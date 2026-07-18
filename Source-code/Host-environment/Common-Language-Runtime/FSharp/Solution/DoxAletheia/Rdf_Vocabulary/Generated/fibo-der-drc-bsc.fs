namespace https.spec.edmcouncil.org.fibo.ontology.DER.DerivativesContracts.DerivativesBasics.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_der_drc_bsc =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/CalculationAgent"></see>
    /// </summary>
    let CalculationAgent =
        Namespaced_IRI.parse _namespace_name "CalculationAgent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/CashflowExpression"></see>
    /// </summary>
    let CashflowExpression =
        Namespaced_IRI.parse _namespace_name "CashflowExpression" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/CashflowFormula"></see>
    /// </summary>
    let CashflowFormula =
        Namespaced_IRI.parse _namespace_name "CashflowFormula" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/CashflowTerms"></see>
    /// </summary>
    let CashflowTerms =
        Namespaced_IRI.parse _namespace_name "CashflowTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/DerivativeTerms"></see>
    /// </summary>
    let DerivativeTerms =
        Namespaced_IRI.parse _namespace_name "DerivativeTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/ContractForDifference"></see>
    /// </summary>
    let ContractForDifference =
        Namespaced_IRI.parse _namespace_name "ContractForDifference" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/CreditDerivative"></see>
    /// </summary>
    let CreditDerivative =
        Namespaced_IRI.parse _namespace_name "CreditDerivative" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/DerivativeSettlementTerms"></see>
    /// </summary>
    let DerivativeSettlementTerms =
        Namespaced_IRI.parse _namespace_name "DerivativeSettlementTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasAdditionalCosts"></see>
    /// </summary>
    let hasAdditionalCosts =
        Namespaced_IRI.parse _namespace_name "hasAdditionalCosts" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasUnderlyingAssetPrice"></see>
    /// </summary>
    let hasUnderlyingAssetPrice =
        Namespaced_IRI.parse _namespace_name "hasUnderlyingAssetPrice" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/DerivativesClearingOrganization"></see>
    /// </summary>
    let DerivativesClearingOrganization =
        Namespaced_IRI.parse _namespace_name "DerivativesClearingOrganization" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/EconomicRateBasedDerivative"></see>
    /// </summary>
    let EconomicRateBasedDerivative =
        Namespaced_IRI.parse _namespace_name "EconomicRateBasedDerivative" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/RateBasedDerivative"></see>
    /// </summary>
    let RateBasedDerivative =
        Namespaced_IRI.parse _namespace_name "RateBasedDerivative" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/ForwardRateAgreement"></see>
    /// </summary>
    let ForwardRateAgreement =
        Namespaced_IRI.parse _namespace_name "ForwardRateAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/InterestRateDerivative"></see>
    /// </summary>
    let InterestRateDerivative =
        Namespaced_IRI.parse _namespace_name "InterestRateDerivative" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/IntroducingBroker"></see>
    /// </summary>
    let IntroducingBroker =
        Namespaced_IRI.parse _namespace_name "IntroducingBroker" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/ObservableValue"></see>
    /// </summary>
    let ObservableValue =
        Namespaced_IRI.parse _namespace_name "ObservableValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/specifiesValueOf"></see>
    /// </summary>
    let specifiesValueOf =
        Namespaced_IRI.parse _namespace_name "specifiesValueOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/OverTheCounterDerivativeInstrument"></see>
    /// </summary>
    let OverTheCounterDerivativeInstrument =
        Namespaced_IRI.parse _namespace_name "OverTheCounterDerivativeInstrument" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/OverTheCounterInstrument"></see>
    /// </summary>
    let OverTheCounterInstrument =
        Namespaced_IRI.parse _namespace_name "OverTheCounterInstrument" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/ParametricCashflowTerms"></see>
    /// </summary>
    let ParametricCashflowTerms =
        Namespaced_IRI.parse _namespace_name "ParametricCashflowTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/PayingParty"></see>
    /// </summary>
    let PayingParty =
        Namespaced_IRI.parse _namespace_name "PayingParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/ReceivingParty"></see>
    /// </summary>
    let ReceivingParty =
        Namespaced_IRI.parse _namespace_name "ReceivingParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/UnderlyingAssetValuation"></see>
    /// </summary>
    let UnderlyingAssetValuation =
        Namespaced_IRI.parse _namespace_name "UnderlyingAssetValuation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/UniqueProductIdentifier"></see>
    /// </summary>
    let UniqueProductIdentifier =
        Namespaced_IRI.parse _namespace_name "UniqueProductIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/UniqueProductIdentifierServiceProvider"></see>
    /// </summary>
    let UniqueProductIdentifierServiceProvider =
        Namespaced_IRI.parse _namespace_name "UniqueProductIdentifierServiceProvider" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/UniqueProductIdentifierReferenceDataLibrary"></see>
    /// </summary>
    let UniqueProductIdentifierReferenceDataLibrary =
        Namespaced_IRI.parse _namespace_name "UniqueProductIdentifierReferenceDataLibrary" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/UniqueProductIdentifierRegistryEntry"></see>
    /// </summary>
    let UniqueProductIdentifierRegistryEntry =
        Namespaced_IRI.parse _namespace_name "UniqueProductIdentifierRegistryEntry" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/ValuationTerms"></see>
    /// </summary>
    let ValuationTerms =
        Namespaced_IRI.parse _namespace_name "ValuationTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasAccretingNotionalAmount"></see>
    /// </summary>
    let hasAccretingNotionalAmount =
        Namespaced_IRI.parse _namespace_name "hasAccretingNotionalAmount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasAmortizingNotionalAmount"></see>
    /// </summary>
    let hasAmortizingNotionalAmount =
        Namespaced_IRI.parse _namespace_name "hasAmortizingNotionalAmount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasCalculationAgent"></see>
    /// </summary>
    let hasCalculationAgent =
        Namespaced_IRI.parse _namespace_name "hasCalculationAgent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasConstantNotionalAmount"></see>
    /// </summary>
    let hasConstantNotionalAmount =
        Namespaced_IRI.parse _namespace_name "hasConstantNotionalAmount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasCustomNotionalAmount"></see>
    /// </summary>
    let hasCustomNotionalAmount =
        Namespaced_IRI.parse _namespace_name "hasCustomNotionalAmount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasFirstDeliveryDate"></see>
    /// </summary>
    let hasFirstDeliveryDate =
        Namespaced_IRI.parse _namespace_name "hasFirstDeliveryDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasFirstNoticeDate"></see>
    /// </summary>
    let hasFirstNoticeDate =
        Namespaced_IRI.parse _namespace_name "hasFirstNoticeDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasLastDeliveryDate"></see>
    /// </summary>
    let hasLastDeliveryDate =
        Namespaced_IRI.parse _namespace_name "hasLastDeliveryDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasLastNoticeDate"></see>
    /// </summary>
    let hasLastNoticeDate =
        Namespaced_IRI.parse _namespace_name "hasLastNoticeDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasSettlementTerms"></see>
    /// </summary>
    let hasSettlementTerms =
        Namespaced_IRI.parse _namespace_name "hasSettlementTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasTickValue"></see>
    /// </summary>
    let hasTickValue =
        Namespaced_IRI.parse _namespace_name "hasTickValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasValuationTerms"></see>
    /// </summary>
    let hasValuationTerms =
        Namespaced_IRI.parse _namespace_name "hasValuationTerms" |> NamespacedName
