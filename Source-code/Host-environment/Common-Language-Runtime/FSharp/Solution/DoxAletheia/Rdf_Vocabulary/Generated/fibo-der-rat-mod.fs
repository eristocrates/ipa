namespace https.spec.edmcouncil.org.fibo.ontology.DER.RateDerivatives.MetadataDERRateDerivatives.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_der_rat_mod =
    let _namespace_iri = Namespace_Iri fibo_der_rat_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-der-rat-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata about the EDMC-FIBO Derivatives (DER) Rate Derivatives Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/MetadataDERRateDerivatives/">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/MetadataDERRateDerivatives/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_der_rat_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-rat-mod:RateDerivativesModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///
    /// labels<para>"rate derivatives module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/MetadataDERRateDerivatives/RateDerivativesModule">https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/MetadataDERRateDerivatives/RateDerivativesModule</seealso>
    let RateDerivativesModule =
        Prefixed_Name(fibo_der_rat_mod, "RateDerivativesModule") |> PrefixedName
