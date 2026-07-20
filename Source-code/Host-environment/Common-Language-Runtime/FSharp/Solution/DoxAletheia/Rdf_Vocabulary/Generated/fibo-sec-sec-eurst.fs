namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Securities.EuropeanSecurities.EUSecuritiesRestrictions.slash

open DoxAletheia

module fibo_sec_sec_eurst =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/AdditionalTier1Capital"></see>
    /// </summary>
    let AdditionalTier1Capital = _prefix "AdditionalTier1Capital"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/BaselIIIDesignation"></see>
    /// </summary>
    let BaselIIIDesignation = _prefix "BaselIIIDesignation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/CommonEquityTier1"></see>
    /// </summary>
    let CommonEquityTier1 = _prefix "CommonEquityTier1"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/EURegulation236-2012"></see>
    /// </summary>
    let ``EURegulation236-2012`` = _prefix "EURegulation236-2012"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/MiFIDRegulatedSecurity"></see>
    /// </summary>
    let MiFIDRegulatedSecurity = _prefix "MiFIDRegulatedSecurity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/isMiFIDReportingRequired"></see>
    /// </summary>
    let isMiFIDReportingRequired = _prefix "isMiFIDReportingRequired"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/hasUpperLimitOnFloatingShares"></see>
    /// </summary>
    let hasUpperLimitOnFloatingShares = _prefix "hasUpperLimitOnFloatingShares"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/Tier1Capital"></see>
    /// </summary>
    let Tier1Capital = _prefix "Tier1Capital"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/Tier2Capital"></see>
    /// </summary>
    let Tier2Capital = _prefix "Tier2Capital"
