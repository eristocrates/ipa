namespace https.spec.edmcouncil.org.fibo.ontology.FND.DatesAndTimes.BusinessDates.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_dt_bd =
    let _namespace_iri = Namespace_Iri fibo_fnd_dt_bd |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-dt-bd:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Business Dates Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_dt_bd, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-bd:BusinessDayConvention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"business day convention"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessDayConvention">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessDayConvention</seealso>
    let BusinessDayConvention =
        Prefixed_Name(fibo_fnd_dt_bd, "BusinessDayConvention") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-bd:BusinessDayFollowing</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-dt-bd:BusinessDayConvention</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"business day following"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessDayFollowing">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessDayFollowing</seealso>
    let BusinessDayFollowing =
        Prefixed_Name(fibo_fnd_dt_bd, "BusinessDayFollowing") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-bd:BusinessDayModifiedFollowing</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-dt-bd:BusinessDayConvention</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"business day modified following"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessDayModifiedFollowing">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessDayModifiedFollowing</seealso>
    let BusinessDayModifiedFollowing =
        Prefixed_Name(fibo_fnd_dt_bd, "BusinessDayModifiedFollowing") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-bd:BusinessDayModifiedPreceding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-dt-bd:BusinessDayConvention</para>
    ///
    /// labels<para>"business day modified preceding"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessDayModifiedPreceding">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessDayModifiedPreceding</seealso>
    let BusinessDayModifiedPreceding =
        Prefixed_Name(fibo_fnd_dt_bd, "BusinessDayModifiedPreceding") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-bd:BusinessDayNearest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-dt-bd:BusinessDayConvention</para>
    ///
    /// labels<para>"business day nearest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessDayNearest">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessDayNearest</seealso>
    let BusinessDayNearest =
        Prefixed_Name(fibo_fnd_dt_bd, "BusinessDayNearest") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-bd:BusinessDayNone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>fibo-fnd-dt-bd:BusinessDayConvention</para>
    ///
    /// labels<para>"business day none"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessDayNone">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessDayNone</seealso>
    let BusinessDayNone =
        Prefixed_Name(fibo_fnd_dt_bd, "BusinessDayNone") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-bd:BusinessDayPreceding</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-dt-bd:BusinessDayConvention</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"business day preceding"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessDayPreceding">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessDayPreceding</seealso>
    let BusinessDayPreceding =
        Prefixed_Name(fibo_fnd_dt_bd, "BusinessDayPreceding") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-bd:BusinessRecurrenceInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"business recurrence interval"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessRecurrenceInterval">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessRecurrenceInterval</seealso>
    let BusinessRecurrenceInterval =
        Prefixed_Name(fibo_fnd_dt_bd, "BusinessRecurrenceInterval") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-bd:BusinessRecurrenceIntervalConvention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"business recurrence interval convention"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessRecurrenceIntervalConvention">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/BusinessRecurrenceIntervalConvention</seealso>
    let BusinessRecurrenceIntervalConvention =
        Prefixed_Name(fibo_fnd_dt_bd, "BusinessRecurrenceIntervalConvention") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-bd:Convention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"convention"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/Convention">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/Convention</seealso>
    let Convention = Prefixed_Name(fibo_fnd_dt_bd, "Convention") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-dt-bd:DayOfMonth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"day of month"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/DayOfMonth">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/DayOfMonth</seealso>
    let DayOfMonth = Prefixed_Name(fibo_fnd_dt_bd, "DayOfMonth") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-dt-bd:DayOfWeek</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"day of the week"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/DayOfWeek">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/DayOfWeek</seealso>
    let DayOfWeek = Prefixed_Name(fibo_fnd_dt_bd, "DayOfWeek") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-dt-bd:EndOfMonth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"end of the month"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/EndOfMonth">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/EndOfMonth</seealso>
    let EndOfMonth = Prefixed_Name(fibo_fnd_dt_bd, "EndOfMonth") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-bd:hasBusinessDayConvention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has business day convention"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/hasBusinessDayConvention">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/hasBusinessDayConvention</seealso>
    let hasBusinessDayConvention =
        Prefixed_Name(fibo_fnd_dt_bd, "hasBusinessDayConvention") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-bd:hasBusinessRecurrenceIntervalConvention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has business recurrence interval convention"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/hasBusinessRecurrenceIntervalConvention">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/hasBusinessRecurrenceIntervalConvention</seealso>
    let hasBusinessRecurrenceIntervalConvention =
        Prefixed_Name(fibo_fnd_dt_bd, "hasBusinessRecurrenceIntervalConvention") |> PrefixedName
