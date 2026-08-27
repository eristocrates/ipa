namespace https.spec.edmcouncil.org.fibo.ontology.MD.TemporalCore.MetadataMDTemporalCore.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_md_temx_mod =
    let _namespace_iri = Namespace_Iri fibo_md_temx_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-md-temx-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata for the EDMC-FIBO Market Data (MD) TemporalCore Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/MD/TemporalCore/MetadataMDTemporalCore/">https://spec.edmcouncil.org/fibo/ontology/MD/TemporalCore/MetadataMDTemporalCore/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_md_temx_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-md-temx-mod:TemporalCoreModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///
    /// labels<para>"temporal core module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/MD/TemporalCore/MetadataMDTemporalCore/TemporalCoreModule">https://spec.edmcouncil.org/fibo/ontology/MD/TemporalCore/MetadataMDTemporalCore/TemporalCoreModule</seealso>
    let TemporalCoreModule =
        Prefixed_Name(fibo_md_temx_mod, "TemporalCoreModule") |> PrefixedName
