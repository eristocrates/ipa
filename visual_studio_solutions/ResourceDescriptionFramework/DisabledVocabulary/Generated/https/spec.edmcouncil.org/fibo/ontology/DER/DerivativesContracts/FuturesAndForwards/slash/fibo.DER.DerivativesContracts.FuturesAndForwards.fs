namespace Fibo.DER.DerivativesContracts.FuturesAndForwards.Namespace
module FuturesAndForwards =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/DER/DerivativesContracts/FuturesAndForwards.rdf") (Some @"fibo.DER.DerivativesContracts.FuturesAndForwards") None
    let BasketFuture = {_prefixID with _localName = "BasketFuture"}
    let BondFuture = {_prefixID with _localName = "BondFuture"}
    let CurrencyFuture = {_prefixID with _localName = "CurrencyFuture"}
    let DebtInstrumentFuture = {_prefixID with _localName = "DebtInstrumentFuture"}
    let DividendAdjustmentPeriod = {_prefixID with _localName = "DividendAdjustmentPeriod"}
    let DividendFuture = {_prefixID with _localName = "DividendFuture"}
    let EquityForward = {_prefixID with _localName = "EquityForward"}
    let EquityFuture = {_prefixID with _localName = "EquityFuture"}
    let FinancialFuture = {_prefixID with _localName = "FinancialFuture"}
    let Forward = {_prefixID with _localName = "Forward"}
    let ForwardContractAdjustmentMethod = {_prefixID with _localName = "ForwardContractAdjustmentMethod"}
    let FutureOnFuture = {_prefixID with _localName = "FutureOnFuture"}
    let FutureOnOption = {_prefixID with _localName = "FutureOnOption"}
    let FutureOnSwap = {_prefixID with _localName = "FutureOnSwap"}
    let IndexFuture = {_prefixID with _localName = "IndexFuture"}
    let InterestRateFuture = {_prefixID with _localName = "InterestRateFuture"}
    let MoneyMarketFuture = {_prefixID with _localName = "MoneyMarketFuture"}
    let StandardizedFuturesListingTerms = {_prefixID with _localName = "StandardizedFuturesListingTerms"}
    let StandardizedFuturesTerms = {_prefixID with _localName = "StandardizedFuturesTerms"}
    let hasConversionFactor = {_prefixID with _localName = "hasConversionFactor"}
    let hasDividendAdjustmentPeriod = {_prefixID with _localName = "hasDividendAdjustmentPeriod"}
    let hasMethodOfAdjustment = {_prefixID with _localName = "hasMethodOfAdjustment"}
    let hasMultiple = {_prefixID with _localName = "hasMultiple"}