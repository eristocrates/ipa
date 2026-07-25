namespace http.purl.org.ontology.wo.core.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module wo =
    let _namespace_iri = Namespace_Iri wo |> NamespaceIRI
    /// <summary>
    ///   <para>wo:scale</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A scale for the weighting of some relation.</para>
    /// labels<para>has scale</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/core#scale">http://purl.org/ontology/wo/core#scale</seealso>
    let scale = Prefixed_Name(wo, "scale") |> PrefixedName
    /// <summary>
    ///   <para>wo:weight</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The weight on some relation, e.g. a interest in a topic, or of an interest that is valid for a specific period of time or was raised up in a specific period of time.</para>
    /// labels<para>has weight</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/core#weight">http://purl.org/ontology/wo/core#weight</seealso>
    let weight = Prefixed_Name(wo, "weight") |> PrefixedName
    /// <summary>
    ///   <para>wo:min_weight</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>A minimum weight of a scale.</para>
    /// labels<para>has min weight</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/core#min_weight">http://purl.org/ontology/wo/core#min_weight</seealso>
    let min_weight = Prefixed_Name(wo, "min_weight") |> PrefixedName
    /// <summary>
    ///   <para>wo:step_size</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A predefined step size for weight of a specific scale.</para>
    /// labels<para>has step size</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/core#step_size">http://purl.org/ontology/wo/core#step_size</seealso>
    let step_size = Prefixed_Name(wo, "step_size") |> PrefixedName
    /// <summary>
    ///   <para>wo:Scale</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A concept for describing scales for weights.</para>
    /// labels<para>Scale</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/core#Scale">http://purl.org/ontology/wo/core#Scale</seealso>
    let Scale = Prefixed_Name(wo, "Scale") |> PrefixedName
    /// <summary>
    ///   <para>wo:Weight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A weight class to enable timestamped (etc.) weights.</para>
    /// labels<para>Weight</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/core#Weight">http://purl.org/ontology/wo/core#Weight</seealso>
    let Weight = Prefixed_Name(wo, "Weight") |> PrefixedName
    /// <summary>
    ///   <para>wo:weight_value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The specific value of a weight.</para>
    /// labels<para>has weight value</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/core#weight_value">http://purl.org/ontology/wo/core#weight_value</seealso>
    let weight_value = Prefixed_Name(wo, "weight_value") |> PrefixedName
    /// <summary>
    ///   <para>wo:max_weight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A maximum weight of a scale.</para>
    /// labels<para>has max weight</para></remarks>
    /// <seealso href="http://purl.org/ontology/wo/core#max_weight">http://purl.org/ontology/wo/core#max_weight</seealso>
    let max_weight = Prefixed_Name(wo, "max_weight") |> PrefixedName
    /// <summary>
    ///   <para>wo:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/wo/core#">http://purl.org/ontology/wo/core#</seealso>
    let _prefix_iri = Prefixed_Name(wo, "") |> PrefixedName
