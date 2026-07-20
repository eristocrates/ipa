namespace https.spec.edmcouncil.org.fibo.ontology.FND.Arrangements.Lifecycles.slash

open DoxAletheia

module fibo_fnd_arr_lif =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/Lifecycle"></see>
    /// </summary>
    let Lifecycle = _prefix "Lifecycle"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/hasStage"></see>
    /// </summary>
    let hasStage = _prefix "hasStage"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/LifecycleStage"></see>
    /// </summary>
    let LifecycleStage = _prefix "LifecycleStage"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/isLifecycleOf"></see>
    /// </summary>
    let isLifecycleOf = _prefix "isLifecycleOf"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/LifecycleEvent"></see>
    /// </summary>
    let LifecycleEvent = _prefix "LifecycleEvent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/LifecycleEventOccurrence"></see>
    /// </summary>
    let LifecycleEventOccurrence = _prefix "LifecycleEventOccurrence"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/LifecycleStageOccurrence"></see>
    /// </summary>
    let LifecycleStageOccurrence = _prefix "LifecycleStageOccurrence"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/LifecycleOccurrence"></see>
    /// </summary>
    let LifecycleOccurrence = _prefix "LifecycleOccurrence"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/isStageOf"></see>
    /// </summary>
    let isStageOf = _prefix "isStageOf"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/LifecycleStatus"></see>
    /// </summary>
    let LifecycleStatus = _prefix "LifecycleStatus"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/hasLifecycle"></see>
    /// </summary>
    let hasLifecycle = _prefix "hasLifecycle"
