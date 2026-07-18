namespace https.w3id.org.opentrafficlights.hash

open DoxAletheia.Rdf_Vocabulary

module otl =
    let _namespace_name = "https://w3id.org/opentrafficlights#"
    /// <summary>
    /// This ontology provides the terms necessary to describe the status of traffic lights.
    /// <see href="https://w3id.org/opentrafficlights#Ontology"></see></summary>
    let Ontology = Namespaced_IRI.parse _namespace_name "Ontology" |> NamespacedName
    /// <summary>
    /// Describes a departure at a certain lane and an arrival at a different lane
    /// <see href="https://w3id.org/opentrafficlights#Connection"></see></summary>
    let Connection = Namespaced_IRI.parse _namespace_name "Connection" |> NamespacedName
    /// <summary>
    /// Describes a part of the road where a passenger departs or arrives from.
    /// <see href="https://w3id.org/opentrafficlights#Lane"></see></summary>
    let Lane = Namespaced_IRI.parse _namespace_name "Lane" |> NamespacedName

    /// <summary>
    /// Describes a group of traffic lights that have the same Signal state.
    /// <see href="https://w3id.org/opentrafficlights#SignalGroup"></see></summary>
    let SignalGroup =
        Namespaced_IRI.parse _namespace_name "SignalGroup" |> NamespacedName

    /// <summary>
    /// Describes the state of a Signal group.
    /// <see href="https://w3id.org/opentrafficlights#SignalState"></see></summary>
    let SignalState =
        Namespaced_IRI.parse _namespace_name "SignalState" |> NamespacedName

    /// <summary>
    /// A road user will arrive here
    /// <see href="https://w3id.org/opentrafficlights#arrivalLane"></see></summary>
    let arrivalLane =
        Namespaced_IRI.parse _namespace_name "arrivalLane" |> NamespacedName

    /// <summary>
    /// A road user will depart from here
    /// <see href="https://w3id.org/opentrafficlights#departureLane"></see></summary>
    let departureLane =
        Namespaced_IRI.parse _namespace_name "departureLane" |> NamespacedName

    /// <summary>
    /// The latest time possible at which the event state could change, except when unpredictable events relating to a pre-emption or priority call disrupt a currently active timing plan.
    /// <see href="https://w3id.org/opentrafficlights#maxEndTime"></see></summary>
    let maxEndTime = Namespaced_IRI.parse _namespace_name "maxEndTime" |> NamespacedName
    /// <summary>
    /// The earliest time possible at which the event state could change, except when unpredictable events relating to a pre-emption or priority call disrupt a currently active timing plan.
    /// <see href="https://w3id.org/opentrafficlights#minEndTime"></see></summary>
    let minEndTime = Namespaced_IRI.parse _namespace_name "minEndTime" |> NamespacedName

    /// <summary>
    /// Represents green, red etc. Adviced to use concept scheme https://w3id.org/opentrafficlights/thesauri/signalphase
    /// <see href="https://w3id.org/opentrafficlights#signalPhase"></see></summary>
    let signalPhase =
        Namespaced_IRI.parse _namespace_name "signalPhase" |> NamespacedName

    /// <summary>
    /// Signal state of a signal group.
    /// <see href="https://w3id.org/opentrafficlights#signalState"></see></summary>
    let signalState =
        Namespaced_IRI.parse _namespace_name "signalState" |> NamespacedName

    /// <summary>
    /// The width of a lane expressed in centimeters.
    /// <see href="https://w3id.org/opentrafficlights#width"></see></summary>
    let width = Namespaced_IRI.parse _namespace_name "width" |> NamespacedName
