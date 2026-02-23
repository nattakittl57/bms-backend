using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api.Models.Bms.Entities;

public class programMediaContent
{
    public int prgMediaContentId { get; set; }
    public string prgMediaContenCode { get; set; }
    public string prgMediaContenName { get; set; }
    public int episodeNo { get; set; }
    public int episodeAt { get; set; }
    public int mediaTypeId { get; set; }
    public int? prgDetId { get; set; }
    public int prgId { get; set; }
    public int prgPrimaryGrgId { get; set; }
    public int? departmentId { get; set; }
    public int? materialTypeId { get; set; }
    public int? licenseProgramItemId { get; set; }
    public string? prgNameOnAir { get; set; }
    public bool isProgramContinue { get; set; }
    public int? prgSchIdMain { get; set; }
    public DateTime? dateContentStart { get; set; }
    public DateTime? dateContentEnd { get; set; }
    public int? broadcastingFormatId { get; set; }
    public DateTime? dateTapeStart { get; set; }
    public DateTime? dateExpire { get; set; }
    public int? numberOfEpisodes { get; set; }
    public string? location { get; set; }
    public string? contact { get; set; }
    public string? copyrightOwner { get; set; }
    public int copyrightMusicTypeId { get; set; }
    public int copyrightImageTypeId { get; set; }
    public int? tapeSensorStatusId { get; set; }
    public int? tapeStorageStatusId { get; set; }
    public TimeSpan? duration { get; set; }
    public int? txStatusId { get; set; }
    public bool? isdubbed { get; set; }
    public string? soundChannel { get; set; }
    public string? tag { get; set; }
    public string? remark { get; set; }
    public string? customerNote { get; set; }
    public DateTime? dateReceive { get; set; }
    public int? numberOfMemberPerContent { get; set; }
    public bool? isSync { get; set; }
    public bool? isManualUnSync { get; set; }
    public bool? isMamDelete { get; set; }
    public bool? isWaitingUpdateMam { get; set; }
    public bool? onAirSchedule { get; set; }
    public DateTime? dateSync { get; set; }
    public DateTime createAt { get; set; }
    public int createByUserId { get; set; }
    public DateTime? updateAt { get; set; }
    public int? updateByUserId { get; set; }
    public bool isenable { get; set; }
    public string? placeHolderId { get; set; }
}

