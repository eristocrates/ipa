namespace https.spec.edmcouncil.org.fibo.ontology.FBC.DebtAndEquities.Guaranty.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fbc_dae_gty =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/Guaranty"></see>
    /// </summary>
    let Guaranty = Namespaced_IRI.parse _namespace_name "Guaranty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/CollateralizedGuaranty"></see>
    /// </summary>
    let CollateralizedGuaranty =
        Namespaced_IRI.parse _namespace_name "CollateralizedGuaranty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/GovernmentGuaranty"></see>
    /// </summary>
    let GovernmentGuaranty =
        Namespaced_IRI.parse _namespace_name "GovernmentGuaranty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/isGuaranteedBy"></see>
    /// </summary>
    let isGuaranteedBy =
        Namespaced_IRI.parse _namespace_name "isGuaranteedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/Guarantor"></see>
    /// </summary>
    let Guarantor = Namespaced_IRI.parse _namespace_name "Guarantor" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/hasPriorityLevel"></see>
    /// </summary>
    let hasPriorityLevel =
        Namespaced_IRI.parse _namespace_name "hasPriorityLevel" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/PriorityLevel"></see>
    /// </summary>
    let PriorityLevel =
        Namespaced_IRI.parse _namespace_name "PriorityLevel" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/hasGuaranteedAmount"></see>
    /// </summary>
    let hasGuaranteedAmount =
        Namespaced_IRI.parse _namespace_name "hasGuaranteedAmount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/InsuranceBackedGuaranty"></see>
    /// </summary>
    let InsuranceBackedGuaranty =
        Namespaced_IRI.parse _namespace_name "InsuranceBackedGuaranty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/InsurancePolicy"></see>
    /// </summary>
    let InsurancePolicy =
        Namespaced_IRI.parse _namespace_name "InsurancePolicy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/Policyholder"></see>
    /// </summary>
    let Policyholder =
        Namespaced_IRI.parse _namespace_name "Policyholder" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/Insurer"></see>
    /// </summary>
    let Insurer = Namespaced_IRI.parse _namespace_name "Insurer" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/JointGuaranty"></see>
    /// </summary>
    let JointGuaranty =
        Namespaced_IRI.parse _namespace_name "JointGuaranty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/LetterOfCredit"></see>
    /// </summary>
    let LetterOfCredit =
        Namespaced_IRI.parse _namespace_name "LetterOfCredit" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/LetterOfCreditGuaranty"></see>
    /// </summary>
    let LetterOfCreditGuaranty =
        Namespaced_IRI.parse _namespace_name "LetterOfCreditGuaranty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/NegativePledge"></see>
    /// </summary>
    let NegativePledge =
        Namespaced_IRI.parse _namespace_name "NegativePledge" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/hasGuarantor"></see>
    /// </summary>
    let hasGuarantor =
        Namespaced_IRI.parse _namespace_name "hasGuarantor" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/hasGuarantorParty"></see>
    /// </summary>
    let hasGuarantorParty =
        Namespaced_IRI.parse _namespace_name "hasGuarantorParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/isGuarantorOf"></see>
    /// </summary>
    let isGuarantorOf =
        Namespaced_IRI.parse _namespace_name "isGuarantorOf" |> NamespacedName
