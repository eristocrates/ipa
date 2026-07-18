namespace https.spec.edmcouncil.org.fibo.ontology.FND.DatesAndTimes.BusinessDates.slash

open DoxAletheia.Rdf_Vocabulary

module fibo_fnd_dt_bd =
    let _namespace_name =
        "https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/"

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessDayConvention"></see>
    /// </summary>
    let BusinessDayConvention =
        Namespaced_IRI.parse _namespace_name "BusinessDayConvention" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessRecurrenceIntervalConvention"></see>
    /// </summary>
    let BusinessRecurrenceIntervalConvention =
        Namespaced_IRI.parse _namespace_name "BusinessRecurrenceIntervalConvention" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessDayFollowing"></see>
    /// </summary>
    let BusinessDayFollowing =
        Namespaced_IRI.parse _namespace_name "BusinessDayFollowing" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessDayModifiedFollowing"></see>
    /// </summary>
    let BusinessDayModifiedFollowing =
        Namespaced_IRI.parse _namespace_name "BusinessDayModifiedFollowing" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessDayModifiedPreceding"></see>
    /// </summary>
    let BusinessDayModifiedPreceding =
        Namespaced_IRI.parse _namespace_name "BusinessDayModifiedPreceding" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessDayNearest"></see>
    /// </summary>
    let BusinessDayNearest =
        Namespaced_IRI.parse _namespace_name "BusinessDayNearest" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessDayNone"></see>
    /// </summary>
    let BusinessDayNone =
        Namespaced_IRI.parse _namespace_name "BusinessDayNone" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessDayPreceding"></see>
    /// </summary>
    let BusinessDayPreceding =
        Namespaced_IRI.parse _namespace_name "BusinessDayPreceding" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessRecurrenceInterval"></see>
    /// </summary>
    let BusinessRecurrenceInterval =
        Namespaced_IRI.parse _namespace_name "BusinessRecurrenceInterval" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/hasBusinessRecurrenceIntervalConvention"></see>
    /// </summary>
    let hasBusinessRecurrenceIntervalConvention =
        Namespaced_IRI.parse _namespace_name "hasBusinessRecurrenceIntervalConvention" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/Convention"></see>
    /// </summary>
    let Convention = Namespaced_IRI.parse _namespace_name "Convention" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/DayOfMonth"></see>
    /// </summary>
    let DayOfMonth = Namespaced_IRI.parse _namespace_name "DayOfMonth" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/DayOfWeek"></see>
    /// </summary>
    let DayOfWeek = Namespaced_IRI.parse _namespace_name "DayOfWeek" |> NamespacedName
    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/EndOfMonth"></see>
    /// </summary>
    let EndOfMonth = Namespaced_IRI.parse _namespace_name "EndOfMonth" |> NamespacedName

    /// <summary>
    ///   <see href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/hasBusinessDayConvention"></see>
    /// </summary>
    let hasBusinessDayConvention =
        Namespaced_IRI.parse _namespace_name "hasBusinessDayConvention" |> NamespacedName
