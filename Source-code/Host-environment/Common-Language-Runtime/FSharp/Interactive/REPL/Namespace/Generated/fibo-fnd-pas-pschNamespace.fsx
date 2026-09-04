#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fnd-pas-psch`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/" "fibo-fnd-pas-psch"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : payee^^xsd:string</para>
    ///   <para>skos:definition : a party to whom a debt should be paid, or to whose order a bill of exchange, note, or check is made payable, or who receives or will receive a payment from a payer in partial or complete fulfillment of an obligation^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/Payee">fibo-fnd-pas-psch:Payee</a>
    /// </summary>
    let Payee = _prefixId.prefix "Payee"
    /// <summary>
    ///   <para>rdfs:label : payer^^xsd:string</para>
    ///   <para>skos:definition : a party who pays a bill or fees, or who makes payments to a payee in partial or complete fulfillment of an obligation^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/Payer">fibo-fnd-pas-psch:Payer</a>
    /// </summary>
    let Payer = _prefixId.prefix "Payer"
    /// <summary>
    ///   <para>rdfs:label : payment^^xsd:string</para>
    ///   <para>skos:definition : delivery of money in fulfillment of an obligation, such as to satisfy a claim or debt^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/Payment">fibo-fnd-pas-psch:Payment</a>
    /// </summary>
    let Payment = _prefixId.prefix "Payment"
    /// <summary>
    ///   <para>rdfs:label : payment event^^xsd:string</para>
    ///   <para>skos:definition : an event that involves delivery of money in fulfillment of an obligation^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/PaymentEvent">fibo-fnd-pas-psch:PaymentEvent</a>
    /// </summary>
    let PaymentEvent = _prefixId.prefix "PaymentEvent"
    /// <summary>
    ///   <para>rdfs:label : payment obligation^^xsd:string</para>
    ///   <para>skos:definition : legally enforceable duty to pay a sum of money according to the terms stated in a contract^^xsd:string</para>
    ///   <para>skos:example : the duty of a borrower to repay a loan, related to the legal right of a lender to enforce payment^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/PaymentObligation">fibo-fnd-pas-psch:PaymentObligation</a>
    /// </summary>
    let PaymentObligation = _prefixId.prefix "PaymentObligation"
    /// <summary>
    ///   <para>rdfs:label : payment schedule^^xsd:string</para>
    ///   <para>skos:definition : schedule for delivery of money in fulfillment of an obligation^^xsd:string</para>
    ///   <para>skos:example : Examples include coupon payment, loan payment, and interest payment schedules, among others.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/PaymentSchedule">fibo-fnd-pas-psch:PaymentSchedule</a>
    /// </summary>
    let PaymentSchedule = _prefixId.prefix "PaymentSchedule"
    /// <summary>
    ///   <para>rdfs:label : fulfills obligation^^xsd:string</para>
    ///   <para>skos:definition : satisfies a requirement for payment of some claim, debt, or other obligation^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/fulfillsObligation">fibo-fnd-pas-psch:fulfillsObligation</a>
    /// </summary>
    let fulfillsObligation = _prefixId.prefix "fulfillsObligation"
    /// <summary>
    ///   <para>rdfs:label : has payment amount^^xsd:string</para>
    ///   <para>skos:definition : specifies the amount of money involved in a payment^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/hasPaymentAmount">fibo-fnd-pas-psch:hasPaymentAmount</a>
    /// </summary>
    let hasPaymentAmount = _prefixId.prefix "hasPaymentAmount"
    /// <summary>
    ///   <para>rdfs:label : has payment schedule^^xsd:string</para>
    ///   <para>skos:definition : specifies the schedule for fulfillment of an obligation^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/hasPaymentSchedule">fibo-fnd-pas-psch:hasPaymentSchedule</a>
    /// </summary>
    let hasPaymentSchedule = _prefixId.prefix "hasPaymentSchedule"
