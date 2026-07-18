namespace https.spec.edmcouncil.org.fibo.ontology.LOAN.LoansSpecific.MetadataLOANLoansSpecific.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_loan_spc_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/MetadataLOANLoansSpecific/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/MetadataLOANLoansSpecific/LoansSpecificModule"></see>
    /// </summary>
    let LoansSpecificModule =
        Namespaced_IRI.parse _namespace_name "LoansSpecificModule" |> NamespacedName
