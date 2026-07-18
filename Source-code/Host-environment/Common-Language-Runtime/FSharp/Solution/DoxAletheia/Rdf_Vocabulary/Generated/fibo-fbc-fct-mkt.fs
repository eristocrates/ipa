namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FunctionalEntities.Markets.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fbc_fct_mkt =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/ActiveMICStatus"></see>
    /// </summary>
    let ActiveMICStatus =
        Namespaced_IRI.parse _namespace_name "ActiveMICStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketIdentifierCodeStatus"></see>
    /// </summary>
    let MarketIdentifierCodeStatus =
        Namespaced_IRI.parse _namespace_name "MarketIdentifierCodeStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/AlternativeTradingSystem"></see>
    /// </summary>
    let AlternativeTradingSystem =
        Namespaced_IRI.parse _namespace_name "AlternativeTradingSystem" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/Exchange"></see>
    /// </summary>
    let Exchange = Namespaced_IRI.parse _namespace_name "Exchange" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-ATSS"></see>
    /// </summary>
    let ``MarketCategoryClassifier-ATSS`` =
        Namespaced_IRI.parse _namespace_name "MarketCategoryClassifier-ATSS" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/ApprovedPublicationArrangement"></see>
    /// </summary>
    let ApprovedPublicationArrangement =
        Namespaced_IRI.parse _namespace_name "ApprovedPublicationArrangement" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/DataReportingServicesProvider"></see>
    /// </summary>
    let DataReportingServicesProvider =
        Namespaced_IRI.parse _namespace_name "DataReportingServicesProvider" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-APPA"></see>
    /// </summary>
    let ``MarketCategoryClassifier-APPA`` =
        Namespaced_IRI.parse _namespace_name "MarketCategoryClassifier-APPA" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/ApprovedReportingMechanism"></see>
    /// </summary>
    let ApprovedReportingMechanism =
        Namespaced_IRI.parse _namespace_name "ApprovedReportingMechanism" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-ARMS"></see>
    /// </summary>
    let ``MarketCategoryClassifier-ARMS`` =
        Namespaced_IRI.parse _namespace_name "MarketCategoryClassifier-ARMS" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/AuctionMarket"></see>
    /// </summary>
    let AuctionMarket =
        Namespaced_IRI.parse _namespace_name "AuctionMarket" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/ConsolidatedTapeProvider"></see>
    /// </summary>
    let ConsolidatedTapeProvider =
        Namespaced_IRI.parse _namespace_name "ConsolidatedTapeProvider" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-CTPS"></see>
    /// </summary>
    let ``MarketCategoryClassifier-CTPS`` =
        Namespaced_IRI.parse _namespace_name "MarketCategoryClassifier-CTPS" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/CryptoAssetServicesProvider"></see>
    /// </summary>
    let CryptoAssetServicesProvider =
        Namespaced_IRI.parse _namespace_name "CryptoAssetServicesProvider" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-CASP"></see>
    /// </summary>
    let ``MarketCategoryClassifier-CASP`` =
        Namespaced_IRI.parse _namespace_name "MarketCategoryClassifier-CASP" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketIdentifier"></see>
    /// </summary>
    let MarketIdentifier =
        Namespaced_IRI.parse _namespace_name "MarketIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/hasFacilityAcronym"></see>
    /// </summary>
    let hasFacilityAcronym =
        Namespaced_IRI.parse _namespace_name "hasFacilityAcronym" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/operatesInCountry"></see>
    /// </summary>
    let operatesInCountry =
        Namespaced_IRI.parse _namespace_name "operatesInCountry" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/operatesInMunicipality"></see>
    /// </summary>
    let operatesInMunicipality =
        Namespaced_IRI.parse _namespace_name "operatesInMunicipality" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/DarkPool"></see>
    /// </summary>
    let DarkPool = Namespaced_IRI.parse _namespace_name "DarkPool" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/DesignatedContractMarket"></see>
    /// </summary>
    let DesignatedContractMarket =
        Namespaced_IRI.parse _namespace_name "DesignatedContractMarket" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-DCMS"></see>
    /// </summary>
    let ``MarketCategoryClassifier-DCMS`` =
        Namespaced_IRI.parse _namespace_name "MarketCategoryClassifier-DCMS" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/ElectronicCommunicationNetwork"></see>
    /// </summary>
    let ElectronicCommunicationNetwork =
        Namespaced_IRI.parse _namespace_name "ElectronicCommunicationNetwork" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/ExchangeParticipant"></see>
    /// </summary>
    let ExchangeParticipant =
        Namespaced_IRI.parse _namespace_name "ExchangeParticipant" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/ExpiredMICStatus"></see>
    /// </summary>
    let ExpiredMICStatus =
        Namespaced_IRI.parse _namespace_name "ExpiredMICStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/ISO10383-ClassificationScheme"></see>
    /// </summary>
    let ``ISO10383-ClassificationScheme`` =
        Namespaced_IRI.parse _namespace_name "ISO10383-ClassificationScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/InterdealerQuotationSystem"></see>
    /// </summary>
    let InterdealerQuotationSystem =
        Namespaced_IRI.parse _namespace_name "InterdealerQuotationSystem" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-IDQS"></see>
    /// </summary>
    let ``MarketCategoryClassifier-IDQS`` =
        Namespaced_IRI.parse _namespace_name "MarketCategoryClassifier-IDQS" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier"></see>
    /// </summary>
    let MarketCategoryClassifier =
        Namespaced_IRI.parse _namespace_name "MarketCategoryClassifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/TradeReportingFacility"></see>
    /// </summary>
    let TradeReportingFacility =
        Namespaced_IRI.parse _namespace_name "TradeReportingFacility" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-MLTF"></see>
    /// </summary>
    let ``MarketCategoryClassifier-MLTF`` =
        Namespaced_IRI.parse _namespace_name "MarketCategoryClassifier-MLTF" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-NSPD"></see>
    /// </summary>
    let ``MarketCategoryClassifier-NSPD`` =
        Namespaced_IRI.parse _namespace_name "MarketCategoryClassifier-NSPD" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-OTFS"></see>
    /// </summary>
    let ``MarketCategoryClassifier-OTFS`` =
        Namespaced_IRI.parse _namespace_name "MarketCategoryClassifier-OTFS" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-OTHR"></see>
    /// </summary>
    let ``MarketCategoryClassifier-OTHR`` =
        Namespaced_IRI.parse _namespace_name "MarketCategoryClassifier-OTHR" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-RMKT"></see>
    /// </summary>
    let ``MarketCategoryClassifier-RMKT`` =
        Namespaced_IRI.parse _namespace_name "MarketCategoryClassifier-RMKT" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-RMOS"></see>
    /// </summary>
    let ``MarketCategoryClassifier-RMOS`` =
        Namespaced_IRI.parse _namespace_name "MarketCategoryClassifier-RMOS" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-SEFS"></see>
    /// </summary>
    let ``MarketCategoryClassifier-SEFS`` =
        Namespaced_IRI.parse _namespace_name "MarketCategoryClassifier-SEFS" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-SINT"></see>
    /// </summary>
    let ``MarketCategoryClassifier-SINT`` =
        Namespaced_IRI.parse _namespace_name "MarketCategoryClassifier-SINT" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier-TRFS"></see>
    /// </summary>
    let ``MarketCategoryClassifier-TRFS`` =
        Namespaced_IRI.parse _namespace_name "MarketCategoryClassifier-TRFS" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketLevelClassifier"></see>
    /// </summary>
    let MarketLevelClassifier =
        Namespaced_IRI.parse _namespace_name "MarketLevelClassifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketLevelClassifier-OPRT"></see>
    /// </summary>
    let ``MarketLevelClassifier-OPRT`` =
        Namespaced_IRI.parse _namespace_name "MarketLevelClassifier-OPRT" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketLevelClassifier-SGMT"></see>
    /// </summary>
    let ``MarketLevelClassifier-SGMT`` =
        Namespaced_IRI.parse _namespace_name "MarketLevelClassifier-SGMT" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketSegmentLevelMarket"></see>
    /// </summary>
    let MarketSegmentLevelMarket =
        Namespaced_IRI.parse _namespace_name "MarketSegmentLevelMarket" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/OperatingLevelMarket"></see>
    /// </summary>
    let OperatingLevelMarket =
        Namespaced_IRI.parse _namespace_name "OperatingLevelMarket" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketSegmentLevelMarketIdentifier"></see>
    /// </summary>
    let MarketSegmentLevelMarketIdentifier =
        Namespaced_IRI.parse _namespace_name "MarketSegmentLevelMarketIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MultilateralTradingFacility"></see>
    /// </summary>
    let MultilateralTradingFacility =
        Namespaced_IRI.parse _namespace_name "MultilateralTradingFacility" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/OffMarketFacility"></see>
    /// </summary>
    let OffMarketFacility =
        Namespaced_IRI.parse _namespace_name "OffMarketFacility" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/OperatingLevelMarketIdentifier"></see>
    /// </summary>
    let OperatingLevelMarketIdentifier =
        Namespaced_IRI.parse _namespace_name "OperatingLevelMarketIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/OrganizedTradingFacility"></see>
    /// </summary>
    let OrganizedTradingFacility =
        Namespaced_IRI.parse _namespace_name "OrganizedTradingFacility" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/QuoteDrivenMarket"></see>
    /// </summary>
    let QuoteDrivenMarket =
        Namespaced_IRI.parse _namespace_name "QuoteDrivenMarket" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/RecognizedMarketOperator"></see>
    /// </summary>
    let RecognizedMarketOperator =
        Namespaced_IRI.parse _namespace_name "RecognizedMarketOperator" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/RegisteredMultilateralTradingFacility"></see>
    /// </summary>
    let RegisteredMultilateralTradingFacility =
        Namespaced_IRI.parse _namespace_name "RegisteredMultilateralTradingFacility" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/RegulatedExchange"></see>
    /// </summary>
    let RegulatedExchange =
        Namespaced_IRI.parse _namespace_name "RegulatedExchange" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/SwapExecutionFacility"></see>
    /// </summary>
    let SwapExecutionFacility =
        Namespaced_IRI.parse _namespace_name "SwapExecutionFacility" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/SystematicInternaliser"></see>
    /// </summary>
    let SystematicInternaliser =
        Namespaced_IRI.parse _namespace_name "SystematicInternaliser" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/UpdatedMICStatus"></see>
    /// </summary>
    let UpdatedMICStatus =
        Namespaced_IRI.parse _namespace_name "UpdatedMICStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/hasMarketIdentifierCodeStatus"></see>
    /// </summary>
    let hasMarketIdentifierCodeStatus =
        Namespaced_IRI.parse _namespace_name "hasMarketIdentifierCodeStatus" |> NamespacedName
