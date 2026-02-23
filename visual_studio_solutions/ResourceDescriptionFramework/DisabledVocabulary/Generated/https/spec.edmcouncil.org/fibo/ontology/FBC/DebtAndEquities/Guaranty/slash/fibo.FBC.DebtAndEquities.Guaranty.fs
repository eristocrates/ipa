namespace Fibo.FBC.DebtAndEquities.Guaranty.Namespace
module Guaranty =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/FBC/DebtAndEquities/Guaranty.rdf") (Some @"fibo.FBC.DebtAndEquities.Guaranty") None
    let CollateralizedGuaranty = {_prefixID with _localName = "CollateralizedGuaranty"}
    let GovernmentGuaranty = {_prefixID with _localName = "GovernmentGuaranty"}
    let Guarantor = {_prefixID with _localName = "Guarantor"}
    let Guaranty = {_prefixID with _localName = "Guaranty"}
    let InsuranceBackedGuaranty = {_prefixID with _localName = "InsuranceBackedGuaranty"}
    let InsurancePolicy = {_prefixID with _localName = "InsurancePolicy"}
    let Insurer = {_prefixID with _localName = "Insurer"}
    let JointGuaranty = {_prefixID with _localName = "JointGuaranty"}
    let LetterOfCredit = {_prefixID with _localName = "LetterOfCredit"}
    let LetterOfCreditGuaranty = {_prefixID with _localName = "LetterOfCreditGuaranty"}
    let NegativePledge = {_prefixID with _localName = "NegativePledge"}
    let Policyholder = {_prefixID with _localName = "Policyholder"}
    let PriorityLevel = {_prefixID with _localName = "PriorityLevel"}
    let hasGuaranteedAmount = {_prefixID with _localName = "hasGuaranteedAmount"}
    let hasGuarantor = {_prefixID with _localName = "hasGuarantor"}
    let hasGuarantorParty = {_prefixID with _localName = "hasGuarantorParty"}
    let hasPriorityLevel = {_prefixID with _localName = "hasPriorityLevel"}
    let isGuaranteedBy = {_prefixID with _localName = "isGuaranteedBy"}
    let isGuarantorOf = {_prefixID with _localName = "isGuarantorOf"}