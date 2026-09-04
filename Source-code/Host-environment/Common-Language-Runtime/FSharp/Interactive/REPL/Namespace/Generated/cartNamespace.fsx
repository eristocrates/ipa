#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module cart =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/net/cartCoord#" "cart"
    let _namespaceIri = _prefixId.prefix ""
    let Point = _prefixId.prefix "Point"
    let Point_List = _prefixId.prefix "Point_List"
    /// <summary>
    ///   <para>rdfs:label : has Point^^xsd:string</para>
    ///   <a href="http://purl.org/net/cartCoord#hasPlacement">cart:hasPlacement</a>
    /// </summary>
    let hasPlacement = _prefixId.prefix "hasPlacement"
    /// <summary>
    ///   <para>rdfs:label : has Point^^xsd:string</para>
    ///   <a href="http://purl.org/net/cartCoord#hasPoint">cart:hasPoint</a>
    /// </summary>
    let hasPoint = _prefixId.prefix "hasPoint"
    /// <summary>
    ///   <para>rdfs:label : X Coordinate^^xsd:string</para>
    ///   <a href="http://purl.org/net/cartCoord#xcoord">cart:xcoord</a>
    /// </summary>
    let xcoord = _prefixId.prefix "xcoord"
    /// <summary>
    ///   <para>rdfs:label : Y Coordinate^^xsd:string</para>
    ///   <a href="http://purl.org/net/cartCoord#ycoord">cart:ycoord</a>
    /// </summary>
    let ycoord = _prefixId.prefix "ycoord"
    /// <summary>
    ///   <para>rdfs:label : Z Coordinate^^xsd:string</para>
    ///   <a href="http://purl.org/net/cartCoord#zcoord">cart:zcoord</a>
    /// </summary>
    let zcoord = _prefixId.prefix "zcoord"
