namespace https.spec.edmcouncil.org.fibo.ontology.BE.LegalEntities.FormalBusinessOrganizations.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_be_le_fbo =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/Branch"></see>
    /// </summary>
    let Branch = Namespaced_IRI.parse _namespace_name "Branch" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/Division"></see>
    /// </summary>
    let Division = Namespaced_IRI.parse _namespace_name "Division" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/JointVenture"></see>
    /// </summary>
    let JointVenture =
        Namespaced_IRI.parse _namespace_name "JointVenture" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/NonGovernmentalOrganization"></see>
    /// </summary>
    let NonGovernmentalOrganization =
        Namespaced_IRI.parse _namespace_name "NonGovernmentalOrganization" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/NotForProfitOrganization"></see>
    /// </summary>
    let NotForProfitOrganization =
        Namespaced_IRI.parse _namespace_name "NotForProfitOrganization" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/OrganizationCoveringAgreement"></see>
    /// </summary>
    let OrganizationCoveringAgreement =
        Namespaced_IRI.parse _namespace_name "OrganizationCoveringAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/ValueAddedTaxIdentificationNumber"></see>
    /// </summary>
    let ValueAddedTaxIdentificationNumber =
        Namespaced_IRI.parse _namespace_name "ValueAddedTaxIdentificationNumber" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/hasEquity"></see>
    /// </summary>
    let hasEquity = Namespaced_IRI.parse _namespace_name "hasEquity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/hasHeadquartersAddress"></see>
    /// </summary>
    let hasHeadquartersAddress =
        Namespaced_IRI.parse _namespace_name "hasHeadquartersAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/hasOperatingAddress"></see>
    /// </summary>
    let hasOperatingAddress =
        Namespaced_IRI.parse _namespace_name "hasOperatingAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/hasRegisteredAddress"></see>
    /// </summary>
    let hasRegisteredAddress =
        Namespaced_IRI.parse _namespace_name "hasRegisteredAddress" |> NamespacedName
