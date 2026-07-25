namespace http.purl.org.dcx.lrmi_vocabs.alignmentType.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module lrmialignmentType =
    let _namespace_iri = Namespace_Iri lrmialignmentType |> NamespaceIRI
    /// <summary>
    ///   <para>lrmialignmentType:</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-vocabs/alignmentType/">http://purl.org/dcx/lrmi-vocabs/alignmentType/</seealso>
    let _prefix_iri = Prefixed_Name(lrmialignmentType, "") |> PrefixedName

    /// <summary>
    ///   <para>lrmialignmentType:complexityLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-vocabs/alignmentType/complexityLevel">http://purl.org/dcx/lrmi-vocabs/alignmentType/complexityLevel</seealso>
    let complexityLevel =
        Prefixed_Name(lrmialignmentType, "complexityLevel") |> PrefixedName

    /// <summary>
    ///   <para>lrmialignmentType:prerequisite</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-vocabs/alignmentType/prerequisite">http://purl.org/dcx/lrmi-vocabs/alignmentType/prerequisite</seealso>
    let prerequisite = Prefixed_Name(lrmialignmentType, "prerequisite") |> PrefixedName

    /// <summary>
    ///   <para>lrmialignmentType:educationalLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-vocabs/alignmentType/educationalLevel">http://purl.org/dcx/lrmi-vocabs/alignmentType/educationalLevel</seealso>
    let educationalLevel =
        Prefixed_Name(lrmialignmentType, "educationalLevel") |> PrefixedName

    /// <summary>
    ///   <para>lrmialignmentType:assesses</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-vocabs/alignmentType/assesses">http://purl.org/dcx/lrmi-vocabs/alignmentType/assesses</seealso>
    let assesses = Prefixed_Name(lrmialignmentType, "assesses") |> PrefixedName

    /// <summary>
    ///   <para>lrmialignmentType:educationalSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-vocabs/alignmentType/educationalSubject">http://purl.org/dcx/lrmi-vocabs/alignmentType/educationalSubject</seealso>
    let educationalSubject =
        Prefixed_Name(lrmialignmentType, "educationalSubject") |> PrefixedName

    /// <summary>
    ///   <para>lrmialignmentType:readingLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-vocabs/alignmentType/readingLevel">http://purl.org/dcx/lrmi-vocabs/alignmentType/readingLevel</seealso>
    let readingLevel = Prefixed_Name(lrmialignmentType, "readingLevel") |> PrefixedName
    /// <summary>
    ///   <para>lrmialignmentType:teaches</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-vocabs/alignmentType/teaches">http://purl.org/dcx/lrmi-vocabs/alignmentType/teaches</seealso>
    let teaches = Prefixed_Name(lrmialignmentType, "teaches") |> PrefixedName
