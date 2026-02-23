namespace Fibo.FBC.FunctionalEntities.BusinessCenters.Namespace
module BusinessCenters =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessCenters/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/FBC/FunctionalEntities/BusinessCenters.rdf") (Some @"fibo.FBC.FunctionalEntities.BusinessCenters") None
    let BusinessCenterCode = {_prefixID with _localName = "BusinessCenterCode"}
    let BusinessCenterCodeScheme = {_prefixID with _localName = "BusinessCenterCodeScheme"}
    let BusinessDayAdjustmentCode = {_prefixID with _localName = "BusinessDayAdjustmentCode"}