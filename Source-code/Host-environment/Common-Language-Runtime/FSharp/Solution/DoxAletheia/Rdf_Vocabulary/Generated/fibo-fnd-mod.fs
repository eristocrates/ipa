namespace https.spec.edmcouncil.org.fibo.ontology.FND.MetadataFND.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_mod =
    let _namespace_name = "https://spec.edmcouncil.org/fibo/ontology/FND/MetadataFND/"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/MetadataFND/FNDDomain"></see>
    /// </summary>
    let FNDDomain = Namespaced_IRI.parse _namespace_name "FNDDomain" |> NamespacedName
