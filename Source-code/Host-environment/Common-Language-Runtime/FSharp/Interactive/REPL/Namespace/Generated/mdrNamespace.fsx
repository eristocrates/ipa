#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module mdr =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://semanticturkey.uniroma2.it/ns/mdr#" "mdr"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : a method to dereference the identifiers defined by some dataset</para>
    ///   <para>rdfs:label : dereferenciation system</para>
    ///   <a href="http://semanticturkey.uniroma2.it/ns/mdr#DereferenciationSystem">mdr:DereferenciationSystem</a>
    /// </summary>
    let DereferenciationSystem = _prefixId.prefix "DereferenciationSystem"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : a limitation of some SPARQL endpoint. This class is an extension point for recording and subsequently reacting in an application-specific manner to any perceived limitation of an endpoint. The focus is on limitations that cannot objectively be defined a-priori, as they rather depend on a number of boundary conditions, such as the task, the underlying access technology and even the specific queries run to perform the task. Such limitations can then be defined in application-specific ontologies reusing this vocabulary</para>
    ///   <para>rdfs:label : sparql endpoint limitation</para>
    ///   <a href="http://semanticturkey.uniroma2.it/ns/mdr#SparqlEndpointLimitation">mdr:SparqlEndpointLimitation</a>
    /// </summary>
    let SparqlEndpointLimitation = _prefixId.prefix "SparqlEndpointLimitation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : relates a void:Dataset to a resource describing a method to dereference the identifiers defined by that dataset. Currently only two instances: :standardDereferenciation and :noDereferenciation are available, however this will be extended soon to account for versioning and other URI-transformation needs</para>
    ///   <para>rdfs:label : dereferenciation system</para>
    ///   <a href="http://semanticturkey.uniroma2.it/ns/mdr#dereferenciationSystem">mdr:dereferenciationSystem</a>
    /// </summary>
    let dereferenciationSystem = _prefixId.prefix "dereferenciationSystem"
    let noDereferenciation = _prefixId.prefix "noDereferenciation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : relates a SPARQL endpoint to a resource describing some limitation of that endpoint</para>
    ///   <para>rdfs:label : sparql endpoint limitation</para>
    ///   <a href="http://semanticturkey.uniroma2.it/ns/mdr#sparqlEndpointLimitation">mdr:sparqlEndpointLimitation</a>
    /// </summary>
    let sparqlEndpointLimitation = _prefixId.prefix "sparqlEndpointLimitation"
    let standardDereferenciation = _prefixId.prefix "standardDereferenciation"
