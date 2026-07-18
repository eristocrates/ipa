namespace http.tour_pedia.org.download.tp.owl.hash

open DoxAletheia.Rdf_Vocabulary

module tp =
    let _namespace_name = "http://tour-pedia.org/download/tp.owl#"
    /// <summary>
    /// The generic class for a touristic place.
    /// <see href="http://tour-pedia.org/download/tp.owl#Place"></see></summary>
    let Place = Namespaced_IRI.parse _namespace_name "Place" |> NamespacedName

    /// <summary>
    ///   <see href="http://tour-pedia.org/download/tp.owl#Accommodation"></see>
    /// </summary>
    let Accommodation =
        Namespaced_IRI.parse _namespace_name "Accommodation" |> NamespacedName

    /// <summary>
    ///   <see href="http://tour-pedia.org/download/tp.owl#POI"></see>
    /// </summary>
    let POI = Namespaced_IRI.parse _namespace_name "POI" |> NamespacedName
    /// <summary>
    ///   <see href="http://tour-pedia.org/download/tp.owl#Restaurant"></see>
    /// </summary>
    let Restaurant = Namespaced_IRI.parse _namespace_name "Restaurant" |> NamespacedName
    /// <summary>
    ///   <see href="http://tour-pedia.org/download/tp.owl#Attraction"></see>
    /// </summary>
    let Attraction = Namespaced_IRI.parse _namespace_name "Attraction" |> NamespacedName
