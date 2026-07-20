namespace http.tracker.api.gnome.org.ontology.v3.slo.hash

open DoxAletheia

module tslo =
    let _namespace_name = "http://tracker.api.gnome.org/ontology/v3/slo#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A place in the space, can be defined by coordinates or text
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#GeoLocation"></see></summary>
    let GeoLocation = _prefix "GeoLocation"
    /// <summary>
    /// Use the nie title, description, ... properties
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#Landmark"></see></summary>
    let Landmark = _prefix "Landmark"
    /// <summary>
    /// Predefined set of instances for categories of landmarks
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#LandmarkCategory"></see></summary>
    let LandmarkCategory = _prefix "LandmarkCategory"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/slo#Route"></see>
    /// </summary>
    let Route = _prefix "Route"
    /// <summary>
    /// Altitude following WGS 84 reference
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#altitude"></see></summary>
    let altitude = _prefix "altitude"
    /// <summary>
    /// Relation of a landmark with a landmark category
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#belongsToCategory"></see></summary>
    let belongsToCategory = _prefix "belongsToCategory"
    /// <summary>
    /// Northern latitude of the bounding box
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#boundingLatitudeMax"></see></summary>
    let boundingLatitudeMax = _prefix "boundingLatitudeMax"
    /// <summary>
    /// Southern latitude of the bounding box
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#boundingLatitudeMin"></see></summary>
    let boundingLatitudeMin = _prefix "boundingLatitudeMin"
    /// <summary>
    /// Eastern longitude of the bounding box
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#boundingLongitudeMax"></see></summary>
    let boundingLongitudeMax = _prefix "boundingLongitudeMax"
    /// <summary>
    /// Western longitude of the bounding box
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#boundingLongitudeMin"></see></summary>
    let boundingLongitudeMin = _prefix "boundingLongitudeMin"
    /// <summary>
    /// Url of the icon that corresponds to this category.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#categoryIconUrl"></see></summary>
    let categoryIconUrl = _prefix "categoryIconUrl"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/slo#endTime"></see>
    /// </summary>
    let endTime = _prefix "endTime"
    /// <summary>
    /// The contact information of the landmark in question
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#hasContact"></see></summary>
    let hasContact = _prefix "hasContact"
    /// <summary>
    /// Represents the error estimate of horizontal (earths-surface) accuracy in meters.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#horizontalAccuracy"></see></summary>
    let horizontalAccuracy = _prefix "horizontalAccuracy"
    /// <summary>
    /// Url of the icon that corresponds to this landmark.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#iconUrl"></see></summary>
    let iconUrl = _prefix "iconUrl"
    /// <summary>
    /// Flag to indicate if this instance is removable. This restriction is not enforced by tracker; it is API responsability to honor the value
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#isRemovable"></see></summary>
    let isRemovable = _prefix "isRemovable"
    /// <summary>
    /// Positive values for the north hemisphere, negative for the south
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#latitude"></see></summary>
    let latitude = _prefix "latitude"
    /// <summary>
    /// This can be subclassed to add semantics
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#location"></see></summary>
    let location = _prefix "location"
    /// <summary>
    /// Positive to the East of the Greenwich meridian, negative to the West (following WGS-84)
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#longitude"></see></summary>
    let longitude = _prefix "longitude"
    /// <summary>
    /// Representation of the location as text address
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#postalAddress"></see></summary>
    let postalAddress = _prefix "postalAddress"
    /// <summary>
    /// Radius from the center to define an area. Some applications can use it in 2D sense, making then a circle instead of a sphere
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#radius"></see></summary>
    let radius = _prefix "radius"
    /// <summary>
    /// FIXME Domain can be resource if we handle map-files correctly in the ontology
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#routeDetails"></see></summary>
    let routeDetails = _prefix "routeDetails"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/slo#startTime"></see>
    /// </summary>
    let startTime = _prefix "startTime"
    /// <summary>
    /// Timestamp when the geolocation is referenced. Create subproperties for certain use cases
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#timestamp"></see></summary>
    let timestamp = _prefix "timestamp"
    /// <summary>
    /// Represents the error estimate of vertical (earths-surface) accuracy in meters.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#verticalAccuracy"></see></summary>
    let verticalAccuracy = _prefix "verticalAccuracy"
