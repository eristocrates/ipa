namespace https.w3id.org.CPSWatch.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module CPSWatch =
    let _namespace_iri = Namespace_Iri CPSWatch |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:CPSWatch#Closed</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:CPSWatch#Status</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/CPSWatch#Closed">https://w3id.org/CPSWatch#Closed</seealso>
    let Closed = Prefixed_Name(CPSWatch, "Closed") |> PrefixedName

    /// <summary>
    ///   <para>w3id:CPSWatch#ContinuousMonitoringSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A CPSWatch#ContinuousMonitoringSensor is a sensor that writes data with a fixed sample rate."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ContinuousMonitoringSensor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/CPSWatch#ContinuousMonitoringSensor">https://w3id.org/CPSWatch#ContinuousMonitoringSensor</seealso>
    let ContinuousMonitoringSensor =
        Prefixed_Name(CPSWatch, "ContinuousMonitoringSensor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:CPSWatch#Critical</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:CPSWatch#Status</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/CPSWatch#Critical">https://w3id.org/CPSWatch#Critical</seealso>
    let Critical = Prefixed_Name(CPSWatch, "Critical") |> PrefixedName
    /// <summary>
    ///   <para>w3id:CPSWatch#Error</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:CPSWatch#Status</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/CPSWatch#Error">https://w3id.org/CPSWatch#Error</seealso>
    let Error = Prefixed_Name(CPSWatch, "Error") |> PrefixedName

    /// <summary>
    ///   <para>w3id:CPSWatch#EventMonitoringSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A CPSWatch#EventMonitoringSensor is a sensor that writes data if a threshold is surpassed."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"EventMonitoringSensor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/CPSWatch#EventMonitoringSensor">https://w3id.org/CPSWatch#EventMonitoringSensor</seealso>
    let EventMonitoringSensor =
        Prefixed_Name(CPSWatch, "EventMonitoringSensor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:CPSWatch#MonitoredSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A CPSWatch#MonitoredSystem is a system that is monitored by CPSWatch#MonitoringSensor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MonitoredSystem"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/CPSWatch#MonitoredSystem">https://w3id.org/CPSWatch#MonitoredSystem</seealso>
    let MonitoredSystem = Prefixed_Name(CPSWatch, "MonitoredSystem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:CPSWatch#MonitoringSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A CPSWatch#MonitoringSensor is a sensor used to monitor a CPSWatch#MonitoredSystem. It can be of type CPSWatch#ContinuousMonitoringSensor, CPSWatch#EventMonitoringSensor, CPSWatch#StatusMonitoringSensor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MonitoringSensor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/CPSWatch#MonitoringSensor">https://w3id.org/CPSWatch#MonitoringSensor</seealso>
    let MonitoringSensor = Prefixed_Name(CPSWatch, "MonitoringSensor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:CPSWatch#NumericMonitoringSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A CPSWatch#NumericMonitoringSensor is a sensor that writes numreric data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NumericMonitoringSensor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/CPSWatch#NumericMonitoringSensor">https://w3id.org/CPSWatch#NumericMonitoringSensor</seealso>
    let NumericMonitoringSensor =
        Prefixed_Name(CPSWatch, "NumericMonitoringSensor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:CPSWatch#NumericObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A CPSWatch#NumericObservation is an observation made by an CPSWatch#NumericMonitoringSensor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NumericObservation "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/CPSWatch#NumericObservation">https://w3id.org/CPSWatch#NumericObservation</seealso>
    let NumericObservation =
        Prefixed_Name(CPSWatch, "NumericObservation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:CPSWatch#Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A CPSWatch#Observation is the parent class of CPSWatch#NumericObservation and CPSWatch#StatusObservation that describe the observation made by a CPSWatch#ContinuousMonitoringSensor, CPSWatch#EventMonitoringSensor, or CPSWatch#StatusMonitoringSensor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Observation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/CPSWatch#Observation">https://w3id.org/CPSWatch#Observation</seealso>
    let Observation = Prefixed_Name(CPSWatch, "Observation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:CPSWatch#Off</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:CPSWatch#Status</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/CPSWatch#Off">https://w3id.org/CPSWatch#Off</seealso>
    let Off = Prefixed_Name(CPSWatch, "Off") |> PrefixedName
    /// <summary>
    ///   <para>w3id:CPSWatch#Ok</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:CPSWatch#Status</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/CPSWatch#Ok">https://w3id.org/CPSWatch#Ok</seealso>
    let Ok = Prefixed_Name(CPSWatch, "Ok") |> PrefixedName
    /// <summary>
    ///   <para>w3id:CPSWatch#On</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:CPSWatch#Status</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/CPSWatch#On">https://w3id.org/CPSWatch#On</seealso>
    let On = Prefixed_Name(CPSWatch, "On") |> PrefixedName
    /// <summary>
    ///   <para>w3id:CPSWatch#Open</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:CPSWatch#Status</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/CPSWatch#Open">https://w3id.org/CPSWatch#Open</seealso>
    let Open = Prefixed_Name(CPSWatch, "Open") |> PrefixedName
    /// <summary>
    ///   <para>w3id:CPSWatch#ShuttingDown</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:CPSWatch#Status</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/CPSWatch#ShuttingDown">https://w3id.org/CPSWatch#ShuttingDown</seealso>
    let ShuttingDown = Prefixed_Name(CPSWatch, "ShuttingDown") |> PrefixedName
    /// <summary>
    ///   <para>w3id:CPSWatch#Starting</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:CPSWatch#Status</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/CPSWatch#Starting">https://w3id.org/CPSWatch#Starting</seealso>
    let Starting = Prefixed_Name(CPSWatch, "Starting") |> PrefixedName
    /// <summary>
    ///   <para>w3id:CPSWatch#Status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The status values a CPSWatch#StatusMonitoringSensor can return."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/CPSWatch#Status">https://w3id.org/CPSWatch#Status</seealso>
    let Status = Prefixed_Name(CPSWatch, "Status") |> PrefixedName

    /// <summary>
    ///   <para>w3id:CPSWatch#StatusMonitoringSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A CPSWatch#StatusMonitoringSensor is a sensor that can write specific states."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"StatusMonitoringSensor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/CPSWatch#StatusMonitoringSensor">https://w3id.org/CPSWatch#StatusMonitoringSensor</seealso>
    let StatusMonitoringSensor =
        Prefixed_Name(CPSWatch, "StatusMonitoringSensor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:CPSWatch#StatusObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A CPSWatch#StatusObservation is an observation made by an CPSWatch#StatusMonitoringSensor monitoring sensor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"StatusObservation "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/CPSWatch#StatusObservation">https://w3id.org/CPSWatch#StatusObservation</seealso>
    let StatusObservation = Prefixed_Name(CPSWatch, "StatusObservation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:CPSWatch#hasDeviationThreshold</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Deviation threshold of a CPSWatch:EventMonitoringSensor that needs to be exceeded to save the current value."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasDeviationThreshold"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/CPSWatch#hasDeviationThreshold">https://w3id.org/CPSWatch#hasDeviationThreshold</seealso>
    let hasDeviationThreshold =
        Prefixed_Name(CPSWatch, "hasDeviationThreshold") |> PrefixedName

    /// <summary>
    ///   <para>w3id:CPSWatch#hasInfluence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connection between two CPSWatch:MonitoringSensor to state that the observations of these sensors are connected."</para>
    /// labels<para>"hasInfluence"</para></remarks>
    /// <seealso href="https://w3id.org/CPSWatch#hasInfluence">https://w3id.org/CPSWatch#hasInfluence</seealso>
    let hasInfluence = Prefixed_Name(CPSWatch, "hasInfluence") |> PrefixedName

    /// <summary>
    ///   <para>w3id:CPSWatch#hasMonitoringSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connection from a CPSWatch:MonitoredSystem to a CPSWatch#MonitoringSensor"</para>
    /// labels<para>"hasMonitoringSensor"</para></remarks>
    /// <seealso href="https://w3id.org/CPSWatch#hasMonitoringSensor">https://w3id.org/CPSWatch#hasMonitoringSensor</seealso>
    let hasMonitoringSensor =
        Prefixed_Name(CPSWatch, "hasMonitoringSensor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:CPSWatch#hasNegativeCorrelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connection between two CPSWatch:MonitoringSensor to state that the observations of these sensors are with a negative correlation."</para>
    /// labels<para>"hasNegativeCorrelation"</para></remarks>
    /// <seealso href="https://w3id.org/CPSWatch#hasNegativeCorrelation">https://w3id.org/CPSWatch#hasNegativeCorrelation</seealso>
    let hasNegativeCorrelation =
        Prefixed_Name(CPSWatch, "hasNegativeCorrelation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:CPSWatch#hasPositiveCorrelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connection between two CPSWatch:MonitoringSensor to state that the observations of these sensors are with a positive correlation."</para>
    /// labels<para>"hasPositiveCorrelation"</para></remarks>
    /// <seealso href="https://w3id.org/CPSWatch#hasPositiveCorrelation">https://w3id.org/CPSWatch#hasPositiveCorrelation</seealso>
    let hasPositiveCorrelation =
        Prefixed_Name(CPSWatch, "hasPositiveCorrelation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:CPSWatch#hasSampleRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Update rate in seconds (s) that the data is stored."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasSampleRate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/CPSWatch#hasSampleRate">https://w3id.org/CPSWatch#hasSampleRate</seealso>
    let hasSampleRate = Prefixed_Name(CPSWatch, "hasSampleRate") |> PrefixedName
    /// <summary>
    ///   <para>w3id:CPSWatch#hasSensorID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The unique ID of a CPSWatch#MonitoringSensor."</para>
    /// labels<para>"hasID"</para></remarks>
    /// <seealso href="https://w3id.org/CPSWatch#hasSensorID">https://w3id.org/CPSWatch#hasSensorID</seealso>
    let hasSensorID = Prefixed_Name(CPSWatch, "hasSensorID") |> PrefixedName
    /// <summary>
    ///   <para>w3id:CPSWatch#hasStates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The possible states that a CPSWatch#StatusMonitoringSensor can have."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasStates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/CPSWatch#hasStates">https://w3id.org/CPSWatch#hasStates</seealso>
    let hasStates = Prefixed_Name(CPSWatch, "hasStates") |> PrefixedName
    /// <summary>
    ///   <para>w3id:CPSWatch#hasStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The Status of the observations of a CPSWatch#StatusMonitoringSensor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasStatus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/CPSWatch#hasStatus">https://w3id.org/CPSWatch#hasStatus</seealso>
    let hasStatus = Prefixed_Name(CPSWatch, "hasStatus") |> PrefixedName
    /// <summary>
    ///   <para>w3id:CPSWatch#hasSubSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connection between two CPSWatch:MonitoredSystem to state that a CPSWatch:MonitoredSystem has a sub system."</para>
    /// labels<para>"hasSubSystem"</para></remarks>
    /// <seealso href="https://w3id.org/CPSWatch#hasSubSystem">https://w3id.org/CPSWatch#hasSubSystem</seealso>
    let hasSubSystem = Prefixed_Name(CPSWatch, "hasSubSystem") |> PrefixedName

    /// <summary>
    ///   <para>w3id:CPSWatch#hasSystemConnection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connection between two CPSWatch:MonitoredSystem to state that system B is dependent on system A, e.g. CPSWatch:MonitoredSystem A hasSystemConnection CPSWatch:MonitoredSystem B."</para>
    /// labels<para>"hasSystemConnection"</para></remarks>
    /// <seealso href="https://w3id.org/CPSWatch#hasSystemConnection">https://w3id.org/CPSWatch#hasSystemConnection</seealso>
    let hasSystemConnection =
        Prefixed_Name(CPSWatch, "hasSystemConnection") |> PrefixedName

    /// <summary>
    ///   <para>w3id:CPSWatch#hasSystemID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The unique ID of a CPSWatch#MonitoredSystem."</para>
    /// labels<para>"hasID"</para></remarks>
    /// <seealso href="https://w3id.org/CPSWatch#hasSystemID">https://w3id.org/CPSWatch#hasSystemID</seealso>
    let hasSystemID = Prefixed_Name(CPSWatch, "hasSystemID") |> PrefixedName
    /// <summary>
    ///   <para>w3id:CPSWatch#hasUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The unit the observations of a CPSWatch#ContinuousMonitoringSensor or CPSWatch#EventMonitoringSensor monitoring sensor are made in."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasUnit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/CPSWatch#hasUnit">https://w3id.org/CPSWatch#hasUnit</seealso>
    let hasUnit = Prefixed_Name(CPSWatch, "hasUnit") |> PrefixedName
