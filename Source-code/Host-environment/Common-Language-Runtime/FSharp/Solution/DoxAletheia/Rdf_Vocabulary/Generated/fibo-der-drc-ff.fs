namespace https.spec.edmcouncil.org.fibo.ontology.DER.DerivativesContracts.FuturesAndForwards.slash

open DoxAletheia

module fibo_der_drc_ff =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/BasketFuture"></see>
    /// </summary>
    let BasketFuture = _prefix "BasketFuture"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/FinancialFuture"></see>
    /// </summary>
    let FinancialFuture = _prefix "FinancialFuture"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/BondFuture"></see>
    /// </summary>
    let BondFuture = _prefix "BondFuture"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/DebtInstrumentFuture"></see>
    /// </summary>
    let DebtInstrumentFuture = _prefix "DebtInstrumentFuture"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/CurrencyFuture"></see>
    /// </summary>
    let CurrencyFuture = _prefix "CurrencyFuture"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/DividendAdjustmentPeriod"></see>
    /// </summary>
    let DividendAdjustmentPeriod = _prefix "DividendAdjustmentPeriod"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/DividendFuture"></see>
    /// </summary>
    let DividendFuture = _prefix "DividendFuture"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/EquityForward"></see>
    /// </summary>
    let EquityForward = _prefix "EquityForward"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/Forward"></see>
    /// </summary>
    let Forward = _prefix "Forward"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/hasDividendAdjustmentPeriod"></see>
    /// </summary>
    let hasDividendAdjustmentPeriod = _prefix "hasDividendAdjustmentPeriod"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/hasMethodOfAdjustment"></see>
    /// </summary>
    let hasMethodOfAdjustment = _prefix "hasMethodOfAdjustment"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/ForwardContractAdjustmentMethod"></see>
    /// </summary>
    let ForwardContractAdjustmentMethod = _prefix "ForwardContractAdjustmentMethod"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/EquityFuture"></see>
    /// </summary>
    let EquityFuture = _prefix "EquityFuture"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/FutureOnFuture"></see>
    /// </summary>
    let FutureOnFuture = _prefix "FutureOnFuture"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/FutureOnOption"></see>
    /// </summary>
    let FutureOnOption = _prefix "FutureOnOption"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/FutureOnSwap"></see>
    /// </summary>
    let FutureOnSwap = _prefix "FutureOnSwap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/IndexFuture"></see>
    /// </summary>
    let IndexFuture = _prefix "IndexFuture"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/InterestRateFuture"></see>
    /// </summary>
    let InterestRateFuture = _prefix "InterestRateFuture"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/MoneyMarketFuture"></see>
    /// </summary>
    let MoneyMarketFuture = _prefix "MoneyMarketFuture"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/StandardizedFuturesListingTerms"></see>
    /// </summary>
    let StandardizedFuturesListingTerms = _prefix "StandardizedFuturesListingTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/StandardizedFuturesTerms"></see>
    /// </summary>
    let StandardizedFuturesTerms = _prefix "StandardizedFuturesTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/hasConversionFactor"></see>
    /// </summary>
    let hasConversionFactor = _prefix "hasConversionFactor"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/hasMultiple"></see>
    /// </summary>
    let hasMultiple = _prefix "hasMultiple"
