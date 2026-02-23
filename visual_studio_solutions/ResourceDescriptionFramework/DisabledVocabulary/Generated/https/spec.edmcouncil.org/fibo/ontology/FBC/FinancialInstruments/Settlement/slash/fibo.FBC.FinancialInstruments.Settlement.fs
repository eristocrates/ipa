namespace Fibo.FBC.FinancialInstruments.Settlement.Namespace
module Settlement =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/FBC/FinancialInstruments/Settlement.rdf") (Some @"fibo.FBC.FinancialInstruments.Settlement") None
    let CashSettlementTerms = {_prefixID with _localName = "CashSettlementTerms"}
    let DeliveryInCash = {_prefixID with _localName = "DeliveryInCash"}
    let DeliveryMethod = {_prefixID with _localName = "DeliveryMethod"}
    let ElectAtExerciseMethod = {_prefixID with _localName = "ElectAtExerciseMethod"}
    let NonDeliverableMethod = {_prefixID with _localName = "NonDeliverableMethod"}
    let PhysicalDeliveryMethod = {_prefixID with _localName = "PhysicalDeliveryMethod"}
    let PhysicalSettlementTerms = {_prefixID with _localName = "PhysicalSettlementTerms"}
    let Settlement = {_prefixID with _localName = "Settlement"}
    let SettlementConvention = {_prefixID with _localName = "SettlementConvention"}
    let SettlementEvent = {_prefixID with _localName = "SettlementEvent"}
    let hasDeliveryMethod = {_prefixID with _localName = "hasDeliveryMethod"}
    let hasPreferredSettlementCurrency = {_prefixID with _localName = "hasPreferredSettlementCurrency"}
    let hasSettlementAmount = {_prefixID with _localName = "hasSettlementAmount"}
    let isFractionalEligible = {_prefixID with _localName = "isFractionalEligible"}
    let isFullyAutomatedSecuritiesTransferApplicable = {_prefixID with _localName = "isFullyAutomatedSecuritiesTransferApplicable"}