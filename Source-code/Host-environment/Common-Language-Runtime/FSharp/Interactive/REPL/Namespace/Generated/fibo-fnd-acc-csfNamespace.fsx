#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fnd-acc-csf`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CashFlows/" "fibo-fnd-acc-csf"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : cash flow^^xsd:string</para>
    ///   <para>skos:definition : the movement of money from some source to some sink^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : From the perspective of an individual investor, the transaction date is the day when the investor's order is executed in the market. However, the process doesn't end there. The value date, on the other hand, is when the transaction actually settles, meaning when the buyer receives the securities and the seller gets the money. This lag between the transaction and value dates is known as the settlement period, which can vary depending on the type of security involved.^^xsd:stringcmns-av:explanatoryNote : One of the primary concepts in value dating is the 'value date', which is the date on which the funds from a transaction are considered available for use. This date can be influenced by various factors, including the type of transaction, the currencies involved, and the policies of the financial institutions handling the transaction. For instance, in international transactions, the value date might be delayed due to the time required for currency conversion and cross-border fund transfers.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CashFlows/CashFlow">fibo-fnd-acc-csf:CashFlow</a>
    /// </summary>
    let CashFlow = _prefixId.prefix "CashFlow"
    /// <summary>
    ///   <para>rdfs:label : cash flow structure^^xsd:string</para>
    ///   <para>skos:definition : the structure related to one or more cash flows^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Cash flow structures may involve not only cash flows, but the kind of schedule, historic payments, projected payments, a link or links to the relevant contract(s) or account(s), and possibly some triggering event.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CashFlows/CashFlowStructure">fibo-fnd-acc-csf:CashFlowStructure</a>
    /// </summary>
    let CashFlowStructure = _prefixId.prefix "CashFlowStructure"
    /// <summary>
    ///   <para>rdfs:label : triggering event</para>
    ///   <para>skos:definition : event that relates to or triggers some aspect of a credit default swap</para>
    ///   <para>cmns-av:explanatoryNote : A triggering event is typically a credit event, but could be anything that happens in the marketplace. For example, a weather-specific contract could be triggered by a hurricane - which wouldn't be considered a credit event per se.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CashFlows/TriggeringEvent">fibo-fnd-acc-csf:TriggeringEvent</a>
    /// </summary>
    let TriggeringEvent = _prefixId.prefix "TriggeringEvent"
    /// <summary>
    ///   <para>rdfs:label : has source of funds^^xsd:string</para>
    ///   <para>skos:definition : refers to the origin of some amount of money^^xsd:string</para>
    ///   <para>skos:example : Typical sources include accounts, payments, etc.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CashFlows/hasSourceOfMoney">fibo-fnd-acc-csf:hasSourceOfMoney</a>
    /// </summary>
    let hasSourceOfMoney = _prefixId.prefix "hasSourceOfMoney"
    /// <summary>
    ///   <para>rdfs:label : has target of funds^^xsd:string</para>
    ///   <para>skos:definition : refers to the sink for some amount of money^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CashFlows/hasTargetOfMoney">fibo-fnd-acc-csf:hasTargetOfMoney</a>
    /// </summary>
    let hasTargetOfMoney = _prefixId.prefix "hasTargetOfMoney"
