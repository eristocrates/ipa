namespace https.spec.edmcouncil.org.fibo.ontology.FND.Places.MetadataFNDPlaces.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_plc_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Places/MetadataFNDPlaces/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Places/MetadataFNDPlaces/PlacesModule"></see>
    /// </summary>
    let PlacesModule =
        Namespaced_IRI.parse _namespace_name "PlacesModule" |> NamespacedName
