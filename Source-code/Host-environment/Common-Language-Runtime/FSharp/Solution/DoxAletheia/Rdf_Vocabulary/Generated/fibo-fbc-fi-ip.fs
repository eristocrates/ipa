namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FinancialInstruments.InstrumentPricing.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fbc_fi_ip =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/AdjustedClosingPrice"></see>
    /// </summary>
    let AdjustedClosingPrice =
        Namespaced_IRI.parse _namespace_name "AdjustedClosingPrice" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/ClosingPrice"></see>
    /// </summary>
    let ClosingPrice =
        Namespaced_IRI.parse _namespace_name "ClosingPrice" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/AuctionMethod"></see>
    /// </summary>
    let AuctionMethod =
        Namespaced_IRI.parse _namespace_name "AuctionMethod" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/PriceDeterminationMethod"></see>
    /// </summary>
    let PriceDeterminationMethod =
        Namespaced_IRI.parse _namespace_name "PriceDeterminationMethod" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/BestBid"></see>
    /// </summary>
    let BestBid = Namespaced_IRI.parse _namespace_name "BestBid" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/BidPrice"></see>
    /// </summary>
    let BidPrice = Namespaced_IRI.parse _namespace_name "BidPrice" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/BestOffer"></see>
    /// </summary>
    let BestOffer = Namespaced_IRI.parse _namespace_name "BestOffer" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/OfferPrice"></see>
    /// </summary>
    let OfferPrice = Namespaced_IRI.parse _namespace_name "OfferPrice" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/BidAskSpread"></see>
    /// </summary>
    let BidAskSpread =
        Namespaced_IRI.parse _namespace_name "BidAskSpread" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/PriceSpread"></see>
    /// </summary>
    let PriceSpread =
        Namespaced_IRI.parse _namespace_name "PriceSpread" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/SecurityPrice"></see>
    /// </summary>
    let SecurityPrice =
        Namespaced_IRI.parse _namespace_name "SecurityPrice" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/CleanPrice"></see>
    /// </summary>
    let CleanPrice = Namespaced_IRI.parse _namespace_name "CleanPrice" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/DirtyPrice"></see>
    /// </summary>
    let DirtyPrice = Namespaced_IRI.parse _namespace_name "DirtyPrice" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/MarketPrice"></see>
    /// </summary>
    let MarketPrice =
        Namespaced_IRI.parse _namespace_name "MarketPrice" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/ClosingPriceDeterminationMethod"></see>
    /// </summary>
    let ClosingPriceDeterminationMethod =
        Namespaced_IRI.parse _namespace_name "ClosingPriceDeterminationMethod" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/CollectionOfSecurityPrices"></see>
    /// </summary>
    let CollectionOfSecurityPrices =
        Namespaced_IRI.parse _namespace_name "CollectionOfSecurityPrices" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/CompositeMarket"></see>
    /// </summary>
    let CompositeMarket =
        Namespaced_IRI.parse _namespace_name "CompositeMarket" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/DerivedPrice"></see>
    /// </summary>
    let DerivedPrice =
        Namespaced_IRI.parse _namespace_name "DerivedPrice" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/HighPrice"></see>
    /// </summary>
    let HighPrice = Namespaced_IRI.parse _namespace_name "HighPrice" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/InternalRateOfReturn"></see>
    /// </summary>
    let InternalRateOfReturn =
        Namespaced_IRI.parse _namespace_name "InternalRateOfReturn" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/RateOfReturn"></see>
    /// </summary>
    let RateOfReturn =
        Namespaced_IRI.parse _namespace_name "RateOfReturn" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/IntraDayPrice"></see>
    /// </summary>
    let IntraDayPrice =
        Namespaced_IRI.parse _namespace_name "IntraDayPrice" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/LowPrice"></see>
    /// </summary>
    let LowPrice = Namespaced_IRI.parse _namespace_name "LowPrice" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasPricingSource"></see>
    /// </summary>
    let hasPricingSource =
        Namespaced_IRI.parse _namespace_name "hasPricingSource" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/MeanPriceDetermination"></see>
    /// </summary>
    let MeanPriceDetermination =
        Namespaced_IRI.parse _namespace_name "MeanPriceDetermination" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/MidPrice"></see>
    /// </summary>
    let MidPrice = Namespaced_IRI.parse _namespace_name "MidPrice" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/OfficialClosingPrice"></see>
    /// </summary>
    let OfficialClosingPrice =
        Namespaced_IRI.parse _namespace_name "OfficialClosingPrice" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasClosingPriceDeterminationMethod"></see>
    /// </summary>
    let hasClosingPriceDeterminationMethod =
        Namespaced_IRI.parse _namespace_name "hasClosingPriceDeterminationMethod" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/OpeningPrice"></see>
    /// </summary>
    let OpeningPrice =
        Namespaced_IRI.parse _namespace_name "OpeningPrice" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/PriceAnalytic"></see>
    /// </summary>
    let PriceAnalytic =
        Namespaced_IRI.parse _namespace_name "PriceAnalytic" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/PricingModel"></see>
    /// </summary>
    let PricingModel =
        Namespaced_IRI.parse _namespace_name "PricingModel" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/TradingDay"></see>
    /// </summary>
    let TradingDay = Namespaced_IRI.parse _namespace_name "TradingDay" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/TradingSession"></see>
    /// </summary>
    let TradingSession =
        Namespaced_IRI.parse _namespace_name "TradingSession" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/VolumeWeightedAveragePrice"></see>
    /// </summary>
    let VolumeWeightedAveragePrice =
        Namespaced_IRI.parse _namespace_name "VolumeWeightedAveragePrice" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/VolumeWeightedOpenPrice"></see>
    /// </summary>
    let VolumeWeightedOpenPrice =
        Namespaced_IRI.parse _namespace_name "VolumeWeightedOpenPrice" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/Yield"></see>
    /// </summary>
    let Yield = Namespaced_IRI.parse _namespace_name "Yield" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/YieldSpread"></see>
    /// </summary>
    let YieldSpread =
        Namespaced_IRI.parse _namespace_name "YieldSpread" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasBookDepth"></see>
    /// </summary>
    let hasBookDepth =
        Namespaced_IRI.parse _namespace_name "hasBookDepth" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasPriceDeterminationMethod"></see>
    /// </summary>
    let hasPriceDeterminationMethod =
        Namespaced_IRI.parse _namespace_name "hasPriceDeterminationMethod" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasLotSize"></see>
    /// </summary>
    let hasLotSize = Namespaced_IRI.parse _namespace_name "hasLotSize" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasNumberOfDaysAccrued"></see>
    /// </summary>
    let hasNumberOfDaysAccrued =
        Namespaced_IRI.parse _namespace_name "hasNumberOfDaysAccrued" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasQuoteLotSize"></see>
    /// </summary>
    let hasQuoteLotSize =
        Namespaced_IRI.parse _namespace_name "hasQuoteLotSize" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasRateOfReturn"></see>
    /// </summary>
    let hasRateOfReturn =
        Namespaced_IRI.parse _namespace_name "hasRateOfReturn" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasRoundLotSize"></see>
    /// </summary>
    let hasRoundLotSize =
        Namespaced_IRI.parse _namespace_name "hasRoundLotSize" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasTradingDateTime"></see>
    /// </summary>
    let hasTradingDateTime =
        Namespaced_IRI.parse _namespace_name "hasTradingDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasTradingVolume"></see>
    /// </summary>
    let hasTradingVolume =
        Namespaced_IRI.parse _namespace_name "hasTradingVolume" |> NamespacedName
