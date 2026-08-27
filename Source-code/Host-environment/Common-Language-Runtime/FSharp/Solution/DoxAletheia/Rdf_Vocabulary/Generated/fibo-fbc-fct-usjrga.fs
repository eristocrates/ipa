namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FunctionalEntities.NorthAmericanEntities.USRegulatoryAgencies.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fbc_fct_usjrga =
    let _namespace_iri = Namespace_Iri fibo_fbc_fct_usjrga |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"US Regulatory Agencies Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fbc_fct_usjrga, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:ABABusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///
    /// labels<para>"ABA business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/ABABusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/ABABusinessEntityIdentifier</seealso>
    let ABABusinessEntityIdentifier =
        Prefixed_Name(fibo_fbc_fct_usjrga, "ABABusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:ABAHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///
    /// labels<para>"ABA headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/ABAHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/ABAHeadquartersAddress</seealso>
    let ABAHeadquartersAddress =
        Prefixed_Name(fibo_fbc_fct_usjrga, "ABAHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:ABAIINRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegistrationAuthorities:Registry</para>
    ///
    /// labels<para>"ABA IIN Registry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/ABAIINRegistry">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/ABAIINRegistry</seealso>
    let ABAIINRegistry =
        Prefixed_Name(fibo_fbc_fct_usjrga, "ABAIINRegistry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:ABAIINRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ABA IIN registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/ABAIINRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/ABAIINRegistryEntry</seealso>
    let ABAIINRegistryEntry =
        Prefixed_Name(fibo_fbc_fct_usjrga, "ABAIINRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:ABARTNRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegistrationAuthorities:Registry</para>
    ///
    /// labels<para>"ABA RTN Registry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/ABARTNRegistry">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/ABARTNRegistry</seealso>
    let ABARTNRegistry =
        Prefixed_Name(fibo_fbc_fct_usjrga, "ABARTNRegistry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:ABARTNRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ABA RTN registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/ABARTNRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/ABARTNRegistryEntry</seealso>
    let ABARTNRegistryEntry =
        Prefixed_Name(fibo_fbc_fct_usjrga, "ABARTNRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:AccuityInc-US-DE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:Corporation</para>
    ///
    /// labels<para>"Accuity Inc. US-DE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/AccuityInc-US-DE">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/AccuityInc-US-DE</seealso>
    let AccuityInc_US_DE =
        Prefixed_Name(fibo_fbc_fct_usjrga, "AccuityInc-US-DE") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:AccuityIncBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///
    /// labels<para>"Accuity Inc. business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/AccuityIncBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/AccuityIncBusinessEntityIdentifier</seealso>
    let AccuityIncBusinessEntityIdentifier =
        Prefixed_Name(fibo_fbc_fct_usjrga, "AccuityIncBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:AccuityIncHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Accuity Inc. headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/AccuityIncHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/AccuityIncHeadquartersAddress</seealso>
    let AccuityIncHeadquartersAddress =
        Prefixed_Name(fibo_fbc_fct_usjrga, "AccuityIncHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:AmericanBankersAssociation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:Corporation</para>
    ///
    /// labels<para>"American Bankers Association"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/AmericanBankersAssociation">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/AmericanBankersAssociation</seealso>
    let AmericanBankersAssociation =
        Prefixed_Name(fibo_fbc_fct_usjrga, "AmericanBankersAssociation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:AmericanBankersAssociationRTNRegistrar</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-pas-fpas:FinancialServiceProvider</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegistrationAuthorities:Registrar</para>
    ///
    /// labels<para>"American Bankers Association RTN Registrar"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/AmericanBankersAssociationRTNRegistrar">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/AmericanBankersAssociationRTNRegistrar</seealso>
    let AmericanBankersAssociationRTNRegistrar =
        Prefixed_Name(fibo_fbc_fct_usjrga, "AmericanBankersAssociationRTNRegistrar") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:AmericanBankersAssociationRegistrationAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegistrationAuthorities:RegistrationAuthority</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-pas-fpas:FinancialServiceProvider</para>
    ///
    /// labels<para>"American Bankers Association Registration Authority"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/AmericanBankersAssociationRegistrationAuthority">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/AmericanBankersAssociationRegistrationAuthority</seealso>
    let AmericanBankersAssociationRegistrationAuthority =
        Prefixed_Name(fibo_fbc_fct_usjrga, "AmericanBankersAssociationRegistrationAuthority") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:BloombergLPRSSDIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usjrga:ResearchStatisticsSupervisionDiscountIdentifier</para>
    ///
    /// labels<para>"RSSD identifier for Bloomberg L.P."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/BloombergLPRSSDIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/BloombergLPRSSDIdentifier</seealso>
    let BloombergLPRSSDIdentifier =
        Prefixed_Name(fibo_fbc_fct_usjrga, "BloombergLPRSSDIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:BoardOfGovernorsOfTheFederalReserveSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-ind-ir-ir:InterestRateAuthority</para>
    ///   <para>RegistrationAuthorities:RegistrationAuthority</para>
    ///   <para>RegulatoryAgencies:RegulatoryAgency</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Board of Governors of the Federal Reserve System"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/BoardOfGovernorsOfTheFederalReserveSystem">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/BoardOfGovernorsOfTheFederalReserveSystem</seealso>
    let BoardOfGovernorsOfTheFederalReserveSystem =
        Prefixed_Name(fibo_fbc_fct_usjrga, "BoardOfGovernorsOfTheFederalReserveSystem") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:CFTCIndustryFilingsRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegistrationAuthorities:Registry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CFTC Industry Filings Repository"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/CFTCIndustryFilingsRepository">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/CFTCIndustryFilingsRepository</seealso>
    let CFTCIndustryFilingsRepository =
        Prefixed_Name(fibo_fbc_fct_usjrga, "CFTCIndustryFilingsRepository") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:CaliforniaBankingRegulator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegistrationAuthorities:RegistrationAuthority</para>
    ///   <para>RegulatoryAgencies:RegulatoryAgency</para>
    ///
    /// labels<para>"California banking regulator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/CaliforniaBankingRegulator">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/CaliforniaBankingRegulator</seealso>
    let CaliforniaBankingRegulator =
        Prefixed_Name(fibo_fbc_fct_usjrga, "CaliforniaBankingRegulator") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:CaliforniaBusinessEntitiesRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:BusinessRegistry</para>
    ///
    /// labels<para>"California business entities registry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/CaliforniaBusinessEntitiesRegistry">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/CaliforniaBusinessEntitiesRegistry</seealso>
    let CaliforniaBusinessEntitiesRegistry =
        Prefixed_Name(fibo_fbc_fct_usjrga, "CaliforniaBusinessEntitiesRegistry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:CaliforniaBusinessProgramsDivision</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:StateGovernmentEntity</para>
    ///   <para>fibo-be-ge-ge:GovernmentDepartment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"California Business Programs Division"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/CaliforniaBusinessProgramsDivision">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/CaliforniaBusinessProgramsDivision</seealso>
    let CaliforniaBusinessProgramsDivision =
        Prefixed_Name(fibo_fbc_fct_usjrga, "CaliforniaBusinessProgramsDivision") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:CaliforniaBusinessRegistrar</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:RegulatoryAgency</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:BusinessRegistrationAuthority</para>
    ///
    /// labels<para>"California business registrar"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/CaliforniaBusinessRegistrar">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/CaliforniaBusinessRegistrar</seealso>
    let CaliforniaBusinessRegistrar =
        Prefixed_Name(fibo_fbc_fct_usjrga, "CaliforniaBusinessRegistrar") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:CaliforniaBusinessRegistrationIdentifierScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:RegistrationIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"California business registration identifier scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/CaliforniaBusinessRegistrationIdentifierScheme">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/CaliforniaBusinessRegistrationIdentifierScheme</seealso>
    let CaliforniaBusinessRegistrationIdentifierScheme =
        Prefixed_Name(fibo_fbc_fct_usjrga, "CaliforniaBusinessRegistrationIdentifierScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:CaliforniaBusinessRegistrationService</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegistrationAuthorities:RegistrationService</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"California business registration service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/CaliforniaBusinessRegistrationService">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/CaliforniaBusinessRegistrationService</seealso>
    let CaliforniaBusinessRegistrationService =
        Prefixed_Name(fibo_fbc_fct_usjrga, "CaliforniaBusinessRegistrationService") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:CaliforniaDepartmentOfBusinessOversight</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:StateGovernmentEntity</para>
    ///   <para>fibo-be-ge-ge:GovernmentDepartment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"California Department of Business Oversight"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/CaliforniaDepartmentOfBusinessOversight">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/CaliforniaDepartmentOfBusinessOversight</seealso>
    let CaliforniaDepartmentOfBusinessOversight =
        Prefixed_Name(fibo_fbc_fct_usjrga, "CaliforniaDepartmentOfBusinessOversight") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:CaliforniaRegistrationAuthorityCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:RegistrationAuthorityCode</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"California registration authority code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/CaliforniaRegistrationAuthorityCode">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/CaliforniaRegistrationAuthorityCode</seealso>
    let CaliforniaRegistrationAuthorityCode =
        Prefixed_Name(fibo_fbc_fct_usjrga, "CaliforniaRegistrationAuthorityCode") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:CommoditiesFuturesAndDerivativesRegulator</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:RegulatoryAgency</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegistrationAuthorities:RegistrationAuthority</para>
    ///
    /// labels<para>"commodities, futures and derivatives regulator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/CommoditiesFuturesAndDerivativesRegulator">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/CommoditiesFuturesAndDerivativesRegulator</seealso>
    let CommoditiesFuturesAndDerivativesRegulator =
        Prefixed_Name(fibo_fbc_fct_usjrga, "CommoditiesFuturesAndDerivativesRegulator") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:CommodityFuturesTradingCommission</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usjrga:FederalGovernmentEntity</para>
    ///   <para>fibo-be-ge-ge:GovernmentAgency</para>
    ///
    /// labels<para>"Commodity Futures Trading Commission"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/CommodityFuturesTradingCommission">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/CommodityFuturesTradingCommission</seealso>
    let CommodityFuturesTradingCommission =
        Prefixed_Name(fibo_fbc_fct_usjrga, "CommodityFuturesTradingCommission") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:ConsumerFinanceRegulator</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:RegulatoryAgency</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"consumer finance regulator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/ConsumerFinanceRegulator">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/ConsumerFinanceRegulator</seealso>
    let ConsumerFinanceRegulator =
        Prefixed_Name(fibo_fbc_fct_usjrga, "ConsumerFinanceRegulator") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:ConsumerFinancialProtectionBureau</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:FederalGovernmentEntity</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:GovernmentDepartment</para>
    ///
    /// labels<para>"Consumer Financial Protection Bureau"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/ConsumerFinancialProtectionBureau">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/ConsumerFinancialProtectionBureau</seealso>
    let ConsumerFinancialProtectionBureau =
        Prefixed_Name(fibo_fbc_fct_usjrga, "ConsumerFinancialProtectionBureau") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:CorporationServiceCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-pas-fpas:ThirdPartyAgent</para>
    ///   <para>fibo-fbc-pas-fpas:AgentForServiceOfProcess</para>
    ///
    /// labels<para>"Corporation Service Company"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/CorporationServiceCompany">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/CorporationServiceCompany</seealso>
    let CorporationServiceCompany =
        Prefixed_Name(fibo_fbc_fct_usjrga, "CorporationServiceCompany") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:CorporationServiceCompany-US-DE</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:Corporation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Corporation Service Company US-DE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/CorporationServiceCompany-US-DE">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/CorporationServiceCompany-US-DE</seealso>
    let CorporationServiceCompany_US_DE =
        Prefixed_Name(fibo_fbc_fct_usjrga, "CorporationServiceCompany-US-DE") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:CorporationServiceCompanyAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:PhysicalAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Corporation Service Company legal address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/CorporationServiceCompanyAddress">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/CorporationServiceCompanyAddress</seealso>
    let CorporationServiceCompanyAddress =
        Prefixed_Name(fibo_fbc_fct_usjrga, "CorporationServiceCompanyAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:CorporationServiceCompanyBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///
    /// labels<para>"Corporation Service Company business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/CorporationServiceCompanyBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/CorporationServiceCompanyBusinessEntityIdentifier</seealso>
    let CorporationServiceCompanyBusinessEntityIdentifier =
        Prefixed_Name(fibo_fbc_fct_usjrga, "CorporationServiceCompanyBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:CorporationTrustCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-pas-fpas:ThirdPartyAgent</para>
    ///   <para>fibo-fbc-pas-fpas:AgentForServiceOfProcess</para>
    ///
    /// labels<para>"Corporation Trust Company"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/CorporationTrustCompany">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/CorporationTrustCompany</seealso>
    let CorporationTrustCompany =
        Prefixed_Name(fibo_fbc_fct_usjrga, "CorporationTrustCompany") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:CorporationTrustCompany-US-DE</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:Corporation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Corporation Trust Company US-DE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/CorporationTrustCompany-US-DE">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/CorporationTrustCompany-US-DE</seealso>
    let CorporationTrustCompany_US_DE =
        Prefixed_Name(fibo_fbc_fct_usjrga, "CorporationTrustCompany-US-DE") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:CorporationTrustCompanyBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///
    /// labels<para>"Corporation Trust Company business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/CorporationTrustCompanyBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/CorporationTrustCompanyBusinessEntityIdentifier</seealso>
    let CorporationTrustCompanyBusinessEntityIdentifier =
        Prefixed_Name(fibo_fbc_fct_usjrga, "CorporationTrustCompanyBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:CorporationTrustCompanyHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:PhysicalAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Corporation Trust Company headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/CorporationTrustCompanyHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/CorporationTrustCompanyHeadquartersAddress</seealso>
    let CorporationTrustCompanyHeadquartersAddress =
        Prefixed_Name(fibo_fbc_fct_usjrga, "CorporationTrustCompanyHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:DTCCINCBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///
    /// labels<para>"The Depository Trust &amp; Clearing Corporation business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/DTCCINCBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/DTCCINCBusinessEntityIdentifier</seealso>
    let DTCCINCBusinessEntityIdentifier =
        Prefixed_Name(fibo_fbc_fct_usjrga, "DTCCINCBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:DTCFDICCertificateNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:FDICCertificateNumber</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"DTC FDIC certificate number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/DTCFDICCertificateNumber">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/DTCFDICCertificateNumber</seealso>
    let DTCFDICCertificateNumber =
        Prefixed_Name(fibo_fbc_fct_usjrga, "DTCFDICCertificateNumber") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:DTCRSSDIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:ResearchStatisticsSupervisionDiscountIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"RSSD identifier for The Depository Trust Company"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/DTCRSSDIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/DTCRSSDIdentifier</seealso>
    let DTCRSSDIdentifier =
        Prefixed_Name(fibo_fbc_fct_usjrga, "DTCRSSDIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:DTCRTN</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:RoutingTransitNumber</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"The Depository Trust Company RTN"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/DTCRTN">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/DTCRTN</seealso>
    let DTCRTN = Prefixed_Name(fibo_fbc_fct_usjrga, "DTCRTN") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:DelawareBusinessEntitiesRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:BusinessRegistry</para>
    ///
    /// labels<para>"Delaware business entities registry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/DelawareBusinessEntitiesRegistry">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/DelawareBusinessEntitiesRegistry</seealso>
    let DelawareBusinessEntitiesRegistry =
        Prefixed_Name(fibo_fbc_fct_usjrga, "DelawareBusinessEntitiesRegistry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:DelawareBusinessRegistrationIdentifierScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:RegistrationIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Delaware business registration identifier scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/DelawareBusinessRegistrationIdentifierScheme">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/DelawareBusinessRegistrationIdentifierScheme</seealso>
    let DelawareBusinessRegistrationIdentifierScheme =
        Prefixed_Name(fibo_fbc_fct_usjrga, "DelawareBusinessRegistrationIdentifierScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:DelawareBusinessRegistrationService</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegistrationAuthorities:RegistrationService</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Delaware business registration service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/DelawareBusinessRegistrationService">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/DelawareBusinessRegistrationService</seealso>
    let DelawareBusinessRegistrationService =
        Prefixed_Name(fibo_fbc_fct_usjrga, "DelawareBusinessRegistrationService") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:DelawareCorporationsRegulator</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:BusinessRegistrationAuthority</para>
    ///   <para>RegulatoryAgencies:RegulatoryAgency</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Delaware corporations regulator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/DelawareCorporationsRegulator">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/DelawareCorporationsRegulator</seealso>
    let DelawareCorporationsRegulator =
        Prefixed_Name(fibo_fbc_fct_usjrga, "DelawareCorporationsRegulator") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:DelawareDivisionOfCorporations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:GovernmentDepartment</para>
    ///   <para>fibo-fbc-fct-usjrga:StateGovernmentEntity</para>
    ///
    /// labels<para>"Delaware Division of Corporations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/DelawareDivisionOfCorporations">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/DelawareDivisionOfCorporations</seealso>
    let DelawareDivisionOfCorporations =
        Prefixed_Name(fibo_fbc_fct_usjrga, "DelawareDivisionOfCorporations") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:DelawareRegistrationAuthorityCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:RegistrationAuthorityCode</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Delaware registration authority code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/DelawareRegistrationAuthorityCode">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/DelawareRegistrationAuthorityCode</seealso>
    let DelawareRegistrationAuthorityCode =
        Prefixed_Name(fibo_fbc_fct_usjrga, "DelawareRegistrationAuthorityCode") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:EDGARRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegistrationAuthorities:Registry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EDGAR Repository"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/EDGARRepository">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/EDGARRepository</seealso>
    let EDGARRepository =
        Prefixed_Name(fibo_fbc_fct_usjrga, "EDGARRepository") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:EmployerIdentificationNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"employer identification number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/EmployerIdentificationNumber">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/EmployerIdentificationNumber</seealso>
    let EmployerIdentificationNumber =
        Prefixed_Name(fibo_fbc_fct_usjrga, "EmployerIdentificationNumber") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:EmployerIdentificationNumberingScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"employer identification numbering scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/EmployerIdentificationNumberingScheme">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/EmployerIdentificationNumberingScheme</seealso>
    let EmployerIdentificationNumberingScheme =
        Prefixed_Name(fibo_fbc_fct_usjrga, "EmployerIdentificationNumberingScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FDICBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///
    /// labels<para>"FDIC business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FDICBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FDICBusinessEntityIdentifier</seealso>
    let FDICBusinessEntityIdentifier =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FDICBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FDICCertificateNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"FDIC Certificate Number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FDICCertificateNumber">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FDICCertificateNumber</seealso>
    let FDICCertificateNumber =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FDICCertificateNumber") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FDICInstitutionDirectory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegistrationAuthorities:Registry</para>
    ///
    /// labels<para>"FDIC Institution Directory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FDICInstitutionDirectory">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FDICInstitutionDirectory</seealso>
    let FDICInstitutionDirectory =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FDICInstitutionDirectory") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FDICRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"FDIC registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FDICRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FDICRegistryEntry</seealso>
    let FDICRegistryEntry =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FDICRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FarmCreditAdministration</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:GovernmentAgency</para>
    ///   <para>fibo-fbc-fct-usjrga:FederalGovernmentEntity</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Farm Credit Administration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FarmCreditAdministration">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FarmCreditAdministration</seealso>
    let FarmCreditAdministration =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FarmCreditAdministration") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FarmCreditRegulator</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:PrimaryFederalRegulator</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-pas-fpas:FinancialServiceProvider</para>
    ///
    /// labels<para>"farm credit regulator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FarmCreditRegulator">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FarmCreditRegulator</seealso>
    let FarmCreditRegulator =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FarmCreditRegulator") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalDepositInsuranceCorporation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:Corporation</para>
    ///   <para>fibo-be-ge-ge:Instrumentality</para>
    ///   <para>fibo-fbc-fct-usjrga:FederalGovernmentEntity</para>
    ///
    /// labels<para>"Federal Deposit Insurance Corporation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalDepositInsuranceCorporation">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalDepositInsuranceCorporation</seealso>
    let FederalDepositInsuranceCorporation =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalDepositInsuranceCorporation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalDepositInsurerAndRegulator</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-pas-fpas:FinancialServiceProvider</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegistrationAuthorities:RegistrationAuthority</para>
    ///   <para>fibo-fbc-fct-usjrga:PrimaryFederalRegulator</para>
    ///
    /// labels<para>"federal deposit insurer and regulator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalDepositInsurerAndRegulator">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalDepositInsurerAndRegulator</seealso>
    let FederalDepositInsurerAndRegulator =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalDepositInsurerAndRegulator") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalFinancialInstitutionsExaminationCouncil</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:GovernmentAgency</para>
    ///   <para>fibo-fbc-fct-usjrga:FederalGovernmentEntity</para>
    ///
    /// labels<para>"Federal Financial Institutions Examination Council"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalFinancialInstitutionsExaminationCouncil">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalFinancialInstitutionsExaminationCouncil</seealso>
    let FederalFinancialInstitutionsExaminationCouncil =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalFinancialInstitutionsExaminationCouncil") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalFinancialInstitutionsExaminationRegulator</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:RegulatoryAgency</para>
    ///   <para>RegistrationAuthorities:RegistrationAuthority</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"federal financial institutions examination regulator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalFinancialInstitutionsExaminationRegulator">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalFinancialInstitutionsExaminationRegulator</seealso>
    let FederalFinancialInstitutionsExaminationRegulator =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalFinancialInstitutionsExaminationRegulator") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalGovernmentEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"federal government entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalGovernmentEntity">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalGovernmentEntity</seealso>
    let FederalGovernmentEntity =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalGovernmentEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalHousingFinanceAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usjrga:FederalGovernmentEntity</para>
    ///   <para>fibo-be-ge-ge:GovernmentAgency</para>
    ///
    /// labels<para>"Federal Housing Finance Agency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalHousingFinanceAgency">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalHousingFinanceAgency</seealso>
    let FederalHousingFinanceAgency =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalHousingFinanceAgency") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalHousingFinanceRegulator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usjrga:PrimaryFederalRegulator</para>
    ///   <para>RegistrationAuthorities:RegistrationAuthority</para>
    ///
    /// labels<para>"federal housing finance regulator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalHousingFinanceRegulator">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalHousingFinanceRegulator</seealso>
    let FederalHousingFinanceRegulator =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalHousingFinanceRegulator") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveBankOfAtlanta</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrictBank</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Federal Reserve Bank of Atlanta"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveBankOfAtlanta">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveBankOfAtlanta</seealso>
    let FederalReserveBankOfAtlanta =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveBankOfAtlanta") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveBankOfBoston</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrictBank</para>
    ///
    /// labels<para>"Federal Reserve Bank of Boston"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveBankOfBoston">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveBankOfBoston</seealso>
    let FederalReserveBankOfBoston =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveBankOfBoston") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveBankOfChicago</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrictBank</para>
    ///
    /// labels<para>"Federal Reserve Bank of Chicago"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveBankOfChicago">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveBankOfChicago</seealso>
    let FederalReserveBankOfChicago =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveBankOfChicago") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveBankOfCleveland</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrictBank</para>
    ///
    /// labels<para>"Federal Reserve Bank of Cleveland"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveBankOfCleveland">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveBankOfCleveland</seealso>
    let FederalReserveBankOfCleveland =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveBankOfCleveland") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveBankOfDallas</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrictBank</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Federal Reserve Bank of Dallas"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveBankOfDallas">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveBankOfDallas</seealso>
    let FederalReserveBankOfDallas =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveBankOfDallas") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveBankOfKansasCity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrictBank</para>
    ///
    /// labels<para>"Federal Reserve Bank of Kansas City"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveBankOfKansasCity">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveBankOfKansasCity</seealso>
    let FederalReserveBankOfKansasCity =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveBankOfKansasCity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveBankOfMinneapolis</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrictBank</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Federal Reserve Bank of Minneapolis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveBankOfMinneapolis">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveBankOfMinneapolis</seealso>
    let FederalReserveBankOfMinneapolis =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveBankOfMinneapolis") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveBankOfNewYork</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrictBank</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Federal Reserve Bank of New York"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveBankOfNewYork">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveBankOfNewYork</seealso>
    let FederalReserveBankOfNewYork =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveBankOfNewYork") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveBankOfNewYork-US-NY</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:Instrumentality</para>
    ///   <para>fibo-fbc-fct-usjrga:FederalGovernmentEntity</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Federal Reserve Bank of New York US-NY"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveBankOfNewYork-US-NY">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveBankOfNewYork-US-NY</seealso>
    let FederalReserveBankOfNewYork_US_NY =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveBankOfNewYork-US-NY") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveBankOfNewYorkAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///
    /// labels<para>"Federal Reserve Bank of New York address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveBankOfNewYorkAddress">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveBankOfNewYorkAddress</seealso>
    let FederalReserveBankOfNewYorkAddress =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveBankOfNewYorkAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveBankOfPhiladelphia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrictBank</para>
    ///
    /// labels<para>"Federal Reserve Bank of Philadelphia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveBankOfPhiladelphia">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveBankOfPhiladelphia</seealso>
    let FederalReserveBankOfPhiladelphia =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveBankOfPhiladelphia") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveBankOfRichmond</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrictBank</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Federal Reserve Bank of Richmond"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveBankOfRichmond">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveBankOfRichmond</seealso>
    let FederalReserveBankOfRichmond =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveBankOfRichmond") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveBankOfSanFrancisco</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrictBank</para>
    ///
    /// labels<para>"Federal Reserve Bank of San Francisco"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveBankOfSanFrancisco">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveBankOfSanFrancisco</seealso>
    let FederalReserveBankOfSanFrancisco =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveBankOfSanFrancisco") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveBankOfStLouis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrictBank</para>
    ///
    /// labels<para>"Federal Reserve Bank of St. Louis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveBankOfStLouis">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveBankOfStLouis</seealso>
    let FederalReserveBankOfStLouis =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveBankOfStLouis") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveBoard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usjrga:FederalGovernmentEntity</para>
    ///   <para>fibo-be-ge-ge:GovernmentDepartment</para>
    ///
    /// labels<para>"Federal Reserve Board"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveBoard">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveBoard</seealso>
    let FederalReserveBoard =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveBoard") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrict</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Federal Reserve district"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveDistrict">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveDistrict</seealso>
    let FederalReserveDistrict =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveDistrict") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrictBank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Federal Reserve district bank"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveDistrictBank">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveDistrictBank</seealso>
    let FederalReserveDistrictBank =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveDistrictBank") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrictIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Federal Reserve district identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveDistrictIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveDistrictIdentifier</seealso>
    let FederalReserveDistrictIdentifier =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveDistrictIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveEighthDistrict</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrict</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Federal Reserve Eighth District"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveEighthDistrict">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveEighthDistrict</seealso>
    let FederalReserveEighthDistrict =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveEighthDistrict") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveEighthDistrictIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrictIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Federal Reserve eighth district identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveEighthDistrictIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveEighthDistrictIdentifier</seealso>
    let FederalReserveEighthDistrictIdentifier =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveEighthDistrictIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveEleventhDistrict</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrict</para>
    ///
    /// labels<para>"Federal Reserve Eleventh District"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveEleventhDistrict">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveEleventhDistrict</seealso>
    let FederalReserveEleventhDistrict =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveEleventhDistrict") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveEleventhDistrictIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrictIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Federal Reserve eleventh district identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveEleventhDistrictIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveEleventhDistrictIdentifier</seealso>
    let FederalReserveEleventhDistrictIdentifier =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveEleventhDistrictIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveFifthDistrict</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrict</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Federal Reserve Fifth District"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveFifthDistrict">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveFifthDistrict</seealso>
    let FederalReserveFifthDistrict =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveFifthDistrict") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveFifthDistrictIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrictIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Federal Reserve fifth district identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveFifthDistrictIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveFifthDistrictIdentifier</seealso>
    let FederalReserveFifthDistrictIdentifier =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveFifthDistrictIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveFirstDistrict</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrict</para>
    ///
    /// labels<para>"Federal Reserve First District"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveFirstDistrict">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveFirstDistrict</seealso>
    let FederalReserveFirstDistrict =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveFirstDistrict") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveFirstDistrictIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrictIdentifier</para>
    ///
    /// labels<para>"Federal Reserve first district identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveFirstDistrictIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveFirstDistrictIdentifier</seealso>
    let FederalReserveFirstDistrictIdentifier =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveFirstDistrictIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveFourthDistrict</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrict</para>
    ///
    /// labels<para>"Federal Reserve Fourth District"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveFourthDistrict">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveFourthDistrict</seealso>
    let FederalReserveFourthDistrict =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveFourthDistrict") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveFourthDistrictIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrictIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Federal Reserve fourth district identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveFourthDistrictIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveFourthDistrictIdentifier</seealso>
    let FederalReserveFourthDistrictIdentifier =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveFourthDistrictIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveNinthDistrict</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrict</para>
    ///
    /// labels<para>"Federal Reserve Ninth District"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveNinthDistrict">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveNinthDistrict</seealso>
    let FederalReserveNinthDistrict =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveNinthDistrict") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveNinthDistrictIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrictIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Federal Reserve ninth district identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveNinthDistrictIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveNinthDistrictIdentifier</seealso>
    let FederalReserveNinthDistrictIdentifier =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveNinthDistrictIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveRegulatoryAgencyAndCentralBank</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:PrimaryFederalRegulator</para>
    ///   <para>fibo-fbc-fct-fse:CentralBank</para>
    ///   <para>RegistrationAuthorities:RegistrationAuthority</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Federal Reserve regulatory agency and central bank"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveRegulatoryAgencyAndCentralBank">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveRegulatoryAgencyAndCentralBank</seealso>
    let FederalReserveRegulatoryAgencyAndCentralBank =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveRegulatoryAgencyAndCentralBank") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveSecondDistrict</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrict</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Federal Reserve Second District"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveSecondDistrict">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveSecondDistrict</seealso>
    let FederalReserveSecondDistrict =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveSecondDistrict") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveSecondDistrictIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrictIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Federal Reserve second district identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveSecondDistrictIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveSecondDistrictIdentifier</seealso>
    let FederalReserveSecondDistrictIdentifier =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveSecondDistrictIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveSeventhDistrict</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrict</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Federal Reserve Seventh District"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveSeventhDistrict">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveSeventhDistrict</seealso>
    let FederalReserveSeventhDistrict =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveSeventhDistrict") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveSeventhDistrictIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrictIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Federal Reserve seventh district identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveSeventhDistrictIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveSeventhDistrictIdentifier</seealso>
    let FederalReserveSeventhDistrictIdentifier =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveSeventhDistrictIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveSixthDistrict</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrict</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Federal Reserve Sixth District"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveSixthDistrict">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveSixthDistrict</seealso>
    let FederalReserveSixthDistrict =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveSixthDistrict") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveSixthDistrictIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrictIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Federal Reserve sixth district identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveSixthDistrictIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveSixthDistrictIdentifier</seealso>
    let FederalReserveSixthDistrictIdentifier =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveSixthDistrictIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:GovernmentAgency</para>
    ///   <para>fibo-fbc-fct-usjrga:FederalGovernmentEntity</para>
    ///
    /// labels<para>"Federal Reserve System"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveSystem">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveSystem</seealso>
    let FederalReserveSystem =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveSystem") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveSystemAsMemberBearingOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Organizations:MemberBearingOrganization</para>
    ///
    /// labels<para>"Federal Reserve System as member bearing organization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveSystemAsMemberBearingOrganization">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveSystemAsMemberBearingOrganization</seealso>
    let FederalReserveSystemAsMemberBearingOrganization =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveSystemAsMemberBearingOrganization") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveSystemMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Federal Reserve System member"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveSystemMember">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveSystemMember</seealso>
    let FederalReserveSystemMember =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveSystemMember") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveSystemMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Organizations:Membership</para>
    ///
    /// labels<para>"Federal Reserve System membership"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveSystemMembership">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveSystemMembership</seealso>
    let FederalReserveSystemMembership =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveSystemMembership") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveSystemNonMemberInstitution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Federal Reserve System non-member institution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveSystemNonMemberInstitution">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveSystemNonMemberInstitution</seealso>
    let FederalReserveSystemNonMemberInstitution =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveSystemNonMemberInstitution") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveTenthDistrict</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrict</para>
    ///
    /// labels<para>"Federal Reserve Tenth District"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveTenthDistrict">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveTenthDistrict</seealso>
    let FederalReserveTenthDistrict =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveTenthDistrict") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveTenthDistrictIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrictIdentifier</para>
    ///
    /// labels<para>"Federal Reserve tenth district identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveTenthDistrictIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveTenthDistrictIdentifier</seealso>
    let FederalReserveTenthDistrictIdentifier =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveTenthDistrictIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveThirdDistrict</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrict</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Federal Reserve Third District"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveThirdDistrict">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveThirdDistrict</seealso>
    let FederalReserveThirdDistrict =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveThirdDistrict") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveThirdDistrictIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrictIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Federal Reserve third district identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveThirdDistrictIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveThirdDistrictIdentifier</seealso>
    let FederalReserveThirdDistrictIdentifier =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveThirdDistrictIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveTwelfthDistrict</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrict</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Federal Reserve Twelfth District"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveTwelfthDistrict">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveTwelfthDistrict</seealso>
    let FederalReserveTwelfthDistrict =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveTwelfthDistrict") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveTwelfthDistrictIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveDistrictIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Federal Reserve twelfth district identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveTwelfthDistrictIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveTwelfthDistrictIdentifier</seealso>
    let FederalReserveTwelfthDistrictIdentifier =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalReserveTwelfthDistrictIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FederalStabilityMonitorAndRegulator</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:RegulatoryAgency</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"federal stability monitor and regulator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalStabilityMonitorAndRegulator">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalStabilityMonitorAndRegulator</seealso>
    let FederalStabilityMonitorAndRegulator =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FederalStabilityMonitorAndRegulator") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FinancialIndustryRegulator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-fse:SelfRegulatingOrganization</para>
    ///
    /// labels<para>"financial industry regulator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FinancialIndustryRegulator">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FinancialIndustryRegulator</seealso>
    let FinancialIndustryRegulator =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FinancialIndustryRegulator") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FinancialIndustryRegulatoryAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-fbo:NonGovernmentalOrganization</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Financial Industry Regulatory Authority"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FinancialIndustryRegulatoryAuthority">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FinancialIndustryRegulatoryAuthority</seealso>
    let FinancialIndustryRegulatoryAuthority =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FinancialIndustryRegulatoryAuthority") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:FinancialStabilityOversightCouncil</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usjrga:FederalGovernmentEntity</para>
    ///   <para>fibo-be-ge-ge:GovernmentDepartment</para>
    ///
    /// labels<para>"Financial Stability Oversight Council"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FinancialStabilityOversightCouncil">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FinancialStabilityOversightCouncil</seealso>
    let FinancialStabilityOversightCouncil =
        Prefixed_Name(fibo_fbc_fct_usjrga, "FinancialStabilityOversightCouncil") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:IssuerIdentificationNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"issuer identification number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/IssuerIdentificationNumber">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/IssuerIdentificationNumber</seealso>
    let IssuerIdentificationNumber =
        Prefixed_Name(fibo_fbc_fct_usjrga, "IssuerIdentificationNumber") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:MassachusettsBusinessRegistrar</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:BusinessRegistrationAuthority</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:RegulatoryAgency</para>
    ///
    /// labels<para>"Massachusetts business registrar"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/MassachusettsBusinessRegistrar">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/MassachusettsBusinessRegistrar</seealso>
    let MassachusettsBusinessRegistrar =
        Prefixed_Name(fibo_fbc_fct_usjrga, "MassachusettsBusinessRegistrar") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:MassachusettsBusinessRegistrationIdentifierScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:RegistrationIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Massachusetts business registration identifier scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/MassachusettsBusinessRegistrationIdentifierScheme">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/MassachusettsBusinessRegistrationIdentifierScheme</seealso>
    let MassachusettsBusinessRegistrationIdentifierScheme =
        Prefixed_Name(fibo_fbc_fct_usjrga, "MassachusettsBusinessRegistrationIdentifierScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:MassachusettsBusinessRegistrationService</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegistrationAuthorities:RegistrationService</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Massachusetts business registration service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/MassachusettsBusinessRegistrationService">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/MassachusettsBusinessRegistrationService</seealso>
    let MassachusettsBusinessRegistrationService =
        Prefixed_Name(fibo_fbc_fct_usjrga, "MassachusettsBusinessRegistrationService") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:MassachusettsCorporationRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:BusinessRegistry</para>
    ///
    /// labels<para>"Massachusetts corporation registry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/MassachusettsCorporationRegistry">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/MassachusettsCorporationRegistry</seealso>
    let MassachusettsCorporationRegistry =
        Prefixed_Name(fibo_fbc_fct_usjrga, "MassachusettsCorporationRegistry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:MassachusettsCorporationsDivision</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:StateGovernmentEntity</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:GovernmentDepartment</para>
    ///
    /// labels<para>"Massachusetts Corporations Division"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/MassachusettsCorporationsDivision">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/MassachusettsCorporationsDivision</seealso>
    let MassachusettsCorporationsDivision =
        Prefixed_Name(fibo_fbc_fct_usjrga, "MassachusettsCorporationsDivision") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:MassachusettsRegistrationAuthorityCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:RegistrationAuthorityCode</para>
    ///
    /// labels<para>"Massachusetts Registration Authority Code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/MassachusettsRegistrationAuthorityCode">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/MassachusettsRegistrationAuthorityCode</seealso>
    let MassachusettsRegistrationAuthorityCode =
        Prefixed_Name(fibo_fbc_fct_usjrga, "MassachusettsRegistrationAuthorityCode") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:NICRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"National Information Center (NIC) registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/NICRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/NICRegistryEntry</seealso>
    let NICRegistryEntry =
        Prefixed_Name(fibo_fbc_fct_usjrga, "NICRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:NationalBankingRegulator</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:PrimaryFederalRegulator</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegistrationAuthorities:RegistrationAuthority</para>
    ///
    /// labels<para>"national banking regulator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/NationalBankingRegulator">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/NationalBankingRegulator</seealso>
    let NationalBankingRegulator =
        Prefixed_Name(fibo_fbc_fct_usjrga, "NationalBankingRegulator") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:NationalCreditUnionAdministration</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:FederalGovernmentEntity</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:GovernmentAgency</para>
    ///
    /// labels<para>"National Credit Union Administration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/NationalCreditUnionAdministration">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/NationalCreditUnionAdministration</seealso>
    let NationalCreditUnionAdministration =
        Prefixed_Name(fibo_fbc_fct_usjrga, "NationalCreditUnionAdministration") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:NationalCreditUnionInsurerAndRegulator</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegistrationAuthorities:RegistrationAuthority</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-pas-fpas:FinancialServiceProvider</para>
    ///   <para>fibo-fbc-fct-usjrga:PrimaryFederalRegulator</para>
    ///
    /// labels<para>"national credit union insurer and regulator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/NationalCreditUnionInsurerAndRegulator">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/NationalCreditUnionInsurerAndRegulator</seealso>
    let NationalCreditUnionInsurerAndRegulator =
        Prefixed_Name(fibo_fbc_fct_usjrga, "NationalCreditUnionInsurerAndRegulator") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:NationalInformationCenterRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegistrationAuthorities:Registry</para>
    ///
    /// labels<para>"National Information Center (NIC) Repository"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/NationalInformationCenterRepository">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/NationalInformationCenterRepository</seealso>
    let NationalInformationCenterRepository =
        Prefixed_Name(fibo_fbc_fct_usjrga, "NationalInformationCenterRepository") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:NewYorkBusinessEntitiesRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:BusinessRegistry</para>
    ///
    /// labels<para>"New York State (NYS) business entities registry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/NewYorkBusinessEntitiesRegistry">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/NewYorkBusinessEntitiesRegistry</seealso>
    let NewYorkBusinessEntitiesRegistry =
        Prefixed_Name(fibo_fbc_fct_usjrga, "NewYorkBusinessEntitiesRegistry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:NewYorkBusinessRegistrationIdentifierScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:RegistrationIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"New York business registration identifier scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/NewYorkBusinessRegistrationIdentifierScheme">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/NewYorkBusinessRegistrationIdentifierScheme</seealso>
    let NewYorkBusinessRegistrationIdentifierScheme =
        Prefixed_Name(fibo_fbc_fct_usjrga, "NewYorkBusinessRegistrationIdentifierScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:NewYorkBusinessRegistrationService</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegistrationAuthorities:RegistrationService</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State of New York business registration service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/NewYorkBusinessRegistrationService">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/NewYorkBusinessRegistrationService</seealso>
    let NewYorkBusinessRegistrationService =
        Prefixed_Name(fibo_fbc_fct_usjrga, "NewYorkBusinessRegistrationService") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:NewYorkCorporationsRegulator</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:BusinessRegistrationAuthority</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:RegulatoryAgency</para>
    ///
    /// labels<para>"State of New York corporations regulator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/NewYorkCorporationsRegulator">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/NewYorkCorporationsRegulator</seealso>
    let NewYorkCorporationsRegulator =
        Prefixed_Name(fibo_fbc_fct_usjrga, "NewYorkCorporationsRegulator") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:NewYorkDivisionOfCorporations</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:GovernmentDepartment</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usjrga:StateGovernmentEntity</para>
    ///
    /// labels<para>"New York State (NYS) Department of State Division of Corporations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/NewYorkDivisionOfCorporations">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/NewYorkDivisionOfCorporations</seealso>
    let NewYorkDivisionOfCorporations =
        Prefixed_Name(fibo_fbc_fct_usjrga, "NewYorkDivisionOfCorporations") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:NewYorkRegistrationAuthorityCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:RegistrationAuthorityCode</para>
    ///
    /// labels<para>"New York Registration Authority Code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/NewYorkRegistrationAuthorityCode">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/NewYorkRegistrationAuthorityCode</seealso>
    let NewYorkRegistrationAuthorityCode =
        Prefixed_Name(fibo_fbc_fct_usjrga, "NewYorkRegistrationAuthorityCode") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:NonDepositoryTrustCompany-MemberInstitution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"non-depository trust company - member institution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/NonDepositoryTrustCompany-MemberInstitution">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/NonDepositoryTrustCompany-MemberInstitution</seealso>
    let NonDepositoryTrustCompany_MemberInstitution =
        Prefixed_Name(fibo_fbc_fct_usjrga, "NonDepositoryTrustCompany-MemberInstitution") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:NonDepositoryTrustCompany-NonMemberInstitution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"non-depository trust company - non-member institution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/NonDepositoryTrustCompany-NonMemberInstitution">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/NonDepositoryTrustCompany-NonMemberInstitution</seealso>
    let NonDepositoryTrustCompany_NonMemberInstitution =
        Prefixed_Name(fibo_fbc_fct_usjrga, "NonDepositoryTrustCompany-NonMemberInstitution") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:OfficeOfTheComptrollerOfTheCurrency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:GovernmentDepartment</para>
    ///
    /// labels<para>"Office of the Comptroller of the Currency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/OfficeOfTheComptrollerOfTheCurrency">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/OfficeOfTheComptrollerOfTheCurrency</seealso>
    let OfficeOfTheComptrollerOfTheCurrency =
        Prefixed_Name(fibo_fbc_fct_usjrga, "OfficeOfTheComptrollerOfTheCurrency") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:OfficeOfThriftSupervision</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-ge-ge:GovernmentDepartment</para>
    ///   <para>fibo-fbc-fct-usjrga:FederalGovernmentEntity</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Office of Thrift Supervision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/OfficeOfThriftSupervision">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/OfficeOfThriftSupervision</seealso>
    let OfficeOfThriftSupervision =
        Prefixed_Name(fibo_fbc_fct_usjrga, "OfficeOfThriftSupervision") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:OhioBusinessFilingPortal</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:BusinessRegistry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Ohio Business Filing Portal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/OhioBusinessFilingPortal">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/OhioBusinessFilingPortal</seealso>
    let OhioBusinessFilingPortal =
        Prefixed_Name(fibo_fbc_fct_usjrga, "OhioBusinessFilingPortal") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:OhioBusinessRegistrar</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:RegulatoryAgency</para>
    ///   <para>fibo-fbc-fct-breg:BusinessRegistrationAuthority</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Ohio business registrar"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/OhioBusinessRegistrar">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/OhioBusinessRegistrar</seealso>
    let OhioBusinessRegistrar =
        Prefixed_Name(fibo_fbc_fct_usjrga, "OhioBusinessRegistrar") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:OhioBusinessRegistrationIdentifierScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:RegistrationIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Ohio business registration identifier scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/OhioBusinessRegistrationIdentifierScheme">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/OhioBusinessRegistrationIdentifierScheme</seealso>
    let OhioBusinessRegistrationIdentifierScheme =
        Prefixed_Name(fibo_fbc_fct_usjrga, "OhioBusinessRegistrationIdentifierScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:OhioBusinessRegistrationService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegistrationAuthorities:RegistrationService</para>
    ///
    /// labels<para>"Ohio business registration service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/OhioBusinessRegistrationService">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/OhioBusinessRegistrationService</seealso>
    let OhioBusinessRegistrationService =
        Prefixed_Name(fibo_fbc_fct_usjrga, "OhioBusinessRegistrationService") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:OhioBusinessServicesDivision</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:StateGovernmentEntity</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:GovernmentDepartment</para>
    ///
    /// labels<para>"Ohio Business Services Division"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/OhioBusinessServicesDivision">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/OhioBusinessServicesDivision</seealso>
    let OhioBusinessServicesDivision =
        Prefixed_Name(fibo_fbc_fct_usjrga, "OhioBusinessServicesDivision") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:OhioRegistrationAuthorityCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:RegistrationAuthorityCode</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Ohio Registration Authority Code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/OhioRegistrationAuthorityCode">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/OhioRegistrationAuthorityCode</seealso>
    let OhioRegistrationAuthorityCode =
        Prefixed_Name(fibo_fbc_fct_usjrga, "OhioRegistrationAuthorityCode") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:PrimaryFederalRegulator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"primary federal regulator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/PrimaryFederalRegulator">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/PrimaryFederalRegulator</seealso>
    let PrimaryFederalRegulator =
        Prefixed_Name(fibo_fbc_fct_usjrga, "PrimaryFederalRegulator") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:ResearchStatisticsSupervisionDiscountIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Research, Statistics, Supervision and Regulation, and Discount and Credit identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/ResearchStatisticsSupervisionDiscountIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/ResearchStatisticsSupervisionDiscountIdentifier</seealso>
    let ResearchStatisticsSupervisionDiscountIdentifier =
        Prefixed_Name(fibo_fbc_fct_usjrga, "ResearchStatisticsSupervisionDiscountIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:RoutingTransitNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"routing transit number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/RoutingTransitNumber">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/RoutingTransitNumber</seealso>
    let RoutingTransitNumber =
        Prefixed_Name(fibo_fbc_fct_usjrga, "RoutingTransitNumber") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:SecuritiesAndExchangeCommission</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:FederalGovernmentEntity</para>
    ///   <para>fibo-be-ge-ge:GovernmentAgency</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Securities and Exchange Commission"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/SecuritiesAndExchangeCommission">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/SecuritiesAndExchangeCommission</seealso>
    let SecuritiesAndExchangeCommission =
        Prefixed_Name(fibo_fbc_fct_usjrga, "SecuritiesAndExchangeCommission") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:SecuritiesAndExchangeRegulator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegistrationAuthorities:RegistrationAuthority</para>
    ///   <para>fibo-fbc-fct-usjrga:PrimaryFederalRegulator</para>
    ///
    /// labels<para>"securities and exchange regulator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/SecuritiesAndExchangeRegulator">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/SecuritiesAndExchangeRegulator</seealso>
    let SecuritiesAndExchangeRegulator =
        Prefixed_Name(fibo_fbc_fct_usjrga, "SecuritiesAndExchangeRegulator") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:SouthDakotaBusinessInformationRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:BusinessRegistry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"South Dakota business entities registry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/SouthDakotaBusinessInformationRegistry">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/SouthDakotaBusinessInformationRegistry</seealso>
    let SouthDakotaBusinessInformationRegistry =
        Prefixed_Name(fibo_fbc_fct_usjrga, "SouthDakotaBusinessInformationRegistry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:SouthDakotaBusinessRegistrationIdentifierScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:RegistrationIdentifierScheme</para>
    ///
    /// labels<para>"South Dakota business registration identifier scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/SouthDakotaBusinessRegistrationIdentifierScheme">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/SouthDakotaBusinessRegistrationIdentifierScheme</seealso>
    let SouthDakotaBusinessRegistrationIdentifierScheme =
        Prefixed_Name(fibo_fbc_fct_usjrga, "SouthDakotaBusinessRegistrationIdentifierScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:SouthDakotaBusinessRegistrationService</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegistrationAuthorities:RegistrationService</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"South Dakota business registration service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/SouthDakotaBusinessRegistrationService">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/SouthDakotaBusinessRegistrationService</seealso>
    let SouthDakotaBusinessRegistrationService =
        Prefixed_Name(fibo_fbc_fct_usjrga, "SouthDakotaBusinessRegistrationService") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:SouthDakotaCorporationsDivision</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:StateGovernmentEntity</para>
    ///   <para>fibo-be-ge-ge:GovernmentDepartment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"South Dakota, Secretary of State Corporations Division"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/SouthDakotaCorporationsDivision">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/SouthDakotaCorporationsDivision</seealso>
    let SouthDakotaCorporationsDivision =
        Prefixed_Name(fibo_fbc_fct_usjrga, "SouthDakotaCorporationsDivision") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:SouthDakotaCorporationsRegulator</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:BusinessRegistrationAuthority</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:RegulatoryAgency</para>
    ///
    /// labels<para>"South Dakota corporations regulator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/SouthDakotaCorporationsRegulator">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/SouthDakotaCorporationsRegulator</seealso>
    let SouthDakotaCorporationsRegulator =
        Prefixed_Name(fibo_fbc_fct_usjrga, "SouthDakotaCorporationsRegulator") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:SouthDakotaRegistrationAuthorityCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:RegistrationAuthorityCode</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"South Dakota Registration Authority Code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/SouthDakotaRegistrationAuthorityCode">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/SouthDakotaRegistrationAuthorityCode</seealso>
    let SouthDakotaRegistrationAuthorityCode =
        Prefixed_Name(fibo_fbc_fct_usjrga, "SouthDakotaRegistrationAuthorityCode") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:StateGovernmentEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"state government entity or agency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/StateGovernmentEntity">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/StateGovernmentEntity</seealso>
    let StateGovernmentEntity =
        Prefixed_Name(fibo_fbc_fct_usjrga, "StateGovernmentEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:StateMemberBank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"state member bank"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/StateMemberBank">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/StateMemberBank</seealso>
    let StateMemberBank =
        Prefixed_Name(fibo_fbc_fct_usjrga, "StateMemberBank") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:TaxpayerIdentificationNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"taxpayer identification number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/TaxpayerIdentificationNumber">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/TaxpayerIdentificationNumber</seealso>
    let TaxpayerIdentificationNumber =
        Prefixed_Name(fibo_fbc_fct_usjrga, "TaxpayerIdentificationNumber") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:TaxpayerIdentificationNumberingScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"taxpayer identification numbering scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/TaxpayerIdentificationNumberingScheme">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/TaxpayerIdentificationNumberingScheme</seealso>
    let TaxpayerIdentificationNumberingScheme =
        Prefixed_Name(fibo_fbc_fct_usjrga, "TaxpayerIdentificationNumberingScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:ThriftRegulator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usjrga:PrimaryFederalRegulator</para>
    ///
    /// labels<para>"thrift regulator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/ThriftRegulator">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/ThriftRegulator</seealso>
    let ThriftRegulator =
        Prefixed_Name(fibo_fbc_fct_usjrga, "ThriftRegulator") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:USDepartmentOfTheTreasury</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:FederalGovernmentEntity</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:GovernmentAgency</para>
    ///
    /// labels<para>"U.S. Department of the Treasury"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/USDepartmentOfTheTreasury">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/USDepartmentOfTheTreasury</seealso>
    let USDepartmentOfTheTreasury =
        Prefixed_Name(fibo_fbc_fct_usjrga, "USDepartmentOfTheTreasury") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:UniformBankPerformanceReportRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegistrationAuthorities:Registry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Uniform Bank Performance Report (UBPR) Repository"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/UniformBankPerformanceReportRepository">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/UniformBankPerformanceReportRepository</seealso>
    let UniformBankPerformanceReportRepository =
        Prefixed_Name(fibo_fbc_fct_usjrga, "UniformBankPerformanceReportRepository") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:hasPrimaryFederalRegulator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has primary federal regulator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/hasPrimaryFederalRegulator">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/hasPrimaryFederalRegulator</seealso>
    let hasPrimaryFederalRegulator =
        Prefixed_Name(fibo_fbc_fct_usjrga, "hasPrimaryFederalRegulator") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-usjrga:hasSecondaryFederalRegulator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has secondary federal regulator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/hasSecondaryFederalRegulator">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/hasSecondaryFederalRegulator</seealso>
    let hasSecondaryFederalRegulator =
        Prefixed_Name(fibo_fbc_fct_usjrga, "hasSecondaryFederalRegulator") |> PrefixedName
