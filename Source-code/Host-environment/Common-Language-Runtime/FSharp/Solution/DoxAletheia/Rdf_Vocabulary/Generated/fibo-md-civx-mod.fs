namespace https.spec.edmcouncil.org.fibo.ontology.MD.CIVTemporal.MetadataMDCIVTemporal.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_md_civx_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/MD/CIVTemporal/MetadataMDCIVTemporal/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/MD/CIVTemporal/MetadataMDCIVTemporal/CIVTemporalModule"></see>
    /// </summary>
    let CIVTemporalModule =
        Namespaced_IRI.parse _namespace_name "CIVTemporalModule" |> NamespacedName
