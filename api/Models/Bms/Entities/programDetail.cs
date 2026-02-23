using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api.Models.Bms.Entities;

public class programDetail
{
    public int prgDetId { get; set; }
    public int? prgPrimaryGrgId { get; set; }
    public int? prgId { get; set; }
    public int? licenseProgramItemId { get; set; }
    public int? grpPrgId { get; set; }
    public int? contactDepartmentId { get; set; }
    public DateTime? prgDetStart { get; set; }
    public DateTime? prgDetEnd { get; set; }
    public TimeSpan? prgTimeStart { get; set; }
    public TimeSpan? prgTimeEnd { get; set; }
    public int? breakTotal { get; set; }
    public int? breakNum { get; set; }
    public TimeSpan? breakTime { get; set; }
    public TimeSpan? advTime { get; set; }
    public TimeSpan? promoteTime { get; set; }
    public bool? breakIn { get; set; }
    public bool? breakOut { get; set; }
    public bool? isAllowSpotBreakIn { get; set; }
    public int? contentNum { get; set; }
    public decimal? prgRate { get; set; }
    public double? prgDiscount { get; set; }
    public string? prgNameOnAir { get; set; }
    public string? episodeName { get; set; }
    public string? episodeNameEN { get; set; }
    public int? episodeNo { get; set; }
    public int? numberOfBroadcastEpisode { get; set; }
    public int? numberOfEpisodesAccordingToContract { get; set; }
    public int? numberOfMediaContent { get; set; }
    public int? numberOfEpisodesPerEpisode { get; set; }
    public int? numberOfAdvertisingBreaks { get; set; }
    public bool? isPrgBoxing { get; set; }
    public int? numberOfFights { get; set; }
    public bool? isTitleHead { get; set; }
    public bool? isSeparateHead { get; set; }
    public bool? isTitleEnd { get; set; }
    public bool? isSeparateEnd { get; set; }
    public int? groupRefId { get; set; }
    public bool? isTitleHeadMain { get; set; }
    public bool? isTitleEndMain { get; set; }
    public string? remarkQueue { get; set; }
    public double? minuteTalkProduct { get; set; }
    public bool? isQuota { get; set; }
    public bool? isSplitTime { get; set; }
    public bool? isHideTimeMasterSheet { get; set; }
    public bool? isHideProgramMasterSheet { get; set; }
    public bool? isHideInTVRating { get; set; }
    public bool? isProgramContinue { get; set; }
    public bool? isProgramContinueEpisodeAt { get; set; }
    public bool? isInsertedProgram { get; set; }
    public int? prgDetTypeId { get; set; }
    public bool? week1 { get; set; }
    public bool? week2 { get; set; }
    public bool? week3 { get; set; }
    public bool? week4 { get; set; }
    public bool? week5 { get; set; }
    public bool? week6 { get; set; }
    public bool? mon { get; set; }
    public bool? tue { get; set; }
    public bool? wed { get; set; }
    public bool? thu { get; set; }
    public bool? fri { get; set; }
    public bool? sat { get; set; }
    public bool? sun { get; set; }
    public string? remarkEdit { get; set; }
    public double? averageRating { get; set; }
    public double? pricePerEpisode { get; set; }
    public string? meetingTime { get; set; }
    public DateTime? meetingDate { get; set; }
    public string? descriptionCondition { get; set; }
    public string? descriptionOnAir { get; set; }
    public string? descriptionResolution { get; set; }
    public bool? isGenDescriptionOnAir { get; set; }
    public int? runningNumber { get; set; }
    public DateTime? dateCreate { get; set; }
    public int? createByUserId { get; set; }
    public DateTime? dateUpdate { get; set; }
    public int? updateByUserId { get; set; }
    public bool? cancelProgram { get; set; }
    public bool? isenable { get; set; }
    public bool? isDraft { get; set; }
}

