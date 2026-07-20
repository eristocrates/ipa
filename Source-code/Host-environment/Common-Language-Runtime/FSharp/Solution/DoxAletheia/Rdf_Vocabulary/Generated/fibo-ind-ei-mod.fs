namespace https.spec.edmcouncil.org.fibo.ontology.IND.EconomicIndicators.MetadataINDEconomicIndicators.slash

open DoxAletheia

module fibo_ind_ei_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/MetadataINDEconomicIndicators/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/MetadataINDEconomicIndicators/EconomicIndicatorsModule"></see>
    /// </summary>
    let EconomicIndicatorsModule = _prefix "EconomicIndicatorsModule"
