namespace https.spec.edmcouncil.org.fibo.ontology.FBC.DebtAndEquities.Guaranty.slash

open DoxAletheia

module fibo_fbc_dae_gty =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/Guaranty"></see>
    /// </summary>
    let Guaranty = _prefix "Guaranty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/CollateralizedGuaranty"></see>
    /// </summary>
    let CollateralizedGuaranty = _prefix "CollateralizedGuaranty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/GovernmentGuaranty"></see>
    /// </summary>
    let GovernmentGuaranty = _prefix "GovernmentGuaranty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/isGuaranteedBy"></see>
    /// </summary>
    let isGuaranteedBy = _prefix "isGuaranteedBy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/Guarantor"></see>
    /// </summary>
    let Guarantor = _prefix "Guarantor"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/hasPriorityLevel"></see>
    /// </summary>
    let hasPriorityLevel = _prefix "hasPriorityLevel"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/PriorityLevel"></see>
    /// </summary>
    let PriorityLevel = _prefix "PriorityLevel"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/hasGuaranteedAmount"></see>
    /// </summary>
    let hasGuaranteedAmount = _prefix "hasGuaranteedAmount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/InsuranceBackedGuaranty"></see>
    /// </summary>
    let InsuranceBackedGuaranty = _prefix "InsuranceBackedGuaranty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/InsurancePolicy"></see>
    /// </summary>
    let InsurancePolicy = _prefix "InsurancePolicy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/Policyholder"></see>
    /// </summary>
    let Policyholder = _prefix "Policyholder"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/Insurer"></see>
    /// </summary>
    let Insurer = _prefix "Insurer"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/JointGuaranty"></see>
    /// </summary>
    let JointGuaranty = _prefix "JointGuaranty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/LetterOfCredit"></see>
    /// </summary>
    let LetterOfCredit = _prefix "LetterOfCredit"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/LetterOfCreditGuaranty"></see>
    /// </summary>
    let LetterOfCreditGuaranty = _prefix "LetterOfCreditGuaranty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/NegativePledge"></see>
    /// </summary>
    let NegativePledge = _prefix "NegativePledge"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/hasGuarantor"></see>
    /// </summary>
    let hasGuarantor = _prefix "hasGuarantor"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/hasGuarantorParty"></see>
    /// </summary>
    let hasGuarantorParty = _prefix "hasGuarantorParty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/isGuarantorOf"></see>
    /// </summary>
    let isGuarantorOf = _prefix "isGuarantorOf"
