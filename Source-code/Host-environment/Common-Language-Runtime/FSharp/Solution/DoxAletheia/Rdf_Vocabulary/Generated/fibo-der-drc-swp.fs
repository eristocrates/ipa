namespace https.spec.edmcouncil.org.fibo.ontology.DER.DerivativesContracts.Swaps.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_der_drc_swp =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/BasisSwap"></see>
    /// </summary>
    let BasisSwap = Namespaced_IRI.parse _namespace_name "BasisSwap" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/RatesSwap"></see>
    /// </summary>
    let RatesSwap = Namespaced_IRI.parse _namespace_name "RatesSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/CorrelationLeg"></see>
    /// </summary>
    let CorrelationLeg =
        Namespaced_IRI.parse _namespace_name "CorrelationLeg" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/PerformanceBasedVariableLeg"></see>
    /// </summary>
    let PerformanceBasedVariableLeg =
        Namespaced_IRI.parse _namespace_name "PerformanceBasedVariableLeg" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/isLegOf"></see>
    /// </summary>
    let isLegOf = Namespaced_IRI.parse _namespace_name "isLegOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/CorrelationSwap"></see>
    /// </summary>
    let CorrelationSwap =
        Namespaced_IRI.parse _namespace_name "CorrelationSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/StatisticalSwap"></see>
    /// </summary>
    let StatisticalSwap =
        Namespaced_IRI.parse _namespace_name "StatisticalSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/DispersionLeg"></see>
    /// </summary>
    let DispersionLeg =
        Namespaced_IRI.parse _namespace_name "DispersionLeg" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/DispersionSwap"></see>
    /// </summary>
    let DispersionSwap =
        Namespaced_IRI.parse _namespace_name "DispersionSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/hasLeg"></see>
    /// </summary>
    let hasLeg = Namespaced_IRI.parse _namespace_name "hasLeg" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/ExcessReturnSwap"></see>
    /// </summary>
    let ExcessReturnSwap =
        Namespaced_IRI.parse _namespace_name "ExcessReturnSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/IndexReturnSwap"></see>
    /// </summary>
    let IndexReturnSwap =
        Namespaced_IRI.parse _namespace_name "IndexReturnSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/FixedLeg"></see>
    /// </summary>
    let FixedLeg = Namespaced_IRI.parse _namespace_name "FixedLeg" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapLeg"></see>
    /// </summary>
    let SwapLeg = Namespaced_IRI.parse _namespace_name "SwapLeg" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/FloatingLeg"></see>
    /// </summary>
    let FloatingLeg =
        Namespaced_IRI.parse _namespace_name "FloatingLeg" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/FixedPaymentLeg"></see>
    /// </summary>
    let FixedPaymentLeg =
        Namespaced_IRI.parse _namespace_name "FixedPaymentLeg" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/ReturnSwap"></see>
    /// </summary>
    let ReturnSwap = Namespaced_IRI.parse _namespace_name "ReturnSwap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/MajorSwapParticipant"></see>
    /// </summary>
    let MajorSwapParticipant =
        Namespaced_IRI.parse _namespace_name "MajorSwapParticipant" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/RateBasedLeg"></see>
    /// </summary>
    let RateBasedLeg =
        Namespaced_IRI.parse _namespace_name "RateBasedLeg" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/Swap"></see>
    /// </summary>
    let Swap = Namespaced_IRI.parse _namespace_name "Swap" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/RealizedVariableLeg"></see>
    /// </summary>
    let RealizedVariableLeg =
        Namespaced_IRI.parse _namespace_name "RealizedVariableLeg" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/ReturnLeg"></see>
    /// </summary>
    let ReturnLeg = Namespaced_IRI.parse _namespace_name "ReturnLeg" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/hasFundingLeg"></see>
    /// </summary>
    let hasFundingLeg =
        Namespaced_IRI.parse _namespace_name "hasFundingLeg" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/hasReturnLeg"></see>
    /// </summary>
    let hasReturnLeg =
        Namespaced_IRI.parse _namespace_name "hasReturnLeg" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SimpleReturnLeg"></see>
    /// </summary>
    let SimpleReturnLeg =
        Namespaced_IRI.parse _namespace_name "SimpleReturnLeg" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/StrikeLeg"></see>
    /// </summary>
    let StrikeLeg = Namespaced_IRI.parse _namespace_name "StrikeLeg" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/UniqueSwapIdentifier"></see>
    /// </summary>
    let UniqueSwapIdentifier =
        Namespaced_IRI.parse _namespace_name "UniqueSwapIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapParty"></see>
    /// </summary>
    let SwapParty = Namespaced_IRI.parse _namespace_name "SwapParty" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapTerms"></see>
    /// </summary>
    let SwapTerms = Namespaced_IRI.parse _namespace_name "SwapTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapConfirmation"></see>
    /// </summary>
    let SwapConfirmation =
        Namespaced_IRI.parse _namespace_name "SwapConfirmation" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapLifecycleEvent"></see>
    /// </summary>
    let SwapLifecycleEvent =
        Namespaced_IRI.parse _namespace_name "SwapLifecycleEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapDataRepository"></see>
    /// </summary>
    let SwapDataRepository =
        Namespaced_IRI.parse _namespace_name "SwapDataRepository" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapDealer"></see>
    /// </summary>
    let SwapDealer = Namespaced_IRI.parse _namespace_name "SwapDealer" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapPayingParty"></see>
    /// </summary>
    let SwapPayingParty =
        Namespaced_IRI.parse _namespace_name "SwapPayingParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapReceivingParty"></see>
    /// </summary>
    let SwapReceivingParty =
        Namespaced_IRI.parse _namespace_name "SwapReceivingParty" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapLegEvent"></see>
    /// </summary>
    let SwapLegEvent =
        Namespaced_IRI.parse _namespace_name "SwapLegEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapLifecycleEventIdentifier"></see>
    /// </summary>
    let SwapLifecycleEventIdentifier =
        Namespaced_IRI.parse _namespace_name "SwapLifecycleEventIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/hasSwapIdentifier"></see>
    /// </summary>
    let hasSwapIdentifier =
        Namespaced_IRI.parse _namespace_name "hasSwapIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/TotalReturnLeg"></see>
    /// </summary>
    let TotalReturnLeg =
        Namespaced_IRI.parse _namespace_name "TotalReturnLeg" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/TotalReturnSwap"></see>
    /// </summary>
    let TotalReturnSwap =
        Namespaced_IRI.parse _namespace_name "TotalReturnSwap" |> NamespacedName
