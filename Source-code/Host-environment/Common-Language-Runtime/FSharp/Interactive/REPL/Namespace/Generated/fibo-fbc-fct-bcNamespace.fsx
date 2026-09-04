#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fbc-fct-bc`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessCenters/" "fibo-fbc-fct-bc"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : business center code^^xsd:string</para>
    ///   <para>skos:definition : code used to denote a metropolitan area where business is conducted^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.fpml.org/coding-scheme/business-center^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : The codes for business centers and municipalities defined herein are largely those identified either as FpML business centers or are locations where there is an exchange, as noted in the ISO 10962 MIC code standard.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessCenters/BusinessCenterCode">fibo-fbc-fct-bc:BusinessCenterCode</a>
    /// </summary>
    let BusinessCenterCode = _prefixId.prefix "BusinessCenterCode"
    /// <summary>
    ///   <para>rdfs:label : business center code set^^xsd:string</para>
    ///   <para>skos:definition : coding scheme used to define a set of codes for municipalities or business centers^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.fpml.org/coding-scheme/business-center^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessCenters/BusinessCenterCodeScheme">fibo-fbc-fct-bc:BusinessCenterCodeScheme</a>
    /// </summary>
    let BusinessCenterCodeScheme = _prefixId.prefix "BusinessCenterCodeScheme"
    /// <summary>
    ///   <para>rdfs:label : business day adjustment code^^xsd:string</para>
    ///   <para>skos:definition : code used to denote a convention for specifying what happens when a date falls on a day that is weekend or holiday in some municipality or business center^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.fpml.org/coding-scheme/business-center^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessCenters/BusinessDayAdjustmentCode">fibo-fbc-fct-bc:BusinessDayAdjustmentCode</a>
    /// </summary>
    let BusinessDayAdjustmentCode = _prefixId.prefix "BusinessDayAdjustmentCode"
