namespace https.spec.edmcouncil.org.fibo.ontology.BP.MetadataBP.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_bp_mod =
    let _namespace_iri = Namespace_Iri fibo_bp_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-bp-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata for the FIBO Business Process (BP) Domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BP/MetadataBP/">https://spec.edmcouncil.org/fibo/ontology/BP/MetadataBP/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_bp_mod, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-bp-mod:BPDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///
    /// labels<para>"business process domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BP/MetadataBP/BPDomain">https://spec.edmcouncil.org/fibo/ontology/BP/MetadataBP/BPDomain</seealso>
    let BPDomain = Prefixed_Name(fibo_bp_mod, "BPDomain") |> PrefixedName
