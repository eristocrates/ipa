namespace https.spec.edmcouncil.org.fibo.ontology.IND.EconomicIndicators.MetadataINDEconomicIndicators.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_ind_ei_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/MetadataINDEconomicIndicators/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/MetadataINDEconomicIndicators/EconomicIndicatorsModule"></see>
    /// </summary>
    let EconomicIndicatorsModule =
        Namespaced_IRI.parse _namespace_name "EconomicIndicatorsModule" |> NamespacedName
