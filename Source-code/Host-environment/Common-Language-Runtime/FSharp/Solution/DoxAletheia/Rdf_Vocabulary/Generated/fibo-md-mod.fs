namespace https.spec.edmcouncil.org.fibo.ontology.MD.MetadataMD.slash

open DoxAletheia

module fibo_md_mod =
    let _namespace_name = "https://spec.edmcouncil.org/fibo/ontology/MD/MetadataMD/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/MD/MetadataMD/MDDomain"></see>
    /// </summary>
    let MDDomain = _prefix "MDDomain"
