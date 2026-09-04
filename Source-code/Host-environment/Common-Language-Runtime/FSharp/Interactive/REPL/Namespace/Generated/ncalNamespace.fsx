#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ncal =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#" "ncal"

    /// <summary>
    ///   <para>rdfs:label : AccessClassification^^xsd:string</para>
    ///   <para>rdfs:comment : Access classification of a calendar component. Introduced to express
    /// the set of values for the ncal:class property. The user may use instances
    /// provided with this ontology or create his/her own with desired semantics.
    /// See the documentation of ncal:class for details.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#AccessClassification">ncal:AccessClassification</a>
    /// </summary>
    let AccessClassification = _prefixId.prefix "AccessClassification"
    /// <summary>
    ///   <para>rdfs:label : Alarm^^xsd:string</para>
    ///   <para>rdfs:comment : Provide a grouping of component properties that define an alarm.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Alarm">ncal:Alarm</a>
    /// </summary>
    let Alarm = _prefixId.prefix "Alarm"
    /// <summary>
    ///   <para>rdfs:label : AlarmAction^^xsd:string</para>
    ///   <para>rdfs:comment : Action to be performed on alarm. This class has been introduced to express the limited set of values of the ncal:action property. Please refer to the documentation of ncal:action for details.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#AlarmAction">ncal:AlarmAction</a>
    /// </summary>
    let AlarmAction = _prefixId.prefix "AlarmAction"
    /// <summary>
    ///   <para>rdfs:label : Attachment^^xsd:string</para>
    ///   <para>rdfs:comment : An object attached to a calendar entity. This class has been introduced to serve as a structured value of the ncal:attach property. See the documentation of ncal:attach for details.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Attachment">ncal:Attachment</a>
    /// </summary>
    let Attachment = _prefixId.prefix "Attachment"
    /// <summary>
    ///   <para>rdfs:label : AttachmentEncoding^^xsd:string</para>
    ///   <para>rdfs:comment : Attachment encoding. This class has been introduced to express the limited vocabulary of values for the ncal:encoding property. See the documentation of ncal:encoding for details.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#AttachmentEncoding">ncal:AttachmentEncoding</a>
    /// </summary>
    let AttachmentEncoding = _prefixId.prefix "AttachmentEncoding"
    /// <summary>
    ///   <para>rdfs:label : Attendee^^xsd:string</para>
    ///   <para>rdfs:comment : An attendee of an event. This class has been introduced to serve as the range for ncal:attendee property. See documentation of ncal:attendee for details.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Attendee">ncal:Attendee</a>
    /// </summary>
    let Attendee = _prefixId.prefix "Attendee"
    /// <summary>
    ///   <para>rdfs:label : AttendeeOrOrganizer^^xsd:string</para>
    ///   <para>rdfs:comment : A common superclass for ncal:Attendee and ncal:Organizer.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#AttendeeOrOrganizer">ncal:AttendeeOrOrganizer</a>
    /// </summary>
    let AttendeeOrOrganizer = _prefixId.prefix "AttendeeOrOrganizer"
    /// <summary>
    ///   <para>rdfs:label : AttendeeRole^^xsd:string</para>
    ///   <para>rdfs:comment : A role the attendee is going to play during an event. This class has been introduced to express the limited vocabulary for the values of ncal:role property. Please refer to the documentation of ncal:role for details.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#AttendeeRole">ncal:AttendeeRole</a>
    /// </summary>
    let AttendeeRole = _prefixId.prefix "AttendeeRole"
    /// <summary>
    ///   <para>rdfs:label : BydayRulePart^^xsd:string</para>
    ///   <para>rdfs:comment : Expresses the compound value of a byday part of a recurrence rule. It stores the weekday and the integer modifier. Inspired by RFC 2445 sec. 4.3.10^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#BydayRulePart">ncal:BydayRulePart</a>
    /// </summary>
    let BydayRulePart = _prefixId.prefix "BydayRulePart"
    /// <summary>
    ///   <para>rdfs:label : Calendar^^xsd:string</para>
    ///   <para>rdfs:comment : A calendar. Inspirations for this class can be traced to the VCALENDAR component defined in RFC 2445 sec. 4.4, but it may just as well be used to represent any kind of Calendar.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Calendar">ncal:Calendar</a>
    /// </summary>
    let Calendar = _prefixId.prefix "Calendar"
    /// <summary>
    ///   <para>rdfs:label : CalendarDataObject^^xsd:string</para>
    ///   <para>rdfs:comment : A DataObject found in a calendar. It is usually interpreted as one of the calendar entity types (e.g. Event, Journal, Todo etc.)^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#CalendarDataObject">ncal:CalendarDataObject</a>
    /// </summary>
    let CalendarDataObject = _prefixId.prefix "CalendarDataObject"
    /// <summary>
    ///   <para>rdfs:label : CalendarScale^^xsd:string</para>
    ///   <para>rdfs:comment : A calendar scale. This class has been introduced to provide the limited vocabulary for the ncal:calscale property.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#CalendarScale">ncal:CalendarScale</a>
    /// </summary>
    let CalendarScale = _prefixId.prefix "CalendarScale"
    /// <summary>
    ///   <para>rdfs:label : CalendarUserType^^xsd:string</para>
    ///   <para>rdfs:comment : A calendar user type. This class has been introduced to express the limited vocabulary for the ncal:cutype property. See documentation of ncal:cutype for details.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#CalendarUserType">ncal:CalendarUserType</a>
    /// </summary>
    let CalendarUserType = _prefixId.prefix "CalendarUserType"
    /// <summary>
    ///   <para>rdfs:comment : Provide a grouping of component properties that describe an event.^^xsd:string</para>
    ///   <para>rdfs:label : Event^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Event">ncal:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>rdfs:label : EventStatus^^xsd:string</para>
    ///   <para>rdfs:comment : A status of an event. This class has been introduced to express
    /// the limited set of values for the ncal:status property. The user may
    /// use the instances provided with this ontology or create his/her own.
    /// See the documentation for ncal:eventStatus for details.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#EventStatus">ncal:EventStatus</a>
    /// </summary>
    let EventStatus = _prefixId.prefix "EventStatus"
    /// <summary>
    ///   <para>rdfs:label : Freebusy^^xsd:string</para>
    ///   <para>rdfs:comment : Provide a grouping of component properties that describe either a request for free/busy time, describe a response to a request for free/busy time or describe a published set of busy time.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Freebusy">ncal:Freebusy</a>
    /// </summary>
    let Freebusy = _prefixId.prefix "Freebusy"
    /// <summary>
    ///   <para>rdfs:label : FreebusyPeriod^^xsd:string</para>
    ///   <para>rdfs:comment : An aggregate of a period and a freebusy type. This class has been introduced to serve as a range of the ncal:freebusy property. See documentation for ncal:freebusy for details. Note that the specification of freebusy property states that the period is to be expressed using UTC time, so the timezone properties should NOT be used for instances of this class.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#FreebusyPeriod">ncal:FreebusyPeriod</a>
    /// </summary>
    let FreebusyPeriod = _prefixId.prefix "FreebusyPeriod"
    /// <summary>
    ///   <para>rdfs:label : FreebusyType^^xsd:string</para>
    ///   <para>rdfs:comment : Type of a Freebusy indication. This class has been introduced to serve as a limited set of values for the ncal:fbtype property. See the documentation of ncal:fbtype for details.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#FreebusyType">ncal:FreebusyType</a>
    /// </summary>
    let FreebusyType = _prefixId.prefix "FreebusyType"
    /// <summary>
    ///   <para>rdfs:label : Journal^^xsd:string</para>
    ///   <para>rdfs:comment : Provide a grouping of component properties that describe a journal entry.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Journal">ncal:Journal</a>
    /// </summary>
    let Journal = _prefixId.prefix "Journal"
    /// <summary>
    ///   <para>rdfs:label : JournalStatus^^xsd:string</para>
    ///   <para>rdfs:comment : A status of a journal entry. This class has been introduced to express
    /// the limited set of values for the ncal:status property. The user may
    /// use the instances provided with this ontology or create his/her own.
    /// See the documentation for ncal:journalStatus for details.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#JournalStatus">ncal:JournalStatus</a>
    /// </summary>
    let JournalStatus = _prefixId.prefix "JournalStatus"
    /// <summary>
    ///   <para>rdfs:label : NcalDateTime^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#NcalDateTime">ncal:NcalDateTime</a>
    /// </summary>
    let NcalDateTime = _prefixId.prefix "NcalDateTime"
    /// <summary>
    ///   <para>rdfs:label : NcalPeriod^^xsd:string</para>
    ///   <para>rdfs:comment : A period of time. Inspired by the PERIOD datatype specified in RFC 2445 sec. 4.3.9^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#NcalPeriod">ncal:NcalPeriod</a>
    /// </summary>
    let NcalPeriod = _prefixId.prefix "NcalPeriod"
    /// <summary>
    ///   <para>rdfs:label : NcalTimeEntity^^xsd:string</para>
    ///   <para>rdfs:comment : A time entity. Conceived as a common superclass for NcalDateTime and NcalPeriod. According to RFC 2445 both DateTime and Period can be interpreted in different timezones. The first case is explored in many properties. The second case is theoretically possible in ncal:rdate property. Therefore the timezone properties have been defined at this level.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#NcalTimeEntity">ncal:NcalTimeEntity</a>
    /// </summary>
    let NcalTimeEntity = _prefixId.prefix "NcalTimeEntity"
    /// <summary>
    ///   <para>rdfs:label : Organizer^^xsd:string</para>
    ///   <para>rdfs:comment : An organizer of an event. This class has been introduced to serve as a range of ncal:organizer property. See documentation of ncal:organizer for details.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Organizer">ncal:Organizer</a>
    /// </summary>
    let Organizer = _prefixId.prefix "Organizer"
    /// <summary>
    ///   <para>rdfs:label : ParticipationStatus^^xsd:string</para>
    ///   <para>rdfs:comment : Participation Status. This class has been introduced to express the limited vocabulary of values for the ncal:partstat property. See the documentation of ncal:partstat for details.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#ParticipationStatus">ncal:ParticipationStatus</a>
    /// </summary>
    let ParticipationStatus = _prefixId.prefix "ParticipationStatus"
    /// <summary>
    ///   <para>rdfs:label : RecurrenceFrequency^^xsd:string</para>
    ///   <para>rdfs:comment : Frequency of a recurrence rule. This class has been introduced to express a limited set of allowed values for the ncal:freq property. See the documentation of ncal:freq for details.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#RecurrenceFrequency">ncal:RecurrenceFrequency</a>
    /// </summary>
    let RecurrenceFrequency = _prefixId.prefix "RecurrenceFrequency"
    /// <summary>
    ///   <para>rdfs:label : RecurrenceIdentifier^^xsd:string</para>
    ///   <para>rdfs:comment : Recurrence Identifier. Introduced to provide a structure for the value of ncal:recurrenceId property. See the documentation of ncal:recurrenceId for details.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#RecurrenceIdentifier">ncal:RecurrenceIdentifier</a>
    /// </summary>
    let RecurrenceIdentifier = _prefixId.prefix "RecurrenceIdentifier"
    /// <summary>
    ///   <para>rdfs:label : RecurrenceIdentifierRange^^xsd:string</para>
    ///   <para>rdfs:comment : Recurrence Identifier Range. This class has been created to provide means to express the limited set of values for the ncal:range property. See documentation for ncal:range for details.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#RecurrenceIdentifierRange">ncal:RecurrenceIdentifierRange</a>
    /// </summary>
    let RecurrenceIdentifierRange = _prefixId.prefix "RecurrenceIdentifierRange"
    /// <summary>
    ///   <para>rdfs:label : RecurrenceRule^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#RecurrenceRule">ncal:RecurrenceRule</a>
    /// </summary>
    let RecurrenceRule = _prefixId.prefix "RecurrenceRule"
    /// <summary>
    ///   <para>rdfs:label : RequestStatus^^xsd:string</para>
    ///   <para>rdfs:comment : Request Status. A class that was introduced to provide a structure for the value of ncal:requestStatus property. See documentation for ncal:requestStatus for details.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#RequestStatus">ncal:RequestStatus</a>
    /// </summary>
    let RequestStatus = _prefixId.prefix "RequestStatus"
    /// <summary>
    ///   <para>rdfs:label : TimeTransparency^^xsd:string</para>
    ///   <para>rdfs:comment : Time transparency. Introduced to provide a way to express
    /// the limited vocabulary for the values of ncal:transp property.
    /// See documentation of ncal:transp for details.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#TimeTransparency">ncal:TimeTransparency</a>
    /// </summary>
    let TimeTransparency = _prefixId.prefix "TimeTransparency"
    /// <summary>
    ///   <para>rdfs:label : Timezone^^xsd:string</para>
    ///   <para>rdfs:comment : Provide a grouping of component properties that defines a time zone.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Timezone">ncal:Timezone</a>
    /// </summary>
    let Timezone = _prefixId.prefix "Timezone"
    /// <summary>
    ///   <para>rdfs:label : TimezoneObservance^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#TimezoneObservance">ncal:TimezoneObservance</a>
    /// </summary>
    let TimezoneObservance = _prefixId.prefix "TimezoneObservance"
    /// <summary>
    ///   <para>rdfs:comment : Provide a grouping of calendar properties that describe a to-do.^^xsd:string</para>
    ///   <para>rdfs:label : Todo^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Todo">ncal:Todo</a>
    /// </summary>
    let Todo = _prefixId.prefix "Todo"
    /// <summary>
    ///   <para>rdfs:label : TodoStatus^^xsd:string</para>
    ///   <para>rdfs:comment : A status of a calendar entity. This class has been introduced to express
    /// the limited set of values for the ncal:status property. The user may
    /// use the instances provided with this ontology or create his/her own.
    /// See the documentation for ncal:todoStatus for details.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#TodoStatus">ncal:TodoStatus</a>
    /// </summary>
    let TodoStatus = _prefixId.prefix "TodoStatus"
    /// <summary>
    ///   <para>rdfs:label : Trigger^^xsd:string</para>
    ///   <para>rdfs:comment : An alarm trigger. This class has been created to serve as the range of ncal:trigger property. See the documentation for ncal:trigger for more details.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Trigger">ncal:Trigger</a>
    /// </summary>
    let Trigger = _prefixId.prefix "Trigger"
    /// <summary>
    ///   <para>rdfs:label : TriggerRelation^^xsd:string</para>
    ///   <para>rdfs:comment : The relation between the trigger and its parent calendar component. This class has been introduced to express the limited vocabulary for the ncal:related property. See the documentation for ncal:related for more details.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#TriggerRelation">ncal:TriggerRelation</a>
    /// </summary>
    let TriggerRelation = _prefixId.prefix "TriggerRelation"

    /// <summary>
    ///   <para>rdfs:label : UnionOfAlarmEventFreebusyJournalTodo^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfAlarmEventFreebusyJournalTodo">ncal:UnionOfAlarmEventFreebusyJournalTodo</a>
    /// </summary>
    let UnionOfAlarmEventFreebusyJournalTodo =
        _prefixId.prefix "UnionOfAlarmEventFreebusyJournalTodo"

    /// <summary>
    ///   <para>rdfs:label : UnionOfAlarmEventFreebusyTodo^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfAlarmEventFreebusyTodo">ncal:UnionOfAlarmEventFreebusyTodo</a>
    /// </summary>
    let UnionOfAlarmEventFreebusyTodo = _prefixId.prefix "UnionOfAlarmEventFreebusyTodo"
    /// <summary>
    ///   <para>rdfs:label : UnionOfAlarmEventJournalTodo^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfAlarmEventJournalTodo">ncal:UnionOfAlarmEventJournalTodo</a>
    /// </summary>
    let UnionOfAlarmEventJournalTodo = _prefixId.prefix "UnionOfAlarmEventJournalTodo"
    /// <summary>
    ///   <para>rdfs:label : UnionOfAlarmEventTodo^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfAlarmEventTodo">ncal:UnionOfAlarmEventTodo</a>
    /// </summary>
    let UnionOfAlarmEventTodo = _prefixId.prefix "UnionOfAlarmEventTodo"
    /// <summary>
    ///   <para>rdfs:label : UnionOfEventFreebusy^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfEventFreebusy">ncal:UnionOfEventFreebusy</a>
    /// </summary>
    let UnionOfEventFreebusy = _prefixId.prefix "UnionOfEventFreebusy"

    /// <summary>
    ///   <para>rdfs:label : UnionOfEventFreebusyJournalTodo^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfEventFreebusyJournalTodo">ncal:UnionOfEventFreebusyJournalTodo</a>
    /// </summary>
    let UnionOfEventFreebusyJournalTodo =
        _prefixId.prefix "UnionOfEventFreebusyJournalTodo"

    /// <summary>
    ///   <para>rdfs:label : UnionOfEventJournalTimezoneTodo^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfEventJournalTimezoneTodo">ncal:UnionOfEventJournalTimezoneTodo</a>
    /// </summary>
    let UnionOfEventJournalTimezoneTodo =
        _prefixId.prefix "UnionOfEventJournalTimezoneTodo"

    /// <summary>
    ///   <para>rdfs:label : UnionOfEventJournalTodo^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfEventJournalTodo">ncal:UnionOfEventJournalTodo</a>
    /// </summary>
    let UnionOfEventJournalTodo = _prefixId.prefix "UnionOfEventJournalTodo"
    /// <summary>
    ///   <para>rdfs:label : UnionOfEventTodo^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfEventTodo">ncal:UnionOfEventTodo</a>
    /// </summary>
    let UnionOfEventTodo = _prefixId.prefix "UnionOfEventTodo"

    /// <summary>
    ///   <para>rdfs:label : UnionOfTimezoneObservanceEventFreebusyJournalTimezoneTodo^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfTimezoneObservanceEventFreebusyJournalTimezoneTodo">ncal:UnionOfTimezoneObservanceEventFreebusyJournalTimezoneTodo</a>
    /// </summary>
    let UnionOfTimezoneObservanceEventFreebusyJournalTimezoneTodo =
        _prefixId.prefix "UnionOfTimezoneObservanceEventFreebusyJournalTimezoneTodo"

    /// <summary>
    ///   <para>rdfs:label : UnionOfTimezoneObservanceEventFreebusyTimezoneTodo^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfTimezoneObservanceEventFreebusyTimezoneTodo">ncal:UnionOfTimezoneObservanceEventFreebusyTimezoneTodo</a>
    /// </summary>
    let UnionOfTimezoneObservanceEventFreebusyTimezoneTodo =
        _prefixId.prefix "UnionOfTimezoneObservanceEventFreebusyTimezoneTodo"

    /// <summary>
    ///   <para>rdfs:label : UnionOfTimezoneObservanceEventJournalTimezoneTodo^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfTimezoneObservanceEventJournalTimezoneTodo">ncal:UnionOfTimezoneObservanceEventJournalTimezoneTodo</a>
    /// </summary>
    let UnionOfTimezoneObservanceEventJournalTimezoneTodo =
        _prefixId.prefix "UnionOfTimezoneObservanceEventJournalTimezoneTodo"

    /// <summary>
    ///   <para>rdfs:label : UnionParentClass^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionParentClass">ncal:UnionParentClass</a>
    /// </summary>
    let UnionParentClass = _prefixId.prefix "UnionParentClass"
    /// <summary>
    ///   <para>rdfs:label : Weekday^^xsd:string</para>
    ///   <para>rdfs:comment : Day of the week. This class has been created to provide the limited vocabulary for ncal:byday property. See the documentation for ncal:byday for details.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Weekday">ncal:Weekday</a>
    /// </summary>
    let Weekday = _prefixId.prefix "Weekday"
    let _8bitEncoding = _prefixId.prefix "_8bitEncoding"
    let acceptedParticipationStatus = _prefixId.prefix "acceptedParticipationStatus"
    /// <summary>
    ///   <para>rdfs:label : action^^xsd:string</para>
    ///   <para>rdfs:comment : This property defines the action to be invoked when an alarm is triggered. Inspired by RFC 2445 sec 4.8.6.1. Originally this property had a limited set of values. They are expressed as instances of the AlarmAction class.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#action">ncal:action</a>
    /// </summary>
    let action = _prefixId.prefix "action"
    /// <summary>
    ///   <para>rdfs:label : attach^^xsd:string</para>
    ///   <para>rdfs:comment : The property provides the capability to associate a document object with a calendar component. Defined in the RFC 2445 sec. 4.8.1.1^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#attach">ncal:attach</a>
    /// </summary>
    let attach = _prefixId.prefix "attach"
    /// <summary>
    ///   <para>rdfs:label : attachmentContent^^xsd:string</para>
    ///   <para>rdfs:comment : The uri of the attachment. Created to express the actual value of the ATTACH property defined in RFC 2445 sec. 4.8.1.1. This property expresses the BINARY datatype of that property. see ncal:attachmentUri for the URI datatype.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#attachmentContent">ncal:attachmentContent</a>
    /// </summary>
    let attachmentContent = _prefixId.prefix "attachmentContent"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : attachmentUri^^xsd:string</para>
    ///   <para>rdfs:comment : The uri of the attachment. Created to express the actual value of the ATTACH property defined in RFC 2445 sec. 4.8.1.1. This property expresses the default URI datatype of that property. see ncal:attachmentContents for the BINARY datatype.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#attachmentUri">ncal:attachmentUri</a>
    /// </summary>
    let attachmentUri = _prefixId.prefix "attachmentUri"
    /// <summary>
    ///   <para>rdfs:label : attendee^^xsd:string</para>
    ///   <para>rdfs:comment : The property defines an "Attendee" within a calendar component. Inspired by RFC 2445 sec. 4.8.4.1. Originally this property accepted many parameters. The Attendee class has been introduced to express them all. Note that NCAL is aligned with NCO. The actual value (of the CAL-ADDRESS type) is expressed as an instance of nco:Contact. Remember that the CN parameter has been removed from NCAL. Instead that value should be expressed using nco:fullname property of the above mentioned nco:Contact instance. The RFC stated that whenever this property is attached to a Valarm instance, the Attendee cannot have any parameters apart from involvedContact.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#attendee">ncal:attendee</a>
    /// </summary>
    let attendee = _prefixId.prefix "attendee"
    let audioAction = _prefixId.prefix "audioAction"
    let base64Encoding = _prefixId.prefix "base64Encoding"
    let busyFreebusyType = _prefixId.prefix "busyFreebusyType"
    let busyTentativeFreebusyType = _prefixId.prefix "busyTentativeFreebusyType"
    let busyUnavailableFreebusyType = _prefixId.prefix "busyUnavailableFreebusyType"
    /// <summary>
    ///   <para>rdfs:label : byday^^xsd:string</para>
    ///   <para>rdfs:comment : Weekdays the recurrence should occur. Defined in RFC 2445 sec. 4.3.10^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#byday">ncal:byday</a>
    /// </summary>
    let byday = _prefixId.prefix "byday"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : bydayModifier^^xsd:string</para>
    ///   <para>rdfs:comment : An integer modifier for the BYDAY rule part.    Each BYDAY value can also be preceded by a positive (+n) or negative  (-n) integer. If present, this indicates the nth occurrence of the specific day within the MONTHLY or YEARLY RRULE. For example, within a MONTHLY rule, +1MO (or simply 1MO) represents the first Monday within the month, whereas -1MO represents the last Monday of the month. If an integer modifier is not present, it means all days of this type within the specified frequency. For example, within a MONTHLY rule, MO represents all Mondays within the month. Inspired by RFC 2445 sec. 4.3.10^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#bydayModifier">ncal:bydayModifier</a>
    /// </summary>
    let bydayModifier = _prefixId.prefix "bydayModifier"
    /// <summary>
    ///   <para>rdfs:label : bydayWeekday^^xsd:string</para>
    ///   <para>rdfs:comment : Connects a BydayRulePath with a weekday.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#bydayWeekday">ncal:bydayWeekday</a>
    /// </summary>
    let bydayWeekday = _prefixId.prefix "bydayWeekday"
    /// <summary>
    ///   <para>rdfs:label : byhour^^xsd:string</para>
    ///   <para>rdfs:comment : Hour of recurrence. Defined in RFC 2445 sec. 4.3.10^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#byhour">ncal:byhour</a>
    /// </summary>
    let byhour = _prefixId.prefix "byhour"
    /// <summary>
    ///   <para>rdfs:label : byminute^^xsd:string</para>
    ///   <para>rdfs:comment : Minute of recurrence. Defined in RFC 2445 sec. 4.3.10^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#byminute">ncal:byminute</a>
    /// </summary>
    let byminute = _prefixId.prefix "byminute"
    /// <summary>
    ///   <para>rdfs:label : bymonth^^xsd:string</para>
    ///   <para>rdfs:comment : Number of the month of the recurrence. Valid values are integers from 1 (January) to 12 (December). Defined in RFC 2445 sec. 4.3.10^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#bymonth">ncal:bymonth</a>
    /// </summary>
    let bymonth = _prefixId.prefix "bymonth"
    /// <summary>
    ///   <para>rdfs:label : bymonthday^^xsd:string</para>
    ///   <para>rdfs:comment : Day of the month when the event should recur. Defined in RFC 2445 sec. 4.3.10^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#bymonthday">ncal:bymonthday</a>
    /// </summary>
    let bymonthday = _prefixId.prefix "bymonthday"
    /// <summary>
    ///   <para>rdfs:label : bysecond^^xsd:string</para>
    ///   <para>rdfs:comment : Second of a recurrence. Defined in RFC 2445 sec. 4.3.10^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#bysecond">ncal:bysecond</a>
    /// </summary>
    let bysecond = _prefixId.prefix "bysecond"
    /// <summary>
    ///   <para>rdfs:label : bysetpos^^xsd:string</para>
    ///   <para>rdfs:comment : The BYSETPOS rule part specify values which correspond to the nth occurrence within the set of events specified by the rule. Valid values are 1 to 366 or -366 to -1. It MUST only be used in conjunction with another BYxxx rule part. For example "the last work day of the month" could be represented as: RRULE: FREQ=MONTHLY; BYDAY=MO, TU, WE, TH, FR; BYSETPOS=-1. Each BYSETPOS value can include a positive (+n) or negative (-n)  integer. If present, this indicates the nth occurrence of the  specific occurrence within the set of events specified by the rule. Defined in RFC 2445 sec. 4.3.10^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#bysetpos">ncal:bysetpos</a>
    /// </summary>
    let bysetpos = _prefixId.prefix "bysetpos"
    /// <summary>
    ///   <para>rdfs:label : byweekno^^xsd:string</para>
    ///   <para>rdfs:comment : The number of the week an event should recur. Defined in RFC 2445 sec. 4.3.10^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#byweekno">ncal:byweekno</a>
    /// </summary>
    let byweekno = _prefixId.prefix "byweekno"
    /// <summary>
    ///   <para>rdfs:label : byyearday^^xsd:string</para>
    ///   <para>rdfs:comment : Day of the year the event should occur. Defined in RFC 2445 sec. 4.3.10^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#byyearday">ncal:byyearday</a>
    /// </summary>
    let byyearday = _prefixId.prefix "byyearday"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : calscale^^xsd:string</para>
    ///   <para>rdfs:comment : This property defines the calendar scale used for the calendar information specified in the iCalendar object. Defined in RFC 2445 sec. 4.7.1^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#calscale">ncal:calscale</a>
    /// </summary>
    let calscale = _prefixId.prefix "calscale"
    let cancelledEventStatus = _prefixId.prefix "cancelledEventStatus"
    let cancelledJournalStatus = _prefixId.prefix "cancelledJournalStatus"
    let cancelledTodoStatus = _prefixId.prefix "cancelledTodoStatus"
    /// <summary>
    ///   <para>rdfs:label : categories^^xsd:string</para>
    ///   <para>rdfs:comment : Categories for a calendar component. Inspired by RFC 2445 sec 4.8.1.2 with the following reservations: The LANGUAGE parameter has been discarded. Please use xml:lang literals to express multiple languages. This property can specify multiple comma-separated categories. The order of categories doesn't matter. Please use a separate triple for each category.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#categories">ncal:categories</a>
    /// </summary>
    let categories = _prefixId.prefix "categories"
    let chairRole = _prefixId.prefix "chairRole"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : class^^xsd:string</para>
    ///   <para>rdfs:comment : Defines the access classification for a calendar component. Inspired by RFC 2445 sec. 4.8.1.3 with the following reservations:  this property has limited vocabulary. Possible values are:  PUBLIC, PRIVATE and CONFIDENTIAL. The default is PUBLIC. Those values are expressed as instances of the AccessClassification class. The user may create his/her own if necessary.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#class">ncal:class</a>
    /// </summary>
    let class_ = _prefixId.prefix "class"
    /// <summary>
    ///   <para>rdfs:label : comment^^xsd:string</para>
    ///   <para>rdfs:comment : Non-processing information intended to provide a comment to the calendar user. Inspired by RFC 2445 sec. 4.8.1.4 with the following reservations:  the LANGUAGE parameter has been discarded. Please use xml:lang literals to express language. For the ALTREP parameter use the commentAltRep property.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#comment">ncal:comment</a>
    /// </summary>
    let comment = _prefixId.prefix "comment"
    /// <summary>
    ///   <para>rdfs:label : commentAltRep^^xsd:string</para>
    ///   <para>rdfs:comment : Alternate representation of the comment. Introduced to cover
    /// the ALTREP parameter of the COMMENT property. See
    /// documentation of ncal:comment for details.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#commentAltRep">ncal:commentAltRep</a>
    /// </summary>
    let commentAltRep = _prefixId.prefix "commentAltRep"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : completed^^xsd:string</para>
    ///   <para>rdfs:comment : This property defines the date and time that a to-do was actually completed. Inspired by RFC 2445 sec. 4.8.2.1. Note that the RFC allows ONLY UTC time values for this property.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#completed">ncal:completed</a>
    /// </summary>
    let completed = _prefixId.prefix "completed"
    let completedParticipationStatus = _prefixId.prefix "completedParticipationStatus"
    let completedStatus = _prefixId.prefix "completedStatus"
    /// <summary>
    ///   <para>rdfs:label : component^^xsd:string</para>
    ///   <para>rdfs:comment : Links the Vcalendar instance with the calendar components. This property has no direct equivalent in the RFC specification. It has been introduced to express the containmnent relations.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#component">ncal:component</a>
    /// </summary>
    let component_ = _prefixId.prefix "component"
    let confidentialClassification = _prefixId.prefix "confidentialClassification"
    let confirmedStatus = _prefixId.prefix "confirmedStatus"
    /// <summary>
    ///   <para>rdfs:label : contact^^xsd:string</para>
    ///   <para>rdfs:comment : The property is used to represent contact information or alternately a reference to contact information associated with the calendar component. Inspired by RFC 2445 sec. 4.8.4.2 with the following reservations: the LANGUAGE parameter has been discarded. Please use xml:lang literals to express language. For the ALTREP parameter use the contactAltRep property.RFC doesn't define any format for the string.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#contact">ncal:contact</a>
    /// </summary>
    let contact = _prefixId.prefix "contact"
    /// <summary>
    ///   <para>rdfs:label : contactAltRep^^xsd:string</para>
    ///   <para>rdfs:comment : Alternate representation of the contact property. Introduced to cover
    /// the ALTREP parameter of the CONTACT property. See
    /// documentation of ncal:contact for details.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#contactAltRep">ncal:contactAltRep</a>
    /// </summary>
    let contactAltRep = _prefixId.prefix "contactAltRep"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : count^^xsd:string</para>
    ///   <para>rdfs:comment : How many times should an event be repeated. Defined in RFC 2445 sec. 4.3.10^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#count">ncal:count</a>
    /// </summary>
    let count = _prefixId.prefix "count"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : created^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies the date and time that the calendar information was created by the calendar user agent in the calendar store. Note: This is analogous to the creation date and time for a file in the file system. Inspired by RFC 2445 sec. 4.8.7.1. Note that this property is a subproperty of nie:created. The domain of nie:created is nie:DataObject. It is not a superclass of UnionOf_Vevent_Vjournal_Vtodo, but since that union is conceived as an 'abstract' class, and in real-life all resources referenced by this property will also be DataObjects, than this shouldn't cause too much of a problem. Note that RFC allows ONLY UTC time values for this property.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#created">ncal:created</a>
    /// </summary>
    let created = _prefixId.prefix "created"
    /// <summary>
    ///   <para>rdfs:label : cutype^^xsd:string</para>
    ///   <para>rdfs:comment : To specify the type of calendar user specified by the property. Inspired by RFC 2445 sec. 4.2.3. This parameter has a limited vocabulary. The terms that may serve as values for this property have been expressed as instances of CalendarUserType class. The user may use instances provided with this ontology or create his own.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#cutype">ncal:cutype</a>
    /// </summary>
    let cutype = _prefixId.prefix "cutype"
    let daily = _prefixId.prefix "daily"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : date^^xsd:string</para>
    ///   <para>rdfs:comment : Date an instance of NcalDateTime refers to. It was conceived to express values in DATE datatype specified in RFC 2445 4.3.4^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#date">ncal:date</a>
    /// </summary>
    let date = _prefixId.prefix "date"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : dateTime^^xsd:string</para>
    ///   <para>rdfs:comment : Representation of a date an instance of NcalDateTime actually refers to. It's purpose is to express values in DATE-TIME datatype, as defined in RFC 2445 sec. 4.3.5^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#dateTime">ncal:dateTime</a>
    /// </summary>
    let dateTime = _prefixId.prefix "dateTime"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : daylight^^xsd:string</para>
    ///   <para>rdfs:comment : Links a timezone with it's daylight observance. This property has no direct equivalent in the RFC 2445. It has been inspired by the structure of the Vtimezone component defined in sec.4.6.5^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#daylight">ncal:daylight</a>
    /// </summary>
    let daylight = _prefixId.prefix "daylight"
    let declinedParticipationStatus = _prefixId.prefix "declinedParticipationStatus"
    /// <summary>
    ///   <para>rdfs:label : delegatedFrom^^xsd:string</para>
    ///   <para>rdfs:comment : To specify the calendar users that have delegated their participation to the calendar user specified by the property. Inspired by RFC 2445 sec. 4.2.4. Originally the value type for this property was CAL-ADDRESS. This has been expressed as nco:Contact to promote integration between NCAL and NCO.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#delegatedFrom">ncal:delegatedFrom</a>
    /// </summary>
    let delegatedFrom = _prefixId.prefix "delegatedFrom"
    let delegatedParticipationStatus = _prefixId.prefix "delegatedParticipationStatus"
    /// <summary>
    ///   <para>rdfs:label : delegatedTo^^xsd:string</para>
    ///   <para>rdfs:comment : To specify the calendar users to whom the calendar user specified by the property has delegated participation. Inspired by RFC 2445 sec. 4.2.5. Originally the value type for this parameter was CAL-ADDRESS. This has been expressed as nco:Contact to promote integration between NCAL and NCO.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#delegatedTo">ncal:delegatedTo</a>
    /// </summary>
    let delegatedTo = _prefixId.prefix "delegatedTo"
    /// <summary>
    ///   <para>rdfs:label : description^^xsd:string</para>
    ///   <para>rdfs:comment : A more complete description of the calendar component, than  that provided by the ncal:summary property.Inspired by RFC 2445 sec. 4.8.1.5 with following reservations:  the LANGUAGE parameter has been discarded. Please use xml:lang literals to express language. For the ALTREP parameter use the descriptionAltRep property.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#description">ncal:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:label : descriptionAltRep^^xsd:string</para>
    ///   <para>rdfs:comment : Alternate representation of the calendar entity description. Introduced to cover
    /// the ALTREP parameter of the DESCRIPTION property. See
    /// documentation of ncal:description for details.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#descriptionAltRep">ncal:descriptionAltRep</a>
    /// </summary>
    let descriptionAltRep = _prefixId.prefix "descriptionAltRep"
    /// <summary>
    ///   <para>rdfs:label : dir^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies a reference to a directory entry associated with the calendar user specified by the property. Inspired by RFC 2445 sec. 4.2.6. Originally the data type of the value of this parameter was URI (Usually an LDAP URI). This has been expressed as rdfs:resource.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#dir">ncal:dir</a>
    /// </summary>
    let dir = _prefixId.prefix "dir"
    let displayAction = _prefixId.prefix "displayAction"
    let draftStatus = _prefixId.prefix "draftStatus"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : dtend^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies the date and time that a calendar component ends. Inspired by RFC 2445 sec. 4.8.2.2^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#dtend">ncal:dtend</a>
    /// </summary>
    let dtend = _prefixId.prefix "dtend"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : dtstamp^^xsd:string</para>
    ///   <para>rdfs:comment : The property indicates the date/time that the instance of the iCalendar object was created. Inspired by RFC 2445 sec. 4.8.7.1. Note that the RFC allows ONLY UTC values for this property.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#dtstamp">ncal:dtstamp</a>
    /// </summary>
    let dtstamp = _prefixId.prefix "dtstamp"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : dtstart^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies when the calendar component begins. Inspired by RFC 2445 sec. 4.8.2.4^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#dtstart">ncal:dtstart</a>
    /// </summary>
    let dtstart = _prefixId.prefix "dtstart"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : due^^xsd:string</para>
    ///   <para>rdfs:comment : This property defines the date and time that a to-do is expected to be completed. Inspired by RFC 2445 sec. 4.8.2.3^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#due">ncal:due</a>
    /// </summary>
    let due = _prefixId.prefix "due"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : duration^^xsd:string</para>
    ///   <para>rdfs:comment : The property specifies a positive duration of time. Inspired by RFC 2445 sec. 4.8.2.5^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#duration">ncal:duration</a>
    /// </summary>
    let duration = _prefixId.prefix "duration"
    let emailAction = _prefixId.prefix "emailAction"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : encoding^^xsd:string</para>
    ///   <para>rdfs:comment : To specify an alternate inline encoding for the property value. Inspired by RFC 2445 sec. 4.2.7. Originally this property had a limited vocabulary. ('8BIT' and 'BASE64'). The terms of this vocabulary have been expressed as instances of the AttachmentEncoding class^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#encoding">ncal:encoding</a>
    /// </summary>
    let encoding = _prefixId.prefix "encoding"
    let endTriggerRelation = _prefixId.prefix "endTriggerRelation"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : status^^xsd:string</para>
    ///   <para>rdfs:comment : Defines the overall status or confirmation for an Event. Based on the STATUS property defined in RFC 2445 sec. 4.8.1.11.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#eventStatus">ncal:eventStatus</a>
    /// </summary>
    let eventStatus = _prefixId.prefix "eventStatus"
    /// <summary>
    ///   <para>rdfs:label : exdate^^xsd:string</para>
    ///   <para>rdfs:comment : This property defines the list of date/time exceptions for a recurring calendar component. Inspired by RFC 2445 sec. 4.8.5.1^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#exdate">ncal:exdate</a>
    /// </summary>
    let exdate = _prefixId.prefix "exdate"
    /// <summary>
    ///   <para>rdfs:label : exrule^^xsd:string</para>
    ///   <para>rdfs:comment : This property defines a rule or repeating pattern for an exception to a recurrence set. Inspired by RFC 2445 sec. 4.8.5.2.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#exrule">ncal:exrule</a>
    /// </summary>
    let exrule = _prefixId.prefix "exrule"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : fbtype^^xsd:string</para>
    ///   <para>rdfs:comment : To specify the free or busy time type. Inspired by RFC 2445 sec. 4.2.9. The RFC specified a limited vocabulary for the values of this property. The terms of this vocabulary have been expressed as instances of the FreebusyType class. The user can use instances provided with this ontology or create his own.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#fbtype">ncal:fbtype</a>
    /// </summary>
    let fbtype = _prefixId.prefix "fbtype"
    let finalStatus = _prefixId.prefix "finalStatus"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : fmttype^^xsd:string</para>
    ///   <para>rdfs:comment : To specify the content type of a referenced object. Inspired by RFC 2445 sec. 4.2.8. The value of this property should be an IANA-registered content type (e.g. application/binary)^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#fmttype">ncal:fmttype</a>
    /// </summary>
    let fmttype = _prefixId.prefix "fmttype"
    let freeFreebusyType = _prefixId.prefix "freeFreebusyType"
    /// <summary>
    ///   <para>rdfs:label : freebusy^^xsd:string</para>
    ///   <para>rdfs:comment : The property defines one or more free or busy time intervals. Inspired by RFC 2445 sec. 4.8.2.6. Note that the periods specified by this property can only be expressed with UTC times. Originally this property could have many comma-separated values. Please use a separate triple for each value.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#freebusy">ncal:freebusy</a>
    /// </summary>
    let freebusy = _prefixId.prefix "freebusy"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : freq^^xsd:string</para>
    ///   <para>rdfs:comment : Frequency of a recurrence rule. Defined in RFC 2445 sec. 4.3.10^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#freq">ncal:freq</a>
    /// </summary>
    let freq = _prefixId.prefix "freq"
    let friday = _prefixId.prefix "friday"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : geo^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies information related to the global position for the activity specified by a calendar component. Inspired by RFC 2445 sec. 4.8.1.6^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#geo">ncal:geo</a>
    /// </summary>
    let geo = _prefixId.prefix "geo"
    let gregorianCalendarScale = _prefixId.prefix "gregorianCalendarScale"
    let groupUserType = _prefixId.prefix "groupUserType"
    /// <summary>
    ///   <para>rdfs:label : hasAlarm^^xsd:string</para>
    ///   <para>rdfs:comment : Links an event or a todo with a DataObject that can be interpreted as an alarm. This property has no direct equivalent in the RFC 2445. It has been provided to express this relation.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#hasAlarm">ncal:hasAlarm</a>
    /// </summary>
    let hasAlarm = _prefixId.prefix "hasAlarm"
    let hourly = _prefixId.prefix "hourly"
    let inProcessParticipationStatus = _prefixId.prefix "inProcessParticipationStatus"
    let inProcessStatus = _prefixId.prefix "inProcessStatus"
    let individualUserType = _prefixId.prefix "individualUserType"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : interval^^xsd:string</para>
    ///   <para>rdfs:comment : The INTERVAL rule part contains a positive integer representing how often the recurrence rule repeats. The default value is "1", meaning every second for a SECONDLY rule, or every minute for a MINUTELY rule, every hour for an HOURLY rule, every day for a DAILY rule, every week for a WEEKLY rule, every month for a MONTHLY rule andevery year for a YEARLY rule. Defined in RFC 2445 sec. 4.3.10^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#interval">ncal:interval</a>
    /// </summary>
    let interval = _prefixId.prefix "interval"
    /// <summary>
    ///   <para>rdfs:label : involvedContact^^xsd:string</para>
    ///   <para>rdfs:comment : A contact of the Attendee or the organizer involved in an event or other calendar entity. This property has been introduced to express the actual value of the ATTENDEE and ORGANIZER properties. The contact will also represent the CN parameter of those properties. See documentation of ncal:attendee or ncal:organizer for more details.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#involvedContact">ncal:involvedContact</a>
    /// </summary>
    let involvedContact = _prefixId.prefix "involvedContact"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : status^^xsd:string</para>
    ///   <para>rdfs:comment : Defines the overall status or confirmation for a journal entry. Based on the STATUS property defined in RFC 2445 sec. 4.8.1.11.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#journalStatus">ncal:journalStatus</a>
    /// </summary>
    let journalStatus = _prefixId.prefix "journalStatus"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : lastModified^^xsd:string</para>
    ///   <para>rdfs:comment : The property specifies the date and time that the information associated with the calendar component was last revised in the calendar store. Note: This is analogous to the modification date and time for a file in the file system. Inspired by RFC 2445 sec. 4.8.7.3. Note that the RFC allows ONLY UTC time values for this property.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#lastModified">ncal:lastModified</a>
    /// </summary>
    let lastModified = _prefixId.prefix "lastModified"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : location^^xsd:string</para>
    ///   <para>rdfs:comment : Defines the intended venue for the activity defined by a calendar component. Inspired by RFC 2445 sec 4.8.1.7 with the following reservations:  the LANGUAGE parameter has been discarded. Please use xml:lang literals to express language.  For the ALTREP parameter use the locationAltRep property.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#location">ncal:location</a>
    /// </summary>
    let location = _prefixId.prefix "location"
    /// <summary>
    ///   <para>rdfs:label : locationAltRep^^xsd:string</para>
    ///   <para>rdfs:comment : Alternate representation of the event or todo location.
    /// Introduced to cover the ALTREP parameter of the LOCATION
    /// property. See documentation of ncal:location for details.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#locationAltRep">ncal:locationAltRep</a>
    /// </summary>
    let locationAltRep = _prefixId.prefix "locationAltRep"
    /// <summary>
    ///   <para>rdfs:label : member^^xsd:string</para>
    ///   <para>rdfs:comment : To specify the group or list membership of the calendar user specified by the property. Inspired by RFC 2445 sec. 4.2.11. Originally this parameter had a value type of CAL-ADDRESS. This has been expressed as nco:Contact to promote integration between NCAL and NCO^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#member">ncal:member</a>
    /// </summary>
    let member_ = _prefixId.prefix "member"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : method^^xsd:string</para>
    ///   <para>rdfs:comment : This property defines the iCalendar object method associated with the calendar object. Defined in RFC 2445 sec. 4.7.2^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#method">ncal:method</a>
    /// </summary>
    let method = _prefixId.prefix "method"
    let minutely = _prefixId.prefix "minutely"
    let monday = _prefixId.prefix "monday"
    let monthly = _prefixId.prefix "monthly"
    /// <summary>
    ///   <para>rdfs:label : ncalRelation^^xsd:string</para>
    ///   <para>rdfs:comment : A common superproperty for all types of ncal relations. It is not to be used directly.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#ncalRelation">ncal:ncalRelation</a>
    /// </summary>
    let ncalRelation = _prefixId.prefix "ncalRelation"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : ncalTimezone^^xsd:string</para>
    ///   <para>rdfs:comment : The timezone instance that should be used to interpret an NcalDateTime. The purpose of this property is similar to the TZID parameter specified in RFC 2445 sec. 4.2.19^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#ncalTimezone">ncal:ncalTimezone</a>
    /// </summary>
    let ncalTimezone = _prefixId.prefix "ncalTimezone"

    let needsActionParticipationStatus =
        _prefixId.prefix "needsActionParticipationStatus"

    let needsActionStatus = _prefixId.prefix "needsActionStatus"
    let nonParticipantRole = _prefixId.prefix "nonParticipantRole"
    let opaqueTransparency = _prefixId.prefix "opaqueTransparency"
    let optParticipantRole = _prefixId.prefix "optParticipantRole"
    /// <summary>
    ///   <para>rdfs:label : organizer^^xsd:string</para>
    ///   <para>rdfs:comment : The property defines the organizer for a calendar component. Inspired by RFC 2445 sec. 4.8.4.3. Originally this property accepted many parameters. The Organizer class has been introduced to express them all. Note that NCAL is aligned with NCO. The actual value (of the CAL-ADDRESS type) is expressed as an instance of nco:Contact. Remember that the CN parameter has been removed from NCAL. Instead that value should be expressed using nco:fullname property of the above mentioned nco:Contact instance.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#organizer">ncal:organizer</a>
    /// </summary>
    let organizer = _prefixId.prefix "organizer"
    /// <summary>
    ///   <para>rdfs:label : partstat^^xsd:string</para>
    ///   <para>rdfs:comment : To specify the participation status for the calendar user specified by the property. Inspired by RFC 2445 sec. 4.2.12. Originally this parameter had three sets of allowed values. Which set applied to a particular case - depended on the type of calendar entity this parameter occured in. (event, todo, journal entry). This would be awkward to model in RDF so a single ParticipationStatus class has been introduced. Terms of the values vocabulary are expressed as instances of this class. Users are advised to pay attention which instances they use.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#partstat">ncal:partstat</a>
    /// </summary>
    let partstat = _prefixId.prefix "partstat"
    /// <summary>
    ///   <para>rdfs:label : percentComplete^^xsd:string</para>
    ///   <para>rdfs:comment : This property is used by an assignee or delegatee of a to-do to convey the percent completion of a to-do to the Organizer. Inspired by RFC 2445 sec. 4.8.1.8^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#percentComplete">ncal:percentComplete</a>
    /// </summary>
    let percentComplete = _prefixId.prefix "percentComplete"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : periodBegin^^xsd:string</para>
    ///   <para>rdfs:comment : Beginng of a period. Inspired by the first part of a structured value of the PERIOD datatype specified in RFC 2445 sec. 4.3.9^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#periodBegin">ncal:periodBegin</a>
    /// </summary>
    let periodBegin = _prefixId.prefix "periodBegin"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : periodDuration^^xsd:string</para>
    ///   <para>rdfs:comment : Duration of a period of time. Inspired by the second part of a structured value of the PERIOD datatype specified in RFC 2445 sec. 4.3.9. Note that a single NcalPeriod instance shouldn't have the periodEnd and periodDuration properties specified simultaneously.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#periodDuration">ncal:periodDuration</a>
    /// </summary>
    let periodDuration = _prefixId.prefix "periodDuration"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : periodEnd^^xsd:string</para>
    ///   <para>rdfs:comment : End of a period of time. Inspired by the second part of a structured value of a PERIOD datatype specified in RFC 2445 sec. 4.3.9. Note that a single NcalPeriod instance shouldn't have the periodEnd and periodDuration properties specified simultaneously.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#periodEnd">ncal:periodEnd</a>
    /// </summary>
    let periodEnd = _prefixId.prefix "periodEnd"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : priority^^xsd:string</para>
    ///   <para>rdfs:comment : The property defines the relative priority for a calendar component. Inspired by RFC 2445 sec. 4.8.1.9^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#priority">ncal:priority</a>
    /// </summary>
    let priority = _prefixId.prefix "priority"
    let privateClassification = _prefixId.prefix "privateClassification"
    let procedureAction = _prefixId.prefix "procedureAction"
    /// <summary>
    ///   <para>rdfs:label : prodid^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies the identifier for the product that created the iCalendar object. Defined in RFC 2445 sec. 4.7.2^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#prodid">ncal:prodid</a>
    /// </summary>
    let prodid = _prefixId.prefix "prodid"
    let publicClassification = _prefixId.prefix "publicClassification"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : range^^xsd:string</para>
    ///   <para>rdfs:comment : To specify the effective range of recurrence instances from the instance specified by the recurrence identifier specified by the property. It is intended to express the RANGE parameter specified in RFC 2445 sec. 4.2.13. The set of possible values for this property is limited. See also the documentation for ncal:recurrenceId for more details.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#range">ncal:range</a>
    /// </summary>
    let range = _prefixId.prefix "range"
    /// <summary>
    ///   <para>rdfs:label : rdate^^xsd:string</para>
    ///   <para>rdfs:comment : This property defines the list of date/times for a recurrence set. Inspired by RFC 2445 sec. 4.8.5.3. Note that RFC allows both DATE, DATE-TIME and PERIOD values for this property. That's why the range has been set to NcalTimeEntity.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#rdate">ncal:rdate</a>
    /// </summary>
    let rdate = _prefixId.prefix "rdate"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : recurrenceId^^xsd:string</para>
    ///   <para>rdfs:comment : This property is used in conjunction with the "UID" and "SEQUENCE" property to identify a specific instance of a recurring "VEVENT", "VTODO" or "VJOURNAL" calendar component. The property value is the effective value of the "DTSTART" property of the recurrence instance. Inspired by the RFC 2445 sec. 4.8.4.4^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#recurrenceId">ncal:recurrenceId</a>
    /// </summary>
    let recurrenceId = _prefixId.prefix "recurrenceId"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : recurrenceIdDateTime^^xsd:string</para>
    ///   <para>rdfs:comment : The date and time of a recurrence identifier. Provided to express the actual value of the ncal:recurrenceId property. See documentation for ncal:recurrenceId for details.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#recurrenceIdDateTime">ncal:recurrenceIdDateTime</a>
    /// </summary>
    let recurrenceIdDateTime = _prefixId.prefix "recurrenceIdDateTime"
    /// <summary>
    ///   <para>rdfs:label : related^^xsd:string</para>
    ///   <para>rdfs:comment : To specify the relationship of the alarm trigger with respect to the start or end of the calendar component. Inspired by RFC 2445 4.2.14. The RFC has specified two possible values for this property ('START' and 'END') they have been expressed as instances of the TriggerRelation class.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#related">ncal:related</a>
    /// </summary>
    let related = _prefixId.prefix "related"
    /// <summary>
    ///   <para>rdfs:label : relatedToChild^^xsd:string</para>
    ///   <para>rdfs:comment : The property is used to represent a relationship or reference between one calendar component and another. Inspired by RFC 2445 sec. 4.8.4.5. Originally this property had a RELTYPE parameter. It has been decided to introduce three different properties to express the values of that parameter. This property expresses the RELATED-TO property with RELTYPE=CHILD parameter.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#relatedToChild">ncal:relatedToChild</a>
    /// </summary>
    let relatedToChild = _prefixId.prefix "relatedToChild"
    /// <summary>
    ///   <para>rdfs:label : relatedToParent^^xsd:string</para>
    ///   <para>rdfs:comment : The property is used to represent a relationship or reference between one calendar component and another. Inspired by RFC 2445 sec. 4.8.4.5. Originally this property had a RELTYPE parameter. It has been decided that it is more natural to introduce three different properties to express the values of that parameter. This property expresses the RELATED-TO property with no RELTYPE parameter (the default value is PARENT), or with explicit RELTYPE=PARENT parameter.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#relatedToParent">ncal:relatedToParent</a>
    /// </summary>
    let relatedToParent = _prefixId.prefix "relatedToParent"
    /// <summary>
    ///   <para>rdfs:label : relatedToSibling^^xsd:string</para>
    ///   <para>rdfs:comment : The property is used to represent a relationship or reference between one calendar component and another. Inspired by RFC 2445 sec. 4.8.4.5. Originally this property had a RELTYPE parameter. It has been decided that it is more natural to introduce three different properties to express the values of that parameter. This property expresses the RELATED-TO property with RELTYPE=SIBLING parameter.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#relatedToSibling">ncal:relatedToSibling</a>
    /// </summary>
    let relatedToSibling = _prefixId.prefix "relatedToSibling"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : repeat^^xsd:string</para>
    ///   <para>rdfs:comment : This property defines the number of time the alarm should be repeated, after the initial trigger. Inspired by RFC 2445 sec. 4.8.6.2^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#repeat">ncal:repeat</a>
    /// </summary>
    let repeat = _prefixId.prefix "repeat"
    let reqParticipantRole = _prefixId.prefix "reqParticipantRole"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : requestStatus^^xsd:string</para>
    ///   <para>rdfs:comment : This property defines the status code returned for a scheduling request. Inspired by RFC 2445 sec. 4.8.8.2. Original value of this property was a four-element structure. The RequestStatus class has been introduced to express it. In RFC 2445 this property could have the LANGUAGE parameter. This has been discarded in this ontology. Use xml:lang literals to express it if necessary.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#requestStatus">ncal:requestStatus</a>
    /// </summary>
    let requestStatus = _prefixId.prefix "requestStatus"
    /// <summary>
    ///   <para>rdfs:label : requestStatusData^^xsd:string</para>
    ///   <para>rdfs:comment : Additional data associated with a request status. Inspired by the third part of the structured value for the REQUEST-STATUS property defined in RFC 2445 sec. 4.8.8.2 ("Textual exception data. For example, the offending property name and value or complete property line")^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#requestStatusData">ncal:requestStatusData</a>
    /// </summary>
    let requestStatusData = _prefixId.prefix "requestStatusData"
    let resourceUserType = _prefixId.prefix "resourceUserType"
    /// <summary>
    ///   <para>rdfs:label : resources^^xsd:string</para>
    ///   <para>rdfs:comment : Defines the equipment or resources anticipated for an activity specified by a calendar entity. Inspired by RFC 2445 sec. 4.8.1.10 with the following reservations:  the LANGUAGE parameter has been discarded. Please use xml:lang literals to express language. For the ALTREP parameter use the resourcesAltRep property. This property specifies multiple resources. The order is not important. it is recommended to introduce a separate triple for each resource.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#resources">ncal:resources</a>
    /// </summary>
    let resources = _prefixId.prefix "resources"
    /// <summary>
    ///   <para>rdfs:label : resourcesAltRep^^xsd:string</para>
    ///   <para>rdfs:comment : Alternate representation of the resources needed for an event or todo. Introduced to cover the ALTREP parameter of the resources property. See documentation for ncal:resources for details.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#resourcesAltRep">ncal:resourcesAltRep</a>
    /// </summary>
    let resourcesAltRep = _prefixId.prefix "resourcesAltRep"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : returnStatus^^xsd:string</para>
    ///   <para>rdfs:comment : Short return status. Inspired by the first element of the structured value of the REQUEST-STATUS property described in RFC 2445 sec. 4.8.8.2.
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
    /// 4.xx - Scheduling Error. This class of status code indicates that the request was not successful. Some sort of error occurred within the  calendaring and scheduling service, not directly related to the request itself.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#returnStatus">ncal:returnStatus</a>
    /// </summary>
    let returnStatus = _prefixId.prefix "returnStatus"
    /// <summary>
    ///   <para>rdfs:label : role^^xsd:string</para>
    ///   <para>rdfs:comment : To specify the participation role for the calendar user specified by the property. Inspired by the RFC 2445 sec. 4.2.16. Originally this property had a limited vocabulary for values. The terms of that vocabulary have been expressed as instances of the AttendeeRole class.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#role">ncal:role</a>
    /// </summary>
    let role = _prefixId.prefix "role"
    let roomUserType = _prefixId.prefix "roomUserType"
    /// <summary>
    ///   <para>rdfs:label : rrule^^xsd:string</para>
    ///   <para>rdfs:comment : This property defines a rule or repeating pattern for recurring events, to-dos, or time zone definitions. sec. 4.8.5.4^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#rrule">ncal:rrule</a>
    /// </summary>
    let rrule = _prefixId.prefix "rrule"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : rsvp^^xsd:string</para>
    ///   <para>rdfs:comment : To specify whether there is an expectation of a favor of a reply from the calendar user specified by the property value. Inspired by RFC 2445 sec. 4.2.17^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#rsvp">ncal:rsvp</a>
    /// </summary>
    let rsvp = _prefixId.prefix "rsvp"
    let saturday = _prefixId.prefix "saturday"
    let secondly = _prefixId.prefix "secondly"
    /// <summary>
    ///   <para>rdfs:label : sentBy^^xsd:string</para>
    ///   <para>rdfs:comment : To specify the calendar user that is acting on behalf of the calendar user specified by the property. Inspired by RFC 2445 sec. 4.2.18. The original data type of this property was a mailto: URI. This has been changed to nco:Contact to promote integration between NCO and NCAL.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#sentBy">ncal:sentBy</a>
    /// </summary>
    let sentBy = _prefixId.prefix "sentBy"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : sequence^^xsd:string</para>
    ///   <para>rdfs:comment : This property defines the revision sequence number of the calendar component within a sequence of revisions. Inspired by RFC 2445 sec. 4.8.7.4^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#sequence">ncal:sequence</a>
    /// </summary>
    let sequence = _prefixId.prefix "sequence"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : standard^^xsd:string</para>
    ///   <para>rdfs:comment : Links the timezone with the standard timezone observance. This property has no direct equivalent in the RFC 2445. It has been inspired by the structure of the Vtimezone component defined in sec.4.6.5^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#standard">ncal:standard</a>
    /// </summary>
    let standard = _prefixId.prefix "standard"
    let startTriggerRelation = _prefixId.prefix "startTriggerRelation"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : statusDescription^^xsd:string</para>
    ///   <para>rdfs:comment : Longer return status description. Inspired by the second part of the structured value of the REQUEST-STATUS property defined in RFC 2445 sec. 4.8.8.2^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#statusDescription">ncal:statusDescription</a>
    /// </summary>
    let statusDescription = _prefixId.prefix "statusDescription"
    /// <summary>
    ///   <para>rdfs:label : summary^^xsd:string</para>
    ///   <para>rdfs:comment : Defines a short summary or subject for the calendar component. Inspired by RFC 2445 sec 4.8.1.12 with the following reservations: the LANGUAGE parameter has been discarded. Please use xml:lang literals to express language. For the ALTREP parameter use the summaryAltRep property.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#summary">ncal:summary</a>
    /// </summary>
    let summary = _prefixId.prefix "summary"
    /// <summary>
    ///   <para>rdfs:label : summaryAltRep^^xsd:string</para>
    ///   <para>rdfs:comment : Alternate representation of the comment. Introduced to cover
    /// the ALTREP parameter of the SUMMARY property. See
    /// documentation of ncal:summary for details.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#summaryAltRep">ncal:summaryAltRep</a>
    /// </summary>
    let summaryAltRep = _prefixId.prefix "summaryAltRep"
    let sunday = _prefixId.prefix "sunday"
    let tentativeParticipationStatus = _prefixId.prefix "tentativeParticipationStatus"
    let tentativeStatus = _prefixId.prefix "tentativeStatus"
    let thisAndFutureRange = _prefixId.prefix "thisAndFutureRange"
    let thisAndPriorRange = _prefixId.prefix "thisAndPriorRange"
    let thursday = _prefixId.prefix "thursday"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : status^^xsd:string</para>
    ///   <para>rdfs:comment : Defines the overall status or confirmation for a todo. Based on the STATUS property defined in RFC 2445 sec. 4.8.1.11.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#todoStatus">ncal:todoStatus</a>
    /// </summary>
    let todoStatus = _prefixId.prefix "todoStatus"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : transp^^xsd:string</para>
    ///   <para>rdfs:comment : Defines whether an event is transparent or not  to busy time searches. Inspired by RFC 2445 sec.4.8.2.7. Values for this property can be chosen from a limited vocabulary. To express this a TimeTransparency class has been introduced.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#transp">ncal:transp</a>
    /// </summary>
    let transp = _prefixId.prefix "transp"
    let transparentTransparency = _prefixId.prefix "transparentTransparency"
    /// <summary>
    ///   <para>rdfs:label : trigger^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies when an alarm will trigger. Inspired by RFC 2445 sec. 4.8.6.3 Originally the value of this property could accept two types : duration and date-time. To express this fact a Trigger class has been introduced. It also has a related property to account for the RELATED parameter.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#trigger">ncal:trigger</a>
    /// </summary>
    let trigger = _prefixId.prefix "trigger"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : triggerDateTime^^xsd:string</para>
    ///   <para>rdfs:comment : The exact date and time of the trigger. This property has been created to express the VALUE=DATE, and VALUE=DATE-TIME parameters of the TRIGGER property. See the documentation for ncal:trigger for more details^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#triggerDateTime">ncal:triggerDateTime</a>
    /// </summary>
    let triggerDateTime = _prefixId.prefix "triggerDateTime"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : triggerDuration^^xsd:string</para>
    ///   <para>rdfs:comment : The duration of a trigger. This property has been created to express the VALUE=DURATION parameter of the TRIGGER property. See documentation for ncal:trigger for more details.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#triggerDuration">ncal:triggerDuration</a>
    /// </summary>
    let triggerDuration = _prefixId.prefix "triggerDuration"
    let tuesday = _prefixId.prefix "tuesday"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : tzid^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies the text value that uniquely identifies the "VTIMEZONE" calendar component. Inspired by RFC 2445 sec 4.8.3.1^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#tzid">ncal:tzid</a>
    /// </summary>
    let tzid = _prefixId.prefix "tzid"
    /// <summary>
    ///   <para>rdfs:label : tzname^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies the customary designation for a timezone description. Inspired by RFC 2445 sec. 4.8.3.2 The LANGUAGE parameter has been discarded. Please xml:lang literals to express languages. Original specification for the domain of this property stated that it must appear within the timezone component. In this ontology the TimezoneObservance class has been itroduced to clarify this specification.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#tzname">ncal:tzname</a>
    /// </summary>
    let tzname = _prefixId.prefix "tzname"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : tzoffsetfrom^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies the offset which is in use prior to this time zone observance. Inspired by RFC 2445 sec. 4.8.3.3. The original domain was underspecified. It said that this property must appear within a Timezone component. In this ontology a TimezoneObservance class has been introduced to clarify this specification. The original range was UTC-OFFSET. There is no equivalent among the XSD datatypes so plain string was chosen.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#tzoffsetfrom">ncal:tzoffsetfrom</a>
    /// </summary>
    let tzoffsetfrom = _prefixId.prefix "tzoffsetfrom"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : tzoffsetto^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies the offset which is in use in this time zone observance. nspired by RFC 2445 sec. 4.8.3.4. The original domain was underspecified. It said that this property must appear within a Timezone component. In this ontology a TimezoneObservance class has been introduced to clarify this specification. The original range was UTC-OFFSET. There is no equivalent among the XSD datatypes so plain string was chosen.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#tzoffsetto">ncal:tzoffsetto</a>
    /// </summary>
    let tzoffsetto = _prefixId.prefix "tzoffsetto"
    /// <summary>
    ///   <para>rdfs:label : tzurl^^xsd:string</para>
    ///   <para>rdfs:comment : The TZURL provides a means for a VTIMEZONE component to point to a network location that can be used to retrieve an up-to- date version of itself. Inspired by RFC 2445 sec. 4.8.3.5. Originally the range of this property had been specified as URI.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#tzurl">ncal:tzurl</a>
    /// </summary>
    let tzurl = _prefixId.prefix "tzurl"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : uid^^xsd:string</para>
    ///   <para>rdfs:comment : This property defines the persistent, globally unique identifier for the calendar component. Inspired by the RFC 2445 sec 4.8.4.7^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#uid">ncal:uid</a>
    /// </summary>
    let uid = _prefixId.prefix "uid"
    let unknownUserType = _prefixId.prefix "unknownUserType"
    /// <summary>
    ///   <para>rdfs:label : until^^xsd:string</para>
    ///   <para>rdfs:comment : The UNTIL rule part defines a date-time value which bounds the recurrence rule in an inclusive manner. If the value specified by UNTIL is synchronized with the specified recurrence, this date or date-time becomes the last instance of the recurrence. If specified as a date-time value, then it MUST be specified in an UTC time format. If not present, and the COUNT rule part is also not present, the RRULE is considered to repeat forever.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#until">ncal:until</a>
    /// </summary>
    let until = _prefixId.prefix "until"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : url^^xsd:string</para>
    ///   <para>rdfs:comment : This property defines a Uniform Resource Locator (URL) associated with the iCalendar object. Inspired by the RFC 2445 sec. 4.8.4.6. Original range had been specified as URI.^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#url">ncal:url</a>
    /// </summary>
    let url = _prefixId.prefix "url"
    /// <summary>
    ///   <para>rdfs:label : version^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies the identifier corresponding to the highest version number or the minimum and maximum range of the iCalendar specification that is required in order to interpret the iCalendar object. Defined in RFC 2445 sec. 4.7.4^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#version">ncal:version</a>
    /// </summary>
    let version = _prefixId.prefix "version"
    let wednesday = _prefixId.prefix "wednesday"
    let weekly = _prefixId.prefix "weekly"
    /// <summary>
    ///   <para>nrl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>rdfs:label : wkst^^xsd:string</para>
    ///   <para>rdfs:comment : The day that's counted as the start of the week. It is used to disambiguate the byweekno rule. Defined in RFC 2445 sec. 4.3.10^^xsd:string</para>
    ///   <a href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#wkst">ncal:wkst</a>
    /// </summary>
    let wkst = _prefixId.prefix "wkst"
    let yearly = _prefixId.prefix "yearly"
