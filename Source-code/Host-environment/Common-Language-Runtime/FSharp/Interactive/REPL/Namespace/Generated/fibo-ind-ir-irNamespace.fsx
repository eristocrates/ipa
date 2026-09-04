#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-ind-ir-ir`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/" "fibo-ind-ir-ir"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : base rate^^xsd:string</para>
    ///   <para>skos:definition : basic rate of interest on which the actual rate a bank charges on loans to its customers is calculated^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : BBR^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Typically, the bank base rate is a reference rate set by a central bank. Banks that are regulated by a given central bank cannot lend below the base rate to their customers. The bank base rate is determined on an ongoing basis and represents the central bank's judgement of the price of short-term funds on their interbank market.^^xsd:string</para>
    ///   <para>cmns-av:synonym : bank base rate^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/BaseRate">fibo-ind-ir-ir:BaseRate</a>
    /// </summary>
    let BaseRate = _prefixId.prefix "BaseRate"
    let EighteenMonths = _prefixId.prefix "EighteenMonths"
    let FifteenYears = _prefixId.prefix "FifteenYears"
    let FiveYears = _prefixId.prefix "FiveYears"
    let FortyEightMonths = _prefixId.prefix "FortyEightMonths"
    let FourYears = _prefixId.prefix "FourYears"
    /// <summary>
    ///   <para>rdfs:label : interbank bid rate^^xsd:string</para>
    ///   <para>skos:definition : interbank rate that is the interest rate at which participating banks are willing to borrow deposits from other banks^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Unlike an interbank offered rate, which is the rate at which banks lend money, an interbank bid rate is the rate at which banks ask to borrow.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/InterbankBidRate">fibo-ind-ir-ir:InterbankBidRate</a>
    /// </summary>
    let InterbankBidRate = _prefixId.prefix "InterbankBidRate"
    /// <summary>
    ///   <para>rdfs:label : interbank mid rate^^xsd:string</para>
    ///   <para>skos:definition : interbank rate that represents the mid-point between bid and offer rates^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/InterbankMidRate">fibo-ind-ir-ir:InterbankMidRate</a>
    /// </summary>
    let InterbankMidRate = _prefixId.prefix "InterbankMidRate"
    /// <summary>
    ///   <para>rdfs:label : interbank offered rate^^xsd:string</para>
    ///   <para>skos:definition : interbank rate that is the interest rate at which participating banks lend money^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/InterbankOfferedRate">fibo-ind-ir-ir:InterbankOfferedRate</a>
    /// </summary>
    let InterbankOfferedRate = _prefixId.prefix "InterbankOfferedRate"
    /// <summary>
    ///   <para>rdfs:label : interbank rate^^xsd:string</para>
    ///   <para>skos:definition : reference rate that is the rate of interest charged on short-term loans between banks^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Banks borrow and lend money in the interbank market in order to manage liquidity and meet the requirements placed on them. The interest rate charged depends on the availability of money in the market, on prevailing rates and on the specific terms of the contract, such as term length.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/InterbankRate">fibo-ind-ir-ir:InterbankRate</a>
    /// </summary>
    let InterbankRate = _prefixId.prefix "InterbankRate"
    /// <summary>
    ///   <para>rdfs:label : interest rate authority^^xsd:string</para>
    ///   <para>skos:definition : financial service provider/publisher responsible for specifying some benchmark interest rate^^xsd:string</para>
    ///   <para>skos:example : This is typically a bank, central bank in the case of the publication of bank interest rates, or the committee responsible for publishing interbank rates, such as EURIBOR.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/InterestRateAuthority">fibo-ind-ir-ir:InterestRateAuthority</a>
    /// </summary>
    let InterestRateAuthority = _prefixId.prefix "InterestRateAuthority"
    /// <summary>
    ///   <para>rdfs:label : interest rate benchmark^^xsd:string</para>
    ///   <para>skos:definition : classifier for regularly updated interest rates that are publicly accessible, typically set by a central bank or group of financial institutions^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Benchmark rates, such as EURIBOR, the Fed Funds rate, and many others including those identified as FpML rates, are used as benchmarks for a variety of debt instruments.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/InterestRateBenchmark">fibo-ind-ir-ir:InterestRateBenchmark</a>
    /// </summary>
    let InterestRateBenchmark = _prefixId.prefix "InterestRateBenchmark"

    /// <summary>
    ///   <para>rdfs:label : interest rate benchmark classification scheme^^xsd:string</para>
    ///   <para>skos:definition : scheme for classifying interest rate benchmarks, such as the FpML classification scheme^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/InterestRateBenchmarkClassificationScheme">fibo-ind-ir-ir:InterestRateBenchmarkClassificationScheme</a>
    /// </summary>
    let InterestRateBenchmarkClassificationScheme =
        _prefixId.prefix "InterestRateBenchmarkClassificationScheme"

    let NineMonths = _prefixId.prefix "NineMonths"
    let OneDay = _prefixId.prefix "OneDay"
    let OneHundredEightyMonths = _prefixId.prefix "OneHundredEightyMonths"
    let OneMonth = _prefixId.prefix "OneMonth"
    let OneWeek = _prefixId.prefix "OneWeek"
    let OneYear = _prefixId.prefix "OneYear"
    /// <summary>
    ///   <para>rdfs:label : overnight rate^^xsd:string</para>
    ///   <para>skos:definition : reference rate that is an interest rate at which a depository institution lends funds to another depository institution (short-term), or the interest rate the central bank charges a financial institution to borrow money overnight^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The overnight rate is the lowest available interest rate, and as such, it is only available to the most creditworthy institutions. It is the underlying rate for Overnight Interest Rate Swaps (IOS).^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/OvernightRate">fibo-ind-ir-ir:OvernightRate</a>
    /// </summary>
    let OvernightRate = _prefixId.prefix "OvernightRate"
    /// <summary>
    ///   <para>rdfs:label : reference interest rate^^xsd:string</para>
    ///   <para>skos:definition : market rate that is a rate of interest paid by or agreed among some bank or set of banks^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The reference rate is a moving index such as EURIBOR, the prime rate or the rate on benchmark U.S. Treasuries.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/ReferenceInterestRate">fibo-ind-ir-ir:ReferenceInterestRate</a>
    /// </summary>
    let ReferenceInterestRate = _prefixId.prefix "ReferenceInterestRate"
    let SixMonths = _prefixId.prefix "SixMonths"
    let SixtyMonths = _prefixId.prefix "SixtyMonths"

    /// <summary>
    ///   <para>rdfs:label : specific-provider interest rate benchmark^^xsd:string</para>
    ///   <para>skos:definition : interest rate benchmark that is made available by a specific market data provider for reference purposes^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Benchmarks, such as those published by Bloomberg, Thomson-Reuters, and others, are usually quoted as of a specific date and time of day.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/SpecificProviderInterestRateBenchmark">fibo-ind-ir-ir:SpecificProviderInterestRateBenchmark</a>
    /// </summary>
    let SpecificProviderInterestRateBenchmark =
        _prefixId.prefix "SpecificProviderInterestRateBenchmark"

    let TenYears = _prefixId.prefix "TenYears"
    let ThirtySixMonths = _prefixId.prefix "ThirtySixMonths"
    let ThirtyYears = _prefixId.prefix "ThirtyYears"
    let ThreeHundredSixtyMonths = _prefixId.prefix "ThreeHundredSixtyMonths"
    let ThreeMonths = _prefixId.prefix "ThreeMonths"
    let ThreeYears = _prefixId.prefix "ThreeYears"
    let TwelveMonths = _prefixId.prefix "TwelveMonths"
    let TwentyFourMonths = _prefixId.prefix "TwentyFourMonths"
    let TwentyYears = _prefixId.prefix "TwentyYears"
    let TwoMonths = _prefixId.prefix "TwoMonths"
    let TwoYears = _prefixId.prefix "TwoYears"
    /// <summary>
    ///   <para>rdfs:label : has rate reset time of day^^xsd:string</para>
    ///   <para>skos:definition : indicates the time of day when a change in a benchmark rate is published, typically the same time every business day^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/hasRateResetTimeOfDay">fibo-ind-ir-ir:hasRateResetTimeOfDay</a>
    /// </summary>
    let hasRateResetTimeOfDay = _prefixId.prefix "hasRateResetTimeOfDay"
    /// <summary>
    ///   <para>rdfs:label : has reference currency^^xsd:string</para>
    ///   <para>skos:definition : relates something to the currency it is based on^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/hasReferenceCurrency">fibo-ind-ir-ir:hasReferenceCurrency</a>
    /// </summary>
    let hasReferenceCurrency = _prefixId.prefix "hasReferenceCurrency"
    /// <summary>
    ///   <para>rdfs:label : has tenor^^xsd:string</para>
    ///   <para>skos:definition : indicates the length of time for which a given rate, such as an interbank rate, exchange rate, other market rate is quoted, or a debt instrument has remaining prior to maturity or expiration^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The tenor of most financial instruments declines over time, while the maturity remains constant. Risk associated with a given asset tends to decline with the reduction of the time remaining to maturity. The tenor of an interest rate swap can also refer to the frequency with which coupon payments are exchanged.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/hasTenor">fibo-ind-ir-ir:hasTenor</a>
    /// </summary>
    let hasTenor = _prefixId.prefix "hasTenor"
