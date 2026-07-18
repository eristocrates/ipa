namespace http.data.ordnancesurvey.co.uk.ontology.geometry.slash

open DoxAletheia.Rdf_Vocabulary

module osgeom =
    let _namespace_name = "http://data.ordnancesurvey.co.uk/ontology/geometry/"

    /// <summary>
    ///   <see href="http://data.ordnancesurvey.co.uk/ontology/geometry/1kmGridSquare"></see>
    /// </summary>
    let _1kmGridSquare =
        Namespaced_IRI.parse _namespace_name "1kmGridSquare" |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ordnancesurvey.co.uk/ontology/geometry/20kmGridSquare"></see>
    /// </summary>
    let _20kmGridSquare =
        Namespaced_IRI.parse _namespace_name "20kmGridSquare" |> NamespacedName

    /// <summary>
    /// A superclass of all geometry types such as points, lines and polygons. This is currently a place holder class and likely to change when some standard way of representing geometries in RDF is agreed.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/geometry/AbstractGeometry"></see></summary>
    let AbstractGeometry =
        Namespaced_IRI.parse _namespace_name "AbstractGeometry" |> NamespacedName

    /// <summary>
    /// This property relates abstract geometry types to a GML (Geographic Markup Language) representation of that geometry. This GML representation is stored as an rdf:XMLLiteral.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/geometry/asGML"></see></summary>
    let asGML = Namespaced_IRI.parse _namespace_name "asGML" |> NamespacedName
    /// <summary>
    /// This relates any object to is two-dimensional geometrical extent.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/geometry/extent"></see></summary>
    let extent = Namespaced_IRI.parse _namespace_name "extent" |> NamespacedName
    /// <summary>
    ///   <see href="http://data.ordnancesurvey.co.uk/ontology/geometry/hectares"></see>
    /// </summary>
    let hectares = Namespaced_IRI.parse _namespace_name "hectares" |> NamespacedName
