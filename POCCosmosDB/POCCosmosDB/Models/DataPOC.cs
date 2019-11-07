using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace POCCosmosDB.Models
{
    public partial class DataPOC
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)] 
        public string Id { get; set; }
        public string CpsVersion { get; set; }
        public string ProductClassCd { get; set; }
        public Guid ProductId { get; set; }
        public string CpsCreatedBy { get; set; }
        public string CpsCreatedOn { get; set; }
        public string CpsUpdatedBy { get; set; }
        public string CpsUpdatedOn { get; set; }
        public Guid TransactionId { get; set; }
        public Guid BrokerAccountId { get; set; }
        public Guid ChannelId { get; set; }
        public InsuredAccount InsuredAccount { get; set; }
        public Opportunity Opportunity { get; set; }
        public Quote Quote { get; set; }
        public Location[] Locations { get; set; }
        public AdditionalInterest[] AdditionalInterests { get; set; }
        public Policy Policy { get; set; }
    }

    public partial class AdditionalInterest
    {
    }

    public partial class InsuredAccount
    {
        public Guid AccountId { get; set; }
        public string AccountType { get; set; }
        public string AccountEntityType { get; set; }
        public string AccountName { get; set; }
        public string AccountRegisteredName { get; set; }
        public string AccountOwner { get; set; }
        public DateTimeOffset AccountYearStarted { get; set; }
        public long AccountPhone { get; set; }
        public Uri AccountWebsite { get; set; }
        public Uri AccountFacebook { get; set; }
        public Uri AccountInstagram { get; set; }
        public Uri AccountTwitter { get; set; }
        public string AccountTradeType { get; set; }
        public AccountIntel AccountIntel { get; set; }
        public PrimaryAddress PrimaryAddress { get; set; }
        public MailingAddress MailingAddress { get; set; }
    }

    public partial class AccountIntel
    {
        public long SicCode { get; set; }
        public string SicCodeDescription { get; set; }
        public string IncorporatedDate { get; set; }
        public long ReportedNumofEmployees { get; set; }
        public long FoodRating { get; set; }
        public string DfpTurnOverRangeByYear { get; set; }
        public string DfpEmployeeRangeByYear { get; set; }
        public string YearOverYearGrowth { get; set; }
        public long NumberOfGoogleReviews { get; set; }
        public long PublicNewsMentionScore { get; set; }
        public long NumberOfPublishedBlogPosts { get; set; }
        public long NumberOfPublishedArticles { get; set; }
        public string LatestPublicationDate { get; set; }
        public long NumberNewsmentions { get; set; }
        public string HasContentMgmtSystem { get; set; }
        public string HasLoginSystem { get; set; }
        public string HasContactForm { get; set; }
        public string HaseCommerceSystem { get; set; }
        public string HasGoogleAnalytics { get; set; }
        public string AsaCase { get; set; }
        public string DisqualifiedDirectors { get; set; }
        public string HseBreach { get; set; }
        public string HseCase { get; set; }
        public string HseNotice { get; set; }
        public string Ico { get; set; }
        public string IcoEnforcement { get; set; }
        public string JudiciaryTribunal { get; set; }
        public string Sanction { get; set; }
        public string BusinessWebsiteQualityScore { get; set; }
        public string SocialPresenceScore { get; set; }
        public string AggregatedBusinessReviewScore { get; set; }
        public string AggregatedReputationScore { get; set; }
        public string EaEnforcement { get; set; }
        public GoogleIntel GoogleIntel { get; set; }
        public CorporateFinancialInfo CorporateFinancialInfo { get; set; }
    }

    public partial class CorporateFinancialInfo
    {
        public string Currentassests { get; set; }
        public string TotalAssestsLessCurrLiailities { get; set; }
        public string NetCurrentAssests { get; set; }
        public string TotalNetAssests { get; set; }
        public string Fixedassests { get; set; }
        public string Creditors { get; set; }
        public string Debtors { get; set; }
        public string ReportedTurnover { get; set; }
    }

    public partial class GoogleIntel
    {
        public long NumberOfGoogleReviews { get; set; }
        public long GoogleReviewRating { get; set; }
        public string GoogleAccessibilityScore { get; set; }
        public string GooglePerformanceScore { get; set; }
        public string GoogleSeoScore { get; set; }
        public string GoogleBestPracticesScore { get; set; }
        public string GooglePwaScore { get; set; }
    }

    public partial class MailingAddress
    {
        public string MailingLatitude { get; set; }
        public string MailingLongitude { get; set; }
        public string MailingLine1 { get; set; }
        public string MailingLine2 { get; set; }
        public string MailingCity { get; set; }
        public string MailingCounty { get; set; }
        public string MailingStateProvCd { get; set; }
        public string MailingCountryCd { get; set; }
        public long MailingPostalZipCd { get; set; }
        public bool MailingSameAsPrimary { get; set; }
        public bool MailingIsPoBox { get; set; }
    }

    public partial class PrimaryAddress
    {
        public string PrimaryLatitude { get; set; }
        public string PrimaryLongitude { get; set; }
        public string PrimaryLine1 { get; set; }
        public string PrimaryLine2 { get; set; }
        public string PrimaryCity { get; set; }
        public string PrimaryCounty { get; set; }
        public string PrimaryStateProvCd { get; set; }
        public string PrimaryCountryCd { get; set; }
        public long PrimaryPostalZipCd { get; set; }
    }

    public partial class Location
    {
        public string LocationId { get; set; }
        public string Locationtype { get; set; }
        public long? BusinessAnnualWageroll { get; set; }
        public LocationAddress LocationAddress { get; set; }
        public LocationIntel LocationIntel { get; set; }
        public BuildingAsset BuildingAsset { get; set; }
        public AdditionalInterest Liability { get; set; }
    }

    public partial class BuildingAsset
    {
        public long? ContentsTsi { get; set; }
        public long? StockTsi { get; set; }
        public long YearBuilt { get; set; }
        public string IsbrickWallsStoneContreteRoofOfSlate { get; set; }
        public string IsGoodStateOfReair { get; set; }
        public string IsUnoccupiedFlatsAboveBus { get; set; }
        public long NumberOfLettingRooms { get; set; }
        public string RoofType { get; set; }
        public string IsccTv { get; set; }
        public string IsOpenAllYearRound { get; set; }
        public string IsRangeMaintainedAnnually { get; set; }
        public string IsRangeMaintainedSemiAnnually { get; set; }
        public string IsCertifiedElecetrical { get; set; }
        public string IsCertifiedLockAllDoors { get; set; }
        public string IsCertifiedLockCellarDoors { get; set; }
        public string IsWindowsSecured { get; set; }
        public string IsFireSupression { get; set; }
        public string IsDanceFloor { get; set; }
        public string IsAtMonPrem { get; set; }
        public string IsCloseAfter0130Am { get; set; }
        public string IsDeepFatFryer { get; set; }
        public string IsDoorSecurity { get; set; }
        public string IsDoesAnyoneLiveOnPremises { get; set; }
        public string IstenantsImprovementsCover { get; set; }
        public string IsbuildingImprovementsCover { get; set; }
        public long? BuildingReplacementValue { get; set; }
        public long? TenantsReplacementValue { get; set; }
        public AssetIntel BuildingAssetIntel { get; set; }
        public OptionalCoverages OptionalCoverages { get; set; }
        public AssetIntel HomeAssetIntel { get; set; }
    }

    public partial class AssetIntel
    {
        public long YearBuilt { get; set; }
        public string NumberOfstories { get; set; }
        public long MinimumNumberOfTenants { get; set; }
        public long SquareFootage { get; set; }
        public string RoofType { get; set; }
        public long TotalPropertySquareFootage { get; set; }
        public long ExternalSquareFootage { get; set; }
        public string Roofpitch { get; set; }
        public string RoofGeometry { get; set; }
        public string SolarPanelsOnRoof { get; set; }
        public string PercentageOfRoofCoveredBySolar { get; set; }
        public string WallContructionMaterial { get; set; }
    }

    public partial class OptionalCoverages
    {
        public string IsEquipmentBreakdown { get; set; }
        public string IsEmployeeDishonesty { get; set; }
        public string IsIncreaseGoodsInTransit { get; set; }
        public string IsIncreaseDeteriorationOfStockLimit { get; set; }
        public string IsIncreaseMoneyLimit { get; set; }
        public string IsLegalExpenses { get; set; }
        public string IsDomesticContentsCover { get; set; }
        public string IsReinstatementValuationCheck { get; set; }
        public string IsPersonalAccident { get; set; }
        public string IsUkResidentsAged1669 { get; set; }
    }

    public partial class LocationAddress
    {
        public string LocationLatitude { get; set; }
        public string LocationLongitude { get; set; }
        public string LocationLine1 { get; set; }
        public string LocationLine2 { get; set; }
        public string LocationCity { get; set; }
        public string LocationCounty { get; set; }
        public string LocationStateProvCd { get; set; }
        public string LocationCountryCd { get; set; }
        public string LocationPostalCd { get; set; }
        public bool LocationSameAsPrimary { get; set; }
        public long? LocationPostalZipCd { get; set; }
    }

    public partial class LocationIntel
    {
        public string CrimeRiskIndicatorByPostcode { get; set; }
        public long Countofcrimes { get; set; }
        public string QuarterToQuarterChangesOfCrimeRisk { get; set; }
        public EquipmentAsset EquipmentAsset { get; set; }
        public BuildingAsset BuildingAsset { get; set; }
    }

    public partial class EquipmentAsset
    {
        public ReplacementValues ReplacementValues { get; set; }
        public PortableEquipmentAsset[] PortableEquipmentAsset { get; set; }
    }

    public partial class PortableEquipmentAsset
    {
        public string EquipmentId { get; set; }
        public string EquipmentName { get; set; }
        public long ReplacementValue { get; set; }
    }

    public partial class ReplacementValues
    {
        public long Building { get; set; }
        public long ToolsAndEquipment { get; set; }
        public long BusinessAndOfficeEquipment { get; set; }
        public long Stock { get; set; }
        public long Contents { get; set; }
    }

    public partial class Opportunity
    {
        public Guid OpportunityId { get; set; }
        public string OpportunityName { get; set; }
        public string OpportunityType { get; set; }
        public string OpportunityReceivedOn { get; set; }
        public string OpportunityClosesOn { get; set; }
        public string OpportunityEffectiveOn { get; set; }
        public string OpportunityExpiresOn { get; set; }
        public string OpportunityStage { get; set; }
        public EligibilityCriteria EligibilityCriteria { get; set; }
        public LossDetail[] LossDetail { get; set; }
    }

    public partial class EligibilityCriteria
    {
        public string BusinessStatus { get; set; }
        public string IsTheBusinessErenExempted { get; set; }
        public long YearsInBusiness { get; set; }
        public string IsThereAnyThirdPartyInterests { get; set; }
        public string IsBankruptcyOrInsolvency { get; set; }
        public string IsConvictionsCriminalProsecutions { get; set; }
        public string IsDisputAndLegalExpenses { get; set; }
        public string IsLossOrClaim { get; set; }
        public long CountOfLossOrClaim { get; set; }
        public string IsInsuranceNonRenewed { get; set; }
    }

    public partial class LossDetail
    {
        public string LossId { get; set; }
        public string LossDate { get; set; }
        public string TypeOfIncident { get; set; }
        public long TotalValueOfClaim { get; set; }
    }

    public partial class Policy
    {
        public Guid PolicyId { get; set; }
        public string PolicySequenceNo { get; set; }
        public string PolicyNumber { get; set; }
        public string PolicyName { get; set; }
        public string PolicyStatus { get; set; }
        public string PolicyBoundedOn { get; set; }
        public string PolicyEffectiveOn { get; set; }
        public string PolicyExpiresOn { get; set; }
        public string PolicyCancelledOn { get; set; }
        public string PolicyCancellationReason { get; set; }
        public string PolicyReinstatedOn { get; set; }
        public PriorQuoteDetails PriorQuoteDetails { get; set; }
    }

    public partial class PriorQuoteDetails
    {
        public long PriorQuotePremium { get; set; }
        public string PriorTaxesAndSurcharges { get; set; }
        public string PriorTotalPremium { get; set; }
    }

    public partial class Quote
    {
        public Guid QuoteId { get; set; }
        public string QuoteNumber { get; set; }
        public string QuoteName { get; set; }
        public string QuoteCreatedOn { get; set; }
        public string QuoteClosesOn { get; set; }
        public string QuoteEffectiveOn { get; set; }
        public string QuoteExpiresOn { get; set; }
        public string QuoteStatus { get; set; }
        public string QuoteType { get; set; }
        public string AmendmentEffectiveOn { get; set; }
        public QuoteRatingDetails QuoteRatingDetails { get; set; }
    }

    public partial class QuoteRatingDetails
    {
        public Guid MasterSetId { get; set; }
        public string RatingStatus { get; set; }
        public long QuotePremium { get; set; }
        public string TaxesAndSurcharges { get; set; }
        public string TotalPremium { get; set; }
        public long Commission { get; set; }
        public Coverage[] Coverages { get; set; }
    }

    public partial class Coverage
    {
        public string CoverageCode { get; set; }
        public string CoverageName { get; set; }
        public string CoveragePremium { get; set; }
        public string CoverageOverridePremium { get; set; }
        public string CoverageRatingStatus { get; set; }
        public string CoverageRatingCode { get; set; }
        public string CoverageRatingDescription { get; set; }
        public Limit[] Limits { get; set; }
        public object[] Deductibles { get; set; }
        public object[] SubCoverages { get; set; }
        public string BuildingsReplacementValue { get; set; }
        public string TenantsReplacementValue { get; set; }
    }

    public partial class Limit
    {
        public string LimitsName { get; set; }
        public string LimitsType { get; set; }
        public string OptionType { get; set; }
        public string[] OptionPicklist { get; set; }
        public string OptionValueSelected { get; set; }
        public long? MinAmt { get; set; }
        public long? MaxAmt { get; set; }
        public object Increment { get; set; }
        public string LimitRatingStatus { get; set; }
        public string LimitRatingCode { get; set; }
        public string LimitRatingDescription { get; set; }
    }

}