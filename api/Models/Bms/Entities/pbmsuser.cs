using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api.Models.Bms.Entities;

public class pbmsuser
{
    public int pbmsUserId { get; set; }
    public int? cmpId { get; set; }
    public int usertypeId { get; set; }
    public string username { get; set; }
    public string? usernameAd { get; set; }
    public string? userCode { get; set; }
    public string password { get; set; }
    public string firstName { get; set; }
    public string? lastName { get; set; }
    public string? nickname { get; set; }
    public string? positionName { get; set; }
    public string? navCode { get; set; }
    public string? empCode { get; set; }
    public string? email { get; set; }
    public string? phone { get; set; }
    public string? mobile { get; set; }
    public string? fax { get; set; }
    public string? pbmsUserSignature { get; set; }
    public string? resignReason { get; set; }
    public bool? acAuthorize { get; set; }
    public bool? isActive { get; set; }
    public DateTime dateCreate { get; set; }
    public int? createByUserId { get; set; }
    public DateTime? dateUpdate { get; set; }
    public int? updateByUserId { get; set; }
    public bool isenable { get; set; }
    public bool isConfirm { get; set; }
    public bool? isSync { get; set; }
    public DateTime? syncDate { get; set; }
    public int? AccessFailedCount { get; set; }
    public DateTime? LockoutEnd { get; set; }
    public bool? LockoutEnabled { get; set; }
}

public class PbmsuserConfiguration : IEntityTypeConfiguration<pbmsuser>
{
    public void Configure(EntityTypeBuilder<pbmsuser> builder)
    {
        builder.ToTable("pbmsuser");
        builder.HasKey(e => e.pbmsUserId);
        builder.Property(e => e.pbmsUserId).IsRequired().HasColumnName("pbmsUserId").HasColumnType("int");
        builder.Property(e => e.cmpId).HasColumnName("cmpId").HasColumnType("int");
        builder.Property(e => e.usertypeId).IsRequired().HasColumnName("usertypeId").HasColumnType("int");
        builder.Property(e => e.username).IsRequired().HasColumnName("username").HasColumnType("varchar(80)");
        builder.Property(e => e.usernameAd).HasColumnName("usernameAd").HasColumnType("varchar(80)");
        builder.Property(e => e.userCode).HasColumnName("userCode").HasColumnType("varchar(80)");
        builder.Property(e => e.password).IsRequired().HasColumnName("password").HasColumnType("varchar(255)");
        builder.Property(e => e.firstName).IsRequired().HasColumnName("firstName").HasColumnType("varchar(80)");
        builder.Property(e => e.lastName).HasColumnName("lastName").HasColumnType("varchar(80)");
        builder.Property(e => e.nickname).HasColumnName("nickname").HasColumnType("varchar(80)");
        builder.Property(e => e.positionName).HasColumnName("positionName").HasColumnType("varchar(80)");
        builder.Property(e => e.navCode).HasColumnName("navCode").HasColumnType("nchar(10)");
        builder.Property(e => e.empCode).HasColumnName("empCode").HasColumnType("varchar(50)");
        builder.Property(e => e.email).HasColumnName("email").HasColumnType("varchar(50)");
        builder.Property(e => e.phone).HasColumnName("phone").HasColumnType("varchar(50)");
        builder.Property(e => e.mobile).HasColumnName("mobile").HasColumnType("varchar(50)");
        builder.Property(e => e.fax).HasColumnName("fax").HasColumnType("varchar(20)");
        builder.Property(e => e.pbmsUserSignature).HasColumnName("pbmsUserSignature").HasColumnType("varchar(255)");
        builder.Property(e => e.resignReason).HasColumnName("resignReason").HasColumnType("varchar(255)");
        builder.Property(e => e.acAuthorize).HasColumnName("acAuthorize").HasColumnType("bit");
        builder.Property(e => e.isActive).HasColumnName("isActive").HasColumnType("bit");
        builder.Property(e => e.dateCreate).IsRequired().HasColumnName("dateCreate").HasColumnType("datetime");
        builder.Property(e => e.createByUserId).HasColumnName("createByUserId").HasColumnType("int");
        builder.Property(e => e.dateUpdate).HasColumnName("dateUpdate").HasColumnType("datetime");
        builder.Property(e => e.updateByUserId).HasColumnName("updateByUserId").HasColumnType("int");
        builder.Property(e => e.isenable).IsRequired().HasColumnName("isenable").HasColumnType("bit");
        builder.Property(e => e.isConfirm).IsRequired().HasColumnName("isConfirm").HasColumnType("bit");
        builder.Property(e => e.isSync).HasColumnName("isSync").HasColumnType("bit");
        builder.Property(e => e.syncDate).HasColumnName("syncDate").HasColumnType("datetime");
        builder.Property(e => e.AccessFailedCount).HasColumnName("AccessFailedCount").HasColumnType("int");
        builder.Property(e => e.LockoutEnd).HasColumnName("LockoutEnd").HasColumnType("datetime");
        builder.Property(e => e.LockoutEnabled).HasColumnName("LockoutEnabled").HasColumnType("bit");
    }
}