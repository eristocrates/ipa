namespace http.purl.org.net.vocab._2004._03.label.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module label =
    let _namespace_iri = Namespace_Iri label |> NamespaceIRI
    /// <summary>
    ///   <para>label:inversePlural</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"En relation mellem en term og dens inverses navn i flertalsform"</para>
    ///   <para>"A relation between a term and the label of its inverse in literal plural form"</para>
    /// labels<para>"inverse plural"</para><para>"inverst flertal"</para></remarks>
    /// <seealso href="http://purl.org/net/vocab/2004/03/label#inversePlural">http://purl.org/net/vocab/2004/03/label#inversePlural</seealso>
    let inversePlural = Prefixed_Name(label, "inversePlural") |> PrefixedName
    /// <summary>
    ///   <para>label:inverseSingular</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"En relation mellem en term og dens inverses navn i entalsform"</para>
    ///   <para>"A relation between a term and the label of its inverse in literal singular form"</para>
    /// labels<para>"inverst ental"</para><para>"inverse singular"</para></remarks>
    /// <seealso href="http://purl.org/net/vocab/2004/03/label#inverseSingular">http://purl.org/net/vocab/2004/03/label#inverseSingular</seealso>
    let inverseSingular = Prefixed_Name(label, "inverseSingular") |> PrefixedName
    /// <summary>
    ///   <para>label:plural</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Una relación entre un término y su etiqueta en forma plural"</para>
    ///   <para>"A relation between a term and its label in literal plural form"</para>
    ///   <para>"En relation mellem en term og dens navn i flertalsform"</para>
    /// labels<para>"plural"</para><para>"flertal"</para></remarks>
    /// <seealso href="http://purl.org/net/vocab/2004/03/label#plural">http://purl.org/net/vocab/2004/03/label#plural</seealso>
    let plural = Prefixed_Name(label, "plural") |> PrefixedName
    /// <summary>
    ///   <para>label:singular</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"A relation between a term and its label in literal singular form"</para>
    ///   <para>"En relation mellem en term og dens navn i entalsform"</para>
    ///   <para>"Una relación entre un término y su etiqueta en forma singular"</para>
    /// labels<para>"singular"</para><para>"ental"</para></remarks>
    /// <seealso href="http://purl.org/net/vocab/2004/03/label#singular">http://purl.org/net/vocab/2004/03/label#singular</seealso>
    let singular = Prefixed_Name(label, "singular") |> PrefixedName
