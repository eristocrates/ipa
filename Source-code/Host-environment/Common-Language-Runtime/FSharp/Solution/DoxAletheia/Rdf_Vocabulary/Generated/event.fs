namespace http.purl.org.NET.c4dm._event.owl.hash

open DoxAletheia

module event_ =
    let _namespace_name = "http://purl.org/NET/c4dm/event.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///
    /// 		An arbitrary classification of a space/time region, by a
    /// 		cognitive agent. An event may have actively participating agents,
    /// 		passive factors, products, and a location in space/time.
    ///
    /// <see href="http://purl.org/NET/c4dm/event.owl#Event"></see></summary>
    let Event = _prefix "Event"
    /// <summary>
    ///
    /// 		Everything used as a factor in an event
    ///
    /// <see href="http://purl.org/NET/c4dm/event.owl#Factor"></see></summary>
    let Factor = _prefix "Factor"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/event.owl#factor_of"></see>
    /// </summary>
    let factor_of = _prefix "factor_of"
    /// <summary>
    ///
    /// 		Everything produced by an event
    ///
    /// <see href="http://purl.org/NET/c4dm/event.owl#Product"></see></summary>
    let Product = _prefix "Product"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/event.owl#produced_in"></see>
    /// </summary>
    let produced_in = _prefix "produced_in"
    /// <summary>
    ///
    /// 		Relates an event to an active agent (a person, a computer, ... :-) )
    ///
    /// <see href="http://purl.org/NET/c4dm/event.owl#agent"></see></summary>
    let agent = _prefix "agent"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/event.owl#hasAgent"></see>
    /// </summary>
    let hasAgent = _prefix "hasAgent"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/event.owl#agent_in"></see>
    /// </summary>
    let agent_in = _prefix "agent_in"
    /// <summary>
    ///
    /// 		Relates an event to a passive factor (a tool, an instrument, an abstract cause...)
    ///
    /// <see href="http://purl.org/NET/c4dm/event.owl#factor"></see></summary>
    let factor = _prefix "factor"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/event.owl#hasFactor"></see>
    /// </summary>
    let hasFactor = _prefix "hasFactor"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/event.owl#hasLiteralFactor"></see>
    /// </summary>
    let hasLiteralFactor = _prefix "hasLiteralFactor"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/event.owl#hasProduct"></see>
    /// </summary>
    let hasProduct = _prefix "hasProduct"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/event.owl#hasSubEvent"></see>
    /// </summary>
    let hasSubEvent = _prefix "hasSubEvent"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/event.owl#isAgentIn"></see>
    /// </summary>
    let isAgentIn = _prefix "isAgentIn"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/event.owl#isFactorOf"></see>
    /// </summary>
    let isFactorOf = _prefix "isFactorOf"
    /// <summary>
    ///
    /// 		Relates an event to a factor which can be described as a literal. This property
    /// 		should not be used as-is, but should be subsumed by other, more specific, properties
    /// 		(like an hypothetic :weatherCelsius, linking an event to a temperature).
    ///
    /// <see href="http://purl.org/NET/c4dm/event.owl#literal_factor"></see></summary>
    let literal_factor = _prefix "literal_factor"
    /// <summary>
    ///
    /// 		Relates an event to a spatial object.
    ///
    /// <see href="http://purl.org/NET/c4dm/event.owl#place"></see></summary>
    let place = _prefix "place"
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/event.owl#producedIn"></see>
    /// </summary>
    let producedIn = _prefix "producedIn"
    /// <summary>
    ///
    /// 		Relates an event to something produced during the event---a sound, a pie, whatever...
    ///
    /// <see href="http://purl.org/NET/c4dm/event.owl#product"></see></summary>
    let product = _prefix "product"
    /// <summary>
    ///
    /// 		This property provides a way to split a complex event (for example, a performance involving several
    /// 		musicians) into simpler ones (one event per musician).
    ///
    /// <see href="http://purl.org/NET/c4dm/event.owl#sub_event"></see></summary>
    let sub_event = _prefix "sub_event"
    /// <summary>
    ///
    /// 		Relates an event to a time object, classifying a time region (either instantaneous or having an extent).
    /// 		By using the Timeline ontology here, you can define event happening on a recorded track or on any
    /// 		media with a temporal extent.
    ///
    /// <see href="http://purl.org/NET/c4dm/event.owl#time"></see></summary>
    let time = _prefix "time"
