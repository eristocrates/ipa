namespace https.spec.edmcouncil.org.fibo.ontology.CAE.MetadataCAE.slash

open DoxAletheia

module fibo_cae_mod =
    let _namespace_name = "https://spec.edmcouncil.org/fibo/ontology/CAE/MetadataCAE/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/CAE/MetadataCAE/CAEDomain"></see>
    /// </summary>
    let CAEDomain = _prefix "CAEDomain"
