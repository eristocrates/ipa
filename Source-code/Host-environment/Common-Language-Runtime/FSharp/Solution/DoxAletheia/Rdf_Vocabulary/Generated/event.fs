namespace http.purl.org.NET.c4dm._event.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module event_ =
    let _namespace_iri = Namespace_Iri event_ |> NamespaceIRI
    /// <summary>
    ///   <para>event:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		An arbitrary classification of a space/time region, by a
    /// 		cognitive agent. An event may have actively participating agents,
    /// 		passive factors, products, and a location in space/time.
    /// 		</para>
    /// labels<para>Event</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/event.owl#Event">http://purl.org/NET/c4dm/event.owl#Event</seealso>
    let Event = Prefixed_Name(event_, "Event") |> PrefixedName
    /// <summary>
    ///   <para>event:produced_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/NET/c4dm/event.owl#produced_in">http://purl.org/NET/c4dm/event.owl#produced_in</seealso>
    let produced_in = Prefixed_Name(event_, "produced_in") |> PrefixedName
    /// <summary>
    ///   <para>event:hasAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/NET/c4dm/event.owl#hasAgent">http://purl.org/NET/c4dm/event.owl#hasAgent</seealso>
    let hasAgent = Prefixed_Name(event_, "hasAgent") |> PrefixedName
    /// <summary>
    ///   <para>event:hasLiteralFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/NET/c4dm/event.owl#hasLiteralFactor">http://purl.org/NET/c4dm/event.owl#hasLiteralFactor</seealso>
    let hasLiteralFactor = Prefixed_Name(event_, "hasLiteralFactor") |> PrefixedName
    /// <summary>
    ///   <para>event:isAgentIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>agent in</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/event.owl#isAgentIn">http://purl.org/NET/c4dm/event.owl#isAgentIn</seealso>
    let isAgentIn = Prefixed_Name(event_, "isAgentIn") |> PrefixedName
    /// <summary>
    ///   <para>event:literal_factor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    /// 		Relates an event to a factor which can be described as a literal. This property
    /// 		should not be used as-is, but should be subsumed by other, more specific, properties
    /// 		(like an hypothetic :weatherCelsius, linking an event to a temperature).
    /// 		</para>
    /// labels<para>literal factor</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/event.owl#literal_factor">http://purl.org/NET/c4dm/event.owl#literal_factor</seealso>
    let literal_factor = Prefixed_Name(event_, "literal_factor") |> PrefixedName
    /// <summary>
    ///   <para>event:place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 		Relates an event to a spatial object.
    /// 		</para>
    /// labels<para>place</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/event.owl#place">http://purl.org/NET/c4dm/event.owl#place</seealso>
    let place = Prefixed_Name(event_, "place") |> PrefixedName
    /// <summary>
    ///   <para>event:product</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 		Relates an event to something produced during the event---a sound, a pie, whatever...
    /// 		</para>
    /// labels<para>product</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/event.owl#product">http://purl.org/NET/c4dm/event.owl#product</seealso>
    let product = Prefixed_Name(event_, "product") |> PrefixedName
    /// <summary>
    ///   <para>event:Factor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		Everything used as a factor in an event
    /// 		</para>
    /// labels<para>Factor</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/event.owl#Factor">http://purl.org/NET/c4dm/event.owl#Factor</seealso>
    let Factor = Prefixed_Name(event_, "Factor") |> PrefixedName
    /// <summary>
    ///   <para>event:factor_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/NET/c4dm/event.owl#factor_of">http://purl.org/NET/c4dm/event.owl#factor_of</seealso>
    let factor_of = Prefixed_Name(event_, "factor_of") |> PrefixedName
    /// <summary>
    ///   <para>event:agent_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/NET/c4dm/event.owl#agent_in">http://purl.org/NET/c4dm/event.owl#agent_in</seealso>
    let agent_in = Prefixed_Name(event_, "agent_in") |> PrefixedName
    /// <summary>
    ///   <para>event:hasFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/NET/c4dm/event.owl#hasFactor">http://purl.org/NET/c4dm/event.owl#hasFactor</seealso>
    let hasFactor = Prefixed_Name(event_, "hasFactor") |> PrefixedName
    /// <summary>
    ///   <para>event:hasProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/NET/c4dm/event.owl#hasProduct">http://purl.org/NET/c4dm/event.owl#hasProduct</seealso>
    let hasProduct = Prefixed_Name(event_, "hasProduct") |> PrefixedName
    /// <summary>
    ///   <para>event:agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 		Relates an event to an active agent (a person, a computer, ... :-) )
    /// 		</para>
    /// labels<para>agent</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/event.owl#agent">http://purl.org/NET/c4dm/event.owl#agent</seealso>
    let agent = Prefixed_Name(event_, "agent") |> PrefixedName
    /// <summary>
    ///   <para>event:hasSubEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/NET/c4dm/event.owl#hasSubEvent">http://purl.org/NET/c4dm/event.owl#hasSubEvent</seealso>
    let hasSubEvent = Prefixed_Name(event_, "hasSubEvent") |> PrefixedName
    /// <summary>
    ///   <para>event:sub_event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 		This property provides a way to split a complex event (for example, a performance involving several
    /// 		musicians) into simpler ones (one event per musician).
    /// 		</para>
    /// labels<para>sub-event</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/event.owl#sub_event">http://purl.org/NET/c4dm/event.owl#sub_event</seealso>
    let sub_event = Prefixed_Name(event_, "sub_event") |> PrefixedName
    /// <summary>
    ///   <para>event:isFactorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>factor of</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/event.owl#isFactorOf">http://purl.org/NET/c4dm/event.owl#isFactorOf</seealso>
    let isFactorOf = Prefixed_Name(event_, "isFactorOf") |> PrefixedName
    /// <summary>
    ///   <para>event:producedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>produced in</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/event.owl#producedIn">http://purl.org/NET/c4dm/event.owl#producedIn</seealso>
    let producedIn = Prefixed_Name(event_, "producedIn") |> PrefixedName
    /// <summary>
    ///   <para>event:time</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 		Relates an event to a time object, classifying a time region (either instantaneous or having an extent).
    /// 		By using the Timeline ontology here, you can define event happening on a recorded track or on any
    /// 		media with a temporal extent.
    /// 		</para>
    /// labels<para>time</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/event.owl#time">http://purl.org/NET/c4dm/event.owl#time</seealso>
    let time = Prefixed_Name(event_, "time") |> PrefixedName
    /// <summary>
    ///   <para>event:Product</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// 		Everything produced by an event
    /// 		</para>
    /// labels<para>Product</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/event.owl#Product">http://purl.org/NET/c4dm/event.owl#Product</seealso>
    let Product = Prefixed_Name(event_, "Product") |> PrefixedName
    /// <summary>
    ///   <para>event:factor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    /// 		Relates an event to a passive factor (a tool, an instrument, an abstract cause...)
    /// 		</para>
    /// labels<para>factor</para></remarks>
    /// <seealso href="http://purl.org/NET/c4dm/event.owl#factor">http://purl.org/NET/c4dm/event.owl#factor</seealso>
    let factor = Prefixed_Name(event_, "factor") |> PrefixedName
