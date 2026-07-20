namespace http.tour_pedia.org.download.tp.owl.hash

open DoxAletheia

module tp =
    let _namespace_name = "http://tour-pedia.org/download/tp.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The generic class for a touristic place.
    /// <see href="http://tour-pedia.org/download/tp.owl#Place"></see></summary>
    let Place = _prefix "Place"
    /// <summary>
    ///   <see href="http://tour-pedia.org/download/tp.owl#Accommodation"></see>
    /// </summary>
    let Accommodation = _prefix "Accommodation"
    /// <summary>
    ///   <see href="http://tour-pedia.org/download/tp.owl#POI"></see>
    /// </summary>
    let POI = _prefix "POI"
    /// <summary>
    ///   <see href="http://tour-pedia.org/download/tp.owl#Restaurant"></see>
    /// </summary>
    let Restaurant = _prefix "Restaurant"
    /// <summary>
    ///   <see href="http://tour-pedia.org/download/tp.owl#Attraction"></see>
    /// </summary>
    let Attraction = _prefix "Attraction"
