namespace https.spec.edmcouncil.org.fibo.ontology.LOAN.LoansSpecific.StudentLoans.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_loan_spc_stu =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/StudentLoans/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/StudentLoans/PrivateStudentLoan"></see>
    /// </summary>
    let PrivateStudentLoan =
        Namespaced_IRI.parse _namespace_name "PrivateStudentLoan" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/StudentLoans/RegulatedStudentLoan"></see>
    /// </summary>
    let RegulatedStudentLoan =
        Namespaced_IRI.parse _namespace_name "RegulatedStudentLoan" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/StudentLoans/StudentLoan"></see>
    /// </summary>
    let StudentLoan =
        Namespaced_IRI.parse _namespace_name "StudentLoan" |> NamespacedName
