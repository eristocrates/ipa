namespace https.spec.edmcouncil.org.fibo.ontology.IND.MarketIndices.MetadataINDMarketIndices.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_ind_mkt_mod =
    let _namespace_iri = Namespace_Iri fibo_ind_mkt_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-ind-mkt-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata about the EDMC-FIBO Indices and Indicators (IND) Market Indices Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/MetadataINDMarketIndices/">https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/MetadataINDMarketIndices/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_ind_mkt_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-mkt-mod:MarketIndicesModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///
    /// labels<para>"market indices module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/MetadataINDMarketIndices/MarketIndicesModule">https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/MetadataINDMarketIndices/MarketIndicesModule</seealso>
    let MarketIndicesModule =
        Prefixed_Name(fibo_ind_mkt_mod, "MarketIndicesModule") |> PrefixedName
