#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module tac =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://ns.bergnet.org/tac/0.1/triple-access-control#" "tac"

    let Authorization = _prefixId.prefix "Authorization"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : A triple filter.</para>
    ///   <para>rdfs:label : Filter</para>
    ///   <a href="http://ns.bergnet.org/tac/0.1/triple-access-control#Filter">tac:Filter</a>
    /// </summary>
    let Filter = _prefixId.prefix "Filter"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:comment : A triple authorization.</para>
    ///   <para>rdfs:label : TripleAuthorization</para>
    ///   <a href="http://ns.bergnet.org/tac/0.1/triple-access-control#TripleAuthorization">tac:TripleAuthorization</a>
    /// </summary>
    let TripleAuthorization = _prefixId.prefix "TripleAuthorization"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:comment : Contains triple authorization information.</para>
    ///   <para>rdfs:label : accesToTriple</para>
    ///   <a href="http://ns.bergnet.org/tac/0.1/triple-access-control#accessToTriple">tac:accessToTriple</a>
    /// </summary>
    let accessToTriple = _prefixId.prefix "accessToTriple"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:comment : Contains sub triple authorization informations.</para>
    ///   <para>rdfs:label : children</para>
    ///   <a href="http://ns.bergnet.org/tac/0.1/triple-access-control#children">tac:children</a>
    /// </summary>
    let children = _prefixId.prefix "children"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:comment : Contains triple filter rules.</para>
    ///   <para>rdfs:label : filter</para>
    ///   <a href="http://ns.bergnet.org/tac/0.1/triple-access-control#filter">tac:filter</a>
    /// </summary>
    let filter = _prefixId.prefix "filter"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:comment : Graph for a triple filter.</para>
    ///   <para>rdfs:label : graph^^xsd:string</para>
    ///   <a href="http://ns.bergnet.org/tac/0.1/triple-access-control#graph">tac:graph</a>
    /// </summary>
    let graph = _prefixId.prefix "graph"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:comment : Access mode is defined per triple authorization.</para>
    ///   <para>rdfs:label : mode</para>
    ///   <a href="http://ns.bergnet.org/tac/0.1/triple-access-control#mode">tac:mode</a>
    /// </summary>
    let mode = _prefixId.prefix "mode"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:comment : Object for a triple filter</para>
    ///   <para>rdfs:label : object</para>
    ///   <a href="http://ns.bergnet.org/tac/0.1/triple-access-control#object">tac:object</a>
    /// </summary>
    let object = _prefixId.prefix "object"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:comment : Predicate for a triple filter.</para>
    ///   <para>rdfs:label : predicate</para>
    ///   <a href="http://ns.bergnet.org/tac/0.1/triple-access-control#predicate">tac:predicate</a>
    /// </summary>
    let predicate = _prefixId.prefix "predicate"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:comment : If this property is true access to the parent triple is only granted if childrens are found.</para>
    ///   <para>rdfs:label : required</para>
    ///   <a href="http://ns.bergnet.org/tac/0.1/triple-access-control#required">tac:required</a>
    /// </summary>
    let required = _prefixId.prefix "required"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:comment : Statement for a triple filter.</para>
    ///   <para>rdfs:label : statement</para>
    ///   <a href="http://ns.bergnet.org/tac/0.1/triple-access-control#statement">tac:statement</a>
    /// </summary>
    let statement = _prefixId.prefix "statement"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:comment : Subject for a triple filter.</para>
    ///   <para>rdfs:label : subject</para>
    ///   <a href="http://ns.bergnet.org/tac/0.1/triple-access-control#subject">tac:subject</a>
    /// </summary>
    let subject = _prefixId.prefix "subject"
