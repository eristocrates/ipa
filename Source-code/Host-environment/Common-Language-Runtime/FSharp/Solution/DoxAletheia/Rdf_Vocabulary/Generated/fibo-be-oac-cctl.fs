namespace https.spec.edmcouncil.org.fibo.ontology.BE.OwnershipAndControl.CorporateControl.slash

open DoxAletheia

module fibo_be_oac_cctl =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/Affiliate"></see>
    /// </summary>
    let Affiliate = _prefix "Affiliate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/isAffiliateOf"></see>
    /// </summary>
    let isAffiliateOf = _prefix "isAffiliateOf"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/Affiliation"></see>
    /// </summary>
    let Affiliation = _prefix "Affiliation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/ControllingAffiliate"></see>
    /// </summary>
    let ControllingAffiliate = _prefix "ControllingAffiliate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/ControlledAffiliate"></see>
    /// </summary>
    let ControlledAffiliate = _prefix "ControlledAffiliate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/DomesticUltimateParent"></see>
    /// </summary>
    let DomesticUltimateParent = _prefix "DomesticUltimateParent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/TotalControllingInterestParty"></see>
    /// </summary>
    let TotalControllingInterestParty = _prefix "TotalControllingInterestParty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/GlobalUltimateParent"></see>
    /// </summary>
    let GlobalUltimateParent = _prefix "GlobalUltimateParent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/JointVenturePartner"></see>
    /// </summary>
    let JointVenturePartner = _prefix "JointVenturePartner"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/SignificantShareholder"></see>
    /// </summary>
    let SignificantShareholder = _prefix "SignificantShareholder"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/VotingShareholder"></see>
    /// </summary>
    let VotingShareholder = _prefix "VotingShareholder"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/Subsidiary"></see>
    /// </summary>
    let Subsidiary = _prefix "Subsidiary"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/hasAffiliate"></see>
    /// </summary>
    let hasAffiliate = _prefix "hasAffiliate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/hasControllingAffiliate"></see>
    /// </summary>
    let hasControllingAffiliate = _prefix "hasControllingAffiliate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/hasDomesticUltimateParent"></see>
    /// </summary>
    let hasDomesticUltimateParent = _prefix "hasDomesticUltimateParent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/hasGlobalUltimateParent"></see>
    /// </summary>
    let hasGlobalUltimateParent = _prefix "hasGlobalUltimateParent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/hasSubsidiary"></see>
    /// </summary>
    let hasSubsidiary = _prefix "hasSubsidiary"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/isParentCompanyOf"></see>
    /// </summary>
    let isParentCompanyOf = _prefix "isParentCompanyOf"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/isControllingAffiliateOf"></see>
    /// </summary>
    let isControllingAffiliateOf = _prefix "isControllingAffiliateOf"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/isSubsidiaryOf"></see>
    /// </summary>
    let isSubsidiaryOf = _prefix "isSubsidiaryOf"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/isWhollyOwnedBy"></see>
    /// </summary>
    let isWhollyOwnedBy = _prefix "isWhollyOwnedBy"