public class ProgramMediaContentConfiguration : IEntityTypeConfiguration<programMediaContent>
{
    public void Configure(EntityTypeBuilder<programMediaContent> builder)
    {
        builder.ToTable("programMediaContent");
        builder.HasKey(e => e.prgMediaContentId);
        builder.Property(e => e.prgMediaContentId).IsRequired().HasColumnName("prgMediaContentId").HasColumnType("int");
        builder.Property(e => e.prgMediaContenCode).IsRequired().HasColumnName("prgMediaContenCode")
            .HasColumnType("varchar(100)");
        builder.Property(e => e.prgMediaContenName).IsRequired().HasColumnName("prgMediaContenName")
            .HasColumnType("varchar(500)");
        builder.Property(e => e.episodeNo).IsRequired().HasColumnName("episodeNo").HasColumnType("int");
        builder.Property(e => e.episodeAt).IsRequired().HasColumnName("episodeAt").HasColumnType("int");
        builder.Property(e => e.mediaTypeId).IsRequired().HasColumnName("mediaTypeId").HasColumnType("int");
        builder.Property(e => e.prgDetId).HasColumnName("prgDetId").HasColumnType("int");
        builder.Property(e => e.prgId).IsRequired().HasColumnName("prgId").HasColumnType("int");
        builder.Property(e => e.prgPrimaryGrgId).IsRequired().HasColumnName("prgPrimaryGrgId").HasColumnType("int");
        builder.Property(e => e.departmentId).HasColumnName("departmentId").HasColumnType("int");
        builder.Property(e => e.materialTypeId).HasColumnName("materialTypeId").HasColumnType("int");
        builder.Property(e => e.licenseProgramItemId).HasColumnName("licenseProgramItemId").HasColumnType("int");
        builder.Property(e => e.prgNameOnAir).HasColumnName("prgNameOnAir").HasColumnType("varchar(500)");
        builder.Property(e => e.isProgramContinue).IsRequired().HasColumnName("isProgramContinue").HasColumnType("bit");
        builder.Property(e => e.prgSchIdMain).HasColumnName("prgSchIdMain").HasColumnType("int");
        builder.Property(e => e.dateContentStart).HasColumnName("dateContentStart").HasColumnType("datetime");
        builder.Property(e => e.dateContentEnd).HasColumnName("dateContentEnd").HasColumnType("datetime");
        builder.Property(e => e.broadcastingFormatId).HasColumnName("broadcastingFormatId").HasColumnType("int");
        builder.Property(e => e.dateTapeStart).HasColumnName("dateTapeStart").HasColumnType("datetime");
        builder.Property(e => e.dateExpire).HasColumnName("dateExpire").HasColumnType("datetime");
        builder.Property(e => e.numberOfEpisodes).HasColumnName("numberOfEpisodes").HasColumnType("int");
        builder.Property(e => e.location).HasColumnName("location").HasColumnType("varchar(500)");
        builder.Property(e => e.contact).HasColumnName("contact").HasColumnType("varchar(500)");
        builder.Property(e => e.copyrightOwner).HasColumnName("copyrightOwner").HasColumnType("varchar(500)");
        builder.Property(e => e.copyrightMusicTypeId).IsRequired().HasColumnName("copyrightMusicTypeId")
            .HasColumnType("int");
        builder.Property(e => e.copyrightImageTypeId).IsRequired().HasColumnName("copyrightImageTypeId")
            .HasColumnType("int");
        builder.Property(e => e.tapeSensorStatusId).HasColumnName("tapeSensorStatusId").HasColumnType("int");
        builder.Property(e => e.tapeStorageStatusId).HasColumnName("tapeStorageStatusId").HasColumnType("int");
        builder.Property(e => e.duration).HasColumnName("duration").HasColumnType("time");
        builder.Property(e => e.txStatusId).HasColumnName("txStatusId").HasColumnType("int");
        builder.Property(e => e.isdubbed).HasColumnName("isdubbed").HasColumnType("bit");
        builder.Property(e => e.soundChannel).HasColumnName("soundChannel").HasColumnType("varchar(1000)");
        builder.Property(e => e.tag).HasColumnName("tag").HasColumnType("varchar(500)");
        builder.Property(e => e.remark).HasColumnName("remark").HasColumnType("varchar(1000)");
        builder.Property(e => e.customerNote).HasColumnName("customerNote").HasColumnType("varchar(1000)");
        builder.Property(e => e.dateReceive).HasColumnName("dateReceive").HasColumnType("datetime");
        builder.Property(e => e.numberOfMemberPerContent).HasColumnName("numberOfMemberPerContent")
            .HasColumnType("int");
        builder.Property(e => e.isSync).HasColumnName("isSync").HasColumnType("bit");
        builder.Property(e => e.isManualUnSync).HasColumnName("isManualUnSync").HasColumnType("bit");
        builder.Property(e => e.isMamDelete).HasColumnName("isMamDelete").HasColumnType("bit");
        builder.Property(e => e.isWaitingUpdateMam).HasColumnName("isWaitingUpdateMam").HasColumnType("bit");
        builder.Property(e => e.onAirSchedule).HasColumnName("onAirSchedule").HasColumnType("bit");
        builder.Property(e => e.dateSync).HasColumnName("dateSync").HasColumnType("datetime");
        builder.Property(e => e.createAt).IsRequired().HasColumnName("createAt").HasColumnType("datetime");
        builder.Property(e => e.createByUserId).IsRequired().HasColumnName("createByUserId").HasColumnType("int");
        builder.Property(e => e.updateAt).HasColumnName("updateAt").HasColumnType("datetime");
        builder.Property(e => e.updateByUserId).HasColumnName("updateByUserId").HasColumnType("int");
        builder.Property(e => e.isenable).IsRequired().HasColumnName("isenable").HasColumnType("bit");
        builder.Property(e => e.placeHolderId).HasColumnName("placeHolderId").HasColumnType("varchar(255)");
    }
}