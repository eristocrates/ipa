namespace Fibo.BP.SecuritiesIssuance.MBSIssuance.Namespace
module MBSIssuance =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/BP/SecuritiesIssuance/MBSIssuance/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/BP/SecuritiesIssuance/MBSIssuance.rdf") (Some @"fibo.BP.SecuritiesIssuance.MBSIssuance") None
    let MBSSecuritizationProcess = {_prefixID with _localName = "MBSSecuritizationProcess"}
    let ProspectusPart = {_prefixID with _localName = "ProspectusPart"}
    let includesDetailsAbout = {_prefixID with _localName = "includesDetailsAbout"}