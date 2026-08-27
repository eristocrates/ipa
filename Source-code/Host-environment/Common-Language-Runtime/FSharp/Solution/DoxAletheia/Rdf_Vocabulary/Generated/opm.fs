namespace https.w3id.org.opm.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module opm =
    let _namespace_iri = Namespace_Iri opm |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:opm#Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/opm#Property">https://w3id.org/opm#Property</seealso>
    let Property = Prefixed_Name(opm, "Property") |> PrefixedName
    /// <summary>
    ///   <para>w3id:opm#PropertyState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/opm#PropertyState">https://w3id.org/opm#PropertyState</seealso>
    let PropertyState = Prefixed_Name(opm, "PropertyState") |> PrefixedName
    /// <summary>
    ///   <para>w3id:opm#hasPropertyState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/opm#hasPropertyState">https://w3id.org/opm#hasPropertyState</seealso>
    let hasPropertyState = Prefixed_Name(opm, "hasPropertyState") |> PrefixedName
