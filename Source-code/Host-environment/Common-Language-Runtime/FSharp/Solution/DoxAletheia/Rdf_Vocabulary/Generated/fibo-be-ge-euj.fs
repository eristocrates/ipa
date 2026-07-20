namespace https.spec.edmcouncil.org.fibo.ontology.BE.GovernmentEntities.EuropeanJurisdiction.EUGovernmentEntitiesAndJurisdictions.slash

open DoxAletheia

module fibo_be_ge_euj =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EUGovernmentEntitiesAndJurisdictions/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EUGovernmentEntitiesAndJurisdictions/CouncilOfEurope"></see>
    /// </summary>
    let CouncilOfEurope = _prefix "CouncilOfEurope"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EUGovernmentEntitiesAndJurisdictions/EuropeanCommission"></see>
    /// </summary>
    let EuropeanCommission = _prefix "EuropeanCommission"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EUGovernmentEntitiesAndJurisdictions/EuropeanCommissionAsRegulatoryAgency"></see>
    /// </summary>
    let EuropeanCommissionAsRegulatoryAgency =
        _prefix "EuropeanCommissionAsRegulatoryAgency"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EUGovernmentEntitiesAndJurisdictions/EuropeanUnionJurisdiction"></see>
    /// </summary>
    let EuropeanUnionJurisdiction = _prefix "EuropeanUnionJurisdiction"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EUGovernmentEntitiesAndJurisdictions/EuropeanEconomicArea"></see>
    /// </summary>
    let EuropeanEconomicArea = _prefix "EuropeanEconomicArea"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EUGovernmentEntitiesAndJurisdictions/EuropeanFreeTradeAssociation"></see>
    /// </summary>
    let EuropeanFreeTradeAssociation = _prefix "EuropeanFreeTradeAssociation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EUGovernmentEntitiesAndJurisdictions/EuropeanUnionEntity"></see>
    /// </summary>
    let EuropeanUnionEntity = _prefix "EuropeanUnionEntity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EUGovernmentEntitiesAndJurisdictions/GovernmentOfTheEuropeanUnion"></see>
    /// </summary>
    let GovernmentOfTheEuropeanUnion = _prefix "GovernmentOfTheEuropeanUnion"
