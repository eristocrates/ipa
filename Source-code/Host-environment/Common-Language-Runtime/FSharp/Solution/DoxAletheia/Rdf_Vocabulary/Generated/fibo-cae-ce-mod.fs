namespace https.spec.edmcouncil.org.fibo.ontology.CAE.CorporateEvents.MetadataCAECorporateEvents.slash

open DoxAletheia

module fibo_cae_ce_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/MetadataCAECorporateEvents/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/MetadataCAECorporateEvents/CorporateEventsModule"></see>
    /// </summary>
    let CorporateEventsModule = _prefix "CorporateEventsModule"
