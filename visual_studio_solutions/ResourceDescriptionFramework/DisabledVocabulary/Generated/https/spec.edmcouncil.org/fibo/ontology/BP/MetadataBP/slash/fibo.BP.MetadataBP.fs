namespace Fibo.BP.MetadataBP.Namespace
module MetadataBP =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/BP/MetadataBP/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/BP/MetadataBP.rdf") (Some @"fibo.BP.MetadataBP") None
    let BPDomain = {_prefixID with _localName = "BPDomain"}