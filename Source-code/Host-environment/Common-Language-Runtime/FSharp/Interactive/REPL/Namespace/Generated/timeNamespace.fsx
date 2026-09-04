#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module time =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3.org/2006/time#" "time"
    let _2006 = _prefixId.prefix "2006"
    let _2016 = _prefixId.prefix "2016"
    /// <summary>
    ///   <para>skos:definition : Description of date and time structured with separate values for the various elements of a calendar-clock system. The temporal reference system is fixed to Gregorian Calendar, and the range of year, month, day properties restricted to corresponding XML Schema types xsd:gYear, xsd:gMonth and xsd:gDay, respectively.</para>
    ///   <para>rdfs:label : Date-Time description</para>
    ///   <para>rdfs:comment : Description of date and time structured with separate values for the various elements of a calendar-clock system. The temporal reference system is fixed to Gregorian Calendar, and the range of year, month, day properties restricted to corresponding XML Schema types xsd:gYear, xsd:gMonth and xsd:gDay, respectively.</para>
    ///   <a href="http://www.w3.org/2006/time#DateTimeDescription">time:DateTimeDescription</a>
    /// </summary>
    let DateTimeDescription = _prefixId.prefix "DateTimeDescription"
    /// <summary>
    ///   <para>skos:note : :DateTimeInterval can only be used for an interval whose limits coincide with a date-time element aligned to the calendar and timezone indicated. For example, while both have a duration of one day, the 24-hour interval beginning at midnight at the beginning of 8 May in Central Europe can be expressed as a :DateTimeInterval, but the 24-hour interval starting at 1:30pm cannot.</para>
    ///   <para>skos:definition : DateTimeInterval is a subclass of ProperInterval, defined using the multi-element DateTimeDescription.</para>
    ///   <para>rdfs:label : Date-time interval</para>
    ///   <para>rdfs:comment : DateTimeInterval is a subclass of ProperInterval, defined using the multi-element DateTimeDescription.</para>
    ///   <a href="http://www.w3.org/2006/time#DateTimeInterval">time:DateTimeInterval</a>
    /// </summary>
    let DateTimeInterval = _prefixId.prefix "DateTimeInterval"
    /// <summary>
    ///   <para>skos:note : Membership of the class :DayOfWeek is open, to allow for alternative week lengths and different day names.</para>
    ///   <para>skos:definition : The day of week</para>
    ///   <para>skos:changeNote : Remove enumeration from definition, in order to allow other days to be used when required in other calendars.
    /// NOTE: existing days are still present as members of the class, but the class membership is now open.
    ///
    /// In the original OWL-Time the following constraint appeared:
    ///   owl:oneOf (
    ///       time:Monday
    ///       time:Tuesday
    ///       time:Wednesday
    ///       time:Thursday
    ///       time:Friday
    ///       time:Saturday
    ///       time:Sunday
    ///     ) ;</para>
    ///   <para>rdfs:label : Day of week</para>
    ///   <para>rdfs:comment : The day of week</para>
    ///   <a href="http://www.w3.org/2006/time#DayOfWeek">time:DayOfWeek</a>
    /// </summary>
    let DayOfWeek = _prefixId.prefix "DayOfWeek"
    /// <summary>
    ///   <para>skos:note : Alternative to time:DurationDescription to support description of a temporal duration other than using a calendar/clock system.</para>
    ///   <para>skos:definition : Duration of a temporal extent expressed as a number scaled by a temporal unit</para>
    ///   <para>rdfs:label : Time duration</para>
    ///   <para>rdfs:comment : Duration of a temporal extent expressed as a number scaled by a temporal unit</para>
    ///   <a href="http://www.w3.org/2006/time#Duration">time:Duration</a>
    /// </summary>
    let Duration = _prefixId.prefix "Duration"
    /// <summary>
    ///   <para>rdfs:comment : Description of temporal extent structured with separate values for the various elements of a calendar-clock system. The temporal reference system is fixed to Gregorian Calendar, and the range of each of the numeric properties is restricted to xsd:decimal</para>
    ///   <para>skos:note : In the Gregorian calendar the length of the month is not fixed. Therefore, a value like "2.5 months" cannot be exactly compared with a similar duration expressed in terms of weeks or days.</para>
    ///   <para>skos:definition : Description of temporal extent structured with separate values for the various elements of a calendar-clock system. The temporal reference system is fixed to Gregorian Calendar, and the range of each of the numeric properties is restricted to xsd:decimal</para>
    ///   <para>rdfs:label : Duration description</para>
    ///   <a href="http://www.w3.org/2006/time#DurationDescription">time:DurationDescription</a>
    /// </summary>
    let DurationDescription = _prefixId.prefix "DurationDescription"
    let Friday = _prefixId.prefix "Friday"
    /// <summary>
    ///   <para>skos:note : Some combinations of properties are redundant - for example, within a specified :year if :dayOfYear is provided then :day and :month can be computed, and vice versa. Individual values should be consistent with each other and the calendar, indicated through the value of the :hasTRS property.^^xsd:string</para>
    ///   <para>rdfs:label : Generalized date-time description</para>
    ///   <para>rdfs:comment : Description of date and time structured with separate values for the various elements of a calendar-clock system</para>
    ///   <para>skos:definition : Description of date and time structured with separate values for the various elements of a calendar-clock system</para>
    ///   <a href="http://www.w3.org/2006/time#GeneralDateTimeDescription">time:GeneralDateTimeDescription</a>
    /// </summary>
    let GeneralDateTimeDescription = _prefixId.prefix "GeneralDateTimeDescription"
    /// <summary>
    ///   <para>skos:definition : Description of temporal extent structured with separate values for the various elements of a calendar-clock system.</para>
    ///   <para>skos:note : The extent of a time duration expressed as a GeneralDurationDescription depends on the Temporal Reference System. In some calendars the length of the week or month is not constant within the year. Therefore, a value like "2.5 months" may not necessarily be exactly compared with a similar duration expressed in terms of weeks or days. When non-earth-based calendars are considered even more care must be taken in comparing durations.</para>
    ///   <para>rdfs:label : Generalized duration description</para>
    ///   <para>rdfs:comment : Description of temporal extent structured with separate values for the various elements of a calendar-clock system.</para>
    ///   <a href="http://www.w3.org/2006/time#GeneralDurationDescription">time:GeneralDurationDescription</a>
    /// </summary>
    let GeneralDurationDescription = _prefixId.prefix "GeneralDurationDescription"
    /// <summary>
    ///   <para>skos:definition : A temporal entity with zero extent or duration</para>
    ///   <para>rdfs:label : Time instant</para>
    ///   <para>rdfs:comment : A temporal entity with zero extent or duration</para>
    ///   <a href="http://www.w3.org/2006/time#Instant">time:Instant</a>
    /// </summary>
    let Instant = _prefixId.prefix "Instant"
    /// <summary>
    ///   <para>skos:definition : A temporal entity with an extent or duration</para>
    ///   <para>rdfs:label : Time interval</para>
    ///   <para>rdfs:comment : A temporal entity with an extent or duration</para>
    ///   <a href="http://www.w3.org/2006/time#Interval">time:Interval</a>
    /// </summary>
    let Interval = _prefixId.prefix "Interval"
    /// <summary>
    ///   <para>skos:historyNote : This class was present in the 2006 version of OWL-Time. It was presented as an example of how DateTimeDescription could be specialized, but does not belong in the revised ontology. ^^xsd:string</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : January^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/time#January">time:January</a>
    /// </summary>
    let January = _prefixId.prefix "January"
    let Monday = _prefixId.prefix "Monday"
    /// <summary>
    ///   <para>skos:definition : The month of the year</para>
    ///   <para>skos:note : Membership of the class :MonthOfYear is open, to allow for alternative annual calendars and different month names.</para>
    ///   <para>rdfs:label : Month of year</para>
    ///   <para>skos:editorialNote : Feature at risk - added in 2017 revision, and not yet widely used. </para>
    ///   <para>rdfs:comment : The month of the year</para>
    ///   <a href="http://www.w3.org/2006/time#MonthOfYear">time:MonthOfYear</a>
    /// </summary>
    let MonthOfYear = _prefixId.prefix "MonthOfYear"
    /// <summary>
    ///   <para>skos:definition : A temporal entity with non-zero extent or duration, i.e. for which the value of the beginning and end are different</para>
    ///   <para>rdfs:label : Proper interval</para>
    ///   <para>rdfs:comment : A temporal entity with non-zero extent or duration, i.e. for which the value of the beginning and end are different</para>
    ///   <a href="http://www.w3.org/2006/time#ProperInterval">time:ProperInterval</a>
    /// </summary>
    let ProperInterval = _prefixId.prefix "ProperInterval"
    let Saturday = _prefixId.prefix "Saturday"
    let Sunday = _prefixId.prefix "Sunday"
    /// <summary>
    ///   <para>skos:note : A taxonomy of temporal reference systems is provided in ISO 19108:2002 [ISO19108], including (a) calendar + clock systems; (b) temporal coordinate systems (i.e. numeric offset from an epoch); (c) temporal ordinal reference systems (i.e. ordered sequence of named intervals, not necessarily of equal duration).</para>
    ///   <para>skos:definition : A temporal reference system, such as a temporal coordinate system (with an origin, direction, and scale), a calendar-clock combination, or a (possibly hierarchical) ordinal system.
    ///
    /// This is a stub class, representing the set of all temporal reference systems.</para>
    ///   <para>rdfs:label : Temporal Reference System</para>
    ///   <para>rdfs:comment : A temporal reference system, such as a temporal coordinate system (with an origin, direction, and scale), a calendar-clock combination, or a (possibly hierarchical) ordinal system.
    ///
    /// This is a stub class, representing the set of all temporal reference systems.</para>
    ///   <a href="http://www.w3.org/2006/time#TRS">time:TRS</a>
    /// </summary>
    let TRS = _prefixId.prefix "TRS"
    /// <summary>
    ///   <para>skos:definition : Time extent; duration of a time interval separate from its particular start position</para>
    ///   <para>rdfs:label : Temporal duration</para>
    ///   <para>rdfs:comment : Time extent; duration of a time interval separate from its particular start position</para>
    ///   <a href="http://www.w3.org/2006/time#TemporalDuration">time:TemporalDuration</a>
    /// </summary>
    let TemporalDuration = _prefixId.prefix "TemporalDuration"
    /// <summary>
    ///   <para>skos:definition : A temporal interval or instant.</para>
    ///   <para>rdfs:label : Temporal entity</para>
    ///   <para>rdfs:comment : A temporal interval or instant.</para>
    ///   <a href="http://www.w3.org/2006/time#TemporalEntity">time:TemporalEntity</a>
    /// </summary>
    let TemporalEntity = _prefixId.prefix "TemporalEntity"
    /// <summary>
    ///   <para>skos:definition : A position on a time-line</para>
    ///   <para>rdfs:label : Temporal position</para>
    ///   <para>rdfs:comment : A position on a time-line</para>
    ///   <a href="http://www.w3.org/2006/time#TemporalPosition">time:TemporalPosition</a>
    /// </summary>
    let TemporalPosition = _prefixId.prefix "TemporalPosition"
    /// <summary>
    ///   <para>skos:note : Membership of the class TemporalUnit is open, to allow for other temporal units used in some technical applications (e.g. millions of years, Baha'i month).</para>
    ///   <para>skos:definition : A standard duration, which provides a scale factor for a time extent, or the granularity or precision for a time position.</para>
    ///   <para>skos:changeNote : Remove enumeration from definition, in order to allow other units to be used when required in other coordinate systems.
    /// NOTE: existing units are still present as members of the class, but the class membership is now open.
    ///
    /// In the original OWL-Time the following constraint appeared:
    ///   owl:oneOf (
    ///       time:unitSecond
    ///       time:unitMinute
    ///       time:unitHour
    ///       time:unitDay
    ///       time:unitWeek
    ///       time:unitMonth
    ///       time:unitYear
    ///     ) ;</para>
    ///   <para>rdfs:label : Temporal unit</para>
    ///   <para>rdfs:comment : A standard duration, which provides a scale factor for a time extent, or the granularity or precision for a time position.</para>
    ///   <a href="http://www.w3.org/2006/time#TemporalUnit">time:TemporalUnit</a>
    /// </summary>
    let TemporalUnit = _prefixId.prefix "TemporalUnit"
    let Thursday = _prefixId.prefix "Thursday"
    /// <summary>
    ///   <para>skos:definition : A temporal position described using either a (nominal) value from an ordinal reference system, or a (numeric) value in a temporal coordinate system. </para>
    ///   <para>rdfs:label : Time position</para>
    ///   <para>rdfs:comment : A temporal position described using either a (nominal) value from an ordinal reference system, or a (numeric) value in a temporal coordinate system. </para>
    ///   <a href="http://www.w3.org/2006/time#TimePosition">time:TimePosition</a>
    /// </summary>
    let TimePosition = _prefixId.prefix "TimePosition"
    /// <summary>
    ///   <para>skos:scopeNote : In this implementation TimeZone has no properties defined. It should be thought of as an 'abstract' superclass of all specific timezone implementations.^^xsd:string</para>
    ///   <para>skos:note : An ontology for time zone descriptions was described in [owl-time-20060927] and provided as RDF in a separate namespace tzont:. However, that ontology was incomplete in scope, and the example datasets were selective. Furthermore, since the use of a class from an external ontology as the range of an ObjectProperty in OWL-Time creates a dependency, reference to the time zone class has been replaced with the 'stub' class in the normative part of this version of OWL-Time.skos:note : A designated timezone is associated with a geographic region. However, for a particular region the offset from UTC often varies seasonally, and the dates of the changes may vary from year to year. The timezone designation usually changes for the different seasons (e.g. Australian Eastern Standard Time vs. Australian Eastern Daylight Time). Furthermore, the offset for a timezone may change over longer timescales, though its designation might not.
    ///
    /// Detailed guidance about working with time zones is given in http://www.w3.org/TR/timezone/ .</para>
    ///   <para>skos:historyNote : In the original 2006 version of OWL-Time, the TimeZone class, with several properties corresponding to a specific model of time-zones, was defined in a separate namespace "http://www.w3.org/2006/timezone#".
    ///
    /// In the current version a class with same local name is put into the main OWL-Time namespace, removing the dependency on the external namespace.
    ///
    /// An alignment axiom
    /// 	tzont:TimeZone rdfs:subClassOf time:TimeZone .
    /// allows data encoded according to the previous version to be consistent with the updated ontology. ^^xsd:string</para>
    ///   <para>skos:definition : A Time Zone specifies the amount by which the local time is offset from UTC.
    /// 	A time zone is usually denoted geographically (e.g. Australian Eastern Daylight Time), with a constant value in a given region.
    /// The region where it applies and the offset from UTC are specified by a locally recognised governing authority.</para>
    ///   <para>rdfs:label : Time Zone</para>
    ///   <para>rdfs:comment : A Time Zone specifies the amount by which the local time is offset from UTC.
    /// 	A time zone is usually denoted geographically (e.g. Australian Eastern Daylight Time), with a constant value in a given region.
    /// The region where it applies and the offset from UTC are specified by a locally recognised governing authority.</para>
    ///   <a href="http://www.w3.org/2006/time#TimeZone">time:TimeZone</a>
    /// </summary>
    let TimeZone = _prefixId.prefix "TimeZone"
    let Tuesday = _prefixId.prefix "Tuesday"
    let Wednesday = _prefixId.prefix "Wednesday"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>skos:prefLabel : Annoskos:prefLabel : سنةskos:prefLabel : Rokskos:prefLabel : Jaarskos:prefLabel : Añoskos:prefLabel : Jahrskos:prefLabel : Année (calendrier)skos:prefLabel : Yearskos:prefLabel : 年skos:prefLabel : Годskos:prefLabel : 年skos:prefLabel : Ano</para>
    ///   <para>skos:historyNote : Year was proposed in the 2006 version of OWL-Time as an example of how DurationDescription could be specialized to allow for a duration to be restricted to a number of years.
    ///
    /// It is deprecated in this edition of OWL-Time. ^^xsd:string</para>
    ///   <para>rdfs:label : Year</para>
    ///   <para>skos:definition : Year duration^^xsd:string</para>
    ///   <para>rdfs:comment : Year duration^^xsd:string</para>
    ///   <a href="http://www.w3.org/2006/time#Year">time:Year</a>
    /// </summary>
    let Year = _prefixId.prefix "Year"
    /// <summary>
    ///   <para>skos:definition : Gives directionality to time. If a temporal entity T1 is after another temporal entity T2, then the beginning of T1 is after the end of T2.</para>
    ///   <para>rdfs:label : after</para>
    ///   <para>rdfs:comment : Gives directionality to time. If a temporal entity T1 is after another temporal entity T2, then the beginning of T1 is after the end of T2.</para>
    ///   <a href="http://www.w3.org/2006/time#after">time:after</a>
    /// </summary>
    let after = _prefixId.prefix "after"
    /// <summary>
    ///   <para>skos:definition : Gives directionality to time. If a temporal entity T1 is before another temporal entity T2, then the end of T1 is before the beginning of T2. Thus, "before" can be considered to be basic to instants and derived for intervals.</para>
    ///   <para>rdfs:label : before</para>
    ///   <para>rdfs:comment : Gives directionality to time. If a temporal entity T1 is before another temporal entity T2, then the end of T1 is before the beginning of T2. Thus, "before" can be considered to be basic to instants and derived for intervals.</para>
    ///   <a href="http://www.w3.org/2006/time#before">time:before</a>
    /// </summary>
    let before = _prefixId.prefix "before"
    /// <summary>
    ///   <para>skos:definition : Day position in a calendar-clock system.
    ///
    /// The range of this property is not specified, so can be replaced by any specific representation of a calendar day from any calendar. </para>
    ///   <para>rdfs:label : day</para>
    ///   <para>rdfs:comment : Day position in a calendar-clock system.
    ///
    /// The range of this property is not specified, so can be replaced by any specific representation of a calendar day from any calendar. </para>
    ///   <a href="http://www.w3.org/2006/time#day">time:day</a>
    /// </summary>
    let day = _prefixId.prefix "day"
    /// <summary>
    ///   <para>skos:definition : The day of week, whose value is a member of the class time:DayOfWeek</para>
    ///   <para>rdfs:label : day of week</para>
    ///   <para>rdfs:comment : The day of week, whose value is a member of the class time:DayOfWeek</para>
    ///   <a href="http://www.w3.org/2006/time#dayOfWeek">time:dayOfWeek</a>
    /// </summary>
    let dayOfWeek = _prefixId.prefix "dayOfWeek"
    /// <summary>
    ///   <para>skos:definition : The number of the day within the year</para>
    ///   <para>rdfs:label : day of year</para>
    ///   <para>rdfs:comment : The number of the day within the year</para>
    ///   <a href="http://www.w3.org/2006/time#dayOfYear">time:dayOfYear</a>
    /// </summary>
    let dayOfYear = _prefixId.prefix "dayOfYear"
    /// <summary>
    ///   <para>skos:definition : length of, or element of the length of, a temporal extent expressed in days</para>
    ///   <para>rdfs:label : days duration</para>
    ///   <para>rdfs:comment : length of, or element of the length of, a temporal extent expressed in days</para>
    ///   <a href="http://www.w3.org/2006/time#days">time:days</a>
    /// </summary>
    let days = _prefixId.prefix "days"
    let generalDay = _prefixId.prefix "generalDay"
    let generalMonth = _prefixId.prefix "generalMonth"
    let generalYear = _prefixId.prefix "generalYear"
    /// <summary>
    ///   <para>skos:definition : Beginning of a temporal entity.</para>
    ///   <para>rdfs:label : has beginning</para>
    ///   <para>rdfs:comment : Beginning of a temporal entity</para>
    ///   <a href="http://www.w3.org/2006/time#hasBeginning">time:hasBeginning</a>
    /// </summary>
    let hasBeginning = _prefixId.prefix "hasBeginning"
    /// <summary>
    ///   <para>skos:definition : Value of DateTimeInterval expressed as a structured value. The beginning and end of the interval coincide with the limits of the shortest element in the description.</para>
    ///   <para>rdfs:label : has Date-Time description</para>
    ///   <para>rdfs:comment : Value of DateTimeInterval expressed as a structured value. The beginning and end of the interval coincide with the limits of the shortest element in the description.</para>
    ///   <a href="http://www.w3.org/2006/time#hasDateTimeDescription">time:hasDateTimeDescription</a>
    /// </summary>
    let hasDateTimeDescription = _prefixId.prefix "hasDateTimeDescription"
    /// <summary>
    ///   <para>skos:definition : Duration of a temporal entity, event or activity, or thing, expressed as a scaled value</para>
    ///   <para>rdfs:label : has duration</para>
    ///   <para>rdfs:comment : Duration of a temporal entity, expressed as a scaled value or nominal value</para>
    ///   <a href="http://www.w3.org/2006/time#hasDuration">time:hasDuration</a>
    /// </summary>
    let hasDuration = _prefixId.prefix "hasDuration"
    /// <summary>
    ///   <para>skos:definition : Duration of a temporal entity, expressed using a structured description</para>
    ///   <para>rdfs:label : has duration description</para>
    ///   <para>rdfs:comment : Duration of a temporal entity, expressed using a structured description</para>
    ///   <a href="http://www.w3.org/2006/time#hasDurationDescription">time:hasDurationDescription</a>
    /// </summary>
    let hasDurationDescription = _prefixId.prefix "hasDurationDescription"
    /// <summary>
    ///   <para>skos:definition : End of a temporal entity.</para>
    ///   <para>rdfs:label : has end</para>
    ///   <para>rdfs:comment : End of a temporal entity.</para>
    ///   <a href="http://www.w3.org/2006/time#hasEnd">time:hasEnd</a>
    /// </summary>
    let hasEnd = _prefixId.prefix "hasEnd"
    /// <summary>
    ///   <para>skos:definition : The temporal reference system used by a temporal position or extent description. </para>
    ///   <para>rdfs:label : Temporal reference system used</para>
    ///   <para>rdfs:comment : The temporal reference system used by a temporal position or extent description. </para>
    ///   <a href="http://www.w3.org/2006/time#hasTRS">time:hasTRS</a>
    /// </summary>
    let hasTRS = _prefixId.prefix "hasTRS"
    /// <summary>
    ///   <para>skos:definition : Duration of a temporal entity.</para>
    ///   <para>rdfs:label : has temporal duration</para>
    ///   <para>rdfs:comment : Duration of a temporal entity.</para>
    ///   <a href="http://www.w3.org/2006/time#hasTemporalDuration">time:hasTemporalDuration</a>
    /// </summary>
    let hasTemporalDuration = _prefixId.prefix "hasTemporalDuration"
    /// <summary>
    ///   <para>skos:editorialNote : Feature at risk - added in 2017 revision, and not yet widely used. </para>
    ///   <para>skos:definition : Supports the association of a temporal entity (instant or interval) to any thing</para>
    ///   <para>rdfs:label : has time</para>
    ///   <para>rdfs:comment : Supports the association of a temporal entity (instant or interval) to any thing</para>
    ///   <a href="http://www.w3.org/2006/time#hasTime">time:hasTime</a>
    /// </summary>
    let hasTime = _prefixId.prefix "hasTime"
    /// <summary>
    ///   <para>skos:editorialNote : Feature at risk - added in 2017 revision, and not yet widely used. </para>
    ///   <para>skos:definition : Extent of a temporal entity, expressed using xsd:duration</para>
    ///   <para>rdfs:label : has XSD duration</para>
    ///   <para>rdfs:comment : Extent of a temporal entity, expressed using xsd:duration</para>
    ///   <a href="http://www.w3.org/2006/time#hasXSDDuration">time:hasXSDDuration</a>
    /// </summary>
    let hasXSDDuration = _prefixId.prefix "hasXSDDuration"
    /// <summary>
    ///   <para>skos:definition : Hour position in a calendar-clock system.</para>
    ///   <para>rdfs:label : hour</para>
    ///   <para>rdfs:comment : Hour position in a calendar-clock system.</para>
    ///   <a href="http://www.w3.org/2006/time#hour">time:hour</a>
    /// </summary>
    let hour = _prefixId.prefix "hour"
    /// <summary>
    ///   <para>skos:definition : length of, or element of the length of, a temporal extent expressed in hours</para>
    ///   <para>rdfs:label : hours duration</para>
    ///   <para>rdfs:comment : length of, or element of the length of, a temporal extent expressed in hours</para>
    ///   <a href="http://www.w3.org/2006/time#hours">time:hours</a>
    /// </summary>
    let hours = _prefixId.prefix "hours"
    /// <summary>
    ///   <para>skos:definition : Position of an instant, expressed using a structured description</para>
    ///   <para>rdfs:label : in date-time description</para>
    ///   <para>rdfs:comment : Position of an instant, expressed using a structured description</para>
    ///   <a href="http://www.w3.org/2006/time#inDateTime">time:inDateTime</a>
    /// </summary>
    let inDateTime = _prefixId.prefix "inDateTime"
    /// <summary>
    ///   <para>skos:definition : Position of a time instant</para>
    ///   <para>rdfs:label : Temporal position</para>
    ///   <para>rdfs:comment : Position of a time instant</para>
    ///   <a href="http://www.w3.org/2006/time#inTemporalPosition">time:inTemporalPosition</a>
    /// </summary>
    let inTemporalPosition = _prefixId.prefix "inTemporalPosition"
    /// <summary>
    ///   <para>skos:definition : Position of a time instant expressed as a TimePosition</para>
    ///   <para>rdfs:label : Time position</para>
    ///   <para>rdfs:comment : Position of an instant, expressed as a temporal coordinate or nominal value</para>
    ///   <a href="http://www.w3.org/2006/time#inTimePosition">time:inTimePosition</a>
    /// </summary>
    let inTimePosition = _prefixId.prefix "inTimePosition"
    /// <summary>
    ///   <para>skos:definition : Position of an instant, expressed using xsd:date</para>
    ///   <para>rdfs:label : in XSD date</para>
    ///   <para>rdfs:comment : Position of an instant, expressed using xsd:date</para>
    ///   <a href="http://www.w3.org/2006/time#inXSDDate">time:inXSDDate</a>
    /// </summary>
    let inXSDDate = _prefixId.prefix "inXSDDate"
    /// <summary>
    ///   <para>skos:note : The property :inXSDDateTime is replaced by :inXSDDateTimeStamp which makes the time-zone field mandatory.</para>
    ///   <para>skos:definition : Position of an instant, expressed using xsd:dateTime</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : in XSD Date-Time</para>
    ///   <para>rdfs:comment : Position of an instant, expressed using xsd:dateTime</para>
    ///   <a href="http://www.w3.org/2006/time#inXSDDateTime">time:inXSDDateTime</a>
    /// </summary>
    let inXSDDateTime = _prefixId.prefix "inXSDDateTime"
    /// <summary>
    ///   <para>skos:definition : Position of an instant, expressed using xsd:dateTimeStamp</para>
    ///   <para>rdfs:label : in XSD Date-Time-Stamp</para>
    ///   <para>rdfs:comment : Position of an instant, expressed using xsd:dateTimeStamp</para>
    ///   <a href="http://www.w3.org/2006/time#inXSDDateTimeStamp">time:inXSDDateTimeStamp</a>
    /// </summary>
    let inXSDDateTimeStamp = _prefixId.prefix "inXSDDateTimeStamp"
    /// <summary>
    ///   <para>skos:definition : Position of an instant, expressed using xsd:gYear</para>
    ///   <para>rdfs:label : in XSD g-Year</para>
    ///   <para>rdfs:comment : Position of an instant, expressed using xsd:gYear</para>
    ///   <a href="http://www.w3.org/2006/time#inXSDgYear">time:inXSDgYear</a>
    /// </summary>
    let inXSDgYear = _prefixId.prefix "inXSDgYear"
    /// <summary>
    ///   <para>skos:definition : Position of an instant, expressed using xsd:gYearMonth</para>
    ///   <para>rdfs:label : in XSD g-YearMonth</para>
    ///   <para>rdfs:comment : Position of an instant, expressed using xsd:gYearMonth</para>
    ///   <a href="http://www.w3.org/2006/time#inXSDgYearMonth">time:inXSDgYearMonth</a>
    /// </summary>
    let inXSDgYearMonth = _prefixId.prefix "inXSDgYearMonth"
    /// <summary>
    ///   <para>skos:definition : An instant that falls inside the interval. It is not intended to include beginnings and ends of intervals.</para>
    ///   <para>rdfs:label : has time instant inside</para>
    ///   <para>rdfs:comment : An instant that falls inside the interval. It is not intended to include beginnings and ends of intervals.</para>
    ///   <a href="http://www.w3.org/2006/time#inside">time:inside</a>
    /// </summary>
    let inside = _prefixId.prefix "inside"
    /// <summary>
    ///   <para>skos:definition : If a proper interval T1 is intervalAfter another proper interval T2, then the beginning of T1 is after the end of T2.</para>
    ///   <para>rdfs:label : interval after</para>
    ///   <para>rdfs:comment : If a proper interval T1 is intervalAfter another proper interval T2, then the beginning of T1 is after the end of T2.</para>
    ///   <a href="http://www.w3.org/2006/time#intervalAfter">time:intervalAfter</a>
    /// </summary>
    let intervalAfter = _prefixId.prefix "intervalAfter"
    /// <summary>
    ///   <para>skos:definition : If a proper interval T1 is intervalBefore another proper interval T2, then the end of T1 is before the beginning of T2.</para>
    ///   <para>rdfs:label : interval before</para>
    ///   <para>rdfs:comment : If a proper interval T1 is intervalBefore another proper interval T2, then the end of T1 is before the beginning of T2.</para>
    ///   <a href="http://www.w3.org/2006/time#intervalBefore">time:intervalBefore</a>
    /// </summary>
    let intervalBefore = _prefixId.prefix "intervalBefore"
    /// <summary>
    ///   <para>skos:definition : If a proper interval T1 is intervalContains another proper interval T2, then the beginning of T1 is before the beginning of T2, and the end of T1 is after the end of T2.</para>
    ///   <para>rdfs:label : interval contains</para>
    ///   <para>rdfs:comment : If a proper interval T1 is intervalContains another proper interval T2, then the beginning of T1 is before the beginning of T2, and the end of T1 is after the end of T2.</para>
    ///   <a href="http://www.w3.org/2006/time#intervalContains">time:intervalContains</a>
    /// </summary>
    let intervalContains = _prefixId.prefix "intervalContains"
    /// <summary>
    ///   <para>skos:note : This interval relation is not included in the 13 basic relationships defined in Allen (1984), but is defined in (T.3) as the union of :intervalDuring v :intervalStarts v :intervalFinishes</para>
    ///   <para>skos:definition : If a proper interval T1 is intervalDisjoint another proper interval T2, then the beginning of T1 is after the end of T2, or the end of T1 is before the beginning of T2, i.e. the intervals do not overlap in any way, but their ordering relationship is not known.</para>
    ///   <para>rdfs:label : interval disjoint</para>
    ///   <para>rdfs:comment : If a proper interval T1 is intervalDisjoint another proper interval T2, then the beginning of T1 is after the end of T2, or the end of T1 is before the beginning of T2, i.e. the intervals do not overlap in any way, but their ordering relationship is not known.</para>
    ///   <a href="http://www.w3.org/2006/time#intervalDisjoint">time:intervalDisjoint</a>
    /// </summary>
    let intervalDisjoint = _prefixId.prefix "intervalDisjoint"
    /// <summary>
    ///   <para>skos:definition : If a proper interval T1 is intervalDuring another proper interval T2, then the beginning of T1 is after the beginning of T2, and the end of T1 is before the end of T2.</para>
    ///   <para>rdfs:label : interval during</para>
    ///   <para>rdfs:comment : If a proper interval T1 is intervalDuring another proper interval T2, then the beginning of T1 is after the beginning of T2, and the end of T1 is before the end of T2.</para>
    ///   <a href="http://www.w3.org/2006/time#intervalDuring">time:intervalDuring</a>
    /// </summary>
    let intervalDuring = _prefixId.prefix "intervalDuring"
    /// <summary>
    ///   <para>skos:definition : If a proper interval T1 is intervalEquals another proper interval T2, then the beginning of T1 is coincident with the beginning of T2, and the end of T1 is coincident with the end of T2.</para>
    ///   <para>rdfs:label : interval equals</para>
    ///   <para>rdfs:comment : If a proper interval T1 is intervalEquals another proper interval T2, then the beginning of T1 is coincident with the beginning of T2, and the end of T1 is coincident with the end of T2.</para>
    ///   <a href="http://www.w3.org/2006/time#intervalEquals">time:intervalEquals</a>
    /// </summary>
    let intervalEquals = _prefixId.prefix "intervalEquals"
    /// <summary>
    ///   <para>skos:definition : If a proper interval T1 is intervalFinishedBy another proper interval T2, then the beginning of T1 is before the beginning of T2, and the end of T1 is coincident with the end of T2.</para>
    ///   <para>rdfs:label : interval finished by</para>
    ///   <para>rdfs:comment : If a proper interval T1 is intervalFinishedBy another proper interval T2, then the beginning of T1 is before the beginning of T2, and the end of T1 is coincident with the end of T2.</para>
    ///   <a href="http://www.w3.org/2006/time#intervalFinishedBy">time:intervalFinishedBy</a>
    /// </summary>
    let intervalFinishedBy = _prefixId.prefix "intervalFinishedBy"
    /// <summary>
    ///   <para>skos:definition : If a proper interval T1 is intervalFinishes another proper interval T2, then the beginning of T1 is after the beginning of T2, and the end of T1 is coincident with the end of T2.</para>
    ///   <para>rdfs:label : interval finishes</para>
    ///   <para>rdfs:comment : If a proper interval T1 is intervalFinishes another proper interval T2, then the beginning of T1 is after the beginning of T2, and the end of T1 is coincident with the end of T2.</para>
    ///   <a href="http://www.w3.org/2006/time#intervalFinishes">time:intervalFinishes</a>
    /// </summary>
    let intervalFinishes = _prefixId.prefix "intervalFinishes"
    /// <summary>
    ///   <para>skos:note : This interval relation is not included in the 13 basic relationships defined in Allen (1984), but is referred to as 'an important relationship' in Allen and Ferguson (1997). It is the disjoint union of :intervalStarts v :intervalDuring v :intervalFinishes</para>
    ///   <para>skos:definition : If a proper interval T1 is intervalIn another proper interval T2, then the beginning of T1 is after the beginning of T2 or is coincident with the beginning of T2, and the end of T1 is before the end of T2, or is coincident with the end of T2, except that end of T1 may not be coincident with the end of T2 if the beginning of T1 is coincident with the beginning of T2.</para>
    ///   <para>rdfs:label : interval in</para>
    ///   <para>rdfs:comment : If a proper interval T1 is intervalIn another proper interval T2, then the beginning of T1 is after the beginning of T2 or is coincident with the beginning of T2, and the end of T1 is before the end of T2, or is coincident with the end of T2, except that end of T1 may not be coincident with the end of T2 if the beginning of T1 is coincident with the beginning of T2.</para>
    ///   <a href="http://www.w3.org/2006/time#intervalIn">time:intervalIn</a>
    /// </summary>
    let intervalIn = _prefixId.prefix "intervalIn"
    /// <summary>
    ///   <para>skos:definition : If a proper interval T1 is intervalMeets another proper interval T2, then the end of T1 is coincident with the beginning of T2.</para>
    ///   <para>rdfs:label : interval meets</para>
    ///   <para>rdfs:comment : If a proper interval T1 is intervalMeets another proper interval T2, then the end of T1 is coincident with the beginning of T2.</para>
    ///   <a href="http://www.w3.org/2006/time#intervalMeets">time:intervalMeets</a>
    /// </summary>
    let intervalMeets = _prefixId.prefix "intervalMeets"
    /// <summary>
    ///   <para>skos:definition : If a proper interval T1 is intervalMetBy another proper interval T2, then the beginning of T1 is coincident with the end of T2.</para>
    ///   <para>rdfs:label : interval met by</para>
    ///   <para>rdfs:comment : If a proper interval T1 is intervalMetBy another proper interval T2, then the beginning of T1 is coincident with the end of T2.</para>
    ///   <a href="http://www.w3.org/2006/time#intervalMetBy">time:intervalMetBy</a>
    /// </summary>
    let intervalMetBy = _prefixId.prefix "intervalMetBy"
    /// <summary>
    ///   <para>skos:definition : If a proper interval T1 is intervalOverlappedBy another proper interval T2, then the beginning of T1 is after the beginning of T2, the beginning of T1 is before the end of T2, and the end of T1 is after the end of T2.</para>
    ///   <para>rdfs:label : interval overlapped by</para>
    ///   <para>rdfs:comment : If a proper interval T1 is intervalOverlappedBy another proper interval T2, then the beginning of T1 is after the beginning of T2, the beginning of T1 is before the end of T2, and the end of T1 is after the end of T2.</para>
    ///   <a href="http://www.w3.org/2006/time#intervalOverlappedBy">time:intervalOverlappedBy</a>
    /// </summary>
    let intervalOverlappedBy = _prefixId.prefix "intervalOverlappedBy"
    /// <summary>
    ///   <para>skos:definition : If a proper interval T1 is intervalOverlaps another proper interval T2, then the beginning of T1 is before the beginning of T2, the end of T1 is after the beginning of T2, and the end of T1 is before the end of T2.</para>
    ///   <para>rdfs:label : interval overlaps</para>
    ///   <para>rdfs:comment : If a proper interval T1 is intervalOverlaps another proper interval T2, then the beginning of T1 is before the beginning of T2, the end of T1 is after the beginning of T2, and the end of T1 is before the end of T2.</para>
    ///   <a href="http://www.w3.org/2006/time#intervalOverlaps">time:intervalOverlaps</a>
    /// </summary>
    let intervalOverlaps = _prefixId.prefix "intervalOverlaps"
    /// <summary>
    ///   <para>skos:definition : If a proper interval T1 is intervalStarted another proper interval T2, then the beginning of T1 is coincident with the beginning of T2, and the end of T1 is after the end of T2.</para>
    ///   <para>rdfs:label : interval started by</para>
    ///   <para>rdfs:comment : If a proper interval T1 is intervalStarted another proper interval T2, then the beginning of T1 is coincident with the beginning of T2, and the end of T1 is after the end of T2.</para>
    ///   <a href="http://www.w3.org/2006/time#intervalStartedBy">time:intervalStartedBy</a>
    /// </summary>
    let intervalStartedBy = _prefixId.prefix "intervalStartedBy"
    /// <summary>
    ///   <para>skos:definition : If a proper interval T1 is intervalStarts another proper interval T2, then the beginning of T1 is coincident with the beginning of T2, and the end of T1 is before the end of T2.</para>
    ///   <para>rdfs:label : interval starts</para>
    ///   <para>rdfs:comment : If a proper interval T1 is intervalStarts another proper interval T2, then the beginning of T1 is coincident with the beginning of T2, and the end of T1 is before the end of T2.</para>
    ///   <a href="http://www.w3.org/2006/time#intervalStarts">time:intervalStarts</a>
    /// </summary>
    let intervalStarts = _prefixId.prefix "intervalStarts"
    /// <summary>
    ///   <para>skos:definition : Minute position in a calendar-clock system.</para>
    ///   <para>rdfs:label : minute</para>
    ///   <para>rdfs:comment : Minute position in a calendar-clock system.</para>
    ///   <a href="http://www.w3.org/2006/time#minute">time:minute</a>
    /// </summary>
    let minute = _prefixId.prefix "minute"
    /// <summary>
    ///   <para>skos:definition : length, or element of, a temporal extent expressed in minutes</para>
    ///   <para>rdfs:label : minutes</para>
    ///   <para>rdfs:comment : length, or element of, a temporal extent expressed in minutes</para>
    ///   <a href="http://www.w3.org/2006/time#minutes">time:minutes</a>
    /// </summary>
    let minutes = _prefixId.prefix "minutes"
    /// <summary>
    ///   <para>skos:definition : Month position in a calendar-clock system.
    ///
    /// The range of this property is not specified, so can be replaced by any specific representation of a calendar month from any calendar. </para>
    ///   <para>rdfs:label : month</para>
    ///   <para>rdfs:comment : Month position in a calendar-clock system.
    ///
    /// The range of this property is not specified, so can be replaced by any specific representation of a calendar month from any calendar. </para>
    ///   <a href="http://www.w3.org/2006/time#month">time:month</a>
    /// </summary>
    let month = _prefixId.prefix "month"
    /// <summary>
    ///   <para>skos:editorialNote : Feature at risk - added in 2017 revision, and not yet widely used. </para>
    ///   <para>skos:definition : The month of the year, whose value is a member of the class time:MonthOfYear</para>
    ///   <para>rdfs:label : month of year</para>
    ///   <para>rdfs:comment : The month of the year, whose value is a member of the class time:MonthOfYear</para>
    ///   <a href="http://www.w3.org/2006/time#monthOfYear">time:monthOfYear</a>
    /// </summary>
    let monthOfYear = _prefixId.prefix "monthOfYear"
    /// <summary>
    ///   <para>skos:definition : length of, or element of the length of, a temporal extent expressed in months</para>
    ///   <para>rdfs:label : months duration</para>
    ///   <para>rdfs:comment : length of, or element of the length of, a temporal extent expressed in months</para>
    ///   <a href="http://www.w3.org/2006/time#months">time:months</a>
    /// </summary>
    let months = _prefixId.prefix "months"
    /// <summary>
    ///   <para>skos:definition : The (nominal) value indicating temporal position in an ordinal reference system </para>
    ///   <para>rdfs:label : Name of temporal position</para>
    ///   <para>rdfs:comment : The (nominal) value indicating temporal position in an ordinal reference system </para>
    ///   <a href="http://www.w3.org/2006/time#nominalPosition">time:nominalPosition</a>
    /// </summary>
    let nominalPosition = _prefixId.prefix "nominalPosition"
    /// <summary>
    ///   <para>skos:definition : Value of a temporal extent expressed as a decimal number scaled by a temporal unit</para>
    ///   <para>rdfs:label : Numeric value of temporal duration</para>
    ///   <para>rdfs:comment : Value of a temporal extent expressed as a decimal number scaled by a temporal unit</para>
    ///   <a href="http://www.w3.org/2006/time#numericDuration">time:numericDuration</a>
    /// </summary>
    let numericDuration = _prefixId.prefix "numericDuration"
    /// <summary>
    ///   <para>skos:definition : The (numeric) value indicating position within a temporal coordinate system </para>
    ///   <para>rdfs:label : Numeric value of temporal position</para>
    ///   <para>rdfs:comment : The (numeric) value indicating position within a temporal coordinate system </para>
    ///   <a href="http://www.w3.org/2006/time#numericPosition">time:numericPosition</a>
    /// </summary>
    let numericPosition = _prefixId.prefix "numericPosition"
    /// <summary>
    ///   <para>rdfs:label : second</para>
    ///   <para>rdfs:comment : Second position in a calendar-clock system.</para>
    ///   <a href="http://www.w3.org/2006/time#second">time:second</a>
    /// </summary>
    let second = _prefixId.prefix "second"
    /// <summary>
    ///   <para>rdfs:label : seconds duration</para>
    ///   <para>rdfs:comment : length of, or element of the length of, a temporal extent expressed in seconds</para>
    ///   <a href="http://www.w3.org/2006/time#seconds">time:seconds</a>
    /// </summary>
    let seconds = _prefixId.prefix "seconds"
    /// <summary>
    ///   <para>skos:note : IANA maintains a database of timezones. These are well maintained and generally considered authoritative, but individual items are not available at individual URIs, so cannot be used directly in data expressed using OWL-Time.
    ///
    /// DBPedia provides a set of resources corresponding to the IANA timezones, with a URI for each (e.g. http://dbpedia.org/resource/Australia/Eucla). The World Clock service also provides a list of time zones with the description of each available as an individual webpage with a convenient individual URI (e.g. https://www.timeanddate.com/time/zones/acwst). These or other, similar, resources might be used as a value of the time:timeZone property.^^xsd:string</para>
    ///   <para>skos:historyNote : In the original 2006 version of OWL-Time, the range of time:timeZone was a TimeZone class in a separate namespace "http://www.w3.org/2006/timezone#".
    /// An alignment axiom
    /// 	tzont:TimeZone rdfs:subClassOf time:TimeZone .
    /// allows data encoded according to the previous version to be consistent with the updated ontology. ^^xsd:string</para>
    ///   <para>rdfs:label : in time zone</para>
    ///   <para>rdfs:comment : The time zone for clock elements in the temporal position</para>
    ///   <a href="http://www.w3.org/2006/time#timeZone">time:timeZone</a>
    /// </summary>
    let timeZone = _prefixId.prefix "timeZone"
    let unitDay = _prefixId.prefix "unitDay"
    let unitHour = _prefixId.prefix "unitHour"
    let unitMinute = _prefixId.prefix "unitMinute"
    let unitMonth = _prefixId.prefix "unitMonth"
    let unitSecond = _prefixId.prefix "unitSecond"
    /// <summary>
    ///   <para>rdfs:label : temporal unit type</para>
    ///   <para>rdfs:comment : The temporal unit which provides the precision of a date-time value or scale of a temporal extent</para>
    ///   <a href="http://www.w3.org/2006/time#unitType">time:unitType</a>
    /// </summary>
    let unitType = _prefixId.prefix "unitType"
    let unitWeek = _prefixId.prefix "unitWeek"
    let unitYear = _prefixId.prefix "unitYear"
    /// <summary>
    ///   <para>skos:note : Weeks are numbered differently depending on the calendar in use and the local language or cultural conventions (locale). ISO-8601 specifies that the first week of the year includes at least four days, and that Monday is the first day of the week. In that system, week 1 is the week that contains the first Thursday in the year.</para>
    ///   <para>rdfs:label : week</para>
    ///   <para>rdfs:comment : Week number within the year.</para>
    ///   <a href="http://www.w3.org/2006/time#week">time:week</a>
    /// </summary>
    let week = _prefixId.prefix "week"
    /// <summary>
    ///   <para>rdfs:label : weeks duration</para>
    ///   <para>rdfs:comment : length of, or element of the length of, a temporal extent expressed in weeks</para>
    ///   <a href="http://www.w3.org/2006/time#weeks">time:weeks</a>
    /// </summary>
    let weeks = _prefixId.prefix "weeks"
    /// <summary>
    ///   <para>skos:note : Using xsd:dateTime in this place means that the duration of the interval is implicit: it corresponds to the length of the smallest non-zero element of the date-time literal. However, this rule cannot be used for intervals whose duration is more than one rank smaller than the starting time - e.g. the first minute or second of a day, the first hour of a month, or the first day of a year. In these cases the desired interval cannot be distinguished from the interval corresponding to the next rank up. Because of this essential ambiguity, use of this property is not recommended and it is deprecated.</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : has XSD date-time</para>
    ///   <para>rdfs:comment : Value of DateTimeInterval expressed as a compact value.</para>
    ///   <a href="http://www.w3.org/2006/time#xsdDateTime">time:xsdDateTime</a>
    /// </summary>
    let xsdDateTime = _prefixId.prefix "xsdDateTime"
    /// <summary>
    ///   <para>rdfs:label : year</para>
    ///   <para>rdfs:comment : Year position in a calendar-clock system.
    ///
    /// The range of this property is not specified, so can be replaced by any specific representation of a calendar year from any calendar. </para>
    ///   <a href="http://www.w3.org/2006/time#year">time:year</a>
    /// </summary>
    let year = _prefixId.prefix "year"
    /// <summary>
    ///   <para>rdfs:label : years duration</para>
    ///   <para>rdfs:comment : length of, or element of the length of, a temporal extent expressed in years</para>
    ///   <a href="http://www.w3.org/2006/time#years">time:years</a>
    /// </summary>
    let years = _prefixId.prefix "years"
