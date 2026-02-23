using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api.Models.Bms.Entities;

public class programCategory
{
    public int prgCateId { get; set; }
    public string? prgCateCode { get; set; }
    public string? prgCateAccountCode { get; set; }
    public string? prgCateName { get; set; }
    public string? description { get; set; }
    public string? color { get; set; }
    public string? vizrtKey { get; set; }
    public bool? isCommercial { get; set; }
    public DateTime? dateCreate { get; set; }
    public int? createByUserId { get; set; }
    public DateTime? dateUpdate { get; set; }
    public int? updateByUserId { get; set; }
    public bool? isenable { get; set; }
    public bool? isdefault { get; set; }
}

public class ProgramCategoryConfiguration : IEntityTypeConfiguration<programCategory>
{
    public void Configure(EntityTypeBuilder<programCategory> builder)
    {
        builder.ToTable("programCategory");
        builder.HasKey(e => e.prgCateId);
        builder.Property(e => e.prgCateId).IsRequired().HasColumnName("prgCateId").HasColumnType("int");
        builder.Property(e => e.prgCateCode).HasColumnName("prgCateCode").HasColumnType("varchar(10)");
        builder.Property(e => e.prgCateAccountCode).HasColumnName("prgCateAccountCode").HasColumnType("varchar(2)");
        builder.Property(e => e.prgCateName).HasColumnName("prgCateName").HasColumnType("varchar(100)");
        builder.Property(e => e.description).HasColumnName("description").HasColumnType("varchar(255)");
        builder.Property(e => e.color).HasColumnName("color").HasColumnType("varchar(10)");
        builder.Property(e => e.vizrtKey).HasColumnName("vizrtKey").HasColumnType("varchar(20)");
        builder.Property(e => e.isCommercial).HasColumnName("isCommercial").HasColumnType("bit");
        builder.Property(e => e.dateCreate).HasColumnName("dateCreate").HasColumnType("datetime");
        builder.Property(e => e.createByUserId).HasColumnName("createByUserId").HasColumnType("int");
        builder.Property(e => e.dateUpdate).HasColumnName("dateUpdate").HasColumnType("datetime");
        builder.Property(e => e.updateByUserId).HasColumnName("updateByUserId").HasColumnType("int");
        builder.Property(e => e.isenable).HasColumnName("isenable").HasColumnType("bit");
        builder.Property(e => e.isdefault).HasColumnName("isdefault").HasColumnType("bit");
    }
}