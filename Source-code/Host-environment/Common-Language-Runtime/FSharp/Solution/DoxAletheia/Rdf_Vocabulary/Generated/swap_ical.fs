namespace http.www.w3.org._2000._10.swap.pim.ical.hash

open DoxAletheia.Rdf_Vocabulary

module swap_ical =
    let _namespace_name = "http://www.w3.org/2000/10/swap/pim/ical#"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#Vcalendar"></see>
    /// </summary>
    let Vcalendar = Namespaced_IRI.parse _namespace_name "Vcalendar" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#Vevent"></see>
    /// </summary>
    let Vevent = Namespaced_IRI.parse _namespace_name "Vevent" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#Vtimezone"></see>
    /// </summary>
    let Vtimezone = Namespaced_IRI.parse _namespace_name "Vtimezone" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#Vtodo"></see>
    /// </summary>
    let Vtodo = Namespaced_IRI.parse _namespace_name "Vtodo" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#calscale"></see>
    /// </summary>
    let calscale = Namespaced_IRI.parse _namespace_name "calscale" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#prodid"></see>
    /// </summary>
    let prodid = Namespaced_IRI.parse _namespace_name "prodid" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#version"></see>
    /// </summary>
    let version = Namespaced_IRI.parse _namespace_name "version" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#attendee"></see>
    /// </summary>
    let attendee = Namespaced_IRI.parse _namespace_name "attendee" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#categories"></see>
    /// </summary>
    let categories = Namespaced_IRI.parse _namespace_name "categories" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#class"></see>
    /// </summary>
    let class_ = Namespaced_IRI.parse _namespace_name "class" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#description"></see>
    /// </summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#dtend"></see>
    /// </summary>
    let dtend = Namespaced_IRI.parse _namespace_name "dtend" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#dtstamp"></see>
    /// </summary>
    let dtstamp = Namespaced_IRI.parse _namespace_name "dtstamp" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#dtstart"></see>
    /// </summary>
    let dtstart = Namespaced_IRI.parse _namespace_name "dtstart" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#location"></see>
    /// </summary>
    let location = Namespaced_IRI.parse _namespace_name "location" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#organizer"></see>
    /// </summary>
    let organizer = Namespaced_IRI.parse _namespace_name "organizer" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#rrule"></see>
    /// </summary>
    let rrule = Namespaced_IRI.parse _namespace_name "rrule" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#sequence"></see>
    /// </summary>
    let sequence = Namespaced_IRI.parse _namespace_name "sequence" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#summary"></see>
    /// </summary>
    let summary = Namespaced_IRI.parse _namespace_name "summary" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#transp"></see>
    /// </summary>
    let transp = Namespaced_IRI.parse _namespace_name "transp" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#uid"></see>
    /// </summary>
    let uid = Namespaced_IRI.parse _namespace_name "uid" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#valarm"></see>
    /// </summary>
    let valarm = Namespaced_IRI.parse _namespace_name "valarm" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#daylight"></see>
    /// </summary>
    let daylight = Namespaced_IRI.parse _namespace_name "daylight" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#standard"></see>
    /// </summary>
    let standard = Namespaced_IRI.parse _namespace_name "standard" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#tzid"></see>
    /// </summary>
    let tzid = Namespaced_IRI.parse _namespace_name "tzid" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#percentComplete"></see>
    /// </summary>
    let percentComplete =
        Namespaced_IRI.parse _namespace_name "percentComplete" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#priority"></see>
    /// </summary>
    let priority = Namespaced_IRI.parse _namespace_name "priority" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#status"></see>
    /// </summary>
    let status = Namespaced_IRI.parse _namespace_name "status" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#action"></see>
    /// </summary>
    let action = Namespaced_IRI.parse _namespace_name "action" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#byday"></see>
    /// </summary>
    let byday = Namespaced_IRI.parse _namespace_name "byday" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#bymonth"></see>
    /// </summary>
    let bymonth = Namespaced_IRI.parse _namespace_name "bymonth" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#cn"></see>
    /// </summary>
    let cn = Namespaced_IRI.parse _namespace_name "cn" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#cutype"></see>
    /// </summary>
    let cutype = Namespaced_IRI.parse _namespace_name "cutype" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#date"></see>
    /// </summary>
    let date = Namespaced_IRI.parse _namespace_name "date" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#duration"></see>
    /// </summary>
    let duration = Namespaced_IRI.parse _namespace_name "duration" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#freq"></see>
    /// </summary>
    let freq = Namespaced_IRI.parse _namespace_name "freq" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#interval"></see>
    /// </summary>
    let interval = Namespaced_IRI.parse _namespace_name "interval" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#language"></see>
    /// </summary>
    let language = Namespaced_IRI.parse _namespace_name "language" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#partstat"></see>
    /// </summary>
    let partstat = Namespaced_IRI.parse _namespace_name "partstat" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#related"></see>
    /// </summary>
    let related = Namespaced_IRI.parse _namespace_name "related" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#role"></see>
    /// </summary>
    let role = Namespaced_IRI.parse _namespace_name "role" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#rsvp"></see>
    /// </summary>
    let rsvp = Namespaced_IRI.parse _namespace_name "rsvp" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#trigger"></see>
    /// </summary>
    let trigger = Namespaced_IRI.parse _namespace_name "trigger" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#tzname"></see>
    /// </summary>
    let tzname = Namespaced_IRI.parse _namespace_name "tzname" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#tzoffsetfrom"></see>
    /// </summary>
    let tzoffsetfrom =
        Namespaced_IRI.parse _namespace_name "tzoffsetfrom" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#tzoffsetto"></see>
    /// </summary>
    let tzoffsetto = Namespaced_IRI.parse _namespace_name "tzoffsetto" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#value"></see>
    /// </summary>
    let value = Namespaced_IRI.parse _namespace_name "value" |> NamespacedName
