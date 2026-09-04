#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module pne =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://data.press.net/ontology/event/" "pne"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : Generic Event Class, a subclass of event:Event. The Event class also subclasses pnt:Stuff as it is a Compound domain entity, this inheritance means news assets can be tagged with Events</para>
    ///   <para>rdfs:label : Generic Event Class</para>
    ///   <a href="http://data.press.net/ontology/event/Event">pne:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    let subEventOf = _prefixId.prefix "subEventOf"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : Property for expressing an event summary. Datatype is String</para>
    ///   <para>rdfs:label : An Event summary</para>
    ///   <a href="http://data.press.net/ontology/event/summary">pne:summary</a>
    /// </summary>
    let summary = _prefixId.prefix "summary"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : Property for expressing the theme of an event, its range is pns:Intangible</para>
    ///   <para>rdfs:label : Associates an Event with an intangible theme</para>
    ///   <a href="http://data.press.net/ontology/event/theme">pne:theme</a>
    /// </summary>
    let theme = _prefixId.prefix "theme"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : Property for expressing an event title. Datatype is String</para>
    ///   <para>rdfs:label : An Event title</para>
    ///   <a href="http://data.press.net/ontology/event/title">pne:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
