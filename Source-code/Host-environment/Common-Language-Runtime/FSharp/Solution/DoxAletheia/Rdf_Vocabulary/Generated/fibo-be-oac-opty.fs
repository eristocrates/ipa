namespace https.spec.edmcouncil.org.fibo.ontology.BE.OwnershipAndControl.OwnershipParties.slash

open DoxAletheia

module fibo_be_oac_opty =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/EntityOwnership"></see>
    /// </summary>
    let EntityOwnership = _prefix "EntityOwnership"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/ConstitutionalOwner"></see>
    /// </summary>
    let ConstitutionalOwner = _prefix "ConstitutionalOwner"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/EntityOwner"></see>
    /// </summary>
    let EntityOwner = _prefix "EntityOwner"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/ControllingEquity"></see>
    /// </summary>
    let ControllingEquity = _prefix "ControllingEquity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/DirectConsolidation"></see>
    /// </summary>
    let DirectConsolidation = _prefix "DirectConsolidation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/hasOwnedEntity"></see>
    /// </summary>
    let hasOwnedEntity = _prefix "hasOwnedEntity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/hasOwningEntity"></see>
    /// </summary>
    let hasOwningEntity = _prefix "hasOwningEntity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/ForeignBranchOwnership"></see>
    /// </summary>
    let ForeignBranchOwnership = _prefix "ForeignBranchOwnership"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/InvestmentEquity"></see>
    /// </summary>
    let InvestmentEquity = _prefix "InvestmentEquity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/Investor"></see>
    /// </summary>
    let Investor = _prefix "Investor"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/InvestorContract"></see>
    /// </summary>
    let InvestorContract = _prefix "InvestorContract"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/UltimateConsolidation"></see>
    /// </summary>
    let UltimateConsolidation = _prefix "UltimateConsolidation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/guarantees"></see>
    /// </summary>
    let guarantees = _prefix "guarantees"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/hasDirectOwnership"></see>
    /// </summary>
    let hasDirectOwnership = _prefix "hasDirectOwnership"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/hasDirectOwningEntity"></see>
    /// </summary>
    let hasDirectOwningEntity = _prefix "hasDirectOwningEntity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/hasInvestmentEntity"></see>
    /// </summary>
    let hasInvestmentEntity = _prefix "hasInvestmentEntity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/hasInvestmentOwnership"></see>
    /// </summary>
    let hasInvestmentOwnership = _prefix "hasInvestmentOwnership"
