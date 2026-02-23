using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api.Models.Bms.Entities;

public class company
{
    public int cmpId { get; set; }
    public string companyLogo { get; set; }
    public string companyName { get; set; }
    public string? companyNameEN { get; set; }
    public string? companyCode { get; set; }
    public string? companyTAXID { get; set; }
    public string? shipAddress { get; set; }
    public string? shipAddressEN { get; set; }
    public string? billAddress { get; set; }
    public string? billAddressEN { get; set; }
    public string? phone { get; set; }
    public string? fax { get; set; }
    public DateTime dateCreate { get; set; }
    public int? createByUserId { get; set; }
    public DateTime? dateUpdate { get; set; }
    public int? updateByUserId { get; set; }
    public bool isenable { get; set; }
}

public class CompanyConfiguration : IEntityTypeConfiguration<company>
{
    public void Configure(EntityTypeBuilder<company> builder)
    {
        builder.ToTable("company");
        builder.HasKey(e => e.cmpId);
        builder.Property(e => e.cmpId).IsRequired().HasColumnName("cmpId").HasColumnType("int");
        builder.Property(e => e.companyLogo).IsRequired().HasColumnName("companyLogo").HasColumnType("varchar(255)");
        builder.Property(e => e.companyName).IsRequired().HasColumnName("companyName").HasColumnType("varchar(255)");
        builder.Property(e => e.companyNameEN).HasColumnName("companyNameEN").HasColumnType("varchar(255)");
        builder.Property(e => e.companyCode).HasColumnName("companyCode").HasColumnType("varchar(50)");
        builder.Property(e => e.companyTAXID).HasColumnName("companyTAXID").HasColumnType("varchar(17)");
        builder.Property(e => e.shipAddress).HasColumnName("shipAddress").HasColumnType("varchar(500)");
        builder.Property(e => e.shipAddressEN).HasColumnName("shipAddressEN").HasColumnType("varchar(500)");
        builder.Property(e => e.billAddress).HasColumnName("billAddress").HasColumnType("varchar(500)");
        builder.Property(e => e.billAddressEN).HasColumnName("billAddressEN").HasColumnType("varchar(500)");
        builder.Property(e => e.phone).HasColumnName("phone").HasColumnType("varchar(50)");
        builder.Property(e => e.fax).HasColumnName("fax").HasColumnType("varchar(50)");
        builder.Property(e => e.dateCreate).IsRequired().HasColumnName("dateCreate").HasColumnType("datetime");
        builder.Property(e => e.createByUserId).HasColumnName("createByUserId").HasColumnType("int");
        builder.Property(e => e.dateUpdate).HasColumnName("dateUpdate").HasColumnType("datetime");
        builder.Property(e => e.updateByUserId).HasColumnName("updateByUserId").HasColumnType("int");
        builder.Property(e => e.isenable).IsRequired().HasColumnName("isenable").HasColumnType("bit");
    }
}