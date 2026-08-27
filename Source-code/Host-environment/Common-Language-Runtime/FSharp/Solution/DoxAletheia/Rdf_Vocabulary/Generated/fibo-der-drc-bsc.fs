namespace https.spec.edmcouncil.org.fibo.ontology.DER.DerivativesContracts.DerivativesBasics.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_der_drc_bsc =
    let _namespace_iri = Namespace_Iri fibo_der_drc_bsc |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-der-drc-bsc:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Derivatives Basics Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_der_drc_bsc, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:CashflowExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cashflow expression"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/CashflowExpression">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/CashflowExpression</seealso>
    let CashflowExpression =
        Prefixed_Name(fibo_der_drc_bsc, "CashflowExpression") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:CashflowFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cashflow formula"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/CashflowFormula">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/CashflowFormula</seealso>
    let CashflowFormula =
        Prefixed_Name(fibo_der_drc_bsc, "CashflowFormula") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:CashflowTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cashflow terms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/CashflowTerms">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/CashflowTerms</seealso>
    let CashflowTerms = Prefixed_Name(fibo_der_drc_bsc, "CashflowTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:ContractForDifference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"contract for difference"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/ContractForDifference">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/ContractForDifference</seealso>
    let ContractForDifference =
        Prefixed_Name(fibo_der_drc_bsc, "ContractForDifference") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:CreditDerivative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"credit derivative"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/CreditDerivative">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/CreditDerivative</seealso>
    let CreditDerivative =
        Prefixed_Name(fibo_der_drc_bsc, "CreditDerivative") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:DerivativeSettlementTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"derivative settlement terms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/DerivativeSettlementTerms">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/DerivativeSettlementTerms</seealso>
    let DerivativeSettlementTerms =
        Prefixed_Name(fibo_der_drc_bsc, "DerivativeSettlementTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:DerivativeTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"derivative terms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/DerivativeTerms">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/DerivativeTerms</seealso>
    let DerivativeTerms =
        Prefixed_Name(fibo_der_drc_bsc, "DerivativeTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:DerivativesClearingOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"derivatives clearing organization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/DerivativesClearingOrganization">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/DerivativesClearingOrganization</seealso>
    let DerivativesClearingOrganization =
        Prefixed_Name(fibo_der_drc_bsc, "DerivativesClearingOrganization") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:EconomicRateBasedDerivative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"economic rate-based derivative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/EconomicRateBasedDerivative">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/EconomicRateBasedDerivative</seealso>
    let EconomicRateBasedDerivative =
        Prefixed_Name(fibo_der_drc_bsc, "EconomicRateBasedDerivative") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:ForwardRateAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"forward rate agreement"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/ForwardRateAgreement">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/ForwardRateAgreement</seealso>
    let ForwardRateAgreement =
        Prefixed_Name(fibo_der_drc_bsc, "ForwardRateAgreement") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:InterestRateDerivative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interest rate derivative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/InterestRateDerivative">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/InterestRateDerivative</seealso>
    let InterestRateDerivative =
        Prefixed_Name(fibo_der_drc_bsc, "InterestRateDerivative") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:IntroducingBroker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"introducing broker"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/IntroducingBroker">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/IntroducingBroker</seealso>
    let IntroducingBroker =
        Prefixed_Name(fibo_der_drc_bsc, "IntroducingBroker") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:ObservableValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"observable value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/ObservableValue">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/ObservableValue</seealso>
    let ObservableValue =
        Prefixed_Name(fibo_der_drc_bsc, "ObservableValue") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:OverTheCounterDerivativeInstrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"over-the-counter derivative instrument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/OverTheCounterDerivativeInstrument">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/OverTheCounterDerivativeInstrument</seealso>
    let OverTheCounterDerivativeInstrument =
        Prefixed_Name(fibo_der_drc_bsc, "OverTheCounterDerivativeInstrument") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:OverTheCounterInstrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"over-the-counter instrument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/OverTheCounterInstrument">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/OverTheCounterInstrument</seealso>
    let OverTheCounterInstrument =
        Prefixed_Name(fibo_der_drc_bsc, "OverTheCounterInstrument") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:ParametricCashflowTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"parametric cashflow terms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/ParametricCashflowTerms">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/ParametricCashflowTerms</seealso>
    let ParametricCashflowTerms =
        Prefixed_Name(fibo_der_drc_bsc, "ParametricCashflowTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:PayingParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"paying party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/PayingParty">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/PayingParty</seealso>
    let PayingParty = Prefixed_Name(fibo_der_drc_bsc, "PayingParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:RateBasedDerivative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"rate-based derivative"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/RateBasedDerivative">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/RateBasedDerivative</seealso>
    let RateBasedDerivative =
        Prefixed_Name(fibo_der_drc_bsc, "RateBasedDerivative") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:ReceivingParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"receiving counterparty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/ReceivingParty">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/ReceivingParty</seealso>
    let ReceivingParty =
        Prefixed_Name(fibo_der_drc_bsc, "ReceivingParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:UnderlyingAssetValuation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"underlying asset valuation"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/UnderlyingAssetValuation">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/UnderlyingAssetValuation</seealso>
    let UnderlyingAssetValuation =
        Prefixed_Name(fibo_der_drc_bsc, "UnderlyingAssetValuation") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:UniqueProductIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"unique product identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/UniqueProductIdentifier">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/UniqueProductIdentifier</seealso>
    let UniqueProductIdentifier =
        Prefixed_Name(fibo_der_drc_bsc, "UniqueProductIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:UniqueProductIdentifierReferenceDataLibrary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>RegistrationAuthorities:Registry</para>
    ///
    /// labels<para>"unique product identifier reference data library"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/UniqueProductIdentifierReferenceDataLibrary">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/UniqueProductIdentifierReferenceDataLibrary</seealso>
    let UniqueProductIdentifierReferenceDataLibrary =
        Prefixed_Name(fibo_der_drc_bsc, "UniqueProductIdentifierReferenceDataLibrary") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:UniqueProductIdentifierRegistryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"unique product identifier registry entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/UniqueProductIdentifierRegistryEntry">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/UniqueProductIdentifierRegistryEntry</seealso>
    let UniqueProductIdentifierRegistryEntry =
        Prefixed_Name(fibo_der_drc_bsc, "UniqueProductIdentifierRegistryEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:UniqueProductIdentifierServiceProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"unique product identifier service provider"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/UniqueProductIdentifierServiceProvider">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/UniqueProductIdentifierServiceProvider</seealso>
    let UniqueProductIdentifierServiceProvider =
        Prefixed_Name(fibo_der_drc_bsc, "UniqueProductIdentifierServiceProvider") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:ValuationTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"valuation terms"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/ValuationTerms">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/ValuationTerms</seealso>
    let ValuationTerms =
        Prefixed_Name(fibo_der_drc_bsc, "ValuationTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:hasAccretingNotionalAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has accreting notional amount"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasAccretingNotionalAmount">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasAccretingNotionalAmount</seealso>
    let hasAccretingNotionalAmount =
        Prefixed_Name(fibo_der_drc_bsc, "hasAccretingNotionalAmount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:hasAdditionalCosts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has additional costs"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasAdditionalCosts">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasAdditionalCosts</seealso>
    let hasAdditionalCosts =
        Prefixed_Name(fibo_der_drc_bsc, "hasAdditionalCosts") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:hasAmortizingNotionalAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has amortizing notional amount"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasAmortizingNotionalAmount">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasAmortizingNotionalAmount</seealso>
    let hasAmortizingNotionalAmount =
        Prefixed_Name(fibo_der_drc_bsc, "hasAmortizingNotionalAmount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:hasConstantNotionalAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has constant notional amount"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasConstantNotionalAmount">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasConstantNotionalAmount</seealso>
    let hasConstantNotionalAmount =
        Prefixed_Name(fibo_der_drc_bsc, "hasConstantNotionalAmount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:hasCustomNotionalAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has custom notional amount"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasCustomNotionalAmount">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasCustomNotionalAmount</seealso>
    let hasCustomNotionalAmount =
        Prefixed_Name(fibo_der_drc_bsc, "hasCustomNotionalAmount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:hasFirstDeliveryDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has first delivery date"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasFirstDeliveryDate">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasFirstDeliveryDate</seealso>
    let hasFirstDeliveryDate =
        Prefixed_Name(fibo_der_drc_bsc, "hasFirstDeliveryDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:hasFirstNoticeDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has first notice date"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasFirstNoticeDate">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasFirstNoticeDate</seealso>
    let hasFirstNoticeDate =
        Prefixed_Name(fibo_der_drc_bsc, "hasFirstNoticeDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:hasLastDeliveryDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has last delivery date"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasLastDeliveryDate">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasLastDeliveryDate</seealso>
    let hasLastDeliveryDate =
        Prefixed_Name(fibo_der_drc_bsc, "hasLastDeliveryDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:hasLastNoticeDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has last notice date"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasLastNoticeDate">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasLastNoticeDate</seealso>
    let hasLastNoticeDate =
        Prefixed_Name(fibo_der_drc_bsc, "hasLastNoticeDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:hasSettlementTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has settlement terms"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasSettlementTerms">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasSettlementTerms</seealso>
    let hasSettlementTerms =
        Prefixed_Name(fibo_der_drc_bsc, "hasSettlementTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:hasTickValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has tick value"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasTickValue">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasTickValue</seealso>
    let hasTickValue = Prefixed_Name(fibo_der_drc_bsc, "hasTickValue") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:hasUnderlyingAssetPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has underlying asset price"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasUnderlyingAssetPrice">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasUnderlyingAssetPrice</seealso>
    let hasUnderlyingAssetPrice =
        Prefixed_Name(fibo_der_drc_bsc, "hasUnderlyingAssetPrice") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:hasValuationTerms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has valuation terms"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasValuationTerms">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/hasValuationTerms</seealso>
    let hasValuationTerms =
        Prefixed_Name(fibo_der_drc_bsc, "hasValuationTerms") |> PrefixedName

    /// <summary>
    ///   <para>fibo-der-drc-bsc:specifiesValueOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"specifies value of"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/specifiesValueOf">https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/specifiesValueOf</seealso>
    let specifiesValueOf =
        Prefixed_Name(fibo_der_drc_bsc, "specifiesValueOf") |> PrefixedName
