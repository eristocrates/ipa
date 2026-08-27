namespace https.spec.edmcouncil.org.fibo.ontology.FND.ProductsAndServices.PaymentsAndSchedules.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_pas_psch =
    let _namespace_iri = Namespace_Iri fibo_fnd_pas_psch |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-pas-psch:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Payments and Schedules Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_pas_psch, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-pas-psch:Payee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"payee"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/Payee">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/Payee</seealso>
    let Payee = Prefixed_Name(fibo_fnd_pas_psch, "Payee") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-pas-psch:Payer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"payer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/Payer">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/Payer</seealso>
    let Payer = Prefixed_Name(fibo_fnd_pas_psch, "Payer") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-pas-psch:Payment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"payment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/Payment">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/Payment</seealso>
    let Payment = Prefixed_Name(fibo_fnd_pas_psch, "Payment") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-pas-psch:PaymentEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"payment event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/PaymentEvent">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/PaymentEvent</seealso>
    let PaymentEvent = Prefixed_Name(fibo_fnd_pas_psch, "PaymentEvent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-pas-psch:PaymentObligation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"payment obligation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/PaymentObligation">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/PaymentObligation</seealso>
    let PaymentObligation =
        Prefixed_Name(fibo_fnd_pas_psch, "PaymentObligation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-pas-psch:PaymentSchedule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"payment schedule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/PaymentSchedule">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/PaymentSchedule</seealso>
    let PaymentSchedule =
        Prefixed_Name(fibo_fnd_pas_psch, "PaymentSchedule") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-pas-psch:fulfillsObligation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"fulfills obligation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/fulfillsObligation">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/fulfillsObligation</seealso>
    let fulfillsObligation =
        Prefixed_Name(fibo_fnd_pas_psch, "fulfillsObligation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-pas-psch:hasPaymentAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has payment amount"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/hasPaymentAmount">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/hasPaymentAmount</seealso>
    let hasPaymentAmount =
        Prefixed_Name(fibo_fnd_pas_psch, "hasPaymentAmount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-pas-psch:hasPaymentSchedule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has payment schedule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/hasPaymentSchedule">https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/hasPaymentSchedule</seealso>
    let hasPaymentSchedule =
        Prefixed_Name(fibo_fnd_pas_psch, "hasPaymentSchedule") |> PrefixedName
