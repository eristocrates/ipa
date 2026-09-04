#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module comm =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://vocab.resc.info/communication#" "comm"

    /// <summary>
    ///   <para>rdfs:label : Classification^^xsd:string</para>
    ///   <para>rdfs:comment : The classification of the incident^^xsd:string</para>
    ///   <a href="http://vocab.resc.info/communication#Classification">comm:Classification</a>
    /// </summary>
    let Classification = _prefixId.prefix "Classification"
    /// <summary>
    ///   <para>rdfs:label : DispatchMessage^^xsd:string</para>
    ///   <para>rdfs:comment : Resources of this class describe messages sent by a dispatch to individual units^^xsd:string</para>
    ///   <a href="http://vocab.resc.info/communication#DispatchMessage">comm:DispatchMessage</a>
    /// </summary>
    let DispatchMessage = _prefixId.prefix "DispatchMessage"
    /// <summary>
    ///   <para>rdfs:label : Unit^^xsd:string</para>
    ///   <para>rdfs:comment : A Unit which can be send to a incident^^xsd:string</para>
    ///   <a href="http://vocab.resc.info/communication#Unit">comm:Unit</a>
    /// </summary>
    let Unit = _prefixId.prefix "Unit"
    let bart = _prefixId.prefix "bart"
    /// <summary>
    ///   <para>rdfs:label : Type^^xsd:string</para>
    ///   <para>rdfs:comment : The type of classification^^xsd:string</para>
    ///   <a href="http://vocab.resc.info/communication#classificationType">comm:classificationType</a>
    /// </summary>
    let classificationType = _prefixId.prefix "classificationType"
    /// <summary>
    ///   <para>rdfs:label : Dispatched to^^xsd:string</para>
    ///   <para>rdfs:comment : the adress on the P2000 pager network where the message was sent to^^xsd:string</para>
    ///   <a href="http://vocab.resc.info/communication#dispatchedTo">comm:dispatchedTo</a>
    /// </summary>
    let dispatchedTo = _prefixId.prefix "dispatchedTo"
    /// <summary>
    ///   <para>rdfs:label : Incident address^^xsd:string</para>
    ///   <para>rdfs:comment : The address where the incident was reported^^xsd:string</para>
    ///   <a href="http://vocab.resc.info/communication#incidentAddress">comm:incidentAddress</a>
    /// </summary>
    let incidentAddress = _prefixId.prefix "incidentAddress"
    /// <summary>
    ///   <para>rdfs:label : Location^^xsd:string</para>
    ///   <para>rdfs:comment : The location in geo format where incident is reported^^xsd:string</para>
    ///   <a href="http://vocab.resc.info/communication#incidentLocation">comm:incidentLocation</a>
    /// </summary>
    let incidentLocation = _prefixId.prefix "incidentLocation"
    /// <summary>
    ///   <para>rdfs:label : The message send to pagers^^xsd:string</para>
    ///   <para>rdfs:comment : This property contains the full message as send through pager networks^^xsd:string</para>
    ///   <a href="http://vocab.resc.info/communication#pagerMessage">comm:pagerMessage</a>
    /// </summary>
    let pagerMessage = _prefixId.prefix "pagerMessage"
    let rdf = _prefixId.prefix "rdf"
    let ttl = _prefixId.prefix "ttl"
    /// <summary>
    ///   <para>rdfs:label : Unit^^xsd:string</para>
    ///   <para>rdfs:comment : Unit sent to the incident^^xsd:string</para>
    ///   <a href="http://vocab.resc.info/communication#unit">comm:unit</a>
    /// </summary>
    let unit = _prefixId.prefix "unit"
