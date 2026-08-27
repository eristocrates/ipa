namespace https.w3id.org.multidimensional_interface.ontology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module multont =
    let _namespace_iri = Namespace_Iri multont |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:multidimensional-interface/ontology#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/multidimensional-interface/ontology#">https://w3id.org/multidimensional-interface/ontology#</seealso>
    let _prefix_iri = Prefixed_Name(multont, "") |> PrefixedName
    /// <summary>
    ///   <para>w3id:multidimensional-interface/ontology#RangeFragment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A Linked Data Fragment that has an interval as selector, which apply to dimensional resources at one of its n dimensions."</para>
    /// labels<para>"RangeFragment"</para></remarks>
    /// <seealso href="https://w3id.org/multidimensional-interface/ontology#RangeFragment">https://w3id.org/multidimensional-interface/ontology#RangeFragment</seealso>
    let RangeFragment = Prefixed_Name(multont, "RangeFragment") |> PrefixedName
    /// <summary>
    ///   <para>w3id:multidimensional-interface/ontology#RangeGate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A Linked Data interface through which Range Fragments can be selected by interval. This interface selects all Range Fragments whose interval overlap with the Range Gate’s interval."</para>
    /// labels<para>"RangeGate"</para></remarks>
    /// <seealso href="https://w3id.org/multidimensional-interface/ontology#RangeGate">https://w3id.org/multidimensional-interface/ontology#RangeGate</seealso>
    let RangeGate = Prefixed_Name(multont, "RangeGate") |> PrefixedName
    /// <summary>
    ///   <para>w3id:multidimensional-interface/ontology#final</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The upper bound of an interval, excluding this value."</para>
    /// labels<para>"interval final"</para></remarks>
    /// <seealso href="https://w3id.org/multidimensional-interface/ontology#final">https://w3id.org/multidimensional-interface/ontology#final</seealso>
    let final = Prefixed_Name(multont, "final") |> PrefixedName
    /// <summary>
    ///   <para>w3id:multidimensional-interface/ontology#hasRangeGate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A link to the Range Gate of a Multidimensional Index of a datasource."</para>
    /// labels<para>"has range gate"</para></remarks>
    /// <seealso href="https://w3id.org/multidimensional-interface/ontology#hasRangeGate">https://w3id.org/multidimensional-interface/ontology#hasRangeGate</seealso>
    let hasRangeGate = Prefixed_Name(multont, "hasRangeGate") |> PrefixedName
    /// <summary>
    ///   <para>w3id:multidimensional-interface/ontology#initial</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The lower bound of an interval, including this value."</para>
    /// labels<para>"interval initial"</para></remarks>
    /// <seealso href="https://w3id.org/multidimensional-interface/ontology#initial">https://w3id.org/multidimensional-interface/ontology#initial</seealso>
    let initial = Prefixed_Name(multont, "initial") |> PrefixedName
