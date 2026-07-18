namespace http.www.w3.org.ns.shacl_shacl.hash

open DoxAletheia.Rdf_Vocabulary

module shsh =
    let _namespace_name = "http://www.w3.org/ns/shacl-shacl#"

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl-shacl#EntailmentShape"></see>
    /// </summary>
    let EntailmentShape =
        Namespaced_IRI.parse _namespace_name "EntailmentShape" |> NamespacedName

    /// <summary>
    /// Defines constraints on what it means for a node to be a node within a well-formed RDF list. Note that this does not check whether the rdf:rest items are also well-formed lists as this would lead to unsupported recursion.
    /// <see href="http://www.w3.org/ns/shacl-shacl#ListNodeShape"></see></summary>
    let ListNodeShape =
        Namespaced_IRI.parse _namespace_name "ListNodeShape" |> NamespacedName

    /// <summary>
    /// A shape describing well-formed RDF lists. Currently does not check for non-recursion. This could be expressed using SHACL-SPARQL.
    /// <see href="http://www.w3.org/ns/shacl-shacl#ListShape"></see></summary>
    let ListShape = Namespaced_IRI.parse _namespace_name "ListShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl-shacl#NodeShapeShape"></see>
    /// </summary>
    let NodeShapeShape =
        Namespaced_IRI.parse _namespace_name "NodeShapeShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl-shacl#PathListWithAtLeast2Members"></see>
    /// </summary>
    let PathListWithAtLeast2Members =
        Namespaced_IRI.parse _namespace_name "PathListWithAtLeast2Members" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl-shacl#PathNodeShape"></see>
    /// </summary>
    let PathNodeShape =
        Namespaced_IRI.parse _namespace_name "PathNodeShape" |> NamespacedName

    /// <summary>
    /// A shape that can be used to validate the syntax rules of well-formed SHACL paths.
    /// <see href="http://www.w3.org/ns/shacl-shacl#PathShape"></see></summary>
    let PathShape = Namespaced_IRI.parse _namespace_name "PathShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl-shacl#PropertyShapeShape"></see>
    /// </summary>
    let PropertyShapeShape =
        Namespaced_IRI.parse _namespace_name "PropertyShapeShape" |> NamespacedName

    /// <summary>
    /// A shape that can be used to validate syntax rules for other shapes.
    /// <see href="http://www.w3.org/ns/shacl-shacl#ShapeShape"></see></summary>
    let ShapeShape = Namespaced_IRI.parse _namespace_name "ShapeShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl-shacl#ShapesGraphShape"></see>
    /// </summary>
    let ShapesGraphShape =
        Namespaced_IRI.parse _namespace_name "ShapesGraphShape" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl-shacl#ShapesListShape"></see>
    /// </summary>
    let ShapesListShape =
        Namespaced_IRI.parse _namespace_name "ShapesListShape" |> NamespacedName