public class ProgramDetailConfiguration : IEntityTypeConfiguration<programDetail>
{
    public void Configure(EntityTypeBuilder<programDetail> builder)
    {
        builder.ToTable("programDetail");
        builder.HasKey(e => e.prgDetId);
        builder.Property(e => e.prgDetId).IsRequired().HasColumnName("prgDetId").HasColumnType("int");
        builder.Property(e => e.prgPrimaryGrgId).HasColumnName("prgPrimaryGrgId").HasColumnType("int");
        builder.Property(e => e.prgId).HasColumnName("prgId").HasColumnType("int");
        builder.Property(e => e.licenseProgramItemId).HasColumnName("licenseProgramItemId").HasColumnType("int");
        builder.Property(e => e.grpPrgId).HasColumnName("grpPrgId").HasColumnType("int");
        builder.Property(e => e.contactDepartmentId).HasColumnName("contactDepartmentId").HasColumnType("int");
        builder.Property(e => e.prgDetStart).HasColumnName("prgDetStart").HasColumnType("datetime");
        builder.Property(e => e.prgDetEnd).HasColumnName("prgDetEnd").HasColumnType("datetime");
        builder.Property(e => e.prgTimeStart).HasColumnName("prgTimeStart").HasColumnType("time");
        builder.Property(e => e.prgTimeEnd).HasColumnName("prgTimeEnd").HasColumnType("time");
        builder.Property(e => e.breakTotal).HasColumnName("breakTotal").HasColumnType("int");
        builder.Property(e => e.breakNum).HasColumnName("breakNum").HasColumnType("int");
        builder.Property(e => e.breakTime).HasColumnName("breakTime").HasColumnType("time");
        builder.Property(e => e.advTime).HasColumnName("advTime").HasColumnType("time");
        builder.Property(e => e.promoteTime).HasColumnName("promoteTime").HasColumnType("time");
        builder.Property(e => e.breakIn).HasColumnName("breakIn").HasColumnType("bit");
        builder.Property(e => e.breakOut).HasColumnName("breakOut").HasColumnType("bit");
        builder.Property(e => e.isAllowSpotBreakIn).HasColumnName("isAllowSpotBreakIn").HasColumnType("bit");
        builder.Property(e => e.contentNum).HasColumnName("contentNum").HasColumnType("int");
        builder.Property(e => e.prgRate).HasColumnName("prgRate").HasColumnType("money");
        builder.Property(e => e.prgDiscount).HasColumnName("prgDiscount").HasColumnType("float");
        builder.Property(e => e.prgNameOnAir).HasColumnName("prgNameOnAir").HasColumnType("varchar(700)");
        builder.Property(e => e.episodeName).HasColumnName("episodeName").HasColumnType("varchar(700)");
        builder.Property(e => e.episodeNameEN).HasColumnName("episodeNameEN").HasColumnType("varchar(700)");
        builder.Property(e => e.episodeNo).HasColumnName("episodeNo").HasColumnType("int");
        builder.Property(e => e.numberOfBroadcastEpisode).HasColumnName("numberOfBroadcastEpisode")
            .HasColumnType("int");
        builder.Property(e => e.numberOfEpisodesAccordingToContract)
            .HasColumnName("numberOfEpisodesAccordingToContract").HasColumnType("int");
        builder.Property(e => e.numberOfMediaContent).HasColumnName("numberOfMediaContent").HasColumnType("int");
        builder.Property(e => e.numberOfEpisodesPerEpisode).HasColumnName("numberOfEpisodesPerEpisode")
            .HasColumnType("int");
        builder.Property(e => e.numberOfAdvertisingBreaks).HasColumnName("numberOfAdvertisingBreaks")
            .HasColumnType("int");
        builder.Property(e => e.isPrgBoxing).HasColumnName("isPrgBoxing").HasColumnType("bit");
        builder.Property(e => e.numberOfFights).HasColumnName("numberOfFights").HasColumnType("int");
        builder.Property(e => e.isTitleHead).HasColumnName("isTitleHead").HasColumnType("bit");
        builder.Property(e => e.isSeparateHead).HasColumnName("isSeparateHead").HasColumnType("bit");
        builder.Property(e => e.isTitleEnd).HasColumnName("isTitleEnd").HasColumnType("bit");
        builder.Property(e => e.isSeparateEnd).HasColumnName("isSeparateEnd").HasColumnType("bit");
        builder.Property(e => e.groupRefId).HasColumnName("groupRefId").HasColumnType("int");
        builder.Property(e => e.isTitleHeadMain).HasColumnName("isTitleHeadMain").HasColumnType("bit");
        builder.Property(e => e.isTitleEndMain).HasColumnName("isTitleEndMain").HasColumnType("bit");
        builder.Property(e => e.remarkQueue).HasColumnName("remarkQueue").HasColumnType("varchar(700)");
        builder.Property(e => e.minuteTalkProduct).HasColumnName("minuteTalkProduct").HasColumnType("float");
        builder.Property(e => e.isQuota).HasColumnName("isQuota").HasColumnType("bit");
        builder.Property(e => e.isSplitTime).HasColumnName("isSplitTime").HasColumnType("bit");
        builder.Property(e => e.isHideTimeMasterSheet).HasColumnName("isHideTimeMasterSheet").HasColumnType("bit");
        builder.Property(e => e.isHideProgramMasterSheet).HasColumnName("isHideProgramMasterSheet")
            .HasColumnType("bit");
        builder.Property(e => e.isHideInTVRating).HasColumnName("isHideInTVRating").HasColumnType("bit");
        builder.Property(e => e.isProgramContinue).HasColumnName("isProgramContinue").HasColumnType("bit");
        builder.Property(e => e.isProgramContinueEpisodeAt).HasColumnName("isProgramContinueEpisodeAt")
            .HasColumnType("bit");
        builder.Property(e => e.isInsertedProgram).HasColumnName("isInsertedProgram").HasColumnType("bit");
        builder.Property(e => e.prgDetTypeId).HasColumnName("prgDetTypeId").HasColumnType("int");
        builder.Property(e => e.week1).HasColumnName("week1").HasColumnType("bit");
        builder.Property(e => e.week2).HasColumnName("week2").HasColumnType("bit");
        builder.Property(e => e.week3).HasColumnName("week3").HasColumnType("bit");
        builder.Property(e => e.week4).HasColumnName("week4").HasColumnType("bit");
        builder.Property(e => e.week5).HasColumnName("week5").HasColumnType("bit");
        builder.Property(e => e.week6).HasColumnName("week6").HasColumnType("bit");
        builder.Property(e => e.mon).HasColumnName("mon").HasColumnType("bit");
        builder.Property(e => e.tue).HasColumnName("tue").HasColumnType("bit");
        builder.Property(e => e.wed).HasColumnName("wed").HasColumnType("bit");
        builder.Property(e => e.thu).HasColumnName("thu").HasColumnType("bit");
        builder.Property(e => e.fri).HasColumnName("fri").HasColumnType("bit");
        builder.Property(e => e.sat).HasColumnName("sat").HasColumnType("bit");
        builder.Property(e => e.sun).HasColumnName("sun").HasColumnType("bit");
        builder.Property(e => e.remarkEdit).HasColumnName("remarkEdit").HasColumnType("varchar(1000)");
        builder.Property(e => e.averageRating).HasColumnName("averageRating").HasColumnType("float");
        builder.Property(e => e.pricePerEpisode).HasColumnName("pricePerEpisode").HasColumnType("float");
        builder.Property(e => e.meetingTime).HasColumnName("meetingTime").HasColumnType("varchar(250)");
        builder.Property(e => e.meetingDate).HasColumnName("meetingDate").HasColumnType("datetime");
        builder.Property(e => e.descriptionCondition).HasColumnName("descriptionCondition")
            .HasColumnType("varchar(1000)");
        builder.Property(e => e.descriptionOnAir).HasColumnName("descriptionOnAir").HasColumnType("varchar(1000)");
        builder.Property(e => e.descriptionResolution).HasColumnName("descriptionResolution")
            .HasColumnType("varchar(1000)");
        builder.Property(e => e.isGenDescriptionOnAir).HasColumnName("isGenDescriptionOnAir").HasColumnType("bit");
        builder.Property(e => e.runningNumber).HasColumnName("runningNumber").HasColumnType("int");
        builder.Property(e => e.dateCreate).HasColumnName("dateCreate").HasColumnType("datetime");
        builder.Property(e => e.createByUserId).HasColumnName("createByUserId").HasColumnType("int");
        builder.Property(e => e.dateUpdate).HasColumnName("dateUpdate").HasColumnType("datetime");
        builder.Property(e => e.updateByUserId).HasColumnName("updateByUserId").HasColumnType("int");
        builder.Property(e => e.cancelProgram).HasColumnName("cancelProgram").HasColumnType("bit");
        builder.Property(e => e.isenable).HasColumnName("isenable").HasColumnType("bit");
        builder.Property(e => e.isDraft).HasColumnName("isDraft").HasColumnType("bit");
    }
}