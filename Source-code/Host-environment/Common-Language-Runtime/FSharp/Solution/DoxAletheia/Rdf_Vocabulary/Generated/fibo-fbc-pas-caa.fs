namespace https.spec.edmcouncil.org.fibo.ontology.FBC.ProductsAndServices.ClientsAndAccounts.slash

open DoxAletheia

module fibo_fbc_pas_caa =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasCorrespondingAccount"></see>
    /// </summary>
    let hasCorrespondingAccount = _prefix "hasCorrespondingAccount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LoanOrCreditAccount"></see>
    /// </summary>
    let LoanOrCreditAccount = _prefix "LoanOrCreditAccount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/CommercialLendingService"></see>
    /// </summary>
    let CommercialLendingService = _prefix "CommercialLendingService"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/DemandDepositAccount"></see>
    /// </summary>
    let DemandDepositAccount = _prefix "DemandDepositAccount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/DepositAccount"></see>
    /// </summary>
    let DepositAccount = _prefix "DepositAccount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/Account"></see>
    /// </summary>
    let Account = _prefix "Account"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountHolder"></see>
    /// </summary>
    let AccountHolder = _prefix "AccountHolder"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountIdentifier"></see>
    /// </summary>
    let AccountIdentifier = _prefix "AccountIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasCloseDate"></see>
    /// </summary>
    let hasCloseDate = _prefix "hasCloseDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/CloseDate"></see>
    /// </summary>
    let CloseDate = _prefix "CloseDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TransactionRecord"></see>
    /// </summary>
    let TransactionRecord = _prefix "TransactionRecord"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasOpenDate"></see>
    /// </summary>
    let hasOpenDate = _prefix "hasOpenDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/OpenDate"></see>
    /// </summary>
    let OpenDate = _prefix "OpenDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasBalance"></see>
    /// </summary>
    let hasBalance = _prefix "hasBalance"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/Balance"></see>
    /// </summary>
    let Balance = _prefix "Balance"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountProvider"></see>
    /// </summary>
    let AccountProvider = _prefix "AccountProvider"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountAsAnAsset"></see>
    /// </summary>
    let AccountAsAnAsset = _prefix "AccountAsAnAsset"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountOwnership"></see>
    /// </summary>
    let AccountOwnership = _prefix "AccountOwnership"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountSpecificServiceAgreement"></see>
    /// </summary>
    let AccountSpecificServiceAgreement = _prefix "AccountSpecificServiceAgreement"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountStatement"></see>
    /// </summary>
    let AccountStatement = _prefix "AccountStatement"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasEndingBalance"></see>
    /// </summary>
    let hasEndingBalance = _prefix "hasEndingBalance"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasStartingBalance"></see>
    /// </summary>
    let hasStartingBalance = _prefix "hasStartingBalance"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/appliesToAccount"></see>
    /// </summary>
    let appliesToAccount = _prefix "appliesToAccount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/recordsTransaction"></see>
    /// </summary>
    let recordsTransaction = _prefix "recordsTransaction"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/IndividualTransaction"></see>
    /// </summary>
    let IndividualTransaction = _prefix "IndividualTransaction"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountingTransaction"></see>
    /// </summary>
    let AccountingTransaction = _prefix "AccountingTransaction"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/BankAccountIdentifier"></see>
    /// </summary>
    let BankAccountIdentifier = _prefix "BankAccountIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/BankIdentifier"></see>
    /// </summary>
    let BankIdentifier = _prefix "BankIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/BasicBankAccountIdentifier"></see>
    /// </summary>
    let BasicBankAccountIdentifier = _prefix "BasicBankAccountIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/BrokerageAccount"></see>
    /// </summary>
    let BrokerageAccount = _prefix "BrokerageAccount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/InvestmentAccount"></see>
    /// </summary>
    let InvestmentAccount = _prefix "InvestmentAccount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/CertificateOfDeposit"></see>
    /// </summary>
    let CertificateOfDeposit = _prefix "CertificateOfDeposit"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/ChartOfAccounts"></see>
    /// </summary>
    let ChartOfAccounts = _prefix "ChartOfAccounts"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LedgerAccount"></see>
    /// </summary>
    let LedgerAccount = _prefix "LedgerAccount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/CustomerAccount"></see>
    /// </summary>
    let CustomerAccount = _prefix "CustomerAccount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/CustomerAccountHolder"></see>
    /// </summary>
    let CustomerAccountHolder = _prefix "CustomerAccountHolder"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TransactionDepositAccount"></see>
    /// </summary>
    let TransactionDepositAccount = _prefix "TransactionDepositAccount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/InvestmentOrDepositAccount"></see>
    /// </summary>
    let InvestmentOrDepositAccount = _prefix "InvestmentOrDepositAccount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/Fee"></see>
    /// </summary>
    let Fee = _prefix "Fee"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/GeneralLedger"></see>
    /// </summary>
    let GeneralLedger = _prefix "GeneralLedger"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TransactionIdentifier"></see>
    /// </summary>
    let TransactionIdentifier = _prefix "TransactionIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/involvesMerchant"></see>
    /// </summary>
    let involvesMerchant = _prefix "involvesMerchant"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TransactionCategory"></see>
    /// </summary>
    let TransactionCategory = _prefix "TransactionCategory"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TransactionSubcategory"></see>
    /// </summary>
    let TransactionSubcategory = _prefix "TransactionSubcategory"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasTransactionDescription"></see>
    /// </summary>
    let hasTransactionDescription = _prefix "hasTransactionDescription"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasPostingDate"></see>
    /// </summary>
    let hasPostingDate = _prefix "hasPostingDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/PostingDate"></see>
    /// </summary>
    let PostingDate = _prefix "PostingDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasTransactionDate"></see>
    /// </summary>
    let hasTransactionDate = _prefix "hasTransactionDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TransactionDate"></see>
    /// </summary>
    let TransactionDate = _prefix "TransactionDate"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/InternationalBankAccountIdentifier"></see>
    /// </summary>
    let InternationalBankAccountIdentifier =
        _prefix "InternationalBankAccountIdentifier"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LedgerAccountClassificationScheme"></see>
    /// </summary>
    let LedgerAccountClassificationScheme = _prefix "LedgerAccountClassificationScheme"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LedgerAccountClassifier"></see>
    /// </summary>
    let LedgerAccountClassifier = _prefix "LedgerAccountClassifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LedgerAccountClassifier-Assets"></see>
    /// </summary>
    let ``LedgerAccountClassifier-Assets`` = _prefix "LedgerAccountClassifier-Assets"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LedgerAccountClassifier-Equity"></see>
    /// </summary>
    let ``LedgerAccountClassifier-Equity`` = _prefix "LedgerAccountClassifier-Equity"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LedgerAccountClassifier-Expenses"></see>
    /// </summary>
    let ``LedgerAccountClassifier-Expenses`` =
        _prefix "LedgerAccountClassifier-Expenses"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LedgerAccountClassifier-Liabilities"></see>
    /// </summary>
    let ``LedgerAccountClassifier-Liabilities`` =
        _prefix "LedgerAccountClassifier-Liabilities"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LedgerAccountClassifier-Revenue"></see>
    /// </summary>
    let ``LedgerAccountClassifier-Revenue`` = _prefix "LedgerAccountClassifier-Revenue"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LendingOfficer"></see>
    /// </summary>
    let LendingOfficer = _prefix "LendingOfficer"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/RelationshipManager"></see>
    /// </summary>
    let RelationshipManager = _prefix "RelationshipManager"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/NonTransactionDepositAccount"></see>
    /// </summary>
    let NonTransactionDepositAccount = _prefix "NonTransactionDepositAccount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/PaymentDueDate"></see>
    /// </summary>
    let PaymentDueDate = _prefix "PaymentDueDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TimeCertificateOfDepositAccount"></see>
    /// </summary>
    let TimeCertificateOfDepositAccount = _prefix "TimeCertificateOfDepositAccount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TimeDepositAccount"></see>
    /// </summary>
    let TimeDepositAccount = _prefix "TimeDepositAccount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TimeDepositOpenAccount"></see>
    /// </summary>
    let TimeDepositOpenAccount = _prefix "TimeDepositOpenAccount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TransactionRecordIdentifier"></see>
    /// </summary>
    let TransactionRecordIdentifier = _prefix "TransactionRecordIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasTransactionRecordStatus"></see>
    /// </summary>
    let hasTransactionRecordStatus = _prefix "hasTransactionRecordStatus"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasPaymentDueDate"></see>
    /// </summary>
    let hasPaymentDueDate = _prefix "hasPaymentDueDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasPrimaryAccountHolder"></see>
    /// </summary>
    let hasPrimaryAccountHolder = _prefix "hasPrimaryAccountHolder"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasSecondaryAccountHolder"></see>
    /// </summary>
    let hasSecondaryAccountHolder = _prefix "hasSecondaryAccountHolder"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/isLinkedToAccount"></see>
    /// </summary>
    let isLinkedToAccount = _prefix "isLinkedToAccount"
