namespace Fibo.LOAN.LoansSpecific.ConsumerLoans.Namespace
module ConsumerLoans =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/ConsumerLoans/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/LOAN/LoansSpecific/ConsumerLoans.rdf") (Some @"fibo.LOAN.LoansSpecific.ConsumerLoans") None
    let ConsumerLoan = {_prefixID with _localName = "ConsumerLoan"}
    let HomeEquityLineOfCredit = {_prefixID with _localName = "HomeEquityLineOfCredit"}
    let MotorVehicleLoan = {_prefixID with _localName = "MotorVehicleLoan"}
    let SecuredConsumerLoan = {_prefixID with _localName = "SecuredConsumerLoan"}
    let UnsecuredConsumerLoan = {_prefixID with _localName = "UnsecuredConsumerLoan"}