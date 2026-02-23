namespace Fibo.BE.Partnerships.Partnerships.Namespace
module Partnerships =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/BE/Partnerships/Partnerships.rdf") (Some @"fibo.BE.Partnerships.Partnerships") None
    let GeneralPartner = {_prefixID with _localName = "GeneralPartner"}
    let GeneralPartnership = {_prefixID with _localName = "GeneralPartnership"}
    let LimitedLiabilityLimitedPartnership = {_prefixID with _localName = "LimitedLiabilityLimitedPartnership"}
    let LimitedLiabilityPartnership = {_prefixID with _localName = "LimitedLiabilityPartnership"}
    let LimitedPartner = {_prefixID with _localName = "LimitedPartner"}
    let LimitedPartnership = {_prefixID with _localName = "LimitedPartnership"}
    let Partner = {_prefixID with _localName = "Partner"}
    let Partnership = {_prefixID with _localName = "Partnership"}
    let PartnershipAgreement = {_prefixID with _localName = "PartnershipAgreement"}
    let hasGeneralPartner = {_prefixID with _localName = "hasGeneralPartner"}
    let hasLimitedPartner = {_prefixID with _localName = "hasLimitedPartner"}
    let isGeneralPartnerOf = {_prefixID with _localName = "isGeneralPartnerOf"}
    let isLimitedPartnerOf = {_prefixID with _localName = "isLimitedPartnerOf"}