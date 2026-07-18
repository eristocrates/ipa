namespace https.spec.edmcouncil.org.fibo.ontology.FND.TransactionsExt.MetadataFNDTransactionsExt.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_txn_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/TransactionsExt/MetadataFNDTransactionsExt/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/TransactionsExt/MetadataFNDTransactionsExt/TransactionsExtModule"></see>
    /// </summary>
    let TransactionsExtModule =
        Namespaced_IRI.parse _namespace_name "TransactionsExtModule" |> NamespacedName
