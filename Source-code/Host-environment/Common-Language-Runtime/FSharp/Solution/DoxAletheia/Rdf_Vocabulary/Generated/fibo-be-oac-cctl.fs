namespace https.spec.edmcouncil.org.fibo.ontology.BE.OwnershipAndControl.CorporateControl.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_be_oac_cctl =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/Affiliate"></see>
    /// </summary>
    let Affiliate = Namespaced_IRI.parse _namespace_name "Affiliate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/isAffiliateOf"></see>
    /// </summary>
    let isAffiliateOf =
        Namespaced_IRI.parse _namespace_name "isAffiliateOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/Affiliation"></see>
    /// </summary>
    let Affiliation =
        Namespaced_IRI.parse _namespace_name "Affiliation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/ControllingAffiliate"></see>
    /// </summary>
    let ControllingAffiliate =
        Namespaced_IRI.parse _namespace_name "ControllingAffiliate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/ControlledAffiliate"></see>
    /// </summary>
    let ControlledAffiliate =
        Namespaced_IRI.parse _namespace_name "ControlledAffiliate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/DomesticUltimateParent"></see>
    /// </summary>
    let DomesticUltimateParent =
        Namespaced_IRI.parse _namespace_name "DomesticUltimateParent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/TotalControllingInterestParty"></see>
    /// </summary>
    let TotalControllingInterestParty =
        Namespaced_IRI.parse _namespace_name "TotalControllingInterestParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/GlobalUltimateParent"></see>
    /// </summary>
    let GlobalUltimateParent =
        Namespaced_IRI.parse _namespace_name "GlobalUltimateParent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/JointVenturePartner"></see>
    /// </summary>
    let JointVenturePartner =
        Namespaced_IRI.parse _namespace_name "JointVenturePartner" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/SignificantShareholder"></see>
    /// </summary>
    let SignificantShareholder =
        Namespaced_IRI.parse _namespace_name "SignificantShareholder" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/VotingShareholder"></see>
    /// </summary>
    let VotingShareholder =
        Namespaced_IRI.parse _namespace_name "VotingShareholder" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/Subsidiary"></see>
    /// </summary>
    let Subsidiary = Namespaced_IRI.parse _namespace_name "Subsidiary" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/hasAffiliate"></see>
    /// </summary>
    let hasAffiliate =
        Namespaced_IRI.parse _namespace_name "hasAffiliate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/hasControllingAffiliate"></see>
    /// </summary>
    let hasControllingAffiliate =
        Namespaced_IRI.parse _namespace_name "hasControllingAffiliate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/hasDomesticUltimateParent"></see>
    /// </summary>
    let hasDomesticUltimateParent =
        Namespaced_IRI.parse _namespace_name "hasDomesticUltimateParent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/hasGlobalUltimateParent"></see>
    /// </summary>
    let hasGlobalUltimateParent =
        Namespaced_IRI.parse _namespace_name "hasGlobalUltimateParent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/hasSubsidiary"></see>
    /// </summary>
    let hasSubsidiary =
        Namespaced_IRI.parse _namespace_name "hasSubsidiary" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/isParentCompanyOf"></see>
    /// </summary>
    let isParentCompanyOf =
        Namespaced_IRI.parse _namespace_name "isParentCompanyOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/isControllingAffiliateOf"></see>
    /// </summary>
    let isControllingAffiliateOf =
        Namespaced_IRI.parse _namespace_name "isControllingAffiliateOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/isSubsidiaryOf"></see>
    /// </summary>
    let isSubsidiaryOf =
        Namespaced_IRI.parse _namespace_name "isSubsidiaryOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/isWhollyOwnedBy"></see>
    /// </summary>
    let isWhollyOwnedBy =
        Namespaced_IRI.parse _namespace_name "isWhollyOwnedBy" |> NamespacedName
