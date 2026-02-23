using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api.Models.Bms.Entities;

public class workgroupType
{
    public int wgTypeId { get; set; }
    public string? wgTypeName { get; set; }
    public bool? isenable { get; set; }
}


public class WorkgroupTypeConfiguration : IEntityTypeConfiguration<workgroupType>
{
    public void Configure(EntityTypeBuilder<workgroupType> builder)
    {
        builder.ToTable("workgroupType");
        builder.HasKey(e => e.wgTypeId);
        builder.Property(e => e.wgTypeId).IsRequired().HasColumnName("wgTypeId").HasColumnType("int");
        builder.Property(e => e.wgTypeName).HasColumnName("wgTypeName").HasColumnType("varchar(255)");
        builder.Property(e => e.isenable).HasColumnName("isenable").HasColumnType("bit");
    }
}