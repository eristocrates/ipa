namespace http.www.w3.org.ns.sawsdl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module sawsdl =
    let _namespace_iri = Namespace_Iri sawsdl |> NamespaceIRI
    /// <summary>
    ///   <para>sawsdl:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/sawsdl#">http://www.w3.org/ns/sawsdl#</seealso>
    let _prefix_iri = Prefixed_Name(sawsdl, "") |> PrefixedName

    /// <summary>
    ///   <para>sawsdl:liftingSchemaMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/sawsdl#liftingSchemaMapping">http://www.w3.org/ns/sawsdl#liftingSchemaMapping</seealso>
    let liftingSchemaMapping =
        Prefixed_Name(sawsdl, "liftingSchemaMapping") |> PrefixedName

    /// <summary>
    ///   <para>sawsdl:loweringSchemaMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/sawsdl#loweringSchemaMapping">http://www.w3.org/ns/sawsdl#loweringSchemaMapping</seealso>
    let loweringSchemaMapping =
        Prefixed_Name(sawsdl, "loweringSchemaMapping") |> PrefixedName

    /// <summary>
    ///   <para>sawsdl:modelReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/sawsdl#modelReference">http://www.w3.org/ns/sawsdl#modelReference</seealso>
    let modelReference = Prefixed_Name(sawsdl, "modelReference") |> PrefixedName
