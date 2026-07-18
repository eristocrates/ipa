namespace https.spec.edmcouncil.org.fibo.ontology.FND.Accounting.AccountingEquity.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_acc_aeq =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/AccountingEquity/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/AccountingEquity/CapitalSurplus"></see>
    /// </summary>
    let CapitalSurplus =
        Namespaced_IRI.parse _namespace_name "CapitalSurplus" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/AccountingEquity/PaidInCapital"></see>
    /// </summary>
    let PaidInCapital =
        Namespaced_IRI.parse _namespace_name "PaidInCapital" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/AccountingEquity/EarningsBeforeInterestTaxesDepreciationAmortization"></see>
    /// </summary>
    let EarningsBeforeInterestTaxesDepreciationAmortization =
        Namespaced_IRI.parse _namespace_name "EarningsBeforeInterestTaxesDepreciationAmortization" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/AccountingEquity/FinancialAsset"></see>
    /// </summary>
    let FinancialAsset =
        Namespaced_IRI.parse _namespace_name "FinancialAsset" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/AccountingEquity/Income"></see>
    /// </summary>
    let Income = Namespaced_IRI.parse _namespace_name "Income" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/AccountingEquity/OwnersEquity"></see>
    /// </summary>
    let OwnersEquity =
        Namespaced_IRI.parse _namespace_name "OwnersEquity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/AccountingEquity/RetainedEarnings"></see>
    /// </summary>
    let RetainedEarnings =
        Namespaced_IRI.parse _namespace_name "RetainedEarnings" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/AccountingEquity/PhysicalAsset"></see>
    /// </summary>
    let PhysicalAsset =
        Namespaced_IRI.parse _namespace_name "PhysicalAsset" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/AccountingEquity/ShareholdersEquity"></see>
    /// </summary>
    let ShareholdersEquity =
        Namespaced_IRI.parse _namespace_name "ShareholdersEquity" |> NamespacedName
