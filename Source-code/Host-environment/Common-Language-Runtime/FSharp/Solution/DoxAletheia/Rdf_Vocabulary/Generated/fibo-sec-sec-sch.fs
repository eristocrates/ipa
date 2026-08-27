namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Securities.ParametricSchedules.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_sec_sec_sch =
    let _namespace_iri = Namespace_Iri fibo_sec_sec_sch |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-sec-sec-sch:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Parametric Schedules Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_sec_sec_sch, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-sch:AuctionDateRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"auction date rule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/AuctionDateRule">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/AuctionDateRule</seealso>
    let AuctionDateRule =
        Prefixed_Name(fibo_sec_sec_sch, "AuctionDateRule") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-sch:DateReturnedBySettlementDateRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"date returned by settlement date rule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/DateReturnedBySettlementDateRule">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/DateReturnedBySettlementDateRule</seealso>
    let DateReturnedBySettlementDateRule =
        Prefixed_Name(fibo_sec_sec_sch, "DateReturnedBySettlementDateRule") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-sch:DateReturnedByTradingDateRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"date returned by trading date rule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/DateReturnedByTradingDateRule">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/DateReturnedByTradingDateRule</seealso>
    let DateReturnedByTradingDateRule =
        Prefixed_Name(fibo_sec_sec_sch, "DateReturnedByTradingDateRule") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-sch:FloatingRateNoteDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"floating-rate note date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/FloatingRateNoteDate">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/FloatingRateNoteDate</seealso>
    let FloatingRateNoteDate =
        Prefixed_Name(fibo_sec_sec_sch, "FloatingRateNoteDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-sch:FloatingRateNoteDateRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"floating-rate note date rule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/FloatingRateNoteDateRule">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/FloatingRateNoteDateRule</seealso>
    let FloatingRateNoteDateRule =
        Prefixed_Name(fibo_sec_sec_sch, "FloatingRateNoteDateRule") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-sch:InternationalMoneyMarketAustralianDollarTradingDateRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"International Money Market (IMM) Australian Dollar (AUD) trading date rule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/InternationalMoneyMarketAustralianDollarTradingDateRule">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/InternationalMoneyMarketAustralianDollarTradingDateRule</seealso>
    let InternationalMoneyMarketAustralianDollarTradingDateRule =
        Prefixed_Name(fibo_sec_sec_sch, "InternationalMoneyMarketAustralianDollarTradingDateRule") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-sch:InternationalMoneyMarketCanadianDollarTradingDateRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"International Money Market (IMM) Canadian Dollar (CAD) trading date rule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/InternationalMoneyMarketCanadianDollarTradingDateRule">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/InternationalMoneyMarketCanadianDollarTradingDateRule</seealso>
    let InternationalMoneyMarketCanadianDollarTradingDateRule =
        Prefixed_Name(fibo_sec_sec_sch, "InternationalMoneyMarketCanadianDollarTradingDateRule") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-sch:InternationalMoneyMarketNewZealandDollarTradingDateRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"International Money Market (IMM) New Zealand Dollar (NZD) trading date rule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/InternationalMoneyMarketNewZealandDollarTradingDateRule">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/InternationalMoneyMarketNewZealandDollarTradingDateRule</seealso>
    let InternationalMoneyMarketNewZealandDollarTradingDateRule =
        Prefixed_Name(fibo_sec_sec_sch, "InternationalMoneyMarketNewZealandDollarTradingDateRule") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-sch:InternationalMoneyMarketSettlementDateRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"International Money Market (IMM) settlement date rule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/InternationalMoneyMarketSettlementDateRule">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/InternationalMoneyMarketSettlementDateRule</seealso>
    let InternationalMoneyMarketSettlementDateRule =
        Prefixed_Name(fibo_sec_sec_sch, "InternationalMoneyMarketSettlementDateRule") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-sch:ScheduledCalculationPeriodEndEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"scheduled calculation period end event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/ScheduledCalculationPeriodEndEvent">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/ScheduledCalculationPeriodEndEvent</seealso>
    let ScheduledCalculationPeriodEndEvent =
        Prefixed_Name(fibo_sec_sec_sch, "ScheduledCalculationPeriodEndEvent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-sch:ScheduledCalculationPeriodStartEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"scheduled calculation period start event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/ScheduledCalculationPeriodStartEvent">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/ScheduledCalculationPeriodStartEvent</seealso>
    let ScheduledCalculationPeriodStartEvent =
        Prefixed_Name(fibo_sec_sec_sch, "ScheduledCalculationPeriodStartEvent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-sch:SettlementDateRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"settlement date rule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/SettlementDateRule">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/SettlementDateRule</seealso>
    let SettlementDateRule =
        Prefixed_Name(fibo_sec_sec_sch, "SettlementDateRule") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-sch:TradingDateRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"trading date rule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/TradingDateRule">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/TradingDateRule</seealso>
    let TradingDateRule =
        Prefixed_Name(fibo_sec_sec_sch, "TradingDateRule") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-sch:USTreasuryBillAuctionDateRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"US Treasury bill auction date rule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/USTreasuryBillAuctionDateRule">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/USTreasuryBillAuctionDateRule</seealso>
    let USTreasuryBillAuctionDateRule =
        Prefixed_Name(fibo_sec_sec_sch, "USTreasuryBillAuctionDateRule") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-sch:USTreasuryBillDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"US Treasury bill date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/USTreasuryBillDate">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/USTreasuryBillDate</seealso>
    let USTreasuryBillDate =
        Prefixed_Name(fibo_sec_sec_sch, "USTreasuryBillDate") |> PrefixedName
