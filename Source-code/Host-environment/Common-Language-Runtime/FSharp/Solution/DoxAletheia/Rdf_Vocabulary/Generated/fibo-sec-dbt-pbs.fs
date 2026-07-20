namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Debt.PoolBackedSecurities.slash

open DoxAletheia

module fibo_sec_dbt_pbs =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/AbsolutePrepaymentRate"></see>
    /// </summary>
    let AbsolutePrepaymentRate = _prefix "AbsolutePrepaymentRate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/DebtPoolStatisticalMeasure"></see>
    /// </summary>
    let DebtPoolStatisticalMeasure = _prefix "DebtPoolStatisticalMeasure"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/AssetBackedSecurity"></see>
    /// </summary>
    let AssetBackedSecurity = _prefix "AssetBackedSecurity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/PoolBackedSecurity"></see>
    /// </summary>
    let PoolBackedSecurity = _prefix "PoolBackedSecurity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/AttachmentPoint"></see>
    /// </summary>
    let AttachmentPoint = _prefix "AttachmentPoint"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/DefaultRate"></see>
    /// </summary>
    let DefaultRate = _prefix "DefaultRate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/DetachmentPoint"></see>
    /// </summary>
    let DetachmentPoint = _prefix "DetachmentPoint"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/hasEstimatedTotalCollateralValueAtIssuance"></see>
    /// </summary>
    let hasEstimatedTotalCollateralValueAtIssuance =
        _prefix "hasEstimatedTotalCollateralValueAtIssuance"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/isPassThrough"></see>
    /// </summary>
    let isPassThrough = _prefix "isPassThrough"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/PrepaymentSpeed"></see>
    /// </summary>
    let PrepaymentSpeed = _prefix "PrepaymentSpeed"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/PrincipalProtectedNote"></see>
    /// </summary>
    let PrincipalProtectedNote = _prefix "PrincipalProtectedNote"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/StructuredFinanceInstrument"></see>
    /// </summary>
    let StructuredFinanceInstrument = _prefix "StructuredFinanceInstrument"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/SingleMonthlyMortality"></see>
    /// </summary>
    let SingleMonthlyMortality = _prefix "SingleMonthlyMortality"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/StructuredFinanceWithoutPrincipalProtection"></see>
    /// </summary>
    let StructuredFinanceWithoutPrincipalProtection =
        _prefix "StructuredFinanceWithoutPrincipalProtection"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/Tranche"></see>
    /// </summary>
    let Tranche = _prefix "Tranche"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/hasAttachmentPoint"></see>
    /// </summary>
    let hasAttachmentPoint = _prefix "hasAttachmentPoint"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/hasDetachmentPoint"></see>
    /// </summary>
    let hasDetachmentPoint = _prefix "hasDetachmentPoint"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/WeightedAverageCoupon"></see>
    /// </summary>
    let WeightedAverageCoupon = _prefix "WeightedAverageCoupon"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/WeightedAverageLife"></see>
    /// </summary>
    let WeightedAverageLife = _prefix "WeightedAverageLife"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/WeightedAverageLoanAge"></see>
    /// </summary>
    let WeightedAverageLoanAge = _prefix "WeightedAverageLoanAge"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/WeightedAverageMaturity"></see>
    /// </summary>
    let WeightedAverageMaturity = _prefix "WeightedAverageMaturity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/WeightedAverageRemainingTerm"></see>
    /// </summary>
    let WeightedAverageRemainingTerm = _prefix "WeightedAverageRemainingTerm"
