#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module xbrll =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/vocab/xbrll#" "xbrll"
    /// <summary>
    ///   <para>rdfs:label : Context</para>
    ///   <para>rdfs:comment : the context of a fact in a financial report</para>
    ///   <a href="https://w3id.org/vocab/xbrll#Context">xbrll:Context</a>
    /// </summary>
    let Context = _prefixId.prefix "Context"
    /// <summary>
    ///   <para>rdfs:label : data point</para>
    ///   <para>rdfs:comment : this define a fact in the report. A data point should have at least one context</para>
    ///   <a href="https://w3id.org/vocab/xbrll#DataPoint">xbrll:DataPoint</a>
    /// </summary>
    let DataPoint = _prefixId.prefix "DataPoint"
    /// <summary>
    ///   <para>rdfs:label : Dimension</para>
    ///   <para>rdfs:comment : The dimension defining whether the dimensions in the axis are explicit member or implicit ones</para>
    ///   <a href="https://w3id.org/vocab/xbrll#Dimension">xbrll:Dimension</a>
    /// </summary>
    let Dimension = _prefixId.prefix "Dimension"
    /// <summary>
    ///   <para>rdfs:label : Financial entity</para>
    ///   <a href="https://w3id.org/vocab/xbrll#FinancialEntity">xbrll:FinancialEntity</a>
    /// </summary>
    let FinancialEntity = _prefixId.prefix "FinancialEntity"
    /// <summary>
    ///   <para>rdfs:label : Financial reportrdfs:label : informe financiero</para>
    ///   <para>rdfs:comment : A financial report may content many data points that are facts</para>
    ///   <a href="https://w3id.org/vocab/xbrll#FinancialReport">xbrll:FinancialReport</a>
    /// </summary>
    let FinancialReport = _prefixId.prefix "FinancialReport"
    /// <summary>
    ///   <para>rdfs:label : Period</para>
    ///   <a href="https://w3id.org/vocab/xbrll#Period">xbrll:Period</a>
    /// </summary>
    let Period = _prefixId.prefix "Period"
    /// <summary>
    ///   <para>rdfs:label : Contact person</para>
    ///   <para>rdfs:comment : The person of contact in the metadata info of a company</para>
    ///   <a href="https://w3id.org/vocab/xbrll#contactPerson">xbrll:contactPerson</a>
    /// </summary>
    let contactPerson = _prefixId.prefix "contactPerson"
    /// <summary>
    ///   <para>rdfs:label : Context property</para>
    ///   <para>rdfs:comment : Context property from a data point</para>
    ///   <a href="https://w3id.org/vocab/xbrll#context">xbrll:context</a>
    /// </summary>
    let context = _prefixId.prefix "context"
    /// <summary>
    ///   <para>rdfs:label : Data point property</para>
    ///   <para>rdfs:comment : Data point property from a financial report</para>
    ///   <a href="https://w3id.org/vocab/xbrll#dataPoint">xbrll:dataPoint</a>
    /// </summary>
    let dataPoint = _prefixId.prefix "dataPoint"
    /// <summary>
    ///   <para>rdfs:label : Decimals</para>
    ///   <para>rdfs:comment : Number of decimals used for a currency</para>
    ///   <a href="https://w3id.org/vocab/xbrll#decimals">xbrll:decimals</a>
    /// </summary>
    let decimals = _prefixId.prefix "decimals"
    /// <summary>
    ///   <para>rdfs:label : End date</para>
    ///   <para>rdfs:comment : End date of a period</para>
    ///   <a href="https://w3id.org/vocab/xbrll#endDate">xbrll:endDate</a>
    /// </summary>
    let endDate = _prefixId.prefix "endDate"
    /// <summary>
    ///   <para>rdfs:label : Fiscal year</para>
    ///   <para>rdfs:comment : End of fiscal year</para>
    ///   <a href="https://w3id.org/vocab/xbrll#fiscalYear">xbrll:fiscalYear</a>
    /// </summary>
    let fiscalYear = _prefixId.prefix "fiscalYear"
    /// <summary>
    ///   <para>rdfs:label : Has dimension</para>
    ///   <a href="https://w3id.org/vocab/xbrll#hasDimension">xbrll:hasDimension</a>
    /// </summary>
    let hasDimension = _prefixId.prefix "hasDimension"
    /// <summary>
    ///   <para>rdfs:label : Is forever</para>
    ///   <para>rdfs:comment : Boolean telling the period is forever or not</para>
    ///   <a href="https://w3id.org/vocab/xbrll#isForever">xbrll:isForever</a>
    /// </summary>
    let isForever = _prefixId.prefix "isForever"
    /// <summary>
    ///   <para>rdfs:label : Is instant</para>
    ///   <para>rdfs:comment : boolean for the instant moment</para>
    ///   <a href="https://w3id.org/vocab/xbrll#isInstant">xbrll:isInstant</a>
    /// </summary>
    let isInstant = _prefixId.prefix "isInstant"
    /// <summary>
    ///   <para>rdfs:label : Period</para>
    ///   <a href="https://w3id.org/vocab/xbrll#period">xbrll:period</a>
    /// </summary>
    let period = _prefixId.prefix "period"
    /// <summary>
    ///   <para>rdfs:label : Report year</para>
    ///   <para>rdfs:comment : year of the report</para>
    ///   <a href="https://w3id.org/vocab/xbrll#reportYear">xbrll:reportYear</a>
    /// </summary>
    let reportYear = _prefixId.prefix "reportYear"
    /// <summary>
    ///   <para>rdfs:label : Start date</para>
    ///   <para>rdfs:comment : Starting date of a period</para>
    ///   <a href="https://w3id.org/vocab/xbrll#startDate">xbrll:startDate</a>
    /// </summary>
    let startDate = _prefixId.prefix "startDate"
