namespace https.spec.edmcouncil.org.fibo.ontology.PAY.PaymentServices.PaymentServices.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_pay_ps_ps =
    let _namespace_iri = Namespace_Iri fibo_pay_ps_ps |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-pay-ps-ps:PaymentService</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/PAY/PaymentServices/PaymentServices/PaymentService">https://spec.edmcouncil.org/fibo/ontology/PAY/PaymentServices/PaymentServices/PaymentService</seealso>
    let PaymentService = Prefixed_Name(fibo_pay_ps_ps, "PaymentService") |> PrefixedName
