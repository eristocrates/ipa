namespace https.spec.edmcouncil.org.fibo.ontology.LOAN.LoansGeneral.MetadataLOANLoansGeneral.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_loan_ln_mod =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/MetadataLOANLoansGeneral/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/MetadataLOANLoansGeneral/LoansGeneralModule"></see>
    /// </summary>
    let LoansGeneralModule =
        Namespaced_IRI.parse _namespace_name "LoansGeneralModule" |> NamespacedName
