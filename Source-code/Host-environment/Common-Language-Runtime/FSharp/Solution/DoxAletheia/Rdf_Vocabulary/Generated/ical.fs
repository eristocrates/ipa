namespace http.www.w3.org._2002._12.cal.ical.hash

open DoxAletheia.Rdf_Vocabulary

module ical =
    let _namespace_name = "http://www.w3.org/2002/12/cal/ical#"

    /// <summary>
    ///   <see href="http://www.w3.org/2002/12/cal/ical#DomainOf_rrule"></see>
    /// </summary>
    let DomainOf_rrule =
        Namespaced_IRI.parse _namespace_name "DomainOf_rrule" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2002/12/cal/ical#List_of_Float"></see>
    /// </summary>
    let List_of_Float =
        Namespaced_IRI.parse _namespace_name "List_of_Float" |> NamespacedName

    /// <summary>
    /// Provide a grouping of component properties that define an alarm.
    /// <see href="http://www.w3.org/2002/12/cal/ical#Valarm"></see></summary>
    let Valarm = Namespaced_IRI.parse _namespace_name "Valarm" |> NamespacedName
    /// <summary>
    /// The property defines an "Attendee" within a calendar component.
    ///
    /// 	    value type: CAL-ADDRESS
    /// <see href="http://www.w3.org/2002/12/cal/ical#attendee"></see></summary>
    let attendee = Namespaced_IRI.parse _namespace_name "attendee" |> NamespacedName
    /// <summary>
    /// This property defines the action to be invoked when an alarm is triggered.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#action"></see></summary>
    let action = Namespaced_IRI.parse _namespace_name "action" |> NamespacedName
    /// <summary>
    /// The property specifies a positive duration of time.
    ///
    /// 	    value type: DURATION
    /// <see href="http://www.w3.org/2002/12/cal/ical#duration"></see></summary>
    let duration = Namespaced_IRI.parse _namespace_name "duration" |> NamespacedName

    /// <summary>
    /// This property provides a more complete description of the calendar component, than that provided by the "SUMMARY" property.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#description"></see></summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    /// This property defines a short summary or subject for the calendar component.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#summary"></see></summary>
    let summary = Namespaced_IRI.parse _namespace_name "summary" |> NamespacedName
    /// <summary>
    /// This property defines the number of time the alarm should be repeated, after the initial trigger.
    ///
    /// 	    value type: INTEGER
    /// <see href="http://www.w3.org/2002/12/cal/ical#repeat"></see></summary>
    let repeat = Namespaced_IRI.parse _namespace_name "repeat" |> NamespacedName
    /// <summary>
    /// The property provides the capability to associate a document object with a calendar component.
    ///
    /// 	    default value type: URI
    /// <see href="http://www.w3.org/2002/12/cal/ical#attach"></see></summary>
    let attach = Namespaced_IRI.parse _namespace_name "attach" |> NamespacedName
    /// <summary>
    /// This property specifies when an alarm will trigger.
    ///
    /// 	    default value type: DURATION
    /// <see href="http://www.w3.org/2002/12/cal/ical#trigger"></see></summary>
    let trigger = Namespaced_IRI.parse _namespace_name "trigger" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2002/12/cal/ical#Value_CAL-ADDRESS"></see>
    /// </summary>
    let ``Value_CAL-ADDRESS`` =
        Namespaced_IRI.parse _namespace_name "Value_CAL-ADDRESS" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2002/12/cal/ical#Value_DATE"></see>
    /// </summary>
    let Value_DATE = Namespaced_IRI.parse _namespace_name "Value_DATE" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2002/12/cal/ical#Value_DATE-TIME"></see>
    /// </summary>
    let ``Value_DATE-TIME`` =
        Namespaced_IRI.parse _namespace_name "Value_DATE-TIME" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2002/12/cal/ical#Value_DURATION"></see>
    /// </summary>
    let Value_DURATION =
        Namespaced_IRI.parse _namespace_name "Value_DURATION" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2002/12/cal/ical#Value_PERIOD"></see>
    /// </summary>
    let Value_PERIOD =
        Namespaced_IRI.parse _namespace_name "Value_PERIOD" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2002/12/cal/ical#Value_RECUR"></see>
    /// </summary>
    let Value_RECUR =
        Namespaced_IRI.parse _namespace_name "Value_RECUR" |> NamespacedName

    /// <summary>
    /// Provide a grouping of component properties that describe an event.
    /// <see href="http://www.w3.org/2002/12/cal/ical#Vevent"></see></summary>
    let Vevent = Namespaced_IRI.parse _namespace_name "Vevent" |> NamespacedName
    /// <summary>
    /// This property specifies the date and time that a calendar component ends.
    ///
    /// 	    default value type: DATE-TIME
    /// <see href="http://www.w3.org/2002/12/cal/ical#dtend"></see></summary>
    let dtend = Namespaced_IRI.parse _namespace_name "dtend" |> NamespacedName
    /// <summary>
    /// The property defines the organizer for a calendar component.
    ///
    /// 	    value type: CAL-ADDRESS
    /// <see href="http://www.w3.org/2002/12/cal/ical#organizer"></see></summary>
    let organizer = Namespaced_IRI.parse _namespace_name "organizer" |> NamespacedName
    /// <summary>
    /// This property defines whether an event is transparent or not to busy time searches.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#transp"></see></summary>
    let transp = Namespaced_IRI.parse _namespace_name "transp" |> NamespacedName

    /// <summary>
    /// The property specifies the date and time that the information associated with the calendar component was last revised in the calendar store. Note: This is analogous to the modification date and time for a file in the file system.
    ///
    /// 	    value type: DATE-TIME
    /// <see href="http://www.w3.org/2002/12/cal/ical#lastModified"></see></summary>
    let lastModified =
        Namespaced_IRI.parse _namespace_name "lastModified" |> NamespacedName

    /// <summary>
    /// This property defines the revision sequence number of the calendar component within a sequence of revisions.
    ///
    /// 	    value type: integer
    /// <see href="http://www.w3.org/2002/12/cal/ical#sequence"></see></summary>
    let sequence = Namespaced_IRI.parse _namespace_name "sequence" |> NamespacedName
    /// <summary>
    /// This property defines the list of date/times for a recurrence set.
    ///
    /// 	    default value type: DATE-TIME
    /// <see href="http://www.w3.org/2002/12/cal/ical#rdate"></see></summary>
    let rdate = Namespaced_IRI.parse _namespace_name "rdate" |> NamespacedName

    /// <summary>
    /// This property defines the status code returned for a scheduling request.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#requestStatus"></see></summary>
    let requestStatus =
        Namespaced_IRI.parse _namespace_name "requestStatus" |> NamespacedName

    /// <summary>
    /// This property defines a rule or repeating pattern for recurring events, to-dos, or time zone definitions.
    ///
    /// 	    value type: RECUR
    /// <see href="http://www.w3.org/2002/12/cal/ical#rrule"></see></summary>
    let rrule = Namespaced_IRI.parse _namespace_name "rrule" |> NamespacedName
    /// <summary>
    /// The property defines the relative priority for a calendar component.
    ///
    /// 	    value type: INTEGER
    /// <see href="http://www.w3.org/2002/12/cal/ical#priority"></see></summary>
    let priority = Namespaced_IRI.parse _namespace_name "priority" |> NamespacedName
    /// <summary>
    /// The property is used to represent contact information or alternately a reference to contact information associated with the calendar component.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#contact"></see></summary>
    let contact = Namespaced_IRI.parse _namespace_name "contact" |> NamespacedName
    /// <summary>
    /// This property defines a rule or repeating pattern for an exception to a recurrence set.
    ///
    /// 	    value type: RECUR
    /// <see href="http://www.w3.org/2002/12/cal/ical#exrule"></see></summary>
    let exrule = Namespaced_IRI.parse _namespace_name "exrule" |> NamespacedName
    /// <summary>
    /// This property defines a Uniform Resource Locator (URL) associated with the iCalendar object.
    ///
    /// 	    value type: URI
    /// <see href="http://www.w3.org/2002/12/cal/ical#url"></see></summary>
    let url = Namespaced_IRI.parse _namespace_name "url" |> NamespacedName
    /// <summary>
    /// This property specifies non-processing information intended to provide a comment to the calendar user.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#comment"></see></summary>
    let comment = Namespaced_IRI.parse _namespace_name "comment" |> NamespacedName
    /// <summary>
    /// The property indicates the date/time that the instance of the iCalendar object was created.
    ///
    /// 	    value type: DATE-TIME
    /// <see href="http://www.w3.org/2002/12/cal/ical#dtstamp"></see></summary>
    let dtstamp = Namespaced_IRI.parse _namespace_name "dtstamp" |> NamespacedName
    /// <summary>
    /// This property defines the list of date/time exceptions for a recurring calendar component.
    ///
    /// 	    default value type: DATE-TIME
    /// <see href="http://www.w3.org/2002/12/cal/ical#exdate"></see></summary>
    let exdate = Namespaced_IRI.parse _namespace_name "exdate" |> NamespacedName
    /// <summary>
    /// This property defines the access classification for a calendar component.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#class"></see></summary>
    let class_ = Namespaced_IRI.parse _namespace_name "class" |> NamespacedName
    /// <summary>
    /// The property is used to represent a relationship or reference between one calendar component and another.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#relatedTo"></see></summary>
    let relatedTo = Namespaced_IRI.parse _namespace_name "relatedTo" |> NamespacedName
    /// <summary>
    /// This property defines the categories for a calendar component.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#categories"></see></summary>
    let categories = Namespaced_IRI.parse _namespace_name "categories" |> NamespacedName
    /// <summary>
    /// This property specifies the date and time that the calendar information was created by the calendar user agent in the calendar store. Note: This is analogous to the creation date and time for a file in the file system.
    ///
    /// 	    value type: DATE-TIME
    /// <see href="http://www.w3.org/2002/12/cal/ical#created"></see></summary>
    let created = Namespaced_IRI.parse _namespace_name "created" |> NamespacedName
    /// <summary>
    /// This property specifies information related to the global position for the activity specified by a calendar component.
    ///
    /// 	    value type: list of FLOAT
    /// <see href="http://www.w3.org/2002/12/cal/ical#geo"></see></summary>
    let geo = Namespaced_IRI.parse _namespace_name "geo" |> NamespacedName
    /// <summary>
    /// This property specifies when the calendar component begins.
    ///
    /// 	    default value type: DATE-TIME
    /// <see href="http://www.w3.org/2002/12/cal/ical#dtstart"></see></summary>
    let dtstart = Namespaced_IRI.parse _namespace_name "dtstart" |> NamespacedName
    /// <summary>
    /// The property defines the intended venue for the activity defined by a calendar component.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#location"></see></summary>
    let location = Namespaced_IRI.parse _namespace_name "location" |> NamespacedName
    /// <summary>
    /// This property defines the equipment or resources anticipated for an activity specified by a calendar entity..
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#resources"></see></summary>
    let resources = Namespaced_IRI.parse _namespace_name "resources" |> NamespacedName
    /// <summary>
    /// This property defines the overall status or confirmation for the calendar component.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#status"></see></summary>
    let status = Namespaced_IRI.parse _namespace_name "status" |> NamespacedName
    /// <summary>
    /// This property defines the persistent, globally unique identifier for the calendar component.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#uid"></see></summary>
    let uid = Namespaced_IRI.parse _namespace_name "uid" |> NamespacedName

    /// <summary>
    /// This property is used in conjunction with the "UID" and "SEQUENCE" property to identify a specific instance of a recurring "VEVENT", "VTODO" or "VJOURNAL" calendar component. The property value is the effective value of the "DTSTART" property of the recurrence instance.
    ///
    /// 	    default value type: DATE-TIME
    /// <see href="http://www.w3.org/2002/12/cal/ical#recurrenceId"></see></summary>
    let recurrenceId =
        Namespaced_IRI.parse _namespace_name "recurrenceId" |> NamespacedName

    /// <summary>
    /// Provide a grouping of component properties that describe either a request for free/busy time, describe a response to a request for free/busy time or describe a published set of busy time.
    /// <see href="http://www.w3.org/2002/12/cal/ical#Vfreebusy"></see></summary>
    let Vfreebusy = Namespaced_IRI.parse _namespace_name "Vfreebusy" |> NamespacedName
    /// <summary>
    /// The property defines one or more free or busy time intervals.
    ///
    /// 	    value type: PERIOD
    /// <see href="http://www.w3.org/2002/12/cal/ical#freebusy"></see></summary>
    let freebusy = Namespaced_IRI.parse _namespace_name "freebusy" |> NamespacedName
    /// <summary>
    /// Provide a grouping of component properties that describe a journal entry.
    /// <see href="http://www.w3.org/2002/12/cal/ical#Vjournal"></see></summary>
    let Vjournal = Namespaced_IRI.parse _namespace_name "Vjournal" |> NamespacedName
    /// <summary>
    /// Provide a grouping of component properties that defines a time zone.
    /// <see href="http://www.w3.org/2002/12/cal/ical#Vtimezone"></see></summary>
    let Vtimezone = Namespaced_IRI.parse _namespace_name "Vtimezone" |> NamespacedName
    /// <summary>
    /// This property specifies the text value that uniquely identifies the "VTIMEZONE" calendar component.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#tzid"></see></summary>
    let tzid = Namespaced_IRI.parse _namespace_name "tzid" |> NamespacedName
    /// <summary>
    /// This property specifies the offset which is in use in this time zone observance.
    ///
    /// 	    value type: UTC-OFFSET
    /// <see href="http://www.w3.org/2002/12/cal/ical#tzoffsetto"></see></summary>
    let tzoffsetto = Namespaced_IRI.parse _namespace_name "tzoffsetto" |> NamespacedName
    /// <summary>
    /// The TZURL provides a means for a VTIMEZONE component to point to a network location that can be used to retrieve an up-to- date version of itself.
    ///
    /// 	    value type: URI
    /// <see href="http://www.w3.org/2002/12/cal/ical#tzurl"></see></summary>
    let tzurl = Namespaced_IRI.parse _namespace_name "tzurl" |> NamespacedName

    /// <summary>
    /// This property specifies the offset which is in use prior to this time zone observance.
    ///
    /// 	    value type: UTC-OFFSET
    /// <see href="http://www.w3.org/2002/12/cal/ical#tzoffsetfrom"></see></summary>
    let tzoffsetfrom =
        Namespaced_IRI.parse _namespace_name "tzoffsetfrom" |> NamespacedName

    /// <summary>
    /// This property specifies the customary designation for a time zone description.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#tzname"></see></summary>
    let tzname = Namespaced_IRI.parse _namespace_name "tzname" |> NamespacedName
    /// <summary>
    /// Provide a grouping of calendar properties that describe a to-do.
    /// <see href="http://www.w3.org/2002/12/cal/ical#Vtodo"></see></summary>
    let Vtodo = Namespaced_IRI.parse _namespace_name "Vtodo" |> NamespacedName
    /// <summary>
    /// This property defines the date and time that a to-do was actually completed.
    ///
    /// 	    value type: DATE-TIME
    /// <see href="http://www.w3.org/2002/12/cal/ical#completed"></see></summary>
    let completed = Namespaced_IRI.parse _namespace_name "completed" |> NamespacedName

    /// <summary>
    /// This property is used by an assignee or delegatee of a to-do to convey the percent completion of a to-do to the Organizer.
    ///
    /// 	    value type: INTEGER
    /// <see href="http://www.w3.org/2002/12/cal/ical#percentComplete"></see></summary>
    let percentComplete =
        Namespaced_IRI.parse _namespace_name "percentComplete" |> NamespacedName

    /// <summary>
    /// This property defines the date and time that a to-do is expected to be completed.
    ///
    /// 	    default value type: DATE-TIME
    /// <see href="http://www.w3.org/2002/12/cal/ical#due"></see></summary>
    let due = Namespaced_IRI.parse _namespace_name "due" |> NamespacedName
    /// <summary>
    /// This class of property provides a framework for defining non-standard properties.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#X-"></see></summary>
    let ``X-`` = Namespaced_IRI.parse _namespace_name "X-" |> NamespacedName
    /// <summary>
    /// This property defines the calendar scale used for the calendar information specified in the iCalendar object.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#calscale"></see></summary>
    let calscale = Namespaced_IRI.parse _namespace_name "calscale" |> NamespacedName
    /// <summary>
    /// This property defines the iCalendar object method associated with the calendar object.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#method"></see></summary>
    let method = Namespaced_IRI.parse _namespace_name "method" |> NamespacedName
    /// <summary>
    /// This property specifies the identifier for the product that created the iCalendar object.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#prodid"></see></summary>
    let prodid = Namespaced_IRI.parse _namespace_name "prodid" |> NamespacedName
    /// <summary>
    /// This property specifies the identifier corresponding to the highest version number or the minimum and maximum range of the iCalendar specification that is required in order to interpret the iCalendar object.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#version"></see></summary>
    let version = Namespaced_IRI.parse _namespace_name "version" |> NamespacedName
