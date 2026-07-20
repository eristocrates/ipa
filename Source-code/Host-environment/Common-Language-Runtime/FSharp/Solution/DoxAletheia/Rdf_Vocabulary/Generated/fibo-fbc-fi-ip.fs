namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FinancialInstruments.InstrumentPricing.slash

open DoxAletheia

module fibo_fbc_fi_ip =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/AdjustedClosingPrice"></see>
    /// </summary>
    let AdjustedClosingPrice = _prefix "AdjustedClosingPrice"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/ClosingPrice"></see>
    /// </summary>
    let ClosingPrice = _prefix "ClosingPrice"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/AuctionMethod"></see>
    /// </summary>
    let AuctionMethod = _prefix "AuctionMethod"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/PriceDeterminationMethod"></see>
    /// </summary>
    let PriceDeterminationMethod = _prefix "PriceDeterminationMethod"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/BestBid"></see>
    /// </summary>
    let BestBid = _prefix "BestBid"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/BidPrice"></see>
    /// </summary>
    let BidPrice = _prefix "BidPrice"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/BestOffer"></see>
    /// </summary>
    let BestOffer = _prefix "BestOffer"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/OfferPrice"></see>
    /// </summary>
    let OfferPrice = _prefix "OfferPrice"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/BidAskSpread"></see>
    /// </summary>
    let BidAskSpread = _prefix "BidAskSpread"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/PriceSpread"></see>
    /// </summary>
    let PriceSpread = _prefix "PriceSpread"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/SecurityPrice"></see>
    /// </summary>
    let SecurityPrice = _prefix "SecurityPrice"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/CleanPrice"></see>
    /// </summary>
    let CleanPrice = _prefix "CleanPrice"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/DirtyPrice"></see>
    /// </summary>
    let DirtyPrice = _prefix "DirtyPrice"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/MarketPrice"></see>
    /// </summary>
    let MarketPrice = _prefix "MarketPrice"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/ClosingPriceDeterminationMethod"></see>
    /// </summary>
    let ClosingPriceDeterminationMethod = _prefix "ClosingPriceDeterminationMethod"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/CollectionOfSecurityPrices"></see>
    /// </summary>
    let CollectionOfSecurityPrices = _prefix "CollectionOfSecurityPrices"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/CompositeMarket"></see>
    /// </summary>
    let CompositeMarket = _prefix "CompositeMarket"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/DerivedPrice"></see>
    /// </summary>
    let DerivedPrice = _prefix "DerivedPrice"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/HighPrice"></see>
    /// </summary>
    let HighPrice = _prefix "HighPrice"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/InternalRateOfReturn"></see>
    /// </summary>
    let InternalRateOfReturn = _prefix "InternalRateOfReturn"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/RateOfReturn"></see>
    /// </summary>
    let RateOfReturn = _prefix "RateOfReturn"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/IntraDayPrice"></see>
    /// </summary>
    let IntraDayPrice = _prefix "IntraDayPrice"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/LowPrice"></see>
    /// </summary>
    let LowPrice = _prefix "LowPrice"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasPricingSource"></see>
    /// </summary>
    let hasPricingSource = _prefix "hasPricingSource"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/MeanPriceDetermination"></see>
    /// </summary>
    let MeanPriceDetermination = _prefix "MeanPriceDetermination"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/MidPrice"></see>
    /// </summary>
    let MidPrice = _prefix "MidPrice"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/OfficialClosingPrice"></see>
    /// </summary>
    let OfficialClosingPrice = _prefix "OfficialClosingPrice"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasClosingPriceDeterminationMethod"></see>
    /// </summary>
    let hasClosingPriceDeterminationMethod =
        _prefix "hasClosingPriceDeterminationMethod"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/OpeningPrice"></see>
    /// </summary>
    let OpeningPrice = _prefix "OpeningPrice"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/PriceAnalytic"></see>
    /// </summary>
    let PriceAnalytic = _prefix "PriceAnalytic"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/PricingModel"></see>
    /// </summary>
    let PricingModel = _prefix "PricingModel"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/TradingDay"></see>
    /// </summary>
    let TradingDay = _prefix "TradingDay"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/TradingSession"></see>
    /// </summary>
    let TradingSession = _prefix "TradingSession"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/VolumeWeightedAveragePrice"></see>
    /// </summary>
    let VolumeWeightedAveragePrice = _prefix "VolumeWeightedAveragePrice"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/VolumeWeightedOpenPrice"></see>
    /// </summary>
    let VolumeWeightedOpenPrice = _prefix "VolumeWeightedOpenPrice"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/Yield"></see>
    /// </summary>
    let Yield = _prefix "Yield"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/YieldSpread"></see>
    /// </summary>
    let YieldSpread = _prefix "YieldSpread"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasBookDepth"></see>
    /// </summary>
    let hasBookDepth = _prefix "hasBookDepth"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasPriceDeterminationMethod"></see>
    /// </summary>
    let hasPriceDeterminationMethod = _prefix "hasPriceDeterminationMethod"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasLotSize"></see>
    /// </summary>
    let hasLotSize = _prefix "hasLotSize"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasNumberOfDaysAccrued"></see>
    /// </summary>
    let hasNumberOfDaysAccrued = _prefix "hasNumberOfDaysAccrued"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasQuoteLotSize"></see>
    /// </summary>
    let hasQuoteLotSize = _prefix "hasQuoteLotSize"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasRateOfReturn"></see>
    /// </summary>
    let hasRateOfReturn = _prefix "hasRateOfReturn"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasRoundLotSize"></see>
    /// </summary>
    let hasRoundLotSize = _prefix "hasRoundLotSize"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasTradingDateTime"></see>
    /// </summary>
    let hasTradingDateTime = _prefix "hasTradingDateTime"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasTradingVolume"></see>
    /// </summary>
    let hasTradingVolume = _prefix "hasTradingVolume"
