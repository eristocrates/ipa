namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Securities.ParametricSchedules.slash

open DoxAletheia

module fibo_sec_sec_sch =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/AuctionDateRule"></see>
    /// </summary>
    let AuctionDateRule = _prefix "AuctionDateRule"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/DateReturnedBySettlementDateRule"></see>
    /// </summary>
    let DateReturnedBySettlementDateRule = _prefix "DateReturnedBySettlementDateRule"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/SettlementDateRule"></see>
    /// </summary>
    let SettlementDateRule = _prefix "SettlementDateRule"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/DateReturnedByTradingDateRule"></see>
    /// </summary>
    let DateReturnedByTradingDateRule = _prefix "DateReturnedByTradingDateRule"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/TradingDateRule"></see>
    /// </summary>
    let TradingDateRule = _prefix "TradingDateRule"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/FloatingRateNoteDate"></see>
    /// </summary>
    let FloatingRateNoteDate = _prefix "FloatingRateNoteDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/FloatingRateNoteDateRule"></see>
    /// </summary>
    let FloatingRateNoteDateRule = _prefix "FloatingRateNoteDateRule"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/InternationalMoneyMarketAustralianDollarTradingDateRule"></see>
    /// </summary>
    let InternationalMoneyMarketAustralianDollarTradingDateRule =
        _prefix "InternationalMoneyMarketAustralianDollarTradingDateRule"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/InternationalMoneyMarketCanadianDollarTradingDateRule"></see>
    /// </summary>
    let InternationalMoneyMarketCanadianDollarTradingDateRule =
        _prefix "InternationalMoneyMarketCanadianDollarTradingDateRule"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/InternationalMoneyMarketNewZealandDollarTradingDateRule"></see>
    /// </summary>
    let InternationalMoneyMarketNewZealandDollarTradingDateRule =
        _prefix "InternationalMoneyMarketNewZealandDollarTradingDateRule"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/InternationalMoneyMarketSettlementDateRule"></see>
    /// </summary>
    let InternationalMoneyMarketSettlementDateRule =
        _prefix "InternationalMoneyMarketSettlementDateRule"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/ScheduledCalculationPeriodEndEvent"></see>
    /// </summary>
    let ScheduledCalculationPeriodEndEvent =
        _prefix "ScheduledCalculationPeriodEndEvent"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/ScheduledCalculationPeriodStartEvent"></see>
    /// </summary>
    let ScheduledCalculationPeriodStartEvent =
        _prefix "ScheduledCalculationPeriodStartEvent"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/USTreasuryBillAuctionDateRule"></see>
    /// </summary>
    let USTreasuryBillAuctionDateRule = _prefix "USTreasuryBillAuctionDateRule"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/USTreasuryBillDate"></see>
    /// </summary>
    let USTreasuryBillDate = _prefix "USTreasuryBillDate"
