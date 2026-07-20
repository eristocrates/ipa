namespace https.spec.edmcouncil.org.fibo.ontology.FND.Arrangements.MetadataFNDArrangements.slash

open DoxAletheia

module fibo_fnd_arr_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/MetadataFNDArrangements/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/MetadataFNDArrangements/ArrangementsModule"></see>
    /// </summary>
    let ArrangementsModule = _prefix "ArrangementsModule"
