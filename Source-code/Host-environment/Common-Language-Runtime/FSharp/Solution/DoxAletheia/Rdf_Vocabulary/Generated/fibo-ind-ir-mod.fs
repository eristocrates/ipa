namespace https.spec.edmcouncil.org.fibo.ontology.IND.InterestRates.MetadataINDInterestRates.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_ind_ir_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MetadataINDInterestRates/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MetadataINDInterestRates/InterestRatesModule"></see>
    /// </summary>
    let InterestRatesModule =
        Namespaced_IRI.parse _namespace_name "InterestRatesModule" |> NamespacedName
