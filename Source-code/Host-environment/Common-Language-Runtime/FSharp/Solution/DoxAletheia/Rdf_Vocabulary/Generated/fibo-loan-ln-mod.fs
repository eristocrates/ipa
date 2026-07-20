namespace https.spec.edmcouncil.org.fibo.ontology.LOAN.LoansGeneral.MetadataLOANLoansGeneral.slash

open DoxAletheia

module fibo_loan_ln_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/MetadataLOANLoansGeneral/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/MetadataLOANLoansGeneral/LoansGeneralModule"></see>
    /// </summary>
    let LoansGeneralModule = _prefix "LoansGeneralModule"
