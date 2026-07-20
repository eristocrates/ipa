namespace https.spec.edmcouncil.org.fibo.ontology.FND.Accounting.CurrencyAmount.slash

open DoxAletheia

module fibo_fnd_acc_cur =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/AmountOfMoney"></see>
    /// </summary>
    let AmountOfMoney = _prefix "AmountOfMoney"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasCurrency"></see>
    /// </summary>
    let hasCurrency = _prefix "hasCurrency"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/Currency"></see>
    /// </summary>
    let Currency = _prefix "Currency"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/CalculatedPrice"></see>
    /// </summary>
    let CalculatedPrice = _prefix "CalculatedPrice"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/MonetaryPrice"></see>
    /// </summary>
    let MonetaryPrice = _prefix "MonetaryPrice"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasMinorUnit"></see>
    /// </summary>
    let hasMinorUnit = _prefix "hasMinorUnit"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasNumericCode"></see>
    /// </summary>
    let hasNumericCode = _prefix "hasNumericCode"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/CurrencyBasket"></see>
    /// </summary>
    let CurrencyBasket = _prefix "CurrencyBasket"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/CurrencyIdentifier"></see>
    /// </summary>
    let CurrencyIdentifier = _prefix "CurrencyIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/ExchangeRate"></see>
    /// </summary>
    let ExchangeRate = _prefix "ExchangeRate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasBaseCurrency"></see>
    /// </summary>
    let hasBaseCurrency = _prefix "hasBaseCurrency"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasDealtCurrency"></see>
    /// </summary>
    let hasDealtCurrency = _prefix "hasDealtCurrency"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasRateValue"></see>
    /// </summary>
    let hasRateValue = _prefix "hasRateValue"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/Funds"></see>
    /// </summary>
    let Funds = _prefix "Funds"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/FundsIdentifier"></see>
    /// </summary>
    let FundsIdentifier = _prefix "FundsIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/InterestRate"></see>
    /// </summary>
    let InterestRate = _prefix "InterestRate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/PercentageMonetaryAmount"></see>
    /// </summary>
    let PercentageMonetaryAmount = _prefix "PercentageMonetaryAmount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/MonetaryAmount"></see>
    /// </summary>
    let MonetaryAmount = _prefix "MonetaryAmount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasAmount"></see>
    /// </summary>
    let hasAmount = _prefix "hasAmount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/Price"></see>
    /// </summary>
    let Price = _prefix "Price"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/PreciousMetal"></see>
    /// </summary>
    let PreciousMetal = _prefix "PreciousMetal"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/PreciousMetalIdentifier"></see>
    /// </summary>
    let PreciousMetalIdentifier = _prefix "PreciousMetalIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/UnitOfAccount"></see>
    /// </summary>
    let UnitOfAccount = _prefix "UnitOfAccount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/UnitOfAccountIdentifier"></see>
    /// </summary>
    let UnitOfAccountIdentifier = _prefix "UnitOfAccountIdentifier"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/UnitPrice"></see>
    /// </summary>
    let UnitPrice = _prefix "UnitPrice"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/isPriceFor"></see>
    /// </summary>
    let isPriceFor = _prefix "isPriceFor"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasFundsType"></see>
    /// </summary>
    let hasFundsType = _prefix "hasFundsType"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasMonetaryAmount"></see>
    /// </summary>
    let hasMonetaryAmount = _prefix "hasMonetaryAmount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasNotionalAmount"></see>
    /// </summary>
    let hasNotionalAmount = _prefix "hasNotionalAmount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasPrice"></see>
    /// </summary>
    let hasPrice = _prefix "hasPrice"
