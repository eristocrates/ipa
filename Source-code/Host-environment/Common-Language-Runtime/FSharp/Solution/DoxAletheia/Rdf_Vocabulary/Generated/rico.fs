namespace https.www.ica.org.standards.RiC.ontology.hash

open DoxAletheia

module rico =
    let _namespace_name = "https://www.ica.org/standards/RiC/ontology#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Connects at least one Record Resource or Instantiation to at
    ///             least one Agent, when the Agent accumulates it, be it intentionally (collecting it) or
    ///             not (receiving it in the course of its activities).
    /// <see href="https://www.ica.org/standards/RiC/ontology#AccumulationRelation"></see></summary>
    let AccumulationRelation = _prefix "AccumulationRelation"
    /// <summary>
    /// Connects an Accumulation Relation to one of the accumulated
    ///             Record Resources or Instantiations
    /// <see href="https://www.ica.org/standards/RiC/ontology#accumulationRelationHasSource"></see></summary>
    let accumulationRelationHasSource = _prefix "accumulationRelationHasSource"
    /// <summary>
    /// The inscription of information made by an Agent on a physical
    ///             carrier in any persistent, recoverable form as a means of communicating information
    ///             through time and space.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Instantiation"></see></summary>
    let Instantiation = _prefix "Instantiation"
    /// <summary>
    /// A Record, Record Set, or Record Part produced or acquired and
    ///             retained by an Agent in the course of Activity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#RecordResource"></see></summary>
    let RecordResource = _prefix "RecordResource"
    /// <summary>
    /// Connects an Accumulation Relation to one of the accumulating
    ///             Agents
    /// <see href="https://www.ica.org/standards/RiC/ontology#accumulationRelationHasTarget"></see></summary>
    let accumulationRelationHasTarget = _prefix "accumulationRelationHasTarget"
    /// <summary>
    /// A Person, or Group, or an entity created by a Person or Group
    ///             (Mechanism), or a Position, that acts in the world.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Agent"></see></summary>
    let Agent = _prefix "Agent"
    /// <summary>
    /// Connects at least one Record Resource or an Instantiation to at
    ///             least one Agent that creates or accumulates the Record Resource, receives it, or sends
    ///             it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#AgentOriginationRelation"></see></summary>
    let AgentOriginationRelation = _prefix "AgentOriginationRelation"
    /// <summary>
    /// When it exists, specifies the identifier and name of RiC-CM
    ///             component that corresponds to the annotated class or property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#RiCCMCorrespondingComponent"></see></summary>
    let RiCCMCorrespondingComponent = _prefix "RiCCMCorrespondingComponent"
    /// <summary>
    /// The doing of something for some human purpose.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Activity"></see></summary>
    let Activity = _prefix "Activity"
    /// <summary>
    /// Connects an Activity to an Activity Type that categorizes
    ///             it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasActivityType"></see></summary>
    let hasActivityType = _prefix "hasActivityType"
    /// <summary>
    /// Categorization of an Activity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#ActivityType"></see></summary>
    let ActivityType = _prefix "ActivityType"
    /// <summary>
    /// Something that happens in time and space.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Event"></see></summary>
    let Event = _prefix "Event"
    /// <summary>
    /// Connects an Activity to an Agent that performed or performs the
    ///             Activity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasPerformedBy"></see></summary>
    let isOrWasPerformedBy = _prefix "isOrWasPerformedBy"
    /// <summary>
    /// Connects at least one Record Resource or Instantiation to at
    ///             least one Activity, when the Record Resource or Instantiation results from the
    ///             activity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#ActivityDocumentationRelation"></see></summary>
    let ActivityDocumentationRelation = _prefix "ActivityDocumentationRelation"

    /// <summary>
    /// Connects an Activity Documentation Relation to one of the
    ///             resulting Record Resources or Instantiations
    /// <see href="https://www.ica.org/standards/RiC/ontology#activityDocumentationRelationHasSource"></see></summary>
    let activityDocumentationRelationHasSource =
        _prefix "activityDocumentationRelationHasSource"

    /// <summary>
    /// Connects an Activity Documentation Relation to one of the
    ///             documented Activities
    /// <see href="https://www.ica.org/standards/RiC/ontology#activityDocumentationRelationHasTarget"></see></summary>
    let activityDocumentationRelationHasTarget =
        _prefix "activityDocumentationRelationHasTarget"

    /// <summary>
    /// Specifies the provenance or origin of at least one Record
    ///             Resource or Instantiation, for example the relation between a Record Resource and the
    ///             Agent which created it or the Activity from which it resulted.
    /// <see href="https://www.ica.org/standards/RiC/ontology#ProvenanceRelation"></see></summary>
    let ProvenanceRelation = _prefix "ProvenanceRelation"
    /// <summary>
    /// Connects an Activity Type to an Activity that it
    ///             categorizes.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isActivityTypeOf"></see></summary>
    let isActivityTypeOf = _prefix "isActivityTypeOf"
    /// <summary>
    /// A superclass for any category of some thing. A type
    ///             characterizes an entity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Type"></see></summary>
    let Type = _prefix "Type"
    /// <summary>
    /// Any idea, material thing, or event within the realm of human
    ///             experience.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Thing"></see></summary>
    let Thing = _prefix "Thing"
    /// <summary>
    /// Connects at least one Agent, to at least another Agent, when the
    ///             first one(s) control(s) in a way the activities of the second one(s).
    /// <see href="https://www.ica.org/standards/RiC/ontology#AgentControlRelation"></see></summary>
    let AgentControlRelation = _prefix "AgentControlRelation"
    /// <summary>
    /// Connects an Agent Control Relation to one of the controlling
    ///             Agents
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentControlRelationHasSource"></see></summary>
    let agentControlRelationHasSource = _prefix "agentControlRelationHasSource"
    /// <summary>
    /// Connects an Agent Control Relation to one of the controlled
    ///             Agents
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentControlRelationHasTarget"></see></summary>
    let agentControlRelationHasTarget = _prefix "agentControlRelationHasTarget"
    /// <summary>
    /// Connects at least one Agent to at least another Agent, when the
    ///             first one is hierarchically superior to the second one.
    /// <see href="https://www.ica.org/standards/RiC/ontology#AgentHierarchicalRelation"></see></summary>
    let AgentHierarchicalRelation = _prefix "AgentHierarchicalRelation"
    /// <summary>
    /// Connects at least one Agent, and at least one Thing over which
    ///             the Agent has some authority.
    /// <see href="https://www.ica.org/standards/RiC/ontology#AuthorityRelation"></see></summary>
    let AuthorityRelation = _prefix "AuthorityRelation"

    /// <summary>
    /// Connects an Agent Hierarchical Relation to one of the
    ///             hierarchically superior Agents
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentHierarchicalRelationHasSource"></see></summary>
    let agentHierarchicalRelationHasSource =
        _prefix "agentHierarchicalRelationHasSource"

    /// <summary>
    /// Connects an Agent Hierarchical Relation to one of the
    ///             hierarchically inferior Agents
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentHierarchicalRelationHasTarget"></see></summary>
    let agentHierarchicalRelationHasTarget =
        _prefix "agentHierarchicalRelationHasTarget"

    /// <summary>
    /// Connects at least two Agents.
    /// <see href="https://www.ica.org/standards/RiC/ontology#AgentToAgentRelation"></see></summary>
    let AgentToAgentRelation = _prefix "AgentToAgentRelation"
    /// <summary>
    /// A label, title or term designating an Agent in order to make it
    ///             distinguishable from other similar entities.
    /// <see href="https://www.ica.org/standards/RiC/ontology#AgentName"></see></summary>
    let AgentName = _prefix "AgentName"
    /// <summary>
    /// A label, title or term designating the entity in order to make
    ///             it distinguishable from other similar entities.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Name"></see></summary>
    let Name = _prefix "Name"
    /// <summary>
    /// Connects an Agent Origination Relation to one of the resulting
    ///             Record Resource or Instantiation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentOriginationRelationHasSource"></see></summary>
    let agentOriginationRelationHasSource = _prefix "agentOriginationRelationHasSource"
    /// <summary>
    /// Connects an Agent Origination Relation to one of the creating or
    ///             accumulating Agents
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentOriginationRelationHasTarget"></see></summary>
    let agentOriginationRelationHasTarget = _prefix "agentOriginationRelationHasTarget"
    /// <summary>
    /// Connects at least one Agent, to at least another Agent, that
    ///             succeeds it chronologically for, for instance, fullfilling some functions or performing
    ///             some activities.
    /// <see href="https://www.ica.org/standards/RiC/ontology#AgentTemporalRelation"></see></summary>
    let AgentTemporalRelation = _prefix "AgentTemporalRelation"
    /// <summary>
    /// Connects at least one Thing to at least one Thing that follows
    ///             it in chronological order.
    /// <see href="https://www.ica.org/standards/RiC/ontology#TemporalRelation"></see></summary>
    let TemporalRelation = _prefix "TemporalRelation"
    /// <summary>
    /// Connects an Agent Temporal Relation to one of the successor
    ///             Agents
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentTemporalRelationHasTarget"></see></summary>
    let agentTemporalRelationHasTarget = _prefix "agentTemporalRelationHasTarget"
    /// <summary>
    /// Connects an Agent Temporal Relation or Mandate Relation, to an
    ///             Activity that is, either transferred from an Agent to another one, or assigned by a
    ///             Mandate to an Agent.
    /// <see href="https://www.ica.org/standards/RiC/ontology#asConcernsActivity"></see></summary>
    let asConcernsActivity = _prefix "asConcernsActivity"
    /// <summary>
    /// Connects an Agent Temporal Relation to one of the predecessor
    ///             Agents
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentTemporalRelationHasSource"></see></summary>
    let agentTemporalRelationHasSource = _prefix "agentTemporalRelationHasSource"
    /// <summary>
    /// Connects an Agent Relation to one of the involved
    ///             Agents
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentRelationConnects"></see></summary>
    let agentRelationConnects = _prefix "agentRelationConnects"
    /// <summary>
    /// The top level relation class. It connects at least two Things.
    ///             An instance of a Relation may have some datatype and object properties : a descriptive
    ///             note (datatype property) like any Thing ; certainty (for 'certain', 'quite probable',
    ///             'uncertain','unknown'); a date (use either the date datatype property or the Date class
    ///             and isAssociatedWithDate object property ; a state (relationState) ; a location (use
    ///             Place class and isAssociatedWithPlace object property) ; a source of information that
    ///             can be used as an evidence for it (use either source datatype property or hasSource
    ///             object property).
    /// <see href="https://www.ica.org/standards/RiC/ontology#Relation"></see></summary>
    let Relation = _prefix "Relation"
    /// <summary>
    /// A concept of any kind that is used for designating an Entity and
    ///             referring to it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Appellation"></see></summary>
    let Appellation = _prefix "Appellation"
    /// <summary>
    /// An idea, unit of thought, abstract cultural object or
    ///             category
    /// <see href="https://www.ica.org/standards/RiC/ontology#Concept"></see></summary>
    let Concept = _prefix "Concept"
    /// <summary>
    /// The relation between an Appellation and at least one Thing that
    ///             the Appellation designates.
    /// <see href="https://www.ica.org/standards/RiC/ontology#AppellationRelation"></see></summary>
    let AppellationRelation = _prefix "AppellationRelation"
    /// <summary>
    /// Connects an Appellation Relation to one of the designated
    ///             Things
    /// <see href="https://www.ica.org/standards/RiC/ontology#appellationRelationHasTarget"></see></summary>
    let appellationRelationHasTarget = _prefix "appellationRelationHasTarget"
    /// <summary>
    /// Connects an Appellation Relation to the concerned
    ///             Appellation
    /// <see href="https://www.ica.org/standards/RiC/ontology#appellationRelationHasSource"></see></summary>
    let appellationRelationHasSource = _prefix "appellationRelationHasSource"
    /// <summary>
    /// Connects an Authority Relation to an Agent that has the
    ///             authority
    /// <see href="https://www.ica.org/standards/RiC/ontology#authorityRelationHasSource"></see></summary>
    let authorityRelationHasSource = _prefix "authorityRelationHasSource"
    /// <summary>
    /// Connects an Authority Relation to a Thing over which the
    ///             Authority is performed
    /// <see href="https://www.ica.org/standards/RiC/ontology#authorityRelationHasTarget"></see></summary>
    let authorityRelationHasTarget = _prefix "authorityRelationHasTarget"
    /// <summary>
    /// Connects at least one Record to at least one Person, Group or
    ///             Position that is responsible for conceiving and formulating the information contained in
    ///             the Record.
    /// <see href="https://www.ica.org/standards/RiC/ontology#AuthorshipRelation"></see></summary>
    let AuthorshipRelation = _prefix "AuthorshipRelation"
    /// <summary>
    /// Connects an Authorship Relation to one of the Records involved
    ///             in the relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#authorshipRelationHasSource"></see></summary>
    let authorshipRelationHasSource = _prefix "authorshipRelationHasSource"
    /// <summary>
    /// Information inscribed at least once by any method on any
    ///             physical carrier in any persistent, recoverable form by an Agent in the course of life
    ///             or work Activity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Record"></see></summary>
    let Record = _prefix "Record"
    /// <summary>
    /// Connects an Authorship Relation to one of the author Person,
    ///             Group or Position.
    /// <see href="https://www.ica.org/standards/RiC/ontology#authorshipRelationHasTarget"></see></summary>
    let authorshipRelationHasTarget = _prefix "authorshipRelationHasTarget"
    /// <summary>
    /// Two or more Agents that act together as an Agent.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Group"></see></summary>
    let Group = _prefix "Group"
    /// <summary>
    /// A human being with a social identity or persona.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Person"></see></summary>
    let Person = _prefix "Person"
    /// <summary>
    /// The functional role of a Person within a Group.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Position"></see></summary>
    let Position = _prefix "Position"
    /// <summary>
    /// Connects at least one Record Resource or Instantiation to at
    ///             least one Agent, when the Agent is either responsible for all or some of the content of
    ///             the Record Resource, or is a contributor to the genesis or production of the
    ///             Instantiation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#CreationRelation"></see></summary>
    let CreationRelation = _prefix "CreationRelation"
    /// <summary>
    /// The extent of a Record Resource carrier
    /// <see href="https://www.ica.org/standards/RiC/ontology#CarrierExtent"></see></summary>
    let CarrierExtent = _prefix "CarrierExtent"
    /// <summary>
    /// Countable characteristics of the content of an entity expressed
    ///             as a quantity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Extent"></see></summary>
    let Extent = _prefix "Extent"
    /// <summary>
    /// Categorization of physical material in or on which information
    ///             is represented.
    /// <see href="https://www.ica.org/standards/RiC/ontology#CarrierType"></see></summary>
    let CarrierType = _prefix "CarrierType"
    /// <summary>
    /// Connects a Carrier Type to an Instantiation whose carrier it
    ///             categorizes.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isCarrierTypeOf"></see></summary>
    let isCarrierTypeOf = _prefix "isCarrierTypeOf"
    /// <summary>
    /// Connects at lest one Person, to at least another Person, when
    ///             the first has child the second one.
    /// <see href="https://www.ica.org/standards/RiC/ontology#ChildRelation"></see></summary>
    let ChildRelation = _prefix "ChildRelation"
    /// <summary>
    /// Connects a Child Relation to a parent Person
    /// <see href="https://www.ica.org/standards/RiC/ontology#childRelationHasSource"></see></summary>
    let childRelationHasSource = _prefix "childRelationHasSource"
    /// <summary>
    /// Connects a Child Relation to a child Person
    /// <see href="https://www.ica.org/standards/RiC/ontology#childRelationHasTarget"></see></summary>
    let childRelationHasTarget = _prefix "childRelationHasTarget"
    /// <summary>
    /// Connects at least one Person to at least another Person, when
    ///             the first has/have descendant the second one(s).
    /// <see href="https://www.ica.org/standards/RiC/ontology#DescendanceRelation"></see></summary>
    let DescendanceRelation = _prefix "DescendanceRelation"
    /// <summary>
    /// The fundamental form of communication in which a Record is
    ///             expressed and the human sense through which it is intended to be
    ///             perceived.
    /// <see href="https://www.ica.org/standards/RiC/ontology#ContentType"></see></summary>
    let ContentType = _prefix "ContentType"
    /// <summary>
    /// Connects a Content Type to a Record or Record Part whose content
    ///             it categorizes.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isContentTypeOf"></see></summary>
    let isContentTypeOf = _prefix "isContentTypeOf"
    /// <summary>
    /// Longitudinal and latitudinal information of a
    ///             Place.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Coordinates"></see></summary>
    let Coordinates = _prefix "Coordinates"
    /// <summary>
    /// Connects an instance of Coordinates to a Physical Location it
    ///             locates or located on earth, according to some reference system.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasCoordinatesOf"></see></summary>
    let isOrWasCoordinatesOf = _prefix "isOrWasCoordinatesOf"
    /// <summary>
    /// A delimitation of the physical territory of a
    ///             Place.
    /// <see href="https://www.ica.org/standards/RiC/ontology#PhysicalLocation"></see></summary>
    let PhysicalLocation = _prefix "PhysicalLocation"
    /// <summary>
    /// An organized group of persons that act together as an Agent, and
    ///             that has a recognized legal or social status.
    /// <see href="https://www.ica.org/standards/RiC/ontology#CorporateBody"></see></summary>
    let CorporateBody = _prefix "CorporateBody"
    /// <summary>
    /// Categorization of a Corporate Body.
    /// <see href="https://www.ica.org/standards/RiC/ontology#CorporateBodyType"></see></summary>
    let CorporateBodyType = _prefix "CorporateBodyType"
    /// <summary>
    /// Connects a Corporate Body Type to a Corporate Body that it
    ///             categorizes or categorized.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasCorporateBodyTypeOf"></see></summary>
    let isOrWasCorporateBodyTypeOf = _prefix "isOrWasCorporateBodyTypeOf"
    /// <summary>
    /// Connects at least two Persons, when they correspond to each
    ///             other.
    /// <see href="https://www.ica.org/standards/RiC/ontology#CorrespondenceRelation"></see></summary>
    let CorrespondenceRelation = _prefix "CorrespondenceRelation"
    /// <summary>
    /// Connects a Correspondence Relation to one of the Persons
    ///             involved
    /// <see href="https://www.ica.org/standards/RiC/ontology#correspondenceRelationConnects"></see></summary>
    let correspondenceRelationConnects = _prefix "correspondenceRelationConnects"
    /// <summary>
    /// Connects at least two Persons that directly know each other
    ///             during their existence. This relation is symmetric.
    /// <see href="https://www.ica.org/standards/RiC/ontology#KnowingRelation"></see></summary>
    let KnowingRelation = _prefix "KnowingRelation"
    /// <summary>
    /// Connects a Creation Relation to the Role Type that the creator
    ///             Agent(s) has in the creation process
    /// <see href="https://www.ica.org/standards/RiC/ontology#creationWithRole"></see></summary>
    let creationWithRole = _prefix "creationWithRole"
    /// <summary>
    /// The role an agent plays in some context (usually in some
    ///             creation relation). Not to be confused with a position (position of an agent in some
    ///             group). For example, a person who is the head of some corporate body may play the role
    ///             of annotator (of a record) in a creation relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#RoleType"></see></summary>
    let RoleType = _prefix "RoleType"
    /// <summary>
    /// Connects a Creation Relation to one of the created Record
    ///             Resources or Instantiations
    /// <see href="https://www.ica.org/standards/RiC/ontology#creationRelationHasSource"></see></summary>
    let creationRelationHasSource = _prefix "creationRelationHasSource"
    /// <summary>
    /// Connects a Creation Relation to one of the creator
    ///             Agents
    /// <see href="https://www.ica.org/standards/RiC/ontology#creationRelationHasTarget"></see></summary>
    let creationRelationHasTarget = _prefix "creationRelationHasTarget"
    /// <summary>
    /// Chronological information associated with an entity that
    ///             contributes to its identification and contextualization.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Date"></see></summary>
    let Date = _prefix "Date"
    /// <summary>
    /// Chronological information associated with an entity that
    ///             contributes to its identification and contextualization, that implies or explicitly
    ///             states a start date and end date.
    /// <see href="https://www.ica.org/standards/RiC/ontology#DateRange"></see></summary>
    let DateRange = _prefix "DateRange"
    /// <summary>
    /// Inverse of 'is beginning date of' object property
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasBeginningDate"></see></summary>
    let hasBeginningDate = _prefix "hasBeginningDate"
    /// <summary>
    /// Chronological information associated with an entity that
    ///             contributes to its identification and contextualization, related to a single point in
    ///             time.
    /// <see href="https://www.ica.org/standards/RiC/ontology#SingleDate"></see></summary>
    let SingleDate = _prefix "SingleDate"
    /// <summary>
    /// Inverse of 'is end date of' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasEndDate"></see></summary>
    let hasEndDate = _prefix "hasEndDate"
    /// <summary>
    /// Non-contiguous single dates or date ranges.
    /// <see href="https://www.ica.org/standards/RiC/ontology#DateSet"></see></summary>
    let DateSet = _prefix "DateSet"
    /// <summary>
    /// Categorization of a person according to characteristics such as
    ///             age, gender, education, place of origin, ethnic/cultural identification, religion,
    ///             etc.
    /// <see href="https://www.ica.org/standards/RiC/ontology#DemographicGroup"></see></summary>
    let DemographicGroup = _prefix "DemographicGroup"
    /// <summary>
    /// Connects an Instantiation to at least one Instantiation that is
    ///             derived from it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#DerivationRelation"></see></summary>
    let DerivationRelation = _prefix "DerivationRelation"
    /// <summary>
    /// Connects a Derivation Relation to one of the derived
    ///             Instantiations
    /// <see href="https://www.ica.org/standards/RiC/ontology#derivationRelationHasTarget"></see></summary>
    let derivationRelationHasTarget = _prefix "derivationRelationHasTarget"
    /// <summary>
    /// Connects a Derivation Relation to the Instantiation from which
    ///             one or more Instantiations is derived.
    /// <see href="https://www.ica.org/standards/RiC/ontology#derivationRelationHasSource"></see></summary>
    let derivationRelationHasSource = _prefix "derivationRelationHasSource"

    /// <summary>
    /// Connects at least two instantiations
    /// <see href="https://www.ica.org/standards/RiC/ontology#InstantiationToInstantiationRelation"></see></summary>
    let InstantiationToInstantiationRelation =
        _prefix "InstantiationToInstantiationRelation"

    /// <summary>
    /// Connects a Descendance Relation to one of the ancestor
    ///             Persons
    /// <see href="https://www.ica.org/standards/RiC/ontology#descendanceRelationHasSource"></see></summary>
    let descendanceRelationHasSource = _prefix "descendanceRelationHasSource"
    /// <summary>
    /// Connects a Descendance Relation to one of the descendant
    ///             Persons
    /// <see href="https://www.ica.org/standards/RiC/ontology#descendanceRelationHasTarget"></see></summary>
    let descendanceRelationHasTarget = _prefix "descendanceRelationHasTarget"
    /// <summary>
    /// Connects at least two Persons, when they have some family link,
    ///             i.e. belong to the same family.
    /// <see href="https://www.ica.org/standards/RiC/ontology#FamilyRelation"></see></summary>
    let FamilyRelation = _prefix "FamilyRelation"
    /// <summary>
    /// Categorization of the document with respect to its extrinsic and
    ///             intrinsic elements that together communicate its content, administrative and documentary
    ///             context, and authority
    /// <see href="https://www.ica.org/standards/RiC/ontology#DocumentaryFormType"></see></summary>
    let DocumentaryFormType = _prefix "DocumentaryFormType"
    /// <summary>
    /// Connects a Documentary Form Type to a Record or Record Part that
    ///             it categorizes.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isDocumentaryFormTypeOf"></see></summary>
    let isDocumentaryFormTypeOf = _prefix "isDocumentaryFormTypeOf"
    /// <summary>
    /// Part of a Record with discrete information content that
    ///             contributes to the Record's physical or intellectual completeness.
    /// <see href="https://www.ica.org/standards/RiC/ontology#RecordPart"></see></summary>
    let RecordPart = _prefix "RecordPart"
    /// <summary>
    /// Connects an Event to an Event Type which categorizes
    ///             it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasEventType"></see></summary>
    let hasEventType = _prefix "hasEventType"
    /// <summary>
    /// Categorization of an Event.
    /// <see href="https://www.ica.org/standards/RiC/ontology#EventType"></see></summary>
    let EventType = _prefix "EventType"
    /// <summary>
    /// An annotation property for recording a possible mapping to a
    ///             component in another model or ontology
    /// <see href="https://www.ica.org/standards/RiC/ontology#closeTo"></see></summary>
    let closeTo = _prefix "closeTo"
    /// <summary>
    /// Connects at least one Event to at least one Thing, when the
    ///             first is associated with the existence and lifecycle of the second one.
    /// <see href="https://www.ica.org/standards/RiC/ontology#EventRelation"></see></summary>
    let EventRelation = _prefix "EventRelation"
    /// <summary>
    /// Connects an Event Relation to an Event
    /// <see href="https://www.ica.org/standards/RiC/ontology#eventRelationHasSource"></see></summary>
    let eventRelationHasSource = _prefix "eventRelationHasSource"
    /// <summary>
    /// Connects an Event Relation to an associated Thing
    /// <see href="https://www.ica.org/standards/RiC/ontology#eventRelationHasTarget"></see></summary>
    let eventRelationHasTarget = _prefix "eventRelationHasTarget"
    /// <summary>
    /// Connects an Event Type to an Event that is
    ///             categorizes.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isEventTypeOf"></see></summary>
    let isEventTypeOf = _prefix "isEventTypeOf"
    /// <summary>
    /// Categorization of the extent that is being measured
    /// <see href="https://www.ica.org/standards/RiC/ontology#ExtentType"></see></summary>
    let ExtentType = _prefix "ExtentType"
    /// <summary>
    /// Two or more persons related by birth, or through marriage,
    ///             adoption, civil union, or other social conventions that bind them together as a socially
    ///             recognized familial group.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Family"></see></summary>
    let Family = _prefix "Family"
    /// <summary>
    /// Connects a Family Relation to a Person.
    /// <see href="https://www.ica.org/standards/RiC/ontology#familyRelationConnects"></see></summary>
    let familyRelationConnects = _prefix "familyRelationConnects"
    /// <summary>
    /// Categorization of a Family.
    /// <see href="https://www.ica.org/standards/RiC/ontology#FamilyType"></see></summary>
    let FamilyType = _prefix "FamilyType"
    /// <summary>
    /// Connects a Family Type to a Family that is
    ///             categorizes.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isFamilyTypeOf"></see></summary>
    let isFamilyTypeOf = _prefix "isFamilyTypeOf"
    /// <summary>
    /// Connects at least two Instantiations which may be considered as
    ///             equivalent.
    /// <see href="https://www.ica.org/standards/RiC/ontology#FunctionalEquivalenceRelation"></see></summary>
    let FunctionalEquivalenceRelation = _prefix "FunctionalEquivalenceRelation"

    /// <summary>
    /// Connects a Functional Equivalence Relation to one of the
    ///             functionally equivalent Instantiations.
    /// <see href="https://www.ica.org/standards/RiC/ontology#functionalEquivalenceRelationConnects"></see></summary>
    let functionalEquivalenceRelationConnects =
        _prefix "functionalEquivalenceRelationConnects"

    /// <summary>
    /// A process or system created by a Person or Group that performs
    ///             an Activity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Mechanism"></see></summary>
    let Mechanism = _prefix "Mechanism"
    /// <summary>
    /// Connects a Group and at least another Group, when the first one
    ///             as the second one(s) among its subdivisions.
    /// <see href="https://www.ica.org/standards/RiC/ontology#GroupSubdivisionRelation"></see></summary>
    let GroupSubdivisionRelation = _prefix "GroupSubdivisionRelation"
    /// <summary>
    /// Connects a Group Subdivision Relation to one of the Groups that
    ///             is a subdivision
    /// <see href="https://www.ica.org/standards/RiC/ontology#groupSubdivisionRelationHasTarget"></see></summary>
    let groupSubdivisionRelationHasTarget = _prefix "groupSubdivisionRelationHasTarget"
    /// <summary>
    /// Connects a Group Subdivision Relation to the Group that has
    ///             subdivisions
    /// <see href="https://www.ica.org/standards/RiC/ontology#groupSubdivisionRelationHasSource"></see></summary>
    let groupSubdivisionRelationHasSource = _prefix "groupSubdivisionRelationHasSource"
    /// <summary>
    /// Connects a Thing to at least one constitutive or component part
    ///             of that Thing.
    /// <see href="https://www.ica.org/standards/RiC/ontology#WholePartRelation"></see></summary>
    let WholePartRelation = _prefix "WholePartRelation"
    /// <summary>
    /// A word, number, letter, symbol, or any combination of these used
    ///             to uniquely identify or reference an individual instance of an entity within a specific
    ///             information domain.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Identifier"></see></summary>
    let Identifier = _prefix "Identifier"
    /// <summary>
    /// Connects an Identifier and an Identifier Type that categorizes
    ///             it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasIdentifierType"></see></summary>
    let hasIdentifierType = _prefix "hasIdentifierType"
    /// <summary>
    /// Categorization of an Identifier.
    /// <see href="https://www.ica.org/standards/RiC/ontology#IdentifierType"></see></summary>
    let IdentifierType = _prefix "IdentifierType"
    /// <summary>
    /// Connects an Identifier Type and an Identifier that it
    ///             categorizes.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isIdentifierTypeOf"></see></summary>
    let isIdentifierTypeOf = _prefix "isIdentifierTypeOf"
    /// <summary>
    /// Connects an Instantiation to a Carrier Type which categorizes
    ///             its carrier.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasCarrierType"></see></summary>
    let hasCarrierType = _prefix "hasCarrierType"
    /// <summary>
    /// Connects an Instantiation to a Representation Type that
    ///             categorizes its representation type.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasRepresentationType"></see></summary>
    let hasRepresentationType = _prefix "hasRepresentationType"
    /// <summary>
    /// Categorization of the method of recording the content type of a
    ///             Record Resource.
    /// <see href="https://www.ica.org/standards/RiC/ontology#RepresentationType"></see></summary>
    let RepresentationType = _prefix "RepresentationType"
    /// <summary>
    /// Connects an Instantiation to a Production Technique Type that
    ///             categorizes its production technique.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasProductionTechniqueType"></see></summary>
    let hasProductionTechniqueType = _prefix "hasProductionTechniqueType"
    /// <summary>
    /// Categorization of the method used in the representation of
    ///             information on the Instantiation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#ProductionTechniqueType"></see></summary>
    let ProductionTechniqueType = _prefix "ProductionTechniqueType"
    /// <summary>
    /// The extent of an Instantiation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#InstantiationExtent"></see></summary>
    let InstantiationExtent = _prefix "InstantiationExtent"

    /// <summary>
    /// Connects an Instantiation to Instantiation Relation to one of
    ///             the related Instantiations.
    /// <see href="https://www.ica.org/standards/RiC/ontology#instantiationToInstantiationRelationConnects"></see></summary>
    let instantiationToInstantiationRelationConnects =
        _prefix "instantiationToInstantiationRelationConnects"

    /// <summary>
    /// Connects at least one Agent and one Record Resource or
    ///             Instantiation on which the Agent has some intellectual property rights.
    /// <see href="https://www.ica.org/standards/RiC/ontology#IntellectualPropertyRightsRelation"></see></summary>
    let IntellectualPropertyRightsRelation =
        _prefix "IntellectualPropertyRightsRelation"

    /// <summary>
    /// Connects an IntellectualPropertyRightsRelation to one of the
    ///             Group, Person or Position that holds the rights.
    /// <see href="https://www.ica.org/standards/RiC/ontology#intellectualPropertyRightsRelationHasSource"></see></summary>
    let intellectualPropertyRightsRelationHasSource =
        _prefix "intellectualPropertyRightsRelationHasSource"

    /// <summary>
    /// Connects an IintellectualPropertyRightsRelation to one of the
    ///             Record Resource or Instantiation on which the rights are held.
    /// <see href="https://www.ica.org/standards/RiC/ontology#intellectualPropertyRightsRelationHasTarget"></see></summary>
    let intellectualPropertyRightsRelationHasTarget =
        _prefix "intellectualPropertyRightsRelationHasTarget"

    /// <summary>
    /// Connects at least one Person to at least another one, when the
    ///             first one has some knowledge of the second one through time or space.
    /// <see href="https://www.ica.org/standards/RiC/ontology#KnowingOfRelation"></see></summary>
    let KnowingOfRelation = _prefix "KnowingOfRelation"
    /// <summary>
    /// Connects a Knowing Of Relation to a 'knowing of' Person (a
    ///             Person who has some knowledge of another one.)
    /// <see href="https://www.ica.org/standards/RiC/ontology#knowingOfRelationHasSource"></see></summary>
    let knowingOfRelationHasSource = _prefix "knowingOfRelationHasSource"
    /// <summary>
    /// Connects a Knowing Of Relation to a 'known by' Person (a Person
    ///             on which another one has some has some knowledge.)
    /// <see href="https://www.ica.org/standards/RiC/ontology#knowingOfRelationHasTarget"></see></summary>
    let knowingOfRelationHasTarget = _prefix "knowingOfRelationHasTarget"
    /// <summary>
    /// Connects Knowing Relation to any known Person
    ///             involved.
    /// <see href="https://www.ica.org/standards/RiC/ontology#knowingRelationConnects"></see></summary>
    let knowingRelationConnects = _prefix "knowingRelationConnects"
    /// <summary>
    /// A spoken or written human language represented in the Record or
    ///             Record Part, or used by the Agent.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Language"></see></summary>
    let Language = _prefix "Language"
    /// <summary>
    /// Connects at least one Person and at least one Group, when the
    ///             first one leads the second one.
    /// <see href="https://www.ica.org/standards/RiC/ontology#LeadershipRelation"></see></summary>
    let LeadershipRelation = _prefix "LeadershipRelation"
    /// <summary>
    /// Connects a Leadership Relation to a Person who is involved as a
    ///             leader.
    /// <see href="https://www.ica.org/standards/RiC/ontology#leadershipRelationHasSource"></see></summary>
    let leadershipRelationHasSource = _prefix "leadershipRelationHasSource"
    /// <summary>
    /// Connects a Leadership Relation to a lead Group.
    /// <see href="https://www.ica.org/standards/RiC/ontology#leadershipRelationHasTarget"></see></summary>
    let leadershipRelationHasTarget = _prefix "leadershipRelationHasTarget"
    /// <summary>
    /// Connects a Leadership Relation to the Position occupied by the
    ///             leading Person.
    /// <see href="https://www.ica.org/standards/RiC/ontology#leadershipWithPosition"></see></summary>
    let leadershipWithPosition = _prefix "leadershipWithPosition"
    /// <summary>
    /// A status defined by law.
    /// <see href="https://www.ica.org/standards/RiC/ontology#LegalStatus"></see></summary>
    let LegalStatus = _prefix "LegalStatus"
    /// <summary>
    /// Connects at least one Agent, and at least one Record Resource or
    ///             Instantiation that the Agent manages.
    /// <see href="https://www.ica.org/standards/RiC/ontology#ManagementRelation"></see></summary>
    let ManagementRelation = _prefix "ManagementRelation"
    /// <summary>
    /// Connects a Management Relation to an Agent who is involved as a
    ///             manager.
    /// <see href="https://www.ica.org/standards/RiC/ontology#managementRelationHasSource"></see></summary>
    let managementRelationHasSource = _prefix "managementRelationHasSource"
    /// <summary>
    /// Connects a Management Relation to a Record Resource or
    ///             Instantiation that is involved as a managed thing.
    /// <see href="https://www.ica.org/standards/RiC/ontology#managementRelationHasTarget"></see></summary>
    let managementRelationHasTarget = _prefix "managementRelationHasTarget"
    /// <summary>
    /// Delegation of authority by an Agent to another Agent to perform
    ///             an Activity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Mandate"></see></summary>
    let Mandate = _prefix "Mandate"
    /// <summary>
    /// Connects a Mandate to the Agent that the Mandate gives the
    ///             authority or competencies to act.
    /// <see href="https://www.ica.org/standards/RiC/ontology#authorizes"></see></summary>
    let authorizes = _prefix "authorizes"
    /// <summary>
    /// Conditions that govern the existence or authority of an Agent or the performance of an Activity, or that contribute to the distinct characteristics of things created or managed by an Agent.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Rule"></see></summary>
    let Rule = _prefix "Rule"
    /// <summary>
    /// Connects at least one Mandate, and at least one Agent, when the
    ///             first gives the second one the authority or competencies to act. May also involve one to
    ///             many Activities that the Mandate(s) assign(s) to the Agent(s).
    /// <see href="https://www.ica.org/standards/RiC/ontology#MandateRelation"></see></summary>
    let MandateRelation = _prefix "MandateRelation"
    /// <summary>
    /// Connects a Mandate Relation to an Agent who is given the
    ///             authority or competencies to act.
    /// <see href="https://www.ica.org/standards/RiC/ontology#mandateRelationHasTarget"></see></summary>
    let mandateRelationHasTarget = _prefix "mandateRelationHasTarget"
    /// <summary>
    /// Connects a Mandate Relation to an Agent that assigns the
    ///             Mandate.
    /// <see href="https://www.ica.org/standards/RiC/ontology#authorizingAgent"></see></summary>
    let authorizingAgent = _prefix "authorizingAgent"
    /// <summary>
    /// Connects at least one Rule to at least one Thing, when it is
    ///             associated with existence and lifecycle of the Thing.
    /// <see href="https://www.ica.org/standards/RiC/ontology#RuleRelation"></see></summary>
    let RuleRelation = _prefix "RuleRelation"
    /// <summary>
    /// Connects a Mandate Relation to a Mandate.
    /// <see href="https://www.ica.org/standards/RiC/ontology#mandateRelationHasSource"></see></summary>
    let mandateRelationHasSource = _prefix "mandateRelationHasSource"
    /// <summary>
    /// Connects a Group and at least one Person, when the first one has
    ///             the second one(s) among its members.
    /// <see href="https://www.ica.org/standards/RiC/ontology#MembershipRelation"></see></summary>
    let MembershipRelation = _prefix "MembershipRelation"
    /// <summary>
    /// Connects a Membership Relation to a Person who is involved as a
    ///             member.
    /// <see href="https://www.ica.org/standards/RiC/ontology#membershipRelationHasTarget"></see></summary>
    let membershipRelationHasTarget = _prefix "membershipRelationHasTarget"
    /// <summary>
    /// Connects a Membership Relation to the Group that has
    ///             member(s).
    /// <see href="https://www.ica.org/standards/RiC/ontology#membershipRelationHasSource"></see></summary>
    let membershipRelationHasSource = _prefix "membershipRelationHasSource"
    /// <summary>
    /// Connects a Membership Relation to the Position occupied by the
    ///             member Person(s).
    /// <see href="https://www.ica.org/standards/RiC/ontology#membershipWithPosition"></see></summary>
    let membershipWithPosition = _prefix "membershipWithPosition"
    /// <summary>
    /// Connects an Instantiation and at least another Instantiation,
    ///             when the first is migrated into the second one(s).
    /// <see href="https://www.ica.org/standards/RiC/ontology#MigrationRelation"></see></summary>
    let MigrationRelation = _prefix "MigrationRelation"
    /// <summary>
    /// Connects a Migration Relation to a resulting
    ///             Instantiation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#migrationRelationHasTarget"></see></summary>
    let migrationRelationHasTarget = _prefix "migrationRelationHasTarget"
    /// <summary>
    /// Connects a Migration Relation to the migrated
    ///             Instantiation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#migrationRelationHasSource"></see></summary>
    let migrationRelationHasSource = _prefix "migrationRelationHasSource"
    /// <summary>
    /// Categorization of a profession, trade, or craft pursued by a
    ///             person in fulfilment of an Activity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#OccupationType"></see></summary>
    let OccupationType = _prefix "OccupationType"
    /// <summary>
    /// Connects an Occupation Type to a Person whose occupation is or
    ///             was categorized by it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasOccupationTypeOf"></see></summary>
    let isOrWasOccupationTypeOf = _prefix "isOrWasOccupationTypeOf"
    /// <summary>
    /// Connects at least one Group, Person or Position, and at least a
    ///             Thing that these Agent(s) own(s).
    /// <see href="https://www.ica.org/standards/RiC/ontology#OwnershipRelation"></see></summary>
    let OwnershipRelation = _prefix "OwnershipRelation"
    /// <summary>
    /// Connects an Ownership Relation to a Person, Group or Position
    ///             that is involved as an owner.
    /// <see href="https://www.ica.org/standards/RiC/ontology#ownershipRelationHasSource"></see></summary>
    let ownershipRelationHasSource = _prefix "ownershipRelationHasSource"
    /// <summary>
    /// Connects an Ownership Relation to a Thing that is
    ///             owned.
    /// <see href="https://www.ica.org/standards/RiC/ontology#ownershipRelationHasTarget"></see></summary>
    let ownershipRelationHasTarget = _prefix "ownershipRelationHasTarget"
    /// <summary>
    /// Connects at least one Activity to at least one Agent, when the
    ///             first is performed by the second one(s).
    /// <see href="https://www.ica.org/standards/RiC/ontology#PerformanceRelation"></see></summary>
    let PerformanceRelation = _prefix "PerformanceRelation"
    /// <summary>
    /// Connects a Performance Relation to a performed
    ///             Activity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#performanceRelationHasSource"></see></summary>
    let performanceRelationHasSource = _prefix "performanceRelationHasSource"
    /// <summary>
    /// Connects a Performance Relation to a performing
    ///             Agent.
    /// <see href="https://www.ica.org/standards/RiC/ontology#performanceRelationHasTarget"></see></summary>
    let performanceRelationHasTarget = _prefix "performanceRelationHasTarget"
    /// <summary>
    /// Connects a Person to an Occupation Type that categorized or
    ///             categorizes his/her occupation (profession, trade or craft).
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadOccupationOfType"></see></summary>
    let hasOrHadOccupationOfType = _prefix "hasOrHadOccupationOfType"
    /// <summary>
    /// Connects a Physical Location to its past or present coordinates
    ///             in a reference system.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadCoordinates"></see></summary>
    let hasOrHadCoordinates = _prefix "hasOrHadCoordinates"
    /// <summary>
    /// Connects a Physical Location to a Place, when it is or was its
    ///             location.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasPhysicalLocationOf"></see></summary>
    let isOrWasPhysicalLocationOf = _prefix "isOrWasPhysicalLocationOf"
    /// <summary>
    /// Bounded, named geographic area or region.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Place"></see></summary>
    let Place = _prefix "Place"
    /// <summary>
    /// Connects a Place to one of its past or present Physical
    ///             Location.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadPhysicalLocation"></see></summary>
    let hasOrHadPhysicalLocation = _prefix "hasOrHadPhysicalLocation"
    /// <summary>
    /// A label, title or term designating a Place in order to make it
    ///             distinguishable from other similar entities.
    /// <see href="https://www.ica.org/standards/RiC/ontology#PlaceName"></see></summary>
    let PlaceName = _prefix "PlaceName"
    /// <summary>
    /// Connects a Place and at least one Thing, when the first is
    ///             associated with the existence and lifecycle of the second one.
    /// <see href="https://www.ica.org/standards/RiC/ontology#PlaceRelation"></see></summary>
    let PlaceRelation = _prefix "PlaceRelation"
    /// <summary>
    /// Connects a Place Relation to a Thing that is associated to the
    ///             Place.
    /// <see href="https://www.ica.org/standards/RiC/ontology#placeRelationHasTarget"></see></summary>
    let placeRelationHasTarget = _prefix "placeRelationHasTarget"
    /// <summary>
    /// Connects a Place Relation to the Place concerned.
    /// <see href="https://www.ica.org/standards/RiC/ontology#placeRelationHasSource"></see></summary>
    let placeRelationHasSource = _prefix "placeRelationHasSource"
    /// <summary>
    /// Categorization of a Place.
    /// <see href="https://www.ica.org/standards/RiC/ontology#PlaceType"></see></summary>
    let PlaceType = _prefix "PlaceType"
    /// <summary>
    /// Connects a Place Type to a Place that is or was categorized by
    ///             it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasPlaceTypeOf"></see></summary>
    let isOrWasPlaceTypeOf = _prefix "isOrWasPlaceTypeOf"
    /// <summary>
    /// Connects at least one Person, and at least one Position that the
    ///             Person occupies.
    /// <see href="https://www.ica.org/standards/RiC/ontology#PositionHoldingRelation"></see></summary>
    let PositionHoldingRelation = _prefix "PositionHoldingRelation"
    /// <summary>
    /// Connects a Position Holding Relation to a Person (who occupies a
    ///             Position).
    /// <see href="https://www.ica.org/standards/RiC/ontology#positionHoldingRelationHasSource"></see></summary>
    let positionHoldingRelationHasSource = _prefix "positionHoldingRelationHasSource"
    /// <summary>
    /// Connects a Position Holding Relation to a Position (that is
    ///             occupied).
    /// <see href="https://www.ica.org/standards/RiC/ontology#positionHoldingRelationHasTarget"></see></summary>
    let positionHoldingRelationHasTarget = _prefix "positionHoldingRelationHasTarget"
    /// <summary>
    /// Connects at least one Position, and a Group, when the first
    ///             one(s) exist(s) in/is defined within the second one.
    /// <see href="https://www.ica.org/standards/RiC/ontology#PositionToGroupRelation"></see></summary>
    let PositionToGroupRelation = _prefix "PositionToGroupRelation"
    /// <summary>
    /// Connects a Position to Group Relation to a Position (that exists
    ///             in a Group).
    /// <see href="https://www.ica.org/standards/RiC/ontology#positionToGroupRelationHasSource"></see></summary>
    let positionToGroupRelationHasSource = _prefix "positionToGroupRelationHasSource"
    /// <summary>
    /// Connects a Position to Group Relation to a Group (in which a
    ///             Position exists).
    /// <see href="https://www.ica.org/standards/RiC/ontology#positionToGroupRelationHasTarget"></see></summary>
    let positionToGroupRelationHasTarget = _prefix "positionToGroupRelationHasTarget"
    /// <summary>
    /// Connects a Production Technique Type to an Instantiation whose
    ///             production technique is categorized by it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isProductionTechniqueTypeOf"></see></summary>
    let isProductionTechniqueTypeOf = _prefix "isProductionTechniqueTypeOf"
    /// <summary>
    /// Connects a Provenance Relation to a Record Resource or
    ///             Instantiation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#provenanceRelationHasSource"></see></summary>
    let provenanceRelationHasSource = _prefix "provenanceRelationHasSource"
    /// <summary>
    /// Connects a Provenance Relation to an Agent or
    ///             Activity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#provenanceRelationHasTarget"></see></summary>
    let provenanceRelationHasTarget = _prefix "provenanceRelationHasTarget"
    /// <summary>
    /// A Proxy represents (stands for) a Record Resource as it exists
    ///             in a specific Record Set.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Proxy"></see></summary>
    let Proxy = _prefix "Proxy"
    /// <summary>
    /// Connects a Proxy to the Record Resource it stands for in the
    ///             specific context of a Record Set.
    /// <see href="https://www.ica.org/standards/RiC/ontology#proxyFor"></see></summary>
    let proxyFor = _prefix "proxyFor"
    /// <summary>
    /// Connects a Proxy to the Record Set in which it stands for
    ///             (represents) another Record Resource.
    /// <see href="https://www.ica.org/standards/RiC/ontology#proxyIn"></see></summary>
    let proxyIn = _prefix "proxyIn"
    /// <summary>
    /// One or more records that are associated by categorization and/or
    ///             physical aggregation by the creator or other Agent.
    /// <see href="https://www.ica.org/standards/RiC/ontology#RecordSet"></see></summary>
    let RecordSet = _prefix "RecordSet"
    /// <summary>
    /// Connects a Record Resource to one of its
    ///             Instantiations.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasInstantiation"></see></summary>
    let hasInstantiation = _prefix "hasInstantiation"
    /// <summary>
    /// The extent of the content of a Record Resource.
    /// <see href="https://www.ica.org/standards/RiC/ontology#RecordResourceExtent"></see></summary>
    let RecordResourceExtent = _prefix "RecordResourceExtent"
    /// <summary>
    /// Connects two to more Record Resources when there is a genetic
    ///             relation between them. Genetic in this sense is as defined by diplomatics, i.e. the
    ///             process by which a Record Resource is developed.
    /// <see href="https://www.ica.org/standards/RiC/ontology#RecordResourceGeneticRelation"></see></summary>
    let RecordResourceGeneticRelation = _prefix "RecordResourceGeneticRelation"

    /// <summary>
    /// Connects a Record Resource Genetic Relation to one of the
    ///             associated Record Resources.
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordResourceGeneticRelationConnects"></see></summary>
    let recordResourceGeneticRelationConnects =
        _prefix "recordResourceGeneticRelationConnects"

    /// <summary>
    /// Connects at least two Record Resources.
    /// <see href="https://www.ica.org/standards/RiC/ontology#RecordResourceToRecordResourceRelation"></see></summary>
    let RecordResourceToRecordResourceRelation =
        _prefix "RecordResourceToRecordResourceRelation"

    /// <summary>
    /// Connects at least one Agent, and one or more Record Resource or
    ///             Instantiation that the Agent holds.
    /// <see href="https://www.ica.org/standards/RiC/ontology#RecordResourceHoldingRelation"></see></summary>
    let RecordResourceHoldingRelation = _prefix "RecordResourceHoldingRelation"

    /// <summary>
    /// Connects a Record Resource Holding Relation to an Agent (as the
    ///             holder of a Record Resource or Instantiation).
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordResourceHoldingRelationHasSource"></see></summary>
    let recordResourceHoldingRelationHasSource =
        _prefix "recordResourceHoldingRelationHasSource"

    /// <summary>
    /// Connects a Record Resource Holding Relation to a Record Resource
    ///             or Instantiation (that is held by an Agent).
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordResourceHoldingRelationHasTarget"></see></summary>
    let recordResourceHoldingRelationHasTarget =
        _prefix "recordResourceHoldingRelationHasTarget"

    /// <summary>
    /// Connects a Record Resource to one or more Instantiations that
    ///             instantiate it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#RecordResourceToInstantiationRelation"></see></summary>
    let RecordResourceToInstantiationRelation =
        _prefix "RecordResourceToInstantiationRelation"

    /// <summary>
    /// Connects a Record Resource To Instantiation Relation to an
    ///             Instantiation of the involved Record Resource.
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordResourceToInstantiationRelationHasTarget"></see></summary>
    let recordResourceToInstantiationRelationHasTarget =
        _prefix "recordResourceToInstantiationRelationHasTarget"

    /// <summary>
    /// Connects a Record Resource To Instantiation Relation to the
    ///             Record Resource (that was instantiated).
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordResourceToInstantiationRelationHasSource"></see></summary>
    let recordResourceToInstantiationRelationHasSource =
        _prefix "recordResourceToInstantiationRelationHasSource"

    /// <summary>
    /// Connects a Record Resource relation to one of the related Record
    ///             Resources.
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordResourceRelationConnects"></see></summary>
    let recordResourceRelationConnects = _prefix "recordResourceRelationConnects"
    /// <summary>
    /// Connects a Record Set to a Record Set Type that categorizes
    ///             it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasRecordSetType"></see></summary>
    let hasRecordSetType = _prefix "hasRecordSetType"
    /// <summary>
    /// A broad categorization of the type of Record Set.
    /// <see href="https://www.ica.org/standards/RiC/ontology#RecordSetType"></see></summary>
    let RecordSetType = _prefix "RecordSetType"
    /// <summary>
    /// Connects a Record Set Type to a Record Set that it
    ///             categorizes.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isRecordSetTypeOf"></see></summary>
    let isRecordSetTypeOf = _prefix "isRecordSetTypeOf"
    /// <summary>
    /// Categorization of the production or reproduction status of a
    ///             Record or Record Part.
    /// <see href="https://www.ica.org/standards/RiC/ontology#RecordState"></see></summary>
    let RecordState = _prefix "RecordState"
    /// <summary>
    /// Connects a Representation Type to an Instantiation that it
    ///             categorizes.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isRepresentationTypeOf"></see></summary>
    let isRepresentationTypeOf = _prefix "isRepresentationTypeOf"
    /// <summary>
    /// Connects a Rule to a Rule Type that categorized or categorizes
    ///             it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadRuleType"></see></summary>
    let hasOrHadRuleType = _prefix "hasOrHadRuleType"
    /// <summary>
    /// Categorization of a Rule.
    /// <see href="https://www.ica.org/standards/RiC/ontology#RuleType"></see></summary>
    let RuleType = _prefix "RuleType"
    /// <summary>
    /// Connects a Rule Relation to a Rule.
    /// <see href="https://www.ica.org/standards/RiC/ontology#ruleRelationHasSource"></see></summary>
    let ruleRelationHasSource = _prefix "ruleRelationHasSource"
    /// <summary>
    /// Connects a Rule Relation to a Thing (that is associated to a
    ///             Rule).
    /// <see href="https://www.ica.org/standards/RiC/ontology#ruleRelationHasTarget"></see></summary>
    let ruleRelationHasTarget = _prefix "ruleRelationHasTarget"
    /// <summary>
    /// connects a Rule Type to a Rule that it categorized or
    ///             categorizes.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasRuleTypeOf"></see></summary>
    let isOrWasRuleTypeOf = _prefix "isOrWasRuleTypeOf"
    /// <summary>
    /// Connects at least one Thing to at least one Thing that follows
    ///             it in some sequence.
    /// <see href="https://www.ica.org/standards/RiC/ontology#SequentialRelation"></see></summary>
    let SequentialRelation = _prefix "SequentialRelation"
    /// <summary>
    /// Connects a Sequential Relation to a Thing that precedes other
    ///             Thing(s) in the sequence.
    /// <see href="https://www.ica.org/standards/RiC/ontology#sequentialRelationHasSource"></see></summary>
    let sequentialRelationHasSource = _prefix "sequentialRelationHasSource"
    /// <summary>
    /// Connects a Sequential Relation to a Thing that follows other
    ///             Thing(s) in the sequence.
    /// <see href="https://www.ica.org/standards/RiC/ontology#sequentialRelationHasTarget"></see></summary>
    let sequentialRelationHasTarget = _prefix "sequentialRelationHasTarget"
    /// <summary>
    /// Connects at least two Persons, when they are
    ///             siblings.
    /// <see href="https://www.ica.org/standards/RiC/ontology#SiblingRelation"></see></summary>
    let SiblingRelation = _prefix "SiblingRelation"
    /// <summary>
    /// Connects a Sibling Relation to one of the siblings
    ///             involved.
    /// <see href="https://www.ica.org/standards/RiC/ontology#siblingRelationConnects"></see></summary>
    let siblingRelationConnects = _prefix "siblingRelationConnects"
    /// <summary>
    /// Connects at least two Persons, when they are
    ///             spouses.
    /// <see href="https://www.ica.org/standards/RiC/ontology#SpouseRelation"></see></summary>
    let SpouseRelation = _prefix "SpouseRelation"
    /// <summary>
    /// Connects a Sibling Relation to one of the spouses
    ///             involved.
    /// <see href="https://www.ica.org/standards/RiC/ontology#spouseRelationConnects"></see></summary>
    let spouseRelationConnects = _prefix "spouseRelationConnects"
    /// <summary>
    /// Connects at least one Person to at least another Person, who is
    ///             their student.
    /// <see href="https://www.ica.org/standards/RiC/ontology#TeachingRelation"></see></summary>
    let TeachingRelation = _prefix "TeachingRelation"
    /// <summary>
    /// Connects a Teaching Relation to a Person (who is a
    ///             teacher).
    /// <see href="https://www.ica.org/standards/RiC/ontology#teachingRelationHasSource"></see></summary>
    let teachingRelationHasSource = _prefix "teachingRelationHasSource"
    /// <summary>
    /// Connects a Teaching Relation to a Person (who is a
    ///             student).
    /// <see href="https://www.ica.org/standards/RiC/ontology#teachingRelationHasTarget"></see></summary>
    let teachingRelationHasTarget = _prefix "teachingRelationHasTarget"
    /// <summary>
    /// Connects a Temporal Relation to a Thing that precedes other
    ///             Thing(s) in time.
    /// <see href="https://www.ica.org/standards/RiC/ontology#temporalRelationHasSource"></see></summary>
    let temporalRelationHasSource = _prefix "temporalRelationHasSource"
    /// <summary>
    /// Connects a Temporal Relation to a Thing that follows other
    ///             Thing(s) in time.
    /// <see href="https://www.ica.org/standards/RiC/ontology#temporalRelationHasTarget"></see></summary>
    let temporalRelationHasTarget = _prefix "temporalRelationHasTarget"
    /// <summary>
    /// A name that is used for a Record Resource or a
    ///             Rule
    /// <see href="https://www.ica.org/standards/RiC/ontology#Title"></see></summary>
    let Title = _prefix "Title"
    /// <summary>
    /// Connects a category (a Type) and at least one Thing that belongs
    ///             to this category.
    /// <see href="https://www.ica.org/standards/RiC/ontology#TypeRelation"></see></summary>
    let TypeRelation = _prefix "TypeRelation"
    /// <summary>
    /// Connects a Type Relation to a Thing (that is categorized by the
    ///             involved Type).
    /// <see href="https://www.ica.org/standards/RiC/ontology#typeRelationHasTarget"></see></summary>
    let typeRelationHasTarget = _prefix "typeRelationHasTarget"
    /// <summary>
    /// Connects a Type Relation to the Type (that categorizes the
    ///             involved Thing(s)).
    /// <see href="https://www.ica.org/standards/RiC/ontology#typeRelationHasSource"></see></summary>
    let typeRelationHasSource = _prefix "typeRelationHasSource"
    /// <summary>
    /// A definite magnitude of a quantity, defined and adopted by convention or by
    ///             law, that is used as a standard for measurement of the same kind of quantity. Can be
    ///             spacial units (cm, m), weigt (g, kg), time (s, h), storage (MB, TB) or more informal
    ///             units used in the archival context like number of boxes, pages or words.
    /// <see href="https://www.ica.org/standards/RiC/ontology#UnitOfMeasurement"></see></summary>
    let UnitOfMeasurement = _prefix "UnitOfMeasurement"
    /// <summary>
    /// Connects a Whole Part Relation to a Thing that is a
    ///             part.
    /// <see href="https://www.ica.org/standards/RiC/ontology#wholePartRelationHasTarget"></see></summary>
    let wholePartRelationHasTarget = _prefix "wholePartRelationHasTarget"
    /// <summary>
    /// Connects a Whole Part Relation to the Thing that has some
    ///             parts.
    /// <see href="https://www.ica.org/standards/RiC/ontology#wholePartRelationHasSource"></see></summary>
    let wholePartRelationHasSource = _prefix "wholePartRelationHasSource"
    /// <summary>
    /// Connects at least two Agents that have some type of work
    ///             relation in the course of their activities.
    /// <see href="https://www.ica.org/standards/RiC/ontology#WorkRelation"></see></summary>
    let WorkRelation = _prefix "WorkRelation"
    /// <summary>
    /// Connects a Work Relation to an Agent.
    /// <see href="https://www.ica.org/standards/RiC/ontology#workRelationConnects"></see></summary>
    let workRelationConnects = _prefix "workRelationConnects"
    /// <summary>
    /// Information on the anticipated accession(s) to the Record
    ///             Set.
    /// <see href="https://www.ica.org/standards/RiC/ontology#accrual"></see></summary>
    let accrual = _prefix "accrual"
    /// <summary>
    /// Information on the status of an Accrual
    /// <see href="https://www.ica.org/standards/RiC/ontology#accrualStatus"></see></summary>
    let accrualStatus = _prefix "accrualStatus"

    /// <summary>
    /// Connects a Record Resource or Instantiation (that is
    ///             accumulated) to an Accumulation Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsSourceOfAccumulationRelation"></see></summary>
    let recordResourceOrInstantiationIsSourceOfAccumulationRelation =
        _prefix "recordResourceOrInstantiationIsSourceOfAccumulationRelation"

    /// <summary>
    /// Connects one of the accumulating Agents to an Accumulation
    ///             Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentIsTargetOfAccumulationRelation"></see></summary>
    let agentIsTargetOfAccumulationRelation =
        _prefix "agentIsTargetOfAccumulationRelation"

    /// <summary>
    /// Connects a Record Resource or Instantiation (that documents an
    ///             Activity) to an Activity Documentation Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsSourceOfActivityDocumentationRelation"></see></summary>
    let recordResourceOrInstantiationIsSourceOfActivityDocumentationRelation =
        _prefix "recordResourceOrInstantiationIsSourceOfActivityDocumentationRelation"

    /// <summary>
    /// Connects an Activity to an Activity Documentation
    ///             Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#activityIsTargetOfActivityDocumentationRelation"></see></summary>
    let activityIsTargetOfActivityDocumentationRelation =
        _prefix "activityIsTargetOfActivityDocumentationRelation"

    /// <summary>
    /// Connects an Activity to an Agent Temporal Relation (when the
    ///             Activity is transferred from an Agent to another one) or a Mandate Relation (the Mandate
    ///             assigns the Activity to the Agent or defines it).
    /// <see href="https://www.ica.org/standards/RiC/ontology#activityIsContextOfRelation"></see></summary>
    let activityIsContextOfRelation = _prefix "activityIsContextOfRelation"
    /// <summary>
    /// Connects a Thing (that is a secondary, contextual entity during
    ///             the existence of the Relation) to a n-ary Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#thingIsContextOfRelation"></see></summary>
    let thingIsContextOfRelation = _prefix "thingIsContextOfRelation"

    /// <summary>
    /// Connects an Activity that is performed to a Performance
    ///             Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#activityIsSourceOfPerformanceRelation"></see></summary>
    let activityIsSourceOfPerformanceRelation =
        _prefix "activityIsSourceOfPerformanceRelation"

    /// <summary>
    /// Connects a Thing (that is the source of a Relation) to a
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#thingIsSourceOfRelation"></see></summary>
    let thingIsSourceOfRelation = _prefix "thingIsSourceOfRelation"

    /// <summary>
    /// Connects an Agent or Activity that is the provenance of a Record
    ///             resource or Instantiation, to a Provenance Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentOrActivityIsTargetOfProvenanceRelation"></see></summary>
    let agentOrActivityIsTargetOfProvenanceRelation =
        _prefix "agentOrActivityIsTargetOfProvenanceRelation"

    /// <summary>
    /// Connects an Event to a Thing on which the Event has or had some
    ///             significant impact.
    /// <see href="https://www.ica.org/standards/RiC/ontology#affectsOrAffected"></see></summary>
    let affectsOrAffected = _prefix "affectsOrAffected"
    /// <summary>
    /// Connects an Event to a Thing that is or was actively or
    ///             passively involved in it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadParticipant"></see></summary>
    let hasOrHadParticipant = _prefix "hasOrHadParticipant"
    /// <summary>
    /// Inverse of 'affects or affected' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasAffectedBy"></see></summary>
    let isOrWasAffectedBy = _prefix "isOrWasAffectedBy"

    /// <summary>
    /// Connects a controlling Agent to an Agent Control
    ///             Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentIsSourceOfAgentControlRelation"></see></summary>
    let agentIsSourceOfAgentControlRelation =
        _prefix "agentIsSourceOfAgentControlRelation"

    /// <summary>
    /// Connects one of the controlled Agents to an Agent Control
    ///             Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentIsTargetOfAgentControlRelation"></see></summary>
    let agentIsTargetOfAgentControlRelation =
        _prefix "agentIsTargetOfAgentControlRelation"

    /// <summary>
    /// Connects an Agent to a Work Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentHasWorkRelation"></see></summary>
    let agentHasWorkRelation = _prefix "agentHasWorkRelation"
    /// <summary>
    /// Connects an Agent to an Agent Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentIsConnectedToAgentRelation"></see></summary>
    let agentIsConnectedToAgentRelation = _prefix "agentIsConnectedToAgentRelation"
    /// <summary>
    /// Connects an n-ary Relation to a Thing that is its
    ///             source.
    /// <see href="https://www.ica.org/standards/RiC/ontology#relationHasSource"></see></summary>
    let relationHasSource = _prefix "relationHasSource"

    /// <summary>
    /// Connects a hierarchically superior Agent to an Agent
    ///             Hierarchical Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentIsSourceOfAgentHierarchicalRelation"></see></summary>
    let agentIsSourceOfAgentHierarchicalRelation =
        _prefix "agentIsSourceOfAgentHierarchicalRelation"

    /// <summary>
    /// Connects an n-ary Relation to a Thing that is its
    ///             target.
    /// <see href="https://www.ica.org/standards/RiC/ontology#relationHasTarget"></see></summary>
    let relationHasTarget = _prefix "relationHasTarget"

    /// <summary>
    /// Connects one of the hierarchically inferior Agents to an Agent
    ///             Hierarchical Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentIsTargetOfAgentHierarchicalRelation"></see></summary>
    let agentIsTargetOfAgentHierarchicalRelation =
        _prefix "agentIsTargetOfAgentHierarchicalRelation"

    /// <summary>
    /// Connects a Thing to a n-ary Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#thingIsConnectedToRelation"></see></summary>
    let thingIsConnectedToRelation = _prefix "thingIsConnectedToRelation"

    /// <summary>
    /// Connects a predecessor Agent to an Agent Temporal
    ///             Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentIsSourceOfAgentTemporalRelation"></see></summary>
    let agentIsSourceOfAgentTemporalRelation =
        _prefix "agentIsSourceOfAgentTemporalRelation"

    /// <summary>
    /// Connects a Thing to a Temporal Relation, when this Thing
    ///             precedes other Thing(s) in time.
    /// <see href="https://www.ica.org/standards/RiC/ontology#thingIsSourceOfTemporalRelation"></see></summary>
    let thingIsSourceOfTemporalRelation = _prefix "thingIsSourceOfTemporalRelation"
    /// <summary>
    /// Connects an Agent thas has the authority, to an Authority
    ///             Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentIsSourceOfAuthorityRelation"></see></summary>
    let agentIsSourceOfAuthorityRelation = _prefix "agentIsSourceOfAuthorityRelation"

    /// <summary>
    /// Connects an Agent having the intellectual property rights, to an
    ///             Intellectual Property Rights Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentIsSourceOfIntellectualPropertyRightsRelation"></see></summary>
    let agentIsSourceOfIntellectualPropertyRightsRelation =
        _prefix "agentIsSourceOfIntellectualPropertyRightsRelation"

    /// <summary>
    /// Connects a manager Agent to a Management Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentIsSourceOfManagementRelation"></see></summary>
    let agentIsSourceOfManagementRelation = _prefix "agentIsSourceOfManagementRelation"
    /// <summary>
    /// Connects an owner Agent to an Ownership Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentIsSourceOfOwnershipRelation"></see></summary>
    let agentIsSourceOfOwnershipRelation = _prefix "agentIsSourceOfOwnershipRelation"

    /// <summary>
    /// Connects an Agent that holds a Record Resource or Instantiation,
    ///             to a Record Resource Holding Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentIsSourceOfRecordResourceHoldingRelation"></see></summary>
    let agentIsSourceOfRecordResourceHoldingRelation =
        _prefix "agentIsSourceOfRecordResourceHoldingRelation"

    /// <summary>
    /// Connects one of the Agents that created or accumulated the
    ///             Record resource or Instantiation, to an Agent Origination Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentIsTargetOfAgentOriginationRelation"></see></summary>
    let agentIsTargetOfAgentOriginationRelation =
        _prefix "agentIsTargetOfAgentOriginationRelation"

    /// <summary>
    /// Connects a Thing (that is under authority of an Agent) to an
    ///             Authority Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfAuthorityRelation"></see></summary>
    let thingIsTargetOfAuthorityRelation = _prefix "thingIsTargetOfAuthorityRelation"
    /// <summary>
    /// Connects a Thing to a n-ary Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfRelation"></see></summary>
    let thingIsTargetOfRelation = _prefix "thingIsTargetOfRelation"

    /// <summary>
    /// Connects a successor Agent to an Agent Temporal
    ///             Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentIsTargetOfAgentTemporalRelation"></see></summary>
    let agentIsTargetOfAgentTemporalRelation =
        _prefix "agentIsTargetOfAgentTemporalRelation"

    /// <summary>
    /// Connects a Thing (that follows other Thing(s) in time) to a
    ///             Temporal Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfTemporalRelation"></see></summary>
    let thingIsTargetOfTemporalRelation = _prefix "thingIsTargetOfTemporalRelation"
    /// <summary>
    /// Connects a Person, Group or Position to an Authorship
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentIsTargetOfAuthorshipRelation"></see></summary>
    let agentIsTargetOfAuthorshipRelation = _prefix "agentIsTargetOfAuthorshipRelation"
    /// <summary>
    /// Connects a creator Agent to a Creation Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentIsTargetOfCreationRelation"></see></summary>
    let agentIsTargetOfCreationRelation = _prefix "agentIsTargetOfCreationRelation"
    /// <summary>
    /// Connects a mandated Agent to a Mandate Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentIsTargetOfMandateRelation"></see></summary>
    let agentIsTargetOfMandateRelation = _prefix "agentIsTargetOfMandateRelation"
    /// <summary>
    /// Connects a Thing (that is associated with a Rule) to a Rule
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfRuleRelation"></see></summary>
    let thingIsTargetOfRuleRelation = _prefix "thingIsTargetOfRuleRelation"

    /// <summary>
    /// Connects an Agent to a Performance Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentIsTargetOfPerformanceRelation"></see></summary>
    let agentIsTargetOfPerformanceRelation =
        _prefix "agentIsTargetOfPerformanceRelation"

    /// <summary>
    /// Connects a Record Resource or Instantiation (that is created,
    ///             sent or accumulated) to an Agent Origination Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsSourceOfAgentOriginationRelation"></see></summary>
    let recordResourceOrInstantiationIsSourceOfAgentOriginationRelation =
        _prefix "recordResourceOrInstantiationIsSourceOfAgentOriginationRelation"

    /// <summary>
    /// Connects an n-ary Relation to any of the Things
    ///             involved.
    /// <see href="https://www.ica.org/standards/RiC/ontology#relationConnects"></see></summary>
    let relationConnects = _prefix "relationConnects"
    /// <summary>
    /// Reference system used for altitude
    /// <see href="https://www.ica.org/standards/RiC/ontology#altimetricSystem"></see></summary>
    let altimetricSystem = _prefix "altimetricSystem"
    /// <summary>
    /// Framework or standard used to represent an
    ///             information.
    /// <see href="https://www.ica.org/standards/RiC/ontology#referenceSystem"></see></summary>
    let referenceSystem = _prefix "referenceSystem"
    /// <summary>
    /// The height of a Place above a reference level, especially above
    ///             sea level.
    /// <see href="https://www.ica.org/standards/RiC/ontology#altitude"></see></summary>
    let altitude = _prefix "altitude"
    /// <summary>
    /// The extent, quantity, amount, or degree of an entity, as
    ///             determined by measurement or calculation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#measure"></see></summary>
    let measure = _prefix "measure"

    /// <summary>
    /// Connects an Appellation to an Appellation
    ///             Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#appellationIsSourceOfAppellationRelation"></see></summary>
    let appellationIsSourceOfAppellationRelation =
        _prefix "appellationIsSourceOfAppellationRelation"

    /// <summary>
    /// Connects a Thing (that is designated by an Appellation) to an
    ///             Appellation Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfAppellationRelation"></see></summary>
    let thingIsTargetOfAppellationRelation =
        _prefix "thingIsTargetOfAppellationRelation"

    /// <summary>
    /// Connects an n-ary Relation to a Thing that is a secondary,
    ///             contextual entity during the existence of the Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#relationHasContext"></see></summary>
    let relationHasContext = _prefix "relationHasContext"
    /// <summary>
    /// Description of evidences that the Record Resource or
    ///             Instantiation is what it purports to be, was created or sent by the said Agent, at the
    ///             said time and has not been tampered or corrupted.
    /// <see href="https://www.ica.org/standards/RiC/ontology#authenticityNote"></see></summary>
    let authenticityNote = _prefix "authenticityNote"
    /// <summary>
    /// Inverse of 'authorizes' object property
    /// <see href="https://www.ica.org/standards/RiC/ontology#authorizedBy"></see></summary>
    let authorizedBy = _prefix "authorizedBy"
    /// <summary>
    /// Inverse of 'is rule associated with' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isAssociatedWithRule"></see></summary>
    let isAssociatedWithRule = _prefix "isAssociatedWithRule"
    /// <summary>
    /// Connects a Rule to a Thing that is associated with the existence
    ///             and lifecycle of the Rule.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isRuleAssociatedWith"></see></summary>
    let isRuleAssociatedWith = _prefix "isRuleAssociatedWith"
    /// <summary>
    /// Connects a Mandate to a Mandate Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#mandateIsSourceOfMandateRelation"></see></summary>
    let mandateIsSourceOfMandateRelation = _prefix "mandateIsSourceOfMandateRelation"

    /// <summary>
    /// Connects an Agent that assigns the Mandate, to a Mandate
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isAuthorizingAgentInMandateRelation"></see></summary>
    let isAuthorizingAgentInMandateRelation =
        _prefix "isAuthorizingAgentInMandateRelation"

    /// <summary>
    /// Information on a Mandate that authorizes an Agent to perform an
    ///             Activity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#authorizingMandate"></see></summary>
    let authorizingMandate = _prefix "authorizingMandate"
    /// <summary>
    /// The rule or conditions that govern the existence or lifecycle of
    ///             a Thing.
    /// <see href="https://www.ica.org/standards/RiC/ontology#ruleFollowed"></see></summary>
    let ruleFollowed = _prefix "ruleFollowed"

    /// <summary>
    /// Connects a Record and an Authorship Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordIsSourceOfAuthorshipRelation"></see></summary>
    let recordIsSourceOfAuthorshipRelation =
        _prefix "recordIsSourceOfAuthorshipRelation"

    /// <summary>
    /// Date at which something began.
    /// <see href="https://www.ica.org/standards/RiC/ontology#beginningDate"></see></summary>
    let beginningDate = _prefix "beginningDate"
    /// <summary>
    /// Chronological information associated with an entity that
    ///             contributes to its identification and contextualization.
    /// <see href="https://www.ica.org/standards/RiC/ontology#date"></see></summary>
    let date = _prefix "date"
    /// <summary>
    /// Date at which a Person was born.
    /// <see href="https://www.ica.org/standards/RiC/ontology#birthDate"></see></summary>
    let birthDate = _prefix "birthDate"
    /// <summary>
    /// Used system of reckoning time in which the beginning, length,
    ///             and divisions of a year are defined, sometimes along with multiyear
    ///             cycles.
    /// <see href="https://www.ica.org/standards/RiC/ontology#calendar"></see></summary>
    let calendar = _prefix "calendar"
    /// <summary>
    /// Identifier of the standard of the Normalized
    ///             date.
    /// <see href="https://www.ica.org/standards/RiC/ontology#dateStandard"></see></summary>
    let dateStandard = _prefix "dateStandard"
    /// <summary>
    /// Number of physical units and/or physical dimensions of the
    ///             carrier of a record resource instantiation. Various carriers, depending on specific
    ///             needs, may have more than one relevant dimension. In some cases, indicating the number
    ///             of physical units may be sufficient, while in other case, relevant dimensions should be
    ///             used in order to characterize the carrier.
    /// <see href="https://www.ica.org/standards/RiC/ontology#carrierExtent"></see></summary>
    let carrierExtent = _prefix "carrierExtent"
    /// <summary>
    /// Countable characteristics of the content of an entity expressed
    ///             as a quantity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#physicalOrLogicalExtent"></see></summary>
    let physicalOrLogicalExtent = _prefix "physicalOrLogicalExtent"
    /// <summary>
    /// Qualifies the level of certitude of the accuracy of a Date, an
    ///             Event or a Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#certainty"></see></summary>
    let certainty = _prefix "certainty"
    /// <summary>
    /// Connects a Person (as a parent) to a Child
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#personIsSourceOfChildRelation"></see></summary>
    let personIsSourceOfChildRelation = _prefix "personIsSourceOfChildRelation"
    /// <summary>
    /// Connects a Person (as a child) to a Child
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#personIsTargetOfChildRelation"></see></summary>
    let personIsTargetOfChildRelation = _prefix "personIsTargetOfChildRelation"
    /// <summary>
    /// A term, number or alphanumeric string that is usually taken from
    ///             an external classification vocabulary or scheme that qualifies the Record
    ///             Resource.
    /// <see href="https://www.ica.org/standards/RiC/ontology#classification"></see></summary>
    let classification = _prefix "classification"
    /// <summary>
    /// Terms and circumstances affecting the availability of a Record
    ///             Resource for consultation. Such conditions may originate in laws, regulations and
    ///             policies, including those pertaining to privacy and security concerns or restrictions;
    ///             they may concern a specific Instantiation of a Record Resource, for example, conditions
    ///             that require preservation treatment; or they may specify the software or hardware
    ///             necessary to access the Instantiation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#conditionsOfAccess"></see></summary>
    let conditionsOfAccess = _prefix "conditionsOfAccess"
    /// <summary>
    /// Terms and circumstances affecting the use of a Record Resource
    ///             after access has been provided. Includes conditions governing reproduction of the Record
    ///             Resource under applicable copyright (intellectual property) and/or property legislation,
    ///             and of the Instantiation, due to conservation status.
    /// <see href="https://www.ica.org/standards/RiC/ontology#conditionsOfUse"></see></summary>
    let conditionsOfUse = _prefix "conditionsOfUse"
    /// <summary>
    /// Connects a Place to a region that is or was within
    ///             it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#containsOrContained"></see></summary>
    let containsOrContained = _prefix "containsOrContained"
    /// <summary>
    /// Connects a Place to a Thing that Place is associated with the
    ///             existence and lifecycle of.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isPlaceAssociatedWith"></see></summary>
    let isPlaceAssociatedWith = _prefix "isPlaceAssociatedWith"
    /// <summary>
    /// Inverse of 'is place associated with' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isAssociatedWithPlace"></see></summary>
    let isAssociatedWithPlace = _prefix "isAssociatedWithPlace"
    /// <summary>
    /// Connects a Thing to a constitutive or component part of that
    ///             Thing.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadPart"></see></summary>
    let hasOrHadPart = _prefix "hasOrHadPart"
    /// <summary>
    /// Inverse of 'contains or contained' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasContainedBy"></see></summary>
    let isOrWasContainedBy = _prefix "isOrWasContainedBy"
    /// <summary>
    /// Connects a Person to a Correspondence Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#personHasCorrespondenceRelation"></see></summary>
    let personHasCorrespondenceRelation = _prefix "personHasCorrespondenceRelation"
    /// <summary>
    /// Date at which an entity was created.
    /// <see href="https://www.ica.org/standards/RiC/ontology#creationDate"></see></summary>
    let creationDate = _prefix "creationDate"

    /// <summary>
    /// Connects a Record Resource or Instantiation (that is created) to
    ///             a Creation Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsSourceOfCreationRelation"></see></summary>
    let recordResourceOrInstantiationIsSourceOfCreationRelation =
        _prefix "recordResourceOrInstantiationIsSourceOfCreationRelation"

    /// <summary>
    /// Connects a Role Type to a Creation Relation (this Role Type
    ///             being the specific role played by the creating Person in the context of this
    ///             Relation).
    /// <see href="https://www.ica.org/standards/RiC/ontology#roleIsContextOfCreationRelation"></see></summary>
    let roleIsContextOfCreationRelation = _prefix "roleIsContextOfCreationRelation"
    /// <summary>
    /// Indicates the precision of a date. It specifies if, and to what
    ///             extent, the value is an estimation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#dateQualifier"></see></summary>
    let dateQualifier = _prefix "dateQualifier"
    /// <summary>
    /// Date at which a Person died.
    /// <see href="https://www.ica.org/standards/RiC/ontology#deathDate"></see></summary>
    let deathDate = _prefix "deathDate"
    /// <summary>
    /// Date at which something ended.
    /// <see href="https://www.ica.org/standards/RiC/ontology#endDate"></see></summary>
    let endDate = _prefix "endDate"
    /// <summary>
    /// Date at which an entity was deleted.
    /// <see href="https://www.ica.org/standards/RiC/ontology#deletionDate"></see></summary>
    let deletionDate = _prefix "deletionDate"

    /// <summary>
    /// Connects an Instantiation (from which at least one Instantiation
    ///             is derived) to a Derivation Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#instantiationIsSourceOfDerivationRelation"></see></summary>
    let instantiationIsSourceOfDerivationRelation =
        _prefix "instantiationIsSourceOfDerivationRelation"

    /// <summary>
    /// Connects a derived Instantiation to a Derivation
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#instantiationIsTargetOfDerivationRelation"></see></summary>
    let instantiationIsTargetOfDerivationRelation =
        _prefix "instantiationIsTargetOfDerivationRelation"

    /// <summary>
    /// Connects a Person (as an ancestor) to a Descendance
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#personIsSourceOfDescendanceRelation"></see></summary>
    let personIsSourceOfDescendanceRelation =
        _prefix "personIsSourceOfDescendanceRelation"

    /// <summary>
    /// Connects a Person (as a descendant) to a Descendance
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#personIsTargetOfDescendanceRelation"></see></summary>
    let personIsTargetOfDescendanceRelation =
        _prefix "personIsTargetOfDescendanceRelation"

    /// <summary>
    /// Connects a Record Resource to a Thing that it
    ///             describes.
    /// <see href="https://www.ica.org/standards/RiC/ontology#describesOrDescribed"></see></summary>
    let describesOrDescribed = _prefix "describesOrDescribed"
    /// <summary>
    /// Connects a Record Resource to a Thing that is or was its
    ///             subject.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadSubject"></see></summary>
    let hasOrHadSubject = _prefix "hasOrHadSubject"
    /// <summary>
    /// Inverse of 'describes or described' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasDescribedBy"></see></summary>
    let isOrWasDescribedBy = _prefix "isOrWasDescribedBy"
    /// <summary>
    /// Descriptive information about an entity that is not otherwise
    ///             addressed.
    /// <see href="https://www.ica.org/standards/RiC/ontology#descriptiveNote"></see></summary>
    let descriptiveNote = _prefix "descriptiveNote"
    /// <summary>
    /// Inverse of 'documents' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#documentedBy"></see></summary>
    let documentedBy = _prefix "documentedBy"
    /// <summary>
    /// Connects an Event to a Thing that results or resulted from the
    ///             Event.
    /// <see href="https://www.ica.org/standards/RiC/ontology#resultsOrResultedIn"></see></summary>
    let resultsOrResultedIn = _prefix "resultsOrResultedIn"
    /// <summary>
    /// Connects a Record Resource or an Instantiation to the Activity
    ///             that generates the Record Resource or Instantiation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#documents"></see></summary>
    let documents = _prefix "documents"
    /// <summary>
    /// Inverse of 'results or resulted in' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#resultsOrResultedFrom"></see></summary>
    let resultsOrResultedFrom = _prefix "resultsOrResultedFrom"
    /// <summary>
    /// Connects an Event to an Event Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#eventIsSourceOfEventRelation"></see></summary>
    let eventIsSourceOfEventRelation = _prefix "eventIsSourceOfEventRelation"
    /// <summary>
    /// Connects a Thing (that is associated with an Event) to an Event
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfEventRelation"></see></summary>
    let thingIsTargetOfEventRelation = _prefix "thingIsTargetOfEventRelation"
    /// <summary>
    /// Connects a Position to a Group in which that Position exists or
    ///             existed, or that is defined by that Group�s organizational structure.
    /// <see href="https://www.ica.org/standards/RiC/ontology#existsOrExistedIn"></see></summary>
    let existsOrExistedIn = _prefix "existsOrExistedIn"
    /// <summary>
    /// Connects two Agents. This object property is
    ///             symmetric.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isAgentAssociatedWithAgent"></see></summary>
    let isAgentAssociatedWithAgent = _prefix "isAgentAssociatedWithAgent"
    /// <summary>
    /// Inverse of 'exists or existed in' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadPosition"></see></summary>
    let hasOrHadPosition = _prefix "hasOrHadPosition"

    /// <summary>
    /// Connects a Position (that exists within a Group) to a Position
    ///             to Group Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#positionIsSourceOfPositionToGroupRelation"></see></summary>
    let positionIsSourceOfPositionToGroupRelation =
        _prefix "positionIsSourceOfPositionToGroupRelation"

    /// <summary>
    /// Natural language expression of a Date.
    /// <see href="https://www.ica.org/standards/RiC/ontology#expressedDate"></see></summary>
    let expressedDate = _prefix "expressedDate"
    /// <summary>
    /// A textual expression of an Appellation or Date.
    /// <see href="https://www.ica.org/standards/RiC/ontology#textualValue"></see></summary>
    let textualValue = _prefix "textualValue"
    /// <summary>
    /// Inverse of 'is or was expressed by' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#expressesOrExpressed"></see></summary>
    let expressesOrExpressed = _prefix "expressesOrExpressed"
    /// <summary>
    /// Connects a Rule to a Record Resource that expresses or expressed
    ///             the Rule.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasExpressedBy"></see></summary>
    let isOrWasExpressedBy = _prefix "isOrWasExpressedBy"
    /// <summary>
    /// Connects a Person to a Family Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#personHasFamilyRelation"></see></summary>
    let personHasFamilyRelation = _prefix "personHasFamilyRelation"
    /// <summary>
    /// Inverse of 'precedes in time' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#followsInTime"></see></summary>
    let followsInTime = _prefix "followsInTime"
    /// <summary>
    /// Inverse of 'precedesOrPreceded' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#followsOrFollowed"></see></summary>
    let followsOrFollowed = _prefix "followsOrFollowed"
    /// <summary>
    /// Connects a Thing to a Thing that follows it in chronological
    ///             order.
    /// <see href="https://www.ica.org/standards/RiC/ontology#precedesInTime"></see></summary>
    let precedesInTime = _prefix "precedesInTime"
    /// <summary>
    /// The most generic object property. Connects an Thing to any other
    ///             Thing This is a symmetric object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isRelatedTo"></see></summary>
    let isRelatedTo = _prefix "isRelatedTo"
    /// <summary>
    /// Connects a Thing to a Thing that follows or followed it in some
    ///             sequence.
    /// <see href="https://www.ica.org/standards/RiC/ontology#precedesOrPreceded"></see></summary>
    let precedesOrPreceded = _prefix "precedesOrPreceded"
    /// <summary>
    /// Connects a Thing (that follows other Thing(s) in a sequence) to
    ///             a Sequential Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfSequentialRelation"></see></summary>
    let thingIsTargetOfSequentialRelation = _prefix "thingIsTargetOfSequentialRelation"

    /// <summary>
    /// Connects an Instantiation to a Functional Equivalence
    ///             Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#instantiationIsConnectedToFunctionalEquivalenceRelation"></see></summary>
    let instantiationIsConnectedToFunctionalEquivalenceRelation =
        _prefix "instantiationIsConnectedToFunctionalEquivalenceRelation"

    /// <summary>
    /// Reference system used for geographical
    ///             coordinates.
    /// <see href="https://www.ica.org/standards/RiC/ontology#geodesicSystem"></see></summary>
    let geodesicSystem = _prefix "geodesicSystem"
    /// <summary>
    /// Longitudinal and latitudinal information of a
    ///             Place.
    /// <see href="https://www.ica.org/standards/RiC/ontology#geographicalCoordinates"></see></summary>
    let geographicalCoordinates = _prefix "geographicalCoordinates"

    /// <summary>
    /// Connects the Group that has at least a subdivision, to a Group
    ///             Subdivision Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#groupIsSourceOfGroupSubdivisionRelation"></see></summary>
    let groupIsSourceOfGroupSubdivisionRelation =
        _prefix "groupIsSourceOfGroupSubdivisionRelation"

    /// <summary>
    /// Connects a Thing to a Whole Part Relation, when this Thing has
    ///             Part other Thing(s).
    /// <see href="https://www.ica.org/standards/RiC/ontology#thingIsSourceOfWholePartRelation"></see></summary>
    let thingIsSourceOfWholePartRelation = _prefix "thingIsSourceOfWholePartRelation"
    /// <summary>
    /// Connects the Group (that has one to many members) to a
    ///             Membership Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#groupIsSourceOfMembershipRelation"></see></summary>
    let groupIsSourceOfMembershipRelation = _prefix "groupIsSourceOfMembershipRelation"

    /// <summary>
    /// Connects a Group that is a subdivision, to a Group Subdivision
    ///             Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#groupIsTargetOfGroupSubdivisionRelation"></see></summary>
    let groupIsTargetOfGroupSubdivisionRelation =
        _prefix "groupIsTargetOfGroupSubdivisionRelation"

    /// <summary>
    /// Connects a Thing to a Whole Part Relation, when this Thing is
    ///             Part of another Thing.
    /// <see href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfWholePartRelation"></see></summary>
    let thingIsTargetOfWholePartRelation = _prefix "thingIsTargetOfWholePartRelation"
    /// <summary>
    /// Connects a Group (which has a leader) to a Leadership
    ///             Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#groupIsTargetOfLeadershipRelation"></see></summary>
    let groupIsTargetOfLeadershipRelation = _prefix "groupIsTargetOfLeadershipRelation"

    /// <summary>
    /// Connects the Group (in which a Position exists) to a Position To
    ///             Group Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#groupIsTargetOfPositionToGroupRelation"></see></summary>
    let groupIsTargetOfPositionToGroupRelation =
        _prefix "groupIsTargetOfPositionToGroupRelation"

    /// <summary>
    /// Connects a Record Resource or an Instantiation to the Agent that
    ///             accumulates it, be it intentionally (collecting) or not (receiving in the course of its
    ///             activities).
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasAccumulator"></see></summary>
    let hasAccumulator = _prefix "hasAccumulator"
    /// <summary>
    /// Connects a Record Resource or an Instantiation to an Agent that
    ///             creates or accumulates the Record Resource, receives it, or sends it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasProvenance"></see></summary>
    let hasProvenance = _prefix "hasProvenance"
    /// <summary>
    /// Inverse of 'has accumulator' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isAccumulatorOf"></see></summary>
    let isAccumulatorOf = _prefix "isAccumulatorOf"
    /// <summary>
    /// Connects a Thing to a Type that categorizes or categorized
    ///             it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadCategory"></see></summary>
    let hasOrHadCategory = _prefix "hasOrHadCategory"
    /// <summary>
    /// Connects a Record Resource or an Instantiation to the Agent that
    ///             it is addressed to.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasAddressee"></see></summary>
    let hasAddressee = _prefix "hasAddressee"
    /// <summary>
    /// Inverse of 'has addressee' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isAddresseeOf"></see></summary>
    let isAddresseeOf = _prefix "isAddresseeOf"
    /// <summary>
    /// Inverse of 'has descendant' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasAncestor"></see></summary>
    let hasAncestor = _prefix "hasAncestor"
    /// <summary>
    /// Connects two Persons that have some type of family link, i.e.
    ///             belong to the same family. This relation is symmetric.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasFamilyAssociationWith"></see></summary>
    let hasFamilyAssociationWith = _prefix "hasFamilyAssociationWith"
    /// <summary>
    /// Inverse of 'has successor' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isSuccessorOf"></see></summary>
    let isSuccessorOf = _prefix "isSuccessorOf"
    /// <summary>
    /// Connects a Person to one of their descendants.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasDescendant"></see></summary>
    let hasDescendant = _prefix "hasDescendant"
    /// <summary>
    /// Connects a Record to the Group, Person or Position that is
    ///             responsible for conceiving and formulating the information contained in the
    ///             Record.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasAuthor"></see></summary>
    let hasAuthor = _prefix "hasAuthor"
    /// <summary>
    /// Connects a Record Resource or an Instantiation to an Agent that
    ///             is either responsible for all or some of the content of the Record Resource or is a
    ///             contributor to the genesis or production of an Instantiation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasCreator"></see></summary>
    let hasCreator = _prefix "hasCreator"
    /// <summary>
    /// Inverse of 'has author' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isAuthorOf"></see></summary>
    let isAuthorOf = _prefix "isAuthorOf"
    /// <summary>
    /// Inverse of 'is date associated with' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isAssociatedWithDate"></see></summary>
    let isAssociatedWithDate = _prefix "isAssociatedWithDate"
    /// <summary>
    /// Connects a Date to a Thing that came into existence on that
    ///             Date.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isBeginningDateOf"></see></summary>
    let isBeginningDateOf = _prefix "isBeginningDateOf"
    /// <summary>
    /// Inverse of 'is birth date of' object property
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasBirthDate"></see></summary>
    let hasBirthDate = _prefix "hasBirthDate"
    /// <summary>
    /// Connects a Date to a Person that was born on that
    ///             Date.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isBirthDateOf"></see></summary>
    let isBirthDateOf = _prefix "isBirthDateOf"
    /// <summary>
    /// Connects a Person to one of their children.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasChild"></see></summary>
    let hasChild = _prefix "hasChild"
    /// <summary>
    /// Inverse of 'has child' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isChildOf"></see></summary>
    let isChildOf = _prefix "isChildOf"
    /// <summary>
    /// Connects a Record Resource or an Instantiation to the Agent that
    ///             collects it intentionally (is a collector).
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasCollector"></see></summary>
    let hasCollector = _prefix "hasCollector"
    /// <summary>
    /// Inverse of 'has collector' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isCollectorOf"></see></summary>
    let isCollectorOf = _prefix "isCollectorOf"
    /// <summary>
    /// Connects a Record or a Record Part to a Content Type which
    ///             categorizes its content.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasContentOfType"></see></summary>
    let hasContentOfType = _prefix "hasContentOfType"
    /// <summary>
    /// Connects a Record Resource to a copy of that Record
    ///             Resource.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasCopy"></see></summary>
    let hasCopy = _prefix "hasCopy"
    /// <summary>
    /// Connects two Record Resources when there is a genetic link
    ///             between them. Genetic in this sense is as defined by diplomatics, i.e. the process by
    ///             which a Record Resource is developed. This relation is symmetric.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasGeneticLinkToRecordResource"></see></summary>
    let hasGeneticLinkToRecordResource = _prefix "hasGeneticLinkToRecordResource"
    /// <summary>
    /// Inverse of 'has copy' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isCopyOf"></see></summary>
    let isCopyOf = _prefix "isCopyOf"
    /// <summary>
    /// Inverse of 'has creator' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isCreatorOf"></see></summary>
    let isCreatorOf = _prefix "isCreatorOf"
    /// <summary>
    /// Inverse of 'is death date of' object property
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasDeathDate"></see></summary>
    let hasDeathDate = _prefix "hasDeathDate"
    /// <summary>
    /// Connects a Date to a Person who died on that
    ///             Date.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isDeathDateOf"></see></summary>
    let isDeathDateOf = _prefix "isDeathDateOf"
    /// <summary>
    /// Connects an Instantiation to an Instantiation that is derived
    ///             from it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasDerivedInstantiation"></see></summary>
    let hasDerivedInstantiation = _prefix "hasDerivedInstantiation"

    /// <summary>
    /// Connects two Instantiations. This object property is
    ///             symmetric.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isInstantiationAssociatedWithInstantiation"></see></summary>
    let isInstantiationAssociatedWithInstantiation =
        _prefix "isInstantiationAssociatedWithInstantiation"

    /// <summary>
    /// Inverse of 'has derived instantiation' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isDerivedFromInstantiation"></see></summary>
    let isDerivedFromInstantiation = _prefix "isDerivedFromInstantiation"
    /// <summary>
    /// Connects an Agent to another Agent that succeeds it
    ///             chronologically.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasSuccessor"></see></summary>
    let hasSuccessor = _prefix "hasSuccessor"
    /// <summary>
    /// Connects a Record or Record Part to its Documentary Form
    ///             Type.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasDocumentaryFormType"></see></summary>
    let hasDocumentaryFormType = _prefix "hasDocumentaryFormType"
    /// <summary>
    /// Inverse of 'is draft of' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasDraft"></see></summary>
    let hasDraft = _prefix "hasDraft"
    /// <summary>
    /// Connects a draft to the final version of a
    ///             Record.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isDraftOf"></see></summary>
    let isDraftOf = _prefix "isDraftOf"
    /// <summary>
    /// Connects a Date to a Thing whose existence ended on that
    ///             Date.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isEndDateOf"></see></summary>
    let isEndDateOf = _prefix "isEndDateOf"
    /// <summary>
    /// Connects a Record Resource or Instantiation to an Extent
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasExtent"></see></summary>
    let hasExtent = _prefix "hasExtent"
    /// <summary>
    /// Connects an Extent to a Record Resource or Instantiation
    /// <see href="https://www.ica.org/standards/RiC/ontology#isExtentOf"></see></summary>
    let isExtentOf = _prefix "isExtentOf"
    /// <summary>
    /// Connects an Extent to an Extent Type that categorizes what is being
    ///             measured.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasExtentType"></see></summary>
    let hasExtentType = _prefix "hasExtentType"
    /// <summary>
    /// Connects an Extent Type to an Extent that it
    ///             categorizes.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isExtentTypeOf"></see></summary>
    let isExtentTypeOf = _prefix "isExtentTypeOf"
    /// <summary>
    /// Connects a Family to a Family Type that categorizes
    ///             it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasFamilyType"></see></summary>
    let hasFamilyType = _prefix "hasFamilyType"

    /// <summary>
    /// Connects two Record Resources. This object property is
    ///             symmetric.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isRecordResourceAssociatedWithRecordResource"></see></summary>
    let isRecordResourceAssociatedWithRecordResource =
        _prefix "isRecordResourceAssociatedWithRecordResource"

    /// <summary>
    /// Inverse of 'has instantiation' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isInstantiationOf"></see></summary>
    let isInstantiationOf = _prefix "isInstantiationOf"

    /// <summary>
    /// Connects a Record Resource (that was instantiated) to a Record
    ///             Resource To Instantiation Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordResourceIsSourceOfRecordResourceToInstantiationRelation"></see></summary>
    let recordResourceIsSourceOfRecordResourceToInstantiationRelation =
        _prefix "recordResourceIsSourceOfRecordResourceToInstantiationRelation"

    /// <summary>
    /// Inverse of 'is modification date of' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasModificationDate"></see></summary>
    let hasModificationDate = _prefix "hasModificationDate"
    /// <summary>
    /// Connects a Date to a Thing that was modified on that
    ///             Date.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isModificationDateOf"></see></summary>
    let isModificationDateOf = _prefix "isModificationDateOf"
    /// <summary>
    /// Connects an Agent and (one of) its present or past Agent
    ///             Name.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadAgentName"></see></summary>
    let hasOrHadAgentName = _prefix "hasOrHadAgentName"
    /// <summary>
    /// Connects a Thing to one of its past or present
    ///             Names.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadName"></see></summary>
    let hasOrHadName = _prefix "hasOrHadName"
    /// <summary>
    /// Connects an Agent Name to an Agent it designates or
    ///             designated.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasAgentNameOf"></see></summary>
    let isOrWasAgentNameOf = _prefix "isOrWasAgentNameOf"
    /// <summary>
    /// Connects a Record Set and a Category (Type) to which all the
    ///             Records or Record Parts that are or were included in the Record Set
    ///             belong.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadAllMembersWithCategory"></see></summary>
    let hasOrHadAllMembersWithCategory = _prefix "hasOrHadAllMembersWithCategory"
    /// <summary>
    /// Connects a Category (Type) and a Record Set whose all present or
    ///             past Record or Record Part members belong to that Category.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasCategoryOfAllMembersOf"></see></summary>
    let isOrWasCategoryOfAllMembersOf = _prefix "isOrWasCategoryOfAllMembersOf"
    /// <summary>
    /// Connects a Record Set and a Content Type that categorizes all
    ///             the Records or Record Parts that are or were included in the Record Set.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadAllMembersWithContentType"></see></summary>
    let hasOrHadAllMembersWithContentType = _prefix "hasOrHadAllMembersWithContentType"
    /// <summary>
    /// Connects a Content Type and a Record Set whose all past or
    ///             present Record or Record Part members have that Content Type.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasContentTypeOfAllMembersOf"></see></summary>
    let isOrWasContentTypeOfAllMembersOf = _prefix "isOrWasContentTypeOfAllMembersOf"

    /// <summary>
    /// Connects a Record Set and a Documentary Form Type that
    ///             categorizes all the Records or Record Parts that are or were included in the Record
    ///             Set.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadAllMembersWithDocumentaryFormType"></see></summary>
    let hasOrHadAllMembersWithDocumentaryFormType =
        _prefix "hasOrHadAllMembersWithDocumentaryFormType"

    /// <summary>
    /// Connects a Documentary Form Type and a Record Set whose all past
    ///             or present Record or Record Part members have that Documentary Form Type.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasDocumentaryFormTypeOfAllMembersOf"></see></summary>
    let isOrWasDocumentaryFormTypeOfAllMembersOf =
        _prefix "isOrWasDocumentaryFormTypeOfAllMembersOf"

    /// <summary>
    /// Connects a Record Set and a Language used by all the Records or
    ///             Record Parts that are or were included in the Record Set.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadAllMembersWithLanguage"></see></summary>
    let hasOrHadAllMembersWithLanguage = _prefix "hasOrHadAllMembersWithLanguage"
    /// <summary>
    /// Connects a Language and a Record Set whose all present or past
    ///             Record or Record Part members use that Language.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasLanguageOfAllMembersOf"></see></summary>
    let isOrWasLanguageOfAllMembersOf = _prefix "isOrWasLanguageOfAllMembersOf"
    /// <summary>
    /// Connects a Record Set and a Legal Status that categorizes all
    ///             the Records or Record Parts that are or were included in the Record Set.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadAllMembersWithLegalStatus"></see></summary>
    let hasOrHadAllMembersWithLegalStatus = _prefix "hasOrHadAllMembersWithLegalStatus"
    /// <summary>
    /// Connects a Legal Status and a Record Set whose all past or
    ///             present Record or Record Part members have that Legal Status.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasLegalStatusOfAllMembersOf"></see></summary>
    let isOrWasLegalStatusOfAllMembersOf = _prefix "isOrWasLegalStatusOfAllMembersOf"
    /// <summary>
    /// Connects a Record Set and a Record State that categorizes all
    ///             the Records or Record Parts that are or were included in the Record Set.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadAllMembersWithRecordState"></see></summary>
    let hasOrHadAllMembersWithRecordState = _prefix "hasOrHadAllMembersWithRecordState"
    /// <summary>
    /// Connects a Record State and a Record Set whose all past or
    ///             present Record or Record Part members have that Record State.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasRecordStateOfAllMembersOf"></see></summary>
    let isOrWasRecordStateOfAllMembersOf = _prefix "isOrWasRecordStateOfAllMembersOf"
    /// <summary>
    /// Connects a Thing to an Appellation that is or was used for
    ///             designating it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadAppellation"></see></summary>
    let hasOrHadAppellation = _prefix "hasOrHadAppellation"
    /// <summary>
    /// Connects an Appellation to a Thing that it designates or
    ///             designated.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasAppellationOf"></see></summary>
    let isOrWasAppellationOf = _prefix "isOrWasAppellationOf"
    /// <summary>
    /// Connects an Agent to a Thing the Agent has or had authority
    ///             over.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadAuthorityOver"></see></summary>
    let hasOrHadAuthorityOver = _prefix "hasOrHadAuthorityOver"
    /// <summary>
    /// Inverse of 'has or had authority over' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasUnderAuthorityOf"></see></summary>
    let isOrWasUnderAuthorityOf = _prefix "isOrWasUnderAuthorityOf"
    /// <summary>
    /// Connects a Type (a category) to a Thing that it categorizes or
    ///             categorized.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasCategoryOf"></see></summary>
    let isOrWasCategoryOf = _prefix "isOrWasCategoryOf"
    /// <summary>
    /// Connects a Thing (that is categorized by a Type) to a Type
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfTypeRelation"></see></summary>
    let thingIsTargetOfTypeRelation = _prefix "thingIsTargetOfTypeRelation"
    /// <summary>
    /// Connects an Instantiation to one of its present or past
    ///             component instantiations.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadComponent"></see></summary>
    let hasOrHadComponent = _prefix "hasOrHadComponent"
    /// <summary>
    /// Inverse of 'has or had component' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasComponentOf"></see></summary>
    let isOrWasComponentOf = _prefix "isOrWasComponentOf"
    /// <summary>
    /// Connects a Record to a Record Part that is or was a component of
    ///             that Record.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadConstituent"></see></summary>
    let hasOrHadConstituent = _prefix "hasOrHadConstituent"
    /// <summary>
    /// Inverse of 'has or had constituent' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasConstituentOf"></see></summary>
    let isOrWasConstituentOf = _prefix "isOrWasConstituentOf"
    /// <summary>
    /// Inverse of 'is or was controller of' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadController"></see></summary>
    let hasOrHadController = _prefix "hasOrHadController"
    /// <summary>
    /// Inverse of 'has or had subordinate' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasSubordinateTo"></see></summary>
    let isOrWasSubordinateTo = _prefix "isOrWasSubordinateTo"
    /// <summary>
    /// Connects an Agent to another Agent it controls or controlled via
    ///             Activities, i.e. controls by function.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasControllerOf"></see></summary>
    let isOrWasControllerOf = _prefix "isOrWasControllerOf"
    /// <summary>
    /// Connects a Corporate Body to a Corporate Body Type which
    ///             categorizes or categorized it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadCorporateBodyType"></see></summary>
    let hasOrHadCorporateBodyType = _prefix "hasOrHadCorporateBodyType"
    /// <summary>
    /// Connects two Persons that correspond or have corresponded with
    ///             each other. This relation is symmetric.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadCorrespondent"></see></summary>
    let hasOrHadCorrespondent = _prefix "hasOrHadCorrespondent"
    /// <summary>
    /// Connects two Persons that directly know each other during their
    ///             existence. This object property is symmetric.
    /// <see href="https://www.ica.org/standards/RiC/ontology#knows"></see></summary>
    let knows = _prefix "knows"
    /// <summary>
    /// Connects a Person or a Group to a Demographic Group to which it
    ///             belongs or belonged.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadDemographicGroup"></see></summary>
    let hasOrHadDemographicGroup = _prefix "hasOrHadDemographicGroup"
    /// <summary>
    /// Connects a Demographic Group to a Person or Group which belongs
    ///             or belonged to it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasDemographicGroupOf"></see></summary>
    let isOrWasDemographicGroupOf = _prefix "isOrWasDemographicGroupOf"
    /// <summary>
    /// Inverse of 'is or was holder of' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadHolder"></see></summary>
    let hasOrHadHolder = _prefix "hasOrHadHolder"
    /// <summary>
    /// Inverse of 'is or was manager of' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadManager"></see></summary>
    let hasOrHadManager = _prefix "hasOrHadManager"
    /// <summary>
    /// Connects an Agent to a Record Resource or Instantiation that the
    ///             Agent holds or held.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasHolderOf"></see></summary>
    let isOrWasHolderOf = _prefix "isOrWasHolderOf"

    /// <summary>
    /// Connects a Record Resource or Instantiation (that is held by an
    ///             Agent) to a Record Resource Holding Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsTargetOfRecordResourceHoldingRelation"></see></summary>
    let recordResourceOrInstantiationIsTargetOfRecordResourceHoldingRelation =
        _prefix "recordResourceOrInstantiationIsTargetOfRecordResourceHoldingRelation"

    /// <summary>
    /// Connects a Thing to one of its past or present
    ///             Identifiers.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadIdentifier"></see></summary>
    let hasOrHadIdentifier = _prefix "hasOrHadIdentifier"
    /// <summary>
    /// Connects an Identifier to a Thing that it identified or
    ///             identifies.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasIdentifierOf"></see></summary>
    let isOrWasIdentifierOf = _prefix "isOrWasIdentifierOf"

    /// <summary>
    /// Inverse of 'is or was holder of intellectual property rights of'
    ///             object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadIntellectualPropertyRightsHolder"></see></summary>
    let hasOrHadIntellectualPropertyRightsHolder =
        _prefix "hasOrHadIntellectualPropertyRightsHolder"

    /// <summary>
    /// Connects an Agent to a Record Resource or Instantiation on which
    ///             the Agent has or had some intellectual property rights.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasHolderOfIntellectualPropertyRightsOf"></see></summary>
    let isOrWasHolderOfIntellectualPropertyRightsOf =
        _prefix "isOrWasHolderOfIntellectualPropertyRightsOf"

    /// <summary>
    /// Connects a Record Resource or Instantiation (on which some
    ///             intellectual property rights are held) to an Intellectual Property Rights
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsTargetOfIntellectualPropertyRightsRelation"></see></summary>
    let recordResourceOrInstantiationIsTargetOfIntellectualPropertyRightsRelation =
        _prefix "recordResourceOrInstantiationIsTargetOfIntellectualPropertyRightsRelation"

    /// <summary>
    /// Inverse of 'is or was jurisdiction of' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadJurisdiction"></see></summary>
    let hasOrHadJurisdiction = _prefix "hasOrHadJurisdiction"
    /// <summary>
    /// Connects a Place to an Agent that has or had jurisdiction over
    ///             the Place.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasJurisdictionOf"></see></summary>
    let isOrWasJurisdictionOf = _prefix "isOrWasJurisdictionOf"
    /// <summary>
    /// Connects an Agent or Record Resource to a Language that it uses
    ///             or used.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadLanguage"></see></summary>
    let hasOrHadLanguage = _prefix "hasOrHadLanguage"
    /// <summary>
    /// Connects a Language to an Agent, Record or Record Part that uses
    ///             or used it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasLanguageOf"></see></summary>
    let isOrWasLanguageOf = _prefix "isOrWasLanguageOf"
    /// <summary>
    /// Inverse of 'is or was leader of' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadLeader"></see></summary>
    let hasOrHadLeader = _prefix "hasOrHadLeader"
    /// <summary>
    /// Connects a Person to the Group that Person leads or led in the
    ///             past.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasLeaderOf"></see></summary>
    let isOrWasLeaderOf = _prefix "isOrWasLeaderOf"
    /// <summary>
    /// Connects an Agent or Record Resource to a Legal Status which
    ///             categorized or categorizes it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadLegalStatus"></see></summary>
    let hasOrHadLegalStatus = _prefix "hasOrHadLegalStatus"
    /// <summary>
    /// Connects a Legal Status to an Agent or Record Resource that it
    ///             categorizes.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasLegalStatusOf"></see></summary>
    let isOrWasLegalStatusOf = _prefix "isOrWasLegalStatusOf"
    /// <summary>
    /// Inverse of 'is or was location of' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadLocation"></see></summary>
    let hasOrHadLocation = _prefix "hasOrHadLocation"
    /// <summary>
    /// Connects a Place to a Thing that is or was located in the
    ///             Place.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasLocationOf"></see></summary>
    let isOrWasLocationOf = _prefix "isOrWasLocationOf"
    /// <summary>
    /// Connects a Record Resource to a Thing that is or was its main
    ///             subject.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadMainSubject"></see></summary>
    let hasOrHadMainSubject = _prefix "hasOrHadMainSubject"
    /// <summary>
    /// Inverse of 'has or had main subject' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasMainSubjectOf"></see></summary>
    let isOrWasMainSubjectOf = _prefix "isOrWasMainSubjectOf"
    /// <summary>
    /// Connects an Agent to a Record Resource or Instantiation that the
    ///             Agent managed or manages.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasManagerOf"></see></summary>
    let isOrWasManagerOf = _prefix "isOrWasManagerOf"

    /// <summary>
    /// Connects a Record Resource or Instantiation (that is managed by
    ///             an Agent) to a Management Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsTargetOfManagementRelation"></see></summary>
    let recordResourceOrInstantiationIsTargetOfManagementRelation =
        _prefix "recordResourceOrInstantiationIsTargetOfManagementRelation"

    /// <summary>
    /// Connects a Group to a Person that is or was a member of that
    ///             Group.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadMember"></see></summary>
    let hasOrHadMember = _prefix "hasOrHadMember"
    /// <summary>
    /// Inverse of 'has or had member' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasMemberOf"></see></summary>
    let isOrWasMemberOf = _prefix "isOrWasMemberOf"
    /// <summary>
    /// Connects a Name to a Thing that it designated or
    ///             designates.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasNameOf"></see></summary>
    let isOrWasNameOf = _prefix "isOrWasNameOf"
    /// <summary>
    /// Inverse of 'is or was owner of' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadOwner"></see></summary>
    let hasOrHadOwner = _prefix "hasOrHadOwner"
    /// <summary>
    /// Connects a Group, Person or Position to a Thing that this Agent
    ///             owns or owned.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasOwnerOf"></see></summary>
    let isOrWasOwnerOf = _prefix "isOrWasOwnerOf"
    /// <summary>
    /// Connects a Thing (that is owned by a Group, a Person or a
    ///             Position) to an Ownership Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfOwnershipRelation"></see></summary>
    let thingIsTargetOfOwnershipRelation = _prefix "thingIsTargetOfOwnershipRelation"
    /// <summary>
    /// Inverse of 'has or had part' relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasPartOf"></see></summary>
    let isOrWasPartOf = _prefix "isOrWasPartOf"
    /// <summary>
    /// Connects an Event to a Thing that is associated with the
    ///             existence and lifecycle of the Event.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isEventAssociatedWith"></see></summary>
    let isEventAssociatedWith = _prefix "isEventAssociatedWith"
    /// <summary>
    /// Inverse of 'has or had participant' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasParticipantIn"></see></summary>
    let isOrWasParticipantIn = _prefix "isOrWasParticipantIn"
    /// <summary>
    /// Connects a Place to one of its past or present
    ///             names.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadPlaceName"></see></summary>
    let hasOrHadPlaceName = _prefix "hasOrHadPlaceName"
    /// <summary>
    /// Connects a Place Name to a Place that was or is designated by
    ///             it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasPlaceNameOf"></see></summary>
    let isOrWasPlaceNameOf = _prefix "isOrWasPlaceNameOf"
    /// <summary>
    /// Connects a Place to a Place Type that categorized or categorizes
    ///             it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadPlaceType"></see></summary>
    let hasOrHadPlaceType = _prefix "hasOrHadPlaceType"
    /// <summary>
    /// Connects a Record Set and a Category (Type) to which some of the
    ///             Records or Record Parts that are or were included in the Record Set
    ///             belong.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadSomeMembersWithCategory"></see></summary>
    let hasOrHadSomeMembersWithCategory = _prefix "hasOrHadSomeMembersWithCategory"
    /// <summary>
    /// Connects a Category (Type) and a Record Set whose some present
    ///             or past Record or Record Part members belong to that Category.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasCategoryOfSomeMembersOf"></see></summary>
    let isOrWasCategoryOfSomeMembersOf = _prefix "isOrWasCategoryOfSomeMembersOf"

    /// <summary>
    /// Connects a Record Set and a Content Type that categorizes some
    ///             of the Records or Record Parts that are or were included in the Record
    ///             Set.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadSomeMembersWithContentType"></see></summary>
    let hasOrHadSomeMembersWithContentType =
        _prefix "hasOrHadSomeMembersWithContentType"

    /// <summary>
    /// Connects a Content Type and a Record Set whose some past or
    ///             present Record or Record Part members have that Content Type.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasContentTypeOfSomeMembersOf"></see></summary>
    let isOrWasContentTypeOfSomeMembersOf = _prefix "isOrWasContentTypeOfSomeMembersOf"
    /// <summary>
    /// Connects a Record Set and a Language used by some of the Records
    ///             or Record Parts that are or were included in the Record Set.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadSomeMembersWithLanguage"></see></summary>
    let hasOrHadSomeMembersWithLanguage = _prefix "hasOrHadSomeMembersWithLanguage"
    /// <summary>
    /// Connects a Language and a Record Set whose some present or past
    ///             Record or Record Part members use that Language.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasLanguageOfSomeMembersOf"></see></summary>
    let isOrWasLanguageOfSomeMembersOf = _prefix "isOrWasLanguageOfSomeMembersOf"

    /// <summary>
    /// Connects a Record Set and a Legal Status that categorizes some
    ///             of the Records or Record Parts that are or were included in the Record
    ///             Set.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadSomeMembersWithLegalStatus"></see></summary>
    let hasOrHadSomeMembersWithLegalStatus =
        _prefix "hasOrHadSomeMembersWithLegalStatus"

    /// <summary>
    /// Connects a Legal Status and a Record Set whose some past or
    ///             present Record or Record Part members have that Legal Status.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasLegalStatusOfSomeMembersOf"></see></summary>
    let isOrWasLegalStatusOfSomeMembersOf = _prefix "isOrWasLegalStatusOfSomeMembersOf"

    /// <summary>
    /// Connects a Record Set and a Record State that categorizes some
    ///             of the Records or Record Parts that are or were included in the Record
    ///             Set.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadSomeMembersWithRecordState"></see></summary>
    let hasOrHadSomeMembersWithRecordState =
        _prefix "hasOrHadSomeMembersWithRecordState"

    /// <summary>
    /// Connects a Record State and a Record Set whose some past or
    ///             present Record or Record Part members have that Record State.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasRecordStateOfSomeMembersOf"></see></summary>
    let isOrWasRecordStateOfSomeMembersOf = _prefix "isOrWasRecordStateOfSomeMembersOf"

    /// <summary>
    /// Connects a Record Set and a Documentary Form Type that
    ///             categorizes some of the Records or Record Parts that are or were included in the Record
    ///             Set.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadSomeMemberswithDocumentaryFormType"></see></summary>
    let hasOrHadSomeMemberswithDocumentaryFormType =
        _prefix "hasOrHadSomeMemberswithDocumentaryFormType"

    /// <summary>
    /// Connects a Documentary Form Type and a Record Set whose some
    ///             past or present Record or Record Part members have that Documentary Form
    ///             Type.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasDocumentaryFormTypeOfSomeMembersOf"></see></summary>
    let isOrWasDocumentaryFormTypeOfSomeMembersOf =
        _prefix "isOrWasDocumentaryFormTypeOfSomeMembersOf"

    /// <summary>
    /// Connects two Persons that are or were married. This relation is
    ///             symmetric.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadSpouse"></see></summary>
    let hasOrHadSpouse = _prefix "hasOrHadSpouse"
    /// <summary>
    /// Connects a Person to a Spouse Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#personHasSpouseRelation"></see></summary>
    let personHasSpouseRelation = _prefix "personHasSpouseRelation"
    /// <summary>
    /// Inverse of 'has or had teacher' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadStudent"></see></summary>
    let hasOrHadStudent = _prefix "hasOrHadStudent"
    /// <summary>
    /// Connects a Person to another Person who is or was their
    ///             student.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadTeacher"></see></summary>
    let hasOrHadTeacher = _prefix "hasOrHadTeacher"
    /// <summary>
    /// Connects a Person (as a teacher) to a Teaching
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#personIsSourceOfTeachingRelation"></see></summary>
    let personIsSourceOfTeachingRelation = _prefix "personIsSourceOfTeachingRelation"
    /// <summary>
    /// Connects a Group to one of its present or past
    ///             subdivisions.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadSubdivision"></see></summary>
    let hasOrHadSubdivision = _prefix "hasOrHadSubdivision"
    /// <summary>
    /// Connects an Agent to an Agent that is hierarchically
    ///             inferior.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadSubordinate"></see></summary>
    let hasOrHadSubordinate = _prefix "hasOrHadSubordinate"
    /// <summary>
    /// Inverse of 'has or had subdivision' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasSubdivisionOf"></see></summary>
    let isOrWasSubdivisionOf = _prefix "isOrWasSubdivisionOf"
    /// <summary>
    /// Connects an Event to one of a series of Events that constitute
    ///             the original, broader, past or ongoing Event.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadSubevent"></see></summary>
    let hasOrHadSubevent = _prefix "hasOrHadSubevent"
    /// <summary>
    /// Inverse of 'is event associated with' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isAssociatedWithEvent"></see></summary>
    let isAssociatedWithEvent = _prefix "isAssociatedWithEvent"
    /// <summary>
    /// Inverse of 'has or had subevent' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasSubeventOf"></see></summary>
    let isOrWasSubeventOf = _prefix "isOrWasSubeventOf"
    /// <summary>
    /// Inverse of 'has or had subject' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasSubjectOf"></see></summary>
    let isOrWasSubjectOf = _prefix "isOrWasSubjectOf"
    /// <summary>
    /// Connects a Person (as a student) to a Teaching
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#personIsTargetOfTeachingRelation"></see></summary>
    let personIsTargetOfTeachingRelation = _prefix "personIsTargetOfTeachingRelation"
    /// <summary>
    /// Connects a Record Resource, Instantiation or Rule to a title
    ///             that is or was used for designating it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadTitle"></see></summary>
    let hasOrHadTitle = _prefix "hasOrHadTitle"
    /// <summary>
    /// Connects a Title to a Record Resource, Instantiation or Rule
    ///             that it designated or designates.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasTitleOf"></see></summary>
    let isOrWasTitleOf = _prefix "isOrWasTitleOf"
    /// <summary>
    /// Connects two Agents that have or had some type of work relation
    ///             in the course of their activities. This relation is symmetric.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadWorkRelationWith"></see></summary>
    let hasOrHadWorkRelationWith = _prefix "hasOrHadWorkRelationWith"
    /// <summary>
    /// Inverse of 'is original of' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOriginal"></see></summary>
    let hasOriginal = _prefix "hasOriginal"
    /// <summary>
    /// Connects the original version of a Record to a copy or a later
    ///             version.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOriginalOf"></see></summary>
    let isOriginalOf = _prefix "isOriginalOf"
    /// <summary>
    /// inverse of 'has provenance' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isProvenanceOf"></see></summary>
    let isProvenanceOf = _prefix "isProvenanceOf"
    /// <summary>
    /// Connects a Record resource to an Agent who published
    ///             it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasPublisher"></see></summary>
    let hasPublisher = _prefix "hasPublisher"
    /// <summary>
    /// Connects an Agent to a Record Resource that it
    ///             published.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isPublisherOf"></see></summary>
    let isPublisherOf = _prefix "isPublisherOf"
    /// <summary>
    /// Connects a Record Resource or an Instantiation to the Agent that
    ///             receives it in the course of its activities.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasReceiver"></see></summary>
    let hasReceiver = _prefix "hasReceiver"
    /// <summary>
    /// Inverse of 'received by' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isReceiverOf"></see></summary>
    let isReceiverOf = _prefix "isReceiverOf"
    /// <summary>
    /// Connects a Record or Record Part to a Record State that
    ///             categorizes its state.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasRecordState"></see></summary>
    let hasRecordState = _prefix "hasRecordState"
    /// <summary>
    /// Connects a Record State to a Record or Record Part whose state
    ///             it categorizes.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isRecordStateOf"></see></summary>
    let isRecordStateOf = _prefix "isRecordStateOf"
    /// <summary>
    /// Connects a Record Resource to a reply, usually in the form of
    ///             correspondence.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasReply"></see></summary>
    let hasReply = _prefix "hasReply"
    /// <summary>
    /// Inverse of 'has reply' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isReplyTo"></see></summary>
    let isReplyTo = _prefix "isReplyTo"
    /// <summary>
    /// Connects a Record Resource or an Instantiation to the Agent that
    ///             sends it
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasSender"></see></summary>
    let hasSender = _prefix "hasSender"
    /// <summary>
    /// Inverse of 'has sender' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isSenderOf"></see></summary>
    let isSenderOf = _prefix "isSenderOf"
    /// <summary>
    /// Connects two Persons that are siblings. This relation is
    ///             symmetric.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasSibling"></see></summary>
    let hasSibling = _prefix "hasSibling"
    /// <summary>
    /// Connects a Person to a Sibling Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#personHasSiblingRelation"></see></summary>
    let personHasSiblingRelation = _prefix "personHasSiblingRelation"
    /// <summary>
    /// Connects a Record Resource or Relation to a Record Resource or
    ///             Agent that is used as a source of information for identifying or describing
    ///             it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasSource"></see></summary>
    let hasSource = _prefix "hasSource"
    /// <summary>
    /// Connects a Record Resource or an Agent to a Record Resource or
    ///             Relation, when the first is used as a source of information for identifying or
    ///             describing the second one.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isSourceOf"></see></summary>
    let isSourceOf = _prefix "isSourceOf"
    /// <summary>
    /// Connects an Extent to a Unit Of Measurement
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasUnitOfMeasurement"></see></summary>
    let hasUnitOfMeasurement = _prefix "hasUnitOfMeasurement"
    /// <summary>
    /// Inverse of 'has unit of measurement' object property
    /// <see href="https://www.ica.org/standards/RiC/ontology#isUnitOfMeasurementOf"></see></summary>
    let isUnitOfMeasurementOf = _prefix "isUnitOfMeasurementOf"
    /// <summary>
    /// Vertical dimension of an entity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#height"></see></summary>
    let height = _prefix "height"
    /// <summary>
    /// Summary of the development of an entity, since its origin until
    ///             present time.
    /// <see href="https://www.ica.org/standards/RiC/ontology#history"></see></summary>
    let history = _prefix "history"
    /// <summary>
    /// A word, number, letter, symbol, or any combination of these used
    ///             to uniquely identify or reference an individual instance of an entity within a specific
    ///             information domain. Includes Global Persistent Identifiers (globally unique and
    ///             persistently resolvable identifier for the entity) and/or Local
    ///             Identifiers.
    /// <see href="https://www.ica.org/standards/RiC/ontology#identifier"></see></summary>
    let identifier = _prefix "identifier"
    /// <summary>
    /// Connects a Record Set to a Record or Record Set it aggregates,
    ///             or aggregated in the past.
    /// <see href="https://www.ica.org/standards/RiC/ontology#includesOrIncluded"></see></summary>
    let includesOrIncluded = _prefix "includesOrIncluded"
    /// <summary>
    /// Inverse of 'includes or included' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasIncludedIn"></see></summary>
    let isOrWasIncludedIn = _prefix "isOrWasIncludedIn"
    /// <summary>
    /// Countable characteristics of the Instantiation expressed as a
    ///             quantity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#instantiationExtent"></see></summary>
    let instantiationExtent = _prefix "instantiationExtent"

    /// <summary>
    /// Connects an Instantiation to an Instantiation to Instantiation
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#instantiationIsConnectedToInstantiationRelation"></see></summary>
    let instantiationIsConnectedToInstantiationRelation =
        _prefix "instantiationIsConnectedToInstantiationRelation"

    /// <summary>
    /// Connects an Instantiation (from which at least one Instantiation
    ///             is migrated) to a Migration Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#instantiationIsSourceOfMigrationRelation"></see></summary>
    let instantiationIsSourceOfMigrationRelation =
        _prefix "instantiationIsSourceOfMigrationRelation"

    /// <summary>
    /// Connects an Instantiation which results from a migration, to a
    ///             Migration Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#instantiationIsTargetOfMigrationRelation"></see></summary>
    let instantiationIsTargetOfMigrationRelation =
        _prefix "instantiationIsTargetOfMigrationRelation"

    /// <summary>
    /// Connects an Instantiation of a Record Resource to the Record
    ///             Resource to Instantiation Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#instantiationIsTargetOfRecordResourceToInstantiationRelation"></see></summary>
    let instantiationIsTargetOfRecordResourceToInstantiationRelation =
        _prefix "instantiationIsTargetOfRecordResourceToInstantiationRelation"

    /// <summary>
    /// Information about the physical arrangement and composition of an
    ///             Instantiation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#instantiationStructure"></see></summary>
    let instantiationStructure = _prefix "instantiationStructure"
    /// <summary>
    /// Information about the intellectual arrangement and composition
    ///             of a Record Resource or the physical arrangement and composition of an Instantiation.
    ///             For Record and Record Part, it encompasses information about the intellectual
    ///             composition of the record, the presence of record parts and their functions. For Record
    ///             Set, it encompasses information about the methodology or criteria used for arranging the
    ///             Record Set members or Record members within the containing Record Set. For
    ///             Instantiation, it may comprise information about the composition of the physical
    ///             elements of the instantiation
    /// <see href="https://www.ica.org/standards/RiC/ontology#structure"></see></summary>
    let structure = _prefix "structure"
    /// <summary>
    /// Information about the completeness of a Record Resource or
    ///             Instantiation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#integrity"></see></summary>
    let integrity = _prefix "integrity"
    /// <summary>
    /// Connects a Date to a Thing that the Date is associated with the
    ///             existence and lifecycle of.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isDateAssociatedWith"></see></summary>
    let isDateAssociatedWith = _prefix "isDateAssociatedWith"
    /// <summary>
    /// Connects a Thing (that is associated with a Place) to a Place
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfPlaceRelation"></see></summary>
    let thingIsTargetOfPlaceRelation = _prefix "thingIsTargetOfPlaceRelation"
    /// <summary>
    /// Connects two Things that are considered
    ///             equivalent.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isEquivalentTo"></see></summary>
    let isEquivalentTo = _prefix "isEquivalentTo"
    /// <summary>
    /// Connects a Date to an Appellation, when it is the date at which
    ///             the Appellation was first used.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isFromUseDateOf"></see></summary>
    let isFromUseDateOf = _prefix "isFromUseDateOf"
    /// <summary>
    /// Connects an Appellation to the Date from which it was
    ///             used.
    /// <see href="https://www.ica.org/standards/RiC/ontology#wasUsedFromDate"></see></summary>
    let wasUsedFromDate = _prefix "wasUsedFromDate"
    /// <summary>
    /// Connects two Instantiations which may be considered as
    ///             equivalent. This relation is symmetric.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isFunctionallyEquivalentTo"></see></summary>
    let isFunctionallyEquivalentTo = _prefix "isFunctionallyEquivalentTo"
    /// <summary>
    /// Connects a Date and a Thing that was last modified at this
    ///             Date.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isLastUpdateDateOf"></see></summary>
    let isLastUpdateDateOf = _prefix "isLastUpdateDateOf"
    /// <summary>
    /// Connects a Thing to the Date when it was last
    ///             modified.
    /// <see href="https://www.ica.org/standards/RiC/ontology#wasLastUpdatedAtDate"></see></summary>
    let wasLastUpdatedAtDate = _prefix "wasLastUpdatedAtDate"
    /// <summary>
    /// Connects two Places that are or were geographically adjacent.
    ///             This is a symmetric object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasAdjacentTo"></see></summary>
    let isOrWasAdjacentTo = _prefix "isOrWasAdjacentTo"
    /// <summary>
    /// Connects a Type (a category) to a Type Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#typeIsSourceOfTypeRelation"></see></summary>
    let typeIsSourceOfTypeRelation = _prefix "typeIsSourceOfTypeRelation"
    /// <summary>
    /// Connects a Rule to an Agent that enforces or enforced the
    ///             Rule.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasEnforcedBy"></see></summary>
    let isOrWasEnforcedBy = _prefix "isOrWasEnforcedBy"
    /// <summary>
    /// Inverse of 'is or was enforced by' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasResponsibleForEnforcing"></see></summary>
    let isOrWasResponsibleForEnforcing = _prefix "isOrWasResponsibleForEnforcing"

    /// <summary>
    /// Connects a Person (as a leader) to a Leadership
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#personIsSourceOfLeadershipRelation"></see></summary>
    let personIsSourceOfLeadershipRelation =
        _prefix "personIsSourceOfLeadershipRelation"

    /// <summary>
    /// Connects a Person (as a member of a Group) to a Membership
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#personIsTargetOfMembershipRelation"></see></summary>
    let personIsTargetOfMembershipRelation =
        _prefix "personIsTargetOfMembershipRelation"

    /// <summary>
    /// Inverse of 'occupies or occupied' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasOccupiedBy"></see></summary>
    let isOrWasOccupiedBy = _prefix "isOrWasOccupiedBy"
    /// <summary>
    /// Connects a Person to a Position they occupy or
    ///             occupied.
    /// <see href="https://www.ica.org/standards/RiC/ontology#occupiesOrOccupied"></see></summary>
    let occupiesOrOccupied = _prefix "occupiesOrOccupied"

    /// <summary>
    /// Connects a Position (that is occupied by a Person) to a Position
    ///             Holding Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#positionIsTargetOfPositionHoldingRelation"></see></summary>
    let positionIsTargetOfPositionHoldingRelation =
        _prefix "positionIsTargetOfPositionHoldingRelation"

    /// <summary>
    /// Inverse of 'is or was performed by' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#performsOrPerformed"></see></summary>
    let performsOrPerformed = _prefix "performsOrPerformed"
    /// <summary>
    /// Inverse of the 'regulates or regulated' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasRegulatedBy"></see></summary>
    let isOrWasRegulatedBy = _prefix "isOrWasRegulatedBy"
    /// <summary>
    /// Connects a Rule to a Thing that it regulates or
    ///             regulated.
    /// <see href="https://www.ica.org/standards/RiC/ontology#regulatesOrRegulated"></see></summary>
    let regulatesOrRegulated = _prefix "regulatesOrRegulated"
    /// <summary>
    /// Connects a Place (as associated to a Thing) to a Place
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#placeIsSourceOfPlaceRelation"></see></summary>
    let placeIsSourceOfPlaceRelation = _prefix "placeIsSourceOfPlaceRelation"

    /// <summary>
    /// Connects a Record Resource to a Record Resource
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordResourceIsConnectedToRecordResourceRelation"></see></summary>
    let recordResourceIsConnectedToRecordResourceRelation =
        _prefix "recordResourceIsConnectedToRecordResourceRelation"

    /// <summary>
    /// Inverse of 'issued by' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isResponsibleForIssuing"></see></summary>
    let isResponsibleForIssuing = _prefix "isResponsibleForIssuing"
    /// <summary>
    /// Connects a Rule to the Agent that issued or published the
    ///             Rule.
    /// <see href="https://www.ica.org/standards/RiC/ontology#issuedBy"></see></summary>
    let issuedBy = _prefix "issuedBy"
    /// <summary>
    /// Connects a Rule to a Rule Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#ruleIsSourceOfRuleRelation"></see></summary>
    let ruleIsSourceOfRuleRelation = _prefix "ruleIsSourceOfRuleRelation"
    /// <summary>
    /// Connects a Date to an Appellation, when it is the date till
    ///             which the Appellation was used.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isToUseDateOf"></see></summary>
    let isToUseDateOf = _prefix "isToUseDateOf"
    /// <summary>
    /// Connects an Appellation to the Date till when it was
    ///             used.
    /// <see href="https://www.ica.org/standards/RiC/ontology#wasUsedToDate"></see></summary>
    let wasUsedToDate = _prefix "wasUsedToDate"
    /// <summary>
    /// Connects a Person (who has some knowledge of another one) to a
    ///             Knowing Of Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#personIsSourceOfKnowingOfRelation"></see></summary>
    let personIsSourceOfKnowingOfRelation = _prefix "personIsSourceOfKnowingOfRelation"
    /// <summary>
    /// Connects a Person (of which another Person has some knowledge)
    ///             to a Knowing Of Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#personIsTargetOfKnowingOfRelation"></see></summary>
    let personIsTargetOfKnowingOfRelation = _prefix "personIsTargetOfKnowingOfRelation"
    /// <summary>
    /// Connects a Person to a Knowing Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#personHasKnowingRelation"></see></summary>
    let personHasKnowingRelation = _prefix "personHasKnowingRelation"
    /// <summary>
    /// Inverse of 'knows of' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#knownBy"></see></summary>
    let knownBy = _prefix "knownBy"
    /// <summary>
    /// Connects a Person to another Person they have some knowledge of
    ///             through time or space.
    /// <see href="https://www.ica.org/standards/RiC/ontology#knowsOf"></see></summary>
    let knowsOf = _prefix "knowsOf"
    /// <summary>
    /// Date at which an entity was last updated.
    /// <see href="https://www.ica.org/standards/RiC/ontology#lastModificationDate"></see></summary>
    let lastModificationDate = _prefix "lastModificationDate"
    /// <summary>
    /// Date of the modification of an entity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#modificationDate"></see></summary>
    let modificationDate = _prefix "modificationDate"
    /// <summary>
    /// Distance in degrees north or south of the
    ///             equator.
    /// <see href="https://www.ica.org/standards/RiC/ontology#latitude"></see></summary>
    let latitude = _prefix "latitude"

    /// <summary>
    /// Connects a Position to a Leadership Relation (the leading Person
    ///             occupies that Position).
    /// <see href="https://www.ica.org/standards/RiC/ontology#positionIsContextOfLeadershipRelation"></see></summary>
    let positionIsContextOfLeadershipRelation =
        _prefix "positionIsContextOfLeadershipRelation"

    /// <summary>
    /// A delimitation of the physical territory of a place. This
    ///             datatype property is used to describe basic human-readable text such as an address, a
    ///             cadastral reference, or less precise information found in a record.
    /// <see href="https://www.ica.org/standards/RiC/ontology#location"></see></summary>
    let location = _prefix "location"
    /// <summary>
    /// Distance in degrees east or west of a prime
    ///             meridian.
    /// <see href="https://www.ica.org/standards/RiC/ontology#longitude"></see></summary>
    let longitude = _prefix "longitude"

    /// <summary>
    /// Connects a Position to a Membership Relation (the member Person
    ///             occupies that Position).
    /// <see href="https://www.ica.org/standards/RiC/ontology#positionIsContextOfMembershipRelation"></see></summary>
    let positionIsContextOfMembershipRelation =
        _prefix "positionIsContextOfMembershipRelation"

    /// <summary>
    /// Inverse of 'migrated into' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#migratedFrom"></see></summary>
    let migratedFrom = _prefix "migratedFrom"
    /// <summary>
    /// Connects an Instantiation to a version it has been migrated
    ///             to.
    /// <see href="https://www.ica.org/standards/RiC/ontology#migratedInto"></see></summary>
    let migratedInto = _prefix "migratedInto"
    /// <summary>
    /// A label, title or term designating the entity in order to make
    ///             it distinguishable from other similar entities. For Record Resource or Instantiation,
    ///             the Name is generally assigned by an Agent as most do not have a Name given when
    ///             created.
    /// <see href="https://www.ica.org/standards/RiC/ontology#name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    /// Date representation based on a standard, preferably
    ///             machine-readable.
    /// <see href="https://www.ica.org/standards/RiC/ontology#normalizedDateValue"></see></summary>
    let normalizedDateValue = _prefix "normalizedDateValue"
    /// <summary>
    /// Value representation based on a standard, preferably
    ///             machine-readable.
    /// <see href="https://www.ica.org/standards/RiC/ontology#normalizedValue"></see></summary>
    let normalizedValue = _prefix "normalizedValue"

    /// <summary>
    /// Connects a Person (who occupies a Position) to a Position
    ///             Holding Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#personIsSourceOfPositionHoldingRelation"></see></summary>
    let personIsSourceOfPositionHoldingRelation =
        _prefix "personIsSourceOfPositionHoldingRelation"

    /// <summary>
    /// Connects two Places that geographically overlap or overlapped.
    ///             This object property is symmetric.
    /// <see href="https://www.ica.org/standards/RiC/ontology#overlapsOrOverlapped"></see></summary>
    let overlapsOrOverlapped = _prefix "overlapsOrOverlapped"
    /// <summary>
    /// Information about the physical features of the Instantiation.
    ///             Includes information about the physical nature and condition such as conservation
    ///             status.
    /// <see href="https://www.ica.org/standards/RiC/ontology#physicalCharacteristics"></see></summary>
    let physicalCharacteristics = _prefix "physicalCharacteristics"
    /// <summary>
    /// Connects a Thing to a Sequential Relation, when this Thing
    ///             precedes other Thing(s) in the sequence.
    /// <see href="https://www.ica.org/standards/RiC/ontology#thingIsSourceOfSequentialRelation"></see></summary>
    let thingIsSourceOfSequentialRelation = _prefix "thingIsSourceOfSequentialRelation"
    /// <summary>
    /// Method used in the representation of information on the
    ///             Instantiation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#productionTechnique"></see></summary>
    let productionTechnique = _prefix "productionTechnique"

    /// <summary>
    /// Connects a Record Resource or Instantiation (that is created or
    ///             accumulated by an Agent, or documents an Activity) to a Provenance
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsSourceOfProvenanceRelation"></see></summary>
    let recordResourceOrInstantiationIsSourceOfProvenanceRelation =
        _prefix "recordResourceOrInstantiationIsSourceOfProvenanceRelation"

    /// <summary>
    /// Date of the publication of a Record Resource.
    /// <see href="https://www.ica.org/standards/RiC/ontology#publicationDate"></see></summary>
    let publicationDate = _prefix "publicationDate"
    /// <summary>
    /// Conditions of an Instantiation that impact the legibility or
    ///             completeness of Record Resource, and thus the viability of its use. Conditions may be
    ///             associated with deficiencies in the processes of Record (re)creation or capture, or the
    ///             deterioration of the Instantiation (e.g. its carrier) causing loss of information of the
    ///             record over time
    /// <see href="https://www.ica.org/standards/RiC/ontology#qualityOfRepresentation"></see></summary>
    let qualityOfRepresentation = _prefix "qualityOfRepresentation"
    /// <summary>
    /// Machine-readable quantity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#quantity"></see></summary>
    let quantity = _prefix "quantity"
    /// <summary>
    /// The quantity of information content as human experienced
    ///             represented in the Record Resource. The method and precision of expressing the quantity
    ///             of information represented in a Record Resource will vary by the kind of Record Resource
    ///             being described as well as by processing economy constraints. For record sets, quantity
    ///             may be expressed as number of records, or, for analogue records in particular, by the
    ///             physical storage dimensions of the Record members. For individual records or record
    ///             parts, quantity may be expressed in more precise terms. Use if you don't use
    ///             RecordResourceExtent class and its properties for handling such
    ///             information.
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordResourceExtent"></see></summary>
    let recordResourceExtent = _prefix "recordResourceExtent"

    /// <summary>
    /// Connects a Record Resource to a Record Resource Genetic
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordResourceIsConnectedToRecordResourceGeneticRelation"></see></summary>
    let recordResourceIsConnectedToRecordResourceGeneticRelation =
        _prefix "recordResourceIsConnectedToRecordResourceGeneticRelation"

    /// <summary>
    /// Information about the intellectual arrangement and composition
    ///             of a Record Resource. For Record and Record Part, it encompasses information about the
    ///             intellectual composition of the record, the presence of record parts and their
    ///             functions. For Record Set, it encompasses information about the methodology or criteria
    ///             used for arranging the Record Set members or Record members within the containing Record
    ///             Set
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordResourceStructure"></see></summary>
    let recordResourceStructure = _prefix "recordResourceStructure"
    /// <summary>
    /// Used to qualify the state of a Relation (e. g. present, past,
    ///             ongoing, unknown).
    /// <see href="https://www.ica.org/standards/RiC/ontology#relationState"></see></summary>
    let relationState = _prefix "relationState"
    /// <summary>
    /// Summary of the scope (such as time periods, geography) and
    ///             content (such as subject matter, administrative processes) of the Record Resource. It
    ///             should highlight the information conveyed in the Record Resource, why it was created,
    ///             received, and/or maintained, and the Agents connected to it. Scope and Content provides
    ///             a more complete summary of the informational content of the Record Resource. It may
    ///             include description of relations with agents, activities, dates and places, or with
    ///             other record resources. It is not to be confused with the History attribute which
    ///             focuses on the origination and subsequence changes to a Record Resource.
    /// <see href="https://www.ica.org/standards/RiC/ontology#scopeAndContent"></see></summary>
    let scopeAndContent = _prefix "scopeAndContent"
    /// <summary>
    /// Information about a source used to identify or describe an
    ///             entity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#source"></see></summary>
    let source = _prefix "source"
    /// <summary>
    /// Describes any relevant physical or software feature of any
    ///             device involved in the creation or management of a Record Resource.
    /// <see href="https://www.ica.org/standards/RiC/ontology#technicalCharacteristics"></see></summary>
    let technicalCharacteristics = _prefix "technicalCharacteristics"
    /// <summary>
    /// An identifying name of a Record Resource, Instantiation or
    ///             Rule.
    /// <see href="https://www.ica.org/standards/RiC/ontology#title"></see></summary>
    let title = _prefix "title"
    /// <summary>
    /// A term used to characterize an entity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#type"></see></summary>
    let type_ = _prefix "type"
    /// <summary>
    /// A definite magnitude of a quantity, defined and adopted by convention or by
    ///             law, that is used as a standard for measurement of the same kind of quantity. Can be
    ///             spacial units (cm, m), weight (g, kg), time (s, h), storage (MB, TB) or more informal
    ///             units used in the archival context like number of boxes, pages or words.
    /// <see href="https://www.ica.org/standards/RiC/ontology#unitOfMeasurement"></see></summary>
    let unitOfMeasurement = _prefix "unitOfMeasurement"
    /// <summary>
    /// Date at which an Appellation was first used.
    /// <see href="https://www.ica.org/standards/RiC/ontology#usedFromDate"></see></summary>
    let usedFromDate = _prefix "usedFromDate"
    /// <summary>
    /// Date until an Appellation was used.
    /// <see href="https://www.ica.org/standards/RiC/ontology#usedToDate"></see></summary>
    let usedToDate = _prefix "usedToDate"
    /// <summary>
    /// Horizontal dimension of an entity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#width"></see></summary>
    let width = _prefix "width"
