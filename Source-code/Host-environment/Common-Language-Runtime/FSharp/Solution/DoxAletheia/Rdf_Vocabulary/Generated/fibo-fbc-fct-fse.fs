namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FunctionalEntities.FinancialServicesEntities.slash

open DoxAletheia

module fibo_fbc_fct_fse =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/Bank"></see>
    /// </summary>
    let Bank = _prefix "Bank"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/DepositoryInstitution"></see>
    /// </summary>
    let DepositoryInstitution = _prefix "DepositoryInstitution"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BankHoldingCompany"></see>
    /// </summary>
    let BankHoldingCompany = _prefix "BankHoldingCompany"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/HoldingCompany"></see>
    /// </summary>
    let HoldingCompany = _prefix "HoldingCompany"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BankingProduct"></see>
    /// </summary>
    let BankingProduct = _prefix "BankingProduct"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BankingService"></see>
    /// </summary>
    let BankingService = _prefix "BankingService"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BrokerageFirm"></see>
    /// </summary>
    let BrokerageFirm = _prefix "BrokerageFirm"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/NonDepositoryInstitution"></see>
    /// </summary>
    let NonDepositoryInstitution = _prefix "NonDepositoryInstitution"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BusinessIdentifierCode"></see>
    /// </summary>
    let BusinessIdentifierCode = _prefix "BusinessIdentifierCode"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BusinessPartyPrefix"></see>
    /// </summary>
    let BusinessPartyPrefix = _prefix "BusinessPartyPrefix"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BusinessPartySuffix"></see>
    /// </summary>
    let BusinessPartySuffix = _prefix "BusinessPartySuffix"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/BusinessIdentifierCodeScheme"></see>
    /// </summary>
    let BusinessIdentifierCodeScheme = _prefix "BusinessIdentifierCodeScheme"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/CentralBank"></see>
    /// </summary>
    let CentralBank = _prefix "CentralBank"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/MonetaryAuthority"></see>
    /// </summary>
    let MonetaryAuthority = _prefix "MonetaryAuthority"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/CentralCounterpartyClearingHouse"></see>
    /// </summary>
    let CentralCounterpartyClearingHouse = _prefix "CentralCounterpartyClearingHouse"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ClearingHouse"></see>
    /// </summary>
    let ClearingHouse = _prefix "ClearingHouse"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/CentralSecuritiesDepository"></see>
    /// </summary>
    let CentralSecuritiesDepository = _prefix "CentralSecuritiesDepository"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ClearingBank"></see>
    /// </summary>
    let ClearingBank = _prefix "ClearingBank"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/CommercialBank"></see>
    /// </summary>
    let CommercialBank = _prefix "CommercialBank"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ClearingCorporation"></see>
    /// </summary>
    let ClearingCorporation = _prefix "ClearingCorporation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ClearingService"></see>
    /// </summary>
    let ClearingService = _prefix "ClearingService"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/CommercialFinanceCompany"></see>
    /// </summary>
    let CommercialFinanceCompany = _prefix "CommercialFinanceCompany"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/FinanceCompany"></see>
    /// </summary>
    let FinanceCompany = _prefix "FinanceCompany"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/CommodityTradingAdvisor"></see>
    /// </summary>
    let CommodityTradingAdvisor = _prefix "CommodityTradingAdvisor"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ConsumerFinanceCompany"></see>
    /// </summary>
    let ConsumerFinanceCompany = _prefix "ConsumerFinanceCompany"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ContractualSavingsInstitution"></see>
    /// </summary>
    let ContractualSavingsInstitution = _prefix "ContractualSavingsInstitution"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/CreditUnion"></see>
    /// </summary>
    let CreditUnion = _prefix "CreditUnion"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/DataProcessingService"></see>
    /// </summary>
    let DataProcessingService = _prefix "DataProcessingService"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/DataProcessingServicer"></see>
    /// </summary>
    let DataProcessingServicer = _prefix "DataProcessingServicer"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/FinancialInstitution"></see>
    /// </summary>
    let FinancialInstitution = _prefix "FinancialInstitution"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/DevelopmentBank"></see>
    /// </summary>
    let DevelopmentBank = _prefix "DevelopmentBank"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ElectronicFundsTransferService"></see>
    /// </summary>
    let ElectronicFundsTransferService = _prefix "ElectronicFundsTransferService"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/FaceAmountCertificateCompany"></see>
    /// </summary>
    let FaceAmountCertificateCompany = _prefix "FaceAmountCertificateCompany"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/InvestmentCompany"></see>
    /// </summary>
    let InvestmentCompany = _prefix "InvestmentCompany"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/ManagementCompany"></see>
    /// </summary>
    let ManagementCompany = _prefix "ManagementCompany"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/FinancialServiceProviderIdentifier"></see>
    /// </summary>
    let FinancialServiceProviderIdentifier =
        _prefix "FinancialServiceProviderIdentifier"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/FinancialServiceProviderIdentifierScheme"></see>
    /// </summary>
    let FinancialServiceProviderIdentifierScheme =
        _prefix "FinancialServiceProviderIdentifierScheme"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/FuturesCommissionMerchant"></see>
    /// </summary>
    let FuturesCommissionMerchant = _prefix "FuturesCommissionMerchant"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/hasPortfolioCompany"></see>
    /// </summary>
    let hasPortfolioCompany = _prefix "hasPortfolioCompany"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/InsuranceCompany"></see>
    /// </summary>
    let InsuranceCompany = _prefix "InsuranceCompany"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/RiskPoolingInstitution"></see>
    /// </summary>
    let RiskPoolingInstitution = _prefix "RiskPoolingInstitution"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/InsuranceService"></see>
    /// </summary>
    let InsuranceService = _prefix "InsuranceService"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/InvestmentBank"></see>
    /// </summary>
    let InvestmentBank = _prefix "InvestmentBank"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/InvestmentService"></see>
    /// </summary>
    let InvestmentService = _prefix "InvestmentService"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/UnitInvestmentTrust"></see>
    /// </summary>
    let UnitInvestmentTrust = _prefix "UnitInvestmentTrust"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/MerchantService"></see>
    /// </summary>
    let MerchantService = _prefix "MerchantService"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/regulatesSupplyOf"></see>
    /// </summary>
    let regulatesSupplyOf = _prefix "regulatesSupplyOf"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/MoneyServicesBusiness"></see>
    /// </summary>
    let MoneyServicesBusiness = _prefix "MoneyServicesBusiness"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/MortgageCompany"></see>
    /// </summary>
    let MortgageCompany = _prefix "MortgageCompany"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/PaymentService"></see>
    /// </summary>
    let PaymentService = _prefix "PaymentService"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/PayrollService"></see>
    /// </summary>
    let PayrollService = _prefix "PayrollService"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/PrincipalUnderwriter"></see>
    /// </summary>
    let PrincipalUnderwriter = _prefix "PrincipalUnderwriter"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/Underwriter"></see>
    /// </summary>
    let Underwriter = _prefix "Underwriter"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/RegisteredInvestmentAdvisor"></see>
    /// </summary>
    let RegisteredInvestmentAdvisor = _prefix "RegisteredInvestmentAdvisor"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/SalesFinanceCompany"></see>
    /// </summary>
    let SalesFinanceCompany = _prefix "SalesFinanceCompany"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/SavingsAssociation"></see>
    /// </summary>
    let SavingsAssociation = _prefix "SavingsAssociation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/SelfRegulatingOrganization"></see>
    /// </summary>
    let SelfRegulatingOrganization = _prefix "SelfRegulatingOrganization"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/TrustCompany"></see>
    /// </summary>
    let TrustCompany = _prefix "TrustCompany"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/UnderwritingArrangement"></see>
    /// </summary>
    let UnderwritingArrangement = _prefix "UnderwritingArrangement"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/WealthManagementService"></see>
    /// </summary>
    let WealthManagementService = _prefix "WealthManagementService"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/hasDateEstablished"></see>
    /// </summary>
    let hasDateEstablished = _prefix "hasDateEstablished"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/hasDateEstablishmentTerminated"></see>
    /// </summary>
    let hasDateEstablishmentTerminated = _prefix "hasDateEstablishmentTerminated"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/hasDateInsured"></see>
    /// </summary>
    let hasDateInsured = _prefix "hasDateInsured"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/isPortfolioCompanyOf"></see>
    /// </summary>
    let isPortfolioCompanyOf = _prefix "isPortfolioCompanyOf"
