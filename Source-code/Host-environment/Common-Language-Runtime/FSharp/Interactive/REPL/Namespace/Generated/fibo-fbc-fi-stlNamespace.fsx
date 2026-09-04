#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fbc-fi-stl`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/" "fibo-fbc-fi-stl"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : cash settlement terms</para>
    ///   <para>skos:definition : contractual commitment to settle in cash^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Note that the security price represents a price per share or per lot, whereas the settlement amount represents a total.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/CashSettlementTerms">fibo-fbc-fi-stl:CashSettlementTerms</a>
    /// </summary>
    let CashSettlementTerms = _prefixId.prefix "CashSettlementTerms"
    let DeliveryInCash = _prefixId.prefix "DeliveryInCash"
    /// <summary>
    ///   <para>rdfs:label : delivery method</para>
    ///   <para>skos:definition : method and commitment to transfer a commodity, currency, security, cash or another instrument as defined in the settlement terms of the contract^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/DeliveryMethod">fibo-fbc-fi-stl:DeliveryMethod</a>
    /// </summary>
    let DeliveryMethod = _prefixId.prefix "DeliveryMethod"
    let ElectAtExerciseMethod = _prefixId.prefix "ElectAtExerciseMethod"
    let NonDeliverableMethod = _prefixId.prefix "NonDeliverableMethod"
    let PhysicalDeliveryMethod = _prefixId.prefix "PhysicalDeliveryMethod"
    /// <summary>
    ///   <para>rdfs:label : physical settlement terms</para>
    ///   <para>skos:definition : commitment to deliver the actual underlying asset on the specified delivery date, rather than cash</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, October 2019</para>
    ///   <para>cmns-av:explanatoryNote : If you sell a gold futures contract of say 100 troy ounces then you have to deliver real gold to the buyer on the mutually agreed date. Most derivatives are not actually exercised, but are traded out before their delivery date. However, physical delivery still occurs with some trades: it is most common with commodities, but can also occur with other financial instruments.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/PhysicalSettlementTerms">fibo-fbc-fi-stl:PhysicalSettlementTerms</a>
    /// </summary>
    let PhysicalSettlementTerms = _prefixId.prefix "PhysicalSettlementTerms"
    /// <summary>
    ///   <para>rdfs:label : settlement</para>
    ///   <para>skos:definition : act of finalizing a transaction, including but not limited to finalizing accounting, exchanging consideration, and/or legally recording documents, as applicable^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/Settlement">fibo-fbc-fi-stl:Settlement</a>
    /// </summary>
    let Settlement = _prefixId.prefix "Settlement"
    /// <summary>
    ///   <para>rdfs:label : settlement convention^^xsd:string</para>
    ///   <para>skos:definition : convention employed to determine the closing date (from the stated settlement date) in the process of settling a transaction on which securities or interests in securities are delivered, usually against (in simultaneous exchange for) payment of some consideration^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : This is often stated in the form 'T+n' where n is the number of business days from the specified settlement date (T).^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/SettlementConvention">fibo-fbc-fi-stl:SettlementConvention</a>
    /// </summary>
    let SettlementConvention = _prefixId.prefix "SettlementConvention"
    /// <summary>
    ///   <para>rdfs:label : settlement event</para>
    ///   <para>skos:definition : specific event involving the finalization a transaction or portion thereof, including but not limited to finalizing accounting, exchanging consideration, and/or legally recording documents, as applicable^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/SettlementEvent">fibo-fbc-fi-stl:SettlementEvent</a>
    /// </summary>
    let SettlementEvent = _prefixId.prefix "SettlementEvent"
    /// <summary>
    ///   <para>rdfs:label : has settlement method</para>
    ///   <para>skos:definition : specifies the strategy for settlement from a delivery perspective^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/hasDeliveryMethod">fibo-fbc-fi-stl:hasDeliveryMethod</a>
    /// </summary>
    let hasDeliveryMethod = _prefixId.prefix "hasDeliveryMethod"

    /// <summary>
    ///   <para>rdfs:label : has preferred settlement currency^^xsd:string</para>
    ///   <para>skos:definition : indicates the preferred currency for settlement purposes^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : This property should only be used in cases where the settlement currency is distinct from the currency in which the instrument is denominated.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/hasPreferredSettlementCurrency">fibo-fbc-fi-stl:hasPreferredSettlementCurrency</a>
    /// </summary>
    let hasPreferredSettlementCurrency =
        _prefixId.prefix "hasPreferredSettlementCurrency"

    /// <summary>
    ///   <para>rdfs:label : has settlement amount</para>
    ///   <para>skos:definition : indicates the monetary amount required for cash settlement^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/hasSettlementAmount">fibo-fbc-fi-stl:hasSettlementAmount</a>
    /// </summary>
    let hasSettlementAmount = _prefixId.prefix "hasSettlementAmount"
    /// <summary>
    ///   <para>rdfs:label : is fractional eligible^^xsd:string</para>
    ///   <para>skos:definition : indicates whether the security can contain fractional share/amounts^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/isFractionalEligible">fibo-fbc-fi-stl:isFractionalEligible</a>
    /// </summary>
    let isFractionalEligible = _prefixId.prefix "isFractionalEligible"

    /// <summary>
    ///   <para>rdfs:label : is fully automated securities transfer applicable^^xsd:string</para>
    ///   <para>skos:definition : indicates whether the security is to be held at the transfer agent as part of the FAST (Fully Automated Securities Transfer) program^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : is FAST applicable^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The Fast Automated Securities Transfer Program (FAST) is a contract between DTC (and its subsidiaries) and transfer agents whereby FAST agents act as custodians for DTC.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/isFullyAutomatedSecuritiesTransferApplicable">fibo-fbc-fi-stl:isFullyAutomatedSecuritiesTransferApplicable</a>
    /// </summary>
    let isFullyAutomatedSecuritiesTransferApplicable =
        _prefixId.prefix "isFullyAutomatedSecuritiesTransferApplicable"
