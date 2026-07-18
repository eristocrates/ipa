namespace https.spec.edmcouncil.org.fibo.ontology.FBC.ProductsAndServices.ClientsAndAccounts.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fbc_pas_caa =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasCorrespondingAccount"></see>
    /// </summary>
    let hasCorrespondingAccount =
        Namespaced_IRI.parse _namespace_name "hasCorrespondingAccount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LoanOrCreditAccount"></see>
    /// </summary>
    let LoanOrCreditAccount =
        Namespaced_IRI.parse _namespace_name "LoanOrCreditAccount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/CommercialLendingService"></see>
    /// </summary>
    let CommercialLendingService =
        Namespaced_IRI.parse _namespace_name "CommercialLendingService" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/DemandDepositAccount"></see>
    /// </summary>
    let DemandDepositAccount =
        Namespaced_IRI.parse _namespace_name "DemandDepositAccount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/DepositAccount"></see>
    /// </summary>
    let DepositAccount =
        Namespaced_IRI.parse _namespace_name "DepositAccount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/Account"></see>
    /// </summary>
    let Account = Namespaced_IRI.parse _namespace_name "Account" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountHolder"></see>
    /// </summary>
    let AccountHolder =
        Namespaced_IRI.parse _namespace_name "AccountHolder" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountIdentifier"></see>
    /// </summary>
    let AccountIdentifier =
        Namespaced_IRI.parse _namespace_name "AccountIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasCloseDate"></see>
    /// </summary>
    let hasCloseDate =
        Namespaced_IRI.parse _namespace_name "hasCloseDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/CloseDate"></see>
    /// </summary>
    let CloseDate = Namespaced_IRI.parse _namespace_name "CloseDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TransactionRecord"></see>
    /// </summary>
    let TransactionRecord =
        Namespaced_IRI.parse _namespace_name "TransactionRecord" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasOpenDate"></see>
    /// </summary>
    let hasOpenDate =
        Namespaced_IRI.parse _namespace_name "hasOpenDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/OpenDate"></see>
    /// </summary>
    let OpenDate = Namespaced_IRI.parse _namespace_name "OpenDate" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasBalance"></see>
    /// </summary>
    let hasBalance = Namespaced_IRI.parse _namespace_name "hasBalance" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/Balance"></see>
    /// </summary>
    let Balance = Namespaced_IRI.parse _namespace_name "Balance" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountProvider"></see>
    /// </summary>
    let AccountProvider =
        Namespaced_IRI.parse _namespace_name "AccountProvider" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountAsAnAsset"></see>
    /// </summary>
    let AccountAsAnAsset =
        Namespaced_IRI.parse _namespace_name "AccountAsAnAsset" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountOwnership"></see>
    /// </summary>
    let AccountOwnership =
        Namespaced_IRI.parse _namespace_name "AccountOwnership" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountSpecificServiceAgreement"></see>
    /// </summary>
    let AccountSpecificServiceAgreement =
        Namespaced_IRI.parse _namespace_name "AccountSpecificServiceAgreement" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountStatement"></see>
    /// </summary>
    let AccountStatement =
        Namespaced_IRI.parse _namespace_name "AccountStatement" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasEndingBalance"></see>
    /// </summary>
    let hasEndingBalance =
        Namespaced_IRI.parse _namespace_name "hasEndingBalance" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasStartingBalance"></see>
    /// </summary>
    let hasStartingBalance =
        Namespaced_IRI.parse _namespace_name "hasStartingBalance" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/appliesToAccount"></see>
    /// </summary>
    let appliesToAccount =
        Namespaced_IRI.parse _namespace_name "appliesToAccount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/recordsTransaction"></see>
    /// </summary>
    let recordsTransaction =
        Namespaced_IRI.parse _namespace_name "recordsTransaction" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/IndividualTransaction"></see>
    /// </summary>
    let IndividualTransaction =
        Namespaced_IRI.parse _namespace_name "IndividualTransaction" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountingTransaction"></see>
    /// </summary>
    let AccountingTransaction =
        Namespaced_IRI.parse _namespace_name "AccountingTransaction" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/BankAccountIdentifier"></see>
    /// </summary>
    let BankAccountIdentifier =
        Namespaced_IRI.parse _namespace_name "BankAccountIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/BankIdentifier"></see>
    /// </summary>
    let BankIdentifier =
        Namespaced_IRI.parse _namespace_name "BankIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/BasicBankAccountIdentifier"></see>
    /// </summary>
    let BasicBankAccountIdentifier =
        Namespaced_IRI.parse _namespace_name "BasicBankAccountIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/BrokerageAccount"></see>
    /// </summary>
    let BrokerageAccount =
        Namespaced_IRI.parse _namespace_name "BrokerageAccount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/InvestmentAccount"></see>
    /// </summary>
    let InvestmentAccount =
        Namespaced_IRI.parse _namespace_name "InvestmentAccount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/CertificateOfDeposit"></see>
    /// </summary>
    let CertificateOfDeposit =
        Namespaced_IRI.parse _namespace_name "CertificateOfDeposit" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/ChartOfAccounts"></see>
    /// </summary>
    let ChartOfAccounts =
        Namespaced_IRI.parse _namespace_name "ChartOfAccounts" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LedgerAccount"></see>
    /// </summary>
    let LedgerAccount =
        Namespaced_IRI.parse _namespace_name "LedgerAccount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/CustomerAccount"></see>
    /// </summary>
    let CustomerAccount =
        Namespaced_IRI.parse _namespace_name "CustomerAccount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/CustomerAccountHolder"></see>
    /// </summary>
    let CustomerAccountHolder =
        Namespaced_IRI.parse _namespace_name "CustomerAccountHolder" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TransactionDepositAccount"></see>
    /// </summary>
    let TransactionDepositAccount =
        Namespaced_IRI.parse _namespace_name "TransactionDepositAccount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/InvestmentOrDepositAccount"></see>
    /// </summary>
    let InvestmentOrDepositAccount =
        Namespaced_IRI.parse _namespace_name "InvestmentOrDepositAccount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/Fee"></see>
    /// </summary>
    let Fee = Namespaced_IRI.parse _namespace_name "Fee" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/GeneralLedger"></see>
    /// </summary>
    let GeneralLedger =
        Namespaced_IRI.parse _namespace_name "GeneralLedger" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TransactionIdentifier"></see>
    /// </summary>
    let TransactionIdentifier =
        Namespaced_IRI.parse _namespace_name "TransactionIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/involvesMerchant"></see>
    /// </summary>
    let involvesMerchant =
        Namespaced_IRI.parse _namespace_name "involvesMerchant" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TransactionCategory"></see>
    /// </summary>
    let TransactionCategory =
        Namespaced_IRI.parse _namespace_name "TransactionCategory" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TransactionSubcategory"></see>
    /// </summary>
    let TransactionSubcategory =
        Namespaced_IRI.parse _namespace_name "TransactionSubcategory" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasTransactionDescription"></see>
    /// </summary>
    let hasTransactionDescription =
        Namespaced_IRI.parse _namespace_name "hasTransactionDescription" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasPostingDate"></see>
    /// </summary>
    let hasPostingDate =
        Namespaced_IRI.parse _namespace_name "hasPostingDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/PostingDate"></see>
    /// </summary>
    let PostingDate =
        Namespaced_IRI.parse _namespace_name "PostingDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasTransactionDate"></see>
    /// </summary>
    let hasTransactionDate =
        Namespaced_IRI.parse _namespace_name "hasTransactionDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TransactionDate"></see>
    /// </summary>
    let TransactionDate =
        Namespaced_IRI.parse _namespace_name "TransactionDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/InternationalBankAccountIdentifier"></see>
    /// </summary>
    let InternationalBankAccountIdentifier =
        Namespaced_IRI.parse _namespace_name "InternationalBankAccountIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LedgerAccountClassificationScheme"></see>
    /// </summary>
    let LedgerAccountClassificationScheme =
        Namespaced_IRI.parse _namespace_name "LedgerAccountClassificationScheme" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LedgerAccountClassifier"></see>
    /// </summary>
    let LedgerAccountClassifier =
        Namespaced_IRI.parse _namespace_name "LedgerAccountClassifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LedgerAccountClassifier-Assets"></see>
    /// </summary>
    let ``LedgerAccountClassifier-Assets`` =
        Namespaced_IRI.parse _namespace_name "LedgerAccountClassifier-Assets" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LedgerAccountClassifier-Equity"></see>
    /// </summary>
    let ``LedgerAccountClassifier-Equity`` =
        Namespaced_IRI.parse _namespace_name "LedgerAccountClassifier-Equity" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LedgerAccountClassifier-Expenses"></see>
    /// </summary>
    let ``LedgerAccountClassifier-Expenses`` =
        Namespaced_IRI.parse _namespace_name "LedgerAccountClassifier-Expenses" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LedgerAccountClassifier-Liabilities"></see>
    /// </summary>
    let ``LedgerAccountClassifier-Liabilities`` =
        Namespaced_IRI.parse _namespace_name "LedgerAccountClassifier-Liabilities" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LedgerAccountClassifier-Revenue"></see>
    /// </summary>
    let ``LedgerAccountClassifier-Revenue`` =
        Namespaced_IRI.parse _namespace_name "LedgerAccountClassifier-Revenue" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LendingOfficer"></see>
    /// </summary>
    let LendingOfficer =
        Namespaced_IRI.parse _namespace_name "LendingOfficer" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/RelationshipManager"></see>
    /// </summary>
    let RelationshipManager =
        Namespaced_IRI.parse _namespace_name "RelationshipManager" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/NonTransactionDepositAccount"></see>
    /// </summary>
    let NonTransactionDepositAccount =
        Namespaced_IRI.parse _namespace_name "NonTransactionDepositAccount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/PaymentDueDate"></see>
    /// </summary>
    let PaymentDueDate =
        Namespaced_IRI.parse _namespace_name "PaymentDueDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TimeCertificateOfDepositAccount"></see>
    /// </summary>
    let TimeCertificateOfDepositAccount =
        Namespaced_IRI.parse _namespace_name "TimeCertificateOfDepositAccount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TimeDepositAccount"></see>
    /// </summary>
    let TimeDepositAccount =
        Namespaced_IRI.parse _namespace_name "TimeDepositAccount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TimeDepositOpenAccount"></see>
    /// </summary>
    let TimeDepositOpenAccount =
        Namespaced_IRI.parse _namespace_name "TimeDepositOpenAccount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TransactionRecordIdentifier"></see>
    /// </summary>
    let TransactionRecordIdentifier =
        Namespaced_IRI.parse _namespace_name "TransactionRecordIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasTransactionRecordStatus"></see>
    /// </summary>
    let hasTransactionRecordStatus =
        Namespaced_IRI.parse _namespace_name "hasTransactionRecordStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasPaymentDueDate"></see>
    /// </summary>
    let hasPaymentDueDate =
        Namespaced_IRI.parse _namespace_name "hasPaymentDueDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasPrimaryAccountHolder"></see>
    /// </summary>
    let hasPrimaryAccountHolder =
        Namespaced_IRI.parse _namespace_name "hasPrimaryAccountHolder" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasSecondaryAccountHolder"></see>
    /// </summary>
    let hasSecondaryAccountHolder =
        Namespaced_IRI.parse _namespace_name "hasSecondaryAccountHolder" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/isLinkedToAccount"></see>
    /// </summary>
    let isLinkedToAccount =
        Namespaced_IRI.parse _namespace_name "isLinkedToAccount" |> NamespacedName
