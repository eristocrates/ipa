namespace https.spec.edmcouncil.org.fibo.ontology.FBC.MetadataFBC.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fbc_mod =
    let _namespace_name = "https://spec.edmcouncil.org/fibo/ontology/FBC/MetadataFBC/"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/MetadataFBC/FBCDomain"></see>
    /// </summary>
    let FBCDomain = Namespaced_IRI.parse _namespace_name "FBCDomain" |> NamespacedName
