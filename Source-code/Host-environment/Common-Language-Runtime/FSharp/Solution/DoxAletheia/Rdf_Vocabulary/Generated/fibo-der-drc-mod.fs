namespace https.spec.edmcouncil.org.fibo.ontology.DER.DerivativesContracts.MetadataDERDerivativesContracts.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_der_drc_mod =
    let _namespace_iri = Namespace_Iri fibo_der_drc_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-der-drc-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata about the EDMC-FIBO Derivatives (DER) Derivatives Contracts Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/MetadataDERDerivativesContracts/">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/MetadataDERDerivativesContracts/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_der_drc_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-mod:DerivativesContractsModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///
    /// labels<para>"derivatives contracts module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/MetadataDERDerivativesContracts/DerivativesContractsModule">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/MetadataDERDerivativesContracts/DerivativesContractsModule</seealso>
    let DerivativesContractsModule =
        Prefixed_Name(fibo_der_drc_mod, "DerivativesContractsModule") |> PrefixedName
