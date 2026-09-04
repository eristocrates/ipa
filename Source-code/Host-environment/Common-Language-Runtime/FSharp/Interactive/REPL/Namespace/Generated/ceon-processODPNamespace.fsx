#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``ceon-processODP`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://w3id.org/CEON/ontology/processODP/" "ceon-processODP"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Event^^xsd:string</para>
    ///   <para>rdfs:comment : Something that happens within a given context or (short) timeframe.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/processODP/Event">ceon-processODP:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>rdfs:label : Process^^xsd:string</para>
    ///   <para>rdfs:comment : Something that takes place over a (longer) period of time and changes some state of affairs.</para>
    ///   <a href="http://w3id.org/CEON/ontology/processODP/Process">ceon-processODP:Process</a>
    /// </summary>
    let Process = _prefixId.prefix "Process"
    /// <summary>
    ///   <para>rdfs:label : Situation^^xsd:string</para>
    ///   <para>rdfs:comment : A situation that may involve some resources and actors, i.e. a state of affairs at a certain point in time.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/processODP/Situation">ceon-processODP:Situation</a>
    /// </summary>
    let Situation = _prefixId.prefix "Situation"
    /// <summary>
    ///   <para>rdfs:label : Time Interval^^xsd:string</para>
    ///   <para>rdfs:comment : A temporal entity has a starting time and an ending time.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/processODP/TimeInterval">ceon-processODP:TimeInterval</a>
    /// </summary>
    let TimeInterval = _prefixId.prefix "TimeInterval"
    /// <summary>
    ///   <para>rdfs:label : during time^^xsd:string</para>
    ///   <para>rdfs:comment : The time interval during which something, e.g. a process or event, takes place.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/processODP/duringTime">ceon-processODP:duringTime</a>
    /// </summary>
    let duringTime = _prefixId.prefix "duringTime"
    /// <summary>
    ///   <para>rdfs:label : end time^^xsd:string</para>
    ///   <para>rdfs:comment : Represents the end time of a time interval.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/processODP/endTime">ceon-processODP:endTime</a>
    /// </summary>
    let endTime = _prefixId.prefix "endTime"
    /// <summary>
    ///   <para>rdfs:label : has input^^xsd:string</para>
    ///   <para>rdfs:comment : The inputs to a process or event.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/processODP/hasInput">ceon-processODP:hasInput</a>
    /// </summary>
    let hasInput = _prefixId.prefix "hasInput"
    /// <summary>
    ///   <para>rdfs:label : has output^^xsd:string</para>
    ///   <para>rdfs:comment : The output of a process or event.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/processODP/hasOutput">ceon-processODP:hasOutput</a>
    /// </summary>
    let hasOutput = _prefixId.prefix "hasOutput"
    /// <summary>
    ///   <para>rdfs:label : has part^^xsd:string</para>
    ///   <para>rdfs:comment : A process or event can consist of several parts, which are sub-processes (e.g. steps) or events.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/processODP/hasPart">ceon-processODP:hasPart</a>
    /// </summary>
    let hasPart = _prefixId.prefix "hasPart"
    /// <summary>
    ///   <para>rdfs:label : is the setting for^^xsd:string</para>
    ///   <para>rdfs:comment : The thing(s) that this situation is the setting for, e.g. a resource that is in a certain state.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/processODP/isSettingFor">ceon-processODP:isSettingFor</a>
    /// </summary>
    let isSettingFor = _prefixId.prefix "isSettingFor"
    /// <summary>
    ///   <para>rdfs:label : occurs at location^^xsd:string</para>
    ///   <para>rdfs:comment : The location in which something (e.g. an event or process) takes place, e.g. the factory location where something is manufactured.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/processODP/occursAtLocation">ceon-processODP:occursAtLocation</a>
    /// </summary>
    let occursAtLocation = _prefixId.prefix "occursAtLocation"
    /// <summary>
    ///   <para>rdfs:label : start time^^xsd:string</para>
    ///   <para>rdfs:comment : Represents the start time of a time interval.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/processODP/startTime">ceon-processODP:startTime</a>
    /// </summary>
    let startTime = _prefixId.prefix "startTime"
