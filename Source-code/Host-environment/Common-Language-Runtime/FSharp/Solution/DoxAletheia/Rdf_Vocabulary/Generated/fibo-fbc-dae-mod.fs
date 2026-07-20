namespace https.spec.edmcouncil.org.fibo.ontology.FBC.DebtAndEquities.MetadataFBCDebtAndEquities.slash

open DoxAletheia

module fibo_fbc_dae_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/MetadataFBCDebtAndEquities/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/MetadataFBCDebtAndEquities/DebtAndEquitiesModule"></see>
    /// </summary>
    let DebtAndEquitiesModule = _prefix "DebtAndEquitiesModule"
