#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-sec-sec-idind`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/" "fibo-sec-sec-idind"

    let _namespaceIri = _prefixId.prefix ""
    let CGSCUSIPAccessRepository = _prefixId.prefix "CGSCUSIPAccessRepository"
    let CUSIPGlobalServices = _prefixId.prefix "CUSIPGlobalServices"

    /// <summary>
    ///   <para>rdfs:label : CUSIP International Numbering System (CINS) number^^xsd:string</para>
    ///   <para>skos:definition : 9-character alphanumeric identifier that employs the same 9 characters as CUSIP, but also contains a letter of the alphabet in the first position signifying the issuer's country or geographic region, issued by CUSIP Global Services^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : CINS^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.cusip.com/cusip/about-cgs-identifiers.htm^^xsd:anyURI</para>
    ///   <para>cmns-av:synonym : CINS number^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/CUSIPInternationalNumberingSystemNumber">fibo-sec-sec-idind:CUSIPInternationalNumberingSystemNumber</a>
    /// </summary>
    let CUSIPInternationalNumberingSystemNumber =
        _prefixId.prefix "CUSIPInternationalNumberingSystemNumber"

    let CUSIPInternationalNumberingSystemScheme =
        _prefixId.prefix "CUSIPInternationalNumberingSystemScheme"

    /// <summary>
    ///   <para>rdfs:label : Committee on Uniform Securities Identification Procedures (CUSIP) number^^xsd:string</para>
    ///   <para>skos:definition : nine-character alphanumeric number that identifies all North American stocks and registered bonds for the purposes of facilitating clearing and settlement of trades, issued by CUSIP Global Services on behalf of the American Bankers' Association, which is a part of Standard and Poor's Capital IQ, that is the National Numbering Agency Identifier for securities issued in North America, which is also part of the ISIN for the security it identifies^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : CUSIP^^xsd:string</para>
    ///   <para>cmns-av:synonym : CUSIP number^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/CommitteeOnUniformSecuritiesIdentificationProceduresNumber">fibo-sec-sec-idind:CommitteeOnUniformSecuritiesIdentificationProceduresNumber</a>
    /// </summary>
    let CommitteeOnUniformSecuritiesIdentificationProceduresNumber =
        _prefixId.prefix "CommitteeOnUniformSecuritiesIdentificationProceduresNumber"

    let CommitteeOnUniformSecuritiesIdentificationProceduresScheme =
        _prefixId.prefix "CommitteeOnUniformSecuritiesIdentificationProceduresScheme"

    /// <summary>
    ///   <para>rdfs:label : common code registry entry^^xsd:string</para>
    ///   <para>skos:definition : entry in a common code registry^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/CommonCodeRegistryEntry">fibo-sec-sec-idind:CommonCodeRegistryEntry</a>
    /// </summary>
    let CommonCodeRegistryEntry = _prefixId.prefix "CommonCodeRegistryEntry"
    let CommonCodeRepository = _prefixId.prefix "CommonCodeRepository"

    /// <summary>
    ///   <para>rdfs:label : Euroclear Clearstream common code^^xsd:string</para>
    ///   <para>skos:definition : nine-character alphanumeric securities identifier, issued in Luxembourg, jointly by Euroclear and Clearstream^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.isin.net/common-code-isin/^^xsd:anyURI</para>
    ///   <para>cmns-av:synonym : common code^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/EuroclearClearstreamCommonCode">fibo-sec-sec-idind:EuroclearClearstreamCommonCode</a>
    /// </summary>
    let EuroclearClearstreamCommonCode =
        _prefixId.prefix "EuroclearClearstreamCommonCode"

    let EuroclearClearstreamCommonCodeScheme =
        _prefixId.prefix "EuroclearClearstreamCommonCodeScheme"

    /// <summary>
    ///   <para>rdfs:label : financial instrument global identifier^^xsd:string</para>
    ///   <para>skos:definition : financial instrument identifier that is defined as specified in the Object Management Group (OMG) Financial Instrument Global Identifier (FIGI) Specification^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : FIGI^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.omg.org/spec/FIGI^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : The development of the Financial Instrument Global Identifier (FIGI) originated from a need for a standard methodology to bridge across multiple identification systems for financial instruments. Without prejudice against any existing symbol-based solutions, or any question of the validity of one system over the other, the FIGI standard utilizes a metadata driven approach to enable the unique and persistent identification of financial instruments. While in most cases, a FIGI uniquely identifies a security, there are situations outside of the U.S. where it instead identifies a listing for a security, similar to a ticker symbol.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/FinancialInstrumentGlobalIdentifier">fibo-sec-sec-idind:FinancialInstrumentGlobalIdentifier</a>
    /// </summary>
    let FinancialInstrumentGlobalIdentifier =
        _prefixId.prefix "FinancialInstrumentGlobalIdentifier"

    let FinancialInstrumentGlobalIdentifierRegistry =
        _prefixId.prefix "FinancialInstrumentGlobalIdentifierRegistry"

    /// <summary>
    ///   <para>rdfs:label : Financial Instrument Global Identifier (FIGI) registry entry^^xsd:string</para>
    ///   <para>skos:definition : entry in a Financial Instrument Global Identifier (FIGI) registry^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : FIGI registry entry^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.omg.org/spec/FIGI^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/FinancialInstrumentGlobalIdentifierRegistryEntry">fibo-sec-sec-idind:FinancialInstrumentGlobalIdentifierRegistryEntry</a>
    /// </summary>
    let FinancialInstrumentGlobalIdentifierRegistryEntry =
        _prefixId.prefix "FinancialInstrumentGlobalIdentifierRegistryEntry"

    let FinancialInstrumentGlobalIdentifierScheme =
        _prefixId.prefix "FinancialInstrumentGlobalIdentifierScheme"

    let FinancialTimesInteractiveDataScheme =
        _prefixId.prefix "FinancialTimesInteractiveDataScheme"

    /// <summary>
    ///   <para>rdfs:label : Refinitiv instrument code^^xsd:string</para>
    ///   <para>skos:definition : proprietary code for financial instruments and indices owned, managed, and distributed by the London Stock Exchange Group's LSEG Financial Solutions (branded as Refinitiv)^^xsd:string</para>
    ///   <para>skos:note : A Refinitiv Instrument Code (RIC), previously known as the Reuters Instrument Code, is a proprietary identifier used by Refinitiv (now LSEG Financial Solutions) to represent financial instrument related data. The composition of a RIC is dependent on the type of instrument.
    ///
    /// - Instrument code : Can be based on the exchange ticker code, ISIN or local code, currency code, and so on
    /// - Period or time interval : Can be an expiry month code for example
    /// - Delimiter : Usually a full stop used to separate the instrument code from the exchange code or a = sign for money securities.
    /// - Source code : Usually a single or double alpha-character capital unique to an exchange
    ///
    /// An equity RIC has several components: the Equity RIC root is in upper case, brokerage characters in lower case (if applicable), and finally an exchange identifier. These codes facilitate information lookup across various financial networks. The concept of RICs traces back to the Quotron service, which Thomson Reuters acquired in the 1980s. The division was spun out as Refinitiv in 2018. Refinitiv was acquired by the London Stock Exchange Group in 2021, and the organization was rebranded as LSEG Financial Solutions in 2023, though the name of the code and certain other branded concepts were retained.^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : RIC^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://community.developers.refinitiv.com/questions/28938/ric-code-understandingidentificaiton.html^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/RefinitivInstrumentCode">fibo-sec-sec-idind:RefinitivInstrumentCode</a>
    /// </summary>
    let RefinitivInstrumentCode = _prefixId.prefix "RefinitivInstrumentCode"
    let RefinitivInstrumentCodeScheme = _prefixId.prefix "RefinitivInstrumentCodeScheme"
    let SEDOLMasterFile = _prefixId.prefix "SEDOLMasterFile"

    /// <summary>
    ///   <para>rdfs:label : Stock Exchange Daily Official List (SEDOL) code^^xsd:string</para>
    ///   <para>skos:definition : seven-character security identifier, issued by the London Stock Exchange, that is the National Securities Identifying Number (NSIN) for securities issued in the United Kingdom, which is also part of the ISIN for the security it identifies^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : SEDOL code^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/StockExchangeDailyOfficialListCode">fibo-sec-sec-idind:StockExchangeDailyOfficialListCode</a>
    /// </summary>
    let StockExchangeDailyOfficialListCode =
        _prefixId.prefix "StockExchangeDailyOfficialListCode"

    let StockExchangeDailyOfficialListScheme =
        _prefixId.prefix "StockExchangeDailyOfficialListScheme"

    /// <summary>
    ///   <para>rdfs:label : Telekurs Id^^xsd:string</para>
    ///   <para>skos:definition : identifier used to identify financial instruments owned, managed, and distributed by SIX Financial Information (formerly Telekurs AG and subsequently SIX Telekurs Ltd.)^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The Telekurs Id was phased out in favor of the Valoren (Valor Nummer in Swiss German) in 2013.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/TelekursId">fibo-sec-sec-idind:TelekursId</a>
    /// </summary>
    let TelekursId = _prefixId.prefix "TelekursId"

    let TelekursSecurityIdentifierScheme =
        _prefixId.prefix "TelekursSecurityIdentifierScheme"

    /// <summary>
    ///   <para>rdfs:label : Valoren^^xsd:string</para>
    ///   <para>skos:definition : identification number assigned to financial instruments in Switzerland, Liechtenstein and Belgium, issued by SIX Financial Information, that is the National Securities Identifying Number (NSIN) for securities issued in those countries and is also part of the ISIN for the security it identifies^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.isin.net/valoren/^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : A VALOR code is between six and nine characters in length and like other securities identification codes (like ISIN, CUSIPs etc). A VALOR is utilized for identification purposes as well as clearing and settlement, similar to an ISIN code, and identifies debt and equity securities.^^xsd:string</para>
    ///   <para>cmns-av:synonym : Valorcmns-av:synonym : Valorcmns-av:synonym : Valor Codecmns-av:synonym : Valor Nummercmns-av:synonym : Valoren Codecmns-av:synonym : Valoren Number</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/Valoren">fibo-sec-sec-idind:Valoren</a>
    /// </summary>
    let Valoren = _prefixId.prefix "Valoren"
    let ValorenScheme = _prefixId.prefix "ValorenScheme"
