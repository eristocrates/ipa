namespace https.spec.edmcouncil.org.fibo.ontology.BE.PrivateLimitedCompanies.PrivateLimitedCompanies.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_be_plc_plc =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/LimitedLiabilityCompany"></see>
    /// </summary>
    let LimitedLiabilityCompany =
        Namespaced_IRI.parse _namespace_name "LimitedLiabilityCompany" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/PrivateCompanyWithLimitedLiability"></see>
    /// </summary>
    let PrivateCompanyWithLimitedLiability =
        Namespaced_IRI.parse _namespace_name "PrivateCompanyWithLimitedLiability" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/hasManagingMember"></see>
    /// </summary>
    let hasManagingMember =
        Namespaced_IRI.parse _namespace_name "hasManagingMember" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/ManagingMember"></see>
    /// </summary>
    let ManagingMember =
        Namespaced_IRI.parse _namespace_name "ManagingMember" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/LimitedLiabilityCompanyMember"></see>
    /// </summary>
    let LimitedLiabilityCompanyMember =
        Namespaced_IRI.parse _namespace_name "LimitedLiabilityCompanyMember" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/LimitedLiabilityCompanyTaxedAsACorporation"></see>
    /// </summary>
    let LimitedLiabilityCompanyTaxedAsACorporation =
        Namespaced_IRI.parse _namespace_name "LimitedLiabilityCompanyTaxedAsACorporation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/ManagerManagedLimitedLiabilityCompany"></see>
    /// </summary>
    let ManagerManagedLimitedLiabilityCompany =
        Namespaced_IRI.parse _namespace_name "ManagerManagedLimitedLiabilityCompany" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/isManagingMemberOf"></see>
    /// </summary>
    let isManagingMemberOf =
        Namespaced_IRI.parse _namespace_name "isManagingMemberOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/PrivateLimitedCompany"></see>
    /// </summary>
    let PrivateLimitedCompany =
        Namespaced_IRI.parse _namespace_name "PrivateLimitedCompany" |> NamespacedName
