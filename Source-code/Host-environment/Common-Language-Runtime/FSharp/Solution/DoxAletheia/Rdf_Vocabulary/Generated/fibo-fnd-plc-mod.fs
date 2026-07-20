namespace https.spec.edmcouncil.org.fibo.ontology.FND.Places.MetadataFNDPlaces.slash

open DoxAletheia

module fibo_fnd_plc_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Places/MetadataFNDPlaces/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/MetadataFNDPlaces/PlacesModule"></see>
    /// </summary>
    let PlacesModule = _prefix "PlacesModule"
