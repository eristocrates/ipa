namespace https.spec.edmcouncil.org.fibo.ontology.FND.ProductsAndServices.PaymentsAndSchedules.slash

open DoxAletheia

module fibo_fnd_pas_psch =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/Payee"></see>
    /// </summary>
    let Payee = _prefix "Payee"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/PaymentObligation"></see>
    /// </summary>
    let PaymentObligation = _prefix "PaymentObligation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/Payer"></see>
    /// </summary>
    let Payer = _prefix "Payer"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/Payment"></see>
    /// </summary>
    let Payment = _prefix "Payment"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/hasPaymentAmount"></see>
    /// </summary>
    let hasPaymentAmount = _prefix "hasPaymentAmount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/PaymentEvent"></see>
    /// </summary>
    let PaymentEvent = _prefix "PaymentEvent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/PaymentSchedule"></see>
    /// </summary>
    let PaymentSchedule = _prefix "PaymentSchedule"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/fulfillsObligation"></see>
    /// </summary>
    let fulfillsObligation = _prefix "fulfillsObligation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/hasPaymentSchedule"></see>
    /// </summary>
    let hasPaymentSchedule = _prefix "hasPaymentSchedule"
