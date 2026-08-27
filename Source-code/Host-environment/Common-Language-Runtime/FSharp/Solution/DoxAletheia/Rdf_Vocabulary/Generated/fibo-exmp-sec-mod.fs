namespace https.spec.edmcouncil.org.fibo.ontology.EXMP.Securities.MetadataEXMPSecurities.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_exmp_sec_mod =
    let _namespace_iri = Namespace_Iri fibo_exmp_sec_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-exmp-sec-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata about the FIBO Example Securities Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/Securities/MetadataEXMPSecurities/">https://spec.edmcouncil.org/fibo/ontology/EXMP/Securities/MetadataEXMPSecurities/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_exmp_sec_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-exmp-sec-mod:ExampleSecuritiesModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///
    /// labels<para>"example securities module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/EXMP/Securities/MetadataEXMPSecurities/ExampleSecuritiesModule">https://spec.edmcouncil.org/fibo/ontology/EXMP/Securities/MetadataEXMPSecurities/ExampleSecuritiesModule</seealso>
    let ExampleSecuritiesModule =
        Prefixed_Name(fibo_exmp_sec_mod, "ExampleSecuritiesModule") |> PrefixedName
