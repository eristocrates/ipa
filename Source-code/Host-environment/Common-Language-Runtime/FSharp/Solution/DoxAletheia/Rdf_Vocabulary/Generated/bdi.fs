namespace https.w3id.org.fossr.ontology.bdi.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module bdi =
    let _namespace_iri = Namespace_Iri bdi |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:Ontology</para>
    ///   <para>"The BDI Ontology provides a formal framework to model the Belief-Desire-Intention (BDI) architecture for rational agents. It defines key mental states—Beliefs, Desires, and Intentions—and their relationships, capturing the agent’s reasoning, motivation, and commitment to action. Supporting classes include Propositions (content of mental states), Justifications (rationale for mental states), Plans (action sequences for goals), and TimeIntervals (temporal validity of entities).
    ///
    /// Key properties like hasBelief, hasDesire, and hasIntention link agents to mental states, while fulfills, adoptsIntention, and motivatesDesire model dynamic interactions. Temporal properties enable reasoning about time-sensitive states and plans. Axioms ensure consistency, such as disjointness between mental states and domain-specific constraints.
    ///
    /// This ontology supports reasoning, querying, and analysis of agent behaviour, enabling applications in AI, multi-agent systems, and decision support."</para>
    /// labels<para>"Belief-Desire-Intention Ontology"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/">https://w3id.org/fossr/ontology/bdi/</seealso>
    let _prefix_iri = Prefixed_Name(bdi, "") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class :Action represents a concrete activity carried out by an agent within the environment. Unlike :ActionDescription, which models the abstract or planned specification of an activity, :Action captures the actual execution or occurrence of that activity in time and space. Actions may be physical, communicative, or cognitive, and are typically associated with agents, plans, and goals. This class supports the representation of observable behaviours that result from deliberative processes such as planning and intention formation. By distinguishing between action descriptions and executed actions, the ontology enables clear reasoning over the alignment between what was intended and what was performed, supporting traceability, validation, and explanation of agent behaviour."</para>
    /// labels<para>"Action"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/Action">https://w3id.org/fossr/ontology/bdi/Action</seealso>
    let Action = Prefixed_Name(bdi, "Action") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Agent is an autonomous entity capable of perceiving its environment, reasoning about it, and acting upon it to achieve specific goals or objectives. Agents can hold mental states such as beliefs, desires, and intentions, which guide their decision-making processes and interactions with the world. Agents may be individuals, organisations, or artificial systems, depending on the context."</para>
    /// labels<para>"Agent"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/Agent">https://w3id.org/fossr/ontology/bdi/Agent</seealso>
    let Agent = Prefixed_Name(bdi, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/Belief</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Belief class represents the mental state of an agent regarding something that the agent holds to be true. It captures the subjective perception or understanding of the world by an agent, which may or may not align with objective reality. In this ontology, beliefs are modelled as descriptions that connect"</para>
    /// labels<para>"Belief"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/Belief">https://w3id.org/fossr/ontology/bdi/Belief</seealso>
    let Belief = Prefixed_Name(bdi, "Belief") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/BeliefProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"BeliefFormation is the cognitive process through which an agent generates, updates, or modifies beliefs based on perception, inference, or communication with other agents. This process allows agents to maintain a dynamically evolving mental representation of their environment and internal states.
    /// For example, an agent monitoring a public health database initially holds the belief that a disease outbreak is contained. However, upon processing new epidemiological reports, the agent updates its belief to reflect the risk of a wider spread and adjusts its reasoning accordingly."</para>
    /// labels<para>"Belief Formation"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/BeliefProcess">https://w3id.org/fossr/ontology/bdi/BeliefProcess</seealso>
    let BeliefProcess = Prefixed_Name(bdi, "BeliefProcess") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/Desire</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Desire class represents a motivational mental state of an agent, encapsulating what the agent wishes or aspires to bring about in the world. Desires are expressions of preferences or goals, but unlike intentions, they do not imply a commitment to act. Desires serve as the driving force behind an agent’s decision-making process, often interacting with beliefs and intentions to influence behaviour."</para>
    /// labels<para>"Desire"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/Desire">https://w3id.org/fossr/ontology/bdi/Desire</seealso>
    let Desire = Prefixed_Name(bdi, "Desire") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/DesireProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"DesireFormation is the mental process by which an agent generates, modifies, or updates desires based on internal motivations, contextual changes, or interactions with external information sources. This process helps agents structure goal-oriented behaviour before intentions are formed.
    /// For example, a decision-support agent in a climate policy system initially lacks any specific desire regarding renewable energy subsidies. After analysing recent economic and environmental reports, it generates a new desire to advocate for increased subsidies, which may later influence its intentions and actions."</para>
    /// labels<para>"Desire Formation"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/DesireProcess">https://w3id.org/fossr/ontology/bdi/DesireProcess</seealso>
    let DesireProcess = Prefixed_Name(bdi, "DesireProcess") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/Goal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Goal represents a desired state or outcome that an agent aspires to achieve. Goals reflect the agent's motivational preferences but do not imply any commitment to act or the feasibility of achieving them. Goals serve as the foundation for forming intentions when prioritised and deemed actionable.
    ///
    /// A example of goal is: "Learn Python programming.". This goal may later lead to an intention: "I intend to enrol in a Python course."."</para>
    /// labels<para>"Goal"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/Goal">https://w3id.org/fossr/ontology/bdi/Goal</seealso>
    let Goal = Prefixed_Name(bdi, "Goal") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/GoalProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"GoalProcess is the mental process by which an agent generates, refines, or revises goals based on its current desires, beliefs, and contextual conditions. This process bridges the motivational layer of the agent, where desires express general preferences, and the deliberative layer, where  intentions represent committed courses of action. By elaborating and prioritising goals, the GoalProcess determines which desired outcomes are worth pursuing and prepares them for adoption as actionable intentions.
    ///
    /// For example, an agent holding a general desire to improve its programming skills  undergoes a GoalProcess that refines this broad aspiration into a concrete and actionable goal: learning Python programming. This goal may subsequently lead to the formation of an intention: \"I intend to enrol in a Python course.\", triggering the planning of a structured sequence of learning activities."</para>
    /// labels<para>"Goal Process"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/GoalProcess">https://w3id.org/fossr/ontology/bdi/GoalProcess</seealso>
    let GoalProcess = Prefixed_Name(bdi, "GoalProcess") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/Intention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The Intention class represents a deliberative mental state of an agent, characterised by the agent’s commitment to achieving a specific goal or executing a plan. Unlike a desire, which expresses a motivational preference, an intention reflects a higher degree of resolve, where the agent actively decides to pursue the desired outcome.
    ///
    /// Intentions bridge the gap between an agent’s desires and actions, driving goal-oriented behaviour based on the agent’s beliefs about feasibility and circumstances.
    ///
    /// Intentions depend on beliefs about feasibility and current conditions (e.g., "I believe the store is open.").
    /// Intentions emerge from prioritised desires or goals (e.g., "I desire to buy groceries.")."</para>
    /// labels<para>"Intention"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/Intention">https://w3id.org/fossr/ontology/bdi/Intention</seealso>
    let Intention = Prefixed_Name(bdi, "Intention") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/IntentionProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"IntentionFormation is the process by which an agent selects, commits to, and refines intentions based on its desires, available resources, and deliberative reasoning. It determines which desires are pursued as actionable commitments and adapts them as new information emerges.
    /// For example, an autonomous assistant tasked with monitoring policy compliance may develop a desire to verify the implementation of a new regulation. After assessing feasibility and priority, it forms an intention to generate a compliance report, refining it further as new data becomes available."</para>
    /// labels<para>"Intention Formation"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/IntentionProcess">https://w3id.org/fossr/ontology/bdi/IntentionProcess</seealso>
    let IntentionProcess = Prefixed_Name(bdi, "IntentionProcess") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/Justification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A justification is a reason, evidence, or explanation that supports a mental state (e.g., belief, intention). It provides the grounds or basis for a mental state (e.g., why a belief is held or a goal is pursued) and Explains or supports mental states (e.g., "I believe it will rain because the forecast says so"). Justifications are typically agent-specific, reflecting the reasoning or evidence considered by an agent."</para>
    /// labels<para>"Justification"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/Justification">https://w3id.org/fossr/ontology/bdi/Justification</seealso>
    let Justification = Prefixed_Name(bdi, "Justification") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/MentalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"MentalEntity is an abstract class that serves as a unifying concept for representing both mental states and mental processes within an agent's cognitive framework. It provides a high-level categorisation for all entities related to an agent’s reasoning, decision-making, and goal-directed behaviour.
    ///
    /// Mental states, such as Belief, Desire, and Intention, represent the informational and motivational aspects of an agent’s cognition. These states can influence and be influenced by mental processes, such as BeliefFormation, DesireFormation, and IntentionFormation, which govern their generation, modification, and updating over time.
    ///
    /// By structuring mental states and processes under a common superclass, MentalEntity facilitates a coherent representation of cognitive dynamics, supporting interoperability and reasoning within the ontology."</para>
    /// labels<para>"Mental entity"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/MentalEntity">https://w3id.org/fossr/ontology/bdi/MentalEntity</seealso>
    let MentalEntity = Prefixed_Name(bdi, "MentalEntity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/MentalProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class :MentalProcess represents the cognitive operations through which an agent reasons upon, transforms, or generates mental content. It encompasses processes such as belief revision, desire formation, intention refinement, and planning. Each MentalProcess is understood as a type of activity (subclass of d0:Activity) that operates over one or more MentalStates and may lead to the creation, modification, or suppression of new or existing mental entities. For example, an agent may engage in a BeliefProcess that updates its beliefs in response to new perceptions, or perform a Planning process that generates a Plan from a set of intentions. By modelling such cognitive activities explicitly, :MentalProcess enables the ontology to describe not only the states held by agents, but also the reasoning dynamics and deliberative mechanisms that underpin agent behaviour. This class is essential for supporting explainability, simulation, and agent-based modelling of mental state evolution."</para>
    /// labels<para>"Mental Process"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/MentalProcess">https://w3id.org/fossr/ontology/bdi/MentalProcess</seealso>
    let MentalProcess = Prefixed_Name(bdi, "MentalProcess") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/MentalState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A mental state is a conceptual representation of an agent's internal condition, which encompasses beliefs, desires, intentions, emotions, and other cognitive or affective states. It is the foundation of an agent’s reasoning, decision-making, and behaviour. Mental states are dynamic and context-dependent, changing in response to external stimuli, internal deliberations, or interactions with other agents."</para>
    /// labels<para>"Mental state"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/MentalState">https://w3id.org/fossr/ontology/bdi/MentalState</seealso>
    let MentalState = Prefixed_Name(bdi, "MentalState") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/Plan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A plan is a structured sequence of actions or steps devised by an agent to achieve a specific goal or fulfil an intention. It serves as an operational framework that translates an agent’s intentions into actionable strategies, guiding behaviour toward a desired goal."</para>
    /// labels<para>"Plan"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/Plan">https://w3id.org/fossr/ontology/bdi/Plan</seealso>
    let Plan = Prefixed_Name(bdi, "Plan") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/PlanExecution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class :PlanExecution represents the actual enactment of a Plan by an Agent within a specific temporal and environmental context.  While a Plan provides a structured description of actions or steps intended to achieve a Goal, a PlanExecution captures the situated, real-world unfolding of that plan. This includes the execution of actions, interaction with the environment, and the potential influence of contingencies or external events. By modelling PlanExecution explicitly, the ontology supports reasoning over whether, how, and to what extent plans have been carried out, enabling comparisons between intended and actual behaviour. It also provides a foundation for temporal monitoring, traceability, and post-hoc analysis of agent decisions, which is crucial for explainability and accountability in both human and artificial agents."</para>
    /// labels<para>"Plan"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/PlanExecution">https://w3id.org/fossr/ontology/bdi/PlanExecution</seealso>
    let PlanExecution = Prefixed_Name(bdi, "PlanExecution") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/Planning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Planning is the cognitive process through which an agent generates, structures, and organises a sequence of actions to achieve a desired goal. It transforms an agent’s intentions into a concrete plan that can guide execution. This process involves selecting appropriate steps, considering constraints, and adapting the plan based on available information.
    ///
    /// For example, an autonomous agent responsible for disaster response may form the intention to deliver medical supplies to a remote area. Through the Planning process, it determines the optimal route, identifies necessary resources, and structures the sequence of actions required to execute the delivery efficiently."</para>
    /// labels<para>"Planning"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/Planning">https://w3id.org/fossr/ontology/bdi/Planning</seealso>
    let Planning = Prefixed_Name(bdi, "Planning") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/Task</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class :Task represents the abstract specification of an action within a plan. It defines the intended activity an agent should perform, including its purpose, expected effects, preconditions, and any constraints relevant to its execution. Unlike concrete actions or events that occur in the world, a Task is a descriptive construct that guides or informs PlanExecutions. This class enables the ontology to model the internal structure of plans as sequences of intentional steps, supporting reasoning over action dependencies, execution order, and alignment with goals. It is particularly useful for representing deliberative and goal-directed behaviour in agent-based systems."</para>
    /// labels<para>"Task"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/Task">https://w3id.org/fossr/ontology/bdi/Task</seealso>
    let Task = Prefixed_Name(bdi, "Task") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/TemporalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The TemporalEntity class represents a general temporal concept that can be either a specific point in time (instant) or a time span (interval).
    /// This class is useful for modeling events, schedules, and historical data where time-related attributes are essential."</para>
    /// labels<para>"Temporal entity"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/TemporalEntity">https://w3id.org/fossr/ontology/bdi/TemporalEntity</seealso>
    let TemporalEntity = Prefixed_Name(bdi, "TemporalEntity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/TimeInstant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The TimeInstant class represents an exact time. It is used to specify the time when events occur, start and end."</para>
    /// labels<para>"Time istant"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/TimeInstant">https://w3id.org/fossr/ontology/bdi/TimeInstant</seealso>
    let TimeInstant = Prefixed_Name(bdi, "TimeInstant") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/TimeInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The TimeInterval class represents a bounded period of time with a defined start and end. It is used to specify the temporal extent of events, states, or processes."</para>
    /// labels<para>"Time interval"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/TimeInterval">https://w3id.org/fossr/ontology/bdi/TimeInterval</seealso>
    let TimeInterval = Prefixed_Name(bdi, "TimeInterval") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/WorldState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A World state represents a temporally situated condition of the environment as perceived or described by an agent. It captures facts, circumstances, or events that hold at a given time, and serves as the basis upon which agents form their beliefs, generate desires, and adopt intentions. A world state can change over time, be influenced by agents’ actions or external events, and may function as a target outcome for plans aiming to realise a specific goal."</para>
    /// labels<para>"World state"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/WorldState">https://w3id.org/fossr/ontology/bdi/WorldState</seealso>
    let WorldState = Prefixed_Name(bdi, "WorldState") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/addresses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property :addresses links a Plan to the Goal it is intended to fulfil. It captures the teleological nature of planning, where a Plan is not arbitrary but constructed with the explicit purpose of realising a desired state of the world, as described by a Goal. This property formalises the intentional link between planning and goal-oriented behaviour in agents. For example, a Plan to deploy renewable energy subsidies may address a Goal of reducing greenhouse gas emissions. The :addresses relation supports reasoning about the relevance and suitability of plans with respect to their objectives, thereby enabling goal-driven agent behaviour and planning traceability."</para>
    /// labels<para>"addresses"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/addresses">https://w3id.org/fossr/ontology/bdi/addresses</seealso>
    let addresses = Prefixed_Name(bdi, "addresses") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/affects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property affects links a MentalProcess to the MentalState(s)
    /// that it generates, modifies, or suppresses. This property captures the
    /// dynamic aspect of cognition, where mental states do not remain static
    /// but evolve through processes such as BeliefProcessing, DesireProcessing,
    /// and IntentionProcessing. For example, a BeliefProcessing activity may
    /// affect a Belief by updating its content, while an IntentionProcessing
    /// activity may affect an Intention by refining or suppressing it. By
    /// using affects, the ontology provides a uniform mechanism to describe
    /// the causal or transformative impact of mental processes on mental states,
    /// supporting reasoning about the lifecycle of cognitive entities and
    /// enhancing explainability of agent behaviour."</para>
    /// labels<para>"affects"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/affects">https://w3id.org/fossr/ontology/bdi/affects</seealso>
    let affects = Prefixed_Name(bdi, "affects") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/atTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The 'at time' property represents the relationship between a mental entity (such as a belief, desire, or intention) and the temporal entity it produces  or influences. This property is used to model how mental states give rise to time-bound events, processes, or commitments."</para>
    /// labels<para>"at time"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/atTime">https://w3id.org/fossr/ontology/bdi/atTime</seealso>
    let atTime = Prefixed_Name(bdi, "atTime") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/beginsWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property :beginsWith identifies the first element in a structured or ordered sequence. It is used to specify which component marks the starting point of a composite entity such as a plan. This property enables the ontology to model linear or sequential structures with clear entry points, which is essential for temporal reasoning, execution tracing, and validating ordering constraints. For example, a Plan may :beginsWith a specific ActionDescription, indicating the first step to be performed. The property is particularly useful in contexts where ordering, precedence, or flow control must be explicitly represented."</para>
    /// labels<para>"begins with"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/beginsWith">https://w3id.org/fossr/ontology/bdi/beginsWith</seealso>
    let beginsWith = Prefixed_Name(bdi, "beginsWith") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/bringsAbout</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property :bringsAbout links a PlanExecution or an Action to the resulting WorldState it produces, modifies, or realises. It models the causal effect that executing a plan has on the environment, enabling reasoning about how agent actions lead to specific changes in the world. This property supports traceability from intentional behaviour to outcomes, and is essential for representing goal achievement, environmental dynamics, and the effects of decision-making over time."</para>
    /// labels<para>"brings about"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/bringsAbout">https://w3id.org/fossr/ontology/bdi/bringsAbout</seealso>
    let bringsAbout = Prefixed_Name(bdi, "bringsAbout") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/cognises</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property :cognises links an Agent to a MentalEntity, capturing the act of mentally entertaining, holding, or being aware of a cognitive entity. It is intended as a general relation that covers different types of propositional attitudes, such as believing, desiring, or intending, without reducing them to specific cases. For example, when an agent has a Belief, a Desire, or an Intention, this can be represented as the agent :cognises the corresponding MentalEntity. Similarly, an agent may cognise a MentalProcess, such as a deliberation or planning activity, that structures its reasoning. By introducing :cognises, the ontology provides a unifying mechanism for relating agents to the mental entities they hold, enabling reasoning across different types of cognitive states and processes while preserving the intentional dimension of cognition."</para>
    /// labels<para>"cognises"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/cognises">https://w3id.org/fossr/ontology/bdi/cognises</seealso>
    let cognises = Prefixed_Name(bdi, "cognises") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/defines</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a Planning entity to one or more Plans, defining the structured actions an agent intends to execute to fulfill its intentions."</para>
    /// labels<para>"defines"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/defines">https://w3id.org/fossr/ontology/bdi/defines</seealso>
    let defines = Prefixed_Name(bdi, "defines") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/endsWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property :endsWith identifies the last element in a structured or ordered sequence. It is used to specify which component marks the ending point of a composite entity such as a plan. This property enables the ontology to model linear or sequential structures with clear entry points, which is essential for temporal reasoning, execution tracing, and validating ordering constraints. For example, a Plan may :endsWith a specific ActionDescription, indicating the last step to be performed. The property is particularly useful in contexts where ordering, precedence, or flow control must be explicitly represented."</para>
    /// labels<para>"ends with"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/endsWith">https://w3id.org/fossr/ontology/bdi/endsWith</seealso>
    let endsWith = Prefixed_Name(bdi, "endsWith") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/executes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property :executes links an Agent to a PlanExecution, indicating that the agent is responsible for carrying out a specific instance of plan enactment. This property captures the realisation of an intended course of action, as described by a Plan, in the external world by the agent. For example, if an agent has committed to a plan for implementing a new policy, the actual execution of that plan is connected to the agent through :executes. This relation is essential for modelling the transition from intention to action and for enabling traceability and accountability of agent behaviour."</para>
    /// labels<para>"executes"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/executes">https://w3id.org/fossr/ontology/bdi/executes</seealso>
    let executes = Prefixed_Name(bdi, "executes") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/follows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property :follows represents a temporal or logical ordering between two entities, where the subject is understood to occur or be positioned after the object. This property is transitive, allowing the expression of sequences in which multiple elements are ordered, such as actions within a plan, events in a process, or reasoning steps in a cognitive sequence. For example, in a plan composed of ordered actions, one ActionDescription may :follows another to indicate that it should be performed subsequently. This property supports temporal reasoning, process traceability, and structural consistency within ordered models."</para>
    /// labels<para>"follows"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/follows">https://w3id.org/fossr/ontology/bdi/follows</seealso>
    let follows = Prefixed_Name(bdi, "follows") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/fulfills</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The fulfills property links an entity, such as an intention or a plan, to the goal it is designed to achieve. It represents the relationship between an agent's commitment or strategy and the desired outcome."</para>
    /// labels<para>"fulfills"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/fulfills">https://w3id.org/fossr/ontology/bdi/fulfills</seealso>
    let fulfills = Prefixed_Name(bdi, "fulfills") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/generates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property generates is a subproperty of :affects and captures
    /// the relation between a MentalProcess and a newly created MentalState.
    /// It is used when a cognitive process results in the formation of a
    /// previously non-existent state, such as the generation of a new Belief
    /// after perceiving a WorldState, the creation of a new Desire in response
    /// to a motivational factor, or the commitment to a new Intention during
    /// deliberation. This property explicitly models the generative aspect of
    /// cognition, ensuring that the ontology can represent the emergence of
    /// mental states as part of an agent's reasoning dynamics."</para>
    /// labels<para>"generates"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/generates">https://w3id.org/fossr/ontology/bdi/generates</seealso>
    let generates = Prefixed_Name(bdi, "generates") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/hasBelief</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The hasBelief property links an agent to the belief(s) they hold, representing the agent’s informational state about the world."</para>
    /// labels<para>"has belief"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/hasBelief">https://w3id.org/fossr/ontology/bdi/hasBelief</seealso>
    let hasBelief = Prefixed_Name(bdi, "hasBelief") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/hasBeliefProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/hasBeliefProcess">https://w3id.org/fossr/ontology/bdi/hasBeliefProcess</seealso>
    let hasBeliefProcess = Prefixed_Name(bdi, "hasBeliefProcess") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/hasComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property :hasComponent expresses a compositional relationship in which the subject entity includes the object as one of its components. It is used to model structural or functional parts that collectively form a more complex whole, allowing flexible representation of modular systems, compound entities, or hierarchical structures. This property applies broadly to both physical and abstract entities, such as a plan composed of multiple action descriptions, or a mental model composed of interrelated mental states. The use of :hasComponent supports reasoning over part-whole dependencies, system decomposition, and modular analysis."</para>
    /// labels<para>"has component"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/hasComponent">https://w3id.org/fossr/ontology/bdi/hasComponent</seealso>
    let hasComponent = Prefixed_Name(bdi, "hasComponent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/hasDesire</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The hasDesire property links an agent to the desire(s) they aspire to achieve, representing the agent’s motivational preferences."</para>
    /// labels<para>"has desire"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/hasDesire">https://w3id.org/fossr/ontology/bdi/hasDesire</seealso>
    let hasDesire = Prefixed_Name(bdi, "hasDesire") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/hasDesireProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/hasDesireProcess">https://w3id.org/fossr/ontology/bdi/hasDesireProcess</seealso>
    let hasDesireProcess = Prefixed_Name(bdi, "hasDesireProcess") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/hasEndTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Defines the temporal istant by specifying when a TimeInterval concludes. This is essential for modeling the execution timeframe of an agent’s plans, actions, or mental states."</para>
    /// labels<para>"has end time"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/hasEndTime">https://w3id.org/fossr/ontology/bdi/hasEndTime</seealso>
    let hasEndTime = Prefixed_Name(bdi, "hasEndTime") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/hasIntention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The hasIntention property links an agent to the intention(s) they commit to, representing the agent’s deliberative state for action."</para>
    /// labels<para>"has intention"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/hasIntention">https://w3id.org/fossr/ontology/bdi/hasIntention</seealso>
    let hasIntention = Prefixed_Name(bdi, "hasIntention") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/hasIntentionProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/hasIntentionProcess">https://w3id.org/fossr/ontology/bdi/hasIntentionProcess</seealso>
    let hasIntentionProcess = Prefixed_Name(bdi, "hasIntentionProcess") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/hasMentalProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""The hasMentalProcess property is an object property that links an agent to one or more of its mental process, such as beliefs formation, desires formation, or intentions formation. It establishes a relationship between the agent (as the holder of mental process) and the abstract representations of those states, enabling changing the agent's mental state."</para>
    /// labels<para>"has mental process"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/hasMentalProcess">https://w3id.org/fossr/ontology/bdi/hasMentalProcess</seealso>
    let hasMentalProcess = Prefixed_Name(bdi, "hasMentalProcess") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/hasMentalState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"has mental state"</para>
    ///   <para>"The hasMentalState property is an object property that links an agent to one or more of its mental states, such as beliefs, desires, or intentions. It establishes a relationship between the agent (as the holder of mental states) and the abstract representations of those states, enabling reasoning about the agent's internal cognitive or motivational processes."</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/hasMentalState">https://w3id.org/fossr/ontology/bdi/hasMentalState</seealso>
    let hasMentalState = Prefixed_Name(bdi, "hasMentalState") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/hasPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:ReflexiveProperty</para>
    ///   <para>"The object property hasPart formalises meronymic (part–whole) relations among mental entities. It is used to represent the fact that complex mental constructs—whether mental states or mental processes—can be decomposed into constituent parts. This allows the ontology to capture the compositional structure of cognition: for example, a Belief may have parts corresponding to different propositional components (e.g., time, location, agent), or a PlanningProcess may have parts representing successive reasoning steps. By asserting :hasPart relations, mental entities need not be treated as atomic, but can instead be modelled as structured and analyzable wholes, thereby supporting fine-grained reasoning, updates to specific components, and richer forms of explainability. The inverse relation of hasPart is partOf."</para>
    /// labels<para>"has part"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/hasPart">https://w3id.org/fossr/ontology/bdi/hasPart</seealso>
    let hasPart = Prefixed_Name(bdi, "hasPart") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/hasPlanning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/hasPlanning">https://w3id.org/fossr/ontology/bdi/hasPlanning</seealso>
    let hasPlanning = Prefixed_Name(bdi, "hasPlanning") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/hasStartTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Defines the temporal istant by specifying when a TimeInterval starts. This is essential for modeling the execution timeframe of an agent’s plans, actions, or mental states."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has start time"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/hasStartTime">https://w3id.org/fossr/ontology/bdi/hasStartTime</seealso>
    let hasStartTime = Prefixed_Name(bdi, "hasStartTime") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/hasValidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The hasValidity property links an entity to a TemporalEntity during which it is valid, active, or applicable. This property represents the temporal scope or extent of the entity's relevance or operation."</para>
    /// labels<para>"has temporal validity"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/hasValidity">https://w3id.org/fossr/ontology/bdi/hasValidity</seealso>
    let hasValidity = Prefixed_Name(bdi, "hasValidity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/isAddressedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property :isAddressedBy is the inverse of :addresses and links a Goal to the Plan(s) designed to fulfil it. This property allows reasoning from the perspective of goals, enabling identification of the plans formulated to achieve a given objective. For instance, a Goal such as ensuring public health safety may be :isAddressedBy multiple Plans representing different intervention strategies. The property supports goal monitoring, plan evaluation, and comparative analysis of alternative courses of action, facilitating transparency and justification in goal-oriented agent behaviour."</para>
    /// labels<para>"is addressed by"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/isAddressedBy">https://w3id.org/fossr/ontology/bdi/isAddressedBy</seealso>
    let isAddressedBy = Prefixed_Name(bdi, "isAddressedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/isAffectedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is affected by"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/isAffectedBy">https://w3id.org/fossr/ontology/bdi/isAffectedBy</seealso>
    let isAffectedBy = Prefixed_Name(bdi, "isAffectedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/isBeliefOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The isBeliefOf property links a belief to the agent that holds it."</para>
    /// labels<para>"is belief of"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/isBeliefOf">https://w3id.org/fossr/ontology/bdi/isBeliefOf</seealso>
    let isBeliefOf = Prefixed_Name(bdi, "isBeliefOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/isBeliefProcessOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/isBeliefProcessOf">https://w3id.org/fossr/ontology/bdi/isBeliefProcessOf</seealso>
    let isBeliefProcessOf = Prefixed_Name(bdi, "isBeliefProcessOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/isCognisedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property :isCognisedBy is the inverse of :cognises. It links a MentalEntity to the Agent that entertains, holds, or is aware of it. This property makes explicit which agent is associated with a given mental entity, such as a Belief, Desire, Intention, or MentalProcess. For example, a Belief that 'the meeting is cancelled' may be :isCognisedBy an agent who holds that belief, while a Plan or Intention may be :isCognisedBy the agent that commits to it. This property is essential for reasoning from the perspective of mental entities, as it allows the ontology to trace mental content back to its cognitive bearer. Together with :cognises, it supports explainability by showing both the mental states an agent holds and the agents that cognise specific mental entities."</para>
    /// labels<para>"is cognised by"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/isCognisedBy">https://w3id.org/fossr/ontology/bdi/isCognisedBy</seealso>
    let isCognisedBy = Prefixed_Name(bdi, "isCognisedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/isComponentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>"The object property :isComponentOf is the inverse of :hasComponent and denotes that the subject entity functions as a component within a larger structure or system. It captures part-to-whole relationships in various contexts, such as an action step being part of a plan. This property facilitates structural reasoning, enabling the identification of higher-level entities to which a given component belongs. It is particularly useful for representing hierarchical, modular, or compositional models in both cognitive and operational domains."</para>
    /// labels<para>"is component of"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/isComponentOf">https://w3id.org/fossr/ontology/bdi/isComponentOf</seealso>
    let isComponentOf = Prefixed_Name(bdi, "isComponentOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/isDefinedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that a Plan instance is defined by a specific Planning entity."</para>
    /// labels<para>"is defined by"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/isDefinedBy">https://w3id.org/fossr/ontology/bdi/isDefinedBy</seealso>
    let isDefinedBy = Prefixed_Name(bdi, "isDefinedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/isDesireOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The isDesireOf property links a desire to the agent that holds it."</para>
    /// labels<para>"is desire of"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/isDesireOf">https://w3id.org/fossr/ontology/bdi/isDesireOf</seealso>
    let isDesireOf = Prefixed_Name(bdi, "isDesireOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/isDesireProcessOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/isDesireProcessOf">https://w3id.org/fossr/ontology/bdi/isDesireProcessOf</seealso>
    let isDesireProcessOf = Prefixed_Name(bdi, "isDesireProcessOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/isExecutedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property :isExecutedBy is the inverse of :executes and connects a PlanExecution to the Agent that performs it. It specifies who is enacting a particular plan in a given context. This property is crucial for understanding who is operationally responsible for turning a plan into action, allowing the ontology to support explanations of observed behaviours, audit processes, and verification of agent compliance. For instance, a PlanExecution aimed at deploying a new system may be :isExecutedBy the agent tasked with implementing it."</para>
    /// labels<para>"is executed by"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/isExecutedBy">https://w3id.org/fossr/ontology/bdi/isExecutedBy</seealso>
    let isExecutedBy = Prefixed_Name(bdi, "isExecutedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/isFulfilledBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The isFulfilledBy property is the inverse of fulfills. It links a goal to the intention(s) or plan(s) that are committed to or designed to achieve it. This property enables reasoning from the perspective of goals to identify the entities working toward their fulfilment."</para>
    ///   <para>"is fulfilled by"</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/isFulfilledBy">https://w3id.org/fossr/ontology/bdi/isFulfilledBy</seealso>
    let isFulfilledBy = Prefixed_Name(bdi, "isFulfilledBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/isGeneratedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property :isGeneratedBy is the inverse of :generates. It links a MentalState to the MentalProcess that created it. This property enables reasoning over the origin of mental states, supporting explainability and traceability of cognitive dynamics. For example, a Belief may be :isGeneratedBy a BeliefProcessing activity triggered by the perception of a WorldState, while an Intention may be :isGeneratedBy an IntentionProcessing activity that selected a Desire for commitment. By modelling generative origins explicitly, the ontology provides mechanisms for explaining why and how specific mental states come into existence."</para>
    /// labels<para>"is generated by"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/isGeneratedBy">https://w3id.org/fossr/ontology/bdi/isGeneratedBy</seealso>
    let isGeneratedBy = Prefixed_Name(bdi, "isGeneratedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/isIntentionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The isIntentionOf property links an intention to the agent that holds it."</para>
    /// labels<para>"is intention of"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/isIntentionOf">https://w3id.org/fossr/ontology/bdi/isIntentionOf</seealso>
    let isIntentionOf = Prefixed_Name(bdi, "isIntentionOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/isIntentionProcessOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/isIntentionProcessOf">https://w3id.org/fossr/ontology/bdi/isIntentionProcessOf</seealso>
    let isIntentionProcessOf =
        Prefixed_Name(bdi, "isIntentionProcessOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/isJustifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The isJustifiedBy property is the inverse of justifies. It links a mental entity to the justification(s) that support it, enabling reasoning about the basis for the mental entity."</para>
    /// labels<para>"is justified by"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/isJustifiedBy">https://w3id.org/fossr/ontology/bdi/isJustifiedBy</seealso>
    let isJustifiedBy = Prefixed_Name(bdi, "isJustifiedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/isMentalProcessOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The isMentalProcessOf property is the inverse object property of hasMentalProcess. It links a mental priocess (such as a belief formation, desire formation, or intentio formationn) to the agent that holds it. This property allows for reasoning and querying in the opposite direction, starting from a mental process and identifying the associated agent."</para>
    /// labels<para>"is mental process of"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/isMentalProcessOf">https://w3id.org/fossr/ontology/bdi/isMentalProcessOf</seealso>
    let isMentalProcessOf = Prefixed_Name(bdi, "isMentalProcessOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/isMentalStateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The isMentalStateOf property is the inverse object property of hasMentalState. It links a mental state (such as a belief, desire, or intention) to the agent that holds it. This property allows for reasoning and querying in the opposite direction, starting from a mental state and identifying the associated agent."</para>
    /// labels<para>"is mental state of"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/isMentalStateOf">https://w3id.org/fossr/ontology/bdi/isMentalStateOf</seealso>
    let isMentalStateOf = Prefixed_Name(bdi, "isMentalStateOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/isModifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property :isModifiedBy is the inverse of :modifies. It links a MentalState to the MentalProcess that has altered it. This property is used to capture the history of changes that a mental state undergoes over time, such as updates, refinements, or adjustments. For instance, a Desire may be :isModifiedBy a DesireProcessing activity that adjusts its priority, or a Belief may be :isModifiedBy a BeliefProcessing activity that incorporates new evidence. The property ensures that modifications to cognitive states can be explicitly represented and traced for purposes of explainability and reasoning about cognitive dynamics."</para>
    /// labels<para>"is modified by"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/isModifiedBy">https://w3id.org/fossr/ontology/bdi/isModifiedBy</seealso>
    let isModifiedBy = Prefixed_Name(bdi, "isModifiedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/isMotivatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The isDesireMotivatedBy property is the inverse of motivatesDesire. It links a desire to the belief(s) that provide the motivational basis for its formation. This property captures the relationship where a belief influences an agent to form or hold a specific desire."</para>
    /// labels<para>"is desire motivated by"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/isMotivatedBy">https://w3id.org/fossr/ontology/bdi/isMotivatedBy</seealso>
    let isMotivatedBy = Prefixed_Name(bdi, "isMotivatedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/isPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:ReflexiveProperty</para>
    ///   <para>"The object property isPartOf represents the inverse of hasPart,
    /// capturing the fact that a mental entity is a constituent part of another
    /// mental entity. This property supports reasoning over hierarchical and
    /// compositional structures of cognition: for example, a propositional
    /// component may be part of a complex Belief, or a reasoning step may be
    /// part of a broader PlanningProcess. The use of isPartOf allows the ontology
    /// to reconstruct the larger cognitive structures to which a mental entity
    /// belongs, complementing the decomposition enabled by hasPart."</para>
    /// labels<para>"is part of"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/isPartOf">https://w3id.org/fossr/ontology/bdi/isPartOf</seealso>
    let isPartOf = Prefixed_Name(bdi, "isPartOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/isPerceivedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property isPerceivedBy links a WorldState to an Agent,  indicating that the state of the world is perceived by that agent. This property allows world states to be contextualised with respect to specific agents, supporting reasoning about which agents have knowledge of, or awareness of, a given condition in the environment. For example, a WorldState describing 'the room is cold' may be
    /// :isPerceivedBy an agent, which in turn can generate corresponding beliefs, desires, or intentions. This property is the inverse of perceives."</para>
    /// labels<para>"is perceived by"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/isPerceivedBy">https://w3id.org/fossr/ontology/bdi/isPerceivedBy</seealso>
    let isPerceivedBy = Prefixed_Name(bdi, "isPerceivedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/isPlanningOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/isPlanningOf">https://w3id.org/fossr/ontology/bdi/isPlanningOf</seealso>
    let isPlanningOf = Prefixed_Name(bdi, "isPlanningOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/isProcessedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that a MentalProcess is performed or carried out by a specific Agent as part of its cognitive activities"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is processed by"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/isProcessedBy">https://w3id.org/fossr/ontology/bdi/isProcessedBy</seealso>
    let isProcessedBy = Prefixed_Name(bdi, "isProcessedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/isReasonedUponBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property :isReasonedUponBy is the inverse of :reasonsUpon. It links a MentalState to the MentalProcess that uses it as input for cognitive deliberation or transformation. This property supports reasoning from the perspective of the mental state, enabling the ontology to answer questions suc as which processes have operated on a given belief, desire, or intention. For example, a Desire may be :isReasonedUponBy an IntentionProcess that evaluates its feasibility and selects it for commitment. The property plays a key role in making explicit the dependency chains within an agent’s reasoning process, thus enhancing explainability and traceability of cognitive dynamics."</para>
    /// labels<para>"is reasoned upon by"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/isReasonedUponBy">https://w3id.org/fossr/ontology/bdi/isReasonedUponBy</seealso>
    let isReasonedUponBy = Prefixed_Name(bdi, "isReasonedUponBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/isReferredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property isReferredBy is defined as the inverse of :refersTo. It links a WorldState to the MentalEntities (beliefs, desires, intentions) that are directed toward it. This property is useful for tracing how a given world state is cognitively represented across different agents, thereby enabling reasoning over shared beliefs, conflicting desires, or multiple intentions that concern the same state of affairs."</para>
    /// labels<para>"is referred by"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/isReferredBy">https://w3id.org/fossr/ontology/bdi/isReferredBy</seealso>
    let isReferredBy = Prefixed_Name(bdi, "isReferredBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/isSatisfiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property :isSatisfiedBy links a Plan to its corresponding PlanExecution, representing the realisation of the plan in a concrete, time-bounded context. While a Plan describes a structured set of intended actions aimed at achieving a Goal, the PlanExecution represents the actual enactment of that plan by an agent. This property allows the ontology to trace how abstract intentions are translated into actions, enabling reasoning over whether and how a plan has been carried out. For example, a Plan for emergency response may have an associated PlanExecution that occurred during a specific crisis scenario. The :isSatisfiedBy relation supports temporal monitoring, evaluation, and explanation of agent behaviour."</para>
    /// labels<para>"is satisfied by"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/isSatisfiedBy">https://w3id.org/fossr/ontology/bdi/isSatisfiedBy</seealso>
    let isSatisfiedBy = Prefixed_Name(bdi, "isSatisfiedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/isSpecifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The isSpecifiedBy property is the inverse of specifiesPlan. It links a plan to the intention it is designed to fulfil, enabling reasoning about the motivational context behind the plan."</para>
    /// labels<para>"is specified by"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/isSpecifiedBy">https://w3id.org/fossr/ontology/bdi/isSpecifiedBy</seealso>
    let isSpecifiedBy = Prefixed_Name(bdi, "isSpecifiedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/isSupportedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The isIntentionSupportedBy property is the inverse of supportsIntention. It links an intention to the belief(s) that justify or support the agent’s decision to pursue it."</para>
    /// labels<para>"is intention supported by"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/isSupportedBy">https://w3id.org/fossr/ontology/bdi/isSupportedBy</seealso>
    let isSupportedBy = Prefixed_Name(bdi, "isSupportedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/isSuppressedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property :isSuppressedBy is the inverse of :suppresses. It links a MentalState to the MentalProcess that deactivated, abandoned, or removed it from the agent’s active repertoire. This property is particularly important for modelling cognitive adaptability, where agents discard outdated beliefs, abandon unfeasible desires, or drop intentions that are no longer relevant. For example, a Belief may be :isSuppressedBy a BeliefProcessing activity invalidating it, or an Intention may be :isSuppressedBy an IntentionProcessing activity that reprioritises goals. By making suppression explicit, the ontology can represent the disappearance of mental states and support reasoning about why they ceased to influence agent behaviour."</para>
    /// labels<para>"is suppressed by"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/isSuppressedBy">https://w3id.org/fossr/ontology/bdi/isSuppressedBy</seealso>
    let isSuppressedBy = Prefixed_Name(bdi, "isSuppressedBy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/isTemporalValidityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The isTemporalValidityOf property is the inverse of hasTemporalValidity. It links a TimeInterval to the entity it defines the temporal validity for, specifying the time period during which the entity is active or applicable."</para>
    /// labels<para>"is temporal validity of"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/isTemporalValidityOf">https://w3id.org/fossr/ontology/bdi/isTemporalValidityOf</seealso>
    let isTemporalValidityOf =
        Prefixed_Name(bdi, "isTemporalValidityOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/isTriggeredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that a MentalProcess is initiated or caused by a specific mental entity, leading to a modification in the agent’s cognitive state."</para>
    /// labels<para>"is triggered by"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/isTriggeredBy">https://w3id.org/fossr/ontology/bdi/isTriggeredBy</seealso>
    let isTriggeredBy = Prefixed_Name(bdi, "isTriggeredBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/justifies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The justifies property links a justification to the mental entity it supports, providing the rationale, evidence, or explanation for why the mental entity is held."</para>
    /// labels<para>"justifies"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/justifies">https://w3id.org/fossr/ontology/bdi/justifies</seealso>
    let justifies = Prefixed_Name(bdi, "justifies") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/modifies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property modifies is a subproperty of :affects and describes
    /// the relation between a MentalProcess and an existing MentalState whose
    /// content or structure is altered by the process. Modification can involve
    /// refinement, enrichment, or updating of a state in light of new information,
    /// constraints, or deliberative reasoning. For example, a BeliefProcessing
    /// activity may modify a Belief when new evidence is integrated, or an
    /// IntentionProcessing activity may modify an Intention by refining its
    /// scope or adjusting its temporal constraints. This property reflects the
    /// fact that mental states are dynamic entities subject to continual revision."</para>
    /// labels<para>"modifies"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/modifies">https://w3id.org/fossr/ontology/bdi/modifies</seealso>
    let modifies = Prefixed_Name(bdi, "modifies") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/motivates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Beliefs often influence or motivate the formation of desires. For example, if an agent believes that exercising improves health, this belief may motivate a desire to exercise."</para>
    /// labels<para>"motivates desire"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/motivates">https://w3id.org/fossr/ontology/bdi/motivates</seealso>
    let motivates = Prefixed_Name(bdi, "motivates") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/perceives</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property perceives links an Agent to a WorldState,  representing the act of perceiving or becoming aware of a state of the world. This property captures the epistemic grounding of beliefs: an agent's mental states are often derived from, or justified by, the world states it perceives. The relation is intended to model the cognitive act of perception in a broad sense, encompassing direct sensory input, mediated observations, or information received through communication. By asserting that an Agent :perceives a WorldState, the ontology enables reasoning over how mental entities such as beliefs are anchored in external conditions. This property is the inverse of isPerceivedBy."</para>
    /// labels<para>"perceives"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/perceives">https://w3id.org/fossr/ontology/bdi/perceives</seealso>
    let perceives = Prefixed_Name(bdi, "perceives") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/precedes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"The object property :precedes is the inverse of :follows and indicates that the subject occurs or is intended to occur before the object. It captures the precedence relation between entities, such as actions, events, or cognitive steps. This property is useful for representing structured sequences where the ordering of components is essential to understanding the process or plan. For example, one ActionDescription may :precedes another to define execution order. Used in combination with :follows, this property enables flexible modelling and reasoning over ordered structures in both physical and cognitive domains."</para>
    /// labels<para>"precedes"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/precedes">https://w3id.org/fossr/ontology/bdi/precedes</seealso>
    let precedes = Prefixed_Name(bdi, "precedes") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/processes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Represents the relationship where an Agent actively engages in a MentalProcess, such as evaluating beliefs, forming desires, or adopting intentions, as part of its cognitive functioning within a BDI framework."</para>
    /// labels<para>"processes"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/processes">https://w3id.org/fossr/ontology/bdi/processes</seealso>
    let processes = Prefixed_Name(bdi, "processes") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/reasonsUpon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property :reasonsUpon links a MentalProcess to the MentalState(s) that serve as its cognitive basis. It captures the fact that a mental process — such as planning, deliberation, or belief revision — operates by drawing upon existing mental states, including beliefs, desires, or intentions. This property models the internal reasoning dynamics of an agent, where the mental process depends on or is triggered by certain mental states in order to produce new cognitive outcomes (e.g., new plans or revised beliefs). For example, an IntentionProcess may reason upon a Desire to form a commitment to action. This relation is essential for reconstructing cognitive explanations and supports transparency in decision-making and mental state transitions."</para>
    /// labels<para>"reasons upon"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/reasonsUpon">https://w3id.org/fossr/ontology/bdi/reasonsUpon</seealso>
    let reasonsUpon = Prefixed_Name(bdi, "reasonsUpon") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/refersTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property refersTo links a MentalEntity (e.g. belief, desire, intention) to the WorldState it is about. This property captures the intentional nature of mental states: they are always directed toward or concerned with some state of the world, whether actual, possible, or hypothetical. For example, a belief such as “the meeting is cancelled” refersTo a world state representing the cancellation of the meeting. Similarly, a desire or an intention can refersTo a world state describing a condition that the agent wishes to bring about. By introducing refersTo, the ontology formally encodes the aboutness relation, which is essential for modelling propositional attitudes and supporting explainability."</para>
    /// labels<para>"refers to"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/refersTo">https://w3id.org/fossr/ontology/bdi/refersTo</seealso>
    let refersTo = Prefixed_Name(bdi, "refersTo") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/satisfies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property :satisfies is the inverse of :isSatisfiedBy and connects a PlanExecution to the Plan that it realises. This property captures the instantiation of an abstract plan into a concrete sequence of actions or behaviours carried out by an agent. It enables reasoning from the execution perspective, such as verifying which plan was implemented, comparing intended and actual outcomes, and auditing agent behaviour. For example, a PlanExecution performed by a response team may be :satisfies a Plan for disaster mitigation. This property is central to supporting traceability, accountability, and simulation of agent decision-making in dynamic environments."</para>
    /// labels<para>"satisfies"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/satisfies">https://w3id.org/fossr/ontology/bdi/satisfies</seealso>
    let satisfies = Prefixed_Name(bdi, "satisfies") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/specifies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The specifies property links an intention to the plan that operationalises it. This property represents how an agent’s commitment to achieving a goal (intention) is translated into a structured sequence of actions (plan)."</para>
    /// labels<para>"specifies"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/specifies">https://w3id.org/fossr/ontology/bdi/specifies</seealso>
    let specifies = Prefixed_Name(bdi, "specifies") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/supports</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The supportsIntention property links a belief to the intention it provides justification or epistemic support for, representing the reasoning or evidence behind the agent’s commitment to act."</para>
    /// labels<para>"supports intention"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/supports">https://w3id.org/fossr/ontology/bdi/supports</seealso>
    let supports = Prefixed_Name(bdi, "supports") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/suppresses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property suppresses is a subproperty of :affects and models
    /// the relation between a MentalProcess and a MentalState that is deactivated,
    /// abandoned, or removed as a result of the process. Suppression may occur
    /// when a Belief is invalidated, a Desire is judged unfeasible or conflicting,
    /// or an Intention is abandoned due to changing priorities or resource
    /// constraints. By representing suppression explicitly, the ontology can
    /// capture the disappearance of mental states from the agent’s active
    /// cognitive repertoire, which is essential for modelling realistic
    /// decision-making and adaptability."</para>
    /// labels<para>"suppresses"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/suppresses">https://w3id.org/fossr/ontology/bdi/suppresses</seealso>
    let suppresses = Prefixed_Name(bdi, "suppresses") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/time</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies the value of a temporal entity."</para>
    /// labels<para>"time"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/time">https://w3id.org/fossr/ontology/bdi/time</seealso>
    let time = Prefixed_Name(bdi, "time") |> PrefixedName
    /// <summary>
    ///   <para>w3id:fossr/ontology/bdi/triggers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Defines a causal relationship where a Mental Entity triggers a MentalProcess, leading to a change in the agent’s internal state, such as updating beliefs, forming new desires, or adopting intentions."</para>
    /// labels<para>"triggers"</para></remarks>
    /// <seealso href="https://w3id.org/fossr/ontology/bdi/triggers">https://w3id.org/fossr/ontology/bdi/triggers</seealso>
    let triggers = Prefixed_Name(bdi, "triggers") |> PrefixedName
