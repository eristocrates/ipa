namespace https.spec.edmcouncil.org.fibo.ontology.FND.DatesAndTimes.FinancialDates.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_dt_fd =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/AdHocSchedule"></see>
    /// </summary>
    let AdHocSchedule =
        Namespaced_IRI.parse _namespace_name "AdHocSchedule" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/Schedule"></see>
    /// </summary>
    let Schedule = Namespaced_IRI.parse _namespace_name "Schedule" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/AdHocScheduleEntry"></see>
    /// </summary>
    let AdHocScheduleEntry =
        Namespaced_IRI.parse _namespace_name "AdHocScheduleEntry" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/DatedCollectionConstituent"></see>
    /// </summary>
    let DatedCollectionConstituent =
        Namespaced_IRI.parse _namespace_name "DatedCollectionConstituent" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/Age"></see>
    /// </summary>
    let Age = Namespaced_IRI.parse _namespace_name "Age" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasAsOfDate"></see>
    /// </summary>
    let hasAsOfDate =
        Namespaced_IRI.parse _namespace_name "hasAsOfDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/AnchorDate"></see>
    /// </summary>
    let AnchorDate = Namespaced_IRI.parse _namespace_name "AnchorDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/BusinessCalendar"></see>
    /// </summary>
    let BusinessCalendar =
        Namespaced_IRI.parse _namespace_name "BusinessCalendar" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalculatedDate"></see>
    /// </summary>
    let CalculatedDate =
        Namespaced_IRI.parse _namespace_name "CalculatedDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalculationPeriod"></see>
    /// </summary>
    let CalculationPeriod =
        Namespaced_IRI.parse _namespace_name "CalculationPeriod" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalculationPeriodLength"></see>
    /// </summary>
    let CalculationPeriodLength =
        Namespaced_IRI.parse _namespace_name "CalculationPeriodLength" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalendarMonth"></see>
    /// </summary>
    let CalendarMonth =
        Namespaced_IRI.parse _namespace_name "CalendarMonth" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalendarPeriod"></see>
    /// </summary>
    let CalendarPeriod =
        Namespaced_IRI.parse _namespace_name "CalendarPeriod" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalendarQuarter"></see>
    /// </summary>
    let CalendarQuarter =
        Namespaced_IRI.parse _namespace_name "CalendarQuarter" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalendarSpecifiedInterval"></see>
    /// </summary>
    let CalendarSpecifiedInterval =
        Namespaced_IRI.parse _namespace_name "CalendarSpecifiedInterval" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/RecurrenceInterval"></see>
    /// </summary>
    let RecurrenceInterval =
        Namespaced_IRI.parse _namespace_name "RecurrenceInterval" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasCalendarPeriod"></see>
    /// </summary>
    let hasCalendarPeriod =
        Namespaced_IRI.parse _namespace_name "hasCalendarPeriod" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasTimeDirection"></see>
    /// </summary>
    let hasTimeDirection =
        Namespaced_IRI.parse _namespace_name "hasTimeDirection" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/TimeDirection"></see>
    /// </summary>
    let TimeDirection =
        Namespaced_IRI.parse _namespace_name "TimeDirection" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasOrdinalNumber"></see>
    /// </summary>
    let hasOrdinalNumber =
        Namespaced_IRI.parse _namespace_name "hasOrdinalNumber" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/ExplicitRecurrenceInterval"></see>
    /// </summary>
    let ExplicitRecurrenceInterval =
        Namespaced_IRI.parse _namespace_name "ExplicitRecurrenceInterval" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalendarWeek"></see>
    /// </summary>
    let CalendarWeek =
        Namespaced_IRI.parse _namespace_name "CalendarWeek" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalendarYear"></see>
    /// </summary>
    let CalendarYear =
        Namespaced_IRI.parse _namespace_name "CalendarYear" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/DatedStructuredCollection"></see>
    /// </summary>
    let DatedStructuredCollection =
        Namespaced_IRI.parse _namespace_name "DatedStructuredCollection" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/Friday"></see>
    /// </summary>
    let Friday = Namespaced_IRI.parse _namespace_name "Friday" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/FromEnd"></see>
    /// </summary>
    let FromEnd = Namespaced_IRI.parse _namespace_name "FromEnd" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/FromStart"></see>
    /// </summary>
    let FromStart = Namespaced_IRI.parse _namespace_name "FromStart" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/Monday"></see>
    /// </summary>
    let Monday = Namespaced_IRI.parse _namespace_name "Monday" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/RegularSchedule"></see>
    /// </summary>
    let RegularSchedule =
        Namespaced_IRI.parse _namespace_name "RegularSchedule" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasAnchorDate"></see>
    /// </summary>
    let hasAnchorDate =
        Namespaced_IRI.parse _namespace_name "hasAnchorDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasFinalStub"></see>
    /// </summary>
    let hasFinalStub =
        Namespaced_IRI.parse _namespace_name "hasFinalStub" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/ScheduleStub"></see>
    /// </summary>
    let ScheduleStub =
        Namespaced_IRI.parse _namespace_name "ScheduleStub" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasInitialStub"></see>
    /// </summary>
    let hasInitialStub =
        Namespaced_IRI.parse _namespace_name "hasInitialStub" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasCount"></see>
    /// </summary>
    let hasCount = Namespaced_IRI.parse _namespace_name "hasCount" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasRecurrenceInterval"></see>
    /// </summary>
    let hasRecurrenceInterval =
        Namespaced_IRI.parse _namespace_name "hasRecurrenceInterval" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/RelativeDate"></see>
    /// </summary>
    let RelativeDate =
        Namespaced_IRI.parse _namespace_name "RelativeDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/isRelativeTo"></see>
    /// </summary>
    let isRelativeTo =
        Namespaced_IRI.parse _namespace_name "isRelativeTo" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasRelativeDuration"></see>
    /// </summary>
    let hasRelativeDuration =
        Namespaced_IRI.parse _namespace_name "hasRelativeDuration" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/SpecifiedDate"></see>
    /// </summary>
    let SpecifiedDate =
        Namespaced_IRI.parse _namespace_name "SpecifiedDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/Saturday"></see>
    /// </summary>
    let Saturday = Namespaced_IRI.parse _namespace_name "Saturday" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasOverallPeriod"></see>
    /// </summary>
    let hasOverallPeriod =
        Namespaced_IRI.parse _namespace_name "hasOverallPeriod" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasDateSpecification"></see>
    /// </summary>
    let hasDateSpecification =
        Namespaced_IRI.parse _namespace_name "hasDateSpecification" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/Sunday"></see>
    /// </summary>
    let Sunday = Namespaced_IRI.parse _namespace_name "Sunday" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/Thursday"></see>
    /// </summary>
    let Thursday = Namespaced_IRI.parse _namespace_name "Thursday" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/Tuesday"></see>
    /// </summary>
    let Tuesday = Namespaced_IRI.parse _namespace_name "Tuesday" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/Wednesday"></see>
    /// </summary>
    let Wednesday = Namespaced_IRI.parse _namespace_name "Wednesday" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasAcquisitionDate"></see>
    /// </summary>
    let hasAcquisitionDate =
        Namespaced_IRI.parse _namespace_name "hasAcquisitionDate" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasAge"></see>
    /// </summary>
    let hasAge = Namespaced_IRI.parse _namespace_name "hasAge" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasClosingDateTime"></see>
    /// </summary>
    let hasClosingDateTime =
        Namespaced_IRI.parse _namespace_name "hasClosingDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasDateAdded"></see>
    /// </summary>
    let hasDateAdded =
        Namespaced_IRI.parse _namespace_name "hasDateAdded" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasDateReceived"></see>
    /// </summary>
    let hasDateReceived =
        Namespaced_IRI.parse _namespace_name "hasDateReceived" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasStub"></see>
    /// </summary>
    let hasStub = Namespaced_IRI.parse _namespace_name "hasStub" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasOpeningDateTime"></see>
    /// </summary>
    let hasOpeningDateTime =
        Namespaced_IRI.parse _namespace_name "hasOpeningDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasSchedule"></see>
    /// </summary>
    let hasSchedule =
        Namespaced_IRI.parse _namespace_name "hasSchedule" |> NamespacedName
