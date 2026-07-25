namespace http.purl.org.ontology.storyline.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module nsl =
    let _namespace_iri = Namespace_Iri nsl |> NamespaceIRI
    /// <summary>
    ///   <para>nsl:StorylineComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An abstract parent class of storyline components.</para>
    /// labels<para>StorylineComponent</para></remarks>
    /// <seealso href="http://purl.org/ontology/storyline/StorylineComponent">http://purl.org/ontology/storyline/StorylineComponent</seealso>
    let StorylineComponent = Prefixed_Name(nsl, "StorylineComponent") |> PrefixedName
    /// <summary>
    ///   <para>nsl:Topic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The topic of a storyline. An interface to some concept in a knowledge domain.</para>
    /// labels<para>Topic</para></remarks>
    /// <seealso href="http://purl.org/ontology/storyline/Topic">http://purl.org/ontology/storyline/Topic</seealso>
    let Topic = Prefixed_Name(nsl, "Topic") |> PrefixedName
    /// <summary>
    ///   <para>nsl:Storyline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A news storyline.</para>
    /// labels<para>Storyline</para></remarks>
    /// <seealso href="http://purl.org/ontology/storyline/Storyline">http://purl.org/ontology/storyline/Storyline</seealso>
    let Storyline = Prefixed_Name(nsl, "Storyline") |> PrefixedName
    /// <summary>
    ///   <para>nsl:StorylineSlot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A storyline slot, used as a container for storyline components.</para>
    /// labels<para>StorylineSlot</para></remarks>
    /// <seealso href="http://purl.org/ontology/storyline/StorylineSlot">http://purl.org/ontology/storyline/StorylineSlot</seealso>
    let StorylineSlot = Prefixed_Name(nsl, "StorylineSlot") |> PrefixedName
    /// <summary>
    ///   <para>nsl:Attribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Attribution of a storyline used for attributing the interpretation of the storyline to some agent. An interface class, that doesn't restrict the implementation of an attribution.</para>
    /// labels<para>Attribution</para></remarks>
    /// <seealso href="http://purl.org/ontology/storyline/Attribution">http://purl.org/ontology/storyline/Attribution</seealso>
    let Attribution = Prefixed_Name(nsl, "Attribution") |> PrefixedName
    /// <summary>
    ///   <para>nsl:0.3</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/ontology/storyline/0.3">http://purl.org/ontology/storyline/0.3</seealso>
    let ``_0.3`` = Prefixed_Name(nsl, "0.3") |> PrefixedName
    /// <summary>
    ///   <para>nsl:contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a Slot to a StorylineComponent contained therein. Can be a news event or another storyline</para>
    /// labels<para>contains</para></remarks>
    /// <seealso href="http://purl.org/ontology/storyline/contains">http://purl.org/ontology/storyline/contains</seealso>
    let contains = Prefixed_Name(nsl, "contains") |> PrefixedName
    /// <summary>
    ///   <para>nsl:attributedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a storyline to its attribution. Provides for interpretation provenance through attribution</para>
    /// labels<para>attributedTo</para></remarks>
    /// <seealso href="http://purl.org/ontology/storyline/attributedTo">http://purl.org/ontology/storyline/attributedTo</seealso>
    let attributedTo = Prefixed_Name(nsl, "attributedTo") |> PrefixedName
    /// <summary>
    ///   <para>nsl:dateCreated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date a storyline was created</para>
    /// labels<para>dateCreated</para></remarks>
    /// <seealso href="http://purl.org/ontology/storyline/dateCreated">http://purl.org/ontology/storyline/dateCreated</seealso>
    let dateCreated = Prefixed_Name(nsl, "dateCreated") |> PrefixedName
    /// <summary>
    ///   <para>nsl:follows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Allows one or more slots to be sequenced. Slot A follows Slot B.</para>
    /// labels<para>follows</para></remarks>
    /// <seealso href="http://purl.org/ontology/storyline/follows">http://purl.org/ontology/storyline/follows</seealso>
    let follows = Prefixed_Name(nsl, "follows") |> PrefixedName
    /// <summary>
    ///   <para>nsl:comment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>An editorial comment on a storyline</para>
    /// labels<para>comment</para></remarks>
    /// <seealso href="http://purl.org/ontology/storyline/comment">http://purl.org/ontology/storyline/comment</seealso>
    let comment = Prefixed_Name(nsl, "comment") |> PrefixedName
    /// <summary>
    ///   <para>nsl:hasChapter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a slot to a storyline as a chapter of an existing storyline.</para>
    /// labels<para>hasChapter</para></remarks>
    /// <seealso href="http://purl.org/ontology/storyline/hasChapter">http://purl.org/ontology/storyline/hasChapter</seealso>
    let hasChapter = Prefixed_Name(nsl, "hasChapter") |> PrefixedName
    /// <summary>
    ///   <para>nsl:hasDevelopment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a slot to a storyline as a development of an existing storyline.</para>
    /// labels<para>hasDevelopment</para></remarks>
    /// <seealso href="http://purl.org/ontology/storyline/hasDevelopment">http://purl.org/ontology/storyline/hasDevelopment</seealso>
    let hasDevelopment = Prefixed_Name(nsl, "hasDevelopment") |> PrefixedName
    /// <summary>
    ///   <para>nsl:hasUpdate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a slot to a storyline as an update to an existing storyline.</para>
    /// labels<para>hasUpdate</para></remarks>
    /// <seealso href="http://purl.org/ontology/storyline/hasUpdate">http://purl.org/ontology/storyline/hasUpdate</seealso>
    let hasUpdate = Prefixed_Name(nsl, "hasUpdate") |> PrefixedName
    /// <summary>
    ///   <para>nsl:hasSlot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a slot to a storyline. A storyline can have many slots</para>
    /// labels<para>hasSlot</para></remarks>
    /// <seealso href="http://purl.org/ontology/storyline/hasSlot">http://purl.org/ontology/storyline/hasSlot</seealso>
    let hasSlot = Prefixed_Name(nsl, "hasSlot") |> PrefixedName
    /// <summary>
    ///   <para>nsl:index</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A slot index. Allows slots to be ordered numerically</para>
    /// labels<para>index</para></remarks>
    /// <seealso href="http://purl.org/ontology/storyline/index">http://purl.org/ontology/storyline/index</seealso>
    let index = Prefixed_Name(nsl, "index") |> PrefixedName
    /// <summary>
    ///   <para>nsl:time</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The time of a slot. A Temporal entity, an interval. Allows slots to be ordered temporally.</para>
    /// labels<para>time</para></remarks>
    /// <seealso href="http://purl.org/ontology/storyline/time">http://purl.org/ontology/storyline/time</seealso>
    let time = Prefixed_Name(nsl, "time") |> PrefixedName
    /// <summary>
    ///   <para>nsl:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A title of a storyline</para>
    /// labels<para>title</para></remarks>
    /// <seealso href="http://purl.org/ontology/storyline/title">http://purl.org/ontology/storyline/title</seealso>
    let title = Prefixed_Name(nsl, "title") |> PrefixedName
    /// <summary>
    ///   <para>nsl:synopsis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The synopsis of a storyline</para>
    /// labels<para>synopsis</para></remarks>
    /// <seealso href="http://purl.org/ontology/storyline/synopsis">http://purl.org/ontology/storyline/synopsis</seealso>
    let synopsis = Prefixed_Name(nsl, "synopsis") |> PrefixedName
    /// <summary>
    ///   <para>nsl:topic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a slot to a topic</para>
    /// labels<para>topic</para></remarks>
    /// <seealso href="http://purl.org/ontology/storyline/topic">http://purl.org/ontology/storyline/topic</seealso>
    let topic = Prefixed_Name(nsl, "topic") |> PrefixedName
    /// <summary>
    ///   <para>nsl:0.2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/ontology/storyline/0.2">http://purl.org/ontology/storyline/0.2</seealso>
    let ``_0.2`` = Prefixed_Name(nsl, "0.2") |> PrefixedName
    /// <summary>
    ///   <para>nsl:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A newsworthy event. An un-disputable real world event.</para>
    /// labels<para>Event</para></remarks>
    /// <seealso href="http://purl.org/ontology/storyline/Event">http://purl.org/ontology/storyline/Event</seealso>
    let Event = Prefixed_Name(nsl, "Event") |> PrefixedName
