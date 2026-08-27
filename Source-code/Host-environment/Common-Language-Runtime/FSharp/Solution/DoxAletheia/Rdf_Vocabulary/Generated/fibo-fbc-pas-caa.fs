namespace https.spec.edmcouncil.org.fibo.ontology.FBC.ProductsAndServices.ClientsAndAccounts.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fbc_pas_caa =
    let _namespace_iri = Namespace_Iri fibo_fbc_pas_caa |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fbc-pas-caa:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Clients and Accounts Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fbc_pas_caa, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-pas-caa:Account</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"account"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/Account">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/Account</seealso>
    let Account = Prefixed_Name(fibo_fbc_pas_caa, "Account") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:AccountAsAnAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"account as an asset"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountAsAnAsset">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountAsAnAsset</seealso>
    let AccountAsAnAsset =
        Prefixed_Name(fibo_fbc_pas_caa, "AccountAsAnAsset") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:AccountHolder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"account holder"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountHolder">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountHolder</seealso>
    let AccountHolder = Prefixed_Name(fibo_fbc_pas_caa, "AccountHolder") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:AccountIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"account identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountIdentifier</seealso>
    let AccountIdentifier =
        Prefixed_Name(fibo_fbc_pas_caa, "AccountIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:AccountOwnership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"account ownership"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountOwnership">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountOwnership</seealso>
    let AccountOwnership =
        Prefixed_Name(fibo_fbc_pas_caa, "AccountOwnership") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:AccountProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"account provider"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountProvider">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountProvider</seealso>
    let AccountProvider =
        Prefixed_Name(fibo_fbc_pas_caa, "AccountProvider") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:AccountSpecificServiceAgreement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"account-specific service agreement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountSpecificServiceAgreement">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountSpecificServiceAgreement</seealso>
    let AccountSpecificServiceAgreement =
        Prefixed_Name(fibo_fbc_pas_caa, "AccountSpecificServiceAgreement") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:AccountStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"account statement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountStatement">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountStatement</seealso>
    let AccountStatement =
        Prefixed_Name(fibo_fbc_pas_caa, "AccountStatement") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:AccountingTransaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"accounting transaction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountingTransaction">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/AccountingTransaction</seealso>
    let AccountingTransaction =
        Prefixed_Name(fibo_fbc_pas_caa, "AccountingTransaction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:Balance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"balance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/Balance">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/Balance</seealso>
    let Balance = Prefixed_Name(fibo_fbc_pas_caa, "Balance") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-pas-caa:BankAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/BankAccount">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/BankAccount</seealso>
    let BankAccount = Prefixed_Name(fibo_fbc_pas_caa, "BankAccount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:BankAccountIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bank account identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/BankAccountIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/BankAccountIdentifier</seealso>
    let BankAccountIdentifier =
        Prefixed_Name(fibo_fbc_pas_caa, "BankAccountIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:BankIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bank identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/BankIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/BankIdentifier</seealso>
    let BankIdentifier =
        Prefixed_Name(fibo_fbc_pas_caa, "BankIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:BasicBankAccountIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"basic bank account identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/BasicBankAccountIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/BasicBankAccountIdentifier</seealso>
    let BasicBankAccountIdentifier =
        Prefixed_Name(fibo_fbc_pas_caa, "BasicBankAccountIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:BrokerageAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"brokerage account"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/BrokerageAccount">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/BrokerageAccount</seealso>
    let BrokerageAccount =
        Prefixed_Name(fibo_fbc_pas_caa, "BrokerageAccount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:CertificateOfDeposit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"certificate of deposit"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/CertificateOfDeposit">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/CertificateOfDeposit</seealso>
    let CertificateOfDeposit =
        Prefixed_Name(fibo_fbc_pas_caa, "CertificateOfDeposit") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:ChartOfAccounts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chart of accounts"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/ChartOfAccounts">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/ChartOfAccounts</seealso>
    let ChartOfAccounts =
        Prefixed_Name(fibo_fbc_pas_caa, "ChartOfAccounts") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:CloseDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"close date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/CloseDate">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/CloseDate</seealso>
    let CloseDate = Prefixed_Name(fibo_fbc_pas_caa, "CloseDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:CommercialLendingService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"commercial lending service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/CommercialLendingService">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/CommercialLendingService</seealso>
    let CommercialLendingService =
        Prefixed_Name(fibo_fbc_pas_caa, "CommercialLendingService") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:CustomerAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"customer account"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/CustomerAccount">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/CustomerAccount</seealso>
    let CustomerAccount =
        Prefixed_Name(fibo_fbc_pas_caa, "CustomerAccount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:CustomerAccountHolder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"customer account holder"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/CustomerAccountHolder">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/CustomerAccountHolder</seealso>
    let CustomerAccountHolder =
        Prefixed_Name(fibo_fbc_pas_caa, "CustomerAccountHolder") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:DemandDepositAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"demand deposit account"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/DemandDepositAccount">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/DemandDepositAccount</seealso>
    let DemandDepositAccount =
        Prefixed_Name(fibo_fbc_pas_caa, "DemandDepositAccount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:DepositAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"deposit account"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/DepositAccount">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/DepositAccount</seealso>
    let DepositAccount =
        Prefixed_Name(fibo_fbc_pas_caa, "DepositAccount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:Fee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fee"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/Fee">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/Fee</seealso>
    let Fee = Prefixed_Name(fibo_fbc_pas_caa, "Fee") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-pas-caa:GeneralLedger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"general ledger"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/GeneralLedger">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/GeneralLedger</seealso>
    let GeneralLedger = Prefixed_Name(fibo_fbc_pas_caa, "GeneralLedger") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:IndividualTransaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"individual transaction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/IndividualTransaction">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/IndividualTransaction</seealso>
    let IndividualTransaction =
        Prefixed_Name(fibo_fbc_pas_caa, "IndividualTransaction") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:InternationalBankAccountIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"international bank account identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/InternationalBankAccountIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/InternationalBankAccountIdentifier</seealso>
    let InternationalBankAccountIdentifier =
        Prefixed_Name(fibo_fbc_pas_caa, "InternationalBankAccountIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:InvestmentAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"investment account"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/InvestmentAccount">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/InvestmentAccount</seealso>
    let InvestmentAccount =
        Prefixed_Name(fibo_fbc_pas_caa, "InvestmentAccount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:InvestmentOrDepositAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"investment or deposit account"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/InvestmentOrDepositAccount">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/InvestmentOrDepositAccount</seealso>
    let InvestmentOrDepositAccount =
        Prefixed_Name(fibo_fbc_pas_caa, "InvestmentOrDepositAccount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:LedgerAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ledger account"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LedgerAccount">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LedgerAccount</seealso>
    let LedgerAccount = Prefixed_Name(fibo_fbc_pas_caa, "LedgerAccount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:LedgerAccountClassificationScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>Classifiers:ClassificationScheme</para>
    ///   <para>CodesAndCodeSets:CodeSet</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ledger account classification scheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LedgerAccountClassificationScheme">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LedgerAccountClassificationScheme</seealso>
    let LedgerAccountClassificationScheme =
        Prefixed_Name(fibo_fbc_pas_caa, "LedgerAccountClassificationScheme") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:LedgerAccountClassifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ledger account classifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LedgerAccountClassifier">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LedgerAccountClassifier</seealso>
    let LedgerAccountClassifier =
        Prefixed_Name(fibo_fbc_pas_caa, "LedgerAccountClassifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:LedgerAccountClassifier-Assets</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-pas-caa:LedgerAccountClassifier</para>
    ///
    /// labels<para>"ledger account classifier - assets"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LedgerAccountClassifier-Assets">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LedgerAccountClassifier-Assets</seealso>
    let LedgerAccountClassifier_Assets =
        Prefixed_Name(fibo_fbc_pas_caa, "LedgerAccountClassifier-Assets") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:LedgerAccountClassifier-Equity</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-pas-caa:LedgerAccountClassifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ledger account classifier - equity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LedgerAccountClassifier-Equity">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LedgerAccountClassifier-Equity</seealso>
    let LedgerAccountClassifier_Equity =
        Prefixed_Name(fibo_fbc_pas_caa, "LedgerAccountClassifier-Equity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:LedgerAccountClassifier-Expenses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-pas-caa:LedgerAccountClassifier</para>
    ///
    /// labels<para>"ledger account classifier - expenses"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LedgerAccountClassifier-Expenses">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LedgerAccountClassifier-Expenses</seealso>
    let LedgerAccountClassifier_Expenses =
        Prefixed_Name(fibo_fbc_pas_caa, "LedgerAccountClassifier-Expenses") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:LedgerAccountClassifier-Liabilities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fbc-pas-caa:LedgerAccountClassifier</para>
    ///
    /// labels<para>"ledger account classifier - liabilities"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LedgerAccountClassifier-Liabilities">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LedgerAccountClassifier-Liabilities</seealso>
    let LedgerAccountClassifier_Liabilities =
        Prefixed_Name(fibo_fbc_pas_caa, "LedgerAccountClassifier-Liabilities") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:LedgerAccountClassifier-Revenue</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fbc-pas-caa:LedgerAccountClassifier</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ledger account classifier - revenue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LedgerAccountClassifier-Revenue">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LedgerAccountClassifier-Revenue</seealso>
    let LedgerAccountClassifier_Revenue =
        Prefixed_Name(fibo_fbc_pas_caa, "LedgerAccountClassifier-Revenue") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:LendingOfficer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"lending officer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LendingOfficer">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LendingOfficer</seealso>
    let LendingOfficer =
        Prefixed_Name(fibo_fbc_pas_caa, "LendingOfficer") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:LoanOrCreditAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"loan or credit account"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LoanOrCreditAccount">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/LoanOrCreditAccount</seealso>
    let LoanOrCreditAccount =
        Prefixed_Name(fibo_fbc_pas_caa, "LoanOrCreditAccount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:NonTransactionDepositAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"non-transaction deposit account"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/NonTransactionDepositAccount">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/NonTransactionDepositAccount</seealso>
    let NonTransactionDepositAccount =
        Prefixed_Name(fibo_fbc_pas_caa, "NonTransactionDepositAccount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:OpenDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"open date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/OpenDate">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/OpenDate</seealso>
    let OpenDate = Prefixed_Name(fibo_fbc_pas_caa, "OpenDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:PaymentDueDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"payment due date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/PaymentDueDate">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/PaymentDueDate</seealso>
    let PaymentDueDate =
        Prefixed_Name(fibo_fbc_pas_caa, "PaymentDueDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:PostingDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"posting date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/PostingDate">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/PostingDate</seealso>
    let PostingDate = Prefixed_Name(fibo_fbc_pas_caa, "PostingDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:RelationshipManager</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"relationship manager"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/RelationshipManager">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/RelationshipManager</seealso>
    let RelationshipManager =
        Prefixed_Name(fibo_fbc_pas_caa, "RelationshipManager") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:TimeCertificateOfDepositAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"time certificate of deposit account"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TimeCertificateOfDepositAccount">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TimeCertificateOfDepositAccount</seealso>
    let TimeCertificateOfDepositAccount =
        Prefixed_Name(fibo_fbc_pas_caa, "TimeCertificateOfDepositAccount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:TimeDepositAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"time deposit account"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TimeDepositAccount">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TimeDepositAccount</seealso>
    let TimeDepositAccount =
        Prefixed_Name(fibo_fbc_pas_caa, "TimeDepositAccount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:TimeDepositOpenAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"time deposit open account"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TimeDepositOpenAccount">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TimeDepositOpenAccount</seealso>
    let TimeDepositOpenAccount =
        Prefixed_Name(fibo_fbc_pas_caa, "TimeDepositOpenAccount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:TransactionCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"transaction category"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TransactionCategory">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TransactionCategory</seealso>
    let TransactionCategory =
        Prefixed_Name(fibo_fbc_pas_caa, "TransactionCategory") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:TransactionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"transaction date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TransactionDate">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TransactionDate</seealso>
    let TransactionDate =
        Prefixed_Name(fibo_fbc_pas_caa, "TransactionDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:TransactionDepositAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"transaction deposit account"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TransactionDepositAccount">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TransactionDepositAccount</seealso>
    let TransactionDepositAccount =
        Prefixed_Name(fibo_fbc_pas_caa, "TransactionDepositAccount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:TransactionIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"transaction identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TransactionIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TransactionIdentifier</seealso>
    let TransactionIdentifier =
        Prefixed_Name(fibo_fbc_pas_caa, "TransactionIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:TransactionRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"transaction record"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TransactionRecord">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TransactionRecord</seealso>
    let TransactionRecord =
        Prefixed_Name(fibo_fbc_pas_caa, "TransactionRecord") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:TransactionRecordIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"transaction record identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TransactionRecordIdentifier">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TransactionRecordIdentifier</seealso>
    let TransactionRecordIdentifier =
        Prefixed_Name(fibo_fbc_pas_caa, "TransactionRecordIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:TransactionSubcategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"transaction subcategory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TransactionSubcategory">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/TransactionSubcategory</seealso>
    let TransactionSubcategory =
        Prefixed_Name(fibo_fbc_pas_caa, "TransactionSubcategory") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:appliesToAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"applies to account"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/appliesToAccount">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/appliesToAccount</seealso>
    let appliesToAccount =
        Prefixed_Name(fibo_fbc_pas_caa, "appliesToAccount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:hasBalance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has balance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasBalance">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasBalance</seealso>
    let hasBalance = Prefixed_Name(fibo_fbc_pas_caa, "hasBalance") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fbc-pas-caa:hasCloseDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has close date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasCloseDate">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasCloseDate</seealso>
    let hasCloseDate = Prefixed_Name(fibo_fbc_pas_caa, "hasCloseDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:hasCorrespondingAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has corresponding account"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasCorrespondingAccount">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasCorrespondingAccount</seealso>
    let hasCorrespondingAccount =
        Prefixed_Name(fibo_fbc_pas_caa, "hasCorrespondingAccount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:hasEndingBalance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has ending balance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasEndingBalance">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasEndingBalance</seealso>
    let hasEndingBalance =
        Prefixed_Name(fibo_fbc_pas_caa, "hasEndingBalance") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:hasOpenDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has open date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasOpenDate">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasOpenDate</seealso>
    let hasOpenDate = Prefixed_Name(fibo_fbc_pas_caa, "hasOpenDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:hasPaymentDueDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has payment due date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasPaymentDueDate">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasPaymentDueDate</seealso>
    let hasPaymentDueDate =
        Prefixed_Name(fibo_fbc_pas_caa, "hasPaymentDueDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:hasPostingDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has posting date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasPostingDate">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasPostingDate</seealso>
    let hasPostingDate =
        Prefixed_Name(fibo_fbc_pas_caa, "hasPostingDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:hasPrimaryAccountHolder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"has primary account holder"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasPrimaryAccountHolder">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasPrimaryAccountHolder</seealso>
    let hasPrimaryAccountHolder =
        Prefixed_Name(fibo_fbc_pas_caa, "hasPrimaryAccountHolder") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:hasSecondaryAccountHolder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has secondary account holder"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasSecondaryAccountHolder">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasSecondaryAccountHolder</seealso>
    let hasSecondaryAccountHolder =
        Prefixed_Name(fibo_fbc_pas_caa, "hasSecondaryAccountHolder") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:hasStartingBalance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has starting balance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasStartingBalance">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasStartingBalance</seealso>
    let hasStartingBalance =
        Prefixed_Name(fibo_fbc_pas_caa, "hasStartingBalance") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:hasTransactionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has transaction date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasTransactionDate">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasTransactionDate</seealso>
    let hasTransactionDate =
        Prefixed_Name(fibo_fbc_pas_caa, "hasTransactionDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:hasTransactionDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has transaction description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasTransactionDescription">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasTransactionDescription</seealso>
    let hasTransactionDescription =
        Prefixed_Name(fibo_fbc_pas_caa, "hasTransactionDescription") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:hasTransactionRecordStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has transaction record status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasTransactionRecordStatus">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/hasTransactionRecordStatus</seealso>
    let hasTransactionRecordStatus =
        Prefixed_Name(fibo_fbc_pas_caa, "hasTransactionRecordStatus") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:involvesMerchant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"involves merchant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/involvesMerchant">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/involvesMerchant</seealso>
    let involvesMerchant =
        Prefixed_Name(fibo_fbc_pas_caa, "involvesMerchant") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:isLinkedToAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is linked to account"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/isLinkedToAccount">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/isLinkedToAccount</seealso>
    let isLinkedToAccount =
        Prefixed_Name(fibo_fbc_pas_caa, "isLinkedToAccount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fbc-pas-caa:recordsTransaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"records transaction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/recordsTransaction">https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/recordsTransaction</seealso>
    let recordsTransaction =
        Prefixed_Name(fibo_fbc_pas_caa, "recordsTransaction") |> PrefixedName
