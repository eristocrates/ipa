namespace https.www.omg.org.spec.Commons.DatesAndTimes.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module DatesAndTimes =
    let _namespace_iri = Namespace_Iri DatesAndTimes |> NamespaceIRI
    /// <summary>
    ///   <para>DatesAndTimes:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/DatesAndTimes/">https://www.omg.org/spec/Commons/DatesAndTimes/</seealso>
    let _prefix_iri = Prefixed_Name(DatesAndTimes, "") |> PrefixedName

    /// <summary>
    ///   <para>DatesAndTimes:CombinedDateTime</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/DatesAndTimes/CombinedDateTime">https://www.omg.org/spec/Commons/DatesAndTimes/CombinedDateTime</seealso>
    let CombinedDateTime =
        Prefixed_Name(DatesAndTimes, "CombinedDateTime") |> PrefixedName

    /// <summary>
    ///   <para>DatesAndTimes:Date</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/DatesAndTimes/Date">https://www.omg.org/spec/Commons/DatesAndTimes/Date</seealso>
    let Date = Prefixed_Name(DatesAndTimes, "Date") |> PrefixedName
    /// <summary>
    ///   <para>DatesAndTimes:DatePeriod</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/DatesAndTimes/DatePeriod">https://www.omg.org/spec/Commons/DatesAndTimes/DatePeriod</seealso>
    let DatePeriod = Prefixed_Name(DatesAndTimes, "DatePeriod") |> PrefixedName
    /// <summary>
    ///   <para>DatesAndTimes:DateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/DatesAndTimes/DateTime">https://www.omg.org/spec/Commons/DatesAndTimes/DateTime</seealso>
    let DateTime = Prefixed_Name(DatesAndTimes, "DateTime") |> PrefixedName
    /// <summary>
    ///   <para>DatesAndTimes:DateTimeStamp</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/DatesAndTimes/DateTimeStamp">https://www.omg.org/spec/Commons/DatesAndTimes/DateTimeStamp</seealso>
    let DateTimeStamp = Prefixed_Name(DatesAndTimes, "DateTimeStamp") |> PrefixedName
    /// <summary>
    ///   <para>DatesAndTimes:Day</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/DatesAndTimes/Day">https://www.omg.org/spec/Commons/DatesAndTimes/Day</seealso>
    let Day = Prefixed_Name(DatesAndTimes, "Day") |> PrefixedName
    /// <summary>
    ///   <para>DatesAndTimes:Duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/DatesAndTimes/Duration">https://www.omg.org/spec/Commons/DatesAndTimes/Duration</seealso>
    let Duration = Prefixed_Name(DatesAndTimes, "Duration") |> PrefixedName
    /// <summary>
    ///   <para>DatesAndTimes:ExplicitDate</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/DatesAndTimes/ExplicitDate">https://www.omg.org/spec/Commons/DatesAndTimes/ExplicitDate</seealso>
    let ExplicitDate = Prefixed_Name(DatesAndTimes, "ExplicitDate") |> PrefixedName

    /// <summary>
    ///   <para>DatesAndTimes:ExplicitDatePeriod</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/DatesAndTimes/ExplicitDatePeriod">https://www.omg.org/spec/Commons/DatesAndTimes/ExplicitDatePeriod</seealso>
    let ExplicitDatePeriod =
        Prefixed_Name(DatesAndTimes, "ExplicitDatePeriod") |> PrefixedName

    /// <summary>
    ///   <para>DatesAndTimes:ExplicitDuration</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/DatesAndTimes/ExplicitDuration">https://www.omg.org/spec/Commons/DatesAndTimes/ExplicitDuration</seealso>
    let ExplicitDuration =
        Prefixed_Name(DatesAndTimes, "ExplicitDuration") |> PrefixedName

    /// <summary>
    ///   <para>DatesAndTimes:TemporalEntity</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/DatesAndTimes/TemporalEntity">https://www.omg.org/spec/Commons/DatesAndTimes/TemporalEntity</seealso>
    let TemporalEntity = Prefixed_Name(DatesAndTimes, "TemporalEntity") |> PrefixedName
    /// <summary>
    ///   <para>DatesAndTimes:TimeInterval</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/DatesAndTimes/TimeInterval">https://www.omg.org/spec/Commons/DatesAndTimes/TimeInterval</seealso>
    let TimeInterval = Prefixed_Name(DatesAndTimes, "TimeInterval") |> PrefixedName
    /// <summary>
    ///   <para>DatesAndTimes:TimeOfDay</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/DatesAndTimes/TimeOfDay">https://www.omg.org/spec/Commons/DatesAndTimes/TimeOfDay</seealso>
    let TimeOfDay = Prefixed_Name(DatesAndTimes, "TimeOfDay") |> PrefixedName
    /// <summary>
    ///   <para>DatesAndTimes:hasDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/DatesAndTimes/hasDate">https://www.omg.org/spec/Commons/DatesAndTimes/hasDate</seealso>
    let hasDate = Prefixed_Name(DatesAndTimes, "hasDate") |> PrefixedName

    /// <summary>
    ///   <para>DatesAndTimes:hasDateOfIssuance</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/DatesAndTimes/hasDateOfIssuance">https://www.omg.org/spec/Commons/DatesAndTimes/hasDateOfIssuance</seealso>
    let hasDateOfIssuance =
        Prefixed_Name(DatesAndTimes, "hasDateOfIssuance") |> PrefixedName

    /// <summary>
    ///   <para>DatesAndTimes:hasDatePeriod</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/DatesAndTimes/hasDatePeriod">https://www.omg.org/spec/Commons/DatesAndTimes/hasDatePeriod</seealso>
    let hasDatePeriod = Prefixed_Name(DatesAndTimes, "hasDatePeriod") |> PrefixedName
    /// <summary>
    ///   <para>DatesAndTimes:hasDateTime</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/DatesAndTimes/hasDateTime">https://www.omg.org/spec/Commons/DatesAndTimes/hasDateTime</seealso>
    let hasDateTime = Prefixed_Name(DatesAndTimes, "hasDateTime") |> PrefixedName

    /// <summary>
    ///   <para>DatesAndTimes:hasDateTimeStamp</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/DatesAndTimes/hasDateTimeStamp">https://www.omg.org/spec/Commons/DatesAndTimes/hasDateTimeStamp</seealso>
    let hasDateTimeStamp =
        Prefixed_Name(DatesAndTimes, "hasDateTimeStamp") |> PrefixedName

    /// <summary>
    ///   <para>DatesAndTimes:hasDateValue</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/DatesAndTimes/hasDateValue">https://www.omg.org/spec/Commons/DatesAndTimes/hasDateValue</seealso>
    let hasDateValue = Prefixed_Name(DatesAndTimes, "hasDateValue") |> PrefixedName
    /// <summary>
    ///   <para>DatesAndTimes:hasDuration</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/DatesAndTimes/hasDuration">https://www.omg.org/spec/Commons/DatesAndTimes/hasDuration</seealso>
    let hasDuration = Prefixed_Name(DatesAndTimes, "hasDuration") |> PrefixedName

    /// <summary>
    ///   <para>DatesAndTimes:hasDurationValue</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/DatesAndTimes/hasDurationValue">https://www.omg.org/spec/Commons/DatesAndTimes/hasDurationValue</seealso>
    let hasDurationValue =
        Prefixed_Name(DatesAndTimes, "hasDurationValue") |> PrefixedName

    /// <summary>
    ///   <para>DatesAndTimes:hasEndDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/DatesAndTimes/hasEndDate">https://www.omg.org/spec/Commons/DatesAndTimes/hasEndDate</seealso>
    let hasEndDate = Prefixed_Name(DatesAndTimes, "hasEndDate") |> PrefixedName

    /// <summary>
    ///   <para>DatesAndTimes:hasExplicitDate</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/DatesAndTimes/hasExplicitDate">https://www.omg.org/spec/Commons/DatesAndTimes/hasExplicitDate</seealso>
    let hasExplicitDate =
        Prefixed_Name(DatesAndTimes, "hasExplicitDate") |> PrefixedName

    /// <summary>
    ///   <para>DatesAndTimes:hasObservedDateTime</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/DatesAndTimes/hasObservedDateTime">https://www.omg.org/spec/Commons/DatesAndTimes/hasObservedDateTime</seealso>
    let hasObservedDateTime =
        Prefixed_Name(DatesAndTimes, "hasObservedDateTime") |> PrefixedName

    /// <summary>
    ///   <para>DatesAndTimes:hasStartDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/DatesAndTimes/hasStartDate">https://www.omg.org/spec/Commons/DatesAndTimes/hasStartDate</seealso>
    let hasStartDate = Prefixed_Name(DatesAndTimes, "hasStartDate") |> PrefixedName
    /// <summary>
    ///   <para>DatesAndTimes:hasTimeValue</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/DatesAndTimes/hasTimeValue">https://www.omg.org/spec/Commons/DatesAndTimes/hasTimeValue</seealso>
    let hasTimeValue = Prefixed_Name(DatesAndTimes, "hasTimeValue") |> PrefixedName
    /// <summary>
    ///   <para>DatesAndTimes:hasWndDate</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/DatesAndTimes/hasWndDate">https://www.omg.org/spec/Commons/DatesAndTimes/hasWndDate</seealso>
    let hasWndDate = Prefixed_Name(DatesAndTimes, "hasWndDate") |> PrefixedName
    /// <summary>
    ///   <para>DatesAndTimes:precedes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/DatesAndTimes/precedes">https://www.omg.org/spec/Commons/DatesAndTimes/precedes</seealso>
    let precedes = Prefixed_Name(DatesAndTimes, "precedes") |> PrefixedName
    /// <summary>
    ///   <para>DatesAndTimes:succeeds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/DatesAndTimes/succeeds">https://www.omg.org/spec/Commons/DatesAndTimes/succeeds</seealso>
    let succeeds = Prefixed_Name(DatesAndTimes, "succeeds") |> PrefixedName
