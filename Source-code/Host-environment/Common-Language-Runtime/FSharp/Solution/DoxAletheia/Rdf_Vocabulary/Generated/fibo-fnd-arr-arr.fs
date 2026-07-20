namespace https.spec.edmcouncil.org.fibo.ontology.FND.Arrangements.Arrangements.slash

open DoxAletheia

module fibo_fnd_arr_arr =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Arrangements/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Arrangements/Scheme"></see>
    /// </summary>
    let Scheme = _prefix "Scheme"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Arrangements/hasCollectionSize"></see>
    /// </summary>
    let hasCollectionSize = _prefix "hasCollectionSize"
