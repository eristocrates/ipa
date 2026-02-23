namespace Fibo.FBC.FunctionalEntities.EuropeanEntities.EUFinancialServicesEntities.Namespace
module EUFinancialServicesEntities =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities.rdf") (Some @"fibo.FBC.FunctionalEntities.EuropeanEntities.EUFinancialServicesEntities") None
    let CRDCreditInstitution = {_prefixID with _localName = "CRDCreditInstitution"}
    let CreditInstitution = {_prefixID with _localName = "CreditInstitution"}
    let CreditInstitutionInvestmentFirm = {_prefixID with _localName = "CreditInstitutionInvestmentFirm"}
    let EuropeanEconomicAreaBranch = {_prefixID with _localName = "EuropeanEconomicAreaBranch"}
    let InvestmentFirm = {_prefixID with _localName = "InvestmentFirm"}
    let LocalFirm = {_prefixID with _localName = "LocalFirm"}
    let NonEuropeanEconomicAreaBranch = {_prefixID with _localName = "NonEuropeanEconomicAreaBranch"}
    let PaymentInstitution = {_prefixID with _localName = "PaymentInstitution"}