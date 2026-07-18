namespace https.spec.edmcouncil.org.fibo.ontology.FBC.ProductsAndServices.FinancialProductsAndServices.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fbc_pas_fpas =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/AgencyAgreement"></see>
    /// </summary>
    let AgencyAgreement =
        Namespaced_IRI.parse _namespace_name "AgencyAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/RegisteredAgent"></see>
    /// </summary>
    let RegisteredAgent =
        Namespaced_IRI.parse _namespace_name "RegisteredAgent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/AgentForServiceOfProcess"></see>
    /// </summary>
    let AgentForServiceOfProcess =
        Namespaced_IRI.parse _namespace_name "AgentForServiceOfProcess" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/AmendedTrade"></see>
    /// </summary>
    let AmendedTrade =
        Namespaced_IRI.parse _namespace_name "AmendedTrade" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradeLifecycleStage"></see>
    /// </summary>
    let TradeLifecycleStage =
        Namespaced_IRI.parse _namespace_name "TradeLifecycleStage" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Basket"></see>
    /// </summary>
    let Basket = Namespaced_IRI.parse _namespace_name "Basket" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasSelectingParty"></see>
    /// </summary>
    let hasSelectingParty =
        Namespaced_IRI.parse _namespace_name "hasSelectingParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasSelectionCriteria"></see>
    /// </summary>
    let hasSelectionCriteria =
        Namespaced_IRI.parse _namespace_name "hasSelectionCriteria" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/BasketConstituent"></see>
    /// </summary>
    let BasketConstituent =
        Namespaced_IRI.parse _namespace_name "BasketConstituent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Broker"></see>
    /// </summary>
    let Broker = Namespaced_IRI.parse _namespace_name "Broker" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/LicensedAgent"></see>
    /// </summary>
    let LicensedAgent =
        Namespaced_IRI.parse _namespace_name "LicensedAgent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ThirdPartyAgent"></see>
    /// </summary>
    let ThirdPartyAgent =
        Namespaced_IRI.parse _namespace_name "ThirdPartyAgent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/BrokerDealer"></see>
    /// </summary>
    let BrokerDealer =
        Namespaced_IRI.parse _namespace_name "BrokerDealer" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Dealer"></see>
    /// </summary>
    let Dealer = Namespaced_IRI.parse _namespace_name "Dealer" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Catalog"></see>
    /// </summary>
    let Catalog = Namespaced_IRI.parse _namespace_name "Catalog" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ClearedTrade"></see>
    /// </summary>
    let ClearedTrade =
        Namespaced_IRI.parse _namespace_name "ClearedTrade" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ClosedTrade"></see>
    /// </summary>
    let ClosedTrade =
        Namespaced_IRI.parse _namespace_name "ClosedTrade" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ContractLifecycle"></see>
    /// </summary>
    let ContractLifecycle =
        Namespaced_IRI.parse _namespace_name "ContractLifecycle" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ContractLifecycleStage"></see>
    /// </summary>
    let ContractLifecycleStage =
        Namespaced_IRI.parse _namespace_name "ContractLifecycleStage" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ContractLifecycleEvent"></see>
    /// </summary>
    let ContractLifecycleEvent =
        Namespaced_IRI.parse _namespace_name "ContractLifecycleEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ContractLifecycleEventOccurrence"></see>
    /// </summary>
    let ContractLifecycleEventOccurrence =
        Namespaced_IRI.parse _namespace_name "ContractLifecycleEventOccurrence" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ContractLifecycleStageOccurrence"></see>
    /// </summary>
    let ContractLifecycleStageOccurrence =
        Namespaced_IRI.parse _namespace_name "ContractLifecycleStageOccurrence" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ContractLifecycleOccurrence"></see>
    /// </summary>
    let ContractLifecycleOccurrence =
        Namespaced_IRI.parse _namespace_name "ContractLifecycleOccurrence" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Exposure"></see>
    /// </summary>
    let Exposure = Namespaced_IRI.parse _namespace_name "Exposure" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/FinancialExposure"></see>
    /// </summary>
    let FinancialExposure =
        Namespaced_IRI.parse _namespace_name "FinancialExposure" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/FinancialIntermediationService"></see>
    /// </summary>
    let FinancialIntermediationService =
        Namespaced_IRI.parse _namespace_name "FinancialIntermediationService" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/FinancialService"></see>
    /// </summary>
    let FinancialService =
        Namespaced_IRI.parse _namespace_name "FinancialService" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/FinancialProduct"></see>
    /// </summary>
    let FinancialProduct =
        Namespaced_IRI.parse _namespace_name "FinancialProduct" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/FinancialServiceProvider"></see>
    /// </summary>
    let FinancialServiceProvider =
        Namespaced_IRI.parse _namespace_name "FinancialServiceProvider" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/FinancialProductCatalog"></see>
    /// </summary>
    let FinancialProductCatalog =
        Namespaced_IRI.parse _namespace_name "FinancialProductCatalog" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Holding"></see>
    /// </summary>
    let Holding = Namespaced_IRI.parse _namespace_name "Holding" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/LegalAgent"></see>
    /// </summary>
    let LegalAgent = Namespaced_IRI.parse _namespace_name "LegalAgent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/MaturedTrade"></see>
    /// </summary>
    let MaturedTrade =
        Namespaced_IRI.parse _namespace_name "MaturedTrade" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Offeree"></see>
    /// </summary>
    let Offeree = Namespaced_IRI.parse _namespace_name "Offeree" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Offering"></see>
    /// </summary>
    let Offering = Namespaced_IRI.parse _namespace_name "Offering" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Offeror"></see>
    /// </summary>
    let Offeror = Namespaced_IRI.parse _namespace_name "Offeror" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/OpenTrade"></see>
    /// </summary>
    let OpenTrade = Namespaced_IRI.parse _namespace_name "OpenTrade" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Position"></see>
    /// </summary>
    let Position = Namespaced_IRI.parse _namespace_name "Position" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ProductLifecycle"></see>
    /// </summary>
    let ProductLifecycle =
        Namespaced_IRI.parse _namespace_name "ProductLifecycle" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ProductLifecycleStage"></see>
    /// </summary>
    let ProductLifecycleStage =
        Namespaced_IRI.parse _namespace_name "ProductLifecycleStage" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ProductLifecycleEvent"></see>
    /// </summary>
    let ProductLifecycleEvent =
        Namespaced_IRI.parse _namespace_name "ProductLifecycleEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ProductLifecycleEventOccurrence"></see>
    /// </summary>
    let ProductLifecycleEventOccurrence =
        Namespaced_IRI.parse _namespace_name "ProductLifecycleEventOccurrence" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ProductLifecycleStageOccurrence"></see>
    /// </summary>
    let ProductLifecycleStageOccurrence =
        Namespaced_IRI.parse _namespace_name "ProductLifecycleStageOccurrence" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ProductLifecycleOccurrence"></see>
    /// </summary>
    let ProductLifecycleOccurrence =
        Namespaced_IRI.parse _namespace_name "ProductLifecycleOccurrence" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/RegulatedCommodity"></see>
    /// </summary>
    let RegulatedCommodity =
        Namespaced_IRI.parse _namespace_name "RegulatedCommodity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/SettlementTerms"></see>
    /// </summary>
    let SettlementTerms =
        Namespaced_IRI.parse _namespace_name "SettlementTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasSettlementDate"></see>
    /// </summary>
    let hasSettlementDate =
        Namespaced_IRI.parse _namespace_name "hasSettlementDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TerminatedTrade"></see>
    /// </summary>
    let TerminatedTrade =
        Namespaced_IRI.parse _namespace_name "TerminatedTrade" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Trade"></see>
    /// </summary>
    let Trade = Namespaced_IRI.parse _namespace_name "Trade" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradeIdentifier"></see>
    /// </summary>
    let TradeIdentifier =
        Namespaced_IRI.parse _namespace_name "TradeIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradeLifecycle"></see>
    /// </summary>
    let TradeLifecycle =
        Namespaced_IRI.parse _namespace_name "TradeLifecycle" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/isFacilitatedBy"></see>
    /// </summary>
    let isFacilitatedBy =
        Namespaced_IRI.parse _namespace_name "isFacilitatedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Trader"></see>
    /// </summary>
    let Trader = Namespaced_IRI.parse _namespace_name "Trader" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/isEmbodiedIn"></see>
    /// </summary>
    let isEmbodiedIn =
        Namespaced_IRI.parse _namespace_name "isEmbodiedIn" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradeLifecycleEvent"></see>
    /// </summary>
    let TradeLifecycleEvent =
        Namespaced_IRI.parse _namespace_name "TradeLifecycleEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradeLifecycleEventOccurrence"></see>
    /// </summary>
    let TradeLifecycleEventOccurrence =
        Namespaced_IRI.parse _namespace_name "TradeLifecycleEventOccurrence" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradeLifecycleStageOccurrence"></see>
    /// </summary>
    let TradeLifecycleStageOccurrence =
        Namespaced_IRI.parse _namespace_name "TradeLifecycleStageOccurrence" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradeLifecycleOccurrence"></see>
    /// </summary>
    let TradeLifecycleOccurrence =
        Namespaced_IRI.parse _namespace_name "TradeLifecycleOccurrence" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/facilitates"></see>
    /// </summary>
    let facilitates =
        Namespaced_IRI.parse _namespace_name "facilitates" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradingStrategy"></see>
    /// </summary>
    let TradingStrategy =
        Namespaced_IRI.parse _namespace_name "TradingStrategy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/UniqueTransactionIdentifier"></see>
    /// </summary>
    let UniqueTransactionIdentifier =
        Namespaced_IRI.parse _namespace_name "UniqueTransactionIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasGeneratingEntity"></see>
    /// </summary>
    let hasGeneratingEntity =
        Namespaced_IRI.parse _namespace_name "hasGeneratingEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/WeightedBasket"></see>
    /// </summary>
    let WeightedBasket =
        Namespaced_IRI.parse _namespace_name "WeightedBasket" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/WeightedBasketConstituent"></see>
    /// </summary>
    let WeightedBasketConstituent =
        Namespaced_IRI.parse _namespace_name "WeightedBasketConstituent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasGeneratingEntityIdentifier"></see>
    /// </summary>
    let hasGeneratingEntityIdentifier =
        Namespaced_IRI.parse _namespace_name "hasGeneratingEntityIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasLegalAgent"></see>
    /// </summary>
    let hasLegalAgent =
        Namespaced_IRI.parse _namespace_name "hasLegalAgent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasNominalNumberOfUnits"></see>
    /// </summary>
    let hasNominalNumberOfUnits =
        Namespaced_IRI.parse _namespace_name "hasNominalNumberOfUnits" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasOffering"></see>
    /// </summary>
    let hasOffering =
        Namespaced_IRI.parse _namespace_name "hasOffering" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/isOfferingOf"></see>
    /// </summary>
    let isOfferingOf =
        Namespaced_IRI.parse _namespace_name "isOfferingOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasOfferingAmount"></see>
    /// </summary>
    let hasOfferingAmount =
        Namespaced_IRI.parse _namespace_name "hasOfferingAmount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasOfferingPrice"></see>
    /// </summary>
    let hasOfferingPrice =
        Namespaced_IRI.parse _namespace_name "hasOfferingPrice" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasOfferingUnits"></see>
    /// </summary>
    let hasOfferingUnits =
        Namespaced_IRI.parse _namespace_name "hasOfferingUnits" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasTradeDate"></see>
    /// </summary>
    let hasTradeDate =
        Namespaced_IRI.parse _namespace_name "hasTradeDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/relatesTo"></see>
    /// </summary>
    let relatesTo = Namespaced_IRI.parse _namespace_name "relatesTo" |> NamespacedName
