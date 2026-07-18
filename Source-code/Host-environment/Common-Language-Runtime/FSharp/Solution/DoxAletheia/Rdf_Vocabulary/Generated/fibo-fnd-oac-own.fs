namespace https.spec.edmcouncil.org.fibo.ontology.FND.OwnershipAndControl.Ownership.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_oac_own =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/Asset"></see>
    /// </summary>
    let Asset = Namespaced_IRI.parse _namespace_name "Asset" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/isAssetOf"></see>
    /// </summary>
    let isAssetOf = Namespaced_IRI.parse _namespace_name "isAssetOf" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/Owner"></see>
    /// </summary>
    let Owner = Namespaced_IRI.parse _namespace_name "Owner" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/isOwnedAsset"></see>
    /// </summary>
    let isOwnedAsset =
        Namespaced_IRI.parse _namespace_name "isOwnedAsset" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/Ownership"></see>
    /// </summary>
    let Ownership = Namespaced_IRI.parse _namespace_name "Ownership" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/IntangibleAsset"></see>
    /// </summary>
    let IntangibleAsset =
        Namespaced_IRI.parse _namespace_name "IntangibleAsset" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/TangibleAsset"></see>
    /// </summary>
    let TangibleAsset =
        Namespaced_IRI.parse _namespace_name "TangibleAsset" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/isOwningParty"></see>
    /// </summary>
    let isOwningParty =
        Namespaced_IRI.parse _namespace_name "isOwningParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/ownsAsset"></see>
    /// </summary>
    let ownsAsset = Namespaced_IRI.parse _namespace_name "ownsAsset" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/hasOwnedAsset"></see>
    /// </summary>
    let hasOwnedAsset =
        Namespaced_IRI.parse _namespace_name "hasOwnedAsset" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/hasOwningParty"></see>
    /// </summary>
    let hasOwningParty =
        Namespaced_IRI.parse _namespace_name "hasOwningParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/isOwnedBy"></see>
    /// </summary>
    let isOwnedBy = Namespaced_IRI.parse _namespace_name "isOwnedBy" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/owns"></see>
    /// </summary>
    let owns = Namespaced_IRI.parse _namespace_name "owns" |> NamespacedName
