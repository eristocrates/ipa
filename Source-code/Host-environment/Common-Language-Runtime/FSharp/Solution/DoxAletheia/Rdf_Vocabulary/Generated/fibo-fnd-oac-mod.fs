namespace https.spec.edmcouncil.org.fibo.ontology.FND.OwnershipAndControl.MetadataFNDOwnershipAndControl.slash

open DoxAletheia

module fibo_fnd_oac_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/MetadataFNDOwnershipAndControl/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/MetadataFNDOwnershipAndControl/OwnershipAndControlModule"></see>
    /// </summary>
    let OwnershipAndControlModule = _prefix "OwnershipAndControlModule"
