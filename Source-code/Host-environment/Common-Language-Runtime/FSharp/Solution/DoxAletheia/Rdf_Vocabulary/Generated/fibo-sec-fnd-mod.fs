namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Funds.MetadataSECFunds.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_sec_fnd_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/MetadataSECFunds/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/MetadataSECFunds/FundsModule"></see>
    /// </summary>
    let FundsModule =
        Namespaced_IRI.parse _namespace_name "FundsModule" |> NamespacedName
