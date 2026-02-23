namespace Fibo.MD.TemporalCore.SecurityCreditStatuses.Namespace
module SecurityCreditStatuses =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/MD/TemporalCore/SecurityCreditStatuses/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/MD/TemporalCore/SecurityCreditStatuses.rdf") (Some @"fibo.MD.TemporalCore.SecurityCreditStatuses") None
    let CreditOK = {_prefixID with _localName = "CreditOK"}
    let InDefault = {_prefixID with _localName = "InDefault"}
    let SecurityCashflowStatus = {_prefixID with _localName = "SecurityCashflowStatus"}
    let SecurityCreditStatus = {_prefixID with _localName = "SecurityCreditStatus"}
    let acceleratedPrincipalPaymentsExpected = {_prefixID with _localName = "acceleratedPrincipalPaymentsExpected"}
    let interestPaymentsExpected = {_prefixID with _localName = "interestPaymentsExpected"}
    let principalPaymentsExpected = {_prefixID with _localName = "principalPaymentsExpected"}