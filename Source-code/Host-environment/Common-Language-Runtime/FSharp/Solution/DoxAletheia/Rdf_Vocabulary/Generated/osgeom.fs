namespace http.data.ordnancesurvey.co.uk.ontology.geometry.slash

open DoxAletheia

module osgeom =
    let _namespace_name = "http://data.ordnancesurvey.co.uk/ontology/geometry/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://data.ordnancesurvey.co.uk/ontology/geometry/1kmGridSquare"></see>
    /// </summary>
    let _1kmGridSquare = _prefix "1kmGridSquare"
    /// <summary>
    ///   <see href="http://data.ordnancesurvey.co.uk/ontology/geometry/20kmGridSquare"></see>
    /// </summary>
    let _20kmGridSquare = _prefix "20kmGridSquare"
    /// <summary>
    /// A superclass of all geometry types such as points, lines and polygons. This is currently a place holder class and likely to change when some standard way of representing geometries in RDF is agreed.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/geometry/AbstractGeometry"></see></summary>
    let AbstractGeometry = _prefix "AbstractGeometry"
    /// <summary>
    /// This property relates abstract geometry types to a GML (Geographic Markup Language) representation of that geometry. This GML representation is stored as an rdf:XMLLiteral.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/geometry/asGML"></see></summary>
    let asGML = _prefix "asGML"
    /// <summary>
    /// This relates any object to is two-dimensional geometrical extent.
    /// <see href="http://data.ordnancesurvey.co.uk/ontology/geometry/extent"></see></summary>
    let extent = _prefix "extent"
    /// <summary>
    ///   <see href="http://data.ordnancesurvey.co.uk/ontology/geometry/hectares"></see>
    /// </summary>
    let hectares = _prefix "hectares"
