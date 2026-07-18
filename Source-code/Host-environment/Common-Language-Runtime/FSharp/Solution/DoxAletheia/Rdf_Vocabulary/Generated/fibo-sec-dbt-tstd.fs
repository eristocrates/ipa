namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Debt.TradedShortTermDebt.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_sec_dbt_tstd =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/BankersAcceptance"></see>
    /// </summary>
    let BankersAcceptance =
        Namespaced_IRI.parse _namespace_name "BankersAcceptance" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/BillOfExchange"></see>
    /// </summary>
    let BillOfExchange =
        Namespaced_IRI.parse _namespace_name "BillOfExchange" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/MoneyMarketInstrument"></see>
    /// </summary>
    let MoneyMarketInstrument =
        Namespaced_IRI.parse _namespace_name "MoneyMarketInstrument" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/Drawee"></see>
    /// </summary>
    let Drawee = Namespaced_IRI.parse _namespace_name "Drawee" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/Drawer"></see>
    /// </summary>
    let Drawer = Namespaced_IRI.parse _namespace_name "Drawer" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/CommercialPaper"></see>
    /// </summary>
    let CommercialPaper =
        Namespaced_IRI.parse _namespace_name "CommercialPaper" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/EurodollarDeposit"></see>
    /// </summary>
    let EurodollarDeposit =
        Namespaced_IRI.parse _namespace_name "EurodollarDeposit" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/RepurchaseAgreement"></see>
    /// </summary>
    let RepurchaseAgreement =
        Namespaced_IRI.parse _namespace_name "RepurchaseAgreement" |> NamespacedName
