namespace http.semweb.mmlab.be.ns.linkedconnections.hash

open DoxAletheia

module lc =
    let _namespace_name = "http://semweb.mmlab.be/ns/linkedconnections#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// This ontology provides the predicates necessary to describe a connection or hop from one transit stop to another.
    /// <see href="http://semweb.mmlab.be/ns/linkedconnections#Ontology"></see></summary>
    let Ontology = _prefix "Ontology"
    /// <summary>
    /// Describes a connection that will not happen anymore, and that should appear as “cancelled” in a route planning result
    /// <see href="http://semweb.mmlab.be/ns/linkedconnections#CancelledConnection"></see></summary>
    let CancelledConnection = _prefix "CancelledConnection"
    /// <summary>
    /// Describes a departure at a certain stop and an arrival at a different stop
    /// <see href="http://semweb.mmlab.be/ns/linkedconnections#Connection"></see></summary>
    let Connection = _prefix "Connection"
    /// <summary>
    /// Describes a connection that will not happen anymore, and that should not appear in a route planning result as it was unscheduled.
    /// <see href="http://semweb.mmlab.be/ns/linkedconnections#UnscheduledConnection"></see></summary>
    let UnscheduledConnection = _prefix "UnscheduledConnection"
    /// <summary>
    /// The time in which the lc:arrivalTime differs from the scheduled arrival time
    /// <see href="http://semweb.mmlab.be/ns/linkedconnections#arrivalDelay"></see></summary>
    let arrivalDelay = _prefix "arrivalDelay"
    /// <summary>
    /// A vehicle will stop here on arrival
    /// <see href="http://semweb.mmlab.be/ns/linkedconnections#arrivalStop"></see></summary>
    let arrivalStop = _prefix "arrivalStop"
    /// <summary>
    /// The time of arrival at a certain stop (when e.g., a delay is announced, the lc:arrivalTime will show that actual time of arrival)
    /// <see href="http://semweb.mmlab.be/ns/linkedconnections#arrivalTime"></see></summary>
    let arrivalTime = _prefix "arrivalTime"
    /// <summary>
    /// The time in which the lc:departureTime differs from the scheduled departure time
    /// <see href="http://semweb.mmlab.be/ns/linkedconnections#departureDelay"></see></summary>
    let departureDelay = _prefix "departureDelay"
    /// <summary>
    /// A vehicle departs here
    /// <see href="http://semweb.mmlab.be/ns/linkedconnections#departureStop"></see></summary>
    let departureStop = _prefix "departureStop"
    /// <summary>
    /// The time of departure at a certain stop (when e.g., a delay is announced, the lc:departureTime will show that actual time of departure)
    /// <see href="http://semweb.mmlab.be/ns/linkedconnections#departureTime"></see></summary>
    let departureTime = _prefix "departureTime"
    /// <summary>
    /// A property representing a departureTime query
    /// <see href="http://semweb.mmlab.be/ns/linkedconnections#departureTimeQuery"></see></summary>
    let departureTimeQuery = _prefix "departureTimeQuery"
    /// <summary>
    /// The next connection on this vehicle's trajectory
    /// <see href="http://semweb.mmlab.be/ns/linkedconnections#nextConnection"></see></summary>
    let nextConnection = _prefix "nextConnection"
