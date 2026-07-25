namespace http.www.loa_cnr.it.ontologies.DOLCE_Lite.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module DOLCE_Lite =
    let _namespace_iri = Namespace_Iri DOLCE_Lite |> NamespaceIRI
    /// <summary>
    ///   <para>DOLCE-Lite:abstract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The main characteristic of abstract entities is that  they do not have spatial nor temporal qualities, and they are not qualities themselves.  The only class of abstract entities we consider in the present version of the upper  ontology is that of quality regions (or simply regions). Quality spaces are special  kinds of quality regions, being mereological sums of all the regions related to a certain quality type. The other examples of abstract entities (sets and facts) are only  indicative.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#abstract">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#abstract</seealso>
    let abstract_ = Prefixed_Name(DOLCE_Lite, "abstract") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:temporal-location_q</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A temporal location quality.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#temporal-location_q">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#temporal-location_q</seealso>
    let temporal_location_q =
        Prefixed_Name(DOLCE_Lite, "temporal-location_q") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:abstract-location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Analytical location holding between non-physical endurants and abstract regions.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#abstract-location">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#abstract-location</seealso>
    let abstract_location =
        Prefixed_Name(DOLCE_Lite, "abstract-location") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:exact-location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A location relation bounded to regions and defined analytically through the composition of inherence and q-location. This is the analytical version of 'generic location'.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#exact-location">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#exact-location</seealso>
    let exact_location = Prefixed_Name(DOLCE_Lite, "exact-location") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:abstract-quality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A quality inherent in a non-physical endurant.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#abstract-quality">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#abstract-quality</seealso>
    let abstract_quality = Prefixed_Name(DOLCE_Lite, "abstract-quality") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:region</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>We distinguish between a quality (e.g., the color  of a specific rose), and its value (e.g., a particular shade of red). The latter  is called quale, and describes the position of an individual quality within a certain  conceptual space (called here quality space) Gardenfors (2000). So when we say that  two roses have (exactly) the same color, we mean that their color qualities, which  are distinct, have the same position in the color space, that is they have the same  color quale.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#region">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#region</seealso>
    let region = Prefixed_Name(DOLCE_Lite, "region") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:q-location-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#q-location-of">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#q-location-of</seealso>
    let q_location_of = Prefixed_Name(DOLCE_Lite, "q-location-of") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:temporal-region</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A region at which only temporal qualities can be  directly located. It assumes a metrics for time.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#temporal-region">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#temporal-region</seealso>
    let temporal_region = Prefixed_Name(DOLCE_Lite, "temporal-region") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:arbitrary-sum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>AKA arbitrary-collection.The mereological sum of any two or more endurants (physical or not). Arbitrary sums have no unity criterion (they are 'extensional').</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#arbitrary-sum">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#arbitrary-sum</seealso>
    let arbitrary_sum = Prefixed_Name(DOLCE_Lite, "arbitrary-sum") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:dependent-place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A feature that is not part of its host, like a hole in a piece of cheese, the underneath of a table, the front of a house, or the shadow of a tree.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#dependent-place">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#dependent-place</seealso>
    let dependent_place = Prefixed_Name(DOLCE_Lite, "dependent-place") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:generic-location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The most generic location relation, probably equivalent to more than one image schema in a cognitive system (e.g. containment for exact location, proximity for approximate location).This is meant to reason on generalized, common sense as well as formal locations, including naive localization, between any kinds of entities. Generic location is branched into 'exact' location, ranging on regions, and 'approximate' (naive) location, ranging on non-regions.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#generic-location">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#generic-location</seealso>
    let generic_location = Prefixed_Name(DOLCE_Lite, "generic-location") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:generic-location-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#generic-location-of">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#generic-location-of</seealso>
    let generic_location_of =
        Prefixed_Name(DOLCE_Lite, "generic-location-of") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:generic-constituent-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#generic-constituent-of">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#generic-constituent-of</seealso>
    let generic_constituent_of =
        Prefixed_Name(DOLCE_Lite, "generic-constituent-of") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:immediate-relation-i</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation that holds without additional mediating individuals. In logical terms, a non-composed relation.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#immediate-relation-i">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#immediate-relation-i</seealso>
    let immediate_relation_i =
        Prefixed_Name(DOLCE_Lite, "immediate-relation-i") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:generic-dependent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The dependence on an individual of a given type at some time. This is traditionally a relation between particulars and universals, but this one states that x generically depends on y if a z different from y, but with the same properties, can be equivalently its depend-on.This is a temporally-indexed relation (embedded in this syntax).</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#generic-dependent">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#generic-dependent</seealso>
    let generic_dependent =
        Prefixed_Name(DOLCE_Lite, "generic-dependent") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:quale-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#quale-of">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#quale-of</seealso>
    let quale_of = Prefixed_Name(DOLCE_Lite, "quale-of") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:has-t-quality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#has-t-quality">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#has-t-quality</seealso>
    let has_t_quality = Prefixed_Name(DOLCE_Lite, "has-t-quality") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:t-inherent-in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The immediate relation holding for qualities and entities at time t.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#t-inherent-in">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#t-inherent-in</seealso>
    let t_inherent_in = Prefixed_Name(DOLCE_Lite, "t-inherent-in") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:physical-location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Analytical location holding between physical endurants and physical regions.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#physical-location">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#physical-location</seealso>
    let physical_location =
        Prefixed_Name(DOLCE_Lite, "physical-location") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:process</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Within stative occurrences, we distinguish between states and processes     according to homeomericity: sitting is classified as a state but running     is classified as a process, since there are (very short) temporal parts of     a running that are not themselves runnings. In general, processes differ     from situations because they are not assumed to have a description from     which they depend. They can be sequenced by some course, but they do not     require a description as a unifying criterion. On the other hand, at any     time, one can conceive a description that asserts the constraints by which     a process of a certian type is such, and in this case, it becomes a     situation. Since the decision of designing an explicit description that     unifies a perdurant depends on context, task, interest, application, etc.,     when aligning an ontology do DLP, there can be indecision on where to     align a process-oriented class. For example, in the WordNet alignment, we     have decided to put only some physical processes under 'process', e.g.     'organic process', in order to stress the social orientedness of DLP. But     whereas we need to talk explicitly of the criteria by which we conceive     organic processes, these will be put under 'situation'. Similar     considerations are made for the other types of perdurants in DOLCE. A     different notion of event (dealing with change) is currently investigated     for further developments: being 'achievement', 'accomplishment', 'state',     'event', etc. can be also considered 'aspects' of processes or of parts of     them. For example, the same process 'rock erosion in the Sinni valley' can     be conceptualized as an accomplishment (what has brought the current state     that e.g. we are trying to explain), as an achievement (the erosion     process as the result of a previous accomplishment), as a state (if we     collapse the time interval of the erosion into a time point), or as an     event (what has changed our focus from a state to another). In the erosion     case, we could have good motivations to shift from one aspect to another:     a) causation focus, b) effectual focus, c) condensation d) transition     (causality). If we want to consider all the aspects of a process together,     we need to postulate a unifying descriptive set of criteria (i.e. a     'description'), according to which that process is circumstantiated in a     'situation'. The different aspects will arise as a parts of a same situation.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#process">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#process</seealso>
    let process_ = Prefixed_Name(DOLCE_Lite, "process") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:q-present-at</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Presence of a physical quality when inheres in  an endurant.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#q-present-at">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#q-present-at</seealso>
    let q_present_at = Prefixed_Name(DOLCE_Lite, "q-present-at") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:quality-space</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A quality space is a topologically maximal region. The constraint of maximality cannot be given completely in OWL, but a constraint is given that creates a partition out of all quality spaces (e.g. no two quality spaces can overlap mereologically).</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#quality-space">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#quality-space</seealso>
    let quality_space = Prefixed_Name(DOLCE_Lite, "quality-space") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:r-location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation for representing regions within other regions, e.g. in measurement spaces (space composition).The result of r-location composition is a new 'composed region', which can either preserve the same region type (e.g. physical+physical-&gt;physical, or  physical+abstract-&gt;physical), or not (e.g. physical+abstract-&gt;abstract). See 'composition description' for more details.In some cases, space composition is conventional, i.e. a space is just 'located' at another space, as in the case of measurement spaces:(direct composition):   r r-location r1In other cases, r-location implies a complex path, e.g. :(homogeneous composition):   r q-location-of q inherent-in x has-quality q1 q-location r1(heterogeneous composition across endurants and perdurants):   r q-location-of q inherent-in e participant-in p has-quality q1 q-location r1(heterogeneous composition across physical and non-physical endurants):   r q-location-of q inherent-in pe specific-constant-dependent npe has-quality q1 q-location r1</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#r-location">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#r-location</seealso>
    let r_location = Prefixed_Name(DOLCE_Lite, "r-location") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:r-location-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#r-location-of">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#r-location-of</seealso>
    let r_location_of = Prefixed_Name(DOLCE_Lite, "r-location-of") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:relevant-part</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Features that are relevant parts of their host, like a bump or an edge.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#relevant-part">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#relevant-part</seealso>
    let relevant_part = Prefixed_Name(DOLCE_Lite, "relevant-part") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:sibling-part</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Mereological sibling: having a common whole</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#sibling-part">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#sibling-part</seealso>
    let sibling_part = Prefixed_Name(DOLCE_Lite, "sibling-part") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:space-region</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An ordinary space: geographical, cosmological, anatomical, topographic, etc.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#space-region">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#space-region</seealso>
    let space_region = Prefixed_Name(DOLCE_Lite, "space-region") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:spatio-temporal-presence-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#spatio-temporal-presence-of">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#spatio-temporal-presence-of</seealso>
    let spatio_temporal_presence_of =
        Prefixed_Name(DOLCE_Lite, "spatio-temporal-presence-of") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:spatio-temporal-region</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any region resulting from the composition of a space region with a temporal region, i.e. being present in region r at time t.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#spatio-temporal-region">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#spatio-temporal-region</seealso>
    let spatio_temporal_region =
        Prefixed_Name(DOLCE_Lite, "spatio-temporal-region") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:spatio-temporally-present-at</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#spatio-temporally-present-at">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#spatio-temporally-present-at</seealso>
    let spatio_temporally_present_at =
        Prefixed_Name(DOLCE_Lite, "spatio-temporally-present-at") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:spatial-location_q</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A physical quality, q-located in (whose value is given within) ordinary spaces (geographical coordinates, cosmological positions, anatomical axes, etc.).</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#spatial-location_q">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#spatial-location_q</seealso>
    let spatial_location_q =
        Prefixed_Name(DOLCE_Lite, "spatial-location_q") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:perdurant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Perdurants (AKA occurrences) comprise what are variously called events, processes, phenomena, activities and states. They can have temporal parts or spatial parts. For instance, the first movement of (an execution of) a symphony is a temporal part of the symphony. On the other hand, the play performed by the left side of the orchestra is a spatial part. In both cases, these parts are occurrences themselves. We assume that objects cannot be parts of occurrences, but rather they participate in them. Perdurants extend in time by accumulating different temporal parts, so that, at any time they are present, they are only partially present, in  the sense that some of their proper temporal parts (e.g., their previous or future phases) may be not present. E.g., the piece of paper you are reading now is wholly present, while some temporal parts of your reading are not present yet, or any more. Philosophers say that endurants are entities that are in time, while lacking temporal parts (so to speak, all their parts flow with them in time). Perdurants, on the contrary, are entities that happen in time, and can have temporal parts (all their parts are fixed in time).</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#perdurant">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#perdurant</seealso>
    let perdurant = Prefixed_Name(DOLCE_Lite, "perdurant") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:abstract-region</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A region at which only abstract qualities can be directly located. It assumes some metrics for abstract (neither physical nor temporal) properties.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#abstract-region">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#abstract-region</seealso>
    let abstract_region = Prefixed_Name(DOLCE_Lite, "abstract-region") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:exact-location-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#exact-location-of">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#exact-location-of</seealso>
    let exact_location_of =
        Prefixed_Name(DOLCE_Lite, "exact-location-of") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:inherent-in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The immediate relation holding for qualities and entities.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#inherent-in">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#inherent-in</seealso>
    let inherent_in = Prefixed_Name(DOLCE_Lite, "inherent-in") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An occurrence-type is stative or eventive according  to whether it holds of the mereological sum of two of its instances, i.e. if it is cumulative or not. A sitting occurrence is stative since the sum of two sittings is still a sitting occurrence.In general, events differ from situations because they are not assumed to have a description from which they depend. They can be sequenced by some course, but they do not require a description as a unifying criterion.On the other hand, at any time, one can conceive a description that asserts the constraints by which an event of a certian type is such, and in this case, it becomes a situation.Since the decision of designing an explicit description that unifies a perdurant depends on context, task, interest, application, etc., when aligning an ontology do DLP, there can be indecision on where to align an event-oriented class. For example, in the WordNet alignment, we have decided to put only some physical events under 'event', e.g. 'discharge', in order to stress the social orientedness of DLP. But whereas we need to talk explicitly of the criteria by which we conceive discharge events, these will be put under 'situation'.Similar considerations are made for the other types of perdurants in DOLCE.A different notion of event (dealing with change) is currently investigated for further developments: being 'achievement', 'accomplishment', 'state', 'event', etc. can be also considered 'aspects' of processes or of parts of them. For example, the same process 'rock erosion in the Sinni valley' can be conceptualized as an accomplishment (what has brought the current state that e.g. we are trying to explain), as an achievement (the erosion process as the result of a previous accomplishment), as a state (if we collapse the time interval of the erosion into a time point), or as an event (what has changed our focus from a state to another).In the erosion case, we could have good motivations to shift from one aspect to another: a) causation focus, b) effectual focus, c) condensation d) transition (causality).If we want to consider all the aspects of a process together, we need to postulate a unifying descriptive set of criteria (i.e. a 'description'), according to which that process is circumstantiated in a 'situation'. The different aspects will arise as a parts of a same situation.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#event">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#event</seealso>
    let event_ = Prefixed_Name(DOLCE_Lite, "event") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:achievement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Eventive occurrences (events) are called achievements  if they are atomic, otherwise they are accomplishments.Further developments: being 'achievement', 'accomplishment', 'state', 'event', etc. can be also considered 'aspects' of processes or of parts of them. For example, the same process 'rock erosion in the Sinni valley' can be seen as an accomplishment (what has brought the current state that e.g. we are trying to explain), as an achievement (the erosion process as the result of a previous accomplishment), as a state (collapsing the time interval of the erosion into a time point), as an event (what has changed our focus from a state to another).In the erosion case, we could have good motivations to shift from one aspect to another: a) causation focus, b) effectual focus, c) condensation d) transition (causality).</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#achievement">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#achievement</seealso>
    let achievement = Prefixed_Name(DOLCE_Lite, "achievement") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:endurant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The main characteristic of endurants is that all of them are independent essential wholes. This does not mean that the corresponding property (being an endurant) carries proper unity, since there is  no common unity criterion for endurants. Endurants can 'genuinely' change in time,  in the sense that the very same endurant as a whole can have incompatible properties at different times. To see this, suppose that an endurant - say 'this paper' - has a  property at a time t 'it's white', and a different, incompatible property at time t'  'it's yellow': in both cases we refer to the whole object, without picking up any  particular part of it. Within endurants, we distinguish between physical and non-physical  endurants, according to whether they have direct spatial qualities. Within physical  endurants, we distinguish between amounts of matter, objects, and features.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#endurant">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#endurant</seealso>
    let endurant = Prefixed_Name(DOLCE_Lite, "endurant") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:atomic-part-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#atomic-part-of">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#atomic-part-of</seealso>
    let atomic_part_of = Prefixed_Name(DOLCE_Lite, "atomic-part-of") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:part-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#part-of">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#part-of</seealso>
    let part_of = Prefixed_Name(DOLCE_Lite, "part-of") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:proper-part-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#proper-part-of">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#proper-part-of</seealso>
    let proper_part_of = Prefixed_Name(DOLCE_Lite, "proper-part-of") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:constant-participant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Anytime x is present, x has participant y. In other words, all parts of x have a same participant.Participation can be constant (in all parts of the perdurant, e.g. in 'the car is running'), or temporary (in only some parts, e.g. in 'I'm electing the president').</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#constant-participant">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#constant-participant</seealso>
    let constant_participant =
        Prefixed_Name(DOLCE_Lite, "constant-participant") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Features are 'parasitic entities', that exist insofar their host exists. Typical examples of features are holes, bumps, boundaries, or spots of color. Features may be relevant parts of their host, like a bump or an edge, or dependent regions like a hole in a piece of cheese, the underneath of a table, the front of a house, or the shadow of a tree, which are not parts of their host. All features are essential wholes, but no common unity criterion may exist for all of them. However, typical features have a topological unity, as they are singular entities.Here only features of physical endurants are considered.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#feature">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#feature</seealso>
    let feature = Prefixed_Name(DOLCE_Lite, "feature") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:mereologically-coincides</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Having the same parts at time t.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#mereologically-coincides">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#mereologically-coincides</seealso>
    let mereologically_coincides =
        Prefixed_Name(DOLCE_Lite, "mereologically-coincides") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:non-physical-object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Formerly known as description. A unitary endurant with no mass (non-physical), generically constantly depending on some agent, on some communication act, and indirectly on some agent participating in that act. Both descriptions (in the now current sense) and concepts are non-physical objects.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#non-physical-object">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#non-physical-object</seealso>
    let non_physical_object =
        Prefixed_Name(DOLCE_Lite, "non-physical-object") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:partly-compresent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A composed (mediated) relation used here to make relations 'temporary': by adding it as a superrelation, the effect is that the two related endurants cannot be present at all the same time intervals, but are compresent at least at some time interval (see related axiom).In FOL, the same constraint can be stated directly by coreference.This workaround can be used to index time of relations that involve reciprocal dependency, but it cannot be used in general with relations involving multiple strata of reality. For example, _about_ relation can be temporally indexed, without involving that the time of the information object overlaps with the time of the entity the information is about (but this works for e.g. the _realizes_ relation between information objects and entities whatsoever). The different temporal constraints of about vs. expresses probably derive from the dependency of aboutness from conception (to be about x, an information object should also express a description d that is satisfied by a situation including x, then temporal overlapping of _about_ is true in virtue of d). On the other hand, even conceives cannot be indexed in this way, because overlapping does not hold between the time og the conceiving agent, and the conceived description (or situation).</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#partly-compresent">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#partly-compresent</seealso>
    let partly_compresent =
        Prefixed_Name(DOLCE_Lite, "partly-compresent") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:temporal-quality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A quality inherent in a perdurant.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#temporal-quality">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#temporal-quality</seealso>
    let temporal_quality = Prefixed_Name(DOLCE_Lite, "temporal-quality") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:physical-quality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A quality inherent in a physical endurant.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#physical-quality">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#physical-quality</seealso>
    let physical_quality = Prefixed_Name(DOLCE_Lite, "physical-quality") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:physical-region</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A region at which only physical qualities can be  directly located. It assumes some metrics for physical properties.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#physical-region">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#physical-region</seealso>
    let physical_region = Prefixed_Name(DOLCE_Lite, "physical-region") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:physical-location-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#physical-location-of">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#physical-location-of</seealso>
    let physical_location_of =
        Prefixed_Name(DOLCE_Lite, "physical-location-of") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:physical-object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The main characteristic of physical objects is that  they are endurants with unity. However, they have no common unity criterion, since  different subtypes of objects may  have different unity criteria. Differently from  aggregates, (most) physical objects change some of their parts while keeping their  identity, they can have therefore temporary parts. Often physical objects (indeed,  all endurants) are ontologically independent from occurrences (discussed below).  However, if we admit that every object has a life, it is hard to exclude a mutual  specific constant dependence between the two. Nevertheless, we may still use the  notion of dependence to (weakly) characterize objects as being not specifically  constantly dependent on other objects.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#physical-object">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#physical-object</seealso>
    let physical_object = Prefixed_Name(DOLCE_Lite, "physical-object") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:stative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An occurrence-type is stative or eventive according  to whether it holds of the mereological sum of two of its instances, i.e. if it is  cumulative or not. A sitting occurrence is stative since the sum of two sittings  is still a sitting occurrence.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#stative">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#stative</seealso>
    let stative = Prefixed_Name(DOLCE_Lite, "stative") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:proposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The abstract content of a proposition. Abstract content is purely combinatorial: from this viewpoint, any content that can be generated by means of combinatorial rules is assumed to exist in the domain of quantification (reified abstracts).</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#proposition">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#proposition</seealso>
    let proposition = Prefixed_Name(DOLCE_Lite, "proposition") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:time-interval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A temporal region, measured according to a calendar.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#time-interval">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#time-interval</seealso>
    let time_interval = Prefixed_Name(DOLCE_Lite, "time-interval") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:time-of-q-presence-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#time-of-q-presence-of">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#time-of-q-presence-of</seealso>
    let time_of_q_presence_of =
        Prefixed_Name(DOLCE_Lite, "time-of-q-presence-of") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:particular</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>AKA 'entity'.Any individual in the DOLCE domain of discourse. The extensional coverage of DOLCE is as large as possible, since it ranges on 'possibilia', i.e all possible individuals that can be postulated by means of DOLCE axioms. Possibilia include physical objects, substances, processes, qualities,  conceptual regions, non-physical objects, collections and even arbitrary sums of objects.The class 'particular' features a covering partition that includes: endurant, perdurant, quality, and abstract. There are also some subclasses defined as unions of subclasses of 'particular' for special purposes: spatio-temporal-particular (any particular except abstracts)- physical-realization (any realization of an information object, defined in the ExtendedDnS ontology).</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#particular">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#particular</seealso>
    let particular = Prefixed_Name(DOLCE_Lite, "particular") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:abstract-location-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#abstract-location-of">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#abstract-location-of</seealso>
    let abstract_location_of =
        Prefixed_Name(DOLCE_Lite, "abstract-location-of") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:q-location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The immediate relation holding for qualities and regions. See 'generic location' branching for the various mediated relations that embed q-location.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#q-location">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#q-location</seealso>
    let q_location = Prefixed_Name(DOLCE_Lite, "q-location") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:part</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The most generic part relation, reflexive, asymmetric, and transitive.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#part">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#part</seealso>
    let part = Prefixed_Name(DOLCE_Lite, "part") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:amount-of-matter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The common trait of amounts of matter is that they are endurants with no unity (according to Gangemi et a. 2001 none of them is an essential  whole). Amounts of matter - 'stuffs' referred to by mass nouns like 'gold', 'iron', 'wood',  'sand', 'meat', etc. - are mereologically  invariant, in the sense that they change their  identity when they change some parts.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#amount-of-matter">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#amount-of-matter</seealso>
    let amount_of_matter = Prefixed_Name(DOLCE_Lite, "amount-of-matter") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:atomic-part</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The part relation between a particular and an atom.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#atomic-part">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#atomic-part</seealso>
    let atomic_part = Prefixed_Name(DOLCE_Lite, "atomic-part") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:boundary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#boundary">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#boundary</seealso>
    let boundary = Prefixed_Name(DOLCE_Lite, "boundary") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:proper-part</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The proper part relation: irreflexive, antisymmetric, and transitive.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#proper-part">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#proper-part</seealso>
    let proper_part = Prefixed_Name(DOLCE_Lite, "proper-part") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:constant-participant-in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#constant-participant-in">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#constant-participant-in</seealso>
    let constant_participant_in =
        Prefixed_Name(DOLCE_Lite, "constant-participant-in") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:participant-in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#participant-in">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#participant-in</seealso>
    let participant_in = Prefixed_Name(DOLCE_Lite, "participant-in") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:quale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An atomic region.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#quale">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#quale</seealso>
    let quale = Prefixed_Name(DOLCE_Lite, "quale") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:identity-n</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Any pair of individuals are notionally identical iff they instantiate all and only the same concepts.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#identity-n">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#identity-n</seealso>
    let identity_n = Prefixed_Name(DOLCE_Lite, "identity-n") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:temporary-atomic-part</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Having an atom as part at a time t.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#temporary-atomic-part">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#temporary-atomic-part</seealso>
    let temporary_atomic_part =
        Prefixed_Name(DOLCE_Lite, "temporary-atomic-part") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:immediate-relation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation that holds without  additional mediating individuals. In logical terms, a non-composed relation.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#immediate-relation">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#immediate-relation</seealso>
    let immediate_relation =
        Prefixed_Name(DOLCE_Lite, "immediate-relation") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:generically-dependent-on</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#generically-dependent-on">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#generically-dependent-on</seealso>
    let generically_dependent_on =
        Prefixed_Name(DOLCE_Lite, "generically-dependent-on") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:set</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A mathematical set.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#set">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#set</seealso>
    let set = Prefixed_Name(DOLCE_Lite, "set") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:specifically-constantly-dependent-on</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#specifically-constantly-dependent-on">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#specifically-constantly-dependent-on</seealso>
    let specifically_constantly_dependent_on =
        Prefixed_Name(DOLCE_Lite, "specifically-constantly-dependent-on") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:life</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Total constant participation applied to the mereological sum of the perdurants in which an endurant participates.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#life">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#life</seealso>
    let life = Prefixed_Name(DOLCE_Lite, "life") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:temporary-participant-in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>x participates in some of y's parts.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#temporary-participant-in">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#temporary-participant-in</seealso>
    let temporary_participant_in =
        Prefixed_Name(DOLCE_Lite, "temporary-participant-in") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:total-constant-participant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The perdurant p has a participant e that constantly participates in p with all its parts, e.g. in 'I played the concert' (where the concert is a solo concert).</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#total-constant-participant">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#total-constant-participant</seealso>
    let total_constant_participant =
        Prefixed_Name(DOLCE_Lite, "total-constant-participant") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:has-quality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#has-quality">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#has-quality</seealso>
    let has_quality = Prefixed_Name(DOLCE_Lite, "has-quality") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:quality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Qualities can be seen as the basic entities we can  perceive or measure: shapes, colors, sizes, sounds, smells, as well as weights, lengths,  electrical charges... 'Quality' is often used as a synonymous of 'property', but this is  not the case in this upper ontology: qualities are particulars, properties are universals.  Qualities inhere to entities: every entity (including qualities themselves) comes with  certain qualities, which exist as long as the entity exists.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#quality">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#quality</seealso>
    let quality = Prefixed_Name(DOLCE_Lite, "quality") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:non-physical-endurant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An endurant with no mass, generically constantly depending on some agent. Non-physical endurants can have physical constituents (e.g. in the case of members of a collection).</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#non-physical-endurant">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#non-physical-endurant</seealso>
    let non_physical_endurant =
        Prefixed_Name(DOLCE_Lite, "non-physical-endurant") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:accomplishment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Eventive occurrences (events) are called achievements if they are atomic, otherwise they are accomplishments.Further developments: being 'achievement', 'accomplishment', 'state', 'event', etc. can be also considered 'aspects' of processes or of parts of them. For example, the same process 'rock erosion in the Sinni valley' can be seen as an accomplishment (what has brought the current state that e.g. we are trying to explain), as an achievement (the erosion process as the result of a previous accomplishment), as a state (collapsing the time interval of the erosion into a time point), as an event (what has changed our focus from a state to another).In the erosion case, we could have good motivations to shift from one aspect to another: a) causation focus, b) effectual focus, c) condensation d) transition (causality).</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#accomplishment">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#accomplishment</seealso>
    let accomplishment = Prefixed_Name(DOLCE_Lite, "accomplishment") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:physical-endurant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An endurant having a direct physical (at least spatial) quality.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#physical-endurant">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#physical-endurant</seealso>
    let physical_endurant =
        Prefixed_Name(DOLCE_Lite, "physical-endurant") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:boundary-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A boundary here is taken to be a part (mereological treatment). Consequently, in the case of endurants, (reified) boundaries are features.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#boundary-of">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#boundary-of</seealso>
    let boundary_of = Prefixed_Name(DOLCE_Lite, "boundary-of") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:participant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The immediate relation holding between endurants and perdurants (e.g. in 'the car is running').Participation can be constant (in all parts of the perdurant, e.g. in 'the car is running'), or temporary (in only some parts, e.g. in 'I'm electing the president').A 'functional' participant is specialized for those forms of participation that depend on the nature of participants, processes, or on the intentionality of agentive participants. Traditional 'thematic role' should be mapped to functional participation.For relations holding between participants in a same perdurant, see the co-participates relation.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#participant">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#participant</seealso>
    let participant = Prefixed_Name(DOLCE_Lite, "participant") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:specific-constant-constituent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>'Constituent' should depend on some layering of  the ontology. For example, scientific granularities or ontological 'strata' are  typical layerings. A constituent is a part belonging to a lower layer. Since layering is actually a partition of the ontology, constituents are not properly classified as parts, although this kinship can be intuitive for common sense. Example of specific constant constituents are the entities constituting a setting (a situation), whilethe entities constituting a collection are examples of generic constant constituents.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#specific-constant-constituent">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#specific-constant-constituent</seealso>
    let specific_constant_constituent =
        Prefixed_Name(DOLCE_Lite, "specific-constant-constituent") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:spatio-temporal-particular</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Dummy class for optimizing some property universes. It includes all entities that are not reifications of universals ('abstracts'), i.e. those entities that are in space-time.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#spatio-temporal-particular">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#spatio-temporal-particular</seealso>
    let spatio_temporal_particular =
        Prefixed_Name(DOLCE_Lite, "spatio-temporal-particular") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:host</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The immediate relation holding for features and entities.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#host">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#host</seealso>
    let host = Prefixed_Name(DOLCE_Lite, "host") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:generic-constituent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>'Constituent' should depend on some layering of  the ontology. For example, scientific granularities or ontological 'strata' are  typical layerings. A constituent is a part belonging to a lower layer. Since layering is actually a partition of the ontology, constituents are not properly classified as parts, although this kinship can be intuitive for common sense. Example of specific constant constituents are the entities constituting a setting (a situation), whilethe entities constituting a collection are examples of generic constant constituents.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#generic-constituent">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#generic-constituent</seealso>
    let generic_constituent =
        Prefixed_Name(DOLCE_Lite, "generic-constituent") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:mediated-relation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation that composes other  relations. For example, a participation relation composed with a representation relation.Composed relation cannot be directly expressed in OWL-DL, then (at least some) compositions are expressed as class or restriction axioms.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#mediated-relation">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#mediated-relation</seealso>
    let mediated_relation =
        Prefixed_Name(DOLCE_Lite, "mediated-relation") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:mediated-relation-i</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation that composes other relations. For example, a participation relation composed with a representation relation. Composed relation cannot be directly expressed in OWL-DL, then (at least some) compositions are expressed as class or restriction axioms.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#mediated-relation-i">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#mediated-relation-i</seealso>
    let mediated_relation_i =
        Prefixed_Name(DOLCE_Lite, "mediated-relation-i") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:has-quale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A quality having a q-location at an atomic region.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#has-quale">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#has-quale</seealso>
    let has_quale = Prefixed_Name(DOLCE_Lite, "has-quale") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:host-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#host-of">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#host-of</seealso>
    let host_of = Prefixed_Name(DOLCE_Lite, "host-of") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:specific-constant-dependent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The constant dependence between two individuals. Taken here as primitive.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#specific-constant-dependent">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#specific-constant-dependent</seealso>
    let specific_constant_dependent =
        Prefixed_Name(DOLCE_Lite, "specific-constant-dependent") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:identity-c</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Any pair of individuals are ontologically identical if they are identical to themselves. Reflexive, symmetric, and transitive.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#identity-c">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#identity-c</seealso>
    let identity_c = Prefixed_Name(DOLCE_Lite, "identity-c") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:life-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#life-of">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#life-of</seealso>
    let life_of = Prefixed_Name(DOLCE_Lite, "life-of") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:temporary-part</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Being part at time t. It holds for endurants only. This is important to model parts that can change or be lost over time without affecting the identity of the whole. In FOL, this is expressed as a ternary relation, but in DLs we only can reason with binary relations, then only the necessary axiom of compresence is represented here.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#temporary-part">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#temporary-part</seealso>
    let temporary_part = Prefixed_Name(DOLCE_Lite, "temporary-part") |> PrefixedName
    /// <summary>
    ///   <para>DOLCE-Lite:overlaps</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Mereological overlap: having a common part.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#overlaps">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#overlaps</seealso>
    let overlaps = Prefixed_Name(DOLCE_Lite, "overlaps") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:specific-constant-constituent-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#specific-constant-constituent-of">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#specific-constant-constituent-of</seealso>
    let specific_constant_constituent_of =
        Prefixed_Name(DOLCE_Lite, "specific-constant-constituent-of") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:state</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Within stative occurrences, we distinguish between  states and processes according to homeomericity: sitting is classified as a state  but running is classified as a process, since there are (very short) temporal parts  of a running that are not themselves runnings.In general, states differ from situations because they are not assumed to have a description from which they depend. They can be sequenced by some course, but they do not require a description as a unifying criterion.On the other hand, at any time, one can conceive a description that asserts the constraints by which a state of a certian type is such, and in this case, it becomes a situation.Since the decision of designing an explicit description that unifies a perdurant depends on context, task, interest, application, etc., when aligning an ontology do DLP, there can be indecision on where to align a state-oriented class. For example, in the WordNet alignment, we have decided to put only some physical states under 'state', e.g. 'turgor', in order to stress the social orientedness of DLP. But whereas we need to talk explicitly of the criteria by which we conceive turgor states, these will be put under 'situation'.Similar considerations are made for the other types of perdurants in DOLCE.A different notion of event (dealing with change) is currently investigated for further developments: being 'achievement', 'accomplishment', 'state', 'event', etc. can be also considered 'aspects' of processes or of parts of them. For example, the same process 'rock erosion in the Sinni valley' can be conceptualized as an accomplishment (what has brought the current state that e.g. we are trying to explain), as an achievement (the erosion process as the result of a previous accomplishment), as a state (if we collapse the time interval of the erosion into a time point), or as an event (what has changed our focus from a state to another).In the erosion case, we could have good motivations to shift from one aspect to another: a) causation focus, b) effectual focus, c) condensation d) transition (causality).If we want to consider all the aspects of a process together, we need to postulate a unifying descriptive set of criteria (i.e. a 'description'), according to which that process is circumstantiated in a 'situation'. The different aspects will arise as a parts of a same situation.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#state">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#state</seealso>
    let state = Prefixed_Name(DOLCE_Lite, "state") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:strong-connection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>By strong connection here we mean a connection between  two entities that share a boundary.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#strong-connection">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#strong-connection</seealso>
    let strong_connection =
        Prefixed_Name(DOLCE_Lite, "strong-connection") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:temporary-proper-part</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Being proper part at time t. It holds for endurants only. This is important to model proper parts that can change or be lost over time without affecting the identity of the whole.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#temporary-proper-part">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#temporary-proper-part</seealso>
    let temporary_proper_part =
        Prefixed_Name(DOLCE_Lite, "temporary-proper-part") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:temporary-atomic-part-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#temporary-atomic-part-of">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#temporary-atomic-part-of</seealso>
    let temporary_atomic_part_of =
        Prefixed_Name(DOLCE_Lite, "temporary-atomic-part-of") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:temporary-proper-part-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#temporary-proper-part-of">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#temporary-proper-part-of</seealso>
    let temporary_proper_part_of =
        Prefixed_Name(DOLCE_Lite, "temporary-proper-part-of") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:temporary-part-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#temporary-part-of">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#temporary-part-of</seealso>
    let temporary_part_of =
        Prefixed_Name(DOLCE_Lite, "temporary-part-of") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:temporary-participant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Only some parts of the perdurant p have a participant e.In fact, participation can be constant (in all parts of the perdurant, e.g. in 'the car is running'), or temporary (in only some parts, e.g. in 'I'm electing the president').Implicitly, this relation has a temporal indexing.If needed, in OWL one can derive such indexing by expliciting what parts of p have e as _constant_ participant.An appropriate OWL axiom is created to bind this relation to a proper part of it, which has the temporary-participant as a constant one.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#temporary-participant">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#temporary-participant</seealso>
    let temporary_participant =
        Prefixed_Name(DOLCE_Lite, "temporary-participant") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:total-constant-participant-in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#total-constant-participant-in">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#total-constant-participant-in</seealso>
    let total_constant_participant_in =
        Prefixed_Name(DOLCE_Lite, "total-constant-participant-in") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:total-temporary-participant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The perdurant p has a participant e that temporarily participates in p with all its parts, e.g. in 'I played the concert' (where I actually played just an ouverture).See also 'temporary-participant'.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#total-temporary-participant">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#total-temporary-participant</seealso>
    let total_temporary_participant =
        Prefixed_Name(DOLCE_Lite, "total-temporary-participant") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:total-temporary-participant-in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#total-temporary-participant-in">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#total-temporary-participant-in</seealso>
    let total_temporary_participant_in =
        Prefixed_Name(DOLCE_Lite, "total-temporary-participant-in") |> PrefixedName

    /// <summary>
    ///   <para>DOLCE-Lite:weak-connection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The basic connection, not requiring a  common boundary.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#weak-connection">http://www.loa-cnr.it/ontologies/DOLCE-Lite.owl#weak-connection</seealso>
    let weak_connection = Prefixed_Name(DOLCE_Lite, "weak-connection") |> PrefixedName
