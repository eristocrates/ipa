#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fbc-fct-cajrga`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/" "fibo-fbc-fct-cajrga"

    let _namespaceIri = _prefixId.prefix ""
    let BankOfCanada = _prefixId.prefix "BankOfCanada"
    let BankOfCanadaHeadOfficeAddress = _prefixId.prefix "BankOfCanadaHeadOfficeAddress"

    let BankOfCanadaLegalEntityIdentifierRegistryEntry =
        _prefixId.prefix "BankOfCanadaLegalEntityIdentifierRegistryEntry"

    /// <summary>
    ///   <para>rdfs:label : business number^^xsd:string</para>
    ///   <para>skos:definition : unique, 9-digit number that is the standard identifier for legal entities in Canada which are typically a business^^xsd:string</para>
    ///   <para>skos:example : 000000000^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : BN^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.canada.ca/en/services/taxes/business-number.html^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/BusinessNumber">fibo-fbc-fct-cajrga:BusinessNumber</a>
    /// </summary>
    let BusinessNumber = _prefixId.prefix "BusinessNumber"

    let BusinessNumberRegistrationIdentifierScheme =
        _prefixId.prefix "BusinessNumberRegistrationIdentifierScheme"

    let BusinessNumberRegistrationService =
        _prefixId.prefix "BusinessNumberRegistrationService"

    let BusinessNumberRegistry = _prefixId.prefix "BusinessNumberRegistry"
    let CanadaRevenueAgency = _prefixId.prefix "CanadaRevenueAgency"

    let CanadaRevenueAgencyHeadOfficeAddress =
        _prefixId.prefix "CanadaRevenueAgencyHeadOfficeAddress"

    let CanadianBankingRegulatoryAgencyAndCentralBank =
        _prefixId.prefix "CanadianBankingRegulatoryAgencyAndCentralBank"

    let CanadianBusinessTaxRegistrar = _prefixId.prefix "CanadianBusinessTaxRegistrar"
    /// <summary>
    ///   <para>rdfs:label : corporation income tax number^^xsd:string</para>
    ///   <para>skos:definition : concatenation of an entity's business number, the 'RC' abbreviation and a 4-digit subaccount number used for reporting corporate income tax^^xsd:string</para>
    ///   <para>skos:example : 000000000RC0001^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.canada.ca/en/revenue-agency/services/tax/businesses/topics/registering-your-business/corporation-income-tax-program-account.html^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : An organization may have more than one tax account through its subunits, this is handled through additional 4-digit subaccount numbers. This is used as both an account and an identifier for the registration.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/CorporationIncomeTaxNumber">fibo-fbc-fct-cajrga:CorporationIncomeTaxNumber</a>
    /// </summary>
    let CorporationIncomeTaxNumber = _prefixId.prefix "CorporationIncomeTaxNumber"

    let CorporationIncomeTaxNumberIdentifierScheme =
        _prefixId.prefix "CorporationIncomeTaxNumberIdentifierScheme"

    let CorporationIncomeTaxNumberRegistrationService =
        _prefixId.prefix "CorporationIncomeTaxNumberRegistrationService"

    let CorporationIncomeTaxNumberRegistry =
        _prefixId.prefix "CorporationIncomeTaxNumberRegistry"

    let GoodsServicesTaxHarmonizedSalesTaxNumberRegistry =
        _prefixId.prefix "GoodsServicesTaxHarmonizedSalesTaxNumberRegistry"

    let GoodsServicesTaxHarmonizedSalesTaxRegistrationIdentifierScheme =
        _prefixId.prefix "GoodsServicesTaxHarmonizedSalesTaxRegistrationIdentifierScheme"

    /// <summary>
    ///   <para>rdfs:label : Goods and Services Tax / Harmonized Sales Tax registration number^^xsd:string</para>
    ///   <para>skos:definition : concatenation of an entity's business number, the 'RT' abbreviation and a 4-digit subaccount number used for reporting GST/HST^^xsd:string</para>
    ///   <para>skos:example : 000000000RT0001^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : GST/HST registation number^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.canada.ca/en/revenue-agency/services/tax/businesses/topics/gst-hst-businesses/account-register.html^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : An organization may have more than one GST/HST account through its subunits, this is handled through additional 4-digit subaccount numbers. This is used as both an account and an identifier for the registration.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/GoodsServicesTaxHarmonizedSalesTaxRegistrationNumber">fibo-fbc-fct-cajrga:GoodsServicesTaxHarmonizedSalesTaxRegistrationNumber</a>
    /// </summary>
    let GoodsServicesTaxHarmonizedSalesTaxRegistrationNumber =
        _prefixId.prefix "GoodsServicesTaxHarmonizedSalesTaxRegistrationNumber"

    let GoodsServicesTaxHarmonizedSalesTaxRegistrationService =
        _prefixId.prefix "GoodsServicesTaxHarmonizedSalesTaxRegistrationService"

    /// <summary>
    ///   <para>rdfs:label : import export program number^^xsd:string</para>
    ///   <para>skos:definition : concatenation of an entity's business number, the 'RM' abbreviation and a 4-digit subaccount number used for customs and import/export reporting purposes^^xsd:string</para>
    ///   <para>skos:example : 000000000RM0001^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.canada.ca/en/revenue-agency/services/tax/businesses/topics/registering-your-business/import-export-program-account.html^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : An organization may have more than one import-exports account through its subunits, this is handled through additional 4-digit subaccount numbers. This is used as both an account and an identifier for the registration.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/ImportExportProgramNumber">fibo-fbc-fct-cajrga:ImportExportProgramNumber</a>
    /// </summary>
    let ImportExportProgramNumber = _prefixId.prefix "ImportExportProgramNumber"

    let ImportExportProgramNumberIdentifierScheme =
        _prefixId.prefix "ImportExportProgramNumberIdentifierScheme"

    let ImportExportProgramNumberRegistrationService =
        _prefixId.prefix "ImportExportProgramNumberRegistrationService"

    let ImportExportProgramNumberRegistry =
        _prefixId.prefix "ImportExportProgramNumberRegistry"

    let InformationReturnsIdentifierScheme =
        _prefixId.prefix "InformationReturnsIdentifierScheme"

    /// <summary>
    ///   <para>rdfs:label : information return program number^^xsd:string</para>
    ///   <para>skos:definition : concatenation of an entity's business number, the 'RZ' abbreviation and a 4-digit subaccount number used for information returns^^xsd:string</para>
    ///   <para>skos:example : 000000000RZ0001^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.canada.ca/en/revenue-agency/services/tax/businesses/topics/completing-slips-summaries/financial-slips-summaries/information-returns-program-account.html^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : An organization may have more than one information returns program number through its subunits, this is handled through additional 4-digit subaccount numbers. This is used as both an account and an identifier for the registration. As opposed to other program numbers, this number is used for filing information returns and not as an account.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/InformationReturnsProgramNumber">fibo-fbc-fct-cajrga:InformationReturnsProgramNumber</a>
    /// </summary>
    let InformationReturnsProgramNumber =
        _prefixId.prefix "InformationReturnsProgramNumber"

    let InformationReturnsProgramNumberRegistrationService =
        _prefixId.prefix "InformationReturnsProgramNumberRegistrationService"

    let InformationReturnsProgramNumberRegistry =
        _prefixId.prefix "InformationReturnsProgramNumberRegistry"

    let PayrollDeductionsProgramIdentifierRegistrationService =
        _prefixId.prefix "PayrollDeductionsProgramIdentifierRegistrationService"

    let PayrollDeductionsProgramIdentifierScheme =
        _prefixId.prefix "PayrollDeductionsProgramIdentifierScheme"

    /// <summary>
    ///   <para>rdfs:label : payroll deductions program number^^xsd:string</para>
    ///   <para>skos:definition : concatenation of an entity's business number, the 'RP' abbreviation and a 4-digit subaccount number used for reporting payroll deductions^^xsd:string</para>
    ///   <para>skos:example : 000000000RP0001^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.canada.ca/en/revenue-agency/services/tax/businesses/topics/payroll/what-payroll-account.html^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : An organization may have more than one deduction account through its subunits, this is handled through additional 4-digit subaccount numbers. This is used as both an account and an identifier for the registration.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/PayrollDeductionsProgramNumber">fibo-fbc-fct-cajrga:PayrollDeductionsProgramNumber</a>
    /// </summary>
    let PayrollDeductionsProgramNumber =
        _prefixId.prefix "PayrollDeductionsProgramNumber"

    let PayrollDeductionsProgramNumberRegistry =
        _prefixId.prefix "PayrollDeductionsProgramNumberRegistry"

    /// <summary>
    ///   <para>rdfs:label : registered charity program number^^xsd:string</para>
    ///   <para>skos:definition : concatenation of an entity's business number, the 'RR' abbreviation and a 4-digit subaccount number used for registered charity contribution^^xsd:string</para>
    ///   <para>skos:example : 000000000RR0001^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.canada.ca/en/revenue-agency/services/charities-giving/charities/operating-a-registered-charity/registration-number.html^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : An organization may have more than one registered charity account through its subunits, this is handled through additional 4-digit subaccount numbers. This is used as both an account and an identifier for the registration.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/RegisteredCharityProgramNumber">fibo-fbc-fct-cajrga:RegisteredCharityProgramNumber</a>
    /// </summary>
    let RegisteredCharityProgramNumber =
        _prefixId.prefix "RegisteredCharityProgramNumber"

    let RegisteredCharityProgramNumberIdentifierScheme =
        _prefixId.prefix "RegisteredCharityProgramNumberIdentifierScheme"

    let RegisteredCharityProgramNumberRegistrationService =
        _prefixId.prefix "RegisteredCharityProgramNumberRegistrationService"

    let RegisteredCharityProgramNumberRegistry =
        _prefixId.prefix "RegisteredCharityProgramNumberRegistry"
