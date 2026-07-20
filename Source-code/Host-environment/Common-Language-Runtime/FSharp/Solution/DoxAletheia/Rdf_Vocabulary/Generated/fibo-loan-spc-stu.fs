namespace https.spec.edmcouncil.org.fibo.ontology.LOAN.LoansSpecific.StudentLoans.slash

open DoxAletheia

module fibo_loan_spc_stu =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/StudentLoans/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/StudentLoans/PrivateStudentLoan"></see>
    /// </summary>
    let PrivateStudentLoan = _prefix "PrivateStudentLoan"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/StudentLoans/RegulatedStudentLoan"></see>
    /// </summary>
    let RegulatedStudentLoan = _prefix "RegulatedStudentLoan"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/StudentLoans/StudentLoan"></see>
    /// </summary>
    let StudentLoan = _prefix "StudentLoan"
