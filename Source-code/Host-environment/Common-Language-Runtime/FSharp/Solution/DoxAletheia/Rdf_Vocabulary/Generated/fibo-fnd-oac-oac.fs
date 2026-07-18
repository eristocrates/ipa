namespace https.spec.edmcouncil.org.fibo.ontology.FND.OwnershipAndControl.OwnershipAndControl.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_oac_oac =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/OwnershipAndControl/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/OwnershipAndControl/OwnershipControlSituation"></see>
    /// </summary>
    let OwnershipControlSituation =
        Namespaced_IRI.parse _namespace_name "OwnershipControlSituation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/OwnershipAndControl/isOwnedAndControlledBy"></see>
    /// </summary>
    let isOwnedAndControlledBy =
        Namespaced_IRI.parse _namespace_name "isOwnedAndControlledBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/OwnershipAndControl/ownsAndControls"></see>
    /// </summary>
    let ownsAndControls =
        Namespaced_IRI.parse _namespace_name "ownsAndControls" |> NamespacedName
