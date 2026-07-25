namespace http.www.w3.org._2000._10.swap.pim.travelTerms.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swaptravelTerms =
    let _namespace_iri = Namespace_Iri swaptravelTerms |> NamespaceIRI
    /// <summary>
    ///   <para>swaptravelTerms:Flight</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Flight</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/travelTerms#Flight">http://www.w3.org/2000/10/swap/pim/travelTerms#Flight</seealso>
    let Flight = Prefixed_Name(swaptravelTerms, "Flight") |> PrefixedName
    /// <summary>
    ///   <para>swaptravelTerms:_g0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/travelTerms#_g0">http://www.w3.org/2000/10/swap/pim/travelTerms#_g0</seealso>
    let _g0 = Prefixed_Name(swaptravelTerms, "_g0") |> PrefixedName
    /// <summary>
    ///   <para>swaptravelTerms:arrivalTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>daml:UniqueProperty</para>
    ///
    /// labels<para>arrival time</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/travelTerms#arrivalTime">http://www.w3.org/2000/10/swap/pim/travelTerms#arrivalTime</seealso>
    let arrivalTime = Prefixed_Name(swaptravelTerms, "arrivalTime") |> PrefixedName
    /// <summary>
    ///   <para>swaptravelTerms:departureTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>daml:UniqueProperty</para>
    ///   <para>hmm... model this as the time of a departure subevent?</para>
    ///   <para>a string representing the departure time,
    ///    in the timezone of the flight's fromLocation</para>
    /// labels<para>departure time</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/travelTerms#departureTime">http://www.w3.org/2000/10/swap/pim/travelTerms#departureTime</seealso>
    let departureTime = Prefixed_Name(swaptravelTerms, "departureTime") |> PrefixedName
    /// <summary>
    ///   <para>swaptravelTerms:0_work</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/travelTerms#0_work">http://www.w3.org/2000/10/swap/pim/travelTerms#0_work</seealso>
    let _0_work = Prefixed_Name(swaptravelTerms, "0_work") |> PrefixedName
    /// <summary>
    ///   <para>swaptravelTerms:TimeString</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>a string of the form HH:MM; e.g. 12:00, 14:23</para>
    ///   <para>@@TODO: relate this to xml schema time stuff, cyc calendar stuff, etc.</para>
    /// labels<para>time string</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/travelTerms#TimeString">http://www.w3.org/2000/10/swap/pim/travelTerms#TimeString</seealso>
    let TimeString = Prefixed_Name(swaptravelTerms, "TimeString") |> PrefixedName
    /// <summary>
    ///   <para>swaptravelTerms:carrier</para>
    /// </summary>
    /// <remarks>
    ///   <para>daml:UniqueProperty</para>
    ///
    /// labels<para>carrier</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/travelTerms#carrier">http://www.w3.org/2000/10/swap/pim/travelTerms#carrier</seealso>
    let carrier = Prefixed_Name(swaptravelTerms, "carrier") |> PrefixedName
    /// <summary>
    ///   <para>swaptravelTerms:flightNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>daml:UniqueProperty</para>
    ///   <para>@@range specification needs a new datatyping property</para>
    /// labels<para>flight number</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/travelTerms#flightNumber">http://www.w3.org/2000/10/swap/pim/travelTerms#flightNumber</seealso>
    let flightNumber = Prefixed_Name(swaptravelTerms, "flightNumber") |> PrefixedName
