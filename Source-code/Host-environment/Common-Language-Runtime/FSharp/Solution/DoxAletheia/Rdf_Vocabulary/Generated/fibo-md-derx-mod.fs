namespace https.spec.edmcouncil.org.fibo.ontology.MD.DerivativesTemporal.MetadataMDDerivativesTemporal.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_md_derx_mod =
    let _namespace_iri = Namespace_Iri fibo_md_derx_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-md-derx-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata for the EDMC-FIBO Market Data (MD) DerivativesTemporal Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/MD/DerivativesTemporal/MetadataMDDerivativesTemporal/">https://spec.edmcouncil.org/fibo/ontology/MD/DerivativesTemporal/MetadataMDDerivativesTemporal/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_md_derx_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-md-derx-mod:DerivativesTemporalModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///
    /// labels<para>"derivatives temporal module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/MD/DerivativesTemporal/MetadataMDDerivativesTemporal/DerivativesTemporalModule">https://spec.edmcouncil.org/fibo/ontology/MD/DerivativesTemporal/MetadataMDDerivativesTemporal/DerivativesTemporalModule</seealso>
    let DerivativesTemporalModule =
        Prefixed_Name(fibo_md_derx_mod, "DerivativesTemporalModule") |> PrefixedName
