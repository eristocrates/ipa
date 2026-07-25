namespace http.www.w3.org._2002._12.cal.ical.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ical =
    let _namespace_iri = Namespace_Iri ical |> NamespaceIRI
    /// <summary>
    ///   <para>ical:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    /// 	    value type: TEXT</para>
    ///   <para>This property provides a more complete description of the calendar component, than that provided by the "SUMMARY" property.</para>
    /// labels<para>DESCRIPTION</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#description">http://www.w3.org/2002/12/cal/ical#description</seealso>
    let description = Prefixed_Name(ical, "description") |> PrefixedName
    /// <summary>
    ///   <para>ical:dtstart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies when the calendar component begins.</para>
    ///   <para>
    /// 	    default value type: DATE-TIME</para>
    /// labels<para>DTSTART</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#dtstart">http://www.w3.org/2002/12/cal/ical#dtstart</seealso>
    let dtstart = Prefixed_Name(ical, "dtstart") |> PrefixedName
    /// <summary>
    ///   <para>ical:tzurl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 	    value type: URI</para>
    ///   <para>The TZURL provides a means for a VTIMEZONE component to point to a network location that can be used to retrieve an up-to- date version of itself.</para>
    /// labels<para>TZURL</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#tzurl">http://www.w3.org/2002/12/cal/ical#tzurl</seealso>
    let tzurl = Prefixed_Name(ical, "tzurl") |> PrefixedName
    /// <summary>
    ///   <para>ical:DomainOf_rrule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#DomainOf_rrule">http://www.w3.org/2002/12/cal/ical#DomainOf_rrule</seealso>
    let DomainOf_rrule = Prefixed_Name(ical, "DomainOf_rrule") |> PrefixedName
    /// <summary>
    ///   <para>ical:action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    /// 	    value type: TEXT</para>
    ///   <para>This property defines the action to be invoked when an alarm is triggered.</para>
    /// labels<para>ACTION</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#action">http://www.w3.org/2002/12/cal/ical#action</seealso>
    let action = Prefixed_Name(ical, "action") |> PrefixedName
    /// <summary>
    ///   <para>ical:percentComplete</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    /// 	    value type: INTEGER</para>
    ///   <para>This property is used by an assignee or delegatee of a to-do to convey the percent completion of a to-do to the Organizer.</para>
    /// labels<para>PERCENT-COMPLETE</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#percentComplete">http://www.w3.org/2002/12/cal/ical#percentComplete</seealso>
    let percentComplete = Prefixed_Name(ical, "percentComplete") |> PrefixedName
    /// <summary>
    ///   <para>ical:method</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property defines the iCalendar object method associated with the calendar object.</para>
    ///   <para>
    /// 	    value type: TEXT</para>
    /// labels<para>METHOD</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#method">http://www.w3.org/2002/12/cal/ical#method</seealso>
    let method = Prefixed_Name(ical, "method") |> PrefixedName
    /// <summary>
    ///   <para>ical:prodid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    /// 	    value type: TEXT</para>
    ///   <para>This property specifies the identifier for the product that created the iCalendar object.</para>
    /// labels<para>PRODID</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#prodid">http://www.w3.org/2002/12/cal/ical#prodid</seealso>
    let prodid = Prefixed_Name(ical, "prodid") |> PrefixedName
    /// <summary>
    ///   <para>ical:version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    /// 	    value type: TEXT</para>
    ///   <para>This property specifies the identifier corresponding to the highest version number or the minimum and maximum range of the iCalendar specification that is required in order to interpret the iCalendar object.</para>
    /// labels<para>VERSION</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#version">http://www.w3.org/2002/12/cal/ical#version</seealso>
    let version = Prefixed_Name(ical, "version") |> PrefixedName
    /// <summary>
    ///   <para>ical:Valarm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Provide a grouping of component properties that define an alarm.</para>
    /// labels<para>VALARM</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#Valarm">http://www.w3.org/2002/12/cal/ical#Valarm</seealso>
    let Valarm = Prefixed_Name(ical, "Valarm") |> PrefixedName
    /// <summary>
    ///   <para>ical:attendee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 	    value type: CAL-ADDRESS</para>
    ///   <para>The property defines an "Attendee" within a calendar component.</para>
    /// labels<para>ATTENDEE</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#attendee">http://www.w3.org/2002/12/cal/ical#attendee</seealso>
    let attendee = Prefixed_Name(ical, "attendee") |> PrefixedName
    /// <summary>
    ///   <para>ical:summary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property defines a short summary or subject for the calendar component.</para>
    ///   <para>
    /// 	    value type: TEXT</para>
    /// labels<para>SUMMARY</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#summary">http://www.w3.org/2002/12/cal/ical#summary</seealso>
    let summary = Prefixed_Name(ical, "summary") |> PrefixedName
    /// <summary>
    ///   <para>ical:attach</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 	    default value type: URI</para>
    ///   <para>The property provides the capability to associate a document object with a calendar component.</para>
    /// labels<para>ATTACH</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#attach">http://www.w3.org/2002/12/cal/ical#attach</seealso>
    let attach = Prefixed_Name(ical, "attach") |> PrefixedName
    /// <summary>
    ///   <para>ical:Value_CAL-ADDRESS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#Value_CAL-ADDRESS">http://www.w3.org/2002/12/cal/ical#Value_CAL-ADDRESS</seealso>
    let Value_CAL_ADDRESS = Prefixed_Name(ical, "Value_CAL-ADDRESS") |> PrefixedName
    /// <summary>
    ///   <para>ical:Value_DATE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#Value_DATE">http://www.w3.org/2002/12/cal/ical#Value_DATE</seealso>
    let Value_DATE = Prefixed_Name(ical, "Value_DATE") |> PrefixedName
    /// <summary>
    ///   <para>ical:Value_DURATION</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#Value_DURATION">http://www.w3.org/2002/12/cal/ical#Value_DURATION</seealso>
    let Value_DURATION = Prefixed_Name(ical, "Value_DURATION") |> PrefixedName
    /// <summary>
    ///   <para>ical:Value_PERIOD</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#Value_PERIOD">http://www.w3.org/2002/12/cal/ical#Value_PERIOD</seealso>
    let Value_PERIOD = Prefixed_Name(ical, "Value_PERIOD") |> PrefixedName
    /// <summary>
    ///   <para>ical:Vevent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Provide a grouping of component properties that describe an event.</para>
    /// labels<para>VEVENT</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#Vevent">http://www.w3.org/2002/12/cal/ical#Vevent</seealso>
    let Vevent = Prefixed_Name(ical, "Vevent") |> PrefixedName
    /// <summary>
    ///   <para>ical:organizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property defines the organizer for a calendar component.</para>
    ///   <para>
    /// 	    value type: CAL-ADDRESS</para>
    /// labels<para>ORGANIZER</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#organizer">http://www.w3.org/2002/12/cal/ical#organizer</seealso>
    let organizer = Prefixed_Name(ical, "organizer") |> PrefixedName
    /// <summary>
    ///   <para>ical:lastModified</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property specifies the date and time that the information associated with the calendar component was last revised in the calendar store. Note: This is analogous to the modification date and time for a file in the file system.</para>
    ///   <para>
    /// 	    value type: DATE-TIME</para>
    /// labels<para>LAST-MODIFIED</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#lastModified">http://www.w3.org/2002/12/cal/ical#lastModified</seealso>
    let lastModified = Prefixed_Name(ical, "lastModified") |> PrefixedName
    /// <summary>
    ///   <para>ical:requestStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property defines the status code returned for a scheduling request.</para>
    ///   <para>
    /// 	    value type: TEXT</para>
    /// labels<para>REQUEST-STATUS</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#requestStatus">http://www.w3.org/2002/12/cal/ical#requestStatus</seealso>
    let requestStatus = Prefixed_Name(ical, "requestStatus") |> PrefixedName
    /// <summary>
    ///   <para>ical:priority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The property defines the relative priority for a calendar component.</para>
    ///   <para>
    /// 	    value type: INTEGER</para>
    /// labels<para>PRIORITY</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#priority">http://www.w3.org/2002/12/cal/ical#priority</seealso>
    let priority = Prefixed_Name(ical, "priority") |> PrefixedName
    /// <summary>
    ///   <para>ical:exrule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property defines a rule or repeating pattern for an exception to a recurrence set.</para>
    ///   <para>
    /// 	    value type: RECUR</para>
    /// labels<para>EXRULE</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#exrule">http://www.w3.org/2002/12/cal/ical#exrule</seealso>
    let exrule = Prefixed_Name(ical, "exrule") |> PrefixedName
    /// <summary>
    ///   <para>ical:url</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property defines a Uniform Resource Locator (URL) associated with the iCalendar object.</para>
    ///   <para>
    /// 	    value type: URI</para>
    /// labels<para>URL</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#url">http://www.w3.org/2002/12/cal/ical#url</seealso>
    let url = Prefixed_Name(ical, "url") |> PrefixedName
    /// <summary>
    ///   <para>ical:X-</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This class of property provides a framework for defining non-standard properties.</para>
    ///   <para>
    /// 	    value type: TEXT</para>
    /// labels<para>Any property name with a "X-" prefix</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#X-">http://www.w3.org/2002/12/cal/ical#X-</seealso>
    let X_ = Prefixed_Name(ical, "X-") |> PrefixedName
    /// <summary>
    ///   <para>ical:comment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property specifies non-processing information intended to provide a comment to the calendar user.</para>
    ///   <para>
    /// 	    value type: TEXT</para>
    /// labels<para>COMMENT</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#comment">http://www.w3.org/2002/12/cal/ical#comment</seealso>
    let comment = Prefixed_Name(ical, "comment") |> PrefixedName
    /// <summary>
    ///   <para>ical:exdate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 	    default value type: DATE-TIME</para>
    ///   <para>This property defines the list of date/time exceptions for a recurring calendar component.</para>
    /// labels<para>EXDATE</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#exdate">http://www.w3.org/2002/12/cal/ical#exdate</seealso>
    let exdate = Prefixed_Name(ical, "exdate") |> PrefixedName
    /// <summary>
    ///   <para>ical:relatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    /// 	    value type: TEXT</para>
    ///   <para>The property is used to represent a relationship or reference between one calendar component and another.</para>
    /// labels<para>RELATED-TO</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#relatedTo">http://www.w3.org/2002/12/cal/ical#relatedTo</seealso>
    let relatedTo = Prefixed_Name(ical, "relatedTo") |> PrefixedName
    /// <summary>
    ///   <para>ical:created</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 	    value type: DATE-TIME</para>
    ///   <para>This property specifies the date and time that the calendar information was created by the calendar user agent in the calendar store. Note: This is analogous to the creation date and time for a file in the file system.</para>
    /// labels<para>CREATED</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#created">http://www.w3.org/2002/12/cal/ical#created</seealso>
    let created = Prefixed_Name(ical, "created") |> PrefixedName
    /// <summary>
    ///   <para>ical:location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The property defines the intended venue for the activity defined by a calendar component.</para>
    ///   <para>
    /// 	    value type: TEXT</para>
    /// labels<para>LOCATION</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#location">http://www.w3.org/2002/12/cal/ical#location</seealso>
    let location = Prefixed_Name(ical, "location") |> PrefixedName
    /// <summary>
    ///   <para>ical:uid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property defines the persistent, globally unique identifier for the calendar component.</para>
    ///   <para>
    /// 	    value type: TEXT</para>
    /// labels<para>UID</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#uid">http://www.w3.org/2002/12/cal/ical#uid</seealso>
    let uid = Prefixed_Name(ical, "uid") |> PrefixedName
    /// <summary>
    ///   <para>ical:freebusy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property defines one or more free or busy time intervals.</para>
    ///   <para>
    /// 	    value type: PERIOD</para>
    /// labels<para>FREEBUSY</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#freebusy">http://www.w3.org/2002/12/cal/ical#freebusy</seealso>
    let freebusy = Prefixed_Name(ical, "freebusy") |> PrefixedName
    /// <summary>
    ///   <para>ical:Vjournal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Provide a grouping of component properties that describe a journal entry.</para>
    /// labels<para>VJOURNAL</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#Vjournal">http://www.w3.org/2002/12/cal/ical#Vjournal</seealso>
    let Vjournal = Prefixed_Name(ical, "Vjournal") |> PrefixedName
    /// <summary>
    ///   <para>ical:Vtimezone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Provide a grouping of component properties that defines a time zone.</para>
    /// labels<para>VTIMEZONE</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#Vtimezone">http://www.w3.org/2002/12/cal/ical#Vtimezone</seealso>
    let Vtimezone = Prefixed_Name(ical, "Vtimezone") |> PrefixedName
    /// <summary>
    ///   <para>ical:tzid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property specifies the text value that uniquely identifies the "VTIMEZONE" calendar component.</para>
    ///   <para>
    /// 	    value type: TEXT</para>
    /// labels<para>TZID</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#tzid">http://www.w3.org/2002/12/cal/ical#tzid</seealso>
    let tzid = Prefixed_Name(ical, "tzid") |> PrefixedName
    /// <summary>
    ///   <para>ical:tzoffsetto</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property specifies the offset which is in use in this time zone observance.</para>
    ///   <para>
    /// 	    value type: UTC-OFFSET</para>
    /// labels<para>TZOFFSETTO</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#tzoffsetto">http://www.w3.org/2002/12/cal/ical#tzoffsetto</seealso>
    let tzoffsetto = Prefixed_Name(ical, "tzoffsetto") |> PrefixedName
    /// <summary>
    ///   <para>ical:tzoffsetfrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property specifies the offset which is in use prior to this time zone observance.</para>
    ///   <para>
    /// 	    value type: UTC-OFFSET</para>
    /// labels<para>TZOFFSETFROM</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#tzoffsetfrom">http://www.w3.org/2002/12/cal/ical#tzoffsetfrom</seealso>
    let tzoffsetfrom = Prefixed_Name(ical, "tzoffsetfrom") |> PrefixedName
    /// <summary>
    ///   <para>ical:tzname</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    /// 	    value type: TEXT</para>
    ///   <para>This property specifies the customary designation for a time zone description.</para>
    /// labels<para>TZNAME</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#tzname">http://www.w3.org/2002/12/cal/ical#tzname</seealso>
    let tzname = Prefixed_Name(ical, "tzname") |> PrefixedName
    /// <summary>
    ///   <para>ical:Vtodo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Provide a grouping of calendar properties that describe a to-do.</para>
    /// labels<para>VTODO</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#Vtodo">http://www.w3.org/2002/12/cal/ical#Vtodo</seealso>
    let Vtodo = Prefixed_Name(ical, "Vtodo") |> PrefixedName
    /// <summary>
    ///   <para>ical:completed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 	    value type: DATE-TIME</para>
    ///   <para>This property defines the date and time that a to-do was actually completed.</para>
    /// labels<para>COMPLETED</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#completed">http://www.w3.org/2002/12/cal/ical#completed</seealso>
    let completed = Prefixed_Name(ical, "completed") |> PrefixedName
    /// <summary>
    ///   <para>ical:due</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property defines the date and time that a to-do is expected to be completed.</para>
    ///   <para>
    /// 	    default value type: DATE-TIME</para>
    /// labels<para>DUE</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#due">http://www.w3.org/2002/12/cal/ical#due</seealso>
    let due = Prefixed_Name(ical, "due") |> PrefixedName
    /// <summary>
    ///   <para>ical:Value_DATE-TIME</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#Value_DATE-TIME">http://www.w3.org/2002/12/cal/ical#Value_DATE-TIME</seealso>
    let Value_DATE_TIME = Prefixed_Name(ical, "Value_DATE-TIME") |> PrefixedName
    /// <summary>
    ///   <para>ical:dtend</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies the date and time that a calendar component ends.</para>
    ///   <para>
    /// 	    default value type: DATE-TIME</para>
    /// labels<para>DTEND</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#dtend">http://www.w3.org/2002/12/cal/ical#dtend</seealso>
    let dtend = Prefixed_Name(ical, "dtend") |> PrefixedName
    /// <summary>
    ///   <para>ical:Value_RECUR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#Value_RECUR">http://www.w3.org/2002/12/cal/ical#Value_RECUR</seealso>
    let Value_RECUR = Prefixed_Name(ical, "Value_RECUR") |> PrefixedName
    /// <summary>
    ///   <para>ical:transp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property defines whether an event is transparent or not to busy time searches.</para>
    ///   <para>
    /// 	    value type: TEXT</para>
    /// labels<para>TRANSP</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#transp">http://www.w3.org/2002/12/cal/ical#transp</seealso>
    let transp = Prefixed_Name(ical, "transp") |> PrefixedName
    /// <summary>
    ///   <para>ical:sequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property defines the revision sequence number of the calendar component within a sequence of revisions.</para>
    ///   <para>
    /// 	    value type: integer</para>
    /// labels<para>SEQUENCE</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#sequence">http://www.w3.org/2002/12/cal/ical#sequence</seealso>
    let sequence = Prefixed_Name(ical, "sequence") |> PrefixedName
    /// <summary>
    ///   <para>ical:contact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The property is used to represent contact information or alternately a reference to contact information associated with the calendar component.</para>
    ///   <para>
    /// 	    value type: TEXT</para>
    /// labels<para>CONTACT</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#contact">http://www.w3.org/2002/12/cal/ical#contact</seealso>
    let contact = Prefixed_Name(ical, "contact") |> PrefixedName
    /// <summary>
    ///   <para>ical:dtstamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 	    value type: DATE-TIME</para>
    ///   <para>The property indicates the date/time that the instance of the iCalendar object was created.</para>
    /// labels<para>DTSTAMP</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#dtstamp">http://www.w3.org/2002/12/cal/ical#dtstamp</seealso>
    let dtstamp = Prefixed_Name(ical, "dtstamp") |> PrefixedName
    /// <summary>
    ///   <para>ical:class</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property defines the access classification for a calendar component.</para>
    ///   <para>
    /// 	    value type: TEXT</para>
    /// labels<para>CLASS</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#class">http://www.w3.org/2002/12/cal/ical#class</seealso>
    let class_ = Prefixed_Name(ical, "class") |> PrefixedName
    /// <summary>
    ///   <para>ical:categories</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    /// 	    value type: TEXT</para>
    ///   <para>This property defines the categories for a calendar component.</para>
    /// labels<para>CATEGORIES</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#categories">http://www.w3.org/2002/12/cal/ical#categories</seealso>
    let categories = Prefixed_Name(ical, "categories") |> PrefixedName
    /// <summary>
    ///   <para>ical:geo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 	    value type: list of FLOAT</para>
    ///   <para>This property specifies information related to the global position for the activity specified by a calendar component.</para>
    /// labels<para>GEO</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#geo">http://www.w3.org/2002/12/cal/ical#geo</seealso>
    let geo = Prefixed_Name(ical, "geo") |> PrefixedName
    /// <summary>
    ///   <para>ical:resources</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    /// 	    value type: TEXT</para>
    ///   <para>This property defines the equipment or resources anticipated for an activity specified by a calendar entity..</para>
    /// labels<para>RESOURCES</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#resources">http://www.w3.org/2002/12/cal/ical#resources</seealso>
    let resources = Prefixed_Name(ical, "resources") |> PrefixedName
    /// <summary>
    ///   <para>ical:status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    /// 	    value type: TEXT</para>
    ///   <para>This property defines the overall status or confirmation for the calendar component.</para>
    /// labels<para>STATUS</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#status">http://www.w3.org/2002/12/cal/ical#status</seealso>
    let status = Prefixed_Name(ical, "status") |> PrefixedName
    /// <summary>
    ///   <para>ical:recurrenceId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 	    default value type: DATE-TIME</para>
    ///   <para>This property is used in conjunction with the "UID" and "SEQUENCE" property to identify a specific instance of a recurring "VEVENT", "VTODO" or "VJOURNAL" calendar component. The property value is the effective value of the "DTSTART" property of the recurrence instance.</para>
    /// labels<para>RECURRENCE-ID</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#recurrenceId">http://www.w3.org/2002/12/cal/ical#recurrenceId</seealso>
    let recurrenceId = Prefixed_Name(ical, "recurrenceId") |> PrefixedName
    /// <summary>
    ///   <para>ical:Vfreebusy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Provide a grouping of component properties that describe either a request for free/busy time, describe a response to a request for free/busy time or describe a published set of busy time.</para>
    /// labels<para>VFREEBUSY</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#Vfreebusy">http://www.w3.org/2002/12/cal/ical#Vfreebusy</seealso>
    let Vfreebusy = Prefixed_Name(ical, "Vfreebusy") |> PrefixedName
    /// <summary>
    ///   <para>ical:rdate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 	    default value type: DATE-TIME</para>
    ///   <para>This property defines the list of date/times for a recurrence set.</para>
    /// labels<para>RDATE</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#rdate">http://www.w3.org/2002/12/cal/ical#rdate</seealso>
    let rdate = Prefixed_Name(ical, "rdate") |> PrefixedName
    /// <summary>
    ///   <para>ical:rrule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property defines a rule or repeating pattern for recurring events, to-dos, or time zone definitions.</para>
    ///   <para>
    /// 	    value type: RECUR</para>
    /// labels<para>RRULE</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#rrule">http://www.w3.org/2002/12/cal/ical#rrule</seealso>
    let rrule = Prefixed_Name(ical, "rrule") |> PrefixedName
    /// <summary>
    ///   <para>ical:List_of_Float</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#List_of_Float">http://www.w3.org/2002/12/cal/ical#List_of_Float</seealso>
    let List_of_Float = Prefixed_Name(ical, "List_of_Float") |> PrefixedName
    /// <summary>
    ///   <para>ical:duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property specifies a positive duration of time.</para>
    ///   <para>
    /// 	    value type: DURATION</para>
    /// labels<para>DURATION</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#duration">http://www.w3.org/2002/12/cal/ical#duration</seealso>
    let duration = Prefixed_Name(ical, "duration") |> PrefixedName
    /// <summary>
    ///   <para>ical:repeat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    /// 	    value type: INTEGER</para>
    ///   <para>This property defines the number of time the alarm should be repeated, after the initial trigger.</para>
    /// labels<para>REPEAT</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#repeat">http://www.w3.org/2002/12/cal/ical#repeat</seealso>
    let repeat = Prefixed_Name(ical, "repeat") |> PrefixedName
    /// <summary>
    ///   <para>ical:trigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 	    default value type: DURATION</para>
    ///   <para>This property specifies when an alarm will trigger.</para>
    /// labels<para>TRIGGER</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#trigger">http://www.w3.org/2002/12/cal/ical#trigger</seealso>
    let trigger = Prefixed_Name(ical, "trigger") |> PrefixedName
    /// <summary>
    ///   <para>ical:calscale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    /// 	    value type: TEXT</para>
    ///   <para>This property defines the calendar scale used for the calendar information specified in the iCalendar object.</para>
    /// labels<para>CALSCALE</para></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/ical#calscale">http://www.w3.org/2002/12/cal/ical#calscale</seealso>
    let calscale = Prefixed_Name(ical, "calscale") |> PrefixedName
