namespace http.purl.org.dcx.lrmi_vocabs.interactivityType.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module lrmiinteractivityType =
    let _namespace_iri = Namespace_Iri lrmiinteractivityType |> NamespaceIRI
    /// <summary>
    ///   <para>lrmiinteractivityType:expositive</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-vocabs/interactivityType/expositive">http://purl.org/dcx/lrmi-vocabs/interactivityType/expositive</seealso>
    let expositive = Prefixed_Name(lrmiinteractivityType, "expositive") |> PrefixedName
    /// <summary>
    ///   <para>lrmiinteractivityType:mixed</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-vocabs/interactivityType/mixed">http://purl.org/dcx/lrmi-vocabs/interactivityType/mixed</seealso>
    let mixed = Prefixed_Name(lrmiinteractivityType, "mixed") |> PrefixedName
    /// <summary>
    ///   <para>lrmiinteractivityType:</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-vocabs/interactivityType/">http://purl.org/dcx/lrmi-vocabs/interactivityType/</seealso>
    let _prefix_iri = Prefixed_Name(lrmiinteractivityType, "") |> PrefixedName
    /// <summary>
    ///   <para>lrmiinteractivityType:active</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-vocabs/interactivityType/active">http://purl.org/dcx/lrmi-vocabs/interactivityType/active</seealso>
    let active = Prefixed_Name(lrmiinteractivityType, "active") |> PrefixedName
