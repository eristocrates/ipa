#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module trspatch =
    let _prefixId = PrefixId.fromNamespaceLabel "http://open-services.net/ns/core/trspatch#" "trspatch"

    /// <summary>
    ///   <para>rdfs:label : afterETag^^xsd:string</para>
    ///   <para>rdfs:comment : HTTP entity tag of resource immediately after this change.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core/trspatch#afterETag">trspatch:afterETag</a>
    /// </summary>
    let afterETag = _prefixId.prefix "afterETag"
    /// <summary>
    ///   <para>rdfs:label : beforeETag^^xsd:string</para>
    ///   <para>rdfs:comment : HTTP entity tag of resource immediately before this change.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core/trspatch#beforeETag">trspatch:beforeETag</a>
    /// </summary>
    let beforeETag = _prefixId.prefix "beforeETag"
    /// <summary>
    ///   <para>rdfs:label : createdFrom^^xsd:string</para>
    ///   <para>rdfs:comment : URI of antecedent resource for trs:Creation Change Events.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core/trspatch#createdFrom">trspatch:createdFrom</a>
    /// </summary>
    let createdFrom = _prefixId.prefix "createdFrom"
    /// <summary>
    ///   <para>rdfs:label : rdfPatch^^xsd:string</para>
    ///   <para>rdfs:comment : Patch directives describing a modification to the resource's RDF representation.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core/trspatch#rdfPatch">trspatch:rdfPatch</a>
    /// </summary>
    let rdfPatch = _prefixId.prefix "rdfPatch"
