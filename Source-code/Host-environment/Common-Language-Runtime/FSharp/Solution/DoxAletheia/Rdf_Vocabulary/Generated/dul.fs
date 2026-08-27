namespace http.www.ontologydesignpatterns.org.ont.dul.DUL.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dul =
    let _namespace_iri = Namespace_Iri dul |> NamespaceIRI
    /// <summary>
    ///   <para>dul:Abstract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Entity that cannot be located in space-time. E.g. mathematical entities: formal semantics elements, regions within dimensional spaces, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Astratto"</para><para>"Abstract"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Abstract">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Abstract</seealso>
    let Abstract = Prefixed_Name(dul, "Abstract") |> PrefixedName
    /// <summary>
    ///   <para>dul:Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Event with at least one Agent that isParticipantIn it, and that executes a Task that typically isDefinedIn a Plan, Workflow, Project, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Azione"</para><para>"Action"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Action">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Action</seealso>
    let Action = Prefixed_Name(dul, "Action") |> PrefixedName
    /// <summary>
    ///   <para>dul:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Additional comment: a computational agent can be considered as a PhysicalAgent that realizes a certain class of algorithms (that can be considered as instances of InformationObject) that allow to obtain some behaviors that are considered typical of agents in general. For an ontology of computational objects based on DOLCE see e.g. http://www.loa-cnr.it/COS/COS.owl, and http://www.loa-cnr.it/KCO/KCO.owl."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Any agentive Object , either physical (e.g. a whale, a robot, an oak), or social (e.g. a corporation, an institution, a community)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Agente"</para><para>"Agent"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Agent">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Agent</seealso>
    let Agent = Prefixed_Name(dul, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>dul:Amount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A quantity, independently from how it is measured, computed, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Amount"</para><para>"Quantità"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Amount">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Amount</seealso>
    let Amount = Prefixed_Name(dul, "Amount") |> PrefixedName
    /// <summary>
    ///   <para>dul:BiologicalObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Biological object"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#BiologicalObject">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#BiologicalObject</seealso>
    let BiologicalObject = Prefixed_Name(dul, "BiologicalObject") |> PrefixedName
    /// <summary>
    ///   <para>dul:ChemicalObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Chemical object"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#ChemicalObject">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#ChemicalObject</seealso>
    let ChemicalObject = Prefixed_Name(dul, "ChemicalObject") |> PrefixedName
    /// <summary>
    ///   <para>dul:Classification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A special kind of Situation that allows to include time indexing for the classifies relation in situations. For example, if a Situation s 'my old cradle is used in these days as a flower pot' isSettingFor the entity 'my old cradle' and the TimeIntervals '8June2007' and '10June2007', and we know that s satisfies a functional Description for aesthetic objects, which defines the Concepts 'flower pot' and 'flower', then we also need to know what concept classifies 'my old cradle' at what time.
    /// In order to solve this issue, we need to create a sub-situation s' for the classification time: 'my old cradle is a flower pot in 8June2007'. Such sub-situation s' isPartOf s."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Classificazione"</para><para>"Classification"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Classification">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Classification</seealso>
    let Classification = Prefixed_Name(dul, "Classification") |> PrefixedName
    /// <summary>
    ///   <para>dul:Collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any container for entities that share one or more common properties. E.g. "stone objects", "the nurses", "the Louvre Aegyptian collection", all the elections for the Italian President of the Republic.
    /// A collection is not a logical class: a collection is a first-order entity, while a class is second-order."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Collection"</para><para>"Collezione"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Collection">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Collection</seealso>
    let Collection = Prefixed_Name(dul, "Collection") |> PrefixedName
    /// <summary>
    ///   <para>dul:Collective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Collection whose members are agents, e.g. "the nurses", "the Italian rockabilly fans".
    /// Collectives, facon de parler, can act as agents, although they are not assumed here to be agents (they are even disjoint from the class SocialAgent). This is represented by admitting collectives in the range of the relations having Agent in their domain or range."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Collettivo"</para><para>"Collective"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Collective">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Collective</seealso>
    let Collective = Prefixed_Name(dul, "Collective") |> PrefixedName
    /// <summary>
    ///   <para>dul:CollectiveAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A SocialAgent that is actedBy agents that are (and act as) members of a Collective. A collective agent can have roles that are also roles of those agents.
    /// For example, in sociology, a 'group action' is the situation in which a number of people (that result to be members of a collective) in a given area behave in a coordinated way in order to achieve a (often common) goal. The Agent in such a Situation is not single, but a CollectiveAgent (a Group). This can be generalized to the notion of social movement, which assumes a large Community or even the entire Society as agents.
    /// The difference between a CollectiveAgent and an Organization is that a Description that introduces a CollectiveAgent is also one that unifies the corresponding Collective. In practice, this difference makes collective agents 'less stable' than organizations, because they have a dedicated, publicly recognizable Description that is conceived to introduce them."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Collective agent"</para><para>"Agente collettivo"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#CollectiveAgent">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#CollectiveAgent</seealso>
    let CollectiveAgent = Prefixed_Name(dul, "CollectiveAgent") |> PrefixedName
    /// <summary>
    ///   <para>dul:Community</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Community"</para><para>"Comunità"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Community">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Community</seealso>
    let Community = Prefixed_Name(dul, "Community") |> PrefixedName
    /// <summary>
    ///   <para>dul:Concept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Concept is a SocialObject, and isDefinedIn some Description; once defined, a Concept can be used in other Description(s). If a Concept isDefinedIn exactly one Description, see the LocalConcept class.
    /// The classifies relation relates Concept(s) to Entity(s) at some TimeInterval"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Concept"</para><para>"Concetto"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Concept">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Concept</seealso>
    let Concept = Prefixed_Name(dul, "Concept") |> PrefixedName
    /// <summary>
    ///   <para>dul:Configuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A collection whose members are 'unified', i.e. organized according to a certain schema that can be represented by a Description.
    /// Typically, a configuration is the collection that emerges out of a composed entity: an industrial artifact, a plan, a discourse, etc.
    /// E.g. a physical book has a configuration provided by the part-whole schema that holds together its cover, pages, ink. That schema, based on the individual relations between the book and its parts, can be represented in a reified way by means of a (structural) description, which is said to 'unify' the book configuration."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Configurazione"</para><para>"Configuration"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Configuration">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Configuration</seealso>
    let Configuration = Prefixed_Name(dul, "Configuration") |> PrefixedName
    /// <summary>
    ///   <para>dul:Contract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"(The content of) an agreement between at least two agents that play a Party Role, about some contract object (a Task to be executed)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Contract"</para><para>"Contratto"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Contract">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Contract</seealso>
    let Contract = Prefixed_Name(dul, "Contract") |> PrefixedName
    /// <summary>
    ///   <para>dul:Description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Description is a SocialObject that represents a conceptualization.
    /// It can be thought also as a 'descriptive context' that uses or defines concepts in order to create a view on a 'relational context' (cf. Situation) out of a set of data or observations.
    /// For example, a Plan is a Description of some actions to be executed by agents in a certain way, with certain parameters; a Diagnosis is a Description that provides an interpretation for a set of observed entities, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Descrizione"</para><para>"Description"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Description">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Description</seealso>
    let Description = Prefixed_Name(dul, "Description") |> PrefixedName
    /// <summary>
    ///   <para>dul:Design</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Description of the Situation, in terms of structure and function, held by an Entity for some reason.
    /// A design is usually accompanied by the rationales behind the construction of the designed Entity (i.e. of the reasons why a design is claimed to be as such). For example, the actual design (a Situation) of a car or of a law is based on both the specification (a Description) of the structure, and the rationales used to construct cars or laws.
    /// While designs typically describe entities to be constructed, they can also be used to describe 'refunctionalized' entities, or to hypothesize unknown functions. For example, a cradle can be refunctionalized as a flowerpot based on a certain home design."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Design"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Design">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Design</seealso>
    let Design = Prefixed_Name(dul, "Design") |> PrefixedName
    /// <summary>
    ///   <para>dul:DesignedArtifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A PhysicalArtifact that is also described by a Design. This excludes simple recycling or refunctionalization of natural objects. Most common sense 'artifacts' can be included in this class: cars, lamps, houses, chips, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Designed artifact"</para><para>"Artefatto progettato"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#DesignedArtifact">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#DesignedArtifact</seealso>
    let DesignedArtifact = Prefixed_Name(dul, "DesignedArtifact") |> PrefixedName
    /// <summary>
    ///   <para>dul:DesignedSubstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#DesignedSubstance">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#DesignedSubstance</seealso>
    let DesignedSubstance = Prefixed_Name(dul, "DesignedSubstance") |> PrefixedName
    /// <summary>
    ///   <para>dul:Diagnosis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Description of the Situation of a system, usually applied in order to control a normal behaviour, or to explain a notable behavior (e.g. a functional breakdown)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Diagnosi"</para><para>"Diagnosis"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Diagnosis">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Diagnosis</seealso>
    let Diagnosis = Prefixed_Name(dul, "Diagnosis") |> PrefixedName
    /// <summary>
    ///   <para>dul:Entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Anything: real, possible, or imaginary, which some modeller wants to talk about for some purpose."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Entity"</para><para>"Entità"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Entity">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Entity</seealso>
    let Entity = Prefixed_Name(dul, "Entity") |> PrefixedName
    /// <summary>
    ///   <para>dul:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any physical, social, or mental process, event, or state.
    ///
    /// More theoretically, events can be classified in different ways, possibly based on 'aspect' (e.g. stative, continuous, accomplishement, achievement, etc.), on 'agentivity' (e.g. intentional, natural, etc.), or on 'typical participants' (e.g. human, physical, abstract, food, etc.).
    /// Here no special direction is taken, and the following explains why: events are related to observable situations, and they can have different views at a same time.
    /// If a position has to be suggested here anyway, the participant-based classification of events seems the most stable and appropriate for many modelling problems.
    ///
    /// (1) Alternative aspectual views
    ///
    /// Consider a same event 'rock erosion in the Sinni valley': it can be conceptualized as an accomplishment (what has brought a certain state to occur), as an achievement (the state resulting from a previous accomplishment), as a punctual event (if we collapse the time interval of the erosion into a time point), or as a transition (something that has changed from a state to a different one).
    /// In the erosion case, we could therefore have good motivations to shift from one aspect to another: a) causation focus, b) effectual focus, c) historical condensation, d) transition (causality).
    ///
    /// The different views refer to the same event, but are still different: how to live with this seeming paradox?
    /// A typical solution e.g. in linguistics (cf. Levin's aspectual classes) and in DOLCE Full (cf. WonderWeb D18 axiomatization) is to classify events based on aspectual differences. But this solution would create different identities for a same event, where the difference is only based on the modeller's attitude.
    /// An alternative solution is applied here, and exploits the notion of (observable) Situation; a Situation is a view, consistent with a Description, which can be observed of a set of entities. It can also be seen as a 'relational context' created by an observer on the basis of a 'frame'. Therefore, a Situation allows to create a context where each particular view can have a proper identity, while the Event preserves its own identity.
    /// For example, ErosionAsAccomplishment is a Situation where rock erosion is observed as a process leading to a certain achievement: the conditions (roles, parameters) that suggest such view are stated in a Description, which acts as a 'theory of accomplishments'. Similarly, ErosionAsTransition is a Situation where rock erosion is observed as an event that has changed a state to another: the conditions for such interpretation are stated in a different Description, which acts as a 'theory of state transitions'.
    /// Consider that in no case the actual event is changed or enriched in parts by the aspectual view.
    ///
    /// (2) Alternative intentionality views
    ///
    /// Similarly to aspectual views, several intentionality views can be provided for a same Event. For example, one can investigate if an avalanche has been caused by immediate natural forces, or if there is any hint of an intentional effort to activate those natural forces.
    /// Also in this case, the Event as such has not different identities, while the causal analysis generates situations with different identities, according to what Description is taken for interpreting the Event.
    /// On the other hand, if the possible actions of an Agent causing the starting of an avalanche are taken as parts of the Event, then this makes its identity change, because we are adding a part to it.
    /// Therefore, if intentionality is a criterion to classify events or not, this depends on if an ontology designer wants to consider causality as a relevant dimension for events' identity.
    ///
    /// (3) Alternative participant views
    ///
    /// A slightly different case is when we consider the basic participants to an Event. In this case, the identity of the Event is affected by the participating objects, because it depends on them.
    /// For example, if snow, mountain slopes, wind, waves, etc. are considered as an avalanche basic participants, or if we also want to add water, human agents, etc., that makes the identity of an avalanche change.
    /// Anyway, this approach to event classification is based on the designer's choices, and more accurately mirrors lexical or commonsense classifications (see. e.g. WordNet 'supersenses' for verb synsets).
    ///
    /// Ultimately, this discussion has no end, because realists will keep defending the idea that events in reality are not changed by the way we describe them, while constructivists will keep defending the idea that, whatever 'true reality' is about, it can't be modelled without the theoretical burden of how we observe and describe it.
    /// Both positions are in principle valid, but, if taken too radically, they focus on issues that are only partly relevant to the aim of computational ontologies, which only attempt to assist domain experts in representing what they want to conceptualize a certain portion of reality according to their own ideas.
    /// For this reason, in this ontology both events and situations are allowed, together with descriptions, in order to encode the modelling needs, independently from the position (if any) chosen by the designer."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Event"</para><para>"Evento"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Event">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Event</seealso>
    let Event = Prefixed_Name(dul, "Event") |> PrefixedName
    /// <summary>
    ///   <para>dul:EventType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Concept that classifies an Event . An event type describes how an Event should be interpreted, executed, expected, seen, etc., according to the Description that the EventType isDefinedIn (or used in)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Event type"</para><para>"Tipo di evento"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#EventType">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#EventType</seealso>
    let EventType = Prefixed_Name(dul, "EventType") |> PrefixedName
    /// <summary>
    ///   <para>dul:FormalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Entities that are formally defined and are considered independent from the social context in which they are used. They cannot be localized in space or time. Also called 'Platonic entities'.
    /// Mathematical and logical entities are included in this class: sets, categories, tuples, costants, variables, etc.
    /// Abstract formal entities are distinguished from information objects, which are supposed to be part of a social context, and are localized in space and time, therefore being (social) objects.
    /// For example, the class 'Quark' is an abstract formal entity from the purely set-theoretical perspective, but it is an InformationObject from the viewpoint of ontology design, when e.g. implemented in a logical language like OWL.
    /// Abstract formal entities are also distinguished from Concept(s), Collection(s), and Description(s), which are part of a social context, therefore being SocialObject(s) as well.
    /// For example, the class 'Quark' is an abstract FormalEntity from the purely set-theoretical perspective, but it is a Concept within history of science and cultural dynamics.
    ///
    /// These distinctions allow to represent two different notions of 'semantics': the first one is abstract and formal ('formal semantics'), and formallyInterprets symbols that are about entities whatsoever; for example, the term 'Quark' isAbout the Collection of all quarks, and that Collection isFormalGroundingFor the abstract class 'Quark' (in the extensional sense).
    /// The second notion is social, localized in space-time ('social semantics'), and can be used to interpret entities in the intensional sense. For example, the Collection of all quarks isCoveredBy the Concept 'Quark', which is also expressed by the term 'Quark'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Entità formale astratta"</para><para>"Formal entity"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#FormalEntity">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#FormalEntity</seealso>
    let FormalEntity = Prefixed_Name(dul, "FormalEntity") |> PrefixedName
    /// <summary>
    ///   <para>dul:FunctionalSubstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Functional substance"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#FunctionalSubstance">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#FunctionalSubstance</seealso>
    let FunctionalSubstance = Prefixed_Name(dul, "FunctionalSubstance") |> PrefixedName
    /// <summary>
    ///   <para>dul:Goal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Description of a Situation that is desired by an Agent, and usually associated to a Plan that describes how to actually achieve it"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Goal"</para><para>"Scopo"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Goal">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Goal</seealso>
    let Goal = Prefixed_Name(dul, "Goal") |> PrefixedName
    /// <summary>
    ///   <para>dul:Group</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A CollectiveAgent whose acting agents conceptualize a same SocialRelation ."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Gruppo"</para><para>"Group"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Group">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Group</seealso>
    let Group = Prefixed_Name(dul, "Group") |> PrefixedName
    /// <summary>
    ///   <para>dul:InformationEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A piece of information, be it concretely realized or not."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#InformationEntity">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#InformationEntity</seealso>
    let InformationEntity = Prefixed_Name(dul, "InformationEntity") |> PrefixedName
    /// <summary>
    ///   <para>dul:InformationObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A piece of information, such as a musical composition, a text, a word, a picture, independently from how it is concretely realized."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Information object"</para><para>"Oggetto informativo"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#InformationObject">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#InformationObject</seealso>
    let InformationObject = Prefixed_Name(dul, "InformationObject") |> PrefixedName

    /// <summary>
    ///   <para>dul:InformationRealization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A concrete realization of an InformationObject, e.g. the written document containing the text of a law."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Informazione concreta"</para><para>"Information realization"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#InformationRealization">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#InformationRealization</seealso>
    let InformationRealization =
        Prefixed_Name(dul, "InformationRealization") |> PrefixedName

    /// <summary>
    ///   <para>dul:LocalConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Concept that isDefinedIn exactly 1 Description. For example, the Concept 'coffee' in a 'preparesCoffee' relation can be defined in that relation, and for all other Description(s) that use it, the isConceptUsedIn property should be applied. Notice therefore that not necessarily all Concept(s) isDefinedIn exactly 1 Description."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Local concept"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#LocalConcept">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#LocalConcept</seealso>
    let LocalConcept = Prefixed_Name(dul, "LocalConcept") |> PrefixedName
    /// <summary>
    ///   <para>dul:Location</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Location">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Location</seealso>
    let Location = Prefixed_Name(dul, "Location") |> PrefixedName
    /// <summary>
    ///   <para>dul:Method</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A method is a Description that defines or uses concepts in order to guide carrying out actions aimed at a solution with respect to a problem.
    /// It is different from a Plan, because plans could be carried out in order to follow a method, but a method can be followed by executing alternative plans."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Metodo"</para><para>"Method"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Method">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Method</seealso>
    let Method = Prefixed_Name(dul, "Method") |> PrefixedName
    /// <summary>
    ///   <para>dul:Narrative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Narrative"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Narrative">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Narrative</seealso>
    let Narrative = Prefixed_Name(dul, "Narrative") |> PrefixedName
    /// <summary>
    ///   <para>dul:NaturalPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A person in the physical commonsense intuition: 'have you seen that person walking down the street?'"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Natural person"</para><para>"Persona fisica"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#NaturalPerson">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#NaturalPerson</seealso>
    let NaturalPerson = Prefixed_Name(dul, "NaturalPerson") |> PrefixedName
    /// <summary>
    ///   <para>dul:Norm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A social norm."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Norm"</para><para>"Norma"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Norm">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Norm</seealso>
    let Norm = Prefixed_Name(dul, "Norm") |> PrefixedName
    /// <summary>
    ///   <para>dul:Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any physical, social, or mental object, or a substance. Following DOLCE Full, objects are always participating in some event (at least their own life), and are spatially located."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Object"</para><para>"Oggetto"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Object">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Object</seealso>
    let Object = Prefixed_Name(dul, "Object") |> PrefixedName
    /// <summary>
    ///   <para>dul:Organism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A physical objects with biological characteristics, typically that organisms can self-reproduce."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Organism"</para><para>"Organismo"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Organism">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Organism</seealso>
    let Organism = Prefixed_Name(dul, "Organism") |> PrefixedName
    /// <summary>
    ///   <para>dul:Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An internally structured, conventionally created SocialAgent, needing a specific Role and Agent that plays it, in order to act."</para>
    ///   <para>"Un agente sociale strutturato internamente e creato convenzionalmente. Per agire, ha bisogno di ruoli e agenti che li ricoprano."</para>
    /// labels<para>"Organization"</para><para>"Organizzazione"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Organization">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Organization</seealso>
    let Organization = Prefixed_Name(dul, "Organization") |> PrefixedName
    /// <summary>
    ///   <para>dul:Parameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Concept that classifies a Region; the difference between a Region and a Parameter is that regions represent sets of observable values, e.g. the height  of a given building, while parameters represent constraints or selections on observable values, e.g. 'VeryHigh'. Therefore, parameters can also be used to constrain regions, e.g. VeryHigh on a subset of values of the Region Height applied to buildings, or to add an external selection criterion , such as measurement units, to regions, e.g. Meter on a subset of values from the Region Length applied to the Region Length applied to roads."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Parameter"</para><para>"Parametro"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Parameter">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Parameter</seealso>
    let Parameter = Prefixed_Name(dul, "Parameter") |> PrefixedName
    /// <summary>
    ///   <para>dul:Pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any invariance detected from a dataset, or from observation; also, any invariance proposed based on top-down considerations.
    /// E.g. patterns detected and abstracted by an organism, by pattern recognition algorithms, by machine learning techniques, etc.
    /// An occurrence of a pattern is an 'observable', or detected Situation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Pattern"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Pattern">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Pattern</seealso>
    let Pattern = Prefixed_Name(dul, "Pattern") |> PrefixedName
    /// <summary>
    ///   <para>dul:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Persons in commonsense intuition, which does not apparently distinguish between either natural or social persons."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Person"</para><para>"Persona {it}"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Person">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Person</seealso>
    let Person = Prefixed_Name(dul, "Person") |> PrefixedName
    /// <summary>
    ///   <para>dul:Personification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A social entity with agentive features, but whose status is the result of a cultural transformation from e.g. a PhysicalObject, an Event, an Abstract, another SocialObject, etc. For example: the holy grail, deus ex machina, gods, magic wands, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Personification"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Personification">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Personification</seealso>
    let Personification = Prefixed_Name(dul, "Personification") |> PrefixedName
    /// <summary>
    ///   <para>dul:PhysicalAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A PhysicalObject that is capable of self-representing (conceptualizing) a Description in order to plan an Action.
    /// A PhysicalAgent is a substrate for (actsFor) a Social Agent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Physical agent"</para><para>"Agente fisico"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#PhysicalAgent">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#PhysicalAgent</seealso>
    let PhysicalAgent = Prefixed_Name(dul, "PhysicalAgent") |> PrefixedName
    /// <summary>
    ///   <para>dul:PhysicalArtifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any PhysicalObject that isDescribedBy a Plan .
    /// This axiomatization is weak, but allows to talk of artifacts in a very general sense, i.e. including recycled objects, objects with an intentional functional change, natural objects that are given a certain function, even though they are not modified or structurally designed, etc. PhysicalArtifact(s) are not considered disjoint from PhysicalBody(s), in order to allow a dual classification when needed. E.g.,
    /// FunctionalSubstance(s) are included here as well.
    /// Immaterial (non-physical) artifacts (e.g. texts, ideas, cultural movements, corporations, communities, etc. can be modelled as social objects (see SocialObject), which are all 'artifactual' in the weak sense assumed here."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Physical artifact"</para><para>"Artefatto fisico"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#PhysicalArtifact">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#PhysicalArtifact</seealso>
    let PhysicalArtifact = Prefixed_Name(dul, "PhysicalArtifact") |> PrefixedName
    /// <summary>
    ///   <para>dul:PhysicalAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Physical value of a physical object, e.g. density, color, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Caratteristica fisica"</para><para>"Physical attribute"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#PhysicalAttribute">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#PhysicalAttribute</seealso>
    let PhysicalAttribute = Prefixed_Name(dul, "PhysicalAttribute") |> PrefixedName
    /// <summary>
    ///   <para>dul:PhysicalBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Physical bodies are PhysicalObject(s), for which we tend to neutralize any possible artifactual character. They can have several granularity levels: geological, chemical, physical, biological, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Physical body"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#PhysicalBody">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#PhysicalBody</seealso>
    let PhysicalBody = Prefixed_Name(dul, "PhysicalBody") |> PrefixedName
    /// <summary>
    ///   <para>dul:PhysicalObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Object that has a proper space region. The prototypical physical object has also an associated mass, but the nature of its mass can greatly vary based on the epistemological status of the object (scientifically measured, subjectively possible, imaginary)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Physical object"</para><para>"Oggetto fisico"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#PhysicalObject">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#PhysicalObject</seealso>
    let PhysicalObject = Prefixed_Name(dul, "PhysicalObject") |> PrefixedName
    /// <summary>
    ///   <para>dul:PhysicalPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A physical object that is inherently located; for example, a water area."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Luogo fisico"</para><para>"Physical place"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#PhysicalPlace">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#PhysicalPlace</seealso>
    let PhysicalPlace = Prefixed_Name(dul, "PhysicalPlace") |> PrefixedName
    /// <summary>
    ///   <para>dul:Place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A location, in a very generic sense: a political geographic entity (Roma, Lesotho), a non-material location determined by the presence of other entities ("the area close to Roma"), pivot events or signs ("the area where the helicopter fell"), complements of other entities ("the area under the table"), etc.
    /// In this generic sense, a Place is an "approximate" location. For an "absolute" location, see the class SpaceRegion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Luogo"</para><para>"Place"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Place">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Place</seealso>
    let Place = Prefixed_Name(dul, "Place") |> PrefixedName
    /// <summary>
    ///   <para>dul:Plan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Description having an explicit Goal, to be achieved by executing the plan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Plan"</para><para>"Piano"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Plan">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Plan</seealso>
    let Plan = Prefixed_Name(dul, "Plan") |> PrefixedName
    /// <summary>
    ///   <para>dul:PlanExecution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Plan executions are situations that proactively satisfy a plan. Subplan executions are proper parts of the whole plan execution."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Plan execution"</para><para>"Esecuzione di piano"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#PlanExecution">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#PlanExecution</seealso>
    let PlanExecution = Prefixed_Name(dul, "PlanExecution") |> PrefixedName
    /// <summary>
    ///   <para>dul:Process</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This is a placeholder for events that are considered in their evolution, or anyway not strictly dependent on agents, tasks, and plans.
    /// See Event class for some thoughts on classifying events. See also 'Transition'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Process"</para><para>"Processo"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Process">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Process</seealso>
    let Process = Prefixed_Name(dul, "Process") |> PrefixedName
    /// <summary>
    ///   <para>dul:Project</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Plan that defines Role(s), Task(s), and a specific structure for tasks to be executed in relation to goals to be achieved, in order to achieve the main goal of the project. In other words, a project is a plan with a subgoal structure and multiple roles and tasks."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Project"</para><para>"Progetto"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Project">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Project</seealso>
    let Project = Prefixed_Name(dul, "Project") |> PrefixedName
    /// <summary>
    ///   <para>dul:Quality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any aspect of an Entity (but not a part of it), which cannot exist without that Entity. For example, the way the surface of a specific PhysicalObject looks like, or the specific light of a place at a certain time, are examples of Quality, while the encoding of a Quality into e.g. a PhysicalAttribute should be modeled as a Region.
    /// From the design viewpoint, the Quality-Region distinction is useful only when individual aspects of an Entity are considered in a domain of discourse.
    /// For example, in an automotive context, it would be irrelevant to consider the aspects of car windows for a specific car, unless the factory wants to check a specific window against design parameters (anomaly detection).
    /// On the other hand, in an antiques context, the individual aspects for a specific piece of furniture are a major focus of attention, and may constitute the actual added value, because the design parameters for old furniture are often not fixed, and may not be viewed as 'anomalies'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Qualità"</para><para>"Quality"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Quality">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Quality</seealso>
    let Quality = Prefixed_Name(dul, "Quality") |> PrefixedName
    /// <summary>
    ///   <para>dul:Region</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any region in a dimensional space (a dimensional space is a maximal Region), which can be used as a value for a quality of an Entity . For example, TimeInterval, SpaceRegion, PhysicalAttribute, Amount, SocialAttribute are all subclasses of Region.
    /// Regions are not data values in the ordinary knowledge representation sense; in order to get patterns for modelling data, see the properties: representsDataValue and hasDataValue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Regione"</para><para>"Region"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Region">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Region</seealso>
    let Region = Prefixed_Name(dul, "Region") |> PrefixedName
    /// <summary>
    ///   <para>dul:Relation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Relations are descriptions that can be considered as the counterpart of formal relations (that are included in the FormalEntity class).
    /// For example, 'givingGrantToInstitution(x,y,z)' with three argument types: Provider(x),Grant(y),Recipient(z), can have a Relation counterpart: 'GivingGrantToInstitution', which defines three Concept instances: Provider,Grant,Recipient.
    /// Since social objects are not formal entities, Relation includes here any 'relation-like' entity in common sense, including social relations."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Relazione"</para><para>"Relation"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Relation">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Relation</seealso>
    let Relation = Prefixed_Name(dul, "Relation") |> PrefixedName
    /// <summary>
    ///   <para>dul:Right</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A legal position by which an Agent is entitled to obtain something from another Agent , under specified circumstances, through an enforcement explicited either in a Law, Contract , etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Right"</para><para>"Diritto"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Right">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Right</seealso>
    let Right = Prefixed_Name(dul, "Right") |> PrefixedName
    /// <summary>
    ///   <para>dul:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Concept that classifies an Object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Role"</para><para>"Ruolo"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Role">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Role</seealso>
    let Role = Prefixed_Name(dul, "Role") |> PrefixedName
    /// <summary>
    ///   <para>dul:Set</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Set"</para><para>"Insieme {it}"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Set">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Set</seealso>
    let Set = Prefixed_Name(dul, "Set") |> PrefixedName
    /// <summary>
    ///   <para>dul:Situation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A view, consistent with ('satisfying') a Description, on a set of entities.
    /// It can also be seen as a 'relational context' created by an observer on the basis of a 'frame' (i.e. a Description).
    /// For example, a PlanExecution is a context including some actions executed by agents according to certain parameters and expected tasks to be achieved from a Plan; a DiagnosedSituation is a context of observed entities that is interpreted on the basis of a Diagnosis, etc.
    /// Situation is also able to represent reified n-ary relations, where isSettingFor is the top-level relation for all binary projections of the n-ary relation. If used in a transformation pattern for n-ary relations, the designer should take care of creating only one subclass of Situation for each n-ary relation, otherwise the 'identification constraint' (Calvanese et al., IJCAI 2001) could be violated."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Situazione"</para><para>"Situation"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Situation">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Situation</seealso>
    let Situation = Prefixed_Name(dul, "Situation") |> PrefixedName
    /// <summary>
    ///   <para>dul:SocialAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any individual whose existence is granted simply by its social communicability and capability of action (through some PhysicalAgent)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Social agent"</para><para>"Agente sociale"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#SocialAgent">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#SocialAgent</seealso>
    let SocialAgent = Prefixed_Name(dul, "SocialAgent") |> PrefixedName
    /// <summary>
    ///   <para>dul:SocialObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Object that exists only within some communication Event, in which at least one PhysicalObject participates in.
    /// In other words, all objects that have been or are created in the process of social communication: for the sake of communication (InformationObject), for incorporating new individuals (SocialAgent, Place), for contextualizing existing entities (Situation), for collecting existing entities (Collection), or for describing existing entities (Description, Concept).
    /// Being dependent on communication, all social objects need to be expressed by some information object (information object are self-expressing)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Oggetto sociale"</para><para>"Social object"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#SocialObject">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#SocialObject</seealso>
    let SocialObject = Prefixed_Name(dul, "SocialObject") |> PrefixedName

    /// <summary>
    ///   <para>dul:SocialObjectAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Region in a dimensional space that is used to represent some characteristic of a SocialObject, e.g. judgment values, social scalars, statistical attributes over a collection of entities, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Social attribute"</para><para>"Caratteristica sociale"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#SocialObjectAttribute">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#SocialObjectAttribute</seealso>
    let SocialObjectAttribute =
        Prefixed_Name(dul, "SocialObjectAttribute") |> PrefixedName

    /// <summary>
    ///   <para>dul:SocialPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A SocialAgent that needs the existence of a specific NaturalPerson in order to act (but the lifetime of the NaturalPerson has only to overlap that of the SocialPerson)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Social person"</para><para>"Persona sociale"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#SocialPerson">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#SocialPerson</seealso>
    let SocialPerson = Prefixed_Name(dul, "SocialPerson") |> PrefixedName
    /// <summary>
    ///   <para>dul:SocialRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any social relationship"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Social relation"</para><para>"Relazione sociale"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#SocialRelation">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#SocialRelation</seealso>
    let SocialRelation = Prefixed_Name(dul, "SocialRelation") |> PrefixedName
    /// <summary>
    ///   <para>dul:SpaceRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Region in a dimensional space that is used to localize an Entity ; i.e., it is not used to represent some characteristic (e.g. it excludes time intervals, colors, size values, judgment values, etc.). Differently from a Place , a space region has a specific dimensional space."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Space region"</para><para>"Regione di spazio"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#SpaceRegion">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#SpaceRegion</seealso>
    let SpaceRegion = Prefixed_Name(dul, "SpaceRegion") |> PrefixedName

    /// <summary>
    ///   <para>dul:SpatioTemporalRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#SpatioTemporalRegion">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#SpatioTemporalRegion</seealso>
    let SpatioTemporalRegion =
        Prefixed_Name(dul, "SpatioTemporalRegion") |> PrefixedName

    /// <summary>
    ///   <para>dul:Substance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any PhysicalBody that has not necessarily specified (designed) boundaries, e.g. a pile of trash, some sand, etc.
    /// In this sense, an artistic object made of trash or a dose of medicine in the form of a pill would be a FunctionalSubstance, and a DesignedArtifact, since its boundaries are specified by a Design; aleatoric objects that are outcomes of an artistic process might be still considered DesignedArtifact(s), and Substance(s)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Substance"</para><para>"Sostanza"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Substance">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Substance</seealso>
    let Substance = Prefixed_Name(dul, "Substance") |> PrefixedName
    /// <summary>
    ///   <para>dul:Task</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An EventType that classifies an Action to be executed.
    /// For example, reaching a destination is a task that can be executed by performing certain actions, e.g. driving a car, buying a train ticket, etc.
    /// The actions to execute a task can also be organized according to a Plan that is not the same as the one that defines the task (if any).
    /// For example, reaching a destination could be defined by a plan to get on holidays, while the plan to execute the task can consist of putting some travels into a sequence."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Task"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Task">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Task</seealso>
    let Task = Prefixed_Name(dul, "Task") |> PrefixedName
    /// <summary>
    ///   <para>dul:Theory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Theory is a Description that represents a set of assumptions for describing something, usually general. Scientific, philosophical, and commonsense theories can be included here.
    /// This class can also be used to act as 'naturalized reifications' of logical theories (of course, they will be necessarily incomplete in this case, because second-order entities are represented as first-order ones)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Theory"</para><para>"Teoria"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Theory">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Theory</seealso>
    let Theory = Prefixed_Name(dul, "Theory") |> PrefixedName
    /// <summary>
    ///   <para>dul:TimeInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any Region in a dimensional space that aims at representing time."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Time interval"</para><para>"Intervallo di tempo"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#TimeInterval">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#TimeInterval</seealso>
    let TimeInterval = Prefixed_Name(dul, "TimeInterval") |> PrefixedName
    /// <summary>
    ///   <para>dul:Transition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A transition is a Situation that creates a context for three TimeInterval(s), two additional different Situation(s), one Event, one Process, and at least one Object: the Event is observed as the cause for the transition, one Situation is the state before the transition, the second Situation is the state after the transition, the Process is the invariance under some different transitions (including the one represented here), in which at least one Object is situated. Finally, the time intervals position the situations and the transitional event in time.
    /// This class of situations partly encodes the ontology underlying typical engineering algebras for processes, e.g. Petri Nets.
    /// A full representation of the transition ontology is outside the expressivity of OWL, because we would need qualified cardinality restrictions,  coreference, property equivalence, and property composition."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Transition"</para><para>"Transizione"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Transition">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Transition</seealso>
    let Transition = Prefixed_Name(dul, "Transition") |> PrefixedName
    /// <summary>
    ///   <para>dul:TypeCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Collection whose members are the maximal set of individuals that share the same (named) type, e.g. "the gem stones", "the Italians".
    /// This class is very useful to apply a variety of the so-called "ClassesAsValues" design pattern, when it is used to talk about the extensional aspect of a class. An alternative variety of the pattern applies to the intensional aspect of a class, and the class Concept should be used instead."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Type collection"</para><para>"Collezione di un tipo"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#TypeCollection">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#TypeCollection</seealso>
    let TypeCollection = Prefixed_Name(dul, "TypeCollection") |> PrefixedName
    /// <summary>
    ///   <para>dul:UnitOfMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Units of measure are conceptualized here as parameters on regions, which can be valued as datatype values."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Unità di misura"</para><para>"Unit of measure"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#UnitOfMeasure">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#UnitOfMeasure</seealso>
    let UnitOfMeasure = Prefixed_Name(dul, "UnitOfMeasure") |> PrefixedName
    /// <summary>
    ///   <para>dul:Workflow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Plan that defines Role(s), Task(s), and a specific structure for tasks to be executed, usually supporting the work of an Organization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Workflow"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Workflow">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Workflow</seealso>
    let Workflow = Prefixed_Name(dul, "Workflow") |> PrefixedName
    /// <summary>
    ///   <para>dul:WorkflowExecution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Workflow execution"</para><para>"Esecuzione di workflow"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#WorkflowExecution">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#WorkflowExecution</seealso>
    let WorkflowExecution = Prefixed_Name(dul, "WorkflowExecution") |> PrefixedName
    /// <summary>
    ///   <para>dul:actsFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation holding between any Agent, and a SocialAgent. In principle, a SocialAgent requires at least one PhysicalAgent in order to act, but this dependency can be 'delegated'; e.g. a university can be acted for by a department, which on its turm is acted for by physical agents."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"agisce per"</para><para>"acts for"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#actsFor">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#actsFor</seealso>
    let actsFor = Prefixed_Name(dul, "actsFor") |> PrefixedName
    /// <summary>
    ///   <para>dul:actsThrough</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation holding between a PhysicalAgent and a SocialAgent. In principle, a SocialAgent requires at least one PhysicalAgent in order to act, but this dependency can be 'delegated', e.g. a university can be acted for by a department, which is acted for by physical agents. AKA isActedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"agisce mediante"</para><para>"acts through"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#actsThrough">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#actsThrough</seealso>
    let actsThrough = Prefixed_Name(dul, "actsThrough") |> PrefixedName
    /// <summary>
    ///   <para>dul:associatedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"A catch-all object property, useful for alignment and querying purposes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"associatedWith"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#associatedWith">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#associatedWith</seealso>
    let associatedWith = Prefixed_Name(dul, "associatedWith") |> PrefixedName
    /// <summary>
    ///   <para>dul:characterizes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between concepts and collections, where a Concept is said to characterize a Collection; it corresponds to a link between the (reified) intensional and extensional interpretations of a _proper subset of_ a (reified) class. This is different from covers, because it refers to an interpretation the entire reified class.
    /// E.g. the collection of vintage saxophones is characterized by the Concept 'manufactured by hand', while it gets covered by the Concept 'Saxophone' with the Parameter 'Vintage'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"characterizes"</para><para>"caratterizza"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#characterizes">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#characterizes</seealso>
    let characterizes = Prefixed_Name(dul, "characterizes") |> PrefixedName
    /// <summary>
    ///   <para>dul:classifies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between a Concept and an Entity, e.g. the Role 'student' classifies a Person 'John'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"classifica"</para><para>"classifies"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#classifies">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#classifies</seealso>
    let classifies = Prefixed_Name(dul, "classifies") |> PrefixedName
    /// <summary>
    ///   <para>dul:conceptualizes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation stating that an Agent is internally representing a SocialObject: situations, descriptions, concepts, etc. E.g., 'John believes in the conspiracy theory'; 'Niels Bohr created the solar-system metaphor for the atomic theory'; 'Jacques assumes all swans are white'; 'the task force members share the attack plan'.
    /// Conceptualizations can be distinguished into different forms, primarily based on the type of SocialObject that is conceptualized. Descriptions and concepts can be 'assumed', situations can be 'believed' or 'known', plans can be 'adopted', etc. (see ontology: http://www.ontologydesignpatterns.org/ont/dul/Conceptualization.owl."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"concettualizza"</para><para>"conceptualizes"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#conceptualizes">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#conceptualizes</seealso>
    let conceptualizes = Prefixed_Name(dul, "conceptualizes") |> PrefixedName
    /// <summary>
    ///   <para>dul:concretelyExpresses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between an InformationRealization and a Description, e.g. 'the printout of the Italian Constitution concretelyExpresses the Italian Constitution'. It should be supplied also with a rule stating that the InformationRealization realizes an InformationObject that expresses the Description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"concretely expresses"</para><para>"esprime concretamente"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#concretelyExpresses">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#concretelyExpresses</seealso>
    let concretelyExpresses = Prefixed_Name(dul, "concretelyExpresses") |> PrefixedName
    /// <summary>
    ///   <para>dul:coparticipatesWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between two objects participating in a same Event; e.g., 'Vitas and Jimmy are playing tennis'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"co-participates with"</para><para>"copartecipa con"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#coparticipatesWith">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#coparticipatesWith</seealso>
    let coparticipatesWith = Prefixed_Name(dul, "coparticipatesWith") |> PrefixedName
    /// <summary>
    ///   <para>dul:covers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between concepts and collections, where a Concept is said to cover a Collection; it corresponds to a link between the (reified) intensional and extensional interpretations of a (reified) class.
    /// E.g. the collection of vintage saxophones is covered by the Concept 'Saxophone' with the Parameter 'Vintage'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ricopre"</para><para>"covers"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#covers">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#covers</seealso>
    let covers = Prefixed_Name(dul, "covers") |> PrefixedName
    /// <summary>
    ///   <para>dul:defines</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between a Description and a Concept, e.g. a Workflow for a governmental Organization defines the Role 'officer', or 'the Italian Traffic Law defines the role Vehicle'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"definisce"</para><para>"defines"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#defines">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#defines</seealso>
    let defines = Prefixed_Name(dul, "defines") |> PrefixedName
    /// <summary>
    ///   <para>dul:definesRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between a description and a role, e.g. the recipe for a cake defines the role 'ingredient'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"definisce il ruolo"</para><para>"defines role"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#definesRole">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#definesRole</seealso>
    let definesRole = Prefixed_Name(dul, "definesRole") |> PrefixedName
    /// <summary>
    ///   <para>dul:definesTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between a description and a task, e.g. the recipe for a cake defines the task 'boil'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"definisce il task"</para><para>"defines task"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#definesTask">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#definesTask</seealso>
    let definesTask = Prefixed_Name(dul, "definesTask") |> PrefixedName
    /// <summary>
    ///   <para>dul:describes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a Description and an Entity : a Description gives a unity to a Collection of parts (the components), or constituents, by assigning a Role to each of them in the context of a whole Object (the system).
    /// A same Entity can be given different descriptions, for example, an old cradle can be given a unifying Description based on the original aesthetic design, the functionality it was built for, or a new aesthetic functionality in which it can be used as a flower pot."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"describes"</para><para>"descrive"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#describes">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#describes</seealso>
    let describes = Prefixed_Name(dul, "describes") |> PrefixedName
    /// <summary>
    ///   <para>dul:directlyFollows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The intransitive follows relation. For example, Wednesday directly precedes Thursday. Directness of precedence depends on the designer conceptualization."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"segue direttamente"</para><para>"directly follows"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#directlyFollows">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#directlyFollows</seealso>
    let directlyFollows = Prefixed_Name(dul, "directlyFollows") |> PrefixedName
    /// <summary>
    ///   <para>dul:directlyPrecedes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The intransitive precedes relation. For example, Monday directly precedes Tuesday. Directness of precedence depends on the designer conceptualization."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"directly precedes"</para><para>"precede direttamente"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#directlyPrecedes">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#directlyPrecedes</seealso>
    let directlyPrecedes = Prefixed_Name(dul, "directlyPrecedes") |> PrefixedName
    /// <summary>
    ///   <para>dul:executesTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between an action and a task, e.g. 'putting some water in a pot and putting the pot on a fire until the water starts bubbling' executes the task 'boiling'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"executes task"</para><para>"esegue il task"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#executesTask">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#executesTask</seealso>
    let executesTask = Prefixed_Name(dul, "executesTask") |> PrefixedName
    /// <summary>
    ///   <para>dul:expands</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A partial order relation that holds between descriptions. It represents the proper part relation between a description and another description featuring the same properties as the former, with at least one additional one.
    /// Descriptions can be expanded either by adding other descriptions as parts, or by refining concepts that are used by them.
    /// An 'intention' to expand must be present (unless purely formal theories are considered, but even in this case a criterion of relevance is usually active)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"expands"</para><para>"espande"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#expands">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#expands</seealso>
    let expands = Prefixed_Name(dul, "expands") |> PrefixedName
    /// <summary>
    ///   <para>dul:expresses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is a large comment field for those who want to investigate the different uses of the 'expresses' relation for modeling different approaches to meaning characterization and modeling.
    /// For example, in all these cases, some aspect of meaning is involved:
    ///
    /// - Beehive means "a structure in which bees are kept, typically in the form of a dome or box." (Oxford dictionary)
    /// - 'Beehive' is a synonym in noun synset 09218159 "beehive|hive" (WordNet)
    /// - 'the term Beehive can be interpreted as the fact of 'being a beehive', i.e. a relation that holds for concepts such as Bee, Honey, Hosting, etc.'
    /// - 'the text of Italian apiculture regulation expresses a rule by which beehives should be kept at least one kilometer away from inhabited areas'
    /// - 'the term Beehive expresses the concept Beehive'
    /// - ''Beehive' for apiculturists does not express the same meaning as for, say, fishermen'
    /// - 'Your meaning of 'Beautiful' does not seem to fit mine'
    /// - ''Beehive' is formally interpreted as the set of all beehives'
    /// - 'from the term 'Beehive', we can build a vector space of statistically significant cooccurring terms in the documents that contain it'
    /// - the lexeme 'Belly' expresses the role 'Body_Part' in the frame 'ObservableBodyParts' (FrameNet)
    ///
    /// As the examples suggest, the 'meaning of meaning' is dependent on the background approach/theory that one assumes. One can hardly make a summary of the too many approaches and theories of meaning, therefore this relation is maybe the most controversial and difficult to explain; normally, in such cases it would be better to give up formalizing.
    /// However, the usefulness of having a 'semantic abstraction' in modeling information objects is so high (e.g. for the semantic web, interoperability, reengineering, etc.), that we accept this challenging task, although without taking any particular position in the debate.
    /// We provide here some examples, which we want to generalize upon when using the 'expresses' relation to model semantic aspects of social reality.
    ///
    /// In the most common approach, lexicographers that write dictionaries, glossaries, etc. assume that the meaning of a term is a paraphrase (or 'gloss', or 'definition').
    /// Another approach is provided by concept schemes like thesauri and lexicons, which assume that the meaning of a term is a 'concept', encoded as a 'lemma', 'synset', or 'descriptor'.
    /// Still another approach is that of psychologists and cognitive scientists, which often assume that the meaning of an information object is a concept encoded in the mind or cognitive system of an agent.
    /// A radically different approach is taken by social scientists and semioticians, who usually assume that meanings of an information object are spread across the communication practices in which members of a community use that object.
    /// Another approach that tackles the distributed nature of meaning is assumed by geometrical models of semantics, which assume that the meaning of an InformationObject (e.g. a word) results from the set of informational contexts (e.g. within texts) in which that object is used similarly.
    /// The logical approach to meaning is still different, since it assumes that the meaning of e.g. a term is equivalent to the set of individuals that the term can be applied to; for example, the meaning of 'Ali' is e.g. an individual person called Ali, the meaning of 'Airplane' is e.g. the set of airplanes, etc.
    /// Finally, an approach taken by structuralist linguistics and frame semantics is that a meaning is the relational context in which an information object can be applied; for example, a meaning of 'Airplane' is situated e.g. in the context ('frame') of passenger airline flights.
    ///
    /// These different approaches are not necessarily conflicting, and they mostly talk about different aspects of so-called 'semantics'. They can be summarized and modelled within DOLCE-Ultralite as follows (notice that such list is far from exhaustive):
    ///
    /// (1) Informal meaning (as for linguistic or commonsense semantics: a distinction is assumed between (informal) meaning and reference; see isAbout for an alternative pattern on reference)
    /// 	- Paraphrase meaning (as for lexicographic semantics). Here it is modelled as the expresses relation between instances of InformationObject and different instances of InformationObject that act as 'paraphrases'
    /// 	- Conceptual meaning (as for 'concept scheme' semantics). Here it is modelled as the expresses relation between instances of InformationObject and instances of Concept
    /// 	- Relational meaning (as for frame semantics). Here it is modelled as the expresses relation between instances of InformationObject and instances of Description
    /// 	- Cognitive meaning (as for 'psychological' semantics). Here it is modelled as the expresses relation between any instance of InformationObject and any different instance of InformationObject that isRealizedBy a mental, cognitive or neural state (depending on which theory of mind is assumed). Such states can be considered here as instances of Process (occurring in the mind, cognitive system, or neural system of an agent)
    /// 	- Cultural meaning (as for 'social science' semantics). Here it is modelled as the expresses relation between instances of InformationObject and instances of SocialObject (institutions, cultural paradigms, norms, social practices, etc.)
    /// 	- Distributional meaning (as for geometrical models of meaning). Here it is modelled as the expresses relation between any instance of InformationObject and any different instance of InformationObject that isFormallyRepresentedIn some (geometrical) Region (e.g. a vector space)
    ///
    /// (2) Formal meaning (as for logic and formal semantics: no distinction is assumed between informal meaning and reference, therefore between 'expresses' and 'isAbout', which can be used interchangeably)
    /// 	- Object-level formal meaning (as in the traditional first-order logic semantics). Here it is modelled as the expresses relation between an instance of InformationObject and an instance of Collection that isGroundingFor (in most cases) a Set; isGroundingFor is defined in the ontology: http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl
    /// 	- Modal formal meaning (as in possible-world semantics). Here it is modelled as the expresses relation between an instance of InformationObject and an instance of Collection that isGroundingFor a Set, and which isPartOf some different instance of Collection that isGroundingFor a PossibleWorld
    ///
    /// This is only a first step to provide a framework, in which one can model different aspects of meaning. A more developed ontology should approach the problem of integrating the different uses of 'expresses', so that different theories, resources, methods can interoperate."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A relation between an InformationObject and a 'meaning', generalized here as a 'SocialObject'. For example: 'A Beehive is a structure in which bees are kept, typically in the form of a dome or box.' (Oxford dictionary)'; 'the term Beehive expresses the concept Beehive in my apiculture ontology'.
    /// The intuition for 'meaning' is intended to be very broad. A separate, large comment is included for those who want to investigate more on what kind of meaning can be represented in what form."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"esprime"</para><para>"expresses"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#expresses">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#expresses</seealso>
    let expresses = Prefixed_Name(dul, "expresses") |> PrefixedName
    /// <summary>
    ///   <para>dul:expressesConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between an InformationObject and a Concept , e.g. the term "dog" expresses the Concept "dog". For expressing a relational meaning, see the more general object property: expresses"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"esprime il concetto"</para><para>"expresses concept"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#expressesConcept">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#expressesConcept</seealso>
    let expressesConcept = Prefixed_Name(dul, "expressesConcept") |> PrefixedName
    /// <summary>
    ///   <para>dul:farFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>"Generic distance relation between any Entity(s). E.g. Rome is far from Beijing, astronomy is far from necromancy."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"far from"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#farFrom">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#farFrom</seealso>
    let farFrom = Prefixed_Name(dul, "farFrom") |> PrefixedName
    /// <summary>
    ///   <para>dul:follows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between entities, expressing a 'sequence' schema.
    /// E.g. 'year 2000 follows 1999', 'preparing coffee' follows 'deciding what coffee to use', 'II World War follows I World War', etc.
    /// It can be used between tasks, processes or time intervals, and subproperties would fit best in order to distinguish the different uses."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"follows"</para><para>"segue"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#follows">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#follows</seealso>
    let follows = Prefixed_Name(dul, "follows") |> PrefixedName
    /// <summary>
    ///   <para>dul:hasCommonBoundary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation to encode either formal or informal characterizations of 'boundaries' common to two different entities: an Event that ends when another begins, two abstract regions that have a common topological boundary, two objects that are said to be 'in contact' from a commonsense perspective, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has common boundary"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasCommonBoundary">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasCommonBoundary</seealso>
    let hasCommonBoundary = Prefixed_Name(dul, "hasCommonBoundary") |> PrefixedName
    /// <summary>
    ///   <para>dul:hasComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The hasPart relation without transitivity, holding between an Object (the system) and another (the component), and assuming a Design that structures the Object."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ha componente"</para><para>"has component"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasComponent">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasComponent</seealso>
    let hasComponent = Prefixed_Name(dul, "hasComponent") |> PrefixedName
    /// <summary>
    ///   <para>dul:hasConstituent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"'Constituency' depends on some layering of  the world described by the ontology. For example, scientific granularities (e.g. body-organ-tissue-cell) or ontological 'strata' (e.g. social-mental-biological-physical) are  typical layerings.
    /// Intuitively, a constituent is a part belonging to a lower layer. Since layering is actually a partition of the world described by the ontology, constituents are not properly classified as parts, although this kinship can be intuitive for common sense.
    /// A desirable advantage of this distinction is that we are able to talk e.g. of physical constituents of non-physical objects (e.g. systems), while this is not possible in terms of parts.
    /// Example of are the persons constituting a social system, the molecules constituting a person, the atoms constituting a river, etc.
    /// In all these examples, we notice a typical discontinuity between the constituted and the constituent object: e.g. a social system is conceptualized at a different layer from the persons that constitute it, a person is conceptualized at a different layer from the molecules that constitute them, and a river is conceptualized at a different layer from the atoms that constitute it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has constituent"</para><para>"ha costituente"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasConstituent">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasConstituent</seealso>
    let hasConstituent = Prefixed_Name(dul, "hasConstituent") |> PrefixedName
    /// <summary>
    ///   <para>dul:hasConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between parameters and entities. It allows to assert generic constraints (encoded as parameters), e.g. MinimumAgeForDriving isConstraintFor John (where John is a legal subject under the TrafficLaw).
    /// The intended semantics (not expressible in OWL) is that a Parameter isParameterFor a Concept that classifies an Entity; moreover, it entails that a Parameter parametrizes a Region that isRegionFor that Entity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ha vincolo"</para><para>"has constraint"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasConstraint">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasConstraint</seealso>
    let hasConstraint = Prefixed_Name(dul, "hasConstraint") |> PrefixedName
    /// <summary>
    ///   <para>dul:hasDataValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A datatype property that encodes values from a datatype for an Entity.
    /// There are several ways to encode values in DOLCE (Ultralite):
    ///
    /// 1) Directly assert an xsd:_ value to an Entity by using hasDataValue
    /// 2) Assert a Region for an Entity by using hasRegion, and then assert an xsd:_ value to that Region, by using hasRegionDataValue
    /// 3) Assert a Quality for an Entity by using hasQuality, then assert a Region for that Quality, and assert an xsd:_ value to that Region, by using hasRegionDataValue
    /// 4) When the value is required, but not directly observed, assert a Parameter for an xsd:_ value by using hasParameterDataValue, and then associate the Parameter to an Entity by using isConstraintFor
    /// 5) When the value is required, but not directly observed, you can also assert a Parameter for a Region by using parametrizes, and then assert an xsd:_ value to that Region, by using hasRegionDataValue
    ///
    /// The five approaches obey different requirements.
    /// For example, a simple value can be easily asserted by using pattern (1), but if one needs to assert an interval between two values, a Region should be introduced to materialize that interval, as pattern (2) suggests.
    /// Furthermore, if one needs to distinguish the individual Quality of a value, e.g. the particular nature of the density of a substance, pattern (3) can be used.
    /// Patterns (4) and (5) should be used instead when a constraint or a selection is modeled, independently from the actual observation of values in the real world."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has data value"</para><para>"ha valore"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasDataValue">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasDataValue</seealso>
    let hasDataValue = Prefixed_Name(dul, "hasDataValue") |> PrefixedName
    /// <summary>
    ///   <para>dul:hasEventDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A datatype property that encodes values from xsd:date for an Event; a same Event can have more than one xsd:date value: begin date, end date, date at which the interval holds, as well as dates expressed in different formats: xsd:gYear, xsd:dateTime, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"evento ha data"</para><para>"has event date"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasEventDate">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasEventDate</seealso>
    let hasEventDate = Prefixed_Name(dul, "hasEventDate") |> PrefixedName
    /// <summary>
    ///   <para>dul:hasIntervalDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A datatype property that encodes values from xsd:date for a TimeInterval; a same TimeInterval can have more than one xsd:date value: begin date, end date, date at which the interval holds, as well as dates expressed in different formats: xsd:gYear, xsd:dateTime, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has interval date"</para><para>"intervallo ha data"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasIntervalDate">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasIntervalDate</seealso>
    let hasIntervalDate = Prefixed_Name(dul, "hasIntervalDate") |> PrefixedName
    /// <summary>
    ///   <para>dul:hasLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A generic, relative spatial location, holding between any entities. E.g. 'the cat is on the mat', 'Omar is in Samarcanda', 'the wound is close to the femural artery'.
    /// For 'absolute' locations, see SpaceRegion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ha localizzazione"</para><para>"has location"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasLocation">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasLocation</seealso>
    let hasLocation = Prefixed_Name(dul, "hasLocation") |> PrefixedName
    /// <summary>
    ///   <para>dul:hasMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between collections and entities, e.g. 'my collection of saxophones includes an old Adolphe Sax original alto' (i.e. my collection has member an Adolphe Sax alto)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ha membro"</para><para>"has member"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasMember">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasMember</seealso>
    let hasMember = Prefixed_Name(dul, "hasMember") |> PrefixedName
    /// <summary>
    ///   <para>dul:hasParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Concept can have a Parameter that constrains the attributes that a classified Entity can have in a certain Situation, e.g. a 4WheelDriver Role definedIn the ItalianTrafficLaw has a MinimumAge parameter on the Amount 16."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ha parametro"</para><para>"has parameter"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasParameter">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasParameter</seealso>
    let hasParameter = Prefixed_Name(dul, "hasParameter") |> PrefixedName

    /// <summary>
    ///   <para>dul:hasParameterDataValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Parametrizes values from a datatype. For example, a Parameter MinimumAgeForDriving hasParameterDataValue 18 on datatype xsd:int, in the Italian traffic code. In this example, MinimumAgeForDriving isDefinedIn the Norm ItalianTrafficCodeAgeDriving.
    /// More complex parametrization requires workarounds. E.g. AgeRangeForDrugUsage could parametrize data value: 14 to 50 on the datatype: xsd:int. Since complex datatypes are not allowed in OWL1.0, a solution to this can only work by creating two 'sub-parameters': MinimumAgeForDrugUsage (that hasParameterDataValue 14) and MaximumAgeForDrugUsage (that hasParameterDataValue 50), which are components of (cf. hasComponent) the main Parameter AgeRangeForDrugUsage.
    /// Ordering on subparameters can be created by using or specializing the object property 'precedes'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has parameter data value"</para><para>"ha valore"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasParameterDataValue">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasParameterDataValue</seealso>
    let hasParameterDataValue =
        Prefixed_Name(dul, "hasParameterDataValue") |> PrefixedName

    /// <summary>
    ///   <para>dul:hasPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"A schematic relation between any entities, e.g. 'the human body has a brain as part', '20th century contains year 1923', 'World War II includes the Pearl Harbour event'.
    /// Subproperties and restrictions can be used to specialize hasPart for objects, events, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has part"</para><para>"ha parte"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasPart">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasPart</seealso>
    let hasPart = Prefixed_Name(dul, "hasPart") |> PrefixedName
    /// <summary>
    ///   <para>dul:hasParticipant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between an object and a process, e.g. 'John took part in the discussion', 'a large mass of snow fell during the avalanche', or 'a cook, some sugar, flour, etc. are all present in the cooking of a cake'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has participant"</para><para>"ha come partecipante"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasParticipant">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasParticipant</seealso>
    let hasParticipant = Prefixed_Name(dul, "hasParticipant") |> PrefixedName
    /// <summary>
    ///   <para>dul:hasPostcondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Direct succession applied to situations.
    /// E.g., 'A postcondition of our Plan is to have things settled'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has postcondition"</para><para>"ha postcondizione"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasPostcondition">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasPostcondition</seealso>
    let hasPostcondition = Prefixed_Name(dul, "hasPostcondition") |> PrefixedName
    /// <summary>
    ///   <para>dul:hasPrecondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Direct precedence applied to situations.
    /// E.g., 'A precondition to declare war against a foreign country is claiming to find nuclear weapons in it'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has precondition"</para><para>"ha precondizione"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasPrecondition">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasPrecondition</seealso>
    let hasPrecondition = Prefixed_Name(dul, "hasPrecondition") |> PrefixedName
    /// <summary>
    ///   <para>dul:hasQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between entities and qualities, e.g. 'Dmitri's skin is yellowish'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has quality"</para><para>"ha qualità"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasQuality">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasQuality</seealso>
    let hasQuality = Prefixed_Name(dul, "hasQuality") |> PrefixedName
    /// <summary>
    ///   <para>dul:hasRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between entities and regions, e.g. 'the number of wheels of that truck is 12', 'the time of the experiment is August 9th, 2004', 'the whale has been localized at 34 degrees E, 20 degrees S'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ha attributo"</para><para>"has region"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasRegion">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasRegion</seealso>
    let hasRegion = Prefixed_Name(dul, "hasRegion") |> PrefixedName
    /// <summary>
    ///   <para>dul:hasRegionDataValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A datatype property that encodes values for a Region, e.g. a float for the Region Height."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"regione ha valore"</para><para>"has region data value"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasRegionDataValue">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasRegionDataValue</seealso>
    let hasRegionDataValue = Prefixed_Name(dul, "hasRegionDataValue") |> PrefixedName
    /// <summary>
    ///   <para>dul:hasRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between an object and a role, e.g. the person 'John' has role 'student'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ha ruolo"</para><para>"has role"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasRole">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasRole</seealso>
    let hasRole = Prefixed_Name(dul, "hasRole") |> PrefixedName
    /// <summary>
    ///   <para>dul:hasSetting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between entities and situations, e.g. 'this morning I've prepared my coffee with a new fantastic Arabica', i.e.: (an amount of) a new fantastic Arabica hasSetting the preparation of my coffee this morning."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has setting"</para><para>"è nel contesto di"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasSetting">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasSetting</seealso>
    let hasSetting = Prefixed_Name(dul, "hasSetting") |> PrefixedName
    /// <summary>
    ///   <para>dul:hasTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between roles and tasks, e.g. 'students have the duty of giving exams' (i.e. the Role 'student' hasTask the Task 'giving exams')."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has task"</para><para>"ha come obiettivo"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasTask">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasTask</seealso>
    let hasTask = Prefixed_Name(dul, "hasTask") |> PrefixedName
    /// <summary>
    ///   <para>dul:hasTimeInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The generic relation between events and time intervals."</para>
    /// labels<para>"has time interval"</para><para>"ha intervallo temporale"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasTimeInterval">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasTimeInterval</seealso>
    let hasTimeInterval = Prefixed_Name(dul, "hasTimeInterval") |> PrefixedName
    /// <summary>
    ///   <para>dul:includesAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between situations and actions, e.g. 'this morning I've prepared my coffee and had my fingers burnt' (i.e.: the preparation of my coffee this morning included a burning of my fingers)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"includes action"</para><para>"include azione"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#includesAction">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#includesAction</seealso>
    let includesAction = Prefixed_Name(dul, "includesAction") |> PrefixedName
    /// <summary>
    ///   <para>dul:includesAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between situations and persons, e.g. 'this morning I've prepared my coffee and had my fingers burnt' (i.e.: the preparation of my coffee this morning included me)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"includes agent"</para><para>"include l'agente"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#includesAgent">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#includesAgent</seealso>
    let includesAgent = Prefixed_Name(dul, "includesAgent") |> PrefixedName
    /// <summary>
    ///   <para>dul:includesEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between situations and events, e.g. 'this morning I've prepared my coffee and had my fingers burnt' (i.e.: the preparation of my coffee this morning included a burning of my fingers)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"includes event"</para><para>"include l'evento"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#includesEvent">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#includesEvent</seealso>
    let includesEvent = Prefixed_Name(dul, "includesEvent") |> PrefixedName
    /// <summary>
    ///   <para>dul:includesObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between situations and objects, e.g. 'this morning I've prepared my coffee and had my fingers burnt' (i.e.: the preparation of my coffee this morning included me)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"includes object"</para><para>"include l'oggetto"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#includesObject">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#includesObject</seealso>
    let includesObject = Prefixed_Name(dul, "includesObject") |> PrefixedName
    /// <summary>
    ///   <para>dul:includesTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between situations and time intervals, e.g. 'this morning I've prepared my coffee and had my fingers burnt' (i.e.: preparing my coffee was held this morning). A data value attached to the time interval typically complements this modelling pattern."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"includes time"</para><para>"include tempo"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#includesTime">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#includesTime</seealso>
    let includesTime = Prefixed_Name(dul, "includesTime") |> PrefixedName
    /// <summary>
    ///   <para>dul:introduces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between a Description and a SocialAgent, e.g. a Constitutional Charter introduces the SocialAgent 'PresidentOfRepublic'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"introduces"</para><para>"introduce"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#introduces">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#introduces</seealso>
    let introduces = Prefixed_Name(dul, "introduces") |> PrefixedName
    /// <summary>
    ///   <para>dul:involvesAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Agent participation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"involves agent"</para><para>"coinvolge agente"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#involvesAgent">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#involvesAgent</seealso>
    let involvesAgent = Prefixed_Name(dul, "involvesAgent") |> PrefixedName
    /// <summary>
    ///   <para>dul:isAbout</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between information objects and any Entity (including information objects). It can be used to talk about e.g. entities are references of proper nouns: the proper noun 'Leonardo da Vinci' isAbout the Person Leonardo da Vinci; as well as to talk about sets of entities that can be described by a common noun: the common noun 'person' isAbout the set of all persons in a domain of discourse, which can be represented in DOLCE-Ultralite as an individual of the class: Collection .
    /// The isAbout relation is reflexive (not expressible in OWL1.0), because information objects are also about themselves."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"si riferisce a"</para><para>"is about"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isAbout">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isAbout</seealso>
    let isAbout = Prefixed_Name(dul, "isAbout") |> PrefixedName
    /// <summary>
    ///   <para>dul:isActionIncludedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"è un'azione nel contesto di"</para><para>"is action included in"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isActionIncludedIn">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isActionIncludedIn</seealso>
    let isActionIncludedIn = Prefixed_Name(dul, "isActionIncludedIn") |> PrefixedName
    /// <summary>
    ///   <para>dul:isAgentIncludedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is agent included in"</para><para>"è un agente nel contesto di"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isAgentIncludedIn">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isAgentIncludedIn</seealso>
    let isAgentIncludedIn = Prefixed_Name(dul, "isAgentIncludedIn") |> PrefixedName
    /// <summary>
    ///   <para>dul:isAgentInvolvedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Agent participation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"è un agente coinvolto in"</para><para>"is agent involved in"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isAgentInvolvedIn">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isAgentInvolvedIn</seealso>
    let isAgentInvolvedIn = Prefixed_Name(dul, "isAgentInvolvedIn") |> PrefixedName
    /// <summary>
    ///   <para>dul:isCharacterizedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is characterized by"</para><para>"is characterized by {@en-us}"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"è caratterizzato da"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isCharacterizedBy">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isCharacterizedBy</seealso>
    let isCharacterizedBy = Prefixed_Name(dul, "isCharacterizedBy") |> PrefixedName
    /// <summary>
    ///   <para>dul:isClassifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between a Concept and an Entity, e.g. 'John is considered a typical rude man'; your last concert constitutes the achievement of a lifetime; '20-year-old means she's mature enough'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"è classificato da"</para><para>"is classified by"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isClassifiedBy">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isClassifiedBy</seealso>
    let isClassifiedBy = Prefixed_Name(dul, "isClassifiedBy") |> PrefixedName
    /// <summary>
    ///   <para>dul:isComponentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The hasPart relation without transitivity, holding between an Object (the system) and another (the component), and assuming a Design that structures the Object."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"è componente di"</para><para>"is component of"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isComponentOf">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isComponentOf</seealso>
    let isComponentOf = Prefixed_Name(dul, "isComponentOf") |> PrefixedName

    /// <summary>
    ///   <para>dul:isConceptExpressedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between an InformationObject and a Concept , e.g. the term "dog" expresses the Concept "dog". For expressing a relational meaning, see the more general object property: expresses"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is concept expressed by"</para><para>"è un concetto espresso da"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isConceptExpressedBy">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isConceptExpressedBy</seealso>
    let isConceptExpressedBy =
        Prefixed_Name(dul, "isConceptExpressedBy") |> PrefixedName

    /// <summary>
    ///   <para>dul:isConceptUsedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A more generic relation holding between a Description and a Concept. In order to be used, a Concept must be previously definedIn another Description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"è un concetto usato in"</para><para>"is concept used in"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isConceptUsedIn">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isConceptUsedIn</seealso>
    let isConceptUsedIn = Prefixed_Name(dul, "isConceptUsedIn") |> PrefixedName
    /// <summary>
    ///   <para>dul:isConceptualizedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation stating that an Agent is internally representing a Description . E.g., 'John believes in the conspiracy theory'; 'Niels Bohr created a solar-system metaphor for his atomic theory'; 'Jacques assumes all swans are white'; 'the task force shares the attack plan'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"è concettualizzato da"</para><para>"is conceptualized by"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isConceptualizedBy">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isConceptualizedBy</seealso>
    let isConceptualizedBy = Prefixed_Name(dul, "isConceptualizedBy") |> PrefixedName

    /// <summary>
    ///   <para>dul:isConcretelyExpressedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between an InformationRealization and a Description, e.g. 'the printout of the Italian Constitution concretelyExpresses the Italian Constitution'. It should be supplied also with a rule stating that the InformationRealization realizes an InformationObject that expresses the Description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"è espresso concretamente da"</para><para>"is concretely expressed by"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isConcretelyExpressedBy">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isConcretelyExpressedBy</seealso>
    let isConcretelyExpressedBy =
        Prefixed_Name(dul, "isConcretelyExpressedBy") |> PrefixedName

    /// <summary>
    ///   <para>dul:isConstituentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"'Constituency' depends on some layering of  the world described by the ontology. For example, scientific granularities (e.g. body-organ-tissue-cell) or ontological 'strata' (e.g. social-mental-biological-physical) are  typical layerings.
    /// Intuitively, a constituent is a part belonging to a lower layer. Since layering is actually a partition of the world described by the ontology, constituents are not properly classified as parts, although this kinship can be intuitive for common sense.
    /// A desirable advantage of this distinction is that we are able to talk e.g. of physical constituents of non-physical objects (e.g. systems), while this is not possible in terms of parts.
    /// Example of are the persons constituting a social system, the molecules constituting a person, the atoms constituting a river, etc.
    /// In all these examples, we notice a typical discontinuity between the constituted and the constituent object: e.g. a social system is conceptualized at a different layer from the persons that constitute it, a person is conceptualized at a different layer from the molecules that constitute them, and a river is conceptualized at a different layer from the atoms that constitute it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"è costituente di"</para><para>"is constituent of"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isConstituentOf">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isConstituentOf</seealso>
    let isConstituentOf = Prefixed_Name(dul, "isConstituentOf") |> PrefixedName
    /// <summary>
    ///   <para>dul:isConstraintFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between parameters and entities. It allows to assert generic constraints (encoded as parameters), e.g. MinimumAgeForDriving isConstraintFor John (where John is a legal subject under the TrafficLaw).
    /// The intended semantics (not expressible in OWL) is that a Parameter isConstraintFor and Entity if the Parameter isParameterFor a Concept that classifies that Entity; moreover, it entails that a Parameter parametrizes a Region that isRegionFor that Entity. The use in OWL is therefore a shortcut to annotate what Parameter constrains what Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"è un vincolo per"</para><para>"is constraint for"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isConstraintFor">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isConstraintFor</seealso>
    let isConstraintFor = Prefixed_Name(dul, "isConstraintFor") |> PrefixedName
    /// <summary>
    ///   <para>dul:isCoveredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between concepts and collections, where a Concept is said to cover a Collection; it corresponds to a link between the (reified) intensional and extensional interpretations of a (reified) class.
    /// E.g. the collection of vintage saxophones is covered by the Concept 'Saxophone' with the Parameter 'Vintage'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is covered by"</para><para>"è ricoperto da"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isCoveredBy">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isCoveredBy</seealso>
    let isCoveredBy = Prefixed_Name(dul, "isCoveredBy") |> PrefixedName
    /// <summary>
    ///   <para>dul:isDefinedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between a Description and a Concept, e.g. a Workflow for a governmental Organization defines the Role 'officer', or 'the Italian Traffic Law defines the role Vehicle'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is defined in"</para><para>"è definito in"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isDefinedIn">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isDefinedIn</seealso>
    let isDefinedIn = Prefixed_Name(dul, "isDefinedIn") |> PrefixedName
    /// <summary>
    ///   <para>dul:isDescribedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between an Entity and a Description: a Description gives a unity to a Collection of parts (the components), or constituents, by assigning a Role to each of them in the context of a whole Object (the system).
    /// A same Entity can be given different descriptions, for example, an old cradle can be given a unifying Description based on the original aesthetic design, the functionality it was built for, or a new aesthetic functionality in which it can be used as a flower pot."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"è descritto da"</para><para>"is described by"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isDescribedBy">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isDescribedBy</seealso>
    let isDescribedBy = Prefixed_Name(dul, "isDescribedBy") |> PrefixedName
    /// <summary>
    ///   <para>dul:isEventIncludedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"è un evento nel contesto di"</para><para>"is event included in"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isEventIncludedIn">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isEventIncludedIn</seealso>
    let isEventIncludedIn = Prefixed_Name(dul, "isEventIncludedIn") |> PrefixedName
    /// <summary>
    ///   <para>dul:isExecutedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between an action and a task, e.g. 'putting some water in a pot and putting the pot on a fire until the water starts bubbling' executes the task 'boiling'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"è eseguito mediante"</para><para>"is executed in"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isExecutedIn">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isExecutedIn</seealso>
    let isExecutedIn = Prefixed_Name(dul, "isExecutedIn") |> PrefixedName
    /// <summary>
    ///   <para>dul:isExpandedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A partial order relation that holds between descriptions. It represents the proper part relation between a description and another description featuring the same properties as the former, with at least one additional one.
    /// Descriptions can be expanded either by adding other descriptions as parts, or by refining concepts that are used by them.
    /// An 'intention' to expand must be present (unless purely formal theories are considered, but even in this case a criterion of relevance is usually active)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is expanded in"</para><para>"è espansa in"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isExpandedIn">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isExpandedIn</seealso>
    let isExpandedIn = Prefixed_Name(dul, "isExpandedIn") |> PrefixedName
    /// <summary>
    ///   <para>dul:isExpressedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between a dul:SocialObject (the 'meaning') and a dul:InformationObject (the 'expression').
    /// For example: 'A Beehive is a structure in which bees are kept, typically in the form of a dome or box.' (Oxford dictionary)'; 'the term Beehive expresses the concept Beehive in my apiculture ontology'.
    /// The intuition for 'meaning' is intended to be very broad. A separate, large comment is included in the encoding of 'expresses', for those who want to investigate more on what kind of meaning can be represented in what form."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"è espresso da"</para><para>"is expressed by"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isExpressedBy">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isExpressedBy</seealso>
    let isExpressedBy = Prefixed_Name(dul, "isExpressedBy") |> PrefixedName
    /// <summary>
    ///   <para>dul:isIntroducedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between a Description and a SocialAgent, e.g. a Constitutional Charter introduces the SocialAgent 'PresidentOfRepublic'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"è introdotto da"</para><para>"is introduced by"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isIntroducedBy">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isIntroducedBy</seealso>
    let isIntroducedBy = Prefixed_Name(dul, "isIntroducedBy") |> PrefixedName
    /// <summary>
    ///   <para>dul:isLocationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A generic, relative localization, holding between any entities. E.g. 'Rome is the seat of the Pope', 'the liver is the location of the tumor'.
    /// For 'absolute' locations, see SpaceRegion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"è una localizzazione di"</para><para>"is location of"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isLocationOf">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isLocationOf</seealso>
    let isLocationOf = Prefixed_Name(dul, "isLocationOf") |> PrefixedName
    /// <summary>
    ///   <para>dul:isMemberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between collections and entities, e.g. 'the Night Watch by Rembrandt is in the Rijksmuseum collection'; 'Davide is member of the Pen Club', 'Igor is one the subjects chosen for the experiment'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is member of"</para><para>"è membro di"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isMemberOf">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isMemberOf</seealso>
    let isMemberOf = Prefixed_Name(dul, "isMemberOf") |> PrefixedName
    /// <summary>
    ///   <para>dul:isObjectIncludedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is object included in"</para><para>"è un oggetto nel contesto di"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isObjectIncludedIn">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isObjectIncludedIn</seealso>
    let isObjectIncludedIn = Prefixed_Name(dul, "isObjectIncludedIn") |> PrefixedName
    /// <summary>
    ///   <para>dul:isObservableAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation to represent a (past, present or future) TimeInterval at which an Entity is observable.
    /// In order to encode a specific time, a data value should be related to the TimeInterval.
    /// An alternative way of representing time is the datatype property: hasIntervalDate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"è osservabile a"</para><para>"is observable at"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isObservableAt">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isObservableAt</seealso>
    let isObservableAt = Prefixed_Name(dul, "isObservableAt") |> PrefixedName
    /// <summary>
    ///   <para>dul:isParameterFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Concept can have a Parameter that constrains the attributes that a classified Entity can have in a certain Situation, e.g. a 4WheelDriver Role definedIn the ItalianTrafficLaw has a MinimumAge parameter on the Amount 16."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is parameter for"</para><para>"è un parametro per"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isParameterFor">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isParameterFor</seealso>
    let isParameterFor = Prefixed_Name(dul, "isParameterFor") |> PrefixedName
    /// <summary>
    ///   <para>dul:isParametrizedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a Parameter, e.g. 'MajorAge', and a Region, e.g. '&gt;17 year'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"è parametrizzato da"</para><para>"is parametrized by"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isParametrizedBy">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isParametrizedBy</seealso>
    let isParametrizedBy = Prefixed_Name(dul, "isParametrizedBy") |> PrefixedName
    /// <summary>
    ///   <para>dul:isPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"A relation between any entities, e.g.'brain is a part of the human body'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"è parte di"</para><para>"is part of"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isPartOf">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isPartOf</seealso>
    let isPartOf = Prefixed_Name(dul, "isPartOf") |> PrefixedName
    /// <summary>
    ///   <para>dul:isParticipantIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between an object and a process, e.g. 'John took part in the discussion', 'a large mass of snow fell during the avalanche', or 'a cook, some sugar, flour, etc. are all present in the cooking of a cake'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is participant in"</para><para>"è un partecipante a"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isParticipantIn">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isParticipantIn</seealso>
    let isParticipantIn = Prefixed_Name(dul, "isParticipantIn") |> PrefixedName
    /// <summary>
    ///   <para>dul:isPostconditionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Direct succession applied to situations.
    /// E.g., 'Taking some rest is a postcondition of my search for a hotel'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"è postcondizione di"</para><para>"is postcondition of"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isPostconditionOf">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isPostconditionOf</seealso>
    let isPostconditionOf = Prefixed_Name(dul, "isPostconditionOf") |> PrefixedName
    /// <summary>
    ///   <para>dul:isPreconditionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Direct precedence applied to situations.
    /// E.g., 'claiming to find nuclear weapons in a foreign country is a precondition to declare war against it'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is precondition of"</para><para>"è precondizione di"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isPreconditionOf">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isPreconditionOf</seealso>
    let isPreconditionOf = Prefixed_Name(dul, "isPreconditionOf") |> PrefixedName
    /// <summary>
    ///   <para>dul:isQualityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between entities and qualities, e.g. 'Dmitri's skin is yellowish'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is quality of"</para><para>"è una qualità di"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isQualityOf">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isQualityOf</seealso>
    let isQualityOf = Prefixed_Name(dul, "isQualityOf") |> PrefixedName
    /// <summary>
    ///   <para>dul:isRealizedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between an information realization and an information object, e.g. the paper copy of the Italian Constitution realizes the text of the Constitution."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is realized by"</para><para>"è realizzato da"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isRealizedBy">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isRealizedBy</seealso>
    let isRealizedBy = Prefixed_Name(dul, "isRealizedBy") |> PrefixedName
    /// <summary>
    ///   <para>dul:isReferenceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between information objects and any Entity (including information objects). It can be used to talk about e.g. entities are references of proper nouns: the proper noun 'Leonardo da Vinci' isAbout the Person Leonardo da Vinci; as well as to talk about sets of entities that can be described by a common noun: the common noun 'person' isAbout the set of all persons in a domain of discourse, which can be represented in DOLCE-Ultralite as an individual of the class: Collection .
    /// The isReferenceOf relation is irreflexive, differently from its inverse isAbout."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"è il riferimento di"</para><para>"is reference of"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isReferenceOf">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isReferenceOf</seealso>
    let isReferenceOf = Prefixed_Name(dul, "isReferenceOf") |> PrefixedName

    /// <summary>
    ///   <para>dul:isReferenceOfInformationRealizedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between entities and information realizations, e.g. between Italy and a paper copy of the text of the Italian Constitution."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"è riferimento dell'informazione realizzata da"</para><para>"is reference of information realized by"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isReferenceOfInformationRealizedBy">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isReferenceOfInformationRealizedBy</seealso>
    let isReferenceOfInformationRealizedBy =
        Prefixed_Name(dul, "isReferenceOfInformationRealizedBy") |> PrefixedName

    /// <summary>
    ///   <para>dul:isRegionFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between entities and regions, e.g. 'the color of my car is red'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is region for"</para><para>"è una regione di"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isRegionFor">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isRegionFor</seealso>
    let isRegionFor = Prefixed_Name(dul, "isRegionFor") |> PrefixedName
    /// <summary>
    ///   <para>dul:isRelatedToConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Any relation between concepts, e.g. superordinated, conceptual parthood, having a parameter, having a task, superordination, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"è associato al concetto"</para><para>"is related to concept"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isRelatedToConcept">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isRelatedToConcept</seealso>
    let isRelatedToConcept = Prefixed_Name(dul, "isRelatedToConcept") |> PrefixedName

    /// <summary>
    ///   <para>dul:isRelatedToDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Any relation between descriptions."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"è associata alla descrizione"</para><para>"is related to description"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isRelatedToDescription">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isRelatedToDescription</seealso>
    let isRelatedToDescription =
        Prefixed_Name(dul, "isRelatedToDescription") |> PrefixedName

    /// <summary>
    ///   <para>dul:isRoleDefinedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between a description and a role, e.g. the role 'Ingredient' is defined in the recipe for a cake."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is role defined in"</para><para>"è un ruolo definito in"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isRoleDefinedIn">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isRoleDefinedIn</seealso>
    let isRoleDefinedIn = Prefixed_Name(dul, "isRoleDefinedIn") |> PrefixedName
    /// <summary>
    ///   <para>dul:isRoleOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between an object and a role, e.g. 'student' is the role of 'John'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"è un ruolo di"</para><para>"is role of"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isRoleOf">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isRoleOf</seealso>
    let isRoleOf = Prefixed_Name(dul, "isRoleOf") |> PrefixedName
    /// <summary>
    ///   <para>dul:isSatisfiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between a Situation and a Description, e.g. the execution of a Plan satisfies that plan."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"è soddisfatta da"</para><para>"is satisfied by"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isSatisfiedBy">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isSatisfiedBy</seealso>
    let isSatisfiedBy = Prefixed_Name(dul, "isSatisfiedBy") |> PrefixedName
    /// <summary>
    ///   <para>dul:isSettingFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between situations and entities, e.g. 'this morning I've prepared my coffee with a new fantastic Arabica', i.e.: the preparation of my coffee this morning is the setting for (an amount of) a new fantastic Arabica."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is setting for"</para><para>"include"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isSettingFor">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isSettingFor</seealso>
    let isSettingFor = Prefixed_Name(dul, "isSettingFor") |> PrefixedName
    /// <summary>
    ///   <para>dul:isSpecializedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"A partial order relation that holds between social objects. It represents the subsumption relation between e.g. a Concept and another Concept that is broader in extensional interpretation, but narrowe in intensional interpretation.
    /// E.g. PhDStudent Role specializes Student Role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is specialized by"</para><para>"è specializzato da"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isSpecializedBy">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isSpecializedBy</seealso>
    let isSpecializedBy = Prefixed_Name(dul, "isSpecializedBy") |> PrefixedName
    /// <summary>
    ///   <para>dul:isSubordinatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Direct succession applied to concepts. E.g. the role 'Officer' is subordinated to 'Director'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is subordinated to"</para><para>"è subordinato a"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isSubordinatedTo">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isSubordinatedTo</seealso>
    let isSubordinatedTo = Prefixed_Name(dul, "isSubordinatedTo") |> PrefixedName
    /// <summary>
    ///   <para>dul:isSuperordinatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Direct precedence applied to concepts. E.g. the role 'Executive' is superordinated to 'DepartmentManager'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"è superordinato a"</para><para>"is superordinated to"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isSuperordinatedTo">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isSuperordinatedTo</seealso>
    let isSuperordinatedTo = Prefixed_Name(dul, "isSuperordinatedTo") |> PrefixedName
    /// <summary>
    ///   <para>dul:isTaskDefinedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between a description and a task, e.g. the task 'boil' is defined in a recipe for a cake."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"è un task definito in"</para><para>"is task defined in"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isTaskDefinedIn">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isTaskDefinedIn</seealso>
    let isTaskDefinedIn = Prefixed_Name(dul, "isTaskDefinedIn") |> PrefixedName
    /// <summary>
    ///   <para>dul:isTaskOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between roles and tasks, e.g. 'students have the duty of giving exams' (i.e. the Role 'student' hasTask the Task 'giving exams')."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is task of"</para><para>"è un obiettivo per"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isTaskOf">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isTaskOf</seealso>
    let isTaskOf = Prefixed_Name(dul, "isTaskOf") |> PrefixedName
    /// <summary>
    ///   <para>dul:isTimeIncludedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is time included in"</para><para>"è un tempo nel contesto di"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isTimeIncludedIn">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isTimeIncludedIn</seealso>
    let isTimeIncludedIn = Prefixed_Name(dul, "isTimeIncludedIn") |> PrefixedName
    /// <summary>
    ///   <para>dul:isTimeIntervalOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The generic relation between time intervals and events."</para>
    /// labels<para>"is time interval of"</para><para>"intervallo temporale di"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isTimeIntervalOf">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isTimeIntervalOf</seealso>
    let isTimeIntervalOf = Prefixed_Name(dul, "isTimeIntervalOf") |> PrefixedName

    /// <summary>
    ///   <para>dul:isTimeOfObservationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation to represent a (past, present or future) TimeInterval at which an Entity is observable.
    /// In order to encode a specific time, a data value should be related to the TimeInterval.
    /// An alternative way of representing time is the datatype property: hasIntervalDate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is time of observation of"</para><para>"è il tempo di osservazione di"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isTimeOfObservationOf">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isTimeOfObservationOf</seealso>
    let isTimeOfObservationOf =
        Prefixed_Name(dul, "isTimeOfObservationOf") |> PrefixedName

    /// <summary>
    ///   <para>dul:isUnifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Collection has a unification criterion, provided by a Description; for example, a community of practice can be unified by a shared theory or interest, e.g. the community that makes research on mirror neurons shares some core knowledge about mirror neurons, which can be represented as a Description MirrorNeuronTheory that unifies the community. There can be several unifying descriptions."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is unified by"</para><para>"è unificato da"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isUnifiedBy">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isUnifiedBy</seealso>
    let isUnifiedBy = Prefixed_Name(dul, "isUnifiedBy") |> PrefixedName
    /// <summary>
    ///   <para>dul:nearTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Generic distance relation between any Entity(s). E.g. Rome is near to Florence, astronomy is near to physics."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"near to"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#nearTo">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#nearTo</seealso>
    let nearTo = Prefixed_Name(dul, "nearTo") |> PrefixedName
    /// <summary>
    ///   <para>dul:overlaps</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>"A schematic relation between any entities, e.g. 'the chest region overlaps with the abdomen region', 'my spoken words overlap with hers', 'the time of my leave overlaps with the time of your arrival', 'fibromyalgia overlaps with other conditions'.
    /// Subproperties and restrictions can be used to specialize overlaps for objects, events, time intervals, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"sovrapposto a"</para><para>"overlaps"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#overlaps">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#overlaps</seealso>
    let overlaps = Prefixed_Name(dul, "overlaps") |> PrefixedName
    /// <summary>
    ///   <para>dul:parametrizes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a Parameter, e.g. 'MajorAgeLimit', and a Region, e.g. '18_year'.
    /// For a more data-oriented relation, see hasDataValue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"parametrizza"</para><para>"parametrizes"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#parametrizes">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#parametrizes</seealso>
    let parametrizes = Prefixed_Name(dul, "parametrizes") |> PrefixedName
    /// <summary>
    ///   <para>dul:precedes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between entities, expressing a 'sequence' schema.
    /// E.g. 'year 1999 precedes 2000', 'deciding what coffee to use' precedes 'preparing coffee', 'World War II follows World War I', 'in the Milan to Rome autoroute, Bologna precedes Florence', etc.
    /// It can then be used between tasks, processes, time intervals, spatially locate objects, situations, etc.
    /// Subproperties can be defined in order to distinguish the different uses."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"precede"</para><para>"precedes"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#precedes">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#precedes</seealso>
    let precedes = Prefixed_Name(dul, "precedes") |> PrefixedName
    /// <summary>
    ///   <para>dul:realizes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between an information realization and an information object, e.g. the paper copy of the Italian Constitution realizes the text of the Constitution."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"realizes"</para><para>"realizza"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#realizes">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#realizes</seealso>
    let realizes = Prefixed_Name(dul, "realizes") |> PrefixedName

    /// <summary>
    ///   <para>dul:realizesInformationAbout</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between entities and information realizations, e.g. between Italy and a paper copy of the text of the Italian Constitution."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"realizza informazione che si riferisce a a"</para><para>"realizes information about"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#realizesInformationAbout">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#realizesInformationAbout</seealso>
    let realizesInformationAbout =
        Prefixed_Name(dul, "realizesInformationAbout") |> PrefixedName

    /// <summary>
    ///   <para>dul:sameSettingAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between two entities participating in a same Situation; e.g., 'Our company provides an antivenom service' (the situation is the service, the two entities are the company and the antivenom)."</para>
    /// labels<para>"è nella stessa situazione di"</para><para>"is in the same setting as"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#sameSettingAs">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#sameSettingAs</seealso>
    let sameSettingAs = Prefixed_Name(dul, "sameSettingAs") |> PrefixedName
    /// <summary>
    ///   <para>dul:satisfies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between a Situation and a Description, e.g. the execution of a Plan satisfies that plan."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"satisfies"</para><para>"soddisfa"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#satisfies">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#satisfies</seealso>
    let satisfies = Prefixed_Name(dul, "satisfies") |> PrefixedName
    /// <summary>
    ///   <para>dul:specializes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A partial order relation that holds between social objects.
    /// It mainly represents the subsumption relation between e.g. a Concept or Description and another Concept (resp. Description) that is broader in extensional interpretation, but narrower in intensional interpretation. For example, the role PhDStudent specializes the role Student.
    /// Another possible use is between a Collection that isCoveredBy a Concept A, and another Collection that isCoveredBy a Concept B that on its turm specializes A. For example, the 70,000 series Selmer Mark VI saxophone Collection specializes the Selmer Mark VI saxophone Collection."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"specializes"</para><para>"specializza"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#specializes">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#specializes</seealso>
    let specializes = Prefixed_Name(dul, "specializes") |> PrefixedName
    /// <summary>
    ///   <para>dul:unifies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Collection has a unification criterion, provided by a Description; for example, a community of practice can be unified by a shared theory or interest, e.g. the community that makes research on mirror neurons shares some core knowledge about mirror neurons, which can be represented as a Description MirrorNeuronTheory that unifies the community. There can be several unifying descriptions."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"unifies"</para><para>"unifica"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#unifies">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#unifies</seealso>
    let unifies = Prefixed_Name(dul, "unifies") |> PrefixedName
    /// <summary>
    ///   <para>dul:usesConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A generic relation holding between a Description and a Concept. In order to be used, a Concept must be previously definedIn another Description. This last condition cannot be encoded for object properties in OWL."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"uses concept"</para><para>"usa il concetto"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#usesConcept">http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#usesConcept</seealso>
    let usesConcept = Prefixed_Name(dul, "usesConcept") |> PrefixedName
