namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FinancialInstruments.MetadataFBCFinancialInstruments.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fbc_fi_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/MetadataFBCFinancialInstruments/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/MetadataFBCFinancialInstruments/FinancialInstrumentsModule"></see>
    /// </summary>
    let FinancialInstrumentsModule =
        Namespaced_IRI.parse _namespace_name "FinancialInstrumentsModule" |> NamespacedName
