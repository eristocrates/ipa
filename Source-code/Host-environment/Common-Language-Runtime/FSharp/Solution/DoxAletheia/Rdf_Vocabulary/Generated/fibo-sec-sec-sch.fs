namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Securities.ParametricSchedules.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_sec_sec_sch =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/AuctionDateRule"></see>
    /// </summary>
    let AuctionDateRule =
        Namespaced_IRI.parse _namespace_name "AuctionDateRule" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/DateReturnedBySettlementDateRule"></see>
    /// </summary>
    let DateReturnedBySettlementDateRule =
        Namespaced_IRI.parse _namespace_name "DateReturnedBySettlementDateRule" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/SettlementDateRule"></see>
    /// </summary>
    let SettlementDateRule =
        Namespaced_IRI.parse _namespace_name "SettlementDateRule" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/DateReturnedByTradingDateRule"></see>
    /// </summary>
    let DateReturnedByTradingDateRule =
        Namespaced_IRI.parse _namespace_name "DateReturnedByTradingDateRule" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/TradingDateRule"></see>
    /// </summary>
    let TradingDateRule =
        Namespaced_IRI.parse _namespace_name "TradingDateRule" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/FloatingRateNoteDate"></see>
    /// </summary>
    let FloatingRateNoteDate =
        Namespaced_IRI.parse _namespace_name "FloatingRateNoteDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/FloatingRateNoteDateRule"></see>
    /// </summary>
    let FloatingRateNoteDateRule =
        Namespaced_IRI.parse _namespace_name "FloatingRateNoteDateRule" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/InternationalMoneyMarketAustralianDollarTradingDateRule"></see>
    /// </summary>
    let InternationalMoneyMarketAustralianDollarTradingDateRule =
        Namespaced_IRI.parse _namespace_name "InternationalMoneyMarketAustralianDollarTradingDateRule" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/InternationalMoneyMarketCanadianDollarTradingDateRule"></see>
    /// </summary>
    let InternationalMoneyMarketCanadianDollarTradingDateRule =
        Namespaced_IRI.parse _namespace_name "InternationalMoneyMarketCanadianDollarTradingDateRule" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/InternationalMoneyMarketNewZealandDollarTradingDateRule"></see>
    /// </summary>
    let InternationalMoneyMarketNewZealandDollarTradingDateRule =
        Namespaced_IRI.parse _namespace_name "InternationalMoneyMarketNewZealandDollarTradingDateRule" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/InternationalMoneyMarketSettlementDateRule"></see>
    /// </summary>
    let InternationalMoneyMarketSettlementDateRule =
        Namespaced_IRI.parse _namespace_name "InternationalMoneyMarketSettlementDateRule" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/ScheduledCalculationPeriodEndEvent"></see>
    /// </summary>
    let ScheduledCalculationPeriodEndEvent =
        Namespaced_IRI.parse _namespace_name "ScheduledCalculationPeriodEndEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/ScheduledCalculationPeriodStartEvent"></see>
    /// </summary>
    let ScheduledCalculationPeriodStartEvent =
        Namespaced_IRI.parse _namespace_name "ScheduledCalculationPeriodStartEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/USTreasuryBillAuctionDateRule"></see>
    /// </summary>
    let USTreasuryBillAuctionDateRule =
        Namespaced_IRI.parse _namespace_name "USTreasuryBillAuctionDateRule" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/USTreasuryBillDate"></see>
    /// </summary>
    let USTreasuryBillDate =
        Namespaced_IRI.parse _namespace_name "USTreasuryBillDate" |> NamespacedName
