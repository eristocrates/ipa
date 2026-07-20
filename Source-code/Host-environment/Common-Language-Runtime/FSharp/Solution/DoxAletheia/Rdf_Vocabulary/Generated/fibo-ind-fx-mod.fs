namespace https.spec.edmcouncil.org.fibo.ontology.IND.ForeignExchange.MetadataINDForeignExchange.slash

open DoxAletheia

module fibo_ind_fx_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/MetadataINDForeignExchange/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/MetadataINDForeignExchange/ForeignExchangeModule"></see>
    /// </summary>
    let ForeignExchangeModule = _prefix "ForeignExchangeModule"
