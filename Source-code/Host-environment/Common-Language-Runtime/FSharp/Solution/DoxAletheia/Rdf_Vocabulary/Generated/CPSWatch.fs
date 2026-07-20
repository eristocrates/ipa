namespace https.w3id.org.CPSWatch.hash

open DoxAletheia

module CPSWatch =
    let _namespace_name = "https://w3id.org/CPSWatch#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A CPSWatch#NumericObservation is an observation made by an CPSWatch#NumericMonitoringSensor.
    /// <see href="https://w3id.org/CPSWatch#NumericObservation"></see></summary>
    let NumericObservation = _prefix "NumericObservation"
    /// <summary>
    /// A CPSWatch#Observation is the parent class of CPSWatch#NumericObservation and CPSWatch#StatusObservation that describe the observation made by a CPSWatch#ContinuousMonitoringSensor, CPSWatch#EventMonitoringSensor, or CPSWatch#StatusMonitoringSensor.
    /// <see href="https://w3id.org/CPSWatch#Observation"></see></summary>
    let Observation = _prefix "Observation"
    /// <summary>
    /// A CPSWatch#MonitoringSensor is a sensor used to monitor a CPSWatch#MonitoredSystem. It can be of type CPSWatch#ContinuousMonitoringSensor, CPSWatch#EventMonitoringSensor, CPSWatch#StatusMonitoringSensor.
    /// <see href="https://w3id.org/CPSWatch#MonitoringSensor"></see></summary>
    let MonitoringSensor = _prefix "MonitoringSensor"
    /// <summary>
    ///   <see href="https://w3id.org/CPSWatch#Closed"></see>
    /// </summary>
    let Closed = _prefix "Closed"
    /// <summary>
    /// The status values a CPSWatch#StatusMonitoringSensor can return.
    /// <see href="https://w3id.org/CPSWatch#Status"></see></summary>
    let Status = _prefix "Status"
    /// <summary>
    /// A CPSWatch#ContinuousMonitoringSensor is a sensor that writes data with a fixed sample rate.
    /// <see href="https://w3id.org/CPSWatch#ContinuousMonitoringSensor"></see></summary>
    let ContinuousMonitoringSensor = _prefix "ContinuousMonitoringSensor"
    /// <summary>
    /// Update rate in seconds (s) that the data is stored.
    /// <see href="https://w3id.org/CPSWatch#hasSampleRate"></see></summary>
    let hasSampleRate = _prefix "hasSampleRate"
    /// <summary>
    /// A CPSWatch#NumericMonitoringSensor is a sensor that writes numreric data.
    /// <see href="https://w3id.org/CPSWatch#NumericMonitoringSensor"></see></summary>
    let NumericMonitoringSensor = _prefix "NumericMonitoringSensor"
    /// <summary>
    ///   <see href="https://w3id.org/CPSWatch#Critical"></see>
    /// </summary>
    let Critical = _prefix "Critical"
    /// <summary>
    ///   <see href="https://w3id.org/CPSWatch#Error"></see>
    /// </summary>
    let Error = _prefix "Error"
    /// <summary>
    /// A CPSWatch#EventMonitoringSensor is a sensor that writes data if a threshold is surpassed.
    /// <see href="https://w3id.org/CPSWatch#EventMonitoringSensor"></see></summary>
    let EventMonitoringSensor = _prefix "EventMonitoringSensor"
    /// <summary>
    /// Deviation threshold of a CPSWatch:EventMonitoringSensor that needs to be exceeded to save the current value.
    /// <see href="https://w3id.org/CPSWatch#hasDeviationThreshold"></see></summary>
    let hasDeviationThreshold = _prefix "hasDeviationThreshold"
    /// <summary>
    /// A CPSWatch#MonitoredSystem is a system that is monitored by CPSWatch#MonitoringSensor.
    /// <see href="https://w3id.org/CPSWatch#MonitoredSystem"></see></summary>
    let MonitoredSystem = _prefix "MonitoredSystem"
    /// <summary>
    /// The unique ID of a CPSWatch#MonitoredSystem.
    /// <see href="https://w3id.org/CPSWatch#hasSystemID"></see></summary>
    let hasSystemID = _prefix "hasSystemID"
    /// <summary>
    /// The unique ID of a CPSWatch#MonitoringSensor.
    /// <see href="https://w3id.org/CPSWatch#hasSensorID"></see></summary>
    let hasSensorID = _prefix "hasSensorID"
    /// <summary>
    ///   <see href="https://w3id.org/CPSWatch#Off"></see>
    /// </summary>
    let Off = _prefix "Off"
    /// <summary>
    ///   <see href="https://w3id.org/CPSWatch#Ok"></see>
    /// </summary>
    let Ok = _prefix "Ok"
    /// <summary>
    ///   <see href="https://w3id.org/CPSWatch#On"></see>
    /// </summary>
    let On = _prefix "On"
    /// <summary>
    ///   <see href="https://w3id.org/CPSWatch#Open"></see>
    /// </summary>
    let Open = _prefix "Open"
    /// <summary>
    ///   <see href="https://w3id.org/CPSWatch#ShuttingDown"></see>
    /// </summary>
    let ShuttingDown = _prefix "ShuttingDown"
    /// <summary>
    ///   <see href="https://w3id.org/CPSWatch#Starting"></see>
    /// </summary>
    let Starting = _prefix "Starting"
    /// <summary>
    /// A CPSWatch#StatusMonitoringSensor is a sensor that can write specific states.
    /// <see href="https://w3id.org/CPSWatch#StatusMonitoringSensor"></see></summary>
    let StatusMonitoringSensor = _prefix "StatusMonitoringSensor"
    /// <summary>
    /// A CPSWatch#StatusObservation is an observation made by an CPSWatch#StatusMonitoringSensor monitoring sensor.
    /// <see href="https://w3id.org/CPSWatch#StatusObservation"></see></summary>
    let StatusObservation = _prefix "StatusObservation"
    /// <summary>
    /// The Status of the observations of a CPSWatch#StatusMonitoringSensor.
    /// <see href="https://w3id.org/CPSWatch#hasStatus"></see></summary>
    let hasStatus = _prefix "hasStatus"
    /// <summary>
    /// Connection between two CPSWatch:MonitoringSensor to state that the observations of these sensors are connected.
    /// <see href="https://w3id.org/CPSWatch#hasInfluence"></see></summary>
    let hasInfluence = _prefix "hasInfluence"
    /// <summary>
    /// Connection from a CPSWatch:MonitoredSystem to a CPSWatch#MonitoringSensor
    /// <see href="https://w3id.org/CPSWatch#hasMonitoringSensor"></see></summary>
    let hasMonitoringSensor = _prefix "hasMonitoringSensor"
    /// <summary>
    /// Connection between two CPSWatch:MonitoringSensor to state that the observations of these sensors are with a negative correlation.
    /// <see href="https://w3id.org/CPSWatch#hasNegativeCorrelation"></see></summary>
    let hasNegativeCorrelation = _prefix "hasNegativeCorrelation"
    /// <summary>
    /// Connection between two CPSWatch:MonitoringSensor to state that the observations of these sensors are with a positive correlation.
    /// <see href="https://w3id.org/CPSWatch#hasPositiveCorrelation"></see></summary>
    let hasPositiveCorrelation = _prefix "hasPositiveCorrelation"
    /// <summary>
    /// The possible states that a CPSWatch#StatusMonitoringSensor can have.
    /// <see href="https://w3id.org/CPSWatch#hasStates"></see></summary>
    let hasStates = _prefix "hasStates"
    /// <summary>
    /// Connection between two CPSWatch:MonitoredSystem to state that a CPSWatch:MonitoredSystem has a sub system.
    /// <see href="https://w3id.org/CPSWatch#hasSubSystem"></see></summary>
    let hasSubSystem = _prefix "hasSubSystem"
    /// <summary>
    /// Connection between two CPSWatch:MonitoredSystem to state that system B is dependent on system A, e.g. CPSWatch:MonitoredSystem A hasSystemConnection CPSWatch:MonitoredSystem B.
    /// <see href="https://w3id.org/CPSWatch#hasSystemConnection"></see></summary>
    let hasSystemConnection = _prefix "hasSystemConnection"
    /// <summary>
    /// The unit the observations of a CPSWatch#ContinuousMonitoringSensor or CPSWatch#EventMonitoringSensor monitoring sensor are made in.
    /// <see href="https://w3id.org/CPSWatch#hasUnit"></see></summary>
    let hasUnit = _prefix "hasUnit"
