namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Securities.MetadataSECSecurities.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_sec_sec_mod =
    let _namespace_iri = Namespace_Iri fibo_sec_sec_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-sec-sec-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata about the EDMC-FIBO Securities (SEC), Securities Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/MetadataSECSecurities/">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/MetadataSECSecurities/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_sec_sec_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-mod:SecuritiesModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///
    /// labels<para>"securities module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/MetadataSECSecurities/SecuritiesModule">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/MetadataSECSecurities/SecuritiesModule</seealso>
    let SecuritiesModule =
        Prefixed_Name(fibo_sec_sec_mod, "SecuritiesModule") |> PrefixedName
