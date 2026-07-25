namespace http.contextus.net.ontology.ontomedia.misc.date.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module date =
    let _namespace_iri = Namespace_Iri date |> NamespaceIRI
    /// <summary>
    ///   <para>date:Calendar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a system of representing time</para>
    /// labels<para>Calendar</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/misc/date#Calendar">http://contextus.net/ontology/ontomedia/misc/date#Calendar</seealso>
    let Calendar = Prefixed_Name(date, "Calendar") |> PrefixedName
    /// <summary>
    ///   <para>date:Date-Component</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the parts of a date</para>
    /// labels<para>Date Component</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/misc/date#Date-Component">http://contextus.net/ontology/ontomedia/misc/date#Date-Component</seealso>
    let Date_Component = Prefixed_Name(date, "Date-Component") |> PrefixedName
    /// <summary>
    ///   <para>date:Minute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the part of a date which is the minute designaition</para>
    /// labels<para>Minute</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/misc/date#Minute">http://contextus.net/ontology/ontomedia/misc/date#Minute</seealso>
    let Minute = Prefixed_Name(date, "Minute") |> PrefixedName
    /// <summary>
    ///   <para>date:Month</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the part of a date which is the month designaition</para>
    /// labels<para>Month</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/misc/date#Month">http://contextus.net/ontology/ontomedia/misc/date#Month</seealso>
    let Month = Prefixed_Name(date, "Month") |> PrefixedName

    /// <summary>
    ///   <para>date:abstracted-from-occurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The occurrance of an event from which the reference point was abstracted</para>
    /// labels<para>Abstracted From Occurrence</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/misc/date#abstracted-from-occurrence">http://contextus.net/ontology/ontomedia/misc/date#abstracted-from-occurrence</seealso>
    let abstracted_from_occurrence =
        Prefixed_Name(date, "abstracted-from-occurrence") |> PrefixedName

    /// <summary>
    ///   <para>date:has-date-component</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies the name represented by the component</para>
    /// labels<para>Has Date Component</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/misc/date#has-date-component">http://contextus.net/ontology/ontomedia/misc/date#has-date-component</seealso>
    let has_date_component = Prefixed_Name(date, "has-date-component") |> PrefixedName

    /// <summary>
    ///   <para>date:reference-point-plus-one</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The Year Following the Reference Point Year</para>
    /// labels<para>Reference Point Plus One</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/misc/date#reference-point-plus-one">http://contextus.net/ontology/ontomedia/misc/date#reference-point-plus-one</seealso>
    let reference_point_plus_one =
        Prefixed_Name(date, "reference-point-plus-one") |> PrefixedName

    /// <summary>
    ///   <para>date:uses-calendar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The calandar which the date uses</para>
    /// labels<para>Uses Calendar</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/misc/date#uses-calendar">http://contextus.net/ontology/ontomedia/misc/date#uses-calendar</seealso>
    let uses_calendar = Prefixed_Name(date, "uses-calendar") |> PrefixedName
    /// <summary>
    ///   <para>date:Date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a value representing time</para>
    /// labels<para>Date</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/misc/date#Date">http://contextus.net/ontology/ontomedia/misc/date#Date</seealso>
    let Date = Prefixed_Name(date, "Date") |> PrefixedName
    /// <summary>
    ///   <para>date:Hour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the part of a date which is the hour designaition</para>
    /// labels<para>Hour</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/misc/date#Hour">http://contextus.net/ontology/ontomedia/misc/date#Hour</seealso>
    let Hour = Prefixed_Name(date, "Hour") |> PrefixedName
    /// <summary>
    ///   <para>date:Year</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the part of a date which is the year designaition</para>
    /// labels<para>Year</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/misc/date#Year">http://contextus.net/ontology/ontomedia/misc/date#Year</seealso>
    let Year = Prefixed_Name(date, "Year") |> PrefixedName

    /// <summary>
    ///   <para>date:after-reference-point</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The relative reference point after which the desired point of time occurs</para>
    /// labels<para>After Reference Point</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/misc/date#after-reference-point">http://contextus.net/ontology/ontomedia/misc/date#after-reference-point</seealso>
    let after_reference_point =
        Prefixed_Name(date, "after-reference-point") |> PrefixedName

    /// <summary>
    ///   <para>date:has-reference-point</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies a point of reference in a Calendar</para>
    /// labels<para>Has Reference Point</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/misc/date#has-reference-point">http://contextus.net/ontology/ontomedia/misc/date#has-reference-point</seealso>
    let has_reference_point = Prefixed_Name(date, "has-reference-point") |> PrefixedName
    /// <summary>
    ///   <para>date:Date-Ordering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the order in which components describing a date should be displayed</para>
    /// labels<para>Date Ordering</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/misc/date#Date-Ordering">http://contextus.net/ontology/ontomedia/misc/date#Date-Ordering</seealso>
    let Date_Ordering = Prefixed_Name(date, "Date-Ordering") |> PrefixedName
    /// <summary>
    ///   <para>date:Second</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the part of a date which is the second designaition</para>
    /// labels<para>Second</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/misc/date#Second">http://contextus.net/ontology/ontomedia/misc/date#Second</seealso>
    let Second = Prefixed_Name(date, "Second") |> PrefixedName
    /// <summary>
    ///   <para>date:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>OntoMedia Date Part Representation</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/misc/date#">http://contextus.net/ontology/ontomedia/misc/date#</seealso>
    let _prefix_iri = Prefixed_Name(date, "") |> PrefixedName

    /// <summary>
    ///   <para>date:CalendarReferencePoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a reference point which a calendar measures other dates relative to</para>
    /// labels<para>Calendar Reference Point</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/misc/date#CalendarReferencePoint">http://contextus.net/ontology/ontomedia/misc/date#CalendarReferencePoint</seealso>
    let CalendarReferencePoint =
        Prefixed_Name(date, "CalendarReferencePoint") |> PrefixedName

    /// <summary>
    ///   <para>date:Day</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the part of a date which is the day designaition</para>
    /// labels<para>Day</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/misc/date#Day">http://contextus.net/ontology/ontomedia/misc/date#Day</seealso>
    let Day = Prefixed_Name(date, "Day") |> PrefixedName
    /// <summary>
    ///   <para>date:Qualifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the textual qualifier that may be part of the data i.e. AD, BCE etc</para>
    /// labels<para>Qualifier</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/misc/date#Qualifier">http://contextus.net/ontology/ontomedia/misc/date#Qualifier</seealso>
    let Qualifier = Prefixed_Name(date, "Qualifier") |> PrefixedName
    /// <summary>
    ///   <para>date:Standard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the International Standard form of the date</para>
    /// labels<para>International Standard</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/misc/date#Standard">http://contextus.net/ontology/ontomedia/misc/date#Standard</seealso>
    let Standard = Prefixed_Name(date, "Standard") |> PrefixedName

    /// <summary>
    ///   <para>date:before-reference-point</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The relative reference point before which the desired point of time occurs</para>
    /// labels<para>Before Reference Point</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/misc/date#before-reference-point">http://contextus.net/ontology/ontomedia/misc/date#before-reference-point</seealso>
    let before_reference_point =
        Prefixed_Name(date, "before-reference-point") |> PrefixedName

    /// <summary>
    ///   <para>date:reference-point-minus-one</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The Year Preceeding the Reference Point Year</para>
    /// labels<para>Reference Point Minus One</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/misc/date#reference-point-minus-one">http://contextus.net/ontology/ontomedia/misc/date#reference-point-minus-one</seealso>
    let reference_point_minus_one =
        Prefixed_Name(date, "reference-point-minus-one") |> PrefixedName
