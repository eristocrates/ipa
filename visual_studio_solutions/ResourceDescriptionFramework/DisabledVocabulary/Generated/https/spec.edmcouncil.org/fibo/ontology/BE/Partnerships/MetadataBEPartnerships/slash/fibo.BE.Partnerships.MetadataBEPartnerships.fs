namespace Fibo.BE.Partnerships.MetadataBEPartnerships.Namespace
module MetadataBEPartnerships =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/MetadataBEPartnerships/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/BE/Partnerships/MetadataBEPartnerships.rdf") (Some @"fibo.BE.Partnerships.MetadataBEPartnerships") None
    let PartnershipsModule = {_prefixID with _localName = "PartnershipsModule"}