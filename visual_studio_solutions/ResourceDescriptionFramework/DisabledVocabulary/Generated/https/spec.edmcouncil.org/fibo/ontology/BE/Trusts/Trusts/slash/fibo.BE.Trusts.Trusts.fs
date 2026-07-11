namespace Fibo.BE.Trusts.Trusts.Namespace
module Trusts =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/BE/Trusts/Trusts.rdf") (Some @"fibo.BE.Trusts.Trusts") None
    let IrrevocableTrust = {_prefixID with _localName = "IrrevocableTrust"}
    let LivingTrust = {_prefixID with _localName = "LivingTrust"}
    let RevocableTrust = {_prefixID with _localName = "RevocableTrust"}
    let TestamentaryTrust = {_prefixID with _localName = "TestamentaryTrust"}
    let Trust = {_prefixID with _localName = "Trust"}
    let TrustAgreement = {_prefixID with _localName = "TrustAgreement"}
    let TrustBeneficiary = {_prefixID with _localName = "TrustBeneficiary"}
    let TrustFundManager = {_prefixID with _localName = "TrustFundManager"}
    let Trustee = {_prefixID with _localName = "Trustee"}
    let Trustor = {_prefixID with _localName = "Trustor"}
    let hasBeneficiary = {_prefixID with _localName = "hasBeneficiary"}
    let hasTrustee = {_prefixID with _localName = "hasTrustee"}
    let isBeneficiaryOf = {_prefixID with _localName = "isBeneficiaryOf"}
    let isTrusteeOf = {_prefixID with _localName = "isTrusteeOf"}