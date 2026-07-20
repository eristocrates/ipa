namespace https.spec.edmcouncil.org.fibo.ontology.FBC.ProductsAndServices.FinancialProductsAndServices.slash

open DoxAletheia

module fibo_fbc_pas_fpas =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/AgencyAgreement"></see>
    /// </summary>
    let AgencyAgreement = _prefix "AgencyAgreement"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/RegisteredAgent"></see>
    /// </summary>
    let RegisteredAgent = _prefix "RegisteredAgent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/AgentForServiceOfProcess"></see>
    /// </summary>
    let AgentForServiceOfProcess = _prefix "AgentForServiceOfProcess"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/AmendedTrade"></see>
    /// </summary>
    let AmendedTrade = _prefix "AmendedTrade"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradeLifecycleStage"></see>
    /// </summary>
    let TradeLifecycleStage = _prefix "TradeLifecycleStage"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Basket"></see>
    /// </summary>
    let Basket = _prefix "Basket"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasSelectingParty"></see>
    /// </summary>
    let hasSelectingParty = _prefix "hasSelectingParty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasSelectionCriteria"></see>
    /// </summary>
    let hasSelectionCriteria = _prefix "hasSelectionCriteria"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/BasketConstituent"></see>
    /// </summary>
    let BasketConstituent = _prefix "BasketConstituent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Broker"></see>
    /// </summary>
    let Broker = _prefix "Broker"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/LicensedAgent"></see>
    /// </summary>
    let LicensedAgent = _prefix "LicensedAgent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ThirdPartyAgent"></see>
    /// </summary>
    let ThirdPartyAgent = _prefix "ThirdPartyAgent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/BrokerDealer"></see>
    /// </summary>
    let BrokerDealer = _prefix "BrokerDealer"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Dealer"></see>
    /// </summary>
    let Dealer = _prefix "Dealer"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Catalog"></see>
    /// </summary>
    let Catalog = _prefix "Catalog"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ClearedTrade"></see>
    /// </summary>
    let ClearedTrade = _prefix "ClearedTrade"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ClosedTrade"></see>
    /// </summary>
    let ClosedTrade = _prefix "ClosedTrade"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ContractLifecycle"></see>
    /// </summary>
    let ContractLifecycle = _prefix "ContractLifecycle"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ContractLifecycleStage"></see>
    /// </summary>
    let ContractLifecycleStage = _prefix "ContractLifecycleStage"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ContractLifecycleEvent"></see>
    /// </summary>
    let ContractLifecycleEvent = _prefix "ContractLifecycleEvent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ContractLifecycleEventOccurrence"></see>
    /// </summary>
    let ContractLifecycleEventOccurrence = _prefix "ContractLifecycleEventOccurrence"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ContractLifecycleStageOccurrence"></see>
    /// </summary>
    let ContractLifecycleStageOccurrence = _prefix "ContractLifecycleStageOccurrence"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ContractLifecycleOccurrence"></see>
    /// </summary>
    let ContractLifecycleOccurrence = _prefix "ContractLifecycleOccurrence"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Exposure"></see>
    /// </summary>
    let Exposure = _prefix "Exposure"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/FinancialExposure"></see>
    /// </summary>
    let FinancialExposure = _prefix "FinancialExposure"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/FinancialIntermediationService"></see>
    /// </summary>
    let FinancialIntermediationService = _prefix "FinancialIntermediationService"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/FinancialService"></see>
    /// </summary>
    let FinancialService = _prefix "FinancialService"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/FinancialProduct"></see>
    /// </summary>
    let FinancialProduct = _prefix "FinancialProduct"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/FinancialServiceProvider"></see>
    /// </summary>
    let FinancialServiceProvider = _prefix "FinancialServiceProvider"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/FinancialProductCatalog"></see>
    /// </summary>
    let FinancialProductCatalog = _prefix "FinancialProductCatalog"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Holding"></see>
    /// </summary>
    let Holding = _prefix "Holding"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/LegalAgent"></see>
    /// </summary>
    let LegalAgent = _prefix "LegalAgent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/MaturedTrade"></see>
    /// </summary>
    let MaturedTrade = _prefix "MaturedTrade"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Offeree"></see>
    /// </summary>
    let Offeree = _prefix "Offeree"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Offering"></see>
    /// </summary>
    let Offering = _prefix "Offering"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Offeror"></see>
    /// </summary>
    let Offeror = _prefix "Offeror"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/OpenTrade"></see>
    /// </summary>
    let OpenTrade = _prefix "OpenTrade"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Position"></see>
    /// </summary>
    let Position = _prefix "Position"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ProductLifecycle"></see>
    /// </summary>
    let ProductLifecycle = _prefix "ProductLifecycle"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ProductLifecycleStage"></see>
    /// </summary>
    let ProductLifecycleStage = _prefix "ProductLifecycleStage"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ProductLifecycleEvent"></see>
    /// </summary>
    let ProductLifecycleEvent = _prefix "ProductLifecycleEvent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ProductLifecycleEventOccurrence"></see>
    /// </summary>
    let ProductLifecycleEventOccurrence = _prefix "ProductLifecycleEventOccurrence"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ProductLifecycleStageOccurrence"></see>
    /// </summary>
    let ProductLifecycleStageOccurrence = _prefix "ProductLifecycleStageOccurrence"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/ProductLifecycleOccurrence"></see>
    /// </summary>
    let ProductLifecycleOccurrence = _prefix "ProductLifecycleOccurrence"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/RegulatedCommodity"></see>
    /// </summary>
    let RegulatedCommodity = _prefix "RegulatedCommodity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/SettlementTerms"></see>
    /// </summary>
    let SettlementTerms = _prefix "SettlementTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasSettlementDate"></see>
    /// </summary>
    let hasSettlementDate = _prefix "hasSettlementDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TerminatedTrade"></see>
    /// </summary>
    let TerminatedTrade = _prefix "TerminatedTrade"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Trade"></see>
    /// </summary>
    let Trade = _prefix "Trade"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradeIdentifier"></see>
    /// </summary>
    let TradeIdentifier = _prefix "TradeIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradeLifecycle"></see>
    /// </summary>
    let TradeLifecycle = _prefix "TradeLifecycle"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/isFacilitatedBy"></see>
    /// </summary>
    let isFacilitatedBy = _prefix "isFacilitatedBy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/Trader"></see>
    /// </summary>
    let Trader = _prefix "Trader"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/isEmbodiedIn"></see>
    /// </summary>
    let isEmbodiedIn = _prefix "isEmbodiedIn"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradeLifecycleEvent"></see>
    /// </summary>
    let TradeLifecycleEvent = _prefix "TradeLifecycleEvent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradeLifecycleEventOccurrence"></see>
    /// </summary>
    let TradeLifecycleEventOccurrence = _prefix "TradeLifecycleEventOccurrence"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradeLifecycleStageOccurrence"></see>
    /// </summary>
    let TradeLifecycleStageOccurrence = _prefix "TradeLifecycleStageOccurrence"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradeLifecycleOccurrence"></see>
    /// </summary>
    let TradeLifecycleOccurrence = _prefix "TradeLifecycleOccurrence"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/facilitates"></see>
    /// </summary>
    let facilitates = _prefix "facilitates"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/TradingStrategy"></see>
    /// </summary>
    let TradingStrategy = _prefix "TradingStrategy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/UniqueTransactionIdentifier"></see>
    /// </summary>
    let UniqueTransactionIdentifier = _prefix "UniqueTransactionIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasGeneratingEntity"></see>
    /// </summary>
    let hasGeneratingEntity = _prefix "hasGeneratingEntity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/WeightedBasket"></see>
    /// </summary>
    let WeightedBasket = _prefix "WeightedBasket"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/WeightedBasketConstituent"></see>
    /// </summary>
    let WeightedBasketConstituent = _prefix "WeightedBasketConstituent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasGeneratingEntityIdentifier"></see>
    /// </summary>
    let hasGeneratingEntityIdentifier = _prefix "hasGeneratingEntityIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasLegalAgent"></see>
    /// </summary>
    let hasLegalAgent = _prefix "hasLegalAgent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasNominalNumberOfUnits"></see>
    /// </summary>
    let hasNominalNumberOfUnits = _prefix "hasNominalNumberOfUnits"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasOffering"></see>
    /// </summary>
    let hasOffering = _prefix "hasOffering"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/isOfferingOf"></see>
    /// </summary>
    let isOfferingOf = _prefix "isOfferingOf"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasOfferingAmount"></see>
    /// </summary>
    let hasOfferingAmount = _prefix "hasOfferingAmount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasOfferingPrice"></see>
    /// </summary>
    let hasOfferingPrice = _prefix "hasOfferingPrice"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasOfferingUnits"></see>
    /// </summary>
    let hasOfferingUnits = _prefix "hasOfferingUnits"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/hasTradeDate"></see>
    /// </summary>
    let hasTradeDate = _prefix "hasTradeDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/relatesTo"></see>
    /// </summary>
    let relatesTo = _prefix "relatesTo"
