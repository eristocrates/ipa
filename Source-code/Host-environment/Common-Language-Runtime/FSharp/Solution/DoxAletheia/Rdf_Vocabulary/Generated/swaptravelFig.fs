namespace http.www.w3.org._2000._10.swap.pim.travelFig.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swaptravelFig =
    let _namespace_iri = Namespace_Iri swaptravelFig |> NamespaceIRI
    /// <summary>
    ///   <para>swaptravelFig:O0</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Flight"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/travelFig#O0">http://www.w3.org/2000/10/swap/pim/travelFig#O0</seealso>
    let O0 = Prefixed_Name(swaptravelFig, "O0") |> PrefixedName
    /// <summary>
    ///   <para>swaptravelFig:O1</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Economy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/travelFig#O1">http://www.w3.org/2000/10/swap/pim/travelFig#O1</seealso>
    let O1 = Prefixed_Name(swaptravelFig, "O1") |> PrefixedName
    /// <summary>
    ///   <para>swaptravelFig:O10</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"toLocation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/travelFig#O10">http://www.w3.org/2000/10/swap/pim/travelFig#O10</seealso>
    let O10 = Prefixed_Name(swaptravelFig, "O10") |> PrefixedName
    /// <summary>
    ///   <para>swaptravelFig:O11</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"TemporalThing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/travelFig#O11">http://www.w3.org/2000/10/swap/pim/travelFig#O11</seealso>
    let O11 = Prefixed_Name(swaptravelFig, "O11") |> PrefixedName
    /// <summary>
    ///   <para>swaptravelFig:O13</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"arrivalTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/travelFig#O13">http://www.w3.org/2000/10/swap/pim/travelFig#O13</seealso>
    let O13 = Prefixed_Name(swaptravelFig, "O13") |> PrefixedName
    /// <summary>
    ///   <para>swaptravelFig:O14</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"TimeString"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/travelFig#O14">http://www.w3.org/2000/10/swap/pim/travelFig#O14</seealso>
    let O14 = Prefixed_Name(swaptravelFig, "O14") |> PrefixedName
    /// <summary>
    ///   <para>swaptravelFig:O15</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"AirlineCompany"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/travelFig#O15">http://www.w3.org/2000/10/swap/pim/travelFig#O15</seealso>
    let O15 = Prefixed_Name(swaptravelFig, "O15") |> PrefixedName
    /// <summary>
    ///   <para>swaptravelFig:O16</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"carrier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/travelFig#O16">http://www.w3.org/2000/10/swap/pim/travelFig#O16</seealso>
    let O16 = Prefixed_Name(swaptravelFig, "O16") |> PrefixedName
    /// <summary>
    ///   <para>swaptravelFig:O17</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"departureTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/travelFig#O17">http://www.w3.org/2000/10/swap/pim/travelFig#O17</seealso>
    let O17 = Prefixed_Name(swaptravelFig, "O17") |> PrefixedName
    /// <summary>
    ///   <para>swaptravelFig:O18</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Literal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/travelFig#O18">http://www.w3.org/2000/10/swap/pim/travelFig#O18</seealso>
    let O18 = Prefixed_Name(swaptravelFig, "O18") |> PrefixedName
    /// <summary>
    ///   <para>swaptravelFig:O20</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"nameOfAgent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/travelFig#O20">http://www.w3.org/2000/10/swap/pim/travelFig#O20</seealso>
    let O20 = Prefixed_Name(swaptravelFig, "O20") |> PrefixedName
    /// <summary>
    ///   <para>swaptravelFig:O21</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Agent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/travelFig#O21">http://www.w3.org/2000/10/swap/pim/travelFig#O21</seealso>
    let O21 = Prefixed_Name(swaptravelFig, "O21") |> PrefixedName
    /// <summary>
    ///   <para>swaptravelFig:O23</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Airport-Physical"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/travelFig#O23">http://www.w3.org/2000/10/swap/pim/travelFig#O23</seealso>
    let O23 = Prefixed_Name(swaptravelFig, "O23") |> PrefixedName
    /// <summary>
    ///   <para>swaptravelFig:O25</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/travelFig#O25">http://www.w3.org/2000/10/swap/pim/travelFig#O25</seealso>
    let O25 = Prefixed_Name(swaptravelFig, "O25") |> PrefixedName
    /// <summary>
    ///   <para>swaptravelFig:O26</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"subEvents"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/travelFig#O26">http://www.w3.org/2000/10/swap/pim/travelFig#O26</seealso>
    let O26 = Prefixed_Name(swaptravelFig, "O26") |> PrefixedName
    /// <summary>
    ///   <para>swaptravelFig:O28</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"dt:date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/travelFig#O28">http://www.w3.org/2000/10/swap/pim/travelFig#O28</seealso>
    let O28 = Prefixed_Name(swaptravelFig, "O28") |> PrefixedName
    /// <summary>
    ///   <para>swaptravelFig:O29</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"flightNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/travelFig#O29">http://www.w3.org/2000/10/swap/pim/travelFig#O29</seealso>
    let O29 = Prefixed_Name(swaptravelFig, "O29") |> PrefixedName
    /// <summary>
    ///   <para>swaptravelFig:O3</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Translocation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/travelFig#O3">http://www.w3.org/2000/10/swap/pim/travelFig#O3</seealso>
    let O3 = Prefixed_Name(swaptravelFig, "O3") |> PrefixedName
    /// <summary>
    ///   <para>swaptravelFig:O5</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"PartiallyTangible"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/travelFig#O5">http://www.w3.org/2000/10/swap/pim/travelFig#O5</seealso>
    let O5 = Prefixed_Name(swaptravelFig, "O5") |> PrefixedName
    /// <summary>
    ///   <para>swaptravelFig:O6</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"fromLocation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/travelFig#O6">http://www.w3.org/2000/10/swap/pim/travelFig#O6</seealso>
    let O6 = Prefixed_Name(swaptravelFig, "O6") |> PrefixedName
    /// <summary>
    ///   <para>swaptravelFig:O7</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/travelFig#O7">http://www.w3.org/2000/10/swap/pim/travelFig#O7</seealso>
    let O7 = Prefixed_Name(swaptravelFig, "O7") |> PrefixedName
    /// <summary>
    ///   <para>swaptravelFig:O8</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"startingDate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/travelFig#O8">http://www.w3.org/2000/10/swap/pim/travelFig#O8</seealso>
    let O8 = Prefixed_Name(swaptravelFig, "O8") |> PrefixedName
    /// <summary>
    ///   <para>swaptravelFig:O9</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"endingDate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/pim/travelFig#O9">http://www.w3.org/2000/10/swap/pim/travelFig#O9</seealso>
    let O9 = Prefixed_Name(swaptravelFig, "O9") |> PrefixedName
