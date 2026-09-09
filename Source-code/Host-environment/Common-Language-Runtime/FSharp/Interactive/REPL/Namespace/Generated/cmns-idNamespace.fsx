#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``cmns-id`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/Identifiers/" "cmns-id"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : identification scheme^^xsd:string</para>
    ///   <para>skos:definition : system for minting identifiers for things that specifies constraints on the structure of the identifier^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO/IEC 11179-3 Information technology - Metadata registries (MDR) - Part 3: Registry metamodel and basic attributes, Third edition, 2013-02-15^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Identifiers/IdentificationScheme">cmns-id:IdentificationScheme</a>
    /// </summary>
    let IdentificationScheme = _prefixId.prefix "IdentificationScheme"
    /// <summary>
    ///   <para>rdfs:label : identifier^^xsd:string</para>
    ///   <para>dct:source : ISO/IEC 11179-3 Information technology - Metadata registries (MDR) - Part 3: Registry metamodel and basic attributes, Third edition, 2013-02-15, clause 3.1.1^^xsd:string</para>
    ///   <para>skos:definition : sequence of characters uniquely identifying that with which it is associated^^xsd:string</para>
    ///   <para>skos:note : Note that some identifiers may be reused, or may be components of other identifiers, thus the restriction on what an identifier identifies is a 'some values' restriction rather than an exact cardinality. Examples of reusable identifiers include ticker symbols, and in the United States, vehicle license numbers, such as vanity plates that can be reassigned and moved from one car to another. Narrower constraints can be added to specific kinds of identifiers that are not reassignable and that identify exactly one thing, such as many national identifiers for people including passport numbers and, in the United States, social security numbers. Also, not all identifiers are explicitly defined in formal schemes, although they may be created or generated according to some formula.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Identifiers/Identifier">cmns-id:Identifier</a>
    /// </summary>
    let Identifier = _prefixId.prefix "Identifier"
    /// <summary>
    ///   <para>rdfs:label : identifies^^xsd:string</para>
    ///   <para>skos:definition : recognizes or establishes identity within some context^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Identifiers/identifies">cmns-id:identifies</a>
    /// </summary>
    let identifies = _prefixId.prefix "identifies"
    /// <summary>
    ///   <para>rdfs:label : is identified by^^xsd:string</para>
    ///   <para>skos:definition : has an identifier that is unique within some context^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/Identifiers/isIdentifiedBy">cmns-id:isIdentifiedBy</a>
    /// </summary>
    let isIdentifiedBy = _prefixId.prefix "isIdentifiedBy"
