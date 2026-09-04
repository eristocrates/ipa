#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fnd-pty-pty`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Parties/Parties/" "fibo-fnd-pty-pty"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : party role identification scheme^^xsd:string</para>
    ///   <para>skos:definition : system for allocating identifiers to roles that parties play^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Parties/Parties/PartyRoleIdentificationScheme">fibo-fnd-pty-pty:PartyRoleIdentificationScheme</a>
    /// </summary>
    let PartyRoleIdentificationScheme = _prefixId.prefix "PartyRoleIdentificationScheme"
    /// <summary>
    ///   <para>rdfs:label : party role identifier^^xsd:string</para>
    ///   <para>skos:definition : sequence of characters, capable of uniquely identifying a party based on a specific role that they play in some context^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Parties/Parties/PartyRoleIdentifier">fibo-fnd-pty-pty:PartyRoleIdentifier</a>
    /// </summary>
    let PartyRoleIdentifier = _prefixId.prefix "PartyRoleIdentifier"
    /// <summary>
    ///   <para>rdfs:label : tax identification scheme^^xsd:string</para>
    ///   <para>skos:definition : identification scheme used to identify taxpayers in some jurisdiction^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.oecd-ilibrary.org/taxation/standard-for-automatic-exchange-of-financial-account-information-in-tax-matters-second-edition_9789264267992-en^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Parties/Parties/TaxIdentificationScheme">fibo-fnd-pty-pty:TaxIdentificationScheme</a>
    /// </summary>
    let TaxIdentificationScheme = _prefixId.prefix "TaxIdentificationScheme"
    /// <summary>
    ///   <para>rdfs:label : tax identifier^^xsd:string</para>
    ///   <para>skos:definition : identifier assigned to a taxpayer that enables compulsory financial charges and other levies to be imposed on the taxpayer by a governmental organization in order to fund government spending and various public expenditures^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.oecd-ilibrary.org/taxation/standard-for-automatic-exchange-of-financial-account-information-in-tax-matters-second-edition_9789264267992-en^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : Tax identifiers are used for various tax-related purposes in the United States and in other countries under the Common Reporting Standard (CRS).^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Parties/Parties/TaxIdentifier">fibo-fnd-pty-pty:TaxIdentifier</a>
    /// </summary>
    let TaxIdentifier = _prefixId.prefix "TaxIdentifier"
    /// <summary>
    ///   <para>rdfs:label : has mailing address^^xsd:string</para>
    ///   <para>skos:definition : identifies a physical address where an independent party can receive communications, including letters and packages^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Parties/Parties/hasMailingAddress">fibo-fnd-pty-pty:hasMailingAddress</a>
    /// </summary>
    let hasMailingAddress = _prefixId.prefix "hasMailingAddress"
