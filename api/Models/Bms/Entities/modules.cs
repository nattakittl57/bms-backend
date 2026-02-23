using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api.Models.Bms.Entities;

public class modules
{
    public int moduleId { get; set; }
    public string moduleCode { get; set; }
    public string moduleName { get; set; }
    public string? iconBig { get; set; }
    public string? iconSmall { get; set; }
    public int isAdminModule { get; set; }
    public int ord { get; set; }
    public bool? isenable { get; set; }
}

public class ModulesConfiguration : IEntityTypeConfiguration<modules>
{
    public void Configure(EntityTypeBuilder<modules> builder)
    {
        builder.ToTable("modules");
        builder.HasKey(e => e.moduleId);
        builder.Property(e => e.moduleId).IsRequired().HasColumnName("moduleId").HasColumnType("int");
        builder.Property(e => e.moduleCode).IsRequired().HasColumnName("moduleCode").HasColumnType("varchar(50)");
        builder.Property(e => e.moduleName).IsRequired().HasColumnName("moduleName").HasColumnType("varchar(255)");
        builder.Property(e => e.iconBig).HasColumnName("iconBig").HasColumnType("varchar(255)");
        builder.Property(e => e.iconSmall).HasColumnName("iconSmall").HasColumnType("varchar(255)");
        builder.Property(e => e.isAdminModule).IsRequired().HasColumnName("isAdminModule").HasColumnType("int");
        builder.Property(e => e.ord).IsRequired().HasColumnName("ord").HasColumnType("int");
        builder.Property(e => e.isenable).HasColumnName("isenable").HasColumnType("bit");
    }
}