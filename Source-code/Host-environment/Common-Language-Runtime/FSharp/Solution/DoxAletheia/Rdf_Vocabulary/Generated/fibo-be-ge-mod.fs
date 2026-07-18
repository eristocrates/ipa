namespace https.spec.edmcouncil.org.fibo.ontology.BE.GovernmentEntities.MetadataBEGovernmentEntities.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_be_ge_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/MetadataBEGovernmentEntities/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/MetadataBEGovernmentEntities/GovernmentEntitiesModule"></see>
    /// </summary>
    let GovernmentEntitiesModule =
        Namespaced_IRI.parse _namespace_name "GovernmentEntitiesModule" |> NamespacedName
