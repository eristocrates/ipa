namespace https.spec.edmcouncil.org.fibo.ontology.FBC.DebtAndEquities.MetadataFBCDebtAndEquities.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fbc_dae_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/MetadataFBCDebtAndEquities/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/MetadataFBCDebtAndEquities/DebtAndEquitiesModule"></see>
    /// </summary>
    let DebtAndEquitiesModule =
        Namespaced_IRI.parse _namespace_name "DebtAndEquitiesModule" |> NamespacedName
