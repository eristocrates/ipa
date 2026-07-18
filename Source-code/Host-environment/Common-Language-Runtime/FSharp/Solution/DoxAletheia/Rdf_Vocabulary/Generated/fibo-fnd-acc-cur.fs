namespace https.spec.edmcouncil.org.fibo.ontology.FND.Accounting.CurrencyAmount.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_acc_cur =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/AmountOfMoney"></see>
    /// </summary>
    let AmountOfMoney =
        Namespaced_IRI.parse _namespace_name "AmountOfMoney" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasCurrency"></see>
    /// </summary>
    let hasCurrency =
        Namespaced_IRI.parse _namespace_name "hasCurrency" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/Currency"></see>
    /// </summary>
    let Currency = Namespaced_IRI.parse _namespace_name "Currency" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/CalculatedPrice"></see>
    /// </summary>
    let CalculatedPrice =
        Namespaced_IRI.parse _namespace_name "CalculatedPrice" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/MonetaryPrice"></see>
    /// </summary>
    let MonetaryPrice =
        Namespaced_IRI.parse _namespace_name "MonetaryPrice" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasMinorUnit"></see>
    /// </summary>
    let hasMinorUnit =
        Namespaced_IRI.parse _namespace_name "hasMinorUnit" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasNumericCode"></see>
    /// </summary>
    let hasNumericCode =
        Namespaced_IRI.parse _namespace_name "hasNumericCode" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/CurrencyBasket"></see>
    /// </summary>
    let CurrencyBasket =
        Namespaced_IRI.parse _namespace_name "CurrencyBasket" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/CurrencyIdentifier"></see>
    /// </summary>
    let CurrencyIdentifier =
        Namespaced_IRI.parse _namespace_name "CurrencyIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/ExchangeRate"></see>
    /// </summary>
    let ExchangeRate =
        Namespaced_IRI.parse _namespace_name "ExchangeRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasBaseCurrency"></see>
    /// </summary>
    let hasBaseCurrency =
        Namespaced_IRI.parse _namespace_name "hasBaseCurrency" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasDealtCurrency"></see>
    /// </summary>
    let hasDealtCurrency =
        Namespaced_IRI.parse _namespace_name "hasDealtCurrency" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasRateValue"></see>
    /// </summary>
    let hasRateValue =
        Namespaced_IRI.parse _namespace_name "hasRateValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/Funds"></see>
    /// </summary>
    let Funds = Namespaced_IRI.parse _namespace_name "Funds" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/FundsIdentifier"></see>
    /// </summary>
    let FundsIdentifier =
        Namespaced_IRI.parse _namespace_name "FundsIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/InterestRate"></see>
    /// </summary>
    let InterestRate =
        Namespaced_IRI.parse _namespace_name "InterestRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/PercentageMonetaryAmount"></see>
    /// </summary>
    let PercentageMonetaryAmount =
        Namespaced_IRI.parse _namespace_name "PercentageMonetaryAmount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/MonetaryAmount"></see>
    /// </summary>
    let MonetaryAmount =
        Namespaced_IRI.parse _namespace_name "MonetaryAmount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasAmount"></see>
    /// </summary>
    let hasAmount = Namespaced_IRI.parse _namespace_name "hasAmount" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/Price"></see>
    /// </summary>
    let Price = Namespaced_IRI.parse _namespace_name "Price" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/PreciousMetal"></see>
    /// </summary>
    let PreciousMetal =
        Namespaced_IRI.parse _namespace_name "PreciousMetal" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/PreciousMetalIdentifier"></see>
    /// </summary>
    let PreciousMetalIdentifier =
        Namespaced_IRI.parse _namespace_name "PreciousMetalIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/UnitOfAccount"></see>
    /// </summary>
    let UnitOfAccount =
        Namespaced_IRI.parse _namespace_name "UnitOfAccount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/UnitOfAccountIdentifier"></see>
    /// </summary>
    let UnitOfAccountIdentifier =
        Namespaced_IRI.parse _namespace_name "UnitOfAccountIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/UnitPrice"></see>
    /// </summary>
    let UnitPrice = Namespaced_IRI.parse _namespace_name "UnitPrice" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/isPriceFor"></see>
    /// </summary>
    let isPriceFor = Namespaced_IRI.parse _namespace_name "isPriceFor" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasFundsType"></see>
    /// </summary>
    let hasFundsType =
        Namespaced_IRI.parse _namespace_name "hasFundsType" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasMonetaryAmount"></see>
    /// </summary>
    let hasMonetaryAmount =
        Namespaced_IRI.parse _namespace_name "hasMonetaryAmount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasNotionalAmount"></see>
    /// </summary>
    let hasNotionalAmount =
        Namespaced_IRI.parse _namespace_name "hasNotionalAmount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasPrice"></see>
    /// </summary>
    let hasPrice = Namespaced_IRI.parse _namespace_name "hasPrice" |> NamespacedName
