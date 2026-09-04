#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ore =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.openarchives.org/ore/terms/" "ore"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : A resource which is included in an Aggregation. Note that asserting that a resource is a member of the class of Aggregated Resources does not imply anything other than that it is aggregated by at least one Aggregation.^^xsd:string</para>
    ///   <para>rdfs:label : Aggregated Resource^^xsd:string</para>
    ///   <a href="http://www.openarchives.org/ore/terms/AggregatedResource">ore:AggregatedResource</a>
    /// </summary>
    let AggregatedResource = _prefixId.prefix "AggregatedResource"
    /// <summary>
    ///   <para>rdfs:comment : A set of related resources (Aggregated Resources), grouped together such that the set can be treated as a single resource. This is the entity described within the ORE interoperability framework by a Resource Map.^^xsd:string</para>
    ///   <para>rdfs:label : Aggregation^^xsd:string</para>
    ///   <a href="http://www.openarchives.org/ore/terms/Aggregation">ore:Aggregation</a>
    /// </summary>
    let Aggregation = _prefixId.prefix "Aggregation"
    /// <summary>
    ///   <para>rdfs:comment : A Proxy represents an Aggregated Resource as it exists in a specific Aggregation. All assertions made about an entity are globally true, not only within the context of the Aggregation. As such, in order to make assertions which are only true of a resource as it exists in an Aggregation, a Proxy object is required. For example, one might want to cite an article as it appears in a specific journal, or assign aggregation-specific metadata to a Resource.^^xsd:string</para>
    ///   <para>rdfs:label : Proxy^^xsd:string</para>
    ///   <a href="http://www.openarchives.org/ore/terms/Proxy">ore:Proxy</a>
    /// </summary>
    let Proxy = _prefixId.prefix "Proxy"
    /// <summary>
    ///   <para>rdfs:comment : A description of an Aggregation according to the OAI-ORE data model. Resource Maps are serialised to a machine readable format according to the implementation guidelines.^^xsd:string</para>
    ///   <para>rdfs:label : Resource Map^^xsd:string</para>
    ///   <a href="http://www.openarchives.org/ore/terms/ResourceMap">ore:ResourceMap</a>
    /// </summary>
    let ResourceMap = _prefixId.prefix "ResourceMap"
    /// <summary>
    ///   <para>rdfs:comment : Aggregations, by definition, aggregate resources. The ore:aggregates relationship expresses that the object resource is a member of the set of Aggregated Resources of the subject (the Aggregation). This relationship between the Aggregation and its Aggregated Resources is thus more specific than a simple part/whole relationship, as expressed by dcterms:hasPart for example.^^xsd:string</para>
    ///   <para>rdfs:label : Aggregates^^xsd:string</para>
    ///   <a href="http://www.openarchives.org/ore/terms/aggregates">ore:aggregates</a>
    /// </summary>
    let aggregates = _prefixId.prefix "aggregates"
    /// <summary>
    ///   <para>rdfs:comment : This relationship asserts that the subject (a Resource Map) describes the object (an Aggregation).^^xsd:string</para>
    ///   <para>rdfs:label : Describes^^xsd:string</para>
    ///   <a href="http://www.openarchives.org/ore/terms/describes">ore:describes</a>
    /// </summary>
    let describes = _prefixId.prefix "describes"
    /// <summary>
    ///   <para>rdfs:comment : The inverse relationship of ore:aggregates, ore:isAggregatedBy asserts that an Aggregated Resource is aggregated by an Aggregation.^^xsd:string</para>
    ///   <para>rdfs:label : Is Aggregated By^^xsd:string</para>
    ///   <a href="http://www.openarchives.org/ore/terms/isAggregatedBy">ore:isAggregatedBy</a>
    /// </summary>
    let isAggregatedBy = _prefixId.prefix "isAggregatedBy"
    /// <summary>
    ///   <para>rdfs:comment : The inverse relationship of ore:describes, in this case the object of the relationship is the Resource Map and the subject is the Aggregation which it describes.^^xsd:string</para>
    ///   <para>rdfs:label : Is Described By^^xsd:string</para>
    ///   <a href="http://www.openarchives.org/ore/terms/isDescribedBy">ore:isDescribedBy</a>
    /// </summary>
    let isDescribedBy = _prefixId.prefix "isDescribedBy"
    /// <summary>
    ///   <para>rdfs:comment : ore:lineage is a relationship between two Proxy objects, both of which MUST have the same Resource for which they are proxies. The meaning is that the Resource for which the subject of the relationship is a Proxy was discovered in the Aggregation in which the object Proxy's resource is aggregated.^^xsd:string</para>
    ///   <para>rdfs:label : Lineage^^xsd:string</para>
    ///   <a href="http://www.openarchives.org/ore/terms/lineage">ore:lineage</a>
    /// </summary>
    let lineage = _prefixId.prefix "lineage"
    /// <summary>
    ///   <para>rdfs:comment : Proxy objects are used to represent a Resource as it is aggregated in a particular Aggregation. The ore:proxyFor relationship is used to link the proxy to the Aggregated Resource it is a proxy for. The subject of the relationship is a Proxy object, and the object of the relationship is the Aggregated Resource.^^xsd:string</para>
    ///   <para>rdfs:label : Proxy For^^xsd:string</para>
    ///   <a href="http://www.openarchives.org/ore/terms/proxyFor">ore:proxyFor</a>
    /// </summary>
    let proxyFor = _prefixId.prefix "proxyFor"
    /// <summary>
    ///   <para>rdfs:comment : Proxy objects must link to the Aggregation in which the resource being proxied is aggregated. The ore:proxyIn relationship is used for this purpose. The subject of the relationship is a Proxy object, and the object of the relationship is the Aggregation.^^xsd:string</para>
    ///   <para>rdfs:label : Proxy In^^xsd:string</para>
    ///   <a href="http://www.openarchives.org/ore/terms/proxyIn">ore:proxyIn</a>
    /// </summary>
    let proxyIn = _prefixId.prefix "proxyIn"
    /// <summary>
    ///   <para>rdfs:comment : The subject of this relationship MUST be an Aggregation.  This Aggregation should be considered an expression within the ORE context of the object of the relationship, as it is broadly equivalent to the resource. For example, the Aggregation may consist of the resources which, together, make up a journal article which has a DOI assigned to it. The Aggregation is not the article to which the DOI was assigned, but is a representation of it in some manner.^^xsd:string</para>
    ///   <para>rdfs:label : Similar To^^xsd:string</para>
    ///   <a href="http://www.openarchives.org/ore/terms/similarTo">ore:similarTo</a>
    /// </summary>
    let similarTo = _prefixId.prefix "similarTo"
