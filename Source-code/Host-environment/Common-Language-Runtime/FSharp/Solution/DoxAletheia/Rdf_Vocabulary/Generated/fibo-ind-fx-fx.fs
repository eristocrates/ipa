namespace https.spec.edmcouncil.org.fibo.ontology.IND.ForeignExchange.ForeignExchange.slash

open DoxAletheia

module fibo_ind_fx_fx =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencyConversionService"></see>
    /// </summary>
    let CurrencyConversionService = _prefix "CurrencyConversionService"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/ForeignExchangeService"></see>
    /// </summary>
    let ForeignExchangeService = _prefix "ForeignExchangeService"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencyForwardRate"></see>
    /// </summary>
    let CurrencyForwardRate = _prefix "CurrencyForwardRate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/QuotedExchangeRate"></see>
    /// </summary>
    let QuotedExchangeRate = _prefix "QuotedExchangeRate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencyForwardRateVolatility"></see>
    /// </summary>
    let CurrencyForwardRateVolatility = _prefix "CurrencyForwardRateVolatility"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/ExchangeRateVolatility"></see>
    /// </summary>
    let ExchangeRateVolatility = _prefix "ExchangeRateVolatility"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencySpotBuyRate"></see>
    /// </summary>
    let CurrencySpotBuyRate = _prefix "CurrencySpotBuyRate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencySpotRate"></see>
    /// </summary>
    let CurrencySpotRate = _prefix "CurrencySpotRate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencySpotMidRate"></see>
    /// </summary>
    let CurrencySpotMidRate = _prefix "CurrencySpotMidRate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencySpotSellRate"></see>
    /// </summary>
    let CurrencySpotSellRate = _prefix "CurrencySpotSellRate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencySpotVolatility"></see>
    /// </summary>
    let CurrencySpotVolatility = _prefix "CurrencySpotVolatility"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/ExchangeRateStructure"></see>
    /// </summary>
    let ExchangeRateStructure = _prefix "ExchangeRateStructure"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/InternationalElectronicFundsTransferService"></see>
    /// </summary>
    let InternationalElectronicFundsTransferService =
        _prefix "InternationalElectronicFundsTransferService"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/hasQuoteCurrency"></see>
    /// </summary>
    let hasQuoteCurrency = _prefix "hasQuoteCurrency"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/hasExchangeRateQuotationSource"></see>
    /// </summary>
    let hasExchangeRateQuotationSource = _prefix "hasExchangeRateQuotationSource"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/hasQuotationBlockAmountBasis"></see>
    /// </summary>
    let hasQuotationBlockAmountBasis = _prefix "hasQuotationBlockAmountBasis"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/hasQuotationSettlementBasis"></see>
    /// </summary>
    let hasQuotationSettlementBasis = _prefix "hasQuotationSettlementBasis"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/hasQuotedExchangeRate"></see>
    /// </summary>
    let hasQuotedExchangeRate = _prefix "hasQuotedExchangeRate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/isPremiumOn"></see>
    /// </summary>
    let isPremiumOn = _prefix "isPremiumOn"
