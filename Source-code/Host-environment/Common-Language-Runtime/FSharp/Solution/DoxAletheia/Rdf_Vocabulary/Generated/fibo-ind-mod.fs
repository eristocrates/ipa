namespace https.spec.edmcouncil.org.fibo.ontology.IND.MetadataIND.slash

open DoxAletheia

module fibo_ind_mod =
    let _namespace_name = "https://spec.edmcouncil.org/fibo/ontology/IND/MetadataIND/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/MetadataIND/INDDomain"></see>
    /// </summary>
    let INDDomain = _prefix "INDDomain"
