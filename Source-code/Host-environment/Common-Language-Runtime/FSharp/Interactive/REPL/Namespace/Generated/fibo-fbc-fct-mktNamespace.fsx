#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fbc-fct-mkt`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/" "fibo-fbc-fct-mkt"

    let _namespaceIri = _prefixId.prefix ""
    let ActiveMICStatus = _prefixId.prefix "ActiveMICStatus"
    /// <summary>
    ///   <para>rdfs:label : alternative trading system^^xsd:string</para>
    ///   <para>skos:definition : trading venue that is more loosely regulated than a regulated exchange^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : ATS^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.iso20022.org/sites/default/files/2021-12/ISO10383_MIC_Release_2_0_Factsheet.pdf^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The SEC formally defines an alternative trading system as any organization, association, person, group of persons, or systems (1) that constitutes, maintains, or provides a market place or facilities for bringing together purchasers and sellers of securities or for otherwise performing with respect to securities the functions commonly performed by a stock exchange within the meaning of Rule 3b-16 under the Exchange Act; and (2) that does not (i) set rules governing the conduct of subscribers other than the conduct of such subscribers' trading on such organization, association, person, group of persons, or system, or (ii) discipline subscribers other than by exclusion from trading.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/AlternativeTradingSystem">fibo-fbc-fct-mkt:AlternativeTradingSystem</a>
    /// </summary>
    let AlternativeTradingSystem = _prefixId.prefix "AlternativeTradingSystem"

    /// <summary>
    ///   <para>rdfs:label : approved publication arrangement^^xsd:string</para>
    ///   <para>skos:definition : data reporting services provider that is authorized to provide the service of publishing certain trade reports on behalf of banks, investment firms, or asset management companies^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : APA^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.esma.europa.eu/press-news/esma-news/esma-identifies-data-reporting-services-providers-be-supervised-directly^^xsd:stringcmns-av:adaptedFrom : https://www.iso20022.org/sites/default/files/2021-12/ISO10383_MIC_Release_2_0_Factsheet.pdf^^xsd:stringcmns-av:adaptedFrom : https://www.lawinsider.com/dictionary/approved-publication-arrangement-apa^^xsd:string</para>
    ///   <para>cmns-av:synonym : authorised publication arrangementcmns-av:synonym : authorized publication arrangement</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/ApprovedPublicationArrangement">fibo-fbc-fct-mkt:ApprovedPublicationArrangement</a>
    /// </summary>
    let ApprovedPublicationArrangement =
        _prefixId.prefix "ApprovedPublicationArrangement"

    /// <summary>
    ///   <para>rdfs:label : approved reporting mechanism^^xsd:string</para>
    ///   <para>skos:definition : data reporting services provider that is authorized to provide the service of reporting details of transactions to competent authorities or ESMA (the European Securities and Markets Authority) on behalf of investment firms^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : ARM^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.esma.europa.eu/press-news/esma-news/esma-identifies-data-reporting-services-providers-be-supervised-directly^^xsd:stringcmns-av:adaptedFrom : https://www.iso20022.org/sites/default/files/2021-12/ISO10383_MIC_Release_2_0_Factsheet.pdf^^xsd:stringcmns-av:adaptedFrom : https://www.lawinsider.com/dictionary/approved-reporting-mechanism^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/ApprovedReportingMechanism">fibo-fbc-fct-mkt:ApprovedReportingMechanism</a>
    /// </summary>
    let ApprovedReportingMechanism = _prefixId.prefix "ApprovedReportingMechanism"
    /// <summary>
    ///   <para>rdfs:label : auction market^^xsd:string</para>
    ///   <para>skos:definition : exchange in which buyers and sellers submit competitive bids that do not involve direct negotiations between parties, as part of an auction scheduled either on demand or on a periodic basis^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/AuctionMarket">fibo-fbc-fct-mkt:AuctionMarket</a>
    /// </summary>
    let AuctionMarket = _prefixId.prefix "AuctionMarket"
    /// <summary>
    ///   <para>rdfs:label : consolidated tape provider^^xsd:string</para>
    ///   <para>skos:definition : data reporting services provider that is authorized to provide the service of collecting trade reports for financial instruments from regulated markets, MTFs, OTFs and APAs and consolidating them into a continuous electronic live data stream providing price and volume data per financial instrument^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : CTP^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.esma.europa.eu/press-news/esma-news/esma-identifies-data-reporting-services-providers-be-supervised-directly^^xsd:stringcmns-av:adaptedFrom : https://www.iso20022.org/sites/default/files/2021-12/ISO10383_MIC_Release_2_0_Factsheet.pdf^^xsd:stringcmns-av:adaptedFrom : https://www.lawinsider.com/dictionary/consolidated-tape-providers-hereinafter-referred-to-as-ctp^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Consolidated tape is an electronic system that collates real-time exchange-listed data, such as price and volume, and disseminates it to investors. Through the consolidated tape, various major exchanges, including the New York Stock Exchange, the NASDAQ, and the Chicago Board Options Exchange, report trades and quotes.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/ConsolidatedTapeProvider">fibo-fbc-fct-mkt:ConsolidatedTapeProvider</a>
    /// </summary>
    let ConsolidatedTapeProvider = _prefixId.prefix "ConsolidatedTapeProvider"
    /// <summary>
    ///   <para>rdfs:label : crypto asset services provider^^xsd:string</para>
    ///   <para>skos:definition : financial services provider that provides services for crypto assets that enable the control of crypto assets, and participate in, or provide, financial services for issuers' offers, or sale, of crypto assets^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : CASP^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.iso20022.org/sites/default/files/2021-12/ISO10383_MIC_Release_2_0_Factsheet.pdf^^xsd:stringcmns-av:adaptedFrom : https://www.lawinsider.com/dictionary/crypto-asset-service-provider-casp^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Services related to crypto assets may include businesses that exchange crypto assets for fiat currencies, or vice versa, that conduct transactions that move crypto assets from one crypto asset address, or account, to another, and/or that provide facilities for the safekeeping, or administration, of crypto assets, or instruments.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/CryptoAssetServicesProvider">fibo-fbc-fct-mkt:CryptoAssetServicesProvider</a>
    /// </summary>
    let CryptoAssetServicesProvider = _prefixId.prefix "CryptoAssetServicesProvider"
    /// <summary>
    ///   <para>rdfs:label : dark pool^^xsd:string</para>
    ///   <para>skos:definition : privately organized alternative trading system, that allows institutional investors the ability to trade without exposure until after the trade has been executed and reported^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/DarkPool">fibo-fbc-fct-mkt:DarkPool</a>
    /// </summary>
    let DarkPool = _prefixId.prefix "DarkPool"
    /// <summary>
    ///   <para>rdfs:label : data reporting services provider^^xsd:string</para>
    ///   <para>skos:definition : market data provider and reporting party that reports and/or publishes data on securities transactions, including required regulatory reporting for such transactions, and as such is subject to regulatory supervision^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : DRSP^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.esma.europa.eu/press-news/esma-news/esma-identifies-data-reporting-services-providers-be-supervised-directly^^xsd:anyURIcmns-av:adaptedFrom : https://www.esma.europa.eu/supervision/supervision/data-reporting-services-providers^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/DataReportingServicesProvider">fibo-fbc-fct-mkt:DataReportingServicesProvider</a>
    /// </summary>
    let DataReportingServicesProvider = _prefixId.prefix "DataReportingServicesProvider"
    /// <summary>
    ///   <para>rdfs:label : designated contract market^^xsd:string</para>
    ///   <para>skos:definition : exchange, trading system, or platform that enables listing for trading futures or option contracts based on any underlying commodity, index or instrument^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : DCM^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.cftc.gov/IndustryOversight/TradingOrganizations/DCMs/index.htm^^xsd:anyURIcmns-av:adaptedFrom : https://www.iso20022.org/sites/default/files/2021-12/ISO10383_MIC_Release_2_0_Factsheet.pdf^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/DesignatedContractMarket">fibo-fbc-fct-mkt:DesignatedContractMarket</a>
    /// </summary>
    let DesignatedContractMarket = _prefixId.prefix "DesignatedContractMarket"

    /// <summary>
    ///   <para>rdfs:label : electronic communication network^^xsd:string</para>
    ///   <para>skos:definition : alternative trading system that automatically matches buy and sell orders for securities in the market^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : ECN^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : ECNs allow brokerages and investors in different geographic areas to trade without a third party involved, offering privacy for investors. They also allow after-hours trading, but trading may be subject to commissions and other fees.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/ElectronicCommunicationNetwork">fibo-fbc-fct-mkt:ElectronicCommunicationNetwork</a>
    /// </summary>
    let ElectronicCommunicationNetwork =
        _prefixId.prefix "ElectronicCommunicationNetwork"

    /// <summary>
    ///   <para>rdfs:label : exchange^^xsd:string</para>
    ///   <para>skos:definition : any organization, association, or group of persons, whether incorporated or unincorporated, which constitutes, maintains, or provides a facility for bringing together purchasers and sellers of financial instruments, commodities, or other products, services, or goods, and includes the market place and facilities maintained by such exchange^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10383, Securities and related financial instruments - Codes for exchanges and market identification (MIC), Third edition, 2012-10-01, confirmed 2018-03-29^^xsd:stringcmns-av:adaptedFrom : Securities Exchange Act of 1934, as amended 12 August 2012^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : An exchange is typically a corporation or mutual organization that provides securities trading services, where securities may be bought and sold by third parties. As a facility, an exchange is also a place of trade associated with a particular site, i.e., stock exchange, regulated market such as an Electronic Trading Platform (ECN), or unregulated market, such as an Automated Trading System (ATS), or market data provider. Stock exchanges also provide facilities for the issue and redemption of securities as well as other financial instruments and capital events including the payment of income and dividends.
    ///
    /// The securities traded on a stock exchange include: shares issued by companies, unit trusts, derivatives, pooled investment products and bonds. To be able to trade a security on a certain stock exchange, it has to be listed there. Usually there is a central location at least for recordkeeping, but trade is less and less linked to such a physical place, as modern markets are electronic networks, which gives them advantages of speed and cost of transactions. Trade on an exchange is by members only.^^xsd:string</para>
    ///   <para>cmns-av:synonym : market^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/Exchange">fibo-fbc-fct-mkt:Exchange</a>
    /// </summary>
    let Exchange = _prefixId.prefix "Exchange"
    /// <summary>
    ///   <para>rdfs:label : exchange participant^^xsd:string</para>
    ///   <para>skos:definition : registered agent who, in accordance with the rules of an exchange, may trade on or through the exchange and whose name is entered in a list, register or roll kept by the exchange as an agent who may trade on or through the exchange^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/ExchangeParticipant">fibo-fbc-fct-mkt:ExchangeParticipant</a>
    /// </summary>
    let ExchangeParticipant = _prefixId.prefix "ExchangeParticipant"
    let ExpiredMICStatus = _prefixId.prefix "ExpiredMICStatus"
    let ISO10383_ClassificationScheme = _prefixId.prefix "ISO10383-ClassificationScheme"
    /// <summary>
    ///   <para>rdfs:label : interdealer quotation system^^xsd:string</para>
    ///   <para>skos:definition : automated system for organizing and disseminating price quotes by brokers and dealer firms that facilitates electronic trading in securities^^xsd:string</para>
    ///   <para>skos:example : The National Association of Securities Dealers Automatic Quotation (Nasdaq), Nasdaq SmallCap Market, and the Over-The-Counter Bulletin Board (OTCBB) exchange platforms are integrated into one IQS. By using this integrated system, investors have access to a wide range of securities, ranging from large blue-chip companies to smaller micro-caps.^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : IQS^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.investopedia.com/terms/i/interdealerquotationsystem.asp^^xsd:stringcmns-av:adaptedFrom : https://www.iso20022.org/sites/default/files/2021-12/ISO10383_MIC_Release_2_0_Factsheet.pdf^^xsd:stringcmns-av:adaptedFrom : https://www.lawinsider.com/dictionary/inter-dealer-quotation-system^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : An IQS ties the price quotations of a number of exchanges together into one platform. This allows investors to more easily access security price quotations that would otherwise need to be monitored on several separate exchanges.^^xsd:stringcmns-av:explanatoryNote : In the United States, an IQS is an automated interdealer quotation system of a national securities association registered pursuant to section 15A(a) of the Exchange Act (15 U.S.C. 78o-3(a)).^^xsd:string</para>
    ///   <para>cmns-av:synonym : inter-dealer quotation system^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/InterdealerQuotationSystem">fibo-fbc-fct-mkt:InterdealerQuotationSystem</a>
    /// </summary>
    let InterdealerQuotationSystem = _prefixId.prefix "InterdealerQuotationSystem"
    /// <summary>
    ///   <para>rdfs:label : market category classifier^^xsd:string</para>
    ///   <para>skos:definition : classifier representing the controlled vocabulary that delineates the nature of the exchange or data reporting services provider where possible^^xsd:string</para>
    ///   <para>skos:scopeNote : As of October 2022, the controlled vocabulary includes two codes that are not semantically useful, namely 'not specified', or NSPD, and 'other', or OTHR. These are included for the sake of completeness but ignored with respect to how the exchange or market is classified. If something has one of these two codes as a market category, they will be classified either as an operating-level or segment-level marketas appropriate with no other distinction in terms of how they are instantiated.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.iso20022.org/sites/default/files/2021-12/ISO10383_MIC_Release_2_0_Factsheet.pdf^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketCategoryClassifier">fibo-fbc-fct-mkt:MarketCategoryClassifier</a>
    /// </summary>
    let MarketCategoryClassifier = _prefixId.prefix "MarketCategoryClassifier"
    let MarketCategoryClassifier_APPA = _prefixId.prefix "MarketCategoryClassifier-APPA"
    let MarketCategoryClassifier_ARMS = _prefixId.prefix "MarketCategoryClassifier-ARMS"
    let MarketCategoryClassifier_ATSS = _prefixId.prefix "MarketCategoryClassifier-ATSS"
    let MarketCategoryClassifier_CASP = _prefixId.prefix "MarketCategoryClassifier-CASP"
    let MarketCategoryClassifier_CTPS = _prefixId.prefix "MarketCategoryClassifier-CTPS"
    let MarketCategoryClassifier_DCMS = _prefixId.prefix "MarketCategoryClassifier-DCMS"
    let MarketCategoryClassifier_IDQS = _prefixId.prefix "MarketCategoryClassifier-IDQS"
    let MarketCategoryClassifier_MLTF = _prefixId.prefix "MarketCategoryClassifier-MLTF"
    let MarketCategoryClassifier_NSPD = _prefixId.prefix "MarketCategoryClassifier-NSPD"
    let MarketCategoryClassifier_OTFS = _prefixId.prefix "MarketCategoryClassifier-OTFS"
    let MarketCategoryClassifier_OTHR = _prefixId.prefix "MarketCategoryClassifier-OTHR"
    let MarketCategoryClassifier_RMKT = _prefixId.prefix "MarketCategoryClassifier-RMKT"
    let MarketCategoryClassifier_RMOS = _prefixId.prefix "MarketCategoryClassifier-RMOS"
    let MarketCategoryClassifier_SEFS = _prefixId.prefix "MarketCategoryClassifier-SEFS"
    let MarketCategoryClassifier_SINT = _prefixId.prefix "MarketCategoryClassifier-SINT"
    let MarketCategoryClassifier_TRFS = _prefixId.prefix "MarketCategoryClassifier-TRFS"
    /// <summary>
    ///   <para>rdfs:label : market identifier^^xsd:string</para>
    ///   <para>skos:definition : identifier that specifies a universal method of identifying exchanges, trading platforms, regulated or non-regulated markets, and data reporting services providers as sources of prices and related information in order to facilitate automated processing^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : MIC^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10383, Securities and related financial instruments - Codes for exchanges and market identification (MIC), Third edition, 2012-10-01^^xsd:stringcmns-av:adaptedFrom : https://www.iso20022.org/market-identifier-codes^^xsd:anyURIcmns-av:adaptedFrom : https://www.iso20022.org/sites/default/files/2021-12/ISO10383_MIC_Release_2_0_Factsheet.pdf^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : It is intended for use in any application and communication for identification of places
    /// - where a financial instrument is listed (place of official listing),
    /// - where a related trade is executed (place of trade), and
    /// - where trade details are reported (trade reporting facility).^^xsd:string</para>
    ///   <para>cmns-av:synonym : Market Identifier Code^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketIdentifier">fibo-fbc-fct-mkt:MarketIdentifier</a>
    /// </summary>
    let MarketIdentifier = _prefixId.prefix "MarketIdentifier"
    /// <summary>
    ///   <para>rdfs:label : market indicator code status^^xsd:string</para>
    ///   <para>skos:definition : lifecycle stage indicating the status of the MIC code, as specified by the registration authority^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.iso20022.org/market-identifier-codes^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketIdentifierCodeStatus">fibo-fbc-fct-mkt:MarketIdentifierCodeStatus</a>
    /// </summary>
    let MarketIdentifierCodeStatus = _prefixId.prefix "MarketIdentifierCodeStatus"
    /// <summary>
    ///   <para>rdfs:label : market level classifier^^xsd:string</para>
    ///   <para>skos:definition : classifier that indicates whether the exchange or data reporting services provider is an operating level or market segment level facility^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.iso20022.org/sites/default/files/2021-12/ISO10383_MIC_Release_2_0_Factsheet.pdf^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketLevelClassifier">fibo-fbc-fct-mkt:MarketLevelClassifier</a>
    /// </summary>
    let MarketLevelClassifier = _prefixId.prefix "MarketLevelClassifier"
    let MarketLevelClassifier_OPRT = _prefixId.prefix "MarketLevelClassifier-OPRT"
    let MarketLevelClassifier_SGMT = _prefixId.prefix "MarketLevelClassifier-SGMT"
    /// <summary>
    ///   <para>rdfs:label : market segment-level market^^xsd:string</para>
    ///   <para>skos:definition : section of an exchange/market/trade reporting facility that specialises in one or more specific instruments or that is regulated differently^^xsd:string</para>
    ///   <para>skos:example : Dark pool^^xsd:string</para>
    ///   <para>skos:note : A market segment MIC can only be registered if an operating/exchange MIC already exists.^^xsd:stringskos:note : It is not required to have a MIC registered for all segments of a market, only for those segments that need to be identified.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10383, Securities and related financial instruments - Codes for exchanges and market identification (MIC), Third edition, 2012-10-01, confirmed 2018-03-29, clause 2.2^^xsd:stringcmns-av:adaptedFrom : https://www.iso20022.org/sites/default/files/2021-12/ISO10383_MIC_Release_2_0_Factsheet.pdf^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketSegmentLevelMarket">fibo-fbc-fct-mkt:MarketSegmentLevelMarket</a>
    /// </summary>
    let MarketSegmentLevelMarket = _prefixId.prefix "MarketSegmentLevelMarket"

    /// <summary>
    ///   <para>rdfs:label : market segment-level market identifier^^xsd:string</para>
    ///   <para>skos:definition : market identifier that identifies a section of an exchange/market/trade reporting facility that specialises in one or more specific instruments or that is regulated differently^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10383, Securities and related financial instruments - Codes for exchanges and market identification (MIC), Third edition, 2012-10-01, confirmed 2018-03-29, clause 2.2^^xsd:stringcmns-av:adaptedFrom : https://www.iso20022.org/sites/default/files/2021-12/ISO10383_MIC_Release_2_0_Factsheet.pdf^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MarketSegmentLevelMarketIdentifier">fibo-fbc-fct-mkt:MarketSegmentLevelMarketIdentifier</a>
    /// </summary>
    let MarketSegmentLevelMarketIdentifier =
        _prefixId.prefix "MarketSegmentLevelMarketIdentifier"

    /// <summary>
    ///   <para>rdfs:label : multilateral trading facility^^xsd:string</para>
    ///   <para>skos:definition : trading system that facilitates the exchange of financial instruments between multiple parties^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : MTF^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.investopedia.com/terms/m/multilateral_trading_facility.asp^^xsd:stringcmns-av:adaptedFrom : https://www.iso20022.org/sites/default/files/2021-12/ISO10383_MIC_Release_2_0_Factsheet.pdf^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Multilateral trading facilities allow eligible contract participants to gather and transfer a variety of securities, especially instruments that may not have an official market. These facilities are often electronic systems controlled by approved market operators or larger investment banks. Traders will usually submit orders electronically, where a matching software engine is used to pair buyers with sellers.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/MultilateralTradingFacility">fibo-fbc-fct-mkt:MultilateralTradingFacility</a>
    /// </summary>
    let MultilateralTradingFacility = _prefixId.prefix "MultilateralTradingFacility"
    /// <summary>
    ///   <para>rdfs:label : off-market facility^^xsd:string</para>
    ///   <para>skos:definition : facility used for reporting over-the-counter (OTC) and other direct trades that are not executed by the exchange but are reported through the exchange^^xsd:string</para>
    ///   <para>cmns-av:synonym : off-book^^xsd:stringcmns-av:synonym : off-facility^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/OffMarketFacility">fibo-fbc-fct-mkt:OffMarketFacility</a>
    /// </summary>
    let OffMarketFacility = _prefixId.prefix "OffMarketFacility"
    /// <summary>
    ///   <para>rdfs:label : operating-level market^^xsd:string</para>
    ///   <para>skos:definition : exchange/market/trade reporting facility in a specific market/country^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10383, Securities and related financial instruments - Codes for exchanges and market identification (MIC), Third edition, 2012-10-01, confirmed 2018-03-29, clause 2.1^^xsd:stringcmns-av:adaptedFrom : https://www.iso20022.org/sites/default/files/2021-12/ISO10383_MIC_Release_2_0_Factsheet.pdf^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/OperatingLevelMarket">fibo-fbc-fct-mkt:OperatingLevelMarket</a>
    /// </summary>
    let OperatingLevelMarket = _prefixId.prefix "OperatingLevelMarket"

    /// <summary>
    ///   <para>rdfs:label : operating-level market identifier^^xsd:string</para>
    ///   <para>skos:definition : market identifier that identifies an exchange/market/trade reporting facility in a specific market/country^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10383, Securities and related financial instruments - Codes for exchanges and market identification (MIC), Third edition, 2012-10-01, confirmed 2018-03-29, clause 2.1^^xsd:stringcmns-av:adaptedFrom : https://www.iso20022.org/sites/default/files/2021-12/ISO10383_MIC_Release_2_0_Factsheet.pdf^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/OperatingLevelMarketIdentifier">fibo-fbc-fct-mkt:OperatingLevelMarketIdentifier</a>
    /// </summary>
    let OperatingLevelMarketIdentifier =
        _prefixId.prefix "OperatingLevelMarketIdentifier"

    /// <summary>
    ///   <para>rdfs:label : organised trading facilityrdfs:label : organized trading facility</para>
    ///   <para>skos:definition : multi-lateral system which is not an RM or an MTF and in which multiple third-party buying and selling interests in bonds, structured finance products, emission allowances or derivatives are able to interact in the system in a way that results in a contract in accordance with the provisions of Title II of MiFID II^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : OTF^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.marketswiki.com/mwiki/Organized_Trading_Facility^^xsd:stringcmns-av:adaptedFrom : https://www.iso20022.org/sites/default/files/2021-12/ISO10383_MIC_Release_2_0_Factsheet.pdf^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : OTFs were introduced by the European Commission as part of MiFID II and are focused on non-equities such as derivatives and cash bond markets.
    ///
    /// OTFs are intended to be similar in scope to a swap execution facility (SEF), a type of entity created by the Dodd-Frank Act in the U.S. The goal of SEFs and OTFs is to bring transparency and structure to OTC derivatives trading.^^xsd:stringcmns-av:explanatoryNote : Unlike RMs and MTFs, operators of OTFs will have discretion as to how to execute orders, subject to pre-transparency and best execution obligations.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/OrganizedTradingFacility">fibo-fbc-fct-mkt:OrganizedTradingFacility</a>
    /// </summary>
    let OrganizedTradingFacility = _prefixId.prefix "OrganizedTradingFacility"
    /// <summary>
    ///   <para>rdfs:label : quote-driven market^^xsd:string</para>
    ///   <para>skos:definition : exchange in which prices are determined from bid and ask quotations made by market makers, dealers, or specialists^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : In a quote-driven market, dealers fill orders from their own inventory or by matching them with other orders. Note that this differs from a typical market, which is order-driven rather than quote-driven.^^xsd:string</para>
    ///   <para>cmns-av:synonym : price-driven market^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/QuoteDrivenMarket">fibo-fbc-fct-mkt:QuoteDrivenMarket</a>
    /// </summary>
    let QuoteDrivenMarket = _prefixId.prefix "QuoteDrivenMarket"
    /// <summary>
    ///   <para>rdfs:label : recognised market operatorrdfs:label : recognized market operator</para>
    ///   <para>skos:definition : exchange that is operated or maintained by an operator registered under certain securities regulations that brings together purchasers and sellers of capital market products^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : RMO^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.igi-global.com/dictionary/regulating-fintech-businesses/77383^^xsd:stringcmns-av:adaptedFrom : https://www.iso20022.org/sites/default/files/2021-12/ISO10383_MIC_Release_2_0_Factsheet.pdf^^xsd:stringcmns-av:adaptedFrom : https://www.lawinsider.com/dictionary/recognized-market^^xsd:stringcmns-av:adaptedFrom : https://www.mas.gov.sg/regulation/capital-markets/approved-exchange-ae-or-recognised-market-operator-rmo-licence^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/RecognizedMarketOperator">fibo-fbc-fct-mkt:RecognizedMarketOperator</a>
    /// </summary>
    let RecognizedMarketOperator = _prefixId.prefix "RecognizedMarketOperator"

    /// <summary>
    ///   <para>rdfs:label : registered multilateral trading facility^^xsd:string</para>
    ///   <para>skos:definition : multilateral system operated by an investment firm or market operator, which brings together multiple third-party buying and selling interests in financial instruments in the system, in accordance with non-discretionary rules, in a way that results in a contract in accordance with the provisions of Title II of the MiFID II^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/RegisteredMultilateralTradingFacility">fibo-fbc-fct-mkt:RegisteredMultilateralTradingFacility</a>
    /// </summary>
    let RegisteredMultilateralTradingFacility =
        _prefixId.prefix "RegisteredMultilateralTradingFacility"

    /// <summary>
    ///   <para>rdfs:label : regulated exchange^^xsd:string</para>
    ///   <para>skos:definition : regulated market that is operated by and/or managed by a market operator that brings together or facilitates the bringing together of multiple third-party buying and selling interests in financial instruments^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : RM^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.investopedia.com/terms/r/regulated-market.asp^^xsd:stringcmns-av:adaptedFrom : https://www.iso20022.org/sites/default/files/2021-12/ISO10383_MIC_Release_2_0_Factsheet.pdf^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : In the financial community in the EU, such an exchange operates in accordance with its non-discretionary rules in a way that results in a contract, in respect of the financial instruments admitted to trading under its rules and/or systems, and which is authorised and functions regularly and in accordance with the provisions of Title III of MiFID II.^^xsd:string</para>
    ///   <para>cmns-av:synonym : regulated market^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/RegulatedExchange">fibo-fbc-fct-mkt:RegulatedExchange</a>
    /// </summary>
    let RegulatedExchange = _prefixId.prefix "RegulatedExchange"
    /// <summary>
    ///   <para>rdfs:label : swap execution facility^^xsd:string</para>
    ///   <para>skos:definition : exchange that enables participants to execute and trade swaps^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : SEF^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.iso20022.org/sites/default/files/2021-12/ISO10383_MIC_Release_2_0_Factsheet.pdf^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Swap execution facilities, including trading systems and other platforms, allow for greater transparency and represent a significant shift in the way derivative trading has been done. The Dodd-Frank Act lays the foundation for this change of derivative execution.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/SwapExecutionFacility">fibo-fbc-fct-mkt:SwapExecutionFacility</a>
    /// </summary>
    let SwapExecutionFacility = _prefixId.prefix "SwapExecutionFacility"
    /// <summary>
    ///   <para>rdfs:label : systematic internaliserrdfs:label : systematic internalizer</para>
    ///   <para>skos:definition : investment firm that, on an organised, frequent, systematic and substantial basis, deals on its own account by executing client orders outside a regulated exchange, MTF or OTF without operating a multilateral system^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : SI^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.emissions-euets.com/systematic-internaliser^^xsd:stringcmns-av:adaptedFrom : https://www.iso20022.org/sites/default/files/2021-12/ISO10383_MIC_Release_2_0_Factsheet.pdf^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/SystematicInternaliser">fibo-fbc-fct-mkt:SystematicInternaliser</a>
    /// </summary>
    let SystematicInternaliser = _prefixId.prefix "SystematicInternaliser"
    /// <summary>
    ///   <para>rdfs:label : trade reporting facility^^xsd:string</para>
    ///   <para>skos:definition : facility that provides a mechanism for the reporting of transactions effected otherwise than on an exchange^^xsd:string</para>
    ///   <para>skos:example : In the United States, for example, trades by FINRA members in Nasdaq-listed and other exchange-listed securities, as approved by the Securities and Exchange Commission (SEC), executed otherwise than on an exchange may be reported to a FINRA TRF. While each FINRA TRF is affiliated with a registered national securities exchange, each FINRA TRF is a FINRA facility and is subject to FINRA's registration as a national securities association.^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : TRF^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.finra.org/filing-reporting/trade-reporting-facility-trf^^xsd:stringcmns-av:adaptedFrom : https://www.iso20022.org/sites/default/files/2021-12/ISO10383_MIC_Release_2_0_Factsheet.pdf^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/TradeReportingFacility">fibo-fbc-fct-mkt:TradeReportingFacility</a>
    /// </summary>
    let TradeReportingFacility = _prefixId.prefix "TradeReportingFacility"
    let UpdatedMICStatus = _prefixId.prefix "UpdatedMICStatus"
    /// <summary>
    ///   <para>rdfs:label : has facility acronym^^xsd:string</para>
    ///   <para>skos:definition : indicates a known acronym of the market^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.iso20022.org/sites/default/files/2021-12/ISO10383_MIC_Release_2_0_Factsheet.pdf^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/hasFacilityAcronym">fibo-fbc-fct-mkt:hasFacilityAcronym</a>
    /// </summary>
    let hasFacilityAcronym = _prefixId.prefix "hasFacilityAcronym"
    /// <summary>
    ///   <para>rdfs:label : has market identifier code status^^xsd:string</para>
    ///   <para>skos:definition : indicates the status of a specific market identifier code (MIC)^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/hasMarketIdentifierCodeStatus">fibo-fbc-fct-mkt:hasMarketIdentifierCodeStatus</a>
    /// </summary>
    let hasMarketIdentifierCodeStatus = _prefixId.prefix "hasMarketIdentifierCodeStatus"
    /// <summary>
    ///   <para>rdfs:label : operates in country^^xsd:string</para>
    ///   <para>skos:definition : indicates the ISO 3166-1 country in which an exchange, data reporting services provider, or crypto asset services provider operates^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.iso20022.org/sites/default/files/2021-12/ISO10383_MIC_Release_2_0_Factsheet.pdf^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/operatesInCountry">fibo-fbc-fct-mkt:operatesInCountry</a>
    /// </summary>
    let operatesInCountry = _prefixId.prefix "operatesInCountry"
    /// <summary>
    ///   <para>rdfs:label : operates in municipality^^xsd:string</para>
    ///   <para>skos:definition : indicates the municipality or business center in which in which an exchange, data reporting services provider, or crypto asset services provider operates^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.iso20022.org/sites/default/files/2021-12/ISO10383_MIC_Release_2_0_Factsheet.pdf^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/operatesInMunicipality">fibo-fbc-fct-mkt:operatesInMunicipality</a>
    /// </summary>
    let operatesInMunicipality = _prefixId.prefix "operatesInMunicipality"
