namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Debt.PoolBackedSecurities.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_sec_dbt_pbs =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/AbsolutePrepaymentRate"></see>
    /// </summary>
    let AbsolutePrepaymentRate =
        Namespaced_IRI.parse _namespace_name "AbsolutePrepaymentRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/DebtPoolStatisticalMeasure"></see>
    /// </summary>
    let DebtPoolStatisticalMeasure =
        Namespaced_IRI.parse _namespace_name "DebtPoolStatisticalMeasure" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/AssetBackedSecurity"></see>
    /// </summary>
    let AssetBackedSecurity =
        Namespaced_IRI.parse _namespace_name "AssetBackedSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/PoolBackedSecurity"></see>
    /// </summary>
    let PoolBackedSecurity =
        Namespaced_IRI.parse _namespace_name "PoolBackedSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/AttachmentPoint"></see>
    /// </summary>
    let AttachmentPoint =
        Namespaced_IRI.parse _namespace_name "AttachmentPoint" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/DefaultRate"></see>
    /// </summary>
    let DefaultRate =
        Namespaced_IRI.parse _namespace_name "DefaultRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/DetachmentPoint"></see>
    /// </summary>
    let DetachmentPoint =
        Namespaced_IRI.parse _namespace_name "DetachmentPoint" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/hasEstimatedTotalCollateralValueAtIssuance"></see>
    /// </summary>
    let hasEstimatedTotalCollateralValueAtIssuance =
        Namespaced_IRI.parse _namespace_name "hasEstimatedTotalCollateralValueAtIssuance" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/isPassThrough"></see>
    /// </summary>
    let isPassThrough =
        Namespaced_IRI.parse _namespace_name "isPassThrough" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/PrepaymentSpeed"></see>
    /// </summary>
    let PrepaymentSpeed =
        Namespaced_IRI.parse _namespace_name "PrepaymentSpeed" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/PrincipalProtectedNote"></see>
    /// </summary>
    let PrincipalProtectedNote =
        Namespaced_IRI.parse _namespace_name "PrincipalProtectedNote" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/StructuredFinanceInstrument"></see>
    /// </summary>
    let StructuredFinanceInstrument =
        Namespaced_IRI.parse _namespace_name "StructuredFinanceInstrument" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/SingleMonthlyMortality"></see>
    /// </summary>
    let SingleMonthlyMortality =
        Namespaced_IRI.parse _namespace_name "SingleMonthlyMortality" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/StructuredFinanceWithoutPrincipalProtection"></see>
    /// </summary>
    let StructuredFinanceWithoutPrincipalProtection =
        Namespaced_IRI.parse _namespace_name "StructuredFinanceWithoutPrincipalProtection" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/Tranche"></see>
    /// </summary>
    let Tranche = Namespaced_IRI.parse _namespace_name "Tranche" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/hasAttachmentPoint"></see>
    /// </summary>
    let hasAttachmentPoint =
        Namespaced_IRI.parse _namespace_name "hasAttachmentPoint" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/hasDetachmentPoint"></see>
    /// </summary>
    let hasDetachmentPoint =
        Namespaced_IRI.parse _namespace_name "hasDetachmentPoint" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/WeightedAverageCoupon"></see>
    /// </summary>
    let WeightedAverageCoupon =
        Namespaced_IRI.parse _namespace_name "WeightedAverageCoupon" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/WeightedAverageLife"></see>
    /// </summary>
    let WeightedAverageLife =
        Namespaced_IRI.parse _namespace_name "WeightedAverageLife" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/WeightedAverageLoanAge"></see>
    /// </summary>
    let WeightedAverageLoanAge =
        Namespaced_IRI.parse _namespace_name "WeightedAverageLoanAge" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/WeightedAverageMaturity"></see>
    /// </summary>
    let WeightedAverageMaturity =
        Namespaced_IRI.parse _namespace_name "WeightedAverageMaturity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/WeightedAverageRemainingTerm"></see>
    /// </summary>
    let WeightedAverageRemainingTerm =
        Namespaced_IRI.parse _namespace_name "WeightedAverageRemainingTerm" |> NamespacedName
