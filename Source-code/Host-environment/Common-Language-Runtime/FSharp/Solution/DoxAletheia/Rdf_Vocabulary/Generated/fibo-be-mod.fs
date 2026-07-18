namespace https.spec.edmcouncil.org.fibo.ontology.BE.MetadataBE.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_be_mod =
    let _namespace_name = "https://spec.edmcouncil.org/fibo/ontology/BE/MetadataBE/"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/BE/MetadataBE/BEDomain"></see>
    /// </summary>
    let BEDomain = Namespaced_IRI.parse _namespace_name "BEDomain" |> NamespacedName
