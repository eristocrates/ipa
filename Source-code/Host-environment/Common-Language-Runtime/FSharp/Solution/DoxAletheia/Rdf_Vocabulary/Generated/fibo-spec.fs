namespace https.spec.edmcouncil.org.fibo.ontology.MetadataFIBO.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_spec =
    let _namespace_name = "https://spec.edmcouncil.org/fibo/ontology/MetadataFIBO/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/MetadataFIBO/FIBOSpecification"></see>
    /// </summary>
    let FIBOSpecification =
        Namespaced_IRI.parse _namespace_name "FIBOSpecification" |> NamespacedName
