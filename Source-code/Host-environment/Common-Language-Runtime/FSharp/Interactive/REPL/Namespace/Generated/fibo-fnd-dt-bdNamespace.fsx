#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fnd-dt-bd`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/" "fibo-fnd-dt-bd"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : business day convention^^xsd:string</para>
    ///   <para>skos:definition : convention that enumerates the possible ways to handle a date that falls on a weekend or holiday^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.actusfrf.org/dictionary^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Business day conventions are linked to a calendar. Calendars have working and non-working days. In the ACTUS dictionary, the rules related to business day conventions (BDCs) state that a BDC value other than N means that cash flows cannot fall on non-working days, they must be shifted to the next business day (following) or the previous on (preceding). These two simple rules get refined twofold: (1) Following modified (preceding): Same like following (preceding), however if a cash flow gets shifted into a new month, then it is shifted to preceding (following) business day; (2) Shift/calculate (SC) and calculate/shift (CS). Accrual, principal, and possibly other calculations are affected by this choice. In the case of SC first the dates are shifted and after the shift cash flows are calculated. In the case of CS it is the other way round.^^xsd:stringcmns-av:explanatoryNote : Business day conventions commonly include:
    /// - Following business day: Moves the date to the next business day
    /// - Modified following business day: Moves the date to the next business day, unless it would fall in the next calendar month
    /// - Preceding business day: Moves the date to the previous business day
    /// - Modified preceding business day: Moves the date to the previous business day, unless it would fall in the previous calendar month^^xsd:stringcmns-av:explanatoryNote : The 2006 IDSA Definitions Section 4.11, provide the following examples: FRN Convention; Eurodollar Convention.
    /// - If a payment date or period end date falls on a non-business day, it is moved to the next business day.
    /// - If there is no numerically corresponding day in a calendar month, the payment date or period end date is moved to the last business day in that month.^^xsd:string</para>
    ///   <para>cmns-av:synonym : business day adjustment^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessDayConvention">fibo-fnd-dt-bd:BusinessDayConvention</a>
    /// </summary>
    let BusinessDayConvention = _prefixId.prefix "BusinessDayConvention"
    let BusinessDayFollowing = _prefixId.prefix "BusinessDayFollowing"
    let BusinessDayModifiedFollowing = _prefixId.prefix "BusinessDayModifiedFollowing"
    let BusinessDayModifiedPreceding = _prefixId.prefix "BusinessDayModifiedPreceding"
    let BusinessDayNearest = _prefixId.prefix "BusinessDayNearest"
    let BusinessDayNone = _prefixId.prefix "BusinessDayNone"
    let BusinessDayPreceding = _prefixId.prefix "BusinessDayPreceding"
    /// <summary>
    ///   <para>rdfs:label : business recurrence interval^^xsd:string</para>
    ///   <para>skos:definition : recurrence interval that is defined per a specific convention that determines how recurring days should be handled^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessRecurrenceInterval">fibo-fnd-dt-bd:BusinessRecurrenceInterval</a>
    /// </summary>
    let BusinessRecurrenceInterval = _prefixId.prefix "BusinessRecurrenceInterval"

    /// <summary>
    ///   <para>rdfs:label : business recurrence interval convention^^xsd:string</para>
    ///   <para>skos:definition : convention that specifies how recurring days should be handled, such as the end of the month, a particular day of the month, a day of the week, or more specifically, a t-bill auction date^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessRecurrenceIntervalConvention">fibo-fnd-dt-bd:BusinessRecurrenceIntervalConvention</a>
    /// </summary>
    let BusinessRecurrenceIntervalConvention =
        _prefixId.prefix "BusinessRecurrenceIntervalConvention"

    /// <summary>
    ///   <para>rdfs:label : convention^^xsd:string</para>
    ///   <para>skos:definition : widely accepted or established way of doing 'something' within some community of practice^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/Convention">fibo-fnd-dt-bd:Convention</a>
    /// </summary>
    let Convention = _prefixId.prefix "Convention"
    /// <summary>
    ///   <para>rdfs:label : day of month^^xsd:string</para>
    ///   <para>skos:definition : specific, recurring day of the month^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/DayOfMonth">fibo-fnd-dt-bd:DayOfMonth</a>
    /// </summary>
    let DayOfMonth = _prefixId.prefix "DayOfMonth"
    /// <summary>
    ///   <para>rdfs:label : day of the week^^xsd:string</para>
    ///   <para>skos:definition : specific, recurring day of the week^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/DayOfWeek">fibo-fnd-dt-bd:DayOfWeek</a>
    /// </summary>
    let DayOfWeek = _prefixId.prefix "DayOfWeek"
    /// <summary>
    ///   <para>rdfs:label : end of the month^^xsd:string</para>
    ///   <para>skos:definition : the last day of a calendar month, irrespective of the length of the calendar month^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/EndOfMonth">fibo-fnd-dt-bd:EndOfMonth</a>
    /// </summary>
    let EndOfMonth = _prefixId.prefix "EndOfMonth"
    /// <summary>
    ///   <para>rdfs:label : has business day convention^^xsd:string</para>
    ///   <para>skos:definition : identifies a convention regarding how a date should be handled when it falls on a day that is not a business day, such as a weekend or holiday^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/hasBusinessDayConvention">fibo-fnd-dt-bd:hasBusinessDayConvention</a>
    /// </summary>
    let hasBusinessDayConvention = _prefixId.prefix "hasBusinessDayConvention"

    /// <summary>
    ///   <para>rdfs:label : has business recurrence interval convention^^xsd:string</para>
    ///   <para>skos:definition : identifies a convention regarding how certain recurring dates should be handled with respect to a given schedule, such as the end of the month^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/hasBusinessRecurrenceIntervalConvention">fibo-fnd-dt-bd:hasBusinessRecurrenceIntervalConvention</a>
    /// </summary>
    let hasBusinessRecurrenceIntervalConvention =
        _prefixId.prefix "hasBusinessRecurrenceIntervalConvention"
