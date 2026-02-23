using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api.Models.Bms.Entities;

public class modulesmenu
{
    public int menuId { get; set; }
    public int moduleId { get; set; }
    public string menuCode { get; set; }
    public string menuName { get; set; }
    public string childCode { get; set; }
    public int parentId { get; set; }
    public string? iconBig { get; set; }
    public string? iconSmall { get; set; }
    public bool? isenable { get; set; }
    public int canview { get; set; }
    public int canadd { get; set; }
    public int canedit { get; set; }
    public int candelete { get; set; }
    public int canprint { get; set; }
    public int canexport { get; set; }
    public int ord { get; set; }
}

public class ModulesmenuConfiguration : IEntityTypeConfiguration<modulesmenu>
{
    public void Configure(EntityTypeBuilder<modulesmenu> builder)
    {
        builder.ToTable("modulesmenu");
        builder.HasKey(e => e.menuId);
        builder.Property(e => e.menuId).IsRequired().HasColumnName("menuId").HasColumnType("int");
        builder.Property(e => e.moduleId).IsRequired().HasColumnName("moduleId").HasColumnType("int");
        builder.Property(e => e.menuCode).IsRequired().HasColumnName("menuCode").HasColumnType("varchar(50)");
        builder.Property(e => e.menuName).IsRequired().HasColumnName("menuName").HasColumnType("varchar(255)");
        builder.Property(e => e.childCode).IsRequired().HasColumnName("childCode").HasColumnType("varchar(50)");
        builder.Property(e => e.parentId).IsRequired().HasColumnName("parentId").HasColumnType("int");
        builder.Property(e => e.iconBig).HasColumnName("iconBig").HasColumnType("varchar(255)");
        builder.Property(e => e.iconSmall).HasColumnName("iconSmall").HasColumnType("varchar(255)");
        builder.Property(e => e.isenable).HasColumnName("isenable").HasColumnType("bit");
        builder.Property(e => e.canview).IsRequired().HasColumnName("canview").HasColumnType("int");
        builder.Property(e => e.canadd).IsRequired().HasColumnName("canadd").HasColumnType("int");
        builder.Property(e => e.canedit).IsRequired().HasColumnName("canedit").HasColumnType("int");
        builder.Property(e => e.candelete).IsRequired().HasColumnName("candelete").HasColumnType("int");
        builder.Property(e => e.canprint).IsRequired().HasColumnName("canprint").HasColumnType("int");
        builder.Property(e => e.canexport).IsRequired().HasColumnName("canexport").HasColumnType("int");
        builder.Property(e => e.ord).IsRequired().HasColumnName("ord").HasColumnType("int");
    }
}