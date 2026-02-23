using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api.Models.Bms.Entities;

public class workgroup
{
    public int wgId { get; set; }
    public int? wgTypeId { get; set; }
    public int? wgSubId { get; set; }
    public int? wgWfId { get; set; }
    public int cmpId { get; set; }
    public int? parentId { get; set; }
    public string workgroupName { get; set; }
    public string? positionName { get; set; }
    public int? reportToId { get; set; }
    public bool? isCondDiscount { get; set; }
    public bool? isCondYield { get; set; }
    public double? discountPercent { get; set; }
    public double? totalNetYield { get; set; }
    public string? desciption { get; set; }
    public DateTime dateCreate { get; set; }
    public int createByUserId { get; set; }
    public DateTime? dateUpdate { get; set; }
    public int? updateByUserId { get; set; }
    public bool isenable { get; set; }
    public bool canApproveQT { get; set; }
}


public class WorkgroupGroupConfiguration : IEntityTypeConfiguration<workgroup>
{
    public void Configure(EntityTypeBuilder<workgroup> builder)
    {
        builder.ToTable("workgroup");
        builder.HasKey(e => e.wgId);
        builder.Property(e => e.wgId).IsRequired().HasColumnName("wgId").HasColumnType("int");
        builder.Property(e => e.wgTypeId).HasColumnName("wgTypeId").HasColumnType("int");
        builder.Property(e => e.wgSubId).HasColumnName("wgSubId").HasColumnType("int");
        builder.Property(e => e.wgWfId).HasColumnName("wgWfId").HasColumnType("int");
        builder.Property(e => e.cmpId).IsRequired().HasColumnName("cmpId").HasColumnType("int");
        builder.Property(e => e.parentId).HasColumnName("parentId").HasColumnType("int");
        builder.Property(e => e.workgroupName).IsRequired().HasColumnName("workgroupName").HasColumnType("varchar(80)");
        builder.Property(e => e.positionName).HasColumnName("positionName").HasColumnType("varchar(255)");
        builder.Property(e => e.reportToId).HasColumnName("reportToId").HasColumnType("int");
        builder.Property(e => e.isCondDiscount).HasColumnName("isCondDiscount").HasColumnType("bit");
        builder.Property(e => e.isCondYield).HasColumnName("isCondYield").HasColumnType("bit");
        builder.Property(e => e.discountPercent).HasColumnName("discountPercent").HasColumnType("float");
        builder.Property(e => e.totalNetYield).HasColumnName("totalNetYield").HasColumnType("float");
        builder.Property(e => e.desciption).HasColumnName("desciption").HasColumnType("varchar(500)");
        builder.Property(e => e.dateCreate).IsRequired().HasColumnName("dateCreate").HasColumnType("datetime");
        builder.Property(e => e.createByUserId).IsRequired().HasColumnName("createByUserId").HasColumnType("int");
        builder.Property(e => e.dateUpdate).HasColumnName("dateUpdate").HasColumnType("datetime");
        builder.Property(e => e.updateByUserId).HasColumnName("updateByUserId").HasColumnType("int");
        builder.Property(e => e.isenable).IsRequired().HasColumnName("isenable").HasColumnType("bit");
        builder.Property(e => e.canApproveQT).IsRequired().HasColumnName("canApproveQT").HasColumnType("bit");
    }
}