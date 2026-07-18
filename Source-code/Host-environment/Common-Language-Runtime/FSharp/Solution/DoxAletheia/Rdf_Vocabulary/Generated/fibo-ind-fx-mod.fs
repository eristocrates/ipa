namespace https.spec.edmcouncil.org.fibo.ontology.IND.ForeignExchange.MetadataINDForeignExchange.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_ind_fx_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/MetadataINDForeignExchange/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/MetadataINDForeignExchange/ForeignExchangeModule"></see>
    /// </summary>
    let ForeignExchangeModule =
        Namespaced_IRI.parse _namespace_name "ForeignExchangeModule" |> NamespacedName
