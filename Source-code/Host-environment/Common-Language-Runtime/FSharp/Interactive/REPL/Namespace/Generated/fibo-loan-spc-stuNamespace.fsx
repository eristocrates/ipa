#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-loan-spc-stu`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/StudentLoans/" "fibo-loan-spc-stu"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : private student loan</para>
    ///   <para>skos:definition : student loan that is not considered a government-backed / regulated loan</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/StudentLoans/PrivateStudentLoan">fibo-loan-spc-stu:PrivateStudentLoan</a>
    /// </summary>
    let PrivateStudentLoan = _prefixId.prefix "PrivateStudentLoan"
    /// <summary>
    ///   <para>rdfs:label : regulated student loan</para>
    ///   <para>skos:definition : student loan (1) whose lender is a government agency or instrumentality, and/or (2) that is treated uniquely due to tax regulations</para>
    ///   <para>cmns-av:explanatoryNote : In the United States, certain student loans survive bankruptcy and are subject to additional tax regulations that do not apply to other kinds of loans.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/StudentLoans/RegulatedStudentLoan">fibo-loan-spc-stu:RegulatedStudentLoan</a>
    /// </summary>
    let RegulatedStudentLoan = _prefixId.prefix "RegulatedStudentLoan"
    /// <summary>
    ///   <para>rdfs:label : student loan</para>
    ///   <para>skos:definition : loan provided for the purposes of education, allowing students and parents/guardians to borrow money for college</para>
    ///   <para>cmns-av:explanatoryNote : Student loans may include loans for graduate and professional education. Student loans may be obtained from government institutions, from private sources such as a bank or financial institution, or from other organizations.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/StudentLoans/StudentLoan">fibo-loan-spc-stu:StudentLoan</a>
    /// </summary>
    let StudentLoan = _prefixId.prefix "StudentLoan"
