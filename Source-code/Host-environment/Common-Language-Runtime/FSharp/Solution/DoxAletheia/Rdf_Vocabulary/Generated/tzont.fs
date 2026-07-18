namespace http.www.w3.org._2006.timezone.hash

open DoxAletheia.Rdf_Vocabulary

module tzont =
    let _namespace_name = "http://www.w3.org/2006/timezone#"
    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#City"></see>
    /// </summary>
    let City = Namespaced_IRI.parse _namespace_name "City" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#PoliticalRegion"></see>
    /// </summary>
    let PoliticalRegion =
        Namespaced_IRI.parse _namespace_name "PoliticalRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#Country"></see>
    /// </summary>
    let Country = Namespaced_IRI.parse _namespace_name "Country" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#County"></see>
    /// </summary>
    let County = Namespaced_IRI.parse _namespace_name "County" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#hasParentRegion"></see>
    /// </summary>
    let hasParentRegion =
        Namespaced_IRI.parse _namespace_name "hasParentRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#State"></see>
    /// </summary>
    let State = Namespaced_IRI.parse _namespace_name "State" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#DLSendDate"></see>
    /// </summary>
    let DLSendDate = Namespaced_IRI.parse _namespace_name "DLSendDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#DLSstartDate"></see>
    /// </summary>
    let DLSstartDate =
        Namespaced_IRI.parse _namespace_name "DLSstartDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#DaylightSavingsPolicy"></see>
    /// </summary>
    let DaylightSavingsPolicy =
        Namespaced_IRI.parse _namespace_name "DaylightSavingsPolicy" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#EnumeratedDaylightSavingsPolicy"></see>
    /// </summary>
    let EnumeratedDaylightSavingsPolicy =
        Namespaced_IRI.parse _namespace_name "EnumeratedDaylightSavingsPolicy" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#GMToffset"></see>
    /// </summary>
    let GMToffset = Namespaced_IRI.parse _namespace_name "GMToffset" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#TimeZone"></see>
    /// </summary>
    let TimeZone = Namespaced_IRI.parse _namespace_name "TimeZone" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#name"></see>
    /// </summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#hasTimeZone"></see>
    /// </summary>
    let hasTimeZone =
        Namespaced_IRI.parse _namespace_name "hasTimeZone" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#observesDaylightSavingsTime"></see>
    /// </summary>
    let observesDaylightSavingsTime =
        Namespaced_IRI.parse _namespace_name "observesDaylightSavingsTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#hasDaylightSavingsPolicy"></see>
    /// </summary>
    let hasDaylightSavingsPolicy =
        Namespaced_IRI.parse _namespace_name "hasDaylightSavingsPolicy" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#exceptionalRegion"></see>
    /// </summary>
    let exceptionalRegion =
        Namespaced_IRI.parse _namespace_name "exceptionalRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#timeZonePart"></see>
    /// </summary>
    let timeZonePart =
        Namespaced_IRI.parse _namespace_name "timeZonePart" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#Region"></see>
    /// </summary>
    let Region = Namespaced_IRI.parse _namespace_name "Region" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#Reservation"></see>
    /// </summary>
    let Reservation =
        Namespaced_IRI.parse _namespace_name "Reservation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#countryOf"></see>
    /// </summary>
    let countryOf = Namespaced_IRI.parse _namespace_name "countryOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#hasAncestorRegion"></see>
    /// </summary>
    let hasAncestorRegion =
        Namespaced_IRI.parse _namespace_name "hasAncestorRegion" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2006/timezone#stateOf"></see>
    /// </summary>
    let stateOf = Namespaced_IRI.parse _namespace_name "stateOf" |> NamespacedName
