namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FunctionalEntities.EuropeanEntities.EUFinancialServicesEntities.slash

open DoxAletheia

module fibo_fbc_fct_eufse =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/CRDCreditInstitution"></see>
    /// </summary>
    let CRDCreditInstitution = _prefix "CRDCreditInstitution"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/CreditInstitution"></see>
    /// </summary>
    let CreditInstitution = _prefix "CreditInstitution"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/EuropeanEconomicAreaBranch"></see>
    /// </summary>
    let EuropeanEconomicAreaBranch = _prefix "EuropeanEconomicAreaBranch"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/NonEuropeanEconomicAreaBranch"></see>
    /// </summary>
    let NonEuropeanEconomicAreaBranch = _prefix "NonEuropeanEconomicAreaBranch"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/CreditInstitutionInvestmentFirm"></see>
    /// </summary>
    let CreditInstitutionInvestmentFirm = _prefix "CreditInstitutionInvestmentFirm"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/InvestmentFirm"></see>
    /// </summary>
    let InvestmentFirm = _prefix "InvestmentFirm"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/LocalFirm"></see>
    /// </summary>
    let LocalFirm = _prefix "LocalFirm"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/PaymentInstitution"></see>
    /// </summary>
    let PaymentInstitution = _prefix "PaymentInstitution"
