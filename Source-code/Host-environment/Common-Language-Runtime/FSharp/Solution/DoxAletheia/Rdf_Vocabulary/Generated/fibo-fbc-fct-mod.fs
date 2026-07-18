namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FunctionalEntities.MetadataFBCFunctionalEntities.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fbc_fct_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/MetadataFBCFunctionalEntities/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/MetadataFBCFunctionalEntities/FunctionalEntitiesModule"></see>
    /// </summary>
    let FunctionalEntitiesModule =
        Namespaced_IRI.parse _namespace_name "FunctionalEntitiesModule" |> NamespacedName
