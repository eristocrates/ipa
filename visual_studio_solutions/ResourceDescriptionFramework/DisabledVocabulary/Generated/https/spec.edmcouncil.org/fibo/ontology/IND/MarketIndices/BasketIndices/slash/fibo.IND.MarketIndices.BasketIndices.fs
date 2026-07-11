namespace Fibo.IND.MarketIndices.BasketIndices.Namespace
module BasketIndices =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/IND/MarketIndices/BasketIndices.rdf") (Some @"fibo.IND.MarketIndices.BasketIndices") None
    let BasketOfCreditRisks = {_prefixID with _localName = "BasketOfCreditRisks"}
    let BasketOfEquities = {_prefixID with _localName = "BasketOfEquities"}
    let CapitalizationBasedWeightingFunction = {_prefixID with _localName = "CapitalizationBasedWeightingFunction"}
    let CreditIndex = {_prefixID with _localName = "CreditIndex"}
    let CreditIndexConstituent = {_prefixID with _localName = "CreditIndexConstituent"}
    let EquityIndex = {_prefixID with _localName = "EquityIndex"}
    let MarketCapitalization = {_prefixID with _localName = "MarketCapitalization"}
    let ReferenceIndex = {_prefixID with _localName = "ReferenceIndex"}
    let hasDebtRanking = {_prefixID with _localName = "hasDebtRanking"}
    let hasIndexName = {_prefixID with _localName = "hasIndexName"}
    let hasIndexValue = {_prefixID with _localName = "hasIndexValue"}
    let hasMarketCapitalization = {_prefixID with _localName = "hasMarketCapitalization"}
    let hasMarketCapitalizationValue = {_prefixID with _localName = "hasMarketCapitalizationValue"}
    let hasOriginalNotionalValue = {_prefixID with _localName = "hasOriginalNotionalValue"}
    let hasPremium = {_prefixID with _localName = "hasPremium"}
    let hasSpreadRange = {_prefixID with _localName = "hasSpreadRange"}
    let hasUpFrontFee = {_prefixID with _localName = "hasUpFrontFee"}