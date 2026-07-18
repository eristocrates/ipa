namespace https.spec.edmcouncil.org.fibo.ontology.FND.Arrangements.ClassificationSchemes.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_arr_cls =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/ClassificationSchemes/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/ClassificationSchemes/IndustrySectorClassificationScheme"></see>
    /// </summary>
    let IndustrySectorClassificationScheme =
        Namespaced_IRI.parse _namespace_name "IndustrySectorClassificationScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/ClassificationSchemes/IndustrySectorClassifier"></see>
    /// </summary>
    let IndustrySectorClassifier =
        Namespaced_IRI.parse _namespace_name "IndustrySectorClassifier" |> NamespacedName
