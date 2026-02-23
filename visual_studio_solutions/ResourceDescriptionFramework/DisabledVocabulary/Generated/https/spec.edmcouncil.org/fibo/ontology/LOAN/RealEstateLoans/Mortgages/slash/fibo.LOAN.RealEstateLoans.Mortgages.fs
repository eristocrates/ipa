namespace Fibo.LOAN.RealEstateLoans.Mortgages.Namespace
module Mortgages =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/LOAN/RealEstateLoans/Mortgages.rdf") (Some @"fibo.LOAN.RealEstateLoans.Mortgages") None
    let ClosedEndMortgageLoan = {_prefixID with _localName = "ClosedEndMortgageLoan"}
    let ClosedEndReverseMortgage = {_prefixID with _localName = "ClosedEndReverseMortgage"}
    let LoanSecuredByRealEstate = {_prefixID with _localName = "LoanSecuredByRealEstate"}
    let Mortgage = {_prefixID with _localName = "Mortgage"}
    let OpenEndMortgageLoan = {_prefixID with _localName = "OpenEndMortgageLoan"}
    let OpenEndReverseMortgage = {_prefixID with _localName = "OpenEndReverseMortgage"}
    let ReverseMortgageLoan = {_prefixID with _localName = "ReverseMortgageLoan"}
    let hasInitialFundingDate = {_prefixID with _localName = "hasInitialFundingDate"}
    let isARMConvertible = {_prefixID with _localName = "isARMConvertible"}