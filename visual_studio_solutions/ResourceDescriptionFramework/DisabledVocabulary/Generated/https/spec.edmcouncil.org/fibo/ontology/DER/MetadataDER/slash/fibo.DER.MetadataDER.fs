namespace Fibo.DER.MetadataDER.Namespace
module MetadataDER =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/DER/MetadataDER/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/DER/MetadataDER.rdf") (Some @"fibo.DER.MetadataDER") None
    let DERDomain = {_prefixID with _localName = "DERDomain"}