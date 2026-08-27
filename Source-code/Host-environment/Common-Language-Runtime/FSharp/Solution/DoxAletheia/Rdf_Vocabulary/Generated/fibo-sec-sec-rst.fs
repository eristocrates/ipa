namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Securities.SecuritiesRestrictions.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_sec_sec_rst =
    let _namespace_iri = Namespace_Iri fibo_sec_sec_rst |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-sec-sec-rst:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Securities Restrictions Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_sec_sec_rst, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-rst:ContractualRestriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"contractual restriction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/ContractualRestriction">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/ContractualRestriction</seealso>
    let ContractualRestriction =
        Prefixed_Name(fibo_sec_sec_rst, "ContractualRestriction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-rst:IndividualInvestor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"individual investor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/IndividualInvestor">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/IndividualInvestor</seealso>
    let IndividualInvestor =
        Prefixed_Name(fibo_sec_sec_rst, "IndividualInvestor") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-rst:InstitutionalInvestor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"institutional investor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/InstitutionalInvestor">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/InstitutionalInvestor</seealso>
    let InstitutionalInvestor =
        Prefixed_Name(fibo_sec_sec_rst, "InstitutionalInvestor") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-rst:InvestorsDomicileRestriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"investors' domicile restriction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/InvestorsDomicileRestriction">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/InvestorsDomicileRestriction</seealso>
    let InvestorsDomicileRestriction =
        Prefixed_Name(fibo_sec_sec_rst, "InvestorsDomicileRestriction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-rst:LegalHoldingRestriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"legal holding restriction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/LegalHoldingRestriction">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/LegalHoldingRestriction</seealso>
    let LegalHoldingRestriction =
        Prefixed_Name(fibo_sec_sec_rst, "LegalHoldingRestriction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-rst:QualifiedInvestorRestriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"qualified investor restriction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/QualifiedInvestorRestriction">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/QualifiedInvestorRestriction</seealso>
    let QualifiedInvestorRestriction =
        Prefixed_Name(fibo_sec_sec_rst, "QualifiedInvestorRestriction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-rst:SecuritiesRegulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"securities regulation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/SecuritiesRegulation">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/SecuritiesRegulation</seealso>
    let SecuritiesRegulation =
        Prefixed_Name(fibo_sec_sec_rst, "SecuritiesRegulation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-rst:SecuritiesRestriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"securities restriction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/SecuritiesRestriction">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/SecuritiesRestriction</seealso>
    let SecuritiesRestriction =
        Prefixed_Name(fibo_sec_sec_rst, "SecuritiesRestriction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-rst:TradingRestriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"trading restriction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/TradingRestriction">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/TradingRestriction</seealso>
    let TradingRestriction =
        Prefixed_Name(fibo_sec_sec_rst, "TradingRestriction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-rst:hasHoldingPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has holding period"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/hasHoldingPeriod">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/hasHoldingPeriod</seealso>
    let hasHoldingPeriod =
        Prefixed_Name(fibo_sec_sec_rst, "hasHoldingPeriod") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-rst:hasRestriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has restriction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/hasRestriction">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/hasRestriction</seealso>
    let hasRestriction =
        Prefixed_Name(fibo_sec_sec_rst, "hasRestriction") |> PrefixedName
