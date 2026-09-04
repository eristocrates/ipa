#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-sec-sec-sch`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/" "fibo-sec-sec-sch"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : auction date rule^^xsd:string</para>
    ///   <para>skos:definition : business recurrence interval convention that is a published rule for defining the date of some auction event^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/AuctionDateRule">fibo-sec-sec-sch:AuctionDateRule</a>
    /// </summary>
    let AuctionDateRule = _prefixId.prefix "AuctionDateRule"

    /// <summary>
    ///   <para>rdfs:label : date returned by settlement date rule^^xsd:string</para>
    ///   <para>skos:definition : calculated date that is determined via a settlement rule^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/DateReturnedBySettlementDateRule">fibo-sec-sec-sch:DateReturnedBySettlementDateRule</a>
    /// </summary>
    let DateReturnedBySettlementDateRule =
        _prefixId.prefix "DateReturnedBySettlementDateRule"

    /// <summary>
    ///   <para>rdfs:label : date returned by trading date rule^^xsd:string</para>
    ///   <para>skos:definition : calculated date that is determined via a trading rule^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/DateReturnedByTradingDateRule">fibo-sec-sec-sch:DateReturnedByTradingDateRule</a>
    /// </summary>
    let DateReturnedByTradingDateRule = _prefixId.prefix "DateReturnedByTradingDateRule"
    /// <summary>
    ///   <para>rdfs:label : floating-rate note date^^xsd:string</para>
    ///   <para>skos:definition : calculated date associated with a floating-rate note, also known as a floater or FRN, which is a debt instrument with a variable interest rate^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : FRN date^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/FloatingRateNoteDate">fibo-sec-sec-sch:FloatingRateNoteDate</a>
    /// </summary>
    let FloatingRateNoteDate = _prefixId.prefix "FloatingRateNoteDate"
    /// <summary>
    ///   <para>rdfs:label : floating-rate note date rule^^xsd:string</para>
    ///   <para>skos:definition : business day adjustment rule applied to floating-rate note instruments^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : FRN date rule^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/FloatingRateNoteDateRule">fibo-sec-sec-sch:FloatingRateNoteDateRule</a>
    /// </summary>
    let FloatingRateNoteDateRule = _prefixId.prefix "FloatingRateNoteDateRule"

    /// <summary>
    ///   <para>rdfs:label : International Money Market (IMM) Australian Dollar (AUD) trading date rule^^xsd:string</para>
    ///   <para>skos:definition : trading date rule defined as the last trading day of an Australian Stock Exchange (ASX) 90-Day Bank Accepted Futures and Options product, one Sydney business day preceding the second Friday of the relevant settlement month^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : IMM AUD trading date rule^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.asx.com.au/documents/products/90-Day-bank-bill-futures-factsheet.pdf^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/InternationalMoneyMarketAustralianDollarTradingDateRule">fibo-sec-sec-sch:InternationalMoneyMarketAustralianDollarTradingDateRule</a>
    /// </summary>
    let InternationalMoneyMarketAustralianDollarTradingDateRule =
        _prefixId.prefix "InternationalMoneyMarketAustralianDollarTradingDateRule"

    /// <summary>
    ///   <para>rdfs:label : International Money Market (IMM) Canadian Dollar (CAD) trading date rule^^xsd:string</para>
    ///   <para>skos:definition : trading date rule defined as the last trading day / expiration day of the Canadian Derivatives Exchange (Bourse do Montreal Inc.), three month Bankers' Acceptance Futures (Ticker symbol BAX), the second London banking day prior to the third Wednesday of the contract month^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : IMM CAD trading date rule^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : If the determined day is a bourse or bank holiday in Toronto or Montreal, the last trading day shall be the previous bank business day, per the Canadian Derivatives Exchange BAX contract specification. The above description implies a Date Roll Rule which is presumably referenced by referring to this rule, so that when this rule is referenced, there would be no Date Roll Rule defined in the FpML message. Semantically, this is still a Date Roll Rule, specifically a "Roll forward" rule with no modification (the third Wednesday of a month will never roll forward to a day in the following month so no Modified rule is required).^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/InternationalMoneyMarketCanadianDollarTradingDateRule">fibo-sec-sec-sch:InternationalMoneyMarketCanadianDollarTradingDateRule</a>
    /// </summary>
    let InternationalMoneyMarketCanadianDollarTradingDateRule =
        _prefixId.prefix "InternationalMoneyMarketCanadianDollarTradingDateRule"

    /// <summary>
    ///   <para>rdfs:label : International Money Market (IMM) New Zealand Dollar (NZD) trading date rule^^xsd:string</para>
    ///   <para>skos:definition : trading date rule defined as the last trading day of an Australian Stock Exchange (ASX) New Zealand (NZ) 90-Day Bank Accepted Futures and Options product, the first Wednesday after the ninth day of the relevant settlement month^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : IMM NZD trading date rule^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/InternationalMoneyMarketNewZealandDollarTradingDateRule">fibo-sec-sec-sch:InternationalMoneyMarketNewZealandDollarTradingDateRule</a>
    /// </summary>
    let InternationalMoneyMarketNewZealandDollarTradingDateRule =
        _prefixId.prefix "InternationalMoneyMarketNewZealandDollarTradingDateRule"

    /// <summary>
    ///   <para>rdfs:label : International Money Market (IMM) settlement date rule^^xsd:string</para>
    ///   <para>skos:definition : settlement date rule as defined in the International Money Market (IMM) settlement dates calendar^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : IMM settlement date rule^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The International Money Market (IMM) is a division of the Chicago Mercantile Exchange (CME) that deals with the trading of currency and interest rate futures and options.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/InternationalMoneyMarketSettlementDateRule">fibo-sec-sec-sch:InternationalMoneyMarketSettlementDateRule</a>
    /// </summary>
    let InternationalMoneyMarketSettlementDateRule =
        _prefixId.prefix "InternationalMoneyMarketSettlementDateRule"

    /// <summary>
    ///   <para>rdfs:label : scheduled calculation period end event^^xsd:string</para>
    ///   <para>skos:definition : the end date of a specific calculation period^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Note that this is not necessarily the same as the day before the next period's start date. Calculation schedules specify periods of time, with a start and an end as well as a duration, with the end date being determined by some convention or published list of dates. FpML for CalculationPeriod 'A type defining the parameters used in the calculation of a fixed or floating rate calculation period amount. This type forms part of cashflows representation of a swap stream.'^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/ScheduledCalculationPeriodEndEvent">fibo-sec-sec-sch:ScheduledCalculationPeriodEndEvent</a>
    /// </summary>
    let ScheduledCalculationPeriodEndEvent =
        _prefixId.prefix "ScheduledCalculationPeriodEndEvent"

    /// <summary>
    ///   <para>rdfs:label : scheduled calculation period start event^^xsd:string</para>
    ///   <para>skos:definition : the start of a specific calculation period^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : FpML for CalculationPeriod 'A type defining the parameters used in the calculation of a fixed or floating rate calculation period amount. This type forms part of cashflows representation of a swap stream.'^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/ScheduledCalculationPeriodStartEvent">fibo-sec-sec-sch:ScheduledCalculationPeriodStartEvent</a>
    /// </summary>
    let ScheduledCalculationPeriodStartEvent =
        _prefixId.prefix "ScheduledCalculationPeriodStartEvent"

    /// <summary>
    ///   <para>rdfs:label : settlement date rule^^xsd:string</para>
    ///   <para>skos:definition : convention for determining settlement dates by reference to some jurisdiction or as set by a given exchange or similar venue^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/SettlementDateRule">fibo-sec-sec-sch:SettlementDateRule</a>
    /// </summary>
    let SettlementDateRule = _prefixId.prefix "SettlementDateRule"
    /// <summary>
    ///   <para>rdfs:label : trading date rule^^xsd:string</para>
    ///   <para>skos:definition : convention for determining trading dates defined with reference to some trading date calendar published by some trading facility or exchange^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Corresponds to several ISDA FpML enumeration entries for determining Calculation Date, but refers to other kinds of trading date defined in those calendars. These include Canadian, Australian and New Zealand dates. Note also that some of these have roll rules included within them for when the date determined by the specification returns a non working day, while others explicitly return a business day and require no date roll rule. At least one is silent on this matter.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/TradingDateRule">fibo-sec-sec-sch:TradingDateRule</a>
    /// </summary>
    let TradingDateRule = _prefixId.prefix "TradingDateRule"
    /// <summary>
    ///   <para>rdfs:label : US Treasury bill auction date rule^^xsd:string</para>
    ///   <para>skos:definition : rule for setting auction dates for US Treasury bills^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.treasurydirect.gov/instit/auctfund/work/work.htm^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : To finance the public debt, the U.S. Treasury sells bills, notes, bonds, Floating Rate Notes (FRNs), and Treasury Inflation-Protected Securities (TIPS) to institutional and individual investors through public auctions. Treasury auctions occur regularly and have a set schedule. Rules and other information are available via announcements of pending auctions.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/USTreasuryBillAuctionDateRule">fibo-sec-sec-sch:USTreasuryBillAuctionDateRule</a>
    /// </summary>
    let USTreasuryBillAuctionDateRule = _prefixId.prefix "USTreasuryBillAuctionDateRule"
    /// <summary>
    ///   <para>rdfs:label : US Treasury bill date^^xsd:string</para>
    ///   <para>skos:definition : auction date for US 13 week and 26 week Treasury bills^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Per FpML notes/definition, this is every Monday except on New York holidays when it will be on a Tuesday.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/USTreasuryBillDate">fibo-sec-sec-sch:USTreasuryBillDate</a>
    /// </summary>
    let USTreasuryBillDate = _prefixId.prefix "USTreasuryBillDate"
