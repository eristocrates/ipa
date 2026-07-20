namespace https.spec.edmcouncil.org.fibo.ontology.BE.LegalEntities.FormalBusinessOrganizations.slash

open DoxAletheia

module fibo_be_le_fbo =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/Branch"></see>
    /// </summary>
    let Branch = _prefix "Branch"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/Division"></see>
    /// </summary>
    let Division = _prefix "Division"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/JointVenture"></see>
    /// </summary>
    let JointVenture = _prefix "JointVenture"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/NonGovernmentalOrganization"></see>
    /// </summary>
    let NonGovernmentalOrganization = _prefix "NonGovernmentalOrganization"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/NotForProfitOrganization"></see>
    /// </summary>
    let NotForProfitOrganization = _prefix "NotForProfitOrganization"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/OrganizationCoveringAgreement"></see>
    /// </summary>
    let OrganizationCoveringAgreement = _prefix "OrganizationCoveringAgreement"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/ValueAddedTaxIdentificationNumber"></see>
    /// </summary>
    let ValueAddedTaxIdentificationNumber = _prefix "ValueAddedTaxIdentificationNumber"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/hasEquity"></see>
    /// </summary>
    let hasEquity = _prefix "hasEquity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/hasHeadquartersAddress"></see>
    /// </summary>
    let hasHeadquartersAddress = _prefix "hasHeadquartersAddress"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/hasOperatingAddress"></see>
    /// </summary>
    let hasOperatingAddress = _prefix "hasOperatingAddress"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/hasRegisteredAddress"></see>
    /// </summary>
    let hasRegisteredAddress = _prefix "hasRegisteredAddress"
