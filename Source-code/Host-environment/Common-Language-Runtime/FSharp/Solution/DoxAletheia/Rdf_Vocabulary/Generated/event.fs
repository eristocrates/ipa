namespace http.purl.org.NET.c4dm._event.owl.hash

open DoxAletheia.Rdf_Vocabulary

module event_ =
    let _namespace_name = "http://purl.org/NET/c4dm/event.owl#"
    /// <summary>
    ///
    /// 		An arbitrary classification of a space/time region, by a
    /// 		cognitive agent. An event may have actively participating agents,
    /// 		passive factors, products, and a location in space/time.
    ///
    /// <see href="http://purl.org/NET/c4dm/event.owl#Event"></see></summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName
    /// <summary>
    ///
    /// 		Everything used as a factor in an event
    ///
    /// <see href="http://purl.org/NET/c4dm/event.owl#Factor"></see></summary>
    let Factor = Namespaced_IRI.parse _namespace_name "Factor" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/event.owl#factor_of"></see>
    /// </summary>
    let factor_of = Namespaced_IRI.parse _namespace_name "factor_of" |> NamespacedName
    /// <summary>
    ///
    /// 		Everything produced by an event
    ///
    /// <see href="http://purl.org/NET/c4dm/event.owl#Product"></see></summary>
    let Product = Namespaced_IRI.parse _namespace_name "Product" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/event.owl#produced_in"></see>
    /// </summary>
    let produced_in =
        Namespaced_IRI.parse _namespace_name "produced_in" |> NamespacedName

    /// <summary>
    ///
    /// 		Relates an event to an active agent (a person, a computer, ... :-) )
    ///
    /// <see href="http://purl.org/NET/c4dm/event.owl#agent"></see></summary>
    let agent = Namespaced_IRI.parse _namespace_name "agent" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/event.owl#hasAgent"></see>
    /// </summary>
    let hasAgent = Namespaced_IRI.parse _namespace_name "hasAgent" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/event.owl#agent_in"></see>
    /// </summary>
    let agent_in = Namespaced_IRI.parse _namespace_name "agent_in" |> NamespacedName
    /// <summary>
    ///
    /// 		Relates an event to a passive factor (a tool, an instrument, an abstract cause...)
    ///
    /// <see href="http://purl.org/NET/c4dm/event.owl#factor"></see></summary>
    let factor = Namespaced_IRI.parse _namespace_name "factor" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/event.owl#hasFactor"></see>
    /// </summary>
    let hasFactor = Namespaced_IRI.parse _namespace_name "hasFactor" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/event.owl#hasLiteralFactor"></see>
    /// </summary>
    let hasLiteralFactor =
        Namespaced_IRI.parse _namespace_name "hasLiteralFactor" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/event.owl#hasProduct"></see>
    /// </summary>
    let hasProduct = Namespaced_IRI.parse _namespace_name "hasProduct" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/event.owl#hasSubEvent"></see>
    /// </summary>
    let hasSubEvent =
        Namespaced_IRI.parse _namespace_name "hasSubEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/event.owl#isAgentIn"></see>
    /// </summary>
    let isAgentIn = Namespaced_IRI.parse _namespace_name "isAgentIn" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/event.owl#isFactorOf"></see>
    /// </summary>
    let isFactorOf = Namespaced_IRI.parse _namespace_name "isFactorOf" |> NamespacedName

    /// <summary>
    ///
    /// 		Relates an event to a factor which can be described as a literal. This property
    /// 		should not be used as-is, but should be subsumed by other, more specific, properties
    /// 		(like an hypothetic :weatherCelsius, linking an event to a temperature).
    ///
    /// <see href="http://purl.org/NET/c4dm/event.owl#literal_factor"></see></summary>
    let literal_factor =
        Namespaced_IRI.parse _namespace_name "literal_factor" |> NamespacedName

    /// <summary>
    ///
    /// 		Relates an event to a spatial object.
    ///
    /// <see href="http://purl.org/NET/c4dm/event.owl#place"></see></summary>
    let place = Namespaced_IRI.parse _namespace_name "place" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/NET/c4dm/event.owl#producedIn"></see>
    /// </summary>
    let producedIn = Namespaced_IRI.parse _namespace_name "producedIn" |> NamespacedName
    /// <summary>
    ///
    /// 		Relates an event to something produced during the event---a sound, a pie, whatever...
    ///
    /// <see href="http://purl.org/NET/c4dm/event.owl#product"></see></summary>
    let product = Namespaced_IRI.parse _namespace_name "product" |> NamespacedName
    /// <summary>
    ///
    /// 		This property provides a way to split a complex event (for example, a performance involving several
    /// 		musicians) into simpler ones (one event per musician).
    ///
    /// <see href="http://purl.org/NET/c4dm/event.owl#sub_event"></see></summary>
    let sub_event = Namespaced_IRI.parse _namespace_name "sub_event" |> NamespacedName
    /// <summary>
    ///
    /// 		Relates an event to a time object, classifying a time region (either instantaneous or having an extent).
    /// 		By using the Timeline ontology here, you can define event happening on a recorded track or on any
    /// 		media with a temporal extent.
    ///
    /// <see href="http://purl.org/NET/c4dm/event.owl#time"></see></summary>
    let time = Namespaced_IRI.parse _namespace_name "time" |> NamespacedName
