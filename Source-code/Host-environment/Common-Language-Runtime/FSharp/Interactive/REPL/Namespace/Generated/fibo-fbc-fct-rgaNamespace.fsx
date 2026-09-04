#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fbc-fct-rga`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/RegulatoryAgencies/" "fibo-fbc-fct-rga"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : examiner^^xsd:string</para>
    ///   <para>skos:definition : party empowered as an official representative by a regulatory agency to investigate and review specified documents for accuracy and truthfulness^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Black's Law Dictionary, see http://thelawdictionary.org/examiner/^^xsd:stringcmns-av:adaptedFrom : EDM Council^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/RegulatoryAgencies/Examiner">fibo-fbc-fct-rga:Examiner</a>
    /// </summary>
    let Examiner = _prefixId.prefix "Examiner"
    /// <summary>
    ///   <para>rdfs:label : government-issued license^^xsd:string</para>
    ///   <para>skos:definition : grant of permission needed to legally perform some task, provide some service, exercise a certain privilege, or pursue some business or occupation^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Barron's Dictionary of Business and Economics Terms, Fifth Edition, 2012^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/RegulatoryAgencies/GovernmentIssuedLicense">fibo-fbc-fct-rga:GovernmentIssuedLicense</a>
    /// </summary>
    let GovernmentIssuedLicense = _prefixId.prefix "GovernmentIssuedLicense"

    /// <summary>
    ///   <para>rdfs:label : regulation identification scheme^^xsd:string</para>
    ///   <para>skos:definition : a scheme for organizing information and allocating identifiers to regulations^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/RegulatoryAgencies/RegulationIdentificationScheme">fibo-fbc-fct-rga:RegulationIdentificationScheme</a>
    /// </summary>
    let RegulationIdentificationScheme =
        _prefixId.prefix "RegulationIdentificationScheme"

    /// <summary>
    ///   <para>rdfs:label : regulation identifier^^xsd:string</para>
    ///   <para>skos:definition : an identifier associated with a regulation^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/RegulatoryAgencies/RegulationIdentifier">fibo-fbc-fct-rga:RegulationIdentifier</a>
    /// </summary>
    let RegulationIdentifier = _prefixId.prefix "RegulationIdentifier"
    /// <summary>
    ///   <para>rdfs:label : regulatory capacity^^xsd:string</para>
    ///   <para>skos:definition : the capacity of some natural person to regulate some industry, organization, or product by virtue of some certification program on behalf of some regulatory agency^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/RegulatoryAgencies/RegulatoryCapacity">fibo-fbc-fct-rga:RegulatoryCapacity</a>
    /// </summary>
    let RegulatoryCapacity = _prefixId.prefix "RegulatoryCapacity"
    /// <summary>
    ///   <para>rdfs:label : tax authority^^xsd:string</para>
    ///   <para>skos:definition : regulatory agency that has jurisdiction over the assessment, determination, collection, imposition and other aspects of any tax^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.collinsdictionary.com/dictionary/english/tax-authority^^xsd:stringcmns-av:adaptedFrom : https://www.lawinsider.com/dictionary/tax-authority^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/RegulatoryAgencies/TaxAuthority">fibo-fbc-fct-rga:TaxAuthority</a>
    /// </summary>
    let TaxAuthority = _prefixId.prefix "TaxAuthority"
