namespace http.www.loa_cnr.it.ontologies.DOLCE_Lite.owl.hash

open DoxAletheia.Rdf_Vocabulary

module dolce =
    let _namespace_name = "http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#"
    /// <summary>
    /// The main characteristic of abstract entities is that  they do not have spatial nor temporal qualities, and they are not qualities themselves.  The only class of abstract entities we consider in the present version of the upper  ontology is that of quality regions (or simply regions). Quality spaces are special  kinds of quality regions, being mereological sums of all the regions related to a certain quality type. The other examples of abstract entities (sets and facts) are only  indicative.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#abstract"></see></summary>
    let abstract_ = Namespaced_IRI.parse _namespace_name "abstract" |> NamespacedName

    /// <summary>
    /// A physical quality, q-located in (whose value is given within) ordinary spaces (geographical coordinates, cosmological positions, anatomical axes, etc.).
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#spatial-location_q"></see></summary>
    let ``spatial-location_q`` =
        Namespaced_IRI.parse _namespace_name "spatial-location_q" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#has-quality"></see>
    /// </summary>
    let ``has-quality`` =
        Namespaced_IRI.parse _namespace_name "has-quality" |> NamespacedName

    /// <summary>
    /// AKA 'entity'.Any individual in the DOLCE domain of discourse. The extensional coverage of DOLCE is as large as possible, since it ranges on 'possibilia', i.e all possible individuals that can be postulated by means of DOLCE axioms. Possibilia include physical objects, substances, processes, qualities,  conceptual regions, non-physical objects, collections and even arbitrary sums of objects.The class 'particular' features a covering partition that includes: endurant, perdurant, quality, and abstract. There are also some subclasses defined as unions of subclasses of 'particular' for special purposes: spatio-temporal-particular (any particular except abstracts)- physical-realization (any realization of an information object, defined in the ExtendedDnS ontology).
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#particular"></see></summary>
    let particular = Namespaced_IRI.parse _namespace_name "particular" |> NamespacedName

    /// <summary>
    /// A temporal location quality.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#temporal-location_q"></see></summary>
    let ``temporal-location_q`` =
        Namespaced_IRI.parse _namespace_name "temporal-location_q" |> NamespacedName

    /// <summary>
    /// Qualities can be seen as the basic entities we can  perceive or measure: shapes, colors, sizes, sounds, smells, as well as weights, lengths,  electrical charges... 'Quality' is often used as a synonymous of 'property', but this is  not the case in this upper ontology: qualities are particulars, properties are universals.  Qualities inhere to entities: every entity (including qualities themselves) comes with  certain qualities, which exist as long as the entity exists.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#quality"></see></summary>
    let quality = Namespaced_IRI.parse _namespace_name "quality" |> NamespacedName
    /// <summary>
    /// Perdurants (AKA occurrences) comprise what are variously called events, processes, phenomena, activities and states. They can have temporal parts or spatial parts. For instance, the first movement of (an execution of) a symphony is a temporal part of the symphony. On the other hand, the play performed by the left side of the orchestra is a spatial part. In both cases, these parts are occurrences themselves. We assume that objects cannot be parts of occurrences, but rather they participate in them. Perdurants extend in time by accumulating different temporal parts, so that, at any time they are present, they are only partially present, in  the sense that some of their proper temporal parts (e.g., their previous or future phases) may be not present. E.g., the piece of paper you are reading now is wholly present, while some temporal parts of your reading are not present yet, or any more. Philosophers say that endurants are entities that are in time, while lacking temporal parts (so to speak, all their parts flow with them in time). Perdurants, on the contrary, are entities that happen in time, and can have temporal parts (all their parts are fixed in time).
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#perdurant"></see></summary>
    let perdurant = Namespaced_IRI.parse _namespace_name "perdurant" |> NamespacedName

    /// <summary>
    /// Analytical location holding between non-physical endurants and abstract regions.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#abstract-location"></see></summary>
    let ``abstract-location`` =
        Namespaced_IRI.parse _namespace_name "abstract-location" |> NamespacedName

    /// <summary>
    /// An endurant with no mass, generically constantly depending on some agent. Non-physical endurants can have physical constituents (e.g. in the case of members of a collection).
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#non-physical-endurant"></see></summary>
    let ``non-physical-endurant`` =
        Namespaced_IRI.parse _namespace_name "non-physical-endurant" |> NamespacedName

    /// <summary>
    /// A region at which only abstract qualities can be directly located. It assumes some metrics for abstract (neither physical nor temporal) properties.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#abstract-region"></see></summary>
    let ``abstract-region`` =
        Namespaced_IRI.parse _namespace_name "abstract-region" |> NamespacedName

    /// <summary>
    /// A location relation bounded to regions and defined analytically through the composition of inherence and q-location. This is the analytical version of 'generic location'.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#exact-location"></see></summary>
    let ``exact-location`` =
        Namespaced_IRI.parse _namespace_name "exact-location" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#abstract-location-of"></see>
    /// </summary>
    let ``abstract-location-of`` =
        Namespaced_IRI.parse _namespace_name "abstract-location-of" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#exact-location-of"></see>
    /// </summary>
    let ``exact-location-of`` =
        Namespaced_IRI.parse _namespace_name "exact-location-of" |> NamespacedName

    /// <summary>
    /// A quality inherent in a non-physical endurant.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#abstract-quality"></see></summary>
    let ``abstract-quality`` =
        Namespaced_IRI.parse _namespace_name "abstract-quality" |> NamespacedName

    /// <summary>
    /// The immediate relation holding for qualities and regions. See 'generic location' branching for the various mediated relations that embed q-location.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#q-location"></see></summary>
    let ``q-location`` =
        Namespaced_IRI.parse _namespace_name "q-location" |> NamespacedName

    /// <summary>
    /// The immediate relation holding for qualities and entities.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#inherent-in"></see></summary>
    let ``inherent-in`` =
        Namespaced_IRI.parse _namespace_name "inherent-in" |> NamespacedName

    /// <summary>
    /// We distinguish between a quality (e.g., the color  of a specific rose), and its value (e.g., a particular shade of red). The latter  is called quale, and describes the position of an individual quality within a certain  conceptual space (called here quality space) Gardenfors (2000). So when we say that  two roses have (exactly) the same color, we mean that their color qualities, which  are distinct, have the same position in the color space, that is they have the same  color quale.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#region"></see></summary>
    let region = Namespaced_IRI.parse _namespace_name "region" |> NamespacedName
    /// <summary>
    /// The most generic part relation, reflexive, asymmetric, and transitive.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#part"></see></summary>
    let part = Namespaced_IRI.parse _namespace_name "part" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#q-location-of"></see>
    /// </summary>
    let ``q-location-of`` =
        Namespaced_IRI.parse _namespace_name "q-location-of" |> NamespacedName

    /// <summary>
    /// A region at which only temporal qualities can be  directly located. It assumes a metrics for time.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#temporal-region"></see></summary>
    let ``temporal-region`` =
        Namespaced_IRI.parse _namespace_name "temporal-region" |> NamespacedName

    /// <summary>
    /// Eventive occurrences (events) are called achievements if they are atomic, otherwise they are accomplishments.Further developments: being 'achievement', 'accomplishment', 'state', 'event', etc. can be also considered 'aspects' of processes or of parts of them. For example, the same process 'rock erosion in the Sinni valley' can be seen as an accomplishment (what has brought the current state that e.g. we are trying to explain), as an achievement (the erosion process as the result of a previous accomplishment), as a state (collapsing the time interval of the erosion into a time point), as an event (what has changed our focus from a state to another).In the erosion case, we could have good motivations to shift from one aspect to another: a) causation focus, b) effectual focus, c) condensation d) transition (causality).
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#accomplishment"></see></summary>
    let accomplishment =
        Namespaced_IRI.parse _namespace_name "accomplishment" |> NamespacedName

    /// <summary>
    /// An occurrence-type is stative or eventive according  to whether it holds of the mereological sum of two of its instances, i.e. if it is cumulative or not. A sitting occurrence is stative since the sum of two sittings is still a sitting occurrence.In general, events differ from situations because they are not assumed to have a description from which they depend. They can be sequenced by some course, but they do not require a description as a unifying criterion.On the other hand, at any time, one can conceive a description that asserts the constraints by which an event of a certian type is such, and in this case, it becomes a situation.Since the decision of designing an explicit description that unifies a perdurant depends on context, task, interest, application, etc., when aligning an ontology do DLP, there can be indecision on where to align an event-oriented class. For example, in the WordNet alignment, we have decided to put only some physical events under 'event', e.g. 'discharge', in order to stress the social orientedness of DLP. But whereas we need to talk explicitly of the criteria by which we conceive discharge events, these will be put under 'situation'.Similar considerations are made for the other types of perdurants in DOLCE.A different notion of event (dealing with change) is currently investigated for further developments: being 'achievement', 'accomplishment', 'state', 'event', etc. can be also considered 'aspects' of processes or of parts of them. For example, the same process 'rock erosion in the Sinni valley' can be conceptualized as an accomplishment (what has brought the current state that e.g. we are trying to explain), as an achievement (the erosion process as the result of a previous accomplishment), as a state (if we collapse the time interval of the erosion into a time point), or as an event (what has changed our focus from a state to another).In the erosion case, we could have good motivations to shift from one aspect to another: a) causation focus, b) effectual focus, c) condensation d) transition (causality).If we want to consider all the aspects of a process together, we need to postulate a unifying descriptive set of criteria (i.e. a 'description'), according to which that process is circumstantiated in a 'situation'. The different aspects will arise as a parts of a same situation.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#event"></see></summary>
    let event_ = Namespaced_IRI.parse _namespace_name "event" |> NamespacedName

    /// <summary>
    /// Eventive occurrences (events) are called achievements  if they are atomic, otherwise they are accomplishments.Further developments: being 'achievement', 'accomplishment', 'state', 'event', etc. can be also considered 'aspects' of processes or of parts of them. For example, the same process 'rock erosion in the Sinni valley' can be seen as an accomplishment (what has brought the current state that e.g. we are trying to explain), as an achievement (the erosion process as the result of a previous accomplishment), as a state (collapsing the time interval of the erosion into a time point), as an event (what has changed our focus from a state to another).In the erosion case, we could have good motivations to shift from one aspect to another: a) causation focus, b) effectual focus, c) condensation d) transition (causality).
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#achievement"></see></summary>
    let achievement =
        Namespaced_IRI.parse _namespace_name "achievement" |> NamespacedName

    /// <summary>
    /// The common trait of amounts of matter is that they are endurants with no unity (according to Gangemi et a. 2001 none of them is an essential  whole). Amounts of matter - 'stuffs' referred to by mass nouns like 'gold', 'iron', 'wood',  'sand', 'meat', etc. - are mereologically  invariant, in the sense that they change their  identity when they change some parts.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#amount-of-matter"></see></summary>
    let ``amount-of-matter`` =
        Namespaced_IRI.parse _namespace_name "amount-of-matter" |> NamespacedName

    /// <summary>
    /// An endurant having a direct physical (at least spatial) quality.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#physical-endurant"></see></summary>
    let ``physical-endurant`` =
        Namespaced_IRI.parse _namespace_name "physical-endurant" |> NamespacedName

    /// <summary>
    /// AKA arbitrary-collection.The mereological sum of any two or more endurants (physical or not). Arbitrary sums have no unity criterion (they are 'extensional').
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#arbitrary-sum"></see></summary>
    let ``arbitrary-sum`` =
        Namespaced_IRI.parse _namespace_name "arbitrary-sum" |> NamespacedName

    /// <summary>
    /// The main characteristic of endurants is that all of them are independent essential wholes. This does not mean that the corresponding property (being an endurant) carries proper unity, since there is  no common unity criterion for endurants. Endurants can 'genuinely' change in time,  in the sense that the very same endurant as a whole can have incompatible properties at different times. To see this, suppose that an endurant - say 'this paper' - has a  property at a time t 'it's white', and a different, incompatible property at time t'  'it's yellow': in both cases we refer to the whole object, without picking up any  particular part of it. Within endurants, we distinguish between physical and non-physical  endurants, according to whether they have direct spatial qualities. Within physical  endurants, we distinguish between amounts of matter, objects, and features.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#endurant"></see></summary>
    let endurant = Namespaced_IRI.parse _namespace_name "endurant" |> NamespacedName

    /// <summary>
    /// The part relation between a particular and an atom.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#atomic-part"></see></summary>
    let ``atomic-part`` =
        Namespaced_IRI.parse _namespace_name "atomic-part" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#atomic-part-of"></see>
    /// </summary>
    let ``atomic-part-of`` =
        Namespaced_IRI.parse _namespace_name "atomic-part-of" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#part-of"></see>
    /// </summary>
    let ``part-of`` = Namespaced_IRI.parse _namespace_name "part-of" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#boundary"></see>
    /// </summary>
    let boundary = Namespaced_IRI.parse _namespace_name "boundary" |> NamespacedName

    /// <summary>
    /// The proper part relation: irreflexive, antisymmetric, and transitive.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#proper-part"></see></summary>
    let ``proper-part`` =
        Namespaced_IRI.parse _namespace_name "proper-part" |> NamespacedName

    /// <summary>
    /// A boundary here is taken to be a part (mereological treatment). Consequently, in the case of endurants, (reified) boundaries are features.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#boundary-of"></see></summary>
    let ``boundary-of`` =
        Namespaced_IRI.parse _namespace_name "boundary-of" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#proper-part-of"></see>
    /// </summary>
    let ``proper-part-of`` =
        Namespaced_IRI.parse _namespace_name "proper-part-of" |> NamespacedName

    /// <summary>
    /// Anytime x is present, x has participant y. In other words, all parts of x have a same participant.Participation can be constant (in all parts of the perdurant, e.g. in 'the car is running'), or temporary (in only some parts, e.g. in 'I'm electing the president').
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#constant-participant"></see></summary>
    let ``constant-participant`` =
        Namespaced_IRI.parse _namespace_name "constant-participant" |> NamespacedName

    /// <summary>
    /// The immediate relation holding between endurants and perdurants (e.g. in 'the car is running').Participation can be constant (in all parts of the perdurant, e.g. in 'the car is running'), or temporary (in only some parts, e.g. in 'I'm electing the president').A 'functional' participant is specialized for those forms of participation that depend on the nature of participants, processes, or on the intentionality of agentive participants. Traditional 'thematic role' should be mapped to functional participation.For relations holding between participants in a same perdurant, see the co-participates relation.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#participant"></see></summary>
    let participant =
        Namespaced_IRI.parse _namespace_name "participant" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#constant-participant-in"></see>
    /// </summary>
    let ``constant-participant-in`` =
        Namespaced_IRI.parse _namespace_name "constant-participant-in" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#participant-in"></see>
    /// </summary>
    let ``participant-in`` =
        Namespaced_IRI.parse _namespace_name "participant-in" |> NamespacedName

    /// <summary>
    /// A feature that is not part of its host, like a hole in a piece of cheese, the underneath of a table, the front of a house, or the shadow of a tree.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#dependent-place"></see></summary>
    let ``dependent-place`` =
        Namespaced_IRI.parse _namespace_name "dependent-place" |> NamespacedName

    /// <summary>
    /// Features are 'parasitic entities', that exist insofar their host exists. Typical examples of features are holes, bumps, boundaries, or spots of color. Features may be relevant parts of their host, like a bump or an edge, or dependent regions like a hole in a piece of cheese, the underneath of a table, the front of a house, or the shadow of a tree, which are not parts of their host. All features are essential wholes, but no common unity criterion may exist for all of them. However, typical features have a topological unity, as they are singular entities.Here only features of physical endurants are considered.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#feature"></see></summary>
    let feature = Namespaced_IRI.parse _namespace_name "feature" |> NamespacedName

    /// <summary>
    /// 'Constituent' should depend on some layering of  the ontology. For example, scientific granularities or ontological 'strata' are  typical layerings. A constituent is a part belonging to a lower layer. Since layering is actually a partition of the ontology, constituents are not properly classified as parts, although this kinship can be intuitive for common sense. Example of specific constant constituents are the entities constituting a setting (a situation), whilethe entities constituting a collection are examples of generic constant constituents.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#specific-constant-constituent"></see></summary>
    let ``specific-constant-constituent`` =
        Namespaced_IRI.parse _namespace_name "specific-constant-constituent" |> NamespacedName

    /// <summary>
    /// Dummy class for optimizing some property universes. It includes all entities that are not reifications of universals ('abstracts'), i.e. those entities that are in space-time.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#spatio-temporal-particular"></see></summary>
    let ``spatio-temporal-particular`` =
        Namespaced_IRI.parse _namespace_name "spatio-temporal-particular" |> NamespacedName

    /// <summary>
    /// The most generic location relation, probably equivalent to more than one image schema in a cognitive system (e.g. containment for exact location, proximity for approximate location).This is meant to reason on generalized, common sense as well as formal locations, including naive localization, between any kinds of entities. Generic location is branched into 'exact' location, ranging on regions, and 'approximate' (naive) location, ranging on non-regions.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#generic-location"></see></summary>
    let ``generic-location`` =
        Namespaced_IRI.parse _namespace_name "generic-location" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#generic-location-of"></see>
    /// </summary>
    let ``generic-location-of`` =
        Namespaced_IRI.parse _namespace_name "generic-location-of" |> NamespacedName

    /// <summary>
    /// The immediate relation holding for features and entities.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#host"></see></summary>
    let host = Namespaced_IRI.parse _namespace_name "host" |> NamespacedName

    /// <summary>
    /// 'Constituent' should depend on some layering of  the ontology. For example, scientific granularities or ontological 'strata' are  typical layerings. A constituent is a part belonging to a lower layer. Since layering is actually a partition of the ontology, constituents are not properly classified as parts, although this kinship can be intuitive for common sense. Example of specific constant constituents are the entities constituting a setting (a situation), whilethe entities constituting a collection are examples of generic constant constituents.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#generic-constituent"></see></summary>
    let ``generic-constituent`` =
        Namespaced_IRI.parse _namespace_name "generic-constituent" |> NamespacedName

    /// <summary>
    /// A relation that holds without  additional mediating individuals. In logical terms, a non-composed relation.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#immediate-relation"></see></summary>
    let ``immediate-relation`` =
        Namespaced_IRI.parse _namespace_name "immediate-relation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#generic-constituent-of"></see>
    /// </summary>
    let ``generic-constituent-of`` =
        Namespaced_IRI.parse _namespace_name "generic-constituent-of" |> NamespacedName

    /// <summary>
    /// A relation that holds without additional mediating individuals. In logical terms, a non-composed relation.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#immediate-relation-i"></see></summary>
    let ``immediate-relation-i`` =
        Namespaced_IRI.parse _namespace_name "immediate-relation-i" |> NamespacedName

    /// <summary>
    /// The dependence on an individual of a given type at some time. This is traditionally a relation between particulars and universals, but this one states that x generically depends on y if a z different from y, but with the same properties, can be equivalently its depend-on.This is a temporally-indexed relation (embedded in this syntax).
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#generic-dependent"></see></summary>
    let ``generic-dependent`` =
        Namespaced_IRI.parse _namespace_name "generic-dependent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#generically-dependent-on"></see>
    /// </summary>
    let ``generically-dependent-on`` =
        Namespaced_IRI.parse _namespace_name "generically-dependent-on" |> NamespacedName

    /// <summary>
    /// A relation that composes other  relations. For example, a participation relation composed with a representation relation.Composed relation cannot be directly expressed in OWL-DL, then (at least some) compositions are expressed as class or restriction axioms.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#mediated-relation"></see></summary>
    let ``mediated-relation`` =
        Namespaced_IRI.parse _namespace_name "mediated-relation" |> NamespacedName

    /// <summary>
    /// A relation that composes other relations. For example, a participation relation composed with a representation relation. Composed relation cannot be directly expressed in OWL-DL, then (at least some) compositions are expressed as class or restriction axioms.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#mediated-relation-i"></see></summary>
    let ``mediated-relation-i`` =
        Namespaced_IRI.parse _namespace_name "mediated-relation-i" |> NamespacedName

    /// <summary>
    /// A quality having a q-location at an atomic region.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#has-quale"></see></summary>
    let ``has-quale`` =
        Namespaced_IRI.parse _namespace_name "has-quale" |> NamespacedName

    /// <summary>
    /// An atomic region.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#quale"></see></summary>
    let quale = Namespaced_IRI.parse _namespace_name "quale" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#quale-of"></see>
    /// </summary>
    let ``quale-of`` = Namespaced_IRI.parse _namespace_name "quale-of" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#has-t-quality"></see>
    /// </summary>
    let ``has-t-quality`` =
        Namespaced_IRI.parse _namespace_name "has-t-quality" |> NamespacedName

    /// <summary>
    /// The immediate relation holding for qualities and entities at time t.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#t-inherent-in"></see></summary>
    let ``t-inherent-in`` =
        Namespaced_IRI.parse _namespace_name "t-inherent-in" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#specifically-constantly-dependent-on"></see>
    /// </summary>
    let ``specifically-constantly-dependent-on`` =
        Namespaced_IRI.parse _namespace_name "specifically-constantly-dependent-on" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#host-of"></see>
    /// </summary>
    let ``host-of`` = Namespaced_IRI.parse _namespace_name "host-of" |> NamespacedName

    /// <summary>
    /// The constant dependence between two individuals. Taken here as primitive.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#specific-constant-dependent"></see></summary>
    let ``specific-constant-dependent`` =
        Namespaced_IRI.parse _namespace_name "specific-constant-dependent" |> NamespacedName

    /// <summary>
    /// Any pair of individuals are ontologically identical if they are identical to themselves. Reflexive, symmetric, and transitive.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#identity-c"></see></summary>
    let ``identity-c`` =
        Namespaced_IRI.parse _namespace_name "identity-c" |> NamespacedName

    /// <summary>
    /// Any pair of individuals are notionally identical iff they instantiate all and only the same concepts.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#identity-n"></see></summary>
    let ``identity-n`` =
        Namespaced_IRI.parse _namespace_name "identity-n" |> NamespacedName

    /// <summary>
    /// Total constant participation applied to the mereological sum of the perdurants in which an endurant participates.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#life"></see></summary>
    let life = Namespaced_IRI.parse _namespace_name "life" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#life-of"></see>
    /// </summary>
    let ``life-of`` = Namespaced_IRI.parse _namespace_name "life-of" |> NamespacedName

    /// <summary>
    /// Having the same parts at time t.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#mereologically-coincides"></see></summary>
    let ``mereologically-coincides`` =
        Namespaced_IRI.parse _namespace_name "mereologically-coincides" |> NamespacedName

    /// <summary>
    /// Being part at time t. It holds for endurants only. This is important to model parts that can change or be lost over time without affecting the identity of the whole. In FOL, this is expressed as a ternary relation, but in DLs we only can reason with binary relations, then only the necessary axiom of compresence is represented here.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#temporary-part"></see></summary>
    let ``temporary-part`` =
        Namespaced_IRI.parse _namespace_name "temporary-part" |> NamespacedName

    /// <summary>
    /// Formerly known as description. A unitary endurant with no mass (non-physical), generically constantly depending on some agent, on some communication act, and indirectly on some agent participating in that act. Both descriptions (in the now current sense) and concepts are non-physical objects.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#non-physical-object"></see></summary>
    let ``non-physical-object`` =
        Namespaced_IRI.parse _namespace_name "non-physical-object" |> NamespacedName

    /// <summary>
    /// Mereological overlap: having a common part.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#overlaps"></see></summary>
    let overlaps = Namespaced_IRI.parse _namespace_name "overlaps" |> NamespacedName

    /// <summary>
    /// A composed (mediated) relation used here to make relations 'temporary': by adding it as a superrelation, the effect is that the two related endurants cannot be present at all the same time intervals, but are compresent at least at some time interval (see related axiom).In FOL, the same constraint can be stated directly by coreference.This workaround can be used to index time of relations that involve reciprocal dependency, but it cannot be used in general with relations involving multiple strata of reality. For example, _about_ relation can be temporally indexed, without involving that the time of the information object overlaps with the time of the entity the information is about (but this works for e.g. the _realizes_ relation between information objects and entities whatsoever). The different temporal constraints of about vs. expresses probably derive from the dependency of aboutness from conception (to be about x, an information object should also express a description d that is satisfied by a situation including x, then temporal overlapping of _about_ is true in virtue of d). On the other hand, even conceives cannot be indexed in this way, because overlapping does not hold between the time og the conceiving agent, and the conceived description (or situation).
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#partly-compresent"></see></summary>
    let ``partly-compresent`` =
        Namespaced_IRI.parse _namespace_name "partly-compresent" |> NamespacedName

    /// <summary>
    /// A quality inherent in a perdurant.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#temporal-quality"></see></summary>
    let ``temporal-quality`` =
        Namespaced_IRI.parse _namespace_name "temporal-quality" |> NamespacedName

    /// <summary>
    /// A quality inherent in a physical endurant.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#physical-quality"></see></summary>
    let ``physical-quality`` =
        Namespaced_IRI.parse _namespace_name "physical-quality" |> NamespacedName

    /// <summary>
    /// Analytical location holding between physical endurants and physical regions.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#physical-location"></see></summary>
    let ``physical-location`` =
        Namespaced_IRI.parse _namespace_name "physical-location" |> NamespacedName

    /// <summary>
    /// A region at which only physical qualities can be  directly located. It assumes some metrics for physical properties.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#physical-region"></see></summary>
    let ``physical-region`` =
        Namespaced_IRI.parse _namespace_name "physical-region" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#physical-location-of"></see>
    /// </summary>
    let ``physical-location-of`` =
        Namespaced_IRI.parse _namespace_name "physical-location-of" |> NamespacedName

    /// <summary>
    /// The main characteristic of physical objects is that  they are endurants with unity. However, they have no common unity criterion, since  different subtypes of objects may  have different unity criteria. Differently from  aggregates, (most) physical objects change some of their parts while keeping their  identity, they can have therefore temporary parts. Often physical objects (indeed,  all endurants) are ontologically independent from occurrences (discussed below).  However, if we admit that every object has a life, it is hard to exclude a mutual  specific constant dependence between the two. Nevertheless, we may still use the  notion of dependence to (weakly) characterize objects as being not specifically  constantly dependent on other objects.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#physical-object"></see></summary>
    let ``physical-object`` =
        Namespaced_IRI.parse _namespace_name "physical-object" |> NamespacedName

    /// <summary>
    /// Within stative occurrences, we distinguish between states and processes     according to homeomericity: sitting is classified as a state but running     is classified as a process, since there are (very short) temporal parts of     a running that are not themselves runnings. In general, processes differ     from situations because they are not assumed to have a description from     which they depend. They can be sequenced by some course, but they do not     require a description as a unifying criterion. On the other hand, at any     time, one can conceive a description that asserts the constraints by which     a process of a certian type is such, and in this case, it becomes a     situation. Since the decision of designing an explicit description that     unifies a perdurant depends on context, task, interest, application, etc.,     when aligning an ontology do DLP, there can be indecision on where to     align a process-oriented class. For example, in the WordNet alignment, we     have decided to put only some physical processes under 'process', e.g.     'organic process', in order to stress the social orientedness of DLP. But     whereas we need to talk explicitly of the criteria by which we conceive     organic processes, these will be put under 'situation'. Similar     considerations are made for the other types of perdurants in DOLCE. A     different notion of event (dealing with change) is currently investigated     for further developments: being 'achievement', 'accomplishment', 'state',     'event', etc. can be also considered 'aspects' of processes or of parts of     them. For example, the same process 'rock erosion in the Sinni valley' can     be conceptualized as an accomplishment (what has brought the current state     that e.g. we are trying to explain), as an achievement (the erosion     process as the result of a previous accomplishment), as a state (if we     collapse the time interval of the erosion into a time point), or as an     event (what has changed our focus from a state to another). In the erosion     case, we could have good motivations to shift from one aspect to another:     a) causation focus, b) effectual focus, c) condensation d) transition     (causality). If we want to consider all the aspects of a process together,     we need to postulate a unifying descriptive set of criteria (i.e. a     'description'), according to which that process is circumstantiated in a     'situation'. The different aspects will arise as a parts of a same situation.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#process"></see></summary>
    let process_ = Namespaced_IRI.parse _namespace_name "process" |> NamespacedName
    /// <summary>
    /// An occurrence-type is stative or eventive according  to whether it holds of the mereological sum of two of its instances, i.e. if it is  cumulative or not. A sitting occurrence is stative since the sum of two sittings  is still a sitting occurrence.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#stative"></see></summary>
    let stative = Namespaced_IRI.parse _namespace_name "stative" |> NamespacedName

    /// <summary>
    /// The abstract content of a proposition. Abstract content is purely combinatorial: from this viewpoint, any content that can be generated by means of combinatorial rules is assumed to exist in the domain of quantification (reified abstracts).
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#proposition"></see></summary>
    let proposition =
        Namespaced_IRI.parse _namespace_name "proposition" |> NamespacedName

    /// <summary>
    /// Presence of a physical quality when inheres in  an endurant.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#q-present-at"></see></summary>
    let ``q-present-at`` =
        Namespaced_IRI.parse _namespace_name "q-present-at" |> NamespacedName

    /// <summary>
    /// A temporal region, measured according to a calendar.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#time-interval"></see></summary>
    let ``time-interval`` =
        Namespaced_IRI.parse _namespace_name "time-interval" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#time-of-q-presence-of"></see>
    /// </summary>
    let ``time-of-q-presence-of`` =
        Namespaced_IRI.parse _namespace_name "time-of-q-presence-of" |> NamespacedName

    /// <summary>
    /// A quality space is a topologically maximal region. The constraint of maximality cannot be given completely in OWL, but a constraint is given that creates a partition out of all quality spaces (e.g. no two quality spaces can overlap mereologically).
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#quality-space"></see></summary>
    let ``quality-space`` =
        Namespaced_IRI.parse _namespace_name "quality-space" |> NamespacedName

    /// <summary>
    /// A relation for representing regions within other regions, e.g. in measurement spaces (space composition).The result of r-location composition is a new 'composed region', which can either preserve the same region type (e.g. physical+physical-&gt;physical, or  physical+abstract-&gt;physical), or not (e.g. physical+abstract-&gt;abstract). See 'composition description' for more details.In some cases, space composition is conventional, i.e. a space is just 'located' at another space, as in the case of measurement spaces:(direct composition):   r r-location r1In other cases, r-location implies a complex path, e.g. :(homogeneous composition):   r q-location-of q inherent-in x has-quality q1 q-location r1(heterogeneous composition across endurants and perdurants):   r q-location-of q inherent-in e participant-in p has-quality q1 q-location r1(heterogeneous composition across physical and non-physical endurants):   r q-location-of q inherent-in pe specific-constant-dependent npe has-quality q1 q-location r1
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#r-location"></see></summary>
    let ``r-location`` =
        Namespaced_IRI.parse _namespace_name "r-location" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#r-location-of"></see>
    /// </summary>
    let ``r-location-of`` =
        Namespaced_IRI.parse _namespace_name "r-location-of" |> NamespacedName

    /// <summary>
    /// Features that are relevant parts of their host, like a bump or an edge.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#relevant-part"></see></summary>
    let ``relevant-part`` =
        Namespaced_IRI.parse _namespace_name "relevant-part" |> NamespacedName

    /// <summary>
    /// A mathematical set.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#set"></see></summary>
    let set = Namespaced_IRI.parse _namespace_name "set" |> NamespacedName

    /// <summary>
    /// Mereological sibling: having a common whole
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#sibling-part"></see></summary>
    let ``sibling-part`` =
        Namespaced_IRI.parse _namespace_name "sibling-part" |> NamespacedName

    /// <summary>
    /// An ordinary space: geographical, cosmological, anatomical, topographic, etc.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#space-region"></see></summary>
    let ``space-region`` =
        Namespaced_IRI.parse _namespace_name "space-region" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#spatio-temporal-presence-of"></see>
    /// </summary>
    let ``spatio-temporal-presence-of`` =
        Namespaced_IRI.parse _namespace_name "spatio-temporal-presence-of" |> NamespacedName

    /// <summary>
    /// Any region resulting from the composition of a space region with a temporal region, i.e. being present in region r at time t.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#spatio-temporal-region"></see></summary>
    let ``spatio-temporal-region`` =
        Namespaced_IRI.parse _namespace_name "spatio-temporal-region" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#spatio-temporally-present-at"></see>
    /// </summary>
    let ``spatio-temporally-present-at`` =
        Namespaced_IRI.parse _namespace_name "spatio-temporally-present-at" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#specific-constant-constituent-of"></see>
    /// </summary>
    let ``specific-constant-constituent-of`` =
        Namespaced_IRI.parse _namespace_name "specific-constant-constituent-of" |> NamespacedName

    /// <summary>
    /// Within stative occurrences, we distinguish between  states and processes according to homeomericity: sitting is classified as a state  but running is classified as a process, since there are (very short) temporal parts  of a running that are not themselves runnings.In general, states differ from situations because they are not assumed to have a description from which they depend. They can be sequenced by some course, but they do not require a description as a unifying criterion.On the other hand, at any time, one can conceive a description that asserts the constraints by which a state of a certian type is such, and in this case, it becomes a situation.Since the decision of designing an explicit description that unifies a perdurant depends on context, task, interest, application, etc., when aligning an ontology do DLP, there can be indecision on where to align a state-oriented class. For example, in the WordNet alignment, we have decided to put only some physical states under 'state', e.g. 'turgor', in order to stress the social orientedness of DLP. But whereas we need to talk explicitly of the criteria by which we conceive turgor states, these will be put under 'situation'.Similar considerations are made for the other types of perdurants in DOLCE.A different notion of event (dealing with change) is currently investigated for further developments: being 'achievement', 'accomplishment', 'state', 'event', etc. can be also considered 'aspects' of processes or of parts of them. For example, the same process 'rock erosion in the Sinni valley' can be conceptualized as an accomplishment (what has brought the current state that e.g. we are trying to explain), as an achievement (the erosion process as the result of a previous accomplishment), as a state (if we collapse the time interval of the erosion into a time point), or as an event (what has changed our focus from a state to another).In the erosion case, we could have good motivations to shift from one aspect to another: a) causation focus, b) effectual focus, c) condensation d) transition (causality).If we want to consider all the aspects of a process together, we need to postulate a unifying descriptive set of criteria (i.e. a 'description'), according to which that process is circumstantiated in a 'situation'. The different aspects will arise as a parts of a same situation.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#state"></see></summary>
    let state = Namespaced_IRI.parse _namespace_name "state" |> NamespacedName

    /// <summary>
    /// By strong connection here we mean a connection between  two entities that share a boundary.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#strong-connection"></see></summary>
    let ``strong-connection`` =
        Namespaced_IRI.parse _namespace_name "strong-connection" |> NamespacedName

    /// <summary>
    /// Having an atom as part at a time t.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#temporary-atomic-part"></see></summary>
    let ``temporary-atomic-part`` =
        Namespaced_IRI.parse _namespace_name "temporary-atomic-part" |> NamespacedName

    /// <summary>
    /// Being proper part at time t. It holds for endurants only. This is important to model proper parts that can change or be lost over time without affecting the identity of the whole.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#temporary-proper-part"></see></summary>
    let ``temporary-proper-part`` =
        Namespaced_IRI.parse _namespace_name "temporary-proper-part" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#temporary-atomic-part-of"></see>
    /// </summary>
    let ``temporary-atomic-part-of`` =
        Namespaced_IRI.parse _namespace_name "temporary-atomic-part-of" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#temporary-proper-part-of"></see>
    /// </summary>
    let ``temporary-proper-part-of`` =
        Namespaced_IRI.parse _namespace_name "temporary-proper-part-of" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#temporary-part-of"></see>
    /// </summary>
    let ``temporary-part-of`` =
        Namespaced_IRI.parse _namespace_name "temporary-part-of" |> NamespacedName

    /// <summary>
    /// Only some parts of the perdurant p have a participant e.In fact, participation can be constant (in all parts of the perdurant, e.g. in 'the car is running'), or temporary (in only some parts, e.g. in 'I'm electing the president').Implicitly, this relation has a temporal indexing.If needed, in OWL one can derive such indexing by expliciting what parts of p have e as _constant_ participant.An appropriate OWL axiom is created to bind this relation to a proper part of it, which has the temporary-participant as a constant one.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#temporary-participant"></see></summary>
    let ``temporary-participant`` =
        Namespaced_IRI.parse _namespace_name "temporary-participant" |> NamespacedName

    /// <summary>
    /// x participates in some of y's parts.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#temporary-participant-in"></see></summary>
    let ``temporary-participant-in`` =
        Namespaced_IRI.parse _namespace_name "temporary-participant-in" |> NamespacedName

    /// <summary>
    /// The perdurant p has a participant e that constantly participates in p with all its parts, e.g. in 'I played the concert' (where the concert is a solo concert).
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#total-constant-participant"></see></summary>
    let ``total-constant-participant`` =
        Namespaced_IRI.parse _namespace_name "total-constant-participant" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#total-constant-participant-in"></see>
    /// </summary>
    let ``total-constant-participant-in`` =
        Namespaced_IRI.parse _namespace_name "total-constant-participant-in" |> NamespacedName

    /// <summary>
    /// The perdurant p has a participant e that temporarily participates in p with all its parts, e.g. in 'I played the concert' (where I actually played just an ouverture).See also 'temporary-participant'.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#total-temporary-participant"></see></summary>
    let ``total-temporary-participant`` =
        Namespaced_IRI.parse _namespace_name "total-temporary-participant" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#total-temporary-participant-in"></see>
    /// </summary>
    let ``total-temporary-participant-in`` =
        Namespaced_IRI.parse _namespace_name "total-temporary-participant-in" |> NamespacedName

    /// <summary>
    /// The basic connection, not requiring a  common boundary.
    /// <see href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#weak-connection"></see></summary>
    let ``weak-connection`` =
        Namespaced_IRI.parse _namespace_name "weak-connection" |> NamespacedName
