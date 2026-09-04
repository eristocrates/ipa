#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module stories =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/ontology/stories/" "stories"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : Contains a set of statements in the form of an RDF graph, thus allowing for interpretations to assert beliefs about the state of the system.</para>
    ///   <para>rdfs:label : Assertion</para>
    ///   <a href="http://purl.org/ontology/stories/Assertion">stories:Assertion</a>
    /// </summary>
    let Assertion = _prefixId.prefix "Assertion"
    /// <summary>
    ///   <para>rdfs:comment : Provides a means to create an ordered list of events that occur within a story - effectively a pairing of an Event and a numeric position.</para>
    ///   <para>rdfs:label : EventList</para>
    ///   <a href="http://purl.org/ontology/stories/EventList">stories:EventList</a>
    /// </summary>
    let EventList = _prefixId.prefix "EventList"
    /// <summary>
    ///   <para>rdfs:comment : Places an Event in an EventList, with index and neighbouring Event information.</para>
    ///   <para>rdfs:label : EventSlot</para>
    ///   <a href="http://purl.org/ontology/stories/EventSlot">stories:EventSlot</a>
    /// </summary>
    let EventSlot = _prefixId.prefix "EventSlot"
    /// <summary>
    ///   <para>rdfs:comment : An interpretation of something in the context of a story, given some supporting material. This is the viewpoint of the interpretation's creator, and may assert statements about the item.</para>
    ///   <para>rdfs:label : Interpretation</para>
    ///   <a href="http://purl.org/ontology/stories/Interpretation">stories:Interpretation</a>
    /// </summary>
    let Interpretation = _prefixId.prefix "Interpretation"
    /// <summary>
    ///   <para>rdfs:comment : A story that may be told, contain other stories, and have a sequence of events.</para>
    ///   <para>rdfs:label : Story</para>
    ///   <a href="http://purl.org/ontology/stories/Story">stories:Story</a>
    /// </summary>
    let Story = _prefixId.prefix "Story"
    /// <summary>
    ///   <para>rdfs:comment : The Assertion which is asserted by this interpretation.</para>
    ///   <para>rdfs:label : asserts</para>
    ///   <a href="http://purl.org/ontology/stories/asserts">stories:asserts</a>
    /// </summary>
    let asserts = _prefixId.prefix "asserts"
    /// <summary>
    ///   <para>rdfs:label : contextualises</para>
    ///   <a href="http://purl.org/ontology/stories/contextualises">stories:contextualises</a>
    /// </summary>
    let contextualises = _prefixId.prefix "contextualises"
    /// <summary>
    ///   <para>rdfs:comment : The inverse of describes, this is an Event describedBy a Thing (e.g. a programme, photo)</para>
    ///   <para>rdfs:label : describedBy</para>
    ///   <a href="http://purl.org/ontology/stories/describedBy">stories:describedBy</a>
    /// </summary>
    let describedBy = _prefixId.prefix "describedBy"
    /// <summary>
    ///   <para>rdfs:comment : A Thing which describes an Event. This could be a Media Fragment, an Image, etc.</para>
    ///   <para>rdfs:label : describes</para>
    ///   <a href="http://purl.org/ontology/stories/describes">stories:describes</a>
    /// </summary>
    let describes = _prefixId.prefix "describes"
    /// <summary>
    ///   <para>rdfs:comment : An ordered list of Events within this story.</para>
    ///   <para>rdfs:label : event</para>
    ///   <a href="http://purl.org/ontology/stories/events">stories:events</a>
    /// </summary>
    let events = _prefixId.prefix "events"
    /// <summary>
    ///   <para>rdfs:comment : Facts asserted by this assertion, in the form of an RDF graph.^^xsd:string</para>
    ///   <para>rdfs:label : facts^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/stories/facts">stories:facts</a>
    /// </summary>
    let facts = _prefixId.prefix "facts"
    /// <summary>
    ///   <para>rdfs:comment : The thing which is interpreted by this interpretation.</para>
    ///   <para>rdfs:label : interprets</para>
    ///   <a href="http://purl.org/ontology/stories/interprets">stories:interprets</a>
    /// </summary>
    let interprets = _prefixId.prefix "interprets"
    /// <summary>
    ///   <para>rdfs:label : item</para>
    ///   <a href="http://purl.org/ontology/stories/item">stories:item</a>
    /// </summary>
    let item = _prefixId.prefix "item"
    /// <summary>
    ///   <para>rdfs:label : slot</para>
    ///   <a href="http://purl.org/ontology/stories/slot">stories:slot</a>
    /// </summary>
    let slot = _prefixId.prefix "slot"
    /// <summary>
    ///   <para>rdfs:comment : A story which is contained within this story. For example, a TV episode may contain stories for different characters, or one overarching story may contain several other smaller stories.</para>
    ///   <para>rdfs:label : sub_story</para>
    ///   <a href="http://purl.org/ontology/stories/sub_story">stories:sub_story</a>
    /// </summary>
    let sub_story = _prefixId.prefix "sub_story"
    /// <summary>
    ///   <para>rdfs:comment : The subject(s) of the story. e.g. characters, events, skos concepts.</para>
    ///   <para>rdfs:label : subject</para>
    ///   <a href="http://purl.org/ontology/stories/subject">stories:subject</a>
    /// </summary>
    let subject = _prefixId.prefix "subject"
    /// <summary>
    ///   <para>rdfs:comment : A Thing which supports an Interpretation (e.g. a supporting document, Event, etc).</para>
    ///   <para>rdfs:label : supports</para>
    ///   <a href="http://purl.org/ontology/stories/supports">stories:supports</a>
    /// </summary>
    let supports = _prefixId.prefix "supports"
    /// <summary>
    ///   <para>rdfs:comment : A story told by this Thing. The Thing could be a photograph which has a story attached to it, a person, a country, a monument, etc.</para>
    ///   <para>rdfs:label : tells</para>
    ///   <a href="http://purl.org/ontology/stories/tells">stories:tells</a>
    /// </summary>
    let tells = _prefixId.prefix "tells"
