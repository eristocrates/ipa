namespace Fibo.MetadataFIBO.Namespace
module MetadataFIBO =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/MetadataFIBO/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/MetadataFIBO.rdf") (Some @"fibo.MetadataFIBO") None
    let FIBOSpecification = {_prefixID with _localName = "FIBOSpecification"}