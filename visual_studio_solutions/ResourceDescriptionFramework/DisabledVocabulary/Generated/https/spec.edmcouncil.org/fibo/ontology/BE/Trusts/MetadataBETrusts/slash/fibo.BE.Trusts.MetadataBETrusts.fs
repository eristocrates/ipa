namespace Fibo.BE.Trusts.MetadataBETrusts.Namespace
module MetadataBETrusts =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/MetadataBETrusts/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/BE/Trusts/MetadataBETrusts.rdf") (Some @"fibo.BE.Trusts.MetadataBETrusts") None
    let TrustsModule = {_prefixID with _localName = "TrustsModule"}