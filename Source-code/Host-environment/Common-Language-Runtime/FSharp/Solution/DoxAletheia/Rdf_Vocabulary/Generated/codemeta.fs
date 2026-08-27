namespace https.codemeta.github.io.terms.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module codemeta =
    let _namespace_iri = Namespace_Iri codemeta |> NamespaceIRI
    /// <summary>
    ///   <para>codemeta:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://codemeta.github.io/terms/">https://codemeta.github.io/terms/</seealso>
    let _prefix_iri = Prefixed_Name(codemeta, "") |> PrefixedName
    /// <summary>
    ///   <para>codemeta:funding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://codemeta.github.io/terms/funding">https://codemeta.github.io/terms/funding</seealso>
    let funding = Prefixed_Name(codemeta, "funding") |> PrefixedName
    /// <summary>
    ///   <para>codemeta:issueTracker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://codemeta.github.io/terms/issueTracker">https://codemeta.github.io/terms/issueTracker</seealso>
    let issueTracker = Prefixed_Name(codemeta, "issueTracker") |> PrefixedName
    /// <summary>
    ///   <para>codemeta:readme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://codemeta.github.io/terms/readme">https://codemeta.github.io/terms/readme</seealso>
    let readme = Prefixed_Name(codemeta, "readme") |> PrefixedName

    /// <summary>
    ///   <para>codemeta:referencePublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://codemeta.github.io/terms/referencePublication">https://codemeta.github.io/terms/referencePublication</seealso>
    let referencePublication =
        Prefixed_Name(codemeta, "referencePublication") |> PrefixedName
