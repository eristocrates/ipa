namespace Fibo.SEC.Securities.SecurityAssets.Namespace
module SecurityAssets =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecurityAssets/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/SEC/Securities/SecurityAssets.rdf") (Some @"fibo.SEC.Securities.SecurityAssets") None
    let Portfolio = {_prefixID with _localName = "Portfolio"}
    let PortfolioHolding = {_prefixID with _localName = "PortfolioHolding"}
    let hasAcquisitionPrice = {_prefixID with _localName = "hasAcquisitionPrice"}