namespace https.spec.edmcouncil.org.fibo.ontology.FND.Accounting.CurrencyAmount.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_acc_cur =
    let _namespace_iri = Namespace_Iri fibo_fnd_acc_cur |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-acc-cur:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Currency Amount Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_acc_cur, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-acc-cur:AmountOfMoney</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"amount of money"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/AmountOfMoney">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/AmountOfMoney</seealso>
    let AmountOfMoney = Prefixed_Name(fibo_fnd_acc_cur, "AmountOfMoney") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-acc-cur:CalculatedPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"calculated price"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/CalculatedPrice">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/CalculatedPrice</seealso>
    let CalculatedPrice =
        Prefixed_Name(fibo_fnd_acc_cur, "CalculatedPrice") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-acc-cur:Currency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"currency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/Currency">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/Currency</seealso>
    let Currency = Prefixed_Name(fibo_fnd_acc_cur, "Currency") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-acc-cur:CurrencyBasket</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"currency basket"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/CurrencyBasket">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/CurrencyBasket</seealso>
    let CurrencyBasket =
        Prefixed_Name(fibo_fnd_acc_cur, "CurrencyBasket") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-acc-cur:CurrencyIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"currency identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/CurrencyIdentifier">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/CurrencyIdentifier</seealso>
    let CurrencyIdentifier =
        Prefixed_Name(fibo_fnd_acc_cur, "CurrencyIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-acc-cur:ExchangeRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"exchange rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/ExchangeRate">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/ExchangeRate</seealso>
    let ExchangeRate = Prefixed_Name(fibo_fnd_acc_cur, "ExchangeRate") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-acc-cur:Funds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"funds"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/Funds">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/Funds</seealso>
    let Funds = Prefixed_Name(fibo_fnd_acc_cur, "Funds") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-acc-cur:FundsIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"funds identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/FundsIdentifier">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/FundsIdentifier</seealso>
    let FundsIdentifier =
        Prefixed_Name(fibo_fnd_acc_cur, "FundsIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-acc-cur:InterestRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"interest rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/InterestRate">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/InterestRate</seealso>
    let InterestRate = Prefixed_Name(fibo_fnd_acc_cur, "InterestRate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-acc-cur:MonetaryAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"monetary amount"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/MonetaryAmount">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/MonetaryAmount</seealso>
    let MonetaryAmount =
        Prefixed_Name(fibo_fnd_acc_cur, "MonetaryAmount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-acc-cur:MonetaryPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"monetary price"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/MonetaryPrice">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/MonetaryPrice</seealso>
    let MonetaryPrice = Prefixed_Name(fibo_fnd_acc_cur, "MonetaryPrice") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-acc-cur:PercentageMonetaryAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"percentage monetary amount"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/PercentageMonetaryAmount">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/PercentageMonetaryAmount</seealso>
    let PercentageMonetaryAmount =
        Prefixed_Name(fibo_fnd_acc_cur, "PercentageMonetaryAmount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-acc-cur:PreciousMetal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"precious metal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/PreciousMetal">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/PreciousMetal</seealso>
    let PreciousMetal = Prefixed_Name(fibo_fnd_acc_cur, "PreciousMetal") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-acc-cur:PreciousMetalIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"precious metal identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/PreciousMetalIdentifier">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/PreciousMetalIdentifier</seealso>
    let PreciousMetalIdentifier =
        Prefixed_Name(fibo_fnd_acc_cur, "PreciousMetalIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-acc-cur:Price</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"price"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/Price">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/Price</seealso>
    let Price = Prefixed_Name(fibo_fnd_acc_cur, "Price") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-acc-cur:UnitOfAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"unit of account"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/UnitOfAccount">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/UnitOfAccount</seealso>
    let UnitOfAccount = Prefixed_Name(fibo_fnd_acc_cur, "UnitOfAccount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-acc-cur:UnitOfAccountIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"unit of account identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/UnitOfAccountIdentifier">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/UnitOfAccountIdentifier</seealso>
    let UnitOfAccountIdentifier =
        Prefixed_Name(fibo_fnd_acc_cur, "UnitOfAccountIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-acc-cur:UnitPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"unit price"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/UnitPrice">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/UnitPrice</seealso>
    let UnitPrice = Prefixed_Name(fibo_fnd_acc_cur, "UnitPrice") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-acc-cur:hasAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has amount"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasAmount">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasAmount</seealso>
    let hasAmount = Prefixed_Name(fibo_fnd_acc_cur, "hasAmount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-acc-cur:hasBaseCurrency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///
    /// labels<para>"has base currency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasBaseCurrency">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasBaseCurrency</seealso>
    let hasBaseCurrency =
        Prefixed_Name(fibo_fnd_acc_cur, "hasBaseCurrency") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-acc-cur:hasCurrency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has currency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasCurrency">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasCurrency</seealso>
    let hasCurrency = Prefixed_Name(fibo_fnd_acc_cur, "hasCurrency") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-acc-cur:hasDealtCurrency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has dealt currency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasDealtCurrency">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasDealtCurrency</seealso>
    let hasDealtCurrency =
        Prefixed_Name(fibo_fnd_acc_cur, "hasDealtCurrency") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-acc-cur:hasFundsType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has funds type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasFundsType">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasFundsType</seealso>
    let hasFundsType = Prefixed_Name(fibo_fnd_acc_cur, "hasFundsType") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-acc-cur:hasMinorUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has minor unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasMinorUnit">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasMinorUnit</seealso>
    let hasMinorUnit = Prefixed_Name(fibo_fnd_acc_cur, "hasMinorUnit") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-acc-cur:hasMonetaryAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has monetary amount"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasMonetaryAmount">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasMonetaryAmount</seealso>
    let hasMonetaryAmount =
        Prefixed_Name(fibo_fnd_acc_cur, "hasMonetaryAmount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-acc-cur:hasNotionalAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has notional amount"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasNotionalAmount">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasNotionalAmount</seealso>
    let hasNotionalAmount =
        Prefixed_Name(fibo_fnd_acc_cur, "hasNotionalAmount") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-acc-cur:hasNumericCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has numeric code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasNumericCode">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasNumericCode</seealso>
    let hasNumericCode =
        Prefixed_Name(fibo_fnd_acc_cur, "hasNumericCode") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-acc-cur:hasPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has price"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasPrice">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasPrice</seealso>
    let hasPrice = Prefixed_Name(fibo_fnd_acc_cur, "hasPrice") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-acc-cur:hasRateValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has rate value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasRateValue">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasRateValue</seealso>
    let hasRateValue = Prefixed_Name(fibo_fnd_acc_cur, "hasRateValue") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-acc-cur:isPriceFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is price for"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/isPriceFor">https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/isPriceFor</seealso>
    let isPriceFor = Prefixed_Name(fibo_fnd_acc_cur, "isPriceFor") |> PrefixedName
