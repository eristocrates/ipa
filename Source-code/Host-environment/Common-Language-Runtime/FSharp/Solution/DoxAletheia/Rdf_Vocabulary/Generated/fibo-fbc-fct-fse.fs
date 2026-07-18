namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FunctionalEntities.FinancialServicesEntities.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fbc_fct_fse =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/Bank"></see>
    /// </summary>
    let Bank = Namespaced_IRI.parse _namespace_name "Bank" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/DepositoryInstitution"></see>
    /// </summary>
    let DepositoryInstitution =
        Namespaced_IRI.parse _namespace_name "DepositoryInstitution" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BankHoldingCompany"></see>
    /// </summary>
    let BankHoldingCompany =
        Namespaced_IRI.parse _namespace_name "BankHoldingCompany" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/HoldingCompany"></see>
    /// </summary>
    let HoldingCompany =
        Namespaced_IRI.parse _namespace_name "HoldingCompany" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BankingProduct"></see>
    /// </summary>
    let BankingProduct =
        Namespaced_IRI.parse _namespace_name "BankingProduct" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BankingService"></see>
    /// </summary>
    let BankingService =
        Namespaced_IRI.parse _namespace_name "BankingService" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BrokerageFirm"></see>
    /// </summary>
    let BrokerageFirm =
        Namespaced_IRI.parse _namespace_name "BrokerageFirm" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/NonDepositoryInstitution"></see>
    /// </summary>
    let NonDepositoryInstitution =
        Namespaced_IRI.parse _namespace_name "NonDepositoryInstitution" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BusinessIdentifierCode"></see>
    /// </summary>
    let BusinessIdentifierCode =
        Namespaced_IRI.parse _namespace_name "BusinessIdentifierCode" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BusinessPartyPrefix"></see>
    /// </summary>
    let BusinessPartyPrefix =
        Namespaced_IRI.parse _namespace_name "BusinessPartyPrefix" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BusinessPartySuffix"></see>
    /// </summary>
    let BusinessPartySuffix =
        Namespaced_IRI.parse _namespace_name "BusinessPartySuffix" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BusinessIdentifierCodeScheme"></see>
    /// </summary>
    let BusinessIdentifierCodeScheme =
        Namespaced_IRI.parse _namespace_name "BusinessIdentifierCodeScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/CentralBank"></see>
    /// </summary>
    let CentralBank =
        Namespaced_IRI.parse _namespace_name "CentralBank" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/MonetaryAuthority"></see>
    /// </summary>
    let MonetaryAuthority =
        Namespaced_IRI.parse _namespace_name "MonetaryAuthority" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/CentralCounterpartyClearingHouse"></see>
    /// </summary>
    let CentralCounterpartyClearingHouse =
        Namespaced_IRI.parse _namespace_name "CentralCounterpartyClearingHouse" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ClearingHouse"></see>
    /// </summary>
    let ClearingHouse =
        Namespaced_IRI.parse _namespace_name "ClearingHouse" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/CentralSecuritiesDepository"></see>
    /// </summary>
    let CentralSecuritiesDepository =
        Namespaced_IRI.parse _namespace_name "CentralSecuritiesDepository" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ClearingBank"></see>
    /// </summary>
    let ClearingBank =
        Namespaced_IRI.parse _namespace_name "ClearingBank" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/CommercialBank"></see>
    /// </summary>
    let CommercialBank =
        Namespaced_IRI.parse _namespace_name "CommercialBank" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ClearingCorporation"></see>
    /// </summary>
    let ClearingCorporation =
        Namespaced_IRI.parse _namespace_name "ClearingCorporation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ClearingService"></see>
    /// </summary>
    let ClearingService =
        Namespaced_IRI.parse _namespace_name "ClearingService" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/CommercialFinanceCompany"></see>
    /// </summary>
    let CommercialFinanceCompany =
        Namespaced_IRI.parse _namespace_name "CommercialFinanceCompany" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/FinanceCompany"></see>
    /// </summary>
    let FinanceCompany =
        Namespaced_IRI.parse _namespace_name "FinanceCompany" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/CommodityTradingAdvisor"></see>
    /// </summary>
    let CommodityTradingAdvisor =
        Namespaced_IRI.parse _namespace_name "CommodityTradingAdvisor" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ConsumerFinanceCompany"></see>
    /// </summary>
    let ConsumerFinanceCompany =
        Namespaced_IRI.parse _namespace_name "ConsumerFinanceCompany" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ContractualSavingsInstitution"></see>
    /// </summary>
    let ContractualSavingsInstitution =
        Namespaced_IRI.parse _namespace_name "ContractualSavingsInstitution" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/CreditUnion"></see>
    /// </summary>
    let CreditUnion =
        Namespaced_IRI.parse _namespace_name "CreditUnion" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/DataProcessingService"></see>
    /// </summary>
    let DataProcessingService =
        Namespaced_IRI.parse _namespace_name "DataProcessingService" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/DataProcessingServicer"></see>
    /// </summary>
    let DataProcessingServicer =
        Namespaced_IRI.parse _namespace_name "DataProcessingServicer" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/FinancialInstitution"></see>
    /// </summary>
    let FinancialInstitution =
        Namespaced_IRI.parse _namespace_name "FinancialInstitution" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/DevelopmentBank"></see>
    /// </summary>
    let DevelopmentBank =
        Namespaced_IRI.parse _namespace_name "DevelopmentBank" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ElectronicFundsTransferService"></see>
    /// </summary>
    let ElectronicFundsTransferService =
        Namespaced_IRI.parse _namespace_name "ElectronicFundsTransferService" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/FaceAmountCertificateCompany"></see>
    /// </summary>
    let FaceAmountCertificateCompany =
        Namespaced_IRI.parse _namespace_name "FaceAmountCertificateCompany" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/InvestmentCompany"></see>
    /// </summary>
    let InvestmentCompany =
        Namespaced_IRI.parse _namespace_name "InvestmentCompany" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ManagementCompany"></see>
    /// </summary>
    let ManagementCompany =
        Namespaced_IRI.parse _namespace_name "ManagementCompany" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/FinancialServiceProviderIdentifier"></see>
    /// </summary>
    let FinancialServiceProviderIdentifier =
        Namespaced_IRI.parse _namespace_name "FinancialServiceProviderIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/FinancialServiceProviderIdentifierScheme"></see>
    /// </summary>
    let FinancialServiceProviderIdentifierScheme =
        Namespaced_IRI.parse _namespace_name "FinancialServiceProviderIdentifierScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/FuturesCommissionMerchant"></see>
    /// </summary>
    let FuturesCommissionMerchant =
        Namespaced_IRI.parse _namespace_name "FuturesCommissionMerchant" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/hasPortfolioCompany"></see>
    /// </summary>
    let hasPortfolioCompany =
        Namespaced_IRI.parse _namespace_name "hasPortfolioCompany" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/InsuranceCompany"></see>
    /// </summary>
    let InsuranceCompany =
        Namespaced_IRI.parse _namespace_name "InsuranceCompany" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/RiskPoolingInstitution"></see>
    /// </summary>
    let RiskPoolingInstitution =
        Namespaced_IRI.parse _namespace_name "RiskPoolingInstitution" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/InsuranceService"></see>
    /// </summary>
    let InsuranceService =
        Namespaced_IRI.parse _namespace_name "InsuranceService" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/InvestmentBank"></see>
    /// </summary>
    let InvestmentBank =
        Namespaced_IRI.parse _namespace_name "InvestmentBank" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/InvestmentService"></see>
    /// </summary>
    let InvestmentService =
        Namespaced_IRI.parse _namespace_name "InvestmentService" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/UnitInvestmentTrust"></see>
    /// </summary>
    let UnitInvestmentTrust =
        Namespaced_IRI.parse _namespace_name "UnitInvestmentTrust" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/MerchantService"></see>
    /// </summary>
    let MerchantService =
        Namespaced_IRI.parse _namespace_name "MerchantService" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/regulatesSupplyOf"></see>
    /// </summary>
    let regulatesSupplyOf =
        Namespaced_IRI.parse _namespace_name "regulatesSupplyOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/MoneyServicesBusiness"></see>
    /// </summary>
    let MoneyServicesBusiness =
        Namespaced_IRI.parse _namespace_name "MoneyServicesBusiness" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/MortgageCompany"></see>
    /// </summary>
    let MortgageCompany =
        Namespaced_IRI.parse _namespace_name "MortgageCompany" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/PaymentService"></see>
    /// </summary>
    let PaymentService =
        Namespaced_IRI.parse _namespace_name "PaymentService" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/PayrollService"></see>
    /// </summary>
    let PayrollService =
        Namespaced_IRI.parse _namespace_name "PayrollService" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/PrincipalUnderwriter"></see>
    /// </summary>
    let PrincipalUnderwriter =
        Namespaced_IRI.parse _namespace_name "PrincipalUnderwriter" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/Underwriter"></see>
    /// </summary>
    let Underwriter =
        Namespaced_IRI.parse _namespace_name "Underwriter" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/RegisteredInvestmentAdvisor"></see>
    /// </summary>
    let RegisteredInvestmentAdvisor =
        Namespaced_IRI.parse _namespace_name "RegisteredInvestmentAdvisor" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/SalesFinanceCompany"></see>
    /// </summary>
    let SalesFinanceCompany =
        Namespaced_IRI.parse _namespace_name "SalesFinanceCompany" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/SavingsAssociation"></see>
    /// </summary>
    let SavingsAssociation =
        Namespaced_IRI.parse _namespace_name "SavingsAssociation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/SelfRegulatingOrganization"></see>
    /// </summary>
    let SelfRegulatingOrganization =
        Namespaced_IRI.parse _namespace_name "SelfRegulatingOrganization" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/TrustCompany"></see>
    /// </summary>
    let TrustCompany =
        Namespaced_IRI.parse _namespace_name "TrustCompany" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/UnderwritingArrangement"></see>
    /// </summary>
    let UnderwritingArrangement =
        Namespaced_IRI.parse _namespace_name "UnderwritingArrangement" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/WealthManagementService"></see>
    /// </summary>
    let WealthManagementService =
        Namespaced_IRI.parse _namespace_name "WealthManagementService" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/hasDateEstablished"></see>
    /// </summary>
    let hasDateEstablished =
        Namespaced_IRI.parse _namespace_name "hasDateEstablished" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/hasDateEstablishmentTerminated"></see>
    /// </summary>
    let hasDateEstablishmentTerminated =
        Namespaced_IRI.parse _namespace_name "hasDateEstablishmentTerminated" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/hasDateInsured"></see>
    /// </summary>
    let hasDateInsured =
        Namespaced_IRI.parse _namespace_name "hasDateInsured" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/isPortfolioCompanyOf"></see>
    /// </summary>
    let isPortfolioCompanyOf =
        Namespaced_IRI.parse _namespace_name "isPortfolioCompanyOf" |> NamespacedName
