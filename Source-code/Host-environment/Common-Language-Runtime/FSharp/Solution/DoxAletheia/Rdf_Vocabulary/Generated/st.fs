namespace http.semweb.mmlab.be.ns.stoptimes.hash

open DoxAletheia.Rdf_Vocabulary

module st =
    let _namespace_name = "http://semweb.mmlab.be/ns/stoptimes#"
    /// <summary>
    /// This ontology provides the predicates necessary to describe an arrival of a transit vehicle and its departure at a certain Stop.
    /// <see href="http://semweb.mmlab.be/ns/stoptimes#Ontology"></see></summary>
    let Ontology = Namespaced_IRI.parse _namespace_name "Ontology" |> NamespacedName
    /// <summary>
    /// A location and a time where a vehicle stops for the purpose of unloading people or things
    /// <see href="http://semweb.mmlab.be/ns/stoptimes#Arrival"></see></summary>
    let Arrival = Namespaced_IRI.parse _namespace_name "Arrival" |> NamespacedName
    /// <summary>
    /// A location and a departure time where a vehicle departs where people or things can be loaded
    /// <see href="http://semweb.mmlab.be/ns/stoptimes#Departure"></see></summary>
    let Departure = Namespaced_IRI.parse _namespace_name "Departure" |> NamespacedName
    /// <summary>
    /// A location and a time where a vehicle stops for the purpose of loading and/or unloading people or things
    /// <see href="http://semweb.mmlab.be/ns/stoptimes#StopTime"></see></summary>
    let StopTime = Namespaced_IRI.parse _namespace_name "StopTime" |> NamespacedName

    /// <summary>
    /// The time in seconds in which the st:arrivalTime differs from the scheduled arrival time
    /// <see href="http://semweb.mmlab.be/ns/stoptimes#arrivalDelay"></see></summary>
    let arrivalDelay =
        Namespaced_IRI.parse _namespace_name "arrivalDelay" |> NamespacedName

    /// <summary>
    /// The average st:StopTimes per day
    /// <see href="http://semweb.mmlab.be/ns/stoptimes#avgStopTimes"></see></summary>
    let avgStopTimes =
        Namespaced_IRI.parse _namespace_name "avgStopTimes" |> NamespacedName

    /// <summary>
    /// The time in seconds in which the st:departureTime differs from the scheduled departure time
    /// <see href="http://semweb.mmlab.be/ns/stoptimes#departureDelay"></see></summary>
    let departureDelay =
        Namespaced_IRI.parse _namespace_name "departureDelay" |> NamespacedName

    /// <summary>
    /// The next stop time on this vehicle's trajectory.
    /// <see href="http://semweb.mmlab.be/ns/stoptimes#nextStopTime"></see></summary>
    let nextStopTime =
        Namespaced_IRI.parse _namespace_name "nextStopTime" |> NamespacedName
