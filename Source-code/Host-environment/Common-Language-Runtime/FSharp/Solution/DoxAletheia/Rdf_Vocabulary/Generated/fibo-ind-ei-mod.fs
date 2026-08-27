namespace https.spec.edmcouncil.org.fibo.ontology.IND.EconomicIndicators.MetadataINDEconomicIndicators.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_ind_ei_mod =
    let _namespace_iri = Namespace_Iri fibo_ind_ei_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-ind-ei-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata about the EDMC-FIBO Indices and Indicators (IND) Economic Indicators Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/MetadataINDEconomicIndicators/">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/MetadataINDEconomicIndicators/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_ind_ei_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-ind-ei-mod:EconomicIndicatorsModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"economic indicators module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/MetadataINDEconomicIndicators/EconomicIndicatorsModule">https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/MetadataINDEconomicIndicators/EconomicIndicatorsModule</seealso>
    let EconomicIndicatorsModule =
        Prefixed_Name(fibo_ind_ei_mod, "EconomicIndicatorsModule") |> PrefixedName
