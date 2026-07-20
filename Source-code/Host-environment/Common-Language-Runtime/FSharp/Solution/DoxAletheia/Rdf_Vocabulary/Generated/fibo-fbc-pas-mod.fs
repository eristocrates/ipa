namespace https.spec.edmcouncil.org.fibo.ontology.FBC.ProductsAndServices.MetadataFBCProductsAndServices.slash

open DoxAletheia

module fibo_fbc_pas_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/MetadataFBCProductsAndServices/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/MetadataFBCProductsAndServices/FBCProductsAndServicesModule"></see>
    /// </summary>
    let FBCProductsAndServicesModule = _prefix "FBCProductsAndServicesModule"
