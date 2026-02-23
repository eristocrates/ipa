namespace Fibo.FBC.DebtAndEquities.CreditEvents.Namespace
module CreditEvents =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/FBC/DebtAndEquities/CreditEvents.rdf") (Some @"fibo.FBC.DebtAndEquities.CreditEvents") None
    let Bankruptcy = {_prefixID with _localName = "Bankruptcy"}
    let CreditEvent = {_prefixID with _localName = "CreditEvent"}
    let CrossDefaultProvision = {_prefixID with _localName = "CrossDefaultProvision"}
    let DefaultEvent = {_prefixID with _localName = "DefaultEvent"}
    let DistressedRatingsDowngrade = {_prefixID with _localName = "DistressedRatingsDowngrade"}
    let Downgrade = {_prefixID with _localName = "Downgrade"}
    let EntitySpecificCreditEvent = {_prefixID with _localName = "EntitySpecificCreditEvent"}
    let FailureToPay = {_prefixID with _localName = "FailureToPay"}
    let FailureToPayInterest = {_prefixID with _localName = "FailureToPayInterest"}
    let FailureToPayPrincipal = {_prefixID with _localName = "FailureToPayPrincipal"}
    let FilingForBankruptcy = {_prefixID with _localName = "FilingForBankruptcy"}
    let HardCreditEvent = {_prefixID with _localName = "HardCreditEvent"}
    let InstallmentDefault = {_prefixID with _localName = "InstallmentDefault"}
    let InterestObligationInLightOfDefault = {_prefixID with _localName = "InterestObligationInLightOfDefault"}
    let MaturityExtension = {_prefixID with _localName = "MaturityExtension"}
    let Moratorium = {_prefixID with _localName = "Moratorium"}
    let ObligationAcceleration = {_prefixID with _localName = "ObligationAcceleration"}
    let ObligationDefault = {_prefixID with _localName = "ObligationDefault"}
    let ObligationRestructuring = {_prefixID with _localName = "ObligationRestructuring"}
    let ObligationSpecificCreditEvent = {_prefixID with _localName = "ObligationSpecificCreditEvent"}
    let Repudiation = {_prefixID with _localName = "Repudiation"}
    let SoftCreditEvent = {_prefixID with _localName = "SoftCreditEvent"}
    let WriteDown = {_prefixID with _localName = "WriteDown"}
    let hasDefaultInterestCompoundingBasis = {_prefixID with _localName = "hasDefaultInterestCompoundingBasis"}
    let hasDefaultThresholdAmount = {_prefixID with _localName = "hasDefaultThresholdAmount"}
    let hasGracePeriod = {_prefixID with _localName = "hasGracePeriod"}
    let involvesMultipleEvents = {_prefixID with _localName = "involvesMultipleEvents"}
    let isDefaultInterestApplicable = {_prefixID with _localName = "isDefaultInterestApplicable"}
    let isGracePeriodExtendable = {_prefixID with _localName = "isGracePeriodExtendable"}