using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api.Models.Bms.Entities;

public class programOnAirType
{
    public int prgOnAirTypeId { get; set; }
    public string? prgOnAirTypeName { get; set; }
    public string? prgOnAirTypeCode { get; set; }
    public string? vizrtKey { get; set; }
    public string? description { get; set; }
    public bool? isenable { get; set; }
}


public class ProgramOnAirTypeConfiguration : IEntityTypeConfiguration<programOnAirType>
{
    public void Configure(EntityTypeBuilder<programOnAirType> builder)
    {
        builder.ToTable("programOnAirType");
        builder.HasKey(e => e.prgOnAirTypeId);
        builder.Property(e => e.prgOnAirTypeId).IsRequired().HasColumnName("prgOnAirTypeId").HasColumnType("int");
        builder.Property(e => e.prgOnAirTypeName).HasColumnName("prgOnAirTypeName").HasColumnType("varchar(50)");
        builder.Property(e => e.prgOnAirTypeCode).HasColumnName("prgOnAirTypeCode").HasColumnType("varchar(10)");
        builder.Property(e => e.vizrtKey).HasColumnName("vizrtKey").HasColumnType("varchar(50)");
        builder.Property(e => e.description).HasColumnName("description").HasColumnType("varchar(255)");
        builder.Property(e => e.isenable).HasColumnName("isenable").HasColumnType("bit");
    }
}