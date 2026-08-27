namespace https.spec.edmcouncil.org.fibo.ontology.DER.DerivativesContracts.Swaps.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_der_drc_swp =
    let _namespace_iri = Namespace_Iri fibo_der_drc_swp |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-der-drc-swp:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Swaps Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_der_drc_swp, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-swp:BasisSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"basis swap"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/BasisSwap">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/BasisSwap</seealso>
    let BasisSwap = Prefixed_Name(fibo_der_drc_swp, "BasisSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-swp:CorrelationLeg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"correlation leg"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/CorrelationLeg">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/CorrelationLeg</seealso>
    let CorrelationLeg =
        Prefixed_Name(fibo_der_drc_swp, "CorrelationLeg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-swp:CorrelationSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"correlation swap"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/CorrelationSwap">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/CorrelationSwap</seealso>
    let CorrelationSwap =
        Prefixed_Name(fibo_der_drc_swp, "CorrelationSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-swp:DispersionLeg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dispersion leg"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/DispersionLeg">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/DispersionLeg</seealso>
    let DispersionLeg = Prefixed_Name(fibo_der_drc_swp, "DispersionLeg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-swp:DispersionSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dispersion swap"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/DispersionSwap">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/DispersionSwap</seealso>
    let DispersionSwap =
        Prefixed_Name(fibo_der_drc_swp, "DispersionSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-swp:ExcessReturnSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"excess return swap"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/ExcessReturnSwap">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/ExcessReturnSwap</seealso>
    let ExcessReturnSwap =
        Prefixed_Name(fibo_der_drc_swp, "ExcessReturnSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-swp:FixedLeg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fixed leg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/FixedLeg">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/FixedLeg</seealso>
    let FixedLeg = Prefixed_Name(fibo_der_drc_swp, "FixedLeg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-swp:FixedPaymentLeg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fixed payment leg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/FixedPaymentLeg">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/FixedPaymentLeg</seealso>
    let FixedPaymentLeg =
        Prefixed_Name(fibo_der_drc_swp, "FixedPaymentLeg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-swp:FloatingLeg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"floating leg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/FloatingLeg">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/FloatingLeg</seealso>
    let FloatingLeg = Prefixed_Name(fibo_der_drc_swp, "FloatingLeg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-swp:IndexReturnSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"index return swap"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/IndexReturnSwap">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/IndexReturnSwap</seealso>
    let IndexReturnSwap =
        Prefixed_Name(fibo_der_drc_swp, "IndexReturnSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-swp:MajorSwapParticipant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"major swap participant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/MajorSwapParticipant">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/MajorSwapParticipant</seealso>
    let MajorSwapParticipant =
        Prefixed_Name(fibo_der_drc_swp, "MajorSwapParticipant") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-swp:PerformanceBasedVariableLeg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"performance-based variable leg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/PerformanceBasedVariableLeg">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/PerformanceBasedVariableLeg</seealso>
    let PerformanceBasedVariableLeg =
        Prefixed_Name(fibo_der_drc_swp, "PerformanceBasedVariableLeg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-swp:RateBasedLeg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"rate-based leg"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/RateBasedLeg">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/RateBasedLeg</seealso>
    let RateBasedLeg = Prefixed_Name(fibo_der_drc_swp, "RateBasedLeg") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-swp:RatesSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"rates swap"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/RatesSwap">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/RatesSwap</seealso>
    let RatesSwap = Prefixed_Name(fibo_der_drc_swp, "RatesSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-swp:RealizedVariableLeg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"realized variable leg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/RealizedVariableLeg">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/RealizedVariableLeg</seealso>
    let RealizedVariableLeg =
        Prefixed_Name(fibo_der_drc_swp, "RealizedVariableLeg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-swp:ReturnLeg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"return leg"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/ReturnLeg">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/ReturnLeg</seealso>
    let ReturnLeg = Prefixed_Name(fibo_der_drc_swp, "ReturnLeg") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-swp:ReturnSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"return swap"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/ReturnSwap">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/ReturnSwap</seealso>
    let ReturnSwap = Prefixed_Name(fibo_der_drc_swp, "ReturnSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-swp:SimpleReturnLeg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"simple return leg"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SimpleReturnLeg">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SimpleReturnLeg</seealso>
    let SimpleReturnLeg =
        Prefixed_Name(fibo_der_drc_swp, "SimpleReturnLeg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-swp:StatisticalSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"statistical swap"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/StatisticalSwap">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/StatisticalSwap</seealso>
    let StatisticalSwap =
        Prefixed_Name(fibo_der_drc_swp, "StatisticalSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-swp:StrikeLeg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"strike leg"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/StrikeLeg">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/StrikeLeg</seealso>
    let StrikeLeg = Prefixed_Name(fibo_der_drc_swp, "StrikeLeg") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-swp:Swap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"swap"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/Swap">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/Swap</seealso>
    let Swap = Prefixed_Name(fibo_der_drc_swp, "Swap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-swp:SwapConfirmation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"swap confirmation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapConfirmation">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapConfirmation</seealso>
    let SwapConfirmation =
        Prefixed_Name(fibo_der_drc_swp, "SwapConfirmation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-swp:SwapDataRepository</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"swap data repository"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapDataRepository">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapDataRepository</seealso>
    let SwapDataRepository =
        Prefixed_Name(fibo_der_drc_swp, "SwapDataRepository") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-swp:SwapDealer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"swap dealer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapDealer">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapDealer</seealso>
    let SwapDealer = Prefixed_Name(fibo_der_drc_swp, "SwapDealer") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-swp:SwapLeg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"swap leg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapLeg">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapLeg</seealso>
    let SwapLeg = Prefixed_Name(fibo_der_drc_swp, "SwapLeg") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-swp:SwapLegEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"swap leg event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapLegEvent">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapLegEvent</seealso>
    let SwapLegEvent = Prefixed_Name(fibo_der_drc_swp, "SwapLegEvent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-swp:SwapLifecycleEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"swap lifecycle event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapLifecycleEvent">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapLifecycleEvent</seealso>
    let SwapLifecycleEvent =
        Prefixed_Name(fibo_der_drc_swp, "SwapLifecycleEvent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-swp:SwapLifecycleEventIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"swap lifecycle event identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapLifecycleEventIdentifier">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapLifecycleEventIdentifier</seealso>
    let SwapLifecycleEventIdentifier =
        Prefixed_Name(fibo_der_drc_swp, "SwapLifecycleEventIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-swp:SwapParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"swap party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapParty">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapParty</seealso>
    let SwapParty = Prefixed_Name(fibo_der_drc_swp, "SwapParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-swp:SwapPayingParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"swap paying party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapPayingParty">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapPayingParty</seealso>
    let SwapPayingParty =
        Prefixed_Name(fibo_der_drc_swp, "SwapPayingParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-swp:SwapReceivingParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"swap receiving party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapReceivingParty">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapReceivingParty</seealso>
    let SwapReceivingParty =
        Prefixed_Name(fibo_der_drc_swp, "SwapReceivingParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-swp:SwapTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"swap terms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapTerms">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/SwapTerms</seealso>
    let SwapTerms = Prefixed_Name(fibo_der_drc_swp, "SwapTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-swp:TotalReturnLeg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"total return leg"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/TotalReturnLeg">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/TotalReturnLeg</seealso>
    let TotalReturnLeg =
        Prefixed_Name(fibo_der_drc_swp, "TotalReturnLeg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-swp:TotalReturnSwap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"total return swap"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/TotalReturnSwap">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/TotalReturnSwap</seealso>
    let TotalReturnSwap =
        Prefixed_Name(fibo_der_drc_swp, "TotalReturnSwap") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-swp:UniqueSwapIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"unique swap identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/UniqueSwapIdentifier">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/UniqueSwapIdentifier</seealso>
    let UniqueSwapIdentifier =
        Prefixed_Name(fibo_der_drc_swp, "UniqueSwapIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-swp:hasFundingLeg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has funding leg"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/hasFundingLeg">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/hasFundingLeg</seealso>
    let hasFundingLeg = Prefixed_Name(fibo_der_drc_swp, "hasFundingLeg") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-swp:hasLeg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has leg"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/hasLeg">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/hasLeg</seealso>
    let hasLeg = Prefixed_Name(fibo_der_drc_swp, "hasLeg") |> PrefixedName
    /// <summary>
    ///   <para>fibo-der-drc-swp:hasReturnLeg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has return leg"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/hasReturnLeg">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/hasReturnLeg</seealso>
    let hasReturnLeg = Prefixed_Name(fibo_der_drc_swp, "hasReturnLeg") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-swp:hasSwapIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has swap identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/hasSwapIdentifier">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/hasSwapIdentifier</seealso>
    let hasSwapIdentifier =
        Prefixed_Name(fibo_der_drc_swp, "hasSwapIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-swp:isLegOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is leg of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/isLegOf">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/isLegOf</seealso>
    let isLegOf = Prefixed_Name(fibo_der_drc_swp, "isLegOf") |> PrefixedName
