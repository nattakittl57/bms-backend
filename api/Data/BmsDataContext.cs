using api.Models.Bms.Entities;
using api.Models.Bms.Stored;
using Microsoft.EntityFrameworkCore;

namespace api.Data;

public class BmsDataContext(DbContextOptions<BmsDataContext> options) : DbContext(options)
{
    /* entities model */
// public DbSet<accountPaymentType> accountPaymentTypes { get; set; }
// public DbSet<accountPriceLevel> accountPriceLevels { get; set; }
// public DbSet<accountStatus> accountStatuss { get; set; }
// public DbSet<accountType> accountTypes { get; set; }
// public DbSet<accountVatType> accountVatTypes { get; set; }
// public DbSet<accountWithholdingTax> accountWithholdingTaxs { get; set; }
// public DbSet<adjustLogTmp> adjustLogTmps { get; set; }
// public DbSet<adjustLogType> adjustLogTypes { get; set; }
// public DbSet<adjustMemberTmp> adjustMemberTmps { get; set; }
// public DbSet<adjustReport> adjustReports { get; set; }
// public DbSet<adjustReportMember> adjustReportMembers { get; set; }
// public DbSet<adjustReportMemberTmp> adjustReportMemberTmps { get; set; }
// public DbSet<adjustReportTmp> adjustReportTmps { get; set; }
// public DbSet<adjustRevenue> adjustRevenues { get; set; }
// public DbSet<adjustScheduleTmp> adjustScheduleTmps { get; set; }
// public DbSet<adminAdjustLog> adminAdjustLogs { get; set; }
//public DbSet<advBreak> advBreaks { get; set; }
// public DbSet<advBreakBackup> advBreakBackups { get; set; }
// public DbSet<advBreakBackupLog> advBreakBackupLogs { get; set; }
// public DbSet<advBreakLog> advBreakLogs { get; set; }
//public DbSet<advBreakOther> advBreakOthers { get; set; }
// public DbSet<advBreakOtherLog> advBreakOtherLogs { get; set; }
// public DbSet<advBreakOthType> advBreakOthTypes { get; set; }
// public DbSet<advBreakType> advBreakTypes { get; set; }
// public DbSet<advCensorStatus> advCensorStatuss { get; set; }
// public DbSet<advertisement> advertisements { get; set; }
// public DbSet<advertisementLog> advertisementLogs { get; set; }
// public DbSet<advertisementOriginType> advertisementOriginTypes { get; set; }
// public DbSet<advertisementSyncImportLog> advertisementSyncImportLogs { get; set; }
// public DbSet<advInvoice> advInvoices { get; set; }
// public DbSet<advSchedule> advSchedules { get; set; }
// public DbSet<advScheduleLog> advScheduleLogs { get; set; }
// public DbSet<advScheduleLoosePromote> advScheduleLoosePromotes { get; set; }
// public DbSet<advSchedulePromote> advSchedulePromotes { get; set; }
// public DbSet<advSchedulePromoteBackup> advSchedulePromoteBackups { get; set; }
// public DbSet<advScheduleTmp> advScheduleTmps { get; set; }
// public DbSet<advStatus> advStatuss { get; set; }
// public DbSet<advType> advTypes { get; set; }
// public DbSet<agreementStatus> agreementStatuss { get; set; }
// public DbSet<airPlayLog> airPlayLogs { get; set; }
// public DbSet<airPlayLogSchedule> airPlayLogSchedules { get; set; }
// public DbSet<airPlayReport> airPlayReports { get; set; }
// public DbSet<airplayStatus> airplayStatuss { get; set; }
// public DbSet<airtimeRate> airtimeRates { get; set; }
// public DbSet<airtimeRateDetail> airtimeRateDetails { get; set; }
// public DbSet<airtimeRateDetailTmp> airtimeRateDetailTmps { get; set; }
// public DbSet<airtimeRateTmp> airtimeRateTmps { get; set; }
// public DbSet<apiMapUserProgram> apiMapUserPrograms { get; set; }
// public DbSet<apiProgram> apiPrograms { get; set; }
// public DbSet<apiUser> apiUsers { get; set; }
// public DbSet<appoveBrandingOrderOther> appoveBrandingOrderOthers { get; set; }
// public DbSet<appoveBrandingrOrderOtherLog> appoveBrandingrOrderOtherLogs { get; set; }
// public DbSet<appoveBrandingType> appoveBrandingTypes { get; set; }
// public DbSet<approveBrandGroupUser> approveBrandGroupUsers { get; set; }
// public DbSet<approveBrandGroupUserMember> approveBrandGroupUserMembers { get; set; }
// public DbSet<approveBrandPosition> approveBrandPositions { get; set; }
// public DbSet<approveBrandUser> approveBrandUsers { get; set; }
// public DbSet<approveCondition> approveConditions { get; set; }
// public DbSet<approveConditionAdvType> approveConditionAdvTypes { get; set; }
// public DbSet<approveConditionConfiguration> approveConditionConfigurations { get; set; }
//
// public DbSet<approveConditionConfigurationApproveCondition> approveConditionConfigurationApproveConditions
// {
//     get;
//     set;
// }
//
// public DbSet<approveConditionConfigurationDetail> approveConditionConfigurationDetails { get; set; }
// public DbSet<approveConditionCustomer> approveConditionCustomers { get; set; }
// public DbSet<approveConditionCustomerGrade> approveConditionCustomerGrades { get; set; }
// public DbSet<approveConditionCustomerGradeLog> approveConditionCustomerGradeLogs { get; set; }
// public DbSet<approveConditionCustomerGradeTmp> approveConditionCustomerGradeTmps { get; set; }
// public DbSet<approveConditionCustomerLog> approveConditionCustomerLogs { get; set; }
// public DbSet<approveConditionCustomerTmp> approveConditionCustomerTmps { get; set; }
// public DbSet<approveConditionDetail> approveConditionDetails { get; set; }
// public DbSet<approveConditionDetailLog> approveConditionDetailLogs { get; set; }
// public DbSet<approveConditionDetailTmp> approveConditionDetailTmps { get; set; }
// public DbSet<approveConditionLog> approveConditionLogs { get; set; }
// public DbSet<approveConditionSubType> approveConditionSubTypes { get; set; }
// public DbSet<approveConditionTmp> approveConditionTmps { get; set; }
// public DbSet<approveConditionType> approveConditionTypes { get; set; }
// public DbSet<approveStatus> approveStatuss { get; set; }
// public DbSet<archivePolicyMam> archivePolicyMams { get; set; }
// public DbSet<bmsApiActivity> bmsApiActivitys { get; set; }
// public DbSet<bmsApiKey> bmsApiKeys { get; set; }
// public DbSet<BMSLicenseManagement> BMSLicenseManagements { get; set; }
// public DbSet<brand> brands { get; set; }
// public DbSet<brandBusinessType> brandBusinessTypes { get; set; }
// public DbSet<businessType> businessTypes { get; set; }
// public DbSet<cashDiscount> cashDiscounts { get; set; }
// public DbSet<chatMessage> chatMessages { get; set; }
// public DbSet<chatRoom> chatRooms { get; set; }
// public DbSet<commentApprove> commentApproves { get; set; }
// public DbSet<commentApproveAE> commentApproveAEs { get; set; }
// public DbSet<commentApproveInvoiceOverdue> commentApproveInvoiceOverdues { get; set; }
// public DbSet<commissionRate> commissionRates { get; set; }
// public DbSet<commissionRateDetail> commissionRateDetails { get; set; }
// public DbSet<commissionRateWorkgroup> commissionRateWorkgroups { get; set; }
public DbSet<company> companies { get; set; }
// public DbSet<confirmOnAirImportFile> confirmOnAirImportFiles { get; set; }
// public DbSet<contactDepartment> contactDepartments { get; set; }
// public DbSet<contactType> contactTypes { get; set; }
// public DbSet<contract> contracts { get; set; }
// public DbSet<contractLog> contractLogs { get; set; }
// public DbSet<contractTemp> contractTemps { get; set; }
// public DbSet<copyReportQueueOther> copyReportQueueOthers { get; set; }
// public DbSet<copyrightImageType> copyrightImageTypes { get; set; }
// public DbSet<copyrightItemType> copyrightItemTypes { get; set; }
// public DbSet<copyrightMusicType> copyrightMusicTypes { get; set; }
// public DbSet<countries> countriess { get; set; }
// public DbSet<currencyExchangeRate> currencyExchangeRates { get; set; }
// public DbSet<custAM> custAMs { get; set; }
// public DbSet<customer> customers { get; set; }
// public DbSet<customerActiveLog> customerActiveLogs { get; set; }
// public DbSet<customerAddressType> customerAddressTypes { get; set; }
// public DbSet<customerAE> customerAEs { get; set; }
// public DbSet<customerAELog> customerAELogs { get; set; }
// public DbSet<customerAEStatus> customerAEStatuss { get; set; }
// public DbSet<customerAETmp> customerAETmps { get; set; }
// public DbSet<customerBranch> customerBranchs { get; set; }
// public DbSet<customerCollector> customerCollectors { get; set; }
// public DbSet<customerCreditStatus> customerCreditStatuss { get; set; }
// public DbSet<customerEditLog> customerEditLogs { get; set; }
// public DbSet<customerGrade> customerGrades { get; set; }
// public DbSet<customerGroup> customerGroups { get; set; }
// public DbSet<customerImportFile> customerImportFiles { get; set; }
// public DbSet<customerLog> customerLogs { get; set; }
// public DbSet<customerNew> customerNews { get; set; }
// public DbSet<customerPaymentTerm> customerPaymentTerms { get; set; }
// public DbSet<customerPurchase> customerPurchases { get; set; }
// public DbSet<customerPurchaseLog> customerPurchaseLogs { get; set; }
// public DbSet<customerPurchaseType> customerPurchaseTypes { get; set; }
// public DbSet<customerStatus> customerStatuss { get; set; }
// public DbSet<customerSubsidiary> customerSubsidiarys { get; set; }
// public DbSet<customerSyncLog> customerSyncLogs { get; set; }
// public DbSet<customerTitle> customerTitles { get; set; }
// public DbSet<customerTmp> customerTmps { get; set; }
// public DbSet<customerType> customerTypes { get; set; }
// public DbSet<dashboard> dashboards { get; set; }
// public DbSet<dataOriginType> dataOriginTypes { get; set; }
// public DbSet<dateLastMinuteConfig> dateLastMinuteConfigs { get; set; }
// public DbSet<dateLastMinuteConfigLog> dateLastMinuteConfigLogs { get; set; }
// public DbSet<department> departments { get; set; }
// public DbSet<depreciateTimeStamp> depreciateTimeStamps { get; set; }
// public DbSet<disablePersonService> disablePersonServices { get; set; }
// public DbSet<emailLog> emailLogs { get; set; }
// public DbSet<epgCountryConfig> epgCountryConfigs { get; set; }
// public DbSet<epgDailySchedule> epgDailySchedules { get; set; }
// public DbSet<epgEntry> epgEntrys { get; set; }
// public DbSet<epgExportHide> epgExportHides { get; set; }
// public DbSet<epgProgramCategoryLevel1Config> epgProgramCategoryLevel1Configs { get; set; }
// public DbSet<epgProgramCategoryLevel2Config> epgProgramCategoryLevel2Configs { get; set; }
// public DbSet<eventOnground> eventOngrounds { get; set; }
// public DbSet<eventOngroundMember> eventOngroundMembers { get; set; }
// public DbSet<exportExcelVersionLog> exportExcelVersionLogs { get; set; }
// public DbSet<exportLog> exportLogs { get; set; }
// public DbSet<exportLogHotlist> exportLogHotlists { get; set; }
// public DbSet<exportLogSchedule> exportLogSchedules { get; set; }
// public DbSet<exportLogScheduleHotlist> exportLogScheduleHotlists { get; set; }
// public DbSet<exportPlaylistSchedule> exportPlaylistSchedules { get; set; }
// public DbSet<exportPlaylistScheduleBackup> exportPlaylistScheduleBackups { get; set; }
// public DbSet<externalMedia> externalMedias { get; set; }
// public DbSet<externalMediaCountries> externalMediaCountriess { get; set; }
// public DbSet<externalMediaOnline> externalMediaOnlines { get; set; }
// public DbSet<FOCTypes> FOCTypess { get; set; }
// public DbSet<genCodePromote> genCodePromotes { get; set; }
// public DbSet<genCodeType> genCodeTypes { get; set; }
// public DbSet<generateBreak> generateBreaks { get; set; }
// public DbSet<geoBlockContentTv> geoBlockContentTvs { get; set; }
// public DbSet<geoBlockTv> geoBlockTvs { get; set; }
// public DbSet<glAccount> glAccounts { get; set; }
// public DbSet<graphic> graphics { get; set; }
// public DbSet<graphicMemberPosition> graphicMemberPositions { get; set; }
// public DbSet<graphicPosition> graphicPositions { get; set; }
// public DbSet<graphicType> graphicTypes { get; set; }
// public DbSet<groupProgram> groupPrograms { get; set; }
// public DbSet<groupProgramActiveLog> groupProgramActiveLogs { get; set; }
// public DbSet<groupProgramEditLog> groupProgramEditLogs { get; set; }
// public DbSet<groupProgramMarketing> groupProgramMarketings { get; set; }
// public DbSet<groupProgramMember> groupProgramMembers { get; set; }
// public DbSet<groupProgramMemberTmp> groupProgramMemberTmps { get; set; }
// public DbSet<groupProgramPromote> groupProgramPromotes { get; set; }
// public DbSet<groupProgramReport> groupProgramReports { get; set; }
// public DbSet<groupProgramTmp> groupProgramTmps { get; set; }
// public DbSet<groupProgramType> groupProgramTypes { get; set; }
// public DbSet<groupProgramUser> groupProgramUsers { get; set; }
// public DbSet<groupProgramWorkgroup> groupProgramWorkgroups { get; set; }
// public DbSet<groupPromoteReport> groupPromoteReports { get; set; }
// public DbSet<groupPromoteReportMember> groupPromoteReportMembers { get; set; }
// public DbSet<groupPromoteReportMemberPromote> groupPromoteReportMemberPromotes { get; set; }
// public DbSet<groupTime> groupTimes { get; set; }
// public DbSet<groupUserNotification> groupUserNotifications { get; set; }
// public DbSet<groupUserNotificationMember> groupUserNotificationMembers { get; set; }
// public DbSet<groupUserNotificationType> groupUserNotificationTypes { get; set; }
// public DbSet<invoice> invoices { get; set; }
// public DbSet<invoiceCopy> invoiceCopys { get; set; }
// public DbSet<invoiceCycle> invoiceCycles { get; set; }
// public DbSet<invoiceDetail> invoiceDetails { get; set; }
// public DbSet<invoiceDetailPrePayContract> invoiceDetailPrePayContracts { get; set; }
// public DbSet<invoiceDetailRental> invoiceDetailRentals { get; set; }
// public DbSet<invoiceDetailSpecialContract> invoiceDetailSpecialContracts { get; set; }
// public DbSet<invoiceImportFile> invoiceImportFiles { get; set; }
// public DbSet<invoiceItemTmp> invoiceItemTmps { get; set; }
// public DbSet<invoiceOverdueApproveFlow> invoiceOverdueApproveFlows { get; set; }
// public DbSet<invoicePackageContract> invoicePackageContracts { get; set; }
// public DbSet<invoiceQuotation> invoiceQuotations { get; set; }
// public DbSet<invoiceQuotationMember> invoiceQuotationMembers { get; set; }
// public DbSet<invoiceStatus> invoiceStatuss { get; set; }
// public DbSet<invoiceTmp> invoiceTmps { get; set; }
// public DbSet<InvSummary> InvSummarys { get; set; }
// public DbSet<InvSummaryDetail> InvSummaryDetails { get; set; }
// public DbSet<LicenseManagement> LicenseManagements { get; set; }
// public DbSet<licensePattern> licensePatterns { get; set; }
//public DbSet<licenseProgram> licensePrograms { get; set; }
// public DbSet<licenseProgramActiveLog> licenseProgramActiveLogs { get; set; }
// public DbSet<licenseProgramBroadcastingRight> licenseProgramBroadcastingRights { get; set; }
// public DbSet<licenseProgramBroadcastingRightLog> licenseProgramBroadcastingRightLogs { get; set; }
// public DbSet<licenseProgramCompany> licenseProgramCompanys { get; set; }
// public DbSet<licenseProgramContentType> licenseProgramContentTypes { get; set; }
// public DbSet<licenseProgramEpisodeDetail> licenseProgramEpisodeDetails { get; set; }
// public DbSet<licenseProgramEpisodeDetailLog> licenseProgramEpisodeDetailLogs { get; set; }
// public DbSet<licenseProgramEpisodeDetailOnlineCondition> licenseProgramEpisodeDetailOnlineConditions { get; set; }
//
// public DbSet<licenseProgramEpisodeDetailOnlineConditionLog> licenseProgramEpisodeDetailOnlineConditionLogs
// {
//     get;
//     set;
// }
//
//public DbSet<licenseProgramItemDetail> licenseProgramItemDetails { get; set; }
// public DbSet<licenseProgramItemDetailLog> licenseProgramItemDetailLogs { get; set; }
// public DbSet<licenseProgramItemDetailOnlineCondition> licenseProgramItemDetailOnlineConditions { get; set; }
// public DbSet<licenseProgramItemDetailOnlineConditionLog> licenseProgramItemDetailOnlineConditionLogs { get; set; }
// public DbSet<licenseProgramLog> licenseProgramLogs { get; set; }
// public DbSet<licenseProgramOnairChanelType> licenseProgramOnairChanelTypes { get; set; }
// public DbSet<licenseProgramPaymentDetail> licenseProgramPaymentDetails { get; set; }
// public DbSet<licenseProgramPaymentDetailFooter> licenseProgramPaymentDetailFooters { get; set; }
// public DbSet<licenseProgramPaymentDetailFooterLog> licenseProgramPaymentDetailFooterLogs { get; set; }
// public DbSet<licenseProgramPaymentDetailLog> licenseProgramPaymentDetailLogs { get; set; }
// public DbSet<licenseProgramProgramType> licenseProgramProgramTypes { get; set; }
// public DbSet<licenseProgramProgramTypeSub> licenseProgramProgramTypeSubs { get; set; }
// public DbSet<licenseProgramSubOnairChanelType> licenseProgramSubOnairChanelTypes { get; set; }
// public DbSet<licenseType> licenseTypes { get; set; }
// public DbSet<lockAdvertisementDetailLog> lockAdvertisementDetailLogs { get; set; }
// public DbSet<lockAdvertisementLog> lockAdvertisementLogs { get; set; }
// public DbSet<lockPeriod> lockPeriods { get; set; }
// public DbSet<lockPeriodLog> lockPeriodLogs { get; set; }
// public DbSet<lockQueue> lockQueues { get; set; }
// public DbSet<lockQueueType> lockQueueTypes { get; set; }
// public DbSet<manageLog> manageLogs { get; set; }
// public DbSet<manageLogMember> manageLogMembers { get; set; }
// public DbSet<manageQueueConfirmBackupLog> manageQueueConfirmBackupLogs { get; set; }
// public DbSet<manageQueueConfirmLog> manageQueueConfirmLogs { get; set; }
// public DbSet<manageQueueConfirmType> manageQueueConfirmTypes { get; set; }
// public DbSet<manageQueuePromoteSaveLog> manageQueuePromoteSaveLogs { get; set; }
// public DbSet<manageQuota> manageQuotas { get; set; }
// public DbSet<manageQuotaSales> manageQuotaSaless { get; set; }
// public DbSet<manageQuotaSalesTmp> manageQuotaSalesTmps { get; set; }
// public DbSet<manageQuotaTeamgroup> manageQuotaTeamgroups { get; set; }
// public DbSet<manageQuotaTeamgroupTmp> manageQuotaTeamgroupTmps { get; set; }
// public DbSet<manageQuotaTmp> manageQuotaTmps { get; set; }
// public DbSet<manageQuotaWorkgroup> manageQuotaWorkgroups { get; set; }
// public DbSet<manageQuotaWorkgroupTmp> manageQuotaWorkgroupTmps { get; set; }
public DbSet<manageTeamGroup> manageTeamGroups { get; set; }
// public DbSet<manageTeamGroupMember> manageTeamGroupMembers { get; set; }
public DbSet<manageTeamGroupReport> manageTeamGroupReports { get; set; }
// public DbSet<manageTeamGroupReportMember> manageTeamGroupReportMembers { get; set; }
public DbSet<manageViewTeamGroup> manageViewTeamGroups { get; set; }
// public DbSet<manualDocument> manualDocuments { get; set; }
// public DbSet<materialType> materialTypes { get; set; }
// public DbSet<materialTypeMappingDepartment> materialTypeMappingDepartments { get; set; }
// public DbSet<mediaDuration> mediaDurations { get; set; }
// public DbSet<mediaDurationType> mediaDurationTypes { get; set; }
// public DbSet<mediaGroupWorkPermission> mediaGroupWorkPermissions { get; set; }
//public DbSet<mediaType> mediaTypes { get; set; }
// public DbSet<memoAccount> memoAccounts { get; set; }
// public DbSet<memoAccountDetail> memoAccountDetails { get; set; }
// public DbSet<memoAccountGroupItem> memoAccountGroupItems { get; set; }
// public DbSet<memoStatus> memoStatuss { get; set; }
// public DbSet<memoType> memoTypes { get; set; }
// public DbSet<misProject> misProjects { get; set; }
public DbSet<modules> modules { get; set; }
public DbSet<modulesmenu> modulesmenus { get; set; }
// public DbSet<navCustomerPostingGroup> navCustomerPostingGroups { get; set; }
// public DbSet<navGenBusPostingGroup> navGenBusPostingGroups { get; set; }
// public DbSet<navVatBusPostingGroup> navVatBusPostingGroups { get; set; }
// public DbSet<navWhtBusPostingGroup> navWhtBusPostingGroups { get; set; }
// public DbSet<notification> notifications { get; set; }
// public DbSet<notificationDetail> notificationDetails { get; set; }
// public DbSet<notificationExpire> notificationExpires { get; set; }
// public DbSet<notificationType> notificationTypes { get; set; }
// public DbSet<onairChanelType> onairChanelTypes { get; set; }
// public DbSet<onlineCondition> onlineConditions { get; set; }
// public DbSet<onlineProgramConfig> onlineProgramConfigs { get; set; }
// public DbSet<onlineStatus> onlineStatuss { get; set; }
// public DbSet<orderAdjust> orderAdjusts { get; set; }
// public DbSet<orderAdjustMember> orderAdjustMembers { get; set; }
// public DbSet<orderAdjustReson> orderAdjustResons { get; set; }
// public DbSet<orderAdjustStatus> orderAdjustStatuss { get; set; }
// public DbSet<orderAdjustType> orderAdjustTypes { get; set; }
// public DbSet<OrderConversionHistory> OrderConversionHistorys { get; set; }
// public DbSet<OrderConversionHistoryMember> OrderConversionHistoryMembers { get; set; }
// public DbSet<orderGroupTime> orderGroupTimes { get; set; }
// public DbSet<orderGroupTimeTmp> orderGroupTimeTmps { get; set; }
// public DbSet<orderProgramTmp> orderProgramTmps { get; set; }
// public DbSet<orderQuotation> orderQuotations { get; set; }
// public DbSet<orderQuotationLog> orderQuotationLogs { get; set; }
// public DbSet<orderQuotationTmp> orderQuotationTmps { get; set; }
// public DbSet<orders> orderss { get; set; }
// public DbSet<ordersLog> ordersLogs { get; set; }
// public DbSet<orderStatus> orderStatuss { get; set; }
// public DbSet<ordersTmp> ordersTmps { get; set; }
// public DbSet<orderType> orderTypes { get; set; }
// public DbSet<othAdjustScheduleTmp> othAdjustScheduleTmps { get; set; }
// public DbSet<othAdvSchedule> othAdvSchedules { get; set; }
// public DbSet<othAdvScheduleLog> othAdvScheduleLogs { get; set; }
// public DbSet<othAdvScheduleTmp> othAdvScheduleTmps { get; set; }
// public DbSet<othOrderApproveGroupUser> othOrderApproveGroupUsers { get; set; }
// public DbSet<othOrderDetail> othOrderDetails { get; set; }
// public DbSet<othOrderLog> othOrderLogs { get; set; }
// public DbSet<othOrderProgramTmp> othOrderProgramTmps { get; set; }
// public DbSet<othOrderQuotation> othOrderQuotations { get; set; }
// public DbSet<othOrderQuotationLog> othOrderQuotationLogs { get; set; }
// public DbSet<othOrderQuotationTmp> othOrderQuotationTmps { get; set; }
// public DbSet<othOrders> othOrderss { get; set; }
// public DbSet<othOrderTmp> othOrderTmps { get; set; }
// public DbSet<othOrderType> othOrderTypes { get; set; }
// public DbSet<package> packages { get; set; }
// public DbSet<packageAgreement> packageAgreements { get; set; }
// public DbSet<packageAgreementDetail> packageAgreementDetails { get; set; }
// public DbSet<packageContractDetail> packageContractDetails { get; set; }
// public DbSet<packageContractDetailHistory> packageContractDetailHistorys { get; set; }
// public DbSet<packageCustomerGradeMember> packageCustomerGradeMembers { get; set; }
// public DbSet<packageCustomerGradeMemberTmp> packageCustomerGradeMemberTmps { get; set; }
// public DbSet<packageCustomerTypeMember> packageCustomerTypeMembers { get; set; }
// public DbSet<packageCustomerTypeMemberTmp> packageCustomerTypeMemberTmps { get; set; }
// public DbSet<packageFOCMapping> packageFOCMappings { get; set; }
// public DbSet<packageGroupPrgMember> packageGroupPrgMembers { get; set; }
// public DbSet<packageGroupPrgMemberTmp> packageGroupPrgMemberTmps { get; set; }
// public DbSet<packageImportFile> packageImportFiles { get; set; }
// public DbSet<packageLog> packageLogs { get; set; }
// public DbSet<packageMember> packageMembers { get; set; }
// public DbSet<packageMemberCustomer> packageMemberCustomers { get; set; }
// public DbSet<packageMemberCustomerTmp> packageMemberCustomerTmps { get; set; }
// public DbSet<packageMemberLog> packageMemberLogs { get; set; }
// public DbSet<packageMemberTmp> packageMemberTmps { get; set; }
// public DbSet<packagePrePayDetail> packagePrePayDetails { get; set; }
// public DbSet<packageProductMember> packageProductMembers { get; set; }
// public DbSet<packageProductMemberTmp> packageProductMemberTmps { get; set; }
// public DbSet<packageProductMemLog> packageProductMemLogs { get; set; }
// public DbSet<packageStatus> packageStatuss { get; set; }
// public DbSet<packageTmp> packageTmps { get; set; }
// public DbSet<packageTotalType> packageTotalTypes { get; set; }
// public DbSet<packageType> packageTypes { get; set; }
// public DbSet<packageTypeMember> packageTypeMembers { get; set; }
// public DbSet<paymentType> paymentTypes { get; set; }
    public DbSet<pbmsuser> pbmsusers { get; set; }

