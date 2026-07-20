namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FinancialInstruments.MetadataFBCFinancialInstruments.slash

open DoxAletheia

module fibo_fbc_fi_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/MetadataFBCFinancialInstruments/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/MetadataFBCFinancialInstruments/FinancialInstrumentsModule"></see>
    /// </summary>
    let FinancialInstrumentsModule = _prefix "FinancialInstrumentsModule"
