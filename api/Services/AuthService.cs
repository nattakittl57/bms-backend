using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using api.Data;
using api.Models.Auth;
using api.Models.Bms.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace api.Services;

public class AuthService
{
    private readonly BmsDataContext _context;
    private readonly IConfiguration _configuration;

    public AuthService(BmsDataContext context, IConfiguration configuration)
    {
        _context = context;
        _configuration = configuration;
    }

    public async Task<LoginResponse?> LoginAsync(LoginRequest request)
    {
        // ค้นหา user จากฐานข้อมูล
        var user = await _context.pbmsusers
            .FirstOrDefaultAsync(u => u.username == request.Username && u.isenable && u.isActive == true);

        if (user == null)
        {
            return null;
        }

        // ตรวจสอบ account lockout
        if (user.LockoutEnabled == true && user.LockoutEnd.HasValue && user.LockoutEnd.Value > DateTime.UtcNow)
        {
            return null;
        }

        // ตรวจสอบ password (สมมติว่าเป็น plain text, ควรใช้ hashed password จริง ๆ)
        if (!VerifyPassword(request.Password, user.password))
        {
            // เพิ่มจำนวนครั้งที่ login ไม่สำเร็จ
            user.AccessFailedCount = (user.AccessFailedCount ?? 0) + 1;

            // ถ้า failed มากกว่า 5 ครั้ง ให้ lock account
            if (user.AccessFailedCount >= 5)
            {
                user.LockoutEnabled = true;
                user.LockoutEnd = DateTime.UtcNow.AddMinutes(30);
            }

            await _context.SaveChangesAsync();
            return null;
        }

        // reset failed count เมื่อ login สำเร็จ
        user.AccessFailedCount = 0;
        user.LockoutEnd = null;
        await _context.SaveChangesAsync();

        // สร้าง JWT token
        var token = GenerateJwtToken(user);
        var refreshToken = GenerateRefreshToken();
        var expiryMinutes = int.Parse(_configuration["JwtSettings:ExpiryMinutes"] ?? "60");

        
        var company = await _context.companies.FindAsync(user.cmpId);
        var companyName = company != null ? company.companyName : null;
        
        return new LoginResponse
        {
            Token = token,
            RefreshToken = refreshToken,
            UserId = user.pbmsUserId,
            Username = user.username,
            FirstName = user.firstName,
            LastName = user.lastName,
            Nickname = user.nickname,
            Email = user.email,
            PositionName = user.positionName,
            UsertypeId = user.usertypeId,
            CmpId = user.cmpId,
            CompanyName = companyName,
            ExpiresAt = DateTime.UtcNow.AddMinutes(expiryMinutes)
        };
    }

