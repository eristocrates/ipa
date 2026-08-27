namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Debt.TradedShortTermDebt.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_sec_dbt_tstd =
    let _namespace_iri = Namespace_Iri fibo_sec_dbt_tstd |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-sec-dbt-tstd:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Traded Short-Term Debt Ontology"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_sec_dbt_tstd, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-tstd:BankersAcceptance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bankers' acceptance"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/BankersAcceptance">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/BankersAcceptance</seealso>
    let BankersAcceptance =
        Prefixed_Name(fibo_sec_dbt_tstd, "BankersAcceptance") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-tstd:BillOfExchange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bill of exchange"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/BillOfExchange">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/BillOfExchange</seealso>
    let BillOfExchange =
        Prefixed_Name(fibo_sec_dbt_tstd, "BillOfExchange") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-tstd:CommercialPaper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"commercial paper"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/CommercialPaper">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/CommercialPaper</seealso>
    let CommercialPaper =
        Prefixed_Name(fibo_sec_dbt_tstd, "CommercialPaper") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-tstd:Drawee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"drawee"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/Drawee">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/Drawee</seealso>
    let Drawee = Prefixed_Name(fibo_sec_dbt_tstd, "Drawee") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-dbt-tstd:Drawer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"drawer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/Drawer">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/Drawer</seealso>
    let Drawer = Prefixed_Name(fibo_sec_dbt_tstd, "Drawer") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-tstd:EurodollarDeposit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"eurodollar deposit"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/EurodollarDeposit">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/EurodollarDeposit</seealso>
    let EurodollarDeposit =
        Prefixed_Name(fibo_sec_dbt_tstd, "EurodollarDeposit") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-tstd:MoneyMarketInstrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"money market instrument"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/MoneyMarketInstrument">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/MoneyMarketInstrument</seealso>
    let MoneyMarketInstrument =
        Prefixed_Name(fibo_sec_dbt_tstd, "MoneyMarketInstrument") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-tstd:RepurchaseAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"repurchase agreement"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/RepurchaseAgreement">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/RepurchaseAgreement</seealso>
    let RepurchaseAgreement =
        Prefixed_Name(fibo_sec_dbt_tstd, "RepurchaseAgreement") |> PrefixedName
