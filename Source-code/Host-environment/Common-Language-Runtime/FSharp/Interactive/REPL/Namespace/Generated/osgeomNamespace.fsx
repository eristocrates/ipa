#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module osgeom =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://data.ordnancesurvey.co.uk/ontology/geometry/" "osgeom"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : 1 km Grid Square^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/geometry/1kmGridSquare">osgeom:1kmGridSquare</a>
    /// </summary>
    let _1kmGridSquare = _prefixId.prefix "1kmGridSquare"
    /// <summary>
    ///   <para>rdfs:label : 20km Grid Square^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/geometry/20kmGridSquare">osgeom:20kmGridSquare</a>
    /// </summary>
    let _20kmGridSquare = _prefixId.prefix "20kmGridSquare"
    /// <summary>
    ///   <para>rdfs:comment : A superclass of all geometry types such as points, lines and polygons. This is currently a place holder class and likely to change when some standard way of representing geometries in RDF is agreed.^^xsd:string</para>
    ///   <para>rdfs:label : Abstract Geometry^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/geometry/AbstractGeometry">osgeom:AbstractGeometry</a>
    /// </summary>
    let AbstractGeometry = _prefixId.prefix "AbstractGeometry"
    /// <summary>
    ///   <para>rdfs:comment : This property relates abstract geometry types to a GML (Geographic Markup Language) representation of that geometry. This GML representation is stored as an rdf:XMLLiteral.^^xsd:string</para>
    ///   <para>rdfs:label : as GML^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/geometry/asGML">osgeom:asGML</a>
    /// </summary>
    let asGML = _prefixId.prefix "asGML"
    /// <summary>
    ///   <para>rdfs:comment : This relates any object to is two-dimensional geometrical extent.^^xsd:string</para>
    ///   <para>rdfs:label : extent^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/geometry/extent">osgeom:extent</a>
    /// </summary>
    let extent = _prefixId.prefix "extent"
    /// <summary>
    ///   <para>rdfs:label : The area of a geometry in hectres.^^xsd:stringrdfs:label : hectres^^xsd:string</para>
    ///   <a href="http://data.ordnancesurvey.co.uk/ontology/geometry/hectares">osgeom:hectares</a>
    /// </summary>
    let hectares = _prefixId.prefix "hectares"
