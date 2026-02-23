using api.Models.Auth;
using api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class AuthController : ControllerBase
{
    private readonly AuthService _authService;

    public AuthController(AuthService authService)
    {
        _authService = authService;
    }

    /// <summary>
    /// Login endpoint - รับ username และ password แล้วคืน JWT token
    /// </summary>
    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        if (string.IsNullOrEmpty(request.Username) || string.IsNullOrEmpty(request.Password))
        {
            return BadRequest(new { message = "Username และ Password จำเป็นต้องระบุ" });
        }

        var result = await _authService.LoginAsync(request);

        if (result == null)
        {
            return Unauthorized(new { message = "Username หรือ Password ไม่ถูกต้อง" });
        }

        return Ok(result);
    }

    /// <summary>
    /// ตรวจสอบ token ปัจจุบัน
    /// </summary>
    [HttpGet]
    [Authorize]
    public IActionResult VerifyToken()
    {
        var userId = User.FindFirst("userId")?.Value;
        var username = User.FindFirst("username")?.Value;

        return Ok(new
        {
            valid = true,
            userId,
            username
        });
    }

    /// <summary>
    /// ดึงข้อมูล user profile ของผู้ใช้ที่ login อยู่
    /// </summary>
    [HttpGet]
    [Authorize]
    public async Task<IActionResult> GetProfile()
    {
        var userIdClaim = User.FindFirst("userId")?.Value;
        
        if (userIdClaim == null || !int.TryParse(userIdClaim, out var userId))
        {
            return Unauthorized(new { message = "Invalid token" });
        }

        var user = await _authService.GetUserByIdAsync(userId);

        if (user == null)
        {
            return NotFound(new { message = "User not found" });
        }

        // ดึงข้อมูล company
        var company = await _authService.GetCompanyByIdAsync(user.cmpId);
        var companyName = company?.companyName;

        return Ok(new
        {
            userId = user.pbmsUserId,
            username = user.username,
            firstName = user.firstName,
            lastName = user.lastName,
            nickname = user.nickname,
            email = user.email,
            phone = user.phone,
            mobile = user.mobile,
            positionName = user.positionName,
            usertypeId = user.usertypeId,
            cmpId = user.cmpId,
            companyName = companyName
        });
    }

    /// <summary>
    /// ดึงข้อมูล menu พร้อม permission ของผู้ใช้ที่ login อยู่
    /// </summary>
    [HttpGet]
    [Authorize]
    public async Task<IActionResult> GetMenus()
    {
        var userIdClaim = User.FindFirst("userId")?.Value;
        
        if (userIdClaim == null || !int.TryParse(userIdClaim, out var userId))
        {
            return Unauthorized(new { message = "Invalid token" });
        }

        var menus = await _authService.GetUserMenusWithPermissionsAsync(userId);

        return Ok(menus);
    }

    /// <summary>
    /// Logout - ออกจากระบบ
    /// </summary>
    [HttpPost]
    [Authorize]
    public IActionResult Logout()
    {
        // สำหรับ JWT-based authentication, logout ทำได้โดยการลบ token ฝั่ง client
        // แต่ถ้าต้องการ invalidate token บน server สามารถเพิ่ม blacklist ได้
        
        var userId = User.FindFirst("userId")?.Value;
        var username = User.FindFirst("username")?.Value;

        // Log logout activity (optional)
        // TODO: บันทึก logout activity ลงฐานข้อมูล

        return Ok(new
        {
            message = "Logout สำเร็จ",
            userId,
            username,
            logoutAt = DateTime.UtcNow
        });
    }
}