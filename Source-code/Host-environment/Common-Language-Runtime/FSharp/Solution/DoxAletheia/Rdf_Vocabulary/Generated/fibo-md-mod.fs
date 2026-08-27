namespace https.spec.edmcouncil.org.fibo.ontology.MD.MetadataMD.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_md_mod =
    let _namespace_iri = Namespace_Iri fibo_md_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-md-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata for the FIBO Market Data (MD) Domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/MD/MetadataMD/">https://spec.edmcouncil.org/fibo/ontology/MD/MetadataMD/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_md_mod, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-md-mod:MDDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///
    /// labels<para>"market data domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/MD/MetadataMD/MDDomain">https://spec.edmcouncil.org/fibo/ontology/MD/MetadataMD/MDDomain</seealso>
    let MDDomain = Prefixed_Name(fibo_md_mod, "MDDomain") |> PrefixedName
