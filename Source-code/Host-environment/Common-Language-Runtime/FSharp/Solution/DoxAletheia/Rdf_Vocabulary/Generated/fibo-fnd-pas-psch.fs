namespace https.spec.edmcouncil.org.fibo.ontology.FND.ProductsAndServices.PaymentsAndSchedules.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_pas_psch =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/Payee"></see>
    /// </summary>
    let Payee = Namespaced_IRI.parse _namespace_name "Payee" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/PaymentObligation"></see>
    /// </summary>
    let PaymentObligation =
        Namespaced_IRI.parse _namespace_name "PaymentObligation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/Payer"></see>
    /// </summary>
    let Payer = Namespaced_IRI.parse _namespace_name "Payer" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/Payment"></see>
    /// </summary>
    let Payment = Namespaced_IRI.parse _namespace_name "Payment" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/hasPaymentAmount"></see>
    /// </summary>
    let hasPaymentAmount =
        Namespaced_IRI.parse _namespace_name "hasPaymentAmount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/PaymentEvent"></see>
    /// </summary>
    let PaymentEvent =
        Namespaced_IRI.parse _namespace_name "PaymentEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/PaymentSchedule"></see>
    /// </summary>
    let PaymentSchedule =
        Namespaced_IRI.parse _namespace_name "PaymentSchedule" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/fulfillsObligation"></see>
    /// </summary>
    let fulfillsObligation =
        Namespaced_IRI.parse _namespace_name "fulfillsObligation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/hasPaymentSchedule"></see>
    /// </summary>
    let hasPaymentSchedule =
        Namespaced_IRI.parse _namespace_name "hasPaymentSchedule" |> NamespacedName
