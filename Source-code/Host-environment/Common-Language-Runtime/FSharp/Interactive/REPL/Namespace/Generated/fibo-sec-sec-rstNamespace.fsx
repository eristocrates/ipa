#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-sec-sec-rst`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/" "fibo-sec-sec-rst"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : contractual restriction^^xsd:string</para>
    ///   <para>skos:definition : contract terms setting out restrictions on either the holder or the issuer of the security, as specified in the terms of the instrument itself^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/ContractualRestriction">fibo-sec-sec-rst:ContractualRestriction</a>
    /// </summary>
    let ContractualRestriction = _prefixId.prefix "ContractualRestriction"
    /// <summary>
    ///   <para>rdfs:label : individual investor^^xsd:string</para>
    ///   <para>skos:definition : investor that is a person, rather than an organization, who may or may not be considered a qualified investor from a legal perspective^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/IndividualInvestor">fibo-sec-sec-rst:IndividualInvestor</a>
    /// </summary>
    let IndividualInvestor = _prefixId.prefix "IndividualInvestor"
    /// <summary>
    ///   <para>rdfs:label : institutional investor^^xsd:string</para>
    ///   <para>skos:definition : investor that pools money to purchase securities, real property, and other investment assets or originates loans^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Institutional investors typically buy, sell, and manage stocks, bonds, and other investment securities on behalf of its clients, customers, members, or shareholders. These include endowment funds, commercial banks, mutual funds, hedge funds, pension funds, and insurance companies. Institutional investors are able to invest in riskier securities and ventures than average investors because they are more sophisticated with respect to their investment methodologies.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/InstitutionalInvestor">fibo-sec-sec-rst:InstitutionalInvestor</a>
    /// </summary>
    let InstitutionalInvestor = _prefixId.prefix "InstitutionalInvestor"
    /// <summary>
    ///   <para>rdfs:label : investors' domicile restriction^^xsd:string</para>
    ///   <para>skos:definition : legal holding restriction that specifies where holders of a security may be domiciled^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/InvestorsDomicileRestriction">fibo-sec-sec-rst:InvestorsDomicileRestriction</a>
    /// </summary>
    let InvestorsDomicileRestriction = _prefixId.prefix "InvestorsDomicileRestriction"
    /// <summary>
    ///   <para>rdfs:label : legal holding restriction^^xsd:string</para>
    ///   <para>skos:definition : security restriction applicable to holding the security^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/LegalHoldingRestriction">fibo-sec-sec-rst:LegalHoldingRestriction</a>
    /// </summary>
    let LegalHoldingRestriction = _prefixId.prefix "LegalHoldingRestriction"
    /// <summary>
    ///   <para>rdfs:label : qualified investor restriction^^xsd:string</para>
    ///   <para>skos:definition : legal holding restriction that defines the concept of a qualified investor for a given purpose and specifies that only such qualified investors may hold the security^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : If a holding period is not defined, then the period for which the restriction applies is indefinite.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/QualifiedInvestorRestriction">fibo-sec-sec-rst:QualifiedInvestorRestriction</a>
    /// </summary>
    let QualifiedInvestorRestriction = _prefixId.prefix "QualifiedInvestorRestriction"
    /// <summary>
    ///   <para>rdfs:label : securities regulation^^xsd:string</para>
    ///   <para>skos:definition : regulation codified in law specific to securities and investments^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/SecuritiesRegulation">fibo-sec-sec-rst:SecuritiesRegulation</a>
    /// </summary>
    let SecuritiesRegulation = _prefixId.prefix "SecuritiesRegulation"
    /// <summary>
    ///   <para>rdfs:label : securities restriction^^xsd:string</para>
    ///   <para>skos:definition : legal obligation that is applicable to a financial instrument or listing as mandated in a law or by contract^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/SecuritiesRestriction">fibo-sec-sec-rst:SecuritiesRestriction</a>
    /// </summary>
    let SecuritiesRestriction = _prefixId.prefix "SecuritiesRestriction"
    /// <summary>
    ///   <para>rdfs:label : trading restriction^^xsd:string</para>
    ///   <para>skos:definition : restriction that limits trading in some manner, typically summarized on term sheets or in other documentation, including but not limited to restrictions on day trading^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/TradingRestriction">fibo-sec-sec-rst:TradingRestriction</a>
    /// </summary>
    let TradingRestriction = _prefixId.prefix "TradingRestriction"
    /// <summary>
    ///   <para>rdfs:label : has holding period^^xsd:string</para>
    ///   <para>skos:definition : identifies a holding period applicable to some financial asset^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/hasHoldingPeriod">fibo-sec-sec-rst:hasHoldingPeriod</a>
    /// </summary>
    let hasHoldingPeriod = _prefixId.prefix "hasHoldingPeriod"
    /// <summary>
    ///   <para>rdfs:label : has restriction^^xsd:string</para>
    ///   <para>skos:definition : identifies a restriction applicable to a given financial instrument or listing^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/hasRestriction">fibo-sec-sec-rst:hasRestriction</a>
    /// </summary>
    let hasRestriction = _prefixId.prefix "hasRestriction"
