namespace http.semweb.mmlab.be.ns.oh.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module oh =
    let _namespace_iri = Namespace_Iri oh |> NamespaceIRI
    /// <summary>
    ///   <para>oh:Calendar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A calendar which can be used for opening hours</para>
    /// labels<para>A calendar</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/oh#Calendar">http://semweb.mmlab.be/ns/oh#Calendar</seealso>
    let Calendar = Prefixed_Name(oh, "Calendar") |> PrefixedName
    /// <summary>
    ///   <para>oh:OpeningHoursType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class to identify the type of opening hours</para>
    /// labels<para>Opening Hours Type</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/oh#OpeningHoursType">http://semweb.mmlab.be/ns/oh#OpeningHoursType</seealso>
    let OpeningHoursType = Prefixed_Name(oh, "OpeningHoursType") |> PrefixedName
    /// <summary>
    ///   <para>oh:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/oh#">http://semweb.mmlab.be/ns/oh#</seealso>
    let _prefix_iri = Prefixed_Name(oh, "") |> PrefixedName
    /// <summary>
    ///   <para>oh:OpeningHours</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class to identify opening hours</para>
    /// labels<para>Opening Hours</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/oh#OpeningHours">http://semweb.mmlab.be/ns/oh#OpeningHours</seealso>
    let OpeningHours = Prefixed_Name(oh, "OpeningHours") |> PrefixedName
    /// <summary>
    ///   <para>oh:calendar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A property to tell oh:OpeningHours to keep this calendar into account</para>
    /// </remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/oh#calendar">http://semweb.mmlab.be/ns/oh#calendar</seealso>
    let calendar = Prefixed_Name(oh, "calendar") |> PrefixedName
    /// <summary>
    ///   <para>oh:closinghours</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Tell whether or not this oh:Calendar specifies closing hours.</para>
    /// labels<para>Are Closing Hours</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/oh#closinghours">http://semweb.mmlab.be/ns/oh#closinghours</seealso>
    let closinghours = Prefixed_Name(oh, "closinghours") |> PrefixedName
    /// <summary>
    ///   <para>oh:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Give a type to an oh:OpeningHours instance</para>
    /// labels<para>has Opening Hours Type</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/oh#type">http://semweb.mmlab.be/ns/oh#type</seealso>
    let type_ = Prefixed_Name(oh, "type") |> PrefixedName
    /// <summary>
    ///   <para>oh:hasOpeningHours</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Link a certain thing to a description of opening hours</para>
    /// labels<para>Has Opening Hours</para></remarks>
    /// <seealso href="http://semweb.mmlab.be/ns/oh#hasOpeningHours">http://semweb.mmlab.be/ns/oh#hasOpeningHours</seealso>
    let hasOpeningHours = Prefixed_Name(oh, "hasOpeningHours") |> PrefixedName
