namespace https.spec.edmcouncil.org.fibo.ontology.FND.Relations.Relations.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_rel_rel =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/Referent"></see>
    /// </summary>
    let Referent = Namespaced_IRI.parse _namespace_name "Referent" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/causes"></see>
    /// </summary>
    let causes = Namespaced_IRI.parse _namespace_name "causes" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/confers"></see>
    /// </summary>
    let confers = Namespaced_IRI.parse _namespace_name "confers" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/controls"></see>
    /// </summary>
    let controls = Namespaced_IRI.parse _namespace_name "controls" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/embodies"></see>
    /// </summary>
    let embodies = Namespaced_IRI.parse _namespace_name "embodies" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/evaluates"></see>
    /// </summary>
    let evaluates = Namespaced_IRI.parse _namespace_name "evaluates" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/exchanges"></see>
    /// </summary>
    let exchanges = Namespaced_IRI.parse _namespace_name "exchanges" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/exemplifies"></see>
    /// </summary>
    let exemplifies =
        Namespaced_IRI.parse _namespace_name "exemplifies" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/generates"></see>
    /// </summary>
    let generates = Namespaced_IRI.parse _namespace_name "generates" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/hasAlias"></see>
    /// </summary>
    let hasAlias = Namespaced_IRI.parse _namespace_name "hasAlias" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/hasCommonName"></see>
    /// </summary>
    let hasCommonName =
        Namespaced_IRI.parse _namespace_name "hasCommonName" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/hasDesignation"></see>
    /// </summary>
    let hasDesignation =
        Namespaced_IRI.parse _namespace_name "hasDesignation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/hasFormalName"></see>
    /// </summary>
    let hasFormalName =
        Namespaced_IRI.parse _namespace_name "hasFormalName" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/hasLegalName"></see>
    /// </summary>
    let hasLegalName =
        Namespaced_IRI.parse _namespace_name "hasLegalName" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/hasTag"></see>
    /// </summary>
    let hasTag = Namespaced_IRI.parse _namespace_name "hasTag" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/holds"></see>
    /// </summary>
    let holds = Namespaced_IRI.parse _namespace_name "holds" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/involves"></see>
    /// </summary>
    let involves = Namespaced_IRI.parse _namespace_name "involves" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isCausedBy"></see>
    /// </summary>
    let isCausedBy = Namespaced_IRI.parse _namespace_name "isCausedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isConferredBy"></see>
    /// </summary>
    let isConferredBy =
        Namespaced_IRI.parse _namespace_name "isConferredBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isControlledBy"></see>
    /// </summary>
    let isControlledBy =
        Namespaced_IRI.parse _namespace_name "isControlledBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isEvaluatedBy"></see>
    /// </summary>
    let isEvaluatedBy =
        Namespaced_IRI.parse _namespace_name "isEvaluatedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isExemplifiedBy"></see>
    /// </summary>
    let isExemplifiedBy =
        Namespaced_IRI.parse _namespace_name "isExemplifiedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isGeneratedBy"></see>
    /// </summary>
    let isGeneratedBy =
        Namespaced_IRI.parse _namespace_name "isGeneratedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isHeldBy"></see>
    /// </summary>
    let isHeldBy = Namespaced_IRI.parse _namespace_name "isHeldBy" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isIssuedBy"></see>
    /// </summary>
    let isIssuedBy = Namespaced_IRI.parse _namespace_name "isIssuedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isMandatedBy"></see>
    /// </summary>
    let isMandatedBy =
        Namespaced_IRI.parse _namespace_name "isMandatedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isProducedBy"></see>
    /// </summary>
    let isProducedBy =
        Namespaced_IRI.parse _namespace_name "isProducedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/produces"></see>
    /// </summary>
    let produces = Namespaced_IRI.parse _namespace_name "produces" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/issues"></see>
    /// </summary>
    let issues = Namespaced_IRI.parse _namespace_name "issues" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/mandates"></see>
    /// </summary>
    let mandates = Namespaced_IRI.parse _namespace_name "mandates" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/wasFormerlyKnownAs"></see>
    /// </summary>
    let wasFormerlyKnownAs =
        Namespaced_IRI.parse _namespace_name "wasFormerlyKnownAs" |> NamespacedName
