namespace https.www.omg.org.spec.Commons.Quantities.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cmns_q =
    let _namespace_iri = Namespace_Iri cmns_q |> NamespaceIRI
    /// <summary>
    ///   <para>cmns-q:hasLowerBound</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Quantities/hasLowerBound">https://www.omg.org/spec/Commons/Quantities/hasLowerBound</seealso>
    let hasLowerBound = Prefixed_Name(cmns_q, "hasLowerBound") |> PrefixedName
    /// <summary>
    ///   <para>cmns-q:hasNumericValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Quantities/hasNumericValue">https://www.omg.org/spec/Commons/Quantities/hasNumericValue</seealso>
    let hasNumericValue = Prefixed_Name(cmns_q, "hasNumericValue") |> PrefixedName
    /// <summary>
    ///   <para>cmns-q:hasQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Quantities/hasQuantity">https://www.omg.org/spec/Commons/Quantities/hasQuantity</seealso>
    let hasQuantity = Prefixed_Name(cmns_q, "hasQuantity") |> PrefixedName
    /// <summary>
    ///   <para>cmns-q:hasUpperBound</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/Quantities/hasUpperBound">https://www.omg.org/spec/Commons/Quantities/hasUpperBound</seealso>
    let hasUpperBound = Prefixed_Name(cmns_q, "hasUpperBound") |> PrefixedName
