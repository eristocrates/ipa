namespace http.www.semanticdesktop.org.ontologies._2007._04._02.ncal.hash

open DoxAletheia

module ncal =
    let _namespace_name = "http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Access classification of a calendar component. Introduced to express
    /// the set of values for the ncal:class property. The user may use instances
    /// provided with this ontology or create his/her own with desired semantics.
    /// See the documentation of ncal:class for details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#AccessClassification"></see></summary>
    let AccessClassification = _prefix "AccessClassification"
    /// <summary>
    /// Provide a grouping of component properties that define an alarm.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Alarm"></see></summary>
    let Alarm = _prefix "Alarm"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfAlarmEventTodo"></see>
    /// </summary>
    let UnionOfAlarmEventTodo = _prefix "UnionOfAlarmEventTodo"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfAlarmEventFreebusyTodo"></see>
    /// </summary>
    let UnionOfAlarmEventFreebusyTodo = _prefix "UnionOfAlarmEventFreebusyTodo"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfAlarmEventJournalTodo"></see>
    /// </summary>
    let UnionOfAlarmEventJournalTodo = _prefix "UnionOfAlarmEventJournalTodo"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfAlarmEventFreebusyJournalTodo"></see>
    /// </summary>
    let UnionOfAlarmEventFreebusyJournalTodo =
        _prefix "UnionOfAlarmEventFreebusyJournalTodo"

    /// <summary>
    /// Action to be performed on alarm. This class has been introduced to express the limited set of values of the ncal:action property. Please refer to the documentation of ncal:action for details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#AlarmAction"></see></summary>
    let AlarmAction = _prefix "AlarmAction"
    /// <summary>
    /// An object attached to a calendar entity. This class has been introduced to serve as a structured value of the ncal:attach property. See the documentation of ncal:attach for details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Attachment"></see></summary>
    let Attachment = _prefix "Attachment"
    /// <summary>
    /// Attachment encoding. This class has been introduced to express the limited vocabulary of values for the ncal:encoding property. See the documentation of ncal:encoding for details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#AttachmentEncoding"></see></summary>
    let AttachmentEncoding = _prefix "AttachmentEncoding"
    /// <summary>
    /// An attendee of an event. This class has been introduced to serve as the range for ncal:attendee property. See documentation of ncal:attendee for details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Attendee"></see></summary>
    let Attendee = _prefix "Attendee"
    /// <summary>
    /// A common superclass for ncal:Attendee and ncal:Organizer.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#AttendeeOrOrganizer"></see></summary>
    let AttendeeOrOrganizer = _prefix "AttendeeOrOrganizer"
    /// <summary>
    /// A role the attendee is going to play during an event. This class has been introduced to express the limited vocabulary for the values of ncal:role property. Please refer to the documentation of ncal:role for details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#AttendeeRole"></see></summary>
    let AttendeeRole = _prefix "AttendeeRole"
    /// <summary>
    /// Expresses the compound value of a byday part of a recurrence rule. It stores the weekday and the integer modifier. Inspired by RFC 2445 sec. 4.3.10
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#BydayRulePart"></see></summary>
    let BydayRulePart = _prefix "BydayRulePart"
    /// <summary>
    /// A calendar. Inspirations for this class can be traced to the VCALENDAR component defined in RFC 2445 sec. 4.4, but it may just as well be used to represent any kind of Calendar.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Calendar"></see></summary>
    let Calendar = _prefix "Calendar"
    /// <summary>
    /// A DataObject found in a calendar. It is usually interpreted as one of the calendar entity types (e.g. Event, Journal, Todo etc.)
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#CalendarDataObject"></see></summary>
    let CalendarDataObject = _prefix "CalendarDataObject"
    /// <summary>
    /// A calendar scale. This class has been introduced to provide the limited vocabulary for the ncal:calscale property.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#CalendarScale"></see></summary>
    let CalendarScale = _prefix "CalendarScale"
    /// <summary>
    /// A calendar user type. This class has been introduced to express the limited vocabulary for the ncal:cutype property. See documentation of ncal:cutype for details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#CalendarUserType"></see></summary>
    let CalendarUserType = _prefix "CalendarUserType"
    /// <summary>
    /// Provide a grouping of component properties that describe an event.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Event"></see></summary>
    let Event = _prefix "Event"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfEventJournalTimezoneTodo"></see>
    /// </summary>
    let UnionOfEventJournalTimezoneTodo = _prefix "UnionOfEventJournalTimezoneTodo"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfEventFreebusyJournalTodo"></see>
    /// </summary>
    let UnionOfEventFreebusyJournalTodo = _prefix "UnionOfEventFreebusyJournalTodo"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfTimezoneObservanceEventJournalTimezoneTodo"></see>
    /// </summary>
    let UnionOfTimezoneObservanceEventJournalTimezoneTodo =
        _prefix "UnionOfTimezoneObservanceEventJournalTimezoneTodo"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfTimezoneObservanceEventFreebusyJournalTimezoneTodo"></see>
    /// </summary>
    let UnionOfTimezoneObservanceEventFreebusyJournalTimezoneTodo =
        _prefix "UnionOfTimezoneObservanceEventFreebusyJournalTimezoneTodo"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfTimezoneObservanceEventFreebusyTimezoneTodo"></see>
    /// </summary>
    let UnionOfTimezoneObservanceEventFreebusyTimezoneTodo =
        _prefix "UnionOfTimezoneObservanceEventFreebusyTimezoneTodo"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfEventFreebusy"></see>
    /// </summary>
    let UnionOfEventFreebusy = _prefix "UnionOfEventFreebusy"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfEventTodo"></see>
    /// </summary>
    let UnionOfEventTodo = _prefix "UnionOfEventTodo"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfEventJournalTodo"></see>
    /// </summary>
    let UnionOfEventJournalTodo = _prefix "UnionOfEventJournalTodo"
    /// <summary>
    /// A status of an event. This class has been introduced to express
    /// the limited set of values for the ncal:status property. The user may
    /// use the instances provided with this ontology or create his/her own.
    /// See the documentation for ncal:eventStatus for details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#EventStatus"></see></summary>
    let EventStatus = _prefix "EventStatus"
    /// <summary>
    /// Provide a grouping of component properties that describe either a request for free/busy time, describe a response to a request for free/busy time or describe a published set of busy time.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Freebusy"></see></summary>
    let Freebusy = _prefix "Freebusy"
    /// <summary>
    /// An aggregate of a period and a freebusy type. This class has been introduced to serve as a range of the ncal:freebusy property. See documentation for ncal:freebusy for details. Note that the specification of freebusy property states that the period is to be expressed using UTC time, so the timezone properties should NOT be used for instances of this class.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#FreebusyPeriod"></see></summary>
    let FreebusyPeriod = _prefix "FreebusyPeriod"
    /// <summary>
    /// A period of time. Inspired by the PERIOD datatype specified in RFC 2445 sec. 4.3.9
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#NcalPeriod"></see></summary>
    let NcalPeriod = _prefix "NcalPeriod"
    /// <summary>
    /// Type of a Freebusy indication. This class has been introduced to serve as a limited set of values for the ncal:fbtype property. See the documentation of ncal:fbtype for details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#FreebusyType"></see></summary>
    let FreebusyType = _prefix "FreebusyType"
    /// <summary>
    /// Provide a grouping of component properties that describe a journal entry.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Journal"></see></summary>
    let Journal = _prefix "Journal"
    /// <summary>
    /// A status of a journal entry. This class has been introduced to express
    /// the limited set of values for the ncal:status property. The user may
    /// use the instances provided with this ontology or create his/her own.
    /// See the documentation for ncal:journalStatus for details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#JournalStatus"></see></summary>
    let JournalStatus = _prefix "JournalStatus"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#NcalDateTime"></see>
    /// </summary>
    let NcalDateTime = _prefix "NcalDateTime"
    /// <summary>
    /// A time entity. Conceived as a common superclass for NcalDateTime and NcalPeriod. According to RFC 2445 both DateTime and Period can be interpreted in different timezones. The first case is explored in many properties. The second case is theoretically possible in ncal:rdate property. Therefore the timezone properties have been defined at this level.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#NcalTimeEntity"></see></summary>
    let NcalTimeEntity = _prefix "NcalTimeEntity"
    /// <summary>
    /// An organizer of an event. This class has been introduced to serve as a range of ncal:organizer property. See documentation of ncal:organizer for details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Organizer"></see></summary>
    let Organizer = _prefix "Organizer"
    /// <summary>
    /// Participation Status. This class has been introduced to express the limited vocabulary of values for the ncal:partstat property. See the documentation of ncal:partstat for details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#ParticipationStatus"></see></summary>
    let ParticipationStatus = _prefix "ParticipationStatus"
    /// <summary>
    /// Frequency of a recurrence rule. This class has been introduced to express a limited set of allowed values for the ncal:freq property. See the documentation of ncal:freq for details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#RecurrenceFrequency"></see></summary>
    let RecurrenceFrequency = _prefix "RecurrenceFrequency"
    /// <summary>
    /// Recurrence Identifier. Introduced to provide a structure for the value of ncal:recurrenceId property. See the documentation of ncal:recurrenceId for details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#RecurrenceIdentifier"></see></summary>
    let RecurrenceIdentifier = _prefix "RecurrenceIdentifier"
    /// <summary>
    /// Recurrence Identifier Range. This class has been created to provide means to express the limited set of values for the ncal:range property. See documentation for ncal:range for details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#RecurrenceIdentifierRange"></see></summary>
    let RecurrenceIdentifierRange = _prefix "RecurrenceIdentifierRange"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#RecurrenceRule"></see>
    /// </summary>
    let RecurrenceRule = _prefix "RecurrenceRule"
    /// <summary>
    /// Request Status. A class that was introduced to provide a structure for the value of ncal:requestStatus property. See documentation for ncal:requestStatus for details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#RequestStatus"></see></summary>
    let RequestStatus = _prefix "RequestStatus"
    /// <summary>
    /// Time transparency. Introduced to provide a way to express
    /// the limited vocabulary for the values of ncal:transp property.
    /// See documentation of ncal:transp for details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#TimeTransparency"></see></summary>
    let TimeTransparency = _prefix "TimeTransparency"
    /// <summary>
    /// Provide a grouping of component properties that defines a time zone.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Timezone"></see></summary>
    let Timezone = _prefix "Timezone"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#TimezoneObservance"></see>
    /// </summary>
    let TimezoneObservance = _prefix "TimezoneObservance"
    /// <summary>
    /// Provide a grouping of calendar properties that describe a to-do.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Todo"></see></summary>
    let Todo = _prefix "Todo"
    /// <summary>
    /// A status of a calendar entity. This class has been introduced to express
    /// the limited set of values for the ncal:status property. The user may
    /// use the instances provided with this ontology or create his/her own.
    /// See the documentation for ncal:todoStatus for details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#TodoStatus"></see></summary>
    let TodoStatus = _prefix "TodoStatus"
    /// <summary>
    /// An alarm trigger. This class has been created to serve as the range of ncal:trigger property. See the documentation for ncal:trigger for more details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Trigger"></see></summary>
    let Trigger = _prefix "Trigger"
    /// <summary>
    /// The relation between the trigger and its parent calendar component. This class has been introduced to express the limited vocabulary for the ncal:related property. See the documentation for ncal:related for more details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#TriggerRelation"></see></summary>
    let TriggerRelation = _prefix "TriggerRelation"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionParentClass"></see>
    /// </summary>
    let UnionParentClass = _prefix "UnionParentClass"
    /// <summary>
    /// Day of the week. This class has been created to provide the limited vocabulary for ncal:byday property. See the documentation for ncal:byday for details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Weekday"></see></summary>
    let Weekday = _prefix "Weekday"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#_8bitEncoding"></see>
    /// </summary>
    let _8bitEncoding = _prefix "_8bitEncoding"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#acceptedParticipationStatus"></see>
    /// </summary>
    let acceptedParticipationStatus = _prefix "acceptedParticipationStatus"
    /// <summary>
    /// This property defines the action to be invoked when an alarm is triggered. Inspired by RFC 2445 sec 4.8.6.1. Originally this property had a limited set of values. They are expressed as instances of the AlarmAction class.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#action"></see></summary>
    let action = _prefix "action"
    /// <summary>
    /// The property provides the capability to associate a document object with a calendar component. Defined in the RFC 2445 sec. 4.8.1.1
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#attach"></see></summary>
    let attach = _prefix "attach"
    /// <summary>
    /// The uri of the attachment. Created to express the actual value of the ATTACH property defined in RFC 2445 sec. 4.8.1.1. This property expresses the BINARY datatype of that property. see ncal:attachmentUri for the URI datatype.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#attachmentContent"></see></summary>
    let attachmentContent = _prefix "attachmentContent"
    /// <summary>
    /// The uri of the attachment. Created to express the actual value of the ATTACH property defined in RFC 2445 sec. 4.8.1.1. This property expresses the default URI datatype of that property. see ncal:attachmentContents for the BINARY datatype.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#attachmentUri"></see></summary>
    let attachmentUri = _prefix "attachmentUri"
    /// <summary>
    /// The property defines an "Attendee" within a calendar component. Inspired by RFC 2445 sec. 4.8.4.1. Originally this property accepted many parameters. The Attendee class has been introduced to express them all. Note that NCAL is aligned with NCO. The actual value (of the CAL-ADDRESS type) is expressed as an instance of nco:Contact. Remember that the CN parameter has been removed from NCAL. Instead that value should be expressed using nco:fullname property of the above mentioned nco:Contact instance. The RFC stated that whenever this property is attached to a Valarm instance, the Attendee cannot have any parameters apart from involvedContact.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#attendee"></see></summary>
    let attendee = _prefix "attendee"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#audioAction"></see>
    /// </summary>
    let audioAction = _prefix "audioAction"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#base64Encoding"></see>
    /// </summary>
    let base64Encoding = _prefix "base64Encoding"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#busyFreebusyType"></see>
    /// </summary>
    let busyFreebusyType = _prefix "busyFreebusyType"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#busyTentativeFreebusyType"></see>
    /// </summary>
    let busyTentativeFreebusyType = _prefix "busyTentativeFreebusyType"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#busyUnavailableFreebusyType"></see>
    /// </summary>
    let busyUnavailableFreebusyType = _prefix "busyUnavailableFreebusyType"
    /// <summary>
    /// Weekdays the recurrence should occur. Defined in RFC 2445 sec. 4.3.10
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#byday"></see></summary>
    let byday = _prefix "byday"
    /// <summary>
    /// An integer modifier for the BYDAY rule part.    Each BYDAY value can also be preceded by a positive (+n) or negative  (-n) integer. If present, this indicates the nth occurrence of the specific day within the MONTHLY or YEARLY RRULE. For example, within a MONTHLY rule, +1MO (or simply 1MO) represents the first Monday within the month, whereas -1MO represents the last Monday of the month. If an integer modifier is not present, it means all days of this type within the specified frequency. For example, within a MONTHLY rule, MO represents all Mondays within the month. Inspired by RFC 2445 sec. 4.3.10
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#bydayModifier"></see></summary>
    let bydayModifier = _prefix "bydayModifier"
    /// <summary>
    /// Connects a BydayRulePath with a weekday.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#bydayWeekday"></see></summary>
    let bydayWeekday = _prefix "bydayWeekday"
    /// <summary>
    /// Hour of recurrence. Defined in RFC 2445 sec. 4.3.10
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#byhour"></see></summary>
    let byhour = _prefix "byhour"
    /// <summary>
    /// Minute of recurrence. Defined in RFC 2445 sec. 4.3.10
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#byminute"></see></summary>
    let byminute = _prefix "byminute"
    /// <summary>
    /// Number of the month of the recurrence. Valid values are integers from 1 (January) to 12 (December). Defined in RFC 2445 sec. 4.3.10
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#bymonth"></see></summary>
    let bymonth = _prefix "bymonth"
    /// <summary>
    /// Day of the month when the event should recur. Defined in RFC 2445 sec. 4.3.10
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#bymonthday"></see></summary>
    let bymonthday = _prefix "bymonthday"
    /// <summary>
    /// Second of a recurrence. Defined in RFC 2445 sec. 4.3.10
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#bysecond"></see></summary>
    let bysecond = _prefix "bysecond"
    /// <summary>
    /// The BYSETPOS rule part specify values which correspond to the nth occurrence within the set of events specified by the rule. Valid values are 1 to 366 or -366 to -1. It MUST only be used in conjunction with another BYxxx rule part. For example "the last work day of the month" could be represented as: RRULE: FREQ=MONTHLY; BYDAY=MO, TU, WE, TH, FR; BYSETPOS=-1. Each BYSETPOS value can include a positive (+n) or negative (-n)  integer. If present, this indicates the nth occurrence of the  specific occurrence within the set of events specified by the rule. Defined in RFC 2445 sec. 4.3.10
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#bysetpos"></see></summary>
    let bysetpos = _prefix "bysetpos"
    /// <summary>
    /// The number of the week an event should recur. Defined in RFC 2445 sec. 4.3.10
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#byweekno"></see></summary>
    let byweekno = _prefix "byweekno"
    /// <summary>
    /// Day of the year the event should occur. Defined in RFC 2445 sec. 4.3.10
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#byyearday"></see></summary>
    let byyearday = _prefix "byyearday"
    /// <summary>
    /// This property defines the calendar scale used for the calendar information specified in the iCalendar object. Defined in RFC 2445 sec. 4.7.1
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#calscale"></see></summary>
    let calscale = _prefix "calscale"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#cancelledEventStatus"></see>
    /// </summary>
    let cancelledEventStatus = _prefix "cancelledEventStatus"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#cancelledJournalStatus"></see>
    /// </summary>
    let cancelledJournalStatus = _prefix "cancelledJournalStatus"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#cancelledTodoStatus"></see>
    /// </summary>
    let cancelledTodoStatus = _prefix "cancelledTodoStatus"
    /// <summary>
    /// Categories for a calendar component. Inspired by RFC 2445 sec 4.8.1.2 with the following reservations: The LANGUAGE parameter has been discarded. Please use xml:lang literals to express multiple languages. This property can specify multiple comma-separated categories. The order of categories doesn't matter. Please use a separate triple for each category.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#categories"></see></summary>
    let categories = _prefix "categories"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#chairRole"></see>
    /// </summary>
    let chairRole = _prefix "chairRole"
    /// <summary>
    /// Defines the access classification for a calendar component. Inspired by RFC 2445 sec. 4.8.1.3 with the following reservations:  this property has limited vocabulary. Possible values are:  PUBLIC, PRIVATE and CONFIDENTIAL. The default is PUBLIC. Those values are expressed as instances of the AccessClassification class. The user may create his/her own if necessary.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#class"></see></summary>
    let class_ = _prefix "class"
    /// <summary>
    /// Non-processing information intended to provide a comment to the calendar user. Inspired by RFC 2445 sec. 4.8.1.4 with the following reservations:  the LANGUAGE parameter has been discarded. Please use xml:lang literals to express language. For the ALTREP parameter use the commentAltRep property.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#comment"></see></summary>
    let comment = _prefix "comment"
    /// <summary>
    /// Alternate representation of the comment. Introduced to cover
    /// the ALTREP parameter of the COMMENT property. See
    /// documentation of ncal:comment for details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#commentAltRep"></see></summary>
    let commentAltRep = _prefix "commentAltRep"
    /// <summary>
    /// This property defines the date and time that a to-do was actually completed. Inspired by RFC 2445 sec. 4.8.2.1. Note that the RFC allows ONLY UTC time values for this property.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#completed"></see></summary>
    let completed = _prefix "completed"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#completedParticipationStatus"></see>
    /// </summary>
    let completedParticipationStatus = _prefix "completedParticipationStatus"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#completedStatus"></see>
    /// </summary>
    let completedStatus = _prefix "completedStatus"
    /// <summary>
    /// Links the Vcalendar instance with the calendar components. This property has no direct equivalent in the RFC specification. It has been introduced to express the containmnent relations.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#component"></see></summary>
    let component_ = _prefix "component"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#confidentialClassification"></see>
    /// </summary>
    let confidentialClassification = _prefix "confidentialClassification"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#confirmedStatus"></see>
    /// </summary>
    let confirmedStatus = _prefix "confirmedStatus"
    /// <summary>
    /// The property is used to represent contact information or alternately a reference to contact information associated with the calendar component. Inspired by RFC 2445 sec. 4.8.4.2 with the following reservations: the LANGUAGE parameter has been discarded. Please use xml:lang literals to express language. For the ALTREP parameter use the contactAltRep property.RFC doesn't define any format for the string.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#contact"></see></summary>
    let contact = _prefix "contact"
    /// <summary>
    /// Alternate representation of the contact property. Introduced to cover
    /// the ALTREP parameter of the CONTACT property. See
    /// documentation of ncal:contact for details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#contactAltRep"></see></summary>
    let contactAltRep = _prefix "contactAltRep"
    /// <summary>
    /// How many times should an event be repeated. Defined in RFC 2445 sec. 4.3.10
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#count"></see></summary>
    let count = _prefix "count"
    /// <summary>
    /// This property specifies the date and time that the calendar information was created by the calendar user agent in the calendar store. Note: This is analogous to the creation date and time for a file in the file system. Inspired by RFC 2445 sec. 4.8.7.1. Note that this property is a subproperty of nie:created. The domain of nie:created is nie:DataObject. It is not a superclass of UnionOf_Vevent_Vjournal_Vtodo, but since that union is conceived as an 'abstract' class, and in real-life all resources referenced by this property will also be DataObjects, than this shouldn't cause too much of a problem. Note that RFC allows ONLY UTC time values for this property.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#created"></see></summary>
    let created = _prefix "created"
    /// <summary>
    /// To specify the type of calendar user specified by the property. Inspired by RFC 2445 sec. 4.2.3. This parameter has a limited vocabulary. The terms that may serve as values for this property have been expressed as instances of CalendarUserType class. The user may use instances provided with this ontology or create his own.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#cutype"></see></summary>
    let cutype = _prefix "cutype"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#daily"></see>
    /// </summary>
    let daily = _prefix "daily"
    /// <summary>
    /// Date an instance of NcalDateTime refers to. It was conceived to express values in DATE datatype specified in RFC 2445 4.3.4
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#date"></see></summary>
    let date = _prefix "date"
    /// <summary>
    /// Representation of a date an instance of NcalDateTime actually refers to. It's purpose is to express values in DATE-TIME datatype, as defined in RFC 2445 sec. 4.3.5
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#dateTime"></see></summary>
    let dateTime = _prefix "dateTime"
    /// <summary>
    /// Links a timezone with it's daylight observance. This property has no direct equivalent in the RFC 2445. It has been inspired by the structure of the Vtimezone component defined in sec.4.6.5
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#daylight"></see></summary>
    let daylight = _prefix "daylight"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#declinedParticipationStatus"></see>
    /// </summary>
    let declinedParticipationStatus = _prefix "declinedParticipationStatus"
    /// <summary>
    /// To specify the calendar users that have delegated their participation to the calendar user specified by the property. Inspired by RFC 2445 sec. 4.2.4. Originally the value type for this property was CAL-ADDRESS. This has been expressed as nco:Contact to promote integration between NCAL and NCO.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#delegatedFrom"></see></summary>
    let delegatedFrom = _prefix "delegatedFrom"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#delegatedParticipationStatus"></see>
    /// </summary>
    let delegatedParticipationStatus = _prefix "delegatedParticipationStatus"
    /// <summary>
    /// To specify the calendar users to whom the calendar user specified by the property has delegated participation. Inspired by RFC 2445 sec. 4.2.5. Originally the value type for this parameter was CAL-ADDRESS. This has been expressed as nco:Contact to promote integration between NCAL and NCO.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#delegatedTo"></see></summary>
    let delegatedTo = _prefix "delegatedTo"
    /// <summary>
    /// A more complete description of the calendar component, than  that provided by the ncal:summary property.Inspired by RFC 2445 sec. 4.8.1.5 with following reservations:  the LANGUAGE parameter has been discarded. Please use xml:lang literals to express language. For the ALTREP parameter use the descriptionAltRep property.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// Alternate representation of the calendar entity description. Introduced to cover
    /// the ALTREP parameter of the DESCRIPTION property. See
    /// documentation of ncal:description for details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#descriptionAltRep"></see></summary>
    let descriptionAltRep = _prefix "descriptionAltRep"
    /// <summary>
    /// Specifies a reference to a directory entry associated with the calendar user specified by the property. Inspired by RFC 2445 sec. 4.2.6. Originally the data type of the value of this parameter was URI (Usually an LDAP URI). This has been expressed as rdfs:resource.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#dir"></see></summary>
    let dir = _prefix "dir"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#displayAction"></see>
    /// </summary>
    let displayAction = _prefix "displayAction"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#draftStatus"></see>
    /// </summary>
    let draftStatus = _prefix "draftStatus"
    /// <summary>
    /// This property specifies the date and time that a calendar component ends. Inspired by RFC 2445 sec. 4.8.2.2
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#dtend"></see></summary>
    let dtend = _prefix "dtend"
    /// <summary>
    /// The property indicates the date/time that the instance of the iCalendar object was created. Inspired by RFC 2445 sec. 4.8.7.1. Note that the RFC allows ONLY UTC values for this property.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#dtstamp"></see></summary>
    let dtstamp = _prefix "dtstamp"
    /// <summary>
    /// This property specifies when the calendar component begins. Inspired by RFC 2445 sec. 4.8.2.4
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#dtstart"></see></summary>
    let dtstart = _prefix "dtstart"
    /// <summary>
    /// This property defines the date and time that a to-do is expected to be completed. Inspired by RFC 2445 sec. 4.8.2.3
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#due"></see></summary>
    let due = _prefix "due"
    /// <summary>
    /// The property specifies a positive duration of time. Inspired by RFC 2445 sec. 4.8.2.5
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#duration"></see></summary>
    let duration = _prefix "duration"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#emailAction"></see>
    /// </summary>
    let emailAction = _prefix "emailAction"
    /// <summary>
    /// To specify an alternate inline encoding for the property value. Inspired by RFC 2445 sec. 4.2.7. Originally this property had a limited vocabulary. ('8BIT' and 'BASE64'). The terms of this vocabulary have been expressed as instances of the AttachmentEncoding class
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#encoding"></see></summary>
    let encoding = _prefix "encoding"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#endTriggerRelation"></see>
    /// </summary>
    let endTriggerRelation = _prefix "endTriggerRelation"
    /// <summary>
    /// Defines the overall status or confirmation for an Event. Based on the STATUS property defined in RFC 2445 sec. 4.8.1.11.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#eventStatus"></see></summary>
    let eventStatus = _prefix "eventStatus"
    /// <summary>
    /// This property defines the list of date/time exceptions for a recurring calendar component. Inspired by RFC 2445 sec. 4.8.5.1
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#exdate"></see></summary>
    let exdate = _prefix "exdate"
    /// <summary>
    /// This property defines a rule or repeating pattern for an exception to a recurrence set. Inspired by RFC 2445 sec. 4.8.5.2.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#exrule"></see></summary>
    let exrule = _prefix "exrule"
    /// <summary>
    /// To specify the free or busy time type. Inspired by RFC 2445 sec. 4.2.9. The RFC specified a limited vocabulary for the values of this property. The terms of this vocabulary have been expressed as instances of the FreebusyType class. The user can use instances provided with this ontology or create his own.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#fbtype"></see></summary>
    let fbtype = _prefix "fbtype"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#finalStatus"></see>
    /// </summary>
    let finalStatus = _prefix "finalStatus"
    /// <summary>
    /// To specify the content type of a referenced object. Inspired by RFC 2445 sec. 4.2.8. The value of this property should be an IANA-registered content type (e.g. application/binary)
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#fmttype"></see></summary>
    let fmttype = _prefix "fmttype"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#freeFreebusyType"></see>
    /// </summary>
    let freeFreebusyType = _prefix "freeFreebusyType"
    /// <summary>
    /// The property defines one or more free or busy time intervals. Inspired by RFC 2445 sec. 4.8.2.6. Note that the periods specified by this property can only be expressed with UTC times. Originally this property could have many comma-separated values. Please use a separate triple for each value.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#freebusy"></see></summary>
    let freebusy = _prefix "freebusy"
    /// <summary>
    /// Frequency of a recurrence rule. Defined in RFC 2445 sec. 4.3.10
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#freq"></see></summary>
    let freq = _prefix "freq"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#friday"></see>
    /// </summary>
    let friday = _prefix "friday"
    /// <summary>
    /// This property specifies information related to the global position for the activity specified by a calendar component. Inspired by RFC 2445 sec. 4.8.1.6
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#geo"></see></summary>
    let geo = _prefix "geo"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#gregorianCalendarScale"></see>
    /// </summary>
    let gregorianCalendarScale = _prefix "gregorianCalendarScale"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#groupUserType"></see>
    /// </summary>
    let groupUserType = _prefix "groupUserType"
    /// <summary>
    /// Links an event or a todo with a DataObject that can be interpreted as an alarm. This property has no direct equivalent in the RFC 2445. It has been provided to express this relation.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#hasAlarm"></see></summary>
    let hasAlarm = _prefix "hasAlarm"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#hourly"></see>
    /// </summary>
    let hourly = _prefix "hourly"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#inProcessParticipationStatus"></see>
    /// </summary>
    let inProcessParticipationStatus = _prefix "inProcessParticipationStatus"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#inProcessStatus"></see>
    /// </summary>
    let inProcessStatus = _prefix "inProcessStatus"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#individualUserType"></see>
    /// </summary>
    let individualUserType = _prefix "individualUserType"
    /// <summary>
    /// The INTERVAL rule part contains a positive integer representing how often the recurrence rule repeats. The default value is "1", meaning every second for a SECONDLY rule, or every minute for a MINUTELY rule, every hour for an HOURLY rule, every day for a DAILY rule, every week for a WEEKLY rule, every month for a MONTHLY rule andevery year for a YEARLY rule. Defined in RFC 2445 sec. 4.3.10
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#interval"></see></summary>
    let interval = _prefix "interval"
    /// <summary>
    /// A contact of the Attendee or the organizer involved in an event or other calendar entity. This property has been introduced to express the actual value of the ATTENDEE and ORGANIZER properties. The contact will also represent the CN parameter of those properties. See documentation of ncal:attendee or ncal:organizer for more details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#involvedContact"></see></summary>
    let involvedContact = _prefix "involvedContact"
    /// <summary>
    /// Defines the overall status or confirmation for a journal entry. Based on the STATUS property defined in RFC 2445 sec. 4.8.1.11.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#journalStatus"></see></summary>
    let journalStatus = _prefix "journalStatus"
    /// <summary>
    /// The property specifies the date and time that the information associated with the calendar component was last revised in the calendar store. Note: This is analogous to the modification date and time for a file in the file system. Inspired by RFC 2445 sec. 4.8.7.3. Note that the RFC allows ONLY UTC time values for this property.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#lastModified"></see></summary>
    let lastModified = _prefix "lastModified"
    /// <summary>
    /// Defines the intended venue for the activity defined by a calendar component. Inspired by RFC 2445 sec 4.8.1.7 with the following reservations:  the LANGUAGE parameter has been discarded. Please use xml:lang literals to express language.  For the ALTREP parameter use the locationAltRep property.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#location"></see></summary>
    let location = _prefix "location"
    /// <summary>
    /// Alternate representation of the event or todo location.
    /// Introduced to cover the ALTREP parameter of the LOCATION
    /// property. See documentation of ncal:location for details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#locationAltRep"></see></summary>
    let locationAltRep = _prefix "locationAltRep"
    /// <summary>
    /// To specify the group or list membership of the calendar user specified by the property. Inspired by RFC 2445 sec. 4.2.11. Originally this parameter had a value type of CAL-ADDRESS. This has been expressed as nco:Contact to promote integration between NCAL and NCO
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#member"></see></summary>
    let member_ = _prefix "member"
    /// <summary>
    /// This property defines the iCalendar object method associated with the calendar object. Defined in RFC 2445 sec. 4.7.2
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#method"></see></summary>
    let method = _prefix "method"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#minutely"></see>
    /// </summary>
    let minutely = _prefix "minutely"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#monday"></see>
    /// </summary>
    let monday = _prefix "monday"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#monthly"></see>
    /// </summary>
    let monthly = _prefix "monthly"
    /// <summary>
    /// A common superproperty for all types of ncal relations. It is not to be used directly.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#ncalRelation"></see></summary>
    let ncalRelation = _prefix "ncalRelation"
    /// <summary>
    /// The timezone instance that should be used to interpret an NcalDateTime. The purpose of this property is similar to the TZID parameter specified in RFC 2445 sec. 4.2.19
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#ncalTimezone"></see></summary>
    let ncalTimezone = _prefix "ncalTimezone"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#needsActionParticipationStatus"></see>
    /// </summary>
    let needsActionParticipationStatus = _prefix "needsActionParticipationStatus"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#needsActionStatus"></see>
    /// </summary>
    let needsActionStatus = _prefix "needsActionStatus"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#nonParticipantRole"></see>
    /// </summary>
    let nonParticipantRole = _prefix "nonParticipantRole"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#opaqueTransparency"></see>
    /// </summary>
    let opaqueTransparency = _prefix "opaqueTransparency"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#optParticipantRole"></see>
    /// </summary>
    let optParticipantRole = _prefix "optParticipantRole"
    /// <summary>
    /// The property defines the organizer for a calendar component. Inspired by RFC 2445 sec. 4.8.4.3. Originally this property accepted many parameters. The Organizer class has been introduced to express them all. Note that NCAL is aligned with NCO. The actual value (of the CAL-ADDRESS type) is expressed as an instance of nco:Contact. Remember that the CN parameter has been removed from NCAL. Instead that value should be expressed using nco:fullname property of the above mentioned nco:Contact instance.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#organizer"></see></summary>
    let organizer = _prefix "organizer"
    /// <summary>
    /// To specify the participation status for the calendar user specified by the property. Inspired by RFC 2445 sec. 4.2.12. Originally this parameter had three sets of allowed values. Which set applied to a particular case - depended on the type of calendar entity this parameter occured in. (event, todo, journal entry). This would be awkward to model in RDF so a single ParticipationStatus class has been introduced. Terms of the values vocabulary are expressed as instances of this class. Users are advised to pay attention which instances they use.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#partstat"></see></summary>
    let partstat = _prefix "partstat"
    /// <summary>
    /// This property is used by an assignee or delegatee of a to-do to convey the percent completion of a to-do to the Organizer. Inspired by RFC 2445 sec. 4.8.1.8
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#percentComplete"></see></summary>
    let percentComplete = _prefix "percentComplete"
    /// <summary>
    /// Beginng of a period. Inspired by the first part of a structured value of the PERIOD datatype specified in RFC 2445 sec. 4.3.9
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#periodBegin"></see></summary>
    let periodBegin = _prefix "periodBegin"
    /// <summary>
    /// Duration of a period of time. Inspired by the second part of a structured value of the PERIOD datatype specified in RFC 2445 sec. 4.3.9. Note that a single NcalPeriod instance shouldn't have the periodEnd and periodDuration properties specified simultaneously.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#periodDuration"></see></summary>
    let periodDuration = _prefix "periodDuration"
    /// <summary>
    /// End of a period of time. Inspired by the second part of a structured value of a PERIOD datatype specified in RFC 2445 sec. 4.3.9. Note that a single NcalPeriod instance shouldn't have the periodEnd and periodDuration properties specified simultaneously.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#periodEnd"></see></summary>
    let periodEnd = _prefix "periodEnd"
    /// <summary>
    /// The property defines the relative priority for a calendar component. Inspired by RFC 2445 sec. 4.8.1.9
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#priority"></see></summary>
    let priority = _prefix "priority"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#privateClassification"></see>
    /// </summary>
    let privateClassification = _prefix "privateClassification"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#procedureAction"></see>
    /// </summary>
    let procedureAction = _prefix "procedureAction"
    /// <summary>
    /// This property specifies the identifier for the product that created the iCalendar object. Defined in RFC 2445 sec. 4.7.2
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#prodid"></see></summary>
    let prodid = _prefix "prodid"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#publicClassification"></see>
    /// </summary>
    let publicClassification = _prefix "publicClassification"
    /// <summary>
    /// To specify the effective range of recurrence instances from the instance specified by the recurrence identifier specified by the property. It is intended to express the RANGE parameter specified in RFC 2445 sec. 4.2.13. The set of possible values for this property is limited. See also the documentation for ncal:recurrenceId for more details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#range"></see></summary>
    let range = _prefix "range"
    /// <summary>
    /// This property defines the list of date/times for a recurrence set. Inspired by RFC 2445 sec. 4.8.5.3. Note that RFC allows both DATE, DATE-TIME and PERIOD values for this property. That's why the range has been set to NcalTimeEntity.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#rdate"></see></summary>
    let rdate = _prefix "rdate"
    /// <summary>
    /// This property is used in conjunction with the "UID" and "SEQUENCE" property to identify a specific instance of a recurring "VEVENT", "VTODO" or "VJOURNAL" calendar component. The property value is the effective value of the "DTSTART" property of the recurrence instance. Inspired by the RFC 2445 sec. 4.8.4.4
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#recurrenceId"></see></summary>
    let recurrenceId = _prefix "recurrenceId"
    /// <summary>
    /// The date and time of a recurrence identifier. Provided to express the actual value of the ncal:recurrenceId property. See documentation for ncal:recurrenceId for details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#recurrenceIdDateTime"></see></summary>
    let recurrenceIdDateTime = _prefix "recurrenceIdDateTime"
    /// <summary>
    /// To specify the relationship of the alarm trigger with respect to the start or end of the calendar component. Inspired by RFC 2445 4.2.14. The RFC has specified two possible values for this property ('START' and 'END') they have been expressed as instances of the TriggerRelation class.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#related"></see></summary>
    let related = _prefix "related"
    /// <summary>
    /// The property is used to represent a relationship or reference between one calendar component and another. Inspired by RFC 2445 sec. 4.8.4.5. Originally this property had a RELTYPE parameter. It has been decided to introduce three different properties to express the values of that parameter. This property expresses the RELATED-TO property with RELTYPE=CHILD parameter.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#relatedToChild"></see></summary>
    let relatedToChild = _prefix "relatedToChild"
    /// <summary>
    /// The property is used to represent a relationship or reference between one calendar component and another. Inspired by RFC 2445 sec. 4.8.4.5. Originally this property had a RELTYPE parameter. It has been decided that it is more natural to introduce three different properties to express the values of that parameter. This property expresses the RELATED-TO property with no RELTYPE parameter (the default value is PARENT), or with explicit RELTYPE=PARENT parameter.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#relatedToParent"></see></summary>
    let relatedToParent = _prefix "relatedToParent"
    /// <summary>
    /// The property is used to represent a relationship or reference between one calendar component and another. Inspired by RFC 2445 sec. 4.8.4.5. Originally this property had a RELTYPE parameter. It has been decided that it is more natural to introduce three different properties to express the values of that parameter. This property expresses the RELATED-TO property with RELTYPE=SIBLING parameter.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#relatedToSibling"></see></summary>
    let relatedToSibling = _prefix "relatedToSibling"
    /// <summary>
    /// This property defines the number of time the alarm should be repeated, after the initial trigger. Inspired by RFC 2445 sec. 4.8.6.2
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#repeat"></see></summary>
    let repeat = _prefix "repeat"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#reqParticipantRole"></see>
    /// </summary>
    let reqParticipantRole = _prefix "reqParticipantRole"
    /// <summary>
    /// This property defines the status code returned for a scheduling request. Inspired by RFC 2445 sec. 4.8.8.2. Original value of this property was a four-element structure. The RequestStatus class has been introduced to express it. In RFC 2445 this property could have the LANGUAGE parameter. This has been discarded in this ontology. Use xml:lang literals to express it if necessary.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#requestStatus"></see></summary>
    let requestStatus = _prefix "requestStatus"
    /// <summary>
    /// Additional data associated with a request status. Inspired by the third part of the structured value for the REQUEST-STATUS property defined in RFC 2445 sec. 4.8.8.2 ("Textual exception data. For example, the offending property name and value or complete property line")
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#requestStatusData"></see></summary>
    let requestStatusData = _prefix "requestStatusData"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#resourceUserType"></see>
    /// </summary>
    let resourceUserType = _prefix "resourceUserType"
    /// <summary>
    /// Defines the equipment or resources anticipated for an activity specified by a calendar entity. Inspired by RFC 2445 sec. 4.8.1.10 with the following reservations:  the LANGUAGE parameter has been discarded. Please use xml:lang literals to express language. For the ALTREP parameter use the resourcesAltRep property. This property specifies multiple resources. The order is not important. it is recommended to introduce a separate triple for each resource.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#resources"></see></summary>
    let resources = _prefix "resources"
    /// <summary>
    /// Alternate representation of the resources needed for an event or todo. Introduced to cover the ALTREP parameter of the resources property. See documentation for ncal:resources for details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#resourcesAltRep"></see></summary>
    let resourcesAltRep = _prefix "resourcesAltRep"
    /// <summary>
    /// Short return status. Inspired by the first element of the structured value of the REQUEST-STATUS property described in RFC 2445 sec. 4.8.8.2.
    ///
    /// The short return status is a PERIOD character (US-ASCII decimal 46) separated 3-tuple of integers. For example, "3.1.1". The successive  levels of integers provide for a successive level of status code granularity.
    ///
    /// The following are initial classes for the return status code. Individual iCalendar object methods will define specific return status codes for these classes. In addition, other classes for the return status code may be defined using the registration process defined later in this memo.
    ///
    ///  1.xx - Preliminary success. This class of status of status code indicates that the request has request has been initially processed but that completion is pending.
    ///
    /// 2.xx -Successful. This class of status code indicates that the request was completed successfuly. However, the exact status code can indicate that a fallback has been taken.
    ///
    /// 3.xx - Client Error. This class of status code indicates that the request was not successful. The error is the result of either a syntax or a semantic error in the client formatted request. Request should not be retried until the condition in the request is corrected.
    ///
    /// 4.xx - Scheduling Error. This class of status code indicates that the request was not successful. Some sort of error occurred within the  calendaring and scheduling service, not directly related to the request itself.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#returnStatus"></see></summary>
    let returnStatus = _prefix "returnStatus"
    /// <summary>
    /// To specify the participation role for the calendar user specified by the property. Inspired by the RFC 2445 sec. 4.2.16. Originally this property had a limited vocabulary for values. The terms of that vocabulary have been expressed as instances of the AttendeeRole class.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#role"></see></summary>
    let role = _prefix "role"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#roomUserType"></see>
    /// </summary>
    let roomUserType = _prefix "roomUserType"
    /// <summary>
    /// This property defines a rule or repeating pattern for recurring events, to-dos, or time zone definitions. sec. 4.8.5.4
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#rrule"></see></summary>
    let rrule = _prefix "rrule"
    /// <summary>
    /// To specify whether there is an expectation of a favor of a reply from the calendar user specified by the property value. Inspired by RFC 2445 sec. 4.2.17
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#rsvp"></see></summary>
    let rsvp = _prefix "rsvp"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#saturday"></see>
    /// </summary>
    let saturday = _prefix "saturday"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#secondly"></see>
    /// </summary>
    let secondly = _prefix "secondly"
    /// <summary>
    /// To specify the calendar user that is acting on behalf of the calendar user specified by the property. Inspired by RFC 2445 sec. 4.2.18. The original data type of this property was a mailto: URI. This has been changed to nco:Contact to promote integration between NCO and NCAL.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#sentBy"></see></summary>
    let sentBy = _prefix "sentBy"
    /// <summary>
    /// This property defines the revision sequence number of the calendar component within a sequence of revisions. Inspired by RFC 2445 sec. 4.8.7.4
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#sequence"></see></summary>
    let sequence = _prefix "sequence"
    /// <summary>
    /// Links the timezone with the standard timezone observance. This property has no direct equivalent in the RFC 2445. It has been inspired by the structure of the Vtimezone component defined in sec.4.6.5
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#standard"></see></summary>
    let standard = _prefix "standard"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#startTriggerRelation"></see>
    /// </summary>
    let startTriggerRelation = _prefix "startTriggerRelation"
    /// <summary>
    /// Longer return status description. Inspired by the second part of the structured value of the REQUEST-STATUS property defined in RFC 2445 sec. 4.8.8.2
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#statusDescription"></see></summary>
    let statusDescription = _prefix "statusDescription"
    /// <summary>
    /// Defines a short summary or subject for the calendar component. Inspired by RFC 2445 sec 4.8.1.12 with the following reservations: the LANGUAGE parameter has been discarded. Please use xml:lang literals to express language. For the ALTREP parameter use the summaryAltRep property.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#summary"></see></summary>
    let summary = _prefix "summary"
    /// <summary>
    /// Alternate representation of the comment. Introduced to cover
    /// the ALTREP parameter of the SUMMARY property. See
    /// documentation of ncal:summary for details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#summaryAltRep"></see></summary>
    let summaryAltRep = _prefix "summaryAltRep"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#sunday"></see>
    /// </summary>
    let sunday = _prefix "sunday"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#tentativeParticipationStatus"></see>
    /// </summary>
    let tentativeParticipationStatus = _prefix "tentativeParticipationStatus"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#tentativeStatus"></see>
    /// </summary>
    let tentativeStatus = _prefix "tentativeStatus"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#thisAndFutureRange"></see>
    /// </summary>
    let thisAndFutureRange = _prefix "thisAndFutureRange"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#thisAndPriorRange"></see>
    /// </summary>
    let thisAndPriorRange = _prefix "thisAndPriorRange"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#thursday"></see>
    /// </summary>
    let thursday = _prefix "thursday"
    /// <summary>
    /// Defines the overall status or confirmation for a todo. Based on the STATUS property defined in RFC 2445 sec. 4.8.1.11.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#todoStatus"></see></summary>
    let todoStatus = _prefix "todoStatus"
    /// <summary>
    /// Defines whether an event is transparent or not  to busy time searches. Inspired by RFC 2445 sec.4.8.2.7. Values for this property can be chosen from a limited vocabulary. To express this a TimeTransparency class has been introduced.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#transp"></see></summary>
    let transp = _prefix "transp"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#transparentTransparency"></see>
    /// </summary>
    let transparentTransparency = _prefix "transparentTransparency"
    /// <summary>
    /// This property specifies when an alarm will trigger. Inspired by RFC 2445 sec. 4.8.6.3 Originally the value of this property could accept two types : duration and date-time. To express this fact a Trigger class has been introduced. It also has a related property to account for the RELATED parameter.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#trigger"></see></summary>
    let trigger = _prefix "trigger"
    /// <summary>
    /// The exact date and time of the trigger. This property has been created to express the VALUE=DATE, and VALUE=DATE-TIME parameters of the TRIGGER property. See the documentation for ncal:trigger for more details
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#triggerDateTime"></see></summary>
    let triggerDateTime = _prefix "triggerDateTime"
    /// <summary>
    /// The duration of a trigger. This property has been created to express the VALUE=DURATION parameter of the TRIGGER property. See documentation for ncal:trigger for more details.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#triggerDuration"></see></summary>
    let triggerDuration = _prefix "triggerDuration"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#tuesday"></see>
    /// </summary>
    let tuesday = _prefix "tuesday"
    /// <summary>
    /// This property specifies the text value that uniquely identifies the "VTIMEZONE" calendar component. Inspired by RFC 2445 sec 4.8.3.1
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#tzid"></see></summary>
    let tzid = _prefix "tzid"
    /// <summary>
    /// Specifies the customary designation for a timezone description. Inspired by RFC 2445 sec. 4.8.3.2 The LANGUAGE parameter has been discarded. Please xml:lang literals to express languages. Original specification for the domain of this property stated that it must appear within the timezone component. In this ontology the TimezoneObservance class has been itroduced to clarify this specification.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#tzname"></see></summary>
    let tzname = _prefix "tzname"
    /// <summary>
    /// This property specifies the offset which is in use prior to this time zone observance. Inspired by RFC 2445 sec. 4.8.3.3. The original domain was underspecified. It said that this property must appear within a Timezone component. In this ontology a TimezoneObservance class has been introduced to clarify this specification. The original range was UTC-OFFSET. There is no equivalent among the XSD datatypes so plain string was chosen.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#tzoffsetfrom"></see></summary>
    let tzoffsetfrom = _prefix "tzoffsetfrom"
    /// <summary>
    /// This property specifies the offset which is in use in this time zone observance. nspired by RFC 2445 sec. 4.8.3.4. The original domain was underspecified. It said that this property must appear within a Timezone component. In this ontology a TimezoneObservance class has been introduced to clarify this specification. The original range was UTC-OFFSET. There is no equivalent among the XSD datatypes so plain string was chosen.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#tzoffsetto"></see></summary>
    let tzoffsetto = _prefix "tzoffsetto"
    /// <summary>
    /// The TZURL provides a means for a VTIMEZONE component to point to a network location that can be used to retrieve an up-to- date version of itself. Inspired by RFC 2445 sec. 4.8.3.5. Originally the range of this property had been specified as URI.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#tzurl"></see></summary>
    let tzurl = _prefix "tzurl"
    /// <summary>
    /// This property defines the persistent, globally unique identifier for the calendar component. Inspired by the RFC 2445 sec 4.8.4.7
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#uid"></see></summary>
    let uid = _prefix "uid"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#unknownUserType"></see>
    /// </summary>
    let unknownUserType = _prefix "unknownUserType"
    /// <summary>
    /// The UNTIL rule part defines a date-time value which bounds the recurrence rule in an inclusive manner. If the value specified by UNTIL is synchronized with the specified recurrence, this date or date-time becomes the last instance of the recurrence. If specified as a date-time value, then it MUST be specified in an UTC time format. If not present, and the COUNT rule part is also not present, the RRULE is considered to repeat forever.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#until"></see></summary>
    let until = _prefix "until"
    /// <summary>
    /// This property defines a Uniform Resource Locator (URL) associated with the iCalendar object. Inspired by the RFC 2445 sec. 4.8.4.6. Original range had been specified as URI.
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#url"></see></summary>
    let url = _prefix "url"
    /// <summary>
    /// This property specifies the identifier corresponding to the highest version number or the minimum and maximum range of the iCalendar specification that is required in order to interpret the iCalendar object. Defined in RFC 2445 sec. 4.7.4
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#version"></see></summary>
    let version = _prefix "version"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#wednesday"></see>
    /// </summary>
    let wednesday = _prefix "wednesday"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#weekly"></see>
    /// </summary>
    let weekly = _prefix "weekly"
    /// <summary>
    /// The day that's counted as the start of the week. It is used to disambiguate the byweekno rule. Defined in RFC 2445 sec. 4.3.10
    /// <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#wkst"></see></summary>
    let wkst = _prefix "wkst"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#yearly"></see>
    /// </summary>
    let yearly = _prefix "yearly"
