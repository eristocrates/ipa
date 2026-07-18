namespace https.spec.edmcouncil.org.fibo.ontology.LOAN.LoansSpecific.CommercialLoans.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_loan_spc_com =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CommercialLoans/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CommercialLoans/CommercialLoan"></see>
    /// </summary>
    let CommercialLoan =
        Namespaced_IRI.parse _namespace_name "CommercialLoan" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CommercialLoans/hasBusinessPurposeDescription"></see>
    /// </summary>
    let hasBusinessPurposeDescription =
        Namespaced_IRI.parse _namespace_name "hasBusinessPurposeDescription" |> NamespacedName
