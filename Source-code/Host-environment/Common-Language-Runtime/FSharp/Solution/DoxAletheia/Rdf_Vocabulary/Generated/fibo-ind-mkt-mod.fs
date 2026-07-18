namespace https.spec.edmcouncil.org.fibo.ontology.IND.MarketIndices.MetadataINDMarketIndices.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_ind_mkt_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/MetadataINDMarketIndices/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/MetadataINDMarketIndices/MarketIndicesModule"></see>
    /// </summary>
    let MarketIndicesModule =
        Namespaced_IRI.parse _namespace_name "MarketIndicesModule" |> NamespacedName
