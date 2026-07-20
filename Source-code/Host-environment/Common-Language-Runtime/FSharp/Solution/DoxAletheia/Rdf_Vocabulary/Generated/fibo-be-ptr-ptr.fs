namespace https.spec.edmcouncil.org.fibo.ontology.BE.Partnerships.Partnerships.slash

open DoxAletheia

module fibo_be_ptr_ptr =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/GeneralPartner"></see>
    /// </summary>
    let GeneralPartner = _prefix "GeneralPartner"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/Partner"></see>
    /// </summary>
    let Partner = _prefix "Partner"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/GeneralPartnership"></see>
    /// </summary>
    let GeneralPartnership = _prefix "GeneralPartnership"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/Partnership"></see>
    /// </summary>
    let Partnership = _prefix "Partnership"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/hasGeneralPartner"></see>
    /// </summary>
    let hasGeneralPartner = _prefix "hasGeneralPartner"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/LimitedLiabilityLimitedPartnership"></see>
    /// </summary>
    let LimitedLiabilityLimitedPartnership =
        _prefix "LimitedLiabilityLimitedPartnership"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/LimitedPartnership"></see>
    /// </summary>
    let LimitedPartnership = _prefix "LimitedPartnership"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/LimitedLiabilityPartnership"></see>
    /// </summary>
    let LimitedLiabilityPartnership = _prefix "LimitedLiabilityPartnership"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/LimitedPartner"></see>
    /// </summary>
    let LimitedPartner = _prefix "LimitedPartner"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/hasLimitedPartner"></see>
    /// </summary>
    let hasLimitedPartner = _prefix "hasLimitedPartner"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/PartnershipAgreement"></see>
    /// </summary>
    let PartnershipAgreement = _prefix "PartnershipAgreement"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/isGeneralPartnerOf"></see>
    /// </summary>
    let isGeneralPartnerOf = _prefix "isGeneralPartnerOf"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/isLimitedPartnerOf"></see>
    /// </summary>
    let isLimitedPartnerOf = _prefix "isLimitedPartnerOf"
