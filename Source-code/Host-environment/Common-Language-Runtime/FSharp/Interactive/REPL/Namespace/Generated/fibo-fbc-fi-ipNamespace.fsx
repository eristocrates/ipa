#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fbc-fi-ip`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/" "fibo-fbc-fi-ip"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : adjusted closing price</para>
    ///   <para>skos:definition : amended closing price to reflect a security's value after accounting for any corporate actions, such as stock splits, dividends, and rights offerings</para>
    ///   <para>cmns-av:explanatoryNote : A particularly dramatic change in price occurs when a company announces a stock split. When the change is made, the price displayed will immediately reflect the split. For example, if a company splits its stock 2-for-1, the last closing price will be cut in half. That's the adjusted closing price.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/AdjustedClosingPrice">fibo-fbc-fi-ip:AdjustedClosingPrice</a>
    /// </summary>
    let AdjustedClosingPrice = _prefixId.prefix "AdjustedClosingPrice"
    let AuctionMethod = _prefixId.prefix "AuctionMethod"
    /// <summary>
    ///   <para>rdfs:label : best bid</para>
    ///   <para>skos:definition : highest bid price a prospective buyer is willing to pay at a particular time for a given security</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/BestBid">fibo-fbc-fi-ip:BestBid</a>
    /// </summary>
    let BestBid = _prefixId.prefix "BestBid"
    /// <summary>
    ///   <para>rdfs:label : best offer</para>
    ///   <para>skos:definition : lowest price acceptable to a prospective seller for a given security at a particular point in time</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/BestOffer">fibo-fbc-fi-ip:BestOffer</a>
    /// </summary>
    let BestOffer = _prefixId.prefix "BestOffer"
    /// <summary>
    ///   <para>rdfs:label : bid ask spread</para>
    ///   <para>skos:definition : difference between an offer (ask) price and a bid price</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/BidAskSpread">fibo-fbc-fi-ip:BidAskSpread</a>
    /// </summary>
    let BidAskSpread = _prefixId.prefix "BidAskSpread"
    /// <summary>
    ///   <para>rdfs:label : bid price</para>
    ///   <para>skos:definition : price a prospective buyer is willing to pay</para>
    ///   <para>cmns-av:explanatoryNote : The term 'bid price' is used by traders / market makers with respect to a given security, and that are prepared to buy or sell round lots at publicly quoted prices, and by specialists in certain instruments that perform similar functions on an exchange.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/BidPrice">fibo-fbc-fi-ip:BidPrice</a>
    /// </summary>
    let BidPrice = _prefixId.prefix "BidPrice"
    /// <summary>
    ///   <para>rdfs:label : clean price</para>
    ///   <para>skos:definition : debt instrument price that does not include accrued interest</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/CleanPrice">fibo-fbc-fi-ip:CleanPrice</a>
    /// </summary>
    let CleanPrice = _prefixId.prefix "CleanPrice"
    /// <summary>
    ///   <para>rdfs:label : closing price</para>
    ///   <para>skos:definition : cash value of the last transacted price before the market closes</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/ClosingPrice">fibo-fbc-fi-ip:ClosingPrice</a>
    /// </summary>
    let ClosingPrice = _prefixId.prefix "ClosingPrice"

    /// <summary>
    ///   <para>rdfs:label : closing price determination method</para>
    ///   <para>skos:definition : strategy for calculating or otherwise determining an official closing price</para>
    ///   <para>cmns-av:explanatoryNote : The official closing price is typically the final price at which something trades during regular market hours on an exchange or trading venue. Because of the evolving nature of online trading in a 24 hour world, every exchange has a method of calculating its official closing price, although that methodology changes from time to time. They may also publish an adjusted closing price, which reflects changes to the price that reflect corporate actions and after hours trading that occur before the opening of the exchange on the following day. Understanding how the closing price is determined is important to ensure price comparability for a given security across exchanges.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/ClosingPriceDeterminationMethod">fibo-fbc-fi-ip:ClosingPriceDeterminationMethod</a>
    /// </summary>
    let ClosingPriceDeterminationMethod =
        _prefixId.prefix "ClosingPriceDeterminationMethod"

    /// <summary>
    ///   <para>rdfs:label : collection of security prices</para>
    ///   <para>skos:definition : collection consisting of a series of prices, each of which has a specific date and time associated with it, for some security</para>
    ///   <para>cmns-av:explanatoryNote : Note that such a collection is of prices that may be quoted or may be established through analysis, such as an average over a number of markets (composite market) or developed via some pricing model (e.g., matrix pricing).</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/CollectionOfSecurityPrices">fibo-fbc-fi-ip:CollectionOfSecurityPrices</a>
    /// </summary>
    let CollectionOfSecurityPrices = _prefixId.prefix "CollectionOfSecurityPrices"
    /// <summary>
    ///   <para>rdfs:label : composite market</para>
    ///   <para>skos:definition : group of exchanges and trading venues referenced for pricing purposes</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/CompositeMarket">fibo-fbc-fi-ip:CompositeMarket</a>
    /// </summary>
    let CompositeMarket = _prefixId.prefix "CompositeMarket"
    /// <summary>
    ///   <para>rdfs:label : derived price</para>
    ///   <para>skos:definition : price that stems from another source or calculation rather than being quoted or based on actual trading data</para>
    ///   <para>skos:example : For example, a product's price can be derived from another pricing source, such as an asset or product, using various contributing factors. Derived prices can also be calculated within a firm using published price spreads or other market data. An interpolated price is determined by interpolation between available price figures, using some algorithm or curve, such as between bid and offer (among others). It also includes yield curves and implied forward curves. That is, interpolation may either be linear (straight line interpolation between two values) or may be expressed as a non linear curve such as a yield curve or an implied forward curve.</para>
    ///   <para>cmns-av:explanatoryNote : There are evaluated prices in which an independent source evaluates a price they have derived, and there are prices which are derived within a firm, from supplied, published end of day price spreads or other market data.</para>
    ///   <para>cmns-av:synonym : interpolated pricecmns-av:synonym : matrix price</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/DerivedPrice">fibo-fbc-fi-ip:DerivedPrice</a>
    /// </summary>
    let DerivedPrice = _prefixId.prefix "DerivedPrice"
    /// <summary>
    ///   <para>rdfs:label : dirty price</para>
    ///   <para>skos:definition : debt instrument price that includes accrued interest</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/DirtyPrice">fibo-fbc-fi-ip:DirtyPrice</a>
    /// </summary>
    let DirtyPrice = _prefixId.prefix "DirtyPrice"
    /// <summary>
    ///   <para>rdfs:label : high price</para>
    ///   <para>skos:definition : highest price for a given security over the period specified</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/HighPrice">fibo-fbc-fi-ip:HighPrice</a>
    /// </summary>
    let HighPrice = _prefixId.prefix "HighPrice"
    /// <summary>
    ///   <para>rdfs:label : internal rate of return</para>
    ///   <para>skos:definition : discount rate that results in a net present value (NPV) of zero for a series of future cash flows</para>
    ///   <para>cmns-av:explanatoryNote : This concept is central to many definitions of debt instrument analytics, and is the inverse of net present value.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/InternalRateOfReturn">fibo-fbc-fi-ip:InternalRateOfReturn</a>
    /// </summary>
    let InternalRateOfReturn = _prefixId.prefix "InternalRateOfReturn"
    /// <summary>
    ///   <para>rdfs:label : intra day price</para>
    ///   <para>skos:definition : price for a given security at some point between the opening and official closing price on an exchange</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/IntraDayPrice">fibo-fbc-fi-ip:IntraDayPrice</a>
    /// </summary>
    let IntraDayPrice = _prefixId.prefix "IntraDayPrice"
    /// <summary>
    ///   <para>rdfs:label : low price</para>
    ///   <para>skos:definition : lowest value for a given security over the period specified</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/LowPrice">fibo-fbc-fi-ip:LowPrice</a>
    /// </summary>
    let LowPrice = _prefixId.prefix "LowPrice"
    /// <summary>
    ///   <para>rdfs:label : market price</para>
    ///   <para>skos:definition : last reported price at which a security was sold</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/MarketPrice">fibo-fbc-fi-ip:MarketPrice</a>
    /// </summary>
    let MarketPrice = _prefixId.prefix "MarketPrice"
    let MeanPriceDetermination = _prefixId.prefix "MeanPriceDetermination"
    /// <summary>
    ///   <para>rdfs:label : mid price</para>
    ///   <para>skos:definition : arithmetic mean between bid and offer prices</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/MidPrice">fibo-fbc-fi-ip:MidPrice</a>
    /// </summary>
    let MidPrice = _prefixId.prefix "MidPrice"
    /// <summary>
    ///   <para>rdfs:label : offer price</para>
    ///   <para>skos:definition : price suggested by a prospective seller at a particular time for a given security</para>
    ///   <para>cmns-av:synonym : ask pricecmns-av:synonym : asking pricecmns-av:synonym : offering price</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/OfferPrice">fibo-fbc-fi-ip:OfferPrice</a>
    /// </summary>
    let OfferPrice = _prefixId.prefix "OfferPrice"
    /// <summary>
    ///   <para>rdfs:label : official closing price</para>
    ///   <para>skos:definition : price of the final trade of a security at the end of a trading day on a given exchange</para>
    ///   <para>cmns-av:explanatoryNote : A stock's closing price is the standard benchmark used by investors to track its performance over time.</para>
    ///   <para>cmns-av:synonym : end-of-day price</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/OfficialClosingPrice">fibo-fbc-fi-ip:OfficialClosingPrice</a>
    /// </summary>
    let OfficialClosingPrice = _prefixId.prefix "OfficialClosingPrice"
    /// <summary>
    ///   <para>rdfs:label : opening price</para>
    ///   <para>skos:definition : price at which something first trades at the start of a trading day</para>
    ///   <para>cmns-av:explanatoryNote : Investors that want to buy or sell as soon as the market opens will put in an order at the opening price. Depending on how the closing price for the prior day is determined, and if there is no after hours trading (AFT), the opening price will be the same as the prior trading day's closing price. Otherwise, the opening price may differ from the prior trading day's official closing price.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/OpeningPrice">fibo-fbc-fi-ip:OpeningPrice</a>
    /// </summary>
    let OpeningPrice = _prefixId.prefix "OpeningPrice"
    /// <summary>
    ///   <para>rdfs:label : price analytic</para>
    ///   <para>skos:definition : statistical measure involving security prices</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/PriceAnalytic">fibo-fbc-fi-ip:PriceAnalytic</a>
    /// </summary>
    let PriceAnalytic = _prefixId.prefix "PriceAnalytic"
    /// <summary>
    ///   <para>rdfs:label : price determination method</para>
    ///   <para>skos:definition : strategy for calculating or otherwise establishing a price for something</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/PriceDeterminationMethod">fibo-fbc-fi-ip:PriceDeterminationMethod</a>
    /// </summary>
    let PriceDeterminationMethod = _prefixId.prefix "PriceDeterminationMethod"
    /// <summary>
    ///   <para>rdfs:label : price spread^^xsd:string</para>
    ///   <para>skos:definition : difference between two prices^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/PriceSpread">fibo-fbc-fi-ip:PriceSpread</a>
    /// </summary>
    let PriceSpread = _prefixId.prefix "PriceSpread"
    /// <summary>
    ///   <para>rdfs:label : pricing model</para>
    ///   <para>skos:definition : expression used to determine a value for an instrument at a given point in time</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/PricingModel">fibo-fbc-fi-ip:PricingModel</a>
    /// </summary>
    let PricingModel = _prefixId.prefix "PricingModel"
    /// <summary>
    ///   <para>rdfs:label : rate of return</para>
    ///   <para>skos:definition : net gain or loss on an investment over a specified time period, expressed as a percentage of the investment's initial cost or value as of a specific point in time</para>
    ///   <para>cmns-av:abbreviation : RoR</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/RateOfReturn">fibo-fbc-fi-ip:RateOfReturn</a>
    /// </summary>
    let RateOfReturn = _prefixId.prefix "RateOfReturn"
    /// <summary>
    ///   <para>rdfs:label : security price</para>
    ///   <para>skos:definition : monetary price for a financial instrument at some point in time</para>
    ///   <para>cmns-av:explanatoryNote : A security price may be the price that some party is willing to pay, has recently paid, or would like to be paid, depending on the circumstances.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/SecurityPrice">fibo-fbc-fi-ip:SecurityPrice</a>
    /// </summary>
    let SecurityPrice = _prefixId.prefix "SecurityPrice"
    /// <summary>
    ///   <para>rdfs:label : trading day</para>
    ///   <para>skos:definition : time span that a particular trading venue is open</para>
    ///   <para>cmns-av:abbreviation : RTH</para>
    ///   <para>cmns-av:adaptedFrom : https://www.lawinsider.com/dictionary/trading-day^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : In the United States, and with respect to common stock in particular, trading day means any day on which the stock is traded on the principal market, or, if the principal market is not the principal trading market for the common stock, then on the principal securities exchange or securities market on which the common stock is then traded, provided that 'Trading Day' shall not include any day on which the common stock is scheduled to trade on such exchange or market for less than 4.5 hours or any day that the common stock is suspended from trading during the final hour of trading on such exchange or market (or if such exchange or market does not designate in advance the closing time of trading on such exchange or market, then during the hour ending at 4:00:00 p.m., New York time) unless such day is otherwise designated as a trading day in writing by the holder.</para>
    ///   <para>cmns-av:synonym : regular trading hours</para>
    ///   <para>cmns-av:usageNote : By convention it is sufficient to provide a value for hasOpeningDateTime, with hasClosingDateTime being optional.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/TradingDay">fibo-fbc-fi-ip:TradingDay</a>
    /// </summary>
    let TradingDay = _prefixId.prefix "TradingDay"
    /// <summary>
    ///   <para>rdfs:label : trading session</para>
    ///   <para>skos:definition : window of time within a trading day in which orders may be placed and filled</para>
    ///   <para>cmns-av:adaptedFrom : https://financial-dictionary.thefreedictionary.com/Trading+Sessions^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : An exchange may have several trading sessions during a day. For example, the exchange may be open from 9 a.m. until 10:30 a.m., from 11:30 a.m. until 1 p.m., and from 2 p.m. to 3:30 p.m. Holding several trading sessions gives the market more time to digest information rationally without having to respond immediately.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/TradingSession">fibo-fbc-fi-ip:TradingSession</a>
    /// </summary>
    let TradingSession = _prefixId.prefix "TradingSession"
    /// <summary>
    ///   <para>rdfs:label : volume-weighted average price</para>
    ///   <para>skos:definition : average price at which a given security has traded throughout a trading day, determined by multiplying each trade by its volume, adding the results, then dividing by the volume traded for the day</para>
    ///   <para>cmns-av:abbreviation : VWAP</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/VolumeWeightedAveragePrice">fibo-fbc-fi-ip:VolumeWeightedAveragePrice</a>
    /// </summary>
    let VolumeWeightedAveragePrice = _prefixId.prefix "VolumeWeightedAveragePrice"
    /// <summary>
    ///   <para>rdfs:label : volume-weighted open price</para>
    ///   <para>skos:definition : price determined by multiplying each trade by its volume, adding the results, then dividing by the volume over a certain period during the trading day (rather than over the course of the entire day)</para>
    ///   <para>cmns-av:abbreviation : VWOP</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/VolumeWeightedOpenPrice">fibo-fbc-fi-ip:VolumeWeightedOpenPrice</a>
    /// </summary>
    let VolumeWeightedOpenPrice = _prefixId.prefix "VolumeWeightedOpenPrice"
    /// <summary>
    ///   <para>rdfs:label : yield</para>
    ///   <para>skos:definition : return on the investor's capital investment</para>
    ///   <para>cmns-av:explanatoryNote : A Yield must be based on a price, and must be in reference to some event or duration of time. It has a calculation method, and may have other qualifying terms such as for compounded yield.cmns-av:explanatoryNote : Yield reflects income over some period of time which is then annualized, and typically projected into the future, assuming that conditions and rates remain the same, whereas return on investment is retrospective.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/Yield">fibo-fbc-fi-ip:Yield</a>
    /// </summary>
    let Yield = _prefixId.prefix "Yield"
    /// <summary>
    ///   <para>rdfs:label : yield spread^^xsd:string</para>
    ///   <para>skos:definition : the spread between the yields of two items</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/YieldSpread">fibo-fbc-fi-ip:YieldSpread</a>
    /// </summary>
    let YieldSpread = _prefixId.prefix "YieldSpread"
    /// <summary>
    ///   <para>rdfs:label : has book depth</para>
    ///   <para>skos:definition : indicates depth of the order book to which the price refers</para>
    ///   <para>cmns-av:explanatoryNote : An order book is the list of orders (manual or electronic) that a trading venue (in particular stock exchanges) uses to record the interest of buyers and sellers in a particular financial instrument. The book depth refers to the number of price levels available at a particular time in the book. Sometimes the book is represented to a fixed depth, and orders beyond that depth are ignored or rejected, and in other cases the book can contain unlimited levels.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasBookDepth">fibo-fbc-fi-ip:hasBookDepth</a>
    /// </summary>
    let hasBookDepth = _prefixId.prefix "hasBookDepth"

    /// <summary>
    ///   <para>rdfs:label : has closing price determination method</para>
    ///   <para>skos:definition : indicates a strategy by which the official closing price is determined</para>
    ///   <para>cmns-av:explanatoryNote : This method itself changes quite frequently i.e. the exchange may change the way it computes closing prices.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasClosingPriceDeterminationMethod">fibo-fbc-fi-ip:hasClosingPriceDeterminationMethod</a>
    /// </summary>
    let hasClosingPriceDeterminationMethod =
        _prefixId.prefix "hasClosingPriceDeterminationMethod"

    /// <summary>
    ///   <para>rdfs:label : has lot size</para>
    ///   <para>skos:definition : magnitude of an item (i.e., total quantity)</para>
    ///   <para>skos:example : For example, with respect to corn, 5000 bushels is a typical contract size. For some oil commodities trades, 1000 barrels is considered a single contract. For equity options, the lot size is typically 100 shares of the underlying.</para>
    ///   <para>cmns-av:explanatoryNote : The lot size, referenced in offerings, listings, orders, and trades, typically refers to the number of shares or units in a single contract.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasLotSize">fibo-fbc-fi-ip:hasLotSize</a>
    /// </summary>
    let hasLotSize = _prefixId.prefix "hasLotSize"
    /// <summary>
    ///   <para>rdfs:label : has number of days accrued</para>
    ///   <para>skos:definition : indicates the number of days for which interest has accrued and has not yet been received</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasNumberOfDaysAccrued">fibo-fbc-fi-ip:hasNumberOfDaysAccrued</a>
    /// </summary>
    let hasNumberOfDaysAccrued = _prefixId.prefix "hasNumberOfDaysAccrued"
    /// <summary>
    ///   <para>rdfs:label : has price determination method</para>
    ///   <para>skos:definition : indicates a strategy by which a given price is determined</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasPriceDeterminationMethod">fibo-fbc-fi-ip:hasPriceDeterminationMethod</a>
    /// </summary>
    let hasPriceDeterminationMethod = _prefixId.prefix "hasPriceDeterminationMethod"
    /// <summary>
    ///   <para>rdfs:label : has pricing source</para>
    ///   <para>skos:definition : indicates the origin of a given quote or price for a financial instrument</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasPricingSource">fibo-fbc-fi-ip:hasPricingSource</a>
    /// </summary>
    let hasPricingSource = _prefixId.prefix "hasPricingSource"
    /// <summary>
    ///   <para>rdfs:label : has quote lot size</para>
    ///   <para>skos:definition : magnitude of something to which the quote price refers</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasQuoteLotSize">fibo-fbc-fi-ip:hasQuoteLotSize</a>
    /// </summary>
    let hasQuoteLotSize = _prefixId.prefix "hasQuoteLotSize"
    /// <summary>
    ///   <para>rdfs:label : has rate of return</para>
    ///   <para>skos:definition : indicates the retrospective rate of return for a given financial instrument over some period of time</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasRateOfReturn">fibo-fbc-fi-ip:hasRateOfReturn</a>
    /// </summary>
    let hasRateOfReturn = _prefixId.prefix "hasRateOfReturn"
    /// <summary>
    ///   <para>rdfs:label : has round lot size</para>
    ///   <para>skos:definition : standard number of securities traded on an exchange</para>
    ///   <para>cmns-av:explanatoryNote : In stocks, a round lot is considered 100 shares or a larger number that can be evenly divided by 100. In bonds, a round lot is usually $100,000 worth. Odd lots and smaller lots have become increasingly common due to technology advances and small investor demand.</para>
    ///   <para>cmns-av:synonym : normal trading unitcmns-av:synonym : unit of trading</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasRoundLotSize">fibo-fbc-fi-ip:hasRoundLotSize</a>
    /// </summary>
    let hasRoundLotSize = _prefixId.prefix "hasRoundLotSize"
    /// <summary>
    ///   <para>rdfs:label : has trading date time</para>
    ///   <para>skos:definition : indicates the specific date and time associated with a given price</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasTradingDateTime">fibo-fbc-fi-ip:hasTradingDateTime</a>
    /// </summary>
    let hasTradingDateTime = _prefixId.prefix "hasTradingDateTime"
    /// <summary>
    ///   <para>rdfs:label : has trading volume</para>
    ///   <para>skos:definition : indicates the number of shares/units traded on a given trading day</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/hasTradingVolume">fibo-fbc-fi-ip:hasTradingVolume</a>
    /// </summary>
    let hasTradingVolume = _prefixId.prefix "hasTradingVolume"
