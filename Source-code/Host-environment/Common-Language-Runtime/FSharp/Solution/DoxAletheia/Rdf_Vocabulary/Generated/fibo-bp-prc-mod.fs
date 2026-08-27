namespace https.spec.edmcouncil.org.fibo.ontology.BP.Process.MetadataBPProcess.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_bp_prc_mod =
    let _namespace_iri = Namespace_Iri fibo_bp_prc_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-bp-prc-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata for the EDMC-FIBO Business Process (BP) Process Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BP/Process/MetadataBPProcess/">https://spec.edmcouncil.org/fibo/ontology/BP/Process/MetadataBPProcess/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_bp_prc_mod, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-bp-prc-mod:ProcessModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"process module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/BP/Process/MetadataBPProcess/ProcessModule">https://spec.edmcouncil.org/fibo/ontology/BP/Process/MetadataBPProcess/ProcessModule</seealso>
    let ProcessModule = Prefixed_Name(fibo_bp_prc_mod, "ProcessModule") |> PrefixedName
