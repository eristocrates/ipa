namespace https.spec.edmcouncil.org.fibo.ontology.EXMP.MetadataEXMP.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_exmp_mod =
    let _namespace_iri = Namespace_Iri fibo_exmp_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-exmp-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata about the FIBO Examples Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/MetadataEXMP/">https://spec.edmcouncil.org/fibo/ontology/EXMP/MetadataEXMP/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_exmp_mod, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-exmp-mod:ExamplesModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///
    /// labels<para>"examples module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/MetadataEXMP/ExamplesModule">https://spec.edmcouncil.org/fibo/ontology/EXMP/MetadataEXMP/ExamplesModule</seealso>
    let ExamplesModule = Prefixed_Name(fibo_exmp_mod, "ExamplesModule") |> PrefixedName
