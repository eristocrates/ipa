namespace https.spec.edmcouncil.org.fibo.ontology.MD.MetadataMD.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_md_mod =
    let _namespace_name = "https://spec.edmcouncil.org/fibo/ontology/MD/MetadataMD/"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/MD/MetadataMD/MDDomain"></see>
    /// </summary>
    let MDDomain = Namespaced_IRI.parse _namespace_name "MDDomain" |> NamespacedName
