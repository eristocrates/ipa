namespace https.spec.edmcouncil.org.fibo.ontology.BE.GovernmentEntities.EuropeanJurisdiction.EUGovernmentEntitiesAndJurisdictions.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_be_ge_euj =
    let _namespace_iri = Namespace_Iri fibo_be_ge_euj |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-be-ge-euj:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"European Government Entities and Jurisdictions Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EUGovernmentEntitiesAndJurisdictions/">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EUGovernmentEntitiesAndJurisdictions/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_be_ge_euj, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-euj:CouncilOfEurope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:SupranationalEntity</para>
    ///
    /// labels<para>"Council of Europe"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EUGovernmentEntitiesAndJurisdictions/CouncilOfEurope">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EUGovernmentEntitiesAndJurisdictions/CouncilOfEurope</seealso>
    let CouncilOfEurope =
        Prefixed_Name(fibo_be_ge_euj, "CouncilOfEurope") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-euj:EuropeanCommission</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:SupranationalEntity</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"European Commission"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EUGovernmentEntitiesAndJurisdictions/EuropeanCommission">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EUGovernmentEntitiesAndJurisdictions/EuropeanCommission</seealso>
    let EuropeanCommission =
        Prefixed_Name(fibo_be_ge_euj, "EuropeanCommission") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-euj:EuropeanCommissionAsRegulatoryAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:RegulatoryAgency</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"European Commission as regulatory agency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EUGovernmentEntitiesAndJurisdictions/EuropeanCommissionAsRegulatoryAgency">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EUGovernmentEntitiesAndJurisdictions/EuropeanCommissionAsRegulatoryAgency</seealso>
    let EuropeanCommissionAsRegulatoryAgency =
        Prefixed_Name(fibo_be_ge_euj, "EuropeanCommissionAsRegulatoryAgency") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-euj:EuropeanEconomicArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"European Economic Area jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EUGovernmentEntitiesAndJurisdictions/EuropeanEconomicArea">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EUGovernmentEntitiesAndJurisdictions/EuropeanEconomicArea</seealso>
    let EuropeanEconomicArea =
        Prefixed_Name(fibo_be_ge_euj, "EuropeanEconomicArea") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-euj:EuropeanFreeTradeAssociation</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:SupranationalEntity</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"European Free Trade Association"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EUGovernmentEntitiesAndJurisdictions/EuropeanFreeTradeAssociation">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EUGovernmentEntitiesAndJurisdictions/EuropeanFreeTradeAssociation</seealso>
    let EuropeanFreeTradeAssociation =
        Prefixed_Name(fibo_be_ge_euj, "EuropeanFreeTradeAssociation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-euj:EuropeanUnionEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:SupranationalEntity</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"European Union entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EUGovernmentEntitiesAndJurisdictions/EuropeanUnionEntity">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EUGovernmentEntitiesAndJurisdictions/EuropeanUnionEntity</seealso>
    let EuropeanUnionEntity =
        Prefixed_Name(fibo_be_ge_euj, "EuropeanUnionEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-euj:EuropeanUnionJurisdiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:Jurisdiction</para>
    ///
    /// labels<para>"European Union jurisdiction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EUGovernmentEntitiesAndJurisdictions/EuropeanUnionJurisdiction">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EUGovernmentEntitiesAndJurisdictions/EuropeanUnionJurisdiction</seealso>
    let EuropeanUnionJurisdiction =
        Prefixed_Name(fibo_be_ge_euj, "EuropeanUnionJurisdiction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-be-ge-euj:GovernmentOfTheEuropeanUnion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:Government</para>
    ///
    /// labels<para>"Government of the European Union"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EUGovernmentEntitiesAndJurisdictions/GovernmentOfTheEuropeanUnion">https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EUGovernmentEntitiesAndJurisdictions/GovernmentOfTheEuropeanUnion</seealso>
    let GovernmentOfTheEuropeanUnion =
        Prefixed_Name(fibo_be_ge_euj, "GovernmentOfTheEuropeanUnion") |> PrefixedName
