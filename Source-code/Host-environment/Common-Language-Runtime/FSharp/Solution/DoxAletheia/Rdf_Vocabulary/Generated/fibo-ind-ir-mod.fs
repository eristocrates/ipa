namespace https.spec.edmcouncil.org.fibo.ontology.IND.InterestRates.MetadataINDInterestRates.slash

open DoxAletheia

module fibo_ind_ir_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MetadataINDInterestRates/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MetadataINDInterestRates/InterestRatesModule"></see>
    /// </summary>
    let InterestRatesModule = _prefix "InterestRatesModule"
