namespace http.www.loa_cnr.it.ontologies.ExtendedDnS.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ExtendedDnS =
    let _namespace_iri = Namespace_Iri ExtendedDnS |> NamespaceIRI

    /// <summary>
    ///   <para>ExtendedDnS:non-agentive-social-object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A social object that is not agentive in the sense of adopting a plan or being acted by some physical agent. See 'agentive-social-object' for more detail.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#non-agentive-social-object">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#non-agentive-social-object</seealso>
    let non_agentive_social_object =
        Prefixed_Name(ExtendedDnS, "non-agentive-social-object") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:attitude-target-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#attitude-target-of">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#attitude-target-of</seealso>
    let attitude_target_of =
        Prefixed_Name(ExtendedDnS, "attitude-target-of") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:modal-target-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#modal-target-of">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#modal-target-of</seealso>
    let modal_target_of = Prefixed_Name(ExtendedDnS, "modal-target-of") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:in-scope-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#in-scope-of">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#in-scope-of</seealso>
    let in_scope_of = Prefixed_Name(ExtendedDnS, "in-scope-of") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:referenced-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation holding between non-physical objects and entities whatsoever (thus including non-physical objects themselves). An intuition for the references relation could be that a non-physical object adds 'information'  to an entity. In fact, non-physical objects depend on a communication setting. In most cases, this is the characteristic relation that provides  a unity criterion to objects, events, etc. For example, cars are objects and not mere aggregates because there is a project, a design, a social value, a functional structure, a personal emotional structure, etc. attached to them. This attachment can be represented by means of 'non-physical objects' that 'reference' cars. The most obvious application is for situations, which do not exist without a description, although they still are extensional entities: a situation without a part is no more the same situation, but a situation is not a mere aggregate, since it has references to a description as its unity criterion. Adding information to an entity can also be thought as an intentional solution to a holistic stance. Defenders of this view -within different frameworks- are Kant, Brentano, Husserl, Gestalt psychologists, Merleau-Ponty ... References is distinguished according to the kinds of non-physical objects and referenced ground entities: referencing between descriptions and situations is called 'SATISFIED-BY', while referencing between description components and situation components is called 'CLASSIFIES'. 'SETTING-FOR' is a referencing relation between a situation and the entities in its setting (it was formerly a constitution relation, but since situation appear to be social objects from the DOLCE viewpoint, the constitution solution is no more applicable). 'EXPRESSES' is bound to information objects and the meaning (description of a representation or conceptualization) in which they are involved. 'REALIZED-BY' is bound to information objects and physical representations that are used to communicate them, etc. 'ABOUT' is bound to information objects and entities whatsoever (aboutness of intentionality).</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#referenced-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#referenced-by</seealso>
    let referenced_by = Prefixed_Name(ExtendedDnS, "referenced-by") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:course</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A concept that classifies (in particular, it 'sequences') perdurants (processes, events, or states), as a component of some description. Courses are the descriptive counterpart of perdurants, and, since perdurants have endurants as participants, they are usually the function of some role.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#course">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#course</seealso>
    let course = Prefixed_Name(ExtendedDnS, "course") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:attitude-towards</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>It is the immediate relation between roles or figures, and tasks. It is the descriptive counterpart of the 'participant-in' relation for agentive roles or figures.In other words, it is used to state attitudes, attention or even subjection that an object can have wrt an action or process. Formally, a modality target is a task that sequences a perdurant that has a participant that plays a role bound to that modality target with a certain modality.For example, a person is usually obliged to drive in a way that prevents hurting other persons. Or a person can have the right to express her ideas.Another, more complex example: a BDI application to a certain ordered set of tasks including  initial conditions (beliefs), final conditions (desires), and ways to reach goals (intentions). In other words, to move from beliefs to goals is a way of bounding one or more agent(s) to a sequence of actions.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#attitude-towards">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#attitude-towards</seealso>
    let attitude_towards =
        Prefixed_Name(ExtendedDnS, "attitude-towards") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:modal-target</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The relation between roles and courses. Modal target subrelations can be seen as 'reifications' of the operators of modal logics.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#modal-target">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#modal-target</seealso>
    let modal_target = Prefixed_Name(ExtendedDnS, "modal-target") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:situation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A situation is a social object that appears in the domain of an ontology only because there is a description whose components can 'carve up' a view (setting) on that domain. A situation has to satisfy a description (see below for ways of defining the satisfies relation), and it has to be setting for at least one entity.In other words, it is the ontological counterpart (with due local differences or restrictions) of settings (situations from SC, contexts, episodes, states of affairs, structures, configurations, cases, etc.).A perdurant is usually the only mandatory constituent of a setting.Two descriptions of a same situation are possible, otherwise we would result in a solipsistic ontology. The time and space (and possibly other qualities) of a situation are the time and space of the perdurants in the setting.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#situation">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#situation</seealso>
    let situation = Prefixed_Name(ExtendedDnS, "situation") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:satisfies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>See 'satisfied-by'.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#satisfies">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#satisfies</seealso>
    let satisfies = Prefixed_Name(ExtendedDnS, "satisfies") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Collections are social objects which, although not defined by a description, depend both on member entities and on some concepts or figures, hence indirectly on descriptions. While we could talk in general of collections of any kind of entities (events, objects, abstracts, etc.), we restrict here our attention to collections of endurants, and to the concepts that classify them (i.e. roles).</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#collection">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#collection</seealso>
    let collection = Prefixed_Name(ExtendedDnS, "collection") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:intensionally-referenced-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#intensionally-referenced-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#intensionally-referenced-by</seealso>
    let intensionally_referenced_by =
        Prefixed_Name(ExtendedDnS, "intensionally-referenced-by") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:classified-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A.K.A. 'selected-by'.The referencing relation between concepts defined by descriptions and constituents of situations. It can be understood as a reification of a 'satisfiability' relation holding between elements of  theories and elements of models.It has a time index, but this should not be intended as a partial compresence, since the time only refers to a part of the classified particular life or extension.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#classified-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#classified-by</seealso>
    let classified_by = Prefixed_Name(ExtendedDnS, "classified-by") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:cognitive-event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An event occurring in the (embodied) mind.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#cognitive-event">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#cognitive-event</seealso>
    let cognitive_event = Prefixed_Name(ExtendedDnS, "cognitive-event") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:d-uses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Descriptions can d-use (descriptively use) concepts or figures, provided that used ones are defined by some description.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#d-uses">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#d-uses</seealso>
    let d_uses = Prefixed_Name(ExtendedDnS, "d-uses") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:refines</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Concepts and figures can be refined by adding components, e.g. an elementary task can become complex, a complex task can increase its complexity, maximal tasks can be composed, etc.A description gets expanded if one of the concepts or figures it uses are refined.Refinement applies also to collections, situations, and information objects.Descriptions are refined by adding component descriptions.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#refines">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#refines</seealso>
    let refines = Prefixed_Name(ExtendedDnS, "refines") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:regulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A description usually requiring a C-SAT satisfaction for a situation. Norms, codes of practice, etc. are examples.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#regulation">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#regulation</seealso>
    let regulation = Prefixed_Name(ExtendedDnS, "regulation") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:regulates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A regulation states reified conditions on how a situation should look like. Regulations are mostly taken as descriptions for the social world.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#regulates">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#regulates</seealso>
    let regulates = Prefixed_Name(ExtendedDnS, "regulates") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:required-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#required-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#required-by</seealso>
    let required_by = Prefixed_Name(ExtendedDnS, "required-by") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:requires</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#requires">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#requires</seealso>
    let requires = Prefixed_Name(ExtendedDnS, "requires") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:requisite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Requisites are constraints over the attributes of entities. Within DnS, a requisite-for relation holds between parameters (that bound regions to certain value ranges), and either roles, figures or courses. When a situation satisfies a description with parameters, endurants and perdurants in the situation must have attributes that range within the boundaries stated by parameters (in DOLCE terms, entities must have qualities that are mapped to certain value ranges of regions).</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#requisite">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#requisite</seealso>
    let requisite = Prefixed_Name(ExtendedDnS, "requisite") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:right-task-for</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#right-task-for">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#right-task-for</seealso>
    let right_task_for = Prefixed_Name(ExtendedDnS, "right-task-for") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:personifies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A figure can personify a particular, e.g. the holy grail or a goddess, or an organization, which personifies a (postulated) collective.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#personifies">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#personifies</seealso>
    let personifies = Prefixed_Name(ExtendedDnS, "personifies") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:non-agentive-physical-object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Within physical objects, a special place have those to which we ascribe intentions, beliefs, and desires. These are called Agentive, as opposite to Non-agentive. Intentionality is understood here as the capability of heading for/dealing with objects or states of the world. This is an important area of ontological investigation we haven't properly explored yet, so our suggestions are really very preliminary. A possible modelling of case roles has been started within the descriptions plugin that could be embedded within basic DOLCE. In general, we assume that agentive objects are constituted by non-agentive objects: an organism is constituted by bodily organs, a robot is constituted by some machinery, and so on. Among non-agentive physical objects we have for example houses, body organs, pieces of wood, etc.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#non-agentive-physical-object">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#non-agentive-physical-object</seealso>
    let non_agentive_physical_object =
        Prefixed_Name(ExtendedDnS, "non-agentive-physical-object") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:social-object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A catch-all class for entities from the social world. It includes agentive and non-agentive socially-constructed objects: descriptions, concepts, figures, collections, information objects. It could be equivalent to 'non-physical object', but we leave the possibility open of 'private' non-physical objects.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#social-object">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#social-object</seealso>
    let social_object = Prefixed_Name(ExtendedDnS, "social-object") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:c-sat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>C-SAT - like R-SAT - concerns entities that exist in a situation entirely prior to the description. Moreover, it assumes redundant satisfaction. But, differently from P-SAT and R-SAT, no qualified satisfaction is assumed. In fact, C-SAT implies no dependency of a situation on its description. C-SAT typically applies to different views of existing situations, as for regulative descriptions (disclaimer: the situation can be already created by complying to the regulation, e.g executing it as a plan, but in this case there actually exists a plan that has the regulation as part), narratives, symbolic interpretations, etc.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#c-sat">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#c-sat</seealso>
    let c_sat = Prefixed_Name(ExtendedDnS, "c-sat") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:satisfied-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>See also comment on 'satisfies' for a different explanation.This is the     primitive relation between descriptions and situations. It can be     understood as a reification of the 'satisfiability' relation of formal     semantics that holds between theories and models. A theory is reified as a description, thus acquiring a life-cycle: a theory     can be changed, versioned, discussed, issued, etc. 'Theory' can be a 'potential' theory in the sense that most conceptualizations     that could be formalized, could also be reified, e.g. plans, norms,     stories, projects, diagnoses, methods, etc. No position is taken on the     extensionality of descriptions. For example, if a theory is required to be     reified in fine detail, if it changes an axiom, it could be considered no     more the same theory. On the other hand, if theories are reified without such a strong assumption,     some axioms can be changed just like non-essential parts of physical     objects, with the theory preserving its identity.In case a theory is considered extensional, it might be considered a member of     a class of 'theory changing history'. The 'refines' relation provides this     possibility.A model is reified as a situation, thus a *class* of models that can satisfy a     theory is reified as a situation type (class). Situations can depend on     descriptions, but not vice-versa (constructivist stance). Components of     descriptions 'classify' entities of situations.There are at least three     satisfaction subrelations, and a lot of conditions can be stated for     allowing an automatic matching of satisfaction. See the FOL version of DLP     for details.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#satisfied-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#satisfied-by</seealso>
    let satisfied_by = Prefixed_Name(ExtendedDnS, "satisfied-by") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:characterized-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#characterized-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#characterized-by</seealso>
    let characterized_by =
        Prefixed_Name(ExtendedDnS, "characterized-by") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:intensionally-references</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#intensionally-references">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#intensionally-references</seealso>
    let intensionally_references =
        Prefixed_Name(ExtendedDnS, "intensionally-references") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:concept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>AKA C-Description. A non-physical object that is defined by a description s, and whose function is classifying entities from a ground ontology in order to build situations that can satisfy s.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#concept">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#concept</seealso>
    let concept = Prefixed_Name(ExtendedDnS, "concept") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:classifies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A.K.A. 'selects'.The referencing relation between concepts defined by  descriptions, and constituents of situations. It can be understood as a  reification of a 'satisfiability' relation holding between elements of theories and elements of models.It has a time index, but this should not be intended as a partial compresence, since the time only refers to a part of the classified particular life or extension.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#classifies">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#classifies</seealso>
    let classifies = Prefixed_Name(ExtendedDnS, "classifies") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:unified-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#unified-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#unified-by</seealso>
    let unified_by = Prefixed_Name(ExtendedDnS, "unified-by") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:member</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Being a (generic, temporary) constituent in a countable collection, for example: member of a society, bacterium in a colony, etc.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#member">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#member</seealso>
    let member_ = Prefixed_Name(ExtendedDnS, "member") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:regulated-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#regulated-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#regulated-by</seealso>
    let regulated_by = Prefixed_Name(ExtendedDnS, "regulated-by") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:relation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A non-social relation(ship): formal, linguistic, etc. It is considered here a theory, because relations are established in order to give an ordering to some reality.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#relation">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#relation</seealso>
    let relation = Prefixed_Name(ExtendedDnS, "relation") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:c-sat-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#c-sat-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#c-sat-by</seealso>
    let c_sat_by = Prefixed_Name(ExtendedDnS, "c-sat-by") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:characterizes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A role r characterizes a collection c when proper subsets of the members of c play different roles r,...,rn that are all used by a same description or deputed by a same figure.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#characterizes">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#characterizes</seealso>
    let characterizes = Prefixed_Name(ExtendedDnS, "characterizes") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:co-participates-with</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation holding between two endurants participating in a same perdurant. This typically subsumes many common sense, verbally encoded, relations, such as "making", "moving", "transforming", etc.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#co-participates-with">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#co-participates-with</seealso>
    let co_participates_with =
        Prefixed_Name(ExtendedDnS, "co-participates-with") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:cognitive-modal-description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The modal descriptions depending on some mental attitude (i.e. internally represented by a physical agent), represented here by means of a relation between roles and tasks.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#cognitive-modal-description">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#cognitive-modal-description</seealso>
    let cognitive_modal_description =
        Prefixed_Name(ExtendedDnS, "cognitive-modal-description") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:internally-represented-in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The relation between descriptions and agents. Agents have inner (a.k.a. 'mental') states and are endowed with, or produce, representations or conceptualizations, both corresponding here to 'descriptions'. The relation has a time index, but this should not be intended as a partial compresence, since time only refers to the part of the agent's life in which it represents the description (a.k.a. 'conceives', now rejected because of its strong human-rationality connotation). Provisionally, internally-represents is introduced here as an immediate (primitive) relation, but other options are under study. The first involves mediating internal representation through an ontology of mental states and events, while the second is semiotic: since descriptions are expressed by at least one information object, representing internally requires at least one creation/interpretation of an information object, therefore internally-represents would be a 'mediated' relation.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#internally-represented-in">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#internally-represented-in</seealso>
    let internally_represented_in =
        Prefixed_Name(ExtendedDnS, "internally-represented-in") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:r-sat-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#r-sat-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#r-sat-by</seealso>
    let r_sat_by = Prefixed_Name(ExtendedDnS, "r-sat-by") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:modal-description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A modal description is any part of a description that has a unity criterion consisting in the specification of a modal target (some course), and it can be a right, power, duty, etc. Notice that modal descriptions can appear in conventionalized descriptions as well as in idiosyncratic assessements, narratives, promises, etc. From the formal semantic viewpoint, a modal description is the reification of a relation involving a modal logic operator.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#modal-description">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#modal-description</seealso>
    let modal_description =
        Prefixed_Name(ExtendedDnS, "modal-description") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:specialized-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specialization as reification of a partial-order relation between type- or set-reified social objects, i.e. descriptions, concepts, and collections.For example, concepts that are apparently classified by other concepts; e.g. a manager that plays the role of buyer, where the role manager actually specializes the role buyer. Descriptions can be specialized by other descriptions that specialize their concepts. For descriptions, an intention to specialize must be present (unless purely formal theories are considered, but even in this case a criterion of relevance is usually active). Specialization does not imply expansion (proper part) for descriptions. If there exists a concept that is defined by the specialized description, which is not d-used in the specializing one, the second only specializes a part of the first. If there exists a concept that is defined by the specializing description, which is not d-used by the specialized one, the first both specializes and expands the second.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#specialized-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#specialized-by</seealso>
    let specialized_by = Prefixed_Name(ExtendedDnS, "specialized-by") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:non-agentive-figure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A typology of non-agentive figures is currently under investigation.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#non-agentive-figure">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#non-agentive-figure</seealso>
    let non_agentive_figure =
        Prefixed_Name(ExtendedDnS, "non-agentive-figure") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:covered-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#covered-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#covered-by</seealso>
    let covered_by = Prefixed_Name(ExtendedDnS, "covered-by") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:collective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A collection with only agents as members.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#collective">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#collective</seealso>
    let collective = Prefixed_Name(ExtendedDnS, "collective") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:communication-event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Here communication is taken in a rather wide sense, being possible as an (intentional) activity as well as a phenomenon.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#communication-event">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#communication-event</seealso>
    let communication_event =
        Prefixed_Name(ExtendedDnS, "communication-event") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:component</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>'Component' is a proper part with a role (or function) in a system or a context. Roles can be different for the same entity, and the evaluation of them changes according to the kind of entity. For instance, components of endurants can 'play functional roles' in a whole, while components of perdurants are the  essential 'episodes' in their whole.As a functional part relation, component is not transitive, because functions depend on intentions and/or designs, and something intentionally essential for a direct whole, can be non-essential for another, indirect whole.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#component">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#component</seealso>
    let component_ = Prefixed_Name(ExtendedDnS, "component") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:defines</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Descriptions define either concepts or (social) figures. Once defined, they can be d-used by other descriptions.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#defines">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#defines</seealso>
    let defines = Prefixed_Name(ExtendedDnS, "defines") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:parameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A concept that classifies (in particular, it is 'valued by') regions, as defined by some description. Parameters are the descriptive counterpart of regions, and, as regions represent the qualities of perdurants or endurants, they can be requisites for some role or course.A parameter has at least one region that is a value for it.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#parameter">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#parameter</seealso>
    let parameter = Prefixed_Name(ExtendedDnS, "parameter") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:covers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The role shared by all members of a collection has a covering relation towards the collection.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#covers">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#covers</seealso>
    let covers = Prefixed_Name(ExtendedDnS, "covers") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:creates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An important relation between agents and descriptions is creation,  implying that a given description is *specifically* dependent on a rational agent.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#creates">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#creates</seealso>
    let creates = Prefixed_Name(ExtendedDnS, "creates") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:d-used-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#d-used-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#d-used-by</seealso>
    let d_used_by = Prefixed_Name(ExtendedDnS, "d-used-by") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:situation-place-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#situation-place-of">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#situation-place-of</seealso>
    let situation_place_of =
        Prefixed_Name(ExtendedDnS, "situation-place-of") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:social-role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A role created and maintained by a society.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#social-role">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#social-role</seealso>
    let social_role = Prefixed_Name(ExtendedDnS, "social-role") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:component-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#component-of">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#component-of</seealso>
    let component_of = Prefixed_Name(ExtendedDnS, "component-of") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:social-description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Examples of Social Descriptions are laws, norms, shares, peace treaties, etc., which are generically dependent on societies.Social descriptions are dependent on a community of agents.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#social-description">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#social-description</seealso>
    let social_description =
        Prefixed_Name(ExtendedDnS, "social-description") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:requisite-for</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Requisites are constraints over the attributes of entities. Within DnS, a requisite-for relation holds between parameters (that bound regions to certain value ranges), and either roles, figures or courses. When a situation satisfies a description with parameters, endurants and perdurants in the situation must have attributes that range within the boundaries stated by parameters (in DOLCE terms, entities must have qualities that are mapped to certain value ranges of regions).</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#requisite-for">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#requisite-for</seealso>
    let requisite_for = Prefixed_Name(ExtendedDnS, "requisite-for") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:created-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An important relation between agents and descriptions is creation, implying that a given description is *specifically* dependent on a rational agent.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#created-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#created-by</seealso>
    let created_by = Prefixed_Name(ExtendedDnS, "created-by") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:deputed-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#deputed-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#deputed-by</seealso>
    let deputed_by = Prefixed_Name(ExtendedDnS, "deputed-by") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:expressed-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#expressed-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#expressed-by</seealso>
    let expressed_by = Prefixed_Name(ExtendedDnS, "expressed-by") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:description-role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A role played by descriptions only. Usable for metalinguistic notions, like those that deal with granular partitions of knowledge, strata of reality, argumentation, etc.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#description-role">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#description-role</seealso>
    let description_role =
        Prefixed_Name(ExtendedDnS, "description-role") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:technique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A technique is a practical method to obtain some modification in the environment (or evaluation of an environment) that fulfils some task.
    /// Differently from a plan, a technique does not necessarily contains a goal or objective as a proper part.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#technique">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#technique</seealso>
    let technique = Prefixed_Name(ExtendedDnS, "technique") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:unifies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Based on characterizing roles, collections specifically depend on some description.We can therefore build a new relation of unification between collections and the descriptions on which they depend. Unification is axiomatized by means of sufficient conditions, and is not temporalized, since changing the description (differently from changing some members) creates a new collection.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#unifies">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#unifies</seealso>
    let unifies = Prefixed_Name(ExtendedDnS, "unifies") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:used-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#used-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#used-by</seealso>
    let used_by = Prefixed_Name(ExtendedDnS, "used-by") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:right-to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between a role and a right allowance towards some function/task.This is dispositional, and implies that a participation classified by this relation is a 'righteous participation'.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#right-to">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#right-to</seealso>
    let right_to = Prefixed_Name(ExtendedDnS, "right-to") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:situation-place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A highly mediated relation used to talk of the endurant(s) that is roughly associated to the regions in which the constituents of a situation are located. The locator endurant is supposed to be a situation constituent on its own.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#situation-place">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#situation-place</seealso>
    let situation_place = Prefixed_Name(ExtendedDnS, "situation-place") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:social-relationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A social description defining roles for the interaction of rational agents.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#social-relationship">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#social-relationship</seealso>
    let social_relationship =
        Prefixed_Name(ExtendedDnS, "social-relationship") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:desire</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Desires are characterized here as modal description dependent on the cognitive (or 'mental') states of an agent. It is difficult to say more than that without reusing an ontology of cognitive states.Informally: a desire is a description that involves some (possible or actual) 'desire towards' attitude by an agent, and is ultimately motivated by evolutionary features of an organism (or by built-in features if the agent is artificial), which are (or used to be) an advantage for it.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#desire">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#desire</seealso>
    let desire = Prefixed_Name(ExtendedDnS, "desire") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:direct-predecessor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Anti-transitive predecessor.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#direct-predecessor">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#direct-predecessor</seealso>
    let direct_predecessor =
        Prefixed_Name(ExtendedDnS, "direct-predecessor") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:direct-successor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Anti-transitive succession.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#direct-successor">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#direct-successor</seealso>
    let direct_successor =
        Prefixed_Name(ExtendedDnS, "direct-successor") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:empowered-for</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#empowered-for">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#empowered-for</seealso>
    let empowered_for = Prefixed_Name(ExtendedDnS, "empowered-for") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:expanded-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#expanded-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#expanded-by</seealso>
    let expanded_by = Prefixed_Name(ExtendedDnS, "expanded-by") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:expands</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A partial order relation that holds between descriptions. It represents the proper part relation between a description and another description featuring the same properties of the former, with at least an additional one.Descriptions can be expanded either by adding other descriptions as parts, or by refining concepts or figures that are d-used by them.Specializing the concepts or figures that are d-used by them is on the contrary a case of description specialization.For descriptions, an intention to expand must be present (unless purely formal theories are considered, but even in this case a criterion of relevance is usually active).</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#expands">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#expands</seealso>
    let expands = Prefixed_Name(ExtendedDnS, "expands") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:expected-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#expected-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#expected-by</seealso>
    let expected_by = Prefixed_Name(ExtendedDnS, "expected-by") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:expects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The composition of d-uses and sequences relations: a description d-uses a course that sequences a perdurant.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#expects">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#expects</seealso>
    let expects = Prefixed_Name(ExtendedDnS, "expects") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:expected-setting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#expected-setting">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#expected-setting</seealso>
    let expected_setting =
        Prefixed_Name(ExtendedDnS, "expected-setting") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:expected-setting-for</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A double composition is needed here for linking situations and descriptions components, since many possible constituents could be available in the situation. The first one constrains the classifies relation through description components, the second one constrains it through situation constituents.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#expected-setting-for">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#expected-setting-for</seealso>
    let expected_setting_for =
        Prefixed_Name(ExtendedDnS, "expected-setting-for") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:exploits</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A method can exploit an involved endurant when it plays a device-like role.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#exploits">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#exploits</seealso>
    let exploits = Prefixed_Name(ExtendedDnS, "exploits") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:involves</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The composition of d-uses and played-by relations: a description d-uses a role that is played by an endurant.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#involves">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#involves</seealso>
    let involves = Prefixed_Name(ExtendedDnS, "involves") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:expresses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between information objects that are used as representations (signs) and the content (meaning, conceptualization) they represent. In this ontology content is reified as a 'description'.Information objects are 'systemic' objects created by the system of rules of a semiotic code. For the representation between the physical implementation of information objects (physical representations) and information objects, the 'realized-by' relation  is used.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#expresses">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#expresses</seealso>
    let expresses = Prefixed_Name(ExtendedDnS, "expresses") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:gestalt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A perceptual structure, from the descriptive viewpoint. In other words, this encodes the conditions by which a configuration, structure, or arrangement is perceived as a meaningful whole by a perceiving agent.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#gestalt">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#gestalt</seealso>
    let gestalt = Prefixed_Name(ExtendedDnS, "gestalt") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:theory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This is used in a wide cultural sense: a theory about something, expressed in a rather systematic way, but not necessarily public (although communicable in principle). An axiomatic theory is not a theory in this sense, although we can expect an axiomatic theory to be the formal representation of a generic theory.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#theory">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#theory</seealso>
    let theory = Prefixed_Name(ExtendedDnS, "theory") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:setting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#setting">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#setting</seealso>
    let setting = Prefixed_Name(ExtendedDnS, "setting") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:information-object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information objects are social objects. They are realized by some entity. They are ordered (expressed according to) by some system for information encoding. Consequently, they are dependent from an encoding as well as from a concrete realization.They can express a description (the ontological equivalent of a meaning/conceptualization), can be about any entity, and can be interpreted by an agent.From a communication perspective, an information object can play the role of "message". From a semiotic perspective, it playes the role of "expression".</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#information-object">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#information-object</seealso>
    let information_object =
        Prefixed_Name(ExtendedDnS, "information-object") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:acts-for</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Figures are not dependent on roles defined or used in the same descriptions they are defined or used, but they can act because they depute some powers to some of those roles. In other words, a figure selected by some agentive role can play that role because there are other roles in the descriptions that define or use the figure. Those roles select endurants that result to act for the figure.For example, an employee acts for an organization that deputes the role (e.g. turner) that classifies the employee. Simply put, a guy working as a turner at FIAT acts for (or on behalf of) FIAT.In complex figures, like organizations or societies, a total agency is possible when an endurant plays a delegate, or representative role of the figure.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#acts-for">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#acts-for</seealso>
    let acts_for = Prefixed_Name(ExtendedDnS, "acts-for") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Perdurant that exemplifies the intentionality of an agent. Could it be aborted, incomplete, mislead, while remaining a (potential) accomplishment ... The point here is that having a result depends on a method, then an action remains an action under incomplete results. As a matter of fact, if we neutralize intentionality, a purely topological, post-hoc view is at odds with the notion of incomplete accomplishments.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#action">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#action</seealso>
    let action = Prefixed_Name(ExtendedDnS, "action") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:information-encoding-system</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An information encoding system is a description that involves information objects. They can be divided into 1) axiomatic systems, which provide roles and operations to define formal descriptions (e.g. theories), 2) combinatorial systems, which provide roles and operations to create valid information objects (e.g. grammars), 3) classification systems, which are contexts of (ev. ordered) lists of information objects, and 4) informal encoding systems, which provide roles and operations to define informal descriptions (e.g. narratives).</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#information-encoding-system">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#information-encoding-system</seealso>
    let information_encoding_system =
        Prefixed_Name(ExtendedDnS, "information-encoding-system") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:physical-realization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any physical particular that realizes a non-physical endurant. Such physical particulars can be either physical endurants, physical qualities, physical regions, perdurants with at least one physical participant, or a situation with one physical entity in its setting.Ultimately, a physical realization depends on at least one physical endurant (each of the others physical entity types depend on a physical endurant to be considered as such).</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#physical-realization">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#physical-realization</seealso>
    let physical_realization =
        Prefixed_Name(ExtendedDnS, "physical-realization") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:deputes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Figures can depute roles that are played by endurants that are supposed to 'act for' the figure.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#deputes">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#deputes</seealso>
    let deputes = Prefixed_Name(ExtendedDnS, "deputes") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A role that involves responsibility, e.g. both duties and rights, in order to perform some task. It usually involves additional rights and/or powers in contexts (descriptions) different from the one that defines the status.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#status">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#status</seealso>
    let status = Prefixed_Name(ExtendedDnS, "status") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:symmetric-role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A role played exactly by two objects at the same time, e.g.: brother, sibling.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#symmetric-role">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#symmetric-role</seealso>
    let symmetric_role = Prefixed_Name(ExtendedDnS, "symmetric-role") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:temporary-component</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Being component at time t. It holds for endurants only. This is important to model components that can change or be lost over time without affecting the identity of the whole.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#temporary-component">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#temporary-component</seealso>
    let temporary_component =
        Prefixed_Name(ExtendedDnS, "temporary-component") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:temporary-component-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#temporary-component-of">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#temporary-component-of</seealso>
    let temporary_component_of =
        Prefixed_Name(ExtendedDnS, "temporary-component-of") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:uses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The use relations between endurants: an endurant e1 uses e2 within a perdurant in which both are participating. A rule then states that if e1 uses e2, e2 is used *in* a perdurant.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#uses">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#uses</seealso>
    let uses = Prefixed_Name(ExtendedDnS, "uses") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:value-for</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The "selected by" relations holding between regions and parameters. At least one region is supposed to be a value for a parameter.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#value-for">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#value-for</seealso>
    let value_for = Prefixed_Name(ExtendedDnS, "value-for") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:aboutness-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#aboutness-of">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#aboutness-of</seealso>
    let aboutness_of = Prefixed_Name(ExtendedDnS, "aboutness-of") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A catch-all class used to join agentive objects (either physical or social). Agents are dispositionally so, in the sense that they internally represent descriptions, and in particular plans, goals and possible actions, but they do not necessarily act. In everyday language, agent is used in this sense, but also to tell that something has acted in a certain way, or to say that something has an initiator or leading role in some action. In DLP, the performs relation encodes these notions.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#agent">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#agent</seealso>
    let agent = Prefixed_Name(ExtendedDnS, "agent") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:about</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The relation between information objects and entities they are about. The difference with 'expresses' is that the last requires a situation to be about something. E.g. Dante's Comedy is about facts like Dante's travel to the hereafter. The Comedy expresses a script as well as various related meanings, while the facts talked about are not 'expressed'.Given that descriptions are expressed by at least one IO, and that interpretations of IOs requires conceiving a description, and the (plausible) claim that being about something can only be done in context, i.e. within a situation, we can propose that the conceived description is satisfied by the situation (the context) of the entity the IO is about.On this basis, about would result to be a mediated relation. This is still a proposal, then we keep about here as a primitive for some time.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#about">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#about</seealso>
    let about = Prefixed_Name(ExtendedDnS, "about") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:acted-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#acted-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#acted-by</seealso>
    let acted_by = Prefixed_Name(ExtendedDnS, "acted-by") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>In dependency terms, an activity is an action that is generically constantly dependent on a (at least partly) shared plan adopted by participants. This condition implies that an action must be sequenced by a task.Intuitively, activities are complex actions that are at least partly conventionally planned.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#activity">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#activity</seealso>
    let activity = Prefixed_Name(ExtendedDnS, "activity") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:plan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A plan is a method for executing or performing a procedure or a stage of a procedure. A plan must use both at least one role played by an agent, and at least one task. Finally, a plan has a goal as proper part, and can also have regulations and other descriptions as proper parts.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#plan">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#plan</seealso>
    let plan = Prefixed_Name(ExtendedDnS, "plan") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:task</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A course used to sequence activities or other controllable perdurants (some states, processes), usually within methods. They must be defined by a method, but can be *used* by other kinds of descriptions. They are desire targets of some role played by an agent. Tasks can be complex, and ordered according to an abstract succession relation. Tasks can relate to ground activities or decision making; the last kind deals with typical flowchart content. A task is different both from a flowchart node, and from an action or action type.Tasks can be considered shortcuts for plans, since at least one role played by an agent has a desire attitude towards them (possibly different from the one that puts the task into action). In principle, tasks could be transformed into explicit plans.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#task">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#task</seealso>
    let task = Prefixed_Name(ExtendedDnS, "task") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:sequenced-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#sequenced-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#sequenced-by</seealso>
    let sequenced_by = Prefixed_Name(ExtendedDnS, "sequenced-by") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:admits</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The composition of d-uses and valued-by relations: a description d-uses a parameter that is valued by a region.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#admits">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#admits</seealso>
    let admits = Prefixed_Name(ExtendedDnS, "admits") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:adopted-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between agents and descriptions, requiring previous creation by a rational agent, and internal representation by a physical agent, directly, or acted by some social agent. It can involve or not an actual desire to perform the possibly expected actions.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#adopted-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#adopted-by</seealso>
    let adopted_by = Prefixed_Name(ExtendedDnS, "adopted-by") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:agentive-social-object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A social object that is assumed to adopt a plan. Since social objects are dependent on physical ones, adoption involves that a social object is acted-by physical agents that 'internally represents' that plan.
    /// For example, an institution can adopt the plan to promote or regulate some activities, but this is possible by means of the powers conferred to it by some legal system, through its representatives, and that plan has to be executed by means of the physical agents that 'act for' the institution.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#agentive-social-object">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#agentive-social-object</seealso>
    let agentive_social_object =
        Prefixed_Name(ExtendedDnS, "agentive-social-object") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:references</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation holding between non-physical objects and entities whatsoever (thus including non-physical objects themselves). An intuition for the references relation could be that a non-physical object adds  'information' to an entity. In fact, non-physical objects depend on a communication setting. In most cases, this is the characteristic relation that provides a unity criterion to objects, events, etc.  For example, cars are objects and not mere aggregates because there is a  project, a design, a social value, a functional structure, a  personal emotional structure, etc. attached to them. This attachment can be represented by means of 'non-physical objects' that 'reference' cars. The most obvious application is for situations, which do not exist without a description, although they still are extensional entities: a situation without a part is no more the same situation, but a situation is not a mere aggregate, since it has references to a description  as its unity criterion. Adding information to an entity can also be thought as an intentional solution to a holistic stance. Defenders of this view -within different frameworks- are  Kant, Brentano, Husserl, Gestalt psychologists, Merleau-Ponty ... References is distinguished according to the kinds of non-physical objects and referenced  ground entities: referencing between descriptions and situations is called 'SATISFIED-BY', while referencing between description components and situation components is called 'CLASSIFIES'. 'SETTING-FOR' is a referencing relation between situation and the entities in its setting (it was formerly a constitution relation, but since situation appear to be social objects from the DOLCE viewpoint, the constitution solution is no more applicable). 'EXPRESSES' is bound to information objects and the meaning (description of a representation or conceptualization) in which they are involved. 'REALIZED-BY' is bound to information objects and physical representations that are used to communicate them, etc. 'ABOUT' is bound to information objects and entities whatsoever (aboutness of intentionality).</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#references">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#references</seealso>
    let references = Prefixed_Name(ExtendedDnS, "references") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:predecessor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>To be understood as 'entity x  has predecessor y'.This is the transitive version, but it results to be a complex property in OWL-DL, and transitivity should be overruled.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#predecessor">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#predecessor</seealso>
    let predecessor = Prefixed_Name(ExtendedDnS, "predecessor") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:successor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>To be understood as 'entity x  has successor y'. Succession does not exclude connection, but it excludes overlapping. It can be direct or indirect, and assumes a choice (temporal, spatial, abstract, etc.) Cf. the cognitive 'path' schema. This is the transitive version.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#successor">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#successor</seealso>
    let successor = Prefixed_Name(ExtendedDnS, "successor") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:empowered-to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between a role and a power allowed towards some function/task.This is dispositional, and implies that a participation classified by this relation is an 'empowered participation'.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#empowered-to">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#empowered-to</seealso>
    let empowered_to = Prefixed_Name(ExtendedDnS, "empowered-to") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:exploited-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#exploited-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#exploited-by</seealso>
    let exploited_by = Prefixed_Name(ExtendedDnS, "exploited-by") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:method</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A description that contains a specification to do, realize, behave, etc. Subclasses are plan, technique, practice, project, etc.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#method">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#method</seealso>
    let method = Prefixed_Name(ExtendedDnS, "method") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:figure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>a.k.a. 'social individual'. Figures are social objects defined or used by descriptions, but differently from concepts, they do not classify entities. Examples of figures are organizations, political-geographic objects, sacred symbols, etc.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#figure">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#figure</seealso>
    let figure = Prefixed_Name(ExtendedDnS, "figure") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:involved-in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#involved-in">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#involved-in</seealso>
    let involved_in = Prefixed_Name(ExtendedDnS, "involved-in") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:extensionally-equivalent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>Two or more collections can be extensionally equivalent and still not be the same collection. Each collection needs a unifying description which provides its intensional identity criterion.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#extensionally-equivalent">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#extensionally-equivalent</seealso>
    let extensionally_equivalent =
        Prefixed_Name(ExtendedDnS, "extensionally-equivalent") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:flux</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Fluxes are processes that (also) contain accomplishments as constituents. In other words, fluxes emerge out of accomplishments.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#flux">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#flux</seealso>
    let flux = Prefixed_Name(ExtendedDnS, "flux") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:functionally-unified-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#functionally-unified-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#functionally-unified-by</seealso>
    let functionally_unified_by =
        Prefixed_Name(ExtendedDnS, "functionally-unified-by") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:functionally-unifies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A description can provide its unity criterion to a physical object. In this case we say that the description *functionally unifies* the physical object. This relation is equivalent to a composition of a description that unifies a collection whose members are (usually connected) proper parts of a physical object.Ideally, this notion should be used to provide a definition to physical objects, but this application would destroy the distinction between a 'perceived' object (an endurant whose unity depends on the perception competence of an agent), and a 'functional' object, since each perceived object would be such because it is functionally unified by a description conceived by the perceiving agent. In DOLCE we still apply to the distinction between perception and function.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#functionally-unifies">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#functionally-unifies</seealso>
    let functionally_unifies =
        Prefixed_Name(ExtendedDnS, "functionally-unifies") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:goal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>We are proposing here a restrictive notion of goal that relies upon its desirability by some agent, which does not necessarily play a role in the execution of the plan the goal is a part of. For example, an agent can have an attitude towards some task defined in a plan, e.g. duty towards, which is different from desiring it (desire towards). We might say that a goal is usually desired by the creator or beneficiary of a plan. The minimal constraint for a goal is that it is a proper part of a plan. For example, a desire to start a relationship can become a goal if someone decides to take action (or lets someone else take it for her sake) to obtain it.
    /// A goal is different from anobjective, because the second one is independent from the cognitive state of a particular physical agent.
    /// In practice, an agent (physical or social) may aim at realizing an objective even though the realizing situation conflicts with a goal-situation of the same agent.
    /// In 'private' plans of a physical agent,  realizing situations usually coincide with goal-situations.
    /// Different cases occur with plans endorsed by social agents like organizations, institutions, etc., which are more clearly aimed at realizing objectives.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#goal">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#goal</seealso>
    let goal = Prefixed_Name(ExtendedDnS, "goal") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:has-in-scope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>When there is an 'epistemological layering', i.e. a description d involves another description d' (one of the roles in d classifies d'), a situation that satisfies d', will be in the scope of d as well.For example, a judgment procedure will have a legal case in its scope, but being a legal case depends on satisfying some legal description not identical to that procedure.Another example: a plan assessment is a technique to evaluate a plan execute, and the assessment 'has in scope' the plan execution.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#has-in-scope">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#has-in-scope</seealso>
    let has_in_scope = Prefixed_Name(ExtendedDnS, "has-in-scope") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:has-method</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An activity expected by a method.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#has-method">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#has-method</seealso>
    let has_method = Prefixed_Name(ExtendedDnS, "has-method") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:method-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#method-of">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#method-of</seealso>
    let method_of = Prefixed_Name(ExtendedDnS, "method-of") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:indicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A parameter valued by regions that are used asindicators for some behaviour or event to be checked.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#indicator">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#indicator</seealso>
    let indicator = Prefixed_Name(ExtendedDnS, "indicator") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:ordered-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>a.k.a. 'expressed according to'. The relation between information objects and the languages, codes, grammars, etc. that they are ordered by. E.g. Dante's Comedy is ordered by Middle Age Italian language (in this case, a complex of encoding systems).In principle, any description can be used as an encoding system, but in practice, only some combinatorial systems are used for encoding (see module on 'information objects').</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#ordered-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#ordered-by</seealso>
    let ordered_by = Prefixed_Name(ExtendedDnS, "ordered-by") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:realized-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>a.k.a. support.A (usually physical) representation (p. endurant, p. perdurant, p. quality, p. region, or p. situation) realizes a non-physical object according to a system of rules.The main use of this relation is between information objects and the entities through which information objects are used and interpreted. E.g. a paper copy of the 1861 edition of Dante's Comedy, with Dore's illustrations, realizes the Comedy (as an information object).There is a sense in which any entity that realizes an IO also realizes an IO about itself.For example, a painting realizing information about a woman also realizes information about its own information. Of course, the converse of the previous axiom does not hold in general.For example, the information about a woman can be realized by entities different from that woman (as when referring to an absent woman). In other words, an entity (in a semiotic perspective) always realizes two information objects: one about itself, and another about something else.In the non-representation cases, the information objects are identical (an entity only realizes information about itself).Therefore entities, once they have a relevance in a society, can have semiotic properties. Even physical artifacts that are not built primarily for communicative purposes  e.g. a chair  can be considered as realizing some IO that expresses a design description (cf. system-design), and is about a context (situation) of use, fruition, or just affordance that satisfies the design.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#realized-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#realized-by</seealso>
    let realized_by = Prefixed_Name(ExtendedDnS, "realized-by") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:instantiated-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#instantiated-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#instantiated-by</seealso>
    let instantiated_by = Prefixed_Name(ExtendedDnS, "instantiated-by") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:instantiates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The maximal specialization achievable according to some criterion. Only applicable to social objects that logically reify set-related entities (relations, classes, sets).</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#instantiates">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#instantiates</seealso>
    let instantiates = Prefixed_Name(ExtendedDnS, "instantiates") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:specializes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specialization as reification of a partial-order relation between social objects. For example, concepts that are apparently classified by other concepts; e.g. a manager that plays the role of buyer, where the role manager actually specializes the role buyer. Descriptions can be specialized by other descriptions that specialize their concepts or figures. For descriptions, an intention to specialize must be present (unless purely formal theories are considered, but even in this case a criterion of relevance is usually active). Specialization does not imply expansion (proper part) for descriptions. If there exists a concept that is defined by the specialized description, which is not d-used in the specializing one, the second only specializes a part of the first. If there exists a concept that is defined by the specializing description, which is not d-used by the specialized one, the first both specializes and expands the second.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#specializes">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#specializes</seealso>
    let specializes = Prefixed_Name(ExtendedDnS, "specializes") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:interpreted-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#interpreted-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#interpreted-by</seealso>
    let interpreted_by = Prefixed_Name(ExtendedDnS, "interpreted-by") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:interprets</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The relation between agents and information objects. In order to interpret something, an agent should conceive a description that results to be 'expressed by' that information object.Interprets implies that an expressed description is conceived by the agent (i.e., when an agent interprets an IO, it conceives of a description expressed by the IO; of course two agents can conceive of different descriptions, then resulting in different interpretations).</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#interprets">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#interprets</seealso>
    let interprets = Prefixed_Name(ExtendedDnS, "interprets") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:sequences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This is the immediate relation between courses and perdurants. A course can be either atomic, being a simple 'perdurant role', or it can be complex, thus creating an abstract ordering over a temporal or causal sequence of processes or actions. The ontology of plans develops in detail intentional complex courses.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#sequences">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#sequences</seealso>
    let sequences = Prefixed_Name(ExtendedDnS, "sequences") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:logical-role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A role used to express logical levels within some layering description or granular partition. A typical example is the Linnean taxonomic ordering, where Phylum or Species are hierarchical roles.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#logical-role">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#logical-role</seealso>
    let logical_role = Prefixed_Name(ExtendedDnS, "logical-role") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:made-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#made-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#made-by</seealso>
    let made_by = Prefixed_Name(ExtendedDnS, "made-by") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:makes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A particular case of an endurant participating in a perdurant that meets (is connected to the beginning of) the life of another endurant.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#makes">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#makes</seealso>
    let makes = Prefixed_Name(ExtendedDnS, "makes") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:cognitive-state</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A state of the (embodied) mind</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#cognitive-state">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#cognitive-state</seealso>
    let cognitive_state = Prefixed_Name(ExtendedDnS, "cognitive-state") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A description is a social object which represents a conceptualization (e.g. a mental object or state), hence it is generically dependent on some agent and communicable. Descriptions define or use concepts or figures, are expressed by an information object and can be satisfied by situations. The typology of descriptions is still preliminary.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#description">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#description</seealso>
    let description = Prefixed_Name(ExtendedDnS, "description") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:rational-agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Either a rational physical object (e.g. an animal capable of meta-representations), or a social object acted by a rational physical object (e.g. an organization).</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#rational-agent">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#rational-agent</seealso>
    let rational_agent = Prefixed_Name(ExtendedDnS, "rational-agent") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:adopts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between agents and descriptions, requiring previous creation by a rational agent, and internal representation by a physical agent, directly, or acted by some social agent. It can involve or not an actual desire to perform the possibly expected actions.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#adopts">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#adopts</seealso>
    let adopts = Prefixed_Name(ExtendedDnS, "adopts") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:agentive-physical-object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Within Physical objects, a special place have those to which we ascribe generic intentionality (compatibly to Brentano's distinction i.e., the ability to represent something to oneself, intentionality is here represented as the ability to internally represent a description).
    /// In particular, we call Agentive, as opposite to Non-agentive, those that are able to internally represent a plan.
    /// In general, we assume that agentive objects are constituted by non-agentive objects: an organism is constituted by bodily organs, a robot is constituted by some machinery, and so on.
    /// Among non-agentive physical objects we have for example houses, bodily organs, pieces of wood, etc.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#agentive-physical-object">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#agentive-physical-object</seealso>
    let agentive_physical_object =
        Prefixed_Name(ExtendedDnS, "agentive-physical-object") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:agent-driven-role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>AKA Agentive-role.A role that can only be played by agents.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#agent-driven-role">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#agent-driven-role</seealso>
    let agent_driven_role =
        Prefixed_Name(ExtendedDnS, "agent-driven-role") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:agentive-figure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Agentive figures are those which are assigned (agentive) roles from a society or community; hence, they can act like a physical agent. Typical agentive figures are societies, organizations, and in general all socially constructed persons. Agentive figures are not dependent on roles defined or used in the same descriptions they are defined or used, but they can act because they depute some powers to some of those roles. In other words, a figure classified by some agentive role can play that role because there are other roles in the descriptions that define or use the figure. Those roles classifies endurants that result to act for the figure. For example, an employee acts for an organization that deputes the role (e.g. turner) that classifies the employee. Simply put, a guy working as a turner at FIAT acts for (or on behalf of) FIAT. In complex figures, like organizations or companies, a total agency is possible when an endurant plays a delegate or representative role of the figure. Since figures are social objects, it is conceivable to find agentive figures that act for other agentive figures.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#agentive-figure">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#agentive-figure</seealso>
    let agentive_figure = Prefixed_Name(ExtendedDnS, "agentive-figure") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:obliged-to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between a role and a duty binding towards some function/task.This is dispositional, and implies that a participation classified by this relation is a 'due participation'.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#obliged-to">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#obliged-to</seealso>
    let obliged_to = Prefixed_Name(ExtendedDnS, "obliged-to") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:optionally-uses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#optionally-uses">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#optionally-uses</seealso>
    let optionally_uses = Prefixed_Name(ExtendedDnS, "optionally-uses") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:p-sat-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#p-sat-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#p-sat-by</seealso>
    let p_sat_by = Prefixed_Name(ExtendedDnS, "p-sat-by") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:valued-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#valued-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#valued-by</seealso>
    let valued_by = Prefixed_Name(ExtendedDnS, "valued-by") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:parametrizes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#parametrizes">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#parametrizes</seealso>
    let parametrizes = Prefixed_Name(ExtendedDnS, "parametrizes") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:path</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A course used to sequence phenomena (non-intentional processes).</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#path">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#path</seealso>
    let path = Prefixed_Name(ExtendedDnS, "path") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:material-artifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>No easy definition of artifactual properties is possible, hence it is better to rely on alternative descriptions and roles: a physical object that shows or is known to have an artifactual origin that counts in the tasks an ontology is supposed to support, will be a material artifact. On the other hand, physical objects that do not show that origin, or that origin is unimportant for the task of the ontology, will be physical bodies. Formally, a restriction is provided here that requires that the collection whose members are (at least some of the) proper parts of a material artifact is *unified* by a plan or project.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#material-artifact">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#material-artifact</seealso>
    let material_artifact =
        Prefixed_Name(ExtendedDnS, "material-artifact") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:project</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A project is a proactively satisfied method. Additionally to a plan, a project includes at least one 'product' role to be played by some endurant (e.g. a house), or one 'result' role played by a perdurant with a definite participant (e.g. a restored state of a house).</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#project">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#project</seealso>
    let project = Prefixed_Name(ExtendedDnS, "project") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:life-cycle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The course of events typical of the life of an object (kind).</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#life-cycle">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#life-cycle</seealso>
    let life_cycle = Prefixed_Name(ExtendedDnS, "life-cycle") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:member-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#member-of">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#member-of</seealso>
    let member_of = Prefixed_Name(ExtendedDnS, "member-of") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:metaphorically-plays</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An endurant of type e1 metaphorically plays a role (defined in a description d2), when that role comes from a metaphorical mapping between the description d1 that grants a unity criterion to endurants of type e1, and another description d2 that grants a unity criterion to endurants of type e2.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#metaphorically-plays">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#metaphorically-plays</seealso>
    let metaphorically_plays =
        Prefixed_Name(ExtendedDnS, "metaphorically-plays") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:admitted-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#admitted-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#admitted-by</seealso>
    let admitted_by = Prefixed_Name(ExtendedDnS, "admitted-by") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:metaphorically-played-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#metaphorically-played-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#metaphorically-played-by</seealso>
    let metaphorically_played_by =
        Prefixed_Name(ExtendedDnS, "metaphorically-played-by") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:objective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The purpose of an agent, either physical or social. It is different from a desire or goal, because it is independent from the cognitive state of a particular physical agent.
    /// In practice, an agent (physical or social) may aim at realizing an objective even though the realizing situation conflicts with a goal-situation of the same agent.
    /// In 'private' plans of a physical agent,  realizing situations usually coincide with goal-situations.
    /// Different cases occur with plans endorsed by social agents like organizations, institutions, etc.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#objective">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#objective</seealso>
    let objective = Prefixed_Name(ExtendedDnS, "objective") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:obligation-for</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#obligation-for">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#obligation-for</seealso>
    let obligation_for = Prefixed_Name(ExtendedDnS, "obligation-for") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:optionally-used-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A task (as any other concept) can be optional within some plan (or any description). In this case, it can be ignored in plan execution without affecting the satisfaction of the plan.Within plans, an task said to be optional should be placed in a way that preserves the topology (the connectedness) of the maximal task, except for sequential tasks, where it can be skipped without affecting the control structure. In fact, an optional task must either be component of a bag or sequential task, or have the concurrent task or the any-order task as a direct predecessor.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#optionally-used-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#optionally-used-by</seealso>
    let optionally_used_by =
        Prefixed_Name(ExtendedDnS, "optionally-used-by") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:orders</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#orders">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#orders</seealso>
    let orders = Prefixed_Name(ExtendedDnS, "orders") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:p-sat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>P-SAT assumes two satisfaction semantics: redundant satisfaction and qualified satisfaction. In order to allow for a correct implementation of the qualified satisfaction, P-SAT requires that the description exists prior to at least some of the entities in the setting of the satisfying situation. Ontologically, it results that P-SAT also implies a specific dependency of the situation on its description. P-SAT typically applies to plans, projects, designs, methods, techniques, game rules, instructions, punishment rules, constitutive descriptions, sanctions, and strategies.A sample P-SAT qualified satisfaction axiom for plans is given in OWL.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#p-sat">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#p-sat</seealso>
    let p_sat = Prefixed_Name(ExtendedDnS, "p-sat") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:parametrized-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The mediated relation between an entity and a parameter through the region at which the entity is localized and that is the value for the parameter.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#parametrized-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#parametrized-by</seealso>
    let parametrized_by = Prefixed_Name(ExtendedDnS, "parametrized-by") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:phenomenon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A phenomenon is basically a process that does not include any intentional active participation. Therefore, it cannot be sequenced by a task.It can be seen as an accomplishment when some intentionality puts boundaries on it (although it is not claimed to be inherently intentional). On the other hand, a purely physical phenomenon does not seem to have inherent boundaries either ... and also for biological processes as well as economic processes this seems to be disputable. If the boundary hypothesis is discarded, phenomenon should migrate under process.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#phenomenon">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#phenomenon</seealso>
    let phenomenon = Prefixed_Name(ExtendedDnS, "phenomenon") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:personified-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A figure can personify a particular, e.g. the holy grail or a goddess, or an organization, which personifies a (postulated) collective.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#personified-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#personified-by</seealso>
    let personified_by = Prefixed_Name(ExtendedDnS, "personified-by") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:physical-phenomenon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A phenomenon having a physical endurant as participant.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#physical-phenomenon">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#physical-phenomenon</seealso>
    let physical_phenomenon =
        Prefixed_Name(ExtendedDnS, "physical-phenomenon") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:realizes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#realizes">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#realizes</seealso>
    let realizes = Prefixed_Name(ExtendedDnS, "realizes") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:setting-for</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The relation between a situation and the entities that are referenced by it. (At least some of, or all) such entities must be classified by concepts defined by the description that the situation is supposed to satisfy.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#setting-for">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#setting-for</seealso>
    let setting_for = Prefixed_Name(ExtendedDnS, "setting-for") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:practice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A social method carried out explicitly or by tradition, spontaneously emerged, or moderately or strongly regulated.
    /// A practice has more relaxed constraints than a plan, and it's characterized by its adoption a agentive social object, e.g. a community.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#practice">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#practice</seealso>
    let practice = Prefixed_Name(ExtendedDnS, "practice") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:r-sat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>R-SAT assumes redundant satisfaction and qualified satisfaction, but it works out that semantics with entities in the situation that entirely exist prior to the description.This seems paradoxical, since a description hardly motivates what happens if it is not present to any agent involved in things happening. For this reason, we postulate a so-called specific retroactive dependency (SRD), meaning that the creator of the description is willing to attribute the status of a scientific law to that description, despite it could not be present before the situation. R-SAT typically applies to explanations that are considered as well-founded in science (physical, social, or cognitive), reverse engineering, criminal investigation, etc. Consider that the actual validity of the explanation is not addressed by the description, but by external evaluation descriptions.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#r-sat">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#r-sat</seealso>
    let r_sat = Prefixed_Name(ExtendedDnS, "r-sat") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:rational-physical-object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>In this ontology, a rational object is encoded as having the ability to internally represent meta-descriptions (descriptions that have other descriptions playing roles used by them). Other theories of rational agency assume desires and intentions for these objects, but in principle any agent can have desires and intentions: the very difference seems to be the ability to choose among different desires or intentions by going 'meta-level'.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#rational-physical-object">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#rational-physical-object</seealso>
    let rational_physical_object =
        Prefixed_Name(ExtendedDnS, "rational-physical-object") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:reconstructed-flux</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Reconstructed fluxes are fluxes that only contain accomplishments as members.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#reconstructed-flux">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#reconstructed-flux</seealso>
    let reconstructed_flux =
        Prefixed_Name(ExtendedDnS, "reconstructed-flux") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:played-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This is the immediate relation between roles and endurants. A role classifies the position (function, use, relevance, ...) of an endurant within a context (description). Roles can be ordered, interdependent, at different layers. etc.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#played-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#played-by</seealso>
    let played_by = Prefixed_Name(ExtendedDnS, "played-by") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Also known as 'functional role'.A concept that classifies (in particular, it is 'played by') endurants, as used in some description. Roles are the descriptive counterpart of endurants, and, as endurants participate in perdurants, they usually have courses as modal targets (see).The typology of roles is still preliminary.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#role">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#role</seealso>
    let role = Prefixed_Name(ExtendedDnS, "role") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:refined-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#refined-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#refined-by</seealso>
    let refined_by = Prefixed_Name(ExtendedDnS, "refined-by") |> PrefixedName
    /// <summary>
    ///   <para>ExtendedDnS:plays</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This is the immediate relation between roles and endurants. A role classifies the position (function, use, relevance, ...) of an endurant within a context (description). Roles can be ordered, interdependent, at different layers. etc.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#plays">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#plays</seealso>
    let plays = Prefixed_Name(ExtendedDnS, "plays") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:constitutive-description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A description whose purpose is defining a figure.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#constitutive-description">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#constitutive-description</seealso>
    let constitutive_description =
        Prefixed_Name(ExtendedDnS, "constitutive-description") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:defined-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#defined-by">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#defined-by</seealso>
    let defined_by = Prefixed_Name(ExtendedDnS, "defined-by") |> PrefixedName

    /// <summary>
    ///   <para>ExtendedDnS:internally-represents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The relation between agents and descriptions. Agents have inner (a.k.a. 'mental') states and are endowed with, or produce, representations or conceptualizations, both corresponding here to 'descriptions'. The relation has a time index, but this should not be intended as a partial compresence, since time only refers to the part of the agent's life in which it represents the description (a.k.a. 'conceives', now rejected because of  its strong human-rationality connotation). Provisionally, internally-represents is introduced here as an immediate (primitive) relation, but other options are under study. The first involves mediating internal representation through an ontology of mental states and events, while the second is semiotic: since descriptions are expressed by at least one information object, representing internally requires at least one creation/interpretation of an information object, therefore internally-represents would be a 'mediated' relation.</para>
    /// </remarks>
    /// <seealso href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#internally-represents">http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#internally-represents</seealso>
    let internally_represents =
        Prefixed_Name(ExtendedDnS, "internally-represents") |> PrefixedName
