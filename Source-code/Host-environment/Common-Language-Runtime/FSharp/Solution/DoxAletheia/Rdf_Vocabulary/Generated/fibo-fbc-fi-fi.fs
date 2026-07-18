namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FinancialInstruments.FinancialInstruments.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fbc_fi_fi =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/PromissoryNote"></see>
    /// </summary>
    let PromissoryNote =
        Namespaced_IRI.parse _namespace_name "PromissoryNote" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/CalculationAgent"></see>
    /// </summary>
    let CalculationAgent =
        Namespaced_IRI.parse _namespace_name "CalculationAgent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/CashInstrument"></see>
    /// </summary>
    let CashInstrument =
        Namespaced_IRI.parse _namespace_name "CashInstrument" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/FinancialInstrument"></see>
    /// </summary>
    let FinancialInstrument =
        Namespaced_IRI.parse _namespace_name "FinancialInstrument" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/CommodityInstrument"></see>
    /// </summary>
    let CommodityInstrument =
        Namespaced_IRI.parse _namespace_name "CommodityInstrument" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasCommodityValueAsOfExecutionDate"></see>
    /// </summary>
    let hasCommodityValueAsOfExecutionDate =
        Namespaced_IRI.parse _namespace_name "hasCommodityValueAsOfExecutionDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/CurrencyInstrument"></see>
    /// </summary>
    let CurrencyInstrument =
        Namespaced_IRI.parse _namespace_name "CurrencyInstrument" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasBuyingCurrency"></see>
    /// </summary>
    let hasBuyingCurrency =
        Namespaced_IRI.parse _namespace_name "hasBuyingCurrency" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasSellingCurrency"></see>
    /// </summary>
    let hasSellingCurrency =
        Namespaced_IRI.parse _namespace_name "hasSellingCurrency" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/DebtInstrument"></see>
    /// </summary>
    let DebtInstrument =
        Namespaced_IRI.parse _namespace_name "DebtInstrument" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/DerivativeInstrument"></see>
    /// </summary>
    let DerivativeInstrument =
        Namespaced_IRI.parse _namespace_name "DerivativeInstrument" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/Entitlement"></see>
    /// </summary>
    let Entitlement =
        Namespaced_IRI.parse _namespace_name "Entitlement" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/EquityInstrument"></see>
    /// </summary>
    let EquityInstrument =
        Namespaced_IRI.parse _namespace_name "EquityInstrument" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/Security"></see>
    /// </summary>
    let Security = Namespaced_IRI.parse _namespace_name "Security" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/ExemptSecurity"></see>
    /// </summary>
    let ExemptSecurity =
        Namespaced_IRI.parse _namespace_name "ExemptSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/FinancialInstrumentIdentifier"></see>
    /// </summary>
    let FinancialInstrumentIdentifier =
        Namespaced_IRI.parse _namespace_name "FinancialInstrumentIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasNominalValue"></see>
    /// </summary>
    let hasNominalValue =
        Namespaced_IRI.parse _namespace_name "hasNominalValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/isLegallyRecordedIn"></see>
    /// </summary>
    let isLegallyRecordedIn =
        Namespaced_IRI.parse _namespace_name "isLegallyRecordedIn" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/isNegotiable"></see>
    /// </summary>
    let isNegotiable =
        Namespaced_IRI.parse _namespace_name "isNegotiable" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/isDenominatedIn"></see>
    /// </summary>
    let isDenominatedIn =
        Namespaced_IRI.parse _namespace_name "isDenominatedIn" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/Issuer"></see>
    /// </summary>
    let Issuer = Namespaced_IRI.parse _namespace_name "Issuer" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/Future"></see>
    /// </summary>
    let Future = Namespaced_IRI.parse _namespace_name "Future" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/NegotiableSecurity"></see>
    /// </summary>
    let NegotiableSecurity =
        Namespaced_IRI.parse _namespace_name "NegotiableSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/NonNegotiableSecurity"></see>
    /// </summary>
    let NonNegotiableSecurity =
        Namespaced_IRI.parse _namespace_name "NonNegotiableSecurity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/Option"></see>
    /// </summary>
    let Option = Namespaced_IRI.parse _namespace_name "Option" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/PackagedFinancialProduct"></see>
    /// </summary>
    let PackagedFinancialProduct =
        Namespaced_IRI.parse _namespace_name "PackagedFinancialProduct" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/RedemptionProvision"></see>
    /// </summary>
    let RedemptionProvision =
        Namespaced_IRI.parse _namespace_name "RedemptionProvision" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/SecuritiesTransaction"></see>
    /// </summary>
    let SecuritiesTransaction =
        Namespaced_IRI.parse _namespace_name "SecuritiesTransaction" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/SpotContract"></see>
    /// </summary>
    let SpotContract =
        Namespaced_IRI.parse _namespace_name "SpotContract" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/StandardizedTerms"></see>
    /// </summary>
    let StandardizedTerms =
        Namespaced_IRI.parse _namespace_name "StandardizedTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/Underlier"></see>
    /// </summary>
    let Underlier = Namespaced_IRI.parse _namespace_name "Underlier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasCalculationAgent"></see>
    /// </summary>
    let hasCalculationAgent =
        Namespaced_IRI.parse _namespace_name "hasCalculationAgent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasPrincipalExecutiveOfficeAddress"></see>
    /// </summary>
    let hasPrincipalExecutiveOfficeAddress =
        Namespaced_IRI.parse _namespace_name "hasPrincipalExecutiveOfficeAddress" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasRedemptionProvision"></see>
    /// </summary>
    let hasRedemptionProvision =
        Namespaced_IRI.parse _namespace_name "hasRedemptionProvision" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasShareholder"></see>
    /// </summary>
    let hasShareholder =
        Namespaced_IRI.parse _namespace_name "hasShareholder" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasUnderlier"></see>
    /// </summary>
    let hasUnderlier =
        Namespaced_IRI.parse _namespace_name "hasUnderlier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasValueExpressedIn"></see>
    /// </summary>
    let hasValueExpressedIn =
        Namespaced_IRI.parse _namespace_name "hasValueExpressedIn" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/holdsSharesIn"></see>
    /// </summary>
    let holdsSharesIn =
        Namespaced_IRI.parse _namespace_name "holdsSharesIn" |> NamespacedName
