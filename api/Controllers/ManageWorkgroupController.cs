using api.Data;
using api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class ManageWorkgroupController(BmsDataContext context, SearchService searchService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetWorkgroup()
    {
        var data = await searchService.GetWorkgroupTypeSelectListItems();
        return Ok(data);
    }
    
    [HttpGet]
    public async Task<IActionResult> GetTeamGroup()
    {
        var data = await searchService.GetTeamGroupSelectListItems(isSearch: false);
        return Ok(data);
    }
    
    [HttpGet]
    public async Task<IActionResult> GetTeamGroupReport()
    {
        var data = await searchService.GetTeamGroupReportSelectListItems(isSearch: false);
        return Ok(data);
    }
    
    [HttpPost]
    public async Task<IActionResult> SearchWorkgroupData([FromBody] SearchWorkgroupRequest request)
    {
        var workgroupName = (request.workgroupName ?? "").Trim();
        
        var data = await (
            from a in context.workgroups
            join b in context.workgroups on a.parentId equals b.wgId into bLeftJoin
            from b in bLeftJoin.DefaultIfEmpty()
            join c in context.workgroups  on a.reportToId equals c.wgId into cLeftJoin
            from c in cLeftJoin.DefaultIfEmpty()
            where a.isenable == true
            where a.workgroupName.Contains(workgroupName)
            select new
            {
                a.wgId,
                a.cmpId,
                a.workgroupName,
                parentWorkgroupName = b == null ? "ไม่ระบุ" : b.workgroupName,
                reportToWorkgroupName = c == null ? "ไม่ระบุ" : c.workgroupName
            }
        ).ToListAsync();
        
        return Ok(data);
    }
    
    [HttpPost]
    public async Task<IActionResult> SaveWorkgroupData([FromBody] SaveWorkgroupRequest request)
    {
        
        
        return Ok(new { message = "บันทึกข้อมูลสำเร็จ", request });
    }
    
    public class SaveWorkgroupRequest
    {
        public string workgroupName { get; set; } = string.Empty;
        public string position { get; set; } = string.Empty;
        public int wgTypeId { get; set; }
        public int teamGroupId { get; set; }
        public int teamGroupReportId { get; set; }
        public string description { get; set; } = string.Empty;
        
        public List<WorkgroupViewMember> wgViewMembers { get; set; } = new List<WorkgroupViewMember>();
    }

    public class WorkgroupViewMember
    {
        public int wgIdView { get; set; }
    }
    
    public class SearchWorkgroupRequest
    {
        public string? workgroupName { get; set; }
    }
}