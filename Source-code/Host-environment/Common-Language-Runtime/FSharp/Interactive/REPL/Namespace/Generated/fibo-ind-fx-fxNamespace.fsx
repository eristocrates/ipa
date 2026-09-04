#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-ind-fx-fx`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/" "fibo-ind-fx-fx"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : currency conversion service^^xsd:string</para>
    ///   <para>skos:definition : foreign exchange service involving the conversion of currency of one country or group of countries for another, typically, but not always, as a counter transaction^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A currency exchange service may be provided by a stand-alone business or may be part of the services offered by a bank or other financial institution. The currency exchange profits from its services either through adjusting the exchange rate or taking a commission.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencyConversionService">fibo-ind-fx-fx:CurrencyConversionService</a>
    /// </summary>
    let CurrencyConversionService = _prefixId.prefix "CurrencyConversionService"
    /// <summary>
    ///   <para>rdfs:label : currency forward rate^^xsd:string</para>
    ///   <para>skos:definition : rate of exchange between two currencies for settlement at some future point in time, expressed as a premium on the spot rate^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencyForwardRate">fibo-ind-fx-fx:CurrencyForwardRate</a>
    /// </summary>
    let CurrencyForwardRate = _prefixId.prefix "CurrencyForwardRate"
    /// <summary>
    ///   <para>rdfs:label : currency forward rate volatility^^xsd:string</para>
    ///   <para>skos:definition : measure of exchange rate fluctuation based on a range of projected values for exchange rates^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencyForwardRateVolatility">fibo-ind-fx-fx:CurrencyForwardRateVolatility</a>
    /// </summary>
    let CurrencyForwardRateVolatility = _prefixId.prefix "CurrencyForwardRateVolatility"
    /// <summary>
    ///   <para>rdfs:label : currency spot buy rate^^xsd:string</para>
    ///   <para>skos:definition : indicative spot buying market rate as observed by the reporting source^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencySpotBuyRate">fibo-ind-fx-fx:CurrencySpotBuyRate</a>
    /// </summary>
    let CurrencySpotBuyRate = _prefixId.prefix "CurrencySpotBuyRate"
    /// <summary>
    ///   <para>rdfs:label : currency spot mid rate^^xsd:string</para>
    ///   <para>skos:definition : indicative middle market (mean of spot buying and selling) rate as observed by the reporting source^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencySpotMidRate">fibo-ind-fx-fx:CurrencySpotMidRate</a>
    /// </summary>
    let CurrencySpotMidRate = _prefixId.prefix "CurrencySpotMidRate"
    /// <summary>
    ///   <para>rdfs:label : currency spot rate^^xsd:string</para>
    ///   <para>skos:definition : rate at which one currency may be exchanged for another for immediate delivery^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Spot rates represent the prices buyers pay in one currency to purchase a second currency. Although the spot exchange rate is for delivery on the earliest value date, the standard settlement date for most spot transactions is two business days after the transaction date.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencySpotRate">fibo-ind-fx-fx:CurrencySpotRate</a>
    /// </summary>
    let CurrencySpotRate = _prefixId.prefix "CurrencySpotRate"
    /// <summary>
    ///   <para>rdfs:label : currency spot sell rate^^xsd:string</para>
    ///   <para>skos:definition : indicative spot selling market rate as observed by the reporting source^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencySpotSellRate">fibo-ind-fx-fx:CurrencySpotSellRate</a>
    /// </summary>
    let CurrencySpotSellRate = _prefixId.prefix "CurrencySpotSellRate"
    /// <summary>
    ///   <para>rdfs:label : currency spot volatility^^xsd:string</para>
    ///   <para>skos:definition : measure of exchange rate fluctuation based on a range of past actual values for exchange rates^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencySpotVolatility">fibo-ind-fx-fx:CurrencySpotVolatility</a>
    /// </summary>
    let CurrencySpotVolatility = _prefixId.prefix "CurrencySpotVolatility"
    /// <summary>
    ///   <para>rdfs:label : exchange rate structure^^xsd:string</para>
    ///   <para>skos:definition : structured collection of quoted or projected exchange rates, such that volatility may be constructed for the structure^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/ExchangeRateStructure">fibo-ind-fx-fx:ExchangeRateStructure</a>
    /// </summary>
    let ExchangeRateStructure = _prefixId.prefix "ExchangeRateStructure"
    /// <summary>
    ///   <para>rdfs:label : exchange rate volatility^^xsd:string</para>
    ///   <para>skos:definition : statistical measure of the rate of change in the rate at which one currency can be exchanged for another^^xsd:string</para>
    ///   <para>cmns-av:usageNote : Volatility is modeled here using a structured collection, comprised of a series of individual exchange rates (either projected or prior quoted rates), dates, and the source for those rates for some overall period of time^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/ExchangeRateVolatility">fibo-ind-fx-fx:ExchangeRateVolatility</a>
    /// </summary>
    let ExchangeRateVolatility = _prefixId.prefix "ExchangeRateVolatility"
    /// <summary>
    ///   <para>rdfs:label : foreign exchange service^^xsd:string</para>
    ///   <para>skos:definition : financial service involving the exchange of one currency for another, conversion of one currency for another, and transfer of money from one country to another whereby currency conversion is required^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/ForeignExchangeService">fibo-ind-fx-fx:ForeignExchangeService</a>
    /// </summary>
    let ForeignExchangeService = _prefixId.prefix "ForeignExchangeService"

    /// <summary>
    ///   <para>rdfs:label : international electronic funds transfer service^^xsd:string</para>
    ///   <para>skos:definition : electronic funds transfer (EFT) service involving the transfer of funds across national borders, that may also involve currency conversion^^xsd:string</para>
    ///   <para>cmns-av:synonym : international wire transfer^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/InternationalElectronicFundsTransferService">fibo-ind-fx-fx:InternationalElectronicFundsTransferService</a>
    /// </summary>
    let InternationalElectronicFundsTransferService =
        _prefixId.prefix "InternationalElectronicFundsTransferService"

    /// <summary>
    ///   <para>rdfs:label : quoted exchange rate^^xsd:string</para>
    ///   <para>skos:definition : exchange rate quoted at a specific point in time, for a given block amount of currency as quoted against another (base) currency^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : An exchange rate of R represents a rate of R units of the quoted currency to 1 unit of the base currency.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/QuotedExchangeRate">fibo-ind-fx-fx:QuotedExchangeRate</a>
    /// </summary>
    let QuotedExchangeRate = _prefixId.prefix "QuotedExchangeRate"

    /// <summary>
    ///   <para>rdfs:label : has exchange rate quotation source</para>
    ///   <para>skos:definition : indicates the origin of a quoted exchange rate</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/hasExchangeRateQuotationSource">fibo-ind-fx-fx:hasExchangeRateQuotationSource</a>
    /// </summary>
    let hasExchangeRateQuotationSource =
        _prefixId.prefix "hasExchangeRateQuotationSource"

    /// <summary>
    ///   <para>rdfs:label : has quotation block amount basis^^xsd:string</para>
    ///   <para>skos:definition : indicates the amount of the dealt currency which would be exchanged in a trade for which the stated spot rate applies^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/hasQuotationBlockAmountBasis">fibo-ind-fx-fx:hasQuotationBlockAmountBasis</a>
    /// </summary>
    let hasQuotationBlockAmountBasis = _prefixId.prefix "hasQuotationBlockAmountBasis"
    /// <summary>
    ///   <para>rdfs:label : has quotation settlement basis^^xsd:string</para>
    ///   <para>skos:definition : indicates the settlement period for a trade for which the stated spot rate applies^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/hasQuotationSettlementBasis">fibo-ind-fx-fx:hasQuotationSettlementBasis</a>
    /// </summary>
    let hasQuotationSettlementBasis = _prefixId.prefix "hasQuotationSettlementBasis"
    /// <summary>
    ///   <para>rdfs:label : has quote currency^^xsd:string</para>
    ///   <para>skos:definition : indicates the quote currency in an exchange rate; R units of this currency represent one unit of the base currency^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/hasQuoteCurrency">fibo-ind-fx-fx:hasQuoteCurrency</a>
    /// </summary>
    let hasQuoteCurrency = _prefixId.prefix "hasQuoteCurrency"
    /// <summary>
    ///   <para>rdfs:label : has quoted exchange rate</para>
    ///   <para>skos:definition : rate of exchange between two currencies as specified as of some date and time as quoted by a specific source</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/hasQuotedExchangeRate">fibo-ind-fx-fx:hasQuotedExchangeRate</a>
    /// </summary>
    let hasQuotedExchangeRate = _prefixId.prefix "hasQuotedExchangeRate"
    /// <summary>
    ///   <para>rdfs:label : is premium on^^xsd:string</para>
    ///   <para>skos:definition : an exchange rate expressed as a premium on the spot rate for the currency pair^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/isPremiumOn">fibo-ind-fx-fx:isPremiumOn</a>
    /// </summary>
    let isPremiumOn = _prefixId.prefix "isPremiumOn"
