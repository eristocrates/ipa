#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-der-drc-cur`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/" "fibo-der-drc-cur"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : currency derivative</para>
    ///   <para>skos:definition : agreement to deliver and settle a given amount of money in one currency, in exchange for a given amount in another currency at an agreed rate of exchange</para>
    ///   <para>cmns-av:abbreviation : FX derivative</para>
    ///   <para>cmns-av:synonym : foreign exchange derivativecmns-av:synonym : forex derivative</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencyDerivative">fibo-der-drc-cur:CurrencyDerivative</a>
    /// </summary>
    let CurrencyDerivative = _prefixId.prefix "CurrencyDerivative"
    /// <summary>
    ///   <para>rdfs:label : currency forward</para>
    ///   <para>skos:definition : agreement to deliver and settle a given amount of money in one currency, in exchange for a given amount in another currency, at an agreed date in the future and at an agreed rate of exchange</para>
    ///   <para>cmns-av:synonym : FX forwardcmns-av:synonym : foreign exchange forward</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencyForward">fibo-der-drc-cur:CurrencyForward</a>
    /// </summary>
    let CurrencyForward = _prefixId.prefix "CurrencyForward"
    /// <summary>
    ///   <para>rdfs:label : currency forward outright</para>
    ///   <para>skos:definition : forward contract in a foreign exchange market that locks in the price at which an entity must buy or sell a currency on a future date</para>
    ///   <para>cmns-av:explanatoryNote : The holders of a currency forward are obligated to buy or sell the currency at a specified price, at a specified quantity and on a specified future date. These contracts cannot be transferred. Jan 10 Review Notes Outright Forward is the term for the professional markets. Spot + Swap where Swap is 2 simultaneous transactions.</para>
    ///   <para>cmns-av:synonym : forward outrightcmns-av:synonym : outright forward currency transaction</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencyForwardOutright">fibo-der-drc-cur:CurrencyForwardOutright</a>
    /// </summary>
    let CurrencyForwardOutright = _prefixId.prefix "CurrencyForwardOutright"
    /// <summary>
    ///   <para>rdfs:label : currency option</para>
    ///   <para>skos:definition : option giving the buyer (holder) the right, but not the obligation, to buy or sell currency at a specified exchange rate during a specified period of time</para>
    ///   <para>cmns-av:abbreviation : FX option</para>
    ///   <para>cmns-av:explanatoryNote : For this right, a premium is paid to the broker, which will vary depending on the number of contracts purchased. Currency options are one of the best ways for corporations or individuals to hedge against adverse movements in exchange rates. Investors can hedge against foreign currency risk by purchasing a currency option put or call. For example, assume that an investor believes that the USD/EUR rate is going to increase from 0.80 to 0.90 (meaning that it will become more expensive for a European investor to buy U.S dollars). In this case, the investor would want to buy a call option on USD/EUR so that he or she could stand to gain from an increase in the exchange rate (or the USD rise).</para>
    ///   <para>cmns-av:synonym : foreign exchange optioncmns-av:synonym : forex option</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencyOption">fibo-der-drc-cur:CurrencyOption</a>
    /// </summary>
    let CurrencyOption = _prefixId.prefix "CurrencyOption"
    /// <summary>
    ///   <para>rdfs:label : currency spot contract</para>
    ///   <para>skos:definition : foreign-exchange contract for immediate delivery</para>
    ///   <para>cmns-av:explanatoryNote : Spot rates represent the price that a buyer expects to pay for a foreign currency in another currency at the time of the quote. Though the spot exchange rate is said to be settled immediately, the globally accepted settlement cycle for foreign-exchange contracts is two days. Foreign-exchange contracts are therefore settled on the second day after the day the deal is made.</para>
    ///   <para>cmns-av:synonym : foreign exchange spot contract</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencySpotContract">fibo-der-drc-cur:CurrencySpotContract</a>
    /// </summary>
    let CurrencySpotContract = _prefixId.prefix "CurrencySpotContract"
    /// <summary>
    ///   <para>rdfs:label : currency spot forward swap</para>
    ///   <para>skos:definition : foreign exchange agreement between two parties involving an exchange of two currencies at agreed fixed rates: a) on the spot settlement date and b) a reverse exchange on a later specified date</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fifth edition, 2021-06-15</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencySpotForwardSwap">fibo-der-drc-cur:CurrencySpotForwardSwap</a>
    /// </summary>
    let CurrencySpotForwardSwap = _prefixId.prefix "CurrencySpotForwardSwap"
    /// <summary>
    ///   <para>rdfs:label : currency swap</para>
    ///   <para>skos:definition : foreign exchange agreement between two parties to exchange a given amount of one currency for another currency for spot delivery or for forward delivery at an agreed rate after a specified period of time</para>
    ///   <para>skos:note : In the case of a 'forward-forward' swap, both legs will be of type CurrencyFoward.</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fifth edition, 2021-06-15</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencySwap">fibo-der-drc-cur:CurrencySwap</a>
    /// </summary>
    let CurrencySwap = _prefixId.prefix "CurrencySwap"
    /// <summary>
    ///   <para>rdfs:label : currency volatility option</para>
    ///   <para>skos:definition : currency option whose underlying asset is based on the volatility of a foreign exchange rate</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/CurrencyVolatilityOption">fibo-der-drc-cur:CurrencyVolatilityOption</a>
    /// </summary>
    let CurrencyVolatilityOption = _prefixId.prefix "CurrencyVolatilityOption"

    /// <summary>
    ///   <para>rdfs:label : foreign exchange master agreement</para>
    ///   <para>skos:definition : product-specific master agreement intended to reflect best market practice and to provide a standard agreement for participants in the foreign exchange markets</para>
    ///   <para>cmns-av:explanatoryNote : The Foreign Exchange Committee of the Federal Reserve Bank of New York has approved and authorized publication of the Foreign Exchange and Options Master Agreement to cover foreign exchange spot and forward transactions as well as currency options.cmns-av:explanatoryNote : The International Foreign Exchange Master Agreement (IFEMA) was published jointly by the British Bankers' Association and The Foreign Exchange Committee of the Federal Reserve Bank of New York in 1993 (an amended version was published in 1995). Foreign exchange settlement netting provisions are specified in such master agreements.</para>
    ///   <para>cmns-av:synonym : FX master agreement^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/ForeignExchangeMasterAgreement">fibo-der-drc-cur:ForeignExchangeMasterAgreement</a>
    /// </summary>
    let ForeignExchangeMasterAgreement =
        _prefixId.prefix "ForeignExchangeMasterAgreement"

    /// <summary>
    ///   <para>rdfs:label : foreign exchange settlement netting provision</para>
    ///   <para>skos:definition : settlement netting provision that is specific to foreign exchange contracts</para>
    ///   <para>cmns-av:explanatoryNote : Foreign exchange settlement netting, if between two counterparties, which is also referred to as bilateral settlement netting in this case, can take one of two forms, payment netting or novation netting. Often, one of these two methods will be found in combination with close-out netting in master agreements between trading counterparties. Close-out netting, as distinct from payment or novation netting, provides for contract liquidation procedures in the event that one of the parties defaults under a contract or become bankrupt. Payment and novation netting describe the day-to-day processes of calculating and paying net amounts.</para>
    ///   <para>cmns-av:synonym : FX settlement netting provision^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/ForeignExchangeSettlementNettingProvision">fibo-der-drc-cur:ForeignExchangeSettlementNettingProvision</a>
    /// </summary>
    let ForeignExchangeSettlementNettingProvision =
        _prefixId.prefix "ForeignExchangeSettlementNettingProvision"

    /// <summary>
    ///   <para>rdfs:label : has forward exchange rate</para>
    ///   <para>skos:definition : rate of exchange between two currencies as specified in a forward contract</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/hasForwardExchangeRate">fibo-der-drc-cur:hasForwardExchangeRate</a>
    /// </summary>
    let hasForwardExchangeRate = _prefixId.prefix "hasForwardExchangeRate"
    /// <summary>
    ///   <para>rdfs:label : has spot exchange rate</para>
    ///   <para>skos:definition : rate of exchange between two currencies as specified as of some date and time as quoted by a specific source, typically for a spot contract</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/hasSpotExchangeRate">fibo-der-drc-cur:hasSpotExchangeRate</a>
    /// </summary>
    let hasSpotExchangeRate = _prefixId.prefix "hasSpotExchangeRate"
