namespace https.spec.edmcouncil.org.fibo.ontology.IND.MarketIndices.MetadataINDMarketIndices.slash

open DoxAletheia

module fibo_ind_mkt_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/MetadataINDMarketIndices/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/MetadataINDMarketIndices/MarketIndicesModule"></see>
    /// </summary>
    let MarketIndicesModule = _prefix "MarketIndicesModule"
