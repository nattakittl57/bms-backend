using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
// ReSharper disable All
#pragma warning disable CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.

namespace api.Models.Bms.Entities;

public class station
{
    public int stationId { get; set; }
    public int cmpId { get; set; }
    public int stationTypeId { get; set; }
    public string stationLogo { get; set; }
    public string stationName { get; set; }
    public string? stationCode { get; set; }
    public TimeSpan? stationTimeStart { get; set; }
    public TimeSpan? stationTimeEnd { get; set; }
    public string? description { get; set; }
    public string? shipAddress { get; set; }
    public string? billAddress { get; set; }
    public string? phone { get; set; }
    public string? fax { get; set; }
    public DateTime dateCreate { get; set; }
    public int? createByUserId { get; set; }
    public DateTime? dateUpdate { get; set; }
    public int? updateByUserId { get; set; }
    public bool? isActivate { get; set; }
    public bool isenable { get; set; }
}


public class StationConfiguration : IEntityTypeConfiguration<station>
{
    public void Configure(EntityTypeBuilder<station> builder)
    {
        builder.ToTable("station");
        builder.HasKey(e => e.stationId);
        builder.Property(e => e.stationId).IsRequired().HasColumnName("stationId").HasColumnType("int");
        builder.Property(e => e.cmpId).IsRequired().HasColumnName("cmpId").HasColumnType("int");
        builder.Property(e => e.stationTypeId).IsRequired().HasColumnName("stationTypeId").HasColumnType("int");
        builder.Property(e => e.stationLogo).IsRequired().HasColumnName("stationLogo").HasColumnType("varchar(255)");
        builder.Property(e => e.stationName).IsRequired().HasColumnName("stationName").HasColumnType("varchar(80)");
        builder.Property(e => e.stationCode).HasColumnName("stationCode").HasColumnType("varchar(50)");
        builder.Property(e => e.stationTimeStart).HasColumnName("stationTimeStart").HasColumnType("time");
        builder.Property(e => e.stationTimeEnd).HasColumnName("stationTimeEnd").HasColumnType("time");
        builder.Property(e => e.description).HasColumnName("description").HasColumnType("varchar(255)");
        builder.Property(e => e.shipAddress).HasColumnName("shipAddress").HasColumnType("varchar(500)");
        builder.Property(e => e.billAddress).HasColumnName("billAddress").HasColumnType("varchar(500)");
        builder.Property(e => e.phone).HasColumnName("phone").HasColumnType("varchar(20)");
        builder.Property(e => e.fax).HasColumnName("fax").HasColumnType("varchar(20)");
        builder.Property(e => e.dateCreate).IsRequired().HasColumnName("dateCreate").HasColumnType("datetime");
        builder.Property(e => e.createByUserId).HasColumnName("createByUserId").HasColumnType("int");
        builder.Property(e => e.dateUpdate).HasColumnName("dateUpdate").HasColumnType("datetime");
        builder.Property(e => e.updateByUserId).HasColumnName("updateByUserId").HasColumnType("int");
        builder.Property(e => e.isActivate).HasColumnName("isActivate").HasColumnType("bit");
        builder.Property(e => e.isenable).IsRequired().HasColumnName("isenable").HasColumnType("bit");
    }
}