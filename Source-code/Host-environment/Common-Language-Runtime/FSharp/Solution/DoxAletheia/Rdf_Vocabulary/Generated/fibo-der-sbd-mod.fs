namespace https.spec.edmcouncil.org.fibo.ontology.DER.SecurityBasedDerivatives.MetadataDERSecurityBasedDerivatives.slash

open DoxAletheia

module fibo_der_sbd_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/MetadataDERSecurityBasedDerivatives/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/MetadataDERSecurityBasedDerivatives/SecurityBasedDerivativesModule"></see>
    /// </summary>
    let SecurityBasedDerivativesModule = _prefix "SecurityBasedDerivativesModule"
