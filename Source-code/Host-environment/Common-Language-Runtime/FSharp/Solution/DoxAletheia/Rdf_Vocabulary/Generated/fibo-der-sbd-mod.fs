namespace https.spec.edmcouncil.org.fibo.ontology.DER.SecurityBasedDerivatives.MetadataDERSecurityBasedDerivatives.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_der_sbd_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/MetadataDERSecurityBasedDerivatives/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/MetadataDERSecurityBasedDerivatives/SecurityBasedDerivativesModule"></see>
    /// </summary>
    let SecurityBasedDerivativesModule =
        Namespaced_IRI.parse _namespace_name "SecurityBasedDerivativesModule" |> NamespacedName
