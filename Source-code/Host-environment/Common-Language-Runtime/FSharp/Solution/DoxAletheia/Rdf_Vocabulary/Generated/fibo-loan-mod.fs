namespace https.spec.edmcouncil.org.fibo.ontology.LOAN.MetadataLOAN.slash

open DoxAletheia

module fibo_loan_mod =
    let _namespace_name = "https://spec.edmcouncil.org/fibo/ontology/LOAN/MetadataLOAN/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/MetadataLOAN/LOANDomain"></see>
    /// </summary>
    let LOANDomain = _prefix "LOANDomain"
