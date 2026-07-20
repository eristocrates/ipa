namespace https.spec.edmcouncil.org.fibo.ontology.MD.DerivativesTemporal.MetadataMDDerivativesTemporal.slash

open DoxAletheia

module fibo_md_derx_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/MD/DerivativesTemporal/MetadataMDDerivativesTemporal/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/MD/DerivativesTemporal/MetadataMDDerivativesTemporal/DerivativesTemporalModule"></see>
    /// </summary>
    let DerivativesTemporalModule = _prefix "DerivativesTemporalModule"
