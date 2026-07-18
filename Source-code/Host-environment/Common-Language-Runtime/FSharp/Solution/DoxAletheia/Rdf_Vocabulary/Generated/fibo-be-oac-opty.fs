namespace https.spec.edmcouncil.org.fibo.ontology.BE.OwnershipAndControl.OwnershipParties.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_be_oac_opty =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/EntityOwnership"></see>
    /// </summary>
    let EntityOwnership =
        Namespaced_IRI.parse _namespace_name "EntityOwnership" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/ConstitutionalOwner"></see>
    /// </summary>
    let ConstitutionalOwner =
        Namespaced_IRI.parse _namespace_name "ConstitutionalOwner" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/EntityOwner"></see>
    /// </summary>
    let EntityOwner =
        Namespaced_IRI.parse _namespace_name "EntityOwner" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/ControllingEquity"></see>
    /// </summary>
    let ControllingEquity =
        Namespaced_IRI.parse _namespace_name "ControllingEquity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/DirectConsolidation"></see>
    /// </summary>
    let DirectConsolidation =
        Namespaced_IRI.parse _namespace_name "DirectConsolidation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/hasOwnedEntity"></see>
    /// </summary>
    let hasOwnedEntity =
        Namespaced_IRI.parse _namespace_name "hasOwnedEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/hasOwningEntity"></see>
    /// </summary>
    let hasOwningEntity =
        Namespaced_IRI.parse _namespace_name "hasOwningEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/ForeignBranchOwnership"></see>
    /// </summary>
    let ForeignBranchOwnership =
        Namespaced_IRI.parse _namespace_name "ForeignBranchOwnership" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/InvestmentEquity"></see>
    /// </summary>
    let InvestmentEquity =
        Namespaced_IRI.parse _namespace_name "InvestmentEquity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/Investor"></see>
    /// </summary>
    let Investor = Namespaced_IRI.parse _namespace_name "Investor" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/InvestorContract"></see>
    /// </summary>
    let InvestorContract =
        Namespaced_IRI.parse _namespace_name "InvestorContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/UltimateConsolidation"></see>
    /// </summary>
    let UltimateConsolidation =
        Namespaced_IRI.parse _namespace_name "UltimateConsolidation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/guarantees"></see>
    /// </summary>
    let guarantees = Namespaced_IRI.parse _namespace_name "guarantees" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/hasDirectOwnership"></see>
    /// </summary>
    let hasDirectOwnership =
        Namespaced_IRI.parse _namespace_name "hasDirectOwnership" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/hasDirectOwningEntity"></see>
    /// </summary>
    let hasDirectOwningEntity =
        Namespaced_IRI.parse _namespace_name "hasDirectOwningEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/hasInvestmentEntity"></see>
    /// </summary>
    let hasInvestmentEntity =
        Namespaced_IRI.parse _namespace_name "hasInvestmentEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/hasInvestmentOwnership"></see>
    /// </summary>
    let hasInvestmentOwnership =
        Namespaced_IRI.parse _namespace_name "hasInvestmentOwnership" |> NamespacedName
