namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Funds.MetadataSECFunds.slash

open DoxAletheia

module fibo_sec_fnd_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/MetadataSECFunds/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/MetadataSECFunds/FundsModule"></see>
    /// </summary>
    let FundsModule = _prefix "FundsModule"
