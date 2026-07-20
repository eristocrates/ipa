namespace https.spec.edmcouncil.org.fibo.ontology.BE.Trusts.Trusts.slash

open DoxAletheia

module fibo_be_tr_tr =
    let _namespace_name = "https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/IrrevocableTrust"></see>
    /// </summary>
    let IrrevocableTrust = _prefix "IrrevocableTrust"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/Trust"></see>
    /// </summary>
    let Trust = _prefix "Trust"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/LivingTrust"></see>
    /// </summary>
    let LivingTrust = _prefix "LivingTrust"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/RevocableTrust"></see>
    /// </summary>
    let RevocableTrust = _prefix "RevocableTrust"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/TestamentaryTrust"></see>
    /// </summary>
    let TestamentaryTrust = _prefix "TestamentaryTrust"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/TrustAgreement"></see>
    /// </summary>
    let TrustAgreement = _prefix "TrustAgreement"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/TrustBeneficiary"></see>
    /// </summary>
    let TrustBeneficiary = _prefix "TrustBeneficiary"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/Trustee"></see>
    /// </summary>
    let Trustee = _prefix "Trustee"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/Trustor"></see>
    /// </summary>
    let Trustor = _prefix "Trustor"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/TrustFundManager"></see>
    /// </summary>
    let TrustFundManager = _prefix "TrustFundManager"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/hasBeneficiary"></see>
    /// </summary>
    let hasBeneficiary = _prefix "hasBeneficiary"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/hasTrustee"></see>
    /// </summary>
    let hasTrustee = _prefix "hasTrustee"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/isTrusteeOf"></see>
    /// </summary>
    let isTrusteeOf = _prefix "isTrusteeOf"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/isBeneficiaryOf"></see>
    /// </summary>
    let isBeneficiaryOf = _prefix "isBeneficiaryOf"
