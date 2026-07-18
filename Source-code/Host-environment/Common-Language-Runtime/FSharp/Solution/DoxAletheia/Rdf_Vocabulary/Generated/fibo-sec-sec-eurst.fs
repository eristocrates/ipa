namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Securities.EuropeanSecurities.EUSecuritiesRestrictions.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_sec_sec_eurst =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/AdditionalTier1Capital"></see>
    /// </summary>
    let AdditionalTier1Capital =
        Namespaced_IRI.parse _namespace_name "AdditionalTier1Capital" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/BaselIIIDesignation"></see>
    /// </summary>
    let BaselIIIDesignation =
        Namespaced_IRI.parse _namespace_name "BaselIIIDesignation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/CommonEquityTier1"></see>
    /// </summary>
    let CommonEquityTier1 =
        Namespaced_IRI.parse _namespace_name "CommonEquityTier1" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/EURegulation236-2012"></see>
    /// </summary>
    let ``EURegulation236-2012`` =
        Namespaced_IRI.parse _namespace_name "EURegulation236-2012" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/MiFIDRegulatedSecurity"></see>
    /// </summary>
    let MiFIDRegulatedSecurity =
        Namespaced_IRI.parse _namespace_name "MiFIDRegulatedSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/isMiFIDReportingRequired"></see>
    /// </summary>
    let isMiFIDReportingRequired =
        Namespaced_IRI.parse _namespace_name "isMiFIDReportingRequired" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/hasUpperLimitOnFloatingShares"></see>
    /// </summary>
    let hasUpperLimitOnFloatingShares =
        Namespaced_IRI.parse _namespace_name "hasUpperLimitOnFloatingShares" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/Tier1Capital"></see>
    /// </summary>
    let Tier1Capital =
        Namespaced_IRI.parse _namespace_name "Tier1Capital" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/Tier2Capital"></see>
    /// </summary>
    let Tier2Capital =
        Namespaced_IRI.parse _namespace_name "Tier2Capital" |> NamespacedName
