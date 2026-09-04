#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module vs =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.w3.org/2003/06/sw-vocab-status/ns#" "vs"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : more info^^xsd:string</para>
    ///   <para>rdfs:comment : more information about the status etc of a term, typically human oriented^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://www.w3.org/2003/06/sw-vocab-status/ns#moreinfo">vs:moreinfo</a>
    /// </summary>
    let moreinfo = _prefixId.prefix "moreinfo"
    /// <summary>
    ///   <para>rdfs:label : term status^^xsd:string</para>
    ///   <para>rdfs:comment : the status of a vocabulary term, expressed as a short symbolic string; known values include 'unstable','testing', 'stable' and 'archaic'^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://www.w3.org/2003/06/sw-vocab-status/ns#term_status">vs:term_status</a>
    /// </summary>
    let term_status = _prefixId.prefix "term_status"
    /// <summary>
    ///   <para>rdfs:label : user docs^^xsd:string</para>
    ///   <para>rdfs:comment : human-oriented documentation, examples etc for use of this term^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <a href="http://www.w3.org/2003/06/sw-vocab-status/ns#userdocs">vs:userdocs</a>
    /// </summary>
    let userdocs = _prefixId.prefix "userdocs"
