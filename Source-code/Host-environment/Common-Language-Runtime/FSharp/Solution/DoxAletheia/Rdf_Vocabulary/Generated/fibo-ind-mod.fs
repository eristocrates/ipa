namespace https.spec.edmcouncil.org.fibo.ontology.IND.MetadataIND.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_ind_mod =
    let _namespace_name = "https://spec.edmcouncil.org/fibo/ontology/IND/MetadataIND/"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/MetadataIND/INDDomain"></see>
    /// </summary>
    let INDDomain = Namespaced_IRI.parse _namespace_name "INDDomain" |> NamespacedName
