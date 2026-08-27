namespace https.spec.edmcouncil.org.fibo.ontology.MD.DebtTemporal.MetadataMDDebtTemporal.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_md_dbtx_mod =
    let _namespace_iri = Namespace_Iri fibo_md_dbtx_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-md-dbtx-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata for the EDMC-FIBO Market Data (MD) DebtTemporal Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/MD/DebtTemporal/MetadataMDDebtTemporal/">https://spec.edmcouncil.org/fibo/ontology/MD/DebtTemporal/MetadataMDDebtTemporal/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_md_dbtx_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-md-dbtx-mod:DebtTemporalModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///
    /// labels<para>"debt temporal module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/MD/DebtTemporal/MetadataMDDebtTemporal/DebtTemporalModule">https://spec.edmcouncil.org/fibo/ontology/MD/DebtTemporal/MetadataMDDebtTemporal/DebtTemporalModule</seealso>
    let DebtTemporalModule =
        Prefixed_Name(fibo_md_dbtx_mod, "DebtTemporalModule") |> PrefixedName
