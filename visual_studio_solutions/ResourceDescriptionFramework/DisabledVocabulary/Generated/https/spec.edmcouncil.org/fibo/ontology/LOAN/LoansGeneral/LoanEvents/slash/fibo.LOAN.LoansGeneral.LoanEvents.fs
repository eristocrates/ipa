namespace Fibo.LOAN.LoansGeneral.LoanEvents.Namespace
module LoanEvents =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/LoanEvents/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/LOAN/LoansGeneral/LoanEvents.rdf") (Some @"fibo.LOAN.LoansGeneral.LoanEvents") None
    let CollateralValuation = {_prefixID with _localName = "CollateralValuation"}
    let CourtJudgment = {_prefixID with _localName = "CourtJudgment"}
    let LegalProceeding = {_prefixID with _localName = "LegalProceeding"}
    let LoanDefaultProceeding = {_prefixID with _localName = "LoanDefaultProceeding"}
    let LoanPaidInFull = {_prefixID with _localName = "LoanPaidInFull"}
    let LoanPhase = {_prefixID with _localName = "LoanPhase"}
    let Prepayment = {_prefixID with _localName = "Prepayment"}
    let RepaymentPhase = {_prefixID with _localName = "RepaymentPhase"}
    let hasDefaultAmount = {_prefixID with _localName = "hasDefaultAmount"}
    let hasDisbursementDate = {_prefixID with _localName = "hasDisbursementDate"}
    let hasJudgementAmount = {_prefixID with _localName = "hasJudgementAmount"}
    let inDefault = {_prefixID with _localName = "inDefault"}
    let isAgainst = {_prefixID with _localName = "isAgainst"}
    let isDeferred = {_prefixID with _localName = "isDeferred"}
    let isDeliveredBy = {_prefixID with _localName = "isDeliveredBy"}