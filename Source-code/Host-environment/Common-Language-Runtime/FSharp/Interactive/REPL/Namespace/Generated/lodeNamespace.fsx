#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module lode =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://linkedevents.org/ontology/" "lode"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment :
    /// An event consists of some temporal and spatial boundaries subjectively
    /// imposed on the flux of reality or imagination, that we wish to treat
    /// as an entity for the purposes of making statements about it. In
    /// particular, we may wish to make statements that relate people, places,
    /// or things to an event.rdfs:comment :
    /// Note that, unlike some defintions of "event," this definition does not
    /// specify that an event involves a change of state, nor does it attempt
    /// to distinguish events from processes or states.</para>
    ///   <para>dcterms:issued : 2009-07-28^^xsd:date</para>
    ///   <para>rdfs:label : Event</para>
    ///   <para>skos:definition :
    /// "Something that happened," as might be reported in a news article or
    /// explained by a historian.</para>
    ///   <a href="http://linkedevents.org/ontology/Event">lode:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>skos:definition :
    /// a named or relatively specified place that is where
    /// an event happened.</para>
    ///   <para>dcterms:issued : 2009-07-28^^xsd:date</para>
    ///   <para>rdfs:label : at place</para>
    ///   <para>rdfs:comment :
    /// This property relates an event to some meaningful place, which may
    /// have a name (e.g. "Paris") or may be defined relative to some other
    /// entity or entities (e.g. "the unincorporated area between Carson and
    /// Harbor Gateway"). An event may be related to more than one such
    /// place.</para>
    ///   <a href="http://linkedevents.org/ontology/atPlace">lode:atPlace</a>
    /// </summary>
    let atPlace = _prefixId.prefix "atPlace"
    /// <summary>
    ///   <para>dcterms:issued : 2009-07-28^^xsd:date</para>
    ///   <para>skos:definition :
    /// an abstract instant or interval of
    /// time that is when an event happened.</para>
    ///   <para>rdfs:comment :
    /// Equivalent definitions from other ontologies:
    ///
    /// * C4DM Event ontology: "Relates an event to a time object, classifying
    ///   a time region (either instantaneous or having an extent)."rdfs:comment :
    /// This property relates an event to some subjectively imposed temporal
    /// boundaries, i.e. a span of time. An event can be related to only one
    /// such span of time.</para>
    ///   <para>rdfs:label : at time</para>
    ///   <a href="http://linkedevents.org/ontology/atTime">lode:atTime</a>
    /// </summary>
    let atTime = _prefixId.prefix "atTime"
    /// <summary>
    ///   <para>skos:definition :
    /// an interval of time that can be
    /// precisely described using calendar dates and clock times.</para>
    ///   <para>dcterms:issued : 2009-07-28^^xsd:date</para>
    ///   <para>rdfs:label : circa</para>
    ///   <para>rdfs:comment :
    /// This property relates a span of time that cannot be precisely located
    /// in a chronological series to another span of time that can be
    /// precisely located, thus asserting that the latter is an approximation
    /// of the former.rdfs:comment : An temporal relation expressing nearness in time.</para>
    ///   <a href="http://linkedevents.org/ontology/circa">lode:circa</a>
    /// </summary>
    let circa = _prefixId.prefix "circa"
    /// <summary>
    ///   <para>skos:definition :
    /// an event illustrated by some thing (typically a media object)</para>
    ///   <para>dcterms:issued : 2010-10-07^^xsd:date</para>
    ///   <para>rdfs:label : illustrate</para>
    ///   <para>rdfs:comment :
    /// This property relates any thing (typically a media object) to an event which it
    /// illustrates, documents or comments upon.</para>
    ///   <a href="http://linkedevents.org/ontology/illustrate">lode:illustrate</a>
    /// </summary>
    let illustrate = _prefixId.prefix "illustrate"
    /// <summary>
    ///   <para>rdfs:comment :
    /// This property relates an event to some subjectively imposed spatial
    /// boundaries, i.e. a region of space. An event can be related to only
    /// one such region of space.rdfs:comment :
    /// Note that a statement that relates an event to a region of space using
    /// this property only asserts that an event occurred somewhere within
    /// the region and does not assert that it occurred everywhere within the
    /// region.</para>
    ///   <para>rdfs:label : in space</para>
    ///   <para>skos:definition :
    /// an abstract region of space (e.g. a
    /// geospatial point or region) that is where an event happened.</para>
    ///   <para>dcterms:issued : 2009-07-28^^xsd:date</para>
    ///   <a href="http://linkedevents.org/ontology/inSpace">lode:inSpace</a>
    /// </summary>
    let inSpace = _prefixId.prefix "inSpace"
    /// <summary>
    ///   <para>skos:definition :
    /// a (physical, social, or mental) object involved in
    /// an event.</para>
    ///   <para>dcterms:issued : 2009-07-28^^xsd:date</para>
    ///   <para>rdfs:label : involved</para>
    ///   <para>rdfs:comment :
    /// This property relates an event to any physical, social, or mental
    /// object or substance. It does not imply any causal relationship or
    /// influence or any other kind of explanatory relationship such as
    /// creation, destruction, etc.</para>
    ///   <a href="http://linkedevents.org/ontology/involved">lode:involved</a>
    /// </summary>
    let involved = _prefixId.prefix "involved"
    /// <summary>
    ///   <para>skos:definition : an agent involved in an event.</para>
    ///   <para>rdfs:comment :
    /// This property relates an event to anything with agency, such as a
    /// (legal or natural) person, a group, an organization, a computational
    /// agent, etc. It does not imply any causal relationship, influence,
    /// intentionality, etc.</para>
    ///   <para>dcterms:issued : 2009-07-28^^xsd:date</para>
    ///   <para>rdfs:label : involved agent</para>
    ///   <a href="http://linkedevents.org/ontology/involvedAgent">lode:involvedAgent</a>
    /// </summary>
    let involvedAgent = _prefixId.prefix "involvedAgent"
