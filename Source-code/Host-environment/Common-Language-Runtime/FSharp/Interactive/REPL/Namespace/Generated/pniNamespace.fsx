#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module pni =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://data.press.net/ontology/identifier/" "pni"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : The Authority for an Identifier, for example the domain or namespace within which an ID is contained</para>
    ///   <para>rdfs:label : The Authority for an Identifier</para>
    ///   <a href="http://data.press.net/ontology/identifier/Authority">pni:Authority</a>
    /// </summary>
    let Authority = _prefixId.prefix "Authority"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : An instance that is Identifiable can have an Identifier associated with it.</para>
    ///   <para>rdfs:label : An Identifiable resource type</para>
    ///   <a href="http://data.press.net/ontology/identifier/Identifiable">pni:Identifiable</a>
    /// </summary>
    let Identifiable = _prefixId.prefix "Identifiable"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : An ID for a given resource. For example a literal ID from a legacy system</para>
    ///   <para>rdfs:label : An Identifier for a resource</para>
    ///   <a href="http://data.press.net/ontology/identifier/Identifier">pni:Identifier</a>
    /// </summary>
    let Identifier = _prefixId.prefix "Identifier"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : Property defining the containing authority of an Identifier</para>
    ///   <para>rdfs:label : Indicates the ID Authority of an Identifier</para>
    ///   <a href="http://data.press.net/ontology/identifier/authority">pni:authority</a>
    /// </summary>
    let authority = _prefixId.prefix "authority"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : Associates an Identifier to an Identifiable thing</para>
    ///   <para>rdfs:label : Associates an Identifier to an Identifiable thing</para>
    ///   <a href="http://data.press.net/ontology/identifier/hasIdentifier">pni:hasIdentifier</a>
    /// </summary>
    let hasIdentifier = _prefixId.prefix "hasIdentifier"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : Property indicating the literal value of the Identifier</para>
    ///   <para>rdfs:label : the value of the Identifier</para>
    ///   <a href="http://data.press.net/ontology/identifier/value">pni:value</a>
    /// </summary>
    let value = _prefixId.prefix "value"
