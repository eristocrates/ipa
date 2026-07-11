namespace Fibo.SEC.Securities.NorthAmericanSecurities.USSecuritiesRestrictions.Namespace
module USSecuritiesRestrictions =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/NorthAmericanSecurities/USSecuritiesRestrictions/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/SEC/Securities/NorthAmericanSecurities/USSecuritiesRestrictions.rdf") (Some @"fibo.SEC.Securities.NorthAmericanSecurities.USSecuritiesRestrictions") None
    let BlueSkyLaw = {_prefixID with _localName = "BlueSkyLaw"}
    let RegulationD = {_prefixID with _localName = "RegulationD"}
    let RegulationS = {_prefixID with _localName = "RegulationS"}
    let Rule144A = {_prefixID with _localName = "Rule144A"}
    let SECExemption3c7 = {_prefixID with _localName = "SECExemption3c7"}
    let ``SECRule15c3-3`` = {_prefixID with _localName = "SECRule15c3-3"}
    let SECRule201 = {_prefixID with _localName = "SECRule201"}
    let TEFRACRule = {_prefixID with _localName = "TEFRACRule"}
    let TEFRADRule = {_prefixID with _localName = "TEFRADRule"}
    let isEmployeeRetirementIncomeSecurityActConformant = {_prefixID with _localName = "isEmployeeRetirementIncomeSecurityActConformant"}
    let isFederalDepositInsuranceCorporationInsured = {_prefixID with _localName = "isFederalDepositInsuranceCorporationInsured"}
    let isSubjectToFederalReserveBoardRegulationT = {_prefixID with _localName = "isSubjectToFederalReserveBoardRegulationT"}