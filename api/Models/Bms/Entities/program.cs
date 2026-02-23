using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api.Models.Bms.Entities;

public class program
{
    public int prgId { get; set; }
    public int stationId { get; set; }
    public int? prgConId { get; set; }
    public int? custId { get; set; }
    public string? plaY_ID { get; set; }
    public string? prgCode { get; set; }
    public string? prgAccountCode { get; set; }
    public string? prgName { get; set; }
    public string? prgNameEN { get; set; }
    public string? prgNameOnAir { get; set; }
    public string? prgFileCode { get; set; }
    public string? prgRefCode { get; set; }
    public int? prgOnAirTypeId { get; set; }
    public int? prgMainId { get; set; }
    public int? prgCateId { get; set; }
    public int? prgCateNbctId { get; set; }
    public int? prgSourceTypeNbctId { get; set; }
    public int? prgRateId { get; set; }
    public bool? isCommercial { get; set; }
    public bool? isOnline { get; set; }
    public bool? isDisabledperson { get; set; }
    public bool? isDubbing { get; set; }
    public string? discription { get; set; }
    public int? departmentId { get; set; }
    public int? materialTypeId { get; set; }
    public int? geoBlockTvId { get; set; }
    public int? geoBlockContentTvId { get; set; }
    public DateTime? dateExpired { get; set; }
    public string? shortSynopsisTH { get; set; }
    public string? shortSynopsisEN { get; set; }
    public string? synopsisTH { get; set; }
    public string? synopsisEN { get; set; }
    public string? keyword { get; set; }
    public string? tags { get; set; }
    public string? opus { get; set; }
    public string? tvScript { get; set; }
    public string? directing { get; set; }
    public string? producer { get; set; }
    public DateTime? dateCreate { get; set; }
    public int? createByUserId { get; set; }
    public DateTime? dateUpdate { get; set; }
    public int? updateByUserId { get; set; }
    public bool? isenable { get; set; }
    public bool? isSync { get; set; }
    public string? placeHolderId { get; set; }
}

public class ProgramConfiguration : IEntityTypeConfiguration<program>
{
    public void Configure(EntityTypeBuilder<program> builder)
    {
        builder.ToTable("program");
        builder.HasKey(e => e.prgId);
        builder.Property(e => e.prgId).IsRequired().HasColumnName("prgId").HasColumnType("int");
        builder.Property(e => e.stationId).IsRequired().HasColumnName("stationId").HasColumnType("int");
        builder.Property(e => e.prgConId).HasColumnName("prgConId").HasColumnType("int");
        builder.Property(e => e.custId).HasColumnName("custId").HasColumnType("int");
        builder.Property(e => e.plaY_ID).HasColumnName("plaY_ID").HasColumnType("varchar(50)");
        builder.Property(e => e.prgCode).HasColumnName("prgCode").HasColumnType("varchar(50)");
        builder.Property(e => e.prgAccountCode).HasColumnName("prgAccountCode").HasColumnType("varchar(50)");
        builder.Property(e => e.prgName).HasColumnName("prgName").HasColumnType("varchar(700)");
        builder.Property(e => e.prgNameEN).HasColumnName("prgNameEN").HasColumnType("varchar(700)");
        builder.Property(e => e.prgNameOnAir).HasColumnName("prgNameOnAir").HasColumnType("varchar(700)");
        builder.Property(e => e.prgFileCode).HasColumnName("prgFileCode").HasColumnType("varchar(50)");
        builder.Property(e => e.prgRefCode).HasColumnName("prgRefCode").HasColumnType("varchar(50)");
        builder.Property(e => e.prgOnAirTypeId).HasColumnName("prgOnAirTypeId").HasColumnType("int");
        builder.Property(e => e.prgMainId).HasColumnName("prgMainId").HasColumnType("int");
        builder.Property(e => e.prgCateId).HasColumnName("prgCateId").HasColumnType("int");
        builder.Property(e => e.prgCateNbctId).HasColumnName("prgCateNbctId").HasColumnType("int");
        builder.Property(e => e.prgSourceTypeNbctId).HasColumnName("prgSourceTypeNbctId").HasColumnType("int");
        builder.Property(e => e.prgRateId).HasColumnName("prgRateId").HasColumnType("int");
        builder.Property(e => e.isCommercial).HasColumnName("isCommercial").HasColumnType("bit");
        builder.Property(e => e.isOnline).HasColumnName("isOnline").HasColumnType("bit");
        builder.Property(e => e.isDisabledperson).HasColumnName("isDisabledperson").HasColumnType("bit");
        builder.Property(e => e.isDubbing).HasColumnName("isDubbing").HasColumnType("bit");
        builder.Property(e => e.discription).HasColumnName("discription").HasColumnType("text");
        builder.Property(e => e.departmentId).HasColumnName("departmentId").HasColumnType("int");
        builder.Property(e => e.materialTypeId).HasColumnName("materialTypeId").HasColumnType("int");
        builder.Property(e => e.geoBlockTvId).HasColumnName("geoBlockTvId").HasColumnType("int");
        builder.Property(e => e.geoBlockContentTvId).HasColumnName("geoBlockContentTvId").HasColumnType("int");
        builder.Property(e => e.dateExpired).HasColumnName("dateExpired").HasColumnType("datetime");
        builder.Property(e => e.shortSynopsisTH).HasColumnName("shortSynopsisTH").HasColumnType("varchar(4000)");
        builder.Property(e => e.shortSynopsisEN).HasColumnName("shortSynopsisEN").HasColumnType("varchar(4000)");
        builder.Property(e => e.synopsisTH).HasColumnName("synopsisTH").HasColumnType("varchar(700)");
        builder.Property(e => e.synopsisEN).HasColumnName("synopsisEN").HasColumnType("varchar(700)");
        builder.Property(e => e.keyword).HasColumnName("keyword").HasColumnType("varchar(700)");
        builder.Property(e => e.tags).HasColumnName("tags").HasColumnType("varchar(700)");
        builder.Property(e => e.opus).HasColumnName("opus").HasColumnType("varchar(700)");
        builder.Property(e => e.tvScript).HasColumnName("tvScript").HasColumnType("varchar(700)");
        builder.Property(e => e.directing).HasColumnName("directing").HasColumnType("varchar(700)");
        builder.Property(e => e.producer).HasColumnName("producer").HasColumnType("varchar(700)");
        builder.Property(e => e.dateCreate).HasColumnName("dateCreate").HasColumnType("datetime");
        builder.Property(e => e.createByUserId).HasColumnName("createByUserId").HasColumnType("int");
        builder.Property(e => e.dateUpdate).HasColumnName("dateUpdate").HasColumnType("datetime");
        builder.Property(e => e.updateByUserId).HasColumnName("updateByUserId").HasColumnType("int");
        builder.Property(e => e.isenable).HasColumnName("isenable").HasColumnType("bit");
        builder.Property(e => e.isSync).HasColumnName("isSync").HasColumnType("bit");
        builder.Property(e => e.placeHolderId).HasColumnName("placeHolderId").HasColumnType("varchar(255)");
    }
}