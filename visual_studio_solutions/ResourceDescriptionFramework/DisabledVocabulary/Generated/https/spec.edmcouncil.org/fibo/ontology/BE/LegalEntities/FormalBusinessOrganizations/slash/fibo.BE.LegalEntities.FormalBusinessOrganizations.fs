namespace Fibo.BE.LegalEntities.FormalBusinessOrganizations.Namespace
module FormalBusinessOrganizations =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/BE/LegalEntities/FormalBusinessOrganizations.rdf") (Some @"fibo.BE.LegalEntities.FormalBusinessOrganizations") None
    let Branch = {_prefixID with _localName = "Branch"}
    let Division = {_prefixID with _localName = "Division"}
    let JointVenture = {_prefixID with _localName = "JointVenture"}
    let NonGovernmentalOrganization = {_prefixID with _localName = "NonGovernmentalOrganization"}
    let NotForProfitOrganization = {_prefixID with _localName = "NotForProfitOrganization"}
    let OrganizationCoveringAgreement = {_prefixID with _localName = "OrganizationCoveringAgreement"}
    let ValueAddedTaxIdentificationNumber = {_prefixID with _localName = "ValueAddedTaxIdentificationNumber"}
    let hasEquity = {_prefixID with _localName = "hasEquity"}
    let hasHeadquartersAddress = {_prefixID with _localName = "hasHeadquartersAddress"}
    let hasOperatingAddress = {_prefixID with _localName = "hasOperatingAddress"}
    let hasRegisteredAddress = {_prefixID with _localName = "hasRegisteredAddress"}