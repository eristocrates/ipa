namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Equities.MetadataSECEquities.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_sec_eq_mod =
    let _namespace_iri = Namespace_Iri fibo_sec_eq_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-sec-eq-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata about the EDMC-FIBO Securities (SEC), Equities Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/MetadataSECEquities/">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/MetadataSECEquities/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_sec_eq_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-eq-mod:EquitiesModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///
    /// labels<para>"equities module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/MetadataSECEquities/EquitiesModule">https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/MetadataSECEquities/EquitiesModule</seealso>
    let EquitiesModule =
        Prefixed_Name(fibo_sec_eq_mod, "EquitiesModule") |> PrefixedName
