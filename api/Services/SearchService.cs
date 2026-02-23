using api.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace api.Services;

public class SearchService(BmsDataContext context)
{
    public async Task<List<SelectListItem>> GetWorkgroupTypeSelectListItems()
    {
        var data = await (
            from a in context.workgroupTypes
            where a.isenable == true
            select new SelectListItem()
            {
                Value = a.wgTypeId.ToString(),
                Text = a.wgTypeName,
            }
        ).ToListAsync();
        
        return data;
    }
    public async Task<List<SelectListItem>> GetTeamGroupSelectListItems(bool isShowAll = true, bool isSearch = true)
    {
        var data = await (
            from a in context.manageTeamGroups
            join b in context.manageViewTeamGroups on a.teamId equals b.teamId
            // where b.wgId == SessionWrapper.wgIdLogin
            where a.isenable == true
            where b.isenable == true
            group new { } by new
            {
                a.teamId,
                a.teamName
            }
            into g
            orderby g.Key.teamName
            select new SelectListItem()
            {
                Value = g.Key.teamId.ToString(),
                Text = g.Key.teamName
            }
        ).ToListAsync();
        
        if (isShowAll)
        {
            data.Insert(0, new SelectListItem
            {
                Text = (isSearch ? "ทั้งหมด" : "ไม่ระบุ"), 
                Value = "0"
            });
        }

        return data;
    }
    public async Task<List<SelectListItem>> GetTeamGroupReportSelectListItems(bool isShowAll = true, bool isSearch = true)
    {
        var data = await (
            from a in context.manageTeamGroupReports
            where a.isenable == true
            select new SelectListItem()
            {
                Value = a.teamId.ToString(),
                Text = a.teamName,
            }
        ).ToListAsync();

        if (isShowAll)
        {
            data.Insert(0, new SelectListItem
            {
                Text = (isSearch ? "ทั้งหมด" : "ไม่ระบุ"),
                Value = "0"
            });
        }
        
        return data;
    }
}