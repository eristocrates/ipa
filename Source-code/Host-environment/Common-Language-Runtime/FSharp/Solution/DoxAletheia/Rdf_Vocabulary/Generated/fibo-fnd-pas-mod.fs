namespace https.spec.edmcouncil.org.fibo.ontology.FND.ProductsAndServices.MetadataFNDProductsAndServices.slash

open DoxAletheia

module fibo_fnd_pas_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/MetadataFNDProductsAndServices/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/MetadataFNDProductsAndServices/ProductsAndServicesModule"></see>
    /// </summary>
    let ProductsAndServicesModule = _prefix "ProductsAndServicesModule"
