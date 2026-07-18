namespace https.spec.edmcouncil.org.fibo.ontology.MD.DerivativesTemporal.MetadataMDDerivativesTemporal.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_md_derx_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/MD/DerivativesTemporal/MetadataMDDerivativesTemporal/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/MD/DerivativesTemporal/MetadataMDDerivativesTemporal/DerivativesTemporalModule"></see>
    /// </summary>
    let DerivativesTemporalModule =
        Namespaced_IRI.parse _namespace_name "DerivativesTemporalModule" |> NamespacedName
