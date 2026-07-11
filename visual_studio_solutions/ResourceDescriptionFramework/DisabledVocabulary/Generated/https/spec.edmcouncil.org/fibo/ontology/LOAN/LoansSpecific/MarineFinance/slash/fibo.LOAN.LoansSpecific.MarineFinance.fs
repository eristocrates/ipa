namespace Fibo.LOAN.LoansSpecific.MarineFinance.Namespace
module MarineFinance =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/MarineFinance/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/LOAN/LoansSpecific/MarineFinance.rdf") (Some @"fibo.LOAN.LoansSpecific.MarineFinance") None
    let MarineFinancing = {_prefixID with _localName = "MarineFinancing"}
    let boatHeldAsChattel = {_prefixID with _localName = "boatHeldAsChattel"}
    let mooredAt = {_prefixID with _localName = "mooredAt"}
    let percentageAdvanced = {_prefixID with _localName = "percentageAdvanced"}
    let residential = {_prefixID with _localName = "residential"}