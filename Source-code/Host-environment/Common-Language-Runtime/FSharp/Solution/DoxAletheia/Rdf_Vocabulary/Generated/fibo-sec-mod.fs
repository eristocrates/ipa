namespace https.spec.edmcouncil.org.fibo.ontology.SEC.MetadataSEC.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_sec_mod =
    let _namespace_name = "https://spec.edmcouncil.org/fibo/ontology/SEC/MetadataSEC/"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/MetadataSEC/SECDomain"></see>
    /// </summary>
    let SECDomain = Namespaced_IRI.parse _namespace_name "SECDomain" |> NamespacedName
