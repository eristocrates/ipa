namespace Fibo.CAE.MetadataCAE.Namespace
module MetadataCAE =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/CAE/MetadataCAE/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/CAE/MetadataCAE.rdf") (Some @"fibo.CAE.MetadataCAE") None
    let CAEDomain = {_prefixID with _localName = "CAEDomain"}