namespace http.purl.org.dcx.lrmi_vocabs.educationalUse.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module lrmieducationalUse =
    let _namespace_iri = Namespace_Iri lrmieducationalUse |> NamespaceIRI
    /// <summary>
    ///   <para>lrmieducationalUse:</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-vocabs/educationalUse/">http://purl.org/dcx/lrmi-vocabs/educationalUse/</seealso>
    let _prefix_iri = Prefixed_Name(lrmieducationalUse, "") |> PrefixedName
    /// <summary>
    ///   <para>lrmieducationalUse:assessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-vocabs/educationalUse/assessment">http://purl.org/dcx/lrmi-vocabs/educationalUse/assessment</seealso>
    let assessment = Prefixed_Name(lrmieducationalUse, "assessment") |> PrefixedName
    /// <summary>
    ///   <para>lrmieducationalUse:instruction</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-vocabs/educationalUse/instruction">http://purl.org/dcx/lrmi-vocabs/educationalUse/instruction</seealso>
    let instruction = Prefixed_Name(lrmieducationalUse, "instruction") |> PrefixedName

    /// <summary>
    ///   <para>lrmieducationalUse:professionalSupport</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/dcx/lrmi-vocabs/educationalUse/professionalSupport">http://purl.org/dcx/lrmi-vocabs/educationalUse/professionalSupport</seealso>
    let professionalSupport =
        Prefixed_Name(lrmieducationalUse, "professionalSupport") |> PrefixedName
