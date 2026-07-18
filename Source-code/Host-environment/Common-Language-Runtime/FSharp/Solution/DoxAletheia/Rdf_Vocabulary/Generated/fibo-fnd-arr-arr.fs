namespace https.spec.edmcouncil.org.fibo.ontology.FND.Arrangements.Arrangements.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_arr_arr =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Arrangements/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Arrangements/Scheme"></see>
    /// </summary>
    let Scheme = Namespaced_IRI.parse _namespace_name "Scheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Arrangements/hasCollectionSize"></see>
    /// </summary>
    let hasCollectionSize =
        Namespaced_IRI.parse _namespace_name "hasCollectionSize" |> NamespacedName
