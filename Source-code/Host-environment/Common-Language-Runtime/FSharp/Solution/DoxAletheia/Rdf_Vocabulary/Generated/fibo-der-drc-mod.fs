namespace https.spec.edmcouncil.org.fibo.ontology.DER.DerivativesContracts.MetadataDERDerivativesContracts.slash

open DoxAletheia

module fibo_der_drc_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/MetadataDERDerivativesContracts/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/MetadataDERDerivativesContracts/DerivativesContractsModule"></see>
    /// </summary>
    let DerivativesContractsModule = _prefix "DerivativesContractsModule"
