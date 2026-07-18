namespace https.spec.edmcouncil.org.fibo.ontology.IND.ForeignExchange.ForeignExchange.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_ind_fx_fx =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencyConversionService"></see>
    /// </summary>
    let CurrencyConversionService =
        Namespaced_IRI.parse _namespace_name "CurrencyConversionService" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/ForeignExchangeService"></see>
    /// </summary>
    let ForeignExchangeService =
        Namespaced_IRI.parse _namespace_name "ForeignExchangeService" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencyForwardRate"></see>
    /// </summary>
    let CurrencyForwardRate =
        Namespaced_IRI.parse _namespace_name "CurrencyForwardRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/QuotedExchangeRate"></see>
    /// </summary>
    let QuotedExchangeRate =
        Namespaced_IRI.parse _namespace_name "QuotedExchangeRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencyForwardRateVolatility"></see>
    /// </summary>
    let CurrencyForwardRateVolatility =
        Namespaced_IRI.parse _namespace_name "CurrencyForwardRateVolatility" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/ExchangeRateVolatility"></see>
    /// </summary>
    let ExchangeRateVolatility =
        Namespaced_IRI.parse _namespace_name "ExchangeRateVolatility" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencySpotBuyRate"></see>
    /// </summary>
    let CurrencySpotBuyRate =
        Namespaced_IRI.parse _namespace_name "CurrencySpotBuyRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencySpotRate"></see>
    /// </summary>
    let CurrencySpotRate =
        Namespaced_IRI.parse _namespace_name "CurrencySpotRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencySpotMidRate"></see>
    /// </summary>
    let CurrencySpotMidRate =
        Namespaced_IRI.parse _namespace_name "CurrencySpotMidRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencySpotSellRate"></see>
    /// </summary>
    let CurrencySpotSellRate =
        Namespaced_IRI.parse _namespace_name "CurrencySpotSellRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/CurrencySpotVolatility"></see>
    /// </summary>
    let CurrencySpotVolatility =
        Namespaced_IRI.parse _namespace_name "CurrencySpotVolatility" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/ExchangeRateStructure"></see>
    /// </summary>
    let ExchangeRateStructure =
        Namespaced_IRI.parse _namespace_name "ExchangeRateStructure" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/InternationalElectronicFundsTransferService"></see>
    /// </summary>
    let InternationalElectronicFundsTransferService =
        Namespaced_IRI.parse _namespace_name "InternationalElectronicFundsTransferService" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/hasQuoteCurrency"></see>
    /// </summary>
    let hasQuoteCurrency =
        Namespaced_IRI.parse _namespace_name "hasQuoteCurrency" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/hasExchangeRateQuotationSource"></see>
    /// </summary>
    let hasExchangeRateQuotationSource =
        Namespaced_IRI.parse _namespace_name "hasExchangeRateQuotationSource" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/hasQuotationBlockAmountBasis"></see>
    /// </summary>
    let hasQuotationBlockAmountBasis =
        Namespaced_IRI.parse _namespace_name "hasQuotationBlockAmountBasis" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/hasQuotationSettlementBasis"></see>
    /// </summary>
    let hasQuotationSettlementBasis =
        Namespaced_IRI.parse _namespace_name "hasQuotationSettlementBasis" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/hasQuotedExchangeRate"></see>
    /// </summary>
    let hasQuotedExchangeRate =
        Namespaced_IRI.parse _namespace_name "hasQuotedExchangeRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/isPremiumOn"></see>
    /// </summary>
    let isPremiumOn =
        Namespaced_IRI.parse _namespace_name "isPremiumOn" |> NamespacedName
