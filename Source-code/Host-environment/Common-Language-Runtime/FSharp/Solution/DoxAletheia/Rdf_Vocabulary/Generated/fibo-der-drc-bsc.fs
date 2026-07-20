namespace https.spec.edmcouncil.org.fibo.ontology.DER.DerivativesContracts.DerivativesBasics.slash

open DoxAletheia

module fibo_der_drc_bsc =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/CalculationAgent"></see>
    /// </summary>
    let CalculationAgent = _prefix "CalculationAgent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/CashflowExpression"></see>
    /// </summary>
    let CashflowExpression = _prefix "CashflowExpression"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/CashflowFormula"></see>
    /// </summary>
    let CashflowFormula = _prefix "CashflowFormula"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/CashflowTerms"></see>
    /// </summary>
    let CashflowTerms = _prefix "CashflowTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/DerivativeTerms"></see>
    /// </summary>
    let DerivativeTerms = _prefix "DerivativeTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/ContractForDifference"></see>
    /// </summary>
    let ContractForDifference = _prefix "ContractForDifference"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/CreditDerivative"></see>
    /// </summary>
    let CreditDerivative = _prefix "CreditDerivative"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/DerivativeSettlementTerms"></see>
    /// </summary>
    let DerivativeSettlementTerms = _prefix "DerivativeSettlementTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasAdditionalCosts"></see>
    /// </summary>
    let hasAdditionalCosts = _prefix "hasAdditionalCosts"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasUnderlyingAssetPrice"></see>
    /// </summary>
    let hasUnderlyingAssetPrice = _prefix "hasUnderlyingAssetPrice"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/DerivativesClearingOrganization"></see>
    /// </summary>
    let DerivativesClearingOrganization = _prefix "DerivativesClearingOrganization"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/EconomicRateBasedDerivative"></see>
    /// </summary>
    let EconomicRateBasedDerivative = _prefix "EconomicRateBasedDerivative"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/RateBasedDerivative"></see>
    /// </summary>
    let RateBasedDerivative = _prefix "RateBasedDerivative"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/ForwardRateAgreement"></see>
    /// </summary>
    let ForwardRateAgreement = _prefix "ForwardRateAgreement"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/InterestRateDerivative"></see>
    /// </summary>
    let InterestRateDerivative = _prefix "InterestRateDerivative"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/IntroducingBroker"></see>
    /// </summary>
    let IntroducingBroker = _prefix "IntroducingBroker"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/ObservableValue"></see>
    /// </summary>
    let ObservableValue = _prefix "ObservableValue"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/specifiesValueOf"></see>
    /// </summary>
    let specifiesValueOf = _prefix "specifiesValueOf"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/OverTheCounterDerivativeInstrument"></see>
    /// </summary>
    let OverTheCounterDerivativeInstrument =
        _prefix "OverTheCounterDerivativeInstrument"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/OverTheCounterInstrument"></see>
    /// </summary>
    let OverTheCounterInstrument = _prefix "OverTheCounterInstrument"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/ParametricCashflowTerms"></see>
    /// </summary>
    let ParametricCashflowTerms = _prefix "ParametricCashflowTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/PayingParty"></see>
    /// </summary>
    let PayingParty = _prefix "PayingParty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/ReceivingParty"></see>
    /// </summary>
    let ReceivingParty = _prefix "ReceivingParty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/UnderlyingAssetValuation"></see>
    /// </summary>
    let UnderlyingAssetValuation = _prefix "UnderlyingAssetValuation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/UniqueProductIdentifier"></see>
    /// </summary>
    let UniqueProductIdentifier = _prefix "UniqueProductIdentifier"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/UniqueProductIdentifierServiceProvider"></see>
    /// </summary>
    let UniqueProductIdentifierServiceProvider =
        _prefix "UniqueProductIdentifierServiceProvider"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/UniqueProductIdentifierReferenceDataLibrary"></see>
    /// </summary>
    let UniqueProductIdentifierReferenceDataLibrary =
        _prefix "UniqueProductIdentifierReferenceDataLibrary"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/UniqueProductIdentifierRegistryEntry"></see>
    /// </summary>
    let UniqueProductIdentifierRegistryEntry =
        _prefix "UniqueProductIdentifierRegistryEntry"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/ValuationTerms"></see>
    /// </summary>
    let ValuationTerms = _prefix "ValuationTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasAccretingNotionalAmount"></see>
    /// </summary>
    let hasAccretingNotionalAmount = _prefix "hasAccretingNotionalAmount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasAmortizingNotionalAmount"></see>
    /// </summary>
    let hasAmortizingNotionalAmount = _prefix "hasAmortizingNotionalAmount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasCalculationAgent"></see>
    /// </summary>
    let hasCalculationAgent = _prefix "hasCalculationAgent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasConstantNotionalAmount"></see>
    /// </summary>
    let hasConstantNotionalAmount = _prefix "hasConstantNotionalAmount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasCustomNotionalAmount"></see>
    /// </summary>
    let hasCustomNotionalAmount = _prefix "hasCustomNotionalAmount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasFirstDeliveryDate"></see>
    /// </summary>
    let hasFirstDeliveryDate = _prefix "hasFirstDeliveryDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasFirstNoticeDate"></see>
    /// </summary>
    let hasFirstNoticeDate = _prefix "hasFirstNoticeDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasLastDeliveryDate"></see>
    /// </summary>
    let hasLastDeliveryDate = _prefix "hasLastDeliveryDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasLastNoticeDate"></see>
    /// </summary>
    let hasLastNoticeDate = _prefix "hasLastNoticeDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasSettlementTerms"></see>
    /// </summary>
    let hasSettlementTerms = _prefix "hasSettlementTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasTickValue"></see>
    /// </summary>
    let hasTickValue = _prefix "hasTickValue"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasValuationTerms"></see>
    /// </summary>
    let hasValuationTerms = _prefix "hasValuationTerms"
