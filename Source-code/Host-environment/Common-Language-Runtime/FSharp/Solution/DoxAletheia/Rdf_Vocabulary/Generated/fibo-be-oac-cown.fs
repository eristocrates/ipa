namespace https.spec.edmcouncil.org.fibo.ontology.BE.OwnershipAndControl.CorporateOwnership.slash

open DoxAletheia

module fibo_be_oac_cown =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/BeneficialOwner"></see>
    /// </summary>
    let BeneficialOwner = _prefix "BeneficialOwner"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/isBeneficialOwnerOf"></see>
    /// </summary>
    let isBeneficialOwnerOf = _prefix "isBeneficialOwnerOf"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/BeneficialOwnership"></see>
    /// </summary>
    let BeneficialOwnership = _prefix "BeneficialOwnership"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/PurchaseLot"></see>
    /// </summary>
    let PurchaseLot = _prefix "PurchaseLot"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/consistsOfNumberOfUnits"></see>
    /// </summary>
    let consistsOfNumberOfUnits = _prefix "consistsOfNumberOfUnits"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/Shareholder"></see>
    /// </summary>
    let Shareholder = _prefix "Shareholder"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/Shareholding"></see>
    /// </summary>
    let Shareholding = _prefix "Shareholding"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/TaxLot"></see>
    /// </summary>
    let TaxLot = _prefix "TaxLot"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/hasBeneficialOwner"></see>
    /// </summary>
    let hasBeneficialOwner = _prefix "hasBeneficialOwner"
