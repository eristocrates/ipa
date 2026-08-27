namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Debt.AssetBackedSecurities.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_sec_dbt_abs =
    let _namespace_iri = Namespace_Iri fibo_sec_dbt_abs |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-sec-dbt-abs:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Asset-backed Securities Ontology"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_sec_dbt_abs, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-abs:AutoAssetBackedSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"auto asset-backed security"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/AutoAssetBackedSecurity">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/AutoAssetBackedSecurity</seealso>
    let AutoAssetBackedSecurity =
        Prefixed_Name(fibo_sec_dbt_abs, "AutoAssetBackedSecurity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-abs:AutoDebtPool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"auto debt pool"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/AutoDebtPool">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/AutoDebtPool</seealso>
    let AutoDebtPool = Prefixed_Name(fibo_sec_dbt_abs, "AutoDebtPool") |> PrefixedName
    /// <summary>
    ///   <para>fibo-sec-dbt-abs:BondPool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bond pool"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/BondPool">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/BondPool</seealso>
    let BondPool = Prefixed_Name(fibo_sec_dbt_abs, "BondPool") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-abs:ConsumerAssetBackedSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"consumer asset-backed security"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/ConsumerAssetBackedSecurity">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/ConsumerAssetBackedSecurity</seealso>
    let ConsumerAssetBackedSecurity =
        Prefixed_Name(fibo_sec_dbt_abs, "ConsumerAssetBackedSecurity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-abs:ControlledAmortizationAssetBackedSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"controlled amortization asset-backed security"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/ControlledAmortizationAssetBackedSecurity">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/ControlledAmortizationAssetBackedSecurity</seealso>
    let ControlledAmortizationAssetBackedSecurity =
        Prefixed_Name(fibo_sec_dbt_abs, "ControlledAmortizationAssetBackedSecurity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-abs:CreditCardAccountPool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"credit card account pool"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/CreditCardAccountPool">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/CreditCardAccountPool</seealso>
    let CreditCardAccountPool =
        Prefixed_Name(fibo_sec_dbt_abs, "CreditCardAccountPool") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-abs:CreditCardAssetBackedSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"credit card asset-backed security"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/CreditCardAssetBackedSecurity">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/CreditCardAssetBackedSecurity</seealso>
    let CreditCardAssetBackedSecurity =
        Prefixed_Name(fibo_sec_dbt_abs, "CreditCardAssetBackedSecurity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-abs:FullyAmortizingAssetBackedSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fully amortizing asset-backed security"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/FullyAmortizingAssetBackedSecurity">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/FullyAmortizingAssetBackedSecurity</seealso>
    let FullyAmortizingAssetBackedSecurity =
        Prefixed_Name(fibo_sec_dbt_abs, "FullyAmortizingAssetBackedSecurity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-abs:HomeEquityLineOfCreditPool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"home equity line of credit pool"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/HomeEquityLineOfCreditPool">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/HomeEquityLineOfCreditPool</seealso>
    let HomeEquityLineOfCreditPool =
        Prefixed_Name(fibo_sec_dbt_abs, "HomeEquityLineOfCreditPool") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-abs:HomeEquityLoanAssetBackedSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"home equity loan asset-backed security"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/HomeEquityLoanAssetBackedSecurity">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/HomeEquityLoanAssetBackedSecurity</seealso>
    let HomeEquityLoanAssetBackedSecurity =
        Prefixed_Name(fibo_sec_dbt_abs, "HomeEquityLoanAssetBackedSecurity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-abs:StudentLoanAssetBackedSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"student loan asset-backed security"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/StudentLoanAssetBackedSecurity">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/StudentLoanAssetBackedSecurity</seealso>
    let StudentLoanAssetBackedSecurity =
        Prefixed_Name(fibo_sec_dbt_abs, "StudentLoanAssetBackedSecurity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-abs:StudentLoanPool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"student loan pool"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/StudentLoanPool">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/StudentLoanPool</seealso>
    let StudentLoanPool =
        Prefixed_Name(fibo_sec_dbt_abs, "StudentLoanPool") |> PrefixedName
