#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module olo =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/ontology/olo/core#" "olo"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Ordered List</para>
    ///   <para>rdfs:comment : An ordered list with a given length an indexed items.</para>
    ///   <a href="http://purl.org/ontology/olo/core#OrderedList">olo:OrderedList</a>
    /// </summary>
    let OrderedList = _prefixId.prefix "OrderedList"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:comment : A slot in an ordered list with a fixed index.</para>
    ///   <para>rdfs:label : Slot</para>
    ///   <a href="http://purl.org/ontology/olo/core#Slot">olo:Slot</a>
    /// </summary>
    let Slot = _prefixId.prefix "Slot"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : has index</para>
    ///   <para>rdfs:comment : An index of a slot in an ordered list.</para>
    ///   <a href="http://purl.org/ontology/olo/core#index">olo:index</a>
    /// </summary>
    let index = _prefixId.prefix "index"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : has item</para>
    ///   <para>rdfs:comment : An item of a slot in an ordered list.</para>
    ///   <a href="http://purl.org/ontology/olo/core#item">olo:item</a>
    /// </summary>
    let item = _prefixId.prefix "item"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : has length</para>
    ///   <para>rdfs:comment : The length of an ordered list.</para>
    ///   <a href="http://purl.org/ontology/olo/core#length">olo:length</a>
    /// </summary>
    let length = _prefixId.prefix "length"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has next</para>
    ///   <para>rdfs:comment : Associates the next slot in an ordered list.</para>
    ///   <a href="http://purl.org/ontology/olo/core#next">olo:next</a>
    /// </summary>
    let next = _prefixId.prefix "next"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has ordered list</para>
    ///   <para>rdfs:comment : An ordered list of an slot.</para>
    ///   <a href="http://purl.org/ontology/olo/core#ordered_list">olo:ordered_list</a>
    /// </summary>
    let ordered_list = _prefixId.prefix "ordered_list"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has previous</para>
    ///   <para>rdfs:comment : Associates the previous slot in an ordered list</para>
    ///   <a href="http://purl.org/ontology/olo/core#previous">olo:previous</a>
    /// </summary>
    let previous = _prefixId.prefix "previous"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : has slot</para>
    ///   <para>rdfs:comment : A slot in an ordered list.</para>
    ///   <a href="http://purl.org/ontology/olo/core#slot">olo:slot</a>
    /// </summary>
    let slot = _prefixId.prefix "slot"
