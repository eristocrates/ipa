namespace https.spec.edmcouncil.org.fibo.ontology.IND.Indicators.MetadataINDIndicators.slash

open DoxAletheia

module fibo_ind_ind_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/MetadataINDIndicators/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/MetadataINDIndicators/IndicatorsModule"></see>
    /// </summary>
    let IndicatorsModule = _prefix "IndicatorsModule"
