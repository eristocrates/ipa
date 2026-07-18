namespace https.spec.edmcouncil.org.fibo.ontology.BE.LegalEntities.MetadataBELegalEntities.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_be_le_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/MetadataBELegalEntities/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/MetadataBELegalEntities/LegalEntitiesModule"></see>
    /// </summary>
    let LegalEntitiesModule =
        Namespaced_IRI.parse _namespace_name "LegalEntitiesModule" |> NamespacedName