    public DbSet<pbmsuserstation> pbmsuserstations { get; set; }

// public DbSet<pbmsusertype> pbmsusertypes { get; set; }
// public DbSet<permissionSP> permissionSPs { get; set; }
// public DbSet<permissionSpecial> permissionSpecials { get; set; }
// public DbSet<permissionSpecialWorkgroup> permissionSpecialWorkgroups { get; set; }
// public DbSet<playlistActionLog> playlistActionLogs { get; set; }
// public DbSet<playlistHotListSyncLog> playlistHotListSyncLogs { get; set; }
// public DbSet<playlistPromoteSyncSAPLog> playlistPromoteSyncSAPLogs { get; set; }
// public DbSet<playlistScheduleConfirmLog> playlistScheduleConfirmLogs { get; set; }
// public DbSet<playlistScheduleDetail> playlistScheduleDetails { get; set; }
// public DbSet<playlistScheduleDetailLog> playlistScheduleDetailLogs { get; set; }
// public DbSet<playlistScheduleExportLog> playlistScheduleExportLogs { get; set; }
// public DbSet<playlistScheduleRemarkEpisodeLog> playlistScheduleRemarkEpisodeLogs { get; set; }
// public DbSet<playlistScheduleSyncLog> playlistScheduleSyncLogs { get; set; }
// public DbSet<positionReportQueueOtherData> positionReportQueueOtherDatas { get; set; }
// public DbSet<prgContentTapeSchedule> prgContentTapeSchedules { get; set; }
// public DbSet<prgSupportListType> prgSupportListTypes { get; set; }
// public DbSet<prgSupportOnAirType> prgSupportOnAirTypes { get; set; }
// public DbSet<prgSupportQueue> prgSupportQueues { get; set; }
// public DbSet<product> products { get; set; }
// public DbSet<productCategory> productCategorys { get; set; }
// public DbSet<productIndustry> productIndustrys { get; set; }
// public DbSet<productOwner> productOwners { get; set; }
    public DbSet<program> programs { get; set; }
    public DbSet<programCategory> programCategories { get; set; }

