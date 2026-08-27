namespace https.www.omg.org.spec.Commons.AnnotationVocabulary.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module omg_ann =
    let _namespace_iri = Namespace_Iri omg_ann |> NamespaceIRI
    /// <summary>
    ///   <para>omg-ann:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/AnnotationVocabulary/">https://www.omg.org/spec/Commons/AnnotationVocabulary/</seealso>
    let _prefix_iri = Prefixed_Name(omg_ann, "") |> PrefixedName
    /// <summary>
    ///   <para>omg-ann:abbreviation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/AnnotationVocabulary/abbreviation">https://www.omg.org/spec/Commons/AnnotationVocabulary/abbreviation</seealso>
    let abbreviation = Prefixed_Name(omg_ann, "abbreviation") |> PrefixedName
    /// <summary>
    ///   <para>omg-ann:acronym</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/AnnotationVocabulary/acronym">https://www.omg.org/spec/Commons/AnnotationVocabulary/acronym</seealso>
    let acronym = Prefixed_Name(omg_ann, "acronym") |> PrefixedName
    /// <summary>
    ///   <para>omg-ann:adaptedFrom</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/AnnotationVocabulary/adaptedFrom">https://www.omg.org/spec/Commons/AnnotationVocabulary/adaptedFrom</seealso>
    let adaptedFrom = Prefixed_Name(omg_ann, "adaptedFrom") |> PrefixedName
    /// <summary>
    ///   <para>omg-ann:copyright</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/AnnotationVocabulary/copyright">https://www.omg.org/spec/Commons/AnnotationVocabulary/copyright</seealso>
    let copyright = Prefixed_Name(omg_ann, "copyright") |> PrefixedName
    /// <summary>
    ///   <para>omg-ann:directSource</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/AnnotationVocabulary/directSource">https://www.omg.org/spec/Commons/AnnotationVocabulary/directSource</seealso>
    let directSource = Prefixed_Name(omg_ann, "directSource") |> PrefixedName
    /// <summary>
    ///   <para>omg-ann:explanatoryNote</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/AnnotationVocabulary/explanatoryNote">https://www.omg.org/spec/Commons/AnnotationVocabulary/explanatoryNote</seealso>
    let explanatoryNote = Prefixed_Name(omg_ann, "explanatoryNote") |> PrefixedName
    /// <summary>
    ///   <para>omg-ann:symbol</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/AnnotationVocabulary/symbol">https://www.omg.org/spec/Commons/AnnotationVocabulary/symbol</seealso>
    let symbol = Prefixed_Name(omg_ann, "symbol") |> PrefixedName
    /// <summary>
    ///   <para>omg-ann:synonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/AnnotationVocabulary/synonym">https://www.omg.org/spec/Commons/AnnotationVocabulary/synonym</seealso>
    let synonym = Prefixed_Name(omg_ann, "synonym") |> PrefixedName
    /// <summary>
    ///   <para>omg-ann:usageNote</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/AnnotationVocabulary/usageNote">https://www.omg.org/spec/Commons/AnnotationVocabulary/usageNote</seealso>
    let usageNote = Prefixed_Name(omg_ann, "usageNote") |> PrefixedName
