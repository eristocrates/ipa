namespace https.spec.edmcouncil.org.fibo.ontology.DER.CreditDerivatives.MetadataDERCreditDerivatives.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_der_cr_mod =
    let _namespace_iri = Namespace_Iri fibo_der_cr_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-der-cr-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata about the EDMC-FIBO Derivatives (DER) Credit Derivatives Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/MetadataDERCreditDerivatives/">https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/MetadataDERCreditDerivatives/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_der_cr_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-cr-mod:CreditDerivativesModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"credit derivatives module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/MetadataDERCreditDerivatives/CreditDerivativesModule">https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/MetadataDERCreditDerivatives/CreditDerivativesModule</seealso>
    let CreditDerivativesModule =
        Prefixed_Name(fibo_der_cr_mod, "CreditDerivativesModule") |> PrefixedName
