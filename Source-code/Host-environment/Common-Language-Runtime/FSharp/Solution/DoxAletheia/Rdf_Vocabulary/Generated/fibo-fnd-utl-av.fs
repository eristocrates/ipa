namespace https.spec.edmcouncil.org.fibo.ontology.FND.Utilities.AnnotationVocabulary.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_utl_av =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/hasMaturityLevel"></see>
    /// </summary>
    let hasMaturityLevel =
        Namespaced_IRI.parse _namespace_name "hasMaturityLevel" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/Release"></see>
    /// </summary>
    let Release = Namespaced_IRI.parse _namespace_name "Release" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/Informative"></see>
    /// </summary>
    let Informative =
        Namespaced_IRI.parse _namespace_name "Informative" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/MaturityLevel"></see>
    /// </summary>
    let MaturityLevel =
        Namespaced_IRI.parse _namespace_name "MaturityLevel" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/Module"></see>
    /// </summary>
    let Module = Namespaced_IRI.parse _namespace_name "Module" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/Provisional"></see>
    /// </summary>
    let Provisional =
        Namespaced_IRI.parse _namespace_name "Provisional" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/commonDesignation"></see>
    /// </summary>
    let commonDesignation =
        Namespaced_IRI.parse _namespace_name "commonDesignation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/definitionOrigin"></see>
    /// </summary>
    let definitionOrigin =
        Namespaced_IRI.parse _namespace_name "definitionOrigin" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/preferredDesignation"></see>
    /// </summary>
    let preferredDesignation =
        Namespaced_IRI.parse _namespace_name "preferredDesignation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/termOrigin"></see>
    /// </summary>
    let termOrigin = Namespaced_IRI.parse _namespace_name "termOrigin" |> NamespacedName
