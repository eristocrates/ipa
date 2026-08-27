namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FunctionalEntities.NorthAmericanEntities.CARegulatoryAgencies.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fbc_fct_cajrga =
    let _namespace_iri = Namespace_Iri fibo_fbc_fct_cajrga |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fbc-fct-cajrga:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Canadian Regulatory Agencies Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fbc_fct_cajrga, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cajrga:BankOfCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:GovernmentAgency</para>
    ///
    /// labels<para>"Banque du Canada"</para><para>"Bank of Canada"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/BankOfCanada">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/BankOfCanada</seealso>
    let BankOfCanada =
        Prefixed_Name(fibo_fbc_fct_cajrga, "BankOfCanada") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cajrga:BankOfCanadaHeadOfficeAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///
    /// labels<para>"Bank of Canada head office address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/BankOfCanadaHeadOfficeAddress">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/BankOfCanadaHeadOfficeAddress</seealso>
    let BankOfCanadaHeadOfficeAddress =
        Prefixed_Name(fibo_fbc_fct_cajrga, "BankOfCanadaHeadOfficeAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cajrga:BankOfCanadaLegalEntityIdentifierRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:LegalEntityIdentifierRegistryEntry</para>
    ///
    /// labels<para>"Bank of Canada legal entity identifier registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/BankOfCanadaLegalEntityIdentifierRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/BankOfCanadaLegalEntityIdentifierRegistryEntry</seealso>
    let BankOfCanadaLegalEntityIdentifierRegistryEntry =
        Prefixed_Name(fibo_fbc_fct_cajrga, "BankOfCanadaLegalEntityIdentifierRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cajrga:BusinessNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"business number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/BusinessNumber">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/BusinessNumber</seealso>
    let BusinessNumber =
        Prefixed_Name(fibo_fbc_fct_cajrga, "BusinessNumber") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cajrga:BusinessNumberRegistrationIdentifierScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-pty-pty:TaxIdentificationScheme</para>
    ///   <para>fibo-be-le-cb:RegistrationIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Canada Revenue Agency business number registration identifier scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/BusinessNumberRegistrationIdentifierScheme">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/BusinessNumberRegistrationIdentifierScheme</seealso>
    let BusinessNumberRegistrationIdentifierScheme =
        Prefixed_Name(fibo_fbc_fct_cajrga, "BusinessNumberRegistrationIdentifierScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cajrga:BusinessNumberRegistrationService</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegistrationAuthorities:RegistrationService</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Canada Revenue Agency business number registration service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/BusinessNumberRegistrationService">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/BusinessNumberRegistrationService</seealso>
    let BusinessNumberRegistrationService =
        Prefixed_Name(fibo_fbc_fct_cajrga, "BusinessNumberRegistrationService") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cajrga:BusinessNumberRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:BusinessRegistry</para>
    ///
    /// labels<para>"Canada Revenue Agency business number entity registry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/BusinessNumberRegistry">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/BusinessNumberRegistry</seealso>
    let BusinessNumberRegistry =
        Prefixed_Name(fibo_fbc_fct_cajrga, "BusinessNumberRegistry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cajrga:CanadaRevenueAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-ge-ge:GovernmentAgency</para>
    ///
    /// labels<para>"Canada Revenue Agency"</para><para>"Agence du revenu du Canada"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/CanadaRevenueAgency">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/CanadaRevenueAgency</seealso>
    let CanadaRevenueAgency =
        Prefixed_Name(fibo_fbc_fct_cajrga, "CanadaRevenueAgency") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cajrga:CanadaRevenueAgencyHeadOfficeAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-plc-adr:ConventionalStreetAddress</para>
    ///
    /// labels<para>"Canada Revenue Agency head office address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/CanadaRevenueAgencyHeadOfficeAddress">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/CanadaRevenueAgencyHeadOfficeAddress</seealso>
    let CanadaRevenueAgencyHeadOfficeAddress =
        Prefixed_Name(fibo_fbc_fct_cajrga, "CanadaRevenueAgencyHeadOfficeAddress") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cajrga:CanadianBankingRegulatoryAgencyAndCentralBank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegulatoryAgencies:RegulatoryAgency</para>
    ///   <para>RegistrationAuthorities:RegistrationAuthority</para>
    ///   <para>fibo-ind-ir-ir:InterestRateAuthority</para>
    ///   <para>fibo-fbc-fct-fse:CentralBank</para>
    ///
    /// labels<para>"Canadian banking regulatory agency, registration authority and central bank role of the Bank of Canada"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/CanadianBankingRegulatoryAgencyAndCentralBank">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/CanadianBankingRegulatoryAgencyAndCentralBank</seealso>
    let CanadianBankingRegulatoryAgencyAndCentralBank =
        Prefixed_Name(fibo_fbc_fct_cajrga, "CanadianBankingRegulatoryAgencyAndCentralBank") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cajrga:CanadianBusinessTaxRegistrar</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegulatoryAgencies:RegulatoryAgency</para>
    ///   <para>fibo-fbc-fct-breg:BusinessRegistrationAuthority</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Canadian business and tax registrar"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/CanadianBusinessTaxRegistrar">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/CanadianBusinessTaxRegistrar</seealso>
    let CanadianBusinessTaxRegistrar =
        Prefixed_Name(fibo_fbc_fct_cajrga, "CanadianBusinessTaxRegistrar") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cajrga:CorporationIncomeTaxNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"corporation income tax number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/CorporationIncomeTaxNumber">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/CorporationIncomeTaxNumber</seealso>
    let CorporationIncomeTaxNumber =
        Prefixed_Name(fibo_fbc_fct_cajrga, "CorporationIncomeTaxNumber") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cajrga:CorporationIncomeTaxNumberIdentifierScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:RegistrationIdentifierScheme</para>
    ///
    /// labels<para>"Canada Revenue Agency corporation income tax number identifier scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/CorporationIncomeTaxNumberIdentifierScheme">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/CorporationIncomeTaxNumberIdentifierScheme</seealso>
    let CorporationIncomeTaxNumberIdentifierScheme =
        Prefixed_Name(fibo_fbc_fct_cajrga, "CorporationIncomeTaxNumberIdentifierScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cajrga:CorporationIncomeTaxNumberRegistrationService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegistrationAuthorities:RegistrationService</para>
    ///
    /// labels<para>"Canada Revenue Agency corporation income tax number registration service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/CorporationIncomeTaxNumberRegistrationService">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/CorporationIncomeTaxNumberRegistrationService</seealso>
    let CorporationIncomeTaxNumberRegistrationService =
        Prefixed_Name(fibo_fbc_fct_cajrga, "CorporationIncomeTaxNumberRegistrationService") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cajrga:CorporationIncomeTaxNumberRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:BusinessRegistry</para>
    ///
    /// labels<para>"Canada Revenue Agency corporation income tax number registry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/CorporationIncomeTaxNumberRegistry">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/CorporationIncomeTaxNumberRegistry</seealso>
    let CorporationIncomeTaxNumberRegistry =
        Prefixed_Name(fibo_fbc_fct_cajrga, "CorporationIncomeTaxNumberRegistry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cajrga:GoodsServicesTaxHarmonizedSalesTaxNumberRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:BusinessRegistry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Canada Revenue Agency Goods and Services Tax / Harmonized Sales Tax number registry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/GoodsServicesTaxHarmonizedSalesTaxNumberRegistry">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/GoodsServicesTaxHarmonizedSalesTaxNumberRegistry</seealso>
    let GoodsServicesTaxHarmonizedSalesTaxNumberRegistry =
        Prefixed_Name(fibo_fbc_fct_cajrga, "GoodsServicesTaxHarmonizedSalesTaxNumberRegistry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cajrga:GoodsServicesTaxHarmonizedSalesTaxRegistrationIdentifierScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:RegistrationIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Canada Revenue Agency Goods and Services Tax / Harmonized Sales Tax registration number identifier scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/GoodsServicesTaxHarmonizedSalesTaxRegistrationIdentifierScheme">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/GoodsServicesTaxHarmonizedSalesTaxRegistrationIdentifierScheme</seealso>
    let GoodsServicesTaxHarmonizedSalesTaxRegistrationIdentifierScheme =
        Prefixed_Name(fibo_fbc_fct_cajrga, "GoodsServicesTaxHarmonizedSalesTaxRegistrationIdentifierScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cajrga:GoodsServicesTaxHarmonizedSalesTaxRegistrationNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Goods and Services Tax / Harmonized Sales Tax registration number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/GoodsServicesTaxHarmonizedSalesTaxRegistrationNumber">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/GoodsServicesTaxHarmonizedSalesTaxRegistrationNumber</seealso>
    let GoodsServicesTaxHarmonizedSalesTaxRegistrationNumber =
        Prefixed_Name(fibo_fbc_fct_cajrga, "GoodsServicesTaxHarmonizedSalesTaxRegistrationNumber") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cajrga:GoodsServicesTaxHarmonizedSalesTaxRegistrationService</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegistrationAuthorities:RegistrationService</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Canada Revenue Agency GST/HST number registration service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/GoodsServicesTaxHarmonizedSalesTaxRegistrationService">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/GoodsServicesTaxHarmonizedSalesTaxRegistrationService</seealso>
    let GoodsServicesTaxHarmonizedSalesTaxRegistrationService =
        Prefixed_Name(fibo_fbc_fct_cajrga, "GoodsServicesTaxHarmonizedSalesTaxRegistrationService") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cajrga:ImportExportProgramNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"import export program number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/ImportExportProgramNumber">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/ImportExportProgramNumber</seealso>
    let ImportExportProgramNumber =
        Prefixed_Name(fibo_fbc_fct_cajrga, "ImportExportProgramNumber") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cajrga:ImportExportProgramNumberIdentifierScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:RegistrationIdentifierScheme</para>
    ///
    /// labels<para>"Canada Revenue Agency import export program number identifier scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/ImportExportProgramNumberIdentifierScheme">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/ImportExportProgramNumberIdentifierScheme</seealso>
    let ImportExportProgramNumberIdentifierScheme =
        Prefixed_Name(fibo_fbc_fct_cajrga, "ImportExportProgramNumberIdentifierScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cajrga:ImportExportProgramNumberRegistrationService</para>
    /// </summary>
    /// <remarks>
    ///   <para>RegistrationAuthorities:RegistrationService</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Canada Revenue Agency import export program number registration service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/ImportExportProgramNumberRegistrationService">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/ImportExportProgramNumberRegistrationService</seealso>
    let ImportExportProgramNumberRegistrationService =
        Prefixed_Name(fibo_fbc_fct_cajrga, "ImportExportProgramNumberRegistrationService") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cajrga:ImportExportProgramNumberRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:BusinessRegistry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Canada Revenue Agency import export program number registry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/ImportExportProgramNumberRegistry">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/ImportExportProgramNumberRegistry</seealso>
    let ImportExportProgramNumberRegistry =
        Prefixed_Name(fibo_fbc_fct_cajrga, "ImportExportProgramNumberRegistry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cajrga:InformationReturnsIdentifierScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:RegistrationIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Canada Revenue Agency information return program number identifier scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/InformationReturnsIdentifierScheme">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/InformationReturnsIdentifierScheme</seealso>
    let InformationReturnsIdentifierScheme =
        Prefixed_Name(fibo_fbc_fct_cajrga, "InformationReturnsIdentifierScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cajrga:InformationReturnsProgramNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"information return program number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/InformationReturnsProgramNumber">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/InformationReturnsProgramNumber</seealso>
    let InformationReturnsProgramNumber =
        Prefixed_Name(fibo_fbc_fct_cajrga, "InformationReturnsProgramNumber") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cajrga:InformationReturnsProgramNumberRegistrationService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegistrationAuthorities:RegistrationService</para>
    ///
    /// labels<para>"Canada Revenue Agency information return program number registration service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/InformationReturnsProgramNumberRegistrationService">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/InformationReturnsProgramNumberRegistrationService</seealso>
    let InformationReturnsProgramNumberRegistrationService =
        Prefixed_Name(fibo_fbc_fct_cajrga, "InformationReturnsProgramNumberRegistrationService") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cajrga:InformationReturnsProgramNumberRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:BusinessRegistry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Canada Revenue Agency import information return program number registry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/InformationReturnsProgramNumberRegistry">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/InformationReturnsProgramNumberRegistry</seealso>
    let InformationReturnsProgramNumberRegistry =
        Prefixed_Name(fibo_fbc_fct_cajrga, "InformationReturnsProgramNumberRegistry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cajrga:PayrollDeductionsProgramIdentifierRegistrationService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegistrationAuthorities:RegistrationService</para>
    ///
    /// labels<para>"Canada Revenue Agency payroll deductions program number registration service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/PayrollDeductionsProgramIdentifierRegistrationService">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/PayrollDeductionsProgramIdentifierRegistrationService</seealso>
    let PayrollDeductionsProgramIdentifierRegistrationService =
        Prefixed_Name(fibo_fbc_fct_cajrga, "PayrollDeductionsProgramIdentifierRegistrationService") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cajrga:PayrollDeductionsProgramIdentifierScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-be-le-cb:RegistrationIdentifierScheme</para>
    ///
    /// labels<para>"Canada Revenue Agency payroll deductions program number identifier scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/PayrollDeductionsProgramIdentifierScheme">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/PayrollDeductionsProgramIdentifierScheme</seealso>
    let PayrollDeductionsProgramIdentifierScheme =
        Prefixed_Name(fibo_fbc_fct_cajrga, "PayrollDeductionsProgramIdentifierScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cajrga:PayrollDeductionsProgramNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"payroll deductions program number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/PayrollDeductionsProgramNumber">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/PayrollDeductionsProgramNumber</seealso>
    let PayrollDeductionsProgramNumber =
        Prefixed_Name(fibo_fbc_fct_cajrga, "PayrollDeductionsProgramNumber") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cajrga:PayrollDeductionsProgramNumberRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-fct-breg:BusinessRegistry</para>
    ///
    /// labels<para>"Canada Revenue Agency payroll deductions program number registry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/PayrollDeductionsProgramNumberRegistry">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/PayrollDeductionsProgramNumberRegistry</seealso>
    let PayrollDeductionsProgramNumberRegistry =
        Prefixed_Name(fibo_fbc_fct_cajrga, "PayrollDeductionsProgramNumberRegistry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cajrga:RegisteredCharityProgramNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"registered charity program number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/RegisteredCharityProgramNumber">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/RegisteredCharityProgramNumber</seealso>
    let RegisteredCharityProgramNumber =
        Prefixed_Name(fibo_fbc_fct_cajrga, "RegisteredCharityProgramNumber") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cajrga:RegisteredCharityProgramNumberIdentifierScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-be-le-cb:RegistrationIdentifierScheme</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Canada Revenue Agency registered charity program number identifier scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/RegisteredCharityProgramNumberIdentifierScheme">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/RegisteredCharityProgramNumberIdentifierScheme</seealso>
    let RegisteredCharityProgramNumberIdentifierScheme =
        Prefixed_Name(fibo_fbc_fct_cajrga, "RegisteredCharityProgramNumberIdentifierScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cajrga:RegisteredCharityProgramNumberRegistrationService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegistrationAuthorities:RegistrationService</para>
    ///
    /// labels<para>"Canada Revenue Agency registered charity program number registration service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/RegisteredCharityProgramNumberRegistrationService">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/RegisteredCharityProgramNumberRegistrationService</seealso>
    let RegisteredCharityProgramNumberRegistrationService =
        Prefixed_Name(fibo_fbc_fct_cajrga, "RegisteredCharityProgramNumberRegistrationService") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-fct-cajrga:RegisteredCharityProgramNumberRegistry</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-fct-breg:BusinessRegistry</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Canada Revenue Agency import registered charity program number registry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/RegisteredCharityProgramNumberRegistry">https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/RegisteredCharityProgramNumberRegistry</seealso>
    let RegisteredCharityProgramNumberRegistry =
        Prefixed_Name(fibo_fbc_fct_cajrga, "RegisteredCharityProgramNumberRegistry") |> PrefixedName
