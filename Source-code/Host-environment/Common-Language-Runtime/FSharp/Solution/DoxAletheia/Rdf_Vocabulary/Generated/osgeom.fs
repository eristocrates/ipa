namespace http.data.ordnancesurvey.co.uk.ontology.geometry.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module osgeom =
    let _namespace_iri = Namespace_Iri osgeom |> NamespaceIRI
    /// <summary>
    ///   <para>osgeom:AbstractGeometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A superclass of all geometry types such as points, lines and polygons. This is currently a place holder class and likely to change when some standard way of representing geometries in RDF is agreed.</para>
    /// labels<para>Abstract Geometry</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/geometry/AbstractGeometry">http://data.ordnancesurvey.co.uk/ontology/geometry/AbstractGeometry</seealso>
    let AbstractGeometry = Prefixed_Name(osgeom, "AbstractGeometry") |> PrefixedName
    /// <summary>
    ///   <para>osgeom:1kmGridSquare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>1 km Grid Square</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/geometry/1kmGridSquare">http://data.ordnancesurvey.co.uk/ontology/geometry/1kmGridSquare</seealso>
    let _1kmGridSquare = Prefixed_Name(osgeom, "1kmGridSquare") |> PrefixedName
    /// <summary>
    ///   <para>osgeom:extent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This relates any object to is two-dimensional geometrical extent.</para>
    /// labels<para>extent</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/geometry/extent">http://data.ordnancesurvey.co.uk/ontology/geometry/extent</seealso>
    let extent = Prefixed_Name(osgeom, "extent") |> PrefixedName
    /// <summary>
    ///   <para>osgeom:hectares</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>The area of a geometry in hectres.</para><para>hectres</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/geometry/hectares">http://data.ordnancesurvey.co.uk/ontology/geometry/hectares</seealso>
    let hectares = Prefixed_Name(osgeom, "hectares") |> PrefixedName
    /// <summary>
    ///   <para>osgeom:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>A ontology to describe abstract geometries.</para>
    /// labels<para>Geometry Ontology</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/geometry/">http://data.ordnancesurvey.co.uk/ontology/geometry/</seealso>
    let _prefix_iri = Prefixed_Name(osgeom, "") |> PrefixedName
    /// <summary>
    ///   <para>osgeom:20kmGridSquare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>20km Grid Square</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/geometry/20kmGridSquare">http://data.ordnancesurvey.co.uk/ontology/geometry/20kmGridSquare</seealso>
    let _20kmGridSquare = Prefixed_Name(osgeom, "20kmGridSquare") |> PrefixedName
    /// <summary>
    ///   <para>osgeom:asGML</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property relates abstract geometry types to a GML (Geographic Markup Language) representation of that geometry. This GML representation is stored as an rdf:XMLLiteral.</para>
    /// labels<para>as GML</para></remarks>
    /// <seealso href="http://data.ordnancesurvey.co.uk/ontology/geometry/asGML">http://data.ordnancesurvey.co.uk/ontology/geometry/asGML</seealso>
    let asGML = Prefixed_Name(osgeom, "asGML") |> PrefixedName
