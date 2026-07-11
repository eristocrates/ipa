namespace Fibo.FND.Places.RealProperty.Namespace
module RealProperty =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/FND/Places/RealProperty.rdf") (Some @"fibo.FND.Places.RealProperty") None
    let PersonalProperty = {_prefixID with _localName = "PersonalProperty"}
    let PropertyInspection = {_prefixID with _localName = "PropertyInspection"}
    let PropertyInspectionReport = {_prefixID with _localName = "PropertyInspectionReport"}
    let RealEstate = {_prefixID with _localName = "RealEstate"}
    let RealProperty = {_prefixID with _localName = "RealProperty"}
    let RealPropertyAppraisal = {_prefixID with _localName = "RealPropertyAppraisal"}
    let RealPropertyIdentifier = {_prefixID with _localName = "RealPropertyIdentifier"}
    let TractIdentifier = {_prefixID with _localName = "TractIdentifier"}
    let TractOfLand = {_prefixID with _localName = "TractOfLand"}