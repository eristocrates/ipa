namespace Fibo.SEC.Debt.TradedShortTermDebt.Namespace
module TradedShortTermDebt =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/SEC/Debt/TradedShortTermDebt.rdf") (Some @"fibo.SEC.Debt.TradedShortTermDebt") None
    let BankersAcceptance = {_prefixID with _localName = "BankersAcceptance"}
    let BillOfExchange = {_prefixID with _localName = "BillOfExchange"}
    let CommercialPaper = {_prefixID with _localName = "CommercialPaper"}
    let Drawee = {_prefixID with _localName = "Drawee"}
    let Drawer = {_prefixID with _localName = "Drawer"}
    let EurodollarDeposit = {_prefixID with _localName = "EurodollarDeposit"}
    let MoneyMarketInstrument = {_prefixID with _localName = "MoneyMarketInstrument"}
    let RepurchaseAgreement = {_prefixID with _localName = "RepurchaseAgreement"}