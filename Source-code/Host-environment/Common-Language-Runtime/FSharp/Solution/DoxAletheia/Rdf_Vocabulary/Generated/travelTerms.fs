namespace http.www.w3.org._2000._10.swap.pim.travelTerms.hash

open DoxAletheia.Rdf_Vocabulary

module travelTerms =
    let _namespace_name = "http://www.w3.org/2000/10/swap/pim/travelTerms#"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/travelTerms#0_work"></see>
    /// </summary>
    let _0_work = Namespaced_IRI.parse _namespace_name "0_work" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/travelTerms#_g0"></see>
    /// </summary>
    let _g0 = Namespaced_IRI.parse _namespace_name "_g0" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/travelTerms#Flight"></see>
    /// </summary>
    let Flight = Namespaced_IRI.parse _namespace_name "Flight" |> NamespacedName
    /// <summary>
    /// @@TODO: relate this to xml schema time stuff, cyc calendar stuff, etc.
    /// a string of the form HH:MM; e.g. 12:00, 14:23
    /// <see href="http://www.w3.org/2000/10/swap/pim/travelTerms#TimeString"></see></summary>
    let TimeString = Namespaced_IRI.parse _namespace_name "TimeString" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/travelTerms#arrivalTime"></see>
    /// </summary>
    let arrivalTime =
        Namespaced_IRI.parse _namespace_name "arrivalTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/travelTerms#carrier"></see>
    /// </summary>
    let carrier = Namespaced_IRI.parse _namespace_name "carrier" |> NamespacedName

    /// <summary>
    /// a string representing the departure time,
    ///    in the timezone of the flight's fromLocation
    /// hmm... model this as the time of a departure subevent?
    /// <see href="http://www.w3.org/2000/10/swap/pim/travelTerms#departureTime"></see></summary>
    let departureTime =
        Namespaced_IRI.parse _namespace_name "departureTime" |> NamespacedName

    /// <summary>
    /// @@range specification needs a new datatyping property
    /// <see href="http://www.w3.org/2000/10/swap/pim/travelTerms#flightNumber"></see></summary>
    let flightNumber =
        Namespaced_IRI.parse _namespace_name "flightNumber" |> NamespacedName
