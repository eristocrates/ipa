namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FunctionalEntities.NorthAmericanEntities.USFinancialServicesEntities.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fbc_fct_usfse =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/AgencyOfAForeignBankingOrganization"></see>
    /// </summary>
    let AgencyOfAForeignBankingOrganization =
        Namespaced_IRI.parse _namespace_name "AgencyOfAForeignBankingOrganization" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/ForeignBank"></see>
    /// </summary>
    let ForeignBank =
        Namespaced_IRI.parse _namespace_name "ForeignBank" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/OfficeOfAForeignBank"></see>
    /// </summary>
    let OfficeOfAForeignBank =
        Namespaced_IRI.parse _namespace_name "OfficeOfAForeignBank" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/AgreementCorporation"></see>
    /// </summary>
    let AgreementCorporation =
        Namespaced_IRI.parse _namespace_name "AgreementCorporation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/AgreementCorporation-Banking"></see>
    /// </summary>
    let ``AgreementCorporation-Banking`` =
        Namespaced_IRI.parse _namespace_name "AgreementCorporation-Banking" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/AgreementCorporation-Investment"></see>
    /// </summary>
    let ``AgreementCorporation-Investment`` =
        Namespaced_IRI.parse _namespace_name "AgreementCorporation-Investment" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/BankersBank"></see>
    /// </summary>
    let BankersBank =
        Namespaced_IRI.parse _namespace_name "BankersBank" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/USBank"></see>
    /// </summary>
    let USBank = Namespaced_IRI.parse _namespace_name "USBank" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/isSubjectToReserveRequirements"></see>
    /// </summary>
    let isSubjectToReserveRequirements =
        Namespaced_IRI.parse _namespace_name "isSubjectToReserveRequirements" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/BankersBankNotSubjectToReserveRequirements"></see>
    /// </summary>
    let BankersBankNotSubjectToReserveRequirements =
        Namespaced_IRI.parse _namespace_name "BankersBankNotSubjectToReserveRequirements" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/BankersBankSubjectToReserveRequirements"></see>
    /// </summary>
    let BankersBankSubjectToReserveRequirements =
        Namespaced_IRI.parse _namespace_name "BankersBankSubjectToReserveRequirements" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/BranchOfADepositoryInstitution"></see>
    /// </summary>
    let BranchOfADepositoryInstitution =
        Namespaced_IRI.parse _namespace_name "BranchOfADepositoryInstitution" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/CommercialLendingCompany"></see>
    /// </summary>
    let CommercialLendingCompany =
        Namespaced_IRI.parse _namespace_name "CommercialLendingCompany" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/CooperativeBank"></see>
    /// </summary>
    let CooperativeBank =
        Namespaced_IRI.parse _namespace_name "CooperativeBank" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/ThriftInstitution"></see>
    /// </summary>
    let ThriftInstitution =
        Namespaced_IRI.parse _namespace_name "ThriftInstitution" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/DomesticBranchOfAForeignBank"></see>
    /// </summary>
    let DomesticBranchOfAForeignBank =
        Namespaced_IRI.parse _namespace_name "DomesticBranchOfAForeignBank" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/DomesticBranchOfDomesticBank"></see>
    /// </summary>
    let DomesticBranchOfDomesticBank =
        Namespaced_IRI.parse _namespace_name "DomesticBranchOfDomesticBank" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/DomesticEntity"></see>
    /// </summary>
    let DomesticEntity =
        Namespaced_IRI.parse _namespace_name "DomesticEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/DomesticEntityOther"></see>
    /// </summary>
    let DomesticEntityOther =
        Namespaced_IRI.parse _namespace_name "DomesticEntityOther" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/DomesticNonBankSubsidiaryOfADomesticEntity"></see>
    /// </summary>
    let DomesticNonBankSubsidiaryOfADomesticEntity =
        Namespaced_IRI.parse _namespace_name "DomesticNonBankSubsidiaryOfADomesticEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/NonBankSubsidiaryOfADomesticEntity"></see>
    /// </summary>
    let NonBankSubsidiaryOfADomesticEntity =
        Namespaced_IRI.parse _namespace_name "NonBankSubsidiaryOfADomesticEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/EdgeCorporation"></see>
    /// </summary>
    let EdgeCorporation =
        Namespaced_IRI.parse _namespace_name "EdgeCorporation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/EdgeCorporation-Banking"></see>
    /// </summary>
    let ``EdgeCorporation-Banking`` =
        Namespaced_IRI.parse _namespace_name "EdgeCorporation-Banking" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/EdgeCorporation-DomesticBranch"></see>
    /// </summary>
    let ``EdgeCorporation-DomesticBranch`` =
        Namespaced_IRI.parse _namespace_name "EdgeCorporation-DomesticBranch" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/EdgeCorporation-Investment"></see>
    /// </summary>
    let ``EdgeCorporation-Investment`` =
        Namespaced_IRI.parse _namespace_name "EdgeCorporation-Investment" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/FarmCreditSystemInstitution"></see>
    /// </summary>
    let FarmCreditSystemInstitution =
        Namespaced_IRI.parse _namespace_name "FarmCreditSystemInstitution" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/FederalAgencyOfForeignBankingOrganization"></see>
    /// </summary>
    let FederalAgencyOfForeignBankingOrganization =
        Namespaced_IRI.parse _namespace_name "FederalAgencyOfForeignBankingOrganization" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/FederalBranchOfForeignBankingOrganization"></see>
    /// </summary>
    let FederalBranchOfForeignBankingOrganization =
        Namespaced_IRI.parse _namespace_name "FederalBranchOfForeignBankingOrganization" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/FederalCreditUnion"></see>
    /// </summary>
    let FederalCreditUnion =
        Namespaced_IRI.parse _namespace_name "FederalCreditUnion" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/USCreditUnion"></see>
    /// </summary>
    let USCreditUnion =
        Namespaced_IRI.parse _namespace_name "USCreditUnion" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/FederalSavingsBank"></see>
    /// </summary>
    let FederalSavingsBank =
        Namespaced_IRI.parse _namespace_name "FederalSavingsBank" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/SavingsBank"></see>
    /// </summary>
    let SavingsBank =
        Namespaced_IRI.parse _namespace_name "SavingsBank" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/FinancialHoldingCompany"></see>
    /// </summary>
    let FinancialHoldingCompany =
        Namespaced_IRI.parse _namespace_name "FinancialHoldingCompany" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/hasHomeCountrySupervisor"></see>
    /// </summary>
    let hasHomeCountrySupervisor =
        Namespaced_IRI.parse _namespace_name "hasHomeCountrySupervisor" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/hasHomeCountry"></see>
    /// </summary>
    let hasHomeCountry =
        Namespaced_IRI.parse _namespace_name "hasHomeCountry" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/ForeignBankingOrganization"></see>
    /// </summary>
    let ForeignBankingOrganization =
        Namespaced_IRI.parse _namespace_name "ForeignBankingOrganization" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/ForeignBankingOrganizationAsABankHoldingCompany"></see>
    /// </summary>
    let ForeignBankingOrganizationAsABankHoldingCompany =
        Namespaced_IRI.parse _namespace_name "ForeignBankingOrganizationAsABankHoldingCompany" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/ForeignBankingOrganizationOfABankHoldingCompany"></see>
    /// </summary>
    let ForeignBankingOrganizationOfABankHoldingCompany =
        Namespaced_IRI.parse _namespace_name "ForeignBankingOrganizationOfABankHoldingCompany" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/ForeignBranchOfForeignBank"></see>
    /// </summary>
    let ForeignBranchOfForeignBank =
        Namespaced_IRI.parse _namespace_name "ForeignBranchOfForeignBank" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/ForeignBranchOfUSBank"></see>
    /// </summary>
    let ForeignBranchOfUSBank =
        Namespaced_IRI.parse _namespace_name "ForeignBranchOfUSBank" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/ForeignBranchOfForeignBankManagedByUSOffice"></see>
    /// </summary>
    let ForeignBranchOfForeignBankManagedByUSOffice =
        Namespaced_IRI.parse _namespace_name "ForeignBranchOfForeignBankManagedByUSOffice" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/ForeignEntityOther"></see>
    /// </summary>
    let ForeignEntityOther =
        Namespaced_IRI.parse _namespace_name "ForeignEntityOther" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/IndustrialBank"></see>
    /// </summary>
    let IndustrialBank =
        Namespaced_IRI.parse _namespace_name "IndustrialBank" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/InsuredFederalBranchOfForeignBankingOrganization"></see>
    /// </summary>
    let InsuredFederalBranchOfForeignBankingOrganization =
        Namespaced_IRI.parse _namespace_name "InsuredFederalBranchOfForeignBankingOrganization" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/InsuredStateBranchOfForeignBankingOrganization"></see>
    /// </summary>
    let InsuredStateBranchOfForeignBankingOrganization =
        Namespaced_IRI.parse _namespace_name "InsuredStateBranchOfForeignBankingOrganization" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/StateBranchOfForeignBankingOrganization"></see>
    /// </summary>
    let StateBranchOfForeignBankingOrganization =
        Namespaced_IRI.parse _namespace_name "StateBranchOfForeignBankingOrganization" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/IntermediateHoldingCompany"></see>
    /// </summary>
    let IntermediateHoldingCompany =
        Namespaced_IRI.parse _namespace_name "IntermediateHoldingCompany" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/InternationalBankOfUSDepositoryEdgeTrustCompany"></see>
    /// </summary>
    let InternationalBankOfUSDepositoryEdgeTrustCompany =
        Namespaced_IRI.parse _namespace_name "InternationalBankOfUSDepositoryEdgeTrustCompany" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/InternationalNonBankSubsidiaryOfADomesticEntity"></see>
    /// </summary>
    let InternationalNonBankSubsidiaryOfADomesticEntity =
        Namespaced_IRI.parse _namespace_name "InternationalNonBankSubsidiaryOfADomesticEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/LimitedBranchOfAForeignBank"></see>
    /// </summary>
    let LimitedBranchOfAForeignBank =
        Namespaced_IRI.parse _namespace_name "LimitedBranchOfAForeignBank" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/MutualSavingsBank"></see>
    /// </summary>
    let MutualSavingsBank =
        Namespaced_IRI.parse _namespace_name "MutualSavingsBank" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/NationalBank"></see>
    /// </summary>
    let NationalBank =
        Namespaced_IRI.parse _namespace_name "NationalBank" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/NewYorkArticleXIIInvestmentCompany"></see>
    /// </summary>
    let NewYorkArticleXIIInvestmentCompany =
        Namespaced_IRI.parse _namespace_name "NewYorkArticleXIIInvestmentCompany" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/SubsidiaryOfADomesticEntity"></see>
    /// </summary>
    let SubsidiaryOfADomesticEntity =
        Namespaced_IRI.parse _namespace_name "SubsidiaryOfADomesticEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/NonDepositoryTrustCompany"></see>
    /// </summary>
    let NonDepositoryTrustCompany =
        Namespaced_IRI.parse _namespace_name "NonDepositoryTrustCompany" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/RegionalAdministrativeOfficeOfAForeignBank"></see>
    /// </summary>
    let RegionalAdministrativeOfficeOfAForeignBank =
        Namespaced_IRI.parse _namespace_name "RegionalAdministrativeOfficeOfAForeignBank" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/RepresentativeOfficeOfAForeignBank"></see>
    /// </summary>
    let RepresentativeOfficeOfAForeignBank =
        Namespaced_IRI.parse _namespace_name "RepresentativeOfficeOfAForeignBank" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/SavingsLoanAssociation"></see>
    /// </summary>
    let SavingsLoanAssociation =
        Namespaced_IRI.parse _namespace_name "SavingsLoanAssociation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/SavingsLoanHoldingCompany"></see>
    /// </summary>
    let SavingsLoanHoldingCompany =
        Namespaced_IRI.parse _namespace_name "SavingsLoanHoldingCompany" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/StateAgencyOfForeignBankingOrganization"></see>
    /// </summary>
    let StateAgencyOfForeignBankingOrganization =
        Namespaced_IRI.parse _namespace_name "StateAgencyOfForeignBankingOrganization" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/StateCharteredBank"></see>
    /// </summary>
    let StateCharteredBank =
        Namespaced_IRI.parse _namespace_name "StateCharteredBank" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/StateCreditUnion"></see>
    /// </summary>
    let StateCreditUnion =
        Namespaced_IRI.parse _namespace_name "StateCreditUnion" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/StateSavingsBank"></see>
    /// </summary>
    let StateSavingsBank =
        Namespaced_IRI.parse _namespace_name "StateSavingsBank" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/USBankHoldingCompany"></see>
    /// </summary>
    let USBankHoldingCompany =
        Namespaced_IRI.parse _namespace_name "USBankHoldingCompany" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/UninsuredFederalAgencyOfForeignBankingOrganization"></see>
    /// </summary>
    let UninsuredFederalAgencyOfForeignBankingOrganization =
        Namespaced_IRI.parse _namespace_name "UninsuredFederalAgencyOfForeignBankingOrganization" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/UninsuredFederalBranchOfForeignBankingOrganization"></see>
    /// </summary>
    let UninsuredFederalBranchOfForeignBankingOrganization =
        Namespaced_IRI.parse _namespace_name "UninsuredFederalBranchOfForeignBankingOrganization" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/UninsuredStateAgencyOfForeignBankingOrganization"></see>
    /// </summary>
    let UninsuredStateAgencyOfForeignBankingOrganization =
        Namespaced_IRI.parse _namespace_name "UninsuredStateAgencyOfForeignBankingOrganization" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/UninsuredStateBranchOfForeignBankingOrganization"></see>
    /// </summary>
    let UninsuredStateBranchOfForeignBankingOrganization =
        Namespaced_IRI.parse _namespace_name "UninsuredStateBranchOfForeignBankingOrganization" |> NamespacedName
