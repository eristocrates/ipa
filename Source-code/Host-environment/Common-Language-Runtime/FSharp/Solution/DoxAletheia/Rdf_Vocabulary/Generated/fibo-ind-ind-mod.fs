namespace https.spec.edmcouncil.org.fibo.ontology.IND.Indicators.MetadataINDIndicators.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_ind_ind_mod =
    let _namespace_iri = Namespace_Iri fibo_ind_ind_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-ind-ind-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata about the EDMC-FIBO Indices and Indicators (IND) Indicators Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/MetadataINDIndicators/">https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/MetadataINDIndicators/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_ind_ind_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ind-mod:IndicatorsModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///
    /// labels<para>"indicators module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/MetadataINDIndicators/IndicatorsModule">https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/MetadataINDIndicators/IndicatorsModule</seealso>
    let IndicatorsModule =
        Prefixed_Name(fibo_ind_ind_mod, "IndicatorsModule") |> PrefixedName
