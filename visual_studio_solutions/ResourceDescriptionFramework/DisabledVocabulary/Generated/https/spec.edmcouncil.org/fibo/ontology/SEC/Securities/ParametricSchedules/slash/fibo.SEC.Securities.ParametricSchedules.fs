namespace Fibo.SEC.Securities.ParametricSchedules.Namespace
module ParametricSchedules =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/SEC/Securities/ParametricSchedules.rdf") (Some @"fibo.SEC.Securities.ParametricSchedules") None
    let AuctionDateRule = {_prefixID with _localName = "AuctionDateRule"}
    let DateReturnedBySettlementDateRule = {_prefixID with _localName = "DateReturnedBySettlementDateRule"}
    let DateReturnedByTradingDateRule = {_prefixID with _localName = "DateReturnedByTradingDateRule"}
    let FloatingRateNoteDate = {_prefixID with _localName = "FloatingRateNoteDate"}
    let FloatingRateNoteDateRule = {_prefixID with _localName = "FloatingRateNoteDateRule"}
    let InternationalMoneyMarketAustralianDollarTradingDateRule = {_prefixID with _localName = "InternationalMoneyMarketAustralianDollarTradingDateRule"}
    let InternationalMoneyMarketCanadianDollarTradingDateRule = {_prefixID with _localName = "InternationalMoneyMarketCanadianDollarTradingDateRule"}
    let InternationalMoneyMarketNewZealandDollarTradingDateRule = {_prefixID with _localName = "InternationalMoneyMarketNewZealandDollarTradingDateRule"}
    let InternationalMoneyMarketSettlementDateRule = {_prefixID with _localName = "InternationalMoneyMarketSettlementDateRule"}
    let ScheduledCalculationPeriodEndEvent = {_prefixID with _localName = "ScheduledCalculationPeriodEndEvent"}
    let ScheduledCalculationPeriodStartEvent = {_prefixID with _localName = "ScheduledCalculationPeriodStartEvent"}
    let SettlementDateRule = {_prefixID with _localName = "SettlementDateRule"}
    let TradingDateRule = {_prefixID with _localName = "TradingDateRule"}
    let USTreasuryBillAuctionDateRule = {_prefixID with _localName = "USTreasuryBillAuctionDateRule"}
    let USTreasuryBillDate = {_prefixID with _localName = "USTreasuryBillDate"}