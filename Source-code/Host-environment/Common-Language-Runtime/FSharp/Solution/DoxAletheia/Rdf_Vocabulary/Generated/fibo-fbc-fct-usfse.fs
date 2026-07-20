namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FunctionalEntities.NorthAmericanEntities.USFinancialServicesEntities.slash

open DoxAletheia

module fibo_fbc_fct_usfse =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/AgencyOfAForeignBankingOrganization"></see>
    /// </summary>
    let AgencyOfAForeignBankingOrganization =
        _prefix "AgencyOfAForeignBankingOrganization"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/ForeignBank"></see>
    /// </summary>
    let ForeignBank = _prefix "ForeignBank"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/OfficeOfAForeignBank"></see>
    /// </summary>
    let OfficeOfAForeignBank = _prefix "OfficeOfAForeignBank"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/AgreementCorporation"></see>
    /// </summary>
    let AgreementCorporation = _prefix "AgreementCorporation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/AgreementCorporation-Banking"></see>
    /// </summary>
    let ``AgreementCorporation-Banking`` = _prefix "AgreementCorporation-Banking"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/AgreementCorporation-Investment"></see>
    /// </summary>
    let ``AgreementCorporation-Investment`` = _prefix "AgreementCorporation-Investment"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/BankersBank"></see>
    /// </summary>
    let BankersBank = _prefix "BankersBank"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/USBank"></see>
    /// </summary>
    let USBank = _prefix "USBank"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/isSubjectToReserveRequirements"></see>
    /// </summary>
    let isSubjectToReserveRequirements = _prefix "isSubjectToReserveRequirements"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/BankersBankNotSubjectToReserveRequirements"></see>
    /// </summary>
    let BankersBankNotSubjectToReserveRequirements =
        _prefix "BankersBankNotSubjectToReserveRequirements"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/BankersBankSubjectToReserveRequirements"></see>
    /// </summary>
    let BankersBankSubjectToReserveRequirements =
        _prefix "BankersBankSubjectToReserveRequirements"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/BranchOfADepositoryInstitution"></see>
    /// </summary>
    let BranchOfADepositoryInstitution = _prefix "BranchOfADepositoryInstitution"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/CommercialLendingCompany"></see>
    /// </summary>
    let CommercialLendingCompany = _prefix "CommercialLendingCompany"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/CooperativeBank"></see>
    /// </summary>
    let CooperativeBank = _prefix "CooperativeBank"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/ThriftInstitution"></see>
    /// </summary>
    let ThriftInstitution = _prefix "ThriftInstitution"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/DomesticBranchOfAForeignBank"></see>
    /// </summary>
    let DomesticBranchOfAForeignBank = _prefix "DomesticBranchOfAForeignBank"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/DomesticBranchOfDomesticBank"></see>
    /// </summary>
    let DomesticBranchOfDomesticBank = _prefix "DomesticBranchOfDomesticBank"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/DomesticEntity"></see>
    /// </summary>
    let DomesticEntity = _prefix "DomesticEntity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/DomesticEntityOther"></see>
    /// </summary>
    let DomesticEntityOther = _prefix "DomesticEntityOther"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/DomesticNonBankSubsidiaryOfADomesticEntity"></see>
    /// </summary>
    let DomesticNonBankSubsidiaryOfADomesticEntity =
        _prefix "DomesticNonBankSubsidiaryOfADomesticEntity"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/NonBankSubsidiaryOfADomesticEntity"></see>
    /// </summary>
    let NonBankSubsidiaryOfADomesticEntity =
        _prefix "NonBankSubsidiaryOfADomesticEntity"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/EdgeCorporation"></see>
    /// </summary>
    let EdgeCorporation = _prefix "EdgeCorporation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/EdgeCorporation-Banking"></see>
    /// </summary>
    let ``EdgeCorporation-Banking`` = _prefix "EdgeCorporation-Banking"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/EdgeCorporation-DomesticBranch"></see>
    /// </summary>
    let ``EdgeCorporation-DomesticBranch`` = _prefix "EdgeCorporation-DomesticBranch"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/EdgeCorporation-Investment"></see>
    /// </summary>
    let ``EdgeCorporation-Investment`` = _prefix "EdgeCorporation-Investment"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/FarmCreditSystemInstitution"></see>
    /// </summary>
    let FarmCreditSystemInstitution = _prefix "FarmCreditSystemInstitution"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/FederalAgencyOfForeignBankingOrganization"></see>
    /// </summary>
    let FederalAgencyOfForeignBankingOrganization =
        _prefix "FederalAgencyOfForeignBankingOrganization"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/FederalBranchOfForeignBankingOrganization"></see>
    /// </summary>
    let FederalBranchOfForeignBankingOrganization =
        _prefix "FederalBranchOfForeignBankingOrganization"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/FederalCreditUnion"></see>
    /// </summary>
    let FederalCreditUnion = _prefix "FederalCreditUnion"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/USCreditUnion"></see>
    /// </summary>
    let USCreditUnion = _prefix "USCreditUnion"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/FederalSavingsBank"></see>
    /// </summary>
    let FederalSavingsBank = _prefix "FederalSavingsBank"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/SavingsBank"></see>
    /// </summary>
    let SavingsBank = _prefix "SavingsBank"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/FinancialHoldingCompany"></see>
    /// </summary>
    let FinancialHoldingCompany = _prefix "FinancialHoldingCompany"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/hasHomeCountrySupervisor"></see>
    /// </summary>
    let hasHomeCountrySupervisor = _prefix "hasHomeCountrySupervisor"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/hasHomeCountry"></see>
    /// </summary>
    let hasHomeCountry = _prefix "hasHomeCountry"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/ForeignBankingOrganization"></see>
    /// </summary>
    let ForeignBankingOrganization = _prefix "ForeignBankingOrganization"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/ForeignBankingOrganizationAsABankHoldingCompany"></see>
    /// </summary>
    let ForeignBankingOrganizationAsABankHoldingCompany =
        _prefix "ForeignBankingOrganizationAsABankHoldingCompany"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/ForeignBankingOrganizationOfABankHoldingCompany"></see>
    /// </summary>
    let ForeignBankingOrganizationOfABankHoldingCompany =
        _prefix "ForeignBankingOrganizationOfABankHoldingCompany"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/ForeignBranchOfForeignBank"></see>
    /// </summary>
    let ForeignBranchOfForeignBank = _prefix "ForeignBranchOfForeignBank"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/ForeignBranchOfUSBank"></see>
    /// </summary>
    let ForeignBranchOfUSBank = _prefix "ForeignBranchOfUSBank"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/ForeignBranchOfForeignBankManagedByUSOffice"></see>
    /// </summary>
    let ForeignBranchOfForeignBankManagedByUSOffice =
        _prefix "ForeignBranchOfForeignBankManagedByUSOffice"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/ForeignEntityOther"></see>
    /// </summary>
    let ForeignEntityOther = _prefix "ForeignEntityOther"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/IndustrialBank"></see>
    /// </summary>
    let IndustrialBank = _prefix "IndustrialBank"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/InsuredFederalBranchOfForeignBankingOrganization"></see>
    /// </summary>
    let InsuredFederalBranchOfForeignBankingOrganization =
        _prefix "InsuredFederalBranchOfForeignBankingOrganization"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/InsuredStateBranchOfForeignBankingOrganization"></see>
    /// </summary>
    let InsuredStateBranchOfForeignBankingOrganization =
        _prefix "InsuredStateBranchOfForeignBankingOrganization"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/StateBranchOfForeignBankingOrganization"></see>
    /// </summary>
    let StateBranchOfForeignBankingOrganization =
        _prefix "StateBranchOfForeignBankingOrganization"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/IntermediateHoldingCompany"></see>
    /// </summary>
    let IntermediateHoldingCompany = _prefix "IntermediateHoldingCompany"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/InternationalBankOfUSDepositoryEdgeTrustCompany"></see>
    /// </summary>
    let InternationalBankOfUSDepositoryEdgeTrustCompany =
        _prefix "InternationalBankOfUSDepositoryEdgeTrustCompany"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/InternationalNonBankSubsidiaryOfADomesticEntity"></see>
    /// </summary>
    let InternationalNonBankSubsidiaryOfADomesticEntity =
        _prefix "InternationalNonBankSubsidiaryOfADomesticEntity"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/LimitedBranchOfAForeignBank"></see>
    /// </summary>
    let LimitedBranchOfAForeignBank = _prefix "LimitedBranchOfAForeignBank"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/MutualSavingsBank"></see>
    /// </summary>
    let MutualSavingsBank = _prefix "MutualSavingsBank"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/NationalBank"></see>
    /// </summary>
    let NationalBank = _prefix "NationalBank"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/NewYorkArticleXIIInvestmentCompany"></see>
    /// </summary>
    let NewYorkArticleXIIInvestmentCompany =
        _prefix "NewYorkArticleXIIInvestmentCompany"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/SubsidiaryOfADomesticEntity"></see>
    /// </summary>
    let SubsidiaryOfADomesticEntity = _prefix "SubsidiaryOfADomesticEntity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/NonDepositoryTrustCompany"></see>
    /// </summary>
    let NonDepositoryTrustCompany = _prefix "NonDepositoryTrustCompany"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/RegionalAdministrativeOfficeOfAForeignBank"></see>
    /// </summary>
    let RegionalAdministrativeOfficeOfAForeignBank =
        _prefix "RegionalAdministrativeOfficeOfAForeignBank"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/RepresentativeOfficeOfAForeignBank"></see>
    /// </summary>
    let RepresentativeOfficeOfAForeignBank =
        _prefix "RepresentativeOfficeOfAForeignBank"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/SavingsLoanAssociation"></see>
    /// </summary>
    let SavingsLoanAssociation = _prefix "SavingsLoanAssociation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/SavingsLoanHoldingCompany"></see>
    /// </summary>
    let SavingsLoanHoldingCompany = _prefix "SavingsLoanHoldingCompany"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/StateAgencyOfForeignBankingOrganization"></see>
    /// </summary>
    let StateAgencyOfForeignBankingOrganization =
        _prefix "StateAgencyOfForeignBankingOrganization"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/StateCharteredBank"></see>
    /// </summary>
    let StateCharteredBank = _prefix "StateCharteredBank"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/StateCreditUnion"></see>
    /// </summary>
    let StateCreditUnion = _prefix "StateCreditUnion"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/StateSavingsBank"></see>
    /// </summary>
    let StateSavingsBank = _prefix "StateSavingsBank"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/USBankHoldingCompany"></see>
    /// </summary>
    let USBankHoldingCompany = _prefix "USBankHoldingCompany"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/UninsuredFederalAgencyOfForeignBankingOrganization"></see>
    /// </summary>
    let UninsuredFederalAgencyOfForeignBankingOrganization =
        _prefix "UninsuredFederalAgencyOfForeignBankingOrganization"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/UninsuredFederalBranchOfForeignBankingOrganization"></see>
    /// </summary>
    let UninsuredFederalBranchOfForeignBankingOrganization =
        _prefix "UninsuredFederalBranchOfForeignBankingOrganization"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/UninsuredStateAgencyOfForeignBankingOrganization"></see>
    /// </summary>
    let UninsuredStateAgencyOfForeignBankingOrganization =
        _prefix "UninsuredStateAgencyOfForeignBankingOrganization"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/UninsuredStateBranchOfForeignBankingOrganization"></see>
    /// </summary>
    let UninsuredStateBranchOfForeignBankingOrganization =
        _prefix "UninsuredStateBranchOfForeignBankingOrganization"
