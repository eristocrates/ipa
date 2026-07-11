namespace Fibo.MD.MetadataMD.Namespace
module MetadataMD =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/MD/MetadataMD/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/MD/MetadataMD.rdf") (Some @"fibo.MD.MetadataMD") None
    let MDDomain = {_prefixID with _localName = "MDDomain"}