namespace https.spec.edmcouncil.org.fibo.ontology.CAE.MetadataCAE.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_cae_mod =
    let _namespace_name = "https://spec.edmcouncil.org/fibo/ontology/CAE/MetadataCAE/"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/MetadataCAE/CAEDomain"></see>
    /// </summary>
    let CAEDomain = Namespaced_IRI.parse _namespace_name "CAEDomain" |> NamespacedName
