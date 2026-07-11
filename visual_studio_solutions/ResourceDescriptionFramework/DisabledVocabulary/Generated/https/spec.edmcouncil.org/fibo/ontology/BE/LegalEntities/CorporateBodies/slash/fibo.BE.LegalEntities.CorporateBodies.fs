namespace Fibo.BE.LegalEntities.CorporateBodies.Namespace
module CorporateBodies =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/BE/LegalEntities/CorporateBodies.rdf") (Some @"fibo.BE.LegalEntities.CorporateBodies") None
    let BenefitCorporation = {_prefixID with _localName = "BenefitCorporation"}
    let BoardAgreement = {_prefixID with _localName = "BoardAgreement"}
    let CommonInterestDevelopmentCorporation = {_prefixID with _localName = "CommonInterestDevelopmentCorporation"}
    let Corporation = {_prefixID with _localName = "Corporation"}
    let ForProfitCorporation = {_prefixID with _localName = "ForProfitCorporation"}
    let IncorporationGuarantee = {_prefixID with _localName = "IncorporationGuarantee"}
    let InstrumentOfIncorporation = {_prefixID with _localName = "InstrumentOfIncorporation"}
    let JointStockCompany = {_prefixID with _localName = "JointStockCompany"}
    let NotForProfitCorporation = {_prefixID with _localName = "NotForProfitCorporation"}
    let PrivatelyHeldCompany = {_prefixID with _localName = "PrivatelyHeldCompany"}
    let PubliclyHeldCompany = {_prefixID with _localName = "PubliclyHeldCompany"}
    let RegistrationIdentifier = {_prefixID with _localName = "RegistrationIdentifier"}
    let RegistrationIdentifierScheme = {_prefixID with _localName = "RegistrationIdentifierScheme"}
    let ReligiousCorporation = {_prefixID with _localName = "ReligiousCorporation"}
    let StockCorporation = {_prefixID with _localName = "StockCorporation"}
    let hasDateOfIncorporation = {_prefixID with _localName = "hasDateOfIncorporation"}
    let hasDateOfRegistration = {_prefixID with _localName = "hasDateOfRegistration"}
    let hasIssuedCapital = {_prefixID with _localName = "hasIssuedCapital"}
    let hasSharesAuthorized = {_prefixID with _localName = "hasSharesAuthorized"}
    let isConstitutedBy = {_prefixID with _localName = "isConstitutedBy"}
    let isIncorporatedIn = {_prefixID with _localName = "isIncorporatedIn"}