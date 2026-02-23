namespace Fibo.SEC.Securities.Pools.Namespace
module Pools =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/SEC/Securities/Pools.rdf") (Some @"fibo.SEC.Securities.Pools") None
    let CollectiveInvestmentVehicle = {_prefixID with _localName = "CollectiveInvestmentVehicle"}
    let DebtPool = {_prefixID with _localName = "DebtPool"}
    let FundFamily = {_prefixID with _localName = "FundFamily"}
    let InstrumentPool = {_prefixID with _localName = "InstrumentPool"}
    let InstrumentPoolAsAsset = {_prefixID with _localName = "InstrumentPoolAsAsset"}
    let ManagedInvestment = {_prefixID with _localName = "ManagedInvestment"}
    let Pool = {_prefixID with _localName = "Pool"}
    let PoolConstituent = {_prefixID with _localName = "PoolConstituent"}
    let PooledFund = {_prefixID with _localName = "PooledFund"}
    let PrivateFund = {_prefixID with _localName = "PrivateFund"}
    let SecuritiesPool = {_prefixID with _localName = "SecuritiesPool"}
    let SecuritiesPoolConstituent = {_prefixID with _localName = "SecuritiesPoolConstituent"}