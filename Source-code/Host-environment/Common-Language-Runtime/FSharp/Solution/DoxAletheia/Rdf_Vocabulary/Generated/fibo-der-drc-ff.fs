namespace https.spec.edmcouncil.org.fibo.ontology.DER.DerivativesContracts.FuturesAndForwards.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_der_drc_ff =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/BasketFuture"></see>
    /// </summary>
    let BasketFuture =
        Namespaced_IRI.parse _namespace_name "BasketFuture" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/FinancialFuture"></see>
    /// </summary>
    let FinancialFuture =
        Namespaced_IRI.parse _namespace_name "FinancialFuture" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/BondFuture"></see>
    /// </summary>
    let BondFuture = Namespaced_IRI.parse _namespace_name "BondFuture" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/DebtInstrumentFuture"></see>
    /// </summary>
    let DebtInstrumentFuture =
        Namespaced_IRI.parse _namespace_name "DebtInstrumentFuture" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/CurrencyFuture"></see>
    /// </summary>
    let CurrencyFuture =
        Namespaced_IRI.parse _namespace_name "CurrencyFuture" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/DividendAdjustmentPeriod"></see>
    /// </summary>
    let DividendAdjustmentPeriod =
        Namespaced_IRI.parse _namespace_name "DividendAdjustmentPeriod" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/DividendFuture"></see>
    /// </summary>
    let DividendFuture =
        Namespaced_IRI.parse _namespace_name "DividendFuture" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/EquityForward"></see>
    /// </summary>
    let EquityForward =
        Namespaced_IRI.parse _namespace_name "EquityForward" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/Forward"></see>
    /// </summary>
    let Forward = Namespaced_IRI.parse _namespace_name "Forward" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/hasDividendAdjustmentPeriod"></see>
    /// </summary>
    let hasDividendAdjustmentPeriod =
        Namespaced_IRI.parse _namespace_name "hasDividendAdjustmentPeriod" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/hasMethodOfAdjustment"></see>
    /// </summary>
    let hasMethodOfAdjustment =
        Namespaced_IRI.parse _namespace_name "hasMethodOfAdjustment" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/ForwardContractAdjustmentMethod"></see>
    /// </summary>
    let ForwardContractAdjustmentMethod =
        Namespaced_IRI.parse _namespace_name "ForwardContractAdjustmentMethod" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/EquityFuture"></see>
    /// </summary>
    let EquityFuture =
        Namespaced_IRI.parse _namespace_name "EquityFuture" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/FutureOnFuture"></see>
    /// </summary>
    let FutureOnFuture =
        Namespaced_IRI.parse _namespace_name "FutureOnFuture" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/FutureOnOption"></see>
    /// </summary>
    let FutureOnOption =
        Namespaced_IRI.parse _namespace_name "FutureOnOption" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/FutureOnSwap"></see>
    /// </summary>
    let FutureOnSwap =
        Namespaced_IRI.parse _namespace_name "FutureOnSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/IndexFuture"></see>
    /// </summary>
    let IndexFuture =
        Namespaced_IRI.parse _namespace_name "IndexFuture" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/InterestRateFuture"></see>
    /// </summary>
    let InterestRateFuture =
        Namespaced_IRI.parse _namespace_name "InterestRateFuture" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/MoneyMarketFuture"></see>
    /// </summary>
    let MoneyMarketFuture =
        Namespaced_IRI.parse _namespace_name "MoneyMarketFuture" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/StandardizedFuturesListingTerms"></see>
    /// </summary>
    let StandardizedFuturesListingTerms =
        Namespaced_IRI.parse _namespace_name "StandardizedFuturesListingTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/StandardizedFuturesTerms"></see>
    /// </summary>
    let StandardizedFuturesTerms =
        Namespaced_IRI.parse _namespace_name "StandardizedFuturesTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/hasConversionFactor"></see>
    /// </summary>
    let hasConversionFactor =
        Namespaced_IRI.parse _namespace_name "hasConversionFactor" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/hasMultiple"></see>
    /// </summary>
    let hasMultiple =
        Namespaced_IRI.parse _namespace_name "hasMultiple" |> NamespacedName
