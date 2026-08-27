namespace https.spec.edmcouncil.org.fibo.ontology.DER.SecurityBasedDerivatives.MetadataDERSecurityBasedDerivatives.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_der_sbd_mod =
    let _namespace_iri = Namespace_Iri fibo_der_sbd_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-der-sbd-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata about the EDMC-FIBO Derivatives (DER) Security-Based Derivatives Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/MetadataDERSecurityBasedDerivatives/">https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/MetadataDERSecurityBasedDerivatives/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_der_sbd_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-sbd-mod:SecurityBasedDerivativesModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"security-based derivatives module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/MetadataDERSecurityBasedDerivatives/SecurityBasedDerivativesModule">https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/MetadataDERSecurityBasedDerivatives/SecurityBasedDerivativesModule</seealso>
    let SecurityBasedDerivativesModule =
        Prefixed_Name(fibo_der_sbd_mod, "SecurityBasedDerivativesModule") |> PrefixedName
