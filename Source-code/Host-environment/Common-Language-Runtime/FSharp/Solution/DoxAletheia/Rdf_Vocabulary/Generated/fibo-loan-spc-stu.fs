namespace https.spec.edmcouncil.org.fibo.ontology.LOAN.LoansSpecific.StudentLoans.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_loan_spc_stu =
    let _namespace_iri = Namespace_Iri fibo_loan_spc_stu |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-loan-spc-stu:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Student Loans Ontology"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/StudentLoans/">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/StudentLoans/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_loan_spc_stu, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-stu:PrivateStudentLoan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"private student loan"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/StudentLoans/PrivateStudentLoan">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/StudentLoans/PrivateStudentLoan</seealso>
    let PrivateStudentLoan =
        Prefixed_Name(fibo_loan_spc_stu, "PrivateStudentLoan") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-stu:RegulatedStudentLoan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"regulated student loan"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/StudentLoans/RegulatedStudentLoan">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/StudentLoans/RegulatedStudentLoan</seealso>
    let RegulatedStudentLoan =
        Prefixed_Name(fibo_loan_spc_stu, "RegulatedStudentLoan") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-stu:StudentLoan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"student loan"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/StudentLoans/StudentLoan">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/StudentLoans/StudentLoan</seealso>
    let StudentLoan = Prefixed_Name(fibo_loan_spc_stu, "StudentLoan") |> PrefixedName
