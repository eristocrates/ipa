#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dady =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/NET/dady#" "dady"
    /// <summary>
    ///   <para>rdfs:label : an update source offering updates as Atom feeds^^xsd:string</para>
    ///   <a href="http://purl.org/NET/dady#AtomUpdateSource">dady:AtomUpdateSource</a>
    /// </summary>
    let AtomUpdateSource = _prefixId.prefix "AtomUpdateSource"
    /// <summary>
    ///   <para>rdfs:label : an update source offering updates as Talis' Changesets^^xsd:string</para>
    ///   <a href="http://purl.org/NET/dady#ChangeSetUpdateSource">dady:ChangeSetUpdateSource</a>
    /// </summary>
    let ChangeSetUpdateSource = _prefixId.prefix "ChangeSetUpdateSource"
    /// <summary>
    ///   <para>rdfs:label : high-frequent updates^^xsd:string</para>
    ///   <para>rdfs:comment : the dataset is updated high-frequently, i.e., once a day or more frequent^^xsd:string</para>
    ///   <a href="http://purl.org/NET/dady#HighFrequentUpdates">dady:HighFrequentUpdates</a>
    /// </summary>
    let HighFrequentUpdates = _prefixId.prefix "HighFrequentUpdates"
    /// <summary>
    ///   <para>rdfs:label : irregular updates^^xsd:string</para>
    ///   <para>rdfs:comment : the dataset is updated in irregular, non-predictable time intervals^^xsd:string</para>
    ///   <a href="http://purl.org/NET/dady#IrregularUpdates">dady:IrregularUpdates</a>
    /// </summary>
    let IrregularUpdates = _prefixId.prefix "IrregularUpdates"
    /// <summary>
    ///   <para>rdfs:label : low-frequent updates^^xsd:string</para>
    ///   <para>rdfs:comment : the dataset is updated low-frequently, i.e., once a year or less frequent^^xsd:string</para>
    ///   <a href="http://purl.org/NET/dady#LowFrequentUpdates">dady:LowFrequentUpdates</a>
    /// </summary>
    let LowFrequentUpdates = _prefixId.prefix "LowFrequentUpdates"
    /// <summary>
    ///   <para>rdfs:label : mid-frequent updates^^xsd:string</para>
    ///   <para>rdfs:comment : the dataset is updated mid-frequently, i.e., from once a week to a couple of months^^xsd:string</para>
    ///   <a href="http://purl.org/NET/dady#MidFrequentUpdates">dady:MidFrequentUpdates</a>
    /// </summary>
    let MidFrequentUpdates = _prefixId.prefix "MidFrequentUpdates"
    /// <summary>
    ///   <para>rdfs:label : no updates^^xsd:string</para>
    ///   <para>rdfs:comment : the dataset is never updated^^xsd:string</para>
    ///   <a href="http://purl.org/NET/dady#NoUpdates">dady:NoUpdates</a>
    /// </summary>
    let NoUpdates = _prefixId.prefix "NoUpdates"
    /// <summary>
    ///   <para>rdfs:label : regular updates^^xsd:string</para>
    ///   <para>rdfs:comment : the dataset is updated in regular time intervals^^xsd:string</para>
    ///   <a href="http://purl.org/NET/dady#RegularUpdates">dady:RegularUpdates</a>
    /// </summary>
    let RegularUpdates = _prefixId.prefix "RegularUpdates"
    /// <summary>
    ///   <para>rdfs:label : an update source offering updates as Triplify's Updates^^xsd:string</para>
    ///   <a href="http://purl.org/NET/dady#TriplifyUpdateSource">dady:TriplifyUpdateSource</a>
    /// </summary>
    let TriplifyUpdateSource = _prefixId.prefix "TriplifyUpdateSource"
    /// <summary>
    ///   <para>rdfs:label : dataset update dynamics^^xsd:string</para>
    ///   <a href="http://purl.org/NET/dady#UpdateDynamics">dady:UpdateDynamics</a>
    /// </summary>
    let UpdateDynamics = _prefixId.prefix "UpdateDynamics"
    /// <summary>
    ///   <para>rdfs:label : update frequency^^xsd:string</para>
    ///   <a href="http://purl.org/NET/dady#UpdateFrequency">dady:UpdateFrequency</a>
    /// </summary>
    let UpdateFrequency = _prefixId.prefix "UpdateFrequency"
    /// <summary>
    ///   <para>rdfs:label : update regularity^^xsd:string</para>
    ///   <a href="http://purl.org/NET/dady#UpdateRegularity">dady:UpdateRegularity</a>
    /// </summary>
    let UpdateRegularity = _prefixId.prefix "UpdateRegularity"
    /// <summary>
    ///   <para>rdfs:label : update source^^xsd:string</para>
    ///   <a href="http://purl.org/NET/dady#UpdateSource">dady:UpdateSource</a>
    /// </summary>
    let UpdateSource = _prefixId.prefix "UpdateSource"
    /// <summary>
    ///   <para>rdfs:label : dataset has update dynamics^^xsd:string</para>
    ///   <a href="http://purl.org/NET/dady#dynamics">dady:dynamics</a>
    /// </summary>
    let dynamics = _prefixId.prefix "dynamics"
    /// <summary>
    ///   <para>rdfs:label : has update notification^^xsd:string</para>
    ///   <a href="http://purl.org/NET/dady#notification">dady:notification</a>
    /// </summary>
    let notification = _prefixId.prefix "notification"
    /// <summary>
    ///   <para>rdfs:label : offers update source^^xsd:string</para>
    ///   <a href="http://purl.org/NET/dady#update">dady:update</a>
    /// </summary>
    let update = _prefixId.prefix "update"
