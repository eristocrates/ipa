namespace http.www.w3.org.ns.shacl_shacl.hash

open DoxAletheia

module shsh =
    let _namespace_name = "http://www.w3.org/ns/shacl-shacl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl-shacl#EntailmentShape"></see>
    /// </summary>
    let EntailmentShape = _prefix "EntailmentShape"
    /// <summary>
    /// Defines constraints on what it means for a node to be a node within a well-formed RDF list. Note that this does not check whether the rdf:rest items are also well-formed lists as this would lead to unsupported recursion.
    /// <see href="http://www.w3.org/ns/shacl-shacl#ListNodeShape"></see></summary>
    let ListNodeShape = _prefix "ListNodeShape"
    /// <summary>
    /// A shape describing well-formed RDF lists. Currently does not check for non-recursion. This could be expressed using SHACL-SPARQL.
    /// <see href="http://www.w3.org/ns/shacl-shacl#ListShape"></see></summary>
    let ListShape = _prefix "ListShape"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl-shacl#NodeShapeShape"></see>
    /// </summary>
    let NodeShapeShape = _prefix "NodeShapeShape"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl-shacl#PathListWithAtLeast2Members"></see>
    /// </summary>
    let PathListWithAtLeast2Members = _prefix "PathListWithAtLeast2Members"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl-shacl#PathNodeShape"></see>
    /// </summary>
    let PathNodeShape = _prefix "PathNodeShape"
    /// <summary>
    /// A shape that can be used to validate the syntax rules of well-formed SHACL paths.
    /// <see href="http://www.w3.org/ns/shacl-shacl#PathShape"></see></summary>
    let PathShape = _prefix "PathShape"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl-shacl#PropertyShapeShape"></see>
    /// </summary>
    let PropertyShapeShape = _prefix "PropertyShapeShape"
    /// <summary>
    /// A shape that can be used to validate syntax rules for other shapes.
    /// <see href="http://www.w3.org/ns/shacl-shacl#ShapeShape"></see></summary>
    let ShapeShape = _prefix "ShapeShape"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl-shacl#ShapesGraphShape"></see>
    /// </summary>
    let ShapesGraphShape = _prefix "ShapesGraphShape"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/shacl-shacl#ShapesListShape"></see>
    /// </summary>
    let ShapesListShape = _prefix "ShapesListShape"
