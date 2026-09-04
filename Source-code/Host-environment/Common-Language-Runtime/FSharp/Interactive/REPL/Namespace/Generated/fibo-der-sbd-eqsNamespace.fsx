#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-der-sbd-eqs`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/" "fibo-der-sbd-eqs"

    let _namespaceIri = _prefixId.prefix ""

    /// <summary>
    ///   <para>rdfs:label : dispersion swap index constituents leg</para>
    ///   <para>skos:definition : dispersion leg whose underlier is a defined set of constituents of a given equity index</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/DispersionSwapIndexConstituentsLeg">fibo-der-sbd-eqs:DispersionSwapIndexConstituentsLeg</a>
    /// </summary>
    let DispersionSwapIndexConstituentsLeg =
        _prefixId.prefix "DispersionSwapIndexConstituentsLeg"

    /// <summary>
    ///   <para>rdfs:label : dispersion swap index leg</para>
    ///   <para>skos:definition : dispersion leg whose underlier is an equity index</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/DispersionSwapIndexLeg">fibo-der-sbd-eqs:DispersionSwapIndexLeg</a>
    /// </summary>
    let DispersionSwapIndexLeg = _prefixId.prefix "DispersionSwapIndexLeg"
    /// <summary>
    ///   <para>rdfs:label : dividend leg</para>
    ///   <para>skos:definition : floating leg of a dividend swap</para>
    ///   <para>cmns-av:usageNote : Note that both dividend swaps and some statistical swaps can be based on a dividend stream/leg.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/DividendLeg">fibo-der-sbd-eqs:DividendLeg</a>
    /// </summary>
    let DividendLeg = _prefixId.prefix "DividendLeg"
    /// <summary>
    ///   <para>rdfs:label : dividend swap</para>
    ///   <para>skos:definition : equity swap that has at least one leg whose underlier is a dividend stream</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fifth edition, 2021-06-15</para>
    ///   <para>cmns-av:explanatoryNote : Dividend swaps include those that are fixed-term contracts between two parties where one party makes an interest rate payment for each interval and the other party pays the total dividends received as pay-out by a selected underlying asset.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/DividendSwap">fibo-der-sbd-eqs:DividendSwap</a>
    /// </summary>
    let DividendSwap = _prefixId.prefix "DividendSwap"
    /// <summary>
    ///   <para>rdfs:label : equity correlation swap</para>
    ///   <para>skos:definition : correlation swap that allows one to hedge risks associated with the observed average correlation of a collection of underlying equity products</para>
    ///   <para>cmns-av:explanatoryNote : The underlier for the leg can be any of (1) dividend stream for a single stock, (2) change in value for a single share, (3) change in value for a basket of shares, (4) change in value for an index, (5) value of a dividend stream for a basket of shares, or (6) comparison of the change in value of a given share or basket or index against something else - for example, a single share against an index, which is the thing you are cross-correlating with the volatility of the share.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/EquityCorrelationSwap">fibo-der-sbd-eqs:EquityCorrelationSwap</a>
    /// </summary>
    let EquityCorrelationSwap = _prefixId.prefix "EquityCorrelationSwap"
    /// <summary>
    ///   <para>rdfs:label : equity price return swap</para>
    ///   <para>skos:definition : return swap whose return leg underlier is based on equities</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fifth edition, 2021-06-15</para>
    ///   <para>cmns-av:explanatoryNote : A price return equity swap is similar to a total return swap, except that dividends are not passed through to the buyer).</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/EquityPriceReturnSwap">fibo-der-sbd-eqs:EquityPriceReturnSwap</a>
    /// </summary>
    let EquityPriceReturnSwap = _prefixId.prefix "EquityPriceReturnSwap"
    /// <summary>
    ///   <para>rdfs:label : equity return leg</para>
    ///   <para>skos:definition : return leg whose income is based on equities</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/EquityReturnLeg">fibo-der-sbd-eqs:EquityReturnLeg</a>
    /// </summary>
    let EquityReturnLeg = _prefixId.prefix "EquityReturnLeg"
    /// <summary>
    ///   <para>rdfs:label : equity swap</para>
    ///   <para>skos:definition : swap whose payments are linked to the change in value of underlying equities (e.g. shares, basket of equities or index) or their cashflow(s)</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fifth edition, 2021-06-15</para>
    ///   <para>cmns-av:explanatoryNote : Equity swaps can be physically or cash settled.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/EquitySwap">fibo-der-sbd-eqs:EquitySwap</a>
    /// </summary>
    let EquitySwap = _prefixId.prefix "EquitySwap"
    /// <summary>
    ///   <para>rdfs:label : equity total return swap</para>
    ///   <para>skos:definition : total return swap whose return leg underlier is based on equities</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fifth edition, 2021-06-15</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/EquityTotalReturnSwap">fibo-der-sbd-eqs:EquityTotalReturnSwap</a>
    /// </summary>
    let EquityTotalReturnSwap = _prefixId.prefix "EquityTotalReturnSwap"
    /// <summary>
    ///   <para>rdfs:label : equity variance swap</para>
    ///   <para>skos:definition : dispersion swap in which the parties agree to exchange payments based on the difference between (i) the realized variance of the price changes of a specified equity underlier over a stated observation period and (ii) a fixed amount of variance that is agreed when the contract is executed</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fifth edition, 2021-06-15</para>
    ///   <para>cmns-av:explanatoryNote : An equity variance swap is a forward swap that uses the variance (being the volatility squared) of an underlying's price movement over a period as the basis for the payoff calculation.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/EquityVarianceSwap">fibo-der-sbd-eqs:EquityVarianceSwap</a>
    /// </summary>
    let EquityVarianceSwap = _prefixId.prefix "EquityVarianceSwap"
    /// <summary>
    ///   <para>rdfs:label : equity volatility swap</para>
    ///   <para>skos:definition : dispersion swap that is a forward contract on the variability of movements in the price of its underlying equities</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fifth edition, 2021-06-15</para>
    ///   <para>cmns-av:explanatoryNote : An equity volatility swap is a measure of the amount by which an asset's price is expected to fluctuate over a given period of time; it is normally measured by the annual standard deviation of daily price changes.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/EquityVolatilitySwap">fibo-der-sbd-eqs:EquityVolatilitySwap</a>
    /// </summary>
    let EquityVolatilitySwap = _prefixId.prefix "EquityVolatilitySwap"
    /// <summary>
    ///   <para>rdfs:label : qualifying dividend period</para>
    ///   <para>skos:definition : date period over which the sum of all qualifying dividends paid by the relevant issuers as identified in the swap terms is calculated</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/QualifyingDividendPeriod">fibo-der-sbd-eqs:QualifyingDividendPeriod</a>
    /// </summary>
    let QualifyingDividendPeriod = _prefixId.prefix "QualifyingDividendPeriod"
    /// <summary>
    ///   <para>rdfs:label : special dividend leg terms</para>
    ///   <para>skos:definition : terms that are invoked if special dividend and memorial dividends are applicable</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/SpecialDividendLegTerms">fibo-der-sbd-eqs:SpecialDividendLegTerms</a>
    /// </summary>
    let SpecialDividendLegTerms = _prefixId.prefix "SpecialDividendLegTerms"
