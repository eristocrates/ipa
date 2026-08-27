namespace https.spec.edmcouncil.org.fibo.ontology.FND.DatesAndTimes.FinancialDates.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_dt_fd =
    let _namespace_iri = Namespace_Iri fibo_fnd_dt_fd |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-dt-fd:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Financial Dates Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_dt_fd, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-dt-fd:AdHocSchedule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ad hoc schedule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/AdHocSchedule">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/AdHocSchedule</seealso>
    let AdHocSchedule = Prefixed_Name(fibo_fnd_dt_fd, "AdHocSchedule") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-fd:AdHocScheduleEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ad hoc schedule entry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/AdHocScheduleEntry">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/AdHocScheduleEntry</seealso>
    let AdHocScheduleEntry =
        Prefixed_Name(fibo_fnd_dt_fd, "AdHocScheduleEntry") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-fd:Age</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"age"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/Age">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/Age</seealso>
    let Age = Prefixed_Name(fibo_fnd_dt_fd, "Age") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-dt-fd:AnchorDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"anchor date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/AnchorDate">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/AnchorDate</seealso>
    let AnchorDate = Prefixed_Name(fibo_fnd_dt_fd, "AnchorDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-fd:BusinessCalendar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"business calendar"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/BusinessCalendar">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/BusinessCalendar</seealso>
    let BusinessCalendar =
        Prefixed_Name(fibo_fnd_dt_fd, "BusinessCalendar") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-fd:CalculatedDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"calculated date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalculatedDate">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalculatedDate</seealso>
    let CalculatedDate = Prefixed_Name(fibo_fnd_dt_fd, "CalculatedDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-fd:CalculationPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"calculation period"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalculationPeriod">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalculationPeriod</seealso>
    let CalculationPeriod =
        Prefixed_Name(fibo_fnd_dt_fd, "CalculationPeriod") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-fd:CalculationPeriodLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"calculation period length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalculationPeriodLength">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalculationPeriodLength</seealso>
    let CalculationPeriodLength =
        Prefixed_Name(fibo_fnd_dt_fd, "CalculationPeriodLength") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-fd:CalendarMonth</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-dt-fd:CalendarPeriod</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"calendar month"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalendarMonth">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalendarMonth</seealso>
    let CalendarMonth = Prefixed_Name(fibo_fnd_dt_fd, "CalendarMonth") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-dt-fd:CalendarPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"calendar period"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalendarPeriod">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalendarPeriod</seealso>
    let CalendarPeriod = Prefixed_Name(fibo_fnd_dt_fd, "CalendarPeriod") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-fd:CalendarQuarter</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-dt-fd:CalendarPeriod</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"calendar quarter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalendarQuarter">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalendarQuarter</seealso>
    let CalendarQuarter =
        Prefixed_Name(fibo_fnd_dt_fd, "CalendarQuarter") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-fd:CalendarSpecifiedInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"calendar-specified interval"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalendarSpecifiedInterval">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalendarSpecifiedInterval</seealso>
    let CalendarSpecifiedInterval =
        Prefixed_Name(fibo_fnd_dt_fd, "CalendarSpecifiedInterval") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-fd:CalendarWeek</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-dt-fd:CalendarPeriod</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"calendar week"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalendarWeek">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalendarWeek</seealso>
    let CalendarWeek = Prefixed_Name(fibo_fnd_dt_fd, "CalendarWeek") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-dt-fd:CalendarYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-dt-fd:CalendarPeriod</para>
    ///
    /// labels<para>"calendar year"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalendarYear">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CalendarYear</seealso>
    let CalendarYear = Prefixed_Name(fibo_fnd_dt_fd, "CalendarYear") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-fd:CombinedDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CombinedDateTime">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/CombinedDateTime</seealso>
    let CombinedDateTime =
        Prefixed_Name(fibo_fnd_dt_fd, "CombinedDateTime") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-fd:DatedCollectionConstituent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dated collection constituent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/DatedCollectionConstituent">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/DatedCollectionConstituent</seealso>
    let DatedCollectionConstituent =
        Prefixed_Name(fibo_fnd_dt_fd, "DatedCollectionConstituent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-fd:DatedStructuredCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dated structured collection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/DatedStructuredCollection">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/DatedStructuredCollection</seealso>
    let DatedStructuredCollection =
        Prefixed_Name(fibo_fnd_dt_fd, "DatedStructuredCollection") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-fd:ExplicitRecurrenceInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"explicit recurrence interval"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/ExplicitRecurrenceInterval">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/ExplicitRecurrenceInterval</seealso>
    let ExplicitRecurrenceInterval =
        Prefixed_Name(fibo_fnd_dt_fd, "ExplicitRecurrenceInterval") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-fd:Friday</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:TimeInterval</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Friday"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/Friday">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/Friday</seealso>
    let Friday = Prefixed_Name(fibo_fnd_dt_fd, "Friday") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-dt-fd:FromEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-dt-fd:TimeDirection</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"from the end"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/FromEnd">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/FromEnd</seealso>
    let FromEnd = Prefixed_Name(fibo_fnd_dt_fd, "FromEnd") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-dt-fd:FromStart</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-dt-fd:TimeDirection</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"from the start"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/FromStart">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/FromStart</seealso>
    let FromStart = Prefixed_Name(fibo_fnd_dt_fd, "FromStart") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-dt-fd:Monday</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:TimeInterval</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Monday"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/Monday">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/Monday</seealso>
    let Monday = Prefixed_Name(fibo_fnd_dt_fd, "Monday") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-fd:RecurrenceInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"recurrence interval"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/RecurrenceInterval">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/RecurrenceInterval</seealso>
    let RecurrenceInterval =
        Prefixed_Name(fibo_fnd_dt_fd, "RecurrenceInterval") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-fd:RegularSchedule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"regular schedule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/RegularSchedule">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/RegularSchedule</seealso>
    let RegularSchedule =
        Prefixed_Name(fibo_fnd_dt_fd, "RegularSchedule") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-fd:RelativeDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"relative date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/RelativeDate">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/RelativeDate</seealso>
    let RelativeDate = Prefixed_Name(fibo_fnd_dt_fd, "RelativeDate") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-dt-fd:Saturday</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:TimeInterval</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Saturday"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/Saturday">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/Saturday</seealso>
    let Saturday = Prefixed_Name(fibo_fnd_dt_fd, "Saturday") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-dt-fd:Schedule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"schedule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/Schedule">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/Schedule</seealso>
    let Schedule = Prefixed_Name(fibo_fnd_dt_fd, "Schedule") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-dt-fd:ScheduleStub</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"schedule stub"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/ScheduleStub">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/ScheduleStub</seealso>
    let ScheduleStub = Prefixed_Name(fibo_fnd_dt_fd, "ScheduleStub") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-dt-fd:SpecifiedDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"specified date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/SpecifiedDate">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/SpecifiedDate</seealso>
    let SpecifiedDate = Prefixed_Name(fibo_fnd_dt_fd, "SpecifiedDate") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-dt-fd:Sunday</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>DatesAndTimes:TimeInterval</para>
    ///
    /// labels<para>"Sunday"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/Sunday">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/Sunday</seealso>
    let Sunday = Prefixed_Name(fibo_fnd_dt_fd, "Sunday") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-dt-fd:Thursday</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:TimeInterval</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Thursday"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/Thursday">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/Thursday</seealso>
    let Thursday = Prefixed_Name(fibo_fnd_dt_fd, "Thursday") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-dt-fd:TimeDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"time direction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/TimeDirection">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/TimeDirection</seealso>
    let TimeDirection = Prefixed_Name(fibo_fnd_dt_fd, "TimeDirection") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-dt-fd:Tuesday</para>
    /// </summary>
    /// <remarks>
    ///   <para>DatesAndTimes:TimeInterval</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Tuesday"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/Tuesday">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/Tuesday</seealso>
    let Tuesday = Prefixed_Name(fibo_fnd_dt_fd, "Tuesday") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-dt-fd:Wednesday</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>DatesAndTimes:TimeInterval</para>
    ///
    /// labels<para>"Wednesday"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/Wednesday">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/Wednesday</seealso>
    let Wednesday = Prefixed_Name(fibo_fnd_dt_fd, "Wednesday") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-fd:hasAcquisitionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"has acquisition date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasAcquisitionDate">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasAcquisitionDate</seealso>
    let hasAcquisitionDate =
        Prefixed_Name(fibo_fnd_dt_fd, "hasAcquisitionDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-fd:hasAge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has age"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasAge">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasAge</seealso>
    let hasAge = Prefixed_Name(fibo_fnd_dt_fd, "hasAge") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-dt-fd:hasAnchorDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has anchor date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasAnchorDate">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasAnchorDate</seealso>
    let hasAnchorDate = Prefixed_Name(fibo_fnd_dt_fd, "hasAnchorDate") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-dt-fd:hasAsOfDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has as-of date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasAsOfDate">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasAsOfDate</seealso>
    let hasAsOfDate = Prefixed_Name(fibo_fnd_dt_fd, "hasAsOfDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-fd:hasCalendarPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has calendar period"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasCalendarPeriod">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasCalendarPeriod</seealso>
    let hasCalendarPeriod =
        Prefixed_Name(fibo_fnd_dt_fd, "hasCalendarPeriod") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-fd:hasClosingDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has closing date time"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasClosingDateTime">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasClosingDateTime</seealso>
    let hasClosingDateTime =
        Prefixed_Name(fibo_fnd_dt_fd, "hasClosingDateTime") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-fd:hasCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has count"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasCount">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasCount</seealso>
    let hasCount = Prefixed_Name(fibo_fnd_dt_fd, "hasCount") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-dt-fd:hasDateAdded</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has date added"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasDateAdded">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasDateAdded</seealso>
    let hasDateAdded = Prefixed_Name(fibo_fnd_dt_fd, "hasDateAdded") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-fd:hasDateReceived</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has date received"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasDateReceived">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasDateReceived</seealso>
    let hasDateReceived =
        Prefixed_Name(fibo_fnd_dt_fd, "hasDateReceived") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-fd:hasDateSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has date specification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasDateSpecification">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasDateSpecification</seealso>
    let hasDateSpecification =
        Prefixed_Name(fibo_fnd_dt_fd, "hasDateSpecification") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-fd:hasFinalStub</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has final stub"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasFinalStub">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasFinalStub</seealso>
    let hasFinalStub = Prefixed_Name(fibo_fnd_dt_fd, "hasFinalStub") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-dt-fd:hasInitialStub</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has initial stub"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasInitialStub">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasInitialStub</seealso>
    let hasInitialStub = Prefixed_Name(fibo_fnd_dt_fd, "hasInitialStub") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-fd:hasOpeningDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has opening date time"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasOpeningDateTime">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasOpeningDateTime</seealso>
    let hasOpeningDateTime =
        Prefixed_Name(fibo_fnd_dt_fd, "hasOpeningDateTime") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-fd:hasOrdinalNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has ordinal number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasOrdinalNumber">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasOrdinalNumber</seealso>
    let hasOrdinalNumber =
        Prefixed_Name(fibo_fnd_dt_fd, "hasOrdinalNumber") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-fd:hasOverallPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has overall period"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasOverallPeriod">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasOverallPeriod</seealso>
    let hasOverallPeriod =
        Prefixed_Name(fibo_fnd_dt_fd, "hasOverallPeriod") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-fd:hasRecurrenceInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has recurrence interval"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasRecurrenceInterval">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasRecurrenceInterval</seealso>
    let hasRecurrenceInterval =
        Prefixed_Name(fibo_fnd_dt_fd, "hasRecurrenceInterval") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-fd:hasRelativeDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has relative duration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasRelativeDuration">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasRelativeDuration</seealso>
    let hasRelativeDuration =
        Prefixed_Name(fibo_fnd_dt_fd, "hasRelativeDuration") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-fd:hasSchedule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has schedule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasSchedule">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasSchedule</seealso>
    let hasSchedule = Prefixed_Name(fibo_fnd_dt_fd, "hasSchedule") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-dt-fd:hasStub</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has stub"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasStub">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasStub</seealso>
    let hasStub = Prefixed_Name(fibo_fnd_dt_fd, "hasStub") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-fd:hasTimeDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has time direction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasTimeDirection">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/hasTimeDirection</seealso>
    let hasTimeDirection =
        Prefixed_Name(fibo_fnd_dt_fd, "hasTimeDirection") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-fd:isRelativeTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is relative to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/isRelativeTo">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/isRelativeTo</seealso>
    let isRelativeTo = Prefixed_Name(fibo_fnd_dt_fd, "isRelativeTo") |> PrefixedName
