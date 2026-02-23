namespace Fibo.FND.MetadataFND.Namespace
module MetadataFND =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/FND/MetadataFND/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/FND/MetadataFND.rdf") (Some @"fibo.FND.MetadataFND") None
    let FNDDomain = {_prefixID with _localName = "FNDDomain"}