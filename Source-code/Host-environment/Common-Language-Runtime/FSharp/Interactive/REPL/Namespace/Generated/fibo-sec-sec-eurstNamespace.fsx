#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-sec-sec-eurst`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/" "fibo-sec-sec-eurst"

    let _namespaceIri = _prefixId.prefix ""
    let AdditionalTier1Capital = _prefixId.prefix "AdditionalTier1Capital"
    /// <summary>
    ///   <para>rdfs:label : Basel III Designation^^xsd:string</para>
    ///   <para>skos:definition : European Union wide securities designation, defined by the Basel Committee on Banking Supervision (BCBS), that classifies securities based on the quality of capital underlying the instrument^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.bis.org/bcbs/basel3.htm^^xsd:anyURIcmns-av:adaptedFrom : https://www.bis.org/bcbs/index.htm^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : Basel III is an international regulatory accord designed to improve the regulation, supervision, and risk management of the banking sector. It was developed in response to the global financial crisis of 2007-2008. A consortium of central banks from 28 countries devised Basel III in 2009, mainly to ensure major banks could survive another upheaval. The regulations include minimum capital, leverage, and liquidity requirements.^^xsd:stringcmns-av:explanatoryNote : Per Basel III, Tier 1 capital, or core capital, equity shares and retained earnings, is preferred. Tier 2 capital, or supplementary capital, is also usable. Possible values include Tier 1, Additional Tier 1, Tier 2, Not Subject to Regulations, and Not Provided.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/BaselIIIDesignation">fibo-sec-sec-eurst:BaselIIIDesignation</a>
    /// </summary>
    let BaselIIIDesignation = _prefixId.prefix "BaselIIIDesignation"
    let CommonEquityTier1 = _prefixId.prefix "CommonEquityTier1"
    let EURegulation236_2012 = _prefixId.prefix "EURegulation236-2012"
    /// <summary>
    ///   <para>rdfs:label : MiFID regulated security</para>
    ///   <para>skos:definition : security for which MiFID reporting is required</para>
    ///   <para>cmns-av:explanatoryNote : A MiFID requlated security is one that is traded on a MiFID regulated market and for which certain additional reporting requirements apply. Markets in Financial Instruments Directive (MiFID), which is a European regulation, issued by the European Securities and Markets Authority (ESMA), that aims to increase transparency across the European Union's financial markets and standardize regulatory disclosures required for firms operating within the EU.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/MiFIDRegulatedSecurity">fibo-sec-sec-eurst:MiFIDRegulatedSecurity</a>
    /// </summary>
    let MiFIDRegulatedSecurity = _prefixId.prefix "MiFIDRegulatedSecurity"
    let Tier1Capital = _prefixId.prefix "Tier1Capital"
    let Tier2Capital = _prefixId.prefix "Tier2Capital"
    /// <summary>
    ///   <para>rdfs:label : has upper limit on floating shares</para>
    ///   <para>skos:definition : indicates the upper limit on the number of free float shares to be reported, if applicable</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/hasUpperLimitOnFloatingShares">fibo-sec-sec-eurst:hasUpperLimitOnFloatingShares</a>
    /// </summary>
    let hasUpperLimitOnFloatingShares = _prefixId.prefix "hasUpperLimitOnFloatingShares"
    /// <summary>
    ///   <para>rdfs:label : is MiFID reporting required^^xsd:string</para>
    ///   <para>skos:definition : indicates whether reporting on the security is required by the Markets in Financial Instruments Directive (MiFID)^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : This indicator specifies whether the security is eligible for trade reporting within the Markets in Financial Instruments Directive (MiFID) zone.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/isMiFIDReportingRequired">fibo-sec-sec-eurst:isMiFIDReportingRequired</a>
    /// </summary>
    let isMiFIDReportingRequired = _prefixId.prefix "isMiFIDReportingRequired"
