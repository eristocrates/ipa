#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module drama =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.purl.org/drammar#" "drama"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : ADTComponent^^xsd:string</para>
    ///   <para>rdfs:comment : ADTComponent This class includes the entities which provide the components of
    ///             abstract data types. Currently, only the list data type includes a component, the
    ///             OrderedListElement. The mapping on the AbstractDataType class is given by the
    ///             hasADTComponent object property, which has the AbstractDataType class as its domain, and
    ///             the ADTComponent class as its range.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#ADTComponent">drama:ADTComponent</a>
    /// </summary>
    let ADTComponent = _prefixId.prefix "ADTComponent"
    /// <summary>
    ///   <para>rdfs:label : AbstractDataType^^xsd:string</para>
    ///   <para>rdfs:comment : AbstractDataType The data types needed for describing drama are sets, lists
    ///             and trees (more precisely, tree nodes).^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#AbstractDataType">drama:AbstractDataType</a>
    /// </summary>
    let AbstractDataType = _prefixId.prefix "AbstractDataType"
    /// <summary>
    ///   <para>rdfs:label : AbstractPlan^^xsd:string</para>
    ///   <para>rdfs:comment : Abstract Plan An abstract plan is a recursive plan, i.e., a plan whose
    ///             elements are plans. Formally, an AbstractPlan is a list (List class) containing
    ///             (containsOLE) elements (OrderedListElements) that have plans as their data (hasData).
    ///             The plans contained in an abstract plan can be either abstract plans or directly
    ///             executable plans.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#AbstractPlan">drama:AbstractPlan</a>
    /// </summary>
    let AbstractPlan = _prefixId.prefix "AbstractPlan"
    /// <summary>
    ///   <para>rdfs:label : Action^^xsd:string</para>
    ///   <para>rdfs:comment : An Action is an intentional Process, which is a type of Process. Formally, an
    ///             action is an Process which is constrained to be contained (isMemberOf) some Unit. In
    ///             Drammar, an Action can be part of a plan of an agent (formally, a plan ia a list of
    ///             actions), or can be included in a Unit (ordered into some timeline). Only direct
    ///             executable plans (DirectlyExecutablePlan class) contain actions The Action class is
    ///             formally disjoint with the UnintentionalEventiveProcess class. We have introduced an
    ///             explicit boolean datatype property isIntentional, because it could be that the
    ///             annotators will use actions directly in the units (i.e. without explicitly introducing a
    ///             plan for it).^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#Action">drama:Action</a>
    /// </summary>
    let Action = _prefixId.prefix "Action"
    /// <summary>
    ///   <para>rdfs:label : Agent^^xsd:string</para>
    ///   <para>rdfs:comment : Agent. Derived from BDI model, a mentalist model of agent which sees the agent
    ///             as a rational entity who form intentions, or plans, (based on her beliefs) to achieve
    ///             her desires (or goals). See Bratman et al. 1988 and Cohen and Levesque 1995. Agents are
    ///             those entities in drama, that potentially - have goals (object property hasGoal); -
    ///             intend plans to achieve goals (object property intends); - participate in actions with
    ///             some role (object property isFillerOf); In addition, agents have emotional states (as a
    ///             result of targeted emotions appraisal processes) and have moral values (hasValue): -
    ///             feel emotions as a result of a cognitive appraisal process (specific object properties
    ///             link each the appraisal of each emotion type to the agent); - have values (object
    ///             property hasValue); The requirement, in drama, is that an agent has a plan, since the
    ///             fact of having a goal would not be sufficient to ensure that the goal is translated into
    ///             some concrete, perceivable behavior in drama. Having a plan, instead, implies that the
    ///             agent also has goal. Notice that some Agent (e.g. Polonius) is involved in an action
    ///             without being intentional (e.g., being the topic of a conversation), it remains
    ///             classified as an Agent in Drammar, though it fills a different role in the frame (e.g.,
    ///             Topic of Conversation). References: Bratman, M. E., Israel, D. J., &amp; Pollack, M. E.
    ///             (1988). Plans and resourceâbounded practical reasoning. Computational intelligence,
    ///             4(3), 349-355. Cohen, P. R., &amp; Levesque, H. J. (1995, June). Communicative Actions
    ///             for Artificial Agents. In ICMAS (Vol. 95, pp. 65-72).^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#Agent">drama:Agent</a>
    /// </summary>
    let Agent = _prefixId.prefix "Agent"
    /// <summary>
    ///   <para>rdfs:label : Belief^^xsd:string</para>
    ///   <para>rdfs:comment : A belief is what an agent believes (which may be true or not in the world) In
    ///             the BDI model, beliefs form the agent's knowledge about the world that the agent
    ///             relies on for devising plans to achieve her goals. In Drammar there is no distinction
    ///             between knowing and believing, because reasoning concerns the agent motivations for
    ///             acting, rather than the relationship between single agent knowledge and shared
    ///             knowledge. A belief is formally defined as the type of MentalState described by a
    ///             BeliefSchema. In the annotation, it is in the scope a ConsistenStateSet, that is
    ///             precondition or effect of a Plan. SWRL rules for mapping project a belief onto some
    ///             ConsistentStateSet which precedes or follows a timeline.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#Belief">drama:Belief</a>
    /// </summary>
    let Belief = _prefixId.prefix "Belief"
    /// <summary>
    ///   <para>rdfs:label : BeliefSchema^^xsd:string</para>
    ///   <para>rdfs:comment : The BeliefSchema class describes a Belief (a type of MentalState). This class
    ///             is formally defined as the subclass of MentalStateSchema having as its quale_schemaType
    ///             value the string "belief". A BeliefSchema has as its propositional content
    ///             (via the propositionalContent object property) a factual process (FactualProcess class)
    ///             or state (FactualState class).^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#BeliefSchema">drama:BeliefSchema</a>
    /// </summary>
    let BeliefSchema = _prefixId.prefix "BeliefSchema"
    /// <summary>
    ///   <para>rdfs:label : ConflictSet^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the relation of conflict distributed over a set of
    ///             plans. It represents the orchestration of conflicts in drama. Although conflict may
    ///             occur, in drama, between (or within) entities of different types (characters may be in
    ///             conflict with each other, ir the same character may experience conflicting emotions),
    ///             here we reduce the notion of conflict to this single class.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#ConflictSet">drama:ConflictSet</a>
    /// </summary>
    let ConflictSet = _prefixId.prefix "ConflictSet"
    /// <summary>
    ///   <para>rdfs:label : ConsistentStateSet^^xsd:string</para>
    ///   <para>rdfs:comment : A ConsistentStateSet is a set of states held consistent by definition. It can
    ///             be a set of states bordering a timeline (i.e., the state of affairs holding before and
    ///             after the timeline) or it can be the state of affairs that holds before and after a plan
    ///             (in this case, it represents the plan precondintions and effects). The
    ///             isTimelinePreconditionOf (isTimelineEffectOf) property connects a ConsistentStateSet
    ///             with a Timeline. The isPlanPreconditionOf (isPlanEffectOf) property connects a
    ///             ConsistentStateSet with a Plan. A ConsistentStateSet has one or more states as its
    ///             members (hasMember property)^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#ConsistentStateSet">drama:ConsistentStateSet</a>
    /// </summary>
    let ConsistentStateSet = _prefixId.prefix "ConsistentStateSet"
    /// <summary>
    ///   <para>rdfs:label : DataStructure^^xsd:string</para>
    ///   <para>rdfs:comment : DataStructure This class encodes the data structures that provide structural
    ///             organization to the other entities. It includes abstract data types (namely sets, lists
    ///             and trees) and data type components.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#DataStructure">drama:DataStructure</a>
    /// </summary>
    let DataStructure = _prefixId.prefix "DataStructure"
    /// <summary>
    ///   <para>rdfs:label : DescriptionTemplate^^xsd:string</para>
    ///   <para>rdfs:comment : DescriptionTemplate This class contains a well known role-based pattern for
    ///             representing the linguistic schemata that describe the elements of drama, such as the
    ///             entities and dynamics. Drammar imports this pattern from other ontologies, namely DOLCE.
    ///             The class DescriptionTemplate contains two classes: - Role - SituationSchema The class
    ///             SituationSchema provides the specific pattern for the description of incidents and
    ///             states, generically termed here as "situations". A situation can be either a
    ///             process or a state, usually described by a linguistic expression consisting of a verb
    ///             ("giving") for processes, such as in the expression "Ophelia gives the
    ///             gift back to Hamlet", or a by a preposition ("behind") for states, such
    ///             as in the expression "Polonius is behind the tapestry"). The Role class
    ///             provides the pattern for the roles that play a part in the state or process (in the
    ///             above example, the role of the "donor" filled by Ophelia, the role of the
    ///             "recipient" filled by Hamlet, etc.). The linguistic counterpart of the
    ///             role-based structure of the description templates is provided by a frame-like accounts
    ///             of the linguistic descriptions of events, such as Framenet or Verbnet
    ///             (https://framenet2.icsi.berkeley.edu/fnReports/data/frameIndex.xml). Based on a lexical
    ///             semantics perspective, these initiatives are aimed at grouping verbs (including
    ///             statives) into "frames of action", i.e., linguistic structures representing a
    ///             group of semantically similar verbs with the complements that accompany them. Following
    ///             a design choice that characterizes the Drammar ontology, all references to the external
    ///             (linguistic or commonsense) knowledge are mediated by the ExternalReference class, a top
    ///             level class whose function is specifically to act as a bridge to the external knowledge
    ///             (see the documentation of the class). So, neither the Roles nor the Situation Schemata
    ///             directly refer to the external linguistic knowledge they assume: rather, the hasExtRef
    ///             property links each component of the pattern onto its corresponding class within the
    ///             ExternalReference class: the SituationSchema class is related to the ExternalRefSchema,
    ///             the Role class is related to the ExternalRefRole class. Each ExternalReference subclass,
    ///             then, bridges each pattern component onto the corresponding component within the
    ///             external knowledge source via a specific data type property.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#DescriptionTemplate">drama:DescriptionTemplate</a>
    /// </summary>
    let DescriptionTemplate = _prefixId.prefix "DescriptionTemplate"
    /// <summary>
    ///   <para>rdfs:label : DirectlyExecutablePlan^^xsd:string</para>
    ///   <para>rdfs:comment : DirectlyExecutablePlans Directly executable plans are plans that contain only
    ///             actions. Formally, a directly executale plan is a list (List class) that contains
    ///             (containsOLE) only elements (OrderedListElement) that have actions as their data
    ///             (hasData).^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#DirectlyExecutablePlan">drama:DirectlyExecutablePlan</a>
    /// </summary>
    let DirectlyExecutablePlan = _prefixId.prefix "DirectlyExecutablePlan"
    /// <summary>
    ///   <para>rdfs:label : DramaEndurant^^xsd:string</para>
    ///   <para>rdfs:comment : DramaEndurant is an entity of drama that can be described as an endurant
    ///             following Gangemi et al. 2002. In Gangemi et al. 2002 "Endurants are wholly present
    ///             (i.e., all their proper parts are present) at any time they are present",
    ///             differently from perdurants, which are only partially present at any time they are
    ///             present. Endurants (and Perdurants, in some cases) play a role in processes and states:
    ///             an Endurant is connected to a role (Role class) in the description of a given process or
    ///             state by the hasRole object property. The class of drama endurants encompasses more
    ///             specific drama entities such as Agent and Object. This bipartite distinction is derived
    ///             from the drama literature, where - Agents that intentionally perform actions; - Objects
    ///             are involved in the actions in an unintentional way. For instance, in Hamlet, the King
    ///             of England is a drama endurant (but non an agent) because it is the filler of a role in
    ///             Claudius' actions (sending ... ) but does not intend any plan (a feature would
    ///             locate it in the Agent class). The difference beteween the King of England and a coffee
    ///             machine is entrusted to common sense knowlegde (e.g., the external lexical knowledge
    ///             stating the sementic type of these two entities). Reference: Gangemi, A., Guarino, N.,
    ///             Masolo, C., Oltramari, A., &amp; Schneider, L. (2002). Sweetening ontologies with DOLCE.
    ///             In Knowledge engineering and knowledge management: Ontologies and the semantic Web (pp.
    ///             166-181). Springer Berlin Heidelberg.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#DramaEndurant">drama:DramaEndurant</a>
    /// </summary>
    let DramaEndurant = _prefixId.prefix "DramaEndurant"
    /// <summary>
    ///   <para>rdfs:label : DramaEntity^^xsd:string</para>
    ///   <para>rdfs:comment : DramaEntity Class of all the dramatic entities, that is, of all the entities
    ///             that are peculiar to drama. Its sisters are classes that are not peculiar to drama, but
    ///             concern templates, (DescriptionTemplate), references to external lexical and semantic
    ///             systems (ExternalReference) and data structures (DataStructure) from computer
    ///             science.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#DramaEntity">drama:DramaEntity</a>
    /// </summary>
    let DramaEntity = _prefixId.prefix "DramaEntity"
    /// <summary>
    ///   <para>rdfs:label : DramaPerdurant^^xsd:string</para>
    ///   <para>rdfs:comment : The DramaPerdurant class contains the entities of drama that can described as
    ///             perdurants in DOLCE (Gangemi et al. 2002): "Perdurants [...] just extend in time by
    ///             accumulating different temporal parts, so that, at any time they are present, they are
    ///             only partially present, in the sense that some of their proper temporal parts (e.g.,
    ///             their previous or future phases) may be not present." In other words, perdurants,
    ///             namaly processes, are not entirely present at any time they are present, differently
    ///             from endurants. The DramaEdurant is the class of elements of Drama that describe the
    ///             story dynamics, i.e. Processes and States. In the context of Drammar, the individuals of
    ///             this class describe the story advancement in terms of incidents and states holding
    ///             between incidents. Each has a specific relation to the segmentation of drama: processes
    ///             are grouped in units, states precedes and follows timelines (which contain units).
    ///             Notice that processes and states are not distinct in Framenet, the knowledge source we
    ///             refer to for describing perdurants outside of Drammar. Reference: Gangemi, A., Guarino,
    ///             N., Masolo, C., Oltramari, A., &amp; Schneider, L. (2002). Sweetening ontologies with
    ///             DOLCE. In Knowledge engineering and knowledge management: Ontologies and the semantic
    ///             Web (pp. 166-181). Springer Berlin Heidelberg.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#DramaPerdurant">drama:DramaPerdurant</a>
    /// </summary>
    let DramaPerdurant = _prefixId.prefix "DramaPerdurant"
    /// <summary>
    ///   <para>rdfs:label : DrammarScene^^xsd:string</para>
    ///   <para>rdfs:comment : DrammarScene A DrammarScene is a type of scene that hinges on characters'
    ///             conflicting plans. In Drammar, the conflict over plans is represented by a class, the
    ///             ConflictSet, which contains the set of plans in conflict. The hingesOn object property
    ///             connects the DrammarScene with the Conflict Set.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#DrammarScene">drama:DrammarScene</a>
    /// </summary>
    let DrammarScene = _prefixId.prefix "DrammarScene"
    /// <summary>
    ///   <para>rdfs:label : Emotion^^xsd:string</para>
    ///   <para>rdfs:comment : Emotion is the class of emotions felt by an agent in a scene. Formally, it is
    ///             described as the subclass of MentalState described by an EmotionSchema. The emotions
    ///             refer to OCC emotion ontology (22 emotions types). Emotion type is an external resource
    ///             (ExternalRefEmotionType). An Emotion has an appraising agent (appraisingAgent object
    ///             property) and, when appraised, is an emotion of (isEmotionOf object property) that
    ///             agent. An emotion also has a target (the agent or object that is the target of the
    ///             emotion): a specifi object property connects each emotion type with its target (e.g.,
    ///             shame_target, love_target, etc.).^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#Emotion">drama:Emotion</a>
    /// </summary>
    let Emotion = _prefixId.prefix "Emotion"
    /// <summary>
    ///   <para>rdfs:label : EmotionSchema^^xsd:string</para>
    ///   <para>rdfs:comment : An EmotionSchema represents the description of an EmotionState, bridged onto
    ///             some external linguistic or semantic system through the mediation of the
    ///             ExternalRefEmotionType class. The EmotionSchema is a MentalStateSchema for describing an
    ///             Emotion. Formally, it is constrained to the value "emotion" for the
    ///             quale_schemaType data property. The hasExtRef property links the EmotionSchema to the
    ///             ExternalRefEmotionType class which in turn links the description of the Emotion to a
    ///             reference theory of emotions.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#EmotionSchema">drama:EmotionSchema</a>
    /// </summary>
    let EmotionSchema = _prefixId.prefix "EmotionSchema"
    /// <summary>
    ///   <para>rdfs:label : ExternalRefEmotionType^^xsd:string</para>
    ///   <para>rdfs:comment : This class includes individuals for all the 22 emotion types referred by OCC
    ///             theory. The individuals are bridge individuals to some external formal OCC-based
    ///             knowledge source, which does not exist yet but is assumed here. These individuals could
    ///             also be a bridge to some commonsense ontology, such as YagoSumo for Values, but it would
    ///             be different from the adoption of the OCC theory, as committed in
    ///             Drammar.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#ExternalRefEmotionType">drama:ExternalRefEmotionType</a>
    /// </summary>
    let ExternalRefEmotionType = _prefixId.prefix "ExternalRefEmotionType"
    /// <summary>
    ///   <para>rdfs:label : ExternalRefEntity^^xsd:string</para>
    ///   <para>rdfs:comment : The ExternalRefEntity class has the function of bridging the description of a
    ///             DramaEntity (not an entity in general) to some external linguistic or semantic resource
    ///             such a dictionary or an ontology. An entity can be linked to its ExternalReference by
    ///             the hasExtRef object property, which has the ExternalReference as its range. The
    ///             ExternalRefEntity iherits the "quale" data property from its direct ancestor,
    ///             ExternalReference class.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#ExternalRefEntity">drama:ExternalRefEntity</a>
    /// </summary>
    let ExternalRefEntity = _prefixId.prefix "ExternalRefEntity"
    /// <summary>
    ///   <para>rdfs:label : ExternalRefRole^^xsd:string</para>
    ///   <para>rdfs:comment : The ExternalRefRole class has the function of bridging the description of a
    ///             Role (not an entity in general) to a description of the role in some external linguistic
    ///             that represents the argument structure of an event. An Role can be linked to its
    ///             ExternalRefRole by the hasExtRef object property, which has the ExternalRefRole as its
    ///             range. The ExternalRefRole class has three data properties which connect it to the
    ///             reference system: - role_framenetRoleID: connects the Role to the id of the
    ///             corresponding role in FrameNet - role_verbnetRoleType: connects the Role to the name of
    ///             the corresponding role in VerdNet (a string) - role_ID_resource^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#ExternalRefRole">drama:ExternalRefRole</a>
    /// </summary>
    let ExternalRefRole = _prefixId.prefix "ExternalRefRole"
    /// <summary>
    ///   <para>rdfs:label : ExternalRefSchema^^xsd:string</para>
    ///   <para>rdfs:comment : The ExternalRefSchema class has the function of bridging the description of a
    ///             SituationSchema to some external lexical-semantic resource representing apt to represent
    ///             the role structure of a process or state. An SituationSchema (or, better, a subclass of
    ///             it) can be linked to its ExternalRefSchema by the hasExtRef object property, which has
    ///             the ExternalReference as its range. The quale_frame_URI data property connects the
    ///             SituationSchema with the FrameNet frame which correponds to it, following the paradigm
    ///             of Linked Data.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#ExternalRefSchema">drama:ExternalRefSchema</a>
    /// </summary>
    let ExternalRefSchema = _prefixId.prefix "ExternalRefSchema"
    /// <summary>
    ///   <para>rdfs:label : ExternalReference^^xsd:string</para>
    ///   <para>rdfs:comment : ExternalReference This is a class that provides the service of accumulating
    ///             all the "quale" datatype properties that refer to external linguistic or
    ///             commonsense knowledge sources. Through this class, the description of the drama entities
    ///             is bridged onto some external lexicon or ontology. Its subclasses are useful in
    ///             grouping, but do not represent specific issues in support.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#ExternalReference">drama:ExternalReference</a>
    /// </summary>
    let ExternalReference = _prefixId.prefix "ExternalReference"
    /// <summary>
    ///   <para>rdfs:label : FrameNetSchema^^xsd:string</para>
    ///   <para>rdfs:comment : A FrameNetSchema corresponds to a process or state describable by a frame in
    ///             Framenet (https://framenet2.icsi.berkeley.edu/fnReports/data/frameIndex.xml). The
    ///             reference of the schema to the external linguistic reality (the FrameNet frame) is
    ///             mediated through an apposite class subsumed by the ExternalReference class, the
    ///             ExternalRefSchema class: the SituationSchema class (and, by inheritance, also the
    ///             FrameNetSchema class) is linked to the ExternalRefSchema class via the hasExtRef
    ///             property. The quale_frame_URI, then, bridges the ExternalRefSchema class onto the URI of
    ///             the appropriate frame.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#FrameNetSchema">drama:FrameNetSchema</a>
    /// </summary>
    let FrameNetSchema = _prefixId.prefix "FrameNetSchema"
    /// <summary>
    ///   <para>rdfs:label : Goal^^xsd:string</para>
    ///   <para>rdfs:comment : The Goal class represents the objectives of an agent. In the BDI model, the
    ///             agent is driven by her desires, or goal, and forms plans to achieve them. In Drammar, a
    ///             goal is achieved by a plan; the achives object property connects a plan with the goal it
    ///             achieves (a single goal, since the achieves property is functional). An agent intends
    ///             (intends object property) a goal. Formally, the Goal class is a defined as a subclass of
    ///             the MentalState class which is constrained: - to be the goal of some agent - to be part
    ///             of some ConsistentStateState - to be described by a GoalSchema Goal has a propositional
    ///             content that is - a process in the case of perform goal PG (Hamlet wants to ask Ophelia
    ///             ...) - a state in the case of - achievement (Hamlet wants Ophelia goes to a nunnery) -
    ///             maintenance (Hamlet wants Claudius (keeps) believing Hamlet is mad) - query (Hamlet
    ///             wants to know whether Ophelia is honest) In these various cases the propositional
    ///             content is different: - Perform Goal - PC: Action - AG - PC: State, embedded in one
    ///             Belief, with status false or Process, embedded in Belief, with accomplishment false - MG
    ///             - PC: State or Process, embedded in Belief, with status/accomplishment true - Query Goal
    ///             - PC: depends on query; e.g.: - Y/N question: the boolean status of a state (currently
    ///             implemented as a State with status TRUE) - Wh question: the filler of a role in some
    ///             state or process (currently not implemented) These are guidelines for writing the plans
    ///             correctly.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#Goal">drama:Goal</a>
    /// </summary>
    let Goal = _prefixId.prefix "Goal"
    /// <summary>
    ///   <para>rdfs:label : GoalSchema^^xsd:string</para>
    ///   <para>rdfs:comment : The GoalSchema class describes a Goal (a type of MentalState). This class is
    ///             formally defined as the subclass of MentalStateSchema having as its quale_schemaType
    ///             value the string "goal". A GoalSchema has as its propositional content (via
    ///             the propositionalContent object property) a factual process (FactualProcess class) or
    ///             state (FactualState class).^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#GoalSchema">drama:GoalSchema</a>
    /// </summary>
    let GoalSchema = _prefixId.prefix "GoalSchema"
    /// <summary>
    ///   <para>rdfs:label : Goal_type^^xsd:string</para>
    ///   <para>rdfs:comment : Type of the goal: one of the strings "Achievement"
    ///             "Maintainance" "Perform" "Query"^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#Goal_type">drama:Goal_type</a>
    /// </summary>
    let Goal_type = _prefixId.prefix "Goal_type"
    /// <summary>
    ///   <para>rdfs:label : List^^xsd:string</para>
    ///   <para>rdfs:comment : List List is inspired by a well known ontology
    ///             (http://smiy.sourceforge.net/olo/spec/orderedlistontology.html#ordered_list); however,
    ///             its implementation in Drammar makes some simplifications (e.g., indexes are not
    ///             included) and renames some entities according to the terminology of the drama domain.
    ///             List in drama: - Plan: sequence of plans (abstract plans) or single actions (directly
    ///             executable plans); - Timeline: sequence of units.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#List">drama:List</a>
    /// </summary>
    let List = _prefixId.prefix "List"
    /// <summary>
    ///   <para>rdfs:label : MentalState^^xsd:string</para>
    ///   <para>rdfs:comment : MentalStates are EventiveStates that are attributed to the mind of an agent.
    ///             There are four types of mental states: 1. Emotion 2. Belief 3. Goal 4. Value Belief and
    ///             Goal are traditionally described as having a propositional content because they both
    ///             concern some attitude of the agent toward a proposition; in Drammar, we don't
    ///             enforce this distinction because the reference theoriesd we adopt for emotion and values
    ///             also enforce some time of propositional content. The only difference is that only the
    ///             schema types for beliefs and goals (BeliefSchema and GoalSchema) have a propositional
    ///             content attached to it (through the propositionalContent object property). A MentalState
    ///             is defined as an EventiveState that is described by a MentalStateSchema. The latter are
    ///             to be specified as EmotionSchema, BeliefSchema, GoalSchema, ValueSchema,
    ///             depending on the MentalState type: so, the MentalStateSchema type works as a selector
    ///             for the right trait of the mental schema.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#MentalState">drama:MentalState</a>
    /// </summary>
    let MentalState = _prefixId.prefix "MentalState"
    /// <summary>
    ///   <para>rdfs:label : MentalStateSchema^^xsd:string</para>
    ///   <para>rdfs:comment : The MentalStateSchema class collects all the schemata that license the
    ///             behavior of the mental states. Following the guidelines for describing mental states in
    ///             Ferrario, R., &amp; Oltramari, A. (2005, March). Towards a computational ontology of
    ///             mind. In Aerospace Conference, 2005 IEEE (pp. 1-9). IEEE, propositional attitudes such
    ///             as beliefs and goals are considered mental states in Drammar. The MentalState class
    ///             includes: - BeliefSchema - EmotionSchema - GoalSchema - ValueSchema The schemata
    ///             match the mental states included in Drammar. Mental states are grouped in the
    ///             DramaPerdurant class as eventive mental states (MentalState class) or as factual mental
    ///             states (F_MentalState class).^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#MentalStateSchema">drama:MentalStateSchema</a>
    /// </summary>
    let MentalStateSchema = _prefixId.prefix "MentalStateSchema"
    /// <summary>
    ///   <para>rdfs:label : Object^^xsd:string</para>
    ///   <para>rdfs:comment : Object Class of entities (endurant) that participates into Perdurants, but
    ///             without having intentions. An object is formally defined as a subclass of DramaEndurant
    ///             whose member do not have plans. Objects can be filler of roles in the description of
    ///             processes and states (for example, a book can be "theme" in a giving action
    ///             (i.e. the entity that changes ownership as a consequence of a giving act). This class is
    ///             formally disjoint from Agents (Disjoint property).^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#Object">drama:Object</a>
    /// </summary>
    let Object = _prefixId.prefix "Object"
    /// <summary>
    ///   <para>rdfs:label : OrderedListElement^^xsd:string</para>
    ///   <para>rdfs:comment : Class of the elements of the ordered lists (lists are plans and timelines).
    ///             Sometimes referred to as OLE. The hasOrderedListElement object property has the List
    ///             class as its domain and the OrderedListElement as its range. Notice that this class
    ///             works as a placeholder that represents the single item in a list (it is not the list
    ///             content itself): the property hasData links the OrderedListElement with the actual data,
    ///             i.e. the content of the item. For example, the OrderedListElements Plans have other
    ///             plans or actions as their data.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#OrderedListElement">drama:OrderedListElement</a>
    /// </summary>
    let OrderedListElement = _prefixId.prefix "OrderedListElement"
    /// <summary>
    ///   <para>rdfs:label : Plan^^xsd:string</para>
    ///   <para>rdfs:comment : Plan A plan is a sequence of actions devised by an agent to achieve some Goal.
    ///             In the BDI model, the agent's 'intention' to execute a plan is the bridge
    ///             between goals and practical actions. In Drammar, a plan is intended by (intendedBy
    ///             object property) an Agent to achieve (achieve property) some Goal. As a consequence, the
    ///             plan motivates (isMotivationFor object property) a timeline (i.e. a given extent of the
    ///             drama text). These are the necessary and sufficient conditions of class. Following the
    ///             paradigm of hierarchical planning, plans are recursive. So plans can contains actions or
    ///             other, simpler plans. Formally, a Plan is a list (namely, it is a subclass of the List
    ///             class) whose elements are simpler plans (for abstract plans) or actions (for directly
    ///             executable plans). A plan is related to its elements by the containsOLE
    ///             property.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#Plan">drama:Plan</a>
    /// </summary>
    let Plan = _prefixId.prefix "Plan"
    /// <summary>
    ///   <para>rdfs:label : Process^^xsd:string</para>
    ///   <para>rdfs:comment : Processes represents the dynamic class of the perdurants: they are gathered
    ///             into units, which are contained into ordered timelines bordered by states. Process is
    ///             the class that bridges to the concept of Process in upper ontologies, externally to
    ///             Drammar (like DOLCE, where States and Processes are types of Statives: here, we include
    ///             also the event types called accomplishments and achievements in DOLCE). Consider that
    ///             such resources are not of linguistic type. The DescriptionTemplate class (or, better,
    ///             its subclass FrameNetSchema), in fact, drives the behavior of the process inside a Plan
    ///             or a Unit, linking it (via the ExternalReference Class) to: 1. a Wordnet sense 2. a
    ///             Frame (from Framenet or Verbnet) 3. a set of Roles, played by roles encompassed in the
    ///             frame All these links are bridged by the ExternalReference Class, which has
    ///             "quale" properties that link the reference to specific resources. In the
    ///             external ontology, a process may be logically defined through the use of axioms: for
    ///             example, in the action of asking, it is assumed that Speaker and Addressee are connected
    ///             through some communication medium, e.g. co-presence in a room or a telephone. In
    ///             Drammar, the DramaStructures that contain the Processes are Units (subclasses of
    ///             DramaSets) and Plans (subclasses of DramaLists). They are then subdivided through a
    ///             further trait, that is whether the process is intentional (of an agent) or not (Action
    ///             or UnintentionalProcess). This trait is defined through a specific Datatype property, of
    ///             boolean type, called isIntentional. So, its subclasses are: - Action: with isIntentional
    ///             property valued TRUE; - UnintentionalProcess: with isIntentional property valued FALSE.
    ///             Same happens in parallel to the States, although in that case the trait concerns the
    ///             state schema.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#Process">drama:Process</a>
    /// </summary>
    let Process = _prefixId.prefix "Process"
    /// <summary>
    ///   <para>rdfs:label : Role^^xsd:string</para>
    ///   <para>rdfs:comment : Role provides the pattern for the role fillers in a frame instantiation, that
    ///             occurs in SituationSchema, for describing processes and states. A Role is filled by a
    ///             DramaEntity: the fact that a given role has an entity as a filler is represented by the
    ///             hasFiller property and its inverse isFillerOf property. A Role belongs (isRoleOf) to a
    ///             given SituationSchema, namely a ProcessSchema or a StateSchema (hasRole property). The
    ///             Role class is related to its filler by the hasFiller property, whose range is the
    ///             DramaEntity class. For example, given the incident describable as "Ophelia gives
    ///             the gift back to Hamlet", the roles of "donor" (the one who does the
    ///             action of giving), "recipient" (the one wjho receives the object to be given)
    ///             and "theme" (the object of giving action) are all instance of the Role class
    ///             connected to the same Situation, each labeled with a linguistic label
    ///             ("donor", "recipient", etc.) and each connected to its filler via
    ///             the hasFiller property. Roles can also be intended as thematic roles of verbs following
    ///             the description contained in the Verbnet resource
    ///             (http://verbs.colorado.edu/verb-index/index.php). The Role class, via the hasExtRef
    ///             object property, is linked to the subclass of the top level ExternalReference class, the
    ///             ExternalRefRole class, whose function is to connect the description of the role with the
    ///             appropriate role name or URI in a linguistic account of roles through apposite data
    ///             properties (namely, the Role_framenetRoleID and Role_verbnetRoleType data properties
    ///             respectively for FrameNet and VerbNet).^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#Role">drama:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"
    /// <summary>
    ///   <para>rdfs:label : Scene^^xsd:string</para>
    ///   <para>rdfs:comment : Scene Drama is divided into scenes, which correspond to an extent of the
    ///             'text' of drama. Scenes (as a type of TreeNode) form a hierarchy, which
    ///             represents the recursive nature of drama. This is obtained by implementing the Scene
    ///             class as a subclass of the TreeNode class. Scenes contains children scenes: this
    ///             relation is modeled through the hasChild property. All scenes span some timeline (spans
    ///             object property), i.e., they have a correspondance with some extent of the drama text
    ///             (represented by the Timeline class).^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#Scene">drama:Scene</a>
    /// </summary>
    let Scene = _prefixId.prefix "Scene"
    /// <summary>
    ///   <para>rdfs:label : Schema_type^^xsd:string</para>
    ///   <para>rdfs:comment : This datatype property represents the type of schema for some construct. Its
    ///             value correspond to the different types of state acknowledged in Drammar : beliefs,
    ///             goals, etc. Each value correspond to a state type: e.g., "belief" for the
    ///             Belief class. In particular, framenet is the magic word for the schemata extracted from
    ///             Framenet.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#Schema_type">drama:Schema_type</a>
    /// </summary>
    let Schema_type = _prefixId.prefix "Schema_type"
    /// <summary>
    ///   <para>rdfs:label : Set^^xsd:string</para>
    ///   <para>rdfs:comment : Set The class of set structures. The relation between sets and set members is
    ///             represented by the hasMember object property. It includes specific subclasses, with each
    ///             subclass characterized by a specific type of members. Sets include: - ConflictsSets:
    ///             sets of conflicting plans; - ConsistentStateSets: sets of consistent states (left and
    ///             right boundaries of timelines and plans). - Units: sets of actions.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#Set">drama:Set</a>
    /// </summary>
    let Set = _prefixId.prefix "Set"
    /// <summary>
    ///   <para>rdfs:label : SetMember^^xsd:string</para>
    ///   <para>rdfs:comment : Class of the elements
    ///             of the sets (sets are conflict sets, consistent state sets, and units). Sometimes
    ///             referred to as SM. The hasMember object property has the Set class as its domain and the
    ///             SetMember as its range. Notice that this class works as a placeholder that represents
    ///             the single element in a set (it is not the content itself): the property hasData links
    ///             the SetMember with the actual data, i.e. the content of the item. For example, the
    ///             specific Set that is a Unit hasMember some SetMember that hasData some
    ///             Action.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#SetMember">drama:SetMember</a>
    /// </summary>
    let SetMember = _prefixId.prefix "SetMember"
    /// <summary>
    ///   <para>rdfs:label : SituationSchema^^xsd:string</para>
    ///   <para>rdfs:comment : The situation schema provides the pattern for the description of incidents and states. It is inspired by the Situation ontology Pattern of the Ontology Design Pattern initiative (http://ontologydesignpatterns.org/). So, a SituationSchema describes ("describes" object property) a DramaPerdurant (either a State or a Process).
    /// The schema works as a hub for the roles involved in a situation. The property hasRole links the Situation class (its domain) with the Role class (the range of the property). Also, notice that, as illustrated in the documentation of the SituationSchema class, a Situation Schema (or, better, its subclasses) does not directly refer to the external linguistic knowledge employed to describe drama: rather, it refers to the ExternalRefSchema class (subclass of the top level ExternalReference class), which in  turn refers to the linguistic knowledge. The SituationSchema class specializes into specific schemata for describing specific type of situations:
    /// - FrameNetSchema: for describing processes, like giving or killing (in Drammar, they are grouped into units arranged on timelines), and states, like being behind some object or being dead (in Drammar, they are bundled into sets that border timelines and plans).
    /// - MentalStateSchema: this class groups the specific types of schemata for describing the mental states of the agents in Drammar, namely beliefs, goals, emotions and values.
    /// Technically, the subtypes of SituationSchema are characterized by different values of the quale_schemaType data property: "belief", "emotion", "framenet", "goal",  "value".
    /// Finally, it is worth mentioning that is a specific design choice of Drammar not to represent the nesting of states: only the type of the top level state, e.g., a belief, is represented, independent of what that belief contains in turn. This flat style of representation is determined by the decision not to commit to a specific logical account of state types. When Drammar is employed for annotation, the content nested into a state is described informally in natural language description accompanying the state, if needed.
    /// Refs: Gangemi, A., &amp; Presutti, V. (2009). Ontology design patterns. In Handbook on ontologies (pp. 221-243). Springer Berlin, Heidelberg.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#SituationSchema">drama:SituationSchema</a>
    /// </summary>
    let SituationSchema = _prefixId.prefix "SituationSchema"
    /// <summary>
    ///   <para>rdfs:label : State^^xsd:string</para>
    ///   <para>rdfs:comment : State represents the static class of the Perdurant. State is the class that
    ///             bridges to the concept of State in upper ontologies, externally to Drammar. For example,
    ///             in DOLCE, states and process are the two distinct types of statives. Both factual and
    ///             eventive states are further divided into different state types: - MentalStates, namely
    ///             Belief, Goals, Values and Emotions (all sharing some propositional content in their
    ///             description); - StateOfAffairs, namely situations holding in the world. States participate
    ///             to some structure. In Drammar, these structures are ConsistenStateSets (types of Sets),
    ///             which borders timelines and plans. The specific type pf States are defined through the
    ///             use of specific types of StateSchema (subclass of DescriptionTemplate). So, its
    ///             subclasses are: - MentalState: the mental state of an agent; - StateOfAffairs: an
    ///             objective state of the story world.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#State">drama:State</a>
    /// </summary>
    let State = _prefixId.prefix "State"
    /// <summary>
    ///   <para>rdfs:label : StateOfAffairs^^xsd:string</para>
    ///   <para>rdfs:comment : StateofAffairs are states that concern the storyworld as a whole; they are
    ///             described by a FrameNetSchema, namely a SituationSchema that points (through the
    ///             ExternalRefSchema class) points to a specific frame. This class gathers all states that
    ///             are external to the characters' mental states, and can be linguistically described
    ///             through some external resources such as FrameNet.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#StateOfAffairs">drama:StateOfAffairs</a>
    /// </summary>
    let StateOfAffairs = _prefixId.prefix "StateOfAffairs"
    /// <summary>
    ///   <para>rdfs:label : Timeline^^xsd:string</para>
    ///   <para>rdfs:comment : Timeline Timeline is a subclass of List whose function is to impose some
    ///             ordering on the units in a drama. Notice that the notion of timeline cannot be collapsed
    ///             onto the actual text: rather, it is simply an indexing posed upon units (which
    ///             correspond to a manifestation of drama in FRBR sense). In formal terms, the orders
    ///             object property has Timeline as its domain and units as its range, so a unit
    ///             "orders" some units. A Timeline contains unit. Formally, the elements
    ///             (OrderedListElements class) contained in a timeline (containsOLE property) are units. A
    ///             Timeline is surrounded by states of affairs that hold before and after it, namely
    ///             instances of the ConsistentSateSets class that precede and follow a given timeline.
    ///             Formally, the Timeline class is the domain of the hasTimelineEffect(Precondition)
    ///             properties, which have the ConsistentStateSet class as their range. A timeline is
    ///             motivated by some plan (motivates object property) and is spanned by some unit (span
    ///             object property). The relation between units and timelines is independent of the
    ///             scene/timeline relation.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#Timeline">drama:Timeline</a>
    /// </summary>
    let Timeline = _prefixId.prefix "Timeline"
    /// <summary>
    ///   <para>rdfs:label : Tree^^xsd:string</para>
    ///   <para>rdfs:comment : Tree The class of tree
    ///             structures. The relation between trees and tree nodes is represented by the containsTN
    ///             abd hasRoot object properties. A drama is actually a tree, composed recursively of
    ///             subtrees, which are scenes at different levels. The subtree relationship is established
    ///             between scenes (property hasChild), which are actually tree nodes.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#Tree">drama:Tree</a>
    /// </summary>
    let Tree = _prefixId.prefix "Tree"
    /// <summary>
    ///   <para>rdfs:label : TreeNode^^xsd:string</para>
    ///   <para>rdfs:comment : TreeNode The TreeNode class represents tree-like structures in drama, namely
    ///             Scenes. This class only represents the recursive structure of drama without an explicit
    ///             commitment to the notion of 'drama as a tree'.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#TreeNode">drama:TreeNode</a>
    /// </summary>
    let TreeNode = _prefixId.prefix "TreeNode"
    /// <summary>
    ///   <para>rdfs:label : UnderspecifiedPlan^^xsd:string</para>
    ///   <para>rdfs:comment : An UnderspecifiedPlan is a plan that is part of a larger plan to achieve some
    ///             goal, but has not been executed. In drama, it represents the unobservable part of a plan
    ///             that has not been fully carried out by some agent. Its existence (in the agent's
    ///             mind) can only be conjectured - remember that a Plan is intended by some agent by
    ///             definition. As the object of a conjecture, it does not contain any details in the
    ///             representation of drama (this does not mean that it does not contain them in the
    ///             agent's mind). As such, an UnderspecifiedPlan: - does *not* motivate a timeline (it
    ///             has not taken place); - does *not* achieve a goal (the actions/subplans composing it and
    ///             its specific goal are not known); - does *not* contain any actions. These conditions,
    ///             part of its definition as an Equivalent Class, distinguish it from Abstract and Directly
    ///             Executable Plans.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#UnderspecifiedPlan">drama:UnderspecifiedPlan</a>
    /// </summary>
    let UnderspecifiedPlan = _prefixId.prefix "UnderspecifiedPlan"
    /// <summary>
    ///   <para>rdfs:label : UnintentionalProcess^^xsd:string</para>
    ///   <para>rdfs:comment : UnintentionalProcess is an unintentional Process. So, an UnintentionalProcess
    ///             is a Process with the property isIntentional that values FALSE.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#UnintentionalProcess">drama:UnintentionalProcess</a>
    /// </summary>
    let UnintentionalProcess = _prefixId.prefix "UnintentionalProcess"
    /// <summary>
    ///   <para>rdfs:label : Unit^^xsd:string</para>
    ///   <para>rdfs:comment : Unit Units are the segmentation of drama. A drama can have multiple
    ///             segmentations. Units are ordered by some Timeline. Units are devoted to the
    ///             representation of characters' actions. So, we require that any unit contains at
    ///             least one action whose description (ProcessSchema) encompasses at least one role having
    ///             an agent as a filler. If a building collapses, this action, by itself, can be part of
    ///             Unit only if an agent is involved in it (e.g., an agent dies). This definition
    ///             guarantees that, in the minimal case, at least one agent appears as filler of the roles
    ///             in the description of at least an action of every unit. A Unit has one or more actions
    ///             as its members (hasMember property).^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#Unit">drama:Unit</a>
    /// </summary>
    let Unit = _prefixId.prefix "Unit"
    /// <summary>
    ///   <para>rdfs:label : Value^^xsd:string</para>
    ///   <para>rdfs:comment : The Value Class represents the values of an agent. These values are
    ///             engaged in drama by the execution of the agents' plans. Formally, a Value is
    ///             a subclass of the MentalState class which is constrained to: - be in a given state, true
    ///             or false, of the boolean property atStake - be in a ConsistentStateSet (namely, the
    ///             consequences of some plan that puts the value at stake or brings it back to balance) -
    ///             be described by a ValueSchema. For example, in the nunnery scene, Ophelia's
    ///             answer "At home, my Lord", being a lie, results in a state that puts at stake
    ///             Hamlet's value of honesty.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#Value">drama:Value</a>
    /// </summary>
    let Value = _prefixId.prefix "Value"
    /// <summary>
    ///   <para>rdfs:label : ValueSchema^^xsd:string</para>
    ///   <para>rdfs:comment : The ValueSchema class describes an agent's Value. Formally,
    ///             it is a subclass of MentalStateSchema whose property quale_schemaType is constrained to
    ///             the string "value".^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#ValueSchema">drama:ValueSchema</a>
    /// </summary>
    let ValueSchema = _prefixId.prefix "ValueSchema"
    /// <summary>
    ///   <para>rdfs:label : accomplished^^xsd:string</para>
    ///   <para>rdfs:comment : Accomplished = true stands for entirely executed and goal achieved
    ///             Accomplished = false stands for entirely executed and goal not achieved When missing,
    ///             nothing is said about execution.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#accomplished">drama:accomplished</a>
    /// </summary>
    let accomplished = _prefixId.prefix "accomplished"
    /// <summary>
    ///   <para>rdfs:label : achieves^^xsd:string</para>
    ///   <para>rdfs:comment : achieves links a Plan to the Goal it aims at achieving^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#achieves">drama:achieves</a>
    /// </summary>
    let achieves = _prefixId.prefix "achieves"
    /// <summary>
    ///   <para>rdfs:label : appraisingAgent^^xsd:string</para>
    ///   <para>rdfs:comment : The appraisingAgent property connects an Emotion with the Agent who appraises
    ///             it. It encompasses specific subproperties for the specific emotion types (in OCC theory,
    ///             there are 22 emotion types such as Love or Shame)^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#appraisingAgent">drama:appraisingAgent</a>
    /// </summary>
    let appraisingAgent = _prefixId.prefix "appraisingAgent"
    /// <summary>
    ///   <para>rdfs:label : atStake^^xsd:string</para>
    ///   <para>rdfs:comment : Boolean property of a Value: - true, if the value is at stake; - false,
    ///             if the value is balanced.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#atStake">drama:atStake</a>
    /// </summary>
    let atStake = _prefixId.prefix "atStake"
    /// <summary>
    ///   <para>rdfs:label : coOccurInScene^^xsd:string</para>
    ///   <para>rdfs:comment : coOccurInScene can be used to describe the fact that two Plans co-occur in the
    ///             same Scene.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#coOccurInScene">drama:coOccurInScene</a>
    /// </summary>
    let coOccurInScene = _prefixId.prefix "coOccurInScene"
    /// <summary>
    ///   <para>rdfs:label : containsFirstOLE^^xsd:string</para>
    ///   <para>rdfs:comment : First OLE of a
    ///             List.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#containsFirstOLE">drama:containsFirstOLE</a>
    /// </summary>
    let containsFirstOLE = _prefixId.prefix "containsFirstOLE"
    /// <summary>
    ///   <para>rdfs:label : containsLastOLE^^xsd:string</para>
    ///   <para>rdfs:comment : Last OLE of a
    ///             List.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#containsLastOLE">drama:containsLastOLE</a>
    /// </summary>
    let containsLastOLE = _prefixId.prefix "containsLastOLE"
    /// <summary>
    ///   <para>rdfs:label : containsOLE^^xsd:string</para>
    ///   <para>rdfs:comment : Inverse of isOLElementOf. Connects the ordered list to its elements.
    ///         ^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#containsOLE">drama:containsOLE</a>
    /// </summary>
    let containsOLE = _prefixId.prefix "containsOLE"
    /// <summary>
    ///   <para>rdfs:label : containsTN^^xsd:string</para>
    ///   <para>rdfs:comment : Connects the tree to
    ///             its (tree) nodes. E.g., the drama is a tree and the scenes are its tree
    ///             nodes.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#containsTN">drama:containsTN</a>
    /// </summary>
    let containsTN = _prefixId.prefix "containsTN"
    /// <summary>
    ///   <para>rdfs:label : describes^^xsd:string</para>
    ///   <para>rdfs:comment : A SituationSchema describes a DramaPerdurant, i.e. provides a template for
    ///             describing processes and states.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#describes">drama:describes</a>
    /// </summary>
    let describes = _prefixId.prefix "describes"
    /// <summary>
    ///   <para>rdfs:label : feels^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#feels">drama:feels</a>
    /// </summary>
    let feels = _prefixId.prefix "feels"
    /// <summary>
    ///   <para>rdfs:label : follows^^xsd:string</para>
    ///   <para>rdfs:comment : Inverse of precedes. Sequential order in an ordered list.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#follows">drama:follows</a>
    /// </summary>
    let follows = _prefixId.prefix "follows"
    /// <summary>
    ///   <para>rdfs:label : HappyFor_appraisingAgent^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#happyFor_appraisingAgent">drama:happyFor_appraisingAgent</a>
    /// </summary>
    let happyFor_appraisingAgent = _prefixId.prefix "happyFor_appraisingAgent"
    /// <summary>
    ///   <para>rdfs:label : happyFor_target^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#happyFor_target">drama:happyFor_target</a>
    /// </summary>
    let happyFor_target = _prefixId.prefix "happyFor_target"
    /// <summary>
    ///   <para>rdfs:label : hasADTComponent^^xsd:string</para>
    ///   <para>rdfs:comment : A generic property for representing the relation among a given abstract
    ///             structure type and its components.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#hasADTComponent">drama:hasADTComponent</a>
    /// </summary>
    let hasADTComponent = _prefixId.prefix "hasADTComponent"
    /// <summary>
    ///   <para>rdfs:label : hasChild^^xsd:string</para>
    ///   <para>rdfs:comment : the basic relation employed for modelling the computational data structure of
    ///             tree.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#hasChild">drama:hasChild</a>
    /// </summary>
    let hasChild = _prefixId.prefix "hasChild"
    /// <summary>
    ///   <para>rdfs:label : hasData^^xsd:string</para>
    ///   <para>rdfs:comment : Property that connects a structural element (e.g. of the class OLE) with the
    ///             data contained in it. Range is not defined; it is defined for each specific structure
    ///             element. ^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#hasData">drama:hasData</a>
    /// </summary>
    let hasData = _prefixId.prefix "hasData"
    /// <summary>
    ///   <para>rdfs:label : hasDoneState^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#hasDoneState">drama:hasDoneState</a>
    /// </summary>
    let hasDoneState = _prefixId.prefix "hasDoneState"
    /// <summary>
    ///   <para>rdfs:label : hasEmotionType^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#hasEmotionType">drama:hasEmotionType</a>
    /// </summary>
    let hasEmotionType = _prefixId.prefix "hasEmotionType"
    /// <summary>
    ///   <para>rdfs:label : hasExtRef^^xsd:string</para>
    ///   <para>rdfs:comment : Quality of an entity (DramaEndurant) In particular: Object_type This property
    ///             provides a URI, in YAGOSUMO or in Wordnet, or a custom string that defines the class of
    ///             some object. E.g., object individual PinkOctopus in Oktapodi is of Object_type
    ///             "octopus" in Yago. Environment_periodOfYear Epoch of some environment. E.g.
    ///             summer, january, Easter. Can be a URI or forced custom string. This is why Range is
    ///             empty. Environment_location Can be "exterior" or "interior". From a
    ///             fixed menu. Environment_timeOfDay Can be "dawn" "morning"
    ///             "afternoon" "evening" "night". From a fixed menu.
    ///             Environment_type The type of an envrironment. E.g.: forest, kitchen, office, ... . It
    ///             can be custom string or URI. This is why Range is empty. Environment_epoch Epoch of some
    ///             environment. E.g. 20th century, 1710's, 50's. Can be a URI or forced custom
    ///             string. This is why Range is empty. ^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#hasExtRef">drama:hasExtRef</a>
    /// </summary>
    let hasExtRef = _prefixId.prefix "hasExtRef"
    /// <summary>
    ///   <para>rdfs:label : hasFiller^^xsd:string</para>
    ///   <para>rdfs:comment : Filler is the property that connects a Role of a FrameNetSchema with the
    ///             DramaEntity (DramaEndurant or DramaPerdurant) that fills that Role.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#hasFiller">drama:hasFiller</a>
    /// </summary>
    let hasFiller = _prefixId.prefix "hasFiller"
    /// <summary>
    ///   <para>rdfs:label : hasGoal^^xsd:string</para>
    ///   <para>rdfs:comment : The property which connects an agent with her/his goals.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#hasGoal">drama:hasGoal</a>
    /// </summary>
    let hasGoal = _prefixId.prefix "hasGoal"
    /// <summary>
    ///   <para>rdfs:label : hasManifestation^^xsd:string</para>
    ///   <para>rdfs:comment : hasManifestation This property connects a Unit to a manifestation of drama
    ///             according to FRBR model. In the real world, a manifestation is represented by a IRI
    ///             (e.g., the URL of a movie, of the recording of a performance, or of the digital edition
    ///             of a novel).^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#hasManifestation">drama:hasManifestation</a>
    /// </summary>
    let hasManifestation = _prefixId.prefix "hasManifestation"
    /// <summary>
    ///   <para>rdfs:label : hasMember^^xsd:string</para>
    ///   <para>rdfs:comment : The specific property for modelling Sets (as a data structure). Any entity, in
    ///             Drammar, can be a member of a Set.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#hasMember">drama:hasMember</a>
    /// </summary>
    let hasMember = _prefixId.prefix "hasMember"
    /// <summary>
    ///   <para>rdfs:label : hasMentalState^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#hasMentalState">drama:hasMentalState</a>
    /// </summary>
    let hasMentalState = _prefixId.prefix "hasMentalState"
    /// <summary>
    ///   <para>rdfs:label : hasMessage^^xsd:string</para>
    ///   <para>rdfs:comment : Anything can convey a message. Standard cases: Signpost at a city entrance
    ///             "Ciudad de Mexico"; Toothpaste brand name on the object toothpaste:
    ///             "Colgate" A specific utterance in a communication action.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#hasMessage">drama:hasMessage</a>
    /// </summary>
    let hasMessage = _prefixId.prefix "hasMessage"
    /// <summary>
    ///   <para>rdfs:label : hasMotivationIn^^xsd:string</para>
    ///   <para>rdfs:comment : The hasMotivation property represents the relation bewteen a plan and the
    ///             timeline it motivates (namely, where the actions of the plan are actually
    ///             contained).^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#hasMotivationIn">drama:hasMotivationIn</a>
    /// </summary>
    let hasMotivationIn = _prefixId.prefix "hasMotivationIn"
    /// <summary>
    ///   <para>rdfs:label : hasParent^^xsd:string</para>
    ///   <para>rdfs:comment : The parent/child relation for modelling tree structures.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#hasParent">drama:hasParent</a>
    /// </summary>
    let hasParent = _prefixId.prefix "hasParent"
    /// <summary>
    ///   <para>rdfs:label : hasPlanEffect^^xsd:string</para>
    ///   <para>rdfs:comment : Property that connects a plan with the consistent set of states that is the
    ///             effect of a plan (ConsistentStateSet).^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#hasPlanEffect">drama:hasPlanEffect</a>
    /// </summary>
    let hasPlanEffect = _prefixId.prefix "hasPlanEffect"
    /// <summary>
    ///   <para>rdfs:label : hasPlanPrecondition^^xsd:string</para>
    ///   <para>rdfs:comment : Property that connect a plan with the ConsistentStateState which forms its
    ///             precondition.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#hasPlanPrecondition">drama:hasPlanPrecondition</a>
    /// </summary>
    let hasPlanPrecondition = _prefixId.prefix "hasPlanPrecondition"
    /// <summary>
    ///   <para>rdfs:label : hasPropositionalContent^^xsd:string</para>
    ///   <para>rdfs:comment : hasPropositionalContent links a BeliefSchema or a GoalSchema to the its
    ///             content (a factual state or process), that is, the Process or State that is the actual
    ///             content of the belief or the goal.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#hasPropositionalContent">drama:hasPropositionalContent</a>
    /// </summary>
    let hasPropositionalContent = _prefixId.prefix "hasPropositionalContent"
    /// <summary>
    ///   <para>rdfs:label : hasRole^^xsd:string</para>
    ///   <para>rdfs:comment : Connects a SituationSchema ( modelled by a frame-like linguistic structure)
    ///             with each Role of the schema.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#hasRole">drama:hasRole</a>
    /// </summary>
    let hasRole = _prefixId.prefix "hasRole"
    /// <summary>
    ///   <para>rdfs:label : hasRoot^^xsd:string</para>
    ///   <para>rdfs:comment : Connects the Tree with
    ///             the TreeNode that is its Root.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#hasRoot">drama:hasRoot</a>
    /// </summary>
    let hasRoot = _prefixId.prefix "hasRoot"
    /// <summary>
    ///   <para>rdfs:label : hasTimelineEffect^^xsd:string</para>
    ///   <para>rdfs:comment : Property that connect a Timeline with the ConsistentStateState which forms its
    ///             effects.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#hasTimelineEffect">drama:hasTimelineEffect</a>
    /// </summary>
    let hasTimelineEffect = _prefixId.prefix "hasTimelineEffect"
    /// <summary>
    ///   <para>rdfs:label : hasTimelinePrecondition^^xsd:string</para>
    ///   <para>rdfs:comment : Property that connect a Timeline with the ConsistentStateState which forms its
    ///             precondition.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#hasTimelinePrecondition">drama:hasTimelinePrecondition</a>
    /// </summary>
    let hasTimelinePrecondition = _prefixId.prefix "hasTimelinePrecondition"
    /// <summary>
    ///   <para>rdfs:label : hasValueEngaged^^xsd:string</para>
    ///   <para>rdfs:comment : The property hasValue connects an agent to her/his values^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#hasValueEngaged">drama:hasValueEngaged</a>
    /// </summary>
    let hasValueEngaged = _prefixId.prefix "hasValueEngaged"
    /// <summary>
    ///   <para>rdfs:label : hingesOn^^xsd:string</para>
    ///   <para>rdfs:comment : A DrammarScene hinges on some ConflictSet^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#hingesOn">drama:hingesOn</a>
    /// </summary>
    let hingesOn = _prefixId.prefix "hingesOn"
    /// <summary>
    ///   <para>rdfs:label : inConflictWith^^xsd:string</para>
    ///   <para>rdfs:comment : The conflict relation over plans. The ontology is neutral with respect with
    ///             conflicts over other entity types, such a goals: it only assumes that conflicts over
    ///             plans are observable.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#inConflictWith">drama:inConflictWith</a>
    /// </summary>
    let inConflictWith = _prefixId.prefix "inConflictWith"
    /// <summary>
    ///   <para>rdfs:label : inSupportOf^^xsd:string</para>
    ///   <para>rdfs:comment : The support relation over goals (parallel to inConflictWith)^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#inSupportOf">drama:inSupportOf</a>
    /// </summary>
    let inSupportOf = _prefixId.prefix "inSupportOf"
    /// <summary>
    ///   <para>rdfs:label : intends^^xsd:string</para>
    ///   <para>rdfs:comment : Intends has as domain an Agent and as range a Plan.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#intends">drama:intends</a>
    /// </summary>
    let intends = _prefixId.prefix "intends"
    /// <summary>
    ///   <para>rdfs:label : isAchievedBy^^xsd:string</para>
    ///   <para>rdfs:comment : This property connects a goal with the plan that achieves it.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#isAchievedBy">drama:isAchievedBy</a>
    /// </summary>
    let isAchievedBy = _prefixId.prefix "isAchievedBy"
    /// <summary>
    ///   <para>rdfs:label : isDataOf^^xsd:string</para>
    ///   <para>rdfs:comment : isDataOf connects some entity to a data structure component (namely, an
    ///             OrderedListElement) of which it is the content.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#isDataOf">drama:isDataOf</a>
    /// </summary>
    let isDataOf = _prefixId.prefix "isDataOf"
    /// <summary>
    ///   <para>rdfs:label : isDescribedBy^^xsd:string</para>
    ///   <para>rdfs:comment : Inverse of describes, this property connects a Dynamics (Process or State)
    ///             with the SituationSchema that describes it.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#isDescribedBy">drama:isDescribedBy</a>
    /// </summary>
    let isDescribedBy = _prefixId.prefix "isDescribedBy"
    /// <summary>
    ///   <para>rdfs:label : isDoneStateOf^^xsd:string</para>
    ///   <para>rdfs:comment : This is the property that connects a process with a particular state, called a
    ///             done state, that holds whether the process has terminated. ^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#isDoneStateOf">drama:isDoneStateOf</a>
    /// </summary>
    let isDoneStateOf = _prefixId.prefix "isDoneStateOf"
    /// <summary>
    ///   <para>rdfs:label : isEmotionOf^^xsd:string</para>
    ///   <para>rdfs:comment : Connects an emotion with the agent who feels it.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#isEmotionOf">drama:isEmotionOf</a>
    /// </summary>
    let isEmotionOf = _prefixId.prefix "isEmotionOf"
    /// <summary>
    ///   <para>rdfs:label : isExtRefOf^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#isExtRefOf">drama:isExtRefOf</a>
    /// </summary>
    let isExtRefOf = _prefixId.prefix "isExtRefOf"
    /// <summary>
    ///   <para>rdfs:label : isExtRefRoleOfExtRefSchema^^xsd:string</para>
    ///   <para>rdfs:comment : This property chain serves the purpose of connecting a frame role with the
    ///             frame it belongs to, via the following property chain: isExtRefOf o isRoleOf o hasExtRef
    ///             where - isExtRefOf connects ExtRefRole to Role - isRoleOf connects Role to ProcessSchema
    ///             - hasExtRef connects ProcessSchema to ExtRefSchema (remember that the actual reference
    ///             to the frame or frame role in an external resources are dealt with by attaching a
    ///             "quale" data property to the classes that represent the external
    ///             references)^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#isExtRefRoleOfExtRefSchema">drama:isExtRefRoleOfExtRefSchema</a>
    /// </summary>
    let isExtRefRoleOfExtRefSchema = _prefixId.prefix "isExtRefRoleOfExtRefSchema"
    /// <summary>
    ///   <para>rdfs:label : isFillerOf^^xsd:string</para>
    ///   <para>rdfs:comment : Connects some DramaEndurant or Perdurant to a Role in a
    ///             SituationSchema^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#isFillerOf">drama:isFillerOf</a>
    /// </summary>
    let isFillerOf = _prefixId.prefix "isFillerOf"
    /// <summary>
    ///   <para>rdfs:label : isGoalOf^^xsd:string</para>
    ///   <para>rdfs:comment : inverse of hasGoal^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#isGoalOf">drama:isGoalOf</a>
    /// </summary>
    let isGoalOf = _prefixId.prefix "isGoalOf"
    /// <summary>
    ///   <para>rdfs:label : isHingedOnBy^^xsd:string</para>
    ///   <para>rdfs:comment : Inverse of hingesOn.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#isHingedOnBy">drama:isHingedOnBy</a>
    /// </summary>
    let isHingedOnBy = _prefixId.prefix "isHingedOnBy"
    /// <summary>
    ///   <para>rdfs:label : isIntendedBy^^xsd:string</para>
    ///   <para>rdfs:comment : Inverse of intends.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#isIntendedBy">drama:isIntendedBy</a>
    /// </summary>
    let isIntendedBy = _prefixId.prefix "isIntendedBy"
    /// <summary>
    ///   <para>rdfs:label : isIntentional^^xsd:string</para>
    ///   <para>rdfs:comment : Boolean property for Intentionality of processes. Applies to Processes to
    ///             distinguish Action from an UnintentionalProcess.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#isIntentional">drama:isIntentional</a>
    /// </summary>
    let isIntentional = _prefixId.prefix "isIntentional"
    /// <summary>
    ///   <para>rdfs:label : isKnownBy^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#isKnownBy">drama:isKnownBy</a>
    /// </summary>
    let isKnownBy = _prefixId.prefix "isKnownBy"
    /// <summary>
    ///   <para>rdfs:label : isMemberOf^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#isMemberOf">drama:isMemberOf</a>
    /// </summary>
    let isMemberOf = _prefixId.prefix "isMemberOf"
    /// <summary>
    ///   <para>rdfs:label : isMentalStateOf^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#isMentalStateOf">drama:isMentalStateOf</a>
    /// </summary>
    let isMentalStateOf = _prefixId.prefix "isMentalStateOf"
    /// <summary>
    ///   <para>rdfs:label : isMotivationFor^^xsd:string</para>
    ///   <para>rdfs:comment : A plan is the motivation for a timeline, namely for a list of units containing
    ///             actions. This property is functional: so, a plan can motivate only a timeline. Notice
    ///             that this implies that a plan cannot motivate the same timeline motivated by a sub-plan,
    ///             and that a plan cannot motivate the same timeline motivated by a more abstract plan. Of
    ///             course, the fact that this property is functional does not imply that a single timeline
    ///             cannot be motivated by more plans.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#isMotivationFor">drama:isMotivationFor</a>
    /// </summary>
    let isMotivationFor = _prefixId.prefix "isMotivationFor"
    /// <summary>
    ///   <para>rdfs:label : isOleContained^^xsd:string</para>
    ///   <para>rdfs:comment : Connects the element of an ordered list to the ordered list.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#isOLEContained">drama:isOLEContained</a>
    /// </summary>
    let isOLEContained = _prefixId.prefix "isOLEContained"
    /// <summary>
    ///   <para>rdfs:label : isOrderedBy^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#isOrderedBy">drama:isOrderedBy</a>
    /// </summary>
    let isOrderedBy = _prefixId.prefix "isOrderedBy"
    /// <summary>
    ///   <para>rdfs:label : isPlanEffectOf^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#isPlanEffectOf">drama:isPlanEffectOf</a>
    /// </summary>
    let isPlanEffectOf = _prefixId.prefix "isPlanEffectOf"
    /// <summary>
    ///   <para>rdfs:label : isPlanPreconditionOf^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#isPlanPreconditionOf">drama:isPlanPreconditionOf</a>
    /// </summary>
    let isPlanPreconditionOf = _prefixId.prefix "isPlanPreconditionOf"
    /// <summary>
    ///   <para>rdfs:label : isPropositionalContentOf^^xsd:string</para>
    ///   <para>rdfs:comment : Inverse of hasPropositionalContent. It links a BeliefSchema or a GoalSchema to
    ///             a State or Process.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#isPropositionalContentOf">drama:isPropositionalContentOf</a>
    /// </summary>
    let isPropositionalContentOf = _prefixId.prefix "isPropositionalContentOf"
    /// <summary>
    ///   <para>rdfs:label : isRoleOf^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#isRoleOf">drama:isRoleOf</a>
    /// </summary>
    let isRoleOf = _prefixId.prefix "isRoleOf"
    /// <summary>
    ///   <para>rdfs:label : isSpannedBy^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#isSpannedBy">drama:isSpannedBy</a>
    /// </summary>
    let isSpannedBy = _prefixId.prefix "isSpannedBy"
    /// <summary>
    ///   <para>rdfs:label : isTimelineEffectOf^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#isTimelineEffectOf">drama:isTimelineEffectOf</a>
    /// </summary>
    let isTimelineEffectOf = _prefixId.prefix "isTimelineEffectOf"
    /// <summary>
    ///   <para>rdfs:label : isTimelinePreconditionOf^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#isTimelinePreconditionOf">drama:isTimelinePreconditionOf</a>
    /// </summary>
    let isTimelinePreconditionOf = _prefixId.prefix "isTimelinePreconditionOf"
    /// <summary>
    ///   <para>rdfs:label : isValueEngagedOf^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#isValueEngagedOf">drama:isValueEngagedOf</a>
    /// </summary>
    let isValueEngagedOf = _prefixId.prefix "isValueEngagedOf"
    /// <summary>
    ///   <para>rdfs:label : knows^^xsd:string</para>
    ///   <para>rdfs:comment : Property of an agent, who BELIEVES a Belief (a mental state with a
    ///             propositional content). BELIEVES = KNOWS.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#knows">drama:knows</a>
    /// </summary>
    let knows = _prefixId.prefix "knows"
    /// <summary>
    ///   <para>rdfs:label : love_appraisingAgent^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#love_appraisingAgent">drama:love_appraisingAgent</a>
    /// </summary>
    let love_appraisingAgent = _prefixId.prefix "love_appraisingAgent"
    /// <summary>
    ///   <para>rdfs:label : love_target^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#love_target">drama:love_target</a>
    /// </summary>
    let love_target = _prefixId.prefix "love_target"
    /// <summary>
    ///   <para>rdfs:label : orders^^xsd:string</para>
    ///   <para>rdfs:comment : A Timeline orders Unit.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#orders">drama:orders</a>
    /// </summary>
    let orders = _prefixId.prefix "orders"
    /// <summary>
    ///   <para>rdfs:label : originalTerm^^xsd:string</para>
    ///   <para>rdfs:comment : This is the string originally inserted for searching the URI in the external
    ///             ontology. E.g. "parlare" "eleganza"^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#originalTerm">drama:originalTerm</a>
    /// </summary>
    let originalTerm = _prefixId.prefix "originalTerm"
    /// <summary>
    ///   <para>rdfs:label : precedes^^xsd:string</para>
    ///   <para>rdfs:comment : Sequential order in an ordered list.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#precedes">drama:precedes</a>
    /// </summary>
    let precedes = _prefixId.prefix "precedes"
    /// <summary>
    ///   <para>rdfs:label : quale^^xsd:string</para>
    ///   <para>rdfs:comment : Any quality associated to anything. Its range is a string (if a URI is needed
    ///             to resolve the reference, this is dealt with when processing the annotation) All its
    ///             subproperties are introduced on the basis of some specific annotation task. So, its
    ///             current subproperties refer to FrameNet, VerbNet, YagoSumo, MWN corpora,
    ///             respectively.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#quale">drama:quale</a>
    /// </summary>
    let quale = _prefixId.prefix "quale"
    /// <summary>
    ///   <para>rdfs:label : quale_MWNSense^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#quale_MWNSense">drama:quale_MWNSense</a>
    /// </summary>
    let quale_MWNSense = _prefixId.prefix "quale_MWNSense"
    /// <summary>
    ///   <para>rdfs:label : quale_YAGOSUMOConcept^^xsd:string</para>
    ///   <para>rdfs:comment : The range is a concept in YagoSUMO. E.g. &amp;%Speaking+, &amp;%Arriving=,
    ///             these two probably from SUMO;
    ///             http://www.mpii.de/yago/resource/wordnet_bathing_100427853, probably from
    ///             YAGO.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#quale_YAGOSUMOConcept">drama:quale_YAGOSUMOConcept</a>
    /// </summary>
    let quale_YAGOSUMOConcept = _prefixId.prefix "quale_YAGOSUMOConcept"
    /// <summary>
    ///   <para>rdfs:label : quale_framenetFrame^^xsd:string</para>
    ///   <para>rdfs:comment : This property of the ExternalRefSchema links the schema to the frame it
    ///             corresponds to, needed to describe some state or process occurring in drama. The value
    ///             is the ID in Framenet. Currently, in the implementation, it is the string of the number
    ///             of choice in the list of frames returned. E.g. "1"^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#quale_framenetFrame">drama:quale_framenetFrame</a>
    /// </summary>
    let quale_framenetFrame = _prefixId.prefix "quale_framenetFrame"
    /// <summary>
    ///   <para>rdfs:label : quale_framenetRoleID^^xsd:string</para>
    ///   <para>rdfs:comment : Role_framenetRoleID ID of the role as stated by Framenet. It is the string
    ///             returned through the access to Framenet. The string represent the ID of the Frame
    ///             Element. ^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#quale_framenetRoleID">drama:quale_framenetRoleID</a>
    /// </summary>
    let quale_framenetRoleID = _prefixId.prefix "quale_framenetRoleID"
    /// <summary>
    ///   <para>rdfs:label : quale_verbnetRoleLabel^^xsd:string</para>
    ///   <para>rdfs:comment : Type of the role as stated by Verbnet. It is the string returned through the
    ///             access to Verbnet. This happens when the access to Framenet fails.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#quale_verbnetRoleLabel">drama:quale_verbnetRoleLabel</a>
    /// </summary>
    let quale_verbnetRoleLabel = _prefixId.prefix "quale_verbnetRoleLabel"
    /// <summary>
    ///   <para>rdfs:label : shame_appraisingAgent^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#shame_appraisingAgent">drama:shame_appraisingAgent</a>
    /// </summary>
    let shame_appraisingAgent = _prefixId.prefix "shame_appraisingAgent"
    /// <summary>
    ///   <para>rdfs:label : shame_target^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#shame_target">drama:shame_target</a>
    /// </summary>
    let shame_target = _prefixId.prefix "shame_target"
    /// <summary>
    ///   <para>rdfs:label : spans^^xsd:string</para>
    ///   <para>rdfs:comment : The coincidence relation of a Scene on a Timeline.^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#spans">drama:spans</a>
    /// </summary>
    let spans = _prefixId.prefix "spans"
    /// <summary>
    ///   <para>rdfs:label : target^^xsd:string</para>
    ///   <para>rdfs:comment : A generic property for describing the relation of an appraised emotional state
    ///             with the target of the emotion, further articulated into more specific target types for
    ///             each emotion type (see appraisingAgent property).^^xsd:string</para>
    ///   <a href="http://www.purl.org/drammar#target">drama:target</a>
    /// </summary>
    let target = _prefixId.prefix "target"
