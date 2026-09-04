#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fbc-fct-usjrga`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/" "fibo-fbc-fct-usjrga"

    let _namespaceIri = _prefixId.prefix ""
    let ABABusinessEntityIdentifier = _prefixId.prefix "ABABusinessEntityIdentifier"
    let ABAHeadquartersAddress = _prefixId.prefix "ABAHeadquartersAddress"
    let ABAIINRegistry = _prefixId.prefix "ABAIINRegistry"
    /// <summary>
    ///   <para>rdfs:label : ABA IIN registry entry^^xsd:string</para>
    ///   <para>skos:definition : an entry in the ABA IIN registry, a repository of financial institution characteristics collected by the ABA for those institutions to which they issue IINs^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/ABAIINRegistryEntry">fibo-fbc-fct-usjrga:ABAIINRegistryEntry</a>
    /// </summary>
    let ABAIINRegistryEntry = _prefixId.prefix "ABAIINRegistryEntry"
    let ABARTNRegistry = _prefixId.prefix "ABARTNRegistry"
    /// <summary>
    ///   <para>rdfs:label : ABA RTN registry entry^^xsd:string</para>
    ///   <para>skos:definition : an entry in the ABA RTN registry, a repository of financial institution characteristics collected by the ABA Registrar on behalf of the ABA^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/ABARTNRegistryEntry">fibo-fbc-fct-usjrga:ABARTNRegistryEntry</a>
    /// </summary>
    let ABARTNRegistryEntry = _prefixId.prefix "ABARTNRegistryEntry"
    let AccuityInc_US_DE = _prefixId.prefix "AccuityInc-US-DE"

    let AccuityIncBusinessEntityIdentifier =
        _prefixId.prefix "AccuityIncBusinessEntityIdentifier"

    let AccuityIncHeadquartersAddress = _prefixId.prefix "AccuityIncHeadquartersAddress"
    let AmericanBankersAssociation = _prefixId.prefix "AmericanBankersAssociation"

    let AmericanBankersAssociationRTNRegistrar =
        _prefixId.prefix "AmericanBankersAssociationRTNRegistrar"

    let AmericanBankersAssociationRegistrationAuthority =
        _prefixId.prefix "AmericanBankersAssociationRegistrationAuthority"

    let BloombergLPRSSDIdentifier = _prefixId.prefix "BloombergLPRSSDIdentifier"

    let BoardOfGovernorsOfTheFederalReserveSystem =
        _prefixId.prefix "BoardOfGovernorsOfTheFederalReserveSystem"

    let CFTCIndustryFilingsRepository = _prefixId.prefix "CFTCIndustryFilingsRepository"
    let CaliforniaBankingRegulator = _prefixId.prefix "CaliforniaBankingRegulator"

    let CaliforniaBusinessEntitiesRegistry =
        _prefixId.prefix "CaliforniaBusinessEntitiesRegistry"

    let CaliforniaBusinessProgramsDivision =
        _prefixId.prefix "CaliforniaBusinessProgramsDivision"

    let CaliforniaBusinessRegistrar = _prefixId.prefix "CaliforniaBusinessRegistrar"

    let CaliforniaBusinessRegistrationIdentifierScheme =
        _prefixId.prefix "CaliforniaBusinessRegistrationIdentifierScheme"

    let CaliforniaBusinessRegistrationService =
        _prefixId.prefix "CaliforniaBusinessRegistrationService"

    let CaliforniaDepartmentOfBusinessOversight =
        _prefixId.prefix "CaliforniaDepartmentOfBusinessOversight"

    let CaliforniaRegistrationAuthorityCode =
        _prefixId.prefix "CaliforniaRegistrationAuthorityCode"

    let CommoditiesFuturesAndDerivativesRegulator =
        _prefixId.prefix "CommoditiesFuturesAndDerivativesRegulator"

    let CommodityFuturesTradingCommission =
        _prefixId.prefix "CommodityFuturesTradingCommission"

    let ConsumerFinanceRegulator = _prefixId.prefix "ConsumerFinanceRegulator"

    let ConsumerFinancialProtectionBureau =
        _prefixId.prefix "ConsumerFinancialProtectionBureau"

    let CorporationServiceCompany = _prefixId.prefix "CorporationServiceCompany"

    let CorporationServiceCompany_US_DE =
        _prefixId.prefix "CorporationServiceCompany-US-DE"

    let CorporationServiceCompanyAddress =
        _prefixId.prefix "CorporationServiceCompanyAddress"

    let CorporationServiceCompanyBusinessEntityIdentifier =
        _prefixId.prefix "CorporationServiceCompanyBusinessEntityIdentifier"

    let CorporationTrustCompany = _prefixId.prefix "CorporationTrustCompany"
    let CorporationTrustCompany_US_DE = _prefixId.prefix "CorporationTrustCompany-US-DE"

    let CorporationTrustCompanyBusinessEntityIdentifier =
        _prefixId.prefix "CorporationTrustCompanyBusinessEntityIdentifier"

    let CorporationTrustCompanyHeadquartersAddress =
        _prefixId.prefix "CorporationTrustCompanyHeadquartersAddress"

    let DTCCINCBusinessEntityIdentifier =
        _prefixId.prefix "DTCCINCBusinessEntityIdentifier"

    let DTCFDICCertificateNumber = _prefixId.prefix "DTCFDICCertificateNumber"
    let DTCRSSDIdentifier = _prefixId.prefix "DTCRSSDIdentifier"
    let DTCRTN = _prefixId.prefix "DTCRTN"

    let DelawareBusinessEntitiesRegistry =
        _prefixId.prefix "DelawareBusinessEntitiesRegistry"

    let DelawareBusinessRegistrationIdentifierScheme =
        _prefixId.prefix "DelawareBusinessRegistrationIdentifierScheme"

    let DelawareBusinessRegistrationService =
        _prefixId.prefix "DelawareBusinessRegistrationService"

    let DelawareCorporationsRegulator = _prefixId.prefix "DelawareCorporationsRegulator"

    let DelawareDivisionOfCorporations =
        _prefixId.prefix "DelawareDivisionOfCorporations"

    let DelawareRegistrationAuthorityCode =
        _prefixId.prefix "DelawareRegistrationAuthorityCode"

    let EDGARRepository = _prefixId.prefix "EDGARRepository"
    /// <summary>
    ///   <para>rdfs:label : employer identification number^^xsd:string</para>
    ///   <para>skos:definition : unique nine-digit number assigned by the Internal Revenue Service (IRS) to business entities operating in the United States for the purposes of identification^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : EIN^^xsd:stringcmns-av:abbreviation : FEIN^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.irs.gov/businesses/small-businesses-self-employed/employer-id-numbers^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : Note that despite the name, the business may not necessarily employ anyone.^^xsd:string</para>
    ///   <para>cmns-av:synonym : Federal Employer Identification Number^^xsd:stringcmns-av:synonym : Federal Tax Identification Number^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/EmployerIdentificationNumber">fibo-fbc-fct-usjrga:EmployerIdentificationNumber</a>
    /// </summary>
    let EmployerIdentificationNumber = _prefixId.prefix "EmployerIdentificationNumber"

    /// <summary>
    ///   <para>rdfs:label : employer identification numbering scheme^^xsd:string</para>
    ///   <para>skos:definition : taxpayer identification numbering scheme used in the United States to identify business entities^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.irs.gov/businesses/small-businesses-self-employed/employer-id-numbers^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/EmployerIdentificationNumberingScheme">fibo-fbc-fct-usjrga:EmployerIdentificationNumberingScheme</a>
    /// </summary>
    let EmployerIdentificationNumberingScheme =
        _prefixId.prefix "EmployerIdentificationNumberingScheme"

    let FDICBusinessEntityIdentifier = _prefixId.prefix "FDICBusinessEntityIdentifier"
    /// <summary>
    ///   <para>rdfs:label : FDIC Certificate Number^^xsd:string</para>
    ///   <para>skos:definition : identifier issued to a depository institution by the FDIC on approval of that institution's application for insurance^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.fdic.gov/^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FDICCertificateNumber">fibo-fbc-fct-usjrga:FDICCertificateNumber</a>
    /// </summary>
    let FDICCertificateNumber = _prefixId.prefix "FDICCertificateNumber"
    let FDICInstitutionDirectory = _prefixId.prefix "FDICInstitutionDirectory"
    /// <summary>
    ///   <para>rdfs:label : FDIC registry entry^^xsd:string</para>
    ///   <para>skos:definition : an entry in the FDIC institution directory, a repository of financial institution characteristics collected by the FDIC related to the institutions they insure^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www7.fdic.gov/idasp/index.asp^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FDICRegistryEntry">fibo-fbc-fct-usjrga:FDICRegistryEntry</a>
    /// </summary>
    let FDICRegistryEntry = _prefixId.prefix "FDICRegistryEntry"
    let FarmCreditAdministration = _prefixId.prefix "FarmCreditAdministration"
    let FarmCreditRegulator = _prefixId.prefix "FarmCreditRegulator"

    let FederalDepositInsuranceCorporation =
        _prefixId.prefix "FederalDepositInsuranceCorporation"

    let FederalDepositInsurerAndRegulator =
        _prefixId.prefix "FederalDepositInsurerAndRegulator"

    let FederalFinancialInstitutionsExaminationCouncil =
        _prefixId.prefix "FederalFinancialInstitutionsExaminationCouncil"

    let FederalFinancialInstitutionsExaminationRegulator =
        _prefixId.prefix "FederalFinancialInstitutionsExaminationRegulator"

    /// <summary>
    ///   <para>rdfs:label : federal government entity^^xsd:string</para>
    ///   <para>skos:definition : formal organization that is an independent agency, instrumentality or other permanent or semi-permanent organization in the machinery of government in the United States, authorized by the executive branch or by Congress, that operates at the national (federal) level^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalGovernmentEntity">fibo-fbc-fct-usjrga:FederalGovernmentEntity</a>
    /// </summary>
    let FederalGovernmentEntity = _prefixId.prefix "FederalGovernmentEntity"
    let FederalHousingFinanceAgency = _prefixId.prefix "FederalHousingFinanceAgency"

    let FederalHousingFinanceRegulator =
        _prefixId.prefix "FederalHousingFinanceRegulator"

    let FederalReserveBankOfAtlanta = _prefixId.prefix "FederalReserveBankOfAtlanta"
    let FederalReserveBankOfBoston = _prefixId.prefix "FederalReserveBankOfBoston"
    let FederalReserveBankOfChicago = _prefixId.prefix "FederalReserveBankOfChicago"
    let FederalReserveBankOfCleveland = _prefixId.prefix "FederalReserveBankOfCleveland"
    let FederalReserveBankOfDallas = _prefixId.prefix "FederalReserveBankOfDallas"

    let FederalReserveBankOfKansasCity =
        _prefixId.prefix "FederalReserveBankOfKansasCity"

    let FederalReserveBankOfMinneapolis =
        _prefixId.prefix "FederalReserveBankOfMinneapolis"

    let FederalReserveBankOfNewYork = _prefixId.prefix "FederalReserveBankOfNewYork"

    let FederalReserveBankOfNewYork_US_NY =
        _prefixId.prefix "FederalReserveBankOfNewYork-US-NY"

    let FederalReserveBankOfNewYorkAddress =
        _prefixId.prefix "FederalReserveBankOfNewYorkAddress"

    let FederalReserveBankOfPhiladelphia =
        _prefixId.prefix "FederalReserveBankOfPhiladelphia"

    let FederalReserveBankOfRichmond = _prefixId.prefix "FederalReserveBankOfRichmond"

    let FederalReserveBankOfSanFrancisco =
        _prefixId.prefix "FederalReserveBankOfSanFrancisco"

    let FederalReserveBankOfStLouis = _prefixId.prefix "FederalReserveBankOfStLouis"
    let FederalReserveBoard = _prefixId.prefix "FederalReserveBoard"
    /// <summary>
    ///   <para>rdfs:label : Federal Reserve district^^xsd:string</para>
    ///   <para>skos:definition : a region of the US identifying the jurisdiction of a Federal Reserve Bank, numbered and named for the city in which that reserve bank is located^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://federalreserve.gov/otherfrb.htm^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : The Federal Reserve officially identifies Districts by number and Reserve Bank city. In the 12th District, the Seattle Branch serves Alaska, and the San Francisco Bank serves Hawaii. The System serves commonwealths and territories as follows: the New York Bank serves the Commonwealth of Puerto Rico and the U.S. Virgin Islands; the San Francisco Bank serves American Samoa, Guam, and the Commonwealth of the Northern Mariana Islands. The Board of Governors revised the branch boundaries of the System in February 1996.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveDistrict">fibo-fbc-fct-usjrga:FederalReserveDistrict</a>
    /// </summary>
    let FederalReserveDistrict = _prefixId.prefix "FederalReserveDistrict"
    /// <summary>
    ///   <para>rdfs:label : Federal Reserve district bank^^xsd:string</para>
    ///   <para>skos:definition : Federal Reserve district and member bank, with jurisdiction over a specific region of the US, named for the city in which the reserve bank is located^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://federalreserve.gov/^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveDistrictBank">fibo-fbc-fct-usjrga:FederalReserveDistrictBank</a>
    /// </summary>
    let FederalReserveDistrictBank = _prefixId.prefix "FederalReserveDistrictBank"

    /// <summary>
    ///   <para>rdfs:label : Federal Reserve district identifier^^xsd:string</para>
    ///   <para>skos:definition : identifier associated with a Federal Reserve district^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveDistrictIdentifier">fibo-fbc-fct-usjrga:FederalReserveDistrictIdentifier</a>
    /// </summary>
    let FederalReserveDistrictIdentifier =
        _prefixId.prefix "FederalReserveDistrictIdentifier"

    let FederalReserveEighthDistrict = _prefixId.prefix "FederalReserveEighthDistrict"

    let FederalReserveEighthDistrictIdentifier =
        _prefixId.prefix "FederalReserveEighthDistrictIdentifier"

    let FederalReserveEleventhDistrict =
        _prefixId.prefix "FederalReserveEleventhDistrict"

    let FederalReserveEleventhDistrictIdentifier =
        _prefixId.prefix "FederalReserveEleventhDistrictIdentifier"

    let FederalReserveFifthDistrict = _prefixId.prefix "FederalReserveFifthDistrict"

    let FederalReserveFifthDistrictIdentifier =
        _prefixId.prefix "FederalReserveFifthDistrictIdentifier"

    let FederalReserveFirstDistrict = _prefixId.prefix "FederalReserveFirstDistrict"

    let FederalReserveFirstDistrictIdentifier =
        _prefixId.prefix "FederalReserveFirstDistrictIdentifier"

    let FederalReserveFourthDistrict = _prefixId.prefix "FederalReserveFourthDistrict"

    let FederalReserveFourthDistrictIdentifier =
        _prefixId.prefix "FederalReserveFourthDistrictIdentifier"

    let FederalReserveNinthDistrict = _prefixId.prefix "FederalReserveNinthDistrict"

    let FederalReserveNinthDistrictIdentifier =
        _prefixId.prefix "FederalReserveNinthDistrictIdentifier"

    let FederalReserveRegulatoryAgencyAndCentralBank =
        _prefixId.prefix "FederalReserveRegulatoryAgencyAndCentralBank"

    let FederalReserveSecondDistrict = _prefixId.prefix "FederalReserveSecondDistrict"

    let FederalReserveSecondDistrictIdentifier =
        _prefixId.prefix "FederalReserveSecondDistrictIdentifier"

    let FederalReserveSeventhDistrict = _prefixId.prefix "FederalReserveSeventhDistrict"

    let FederalReserveSeventhDistrictIdentifier =
        _prefixId.prefix "FederalReserveSeventhDistrictIdentifier"

    let FederalReserveSixthDistrict = _prefixId.prefix "FederalReserveSixthDistrict"

    let FederalReserveSixthDistrictIdentifier =
        _prefixId.prefix "FederalReserveSixthDistrictIdentifier"

    let FederalReserveSystem = _prefixId.prefix "FederalReserveSystem"

    let FederalReserveSystemAsMemberBearingOrganization =
        _prefixId.prefix "FederalReserveSystemAsMemberBearingOrganization"

    /// <summary>
    ///   <para>rdfs:label : Federal Reserve System member^^xsd:string</para>
    ///   <para>skos:definition : financial institution that is a member of the Federal Reserve System (FRS)^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://federalreserve.gov/^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveSystemMember">fibo-fbc-fct-usjrga:FederalReserveSystemMember</a>
    /// </summary>
    let FederalReserveSystemMember = _prefixId.prefix "FederalReserveSystemMember"

    let FederalReserveSystemMembership =
        _prefixId.prefix "FederalReserveSystemMembership"

    /// <summary>
    ///   <para>rdfs:label : Federal Reserve System non-member institution^^xsd:string</para>
    ///   <para>skos:definition : depository institution that is not member of the Federal Reserve System (FRS)^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : A non-member bank is a commercial bank that is state-chartered and NOT a member of the Federal Reserve System. It includes all insured commercial banks and industrial banks.^^xsd:string</para>
    ///   <para>cmns-av:synonym : non-member bank^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/FederalReserveSystemNonMemberInstitution">fibo-fbc-fct-usjrga:FederalReserveSystemNonMemberInstitution</a>
    /// </summary>
    let FederalReserveSystemNonMemberInstitution =
        _prefixId.prefix "FederalReserveSystemNonMemberInstitution"

    let FederalReserveTenthDistrict = _prefixId.prefix "FederalReserveTenthDistrict"

    let FederalReserveTenthDistrictIdentifier =
        _prefixId.prefix "FederalReserveTenthDistrictIdentifier"

    let FederalReserveThirdDistrict = _prefixId.prefix "FederalReserveThirdDistrict"

    let FederalReserveThirdDistrictIdentifier =
        _prefixId.prefix "FederalReserveThirdDistrictIdentifier"

    let FederalReserveTwelfthDistrict = _prefixId.prefix "FederalReserveTwelfthDistrict"

    let FederalReserveTwelfthDistrictIdentifier =
        _prefixId.prefix "FederalReserveTwelfthDistrictIdentifier"

    let FederalStabilityMonitorAndRegulator =
        _prefixId.prefix "FederalStabilityMonitorAndRegulator"

    let FinancialIndustryRegulator = _prefixId.prefix "FinancialIndustryRegulator"

    let FinancialIndustryRegulatoryAuthority =
        _prefixId.prefix "FinancialIndustryRegulatoryAuthority"

    let FinancialStabilityOversightCouncil =
        _prefixId.prefix "FinancialStabilityOversightCouncil"

    /// <summary>
    ///   <para>rdfs:label : issuer identification number^^xsd:string</para>
    ///   <para>skos:definition : a numbering system that allows a credit, debit, or other card to be identified as having been issued by a particular financial institution^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : IIN^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : IINs are issued directly by the American Banker's Association (ABA) in the US. The ABA is the Registration Authority (RA) for ISO/IEC 7812, which defines the IIN, in other words.^^xsd:stringcmns-av:explanatoryNote : The issuer identification number (IIN) is a six digit number that is unique to a single card issuer. The number is only used to identify the card issuer, and is not used to identify a particular product, service, or region associated with the card issuer.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/IssuerIdentificationNumber">fibo-fbc-fct-usjrga:IssuerIdentificationNumber</a>
    /// </summary>
    let IssuerIdentificationNumber = _prefixId.prefix "IssuerIdentificationNumber"

    let MassachusettsBusinessRegistrar =
        _prefixId.prefix "MassachusettsBusinessRegistrar"

    let MassachusettsBusinessRegistrationIdentifierScheme =
        _prefixId.prefix "MassachusettsBusinessRegistrationIdentifierScheme"

    let MassachusettsBusinessRegistrationService =
        _prefixId.prefix "MassachusettsBusinessRegistrationService"

    let MassachusettsCorporationRegistry =
        _prefixId.prefix "MassachusettsCorporationRegistry"

    let MassachusettsCorporationsDivision =
        _prefixId.prefix "MassachusettsCorporationsDivision"

    let MassachusettsRegistrationAuthorityCode =
        _prefixId.prefix "MassachusettsRegistrationAuthorityCode"

    /// <summary>
    ///   <para>rdfs:label : National Information Center (NIC) registry entry^^xsd:string</para>
    ///   <para>skos:definition : an entry in the the National Information Center (NIC) repository, a repository of financial data and institution characteristics collected by the Federal Reserve System^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.ffiec.gov/nicpubweb/nicweb/NicHome.aspx^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/NICRegistryEntry">fibo-fbc-fct-usjrga:NICRegistryEntry</a>
    /// </summary>
    let NICRegistryEntry = _prefixId.prefix "NICRegistryEntry"
    let NationalBankingRegulator = _prefixId.prefix "NationalBankingRegulator"

    let NationalCreditUnionAdministration =
        _prefixId.prefix "NationalCreditUnionAdministration"

    let NationalCreditUnionInsurerAndRegulator =
        _prefixId.prefix "NationalCreditUnionInsurerAndRegulator"

    let NationalInformationCenterRepository =
        _prefixId.prefix "NationalInformationCenterRepository"

    let NewYorkBusinessEntitiesRegistry =
        _prefixId.prefix "NewYorkBusinessEntitiesRegistry"

    let NewYorkBusinessRegistrationIdentifierScheme =
        _prefixId.prefix "NewYorkBusinessRegistrationIdentifierScheme"

    let NewYorkBusinessRegistrationService =
        _prefixId.prefix "NewYorkBusinessRegistrationService"

    let NewYorkCorporationsRegulator = _prefixId.prefix "NewYorkCorporationsRegulator"
    let NewYorkDivisionOfCorporations = _prefixId.prefix "NewYorkDivisionOfCorporations"

    let NewYorkRegistrationAuthorityCode =
        _prefixId.prefix "NewYorkRegistrationAuthorityCode"

    /// <summary>
    ///   <para>rdfs:label : non-depository trust company - member institution^^xsd:string</para>
    ///   <para>skos:definition : non-depository trust company that is a member of the Federal Reserve system^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/NonDepositoryTrustCompany-MemberInstitution">fibo-fbc-fct-usjrga:NonDepositoryTrustCompany-MemberInstitution</a>
    /// </summary>
    let NonDepositoryTrustCompany_MemberInstitution =
        _prefixId.prefix "NonDepositoryTrustCompany-MemberInstitution"

    /// <summary>
    ///   <para>rdfs:label : non-depository trust company - non-member institution^^xsd:string</para>
    ///   <para>skos:definition : non-depository trust company that is not a member of the Federal Reserve system^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.ffiec.gov/npw/Help/InstitutionTypes^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/NonDepositoryTrustCompany-NonMemberInstitution">fibo-fbc-fct-usjrga:NonDepositoryTrustCompany-NonMemberInstitution</a>
    /// </summary>
    let NonDepositoryTrustCompany_NonMemberInstitution =
        _prefixId.prefix "NonDepositoryTrustCompany-NonMemberInstitution"

    let OfficeOfTheComptrollerOfTheCurrency =
        _prefixId.prefix "OfficeOfTheComptrollerOfTheCurrency"

    let OfficeOfThriftSupervision = _prefixId.prefix "OfficeOfThriftSupervision"
    let OhioBusinessFilingPortal = _prefixId.prefix "OhioBusinessFilingPortal"
    let OhioBusinessRegistrar = _prefixId.prefix "OhioBusinessRegistrar"

    let OhioBusinessRegistrationIdentifierScheme =
        _prefixId.prefix "OhioBusinessRegistrationIdentifierScheme"

    let OhioBusinessRegistrationService =
        _prefixId.prefix "OhioBusinessRegistrationService"

    let OhioBusinessServicesDivision = _prefixId.prefix "OhioBusinessServicesDivision"
    let OhioRegistrationAuthorityCode = _prefixId.prefix "OhioRegistrationAuthorityCode"
    /// <summary>
    ///   <para>rdfs:label : primary federal regulator^^xsd:string</para>
    ///   <para>skos:definition : federal regulatory agency that is designated as the main agency responsible for oversight of a given institution for an institution^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.ffiec.gov/nicpubweb/nicweb/NicHome.aspx^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/PrimaryFederalRegulator">fibo-fbc-fct-usjrga:PrimaryFederalRegulator</a>
    /// </summary>
    let PrimaryFederalRegulator = _prefixId.prefix "PrimaryFederalRegulator"

    /// <summary>
    ///   <para>rdfs:label : Research, Statistics, Supervision and Regulation, and Discount and Credit identifier^^xsd:string</para>
    ///   <para>skos:definition : unique identifier assigned by the Federal Reserve to financial institutions for regulatory and oversight purposes^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : RSSD ID^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://cdr.ffiec.gov/CDR/Public/CDRHelp/FAQs1205.htm#FAQ16^^xsd:anyURI</para>
    ///   <para>cmns-av:synonym : ID_RSSD^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/ResearchStatisticsSupervisionDiscountIdentifier">fibo-fbc-fct-usjrga:ResearchStatisticsSupervisionDiscountIdentifier</a>
    /// </summary>
    let ResearchStatisticsSupervisionDiscountIdentifier =
        _prefixId.prefix "ResearchStatisticsSupervisionDiscountIdentifier"

    /// <summary>
    ///   <para>rdfs:label : routing transit number^^xsd:string</para>
    ///   <para>skos:definition : unique nine digit identifier, used primarily in the United States, to identify a banking or other financial institution for clearing funds, and, as it appears on a check, denotes the banking institution that holds the account from which funds are to be drawn^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : RTN^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Routing transit numbers are issued by Accuity on behalf of the American Bankers Association (ABA).^^xsd:stringcmns-av:explanatoryNote : The ABA RTN was originally designed to facilitate the sorting, bundling, and shipment of paper checks back to the drawer's (check writer's) account. As new payment methods were developed (ACH and Wire), the system was expanded to accommodate these payment methods.
    ///
    /// The ABA RTN is necessary for the Federal Reserve Banks to process Fedwire funds transfers, and by the Automated Clearing House to process direct deposits, bill payments, and other such automated transfers.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/RoutingTransitNumber">fibo-fbc-fct-usjrga:RoutingTransitNumber</a>
    /// </summary>
    let RoutingTransitNumber = _prefixId.prefix "RoutingTransitNumber"

    let SecuritiesAndExchangeCommission =
        _prefixId.prefix "SecuritiesAndExchangeCommission"

    let SecuritiesAndExchangeRegulator =
        _prefixId.prefix "SecuritiesAndExchangeRegulator"

    let SouthDakotaBusinessInformationRegistry =
        _prefixId.prefix "SouthDakotaBusinessInformationRegistry"

    let SouthDakotaBusinessRegistrationIdentifierScheme =
        _prefixId.prefix "SouthDakotaBusinessRegistrationIdentifierScheme"

    let SouthDakotaBusinessRegistrationService =
        _prefixId.prefix "SouthDakotaBusinessRegistrationService"

    let SouthDakotaCorporationsDivision =
        _prefixId.prefix "SouthDakotaCorporationsDivision"

    let SouthDakotaCorporationsRegulator =
        _prefixId.prefix "SouthDakotaCorporationsRegulator"

    let SouthDakotaRegistrationAuthorityCode =
        _prefixId.prefix "SouthDakotaRegistrationAuthorityCode"

    /// <summary>
    ///   <para>rdfs:label : state government entity or agency^^xsd:string</para>
    ///   <para>skos:definition : formal organization that is an independent agency, instrumentality or other permanent or semi-permanent organization in the machinery of government of any one of the states or territories of the United States^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/StateGovernmentEntity">fibo-fbc-fct-usjrga:StateGovernmentEntity</a>
    /// </summary>
    let StateGovernmentEntity = _prefixId.prefix "StateGovernmentEntity"
    /// <summary>
    ///   <para>rdfs:label : state member bank^^xsd:string</para>
    ///   <para>skos:definition : state-chartered bank that is a member of the Federal Reserve System (FRS)^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : http://www.ffiec.gov/nicpubweb/Content/HELP/Institution%20Type%20Description.htm^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/StateMemberBank">fibo-fbc-fct-usjrga:StateMemberBank</a>
    /// </summary>
    let StateMemberBank = _prefixId.prefix "StateMemberBank"
    /// <summary>
    ///   <para>rdfs:label : taxpayer identification number^^xsd:string</para>
    ///   <para>skos:definition : identification number used by the Internal Revenue Service (IRS) in the administration of tax laws in the United States^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : TIN^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.irs.gov/individuals/international-taxpayers/taxpayer-identification-numbers-tin^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : A TIN must be furnished on returns, statements, and other tax related documents. For example a number must be furnished:
    /// - When filing tax returns.
    /// - When claiming treaty benefits.
    ///
    /// A TIN must be on a withholding certificate if the beneficial owner is claiming any of the following:
    /// - Tax treaty benefits (other than for income from marketable securities)
    /// - Exemption for effectively connected income
    /// - Exemption for certain annuities.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/TaxpayerIdentificationNumber">fibo-fbc-fct-usjrga:TaxpayerIdentificationNumber</a>
    /// </summary>
    let TaxpayerIdentificationNumber = _prefixId.prefix "TaxpayerIdentificationNumber"

    /// <summary>
    ///   <para>rdfs:label : taxpayer identification numbering scheme^^xsd:string</para>
    ///   <para>skos:definition : tax identification scheme used in the United States^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.irs.gov/individuals/international-taxpayers/taxpayer-identification-numbers-tin^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/TaxpayerIdentificationNumberingScheme">fibo-fbc-fct-usjrga:TaxpayerIdentificationNumberingScheme</a>
    /// </summary>
    let TaxpayerIdentificationNumberingScheme =
        _prefixId.prefix "TaxpayerIdentificationNumberingScheme"

    let ThriftRegulator = _prefixId.prefix "ThriftRegulator"
    let USDepartmentOfTheTreasury = _prefixId.prefix "USDepartmentOfTheTreasury"

    let UniformBankPerformanceReportRepository =
        _prefixId.prefix "UniformBankPerformanceReportRepository"

    /// <summary>
    ///   <para>rdfs:label : has primary federal regulator^^xsd:string</para>
    ///   <para>skos:definition : identifies the primary federal regulator for an institution^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/hasPrimaryFederalRegulator">fibo-fbc-fct-usjrga:hasPrimaryFederalRegulator</a>
    /// </summary>
    let hasPrimaryFederalRegulator = _prefixId.prefix "hasPrimaryFederalRegulator"
    /// <summary>
    ///   <para>rdfs:label : has secondary federal regulator^^xsd:string</para>
    ///   <para>skos:definition : identifies an additional federal regulator, over and above the primary federal regulator, for an institution^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/hasSecondaryFederalRegulator">fibo-fbc-fct-usjrga:hasSecondaryFederalRegulator</a>
    /// </summary>
    let hasSecondaryFederalRegulator = _prefixId.prefix "hasSecondaryFederalRegulator"
