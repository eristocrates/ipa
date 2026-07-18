namespace https.spec.edmcouncil.org.fibo.ontology.BE.Partnerships.Partnerships.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_be_ptr_ptr =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/GeneralPartner"></see>
    /// </summary>
    let GeneralPartner =
        Namespaced_IRI.parse _namespace_name "GeneralPartner" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/Partner"></see>
    /// </summary>
    let Partner = Namespaced_IRI.parse _namespace_name "Partner" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/GeneralPartnership"></see>
    /// </summary>
    let GeneralPartnership =
        Namespaced_IRI.parse _namespace_name "GeneralPartnership" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/Partnership"></see>
    /// </summary>
    let Partnership =
        Namespaced_IRI.parse _namespace_name "Partnership" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/hasGeneralPartner"></see>
    /// </summary>
    let hasGeneralPartner =
        Namespaced_IRI.parse _namespace_name "hasGeneralPartner" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/LimitedLiabilityLimitedPartnership"></see>
    /// </summary>
    let LimitedLiabilityLimitedPartnership =
        Namespaced_IRI.parse _namespace_name "LimitedLiabilityLimitedPartnership" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/LimitedPartnership"></see>
    /// </summary>
    let LimitedPartnership =
        Namespaced_IRI.parse _namespace_name "LimitedPartnership" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/LimitedLiabilityPartnership"></see>
    /// </summary>
    let LimitedLiabilityPartnership =
        Namespaced_IRI.parse _namespace_name "LimitedLiabilityPartnership" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/LimitedPartner"></see>
    /// </summary>
    let LimitedPartner =
        Namespaced_IRI.parse _namespace_name "LimitedPartner" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/hasLimitedPartner"></see>
    /// </summary>
    let hasLimitedPartner =
        Namespaced_IRI.parse _namespace_name "hasLimitedPartner" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/PartnershipAgreement"></see>
    /// </summary>
    let PartnershipAgreement =
        Namespaced_IRI.parse _namespace_name "PartnershipAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/isGeneralPartnerOf"></see>
    /// </summary>
    let isGeneralPartnerOf =
        Namespaced_IRI.parse _namespace_name "isGeneralPartnerOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/isLimitedPartnerOf"></see>
    /// </summary>
    let isLimitedPartnerOf =
        Namespaced_IRI.parse _namespace_name "isLimitedPartnerOf" |> NamespacedName
