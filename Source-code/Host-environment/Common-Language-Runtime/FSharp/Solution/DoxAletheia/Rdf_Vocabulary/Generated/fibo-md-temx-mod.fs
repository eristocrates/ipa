namespace https.spec.edmcouncil.org.fibo.ontology.MD.TemporalCore.MetadataMDTemporalCore.slash

open DoxAletheia

module fibo_md_temx_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/MD/TemporalCore/MetadataMDTemporalCore/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/MD/TemporalCore/MetadataMDTemporalCore/TemporalCoreModule"></see>
    /// </summary>
    let TemporalCoreModule = _prefix "TemporalCoreModule"
