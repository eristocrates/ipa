namespace http.streamreasoning.org.ontologies.frappe.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module frappe =
    let _namespace_iri = Namespace_Iri frappe |> NamespaceIRI
    /// <summary>
    ///   <para>frappe:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"FraPPE is a vocabulary to enable Visual Analitycs operations on geo-spatial time varying data. By enabling Visual Analytics instruments FraPPE ease the capture, correalation and comapration operations on geo-spatial data from different sources evolving over time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"FraPPE: Frame, Pixel, Place, Event vocabulary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://streamreasoning.org/ontologies/frappe#">http://streamreasoning.org/ontologies/frappe#</seealso>
    let _prefix_iri = Prefixed_Name(frappe, "") |> PrefixedName
    /// <summary>
    ///   <para>frappe:Capture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Activity to create new Captured Frame"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Capture"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://streamreasoning.org/ontologies/frappe#Capture">http://streamreasoning.org/ontologies/frappe#Capture</seealso>
    let Capture = Prefixed_Name(frappe, "Capture") |> PrefixedName
    /// <summary>
    ///   <para>frappe:CapturedFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Original time varying representation of a Grid, mediated by the Capture activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CapturedFrame"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://streamreasoning.org/ontologies/frappe#CapturedFrame">http://streamreasoning.org/ontologies/frappe#CapturedFrame</seealso>
    let CapturedFrame = Prefixed_Name(frappe, "CapturedFrame") |> PrefixedName
    /// <summary>
    ///   <para>frappe:Cell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Cell represents the basic spatial unit of aggregation of information"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://streamreasoning.org/ontologies/frappe#Cell">http://streamreasoning.org/ontologies/frappe#Cell</seealso>
    let Cell = Prefixed_Name(frappe, "Cell") |> PrefixedName
    /// <summary>
    ///   <para>frappe:Frame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Frame represents a time varying representation of a Grid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Frame"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://streamreasoning.org/ontologies/frappe#Frame">http://streamreasoning.org/ontologies/frappe#Frame</seealso>
    let Frame = Prefixed_Name(frappe, "Frame") |> PrefixedName
    /// <summary>
    ///   <para>frappe:Grid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Grid represents a group of contiguous Cells"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Grid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://streamreasoning.org/ontologies/frappe#Grid">http://streamreasoning.org/ontologies/frappe#Grid</seealso>
    let Grid = Prefixed_Name(frappe, "Grid") |> PrefixedName
    /// <summary>
    ///   <para>frappe:Pixel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Pixel is a time varying representation of a Cell
    /// "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Pixel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://streamreasoning.org/ontologies/frappe#Pixel">http://streamreasoning.org/ontologies/frappe#Pixel</seealso>
    let Pixel = Prefixed_Name(frappe, "Pixel") |> PrefixedName
    /// <summary>
    ///   <para>frappe:Place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Place represents a point in space"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Place"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://streamreasoning.org/ontologies/frappe#Place">http://streamreasoning.org/ontologies/frappe#Place</seealso>
    let Place = Prefixed_Name(frappe, "Place") |> PrefixedName
    /// <summary>
    ///   <para>frappe:SyntheticFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Synthetic time varying representation of a Grid, mediated by the Synthetize activity. A Synthetic Frame can be be created starting from Captured Frames or Synthetic Frames"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SyntheticFrame"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://streamreasoning.org/ontologies/frappe#SyntheticFrame">http://streamreasoning.org/ontologies/frappe#SyntheticFrame</seealso>
    let SyntheticFrame = Prefixed_Name(frappe, "SyntheticFrame") |> PrefixedName
    /// <summary>
    ///   <para>frappe:Synthetize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Activity to create new Synthetic Frame"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Synthetize"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://streamreasoning.org/ontologies/frappe#Synthetize">http://streamreasoning.org/ontologies/frappe#Synthetize</seealso>
    let Synthetize = Prefixed_Name(frappe, "Synthetize") |> PrefixedName
    /// <summary>
    ///   <para>frappe:contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a Frame with its Pixels"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Contains"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://streamreasoning.org/ontologies/frappe#contains">http://streamreasoning.org/ontologies/frappe#contains</seealso>
    let contains = Prefixed_Name(frappe, "contains") |> PrefixedName
    /// <summary>
    ///   <para>frappe:hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://streamreasoning.org/ontologies/frappe#hasValue">http://streamreasoning.org/ontologies/frappe#hasValue</seealso>
    let hasValue = Prefixed_Name(frappe, "hasValue") |> PrefixedName
    /// <summary>
    ///   <para>frappe:isIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a Pixel with its Frame"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isIn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://streamreasoning.org/ontologies/frappe#isIn">http://streamreasoning.org/ontologies/frappe#isIn</seealso>
    let isIn = Prefixed_Name(frappe, "isIn") |> PrefixedName
    /// <summary>
    ///   <para>frappe:isLocationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a Place with its Events"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isLocationOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://streamreasoning.org/ontologies/frappe#isLocationOf">http://streamreasoning.org/ontologies/frappe#isLocationOf</seealso>
    let isLocationOf = Prefixed_Name(frappe, "isLocationOf") |> PrefixedName
    /// <summary>
    ///   <para>frappe:isReferredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a Cell with its Pixels"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isReferredBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://streamreasoning.org/ontologies/frappe#isReferredBy">http://streamreasoning.org/ontologies/frappe#isReferredBy</seealso>
    let isReferredBy = Prefixed_Name(frappe, "isReferredBy") |> PrefixedName
    /// <summary>
    ///   <para>frappe:location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates an Event with its Pixel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://streamreasoning.org/ontologies/frappe#location">http://streamreasoning.org/ontologies/frappe#location</seealso>
    let location = Prefixed_Name(frappe, "location") |> PrefixedName
    /// <summary>
    ///   <para>frappe:refers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates Pixel to its Cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"refers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://streamreasoning.org/ontologies/frappe#refers">http://streamreasoning.org/ontologies/frappe#refers</seealso>
    let refers = Prefixed_Name(frappe, "refers") |> PrefixedName
    /// <summary>
    ///   <para>frappe:samplingTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a Frame with its creation Instant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"samplingTs"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://streamreasoning.org/ontologies/frappe#samplingTime">http://streamreasoning.org/ontologies/frappe#samplingTime</seealso>
    let samplingTime = Prefixed_Name(frappe, "samplingTime") |> PrefixedName
    /// <summary>
    ///   <para>frappe:timeExposure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relate a Capture Frame to the time interval needed to capture a minimum quantity of data"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"timeExposure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://streamreasoning.org/ontologies/frappe#timeExposure">http://streamreasoning.org/ontologies/frappe#timeExposure</seealso>
    let timeExposure = Prefixed_Name(frappe, "timeExposure") |> PrefixedName
    /// <summary>
    ///   <para>frappe:wasCapturedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a Frame to a Grid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"wasCapturedFrom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://streamreasoning.org/ontologies/frappe#wasCapturedFrom">http://streamreasoning.org/ontologies/frappe#wasCapturedFrom</seealso>
    let wasCapturedFrom = Prefixed_Name(frappe, "wasCapturedFrom") |> PrefixedName
    /// <summary>
    ///   <para>frappe:wasSynthetizedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a Synthetic Frame to the elements needed to the Synthetization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"wasSynthetizedFrom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://streamreasoning.org/ontologies/frappe#wasSynthetizedFrom">http://streamreasoning.org/ontologies/frappe#wasSynthetizedFrom</seealso>
    let wasSynthetizedFrom = Prefixed_Name(frappe, "wasSynthetizedFrom") |> PrefixedName
