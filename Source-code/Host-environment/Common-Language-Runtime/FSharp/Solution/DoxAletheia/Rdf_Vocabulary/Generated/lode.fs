namespace http.linkedevents.org.ontology.slash

open DoxAletheia

module lode =
    let _namespace_name = "http://linkedevents.org/ontology/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://linkedevents.org/ontology/rdfxml/"></see>
    /// </summary>
    let ``rdfxml/`` = _prefix "rdfxml/"
    /// <summary>
    ///   <see href="http://linkedevents.org/ontology/html/"></see>
    /// </summary>
    let ``html/`` = _prefix "html/"
    /// <summary>
    ///
    /// An event consists of some temporal and spatial boundaries subjectively
    /// imposed on the flux of reality or imagination, that we wish to treat
    /// as an entity for the purposes of making statements about it. In
    /// particular, we may wish to make statements that relate people, places,
    /// or things to an event.
    ///
    /// Note that, unlike some defintions of "event," this definition does not
    /// specify that an event involves a change of state, nor does it attempt
    /// to distinguish events from processes or states.
    /// <see href="http://linkedevents.org/ontology/Event"></see></summary>
    let Event = _prefix "Event"
    /// <summary>
    ///
    /// This property relates an event to some meaningful place, which may
    /// have a name (e.g. "Paris") or may be defined relative to some other
    /// entity or entities (e.g. "the unincorporated area between Carson and
    /// Harbor Gateway"). An event may be related to more than one such
    /// place.
    /// <see href="http://linkedevents.org/ontology/atPlace"></see></summary>
    let atPlace = _prefix "atPlace"
    /// <summary>
    ///
    /// Equivalent definitions from other ontologies:
    ///
    /// * C4DM Event ontology: "Relates an event to a time object, classifying
    ///   a time region (either instantaneous or having an extent)."
    ///
    /// This property relates an event to some subjectively imposed temporal
    /// boundaries, i.e. a span of time. An event can be related to only one
    /// such span of time.
    /// <see href="http://linkedevents.org/ontology/atTime"></see></summary>
    let atTime = _prefix "atTime"
    /// <summary>
    ///
    /// This property relates a span of time that cannot be precisely located
    /// in a chronological series to another span of time that can be
    /// precisely located, thus asserting that the latter is an approximation
    /// of the former.
    /// An temporal relation expressing nearness in time.
    /// <see href="http://linkedevents.org/ontology/circa"></see></summary>
    let circa = _prefix "circa"
    /// <summary>
    ///
    /// This property relates any thing (typically a media object) to an event which it
    /// illustrates, documents or comments upon.
    /// <see href="http://linkedevents.org/ontology/illustrate"></see></summary>
    let illustrate = _prefix "illustrate"
    /// <summary>
    ///
    /// This property relates an event to some subjectively imposed spatial
    /// boundaries, i.e. a region of space. An event can be related to only
    /// one such region of space.
    ///
    /// Note that a statement that relates an event to a region of space using
    /// this property only asserts that an event occurred somewhere within
    /// the region and does not assert that it occurred everywhere within the
    /// region.
    /// <see href="http://linkedevents.org/ontology/inSpace"></see></summary>
    let inSpace = _prefix "inSpace"
    /// <summary>
    ///
    /// This property relates an event to any physical, social, or mental
    /// object or substance. It does not imply any causal relationship or
    /// influence or any other kind of explanatory relationship such as
    /// creation, destruction, etc.
    /// <see href="http://linkedevents.org/ontology/involved"></see></summary>
    let involved = _prefix "involved"
    /// <summary>
    ///
    /// This property relates an event to anything with agency, such as a
    /// (legal or natural) person, a group, an organization, a computational
    /// agent, etc. It does not imply any causal relationship, influence,
    /// intentionality, etc.
    /// <see href="http://linkedevents.org/ontology/involvedAgent"></see></summary>
    let involvedAgent = _prefix "involvedAgent"
