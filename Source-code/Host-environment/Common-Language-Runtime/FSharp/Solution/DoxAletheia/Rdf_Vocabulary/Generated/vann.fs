namespace http.purl.org.vocab.vann.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module vann =
    let _namespace_iri = Namespace_Iri vann |> NamespaceIRI
    /// <summary>
    ///   <para>vann:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/vocab/vann/">http://purl.org/vocab/vann/</seealso>
    let _prefix_iri = Prefixed_Name(vann, "") |> PrefixedName
    /// <summary>
    ///   <para>vann:vann-vocab-20040305</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/vocab/vann/vann-vocab-20040305">http://purl.org/vocab/vann/vann-vocab-20040305</seealso>
    let vann_vocab_20040305 = Prefixed_Name(vann, "vann-vocab-20040305") |> PrefixedName

    /// <summary>
    ///   <para>vann:preferredNamespaceUri</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>The preferred namespace URI to use when using terms from this vocabulary in an XML document.</para>
    /// labels<para>Preferred Namespace Uri</para></remarks>
    /// <seealso href="http://purl.org/vocab/vann/preferredNamespaceUri">http://purl.org/vocab/vann/preferredNamespaceUri</seealso>
    let preferredNamespaceUri =
        Prefixed_Name(vann, "preferredNamespaceUri") |> PrefixedName

    /// <summary>
    ///   <para>vann:termGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A group of related terms in a vocabulary.</para>
    /// labels<para>Term Group</para></remarks>
    /// <seealso href="http://purl.org/vocab/vann/termGroup">http://purl.org/vocab/vann/termGroup</seealso>
    let termGroup = Prefixed_Name(vann, "termGroup") |> PrefixedName

    /// <summary>
    ///   <para>vann:preferredNamespacePrefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>The preferred namespace prefix to use when using terms from this vocabulary in an XML document.</para>
    /// labels<para>Preferred Namespace Prefix</para></remarks>
    /// <seealso href="http://purl.org/vocab/vann/preferredNamespacePrefix">http://purl.org/vocab/vann/preferredNamespacePrefix</seealso>
    let preferredNamespacePrefix =
        Prefixed_Name(vann, "preferredNamespacePrefix") |> PrefixedName

    /// <summary>
    ///   <para>vann:changes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A reference to a resource that describes changes between this version of a vocabulary and the previous.</para>
    /// labels<para>Changes</para></remarks>
    /// <seealso href="http://purl.org/vocab/vann/changes">http://purl.org/vocab/vann/changes</seealso>
    let changes = Prefixed_Name(vann, "changes") |> PrefixedName
    /// <summary>
    ///   <para>vann:example</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A reference to a resource that provides an example of how this resource can be used.</para>
    /// labels<para>Example</para></remarks>
    /// <seealso href="http://purl.org/vocab/vann/example">http://purl.org/vocab/vann/example</seealso>
    let example = Prefixed_Name(vann, "example") |> PrefixedName
    /// <summary>
    ///   <para>vann:usageNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A reference to a resource that provides information on how this resource is to be used.</para>
    /// labels<para>Usage Note</para></remarks>
    /// <seealso href="http://purl.org/vocab/vann/usageNote">http://purl.org/vocab/vann/usageNote</seealso>
    let usageNote = Prefixed_Name(vann, "usageNote") |> PrefixedName