    public DbSet<programCategoryNBCT> programCategoryNBCTs { get; set; }

// public DbSet<programChange> programChanges { get; set; }
// public DbSet<programChangeType> programChangeTypes { get; set; }
// public DbSet<programCondition> programConditions { get; set; }
// public DbSet<programConditionMember> programConditionMembers { get; set; }
// public DbSet<programContract> programContracts { get; set; }
// public DbSet<programContractAdv> programContractAdvs { get; set; }
// public DbSet<programContractAdvLog> programContractAdvLogs { get; set; }
// public DbSet<programContractApprove> programContractApproves { get; set; }
// public DbSet<programContractCompany> programContractCompanys { get; set; }
// public DbSet<programContractConditionMember> programContractConditionMembers { get; set; }
// public DbSet<programContractConfiguration> programContractConfigurations { get; set; }
// public DbSet<programContractDetail> programContractDetails { get; set; }
// public DbSet<programContractDetailLog> programContractDetailLogs { get; set; }
// public DbSet<programContractEndConfiguration> programContractEndConfigurations { get; set; }
// public DbSet<programContractEndContract> programContractEndContracts { get; set; }
// public DbSet<programContractEndOptionConfiguration> programContractEndOptionConfigurations { get; set; }
// public DbSet<programContractEndOptionContract> programContractEndOptionContracts { get; set; }
// public DbSet<programContractImportFile> programContractImportFiles { get; set; }
// public DbSet<programContractLicense> programContractLicenses { get; set; }
// public DbSet<programContractLog> programContractLogs { get; set; }
// public DbSet<programContractMainContract> programContractMainContracts { get; set; }
// public DbSet<programContractOtherCondition> programContractOtherConditions { get; set; }
// public DbSet<programContractPayment> programContractPayments { get; set; }
// public DbSet<programContractPaymentLog> programContractPaymentLogs { get; set; }
// public DbSet<programContractPaymentTerm> programContractPaymentTerms { get; set; }
// public DbSet<programContractPeriod> programContractPeriods { get; set; }
// public DbSet<programContractProducer> programContractProducers { get; set; }
// public DbSet<programContractProduct> programContractProducts { get; set; }
// public DbSet<programContractProductMapping> programContractProductMappings { get; set; }
// public DbSet<programContractProgramCategory> programContractProgramCategorys { get; set; }
// public DbSet<programContractProgramDetail> programContractProgramDetails { get; set; }
// public DbSet<programContractProgramDetailLog> programContractProgramDetailLogs { get; set; }
// public DbSet<programContractProgramPeriod> programContractProgramPeriods { get; set; }
// public DbSet<programContractReportDetail> programContractReportDetails { get; set; }
// public DbSet<programContractReportRentalTimeDetail> programContractReportRentalTimeDetails { get; set; }
// public DbSet<programContractReportRevenueShareDetail> programContractReportRevenueShareDetails { get; set; }
// public DbSet<programContractReportTimeShareDetail> programContractReportTimeShareDetails { get; set; }
// public DbSet<programContractSign> programContractSigns { get; set; }
// public DbSet<programContractSignLog> programContractSignLogs { get; set; }
// public DbSet<programContractSignType> programContractSignTypes { get; set; }
// public DbSet<programContractStatus> programContractStatuss { get; set; }
// public DbSet<programContractType> programContractTypes { get; set; }
// public DbSet<programCountries> programCountriess { get; set; }
// public DbSet<programDailyConfirm> programDailyConfirms { get; set; }
// public DbSet<programDailyGraphic> programDailyGraphics { get; set; }
// public DbSet<programDailyGraphicEpisode> programDailyGraphicEpisodes { get; set; }
// public DbSet<programDailyGraphicLog> programDailyGraphicLogs { get; set; }
// public DbSet<programDailyLayoutOverTime> programDailyLayoutOverTimes { get; set; }
//public DbSet<programDailySchedule> programDailySchedules { get; set; }
// public DbSet<programDailyScheduleBackup> programDailyScheduleBackups { get; set; }
// public DbSet<programDailyScheduleBackupConditionMember> programDailyScheduleBackupConditionMembers { get; set; }
//
// public DbSet<programDailyScheduleBackupConditionMemberLog> programDailyScheduleBackupConditionMemberLogs
// {
//     get;
//     set;
// }
//
// public DbSet<programDailyScheduleBackupEpisode> programDailyScheduleBackupEpisodes { get; set; }
// public DbSet<programDailyScheduleBackupEpisodeLog> programDailyScheduleBackupEpisodeLogs { get; set; }
// public DbSet<programDailyScheduleBackupLog> programDailyScheduleBackupLogs { get; set; }
// public DbSet<programDailyScheduleBackupSolution> programDailyScheduleBackupSolutions { get; set; }
// public DbSet<programDailyScheduleBackupSplitTime> programDailyScheduleBackupSplitTimes { get; set; }
// public DbSet<programDailyScheduleBackupSplitTimeLog> programDailyScheduleBackupSplitTimeLogs { get; set; }
// public DbSet<programDailyScheduleBackupStudioMember> programDailyScheduleBackupStudioMembers { get; set; }
// public DbSet<programDailyScheduleBackupStudioMemberLog> programDailyScheduleBackupStudioMemberLogs { get; set; }
// public DbSet<programDailyScheduleCodeClean> programDailyScheduleCodeCleans { get; set; }
// public DbSet<programDailyScheduleCodeCleanHistoryLog> programDailyScheduleCodeCleanHistoryLogs { get; set; }
// public DbSet<programDailyScheduleCodeCleanImportFile> programDailyScheduleCodeCleanImportFiles { get; set; }
// public DbSet<programDailyScheduleCodeCleanLog> programDailyScheduleCodeCleanLogs { get; set; }
//public DbSet<programDailyScheduleConditionMember> programDailyScheduleConditionMembers { get; set; }
//public DbSet<programDailyScheduleConditionMemberLog> programDailyScheduleConditionMemberLogs { get; set; }
//public DbSet<programDailyScheduleEpisode> programDailyScheduleEpisodes { get; set; }
// public DbSet<programDailyScheduleEpisodeHistoryLog> programDailyScheduleEpisodeHistoryLogs { get; set; }
// public DbSet<programDailyScheduleEpisodeImportFile> programDailyScheduleEpisodeImportFiles { get; set; }
// public DbSet<programDailyScheduleEpisodeLog> programDailyScheduleEpisodeLogs { get; set; }
// public DbSet<programDailyScheduleEpisodeRerun> programDailyScheduleEpisodeReruns { get; set; }
// public DbSet<programDailyScheduleEpisodeRerunLog> programDailyScheduleEpisodeRerunLogs { get; set; }
// public DbSet<programDailyScheduleEpisodeTemplate> programDailyScheduleEpisodeTemplates { get; set; }
// public DbSet<programDailyScheduleEpisodeTemplateLog> programDailyScheduleEpisodeTemplateLogs { get; set; }
//public DbSet<programDailyScheduleHistoryLog> programDailyScheduleHistoryLogs { get; set; }
// public DbSet<programDailyScheduleLicense> programDailyScheduleLicenses { get; set; }
// public DbSet<programDailyScheduleLog> programDailyScheduleLogs { get; set; }
//public DbSet<programDailyScheduleSplitTime> programDailyScheduleSplitTimes { get; set; }
// public DbSet<programDailyScheduleSplitTimeLog> programDailyScheduleSplitTimeLogs { get; set; }
//public DbSet<programDailyScheduleStudioMember> programDailyScheduleStudioMembers { get; set; }
// public DbSet<programDailyScheduleStudioMemberLog> programDailyScheduleStudioMemberLogs { get; set; }
// public DbSet<programDailySupport> programDailySupports { get; set; }
// public DbSet<programDailySupportLog> programDailySupportLogs { get; set; }
// public DbSet<programDailySupportMainLog> programDailySupportMainLogs { get; set; }
    public DbSet<programDetail> programDetails { get; set; }

//public DbSet<programDetailBreak> programDetailBreaks { get; set; }
//public DbSet<programDetailBreakLog> programDetailBreakLogs { get; set; }
//public DbSet<programDetailBreakOther> programDetailBreakOthers { get; set; }
//public DbSet<programDetailBreakOtherLog> programDetailBreakOtherLogs { get; set; }
// public DbSet<programDetailBreakTmp> programDetailBreakTmps { get; set; }
//public DbSet<programDetailConditionMember> programDetailConditionMembers { get; set; }
//public DbSet<programDetailConditionMemberLog> programDetailConditionMemberLogs { get; set; }
// public DbSet<programDetailConditionMemberTmp> programDetailConditionMemberTmps { get; set; }
//public DbSet<programDetailContinuous> programDetailContinuous { get; set; }
//public DbSet<programDetailContinuousLog> programDetailContinuousLogs { get; set; }
//public DbSet<programDetailDateOnAir> programDetailDateOnAirs { get; set; }
//public DbSet<programDetailDateOnAirLog> programDetailDateOnAirLogs { get; set; }
// public DbSet<programDetailEntry> programDetailEntrys { get; set; }
// public DbSet<programDetailGraphic> programDetailGraphics { get; set; }
// public DbSet<programDetailGraphicLog> programDetailGraphicLogs { get; set; }
// public DbSet<programDetailLicense> programDetailLicenses { get; set; }
// public DbSet<programDetailLicenseLog> programDetailLicenseLogs { get; set; }
//public DbSet<programDetailLog> programDetailLogs { get; set; }
// public DbSet<programDetailMediaContentRerun> programDetailMediaContentReruns { get; set; }
// public DbSet<programDetailOther> programDetailOthers { get; set; }
// public DbSet<programDetailOtherLog> programDetailOtherLogs { get; set; }
// public DbSet<programDetailOtherTmp> programDetailOtherTmps { get; set; }
//public DbSet<programDetailSplitTime> programDetailSplitTimes { get; set; }
//public DbSet<programDetailSplitTimeLog> programDetailSplitTimeLogs { get; set; }
// public DbSet<programDetailSplitTimeTmp> programDetailSplitTimeTmps { get; set; }
//public DbSet<programDetailStatusProcess> programDetailStatusProcesses { get; set; }
//public DbSet<programDetailStudioMember> programDetailStudioMembers { get; set; }
//public DbSet<programDetailStudioMemberLog> programDetailStudioMemberLogs { get; set; }
//public DbSet<programDetailStudioMemberTemp> programDetailStudioMemberTemps { get; set; }
// public DbSet<programDetailSupport> programDetailSupports { get; set; }
// public DbSet<programDetailSupportLog> programDetailSupportLogs { get; set; }
// public DbSet<programDetailTmp> programDetailTmps { get; set; }
//public DbSet<programDetailWeekOnAir> programDetailWeekOnAirs { get; set; }
//public DbSet<programDetailWeekOnAirLog> programDetailWeekOnAirLogs { get; set; }
// public DbSet<programDisableService> programDisableServices { get; set; }
// public DbSet<programDisableServiceLog> programDisableServiceLogs { get; set; }
// public DbSet<programEntryLicense> programEntryLicenses { get; set; }
// public DbSet<programFixAsset> programFixAssets { get; set; }
// public DbSet<programGroupRefLog> programGroupRefLogs { get; set; }
// public DbSet<programLayoutConfirmItem> programLayoutConfirmItems { get; set; }
// public DbSet<programLayoutConfirmItemSupport> programLayoutConfirmItemSupports { get; set; }
// public DbSet<programLayoutConfirmLog> programLayoutConfirmLogs { get; set; }
// public DbSet<programLog> programLogs { get; set; }
    public DbSet<programMediaContent> programMediaContents { get; set; }

//public DbSet<programMediaContentMember> programMediaContentMembers { get; set; }
// public DbSet<programMediaContentNameLog> programMediaContentNameLogs { get; set; }
// public DbSet<programMonthlySupport> programMonthlySupports { get; set; }
    public DbSet<programOnAirType> programOnAirTypes { get; set; }

// public DbSet<programOnlineCondition> programOnlineConditions { get; set; }
// public DbSet<programOnlineConditionLog> programOnlineConditionLogs { get; set; }
//public DbSet<programPrimaryGroup> programPrimaryGroups { get; set; }
// public DbSet<programProject> programProjects { get; set; }
// public DbSet<programRateType> programRateTypes { get; set; }
// public DbSet<programReportLog> programReportLogs { get; set; }
// public DbSet<programScheduleSyncLog> programScheduleSyncLogs { get; set; }
//public DbSet<programSettingGenerateAutoMediaCode> programSettingGenerateAutoMediaCodes { get; set; }
// public DbSet<programSourceTypeNBCT> programSourceTypeNBCTs { get; set; }
// public DbSet<programStatus> programStatuss { get; set; }
// public DbSet<programTape> programTapes { get; set; }
// public DbSet<programTapeExpireType> programTapeExpireTypes { get; set; }
// public DbSet<programTapeHistory> programTapeHistorys { get; set; }
// public DbSet<programTapeImportFile> programTapeImportFiles { get; set; }
// public DbSet<programTapeLog> programTapeLogs { get; set; }
// public DbSet<programTapeType> programTapeTypes { get; set; }
// public DbSet<project> projects { get; set; }
// public DbSet<promote> promotes { get; set; }
// public DbSet<promoteLog> promoteLogs { get; set; }
// public DbSet<queue_email> queue_emails { get; set; }
// public DbSet<quotaSalesMinute> quotaSalesMinutes { get; set; }
// public DbSet<quotation> quotations { get; set; }
// public DbSet<quotationApproveFlow> quotationApproveFlows { get; set; }
// public DbSet<quotationContractDetail> quotationContractDetails { get; set; }
// public DbSet<quotationCustomerDetail> quotationCustomerDetails { get; set; }
// public DbSet<quotationFulLog> quotationFulLogs { get; set; }
// public DbSet<quotationGroupPrgMember> quotationGroupPrgMembers { get; set; }
// public DbSet<quotationLog> quotationLogs { get; set; }
// public DbSet<quotationLogType> quotationLogTypes { get; set; }
// public DbSet<quotationMember> quotationMembers { get; set; }
// public DbSet<quotationMemberAdjust> quotationMemberAdjusts { get; set; }
// public DbSet<quotationMemberAdjustLog> quotationMemberAdjustLogs { get; set; }
// public DbSet<quotationMemberAdjustLogType> quotationMemberAdjustLogTypes { get; set; }
// public DbSet<quotationMemberFullLog> quotationMemberFullLogs { get; set; }
// public DbSet<quotationMemberUser> quotationMemberUsers { get; set; }
// public DbSet<quotationMemberUserHistory> quotationMemberUserHistorys { get; set; }
// public DbSet<quotationProductMember> quotationProductMembers { get; set; }
// public DbSet<quotationReference> quotationReferences { get; set; }
// public DbSet<quotationStatus> quotationStatuss { get; set; }
// public DbSet<rebate> rebates { get; set; }
// public DbSet<rebateCustomer> rebateCustomers { get; set; }
// public DbSet<rebateDetail> rebateDetails { get; set; }
// public DbSet<rebateWorkGroup> rebateWorkGroups { get; set; }
// public DbSet<receiptAX> receiptAXs { get; set; }
// public DbSet<receive> receives { get; set; }
// public DbSet<reconcileTax> reconcileTaxs { get; set; }
// public DbSet<regions> regionss { get; set; }
// public DbSet<rentalType> rentalTypes { get; set; }
// public DbSet<rowNumber> rowNumbers { get; set; }
// public DbSet<salesForecast> salesForecasts { get; set; }
// public DbSet<salesForecastDetail> salesForecastDetails { get; set; }
// public DbSet<sapCategory> sapCategorys { get; set; }
// public DbSet<sapPlaylisScheduleLog> sapPlaylisScheduleLogs { get; set; }
// public DbSet<sapProgramScheduleLog> sapProgramScheduleLogs { get; set; }
// public DbSet<scheduleType> scheduleTypes { get; set; }
// public DbSet<sessionAdjustOrder> sessionAdjustOrders { get; set; }
// public DbSet<sessionManage> sessionManages { get; set; }
// public DbSet<sessionUserStatus> sessionUserStatuss { get; set; }
// public DbSet<specialCommand> specialCommands { get; set; }
    public DbSet<station> stations { get; set; }
// public DbSet<stationLicense> stationLicenses { get; set; }
// public DbSet<stationTimeSlot> stationTimeSlots { get; set; }
// public DbSet<stationtype> stationtypes { get; set; }
// public DbSet<studio> studios { get; set; }
// public DbSet<subLicenseProgram> subLicensePrograms { get; set; }
// public DbSet<subLicenseProgramLog> subLicenseProgramLogs { get; set; }
// public DbSet<syncMamHistory> syncMamHistorys { get; set; }
// public DbSet<syncMamHistoryAction> syncMamHistoryActions { get; set; }
// public DbSet<targetAge> targetAges { get; set; }
// public DbSet<targetArea> targetAreas { get; set; }
// public DbSet<targetGender> targetGenders { get; set; }
// public DbSet<targetIncome> targetIncomes { get; set; }
// public DbSet<teamgroup> teamgroups { get; set; }
// public DbSet<teamgroupworkgroup> teamgroupworkgroups { get; set; }
// public DbSet<testRunJobProductOwner> testRunJobProductOwners { get; set; }
// public DbSet<timeBreakConfig> timeBreakConfigs { get; set; }
// public DbSet<timeSlot> timeSlots { get; set; }
// public DbSet<timeSlotConfiguration> timeSlotConfigurations { get; set; }
// public DbSet<TVRatingAllocate> TVRatingAllocates { get; set; }
// public DbSet<TVRatingAllocateConfigAgeType> TVRatingAllocateConfigAgeTypes { get; set; }
// public DbSet<TVRatingAllocateConfigIncomeType> TVRatingAllocateConfigIncomeTypes { get; set; }
// public DbSet<TVRatingAllocateConfigStation> TVRatingAllocateConfigStations { get; set; }
// public DbSet<TVRatingAllocateConfigZoneType> TVRatingAllocateConfigZoneTypes { get; set; }
// public DbSet<TVRatingAllocateDetail> TVRatingAllocateDetails { get; set; }
// public DbSet<TVRatingAllocateTimeRange> TVRatingAllocateTimeRanges { get; set; }
// public DbSet<TVRatingProgram> TVRatingPrograms { get; set; }
// public DbSet<TVRatingProgramConfigAgeType> TVRatingProgramConfigAgeTypes { get; set; }
// public DbSet<TVRatingProgramConfigIncomeType> TVRatingProgramConfigIncomeTypes { get; set; }
// public DbSet<TVRatingProgramConfigStation> TVRatingProgramConfigStations { get; set; }
// public DbSet<TVRatingProgramConfigZoneType> TVRatingProgramConfigZoneTypes { get; set; }
// public DbSet<TVRatingProgramDetail> TVRatingProgramDetails { get; set; }
// public DbSet<TVRatingSubType> TVRatingSubTypes { get; set; }
// public DbSet<TVRatingType> TVRatingTypes { get; set; }
// public DbSet<txStatusMam> txStatusMams { get; set; }
// public DbSet<userDashboard> userDashboards { get; set; }
// public DbSet<userPasswordExpiration> userPasswordExpirations { get; set; }
public DbSet<userpermission> userpermissions { get; set; }
// public DbSet<userSpecialPermission> userSpecialPermissions { get; set; }
// public DbSet<vatValue> vatValues { get; set; }
// public DbSet<vendor> vendors { get; set; }
// public DbSet<whtGroup> whtGroups { get; set; }
// public DbSet<whtValue> whtValues { get; set; }
// public DbSet<withdrawSlip> withdrawSlips { get; set; }
// public DbSet<withdrawSlipDetail> withdrawSlipDetails { get; set; }
// public DbSet<withdrawSlipType> withdrawSlipTypes { get; set; }
// public DbSet<workflowType> workflowTypes { get; set; }
// public DbSet<workflowTypeItem> workflowTypeItems { get; set; }
// public DbSet<workflowTypeItemDelegate> workflowTypeItemDelegates { get; set; }
public DbSet<workgroup> workgroups { get; set; }
// public DbSet<workgroupChatRoom> workgroupChatRooms { get; set; }
// public DbSet<workgroupDashboard> workgroupDashboards { get; set; }
public DbSet<workgroupPermission> workgroupPermissions { get; set; }
// public DbSet<workgrouprole> workgrouproles { get; set; }
// public DbSet<workgroupSpecialPermisson> workgroupSpecialPermissons { get; set; }
// public DbSet<workgroupStation> workgroupStations { get; set; }
// public DbSet<workgroupSubGroup> workgroupSubGroups { get; set; }
public DbSet<workgroupType> workgroupTypes { get; set; }
// public DbSet<workgroupuser> workgroupusers { get; set; }
// public DbSet<workgroupUserHistory> workgroupUserHistorys { get; set; }
// public DbSet<workgroupViewMember> workgroupViewMembers { get; set; }
// public DbSet<workgroupWorkFlow> workgroupWorkFlows { get; set; }

