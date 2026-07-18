namespace https.spec.edmcouncil.org.fibo.ontology.BE.FunctionalEntities.MetadataBEFunctionalEntities.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_be_fct_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/MetadataBEFunctionalEntities/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/MetadataBEFunctionalEntities/FunctionalEntitiesModule"></see>
    /// </summary>
    let FunctionalEntitiesModule =
        Namespaced_IRI.parse _namespace_name "FunctionalEntitiesModule" |> NamespacedName
