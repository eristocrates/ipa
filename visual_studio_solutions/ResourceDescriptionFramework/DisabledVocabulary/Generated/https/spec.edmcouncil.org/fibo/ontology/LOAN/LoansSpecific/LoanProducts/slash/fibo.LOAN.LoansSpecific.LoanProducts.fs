namespace Fibo.LOAN.LoansSpecific.LoanProducts.Namespace
module LoanProducts =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/LoanProducts/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/LOAN/LoansSpecific/LoanProducts.rdf") (Some @"fibo.LOAN.LoansSpecific.LoanProducts") None
    let AutoLoanPurpose = {_prefixID with _localName = "AutoLoanPurpose"}
    let BridgingLoanPurpose = {_prefixID with _localName = "BridgingLoanPurpose"}
    let ConstructionLoanPurpose = {_prefixID with _localName = "ConstructionLoanPurpose"}
    let CreditCardReceivablePurpose = {_prefixID with _localName = "CreditCardReceivablePurpose"}
    let HomeEquityLoanPurpose = {_prefixID with _localName = "HomeEquityLoanPurpose"}
    let LineItem = {_prefixID with _localName = "LineItem"}
    let LoanMarketCategory = {_prefixID with _localName = "LoanMarketCategory"}
    let ``LoanMarketCategory-Automobile`` = {_prefixID with _localName = "LoanMarketCategory-Automobile"}
    let ``LoanMarketCategory-Commercial`` = {_prefixID with _localName = "LoanMarketCategory-Commercial"}
    let ``LoanMarketCategory-Construction`` = {_prefixID with _localName = "LoanMarketCategory-Construction"}
    let ``LoanMarketCategory-Education`` = {_prefixID with _localName = "LoanMarketCategory-Education"}
    let ``LoanMarketCategory-Mortgage`` = {_prefixID with _localName = "LoanMarketCategory-Mortgage"}
    let ``LoanMarketCategory-Personal`` = {_prefixID with _localName = "LoanMarketCategory-Personal"}
    let ``LoanMarketCategory-SmallBusiness`` = {_prefixID with _localName = "LoanMarketCategory-SmallBusiness"}
    let LoanProduct = {_prefixID with _localName = "LoanProduct"}
    let LoanProductDisclosureRight = {_prefixID with _localName = "LoanProductDisclosureRight"}
    let LoanProductOffering = {_prefixID with _localName = "LoanProductOffering"}
    let LoanPurpose = {_prefixID with _localName = "LoanPurpose"}
    let MortgageProduct = {_prefixID with _localName = "MortgageProduct"}
    let MotorhomeLoanPurpose = {_prefixID with _localName = "MotorhomeLoanPurpose"}
    let OrdinaryLoanPurpose = {_prefixID with _localName = "OrdinaryLoanPurpose"}
    let OverdraftFacilityPurpose = {_prefixID with _localName = "OverdraftFacilityPurpose"}
    let ResidentialHouseboatLoanPurpose = {_prefixID with _localName = "ResidentialHouseboatLoanPurpose"}
    let StudentLoanPurpose = {_prefixID with _localName = "StudentLoanPurpose"}
    let WorkingCapitalPurpose = {_prefixID with _localName = "WorkingCapitalPurpose"}
    let hasPreconditions = {_prefixID with _localName = "hasPreconditions"}
    let hasUnitCost = {_prefixID with _localName = "hasUnitCost"}