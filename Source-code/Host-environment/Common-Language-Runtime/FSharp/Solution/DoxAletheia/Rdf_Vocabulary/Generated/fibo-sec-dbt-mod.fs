namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Debt.MetadataSECDebt.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_sec_dbt_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/MetadataSECDebt/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/MetadataSECDebt/DebtModule"></see>
    /// </summary>
    let DebtModule = Namespaced_IRI.parse _namespace_name "DebtModule" |> NamespacedName
