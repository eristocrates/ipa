namespace https.vocab.org.vann.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module vann1 =
    let _namespace_iri = Namespace_Iri vann1 |> NamespaceIRI
    /// <summary>
    ///   <para>vann1:changes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A reference to a resource that describes changes between this version of a vocabulary and the previous."</para>
    /// labels<para>"changes"</para></remarks>
    /// <seealso href="https://vocab.org/vann/changes">https://vocab.org/vann/changes</seealso>
    let changes = Prefixed_Name(vann1, "changes") |> PrefixedName
    /// <summary>
    ///   <para>vann1:example</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A reference to a resource that provides an example of how this resource can be used."</para>
    /// labels<para>"example"</para></remarks>
    /// <seealso href="https://vocab.org/vann/example">https://vocab.org/vann/example</seealso>
    let example = Prefixed_Name(vann1, "example") |> PrefixedName

    /// <summary>
    ///   <para>vann1:preferredNamespacePrefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The preferred namespace prefix to use when using terms from this vocabulary in an XML document."</para>
    /// labels<para>"preferred namespace prefix"</para></remarks>
    /// <seealso href="https://vocab.org/vann/preferredNamespacePrefix">https://vocab.org/vann/preferredNamespacePrefix</seealso>
    let preferredNamespacePrefix =
        Prefixed_Name(vann1, "preferredNamespacePrefix") |> PrefixedName

    /// <summary>
    ///   <para>vann1:preferredNamespaceUri</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The preferred namespace URI to use when using terms from this vocabulary in an XML document."</para>
    /// labels<para>"preferred namespace uri"</para></remarks>
    /// <seealso href="https://vocab.org/vann/preferredNamespaceUri">https://vocab.org/vann/preferredNamespaceUri</seealso>
    let preferredNamespaceUri =
        Prefixed_Name(vann1, "preferredNamespaceUri") |> PrefixedName

    /// <summary>
    ///   <para>vann1:usageNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A reference to a resource that provides information on how this resource is to be used."</para>
    /// labels<para>"usage note"</para></remarks>
    /// <seealso href="https://vocab.org/vann/usageNote">https://vocab.org/vann/usageNote</seealso>
    let usageNote = Prefixed_Name(vann1, "usageNote") |> PrefixedName
