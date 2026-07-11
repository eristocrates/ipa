namespace Fibo.SEC.Debt.DistributedLoans.Namespace
module DistributedLoans =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/SEC/Debt/DistributedLoans.rdf") (Some @"fibo.SEC.Debt.DistributedLoans") None
    let AdministrativeAgent = {_prefixID with _localName = "AdministrativeAgent"}
    let Bookrunner = {_prefixID with _localName = "Bookrunner"}
    let DocumentationAgent = {_prefixID with _localName = "DocumentationAgent"}
    let FinanceSyndicate = {_prefixID with _localName = "FinanceSyndicate"}
    let FinanceSyndicateMember = {_prefixID with _localName = "FinanceSyndicateMember"}
    let LeadArranger = {_prefixID with _localName = "LeadArranger"}
    let LoanParticipationNote = {_prefixID with _localName = "LoanParticipationNote"}
    let SyndicatedLoan = {_prefixID with _localName = "SyndicatedLoan"}
    let SyndicationAgent = {_prefixID with _localName = "SyndicationAgent"}