#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module nsl =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/ontology/storyline/" "nsl"

    let ``_0.2`` = _prefixId.prefix "0.2"
    let ``_0.3`` = _prefixId.prefix "0.3"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Attribution</para>
    ///   <para>rdfs:comment : Attribution of a storyline used for attributing the interpretation of the storyline to some agent. An interface class, that doesn't restrict the implementation of an attribution.</para>
    ///   <a href="http://purl.org/ontology/storyline/Attribution">nsl:Attribution</a>
    /// </summary>
    let Attribution = _prefixId.prefix "Attribution"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Event</para>
    ///   <para>rdfs:comment : A newsworthy event. An un-disputable real world event.</para>
    ///   <a href="http://purl.org/ontology/storyline/Event">nsl:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Storyline</para>
    ///   <para>rdfs:comment : A news storyline.</para>
    ///   <a href="http://purl.org/ontology/storyline/Storyline">nsl:Storyline</a>
    /// </summary>
    let Storyline = _prefixId.prefix "Storyline"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : StorylineComponent</para>
    ///   <para>rdfs:comment : An abstract parent class of storyline components.</para>
    ///   <a href="http://purl.org/ontology/storyline/StorylineComponent">nsl:StorylineComponent</a>
    /// </summary>
    let StorylineComponent = _prefixId.prefix "StorylineComponent"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : StorylineSlot</para>
    ///   <para>rdfs:comment : A storyline slot, used as a container for storyline components.</para>
    ///   <a href="http://purl.org/ontology/storyline/StorylineSlot">nsl:StorylineSlot</a>
    /// </summary>
    let StorylineSlot = _prefixId.prefix "StorylineSlot"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : Topic</para>
    ///   <para>rdfs:comment : The topic of a storyline. An interface to some concept in a knowledge domain.</para>
    ///   <a href="http://purl.org/ontology/storyline/Topic">nsl:Topic</a>
    /// </summary>
    let Topic = _prefixId.prefix "Topic"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : attributedTo</para>
    ///   <para>rdfs:comment : Associates a storyline to its attribution. Provides for interpretation provenance through attribution</para>
    ///   <a href="http://purl.org/ontology/storyline/attributedTo">nsl:attributedTo</a>
    /// </summary>
    let attributedTo = _prefixId.prefix "attributedTo"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : comment</para>
    ///   <para>rdfs:comment : An editorial comment on a storyline</para>
    ///   <a href="http://purl.org/ontology/storyline/comment">nsl:comment</a>
    /// </summary>
    let comment = _prefixId.prefix "comment"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : contains</para>
    ///   <para>rdfs:comment : Associates a Slot to a StorylineComponent contained therein. Can be a news event or another storyline</para>
    ///   <a href="http://purl.org/ontology/storyline/contains">nsl:contains</a>
    /// </summary>
    let contains = _prefixId.prefix "contains"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : dateCreated</para>
    ///   <para>rdfs:comment : The date a storyline was created</para>
    ///   <a href="http://purl.org/ontology/storyline/dateCreated">nsl:dateCreated</a>
    /// </summary>
    let dateCreated = _prefixId.prefix "dateCreated"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : follows</para>
    ///   <para>rdfs:comment : Allows one or more slots to be sequenced. Slot A follows Slot B.</para>
    ///   <a href="http://purl.org/ontology/storyline/follows">nsl:follows</a>
    /// </summary>
    let follows = _prefixId.prefix "follows"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hasChapter</para>
    ///   <para>rdfs:comment : Associates a slot to a storyline as a chapter of an existing storyline.</para>
    ///   <a href="http://purl.org/ontology/storyline/hasChapter">nsl:hasChapter</a>
    /// </summary>
    let hasChapter = _prefixId.prefix "hasChapter"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hasDevelopment</para>
    ///   <para>rdfs:comment : Associates a slot to a storyline as a development of an existing storyline.</para>
    ///   <a href="http://purl.org/ontology/storyline/hasDevelopment">nsl:hasDevelopment</a>
    /// </summary>
    let hasDevelopment = _prefixId.prefix "hasDevelopment"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hasSlot</para>
    ///   <para>rdfs:comment : Associates a slot to a storyline. A storyline can have many slots</para>
    ///   <a href="http://purl.org/ontology/storyline/hasSlot">nsl:hasSlot</a>
    /// </summary>
    let hasSlot = _prefixId.prefix "hasSlot"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : hasUpdate</para>
    ///   <para>rdfs:comment : Associates a slot to a storyline as an update to an existing storyline.</para>
    ///   <a href="http://purl.org/ontology/storyline/hasUpdate">nsl:hasUpdate</a>
    /// </summary>
    let hasUpdate = _prefixId.prefix "hasUpdate"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : index</para>
    ///   <para>rdfs:comment : A slot index. Allows slots to be ordered numerically</para>
    ///   <a href="http://purl.org/ontology/storyline/index">nsl:index</a>
    /// </summary>
    let index = _prefixId.prefix "index"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : synopsis</para>
    ///   <para>rdfs:comment : The synopsis of a storyline</para>
    ///   <a href="http://purl.org/ontology/storyline/synopsis">nsl:synopsis</a>
    /// </summary>
    let synopsis = _prefixId.prefix "synopsis"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : time</para>
    ///   <para>rdfs:comment : The time of a slot. A Temporal entity, an interval. Allows slots to be ordered temporally.</para>
    ///   <a href="http://purl.org/ontology/storyline/time">nsl:time</a>
    /// </summary>
    let time = _prefixId.prefix "time"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : title</para>
    ///   <para>rdfs:comment : A title of a storyline</para>
    ///   <a href="http://purl.org/ontology/storyline/title">nsl:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:label : topic</para>
    ///   <para>rdfs:comment : Associates a slot to a topic</para>
    ///   <a href="http://purl.org/ontology/storyline/topic">nsl:topic</a>
    /// </summary>
    let topic = _prefixId.prefix "topic"
