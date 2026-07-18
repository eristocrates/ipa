namespace https.spec.edmcouncil.org.fibo.ontology.FND.Accounting.CashFlows.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_acc_csf =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CashFlows/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CashFlows/CashFlow"></see>
    /// </summary>
    let CashFlow = Namespaced_IRI.parse _namespace_name "CashFlow" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CashFlows/hasSourceOfMoney"></see>
    /// </summary>
    let hasSourceOfMoney =
        Namespaced_IRI.parse _namespace_name "hasSourceOfMoney" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CashFlows/hasTargetOfMoney"></see>
    /// </summary>
    let hasTargetOfMoney =
        Namespaced_IRI.parse _namespace_name "hasTargetOfMoney" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CashFlows/CashFlowStructure"></see>
    /// </summary>
    let CashFlowStructure =
        Namespaced_IRI.parse _namespace_name "CashFlowStructure" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CashFlows/TriggeringEvent"></see>
    /// </summary>
    let TriggeringEvent =
        Namespaced_IRI.parse _namespace_name "TriggeringEvent" |> NamespacedName
