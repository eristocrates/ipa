namespace https.spec.edmcouncil.org.fibo.ontology.MD.DebtTemporal.MetadataMDDebtTemporal.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_md_dbtx_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/MD/DebtTemporal/MetadataMDDebtTemporal/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/MD/DebtTemporal/MetadataMDDebtTemporal/DebtTemporalModule"></see>
    /// </summary>
    let DebtTemporalModule =
        Namespaced_IRI.parse _namespace_name "DebtTemporalModule" |> NamespacedName
