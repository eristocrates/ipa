namespace https.spec.edmcouncil.org.fibo.ontology.SEC.MetadataSEC.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_sec_mod =
    let _namespace_iri = Namespace_Iri fibo_sec_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-sec-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata about the FIBO Securities (SEC) Domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/MetadataSEC/">https://spec.edmcouncil.org/fibo/ontology/SEC/MetadataSEC/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_sec_mod, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-mod:SECDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"securities domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/MetadataSEC/SECDomain">https://spec.edmcouncil.org/fibo/ontology/SEC/MetadataSEC/SECDomain</seealso>
    let SECDomain = Prefixed_Name(fibo_sec_mod, "SECDomain") |> PrefixedName
