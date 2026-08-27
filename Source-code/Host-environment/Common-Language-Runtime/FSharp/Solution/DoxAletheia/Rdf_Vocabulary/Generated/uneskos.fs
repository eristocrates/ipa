namespace http.purl.org.umu.uneskos.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module uneskos =
    let _namespace_iri = Namespace_Iri uneskos |> NamespaceIRI
    /// <summary>
    ///   <para>uneskos:contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"contains element"</para></remarks>
    /// <seealso href="http://purl.org/umu/uneskos#contains">http://purl.org/umu/uneskos#contains</seealso>
    let contains = Prefixed_Name(uneskos, "contains") |> PrefixedName
    /// <summary>
    ///   <para>uneskos:hasMainConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has main concept"</para></remarks>
    /// <seealso href="http://purl.org/umu/uneskos#hasMainConcept">http://purl.org/umu/uneskos#hasMainConcept</seealso>
    let hasMainConcept = Prefixed_Name(uneskos, "hasMainConcept") |> PrefixedName
    /// <summary>
    ///   <para>uneskos:hasMicroThesaurus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"has Microthesaurus"</para></remarks>
    /// <seealso href="http://purl.org/umu/uneskos#hasMicroThesaurus">http://purl.org/umu/uneskos#hasMicroThesaurus</seealso>
    let hasMicroThesaurus = Prefixed_Name(uneskos, "hasMicroThesaurus") |> PrefixedName
    /// <summary>
    ///   <para>uneskos:mainConceptOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"is main concept in Collection"</para></remarks>
    /// <seealso href="http://purl.org/umu/uneskos#mainConceptOf">http://purl.org/umu/uneskos#mainConceptOf</seealso>
    let mainConceptOf = Prefixed_Name(uneskos, "mainConceptOf") |> PrefixedName
    /// <summary>
    ///   <para>uneskos:memberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"member of"</para></remarks>
    /// <seealso href="http://purl.org/umu/uneskos#memberOf">http://purl.org/umu/uneskos#memberOf</seealso>
    let memberOf = Prefixed_Name(uneskos, "memberOf") |> PrefixedName
