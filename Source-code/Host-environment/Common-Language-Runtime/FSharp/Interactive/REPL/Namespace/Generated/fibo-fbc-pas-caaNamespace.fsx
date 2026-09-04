#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fbc-pas-caa`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/" "fibo-fbc-pas-caa"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : account^^xsd:string</para>
    ///   <para>skos:definition : container for records associated with a business arrangement for regular transactions and services^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : In general, an account is associated with a contractual relationship between a buyer and seller under which payment may be made at a later time. General ledger accounts are an exception to this, however, and typically do not have account holders, including internal account holders. They may, on the other hand, have responsible parties.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/Account">fibo-fbc-pas-caa:Account</a>
    /// </summary>
    let Account = _prefixId.prefix "Account"
    /// <summary>
    ///   <para>rdfs:label : account as an asset^^xsd:string</para>
    ///   <para>skos:definition : financial asset in the form of an account^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountAsAnAsset">fibo-fbc-pas-caa:AccountAsAnAsset</a>
    /// </summary>
    let AccountAsAnAsset = _prefixId.prefix "AccountAsAnAsset"
    /// <summary>
    ///   <para>rdfs:label : account holder^^xsd:string</para>
    ///   <para>skos:definition : party that owns an account^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : An account holder is named on the account and is authorized to conduct transactions associated with the account. Authorization is typically evidenced by signatures maintained on file by the account provider.^^xsd:stringcmns-av:explanatoryNote : Note that this concept of account holder applies to internal accounts that are non-general ledger accounts also have account holders, such as payroll accounts, internal checking accounts associated with cashier's checks, and so forth.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountHolder">fibo-fbc-pas-caa:AccountHolder</a>
    /// </summary>
    let AccountHolder = _prefixId.prefix "AccountHolder"
    /// <summary>
    ///   <para>rdfs:label : account identifier^^xsd:string</para>
    ///   <para>skos:definition : identifier that denotes an account^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 13616-1:2007 Financial services - International bank account number (IBAN)^^xsd:string</para>
    ///   <para>cmns-av:synonym : account number^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountIdentifier">fibo-fbc-pas-caa:AccountIdentifier</a>
    /// </summary>
    let AccountIdentifier = _prefixId.prefix "AccountIdentifier"
    /// <summary>
    ///   <para>rdfs:label : account ownership^^xsd:string</para>
    ///   <para>skos:definition : holding of an account^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountOwnership">fibo-fbc-pas-caa:AccountOwnership</a>
    /// </summary>
    let AccountOwnership = _prefixId.prefix "AccountOwnership"
    /// <summary>
    ///   <para>rdfs:label : account provider^^xsd:string</para>
    ///   <para>skos:definition : party that provides and services an account^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountProvider">fibo-fbc-pas-caa:AccountProvider</a>
    /// </summary>
    let AccountProvider = _prefixId.prefix "AccountProvider"

    /// <summary>
    ///   <para>rdfs:label : account-specific service agreement^^xsd:string</para>
    ///   <para>skos:definition : service-agreement that is account-specific, applicable in cases where a client might hold multiple accounts with differing terms and conditions^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Customers of financial service providers frequently hold multiple accounts - brokerage accounts, checking and savings accounts, trust accounts, and so forth - which may have specific terms and conditions associated with them.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountSpecificServiceAgreement">fibo-fbc-pas-caa:AccountSpecificServiceAgreement</a>
    /// </summary>
    let AccountSpecificServiceAgreement =
        _prefixId.prefix "AccountSpecificServiceAgreement"

    /// <summary>
    ///   <para>rdfs:label : account statement^^xsd:string</para>
    ///   <para>skos:definition : periodic summary of account activity for a given period of time^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Common kinds of account statements include checking account statements, usually provided monthly, and brokerage account statements, which are provided monthly or quarterly, depending on the terms of the account agreement. Monthly credit card bills are also considered account statements.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountStatement">fibo-fbc-pas-caa:AccountStatement</a>
    /// </summary>
    let AccountStatement = _prefixId.prefix "AccountStatement"
    /// <summary>
    ///   <para>rdfs:label : accounting transaction^^xsd:string</para>
    ///   <para>skos:definition : event recognized by an entry in the records of an account^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountingTransaction">fibo-fbc-pas-caa:AccountingTransaction</a>
    /// </summary>
    let AccountingTransaction = _prefixId.prefix "AccountingTransaction"
    /// <summary>
    ///   <para>rdfs:label : balance^^xsd:string</para>
    ///   <para>skos:definition : amount of money available or owed^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The balance is the net amount after factoring in all debits and credits, including service charges and fees.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/Balance">fibo-fbc-pas-caa:Balance</a>
    /// </summary>
    let Balance = _prefixId.prefix "Balance"
    /// <summary>
    ///   <para>rdfs:label : bank account identifier^^xsd:string</para>
    ///   <para>skos:definition : identifier that identifies a demand deposit account provided by a bank^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 13616-1:2007 Financial services - International bank account number (IBAN)^^xsd:string</para>
    ///   <para>cmns-av:synonym : bank account number^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/BankAccountIdentifier">fibo-fbc-pas-caa:BankAccountIdentifier</a>
    /// </summary>
    let BankAccountIdentifier = _prefixId.prefix "BankAccountIdentifier"
    /// <summary>
    ///   <para>rdfs:label : bank identifier^^xsd:string</para>
    ///   <para>skos:definition : identifier that uniquely identifies the financial institution and, when appropriate, the branch of that financial institution servicing an account^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 13616-1:2007 Financial services - International bank account number (IBAN)^^xsd:string</para>
    ///   <para>cmns-av:synonym : bank number^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/BankIdentifier">fibo-fbc-pas-caa:BankIdentifier</a>
    /// </summary>
    let BankIdentifier = _prefixId.prefix "BankIdentifier"
    /// <summary>
    ///   <para>rdfs:label : basic bank account identifier^^xsd:string</para>
    ///   <para>skos:definition : identifier that uniquely identifies an individual account at a specific financial institution in a particular country and which includes a bank identifier of the financial institution servicing that account^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : BBAN^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 13616-1:2007 Financial services - International bank account number (IBAN)^^xsd:string</para>
    ///   <para>cmns-av:synonym : basic bank account number^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/BasicBankAccountIdentifier">fibo-fbc-pas-caa:BasicBankAccountIdentifier</a>
    /// </summary>
    let BasicBankAccountIdentifier = _prefixId.prefix "BasicBankAccountIdentifier"
    /// <summary>
    ///   <para>rdfs:label : brokerage account^^xsd:string</para>
    ///   <para>skos:definition : account offered by a broker that allows the investor to deposit funds and place investment orders^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The investor owns the assets contained in the brokerage account and must usually claim as income any capital gains incurred.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/BrokerageAccount">fibo-fbc-pas-caa:BrokerageAccount</a>
    /// </summary>
    let BrokerageAccount = _prefixId.prefix "BrokerageAccount"
    /// <summary>
    ///   <para>rdfs:label : certificate of deposit</para>
    ///   <para>skos:definition : cash instrument associated with a time deposit account that cannot be withdrawn for a certain period of time (term)</para>
    ///   <para>cmns-av:abbreviation : CD^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : When the term is over it can be withdrawn or it can be held for another term. The longer the term the better the yield on the money.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/CertificateOfDeposit">fibo-fbc-pas-caa:CertificateOfDeposit</a>
    /// </summary>
    let CertificateOfDeposit = _prefixId.prefix "CertificateOfDeposit"
    /// <summary>
    ///   <para>rdfs:label : chart of accounts^^xsd:string</para>
    ///   <para>skos:definition : structured system of financial account codes used to classify, record, and organize an entity's financial transactions in accordance with applicable legal, regulatory, and reporting requirements^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/ChartOfAccounts">fibo-fbc-pas-caa:ChartOfAccounts</a>
    /// </summary>
    let ChartOfAccounts = _prefixId.prefix "ChartOfAccounts"
    /// <summary>
    ///   <para>rdfs:label : close date^^xsd:string</para>
    ///   <para>skos:definition : date on which something was closed^^xsd:string</para>
    ///   <para>skos:example : account close date, transaction record close date, and so forth^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/CloseDate">fibo-fbc-pas-caa:CloseDate</a>
    /// </summary>
    let CloseDate = _prefixId.prefix "CloseDate"
    /// <summary>
    ///   <para>rdfs:label : commercial lending service^^xsd:string</para>
    ///   <para>skos:definition : service involving the extension of credit to support business activities^^xsd:string</para>
    ///   <para>skos:example : Examples include operating lines of credit and term loans for property, plant and equipment (PP&amp;E).^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/CommercialLendingService">fibo-fbc-pas-caa:CommercialLendingService</a>
    /// </summary>
    let CommercialLendingService = _prefixId.prefix "CommercialLendingService"
    /// <summary>
    ///   <para>rdfs:label : customer account^^xsd:string</para>
    ///   <para>skos:definition : account that represents an identified, named collection of balances and cumulative totals used to summarize customer transaction-related activity over a designated period of time^^xsd:string</para>
    ///   <para>cmns-av:synonym : financial service account^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/CustomerAccount">fibo-fbc-pas-caa:CustomerAccount</a>
    /// </summary>
    let CustomerAccount = _prefixId.prefix "CustomerAccount"
    /// <summary>
    ///   <para>rdfs:label : customer account holder^^xsd:string</para>
    ///   <para>skos:definition : party that owns a customer account^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/CustomerAccountHolder">fibo-fbc-pas-caa:CustomerAccountHolder</a>
    /// </summary>
    let CustomerAccountHolder = _prefixId.prefix "CustomerAccountHolder"
    /// <summary>
    ///   <para>rdfs:label : demand deposit account^^xsd:string</para>
    ///   <para>skos:definition : non-interest-bearing deposit account in which deposits are payable immediately on demand, or that are issued with an original maturity or required notice period of less than seven days, or that represent funds for which the depository institution does not reserve the right to require at least seven days' written notice of an intended withdrawal^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : DDA^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Demand deposits include any matured time deposits without automatic renewal provisions, unless the deposit agreement provides for the funds to be transferred at maturity to another type of account. Demand deposits do not include: (i) money market deposit accounts (MMDAs) or (ii) NOW accounts.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/DemandDepositAccount">fibo-fbc-pas-caa:DemandDepositAccount</a>
    /// </summary>
    let DemandDepositAccount = _prefixId.prefix "DemandDepositAccount"
    /// <summary>
    ///   <para>rdfs:label : deposit account^^xsd:string</para>
    ///   <para>skos:definition : account that provides a record of money placed with a depository institution for safekeeping and management^^xsd:string</para>
    ///   <para>skos:example : Deposit accounts include savings accounts, money market accounts, and transactional accounts, such as demand deposit accounts, among others.^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The account holder has the right to withdraw deposited funds, as set forth in the terms and conditions governing the account agreement. Deposit accounts may be insured up to a certain amount, depending on the jurisdiction.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/DepositAccount">fibo-fbc-pas-caa:DepositAccount</a>
    /// </summary>
    let DepositAccount = _prefixId.prefix "DepositAccount"
    /// <summary>
    ///   <para>rdfs:label : fee^^xsd:string</para>
    ///   <para>skos:definition : charge for services performed^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/Fee">fibo-fbc-pas-caa:Fee</a>
    /// </summary>
    let Fee = _prefixId.prefix "Fee"
    /// <summary>
    ///   <para>rdfs:label : general ledger^^xsd:string</para>
    ///   <para>skos:definition : organized collection of ledger accounts used to record and summarize changes in position as transactions are posted during an accounting period^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/GeneralLedger">fibo-fbc-pas-caa:GeneralLedger</a>
    /// </summary>
    let GeneralLedger = _prefixId.prefix "GeneralLedger"
    /// <summary>
    ///   <para>rdfs:label : individual transaction^^xsd:string</para>
    ///   <para>skos:definition : event that has a monetary impact and is documented in the records associated with an account^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/IndividualTransaction">fibo-fbc-pas-caa:IndividualTransaction</a>
    /// </summary>
    let IndividualTransaction = _prefixId.prefix "IndividualTransaction"

    /// <summary>
    ///   <para>rdfs:label : international bank account identifier^^xsd:string</para>
    ///   <para>skos:definition : identifier for a bank account that is an expanded version of the basic bank account number (BBAN), intended for use internationally^^xsd:string</para>
    ///   <para>skos:example : For an account in Switzerland, suppose that an example domestic account number is 762 1162-3852.957. Suppose further that the bank identifier portion of that domestic account number is 762, or normalized for the BBAN is '00762'. For that example, the corresponding BBAN is '00762011623852957' and IBAN is 'CH9300762011623852957'.^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : IBAN^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 13616-1:2007 Financial services - International bank account number (IBAN)^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Note that international bank account numbers are formatted uniquely by country. A description of the country-specific formats is available from SWIFT (https://www.swift.com/), which is the ISO registrar for ISO 13616.^^xsd:stringcmns-av:explanatoryNote : The IBAN structure is defined in ISO 13616-1 and consists of a two-letter ISO 3166-1 country code, followed by two check digits and up to thirty alphanumeric characters for a BBAN (Basic Bank Account Number) which has a fixed length per country and, included within it, a bank identifier with a fixed position and a fixed length per country. The check digits are calculated based on the scheme defined in ISO/IEC 7064 (MOD97-10).^^xsd:string</para>
    ///   <para>cmns-av:synonym : international bank account number^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/InternationalBankAccountIdentifier">fibo-fbc-pas-caa:InternationalBankAccountIdentifier</a>
    /// </summary>
    let InternationalBankAccountIdentifier =
        _prefixId.prefix "InternationalBankAccountIdentifier"

    /// <summary>
    ///   <para>rdfs:label : investment account^^xsd:string</para>
    ///   <para>skos:definition : account that provides a record of deposits of funds and/or securities held at a financial institution^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The typical objectives of an investment account are to achieve long term growth, income or capital preservation from the deposited asset portfolio. Investment accounts are typically not insured.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/InvestmentAccount">fibo-fbc-pas-caa:InvestmentAccount</a>
    /// </summary>
    let InvestmentAccount = _prefixId.prefix "InvestmentAccount"
    /// <summary>
    ///   <para>rdfs:label : investment or deposit account^^xsd:string</para>
    ///   <para>skos:definition : account associated with a product or service that requires the account holder to provide funds for management by the account provider^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The account holder may or may not be entitled to consideration in exchange for providing such funds, for example, interest, depending on the type of account and the terms and conditions associated with it. Also, there may be fees associated with management services provided by the account provider. Note too that this may be an internal account held on behalf of an institution or a customer account.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/InvestmentOrDepositAccount">fibo-fbc-pas-caa:InvestmentOrDepositAccount</a>
    /// </summary>
    let InvestmentOrDepositAccount = _prefixId.prefix "InvestmentOrDepositAccount"
    /// <summary>
    ///   <para>rdfs:label : ledger account^^xsd:string</para>
    ///   <para>skos:definition : individual record for one element or sub-element in a ledger that records and summarizes increases, decreases, and balances associated with that specific element^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Ledger accounts are internal to a legal entity's accounting system(s).^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LedgerAccount">fibo-fbc-pas-caa:LedgerAccount</a>
    /// </summary>
    let LedgerAccount = _prefixId.prefix "LedgerAccount"

    let LedgerAccountClassificationScheme =
        _prefixId.prefix "LedgerAccountClassificationScheme"

    /// <summary>
    ///   <para>rdfs:label : ledger account classifier^^xsd:string</para>
    ///   <para>skos:definition : classifier used to organize an entity's financial accounts in accordance with applicable legal, regulatory, and reporting requirements^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LedgerAccountClassifier">fibo-fbc-pas-caa:LedgerAccountClassifier</a>
    /// </summary>
    let LedgerAccountClassifier = _prefixId.prefix "LedgerAccountClassifier"

    let LedgerAccountClassifier_Assets =
        _prefixId.prefix "LedgerAccountClassifier-Assets"

    let LedgerAccountClassifier_Equity =
        _prefixId.prefix "LedgerAccountClassifier-Equity"

    let LedgerAccountClassifier_Expenses =
        _prefixId.prefix "LedgerAccountClassifier-Expenses"

    let LedgerAccountClassifier_Liabilities =
        _prefixId.prefix "LedgerAccountClassifier-Liabilities"

    let LedgerAccountClassifier_Revenue =
        _prefixId.prefix "LedgerAccountClassifier-Revenue"

    /// <summary>
    ///   <para>rdfs:label : lending officer^^xsd:string</para>
    ///   <para>skos:definition : corporate officer that has overarching responsibility for the relationship with a specific borrower or account^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LendingOfficer">fibo-fbc-pas-caa:LendingOfficer</a>
    /// </summary>
    let LendingOfficer = _prefixId.prefix "LendingOfficer"
    /// <summary>
    ///   <para>rdfs:label : loan or credit account^^xsd:string</para>
    ///   <para>skos:definition : account associated with a service in which the account holder receives funds from the account provider under certain terms and conditions for repayment^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Note that this may be an internal account held on behalf of an institution or a customer account, such as a line of credit account associated with an internal line of business.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LoanOrCreditAccount">fibo-fbc-pas-caa:LoanOrCreditAccount</a>
    /// </summary>
    let LoanOrCreditAccount = _prefixId.prefix "LoanOrCreditAccount"
    /// <summary>
    ///   <para>rdfs:label : non-transaction deposit account^^xsd:string</para>
    ///   <para>skos:definition : any deposit account that is not explicitly considered a transaction account^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Non-transaction accounts include: (a) savings deposits ((i) money market deposit accounts (MMDAs) and (ii) other savings deposits) and (b) time deposits ((i) time certificates of deposit and (ii) time deposits, open account).^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/NonTransactionDepositAccount">fibo-fbc-pas-caa:NonTransactionDepositAccount</a>
    /// </summary>
    let NonTransactionDepositAccount = _prefixId.prefix "NonTransactionDepositAccount"
    /// <summary>
    ///   <para>rdfs:label : open date^^xsd:string</para>
    ///   <para>skos:definition : date on which something was created^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/OpenDate">fibo-fbc-pas-caa:OpenDate</a>
    /// </summary>
    let OpenDate = _prefixId.prefix "OpenDate"
    /// <summary>
    ///   <para>rdfs:label : payment due date^^xsd:string</para>
    ///   <para>skos:definition : date by which payment of the current outstanding balance, part thereof, or a minimum amount due must be made to the creditor^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/PaymentDueDate">fibo-fbc-pas-caa:PaymentDueDate</a>
    /// </summary>
    let PaymentDueDate = _prefixId.prefix "PaymentDueDate"
    /// <summary>
    ///   <para>rdfs:label : posting date^^xsd:string</para>
    ///   <para>skos:definition : date that determines in which posting period a document or journal entry is added to an account record^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/PostingDate">fibo-fbc-pas-caa:PostingDate</a>
    /// </summary>
    let PostingDate = _prefixId.prefix "PostingDate"
    /// <summary>
    ///   <para>rdfs:label : relationship manager^^xsd:string</para>
    ///   <para>skos:definition : responsible party who manages a client's account and oversees their relationship with the service provider^^xsd:string</para>
    ///   <para>cmns-av:synonym : account manager^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/RelationshipManager">fibo-fbc-pas-caa:RelationshipManager</a>
    /// </summary>
    let RelationshipManager = _prefixId.prefix "RelationshipManager"

    /// <summary>
    ///   <para>rdfs:label : time certificate of deposit account^^xsd:string</para>
    ///   <para>skos:definition : time deposit account that allows deposits evidenced by a negotiable or nonnegotiable instrument, or a deposit in book entry form evidenced by a receipt or similar acknowledgement issued by the bank, that provides, on its face, that the amount of such deposit is payable to the bearer, to any specified person, or to the order of a specified person, as follows: (1) on a certain date not less than seven days after the date of deposit, (2) at the expiration of a specified period not less than seven days after the date of the deposit, or (3) upon written notice to the bank which is to be given not less than seven days before the date of withdrawal.^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : CDA^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TimeCertificateOfDepositAccount">fibo-fbc-pas-caa:TimeCertificateOfDepositAccount</a>
    /// </summary>
    let TimeCertificateOfDepositAccount =
        _prefixId.prefix "TimeCertificateOfDepositAccount"

    /// <summary>
    ///   <para>rdfs:label : time deposit account^^xsd:string</para>
    ///   <para>skos:definition : deposit account that the depositor does not have a right, and is not permitted, to make withdrawals from within six days after the date of deposit unless the deposit is subject to an early withdrawal penalty of at least seven days' simple interest on amounts withdrawn within the first six days after deposit^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A time deposit from which partial early withdrawals are permitted must impose additional early withdrawal penalties of at least seven days' simple interest on amounts withdrawn within six days after each partial withdrawal. If such additional early withdrawal penalties are not imposed, the account ceases to be a time deposit. The account may become a savings deposit if it meets the requirements for a savings deposit; otherwise it becomes a demand deposit.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TimeDepositAccount">fibo-fbc-pas-caa:TimeDepositAccount</a>
    /// </summary>
    let TimeDepositAccount = _prefixId.prefix "TimeDepositAccount"
    /// <summary>
    ///   <para>rdfs:label : time deposit open account^^xsd:string</para>
    ///   <para>skos:definition : time deposit account that allows deposits (other than time certificates of deposit) for which there is in force a written contract with the depositor that neither the whole nor any part of such deposit may be withdrawn prior to (1) the date of maturity, which shall be not less than seven days after the date of the deposit, or (2) the expiration of a specified period of written notice of not less than seven days^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TimeDepositOpenAccount">fibo-fbc-pas-caa:TimeDepositOpenAccount</a>
    /// </summary>
    let TimeDepositOpenAccount = _prefixId.prefix "TimeDepositOpenAccount"
    /// <summary>
    ///   <para>rdfs:label : transaction category^^xsd:string</para>
    ///   <para>skos:definition : high-level classifier for an individual transaction^^xsd:string</para>
    ///   <para>skos:example : credit, debit, fee^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TransactionCategory">fibo-fbc-pas-caa:TransactionCategory</a>
    /// </summary>
    let TransactionCategory = _prefixId.prefix "TransactionCategory"
    /// <summary>
    ///   <para>rdfs:label : transaction date^^xsd:string</para>
    ///   <para>skos:definition : date on which a specific transaction was initiated^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TransactionDate">fibo-fbc-pas-caa:TransactionDate</a>
    /// </summary>
    let TransactionDate = _prefixId.prefix "TransactionDate"
    /// <summary>
    ///   <para>rdfs:label : transaction deposit account^^xsd:string</para>
    ///   <para>skos:definition : deposit account from which the depositor / account holder is permitted to make transfers or withdrawals by negotiable / transferable instruments, payment orders of withdrawal, telephone transfers, and so forth, and that may be accessible via an electronic device such as an automated teller machine (ATM), remote service unit (RSU), mobile device, and by debit card^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Excluded from transaction accounts are savings deposits (both money market deposit accounts (MMDAs) and other savings deposits), even though such deposits permit some third-party transfers. However, an account that otherwise meets the definition of a savings deposit but that authorizes or permits the depositor to exceed the transfer limitations specified for that account shall be reported as a transaction account.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TransactionDepositAccount">fibo-fbc-pas-caa:TransactionDepositAccount</a>
    /// </summary>
    let TransactionDepositAccount = _prefixId.prefix "TransactionDepositAccount"
    /// <summary>
    ///   <para>rdfs:label : transaction identifier^^xsd:string</para>
    ///   <para>skos:definition : identifier for an individual transaction associated with an account^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TransactionIdentifier">fibo-fbc-pas-caa:TransactionIdentifier</a>
    /// </summary>
    let TransactionIdentifier = _prefixId.prefix "TransactionIdentifier"
    /// <summary>
    ///   <para>rdfs:label : transaction record^^xsd:string</para>
    ///   <para>skos:definition : record of transactions associated with an account^^xsd:string</para>
    ///   <para>cmns-av:usageNote : The date a particular transaction record is closed typically corresponds to (and may precede) the date the account is closed, though in the case of certain accounts, such as a credit card account, if a customer is issued a new account or card number due to loss, fraud, or for some other reason, it is possible that multiple transaction records would be associated with the account. In that case, the close date might correspond to the date that a hold was placed on the original account.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TransactionRecord">fibo-fbc-pas-caa:TransactionRecord</a>
    /// </summary>
    let TransactionRecord = _prefixId.prefix "TransactionRecord"
    /// <summary>
    ///   <para>rdfs:label : transaction record identifier^^xsd:string</para>
    ///   <para>skos:definition : unique identifier for record of transactions^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TransactionRecordIdentifier">fibo-fbc-pas-caa:TransactionRecordIdentifier</a>
    /// </summary>
    let TransactionRecordIdentifier = _prefixId.prefix "TransactionRecordIdentifier"
    /// <summary>
    ///   <para>rdfs:label : transaction subcategory^^xsd:string</para>
    ///   <para>skos:definition : second-level classifier for a transaction, e.g., direct deposit, check, cash advance, withdrawal, payment, purchase, and so forth^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TransactionSubcategory">fibo-fbc-pas-caa:TransactionSubcategory</a>
    /// </summary>
    let TransactionSubcategory = _prefixId.prefix "TransactionSubcategory"
    /// <summary>
    ///   <para>rdfs:label : applies to account^^xsd:string</para>
    ///   <para>skos:definition : indicates the account to which the transaction record or individual transaction applies^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/appliesToAccount">fibo-fbc-pas-caa:appliesToAccount</a>
    /// </summary>
    let appliesToAccount = _prefixId.prefix "appliesToAccount"
    /// <summary>
    ///   <para>rdfs:label : has balance^^xsd:string</para>
    ///   <para>skos:definition : relates an account to the net amount of money available in that account^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasBalance">fibo-fbc-pas-caa:hasBalance</a>
    /// </summary>
    let hasBalance = _prefixId.prefix "hasBalance"
    /// <summary>
    ///   <para>rdfs:label : has close date^^xsd:string</para>
    ///   <para>skos:definition : relates something to the date that it was closed^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasCloseDate">fibo-fbc-pas-caa:hasCloseDate</a>
    /// </summary>
    let hasCloseDate = _prefixId.prefix "hasCloseDate"
    /// <summary>
    ///   <para>rdfs:label : has corresponding account^^xsd:string</para>
    ///   <para>skos:definition : relates a credit agreement to an account used as the basis for managing transactions^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasCorrespondingAccount">fibo-fbc-pas-caa:hasCorrespondingAccount</a>
    /// </summary>
    let hasCorrespondingAccount = _prefixId.prefix "hasCorrespondingAccount"
    /// <summary>
    ///   <para>rdfs:label : has ending balance^^xsd:string</para>
    ///   <para>skos:definition : relates an account statement to the amount of money available in that account at the end of the statement period^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasEndingBalance">fibo-fbc-pas-caa:hasEndingBalance</a>
    /// </summary>
    let hasEndingBalance = _prefixId.prefix "hasEndingBalance"
    /// <summary>
    ///   <para>rdfs:label : has open date^^xsd:string</para>
    ///   <para>skos:definition : relates something to the date that it was created^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasOpenDate">fibo-fbc-pas-caa:hasOpenDate</a>
    /// </summary>
    let hasOpenDate = _prefixId.prefix "hasOpenDate"
    /// <summary>
    ///   <para>rdfs:label : has payment due date^^xsd:string</para>
    ///   <para>skos:definition : indicates the date by which payment of some amount must be made to the creditor^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasPaymentDueDate">fibo-fbc-pas-caa:hasPaymentDueDate</a>
    /// </summary>
    let hasPaymentDueDate = _prefixId.prefix "hasPaymentDueDate"
    /// <summary>
    ///   <para>rdfs:label : has posting date^^xsd:string</para>
    ///   <para>skos:definition : indicates the date that the transaction was posted to the account^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasPostingDate">fibo-fbc-pas-caa:hasPostingDate</a>
    /// </summary>
    let hasPostingDate = _prefixId.prefix "hasPostingDate"
    /// <summary>
    ///   <para>rdfs:label : has primary account holder^^xsd:string</para>
    ///   <para>skos:definition : relates an account to a client or customer that is considered the primary owner of the account^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Note that for many financial institutions, there must be a client or customer designated as the primary owner. In cases where there is a tax identifier associated with the account, it is that of the primary owner.^^xsd:string</para>
    ///   <para>cmns-av:synonym : has primary account owner^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasPrimaryAccountHolder">fibo-fbc-pas-caa:hasPrimaryAccountHolder</a>
    /// </summary>
    let hasPrimaryAccountHolder = _prefixId.prefix "hasPrimaryAccountHolder"
    /// <summary>
    ///   <para>rdfs:label : has secondary account holder^^xsd:string</para>
    ///   <para>skos:definition : relates an account to a client or customer that is considered a secondary, co-owner of the account^^xsd:string</para>
    ///   <para>cmns-av:synonym : has account co-owner^^xsd:stringcmns-av:synonym : has secondary account owner^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasSecondaryAccountHolder">fibo-fbc-pas-caa:hasSecondaryAccountHolder</a>
    /// </summary>
    let hasSecondaryAccountHolder = _prefixId.prefix "hasSecondaryAccountHolder"
    /// <summary>
    ///   <para>rdfs:label : has starting balance^^xsd:string</para>
    ///   <para>skos:definition : relates an account statement to the amount of money available in that account at the beginning of the statement period^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasStartingBalance">fibo-fbc-pas-caa:hasStartingBalance</a>
    /// </summary>
    let hasStartingBalance = _prefixId.prefix "hasStartingBalance"
    /// <summary>
    ///   <para>rdfs:label : has transaction date^^xsd:string</para>
    ///   <para>skos:definition : indicates the date on which the transaction actually occurred^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasTransactionDate">fibo-fbc-pas-caa:hasTransactionDate</a>
    /// </summary>
    let hasTransactionDate = _prefixId.prefix "hasTransactionDate"
    /// <summary>
    ///   <para>rdfs:label : has transaction description^^xsd:string</para>
    ///   <para>skos:definition : provides a textual description of the transaction^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasTransactionDescription">fibo-fbc-pas-caa:hasTransactionDescription</a>
    /// </summary>
    let hasTransactionDescription = _prefixId.prefix "hasTransactionDescription"
    /// <summary>
    ///   <para>rdfs:label : has transaction record status^^xsd:string</para>
    ///   <para>skos:definition : indicates the status of the transaction record^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasTransactionRecordStatus">fibo-fbc-pas-caa:hasTransactionRecordStatus</a>
    /// </summary>
    let hasTransactionRecordStatus = _prefixId.prefix "hasTransactionRecordStatus"
    /// <summary>
    ///   <para>rdfs:label : involves merchant^^xsd:string</para>
    ///   <para>skos:definition : indicates the merchant (seller) involved in the transaction^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/involvesMerchant">fibo-fbc-pas-caa:involvesMerchant</a>
    /// </summary>
    let involvesMerchant = _prefixId.prefix "involvesMerchant"
    /// <summary>
    ///   <para>rdfs:label : is linked to account^^xsd:string</para>
    ///   <para>skos:definition : connects a given customer account to another customer account^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/isLinkedToAccount">fibo-fbc-pas-caa:isLinkedToAccount</a>
    /// </summary>
    let isLinkedToAccount = _prefixId.prefix "isLinkedToAccount"
    /// <summary>
    ///   <para>rdfs:label : records transaction^^xsd:string</para>
    ///   <para>skos:definition : links an account statement to the individual transactions it documents^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/recordsTransaction">fibo-fbc-pas-caa:recordsTransaction</a>
    /// </summary>
    let recordsTransaction = _prefixId.prefix "recordsTransaction"
