namespace https.spec.edmcouncil.org.fibo.ontology.FND.OwnershipAndControl.MetadataFNDOwnershipAndControl.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_oac_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/MetadataFNDOwnershipAndControl/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/MetadataFNDOwnershipAndControl/OwnershipAndControlModule"></see>
    /// </summary>
    let OwnershipAndControlModule =
        Namespaced_IRI.parse _namespace_name "OwnershipAndControlModule" |> NamespacedName
