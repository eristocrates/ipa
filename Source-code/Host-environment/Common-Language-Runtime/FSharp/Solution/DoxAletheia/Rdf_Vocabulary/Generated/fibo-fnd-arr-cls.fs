namespace https.spec.edmcouncil.org.fibo.ontology.FND.Arrangements.ClassificationSchemes.slash

open DoxAletheia

module fibo_fnd_arr_cls =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/ClassificationSchemes/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/ClassificationSchemes/IndustrySectorClassificationScheme"></see>
    /// </summary>
    let IndustrySectorClassificationScheme =
        _prefix "IndustrySectorClassificationScheme"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/ClassificationSchemes/IndustrySectorClassifier"></see>
    /// </summary>
    let IndustrySectorClassifier = _prefix "IndustrySectorClassifier"
