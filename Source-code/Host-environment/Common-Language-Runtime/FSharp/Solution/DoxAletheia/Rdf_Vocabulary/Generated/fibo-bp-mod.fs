namespace https.spec.edmcouncil.org.fibo.ontology.BP.MetadataBP.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_bp_mod =
    let _namespace_name = "https://spec.edmcouncil.org/fibo/ontology/BP/MetadataBP/"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BP/MetadataBP/BPDomain"></see>
    /// </summary>
    let BPDomain = Namespaced_IRI.parse _namespace_name "BPDomain" |> NamespacedName
