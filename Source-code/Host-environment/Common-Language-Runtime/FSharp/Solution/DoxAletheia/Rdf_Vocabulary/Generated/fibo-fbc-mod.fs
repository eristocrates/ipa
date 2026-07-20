namespace https.spec.edmcouncil.org.fibo.ontology.FBC.MetadataFBC.slash

open DoxAletheia

module fibo_fbc_mod =
    let _namespace_name = "https://spec.edmcouncil.org/fibo/ontology/FBC/MetadataFBC/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/MetadataFBC/FBCDomain"></see>
    /// </summary>
    let FBCDomain = _prefix "FBCDomain"
