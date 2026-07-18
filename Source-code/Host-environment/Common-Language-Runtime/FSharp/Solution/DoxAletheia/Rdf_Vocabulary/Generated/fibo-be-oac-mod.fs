namespace https.spec.edmcouncil.org.fibo.ontology.BE.OwnershipAndControl.MetadataBEOwnershipAndControl.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_be_oac_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/MetadataBEOwnershipAndControl/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/MetadataBEOwnershipAndControl/OwnershipAndControlModule"></see>
    /// </summary>
    let OwnershipAndControlModule =
        Namespaced_IRI.parse _namespace_name "OwnershipAndControlModule" |> NamespacedName
