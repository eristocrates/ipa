namespace https.spec.edmcouncil.org.fibo.ontology.FBC.ProductsAndServices.MetadataFBCProductsAndServices.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fbc_pas_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/MetadataFBCProductsAndServices/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/MetadataFBCProductsAndServices/FBCProductsAndServicesModule"></see>
    /// </summary>
    let FBCProductsAndServicesModule =
        Namespaced_IRI.parse _namespace_name "FBCProductsAndServicesModule" |> NamespacedName
