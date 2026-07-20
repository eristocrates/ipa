namespace https.spec.edmcouncil.org.fibo.ontology.FND.Relations.Relations.slash

open DoxAletheia

module fibo_fnd_rel_rel =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/Referent"></see>
    /// </summary>
    let Referent = _prefix "Referent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/causes"></see>
    /// </summary>
    let causes = _prefix "causes"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/confers"></see>
    /// </summary>
    let confers = _prefix "confers"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/controls"></see>
    /// </summary>
    let controls = _prefix "controls"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/embodies"></see>
    /// </summary>
    let embodies = _prefix "embodies"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/evaluates"></see>
    /// </summary>
    let evaluates = _prefix "evaluates"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/exchanges"></see>
    /// </summary>
    let exchanges = _prefix "exchanges"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/exemplifies"></see>
    /// </summary>
    let exemplifies = _prefix "exemplifies"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/generates"></see>
    /// </summary>
    let generates = _prefix "generates"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/hasAlias"></see>
    /// </summary>
    let hasAlias = _prefix "hasAlias"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/hasCommonName"></see>
    /// </summary>
    let hasCommonName = _prefix "hasCommonName"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/hasDesignation"></see>
    /// </summary>
    let hasDesignation = _prefix "hasDesignation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/hasFormalName"></see>
    /// </summary>
    let hasFormalName = _prefix "hasFormalName"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/hasLegalName"></see>
    /// </summary>
    let hasLegalName = _prefix "hasLegalName"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/hasTag"></see>
    /// </summary>
    let hasTag = _prefix "hasTag"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/holds"></see>
    /// </summary>
    let holds = _prefix "holds"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/involves"></see>
    /// </summary>
    let involves = _prefix "involves"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isCausedBy"></see>
    /// </summary>
    let isCausedBy = _prefix "isCausedBy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isConferredBy"></see>
    /// </summary>
    let isConferredBy = _prefix "isConferredBy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isControlledBy"></see>
    /// </summary>
    let isControlledBy = _prefix "isControlledBy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isEvaluatedBy"></see>
    /// </summary>
    let isEvaluatedBy = _prefix "isEvaluatedBy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isExemplifiedBy"></see>
    /// </summary>
    let isExemplifiedBy = _prefix "isExemplifiedBy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isGeneratedBy"></see>
    /// </summary>
    let isGeneratedBy = _prefix "isGeneratedBy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isHeldBy"></see>
    /// </summary>
    let isHeldBy = _prefix "isHeldBy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isIssuedBy"></see>
    /// </summary>
    let isIssuedBy = _prefix "isIssuedBy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isMandatedBy"></see>
    /// </summary>
    let isMandatedBy = _prefix "isMandatedBy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/isProducedBy"></see>
    /// </summary>
    let isProducedBy = _prefix "isProducedBy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/produces"></see>
    /// </summary>
    let produces = _prefix "produces"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/issues"></see>
    /// </summary>
    let issues = _prefix "issues"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/mandates"></see>
    /// </summary>
    let mandates = _prefix "mandates"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/wasFormerlyKnownAs"></see>
    /// </summary>
    let wasFormerlyKnownAs = _prefix "wasFormerlyKnownAs"
