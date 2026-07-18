namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Debt.AssetBackedSecurities.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_sec_dbt_abs =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/AutoAssetBackedSecurity"></see>
    /// </summary>
    let AutoAssetBackedSecurity =
        Namespaced_IRI.parse _namespace_name "AutoAssetBackedSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/AutoDebtPool"></see>
    /// </summary>
    let AutoDebtPool =
        Namespaced_IRI.parse _namespace_name "AutoDebtPool" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/BondPool"></see>
    /// </summary>
    let BondPool = Namespaced_IRI.parse _namespace_name "BondPool" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/ConsumerAssetBackedSecurity"></see>
    /// </summary>
    let ConsumerAssetBackedSecurity =
        Namespaced_IRI.parse _namespace_name "ConsumerAssetBackedSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/ControlledAmortizationAssetBackedSecurity"></see>
    /// </summary>
    let ControlledAmortizationAssetBackedSecurity =
        Namespaced_IRI.parse _namespace_name "ControlledAmortizationAssetBackedSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/CreditCardAccountPool"></see>
    /// </summary>
    let CreditCardAccountPool =
        Namespaced_IRI.parse _namespace_name "CreditCardAccountPool" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/CreditCardAssetBackedSecurity"></see>
    /// </summary>
    let CreditCardAssetBackedSecurity =
        Namespaced_IRI.parse _namespace_name "CreditCardAssetBackedSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/FullyAmortizingAssetBackedSecurity"></see>
    /// </summary>
    let FullyAmortizingAssetBackedSecurity =
        Namespaced_IRI.parse _namespace_name "FullyAmortizingAssetBackedSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/HomeEquityLineOfCreditPool"></see>
    /// </summary>
    let HomeEquityLineOfCreditPool =
        Namespaced_IRI.parse _namespace_name "HomeEquityLineOfCreditPool" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/HomeEquityLoanAssetBackedSecurity"></see>
    /// </summary>
    let HomeEquityLoanAssetBackedSecurity =
        Namespaced_IRI.parse _namespace_name "HomeEquityLoanAssetBackedSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/StudentLoanAssetBackedSecurity"></see>
    /// </summary>
    let StudentLoanAssetBackedSecurity =
        Namespaced_IRI.parse _namespace_name "StudentLoanAssetBackedSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/StudentLoanPool"></see>
    /// </summary>
    let StudentLoanPool =
        Namespaced_IRI.parse _namespace_name "StudentLoanPool" |> NamespacedName
