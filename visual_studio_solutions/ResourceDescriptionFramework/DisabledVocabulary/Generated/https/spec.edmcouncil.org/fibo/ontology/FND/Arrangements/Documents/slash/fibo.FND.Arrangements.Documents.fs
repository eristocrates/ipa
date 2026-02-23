namespace Fibo.FND.Arrangements.Documents.Namespace
module Documents =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/FND/Arrangements/Documents.rdf") (Some @"fibo.FND.Arrangements.Documents") None
    let FinancialRecord = {_prefixID with _localName = "FinancialRecord"}
    let hasExpirationDate = {_prefixID with _localName = "hasExpirationDate"}
    let hasRecord = {_prefixID with _localName = "hasRecord"}
    let hasReportingPeriod = {_prefixID with _localName = "hasReportingPeriod"}
    let hasTerminationDate = {_prefixID with _localName = "hasTerminationDate"}