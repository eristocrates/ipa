#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module event =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/NET/c4dm/event.owl#" "event"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		An arbitrary classification of a space/time region, by a
    /// 		cognitive agent. An event may have actively participating agents,
    /// 		passive factors, products, and a location in space/time.
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Event^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/event.owl#Event">event:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		Everything used as a factor in an event
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Factor^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/event.owl#Factor">event:Factor</a>
    /// </summary>
    let Factor = _prefixId.prefix "Factor"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// 		Everything produced by an event
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : Product^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/event.owl#Product">event:Product</a>
    /// </summary>
    let Product = _prefixId.prefix "Product"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		Relates an event to an active agent (a person, a computer, ... :-) )
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : agent^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/event.owl#agent">event:agent</a>
    /// </summary>
    let agent = _prefixId.prefix "agent"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/event.owl#agent_in">event:agent_in</a>
    /// </summary>
    let agent_in = _prefixId.prefix "agent_in"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		Relates an event to a passive factor (a tool, an instrument, an abstract cause...)
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : factor^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/event.owl#factor">event:factor</a>
    /// </summary>
    let factor = _prefixId.prefix "factor"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/event.owl#factor_of">event:factor_of</a>
    /// </summary>
    let factor_of = _prefixId.prefix "factor_of"
    /// <summary>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/event.owl#hasAgent">event:hasAgent</a>
    /// </summary>
    let hasAgent = _prefixId.prefix "hasAgent"
    /// <summary>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/event.owl#hasFactor">event:hasFactor</a>
    /// </summary>
    let hasFactor = _prefixId.prefix "hasFactor"
    /// <summary>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/event.owl#hasLiteralFactor">event:hasLiteralFactor</a>
    /// </summary>
    let hasLiteralFactor = _prefixId.prefix "hasLiteralFactor"
    /// <summary>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/event.owl#hasProduct">event:hasProduct</a>
    /// </summary>
    let hasProduct = _prefixId.prefix "hasProduct"
    /// <summary>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/event.owl#hasSubEvent">event:hasSubEvent</a>
    /// </summary>
    let hasSubEvent = _prefixId.prefix "hasSubEvent"
    /// <summary>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <para>rdfs:label : agent in^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/event.owl#isAgentIn">event:isAgentIn</a>
    /// </summary>
    let isAgentIn = _prefixId.prefix "isAgentIn"
    /// <summary>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <para>rdfs:label : factor of^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/event.owl#isFactorOf">event:isFactorOf</a>
    /// </summary>
    let isFactorOf = _prefixId.prefix "isFactorOf"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		Relates an event to a factor which can be described as a literal. This property
    /// 		should not be used as-is, but should be subsumed by other, more specific, properties
    /// 		(like an hypothetic :weatherCelsius, linking an event to a temperature).
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : literal factor^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/event.owl#literal_factor">event:literal_factor</a>
    /// </summary>
    let literal_factor = _prefixId.prefix "literal_factor"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		Relates an event to a spatial object.
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : place^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/event.owl#place">event:place</a>
    /// </summary>
    let place = _prefixId.prefix "place"
    /// <summary>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <para>rdfs:label : produced in^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/event.owl#producedIn">event:producedIn</a>
    /// </summary>
    let producedIn = _prefixId.prefix "producedIn"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/event.owl#produced_in">event:produced_in</a>
    /// </summary>
    let produced_in = _prefixId.prefix "produced_in"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		Relates an event to something produced during the event---a sound, a pie, whatever...
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : product^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/event.owl#product">event:product</a>
    /// </summary>
    let product = _prefixId.prefix "product"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		This property provides a way to split a complex event (for example, a performance involving several
    /// 		musicians) into simpler ones (one event per musician).
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : sub-event^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/event.owl#sub_event">event:sub_event</a>
    /// </summary>
    let sub_event = _prefixId.prefix "sub_event"
    /// <summary>
    ///   <para>rdfs:comment :
    /// 		Relates an event to a time object, classifying a time region (either instantaneous or having an extent).
    /// 		By using the Timeline ontology here, you can define event happening on a recorded track or on any
    /// 		media with a temporal extent.
    /// 		^^xsd:string</para>
    ///   <para>rdfs:label : time^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://purl.org/NET/c4dm/event.owl#time">event:time</a>
    /// </summary>
    let time = _prefixId.prefix "time"
