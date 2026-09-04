#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``gleif-ra`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://www.gleif.org/ontology/RegistrationAuthority/" "gleif-ra"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>skos:definition : a registry for registering and maintaining information about business entities^^xsd:string</para>
    ///   <para>rdfs:label : business registry^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/RegistrationAuthority/BusinessRegistry">gleif-ra:BusinessRegistry</a>
    /// </summary>
    let BusinessRegistry = _prefixId.prefix "BusinessRegistry"
    let RAregistry = _prefixId.prefix "RAregistry"
    /// <summary>
    ///   <para>skos:definition : The reference code of the registration authority, taken from the Registration Authorities Code List maintained by GLEIF.^^xsd:string</para>
    ///   <para>rdfs:label : registration authority code^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/RegistrationAuthority/RegistrationAuthorityCode">gleif-ra:RegistrationAuthorityCode</a>
    /// </summary>
    let RegistrationAuthorityCode = _prefixId.prefix "RegistrationAuthorityCode"
