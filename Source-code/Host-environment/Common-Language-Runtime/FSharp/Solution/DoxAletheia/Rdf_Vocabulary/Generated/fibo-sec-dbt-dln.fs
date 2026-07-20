namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Debt.DistributedLoans.slash

open DoxAletheia

module fibo_sec_dbt_dln =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/AdministrativeAgent"></see>
    /// </summary>
    let AdministrativeAgent = _prefix "AdministrativeAgent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/Bookrunner"></see>
    /// </summary>
    let Bookrunner = _prefix "Bookrunner"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/DocumentationAgent"></see>
    /// </summary>
    let DocumentationAgent = _prefix "DocumentationAgent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/FinanceSyndicate"></see>
    /// </summary>
    let FinanceSyndicate = _prefix "FinanceSyndicate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/FinanceSyndicateMember"></see>
    /// </summary>
    let FinanceSyndicateMember = _prefix "FinanceSyndicateMember"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/LeadArranger"></see>
    /// </summary>
    let LeadArranger = _prefix "LeadArranger"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/LoanParticipationNote"></see>
    /// </summary>
    let LoanParticipationNote = _prefix "LoanParticipationNote"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/SyndicatedLoan"></see>
    /// </summary>
    let SyndicatedLoan = _prefix "SyndicatedLoan"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/SyndicationAgent"></see>
    /// </summary>
    let SyndicationAgent = _prefix "SyndicationAgent"
