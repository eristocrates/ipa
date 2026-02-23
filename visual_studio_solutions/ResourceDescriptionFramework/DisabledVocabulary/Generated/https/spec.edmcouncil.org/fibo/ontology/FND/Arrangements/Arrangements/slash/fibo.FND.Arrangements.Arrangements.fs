namespace Fibo.FND.Arrangements.Arrangements.Namespace
module Arrangements =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Arrangements/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/FND/Arrangements/Arrangements.rdf") (Some @"fibo.FND.Arrangements.Arrangements") None
    let Scheme = {_prefixID with _localName = "Scheme"}
    let hasCollectionSize = {_prefixID with _localName = "hasCollectionSize"}