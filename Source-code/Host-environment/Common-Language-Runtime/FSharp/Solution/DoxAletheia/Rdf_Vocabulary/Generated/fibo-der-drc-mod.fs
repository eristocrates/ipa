namespace https.spec.edmcouncil.org.fibo.ontology.DER.DerivativesContracts.MetadataDERDerivativesContracts.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_der_drc_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/MetadataDERDerivativesContracts/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/MetadataDERDerivativesContracts/DerivativesContractsModule"></see>
    /// </summary>
    let DerivativesContractsModule =
        Namespaced_IRI.parse _namespace_name "DerivativesContractsModule" |> NamespacedName
