namespace Fibo.IND.Indicators.Indicators.Namespace
module Indicators =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/IND/Indicators/Indicators.rdf") (Some @"fibo.IND.Indicators.Indicators") None
    let DailyAverageMarketRate = {_prefixID with _localName = "DailyAverageMarketRate"}
    let EndOfDayMarketRate = {_prefixID with _localName = "EndOfDayMarketRate"}
    let HistoricalPriceVolatility = {_prefixID with _localName = "HistoricalPriceVolatility"}
    let HistoricalVolatility = {_prefixID with _localName = "HistoricalVolatility"}
    let ImpliedPriceVolatility = {_prefixID with _localName = "ImpliedPriceVolatility"}
    let ImpliedVolatility = {_prefixID with _localName = "ImpliedVolatility"}
    let MarketRate = {_prefixID with _localName = "MarketRate"}
    let MarketSpread = {_prefixID with _localName = "MarketSpread"}
    let PriceStructure = {_prefixID with _localName = "PriceStructure"}
    let PriceVolatility = {_prefixID with _localName = "PriceVolatility"}
    let QuotedPrice = {_prefixID with _localName = "QuotedPrice"}
    let TermStructure = {_prefixID with _localName = "TermStructure"}
    let Volatility = {_prefixID with _localName = "Volatility"}
    let hasQuotationDate = {_prefixID with _localName = "hasQuotationDate"}
    let hasQuotationDateTime = {_prefixID with _localName = "hasQuotationDateTime"}
    let isVolatilityOf = {_prefixID with _localName = "isVolatilityOf"}