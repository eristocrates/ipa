namespace https.spec.edmcouncil.org.fibo.ontology.FND.Accounting.AccountingEquity.slash

open DoxAletheia

module fibo_fnd_acc_aeq =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/AccountingEquity/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/AccountingEquity/CapitalSurplus"></see>
    /// </summary>
    let CapitalSurplus = _prefix "CapitalSurplus"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/AccountingEquity/PaidInCapital"></see>
    /// </summary>
    let PaidInCapital = _prefix "PaidInCapital"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/AccountingEquity/EarningsBeforeInterestTaxesDepreciationAmortization"></see>
    /// </summary>
    let EarningsBeforeInterestTaxesDepreciationAmortization =
        _prefix "EarningsBeforeInterestTaxesDepreciationAmortization"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/AccountingEquity/FinancialAsset"></see>
    /// </summary>
    let FinancialAsset = _prefix "FinancialAsset"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/AccountingEquity/Income"></see>
    /// </summary>
    let Income = _prefix "Income"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/AccountingEquity/OwnersEquity"></see>
    /// </summary>
    let OwnersEquity = _prefix "OwnersEquity"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/AccountingEquity/RetainedEarnings"></see>
    /// </summary>
    let RetainedEarnings = _prefix "RetainedEarnings"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/AccountingEquity/PhysicalAsset"></see>
    /// </summary>
    let PhysicalAsset = _prefix "PhysicalAsset"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/AccountingEquity/ShareholdersEquity"></see>
    /// </summary>
    let ShareholdersEquity = _prefix "ShareholdersEquity"
