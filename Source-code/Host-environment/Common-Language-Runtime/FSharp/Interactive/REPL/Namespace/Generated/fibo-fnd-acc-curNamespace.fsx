#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fnd-acc-cur`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/" "fibo-fnd-acc-cur"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : amount of money^^xsd:string</para>
    ///   <para>skos:definition : amount of readily available cash in banknotes and coins^^xsd:string</para>
    ///   <para>skos:editorialNote : This is an actual sum of money, not the measure of a sum of money in monetary units, although it has the same basic properties (decimal number with a currenct unit).^^xsd:string</para>
    ///   <para>cmns-av:synonym : cash^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/AmountOfMoney">fibo-fnd-acc-cur:AmountOfMoney</a>
    /// </summary>
    let AmountOfMoney = _prefixId.prefix "AmountOfMoney"
    /// <summary>
    ///   <para>rdfs:label : calculated price^^xsd:string</para>
    ///   <para>skos:definition : monetary price determined by a formula^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/CalculatedPrice">fibo-fnd-acc-cur:CalculatedPrice</a>
    /// </summary>
    let CalculatedPrice = _prefixId.prefix "CalculatedPrice"
    /// <summary>
    ///   <para>rdfs:label : currency^^xsd:string</para>
    ///   <para>skos:definition : medium of exchange value, defined by reference to the geographical location of the monetary authorities responsible for it^^xsd:string</para>
    ///   <para>fibo-fnd-utl-av:definitionOrigin : Codes for the representation of currencies and funds, ISO 4217, Eighth edition, 2015-08-01, section 3.2^^xsd:string</para>
    ///   <para>cmns-av:synonym : currency unit^^xsd:stringcmns-av:synonym : monetary unit^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/Currency">fibo-fnd-acc-cur:Currency</a>
    /// </summary>
    let Currency = _prefixId.prefix "Currency"
    /// <summary>
    ///   <para>rdfs:label : currency basket^^xsd:string</para>
    ///   <para>skos:definition : selected group of currencies, in which the weighted average is used as a measure of the value or the amount of an obligation^^xsd:string</para>
    ///   <para>skos:note : A currency basket functions as a benchmark for regional currency movements; its composition and weighting depends on its purpose.^^xsd:string</para>
    ///   <para>fibo-fnd-utl-av:definitionOrigin : Codes for the representation of currencies and funds, ISO 4217, Eighth edition, 2015-08-01, section 3.2^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/CurrencyBasket">fibo-fnd-acc-cur:CurrencyBasket</a>
    /// </summary>
    let CurrencyBasket = _prefixId.prefix "CurrencyBasket"
    /// <summary>
    ///   <para>rdfs:label : currency identifier^^xsd:string</para>
    ///   <para>skos:definition : sequence of characters representing some currency^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Codes for the representation of currencies and funds, ISO 4217, Eighth edition, 2015-08-01, section 3.2^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The first (left-most) two characters of the ISO 4217 3-letter currency identifier relate to the currency authority that issues the currency, and is, in most cases the ISO 3166-1 alpha 2 code for the geopolitical entity whose central bank is the issuer. The third (right-most) character of the identifier (alphabetic code) is an indicator derived from the name of the major currency unit or fund. If the currency is not associated with a single geographical entity as described in ISO 3166-1, typically a specially allocated identifier (alpha-2 code) is used to describe the currency authority. This code has been allocated by the Maintenance Agency from within the user-assigned range of codes XA to XZ specified in 8.1.3 of ISO 3166-1:2013. The character following X will be a mnemonic, where possible, derived from the name of the geographical area concerned.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/CurrencyIdentifier">fibo-fnd-acc-cur:CurrencyIdentifier</a>
    /// </summary>
    let CurrencyIdentifier = _prefixId.prefix "CurrencyIdentifier"
    /// <summary>
    ///   <para>rdfs:label : exchange rate^^xsd:string</para>
    ///   <para>skos:definition : rate at which one currency can be exchanged for another^^xsd:string</para>
    ///   <para>skos:example : The exchange rate between the U.S. dollar and British pound is distinct from the exchange rate between the U.S. dollar and the euro.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/ExchangeRate">fibo-fnd-acc-cur:ExchangeRate</a>
    /// </summary>
    let ExchangeRate = _prefixId.prefix "ExchangeRate"
    /// <summary>
    ///   <para>rdfs:label : funds^^xsd:string</para>
    ///   <para>skos:definition : artificial currency used as calculation basis for another currency(s) and accounting purposes^^xsd:string</para>
    ///   <para>fibo-fnd-utl-av:definitionOrigin : Codes for the representation of currencies and funds, ISO 4217, Eighth edition, 2015-08-01, section 3.3^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/Funds">fibo-fnd-acc-cur:Funds</a>
    /// </summary>
    let Funds = _prefixId.prefix "Funds"
    /// <summary>
    ///   <para>rdfs:label : funds identifier^^xsd:string</para>
    ///   <para>skos:definition : sequence of characters that can be used to uniquely identify funds^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Codes for the representation of currencies and funds, ISO 4217, Eighth edition, 2015-08-01, section 3.2^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/FundsIdentifier">fibo-fnd-acc-cur:FundsIdentifier</a>
    /// </summary>
    let FundsIdentifier = _prefixId.prefix "FundsIdentifier"
    /// <summary>
    ///   <para>rdfs:label : interest rate^^xsd:string</para>
    ///   <para>skos:definition : amount charged, expressed as a percentage of principal, in exchange for the use of assets^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Interest rates are typically noted on an annual basis, known as the annual percentage rate (APR). The assets borrowed could include cash, consumer goods, and large assets such as a vehicle or building. The rate is derived by dividing the amount of interest by the amount of principal borrowed. Interest rates are quoted on bills, notes, bonds, credit cards, and many kinds of consumer and business loans.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/InterestRate">fibo-fnd-acc-cur:InterestRate</a>
    /// </summary>
    let InterestRate = _prefixId.prefix "InterestRate"
    /// <summary>
    ///   <para>rdfs:label : monetary amount^^xsd:string</para>
    ///   <para>skos:definition : measure that is an amount of money specified in monetary units^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/MonetaryAmount">fibo-fnd-acc-cur:MonetaryAmount</a>
    /// </summary>
    let MonetaryAmount = _prefixId.prefix "MonetaryAmount"
    /// <summary>
    ///   <para>rdfs:label : monetary price^^xsd:string</para>
    ///   <para>skos:definition : price that that is expressed as a monetary amount^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : As the consideration given in exchange for transfer of ownership, price forms the essential basis of commercial transactions. It may be fixed by a contract, left to be determined by an agreed upon formula at a future date, or discovered or negotiated during the course of dealings between the parties involved. In commerce, price is determined by what (1) a buyer is willing to pay, (2) a seller is willing to accept, and (3) the competition is allowing to be charged.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/MonetaryPrice">fibo-fnd-acc-cur:MonetaryPrice</a>
    /// </summary>
    let MonetaryPrice = _prefixId.prefix "MonetaryPrice"
    /// <summary>
    ///   <para>rdfs:label : percentage monetary amount^^xsd:string</para>
    ///   <para>skos:definition : measure of some amount of money expressed as a percentage of some other amount, some notional amount or some concrete money amount^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/PercentageMonetaryAmount">fibo-fnd-acc-cur:PercentageMonetaryAmount</a>
    /// </summary>
    let PercentageMonetaryAmount = _prefixId.prefix "PercentageMonetaryAmount"
    /// <summary>
    ///   <para>rdfs:label : precious metal^^xsd:string</para>
    ///   <para>skos:definition : metal that is considered to be rare and/or have a high economic value^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/PreciousMetal">fibo-fnd-acc-cur:PreciousMetal</a>
    /// </summary>
    let PreciousMetal = _prefixId.prefix "PreciousMetal"
    /// <summary>
    ///   <para>rdfs:label : precious metal identifier^^xsd:string</para>
    ///   <para>skos:definition : sequence of characters uniquely identifying the precious metal in some context^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/PreciousMetalIdentifier">fibo-fnd-acc-cur:PreciousMetalIdentifier</a>
    /// </summary>
    let PreciousMetalIdentifier = _prefixId.prefix "PreciousMetalIdentifier"
    /// <summary>
    ///   <para>rdfs:label : price^^xsd:string</para>
    ///   <para>skos:definition : amount of money, goods, or services requested, expected, required, or given in exchange for something else^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/Price">fibo-fnd-acc-cur:Price</a>
    /// </summary>
    let Price = _prefixId.prefix "Price"
    /// <summary>
    ///   <para>rdfs:label : unit of account^^xsd:string</para>
    ///   <para>skos:definition : nominal monetary unit of measure used to represent the real value (or cost) of any economic item; i.e. goods, services, assets, liabilities, income, expenses^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/UnitOfAccount">fibo-fnd-acc-cur:UnitOfAccount</a>
    /// </summary>
    let UnitOfAccount = _prefixId.prefix "UnitOfAccount"
    /// <summary>
    ///   <para>rdfs:label : unit of account identifier^^xsd:string</para>
    ///   <para>skos:definition : sequence of characters that can be used to uniquely identify a nominal monetary unit^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/UnitOfAccountIdentifier">fibo-fnd-acc-cur:UnitOfAccountIdentifier</a>
    /// </summary>
    let UnitOfAccountIdentifier = _prefixId.prefix "UnitOfAccountIdentifier"
    /// <summary>
    ///   <para>rdfs:label : unit price^^xsd:string</para>
    ///   <para>skos:definition : monetary price expressed in relation to a well-known measurable unit by which the goods or services are allocated^^xsd:string</para>
    ///   <para>skos:example : For example, gold is commonly measured in troy ounces, grams, etc., and oil is measured in terms of barrels.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/UnitPrice">fibo-fnd-acc-cur:UnitPrice</a>
    /// </summary>
    let UnitPrice = _prefixId.prefix "UnitPrice"
    /// <summary>
    ///   <para>rdfs:label : has amount^^xsd:string</para>
    ///   <para>skos:definition : total number or quantity^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasAmount">fibo-fnd-acc-cur:hasAmount</a>
    /// </summary>
    let hasAmount = _prefixId.prefix "hasAmount"
    /// <summary>
    ///   <para>rdfs:label : has base currency^^xsd:string</para>
    ///   <para>skos:definition : specifies a unit of currency representing R units of the dealt currency, where R is the exchange rate value, in an exchange rate^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasBaseCurrency">fibo-fnd-acc-cur:hasBaseCurrency</a>
    /// </summary>
    let hasBaseCurrency = _prefixId.prefix "hasBaseCurrency"
    /// <summary>
    ///   <para>rdfs:label : has currency^^xsd:string</para>
    ///   <para>skos:definition : specifies the medium of exchange value in which something, such as a monetary amount is denominated^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasCurrency">fibo-fnd-acc-cur:hasCurrency</a>
    /// </summary>
    let hasCurrency = _prefixId.prefix "hasCurrency"
    /// <summary>
    ///   <para>rdfs:label : has dealt currency^^xsd:string</para>
    ///   <para>skos:definition : specifies a unit of currency representing the exchanged (target) currency in an exchange rate; R units of this currency represent one unit of the base currency^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasDealtCurrency">fibo-fnd-acc-cur:hasDealtCurrency</a>
    /// </summary>
    let hasDealtCurrency = _prefixId.prefix "hasDealtCurrency"
    /// <summary>
    ///   <para>rdfs:label : has funds type^^xsd:string</para>
    ///   <para>skos:definition : indicates the type of funds, such as next day for US funds^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasFundsType">fibo-fnd-acc-cur:hasFundsType</a>
    /// </summary>
    let hasFundsType = _prefixId.prefix "hasFundsType"
    /// <summary>
    ///   <para>rdfs:label : has minor unit^^xsd:string</para>
    ///   <para>skos:definition : relates a code for the minor unit of currency to the currency or fund^^xsd:string</para>
    ///   <para>skos:scopeNote : Requirements sometimes arise for values to be expressed in terms of minor units of currency. When this occurs, it is necessary to know the decimal relationship that exists between the currency concerned and its minor unit.
    /// - 0 means that there is no minor unit for the currency;
    /// - 1, 2, and 3 signify a ratio of 10 to 1, 100 to 1 and 1000 to 1 respectively.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasMinorUnit">fibo-fnd-acc-cur:hasMinorUnit</a>
    /// </summary>
    let hasMinorUnit = _prefixId.prefix "hasMinorUnit"
    /// <summary>
    ///   <para>rdfs:label : has monetary amount^^xsd:string</para>
    ///   <para>skos:definition : specifies a value for something in terms of an amount of money and the currency in which it is denoted^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasMonetaryAmount">fibo-fnd-acc-cur:hasMonetaryAmount</a>
    /// </summary>
    let hasMonetaryAmount = _prefixId.prefix "hasMonetaryAmount"
    /// <summary>
    ///   <para>rdfs:label : has notional amount^^xsd:string</para>
    ///   <para>skos:definition : has a generally unchangeable value used for certain calculations, expressed as some monetary amount^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962:2019, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, 2019-10, clause 6.8.2^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : For certain kinds of derivative instruments, including but not limited to swaps, the notional amount indicates face amount of a swap upon which the payment streams for that swap are based. While this is typically constant throughout the lifetime of a contract, it can be accreting, amortizing, or custom, such as in the case of a notional step schedule.^^xsd:stringcmns-av:explanatoryNote : The notional amount (or notional principal amount or notional value) on a financial instrument is typically the face amount used to calculate payments made on that instrument. This amount generally does not change and is thus referred to as notional.
    ///
    /// 		When applied to a swap this is the amount used for calculating the actual value of the interest due. Also known as notional value when describing derivative contracts in the options, futures, and currency markets, this term is often used to value the underlying asset in a derivatives trade. It can be the total value of a position, how much value a position controls, or an agreed-upon amount in a contract.
    ///
    /// 		An example is that a firm might have a variable rate loan on $100,000 but decide to swap only $40,000. The $40,000 is the notional amount of the swap and becomes the amount on which interest is paid.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasNotionalAmount">fibo-fnd-acc-cur:hasNotionalAmount</a>
    /// </summary>
    let hasNotionalAmount = _prefixId.prefix "hasNotionalAmount"
    /// <summary>
    ///   <para>rdfs:label : has numeric code^^xsd:string</para>
    ///   <para>skos:definition : relates a numeric code to something, such as a currency or fund^^xsd:string</para>
    ///   <para>skos:scopeNote : In the case of currency codes, the numeric currency code is derived, where possible, from the United Nations Standard Country or Area Code. Additional codes to meet special requirements (as described in 5.1.3) and in respect of funds will be allocated as necessary from within the user-assigned range of codes 950 to 998. Funds codes are allocated in descending order commencing at 998.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasNumericCode">fibo-fnd-acc-cur:hasNumericCode</a>
    /// </summary>
    let hasNumericCode = _prefixId.prefix "hasNumericCode"
    /// <summary>
    ///   <para>rdfs:label : has price^^xsd:string</para>
    ///   <para>skos:definition : indicates the value of something expressed as an amount of money or goods^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasPrice">fibo-fnd-acc-cur:hasPrice</a>
    /// </summary>
    let hasPrice = _prefixId.prefix "hasPrice"
    /// <summary>
    ///   <para>rdfs:label : has rate value^^xsd:string</para>
    ///   <para>skos:definition : has a value for a rate expressed as a number (may be a percentage or raw number)^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/hasRateValue">fibo-fnd-acc-cur:hasRateValue</a>
    /// </summary>
    let hasRateValue = _prefixId.prefix "hasRateValue"
    /// <summary>
    ///   <para>rdfs:label : is price for^^xsd:string</para>
    ///   <para>skos:definition : links a price to something it provides a value for^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/isPriceFor">fibo-fnd-acc-cur:isPriceFor</a>
    /// </summary>
    let isPriceFor = _prefixId.prefix "isPriceFor"
