#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module trs =
    let _prefixId = PrefixId.fromNamespaceLabel "http://open-services.net/ns/core/trs#" "trs"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Base^^xsd:string</para>
    ///   <para>rdfs:comment : A Base identifies the initial set of resources in a Tracked Resource Set.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core/trs#Base">trs:Base</a>
    /// </summary>
    let Base = _prefixId.prefix "Base"
    /// <summary>
    ///   <para>rdfs:label : Change Log^^xsd:string</para>
    ///   <para>rdfs:comment : A Change Log describes what resources have been created, modified or deleted, and when.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core/trs#ChangeLog">trs:ChangeLog</a>
    /// </summary>
    let ChangeLog = _prefixId.prefix "ChangeLog"
    /// <summary>
    ///   <para>rdfs:label : Creation^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a resource creation or modification change event.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core/trs#Creation">trs:Creation</a>
    /// </summary>
    let Creation = _prefixId.prefix "Creation"
    /// <summary>
    ///   <para>rdfs:label : Deletion^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a resource deletion change event.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core/trs#Deletion">trs:Deletion</a>
    /// </summary>
    let Deletion = _prefixId.prefix "Deletion"
    /// <summary>
    ///   <para>rdfs:label : Modification^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a resource creation or modification change event.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core/trs#Modification">trs:Modification</a>
    /// </summary>
    let Modification = _prefixId.prefix "Modification"
    /// <summary>
    ///   <para>rdfs:label : Tracked Resource Set^^xsd:string</para>
    ///   <para>rdfs:comment : A Tracked Resource Set provides a representation of the current state of a Resource Set.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core/trs#TrackedResourceSet">trs:TrackedResourceSet</a>
    /// </summary>
    let TrackedResourceSet = _prefixId.prefix "TrackedResourceSet"
    /// <summary>
    ///   <para>rdfs:label : base^^xsd:string</para>
    ///   <para>rdfs:comment : An enumeration of the Resources in the Resource Set.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core/trs#base">trs:base</a>
    /// </summary>
    let base_ = _prefixId.prefix "base"
    /// <summary>
    ///   <para>rdfs:label : change^^xsd:string</para>
    ///   <para>rdfs:comment : The Change Event entries.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core/trs#change">trs:change</a>
    /// </summary>
    let change = _prefixId.prefix "change"
    /// <summary>
    ///   <para>rdfs:label : changeLog^^xsd:string</para>
    ///   <para>rdfs:comment : A Change Log providing an order series of incremental adjustments to the Resource Set.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core/trs#changeLog">trs:changeLog</a>
    /// </summary>
    let changeLog = _prefixId.prefix "changeLog"
    /// <summary>
    ///   <para>rdfs:label : changed^^xsd:string</para>
    ///   <para>rdfs:comment : The Resource that has changed.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core/trs#changed">trs:changed</a>
    /// </summary>
    let changed = _prefixId.prefix "changed"
    /// <summary>
    ///   <para>rdfs:label : cutoffEvent^^xsd:string</para>
    ///   <para>rdfs:comment : The most recent Change Log entry that is accounted for in this Base. When rdf:nil, the Base is an enumeration at the start of time.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core/trs#cutoffEvent">trs:cutoffEvent</a>
    /// </summary>
    let cutoffEvent = _prefixId.prefix "cutoffEvent"
    /// <summary>
    ///   <para>rdfs:label : order^^xsd:string</para>
    ///   <para>rdfs:comment : The sequence in time of the Change Event.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core/trs#order">trs:order</a>
    /// </summary>
    let order = _prefixId.prefix "order"
    /// <summary>
    ///   <para>rdfs:label : previous^^xsd:string</para>
    ///   <para>rdfs:comment : The continuation of the Change Log, containing the next group of chronologically earlier Change Events.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core/trs#previous">trs:previous</a>
    /// </summary>
    let previous = _prefixId.prefix "previous"
    /// <summary>
    ///   <para>rdfs:label : trackedResourceSet^^xsd:string</para>
    ///   <para>rdfs:comment : A Tracked Resource Set.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/core/trs#trackedResourceSet">trs:trackedResourceSet</a>
    /// </summary>
    let trackedResourceSet = _prefixId.prefix "trackedResourceSet"
