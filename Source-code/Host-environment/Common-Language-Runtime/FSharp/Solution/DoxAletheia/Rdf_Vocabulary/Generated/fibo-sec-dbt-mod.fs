namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Debt.MetadataSECDebt.slash

open DoxAletheia

module fibo_sec_dbt_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/MetadataSECDebt/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/MetadataSECDebt/DebtModule"></see>
    /// </summary>
    let DebtModule = _prefix "DebtModule"
