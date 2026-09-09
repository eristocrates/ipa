#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``cmns-dt`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/DatesAndTimes/" "cmns-dt"

    let _namespaceIri = _prefixId.prefix ""
    let CombinedDateTime = _prefixId.prefix "CombinedDateTime"
    /// <summary>
    ///   <para>rdfs:label : date^^xsd:string</para>
    ///   <para>skos:definition : calendar day on some calendar^^xsd:string</para>
    ///   <para>skos:note : A date may or may not have a value, and may be explicit or calculated. A date that has a value is one that is either explicitly set as a literal when it is created, or is some form of 'calculated date'. In an instance of date, the existence of the 'has date value' property both indicates that the date is known, and gives the value of the date. A date that does not have a value is likely one that is some form of 'calculated date, in which the actual date has not (yet) been established.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/DatesAndTimes/Date">cmns-dt:Date</a>
    /// </summary>
    let Date = _prefixId.prefix "Date"
    /// <summary>
    ///   <para>rdfs:label : date period^^xsd:string</para>
    ///   <para>skos:definition : time span over one or more calendar days^^xsd:string</para>
    ///   <para>skos:note : A date period is considered unknown or incomplete if either the start date or the end date has no value. There may be cases, however, when the length of time is known, such as a 4-day work week, but the precise start and end of that week are not known.^^xsd:stringskos:note : A date period is typically defined by at least two of three properties: (1) a start date, (2) an end date, and (3) a duration. If more than one of these properties is missing, the date period may be invalid, incomplete, or unknown.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/DatesAndTimes/DatePeriod">cmns-dt:DatePeriod</a>
    /// </summary>
    let DatePeriod = _prefixId.prefix "DatePeriod"
    /// <summary>
    ///   <para>rdfs:label : date time^^xsd:string</para>
    ///   <para>skos:definition : time point including a date and a time, optionally including a time zone offset^^xsd:string</para>
    ///   <para>skos:note : 'has date time value' is omitted if the 'date time' is not (yet) known. The time zone is implicitly UTC.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/DatesAndTimes/DateTime">cmns-dt:DateTime</a>
    /// </summary>
    let DateTime = _prefixId.prefix "DateTime"
    /// <summary>
    ///   <para>rdfs:label : date time stamp^^xsd:string</para>
    ///   <para>skos:definition : time point including a date and a time that requires a time zone offset^^xsd:string</para>
    ///   <para>skos:note : 'has date time stamp value' is omitted if the 'date time stamp' is not (yet) established.^^xsd:string</para>
    ///   <para>cmns-av:synonym : time stamp^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/DatesAndTimes/DateTimeStamp">cmns-dt:DateTimeStamp</a>
    /// </summary>
    let DateTimeStamp = _prefixId.prefix "DateTimeStamp"
    let Day = _prefixId.prefix "Day"
    /// <summary>
    ///   <para>rdfs:label : duration^^xsd:string</para>
    ///   <para>skos:definition : interval of time of some specific length^^xsd:string</para>
    ///   <para>skos:note : The 'has duration value' property is absent if the duration is not (yet) known.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/DatesAndTimes/Duration">cmns-dt:Duration</a>
    /// </summary>
    let Duration = _prefixId.prefix "Duration"
    /// <summary>
    ///   <para>rdfs:label : explicit date^^xsd:string</para>
    ///   <para>skos:definition : date in which the 'has date value' property is required^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/DatesAndTimes/ExplicitDate">cmns-dt:ExplicitDate</a>
    /// </summary>
    let ExplicitDate = _prefixId.prefix "ExplicitDate"
    /// <summary>
    ///   <para>rdfs:label : explicit date period^^xsd:string</para>
    ///   <para>skos:definition : date period for which the start date, end date, and/or duration are required^^xsd:string</para>
    ///   <para>skos:note : As with 'date period', any one of {start date, end date, duration} may be omitted because the missing property can be inferred from the other two.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/DatesAndTimes/ExplicitDatePeriod">cmns-dt:ExplicitDatePeriod</a>
    /// </summary>
    let ExplicitDatePeriod = _prefixId.prefix "ExplicitDatePeriod"
    /// <summary>
    ///   <para>rdfs:label : explicit duration^^xsd:string</para>
    ///   <para>skos:definition : duration for which the 'has duration value' property must have a value^^xsd:string</para>
    ///   <para>skos:note : This class is used when a duration is guaranteed to be known when it is created.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/DatesAndTimes/ExplicitDuration">cmns-dt:ExplicitDuration</a>
    /// </summary>
    let ExplicitDuration = _prefixId.prefix "ExplicitDuration"
    /// <summary>
    ///   <para>rdfs:label : explicit time period^^xsd:string</para>
    ///   <para>skos:definition : time period for which the starting time, ending time, and/or duration are required^^xsd:string</para>
    ///   <para>skos:note : As with 'time period', any one of {start time, end time, duration} may be omitted because the missing property can be inferred from the other two.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/DatesAndTimes/ExplicitTimePeriod">cmns-dt:ExplicitTimePeriod</a>
    /// </summary>
    let ExplicitTimePeriod = _prefixId.prefix "ExplicitTimePeriod"
    /// <summary>
    ///   <para>rdfs:label : proper interval^^xsd:string</para>
    ///   <para>dct:source : https://www.w3.org/TR/owl-time/#time:ProperInterval^^xsd:anyURI</para>
    ///   <para>skos:definition : time interval with a non-zero extent or duration^^xsd:string</para>
    ///   <para>skos:note : Proper interval is included explicitly to enable mapping to the same term in the Time Ontology in OWL for use with the Allen intervals encoded therein.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/DatesAndTimes/ProperInterval">cmns-dt:ProperInterval</a>
    /// </summary>
    let ProperInterval = _prefixId.prefix "ProperInterval"
    /// <summary>
    ///   <para>rdfs:label : temporal entity^^xsd:string</para>
    ///   <para>skos:definition : time interval or instant^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/DatesAndTimes/TemporalEntity">cmns-dt:TemporalEntity</a>
    /// </summary>
    let TemporalEntity = _prefixId.prefix "TemporalEntity"
    /// <summary>
    ///   <para>rdfs:label : time instant^^xsd:string</para>
    ///   <para>skos:definition : temporal entity that is a member of a time scale, with no extent or duration^^xsd:string</para>
    ///   <para>skos:example : The Battle of Hastings was on '14 October 1066'. (This gives the Julian date of the battle at a granularity of 'day'. If desired, the battle could be given more precisely as a time period within that calendar day.)^^xsd:string</para>
    ///   <para>skos:note : For scales that have a granularity specified in days, a date is a time point; for scales down to the seconds, the equivalent of an xsd:dateTime or xsd:dateTimeStamp is a time point.^^xsd:stringskos:note : The duration of each time interval that is an instance of the time point is the granularity of the time scale of the time point.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.omg.org/spec/DTV/^^xsd:anyURIcmns-av:adaptedFrom : https://www.w3.org/TR/owl-time/#time:Instant^^xsd:anyURI</para>
    ///   <para>cmns-av:synonym : instant in time^^xsd:stringcmns-av:synonym : time point^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/DatesAndTimes/TimeInstant">cmns-dt:TimeInstant</a>
    /// </summary>
    let TimeInstant = _prefixId.prefix "TimeInstant"
    /// <summary>
    ///   <para>rdfs:label : time interval^^xsd:string</para>
    ///   <para>skos:definition : segment of the time axis, a location in time, with an extent or duration^^xsd:string</para>
    ///   <para>skos:example : the day whose Gregorian calendar date is September 11, 2001^^xsd:stringskos:example : the lifetime of Henry V^^xsd:string</para>
    ///   <para>skos:note : Every time interval has a beginning, an end, and a duration, even if not known. Every time interval is 'finite', a bounded segment of the time axis. The beginning or end of a time interval may be defined by reference to events that occur for a time interval that is not known.^^xsd:stringskos:note : Time intervals may be indefinite, meaning that their beginning is primordiality or their end is perpetuity, or both (eternity). This vocabulary assumes that indefinite time intervals exist and have some duration, but their duration is unknown.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.omg.org/spec/DTV/^^xsd:anyURIcmns-av:adaptedFrom : https://www.w3.org/TR/owl-time/#time:Interval^^xsd:anyURI</para>
    ///   <a href="https://www.omg.org/spec/Commons/DatesAndTimes/TimeInterval">cmns-dt:TimeInterval</a>
    /// </summary>
    let TimeInterval = _prefixId.prefix "TimeInterval"
    /// <summary>
    ///   <para>rdfs:label : time of day^^xsd:string</para>
    ///   <para>skos:definition : explicit time, according to a clock^^xsd:string</para>
    ///   <para>skos:note : The representation similar to xsd:dateTime, but should exclude the date component and time zone. The value of the has time value property roughly corresponds to xsd:time in XML schema datatypes, which is prohibited from use in OWL due to ambiguity in its definition.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/DatesAndTimes/TimeOfDay">cmns-dt:TimeOfDay</a>
    /// </summary>
    let TimeOfDay = _prefixId.prefix "TimeOfDay"
    /// <summary>
    ///   <para>rdfs:label : time period^^xsd:string</para>
    ///   <para>skos:definition : time span over some finite window^^xsd:string</para>
    ///   <para>skos:note : A time period is defined by at least two of three properties: (1) a start time, (2) an end time, and (3) a duration. If more than one of these properties is missing, the time period may be invalid or unknown.^^xsd:stringskos:note : A time period is unknown if either the starting or ending time has no value. If a time period is unknown, then the duration should either be omitted or unknown (have no value).^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/DatesAndTimes/TimePeriod">cmns-dt:TimePeriod</a>
    /// </summary>
    let TimePeriod = _prefixId.prefix "TimePeriod"
    /// <summary>
    ///   <para>rdfs:label : has date^^xsd:string</para>
    ///   <para>skos:definition : identifies a calendar day, month and year^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/DatesAndTimes/hasDate">cmns-dt:hasDate</a>
    /// </summary>
    let hasDate = _prefixId.prefix "hasDate"
    /// <summary>
    ///   <para>rdfs:label : has date of issuance^^xsd:string</para>
    ///   <para>skos:definition : links something, such as an agreement, contract, license, or report, to the date it was made available^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/DatesAndTimes/hasDateOfIssuance">cmns-dt:hasDateOfIssuance</a>
    /// </summary>
    let hasDateOfIssuance = _prefixId.prefix "hasDateOfIssuance"
    /// <summary>
    ///   <para>rdfs:label : has date period^^xsd:string</para>
    ///   <para>skos:definition : identifies a specific window of time, including a start date, end date and/or duration^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/DatesAndTimes/hasDatePeriod">cmns-dt:hasDatePeriod</a>
    /// </summary>
    let hasDatePeriod = _prefixId.prefix "hasDatePeriod"
    /// <summary>
    ///   <para>rdfs:label : has date time^^xsd:string</para>
    ///   <para>skos:definition : identifies a specific date and time of day, possibly excluding the time zone^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/DatesAndTimes/hasDateTime">cmns-dt:hasDateTime</a>
    /// </summary>
    let hasDateTime = _prefixId.prefix "hasDateTime"
    /// <summary>
    ///   <para>rdfs:label : has date time stamp^^xsd:string</para>
    ///   <para>skos:definition : identifies a specific date and time of day, explicitly including the time zone^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/DatesAndTimes/hasDateTimeStamp">cmns-dt:hasDateTimeStamp</a>
    /// </summary>
    let hasDateTimeStamp = _prefixId.prefix "hasDateTimeStamp"
    /// <summary>
    ///   <para>rdfs:label : has date time stamp value^^xsd:string</para>
    ///   <para>skos:definition : specifies an actual literal (explicit) date and time, including the time zone^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/DatesAndTimes/hasDateTimeStampValue">cmns-dt:hasDateTimeStampValue</a>
    /// </summary>
    let hasDateTimeStampValue = _prefixId.prefix "hasDateTimeStampValue"
    /// <summary>
    ///   <para>rdfs:label : has date time value^^xsd:string</para>
    ///   <para>skos:definition : specifies an actual literal (explicit) date and time^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/DatesAndTimes/hasDateTimeValue">cmns-dt:hasDateTimeValue</a>
    /// </summary>
    let hasDateTimeValue = _prefixId.prefix "hasDateTimeValue"
    /// <summary>
    ///   <para>rdfs:label : has date value^^xsd:string</para>
    ///   <para>skos:definition : specifies an actual literal (explicit) date captured in the format specified for xsd:date (i.e., ISO 8601 format), WITHOUT the time or timezone information; the semantics are identical to those of xsd:date^^xsd:string</para>
    ///   <para>skos:example : 2002-10-10 means October 10, 2002^^xsd:string</para>
    ///   <para>skos:note : In the Finance domain, for consistency with FpML (reference FpML Coding Schemes 30 June 2014, Version 1.56, section 2.1.1), the year MUST be specified as 4 digits, and the month and day MUST be specified as 2 digits with a leading zero if needed. Times and timezones should NOT be specified.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/DatesAndTimes/hasDateValue">cmns-dt:hasDateValue</a>
    /// </summary>
    let hasDateValue = _prefixId.prefix "hasDateValue"
    /// <summary>
    ///   <para>rdfs:label : has duration^^xsd:string</para>
    ///   <para>skos:definition : specifies the time during which something continues^^xsd:string</para>
    ///   <para>skos:note : This duration may be omitted or unknown if either the start or end Date of the DatePeriod is an ExplicitDate.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/DatesAndTimes/hasDuration">cmns-dt:hasDuration</a>
    /// </summary>
    let hasDuration = _prefixId.prefix "hasDuration"
    /// <summary>
    ///   <para>rdfs:label : has duration value^^xsd:string</para>
    ///   <para>skos:definition : specifies a literal (explicit) duration (amount of time) captured in the format specified for xsd:duration (i.e., ISO 8601 format); the semantics are identical to those of xsd:duration^^xsd:string</para>
    ///   <para>skos:example : -P3D means negative 3 days duration. This is used with OffsetDates to specify 3 days before (prior) to some other Date.^^xsd:stringskos:example : P1Y means 1 year^^xsd:stringskos:example : P1Y2M3DT4H5M6S means 1 year, 2 months, 3 days, 4 hours, 5 minutes, 6 seconds^^xsd:stringskos:example : P2M means 2 months^^xsd:stringskos:example : P3D means 3 days^^xsd:stringskos:example : PT4H means 4 hours^^xsd:stringskos:example : PT5M means 5 minutes^^xsd:stringskos:example : PT6S means 6 seconds^^xsd:string</para>
    ///   <para>skos:note : Negative durations are used to indicate relative dates that are before (rather than after) some other Date.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/DatesAndTimes/hasDurationValue">cmns-dt:hasDurationValue</a>
    /// </summary>
    let hasDurationValue = _prefixId.prefix "hasDurationValue"
    /// <summary>
    ///   <para>rdfs:label : has end^^xsd:string</para>
    ///   <para>skos:definition : indicates the final or ending time point associated with something^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/DatesAndTimes/hasEnd">cmns-dt:hasEnd</a>
    /// </summary>
    let hasEnd = _prefixId.prefix "hasEnd"
    /// <summary>
    ///   <para>rdfs:label : has end date^^xsd:string</para>
    ///   <para>skos:definition : indicates the final or ending date associated with something^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/DatesAndTimes/hasEndDate">cmns-dt:hasEndDate</a>
    /// </summary>
    let hasEndDate = _prefixId.prefix "hasEndDate"
    /// <summary>
    ///   <para>rdfs:label : has end time^^xsd:string</para>
    ///   <para>skos:definition : indicates the final or ending time associated with something^^xsd:string</para>
    ///   <para>cmns-av:usageNote : Use of the property 'hasTimeValue' as a property of the TimeOfDay to record the actual time, or use either the DateTime or DateTimeStamp class with the date zeroed out if the date is not relevant but with the time included.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/DatesAndTimes/hasEndTime">cmns-dt:hasEndTime</a>
    /// </summary>
    let hasEndTime = _prefixId.prefix "hasEndTime"
    /// <summary>
    ///   <para>rdfs:label : has explicit date^^xsd:string</para>
    ///   <para>skos:definition : indicates a stated date, as opposed to a calculated or unknown date, associated with something^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/DatesAndTimes/hasExplicitDate">cmns-dt:hasExplicitDate</a>
    /// </summary>
    let hasExplicitDate = _prefixId.prefix "hasExplicitDate"
    /// <summary>
    ///   <para>rdfs:label : has observed date and time^^xsd:string</para>
    ///   <para>skos:definition : indicates a date and time associated with an event, measurement, record, or observation^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/DatesAndTimes/hasObservedDateTime">cmns-dt:hasObservedDateTime</a>
    /// </summary>
    let hasObservedDateTime = _prefixId.prefix "hasObservedDateTime"
    /// <summary>
    ///   <para>rdfs:label : has start^^xsd:string</para>
    ///   <para>skos:definition : indicates the initial time point associated with something^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/DatesAndTimes/hasStart">cmns-dt:hasStart</a>
    /// </summary>
    let hasStart = _prefixId.prefix "hasStart"
    /// <summary>
    ///   <para>rdfs:label : has start date^^xsd:string</para>
    ///   <para>skos:definition : indicates the initial date associated with something^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/DatesAndTimes/hasStartDate">cmns-dt:hasStartDate</a>
    /// </summary>
    let hasStartDate = _prefixId.prefix "hasStartDate"
    /// <summary>
    ///   <para>rdfs:label : has start time^^xsd:string</para>
    ///   <para>skos:definition : indicates the initial or starting time associated with something^^xsd:string</para>
    ///   <para>cmns-av:usageNote : Use of the property 'hasTimeValue' as a property of the TimeOfDay to record the actual time, or use either the DateTime or DateTimeStamp class with the date zeroed out if the date is not relevant but with the time included.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/DatesAndTimes/hasStartTime">cmns-dt:hasStartTime</a>
    /// </summary>
    let hasStartTime = _prefixId.prefix "hasStartTime"
    /// <summary>
    ///   <para>rdfs:label : has time^^xsd:string</para>
    ///   <para>skos:definition : specifies a general time that can be associated with any element^^xsd:string</para>
    ///   <para>skos:note : This property corresponds to the property of the same name in the W3C Time Ontology, and can be used to support mapping.^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/DatesAndTimes/hasTime">cmns-dt:hasTime</a>
    /// </summary>
    let hasTime = _prefixId.prefix "hasTime"
    /// <summary>
    ///   <para>rdfs:label : has time period^^xsd:string</para>
    ///   <para>skos:definition : identifies a specific window of time, including a starting time, ending time and/or duration^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/DatesAndTimes/hasTimePeriod">cmns-dt:hasTimePeriod</a>
    /// </summary>
    let hasTimePeriod = _prefixId.prefix "hasTimePeriod"
    /// <summary>
    ///   <para>rdfs:label : has time value^^xsd:string</para>
    ///   <para>skos:definition : specifies an explicit time, captured in the format specified for xsd:time (i.e., ISO 8601 format), WITHOUT the date or timezone information^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/DatesAndTimes/hasTimeValue">cmns-dt:hasTimeValue</a>
    /// </summary>
    let hasTimeValue = _prefixId.prefix "hasTimeValue"
    /// <summary>
    ///   <para>rdfs:label : precedes^^xsd:string</para>
    ///   <para>dct:source : ISO 1087 Terminology work and terminology science - Vocabulary, Second edition, 2019-09, clause 3.2.24^^xsd:string</para>
    ///   <para>skos:definition : associates based on prior spatial or temporal proximity; occurs before in a logical order or sequence^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/DatesAndTimes/precedes">cmns-dt:precedes</a>
    /// </summary>
    let precedes = _prefixId.prefix "precedes"
    /// <summary>
    ///   <para>rdfs:label : succeeds^^xsd:string</para>
    ///   <para>dct:source : ISO 1087 Terminology work and terminology science - Vocabulary, Second edition, 2019-09, clause 3.2.24^^xsd:string</para>
    ///   <para>skos:definition : associates based on subsequent spatial or temporal proximity; follows in a logical order or sequence^^xsd:string</para>
    ///   <a href="https://www.omg.org/spec/Commons/DatesAndTimes/succeeds">cmns-dt:succeeds</a>
    /// </summary>
    let succeeds = _prefixId.prefix "succeeds"
