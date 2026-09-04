#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fnd-dt-fd`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/" "fibo-fnd-dt-fd"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : ad hoc schedule^^xsd:string</para>
    ///   <para>skos:definition : schedule consisting of some number of individual events that are not necessarily recurring^^xsd:string</para>
    ///   <para>cmns-av:usageNote : Other ontologies can extend AdHocSchedule and/or AdHocScheduleEntry as needed to relate the date to something. In particular, the Occurrences ontology extends AdHocScheduleEntry to associate an OccurrenceKind with each entry. The intended meaning is that an Occurrence of the OccurrenceKind happens on the corresponding Date.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/AdHocSchedule">fibo-fnd-dt-fd:AdHocSchedule</a>
    /// </summary>
    let AdHocSchedule = _prefixId.prefix "AdHocSchedule"
    /// <summary>
    ///   <para>rdfs:label : ad hoc schedule entry^^xsd:string</para>
    ///   <para>skos:definition : entry, including a date or date and time, among multiple non-regularly-recurring entries in a schedule^^xsd:string</para>
    ///   <para>cmns-av:usageNote : Other ontologies can extend AdHocScheduleEntry as needed. In particular, the Occurrences ontology extends AdHocScheduleEntry to consist of occurrences (events) of a given OccurrenceKind. The meaning is that an ad hoc schedule entry comprises a date and an event which is scheduled to occur on that date.^^xsd:stringcmns-av:usageNote : The Date of an AdHocScheduleEntry can be an ExplicitDate or any kind of CalculatedDate, such as:
    ///
    /// * An OccurrenceBasedDate -- a Date that itself is defined by an Occurrence (see the Occurrences ontology)
    /// * A RelativeDate - a Date relative to another Date, such as T+3
    /// * A SpecifiedDate - a Date that is defined by an arbitrary rule^^xsd:stringcmns-av:usageNote : The cmns-dt;hasDate property may be used to reify a date, if it is important to do so for a given application, or if not and typically, the inherited cmns-dt;hasObservedDateTime property may be used together with a cmns-dt;CombinedDateTime value, as long as the resulting schedule is consistent in using one or the other.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/AdHocScheduleEntry">fibo-fnd-dt-fd:AdHocScheduleEntry</a>
    /// </summary>
    let AdHocScheduleEntry = _prefixId.prefix "AdHocScheduleEntry"
    /// <summary>
    ///   <para>rdfs:label : age^^xsd:string</para>
    ///   <para>skos:definition : length of time that something or someone has been alive or existed^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/Age">fibo-fnd-dt-fd:Age</a>
    /// </summary>
    let Age = _prefixId.prefix "Age"
    /// <summary>
    ///   <para>rdfs:label : anchor date^^xsd:string</para>
    ///   <para>skos:definition : fixed reference point within a series or timeline^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : It is an explicit date chosen to provide context or structure for analyzing data or events.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/AnchorDate">fibo-fnd-dt-fd:AnchorDate</a>
    /// </summary>
    let AnchorDate = _prefixId.prefix "AnchorDate"
    /// <summary>
    ///   <para>rdfs:label : business calendar^^xsd:string</para>
    ///   <para>skos:definition : schedule and communications tool used to manage meetings, plan events, and coordinate activities within and/or across organizations^^xsd:string</para>
    ///   <para>skos:example : academic calendar, bank holiday calendar^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/BusinessCalendar">fibo-fnd-dt-fd:BusinessCalendar</a>
    /// </summary>
    let BusinessCalendar = _prefixId.prefix "BusinessCalendar"
    /// <summary>
    ///   <para>rdfs:label : calculated date^^xsd:string</para>
    ///   <para>skos:definition : date that is or will be determined based on some formula^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The hasDateValue property of a CalculatedDate is not set until the Date is calculated. Since the calculation may depend upon future events that may or may not ever happen, the hasDateValue property may never be set.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalculatedDate">fibo-fnd-dt-fd:CalculatedDate</a>
    /// </summary>
    let CalculatedDate = _prefixId.prefix "CalculatedDate"
    /// <summary>
    ///   <para>rdfs:label : calculation period^^xsd:string</para>
    ///   <para>skos:definition : explicit period from the start to the end of a specific interval or range within which a computational process or operation occurs^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalculationPeriod">fibo-fnd-dt-fd:CalculationPeriod</a>
    /// </summary>
    let CalculationPeriod = _prefixId.prefix "CalculationPeriod"
    /// <summary>
    ///   <para>rdfs:label : calculation period length^^xsd:string</para>
    ///   <para>skos:definition : explicit number of days from the adjusted effective or start date to the adjusted termination or end date calculated in accordance with the applicable day count fraction^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalculationPeriodLength">fibo-fnd-dt-fd:CalculationPeriodLength</a>
    /// </summary>
    let CalculationPeriodLength = _prefixId.prefix "CalculationPeriodLength"
    let CalendarMonth = _prefixId.prefix "CalendarMonth"
    /// <summary>
    ///   <para>rdfs:label : calendar period^^xsd:string</para>
    ///   <para>skos:definition : time interval that occurs within a system that fixes the beginning and length of a segment of the year with respect to that system^^xsd:string</para>
    ///   <para>skos:editorialNote : The terms 'calendar xxx' are intended to reinforce that these are periods on a calendar, not durations.
    ///
    /// For example, a calendar year always starts on a January 1 and ends on a December 31. The term 'calendar year' does not mean the same thing as a duration (an amount of time) of 1 year, nor can a calendar year start on any arbitrary day of a year. For example, a calendar year never starts on September 1.
    ///
    /// Similar points apply to other kinds of calendar periods, such as calendar week, calendar month, and calendar quarter.^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A calendar-specified date may be figured with respect to a calendar week, a calendar month, a calendar quarter, or a calendar year.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalendarPeriod">fibo-fnd-dt-fd:CalendarPeriod</a>
    /// </summary>
    let CalendarPeriod = _prefixId.prefix "CalendarPeriod"
    let CalendarQuarter = _prefixId.prefix "CalendarQuarter"
    /// <summary>
    ///   <para>rdfs:label : calendar-specified interval^^xsd:string</para>
    ///   <para>skos:definition : recurrence interval that is defined as the nth day of some calendar period (such as a calendar month), and a time direction (forward from the beginning of the month, or backwards from the end)^^xsd:string</para>
    ///   <para>skos:example : The 15th day of each calendar month.^^xsd:stringskos:example : The last day of each quarter, specified as RelativeDay 1, and TimeDirection set to FromEnd.^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The nth day is an ordinal number, not a cardinal number. '1' means the first day of the calendar period.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalendarSpecifiedInterval">fibo-fnd-dt-fd:CalendarSpecifiedInterval</a>
    /// </summary>
    let CalendarSpecifiedInterval = _prefixId.prefix "CalendarSpecifiedInterval"
    let CalendarWeek = _prefixId.prefix "CalendarWeek"
    let CalendarYear = _prefixId.prefix "CalendarYear"
    /// <summary>
    ///   <para>rdfs:label : dated collection constituent^^xsd:string</para>
    ///   <para>skos:definition : element of a collection that is associated with a date and time^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Note that the use of several options for the representation of a date and time stamp enables extensions for milliseconds, nanoseconds using an xsd:string that has the format of an xsd:dateTime datatype but extends the level of granularity consistently. An example of where this is required is to represent prices that change multiple times in a given day.^^xsd:string</para>
    ///   <para>cmns-av:usageNote : The use of custom datatypes is outside the OWL 2 RL profile and so users should consider commenting out the restriction on hasObservedDateTime altogether or change the data range to rdfs:Literal in applications that are constrained to OWL 2 RL.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/DatedCollectionConstituent">fibo-fnd-dt-fd:DatedCollectionConstituent</a>
    /// </summary>
    let DatedCollectionConstituent = _prefixId.prefix "DatedCollectionConstituent"
    /// <summary>
    ///   <para>rdfs:label : dated structured collection^^xsd:string</para>
    ///   <para>skos:definition : structured collection whose elements are required to have a date and time^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/DatedStructuredCollection">fibo-fnd-dt-fd:DatedStructuredCollection</a>
    /// </summary>
    let DatedStructuredCollection = _prefixId.prefix "DatedStructuredCollection"
    /// <summary>
    ///   <para>rdfs:label : explicit recurrence interval^^xsd:string</para>
    ///   <para>skos:definition : recurrence interval defined via an explicit duration^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/ExplicitRecurrenceInterval">fibo-fnd-dt-fd:ExplicitRecurrenceInterval</a>
    /// </summary>
    let ExplicitRecurrenceInterval = _prefixId.prefix "ExplicitRecurrenceInterval"
    let Friday = _prefixId.prefix "Friday"
    let FromEnd = _prefixId.prefix "FromEnd"
    let FromStart = _prefixId.prefix "FromStart"
    let Monday = _prefixId.prefix "Monday"
    /// <summary>
    ///   <para>rdfs:label : recurrence interval^^xsd:string</para>
    ///   <para>skos:definition : time interval that is consistent between elements of a regular schedule^^xsd:string</para>
    ///   <para>cmns-av:synonym : frequency^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/RecurrenceInterval">fibo-fnd-dt-fd:RecurrenceInterval</a>
    /// </summary>
    let RecurrenceInterval = _prefixId.prefix "RecurrenceInterval"
    /// <summary>
    ///   <para>rdfs:label : regular schedule^^xsd:string</para>
    ///   <para>skos:definition : schedule whose time intervals recur regularly^^xsd:string</para>
    ///   <para>skos:editorialNote : The BusinessDates ontology extends 'RegularSchedule' with an optional BusinessDayAdjustment that specifies what should happen if a scheduled date falls on a weekend or a holiday.^^xsd:string</para>
    ///   <para>skos:example : A 30 year mortgage is payable monthly on the 10th of the month, starting July 2015. The mortgage is issued on June 15, 2015 so the first payment is for the period June 15-June 30, and the last payment is for June 1-14 2045.
    ///
    /// The payment schedule is a RegularSchedule with these properties:
    ///
    /// * comprises: regular payment OccurrenceKind (with payment details) (see the 'comprises' property of the Occurrences ontology)
    /// * hasInitialStub: June 15-30, 2015 for initial payment
    /// * hasFinalStub: June 1-14, 2045 for final payment
    /// * hasCount: 358
    /// * hasOverallPeriod starting Date: June 15, 2015 with a duration of 30 years
    /// * hasRecurrenceInterval: specifies 10th day of each calendar month
    /// * hasRecurrenceStartDate: July 1, 2015^^xsd:stringskos:example : A corporate bond pays interest for 10 years starting on the first day of 2015. Interest payments are due 15 days after the expiration of each 6 month period: on July 15 and January 16.
    ///
    /// The payment schedule is a RegularSchedule, with these properties:
    ///
    /// * comprises: identifies the interest payment details
    /// * overall DatePeriod starting date is '2015-01-01', ending date is '2025-01-15', and duration is 'P10Y15D'
    /// * hasCount is 20 (2 payments per year for 10 years)
    /// * hasRecurrenceInterval is 'P6M'
    /// * hasRecurrenceStartDate is '2015-01-15'^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A RegularSchedule is a Schedule defined as a set of Dates that start on a recurrence start date and repeat after each recurrence interval. The size of this set is defined by a count.
    ///
    /// The 'initial ScheduleStub' associated with a RegularSchedule identifies any special treatment applied before the recurrence start date. Similarly, a 'final ScheduleStub' identifies any special handling at the end of the recurrences. For example, a mortgage loan that is due each calendar month may have an initial payment due before the first calendar month, or a final payment due after the last monthly payment.^^xsd:string</para>
    ///   <para>cmns-av:usageNote : Other ontologies can extend RegularSchedule as needed.
    ///
    /// In particular, the Occurrences ontology extends RegularSchedule to 'comprise' an 'OccurrenceKind'. The intended meaning is that a regular schedule comprises a number of scheduled dates and an event which is scheduled to occur on each of those dates, in other words an Occurrence of the OccurrenceKind should happen on each Date defined by the RegularSchedule.^^xsd:stringcmns-av:usageNote : The recurrence start date can be an ExplicitDate or any kind of CalculatedDate. Hence, the starting date could be relative to another Date (e.g. T+3) or triggered by the Occurrence of an OccurrenceKind, etc.
    ///
    /// The recurrence start date can also be relative to the starting Date of the overall DatePeriod of the Schedule.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/RegularSchedule">fibo-fnd-dt-fd:RegularSchedule</a>
    /// </summary>
    let RegularSchedule = _prefixId.prefix "RegularSchedule"
    /// <summary>
    ///   <para>rdfs:label : relative date^^xsd:string</para>
    ///   <para>skos:definition : calculated date that is some duration before or after another date^^xsd:string</para>
    ///   <para>skos:example : A settlement date, defined as T+3: three days after the trade date. The 'hasRelativeDuration' property is set to '3D'.^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : When the 'hasRelativeDuration' property is negative, the RelativeDate is before the 'isRelativeTo' Date; otherwise the RelativeDate is after the 'isRelativeTo' Date.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/RelativeDate">fibo-fnd-dt-fd:RelativeDate</a>
    /// </summary>
    let RelativeDate = _prefixId.prefix "RelativeDate"
    let Saturday = _prefixId.prefix "Saturday"
    /// <summary>
    ///   <para>rdfs:label : schedule^^xsd:string</para>
    ///   <para>skos:definition : collection of events, observations, or other occurrences and the associated dates and/or times when they will be done^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The overall period covers the entire DatePeriod of the Schedule, from the earliest Date to the final Date of the Schedule. Schedules may be ad hoc, essentially a list of dates and events without any consistency in the durations between events, regular, in which case there is a consistently recurring interval between events, or a combination of the two. There may be a single overall period, or more than one if the schedule is extended for some reason.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/Schedule">fibo-fnd-dt-fd:Schedule</a>
    /// </summary>
    let Schedule = _prefixId.prefix "Schedule"
    /// <summary>
    ///   <para>rdfs:label : schedule stub^^xsd:string</para>
    ///   <para>skos:definition : date period before the start of the recurring part of a schedule or after the end of the recurring part, which may be associated with a specific occurrence kind^^xsd:string</para>
    ///   <para>skos:editorialNote : The Occurrences ontology extends ScheduleStub to 'comprise' an OccurrenceKind. The meaning is that a schedule stub comprises a date period and an event which is scheduled to occur during that date period; in other words that an Occurrence of the OccurrenceKind should happen during the DatePeriod of the ScheduleStub.^^xsd:string</para>
    ///   <para>skos:example : A 30 year mortgage calls for monthly payments on the first day of each month, according to a RegularSchedule. If the mortgage does not start on the first day of a calendar month, then an initial ScheduleStub specifies the payment due for the DatePeriod up to the first day of the next calendar month. Similarly, a final ScheduleStub specifies the last payment due for the DatePeriod after the end of the last full calendar month.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/ScheduleStub">fibo-fnd-dt-fd:ScheduleStub</a>
    /// </summary>
    let ScheduleStub = _prefixId.prefix "ScheduleStub"
    /// <summary>
    ///   <para>rdfs:label : specified date^^xsd:string</para>
    ///   <para>skos:definition : calculated date that is defined by a rule that is captured as a string by the 'hasDateSpecification' property^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/SpecifiedDate">fibo-fnd-dt-fd:SpecifiedDate</a>
    /// </summary>
    let SpecifiedDate = _prefixId.prefix "SpecifiedDate"
    let Sunday = _prefixId.prefix "Sunday"
    let Thursday = _prefixId.prefix "Thursday"
    /// <summary>
    ///   <para>rdfs:label : time direction^^xsd:string</para>
    ///   <para>skos:definition : enumeration that indicates whether a calendar-specified date is figured from the start or the end of a calendar period^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/TimeDirection">fibo-fnd-dt-fd:TimeDirection</a>
    /// </summary>
    let TimeDirection = _prefixId.prefix "TimeDirection"
    let Tuesday = _prefixId.prefix "Tuesday"
    let Wednesday = _prefixId.prefix "Wednesday"
    /// <summary>
    ///   <para>rdfs:label : has acquisition date^^xsd:string</para>
    ///   <para>skos:definition : links an asset or owner/controller/controllee to the date or date and time of purchase^^xsd:string</para>
    ///   <para>cmns-av:usageNote : The use of custom datatypes is outside the OWL 2 RL profile and so users should consider commenting out the range restriction or change the range to rdfs:Literal in applications that are constrained to OWL 2 RL.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasAcquisitionDate">fibo-fnd-dt-fd:hasAcquisitionDate</a>
    /// </summary>
    let hasAcquisitionDate = _prefixId.prefix "hasAcquisitionDate"
    /// <summary>
    ///   <para>rdfs:label : has age^^xsd:string</para>
    ///   <para>skos:definition : relates something to the length of time it has existed^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasAge">fibo-fnd-dt-fd:hasAge</a>
    /// </summary>
    let hasAge = _prefixId.prefix "hasAge"
    /// <summary>
    ///   <para>rdfs:label : has anchor date^^xsd:string</para>
    ///   <para>skos:definition : specifies a fixed reference point within a series or timeline^^xsd:string</para>
    ///   <para>skos:example : With respect to a scoped measure, such as an economic indicator, the anchor date specifies the reference date against which the value of a numeric index for a more recent date is compared (i.e., the starting point from which it stems).^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasAnchorDate">fibo-fnd-dt-fd:hasAnchorDate</a>
    /// </summary>
    let hasAnchorDate = _prefixId.prefix "hasAnchorDate"
    /// <summary>
    ///   <para>rdfs:label : has as-of date^^xsd:string</para>
    ///   <para>skos:definition : relates something to the date on which it is accurate or valid (e.g. a credit report has an asOfDate that means the date when the information was drawn)^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : It is different from the creation date and need not be the last date of the DatePeriod covered.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasAsOfDate">fibo-fnd-dt-fd:hasAsOfDate</a>
    /// </summary>
    let hasAsOfDate = _prefixId.prefix "hasAsOfDate"
    /// <summary>
    ///   <para>rdfs:label : has calendar period^^xsd:string</para>
    ///   <para>skos:definition : identifies a period of time used in computing a calendar-specified date, such as a calendar week, calendar month, calendar quarter, or calendar year^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasCalendarPeriod">fibo-fnd-dt-fd:hasCalendarPeriod</a>
    /// </summary>
    let hasCalendarPeriod = _prefixId.prefix "hasCalendarPeriod"
    /// <summary>
    ///   <para>rdfs:label : has closing date time</para>
    ///   <para>skos:definition : the day and time at which something closes</para>
    ///   <para>cmns-av:usageNote : The use of custom datatypes is outside the OWL 2 RL profile and so users should consider commenting out the range restriction or change the range to rdfs:Literal in applications that are constrained to OWL 2 RL.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasClosingDateTime">fibo-fnd-dt-fd:hasClosingDateTime</a>
    /// </summary>
    let hasClosingDateTime = _prefixId.prefix "hasClosingDateTime"
    /// <summary>
    ///   <para>rdfs:label : has count^^xsd:string</para>
    ///   <para>skos:definition : specifies the total number of things in a collection, such as the number of entries in a regular schedule^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasCount">fibo-fnd-dt-fd:hasCount</a>
    /// </summary>
    let hasCount = _prefixId.prefix "hasCount"
    /// <summary>
    ///   <para>rdfs:label : has date added^^xsd:string</para>
    ///   <para>skos:definition : indicates the date something was included in something else^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasDateAdded">fibo-fnd-dt-fd:hasDateAdded</a>
    /// </summary>
    let hasDateAdded = _prefixId.prefix "hasDateAdded"
    /// <summary>
    ///   <para>rdfs:label : has date received^^xsd:string</para>
    ///   <para>skos:definition : relates something to the date it arrived or was delivered, e.g., a loan application request^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasDateReceived">fibo-fnd-dt-fd:hasDateReceived</a>
    /// </summary>
    let hasDateReceived = _prefixId.prefix "hasDateReceived"
    /// <summary>
    ///   <para>rdfs:label : has date specification^^xsd:string</para>
    ///   <para>skos:definition : rule that specifies how a specified date is computed^^xsd:string</para>
    ///   <para>skos:editorialNote : The rule is modeled as a simple String because OWL2 provides no way to model the semantics of such a rule.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasDateSpecification">fibo-fnd-dt-fd:hasDateSpecification</a>
    /// </summary>
    let hasDateSpecification = _prefixId.prefix "hasDateSpecification"
    /// <summary>
    ///   <para>rdfs:label : has final stub^^xsd:string</para>
    ///   <para>skos:definition : identifies any special period at the end of a regular schedule^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasFinalStub">fibo-fnd-dt-fd:hasFinalStub</a>
    /// </summary>
    let hasFinalStub = _prefixId.prefix "hasFinalStub"
    /// <summary>
    ///   <para>rdfs:label : has initial stub^^xsd:string</para>
    ///   <para>skos:definition : identifies any special period at the start of a regular schedule^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasInitialStub">fibo-fnd-dt-fd:hasInitialStub</a>
    /// </summary>
    let hasInitialStub = _prefixId.prefix "hasInitialStub"
    /// <summary>
    ///   <para>rdfs:label : has opening date time</para>
    ///   <para>skos:definition : the day and time at which something opens</para>
    ///   <para>cmns-av:usageNote : The use of custom datatypes is outside the OWL 2 RL profile and so users should consider commenting out the range restriction or change the range to rdfs:Literal in applications that are constrained to OWL 2 RL.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasOpeningDateTime">fibo-fnd-dt-fd:hasOpeningDateTime</a>
    /// </summary>
    let hasOpeningDateTime = _prefixId.prefix "hasOpeningDateTime"
    /// <summary>
    ///   <para>rdfs:label : has ordinal number^^xsd:string</para>
    ///   <para>skos:definition : specifies a number designating place in an ordered sequence, i.e., 1st, 2nd, 3rd, etc.^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Negative ordinal numbers mean 1st before, 2nd before, etc.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasOrdinalNumber">fibo-fnd-dt-fd:hasOrdinalNumber</a>
    /// </summary>
    let hasOrdinalNumber = _prefixId.prefix "hasOrdinalNumber"
    /// <summary>
    ///   <para>rdfs:label : has overall period^^xsd:string</para>
    ///   <para>skos:definition : identifies a date period that includes all the dates of a schedule, including any schedule stubs^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasOverallPeriod">fibo-fnd-dt-fd:hasOverallPeriod</a>
    /// </summary>
    let hasOverallPeriod = _prefixId.prefix "hasOverallPeriod"
    /// <summary>
    ///   <para>rdfs:label : has recurrence interval^^xsd:string</para>
    ///   <para>skos:definition : indicates the frequency with which some event or publication occurs^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasRecurrenceInterval">fibo-fnd-dt-fd:hasRecurrenceInterval</a>
    /// </summary>
    let hasRecurrenceInterval = _prefixId.prefix "hasRecurrenceInterval"
    /// <summary>
    ///   <para>rdfs:label : has relative duration^^xsd:string</para>
    ///   <para>skos:definition : duration between two explicit dates^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A relative duration may be negative.^^xsd:stringcmns-av:explanatoryNote : Note that this property is distinct from hasDurationValue, as a relative duration may resolve to a relative date or date time (both of which are time points) rather than an interval, which would result in a logical inconsistency if its parent property is hasDurationValue.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasRelativeDuration">fibo-fnd-dt-fd:hasRelativeDuration</a>
    /// </summary>
    let hasRelativeDuration = _prefixId.prefix "hasRelativeDuration"
    /// <summary>
    ///   <para>rdfs:label : has schedule^^xsd:string</para>
    ///   <para>skos:definition : indicates a schedule for something^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasSchedule">fibo-fnd-dt-fd:hasSchedule</a>
    /// </summary>
    let hasSchedule = _prefixId.prefix "hasSchedule"
    /// <summary>
    ///   <para>rdfs:label : has stub^^xsd:string</para>
    ///   <para>skos:definition : links an abbreviated period at the start or end of some schedule to the overall schedule^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasStub">fibo-fnd-dt-fd:hasStub</a>
    /// </summary>
    let hasStub = _prefixId.prefix "hasStub"
    /// <summary>
    ///   <para>rdfs:label : has time direction^^xsd:string</para>
    ///   <para>skos:definition : indicates whether a calendar-specified date is figured from the beginning or end of a calendar period^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasTimeDirection">fibo-fnd-dt-fd:hasTimeDirection</a>
    /// </summary>
    let hasTimeDirection = _prefixId.prefix "hasTimeDirection"
    /// <summary>
    ///   <para>rdfs:label : is relative to^^xsd:string</para>
    ///   <para>skos:definition : identifies a specific date that a relative date or relative date period references^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/isRelativeTo">fibo-fnd-dt-fd:isRelativeTo</a>
    /// </summary>
    let isRelativeTo = _prefixId.prefix "isRelativeTo"
