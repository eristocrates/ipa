#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-ind-ind-ind`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/" "fibo-ind-ind-ind"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : daily average market rate^^xsd:string</para>
    ///   <para>skos:definition : overall level of a given rate, calculated as the sum of some selected observed values of the rates for a particular reference rate, foreign exchange rate, lending rate, or other market rate divided by the number of samples collected over the course of a twenty-four (24) hour period for a specific date^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.investopedia.com/terms/m/marketaverage.asp^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/DailyAverageMarketRate">fibo-ind-ind-ind:DailyAverageMarketRate</a>
    /// </summary>
    let DailyAverageMarketRate = _prefixId.prefix "DailyAverageMarketRate"
    /// <summary>
    ///   <para>rdfs:label : end-of-day market rate^^xsd:string</para>
    ///   <para>skos:definition : value of a given market rate of the end of the business day for a specific date^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/EndOfDayMarketRate">fibo-ind-ind-ind:EndOfDayMarketRate</a>
    /// </summary>
    let EndOfDayMarketRate = _prefixId.prefix "EndOfDayMarketRate"
    /// <summary>
    ///   <para>rdfs:label : historical price volatility^^xsd:string</para>
    ///   <para>skos:definition : historical volatility measure of past trading ranges of prices of underlying securities and indexes^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Calculations for historical volatility are generally based on the change from one closing price to the next.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/HistoricalPriceVolatility">fibo-ind-ind-ind:HistoricalPriceVolatility</a>
    /// </summary>
    let HistoricalPriceVolatility = _prefixId.prefix "HistoricalPriceVolatility"
    /// <summary>
    ///   <para>rdfs:label : historical volatility^^xsd:string</para>
    ///   <para>skos:definition : measure of volatility that uses actual values for pricing, rates, and other measurements calculated over some prior period^^xsd:string</para>
    ///   <para>cmns-av:synonym : realized volatility^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/HistoricalVolatility">fibo-ind-ind-ind:HistoricalVolatility</a>
    /// </summary>
    let HistoricalVolatility = _prefixId.prefix "HistoricalVolatility"
    /// <summary>
    ///   <para>rdfs:label : implied price volatility^^xsd:string</para>
    ///   <para>skos:definition : measure of volatility that represents the expected fluctuations of an underlying stock or index over a specific time frame^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/ImpliedPriceVolatility">fibo-ind-ind-ind:ImpliedPriceVolatility</a>
    /// </summary>
    let ImpliedPriceVolatility = _prefixId.prefix "ImpliedPriceVolatility"
    /// <summary>
    ///   <para>rdfs:label : implied volatility^^xsd:string</para>
    ///   <para>skos:definition : measure of volatility that is a forward-looking metric used to calculate probability^^xsd:string</para>
    ///   <para>cmns-av:synonym : projected volatility^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/ImpliedVolatility">fibo-ind-ind-ind:ImpliedVolatility</a>
    /// </summary>
    let ImpliedVolatility = _prefixId.prefix "ImpliedVolatility"
    /// <summary>
    ///   <para>rdfs:label : market rate^^xsd:string</para>
    ///   <para>skos:definition : value of a rate established in the marketplace for a set of instruments or that describes the economic climate for an industry and/or political region (e.g., SOFR, Prime)^^xsd:string</para>
    ///   <para>skos:example : Financial market rates include, but are not limited to reference rates, foreign exchange rates, lending rates, bankers' acceptance rates, and so forth.^^xsd:string</para>
    ///   <para>skos:scopeNote : Market rates include but may not be limited to the following:
    /// 	(1) Index: Statistical composite that measures changes in the economy or in financial markets, often expressed in percentage changes from a base year or from the previous month
    /// 	(2) Money Rate: Benchmark or guideline for interest rates determined by central banks or economical climate as a whole
    /// 	(3) Bankers' Acceptance Rate: Benchmark reflecting market fluctuations of Bankers' Acceptance issued instruments
    /// 	(4) Commercial Paper Rate: Benchmark reflecting market fluctuations of Commercial Paper issued instruments
    /// 	(5) Certificate of Deposit Rate: Benchmark reflecting market fluctuations of Certificate of Deposit issued instruments
    /// 	(6) Interbank Rate
    /// 	(7) Prime
    /// 	(8) Time Deposit Rate: Benchmark reflecting market fluctuations of Deposit/Redeposit issued instruments^^xsd:stringskos:scopeNote : known collectively (in the CFI Standard) as referential instruments^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/MarketRate">fibo-ind-ind-ind:MarketRate</a>
    /// </summary>
    let MarketRate = _prefixId.prefix "MarketRate"
    /// <summary>
    ///   <para>rdfs:label : market spread^^xsd:string</para>
    ///   <para>skos:definition : statistical measure providing the difference (or spread) between two market rates^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/MarketSpread">fibo-ind-ind-ind:MarketSpread</a>
    /// </summary>
    let MarketSpread = _prefixId.prefix "MarketSpread"
    /// <summary>
    ///   <para>rdfs:label : price structure^^xsd:string</para>
    ///   <para>skos:definition : structured collection of prices, such as market prices for some index or security, such that volatility or other analyses may be performed over the structure^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Historical prices are needed not only for various statistical analyses but for determining best prices for certain kinds of options, for example. Note that prices may be quoted or calculated.^^xsd:string</para>
    ///   <para>cmns-av:synonym : price history^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/PriceStructure">fibo-ind-ind-ind:PriceStructure</a>
    /// </summary>
    let PriceStructure = _prefixId.prefix "PriceStructure"
    /// <summary>
    ///   <para>rdfs:label : price volatility^^xsd:string</para>
    ///   <para>skos:definition : statistical measure of the rate of change in pricing for a given security or market index^^xsd:string</para>
    ///   <para>skos:editorialNote : Volatility is modeled here using a structured collection, comprised of a series of individual prices of something (a security, index, etc., typically quoted prices), dates, and the source for those prices for some overall period of time^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Volatility can be determined using the standard deviation or variance among prices for the security or market index over some period of time. For a specific security, volatility may measure the amount and frequency in rapid price fluctuation. It is computed as the annualized standard deviation of the percentage change in a security's daily price.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/PriceVolatility">fibo-ind-ind-ind:PriceVolatility</a>
    /// </summary>
    let PriceVolatility = _prefixId.prefix "PriceVolatility"
    /// <summary>
    ///   <para>rdfs:label : quoted price^^xsd:string</para>
    ///   <para>skos:definition : a monetary price quoted by some publisher on a given date^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/QuotedPrice">fibo-ind-ind-ind:QuotedPrice</a>
    /// </summary>
    let QuotedPrice = _prefixId.prefix "QuotedPrice"
    /// <summary>
    ///   <para>rdfs:label : term structure^^xsd:string</para>
    ///   <para>skos:definition : structured collection of rates, such as interest rates, or bond yields with different terms to maturity, such that a yield curve may be constructed for the structure^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Term structure refers to a set of discrete points; elements are ordered by time. Restrictions on the rate (see above) and a point in time, paired together, and then ordered in a structured collection is how this should ultimately be modeled. Then the concept of yield curve would be a child of term structure, for calculation of net present value, for example. Term structures consist of two or more observed or projected values, typically related to debt instruments or interest rates. assessment of monetary policy conditions, and so forth.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/TermStructure">fibo-ind-ind-ind:TermStructure</a>
    /// </summary>
    let TermStructure = _prefixId.prefix "TermStructure"
    /// <summary>
    ///   <para>rdfs:label : volatility^^xsd:string</para>
    ///   <para>skos:definition : statistical measure of the dispersion around the average of some random variable over some period of time^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/Volatility">fibo-ind-ind-ind:Volatility</a>
    /// </summary>
    let Volatility = _prefixId.prefix "Volatility"
    /// <summary>
    ///   <para>rdfs:label : has quotation date^^xsd:string</para>
    ///   <para>skos:definition : indicates the quotation date for a given market rate or indicator^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Typically this property reflects a daily average or end of day quote.^^xsd:string</para>
    ///   <para>cmns-av:usageNote : Note that this property requires a reified date value, if used.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/hasQuotationDate">fibo-ind-ind-ind:hasQuotationDate</a>
    /// </summary>
    let hasQuotationDate = _prefixId.prefix "hasQuotationDate"
    /// <summary>
    ///   <para>rdfs:label : has quotation date and time^^xsd:string</para>
    ///   <para>skos:definition : indicates a quotation date and possibly a time for a given market rate, interest rate, indicator, or other quoted pricing information^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/hasQuotationDateTime">fibo-ind-ind-ind:hasQuotationDateTime</a>
    /// </summary>
    let hasQuotationDateTime = _prefixId.prefix "hasQuotationDateTime"
    /// <summary>
    ///   <para>rdfs:label : is volatility of^^xsd:string</para>
    ///   <para>skos:definition : indicates something to which the volatility measure applies and of which it is a measure^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/isVolatilityOf">fibo-ind-ind-ind:isVolatilityOf</a>
    /// </summary>
    let isVolatilityOf = _prefixId.prefix "isVolatilityOf"
