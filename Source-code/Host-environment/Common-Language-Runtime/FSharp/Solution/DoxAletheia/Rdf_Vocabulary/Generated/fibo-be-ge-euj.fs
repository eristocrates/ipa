namespace https.spec.edmcouncil.org.fibo.ontology.BE.GovernmentEntities.EuropeanJurisdiction.EUGovernmentEntitiesAndJurisdictions.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_be_ge_euj =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EUGovernmentEntitiesAndJurisdictions/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EUGovernmentEntitiesAndJurisdictions/CouncilOfEurope"></see>
    /// </summary>
    let CouncilOfEurope =
        Namespaced_IRI.parse _namespace_name "CouncilOfEurope" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EUGovernmentEntitiesAndJurisdictions/EuropeanCommission"></see>
    /// </summary>
    let EuropeanCommission =
        Namespaced_IRI.parse _namespace_name "EuropeanCommission" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EUGovernmentEntitiesAndJurisdictions/EuropeanCommissionAsRegulatoryAgency"></see>
    /// </summary>
    let EuropeanCommissionAsRegulatoryAgency =
        Namespaced_IRI.parse _namespace_name "EuropeanCommissionAsRegulatoryAgency" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EUGovernmentEntitiesAndJurisdictions/EuropeanUnionJurisdiction"></see>
    /// </summary>
    let EuropeanUnionJurisdiction =
        Namespaced_IRI.parse _namespace_name "EuropeanUnionJurisdiction" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EUGovernmentEntitiesAndJurisdictions/EuropeanEconomicArea"></see>
    /// </summary>
    let EuropeanEconomicArea =
        Namespaced_IRI.parse _namespace_name "EuropeanEconomicArea" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EUGovernmentEntitiesAndJurisdictions/EuropeanFreeTradeAssociation"></see>
    /// </summary>
    let EuropeanFreeTradeAssociation =
        Namespaced_IRI.parse _namespace_name "EuropeanFreeTradeAssociation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EUGovernmentEntitiesAndJurisdictions/EuropeanUnionEntity"></see>
    /// </summary>
    let EuropeanUnionEntity =
        Namespaced_IRI.parse _namespace_name "EuropeanUnionEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EUGovernmentEntitiesAndJurisdictions/GovernmentOfTheEuropeanUnion"></see>
    /// </summary>
    let GovernmentOfTheEuropeanUnion =
        Namespaced_IRI.parse _namespace_name "GovernmentOfTheEuropeanUnion" |> NamespacedName
