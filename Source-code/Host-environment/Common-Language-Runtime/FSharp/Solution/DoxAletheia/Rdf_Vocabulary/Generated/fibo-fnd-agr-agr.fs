namespace https.spec.edmcouncil.org.fibo.ontology.FND.Agreements.Agreements.slash

open DoxAletheia

module fibo_fnd_agr_agr =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/Agreement"></see>
    /// </summary>
    let Agreement = _prefix "Agreement"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/Commitment"></see>
    /// </summary>
    let Commitment = _prefix "Commitment"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/Beneficiary"></see>
    /// </summary>
    let Beneficiary = _prefix "Beneficiary"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/BilateralAgreement"></see>
    /// </summary>
    let BilateralAgreement = _prefix "BilateralAgreement"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/CommitmentAtLarge"></see>
    /// </summary>
    let CommitmentAtLarge = _prefix "CommitmentAtLarge"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/UnilateralCommitment"></see>
    /// </summary>
    let UnilateralCommitment = _prefix "UnilateralCommitment"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/IndividualUnilateralCommitment"></see>
    /// </summary>
    let IndividualUnilateralCommitment = _prefix "IndividualUnilateralCommitment"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/MultilateralAgreement"></see>
    /// </summary>
    let MultilateralAgreement = _prefix "MultilateralAgreement"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/MutualAgreement"></see>
    /// </summary>
    let MutualAgreement = _prefix "MutualAgreement"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/MutualCommitment"></see>
    /// </summary>
    let MutualCommitment = _prefix "MutualCommitment"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/Obligee"></see>
    /// </summary>
    let Obligee = _prefix "Obligee"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/Obligor"></see>
    /// </summary>
    let Obligor = _prefix "Obligor"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/hasObligation"></see>
    /// </summary>
    let hasObligation = _prefix "hasObligation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/isObligationOf"></see>
    /// </summary>
    let isObligationOf = _prefix "isObligationOf"
