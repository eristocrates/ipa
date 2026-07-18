namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Securities.SecuritiesIssuance.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_sec_sec_iss =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasFinancialInstrumentShortName"></see>
    /// </summary>
    let hasFinancialInstrumentShortName =
        Namespaced_IRI.parse _namespace_name "hasFinancialInstrumentShortName" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/FinancialInstrumentShortName"></see>
    /// </summary>
    let FinancialInstrumentShortName =
        Namespaced_IRI.parse _namespace_name "FinancialInstrumentShortName" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasIssuerShortName"></see>
    /// </summary>
    let hasIssuerShortName =
        Namespaced_IRI.parse _namespace_name "hasIssuerShortName" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/isIssuedInForm"></see>
    /// </summary>
    let isIssuedInForm =
        Namespaced_IRI.parse _namespace_name "isIssuedInForm" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/SecurityForm"></see>
    /// </summary>
    let SecurityForm =
        Namespaced_IRI.parse _namespace_name "SecurityForm" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/isRegisteredWith"></see>
    /// </summary>
    let isRegisteredWith =
        Namespaced_IRI.parse _namespace_name "isRegisteredWith" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/BearerAndRegisteredForm"></see>
    /// </summary>
    let BearerAndRegisteredForm =
        Namespaced_IRI.parse _namespace_name "BearerAndRegisteredForm" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/BearerForm"></see>
    /// </summary>
    let BearerForm = Namespaced_IRI.parse _namespace_name "BearerForm" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/BestEffortsOffering"></see>
    /// </summary>
    let BestEffortsOffering =
        Namespaced_IRI.parse _namespace_name "BestEffortsOffering" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/SecuritiesOffering"></see>
    /// </summary>
    let SecuritiesOffering =
        Namespaced_IRI.parse _namespace_name "SecuritiesOffering" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/BookEntryForm"></see>
    /// </summary>
    let BookEntryForm =
        Namespaced_IRI.parse _namespace_name "BookEntryForm" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/ConversionTerms"></see>
    /// </summary>
    let ConversionTerms =
        Namespaced_IRI.parse _namespace_name "ConversionTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/specifiesConversionInto"></see>
    /// </summary>
    let specifiesConversionInto =
        Namespaced_IRI.parse _namespace_name "specifiesConversionInto" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/ConvertibleSecurity"></see>
    /// </summary>
    let ConvertibleSecurity =
        Namespaced_IRI.parse _namespace_name "ConvertibleSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/ExemptIssuer"></see>
    /// </summary>
    let ExemptIssuer =
        Namespaced_IRI.parse _namespace_name "ExemptIssuer" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/ExemptOffering"></see>
    /// </summary>
    let ExemptOffering =
        Namespaced_IRI.parse _namespace_name "ExemptOffering" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/PublicOffering"></see>
    /// </summary>
    let PublicOffering =
        Namespaced_IRI.parse _namespace_name "PublicOffering" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/ExemptTransaction"></see>
    /// </summary>
    let ExemptTransaction =
        Namespaced_IRI.parse _namespace_name "ExemptTransaction" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasInstrumentDescription"></see>
    /// </summary>
    let hasInstrumentDescription =
        Namespaced_IRI.parse _namespace_name "hasInstrumentDescription" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/FirmCommitmentOffering"></see>
    /// </summary>
    let FirmCommitmentOffering =
        Namespaced_IRI.parse _namespace_name "FirmCommitmentOffering" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/MiscellaneousForm"></see>
    /// </summary>
    let MiscellaneousForm =
        Namespaced_IRI.parse _namespace_name "MiscellaneousForm" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/OfferingDocument"></see>
    /// </summary>
    let OfferingDocument =
        Namespaced_IRI.parse _namespace_name "OfferingDocument" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/OfferingStatement"></see>
    /// </summary>
    let OfferingStatement =
        Namespaced_IRI.parse _namespace_name "OfferingStatement" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/PrivateOffering"></see>
    /// </summary>
    let PrivateOffering =
        Namespaced_IRI.parse _namespace_name "PrivateOffering" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/PrivatePlacementMemorandum"></see>
    /// </summary>
    let PrivatePlacementMemorandum =
        Namespaced_IRI.parse _namespace_name "PrivatePlacementMemorandum" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/Prospectus"></see>
    /// </summary>
    let Prospectus = Namespaced_IRI.parse _namespace_name "Prospectus" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/RegisteredForm"></see>
    /// </summary>
    let RegisteredForm =
        Namespaced_IRI.parse _namespace_name "RegisteredForm" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/isUnderwrittenBy"></see>
    /// </summary>
    let isUnderwrittenBy =
        Namespaced_IRI.parse _namespace_name "isUnderwrittenBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/SecurityUnderwriter"></see>
    /// </summary>
    let SecurityUnderwriter =
        Namespaced_IRI.parse _namespace_name "SecurityUnderwriter" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/SecurityOfferingDistributionType"></see>
    /// </summary>
    let SecurityOfferingDistributionType =
        Namespaced_IRI.parse _namespace_name "SecurityOfferingDistributionType" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/SecurityUnderwritingArrangement"></see>
    /// </summary>
    let SecurityUnderwritingArrangement =
        Namespaced_IRI.parse _namespace_name "SecurityUnderwritingArrangement" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasActualClosingDate"></see>
    /// </summary>
    let hasActualClosingDate =
        Namespaced_IRI.parse _namespace_name "hasActualClosingDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasAnnouncementDate"></see>
    /// </summary>
    let hasAnnouncementDate =
        Namespaced_IRI.parse _namespace_name "hasAnnouncementDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasFirstTradeDate"></see>
    /// </summary>
    let hasFirstTradeDate =
        Namespaced_IRI.parse _namespace_name "hasFirstTradeDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasFirstTradeSettlementDate"></see>
    /// </summary>
    let hasFirstTradeSettlementDate =
        Namespaced_IRI.parse _namespace_name "hasFirstTradeSettlementDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasSeries"></see>
    /// </summary>
    let hasSeries = Namespaced_IRI.parse _namespace_name "hasSeries" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasSubscriptionAmount"></see>
    /// </summary>
    let hasSubscriptionAmount =
        Namespaced_IRI.parse _namespace_name "hasSubscriptionAmount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasSubscriptionPeriod"></see>
    /// </summary>
    let hasSubscriptionPeriod =
        Namespaced_IRI.parse _namespace_name "hasSubscriptionPeriod" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/isOverAllotted"></see>
    /// </summary>
    let isOverAllotted =
        Namespaced_IRI.parse _namespace_name "isOverAllotted" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/underwrites"></see>
    /// </summary>
    let underwrites =
        Namespaced_IRI.parse _namespace_name "underwrites" |> NamespacedName
