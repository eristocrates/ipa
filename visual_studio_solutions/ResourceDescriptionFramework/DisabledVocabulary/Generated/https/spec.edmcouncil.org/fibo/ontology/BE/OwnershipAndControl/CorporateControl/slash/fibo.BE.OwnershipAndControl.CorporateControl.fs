namespace Fibo.BE.OwnershipAndControl.CorporateControl.Namespace
module CorporateControl =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/BE/OwnershipAndControl/CorporateControl.rdf") (Some @"fibo.BE.OwnershipAndControl.CorporateControl") None
    let Affiliate = {_prefixID with _localName = "Affiliate"}
    let Affiliation = {_prefixID with _localName = "Affiliation"}
    let ControlledAffiliate = {_prefixID with _localName = "ControlledAffiliate"}
    let ControllingAffiliate = {_prefixID with _localName = "ControllingAffiliate"}
    let DomesticUltimateParent = {_prefixID with _localName = "DomesticUltimateParent"}
    let GlobalUltimateParent = {_prefixID with _localName = "GlobalUltimateParent"}
    let JointVenturePartner = {_prefixID with _localName = "JointVenturePartner"}
    let SignificantShareholder = {_prefixID with _localName = "SignificantShareholder"}
    let Subsidiary = {_prefixID with _localName = "Subsidiary"}
    let TotalControllingInterestParty = {_prefixID with _localName = "TotalControllingInterestParty"}
    let VotingShareholder = {_prefixID with _localName = "VotingShareholder"}
    let hasAffiliate = {_prefixID with _localName = "hasAffiliate"}
    let hasControllingAffiliate = {_prefixID with _localName = "hasControllingAffiliate"}
    let hasDomesticUltimateParent = {_prefixID with _localName = "hasDomesticUltimateParent"}
    let hasGlobalUltimateParent = {_prefixID with _localName = "hasGlobalUltimateParent"}
    let hasSubsidiary = {_prefixID with _localName = "hasSubsidiary"}
    let isAffiliateOf = {_prefixID with _localName = "isAffiliateOf"}
    let isControllingAffiliateOf = {_prefixID with _localName = "isControllingAffiliateOf"}
    let isParentCompanyOf = {_prefixID with _localName = "isParentCompanyOf"}
    let isSubsidiaryOf = {_prefixID with _localName = "isSubsidiaryOf"}
    let isWhollyOwnedBy = {_prefixID with _localName = "isWhollyOwnedBy"}