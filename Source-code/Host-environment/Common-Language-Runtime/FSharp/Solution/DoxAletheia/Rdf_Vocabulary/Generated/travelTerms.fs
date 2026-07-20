namespace http.www.w3.org._2000._10.swap.pim.travelTerms.hash

open DoxAletheia

module travelTerms =
    let _namespace_name = "http://www.w3.org/2000/10/swap/pim/travelTerms#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/travelTerms#0_work"></see>
    /// </summary>
    let _0_work = _prefix "0_work"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/travelTerms#_g0"></see>
    /// </summary>
    let _g0 = _prefix "_g0"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/travelTerms#Flight"></see>
    /// </summary>
    let Flight = _prefix "Flight"
    /// <summary>
    /// @@TODO: relate this to xml schema time stuff, cyc calendar stuff, etc.
    /// a string of the form HH:MM; e.g. 12:00, 14:23
    /// <see href="http://www.w3.org/2000/10/swap/pim/travelTerms#TimeString"></see></summary>
    let TimeString = _prefix "TimeString"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/travelTerms#arrivalTime"></see>
    /// </summary>
    let arrivalTime = _prefix "arrivalTime"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/travelTerms#carrier"></see>
    /// </summary>
    let carrier = _prefix "carrier"
    /// <summary>
    /// a string representing the departure time,
    ///    in the timezone of the flight's fromLocation
    /// hmm... model this as the time of a departure subevent?
    /// <see href="http://www.w3.org/2000/10/swap/pim/travelTerms#departureTime"></see></summary>
    let departureTime = _prefix "departureTime"
    /// <summary>
    /// @@range specification needs a new datatyping property
    /// <see href="http://www.w3.org/2000/10/swap/pim/travelTerms#flightNumber"></see></summary>
    let flightNumber = _prefix "flightNumber"
