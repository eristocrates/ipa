namespace http.www.w3.org._2002._12.cal.ical.hash

open DoxAletheia

module ical =
    let _namespace_name = "http://www.w3.org/2002/12/cal/ical#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2002/12/cal/ical#DomainOf_rrule"></see>
    /// </summary>
    let DomainOf_rrule = _prefix "DomainOf_rrule"
    /// <summary>
    ///   <see href="http://www.w3.org/2002/12/cal/ical#List_of_Float"></see>
    /// </summary>
    let List_of_Float = _prefix "List_of_Float"
    /// <summary>
    /// Provide a grouping of component properties that define an alarm.
    /// <see href="http://www.w3.org/2002/12/cal/ical#Valarm"></see></summary>
    let Valarm = _prefix "Valarm"
    /// <summary>
    /// The property defines an "Attendee" within a calendar component.
    ///
    /// 	    value type: CAL-ADDRESS
    /// <see href="http://www.w3.org/2002/12/cal/ical#attendee"></see></summary>
    let attendee = _prefix "attendee"
    /// <summary>
    /// This property defines the action to be invoked when an alarm is triggered.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#action"></see></summary>
    let action = _prefix "action"
    /// <summary>
    /// The property specifies a positive duration of time.
    ///
    /// 	    value type: DURATION
    /// <see href="http://www.w3.org/2002/12/cal/ical#duration"></see></summary>
    let duration = _prefix "duration"
    /// <summary>
    /// This property provides a more complete description of the calendar component, than that provided by the "SUMMARY" property.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// This property defines a short summary or subject for the calendar component.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#summary"></see></summary>
    let summary = _prefix "summary"
    /// <summary>
    /// This property defines the number of time the alarm should be repeated, after the initial trigger.
    ///
    /// 	    value type: INTEGER
    /// <see href="http://www.w3.org/2002/12/cal/ical#repeat"></see></summary>
    let repeat = _prefix "repeat"
    /// <summary>
    /// The property provides the capability to associate a document object with a calendar component.
    ///
    /// 	    default value type: URI
    /// <see href="http://www.w3.org/2002/12/cal/ical#attach"></see></summary>
    let attach = _prefix "attach"
    /// <summary>
    /// This property specifies when an alarm will trigger.
    ///
    /// 	    default value type: DURATION
    /// <see href="http://www.w3.org/2002/12/cal/ical#trigger"></see></summary>
    let trigger = _prefix "trigger"
    /// <summary>
    ///   <see href="http://www.w3.org/2002/12/cal/ical#Value_CAL-ADDRESS"></see>
    /// </summary>
    let ``Value_CAL-ADDRESS`` = _prefix "Value_CAL-ADDRESS"
    /// <summary>
    ///   <see href="http://www.w3.org/2002/12/cal/ical#Value_DATE"></see>
    /// </summary>
    let Value_DATE = _prefix "Value_DATE"
    /// <summary>
    ///   <see href="http://www.w3.org/2002/12/cal/ical#Value_DATE-TIME"></see>
    /// </summary>
    let ``Value_DATE-TIME`` = _prefix "Value_DATE-TIME"
    /// <summary>
    ///   <see href="http://www.w3.org/2002/12/cal/ical#Value_DURATION"></see>
    /// </summary>
    let Value_DURATION = _prefix "Value_DURATION"
    /// <summary>
    ///   <see href="http://www.w3.org/2002/12/cal/ical#Value_PERIOD"></see>
    /// </summary>
    let Value_PERIOD = _prefix "Value_PERIOD"
    /// <summary>
    ///   <see href="http://www.w3.org/2002/12/cal/ical#Value_RECUR"></see>
    /// </summary>
    let Value_RECUR = _prefix "Value_RECUR"
    /// <summary>
    /// Provide a grouping of component properties that describe an event.
    /// <see href="http://www.w3.org/2002/12/cal/ical#Vevent"></see></summary>
    let Vevent = _prefix "Vevent"
    /// <summary>
    /// This property specifies the date and time that a calendar component ends.
    ///
    /// 	    default value type: DATE-TIME
    /// <see href="http://www.w3.org/2002/12/cal/ical#dtend"></see></summary>
    let dtend = _prefix "dtend"
    /// <summary>
    /// The property defines the organizer for a calendar component.
    ///
    /// 	    value type: CAL-ADDRESS
    /// <see href="http://www.w3.org/2002/12/cal/ical#organizer"></see></summary>
    let organizer = _prefix "organizer"
    /// <summary>
    /// This property defines whether an event is transparent or not to busy time searches.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#transp"></see></summary>
    let transp = _prefix "transp"
    /// <summary>
    /// The property specifies the date and time that the information associated with the calendar component was last revised in the calendar store. Note: This is analogous to the modification date and time for a file in the file system.
    ///
    /// 	    value type: DATE-TIME
    /// <see href="http://www.w3.org/2002/12/cal/ical#lastModified"></see></summary>
    let lastModified = _prefix "lastModified"
    /// <summary>
    /// This property defines the revision sequence number of the calendar component within a sequence of revisions.
    ///
    /// 	    value type: integer
    /// <see href="http://www.w3.org/2002/12/cal/ical#sequence"></see></summary>
    let sequence = _prefix "sequence"
    /// <summary>
    /// This property defines the list of date/times for a recurrence set.
    ///
    /// 	    default value type: DATE-TIME
    /// <see href="http://www.w3.org/2002/12/cal/ical#rdate"></see></summary>
    let rdate = _prefix "rdate"
    /// <summary>
    /// This property defines the status code returned for a scheduling request.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#requestStatus"></see></summary>
    let requestStatus = _prefix "requestStatus"
    /// <summary>
    /// This property defines a rule or repeating pattern for recurring events, to-dos, or time zone definitions.
    ///
    /// 	    value type: RECUR
    /// <see href="http://www.w3.org/2002/12/cal/ical#rrule"></see></summary>
    let rrule = _prefix "rrule"
    /// <summary>
    /// The property defines the relative priority for a calendar component.
    ///
    /// 	    value type: INTEGER
    /// <see href="http://www.w3.org/2002/12/cal/ical#priority"></see></summary>
    let priority = _prefix "priority"
    /// <summary>
    /// The property is used to represent contact information or alternately a reference to contact information associated with the calendar component.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#contact"></see></summary>
    let contact = _prefix "contact"
    /// <summary>
    /// This property defines a rule or repeating pattern for an exception to a recurrence set.
    ///
    /// 	    value type: RECUR
    /// <see href="http://www.w3.org/2002/12/cal/ical#exrule"></see></summary>
    let exrule = _prefix "exrule"
    /// <summary>
    /// This property defines a Uniform Resource Locator (URL) associated with the iCalendar object.
    ///
    /// 	    value type: URI
    /// <see href="http://www.w3.org/2002/12/cal/ical#url"></see></summary>
    let url = _prefix "url"
    /// <summary>
    /// This property specifies non-processing information intended to provide a comment to the calendar user.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#comment"></see></summary>
    let comment = _prefix "comment"
    /// <summary>
    /// The property indicates the date/time that the instance of the iCalendar object was created.
    ///
    /// 	    value type: DATE-TIME
    /// <see href="http://www.w3.org/2002/12/cal/ical#dtstamp"></see></summary>
    let dtstamp = _prefix "dtstamp"
    /// <summary>
    /// This property defines the list of date/time exceptions for a recurring calendar component.
    ///
    /// 	    default value type: DATE-TIME
    /// <see href="http://www.w3.org/2002/12/cal/ical#exdate"></see></summary>
    let exdate = _prefix "exdate"
    /// <summary>
    /// This property defines the access classification for a calendar component.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#class"></see></summary>
    let class_ = _prefix "class"
    /// <summary>
    /// The property is used to represent a relationship or reference between one calendar component and another.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#relatedTo"></see></summary>
    let relatedTo = _prefix "relatedTo"
    /// <summary>
    /// This property defines the categories for a calendar component.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#categories"></see></summary>
    let categories = _prefix "categories"
    /// <summary>
    /// This property specifies the date and time that the calendar information was created by the calendar user agent in the calendar store. Note: This is analogous to the creation date and time for a file in the file system.
    ///
    /// 	    value type: DATE-TIME
    /// <see href="http://www.w3.org/2002/12/cal/ical#created"></see></summary>
    let created = _prefix "created"
    /// <summary>
    /// This property specifies information related to the global position for the activity specified by a calendar component.
    ///
    /// 	    value type: list of FLOAT
    /// <see href="http://www.w3.org/2002/12/cal/ical#geo"></see></summary>
    let geo = _prefix "geo"
    /// <summary>
    /// This property specifies when the calendar component begins.
    ///
    /// 	    default value type: DATE-TIME
    /// <see href="http://www.w3.org/2002/12/cal/ical#dtstart"></see></summary>
    let dtstart = _prefix "dtstart"
    /// <summary>
    /// The property defines the intended venue for the activity defined by a calendar component.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#location"></see></summary>
    let location = _prefix "location"
    /// <summary>
    /// This property defines the equipment or resources anticipated for an activity specified by a calendar entity..
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#resources"></see></summary>
    let resources = _prefix "resources"
    /// <summary>
    /// This property defines the overall status or confirmation for the calendar component.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#status"></see></summary>
    let status = _prefix "status"
    /// <summary>
    /// This property defines the persistent, globally unique identifier for the calendar component.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#uid"></see></summary>
    let uid = _prefix "uid"
    /// <summary>
    /// This property is used in conjunction with the "UID" and "SEQUENCE" property to identify a specific instance of a recurring "VEVENT", "VTODO" or "VJOURNAL" calendar component. The property value is the effective value of the "DTSTART" property of the recurrence instance.
    ///
    /// 	    default value type: DATE-TIME
    /// <see href="http://www.w3.org/2002/12/cal/ical#recurrenceId"></see></summary>
    let recurrenceId = _prefix "recurrenceId"
    /// <summary>
    /// Provide a grouping of component properties that describe either a request for free/busy time, describe a response to a request for free/busy time or describe a published set of busy time.
    /// <see href="http://www.w3.org/2002/12/cal/ical#Vfreebusy"></see></summary>
    let Vfreebusy = _prefix "Vfreebusy"
    /// <summary>
    /// The property defines one or more free or busy time intervals.
    ///
    /// 	    value type: PERIOD
    /// <see href="http://www.w3.org/2002/12/cal/ical#freebusy"></see></summary>
    let freebusy = _prefix "freebusy"
    /// <summary>
    /// Provide a grouping of component properties that describe a journal entry.
    /// <see href="http://www.w3.org/2002/12/cal/ical#Vjournal"></see></summary>
    let Vjournal = _prefix "Vjournal"
    /// <summary>
    /// Provide a grouping of component properties that defines a time zone.
    /// <see href="http://www.w3.org/2002/12/cal/ical#Vtimezone"></see></summary>
    let Vtimezone = _prefix "Vtimezone"
    /// <summary>
    /// This property specifies the text value that uniquely identifies the "VTIMEZONE" calendar component.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#tzid"></see></summary>
    let tzid = _prefix "tzid"
    /// <summary>
    /// This property specifies the offset which is in use in this time zone observance.
    ///
    /// 	    value type: UTC-OFFSET
    /// <see href="http://www.w3.org/2002/12/cal/ical#tzoffsetto"></see></summary>
    let tzoffsetto = _prefix "tzoffsetto"
    /// <summary>
    /// The TZURL provides a means for a VTIMEZONE component to point to a network location that can be used to retrieve an up-to- date version of itself.
    ///
    /// 	    value type: URI
    /// <see href="http://www.w3.org/2002/12/cal/ical#tzurl"></see></summary>
    let tzurl = _prefix "tzurl"
    /// <summary>
    /// This property specifies the offset which is in use prior to this time zone observance.
    ///
    /// 	    value type: UTC-OFFSET
    /// <see href="http://www.w3.org/2002/12/cal/ical#tzoffsetfrom"></see></summary>
    let tzoffsetfrom = _prefix "tzoffsetfrom"
    /// <summary>
    /// This property specifies the customary designation for a time zone description.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#tzname"></see></summary>
    let tzname = _prefix "tzname"
    /// <summary>
    /// Provide a grouping of calendar properties that describe a to-do.
    /// <see href="http://www.w3.org/2002/12/cal/ical#Vtodo"></see></summary>
    let Vtodo = _prefix "Vtodo"
    /// <summary>
    /// This property defines the date and time that a to-do was actually completed.
    ///
    /// 	    value type: DATE-TIME
    /// <see href="http://www.w3.org/2002/12/cal/ical#completed"></see></summary>
    let completed = _prefix "completed"
    /// <summary>
    /// This property is used by an assignee or delegatee of a to-do to convey the percent completion of a to-do to the Organizer.
    ///
    /// 	    value type: INTEGER
    /// <see href="http://www.w3.org/2002/12/cal/ical#percentComplete"></see></summary>
    let percentComplete = _prefix "percentComplete"
    /// <summary>
    /// This property defines the date and time that a to-do is expected to be completed.
    ///
    /// 	    default value type: DATE-TIME
    /// <see href="http://www.w3.org/2002/12/cal/ical#due"></see></summary>
    let due = _prefix "due"
    /// <summary>
    /// This class of property provides a framework for defining non-standard properties.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#X-"></see></summary>
    let ``X-`` = _prefix "X-"
    /// <summary>
    /// This property defines the calendar scale used for the calendar information specified in the iCalendar object.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#calscale"></see></summary>
    let calscale = _prefix "calscale"
    /// <summary>
    /// This property defines the iCalendar object method associated with the calendar object.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#method"></see></summary>
    let method = _prefix "method"
    /// <summary>
    /// This property specifies the identifier for the product that created the iCalendar object.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#prodid"></see></summary>
    let prodid = _prefix "prodid"
    /// <summary>
    /// This property specifies the identifier corresponding to the highest version number or the minimum and maximum range of the iCalendar specification that is required in order to interpret the iCalendar object.
    ///
    /// 	    value type: TEXT
    /// <see href="http://www.w3.org/2002/12/cal/ical#version"></see></summary>
    let version = _prefix "version"
