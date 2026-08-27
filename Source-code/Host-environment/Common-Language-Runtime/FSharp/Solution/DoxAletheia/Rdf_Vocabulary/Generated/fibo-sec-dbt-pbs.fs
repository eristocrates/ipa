namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Debt.PoolBackedSecurities.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_sec_dbt_pbs =
    let _namespace_iri = Namespace_Iri fibo_sec_dbt_pbs |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-sec-dbt-pbs:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Pool-backed Securities Ontology"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_sec_dbt_pbs, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-pbs:AbsolutePrepaymentRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"absolute prepayment rate"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/AbsolutePrepaymentRate">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/AbsolutePrepaymentRate</seealso>
    let AbsolutePrepaymentRate =
        Prefixed_Name(fibo_sec_dbt_pbs, "AbsolutePrepaymentRate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-pbs:AssetBackedSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"asset-backed security"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/AssetBackedSecurity">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/AssetBackedSecurity</seealso>
    let AssetBackedSecurity =
        Prefixed_Name(fibo_sec_dbt_pbs, "AssetBackedSecurity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-pbs:AttachmentPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"attachment point"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/AttachmentPoint">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/AttachmentPoint</seealso>
    let AttachmentPoint =
        Prefixed_Name(fibo_sec_dbt_pbs, "AttachmentPoint") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-pbs:DebtPoolStatisticalMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"debt pool statistical measure"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/DebtPoolStatisticalMeasure">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/DebtPoolStatisticalMeasure</seealso>
    let DebtPoolStatisticalMeasure =
        Prefixed_Name(fibo_sec_dbt_pbs, "DebtPoolStatisticalMeasure") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-pbs:DefaultRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"default rate"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/DefaultRate">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/DefaultRate</seealso>
    let DefaultRate = Prefixed_Name(fibo_sec_dbt_pbs, "DefaultRate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-pbs:DetachmentPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"detachment point"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/DetachmentPoint">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/DetachmentPoint</seealso>
    let DetachmentPoint =
        Prefixed_Name(fibo_sec_dbt_pbs, "DetachmentPoint") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-pbs:PoolBackedSecurity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"pool-backed security"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/PoolBackedSecurity">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/PoolBackedSecurity</seealso>
    let PoolBackedSecurity =
        Prefixed_Name(fibo_sec_dbt_pbs, "PoolBackedSecurity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-pbs:PrepaymentSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"prepayment speed"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/PrepaymentSpeed">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/PrepaymentSpeed</seealso>
    let PrepaymentSpeed =
        Prefixed_Name(fibo_sec_dbt_pbs, "PrepaymentSpeed") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-pbs:PrincipalProtectedNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"principal protected note"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/PrincipalProtectedNote">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/PrincipalProtectedNote</seealso>
    let PrincipalProtectedNote =
        Prefixed_Name(fibo_sec_dbt_pbs, "PrincipalProtectedNote") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-pbs:SingleMonthlyMortality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"single monthly mortality"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/SingleMonthlyMortality">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/SingleMonthlyMortality</seealso>
    let SingleMonthlyMortality =
        Prefixed_Name(fibo_sec_dbt_pbs, "SingleMonthlyMortality") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-pbs:StructuredFinanceInstrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"structured finance instrument"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/StructuredFinanceInstrument">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/StructuredFinanceInstrument</seealso>
    let StructuredFinanceInstrument =
        Prefixed_Name(fibo_sec_dbt_pbs, "StructuredFinanceInstrument") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-pbs:StructuredFinanceWithoutPrincipalProtection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"structured finance without principal protection"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/StructuredFinanceWithoutPrincipalProtection">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/StructuredFinanceWithoutPrincipalProtection</seealso>
    let StructuredFinanceWithoutPrincipalProtection =
        Prefixed_Name(fibo_sec_dbt_pbs, "StructuredFinanceWithoutPrincipalProtection") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-pbs:Tranche</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"tranche"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/Tranche">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/Tranche</seealso>
    let Tranche = Prefixed_Name(fibo_sec_dbt_pbs, "Tranche") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-pbs:WeightedAverageCoupon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"weighted average coupon"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/WeightedAverageCoupon">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/WeightedAverageCoupon</seealso>
    let WeightedAverageCoupon =
        Prefixed_Name(fibo_sec_dbt_pbs, "WeightedAverageCoupon") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-pbs:WeightedAverageLife</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"weighted average life"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/WeightedAverageLife">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/WeightedAverageLife</seealso>
    let WeightedAverageLife =
        Prefixed_Name(fibo_sec_dbt_pbs, "WeightedAverageLife") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-pbs:WeightedAverageLoanAge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"weighted average loan age"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/WeightedAverageLoanAge">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/WeightedAverageLoanAge</seealso>
    let WeightedAverageLoanAge =
        Prefixed_Name(fibo_sec_dbt_pbs, "WeightedAverageLoanAge") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-pbs:WeightedAverageMaturity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"weighted average maturity"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/WeightedAverageMaturity">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/WeightedAverageMaturity</seealso>
    let WeightedAverageMaturity =
        Prefixed_Name(fibo_sec_dbt_pbs, "WeightedAverageMaturity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-pbs:WeightedAverageRemainingTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"weighted average remaining term"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/WeightedAverageRemainingTerm">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/WeightedAverageRemainingTerm</seealso>
    let WeightedAverageRemainingTerm =
        Prefixed_Name(fibo_sec_dbt_pbs, "WeightedAverageRemainingTerm") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-pbs:hasAttachmentPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has attachment point"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/hasAttachmentPoint">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/hasAttachmentPoint</seealso>
    let hasAttachmentPoint =
        Prefixed_Name(fibo_sec_dbt_pbs, "hasAttachmentPoint") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-pbs:hasDetachmentPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has detachment point"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/hasDetachmentPoint">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/hasDetachmentPoint</seealso>
    let hasDetachmentPoint =
        Prefixed_Name(fibo_sec_dbt_pbs, "hasDetachmentPoint") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-pbs:hasEstimatedTotalCollateralValueAtIssuance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is estimated value of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/hasEstimatedTotalCollateralValueAtIssuance">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/hasEstimatedTotalCollateralValueAtIssuance</seealso>
    let hasEstimatedTotalCollateralValueAtIssuance =
        Prefixed_Name(fibo_sec_dbt_pbs, "hasEstimatedTotalCollateralValueAtIssuance") |> PrefixedName

    /// <summary>
    ///   <para>fibo-sec-dbt-pbs:isPassThrough</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is pass through"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/isPassThrough">https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/isPassThrough</seealso>
    let isPassThrough = Prefixed_Name(fibo_sec_dbt_pbs, "isPassThrough") |> PrefixedName
