#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module oslc_am =
    let _prefixId = PrefixId.fromNamespaceLabel "http://open-services.net/ns/am#" "oslc_am"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : A locally managed resource that describes a link type predicate that might otherwise not be directly resolvable.^^xsd:string</para>
    ///   <para>rdfs:label : LinkType^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/am#LinkType">oslc_am:LinkType</a>
    /// </summary>
    let LinkType = _prefixId.prefix "LinkType"
    /// <summary>
    ///   <para>rdfs:comment : A generic architecture resource.  A resource of this type is likely to be a model or design artifact.^^xsd:string</para>
    ///   <para>rdfs:label : ArchitectureResource^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/am#Resource">oslc_am:Resource</a>
    /// </summary>
    let Resource = _prefixId.prefix "Resource"
