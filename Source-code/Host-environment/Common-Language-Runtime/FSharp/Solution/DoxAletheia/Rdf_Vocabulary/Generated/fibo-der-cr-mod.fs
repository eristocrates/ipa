namespace https.spec.edmcouncil.org.fibo.ontology.DER.CreditDerivatives.MetadataDERCreditDerivatives.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_der_cr_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/MetadataDERCreditDerivatives/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/MetadataDERCreditDerivatives/CreditDerivativesModule"></see>
    /// </summary>
    let CreditDerivativesModule =
        Namespaced_IRI.parse _namespace_name "CreditDerivativesModule" |> NamespacedName