    /* stores model */
    public DbSet<stProgramEntrySelect> stProgramEntrySelect { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // โหลด configuration อื่น ๆ จาก assembly นี้ (ถ้ามี)
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BmsDataContext).Assembly);
    }
}


/*

 DECLARE @tableName NVARCHAR(128) = 'programDailyScheduleSplitTime';

SELECT
    'public '
    + CASE
        WHEN DATA_TYPE IN ('int', 'smallint', 'bigint', 'tinyint') THEN 'int'

        WHEN DATA_TYPE = 'bit' THEN 'bool'
        WHEN DATA_TYPE IN ('decimal', 'numeric', 'money', 'smallmoney') THEN 'decimal'
        WHEN DATA_TYPE IN ('float', 'real') THEN 'double'
        WHEN DATA_TYPE LIKE '%char%' OR DATA_TYPE LIKE '%text%' OR DATA_TYPE LIKE '%xml%' THEN 'string'
        WHEN DATA_TYPE IN ('date', 'datetime', 'datetime2', 'smalldatetime', 'datetimeoffset') THEN  'DateTime'
        WHEN DATA_TYPE = 'time' THEN  'TimeSpan'
        WHEN DATA_TYPE = 'uniqueidentifier' THEN  'Guid'
        ELSE 'object'
      END
    + CASE WHEN IS_NULLABLE = 'YES' THEN '?' ELSE '' END
    + ' '
    + COLUMN_NAME
    + ' { get; set; }'
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = @tableName
ORDER BY ORDINAL_POSITION;


;WITH x AS (
    SELECT 0 AS sortOrder,
           'builder.ToTable("' + @tableName + '");' as line

    UNION ALL

    SELECT
        1 AS sortOrder,
        'builder.HasKey(e => e.' +
        + COLUMN_NAME
        + ');' AS line
    FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE
    WHERE TABLE_NAME = @tableName
        AND CONSTRAINT_NAME IN (
            SELECT CONSTRAINT_NAME
            FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
            WHERE TABLE_NAME = @tableName
                AND CONSTRAINT_TYPE = 'PRIMARY KEY'
        )




    UNION ALL
    SELECT C.ORDINAL_POSITION + 100 AS sortOrder,
        'builder.Property(e => e.'
        + COLUMN_NAME
        + ')'
        + CASE WHEN C.IS_NULLABLE = 'NO' THEN '.IsRequired()' ELSE '' END
        + '.HasColumnName("' + C.COLUMN_NAME + '")'
        + '.HasColumnType("'
            + C.DATA_TYPE
            + CASE
                WHEN C.DATA_TYPE IN ('varchar','nvarchar','char','nchar')
                     AND C.CHARACTER_MAXIMUM_LENGTH IS NOT NULL
                     THEN '(' +
                         CASE WHEN C.CHARACTER_MAXIMUM_LENGTH = -1
                              THEN 'max'
                              ELSE CAST(C.CHARACTER_MAXIMUM_LENGTH AS VARCHAR(10)) END
                         + ')'
                WHEN C.DATA_TYPE IN ('decimal','numeric')
                     AND C.NUMERIC_PRECISION IS NOT NULL
                     THEN '(' + CAST(C.NUMERIC_PRECISION AS VARCHAR(10))
                         + ',' + CAST(C.NUMERIC_SCALE AS VARCHAR(10)) + ')'
                ELSE ''
              END
        + '");'
    FROM INFORMATION_SCHEMA.COLUMNS C
    WHERE C.TABLE_NAME = @tableName
)
SELECT line
FROM x
ORDER BY sortOrder;






*
 */