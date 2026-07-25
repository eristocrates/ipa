namespace http.tracker.api.gnome.org.ontology.v3.nrl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tnrl =
    let _namespace_iri = Namespace_Iri tnrl |> NamespaceIRI
    /// <summary>
    ///   <para>tnrl:prefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This is a Tracker extension</para>
    /// labels<para>Base prefix of the subject namespace</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nrl#prefix">http://tracker.api.gnome.org/ontology/v3/nrl#prefix</seealso>
    let prefix = Prefixed_Name(tnrl, "prefix") |> PrefixedName
    /// <summary>
    ///   <para>tnrl:lastModified</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>last modification date. This is a Tracker extension</para>
    /// labels<para>lastModified</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nrl#lastModified">http://tracker.api.gnome.org/ontology/v3/nrl#lastModified</seealso>
    let lastModified = Prefixed_Name(tnrl, "lastModified") |> PrefixedName
    /// <summary>
    ///   <para>tnrl:deprecated</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>If this property is assigned, the subject class, property, or resource, is deprecated and should not be used in production systems any longer. It may be removed without further notice. This property is a Tracker extension</para>
    /// labels<para>deprecated</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nrl#deprecated">http://tracker.api.gnome.org/ontology/v3/nrl#deprecated</seealso>
    let deprecated = Prefixed_Name(tnrl, "deprecated") |> PrefixedName
    /// <summary>
    ///   <para>tnrl:fulltextIndexed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether the property is full-text indexed. This is a Tracker extension</para>
    /// labels<para>Full-text indexed</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nrl#fulltextIndexed">http://tracker.api.gnome.org/ontology/v3/nrl#fulltextIndexed</seealso>
    let fulltextIndexed = Prefixed_Name(tnrl, "fulltextIndexed") |> PrefixedName

    /// <summary>
    ///   <para>tnrl:propertySpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Link to upstream specification for an ontology property. This is a Tracker extension</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nrl#propertySpecification">http://tracker.api.gnome.org/ontology/v3/nrl#propertySpecification</seealso>
    let propertySpecification =
        Prefixed_Name(tnrl, "propertySpecification") |> PrefixedName

    /// <summary>
    ///   <para>tnrl:Namespace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Specifies a namespace. This is a Tracker extension</para>
    /// labels<para>Namespace</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nrl#Namespace">http://tracker.api.gnome.org/ontology/v3/nrl#Namespace</seealso>
    let Namespace = Prefixed_Name(tnrl, "Namespace") |> PrefixedName
    /// <summary>
    ///   <para>tnrl:Ontology</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An ontology</para>
    /// labels<para>Ontology</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nrl#Ontology">http://tracker.api.gnome.org/ontology/v3/nrl#Ontology</seealso>
    let Ontology = Prefixed_Name(tnrl, "Ontology") |> PrefixedName
    /// <summary>
    ///   <para>tnrl:indexed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether a property has an index. This is a Tracker extension</para>
    /// labels<para>Indexed</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nrl#indexed">http://tracker.api.gnome.org/ontology/v3/nrl#indexed</seealso>
    let indexed = Prefixed_Name(tnrl, "indexed") |> PrefixedName
    /// <summary>
    ///   <para>tnrl:classSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Link to upstream specification for an ontology class. This is a Tracker extension</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nrl#classSpecification">http://tracker.api.gnome.org/ontology/v3/nrl#classSpecification</seealso>
    let classSpecification = Prefixed_Name(tnrl, "classSpecification") |> PrefixedName
    /// <summary>
    ///   <para>tnrl:maxCardinality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies a maximum value cardinality for a specific property</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nrl#maxCardinality">http://tracker.api.gnome.org/ontology/v3/nrl#maxCardinality</seealso>
    let maxCardinality = Prefixed_Name(tnrl, "maxCardinality") |> PrefixedName
    /// <summary>
    ///   <para>tnrl:domainIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Property is a domain index for the subject class. This is a Tracker extension</para>
    /// labels<para>Domain Index</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nrl#domainIndex">http://tracker.api.gnome.org/ontology/v3/nrl#domainIndex</seealso>
    let domainIndex = Prefixed_Name(tnrl, "domainIndex") |> PrefixedName
    /// <summary>
    ///   <para>tnrl:modified</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Modification sequence number. This is a Tracker extension</para>
    /// labels<para>Modification sequence</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nrl#modified">http://tracker.api.gnome.org/ontology/v3/nrl#modified</seealso>
    let modified = Prefixed_Name(tnrl, "modified") |> PrefixedName
    /// <summary>
    ///   <para>tnrl:notify</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether resources of this class emits notifications on changes. This is a Tracker extension</para>
    /// labels<para>Event notification</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nrl#notify">http://tracker.api.gnome.org/ontology/v3/nrl#notify</seealso>
    let notify = Prefixed_Name(tnrl, "notify") |> PrefixedName
    /// <summary>
    ///   <para>tnrl:secondaryIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether subject and object properties share an index. This is a Tracker extension</para>
    /// labels<para>Secondary indexed</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nrl#secondaryIndex">http://tracker.api.gnome.org/ontology/v3/nrl#secondaryIndex</seealso>
    let secondaryIndex = Prefixed_Name(tnrl, "secondaryIndex") |> PrefixedName
    /// <summary>
    ///   <para>tnrl:weight</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Property weight on full-text search relevance. This is a Tracker extension</para>
    /// labels<para>Full-text index weight</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nrl#weight">http://tracker.api.gnome.org/ontology/v3/nrl#weight</seealso>
    let weight = Prefixed_Name(tnrl, "weight") |> PrefixedName
    /// <summary>
    ///   <para>tnrl:</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnrl:Ontology</para>
    ///   <para>tnrl:Namespace</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nrl#">http://tracker.api.gnome.org/ontology/v3/nrl#</seealso>
    let _prefix_iri = Prefixed_Name(tnrl, "") |> PrefixedName

    /// <summary>
    ///   <para>tnrl:InverseFunctionalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A marker class to identify inverse functional properties</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nrl#InverseFunctionalProperty">http://tracker.api.gnome.org/ontology/v3/nrl#InverseFunctionalProperty</seealso>
    let InverseFunctionalProperty =
        Prefixed_Name(tnrl, "InverseFunctionalProperty") |> PrefixedName

    /// <summary>
    ///   <para>tnrl:added</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Time of insertion of the resource. This is a Tracker extension</para>
    /// labels<para>Insertion time</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/nrl#added">http://tracker.api.gnome.org/ontology/v3/nrl#added</seealso>
    let added = Prefixed_Name(tnrl, "added") |> PrefixedName
