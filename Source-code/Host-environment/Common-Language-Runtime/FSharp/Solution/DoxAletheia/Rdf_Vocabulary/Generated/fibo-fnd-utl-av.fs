namespace https.spec.edmcouncil.org.fibo.ontology.FND.Utilities.AnnotationVocabulary.slash

open DoxAletheia

module fibo_fnd_utl_av =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/hasMaturityLevel"></see>
    /// </summary>
    let hasMaturityLevel = _prefix "hasMaturityLevel"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/Release"></see>
    /// </summary>
    let Release = _prefix "Release"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/Informative"></see>
    /// </summary>
    let Informative = _prefix "Informative"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/MaturityLevel"></see>
    /// </summary>
    let MaturityLevel = _prefix "MaturityLevel"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/Module"></see>
    /// </summary>
    let Module = _prefix "Module"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/Provisional"></see>
    /// </summary>
    let Provisional = _prefix "Provisional"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/commonDesignation"></see>
    /// </summary>
    let commonDesignation = _prefix "commonDesignation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/definitionOrigin"></see>
    /// </summary>
    let definitionOrigin = _prefix "definitionOrigin"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/preferredDesignation"></see>
    /// </summary>
    let preferredDesignation = _prefix "preferredDesignation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/termOrigin"></see>
    /// </summary>
    let termOrigin = _prefix "termOrigin"
