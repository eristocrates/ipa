namespace http.w3id.org.CEON.ontology.processODP.slash

open DoxAletheia

module ceon_processODP =
    let _namespace_name = "http://w3id.org/CEON/ontology/processODP/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/CEON/ontology/processODP/0.5/"></see>
    /// </summary>
    let ``_0.5/`` = _prefix "0.5/"
    /// <summary>
    /// Something that happens within a given context or (short) timeframe.
    /// <see href="http://w3id.org/CEON/ontology/processODP/Event"></see></summary>
    let Event = _prefix "Event"
    /// <summary>
    /// The inputs to a process or event.
    /// <see href="http://w3id.org/CEON/ontology/processODP/hasInput"></see></summary>
    let hasInput = _prefix "hasInput"
    /// <summary>
    /// The output of a process or event.
    /// <see href="http://w3id.org/CEON/ontology/processODP/hasOutput"></see></summary>
    let hasOutput = _prefix "hasOutput"
    /// <summary>
    /// A process or event can consist of several parts, which are sub-processes (e.g. steps) or events.
    /// <see href="http://w3id.org/CEON/ontology/processODP/hasPart"></see></summary>
    let hasPart = _prefix "hasPart"
    /// <summary>
    /// Something that takes place over a (longer) period of time and changes some state of affairs.
    /// <see href="http://w3id.org/CEON/ontology/processODP/Process"></see></summary>
    let Process = _prefix "Process"
    /// <summary>
    /// A situation that may involve some resources and actors, i.e. a state of affairs at a certain point in time.
    /// <see href="http://w3id.org/CEON/ontology/processODP/Situation"></see></summary>
    let Situation = _prefix "Situation"
    /// <summary>
    /// The thing(s) that this situation is the setting for, e.g. a resource that is in a certain state.
    /// <see href="http://w3id.org/CEON/ontology/processODP/isSettingFor"></see></summary>
    let isSettingFor = _prefix "isSettingFor"
    /// <summary>
    /// A temporal entity has a starting time and an ending time.
    /// <see href="http://w3id.org/CEON/ontology/processODP/TimeInterval"></see></summary>
    let TimeInterval = _prefix "TimeInterval"
    /// <summary>
    /// The time interval during which something, e.g. a process or event, takes place.
    /// <see href="http://w3id.org/CEON/ontology/processODP/duringTime"></see></summary>
    let duringTime = _prefix "duringTime"
    /// <summary>
    /// Represents the end time of a time interval.
    /// <see href="http://w3id.org/CEON/ontology/processODP/endTime"></see></summary>
    let endTime = _prefix "endTime"
    /// <summary>
    /// The location in which something (e.g. an event or process) takes place, e.g. the factory location where something is manufactured.
    /// <see href="http://w3id.org/CEON/ontology/processODP/occursAtLocation"></see></summary>
    let occursAtLocation = _prefix "occursAtLocation"
    /// <summary>
    /// Represents the start time of a time interval.
    /// <see href="http://w3id.org/CEON/ontology/processODP/startTime"></see></summary>
    let startTime = _prefix "startTime"
