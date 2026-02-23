using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api.Models.Bms.Stored;

public class stProgramEntrySelect
{
    public int prgId { get; set; }
    public int stationId { get; set; }
    public string? prgCode { get; set; }
    public string? prgName { get; set; }
    public string? prgNameOnAir { get; set; }
    public string? prgConName { get; set; }
    public string? prgCateName { get; set; }
    public string? departmentName { get; set; }
    public string? materialTypeName { get; set; }
    public int? prgCateId { get; set; }
    public DateTime? dateCreate { get; set; }
    public int? prgConId { get; set; }
    public string? prgAccountCode { get; set; }
    public string? stationName { get; set; }
    public int prgMainId { get; set; }
    public int checkPrgMonthly { get; set; }
    public int checkRerun { get; set; }
    public int checkContent { get; set; }
    public bool? isSync { get; set; }
    public string? prgCateNameNbct { get; set; }
    public string? prgOnAirTypeName { get; set; }
}

public class stProgramEntrySelectConfiguration : IEntityTypeConfiguration<stProgramEntrySelect>
{
    public void Configure(EntityTypeBuilder<stProgramEntrySelect> builder)
    {
        builder.HasNoKey();
        builder.ToView(null);
    }
}