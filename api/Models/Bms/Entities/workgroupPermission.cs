using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api.Models.Bms.Entities;

public class workgroupPermission
{
    public int rolePermId { get; set; }
    public int wgId { get; set; }
    public int menuId { get; set; }
    public bool? isModule { get; set; }
    public DateTime dateCreate { get; set; }
    public int createByUserId { get; set; }
    public DateTime? dateUpdate { get; set; }
    public int? updateByUserId { get; set; }
    public int canview { get; set; }
    public int canadd { get; set; }
    public int canedit { get; set; }
    public int candelete { get; set; }
    public int canprint { get; set; }
    public int canexport { get; set; }
}


public class WorkgroupPermissionConfiguration : IEntityTypeConfiguration<workgroupPermission>
{
    public void Configure(EntityTypeBuilder<workgroupPermission> builder)
    {
        builder.ToTable("workgroupPermission");
        builder.HasKey(e => e.rolePermId);
        builder.Property(e => e.rolePermId).IsRequired().HasColumnName("rolePermId").HasColumnType("int");
        builder.Property(e => e.wgId).IsRequired().HasColumnName("wgId").HasColumnType("int");
        builder.Property(e => e.menuId).IsRequired().HasColumnName("menuId").HasColumnType("int");
        builder.Property(e => e.isModule).HasColumnName("isModule").HasColumnType("bit");
        builder.Property(e => e.dateCreate).IsRequired().HasColumnName("dateCreate").HasColumnType("datetime");
        builder.Property(e => e.createByUserId).IsRequired().HasColumnName("createByUserId").HasColumnType("int");
        builder.Property(e => e.dateUpdate).HasColumnName("dateUpdate").HasColumnType("datetime");
        builder.Property(e => e.updateByUserId).HasColumnName("updateByUserId").HasColumnType("int");
        builder.Property(e => e.canview).IsRequired().HasColumnName("canview").HasColumnType("int");
        builder.Property(e => e.canadd).IsRequired().HasColumnName("canadd").HasColumnType("int");
        builder.Property(e => e.canedit).IsRequired().HasColumnName("canedit").HasColumnType("int");
        builder.Property(e => e.candelete).IsRequired().HasColumnName("candelete").HasColumnType("int");
        builder.Property(e => e.canprint).IsRequired().HasColumnName("canprint").HasColumnType("int");
        builder.Property(e => e.canexport).IsRequired().HasColumnName("canexport").HasColumnType("int");
    }
}