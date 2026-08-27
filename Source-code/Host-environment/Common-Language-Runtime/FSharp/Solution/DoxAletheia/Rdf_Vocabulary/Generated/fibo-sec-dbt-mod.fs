namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Debt.MetadataSECDebt.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_sec_dbt_mod =
    let _namespace_iri = Namespace_Iri fibo_sec_dbt_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-sec-dbt-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata about the EDMC-FIBO Securities (SEC) Debt Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/MetadataSECDebt/">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/MetadataSECDebt/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_sec_dbt_mod, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-dbt-mod:DebtModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"debt module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/MetadataSECDebt/DebtModule">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/MetadataSECDebt/DebtModule</seealso>
    let DebtModule = Prefixed_Name(fibo_sec_dbt_mod, "DebtModule") |> PrefixedName
