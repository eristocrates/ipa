namespace https.spec.edmcouncil.org.fibo.ontology.FND.DatesAndTimes.BusinessDates.slash

open DoxAletheia

module fibo_fnd_dt_bd =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessDayConvention"></see>
    /// </summary>
    let BusinessDayConvention = _prefix "BusinessDayConvention"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessRecurrenceIntervalConvention"></see>
    /// </summary>
    let BusinessRecurrenceIntervalConvention =
        _prefix "BusinessRecurrenceIntervalConvention"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessDayFollowing"></see>
    /// </summary>
    let BusinessDayFollowing = _prefix "BusinessDayFollowing"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessDayModifiedFollowing"></see>
    /// </summary>
    let BusinessDayModifiedFollowing = _prefix "BusinessDayModifiedFollowing"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessDayModifiedPreceding"></see>
    /// </summary>
    let BusinessDayModifiedPreceding = _prefix "BusinessDayModifiedPreceding"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessDayNearest"></see>
    /// </summary>
    let BusinessDayNearest = _prefix "BusinessDayNearest"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessDayNone"></see>
    /// </summary>
    let BusinessDayNone = _prefix "BusinessDayNone"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessDayPreceding"></see>
    /// </summary>
    let BusinessDayPreceding = _prefix "BusinessDayPreceding"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessRecurrenceInterval"></see>
    /// </summary>
    let BusinessRecurrenceInterval = _prefix "BusinessRecurrenceInterval"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/hasBusinessRecurrenceIntervalConvention"></see>
    /// </summary>
    let hasBusinessRecurrenceIntervalConvention =
        _prefix "hasBusinessRecurrenceIntervalConvention"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/Convention"></see>
    /// </summary>
    let Convention = _prefix "Convention"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/DayOfMonth"></see>
    /// </summary>
    let DayOfMonth = _prefix "DayOfMonth"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/DayOfWeek"></see>
    /// </summary>
    let DayOfWeek = _prefix "DayOfWeek"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/EndOfMonth"></see>
    /// </summary>
    let EndOfMonth = _prefix "EndOfMonth"
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/hasBusinessDayConvention"></see>
    /// </summary>
    let hasBusinessDayConvention = _prefix "hasBusinessDayConvention"
