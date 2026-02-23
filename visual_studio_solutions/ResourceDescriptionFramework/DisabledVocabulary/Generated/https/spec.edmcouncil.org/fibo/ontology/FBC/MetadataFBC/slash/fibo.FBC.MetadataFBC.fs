namespace Fibo.FBC.MetadataFBC.Namespace
module MetadataFBC =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/FBC/MetadataFBC/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/FBC/MetadataFBC.rdf") (Some @"fibo.FBC.MetadataFBC") None
    let FBCDomain = {_prefixID with _localName = "FBCDomain"}