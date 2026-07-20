namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FunctionalEntities.Markets.slash

open DoxAletheia

module fibo_fbc_fct_mkt =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/ActiveMICStatus"></see>
    /// </summary>
    let ActiveMICStatus = _prefix "ActiveMICStatus"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketIdentifierCodeStatus"></see>
    /// </summary>
    let MarketIdentifierCodeStatus = _prefix "MarketIdentifierCodeStatus"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/AlternativeTradingSystem"></see>
    /// </summary>
    let AlternativeTradingSystem = _prefix "AlternativeTradingSystem"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/Exchange"></see>
    /// </summary>
    let Exchange = _prefix "Exchange"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-ATSS"></see>
    /// </summary>
    let ``MarketCategoryClassifier-ATSS`` = _prefix "MarketCategoryClassifier-ATSS"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/ApprovedPublicationArrangement"></see>
    /// </summary>
    let ApprovedPublicationArrangement = _prefix "ApprovedPublicationArrangement"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/DataReportingServicesProvider"></see>
    /// </summary>
    let DataReportingServicesProvider = _prefix "DataReportingServicesProvider"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-APPA"></see>
    /// </summary>
    let ``MarketCategoryClassifier-APPA`` = _prefix "MarketCategoryClassifier-APPA"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/ApprovedReportingMechanism"></see>
    /// </summary>
    let ApprovedReportingMechanism = _prefix "ApprovedReportingMechanism"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-ARMS"></see>
    /// </summary>
    let ``MarketCategoryClassifier-ARMS`` = _prefix "MarketCategoryClassifier-ARMS"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/AuctionMarket"></see>
    /// </summary>
    let AuctionMarket = _prefix "AuctionMarket"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/ConsolidatedTapeProvider"></see>
    /// </summary>
    let ConsolidatedTapeProvider = _prefix "ConsolidatedTapeProvider"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-CTPS"></see>
    /// </summary>
    let ``MarketCategoryClassifier-CTPS`` = _prefix "MarketCategoryClassifier-CTPS"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/CryptoAssetServicesProvider"></see>
    /// </summary>
    let CryptoAssetServicesProvider = _prefix "CryptoAssetServicesProvider"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-CASP"></see>
    /// </summary>
    let ``MarketCategoryClassifier-CASP`` = _prefix "MarketCategoryClassifier-CASP"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketIdentifier"></see>
    /// </summary>
    let MarketIdentifier = _prefix "MarketIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/hasFacilityAcronym"></see>
    /// </summary>
    let hasFacilityAcronym = _prefix "hasFacilityAcronym"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/operatesInCountry"></see>
    /// </summary>
    let operatesInCountry = _prefix "operatesInCountry"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/operatesInMunicipality"></see>
    /// </summary>
    let operatesInMunicipality = _prefix "operatesInMunicipality"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/DarkPool"></see>
    /// </summary>
    let DarkPool = _prefix "DarkPool"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/DesignatedContractMarket"></see>
    /// </summary>
    let DesignatedContractMarket = _prefix "DesignatedContractMarket"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-DCMS"></see>
    /// </summary>
    let ``MarketCategoryClassifier-DCMS`` = _prefix "MarketCategoryClassifier-DCMS"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/ElectronicCommunicationNetwork"></see>
    /// </summary>
    let ElectronicCommunicationNetwork = _prefix "ElectronicCommunicationNetwork"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/ExchangeParticipant"></see>
    /// </summary>
    let ExchangeParticipant = _prefix "ExchangeParticipant"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/ExpiredMICStatus"></see>
    /// </summary>
    let ExpiredMICStatus = _prefix "ExpiredMICStatus"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/ISO10383-ClassificationScheme"></see>
    /// </summary>
    let ``ISO10383-ClassificationScheme`` = _prefix "ISO10383-ClassificationScheme"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/InterdealerQuotationSystem"></see>
    /// </summary>
    let InterdealerQuotationSystem = _prefix "InterdealerQuotationSystem"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-IDQS"></see>
    /// </summary>
    let ``MarketCategoryClassifier-IDQS`` = _prefix "MarketCategoryClassifier-IDQS"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier"></see>
    /// </summary>
    let MarketCategoryClassifier = _prefix "MarketCategoryClassifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/TradeReportingFacility"></see>
    /// </summary>
    let TradeReportingFacility = _prefix "TradeReportingFacility"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-MLTF"></see>
    /// </summary>
    let ``MarketCategoryClassifier-MLTF`` = _prefix "MarketCategoryClassifier-MLTF"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-NSPD"></see>
    /// </summary>
    let ``MarketCategoryClassifier-NSPD`` = _prefix "MarketCategoryClassifier-NSPD"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-OTFS"></see>
    /// </summary>
    let ``MarketCategoryClassifier-OTFS`` = _prefix "MarketCategoryClassifier-OTFS"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-OTHR"></see>
    /// </summary>
    let ``MarketCategoryClassifier-OTHR`` = _prefix "MarketCategoryClassifier-OTHR"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-RMKT"></see>
    /// </summary>
    let ``MarketCategoryClassifier-RMKT`` = _prefix "MarketCategoryClassifier-RMKT"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-RMOS"></see>
    /// </summary>
    let ``MarketCategoryClassifier-RMOS`` = _prefix "MarketCategoryClassifier-RMOS"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-SEFS"></see>
    /// </summary>
    let ``MarketCategoryClassifier-SEFS`` = _prefix "MarketCategoryClassifier-SEFS"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-SINT"></see>
    /// </summary>
    let ``MarketCategoryClassifier-SINT`` = _prefix "MarketCategoryClassifier-SINT"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-TRFS"></see>
    /// </summary>
    let ``MarketCategoryClassifier-TRFS`` = _prefix "MarketCategoryClassifier-TRFS"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketLevelClassifier"></see>
    /// </summary>
    let MarketLevelClassifier = _prefix "MarketLevelClassifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketLevelClassifier-OPRT"></see>
    /// </summary>
    let ``MarketLevelClassifier-OPRT`` = _prefix "MarketLevelClassifier-OPRT"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketLevelClassifier-SGMT"></see>
    /// </summary>
    let ``MarketLevelClassifier-SGMT`` = _prefix "MarketLevelClassifier-SGMT"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketSegmentLevelMarket"></see>
    /// </summary>
    let MarketSegmentLevelMarket = _prefix "MarketSegmentLevelMarket"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/OperatingLevelMarket"></see>
    /// </summary>
    let OperatingLevelMarket = _prefix "OperatingLevelMarket"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketSegmentLevelMarketIdentifier"></see>
    /// </summary>
    let MarketSegmentLevelMarketIdentifier =
        _prefix "MarketSegmentLevelMarketIdentifier"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MultilateralTradingFacility"></see>
    /// </summary>
    let MultilateralTradingFacility = _prefix "MultilateralTradingFacility"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/OffMarketFacility"></see>
    /// </summary>
    let OffMarketFacility = _prefix "OffMarketFacility"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/OperatingLevelMarketIdentifier"></see>
    /// </summary>
    let OperatingLevelMarketIdentifier = _prefix "OperatingLevelMarketIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/OrganizedTradingFacility"></see>
    /// </summary>
    let OrganizedTradingFacility = _prefix "OrganizedTradingFacility"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/QuoteDrivenMarket"></see>
    /// </summary>
    let QuoteDrivenMarket = _prefix "QuoteDrivenMarket"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/RecognizedMarketOperator"></see>
    /// </summary>
    let RecognizedMarketOperator = _prefix "RecognizedMarketOperator"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/RegisteredMultilateralTradingFacility"></see>
    /// </summary>
    let RegisteredMultilateralTradingFacility =
        _prefix "RegisteredMultilateralTradingFacility"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/RegulatedExchange"></see>
    /// </summary>
    let RegulatedExchange = _prefix "RegulatedExchange"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/SwapExecutionFacility"></see>
    /// </summary>
    let SwapExecutionFacility = _prefix "SwapExecutionFacility"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/SystematicInternaliser"></see>
    /// </summary>
    let SystematicInternaliser = _prefix "SystematicInternaliser"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/UpdatedMICStatus"></see>
    /// </summary>
    let UpdatedMICStatus = _prefix "UpdatedMICStatus"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/hasMarketIdentifierCodeStatus"></see>
    /// </summary>
    let hasMarketIdentifierCodeStatus = _prefix "hasMarketIdentifierCodeStatus"
