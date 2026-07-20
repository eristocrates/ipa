namespace https.spec.edmcouncil.org.fibo.ontology.BE.GovernmentEntities.MetadataBEGovernmentEntities.slash

open DoxAletheia

module fibo_be_ge_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/MetadataBEGovernmentEntities/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/MetadataBEGovernmentEntities/GovernmentEntitiesModule"></see>
    /// </summary>
    let GovernmentEntitiesModule = _prefix "GovernmentEntitiesModule"
