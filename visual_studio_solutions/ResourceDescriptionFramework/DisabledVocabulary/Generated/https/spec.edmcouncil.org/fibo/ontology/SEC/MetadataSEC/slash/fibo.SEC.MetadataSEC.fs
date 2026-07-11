namespace Fibo.SEC.MetadataSEC.Namespace
module MetadataSEC =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/SEC/MetadataSEC/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/SEC/MetadataSEC.rdf") (Some @"fibo.SEC.MetadataSEC") None
    let SECDomain = {_prefixID with _localName = "SECDomain"}