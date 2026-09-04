#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ssso =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/ontology/ssso#" "ssso"
    /// <summary>
    ///   <para>rdfs:label : ExecutedService</para>
    ///   <a href="http://purl.org/ontology/ssso#ExecutedService">ssso:ExecutedService</a>
    /// </summary>
    let ExecutedService = _prefixId.prefix "ExecutedService"
    /// <summary>
    ///   <para>rdfs:label : ReservedService</para>
    ///   <a href="http://purl.org/ontology/ssso#PreparedService">ssso:PreparedService</a>
    /// </summary>
    let PreparedService = _prefixId.prefix "PreparedService"
    let ProvidedService = _prefixId.prefix "ProvidedService"
    /// <summary>
    ///   <para>rdfs:label : RejectedService</para>
    ///   <a href="http://purl.org/ontology/ssso#RejectedService">ssso:RejectedService</a>
    /// </summary>
    let RejectedService = _prefixId.prefix "RejectedService"
    /// <summary>
    ///   <para>rdfs:label : ReservedService</para>
    ///   <a href="http://purl.org/ontology/ssso#ReservedService">ssso:ReservedService</a>
    /// </summary>
    let ReservedService = _prefixId.prefix "ReservedService"
    /// <summary>
    ///   <para>rdfs:label : ServiceEvent</para>
    ///   <a href="http://purl.org/ontology/ssso#ServiceEvent">ssso:ServiceEvent</a>
    /// </summary>
    let ServiceEvent = _prefixId.prefix "ServiceEvent"
    /// <summary>
    ///   <para>rdfs:label : ServiceFulfillment</para>
    ///   <a href="http://purl.org/ontology/ssso#ServiceFulfillment">ssso:ServiceFulfillment</a>
    /// </summary>
    let ServiceFulfillment = _prefixId.prefix "ServiceFulfillment"
    /// <summary>
    ///   <para>rdfs:label : TimeTravel</para>
    ///   <a href="http://purl.org/ontology/ssso#TimeTravel">ssso:TimeTravel</a>
    /// </summary>
    let TimeTravel = _prefixId.prefix "TimeTravel"
    /// <summary>
    ///   <para>rdfs:label : nextService</para>
    ///   <a href="http://purl.org/ontology/ssso#nextService">ssso:nextService</a>
    /// </summary>
    let nextService = _prefixId.prefix "nextService"
    /// <summary>
    ///   <para>rdfs:label : previousService</para>
    ///   <a href="http://purl.org/ontology/ssso#previousService">ssso:previousService</a>
    /// </summary>
    let previousService = _prefixId.prefix "previousService"
