namespace https.spec.edmcouncil.org.fibo.ontology.MD.TemporalCore.MetadataMDTemporalCore.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_md_temx_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/MD/TemporalCore/MetadataMDTemporalCore/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/MD/TemporalCore/MetadataMDTemporalCore/TemporalCoreModule"></see>
    /// </summary>
    let TemporalCoreModule =
        Namespaced_IRI.parse _namespace_name "TemporalCoreModule" |> NamespacedName
