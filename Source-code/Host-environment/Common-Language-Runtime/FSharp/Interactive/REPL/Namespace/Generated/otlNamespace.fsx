#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module otl =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://w3id.org/opentrafficlights#" "otl"

    /// <summary>
    ///   <para>rdfs:comment : Describes a departure at a certain lane and an arrival at a different lane</para>
    ///   <para>rdfs:label : Connection</para>
    ///   <a href="https://w3id.org/opentrafficlights#Connection">otl:Connection</a>
    /// </summary>
    let Connection = _prefixId.prefix "Connection"
    /// <summary>
    ///   <para>rdfs:comment : Describes a part of the road where a passenger departs or arrives from.</para>
    ///   <para>rdfs:label : Lane</para>
    ///   <a href="https://w3id.org/opentrafficlights#Lane">otl:Lane</a>
    /// </summary>
    let Lane = _prefixId.prefix "Lane"
    let Ontology = _prefixId.prefix "Ontology"
    /// <summary>
    ///   <para>rdfs:comment : Describes a group of traffic lights that have the same Signal state.</para>
    ///   <para>rdfs:label : Signal group</para>
    ///   <a href="https://w3id.org/opentrafficlights#SignalGroup">otl:SignalGroup</a>
    /// </summary>
    let SignalGroup = _prefixId.prefix "SignalGroup"
    /// <summary>
    ///   <para>rdfs:comment : Describes the state of a Signal group.</para>
    ///   <para>rdfs:label : Signal state</para>
    ///   <a href="https://w3id.org/opentrafficlights#SignalState">otl:SignalState</a>
    /// </summary>
    let SignalState = _prefixId.prefix "SignalState"
    /// <summary>
    ///   <para>rdfs:comment : A road user will arrive here</para>
    ///   <para>rdfs:label : Arrival lane</para>
    ///   <a href="https://w3id.org/opentrafficlights#arrivalLane">otl:arrivalLane</a>
    /// </summary>
    let arrivalLane = _prefixId.prefix "arrivalLane"
    /// <summary>
    ///   <para>rdfs:comment : A road user will depart from here</para>
    ///   <para>rdfs:label : Departure lane</para>
    ///   <a href="https://w3id.org/opentrafficlights#departureLane">otl:departureLane</a>
    /// </summary>
    let departureLane = _prefixId.prefix "departureLane"
    /// <summary>
    ///   <para>rdfs:comment : The latest time possible at which the event state could change, except when unpredictable events relating to a pre-emption or priority call disrupt a currently active timing plan.</para>
    ///   <para>rdfs:label : Maximum end time</para>
    ///   <a href="https://w3id.org/opentrafficlights#maxEndTime">otl:maxEndTime</a>
    /// </summary>
    let maxEndTime = _prefixId.prefix "maxEndTime"
    /// <summary>
    ///   <para>rdfs:comment : The earliest time possible at which the event state could change, except when unpredictable events relating to a pre-emption or priority call disrupt a currently active timing plan.</para>
    ///   <para>rdfs:label : Minimum end time</para>
    ///   <a href="https://w3id.org/opentrafficlights#minEndTime">otl:minEndTime</a>
    /// </summary>
    let minEndTime = _prefixId.prefix "minEndTime"
    /// <summary>
    ///   <para>rdfs:comment : Represents green, red etc. Adviced to use concept scheme https://w3id.org/opentrafficlights/thesauri/signalphase</para>
    ///   <para>rdfs:label : Phase of a Signal state</para>
    ///   <a href="https://w3id.org/opentrafficlights#signalPhase">otl:signalPhase</a>
    /// </summary>
    let signalPhase = _prefixId.prefix "signalPhase"
    /// <summary>
    ///   <para>rdfs:comment : Signal state of a signal group.</para>
    ///   <para>rdfs:label : Signal state</para>
    ///   <a href="https://w3id.org/opentrafficlights#signalState">otl:signalState</a>
    /// </summary>
    let signalState = _prefixId.prefix "signalState"
    /// <summary>
    ///   <para>rdfs:comment : The width of a lane expressed in centimeters.</para>
    ///   <para>rdfs:label : Width</para>
    ///   <a href="https://w3id.org/opentrafficlights#width">otl:width</a>
    /// </summary>
    let width = _prefixId.prefix "width"
