namespace http.www.semanticdesktop.org.ontologies._2007._04._02.ncal.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ncal =
    let _namespace_iri = Namespace_Iri ncal |> NamespaceIRI
    /// <summary>
    ///   <para>ncal:Alarm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Provide a grouping of component properties that define an alarm.</para>
    /// labels<para>Alarm</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Alarm">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Alarm</seealso>
    let Alarm = Prefixed_Name(ncal, "Alarm") |> PrefixedName
    /// <summary>
    ///   <para>ncal:Attachment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An object attached to a calendar entity. This class has been introduced to serve as a structured value of the ncal:attach property. See the documentation of ncal:attach for details.</para>
    /// labels<para>Attachment</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Attachment">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Attachment</seealso>
    let Attachment = Prefixed_Name(ncal, "Attachment") |> PrefixedName
    /// <summary>
    ///   <para>ncal:Attendee</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An attendee of an event. This class has been introduced to serve as the range for ncal:attendee property. See documentation of ncal:attendee for details.</para>
    /// labels<para>Attendee</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Attendee">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Attendee</seealso>
    let Attendee = Prefixed_Name(ncal, "Attendee") |> PrefixedName
    /// <summary>
    ///   <para>ncal:RecurrenceRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>RecurrenceRule</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#RecurrenceRule">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#RecurrenceRule</seealso>
    let RecurrenceRule = Prefixed_Name(ncal, "RecurrenceRule") |> PrefixedName
    /// <summary>
    ///   <para>ncal:tuesday</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:Weekday</para>
    ///
    /// labels<para>tuesday</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#tuesday">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#tuesday</seealso>
    let tuesday = Prefixed_Name(ncal, "tuesday") |> PrefixedName
    /// <summary>
    ///   <para>ncal:tzoffsetto</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property specifies the offset which is in use in this time zone observance. nspired by RFC 2445 sec. 4.8.3.4. The original domain was underspecified. It said that this property must appear within a Timezone component. In this ontology a TimezoneObservance class has been introduced to clarify this specification. The original range was UTC-OFFSET. There is no equivalent among the XSD datatypes so plain string was chosen.</para>
    /// labels<para>tzoffsetto</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#tzoffsetto">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#tzoffsetto</seealso>
    let tzoffsetto = Prefixed_Name(ncal, "tzoffsetto") |> PrefixedName
    /// <summary>
    ///   <para>ncal:tzurl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The TZURL provides a means for a VTIMEZONE component to point to a network location that can be used to retrieve an up-to- date version of itself. Inspired by RFC 2445 sec. 4.8.3.5. Originally the range of this property had been specified as URI.</para>
    /// labels<para>tzurl</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#tzurl">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#tzurl</seealso>
    let tzurl = Prefixed_Name(ncal, "tzurl") |> PrefixedName

    /// <summary>
    ///   <para>ncal:UnionOfAlarmEventFreebusyTodo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>UnionOfAlarmEventFreebusyTodo</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfAlarmEventFreebusyTodo">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfAlarmEventFreebusyTodo</seealso>
    let UnionOfAlarmEventFreebusyTodo =
        Prefixed_Name(ncal, "UnionOfAlarmEventFreebusyTodo") |> PrefixedName

    /// <summary>
    ///   <para>ncal:AttachmentEncoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Attachment encoding. This class has been introduced to express the limited vocabulary of values for the ncal:encoding property. See the documentation of ncal:encoding for details.</para>
    /// labels<para>AttachmentEncoding</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#AttachmentEncoding">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#AttachmentEncoding</seealso>
    let AttachmentEncoding = Prefixed_Name(ncal, "AttachmentEncoding") |> PrefixedName
    /// <summary>
    ///   <para>ncal:prodid</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property specifies the identifier for the product that created the iCalendar object. Defined in RFC 2445 sec. 4.7.2</para>
    /// labels<para>prodid</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#prodid">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#prodid</seealso>
    let prodid = Prefixed_Name(ncal, "prodid") |> PrefixedName
    /// <summary>
    ///   <para>ncal:rdate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property defines the list of date/times for a recurrence set. Inspired by RFC 2445 sec. 4.8.5.3. Note that RFC allows both DATE, DATE-TIME and PERIOD values for this property. That's why the range has been set to NcalTimeEntity.</para>
    /// labels<para>rdate</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#rdate">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#rdate</seealso>
    let rdate = Prefixed_Name(ncal, "rdate") |> PrefixedName

    /// <summary>
    ///   <para>ncal:recurrenceIdDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The date and time of a recurrence identifier. Provided to express the actual value of the ncal:recurrenceId property. See documentation for ncal:recurrenceId for details.</para>
    /// labels<para>recurrenceIdDateTime</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#recurrenceIdDateTime">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#recurrenceIdDateTime</seealso>
    let recurrenceIdDateTime =
        Prefixed_Name(ncal, "recurrenceIdDateTime") |> PrefixedName

    /// <summary>
    ///   <para>ncal:relatedToChild</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property is used to represent a relationship or reference between one calendar component and another. Inspired by RFC 2445 sec. 4.8.4.5. Originally this property had a RELTYPE parameter. It has been decided to introduce three different properties to express the values of that parameter. This property expresses the RELATED-TO property with RELTYPE=CHILD parameter.</para>
    /// labels<para>relatedToChild</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#relatedToChild">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#relatedToChild</seealso>
    let relatedToChild = Prefixed_Name(ncal, "relatedToChild") |> PrefixedName
    /// <summary>
    ///   <para>ncal:relatedToSibling</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property is used to represent a relationship or reference between one calendar component and another. Inspired by RFC 2445 sec. 4.8.4.5. Originally this property had a RELTYPE parameter. It has been decided that it is more natural to introduce three different properties to express the values of that parameter. This property expresses the RELATED-TO property with RELTYPE=SIBLING parameter.</para>
    /// labels<para>relatedToSibling</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#relatedToSibling">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#relatedToSibling</seealso>
    let relatedToSibling = Prefixed_Name(ncal, "relatedToSibling") |> PrefixedName
    /// <summary>
    ///   <para>ncal:reqParticipantRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:AttendeeRole</para>
    ///
    /// labels<para>reqParticipantRole</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#reqParticipantRole">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#reqParticipantRole</seealso>
    let reqParticipantRole = Prefixed_Name(ncal, "reqParticipantRole") |> PrefixedName
    /// <summary>
    ///   <para>ncal:requestStatusData</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Additional data associated with a request status. Inspired by the third part of the structured value for the REQUEST-STATUS property defined in RFC 2445 sec. 4.8.8.2 ("Textual exception data. For example, the offending property name and value or complete property line")</para>
    /// labels<para>requestStatusData</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#requestStatusData">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#requestStatusData</seealso>
    let requestStatusData = Prefixed_Name(ncal, "requestStatusData") |> PrefixedName
    /// <summary>
    ///   <para>ncal:resourcesAltRep</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Alternate representation of the resources needed for an event or todo. Introduced to cover the ALTREP parameter of the resources property. See documentation for ncal:resources for details.</para>
    /// labels<para>resourcesAltRep</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#resourcesAltRep">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#resourcesAltRep</seealso>
    let resourcesAltRep = Prefixed_Name(ncal, "resourcesAltRep") |> PrefixedName
    /// <summary>
    ///   <para>ncal:roomUserType</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:CalendarUserType</para>
    ///
    /// labels<para>roomUserType</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#roomUserType">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#roomUserType</seealso>
    let roomUserType = Prefixed_Name(ncal, "roomUserType") |> PrefixedName
    /// <summary>
    ///   <para>ncal:saturday</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:Weekday</para>
    ///
    /// labels<para>saturday</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#saturday">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#saturday</seealso>
    let saturday = Prefixed_Name(ncal, "saturday") |> PrefixedName
    /// <summary>
    ///   <para>ncal:standard</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Links the timezone with the standard timezone observance. This property has no direct equivalent in the RFC 2445. It has been inspired by the structure of the Vtimezone component defined in sec.4.6.5</para>
    /// labels<para>standard</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#standard">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#standard</seealso>
    let standard = Prefixed_Name(ncal, "standard") |> PrefixedName
    /// <summary>
    ///   <para>ncal:summary</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Defines a short summary or subject for the calendar component. Inspired by RFC 2445 sec 4.8.1.12 with the following reservations: the LANGUAGE parameter has been discarded. Please use xml:lang literals to express language. For the ALTREP parameter use the summaryAltRep property.</para>
    /// labels<para>summary</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#summary">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#summary</seealso>
    let summary = Prefixed_Name(ncal, "summary") |> PrefixedName
    /// <summary>
    ///   <para>ncal:sunday</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:Weekday</para>
    ///
    /// labels<para>sunday</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#sunday">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#sunday</seealso>
    let sunday = Prefixed_Name(ncal, "sunday") |> PrefixedName

    /// <summary>
    ///   <para>ncal:tentativeParticipationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:ParticipationStatus</para>
    ///
    /// labels<para>tentativeParticipationStatus</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#tentativeParticipationStatus">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#tentativeParticipationStatus</seealso>
    let tentativeParticipationStatus =
        Prefixed_Name(ncal, "tentativeParticipationStatus") |> PrefixedName

    /// <summary>
    ///   <para>ncal:thursday</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:Weekday</para>
    ///
    /// labels<para>thursday</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#thursday">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#thursday</seealso>
    let thursday = Prefixed_Name(ncal, "thursday") |> PrefixedName
    /// <summary>
    ///   <para>ncal:todoStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Defines the overall status or confirmation for a todo. Based on the STATUS property defined in RFC 2445 sec. 4.8.1.11.</para>
    /// labels<para>status</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#todoStatus">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#todoStatus</seealso>
    let todoStatus = Prefixed_Name(ncal, "todoStatus") |> PrefixedName
    /// <summary>
    ///   <para>ncal:transp</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Defines whether an event is transparent or not  to busy time searches. Inspired by RFC 2445 sec.4.8.2.7. Values for this property can be chosen from a limited vocabulary. To express this a TimeTransparency class has been introduced.</para>
    /// labels<para>transp</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#transp">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#transp</seealso>
    let transp = Prefixed_Name(ncal, "transp") |> PrefixedName
    /// <summary>
    ///   <para>ncal:trigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property specifies when an alarm will trigger. Inspired by RFC 2445 sec. 4.8.6.3 Originally the value of this property could accept two types : duration and date-time. To express this fact a Trigger class has been introduced. It also has a related property to account for the RELATED parameter.</para>
    /// labels<para>trigger</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#trigger">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#trigger</seealso>
    let trigger = Prefixed_Name(ncal, "trigger") |> PrefixedName
    /// <summary>
    ///   <para>ncal:triggerDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The exact date and time of the trigger. This property has been created to express the VALUE=DATE, and VALUE=DATE-TIME parameters of the TRIGGER property. See the documentation for ncal:trigger for more details</para>
    /// labels<para>triggerDateTime</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#triggerDateTime">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#triggerDateTime</seealso>
    let triggerDateTime = Prefixed_Name(ncal, "triggerDateTime") |> PrefixedName
    /// <summary>
    ///   <para>ncal:triggerDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The duration of a trigger. This property has been created to express the VALUE=DURATION parameter of the TRIGGER property. See documentation for ncal:trigger for more details.</para>
    /// labels<para>triggerDuration</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#triggerDuration">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#triggerDuration</seealso>
    let triggerDuration = Prefixed_Name(ncal, "triggerDuration") |> PrefixedName
    /// <summary>
    ///   <para>ncal:tzid</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property specifies the text value that uniquely identifies the "VTIMEZONE" calendar component. Inspired by RFC 2445 sec 4.8.3.1</para>
    /// labels<para>tzid</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#tzid">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#tzid</seealso>
    let tzid = Prefixed_Name(ncal, "tzid") |> PrefixedName
    /// <summary>
    ///   <para>ncal:tzname</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies the customary designation for a timezone description. Inspired by RFC 2445 sec. 4.8.3.2 The LANGUAGE parameter has been discarded. Please xml:lang literals to express languages. Original specification for the domain of this property stated that it must appear within the timezone component. In this ontology the TimezoneObservance class has been itroduced to clarify this specification.</para>
    /// labels<para>tzname</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#tzname">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#tzname</seealso>
    let tzname = Prefixed_Name(ncal, "tzname") |> PrefixedName
    /// <summary>
    ///   <para>ncal:tzoffsetfrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property specifies the offset which is in use prior to this time zone observance. Inspired by RFC 2445 sec. 4.8.3.3. The original domain was underspecified. It said that this property must appear within a Timezone component. In this ontology a TimezoneObservance class has been introduced to clarify this specification. The original range was UTC-OFFSET. There is no equivalent among the XSD datatypes so plain string was chosen.</para>
    /// labels<para>tzoffsetfrom</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#tzoffsetfrom">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#tzoffsetfrom</seealso>
    let tzoffsetfrom = Prefixed_Name(ncal, "tzoffsetfrom") |> PrefixedName
    /// <summary>
    ///   <para>ncal:uid</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property defines the persistent, globally unique identifier for the calendar component. Inspired by the RFC 2445 sec 4.8.4.7</para>
    /// labels<para>uid</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#uid">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#uid</seealso>
    let uid = Prefixed_Name(ncal, "uid") |> PrefixedName
    /// <summary>
    ///   <para>ncal:unknownUserType</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:CalendarUserType</para>
    ///
    /// labels<para>unknownUserType</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#unknownUserType">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#unknownUserType</seealso>
    let unknownUserType = Prefixed_Name(ncal, "unknownUserType") |> PrefixedName
    /// <summary>
    ///   <para>ncal:until</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The UNTIL rule part defines a date-time value which bounds the recurrence rule in an inclusive manner. If the value specified by UNTIL is synchronized with the specified recurrence, this date or date-time becomes the last instance of the recurrence. If specified as a date-time value, then it MUST be specified in an UTC time format. If not present, and the COUNT rule part is also not present, the RRULE is considered to repeat forever.</para>
    /// labels<para>until</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#until">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#until</seealso>
    let until = Prefixed_Name(ncal, "until") |> PrefixedName
    /// <summary>
    ///   <para>ncal:version</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property specifies the identifier corresponding to the highest version number or the minimum and maximum range of the iCalendar specification that is required in order to interpret the iCalendar object. Defined in RFC 2445 sec. 4.7.4</para>
    /// labels<para>version</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#version">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#version</seealso>
    let version = Prefixed_Name(ncal, "version") |> PrefixedName
    /// <summary>
    ///   <para>ncal:wednesday</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:Weekday</para>
    ///
    /// labels<para>wednesday</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#wednesday">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#wednesday</seealso>
    let wednesday = Prefixed_Name(ncal, "wednesday") |> PrefixedName
    /// <summary>
    ///   <para>ncal:weekly</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:RecurrenceFrequency</para>
    ///
    /// labels<para>weekly</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#weekly">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#weekly</seealso>
    let weekly = Prefixed_Name(ncal, "weekly") |> PrefixedName

    /// <summary>
    ///   <para>ncal:UnionOfAlarmEventJournalTodo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>UnionOfAlarmEventJournalTodo</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfAlarmEventJournalTodo">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfAlarmEventJournalTodo</seealso>
    let UnionOfAlarmEventJournalTodo =
        Prefixed_Name(ncal, "UnionOfAlarmEventJournalTodo") |> PrefixedName

    /// <summary>
    ///   <para>ncal:CalendarScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A calendar scale. This class has been introduced to provide the limited vocabulary for the ncal:calscale property.</para>
    /// labels<para>CalendarScale</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#CalendarScale">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#CalendarScale</seealso>
    let CalendarScale = Prefixed_Name(ncal, "CalendarScale") |> PrefixedName

    /// <summary>
    ///   <para>ncal:UnionOfAlarmEventFreebusyJournalTodo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>UnionOfAlarmEventFreebusyJournalTodo</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfAlarmEventFreebusyJournalTodo">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfAlarmEventFreebusyJournalTodo</seealso>
    let UnionOfAlarmEventFreebusyJournalTodo =
        Prefixed_Name(ncal, "UnionOfAlarmEventFreebusyJournalTodo") |> PrefixedName

    /// <summary>
    ///   <para>ncal:AttendeeRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A role the attendee is going to play during an event. This class has been introduced to express the limited vocabulary for the values of ncal:role property. Please refer to the documentation of ncal:role for details.</para>
    /// labels<para>AttendeeRole</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#AttendeeRole">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#AttendeeRole</seealso>
    let AttendeeRole = Prefixed_Name(ncal, "AttendeeRole") |> PrefixedName
    /// <summary>
    ///   <para>ncal:Journal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Provide a grouping of component properties that describe a journal entry.</para>
    /// labels<para>Journal</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Journal">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Journal</seealso>
    let Journal = Prefixed_Name(ncal, "Journal") |> PrefixedName
    /// <summary>
    ///   <para>ncal:NcalDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>NcalDateTime</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#NcalDateTime">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#NcalDateTime</seealso>
    let NcalDateTime = Prefixed_Name(ncal, "NcalDateTime") |> PrefixedName
    /// <summary>
    ///   <para>ncal:Organizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An organizer of an event. This class has been introduced to serve as a range of ncal:organizer property. See documentation of ncal:organizer for details.</para>
    /// labels<para>Organizer</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Organizer">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Organizer</seealso>
    let Organizer = Prefixed_Name(ncal, "Organizer") |> PrefixedName
    /// <summary>
    ///   <para>ncal:BydayRulePart</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Expresses the compound value of a byday part of a recurrence rule. It stores the weekday and the integer modifier. Inspired by RFC 2445 sec. 4.3.10</para>
    /// labels<para>BydayRulePart</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#BydayRulePart">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#BydayRulePart</seealso>
    let BydayRulePart = Prefixed_Name(ncal, "BydayRulePart") |> PrefixedName

    /// <summary>
    ///   <para>ncal:UnionOfTimezoneObservanceEventJournalTimezoneTodo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>UnionOfTimezoneObservanceEventJournalTimezoneTodo</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfTimezoneObservanceEventJournalTimezoneTodo">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfTimezoneObservanceEventJournalTimezoneTodo</seealso>
    let UnionOfTimezoneObservanceEventJournalTimezoneTodo =
        Prefixed_Name(ncal, "UnionOfTimezoneObservanceEventJournalTimezoneTodo") |> PrefixedName

    /// <summary>
    ///   <para>ncal:delegatedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>To specify the calendar users that have delegated their participation to the calendar user specified by the property. Inspired by RFC 2445 sec. 4.2.4. Originally the value type for this property was CAL-ADDRESS. This has been expressed as nco:Contact to promote integration between NCAL and NCO.</para>
    /// labels<para>delegatedFrom</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#delegatedFrom">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#delegatedFrom</seealso>
    let delegatedFrom = Prefixed_Name(ncal, "delegatedFrom") |> PrefixedName
    /// <summary>
    ///   <para>ncal:descriptionAltRep</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Alternate representation of the calendar entity description. Introduced to cover
    /// the ALTREP parameter of the DESCRIPTION property. See
    /// documentation of ncal:description for details.</para>
    /// labels<para>descriptionAltRep</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#descriptionAltRep">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#descriptionAltRep</seealso>
    let descriptionAltRep = Prefixed_Name(ncal, "descriptionAltRep") |> PrefixedName
    /// <summary>
    ///   <para>ncal:displayAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:AlarmAction</para>
    ///
    /// labels<para>displayAction</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#displayAction">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#displayAction</seealso>
    let displayAction = Prefixed_Name(ncal, "displayAction") |> PrefixedName
    /// <summary>
    ///   <para>ncal:dtstart</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property specifies when the calendar component begins. Inspired by RFC 2445 sec. 4.8.2.4</para>
    /// labels<para>dtstart</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#dtstart">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#dtstart</seealso>
    let dtstart = Prefixed_Name(ncal, "dtstart") |> PrefixedName
    /// <summary>
    ///   <para>ncal:duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property specifies a positive duration of time. Inspired by RFC 2445 sec. 4.8.2.5</para>
    /// labels<para>duration</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#duration">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#duration</seealso>
    let duration = Prefixed_Name(ncal, "duration") |> PrefixedName
    /// <summary>
    ///   <para>ncal:encoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>To specify an alternate inline encoding for the property value. Inspired by RFC 2445 sec. 4.2.7. Originally this property had a limited vocabulary. ('8BIT' and 'BASE64'). The terms of this vocabulary have been expressed as instances of the AttachmentEncoding class</para>
    /// labels<para>encoding</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#encoding">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#encoding</seealso>
    let encoding = Prefixed_Name(ncal, "encoding") |> PrefixedName
    /// <summary>
    ///   <para>ncal:endTriggerRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:TriggerRelation</para>
    ///
    /// labels<para>endTriggerRelation</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#endTriggerRelation">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#endTriggerRelation</seealso>
    let endTriggerRelation = Prefixed_Name(ncal, "endTriggerRelation") |> PrefixedName
    /// <summary>
    ///   <para>ncal:Calendar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A calendar. Inspirations for this class can be traced to the VCALENDAR component defined in RFC 2445 sec. 4.4, but it may just as well be used to represent any kind of Calendar.</para>
    /// labels<para>Calendar</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Calendar">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Calendar</seealso>
    let Calendar = Prefixed_Name(ncal, "Calendar") |> PrefixedName
    /// <summary>
    ///   <para>ncal:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Provide a grouping of component properties that describe an event.</para>
    /// labels<para>Event</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Event">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Event</seealso>
    let Event = Prefixed_Name(ncal, "Event") |> PrefixedName

    /// <summary>
    ///   <para>ncal:UnionOfEventFreebusyJournalTodo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>UnionOfEventFreebusyJournalTodo</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfEventFreebusyJournalTodo">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfEventFreebusyJournalTodo</seealso>
    let UnionOfEventFreebusyJournalTodo =
        Prefixed_Name(ncal, "UnionOfEventFreebusyJournalTodo") |> PrefixedName

    /// <summary>
    ///   <para>ncal:CalendarDataObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A DataObject found in a calendar. It is usually interpreted as one of the calendar entity types (e.g. Event, Journal, Todo etc.)</para>
    /// labels<para>CalendarDataObject</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#CalendarDataObject">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#CalendarDataObject</seealso>
    let CalendarDataObject = Prefixed_Name(ncal, "CalendarDataObject") |> PrefixedName
    /// <summary>
    ///   <para>ncal:CalendarUserType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A calendar user type. This class has been introduced to express the limited vocabulary for the ncal:cutype property. See documentation of ncal:cutype for details.</para>
    /// labels<para>CalendarUserType</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#CalendarUserType">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#CalendarUserType</seealso>
    let CalendarUserType = Prefixed_Name(ncal, "CalendarUserType") |> PrefixedName

    /// <summary>
    ///   <para>ncal:UnionOfEventJournalTimezoneTodo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>UnionOfEventJournalTimezoneTodo</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfEventJournalTimezoneTodo">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfEventJournalTimezoneTodo</seealso>
    let UnionOfEventJournalTimezoneTodo =
        Prefixed_Name(ncal, "UnionOfEventJournalTimezoneTodo") |> PrefixedName

    /// <summary>
    ///   <para>ncal:UnionOfTimezoneObservanceEventFreebusyTimezoneTodo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>UnionOfTimezoneObservanceEventFreebusyTimezoneTodo</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfTimezoneObservanceEventFreebusyTimezoneTodo">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfTimezoneObservanceEventFreebusyTimezoneTodo</seealso>
    let UnionOfTimezoneObservanceEventFreebusyTimezoneTodo =
        Prefixed_Name(ncal, "UnionOfTimezoneObservanceEventFreebusyTimezoneTodo") |> PrefixedName

    /// <summary>
    ///   <para>ncal:UnionOfEventTodo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>UnionOfEventTodo</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfEventTodo">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfEventTodo</seealso>
    let UnionOfEventTodo = Prefixed_Name(ncal, "UnionOfEventTodo") |> PrefixedName
    /// <summary>
    ///   <para>ncal:cancelledTodoStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:TodoStatus</para>
    ///
    /// labels<para>cancelledTodoStatus</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#cancelledTodoStatus">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#cancelledTodoStatus</seealso>
    let cancelledTodoStatus = Prefixed_Name(ncal, "cancelledTodoStatus") |> PrefixedName
    /// <summary>
    ///   <para>ncal:chairRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:AttendeeRole</para>
    ///
    /// labels<para>chairRole</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#chairRole">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#chairRole</seealso>
    let chairRole = Prefixed_Name(ncal, "chairRole") |> PrefixedName
    /// <summary>
    ///   <para>ncal:completed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property defines the date and time that a to-do was actually completed. Inspired by RFC 2445 sec. 4.8.2.1. Note that the RFC allows ONLY UTC time values for this property.</para>
    /// labels<para>completed</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#completed">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#completed</seealso>
    let completed = Prefixed_Name(ncal, "completed") |> PrefixedName
    /// <summary>
    ///   <para>ncal:component</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Links the Vcalendar instance with the calendar components. This property has no direct equivalent in the RFC specification. It has been introduced to express the containmnent relations.</para>
    /// labels<para>component</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#component">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#component</seealso>
    let component_ = Prefixed_Name(ncal, "component") |> PrefixedName
    /// <summary>
    ///   <para>ncal:contact</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property is used to represent contact information or alternately a reference to contact information associated with the calendar component. Inspired by RFC 2445 sec. 4.8.4.2 with the following reservations: the LANGUAGE parameter has been discarded. Please use xml:lang literals to express language. For the ALTREP parameter use the contactAltRep property.RFC doesn't define any format for the string.</para>
    /// labels<para>contact</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#contact">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#contact</seealso>
    let contact = Prefixed_Name(ncal, "contact") |> PrefixedName
    /// <summary>
    ///   <para>ncal:contactAltRep</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Alternate representation of the contact property. Introduced to cover
    /// the ALTREP parameter of the CONTACT property. See
    /// documentation of ncal:contact for details.</para>
    /// labels<para>contactAltRep</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#contactAltRep">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#contactAltRep</seealso>
    let contactAltRep = Prefixed_Name(ncal, "contactAltRep") |> PrefixedName
    /// <summary>
    ///   <para>ncal:created</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property specifies the date and time that the calendar information was created by the calendar user agent in the calendar store. Note: This is analogous to the creation date and time for a file in the file system. Inspired by RFC 2445 sec. 4.8.7.1. Note that this property is a subproperty of nie:created. The domain of nie:created is nie:DataObject. It is not a superclass of UnionOf_Vevent_Vjournal_Vtodo, but since that union is conceived as an 'abstract' class, and in real-life all resources referenced by this property will also be DataObjects, than this shouldn't cause too much of a problem. Note that RFC allows ONLY UTC time values for this property.</para>
    /// labels<para>created</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#created">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#created</seealso>
    let created = Prefixed_Name(ncal, "created") |> PrefixedName
    /// <summary>
    ///   <para>ncal:daily</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:RecurrenceFrequency</para>
    ///
    /// labels<para>daily</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#daily">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#daily</seealso>
    let daily = Prefixed_Name(ncal, "daily") |> PrefixedName
    /// <summary>
    ///   <para>ncal:dateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Representation of a date an instance of NcalDateTime actually refers to. It's purpose is to express values in DATE-TIME datatype, as defined in RFC 2445 sec. 4.3.5</para>
    /// labels<para>dateTime</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#dateTime">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#dateTime</seealso>
    let dateTime = Prefixed_Name(ncal, "dateTime") |> PrefixedName

    /// <summary>
    ///   <para>ncal:declinedParticipationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:ParticipationStatus</para>
    ///
    /// labels<para>declinedParticipationStatus</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#declinedParticipationStatus">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#declinedParticipationStatus</seealso>
    let declinedParticipationStatus =
        Prefixed_Name(ncal, "declinedParticipationStatus") |> PrefixedName

    /// <summary>
    ///   <para>ncal:delegatedParticipationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:ParticipationStatus</para>
    ///
    /// labels<para>delegatedParticipationStatus</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#delegatedParticipationStatus">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#delegatedParticipationStatus</seealso>
    let delegatedParticipationStatus =
        Prefixed_Name(ncal, "delegatedParticipationStatus") |> PrefixedName

    /// <summary>
    ///   <para>ncal:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A more complete description of the calendar component, than  that provided by the ncal:summary property.Inspired by RFC 2445 sec. 4.8.1.5 with following reservations:  the LANGUAGE parameter has been discarded. Please use xml:lang literals to express language. For the ALTREP parameter use the descriptionAltRep property.</para>
    /// labels<para>description</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#description">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#description</seealso>
    let description = Prefixed_Name(ncal, "description") |> PrefixedName
    /// <summary>
    ///   <para>ncal:draftStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:JournalStatus</para>
    ///
    /// labels<para>draftStatus</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#draftStatus">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#draftStatus</seealso>
    let draftStatus = Prefixed_Name(ncal, "draftStatus") |> PrefixedName
    /// <summary>
    ///   <para>ncal:dtend</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property specifies the date and time that a calendar component ends. Inspired by RFC 2445 sec. 4.8.2.2</para>
    /// labels<para>dtend</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#dtend">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#dtend</seealso>
    let dtend = Prefixed_Name(ncal, "dtend") |> PrefixedName
    /// <summary>
    ///   <para>ncal:due</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property defines the date and time that a to-do is expected to be completed. Inspired by RFC 2445 sec. 4.8.2.3</para>
    /// labels<para>due</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#due">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#due</seealso>
    let due = Prefixed_Name(ncal, "due") |> PrefixedName
    /// <summary>
    ///   <para>ncal:emailAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:AlarmAction</para>
    ///
    /// labels<para>emailAction</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#emailAction">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#emailAction</seealso>
    let emailAction = Prefixed_Name(ncal, "emailAction") |> PrefixedName
    /// <summary>
    ///   <para>ncal:exdate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property defines the list of date/time exceptions for a recurring calendar component. Inspired by RFC 2445 sec. 4.8.5.1</para>
    /// labels<para>exdate</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#exdate">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#exdate</seealso>
    let exdate = Prefixed_Name(ncal, "exdate") |> PrefixedName
    /// <summary>
    ///   <para>ncal:fbtype</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>To specify the free or busy time type. Inspired by RFC 2445 sec. 4.2.9. The RFC specified a limited vocabulary for the values of this property. The terms of this vocabulary have been expressed as instances of the FreebusyType class. The user can use instances provided with this ontology or create his own.</para>
    /// labels<para>fbtype</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#fbtype">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#fbtype</seealso>
    let fbtype = Prefixed_Name(ncal, "fbtype") |> PrefixedName
    /// <summary>
    ///   <para>ncal:fmttype</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>To specify the content type of a referenced object. Inspired by RFC 2445 sec. 4.2.8. The value of this property should be an IANA-registered content type (e.g. application/binary)</para>
    /// labels<para>fmttype</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#fmttype">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#fmttype</seealso>
    let fmttype = Prefixed_Name(ncal, "fmttype") |> PrefixedName
    /// <summary>
    ///   <para>ncal:freebusy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property defines one or more free or busy time intervals. Inspired by RFC 2445 sec. 4.8.2.6. Note that the periods specified by this property can only be expressed with UTC times. Originally this property could have many comma-separated values. Please use a separate triple for each value.</para>
    /// labels<para>freebusy</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#freebusy">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#freebusy</seealso>
    let freebusy = Prefixed_Name(ncal, "freebusy") |> PrefixedName
    /// <summary>
    ///   <para>ncal:freq</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Frequency of a recurrence rule. Defined in RFC 2445 sec. 4.3.10</para>
    /// labels<para>freq</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#freq">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#freq</seealso>
    let freq = Prefixed_Name(ncal, "freq") |> PrefixedName

    /// <summary>
    ///   <para>ncal:gregorianCalendarScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:CalendarScale</para>
    ///
    /// labels<para>gregorianCalendarScale</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#gregorianCalendarScale">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#gregorianCalendarScale</seealso>
    let gregorianCalendarScale =
        Prefixed_Name(ncal, "gregorianCalendarScale") |> PrefixedName

    /// <summary>
    ///   <para>ncal:groupUserType</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:CalendarUserType</para>
    ///
    /// labels<para>groupUserType</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#groupUserType">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#groupUserType</seealso>
    let groupUserType = Prefixed_Name(ncal, "groupUserType") |> PrefixedName
    /// <summary>
    ///   <para>ncal:hasAlarm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Links an event or a todo with a DataObject that can be interpreted as an alarm. This property has no direct equivalent in the RFC 2445. It has been provided to express this relation.</para>
    /// labels<para>hasAlarm</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#hasAlarm">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#hasAlarm</seealso>
    let hasAlarm = Prefixed_Name(ncal, "hasAlarm") |> PrefixedName
    /// <summary>
    ///   <para>ncal:interval</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The INTERVAL rule part contains a positive integer representing how often the recurrence rule repeats. The default value is "1", meaning every second for a SECONDLY rule, or every minute for a MINUTELY rule, every hour for an HOURLY rule, every day for a DAILY rule, every week for a WEEKLY rule, every month for a MONTHLY rule andevery year for a YEARLY rule. Defined in RFC 2445 sec. 4.3.10</para>
    /// labels<para>interval</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#interval">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#interval</seealso>
    let interval = Prefixed_Name(ncal, "interval") |> PrefixedName
    /// <summary>
    ///   <para>ncal:involvedContact</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A contact of the Attendee or the organizer involved in an event or other calendar entity. This property has been introduced to express the actual value of the ATTENDEE and ORGANIZER properties. The contact will also represent the CN parameter of those properties. See documentation of ncal:attendee or ncal:organizer for more details.</para>
    /// labels<para>involvedContact</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#involvedContact">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#involvedContact</seealso>
    let involvedContact = Prefixed_Name(ncal, "involvedContact") |> PrefixedName
    /// <summary>
    ///   <para>ncal:journalStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Defines the overall status or confirmation for a journal entry. Based on the STATUS property defined in RFC 2445 sec. 4.8.1.11.</para>
    /// labels<para>status</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#journalStatus">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#journalStatus</seealso>
    let journalStatus = Prefixed_Name(ncal, "journalStatus") |> PrefixedName
    /// <summary>
    ///   <para>ncal:location</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Defines the intended venue for the activity defined by a calendar component. Inspired by RFC 2445 sec 4.8.1.7 with the following reservations:  the LANGUAGE parameter has been discarded. Please use xml:lang literals to express language.  For the ALTREP parameter use the locationAltRep property.</para>
    /// labels<para>location</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#location">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#location</seealso>
    let location = Prefixed_Name(ncal, "location") |> PrefixedName
    /// <summary>
    ///   <para>ncal:locationAltRep</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Alternate representation of the event or todo location.
    /// Introduced to cover the ALTREP parameter of the LOCATION
    /// property. See documentation of ncal:location for details.</para>
    /// labels<para>locationAltRep</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#locationAltRep">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#locationAltRep</seealso>
    let locationAltRep = Prefixed_Name(ncal, "locationAltRep") |> PrefixedName
    /// <summary>
    ///   <para>ncal:member</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>To specify the group or list membership of the calendar user specified by the property. Inspired by RFC 2445 sec. 4.2.11. Originally this parameter had a value type of CAL-ADDRESS. This has been expressed as nco:Contact to promote integration between NCAL and NCO</para>
    /// labels<para>member</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#member">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#member</seealso>
    let member_ = Prefixed_Name(ncal, "member") |> PrefixedName
    /// <summary>
    ///   <para>ncal:minutely</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:RecurrenceFrequency</para>
    ///
    /// labels<para>minutely</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#minutely">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#minutely</seealso>
    let minutely = Prefixed_Name(ncal, "minutely") |> PrefixedName
    /// <summary>
    ///   <para>ncal:monday</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:Weekday</para>
    ///
    /// labels<para>monday</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#monday">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#monday</seealso>
    let monday = Prefixed_Name(ncal, "monday") |> PrefixedName
    /// <summary>
    ///   <para>ncal:monthly</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:RecurrenceFrequency</para>
    ///
    /// labels<para>monthly</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#monthly">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#monthly</seealso>
    let monthly = Prefixed_Name(ncal, "monthly") |> PrefixedName
    /// <summary>
    ///   <para>ncal:ncalRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A common superproperty for all types of ncal relations. It is not to be used directly.</para>
    /// labels<para>ncalRelation</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#ncalRelation">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#ncalRelation</seealso>
    let ncalRelation = Prefixed_Name(ncal, "ncalRelation") |> PrefixedName

    /// <summary>
    ///   <para>ncal:needsActionParticipationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:ParticipationStatus</para>
    ///
    /// labels<para>needsActionParticipationStatus</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#needsActionParticipationStatus">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#needsActionParticipationStatus</seealso>
    let needsActionParticipationStatus =
        Prefixed_Name(ncal, "needsActionParticipationStatus") |> PrefixedName

    /// <summary>
    ///   <para>ncal:needsActionStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:TodoStatus</para>
    ///
    /// labels<para>needsActionStatus</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#needsActionStatus">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#needsActionStatus</seealso>
    let needsActionStatus = Prefixed_Name(ncal, "needsActionStatus") |> PrefixedName
    /// <summary>
    ///   <para>ncal:nonParticipantRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:AttendeeRole</para>
    ///
    /// labels<para>nonParticipantRole</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#nonParticipantRole">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#nonParticipantRole</seealso>
    let nonParticipantRole = Prefixed_Name(ncal, "nonParticipantRole") |> PrefixedName
    /// <summary>
    ///   <para>ncal:opaqueTransparency</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:TimeTransparency</para>
    ///
    /// labels<para>opaqueTransparency</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#opaqueTransparency">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#opaqueTransparency</seealso>
    let opaqueTransparency = Prefixed_Name(ncal, "opaqueTransparency") |> PrefixedName

    /// <summary>
    ///   <para>ncal:UnionOfTimezoneObservanceEventFreebusyJournalTimezoneTodo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>UnionOfTimezoneObservanceEventFreebusyJournalTimezoneTodo</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfTimezoneObservanceEventFreebusyJournalTimezoneTodo">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfTimezoneObservanceEventFreebusyJournalTimezoneTodo</seealso>
    let UnionOfTimezoneObservanceEventFreebusyJournalTimezoneTodo =
        Prefixed_Name(ncal, "UnionOfTimezoneObservanceEventFreebusyJournalTimezoneTodo") |> PrefixedName

    /// <summary>
    ///   <para>ncal:UnionOfEventJournalTodo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>UnionOfEventJournalTodo</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfEventJournalTodo">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfEventJournalTodo</seealso>
    let UnionOfEventJournalTodo =
        Prefixed_Name(ncal, "UnionOfEventJournalTodo") |> PrefixedName

    /// <summary>
    ///   <para>ncal:NcalPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A period of time. Inspired by the PERIOD datatype specified in RFC 2445 sec. 4.3.9</para>
    /// labels<para>NcalPeriod</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#NcalPeriod">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#NcalPeriod</seealso>
    let NcalPeriod = Prefixed_Name(ncal, "NcalPeriod") |> PrefixedName
    /// <summary>
    ///   <para>ncal:JournalStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A status of a journal entry. This class has been introduced to express
    /// the limited set of values for the ncal:status property. The user may
    /// use the instances provided with this ontology or create his/her own.
    /// See the documentation for ncal:journalStatus for details.</para>
    /// labels<para>JournalStatus</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#JournalStatus">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#JournalStatus</seealso>
    let JournalStatus = Prefixed_Name(ncal, "JournalStatus") |> PrefixedName

    /// <summary>
    ///   <para>ncal:UnionOfEventFreebusy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>UnionOfEventFreebusy</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfEventFreebusy">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfEventFreebusy</seealso>
    let UnionOfEventFreebusy =
        Prefixed_Name(ncal, "UnionOfEventFreebusy") |> PrefixedName

    /// <summary>
    ///   <para>ncal:Freebusy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Provide a grouping of component properties that describe either a request for free/busy time, describe a response to a request for free/busy time or describe a published set of busy time.</para>
    /// labels<para>Freebusy</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Freebusy">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Freebusy</seealso>
    let Freebusy = Prefixed_Name(ncal, "Freebusy") |> PrefixedName
    /// <summary>
    ///   <para>ncal:FreebusyPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An aggregate of a period and a freebusy type. This class has been introduced to serve as a range of the ncal:freebusy property. See documentation for ncal:freebusy for details. Note that the specification of freebusy property states that the period is to be expressed using UTC time, so the timezone properties should NOT be used for instances of this class.</para>
    /// labels<para>FreebusyPeriod</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#FreebusyPeriod">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#FreebusyPeriod</seealso>
    let FreebusyPeriod = Prefixed_Name(ncal, "FreebusyPeriod") |> PrefixedName
    /// <summary>
    ///   <para>ncal:geo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property specifies information related to the global position for the activity specified by a calendar component. Inspired by RFC 2445 sec. 4.8.1.6</para>
    /// labels<para>geo</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#geo">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#geo</seealso>
    let geo = Prefixed_Name(ncal, "geo") |> PrefixedName
    /// <summary>
    ///   <para>ncal:inProcessStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:TodoStatus</para>
    ///
    /// labels<para>inProcessStatus</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#inProcessStatus">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#inProcessStatus</seealso>
    let inProcessStatus = Prefixed_Name(ncal, "inProcessStatus") |> PrefixedName
    /// <summary>
    ///   <para>ncal:EventStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A status of an event. This class has been introduced to express
    /// the limited set of values for the ncal:status property. The user may
    /// use the instances provided with this ontology or create his/her own.
    /// See the documentation for ncal:eventStatus for details.</para>
    /// labels<para>EventStatus</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#EventStatus">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#EventStatus</seealso>
    let EventStatus = Prefixed_Name(ncal, "EventStatus") |> PrefixedName
    /// <summary>
    ///   <para>ncal:eventStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Defines the overall status or confirmation for an Event. Based on the STATUS property defined in RFC 2445 sec. 4.8.1.11.</para>
    /// labels<para>status</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#eventStatus">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#eventStatus</seealso>
    let eventStatus = Prefixed_Name(ncal, "eventStatus") |> PrefixedName
    /// <summary>
    ///   <para>ncal:exrule</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property defines a rule or repeating pattern for an exception to a recurrence set. Inspired by RFC 2445 sec. 4.8.5.2.</para>
    /// labels<para>exrule</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#exrule">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#exrule</seealso>
    let exrule = Prefixed_Name(ncal, "exrule") |> PrefixedName
    /// <summary>
    ///   <para>ncal:finalStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:JournalStatus</para>
    ///
    /// labels<para>finalStatus</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#finalStatus">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#finalStatus</seealso>
    let finalStatus = Prefixed_Name(ncal, "finalStatus") |> PrefixedName
    /// <summary>
    ///   <para>ncal:freeFreebusyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:FreebusyType</para>
    ///
    /// labels<para>freeFreebusyType</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#freeFreebusyType">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#freeFreebusyType</seealso>
    let freeFreebusyType = Prefixed_Name(ncal, "freeFreebusyType") |> PrefixedName
    /// <summary>
    ///   <para>ncal:friday</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:Weekday</para>
    ///
    /// labels<para>friday</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#friday">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#friday</seealso>
    let friday = Prefixed_Name(ncal, "friday") |> PrefixedName
    /// <summary>
    ///   <para>ncal:hourly</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:RecurrenceFrequency</para>
    ///
    /// labels<para>hourly</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#hourly">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#hourly</seealso>
    let hourly = Prefixed_Name(ncal, "hourly") |> PrefixedName
    /// <summary>
    ///   <para>ncal:individualUserType</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:CalendarUserType</para>
    ///
    /// labels<para>individualUserType</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#individualUserType">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#individualUserType</seealso>
    let individualUserType = Prefixed_Name(ncal, "individualUserType") |> PrefixedName

    /// <summary>
    ///   <para>ncal:inProcessParticipationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:ParticipationStatus</para>
    ///
    /// labels<para>inProcessParticipationStatus</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#inProcessParticipationStatus">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#inProcessParticipationStatus</seealso>
    let inProcessParticipationStatus =
        Prefixed_Name(ncal, "inProcessParticipationStatus") |> PrefixedName

    /// <summary>
    ///   <para>ncal:lastModified</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property specifies the date and time that the information associated with the calendar component was last revised in the calendar store. Note: This is analogous to the modification date and time for a file in the file system. Inspired by RFC 2445 sec. 4.8.7.3. Note that the RFC allows ONLY UTC time values for this property.</para>
    /// labels<para>lastModified</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#lastModified">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#lastModified</seealso>
    let lastModified = Prefixed_Name(ncal, "lastModified") |> PrefixedName
    /// <summary>
    ///   <para>ncal:method</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property defines the iCalendar object method associated with the calendar object. Defined in RFC 2445 sec. 4.7.2</para>
    /// labels<para>method</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#method">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#method</seealso>
    let method = Prefixed_Name(ncal, "method") |> PrefixedName
    /// <summary>
    ///   <para>ncal:organizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property defines the organizer for a calendar component. Inspired by RFC 2445 sec. 4.8.4.3. Originally this property accepted many parameters. The Organizer class has been introduced to express them all. Note that NCAL is aligned with NCO. The actual value (of the CAL-ADDRESS type) is expressed as an instance of nco:Contact. Remember that the CN parameter has been removed from NCAL. Instead that value should be expressed using nco:fullname property of the above mentioned nco:Contact instance.</para>
    /// labels<para>organizer</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#organizer">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#organizer</seealso>
    let organizer = Prefixed_Name(ncal, "organizer") |> PrefixedName
    /// <summary>
    ///   <para>ncal:partstat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>To specify the participation status for the calendar user specified by the property. Inspired by RFC 2445 sec. 4.2.12. Originally this parameter had three sets of allowed values. Which set applied to a particular case - depended on the type of calendar entity this parameter occured in. (event, todo, journal entry). This would be awkward to model in RDF so a single ParticipationStatus class has been introduced. Terms of the values vocabulary are expressed as instances of this class. Users are advised to pay attention which instances they use.</para>
    /// labels<para>partstat</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#partstat">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#partstat</seealso>
    let partstat = Prefixed_Name(ncal, "partstat") |> PrefixedName
    /// <summary>
    ///   <para>ncal:periodBegin</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Beginng of a period. Inspired by the first part of a structured value of the PERIOD datatype specified in RFC 2445 sec. 4.3.9</para>
    /// labels<para>periodBegin</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#periodBegin">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#periodBegin</seealso>
    let periodBegin = Prefixed_Name(ncal, "periodBegin") |> PrefixedName
    /// <summary>
    ///   <para>ncal:periodDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Duration of a period of time. Inspired by the second part of a structured value of the PERIOD datatype specified in RFC 2445 sec. 4.3.9. Note that a single NcalPeriod instance shouldn't have the periodEnd and periodDuration properties specified simultaneously.</para>
    /// labels<para>periodDuration</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#periodDuration">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#periodDuration</seealso>
    let periodDuration = Prefixed_Name(ncal, "periodDuration") |> PrefixedName
    /// <summary>
    ///   <para>ncal:priority</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property defines the relative priority for a calendar component. Inspired by RFC 2445 sec. 4.8.1.9</para>
    /// labels<para>priority</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#priority">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#priority</seealso>
    let priority = Prefixed_Name(ncal, "priority") |> PrefixedName

    /// <summary>
    ///   <para>ncal:privateClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:AccessClassification</para>
    ///
    /// labels<para>privateClassification</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#privateClassification">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#privateClassification</seealso>
    let privateClassification =
        Prefixed_Name(ncal, "privateClassification") |> PrefixedName

    /// <summary>
    ///   <para>ncal:range</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>To specify the effective range of recurrence instances from the instance specified by the recurrence identifier specified by the property. It is intended to express the RANGE parameter specified in RFC 2445 sec. 4.2.13. The set of possible values for this property is limited. See also the documentation for ncal:recurrenceId for more details.</para>
    /// labels<para>range</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#range">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#range</seealso>
    let range = Prefixed_Name(ncal, "range") |> PrefixedName
    /// <summary>
    ///   <para>ncal:FreebusyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Type of a Freebusy indication. This class has been introduced to serve as a limited set of values for the ncal:fbtype property. See the documentation of ncal:fbtype for details.</para>
    /// labels<para>FreebusyType</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#FreebusyType">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#FreebusyType</seealso>
    let FreebusyType = Prefixed_Name(ncal, "FreebusyType") |> PrefixedName
    /// <summary>
    ///   <para>ncal:percentComplete</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property is used by an assignee or delegatee of a to-do to convey the percent completion of a to-do to the Organizer. Inspired by RFC 2445 sec. 4.8.1.8</para>
    /// labels<para>percentComplete</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#percentComplete">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#percentComplete</seealso>
    let percentComplete = Prefixed_Name(ncal, "percentComplete") |> PrefixedName
    /// <summary>
    ///   <para>ncal:periodEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>End of a period of time. Inspired by the second part of a structured value of a PERIOD datatype specified in RFC 2445 sec. 4.3.9. Note that a single NcalPeriod instance shouldn't have the periodEnd and periodDuration properties specified simultaneously.</para>
    /// labels<para>periodEnd</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#periodEnd">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#periodEnd</seealso>
    let periodEnd = Prefixed_Name(ncal, "periodEnd") |> PrefixedName
    /// <summary>
    ///   <para>ncal:procedureAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:AlarmAction</para>
    ///
    /// labels<para>procedureAction</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#procedureAction">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#procedureAction</seealso>
    let procedureAction = Prefixed_Name(ncal, "procedureAction") |> PrefixedName

    /// <summary>
    ///   <para>ncal:publicClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:AccessClassification</para>
    ///
    /// labels<para>publicClassification</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#publicClassification">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#publicClassification</seealso>
    let publicClassification =
        Prefixed_Name(ncal, "publicClassification") |> PrefixedName

    /// <summary>
    ///   <para>ncal:recurrenceId</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property is used in conjunction with the "UID" and "SEQUENCE" property to identify a specific instance of a recurring "VEVENT", "VTODO" or "VJOURNAL" calendar component. The property value is the effective value of the "DTSTART" property of the recurrence instance. Inspired by the RFC 2445 sec. 4.8.4.4</para>
    /// labels<para>recurrenceId</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#recurrenceId">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#recurrenceId</seealso>
    let recurrenceId = Prefixed_Name(ncal, "recurrenceId") |> PrefixedName
    /// <summary>
    ///   <para>ncal:related</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>To specify the relationship of the alarm trigger with respect to the start or end of the calendar component. Inspired by RFC 2445 4.2.14. The RFC has specified two possible values for this property ('START' and 'END') they have been expressed as instances of the TriggerRelation class.</para>
    /// labels<para>related</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#related">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#related</seealso>
    let related = Prefixed_Name(ncal, "related") |> PrefixedName
    /// <summary>
    ///   <para>ncal:relatedToParent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property is used to represent a relationship or reference between one calendar component and another. Inspired by RFC 2445 sec. 4.8.4.5. Originally this property had a RELTYPE parameter. It has been decided that it is more natural to introduce three different properties to express the values of that parameter. This property expresses the RELATED-TO property with no RELTYPE parameter (the default value is PARENT), or with explicit RELTYPE=PARENT parameter.</para>
    /// labels<para>relatedToParent</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#relatedToParent">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#relatedToParent</seealso>
    let relatedToParent = Prefixed_Name(ncal, "relatedToParent") |> PrefixedName
    /// <summary>
    ///   <para>ncal:repeat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property defines the number of time the alarm should be repeated, after the initial trigger. Inspired by RFC 2445 sec. 4.8.6.2</para>
    /// labels<para>repeat</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#repeat">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#repeat</seealso>
    let repeat = Prefixed_Name(ncal, "repeat") |> PrefixedName
    /// <summary>
    ///   <para>ncal:requestStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property defines the status code returned for a scheduling request. Inspired by RFC 2445 sec. 4.8.8.2. Original value of this property was a four-element structure. The RequestStatus class has been introduced to express it. In RFC 2445 this property could have the LANGUAGE parameter. This has been discarded in this ontology. Use xml:lang literals to express it if necessary.</para>
    /// labels<para>requestStatus</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#requestStatus">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#requestStatus</seealso>
    let requestStatus = Prefixed_Name(ncal, "requestStatus") |> PrefixedName
    /// <summary>
    ///   <para>ncal:resourceUserType</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:CalendarUserType</para>
    ///
    /// labels<para>resourceUserType</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#resourceUserType">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#resourceUserType</seealso>
    let resourceUserType = Prefixed_Name(ncal, "resourceUserType") |> PrefixedName
    /// <summary>
    ///   <para>ncal:resources</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Defines the equipment or resources anticipated for an activity specified by a calendar entity. Inspired by RFC 2445 sec. 4.8.1.10 with the following reservations:  the LANGUAGE parameter has been discarded. Please use xml:lang literals to express language. For the ALTREP parameter use the resourcesAltRep property. This property specifies multiple resources. The order is not important. it is recommended to introduce a separate triple for each resource.</para>
    /// labels<para>resources</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#resources">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#resources</seealso>
    let resources = Prefixed_Name(ncal, "resources") |> PrefixedName
    /// <summary>
    ///   <para>ncal:returnStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Short return status. Inspired by the first element of the structured value of the REQUEST-STATUS property described in RFC 2445 sec. 4.8.8.2.
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
    /// 4.xx - Scheduling Error. This class of status code indicates that the request was not successful. Some sort of error occurred within the  calendaring and scheduling service, not directly related to the request itself.</para>
    /// labels<para>returnStatus</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#returnStatus">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#returnStatus</seealso>
    let returnStatus = Prefixed_Name(ncal, "returnStatus") |> PrefixedName
    /// <summary>
    ///   <para>ncal:role</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>To specify the participation role for the calendar user specified by the property. Inspired by the RFC 2445 sec. 4.2.16. Originally this property had a limited vocabulary for values. The terms of that vocabulary have been expressed as instances of the AttendeeRole class.</para>
    /// labels<para>role</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#role">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#role</seealso>
    let role = Prefixed_Name(ncal, "role") |> PrefixedName
    /// <summary>
    ///   <para>ncal:rrule</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property defines a rule or repeating pattern for recurring events, to-dos, or time zone definitions. sec. 4.8.5.4</para>
    /// labels<para>rrule</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#rrule">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#rrule</seealso>
    let rrule = Prefixed_Name(ncal, "rrule") |> PrefixedName
    /// <summary>
    ///   <para>ncal:rsvp</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>To specify whether there is an expectation of a favor of a reply from the calendar user specified by the property value. Inspired by RFC 2445 sec. 4.2.17</para>
    /// labels<para>rsvp</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#rsvp">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#rsvp</seealso>
    let rsvp = Prefixed_Name(ncal, "rsvp") |> PrefixedName
    /// <summary>
    ///   <para>ncal:secondly</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:RecurrenceFrequency</para>
    ///
    /// labels<para>secondly</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#secondly">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#secondly</seealso>
    let secondly = Prefixed_Name(ncal, "secondly") |> PrefixedName
    /// <summary>
    ///   <para>ncal:sentBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>To specify the calendar user that is acting on behalf of the calendar user specified by the property. Inspired by RFC 2445 sec. 4.2.18. The original data type of this property was a mailto: URI. This has been changed to nco:Contact to promote integration between NCO and NCAL.</para>
    /// labels<para>sentBy</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#sentBy">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#sentBy</seealso>
    let sentBy = Prefixed_Name(ncal, "sentBy") |> PrefixedName

    /// <summary>
    ///   <para>ncal:startTriggerRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:TriggerRelation</para>
    ///
    /// labels<para>startTriggerRelation</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#startTriggerRelation">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#startTriggerRelation</seealso>
    let startTriggerRelation =
        Prefixed_Name(ncal, "startTriggerRelation") |> PrefixedName

    /// <summary>
    ///   <para>ncal:statusDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Longer return status description. Inspired by the second part of the structured value of the REQUEST-STATUS property defined in RFC 2445 sec. 4.8.8.2</para>
    /// labels<para>statusDescription</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#statusDescription">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#statusDescription</seealso>
    let statusDescription = Prefixed_Name(ncal, "statusDescription") |> PrefixedName
    /// <summary>
    ///   <para>ncal:summaryAltRep</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Alternate representation of the comment. Introduced to cover
    /// the ALTREP parameter of the SUMMARY property. See
    /// documentation of ncal:summary for details.</para>
    /// labels<para>summaryAltRep</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#summaryAltRep">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#summaryAltRep</seealso>
    let summaryAltRep = Prefixed_Name(ncal, "summaryAltRep") |> PrefixedName
    /// <summary>
    ///   <para>ncal:tentativeStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:EventStatus</para>
    ///
    /// labels<para>tentativeStatus</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#tentativeStatus">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#tentativeStatus</seealso>
    let tentativeStatus = Prefixed_Name(ncal, "tentativeStatus") |> PrefixedName
    /// <summary>
    ///   <para>ncal:thisAndFutureRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:RecurrenceIdentifierRange</para>
    ///
    /// labels<para>thisAndFutureRange</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#thisAndFutureRange">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#thisAndFutureRange</seealso>
    let thisAndFutureRange = Prefixed_Name(ncal, "thisAndFutureRange") |> PrefixedName
    /// <summary>
    ///   <para>ncal:ncalTimezone</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The timezone instance that should be used to interpret an NcalDateTime. The purpose of this property is similar to the TZID parameter specified in RFC 2445 sec. 4.2.19</para>
    /// labels<para>ncalTimezone</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#ncalTimezone">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#ncalTimezone</seealso>
    let ncalTimezone = Prefixed_Name(ncal, "ncalTimezone") |> PrefixedName
    /// <summary>
    ///   <para>ncal:optParticipantRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:AttendeeRole</para>
    ///
    /// labels<para>optParticipantRole</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#optParticipantRole">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#optParticipantRole</seealso>
    let optParticipantRole = Prefixed_Name(ncal, "optParticipantRole") |> PrefixedName
    /// <summary>
    ///   <para>ncal:NcalTimeEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A time entity. Conceived as a common superclass for NcalDateTime and NcalPeriod. According to RFC 2445 both DateTime and Period can be interpreted in different timezones. The first case is explored in many properties. The second case is theoretically possible in ncal:rdate property. Therefore the timezone properties have been defined at this level.</para>
    /// labels<para>NcalTimeEntity</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#NcalTimeEntity">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#NcalTimeEntity</seealso>
    let NcalTimeEntity = Prefixed_Name(ncal, "NcalTimeEntity") |> PrefixedName
    /// <summary>
    ///   <para>ncal:TimeTransparency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Time transparency. Introduced to provide a way to express
    /// the limited vocabulary for the values of ncal:transp property.
    /// See documentation of ncal:transp for details.</para>
    /// labels<para>TimeTransparency</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#TimeTransparency">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#TimeTransparency</seealso>
    let TimeTransparency = Prefixed_Name(ncal, "TimeTransparency") |> PrefixedName
    /// <summary>
    ///   <para>ncal:Todo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Provide a grouping of calendar properties that describe a to-do.</para>
    /// labels<para>Todo</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Todo">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Todo</seealso>
    let Todo = Prefixed_Name(ncal, "Todo") |> PrefixedName
    /// <summary>
    ///   <para>ncal:Trigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An alarm trigger. This class has been created to serve as the range of ncal:trigger property. See the documentation for ncal:trigger for more details.</para>
    /// labels<para>Trigger</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Trigger">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Trigger</seealso>
    let Trigger = Prefixed_Name(ncal, "Trigger") |> PrefixedName
    /// <summary>
    ///   <para>ncal:UnionParentClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>UnionParentClass</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionParentClass">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionParentClass</seealso>
    let UnionParentClass = Prefixed_Name(ncal, "UnionParentClass") |> PrefixedName
    /// <summary>
    ///   <para>ncal:ParticipationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Participation Status. This class has been introduced to express the limited vocabulary of values for the ncal:partstat property. See the documentation of ncal:partstat for details.</para>
    /// labels<para>ParticipationStatus</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#ParticipationStatus">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#ParticipationStatus</seealso>
    let ParticipationStatus = Prefixed_Name(ncal, "ParticipationStatus") |> PrefixedName

    /// <summary>
    ///   <para>ncal:RecurrenceIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Recurrence Identifier. Introduced to provide a structure for the value of ncal:recurrenceId property. See the documentation of ncal:recurrenceId for details.</para>
    /// labels<para>RecurrenceIdentifier</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#RecurrenceIdentifier">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#RecurrenceIdentifier</seealso>
    let RecurrenceIdentifier =
        Prefixed_Name(ncal, "RecurrenceIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>ncal:RecurrenceIdentifierRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Recurrence Identifier Range. This class has been created to provide means to express the limited set of values for the ncal:range property. See documentation for ncal:range for details.</para>
    /// labels<para>RecurrenceIdentifierRange</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#RecurrenceIdentifierRange">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#RecurrenceIdentifierRange</seealso>
    let RecurrenceIdentifierRange =
        Prefixed_Name(ncal, "RecurrenceIdentifierRange") |> PrefixedName

    /// <summary>
    ///   <para>ncal:thisAndPriorRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:RecurrenceIdentifierRange</para>
    ///
    /// labels<para>thisAndPriorRange</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#thisAndPriorRange">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#thisAndPriorRange</seealso>
    let thisAndPriorRange = Prefixed_Name(ncal, "thisAndPriorRange") |> PrefixedName

    /// <summary>
    ///   <para>ncal:transparentTransparency</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:TimeTransparency</para>
    ///
    /// labels<para>transparentTransparency</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#transparentTransparency">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#transparentTransparency</seealso>
    let transparentTransparency =
        Prefixed_Name(ncal, "transparentTransparency") |> PrefixedName

    /// <summary>
    ///   <para>ncal:RecurrenceFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Frequency of a recurrence rule. This class has been introduced to express a limited set of allowed values for the ncal:freq property. See the documentation of ncal:freq for details.</para>
    /// labels<para>RecurrenceFrequency</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#RecurrenceFrequency">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#RecurrenceFrequency</seealso>
    let RecurrenceFrequency = Prefixed_Name(ncal, "RecurrenceFrequency") |> PrefixedName
    /// <summary>
    ///   <para>ncal:RequestStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Request Status. A class that was introduced to provide a structure for the value of ncal:requestStatus property. See documentation for ncal:requestStatus for details.</para>
    /// labels<para>RequestStatus</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#RequestStatus">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#RequestStatus</seealso>
    let RequestStatus = Prefixed_Name(ncal, "RequestStatus") |> PrefixedName
    /// <summary>
    ///   <para>ncal:TimezoneObservance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>TimezoneObservance</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#TimezoneObservance">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#TimezoneObservance</seealso>
    let TimezoneObservance = Prefixed_Name(ncal, "TimezoneObservance") |> PrefixedName
    /// <summary>
    ///   <para>ncal:wkst</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The day that's counted as the start of the week. It is used to disambiguate the byweekno rule. Defined in RFC 2445 sec. 4.3.10</para>
    /// labels<para>wkst</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#wkst">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#wkst</seealso>
    let wkst = Prefixed_Name(ncal, "wkst") |> PrefixedName
    /// <summary>
    ///   <para>ncal:sequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property defines the revision sequence number of the calendar component within a sequence of revisions. Inspired by RFC 2445 sec. 4.8.7.4</para>
    /// labels<para>sequence</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#sequence">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#sequence</seealso>
    let sequence = Prefixed_Name(ncal, "sequence") |> PrefixedName
    /// <summary>
    ///   <para>ncal:Timezone</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Provide a grouping of component properties that defines a time zone.</para>
    /// labels<para>Timezone</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Timezone">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Timezone</seealso>
    let Timezone = Prefixed_Name(ncal, "Timezone") |> PrefixedName
    /// <summary>
    ///   <para>ncal:TodoStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A status of a calendar entity. This class has been introduced to express
    /// the limited set of values for the ncal:status property. The user may
    /// use the instances provided with this ontology or create his/her own.
    /// See the documentation for ncal:todoStatus for details.</para>
    /// labels<para>TodoStatus</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#TodoStatus">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#TodoStatus</seealso>
    let TodoStatus = Prefixed_Name(ncal, "TodoStatus") |> PrefixedName
    /// <summary>
    ///   <para>ncal:TriggerRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The relation between the trigger and its parent calendar component. This class has been introduced to express the limited vocabulary for the ncal:related property. See the documentation for ncal:related for more details.</para>
    /// labels<para>TriggerRelation</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#TriggerRelation">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#TriggerRelation</seealso>
    let TriggerRelation = Prefixed_Name(ncal, "TriggerRelation") |> PrefixedName
    /// <summary>
    ///   <para>ncal:Weekday</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Day of the week. This class has been created to provide the limited vocabulary for ncal:byday property. See the documentation for ncal:byday for details.</para>
    /// labels<para>Weekday</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Weekday">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#Weekday</seealso>
    let Weekday = Prefixed_Name(ncal, "Weekday") |> PrefixedName
    /// <summary>
    ///   <para>ncal:_8bitEncoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:AttachmentEncoding</para>
    ///
    /// labels<para>_8bitEncoding</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#_8bitEncoding">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#_8bitEncoding</seealso>
    let _8bitEncoding = Prefixed_Name(ncal, "_8bitEncoding") |> PrefixedName
    /// <summary>
    ///   <para>ncal:action</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property defines the action to be invoked when an alarm is triggered. Inspired by RFC 2445 sec 4.8.6.1. Originally this property had a limited set of values. They are expressed as instances of the AlarmAction class.</para>
    /// labels<para>action</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#action">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#action</seealso>
    let action = Prefixed_Name(ncal, "action") |> PrefixedName
    /// <summary>
    ///   <para>ncal:attach</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property provides the capability to associate a document object with a calendar component. Defined in the RFC 2445 sec. 4.8.1.1</para>
    /// labels<para>attach</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#attach">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#attach</seealso>
    let attach = Prefixed_Name(ncal, "attach") |> PrefixedName
    /// <summary>
    ///   <para>ncal:attachmentContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The uri of the attachment. Created to express the actual value of the ATTACH property defined in RFC 2445 sec. 4.8.1.1. This property expresses the BINARY datatype of that property. see ncal:attachmentUri for the URI datatype.</para>
    /// labels<para>attachmentContent</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#attachmentContent">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#attachmentContent</seealso>
    let attachmentContent = Prefixed_Name(ncal, "attachmentContent") |> PrefixedName
    /// <summary>
    ///   <para>ncal:attendee</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property defines an "Attendee" within a calendar component. Inspired by RFC 2445 sec. 4.8.4.1. Originally this property accepted many parameters. The Attendee class has been introduced to express them all. Note that NCAL is aligned with NCO. The actual value (of the CAL-ADDRESS type) is expressed as an instance of nco:Contact. Remember that the CN parameter has been removed from NCAL. Instead that value should be expressed using nco:fullname property of the above mentioned nco:Contact instance. The RFC stated that whenever this property is attached to a Valarm instance, the Attendee cannot have any parameters apart from involvedContact.</para>
    /// labels<para>attendee</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#attendee">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#attendee</seealso>
    let attendee = Prefixed_Name(ncal, "attendee") |> PrefixedName
    /// <summary>
    ///   <para>ncal:base64Encoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:AttachmentEncoding</para>
    ///
    /// labels<para>base64Encoding</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#base64Encoding">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#base64Encoding</seealso>
    let base64Encoding = Prefixed_Name(ncal, "base64Encoding") |> PrefixedName
    /// <summary>
    ///   <para>ncal:busyFreebusyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:FreebusyType</para>
    ///
    /// labels<para>busyFreebusyType</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#busyFreebusyType">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#busyFreebusyType</seealso>
    let busyFreebusyType = Prefixed_Name(ncal, "busyFreebusyType") |> PrefixedName
    /// <summary>
    ///   <para>ncal:byday</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Weekdays the recurrence should occur. Defined in RFC 2445 sec. 4.3.10</para>
    /// labels<para>byday</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#byday">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#byday</seealso>
    let byday = Prefixed_Name(ncal, "byday") |> PrefixedName
    /// <summary>
    ///   <para>ncal:bydayWeekday</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Connects a BydayRulePath with a weekday.</para>
    /// labels<para>bydayWeekday</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#bydayWeekday">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#bydayWeekday</seealso>
    let bydayWeekday = Prefixed_Name(ncal, "bydayWeekday") |> PrefixedName
    /// <summary>
    ///   <para>ncal:byminute</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Minute of recurrence. Defined in RFC 2445 sec. 4.3.10</para>
    /// labels<para>byminute</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#byminute">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#byminute</seealso>
    let byminute = Prefixed_Name(ncal, "byminute") |> PrefixedName
    /// <summary>
    ///   <para>ncal:bymonth</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Number of the month of the recurrence. Valid values are integers from 1 (January) to 12 (December). Defined in RFC 2445 sec. 4.3.10</para>
    /// labels<para>bymonth</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#bymonth">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#bymonth</seealso>
    let bymonth = Prefixed_Name(ncal, "bymonth") |> PrefixedName
    /// <summary>
    ///   <para>ncal:bymonthday</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Day of the month when the event should recur. Defined in RFC 2445 sec. 4.3.10</para>
    /// labels<para>bymonthday</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#bymonthday">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#bymonthday</seealso>
    let bymonthday = Prefixed_Name(ncal, "bymonthday") |> PrefixedName
    /// <summary>
    ///   <para>ncal:bysetpos</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The BYSETPOS rule part specify values which correspond to the nth occurrence within the set of events specified by the rule. Valid values are 1 to 366 or -366 to -1. It MUST only be used in conjunction with another BYxxx rule part. For example "the last work day of the month" could be represented as: RRULE: FREQ=MONTHLY; BYDAY=MO, TU, WE, TH, FR; BYSETPOS=-1. Each BYSETPOS value can include a positive (+n) or negative (-n)  integer. If present, this indicates the nth occurrence of the  specific occurrence within the set of events specified by the rule. Defined in RFC 2445 sec. 4.3.10</para>
    /// labels<para>bysetpos</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#bysetpos">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#bysetpos</seealso>
    let bysetpos = Prefixed_Name(ncal, "bysetpos") |> PrefixedName
    /// <summary>
    ///   <para>ncal:byweekno</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of the week an event should recur. Defined in RFC 2445 sec. 4.3.10</para>
    /// labels<para>byweekno</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#byweekno">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#byweekno</seealso>
    let byweekno = Prefixed_Name(ncal, "byweekno") |> PrefixedName
    /// <summary>
    ///   <para>ncal:calscale</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property defines the calendar scale used for the calendar information specified in the iCalendar object. Defined in RFC 2445 sec. 4.7.1</para>
    /// labels<para>calscale</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#calscale">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#calscale</seealso>
    let calscale = Prefixed_Name(ncal, "calscale") |> PrefixedName

    /// <summary>
    ///   <para>ncal:cancelledEventStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:EventStatus</para>
    ///
    /// labels<para>cancelledEventStatus</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#cancelledEventStatus">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#cancelledEventStatus</seealso>
    let cancelledEventStatus =
        Prefixed_Name(ncal, "cancelledEventStatus") |> PrefixedName

    /// <summary>
    ///   <para>ncal:cancelledJournalStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:JournalStatus</para>
    ///
    /// labels<para>cancelledJournalStatus</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#cancelledJournalStatus">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#cancelledJournalStatus</seealso>
    let cancelledJournalStatus =
        Prefixed_Name(ncal, "cancelledJournalStatus") |> PrefixedName

    /// <summary>
    ///   <para>ncal:class</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Defines the access classification for a calendar component. Inspired by RFC 2445 sec. 4.8.1.3 with the following reservations:  this property has limited vocabulary. Possible values are:  PUBLIC, PRIVATE and CONFIDENTIAL. The default is PUBLIC. Those values are expressed as instances of the AccessClassification class. The user may create his/her own if necessary.</para>
    /// labels<para>class</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#class">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#class</seealso>
    let class_ = Prefixed_Name(ncal, "class") |> PrefixedName
    /// <summary>
    ///   <para>ncal:comment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Non-processing information intended to provide a comment to the calendar user. Inspired by RFC 2445 sec. 4.8.1.4 with the following reservations:  the LANGUAGE parameter has been discarded. Please use xml:lang literals to express language. For the ALTREP parameter use the commentAltRep property.</para>
    /// labels<para>comment</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#comment">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#comment</seealso>
    let comment = Prefixed_Name(ncal, "comment") |> PrefixedName
    /// <summary>
    ///   <para>ncal:url</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This property defines a Uniform Resource Locator (URL) associated with the iCalendar object. Inspired by the RFC 2445 sec. 4.8.4.6. Original range had been specified as URI.</para>
    /// labels<para>url</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#url">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#url</seealso>
    let url = Prefixed_Name(ncal, "url") |> PrefixedName
    /// <summary>
    ///   <para>ncal:yearly</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:RecurrenceFrequency</para>
    ///
    /// labels<para>yearly</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#yearly">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#yearly</seealso>
    let yearly = Prefixed_Name(ncal, "yearly") |> PrefixedName

    /// <summary>
    ///   <para>ncal:acceptedParticipationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:ParticipationStatus</para>
    ///
    /// labels<para>acceptedParticipationStatus</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#acceptedParticipationStatus">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#acceptedParticipationStatus</seealso>
    let acceptedParticipationStatus =
        Prefixed_Name(ncal, "acceptedParticipationStatus") |> PrefixedName

    /// <summary>
    ///   <para>ncal:audioAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:AlarmAction</para>
    ///
    /// labels<para>audioAction</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#audioAction">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#audioAction</seealso>
    let audioAction = Prefixed_Name(ncal, "audioAction") |> PrefixedName

    /// <summary>
    ///   <para>ncal:busyTentativeFreebusyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:FreebusyType</para>
    ///
    /// labels<para>busyTentativeFreebusyType</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#busyTentativeFreebusyType">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#busyTentativeFreebusyType</seealso>
    let busyTentativeFreebusyType =
        Prefixed_Name(ncal, "busyTentativeFreebusyType") |> PrefixedName

    /// <summary>
    ///   <para>ncal:bydayModifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An integer modifier for the BYDAY rule part.    Each BYDAY value can also be preceded by a positive (+n) or negative  (-n) integer. If present, this indicates the nth occurrence of the specific day within the MONTHLY or YEARLY RRULE. For example, within a MONTHLY rule, +1MO (or simply 1MO) represents the first Monday within the month, whereas -1MO represents the last Monday of the month. If an integer modifier is not present, it means all days of this type within the specified frequency. For example, within a MONTHLY rule, MO represents all Mondays within the month. Inspired by RFC 2445 sec. 4.3.10</para>
    /// labels<para>bydayModifier</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#bydayModifier">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#bydayModifier</seealso>
    let bydayModifier = Prefixed_Name(ncal, "bydayModifier") |> PrefixedName

    /// <summary>
    ///   <para>ncal:busyUnavailableFreebusyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:FreebusyType</para>
    ///
    /// labels<para>busyUnavailableFreebusyType</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#busyUnavailableFreebusyType">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#busyUnavailableFreebusyType</seealso>
    let busyUnavailableFreebusyType =
        Prefixed_Name(ncal, "busyUnavailableFreebusyType") |> PrefixedName

    /// <summary>
    ///   <para>ncal:byhour</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Hour of recurrence. Defined in RFC 2445 sec. 4.3.10</para>
    /// labels<para>byhour</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#byhour">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#byhour</seealso>
    let byhour = Prefixed_Name(ncal, "byhour") |> PrefixedName
    /// <summary>
    ///   <para>ncal:bysecond</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Second of a recurrence. Defined in RFC 2445 sec. 4.3.10</para>
    /// labels<para>bysecond</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#bysecond">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#bysecond</seealso>
    let bysecond = Prefixed_Name(ncal, "bysecond") |> PrefixedName
    /// <summary>
    ///   <para>ncal:byyearday</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Day of the year the event should occur. Defined in RFC 2445 sec. 4.3.10</para>
    /// labels<para>byyearday</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#byyearday">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#byyearday</seealso>
    let byyearday = Prefixed_Name(ncal, "byyearday") |> PrefixedName
    /// <summary>
    ///   <para>ncal:categories</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Categories for a calendar component. Inspired by RFC 2445 sec 4.8.1.2 with the following reservations: The LANGUAGE parameter has been discarded. Please use xml:lang literals to express multiple languages. This property can specify multiple comma-separated categories. The order of categories doesn't matter. Please use a separate triple for each category.</para>
    /// labels<para>categories</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#categories">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#categories</seealso>
    let categories = Prefixed_Name(ncal, "categories") |> PrefixedName
    /// <summary>
    ///   <para>ncal:commentAltRep</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Alternate representation of the comment. Introduced to cover
    /// the ALTREP parameter of the COMMENT property. See
    /// documentation of ncal:comment for details.</para>
    /// labels<para>commentAltRep</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#commentAltRep">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#commentAltRep</seealso>
    let commentAltRep = Prefixed_Name(ncal, "commentAltRep") |> PrefixedName

    /// <summary>
    ///   <para>ncal:completedParticipationStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:ParticipationStatus</para>
    ///
    /// labels<para>completedParticipationStatus</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#completedParticipationStatus">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#completedParticipationStatus</seealso>
    let completedParticipationStatus =
        Prefixed_Name(ncal, "completedParticipationStatus") |> PrefixedName

    /// <summary>
    ///   <para>ncal:completedStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:TodoStatus</para>
    ///
    /// labels<para>completedStatus</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#completedStatus">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#completedStatus</seealso>
    let completedStatus = Prefixed_Name(ncal, "completedStatus") |> PrefixedName

    /// <summary>
    ///   <para>ncal:confidentialClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:AccessClassification</para>
    ///
    /// labels<para>confidentialClassification</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#confidentialClassification">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#confidentialClassification</seealso>
    let confidentialClassification =
        Prefixed_Name(ncal, "confidentialClassification") |> PrefixedName

    /// <summary>
    ///   <para>ncal:confirmedStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>ncal:EventStatus</para>
    ///
    /// labels<para>confirmedStatus</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#confirmedStatus">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#confirmedStatus</seealso>
    let confirmedStatus = Prefixed_Name(ncal, "confirmedStatus") |> PrefixedName
    /// <summary>
    ///   <para>ncal:count</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>How many times should an event be repeated. Defined in RFC 2445 sec. 4.3.10</para>
    /// labels<para>count</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#count">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#count</seealso>
    let count = Prefixed_Name(ncal, "count") |> PrefixedName
    /// <summary>
    ///   <para>ncal:cutype</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>To specify the type of calendar user specified by the property. Inspired by RFC 2445 sec. 4.2.3. This parameter has a limited vocabulary. The terms that may serve as values for this property have been expressed as instances of CalendarUserType class. The user may use instances provided with this ontology or create his own.</para>
    /// labels<para>cutype</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#cutype">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#cutype</seealso>
    let cutype = Prefixed_Name(ncal, "cutype") |> PrefixedName
    /// <summary>
    ///   <para>ncal:date</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Date an instance of NcalDateTime refers to. It was conceived to express values in DATE datatype specified in RFC 2445 4.3.4</para>
    /// labels<para>date</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#date">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#date</seealso>
    let date = Prefixed_Name(ncal, "date") |> PrefixedName
    /// <summary>
    ///   <para>ncal:daylight</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Links a timezone with it's daylight observance. This property has no direct equivalent in the RFC 2445. It has been inspired by the structure of the Vtimezone component defined in sec.4.6.5</para>
    /// labels<para>daylight</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#daylight">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#daylight</seealso>
    let daylight = Prefixed_Name(ncal, "daylight") |> PrefixedName
    /// <summary>
    ///   <para>ncal:delegatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>To specify the calendar users to whom the calendar user specified by the property has delegated participation. Inspired by RFC 2445 sec. 4.2.5. Originally the value type for this parameter was CAL-ADDRESS. This has been expressed as nco:Contact to promote integration between NCAL and NCO.</para>
    /// labels<para>delegatedTo</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#delegatedTo">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#delegatedTo</seealso>
    let delegatedTo = Prefixed_Name(ncal, "delegatedTo") |> PrefixedName
    /// <summary>
    ///   <para>ncal:dir</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Specifies a reference to a directory entry associated with the calendar user specified by the property. Inspired by RFC 2445 sec. 4.2.6. Originally the data type of the value of this parameter was URI (Usually an LDAP URI). This has been expressed as rdfs:resource.</para>
    /// labels<para>dir</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#dir">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#dir</seealso>
    let dir = Prefixed_Name(ncal, "dir") |> PrefixedName
    /// <summary>
    ///   <para>ncal:dtstamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property indicates the date/time that the instance of the iCalendar object was created. Inspired by RFC 2445 sec. 4.8.7.1. Note that the RFC allows ONLY UTC values for this property.</para>
    /// labels<para>dtstamp</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#dtstamp">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#dtstamp</seealso>
    let dtstamp = Prefixed_Name(ncal, "dtstamp") |> PrefixedName

    /// <summary>
    ///   <para>ncal:AccessClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Access classification of a calendar component. Introduced to express
    /// the set of values for the ncal:class property. The user may use instances
    /// provided with this ontology or create his/her own with desired semantics.
    /// See the documentation of ncal:class for details.</para>
    /// labels<para>AccessClassification</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#AccessClassification">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#AccessClassification</seealso>
    let AccessClassification =
        Prefixed_Name(ncal, "AccessClassification") |> PrefixedName

    /// <summary>
    ///   <para>ncal:UnionOfAlarmEventTodo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>UnionOfAlarmEventTodo</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfAlarmEventTodo">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#UnionOfAlarmEventTodo</seealso>
    let UnionOfAlarmEventTodo =
        Prefixed_Name(ncal, "UnionOfAlarmEventTodo") |> PrefixedName

    /// <summary>
    ///   <para>ncal:AlarmAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Action to be performed on alarm. This class has been introduced to express the limited set of values of the ncal:action property. Please refer to the documentation of ncal:action for details.</para>
    /// labels<para>AlarmAction</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#AlarmAction">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#AlarmAction</seealso>
    let AlarmAction = Prefixed_Name(ncal, "AlarmAction") |> PrefixedName
    /// <summary>
    ///   <para>ncal:AttendeeOrOrganizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A common superclass for ncal:Attendee and ncal:Organizer.</para>
    /// labels<para>AttendeeOrOrganizer</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#AttendeeOrOrganizer">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#AttendeeOrOrganizer</seealso>
    let AttendeeOrOrganizer = Prefixed_Name(ncal, "AttendeeOrOrganizer") |> PrefixedName
    /// <summary>
    ///   <para>ncal:attachmentUri</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The uri of the attachment. Created to express the actual value of the ATTACH property defined in RFC 2445 sec. 4.8.1.1. This property expresses the default URI datatype of that property. see ncal:attachmentContents for the BINARY datatype.</para>
    /// labels<para>attachmentUri</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#attachmentUri">http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#attachmentUri</seealso>
    let attachmentUri = Prefixed_Name(ncal, "attachmentUri") |> PrefixedName
