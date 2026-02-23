using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api.Models.Bms.Entities;

public class manageViewTeamGroup
{
    public int viewTeamId { get; set; }
    public int teamId { get; set; }
    public int wgId { get; set; }
    public DateTime dateCreate { get; set; }
    public int createByUserId { get; set; }
    public DateTime? dateUpdate { get; set; }
    public int? updateByUserId { get; set; }
    public bool isenable { get; set; }
}


public class ManageViewTeamGroupConfiguration : IEntityTypeConfiguration<manageViewTeamGroup>
{
    public void Configure(EntityTypeBuilder<manageViewTeamGroup> builder)
    {
        builder.ToTable("manageViewTeamGroup");
        builder.HasKey(e => e.viewTeamId);
        builder.Property(e => e.viewTeamId).IsRequired().HasColumnName("viewTeamId").HasColumnType("int");
        builder.Property(e => e.teamId).IsRequired().HasColumnName("teamId").HasColumnType("int");
        builder.Property(e => e.wgId).IsRequired().HasColumnName("wgId").HasColumnType("int");
        builder.Property(e => e.dateCreate).IsRequired().HasColumnName("dateCreate").HasColumnType("datetime");
        builder.Property(e => e.createByUserId).IsRequired().HasColumnName("createByUserId").HasColumnType("int");
        builder.Property(e => e.dateUpdate).HasColumnName("dateUpdate").HasColumnType("datetime");
        builder.Property(e => e.updateByUserId).HasColumnName("updateByUserId").HasColumnType("int");
        builder.Property(e => e.isenable).IsRequired().HasColumnName("isenable").HasColumnType("bit");
    }
}