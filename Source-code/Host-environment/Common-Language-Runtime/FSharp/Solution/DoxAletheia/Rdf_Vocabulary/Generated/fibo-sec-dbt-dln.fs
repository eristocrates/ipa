namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Debt.DistributedLoans.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_sec_dbt_dln =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/AdministrativeAgent"></see>
    /// </summary>
    let AdministrativeAgent =
        Namespaced_IRI.parse _namespace_name "AdministrativeAgent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/Bookrunner"></see>
    /// </summary>
    let Bookrunner = Namespaced_IRI.parse _namespace_name "Bookrunner" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/DocumentationAgent"></see>
    /// </summary>
    let DocumentationAgent =
        Namespaced_IRI.parse _namespace_name "DocumentationAgent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/FinanceSyndicate"></see>
    /// </summary>
    let FinanceSyndicate =
        Namespaced_IRI.parse _namespace_name "FinanceSyndicate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/FinanceSyndicateMember"></see>
    /// </summary>
    let FinanceSyndicateMember =
        Namespaced_IRI.parse _namespace_name "FinanceSyndicateMember" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/LeadArranger"></see>
    /// </summary>
    let LeadArranger =
        Namespaced_IRI.parse _namespace_name "LeadArranger" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/LoanParticipationNote"></see>
    /// </summary>
    let LoanParticipationNote =
        Namespaced_IRI.parse _namespace_name "LoanParticipationNote" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/SyndicatedLoan"></see>
    /// </summary>
    let SyndicatedLoan =
        Namespaced_IRI.parse _namespace_name "SyndicatedLoan" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/SyndicationAgent"></see>
    /// </summary>
    let SyndicationAgent =
        Namespaced_IRI.parse _namespace_name "SyndicationAgent" |> NamespacedName
