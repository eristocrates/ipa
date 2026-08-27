namespace http.www.w3.org._2002._12.cal.icaltzd.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module icaltzd =
    let _namespace_iri = Namespace_Iri icaltzd |> NamespaceIRI
    /// <summary>
    ///   <para>icaltzd:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/icaltzd#">http://www.w3.org/2002/12/cal/icaltzd#</seealso>
    let _prefix_iri = Prefixed_Name(icaltzd, "") |> PrefixedName
    /// <summary>
    ///   <para>icaltzd:VEVENT</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/icaltzd#VEVENT">http://www.w3.org/2002/12/cal/icaltzd#VEVENT</seealso>
    let VEVENT = Prefixed_Name(icaltzd, "VEVENT") |> PrefixedName
    /// <summary>
    ///   <para>icaltzd:dtend</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/icaltzd#dtend">http://www.w3.org/2002/12/cal/icaltzd#dtend</seealso>
    let dtend = Prefixed_Name(icaltzd, "dtend") |> PrefixedName
    /// <summary>
    ///   <para>icaltzd:dtstart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2002/12/cal/icaltzd#dtstart">http://www.w3.org/2002/12/cal/icaltzd#dtstart</seealso>
    let dtstart = Prefixed_Name(icaltzd, "dtstart") |> PrefixedName
