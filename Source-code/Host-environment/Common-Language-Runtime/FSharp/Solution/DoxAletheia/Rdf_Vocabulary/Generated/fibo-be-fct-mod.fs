namespace https.spec.edmcouncil.org.fibo.ontology.BE.FunctionalEntities.MetadataBEFunctionalEntities.slash

open DoxAletheia

module fibo_be_fct_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/MetadataBEFunctionalEntities/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/MetadataBEFunctionalEntities/FunctionalEntitiesModule"></see>
    /// </summary>
    let FunctionalEntitiesModule = _prefix "FunctionalEntitiesModule"
