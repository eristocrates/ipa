namespace https.spec.edmcouncil.org.fibo.ontology.ACTUS.MetadataACTUS.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_actus_mod =
    let _namespace_iri = Namespace_Iri fibo_actus_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-actus-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata about the FIBO Algorithmic Contract Types Unified Standards (ACTUS) Domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/MetadataACTUS/">https://spec.edmcouncil.org/fibo/ontology/ACTUS/MetadataACTUS/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_actus_mod, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-actus-mod:ACTUSDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTUS domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/ACTUS/MetadataACTUS/ACTUSDomain">https://spec.edmcouncil.org/fibo/ontology/ACTUS/MetadataACTUS/ACTUSDomain</seealso>
    let ACTUSDomain = Prefixed_Name(fibo_actus_mod, "ACTUSDomain") |> PrefixedName
