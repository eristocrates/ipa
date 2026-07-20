namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FinancialInstruments.Settlement.slash

open DoxAletheia

module fibo_fbc_fi_stl =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/CashSettlementTerms"></see>
    /// </summary>
    let CashSettlementTerms = _prefix "CashSettlementTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/hasDeliveryMethod"></see>
    /// </summary>
    let hasDeliveryMethod = _prefix "hasDeliveryMethod"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/DeliveryInCash"></see>
    /// </summary>
    let DeliveryInCash = _prefix "DeliveryInCash"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/hasSettlementAmount"></see>
    /// </summary>
    let hasSettlementAmount = _prefix "hasSettlementAmount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/DeliveryMethod"></see>
    /// </summary>
    let DeliveryMethod = _prefix "DeliveryMethod"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/ElectAtExerciseMethod"></see>
    /// </summary>
    let ElectAtExerciseMethod = _prefix "ElectAtExerciseMethod"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/NonDeliverableMethod"></see>
    /// </summary>
    let NonDeliverableMethod = _prefix "NonDeliverableMethod"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/PhysicalDeliveryMethod"></see>
    /// </summary>
    let PhysicalDeliveryMethod = _prefix "PhysicalDeliveryMethod"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/PhysicalSettlementTerms"></see>
    /// </summary>
    let PhysicalSettlementTerms = _prefix "PhysicalSettlementTerms"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/Settlement"></see>
    /// </summary>
    let Settlement = _prefix "Settlement"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/SettlementConvention"></see>
    /// </summary>
    let SettlementConvention = _prefix "SettlementConvention"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/SettlementEvent"></see>
    /// </summary>
    let SettlementEvent = _prefix "SettlementEvent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/hasPreferredSettlementCurrency"></see>
    /// </summary>
    let hasPreferredSettlementCurrency = _prefix "hasPreferredSettlementCurrency"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/isFractionalEligible"></see>
    /// </summary>
    let isFractionalEligible = _prefix "isFractionalEligible"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/isFullyAutomatedSecuritiesTransferApplicable"></see>
    /// </summary>
    let isFullyAutomatedSecuritiesTransferApplicable =
        _prefix "isFullyAutomatedSecuritiesTransferApplicable"
