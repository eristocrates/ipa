namespace https.spec.edmcouncil.org.fibo.ontology.IND.Indicators.MetadataINDIndicators.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_ind_ind_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/MetadataINDIndicators/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/MetadataINDIndicators/IndicatorsModule"></see>
    /// </summary>
    let IndicatorsModule =
        Namespaced_IRI.parse _namespace_name "IndicatorsModule" |> NamespacedName
