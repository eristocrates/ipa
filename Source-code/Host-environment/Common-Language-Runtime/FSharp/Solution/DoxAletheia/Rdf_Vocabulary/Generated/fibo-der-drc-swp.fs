namespace https.spec.edmcouncil.org.fibo.ontology.DER.DerivativesContracts.Swaps.slash

open DoxAletheia

module fibo_der_drc_swp =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/BasisSwap"></see>
    /// </summary>
    let BasisSwap = _prefix "BasisSwap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/RatesSwap"></see>
    /// </summary>
    let RatesSwap = _prefix "RatesSwap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/CorrelationLeg"></see>
    /// </summary>
    let CorrelationLeg = _prefix "CorrelationLeg"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/PerformanceBasedVariableLeg"></see>
    /// </summary>
    let PerformanceBasedVariableLeg = _prefix "PerformanceBasedVariableLeg"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/isLegOf"></see>
    /// </summary>
    let isLegOf = _prefix "isLegOf"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/CorrelationSwap"></see>
    /// </summary>
    let CorrelationSwap = _prefix "CorrelationSwap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/StatisticalSwap"></see>
    /// </summary>
    let StatisticalSwap = _prefix "StatisticalSwap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/DispersionLeg"></see>
    /// </summary>
    let DispersionLeg = _prefix "DispersionLeg"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/DispersionSwap"></see>
    /// </summary>
    let DispersionSwap = _prefix "DispersionSwap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/hasLeg"></see>
    /// </summary>
    let hasLeg = _prefix "hasLeg"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/ExcessReturnSwap"></see>
    /// </summary>
    let ExcessReturnSwap = _prefix "ExcessReturnSwap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/IndexReturnSwap"></see>
    /// </summary>
    let IndexReturnSwap = _prefix "IndexReturnSwap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/FixedLeg"></see>
    /// </summary>
    let FixedLeg = _prefix "FixedLeg"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapLeg"></see>
    /// </summary>
    let SwapLeg = _prefix "SwapLeg"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/FloatingLeg"></see>
    /// </summary>
    let FloatingLeg = _prefix "FloatingLeg"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/FixedPaymentLeg"></see>
    /// </summary>
    let FixedPaymentLeg = _prefix "FixedPaymentLeg"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/ReturnSwap"></see>
    /// </summary>
    let ReturnSwap = _prefix "ReturnSwap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/MajorSwapParticipant"></see>
    /// </summary>
    let MajorSwapParticipant = _prefix "MajorSwapParticipant"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/RateBasedLeg"></see>
    /// </summary>
    let RateBasedLeg = _prefix "RateBasedLeg"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/Swap"></see>
    /// </summary>
    let Swap = _prefix "Swap"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/RealizedVariableLeg"></see>
    /// </summary>
    let RealizedVariableLeg = _prefix "RealizedVariableLeg"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/ReturnLeg"></see>
    /// </summary>
    let ReturnLeg = _prefix "ReturnLeg"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/hasFundingLeg"></see>
    /// </summary>
    let hasFundingLeg = _prefix "hasFundingLeg"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/hasReturnLeg"></see>
    /// </summary>
    let hasReturnLeg = _prefix "hasReturnLeg"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SimpleReturnLeg"></see>
    /// </summary>
    let SimpleReturnLeg = _prefix "SimpleReturnLeg"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/StrikeLeg"></see>
    /// </summary>
    let StrikeLeg = _prefix "StrikeLeg"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/UniqueSwapIdentifier"></see>
    /// </summary>
    let UniqueSwapIdentifier = _prefix "UniqueSwapIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapParty"></see>
    /// </summary>
    let SwapParty = _prefix "SwapParty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapTerms"></see>
    /// </summary>
    let SwapTerms = _prefix "SwapTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapConfirmation"></see>
    /// </summary>
    let SwapConfirmation = _prefix "SwapConfirmation"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapLifecycleEvent"></see>
    /// </summary>
    let SwapLifecycleEvent = _prefix "SwapLifecycleEvent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapDataRepository"></see>
    /// </summary>
    let SwapDataRepository = _prefix "SwapDataRepository"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapDealer"></see>
    /// </summary>
    let SwapDealer = _prefix "SwapDealer"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapPayingParty"></see>
    /// </summary>
    let SwapPayingParty = _prefix "SwapPayingParty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapReceivingParty"></see>
    /// </summary>
    let SwapReceivingParty = _prefix "SwapReceivingParty"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapLegEvent"></see>
    /// </summary>
    let SwapLegEvent = _prefix "SwapLegEvent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapLifecycleEventIdentifier"></see>
    /// </summary>
    let SwapLifecycleEventIdentifier = _prefix "SwapLifecycleEventIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/hasSwapIdentifier"></see>
    /// </summary>
    let hasSwapIdentifier = _prefix "hasSwapIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/TotalReturnLeg"></see>
    /// </summary>
    let TotalReturnLeg = _prefix "TotalReturnLeg"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/TotalReturnSwap"></see>
    /// </summary>
    let TotalReturnSwap = _prefix "TotalReturnSwap"
