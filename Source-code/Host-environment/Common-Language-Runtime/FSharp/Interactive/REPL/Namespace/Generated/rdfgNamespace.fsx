#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module rdfg =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.w3.org/2004/03/trix/rdfg-1/" "rdfg"

    /// <summary>
    ///   <para>rdfs:label : Graph^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// An RDF graph (with intensional semantics).
    ///       ^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/03/trix/rdfg-1/Graph">rdfg:Graph</a>
    /// </summary>
    let Graph = _prefixId.prefix "Graph"
    /// <summary>
    ///   <para>rdfs:label : equivalent graph^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// The graphs associated with the subject and object are equivalent.
    ///       ^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/03/trix/rdfg-1/equivalentGraph">rdfg:equivalentGraph</a>
    /// </summary>
    let equivalentGraph = _prefixId.prefix "equivalentGraph"
    /// <summary>
    ///   <para>rdfs:label : subgraph of^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// The graph associated with the subject is a subgraph of a graph equivalent
    /// to that associated with the object.
    ///       ^^xsd:string</para>
    ///   <a href="http://www.w3.org/2004/03/trix/rdfg-1/subGraphOf">rdfg:subGraphOf</a>
    /// </summary>
    let subGraphOf = _prefixId.prefix "subGraphOf"
