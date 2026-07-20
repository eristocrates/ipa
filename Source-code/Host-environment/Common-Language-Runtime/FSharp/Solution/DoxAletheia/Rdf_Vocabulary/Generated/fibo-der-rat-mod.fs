namespace https.spec.edmcouncil.org.fibo.ontology.DER.RateDerivatives.MetadataDERRateDerivatives.slash

open DoxAletheia

module fibo_der_rat_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/MetadataDERRateDerivatives/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/MetadataDERRateDerivatives/RateDerivativesModule"></see>
    /// </summary>
    let RateDerivativesModule = _prefix "RateDerivativesModule"
