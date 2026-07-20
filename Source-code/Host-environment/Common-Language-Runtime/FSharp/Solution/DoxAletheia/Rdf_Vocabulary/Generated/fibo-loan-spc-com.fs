namespace https.spec.edmcouncil.org.fibo.ontology.LOAN.LoansSpecific.CommercialLoans.slash

open DoxAletheia

module fibo_loan_spc_com =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CommercialLoans/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CommercialLoans/CommercialLoan"></see>
    /// </summary>
    let CommercialLoan = _prefix "CommercialLoan"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CommercialLoans/hasBusinessPurposeDescription"></see>
    /// </summary>
    let hasBusinessPurposeDescription = _prefix "hasBusinessPurposeDescription"
