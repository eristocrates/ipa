namespace https.spec.edmcouncil.org.fibo.ontology.BE.OwnershipAndControl.CorporateOwnership.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_be_oac_cown =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/BeneficialOwner"></see>
    /// </summary>
    let BeneficialOwner =
        Namespaced_IRI.parse _namespace_name "BeneficialOwner" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/isBeneficialOwnerOf"></see>
    /// </summary>
    let isBeneficialOwnerOf =
        Namespaced_IRI.parse _namespace_name "isBeneficialOwnerOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/BeneficialOwnership"></see>
    /// </summary>
    let BeneficialOwnership =
        Namespaced_IRI.parse _namespace_name "BeneficialOwnership" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/PurchaseLot"></see>
    /// </summary>
    let PurchaseLot =
        Namespaced_IRI.parse _namespace_name "PurchaseLot" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/consistsOfNumberOfUnits"></see>
    /// </summary>
    let consistsOfNumberOfUnits =
        Namespaced_IRI.parse _namespace_name "consistsOfNumberOfUnits" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/Shareholder"></see>
    /// </summary>
    let Shareholder =
        Namespaced_IRI.parse _namespace_name "Shareholder" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/Shareholding"></see>
    /// </summary>
    let Shareholding =
        Namespaced_IRI.parse _namespace_name "Shareholding" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/TaxLot"></see>
    /// </summary>
    let TaxLot = Namespaced_IRI.parse _namespace_name "TaxLot" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/hasBeneficialOwner"></see>
    /// </summary>
    let hasBeneficialOwner =
        Namespaced_IRI.parse _namespace_name "hasBeneficialOwner" |> NamespacedName