    private string GenerateJwtToken(pbmsuser user)
    {
        var secretKey = _configuration["JwtSettings:SecretKey"];
        var issuer = _configuration["JwtSettings:Issuer"];
        var audience = _configuration["JwtSettings:Audience"];
        var expiryMinutes = int.Parse(_configuration["JwtSettings:ExpiryMinutes"] ?? "60");

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey!));
        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, user.username),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim("userId", user.pbmsUserId.ToString()),
            new Claim("username", user.username),
            new Claim("firstName", user.firstName),
            new Claim("lastName", user.lastName ?? ""),
            new Claim("email", user.email ?? ""),
            new Claim("usertypeId", user.usertypeId.ToString())
        };

        var token = new JwtSecurityToken(
            issuer: issuer,
            audience: audience,
            claims: claims,
            expires: DateTime.UtcNow.AddMinutes(expiryMinutes),
            signingCredentials: credentials
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }

    private string GenerateRefreshToken()
    {
        var randomNumber = new byte[32];
        using var rng = RandomNumberGenerator.Create();
        rng.GetBytes(randomNumber);
        return Convert.ToBase64String(randomNumber);
    }

    private bool VerifyPassword(string inputPassword, string storedPassword)
    {
        // ตรวจสอบว่า stored password เป็น BCrypt hash หรือไม่
        // BCrypt hash จะขึ้นต้นด้วย $2a$, $2b$, หรือ $2y$
        if (storedPassword.StartsWith("$2"))
        {
            return BCrypt.Net.BCrypt.Verify(inputPassword, storedPassword);
        }
        
        // ถ้าไม่ใช่ BCrypt hash ให้เปรียบเทียบแบบ plain text (สำหรับข้อมูลเก่า)
        // TODO: ควร migrate password ทั้งหมดให้เป็น BCrypt
        return inputPassword == storedPassword;
    }

    public string HashPassword(string password)
    {
        return BCrypt.Net.BCrypt.HashPassword(password);
    }

    public async Task<pbmsuser?> GetUserByIdAsync(int userId)
    {
        return await _context.pbmsusers
            .FirstOrDefaultAsync(u => u.pbmsUserId == userId && u.isenable && u.isActive == true);
    }

    public async Task<pbmsuser?> GetUserByUsernameAsync(string username)
    {
        return await _context.pbmsusers
            .FirstOrDefaultAsync(u => u.username == username && u.isenable && u.isActive == true);
    }

    public async Task<company?> GetCompanyByIdAsync(int? companyId)
    {
        if (!companyId.HasValue)
            return null;
        return await _context.companies.FindAsync(companyId.Value);
    }

    public async Task<List<MenuWithPermissionDto>> GetUserMenusWithPermissionsAsync(int userId)
    {
        // ดึง modules ทั้งหมดที่ enable
        var modules = await _context.modules
            .Where(m => m.isenable == true)
            .OrderBy(m => m.ord)
            .ToListAsync();

        var result = new List<MenuWithPermissionDto>();

        foreach (var module in modules)
        {
            // ตรวจสอบ permission ของ module
            var modulePermission = await GetMenuPermissionAsync(userId, module.moduleId, true);
            
            // ถ้าไม่มีสิทธิ์ view module นี้ ให้ข้าม
            if (modulePermission.canview == 0)
                continue;

            var moduleDto = new MenuWithPermissionDto
            {
                menuId = module.moduleId,
                moduleId = module.moduleId,
                menuCode = module.moduleCode,
                title = module.moduleName,
                icon = module.iconSmall,
                route = null, // module ไม่มี route
                ord = module.ord,
                parentId = 0,
                isModule = true,
                open = false,
                canview = modulePermission.canview,
                canadd = modulePermission.canadd,
                canedit = modulePermission.canedit,
                candelete = modulePermission.candelete,
                canprint = modulePermission.canprint,
                canexport = modulePermission.canexport,
                children = new List<MenuWithPermissionDto>()
            };

            // ดึง menus ภายใต้ module นี้
            var menus = await _context.modulesmenus
                .Where(m => m.moduleId == module.moduleId && m.isenable == true)
                .OrderBy(m => m.ord)
                .ToListAsync();

            // สร้าง hierarchical structure
            var menuDict = new Dictionary<int, MenuWithPermissionDto>();
            
            foreach (var menu in menus)
            {
                var menuPermission = await GetMenuPermissionAsync(userId, menu.menuId, false);
                
                // ถ้าไม่มีสิทธิ์ view menu นี้ ให้ข้าม
                if (menuPermission.canview == 0)
                    continue;

                var menuDto = new MenuWithPermissionDto
                {
                    menuId = menu.menuId,
                    moduleId = menu.moduleId,
                    menuCode = menu.menuCode,
                    title = menu.menuName,
                    icon = menu.iconSmall,
                    route = !string.IsNullOrEmpty(menu.childCode) ? $"/{menu.childCode}" : null,
                    childCode = menu.childCode,
                    parentId = menu.parentId,
                    ord = menu.ord,
                    isModule = false,
                    open = false,
                    canview = menuPermission.canview,
                    canadd = menuPermission.canadd,
                    canedit = menuPermission.canedit,
                    candelete = menuPermission.candelete,
                    canprint = menuPermission.canprint,
                    canexport = menuPermission.canexport,
                    children = new List<MenuWithPermissionDto>()
                };

                menuDict[menu.menuId] = menuDto;
            }

            // สร้าง tree structure แบบ recursive (รองรับหลายชั้น)
            foreach (var menuDto in menuDict.Values)
            {
                if (menuDto.parentId == 0)
                {
                    // menu ระดับบนสุด เพิ่มเข้า module
                    moduleDto.children.Add(menuDto);
                }
                else if (menuDict.ContainsKey(menuDto.parentId))
                {
                    // menu ที่มี parent เพิ่มเข้า children ของ parent (รองรับชั้นที่ 2, 3, ...)
                    menuDict[menuDto.parentId].children!.Add(menuDto);
                }
            }
            
            // เรียงลำดับ children ตาม ord
            SortMenuChildren(moduleDto.children);

            result.Add(moduleDto);
        }

        return result;
    }

    private void SortMenuChildren(List<MenuWithPermissionDto> menus)
    {
        if (menus == null || menus.Count == 0)
            return;

        // เรียงลำดับตาม ord
        menus.Sort((a, b) => a.ord.CompareTo(b.ord));

        // เรียงลำดับ children แบบ recursive
        foreach (var menu in menus)
        {
            if (menu.children != null && menu.children.Count > 0)
            {
                SortMenuChildren(menu.children);
            }
        }
    }

    private async Task<PermissionDto> GetMenuPermissionAsync(int userId, int menuId, bool isModule)
    {
        // ค่าเริ่มต้นจาก modulesmenu
        var defaultPermission = new PermissionDto();
        
        if (!isModule)
        {
            var menu = await _context.modulesmenus.FindAsync(menuId);
            if (menu != null)
            {
                defaultPermission.canview = menu.canview;
                defaultPermission.canadd = menu.canadd;
                defaultPermission.canedit = menu.canedit;
                defaultPermission.candelete = menu.candelete;
                defaultPermission.canprint = menu.canprint;
                defaultPermission.canexport = menu.canexport;
            }
        }
        else
        {
            // สำหรับ module ให้ default เป็น 1 (มีสิทธิ์ทั้งหมด)
            defaultPermission.canview = 1;
            defaultPermission.canadd = 1;
            defaultPermission.canedit = 1;
            defaultPermission.candelete = 1;
            defaultPermission.canprint = 1;
            defaultPermission.canexport = 1;
        }

        // ตรวจสอบ user permission (มีความสำคัญสูงสุด)
        var userPerm = await _context.userpermissions
            .FirstOrDefaultAsync(up => up.pbmsUserId == userId && up.menuId == menuId && up.isModule == isModule);

        if (userPerm != null)
        {
            return new PermissionDto
            {
                canview = userPerm.canview,
                canadd = userPerm.canadd,
                canedit = userPerm.canedit,
                candelete = userPerm.candelete,
                canprint = userPerm.canprint,
                canexport = userPerm.canexport
            };
        }

        // ตรวจสอบ workgroup permission (ถ้าไม่มี user permission)
        // สมมติว่า user มี usertypeId ที่เป็น wgId
        var user = await _context.pbmsusers.FindAsync(userId);
        if (user != null && user.usertypeId > 0)
        {
            var wgPerm = await _context.workgroupPermissions
                .FirstOrDefaultAsync(wp => wp.wgId == user.usertypeId && wp.menuId == menuId && wp.isModule == isModule);

            if (wgPerm != null)
            {
                return new PermissionDto
                {
                    canview = wgPerm.canview,
                    canadd = wgPerm.canadd,
                    canedit = wgPerm.canedit,
                    candelete = wgPerm.candelete,
                    canprint = wgPerm.canprint,
                    canexport = wgPerm.canexport
                };
            }
        }

        // ถ้าไม่มี permission ที่กำหนดไว้ ใช้ค่าเริ่มต้น
        return defaultPermission;
    }
}

public class MenuWithPermissionDto
{
    // ข้อมูลสำหรับ frontend (ตาม interface MenuItem)
    public string title { get; set; } = string.Empty;
    public string? icon { get; set; }
    public string? route { get; set; }
    public List<MenuWithPermissionDto>? children { get; set; }
    public bool? open { get; set; }
    
    // ข้อมูลเพิ่มเติมสำหรับระบบ
    public int menuId { get; set; }
    public int moduleId { get; set; }
    public string menuCode { get; set; } = string.Empty;
    public string? childCode { get; set; }
    public int parentId { get; set; }
    public int ord { get; set; }
    public bool isModule { get; set; }
    
    // Permission
    public int canview { get; set; }
    public int canadd { get; set; }
    public int canedit { get; set; }
    public int candelete { get; set; }
    public int canprint { get; set; }
    public int canexport { get; set; }
}

public class PermissionDto
{
    public int canview { get; set; }
    public int canadd { get; set; }
    public int canedit { get; set; }
    public int candelete { get; set; }
    public int canprint { get; set; }
    public int canexport { get; set; }
}
