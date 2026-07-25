namespace http.tracker.api.gnome.org.ontology.v3.nao.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tnao =
    let _namespace_iri = Namespace_Iri tnao |> NamespaceIRI
    /// <summary>
    ///   <para>tnao:</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnrl:Ontology</para>
    ///   <para>tnrl:Namespace</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nao#">http://tracker.api.gnome.org/ontology/v3/nao#</seealso>
    let _prefix_iri = Prefixed_Name(tnao, "") |> PrefixedName
    /// <summary>
    ///   <para>tnao:Tag</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Represents a generic tag</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nao#Tag">http://tracker.api.gnome.org/ontology/v3/nao#Tag</seealso>
    let Tag = Prefixed_Name(tnao, "Tag") |> PrefixedName
    /// <summary>
    ///   <para>tnao:deprecated</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>If this property is assigned, the subject class, property, or resource, is deprecated and should not be used in production systems any longer. It may be removed without further notice.</para>
    /// labels<para>deprecated</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nao#deprecated">http://tracker.api.gnome.org/ontology/v3/nao#deprecated</seealso>
    let deprecated = Prefixed_Name(tnao, "deprecated") |> PrefixedName
    /// <summary>
    ///   <para>tnao:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>In the context of the social semantic desktop the textual annotation provided via rdfs:comment is meant for technical users, the textual annotation here is aimed at average users and is meant to be used to define custom descriptions of resources on the desktop</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nao#description">http://tracker.api.gnome.org/ontology/v3/nao#description</seealso>
    let description = Prefixed_Name(tnao, "description") |> PrefixedName
    /// <summary>
    ///   <para>tnao:hasTag</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Defines an existing tag for a resource</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nao#hasTag">http://tracker.api.gnome.org/ontology/v3/nao#hasTag</seealso>
    let hasTag = Prefixed_Name(tnao, "hasTag") |> PrefixedName
    /// <summary>
    ///   <para>tnao:identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Defines a generic identifier for a resource</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nao#identifier">http://tracker.api.gnome.org/ontology/v3/nao#identifier</seealso>
    let identifier = Prefixed_Name(tnao, "identifier") |> PrefixedName
    /// <summary>
    ///   <para>tnao:isRelated</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property defines a symmetric relation between any two resources. In order for this property to be used legally, the relationship must be symmetric.</para>
    /// labels<para>Is related</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nao#isRelated">http://tracker.api.gnome.org/ontology/v3/nao#isRelated</seealso>
    let isRelated = Prefixed_Name(tnao, "isRelated") |> PrefixedName
    /// <summary>
    ///   <para>tnao:lastModified</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>last modification date</para>
    /// labels<para>lastModified</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nao#lastModified">http://tracker.api.gnome.org/ontology/v3/nao#lastModified</seealso>
    let lastModified = Prefixed_Name(tnao, "lastModified") |> PrefixedName
    /// <summary>
    ///   <para>tnao:numericRating</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Annotation for a resource in the form of a numeric rating (float value), allowed values are between 1 and 10 whereas 0 is interpreted as not set</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nao#numericRating">http://tracker.api.gnome.org/ontology/v3/nao#numericRating</seealso>
    let numericRating = Prefixed_Name(tnao, "numericRating") |> PrefixedName
    /// <summary>
    ///   <para>tnao:prefLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A preferred label for a resource</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nao#prefLabel">http://tracker.api.gnome.org/ontology/v3/nao#prefLabel</seealso>
    let prefLabel = Prefixed_Name(tnao, "prefLabel") |> PrefixedName
