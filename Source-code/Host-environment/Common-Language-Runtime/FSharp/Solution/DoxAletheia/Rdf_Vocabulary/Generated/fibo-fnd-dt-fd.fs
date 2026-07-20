namespace https.spec.edmcouncil.org.fibo.ontology.FND.DatesAndTimes.FinancialDates.slash

open DoxAletheia

module fibo_fnd_dt_fd =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/AdHocSchedule"></see>
    /// </summary>
    let AdHocSchedule = _prefix "AdHocSchedule"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/Schedule"></see>
    /// </summary>
    let Schedule = _prefix "Schedule"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/AdHocScheduleEntry"></see>
    /// </summary>
    let AdHocScheduleEntry = _prefix "AdHocScheduleEntry"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/DatedCollectionConstituent"></see>
    /// </summary>
    let DatedCollectionConstituent = _prefix "DatedCollectionConstituent"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/Age"></see>
    /// </summary>
    let Age = _prefix "Age"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasAsOfDate"></see>
    /// </summary>
    let hasAsOfDate = _prefix "hasAsOfDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/AnchorDate"></see>
    /// </summary>
    let AnchorDate = _prefix "AnchorDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/BusinessCalendar"></see>
    /// </summary>
    let BusinessCalendar = _prefix "BusinessCalendar"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalculatedDate"></see>
    /// </summary>
    let CalculatedDate = _prefix "CalculatedDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalculationPeriod"></see>
    /// </summary>
    let CalculationPeriod = _prefix "CalculationPeriod"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalculationPeriodLength"></see>
    /// </summary>
    let CalculationPeriodLength = _prefix "CalculationPeriodLength"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalendarMonth"></see>
    /// </summary>
    let CalendarMonth = _prefix "CalendarMonth"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalendarPeriod"></see>
    /// </summary>
    let CalendarPeriod = _prefix "CalendarPeriod"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalendarQuarter"></see>
    /// </summary>
    let CalendarQuarter = _prefix "CalendarQuarter"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalendarSpecifiedInterval"></see>
    /// </summary>
    let CalendarSpecifiedInterval = _prefix "CalendarSpecifiedInterval"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/RecurrenceInterval"></see>
    /// </summary>
    let RecurrenceInterval = _prefix "RecurrenceInterval"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasCalendarPeriod"></see>
    /// </summary>
    let hasCalendarPeriod = _prefix "hasCalendarPeriod"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasTimeDirection"></see>
    /// </summary>
    let hasTimeDirection = _prefix "hasTimeDirection"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/TimeDirection"></see>
    /// </summary>
    let TimeDirection = _prefix "TimeDirection"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasOrdinalNumber"></see>
    /// </summary>
    let hasOrdinalNumber = _prefix "hasOrdinalNumber"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/ExplicitRecurrenceInterval"></see>
    /// </summary>
    let ExplicitRecurrenceInterval = _prefix "ExplicitRecurrenceInterval"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalendarWeek"></see>
    /// </summary>
    let CalendarWeek = _prefix "CalendarWeek"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalendarYear"></see>
    /// </summary>
    let CalendarYear = _prefix "CalendarYear"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/DatedStructuredCollection"></see>
    /// </summary>
    let DatedStructuredCollection = _prefix "DatedStructuredCollection"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/Friday"></see>
    /// </summary>
    let Friday = _prefix "Friday"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/FromEnd"></see>
    /// </summary>
    let FromEnd = _prefix "FromEnd"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/FromStart"></see>
    /// </summary>
    let FromStart = _prefix "FromStart"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/Monday"></see>
    /// </summary>
    let Monday = _prefix "Monday"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/RegularSchedule"></see>
    /// </summary>
    let RegularSchedule = _prefix "RegularSchedule"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasAnchorDate"></see>
    /// </summary>
    let hasAnchorDate = _prefix "hasAnchorDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasFinalStub"></see>
    /// </summary>
    let hasFinalStub = _prefix "hasFinalStub"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/ScheduleStub"></see>
    /// </summary>
    let ScheduleStub = _prefix "ScheduleStub"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasInitialStub"></see>
    /// </summary>
    let hasInitialStub = _prefix "hasInitialStub"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasCount"></see>
    /// </summary>
    let hasCount = _prefix "hasCount"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasRecurrenceInterval"></see>
    /// </summary>
    let hasRecurrenceInterval = _prefix "hasRecurrenceInterval"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/RelativeDate"></see>
    /// </summary>
    let RelativeDate = _prefix "RelativeDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/isRelativeTo"></see>
    /// </summary>
    let isRelativeTo = _prefix "isRelativeTo"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasRelativeDuration"></see>
    /// </summary>
    let hasRelativeDuration = _prefix "hasRelativeDuration"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/SpecifiedDate"></see>
    /// </summary>
    let SpecifiedDate = _prefix "SpecifiedDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/Saturday"></see>
    /// </summary>
    let Saturday = _prefix "Saturday"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasOverallPeriod"></see>
    /// </summary>
    let hasOverallPeriod = _prefix "hasOverallPeriod"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasDateSpecification"></see>
    /// </summary>
    let hasDateSpecification = _prefix "hasDateSpecification"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/Sunday"></see>
    /// </summary>
    let Sunday = _prefix "Sunday"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/Thursday"></see>
    /// </summary>
    let Thursday = _prefix "Thursday"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/Tuesday"></see>
    /// </summary>
    let Tuesday = _prefix "Tuesday"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/Wednesday"></see>
    /// </summary>
    let Wednesday = _prefix "Wednesday"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasAcquisitionDate"></see>
    /// </summary>
    let hasAcquisitionDate = _prefix "hasAcquisitionDate"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasAge"></see>
    /// </summary>
    let hasAge = _prefix "hasAge"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasClosingDateTime"></see>
    /// </summary>
    let hasClosingDateTime = _prefix "hasClosingDateTime"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasDateAdded"></see>
    /// </summary>
    let hasDateAdded = _prefix "hasDateAdded"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasDateReceived"></see>
    /// </summary>
    let hasDateReceived = _prefix "hasDateReceived"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasStub"></see>
    /// </summary>
    let hasStub = _prefix "hasStub"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasOpeningDateTime"></see>
    /// </summary>
    let hasOpeningDateTime = _prefix "hasOpeningDateTime"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasSchedule"></see>
    /// </summary>
    let hasSchedule = _prefix "hasSchedule"
