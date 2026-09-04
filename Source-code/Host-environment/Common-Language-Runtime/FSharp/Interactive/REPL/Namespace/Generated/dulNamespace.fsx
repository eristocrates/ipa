#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dul =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#" "dul"

    /// <summary>
    ///   <para>rdfs:comment : Any Entity that cannot be located in space-time. E.g. mathematical entities: formal semantics elements, regions within dimensional spaces, etc.^^xsd:string</para>
    ///   <para>rdfs:label : Astrattordfs:label : Abstract</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Abstract">dul:Abstract</a>
    /// </summary>
    let Abstract = _prefixId.prefix "Abstract"
    /// <summary>
    ///   <para>rdfs:comment : An Event with at least one Agent that isParticipantIn it, and that executes a Task that typically isDefinedIn a Plan, Workflow, Project, etc.^^xsd:string</para>
    ///   <para>rdfs:label : Azionerdfs:label : Action</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Action">dul:Action</a>
    /// </summary>
    let Action = _prefixId.prefix "Action"
    /// <summary>
    ///   <para>rdfs:comment : Any agentive Object , either physical (e.g. a whale, a robot, an oak), or social (e.g. a corporation, an institution, a community).^^xsd:stringrdfs:comment : Additional comment: a computational agent can be considered as a PhysicalAgent that realizes a certain class of algorithms (that can be considered as instances of InformationObject) that allow to obtain some behaviors that are considered typical of agents in general. For an ontology of computational objects based on DOLCE see e.g. http://www.loa-cnr.it/COS/COS.owl, and http://www.loa-cnr.it/KCO/KCO.owl.^^xsd:string</para>
    ///   <para>rdfs:label : Agenterdfs:label : Agent</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Agent">dul:Agent</a>
    /// </summary>
    let Agent = _prefixId.prefix "Agent"
    /// <summary>
    ///   <para>rdfs:comment : A quantity, independently from how it is measured, computed, etc.^^xsd:string</para>
    ///   <para>rdfs:label : Quantitàrdfs:label : Amount</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Amount">dul:Amount</a>
    /// </summary>
    let Amount = _prefixId.prefix "Amount"
    /// <summary>
    ///   <para>rdfs:label : Biological object</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#BiologicalObject">dul:BiologicalObject</a>
    /// </summary>
    let BiologicalObject = _prefixId.prefix "BiologicalObject"
    /// <summary>
    ///   <para>rdfs:label : Chemical object</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#ChemicalObject">dul:ChemicalObject</a>
    /// </summary>
    let ChemicalObject = _prefixId.prefix "ChemicalObject"
    /// <summary>
    ///   <para>rdfs:comment : A special kind of Situation that allows to include time indexing for the classifies relation in situations. For example, if a Situation s 'my old cradle is used in these days as a flower pot' isSettingFor the entity 'my old cradle' and the TimeIntervals '8June2007' and '10June2007', and we know that s satisfies a functional Description for aesthetic objects, which defines the Concepts 'flower pot' and 'flower', then we also need to know what concept classifies 'my old cradle' at what time.
    /// In order to solve this issue, we need to create a sub-situation s' for the classification time: 'my old cradle is a flower pot in 8June2007'. Such sub-situation s' isPartOf s.^^xsd:string</para>
    ///   <para>rdfs:label : Classificazionerdfs:label : Classification</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Classification">dul:Classification</a>
    /// </summary>
    let Classification = _prefixId.prefix "Classification"
    /// <summary>
    ///   <para>rdfs:comment : Any container for entities that share one or more common properties. E.g. "stone objects", "the nurses", "the Louvre Aegyptian collection", all the elections for the Italian President of the Republic.
    /// A collection is not a logical class: a collection is a first-order entity, while a class is second-order.^^xsd:string</para>
    ///   <para>rdfs:label : Collezionerdfs:label : Collection</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Collection">dul:Collection</a>
    /// </summary>
    let Collection = _prefixId.prefix "Collection"
    /// <summary>
    ///   <para>rdfs:comment : A Collection whose members are agents, e.g. "the nurses", "the Italian rockabilly fans".
    /// Collectives, facon de parler, can act as agents, although they are not assumed here to be agents (they are even disjoint from the class SocialAgent). This is represented by admitting collectives in the range of the relations having Agent in their domain or range.^^xsd:string</para>
    ///   <para>rdfs:label : Collettivordfs:label : Collective</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Collective">dul:Collective</a>
    /// </summary>
    let Collective = _prefixId.prefix "Collective"
    /// <summary>
    ///   <para>rdfs:comment : A SocialAgent that is actedBy agents that are (and act as) members of a Collective. A collective agent can have roles that are also roles of those agents.
    /// For example, in sociology, a 'group action' is the situation in which a number of people (that result to be members of a collective) in a given area behave in a coordinated way in order to achieve a (often common) goal. The Agent in such a Situation is not single, but a CollectiveAgent (a Group). This can be generalized to the notion of social movement, which assumes a large Community or even the entire Society as agents.
    /// The difference between a CollectiveAgent and an Organization is that a Description that introduces a CollectiveAgent is also one that unifies the corresponding Collective. In practice, this difference makes collective agents 'less stable' than organizations, because they have a dedicated, publicly recognizable Description that is conceived to introduce them.^^xsd:string</para>
    ///   <para>rdfs:label : Agente collettivordfs:label : Collective agent</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#CollectiveAgent">dul:CollectiveAgent</a>
    /// </summary>
    let CollectiveAgent = _prefixId.prefix "CollectiveAgent"
    /// <summary>
    ///   <para>rdfs:label : Comunitàrdfs:label : Community</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Community">dul:Community</a>
    /// </summary>
    let Community = _prefixId.prefix "Community"
    /// <summary>
    ///   <para>rdfs:comment : A Concept is a SocialObject, and isDefinedIn some Description; once defined, a Concept can be used in other Description(s). If a Concept isDefinedIn exactly one Description, see the LocalConcept class.
    /// The classifies relation relates Concept(s) to Entity(s) at some TimeInterval^^xsd:string</para>
    ///   <para>rdfs:label : Conceptrdfs:label : Concetto</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Concept">dul:Concept</a>
    /// </summary>
    let Concept = _prefixId.prefix "Concept"
    /// <summary>
    ///   <para>rdfs:comment : A collection whose members are 'unified', i.e. organized according to a certain schema that can be represented by a Description.
    /// Typically, a configuration is the collection that emerges out of a composed entity: an industrial artifact, a plan, a discourse, etc.
    /// E.g. a physical book has a configuration provided by the part-whole schema that holds together its cover, pages, ink. That schema, based on the individual relations between the book and its parts, can be represented in a reified way by means of a (structural) description, which is said to 'unify' the book configuration.^^xsd:string</para>
    ///   <para>rdfs:label : Configurazionerdfs:label : Configuration</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Configuration">dul:Configuration</a>
    /// </summary>
    let Configuration = _prefixId.prefix "Configuration"
    /// <summary>
    ///   <para>rdfs:comment : (The content of) an agreement between at least two agents that play a Party Role, about some contract object (a Task to be executed).^^xsd:string</para>
    ///   <para>rdfs:label : Contrattordfs:label : Contract</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Contract">dul:Contract</a>
    /// </summary>
    let Contract = _prefixId.prefix "Contract"
    /// <summary>
    ///   <para>rdfs:comment : A Description is a SocialObject that represents a conceptualization.
    /// It can be thought also as a 'descriptive context' that uses or defines concepts in order to create a view on a 'relational context' (cf. Situation) out of a set of data or observations.
    /// For example, a Plan is a Description of some actions to be executed by agents in a certain way, with certain parameters; a Diagnosis is a Description that provides an interpretation for a set of observed entities, etc.^^xsd:string</para>
    ///   <para>rdfs:label : Descrizionerdfs:label : Description</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Description">dul:Description</a>
    /// </summary>
    let Description = _prefixId.prefix "Description"
    /// <summary>
    ///   <para>rdfs:comment : A Description of the Situation, in terms of structure and function, held by an Entity for some reason.
    /// A design is usually accompanied by the rationales behind the construction of the designed Entity (i.e. of the reasons why a design is claimed to be as such). For example, the actual design (a Situation) of a car or of a law is based on both the specification (a Description) of the structure, and the rationales used to construct cars or laws.
    /// While designs typically describe entities to be constructed, they can also be used to describe 'refunctionalized' entities, or to hypothesize unknown functions. For example, a cradle can be refunctionalized as a flowerpot based on a certain home design.^^xsd:string</para>
    ///   <para>rdfs:label : Designrdfs:label : Design</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Design">dul:Design</a>
    /// </summary>
    let Design = _prefixId.prefix "Design"
    /// <summary>
    ///   <para>rdfs:comment : A PhysicalArtifact that is also described by a Design. This excludes simple recycling or refunctionalization of natural objects. Most common sense 'artifacts' can be included in this class: cars, lamps, houses, chips, etc.^^xsd:string</para>
    ///   <para>rdfs:label : Artefatto progettatordfs:label : Designed artifact</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#DesignedArtifact">dul:DesignedArtifact</a>
    /// </summary>
    let DesignedArtifact = _prefixId.prefix "DesignedArtifact"
    let DesignedSubstance = _prefixId.prefix "DesignedSubstance"
    /// <summary>
    ///   <para>rdfs:comment : A Description of the Situation of a system, usually applied in order to control a normal behaviour, or to explain a notable behavior (e.g. a functional breakdown).^^xsd:string</para>
    ///   <para>rdfs:label : Diagnosirdfs:label : Diagnosis</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Diagnosis">dul:Diagnosis</a>
    /// </summary>
    let Diagnosis = _prefixId.prefix "Diagnosis"
    /// <summary>
    ///   <para>rdfs:comment : Anything: real, possible, or imaginary, which some modeller wants to talk about for some purpose.^^xsd:string</para>
    ///   <para>rdfs:label : Entitàrdfs:label : Entity</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Entity">dul:Entity</a>
    /// </summary>
    let Entity = _prefixId.prefix "Entity"
    /// <summary>
    ///   <para>rdfs:label : Eventrdfs:label : Evento</para>
    ///   <para>rdfs:comment : Any physical, social, or mental process, event, or state.
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
    /// For this reason, in this ontology both events and situations are allowed, together with descriptions, in order to encode the modelling needs, independently from the position (if any) chosen by the designer.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Event">dul:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>rdfs:comment : A Concept that classifies an Event . An event type describes how an Event should be interpreted, executed, expected, seen, etc., according to the Description that the EventType isDefinedIn (or used in)^^xsd:string</para>
    ///   <para>rdfs:label : Tipo di eventordfs:label : Event type</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#EventType">dul:EventType</a>
    /// </summary>
    let EventType = _prefixId.prefix "EventType"
    /// <summary>
    ///   <para>rdfs:comment : Entities that are formally defined and are considered independent from the social context in which they are used. They cannot be localized in space or time. Also called 'Platonic entities'.
    /// Mathematical and logical entities are included in this class: sets, categories, tuples, costants, variables, etc.
    /// Abstract formal entities are distinguished from information objects, which are supposed to be part of a social context, and are localized in space and time, therefore being (social) objects.
    /// For example, the class 'Quark' is an abstract formal entity from the purely set-theoretical perspective, but it is an InformationObject from the viewpoint of ontology design, when e.g. implemented in a logical language like OWL.
    /// Abstract formal entities are also distinguished from Concept(s), Collection(s), and Description(s), which are part of a social context, therefore being SocialObject(s) as well.
    /// For example, the class 'Quark' is an abstract FormalEntity from the purely set-theoretical perspective, but it is a Concept within history of science and cultural dynamics.
    ///
    /// These distinctions allow to represent two different notions of 'semantics': the first one is abstract and formal ('formal semantics'), and formallyInterprets symbols that are about entities whatsoever; for example, the term 'Quark' isAbout the Collection of all quarks, and that Collection isFormalGroundingFor the abstract class 'Quark' (in the extensional sense).
    /// The second notion is social, localized in space-time ('social semantics'), and can be used to interpret entities in the intensional sense. For example, the Collection of all quarks isCoveredBy the Concept 'Quark', which is also expressed by the term 'Quark'.^^xsd:string</para>
    ///   <para>rdfs:label : Entità formale astrattardfs:label : Formal entity</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#FormalEntity">dul:FormalEntity</a>
    /// </summary>
    let FormalEntity = _prefixId.prefix "FormalEntity"
    /// <summary>
    ///   <para>rdfs:label : Functional substance</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#FunctionalSubstance">dul:FunctionalSubstance</a>
    /// </summary>
    let FunctionalSubstance = _prefixId.prefix "FunctionalSubstance"
    /// <summary>
    ///   <para>rdfs:comment : The Description of a Situation that is desired by an Agent, and usually associated to a Plan that describes how to actually achieve it^^xsd:string</para>
    ///   <para>rdfs:label : Scopordfs:label : Goal</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Goal">dul:Goal</a>
    /// </summary>
    let Goal = _prefixId.prefix "Goal"
    /// <summary>
    ///   <para>rdfs:comment : A CollectiveAgent whose acting agents conceptualize a same SocialRelation .^^xsd:string</para>
    ///   <para>rdfs:label : Gruppordfs:label : Group</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Group">dul:Group</a>
    /// </summary>
    let Group = _prefixId.prefix "Group"
    /// <summary>
    ///   <para>rdfs:comment : A piece of information, be it concretely realized or not.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#InformationEntity">dul:InformationEntity</a>
    /// </summary>
    let InformationEntity = _prefixId.prefix "InformationEntity"
    /// <summary>
    ///   <para>rdfs:label : Oggetto informativordfs:label : Information object</para>
    ///   <para>rdfs:comment : A piece of information, such as a musical composition, a text, a word, a picture, independently from how it is concretely realized.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#InformationObject">dul:InformationObject</a>
    /// </summary>
    let InformationObject = _prefixId.prefix "InformationObject"
    /// <summary>
    ///   <para>rdfs:comment : A concrete realization of an InformationObject, e.g. the written document containing the text of a law.^^xsd:string</para>
    ///   <para>rdfs:label : Informazione concretardfs:label : Information realization</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#InformationRealization">dul:InformationRealization</a>
    /// </summary>
    let InformationRealization = _prefixId.prefix "InformationRealization"
    /// <summary>
    ///   <para>rdfs:comment : A Concept that isDefinedIn exactly 1 Description. For example, the Concept 'coffee' in a 'preparesCoffee' relation can be defined in that relation, and for all other Description(s) that use it, the isConceptUsedIn property should be applied. Notice therefore that not necessarily all Concept(s) isDefinedIn exactly 1 Description.^^xsd:string</para>
    ///   <para>rdfs:label : Local concept</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#LocalConcept">dul:LocalConcept</a>
    /// </summary>
    let LocalConcept = _prefixId.prefix "LocalConcept"
    /// <summary>
    ///   <para>rdfs:comment : A method is a Description that defines or uses concepts in order to guide carrying out actions aimed at a solution with respect to a problem.
    /// It is different from a Plan, because plans could be carried out in order to follow a method, but a method can be followed by executing alternative plans.^^xsd:string</para>
    ///   <para>rdfs:label : Metodordfs:label : Method</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Method">dul:Method</a>
    /// </summary>
    let Method = _prefixId.prefix "Method"
    /// <summary>
    ///   <para>rdfs:label : Narrative</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Narrative">dul:Narrative</a>
    /// </summary>
    let Narrative = _prefixId.prefix "Narrative"
    /// <summary>
    ///   <para>rdfs:comment : A person in the physical commonsense intuition: 'have you seen that person walking down the street?'^^xsd:string</para>
    ///   <para>rdfs:label : Persona fisicardfs:label : Natural person</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#NaturalPerson">dul:NaturalPerson</a>
    /// </summary>
    let NaturalPerson = _prefixId.prefix "NaturalPerson"
    /// <summary>
    ///   <para>rdfs:comment : A social norm.^^xsd:string</para>
    ///   <para>rdfs:label : Normardfs:label : Norm</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Norm">dul:Norm</a>
    /// </summary>
    let Norm = _prefixId.prefix "Norm"
    /// <summary>
    ///   <para>rdfs:label : Oggettordfs:label : Object</para>
    ///   <para>rdfs:comment : Any physical, social, or mental object, or a substance. Following DOLCE Full, objects are always participating in some event (at least their own life), and are spatially located.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Object">dul:Object</a>
    /// </summary>
    let Object = _prefixId.prefix "Object"
    /// <summary>
    ///   <para>rdfs:comment : A physical objects with biological characteristics, typically that organisms can self-reproduce.^^xsd:string</para>
    ///   <para>rdfs:label : Organismordfs:label : Organism</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Organism">dul:Organism</a>
    /// </summary>
    let Organism = _prefixId.prefix "Organism"
    /// <summary>
    ///   <para>rdfs:comment : Un agente sociale strutturato internamente e creato convenzionalmente. Per agire, ha bisogno di ruoli e agenti che li ricoprano.rdfs:comment : An internally structured, conventionally created SocialAgent, needing a specific Role and Agent that plays it, in order to act.</para>
    ///   <para>rdfs:label : Organizzazionerdfs:label : Organization</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Organization">dul:Organization</a>
    /// </summary>
    let Organization = _prefixId.prefix "Organization"
    /// <summary>
    ///   <para>rdfs:comment : A Concept that classifies a Region; the difference between a Region and a Parameter is that regions represent sets of observable values, e.g. the height  of a given building, while parameters represent constraints or selections on observable values, e.g. 'VeryHigh'. Therefore, parameters can also be used to constrain regions, e.g. VeryHigh on a subset of values of the Region Height applied to buildings, or to add an external selection criterion , such as measurement units, to regions, e.g. Meter on a subset of values from the Region Length applied to the Region Length applied to roads.^^xsd:string</para>
    ///   <para>rdfs:label : Parametrordfs:label : Parameter</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Parameter">dul:Parameter</a>
    /// </summary>
    let Parameter = _prefixId.prefix "Parameter"
    /// <summary>
    ///   <para>rdfs:comment : Any invariance detected from a dataset, or from observation; also, any invariance proposed based on top-down considerations.
    /// E.g. patterns detected and abstracted by an organism, by pattern recognition algorithms, by machine learning techniques, etc.
    /// An occurrence of a pattern is an 'observable', or detected Situation^^xsd:string</para>
    ///   <para>rdfs:label : Pattern</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Pattern">dul:Pattern</a>
    /// </summary>
    let Pattern = _prefixId.prefix "Pattern"
    /// <summary>
    ///   <para>rdfs:comment : Persons in commonsense intuition, which does not apparently distinguish between either natural or social persons.^^xsd:string</para>
    ///   <para>rdfs:label : Personrdfs:label : Persona {it}^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Person">dul:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>rdfs:comment : A social entity with agentive features, but whose status is the result of a cultural transformation from e.g. a PhysicalObject, an Event, an Abstract, another SocialObject, etc. For example: the holy grail, deus ex machina, gods, magic wands, etc.^^xsd:string</para>
    ///   <para>rdfs:label : Personification</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Personification">dul:Personification</a>
    /// </summary>
    let Personification = _prefixId.prefix "Personification"
    /// <summary>
    ///   <para>rdfs:comment : A PhysicalObject that is capable of self-representing (conceptualizing) a Description in order to plan an Action.
    /// A PhysicalAgent is a substrate for (actsFor) a Social Agent^^xsd:string</para>
    ///   <para>rdfs:label : Agente fisicordfs:label : Physical agent</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#PhysicalAgent">dul:PhysicalAgent</a>
    /// </summary>
    let PhysicalAgent = _prefixId.prefix "PhysicalAgent"
    /// <summary>
    ///   <para>rdfs:comment : Any PhysicalObject that isDescribedBy a Plan .
    /// This axiomatization is weak, but allows to talk of artifacts in a very general sense, i.e. including recycled objects, objects with an intentional functional change, natural objects that are given a certain function, even though they are not modified or structurally designed, etc. PhysicalArtifact(s) are not considered disjoint from PhysicalBody(s), in order to allow a dual classification when needed. E.g.,
    /// FunctionalSubstance(s) are included here as well.
    /// Immaterial (non-physical) artifacts (e.g. texts, ideas, cultural movements, corporations, communities, etc. can be modelled as social objects (see SocialObject), which are all 'artifactual' in the weak sense assumed here.^^xsd:string</para>
    ///   <para>rdfs:label : Artefatto fisicordfs:label : Physical artifact</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#PhysicalArtifact">dul:PhysicalArtifact</a>
    /// </summary>
    let PhysicalArtifact = _prefixId.prefix "PhysicalArtifact"
    /// <summary>
    ///   <para>rdfs:comment : Physical value of a physical object, e.g. density, color, etc.^^xsd:string</para>
    ///   <para>rdfs:label : Caratteristica fisicardfs:label : Physical attribute</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#PhysicalAttribute">dul:PhysicalAttribute</a>
    /// </summary>
    let PhysicalAttribute = _prefixId.prefix "PhysicalAttribute"
    /// <summary>
    ///   <para>rdfs:comment : Physical bodies are PhysicalObject(s), for which we tend to neutralize any possible artifactual character. They can have several granularity levels: geological, chemical, physical, biological, etc.^^xsd:string</para>
    ///   <para>rdfs:label : Physical body</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#PhysicalBody">dul:PhysicalBody</a>
    /// </summary>
    let PhysicalBody = _prefixId.prefix "PhysicalBody"
    /// <summary>
    ///   <para>rdfs:comment : Any Object that has a proper space region. The prototypical physical object has also an associated mass, but the nature of its mass can greatly vary based on the epistemological status of the object (scientifically measured, subjectively possible, imaginary).^^xsd:string</para>
    ///   <para>rdfs:label : Oggetto fisicordfs:label : Physical object</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#PhysicalObject">dul:PhysicalObject</a>
    /// </summary>
    let PhysicalObject = _prefixId.prefix "PhysicalObject"
    /// <summary>
    ///   <para>rdfs:comment : A physical object that is inherently located; for example, a water area.^^xsd:string</para>
    ///   <para>rdfs:label : Luogo fisicordfs:label : Physical place</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#PhysicalPlace">dul:PhysicalPlace</a>
    /// </summary>
    let PhysicalPlace = _prefixId.prefix "PhysicalPlace"
    /// <summary>
    ///   <para>rdfs:comment : A location, in a very generic sense: a political geographic entity (Roma, Lesotho), a non-material location determined by the presence of other entities ("the area close to Roma"), pivot events or signs ("the area where the helicopter fell"), complements of other entities ("the area under the table"), etc.
    /// In this generic sense, a Place is an "approximate" location. For an "absolute" location, see the class SpaceRegion^^xsd:string</para>
    ///   <para>rdfs:label : Luogordfs:label : Place</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Place">dul:Place</a>
    /// </summary>
    let Place = _prefixId.prefix "Place"
    /// <summary>
    ///   <para>rdfs:comment : A Description having an explicit Goal, to be achieved by executing the plan^^xsd:string</para>
    ///   <para>rdfs:label : Pianordfs:label : Plan</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Plan">dul:Plan</a>
    /// </summary>
    let Plan = _prefixId.prefix "Plan"
    /// <summary>
    ///   <para>rdfs:comment : Plan executions are situations that proactively satisfy a plan. Subplan executions are proper parts of the whole plan execution.^^xsd:string</para>
    ///   <para>rdfs:label : Esecuzione di pianordfs:label : Plan execution</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#PlanExecution">dul:PlanExecution</a>
    /// </summary>
    let PlanExecution = _prefixId.prefix "PlanExecution"
    /// <summary>
    ///   <para>rdfs:comment : This is a placeholder for events that are considered in their evolution, or anyway not strictly dependent on agents, tasks, and plans.
    /// See Event class for some thoughts on classifying events. See also 'Transition'.^^xsd:string</para>
    ///   <para>rdfs:label : Processordfs:label : Process</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Process">dul:Process</a>
    /// </summary>
    let Process = _prefixId.prefix "Process"
    /// <summary>
    ///   <para>rdfs:comment : A Plan that defines Role(s), Task(s), and a specific structure for tasks to be executed in relation to goals to be achieved, in order to achieve the main goal of the project. In other words, a project is a plan with a subgoal structure and multiple roles and tasks.^^xsd:string</para>
    ///   <para>rdfs:label : Progettordfs:label : Project</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Project">dul:Project</a>
    /// </summary>
    let Project = _prefixId.prefix "Project"
    /// <summary>
    ///   <para>rdfs:comment : Any aspect of an Entity (but not a part of it), which cannot exist without that Entity. For example, the way the surface of a specific PhysicalObject looks like, or the specific light of a place at a certain time, are examples of Quality, while the encoding of a Quality into e.g. a PhysicalAttribute should be modeled as a Region.
    /// From the design viewpoint, the Quality-Region distinction is useful only when individual aspects of an Entity are considered in a domain of discourse.
    /// For example, in an automotive context, it would be irrelevant to consider the aspects of car windows for a specific car, unless the factory wants to check a specific window against design parameters (anomaly detection).
    /// On the other hand, in an antiques context, the individual aspects for a specific piece of furniture are a major focus of attention, and may constitute the actual added value, because the design parameters for old furniture are often not fixed, and may not be viewed as 'anomalies'.^^xsd:string</para>
    ///   <para>rdfs:label : Qualitàrdfs:label : Quality</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Quality">dul:Quality</a>
    /// </summary>
    let Quality = _prefixId.prefix "Quality"
    /// <summary>
    ///   <para>rdfs:label : Regionerdfs:label : Region</para>
    ///   <para>rdfs:comment : Any region in a dimensional space (a dimensional space is a maximal Region), which can be used as a value for a quality of an Entity . For example, TimeInterval, SpaceRegion, PhysicalAttribute, Amount, SocialAttribute are all subclasses of Region.
    /// Regions are not data values in the ordinary knowledge representation sense; in order to get patterns for modelling data, see the properties: representsDataValue and hasDataValue^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Region">dul:Region</a>
    /// </summary>
    let Region = _prefixId.prefix "Region"
    /// <summary>
    ///   <para>rdfs:comment : Relations are descriptions that can be considered as the counterpart of formal relations (that are included in the FormalEntity class).
    /// For example, 'givingGrantToInstitution(x,y,z)' with three argument types: Provider(x),Grant(y),Recipient(z), can have a Relation counterpart: 'GivingGrantToInstitution', which defines three Concept instances: Provider,Grant,Recipient.
    /// Since social objects are not formal entities, Relation includes here any 'relation-like' entity in common sense, including social relations.^^xsd:string</para>
    ///   <para>rdfs:label : Relazionerdfs:label : Relation</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Relation">dul:Relation</a>
    /// </summary>
    let Relation = _prefixId.prefix "Relation"
    /// <summary>
    ///   <para>rdfs:comment : A legal position by which an Agent is entitled to obtain something from another Agent , under specified circumstances, through an enforcement explicited either in a Law, Contract , etc.^^xsd:string</para>
    ///   <para>rdfs:label : Dirittordfs:label : Right</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Right">dul:Right</a>
    /// </summary>
    let Right = _prefixId.prefix "Right"
    /// <summary>
    ///   <para>rdfs:comment : A Concept that classifies an Object^^xsd:string</para>
    ///   <para>rdfs:label : Ruolordfs:label : Role</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Role">dul:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"
    /// <summary>
    ///   <para>rdfs:label : Setrdfs:label : Insieme {it}^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Set">dul:Set</a>
    /// </summary>
    let Set = _prefixId.prefix "Set"
    /// <summary>
    ///   <para>rdfs:comment : A view, consistent with ('satisfying') a Description, on a set of entities.
    /// It can also be seen as a 'relational context' created by an observer on the basis of a 'frame' (i.e. a Description).
    /// For example, a PlanExecution is a context including some actions executed by agents according to certain parameters and expected tasks to be achieved from a Plan; a DiagnosedSituation is a context of observed entities that is interpreted on the basis of a Diagnosis, etc.
    /// Situation is also able to represent reified n-ary relations, where isSettingFor is the top-level relation for all binary projections of the n-ary relation. If used in a transformation pattern for n-ary relations, the designer should take care of creating only one subclass of Situation for each n-ary relation, otherwise the 'identification constraint' (Calvanese et al., IJCAI 2001) could be violated.^^xsd:string</para>
    ///   <para>rdfs:label : Situazionerdfs:label : Situation</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Situation">dul:Situation</a>
    /// </summary>
    let Situation = _prefixId.prefix "Situation"
    /// <summary>
    ///   <para>rdfs:comment : Any individual whose existence is granted simply by its social communicability and capability of action (through some PhysicalAgent).^^xsd:string</para>
    ///   <para>rdfs:label : Agente socialerdfs:label : Social agent</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#SocialAgent">dul:SocialAgent</a>
    /// </summary>
    let SocialAgent = _prefixId.prefix "SocialAgent"
    /// <summary>
    ///   <para>rdfs:comment : Any Object that exists only within some communication Event, in which at least one PhysicalObject participates in.
    /// In other words, all objects that have been or are created in the process of social communication: for the sake of communication (InformationObject), for incorporating new individuals (SocialAgent, Place), for contextualizing existing entities (Situation), for collecting existing entities (Collection), or for describing existing entities (Description, Concept).
    /// Being dependent on communication, all social objects need to be expressed by some information object (information object are self-expressing).^^xsd:string</para>
    ///   <para>rdfs:label : Oggetto socialerdfs:label : Social object</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#SocialObject">dul:SocialObject</a>
    /// </summary>
    let SocialObject = _prefixId.prefix "SocialObject"
    /// <summary>
    ///   <para>rdfs:comment : Any Region in a dimensional space that is used to represent some characteristic of a SocialObject, e.g. judgment values, social scalars, statistical attributes over a collection of entities, etc.^^xsd:string</para>
    ///   <para>rdfs:label : Caratteristica socialerdfs:label : Social attribute</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#SocialObjectAttribute">dul:SocialObjectAttribute</a>
    /// </summary>
    let SocialObjectAttribute = _prefixId.prefix "SocialObjectAttribute"
    /// <summary>
    ///   <para>owl:versionInfo : Formerly: Person (changed to avoid confusion with commonsense intuition)^^xsd:string</para>
    ///   <para>rdfs:comment : A SocialAgent that needs the existence of a specific NaturalPerson in order to act (but the lifetime of the NaturalPerson has only to overlap that of the SocialPerson).^^xsd:string</para>
    ///   <para>rdfs:label : Persona socialerdfs:label : Social person</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#SocialPerson">dul:SocialPerson</a>
    /// </summary>
    let SocialPerson = _prefixId.prefix "SocialPerson"
    /// <summary>
    ///   <para>rdfs:comment : Any social relationship^^xsd:string</para>
    ///   <para>rdfs:label : Relazione socialerdfs:label : Social relation</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#SocialRelation">dul:SocialRelation</a>
    /// </summary>
    let SocialRelation = _prefixId.prefix "SocialRelation"
    /// <summary>
    ///   <para>rdfs:comment : Any Region in a dimensional space that is used to localize an Entity ; i.e., it is not used to represent some characteristic (e.g. it excludes time intervals, colors, size values, judgment values, etc.). Differently from a Place , a space region has a specific dimensional space.^^xsd:string</para>
    ///   <para>rdfs:label : Regione di spaziordfs:label : Space region</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#SpaceRegion">dul:SpaceRegion</a>
    /// </summary>
    let SpaceRegion = _prefixId.prefix "SpaceRegion"
    let SpatioTemporalRegion = _prefixId.prefix "SpatioTemporalRegion"
    /// <summary>
    ///   <para>rdfs:comment : Any PhysicalBody that has not necessarily specified (designed) boundaries, e.g. a pile of trash, some sand, etc.
    /// In this sense, an artistic object made of trash or a dose of medicine in the form of a pill would be a FunctionalSubstance, and a DesignedArtifact, since its boundaries are specified by a Design; aleatoric objects that are outcomes of an artistic process might be still considered DesignedArtifact(s), and Substance(s).^^xsd:string</para>
    ///   <para>rdfs:label : Sostanzardfs:label : Substance</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Substance">dul:Substance</a>
    /// </summary>
    let Substance = _prefixId.prefix "Substance"
    /// <summary>
    ///   <para>rdfs:comment : An EventType that classifies an Action to be executed.
    /// For example, reaching a destination is a task that can be executed by performing certain actions, e.g. driving a car, buying a train ticket, etc.
    /// The actions to execute a task can also be organized according to a Plan that is not the same as the one that defines the task (if any).
    /// For example, reaching a destination could be defined by a plan to get on holidays, while the plan to execute the task can consist of putting some travels into a sequence.^^xsd:string</para>
    ///   <para>rdfs:label : Taskrdfs:label : Task</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Task">dul:Task</a>
    /// </summary>
    let Task = _prefixId.prefix "Task"
    /// <summary>
    ///   <para>rdfs:comment : A Theory is a Description that represents a set of assumptions for describing something, usually general. Scientific, philosophical, and commonsense theories can be included here.
    /// This class can also be used to act as 'naturalized reifications' of logical theories (of course, they will be necessarily incomplete in this case, because second-order entities are represented as first-order ones).^^xsd:string</para>
    ///   <para>rdfs:label : Teoriardfs:label : Theory</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Theory">dul:Theory</a>
    /// </summary>
    let Theory = _prefixId.prefix "Theory"
    /// <summary>
    ///   <para>rdfs:comment : Any Region in a dimensional space that aims at representing time.^^xsd:string</para>
    ///   <para>rdfs:label : Intervallo di tempordfs:label : Time interval</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#TimeInterval">dul:TimeInterval</a>
    /// </summary>
    let TimeInterval = _prefixId.prefix "TimeInterval"
    /// <summary>
    ///   <para>rdfs:comment : A transition is a Situation that creates a context for three TimeInterval(s), two additional different Situation(s), one Event, one Process, and at least one Object: the Event is observed as the cause for the transition, one Situation is the state before the transition, the second Situation is the state after the transition, the Process is the invariance under some different transitions (including the one represented here), in which at least one Object is situated. Finally, the time intervals position the situations and the transitional event in time.
    /// This class of situations partly encodes the ontology underlying typical engineering algebras for processes, e.g. Petri Nets.
    /// A full representation of the transition ontology is outside the expressivity of OWL, because we would need qualified cardinality restrictions,  coreference, property equivalence, and property composition.^^xsd:string</para>
    ///   <para>rdfs:label : Transitionrdfs:label : Transizione</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Transition">dul:Transition</a>
    /// </summary>
    let Transition = _prefixId.prefix "Transition"
    /// <summary>
    ///   <para>rdfs:comment : A Collection whose members are the maximal set of individuals that share the same (named) type, e.g. "the gem stones", "the Italians".
    /// This class is very useful to apply a variety of the so-called "ClassesAsValues" design pattern, when it is used to talk about the extensional aspect of a class. An alternative variety of the pattern applies to the intensional aspect of a class, and the class Concept should be used instead.^^xsd:string</para>
    ///   <para>rdfs:label : Collezione di un tipordfs:label : Type collection</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#TypeCollection">dul:TypeCollection</a>
    /// </summary>
    let TypeCollection = _prefixId.prefix "TypeCollection"
    /// <summary>
    ///   <para>rdfs:comment : Units of measure are conceptualized here as parameters on regions, which can be valued as datatype values.^^xsd:string</para>
    ///   <para>rdfs:label : Unità di misurardfs:label : Unit of measure</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#UnitOfMeasure">dul:UnitOfMeasure</a>
    /// </summary>
    let UnitOfMeasure = _prefixId.prefix "UnitOfMeasure"
    /// <summary>
    ///   <para>rdfs:comment : A Plan that defines Role(s), Task(s), and a specific structure for tasks to be executed, usually supporting the work of an Organization^^xsd:string</para>
    ///   <para>rdfs:label : Workflowrdfs:label : Workflow</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#Workflow">dul:Workflow</a>
    /// </summary>
    let Workflow = _prefixId.prefix "Workflow"
    /// <summary>
    ///   <para>rdfs:label : Esecuzione di workflowrdfs:label : Workflow execution</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#WorkflowExecution">dul:WorkflowExecution</a>
    /// </summary>
    let WorkflowExecution = _prefixId.prefix "WorkflowExecution"
    /// <summary>
    ///   <para>rdfs:comment : The relation holding between any Agent, and a SocialAgent. In principle, a SocialAgent requires at least one PhysicalAgent in order to act, but this dependency can be 'delegated'; e.g. a university can be acted for by a department, which on its turm is acted for by physical agents.^^xsd:string</para>
    ///   <para>rdfs:label : agisce perrdfs:label : acts for</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#actsFor">dul:actsFor</a>
    /// </summary>
    let actsFor = _prefixId.prefix "actsFor"
    /// <summary>
    ///   <para>rdfs:comment : The relation holding between a PhysicalAgent and a SocialAgent. In principle, a SocialAgent requires at least one PhysicalAgent in order to act, but this dependency can be 'delegated', e.g. a university can be acted for by a department, which is acted for by physical agents. AKA isActedBy^^xsd:string</para>
    ///   <para>rdfs:label : agisce medianterdfs:label : acts through</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#actsThrough">dul:actsThrough</a>
    /// </summary>
    let actsThrough = _prefixId.prefix "actsThrough"
    /// <summary>
    ///   <para>rdfs:comment : A catch-all object property, useful for alignment and querying purposes.^^xsd:string</para>
    ///   <para>rdfs:label : associatedWith^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#associatedWith">dul:associatedWith</a>
    /// </summary>
    let associatedWith = _prefixId.prefix "associatedWith"
    /// <summary>
    ///   <para>rdfs:comment : A relation between concepts and collections, where a Concept is said to characterize a Collection; it corresponds to a link between the (reified) intensional and extensional interpretations of a _proper subset of_ a (reified) class. This is different from covers, because it refers to an interpretation the entire reified class.
    /// E.g. the collection of vintage saxophones is characterized by the Concept 'manufactured by hand', while it gets covered by the Concept 'Saxophone' with the Parameter 'Vintage'.^^xsd:string</para>
    ///   <para>rdfs:label : caratterizzardfs:label : characterizes</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#characterizes">dul:characterizes</a>
    /// </summary>
    let characterizes = _prefixId.prefix "characterizes"
    /// <summary>
    ///   <para>rdfs:comment : A relation between a Concept and an Entity, e.g. the Role 'student' classifies a Person 'John'.^^xsd:string</para>
    ///   <para>rdfs:label : classificardfs:label : classifies</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#classifies">dul:classifies</a>
    /// </summary>
    let classifies = _prefixId.prefix "classifies"
    /// <summary>
    ///   <para>rdfs:comment : A relation stating that an Agent is internally representing a SocialObject: situations, descriptions, concepts, etc. E.g., 'John believes in the conspiracy theory'; 'Niels Bohr created the solar-system metaphor for the atomic theory'; 'Jacques assumes all swans are white'; 'the task force members share the attack plan'.
    /// Conceptualizations can be distinguished into different forms, primarily based on the type of SocialObject that is conceptualized. Descriptions and concepts can be 'assumed', situations can be 'believed' or 'known', plans can be 'adopted', etc. (see ontology: http://www.ontologydesignpatterns.org/ont/dul/Conceptualization.owl.^^xsd:string</para>
    ///   <para>rdfs:label : concettualizzardfs:label : conceptualizes</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#conceptualizes">dul:conceptualizes</a>
    /// </summary>
    let conceptualizes = _prefixId.prefix "conceptualizes"
    /// <summary>
    ///   <para>rdfs:comment : A relation between an InformationRealization and a Description, e.g. 'the printout of the Italian Constitution concretelyExpresses the Italian Constitution'. It should be supplied also with a rule stating that the InformationRealization realizes an InformationObject that expresses the Description^^xsd:string</para>
    ///   <para>rdfs:label : esprime concretamenterdfs:label : concretely expresses</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#concretelyExpresses">dul:concretelyExpresses</a>
    /// </summary>
    let concretelyExpresses = _prefixId.prefix "concretelyExpresses"
    /// <summary>
    ///   <para>rdfs:label : co-participates withrdfs:label : copartecipa con</para>
    ///   <para>rdfs:comment : A relation between two objects participating in a same Event; e.g., 'Vitas and Jimmy are playing tennis'.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#coparticipatesWith">dul:coparticipatesWith</a>
    /// </summary>
    let coparticipatesWith = _prefixId.prefix "coparticipatesWith"
    /// <summary>
    ///   <para>rdfs:comment : A relation between concepts and collections, where a Concept is said to cover a Collection; it corresponds to a link between the (reified) intensional and extensional interpretations of a (reified) class.
    /// E.g. the collection of vintage saxophones is covered by the Concept 'Saxophone' with the Parameter 'Vintage'.^^xsd:string</para>
    ///   <para>rdfs:label : ricoprerdfs:label : covers</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#covers">dul:covers</a>
    /// </summary>
    let covers = _prefixId.prefix "covers"
    /// <summary>
    ///   <para>rdfs:comment : A relation between a Description and a Concept, e.g. a Workflow for a governmental Organization defines the Role 'officer', or 'the Italian Traffic Law defines the role Vehicle'.^^xsd:string</para>
    ///   <para>rdfs:label : definiscerdfs:label : defines</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#defines">dul:defines</a>
    /// </summary>
    let defines = _prefixId.prefix "defines"
    /// <summary>
    ///   <para>rdfs:comment : A relation between a description and a role, e.g. the recipe for a cake defines the role 'ingredient'.^^xsd:string</para>
    ///   <para>rdfs:label : definisce il ruolordfs:label : defines role</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#definesRole">dul:definesRole</a>
    /// </summary>
    let definesRole = _prefixId.prefix "definesRole"
    /// <summary>
    ///   <para>rdfs:comment : A relation between a description and a task, e.g. the recipe for a cake defines the task 'boil'.^^xsd:string</para>
    ///   <para>rdfs:label : definisce il taskrdfs:label : defines task</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#definesTask">dul:definesTask</a>
    /// </summary>
    let definesTask = _prefixId.prefix "definesTask"
    /// <summary>
    ///   <para>rdfs:comment : The relation between a Description and an Entity : a Description gives a unity to a Collection of parts (the components), or constituents, by assigning a Role to each of them in the context of a whole Object (the system).
    /// A same Entity can be given different descriptions, for example, an old cradle can be given a unifying Description based on the original aesthetic design, the functionality it was built for, or a new aesthetic functionality in which it can be used as a flower pot.^^xsd:string</para>
    ///   <para>rdfs:label : descriverdfs:label : describes</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#describes">dul:describes</a>
    /// </summary>
    let describes = _prefixId.prefix "describes"
    /// <summary>
    ///   <para>rdfs:comment : The intransitive follows relation. For example, Wednesday directly precedes Thursday. Directness of precedence depends on the designer conceptualization.^^xsd:string</para>
    ///   <para>rdfs:label : segue direttamenterdfs:label : directly follows</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#directlyFollows">dul:directlyFollows</a>
    /// </summary>
    let directlyFollows = _prefixId.prefix "directlyFollows"
    /// <summary>
    ///   <para>rdfs:comment : The intransitive precedes relation. For example, Monday directly precedes Tuesday. Directness of precedence depends on the designer conceptualization.^^xsd:string</para>
    ///   <para>rdfs:label : precede direttamenterdfs:label : directly precedes</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#directlyPrecedes">dul:directlyPrecedes</a>
    /// </summary>
    let directlyPrecedes = _prefixId.prefix "directlyPrecedes"
    /// <summary>
    ///   <para>rdfs:comment : A relation between an action and a task, e.g. 'putting some water in a pot and putting the pot on a fire until the water starts bubbling' executes the task 'boiling'.^^xsd:string</para>
    ///   <para>rdfs:label : esegue il taskrdfs:label : executes task</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#executesTask">dul:executesTask</a>
    /// </summary>
    let executesTask = _prefixId.prefix "executesTask"
    /// <summary>
    ///   <para>rdfs:comment : A partial order relation that holds between descriptions. It represents the proper part relation between a description and another description featuring the same properties as the former, with at least one additional one.
    /// Descriptions can be expanded either by adding other descriptions as parts, or by refining concepts that are used by them.
    /// An 'intention' to expand must be present (unless purely formal theories are considered, but even in this case a criterion of relevance is usually active).^^xsd:string</para>
    ///   <para>rdfs:label : espanderdfs:label : expands</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#expands">dul:expands</a>
    /// </summary>
    let expands = _prefixId.prefix "expands"
    /// <summary>
    ///   <para>rdfs:comment : This is a large comment field for those who want to investigate the different uses of the 'expresses' relation for modeling different approaches to meaning characterization and modeling.
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
    /// This is only a first step to provide a framework, in which one can model different aspects of meaning. A more developed ontology should approach the problem of integrating the different uses of 'expresses', so that different theories, resources, methods can interoperate.^^xsd:stringrdfs:comment : A relation between an InformationObject and a 'meaning', generalized here as a 'SocialObject'. For example: 'A Beehive is a structure in which bees are kept, typically in the form of a dome or box.' (Oxford dictionary)'; 'the term Beehive expresses the concept Beehive in my apiculture ontology'.
    /// The intuition for 'meaning' is intended to be very broad. A separate, large comment is included for those who want to investigate more on what kind of meaning can be represented in what form.^^xsd:string</para>
    ///   <para>rdfs:label : esprimerdfs:label : expresses</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#expresses">dul:expresses</a>
    /// </summary>
    let expresses = _prefixId.prefix "expresses"
    /// <summary>
    ///   <para>rdfs:comment : A relation between an InformationObject and a Concept , e.g. the term "dog" expresses the Concept "dog". For expressing a relational meaning, see the more general object property: expresses^^xsd:string</para>
    ///   <para>rdfs:label : esprime il concettordfs:label : expresses concept</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#expressesConcept">dul:expressesConcept</a>
    /// </summary>
    let expressesConcept = _prefixId.prefix "expressesConcept"
    /// <summary>
    ///   <para>rdfs:comment : Generic distance relation between any Entity(s). E.g. Rome is far from Beijing, astronomy is far from necromancy.^^xsd:string</para>
    ///   <para>rdfs:label : far from</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#farFrom">dul:farFrom</a>
    /// </summary>
    let farFrom = _prefixId.prefix "farFrom"
    /// <summary>
    ///   <para>rdfs:label : seguerdfs:label : follows</para>
    ///   <para>rdfs:comment : A relation between entities, expressing a 'sequence' schema.
    /// E.g. 'year 2000 follows 1999', 'preparing coffee' follows 'deciding what coffee to use', 'II World War follows I World War', etc.
    /// It can be used between tasks, processes or time intervals, and subproperties would fit best in order to distinguish the different uses.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#follows">dul:follows</a>
    /// </summary>
    let follows = _prefixId.prefix "follows"
    /// <summary>
    ///   <para>rdfs:comment : A relation to encode either formal or informal characterizations of 'boundaries' common to two different entities: an Event that ends when another begins, two abstract regions that have a common topological boundary, two objects that are said to be 'in contact' from a commonsense perspective, etc.^^xsd:string</para>
    ///   <para>rdfs:label : has common boundary</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasCommonBoundary">dul:hasCommonBoundary</a>
    /// </summary>
    let hasCommonBoundary = _prefixId.prefix "hasCommonBoundary"
    /// <summary>
    ///   <para>rdfs:comment : The hasPart relation without transitivity, holding between an Object (the system) and another (the component), and assuming a Design that structures the Object.^^xsd:string</para>
    ///   <para>rdfs:label : ha componenterdfs:label : has component</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasComponent">dul:hasComponent</a>
    /// </summary>
    let hasComponent = _prefixId.prefix "hasComponent"
    /// <summary>
    ///   <para>rdfs:comment : 'Constituency' depends on some layering of  the world described by the ontology. For example, scientific granularities (e.g. body-organ-tissue-cell) or ontological 'strata' (e.g. social-mental-biological-physical) are  typical layerings.
    /// Intuitively, a constituent is a part belonging to a lower layer. Since layering is actually a partition of the world described by the ontology, constituents are not properly classified as parts, although this kinship can be intuitive for common sense.
    /// A desirable advantage of this distinction is that we are able to talk e.g. of physical constituents of non-physical objects (e.g. systems), while this is not possible in terms of parts.
    /// Example of are the persons constituting a social system, the molecules constituting a person, the atoms constituting a river, etc.
    /// In all these examples, we notice a typical discontinuity between the constituted and the constituent object: e.g. a social system is conceptualized at a different layer from the persons that constitute it, a person is conceptualized at a different layer from the molecules that constitute them, and a river is conceptualized at a different layer from the atoms that constitute it.^^xsd:string</para>
    ///   <para>rdfs:label : ha costituenterdfs:label : has constituent</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasConstituent">dul:hasConstituent</a>
    /// </summary>
    let hasConstituent = _prefixId.prefix "hasConstituent"
    /// <summary>
    ///   <para>rdfs:comment : A relation between parameters and entities. It allows to assert generic constraints (encoded as parameters), e.g. MinimumAgeForDriving isConstraintFor John (where John is a legal subject under the TrafficLaw).
    /// The intended semantics (not expressible in OWL) is that a Parameter isParameterFor a Concept that classifies an Entity; moreover, it entails that a Parameter parametrizes a Region that isRegionFor that Entity.^^xsd:string</para>
    ///   <para>rdfs:label : ha vincolordfs:label : has constraint</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasConstraint">dul:hasConstraint</a>
    /// </summary>
    let hasConstraint = _prefixId.prefix "hasConstraint"
    /// <summary>
    ///   <para>rdfs:comment : A datatype property that encodes values from a datatype for an Entity.
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
    /// Patterns (4) and (5) should be used instead when a constraint or a selection is modeled, independently from the actual observation of values in the real world.^^xsd:string</para>
    ///   <para>rdfs:label : ha valorerdfs:label : has data value</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasDataValue">dul:hasDataValue</a>
    /// </summary>
    let hasDataValue = _prefixId.prefix "hasDataValue"
    /// <summary>
    ///   <para>rdfs:comment : A datatype property that encodes values from xsd:date for an Event; a same Event can have more than one xsd:date value: begin date, end date, date at which the interval holds, as well as dates expressed in different formats: xsd:gYear, xsd:dateTime, etc.^^xsd:string</para>
    ///   <para>rdfs:label : evento ha datardfs:label : has event date</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasEventDate">dul:hasEventDate</a>
    /// </summary>
    let hasEventDate = _prefixId.prefix "hasEventDate"
    /// <summary>
    ///   <para>rdfs:comment : A datatype property that encodes values from xsd:date for a TimeInterval; a same TimeInterval can have more than one xsd:date value: begin date, end date, date at which the interval holds, as well as dates expressed in different formats: xsd:gYear, xsd:dateTime, etc.^^xsd:string</para>
    ///   <para>rdfs:label : intervallo ha datardfs:label : has interval date</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasIntervalDate">dul:hasIntervalDate</a>
    /// </summary>
    let hasIntervalDate = _prefixId.prefix "hasIntervalDate"
    /// <summary>
    ///   <para>rdfs:comment : A generic, relative spatial location, holding between any entities. E.g. 'the cat is on the mat', 'Omar is in Samarcanda', 'the wound is close to the femural artery'.
    /// For 'absolute' locations, see SpaceRegion^^xsd:string</para>
    ///   <para>rdfs:label : ha localizzazionerdfs:label : has location</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasLocation">dul:hasLocation</a>
    /// </summary>
    let hasLocation = _prefixId.prefix "hasLocation"
    /// <summary>
    ///   <para>rdfs:comment : A relation between collections and entities, e.g. 'my collection of saxophones includes an old Adolphe Sax original alto' (i.e. my collection has member an Adolphe Sax alto).^^xsd:string</para>
    ///   <para>rdfs:label : ha membrordfs:label : has member</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasMember">dul:hasMember</a>
    /// </summary>
    let hasMember = _prefixId.prefix "hasMember"
    /// <summary>
    ///   <para>rdfs:comment : A Concept can have a Parameter that constrains the attributes that a classified Entity can have in a certain Situation, e.g. a 4WheelDriver Role definedIn the ItalianTrafficLaw has a MinimumAge parameter on the Amount 16.^^xsd:string</para>
    ///   <para>rdfs:label : ha parametrordfs:label : has parameter</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasParameter">dul:hasParameter</a>
    /// </summary>
    let hasParameter = _prefixId.prefix "hasParameter"
    /// <summary>
    ///   <para>rdfs:comment : Parametrizes values from a datatype. For example, a Parameter MinimumAgeForDriving hasParameterDataValue 18 on datatype xsd:int, in the Italian traffic code. In this example, MinimumAgeForDriving isDefinedIn the Norm ItalianTrafficCodeAgeDriving.
    /// More complex parametrization requires workarounds. E.g. AgeRangeForDrugUsage could parametrize data value: 14 to 50 on the datatype: xsd:int. Since complex datatypes are not allowed in OWL1.0, a solution to this can only work by creating two 'sub-parameters': MinimumAgeForDrugUsage (that hasParameterDataValue 14) and MaximumAgeForDrugUsage (that hasParameterDataValue 50), which are components of (cf. hasComponent) the main Parameter AgeRangeForDrugUsage.
    /// Ordering on subparameters can be created by using or specializing the object property 'precedes'.^^xsd:string</para>
    ///   <para>rdfs:label : ha valorerdfs:label : has parameter data value</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasParameterDataValue">dul:hasParameterDataValue</a>
    /// </summary>
    let hasParameterDataValue = _prefixId.prefix "hasParameterDataValue"
    /// <summary>
    ///   <para>rdfs:comment : A schematic relation between any entities, e.g. 'the human body has a brain as part', '20th century contains year 1923', 'World War II includes the Pearl Harbour event'.
    /// Subproperties and restrictions can be used to specialize hasPart for objects, events, etc.^^xsd:string</para>
    ///   <para>rdfs:label : ha parterdfs:label : has part</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasPart">dul:hasPart</a>
    /// </summary>
    let hasPart = _prefixId.prefix "hasPart"
    /// <summary>
    ///   <para>rdfs:comment : A relation between an object and a process, e.g. 'John took part in the discussion', 'a large mass of snow fell during the avalanche', or 'a cook, some sugar, flour, etc. are all present in the cooking of a cake'.^^xsd:string</para>
    ///   <para>rdfs:label : ha come partecipanterdfs:label : has participant</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasParticipant">dul:hasParticipant</a>
    /// </summary>
    let hasParticipant = _prefixId.prefix "hasParticipant"
    /// <summary>
    ///   <para>rdfs:comment : Direct succession applied to situations.
    /// E.g., 'A postcondition of our Plan is to have things settled'.^^xsd:string</para>
    ///   <para>rdfs:label : ha postcondizionerdfs:label : has postcondition</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasPostcondition">dul:hasPostcondition</a>
    /// </summary>
    let hasPostcondition = _prefixId.prefix "hasPostcondition"
    /// <summary>
    ///   <para>rdfs:comment : Direct precedence applied to situations.
    /// E.g., 'A precondition to declare war against a foreign country is claiming to find nuclear weapons in it'.^^xsd:string</para>
    ///   <para>rdfs:label : ha precondizionerdfs:label : has precondition</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasPrecondition">dul:hasPrecondition</a>
    /// </summary>
    let hasPrecondition = _prefixId.prefix "hasPrecondition"
    /// <summary>
    ///   <para>rdfs:comment : A relation between entities and qualities, e.g. 'Dmitri's skin is yellowish'.^^xsd:string</para>
    ///   <para>rdfs:label : ha qualitàrdfs:label : has quality</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasQuality">dul:hasQuality</a>
    /// </summary>
    let hasQuality = _prefixId.prefix "hasQuality"
    /// <summary>
    ///   <para>rdfs:comment : A relation between entities and regions, e.g. 'the number of wheels of that truck is 12', 'the time of the experiment is August 9th, 2004', 'the whale has been localized at 34 degrees E, 20 degrees S'.^^xsd:string</para>
    ///   <para>rdfs:label : ha attributordfs:label : has region</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasRegion">dul:hasRegion</a>
    /// </summary>
    let hasRegion = _prefixId.prefix "hasRegion"
    /// <summary>
    ///   <para>rdfs:comment : A datatype property that encodes values for a Region, e.g. a float for the Region Height.^^xsd:string</para>
    ///   <para>rdfs:label : regione ha valorerdfs:label : has region data value</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasRegionDataValue">dul:hasRegionDataValue</a>
    /// </summary>
    let hasRegionDataValue = _prefixId.prefix "hasRegionDataValue"
    /// <summary>
    ///   <para>rdfs:comment : A relation between an object and a role, e.g. the person 'John' has role 'student'.^^xsd:string</para>
    ///   <para>rdfs:label : ha ruolordfs:label : has role</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasRole">dul:hasRole</a>
    /// </summary>
    let hasRole = _prefixId.prefix "hasRole"
    /// <summary>
    ///   <para>rdfs:comment : A relation between entities and situations, e.g. 'this morning I've prepared my coffee with a new fantastic Arabica', i.e.: (an amount of) a new fantastic Arabica hasSetting the preparation of my coffee this morning.^^xsd:string</para>
    ///   <para>rdfs:label : è nel contesto dirdfs:label : has setting</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasSetting">dul:hasSetting</a>
    /// </summary>
    let hasSetting = _prefixId.prefix "hasSetting"
    /// <summary>
    ///   <para>rdfs:comment : A relation between roles and tasks, e.g. 'students have the duty of giving exams' (i.e. the Role 'student' hasTask the Task 'giving exams').^^xsd:string</para>
    ///   <para>rdfs:label : ha come obiettivordfs:label : has task</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasTask">dul:hasTask</a>
    /// </summary>
    let hasTask = _prefixId.prefix "hasTask"
    /// <summary>
    ///   <para>rdfs:comment : The generic relation between events and time intervals.</para>
    ///   <para>rdfs:label : ha intervallo temporalerdfs:label : has time interval</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#hasTimeInterval">dul:hasTimeInterval</a>
    /// </summary>
    let hasTimeInterval = _prefixId.prefix "hasTimeInterval"
    /// <summary>
    ///   <para>rdfs:comment : A relation between situations and actions, e.g. 'this morning I've prepared my coffee and had my fingers burnt' (i.e.: the preparation of my coffee this morning included a burning of my fingers).^^xsd:string</para>
    ///   <para>rdfs:label : include azionerdfs:label : includes action</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#includesAction">dul:includesAction</a>
    /// </summary>
    let includesAction = _prefixId.prefix "includesAction"
    /// <summary>
    ///   <para>rdfs:comment : A relation between situations and persons, e.g. 'this morning I've prepared my coffee and had my fingers burnt' (i.e.: the preparation of my coffee this morning included me).^^xsd:string</para>
    ///   <para>rdfs:label : include l'agenterdfs:label : includes agent</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#includesAgent">dul:includesAgent</a>
    /// </summary>
    let includesAgent = _prefixId.prefix "includesAgent"
    /// <summary>
    ///   <para>rdfs:comment : A relation between situations and events, e.g. 'this morning I've prepared my coffee and had my fingers burnt' (i.e.: the preparation of my coffee this morning included a burning of my fingers).^^xsd:string</para>
    ///   <para>rdfs:label : include l'eventordfs:label : includes event</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#includesEvent">dul:includesEvent</a>
    /// </summary>
    let includesEvent = _prefixId.prefix "includesEvent"
    /// <summary>
    ///   <para>rdfs:comment : A relation between situations and objects, e.g. 'this morning I've prepared my coffee and had my fingers burnt' (i.e.: the preparation of my coffee this morning included me).^^xsd:string</para>
    ///   <para>rdfs:label : include l'oggettordfs:label : includes object</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#includesObject">dul:includesObject</a>
    /// </summary>
    let includesObject = _prefixId.prefix "includesObject"
    /// <summary>
    ///   <para>rdfs:comment : A relation between situations and time intervals, e.g. 'this morning I've prepared my coffee and had my fingers burnt' (i.e.: preparing my coffee was held this morning). A data value attached to the time interval typically complements this modelling pattern.^^xsd:string</para>
    ///   <para>rdfs:label : include tempordfs:label : includes time</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#includesTime">dul:includesTime</a>
    /// </summary>
    let includesTime = _prefixId.prefix "includesTime"
    /// <summary>
    ///   <para>rdfs:comment : A relation between a Description and a SocialAgent, e.g. a Constitutional Charter introduces the SocialAgent 'PresidentOfRepublic'.^^xsd:string</para>
    ///   <para>rdfs:label : introducerdfs:label : introduces</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#introduces">dul:introduces</a>
    /// </summary>
    let introduces = _prefixId.prefix "introduces"
    /// <summary>
    ///   <para>rdfs:comment : Agent participation.^^xsd:string</para>
    ///   <para>rdfs:label : coinvolge agenterdfs:label : involves agent</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#involvesAgent">dul:involvesAgent</a>
    /// </summary>
    let involvesAgent = _prefixId.prefix "involvesAgent"
    /// <summary>
    ///   <para>rdfs:comment : A relation between information objects and any Entity (including information objects). It can be used to talk about e.g. entities are references of proper nouns: the proper noun 'Leonardo da Vinci' isAbout the Person Leonardo da Vinci; as well as to talk about sets of entities that can be described by a common noun: the common noun 'person' isAbout the set of all persons in a domain of discourse, which can be represented in DOLCE-Ultralite as an individual of the class: Collection .
    /// The isAbout relation is reflexive (not expressible in OWL1.0), because information objects are also about themselves.^^xsd:string</para>
    ///   <para>rdfs:label : si riferisce ardfs:label : is about</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isAbout">dul:isAbout</a>
    /// </summary>
    let isAbout = _prefixId.prefix "isAbout"
    /// <summary>
    ///   <para>rdfs:label : è un'azione nel contesto dirdfs:label : is action included in</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isActionIncludedIn">dul:isActionIncludedIn</a>
    /// </summary>
    let isActionIncludedIn = _prefixId.prefix "isActionIncludedIn"
    /// <summary>
    ///   <para>rdfs:label : è un agente nel contesto dirdfs:label : is agent included in</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isAgentIncludedIn">dul:isAgentIncludedIn</a>
    /// </summary>
    let isAgentIncludedIn = _prefixId.prefix "isAgentIncludedIn"
    /// <summary>
    ///   <para>rdfs:comment : Agent participation.^^xsd:string</para>
    ///   <para>rdfs:label : è un agente coinvolto inrdfs:label : is agent involved in</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isAgentInvolvedIn">dul:isAgentInvolvedIn</a>
    /// </summary>
    let isAgentInvolvedIn = _prefixId.prefix "isAgentInvolvedIn"
    /// <summary>
    ///   <para>rdfs:label : è caratterizzato dardfs:label : is characterized byrdfs:label : is characterized by {@en-us}^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isCharacterizedBy">dul:isCharacterizedBy</a>
    /// </summary>
    let isCharacterizedBy = _prefixId.prefix "isCharacterizedBy"
    /// <summary>
    ///   <para>rdfs:comment : A relation between a Concept and an Entity, e.g. 'John is considered a typical rude man'; your last concert constitutes the achievement of a lifetime; '20-year-old means she's mature enough'.^^xsd:string</para>
    ///   <para>rdfs:label : è classificato dardfs:label : is classified by</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isClassifiedBy">dul:isClassifiedBy</a>
    /// </summary>
    let isClassifiedBy = _prefixId.prefix "isClassifiedBy"
    /// <summary>
    ///   <para>rdfs:comment : The hasPart relation without transitivity, holding between an Object (the system) and another (the component), and assuming a Design that structures the Object.^^xsd:string</para>
    ///   <para>rdfs:label : è componente dirdfs:label : is component of</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isComponentOf">dul:isComponentOf</a>
    /// </summary>
    let isComponentOf = _prefixId.prefix "isComponentOf"
    /// <summary>
    ///   <para>rdfs:comment : A relation between an InformationObject and a Concept , e.g. the term "dog" expresses the Concept "dog". For expressing a relational meaning, see the more general object property: expresses^^xsd:string</para>
    ///   <para>rdfs:label : è un concetto espresso dardfs:label : is concept expressed by</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isConceptExpressedBy">dul:isConceptExpressedBy</a>
    /// </summary>
    let isConceptExpressedBy = _prefixId.prefix "isConceptExpressedBy"
    /// <summary>
    ///   <para>rdfs:comment : A more generic relation holding between a Description and a Concept. In order to be used, a Concept must be previously definedIn another Description^^xsd:string</para>
    ///   <para>rdfs:label : è un concetto usato inrdfs:label : is concept used in</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isConceptUsedIn">dul:isConceptUsedIn</a>
    /// </summary>
    let isConceptUsedIn = _prefixId.prefix "isConceptUsedIn"
    /// <summary>
    ///   <para>rdfs:comment : A relation stating that an Agent is internally representing a Description . E.g., 'John believes in the conspiracy theory'; 'Niels Bohr created a solar-system metaphor for his atomic theory'; 'Jacques assumes all swans are white'; 'the task force shares the attack plan'.^^xsd:string</para>
    ///   <para>rdfs:label : è concettualizzato dardfs:label : is conceptualized by</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isConceptualizedBy">dul:isConceptualizedBy</a>
    /// </summary>
    let isConceptualizedBy = _prefixId.prefix "isConceptualizedBy"
    /// <summary>
    ///   <para>rdfs:comment : A relation between an InformationRealization and a Description, e.g. 'the printout of the Italian Constitution concretelyExpresses the Italian Constitution'. It should be supplied also with a rule stating that the InformationRealization realizes an InformationObject that expresses the Description^^xsd:string</para>
    ///   <para>rdfs:label : è espresso concretamente dardfs:label : is concretely expressed by</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isConcretelyExpressedBy">dul:isConcretelyExpressedBy</a>
    /// </summary>
    let isConcretelyExpressedBy = _prefixId.prefix "isConcretelyExpressedBy"
    /// <summary>
    ///   <para>rdfs:comment : 'Constituency' depends on some layering of  the world described by the ontology. For example, scientific granularities (e.g. body-organ-tissue-cell) or ontological 'strata' (e.g. social-mental-biological-physical) are  typical layerings.
    /// Intuitively, a constituent is a part belonging to a lower layer. Since layering is actually a partition of the world described by the ontology, constituents are not properly classified as parts, although this kinship can be intuitive for common sense.
    /// A desirable advantage of this distinction is that we are able to talk e.g. of physical constituents of non-physical objects (e.g. systems), while this is not possible in terms of parts.
    /// Example of are the persons constituting a social system, the molecules constituting a person, the atoms constituting a river, etc.
    /// In all these examples, we notice a typical discontinuity between the constituted and the constituent object: e.g. a social system is conceptualized at a different layer from the persons that constitute it, a person is conceptualized at a different layer from the molecules that constitute them, and a river is conceptualized at a different layer from the atoms that constitute it.^^xsd:string</para>
    ///   <para>rdfs:label : è costituente dirdfs:label : is constituent of</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isConstituentOf">dul:isConstituentOf</a>
    /// </summary>
    let isConstituentOf = _prefixId.prefix "isConstituentOf"
    /// <summary>
    ///   <para>rdfs:comment : A relation between parameters and entities. It allows to assert generic constraints (encoded as parameters), e.g. MinimumAgeForDriving isConstraintFor John (where John is a legal subject under the TrafficLaw).
    /// The intended semantics (not expressible in OWL) is that a Parameter isConstraintFor and Entity if the Parameter isParameterFor a Concept that classifies that Entity; moreover, it entails that a Parameter parametrizes a Region that isRegionFor that Entity. The use in OWL is therefore a shortcut to annotate what Parameter constrains what Entity^^xsd:string</para>
    ///   <para>rdfs:label : è un vincolo perrdfs:label : is constraint for</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isConstraintFor">dul:isConstraintFor</a>
    /// </summary>
    let isConstraintFor = _prefixId.prefix "isConstraintFor"
    /// <summary>
    ///   <para>rdfs:comment : A relation between concepts and collections, where a Concept is said to cover a Collection; it corresponds to a link between the (reified) intensional and extensional interpretations of a (reified) class.
    /// E.g. the collection of vintage saxophones is covered by the Concept 'Saxophone' with the Parameter 'Vintage'.^^xsd:string</para>
    ///   <para>rdfs:label : è ricoperto dardfs:label : is covered by</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isCoveredBy">dul:isCoveredBy</a>
    /// </summary>
    let isCoveredBy = _prefixId.prefix "isCoveredBy"
    /// <summary>
    ///   <para>rdfs:comment : A relation between a Description and a Concept, e.g. a Workflow for a governmental Organization defines the Role 'officer', or 'the Italian Traffic Law defines the role Vehicle'.^^xsd:string</para>
    ///   <para>rdfs:label : è definito inrdfs:label : is defined in</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isDefinedIn">dul:isDefinedIn</a>
    /// </summary>
    let isDefinedIn = _prefixId.prefix "isDefinedIn"
    /// <summary>
    ///   <para>rdfs:comment : The relation between an Entity and a Description: a Description gives a unity to a Collection of parts (the components), or constituents, by assigning a Role to each of them in the context of a whole Object (the system).
    /// A same Entity can be given different descriptions, for example, an old cradle can be given a unifying Description based on the original aesthetic design, the functionality it was built for, or a new aesthetic functionality in which it can be used as a flower pot.^^xsd:string</para>
    ///   <para>rdfs:label : è descritto dardfs:label : is described by</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isDescribedBy">dul:isDescribedBy</a>
    /// </summary>
    let isDescribedBy = _prefixId.prefix "isDescribedBy"
    /// <summary>
    ///   <para>rdfs:label : è un evento nel contesto dirdfs:label : is event included in</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isEventIncludedIn">dul:isEventIncludedIn</a>
    /// </summary>
    let isEventIncludedIn = _prefixId.prefix "isEventIncludedIn"
    /// <summary>
    ///   <para>rdfs:comment : A relation between an action and a task, e.g. 'putting some water in a pot and putting the pot on a fire until the water starts bubbling' executes the task 'boiling'.^^xsd:string</para>
    ///   <para>rdfs:label : è eseguito medianterdfs:label : is executed in</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isExecutedIn">dul:isExecutedIn</a>
    /// </summary>
    let isExecutedIn = _prefixId.prefix "isExecutedIn"
    /// <summary>
    ///   <para>rdfs:comment : A partial order relation that holds between descriptions. It represents the proper part relation between a description and another description featuring the same properties as the former, with at least one additional one.
    /// Descriptions can be expanded either by adding other descriptions as parts, or by refining concepts that are used by them.
    /// An 'intention' to expand must be present (unless purely formal theories are considered, but even in this case a criterion of relevance is usually active).^^xsd:string</para>
    ///   <para>rdfs:label : è espansa inrdfs:label : is expanded in</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isExpandedIn">dul:isExpandedIn</a>
    /// </summary>
    let isExpandedIn = _prefixId.prefix "isExpandedIn"
    /// <summary>
    ///   <para>rdfs:comment : A relation between a dul:SocialObject (the 'meaning') and a dul:InformationObject (the 'expression').
    /// For example: 'A Beehive is a structure in which bees are kept, typically in the form of a dome or box.' (Oxford dictionary)'; 'the term Beehive expresses the concept Beehive in my apiculture ontology'.
    /// The intuition for 'meaning' is intended to be very broad. A separate, large comment is included in the encoding of 'expresses', for those who want to investigate more on what kind of meaning can be represented in what form.^^xsd:string</para>
    ///   <para>rdfs:label : è espresso dardfs:label : is expressed by</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isExpressedBy">dul:isExpressedBy</a>
    /// </summary>
    let isExpressedBy = _prefixId.prefix "isExpressedBy"
    /// <summary>
    ///   <para>rdfs:comment : A relation between a Description and a SocialAgent, e.g. a Constitutional Charter introduces the SocialAgent 'PresidentOfRepublic'.^^xsd:string</para>
    ///   <para>rdfs:label : è introdotto dardfs:label : is introduced by</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isIntroducedBy">dul:isIntroducedBy</a>
    /// </summary>
    let isIntroducedBy = _prefixId.prefix "isIntroducedBy"
    /// <summary>
    ///   <para>rdfs:comment : A generic, relative localization, holding between any entities. E.g. 'Rome is the seat of the Pope', 'the liver is the location of the tumor'.
    /// For 'absolute' locations, see SpaceRegion^^xsd:string</para>
    ///   <para>rdfs:label : è una localizzazione dirdfs:label : is location of</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isLocationOf">dul:isLocationOf</a>
    /// </summary>
    let isLocationOf = _prefixId.prefix "isLocationOf"
    /// <summary>
    ///   <para>rdfs:comment : A relation between collections and entities, e.g. 'the Night Watch by Rembrandt is in the Rijksmuseum collection'; 'Davide is member of the Pen Club', 'Igor is one the subjects chosen for the experiment'.^^xsd:string</para>
    ///   <para>rdfs:label : è membro dirdfs:label : is member of</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isMemberOf">dul:isMemberOf</a>
    /// </summary>
    let isMemberOf = _prefixId.prefix "isMemberOf"
    /// <summary>
    ///   <para>rdfs:label : è un oggetto nel contesto dirdfs:label : is object included in</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isObjectIncludedIn">dul:isObjectIncludedIn</a>
    /// </summary>
    let isObjectIncludedIn = _prefixId.prefix "isObjectIncludedIn"
    /// <summary>
    ///   <para>rdfs:comment : A relation to represent a (past, present or future) TimeInterval at which an Entity is observable.
    /// In order to encode a specific time, a data value should be related to the TimeInterval.
    /// An alternative way of representing time is the datatype property: hasIntervalDate^^xsd:string</para>
    ///   <para>rdfs:label : è osservabile ardfs:label : is observable at</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isObservableAt">dul:isObservableAt</a>
    /// </summary>
    let isObservableAt = _prefixId.prefix "isObservableAt"
    /// <summary>
    ///   <para>rdfs:comment : A Concept can have a Parameter that constrains the attributes that a classified Entity can have in a certain Situation, e.g. a 4WheelDriver Role definedIn the ItalianTrafficLaw has a MinimumAge parameter on the Amount 16.^^xsd:string</para>
    ///   <para>rdfs:label : è un parametro perrdfs:label : is parameter for</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isParameterFor">dul:isParameterFor</a>
    /// </summary>
    let isParameterFor = _prefixId.prefix "isParameterFor"
    /// <summary>
    ///   <para>rdfs:comment : The relation between a Parameter, e.g. 'MajorAge', and a Region, e.g. '&gt;17 year'.^^xsd:string</para>
    ///   <para>rdfs:label : è parametrizzato dardfs:label : is parametrized by</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isParametrizedBy">dul:isParametrizedBy</a>
    /// </summary>
    let isParametrizedBy = _prefixId.prefix "isParametrizedBy"
    /// <summary>
    ///   <para>rdfs:label : è parte dirdfs:label : is part of</para>
    ///   <para>rdfs:comment : A relation between any entities, e.g.'brain is a part of the human body'.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isPartOf">dul:isPartOf</a>
    /// </summary>
    let isPartOf = _prefixId.prefix "isPartOf"
    /// <summary>
    ///   <para>rdfs:comment : A relation between an object and a process, e.g. 'John took part in the discussion', 'a large mass of snow fell during the avalanche', or 'a cook, some sugar, flour, etc. are all present in the cooking of a cake'.^^xsd:string</para>
    ///   <para>rdfs:label : è un partecipante ardfs:label : is participant in</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isParticipantIn">dul:isParticipantIn</a>
    /// </summary>
    let isParticipantIn = _prefixId.prefix "isParticipantIn"
    /// <summary>
    ///   <para>rdfs:comment : Direct succession applied to situations.
    /// E.g., 'Taking some rest is a postcondition of my search for a hotel'.^^xsd:string</para>
    ///   <para>rdfs:label : è postcondizione dirdfs:label : is postcondition of</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isPostconditionOf">dul:isPostconditionOf</a>
    /// </summary>
    let isPostconditionOf = _prefixId.prefix "isPostconditionOf"
    /// <summary>
    ///   <para>rdfs:comment : Direct precedence applied to situations.
    /// E.g., 'claiming to find nuclear weapons in a foreign country is a precondition to declare war against it'.^^xsd:string</para>
    ///   <para>rdfs:label : è precondizione dirdfs:label : is precondition of</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isPreconditionOf">dul:isPreconditionOf</a>
    /// </summary>
    let isPreconditionOf = _prefixId.prefix "isPreconditionOf"
    /// <summary>
    ///   <para>rdfs:comment : A relation between entities and qualities, e.g. 'Dmitri's skin is yellowish'.^^xsd:string</para>
    ///   <para>rdfs:label : è una qualità dirdfs:label : is quality of</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isQualityOf">dul:isQualityOf</a>
    /// </summary>
    let isQualityOf = _prefixId.prefix "isQualityOf"
    /// <summary>
    ///   <para>rdfs:comment : A relation between an information realization and an information object, e.g. the paper copy of the Italian Constitution realizes the text of the Constitution.^^xsd:string</para>
    ///   <para>rdfs:label : è realizzato dardfs:label : is realized by</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isRealizedBy">dul:isRealizedBy</a>
    /// </summary>
    let isRealizedBy = _prefixId.prefix "isRealizedBy"
    /// <summary>
    ///   <para>rdfs:comment : A relation between information objects and any Entity (including information objects). It can be used to talk about e.g. entities are references of proper nouns: the proper noun 'Leonardo da Vinci' isAbout the Person Leonardo da Vinci; as well as to talk about sets of entities that can be described by a common noun: the common noun 'person' isAbout the set of all persons in a domain of discourse, which can be represented in DOLCE-Ultralite as an individual of the class: Collection .
    /// The isReferenceOf relation is irreflexive, differently from its inverse isAbout.^^xsd:string</para>
    ///   <para>rdfs:label : è il riferimento dirdfs:label : is reference of</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isReferenceOf">dul:isReferenceOf</a>
    /// </summary>
    let isReferenceOf = _prefixId.prefix "isReferenceOf"

    /// <summary>
    ///   <para>rdfs:comment : The relation between entities and information realizations, e.g. between Italy and a paper copy of the text of the Italian Constitution.^^xsd:string</para>
    ///   <para>rdfs:label : è riferimento dell'informazione realizzata dardfs:label : is reference of information realized by</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isReferenceOfInformationRealizedBy">dul:isReferenceOfInformationRealizedBy</a>
    /// </summary>
    let isReferenceOfInformationRealizedBy =
        _prefixId.prefix "isReferenceOfInformationRealizedBy"

    /// <summary>
    ///   <para>rdfs:comment : A relation between entities and regions, e.g. 'the color of my car is red'.^^xsd:string</para>
    ///   <para>rdfs:label : è una regione dirdfs:label : is region for</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isRegionFor">dul:isRegionFor</a>
    /// </summary>
    let isRegionFor = _prefixId.prefix "isRegionFor"
    /// <summary>
    ///   <para>rdfs:label : is related to conceptrdfs:label : è associato al concetto</para>
    ///   <para>rdfs:comment : Any relation between concepts, e.g. superordinated, conceptual parthood, having a parameter, having a task, superordination, etc.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isRelatedToConcept">dul:isRelatedToConcept</a>
    /// </summary>
    let isRelatedToConcept = _prefixId.prefix "isRelatedToConcept"
    /// <summary>
    ///   <para>rdfs:label : è associata alla descrizionerdfs:label : is related to description</para>
    ///   <para>rdfs:comment : Any relation between descriptions.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isRelatedToDescription">dul:isRelatedToDescription</a>
    /// </summary>
    let isRelatedToDescription = _prefixId.prefix "isRelatedToDescription"
    /// <summary>
    ///   <para>rdfs:comment : A relation between a description and a role, e.g. the role 'Ingredient' is defined in the recipe for a cake.^^xsd:string</para>
    ///   <para>rdfs:label : è un ruolo definito inrdfs:label : is role defined in</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isRoleDefinedIn">dul:isRoleDefinedIn</a>
    /// </summary>
    let isRoleDefinedIn = _prefixId.prefix "isRoleDefinedIn"
    /// <summary>
    ///   <para>rdfs:comment : A relation between an object and a role, e.g. 'student' is the role of 'John'.^^xsd:string</para>
    ///   <para>rdfs:label : è un ruolo dirdfs:label : is role of</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isRoleOf">dul:isRoleOf</a>
    /// </summary>
    let isRoleOf = _prefixId.prefix "isRoleOf"
    /// <summary>
    ///   <para>rdfs:comment : A relation between a Situation and a Description, e.g. the execution of a Plan satisfies that plan.^^xsd:string</para>
    ///   <para>rdfs:label : è soddisfatta dardfs:label : is satisfied by</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isSatisfiedBy">dul:isSatisfiedBy</a>
    /// </summary>
    let isSatisfiedBy = _prefixId.prefix "isSatisfiedBy"
    /// <summary>
    ///   <para>rdfs:comment : A relation between situations and entities, e.g. 'this morning I've prepared my coffee with a new fantastic Arabica', i.e.: the preparation of my coffee this morning is the setting for (an amount of) a new fantastic Arabica.^^xsd:string</para>
    ///   <para>rdfs:label : includerdfs:label : is setting for</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isSettingFor">dul:isSettingFor</a>
    /// </summary>
    let isSettingFor = _prefixId.prefix "isSettingFor"
    /// <summary>
    ///   <para>rdfs:label : è specializzato dardfs:label : is specialized by</para>
    ///   <para>rdfs:comment : A partial order relation that holds between social objects. It represents the subsumption relation between e.g. a Concept and another Concept that is broader in extensional interpretation, but narrowe in intensional interpretation.
    /// E.g. PhDStudent Role specializes Student Role^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isSpecializedBy">dul:isSpecializedBy</a>
    /// </summary>
    let isSpecializedBy = _prefixId.prefix "isSpecializedBy"
    /// <summary>
    ///   <para>rdfs:comment : Direct succession applied to concepts. E.g. the role 'Officer' is subordinated to 'Director'.^^xsd:string</para>
    ///   <para>rdfs:label : è subordinato ardfs:label : is subordinated to</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isSubordinatedTo">dul:isSubordinatedTo</a>
    /// </summary>
    let isSubordinatedTo = _prefixId.prefix "isSubordinatedTo"
    /// <summary>
    ///   <para>rdfs:comment : Direct precedence applied to concepts. E.g. the role 'Executive' is superordinated to 'DepartmentManager'.^^xsd:string</para>
    ///   <para>rdfs:label : è superordinato ardfs:label : is superordinated to</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isSuperordinatedTo">dul:isSuperordinatedTo</a>
    /// </summary>
    let isSuperordinatedTo = _prefixId.prefix "isSuperordinatedTo"
    /// <summary>
    ///   <para>rdfs:comment : A relation between a description and a task, e.g. the task 'boil' is defined in a recipe for a cake.^^xsd:string</para>
    ///   <para>rdfs:label : è un task definito inrdfs:label : is task defined in</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isTaskDefinedIn">dul:isTaskDefinedIn</a>
    /// </summary>
    let isTaskDefinedIn = _prefixId.prefix "isTaskDefinedIn"
    /// <summary>
    ///   <para>rdfs:comment : A relation between roles and tasks, e.g. 'students have the duty of giving exams' (i.e. the Role 'student' hasTask the Task 'giving exams').^^xsd:string</para>
    ///   <para>rdfs:label : è un obiettivo perrdfs:label : is task of</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isTaskOf">dul:isTaskOf</a>
    /// </summary>
    let isTaskOf = _prefixId.prefix "isTaskOf"
    /// <summary>
    ///   <para>rdfs:label : è un tempo nel contesto dirdfs:label : is time included in</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isTimeIncludedIn">dul:isTimeIncludedIn</a>
    /// </summary>
    let isTimeIncludedIn = _prefixId.prefix "isTimeIncludedIn"
    /// <summary>
    ///   <para>rdfs:comment : The generic relation between time intervals and events.</para>
    ///   <para>rdfs:label : intervallo temporale dirdfs:label : is time interval of</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isTimeIntervalOf">dul:isTimeIntervalOf</a>
    /// </summary>
    let isTimeIntervalOf = _prefixId.prefix "isTimeIntervalOf"
    /// <summary>
    ///   <para>rdfs:comment : A relation to represent a (past, present or future) TimeInterval at which an Entity is observable.
    /// In order to encode a specific time, a data value should be related to the TimeInterval.
    /// An alternative way of representing time is the datatype property: hasIntervalDate^^xsd:string</para>
    ///   <para>rdfs:label : è il tempo di osservazione dirdfs:label : is time of observation of</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isTimeOfObservationOf">dul:isTimeOfObservationOf</a>
    /// </summary>
    let isTimeOfObservationOf = _prefixId.prefix "isTimeOfObservationOf"
    /// <summary>
    ///   <para>rdfs:comment : A Collection has a unification criterion, provided by a Description; for example, a community of practice can be unified by a shared theory or interest, e.g. the community that makes research on mirror neurons shares some core knowledge about mirror neurons, which can be represented as a Description MirrorNeuronTheory that unifies the community. There can be several unifying descriptions.^^xsd:string</para>
    ///   <para>rdfs:label : è unificato dardfs:label : is unified by</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#isUnifiedBy">dul:isUnifiedBy</a>
    /// </summary>
    let isUnifiedBy = _prefixId.prefix "isUnifiedBy"
    /// <summary>
    ///   <para>rdfs:comment : Generic distance relation between any Entity(s). E.g. Rome is near to Florence, astronomy is near to physics.^^xsd:string</para>
    ///   <para>rdfs:label : near to</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#nearTo">dul:nearTo</a>
    /// </summary>
    let nearTo = _prefixId.prefix "nearTo"
    /// <summary>
    ///   <para>rdfs:label : overlapsrdfs:label : sovrapposto a</para>
    ///   <para>rdfs:comment : A schematic relation between any entities, e.g. 'the chest region overlaps with the abdomen region', 'my spoken words overlap with hers', 'the time of my leave overlaps with the time of your arrival', 'fibromyalgia overlaps with other conditions'.
    /// Subproperties and restrictions can be used to specialize overlaps for objects, events, time intervals, etc.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#overlaps">dul:overlaps</a>
    /// </summary>
    let overlaps = _prefixId.prefix "overlaps"
    /// <summary>
    ///   <para>rdfs:comment : The relation between a Parameter, e.g. 'MajorAgeLimit', and a Region, e.g. '18_year'.
    /// For a more data-oriented relation, see hasDataValue^^xsd:string</para>
    ///   <para>rdfs:label : parametrizzardfs:label : parametrizes</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#parametrizes">dul:parametrizes</a>
    /// </summary>
    let parametrizes = _prefixId.prefix "parametrizes"
    /// <summary>
    ///   <para>rdfs:comment : A relation between entities, expressing a 'sequence' schema.
    /// E.g. 'year 1999 precedes 2000', 'deciding what coffee to use' precedes 'preparing coffee', 'World War II follows World War I', 'in the Milan to Rome autoroute, Bologna precedes Florence', etc.
    /// It can then be used between tasks, processes, time intervals, spatially locate objects, situations, etc.
    /// Subproperties can be defined in order to distinguish the different uses.^^xsd:string</para>
    ///   <para>rdfs:label : precederdfs:label : precedes</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#precedes">dul:precedes</a>
    /// </summary>
    let precedes = _prefixId.prefix "precedes"
    /// <summary>
    ///   <para>rdfs:comment : A relation between an information realization and an information object, e.g. the paper copy of the Italian Constitution realizes the text of the Constitution.^^xsd:string</para>
    ///   <para>rdfs:label : realizzardfs:label : realizes</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#realizes">dul:realizes</a>
    /// </summary>
    let realizes = _prefixId.prefix "realizes"
    /// <summary>
    ///   <para>rdfs:comment : The relation between entities and information realizations, e.g. between Italy and a paper copy of the text of the Italian Constitution.^^xsd:string</para>
    ///   <para>rdfs:label : realizza informazione che si riferisce a ardfs:label : realizes information about</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#realizesInformationAbout">dul:realizesInformationAbout</a>
    /// </summary>
    let realizesInformationAbout = _prefixId.prefix "realizesInformationAbout"
    /// <summary>
    ///   <para>rdfs:label : is in the same setting asrdfs:label : è nella stessa situazione di</para>
    ///   <para>rdfs:isDefinedBy : http://www.ontologydesignpatterns.org/ont/dul/DUL.owl^^xsd:string</para>
    ///   <para>rdfs:comment : A relation between two entities participating in a same Situation; e.g., 'Our company provides an antivenom service' (the situation is the service, the two entities are the company and the antivenom).</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#sameSettingAs">dul:sameSettingAs</a>
    /// </summary>
    let sameSettingAs = _prefixId.prefix "sameSettingAs"
    /// <summary>
    ///   <para>rdfs:comment : A relation between a Situation and a Description, e.g. the execution of a Plan satisfies that plan.^^xsd:string</para>
    ///   <para>rdfs:label : soddisfardfs:label : satisfies</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#satisfies">dul:satisfies</a>
    /// </summary>
    let satisfies = _prefixId.prefix "satisfies"
    /// <summary>
    ///   <para>rdfs:comment : A partial order relation that holds between social objects.
    /// It mainly represents the subsumption relation between e.g. a Concept or Description and another Concept (resp. Description) that is broader in extensional interpretation, but narrower in intensional interpretation. For example, the role PhDStudent specializes the role Student.
    /// Another possible use is between a Collection that isCoveredBy a Concept A, and another Collection that isCoveredBy a Concept B that on its turm specializes A. For example, the 70,000 series Selmer Mark VI saxophone Collection specializes the Selmer Mark VI saxophone Collection.^^xsd:string</para>
    ///   <para>rdfs:label : specializzardfs:label : specializes</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#specializes">dul:specializes</a>
    /// </summary>
    let specializes = _prefixId.prefix "specializes"
    /// <summary>
    ///   <para>rdfs:comment : A Collection has a unification criterion, provided by a Description; for example, a community of practice can be unified by a shared theory or interest, e.g. the community that makes research on mirror neurons shares some core knowledge about mirror neurons, which can be represented as a Description MirrorNeuronTheory that unifies the community. There can be several unifying descriptions.^^xsd:string</para>
    ///   <para>rdfs:label : unificardfs:label : unifies</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#unifies">dul:unifies</a>
    /// </summary>
    let unifies = _prefixId.prefix "unifies"
    /// <summary>
    ///   <para>rdfs:comment : A generic relation holding between a Description and a Concept. In order to be used, a Concept must be previously definedIn another Description. This last condition cannot be encoded for object properties in OWL.^^xsd:string</para>
    ///   <para>rdfs:label : usa il concettordfs:label : uses concept</para>
    ///   <a href="http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#usesConcept">dul:usesConcept</a>
    /// </summary>
    let usesConcept = _prefixId.prefix "usesConcept"
