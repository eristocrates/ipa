namespace Fibo.BE.OwnershipAndControl.CorporateOwnership.Namespace
module CorporateOwnership =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/BE/OwnershipAndControl/CorporateOwnership.rdf") (Some @"fibo.BE.OwnershipAndControl.CorporateOwnership") None
    let BeneficialOwner = {_prefixID with _localName = "BeneficialOwner"}
    let BeneficialOwnership = {_prefixID with _localName = "BeneficialOwnership"}
    let PurchaseLot = {_prefixID with _localName = "PurchaseLot"}
    let Shareholder = {_prefixID with _localName = "Shareholder"}
    let Shareholding = {_prefixID with _localName = "Shareholding"}
    let TaxLot = {_prefixID with _localName = "TaxLot"}
    let consistsOfNumberOfUnits = {_prefixID with _localName = "consistsOfNumberOfUnits"}
    let hasBeneficialOwner = {_prefixID with _localName = "hasBeneficialOwner"}
    let isBeneficialOwnerOf = {_prefixID with _localName = "isBeneficialOwnerOf"}