namespace Fibo.MD.TemporalCore.SecurityTradingStatuses.Namespace
module SecurityTradingStatuses =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/MD/TemporalCore/SecurityTradingStatuses/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/MD/TemporalCore/SecurityTradingStatuses.rdf") (Some @"fibo.MD.TemporalCore.SecurityTradingStatuses") None
    let Active = {_prefixID with _localName = "Active"}
    let ActivelyTrading = {_prefixID with _localName = "ActivelyTrading"}
    let ExchangeSecurityTradingStatus = {_prefixID with _localName = "ExchangeSecurityTradingStatus"}
    let Inactive = {_prefixID with _localName = "Inactive"}
    let Issued = {_prefixID with _localName = "Issued"}
    let SecurityLifecycleStatus = {_prefixID with _localName = "SecurityLifecycleStatus"}
    let SecurityTradingStatus = {_prefixID with _localName = "SecurityTradingStatus"}
    let TradingHalted = {_prefixID with _localName = "TradingHalted"}
    let WhenDistributed = {_prefixID with _localName = "WhenDistributed"}
    let WhenIssued = {_prefixID with _localName = "WhenIssued"}
    let Worthless = {_prefixID with _localName = "Worthless"}