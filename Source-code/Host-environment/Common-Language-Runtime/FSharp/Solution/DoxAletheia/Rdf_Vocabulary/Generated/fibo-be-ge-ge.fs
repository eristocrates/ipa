namespace https.spec.edmcouncil.org.fibo.ontology.BE.GovernmentEntities.GovernmentEntities.slash

open DoxAletheia

module fibo_be_ge_ge =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/BranchOfGovernment"></see>
    /// </summary>
    let BranchOfGovernment = _prefix "BranchOfGovernment"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/GovernmentBody"></see>
    /// </summary>
    let GovernmentBody = _prefix "GovernmentBody"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/DevolvedGovernment"></see>
    /// </summary>
    let DevolvedGovernment = _prefix "DevolvedGovernment"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/Government"></see>
    /// </summary>
    let Government = _prefix "Government"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/ExecutiveBranch"></see>
    /// </summary>
    let ExecutiveBranch = _prefix "ExecutiveBranch"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/FederalGovernment"></see>
    /// </summary>
    let FederalGovernment = _prefix "FederalGovernment"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/NationalGovernment"></see>
    /// </summary>
    let NationalGovernment = _prefix "NationalGovernment"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/FederatedSovereignty"></see>
    /// </summary>
    let FederatedSovereignty = _prefix "FederatedSovereignty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/SovereignState"></see>
    /// </summary>
    let SovereignState = _prefix "SovereignState"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/hasFullSovereigntyOver"></see>
    /// </summary>
    let hasFullSovereigntyOver = _prefix "hasFullSovereigntyOver"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/hasSharedSovereigntyOver"></see>
    /// </summary>
    let hasSharedSovereigntyOver = _prefix "hasSharedSovereigntyOver"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/isRepresentedBy"></see>
    /// </summary>
    let isRepresentedBy = _prefix "isRepresentedBy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/RegionalGovernment"></see>
    /// </summary>
    let RegionalGovernment = _prefix "RegionalGovernment"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/GovernmentAgency"></see>
    /// </summary>
    let GovernmentAgency = _prefix "GovernmentAgency"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/GovernmentDepartment"></see>
    /// </summary>
    let GovernmentDepartment = _prefix "GovernmentDepartment"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/Instrumentality"></see>
    /// </summary>
    let Instrumentality = _prefix "Instrumentality"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/GovernmentAppointee"></see>
    /// </summary>
    let GovernmentAppointee = _prefix "GovernmentAppointee"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/GovernmentOfficial"></see>
    /// </summary>
    let GovernmentOfficial = _prefix "GovernmentOfficial"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/GovernmentMinister"></see>
    /// </summary>
    let GovernmentMinister = _prefix "GovernmentMinister"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/isInstrumentOf"></see>
    /// </summary>
    let isInstrumentOf = _prefix "isInstrumentOf"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/Judiciary"></see>
    /// </summary>
    let Judiciary = _prefix "Judiciary"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/Legislature"></see>
    /// </summary>
    let Legislature = _prefix "Legislature"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/MunicipalEntity"></see>
    /// </summary>
    let MunicipalEntity = _prefix "MunicipalEntity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/Polity"></see>
    /// </summary>
    let Polity = _prefix "Polity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/hasSovereigntyOver"></see>
    /// </summary>
    let hasSovereigntyOver = _prefix "hasSovereigntyOver"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/MunicipalGovernment"></see>
    /// </summary>
    let MunicipalGovernment = _prefix "MunicipalGovernment"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/RegionalSovereignty"></see>
    /// </summary>
    let RegionalSovereignty = _prefix "RegionalSovereignty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/SupranationalEntity"></see>
    /// </summary>
    let SupranationalEntity = _prefix "SupranationalEntity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/TribalArea"></see>
    /// </summary>
    let TribalArea = _prefix "TribalArea"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/TribalEntity"></see>
    /// </summary>
    let TribalEntity = _prefix "TribalEntity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/TribalGovernment"></see>
    /// </summary>
    let TribalGovernment = _prefix "TribalGovernment"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/isElectedBy"></see>
    /// </summary>
    let isElectedBy = _prefix "isElectedBy"
