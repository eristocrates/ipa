namespace http.www.w3.org._2003._01.geo.wgs84_pos.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module w3cgeo =
    let _namespace_iri = Namespace_Iri w3cgeo |> NamespaceIRI
    /// <summary>
    ///   <para>w3cgeo:</para>
    /// </summary>
    /// <remarks>
    ///   <para>"
    /// Recent changes to this namespace:
    /// $Log: wgs84_pos.rdf,v $
    /// Revision 1.22  2009/04/20 15:00:30  timbl
    /// Remove the time bits which have been deal with elsewhere eg in iCal.
    ///
    /// Revision 1.21  2009/04/20 12:52:47  timbl
    /// try again
    ///
    /// Revision 1.20  2009/04/20 12:42:11  timbl
    /// Add Event (edited ages ago and never checked in), and location (following discussion http://chatlogs.planetrdf.com/swig/2009-04-20#T12-36-09)
    ///
    /// Revision 1.19  2009/04/20 12:36:31  timbl
    /// Add Event (edited ages ago and never checked in), and location (following discussion http://chatlogs.planetrdf.com/swig/2009-04-20#T12-36-09)
    ///
    /// Revision 1.18  2006/02/01 22:01:04  danbri
    /// Clarified that lat and long are decimal degrees, and that alt is decimal metres about local reference ellipsoid
    ///
    /// Revision 1.17  2004/02/06 17:38:12  danbri
    /// Fixed a bad commit screwup
    ///
    /// Revision 1.15  2003/04/19 11:24:08  danbri
    /// Fixed the typo even more.
    ///
    /// Revision 1.14  2003/04/19 11:16:56  danbri
    /// fixed a typo
    ///
    /// Revision 1.13  2003/02/19 22:27:27  connolly
    /// relaxed domain constraints on lat/long/alt from Point to SpatialThing
    ///
    /// Revision 1.12  2003/01/12 01:41:41  danbri
    /// Trying local copy of XSLT doc.
    ///
    /// Revision 1.11  2003/01/12 01:20:18  danbri
    /// added a link to morten's xslt rdfs viewer.
    ///
    /// Revision 1.10  2003/01/11 18:56:49  danbri
    /// Removed datatype range from lat and long properties, since they would
    /// have required each occurance of the property to mention the datatype.
    ///
    /// Revision 1.9  2003/01/11 11:41:31  danbri
    /// Another typo; repaired rdfs:Property to rdf:Property x4
    ///
    /// Revision 1.8  2003/01/11 11:05:02  danbri
    /// Added an rdfs:range for each lat/long/alt property,
    /// http://www.w3.org/2001/XMLSchema#float
    ///
    /// Revision 1.7  2003/01/10 20:25:16  danbri
    /// Longer rdfs:comment for Point, trying to be Earth-centric and neutral about
    /// coordinate system(s) at the same time. Feedback welcomed.
    ///
    /// Revision 1.6  2003/01/10 20:18:30  danbri
    /// Added CVS log comments into the RDF/XML as an rdfs:comment property of the
    /// vocabulary. Note that this is not common practice (but seems both harmless
    /// and potentially useful).
    ///
    ///
    /// revision 1.5
    /// date: 2003/01/10 20:14:31;  author: danbri;  state: Exp;  lines: +16 -5
    /// Updated schema:
    /// Added a dc:date, added url for more info. Changed the rdfs:label of the
    /// namespace from gp to geo. Added a class Point, set as the rdfs:domain of
    /// each property. Added XML comment on the lat_long property suggesting that
    /// we might not need it (based on #rdfig commentary from implementors).
    ///
    /// revision 1.4
    /// date: 2003/01/10 20:01:07;  author: danbri;  state: Exp;  lines: +6 -5
    /// Fixed typo; several rdfs:about attributes are now rdf:about. Thanks to MortenF in
    /// #rdfig for catching this error.
    ///
    /// revision 1.3
    /// date: 2003/01/10 11:59:03;  author: danbri;  state: Exp;  lines: +4 -3
    /// fixed buglet in vocab, added more wgs links
    ///
    /// revision 1.2
    /// date: 2003/01/10 11:01:11;  author: danbri;  state: Exp;  lines: +4 -4
    /// Removed alt from the as-a-flat-string property, and switched from
    /// space separated to comma separated.
    ///
    /// revision 1.1
    /// date: 2003/01/10 10:53:23;  author: danbri;  state: Exp;
    /// basic geo vocab
    ///
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Recent changes to this namespace:
    /// $Log: wgs84_pos.rdf,v $
    /// Revision 1.22  2009/04/20 15:00:30  timbl
    /// Remove the time bits which have been deal with elsewhere eg in iCal.
    ///
    /// Revision 1.21  2009/04/20 12:52:47  timbl
    /// try again
    ///
    /// Revision 1.20  2009/04/20 12:42:11  timbl
    /// Add Event (edited ages ago and never checked in), and location (following discussion http://chatlogs.planetrdf.com/swig/2009-04-20#T12-36-09)
    ///
    /// Revision 1.19  2009/04/20 12:36:31  timbl
    /// Add Event (edited ages ago and never checked in), and location (following discussion http://chatlogs.planetrdf.com/swig/2009-04-20#T12-36-09)
    ///
    /// Revision 1.18  2006/02/01 22:01:04  danbri
    /// Clarified that lat and long are decimal degrees, and that alt is decimal metres about local reference ellipsoid
    ///
    /// Revision 1.17  2004/02/06 17:38:12  danbri
    /// Fixed a bad commit screwup
    ///
    /// Revision 1.15  2003/04/19 11:24:08  danbri
    /// Fixed the typo even more.
    ///
    /// Revision 1.14  2003/04/19 11:16:56  danbri
    /// fixed a typo
    ///
    /// Revision 1.13  2003/02/19 22:27:27  connolly
    /// relaxed domain constraints on lat/long/alt from Point to SpatialThing
    ///
    /// Revision 1.12  2003/01/12 01:41:41  danbri
    /// Trying local copy of XSLT doc.
    ///
    /// Revision 1.11  2003/01/12 01:20:18  danbri
    /// added a link to morten's xslt rdfs viewer.
    ///
    /// Revision 1.10  2003/01/11 18:56:49  danbri
    /// Removed datatype range from lat and long properties, since they would
    /// have required each occurance of the property to mention the datatype.
    ///
    /// Revision 1.9  2003/01/11 11:41:31  danbri
    /// Another typo; repaired rdfs:Property to rdf:Property x4
    ///
    /// Revision 1.8  2003/01/11 11:05:02  danbri
    /// Added an rdfs:range for each lat/long/alt property,
    /// http://www.w3.org/2001/XMLSchema#float
    ///
    /// Revision 1.7  2003/01/10 20:25:16  danbri
    /// Longer rdfs:comment for Point, trying to be Earth-centric and neutral about
    /// coordinate system(s) at the same time. Feedback welcomed.
    ///
    /// Revision 1.6  2003/01/10 20:18:30  danbri
    /// Added CVS log comments into the RDF/XML as an rdfs:comment property of the
    /// vocabulary. Note that this is not common practice (but seems both harmless
    /// and potentially useful).
    ///
    ///
    /// revision 1.5
    /// date: 2003/01/10 20:14:31;  author: danbri;  state: Exp;  lines: +16 -5
    /// Updated schema:
    /// Added a dc:date, added url for more info. Changed the rdfs:label of the
    /// namespace from gp to geo. Added a class Point, set as the rdfs:domain of
    /// each property. Added XML comment on the lat_long property suggesting that
    /// we might not need it (based on #rdfig commentary from implementors).
    ///
    /// revision 1.4
    /// date: 2003/01/10 20:01:07;  author: danbri;  state: Exp;  lines: +6 -5
    /// Fixed typo; several rdfs:about attributes are now rdf:about. Thanks to MortenF in
    /// #rdfig for catching this error.
    ///
    /// revision 1.3
    /// date: 2003/01/10 11:59:03;  author: danbri;  state: Exp;  lines: +4 -3
    /// fixed buglet in vocab, added more wgs links
    ///
    /// revision 1.2
    /// date: 2003/01/10 11:01:11;  author: danbri;  state: Exp;  lines: +4 -4
    /// Removed alt from the as-a-flat-string property, and switched from
    /// space separated to comma separated.
    ///
    /// revision 1.1
    /// date: 2003/01/10 10:53:23;  author: danbri;  state: Exp;
    /// basic geo vocab"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"geo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2003/01/geo/wgs84_pos#">http://www.w3.org/2003/01/geo/wgs84_pos#</seealso>
    let _prefix_iri = Prefixed_Name(w3cgeo, "") |> PrefixedName
    /// <summary>
    ///   <para>w3cgeo:BoundingBox</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2003/01/geo/wgs84_pos#BoundingBox">http://www.w3.org/2003/01/geo/wgs84_pos#BoundingBox</seealso>
    let BoundingBox = Prefixed_Name(w3cgeo, "BoundingBox") |> PrefixedName
    /// <summary>
    ///   <para>w3cgeo:Feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2003/01/geo/wgs84_pos#Feature">http://www.w3.org/2003/01/geo/wgs84_pos#Feature</seealso>
    let Feature = Prefixed_Name(w3cgeo, "Feature") |> PrefixedName
    /// <summary>
    ///   <para>w3cgeo:Geometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2003/01/geo/wgs84_pos#Geometry">http://www.w3.org/2003/01/geo/wgs84_pos#Geometry</seealso>
    let Geometry = Prefixed_Name(w3cgeo, "Geometry") |> PrefixedName
    /// <summary>
    ///   <para>w3cgeo:Latitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2003/01/geo/wgs84_pos#Latitude">http://www.w3.org/2003/01/geo/wgs84_pos#Latitude</seealso>
    let Latitude = Prefixed_Name(w3cgeo, "Latitude") |> PrefixedName
    /// <summary>
    ///   <para>w3cgeo:Longitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2003/01/geo/wgs84_pos#Longitude">http://www.w3.org/2003/01/geo/wgs84_pos#Longitude</seealso>
    let Longitude = Prefixed_Name(w3cgeo, "Longitude") |> PrefixedName
    /// <summary>
    ///   <para>w3cgeo:Point</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Uniquely identified by lat/long/alt. i.e.
    ///
    /// spaciallyIntersects(P1, P2) :- lat(P1, LAT), long(P1, LONG), alt(P1, ALT),
    ///   lat(P2, LAT), long(P2, LONG), alt(P2, ALT).
    ///
    /// sameThing(P1, P2) :- type(P1, Point), type(P2, Point), spaciallyIntersects(P1, P2)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"
    /// Uniquely identified by lat/long/alt. i.e.
    ///
    /// spaciallyIntersects(P1, P2) :- lat(P1, LAT), long(P1, LONG), alt(P1, ALT),
    ///   lat(P2, LAT), long(P2, LONG), alt(P2, ALT).
    ///
    /// sameThing(P1, P2) :- type(P1, Point), type(P2, Point), spaciallyIntersects(P1, P2).
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A point, typically described using a coordinate system relative to Earth, such as WGS84."</para>
    ///   <para>"A point, typically described using a coordinate system relative to Earth, such as WGS84.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"
    /// Uniquely identified by lat/long/alt. i.e.
    ///
    /// spaciallyIntersects(P1, P2) :- lat(P1, LAT), long(P1, LONG), alt(P1, ALT),
    ///   lat(P2, LAT), long(P2, LONG), alt(P2, ALT).
    ///
    /// sameThing(P1, P2) :- type(P1, Point), type(P2, Point), spaciallyIntersects(P1, P2).
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A point, typically described using a coordinate system relative to Earth, such as WGS84. Uniquely identified by lat/long/alt. i.e. spaciallyIntersects(P1, P2) :- lat(P1, LAT), long(P1, LONG), alt(P1, ALT), at(P2, LAT), long(P2, LONG), alt(P2, ALT). sameThing(P1, P2) :- type(P1, Point), type(P2, Point), spaciallyIntersects(P1, P2)."</para>
    ///   <para>"A point, typically described using a coordinate system relative to Earth, such as WGS84."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The relation between something and the point,
    ///  or other geometrical thing in space, where it is.  For example, the realtionship between
    ///  a radio tower and a Point with a given lat and long.
    ///  Or a relationship between a park and its outline as a closed arc of points, or a road and
    ///  its location as a arc (a sequence of points).
    ///  Clearly in practice there will be limit to the accuracy of any such statement, but one would expect
    ///  an accuracy appropriate for the size of the object and uses such as mapping ."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"
    /// Uniquely identified by lat/long/alt. i.e.
    ///
    /// spaciallyIntersects(P1, P2) :- lat(P1, LAT), long(P1, LONG), alt(P1, ALT),
    ///   lat(P2, LAT), long(P2, LONG), alt(P2, ALT).
    ///
    /// sameThing(P1, P2) :- type(P1, Point), type(P2, Point), spaciallyIntersects(P1, P2)."</para>
    /// labels<para>"point"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Point"</para><para>"Point"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2003/01/geo/wgs84_pos#Point">http://www.w3.org/2003/01/geo/wgs84_pos#Point</seealso>
    let Point = Prefixed_Name(w3cgeo, "Point") |> PrefixedName
    /// <summary>
    ///   <para>w3cgeo:SpartialThing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2003/01/geo/wgs84_pos#SpartialThing">http://www.w3.org/2003/01/geo/wgs84_pos#SpartialThing</seealso>
    let SpartialThing = Prefixed_Name(w3cgeo, "SpartialThing") |> PrefixedName
    /// <summary>
    ///   <para>w3cgeo:SpatialThing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Anything with spatial extent, i.e. size, shape, or position.
    ///  e.g. people, places, bowling balls, as well as abstract areas like cubes."</para>
    ///   <para>"Anything with spatial extent, i.e. size, shape, or position.
    ///  e.g. people, places, bowling balls, as well as abstract areas like cubes.
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Spatial thing"</para>
    ///   <para>"Anything with spatial extent, i.e. size, shape, or position.
    ///  e.g. people, places, bowling balls, as well as abstract areas like cubes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Anything with spatial extent, i.e. size, shape, or position. e.g. people, places, bowling balls, as well as abstract areas like cubes."</para>
    /// labels<para>"Entité spatiale"</para><para>"SpatialThing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Spatial Thing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Spatial thing"</para></remarks>
    /// <seealso href="http://www.w3.org/2003/01/geo/wgs84_pos#SpatialThing">http://www.w3.org/2003/01/geo/wgs84_pos#SpatialThing</seealso>
    let SpatialThing = Prefixed_Name(w3cgeo, "SpatialThing") |> PrefixedName
    /// <summary>
    ///   <para>w3cgeo:alt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The WGS84 altitude of a SpatialThing (decimal meters above the local reference ellipsoid)."</para>
    ///   <para>"The WGS84 altitude of a SpatialThing (decimal meters above the local reference ellipsoid)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Altitude in WGS84"</para>
    ///   <para>"altitude"</para>
    ///   <para>"the altitude of a spartial thing, i.e., a point."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The WGS84 altitude of a SpatialThing (decimal meters
    /// above the local reference ellipsoid)."</para>
    ///   <para>"The WGS84 altitude of a SpatialThing (decimal meters
    /// above the local reference ellipsoid)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"altitude"</para><para>"altitude"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2003/01/geo/wgs84_pos#alt">http://www.w3.org/2003/01/geo/wgs84_pos#alt</seealso>
    let alt = Prefixed_Name(w3cgeo, "alt") |> PrefixedName
    /// <summary>
    ///   <para>w3cgeo:asWKT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"geometrie als well-known text (WKT)"</para><para>"geometry as well-known text (WKT)"</para></remarks>
    /// <seealso href="http://www.w3.org/2003/01/geo/wgs84_pos#asWKT">http://www.w3.org/2003/01/geo/wgs84_pos#asWKT</seealso>
    let asWKT = Prefixed_Name(w3cgeo, "asWKT") |> PrefixedName
    /// <summary>
    ///   <para>w3cgeo:hasGeometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has geometry"</para><para>"heeft geometrie"</para></remarks>
    /// <seealso href="http://www.w3.org/2003/01/geo/wgs84_pos#hasGeometry">http://www.w3.org/2003/01/geo/wgs84_pos#hasGeometry</seealso>
    let hasGeometry = Prefixed_Name(w3cgeo, "hasGeometry") |> PrefixedName
    /// <summary>
    ///   <para>w3cgeo:lat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The WGS84 latitude of a SpatialThing (decimal degrees)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Geographic latitude of a place."</para>
    ///   <para>"Latitud"</para>
    ///   <para>"Latitude in WGS84"</para>
    ///   <para>"The WGS84 latitude of a SpatialThing (decimal degrees)."</para>
    /// labels<para>"latitude"</para><para>"latitude"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"lattitude"</para><para>"Latitud"</para></remarks>
    /// <seealso href="http://www.w3.org/2003/01/geo/wgs84_pos#lat">http://www.w3.org/2003/01/geo/wgs84_pos#lat</seealso>
    let lat = Prefixed_Name(w3cgeo, "lat") |> PrefixedName
    /// <summary>
    ///   <para>w3cgeo:lat_long</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A comma-separated representation of a latitude, longitude coordinate."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"lat/long"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2003/01/geo/wgs84_pos#lat_long">http://www.w3.org/2003/01/geo/wgs84_pos#lat_long</seealso>
    let lat_long = Prefixed_Name(w3cgeo, "lat_long") |> PrefixedName
    /// <summary>
    ///   <para>w3cgeo:latitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2003/01/geo/wgs84_pos#latitude">http://www.w3.org/2003/01/geo/wgs84_pos#latitude</seealso>
    let latitude = Prefixed_Name(w3cgeo, "latitude") |> PrefixedName
    /// <summary>
    ///   <para>w3cgeo:location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The relation between something and the point,
    ///  or other geometrical thing in space, where it is.  For example, the realtionship between
    ///  a radio tower and a Point with a given lat and long.
    ///  Or a relationship between a park and its outline as a closed arc of points, or a road and
    ///  its location as a arc (a sequence of points).
    ///  Clearly in practice there will be limit to the accuracy of any such statement, but one would expect
    ///  an accuracy appropriate for the size of the object and uses such as mapping ."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The relation between something and the point, or other geometrical thing in space, where it is."</para>
    ///   <para>"The relation between something and the point, or other geometrical thing in space, where it is.  For example, the realtionship between a radio tower and a Point with a given lat and long. Or a relationship between a park and its outline as a closed arc of points, or a road and its location as a arc (a sequence of points). Clearly in practice there will be limit to the accuracy of any such statement, but one would expect an accuracy appropriate for the size of the object and uses such as mapping ."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The relation between something and the point,
    ///  or other geometrical thing in space, where it is.  For example, the realtionship between
    ///  a radio tower and a Point with a given lat and long.
    ///  Or a relationship between a park and its outline as a closed arc of points, or a road and
    ///  its location as a arc (a sequence of points).
    ///  Clearly in practice there will be limit to the accuracy of any such statement, but one would expect
    ///  an accuracy appropriate for the size of the object and uses such as mapping .
    ///  "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The relation between something and the point,
    ///  or other geometrical thing in space, where it is.  For example, the realtionship between
    ///  a radio tower and a Point with a given lat and long.
    ///  Or a relationship between a park and its outline as a closed arc of points, or a road and
    ///  its location as a arc (a sequence of points).
    ///  Clearly in practice there will be limit to the accuracy of any such statement, but one would expect
    ///  an accuracy appropriate for the size of the object and uses such as mapping ."</para>
    ///   <para>"The relation between something and the point,  or other geometrical thing in space, where it is.  For example, the realtionship between a radio tower and a Point with a given lat and long. Or a relationship between a park and its outline as a closed arc of points, or a road and its location as a arc (a sequence of points). Clearly in practice there will be limit to the accuracy of any such statement, but one would expect an accuracy appropriate for the size of the object and uses such as mapping ."</para>
    ///   <para>"Provides relation between object and its physical location."</para>
    ///   <para>"The relation between something and the point,
    ///  or other geometrical thing in space, where it is.  For example, the realtionship between
    ///  a radio tower and a Point with a given lat and long.
    ///  Or a relationship between a park and its outline as a closed arc of points, or a road and
    ///  its location as a arc (a sequence of points).
    ///  Clearly in practice there will be limit to the accuracy of any such statement, but one would expect
    ///  an accuracy appropriate for the size of the object and uses such as mapping .
    ///  "</para>
    ///   <para>"The relation between something and the point, or other geometrical thing in space, where it is.  For example, the relationship between a radio tower and a Point with a given lat and long. Or a relationship between a park and its outline as a closed arc of points, or a road and its location as a arc (a sequence of points). Clearly in practice there will be limit to the accuracy of any such statement, but one would expect an accuracy appropriate for the size of the object and uses such as mapping."</para>
    /// labels<para>"location"</para><para>"location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2003/01/geo/wgs84_pos#location">http://www.w3.org/2003/01/geo/wgs84_pos#location</seealso>
    let location = Prefixed_Name(w3cgeo, "location") |> PrefixedName
    /// <summary>
    ///   <para>w3cgeo:lon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Longitude in WGS84"</para>
    /// labels<para>"longitude"</para></remarks>
    /// <seealso href="http://www.w3.org/2003/01/geo/wgs84_pos#lon">http://www.w3.org/2003/01/geo/wgs84_pos#lon</seealso>
    let lon = Prefixed_Name(w3cgeo, "lon") |> PrefixedName
    /// <summary>
    ///   <para>w3cgeo:long</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The WGS84 longitude of a SpatialThing (decimal degrees)."</para>
    ///   <para>"Longitud"</para>
    ///   <para>"The WGS84 longitude of a SpatialThing (decimal degrees)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Geographic longitude of a place."</para>
    ///   <para>"The WGS84 longitude of a SpatialThing (decimal degrees)"</para>
    /// labels<para>"longitude"</para><para>"Longitud"</para><para>"longitude"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2003/01/geo/wgs84_pos#long">http://www.w3.org/2003/01/geo/wgs84_pos#long</seealso>
    let long = Prefixed_Name(w3cgeo, "long") |> PrefixedName
    /// <summary>
    ///   <para>w3cgeo:longitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2003/01/geo/wgs84_pos#longitude">http://www.w3.org/2003/01/geo/wgs84_pos#longitude</seealso>
    let longitude = Prefixed_Name(w3cgeo, "longitude") |> PrefixedName
    /// <summary>
    ///   <para>w3cgeo:wktLiteral</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2003/01/geo/wgs84_pos#wktLiteral">http://www.w3.org/2003/01/geo/wgs84_pos#wktLiteral</seealso>
    let wktLiteral = Prefixed_Name(w3cgeo, "wktLiteral") |> PrefixedName
