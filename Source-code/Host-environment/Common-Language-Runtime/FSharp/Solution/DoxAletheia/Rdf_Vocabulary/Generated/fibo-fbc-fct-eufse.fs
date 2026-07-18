namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FunctionalEntities.EuropeanEntities.EUFinancialServicesEntities.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fbc_fct_eufse =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/CRDCreditInstitution"></see>
    /// </summary>
    let CRDCreditInstitution =
        Namespaced_IRI.parse _namespace_name "CRDCreditInstitution" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/CreditInstitution"></see>
    /// </summary>
    let CreditInstitution =
        Namespaced_IRI.parse _namespace_name "CreditInstitution" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/EuropeanEconomicAreaBranch"></see>
    /// </summary>
    let EuropeanEconomicAreaBranch =
        Namespaced_IRI.parse _namespace_name "EuropeanEconomicAreaBranch" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/NonEuropeanEconomicAreaBranch"></see>
    /// </summary>
    let NonEuropeanEconomicAreaBranch =
        Namespaced_IRI.parse _namespace_name "NonEuropeanEconomicAreaBranch" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/CreditInstitutionInvestmentFirm"></see>
    /// </summary>
    let CreditInstitutionInvestmentFirm =
        Namespaced_IRI.parse _namespace_name "CreditInstitutionInvestmentFirm" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/InvestmentFirm"></see>
    /// </summary>
    let InvestmentFirm =
        Namespaced_IRI.parse _namespace_name "InvestmentFirm" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/LocalFirm"></see>
    /// </summary>
    let LocalFirm = Namespaced_IRI.parse _namespace_name "LocalFirm" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/PaymentInstitution"></see>
    /// </summary>
    let PaymentInstitution =
        Namespaced_IRI.parse _namespace_name "PaymentInstitution" |> NamespacedName
