namespace https.spec.edmcouncil.org.fibo.ontology.CAE.CorporateEvents.MetadataCAECorporateEvents.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_cae_ce_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/MetadataCAECorporateEvents/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/MetadataCAECorporateEvents/CorporateEventsModule"></see>
    /// </summary>
    let CorporateEventsModule =
        Namespaced_IRI.parse _namespace_name "CorporateEventsModule" |> NamespacedName
