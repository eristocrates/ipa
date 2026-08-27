namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Securities.EuropeanSecurities.EUSecuritiesRestrictions.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_sec_sec_eurst =
    let _namespace_iri = Namespace_Iri fibo_sec_sec_eurst |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-sec-sec-eurst:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"EU Securities Restrictions Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_sec_sec_eurst, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-eurst:AdditionalTier1Capital</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-sec-sec-eurst:BaselIIIDesignation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"additional tier 1 capital"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/AdditionalTier1Capital">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/AdditionalTier1Capital</seealso>
    let AdditionalTier1Capital =
        Prefixed_Name(fibo_sec_sec_eurst, "AdditionalTier1Capital") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-eurst:BaselIIIDesignation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Basel III Designation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/BaselIIIDesignation">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/BaselIIIDesignation</seealso>
    let BaselIIIDesignation =
        Prefixed_Name(fibo_sec_sec_eurst, "BaselIIIDesignation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-eurst:CommonEquityTier1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-sec-sec-eurst:BaselIIIDesignation</para>
    ///
    /// labels<para>"common equity tier 1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/CommonEquityTier1">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/CommonEquityTier1</seealso>
    let CommonEquityTier1 =
        Prefixed_Name(fibo_sec_sec_eurst, "CommonEquityTier1") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-eurst:EURegulation236-2012</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-sec-sec-rst:TradingRestriction</para>
    ///   <para>fibo-sec-sec-rst:SecuritiesRegulation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EU Regulation 236/2012"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/EURegulation236-2012">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/EURegulation236-2012</seealso>
    let EURegulation236_2012 =
        Prefixed_Name(fibo_sec_sec_eurst, "EURegulation236-2012") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-eurst:MiFIDRegulatedSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"MiFID regulated security"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/MiFIDRegulatedSecurity">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/MiFIDRegulatedSecurity</seealso>
    let MiFIDRegulatedSecurity =
        Prefixed_Name(fibo_sec_sec_eurst, "MiFIDRegulatedSecurity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-eurst:Tier1Capital</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-sec-sec-eurst:BaselIIIDesignation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"tier 1 capital"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/Tier1Capital">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/Tier1Capital</seealso>
    let Tier1Capital = Prefixed_Name(fibo_sec_sec_eurst, "Tier1Capital") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-sec-eurst:Tier2Capital</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-sec-sec-eurst:BaselIIIDesignation</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"tier 2 capital"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/Tier2Capital">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/Tier2Capital</seealso>
    let Tier2Capital = Prefixed_Name(fibo_sec_sec_eurst, "Tier2Capital") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-eurst:hasUpperLimitOnFloatingShares</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has upper limit on floating shares"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/hasUpperLimitOnFloatingShares">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/hasUpperLimitOnFloatingShares</seealso>
    let hasUpperLimitOnFloatingShares =
        Prefixed_Name(fibo_sec_sec_eurst, "hasUpperLimitOnFloatingShares") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-sec-eurst:isMiFIDReportingRequired</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is MiFID reporting required"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/isMiFIDReportingRequired">https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/isMiFIDReportingRequired</seealso>
    let isMiFIDReportingRequired =
        Prefixed_Name(fibo_sec_sec_eurst, "isMiFIDReportingRequired") |> PrefixedName
