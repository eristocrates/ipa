#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``gleif-L2parent`` =
    let _prefixId = PrefixId.fromNamespaceLabel "https://www.gleif.org/ontology/L2Parent/" "gleif-L2parent"

    let _namespaceIri = _prefixId.prefix ""
    let EntityWithoutLEI = _prefixId.prefix "EntityWithoutLEI"
    /// <summary>
    ///   <para>rdfs:label : parent entity registry entry^^xsd:string</para>
    ///   <para>skos:definition : The Registration container element which contains all information on the legal entity's parent registration with the Managing LOU.^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L2Parent/ParentEntityRegistryEntry">gleif-L2parent:ParentEntityRegistryEntry</a>
    /// </summary>
    let ParentEntityRegistryEntry = _prefixId.prefix "ParentEntityRegistryEntry"
    /// <summary>
    ///   <para>rdfs:label : parent registration status^^xsd:string</para>
    ///   <para>skos:definition : The status of the parent legal entity's registration with the Managing LOU.^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/L2Parent/RegistrationStatus">gleif-L2parent:RegistrationStatus</a>
    /// </summary>
    let RegistrationStatus = _prefixId.prefix "RegistrationStatus"

    let RegistrationStatusPendingValidation = _prefixId.prefix "RegistrationStatusPendingValidation"
