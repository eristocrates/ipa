namespace http.open_services.net.ns.core.trs.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ostrs =
    let _namespace_iri = Namespace_Iri ostrs |> NamespaceIRI
    /// <summary>
    ///   <para>ostrs:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"OSLC Core Tracked Resource Set vocabulary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core/trs#">http://open-services.net/ns/core/trs#</seealso>
    let _prefix_iri = Prefixed_Name(ostrs, "") |> PrefixedName
    /// <summary>
    ///   <para>ostrs:Base</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A Base identifies the initial set of resources in a Tracked Resource Set."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Base"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core/trs#Base">http://open-services.net/ns/core/trs#Base</seealso>
    let Base = Prefixed_Name(ostrs, "Base") |> PrefixedName
    /// <summary>
    ///   <para>ostrs:ChangeLog</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A Change Log describes what resources have been created, modified or deleted, and when."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Change Log"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core/trs#ChangeLog">http://open-services.net/ns/core/trs#ChangeLog</seealso>
    let ChangeLog = Prefixed_Name(ostrs, "ChangeLog") |> PrefixedName
    /// <summary>
    ///   <para>ostrs:Creation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents a resource creation or modification change event."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Creation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core/trs#Creation">http://open-services.net/ns/core/trs#Creation</seealso>
    let Creation = Prefixed_Name(ostrs, "Creation") |> PrefixedName
    /// <summary>
    ///   <para>ostrs:Deletion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents a resource deletion change event."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Deletion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core/trs#Deletion">http://open-services.net/ns/core/trs#Deletion</seealso>
    let Deletion = Prefixed_Name(ostrs, "Deletion") |> PrefixedName
    /// <summary>
    ///   <para>ostrs:Modification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents a resource creation or modification change event."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Modification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core/trs#Modification">http://open-services.net/ns/core/trs#Modification</seealso>
    let Modification = Prefixed_Name(ostrs, "Modification") |> PrefixedName
    /// <summary>
    ///   <para>ostrs:TrackedResourceSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A Tracked Resource Set provides a representation of the current state of a Resource Set."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Tracked Resource Set"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core/trs#TrackedResourceSet">http://open-services.net/ns/core/trs#TrackedResourceSet</seealso>
    let TrackedResourceSet = Prefixed_Name(ostrs, "TrackedResourceSet") |> PrefixedName
    /// <summary>
    ///   <para>ostrs:base</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An enumeration of the Resources in the Resource Set."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"base"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core/trs#base">http://open-services.net/ns/core/trs#base</seealso>
    let base_ = Prefixed_Name(ostrs, "base") |> PrefixedName
    /// <summary>
    ///   <para>ostrs:change</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The Change Event entries."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"change"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core/trs#change">http://open-services.net/ns/core/trs#change</seealso>
    let change = Prefixed_Name(ostrs, "change") |> PrefixedName
    /// <summary>
    ///   <para>ostrs:changeLog</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A Change Log providing an order series of incremental adjustments to the Resource Set."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"changeLog"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core/trs#changeLog">http://open-services.net/ns/core/trs#changeLog</seealso>
    let changeLog = Prefixed_Name(ostrs, "changeLog") |> PrefixedName
    /// <summary>
    ///   <para>ostrs:changed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The Resource that has changed."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"changed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core/trs#changed">http://open-services.net/ns/core/trs#changed</seealso>
    let changed = Prefixed_Name(ostrs, "changed") |> PrefixedName
    /// <summary>
    ///   <para>ostrs:cutoffEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The most recent Change Log entry that is accounted for in this Base. When rdf:nil, the Base is an enumeration at the start of time."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"cutoffEvent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core/trs#cutoffEvent">http://open-services.net/ns/core/trs#cutoffEvent</seealso>
    let cutoffEvent = Prefixed_Name(ostrs, "cutoffEvent") |> PrefixedName
    /// <summary>
    ///   <para>ostrs:order</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The sequence in time of the Change Event."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"order"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core/trs#order">http://open-services.net/ns/core/trs#order</seealso>
    let order = Prefixed_Name(ostrs, "order") |> PrefixedName
    /// <summary>
    ///   <para>ostrs:previous</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The continuation of the Change Log, containing the next group of chronologically earlier Change Events."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"previous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core/trs#previous">http://open-services.net/ns/core/trs#previous</seealso>
    let previous = Prefixed_Name(ostrs, "previous") |> PrefixedName
    /// <summary>
    ///   <para>ostrs:trackedResourceSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A Tracked Resource Set."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"trackedResourceSet"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://open-services.net/ns/core/trs#trackedResourceSet">http://open-services.net/ns/core/trs#trackedResourceSet</seealso>
    let trackedResourceSet = Prefixed_Name(ostrs, "trackedResourceSet") |> PrefixedName
