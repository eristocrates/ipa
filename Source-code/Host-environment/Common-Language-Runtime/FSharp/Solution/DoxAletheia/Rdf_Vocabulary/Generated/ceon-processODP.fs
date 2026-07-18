namespace http.w3id.org.CEON.ontology.processODP.slash

open DoxAletheia.Rdf_Vocabulary

module ceon_processODP =
    let _namespace_name = "http://w3id.org/CEON/ontology/processODP/"
    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/processODP/0.5/"></see>
    /// </summary>
    let ``_0.5/`` = Namespaced_IRI.parse _namespace_name "0.5/" |> NamespacedName
    /// <summary>
    /// Something that happens within a given context or (short) timeframe.
    /// <see href="http://w3id.org/CEON/ontology/processODP/Event"></see></summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName
    /// <summary>
    /// The inputs to a process or event.
    /// <see href="http://w3id.org/CEON/ontology/processODP/hasInput"></see></summary>
    let hasInput = Namespaced_IRI.parse _namespace_name "hasInput" |> NamespacedName
    /// <summary>
    /// The output of a process or event.
    /// <see href="http://w3id.org/CEON/ontology/processODP/hasOutput"></see></summary>
    let hasOutput = Namespaced_IRI.parse _namespace_name "hasOutput" |> NamespacedName
    /// <summary>
    /// A process or event can consist of several parts, which are sub-processes (e.g. steps) or events.
    /// <see href="http://w3id.org/CEON/ontology/processODP/hasPart"></see></summary>
    let hasPart = Namespaced_IRI.parse _namespace_name "hasPart" |> NamespacedName
    /// <summary>
    /// Something that takes place over a (longer) period of time and changes some state of affairs.
    /// <see href="http://w3id.org/CEON/ontology/processODP/Process"></see></summary>
    let Process = Namespaced_IRI.parse _namespace_name "Process" |> NamespacedName
    /// <summary>
    /// A situation that may involve some resources and actors, i.e. a state of affairs at a certain point in time.
    /// <see href="http://w3id.org/CEON/ontology/processODP/Situation"></see></summary>
    let Situation = Namespaced_IRI.parse _namespace_name "Situation" |> NamespacedName

    /// <summary>
    /// The thing(s) that this situation is the setting for, e.g. a resource that is in a certain state.
    /// <see href="http://w3id.org/CEON/ontology/processODP/isSettingFor"></see></summary>
    let isSettingFor =
        Namespaced_IRI.parse _namespace_name "isSettingFor" |> NamespacedName

    /// <summary>
    /// A temporal entity has a starting time and an ending time.
    /// <see href="http://w3id.org/CEON/ontology/processODP/TimeInterval"></see></summary>
    let TimeInterval =
        Namespaced_IRI.parse _namespace_name "TimeInterval" |> NamespacedName

    /// <summary>
    /// The time interval during which something, e.g. a process or event, takes place.
    /// <see href="http://w3id.org/CEON/ontology/processODP/duringTime"></see></summary>
    let duringTime = Namespaced_IRI.parse _namespace_name "duringTime" |> NamespacedName
    /// <summary>
    /// Represents the end time of a time interval.
    /// <see href="http://w3id.org/CEON/ontology/processODP/endTime"></see></summary>
    let endTime = Namespaced_IRI.parse _namespace_name "endTime" |> NamespacedName

    /// <summary>
    /// The location in which something (e.g. an event or process) takes place, e.g. the factory location where something is manufactured.
    /// <see href="http://w3id.org/CEON/ontology/processODP/occursAtLocation"></see></summary>
    let occursAtLocation =
        Namespaced_IRI.parse _namespace_name "occursAtLocation" |> NamespacedName

    /// <summary>
    /// Represents the start time of a time interval.
    /// <see href="http://w3id.org/CEON/ontology/processODP/startTime"></see></summary>
    let startTime = Namespaced_IRI.parse _namespace_name "startTime" |> NamespacedName
