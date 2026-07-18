namespace http.semweb.mmlab.be.ns.linkedconnections.hash

open DoxAletheia.Rdf_Vocabulary

module lc =
    let _namespace_name = "http://semweb.mmlab.be/ns/linkedconnections#"
    /// <summary>
    /// This ontology provides the predicates necessary to describe a connection or hop from one transit stop to another.
    /// <see href="http://semweb.mmlab.be/ns/linkedconnections#Ontology"></see></summary>
    let Ontology = Namespaced_IRI.parse _namespace_name "Ontology" |> NamespacedName

    /// <summary>
    /// Describes a connection that will not happen anymore, and that should appear as “cancelled” in a route planning result
    /// <see href="http://semweb.mmlab.be/ns/linkedconnections#CancelledConnection"></see></summary>
    let CancelledConnection =
        Namespaced_IRI.parse _namespace_name "CancelledConnection" |> NamespacedName

    /// <summary>
    /// Describes a departure at a certain stop and an arrival at a different stop
    /// <see href="http://semweb.mmlab.be/ns/linkedconnections#Connection"></see></summary>
    let Connection = Namespaced_IRI.parse _namespace_name "Connection" |> NamespacedName

    /// <summary>
    /// Describes a connection that will not happen anymore, and that should not appear in a route planning result as it was unscheduled.
    /// <see href="http://semweb.mmlab.be/ns/linkedconnections#UnscheduledConnection"></see></summary>
    let UnscheduledConnection =
        Namespaced_IRI.parse _namespace_name "UnscheduledConnection" |> NamespacedName

    /// <summary>
    /// The time in which the lc:arrivalTime differs from the scheduled arrival time
    /// <see href="http://semweb.mmlab.be/ns/linkedconnections#arrivalDelay"></see></summary>
    let arrivalDelay =
        Namespaced_IRI.parse _namespace_name "arrivalDelay" |> NamespacedName

    /// <summary>
    /// A vehicle will stop here on arrival
    /// <see href="http://semweb.mmlab.be/ns/linkedconnections#arrivalStop"></see></summary>
    let arrivalStop =
        Namespaced_IRI.parse _namespace_name "arrivalStop" |> NamespacedName

    /// <summary>
    /// The time of arrival at a certain stop (when e.g., a delay is announced, the lc:arrivalTime will show that actual time of arrival)
    /// <see href="http://semweb.mmlab.be/ns/linkedconnections#arrivalTime"></see></summary>
    let arrivalTime =
        Namespaced_IRI.parse _namespace_name "arrivalTime" |> NamespacedName

    /// <summary>
    /// The time in which the lc:departureTime differs from the scheduled departure time
    /// <see href="http://semweb.mmlab.be/ns/linkedconnections#departureDelay"></see></summary>
    let departureDelay =
        Namespaced_IRI.parse _namespace_name "departureDelay" |> NamespacedName

    /// <summary>
    /// A vehicle departs here
    /// <see href="http://semweb.mmlab.be/ns/linkedconnections#departureStop"></see></summary>
    let departureStop =
        Namespaced_IRI.parse _namespace_name "departureStop" |> NamespacedName

    /// <summary>
    /// The time of departure at a certain stop (when e.g., a delay is announced, the lc:departureTime will show that actual time of departure)
    /// <see href="http://semweb.mmlab.be/ns/linkedconnections#departureTime"></see></summary>
    let departureTime =
        Namespaced_IRI.parse _namespace_name "departureTime" |> NamespacedName

    /// <summary>
    /// A property representing a departureTime query
    /// <see href="http://semweb.mmlab.be/ns/linkedconnections#departureTimeQuery"></see></summary>
    let departureTimeQuery =
        Namespaced_IRI.parse _namespace_name "departureTimeQuery" |> NamespacedName

    /// <summary>
    /// The next connection on this vehicle's trajectory
    /// <see href="http://semweb.mmlab.be/ns/linkedconnections#nextConnection"></see></summary>
    let nextConnection =
        Namespaced_IRI.parse _namespace_name "nextConnection" |> NamespacedName
