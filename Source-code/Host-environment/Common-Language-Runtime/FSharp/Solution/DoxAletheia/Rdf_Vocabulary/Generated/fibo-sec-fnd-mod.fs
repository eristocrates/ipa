namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Funds.MetadataSECFunds.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_sec_fnd_mod =
    let _namespace_iri = Namespace_Iri fibo_sec_fnd_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-sec-fnd-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata SEC Funds Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/MetadataSECFunds/">https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/MetadataSECFunds/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_sec_fnd_mod, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-fnd-mod:FundsModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"funds module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/MetadataSECFunds/FundsModule">https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/MetadataSECFunds/FundsModule</seealso>
    let FundsModule = Prefixed_Name(fibo_sec_fnd_mod, "FundsModule") |> PrefixedName
