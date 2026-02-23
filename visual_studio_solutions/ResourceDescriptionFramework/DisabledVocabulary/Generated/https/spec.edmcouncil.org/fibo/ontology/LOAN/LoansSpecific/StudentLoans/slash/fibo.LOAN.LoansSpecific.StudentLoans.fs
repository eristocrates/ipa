namespace Fibo.LOAN.LoansSpecific.StudentLoans.Namespace
module StudentLoans =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/StudentLoans/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/LOAN/LoansSpecific/StudentLoans.rdf") (Some @"fibo.LOAN.LoansSpecific.StudentLoans") None
    let PrivateStudentLoan = {_prefixID with _localName = "PrivateStudentLoan"}
    let RegulatedStudentLoan = {_prefixID with _localName = "RegulatedStudentLoan"}
    let StudentLoan = {_prefixID with _localName = "StudentLoan"}