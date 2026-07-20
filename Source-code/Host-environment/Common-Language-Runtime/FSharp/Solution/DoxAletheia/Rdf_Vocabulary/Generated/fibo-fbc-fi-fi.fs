namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FinancialInstruments.FinancialInstruments.slash

open DoxAletheia

module fibo_fbc_fi_fi =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/PromissoryNote"></see>
    /// </summary>
    let PromissoryNote = _prefix "PromissoryNote"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/CalculationAgent"></see>
    /// </summary>
    let CalculationAgent = _prefix "CalculationAgent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/CashInstrument"></see>
    /// </summary>
    let CashInstrument = _prefix "CashInstrument"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/FinancialInstrument"></see>
    /// </summary>
    let FinancialInstrument = _prefix "FinancialInstrument"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/CommodityInstrument"></see>
    /// </summary>
    let CommodityInstrument = _prefix "CommodityInstrument"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasCommodityValueAsOfExecutionDate"></see>
    /// </summary>
    let hasCommodityValueAsOfExecutionDate =
        _prefix "hasCommodityValueAsOfExecutionDate"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/CurrencyInstrument"></see>
    /// </summary>
    let CurrencyInstrument = _prefix "CurrencyInstrument"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasBuyingCurrency"></see>
    /// </summary>
    let hasBuyingCurrency = _prefix "hasBuyingCurrency"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasSellingCurrency"></see>
    /// </summary>
    let hasSellingCurrency = _prefix "hasSellingCurrency"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/DebtInstrument"></see>
    /// </summary>
    let DebtInstrument = _prefix "DebtInstrument"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/DerivativeInstrument"></see>
    /// </summary>
    let DerivativeInstrument = _prefix "DerivativeInstrument"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/Entitlement"></see>
    /// </summary>
    let Entitlement = _prefix "Entitlement"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/EquityInstrument"></see>
    /// </summary>
    let EquityInstrument = _prefix "EquityInstrument"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/Security"></see>
    /// </summary>
    let Security = _prefix "Security"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/ExemptSecurity"></see>
    /// </summary>
    let ExemptSecurity = _prefix "ExemptSecurity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/FinancialInstrumentIdentifier"></see>
    /// </summary>
    let FinancialInstrumentIdentifier = _prefix "FinancialInstrumentIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasNominalValue"></see>
    /// </summary>
    let hasNominalValue = _prefix "hasNominalValue"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/isLegallyRecordedIn"></see>
    /// </summary>
    let isLegallyRecordedIn = _prefix "isLegallyRecordedIn"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/isNegotiable"></see>
    /// </summary>
    let isNegotiable = _prefix "isNegotiable"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/isDenominatedIn"></see>
    /// </summary>
    let isDenominatedIn = _prefix "isDenominatedIn"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/Issuer"></see>
    /// </summary>
    let Issuer = _prefix "Issuer"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/Future"></see>
    /// </summary>
    let Future = _prefix "Future"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/NegotiableSecurity"></see>
    /// </summary>
    let NegotiableSecurity = _prefix "NegotiableSecurity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/NonNegotiableSecurity"></see>
    /// </summary>
    let NonNegotiableSecurity = _prefix "NonNegotiableSecurity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/Option"></see>
    /// </summary>
    let Option = _prefix "Option"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/PackagedFinancialProduct"></see>
    /// </summary>
    let PackagedFinancialProduct = _prefix "PackagedFinancialProduct"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/RedemptionProvision"></see>
    /// </summary>
    let RedemptionProvision = _prefix "RedemptionProvision"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/SecuritiesTransaction"></see>
    /// </summary>
    let SecuritiesTransaction = _prefix "SecuritiesTransaction"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/SpotContract"></see>
    /// </summary>
    let SpotContract = _prefix "SpotContract"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/StandardizedTerms"></see>
    /// </summary>
    let StandardizedTerms = _prefix "StandardizedTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/Underlier"></see>
    /// </summary>
    let Underlier = _prefix "Underlier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasCalculationAgent"></see>
    /// </summary>
    let hasCalculationAgent = _prefix "hasCalculationAgent"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasPrincipalExecutiveOfficeAddress"></see>
    /// </summary>
    let hasPrincipalExecutiveOfficeAddress =
        _prefix "hasPrincipalExecutiveOfficeAddress"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasRedemptionProvision"></see>
    /// </summary>
    let hasRedemptionProvision = _prefix "hasRedemptionProvision"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasShareholder"></see>
    /// </summary>
    let hasShareholder = _prefix "hasShareholder"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasUnderlier"></see>
    /// </summary>
    let hasUnderlier = _prefix "hasUnderlier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/hasValueExpressedIn"></see>
    /// </summary>
    let hasValueExpressedIn = _prefix "hasValueExpressedIn"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/holdsSharesIn"></see>
    /// </summary>
    let holdsSharesIn = _prefix "holdsSharesIn"
