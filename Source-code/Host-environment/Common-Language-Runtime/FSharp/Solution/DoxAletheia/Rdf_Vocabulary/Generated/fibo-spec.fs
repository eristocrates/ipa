namespace https.spec.edmcouncil.org.fibo.ontology.MetadataFIBO.slash

open DoxAletheia

module fibo_spec =
    let _namespace_name = "https://spec.edmcouncil.org/fibo/ontology/MetadataFIBO/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/MetadataFIBO/FIBOSpecification"></see>
    /// </summary>
    let FIBOSpecification = _prefix "FIBOSpecification"
