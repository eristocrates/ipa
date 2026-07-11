namespace Fibo.IND.MetadataIND.Namespace
module MetadataIND =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/IND/MetadataIND/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/IND/MetadataIND.rdf") (Some @"fibo.IND.MetadataIND") None
    let INDDomain = {_prefixID with _localName = "INDDomain"}