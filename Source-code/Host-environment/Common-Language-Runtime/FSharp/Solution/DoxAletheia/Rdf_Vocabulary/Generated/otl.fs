namespace https.w3id.org.opentrafficlights.hash

open DoxAletheia

module otl =
    let _namespace_name = "https://w3id.org/opentrafficlights#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// This ontology provides the terms necessary to describe the status of traffic lights.
    /// <see href="https://w3id.org/opentrafficlights#Ontology"></see></summary>
    let Ontology = _prefix "Ontology"
    /// <summary>
    /// Describes a departure at a certain lane and an arrival at a different lane
    /// <see href="https://w3id.org/opentrafficlights#Connection"></see></summary>
    let Connection = _prefix "Connection"
    /// <summary>
    /// Describes a part of the road where a passenger departs or arrives from.
    /// <see href="https://w3id.org/opentrafficlights#Lane"></see></summary>
    let Lane = _prefix "Lane"
    /// <summary>
    /// Describes a group of traffic lights that have the same Signal state.
    /// <see href="https://w3id.org/opentrafficlights#SignalGroup"></see></summary>
    let SignalGroup = _prefix "SignalGroup"
    /// <summary>
    /// Describes the state of a Signal group.
    /// <see href="https://w3id.org/opentrafficlights#SignalState"></see></summary>
    let SignalState = _prefix "SignalState"
    /// <summary>
    /// A road user will arrive here
    /// <see href="https://w3id.org/opentrafficlights#arrivalLane"></see></summary>
    let arrivalLane = _prefix "arrivalLane"
    /// <summary>
    /// A road user will depart from here
    /// <see href="https://w3id.org/opentrafficlights#departureLane"></see></summary>
    let departureLane = _prefix "departureLane"
    /// <summary>
    /// The latest time possible at which the event state could change, except when unpredictable events relating to a pre-emption or priority call disrupt a currently active timing plan.
    /// <see href="https://w3id.org/opentrafficlights#maxEndTime"></see></summary>
    let maxEndTime = _prefix "maxEndTime"
    /// <summary>
    /// The earliest time possible at which the event state could change, except when unpredictable events relating to a pre-emption or priority call disrupt a currently active timing plan.
    /// <see href="https://w3id.org/opentrafficlights#minEndTime"></see></summary>
    let minEndTime = _prefix "minEndTime"
    /// <summary>
    /// Represents green, red etc. Adviced to use concept scheme https://w3id.org/opentrafficlights/thesauri/signalphase
    /// <see href="https://w3id.org/opentrafficlights#signalPhase"></see></summary>
    let signalPhase = _prefix "signalPhase"
    /// <summary>
    /// Signal state of a signal group.
    /// <see href="https://w3id.org/opentrafficlights#signalState"></see></summary>
    let signalState = _prefix "signalState"
    /// <summary>
    /// The width of a lane expressed in centimeters.
    /// <see href="https://w3id.org/opentrafficlights#width"></see></summary>
    let width = _prefix "width"
