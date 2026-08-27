namespace http.purl.org.olia.system.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module oliasystem =
    let _namespace_iri = Namespace_Iri oliasystem |> NamespaceIRI
    /// <summary>
    ///   <para>oliasystem:Feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/olia/system.owl#Feature">http://purl.org/olia/system.owl#Feature</seealso>
    let Feature = Prefixed_Name(oliasystem, "Feature") |> PrefixedName
    /// <summary>
    ///   <para>oliasystem:UnitOfAnnotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/olia/system.owl#UnitOfAnnotation">http://purl.org/olia/system.owl#UnitOfAnnotation</seealso>
    let UnitOfAnnotation = Prefixed_Name(oliasystem, "UnitOfAnnotation") |> PrefixedName
    /// <summary>
    ///   <para>oliasystem:hasFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/olia/system.owl#hasFeature">http://purl.org/olia/system.owl#hasFeature</seealso>
    let hasFeature = Prefixed_Name(oliasystem, "hasFeature") |> PrefixedName
