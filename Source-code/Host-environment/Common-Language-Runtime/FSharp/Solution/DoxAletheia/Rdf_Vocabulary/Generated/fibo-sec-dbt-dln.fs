namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Debt.DistributedLoans.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_sec_dbt_dln =
    let _namespace_iri = Namespace_Iri fibo_sec_dbt_dln |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-sec-dbt-dln:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Distributed Loans Ontology"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_sec_dbt_dln, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dln:AdministrativeAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"administrative agent"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/AdministrativeAgent">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/AdministrativeAgent</seealso>
    let AdministrativeAgent =
        Prefixed_Name(fibo_sec_dbt_dln, "AdministrativeAgent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dln:Bookrunner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bookrunner"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/Bookrunner">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/Bookrunner</seealso>
    let Bookrunner = Prefixed_Name(fibo_sec_dbt_dln, "Bookrunner") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dln:DocumentationAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"documentation agent"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/DocumentationAgent">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/DocumentationAgent</seealso>
    let DocumentationAgent =
        Prefixed_Name(fibo_sec_dbt_dln, "DocumentationAgent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dln:FinanceSyndicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"finance syndicate"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/FinanceSyndicate">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/FinanceSyndicate</seealso>
    let FinanceSyndicate =
        Prefixed_Name(fibo_sec_dbt_dln, "FinanceSyndicate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dln:FinanceSyndicateMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"finance syndicate member"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/FinanceSyndicateMember">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/FinanceSyndicateMember</seealso>
    let FinanceSyndicateMember =
        Prefixed_Name(fibo_sec_dbt_dln, "FinanceSyndicateMember") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dln:LeadArranger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"lead arranger"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/LeadArranger">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/LeadArranger</seealso>
    let LeadArranger = Prefixed_Name(fibo_sec_dbt_dln, "LeadArranger") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dln:LoanParticipationNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"loan participation note"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/LoanParticipationNote">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/LoanParticipationNote</seealso>
    let LoanParticipationNote =
        Prefixed_Name(fibo_sec_dbt_dln, "LoanParticipationNote") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dln:SyndicatedLoan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"syndicated loan"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/SyndicatedLoan">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/SyndicatedLoan</seealso>
    let SyndicatedLoan =
        Prefixed_Name(fibo_sec_dbt_dln, "SyndicatedLoan") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-dln:SyndicationAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"syndication agent"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/SyndicationAgent">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/SyndicationAgent</seealso>
    let SyndicationAgent =
        Prefixed_Name(fibo_sec_dbt_dln, "SyndicationAgent") |> PrefixedName
