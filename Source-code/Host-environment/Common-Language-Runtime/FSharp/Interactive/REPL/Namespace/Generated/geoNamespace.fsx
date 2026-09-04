#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module geo =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.w3.org/2003/01/geo/wgs84_pos#" "geo"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : point^^xsd:string</para>
    ///   <para>rdfs:comment : A point, typically described using a coordinate system relative to Earth, such as WGS84.
    ///   ^^xsd:stringrdfs:comment :
    /// Uniquely identified by lat/long/alt. i.e.
    ///
    /// spaciallyIntersects(P1, P2) :- lat(P1, LAT), long(P1, LONG), alt(P1, ALT),
    ///   lat(P2, LAT), long(P2, LONG), alt(P2, ALT).
    ///
    /// sameThing(P1, P2) :- type(P1, Point), type(P2, Point), spaciallyIntersects(P1, P2).
    ///   ^^xsd:string</para>
    ///   <a href="http://www.w3.org/2003/01/geo/wgs84_pos#Point">geo:Point</a>
    /// </summary>
    let Point = _prefixId.prefix "Point"
    /// <summary>
    ///   <para>rdfs:label : SpatialThing^^xsd:string</para>
    ///   <para>rdfs:comment : Anything with spatial extent, i.e. size, shape, or position.
    ///  e.g. people, places, bowling balls, as well as abstract areas like cubes.
    /// ^^xsd:string</para>
    ///   <a href="http://www.w3.org/2003/01/geo/wgs84_pos#SpatialThing">geo:SpatialThing</a>
    /// </summary>
    let SpatialThing = _prefixId.prefix "SpatialThing"
    /// <summary>
    ///   <para>rdfs:label : altitude^^xsd:string</para>
    ///   <para>rdfs:comment : The WGS84 altitude of a SpatialThing (decimal meters
    /// above the local reference ellipsoid).^^xsd:string</para>
    ///   <a href="http://www.w3.org/2003/01/geo/wgs84_pos#alt">geo:alt</a>
    /// </summary>
    let alt = _prefixId.prefix "alt"
    /// <summary>
    ///   <para>rdfs:label : latitude^^xsd:string</para>
    ///   <para>rdfs:comment : The WGS84 latitude of a SpatialThing (decimal degrees).^^xsd:string</para>
    ///   <a href="http://www.w3.org/2003/01/geo/wgs84_pos#lat">geo:lat</a>
    /// </summary>
    let lat = _prefixId.prefix "lat"
    /// <summary>
    ///   <para>rdfs:label : lat/long^^xsd:string</para>
    ///   <para>rdfs:comment : A comma-separated representation of a latitude, longitude coordinate.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2003/01/geo/wgs84_pos#lat_long">geo:lat_long</a>
    /// </summary>
    let lat_long = _prefixId.prefix "lat_long"
    /// <summary>
    ///   <para>rdfs:label : location^^xsd:string</para>
    ///   <para>rdfs:comment : The relation between something and the point,
    ///  or other geometrical thing in space, where it is.  For example, the realtionship between
    ///  a radio tower and a Point with a given lat and long.
    ///  Or a relationship between a park and its outline as a closed arc of points, or a road and
    ///  its location as a arc (a sequence of points).
    ///  Clearly in practice there will be limit to the accuracy of any such statement, but one would expect
    ///  an accuracy appropriate for the size of the object and uses such as mapping .
    ///  ^^xsd:string</para>
    ///   <a href="http://www.w3.org/2003/01/geo/wgs84_pos#location">geo:location</a>
    /// </summary>
    let location = _prefixId.prefix "location"
    /// <summary>
    ///   <para>rdfs:label : longitude^^xsd:string</para>
    ///   <para>rdfs:comment : The WGS84 longitude of a SpatialThing (decimal degrees).^^xsd:string</para>
    ///   <a href="http://www.w3.org/2003/01/geo/wgs84_pos#long">geo:long</a>
    /// </summary>
    let long = _prefixId.prefix "long"
