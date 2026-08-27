namespace https.spec.edmcouncil.org.fibo.ontology.EXMP.LegalEntities.FinancialInstitutionExamples.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_exmp_le_finst =
    let _namespace_iri = Namespace_Iri fibo_exmp_le_finst |> NamespaceIRI

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BNYMellonNationalAssociationAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:PhysicalAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"BNY Mellon, National Association address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BNYMellonNationalAssociationAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BNYMellonNationalAssociationAddress</seealso>
    let BNYMellonNationalAssociationAddress =
        Prefixed_Name(fibo_exmp_le_finst, "BNYMellonNationalAssociationAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BNYMellonNationalAssociationBusinessEntityIdentifier-SD</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///
    /// labels<para>"business entity identifier for BNY Mellon, National Association"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BNYMellonNationalAssociationBusinessEntityIdentifier-SD">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BNYMellonNationalAssociationBusinessEntityIdentifier-SD</seealso>
    let BNYMellonNationalAssociationBusinessEntityIdentifier_SD =
        Prefixed_Name(fibo_exmp_le_finst, "BNYMellonNationalAssociationBusinessEntityIdentifier-SD") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BNYMellonNationalAssociationBusinessIdentifierCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-fse:BusinessIdentifierCode</para>
    ///
    /// labels<para>"BNY Mellon, National Association - Business Identifier Code (BIC)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BNYMellonNationalAssociationBusinessIdentifierCode">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BNYMellonNationalAssociationBusinessIdentifierCode</seealso>
    let BNYMellonNationalAssociationBusinessIdentifierCode =
        Prefixed_Name(fibo_exmp_le_finst, "BNYMellonNationalAssociationBusinessIdentifierCode") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BNYMellonNationalAssociationBusinessPartyPrefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-fse:BusinessPartyPrefix</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"BNY Mellon, National Association business party prefix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BNYMellonNationalAssociationBusinessPartyPrefix">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BNYMellonNationalAssociationBusinessPartyPrefix</seealso>
    let BNYMellonNationalAssociationBusinessPartyPrefix =
        Prefixed_Name(fibo_exmp_le_finst, "BNYMellonNationalAssociationBusinessPartyPrefix") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BNYMellonNationalAssociationBusinessPartySuffix</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-fse:BusinessPartySuffix</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"BNY Mellon, National Association business party suffix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BNYMellonNationalAssociationBusinessPartySuffix">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BNYMellonNationalAssociationBusinessPartySuffix</seealso>
    let BNYMellonNationalAssociationBusinessPartySuffix =
        Prefixed_Name(fibo_exmp_le_finst, "BNYMellonNationalAssociationBusinessPartySuffix") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BNYMellonNationalAssociationDateEstablished</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///
    /// labels<para>"BNY Mellon, National Association date established"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BNYMellonNationalAssociationDateEstablished">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BNYMellonNationalAssociationDateEstablished</seealso>
    let BNYMellonNationalAssociationDateEstablished =
        Prefixed_Name(fibo_exmp_le_finst, "BNYMellonNationalAssociationDateEstablished") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BNYMellonNationalAssociationDateInsured</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"BNY Mellon, National Association date insured"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BNYMellonNationalAssociationDateInsured">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BNYMellonNationalAssociationDateInsured</seealso>
    let BNYMellonNationalAssociationDateInsured =
        Prefixed_Name(fibo_exmp_le_finst, "BNYMellonNationalAssociationDateInsured") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BNYMellonNationalAssociationFDICCertificateNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usjrga:FDICCertificateNumber</para>
    ///
    /// labels<para>"BNY Mellon, National Association FDIC Certificate number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BNYMellonNationalAssociationFDICCertificateNumber">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BNYMellonNationalAssociationFDICCertificateNumber</seealso>
    let BNYMellonNationalAssociationFDICCertificateNumber =
        Prefixed_Name(fibo_exmp_le_finst, "BNYMellonNationalAssociationFDICCertificateNumber") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BNYMellonNationalAssociationLegalEntityIdentifierRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:LegalEntityIdentifierRegistryEntry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"BNY Mellon, National Association legal entity identifier registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BNYMellonNationalAssociationLegalEntityIdentifierRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BNYMellonNationalAssociationLegalEntityIdentifierRegistryEntry</seealso>
    let BNYMellonNationalAssociationLegalEntityIdentifierRegistryEntry =
        Prefixed_Name(fibo_exmp_le_finst, "BNYMellonNationalAssociationLegalEntityIdentifierRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BNYMellonNationalAssociationRSSDIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:ResearchStatisticsSupervisionDiscountIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"BNY Mellon, National Association RSSD identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BNYMellonNationalAssociationRSSDIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BNYMellonNationalAssociationRSSDIdentifier</seealso>
    let BNYMellonNationalAssociationRSSDIdentifier =
        Prefixed_Name(fibo_exmp_le_finst, "BNYMellonNationalAssociationRSSDIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BNYMellonNationalAssociationRTN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usjrga:RoutingTransitNumber</para>
    ///
    /// labels<para>"BNY Mellon, National Association RTN"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BNYMellonNationalAssociationRTN">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BNYMellonNationalAssociationRTN</seealso>
    let BNYMellonNationalAssociationRTN =
        Prefixed_Name(fibo_exmp_le_finst, "BNYMellonNationalAssociationRTN") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BankOfAmericaEurope</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-fse:BrokerageFirm</para>
    ///   <para>fibo-fbc-fct-fse:CommercialBank</para>
    ///   <para>fibo-fbc-fct-fse:CommodityTradingAdvisor</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-der-drc-swp:SwapDealer</para>
    ///   <para>fibo-der-drc-bsc:IntroducingBroker</para>
    ///
    /// labels<para>"Bank of America Europe"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfAmericaEurope">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfAmericaEurope</seealso>
    let BankOfAmericaEurope =
        Prefixed_Name(fibo_exmp_le_finst, "BankOfAmericaEurope") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BankOfAmericaEuropeEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:Corporation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Bank of America Europe entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfAmericaEuropeEntity">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfAmericaEuropeEntity</seealso>
    let BankOfAmericaEuropeEntity =
        Prefixed_Name(fibo_exmp_le_finst, "BankOfAmericaEuropeEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BankOfAmericaEuropeHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///
    /// labels<para>"Bank of America Europe headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfAmericaEuropeHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfAmericaEuropeHeadquartersAddress</seealso>
    let BankOfAmericaEuropeHeadquartersAddress =
        Prefixed_Name(fibo_exmp_le_finst, "BankOfAmericaEuropeHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BankOfAmericaEuropeLegalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///
    /// labels<para>"Bank of America Europe legal address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfAmericaEuropeLegalAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfAmericaEuropeLegalAddress</seealso>
    let BankOfAmericaEuropeLegalAddress =
        Prefixed_Name(fibo_exmp_le_finst, "BankOfAmericaEuropeLegalAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BankOfAmericaEuropeLegalEntityIdentifierRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:LegalEntityIdentifierRegistryEntry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Bank of America Europe legal entity identifier registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfAmericaEuropeLegalEntityIdentifierRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfAmericaEuropeLegalEntityIdentifierRegistryEntry</seealso>
    let BankOfAmericaEuropeLegalEntityIdentifierRegistryEntry =
        Prefixed_Name(fibo_exmp_le_finst, "BankOfAmericaEuropeLegalEntityIdentifierRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BankOfAmericaNationalAssociation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usfse:NationalBank</para>
    ///
    /// labels<para>"Bank of America, National Association"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfAmericaNationalAssociation">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfAmericaNationalAssociation</seealso>
    let BankOfAmericaNationalAssociation =
        Prefixed_Name(fibo_exmp_le_finst, "BankOfAmericaNationalAssociation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BankOfAmericaNationalAssociation-US</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-lp:BusinessEntity</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Bank of America, National Association US"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfAmericaNationalAssociation-US">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfAmericaNationalAssociation-US</seealso>
    let BankOfAmericaNationalAssociation_US =
        Prefixed_Name(fibo_exmp_le_finst, "BankOfAmericaNationalAssociation-US") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BankOfAmericaNationalAssociationDateEstablished</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///
    /// labels<para>"Bank of America, National Association date established"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfAmericaNationalAssociationDateEstablished">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfAmericaNationalAssociationDateEstablished</seealso>
    let BankOfAmericaNationalAssociationDateEstablished =
        Prefixed_Name(fibo_exmp_le_finst, "BankOfAmericaNationalAssociationDateEstablished") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BankOfAmericaNationalAssociationDateInsured</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///
    /// labels<para>"Bank of America, National Association date insured"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfAmericaNationalAssociationDateInsured">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfAmericaNationalAssociationDateInsured</seealso>
    let BankOfAmericaNationalAssociationDateInsured =
        Prefixed_Name(fibo_exmp_le_finst, "BankOfAmericaNationalAssociationDateInsured") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BankOfAmericaNationalAssociationHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:PhysicalAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Bank of America, National Association headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfAmericaNationalAssociationHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfAmericaNationalAssociationHeadquartersAddress</seealso>
    let BankOfAmericaNationalAssociationHeadquartersAddress =
        Prefixed_Name(fibo_exmp_le_finst, "BankOfAmericaNationalAssociationHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BankOfAmericaNationalAssociationLegalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:PhysicalAddress</para>
    ///
    /// labels<para>"Bank of America, National Association legal address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfAmericaNationalAssociationLegalAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfAmericaNationalAssociationLegalAddress</seealso>
    let BankOfAmericaNationalAssociationLegalAddress =
        Prefixed_Name(fibo_exmp_le_finst, "BankOfAmericaNationalAssociationLegalAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BankOfAmericaNationalAssociationLegalEntityIdentifierRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:LegalEntityIdentifierRegistryEntry</para>
    ///
    /// labels<para>"Bank of America, National Association legal entity identifier registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfAmericaNationalAssociationLegalEntityIdentifierRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfAmericaNationalAssociationLegalEntityIdentifierRegistryEntry</seealso>
    let BankOfAmericaNationalAssociationLegalEntityIdentifierRegistryEntry =
        Prefixed_Name(fibo_exmp_le_finst, "BankOfAmericaNationalAssociationLegalEntityIdentifierRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BankOfNewYorkMellonCorporation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usfse:FinancialHoldingCompany</para>
    ///
    /// labels<para>"The Bank of New York Mellon Corporation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfNewYorkMellonCorporation">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfNewYorkMellonCorporation</seealso>
    let BankOfNewYorkMellonCorporation =
        Prefixed_Name(fibo_exmp_le_finst, "BankOfNewYorkMellonCorporation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BankOfNewYorkMellonCorporation-US-DE</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:PubliclyHeldCompany</para>
    ///   <para>fibo-be-le-cb:ForProfitCorporation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"The Bank of New York Mellon Corporation US-DE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfNewYorkMellonCorporation-US-DE">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfNewYorkMellonCorporation-US-DE</seealso>
    let BankOfNewYorkMellonCorporation_US_DE =
        Prefixed_Name(fibo_exmp_le_finst, "BankOfNewYorkMellonCorporation-US-DE") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BankOfNewYorkMellonCorporationAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:PhysicalAddress</para>
    ///
    /// labels<para>"Bank of New York Mellon Corporation address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfNewYorkMellonCorporationAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfNewYorkMellonCorporationAddress</seealso>
    let BankOfNewYorkMellonCorporationAddress =
        Prefixed_Name(fibo_exmp_le_finst, "BankOfNewYorkMellonCorporationAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BankOfNewYorkMellonCorporationBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Bank of New York Mellon Corporation business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfNewYorkMellonCorporationBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfNewYorkMellonCorporationBusinessEntityIdentifier</seealso>
    let BankOfNewYorkMellonCorporationBusinessEntityIdentifier =
        Prefixed_Name(fibo_exmp_le_finst, "BankOfNewYorkMellonCorporationBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BankOfNewYorkMellonCorporationIncorporationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Bank of New York Mellon Corporation incorporation date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfNewYorkMellonCorporationIncorporationDate">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfNewYorkMellonCorporationIncorporationDate</seealso>
    let BankOfNewYorkMellonCorporationIncorporationDate =
        Prefixed_Name(fibo_exmp_le_finst, "BankOfNewYorkMellonCorporationIncorporationDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BankOfNewYorkMellonCorporationLegalEntityIdentifierRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:LegalEntityIdentifierRegistryEntry</para>
    ///
    /// labels<para>"Bank of New York Mellon Corporation legal entity identifier registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfNewYorkMellonCorporationLegalEntityIdentifierRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfNewYorkMellonCorporationLegalEntityIdentifierRegistryEntry</seealso>
    let BankOfNewYorkMellonCorporationLegalEntityIdentifierRegistryEntry =
        Prefixed_Name(fibo_exmp_le_finst, "BankOfNewYorkMellonCorporationLegalEntityIdentifierRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BankOfNewYorkMellonCorporationRSSDIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usjrga:ResearchStatisticsSupervisionDiscountIdentifier</para>
    ///
    /// labels<para>"Bank of New York Mellon Corporation RSSD identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfNewYorkMellonCorporationRSSDIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfNewYorkMellonCorporationRSSDIdentifier</seealso>
    let BankOfNewYorkMellonCorporationRSSDIdentifier =
        Prefixed_Name(fibo_exmp_le_finst, "BankOfNewYorkMellonCorporationRSSDIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BankOfNewYorkMellonDateEstablished</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"The Bank of New York Mellon Corporation date established"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfNewYorkMellonDateEstablished">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BankOfNewYorkMellonDateEstablished</seealso>
    let BankOfNewYorkMellonDateEstablished =
        Prefixed_Name(fibo_exmp_le_finst, "BankOfNewYorkMellonDateEstablished") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BarclaysBank</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-der-drc-swp:SwapDealer</para>
    ///   <para>fibo-fbc-fct-fse:BrokerageFirm</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-der-drc-bsc:IntroducingBroker</para>
    ///   <para>fibo-fbc-fct-fse:CommodityTradingAdvisor</para>
    ///   <para>fibo-fbc-fct-fse:CommercialBank</para>
    ///
    /// labels<para>"Barclays Bank"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BarclaysBank">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BarclaysBank</seealso>
    let BarclaysBank = Prefixed_Name(fibo_exmp_le_finst, "BarclaysBank") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BarclaysBankPlc</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:Corporation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Barclays Bank Plc"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BarclaysBankPlc">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BarclaysBankPlc</seealso>
    let BarclaysBankPlc =
        Prefixed_Name(fibo_exmp_le_finst, "BarclaysBankPlc") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BarclaysBankPlcHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///
    /// labels<para>"Barclays Bank Plc headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BarclaysBankPlcHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BarclaysBankPlcHeadquartersAddress</seealso>
    let BarclaysBankPlcHeadquartersAddress =
        Prefixed_Name(fibo_exmp_le_finst, "BarclaysBankPlcHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BarclaysBankPlcLegalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///
    /// labels<para>"Barclays Bank Plc legal address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BarclaysBankPlcLegalAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BarclaysBankPlcLegalAddress</seealso>
    let BarclaysBankPlcLegalAddress =
        Prefixed_Name(fibo_exmp_le_finst, "BarclaysBankPlcLegalAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BarclaysBankPlcLegalEntityIdentifierRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:LegalEntityIdentifierRegistryEntry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Barclays Bank Plc legal entity identifier registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BarclaysBankPlcLegalEntityIdentifierRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BarclaysBankPlcLegalEntityIdentifierRegistryEntry</seealso>
    let BarclaysBankPlcLegalEntityIdentifierRegistryEntry =
        Prefixed_Name(fibo_exmp_le_finst, "BarclaysBankPlcLegalEntityIdentifierRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:CitiCardsSouthDakotaAcceptanceCorp</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-fse:FinanceCompany</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Citi Cards South Dakota Acceptance Corp."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitiCardsSouthDakotaAcceptanceCorp">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitiCardsSouthDakotaAcceptanceCorp</seealso>
    let CitiCardsSouthDakotaAcceptanceCorp =
        Prefixed_Name(fibo_exmp_le_finst, "CitiCardsSouthDakotaAcceptanceCorp") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:CitiCardsSouthDakotaAcceptanceCorp-US-DE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:StockCorporation</para>
    ///
    /// labels<para>"Citi Cards South Dakota Acceptance Corp. US-DE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitiCardsSouthDakotaAcceptanceCorp-US-DE">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitiCardsSouthDakotaAcceptanceCorp-US-DE</seealso>
    let CitiCardsSouthDakotaAcceptanceCorp_US_DE =
        Prefixed_Name(fibo_exmp_le_finst, "CitiCardsSouthDakotaAcceptanceCorp-US-DE") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:CitiCardsSouthDakotaAcceptanceCorpBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Citi Cards South Dakota Acceptance Corp. business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitiCardsSouthDakotaAcceptanceCorpBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitiCardsSouthDakotaAcceptanceCorpBusinessEntityIdentifier</seealso>
    let CitiCardsSouthDakotaAcceptanceCorpBusinessEntityIdentifier =
        Prefixed_Name(fibo_exmp_le_finst, "CitiCardsSouthDakotaAcceptanceCorpBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:CitiCardsSouthDakotaAcceptanceCorpHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:PhysicalAddress</para>
    ///
    /// labels<para>"Citi Cards South Dakota Acceptance Corp. headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitiCardsSouthDakotaAcceptanceCorpHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitiCardsSouthDakotaAcceptanceCorpHeadquartersAddress</seealso>
    let CitiCardsSouthDakotaAcceptanceCorpHeadquartersAddress =
        Prefixed_Name(fibo_exmp_le_finst, "CitiCardsSouthDakotaAcceptanceCorpHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:CitiCardsSouthDakotaAcceptanceCorpIncorporationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Citi Cards South Dakota Acceptance Corp. incorporation date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitiCardsSouthDakotaAcceptanceCorpIncorporationDate">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitiCardsSouthDakotaAcceptanceCorpIncorporationDate</seealso>
    let CitiCardsSouthDakotaAcceptanceCorpIncorporationDate =
        Prefixed_Name(fibo_exmp_le_finst, "CitiCardsSouthDakotaAcceptanceCorpIncorporationDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:CitiCardsSouthDakotaAcceptanceCorpOwnership</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-oac-opty:DirectConsolidation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Citi Cards South Dakota Acceptance Corp. ownership"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitiCardsSouthDakotaAcceptanceCorpOwnership">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitiCardsSouthDakotaAcceptanceCorpOwnership</seealso>
    let CitiCardsSouthDakotaAcceptanceCorpOwnership =
        Prefixed_Name(fibo_exmp_le_finst, "CitiCardsSouthDakotaAcceptanceCorpOwnership") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:CitiCardsSouthDakotaAcceptanceCorpRSSDIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:ResearchStatisticsSupervisionDiscountIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Citi Cards South Dakota Acceptance Corp. RSSD identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitiCardsSouthDakotaAcceptanceCorpRSSDIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitiCardsSouthDakotaAcceptanceCorpRSSDIdentifier</seealso>
    let CitiCardsSouthDakotaAcceptanceCorpRSSDIdentifier =
        Prefixed_Name(fibo_exmp_le_finst, "CitiCardsSouthDakotaAcceptanceCorpRSSDIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:CitibankNA</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usfse:NationalBank</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Citibank, N.A."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitibankNA">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitibankNA</seealso>
    let CitibankNA = Prefixed_Name(fibo_exmp_le_finst, "CitibankNA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:CitibankNA-US-DE</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:StockCorporation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Citibank, N.A. US-DE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitibankNA-US-DE">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitibankNA-US-DE</seealso>
    let CitibankNA_US_DE =
        Prefixed_Name(fibo_exmp_le_finst, "CitibankNA-US-DE") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:CitibankNABusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Citibank, N.A. business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitibankNABusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitibankNABusinessEntityIdentifier</seealso>
    let CitibankNABusinessEntityIdentifier =
        Prefixed_Name(fibo_exmp_le_finst, "CitibankNABusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:CitibankNADateEstablished</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Citibank, N.A. date established"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitibankNADateEstablished">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitibankNADateEstablished</seealso>
    let CitibankNADateEstablished =
        Prefixed_Name(fibo_exmp_le_finst, "CitibankNADateEstablished") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:CitibankNADateInsured</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Citibank, N.A. date insured"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitibankNADateInsured">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitibankNADateInsured</seealso>
    let CitibankNADateInsured =
        Prefixed_Name(fibo_exmp_le_finst, "CitibankNADateInsured") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:CitibankNAFDICCertificateNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:FDICCertificateNumber</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Citibank, N.A. FDIC Certificate number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitibankNAFDICCertificateNumber">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitibankNAFDICCertificateNumber</seealso>
    let CitibankNAFDICCertificateNumber =
        Prefixed_Name(fibo_exmp_le_finst, "CitibankNAFDICCertificateNumber") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:CitibankNAHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:PhysicalAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Citibank, N.A headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitibankNAHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitibankNAHeadquartersAddress</seealso>
    let CitibankNAHeadquartersAddress =
        Prefixed_Name(fibo_exmp_le_finst, "CitibankNAHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:CitibankNAIncorporationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Citibank, N.A. incorporation date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitibankNAIncorporationDate">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitibankNAIncorporationDate</seealso>
    let CitibankNAIncorporationDate =
        Prefixed_Name(fibo_exmp_le_finst, "CitibankNAIncorporationDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:CitibankNALegalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:PhysicalAddress</para>
    ///
    /// labels<para>"Citibank N.A. legal address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitibankNALegalAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitibankNALegalAddress</seealso>
    let CitibankNALegalAddress =
        Prefixed_Name(fibo_exmp_le_finst, "CitibankNALegalAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:CitibankNALegalEntityIdentifierRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:LegalEntityIdentifierRegistryEntry</para>
    ///
    /// labels<para>"Citibank, N.A. legal entity identifier registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitibankNALegalEntityIdentifierRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitibankNALegalEntityIdentifierRegistryEntry</seealso>
    let CitibankNALegalEntityIdentifierRegistryEntry =
        Prefixed_Name(fibo_exmp_le_finst, "CitibankNALegalEntityIdentifierRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:CitibankNAOwnership</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-oac-opty:DirectConsolidation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Citibank, N.A. ownership"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitibankNAOwnership">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitibankNAOwnership</seealso>
    let CitibankNAOwnership =
        Prefixed_Name(fibo_exmp_le_finst, "CitibankNAOwnership") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:CitibankNARSSDIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usjrga:ResearchStatisticsSupervisionDiscountIdentifier</para>
    ///
    /// labels<para>"Citibank, N.A. RSSD identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitibankNARSSDIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitibankNARSSDIdentifier</seealso>
    let CitibankNARSSDIdentifier =
        Prefixed_Name(fibo_exmp_le_finst, "CitibankNARSSDIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:CitibankNARTN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usjrga:RoutingTransitNumber</para>
    ///
    /// labels<para>"Citibank, N.A. RTN"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitibankNARTN">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitibankNARTN</seealso>
    let CitibankNARTN =
        Prefixed_Name(fibo_exmp_le_finst, "CitibankNARTN") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:CiticorpLLC</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usfse:FinancialHoldingCompany</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Citicorp LLC"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CiticorpLLC">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CiticorpLLC</seealso>
    let CiticorpLLC = Prefixed_Name(fibo_exmp_le_finst, "CiticorpLLC") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:CiticorpLLC-US-DE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-plc-plc:PrivateCompanyWithLimitedLiability</para>
    ///
    /// labels<para>"Citicorp LLC US-DE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CiticorpLLC-US-DE">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CiticorpLLC-US-DE</seealso>
    let CiticorpLLC_US_DE =
        Prefixed_Name(fibo_exmp_le_finst, "CiticorpLLC-US-DE") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:CiticorpLLCBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Citicorp LLC business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CiticorpLLCBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CiticorpLLCBusinessEntityIdentifier</seealso>
    let CiticorpLLCBusinessEntityIdentifier =
        Prefixed_Name(fibo_exmp_le_finst, "CiticorpLLCBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:CiticorpLLCLegalEntityIdentifierRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:LegalEntityIdentifierRegistryEntry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Citicorp LLC legal entity identifier registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CiticorpLLCLegalEntityIdentifierRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CiticorpLLCLegalEntityIdentifierRegistryEntry</seealso>
    let CiticorpLLCLegalEntityIdentifierRegistryEntry =
        Prefixed_Name(fibo_exmp_le_finst, "CiticorpLLCLegalEntityIdentifierRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:CiticorpLLCOwnership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-oac-opty:DirectConsolidation</para>
    ///
    /// labels<para>"Citicorp LLC ownership"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CiticorpLLCOwnership">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CiticorpLLCOwnership</seealso>
    let CiticorpLLCOwnership =
        Prefixed_Name(fibo_exmp_le_finst, "CiticorpLLCOwnership") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:CiticorpLLCRSSDIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:ResearchStatisticsSupervisionDiscountIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Citicorp LLC RSSD identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CiticorpLLCRSSDIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CiticorpLLCRSSDIdentifier</seealso>
    let CiticorpLLCRSSDIdentifier =
        Prefixed_Name(fibo_exmp_le_finst, "CiticorpLLCRSSDIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:CiticorpLLCRegistrationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Citicorp LLC registration date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CiticorpLLCRegistrationDate">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CiticorpLLCRegistrationDate</seealso>
    let CiticorpLLCRegistrationDate =
        Prefixed_Name(fibo_exmp_le_finst, "CiticorpLLCRegistrationDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:CitigroupInc</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usfse:FinancialHoldingCompany</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Citigroup Inc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitigroupInc">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitigroupInc</seealso>
    let CitigroupInc = Prefixed_Name(fibo_exmp_le_finst, "CitigroupInc") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:CitigroupInc-US-DE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:PubliclyHeldCompany</para>
    ///   <para>fibo-be-le-cb:ForProfitCorporation</para>
    ///
    /// labels<para>"Citigroup Inc. US-DE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitigroupInc-US-DE">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitigroupInc-US-DE</seealso>
    let CitigroupInc_US_DE =
        Prefixed_Name(fibo_exmp_le_finst, "CitigroupInc-US-DE") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:CitigroupIncBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///
    /// labels<para>"Citigroup Inc. business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitigroupIncBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitigroupIncBusinessEntityIdentifier</seealso>
    let CitigroupIncBusinessEntityIdentifier =
        Prefixed_Name(fibo_exmp_le_finst, "CitigroupIncBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:CitigroupIncHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:PhysicalAddress</para>
    ///
    /// labels<para>"Citigroup Inc. headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitigroupIncHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitigroupIncHeadquartersAddress</seealso>
    let CitigroupIncHeadquartersAddress =
        Prefixed_Name(fibo_exmp_le_finst, "CitigroupIncHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:CitigroupIncIncorporationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///
    /// labels<para>"Citigroup Inc. incorporation date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitigroupIncIncorporationDate">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitigroupIncIncorporationDate</seealso>
    let CitigroupIncIncorporationDate =
        Prefixed_Name(fibo_exmp_le_finst, "CitigroupIncIncorporationDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:CitigroupIncLegalEntityIdentifierRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:LegalEntityIdentifierRegistryEntry</para>
    ///
    /// labels<para>"Citigroup Inc. legal entity identifier registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitigroupIncLegalEntityIdentifierRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitigroupIncLegalEntityIdentifierRegistryEntry</seealso>
    let CitigroupIncLegalEntityIdentifierRegistryEntry =
        Prefixed_Name(fibo_exmp_le_finst, "CitigroupIncLegalEntityIdentifierRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:CitigroupIncRSSDIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usjrga:ResearchStatisticsSupervisionDiscountIdentifier</para>
    ///
    /// labels<para>"Citigroup Inc. RSSD identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitigroupIncRSSDIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CitigroupIncRSSDIdentifier</seealso>
    let CitigroupIncRSSDIdentifier =
        Prefixed_Name(fibo_exmp_le_finst, "CitigroupIncRSSDIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:Commerzbank</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-fse:BrokerageFirm</para>
    ///   <para>fibo-der-drc-swp:SwapDealer</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-fse:CommodityTradingAdvisor</para>
    ///   <para>fibo-fbc-fct-fse:CommercialBank</para>
    ///   <para>fibo-der-drc-bsc:IntroducingBroker</para>
    ///
    /// labels<para>"Commerzbank"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/Commerzbank">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/Commerzbank</seealso>
    let Commerzbank = Prefixed_Name(fibo_exmp_le_finst, "Commerzbank") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:CommerzbankAG</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:StockCorporation</para>
    ///
    /// labels<para>"Commerzbank AG"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CommerzbankAG">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CommerzbankAG</seealso>
    let CommerzbankAG =
        Prefixed_Name(fibo_exmp_le_finst, "CommerzbankAG") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:CommerzbankAGHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Commerzbank AG headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CommerzbankAGHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CommerzbankAGHeadquartersAddress</seealso>
    let CommerzbankAGHeadquartersAddress =
        Prefixed_Name(fibo_exmp_le_finst, "CommerzbankAGHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:CommerzbankAGLegalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///
    /// labels<para>"Commerzbank AG legal address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CommerzbankAGLegalAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CommerzbankAGLegalAddress</seealso>
    let CommerzbankAGLegalAddress =
        Prefixed_Name(fibo_exmp_le_finst, "CommerzbankAGLegalAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:CommerzbankAGLegalEntityIdentifierRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:LegalEntityIdentifierRegistryEntry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Commerzbank AG legal entity identifier registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CommerzbankAGLegalEntityIdentifierRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/CommerzbankAGLegalEntityIdentifierRegistryEntry</seealso>
    let CommerzbankAGLegalEntityIdentifierRegistryEntry =
        Prefixed_Name(fibo_exmp_le_finst, "CommerzbankAGLegalEntityIdentifierRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:DeutscheBankAktiengesellschaft-DE</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:Corporation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Deutsche Bank Aktiengesellschaft DE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/DeutscheBankAktiengesellschaft-DE">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/DeutscheBankAktiengesellschaft-DE</seealso>
    let DeutscheBankAktiengesellschaft_DE =
        Prefixed_Name(fibo_exmp_le_finst, "DeutscheBankAktiengesellschaft-DE") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:FMRLLC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-fse:ManagementCompany</para>
    ///
    /// labels<para>"FMR LLC"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/FMRLLC">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/FMRLLC</seealso>
    let FMRLLC = Prefixed_Name(fibo_exmp_le_finst, "FMRLLC") |> PrefixedName
    /// <summary>
    ///   <para>fibo-exmp-le-finst:FMRLLC-US-DE</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-plc-plc:PrivateCompanyWithLimitedLiability</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"FMR LLC US-DE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/FMRLLC-US-DE">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/FMRLLC-US-DE</seealso>
    let FMRLLC_US_DE = Prefixed_Name(fibo_exmp_le_finst, "FMRLLC-US-DE") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:FMRLLCBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///
    /// labels<para>"FMR LLC business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/FMRLLCBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/FMRLLCBusinessEntityIdentifier</seealso>
    let FMRLLCBusinessEntityIdentifier =
        Prefixed_Name(fibo_exmp_le_finst, "FMRLLCBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:FMRLLCDateEstablished</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"FMR LLC date established"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/FMRLLCDateEstablished">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/FMRLLCDateEstablished</seealso>
    let FMRLLCDateEstablished =
        Prefixed_Name(fibo_exmp_le_finst, "FMRLLCDateEstablished") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:FMRLLCHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:PhysicalAddress</para>
    ///
    /// labels<para>"FMR LLC headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/FMRLLCHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/FMRLLCHeadquartersAddress</seealso>
    let FMRLLCHeadquartersAddress =
        Prefixed_Name(fibo_exmp_le_finst, "FMRLLCHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:FMRLLCLegalEntityIdentifierRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:LegalEntityIdentifierRegistryEntry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"FMR LLC legal entity identifier registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/FMRLLCLegalEntityIdentifierRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/FMRLLCLegalEntityIdentifierRegistryEntry</seealso>
    let FMRLLCLegalEntityIdentifierRegistryEntry =
        Prefixed_Name(fibo_exmp_le_finst, "FMRLLCLegalEntityIdentifierRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:FMRLLCRSSDIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usjrga:ResearchStatisticsSupervisionDiscountIdentifier</para>
    ///
    /// labels<para>"FMR LLC RSSD identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/FMRLLCRSSDIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/FMRLLCRSSDIdentifier</seealso>
    let FMRLLCRSSDIdentifier =
        Prefixed_Name(fibo_exmp_le_finst, "FMRLLCRSSDIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:GoldmanSachsAndCoLLC-US-NY</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-plc-plc:LimitedLiabilityCompany</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Goldman Sachs &amp; Co. LLC"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/GoldmanSachsAndCoLLC-US-NY">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/GoldmanSachsAndCoLLC-US-NY</seealso>
    let GoldmanSachsAndCoLLC_US_NY =
        Prefixed_Name(fibo_exmp_le_finst, "GoldmanSachsAndCoLLC-US-NY") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:INGBank</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-der-drc-bsc:IntroducingBroker</para>
    ///   <para>fibo-fbc-fct-fse:CommodityTradingAdvisor</para>
    ///   <para>fibo-fbc-fct-fse:BrokerageFirm</para>
    ///   <para>fibo-fbc-fct-fse:CommercialBank</para>
    ///   <para>fibo-der-drc-swp:SwapDealer</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ING Bank"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/INGBank">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/INGBank</seealso>
    let INGBank = Prefixed_Name(fibo_exmp_le_finst, "INGBank") |> PrefixedName
    /// <summary>
    ///   <para>fibo-exmp-le-finst:INGBankNV</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:Corporation</para>
    ///
    /// labels<para>"ING Bank N.V."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/INGBankNV">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/INGBankNV</seealso>
    let INGBankNV = Prefixed_Name(fibo_exmp_le_finst, "INGBankNV") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:INGBankNVHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ING Bank N.V. headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/INGBankNVHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/INGBankNVHeadquartersAddress</seealso>
    let INGBankNVHeadquartersAddress =
        Prefixed_Name(fibo_exmp_le_finst, "INGBankNVHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:INGBankNVLegalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ING Bank N.V. legal address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/INGBankNVLegalAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/INGBankNVLegalAddress</seealso>
    let INGBankNVLegalAddress =
        Prefixed_Name(fibo_exmp_le_finst, "INGBankNVLegalAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:INGBankNVLegalEntityIdentifierRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:LegalEntityIdentifierRegistryEntry</para>
    ///
    /// labels<para>"ING Bank N.V. legal entity identifier registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/INGBankNVLegalEntityIdentifierRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/INGBankNVLegalEntityIdentifierRegistryEntry</seealso>
    let INGBankNVLegalEntityIdentifierRegistryEntry =
        Prefixed_Name(fibo_exmp_le_finst, "INGBankNVLegalEntityIdentifierRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:JPMorganChaseAndCo</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usfse:FinancialHoldingCompany</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"JPMorgan Chase &amp; Co."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseAndCo">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseAndCo</seealso>
    let JPMorganChaseAndCo =
        Prefixed_Name(fibo_exmp_le_finst, "JPMorganChaseAndCo") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:JPMorganChaseAndCo-US-DE</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:ForProfitCorporation</para>
    ///   <para>fibo-be-le-cb:PubliclyHeldCompany</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"JPMorgan Chase &amp; Co. US-DE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseAndCo-US-DE">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseAndCo-US-DE</seealso>
    let JPMorganChaseAndCo_US_DE =
        Prefixed_Name(fibo_exmp_le_finst, "JPMorganChaseAndCo-US-DE") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:JPMorganChaseAndCoBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"JPMorgan Chase &amp; Co. business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseAndCoBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseAndCoBusinessEntityIdentifier</seealso>
    let JPMorganChaseAndCoBusinessEntityIdentifier =
        Prefixed_Name(fibo_exmp_le_finst, "JPMorganChaseAndCoBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:JPMorganChaseAndCoBusinessIdentifierCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-fse:BusinessIdentifierCode</para>
    ///
    /// labels<para>"JPMorgan Chase &amp; Co. Business Identifier Code (BIC)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseAndCoBusinessIdentifierCode">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseAndCoBusinessIdentifierCode</seealso>
    let JPMorganChaseAndCoBusinessIdentifierCode =
        Prefixed_Name(fibo_exmp_le_finst, "JPMorganChaseAndCoBusinessIdentifierCode") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:JPMorganChaseAndCoBusinessPartyPrefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-fse:BusinessPartyPrefix</para>
    ///
    /// labels<para>"JPMorgan Chase &amp; Co. business party prefix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseAndCoBusinessPartyPrefix">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseAndCoBusinessPartyPrefix</seealso>
    let JPMorganChaseAndCoBusinessPartyPrefix =
        Prefixed_Name(fibo_exmp_le_finst, "JPMorganChaseAndCoBusinessPartyPrefix") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:JPMorganChaseAndCoBusinessPartySuffix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-fse:BusinessPartySuffix</para>
    ///
    /// labels<para>"JPMorgan Chase &amp; Co. business party suffix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseAndCoBusinessPartySuffix">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseAndCoBusinessPartySuffix</seealso>
    let JPMorganChaseAndCoBusinessPartySuffix =
        Prefixed_Name(fibo_exmp_le_finst, "JPMorganChaseAndCoBusinessPartySuffix") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:JPMorganChaseAndCoHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:PhysicalAddress</para>
    ///
    /// labels<para>"JPMorgan Chase &amp; Co. headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseAndCoHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseAndCoHeadquartersAddress</seealso>
    let JPMorganChaseAndCoHeadquartersAddress =
        Prefixed_Name(fibo_exmp_le_finst, "JPMorganChaseAndCoHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:JPMorganChaseAndCoIncorporationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"JPMorgan Chase &amp; Co. incorporation date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseAndCoIncorporationDate">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseAndCoIncorporationDate</seealso>
    let JPMorganChaseAndCoIncorporationDate =
        Prefixed_Name(fibo_exmp_le_finst, "JPMorganChaseAndCoIncorporationDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:JPMorganChaseAndCoLegalEntityIdentifierRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:LegalEntityIdentifierRegistryEntry</para>
    ///
    /// labels<para>"JPMorgan Chase &amp; Co. legal entity identifier registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseAndCoLegalEntityIdentifierRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseAndCoLegalEntityIdentifierRegistryEntry</seealso>
    let JPMorganChaseAndCoLegalEntityIdentifierRegistryEntry =
        Prefixed_Name(fibo_exmp_le_finst, "JPMorganChaseAndCoLegalEntityIdentifierRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:JPMorganChaseAndCoRSSDIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:ResearchStatisticsSupervisionDiscountIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"JPMorgan Chase &amp; Co. RSSD identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseAndCoRSSDIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseAndCoRSSDIdentifier</seealso>
    let JPMorganChaseAndCoRSSDIdentifier =
        Prefixed_Name(fibo_exmp_le_finst, "JPMorganChaseAndCoRSSDIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:JPMorganChaseBankNationalAssociation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usfse:NationalBank</para>
    ///   <para>fibo-fbc-fct-usjrga:FederalReserveSystemMember</para>
    ///
    /// labels<para>"JPMorgan Chase Bank, National Association"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseBankNationalAssociation">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseBankNationalAssociation</seealso>
    let JPMorganChaseBankNationalAssociation =
        Prefixed_Name(fibo_exmp_le_finst, "JPMorganChaseBankNationalAssociation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:JPMorganChaseBankNationalAssociation-US</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-lp:BusinessEntity</para>
    ///
    /// labels<para>"JPMorgan Chase Bank, National Association US"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseBankNationalAssociation-US">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseBankNationalAssociation-US</seealso>
    let JPMorganChaseBankNationalAssociation_US =
        Prefixed_Name(fibo_exmp_le_finst, "JPMorganChaseBankNationalAssociation-US") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:JPMorganChaseBankNationalAssociationAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:PhysicalAddress</para>
    ///
    /// labels<para>"JPMorgan Chase Bank, National Association address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseBankNationalAssociationAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseBankNationalAssociationAddress</seealso>
    let JPMorganChaseBankNationalAssociationAddress =
        Prefixed_Name(fibo_exmp_le_finst, "JPMorganChaseBankNationalAssociationAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:JPMorganChaseBankNationalAssociationBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///
    /// labels<para>"JPMorgan Chase Bank, National Association business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseBankNationalAssociationBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseBankNationalAssociationBusinessEntityIdentifier</seealso>
    let JPMorganChaseBankNationalAssociationBusinessEntityIdentifier =
        Prefixed_Name(fibo_exmp_le_finst, "JPMorganChaseBankNationalAssociationBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:JPMorganChaseBankNationalAssociationBusinessIdentifierCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-fse:BusinessIdentifierCode</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"JPMorgan Chase Bank, National Association - business identifier code (BIC)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseBankNationalAssociationBusinessIdentifierCode">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseBankNationalAssociationBusinessIdentifierCode</seealso>
    let JPMorganChaseBankNationalAssociationBusinessIdentifierCode =
        Prefixed_Name(fibo_exmp_le_finst, "JPMorganChaseBankNationalAssociationBusinessIdentifierCode") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:JPMorganChaseBankNationalAssociationBusinessPartyPrefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-fse:BusinessPartyPrefix</para>
    ///
    /// labels<para>"JPMorgan Chase Bank, National Association business party prefix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseBankNationalAssociationBusinessPartyPrefix">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseBankNationalAssociationBusinessPartyPrefix</seealso>
    let JPMorganChaseBankNationalAssociationBusinessPartyPrefix =
        Prefixed_Name(fibo_exmp_le_finst, "JPMorganChaseBankNationalAssociationBusinessPartyPrefix") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:JPMorganChaseBankNationalAssociationBusinessPartySuffix</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-fse:BusinessPartySuffix</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"JPMorgan Chase Bank, National Association business party suffix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseBankNationalAssociationBusinessPartySuffix">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseBankNationalAssociationBusinessPartySuffix</seealso>
    let JPMorganChaseBankNationalAssociationBusinessPartySuffix =
        Prefixed_Name(fibo_exmp_le_finst, "JPMorganChaseBankNationalAssociationBusinessPartySuffix") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:JPMorganChaseBankNationalAssociationDateEstablished</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///
    /// labels<para>"JPMorgan Chase Bank, National Association date established"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseBankNationalAssociationDateEstablished">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseBankNationalAssociationDateEstablished</seealso>
    let JPMorganChaseBankNationalAssociationDateEstablished =
        Prefixed_Name(fibo_exmp_le_finst, "JPMorganChaseBankNationalAssociationDateEstablished") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:JPMorganChaseBankNationalAssociationDateInsured</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///
    /// labels<para>"JPMorgan Chase Bank, National Association date insured"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseBankNationalAssociationDateInsured">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseBankNationalAssociationDateInsured</seealso>
    let JPMorganChaseBankNationalAssociationDateInsured =
        Prefixed_Name(fibo_exmp_le_finst, "JPMorganChaseBankNationalAssociationDateInsured") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:JPMorganChaseBankNationalAssociationFDICCertificateNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usjrga:FDICCertificateNumber</para>
    ///
    /// labels<para>"JPMorgan Chase Bank, National Association FDIC Certificate number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseBankNationalAssociationFDICCertificateNumber">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseBankNationalAssociationFDICCertificateNumber</seealso>
    let JPMorganChaseBankNationalAssociationFDICCertificateNumber =
        Prefixed_Name(fibo_exmp_le_finst, "JPMorganChaseBankNationalAssociationFDICCertificateNumber") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:JPMorganChaseBankNationalAssociationLegalEntityIdentifierRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:LegalEntityIdentifierRegistryEntry</para>
    ///
    /// labels<para>"JPMorgan Chase Bank, National Association legal entity identifier registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseBankNationalAssociationLegalEntityIdentifierRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseBankNationalAssociationLegalEntityIdentifierRegistryEntry</seealso>
    let JPMorganChaseBankNationalAssociationLegalEntityIdentifierRegistryEntry =
        Prefixed_Name(fibo_exmp_le_finst, "JPMorganChaseBankNationalAssociationLegalEntityIdentifierRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:JPMorganChaseBankNationalAssociationRSSDIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:ResearchStatisticsSupervisionDiscountIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"JPMorgan Chase Bank, National Association RSSD identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseBankNationalAssociationRSSDIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseBankNationalAssociationRSSDIdentifier</seealso>
    let JPMorganChaseBankNationalAssociationRSSDIdentifier =
        Prefixed_Name(fibo_exmp_le_finst, "JPMorganChaseBankNationalAssociationRSSDIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:JPMorganChaseBankNationalAssociationRTN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usjrga:RoutingTransitNumber</para>
    ///
    /// labels<para>"JPMorgan Chase Bank, National Association RTN"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseBankNationalAssociationRTN">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseBankNationalAssociationRTN</seealso>
    let JPMorganChaseBankNationalAssociationRTN =
        Prefixed_Name(fibo_exmp_le_finst, "JPMorganChaseBankNationalAssociationRTN") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:JPMorganChaseBankNationalAssociationRegistrationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"JPMorgan Chase Bank, National Association registration date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseBankNationalAssociationRegistrationDate">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganChaseBankNationalAssociationRegistrationDate</seealso>
    let JPMorganChaseBankNationalAssociationRegistrationDate =
        Prefixed_Name(fibo_exmp_le_finst, "JPMorganChaseBankNationalAssociationRegistrationDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:JPMorganSecurities</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-fse:InsuranceCompany</para>
    ///   <para>fibo-fbc-fct-fse:CommercialBank</para>
    ///   <para>fibo-der-drc-swp:SwapDealer</para>
    ///   <para>fibo-fbc-fct-fse:CommodityTradingAdvisor</para>
    ///   <para>fibo-der-drc-bsc:IntroducingBroker</para>
    ///   <para>fibo-fbc-fct-fse:BrokerageFirm</para>
    ///   <para>fibo-fbc-fct-fse:InvestmentBank</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"JP Morgan Securities"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganSecurities">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganSecurities</seealso>
    let JPMorganSecurities =
        Prefixed_Name(fibo_exmp_le_finst, "JPMorganSecurities") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:JPMorganSecuritiesPlc</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:Corporation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"JP Morgan Securities"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganSecuritiesPlc">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganSecuritiesPlc</seealso>
    let JPMorganSecuritiesPlc =
        Prefixed_Name(fibo_exmp_le_finst, "JPMorganSecuritiesPlc") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:JPMorganSecuritiesPlcHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"JP Morgan Securities Plc headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganSecuritiesPlcHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganSecuritiesPlcHeadquartersAddress</seealso>
    let JPMorganSecuritiesPlcHeadquartersAddress =
        Prefixed_Name(fibo_exmp_le_finst, "JPMorganSecuritiesPlcHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:JPMorganSecuritiesPlcLegalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///
    /// labels<para>"JP Morgan Securities Plc legal address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganSecuritiesPlcLegalAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganSecuritiesPlcLegalAddress</seealso>
    let JPMorganSecuritiesPlcLegalAddress =
        Prefixed_Name(fibo_exmp_le_finst, "JPMorganSecuritiesPlcLegalAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:JPMorganSecuritiesPlcLegalEntityIdentifierRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:LegalEntityIdentifierRegistryEntry</para>
    ///
    /// labels<para>"JP Morgan Securities legal entity identifier registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganSecuritiesPlcLegalEntityIdentifierRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/JPMorganSecuritiesPlcLegalEntityIdentifierRegistryEntry</seealso>
    let JPMorganSecuritiesPlcLegalEntityIdentifierRegistryEntry =
        Prefixed_Name(fibo_exmp_le_finst, "JPMorganSecuritiesPlcLegalEntityIdentifierRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:MorganStanleyAndCoInternational</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-der-drc-bsc:IntroducingBroker</para>
    ///   <para>fibo-fbc-fct-fse:InvestmentBank</para>
    ///   <para>fibo-der-drc-swp:SwapDealer</para>
    ///   <para>fibo-fbc-fct-fse:CommodityTradingAdvisor</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-fse:BrokerageFirm</para>
    ///
    /// labels<para>"Morgan Stanley &amp; Co. International"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/MorganStanleyAndCoInternational">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/MorganStanleyAndCoInternational</seealso>
    let MorganStanleyAndCoInternational =
        Prefixed_Name(fibo_exmp_le_finst, "MorganStanleyAndCoInternational") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:MorganStanleyAndCoInternationalPlc</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:Corporation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Morgan Stanley &amp; Co. International Plc"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/MorganStanleyAndCoInternationalPlc">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/MorganStanleyAndCoInternationalPlc</seealso>
    let MorganStanleyAndCoInternationalPlc =
        Prefixed_Name(fibo_exmp_le_finst, "MorganStanleyAndCoInternationalPlc") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:MorganStanleyAndCoInternationalPlcHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Morgan Stanley &amp; Co. International Plc headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/MorganStanleyAndCoInternationalPlcHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/MorganStanleyAndCoInternationalPlcHeadquartersAddress</seealso>
    let MorganStanleyAndCoInternationalPlcHeadquartersAddress =
        Prefixed_Name(fibo_exmp_le_finst, "MorganStanleyAndCoInternationalPlcHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:MorganStanleyAndCoInternationalPlcLegalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///
    /// labels<para>"Morgan Stanley &amp; Co. International Plc legal address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/MorganStanleyAndCoInternationalPlcLegalAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/MorganStanleyAndCoInternationalPlcLegalAddress</seealso>
    let MorganStanleyAndCoInternationalPlcLegalAddress =
        Prefixed_Name(fibo_exmp_le_finst, "MorganStanleyAndCoInternationalPlcLegalAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:MorganStanleyAndCoInternationalPlcLegalEntityIdentifierRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:LegalEntityIdentifierRegistryEntry</para>
    ///
    /// labels<para>"Morgan Stanley &amp; Co. International Plc legal entity identifier registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/MorganStanleyAndCoInternationalPlcLegalEntityIdentifierRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/MorganStanleyAndCoInternationalPlcLegalEntityIdentifierRegistryEntry</seealso>
    let MorganStanleyAndCoInternationalPlcLegalEntityIdentifierRegistryEntry =
        Prefixed_Name(fibo_exmp_le_finst, "MorganStanleyAndCoInternationalPlcLegalEntityIdentifierRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:MorganStanleyAndCoLLC</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-der-drc-swp:SwapDealer</para>
    ///   <para>fibo-fbc-fct-fse:BrokerageFirm</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-fse:InvestmentBank</para>
    ///   <para>fibo-der-drc-bsc:IntroducingBroker</para>
    ///   <para>fibo-fbc-fct-fse:CommodityTradingAdvisor</para>
    ///
    /// labels<para>"Morgan Stanley &amp; Co. LLC"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/MorganStanleyAndCoLLC">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/MorganStanleyAndCoLLC</seealso>
    let MorganStanleyAndCoLLC =
        Prefixed_Name(fibo_exmp_le_finst, "MorganStanleyAndCoLLC") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:MorganStanleyAndCoLLC-US-DE</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-plc-plc:LimitedLiabilityCompany</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Morgan Stanley &amp; Co. LLC US-DE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/MorganStanleyAndCoLLC-US-DE">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/MorganStanleyAndCoLLC-US-DE</seealso>
    let MorganStanleyAndCoLLC_US_DE =
        Prefixed_Name(fibo_exmp_le_finst, "MorganStanleyAndCoLLC-US-DE") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:MorganStanleyAndCoLLCHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Morgan Stanley &amp; Co. LLC headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/MorganStanleyAndCoLLCHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/MorganStanleyAndCoLLCHeadquartersAddress</seealso>
    let MorganStanleyAndCoLLCHeadquartersAddress =
        Prefixed_Name(fibo_exmp_le_finst, "MorganStanleyAndCoLLCHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:MorganStanleyAndCoLLCLegalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Morgan Stanley &amp; Co. LLC legal address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/MorganStanleyAndCoLLCLegalAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/MorganStanleyAndCoLLCLegalAddress</seealso>
    let MorganStanleyAndCoLLCLegalAddress =
        Prefixed_Name(fibo_exmp_le_finst, "MorganStanleyAndCoLLCLegalAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:MorganStanleyAndCoLLCLegalEntityIdentifierRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:LegalEntityIdentifierRegistryEntry</para>
    ///
    /// labels<para>"Morgan Stanley &amp; Co. LLC legal entity identifier registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/MorganStanleyAndCoLLCLegalEntityIdentifierRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/MorganStanleyAndCoLLCLegalEntityIdentifierRegistryEntry</seealso>
    let MorganStanleyAndCoLLCLegalEntityIdentifierRegistryEntry =
        Prefixed_Name(fibo_exmp_le_finst, "MorganStanleyAndCoLLCLegalEntityIdentifierRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:NasdaqOMXGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:Corporation</para>
    ///
    /// labels<para>"Nasdaq OMX Group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/NasdaqOMXGroup">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/NasdaqOMXGroup</seealso>
    let NasdaqOMXGroup =
        Prefixed_Name(fibo_exmp_le_finst, "NasdaqOMXGroup") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:NatWestMarkets</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-fse:InvestmentBank</para>
    ///   <para>fibo-der-drc-swp:SwapDealer</para>
    ///   <para>fibo-fbc-fct-fse:BrokerageFirm</para>
    ///   <para>fibo-fbc-fct-fse:CommodityTradingAdvisor</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-der-drc-bsc:IntroducingBroker</para>
    ///
    /// labels<para>"NatWest Markets"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/NatWestMarkets">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/NatWestMarkets</seealso>
    let NatWestMarkets =
        Prefixed_Name(fibo_exmp_le_finst, "NatWestMarkets") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:NatWestMarketsPlc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:Corporation</para>
    ///
    /// labels<para>"NatWest Markets Plc"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/NatWestMarketsPlc">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/NatWestMarketsPlc</seealso>
    let NatWestMarketsPlc =
        Prefixed_Name(fibo_exmp_le_finst, "NatWestMarketsPlc") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:NatWestMarketsPlcHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///
    /// labels<para>"NatWest Markets Plc headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/NatWestMarketsPlcHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/NatWestMarketsPlcHeadquartersAddress</seealso>
    let NatWestMarketsPlcHeadquartersAddress =
        Prefixed_Name(fibo_exmp_le_finst, "NatWestMarketsPlcHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:NatWestMarketsPlcLegalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"NatWest Markets Plc legal address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/NatWestMarketsPlcLegalAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/NatWestMarketsPlcLegalAddress</seealso>
    let NatWestMarketsPlcLegalAddress =
        Prefixed_Name(fibo_exmp_le_finst, "NatWestMarketsPlcLegalAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:NatWestMarketsPlcLegalEntityIdentifierRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:LegalEntityIdentifierRegistryEntry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"NatWest Markets Plc legal entity identifier registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/NatWestMarketsPlcLegalEntityIdentifierRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/NatWestMarketsPlcLegalEntityIdentifierRegistryEntry</seealso>
    let NatWestMarketsPlcLegalEntityIdentifierRegistryEntry =
        Prefixed_Name(fibo_exmp_le_finst, "NatWestMarketsPlcLegalEntityIdentifierRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:PinnacleBank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usfse:StateCharteredBank</para>
    ///
    /// labels<para>"Pinnacle Bank"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/PinnacleBank">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/PinnacleBank</seealso>
    let PinnacleBank = Prefixed_Name(fibo_exmp_le_finst, "PinnacleBank") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:PinnacleBank-US-CA</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:StockCorporation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Pinnacle Bank US-CA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/PinnacleBank-US-CA">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/PinnacleBank-US-CA</seealso>
    let PinnacleBank_US_CA =
        Prefixed_Name(fibo_exmp_le_finst, "PinnacleBank-US-CA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:PinnacleBankBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegistrationAuthorities:RegisteredIdentifier</para>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Pinnacle Bank business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/PinnacleBankBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/PinnacleBankBusinessEntityIdentifier</seealso>
    let PinnacleBankBusinessEntityIdentifier =
        Prefixed_Name(fibo_exmp_le_finst, "PinnacleBankBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:PinnacleBankCaliforniaCertificateOfAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-rga:GovernmentIssuedLicense</para>
    ///
    /// labels<para>"Pinnacle Bank California Certificate of Authority"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/PinnacleBankCaliforniaCertificateOfAuthority">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/PinnacleBankCaliforniaCertificateOfAuthority</seealso>
    let PinnacleBankCaliforniaCertificateOfAuthority =
        Prefixed_Name(fibo_exmp_le_finst, "PinnacleBankCaliforniaCertificateOfAuthority") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:PinnacleBankCaliforniaCertificateOfAuthorityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-law-lcap:LicenseIdentifier</para>
    ///
    /// labels<para>"Pinnacle Bank California Certificate of Authority identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/PinnacleBankCaliforniaCertificateOfAuthorityIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/PinnacleBankCaliforniaCertificateOfAuthorityIdentifier</seealso>
    let PinnacleBankCaliforniaCertificateOfAuthorityIdentifier =
        Prefixed_Name(fibo_exmp_le_finst, "PinnacleBankCaliforniaCertificateOfAuthorityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:PinnacleBankDateOfRegistration</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Pinnacle Bank date of registration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/PinnacleBankDateOfRegistration">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/PinnacleBankDateOfRegistration</seealso>
    let PinnacleBankDateOfRegistration =
        Prefixed_Name(fibo_exmp_le_finst, "PinnacleBankDateOfRegistration") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:PinnacleBankFDICCertificateNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usjrga:FDICCertificateNumber</para>
    ///
    /// labels<para>"Pinnacle Bank FDIC Certificate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/PinnacleBankFDICCertificateNumber">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/PinnacleBankFDICCertificateNumber</seealso>
    let PinnacleBankFDICCertificateNumber =
        Prefixed_Name(fibo_exmp_le_finst, "PinnacleBankFDICCertificateNumber") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:PinnacleBankHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:PhysicalAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Pinnacle Bank headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/PinnacleBankHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/PinnacleBankHeadquartersAddress</seealso>
    let PinnacleBankHeadquartersAddress =
        Prefixed_Name(fibo_exmp_le_finst, "PinnacleBankHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:PinnacleBankLegalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:PhysicalAddress</para>
    ///
    /// labels<para>"Pinnacle Bank legal address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/PinnacleBankLegalAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/PinnacleBankLegalAddress</seealso>
    let PinnacleBankLegalAddress =
        Prefixed_Name(fibo_exmp_le_finst, "PinnacleBankLegalAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:PinnacleBankRSSDIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:ResearchStatisticsSupervisionDiscountIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Pinnacle Bank RSSD identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/PinnacleBankRSSDIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/PinnacleBankRSSDIdentifier</seealso>
    let PinnacleBankRSSDIdentifier =
        Prefixed_Name(fibo_exmp_le_finst, "PinnacleBankRSSDIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:PinnacleBankRTN</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:RoutingTransitNumber</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Pinnacle Bank RTN"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/PinnacleBankRTN">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/PinnacleBankRTN</seealso>
    let PinnacleBankRTN =
        Prefixed_Name(fibo_exmp_le_finst, "PinnacleBankRTN") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:SocieteGenerale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-der-drc-bsc:IntroducingBroker</para>
    ///   <para>fibo-fbc-fct-fse:CommodityTradingAdvisor</para>
    ///   <para>fibo-fbc-fct-fse:CommercialBank</para>
    ///   <para>fibo-fbc-fct-fse:BrokerageFirm</para>
    ///   <para>fibo-fbc-fct-fse:InsuranceCompany</para>
    ///   <para>fibo-der-drc-swp:SwapDealer</para>
    ///   <para>fibo-fbc-fct-fse:InvestmentBank</para>
    ///
    /// labels<para>"Société Générale"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/SocieteGenerale">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/SocieteGenerale</seealso>
    let SocieteGenerale =
        Prefixed_Name(fibo_exmp_le_finst, "SocieteGenerale") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:SocieteGeneraleEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:Corporation</para>
    ///
    /// labels<para>"Société Générale entité"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/SocieteGeneraleEntity">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/SocieteGeneraleEntity</seealso>
    let SocieteGeneraleEntity =
        Prefixed_Name(fibo_exmp_le_finst, "SocieteGeneraleEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:SocieteGeneraleHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Société Générale headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/SocieteGeneraleHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/SocieteGeneraleHeadquartersAddress</seealso>
    let SocieteGeneraleHeadquartersAddress =
        Prefixed_Name(fibo_exmp_le_finst, "SocieteGeneraleHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:SocieteGeneraleLegalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Société Générale legal address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/SocieteGeneraleLegalAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/SocieteGeneraleLegalAddress</seealso>
    let SocieteGeneraleLegalAddress =
        Prefixed_Name(fibo_exmp_le_finst, "SocieteGeneraleLegalAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:SocieteGeneraleLegalEntityIdentifierRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:LegalEntityIdentifierRegistryEntry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Société Générale legal entity identifier registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/SocieteGeneraleLegalEntityIdentifierRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/SocieteGeneraleLegalEntityIdentifierRegistryEntry</seealso>
    let SocieteGeneraleLegalEntityIdentifierRegistryEntry =
        Prefixed_Name(fibo_exmp_le_finst, "SocieteGeneraleLegalEntityIdentifierRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:StandardCharteredBank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-fse:CommodityTradingAdvisor</para>
    ///   <para>fibo-fbc-fct-fse:BrokerageFirm</para>
    ///   <para>fibo-fbc-fct-fse:CommercialBank</para>
    ///   <para>fibo-der-drc-swp:SwapDealer</para>
    ///   <para>fibo-fbc-fct-fse:InsuranceCompany</para>
    ///   <para>fibo-fbc-fct-fse:InvestmentBank</para>
    ///   <para>fibo-der-drc-bsc:IntroducingBroker</para>
    ///
    /// labels<para>"Standard Chartered Bank"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StandardCharteredBank">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StandardCharteredBank</seealso>
    let StandardCharteredBank =
        Prefixed_Name(fibo_exmp_le_finst, "StandardCharteredBank") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:StandardCharteredBankEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:Corporation</para>
    ///
    /// labels<para>"Standard Chartered Bank entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StandardCharteredBankEntity">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StandardCharteredBankEntity</seealso>
    let StandardCharteredBankEntity =
        Prefixed_Name(fibo_exmp_le_finst, "StandardCharteredBankEntity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:StandardCharteredBankHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Standard Chartered Bank headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StandardCharteredBankHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StandardCharteredBankHeadquartersAddress</seealso>
    let StandardCharteredBankHeadquartersAddress =
        Prefixed_Name(fibo_exmp_le_finst, "StandardCharteredBankHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:StandardCharteredBankLegalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Standard Chartered Bank legal address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StandardCharteredBankLegalAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StandardCharteredBankLegalAddress</seealso>
    let StandardCharteredBankLegalAddress =
        Prefixed_Name(fibo_exmp_le_finst, "StandardCharteredBankLegalAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:StandardCharteredBankLegalEntityIdentifierRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:LegalEntityIdentifierRegistryEntry</para>
    ///
    /// labels<para>"Standard Chartered Bank legal entity identifier registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StandardCharteredBankLegalEntityIdentifierRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StandardCharteredBankLegalEntityIdentifierRegistryEntry</seealso>
    let StandardCharteredBankLegalEntityIdentifierRegistryEntry =
        Prefixed_Name(fibo_exmp_le_finst, "StandardCharteredBankLegalEntityIdentifierRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:StandardCharteredSecuritiesNorthAmericaLLC-US-DE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-plc-plc:LimitedLiabilityCompany</para>
    ///
    /// labels<para>"Standard Chartered Securities (North America) LLC"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StandardCharteredSecuritiesNorthAmericaLLC-US-DE">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StandardCharteredSecuritiesNorthAmericaLLC-US-DE</seealso>
    let StandardCharteredSecuritiesNorthAmericaLLC_US_DE =
        Prefixed_Name(fibo_exmp_le_finst, "StandardCharteredSecuritiesNorthAmericaLLC-US-DE") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:StateStreetBankAndTrustCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:StateMemberBank</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State Street Bank and Trust"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetBankAndTrustCompany">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetBankAndTrustCompany</seealso>
    let StateStreetBankAndTrustCompany =
        Prefixed_Name(fibo_exmp_le_finst, "StateStreetBankAndTrustCompany") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:StateStreetBankAndTrustCompany-US-MA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-tr-tr:Trust</para>
    ///
    /// labels<para>"State Street Bank and Trust Company US-MA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetBankAndTrustCompany-US-MA">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetBankAndTrustCompany-US-MA</seealso>
    let StateStreetBankAndTrustCompany_US_MA =
        Prefixed_Name(fibo_exmp_le_finst, "StateStreetBankAndTrustCompany-US-MA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:StateStreetBankAndTrustCompanyBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State Street Bank and Trust Company business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetBankAndTrustCompanyBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetBankAndTrustCompanyBusinessEntityIdentifier</seealso>
    let StateStreetBankAndTrustCompanyBusinessEntityIdentifier =
        Prefixed_Name(fibo_exmp_le_finst, "StateStreetBankAndTrustCompanyBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:StateStreetBankAndTrustCompanyBusinessIdentifierCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-fse:BusinessIdentifierCode</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State Street Bank and Trust Company - business identifier code (BIC)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetBankAndTrustCompanyBusinessIdentifierCode">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetBankAndTrustCompanyBusinessIdentifierCode</seealso>
    let StateStreetBankAndTrustCompanyBusinessIdentifierCode =
        Prefixed_Name(fibo_exmp_le_finst, "StateStreetBankAndTrustCompanyBusinessIdentifierCode") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:StateStreetBankAndTrustCompanyBusinessPartyPrefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-fse:BusinessPartyPrefix</para>
    ///
    /// labels<para>"State Street Bank and Trust Company business party prefix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetBankAndTrustCompanyBusinessPartyPrefix">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetBankAndTrustCompanyBusinessPartyPrefix</seealso>
    let StateStreetBankAndTrustCompanyBusinessPartyPrefix =
        Prefixed_Name(fibo_exmp_le_finst, "StateStreetBankAndTrustCompanyBusinessPartyPrefix") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:StateStreetBankAndTrustCompanyBusinessPartySuffix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-fse:BusinessPartySuffix</para>
    ///
    /// labels<para>"State Street Bank and Trust Company business party suffix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetBankAndTrustCompanyBusinessPartySuffix">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetBankAndTrustCompanyBusinessPartySuffix</seealso>
    let StateStreetBankAndTrustCompanyBusinessPartySuffix =
        Prefixed_Name(fibo_exmp_le_finst, "StateStreetBankAndTrustCompanyBusinessPartySuffix") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:StateStreetBankAndTrustCompanyDateEstablished</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///
    /// labels<para>"State Street Bank and Trust Company date established"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetBankAndTrustCompanyDateEstablished">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetBankAndTrustCompanyDateEstablished</seealso>
    let StateStreetBankAndTrustCompanyDateEstablished =
        Prefixed_Name(fibo_exmp_le_finst, "StateStreetBankAndTrustCompanyDateEstablished") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:StateStreetBankAndTrustCompanyDateInsured</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State Street Bank and Trust Company date insured"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetBankAndTrustCompanyDateInsured">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetBankAndTrustCompanyDateInsured</seealso>
    let StateStreetBankAndTrustCompanyDateInsured =
        Prefixed_Name(fibo_exmp_le_finst, "StateStreetBankAndTrustCompanyDateInsured") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:StateStreetBankAndTrustCompanyFDICCertificateNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:FDICCertificateNumber</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State Street Bank and Trust Company FDIC Certificate number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetBankAndTrustCompanyFDICCertificateNumber">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetBankAndTrustCompanyFDICCertificateNumber</seealso>
    let StateStreetBankAndTrustCompanyFDICCertificateNumber =
        Prefixed_Name(fibo_exmp_le_finst, "StateStreetBankAndTrustCompanyFDICCertificateNumber") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:StateStreetBankAndTrustCompanyLegalEntityIdentifierRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:LegalEntityIdentifierRegistryEntry</para>
    ///
    /// labels<para>"State Street Bank and Trust Company legal entity identifier registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetBankAndTrustCompanyLegalEntityIdentifierRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetBankAndTrustCompanyLegalEntityIdentifierRegistryEntry</seealso>
    let StateStreetBankAndTrustCompanyLegalEntityIdentifierRegistryEntry =
        Prefixed_Name(fibo_exmp_le_finst, "StateStreetBankAndTrustCompanyLegalEntityIdentifierRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:StateStreetBankAndTrustCompanyRSSDIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:ResearchStatisticsSupervisionDiscountIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State Street Bank and Trust Company RSSD identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetBankAndTrustCompanyRSSDIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetBankAndTrustCompanyRSSDIdentifier</seealso>
    let StateStreetBankAndTrustCompanyRSSDIdentifier =
        Prefixed_Name(fibo_exmp_le_finst, "StateStreetBankAndTrustCompanyRSSDIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:StateStreetBankAndTrustCompanyRTN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usjrga:RoutingTransitNumber</para>
    ///
    /// labels<para>"State Street Bank and Trust Company RTN"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetBankAndTrustCompanyRTN">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetBankAndTrustCompanyRTN</seealso>
    let StateStreetBankAndTrustCompanyRTN =
        Prefixed_Name(fibo_exmp_le_finst, "StateStreetBankAndTrustCompanyRTN") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:StateStreetBankAndTrustCompanyRegistrationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State Street Bank and Trust Company registration date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetBankAndTrustCompanyRegistrationDate">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetBankAndTrustCompanyRegistrationDate</seealso>
    let StateStreetBankAndTrustCompanyRegistrationDate =
        Prefixed_Name(fibo_exmp_le_finst, "StateStreetBankAndTrustCompanyRegistrationDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:StateStreetCorporation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usfse:FinancialHoldingCompany</para>
    ///
    /// labels<para>"State Street Corporation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetCorporation">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetCorporation</seealso>
    let StateStreetCorporation =
        Prefixed_Name(fibo_exmp_le_finst, "StateStreetCorporation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:StateStreetCorporation-US-MA</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:ForProfitCorporation</para>
    ///   <para>fibo-be-le-cb:PubliclyHeldCompany</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State Street Corporation US-MA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetCorporation-US-MA">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetCorporation-US-MA</seealso>
    let StateStreetCorporation_US_MA =
        Prefixed_Name(fibo_exmp_le_finst, "StateStreetCorporation-US-MA") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:StateStreetCorporationBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///
    /// labels<para>"State Street Corporation business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetCorporationBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetCorporationBusinessEntityIdentifier</seealso>
    let StateStreetCorporationBusinessEntityIdentifier =
        Prefixed_Name(fibo_exmp_le_finst, "StateStreetCorporationBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:StateStreetCorporationHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:PhysicalAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State Street Corporation headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetCorporationHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetCorporationHeadquartersAddress</seealso>
    let StateStreetCorporationHeadquartersAddress =
        Prefixed_Name(fibo_exmp_le_finst, "StateStreetCorporationHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:StateStreetCorporationIncorporationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State Street Corporation incorporation date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetCorporationIncorporationDate">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetCorporationIncorporationDate</seealso>
    let StateStreetCorporationIncorporationDate =
        Prefixed_Name(fibo_exmp_le_finst, "StateStreetCorporationIncorporationDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:StateStreetCorporationLegalEntityIdentifierRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:LegalEntityIdentifierRegistryEntry</para>
    ///
    /// labels<para>"State Street Corporation legal entity identifier registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetCorporationLegalEntityIdentifierRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetCorporationLegalEntityIdentifierRegistryEntry</seealso>
    let StateStreetCorporationLegalEntityIdentifierRegistryEntry =
        Prefixed_Name(fibo_exmp_le_finst, "StateStreetCorporationLegalEntityIdentifierRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:StateStreetCorporationRSSDIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:ResearchStatisticsSupervisionDiscountIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"State Street Corporation RSSD identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetCorporationRSSDIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/StateStreetCorporationRSSDIdentifier</seealso>
    let StateStreetCorporationRSSDIdentifier =
        Prefixed_Name(fibo_exmp_le_finst, "StateStreetCorporationRSSDIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:WFCHoldingsLLC</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usfse:FinancialHoldingCompany</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"WFC Holdings, LLC"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WFCHoldingsLLC">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WFCHoldingsLLC</seealso>
    let WFCHoldingsLLC =
        Prefixed_Name(fibo_exmp_le_finst, "WFCHoldingsLLC") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:WFCHoldingsLLC-US-DE</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-plc-plc:PrivateCompanyWithLimitedLiability</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"WFC Holdings, LLC US-DE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WFCHoldingsLLC-US-DE">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WFCHoldingsLLC-US-DE</seealso>
    let WFCHoldingsLLC_US_DE =
        Prefixed_Name(fibo_exmp_le_finst, "WFCHoldingsLLC-US-DE") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:WFCHoldingsLLCBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"WFC Holdings, LLC business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WFCHoldingsLLCBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WFCHoldingsLLCBusinessEntityIdentifier</seealso>
    let WFCHoldingsLLCBusinessEntityIdentifier =
        Prefixed_Name(fibo_exmp_le_finst, "WFCHoldingsLLCBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:WFCHoldingsLLCHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:PhysicalAddress</para>
    ///
    /// labels<para>"WFC Holdings, LLC headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WFCHoldingsLLCHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WFCHoldingsLLCHeadquartersAddress</seealso>
    let WFCHoldingsLLCHeadquartersAddress =
        Prefixed_Name(fibo_exmp_le_finst, "WFCHoldingsLLCHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:WFCHoldingsLLCIncorporationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"WFC Holdings, LLC incorporation date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WFCHoldingsLLCIncorporationDate">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WFCHoldingsLLCIncorporationDate</seealso>
    let WFCHoldingsLLCIncorporationDate =
        Prefixed_Name(fibo_exmp_le_finst, "WFCHoldingsLLCIncorporationDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:WFCHoldingsLLCLegalEntityIdentifierRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:LegalEntityIdentifierRegistryEntry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"WFC Holdings, LLC legal entity identifier registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WFCHoldingsLLCLegalEntityIdentifierRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WFCHoldingsLLCLegalEntityIdentifierRegistryEntry</seealso>
    let WFCHoldingsLLCLegalEntityIdentifierRegistryEntry =
        Prefixed_Name(fibo_exmp_le_finst, "WFCHoldingsLLCLegalEntityIdentifierRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:WFCHoldingsLLCOwnership</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-oac-opty:DirectConsolidation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"WFC Holdings, LLC ownership"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WFCHoldingsLLCOwnership">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WFCHoldingsLLCOwnership</seealso>
    let WFCHoldingsLLCOwnership =
        Prefixed_Name(fibo_exmp_le_finst, "WFCHoldingsLLCOwnership") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:WellsFargoAndCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usfse:FinancialHoldingCompany</para>
    ///
    /// labels<para>"Wells Fargo &amp; Company"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoAndCompany">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoAndCompany</seealso>
    let WellsFargoAndCompany =
        Prefixed_Name(fibo_exmp_le_finst, "WellsFargoAndCompany") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:WellsFargoAndCompany-US-DE</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:PubliclyHeldCompany</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:ForProfitCorporation</para>
    ///
    /// labels<para>"Wells Fargo &amp; Company US-DE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoAndCompany-US-DE">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoAndCompany-US-DE</seealso>
    let WellsFargoAndCompany_US_DE =
        Prefixed_Name(fibo_exmp_le_finst, "WellsFargoAndCompany-US-DE") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:WellsFargoAndCompanyBusinessEntityIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:RegistrationIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Wells Fargo &amp; Company business entity identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoAndCompanyBusinessEntityIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoAndCompanyBusinessEntityIdentifier</seealso>
    let WellsFargoAndCompanyBusinessEntityIdentifier =
        Prefixed_Name(fibo_exmp_le_finst, "WellsFargoAndCompanyBusinessEntityIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:WellsFargoAndCompanyHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:PhysicalAddress</para>
    ///
    /// labels<para>"Wells Fargo &amp; Company headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoAndCompanyHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoAndCompanyHeadquartersAddress</seealso>
    let WellsFargoAndCompanyHeadquartersAddress =
        Prefixed_Name(fibo_exmp_le_finst, "WellsFargoAndCompanyHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:WellsFargoAndCompanyIncorporationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///
    /// labels<para>"Wells Fargo &amp; Company incorporation date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoAndCompanyIncorporationDate">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoAndCompanyIncorporationDate</seealso>
    let WellsFargoAndCompanyIncorporationDate =
        Prefixed_Name(fibo_exmp_le_finst, "WellsFargoAndCompanyIncorporationDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:WellsFargoAndCompanyLegalEntityIdentifierRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:LegalEntityIdentifierRegistryEntry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Wells Fargo &amp; Company legal entity identifier registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoAndCompanyLegalEntityIdentifierRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoAndCompanyLegalEntityIdentifierRegistryEntry</seealso>
    let WellsFargoAndCompanyLegalEntityIdentifierRegistryEntry =
        Prefixed_Name(fibo_exmp_le_finst, "WellsFargoAndCompanyLegalEntityIdentifierRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:WellsFargoAndCompanyRSSDIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:ResearchStatisticsSupervisionDiscountIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Wells Fargo &amp; Company RSSD identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoAndCompanyRSSDIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoAndCompanyRSSDIdentifier</seealso>
    let WellsFargoAndCompanyRSSDIdentifier =
        Prefixed_Name(fibo_exmp_le_finst, "WellsFargoAndCompanyRSSDIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:WellsFargoBankNationalAssociation</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usfse:NationalBank</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Wells Fargo Bank, National Association"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoBankNationalAssociation">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoBankNationalAssociation</seealso>
    let WellsFargoBankNationalAssociation =
        Prefixed_Name(fibo_exmp_le_finst, "WellsFargoBankNationalAssociation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:WellsFargoBankNationalAssociation-US</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-lp:BusinessEntity</para>
    ///
    /// labels<para>"Wells Fargo Bank, National Association, US"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoBankNationalAssociation-US">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoBankNationalAssociation-US</seealso>
    let WellsFargoBankNationalAssociation_US =
        Prefixed_Name(fibo_exmp_le_finst, "WellsFargoBankNationalAssociation-US") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:WellsFargoBankNationalAssociationBusinessIdentifierCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-fse:BusinessIdentifierCode</para>
    ///
    /// labels<para>"Wells Fargo Bank, National Association - business identifier code (BIC)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoBankNationalAssociationBusinessIdentifierCode">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoBankNationalAssociationBusinessIdentifierCode</seealso>
    let WellsFargoBankNationalAssociationBusinessIdentifierCode =
        Prefixed_Name(fibo_exmp_le_finst, "WellsFargoBankNationalAssociationBusinessIdentifierCode") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:WellsFargoBankNationalAssociationBusinessPartyPrefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-fse:BusinessPartyPrefix</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Wells Fargo Bank, National Association business party prefix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoBankNationalAssociationBusinessPartyPrefix">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoBankNationalAssociationBusinessPartyPrefix</seealso>
    let WellsFargoBankNationalAssociationBusinessPartyPrefix =
        Prefixed_Name(fibo_exmp_le_finst, "WellsFargoBankNationalAssociationBusinessPartyPrefix") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:WellsFargoBankNationalAssociationBusinessPartySuffix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-fse:BusinessPartySuffix</para>
    ///
    /// labels<para>"Wells Fargo Bank, National Association business party suffix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoBankNationalAssociationBusinessPartySuffix">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoBankNationalAssociationBusinessPartySuffix</seealso>
    let WellsFargoBankNationalAssociationBusinessPartySuffix =
        Prefixed_Name(fibo_exmp_le_finst, "WellsFargoBankNationalAssociationBusinessPartySuffix") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:WellsFargoBankNationalAssociationDateEstablished</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///
    /// labels<para>"Wells Fargo Bank, National Association date established"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoBankNationalAssociationDateEstablished">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoBankNationalAssociationDateEstablished</seealso>
    let WellsFargoBankNationalAssociationDateEstablished =
        Prefixed_Name(fibo_exmp_le_finst, "WellsFargoBankNationalAssociationDateEstablished") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:WellsFargoBankNationalAssociationDateInsured</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Wells Fargo Bank, National Association date insured"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoBankNationalAssociationDateInsured">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoBankNationalAssociationDateInsured</seealso>
    let WellsFargoBankNationalAssociationDateInsured =
        Prefixed_Name(fibo_exmp_le_finst, "WellsFargoBankNationalAssociationDateInsured") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:WellsFargoBankNationalAssociationFDICCertificateNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usjrga:FDICCertificateNumber</para>
    ///
    /// labels<para>"Wells Fargo Bank, National Association FDIC Certificate number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoBankNationalAssociationFDICCertificateNumber">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoBankNationalAssociationFDICCertificateNumber</seealso>
    let WellsFargoBankNationalAssociationFDICCertificateNumber =
        Prefixed_Name(fibo_exmp_le_finst, "WellsFargoBankNationalAssociationFDICCertificateNumber") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:WellsFargoBankNationalAssociationHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:PhysicalAddress</para>
    ///
    /// labels<para>"Wells Fargo Bank, National Association headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoBankNationalAssociationHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoBankNationalAssociationHeadquartersAddress</seealso>
    let WellsFargoBankNationalAssociationHeadquartersAddress =
        Prefixed_Name(fibo_exmp_le_finst, "WellsFargoBankNationalAssociationHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:WellsFargoBankNationalAssociationLegalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:PhysicalAddress</para>
    ///
    /// labels<para>"Wells Fargo Bank, National Association legal address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoBankNationalAssociationLegalAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoBankNationalAssociationLegalAddress</seealso>
    let WellsFargoBankNationalAssociationLegalAddress =
        Prefixed_Name(fibo_exmp_le_finst, "WellsFargoBankNationalAssociationLegalAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:WellsFargoBankNationalAssociationLegalEntityIdentifierRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:LegalEntityIdentifierRegistryEntry</para>
    ///
    /// labels<para>"Wells Fargo Bank, National Association legal entity identifier registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoBankNationalAssociationLegalEntityIdentifierRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoBankNationalAssociationLegalEntityIdentifierRegistryEntry</seealso>
    let WellsFargoBankNationalAssociationLegalEntityIdentifierRegistryEntry =
        Prefixed_Name(fibo_exmp_le_finst, "WellsFargoBankNationalAssociationLegalEntityIdentifierRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:WellsFargoBankNationalAssociationOwnership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-oac-opty:DirectConsolidation</para>
    ///
    /// labels<para>"Wells Fargo Bank, National Association ownership"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoBankNationalAssociationOwnership">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoBankNationalAssociationOwnership</seealso>
    let WellsFargoBankNationalAssociationOwnership =
        Prefixed_Name(fibo_exmp_le_finst, "WellsFargoBankNationalAssociationOwnership") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:WellsFargoBankNationalAssociationRSSDIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-usjrga:ResearchStatisticsSupervisionDiscountIdentifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Wells Fargo Bank, National Association RSSD identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoBankNationalAssociationRSSDIdentifier">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoBankNationalAssociationRSSDIdentifier</seealso>
    let WellsFargoBankNationalAssociationRSSDIdentifier =
        Prefixed_Name(fibo_exmp_le_finst, "WellsFargoBankNationalAssociationRSSDIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:WellsFargoBankNationalAssociationRTN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usjrga:RoutingTransitNumber</para>
    ///
    /// labels<para>"Wells Fargo Bank, National Association RTN"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoBankNationalAssociationRTN">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/WellsFargoBankNationalAssociationRTN</seealso>
    let WellsFargoBankNationalAssociationRTN =
        Prefixed_Name(fibo_exmp_le_finst, "WellsFargoBankNationalAssociationRTN") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Financial Institution Examples"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_exmp_le_finst, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-exmp-le-finst:ABNAMROBank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-fse:BrokerageFirm</para>
    ///   <para>fibo-der-drc-bsc:IntroducingBroker</para>
    ///   <para>fibo-fbc-fct-fse:CommercialBank</para>
    ///   <para>fibo-fbc-fct-fse:CommodityTradingAdvisor</para>
    ///   <para>fibo-fbc-fct-fse:InsuranceCompany</para>
    ///   <para>fibo-der-drc-swp:SwapDealer</para>
    ///
    /// labels<para>"ABN AMRO Bank"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/ABNAMROBank">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/ABNAMROBank</seealso>
    let ABNAMROBank = Prefixed_Name(fibo_exmp_le_finst, "ABNAMROBank") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:ABNAMROBankNV</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:Corporation</para>
    ///
    /// labels<para>"ABN AMRO Bank N.V."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/ABNAMROBankNV">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/ABNAMROBankNV</seealso>
    let ABNAMROBankNV =
        Prefixed_Name(fibo_exmp_le_finst, "ABNAMROBankNV") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:ABNAMROBankNVHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ABN AMRO Bank N.V. headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/ABNAMROBankNVHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/ABNAMROBankNVHeadquartersAddress</seealso>
    let ABNAMROBankNVHeadquartersAddress =
        Prefixed_Name(fibo_exmp_le_finst, "ABNAMROBankNVHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:ABNAMROBankNVLegalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///
    /// labels<para>"ABN AMRO Bank N.V. legal address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/ABNAMROBankNVLegalAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/ABNAMROBankNVLegalAddress</seealso>
    let ABNAMROBankNVLegalAddress =
        Prefixed_Name(fibo_exmp_le_finst, "ABNAMROBankNVLegalAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:ABNAMROBankNVLegalEntityIdentifierRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:LegalEntityIdentifierRegistryEntry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ABN AMRO Bank N.V. legal entity identifier registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/ABNAMROBankNVLegalEntityIdentifierRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/ABNAMROBankNVLegalEntityIdentifierRegistryEntry</seealso>
    let ABNAMROBankNVLegalEntityIdentifierRegistryEntry =
        Prefixed_Name(fibo_exmp_le_finst, "ABNAMROBankNVLegalEntityIdentifierRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:ABNAMROSecurities</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-fse:BrokerageFirm</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ABN AMRO Securities"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/ABNAMROSecurities">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/ABNAMROSecurities</seealso>
    let ABNAMROSecurities =
        Prefixed_Name(fibo_exmp_le_finst, "ABNAMROSecurities") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:ABNAMROSecuritiesHeadquartersAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///
    /// labels<para>"ABN AMRO Securities (USA) LLC headquarters address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/ABNAMROSecuritiesHeadquartersAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/ABNAMROSecuritiesHeadquartersAddress</seealso>
    let ABNAMROSecuritiesHeadquartersAddress =
        Prefixed_Name(fibo_exmp_le_finst, "ABNAMROSecuritiesHeadquartersAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:ABNAMROSecuritiesLegalAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///
    /// labels<para>"ABN AMRO Securities (USA) LLC legal address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/ABNAMROSecuritiesLegalAddress">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/ABNAMROSecuritiesLegalAddress</seealso>
    let ABNAMROSecuritiesLegalAddress =
        Prefixed_Name(fibo_exmp_le_finst, "ABNAMROSecuritiesLegalAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:ABNAMROSecuritiesLegalEntityIdentifierRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:LegalEntityIdentifierRegistryEntry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ABN AMRO Securities (USA) LLC legal entity identifier registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/ABNAMROSecuritiesLegalEntityIdentifierRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/ABNAMROSecuritiesLegalEntityIdentifierRegistryEntry</seealso>
    let ABNAMROSecuritiesLegalEntityIdentifierRegistryEntry =
        Prefixed_Name(fibo_exmp_le_finst, "ABNAMROSecuritiesLegalEntityIdentifierRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:ABNAMROSecuritiesUSALLC-US-DE</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-plc-plc:LimitedLiabilityCompany</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ABN AMRO Securities (USA) LLC"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/ABNAMROSecuritiesUSALLC-US-DE">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/ABNAMROSecuritiesUSALLC-US-DE</seealso>
    let ABNAMROSecuritiesUSALLC_US_DE =
        Prefixed_Name(fibo_exmp_le_finst, "ABNAMROSecuritiesUSALLC-US-DE") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BNPParibasUSAINC-US-DE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:Corporation</para>
    ///
    /// labels<para>"BNP Paribas USA, INC."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BNPParibasUSAINC-US-DE">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BNPParibasUSAINC-US-DE</seealso>
    let BNPParibasUSAINC_US_DE =
        Prefixed_Name(fibo_exmp_le_finst, "BNPParibasUSAINC-US-DE") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BNYMellonNationalAssociation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-usfse:NationalBank</para>
    ///
    /// labels<para>"BNY Mellon, National Association"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BNYMellonNationalAssociation">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BNYMellonNationalAssociation</seealso>
    let BNYMellonNationalAssociation =
        Prefixed_Name(fibo_exmp_le_finst, "BNYMellonNationalAssociation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-le-finst:BNYMellonNationalAssociation-US-DE</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:StockCorporation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"BNY Mellon, National Association US-DE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BNYMellonNationalAssociation-US-DE">https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/BNYMellonNationalAssociation-US-DE</seealso>
    let BNYMellonNationalAssociation_US_DE =
        Prefixed_Name(fibo_exmp_le_finst, "BNYMellonNationalAssociation-US-DE") |> PrefixedName
