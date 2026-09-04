#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module cal =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.w3.org/2002/12/cal/ical#" "cal"

    let DomainOf_rrule = _prefixId.prefix "DomainOf_rrule"
    let List_of_Float = _prefixId.prefix "List_of_Float"
    /// <summary>
    ///   <para>rdfs:comment : Provide a grouping of component properties that define an alarm.^^xsd:string</para>
    ///   <para>rdfs:label : VALARM^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#Valarm">cal:Valarm</a>
    /// </summary>
    let Valarm = _prefixId.prefix "Valarm"
    let Value_CAL_ADDRESS = _prefixId.prefix "Value_CAL-ADDRESS"
    let Value_DATE = _prefixId.prefix "Value_DATE"
    let Value_DATE_TIME = _prefixId.prefix "Value_DATE-TIME"
    let Value_DURATION = _prefixId.prefix "Value_DURATION"
    let Value_PERIOD = _prefixId.prefix "Value_PERIOD"
    let Value_RECUR = _prefixId.prefix "Value_RECUR"
    /// <summary>
    ///   <para>rdfs:label : VEVENT^^xsd:string</para>
    ///   <para>rdfs:comment : Provide a grouping of component properties that describe an event.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#Vevent">cal:Vevent</a>
    /// </summary>
    let Vevent = _prefixId.prefix "Vevent"
    /// <summary>
    ///   <para>rdfs:comment : Provide a grouping of component properties that describe either a request for free/busy time, describe a response to a request for free/busy time or describe a published set of busy time.^^xsd:string</para>
    ///   <para>rdfs:label : VFREEBUSY^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#Vfreebusy">cal:Vfreebusy</a>
    /// </summary>
    let Vfreebusy = _prefixId.prefix "Vfreebusy"
    /// <summary>
    ///   <para>rdfs:label : VJOURNAL^^xsd:string</para>
    ///   <para>rdfs:comment : Provide a grouping of component properties that describe a journal entry.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#Vjournal">cal:Vjournal</a>
    /// </summary>
    let Vjournal = _prefixId.prefix "Vjournal"
    /// <summary>
    ///   <para>rdfs:comment : Provide a grouping of component properties that defines a time zone.^^xsd:string</para>
    ///   <para>rdfs:label : VTIMEZONE^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#Vtimezone">cal:Vtimezone</a>
    /// </summary>
    let Vtimezone = _prefixId.prefix "Vtimezone"
    /// <summary>
    ///   <para>rdfs:comment : Provide a grouping of calendar properties that describe a to-do.^^xsd:string</para>
    ///   <para>rdfs:label : VTODO^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#Vtodo">cal:Vtodo</a>
    /// </summary>
    let Vtodo = _prefixId.prefix "Vtodo"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : TEXT^^xsd:string</para>
    ///   <para>rdfs:label : Any property name with a "X-" prefix^^xsd:string</para>
    ///   <para>rdfs:comment : This class of property provides a framework for defining non-standard properties.^^xsd:stringrdfs:comment :
    /// 	    value type: TEXT^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#X-">cal:X-</a>
    /// </summary>
    let X_ = _prefixId.prefix "X-"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : TEXT^^xsd:string</para>
    ///   <para>rdfs:label : ACTION^^xsd:string</para>
    ///   <para>rdfs:comment : This property defines the action to be invoked when an alarm is triggered.^^xsd:stringrdfs:comment :
    /// 	    value type: TEXT^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#action">cal:action</a>
    /// </summary>
    let action = _prefixId.prefix "action"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : URI^^xsd:string</para>
    ///   <para>rdfs:label : ATTACH^^xsd:string</para>
    ///   <para>rdfs:comment : The property provides the capability to associate a document object with a calendar component.^^xsd:stringrdfs:comment :
    /// 	    default value type: URI^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#attach">cal:attach</a>
    /// </summary>
    let attach = _prefixId.prefix "attach"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : CAL-ADDRESS^^xsd:string</para>
    ///   <para>rdfs:label : ATTENDEE^^xsd:string</para>
    ///   <para>rdfs:comment : The property defines an "Attendee" within a calendar component.^^xsd:stringrdfs:comment :
    /// 	    value type: CAL-ADDRESS^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#attendee">cal:attendee</a>
    /// </summary>
    let attendee = _prefixId.prefix "attendee"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : TEXT^^xsd:string</para>
    ///   <para>rdfs:label : CALSCALE^^xsd:string</para>
    ///   <para>rdfs:comment : This property defines the calendar scale used for the calendar information specified in the iCalendar object.^^xsd:stringrdfs:comment :
    /// 	    value type: TEXT^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#calscale">cal:calscale</a>
    /// </summary>
    let calscale = _prefixId.prefix "calscale"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : TEXT^^xsd:string</para>
    ///   <para>rdfs:label : CATEGORIES^^xsd:string</para>
    ///   <para>rdfs:comment : This property defines the categories for a calendar component.^^xsd:stringrdfs:comment :
    /// 	    value type: TEXT^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#categories">cal:categories</a>
    /// </summary>
    let categories = _prefixId.prefix "categories"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : TEXT^^xsd:string</para>
    ///   <para>rdfs:label : CLASS^^xsd:string</para>
    ///   <para>rdfs:comment : This property defines the access classification for a calendar component.^^xsd:stringrdfs:comment :
    /// 	    value type: TEXT^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#class">cal:class</a>
    /// </summary>
    let class_ = _prefixId.prefix "class"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : TEXT^^xsd:string</para>
    ///   <para>rdfs:label : COMMENT^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies non-processing information intended to provide a comment to the calendar user.^^xsd:stringrdfs:comment :
    /// 	    value type: TEXT^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#comment">cal:comment</a>
    /// </summary>
    let comment = _prefixId.prefix "comment"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : DATE-TIME^^xsd:string</para>
    ///   <para>rdfs:label : COMPLETED^^xsd:string</para>
    ///   <para>rdfs:comment : This property defines the date and time that a to-do was actually completed.^^xsd:stringrdfs:comment :
    /// 	    value type: DATE-TIME^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#completed">cal:completed</a>
    /// </summary>
    let completed = _prefixId.prefix "completed"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : TEXT^^xsd:string</para>
    ///   <para>rdfs:label : CONTACT^^xsd:string</para>
    ///   <para>rdfs:comment : The property is used to represent contact information or alternately a reference to contact information associated with the calendar component.^^xsd:stringrdfs:comment :
    /// 	    value type: TEXT^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#contact">cal:contact</a>
    /// </summary>
    let contact = _prefixId.prefix "contact"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : DATE-TIME^^xsd:string</para>
    ///   <para>rdfs:label : CREATED^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies the date and time that the calendar information was created by the calendar user agent in the calendar store. Note: This is analogous to the creation date and time for a file in the file system.^^xsd:stringrdfs:comment :
    /// 	    value type: DATE-TIME^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#created">cal:created</a>
    /// </summary>
    let created = _prefixId.prefix "created"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : TEXT^^xsd:string</para>
    ///   <para>rdfs:label : DESCRIPTION^^xsd:string</para>
    ///   <para>rdfs:comment : This property provides a more complete description of the calendar component, than that provided by the "SUMMARY" property.^^xsd:stringrdfs:comment :
    /// 	    value type: TEXT^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#description">cal:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : DATE-TIME^^xsd:string</para>
    ///   <para>rdfs:label : DTEND^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies the date and time that a calendar component ends.^^xsd:stringrdfs:comment :
    /// 	    default value type: DATE-TIME^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#dtend">cal:dtend</a>
    /// </summary>
    let dtend = _prefixId.prefix "dtend"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : DATE-TIME^^xsd:string</para>
    ///   <para>rdfs:label : DTSTAMP^^xsd:string</para>
    ///   <para>rdfs:comment : The property indicates the date/time that the instance of the iCalendar object was created.^^xsd:stringrdfs:comment :
    /// 	    value type: DATE-TIME^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#dtstamp">cal:dtstamp</a>
    /// </summary>
    let dtstamp = _prefixId.prefix "dtstamp"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : DATE-TIME^^xsd:string</para>
    ///   <para>rdfs:label : DTSTART^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies when the calendar component begins.^^xsd:stringrdfs:comment :
    /// 	    default value type: DATE-TIME^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#dtstart">cal:dtstart</a>
    /// </summary>
    let dtstart = _prefixId.prefix "dtstart"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : DATE-TIME^^xsd:string</para>
    ///   <para>rdfs:label : DUE^^xsd:string</para>
    ///   <para>rdfs:comment : This property defines the date and time that a to-do is expected to be completed.^^xsd:stringrdfs:comment :
    /// 	    default value type: DATE-TIME^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#due">cal:due</a>
    /// </summary>
    let due = _prefixId.prefix "due"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : DURATION^^xsd:string</para>
    ///   <para>rdfs:label : DURATION^^xsd:string</para>
    ///   <para>rdfs:comment : The property specifies a positive duration of time.^^xsd:stringrdfs:comment :
    /// 	    value type: DURATION^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#duration">cal:duration</a>
    /// </summary>
    let duration = _prefixId.prefix "duration"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : DATE-TIME^^xsd:string</para>
    ///   <para>rdfs:label : EXDATE^^xsd:string</para>
    ///   <para>rdfs:comment : This property defines the list of date/time exceptions for a recurring calendar component.^^xsd:stringrdfs:comment :
    /// 	    default value type: DATE-TIME^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#exdate">cal:exdate</a>
    /// </summary>
    let exdate = _prefixId.prefix "exdate"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : RECUR^^xsd:string</para>
    ///   <para>rdfs:label : EXRULE^^xsd:string</para>
    ///   <para>rdfs:comment : This property defines a rule or repeating pattern for an exception to a recurrence set.^^xsd:stringrdfs:comment :
    /// 	    value type: RECUR^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#exrule">cal:exrule</a>
    /// </summary>
    let exrule = _prefixId.prefix "exrule"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : PERIOD^^xsd:string</para>
    ///   <para>rdfs:label : FREEBUSY^^xsd:string</para>
    ///   <para>rdfs:comment : The property defines one or more free or busy time intervals.^^xsd:stringrdfs:comment :
    /// 	    value type: PERIOD^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#freebusy">cal:freebusy</a>
    /// </summary>
    let freebusy = _prefixId.prefix "freebusy"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueListType : FLOAT^^xsd:string</para>
    ///   <para>rdfs:label : GEO^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies information related to the global position for the activity specified by a calendar component.^^xsd:stringrdfs:comment :
    /// 	    value type: list of FLOAT^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#geo">cal:geo</a>
    /// </summary>
    let geo = _prefixId.prefix "geo"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : DATE-TIME^^xsd:string</para>
    ///   <para>rdfs:label : LAST-MODIFIED^^xsd:string</para>
    ///   <para>rdfs:comment : The property specifies the date and time that the information associated with the calendar component was last revised in the calendar store. Note: This is analogous to the modification date and time for a file in the file system.^^xsd:stringrdfs:comment :
    /// 	    value type: DATE-TIME^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#lastModified">cal:lastModified</a>
    /// </summary>
    let lastModified = _prefixId.prefix "lastModified"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : TEXT^^xsd:string</para>
    ///   <para>rdfs:label : LOCATION^^xsd:string</para>
    ///   <para>rdfs:comment : The property defines the intended venue for the activity defined by a calendar component.^^xsd:stringrdfs:comment :
    /// 	    value type: TEXT^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#location">cal:location</a>
    /// </summary>
    let location = _prefixId.prefix "location"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : TEXT^^xsd:string</para>
    ///   <para>rdfs:label : METHOD^^xsd:string</para>
    ///   <para>rdfs:comment : This property defines the iCalendar object method associated with the calendar object.^^xsd:stringrdfs:comment :
    /// 	    value type: TEXT^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#method">cal:method</a>
    /// </summary>
    let method = _prefixId.prefix "method"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : CAL-ADDRESS^^xsd:string</para>
    ///   <para>rdfs:label : ORGANIZER^^xsd:string</para>
    ///   <para>rdfs:comment : The property defines the organizer for a calendar component.^^xsd:stringrdfs:comment :
    /// 	    value type: CAL-ADDRESS^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#organizer">cal:organizer</a>
    /// </summary>
    let organizer = _prefixId.prefix "organizer"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : INTEGER^^xsd:string</para>
    ///   <para>rdfs:label : PERCENT-COMPLETE^^xsd:string</para>
    ///   <para>rdfs:comment : This property is used by an assignee or delegatee of a to-do to convey the percent completion of a to-do to the Organizer.^^xsd:stringrdfs:comment :
    /// 	    value type: INTEGER^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#percentComplete">cal:percentComplete</a>
    /// </summary>
    let percentComplete = _prefixId.prefix "percentComplete"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : INTEGER^^xsd:string</para>
    ///   <para>rdfs:label : PRIORITY^^xsd:string</para>
    ///   <para>rdfs:comment : The property defines the relative priority for a calendar component.^^xsd:stringrdfs:comment :
    /// 	    value type: INTEGER^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#priority">cal:priority</a>
    /// </summary>
    let priority = _prefixId.prefix "priority"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : TEXT^^xsd:string</para>
    ///   <para>rdfs:label : PRODID^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies the identifier for the product that created the iCalendar object.^^xsd:stringrdfs:comment :
    /// 	    value type: TEXT^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#prodid">cal:prodid</a>
    /// </summary>
    let prodid = _prefixId.prefix "prodid"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : DATE-TIME^^xsd:string</para>
    ///   <para>rdfs:label : RDATE^^xsd:string</para>
    ///   <para>rdfs:comment : This property defines the list of date/times for a recurrence set.^^xsd:stringrdfs:comment :
    /// 	    default value type: DATE-TIME^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#rdate">cal:rdate</a>
    /// </summary>
    let rdate = _prefixId.prefix "rdate"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : DATE-TIME^^xsd:string</para>
    ///   <para>rdfs:label : RECURRENCE-ID^^xsd:string</para>
    ///   <para>rdfs:comment : This property is used in conjunction with the "UID" and "SEQUENCE" property to identify a specific instance of a recurring "VEVENT", "VTODO" or "VJOURNAL" calendar component. The property value is the effective value of the "DTSTART" property of the recurrence instance.^^xsd:stringrdfs:comment :
    /// 	    default value type: DATE-TIME^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#recurrenceId">cal:recurrenceId</a>
    /// </summary>
    let recurrenceId = _prefixId.prefix "recurrenceId"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : TEXT^^xsd:string</para>
    ///   <para>rdfs:label : RELATED-TO^^xsd:string</para>
    ///   <para>rdfs:comment : The property is used to represent a relationship or reference between one calendar component and another.^^xsd:stringrdfs:comment :
    /// 	    value type: TEXT^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#relatedTo">cal:relatedTo</a>
    /// </summary>
    let relatedTo = _prefixId.prefix "relatedTo"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : INTEGER^^xsd:string</para>
    ///   <para>rdfs:label : REPEAT^^xsd:string</para>
    ///   <para>rdfs:comment : This property defines the number of time the alarm should be repeated, after the initial trigger.^^xsd:stringrdfs:comment :
    /// 	    value type: INTEGER^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#repeat">cal:repeat</a>
    /// </summary>
    let repeat = _prefixId.prefix "repeat"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : TEXT^^xsd:string</para>
    ///   <para>rdfs:label : REQUEST-STATUS^^xsd:string</para>
    ///   <para>rdfs:comment : This property defines the status code returned for a scheduling request.^^xsd:stringrdfs:comment :
    /// 	    value type: TEXT^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#requestStatus">cal:requestStatus</a>
    /// </summary>
    let requestStatus = _prefixId.prefix "requestStatus"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : TEXT^^xsd:string</para>
    ///   <para>rdfs:label : RESOURCES^^xsd:string</para>
    ///   <para>rdfs:comment : This property defines the equipment or resources anticipated for an activity specified by a calendar entity..^^xsd:stringrdfs:comment :
    /// 	    value type: TEXT^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#resources">cal:resources</a>
    /// </summary>
    let resources = _prefixId.prefix "resources"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : RECUR^^xsd:string</para>
    ///   <para>rdfs:label : RRULE^^xsd:string</para>
    ///   <para>rdfs:comment : This property defines a rule or repeating pattern for recurring events, to-dos, or time zone definitions.^^xsd:stringrdfs:comment :
    /// 	    value type: RECUR^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#rrule">cal:rrule</a>
    /// </summary>
    let rrule = _prefixId.prefix "rrule"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : integer^^xsd:string</para>
    ///   <para>rdfs:label : SEQUENCE^^xsd:string</para>
    ///   <para>rdfs:comment : This property defines the revision sequence number of the calendar component within a sequence of revisions.^^xsd:stringrdfs:comment :
    /// 	    value type: integer^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#sequence">cal:sequence</a>
    /// </summary>
    let sequence = _prefixId.prefix "sequence"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : TEXT^^xsd:string</para>
    ///   <para>rdfs:label : STATUS^^xsd:string</para>
    ///   <para>rdfs:comment : This property defines the overall status or confirmation for the calendar component.^^xsd:stringrdfs:comment :
    /// 	    value type: TEXT^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#status">cal:status</a>
    /// </summary>
    let status = _prefixId.prefix "status"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : TEXT^^xsd:string</para>
    ///   <para>rdfs:label : SUMMARY^^xsd:string</para>
    ///   <para>rdfs:comment : This property defines a short summary or subject for the calendar component.^^xsd:stringrdfs:comment :
    /// 	    value type: TEXT^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#summary">cal:summary</a>
    /// </summary>
    let summary = _prefixId.prefix "summary"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : TEXT^^xsd:string</para>
    ///   <para>rdfs:label : TRANSP^^xsd:string</para>
    ///   <para>rdfs:comment : This property defines whether an event is transparent or not to busy time searches.^^xsd:stringrdfs:comment :
    /// 	    value type: TEXT^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#transp">cal:transp</a>
    /// </summary>
    let transp = _prefixId.prefix "transp"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : DURATION^^xsd:string</para>
    ///   <para>rdfs:label : TRIGGER^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies when an alarm will trigger.^^xsd:stringrdfs:comment :
    /// 	    default value type: DURATION^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#trigger">cal:trigger</a>
    /// </summary>
    let trigger = _prefixId.prefix "trigger"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : TEXT^^xsd:string</para>
    ///   <para>rdfs:label : TZID^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies the text value that uniquely identifies the "VTIMEZONE" calendar component.^^xsd:stringrdfs:comment :
    /// 	    value type: TEXT^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#tzid">cal:tzid</a>
    /// </summary>
    let tzid = _prefixId.prefix "tzid"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : TEXT^^xsd:string</para>
    ///   <para>rdfs:label : TZNAME^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies the customary designation for a time zone description.^^xsd:stringrdfs:comment :
    /// 	    value type: TEXT^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#tzname">cal:tzname</a>
    /// </summary>
    let tzname = _prefixId.prefix "tzname"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : UTC-OFFSET^^xsd:string</para>
    ///   <para>rdfs:label : TZOFFSETFROM^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies the offset which is in use prior to this time zone observance.^^xsd:stringrdfs:comment :
    /// 	    value type: UTC-OFFSET^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#tzoffsetfrom">cal:tzoffsetfrom</a>
    /// </summary>
    let tzoffsetfrom = _prefixId.prefix "tzoffsetfrom"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : UTC-OFFSET^^xsd:string</para>
    ///   <para>rdfs:label : TZOFFSETTO^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies the offset which is in use in this time zone observance.^^xsd:stringrdfs:comment :
    /// 	    value type: UTC-OFFSET^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#tzoffsetto">cal:tzoffsetto</a>
    /// </summary>
    let tzoffsetto = _prefixId.prefix "tzoffsetto"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : URI^^xsd:string</para>
    ///   <para>rdfs:label : TZURL^^xsd:string</para>
    ///   <para>rdfs:comment : The TZURL provides a means for a VTIMEZONE component to point to a network location that can be used to retrieve an up-to- date version of itself.^^xsd:stringrdfs:comment :
    /// 	    value type: URI^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#tzurl">cal:tzurl</a>
    /// </summary>
    let tzurl = _prefixId.prefix "tzurl"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : TEXT^^xsd:string</para>
    ///   <para>rdfs:label : UID^^xsd:string</para>
    ///   <para>rdfs:comment : This property defines the persistent, globally unique identifier for the calendar component.^^xsd:stringrdfs:comment :
    /// 	    value type: TEXT^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#uid">cal:uid</a>
    /// </summary>
    let uid = _prefixId.prefix "uid"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : URI^^xsd:string</para>
    ///   <para>rdfs:label : URL^^xsd:string</para>
    ///   <para>rdfs:comment : This property defines a Uniform Resource Locator (URL) associated with the iCalendar object.^^xsd:stringrdfs:comment :
    /// 	    value type: URI^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#url">cal:url</a>
    /// </summary>
    let url = _prefixId.prefix "url"
    /// <summary>
    ///   <para>http://www.w3.org/2002/12/cal/icalSpec#valueType : TEXT^^xsd:string</para>
    ///   <para>rdfs:label : VERSION^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies the identifier corresponding to the highest version number or the minimum and maximum range of the iCalendar specification that is required in order to interpret the iCalendar object.^^xsd:stringrdfs:comment :
    /// 	    value type: TEXT^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/12/cal/ical#version">cal:version</a>
    /// </summary>
    let version = _prefixId.prefix "version"
