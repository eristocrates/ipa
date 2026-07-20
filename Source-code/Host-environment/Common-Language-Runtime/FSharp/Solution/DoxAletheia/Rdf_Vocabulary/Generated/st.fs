namespace http.semweb.mmlab.be.ns.stoptimes.hash

open DoxAletheia

module st =
    let _namespace_name = "http://semweb.mmlab.be/ns/stoptimes#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// This ontology provides the predicates necessary to describe an arrival of a transit vehicle and its departure at a certain Stop.
    /// <see href="http://semweb.mmlab.be/ns/stoptimes#Ontology"></see></summary>
    let Ontology = _prefix "Ontology"
    /// <summary>
    /// A location and a time where a vehicle stops for the purpose of unloading people or things
    /// <see href="http://semweb.mmlab.be/ns/stoptimes#Arrival"></see></summary>
    let Arrival = _prefix "Arrival"
    /// <summary>
    /// A location and a departure time where a vehicle departs where people or things can be loaded
    /// <see href="http://semweb.mmlab.be/ns/stoptimes#Departure"></see></summary>
    let Departure = _prefix "Departure"
    /// <summary>
    /// A location and a time where a vehicle stops for the purpose of loading and/or unloading people or things
    /// <see href="http://semweb.mmlab.be/ns/stoptimes#StopTime"></see></summary>
    let StopTime = _prefix "StopTime"
    /// <summary>
    /// The time in seconds in which the st:arrivalTime differs from the scheduled arrival time
    /// <see href="http://semweb.mmlab.be/ns/stoptimes#arrivalDelay"></see></summary>
    let arrivalDelay = _prefix "arrivalDelay"
    /// <summary>
    /// The average st:StopTimes per day
    /// <see href="http://semweb.mmlab.be/ns/stoptimes#avgStopTimes"></see></summary>
    let avgStopTimes = _prefix "avgStopTimes"
    /// <summary>
    /// The time in seconds in which the st:departureTime differs from the scheduled departure time
    /// <see href="http://semweb.mmlab.be/ns/stoptimes#departureDelay"></see></summary>
    let departureDelay = _prefix "departureDelay"
    /// <summary>
    /// The next stop time on this vehicle's trajectory.
    /// <see href="http://semweb.mmlab.be/ns/stoptimes#nextStopTime"></see></summary>
    let nextStopTime = _prefix "nextStopTime"
