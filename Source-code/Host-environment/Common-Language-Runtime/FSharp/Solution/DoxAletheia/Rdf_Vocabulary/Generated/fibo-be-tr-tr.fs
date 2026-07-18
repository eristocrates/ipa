namespace https.spec.edmcouncil.org.fibo.ontology.BE.Trusts.Trusts.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_be_tr_tr =
    let _namespace_name = "https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/IrrevocableTrust"></see>
    /// </summary>
    let IrrevocableTrust =
        Namespaced_IRI.parse _namespace_name "IrrevocableTrust" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/Trust"></see>
    /// </summary>
    let Trust = Namespaced_IRI.parse _namespace_name "Trust" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/LivingTrust"></see>
    /// </summary>
    let LivingTrust =
        Namespaced_IRI.parse _namespace_name "LivingTrust" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/RevocableTrust"></see>
    /// </summary>
    let RevocableTrust =
        Namespaced_IRI.parse _namespace_name "RevocableTrust" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/TestamentaryTrust"></see>
    /// </summary>
    let TestamentaryTrust =
        Namespaced_IRI.parse _namespace_name "TestamentaryTrust" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/TrustAgreement"></see>
    /// </summary>
    let TrustAgreement =
        Namespaced_IRI.parse _namespace_name "TrustAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/TrustBeneficiary"></see>
    /// </summary>
    let TrustBeneficiary =
        Namespaced_IRI.parse _namespace_name "TrustBeneficiary" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/Trustee"></see>
    /// </summary>
    let Trustee = Namespaced_IRI.parse _namespace_name "Trustee" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/Trustor"></see>
    /// </summary>
    let Trustor = Namespaced_IRI.parse _namespace_name "Trustor" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/TrustFundManager"></see>
    /// </summary>
    let TrustFundManager =
        Namespaced_IRI.parse _namespace_name "TrustFundManager" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/hasBeneficiary"></see>
    /// </summary>
    let hasBeneficiary =
        Namespaced_IRI.parse _namespace_name "hasBeneficiary" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/hasTrustee"></see>
    /// </summary>
    let hasTrustee = Namespaced_IRI.parse _namespace_name "hasTrustee" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/isTrusteeOf"></see>
    /// </summary>
    let isTrusteeOf =
        Namespaced_IRI.parse _namespace_name "isTrusteeOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/isBeneficiaryOf"></see>
    /// </summary>
    let isBeneficiaryOf =
        Namespaced_IRI.parse _namespace_name "isBeneficiaryOf" |> NamespacedName
