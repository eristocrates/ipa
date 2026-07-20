namespace https.spec.edmcouncil.org.fibo.ontology.SEC.Securities.SecuritiesIssuance.slash

open DoxAletheia

module fibo_sec_sec_iss =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasFinancialInstrumentShortName"></see>
    /// </summary>
    let hasFinancialInstrumentShortName = _prefix "hasFinancialInstrumentShortName"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/FinancialInstrumentShortName"></see>
    /// </summary>
    let FinancialInstrumentShortName = _prefix "FinancialInstrumentShortName"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasIssuerShortName"></see>
    /// </summary>
    let hasIssuerShortName = _prefix "hasIssuerShortName"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/isIssuedInForm"></see>
    /// </summary>
    let isIssuedInForm = _prefix "isIssuedInForm"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/SecurityForm"></see>
    /// </summary>
    let SecurityForm = _prefix "SecurityForm"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/isRegisteredWith"></see>
    /// </summary>
    let isRegisteredWith = _prefix "isRegisteredWith"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/BearerAndRegisteredForm"></see>
    /// </summary>
    let BearerAndRegisteredForm = _prefix "BearerAndRegisteredForm"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/BearerForm"></see>
    /// </summary>
    let BearerForm = _prefix "BearerForm"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/BestEffortsOffering"></see>
    /// </summary>
    let BestEffortsOffering = _prefix "BestEffortsOffering"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/SecuritiesOffering"></see>
    /// </summary>
    let SecuritiesOffering = _prefix "SecuritiesOffering"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/BookEntryForm"></see>
    /// </summary>
    let BookEntryForm = _prefix "BookEntryForm"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/ConversionTerms"></see>
    /// </summary>
    let ConversionTerms = _prefix "ConversionTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/specifiesConversionInto"></see>
    /// </summary>
    let specifiesConversionInto = _prefix "specifiesConversionInto"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/ConvertibleSecurity"></see>
    /// </summary>
    let ConvertibleSecurity = _prefix "ConvertibleSecurity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/ExemptIssuer"></see>
    /// </summary>
    let ExemptIssuer = _prefix "ExemptIssuer"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/ExemptOffering"></see>
    /// </summary>
    let ExemptOffering = _prefix "ExemptOffering"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/PublicOffering"></see>
    /// </summary>
    let PublicOffering = _prefix "PublicOffering"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/ExemptTransaction"></see>
    /// </summary>
    let ExemptTransaction = _prefix "ExemptTransaction"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasInstrumentDescription"></see>
    /// </summary>
    let hasInstrumentDescription = _prefix "hasInstrumentDescription"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/FirmCommitmentOffering"></see>
    /// </summary>
    let FirmCommitmentOffering = _prefix "FirmCommitmentOffering"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/MiscellaneousForm"></see>
    /// </summary>
    let MiscellaneousForm = _prefix "MiscellaneousForm"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/OfferingDocument"></see>
    /// </summary>
    let OfferingDocument = _prefix "OfferingDocument"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/OfferingStatement"></see>
    /// </summary>
    let OfferingStatement = _prefix "OfferingStatement"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/PrivateOffering"></see>
    /// </summary>
    let PrivateOffering = _prefix "PrivateOffering"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/PrivatePlacementMemorandum"></see>
    /// </summary>
    let PrivatePlacementMemorandum = _prefix "PrivatePlacementMemorandum"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/Prospectus"></see>
    /// </summary>
    let Prospectus = _prefix "Prospectus"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/RegisteredForm"></see>
    /// </summary>
    let RegisteredForm = _prefix "RegisteredForm"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/isUnderwrittenBy"></see>
    /// </summary>
    let isUnderwrittenBy = _prefix "isUnderwrittenBy"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/SecurityUnderwriter"></see>
    /// </summary>
    let SecurityUnderwriter = _prefix "SecurityUnderwriter"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/SecurityOfferingDistributionType"></see>
    /// </summary>
    let SecurityOfferingDistributionType = _prefix "SecurityOfferingDistributionType"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/SecurityUnderwritingArrangement"></see>
    /// </summary>
    let SecurityUnderwritingArrangement = _prefix "SecurityUnderwritingArrangement"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasActualClosingDate"></see>
    /// </summary>
    let hasActualClosingDate = _prefix "hasActualClosingDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasAnnouncementDate"></see>
    /// </summary>
    let hasAnnouncementDate = _prefix "hasAnnouncementDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasFirstTradeDate"></see>
    /// </summary>
    let hasFirstTradeDate = _prefix "hasFirstTradeDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasFirstTradeSettlementDate"></see>
    /// </summary>
    let hasFirstTradeSettlementDate = _prefix "hasFirstTradeSettlementDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasSeries"></see>
    /// </summary>
    let hasSeries = _prefix "hasSeries"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasSubscriptionAmount"></see>
    /// </summary>
    let hasSubscriptionAmount = _prefix "hasSubscriptionAmount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/hasSubscriptionPeriod"></see>
    /// </summary>
    let hasSubscriptionPeriod = _prefix "hasSubscriptionPeriod"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/isOverAllotted"></see>
    /// </summary>
    let isOverAllotted = _prefix "isOverAllotted"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/underwrites"></see>
    /// </summary>
    let underwrites = _prefix "underwrites"
