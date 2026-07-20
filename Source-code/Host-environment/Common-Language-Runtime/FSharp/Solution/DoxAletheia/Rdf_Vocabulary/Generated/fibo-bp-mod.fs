namespace https.spec.edmcouncil.org.fibo.ontology.BP.MetadataBP.slash

open DoxAletheia

module fibo_bp_mod =
    let _namespace_name = "https://spec.edmcouncil.org/fibo/ontology/BP/MetadataBP/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BP/MetadataBP/BPDomain"></see>
    /// </summary>
    let BPDomain = _prefix "BPDomain"
