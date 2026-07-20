namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Debt.TradedShortTermDebt.slash

open DoxAletheia

module fibo_sec_dbt_tstd =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/BankersAcceptance"></see>
    /// </summary>
    let BankersAcceptance = _prefix "BankersAcceptance"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/BillOfExchange"></see>
    /// </summary>
    let BillOfExchange = _prefix "BillOfExchange"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/MoneyMarketInstrument"></see>
    /// </summary>
    let MoneyMarketInstrument = _prefix "MoneyMarketInstrument"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/Drawee"></see>
    /// </summary>
    let Drawee = _prefix "Drawee"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/Drawer"></see>
    /// </summary>
    let Drawer = _prefix "Drawer"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/CommercialPaper"></see>
    /// </summary>
    let CommercialPaper = _prefix "CommercialPaper"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/EurodollarDeposit"></see>
    /// </summary>
    let EurodollarDeposit = _prefix "EurodollarDeposit"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/RepurchaseAgreement"></see>
    /// </summary>
    let RepurchaseAgreement = _prefix "RepurchaseAgreement"
