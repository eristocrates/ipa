namespace Fibo.FND.ProductsAndServices.PaymentsAndSchedules.Namespace
module PaymentsAndSchedules =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/FND/ProductsAndServices/PaymentsAndSchedules.rdf") (Some @"fibo.FND.ProductsAndServices.PaymentsAndSchedules") None
    let Payee = {_prefixID with _localName = "Payee"}
    let Payer = {_prefixID with _localName = "Payer"}
    let Payment = {_prefixID with _localName = "Payment"}
    let PaymentEvent = {_prefixID with _localName = "PaymentEvent"}
    let PaymentObligation = {_prefixID with _localName = "PaymentObligation"}
    let PaymentSchedule = {_prefixID with _localName = "PaymentSchedule"}
    let fulfillsObligation = {_prefixID with _localName = "fulfillsObligation"}
    let hasPaymentAmount = {_prefixID with _localName = "hasPaymentAmount"}
    let hasPaymentSchedule = {_prefixID with _localName = "hasPaymentSchedule"}