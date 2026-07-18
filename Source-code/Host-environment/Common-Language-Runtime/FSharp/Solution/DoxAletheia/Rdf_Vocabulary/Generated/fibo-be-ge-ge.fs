namespace https.spec.edmcouncil.org.fibo.ontology.BE.GovernmentEntities.GovernmentEntities.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_be_ge_ge =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/BranchOfGovernment"></see>
    /// </summary>
    let BranchOfGovernment =
        Namespaced_IRI.parse _namespace_name "BranchOfGovernment" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/GovernmentBody"></see>
    /// </summary>
    let GovernmentBody =
        Namespaced_IRI.parse _namespace_name "GovernmentBody" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/DevolvedGovernment"></see>
    /// </summary>
    let DevolvedGovernment =
        Namespaced_IRI.parse _namespace_name "DevolvedGovernment" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/Government"></see>
    /// </summary>
    let Government = Namespaced_IRI.parse _namespace_name "Government" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/ExecutiveBranch"></see>
    /// </summary>
    let ExecutiveBranch =
        Namespaced_IRI.parse _namespace_name "ExecutiveBranch" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/FederalGovernment"></see>
    /// </summary>
    let FederalGovernment =
        Namespaced_IRI.parse _namespace_name "FederalGovernment" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/NationalGovernment"></see>
    /// </summary>
    let NationalGovernment =
        Namespaced_IRI.parse _namespace_name "NationalGovernment" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/FederatedSovereignty"></see>
    /// </summary>
    let FederatedSovereignty =
        Namespaced_IRI.parse _namespace_name "FederatedSovereignty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/SovereignState"></see>
    /// </summary>
    let SovereignState =
        Namespaced_IRI.parse _namespace_name "SovereignState" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/hasFullSovereigntyOver"></see>
    /// </summary>
    let hasFullSovereigntyOver =
        Namespaced_IRI.parse _namespace_name "hasFullSovereigntyOver" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/hasSharedSovereigntyOver"></see>
    /// </summary>
    let hasSharedSovereigntyOver =
        Namespaced_IRI.parse _namespace_name "hasSharedSovereigntyOver" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/isRepresentedBy"></see>
    /// </summary>
    let isRepresentedBy =
        Namespaced_IRI.parse _namespace_name "isRepresentedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/RegionalGovernment"></see>
    /// </summary>
    let RegionalGovernment =
        Namespaced_IRI.parse _namespace_name "RegionalGovernment" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/GovernmentAgency"></see>
    /// </summary>
    let GovernmentAgency =
        Namespaced_IRI.parse _namespace_name "GovernmentAgency" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/GovernmentDepartment"></see>
    /// </summary>
    let GovernmentDepartment =
        Namespaced_IRI.parse _namespace_name "GovernmentDepartment" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/Instrumentality"></see>
    /// </summary>
    let Instrumentality =
        Namespaced_IRI.parse _namespace_name "Instrumentality" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/GovernmentAppointee"></see>
    /// </summary>
    let GovernmentAppointee =
        Namespaced_IRI.parse _namespace_name "GovernmentAppointee" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/GovernmentOfficial"></see>
    /// </summary>
    let GovernmentOfficial =
        Namespaced_IRI.parse _namespace_name "GovernmentOfficial" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/GovernmentMinister"></see>
    /// </summary>
    let GovernmentMinister =
        Namespaced_IRI.parse _namespace_name "GovernmentMinister" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/isInstrumentOf"></see>
    /// </summary>
    let isInstrumentOf =
        Namespaced_IRI.parse _namespace_name "isInstrumentOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/Judiciary"></see>
    /// </summary>
    let Judiciary = Namespaced_IRI.parse _namespace_name "Judiciary" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/Legislature"></see>
    /// </summary>
    let Legislature =
        Namespaced_IRI.parse _namespace_name "Legislature" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/MunicipalEntity"></see>
    /// </summary>
    let MunicipalEntity =
        Namespaced_IRI.parse _namespace_name "MunicipalEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/Polity"></see>
    /// </summary>
    let Polity = Namespaced_IRI.parse _namespace_name "Polity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/hasSovereigntyOver"></see>
    /// </summary>
    let hasSovereigntyOver =
        Namespaced_IRI.parse _namespace_name "hasSovereigntyOver" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/MunicipalGovernment"></see>
    /// </summary>
    let MunicipalGovernment =
        Namespaced_IRI.parse _namespace_name "MunicipalGovernment" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/RegionalSovereignty"></see>
    /// </summary>
    let RegionalSovereignty =
        Namespaced_IRI.parse _namespace_name "RegionalSovereignty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/SupranationalEntity"></see>
    /// </summary>
    let SupranationalEntity =
        Namespaced_IRI.parse _namespace_name "SupranationalEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/TribalArea"></see>
    /// </summary>
    let TribalArea = Namespaced_IRI.parse _namespace_name "TribalArea" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/TribalEntity"></see>
    /// </summary>
    let TribalEntity =
        Namespaced_IRI.parse _namespace_name "TribalEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/TribalGovernment"></see>
    /// </summary>
    let TribalGovernment =
        Namespaced_IRI.parse _namespace_name "TribalGovernment" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/isElectedBy"></see>
    /// </summary>
    let isElectedBy =
        Namespaced_IRI.parse _namespace_name "isElectedBy" |> NamespacedName
