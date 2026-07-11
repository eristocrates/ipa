namespace Fibo.SEC.Securities.SecuritiesRestrictions.Namespace
module SecuritiesRestrictions =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/SEC/Securities/SecuritiesRestrictions.rdf") (Some @"fibo.SEC.Securities.SecuritiesRestrictions") None
    let ContractualRestriction = {_prefixID with _localName = "ContractualRestriction"}
    let IndividualInvestor = {_prefixID with _localName = "IndividualInvestor"}
    let InstitutionalInvestor = {_prefixID with _localName = "InstitutionalInvestor"}
    let InvestorsDomicileRestriction = {_prefixID with _localName = "InvestorsDomicileRestriction"}
    let LegalHoldingRestriction = {_prefixID with _localName = "LegalHoldingRestriction"}
    let QualifiedInvestorRestriction = {_prefixID with _localName = "QualifiedInvestorRestriction"}
    let SecuritiesRegulation = {_prefixID with _localName = "SecuritiesRegulation"}
    let SecuritiesRestriction = {_prefixID with _localName = "SecuritiesRestriction"}
    let TradingRestriction = {_prefixID with _localName = "TradingRestriction"}
    let hasHoldingPeriod = {_prefixID with _localName = "hasHoldingPeriod"}
    let hasRestriction = {_prefixID with _localName = "hasRestriction"}