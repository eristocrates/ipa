namespace Fibo.LOAN.MetadataLOAN.Namespace
module MetadataLOAN =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/LOAN/MetadataLOAN/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/LOAN/MetadataLOAN.rdf") (Some @"fibo.LOAN.MetadataLOAN") None
    let LOANDomain = {_prefixID with _localName = "LOANDomain"}