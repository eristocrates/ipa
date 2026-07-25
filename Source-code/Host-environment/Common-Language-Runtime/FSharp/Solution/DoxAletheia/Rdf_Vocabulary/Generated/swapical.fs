namespace http.www.w3.org._2000._10.swap.pim.ical.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swapical =
    let _namespace_iri = Namespace_Iri swapical |> NamespaceIRI
    /// <summary>
    ///   <para>swapical:Vevent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#Vevent">http://www.w3.org/2000/10/swap/pim/ical#Vevent</seealso>
    let Vevent = Prefixed_Name(swapical, "Vevent") |> PrefixedName
    /// <summary>
    ///   <para>swapical:dtstamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#dtstamp">http://www.w3.org/2000/10/swap/pim/ical#dtstamp</seealso>
    let dtstamp = Prefixed_Name(swapical, "dtstamp") |> PrefixedName
    /// <summary>
    ///   <para>swapical:transp</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#transp">http://www.w3.org/2000/10/swap/pim/ical#transp</seealso>
    let transp = Prefixed_Name(swapical, "transp") |> PrefixedName
    /// <summary>
    ///   <para>swapical:standard</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#standard">http://www.w3.org/2000/10/swap/pim/ical#standard</seealso>
    let standard = Prefixed_Name(swapical, "standard") |> PrefixedName
    /// <summary>
    ///   <para>swapical:Vcalendar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#Vcalendar">http://www.w3.org/2000/10/swap/pim/ical#Vcalendar</seealso>
    let Vcalendar = Prefixed_Name(swapical, "Vcalendar") |> PrefixedName
    /// <summary>
    ///   <para>swapical:calscale</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#calscale">http://www.w3.org/2000/10/swap/pim/ical#calscale</seealso>
    let calscale = Prefixed_Name(swapical, "calscale") |> PrefixedName
    /// <summary>
    ///   <para>swapical:attendee</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#attendee">http://www.w3.org/2000/10/swap/pim/ical#attendee</seealso>
    let attendee = Prefixed_Name(swapical, "attendee") |> PrefixedName
    /// <summary>
    ///   <para>swapical:class</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#class">http://www.w3.org/2000/10/swap/pim/ical#class</seealso>
    let class_ = Prefixed_Name(swapical, "class") |> PrefixedName
    /// <summary>
    ///   <para>swapical:dtstart</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#dtstart">http://www.w3.org/2000/10/swap/pim/ical#dtstart</seealso>
    let dtstart = Prefixed_Name(swapical, "dtstart") |> PrefixedName
    /// <summary>
    ///   <para>swapical:rrule</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#rrule">http://www.w3.org/2000/10/swap/pim/ical#rrule</seealso>
    let rrule = Prefixed_Name(swapical, "rrule") |> PrefixedName
    /// <summary>
    ///   <para>swapical:sequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#sequence">http://www.w3.org/2000/10/swap/pim/ical#sequence</seealso>
    let sequence = Prefixed_Name(swapical, "sequence") |> PrefixedName
    /// <summary>
    ///   <para>swapical:daylight</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#daylight">http://www.w3.org/2000/10/swap/pim/ical#daylight</seealso>
    let daylight = Prefixed_Name(swapical, "daylight") |> PrefixedName
    /// <summary>
    ///   <para>swapical:percentComplete</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#percentComplete">http://www.w3.org/2000/10/swap/pim/ical#percentComplete</seealso>
    let percentComplete = Prefixed_Name(swapical, "percentComplete") |> PrefixedName
    /// <summary>
    ///   <para>swapical:priority</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#priority">http://www.w3.org/2000/10/swap/pim/ical#priority</seealso>
    let priority = Prefixed_Name(swapical, "priority") |> PrefixedName
    /// <summary>
    ///   <para>swapical:Vtodo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#Vtodo">http://www.w3.org/2000/10/swap/pim/ical#Vtodo</seealso>
    let Vtodo = Prefixed_Name(swapical, "Vtodo") |> PrefixedName
    /// <summary>
    ///   <para>swapical:prodid</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#prodid">http://www.w3.org/2000/10/swap/pim/ical#prodid</seealso>
    let prodid = Prefixed_Name(swapical, "prodid") |> PrefixedName
    /// <summary>
    ///   <para>swapical:version</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#version">http://www.w3.org/2000/10/swap/pim/ical#version</seealso>
    let version = Prefixed_Name(swapical, "version") |> PrefixedName
    /// <summary>
    ///   <para>swapical:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#description">http://www.w3.org/2000/10/swap/pim/ical#description</seealso>
    let description = Prefixed_Name(swapical, "description") |> PrefixedName
    /// <summary>
    ///   <para>swapical:organizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#organizer">http://www.w3.org/2000/10/swap/pim/ical#organizer</seealso>
    let organizer = Prefixed_Name(swapical, "organizer") |> PrefixedName
    /// <summary>
    ///   <para>swapical:summary</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#summary">http://www.w3.org/2000/10/swap/pim/ical#summary</seealso>
    let summary = Prefixed_Name(swapical, "summary") |> PrefixedName
    /// <summary>
    ///   <para>swapical:valarm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#valarm">http://www.w3.org/2000/10/swap/pim/ical#valarm</seealso>
    let valarm = Prefixed_Name(swapical, "valarm") |> PrefixedName
    /// <summary>
    ///   <para>swapical:tzid</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#tzid">http://www.w3.org/2000/10/swap/pim/ical#tzid</seealso>
    let tzid = Prefixed_Name(swapical, "tzid") |> PrefixedName
    /// <summary>
    ///   <para>swapical:action</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#action">http://www.w3.org/2000/10/swap/pim/ical#action</seealso>
    let action = Prefixed_Name(swapical, "action") |> PrefixedName
    /// <summary>
    ///   <para>swapical:dtend</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#dtend">http://www.w3.org/2000/10/swap/pim/ical#dtend</seealso>
    let dtend = Prefixed_Name(swapical, "dtend") |> PrefixedName
    /// <summary>
    ///   <para>swapical:uid</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#uid">http://www.w3.org/2000/10/swap/pim/ical#uid</seealso>
    let uid = Prefixed_Name(swapical, "uid") |> PrefixedName
    /// <summary>
    ///   <para>swapical:status</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#status">http://www.w3.org/2000/10/swap/pim/ical#status</seealso>
    let status = Prefixed_Name(swapical, "status") |> PrefixedName
    /// <summary>
    ///   <para>swapical:categories</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#categories">http://www.w3.org/2000/10/swap/pim/ical#categories</seealso>
    let categories = Prefixed_Name(swapical, "categories") |> PrefixedName
    /// <summary>
    ///   <para>swapical:location</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#location">http://www.w3.org/2000/10/swap/pim/ical#location</seealso>
    let location = Prefixed_Name(swapical, "location") |> PrefixedName
    /// <summary>
    ///   <para>swapical:cn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#cn">http://www.w3.org/2000/10/swap/pim/ical#cn</seealso>
    let cn = Prefixed_Name(swapical, "cn") |> PrefixedName
    /// <summary>
    ///   <para>swapical:byday</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#byday">http://www.w3.org/2000/10/swap/pim/ical#byday</seealso>
    let byday = Prefixed_Name(swapical, "byday") |> PrefixedName
    /// <summary>
    ///   <para>swapical:bymonth</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#bymonth">http://www.w3.org/2000/10/swap/pim/ical#bymonth</seealso>
    let bymonth = Prefixed_Name(swapical, "bymonth") |> PrefixedName
    /// <summary>
    ///   <para>swapical:date</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#date">http://www.w3.org/2000/10/swap/pim/ical#date</seealso>
    let date = Prefixed_Name(swapical, "date") |> PrefixedName
    /// <summary>
    ///   <para>swapical:interval</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#interval">http://www.w3.org/2000/10/swap/pim/ical#interval</seealso>
    let interval = Prefixed_Name(swapical, "interval") |> PrefixedName
    /// <summary>
    ///   <para>swapical:cutype</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#cutype">http://www.w3.org/2000/10/swap/pim/ical#cutype</seealso>
    let cutype = Prefixed_Name(swapical, "cutype") |> PrefixedName
    /// <summary>
    ///   <para>swapical:freq</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#freq">http://www.w3.org/2000/10/swap/pim/ical#freq</seealso>
    let freq = Prefixed_Name(swapical, "freq") |> PrefixedName
    /// <summary>
    ///   <para>swapical:rsvp</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#rsvp">http://www.w3.org/2000/10/swap/pim/ical#rsvp</seealso>
    let rsvp = Prefixed_Name(swapical, "rsvp") |> PrefixedName
    /// <summary>
    ///   <para>swapical:related</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#related">http://www.w3.org/2000/10/swap/pim/ical#related</seealso>
    let related = Prefixed_Name(swapical, "related") |> PrefixedName
    /// <summary>
    ///   <para>swapical:trigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#trigger">http://www.w3.org/2000/10/swap/pim/ical#trigger</seealso>
    let trigger = Prefixed_Name(swapical, "trigger") |> PrefixedName
    /// <summary>
    ///   <para>swapical:tzoffsetfrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#tzoffsetfrom">http://www.w3.org/2000/10/swap/pim/ical#tzoffsetfrom</seealso>
    let tzoffsetfrom = Prefixed_Name(swapical, "tzoffsetfrom") |> PrefixedName
    /// <summary>
    ///   <para>swapical:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#value">http://www.w3.org/2000/10/swap/pim/ical#value</seealso>
    let value = Prefixed_Name(swapical, "value") |> PrefixedName
    /// <summary>
    ///   <para>swapical:tzname</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#tzname">http://www.w3.org/2000/10/swap/pim/ical#tzname</seealso>
    let tzname = Prefixed_Name(swapical, "tzname") |> PrefixedName
    /// <summary>
    ///   <para>swapical:tzoffsetto</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#tzoffsetto">http://www.w3.org/2000/10/swap/pim/ical#tzoffsetto</seealso>
    let tzoffsetto = Prefixed_Name(swapical, "tzoffsetto") |> PrefixedName
    /// <summary>
    ///   <para>swapical:Vtimezone</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#Vtimezone">http://www.w3.org/2000/10/swap/pim/ical#Vtimezone</seealso>
    let Vtimezone = Prefixed_Name(swapical, "Vtimezone") |> PrefixedName
    /// <summary>
    ///   <para>swapical:duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#duration">http://www.w3.org/2000/10/swap/pim/ical#duration</seealso>
    let duration = Prefixed_Name(swapical, "duration") |> PrefixedName
    /// <summary>
    ///   <para>swapical:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#language">http://www.w3.org/2000/10/swap/pim/ical#language</seealso>
    let language = Prefixed_Name(swapical, "language") |> PrefixedName
    /// <summary>
    ///   <para>swapical:partstat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#partstat">http://www.w3.org/2000/10/swap/pim/ical#partstat</seealso>
    let partstat = Prefixed_Name(swapical, "partstat") |> PrefixedName
    /// <summary>
    ///   <para>swapical:role</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/ical#role">http://www.w3.org/2000/10/swap/pim/ical#role</seealso>
    let role = Prefixed_Name(swapical, "role") |> PrefixedName
