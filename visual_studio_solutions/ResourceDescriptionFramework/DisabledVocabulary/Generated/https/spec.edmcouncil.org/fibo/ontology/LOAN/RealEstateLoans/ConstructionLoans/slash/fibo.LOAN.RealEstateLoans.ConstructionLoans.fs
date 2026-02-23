namespace Fibo.LOAN.RealEstateLoans.ConstructionLoans.Namespace
module ConstructionLoans =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/ConstructionLoans/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/LOAN/RealEstateLoans/ConstructionLoans.rdf") (Some @"fibo.LOAN.RealEstateLoans.ConstructionLoans") None
    let ConstructionLoan = {_prefixID with _localName = "ConstructionLoan"}
    let hasMaximumAllowedBalance = {_prefixID with _localName = "hasMaximumAllowedBalance"}
    let hasMaximumAnticipatedBalance = {_prefixID with _localName = "hasMaximumAnticipatedBalance"}
    let hasMilestoneMaximumDrawdownAmount = {_prefixID with _localName = "hasMilestoneMaximumDrawdownAmount"}