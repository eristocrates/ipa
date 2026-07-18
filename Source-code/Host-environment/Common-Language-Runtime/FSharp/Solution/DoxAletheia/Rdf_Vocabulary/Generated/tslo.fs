namespace http.tracker.api.gnome.org.ontology.v3.slo.hash

open DoxAletheia.Rdf_Vocabulary

module tslo =
    let _namespace_name = "http://tracker.api.gnome.org/ontology/v3/slo#"

    /// <summary>
    /// A place in the space, can be defined by coordinates or text
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#GeoLocation"></see></summary>
    let GeoLocation =
        Namespaced_IRI.parse _namespace_name "GeoLocation" |> NamespacedName

    /// <summary>
    /// Use the nie title, description, ... properties
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#Landmark"></see></summary>
    let Landmark = Namespaced_IRI.parse _namespace_name "Landmark" |> NamespacedName

    /// <summary>
    /// Predefined set of instances for categories of landmarks
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#LandmarkCategory"></see></summary>
    let LandmarkCategory =
        Namespaced_IRI.parse _namespace_name "LandmarkCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/slo#Route"></see>
    /// </summary>
    let Route = Namespaced_IRI.parse _namespace_name "Route" |> NamespacedName
    /// <summary>
    /// Altitude following WGS 84 reference
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#altitude"></see></summary>
    let altitude = Namespaced_IRI.parse _namespace_name "altitude" |> NamespacedName

    /// <summary>
    /// Relation of a landmark with a landmark category
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#belongsToCategory"></see></summary>
    let belongsToCategory =
        Namespaced_IRI.parse _namespace_name "belongsToCategory" |> NamespacedName

    /// <summary>
    /// Northern latitude of the bounding box
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#boundingLatitudeMax"></see></summary>
    let boundingLatitudeMax =
        Namespaced_IRI.parse _namespace_name "boundingLatitudeMax" |> NamespacedName

    /// <summary>
    /// Southern latitude of the bounding box
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#boundingLatitudeMin"></see></summary>
    let boundingLatitudeMin =
        Namespaced_IRI.parse _namespace_name "boundingLatitudeMin" |> NamespacedName

    /// <summary>
    /// Eastern longitude of the bounding box
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#boundingLongitudeMax"></see></summary>
    let boundingLongitudeMax =
        Namespaced_IRI.parse _namespace_name "boundingLongitudeMax" |> NamespacedName

    /// <summary>
    /// Western longitude of the bounding box
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#boundingLongitudeMin"></see></summary>
    let boundingLongitudeMin =
        Namespaced_IRI.parse _namespace_name "boundingLongitudeMin" |> NamespacedName

    /// <summary>
    /// Url of the icon that corresponds to this category.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#categoryIconUrl"></see></summary>
    let categoryIconUrl =
        Namespaced_IRI.parse _namespace_name "categoryIconUrl" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/slo#endTime"></see>
    /// </summary>
    let endTime = Namespaced_IRI.parse _namespace_name "endTime" |> NamespacedName
    /// <summary>
    /// The contact information of the landmark in question
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#hasContact"></see></summary>
    let hasContact = Namespaced_IRI.parse _namespace_name "hasContact" |> NamespacedName

    /// <summary>
    /// Represents the error estimate of horizontal (earths-surface) accuracy in meters.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#horizontalAccuracy"></see></summary>
    let horizontalAccuracy =
        Namespaced_IRI.parse _namespace_name "horizontalAccuracy" |> NamespacedName

    /// <summary>
    /// Url of the icon that corresponds to this landmark.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#iconUrl"></see></summary>
    let iconUrl = Namespaced_IRI.parse _namespace_name "iconUrl" |> NamespacedName

    /// <summary>
    /// Flag to indicate if this instance is removable. This restriction is not enforced by tracker; it is API responsability to honor the value
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#isRemovable"></see></summary>
    let isRemovable =
        Namespaced_IRI.parse _namespace_name "isRemovable" |> NamespacedName

    /// <summary>
    /// Positive values for the north hemisphere, negative for the south
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#latitude"></see></summary>
    let latitude = Namespaced_IRI.parse _namespace_name "latitude" |> NamespacedName
    /// <summary>
    /// This can be subclassed to add semantics
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#location"></see></summary>
    let location = Namespaced_IRI.parse _namespace_name "location" |> NamespacedName
    /// <summary>
    /// Positive to the East of the Greenwich meridian, negative to the West (following WGS-84)
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#longitude"></see></summary>
    let longitude = Namespaced_IRI.parse _namespace_name "longitude" |> NamespacedName

    /// <summary>
    /// Representation of the location as text address
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#postalAddress"></see></summary>
    let postalAddress =
        Namespaced_IRI.parse _namespace_name "postalAddress" |> NamespacedName

    /// <summary>
    /// Radius from the center to define an area. Some applications can use it in 2D sense, making then a circle instead of a sphere
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#radius"></see></summary>
    let radius = Namespaced_IRI.parse _namespace_name "radius" |> NamespacedName

    /// <summary>
    /// FIXME Domain can be resource if we handle map-files correctly in the ontology
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#routeDetails"></see></summary>
    let routeDetails =
        Namespaced_IRI.parse _namespace_name "routeDetails" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/slo#startTime"></see>
    /// </summary>
    let startTime = Namespaced_IRI.parse _namespace_name "startTime" |> NamespacedName
    /// <summary>
    /// Timestamp when the geolocation is referenced. Create subproperties for certain use cases
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#timestamp"></see></summary>
    let timestamp = Namespaced_IRI.parse _namespace_name "timestamp" |> NamespacedName

    /// <summary>
    /// Represents the error estimate of vertical (earths-surface) accuracy in meters.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/slo#verticalAccuracy"></see></summary>
    let verticalAccuracy =
        Namespaced_IRI.parse _namespace_name "verticalAccuracy" |> NamespacedName
