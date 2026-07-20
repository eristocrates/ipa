namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Debt.AssetBackedSecurities.slash

open DoxAletheia

module fibo_sec_dbt_abs =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/AutoAssetBackedSecurity"></see>
    /// </summary>
    let AutoAssetBackedSecurity = _prefix "AutoAssetBackedSecurity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/AutoDebtPool"></see>
    /// </summary>
    let AutoDebtPool = _prefix "AutoDebtPool"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/BondPool"></see>
    /// </summary>
    let BondPool = _prefix "BondPool"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/ConsumerAssetBackedSecurity"></see>
    /// </summary>
    let ConsumerAssetBackedSecurity = _prefix "ConsumerAssetBackedSecurity"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/ControlledAmortizationAssetBackedSecurity"></see>
    /// </summary>
    let ControlledAmortizationAssetBackedSecurity =
        _prefix "ControlledAmortizationAssetBackedSecurity"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/CreditCardAccountPool"></see>
    /// </summary>
    let CreditCardAccountPool = _prefix "CreditCardAccountPool"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/CreditCardAssetBackedSecurity"></see>
    /// </summary>
    let CreditCardAssetBackedSecurity = _prefix "CreditCardAssetBackedSecurity"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/FullyAmortizingAssetBackedSecurity"></see>
    /// </summary>
    let FullyAmortizingAssetBackedSecurity =
        _prefix "FullyAmortizingAssetBackedSecurity"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/HomeEquityLineOfCreditPool"></see>
    /// </summary>
    let HomeEquityLineOfCreditPool = _prefix "HomeEquityLineOfCreditPool"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/HomeEquityLoanAssetBackedSecurity"></see>
    /// </summary>
    let HomeEquityLoanAssetBackedSecurity = _prefix "HomeEquityLoanAssetBackedSecurity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/StudentLoanAssetBackedSecurity"></see>
    /// </summary>
    let StudentLoanAssetBackedSecurity = _prefix "StudentLoanAssetBackedSecurity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/StudentLoanPool"></see>
    /// </summary>
    let StudentLoanPool = _prefix "StudentLoanPool"
