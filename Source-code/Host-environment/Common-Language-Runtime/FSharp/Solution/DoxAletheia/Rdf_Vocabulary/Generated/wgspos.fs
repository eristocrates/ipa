namespace http.www.w3.org._2003._01.geo.wgs84_pos.hash

open DoxAletheia

module wgspos =
    let _namespace_name = "http://www.w3.org/2003/01/geo/wgs84_pos#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A point, typically described using a coordinate system relative to Earth, such as WGS84.
    ///
    ///
    /// Uniquely identified by lat/long/alt. i.e.
    ///
    /// spaciallyIntersects(P1, P2) :- lat(P1, LAT), long(P1, LONG), alt(P1, ALT),
    ///   lat(P2, LAT), long(P2, LONG), alt(P2, ALT).
    ///
    /// sameThing(P1, P2) :- type(P1, Point), type(P2, Point), spaciallyIntersects(P1, P2).
    ///
    /// <see href="http://www.w3.org/2003/01/geo/wgs84_pos#Point"></see></summary>
    let Point = _prefix "Point"
    /// <summary>
    /// Anything with spatial extent, i.e. size, shape, or position.
    ///  e.g. people, places, bowling balls, as well as abstract areas like cubes.
    ///
    /// <see href="http://www.w3.org/2003/01/geo/wgs84_pos#SpatialThing"></see></summary>
    let SpatialThing = _prefix "SpatialThing"
    /// <summary>
    /// The WGS84 altitude of a SpatialThing (decimal meters
    /// above the local reference ellipsoid).
    /// <see href="http://www.w3.org/2003/01/geo/wgs84_pos#alt"></see></summary>
    let alt = _prefix "alt"
    /// <summary>
    /// The WGS84 latitude of a SpatialThing (decimal degrees).
    /// <see href="http://www.w3.org/2003/01/geo/wgs84_pos#lat"></see></summary>
    let lat = _prefix "lat"
    /// <summary>
    /// A comma-separated representation of a latitude, longitude coordinate.
    /// <see href="http://www.w3.org/2003/01/geo/wgs84_pos#lat_long"></see></summary>
    let lat_long = _prefix "lat_long"
    /// <summary>
    /// The relation between something and the point,
    ///  or other geometrical thing in space, where it is.  For example, the realtionship between
    ///  a radio tower and a Point with a given lat and long.
    ///  Or a relationship between a park and its outline as a closed arc of points, or a road and
    ///  its location as a arc (a sequence of points).
    ///  Clearly in practice there will be limit to the accuracy of any such statement, but one would expect
    ///  an accuracy appropriate for the size of the object and uses such as mapping .
    ///
    /// <see href="http://www.w3.org/2003/01/geo/wgs84_pos#location"></see></summary>
    let location = _prefix "location"
    /// <summary>
    /// The WGS84 longitude of a SpatialThing (decimal degrees).
    /// <see href="http://www.w3.org/2003/01/geo/wgs84_pos#long"></see></summary>
    let long = _prefix "long"
