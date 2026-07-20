namespace https.spec.edmcouncil.org.fibo.ontology.DER.DerivativesContracts.RightsAndWarrants.slash

open DoxAletheia

module fibo_der_drc_raw =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/AllotmentRight"></see>
    /// </summary>
    let AllotmentRight = _prefix "AllotmentRight"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/AllotmentRightFormula"></see>
    /// </summary>
    let AllotmentRightFormula = _prefix "AllotmentRightFormula"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/BarrierInstrumentBasedMiniFutureCertificate"></see>
    /// </summary>
    let BarrierInstrumentBasedMiniFutureCertificate =
        _prefix "BarrierInstrumentBasedMiniFutureCertificate"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/MiniFutureCertificate"></see>
    /// </summary>
    let MiniFutureCertificate = _prefix "MiniFutureCertificate"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/BarrierUnderlyingMiniFutureCertificate"></see>
    /// </summary>
    let BarrierUnderlyingMiniFutureCertificate =
        _prefix "BarrierUnderlyingMiniFutureCertificate"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/BasketWarrant"></see>
    /// </summary>
    let BasketWarrant = _prefix "BasketWarrant"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/Warrant"></see>
    /// </summary>
    let Warrant = _prefix "Warrant"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/BondPurchaseRight"></see>
    /// </summary>
    let BondPurchaseRight = _prefix "BondPurchaseRight"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/PurchaseRight"></see>
    /// </summary>
    let PurchaseRight = _prefix "PurchaseRight"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/BondSubscriptionRight"></see>
    /// </summary>
    let BondSubscriptionRight = _prefix "BondSubscriptionRight"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/SubscriptionRight"></see>
    /// </summary>
    let SubscriptionRight = _prefix "SubscriptionRight"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CallPutWarrant"></see>
    /// </summary>
    let CallPutWarrant = _prefix "CallPutWarrant"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CallWarrant"></see>
    /// </summary>
    let CallWarrant = _prefix "CallWarrant"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/PutWarrant"></see>
    /// </summary>
    let PutWarrant = _prefix "PutWarrant"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CombinedInstrumentsPurchaseRight"></see>
    /// </summary>
    let CombinedInstrumentsPurchaseRight = _prefix "CombinedInstrumentsPurchaseRight"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CombinedInstrumentsSubscriptionRight"></see>
    /// </summary>
    let CombinedInstrumentsSubscriptionRight =
        _prefix "CombinedInstrumentsSubscriptionRight"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CommodityWarrant"></see>
    /// </summary>
    let CommodityWarrant = _prefix "CommodityWarrant"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CommonConvertibleSharePurchaseRight"></see>
    /// </summary>
    let CommonConvertibleSharePurchaseRight =
        _prefix "CommonConvertibleSharePurchaseRight"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CommonConvertibleShareSubscriptionRight"></see>
    /// </summary>
    let CommonConvertibleShareSubscriptionRight =
        _prefix "CommonConvertibleShareSubscriptionRight"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CommonSharePurchaseRight"></see>
    /// </summary>
    let CommonSharePurchaseRight = _prefix "CommonSharePurchaseRight"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CommonShareSubscriptionRight"></see>
    /// </summary>
    let CommonShareSubscriptionRight = _prefix "CommonShareSubscriptionRight"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CompanyWarrant"></see>
    /// </summary>
    let CompanyWarrant = _prefix "CompanyWarrant"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/EquityWarrant"></see>
    /// </summary>
    let EquityWarrant = _prefix "EquityWarrant"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/ConstantLeverageCertificate"></see>
    /// </summary>
    let ConstantLeverageCertificate = _prefix "ConstantLeverageCertificate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CoveredWarrant"></see>
    /// </summary>
    let CoveredWarrant = _prefix "CoveredWarrant"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/CurrencyWarrant"></see>
    /// </summary>
    let CurrencyWarrant = _prefix "CurrencyWarrant"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/DebtWarrant"></see>
    /// </summary>
    let DebtWarrant = _prefix "DebtWarrant"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/TraditionalWarrant"></see>
    /// </summary>
    let TraditionalWarrant = _prefix "TraditionalWarrant"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/ExchangeTradedWarrant"></see>
    /// </summary>
    let ExchangeTradedWarrant = _prefix "ExchangeTradedWarrant"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/PublicWarrant"></see>
    /// </summary>
    let PublicWarrant = _prefix "PublicWarrant"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/ExoticWarrant"></see>
    /// </summary>
    let ExoticWarrant = _prefix "ExoticWarrant"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/IndexWarrant"></see>
    /// </summary>
    let IndexWarrant = _prefix "IndexWarrant"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/LongMiniFutureCertificate"></see>
    /// </summary>
    let LongMiniFutureCertificate = _prefix "LongMiniFutureCertificate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/NakedWarrant"></see>
    /// </summary>
    let NakedWarrant = _prefix "NakedWarrant"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/PerpetualWarrant"></see>
    /// </summary>
    let PerpetualWarrant = _prefix "PerpetualWarrant"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/PreferredConvertibleSharePurchaseRight"></see>
    /// </summary>
    let PreferredConvertibleSharePurchaseRight =
        _prefix "PreferredConvertibleSharePurchaseRight"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/PreferredConvertibleShareSubscriptionRight"></see>
    /// </summary>
    let PreferredConvertibleShareSubscriptionRight =
        _prefix "PreferredConvertibleShareSubscriptionRight"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/PreferredSharePurchaseRight"></see>
    /// </summary>
    let PreferredSharePurchaseRight = _prefix "PreferredSharePurchaseRight"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/PreferredShareSubscriptionRight"></see>
    /// </summary>
    let PreferredShareSubscriptionRight = _prefix "PreferredShareSubscriptionRight"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/PrivateWarrant"></see>
    /// </summary>
    let PrivateWarrant = _prefix "PrivateWarrant"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/ShortMiniFutureCertificate"></see>
    /// </summary>
    let ShortMiniFutureCertificate = _prefix "ShortMiniFutureCertificate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/StructuredWarrant"></see>
    /// </summary>
    let StructuredWarrant = _prefix "StructuredWarrant"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/hasConversionRatio"></see>
    /// </summary>
    let hasConversionRatio = _prefix "hasConversionRatio"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/hasOversubscribeOption"></see>
    /// </summary>
    let hasOversubscribeOption = _prefix "hasOversubscribeOption"
