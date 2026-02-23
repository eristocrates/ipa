namespace Fibo.LOAN.LoansSpecific.CommercialLoans.Namespace
module CommercialLoans =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CommercialLoans/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/LOAN/LoansSpecific/CommercialLoans.rdf") (Some @"fibo.LOAN.LoansSpecific.CommercialLoans") None
    let CommercialLoan = {_prefixID with _localName = "CommercialLoan"}
    let hasBusinessPurposeDescription = {_prefixID with _localName = "hasBusinessPurposeDescription"}