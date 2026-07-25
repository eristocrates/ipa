namespace http.www.w3.org.ns.shacl_shacl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module shsh =
    let _namespace_iri = Namespace_Iri shsh |> NamespaceIRI
    /// <summary>
    ///   <para>shsh:EntailmentShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl-shacl#EntailmentShape">http://www.w3.org/ns/shacl-shacl#EntailmentShape</seealso>
    let EntailmentShape = Prefixed_Name(shsh, "EntailmentShape") |> PrefixedName
    /// <summary>
    ///   <para>shsh:ShapeShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>A shape that can be used to validate syntax rules for other shapes.</para>
    /// labels<para>Shape shape</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl-shacl#ShapeShape">http://www.w3.org/ns/shacl-shacl#ShapeShape</seealso>
    let ShapeShape = Prefixed_Name(shsh, "ShapeShape") |> PrefixedName
    /// <summary>
    ///   <para>shsh:ListNodeShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>Defines constraints on what it means for a node to be a node within a well-formed RDF list. Note that this does not check whether the rdf:rest items are also well-formed lists as this would lead to unsupported recursion.</para>
    /// labels<para>List node shape</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl-shacl#ListNodeShape">http://www.w3.org/ns/shacl-shacl#ListNodeShape</seealso>
    let ListNodeShape = Prefixed_Name(shsh, "ListNodeShape") |> PrefixedName
    /// <summary>
    ///   <para>shsh:NodeShapeShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl-shacl#NodeShapeShape">http://www.w3.org/ns/shacl-shacl#NodeShapeShape</seealso>
    let NodeShapeShape = Prefixed_Name(shsh, "NodeShapeShape") |> PrefixedName
    /// <summary>
    ///   <para>shsh:PathNodeShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl-shacl#PathNodeShape">http://www.w3.org/ns/shacl-shacl#PathNodeShape</seealso>
    let PathNodeShape = Prefixed_Name(shsh, "PathNodeShape") |> PrefixedName
    /// <summary>
    ///   <para>shsh:PathShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>A shape that can be used to validate the syntax rules of well-formed SHACL paths.</para>
    /// labels<para>Path shape</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl-shacl#PathShape">http://www.w3.org/ns/shacl-shacl#PathShape</seealso>
    let PathShape = Prefixed_Name(shsh, "PathShape") |> PrefixedName

    /// <summary>
    ///   <para>shsh:PathListWithAtLeast2Members</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl-shacl#PathListWithAtLeast2Members">http://www.w3.org/ns/shacl-shacl#PathListWithAtLeast2Members</seealso>
    let PathListWithAtLeast2Members =
        Prefixed_Name(shsh, "PathListWithAtLeast2Members") |> PrefixedName

    /// <summary>
    ///   <para>shsh:PropertyShapeShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl-shacl#PropertyShapeShape">http://www.w3.org/ns/shacl-shacl#PropertyShapeShape</seealso>
    let PropertyShapeShape = Prefixed_Name(shsh, "PropertyShapeShape") |> PrefixedName
    /// <summary>
    ///   <para>shsh:ShapesGraphShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl-shacl#ShapesGraphShape">http://www.w3.org/ns/shacl-shacl#ShapesGraphShape</seealso>
    let ShapesGraphShape = Prefixed_Name(shsh, "ShapesGraphShape") |> PrefixedName
    /// <summary>
    ///   <para>shsh:</para>
    /// </summary>
    /// <remarks>
    ///   <para>This shapes graph can be used to validate SHACL shapes graphs against a subset of the syntax rules.</para>
    /// labels<para>SHACL for SHACL</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl-shacl#">http://www.w3.org/ns/shacl-shacl#</seealso>
    let _prefix_iri = Prefixed_Name(shsh, "") |> PrefixedName
    /// <summary>
    ///   <para>shsh:ListShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>A shape describing well-formed RDF lists. Currently does not check for non-recursion. This could be expressed using SHACL-SPARQL.</para>
    /// labels<para>List shape</para></remarks>
    /// <seealso href="http://www.w3.org/ns/shacl-shacl#ListShape">http://www.w3.org/ns/shacl-shacl#ListShape</seealso>
    let ListShape = Prefixed_Name(shsh, "ListShape") |> PrefixedName
    /// <summary>
    ///   <para>shsh:ShapesListShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/shacl-shacl#ShapesListShape">http://www.w3.org/ns/shacl-shacl#ShapesListShape</seealso>
    let ShapesListShape = Prefixed_Name(shsh, "ShapesListShape") |> PrefixedName
