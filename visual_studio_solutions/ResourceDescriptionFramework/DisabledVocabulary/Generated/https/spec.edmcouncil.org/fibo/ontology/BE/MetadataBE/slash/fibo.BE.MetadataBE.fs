namespace Fibo.BE.MetadataBE.Namespace
module MetadataBE =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/BE/MetadataBE/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/BE/MetadataBE.rdf") (Some @"fibo.BE.MetadataBE") None
    let BEDomain = {_prefixID with _localName = "BEDomain"}