namespace http.www.w3.org._2006.timezone.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tzont =
    let _namespace_iri = Namespace_Iri tzont |> NamespaceIRI
    /// <summary>
    ///   <para>tzont:City</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/timezone#City">http://www.w3.org/2006/timezone#City</seealso>
    let City = Prefixed_Name(tzont, "City") |> PrefixedName
    /// <summary>
    ///   <para>tzont:Country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/timezone#Country">http://www.w3.org/2006/timezone#Country</seealso>
    let Country = Prefixed_Name(tzont, "Country") |> PrefixedName
    /// <summary>
    ///   <para>tzont:County</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/timezone#County">http://www.w3.org/2006/timezone#County</seealso>
    let County = Prefixed_Name(tzont, "County") |> PrefixedName
    /// <summary>
    ///   <para>tzont:DLSendDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/timezone#DLSendDate">http://www.w3.org/2006/timezone#DLSendDate</seealso>
    let DLSendDate = Prefixed_Name(tzont, "DLSendDate") |> PrefixedName
    /// <summary>
    ///   <para>tzont:DLSstartDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/timezone#DLSstartDate">http://www.w3.org/2006/timezone#DLSstartDate</seealso>
    let DLSstartDate = Prefixed_Name(tzont, "DLSstartDate") |> PrefixedName

    /// <summary>
    ///   <para>tzont:DaylightSavingsPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/timezone#DaylightSavingsPolicy">http://www.w3.org/2006/timezone#DaylightSavingsPolicy</seealso>
    let DaylightSavingsPolicy =
        Prefixed_Name(tzont, "DaylightSavingsPolicy") |> PrefixedName

    /// <summary>
    ///   <para>tzont:EnumeratedDaylightSavingsPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/timezone#EnumeratedDaylightSavingsPolicy">http://www.w3.org/2006/timezone#EnumeratedDaylightSavingsPolicy</seealso>
    let EnumeratedDaylightSavingsPolicy =
        Prefixed_Name(tzont, "EnumeratedDaylightSavingsPolicy") |> PrefixedName

    /// <summary>
    ///   <para>tzont:GMToffset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/timezone#GMToffset">http://www.w3.org/2006/timezone#GMToffset</seealso>
    let GMToffset = Prefixed_Name(tzont, "GMToffset") |> PrefixedName
    /// <summary>
    ///   <para>tzont:PoliticalRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/timezone#PoliticalRegion">http://www.w3.org/2006/timezone#PoliticalRegion</seealso>
    let PoliticalRegion = Prefixed_Name(tzont, "PoliticalRegion") |> PrefixedName
    /// <summary>
    ///   <para>tzont:Region</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/timezone#Region">http://www.w3.org/2006/timezone#Region</seealso>
    let Region = Prefixed_Name(tzont, "Region") |> PrefixedName
    /// <summary>
    ///   <para>tzont:Reservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/timezone#Reservation">http://www.w3.org/2006/timezone#Reservation</seealso>
    let Reservation = Prefixed_Name(tzont, "Reservation") |> PrefixedName
    /// <summary>
    ///   <para>tzont:State</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/timezone#State">http://www.w3.org/2006/timezone#State</seealso>
    let State = Prefixed_Name(tzont, "State") |> PrefixedName
    /// <summary>
    ///   <para>tzont:TimeZone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"A data property that permits the time zone relating to an entity to be specified."</para>
    /// labels<para>"has time zone"</para></remarks>
    /// <seealso href="http://www.w3.org/2006/timezone#TimeZone">http://www.w3.org/2006/timezone#TimeZone</seealso>
    let TimeZone = Prefixed_Name(tzont, "TimeZone") |> PrefixedName
    /// <summary>
    ///   <para>tzont:countryOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/timezone#countryOf">http://www.w3.org/2006/timezone#countryOf</seealso>
    let countryOf = Prefixed_Name(tzont, "countryOf") |> PrefixedName
    /// <summary>
    ///   <para>tzont:exceptionalRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/timezone#exceptionalRegion">http://www.w3.org/2006/timezone#exceptionalRegion</seealso>
    let exceptionalRegion = Prefixed_Name(tzont, "exceptionalRegion") |> PrefixedName
    /// <summary>
    ///   <para>tzont:hasAncestorRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/timezone#hasAncestorRegion">http://www.w3.org/2006/timezone#hasAncestorRegion</seealso>
    let hasAncestorRegion = Prefixed_Name(tzont, "hasAncestorRegion") |> PrefixedName

    /// <summary>
    ///   <para>tzont:hasDaylightSavingsPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/timezone#hasDaylightSavingsPolicy">http://www.w3.org/2006/timezone#hasDaylightSavingsPolicy</seealso>
    let hasDaylightSavingsPolicy =
        Prefixed_Name(tzont, "hasDaylightSavingsPolicy") |> PrefixedName

    /// <summary>
    ///   <para>tzont:hasParentRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/timezone#hasParentRegion">http://www.w3.org/2006/timezone#hasParentRegion</seealso>
    let hasParentRegion = Prefixed_Name(tzont, "hasParentRegion") |> PrefixedName
    /// <summary>
    ///   <para>tzont:hasTimeZone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/timezone#hasTimeZone">http://www.w3.org/2006/timezone#hasTimeZone</seealso>
    let hasTimeZone = Prefixed_Name(tzont, "hasTimeZone") |> PrefixedName
    /// <summary>
    ///   <para>tzont:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/timezone#name">http://www.w3.org/2006/timezone#name</seealso>
    let name = Prefixed_Name(tzont, "name") |> PrefixedName

    /// <summary>
    ///   <para>tzont:observesDaylightSavingsTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/timezone#observesDaylightSavingsTime">http://www.w3.org/2006/timezone#observesDaylightSavingsTime</seealso>
    let observesDaylightSavingsTime =
        Prefixed_Name(tzont, "observesDaylightSavingsTime") |> PrefixedName

    /// <summary>
    ///   <para>tzont:stateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/timezone#stateOf">http://www.w3.org/2006/timezone#stateOf</seealso>
    let stateOf = Prefixed_Name(tzont, "stateOf") |> PrefixedName
    /// <summary>
    ///   <para>tzont:timeZonePart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/timezone#timeZonePart">http://www.w3.org/2006/timezone#timeZonePart</seealso>
    let timeZonePart = Prefixed_Name(tzont, "timeZonePart") |> PrefixedName
