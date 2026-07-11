namespace Fibo.BE.OwnershipAndControl.OwnershipParties.Namespace
module OwnershipParties =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/BE/OwnershipAndControl/OwnershipParties.rdf") (Some @"fibo.BE.OwnershipAndControl.OwnershipParties") None
    let ConstitutionalOwner = {_prefixID with _localName = "ConstitutionalOwner"}
    let ControllingEquity = {_prefixID with _localName = "ControllingEquity"}
    let DirectConsolidation = {_prefixID with _localName = "DirectConsolidation"}
    let EntityOwner = {_prefixID with _localName = "EntityOwner"}
    let EntityOwnership = {_prefixID with _localName = "EntityOwnership"}
    let ForeignBranchOwnership = {_prefixID with _localName = "ForeignBranchOwnership"}
    let InvestmentEquity = {_prefixID with _localName = "InvestmentEquity"}
    let Investor = {_prefixID with _localName = "Investor"}
    let InvestorContract = {_prefixID with _localName = "InvestorContract"}
    let UltimateConsolidation = {_prefixID with _localName = "UltimateConsolidation"}
    let guarantees = {_prefixID with _localName = "guarantees"}
    let hasDirectOwnership = {_prefixID with _localName = "hasDirectOwnership"}
    let hasDirectOwningEntity = {_prefixID with _localName = "hasDirectOwningEntity"}
    let hasInvestmentEntity = {_prefixID with _localName = "hasInvestmentEntity"}
    let hasInvestmentOwnership = {_prefixID with _localName = "hasInvestmentOwnership"}
    let hasOwnedEntity = {_prefixID with _localName = "hasOwnedEntity"}
    let hasOwningEntity = {_prefixID with _localName = "hasOwningEntity"}