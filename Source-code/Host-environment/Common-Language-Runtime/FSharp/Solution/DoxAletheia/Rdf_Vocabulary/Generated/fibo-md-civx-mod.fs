namespace https.spec.edmcouncil.org.fibo.ontology.MD.CIVTemporal.MetadataMDCIVTemporal.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_md_civx_mod =
    let _namespace_iri = Namespace_Iri fibo_md_civx_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-md-civx-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata for the EDMC-FIBO Market Data (MD) CIV Temporal Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/MD/CIVTemporal/MetadataMDCIVTemporal/">https://spec.edmcouncil.org/fibo/ontology/MD/CIVTemporal/MetadataMDCIVTemporal/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_md_civx_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-md-civx-mod:CIVTemporalModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"collective investment vehicles temporal module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/MD/CIVTemporal/MetadataMDCIVTemporal/CIVTemporalModule">https://spec.edmcouncil.org/fibo/ontology/MD/CIVTemporal/MetadataMDCIVTemporal/CIVTemporalModule</seealso>
    let CIVTemporalModule =
        Prefixed_Name(fibo_md_civx_mod, "CIVTemporalModule") |> PrefixedName
