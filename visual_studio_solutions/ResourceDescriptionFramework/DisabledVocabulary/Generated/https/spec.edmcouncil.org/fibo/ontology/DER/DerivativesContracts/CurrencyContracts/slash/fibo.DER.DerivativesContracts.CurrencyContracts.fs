namespace Fibo.DER.DerivativesContracts.CurrencyContracts.Namespace
module CurrencyContracts =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/DER/DerivativesContracts/CurrencyContracts.rdf") (Some @"fibo.DER.DerivativesContracts.CurrencyContracts") None
    let CurrencyDerivative = {_prefixID with _localName = "CurrencyDerivative"}
    let CurrencyForward = {_prefixID with _localName = "CurrencyForward"}
    let CurrencyForwardOutright = {_prefixID with _localName = "CurrencyForwardOutright"}
    let CurrencyOption = {_prefixID with _localName = "CurrencyOption"}
    let CurrencySpotContract = {_prefixID with _localName = "CurrencySpotContract"}
    let CurrencySpotForwardSwap = {_prefixID with _localName = "CurrencySpotForwardSwap"}
    let CurrencySwap = {_prefixID with _localName = "CurrencySwap"}
    let CurrencyVolatilityOption = {_prefixID with _localName = "CurrencyVolatilityOption"}
    let ForeignExchangeMasterAgreement = {_prefixID with _localName = "ForeignExchangeMasterAgreement"}
    let ForeignExchangeSettlementNettingProvision = {_prefixID with _localName = "ForeignExchangeSettlementNettingProvision"}
    let hasForwardExchangeRate = {_prefixID with _localName = "hasForwardExchangeRate"}
    let hasSpotExchangeRate = {_prefixID with _localName = "hasSpotExchangeRate"}