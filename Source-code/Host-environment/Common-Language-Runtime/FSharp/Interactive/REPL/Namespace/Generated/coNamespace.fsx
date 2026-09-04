#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module co =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/ontology/co/core#" "co"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : Counter</para>
    ///   <para>rdfs:comment : Counter of a given object/ given objects, which are related to that counter.</para>
    ///   <a href="http://purl.org/ontology/co/core#Counter">co:Counter</a>
    /// </summary>
    let Counter = _prefixId.prefix "Counter"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : Scrobble Event</para>
    ///   <para>rdfs:comment : An event corresponding to a scrobbling (counting an activity, which includes at least a specific factor and
    /// a specific agent), e.g. a track being played by someone, a video watched by someone, a book read by
    /// someone, a sporting activity by someone, ...</para>
    ///   <a href="http://purl.org/ontology/co/core#ScrobbleEvent">co:ScrobbleEvent</a>
    /// </summary>
    let ScrobbleEvent = _prefixId.prefix "ScrobbleEvent"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : has count</para>
    ///   <para>rdfs:comment : Links a counter resource to the actual count</para>
    ///   <a href="http://purl.org/ontology/co/core#count">co:count</a>
    /// </summary>
    let count = _prefixId.prefix "count"
    /// <summary>
    ///   <para>vs:term_status : stable</para>
    ///   <para>rdfs:label : has counter</para>
    ///   <para>rdfs:comment : Links an object to a counter resource. Please feel free to create further sub properties with more restricted domains.</para>
    ///   <a href="http://purl.org/ontology/co/core#counter">co:counter</a>
    /// </summary>
    let counter = _prefixId.prefix "counter"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has event</para>
    ///   <para>rdfs:comment : Links counter resources to related events.</para>
    ///   <a href="http://purl.org/ontology/co/core#event">co:event</a>
    /// </summary>
    let event_ = _prefixId.prefix "event"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : has event counter</para>
    ///   <para>rdfs:comment : Links events to a counter resource, where they where counted in.</para>
    ///   <a href="http://purl.org/ontology/co/core#event_counter">co:event_counter</a>
    /// </summary>
    let event_counter = _prefixId.prefix "event_counter"
    /// <summary>
    ///   <para>vs:term_status : testing</para>
    ///   <para>rdfs:label : has object</para>
    ///   <para>rdfs:comment : Links a counter resource to an object. Please feel free to create further sub properties with more restricted ranges.</para>
    ///   <a href="http://purl.org/ontology/co/core#object">co:object</a>
    /// </summary>
    let object = _prefixId.prefix "object"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:label : has scrobble object</para>
    ///   <para>rdfs:comment : A scrobble object of a scrobble event, e.g. a music track, a video or a described activity. That means a specific thing that is involved in this scrobbling action.</para>
    ///   <a href="http://purl.org/ontology/co/core#scrobble_object">co:scrobble_object</a>
    /// </summary>
    let scrobble_object = _prefixId.prefix "scrobble_object"
