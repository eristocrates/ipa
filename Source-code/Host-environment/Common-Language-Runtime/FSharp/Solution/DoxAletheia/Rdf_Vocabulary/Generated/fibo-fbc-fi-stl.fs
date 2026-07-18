namespace https.spec.edmcouncil.org.fibo.ontology.FBC.FinancialInstruments.Settlement.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fbc_fi_stl =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/CashSettlementTerms"></see>
    /// </summary>
    let CashSettlementTerms =
        Namespaced_IRI.parse _namespace_name "CashSettlementTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/hasDeliveryMethod"></see>
    /// </summary>
    let hasDeliveryMethod =
        Namespaced_IRI.parse _namespace_name "hasDeliveryMethod" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/DeliveryInCash"></see>
    /// </summary>
    let DeliveryInCash =
        Namespaced_IRI.parse _namespace_name "DeliveryInCash" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/hasSettlementAmount"></see>
    /// </summary>
    let hasSettlementAmount =
        Namespaced_IRI.parse _namespace_name "hasSettlementAmount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/DeliveryMethod"></see>
    /// </summary>
    let DeliveryMethod =
        Namespaced_IRI.parse _namespace_name "DeliveryMethod" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/ElectAtExerciseMethod"></see>
    /// </summary>
    let ElectAtExerciseMethod =
        Namespaced_IRI.parse _namespace_name "ElectAtExerciseMethod" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/NonDeliverableMethod"></see>
    /// </summary>
    let NonDeliverableMethod =
        Namespaced_IRI.parse _namespace_name "NonDeliverableMethod" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/PhysicalDeliveryMethod"></see>
    /// </summary>
    let PhysicalDeliveryMethod =
        Namespaced_IRI.parse _namespace_name "PhysicalDeliveryMethod" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/PhysicalSettlementTerms"></see>
    /// </summary>
    let PhysicalSettlementTerms =
        Namespaced_IRI.parse _namespace_name "PhysicalSettlementTerms" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/Settlement"></see>
    /// </summary>
    let Settlement = Namespaced_IRI.parse _namespace_name "Settlement" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/SettlementConvention"></see>
    /// </summary>
    let SettlementConvention =
        Namespaced_IRI.parse _namespace_name "SettlementConvention" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/SettlementEvent"></see>
    /// </summary>
    let SettlementEvent =
        Namespaced_IRI.parse _namespace_name "SettlementEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/hasPreferredSettlementCurrency"></see>
    /// </summary>
    let hasPreferredSettlementCurrency =
        Namespaced_IRI.parse _namespace_name "hasPreferredSettlementCurrency" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/isFractionalEligible"></see>
    /// </summary>
    let isFractionalEligible =
        Namespaced_IRI.parse _namespace_name "isFractionalEligible" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/isFullyAutomatedSecuritiesTransferApplicable"></see>
    /// </summary>
    let isFullyAutomatedSecuritiesTransferApplicable =
        Namespaced_IRI.parse _namespace_name "isFullyAutomatedSecuritiesTransferApplicable" |> NamespacedName
