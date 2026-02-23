namespace Fibo.FND.Accounting.CashFlows.Namespace
module CashFlows =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CashFlows/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/FND/Accounting/CashFlows.rdf") (Some @"fibo.FND.Accounting.CashFlows") None
    let CashFlow = {_prefixID with _localName = "CashFlow"}
    let CashFlowStructure = {_prefixID with _localName = "CashFlowStructure"}
    let TriggeringEvent = {_prefixID with _localName = "TriggeringEvent"}
    let hasSourceOfMoney = {_prefixID with _localName = "hasSourceOfMoney"}
    let hasTargetOfMoney = {_prefixID with _localName = "hasTargetOfMoney"}