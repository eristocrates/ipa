namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Securities.SecuritiesRestrictions.slash

open DoxAletheia

module fibo_sec_sec_rst =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/hasRestriction"></see>
    /// </summary>
    let hasRestriction = _prefix "hasRestriction"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/SecuritiesRestriction"></see>
    /// </summary>
    let SecuritiesRestriction = _prefix "SecuritiesRestriction"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/ContractualRestriction"></see>
    /// </summary>
    let ContractualRestriction = _prefix "ContractualRestriction"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/IndividualInvestor"></see>
    /// </summary>
    let IndividualInvestor = _prefix "IndividualInvestor"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/InstitutionalInvestor"></see>
    /// </summary>
    let InstitutionalInvestor = _prefix "InstitutionalInvestor"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/InvestorsDomicileRestriction"></see>
    /// </summary>
    let InvestorsDomicileRestriction = _prefix "InvestorsDomicileRestriction"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/LegalHoldingRestriction"></see>
    /// </summary>
    let LegalHoldingRestriction = _prefix "LegalHoldingRestriction"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/QualifiedInvestorRestriction"></see>
    /// </summary>
    let QualifiedInvestorRestriction = _prefix "QualifiedInvestorRestriction"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/hasHoldingPeriod"></see>
    /// </summary>
    let hasHoldingPeriod = _prefix "hasHoldingPeriod"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/SecuritiesRegulation"></see>
    /// </summary>
    let SecuritiesRegulation = _prefix "SecuritiesRegulation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/TradingRestriction"></see>
    /// </summary>
    let TradingRestriction = _prefix "TradingRestriction"
