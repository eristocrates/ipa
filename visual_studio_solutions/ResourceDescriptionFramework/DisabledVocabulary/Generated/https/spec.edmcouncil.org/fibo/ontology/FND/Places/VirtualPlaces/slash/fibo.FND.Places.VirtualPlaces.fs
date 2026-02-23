namespace Fibo.FND.Places.VirtualPlaces.Namespace
module VirtualPlaces =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/FND/Places/VirtualPlaces/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/FND/Places/VirtualPlaces.rdf") (Some @"fibo.FND.Places.VirtualPlaces") None
    let ElectronicMailAddress = {_prefixID with _localName = "ElectronicMailAddress"}
    let NetworkLocation = {_prefixID with _localName = "NetworkLocation"}
    let NotionalPlace = {_prefixID with _localName = "NotionalPlace"}
    let TelephoneNumber = {_prefixID with _localName = "TelephoneNumber"}
    let hasElectronicMailAddress = {_prefixID with _localName = "hasElectronicMailAddress"}
    let hasTelephoneNumber = {_prefixID with _localName = "hasTelephoneNumber"}