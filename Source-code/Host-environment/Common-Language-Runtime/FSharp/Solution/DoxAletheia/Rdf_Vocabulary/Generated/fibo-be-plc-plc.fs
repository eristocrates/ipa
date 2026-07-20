namespace https.spec.edmcouncil.org.fibo.ontology.BE.PrivateLimitedCompanies.PrivateLimitedCompanies.slash

open DoxAletheia

module fibo_be_plc_plc =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/LimitedLiabilityCompany"></see>
    /// </summary>
    let LimitedLiabilityCompany = _prefix "LimitedLiabilityCompany"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/PrivateCompanyWithLimitedLiability"></see>
    /// </summary>
    let PrivateCompanyWithLimitedLiability =
        _prefix "PrivateCompanyWithLimitedLiability"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/hasManagingMember"></see>
    /// </summary>
    let hasManagingMember = _prefix "hasManagingMember"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/ManagingMember"></see>
    /// </summary>
    let ManagingMember = _prefix "ManagingMember"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/LimitedLiabilityCompanyMember"></see>
    /// </summary>
    let LimitedLiabilityCompanyMember = _prefix "LimitedLiabilityCompanyMember"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/LimitedLiabilityCompanyTaxedAsACorporation"></see>
    /// </summary>
    let LimitedLiabilityCompanyTaxedAsACorporation =
        _prefix "LimitedLiabilityCompanyTaxedAsACorporation"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/ManagerManagedLimitedLiabilityCompany"></see>
    /// </summary>
    let ManagerManagedLimitedLiabilityCompany =
        _prefix "ManagerManagedLimitedLiabilityCompany"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/isManagingMemberOf"></see>
    /// </summary>
    let isManagingMemberOf = _prefix "isManagingMemberOf"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/PrivateLimitedCompany"></see>
    /// </summary>
    let PrivateLimitedCompany = _prefix "PrivateLimitedCompany"
