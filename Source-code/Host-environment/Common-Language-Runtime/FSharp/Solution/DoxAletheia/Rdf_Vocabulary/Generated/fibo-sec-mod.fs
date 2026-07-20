namespace https.spec.edmcouncil.org.fibo.ontology.SEC.MetadataSEC.slash

open DoxAletheia

module fibo_sec_mod =
    let _namespace_name = "https://spec.edmcouncil.org/fibo/ontology/SEC/MetadataSEC/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/MetadataSEC/SECDomain"></see>
    /// </summary>
    let SECDomain = _prefix "SECDomain"
