#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-sec-sec-cls`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/" "fibo-sec-sec-cls"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : asset class^^xsd:string</para>
    ///   <para>skos:definition : financial instrument classifier for a group of securities that exhibit similar characteristics, behave similarly in the marketplace and are subject to the same laws and regulations^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.investopedia.com/terms/a/assetclasses.asp^^xsd:anyURIcmns-av:adaptedFrom : https://www.law.cornell.edu/cfr/text/17/45.1^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : Asset class means the broad category of goods, services or commodities, including any 'excluded commodity' as defined in CEA section 1a(19), with common characteristics underlying a swap. The asset classes include credit, equity, foreign exchange (excluding cross-currency), interest rate (including cross-currency), other commodity, and such other asset classes as may be determined by the Commission.^^xsd:stringcmns-av:explanatoryNote : The three main asset classes are equities, or stocks; fixed income, or bonds; and cash equivalents, or money market instruments. Some investment professionals add real estate and commodities, and possibly other types of investments, to the asset class mix.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/AssetClass">fibo-sec-sec-cls:AssetClass</a>
    /// </summary>
    let AssetClass = _prefixId.prefix "AssetClass"

    /// <summary>
    ///   <para>rdfs:label : classification of financial instruments code scheme^^xsd:string</para>
    ///   <para>skos:definition : classification scheme for set of codes for financial instruments that can be used globally for straight-through processing by all involved participants in an electronic data processing environment^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : CFI code scheme^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.iso.org/standard/73564.html^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : The ISO 10962 Securities and related financial instruments - Classification of financial instruments (CFI) code was developed as a solution to a number of challenges. One is to establish a series of codes which clearly classify financial instruments having similar features. The other is to develop a glossary of terms and provide common definitions which allow market participants to easily understand terminology being used.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/ClassificationOfFinancialInstrumentsCodeScheme">fibo-sec-sec-cls:ClassificationOfFinancialInstrumentsCodeScheme</a>
    /// </summary>
    let ClassificationOfFinancialInstrumentsCodeScheme =
        _prefixId.prefix "ClassificationOfFinancialInstrumentsCodeScheme"

    /// <summary>
    ///   <para>rdfs:label : financial instrument classification code^^xsd:string</para>
    ///   <para>skos:definition : classifier and code for a financial instrument defined in the ISO 10962 Classification of Financial Instruments (CFI) Code Scheme^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : CFI code^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.iso.org/standard/73564.html^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/FinancialInstrumentClassificationCode">fibo-sec-sec-cls:FinancialInstrumentClassificationCode</a>
    /// </summary>
    let FinancialInstrumentClassificationCode =
        _prefixId.prefix "FinancialInstrumentClassificationCode"

    /// <summary>
    ///   <para>rdfs:label : financial instrument classification scheme^^xsd:string</para>
    ///   <para>skos:definition : classification scheme defining a set of classifiers for financial instruments^^xsd:string</para>
    ///   <para>skos:example : the ISO 10962 Classification of Financial Instruments (CFI) classification scheme^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/FinancialInstrumentClassificationScheme">fibo-sec-sec-cls:FinancialInstrumentClassificationScheme</a>
    /// </summary>
    let FinancialInstrumentClassificationScheme =
        _prefixId.prefix "FinancialInstrumentClassificationScheme"

    /// <summary>
    ///   <para>rdfs:label : financial instrument classifier^^xsd:string</para>
    ///   <para>skos:definition : classifier for a financial instrument based on its type and features^^xsd:string</para>
    ///   <para>skos:example : Examples include equity instrument, debt instrument, option, future, etc. per the the ISO 10962 CFI (Classification of Financial Instruments) standard, as cash instruments or derivative instruments per the Financial Accounting Standards Board (FASB) and International Accounting Standards Board (IASB) accounting standards, and so forth.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/FinancialInstrumentClassifier">fibo-sec-sec-cls:FinancialInstrumentClassifier</a>
    /// </summary>
    let FinancialInstrumentClassifier = _prefixId.prefix "FinancialInstrumentClassifier"

    /// <summary>
    ///   <para>rdfs:label : Global Industry Classification Standards classifier^^xsd:string</para>
    ///   <para>skos:definition : four-tiered standardized classification or delineation for an organization based on the principal business activity of the organization^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : GICS classifier^^xsd:stringcmns-av:abbreviation : GICS code^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/GlobalIndustryClassificationStandardsClassifier">fibo-sec-sec-cls:GlobalIndustryClassificationStandardsClassifier</a>
    /// </summary>
    let GlobalIndustryClassificationStandardsClassifier =
        _prefixId.prefix "GlobalIndustryClassificationStandardsClassifier"

    let GlobalIndustryClassificationStandardsScheme =
        _prefixId.prefix "GlobalIndustryClassificationStandardsScheme"

    let ISO10962_201910_CodeScheme = _prefixId.prefix "ISO10962-201910-CodeScheme"

    /// <summary>
    ///   <para>rdfs:label : industry classification benchmark classifier^^xsd:string</para>
    ///   <para>skos:definition : standardized classification or delineation for an organization based on their main source of revenue^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : ICB classifier^^xsd:stringcmns-av:abbreviation : ICB code^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/IndustryClassificationBenchmarkClassifier">fibo-sec-sec-cls:IndustryClassificationBenchmarkClassifier</a>
    /// </summary>
    let IndustryClassificationBenchmarkClassifier =
        _prefixId.prefix "IndustryClassificationBenchmarkClassifier"

    let IndustryClassificationBenchmarkScheme =
        _prefixId.prefix "IndustryClassificationBenchmarkScheme"
