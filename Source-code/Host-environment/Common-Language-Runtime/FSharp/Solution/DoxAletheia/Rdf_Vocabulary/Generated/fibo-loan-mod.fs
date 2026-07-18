namespace https.spec.edmcouncil.org.fibo.ontology.LOAN.MetadataLOAN.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_loan_mod =
    let _namespace_name = "https://spec.edmcouncil.org/fibo/ontology/LOAN/MetadataLOAN/"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/MetadataLOAN/LOANDomain"></see>
    /// </summary>
    let LOANDomain = Namespaced_IRI.parse _namespace_name "LOANDomain" |> NamespacedName
