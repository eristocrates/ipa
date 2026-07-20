namespace https.spec.edmcouncil.org.fibo.ontology.DER.MetadataDER.slash

open DoxAletheia

module fibo_der_mod =
    let _namespace_name = "https://spec.edmcouncil.org/fibo/ontology/DER/MetadataDER/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/MetadataDER/DERDomain"></see>
    /// </summary>
    let DERDomain = _prefix "DERDomain"
