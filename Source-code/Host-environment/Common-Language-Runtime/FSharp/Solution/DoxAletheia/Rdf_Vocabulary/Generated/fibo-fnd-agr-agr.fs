namespace https.spec.edmcouncil.org.fibo.ontology.FND.Agreements.Agreements.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_agr_agr =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/Agreement"></see>
    /// </summary>
    let Agreement = Namespaced_IRI.parse _namespace_name "Agreement" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/Commitment"></see>
    /// </summary>
    let Commitment = Namespaced_IRI.parse _namespace_name "Commitment" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/Beneficiary"></see>
    /// </summary>
    let Beneficiary =
        Namespaced_IRI.parse _namespace_name "Beneficiary" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/BilateralAgreement"></see>
    /// </summary>
    let BilateralAgreement =
        Namespaced_IRI.parse _namespace_name "BilateralAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/CommitmentAtLarge"></see>
    /// </summary>
    let CommitmentAtLarge =
        Namespaced_IRI.parse _namespace_name "CommitmentAtLarge" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/UnilateralCommitment"></see>
    /// </summary>
    let UnilateralCommitment =
        Namespaced_IRI.parse _namespace_name "UnilateralCommitment" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/IndividualUnilateralCommitment"></see>
    /// </summary>
    let IndividualUnilateralCommitment =
        Namespaced_IRI.parse _namespace_name "IndividualUnilateralCommitment" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/MultilateralAgreement"></see>
    /// </summary>
    let MultilateralAgreement =
        Namespaced_IRI.parse _namespace_name "MultilateralAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/MutualAgreement"></see>
    /// </summary>
    let MutualAgreement =
        Namespaced_IRI.parse _namespace_name "MutualAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/MutualCommitment"></see>
    /// </summary>
    let MutualCommitment =
        Namespaced_IRI.parse _namespace_name "MutualCommitment" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/Obligee"></see>
    /// </summary>
    let Obligee = Namespaced_IRI.parse _namespace_name "Obligee" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/Obligor"></see>
    /// </summary>
    let Obligor = Namespaced_IRI.parse _namespace_name "Obligor" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/hasObligation"></see>
    /// </summary>
    let hasObligation =
        Namespaced_IRI.parse _namespace_name "hasObligation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/isObligationOf"></see>
    /// </summary>
    let isObligationOf =
        Namespaced_IRI.parse _namespace_name "isObligationOf" |> NamespacedName
