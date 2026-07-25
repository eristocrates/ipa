namespace http.tracker.api.gnome.org.ontology.v3.slo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tslo =
    let _namespace_iri = Namespace_Iri tslo |> NamespaceIRI
    /// <summary>
    ///   <para>tslo:Landmark</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Use the nie title, description, ... properties</para>
    /// labels<para>Point with special relevance for the user</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/slo#Landmark">http://tracker.api.gnome.org/ontology/v3/slo#Landmark</seealso>
    let Landmark = Prefixed_Name(tslo, "Landmark") |> PrefixedName
    /// <summary>
    ///   <para>tslo:Route</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Minimum box containing all the points traversed in route</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/slo#Route">http://tracker.api.gnome.org/ontology/v3/slo#Route</seealso>
    let Route = Prefixed_Name(tslo, "Route") |> PrefixedName
    /// <summary>
    ///   <para>tslo:belongsToCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Relation of a landmark with a landmark category</para>
    /// labels<para>Belongs to category</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/slo#belongsToCategory">http://tracker.api.gnome.org/ontology/v3/slo#belongsToCategory</seealso>
    let belongsToCategory = Prefixed_Name(tslo, "belongsToCategory") |> PrefixedName
    /// <summary>
    ///   <para>tslo:GeoLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A place in the space, can be defined by coordinates or text</para>
    /// labels<para>Location</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/slo#GeoLocation">http://tracker.api.gnome.org/ontology/v3/slo#GeoLocation</seealso>
    let GeoLocation = Prefixed_Name(tslo, "GeoLocation") |> PrefixedName

    /// <summary>
    ///   <para>tslo:boundingLongitudeMin</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Western longitude of the bounding box</para>
    /// labels<para>Longitude</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/slo#boundingLongitudeMin">http://tracker.api.gnome.org/ontology/v3/slo#boundingLongitudeMin</seealso>
    let boundingLongitudeMin =
        Prefixed_Name(tslo, "boundingLongitudeMin") |> PrefixedName

    /// <summary>
    ///   <para>tslo:hasContact</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The contact information of the landmark in question</para>
    /// labels<para>Landmark contact information</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/slo#hasContact">http://tracker.api.gnome.org/ontology/v3/slo#hasContact</seealso>
    let hasContact = Prefixed_Name(tslo, "hasContact") |> PrefixedName
    /// <summary>
    ///   <para>tslo:LandmarkCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Predefined set of instances for categories of landmarks</para>
    /// labels<para>Landmark category</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/slo#LandmarkCategory">http://tracker.api.gnome.org/ontology/v3/slo#LandmarkCategory</seealso>
    let LandmarkCategory = Prefixed_Name(tslo, "LandmarkCategory") |> PrefixedName
    /// <summary>
    ///   <para>tslo:altitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Altitude following WGS 84 reference</para>
    /// labels<para>Altitude</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/slo#altitude">http://tracker.api.gnome.org/ontology/v3/slo#altitude</seealso>
    let altitude = Prefixed_Name(tslo, "altitude") |> PrefixedName
    /// <summary>
    ///   <para>tslo:boundingLatitudeMax</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Northern latitude of the bounding box</para>
    /// labels<para>Latitude</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/slo#boundingLatitudeMax">http://tracker.api.gnome.org/ontology/v3/slo#boundingLatitudeMax</seealso>
    let boundingLatitudeMax = Prefixed_Name(tslo, "boundingLatitudeMax") |> PrefixedName
    /// <summary>
    ///   <para>tslo:boundingLatitudeMin</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Southern latitude of the bounding box</para>
    /// labels<para>Latitude</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/slo#boundingLatitudeMin">http://tracker.api.gnome.org/ontology/v3/slo#boundingLatitudeMin</seealso>
    let boundingLatitudeMin = Prefixed_Name(tslo, "boundingLatitudeMin") |> PrefixedName

    /// <summary>
    ///   <para>tslo:boundingLongitudeMax</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Eastern longitude of the bounding box</para>
    /// labels<para>Longitude</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/slo#boundingLongitudeMax">http://tracker.api.gnome.org/ontology/v3/slo#boundingLongitudeMax</seealso>
    let boundingLongitudeMax =
        Prefixed_Name(tslo, "boundingLongitudeMax") |> PrefixedName

    /// <summary>
    ///   <para>tslo:categoryIconUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Url of the icon that corresponds to this category.</para>
    /// labels<para>Landmark category icon</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/slo#categoryIconUrl">http://tracker.api.gnome.org/ontology/v3/slo#categoryIconUrl</seealso>
    let categoryIconUrl = Prefixed_Name(tslo, "categoryIconUrl") |> PrefixedName
    /// <summary>
    ///   <para>tslo:iconUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Url of the icon that corresponds to this landmark.</para>
    /// labels<para>Landmark icon</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/slo#iconUrl">http://tracker.api.gnome.org/ontology/v3/slo#iconUrl</seealso>
    let iconUrl = Prefixed_Name(tslo, "iconUrl") |> PrefixedName
    /// <summary>
    ///   <para>tslo:endTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Time when the last point in the route was saved</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/slo#endTime">http://tracker.api.gnome.org/ontology/v3/slo#endTime</seealso>
    let endTime = Prefixed_Name(tslo, "endTime") |> PrefixedName
    /// <summary>
    ///   <para>tslo:horizontalAccuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Represents the error estimate of horizontal (earths-surface) accuracy in meters.</para>
    /// labels<para>Longitude</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/slo#horizontalAccuracy">http://tracker.api.gnome.org/ontology/v3/slo#horizontalAccuracy</seealso>
    let horizontalAccuracy = Prefixed_Name(tslo, "horizontalAccuracy") |> PrefixedName
    /// <summary>
    ///   <para>tslo:isRemovable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Flag to indicate if this instance is removable. This restriction is not enforced by tracker; it is API responsability to honor the value</para>
    /// labels<para>Is removable</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/slo#isRemovable">http://tracker.api.gnome.org/ontology/v3/slo#isRemovable</seealso>
    let isRemovable = Prefixed_Name(tslo, "isRemovable") |> PrefixedName
    /// <summary>
    ///   <para>tslo:latitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Positive values for the north hemisphere, negative for the south</para>
    /// labels<para>Latitude</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/slo#latitude">http://tracker.api.gnome.org/ontology/v3/slo#latitude</seealso>
    let latitude = Prefixed_Name(tslo, "latitude") |> PrefixedName
    /// <summary>
    ///   <para>tslo:location</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This can be subclassed to add semantics</para>
    /// labels<para>Property linking something to a location</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/slo#location">http://tracker.api.gnome.org/ontology/v3/slo#location</seealso>
    let location = Prefixed_Name(tslo, "location") |> PrefixedName
    /// <summary>
    ///   <para>tslo:longitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Positive to the East of the Greenwich meridian, negative to the West (following WGS-84)</para>
    /// labels<para>Longitude</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/slo#longitude">http://tracker.api.gnome.org/ontology/v3/slo#longitude</seealso>
    let longitude = Prefixed_Name(tslo, "longitude") |> PrefixedName
    /// <summary>
    ///   <para>tslo:postalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Representation of the location as text address</para>
    /// labels<para>As postal address</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/slo#postalAddress">http://tracker.api.gnome.org/ontology/v3/slo#postalAddress</seealso>
    let postalAddress = Prefixed_Name(tslo, "postalAddress") |> PrefixedName
    /// <summary>
    ///   <para>tslo:radius</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Radius from the center to define an area. Some applications can use it in 2D sense, making then a circle instead of a sphere</para>
    /// labels<para>Radius</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/slo#radius">http://tracker.api.gnome.org/ontology/v3/slo#radius</seealso>
    let radius = Prefixed_Name(tslo, "radius") |> PrefixedName
    /// <summary>
    ///   <para>tslo:timestamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Timestamp when the geolocation is referenced. Create subproperties for certain use cases</para>
    /// labels<para>Timestamp</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/slo#timestamp">http://tracker.api.gnome.org/ontology/v3/slo#timestamp</seealso>
    let timestamp = Prefixed_Name(tslo, "timestamp") |> PrefixedName
    /// <summary>
    ///   <para>tslo:routeDetails</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>FIXME Domain can be resource if we handle map-files correctly in the ontology</para>
    /// labels<para>Pointer to a file containing route details (e.g. KML file).</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/slo#routeDetails">http://tracker.api.gnome.org/ontology/v3/slo#routeDetails</seealso>
    let routeDetails = Prefixed_Name(tslo, "routeDetails") |> PrefixedName
    /// <summary>
    ///   <para>tslo:startTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Time when the first point in the route was saved</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/slo#startTime">http://tracker.api.gnome.org/ontology/v3/slo#startTime</seealso>
    let startTime = Prefixed_Name(tslo, "startTime") |> PrefixedName
    /// <summary>
    ///   <para>tslo:verticalAccuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Represents the error estimate of vertical (earths-surface) accuracy in meters.</para>
    /// labels<para>Latitude</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/slo#verticalAccuracy">http://tracker.api.gnome.org/ontology/v3/slo#verticalAccuracy</seealso>
    let verticalAccuracy = Prefixed_Name(tslo, "verticalAccuracy") |> PrefixedName
    /// <summary>
    ///   <para>tslo:</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnrl:Ontology</para>
    ///   <para>tnrl:Namespace</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/slo#">http://tracker.api.gnome.org/ontology/v3/slo#</seealso>
    let _prefix_iri = Prefixed_Name(tslo, "") |> PrefixedName
