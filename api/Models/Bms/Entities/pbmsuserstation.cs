using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api.Models.Bms.Entities;

public class pbmsuserstation
{
    public int pbmsUserId { get; set; }
    public int stationId { get; set; }
}


public class PbmsuserstationConfiguration : IEntityTypeConfiguration<pbmsuserstation>
{
    public void Configure(EntityTypeBuilder<pbmsuserstation> builder)
    {
        builder.ToTable("pbmsuserstation");
        builder.HasKey(e => e.pbmsUserId);
        builder.HasKey(e => e.stationId);
        builder.Property(e => e.pbmsUserId).IsRequired().HasColumnName("pbmsUserId").HasColumnType("int");
        builder.Property(e => e.stationId).IsRequired().HasColumnName("stationId").HasColumnType("int");
    }
}