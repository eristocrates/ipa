namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FinancialInstruments.InstrumentPricing.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fbc_fi_ip =
    let _namespace_iri = Namespace_Iri fibo_fbc_fi_ip |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fbc-fi-ip:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Instrument Pricing Ontology"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fbc_fi_ip, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-ip:AdjustedClosingPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"adjusted closing price"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/AdjustedClosingPrice">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/AdjustedClosingPrice</seealso>
    let AdjustedClosingPrice =
        Prefixed_Name(fibo_fbc_fi_ip, "AdjustedClosingPrice") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-ip:AuctionMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fi-ip:PriceDeterminationMethod</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"auction method"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/AuctionMethod">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/AuctionMethod</seealso>
    let AuctionMethod = Prefixed_Name(fibo_fbc_fi_ip, "AuctionMethod") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-fi-ip:BestBid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"best bid"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/BestBid">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/BestBid</seealso>
    let BestBid = Prefixed_Name(fibo_fbc_fi_ip, "BestBid") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-fi-ip:BestOffer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"best offer"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/BestOffer">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/BestOffer</seealso>
    let BestOffer = Prefixed_Name(fibo_fbc_fi_ip, "BestOffer") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-fi-ip:BidAskSpread</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bid ask spread"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/BidAskSpread">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/BidAskSpread</seealso>
    let BidAskSpread = Prefixed_Name(fibo_fbc_fi_ip, "BidAskSpread") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-fi-ip:BidPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bid price"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/BidPrice">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/BidPrice</seealso>
    let BidPrice = Prefixed_Name(fibo_fbc_fi_ip, "BidPrice") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-fi-ip:CleanPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"clean price"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/CleanPrice">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/CleanPrice</seealso>
    let CleanPrice = Prefixed_Name(fibo_fbc_fi_ip, "CleanPrice") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-fi-ip:ClosingPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"closing price"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/ClosingPrice">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/ClosingPrice</seealso>
    let ClosingPrice = Prefixed_Name(fibo_fbc_fi_ip, "ClosingPrice") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-ip:ClosingPriceDeterminationMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"closing price determination method"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/ClosingPriceDeterminationMethod">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/ClosingPriceDeterminationMethod</seealso>
    let ClosingPriceDeterminationMethod =
        Prefixed_Name(fibo_fbc_fi_ip, "ClosingPriceDeterminationMethod") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-ip:CollectionOfSecurityPrices</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"collection of security prices"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/CollectionOfSecurityPrices">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/CollectionOfSecurityPrices</seealso>
    let CollectionOfSecurityPrices =
        Prefixed_Name(fibo_fbc_fi_ip, "CollectionOfSecurityPrices") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-ip:CompositeMarket</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"composite market"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/CompositeMarket">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/CompositeMarket</seealso>
    let CompositeMarket =
        Prefixed_Name(fibo_fbc_fi_ip, "CompositeMarket") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-ip:DerivedPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"derived price"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/DerivedPrice">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/DerivedPrice</seealso>
    let DerivedPrice = Prefixed_Name(fibo_fbc_fi_ip, "DerivedPrice") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-fi-ip:DirtyPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dirty price"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/DirtyPrice">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/DirtyPrice</seealso>
    let DirtyPrice = Prefixed_Name(fibo_fbc_fi_ip, "DirtyPrice") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-fi-ip:HighPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"high price"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/HighPrice">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/HighPrice</seealso>
    let HighPrice = Prefixed_Name(fibo_fbc_fi_ip, "HighPrice") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-ip:InternalRateOfReturn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"internal rate of return"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/InternalRateOfReturn">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/InternalRateOfReturn</seealso>
    let InternalRateOfReturn =
        Prefixed_Name(fibo_fbc_fi_ip, "InternalRateOfReturn") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-ip:IntraDayPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"intra day price"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/IntraDayPrice">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/IntraDayPrice</seealso>
    let IntraDayPrice = Prefixed_Name(fibo_fbc_fi_ip, "IntraDayPrice") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-fi-ip:LowPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"low price"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/LowPrice">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/LowPrice</seealso>
    let LowPrice = Prefixed_Name(fibo_fbc_fi_ip, "LowPrice") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-fi-ip:MarketPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"market price"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/MarketPrice">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/MarketPrice</seealso>
    let MarketPrice = Prefixed_Name(fibo_fbc_fi_ip, "MarketPrice") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-ip:MeanPriceDetermination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fi-ip:PriceDeterminationMethod</para>
    ///
    /// labels<para>"mean price determination"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/MeanPriceDetermination">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/MeanPriceDetermination</seealso>
    let MeanPriceDetermination =
        Prefixed_Name(fibo_fbc_fi_ip, "MeanPriceDetermination") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-ip:MidPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mid price"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/MidPrice">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/MidPrice</seealso>
    let MidPrice = Prefixed_Name(fibo_fbc_fi_ip, "MidPrice") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-fi-ip:OfferPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"offer price"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/OfferPrice">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/OfferPrice</seealso>
    let OfferPrice = Prefixed_Name(fibo_fbc_fi_ip, "OfferPrice") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-ip:OfficialClosingPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"official closing price"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/OfficialClosingPrice">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/OfficialClosingPrice</seealso>
    let OfficialClosingPrice =
        Prefixed_Name(fibo_fbc_fi_ip, "OfficialClosingPrice") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-ip:OpeningPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"opening price"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/OpeningPrice">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/OpeningPrice</seealso>
    let OpeningPrice = Prefixed_Name(fibo_fbc_fi_ip, "OpeningPrice") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-fi-ip:PriceAnalytic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"price analytic"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/PriceAnalytic">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/PriceAnalytic</seealso>
    let PriceAnalytic = Prefixed_Name(fibo_fbc_fi_ip, "PriceAnalytic") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-ip:PriceDeterminationMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"price determination method"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/PriceDeterminationMethod">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/PriceDeterminationMethod</seealso>
    let PriceDeterminationMethod =
        Prefixed_Name(fibo_fbc_fi_ip, "PriceDeterminationMethod") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-ip:PriceSpread</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"price spread"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/PriceSpread">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/PriceSpread</seealso>
    let PriceSpread = Prefixed_Name(fibo_fbc_fi_ip, "PriceSpread") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-fi-ip:PricingModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"pricing model"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/PricingModel">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/PricingModel</seealso>
    let PricingModel = Prefixed_Name(fibo_fbc_fi_ip, "PricingModel") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-fi-ip:RateOfReturn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"rate of return"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/RateOfReturn">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/RateOfReturn</seealso>
    let RateOfReturn = Prefixed_Name(fibo_fbc_fi_ip, "RateOfReturn") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-fi-ip:SecurityPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"security price"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/SecurityPrice">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/SecurityPrice</seealso>
    let SecurityPrice = Prefixed_Name(fibo_fbc_fi_ip, "SecurityPrice") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-fi-ip:TradingDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"trading day"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/TradingDay">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/TradingDay</seealso>
    let TradingDay = Prefixed_Name(fibo_fbc_fi_ip, "TradingDay") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-fi-ip:TradingSession</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"trading session"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/TradingSession">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/TradingSession</seealso>
    let TradingSession = Prefixed_Name(fibo_fbc_fi_ip, "TradingSession") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-ip:VolumeWeightedAveragePrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"volume-weighted average price"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/VolumeWeightedAveragePrice">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/VolumeWeightedAveragePrice</seealso>
    let VolumeWeightedAveragePrice =
        Prefixed_Name(fibo_fbc_fi_ip, "VolumeWeightedAveragePrice") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-ip:VolumeWeightedOpenPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"volume-weighted open price"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/VolumeWeightedOpenPrice">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/VolumeWeightedOpenPrice</seealso>
    let VolumeWeightedOpenPrice =
        Prefixed_Name(fibo_fbc_fi_ip, "VolumeWeightedOpenPrice") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-ip:Yield</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"yield"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/Yield">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/Yield</seealso>
    let Yield = Prefixed_Name(fibo_fbc_fi_ip, "Yield") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-fi-ip:YieldSpread</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"yield spread"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/YieldSpread">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/YieldSpread</seealso>
    let YieldSpread = Prefixed_Name(fibo_fbc_fi_ip, "YieldSpread") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-fi-ip:hasBookDepth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has book depth"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasBookDepth">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasBookDepth</seealso>
    let hasBookDepth = Prefixed_Name(fibo_fbc_fi_ip, "hasBookDepth") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-ip:hasClosingPriceDeterminationMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has closing price determination method"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasClosingPriceDeterminationMethod">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasClosingPriceDeterminationMethod</seealso>
    let hasClosingPriceDeterminationMethod =
        Prefixed_Name(fibo_fbc_fi_ip, "hasClosingPriceDeterminationMethod") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-ip:hasLotSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has lot size"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasLotSize">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasLotSize</seealso>
    let hasLotSize = Prefixed_Name(fibo_fbc_fi_ip, "hasLotSize") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-ip:hasNumberOfDaysAccrued</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has number of days accrued"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasNumberOfDaysAccrued">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasNumberOfDaysAccrued</seealso>
    let hasNumberOfDaysAccrued =
        Prefixed_Name(fibo_fbc_fi_ip, "hasNumberOfDaysAccrued") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-ip:hasPriceDeterminationMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has price determination method"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasPriceDeterminationMethod">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasPriceDeterminationMethod</seealso>
    let hasPriceDeterminationMethod =
        Prefixed_Name(fibo_fbc_fi_ip, "hasPriceDeterminationMethod") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-ip:hasPricingSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has pricing source"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasPricingSource">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasPricingSource</seealso>
    let hasPricingSource =
        Prefixed_Name(fibo_fbc_fi_ip, "hasPricingSource") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-ip:hasQuoteLotSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has quote lot size"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasQuoteLotSize">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasQuoteLotSize</seealso>
    let hasQuoteLotSize =
        Prefixed_Name(fibo_fbc_fi_ip, "hasQuoteLotSize") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-ip:hasRateOfReturn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has rate of return"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasRateOfReturn">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasRateOfReturn</seealso>
    let hasRateOfReturn =
        Prefixed_Name(fibo_fbc_fi_ip, "hasRateOfReturn") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-ip:hasRoundLotSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has round lot size"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasRoundLotSize">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasRoundLotSize</seealso>
    let hasRoundLotSize =
        Prefixed_Name(fibo_fbc_fi_ip, "hasRoundLotSize") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-ip:hasTradingDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has trading date time"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasTradingDateTime">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasTradingDateTime</seealso>
    let hasTradingDateTime =
        Prefixed_Name(fibo_fbc_fi_ip, "hasTradingDateTime") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fi-ip:hasTradingVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has trading volume"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasTradingVolume">https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasTradingVolume</seealso>
    let hasTradingVolume =
        Prefixed_Name(fibo_fbc_fi_ip, "hasTradingVolume") |> PrefixedName
