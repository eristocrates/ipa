namespace https.spec.edmcouncil.org.fibo.ontology.FND.Arrangements.MetadataFNDArrangements.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_arr_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/MetadataFNDArrangements/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/MetadataFNDArrangements/ArrangementsModule"></see>
    /// </summary>
    let ArrangementsModule =
        Namespaced_IRI.parse _namespace_name "ArrangementsModule" |> NamespacedName
