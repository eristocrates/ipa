namespace https.spec.edmcouncil.org.fibo.ontology.DER.RateDerivatives.MetadataDERRateDerivatives.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_der_rat_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/MetadataDERRateDerivatives/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/MetadataDERRateDerivatives/RateDerivativesModule"></see>
    /// </summary>
    let RateDerivativesModule =
        Namespaced_IRI.parse _namespace_name "RateDerivativesModule" |> NamespacedName
