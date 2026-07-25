namespace http.www.openarchives.org.ore.terms.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ore =
    let _namespace_iri = Namespace_Iri ore |> NamespaceIRI
    /// <summary>
    ///   <para>ore:AggregatedResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A resource which is included in an Aggregation. Note that asserting that a resource is a member of the class of Aggregated Resources does not imply anything other than that it is aggregated by at least one Aggregation.</para>
    /// labels<para>Aggregated Resource</para></remarks>
    /// <seealso href="http://www.openarchives.org/ore/terms/AggregatedResource">http://www.openarchives.org/ore/terms/AggregatedResource</seealso>
    let AggregatedResource = Prefixed_Name(ore, "AggregatedResource") |> PrefixedName
    /// <summary>
    ///   <para>ore:Proxy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Proxy represents an Aggregated Resource as it exists in a specific Aggregation. All assertions made about an entity are globally true, not only within the context of the Aggregation. As such, in order to make assertions which are only true of a resource as it exists in an Aggregation, a Proxy object is required. For example, one might want to cite an article as it appears in a specific journal, or assign aggregation-specific metadata to a Resource.</para>
    /// labels<para>Proxy</para></remarks>
    /// <seealso href="http://www.openarchives.org/ore/terms/Proxy">http://www.openarchives.org/ore/terms/Proxy</seealso>
    let Proxy = Prefixed_Name(ore, "Proxy") |> PrefixedName
    /// <summary>
    ///   <para>ore:Aggregation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A set of related resources (Aggregated Resources), grouped together such that the set can be treated as a single resource. This is the entity described within the ORE interoperability framework by a Resource Map.</para>
    /// labels<para>Aggregation</para></remarks>
    /// <seealso href="http://www.openarchives.org/ore/terms/Aggregation">http://www.openarchives.org/ore/terms/Aggregation</seealso>
    let Aggregation = Prefixed_Name(ore, "Aggregation") |> PrefixedName
    /// <summary>
    ///   <para>ore:ResourceMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A description of an Aggregation according to the OAI-ORE data model. Resource Maps are serialised to a machine readable format according to the implementation guidelines.</para>
    /// labels<para>Resource Map</para></remarks>
    /// <seealso href="http://www.openarchives.org/ore/terms/ResourceMap">http://www.openarchives.org/ore/terms/ResourceMap</seealso>
    let ResourceMap = Prefixed_Name(ore, "ResourceMap") |> PrefixedName
    /// <summary>
    ///   <para>ore:aggregates</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Aggregations, by definition, aggregate resources. The ore:aggregates relationship expresses that the object resource is a member of the set of Aggregated Resources of the subject (the Aggregation). This relationship between the Aggregation and its Aggregated Resources is thus more specific than a simple part/whole relationship, as expressed by dcterms:hasPart for example.</para>
    /// labels<para>Aggregates</para></remarks>
    /// <seealso href="http://www.openarchives.org/ore/terms/aggregates">http://www.openarchives.org/ore/terms/aggregates</seealso>
    let aggregates = Prefixed_Name(ore, "aggregates") |> PrefixedName
    /// <summary>
    ///   <para>ore:describes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This relationship asserts that the subject (a Resource Map) describes the object (an Aggregation).</para>
    /// labels<para>Describes</para></remarks>
    /// <seealso href="http://www.openarchives.org/ore/terms/describes">http://www.openarchives.org/ore/terms/describes</seealso>
    let describes = Prefixed_Name(ore, "describes") |> PrefixedName
    /// <summary>
    ///   <para>ore:isDescribedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The inverse relationship of ore:describes, in this case the object of the relationship is the Resource Map and the subject is the Aggregation which it describes.</para>
    /// labels<para>Is Described By</para></remarks>
    /// <seealso href="http://www.openarchives.org/ore/terms/isDescribedBy">http://www.openarchives.org/ore/terms/isDescribedBy</seealso>
    let isDescribedBy = Prefixed_Name(ore, "isDescribedBy") |> PrefixedName
    /// <summary>
    ///   <para>ore:isAggregatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The inverse relationship of ore:aggregates, ore:isAggregatedBy asserts that an Aggregated Resource is aggregated by an Aggregation.</para>
    /// labels<para>Is Aggregated By</para></remarks>
    /// <seealso href="http://www.openarchives.org/ore/terms/isAggregatedBy">http://www.openarchives.org/ore/terms/isAggregatedBy</seealso>
    let isAggregatedBy = Prefixed_Name(ore, "isAggregatedBy") |> PrefixedName
    /// <summary>
    ///   <para>ore:proxyFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Proxy objects are used to represent a Resource as it is aggregated in a particular Aggregation. The ore:proxyFor relationship is used to link the proxy to the Aggregated Resource it is a proxy for. The subject of the relationship is a Proxy object, and the object of the relationship is the Aggregated Resource.</para>
    /// labels<para>Proxy For</para></remarks>
    /// <seealso href="http://www.openarchives.org/ore/terms/proxyFor">http://www.openarchives.org/ore/terms/proxyFor</seealso>
    let proxyFor = Prefixed_Name(ore, "proxyFor") |> PrefixedName
    /// <summary>
    ///   <para>ore:lineage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>ore:lineage is a relationship between two Proxy objects, both of which MUST have the same Resource for which they are proxies. The meaning is that the Resource for which the subject of the relationship is a Proxy was discovered in the Aggregation in which the object Proxy's resource is aggregated.</para>
    /// labels<para>Lineage</para></remarks>
    /// <seealso href="http://www.openarchives.org/ore/terms/lineage">http://www.openarchives.org/ore/terms/lineage</seealso>
    let lineage = Prefixed_Name(ore, "lineage") |> PrefixedName
    /// <summary>
    ///   <para>ore:proxyIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Proxy objects must link to the Aggregation in which the resource being proxied is aggregated. The ore:proxyIn relationship is used for this purpose. The subject of the relationship is a Proxy object, and the object of the relationship is the Aggregation.</para>
    /// labels<para>Proxy In</para></remarks>
    /// <seealso href="http://www.openarchives.org/ore/terms/proxyIn">http://www.openarchives.org/ore/terms/proxyIn</seealso>
    let proxyIn = Prefixed_Name(ore, "proxyIn") |> PrefixedName
    /// <summary>
    ///   <para>ore:</para>
    /// </summary>
    /// <remarks>
    ///   <para>The set of terms provided by the OAI ORE initiative</para>
    /// labels<para>The OAI ORE terms vocabulary</para></remarks>
    /// <seealso href="http://www.openarchives.org/ore/terms/">http://www.openarchives.org/ore/terms/</seealso>
    let _prefix_iri = Prefixed_Name(ore, "") |> PrefixedName
    /// <summary>
    ///   <para>ore:similarTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The subject of this relationship MUST be an Aggregation.  This Aggregation should be considered an expression within the ORE context of the object of the relationship, as it is broadly equivalent to the resource. For example, the Aggregation may consist of the resources which, together, make up a journal article which has a DOI assigned to it. The Aggregation is not the article to which the DOI was assigned, but is a representation of it in some manner.</para>
    /// labels<para>Similar To</para></remarks>
    /// <seealso href="http://www.openarchives.org/ore/terms/similarTo">http://www.openarchives.org/ore/terms/similarTo</seealso>
    let similarTo = Prefixed_Name(ore, "similarTo") |> PrefixedName
