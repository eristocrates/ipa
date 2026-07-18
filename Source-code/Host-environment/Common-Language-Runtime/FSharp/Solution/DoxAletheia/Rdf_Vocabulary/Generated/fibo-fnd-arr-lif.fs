namespace https.spec.edmcouncil.org.fibo.ontology.FND.Arrangements.Lifecycles.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_arr_lif =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/Lifecycle"></see>
    /// </summary>
    let Lifecycle = Namespaced_IRI.parse _namespace_name "Lifecycle" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/hasStage"></see>
    /// </summary>
    let hasStage = Namespaced_IRI.parse _namespace_name "hasStage" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/LifecycleStage"></see>
    /// </summary>
    let LifecycleStage =
        Namespaced_IRI.parse _namespace_name "LifecycleStage" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/isLifecycleOf"></see>
    /// </summary>
    let isLifecycleOf =
        Namespaced_IRI.parse _namespace_name "isLifecycleOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/LifecycleEvent"></see>
    /// </summary>
    let LifecycleEvent =
        Namespaced_IRI.parse _namespace_name "LifecycleEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/LifecycleEventOccurrence"></see>
    /// </summary>
    let LifecycleEventOccurrence =
        Namespaced_IRI.parse _namespace_name "LifecycleEventOccurrence" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/LifecycleStageOccurrence"></see>
    /// </summary>
    let LifecycleStageOccurrence =
        Namespaced_IRI.parse _namespace_name "LifecycleStageOccurrence" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/LifecycleOccurrence"></see>
    /// </summary>
    let LifecycleOccurrence =
        Namespaced_IRI.parse _namespace_name "LifecycleOccurrence" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/isStageOf"></see>
    /// </summary>
    let isStageOf = Namespaced_IRI.parse _namespace_name "isStageOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/LifecycleStatus"></see>
    /// </summary>
    let LifecycleStatus =
        Namespaced_IRI.parse _namespace_name "LifecycleStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/hasLifecycle"></see>
    /// </summary>
    let hasLifecycle =
        Namespaced_IRI.parse _namespace_name "hasLifecycle" |> NamespacedName
