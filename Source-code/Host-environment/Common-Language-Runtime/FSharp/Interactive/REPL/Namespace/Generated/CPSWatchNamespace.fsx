#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module CPSWatch =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/CPSWatch#" "CPSWatch"
    let Closed = _prefixId.prefix "Closed"
    /// <summary>
    ///   <para>rdfs:label : ContinuousMonitoringSensor^^xsd:string</para>
    ///   <para>rdfs:comment : A CPSWatch#ContinuousMonitoringSensor is a sensor that writes data with a fixed sample rate.^^xsd:string</para>
    ///   <a href="https://w3id.org/CPSWatch#ContinuousMonitoringSensor">CPSWatch:ContinuousMonitoringSensor</a>
    /// </summary>
    let ContinuousMonitoringSensor = _prefixId.prefix "ContinuousMonitoringSensor"
    let Critical = _prefixId.prefix "Critical"
    let Error = _prefixId.prefix "Error"
    /// <summary>
    ///   <para>rdfs:label : EventMonitoringSensor^^xsd:string</para>
    ///   <para>rdfs:comment : A CPSWatch#EventMonitoringSensor is a sensor that writes data if a threshold is surpassed.^^xsd:string</para>
    ///   <a href="https://w3id.org/CPSWatch#EventMonitoringSensor">CPSWatch:EventMonitoringSensor</a>
    /// </summary>
    let EventMonitoringSensor = _prefixId.prefix "EventMonitoringSensor"
    /// <summary>
    ///   <para>rdfs:label : MonitoredSystem^^xsd:string</para>
    ///   <para>rdfs:comment : A CPSWatch#MonitoredSystem is a system that is monitored by CPSWatch#MonitoringSensor.^^xsd:string</para>
    ///   <a href="https://w3id.org/CPSWatch#MonitoredSystem">CPSWatch:MonitoredSystem</a>
    /// </summary>
    let MonitoredSystem = _prefixId.prefix "MonitoredSystem"
    /// <summary>
    ///   <para>rdfs:label : MonitoringSensor^^xsd:string</para>
    ///   <para>rdfs:comment : A CPSWatch#MonitoringSensor is a sensor used to monitor a CPSWatch#MonitoredSystem. It can be of type CPSWatch#ContinuousMonitoringSensor, CPSWatch#EventMonitoringSensor, CPSWatch#StatusMonitoringSensor.^^xsd:string</para>
    ///   <a href="https://w3id.org/CPSWatch#MonitoringSensor">CPSWatch:MonitoringSensor</a>
    /// </summary>
    let MonitoringSensor = _prefixId.prefix "MonitoringSensor"
    /// <summary>
    ///   <para>rdfs:label : NumericMonitoringSensor^^xsd:string</para>
    ///   <para>rdfs:comment : A CPSWatch#NumericMonitoringSensor is a sensor that writes numreric data.^^xsd:string</para>
    ///   <a href="https://w3id.org/CPSWatch#NumericMonitoringSensor">CPSWatch:NumericMonitoringSensor</a>
    /// </summary>
    let NumericMonitoringSensor = _prefixId.prefix "NumericMonitoringSensor"
    /// <summary>
    ///   <para>rdfs:label : NumericObservation ^^xsd:string</para>
    ///   <para>rdfs:comment : A CPSWatch#NumericObservation is an observation made by an CPSWatch#NumericMonitoringSensor.^^xsd:string</para>
    ///   <a href="https://w3id.org/CPSWatch#NumericObservation">CPSWatch:NumericObservation</a>
    /// </summary>
    let NumericObservation = _prefixId.prefix "NumericObservation"
    /// <summary>
    ///   <para>rdfs:label : Observation^^xsd:string</para>
    ///   <para>rdfs:comment : A CPSWatch#Observation is the parent class of CPSWatch#NumericObservation and CPSWatch#StatusObservation that describe the observation made by a CPSWatch#ContinuousMonitoringSensor, CPSWatch#EventMonitoringSensor, or CPSWatch#StatusMonitoringSensor.^^xsd:string</para>
    ///   <a href="https://w3id.org/CPSWatch#Observation">CPSWatch:Observation</a>
    /// </summary>
    let Observation = _prefixId.prefix "Observation"
    let Off = _prefixId.prefix "Off"
    let Ok = _prefixId.prefix "Ok"
    let On = _prefixId.prefix "On"
    let Open = _prefixId.prefix "Open"
    let ShuttingDown = _prefixId.prefix "ShuttingDown"
    let Starting = _prefixId.prefix "Starting"
    /// <summary>
    ///   <para>rdfs:label : Status^^xsd:string</para>
    ///   <para>rdfs:comment : The status values a CPSWatch#StatusMonitoringSensor can return.^^xsd:string</para>
    ///   <a href="https://w3id.org/CPSWatch#Status">CPSWatch:Status</a>
    /// </summary>
    let Status = _prefixId.prefix "Status"
    /// <summary>
    ///   <para>rdfs:label : StatusMonitoringSensor^^xsd:string</para>
    ///   <para>rdfs:comment : A CPSWatch#StatusMonitoringSensor is a sensor that can write specific states.^^xsd:string</para>
    ///   <a href="https://w3id.org/CPSWatch#StatusMonitoringSensor">CPSWatch:StatusMonitoringSensor</a>
    /// </summary>
    let StatusMonitoringSensor = _prefixId.prefix "StatusMonitoringSensor"
    /// <summary>
    ///   <para>rdfs:label : StatusObservation ^^xsd:string</para>
    ///   <para>rdfs:comment : A CPSWatch#StatusObservation is an observation made by an CPSWatch#StatusMonitoringSensor monitoring sensor.^^xsd:string</para>
    ///   <a href="https://w3id.org/CPSWatch#StatusObservation">CPSWatch:StatusObservation</a>
    /// </summary>
    let StatusObservation = _prefixId.prefix "StatusObservation"
    /// <summary>
    ///   <para>owl:cardinality : 1^^xsd:nonNegativeInteger</para>
    ///   <para>rdfs:label : hasDeviationThreshold^^xsd:string</para>
    ///   <para>rdfs:comment : Deviation threshold of a CPSWatch:EventMonitoringSensor that needs to be exceeded to save the current value.^^xsd:string</para>
    ///   <a href="https://w3id.org/CPSWatch#hasDeviationThreshold">CPSWatch:hasDeviationThreshold</a>
    /// </summary>
    let hasDeviationThreshold = _prefixId.prefix "hasDeviationThreshold"
    /// <summary>
    ///   <para>rdfs:label : hasInfluence</para>
    ///   <para>rdfs:comment : Connection between two CPSWatch:MonitoringSensor to state that the observations of these sensors are connected.</para>
    ///   <a href="https://w3id.org/CPSWatch#hasInfluence">CPSWatch:hasInfluence</a>
    /// </summary>
    let hasInfluence = _prefixId.prefix "hasInfluence"
    /// <summary>
    ///   <para>rdfs:label : hasMonitoringSensor</para>
    ///   <para>rdfs:comment : Connection from a CPSWatch:MonitoredSystem to a CPSWatch#MonitoringSensor</para>
    ///   <a href="https://w3id.org/CPSWatch#hasMonitoringSensor">CPSWatch:hasMonitoringSensor</a>
    /// </summary>
    let hasMonitoringSensor = _prefixId.prefix "hasMonitoringSensor"
    /// <summary>
    ///   <para>rdfs:label : hasNegativeCorrelation</para>
    ///   <para>rdfs:comment : Connection between two CPSWatch:MonitoringSensor to state that the observations of these sensors are with a negative correlation.</para>
    ///   <a href="https://w3id.org/CPSWatch#hasNegativeCorrelation">CPSWatch:hasNegativeCorrelation</a>
    /// </summary>
    let hasNegativeCorrelation = _prefixId.prefix "hasNegativeCorrelation"
    /// <summary>
    ///   <para>rdfs:label : hasPositiveCorrelation</para>
    ///   <para>rdfs:comment : Connection between two CPSWatch:MonitoringSensor to state that the observations of these sensors are with a positive correlation.</para>
    ///   <a href="https://w3id.org/CPSWatch#hasPositiveCorrelation">CPSWatch:hasPositiveCorrelation</a>
    /// </summary>
    let hasPositiveCorrelation = _prefixId.prefix "hasPositiveCorrelation"
    /// <summary>
    ///   <para>owl:cardinality : 1^^xsd:nonNegativeInteger</para>
    ///   <para>rdfs:label : hasSampleRate^^xsd:string</para>
    ///   <para>rdfs:comment : Update rate in seconds (s) that the data is stored.^^xsd:string</para>
    ///   <a href="https://w3id.org/CPSWatch#hasSampleRate">CPSWatch:hasSampleRate</a>
    /// </summary>
    let hasSampleRate = _prefixId.prefix "hasSampleRate"
    /// <summary>
    ///   <para>rdfs:label : hasID</para>
    ///   <para>rdfs:comment : The unique ID of a CPSWatch#MonitoringSensor.</para>
    ///   <a href="https://w3id.org/CPSWatch#hasSensorID">CPSWatch:hasSensorID</a>
    /// </summary>
    let hasSensorID = _prefixId.prefix "hasSensorID"
    /// <summary>
    ///   <para>rdfs:label : hasStates^^xsd:string</para>
    ///   <para>rdfs:comment : The possible states that a CPSWatch#StatusMonitoringSensor can have.^^xsd:string</para>
    ///   <a href="https://w3id.org/CPSWatch#hasStates">CPSWatch:hasStates</a>
    /// </summary>
    let hasStates = _prefixId.prefix "hasStates"
    /// <summary>
    ///   <para>owl:cardinality : 1^^xsd:nonNegativeInteger</para>
    ///   <para>rdfs:label : hasStatus^^xsd:string</para>
    ///   <para>rdfs:comment : The Status of the observations of a CPSWatch#StatusMonitoringSensor.^^xsd:string</para>
    ///   <a href="https://w3id.org/CPSWatch#hasStatus">CPSWatch:hasStatus</a>
    /// </summary>
    let hasStatus = _prefixId.prefix "hasStatus"
    /// <summary>
    ///   <para>rdfs:label : hasSubSystem</para>
    ///   <para>rdfs:comment : Connection between two CPSWatch:MonitoredSystem to state that a CPSWatch:MonitoredSystem has a sub system.</para>
    ///   <a href="https://w3id.org/CPSWatch#hasSubSystem">CPSWatch:hasSubSystem</a>
    /// </summary>
    let hasSubSystem = _prefixId.prefix "hasSubSystem"
    /// <summary>
    ///   <para>rdfs:label : hasSystemConnection</para>
    ///   <para>rdfs:comment : Connection between two CPSWatch:MonitoredSystem to state that system B is dependent on system A, e.g. CPSWatch:MonitoredSystem A hasSystemConnection CPSWatch:MonitoredSystem B.</para>
    ///   <a href="https://w3id.org/CPSWatch#hasSystemConnection">CPSWatch:hasSystemConnection</a>
    /// </summary>
    let hasSystemConnection = _prefixId.prefix "hasSystemConnection"
    /// <summary>
    ///   <para>rdfs:label : hasID</para>
    ///   <para>rdfs:comment : The unique ID of a CPSWatch#MonitoredSystem.</para>
    ///   <a href="https://w3id.org/CPSWatch#hasSystemID">CPSWatch:hasSystemID</a>
    /// </summary>
    let hasSystemID = _prefixId.prefix "hasSystemID"
    /// <summary>
    ///   <para>owl:cardinality : 1^^xsd:nonNegativeInteger</para>
    ///   <para>rdfs:label : hasUnit^^xsd:string</para>
    ///   <para>rdfs:comment : The unit the observations of a CPSWatch#ContinuousMonitoringSensor or CPSWatch#EventMonitoringSensor monitoring sensor are made in.^^xsd:string</para>
    ///   <a href="https://w3id.org/CPSWatch#hasUnit">CPSWatch:hasUnit</a>
    /// </summary>
    let hasUnit = _prefixId.prefix "hasUnit"
