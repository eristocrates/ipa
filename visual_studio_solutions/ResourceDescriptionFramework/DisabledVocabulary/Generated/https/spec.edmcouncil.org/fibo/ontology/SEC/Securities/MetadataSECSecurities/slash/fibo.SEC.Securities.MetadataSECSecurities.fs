namespace Fibo.SEC.Securities.MetadataSECSecurities.Namespace
module MetadataSECSecurities =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/MetadataSECSecurities/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/SEC/Securities/MetadataSECSecurities.rdf") (Some @"fibo.SEC.Securities.MetadataSECSecurities") None
    let SecuritiesModule = {_prefixID with _localName = "SecuritiesModule"}