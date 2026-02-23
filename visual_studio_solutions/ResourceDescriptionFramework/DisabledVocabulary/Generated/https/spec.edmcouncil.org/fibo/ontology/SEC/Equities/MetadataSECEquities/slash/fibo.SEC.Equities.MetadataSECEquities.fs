namespace Fibo.SEC.Equities.MetadataSECEquities.Namespace
module MetadataSECEquities =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/MetadataSECEquities/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/SEC/Equities/MetadataSECEquities.rdf") (Some @"fibo.SEC.Equities.MetadataSECEquities") None
    let EquitiesModule = {_prefixID with _localName = "EquitiesModule"}