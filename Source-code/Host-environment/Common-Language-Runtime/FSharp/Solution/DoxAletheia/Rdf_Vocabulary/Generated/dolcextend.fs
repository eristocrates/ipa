namespace http.www.loa_cnr.it.ontologies.ExtendedDnS.owl.hash

open DoxAletheia.Rdf_Vocabulary

module dolcextend =
    let _namespace_name = "http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#"
    /// <summary>
    /// The relation between information objects and entities they are about. The difference with 'expresses' is that the last requires a situation to be about something. E.g. Dante's Comedy is about facts like Dante's travel to the hereafter. The Comedy expresses a script as well as various related meanings, while the facts talked about are not 'expressed'.Given that descriptions are expressed by at least one IO, and that interpretations of IOs requires conceiving a description, and the (plausible) claim that being about something can only be done in context, i.e. within a situation, we can propose that the conceived description is satisfied by the situation (the context) of the entity the IO is about.On this basis, about would result to be a mediated relation. This is still a proposal, then we keep about here as a primitive for some time.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#about"></see></summary>
    let about = Namespaced_IRI.parse _namespace_name "about" |> NamespacedName

    /// <summary>
    /// Information objects are social objects. They are realized by some entity. They are ordered (expressed according to) by some system for information encoding. Consequently, they are dependent from an encoding as well as from a concrete realization.They can express a description (the ontological equivalent of a meaning/conceptualization), can be about any entity, and can be interpreted by an agent.From a communication perspective, an information object can play the role of "message". From a semiotic perspective, it playes the role of "expression".
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#information-object"></see></summary>
    let ``information-object`` =
        Namespaced_IRI.parse _namespace_name "information-object" |> NamespacedName

    /// <summary>
    /// A relation holding between non-physical objects and entities whatsoever (thus including non-physical objects themselves). An intuition for the references relation could be that a non-physical object adds  'information' to an entity. In fact, non-physical objects depend on a communication setting. In most cases, this is the characteristic relation that provides a unity criterion to objects, events, etc.  For example, cars are objects and not mere aggregates because there is a  project, a design, a social value, a functional structure, a  personal emotional structure, etc. attached to them. This attachment can be represented by means of 'non-physical objects' that 'reference' cars. The most obvious application is for situations, which do not exist without a description, although they still are extensional entities: a situation without a part is no more the same situation, but a situation is not a mere aggregate, since it has references to a description  as its unity criterion. Adding information to an entity can also be thought as an intentional solution to a holistic stance. Defenders of this view -within different frameworks- are  Kant, Brentano, Husserl, Gestalt psychologists, Merleau-Ponty ... References is distinguished according to the kinds of non-physical objects and referenced  ground entities: referencing between descriptions and situations is called 'SATISFIED-BY', while referencing between description components and situation components is called 'CLASSIFIES'. 'SETTING-FOR' is a referencing relation between situation and the entities in its setting (it was formerly a constitution relation, but since situation appear to be social objects from the DOLCE viewpoint, the constitution solution is no more applicable). 'EXPRESSES' is bound to information objects and the meaning (description of a representation or conceptualization) in which they are involved. 'REALIZED-BY' is bound to information objects and physical representations that are used to communicate them, etc. 'ABOUT' is bound to information objects and entities whatsoever (aboutness of intentionality).
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#references"></see></summary>
    let references = Namespaced_IRI.parse _namespace_name "references" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#aboutness-of"></see>
    /// </summary>
    let ``aboutness-of`` =
        Namespaced_IRI.parse _namespace_name "aboutness-of" |> NamespacedName

    /// <summary>
    /// A relation holding between non-physical objects and entities whatsoever (thus including non-physical objects themselves). An intuition for the references relation could be that a non-physical object adds 'information'  to an entity. In fact, non-physical objects depend on a communication setting. In most cases, this is the characteristic relation that provides  a unity criterion to objects, events, etc. For example, cars are objects and not mere aggregates because there is a project, a design, a social value, a functional structure, a personal emotional structure, etc. attached to them. This attachment can be represented by means of 'non-physical objects' that 'reference' cars. The most obvious application is for situations, which do not exist without a description, although they still are extensional entities: a situation without a part is no more the same situation, but a situation is not a mere aggregate, since it has references to a description as its unity criterion. Adding information to an entity can also be thought as an intentional solution to a holistic stance. Defenders of this view -within different frameworks- are Kant, Brentano, Husserl, Gestalt psychologists, Merleau-Ponty ... References is distinguished according to the kinds of non-physical objects and referenced ground entities: referencing between descriptions and situations is called 'SATISFIED-BY', while referencing between description components and situation components is called 'CLASSIFIES'. 'SETTING-FOR' is a referencing relation between a situation and the entities in its setting (it was formerly a constitution relation, but since situation appear to be social objects from the DOLCE viewpoint, the constitution solution is no more applicable). 'EXPRESSES' is bound to information objects and the meaning (description of a representation or conceptualization) in which they are involved. 'REALIZED-BY' is bound to information objects and physical representations that are used to communicate them, etc. 'ABOUT' is bound to information objects and entities whatsoever (aboutness of intentionality).
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#referenced-by"></see></summary>
    let ``referenced-by`` =
        Namespaced_IRI.parse _namespace_name "referenced-by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#acted-by"></see>
    /// </summary>
    let ``acted-by`` = Namespaced_IRI.parse _namespace_name "acted-by" |> NamespacedName
    /// <summary>
    /// a.k.a. 'social individual'. Figures are social objects defined or used by descriptions, but differently from concepts, they do not classify entities. Examples of figures are organizations, political-geographic objects, sacred symbols, etc.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#figure"></see></summary>
    let figure = Namespaced_IRI.parse _namespace_name "figure" |> NamespacedName
    /// <summary>
    /// A catch-all class used to join agentive objects (either physical or social). Agents are dispositionally so, in the sense that they internally represent descriptions, and in particular plans, goals and possible actions, but they do not necessarily act. In everyday language, agent is used in this sense, but also to tell that something has acted in a certain way, or to say that something has an initiator or leading role in some action. In DLP, the performs relation encodes these notions.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#agent"></see></summary>
    let agent = Namespaced_IRI.parse _namespace_name "agent" |> NamespacedName
    /// <summary>
    /// Figures are not dependent on roles defined or used in the same descriptions they are defined or used, but they can act because they depute some powers to some of those roles. In other words, a figure selected by some agentive role can play that role because there are other roles in the descriptions that define or use the figure. Those roles select endurants that result to act for the figure.For example, an employee acts for an organization that deputes the role (e.g. turner) that classifies the employee. Simply put, a guy working as a turner at FIAT acts for (or on behalf of) FIAT.In complex figures, like organizations or societies, a total agency is possible when an endurant plays a delegate, or representative role of the figure.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#acts-for"></see></summary>
    let ``acts-for`` = Namespaced_IRI.parse _namespace_name "acts-for" |> NamespacedName
    /// <summary>
    /// A Perdurant that exemplifies the intentionality of an agent. Could it be aborted, incomplete, mislead, while remaining a (potential) accomplishment ... The point here is that having a result depends on a method, then an action remains an action under incomplete results. As a matter of fact, if we neutralize intentionality, a purely topological, post-hoc view is at odds with the notion of incomplete accomplishments.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#action"></see></summary>
    let action = Namespaced_IRI.parse _namespace_name "action" |> NamespacedName

    /// <summary>
    /// A state of the (embodied) mind
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#cognitive-state"></see></summary>
    let ``cognitive-state`` =
        Namespaced_IRI.parse _namespace_name "cognitive-state" |> NamespacedName

    /// <summary>
    /// In dependency terms, an activity is an action that is generically constantly dependent on a (at least partly) shared plan adopted by participants. This condition implies that an action must be sequenced by a task.Intuitively, activities are complex actions that are at least partly conventionally planned.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#activity"></see></summary>
    let activity = Namespaced_IRI.parse _namespace_name "activity" |> NamespacedName
    /// <summary>
    /// A plan is a method for executing or performing a procedure or a stage of a procedure. A plan must use both at least one role played by an agent, and at least one task. Finally, a plan has a goal as proper part, and can also have regulations and other descriptions as proper parts.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#plan"></see></summary>
    let plan = Namespaced_IRI.parse _namespace_name "plan" |> NamespacedName
    /// <summary>
    /// A course used to sequence activities or other controllable perdurants (some states, processes), usually within methods. They must be defined by a method, but can be *used* by other kinds of descriptions. They are desire targets of some role played by an agent. Tasks can be complex, and ordered according to an abstract succession relation. Tasks can relate to ground activities or decision making; the last kind deals with typical flowchart content. A task is different both from a flowchart node, and from an action or action type.Tasks can be considered shortcuts for plans, since at least one role played by an agent has a desire attitude towards them (possibly different from the one that puts the task into action). In principle, tasks could be transformed into explicit plans.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#task"></see></summary>
    let task = Namespaced_IRI.parse _namespace_name "task" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#sequenced-by"></see>
    /// </summary>
    let ``sequenced-by`` =
        Namespaced_IRI.parse _namespace_name "sequenced-by" |> NamespacedName

    /// <summary>
    /// The composition of d-uses and valued-by relations: a description d-uses a parameter that is valued by a region.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#admits"></see></summary>
    let admits = Namespaced_IRI.parse _namespace_name "admits" |> NamespacedName

    /// <summary>
    /// A description is a social object which represents a conceptualization (e.g. a mental object or state), hence it is generically dependent on some agent and communicable. Descriptions define or use concepts or figures, are expressed by an information object and can be satisfied by situations. The typology of descriptions is still preliminary.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#description"></see></summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#admitted-by"></see>
    /// </summary>
    let ``admitted-by`` =
        Namespaced_IRI.parse _namespace_name "admitted-by" |> NamespacedName

    /// <summary>
    /// A relation between agents and descriptions, requiring previous creation by a rational agent, and internal representation by a physical agent, directly, or acted by some social agent. It can involve or not an actual desire to perform the possibly expected actions.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#adopted-by"></see></summary>
    let ``adopted-by`` =
        Namespaced_IRI.parse _namespace_name "adopted-by" |> NamespacedName

    /// <summary>
    /// Either a rational physical object (e.g. an animal capable of meta-representations), or a social object acted by a rational physical object (e.g. an organization).
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#rational-agent"></see></summary>
    let ``rational-agent`` =
        Namespaced_IRI.parse _namespace_name "rational-agent" |> NamespacedName

    /// <summary>
    /// A relation between agents and descriptions, requiring previous creation by a rational agent, and internal representation by a physical agent, directly, or acted by some social agent. It can involve or not an actual desire to perform the possibly expected actions.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#adopts"></see></summary>
    let adopts = Namespaced_IRI.parse _namespace_name "adopts" |> NamespacedName

    /// <summary>
    /// Within Physical objects, a special place have those to which we ascribe generic intentionality (compatibly to Brentano's distinction i.e., the ability to represent something to oneself, intentionality is here represented as the ability to internally represent a description).
    /// In particular, we call Agentive, as opposite to Non-agentive, those that are able to internally represent a plan.
    /// In general, we assume that agentive objects are constituted by non-agentive objects: an organism is constituted by bodily organs, a robot is constituted by some machinery, and so on.
    /// Among non-agentive physical objects we have for example houses, bodily organs, pieces of wood, etc.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#agentive-physical-object"></see></summary>
    let ``agentive-physical-object`` =
        Namespaced_IRI.parse _namespace_name "agentive-physical-object" |> NamespacedName

    /// <summary>
    /// A social object that is assumed to adopt a plan. Since social objects are dependent on physical ones, adoption involves that a social object is acted-by physical agents that 'internally represents' that plan.
    /// For example, an institution can adopt the plan to promote or regulate some activities, but this is possible by means of the powers conferred to it by some legal system, through its representatives, and that plan has to be executed by means of the physical agents that 'act for' the institution.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#agentive-social-object"></see></summary>
    let ``agentive-social-object`` =
        Namespaced_IRI.parse _namespace_name "agentive-social-object" |> NamespacedName

    /// <summary>
    /// AKA Agentive-role.A role that can only be played by agents.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#agent-driven-role"></see></summary>
    let ``agent-driven-role`` =
        Namespaced_IRI.parse _namespace_name "agent-driven-role" |> NamespacedName

    /// <summary>
    /// This is the immediate relation between roles and endurants. A role classifies the position (function, use, relevance, ...) of an endurant within a context (description). Roles can be ordered, interdependent, at different layers. etc.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#played-by"></see></summary>
    let ``played-by`` =
        Namespaced_IRI.parse _namespace_name "played-by" |> NamespacedName

    /// <summary>
    /// Also known as 'functional role'.A concept that classifies (in particular, it is 'played by') endurants, as used in some description. Roles are the descriptive counterpart of endurants, and, as endurants participate in perdurants, they usually have courses as modal targets (see).The typology of roles is still preliminary.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#role"></see></summary>
    let role = Namespaced_IRI.parse _namespace_name "role" |> NamespacedName

    /// <summary>
    /// Agentive figures are those which are assigned (agentive) roles from a society or community; hence, they can act like a physical agent. Typical agentive figures are societies, organizations, and in general all socially constructed persons. Agentive figures are not dependent on roles defined or used in the same descriptions they are defined or used, but they can act because they depute some powers to some of those roles. In other words, a figure classified by some agentive role can play that role because there are other roles in the descriptions that define or use the figure. Those roles classifies endurants that result to act for the figure. For example, an employee acts for an organization that deputes the role (e.g. turner) that classifies the employee. Simply put, a guy working as a turner at FIAT acts for (or on behalf of) FIAT. In complex figures, like organizations or companies, a total agency is possible when an endurant plays a delegate or representative role of the figure. Since figures are social objects, it is conceivable to find agentive figures that act for other agentive figures.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#agentive-figure"></see></summary>
    let ``agentive-figure`` =
        Namespaced_IRI.parse _namespace_name "agentive-figure" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#refined-by"></see>
    /// </summary>
    let ``refined-by`` =
        Namespaced_IRI.parse _namespace_name "refined-by" |> NamespacedName

    /// <summary>
    /// A figure can personify a particular, e.g. the holy grail or a goddess, or an organization, which personifies a (postulated) collective.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#personifies"></see></summary>
    let personifies =
        Namespaced_IRI.parse _namespace_name "personifies" |> NamespacedName

    /// <summary>
    /// This is the immediate relation between roles and endurants. A role classifies the position (function, use, relevance, ...) of an endurant within a context (description). Roles can be ordered, interdependent, at different layers. etc.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#plays"></see></summary>
    let plays = Namespaced_IRI.parse _namespace_name "plays" |> NamespacedName

    /// <summary>
    /// A description whose purpose is defining a figure.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#constitutive-description"></see></summary>
    let ``constitutive-description`` =
        Namespaced_IRI.parse _namespace_name "constitutive-description" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#defined-by"></see>
    /// </summary>
    let ``defined-by`` =
        Namespaced_IRI.parse _namespace_name "defined-by" |> NamespacedName

    /// <summary>
    /// The relation between agents and descriptions. Agents have inner (a.k.a. 'mental') states and are endowed with, or produce, representations or conceptualizations, both corresponding here to 'descriptions'. The relation has a time index, but this should not be intended as a partial compresence, since time only refers to the part of the agent's life in which it represents the description (a.k.a. 'conceives', now rejected because of  its strong human-rationality connotation). Provisionally, internally-represents is introduced here as an immediate (primitive) relation, but other options are under study. The first involves mediating internal representation through an ontology of mental states and events, while the second is semiotic: since descriptions are expressed by at least one information object, representing internally requires at least one creation/interpretation of an information object, therefore internally-represents would be a 'mediated' relation.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#internally-represents"></see></summary>
    let ``internally-represents`` =
        Namespaced_IRI.parse _namespace_name "internally-represents" |> NamespacedName

    /// <summary>
    /// Within physical objects, a special place have those to which we ascribe intentions, beliefs, and desires. These are called Agentive, as opposite to Non-agentive. Intentionality is understood here as the capability of heading for/dealing with objects or states of the world. This is an important area of ontological investigation we haven't properly explored yet, so our suggestions are really very preliminary. A possible modelling of case roles has been started within the descriptions plugin that could be embedded within basic DOLCE. In general, we assume that agentive objects are constituted by non-agentive objects: an organism is constituted by bodily organs, a robot is constituted by some machinery, and so on. Among non-agentive physical objects we have for example houses, body organs, pieces of wood, etc.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#non-agentive-physical-object"></see></summary>
    let ``non-agentive-physical-object`` =
        Namespaced_IRI.parse _namespace_name "non-agentive-physical-object" |> NamespacedName

    /// <summary>
    /// A social object that is not agentive in the sense of adopting a plan or being acted by some physical agent. See 'agentive-social-object' for more detail.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#non-agentive-social-object"></see></summary>
    let ``non-agentive-social-object`` =
        Namespaced_IRI.parse _namespace_name "non-agentive-social-object" |> NamespacedName

    /// <summary>
    /// A catch-all class for entities from the social world. It includes agentive and non-agentive socially-constructed objects: descriptions, concepts, figures, collections, information objects. It could be equivalent to 'non-physical object', but we leave the possibility open of 'private' non-physical objects.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#social-object"></see></summary>
    let ``social-object`` =
        Namespaced_IRI.parse _namespace_name "social-object" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#attitude-target-of"></see>
    /// </summary>
    let ``attitude-target-of`` =
        Namespaced_IRI.parse _namespace_name "attitude-target-of" |> NamespacedName

    /// <summary>
    /// A concept that classifies (in particular, it 'sequences') perdurants (processes, events, or states), as a component of some description. Courses are the descriptive counterpart of perdurants, and, since perdurants have endurants as participants, they are usually the function of some role.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#course"></see></summary>
    let course = Namespaced_IRI.parse _namespace_name "course" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#modal-target-of"></see>
    /// </summary>
    let ``modal-target-of`` =
        Namespaced_IRI.parse _namespace_name "modal-target-of" |> NamespacedName

    /// <summary>
    /// It is the immediate relation between roles or figures, and tasks. It is the descriptive counterpart of the 'participant-in' relation for agentive roles or figures.In other words, it is used to state attitudes, attention or even subjection that an object can have wrt an action or process. Formally, a modality target is a task that sequences a perdurant that has a participant that plays a role bound to that modality target with a certain modality.For example, a person is usually obliged to drive in a way that prevents hurting other persons. Or a person can have the right to express her ideas.Another, more complex example: a BDI application to a certain ordered set of tasks including  initial conditions (beliefs), final conditions (desires), and ways to reach goals (intentions). In other words, to move from beliefs to goals is a way of bounding one or more agent(s) to a sequence of actions.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#attitude-towards"></see></summary>
    let ``attitude-towards`` =
        Namespaced_IRI.parse _namespace_name "attitude-towards" |> NamespacedName

    /// <summary>
    /// The relation between roles and courses. Modal target subrelations can be seen as 'reifications' of the operators of modal logics.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#modal-target"></see></summary>
    let ``modal-target`` =
        Namespaced_IRI.parse _namespace_name "modal-target" |> NamespacedName

    /// <summary>
    /// C-SAT - like R-SAT - concerns entities that exist in a situation entirely prior to the description. Moreover, it assumes redundant satisfaction. But, differently from P-SAT and R-SAT, no qualified satisfaction is assumed. In fact, C-SAT implies no dependency of a situation on its description. C-SAT typically applies to different views of existing situations, as for regulative descriptions (disclaimer: the situation can be already created by complying to the regulation, e.g executing it as a plan, but in this case there actually exists a plan that has the regulation as part), narratives, symbolic interpretations, etc.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#c-sat"></see></summary>
    let ``c-sat`` = Namespaced_IRI.parse _namespace_name "c-sat" |> NamespacedName
    /// <summary>
    /// A situation is a social object that appears in the domain of an ontology only because there is a description whose components can 'carve up' a view (setting) on that domain. A situation has to satisfy a description (see below for ways of defining the satisfies relation), and it has to be setting for at least one entity.In other words, it is the ontological counterpart (with due local differences or restrictions) of settings (situations from SC, contexts, episodes, states of affairs, structures, configurations, cases, etc.).A perdurant is usually the only mandatory constituent of a setting.Two descriptions of a same situation are possible, otherwise we would result in a solipsistic ontology. The time and space (and possibly other qualities) of a situation are the time and space of the perdurants in the setting.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#situation"></see></summary>
    let situation = Namespaced_IRI.parse _namespace_name "situation" |> NamespacedName
    /// <summary>
    /// See 'satisfied-by'.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#satisfies"></see></summary>
    let satisfies = Namespaced_IRI.parse _namespace_name "satisfies" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#c-sat-by"></see>
    /// </summary>
    let ``c-sat-by`` = Namespaced_IRI.parse _namespace_name "c-sat-by" |> NamespacedName

    /// <summary>
    /// See also comment on 'satisfies' for a different explanation.This is the     primitive relation between descriptions and situations. It can be     understood as a reification of the 'satisfiability' relation of formal     semantics that holds between theories and models. A theory is reified as a description, thus acquiring a life-cycle: a theory     can be changed, versioned, discussed, issued, etc. 'Theory' can be a 'potential' theory in the sense that most conceptualizations     that could be formalized, could also be reified, e.g. plans, norms,     stories, projects, diagnoses, methods, etc. No position is taken on the     extensionality of descriptions. For example, if a theory is required to be     reified in fine detail, if it changes an axiom, it could be considered no     more the same theory. On the other hand, if theories are reified without such a strong assumption,     some axioms can be changed just like non-essential parts of physical     objects, with the theory preserving its identity.In case a theory is considered extensional, it might be considered a member of     a class of 'theory changing history'. The 'refines' relation provides this     possibility.A model is reified as a situation, thus a *class* of models that can satisfy a     theory is reified as a situation type (class). Situations can depend on     descriptions, but not vice-versa (constructivist stance). Components of     descriptions 'classify' entities of situations.There are at least three     satisfaction subrelations, and a lot of conditions can be stated for     allowing an automatic matching of satisfaction. See the FOL version of DLP     for details.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#satisfied-by"></see></summary>
    let ``satisfied-by`` =
        Namespaced_IRI.parse _namespace_name "satisfied-by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#characterized-by"></see>
    /// </summary>
    let ``characterized-by`` =
        Namespaced_IRI.parse _namespace_name "characterized-by" |> NamespacedName

    /// <summary>
    /// Collections are social objects which, although not defined by a description, depend both on member entities and on some concepts or figures, hence indirectly on descriptions. While we could talk in general of collections of any kind of entities (events, objects, abstracts, etc.), we restrict here our attention to collections of endurants, and to the concepts that classify them (i.e. roles).
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#collection"></see></summary>
    let collection = Namespaced_IRI.parse _namespace_name "collection" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#intensionally-referenced-by"></see>
    /// </summary>
    let ``intensionally-referenced-by`` =
        Namespaced_IRI.parse _namespace_name "intensionally-referenced-by" |> NamespacedName

    /// <summary>
    /// A role r characterizes a collection c when proper subsets of the members of c play different roles r,...,rn that are all used by a same description or deputed by a same figure.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#characterizes"></see></summary>
    let characterizes =
        Namespaced_IRI.parse _namespace_name "characterizes" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#intensionally-references"></see>
    /// </summary>
    let ``intensionally-references`` =
        Namespaced_IRI.parse _namespace_name "intensionally-references" |> NamespacedName

    /// <summary>
    /// A.K.A. 'selected-by'.The referencing relation between concepts defined by descriptions and constituents of situations. It can be understood as a reification of a 'satisfiability' relation holding between elements of  theories and elements of models.It has a time index, but this should not be intended as a partial compresence, since the time only refers to a part of the classified particular life or extension.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#classified-by"></see></summary>
    let ``classified-by`` =
        Namespaced_IRI.parse _namespace_name "classified-by" |> NamespacedName

    /// <summary>
    /// AKA C-Description. A non-physical object that is defined by a description s, and whose function is classifying entities from a ground ontology in order to build situations that can satisfy s.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#concept"></see></summary>
    let concept = Namespaced_IRI.parse _namespace_name "concept" |> NamespacedName
    /// <summary>
    /// A.K.A. 'selects'.The referencing relation between concepts defined by  descriptions, and constituents of situations. It can be understood as a  reification of a 'satisfiability' relation holding between elements of theories and elements of models.It has a time index, but this should not be intended as a partial compresence, since the time only refers to a part of the classified particular life or extension.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#classifies"></see></summary>
    let classifies = Namespaced_IRI.parse _namespace_name "classifies" |> NamespacedName

    /// <summary>
    /// A relation holding between two endurants participating in a same perdurant. This typically subsumes many common sense, verbally encoded, relations, such as "making", "moving", "transforming", etc.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#co-participates-with"></see></summary>
    let ``co-participates-with`` =
        Namespaced_IRI.parse _namespace_name "co-participates-with" |> NamespacedName

    /// <summary>
    /// An event occurring in the (embodied) mind.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#cognitive-event"></see></summary>
    let ``cognitive-event`` =
        Namespaced_IRI.parse _namespace_name "cognitive-event" |> NamespacedName

    /// <summary>
    /// The modal descriptions depending on some mental attitude (i.e. internally represented by a physical agent), represented here by means of a relation between roles and tasks.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#cognitive-modal-description"></see></summary>
    let ``cognitive-modal-description`` =
        Namespaced_IRI.parse _namespace_name "cognitive-modal-description" |> NamespacedName

    /// <summary>
    /// A modal description is any part of a description that has a unity criterion consisting in the specification of a modal target (some course), and it can be a right, power, duty, etc. Notice that modal descriptions can appear in conventionalized descriptions as well as in idiosyncratic assessements, narratives, promises, etc. From the formal semantic viewpoint, a modal description is the reification of a relation involving a modal logic operator.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#modal-description"></see></summary>
    let ``modal-description`` =
        Namespaced_IRI.parse _namespace_name "modal-description" |> NamespacedName

    /// <summary>
    /// Descriptions can d-use (descriptively use) concepts or figures, provided that used ones are defined by some description.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#d-uses"></see></summary>
    let ``d-uses`` = Namespaced_IRI.parse _namespace_name "d-uses" |> NamespacedName

    /// <summary>
    /// The relation between descriptions and agents. Agents have inner (a.k.a. 'mental') states and are endowed with, or produce, representations or conceptualizations, both corresponding here to 'descriptions'. The relation has a time index, but this should not be intended as a partial compresence, since time only refers to the part of the agent's life in which it represents the description (a.k.a. 'conceives', now rejected because of its strong human-rationality connotation). Provisionally, internally-represents is introduced here as an immediate (primitive) relation, but other options are under study. The first involves mediating internal representation through an ontology of mental states and events, while the second is semiotic: since descriptions are expressed by at least one information object, representing internally requires at least one creation/interpretation of an information object, therefore internally-represents would be a 'mediated' relation.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#internally-represented-in"></see></summary>
    let ``internally-represented-in`` =
        Namespaced_IRI.parse _namespace_name "internally-represented-in" |> NamespacedName

    /// <summary>
    /// Specialization as reification of a partial-order relation between type- or set-reified social objects, i.e. descriptions, concepts, and collections.For example, concepts that are apparently classified by other concepts; e.g. a manager that plays the role of buyer, where the role manager actually specializes the role buyer. Descriptions can be specialized by other descriptions that specialize their concepts. For descriptions, an intention to specialize must be present (unless purely formal theories are considered, but even in this case a criterion of relevance is usually active). Specialization does not imply expansion (proper part) for descriptions. If there exists a concept that is defined by the specialized description, which is not d-used in the specializing one, the second only specializes a part of the first. If there exists a concept that is defined by the specializing description, which is not d-used by the specialized one, the first both specializes and expands the second.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#specialized-by"></see></summary>
    let ``specialized-by`` =
        Namespaced_IRI.parse _namespace_name "specialized-by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#unified-by"></see>
    /// </summary>
    let ``unified-by`` =
        Namespaced_IRI.parse _namespace_name "unified-by" |> NamespacedName

    /// <summary>
    /// A typology of non-agentive figures is currently under investigation.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#non-agentive-figure"></see></summary>
    let ``non-agentive-figure`` =
        Namespaced_IRI.parse _namespace_name "non-agentive-figure" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#covered-by"></see>
    /// </summary>
    let ``covered-by`` =
        Namespaced_IRI.parse _namespace_name "covered-by" |> NamespacedName

    /// <summary>
    /// A collection with only agents as members.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#collective"></see></summary>
    let collective = Namespaced_IRI.parse _namespace_name "collective" |> NamespacedName
    /// <summary>
    /// Being a (generic, temporary) constituent in a countable collection, for example: member of a society, bacterium in a colony, etc.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#member"></see></summary>
    let member_ = Namespaced_IRI.parse _namespace_name "member" |> NamespacedName

    /// <summary>
    /// Here communication is taken in a rather wide sense, being possible as an (intentional) activity as well as a phenomenon.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#communication-event"></see></summary>
    let ``communication-event`` =
        Namespaced_IRI.parse _namespace_name "communication-event" |> NamespacedName

    /// <summary>
    /// 'Component' is a proper part with a role (or function) in a system or a context. Roles can be different for the same entity, and the evaluation of them changes according to the kind of entity. For instance, components of endurants can 'play functional roles' in a whole, while components of perdurants are the  essential 'episodes' in their whole.As a functional part relation, component is not transitive, because functions depend on intentions and/or designs, and something intentionally essential for a direct whole, can be non-essential for another, indirect whole.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#component"></see></summary>
    let component_ = Namespaced_IRI.parse _namespace_name "component" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#component-of"></see>
    /// </summary>
    let ``component-of`` =
        Namespaced_IRI.parse _namespace_name "component-of" |> NamespacedName

    /// <summary>
    /// Descriptions define either concepts or (social) figures. Once defined, they can be d-used by other descriptions.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#defines"></see></summary>
    let defines = Namespaced_IRI.parse _namespace_name "defines" |> NamespacedName
    /// <summary>
    /// A concept that classifies (in particular, it is 'valued by') regions, as defined by some description. Parameters are the descriptive counterpart of regions, and, as regions represent the qualities of perdurants or endurants, they can be requisites for some role or course.A parameter has at least one region that is a value for it.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#parameter"></see></summary>
    let parameter = Namespaced_IRI.parse _namespace_name "parameter" |> NamespacedName
    /// <summary>
    /// The role shared by all members of a collection has a covering relation towards the collection.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#covers"></see></summary>
    let covers = Namespaced_IRI.parse _namespace_name "covers" |> NamespacedName

    /// <summary>
    /// An important relation between agents and descriptions is creation, implying that a given description is *specifically* dependent on a rational agent.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#created-by"></see></summary>
    let ``created-by`` =
        Namespaced_IRI.parse _namespace_name "created-by" |> NamespacedName

    /// <summary>
    /// An important relation between agents and descriptions is creation,  implying that a given description is *specifically* dependent on a rational agent.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#creates"></see></summary>
    let creates = Namespaced_IRI.parse _namespace_name "creates" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#d-used-by"></see>
    /// </summary>
    let ``d-used-by`` =
        Namespaced_IRI.parse _namespace_name "d-used-by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#deputed-by"></see>
    /// </summary>
    let ``deputed-by`` =
        Namespaced_IRI.parse _namespace_name "deputed-by" |> NamespacedName

    /// <summary>
    /// Figures can depute roles that are played by endurants that are supposed to 'act for' the figure.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#deputes"></see></summary>
    let deputes = Namespaced_IRI.parse _namespace_name "deputes" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#expressed-by"></see>
    /// </summary>
    let ``expressed-by`` =
        Namespaced_IRI.parse _namespace_name "expressed-by" |> NamespacedName

    /// <summary>
    /// A role played by descriptions only. Usable for metalinguistic notions, like those that deal with granular partitions of knowledge, strata of reality, argumentation, etc.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#description-role"></see></summary>
    let ``description-role`` =
        Namespaced_IRI.parse _namespace_name "description-role" |> NamespacedName

    /// <summary>
    /// Desires are characterized here as modal description dependent on the cognitive (or 'mental') states of an agent. It is difficult to say more than that without reusing an ontology of cognitive states.Informally: a desire is a description that involves some (possible or actual) 'desire towards' attitude by an agent, and is ultimately motivated by evolutionary features of an organism (or by built-in features if the agent is artificial), which are (or used to be) an advantage for it.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#desire"></see></summary>
    let desire = Namespaced_IRI.parse _namespace_name "desire" |> NamespacedName

    /// <summary>
    /// Anti-transitive predecessor.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#direct-predecessor"></see></summary>
    let ``direct-predecessor`` =
        Namespaced_IRI.parse _namespace_name "direct-predecessor" |> NamespacedName

    /// <summary>
    /// To be understood as 'entity x  has predecessor y'.This is the transitive version, but it results to be a complex property in OWL-DL, and transitivity should be overruled.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#predecessor"></see></summary>
    let predecessor =
        Namespaced_IRI.parse _namespace_name "predecessor" |> NamespacedName

    /// <summary>
    /// Anti-transitive succession.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#direct-successor"></see></summary>
    let ``direct-successor`` =
        Namespaced_IRI.parse _namespace_name "direct-successor" |> NamespacedName

    /// <summary>
    /// To be understood as 'entity x  has successor y'. Succession does not exclude connection, but it excludes overlapping. It can be direct or indirect, and assumes a choice (temporal, spatial, abstract, etc.) Cf. the cognitive 'path' schema. This is the transitive version.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#successor"></see></summary>
    let successor = Namespaced_IRI.parse _namespace_name "successor" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#empowered-for"></see>
    /// </summary>
    let ``empowered-for`` =
        Namespaced_IRI.parse _namespace_name "empowered-for" |> NamespacedName

    /// <summary>
    /// A relation between a role and a power allowed towards some function/task.This is dispositional, and implies that a participation classified by this relation is an 'empowered participation'.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#empowered-to"></see></summary>
    let ``empowered-to`` =
        Namespaced_IRI.parse _namespace_name "empowered-to" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#expanded-by"></see>
    /// </summary>
    let ``expanded-by`` =
        Namespaced_IRI.parse _namespace_name "expanded-by" |> NamespacedName

    /// <summary>
    /// A partial order relation that holds between descriptions. It represents the proper part relation between a description and another description featuring the same properties of the former, with at least an additional one.Descriptions can be expanded either by adding other descriptions as parts, or by refining concepts or figures that are d-used by them.Specializing the concepts or figures that are d-used by them is on the contrary a case of description specialization.For descriptions, an intention to expand must be present (unless purely formal theories are considered, but even in this case a criterion of relevance is usually active).
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#expands"></see></summary>
    let expands = Namespaced_IRI.parse _namespace_name "expands" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#expected-by"></see>
    /// </summary>
    let ``expected-by`` =
        Namespaced_IRI.parse _namespace_name "expected-by" |> NamespacedName

    /// <summary>
    /// The composition of d-uses and sequences relations: a description d-uses a course that sequences a perdurant.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#expects"></see></summary>
    let expects = Namespaced_IRI.parse _namespace_name "expects" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#expected-setting"></see>
    /// </summary>
    let ``expected-setting`` =
        Namespaced_IRI.parse _namespace_name "expected-setting" |> NamespacedName

    /// <summary>
    /// A double composition is needed here for linking situations and descriptions components, since many possible constituents could be available in the situation. The first one constrains the classifies relation through description components, the second one constrains it through situation constituents.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#expected-setting-for"></see></summary>
    let ``expected-setting-for`` =
        Namespaced_IRI.parse _namespace_name "expected-setting-for" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#exploited-by"></see>
    /// </summary>
    let ``exploited-by`` =
        Namespaced_IRI.parse _namespace_name "exploited-by" |> NamespacedName

    /// <summary>
    /// A description that contains a specification to do, realize, behave, etc. Subclasses are plan, technique, practice, project, etc.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#method"></see></summary>
    let method = Namespaced_IRI.parse _namespace_name "method" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#involved-in"></see>
    /// </summary>
    let ``involved-in`` =
        Namespaced_IRI.parse _namespace_name "involved-in" |> NamespacedName

    /// <summary>
    /// A method can exploit an involved endurant when it plays a device-like role.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#exploits"></see></summary>
    let exploits = Namespaced_IRI.parse _namespace_name "exploits" |> NamespacedName
    /// <summary>
    /// The composition of d-uses and played-by relations: a description d-uses a role that is played by an endurant.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#involves"></see></summary>
    let involves = Namespaced_IRI.parse _namespace_name "involves" |> NamespacedName
    /// <summary>
    /// A relation between information objects that are used as representations (signs) and the content (meaning, conceptualization) they represent. In this ontology content is reified as a 'description'.Information objects are 'systemic' objects created by the system of rules of a semiotic code. For the representation between the physical implementation of information objects (physical representations) and information objects, the 'realized-by' relation  is used.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#expresses"></see></summary>
    let expresses = Namespaced_IRI.parse _namespace_name "expresses" |> NamespacedName

    /// <summary>
    /// Two or more collections can be extensionally equivalent and still not be the same collection. Each collection needs a unifying description which provides its intensional identity criterion.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#extensionally-equivalent"></see></summary>
    let ``extensionally-equivalent`` =
        Namespaced_IRI.parse _namespace_name "extensionally-equivalent" |> NamespacedName

    /// <summary>
    /// Fluxes are processes that (also) contain accomplishments as constituents. In other words, fluxes emerge out of accomplishments.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#flux"></see></summary>
    let flux = Namespaced_IRI.parse _namespace_name "flux" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#functionally-unified-by"></see>
    /// </summary>
    let ``functionally-unified-by`` =
        Namespaced_IRI.parse _namespace_name "functionally-unified-by" |> NamespacedName

    /// <summary>
    /// A description can provide its unity criterion to a physical object. In this case we say that the description *functionally unifies* the physical object. This relation is equivalent to a composition of a description that unifies a collection whose members are (usually connected) proper parts of a physical object.Ideally, this notion should be used to provide a definition to physical objects, but this application would destroy the distinction between a 'perceived' object (an endurant whose unity depends on the perception competence of an agent), and a 'functional' object, since each perceived object would be such because it is functionally unified by a description conceived by the perceiving agent. In DOLCE we still apply to the distinction between perception and function.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#functionally-unifies"></see></summary>
    let ``functionally-unifies`` =
        Namespaced_IRI.parse _namespace_name "functionally-unifies" |> NamespacedName

    /// <summary>
    /// A perceptual structure, from the descriptive viewpoint. In other words, this encodes the conditions by which a configuration, structure, or arrangement is perceived as a meaningful whole by a perceiving agent.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#gestalt"></see></summary>
    let gestalt = Namespaced_IRI.parse _namespace_name "gestalt" |> NamespacedName
    /// <summary>
    /// This is used in a wide cultural sense: a theory about something, expressed in a rather systematic way, but not necessarily public (although communicable in principle). An axiomatic theory is not a theory in this sense, although we can expect an axiomatic theory to be the formal representation of a generic theory.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#theory"></see></summary>
    let theory = Namespaced_IRI.parse _namespace_name "theory" |> NamespacedName
    /// <summary>
    /// We are proposing here a restrictive notion of goal that relies upon its desirability by some agent, which does not necessarily play a role in the execution of the plan the goal is a part of. For example, an agent can have an attitude towards some task defined in a plan, e.g. duty towards, which is different from desiring it (desire towards). We might say that a goal is usually desired by the creator or beneficiary of a plan. The minimal constraint for a goal is that it is a proper part of a plan. For example, a desire to start a relationship can become a goal if someone decides to take action (or lets someone else take it for her sake) to obtain it.
    /// A goal is different from anobjective, because the second one is independent from the cognitive state of a particular physical agent.
    /// In practice, an agent (physical or social) may aim at realizing an objective even though the realizing situation conflicts with a goal-situation of the same agent.
    /// In 'private' plans of a physical agent,  realizing situations usually coincide with goal-situations.
    /// Different cases occur with plans endorsed by social agents like organizations, institutions, etc., which are more clearly aimed at realizing objectives.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#goal"></see></summary>
    let goal = Namespaced_IRI.parse _namespace_name "goal" |> NamespacedName

    /// <summary>
    /// When there is an 'epistemological layering', i.e. a description d involves another description d' (one of the roles in d classifies d'), a situation that satisfies d', will be in the scope of d as well.For example, a judgment procedure will have a legal case in its scope, but being a legal case depends on satisfying some legal description not identical to that procedure.Another example: a plan assessment is a technique to evaluate a plan execute, and the assessment 'has in scope' the plan execution.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#has-in-scope"></see></summary>
    let ``has-in-scope`` =
        Namespaced_IRI.parse _namespace_name "has-in-scope" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#in-scope-of"></see>
    /// </summary>
    let ``in-scope-of`` =
        Namespaced_IRI.parse _namespace_name "in-scope-of" |> NamespacedName

    /// <summary>
    /// An activity expected by a method.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#has-method"></see></summary>
    let ``has-method`` =
        Namespaced_IRI.parse _namespace_name "has-method" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#method-of"></see>
    /// </summary>
    let ``method-of`` =
        Namespaced_IRI.parse _namespace_name "method-of" |> NamespacedName

    /// <summary>
    /// A parameter valued by regions that are used asindicators for some behaviour or event to be checked.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#indicator"></see></summary>
    let indicator = Namespaced_IRI.parse _namespace_name "indicator" |> NamespacedName

    /// <summary>
    /// An information encoding system is a description that involves information objects. They can be divided into 1) axiomatic systems, which provide roles and operations to define formal descriptions (e.g. theories), 2) combinatorial systems, which provide roles and operations to create valid information objects (e.g. grammars), 3) classification systems, which are contexts of (ev. ordered) lists of information objects, and 4) informal encoding systems, which provide roles and operations to define informal descriptions (e.g. narratives).
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#information-encoding-system"></see></summary>
    let ``information-encoding-system`` =
        Namespaced_IRI.parse _namespace_name "information-encoding-system" |> NamespacedName

    /// <summary>
    /// a.k.a. 'expressed according to'. The relation between information objects and the languages, codes, grammars, etc. that they are ordered by. E.g. Dante's Comedy is ordered by Middle Age Italian language (in this case, a complex of encoding systems).In principle, any description can be used as an encoding system, but in practice, only some combinatorial systems are used for encoding (see module on 'information objects').
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#ordered-by"></see></summary>
    let ``ordered-by`` =
        Namespaced_IRI.parse _namespace_name "ordered-by" |> NamespacedName

    /// <summary>
    /// Any physical particular that realizes a non-physical endurant. Such physical particulars can be either physical endurants, physical qualities, physical regions, perdurants with at least one physical participant, or a situation with one physical entity in its setting.Ultimately, a physical realization depends on at least one physical endurant (each of the others physical entity types depend on a physical endurant to be considered as such).
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#physical-realization"></see></summary>
    let ``physical-realization`` =
        Namespaced_IRI.parse _namespace_name "physical-realization" |> NamespacedName

    /// <summary>
    /// a.k.a. support.A (usually physical) representation (p. endurant, p. perdurant, p. quality, p. region, or p. situation) realizes a non-physical object according to a system of rules.The main use of this relation is between information objects and the entities through which information objects are used and interpreted. E.g. a paper copy of the 1861 edition of Dante's Comedy, with Dore's illustrations, realizes the Comedy (as an information object).There is a sense in which any entity that realizes an IO also realizes an IO about itself.For example, a painting realizing information about a woman also realizes information about its own information. Of course, the converse of the previous axiom does not hold in general.For example, the information about a woman can be realized by entities different from that woman (as when referring to an absent woman). In other words, an entity (in a semiotic perspective) always realizes two information objects: one about itself, and another about something else.In the non-representation cases, the information objects are identical (an entity only realizes information about itself).Therefore entities, once they have a relevance in a society, can have semiotic properties. Even physical artifacts that are not built primarily for communicative purposes  e.g. a chair  can be considered as realizing some IO that expresses a design description (cf. system-design), and is about a context (situation) of use, fruition, or just affordance that satisfies the design.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#realized-by"></see></summary>
    let ``realized-by`` =
        Namespaced_IRI.parse _namespace_name "realized-by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#instantiated-by"></see>
    /// </summary>
    let ``instantiated-by`` =
        Namespaced_IRI.parse _namespace_name "instantiated-by" |> NamespacedName

    /// <summary>
    /// The maximal specialization achievable according to some criterion. Only applicable to social objects that logically reify set-related entities (relations, classes, sets).
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#instantiates"></see></summary>
    let instantiates =
        Namespaced_IRI.parse _namespace_name "instantiates" |> NamespacedName

    /// <summary>
    /// Specialization as reification of a partial-order relation between social objects. For example, concepts that are apparently classified by other concepts; e.g. a manager that plays the role of buyer, where the role manager actually specializes the role buyer. Descriptions can be specialized by other descriptions that specialize their concepts or figures. For descriptions, an intention to specialize must be present (unless purely formal theories are considered, but even in this case a criterion of relevance is usually active). Specialization does not imply expansion (proper part) for descriptions. If there exists a concept that is defined by the specialized description, which is not d-used in the specializing one, the second only specializes a part of the first. If there exists a concept that is defined by the specializing description, which is not d-used by the specialized one, the first both specializes and expands the second.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#specializes"></see></summary>
    let specializes =
        Namespaced_IRI.parse _namespace_name "specializes" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#interpreted-by"></see>
    /// </summary>
    let ``interpreted-by`` =
        Namespaced_IRI.parse _namespace_name "interpreted-by" |> NamespacedName

    /// <summary>
    /// The relation between agents and information objects. In order to interpret something, an agent should conceive a description that results to be 'expressed by' that information object.Interprets implies that an expressed description is conceived by the agent (i.e., when an agent interprets an IO, it conceives of a description expressed by the IO; of course two agents can conceive of different descriptions, then resulting in different interpretations).
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#interprets"></see></summary>
    let interprets = Namespaced_IRI.parse _namespace_name "interprets" |> NamespacedName

    /// <summary>
    /// The course of events typical of the life of an object (kind).
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#life-cycle"></see></summary>
    let ``life-cycle`` =
        Namespaced_IRI.parse _namespace_name "life-cycle" |> NamespacedName

    /// <summary>
    /// This is the immediate relation between courses and perdurants. A course can be either atomic, being a simple 'perdurant role', or it can be complex, thus creating an abstract ordering over a temporal or causal sequence of processes or actions. The ontology of plans develops in detail intentional complex courses.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#sequences"></see></summary>
    let sequences = Namespaced_IRI.parse _namespace_name "sequences" |> NamespacedName

    /// <summary>
    /// A role used to express logical levels within some layering description or granular partition. A typical example is the Linnean taxonomic ordering, where Phylum or Species are hierarchical roles.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#logical-role"></see></summary>
    let ``logical-role`` =
        Namespaced_IRI.parse _namespace_name "logical-role" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#made-by"></see>
    /// </summary>
    let ``made-by`` = Namespaced_IRI.parse _namespace_name "made-by" |> NamespacedName
    /// <summary>
    /// A particular case of an endurant participating in a perdurant that meets (is connected to the beginning of) the life of another endurant.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#makes"></see></summary>
    let makes = Namespaced_IRI.parse _namespace_name "makes" |> NamespacedName

    /// <summary>
    /// No easy definition of artifactual properties is possible, hence it is better to rely on alternative descriptions and roles: a physical object that shows or is known to have an artifactual origin that counts in the tasks an ontology is supposed to support, will be a material artifact. On the other hand, physical objects that do not show that origin, or that origin is unimportant for the task of the ontology, will be physical bodies. Formally, a restriction is provided here that requires that the collection whose members are (at least some of the) proper parts of a material artifact is *unified* by a plan or project.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#material-artifact"></see></summary>
    let ``material-artifact`` =
        Namespaced_IRI.parse _namespace_name "material-artifact" |> NamespacedName

    /// <summary>
    /// A project is a proactively satisfied method. Additionally to a plan, a project includes at least one 'product' role to be played by some endurant (e.g. a house), or one 'result' role played by a perdurant with a definite participant (e.g. a restored state of a house).
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#project"></see></summary>
    let project = Namespaced_IRI.parse _namespace_name "project" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#member-of"></see>
    /// </summary>
    let ``member-of`` =
        Namespaced_IRI.parse _namespace_name "member-of" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#metaphorically-played-by"></see>
    /// </summary>
    let ``metaphorically-played-by`` =
        Namespaced_IRI.parse _namespace_name "metaphorically-played-by" |> NamespacedName

    /// <summary>
    /// An endurant of type e1 metaphorically plays a role (defined in a description d2), when that role comes from a metaphorical mapping between the description d1 that grants a unity criterion to endurants of type e1, and another description d2 that grants a unity criterion to endurants of type e2.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#metaphorically-plays"></see></summary>
    let ``metaphorically-plays`` =
        Namespaced_IRI.parse _namespace_name "metaphorically-plays" |> NamespacedName

    /// <summary>
    /// The purpose of an agent, either physical or social. It is different from a desire or goal, because it is independent from the cognitive state of a particular physical agent.
    /// In practice, an agent (physical or social) may aim at realizing an objective even though the realizing situation conflicts with a goal-situation of the same agent.
    /// In 'private' plans of a physical agent,  realizing situations usually coincide with goal-situations.
    /// Different cases occur with plans endorsed by social agents like organizations, institutions, etc.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#objective"></see></summary>
    let objective = Namespaced_IRI.parse _namespace_name "objective" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#obligation-for"></see>
    /// </summary>
    let ``obligation-for`` =
        Namespaced_IRI.parse _namespace_name "obligation-for" |> NamespacedName

    /// <summary>
    /// A relation between a role and a duty binding towards some function/task.This is dispositional, and implies that a participation classified by this relation is a 'due participation'.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#obliged-to"></see></summary>
    let ``obliged-to`` =
        Namespaced_IRI.parse _namespace_name "obliged-to" |> NamespacedName

    /// <summary>
    /// A task (as any other concept) can be optional within some plan (or any description). In this case, it can be ignored in plan execution without affecting the satisfaction of the plan.Within plans, an task said to be optional should be placed in a way that preserves the topology (the connectedness) of the maximal task, except for sequential tasks, where it can be skipped without affecting the control structure. In fact, an optional task must either be component of a bag or sequential task, or have the concurrent task or the any-order task as a direct predecessor.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#optionally-used-by"></see></summary>
    let ``optionally-used-by`` =
        Namespaced_IRI.parse _namespace_name "optionally-used-by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#optionally-uses"></see>
    /// </summary>
    let ``optionally-uses`` =
        Namespaced_IRI.parse _namespace_name "optionally-uses" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#orders"></see>
    /// </summary>
    let orders = Namespaced_IRI.parse _namespace_name "orders" |> NamespacedName
    /// <summary>
    /// P-SAT assumes two satisfaction semantics: redundant satisfaction and qualified satisfaction. In order to allow for a correct implementation of the qualified satisfaction, P-SAT requires that the description exists prior to at least some of the entities in the setting of the satisfying situation. Ontologically, it results that P-SAT also implies a specific dependency of the situation on its description. P-SAT typically applies to plans, projects, designs, methods, techniques, game rules, instructions, punishment rules, constitutive descriptions, sanctions, and strategies.A sample P-SAT qualified satisfaction axiom for plans is given in OWL.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#p-sat"></see></summary>
    let ``p-sat`` = Namespaced_IRI.parse _namespace_name "p-sat" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#p-sat-by"></see>
    /// </summary>
    let ``p-sat-by`` = Namespaced_IRI.parse _namespace_name "p-sat-by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#valued-by"></see>
    /// </summary>
    let ``valued-by`` =
        Namespaced_IRI.parse _namespace_name "valued-by" |> NamespacedName

    /// <summary>
    /// The mediated relation between an entity and a parameter through the region at which the entity is localized and that is the value for the parameter.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#parametrized-by"></see></summary>
    let ``parametrized-by`` =
        Namespaced_IRI.parse _namespace_name "parametrized-by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#parametrizes"></see>
    /// </summary>
    let parametrizes =
        Namespaced_IRI.parse _namespace_name "parametrizes" |> NamespacedName

    /// <summary>
    /// A course used to sequence phenomena (non-intentional processes).
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#path"></see></summary>
    let path = Namespaced_IRI.parse _namespace_name "path" |> NamespacedName
    /// <summary>
    /// A phenomenon is basically a process that does not include any intentional active participation. Therefore, it cannot be sequenced by a task.It can be seen as an accomplishment when some intentionality puts boundaries on it (although it is not claimed to be inherently intentional). On the other hand, a purely physical phenomenon does not seem to have inherent boundaries either ... and also for biological processes as well as economic processes this seems to be disputable. If the boundary hypothesis is discarded, phenomenon should migrate under process.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#phenomenon"></see></summary>
    let phenomenon = Namespaced_IRI.parse _namespace_name "phenomenon" |> NamespacedName

    /// <summary>
    /// A figure can personify a particular, e.g. the holy grail or a goddess, or an organization, which personifies a (postulated) collective.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#personified-by"></see></summary>
    let ``personified-by`` =
        Namespaced_IRI.parse _namespace_name "personified-by" |> NamespacedName

    /// <summary>
    /// A phenomenon having a physical endurant as participant.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#physical-phenomenon"></see></summary>
    let ``physical-phenomenon`` =
        Namespaced_IRI.parse _namespace_name "physical-phenomenon" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#realizes"></see>
    /// </summary>
    let realizes = Namespaced_IRI.parse _namespace_name "realizes" |> NamespacedName

    /// <summary>
    /// The relation between a situation and the entities that are referenced by it. (At least some of, or all) such entities must be classified by concepts defined by the description that the situation is supposed to satisfy.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#setting-for"></see></summary>
    let ``setting-for`` =
        Namespaced_IRI.parse _namespace_name "setting-for" |> NamespacedName

    /// <summary>
    /// A social method carried out explicitly or by tradition, spontaneously emerged, or moderately or strongly regulated.
    /// A practice has more relaxed constraints than a plan, and it's characterized by its adoption a agentive social object, e.g. a community.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#practice"></see></summary>
    let practice = Namespaced_IRI.parse _namespace_name "practice" |> NamespacedName
    /// <summary>
    /// R-SAT assumes redundant satisfaction and qualified satisfaction, but it works out that semantics with entities in the situation that entirely exist prior to the description.This seems paradoxical, since a description hardly motivates what happens if it is not present to any agent involved in things happening. For this reason, we postulate a so-called specific retroactive dependency (SRD), meaning that the creator of the description is willing to attribute the status of a scientific law to that description, despite it could not be present before the situation. R-SAT typically applies to explanations that are considered as well-founded in science (physical, social, or cognitive), reverse engineering, criminal investigation, etc. Consider that the actual validity of the explanation is not addressed by the description, but by external evaluation descriptions.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#r-sat"></see></summary>
    let ``r-sat`` = Namespaced_IRI.parse _namespace_name "r-sat" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#r-sat-by"></see>
    /// </summary>
    let ``r-sat-by`` = Namespaced_IRI.parse _namespace_name "r-sat-by" |> NamespacedName

    /// <summary>
    /// In this ontology, a rational object is encoded as having the ability to internally represent meta-descriptions (descriptions that have other descriptions playing roles used by them). Other theories of rational agency assume desires and intentions for these objects, but in principle any agent can have desires and intentions: the very difference seems to be the ability to choose among different desires or intentions by going 'meta-level'.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#rational-physical-object"></see></summary>
    let ``rational-physical-object`` =
        Namespaced_IRI.parse _namespace_name "rational-physical-object" |> NamespacedName

    /// <summary>
    /// Reconstructed fluxes are fluxes that only contain accomplishments as members.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#reconstructed-flux"></see></summary>
    let ``reconstructed-flux`` =
        Namespaced_IRI.parse _namespace_name "reconstructed-flux" |> NamespacedName

    /// <summary>
    /// Concepts and figures can be refined by adding components, e.g. an elementary task can become complex, a complex task can increase its complexity, maximal tasks can be composed, etc.A description gets expanded if one of the concepts or figures it uses are refined.Refinement applies also to collections, situations, and information objects.Descriptions are refined by adding component descriptions.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#refines"></see></summary>
    let refines = Namespaced_IRI.parse _namespace_name "refines" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#regulated-by"></see>
    /// </summary>
    let ``regulated-by`` =
        Namespaced_IRI.parse _namespace_name "regulated-by" |> NamespacedName

    /// <summary>
    /// A description usually requiring a C-SAT satisfaction for a situation. Norms, codes of practice, etc. are examples.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#regulation"></see></summary>
    let regulation = Namespaced_IRI.parse _namespace_name "regulation" |> NamespacedName
    /// <summary>
    /// A regulation states reified conditions on how a situation should look like. Regulations are mostly taken as descriptions for the social world.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#regulates"></see></summary>
    let regulates = Namespaced_IRI.parse _namespace_name "regulates" |> NamespacedName

    /// <summary>
    /// Examples of Social Descriptions are laws, norms, shares, peace treaties, etc., which are generically dependent on societies.Social descriptions are dependent on a community of agents.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#social-description"></see></summary>
    let ``social-description`` =
        Namespaced_IRI.parse _namespace_name "social-description" |> NamespacedName

    /// <summary>
    /// A non-social relation(ship): formal, linguistic, etc. It is considered here a theory, because relations are established in order to give an ordering to some reality.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#relation"></see></summary>
    let relation = Namespaced_IRI.parse _namespace_name "relation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#required-by"></see>
    /// </summary>
    let ``required-by`` =
        Namespaced_IRI.parse _namespace_name "required-by" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#requires"></see>
    /// </summary>
    let requires = Namespaced_IRI.parse _namespace_name "requires" |> NamespacedName
    /// <summary>
    /// Requisites are constraints over the attributes of entities. Within DnS, a requisite-for relation holds between parameters (that bound regions to certain value ranges), and either roles, figures or courses. When a situation satisfies a description with parameters, endurants and perdurants in the situation must have attributes that range within the boundaries stated by parameters (in DOLCE terms, entities must have qualities that are mapped to certain value ranges of regions).
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#requisite"></see></summary>
    let requisite = Namespaced_IRI.parse _namespace_name "requisite" |> NamespacedName

    /// <summary>
    /// Requisites are constraints over the attributes of entities. Within DnS, a requisite-for relation holds between parameters (that bound regions to certain value ranges), and either roles, figures or courses. When a situation satisfies a description with parameters, endurants and perdurants in the situation must have attributes that range within the boundaries stated by parameters (in DOLCE terms, entities must have qualities that are mapped to certain value ranges of regions).
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#requisite-for"></see></summary>
    let ``requisite-for`` =
        Namespaced_IRI.parse _namespace_name "requisite-for" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#right-task-for"></see>
    /// </summary>
    let ``right-task-for`` =
        Namespaced_IRI.parse _namespace_name "right-task-for" |> NamespacedName

    /// <summary>
    /// A relation between a role and a right allowance towards some function/task.This is dispositional, and implies that a participation classified by this relation is a 'righteous participation'.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#right-to"></see></summary>
    let ``right-to`` = Namespaced_IRI.parse _namespace_name "right-to" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#setting"></see>
    /// </summary>
    let setting = Namespaced_IRI.parse _namespace_name "setting" |> NamespacedName

    /// <summary>
    /// A highly mediated relation used to talk of the endurant(s) that is roughly associated to the regions in which the constituents of a situation are located. The locator endurant is supposed to be a situation constituent on its own.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#situation-place"></see></summary>
    let ``situation-place`` =
        Namespaced_IRI.parse _namespace_name "situation-place" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#situation-place-of"></see>
    /// </summary>
    let ``situation-place-of`` =
        Namespaced_IRI.parse _namespace_name "situation-place-of" |> NamespacedName

    /// <summary>
    /// A social description defining roles for the interaction of rational agents.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#social-relationship"></see></summary>
    let ``social-relationship`` =
        Namespaced_IRI.parse _namespace_name "social-relationship" |> NamespacedName

    /// <summary>
    /// A role created and maintained by a society.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#social-role"></see></summary>
    let ``social-role`` =
        Namespaced_IRI.parse _namespace_name "social-role" |> NamespacedName

    /// <summary>
    /// A role that involves responsibility, e.g. both duties and rights, in order to perform some task. It usually involves additional rights and/or powers in contexts (descriptions) different from the one that defines the status.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#status"></see></summary>
    let status = Namespaced_IRI.parse _namespace_name "status" |> NamespacedName

    /// <summary>
    /// A role played exactly by two objects at the same time, e.g.: brother, sibling.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#symmetric-role"></see></summary>
    let ``symmetric-role`` =
        Namespaced_IRI.parse _namespace_name "symmetric-role" |> NamespacedName

    /// <summary>
    /// A technique is a practical method to obtain some modification in the environment (or evaluation of an environment) that fulfils some task.
    /// Differently from a plan, a technique does not necessarily contains a goal or objective as a proper part.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#technique"></see></summary>
    let technique = Namespaced_IRI.parse _namespace_name "technique" |> NamespacedName

    /// <summary>
    /// Being component at time t. It holds for endurants only. This is important to model components that can change or be lost over time without affecting the identity of the whole.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#temporary-component"></see></summary>
    let ``temporary-component`` =
        Namespaced_IRI.parse _namespace_name "temporary-component" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#temporary-component-of"></see>
    /// </summary>
    let ``temporary-component-of`` =
        Namespaced_IRI.parse _namespace_name "temporary-component-of" |> NamespacedName

    /// <summary>
    /// Based on characterizing roles, collections specifically depend on some description.We can therefore build a new relation of unification between collections and the descriptions on which they depend. Unification is axiomatized by means of sufficient conditions, and is not temporalized, since changing the description (differently from changing some members) creates a new collection.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#unifies"></see></summary>
    let unifies = Namespaced_IRI.parse _namespace_name "unifies" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#used-by"></see>
    /// </summary>
    let ``used-by`` = Namespaced_IRI.parse _namespace_name "used-by" |> NamespacedName
    /// <summary>
    /// The use relations between endurants: an endurant e1 uses e2 within a perdurant in which both are participating. A rule then states that if e1 uses e2, e2 is used *in* a perdurant.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#uses"></see></summary>
    let uses = Namespaced_IRI.parse _namespace_name "uses" |> NamespacedName

    /// <summary>
    /// The "selected by" relations holding between regions and parameters. At least one region is supposed to be a value for a parameter.
    /// <see href="http://www.loa-cnr.it/ontologies/ExtendedDnS.owl#value-for"></see></summary>
    let ``value-for`` =
        Namespaced_IRI.parse _namespace_name "value-for" |> NamespacedName
