namespace https.spec.edmcouncil.org.fibo.ontology.FND.Accounting.CashFlows.slash

open DoxAletheia

module fibo_fnd_acc_csf =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CashFlows/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CashFlows/CashFlow"></see>
    /// </summary>
    let CashFlow = _prefix "CashFlow"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CashFlows/hasSourceOfMoney"></see>
    /// </summary>
    let hasSourceOfMoney = _prefix "hasSourceOfMoney"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CashFlows/hasTargetOfMoney"></see>
    /// </summary>
    let hasTargetOfMoney = _prefix "hasTargetOfMoney"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CashFlows/CashFlowStructure"></see>
    /// </summary>
    let CashFlowStructure = _prefix "CashFlowStructure"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CashFlows/TriggeringEvent"></see>
    /// </summary>
    let TriggeringEvent = _prefix "TriggeringEvent"
