#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-be-fct-pub`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/" "fibo-be-fct-pub"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : API-first market data provider^^xsd:string</para>
    ///   <para>skos:definition : market data provider that delivers financial information primarily through programmatic interfaces, offering real-time or historical data via APIs for automated consumption^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/APIFirstMarketDataProvider">fibo-be-fct-pub:APIFirstMarketDataProvider</a>
    /// </summary>
    let APIFirstMarketDataProvider = _prefixId.prefix "APIFirstMarketDataProvider"
    /// <summary>
    ///   <para>rdfs:label : alternative data provider^^xsd:string</para>
    ///   <para>skos:definition : market data provider that supplies non-traditional datasets derived from sources such as web activity, sentiment analysis, geospatial signals, or other alternative information channels^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/AlternativeDataProvider">fibo-be-fct-pub:AlternativeDataProvider</a>
    /// </summary>
    let AlternativeDataProvider = _prefixId.prefix "AlternativeDataProvider"

    /// <summary>
    ///   <para>rdfs:label : crypto and digital-asset data provider^^xsd:string</para>
    ///   <para>skos:definition : market data provider that supplies pricing, reference data, and analytics for digital tokens and crypto-assets^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/CryptoDigitalAssetDataProvider">fibo-be-fct-pub:CryptoDigitalAssetDataProvider</a>
    /// </summary>
    let CryptoDigitalAssetDataProvider =
        _prefixId.prefix "CryptoDigitalAssetDataProvider"

    /// <summary>
    ///   <para>rdfs:label : derivatives and volatility data provider^^xsd:string</para>
    ///   <para>skos:definition : market data provider that supplies pricing, implied-volatility surfaces, and analytics for derivatives, including options, futures, and structured products^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/DerivativesVolatilityDataProvider">fibo-be-fct-pub:DerivativesVolatilityDataProvider</a>
    /// </summary>
    let DerivativesVolatilityDataProvider =
        _prefixId.prefix "DerivativesVolatilityDataProvider"

    /// <summary>
    ///   <para>rdfs:label : exchange-sourced data provider^^xsd:string</para>
    ///   <para>skos:definition : market data provider that distributes financial information originating directly from trading venues, including order-book data, trades, quotes, and venue-specific reference data^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/ExchangeSourcedDataProvider">fibo-be-fct-pub:ExchangeSourcedDataProvider</a>
    /// </summary>
    let ExchangeSourcedDataProvider = _prefixId.prefix "ExchangeSourcedDataProvider"
    /// <summary>
    ///   <para>rdfs:label : fixed income specialist provider^^xsd:string</para>
    ///   <para>skos:definition : market data provider that focuses on pricing, reference data, and analytics for fixed-income instruments such as bonds, credit products, and money-market securities^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/FixedIncomeSpecialistProvider">fibo-be-fct-pub:FixedIncomeSpecialistProvider</a>
    /// </summary>
    let FixedIncomeSpecialistProvider = _prefixId.prefix "FixedIncomeSpecialistProvider"

    /// <summary>
    ///   <para>rdfs:label : institutional market data provider^^xsd:string</para>
    ///   <para>skos:definition : market data provider that supplies multi-asset financial information, analytics, and reference data to financial institutions such as banks, asset managers, and trading firms^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Institutional market data providers Offer real-time and historical market data for various asset classes. They ensure data accuracy and compliance with regulatory standards. They typically provide tools for data visualization and analysis to aid decision-making. They may also facilitate access to proprietary research and market insights. Many such firms provide APIs and other options for ease of integration with trading platforms and risk management systems^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/InstitutionalMarketDataProvider">fibo-be-fct-pub:InstitutionalMarketDataProvider</a>
    /// </summary>
    let InstitutionalMarketDataProvider =
        _prefixId.prefix "InstitutionalMarketDataProvider"

    /// <summary>
    ///   <para>rdfs:label : market data provider^^xsd:string</para>
    ///   <para>skos:definition : publisher that supplies financial information, reference data, analytics, or related datasets used in financial markets^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Market data providers include exchanges and independent data vendors, among others. Market valuation and related control and risk processes typically require explicit documentation of the source for a given market rate, such as an interest rate benchmark, exchange rate, stock prices, and so forth.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/MarketDataProvider">fibo-be-fct-pub:MarketDataProvider</a>
    /// </summary>
    let MarketDataProvider = _prefixId.prefix "MarketDataProvider"
    /// <summary>
    ///   <para>rdfs:label : publication^^xsd:string</para>
    ///   <para>skos:definition : document offered for general distribution and usually produced in multiple copies^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 5127:2017, Information and documentation - Foundation and vocabulary^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A publication can be anything made public by print (such as a newspaper, magazine, pamphlet, letter, telegram, via computer modem or program, or in a poster, brochure or pamphlet), orally, or by broadcast (radio, television).^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/Publication">fibo-be-fct-pub:Publication</a>
    /// </summary>
    let Publication = _prefixId.prefix "Publication"
    /// <summary>
    ///   <para>rdfs:label : publisher^^xsd:string</para>
    ///   <para>skos:definition : role of person(s) or organization(s) responsible for the printing or distribution of an item, whether in digital or print (physical) form^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10161-1:2014(en), Information and documentation - Open Systems Interconnection - Interlibrary Loan Application Protocol Specification - Part 1: Protocol specification^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Publishers may also include banks, government agencies and the like.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/Publisher">fibo-be-fct-pub:Publisher</a>
    /// </summary>
    let Publisher = _prefixId.prefix "Publisher"

    /// <summary>
    ///   <para>rdfs:label : reference data specialist provider^^xsd:string</para>
    ///   <para>skos:definition : market data provider that focuses on authoritative reference data, including corporate actions, instrument identifiers, classifications, and entity information aligned with ISO standards^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/ReferenceDataSpecialistProvider">fibo-be-fct-pub:ReferenceDataSpecialistProvider</a>
    /// </summary>
    let ReferenceDataSpecialistProvider =
        _prefixId.prefix "ReferenceDataSpecialistProvider"

    /// <summary>
    ///   <para>rdfs:label : has publisher^^xsd:string</para>
    ///   <para>skos:definition : indicates the party in the role of issuing the information^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/hasPublisher">fibo-be-fct-pub:hasPublisher</a>
    /// </summary>
    let hasPublisher = _prefixId.prefix "hasPublisher"
    /// <summary>
    ///   <para>rdfs:label : is published by^^xsd:string</para>
    ///   <para>skos:definition : identifies the independent party (i.e., the individual or organization) that disseminates the material^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/isPublishedBy">fibo-be-fct-pub:isPublishedBy</a>
    /// </summary>
    let isPublishedBy = _prefixId.prefix "isPublishedBy"
    /// <summary>
    ///   <para>rdfs:label : publishes^^xsd:string</para>
    ///   <para>skos:definition : prepares and issues material for public consumption^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/publishes">fibo-be-fct-pub:publishes</a>
    /// </summary>
    let publishes = _prefixId.prefix "publishes"
