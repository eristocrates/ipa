#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ont =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/net/ns/ontology-annot#" "ont"

    /// <summary>
    ///   <para>rdfs:label : created^^xsd:string</para>
    ///   <a href="http://purl.org/net/ns/ontology-annot#created">ont:created</a>
    /// </summary>
    let created = _prefixId.prefix "created"
    /// <summary>
    ///   <para>rdfs:label : creator^^xsd:string</para>
    ///   <a href="http://purl.org/net/ns/ontology-annot#creator">ont:creator</a>
    /// </summary>
    let creator = _prefixId.prefix "creator"
    /// <summary>
    ///   <para>rdfs:label : deprecated by^^xsd:string</para>
    ///   <a href="http://purl.org/net/ns/ontology-annot#deprecatedBy">ont:deprecatedBy</a>
    /// </summary>
    let deprecatedBy = _prefixId.prefix "deprecatedBy"
    /// <summary>
    ///   <para>rdfs:label : description^^xsd:string</para>
    ///   <a href="http://purl.org/net/ns/ontology-annot#description">ont:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:label : modified^^xsd:string</para>
    ///   <a href="http://purl.org/net/ns/ontology-annot#modified">ont:modified</a>
    /// </summary>
    let modified = _prefixId.prefix "modified"
    /// <summary>
    ///   <para>rdfs:label : relation^^xsd:string</para>
    ///   <a href="http://purl.org/net/ns/ontology-annot#relation">ont:relation</a>
    /// </summary>
    let relation = _prefixId.prefix "relation"
    /// <summary>
    ///   <para>rdfs:label : see other^^xsd:string</para>
    ///   <a href="http://purl.org/net/ns/ontology-annot#seeOther">ont:seeOther</a>
    /// </summary>
    let seeOther = _prefixId.prefix "seeOther"
    /// <summary>
    ///   <para>rdfs:label : title^^xsd:string</para>
    ///   <a href="http://purl.org/net/ns/ontology-annot#title">ont:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
