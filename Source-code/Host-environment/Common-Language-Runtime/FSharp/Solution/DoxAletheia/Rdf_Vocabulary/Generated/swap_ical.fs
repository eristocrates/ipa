namespace http.www.w3.org._2000._10.swap.pim.ical.hash

open DoxAletheia

module swap_ical =
    let _namespace_name = "http://www.w3.org/2000/10/swap/pim/ical#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#Vcalendar"></see>
    /// </summary>
    let Vcalendar = _prefix "Vcalendar"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#Vevent"></see>
    /// </summary>
    let Vevent = _prefix "Vevent"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#Vtimezone"></see>
    /// </summary>
    let Vtimezone = _prefix "Vtimezone"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#Vtodo"></see>
    /// </summary>
    let Vtodo = _prefix "Vtodo"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#calscale"></see>
    /// </summary>
    let calscale = _prefix "calscale"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#prodid"></see>
    /// </summary>
    let prodid = _prefix "prodid"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#version"></see>
    /// </summary>
    let version = _prefix "version"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#attendee"></see>
    /// </summary>
    let attendee = _prefix "attendee"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#categories"></see>
    /// </summary>
    let categories = _prefix "categories"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#class"></see>
    /// </summary>
    let class_ = _prefix "class"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#description"></see>
    /// </summary>
    let description = _prefix "description"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#dtend"></see>
    /// </summary>
    let dtend = _prefix "dtend"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#dtstamp"></see>
    /// </summary>
    let dtstamp = _prefix "dtstamp"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#dtstart"></see>
    /// </summary>
    let dtstart = _prefix "dtstart"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#location"></see>
    /// </summary>
    let location = _prefix "location"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#organizer"></see>
    /// </summary>
    let organizer = _prefix "organizer"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#rrule"></see>
    /// </summary>
    let rrule = _prefix "rrule"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#sequence"></see>
    /// </summary>
    let sequence = _prefix "sequence"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#summary"></see>
    /// </summary>
    let summary = _prefix "summary"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#transp"></see>
    /// </summary>
    let transp = _prefix "transp"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#uid"></see>
    /// </summary>
    let uid = _prefix "uid"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#valarm"></see>
    /// </summary>
    let valarm = _prefix "valarm"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#daylight"></see>
    /// </summary>
    let daylight = _prefix "daylight"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#standard"></see>
    /// </summary>
    let standard = _prefix "standard"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#tzid"></see>
    /// </summary>
    let tzid = _prefix "tzid"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#percentComplete"></see>
    /// </summary>
    let percentComplete = _prefix "percentComplete"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#priority"></see>
    /// </summary>
    let priority = _prefix "priority"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#status"></see>
    /// </summary>
    let status = _prefix "status"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#action"></see>
    /// </summary>
    let action = _prefix "action"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#byday"></see>
    /// </summary>
    let byday = _prefix "byday"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#bymonth"></see>
    /// </summary>
    let bymonth = _prefix "bymonth"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#cn"></see>
    /// </summary>
    let cn = _prefix "cn"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#cutype"></see>
    /// </summary>
    let cutype = _prefix "cutype"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#date"></see>
    /// </summary>
    let date = _prefix "date"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#duration"></see>
    /// </summary>
    let duration = _prefix "duration"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#freq"></see>
    /// </summary>
    let freq = _prefix "freq"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#interval"></see>
    /// </summary>
    let interval = _prefix "interval"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#language"></see>
    /// </summary>
    let language = _prefix "language"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#partstat"></see>
    /// </summary>
    let partstat = _prefix "partstat"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#related"></see>
    /// </summary>
    let related = _prefix "related"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#role"></see>
    /// </summary>
    let role = _prefix "role"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#rsvp"></see>
    /// </summary>
    let rsvp = _prefix "rsvp"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#trigger"></see>
    /// </summary>
    let trigger = _prefix "trigger"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#tzname"></see>
    /// </summary>
    let tzname = _prefix "tzname"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#tzoffsetfrom"></see>
    /// </summary>
    let tzoffsetfrom = _prefix "tzoffsetfrom"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#tzoffsetto"></see>
    /// </summary>
    let tzoffsetto = _prefix "tzoffsetto"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/pim/ical#value"></see>
    /// </summary>
    let value = _prefix "value"
