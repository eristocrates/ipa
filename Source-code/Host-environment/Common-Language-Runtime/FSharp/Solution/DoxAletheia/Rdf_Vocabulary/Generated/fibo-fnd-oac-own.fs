namespace https.spec.edmcouncil.org.fibo.ontology.FND.OwnershipAndControl.Ownership.slash

open DoxAletheia

module fibo_fnd_oac_own =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/Asset"></see>
    /// </summary>
    let Asset = _prefix "Asset"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/isAssetOf"></see>
    /// </summary>
    let isAssetOf = _prefix "isAssetOf"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/Owner"></see>
    /// </summary>
    let Owner = _prefix "Owner"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/isOwnedAsset"></see>
    /// </summary>
    let isOwnedAsset = _prefix "isOwnedAsset"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/Ownership"></see>
    /// </summary>
    let Ownership = _prefix "Ownership"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/IntangibleAsset"></see>
    /// </summary>
    let IntangibleAsset = _prefix "IntangibleAsset"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/TangibleAsset"></see>
    /// </summary>
    let TangibleAsset = _prefix "TangibleAsset"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/isOwningParty"></see>
    /// </summary>
    let isOwningParty = _prefix "isOwningParty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/ownsAsset"></see>
    /// </summary>
    let ownsAsset = _prefix "ownsAsset"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/hasOwnedAsset"></see>
    /// </summary>
    let hasOwnedAsset = _prefix "hasOwnedAsset"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/hasOwningParty"></see>
    /// </summary>
    let hasOwningParty = _prefix "hasOwningParty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/isOwnedBy"></see>
    /// </summary>
    let isOwnedBy = _prefix "isOwnedBy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/owns"></see>
    /// </summary>
    let owns = _prefix "owns"
