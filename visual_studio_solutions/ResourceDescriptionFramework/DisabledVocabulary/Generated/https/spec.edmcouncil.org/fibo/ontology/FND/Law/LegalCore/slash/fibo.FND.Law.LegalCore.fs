namespace Fibo.FND.Law.LegalCore.Namespace
module LegalCore =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCore/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/FND/Law/LegalCore.rdf") (Some @"fibo.FND.Law.LegalCore") None
    let Constitution = {_prefixID with _localName = "Constitution"}
    let CourtOfLaw = {_prefixID with _localName = "CourtOfLaw"}
    let Law = {_prefixID with _localName = "Law"}
    let StatuteLaw = {_prefixID with _localName = "StatuteLaw"}
    let hasInForce = {_prefixID with _localName = "hasInForce"}
    let isInForceIn = {_prefixID with _localName = "isInForceIn"}