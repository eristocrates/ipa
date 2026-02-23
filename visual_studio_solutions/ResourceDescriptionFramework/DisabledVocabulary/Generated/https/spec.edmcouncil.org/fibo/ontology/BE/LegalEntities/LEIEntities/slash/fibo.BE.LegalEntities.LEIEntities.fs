namespace Fibo.BE.LegalEntities.LEIEntities.Namespace
module LEIEntities =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/BE/LegalEntities/LEIEntities.rdf") (Some @"fibo.BE.LegalEntities.LEIEntities") None
    let AccountingFramework = {_prefixID with _localName = "AccountingFramework"}
    let AccountingPeriod = {_prefixID with _localName = "AccountingPeriod"}
    let ContractuallyCapableEntity = {_prefixID with _localName = "ContractuallyCapableEntity"}
    let DocumentFilingPeriod = {_prefixID with _localName = "DocumentFilingPeriod"}
    let EntityLegalForm = {_prefixID with _localName = "EntityLegalForm"}
    let EntityLegalFormIdentifier = {_prefixID with _localName = "EntityLegalFormIdentifier"}
    let EntityLegalFormScheme = {_prefixID with _localName = "EntityLegalFormScheme"}
    let GenerallyAcceptedAccountingPrinciples = {_prefixID with _localName = "GenerallyAcceptedAccountingPrinciples"}
    let ``ISO17442-CodeSet`` = {_prefixID with _localName = "ISO17442-CodeSet"}
    let ``ISO20275-CodeSet`` = {_prefixID with _localName = "ISO20275-CodeSet"}
    let InternationalFinancialReportingStandard = {_prefixID with _localName = "InternationalFinancialReportingStandard"}
    let LEIRegisteredEntity = {_prefixID with _localName = "LEIRegisteredEntity"}
    let LegalEntityIdentifier = {_prefixID with _localName = "LegalEntityIdentifier"}
    let LegalEntityIdentifierScheme = {_prefixID with _localName = "LegalEntityIdentifierScheme"}
    let OtherAccountingFramework = {_prefixID with _localName = "OtherAccountingFramework"}
    let RelationshipPeriodQualifier = {_prefixID with _localName = "RelationshipPeriodQualifier"}
    let RelationshipQualifier = {_prefixID with _localName = "RelationshipQualifier"}
    let RelationshipRecord = {_prefixID with _localName = "RelationshipRecord"}
    let RelationshipStatus = {_prefixID with _localName = "RelationshipStatus"}
    let RelationshipStatusActive = {_prefixID with _localName = "RelationshipStatusActive"}
    let RelationshipStatusInactive = {_prefixID with _localName = "RelationshipStatusInactive"}
    let hasLegalAddress = {_prefixID with _localName = "hasLegalAddress"}
    let hasLegalForm = {_prefixID with _localName = "hasLegalForm"}
    let hasLegalFormAbbreviation = {_prefixID with _localName = "hasLegalFormAbbreviation"}
    let hasOwnershipPercentage = {_prefixID with _localName = "hasOwnershipPercentage"}
    let hasTransliteratedLegalFormAbbreviation = {_prefixID with _localName = "hasTransliteratedLegalFormAbbreviation"}
    let hasTransliteratedName = {_prefixID with _localName = "hasTransliteratedName"}
    let isConsolidatedBy = {_prefixID with _localName = "isConsolidatedBy"}
    let isConsolidationOf = {_prefixID with _localName = "isConsolidationOf"}
    let isDirectlyConsolidatedBy = {_prefixID with _localName = "isDirectlyConsolidatedBy"}
    let isInternationalBranchOf = {_prefixID with _localName = "isInternationalBranchOf"}
    let isQuantifiedBy = {_prefixID with _localName = "isQuantifiedBy"}
    let isUltimatelyConsolidatedBy = {_prefixID with _localName = "isUltimatelyConsolidatedBy"}