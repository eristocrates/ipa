namespace Fibo.IND.ForeignExchange.ForeignExchange.Namespace
module ForeignExchange =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/IND/ForeignExchange/ForeignExchange.rdf") (Some @"fibo.IND.ForeignExchange.ForeignExchange") None
    let CurrencyConversionService = {_prefixID with _localName = "CurrencyConversionService"}
    let CurrencyForwardRate = {_prefixID with _localName = "CurrencyForwardRate"}
    let CurrencyForwardRateVolatility = {_prefixID with _localName = "CurrencyForwardRateVolatility"}
    let CurrencySpotBuyRate = {_prefixID with _localName = "CurrencySpotBuyRate"}
    let CurrencySpotMidRate = {_prefixID with _localName = "CurrencySpotMidRate"}
    let CurrencySpotRate = {_prefixID with _localName = "CurrencySpotRate"}
    let CurrencySpotSellRate = {_prefixID with _localName = "CurrencySpotSellRate"}
    let CurrencySpotVolatility = {_prefixID with _localName = "CurrencySpotVolatility"}
    let ExchangeRateStructure = {_prefixID with _localName = "ExchangeRateStructure"}
    let ExchangeRateVolatility = {_prefixID with _localName = "ExchangeRateVolatility"}
    let ForeignExchangeService = {_prefixID with _localName = "ForeignExchangeService"}
    let InternationalElectronicFundsTransferService = {_prefixID with _localName = "InternationalElectronicFundsTransferService"}
    let QuotedExchangeRate = {_prefixID with _localName = "QuotedExchangeRate"}
    let hasExchangeRateQuotationSource = {_prefixID with _localName = "hasExchangeRateQuotationSource"}
    let hasQuotationBlockAmountBasis = {_prefixID with _localName = "hasQuotationBlockAmountBasis"}
    let hasQuotationSettlementBasis = {_prefixID with _localName = "hasQuotationSettlementBasis"}
    let hasQuoteCurrency = {_prefixID with _localName = "hasQuoteCurrency"}
    let hasQuotedExchangeRate = {_prefixID with _localName = "hasQuotedExchangeRate"}
    let isPremiumOn = {_prefixID with _localName = "isPremiumOn"}