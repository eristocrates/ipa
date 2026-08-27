namespace http.www.purl.org.drammar.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module drammar =
    let _namespace_iri = Namespace_Iri drammar |> NamespaceIRI
    /// <summary>
    ///   <para>drammar:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.purl.org/drammar#">http://www.purl.org/drammar#</seealso>
    let _prefix_iri = Prefixed_Name(drammar, "") |> PrefixedName
    /// <summary>
    ///   <para>drammar:ADTComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ADTComponent This class includes the entities which provide the components of
    ///             abstract data types. Currently, only the list data type includes a component, the
    ///             OrderedListElement. The mapping on the AbstractDataType class is given by the
    ///             hasADTComponent object property, which has the AbstractDataType class as its domain, and
    ///             the ADTComponent class as its range."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ADTComponent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#ADTComponent">http://www.purl.org/drammar#ADTComponent</seealso>
    let ADTComponent = Prefixed_Name(drammar, "ADTComponent") |> PrefixedName
    /// <summary>
    ///   <para>drammar:AbstractDataType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"AbstractDataType The data types needed for describing drama are sets, lists
    ///             and trees (more precisely, tree nodes)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AbstractDataType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#AbstractDataType">http://www.purl.org/drammar#AbstractDataType</seealso>
    let AbstractDataType = Prefixed_Name(drammar, "AbstractDataType") |> PrefixedName
    /// <summary>
    ///   <para>drammar:AbstractPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Abstract Plan An abstract plan is a recursive plan, i.e., a plan whose
    ///             elements are plans. Formally, an AbstractPlan is a list (List class) containing
    ///             (containsOLE) elements (OrderedListElements) that have plans as their data (hasData).
    ///             The plans contained in an abstract plan can be either abstract plans or directly
    ///             executable plans."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AbstractPlan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#AbstractPlan">http://www.purl.org/drammar#AbstractPlan</seealso>
    let AbstractPlan = Prefixed_Name(drammar, "AbstractPlan") |> PrefixedName
    /// <summary>
    ///   <para>drammar:Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Action is an intentional Process, which is a type of Process. Formally, an
    ///             action is an Process which is constrained to be contained (isMemberOf) some Unit. In
    ///             Drammar, an Action can be part of a plan of an agent (formally, a plan ia a list of
    ///             actions), or can be included in a Unit (ordered into some timeline). Only direct
    ///             executable plans (DirectlyExecutablePlan class) contain actions The Action class is
    ///             formally disjoint with the UnintentionalEventiveProcess class. We have introduced an
    ///             explicit boolean datatype property isIntentional, because it could be that the
    ///             annotators will use actions directly in the units (i.e. without explicitly introducing a
    ///             plan for it)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Action"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#Action">http://www.purl.org/drammar#Action</seealso>
    let Action = Prefixed_Name(drammar, "Action") |> PrefixedName
    /// <summary>
    ///   <para>drammar:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Agent. Derived from BDI model, a mentalist model of agent which sees the agent
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
    ///             for Artificial Agents. In ICMAS (Vol. 95, pp. 65-72)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Agent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#Agent">http://www.purl.org/drammar#Agent</seealso>
    let Agent = Prefixed_Name(drammar, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>drammar:Belief</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A belief is what an agent believes (which may be true or not in the world) In
    ///             the BDI model, beliefs form the agent's knowledge about the world that the agent
    ///             relies on for devising plans to achieve her goals. In Drammar there is no distinction
    ///             between knowing and believing, because reasoning concerns the agent motivations for
    ///             acting, rather than the relationship between single agent knowledge and shared
    ///             knowledge. A belief is formally defined as the type of MentalState described by a
    ///             BeliefSchema. In the annotation, it is in the scope a ConsistenStateSet, that is
    ///             precondition or effect of a Plan. SWRL rules for mapping project a belief onto some
    ///             ConsistentStateSet which precedes or follows a timeline."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Belief"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#Belief">http://www.purl.org/drammar#Belief</seealso>
    let Belief = Prefixed_Name(drammar, "Belief") |> PrefixedName
    /// <summary>
    ///   <para>drammar:BeliefSchema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The BeliefSchema class describes a Belief (a type of MentalState). This class
    ///             is formally defined as the subclass of MentalStateSchema having as its quale_schemaType
    ///             value the string "belief". A BeliefSchema has as its propositional content
    ///             (via the propositionalContent object property) a factual process (FactualProcess class)
    ///             or state (FactualState class)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"BeliefSchema"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#BeliefSchema">http://www.purl.org/drammar#BeliefSchema</seealso>
    let BeliefSchema = Prefixed_Name(drammar, "BeliefSchema") |> PrefixedName
    /// <summary>
    ///   <para>drammar:ConflictSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the relation of conflict distributed over a set of
    ///             plans. It represents the orchestration of conflicts in drama. Although conflict may
    ///             occur, in drama, between (or within) entities of different types (characters may be in
    ///             conflict with each other, ir the same character may experience conflicting emotions),
    ///             here we reduce the notion of conflict to this single class."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ConflictSet"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#ConflictSet">http://www.purl.org/drammar#ConflictSet</seealso>
    let ConflictSet = Prefixed_Name(drammar, "ConflictSet") |> PrefixedName

    /// <summary>
    ///   <para>drammar:ConsistentStateSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A ConsistentStateSet is a set of states held consistent by definition. It can
    ///             be a set of states bordering a timeline (i.e., the state of affairs holding before and
    ///             after the timeline) or it can be the state of affairs that holds before and after a plan
    ///             (in this case, it represents the plan precondintions and effects). The
    ///             isTimelinePreconditionOf (isTimelineEffectOf) property connects a ConsistentStateSet
    ///             with a Timeline. The isPlanPreconditionOf (isPlanEffectOf) property connects a
    ///             ConsistentStateSet with a Plan. A ConsistentStateSet has one or more states as its
    ///             members (hasMember property)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ConsistentStateSet"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#ConsistentStateSet">http://www.purl.org/drammar#ConsistentStateSet</seealso>
    let ConsistentStateSet =
        Prefixed_Name(drammar, "ConsistentStateSet") |> PrefixedName

    /// <summary>
    ///   <para>drammar:DataStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"DataStructure This class encodes the data structures that provide structural
    ///             organization to the other entities. It includes abstract data types (namely sets, lists
    ///             and trees) and data type components."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DataStructure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#DataStructure">http://www.purl.org/drammar#DataStructure</seealso>
    let DataStructure = Prefixed_Name(drammar, "DataStructure") |> PrefixedName

    /// <summary>
    ///   <para>drammar:DescriptionTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"DescriptionTemplate This class contains a well known role-based pattern for
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
    ///             external knowledge source via a specific data type property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DescriptionTemplate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#DescriptionTemplate">http://www.purl.org/drammar#DescriptionTemplate</seealso>
    let DescriptionTemplate =
        Prefixed_Name(drammar, "DescriptionTemplate") |> PrefixedName

    /// <summary>
    ///   <para>drammar:DirectlyExecutablePlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"DirectlyExecutablePlans Directly executable plans are plans that contain only
    ///             actions. Formally, a directly executale plan is a list (List class) that contains
    ///             (containsOLE) only elements (OrderedListElement) that have actions as their data
    ///             (hasData)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DirectlyExecutablePlan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#DirectlyExecutablePlan">http://www.purl.org/drammar#DirectlyExecutablePlan</seealso>
    let DirectlyExecutablePlan =
        Prefixed_Name(drammar, "DirectlyExecutablePlan") |> PrefixedName

    /// <summary>
    ///   <para>drammar:DramaEndurant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"DramaEndurant is an entity of drama that can be described as an endurant
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
    ///             166-181). Springer Berlin Heidelberg."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DramaEndurant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#DramaEndurant">http://www.purl.org/drammar#DramaEndurant</seealso>
    let DramaEndurant = Prefixed_Name(drammar, "DramaEndurant") |> PrefixedName
    /// <summary>
    ///   <para>drammar:DramaEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"DramaEntity Class of all the dramatic entities, that is, of all the entities
    ///             that are peculiar to drama. Its sisters are classes that are not peculiar to drama, but
    ///             concern templates, (DescriptionTemplate), references to external lexical and semantic
    ///             systems (ExternalReference) and data structures (DataStructure) from computer
    ///             science."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DramaEntity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#DramaEntity">http://www.purl.org/drammar#DramaEntity</seealso>
    let DramaEntity = Prefixed_Name(drammar, "DramaEntity") |> PrefixedName
    /// <summary>
    ///   <para>drammar:DramaPerdurant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The DramaPerdurant class contains the entities of drama that can described as
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
    ///             Web (pp. 166-181). Springer Berlin Heidelberg."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DramaPerdurant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#DramaPerdurant">http://www.purl.org/drammar#DramaPerdurant</seealso>
    let DramaPerdurant = Prefixed_Name(drammar, "DramaPerdurant") |> PrefixedName
    /// <summary>
    ///   <para>drammar:DrammarScene</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"DrammarScene A DrammarScene is a type of scene that hinges on characters'
    ///             conflicting plans. In Drammar, the conflict over plans is represented by a class, the
    ///             ConflictSet, which contains the set of plans in conflict. The hingesOn object property
    ///             connects the DrammarScene with the Conflict Set."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DrammarScene"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#DrammarScene">http://www.purl.org/drammar#DrammarScene</seealso>
    let DrammarScene = Prefixed_Name(drammar, "DrammarScene") |> PrefixedName
    /// <summary>
    ///   <para>drammar:Emotion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Emotion is the class of emotions felt by an agent in a scene. Formally, it is
    ///             described as the subclass of MentalState described by an EmotionSchema. The emotions
    ///             refer to OCC emotion ontology (22 emotions types). Emotion type is an external resource
    ///             (ExternalRefEmotionType). An Emotion has an appraising agent (appraisingAgent object
    ///             property) and, when appraised, is an emotion of (isEmotionOf object property) that
    ///             agent. An emotion also has a target (the agent or object that is the target of the
    ///             emotion): a specifi object property connects each emotion type with its target (e.g.,
    ///             shame_target, love_target, etc.)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Emotion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#Emotion">http://www.purl.org/drammar#Emotion</seealso>
    let Emotion = Prefixed_Name(drammar, "Emotion") |> PrefixedName
    /// <summary>
    ///   <para>drammar:EmotionSchema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An EmotionSchema represents the description of an EmotionState, bridged onto
    ///             some external linguistic or semantic system through the mediation of the
    ///             ExternalRefEmotionType class. The EmotionSchema is a MentalStateSchema for describing an
    ///             Emotion. Formally, it is constrained to the value "emotion" for the
    ///             quale_schemaType data property. The hasExtRef property links the EmotionSchema to the
    ///             ExternalRefEmotionType class which in turn links the description of the Emotion to a
    ///             reference theory of emotions."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"EmotionSchema"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#EmotionSchema">http://www.purl.org/drammar#EmotionSchema</seealso>
    let EmotionSchema = Prefixed_Name(drammar, "EmotionSchema") |> PrefixedName

    /// <summary>
    ///   <para>drammar:ExternalRefEmotionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class includes individuals for all the 22 emotion types referred by OCC
    ///             theory. The individuals are bridge individuals to some external formal OCC-based
    ///             knowledge source, which does not exist yet but is assumed here. These individuals could
    ///             also be a bridge to some commonsense ontology, such as YagoSumo for Values, but it would
    ///             be different from the adoption of the OCC theory, as committed in
    ///             Drammar."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ExternalRefEmotionType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#ExternalRefEmotionType">http://www.purl.org/drammar#ExternalRefEmotionType</seealso>
    let ExternalRefEmotionType =
        Prefixed_Name(drammar, "ExternalRefEmotionType") |> PrefixedName

    /// <summary>
    ///   <para>drammar:ExternalRefEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The ExternalRefEntity class has the function of bridging the description of a
    ///             DramaEntity (not an entity in general) to some external linguistic or semantic resource
    ///             such a dictionary or an ontology. An entity can be linked to its ExternalReference by
    ///             the hasExtRef object property, which has the ExternalReference as its range. The
    ///             ExternalRefEntity iherits the "quale" data property from its direct ancestor,
    ///             ExternalReference class."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ExternalRefEntity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#ExternalRefEntity">http://www.purl.org/drammar#ExternalRefEntity</seealso>
    let ExternalRefEntity = Prefixed_Name(drammar, "ExternalRefEntity") |> PrefixedName
    /// <summary>
    ///   <para>drammar:ExternalRefRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The ExternalRefRole class has the function of bridging the description of a
    ///             Role (not an entity in general) to a description of the role in some external linguistic
    ///             that represents the argument structure of an event. An Role can be linked to its
    ///             ExternalRefRole by the hasExtRef object property, which has the ExternalRefRole as its
    ///             range. The ExternalRefRole class has three data properties which connect it to the
    ///             reference system: - role_framenetRoleID: connects the Role to the id of the
    ///             corresponding role in FrameNet - role_verbnetRoleType: connects the Role to the name of
    ///             the corresponding role in VerdNet (a string) - role_ID_resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ExternalRefRole"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#ExternalRefRole">http://www.purl.org/drammar#ExternalRefRole</seealso>
    let ExternalRefRole = Prefixed_Name(drammar, "ExternalRefRole") |> PrefixedName
    /// <summary>
    ///   <para>drammar:ExternalRefSchema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The ExternalRefSchema class has the function of bridging the description of a
    ///             SituationSchema to some external lexical-semantic resource representing apt to represent
    ///             the role structure of a process or state. An SituationSchema (or, better, a subclass of
    ///             it) can be linked to its ExternalRefSchema by the hasExtRef object property, which has
    ///             the ExternalReference as its range. The quale_frame_URI data property connects the
    ///             SituationSchema with the FrameNet frame which correponds to it, following the paradigm
    ///             of Linked Data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ExternalRefSchema"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#ExternalRefSchema">http://www.purl.org/drammar#ExternalRefSchema</seealso>
    let ExternalRefSchema = Prefixed_Name(drammar, "ExternalRefSchema") |> PrefixedName
    /// <summary>
    ///   <para>drammar:ExternalReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ExternalReference This is a class that provides the service of accumulating
    ///             all the "quale" datatype properties that refer to external linguistic or
    ///             commonsense knowledge sources. Through this class, the description of the drama entities
    ///             is bridged onto some external lexicon or ontology. Its subclasses are useful in
    ///             grouping, but do not represent specific issues in support."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ExternalReference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#ExternalReference">http://www.purl.org/drammar#ExternalReference</seealso>
    let ExternalReference = Prefixed_Name(drammar, "ExternalReference") |> PrefixedName
    /// <summary>
    ///   <para>drammar:FrameNetSchema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A FrameNetSchema corresponds to a process or state describable by a frame in
    ///             Framenet (https://framenet2.icsi.berkeley.edu/fnReports/data/frameIndex.xml). The
    ///             reference of the schema to the external linguistic reality (the FrameNet frame) is
    ///             mediated through an apposite class subsumed by the ExternalReference class, the
    ///             ExternalRefSchema class: the SituationSchema class (and, by inheritance, also the
    ///             FrameNetSchema class) is linked to the ExternalRefSchema class via the hasExtRef
    ///             property. The quale_frame_URI, then, bridges the ExternalRefSchema class onto the URI of
    ///             the appropriate frame."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"FrameNetSchema"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#FrameNetSchema">http://www.purl.org/drammar#FrameNetSchema</seealso>
    let FrameNetSchema = Prefixed_Name(drammar, "FrameNetSchema") |> PrefixedName
    /// <summary>
    ///   <para>drammar:Goal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Goal class represents the objectives of an agent. In the BDI model, the
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
    ///             correctly."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Goal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#Goal">http://www.purl.org/drammar#Goal</seealso>
    let Goal = Prefixed_Name(drammar, "Goal") |> PrefixedName
    /// <summary>
    ///   <para>drammar:GoalSchema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The GoalSchema class describes a Goal (a type of MentalState). This class is
    ///             formally defined as the subclass of MentalStateSchema having as its quale_schemaType
    ///             value the string "goal". A GoalSchema has as its propositional content (via
    ///             the propositionalContent object property) a factual process (FactualProcess class) or
    ///             state (FactualState class)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"GoalSchema"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#GoalSchema">http://www.purl.org/drammar#GoalSchema</seealso>
    let GoalSchema = Prefixed_Name(drammar, "GoalSchema") |> PrefixedName
    /// <summary>
    ///   <para>drammar:Goal_type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Type of the goal: one of the strings "Achievement"
    ///             "Maintainance" "Perform" "Query""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Goal_type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#Goal_type">http://www.purl.org/drammar#Goal_type</seealso>
    let Goal_type = Prefixed_Name(drammar, "Goal_type") |> PrefixedName
    /// <summary>
    ///   <para>drammar:List</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"List List is inspired by a well known ontology
    ///             (http://smiy.sourceforge.net/olo/spec/orderedlistontology.html#ordered_list); however,
    ///             its implementation in Drammar makes some simplifications (e.g., indexes are not
    ///             included) and renames some entities according to the terminology of the drama domain.
    ///             List in drama: - Plan: sequence of plans (abstract plans) or single actions (directly
    ///             executable plans); - Timeline: sequence of units."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"List"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#List">http://www.purl.org/drammar#List</seealso>
    let List = Prefixed_Name(drammar, "List") |> PrefixedName
    /// <summary>
    ///   <para>drammar:MentalState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"MentalStates are EventiveStates that are attributed to the mind of an agent.
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
    ///             for the right trait of the mental schema."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MentalState"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#MentalState">http://www.purl.org/drammar#MentalState</seealso>
    let MentalState = Prefixed_Name(drammar, "MentalState") |> PrefixedName
    /// <summary>
    ///   <para>drammar:MentalStateSchema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The MentalStateSchema class collects all the schemata that license the
    ///             behavior of the mental states. Following the guidelines for describing mental states in
    ///             Ferrario, R., &amp; Oltramari, A. (2005, March). Towards a computational ontology of
    ///             mind. In Aerospace Conference, 2005 IEEE (pp. 1-9). IEEE, propositional attitudes such
    ///             as beliefs and goals are considered mental states in Drammar. The MentalState class
    ///             includes: - BeliefSchema - EmotionSchema - GoalSchema - ValueSchema The schemata
    ///             match the mental states included in Drammar. Mental states are grouped in the
    ///             DramaPerdurant class as eventive mental states (MentalState class) or as factual mental
    ///             states (F_MentalState class)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MentalStateSchema"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#MentalStateSchema">http://www.purl.org/drammar#MentalStateSchema</seealso>
    let MentalStateSchema = Prefixed_Name(drammar, "MentalStateSchema") |> PrefixedName
    /// <summary>
    ///   <para>drammar:Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Object Class of entities (endurant) that participates into Perdurants, but
    ///             without having intentions. An object is formally defined as a subclass of DramaEndurant
    ///             whose member do not have plans. Objects can be filler of roles in the description of
    ///             processes and states (for example, a book can be "theme" in a giving action
    ///             (i.e. the entity that changes ownership as a consequence of a giving act). This class is
    ///             formally disjoint from Agents (Disjoint property)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#Object">http://www.purl.org/drammar#Object</seealso>
    let Object = Prefixed_Name(drammar, "Object") |> PrefixedName

    /// <summary>
    ///   <para>drammar:OrderedListElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class of the elements of the ordered lists (lists are plans and timelines).
    ///             Sometimes referred to as OLE. The hasOrderedListElement object property has the List
    ///             class as its domain and the OrderedListElement as its range. Notice that this class
    ///             works as a placeholder that represents the single item in a list (it is not the list
    ///             content itself): the property hasData links the OrderedListElement with the actual data,
    ///             i.e. the content of the item. For example, the OrderedListElements Plans have other
    ///             plans or actions as their data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"OrderedListElement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#OrderedListElement">http://www.purl.org/drammar#OrderedListElement</seealso>
    let OrderedListElement =
        Prefixed_Name(drammar, "OrderedListElement") |> PrefixedName

    /// <summary>
    ///   <para>drammar:Plan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Plan A plan is a sequence of actions devised by an agent to achieve some Goal.
    ///             In the BDI model, the agent's 'intention' to execute a plan is the bridge
    ///             between goals and practical actions. In Drammar, a plan is intended by (intendedBy
    ///             object property) an Agent to achieve (achieve property) some Goal. As a consequence, the
    ///             plan motivates (isMotivationFor object property) a timeline (i.e. a given extent of the
    ///             drama text). These are the necessary and sufficient conditions of class. Following the
    ///             paradigm of hierarchical planning, plans are recursive. So plans can contains actions or
    ///             other, simpler plans. Formally, a Plan is a list (namely, it is a subclass of the List
    ///             class) whose elements are simpler plans (for abstract plans) or actions (for directly
    ///             executable plans). A plan is related to its elements by the containsOLE
    ///             property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Plan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#Plan">http://www.purl.org/drammar#Plan</seealso>
    let Plan = Prefixed_Name(drammar, "Plan") |> PrefixedName
    /// <summary>
    ///   <para>drammar:Process</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Processes represents the dynamic class of the perdurants: they are gathered
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
    ///             state schema."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#Process">http://www.purl.org/drammar#Process</seealso>
    let Process = Prefixed_Name(drammar, "Process") |> PrefixedName
    /// <summary>
    ///   <para>drammar:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Role provides the pattern for the role fillers in a frame instantiation, that
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
    ///             respectively for FrameNet and VerbNet)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#Role">http://www.purl.org/drammar#Role</seealso>
    let Role = Prefixed_Name(drammar, "Role") |> PrefixedName
    /// <summary>
    ///   <para>drammar:Scene</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Scene Drama is divided into scenes, which correspond to an extent of the
    ///             'text' of drama. Scenes (as a type of TreeNode) form a hierarchy, which
    ///             represents the recursive nature of drama. This is obtained by implementing the Scene
    ///             class as a subclass of the TreeNode class. Scenes contains children scenes: this
    ///             relation is modeled through the hasChild property. All scenes span some timeline (spans
    ///             object property), i.e., they have a correspondance with some extent of the drama text
    ///             (represented by the Timeline class)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Scene"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#Scene">http://www.purl.org/drammar#Scene</seealso>
    let Scene = Prefixed_Name(drammar, "Scene") |> PrefixedName
    /// <summary>
    ///   <para>drammar:Schema_type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This datatype property represents the type of schema for some construct. Its
    ///             value correspond to the different types of state acknowledged in Drammar : beliefs,
    ///             goals, etc. Each value correspond to a state type: e.g., "belief" for the
    ///             Belief class. In particular, framenet is the magic word for the schemata extracted from
    ///             Framenet."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Schema_type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#Schema_type">http://www.purl.org/drammar#Schema_type</seealso>
    let Schema_type = Prefixed_Name(drammar, "Schema_type") |> PrefixedName
    /// <summary>
    ///   <para>drammar:Set</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Set The class of set structures. The relation between sets and set members is
    ///             represented by the hasMember object property. It includes specific subclasses, with each
    ///             subclass characterized by a specific type of members. Sets include: - ConflictsSets:
    ///             sets of conflicting plans; - ConsistentStateSets: sets of consistent states (left and
    ///             right boundaries of timelines and plans). - Units: sets of actions."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Set"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#Set">http://www.purl.org/drammar#Set</seealso>
    let Set = Prefixed_Name(drammar, "Set") |> PrefixedName
    /// <summary>
    ///   <para>drammar:SetMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class of the elements
    ///             of the sets (sets are conflict sets, consistent state sets, and units). Sometimes
    ///             referred to as SM. The hasMember object property has the Set class as its domain and the
    ///             SetMember as its range. Notice that this class works as a placeholder that represents
    ///             the single element in a set (it is not the content itself): the property hasData links
    ///             the SetMember with the actual data, i.e. the content of the item. For example, the
    ///             specific Set that is a Unit hasMember some SetMember that hasData some
    ///             Action."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SetMember"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#SetMember">http://www.purl.org/drammar#SetMember</seealso>
    let SetMember = Prefixed_Name(drammar, "SetMember") |> PrefixedName
    /// <summary>
    ///   <para>drammar:SituationSchema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The situation schema provides the pattern for the description of incidents and states. It is inspired by the Situation ontology Pattern of the Ontology Design Pattern initiative (http://ontologydesignpatterns.org/). So, a SituationSchema describes ("describes" object property) a DramaPerdurant (either a State or a Process).
    /// The schema works as a hub for the roles involved in a situation. The property hasRole links the Situation class (its domain) with the Role class (the range of the property). Also, notice that, as illustrated in the documentation of the SituationSchema class, a Situation Schema (or, better, its subclasses) does not directly refer to the external linguistic knowledge employed to describe drama: rather, it refers to the ExternalRefSchema class (subclass of the top level ExternalReference class), which in  turn refers to the linguistic knowledge. The SituationSchema class specializes into specific schemata for describing specific type of situations:
    /// - FrameNetSchema: for describing processes, like giving or killing (in Drammar, they are grouped into units arranged on timelines), and states, like being behind some object or being dead (in Drammar, they are bundled into sets that border timelines and plans).
    /// - MentalStateSchema: this class groups the specific types of schemata for describing the mental states of the agents in Drammar, namely beliefs, goals, emotions and values.
    /// Technically, the subtypes of SituationSchema are characterized by different values of the quale_schemaType data property: "belief", "emotion", "framenet", "goal",  "value".
    /// Finally, it is worth mentioning that is a specific design choice of Drammar not to represent the nesting of states: only the type of the top level state, e.g., a belief, is represented, independent of what that belief contains in turn. This flat style of representation is determined by the decision not to commit to a specific logical account of state types. When Drammar is employed for annotation, the content nested into a state is described informally in natural language description accompanying the state, if needed.
    /// Refs: Gangemi, A., &amp; Presutti, V. (2009). Ontology design patterns. In Handbook on ontologies (pp. 221-243). Springer Berlin, Heidelberg."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SituationSchema"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#SituationSchema">http://www.purl.org/drammar#SituationSchema</seealso>
    let SituationSchema = Prefixed_Name(drammar, "SituationSchema") |> PrefixedName
    /// <summary>
    ///   <para>drammar:State</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"State represents the static class of the Perdurant. State is the class that
    ///             bridges to the concept of State in upper ontologies, externally to Drammar. For example,
    ///             in DOLCE, states and process are the two distinct types of statives. Both factual and
    ///             eventive states are further divided into different state types: - MentalStates, namely
    ///             Belief, Goals, Values and Emotions (all sharing some propositional content in their
    ///             description); - StateOfAffairs, namely situations holding in the world. States participate
    ///             to some structure. In Drammar, these structures are ConsistenStateSets (types of Sets),
    ///             which borders timelines and plans. The specific type pf States are defined through the
    ///             use of specific types of StateSchema (subclass of DescriptionTemplate). So, its
    ///             subclasses are: - MentalState: the mental state of an agent; - StateOfAffairs: an
    ///             objective state of the story world."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"State"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#State">http://www.purl.org/drammar#State</seealso>
    let State = Prefixed_Name(drammar, "State") |> PrefixedName
    /// <summary>
    ///   <para>drammar:StateOfAffairs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"StateofAffairs are states that concern the storyworld as a whole; they are
    ///             described by a FrameNetSchema, namely a SituationSchema that points (through the
    ///             ExternalRefSchema class) points to a specific frame. This class gathers all states that
    ///             are external to the characters' mental states, and can be linguistically described
    ///             through some external resources such as FrameNet."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"StateOfAffairs"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#StateOfAffairs">http://www.purl.org/drammar#StateOfAffairs</seealso>
    let StateOfAffairs = Prefixed_Name(drammar, "StateOfAffairs") |> PrefixedName
    /// <summary>
    ///   <para>drammar:Timeline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Timeline Timeline is a subclass of List whose function is to impose some
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
    ///             scene/timeline relation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Timeline"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#Timeline">http://www.purl.org/drammar#Timeline</seealso>
    let Timeline = Prefixed_Name(drammar, "Timeline") |> PrefixedName
    /// <summary>
    ///   <para>drammar:Tree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Tree The class of tree
    ///             structures. The relation between trees and tree nodes is represented by the containsTN
    ///             abd hasRoot object properties. A drama is actually a tree, composed recursively of
    ///             subtrees, which are scenes at different levels. The subtree relationship is established
    ///             between scenes (property hasChild), which are actually tree nodes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Tree"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#Tree">http://www.purl.org/drammar#Tree</seealso>
    let Tree = Prefixed_Name(drammar, "Tree") |> PrefixedName
    /// <summary>
    ///   <para>drammar:TreeNode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"TreeNode The TreeNode class represents tree-like structures in drama, namely
    ///             Scenes. This class only represents the recursive structure of drama without an explicit
    ///             commitment to the notion of 'drama as a tree'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TreeNode"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#TreeNode">http://www.purl.org/drammar#TreeNode</seealso>
    let TreeNode = Prefixed_Name(drammar, "TreeNode") |> PrefixedName

    /// <summary>
    ///   <para>drammar:UnderspecifiedPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An UnderspecifiedPlan is a plan that is part of a larger plan to achieve some
    ///             goal, but has not been executed. In drama, it represents the unobservable part of a plan
    ///             that has not been fully carried out by some agent. Its existence (in the agent's
    ///             mind) can only be conjectured - remember that a Plan is intended by some agent by
    ///             definition. As the object of a conjecture, it does not contain any details in the
    ///             representation of drama (this does not mean that it does not contain them in the
    ///             agent's mind). As such, an UnderspecifiedPlan: - does *not* motivate a timeline (it
    ///             has not taken place); - does *not* achieve a goal (the actions/subplans composing it and
    ///             its specific goal are not known); - does *not* contain any actions. These conditions,
    ///             part of its definition as an Equivalent Class, distinguish it from Abstract and Directly
    ///             Executable Plans."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"UnderspecifiedPlan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#UnderspecifiedPlan">http://www.purl.org/drammar#UnderspecifiedPlan</seealso>
    let UnderspecifiedPlan =
        Prefixed_Name(drammar, "UnderspecifiedPlan") |> PrefixedName

    /// <summary>
    ///   <para>drammar:UnintentionalProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"UnintentionalProcess is an unintentional Process. So, an UnintentionalProcess
    ///             is a Process with the property isIntentional that values FALSE."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"UnintentionalProcess"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#UnintentionalProcess">http://www.purl.org/drammar#UnintentionalProcess</seealso>
    let UnintentionalProcess =
        Prefixed_Name(drammar, "UnintentionalProcess") |> PrefixedName

    /// <summary>
    ///   <para>drammar:Unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Unit Units are the segmentation of drama. A drama can have multiple
    ///             segmentations. Units are ordered by some Timeline. Units are devoted to the
    ///             representation of characters' actions. So, we require that any unit contains at
    ///             least one action whose description (ProcessSchema) encompasses at least one role having
    ///             an agent as a filler. If a building collapses, this action, by itself, can be part of
    ///             Unit only if an agent is involved in it (e.g., an agent dies). This definition
    ///             guarantees that, in the minimal case, at least one agent appears as filler of the roles
    ///             in the description of at least an action of every unit. A Unit has one or more actions
    ///             as its members (hasMember property)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#Unit">http://www.purl.org/drammar#Unit</seealso>
    let Unit = Prefixed_Name(drammar, "Unit") |> PrefixedName
    /// <summary>
    ///   <para>drammar:Value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Value Class represents the values of an agent. These values are
    ///             engaged in drama by the execution of the agents' plans. Formally, a Value is
    ///             a subclass of the MentalState class which is constrained to: - be in a given state, true
    ///             or false, of the boolean property atStake - be in a ConsistentStateSet (namely, the
    ///             consequences of some plan that puts the value at stake or brings it back to balance) -
    ///             be described by a ValueSchema. For example, in the nunnery scene, Ophelia's
    ///             answer "At home, my Lord", being a lie, results in a state that puts at stake
    ///             Hamlet's value of honesty."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#Value">http://www.purl.org/drammar#Value</seealso>
    let Value = Prefixed_Name(drammar, "Value") |> PrefixedName
    /// <summary>
    ///   <para>drammar:ValueSchema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The ValueSchema class describes an agent's Value. Formally,
    ///             it is a subclass of MentalStateSchema whose property quale_schemaType is constrained to
    ///             the string "value"."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ValueSchema"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#ValueSchema">http://www.purl.org/drammar#ValueSchema</seealso>
    let ValueSchema = Prefixed_Name(drammar, "ValueSchema") |> PrefixedName
    /// <summary>
    ///   <para>drammar:accomplished</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Accomplished = true stands for entirely executed and goal achieved
    ///             Accomplished = false stands for entirely executed and goal not achieved When missing,
    ///             nothing is said about execution."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"accomplished"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#accomplished">http://www.purl.org/drammar#accomplished</seealso>
    let accomplished = Prefixed_Name(drammar, "accomplished") |> PrefixedName
    /// <summary>
    ///   <para>drammar:achieves</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"achieves links a Plan to the Goal it aims at achieving"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"achieves"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#achieves">http://www.purl.org/drammar#achieves</seealso>
    let achieves = Prefixed_Name(drammar, "achieves") |> PrefixedName
    /// <summary>
    ///   <para>drammar:appraisingAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The appraisingAgent property connects an Emotion with the Agent who appraises
    ///             it. It encompasses specific subproperties for the specific emotion types (in OCC theory,
    ///             there are 22 emotion types such as Love or Shame)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"appraisingAgent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#appraisingAgent">http://www.purl.org/drammar#appraisingAgent</seealso>
    let appraisingAgent = Prefixed_Name(drammar, "appraisingAgent") |> PrefixedName
    /// <summary>
    ///   <para>drammar:atStake</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Boolean property of a Value: - true, if the value is at stake; - false,
    ///             if the value is balanced."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"atStake"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#atStake">http://www.purl.org/drammar#atStake</seealso>
    let atStake = Prefixed_Name(drammar, "atStake") |> PrefixedName
    /// <summary>
    ///   <para>drammar:coOccurInScene</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>"coOccurInScene can be used to describe the fact that two Plans co-occur in the
    ///             same Scene."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"coOccurInScene"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#coOccurInScene">http://www.purl.org/drammar#coOccurInScene</seealso>
    let coOccurInScene = Prefixed_Name(drammar, "coOccurInScene") |> PrefixedName
    /// <summary>
    ///   <para>drammar:containsFirstOLE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"First OLE of a
    ///             List."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"containsFirstOLE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#containsFirstOLE">http://www.purl.org/drammar#containsFirstOLE</seealso>
    let containsFirstOLE = Prefixed_Name(drammar, "containsFirstOLE") |> PrefixedName
    /// <summary>
    ///   <para>drammar:containsLastOLE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Last OLE of a
    ///             List."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"containsLastOLE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#containsLastOLE">http://www.purl.org/drammar#containsLastOLE</seealso>
    let containsLastOLE = Prefixed_Name(drammar, "containsLastOLE") |> PrefixedName
    /// <summary>
    ///   <para>drammar:containsOLE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>"Inverse of isOLElementOf. Connects the ordered list to its elements.
    ///         "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"containsOLE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#containsOLE">http://www.purl.org/drammar#containsOLE</seealso>
    let containsOLE = Prefixed_Name(drammar, "containsOLE") |> PrefixedName
    /// <summary>
    ///   <para>drammar:containsTN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects the tree to
    ///             its (tree) nodes. E.g., the drama is a tree and the scenes are its tree
    ///             nodes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"containsTN"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#containsTN">http://www.purl.org/drammar#containsTN</seealso>
    let containsTN = Prefixed_Name(drammar, "containsTN") |> PrefixedName
    /// <summary>
    ///   <para>drammar:describes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A SituationSchema describes a DramaPerdurant, i.e. provides a template for
    ///             describing processes and states."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"describes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#describes">http://www.purl.org/drammar#describes</seealso>
    let describes = Prefixed_Name(drammar, "describes") |> PrefixedName
    /// <summary>
    ///   <para>drammar:feels</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"feels"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#feels">http://www.purl.org/drammar#feels</seealso>
    let feels = Prefixed_Name(drammar, "feels") |> PrefixedName
    /// <summary>
    ///   <para>drammar:follows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of precedes. Sequential order in an ordered list."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"follows"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#follows">http://www.purl.org/drammar#follows</seealso>
    let follows = Prefixed_Name(drammar, "follows") |> PrefixedName

    /// <summary>
    ///   <para>drammar:happyFor_appraisingAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"HappyFor_appraisingAgent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#happyFor_appraisingAgent">http://www.purl.org/drammar#happyFor_appraisingAgent</seealso>
    let happyFor_appraisingAgent =
        Prefixed_Name(drammar, "happyFor_appraisingAgent") |> PrefixedName

    /// <summary>
    ///   <para>drammar:happyFor_target</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"happyFor_target"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#happyFor_target">http://www.purl.org/drammar#happyFor_target</seealso>
    let happyFor_target = Prefixed_Name(drammar, "happyFor_target") |> PrefixedName
    /// <summary>
    ///   <para>drammar:hasADTComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A generic property for representing the relation among a given abstract
    ///             structure type and its components."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasADTComponent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#hasADTComponent">http://www.purl.org/drammar#hasADTComponent</seealso>
    let hasADTComponent = Prefixed_Name(drammar, "hasADTComponent") |> PrefixedName
    /// <summary>
    ///   <para>drammar:hasChild</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"the basic relation employed for modelling the computational data structure of
    ///             tree."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasChild"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#hasChild">http://www.purl.org/drammar#hasChild</seealso>
    let hasChild = Prefixed_Name(drammar, "hasChild") |> PrefixedName
    /// <summary>
    ///   <para>drammar:hasData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property that connects a structural element (e.g. of the class OLE) with the
    ///             data contained in it. Range is not defined; it is defined for each specific structure
    ///             element. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasData"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#hasData">http://www.purl.org/drammar#hasData</seealso>
    let hasData = Prefixed_Name(drammar, "hasData") |> PrefixedName
    /// <summary>
    ///   <para>drammar:hasDoneState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasDoneState"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#hasDoneState">http://www.purl.org/drammar#hasDoneState</seealso>
    let hasDoneState = Prefixed_Name(drammar, "hasDoneState") |> PrefixedName
    /// <summary>
    ///   <para>drammar:hasEmotionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasEmotionType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#hasEmotionType">http://www.purl.org/drammar#hasEmotionType</seealso>
    let hasEmotionType = Prefixed_Name(drammar, "hasEmotionType") |> PrefixedName
    /// <summary>
    ///   <para>drammar:hasExtRef</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Quality of an entity (DramaEndurant) In particular: Object_type This property
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
    ///             string. This is why Range is empty. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasExtRef"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#hasExtRef">http://www.purl.org/drammar#hasExtRef</seealso>
    let hasExtRef = Prefixed_Name(drammar, "hasExtRef") |> PrefixedName
    /// <summary>
    ///   <para>drammar:hasFiller</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Filler is the property that connects a Role of a FrameNetSchema with the
    ///             DramaEntity (DramaEndurant or DramaPerdurant) that fills that Role."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasFiller"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#hasFiller">http://www.purl.org/drammar#hasFiller</seealso>
    let hasFiller = Prefixed_Name(drammar, "hasFiller") |> PrefixedName
    /// <summary>
    ///   <para>drammar:hasGoal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The property which connects an agent with her/his goals."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasGoal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#hasGoal">http://www.purl.org/drammar#hasGoal</seealso>
    let hasGoal = Prefixed_Name(drammar, "hasGoal") |> PrefixedName
    /// <summary>
    ///   <para>drammar:hasManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"hasManifestation This property connects a Unit to a manifestation of drama
    ///             according to FRBR model. In the real world, a manifestation is represented by a IRI
    ///             (e.g., the URL of a movie, of the recording of a performance, or of the digital edition
    ///             of a novel)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasManifestation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#hasManifestation">http://www.purl.org/drammar#hasManifestation</seealso>
    let hasManifestation = Prefixed_Name(drammar, "hasManifestation") |> PrefixedName
    /// <summary>
    ///   <para>drammar:hasMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The specific property for modelling Sets (as a data structure). Any entity, in
    ///             Drammar, can be a member of a Set."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasMember"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#hasMember">http://www.purl.org/drammar#hasMember</seealso>
    let hasMember = Prefixed_Name(drammar, "hasMember") |> PrefixedName
    /// <summary>
    ///   <para>drammar:hasMentalState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasMentalState"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#hasMentalState">http://www.purl.org/drammar#hasMentalState</seealso>
    let hasMentalState = Prefixed_Name(drammar, "hasMentalState") |> PrefixedName
    /// <summary>
    ///   <para>drammar:hasMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Anything can convey a message. Standard cases: Signpost at a city entrance
    ///             "Ciudad de Mexico"; Toothpaste brand name on the object toothpaste:
    ///             "Colgate" A specific utterance in a communication action."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasMessage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#hasMessage">http://www.purl.org/drammar#hasMessage</seealso>
    let hasMessage = Prefixed_Name(drammar, "hasMessage") |> PrefixedName
    /// <summary>
    ///   <para>drammar:hasMotivationIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The hasMotivation property represents the relation bewteen a plan and the
    ///             timeline it motivates (namely, where the actions of the plan are actually
    ///             contained)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasMotivationIn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#hasMotivationIn">http://www.purl.org/drammar#hasMotivationIn</seealso>
    let hasMotivationIn = Prefixed_Name(drammar, "hasMotivationIn") |> PrefixedName
    /// <summary>
    ///   <para>drammar:hasParent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The parent/child relation for modelling tree structures."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasParent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#hasParent">http://www.purl.org/drammar#hasParent</seealso>
    let hasParent = Prefixed_Name(drammar, "hasParent") |> PrefixedName
    /// <summary>
    ///   <para>drammar:hasPlanEffect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property that connects a plan with the consistent set of states that is the
    ///             effect of a plan (ConsistentStateSet)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasPlanEffect"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#hasPlanEffect">http://www.purl.org/drammar#hasPlanEffect</seealso>
    let hasPlanEffect = Prefixed_Name(drammar, "hasPlanEffect") |> PrefixedName

    /// <summary>
    ///   <para>drammar:hasPlanPrecondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property that connect a plan with the ConsistentStateState which forms its
    ///             precondition."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasPlanPrecondition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#hasPlanPrecondition">http://www.purl.org/drammar#hasPlanPrecondition</seealso>
    let hasPlanPrecondition =
        Prefixed_Name(drammar, "hasPlanPrecondition") |> PrefixedName

    /// <summary>
    ///   <para>drammar:hasPropositionalContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"hasPropositionalContent links a BeliefSchema or a GoalSchema to the its
    ///             content (a factual state or process), that is, the Process or State that is the actual
    ///             content of the belief or the goal."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasPropositionalContent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#hasPropositionalContent">http://www.purl.org/drammar#hasPropositionalContent</seealso>
    let hasPropositionalContent =
        Prefixed_Name(drammar, "hasPropositionalContent") |> PrefixedName

    /// <summary>
    ///   <para>drammar:hasRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a SituationSchema ( modelled by a frame-like linguistic structure)
    ///             with each Role of the schema."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasRole"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#hasRole">http://www.purl.org/drammar#hasRole</seealso>
    let hasRole = Prefixed_Name(drammar, "hasRole") |> PrefixedName
    /// <summary>
    ///   <para>drammar:hasRoot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects the Tree with
    ///             the TreeNode that is its Root."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasRoot"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#hasRoot">http://www.purl.org/drammar#hasRoot</seealso>
    let hasRoot = Prefixed_Name(drammar, "hasRoot") |> PrefixedName
    /// <summary>
    ///   <para>drammar:hasTimelineEffect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>"Property that connect a Timeline with the ConsistentStateState which forms its
    ///             effects."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasTimelineEffect"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#hasTimelineEffect">http://www.purl.org/drammar#hasTimelineEffect</seealso>
    let hasTimelineEffect = Prefixed_Name(drammar, "hasTimelineEffect") |> PrefixedName

    /// <summary>
    ///   <para>drammar:hasTimelinePrecondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property that connect a Timeline with the ConsistentStateState which forms its
    ///             precondition."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasTimelinePrecondition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#hasTimelinePrecondition">http://www.purl.org/drammar#hasTimelinePrecondition</seealso>
    let hasTimelinePrecondition =
        Prefixed_Name(drammar, "hasTimelinePrecondition") |> PrefixedName

    /// <summary>
    ///   <para>drammar:hasValueEngaged</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The property hasValue connects an agent to her/his values"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasValueEngaged"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#hasValueEngaged">http://www.purl.org/drammar#hasValueEngaged</seealso>
    let hasValueEngaged = Prefixed_Name(drammar, "hasValueEngaged") |> PrefixedName
    /// <summary>
    ///   <para>drammar:hingesOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A DrammarScene hinges on some ConflictSet"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hingesOn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#hingesOn">http://www.purl.org/drammar#hingesOn</seealso>
    let hingesOn = Prefixed_Name(drammar, "hingesOn") |> PrefixedName
    /// <summary>
    ///   <para>drammar:inConflictWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>"The conflict relation over plans. The ontology is neutral with respect with
    ///             conflicts over other entity types, such a goals: it only assumes that conflicts over
    ///             plans are observable."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"inConflictWith"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#inConflictWith">http://www.purl.org/drammar#inConflictWith</seealso>
    let inConflictWith = Prefixed_Name(drammar, "inConflictWith") |> PrefixedName
    /// <summary>
    ///   <para>drammar:inSupportOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The support relation over goals (parallel to inConflictWith)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"inSupportOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#inSupportOf">http://www.purl.org/drammar#inSupportOf</seealso>
    let inSupportOf = Prefixed_Name(drammar, "inSupportOf") |> PrefixedName
    /// <summary>
    ///   <para>drammar:intends</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Intends has as domain an Agent and as range a Plan."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"intends"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#intends">http://www.purl.org/drammar#intends</seealso>
    let intends = Prefixed_Name(drammar, "intends") |> PrefixedName
    /// <summary>
    ///   <para>drammar:isAchievedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property connects a goal with the plan that achieves it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isAchievedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#isAchievedBy">http://www.purl.org/drammar#isAchievedBy</seealso>
    let isAchievedBy = Prefixed_Name(drammar, "isAchievedBy") |> PrefixedName
    /// <summary>
    ///   <para>drammar:isDataOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"isDataOf connects some entity to a data structure component (namely, an
    ///             OrderedListElement) of which it is the content."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isDataOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#isDataOf">http://www.purl.org/drammar#isDataOf</seealso>
    let isDataOf = Prefixed_Name(drammar, "isDataOf") |> PrefixedName
    /// <summary>
    ///   <para>drammar:isDescribedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of describes, this property connects a Dynamics (Process or State)
    ///             with the SituationSchema that describes it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isDescribedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#isDescribedBy">http://www.purl.org/drammar#isDescribedBy</seealso>
    let isDescribedBy = Prefixed_Name(drammar, "isDescribedBy") |> PrefixedName
    /// <summary>
    ///   <para>drammar:isDoneStateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This is the property that connects a process with a particular state, called a
    ///             done state, that holds whether the process has terminated. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isDoneStateOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#isDoneStateOf">http://www.purl.org/drammar#isDoneStateOf</seealso>
    let isDoneStateOf = Prefixed_Name(drammar, "isDoneStateOf") |> PrefixedName
    /// <summary>
    ///   <para>drammar:isEmotionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects an emotion with the agent who feels it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isEmotionOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#isEmotionOf">http://www.purl.org/drammar#isEmotionOf</seealso>
    let isEmotionOf = Prefixed_Name(drammar, "isEmotionOf") |> PrefixedName
    /// <summary>
    ///   <para>drammar:isExtRefOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isExtRefOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#isExtRefOf">http://www.purl.org/drammar#isExtRefOf</seealso>
    let isExtRefOf = Prefixed_Name(drammar, "isExtRefOf") |> PrefixedName

    /// <summary>
    ///   <para>drammar:isExtRefRoleOfExtRefSchema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property chain serves the purpose of connecting a frame role with the
    ///             frame it belongs to, via the following property chain: isExtRefOf o isRoleOf o hasExtRef
    ///             where - isExtRefOf connects ExtRefRole to Role - isRoleOf connects Role to ProcessSchema
    ///             - hasExtRef connects ProcessSchema to ExtRefSchema (remember that the actual reference
    ///             to the frame or frame role in an external resources are dealt with by attaching a
    ///             "quale" data property to the classes that represent the external
    ///             references)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isExtRefRoleOfExtRefSchema"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#isExtRefRoleOfExtRefSchema">http://www.purl.org/drammar#isExtRefRoleOfExtRefSchema</seealso>
    let isExtRefRoleOfExtRefSchema =
        Prefixed_Name(drammar, "isExtRefRoleOfExtRefSchema") |> PrefixedName

    /// <summary>
    ///   <para>drammar:isFillerOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>"Connects some DramaEndurant or Perdurant to a Role in a
    ///             SituationSchema"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isFillerOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#isFillerOf">http://www.purl.org/drammar#isFillerOf</seealso>
    let isFillerOf = Prefixed_Name(drammar, "isFillerOf") |> PrefixedName
    /// <summary>
    ///   <para>drammar:isGoalOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"inverse of hasGoal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isGoalOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#isGoalOf">http://www.purl.org/drammar#isGoalOf</seealso>
    let isGoalOf = Prefixed_Name(drammar, "isGoalOf") |> PrefixedName
    /// <summary>
    ///   <para>drammar:isHingedOnBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of hingesOn."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isHingedOnBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#isHingedOnBy">http://www.purl.org/drammar#isHingedOnBy</seealso>
    let isHingedOnBy = Prefixed_Name(drammar, "isHingedOnBy") |> PrefixedName
    /// <summary>
    ///   <para>drammar:isIntendedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of intends."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isIntendedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#isIntendedBy">http://www.purl.org/drammar#isIntendedBy</seealso>
    let isIntendedBy = Prefixed_Name(drammar, "isIntendedBy") |> PrefixedName
    /// <summary>
    ///   <para>drammar:isIntentional</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Boolean property for Intentionality of processes. Applies to Processes to
    ///             distinguish Action from an UnintentionalProcess."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isIntentional"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#isIntentional">http://www.purl.org/drammar#isIntentional</seealso>
    let isIntentional = Prefixed_Name(drammar, "isIntentional") |> PrefixedName
    /// <summary>
    ///   <para>drammar:isKnownBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isKnownBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#isKnownBy">http://www.purl.org/drammar#isKnownBy</seealso>
    let isKnownBy = Prefixed_Name(drammar, "isKnownBy") |> PrefixedName
    /// <summary>
    ///   <para>drammar:isMemberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isMemberOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#isMemberOf">http://www.purl.org/drammar#isMemberOf</seealso>
    let isMemberOf = Prefixed_Name(drammar, "isMemberOf") |> PrefixedName
    /// <summary>
    ///   <para>drammar:isMentalStateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isMentalStateOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#isMentalStateOf">http://www.purl.org/drammar#isMentalStateOf</seealso>
    let isMentalStateOf = Prefixed_Name(drammar, "isMentalStateOf") |> PrefixedName
    /// <summary>
    ///   <para>drammar:isMotivationFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"A plan is the motivation for a timeline, namely for a list of units containing
    ///             actions. This property is functional: so, a plan can motivate only a timeline. Notice
    ///             that this implies that a plan cannot motivate the same timeline motivated by a sub-plan,
    ///             and that a plan cannot motivate the same timeline motivated by a more abstract plan. Of
    ///             course, the fact that this property is functional does not imply that a single timeline
    ///             cannot be motivated by more plans."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isMotivationFor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#isMotivationFor">http://www.purl.org/drammar#isMotivationFor</seealso>
    let isMotivationFor = Prefixed_Name(drammar, "isMotivationFor") |> PrefixedName
    /// <summary>
    ///   <para>drammar:isOLEContained</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Connects the element of an ordered list to the ordered list."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isOleContained"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#isOLEContained">http://www.purl.org/drammar#isOLEContained</seealso>
    let isOLEContained = Prefixed_Name(drammar, "isOLEContained") |> PrefixedName
    /// <summary>
    ///   <para>drammar:isOrderedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isOrderedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#isOrderedBy">http://www.purl.org/drammar#isOrderedBy</seealso>
    let isOrderedBy = Prefixed_Name(drammar, "isOrderedBy") |> PrefixedName
    /// <summary>
    ///   <para>drammar:isPlanEffectOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isPlanEffectOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#isPlanEffectOf">http://www.purl.org/drammar#isPlanEffectOf</seealso>
    let isPlanEffectOf = Prefixed_Name(drammar, "isPlanEffectOf") |> PrefixedName

    /// <summary>
    ///   <para>drammar:isPlanPreconditionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isPlanPreconditionOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#isPlanPreconditionOf">http://www.purl.org/drammar#isPlanPreconditionOf</seealso>
    let isPlanPreconditionOf =
        Prefixed_Name(drammar, "isPlanPreconditionOf") |> PrefixedName

    /// <summary>
    ///   <para>drammar:isPropositionalContentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Inverse of hasPropositionalContent. It links a BeliefSchema or a GoalSchema to
    ///             a State or Process."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isPropositionalContentOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#isPropositionalContentOf">http://www.purl.org/drammar#isPropositionalContentOf</seealso>
    let isPropositionalContentOf =
        Prefixed_Name(drammar, "isPropositionalContentOf") |> PrefixedName

    /// <summary>
    ///   <para>drammar:isRoleOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isRoleOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#isRoleOf">http://www.purl.org/drammar#isRoleOf</seealso>
    let isRoleOf = Prefixed_Name(drammar, "isRoleOf") |> PrefixedName
    /// <summary>
    ///   <para>drammar:isSpannedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"isSpannedBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#isSpannedBy">http://www.purl.org/drammar#isSpannedBy</seealso>
    let isSpannedBy = Prefixed_Name(drammar, "isSpannedBy") |> PrefixedName

    /// <summary>
    ///   <para>drammar:isTimelineEffectOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"isTimelineEffectOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#isTimelineEffectOf">http://www.purl.org/drammar#isTimelineEffectOf</seealso>
    let isTimelineEffectOf =
        Prefixed_Name(drammar, "isTimelineEffectOf") |> PrefixedName

    /// <summary>
    ///   <para>drammar:isTimelinePreconditionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isTimelinePreconditionOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#isTimelinePreconditionOf">http://www.purl.org/drammar#isTimelinePreconditionOf</seealso>
    let isTimelinePreconditionOf =
        Prefixed_Name(drammar, "isTimelinePreconditionOf") |> PrefixedName

    /// <summary>
    ///   <para>drammar:isValueEngagedOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isValueEngagedOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#isValueEngagedOf">http://www.purl.org/drammar#isValueEngagedOf</seealso>
    let isValueEngagedOf = Prefixed_Name(drammar, "isValueEngagedOf") |> PrefixedName
    /// <summary>
    ///   <para>drammar:knows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property of an agent, who BELIEVES a Belief (a mental state with a
    ///             propositional content). BELIEVES = KNOWS."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"knows"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#knows">http://www.purl.org/drammar#knows</seealso>
    let knows = Prefixed_Name(drammar, "knows") |> PrefixedName

    /// <summary>
    ///   <para>drammar:love_appraisingAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"love_appraisingAgent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#love_appraisingAgent">http://www.purl.org/drammar#love_appraisingAgent</seealso>
    let love_appraisingAgent =
        Prefixed_Name(drammar, "love_appraisingAgent") |> PrefixedName

    /// <summary>
    ///   <para>drammar:love_target</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"love_target"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#love_target">http://www.purl.org/drammar#love_target</seealso>
    let love_target = Prefixed_Name(drammar, "love_target") |> PrefixedName
    /// <summary>
    ///   <para>drammar:orders</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Timeline orders Unit."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"orders"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#orders">http://www.purl.org/drammar#orders</seealso>
    let orders = Prefixed_Name(drammar, "orders") |> PrefixedName
    /// <summary>
    ///   <para>drammar:originalTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This is the string originally inserted for searching the URI in the external
    ///             ontology. E.g. "parlare" "eleganza""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"originalTerm"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#originalTerm">http://www.purl.org/drammar#originalTerm</seealso>
    let originalTerm = Prefixed_Name(drammar, "originalTerm") |> PrefixedName
    /// <summary>
    ///   <para>drammar:precedes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Sequential order in an ordered list."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"precedes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#precedes">http://www.purl.org/drammar#precedes</seealso>
    let precedes = Prefixed_Name(drammar, "precedes") |> PrefixedName
    /// <summary>
    ///   <para>drammar:quale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Any quality associated to anything. Its range is a string (if a URI is needed
    ///             to resolve the reference, this is dealt with when processing the annotation) All its
    ///             subproperties are introduced on the basis of some specific annotation task. So, its
    ///             current subproperties refer to FrameNet, VerbNet, YagoSumo, MWN corpora,
    ///             respectively."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"quale"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#quale">http://www.purl.org/drammar#quale</seealso>
    let quale = Prefixed_Name(drammar, "quale") |> PrefixedName
    /// <summary>
    ///   <para>drammar:quale_MWNSense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"quale_MWNSense"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#quale_MWNSense">http://www.purl.org/drammar#quale_MWNSense</seealso>
    let quale_MWNSense = Prefixed_Name(drammar, "quale_MWNSense") |> PrefixedName

    /// <summary>
    ///   <para>drammar:quale_YAGOSUMOConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The range is a concept in YagoSUMO. E.g. &amp;%Speaking+, &amp;%Arriving=,
    ///             these two probably from SUMO;
    ///             http://www.mpii.de/yago/resource/wordnet_bathing_100427853, probably from
    ///             YAGO."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"quale_YAGOSUMOConcept"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#quale_YAGOSUMOConcept">http://www.purl.org/drammar#quale_YAGOSUMOConcept</seealso>
    let quale_YAGOSUMOConcept =
        Prefixed_Name(drammar, "quale_YAGOSUMOConcept") |> PrefixedName

    /// <summary>
    ///   <para>drammar:quale_framenetFrame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property of the ExternalRefSchema links the schema to the frame it
    ///             corresponds to, needed to describe some state or process occurring in drama. The value
    ///             is the ID in Framenet. Currently, in the implementation, it is the string of the number
    ///             of choice in the list of frames returned. E.g. "1""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"quale_framenetFrame"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#quale_framenetFrame">http://www.purl.org/drammar#quale_framenetFrame</seealso>
    let quale_framenetFrame =
        Prefixed_Name(drammar, "quale_framenetFrame") |> PrefixedName

    /// <summary>
    ///   <para>drammar:quale_framenetRoleID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Role_framenetRoleID ID of the role as stated by Framenet. It is the string
    ///             returned through the access to Framenet. The string represent the ID of the Frame
    ///             Element. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"quale_framenetRoleID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#quale_framenetRoleID">http://www.purl.org/drammar#quale_framenetRoleID</seealso>
    let quale_framenetRoleID =
        Prefixed_Name(drammar, "quale_framenetRoleID") |> PrefixedName

    /// <summary>
    ///   <para>drammar:quale_verbnetRoleLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Type of the role as stated by Verbnet. It is the string returned through the
    ///             access to Verbnet. This happens when the access to Framenet fails."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"quale_verbnetRoleLabel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#quale_verbnetRoleLabel">http://www.purl.org/drammar#quale_verbnetRoleLabel</seealso>
    let quale_verbnetRoleLabel =
        Prefixed_Name(drammar, "quale_verbnetRoleLabel") |> PrefixedName

    /// <summary>
    ///   <para>drammar:shame_appraisingAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"shame_appraisingAgent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#shame_appraisingAgent">http://www.purl.org/drammar#shame_appraisingAgent</seealso>
    let shame_appraisingAgent =
        Prefixed_Name(drammar, "shame_appraisingAgent") |> PrefixedName

    /// <summary>
    ///   <para>drammar:shame_target</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"shame_target"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#shame_target">http://www.purl.org/drammar#shame_target</seealso>
    let shame_target = Prefixed_Name(drammar, "shame_target") |> PrefixedName
    /// <summary>
    ///   <para>drammar:spans</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The coincidence relation of a Scene on a Timeline."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"spans"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#spans">http://www.purl.org/drammar#spans</seealso>
    let spans = Prefixed_Name(drammar, "spans") |> PrefixedName
    /// <summary>
    ///   <para>drammar:target</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A generic property for describing the relation of an appraised emotional state
    ///             with the target of the emotion, further articulated into more specific target types for
    ///             each emotion type (see appraisingAgent property)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"target"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.purl.org/drammar#target">http://www.purl.org/drammar#target</seealso>
    let target = Prefixed_Name(drammar, "target") |> PrefixedName
