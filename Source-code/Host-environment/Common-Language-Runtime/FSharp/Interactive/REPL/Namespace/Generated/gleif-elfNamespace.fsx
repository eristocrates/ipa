#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``gleif-elf`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://www.gleif.org/ontology/EntityLegalForm/" "gleif-elf"

    let _namespaceIri = _prefixId.prefix ""
    let ELFregistry = _prefixId.prefix "ELFregistry"
    /// <summary>
    ///   <para>skos:definition : The legal form of the entity, taken from the ISO Entity Legal Form (ELF) code list maintained by GLEIF. ^^xsd:string</para>
    ///   <para>rdfs:label : entity legal form^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/EntityLegalForm/EntityLegalForm">gleif-elf:EntityLegalForm</a>
    /// </summary>
    let EntityLegalForm = _prefixId.prefix "EntityLegalForm"
    /// <summary>
    ///   <para>skos:definition : A current code from the GLEIF-maintained list MUST be used. Values of the LegalFormEnum code list are maintained by GLEIF on behalf of ISO through the Entity Legal Form (ELF) as defined in ISO 20275.^^xsd:string</para>
    ///   <para>rdfs:label : entity legal form identifier^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/EntityLegalForm/EntityLegalFormIdentifier">gleif-elf:EntityLegalFormIdentifier</a>
    /// </summary>
    let EntityLegalFormIdentifier = _prefixId.prefix "EntityLegalFormIdentifier"
