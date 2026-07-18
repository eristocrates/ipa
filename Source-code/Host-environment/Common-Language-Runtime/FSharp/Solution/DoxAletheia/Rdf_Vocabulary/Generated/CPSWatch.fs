namespace https.w3id.org.CPSWatch.hash

open DoxAletheia.Rdf_Vocabulary

module CPSWatch =
    let _namespace_name = "https://w3id.org/CPSWatch#"

    /// <summary>
    /// A CPSWatch#NumericObservation is an observation made by an CPSWatch#NumericMonitoringSensor.
    /// <see href="https://w3id.org/CPSWatch#NumericObservation"></see></summary>
    let NumericObservation =
        Namespaced_IRI.parse _namespace_name "NumericObservation" |> NamespacedName

    /// <summary>
    /// A CPSWatch#Observation is the parent class of CPSWatch#NumericObservation and CPSWatch#StatusObservation that describe the observation made by a CPSWatch#ContinuousMonitoringSensor, CPSWatch#EventMonitoringSensor, or CPSWatch#StatusMonitoringSensor.
    /// <see href="https://w3id.org/CPSWatch#Observation"></see></summary>
    let Observation =
        Namespaced_IRI.parse _namespace_name "Observation" |> NamespacedName

    /// <summary>
    /// A CPSWatch#MonitoringSensor is a sensor used to monitor a CPSWatch#MonitoredSystem. It can be of type CPSWatch#ContinuousMonitoringSensor, CPSWatch#EventMonitoringSensor, CPSWatch#StatusMonitoringSensor.
    /// <see href="https://w3id.org/CPSWatch#MonitoringSensor"></see></summary>
    let MonitoringSensor =
        Namespaced_IRI.parse _namespace_name "MonitoringSensor" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/CPSWatch#Closed"></see>
    /// </summary>
    let Closed = Namespaced_IRI.parse _namespace_name "Closed" |> NamespacedName
    /// <summary>
    /// The status values a CPSWatch#StatusMonitoringSensor can return.
    /// <see href="https://w3id.org/CPSWatch#Status"></see></summary>
    let Status = Namespaced_IRI.parse _namespace_name "Status" |> NamespacedName

    /// <summary>
    /// A CPSWatch#ContinuousMonitoringSensor is a sensor that writes data with a fixed sample rate.
    /// <see href="https://w3id.org/CPSWatch#ContinuousMonitoringSensor"></see></summary>
    let ContinuousMonitoringSensor =
        Namespaced_IRI.parse _namespace_name "ContinuousMonitoringSensor" |> NamespacedName

    /// <summary>
    /// Update rate in seconds (s) that the data is stored.
    /// <see href="https://w3id.org/CPSWatch#hasSampleRate"></see></summary>
    let hasSampleRate =
        Namespaced_IRI.parse _namespace_name "hasSampleRate" |> NamespacedName

    /// <summary>
    /// A CPSWatch#NumericMonitoringSensor is a sensor that writes numreric data.
    /// <see href="https://w3id.org/CPSWatch#NumericMonitoringSensor"></see></summary>
    let NumericMonitoringSensor =
        Namespaced_IRI.parse _namespace_name "NumericMonitoringSensor" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/CPSWatch#Critical"></see>
    /// </summary>
    let Critical = Namespaced_IRI.parse _namespace_name "Critical" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/CPSWatch#Error"></see>
    /// </summary>
    let Error = Namespaced_IRI.parse _namespace_name "Error" |> NamespacedName

    /// <summary>
    /// A CPSWatch#EventMonitoringSensor is a sensor that writes data if a threshold is surpassed.
    /// <see href="https://w3id.org/CPSWatch#EventMonitoringSensor"></see></summary>
    let EventMonitoringSensor =
        Namespaced_IRI.parse _namespace_name "EventMonitoringSensor" |> NamespacedName

    /// <summary>
    /// Deviation threshold of a CPSWatch:EventMonitoringSensor that needs to be exceeded to save the current value.
    /// <see href="https://w3id.org/CPSWatch#hasDeviationThreshold"></see></summary>
    let hasDeviationThreshold =
        Namespaced_IRI.parse _namespace_name "hasDeviationThreshold" |> NamespacedName

    /// <summary>
    /// A CPSWatch#MonitoredSystem is a system that is monitored by CPSWatch#MonitoringSensor.
    /// <see href="https://w3id.org/CPSWatch#MonitoredSystem"></see></summary>
    let MonitoredSystem =
        Namespaced_IRI.parse _namespace_name "MonitoredSystem" |> NamespacedName

    /// <summary>
    /// The unique ID of a CPSWatch#MonitoredSystem.
    /// <see href="https://w3id.org/CPSWatch#hasSystemID"></see></summary>
    let hasSystemID =
        Namespaced_IRI.parse _namespace_name "hasSystemID" |> NamespacedName

    /// <summary>
    /// The unique ID of a CPSWatch#MonitoringSensor.
    /// <see href="https://w3id.org/CPSWatch#hasSensorID"></see></summary>
    let hasSensorID =
        Namespaced_IRI.parse _namespace_name "hasSensorID" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/CPSWatch#Off"></see>
    /// </summary>
    let Off = Namespaced_IRI.parse _namespace_name "Off" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/CPSWatch#Ok"></see>
    /// </summary>
    let Ok = Namespaced_IRI.parse _namespace_name "Ok" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/CPSWatch#On"></see>
    /// </summary>
    let On = Namespaced_IRI.parse _namespace_name "On" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/CPSWatch#Open"></see>
    /// </summary>
    let Open = Namespaced_IRI.parse _namespace_name "Open" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/CPSWatch#ShuttingDown"></see>
    /// </summary>
    let ShuttingDown =
        Namespaced_IRI.parse _namespace_name "ShuttingDown" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/CPSWatch#Starting"></see>
    /// </summary>
    let Starting = Namespaced_IRI.parse _namespace_name "Starting" |> NamespacedName

    /// <summary>
    /// A CPSWatch#StatusMonitoringSensor is a sensor that can write specific states.
    /// <see href="https://w3id.org/CPSWatch#StatusMonitoringSensor"></see></summary>
    let StatusMonitoringSensor =
        Namespaced_IRI.parse _namespace_name "StatusMonitoringSensor" |> NamespacedName

    /// <summary>
    /// A CPSWatch#StatusObservation is an observation made by an CPSWatch#StatusMonitoringSensor monitoring sensor.
    /// <see href="https://w3id.org/CPSWatch#StatusObservation"></see></summary>
    let StatusObservation =
        Namespaced_IRI.parse _namespace_name "StatusObservation" |> NamespacedName

    /// <summary>
    /// The Status of the observations of a CPSWatch#StatusMonitoringSensor.
    /// <see href="https://w3id.org/CPSWatch#hasStatus"></see></summary>
    let hasStatus = Namespaced_IRI.parse _namespace_name "hasStatus" |> NamespacedName

    /// <summary>
    /// Connection between two CPSWatch:MonitoringSensor to state that the observations of these sensors are connected.
    /// <see href="https://w3id.org/CPSWatch#hasInfluence"></see></summary>
    let hasInfluence =
        Namespaced_IRI.parse _namespace_name "hasInfluence" |> NamespacedName

    /// <summary>
    /// Connection from a CPSWatch:MonitoredSystem to a CPSWatch#MonitoringSensor
    /// <see href="https://w3id.org/CPSWatch#hasMonitoringSensor"></see></summary>
    let hasMonitoringSensor =
        Namespaced_IRI.parse _namespace_name "hasMonitoringSensor" |> NamespacedName

    /// <summary>
    /// Connection between two CPSWatch:MonitoringSensor to state that the observations of these sensors are with a negative correlation.
    /// <see href="https://w3id.org/CPSWatch#hasNegativeCorrelation"></see></summary>
    let hasNegativeCorrelation =
        Namespaced_IRI.parse _namespace_name "hasNegativeCorrelation" |> NamespacedName

    /// <summary>
    /// Connection between two CPSWatch:MonitoringSensor to state that the observations of these sensors are with a positive correlation.
    /// <see href="https://w3id.org/CPSWatch#hasPositiveCorrelation"></see></summary>
    let hasPositiveCorrelation =
        Namespaced_IRI.parse _namespace_name "hasPositiveCorrelation" |> NamespacedName

    /// <summary>
    /// The possible states that a CPSWatch#StatusMonitoringSensor can have.
    /// <see href="https://w3id.org/CPSWatch#hasStates"></see></summary>
    let hasStates = Namespaced_IRI.parse _namespace_name "hasStates" |> NamespacedName

    /// <summary>
    /// Connection between two CPSWatch:MonitoredSystem to state that a CPSWatch:MonitoredSystem has a sub system.
    /// <see href="https://w3id.org/CPSWatch#hasSubSystem"></see></summary>
    let hasSubSystem =
        Namespaced_IRI.parse _namespace_name "hasSubSystem" |> NamespacedName

    /// <summary>
    /// Connection between two CPSWatch:MonitoredSystem to state that system B is dependent on system A, e.g. CPSWatch:MonitoredSystem A hasSystemConnection CPSWatch:MonitoredSystem B.
    /// <see href="https://w3id.org/CPSWatch#hasSystemConnection"></see></summary>
    let hasSystemConnection =
        Namespaced_IRI.parse _namespace_name "hasSystemConnection" |> NamespacedName

    /// <summary>
    /// The unit the observations of a CPSWatch#ContinuousMonitoringSensor or CPSWatch#EventMonitoringSensor monitoring sensor are made in.
    /// <see href="https://w3id.org/CPSWatch#hasUnit"></see></summary>
    let hasUnit = Namespaced_IRI.parse _namespace_name "hasUnit" |> NamespacedName
