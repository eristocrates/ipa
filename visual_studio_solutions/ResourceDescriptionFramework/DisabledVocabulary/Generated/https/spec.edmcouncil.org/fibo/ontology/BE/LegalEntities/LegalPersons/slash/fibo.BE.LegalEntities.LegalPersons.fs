namespace Fibo.BE.LegalEntities.LegalPersons.Namespace
module LegalPersons =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/BE/LegalEntities/LegalPersons.rdf") (Some @"fibo.BE.LegalEntities.LegalPersons") None
    let BusinessEntity = {_prefixID with _localName = "BusinessEntity"}
    let BusinessLicense = {_prefixID with _localName = "BusinessLicense"}
    let CharteredLegalPerson = {_prefixID with _localName = "CharteredLegalPerson"}
    let LegallyCompetentNaturalPerson = {_prefixID with _localName = "LegallyCompetentNaturalPerson"}
    let NotForProfitObjective = {_prefixID with _localName = "NotForProfitObjective"}
    let PowerOfAttorney = {_prefixID with _localName = "PowerOfAttorney"}
    let ProfitObjective = {_prefixID with _localName = "ProfitObjective"}
    let PublicPurpose = {_prefixID with _localName = "PublicPurpose"}
    let ReligiousObjective = {_prefixID with _localName = "ReligiousObjective"}
    let SpecialPurposeVehicle = {_prefixID with _localName = "SpecialPurposeVehicle"}
    let StatutoryBody = {_prefixID with _localName = "StatutoryBody"}
    let VariableInterestEntity = {_prefixID with _localName = "VariableInterestEntity"}
    let hasIntendedLiquidationDate = {_prefixID with _localName = "hasIntendedLiquidationDate"}