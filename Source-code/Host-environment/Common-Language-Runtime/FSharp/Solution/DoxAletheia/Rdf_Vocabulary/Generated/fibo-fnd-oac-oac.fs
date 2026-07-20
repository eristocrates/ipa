namespace https.spec.edmcouncil.org.fibo.ontology.FND.OwnershipAndControl.OwnershipAndControl.slash

open DoxAletheia

module fibo_fnd_oac_oac =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/OwnershipAndControl/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/OwnershipAndControl/OwnershipControlSituation"></see>
    /// </summary>
    let OwnershipControlSituation = _prefix "OwnershipControlSituation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/OwnershipAndControl/isOwnedAndControlledBy"></see>
    /// </summary>
    let isOwnedAndControlledBy = _prefix "isOwnedAndControlledBy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/OwnershipAndControl/ownsAndControls"></see>
    /// </summary>
    let ownsAndControls = _prefix "ownsAndControls"
