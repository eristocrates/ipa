namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Securities.SecuritiesRestrictions.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_sec_sec_rst =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/hasRestriction"></see>
    /// </summary>
    let hasRestriction =
        Namespaced_IRI.parse _namespace_name "hasRestriction" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/SecuritiesRestriction"></see>
    /// </summary>
    let SecuritiesRestriction =
        Namespaced_IRI.parse _namespace_name "SecuritiesRestriction" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/ContractualRestriction"></see>
    /// </summary>
    let ContractualRestriction =
        Namespaced_IRI.parse _namespace_name "ContractualRestriction" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/IndividualInvestor"></see>
    /// </summary>
    let IndividualInvestor =
        Namespaced_IRI.parse _namespace_name "IndividualInvestor" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/InstitutionalInvestor"></see>
    /// </summary>
    let InstitutionalInvestor =
        Namespaced_IRI.parse _namespace_name "InstitutionalInvestor" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/InvestorsDomicileRestriction"></see>
    /// </summary>
    let InvestorsDomicileRestriction =
        Namespaced_IRI.parse _namespace_name "InvestorsDomicileRestriction" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/LegalHoldingRestriction"></see>
    /// </summary>
    let LegalHoldingRestriction =
        Namespaced_IRI.parse _namespace_name "LegalHoldingRestriction" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/QualifiedInvestorRestriction"></see>
    /// </summary>
    let QualifiedInvestorRestriction =
        Namespaced_IRI.parse _namespace_name "QualifiedInvestorRestriction" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/hasHoldingPeriod"></see>
    /// </summary>
    let hasHoldingPeriod =
        Namespaced_IRI.parse _namespace_name "hasHoldingPeriod" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/SecuritiesRegulation"></see>
    /// </summary>
    let SecuritiesRegulation =
        Namespaced_IRI.parse _namespace_name "SecuritiesRegulation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/TradingRestriction"></see>
    /// </summary>
    let TradingRestriction =
        Namespaced_IRI.parse _namespace_name "TradingRestriction" |> NamespacedName
