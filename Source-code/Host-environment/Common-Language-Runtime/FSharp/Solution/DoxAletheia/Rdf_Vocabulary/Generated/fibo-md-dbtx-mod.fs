namespace https.spec.edmcouncil.org.fibo.ontology.MD.DebtTemporal.MetadataMDDebtTemporal.slash

open DoxAletheia

module fibo_md_dbtx_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/MD/DebtTemporal/MetadataMDDebtTemporal/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/MD/DebtTemporal/MetadataMDDebtTemporal/DebtTemporalModule"></see>
    /// </summary>
    let DebtTemporalModule = _prefix "DebtTemporalModule"
