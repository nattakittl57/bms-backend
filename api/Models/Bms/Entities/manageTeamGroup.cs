using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api.Models.Bms.Entities;

public class manageTeamGroup
{
    public int teamId { get; set; }
    public string teamName { get; set; }
    public DateTime dateCreate { get; set; }
    public int createByUserId { get; set; }
    public DateTime? dateUpdate { get; set; }
    public int? updateByUserId { get; set; }
    public bool isenable { get; set; }
}


public class ManageTeamGroupConfiguration : IEntityTypeConfiguration<manageTeamGroup>
{
    public void Configure(EntityTypeBuilder<manageTeamGroup> builder)
    {
        builder.ToTable("manageTeamGroup");
        builder.HasKey(e => e.teamId);
        builder.Property(e => e.teamId).IsRequired().HasColumnName("teamId").HasColumnType("int");
        builder.Property(e => e.teamName).IsRequired().HasColumnName("teamName").HasColumnType("varchar(250)");
        builder.Property(e => e.dateCreate).IsRequired().HasColumnName("dateCreate").HasColumnType("datetime");
        builder.Property(e => e.createByUserId).IsRequired().HasColumnName("createByUserId").HasColumnType("int");
        builder.Property(e => e.dateUpdate).HasColumnName("dateUpdate").HasColumnType("datetime");
        builder.Property(e => e.updateByUserId).HasColumnName("updateByUserId").HasColumnType("int");
        builder.Property(e => e.isenable).IsRequired().HasColumnName("isenable").HasColumnType("bit");
    }
}