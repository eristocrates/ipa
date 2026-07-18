namespace https.spec.edmcouncil.org.fibo.ontology.DER.MetadataDER.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_der_mod =
    let _namespace_name = "https://spec.edmcouncil.org/fibo/ontology/DER/MetadataDER/"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/MetadataDER/DERDomain"></see>
    /// </summary>
    let DERDomain = Namespaced_IRI.parse _namespace_name "DERDomain" |> NamespacedName
