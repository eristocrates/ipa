namespace https.spec.edmcouncil.org.fibo.ontology.LOAN.LoansSpecific.MetadataLOANLoansSpecific.slash

open DoxAletheia

module fibo_loan_spc_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/MetadataLOANLoansSpecific/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/MetadataLOANLoansSpecific/LoansSpecificModule"></see>
    /// </summary>
    let LoansSpecificModule = _prefix "LoansSpecificModule"
