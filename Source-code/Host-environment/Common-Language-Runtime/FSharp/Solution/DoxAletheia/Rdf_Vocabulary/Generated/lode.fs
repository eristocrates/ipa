namespace http.linkedevents.org.ontology.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module lode =
    let _namespace_iri = Namespace_Iri lode |> NamespaceIRI
    /// <summary>
    ///   <para>lode:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"
    /// This document describes an ontology for publishing descriptions of
    /// historical events as Linked Data, and for mapping between other
    /// event-related vocabularies and ontologies."</para>
    /// labels<para>"LODE: An ontology for Linking Open Descriptions of Events"</para></remarks>
    /// <seealso href="http://linkedevents.org/ontology/">http://linkedevents.org/ontology/</seealso>
    let _prefix_iri = Prefixed_Name(lode, "") |> PrefixedName
    /// <summary>
    ///   <para>lode:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"
    /// An event consists of some temporal and spatial boundaries subjectively
    /// imposed on the flux of reality or imagination, that we wish to treat
    /// as an entity for the purposes of making statements about it. In
    /// particular, we may wish to make statements that relate people, places,
    /// or things to an event."</para>
    ///   <para>"
    /// Note that, unlike some defintions of "event," this definition does not
    /// specify that an event involves a change of state, nor does it attempt
    /// to distinguish events from processes or states."</para>
    /// labels<para>"Event"</para></remarks>
    /// <seealso href="http://linkedevents.org/ontology/Event">http://linkedevents.org/ontology/Event</seealso>
    let Event = Prefixed_Name(lode, "Event") |> PrefixedName
    /// <summary>
    ///   <para>lode:atPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"
    /// This property relates an event to some meaningful place, which may
    /// have a name (e.g. "Paris") or may be defined relative to some other
    /// entity or entities (e.g. "the unincorporated area between Carson and
    /// Harbor Gateway"). An event may be related to more than one such
    /// place."</para>
    /// labels<para>"at place"</para></remarks>
    /// <seealso href="http://linkedevents.org/ontology/atPlace">http://linkedevents.org/ontology/atPlace</seealso>
    let atPlace = Prefixed_Name(lode, "atPlace") |> PrefixedName
    /// <summary>
    ///   <para>lode:atTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"
    /// This property relates an event to some subjectively imposed temporal
    /// boundaries, i.e. a span of time. An event can be related to only one
    /// such span of time."</para>
    ///   <para>"
    /// Equivalent definitions from other ontologies:
    ///
    /// * C4DM Event ontology: "Relates an event to a time object, classifying
    ///   a time region (either instantaneous or having an extent).""</para>
    /// labels<para>"at time"</para></remarks>
    /// <seealso href="http://linkedevents.org/ontology/atTime">http://linkedevents.org/ontology/atTime</seealso>
    let atTime = Prefixed_Name(lode, "atTime") |> PrefixedName
    /// <summary>
    ///   <para>lode:circa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An temporal relation expressing nearness in time."</para>
    ///   <para>"
    /// This property relates a span of time that cannot be precisely located
    /// in a chronological series to another span of time that can be
    /// precisely located, thus asserting that the latter is an approximation
    /// of the former."</para>
    /// labels<para>"circa"</para></remarks>
    /// <seealso href="http://linkedevents.org/ontology/circa">http://linkedevents.org/ontology/circa</seealso>
    let circa = Prefixed_Name(lode, "circa") |> PrefixedName
    /// <summary>
    ///   <para>lode:html/</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:IMT</para>
    ///
    /// labels<para>"HTML"</para></remarks>
    /// <seealso href="http://linkedevents.org/ontology/html/">http://linkedevents.org/ontology/html/</seealso>
    let ``html/`` = Prefixed_Name(lode, "html/") |> PrefixedName
    /// <summary>
    ///   <para>lode:illustrate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"
    /// This property relates any thing (typically a media object) to an event which it
    /// illustrates, documents or comments upon."</para>
    /// labels<para>"illustrate"</para></remarks>
    /// <seealso href="http://linkedevents.org/ontology/illustrate">http://linkedevents.org/ontology/illustrate</seealso>
    let illustrate = Prefixed_Name(lode, "illustrate") |> PrefixedName
    /// <summary>
    ///   <para>lode:inSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"
    /// Note that a statement that relates an event to a region of space using
    /// this property only asserts that an event occurred somewhere within
    /// the region and does not assert that it occurred everywhere within the
    /// region."</para>
    ///   <para>"
    /// This property relates an event to some subjectively imposed spatial
    /// boundaries, i.e. a region of space. An event can be related to only
    /// one such region of space."</para>
    /// labels<para>"in space"</para></remarks>
    /// <seealso href="http://linkedevents.org/ontology/inSpace">http://linkedevents.org/ontology/inSpace</seealso>
    let inSpace = Prefixed_Name(lode, "inSpace") |> PrefixedName
    /// <summary>
    ///   <para>lode:involved</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"
    /// This property relates an event to any physical, social, or mental
    /// object or substance. It does not imply any causal relationship or
    /// influence or any other kind of explanatory relationship such as
    /// creation, destruction, etc."</para>
    /// labels<para>"involved"</para></remarks>
    /// <seealso href="http://linkedevents.org/ontology/involved">http://linkedevents.org/ontology/involved</seealso>
    let involved = Prefixed_Name(lode, "involved") |> PrefixedName
    /// <summary>
    ///   <para>lode:involvedAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"
    /// This property relates an event to anything with agency, such as a
    /// (legal or natural) person, a group, an organization, a computational
    /// agent, etc. It does not imply any causal relationship, influence,
    /// intentionality, etc."</para>
    /// labels<para>"involved agent"</para></remarks>
    /// <seealso href="http://linkedevents.org/ontology/involvedAgent">http://linkedevents.org/ontology/involvedAgent</seealso>
    let involvedAgent = Prefixed_Name(lode, "involvedAgent") |> PrefixedName
    /// <summary>
    ///   <para>lode:rdfxml/</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcterms:IMT</para>
    ///
    /// labels<para>"RDF/XML"</para></remarks>
    /// <seealso href="http://linkedevents.org/ontology/rdfxml/">http://linkedevents.org/ontology/rdfxml/</seealso>
    let ``rdfxml/`` = Prefixed_Name(lode, "rdfxml/") |> PrefixedName
