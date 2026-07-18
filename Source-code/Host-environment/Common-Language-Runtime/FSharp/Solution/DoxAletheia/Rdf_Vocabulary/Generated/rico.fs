namespace https.www.ica.org.standards.RiC.ontology.hash

open DoxAletheia.Rdf_Vocabulary

module rico =
    let _namespace_name = "https://www.ica.org/standards/RiC/ontology#"

    /// <summary>
    /// Connects at least one Record Resource or Instantiation to at
    ///             least one Agent, when the Agent accumulates it, be it intentionally (collecting it) or
    ///             not (receiving it in the course of its activities).
    /// <see href="https://www.ica.org/standards/RiC/ontology#AccumulationRelation"></see></summary>
    let AccumulationRelation =
        Namespaced_IRI.parse _namespace_name "AccumulationRelation" |> NamespacedName

    /// <summary>
    /// Connects an Accumulation Relation to one of the accumulated
    ///             Record Resources or Instantiations
    /// <see href="https://www.ica.org/standards/RiC/ontology#accumulationRelationHasSource"></see></summary>
    let accumulationRelationHasSource =
        Namespaced_IRI.parse _namespace_name "accumulationRelationHasSource" |> NamespacedName

    /// <summary>
    /// The inscription of information made by an Agent on a physical
    ///             carrier in any persistent, recoverable form as a means of communicating information
    ///             through time and space.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Instantiation"></see></summary>
    let Instantiation =
        Namespaced_IRI.parse _namespace_name "Instantiation" |> NamespacedName

    /// <summary>
    /// A Record, Record Set, or Record Part produced or acquired and
    ///             retained by an Agent in the course of Activity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#RecordResource"></see></summary>
    let RecordResource =
        Namespaced_IRI.parse _namespace_name "RecordResource" |> NamespacedName

    /// <summary>
    /// Connects an Accumulation Relation to one of the accumulating
    ///             Agents
    /// <see href="https://www.ica.org/standards/RiC/ontology#accumulationRelationHasTarget"></see></summary>
    let accumulationRelationHasTarget =
        Namespaced_IRI.parse _namespace_name "accumulationRelationHasTarget" |> NamespacedName

    /// <summary>
    /// A Person, or Group, or an entity created by a Person or Group
    ///             (Mechanism), or a Position, that acts in the world.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Agent"></see></summary>
    let Agent = Namespaced_IRI.parse _namespace_name "Agent" |> NamespacedName

    /// <summary>
    /// Connects at least one Record Resource or an Instantiation to at
    ///             least one Agent that creates or accumulates the Record Resource, receives it, or sends
    ///             it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#AgentOriginationRelation"></see></summary>
    let AgentOriginationRelation =
        Namespaced_IRI.parse _namespace_name "AgentOriginationRelation" |> NamespacedName

    /// <summary>
    /// When it exists, specifies the identifier and name of RiC-CM
    ///             component that corresponds to the annotated class or property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#RiCCMCorrespondingComponent"></see></summary>
    let RiCCMCorrespondingComponent =
        Namespaced_IRI.parse _namespace_name "RiCCMCorrespondingComponent" |> NamespacedName

    /// <summary>
    /// The doing of something for some human purpose.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Activity"></see></summary>
    let Activity = Namespaced_IRI.parse _namespace_name "Activity" |> NamespacedName

    /// <summary>
    /// Connects an Activity to an Activity Type that categorizes
    ///             it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasActivityType"></see></summary>
    let hasActivityType =
        Namespaced_IRI.parse _namespace_name "hasActivityType" |> NamespacedName

    /// <summary>
    /// Categorization of an Activity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#ActivityType"></see></summary>
    let ActivityType =
        Namespaced_IRI.parse _namespace_name "ActivityType" |> NamespacedName

    /// <summary>
    /// Something that happens in time and space.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Event"></see></summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName

    /// <summary>
    /// Connects an Activity to an Agent that performed or performs the
    ///             Activity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasPerformedBy"></see></summary>
    let isOrWasPerformedBy =
        Namespaced_IRI.parse _namespace_name "isOrWasPerformedBy" |> NamespacedName

    /// <summary>
    /// Connects at least one Record Resource or Instantiation to at
    ///             least one Activity, when the Record Resource or Instantiation results from the
    ///             activity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#ActivityDocumentationRelation"></see></summary>
    let ActivityDocumentationRelation =
        Namespaced_IRI.parse _namespace_name "ActivityDocumentationRelation" |> NamespacedName

    /// <summary>
    /// Connects an Activity Documentation Relation to one of the
    ///             resulting Record Resources or Instantiations
    /// <see href="https://www.ica.org/standards/RiC/ontology#activityDocumentationRelationHasSource"></see></summary>
    let activityDocumentationRelationHasSource =
        Namespaced_IRI.parse _namespace_name "activityDocumentationRelationHasSource" |> NamespacedName

    /// <summary>
    /// Connects an Activity Documentation Relation to one of the
    ///             documented Activities
    /// <see href="https://www.ica.org/standards/RiC/ontology#activityDocumentationRelationHasTarget"></see></summary>
    let activityDocumentationRelationHasTarget =
        Namespaced_IRI.parse _namespace_name "activityDocumentationRelationHasTarget" |> NamespacedName

    /// <summary>
    /// Specifies the provenance or origin of at least one Record
    ///             Resource or Instantiation, for example the relation between a Record Resource and the
    ///             Agent which created it or the Activity from which it resulted.
    /// <see href="https://www.ica.org/standards/RiC/ontology#ProvenanceRelation"></see></summary>
    let ProvenanceRelation =
        Namespaced_IRI.parse _namespace_name "ProvenanceRelation" |> NamespacedName

    /// <summary>
    /// Connects an Activity Type to an Activity that it
    ///             categorizes.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isActivityTypeOf"></see></summary>
    let isActivityTypeOf =
        Namespaced_IRI.parse _namespace_name "isActivityTypeOf" |> NamespacedName

    /// <summary>
    /// A superclass for any category of some thing. A type
    ///             characterizes an entity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Type"></see></summary>
    let Type = Namespaced_IRI.parse _namespace_name "Type" |> NamespacedName
    /// <summary>
    /// Any idea, material thing, or event within the realm of human
    ///             experience.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Thing"></see></summary>
    let Thing = Namespaced_IRI.parse _namespace_name "Thing" |> NamespacedName

    /// <summary>
    /// Connects at least one Agent, to at least another Agent, when the
    ///             first one(s) control(s) in a way the activities of the second one(s).
    /// <see href="https://www.ica.org/standards/RiC/ontology#AgentControlRelation"></see></summary>
    let AgentControlRelation =
        Namespaced_IRI.parse _namespace_name "AgentControlRelation" |> NamespacedName

    /// <summary>
    /// Connects an Agent Control Relation to one of the controlling
    ///             Agents
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentControlRelationHasSource"></see></summary>
    let agentControlRelationHasSource =
        Namespaced_IRI.parse _namespace_name "agentControlRelationHasSource" |> NamespacedName

    /// <summary>
    /// Connects an Agent Control Relation to one of the controlled
    ///             Agents
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentControlRelationHasTarget"></see></summary>
    let agentControlRelationHasTarget =
        Namespaced_IRI.parse _namespace_name "agentControlRelationHasTarget" |> NamespacedName

    /// <summary>
    /// Connects at least one Agent to at least another Agent, when the
    ///             first one is hierarchically superior to the second one.
    /// <see href="https://www.ica.org/standards/RiC/ontology#AgentHierarchicalRelation"></see></summary>
    let AgentHierarchicalRelation =
        Namespaced_IRI.parse _namespace_name "AgentHierarchicalRelation" |> NamespacedName

    /// <summary>
    /// Connects at least one Agent, and at least one Thing over which
    ///             the Agent has some authority.
    /// <see href="https://www.ica.org/standards/RiC/ontology#AuthorityRelation"></see></summary>
    let AuthorityRelation =
        Namespaced_IRI.parse _namespace_name "AuthorityRelation" |> NamespacedName

    /// <summary>
    /// Connects an Agent Hierarchical Relation to one of the
    ///             hierarchically superior Agents
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentHierarchicalRelationHasSource"></see></summary>
    let agentHierarchicalRelationHasSource =
        Namespaced_IRI.parse _namespace_name "agentHierarchicalRelationHasSource" |> NamespacedName

    /// <summary>
    /// Connects an Agent Hierarchical Relation to one of the
    ///             hierarchically inferior Agents
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentHierarchicalRelationHasTarget"></see></summary>
    let agentHierarchicalRelationHasTarget =
        Namespaced_IRI.parse _namespace_name "agentHierarchicalRelationHasTarget" |> NamespacedName

    /// <summary>
    /// Connects at least two Agents.
    /// <see href="https://www.ica.org/standards/RiC/ontology#AgentToAgentRelation"></see></summary>
    let AgentToAgentRelation =
        Namespaced_IRI.parse _namespace_name "AgentToAgentRelation" |> NamespacedName

    /// <summary>
    /// A label, title or term designating an Agent in order to make it
    ///             distinguishable from other similar entities.
    /// <see href="https://www.ica.org/standards/RiC/ontology#AgentName"></see></summary>
    let AgentName = Namespaced_IRI.parse _namespace_name "AgentName" |> NamespacedName
    /// <summary>
    /// A label, title or term designating the entity in order to make
    ///             it distinguishable from other similar entities.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Name"></see></summary>
    let Name = Namespaced_IRI.parse _namespace_name "Name" |> NamespacedName

    /// <summary>
    /// Connects an Agent Origination Relation to one of the resulting
    ///             Record Resource or Instantiation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentOriginationRelationHasSource"></see></summary>
    let agentOriginationRelationHasSource =
        Namespaced_IRI.parse _namespace_name "agentOriginationRelationHasSource" |> NamespacedName

    /// <summary>
    /// Connects an Agent Origination Relation to one of the creating or
    ///             accumulating Agents
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentOriginationRelationHasTarget"></see></summary>
    let agentOriginationRelationHasTarget =
        Namespaced_IRI.parse _namespace_name "agentOriginationRelationHasTarget" |> NamespacedName

    /// <summary>
    /// Connects at least one Agent, to at least another Agent, that
    ///             succeeds it chronologically for, for instance, fullfilling some functions or performing
    ///             some activities.
    /// <see href="https://www.ica.org/standards/RiC/ontology#AgentTemporalRelation"></see></summary>
    let AgentTemporalRelation =
        Namespaced_IRI.parse _namespace_name "AgentTemporalRelation" |> NamespacedName

    /// <summary>
    /// Connects at least one Thing to at least one Thing that follows
    ///             it in chronological order.
    /// <see href="https://www.ica.org/standards/RiC/ontology#TemporalRelation"></see></summary>
    let TemporalRelation =
        Namespaced_IRI.parse _namespace_name "TemporalRelation" |> NamespacedName

    /// <summary>
    /// Connects an Agent Temporal Relation to one of the successor
    ///             Agents
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentTemporalRelationHasTarget"></see></summary>
    let agentTemporalRelationHasTarget =
        Namespaced_IRI.parse _namespace_name "agentTemporalRelationHasTarget" |> NamespacedName

    /// <summary>
    /// Connects an Agent Temporal Relation or Mandate Relation, to an
    ///             Activity that is, either transferred from an Agent to another one, or assigned by a
    ///             Mandate to an Agent.
    /// <see href="https://www.ica.org/standards/RiC/ontology#asConcernsActivity"></see></summary>
    let asConcernsActivity =
        Namespaced_IRI.parse _namespace_name "asConcernsActivity" |> NamespacedName

    /// <summary>
    /// Connects an Agent Temporal Relation to one of the predecessor
    ///             Agents
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentTemporalRelationHasSource"></see></summary>
    let agentTemporalRelationHasSource =
        Namespaced_IRI.parse _namespace_name "agentTemporalRelationHasSource" |> NamespacedName

    /// <summary>
    /// Connects an Agent Relation to one of the involved
    ///             Agents
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentRelationConnects"></see></summary>
    let agentRelationConnects =
        Namespaced_IRI.parse _namespace_name "agentRelationConnects" |> NamespacedName

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
    let Relation = Namespaced_IRI.parse _namespace_name "Relation" |> NamespacedName

    /// <summary>
    /// A concept of any kind that is used for designating an Entity and
    ///             referring to it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Appellation"></see></summary>
    let Appellation =
        Namespaced_IRI.parse _namespace_name "Appellation" |> NamespacedName

    /// <summary>
    /// An idea, unit of thought, abstract cultural object or
    ///             category
    /// <see href="https://www.ica.org/standards/RiC/ontology#Concept"></see></summary>
    let Concept = Namespaced_IRI.parse _namespace_name "Concept" |> NamespacedName

    /// <summary>
    /// The relation between an Appellation and at least one Thing that
    ///             the Appellation designates.
    /// <see href="https://www.ica.org/standards/RiC/ontology#AppellationRelation"></see></summary>
    let AppellationRelation =
        Namespaced_IRI.parse _namespace_name "AppellationRelation" |> NamespacedName

    /// <summary>
    /// Connects an Appellation Relation to one of the designated
    ///             Things
    /// <see href="https://www.ica.org/standards/RiC/ontology#appellationRelationHasTarget"></see></summary>
    let appellationRelationHasTarget =
        Namespaced_IRI.parse _namespace_name "appellationRelationHasTarget" |> NamespacedName

    /// <summary>
    /// Connects an Appellation Relation to the concerned
    ///             Appellation
    /// <see href="https://www.ica.org/standards/RiC/ontology#appellationRelationHasSource"></see></summary>
    let appellationRelationHasSource =
        Namespaced_IRI.parse _namespace_name "appellationRelationHasSource" |> NamespacedName

    /// <summary>
    /// Connects an Authority Relation to an Agent that has the
    ///             authority
    /// <see href="https://www.ica.org/standards/RiC/ontology#authorityRelationHasSource"></see></summary>
    let authorityRelationHasSource =
        Namespaced_IRI.parse _namespace_name "authorityRelationHasSource" |> NamespacedName

    /// <summary>
    /// Connects an Authority Relation to a Thing over which the
    ///             Authority is performed
    /// <see href="https://www.ica.org/standards/RiC/ontology#authorityRelationHasTarget"></see></summary>
    let authorityRelationHasTarget =
        Namespaced_IRI.parse _namespace_name "authorityRelationHasTarget" |> NamespacedName

    /// <summary>
    /// Connects at least one Record to at least one Person, Group or
    ///             Position that is responsible for conceiving and formulating the information contained in
    ///             the Record.
    /// <see href="https://www.ica.org/standards/RiC/ontology#AuthorshipRelation"></see></summary>
    let AuthorshipRelation =
        Namespaced_IRI.parse _namespace_name "AuthorshipRelation" |> NamespacedName

    /// <summary>
    /// Connects an Authorship Relation to one of the Records involved
    ///             in the relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#authorshipRelationHasSource"></see></summary>
    let authorshipRelationHasSource =
        Namespaced_IRI.parse _namespace_name "authorshipRelationHasSource" |> NamespacedName

    /// <summary>
    /// Information inscribed at least once by any method on any
    ///             physical carrier in any persistent, recoverable form by an Agent in the course of life
    ///             or work Activity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Record"></see></summary>
    let Record = Namespaced_IRI.parse _namespace_name "Record" |> NamespacedName

    /// <summary>
    /// Connects an Authorship Relation to one of the author Person,
    ///             Group or Position.
    /// <see href="https://www.ica.org/standards/RiC/ontology#authorshipRelationHasTarget"></see></summary>
    let authorshipRelationHasTarget =
        Namespaced_IRI.parse _namespace_name "authorshipRelationHasTarget" |> NamespacedName

    /// <summary>
    /// Two or more Agents that act together as an Agent.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Group"></see></summary>
    let Group = Namespaced_IRI.parse _namespace_name "Group" |> NamespacedName
    /// <summary>
    /// A human being with a social identity or persona.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Person"></see></summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName
    /// <summary>
    /// The functional role of a Person within a Group.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Position"></see></summary>
    let Position = Namespaced_IRI.parse _namespace_name "Position" |> NamespacedName

    /// <summary>
    /// Connects at least one Record Resource or Instantiation to at
    ///             least one Agent, when the Agent is either responsible for all or some of the content of
    ///             the Record Resource, or is a contributor to the genesis or production of the
    ///             Instantiation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#CreationRelation"></see></summary>
    let CreationRelation =
        Namespaced_IRI.parse _namespace_name "CreationRelation" |> NamespacedName

    /// <summary>
    /// The extent of a Record Resource carrier
    /// <see href="https://www.ica.org/standards/RiC/ontology#CarrierExtent"></see></summary>
    let CarrierExtent =
        Namespaced_IRI.parse _namespace_name "CarrierExtent" |> NamespacedName

    /// <summary>
    /// Countable characteristics of the content of an entity expressed
    ///             as a quantity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Extent"></see></summary>
    let Extent = Namespaced_IRI.parse _namespace_name "Extent" |> NamespacedName

    /// <summary>
    /// Categorization of physical material in or on which information
    ///             is represented.
    /// <see href="https://www.ica.org/standards/RiC/ontology#CarrierType"></see></summary>
    let CarrierType =
        Namespaced_IRI.parse _namespace_name "CarrierType" |> NamespacedName

    /// <summary>
    /// Connects a Carrier Type to an Instantiation whose carrier it
    ///             categorizes.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isCarrierTypeOf"></see></summary>
    let isCarrierTypeOf =
        Namespaced_IRI.parse _namespace_name "isCarrierTypeOf" |> NamespacedName

    /// <summary>
    /// Connects at lest one Person, to at least another Person, when
    ///             the first has child the second one.
    /// <see href="https://www.ica.org/standards/RiC/ontology#ChildRelation"></see></summary>
    let ChildRelation =
        Namespaced_IRI.parse _namespace_name "ChildRelation" |> NamespacedName

    /// <summary>
    /// Connects a Child Relation to a parent Person
    /// <see href="https://www.ica.org/standards/RiC/ontology#childRelationHasSource"></see></summary>
    let childRelationHasSource =
        Namespaced_IRI.parse _namespace_name "childRelationHasSource" |> NamespacedName

    /// <summary>
    /// Connects a Child Relation to a child Person
    /// <see href="https://www.ica.org/standards/RiC/ontology#childRelationHasTarget"></see></summary>
    let childRelationHasTarget =
        Namespaced_IRI.parse _namespace_name "childRelationHasTarget" |> NamespacedName

    /// <summary>
    /// Connects at least one Person to at least another Person, when
    ///             the first has/have descendant the second one(s).
    /// <see href="https://www.ica.org/standards/RiC/ontology#DescendanceRelation"></see></summary>
    let DescendanceRelation =
        Namespaced_IRI.parse _namespace_name "DescendanceRelation" |> NamespacedName

    /// <summary>
    /// The fundamental form of communication in which a Record is
    ///             expressed and the human sense through which it is intended to be
    ///             perceived.
    /// <see href="https://www.ica.org/standards/RiC/ontology#ContentType"></see></summary>
    let ContentType =
        Namespaced_IRI.parse _namespace_name "ContentType" |> NamespacedName

    /// <summary>
    /// Connects a Content Type to a Record or Record Part whose content
    ///             it categorizes.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isContentTypeOf"></see></summary>
    let isContentTypeOf =
        Namespaced_IRI.parse _namespace_name "isContentTypeOf" |> NamespacedName

    /// <summary>
    /// Longitudinal and latitudinal information of a
    ///             Place.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Coordinates"></see></summary>
    let Coordinates =
        Namespaced_IRI.parse _namespace_name "Coordinates" |> NamespacedName

    /// <summary>
    /// Connects an instance of Coordinates to a Physical Location it
    ///             locates or located on earth, according to some reference system.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasCoordinatesOf"></see></summary>
    let isOrWasCoordinatesOf =
        Namespaced_IRI.parse _namespace_name "isOrWasCoordinatesOf" |> NamespacedName

    /// <summary>
    /// A delimitation of the physical territory of a
    ///             Place.
    /// <see href="https://www.ica.org/standards/RiC/ontology#PhysicalLocation"></see></summary>
    let PhysicalLocation =
        Namespaced_IRI.parse _namespace_name "PhysicalLocation" |> NamespacedName

    /// <summary>
    /// An organized group of persons that act together as an Agent, and
    ///             that has a recognized legal or social status.
    /// <see href="https://www.ica.org/standards/RiC/ontology#CorporateBody"></see></summary>
    let CorporateBody =
        Namespaced_IRI.parse _namespace_name "CorporateBody" |> NamespacedName

    /// <summary>
    /// Categorization of a Corporate Body.
    /// <see href="https://www.ica.org/standards/RiC/ontology#CorporateBodyType"></see></summary>
    let CorporateBodyType =
        Namespaced_IRI.parse _namespace_name "CorporateBodyType" |> NamespacedName

    /// <summary>
    /// Connects a Corporate Body Type to a Corporate Body that it
    ///             categorizes or categorized.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasCorporateBodyTypeOf"></see></summary>
    let isOrWasCorporateBodyTypeOf =
        Namespaced_IRI.parse _namespace_name "isOrWasCorporateBodyTypeOf" |> NamespacedName

    /// <summary>
    /// Connects at least two Persons, when they correspond to each
    ///             other.
    /// <see href="https://www.ica.org/standards/RiC/ontology#CorrespondenceRelation"></see></summary>
    let CorrespondenceRelation =
        Namespaced_IRI.parse _namespace_name "CorrespondenceRelation" |> NamespacedName

    /// <summary>
    /// Connects a Correspondence Relation to one of the Persons
    ///             involved
    /// <see href="https://www.ica.org/standards/RiC/ontology#correspondenceRelationConnects"></see></summary>
    let correspondenceRelationConnects =
        Namespaced_IRI.parse _namespace_name "correspondenceRelationConnects" |> NamespacedName

    /// <summary>
    /// Connects at least two Persons that directly know each other
    ///             during their existence. This relation is symmetric.
    /// <see href="https://www.ica.org/standards/RiC/ontology#KnowingRelation"></see></summary>
    let KnowingRelation =
        Namespaced_IRI.parse _namespace_name "KnowingRelation" |> NamespacedName

    /// <summary>
    /// Connects a Creation Relation to the Role Type that the creator
    ///             Agent(s) has in the creation process
    /// <see href="https://www.ica.org/standards/RiC/ontology#creationWithRole"></see></summary>
    let creationWithRole =
        Namespaced_IRI.parse _namespace_name "creationWithRole" |> NamespacedName

    /// <summary>
    /// The role an agent plays in some context (usually in some
    ///             creation relation). Not to be confused with a position (position of an agent in some
    ///             group). For example, a person who is the head of some corporate body may play the role
    ///             of annotator (of a record) in a creation relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#RoleType"></see></summary>
    let RoleType = Namespaced_IRI.parse _namespace_name "RoleType" |> NamespacedName

    /// <summary>
    /// Connects a Creation Relation to one of the created Record
    ///             Resources or Instantiations
    /// <see href="https://www.ica.org/standards/RiC/ontology#creationRelationHasSource"></see></summary>
    let creationRelationHasSource =
        Namespaced_IRI.parse _namespace_name "creationRelationHasSource" |> NamespacedName

    /// <summary>
    /// Connects a Creation Relation to one of the creator
    ///             Agents
    /// <see href="https://www.ica.org/standards/RiC/ontology#creationRelationHasTarget"></see></summary>
    let creationRelationHasTarget =
        Namespaced_IRI.parse _namespace_name "creationRelationHasTarget" |> NamespacedName

    /// <summary>
    /// Chronological information associated with an entity that
    ///             contributes to its identification and contextualization.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Date"></see></summary>
    let Date = Namespaced_IRI.parse _namespace_name "Date" |> NamespacedName
    /// <summary>
    /// Chronological information associated with an entity that
    ///             contributes to its identification and contextualization, that implies or explicitly
    ///             states a start date and end date.
    /// <see href="https://www.ica.org/standards/RiC/ontology#DateRange"></see></summary>
    let DateRange = Namespaced_IRI.parse _namespace_name "DateRange" |> NamespacedName

    /// <summary>
    /// Inverse of 'is beginning date of' object property
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasBeginningDate"></see></summary>
    let hasBeginningDate =
        Namespaced_IRI.parse _namespace_name "hasBeginningDate" |> NamespacedName

    /// <summary>
    /// Chronological information associated with an entity that
    ///             contributes to its identification and contextualization, related to a single point in
    ///             time.
    /// <see href="https://www.ica.org/standards/RiC/ontology#SingleDate"></see></summary>
    let SingleDate = Namespaced_IRI.parse _namespace_name "SingleDate" |> NamespacedName
    /// <summary>
    /// Inverse of 'is end date of' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasEndDate"></see></summary>
    let hasEndDate = Namespaced_IRI.parse _namespace_name "hasEndDate" |> NamespacedName
    /// <summary>
    /// Non-contiguous single dates or date ranges.
    /// <see href="https://www.ica.org/standards/RiC/ontology#DateSet"></see></summary>
    let DateSet = Namespaced_IRI.parse _namespace_name "DateSet" |> NamespacedName

    /// <summary>
    /// Categorization of a person according to characteristics such as
    ///             age, gender, education, place of origin, ethnic/cultural identification, religion,
    ///             etc.
    /// <see href="https://www.ica.org/standards/RiC/ontology#DemographicGroup"></see></summary>
    let DemographicGroup =
        Namespaced_IRI.parse _namespace_name "DemographicGroup" |> NamespacedName

    /// <summary>
    /// Connects an Instantiation to at least one Instantiation that is
    ///             derived from it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#DerivationRelation"></see></summary>
    let DerivationRelation =
        Namespaced_IRI.parse _namespace_name "DerivationRelation" |> NamespacedName

    /// <summary>
    /// Connects a Derivation Relation to one of the derived
    ///             Instantiations
    /// <see href="https://www.ica.org/standards/RiC/ontology#derivationRelationHasTarget"></see></summary>
    let derivationRelationHasTarget =
        Namespaced_IRI.parse _namespace_name "derivationRelationHasTarget" |> NamespacedName

    /// <summary>
    /// Connects a Derivation Relation to the Instantiation from which
    ///             one or more Instantiations is derived.
    /// <see href="https://www.ica.org/standards/RiC/ontology#derivationRelationHasSource"></see></summary>
    let derivationRelationHasSource =
        Namespaced_IRI.parse _namespace_name "derivationRelationHasSource" |> NamespacedName

    /// <summary>
    /// Connects at least two instantiations
    /// <see href="https://www.ica.org/standards/RiC/ontology#InstantiationToInstantiationRelation"></see></summary>
    let InstantiationToInstantiationRelation =
        Namespaced_IRI.parse _namespace_name "InstantiationToInstantiationRelation" |> NamespacedName

    /// <summary>
    /// Connects a Descendance Relation to one of the ancestor
    ///             Persons
    /// <see href="https://www.ica.org/standards/RiC/ontology#descendanceRelationHasSource"></see></summary>
    let descendanceRelationHasSource =
        Namespaced_IRI.parse _namespace_name "descendanceRelationHasSource" |> NamespacedName

    /// <summary>
    /// Connects a Descendance Relation to one of the descendant
    ///             Persons
    /// <see href="https://www.ica.org/standards/RiC/ontology#descendanceRelationHasTarget"></see></summary>
    let descendanceRelationHasTarget =
        Namespaced_IRI.parse _namespace_name "descendanceRelationHasTarget" |> NamespacedName

    /// <summary>
    /// Connects at least two Persons, when they have some family link,
    ///             i.e. belong to the same family.
    /// <see href="https://www.ica.org/standards/RiC/ontology#FamilyRelation"></see></summary>
    let FamilyRelation =
        Namespaced_IRI.parse _namespace_name "FamilyRelation" |> NamespacedName

    /// <summary>
    /// Categorization of the document with respect to its extrinsic and
    ///             intrinsic elements that together communicate its content, administrative and documentary
    ///             context, and authority
    /// <see href="https://www.ica.org/standards/RiC/ontology#DocumentaryFormType"></see></summary>
    let DocumentaryFormType =
        Namespaced_IRI.parse _namespace_name "DocumentaryFormType" |> NamespacedName

    /// <summary>
    /// Connects a Documentary Form Type to a Record or Record Part that
    ///             it categorizes.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isDocumentaryFormTypeOf"></see></summary>
    let isDocumentaryFormTypeOf =
        Namespaced_IRI.parse _namespace_name "isDocumentaryFormTypeOf" |> NamespacedName

    /// <summary>
    /// Part of a Record with discrete information content that
    ///             contributes to the Record's physical or intellectual completeness.
    /// <see href="https://www.ica.org/standards/RiC/ontology#RecordPart"></see></summary>
    let RecordPart = Namespaced_IRI.parse _namespace_name "RecordPart" |> NamespacedName

    /// <summary>
    /// Connects an Event to an Event Type which categorizes
    ///             it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasEventType"></see></summary>
    let hasEventType =
        Namespaced_IRI.parse _namespace_name "hasEventType" |> NamespacedName

    /// <summary>
    /// Categorization of an Event.
    /// <see href="https://www.ica.org/standards/RiC/ontology#EventType"></see></summary>
    let EventType = Namespaced_IRI.parse _namespace_name "EventType" |> NamespacedName
    /// <summary>
    /// An annotation property for recording a possible mapping to a
    ///             component in another model or ontology
    /// <see href="https://www.ica.org/standards/RiC/ontology#closeTo"></see></summary>
    let closeTo = Namespaced_IRI.parse _namespace_name "closeTo" |> NamespacedName

    /// <summary>
    /// Connects at least one Event to at least one Thing, when the
    ///             first is associated with the existence and lifecycle of the second one.
    /// <see href="https://www.ica.org/standards/RiC/ontology#EventRelation"></see></summary>
    let EventRelation =
        Namespaced_IRI.parse _namespace_name "EventRelation" |> NamespacedName

    /// <summary>
    /// Connects an Event Relation to an Event
    /// <see href="https://www.ica.org/standards/RiC/ontology#eventRelationHasSource"></see></summary>
    let eventRelationHasSource =
        Namespaced_IRI.parse _namespace_name "eventRelationHasSource" |> NamespacedName

    /// <summary>
    /// Connects an Event Relation to an associated Thing
    /// <see href="https://www.ica.org/standards/RiC/ontology#eventRelationHasTarget"></see></summary>
    let eventRelationHasTarget =
        Namespaced_IRI.parse _namespace_name "eventRelationHasTarget" |> NamespacedName

    /// <summary>
    /// Connects an Event Type to an Event that is
    ///             categorizes.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isEventTypeOf"></see></summary>
    let isEventTypeOf =
        Namespaced_IRI.parse _namespace_name "isEventTypeOf" |> NamespacedName

    /// <summary>
    /// Categorization of the extent that is being measured
    /// <see href="https://www.ica.org/standards/RiC/ontology#ExtentType"></see></summary>
    let ExtentType = Namespaced_IRI.parse _namespace_name "ExtentType" |> NamespacedName
    /// <summary>
    /// Two or more persons related by birth, or through marriage,
    ///             adoption, civil union, or other social conventions that bind them together as a socially
    ///             recognized familial group.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Family"></see></summary>
    let Family = Namespaced_IRI.parse _namespace_name "Family" |> NamespacedName

    /// <summary>
    /// Connects a Family Relation to a Person.
    /// <see href="https://www.ica.org/standards/RiC/ontology#familyRelationConnects"></see></summary>
    let familyRelationConnects =
        Namespaced_IRI.parse _namespace_name "familyRelationConnects" |> NamespacedName

    /// <summary>
    /// Categorization of a Family.
    /// <see href="https://www.ica.org/standards/RiC/ontology#FamilyType"></see></summary>
    let FamilyType = Namespaced_IRI.parse _namespace_name "FamilyType" |> NamespacedName

    /// <summary>
    /// Connects a Family Type to a Family that is
    ///             categorizes.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isFamilyTypeOf"></see></summary>
    let isFamilyTypeOf =
        Namespaced_IRI.parse _namespace_name "isFamilyTypeOf" |> NamespacedName

    /// <summary>
    /// Connects at least two Instantiations which may be considered as
    ///             equivalent.
    /// <see href="https://www.ica.org/standards/RiC/ontology#FunctionalEquivalenceRelation"></see></summary>
    let FunctionalEquivalenceRelation =
        Namespaced_IRI.parse _namespace_name "FunctionalEquivalenceRelation" |> NamespacedName

    /// <summary>
    /// Connects a Functional Equivalence Relation to one of the
    ///             functionally equivalent Instantiations.
    /// <see href="https://www.ica.org/standards/RiC/ontology#functionalEquivalenceRelationConnects"></see></summary>
    let functionalEquivalenceRelationConnects =
        Namespaced_IRI.parse _namespace_name "functionalEquivalenceRelationConnects" |> NamespacedName

    /// <summary>
    /// A process or system created by a Person or Group that performs
    ///             an Activity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Mechanism"></see></summary>
    let Mechanism = Namespaced_IRI.parse _namespace_name "Mechanism" |> NamespacedName

    /// <summary>
    /// Connects a Group and at least another Group, when the first one
    ///             as the second one(s) among its subdivisions.
    /// <see href="https://www.ica.org/standards/RiC/ontology#GroupSubdivisionRelation"></see></summary>
    let GroupSubdivisionRelation =
        Namespaced_IRI.parse _namespace_name "GroupSubdivisionRelation" |> NamespacedName

    /// <summary>
    /// Connects a Group Subdivision Relation to one of the Groups that
    ///             is a subdivision
    /// <see href="https://www.ica.org/standards/RiC/ontology#groupSubdivisionRelationHasTarget"></see></summary>
    let groupSubdivisionRelationHasTarget =
        Namespaced_IRI.parse _namespace_name "groupSubdivisionRelationHasTarget" |> NamespacedName

    /// <summary>
    /// Connects a Group Subdivision Relation to the Group that has
    ///             subdivisions
    /// <see href="https://www.ica.org/standards/RiC/ontology#groupSubdivisionRelationHasSource"></see></summary>
    let groupSubdivisionRelationHasSource =
        Namespaced_IRI.parse _namespace_name "groupSubdivisionRelationHasSource" |> NamespacedName

    /// <summary>
    /// Connects a Thing to at least one constitutive or component part
    ///             of that Thing.
    /// <see href="https://www.ica.org/standards/RiC/ontology#WholePartRelation"></see></summary>
    let WholePartRelation =
        Namespaced_IRI.parse _namespace_name "WholePartRelation" |> NamespacedName

    /// <summary>
    /// A word, number, letter, symbol, or any combination of these used
    ///             to uniquely identify or reference an individual instance of an entity within a specific
    ///             information domain.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Identifier"></see></summary>
    let Identifier = Namespaced_IRI.parse _namespace_name "Identifier" |> NamespacedName

    /// <summary>
    /// Connects an Identifier and an Identifier Type that categorizes
    ///             it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasIdentifierType"></see></summary>
    let hasIdentifierType =
        Namespaced_IRI.parse _namespace_name "hasIdentifierType" |> NamespacedName

    /// <summary>
    /// Categorization of an Identifier.
    /// <see href="https://www.ica.org/standards/RiC/ontology#IdentifierType"></see></summary>
    let IdentifierType =
        Namespaced_IRI.parse _namespace_name "IdentifierType" |> NamespacedName

    /// <summary>
    /// Connects an Identifier Type and an Identifier that it
    ///             categorizes.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isIdentifierTypeOf"></see></summary>
    let isIdentifierTypeOf =
        Namespaced_IRI.parse _namespace_name "isIdentifierTypeOf" |> NamespacedName

    /// <summary>
    /// Connects an Instantiation to a Carrier Type which categorizes
    ///             its carrier.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasCarrierType"></see></summary>
    let hasCarrierType =
        Namespaced_IRI.parse _namespace_name "hasCarrierType" |> NamespacedName

    /// <summary>
    /// Connects an Instantiation to a Representation Type that
    ///             categorizes its representation type.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasRepresentationType"></see></summary>
    let hasRepresentationType =
        Namespaced_IRI.parse _namespace_name "hasRepresentationType" |> NamespacedName

    /// <summary>
    /// Categorization of the method of recording the content type of a
    ///             Record Resource.
    /// <see href="https://www.ica.org/standards/RiC/ontology#RepresentationType"></see></summary>
    let RepresentationType =
        Namespaced_IRI.parse _namespace_name "RepresentationType" |> NamespacedName

    /// <summary>
    /// Connects an Instantiation to a Production Technique Type that
    ///             categorizes its production technique.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasProductionTechniqueType"></see></summary>
    let hasProductionTechniqueType =
        Namespaced_IRI.parse _namespace_name "hasProductionTechniqueType" |> NamespacedName

    /// <summary>
    /// Categorization of the method used in the representation of
    ///             information on the Instantiation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#ProductionTechniqueType"></see></summary>
    let ProductionTechniqueType =
        Namespaced_IRI.parse _namespace_name "ProductionTechniqueType" |> NamespacedName

    /// <summary>
    /// The extent of an Instantiation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#InstantiationExtent"></see></summary>
    let InstantiationExtent =
        Namespaced_IRI.parse _namespace_name "InstantiationExtent" |> NamespacedName

    /// <summary>
    /// Connects an Instantiation to Instantiation Relation to one of
    ///             the related Instantiations.
    /// <see href="https://www.ica.org/standards/RiC/ontology#instantiationToInstantiationRelationConnects"></see></summary>
    let instantiationToInstantiationRelationConnects =
        Namespaced_IRI.parse _namespace_name "instantiationToInstantiationRelationConnects" |> NamespacedName

    /// <summary>
    /// Connects at least one Agent and one Record Resource or
    ///             Instantiation on which the Agent has some intellectual property rights.
    /// <see href="https://www.ica.org/standards/RiC/ontology#IntellectualPropertyRightsRelation"></see></summary>
    let IntellectualPropertyRightsRelation =
        Namespaced_IRI.parse _namespace_name "IntellectualPropertyRightsRelation" |> NamespacedName

    /// <summary>
    /// Connects an IntellectualPropertyRightsRelation to one of the
    ///             Group, Person or Position that holds the rights.
    /// <see href="https://www.ica.org/standards/RiC/ontology#intellectualPropertyRightsRelationHasSource"></see></summary>
    let intellectualPropertyRightsRelationHasSource =
        Namespaced_IRI.parse _namespace_name "intellectualPropertyRightsRelationHasSource" |> NamespacedName

    /// <summary>
    /// Connects an IintellectualPropertyRightsRelation to one of the
    ///             Record Resource or Instantiation on which the rights are held.
    /// <see href="https://www.ica.org/standards/RiC/ontology#intellectualPropertyRightsRelationHasTarget"></see></summary>
    let intellectualPropertyRightsRelationHasTarget =
        Namespaced_IRI.parse _namespace_name "intellectualPropertyRightsRelationHasTarget" |> NamespacedName

    /// <summary>
    /// Connects at least one Person to at least another one, when the
    ///             first one has some knowledge of the second one through time or space.
    /// <see href="https://www.ica.org/standards/RiC/ontology#KnowingOfRelation"></see></summary>
    let KnowingOfRelation =
        Namespaced_IRI.parse _namespace_name "KnowingOfRelation" |> NamespacedName

    /// <summary>
    /// Connects a Knowing Of Relation to a 'knowing of' Person (a
    ///             Person who has some knowledge of another one.)
    /// <see href="https://www.ica.org/standards/RiC/ontology#knowingOfRelationHasSource"></see></summary>
    let knowingOfRelationHasSource =
        Namespaced_IRI.parse _namespace_name "knowingOfRelationHasSource" |> NamespacedName

    /// <summary>
    /// Connects a Knowing Of Relation to a 'known by' Person (a Person
    ///             on which another one has some has some knowledge.)
    /// <see href="https://www.ica.org/standards/RiC/ontology#knowingOfRelationHasTarget"></see></summary>
    let knowingOfRelationHasTarget =
        Namespaced_IRI.parse _namespace_name "knowingOfRelationHasTarget" |> NamespacedName

    /// <summary>
    /// Connects Knowing Relation to any known Person
    ///             involved.
    /// <see href="https://www.ica.org/standards/RiC/ontology#knowingRelationConnects"></see></summary>
    let knowingRelationConnects =
        Namespaced_IRI.parse _namespace_name "knowingRelationConnects" |> NamespacedName

    /// <summary>
    /// A spoken or written human language represented in the Record or
    ///             Record Part, or used by the Agent.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Language"></see></summary>
    let Language = Namespaced_IRI.parse _namespace_name "Language" |> NamespacedName

    /// <summary>
    /// Connects at least one Person and at least one Group, when the
    ///             first one leads the second one.
    /// <see href="https://www.ica.org/standards/RiC/ontology#LeadershipRelation"></see></summary>
    let LeadershipRelation =
        Namespaced_IRI.parse _namespace_name "LeadershipRelation" |> NamespacedName

    /// <summary>
    /// Connects a Leadership Relation to a Person who is involved as a
    ///             leader.
    /// <see href="https://www.ica.org/standards/RiC/ontology#leadershipRelationHasSource"></see></summary>
    let leadershipRelationHasSource =
        Namespaced_IRI.parse _namespace_name "leadershipRelationHasSource" |> NamespacedName

    /// <summary>
    /// Connects a Leadership Relation to a lead Group.
    /// <see href="https://www.ica.org/standards/RiC/ontology#leadershipRelationHasTarget"></see></summary>
    let leadershipRelationHasTarget =
        Namespaced_IRI.parse _namespace_name "leadershipRelationHasTarget" |> NamespacedName

    /// <summary>
    /// Connects a Leadership Relation to the Position occupied by the
    ///             leading Person.
    /// <see href="https://www.ica.org/standards/RiC/ontology#leadershipWithPosition"></see></summary>
    let leadershipWithPosition =
        Namespaced_IRI.parse _namespace_name "leadershipWithPosition" |> NamespacedName

    /// <summary>
    /// A status defined by law.
    /// <see href="https://www.ica.org/standards/RiC/ontology#LegalStatus"></see></summary>
    let LegalStatus =
        Namespaced_IRI.parse _namespace_name "LegalStatus" |> NamespacedName

    /// <summary>
    /// Connects at least one Agent, and at least one Record Resource or
    ///             Instantiation that the Agent manages.
    /// <see href="https://www.ica.org/standards/RiC/ontology#ManagementRelation"></see></summary>
    let ManagementRelation =
        Namespaced_IRI.parse _namespace_name "ManagementRelation" |> NamespacedName

    /// <summary>
    /// Connects a Management Relation to an Agent who is involved as a
    ///             manager.
    /// <see href="https://www.ica.org/standards/RiC/ontology#managementRelationHasSource"></see></summary>
    let managementRelationHasSource =
        Namespaced_IRI.parse _namespace_name "managementRelationHasSource" |> NamespacedName

    /// <summary>
    /// Connects a Management Relation to a Record Resource or
    ///             Instantiation that is involved as a managed thing.
    /// <see href="https://www.ica.org/standards/RiC/ontology#managementRelationHasTarget"></see></summary>
    let managementRelationHasTarget =
        Namespaced_IRI.parse _namespace_name "managementRelationHasTarget" |> NamespacedName

    /// <summary>
    /// Delegation of authority by an Agent to another Agent to perform
    ///             an Activity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Mandate"></see></summary>
    let Mandate = Namespaced_IRI.parse _namespace_name "Mandate" |> NamespacedName
    /// <summary>
    /// Connects a Mandate to the Agent that the Mandate gives the
    ///             authority or competencies to act.
    /// <see href="https://www.ica.org/standards/RiC/ontology#authorizes"></see></summary>
    let authorizes = Namespaced_IRI.parse _namespace_name "authorizes" |> NamespacedName
    /// <summary>
    /// Conditions that govern the existence or authority of an Agent or the performance of an Activity, or that contribute to the distinct characteristics of things created or managed by an Agent.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Rule"></see></summary>
    let Rule = Namespaced_IRI.parse _namespace_name "Rule" |> NamespacedName

    /// <summary>
    /// Connects at least one Mandate, and at least one Agent, when the
    ///             first gives the second one the authority or competencies to act. May also involve one to
    ///             many Activities that the Mandate(s) assign(s) to the Agent(s).
    /// <see href="https://www.ica.org/standards/RiC/ontology#MandateRelation"></see></summary>
    let MandateRelation =
        Namespaced_IRI.parse _namespace_name "MandateRelation" |> NamespacedName

    /// <summary>
    /// Connects a Mandate Relation to an Agent who is given the
    ///             authority or competencies to act.
    /// <see href="https://www.ica.org/standards/RiC/ontology#mandateRelationHasTarget"></see></summary>
    let mandateRelationHasTarget =
        Namespaced_IRI.parse _namespace_name "mandateRelationHasTarget" |> NamespacedName

    /// <summary>
    /// Connects a Mandate Relation to an Agent that assigns the
    ///             Mandate.
    /// <see href="https://www.ica.org/standards/RiC/ontology#authorizingAgent"></see></summary>
    let authorizingAgent =
        Namespaced_IRI.parse _namespace_name "authorizingAgent" |> NamespacedName

    /// <summary>
    /// Connects at least one Rule to at least one Thing, when it is
    ///             associated with existence and lifecycle of the Thing.
    /// <see href="https://www.ica.org/standards/RiC/ontology#RuleRelation"></see></summary>
    let RuleRelation =
        Namespaced_IRI.parse _namespace_name "RuleRelation" |> NamespacedName

    /// <summary>
    /// Connects a Mandate Relation to a Mandate.
    /// <see href="https://www.ica.org/standards/RiC/ontology#mandateRelationHasSource"></see></summary>
    let mandateRelationHasSource =
        Namespaced_IRI.parse _namespace_name "mandateRelationHasSource" |> NamespacedName

    /// <summary>
    /// Connects a Group and at least one Person, when the first one has
    ///             the second one(s) among its members.
    /// <see href="https://www.ica.org/standards/RiC/ontology#MembershipRelation"></see></summary>
    let MembershipRelation =
        Namespaced_IRI.parse _namespace_name "MembershipRelation" |> NamespacedName

    /// <summary>
    /// Connects a Membership Relation to a Person who is involved as a
    ///             member.
    /// <see href="https://www.ica.org/standards/RiC/ontology#membershipRelationHasTarget"></see></summary>
    let membershipRelationHasTarget =
        Namespaced_IRI.parse _namespace_name "membershipRelationHasTarget" |> NamespacedName

    /// <summary>
    /// Connects a Membership Relation to the Group that has
    ///             member(s).
    /// <see href="https://www.ica.org/standards/RiC/ontology#membershipRelationHasSource"></see></summary>
    let membershipRelationHasSource =
        Namespaced_IRI.parse _namespace_name "membershipRelationHasSource" |> NamespacedName

    /// <summary>
    /// Connects a Membership Relation to the Position occupied by the
    ///             member Person(s).
    /// <see href="https://www.ica.org/standards/RiC/ontology#membershipWithPosition"></see></summary>
    let membershipWithPosition =
        Namespaced_IRI.parse _namespace_name "membershipWithPosition" |> NamespacedName

    /// <summary>
    /// Connects an Instantiation and at least another Instantiation,
    ///             when the first is migrated into the second one(s).
    /// <see href="https://www.ica.org/standards/RiC/ontology#MigrationRelation"></see></summary>
    let MigrationRelation =
        Namespaced_IRI.parse _namespace_name "MigrationRelation" |> NamespacedName

    /// <summary>
    /// Connects a Migration Relation to a resulting
    ///             Instantiation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#migrationRelationHasTarget"></see></summary>
    let migrationRelationHasTarget =
        Namespaced_IRI.parse _namespace_name "migrationRelationHasTarget" |> NamespacedName

    /// <summary>
    /// Connects a Migration Relation to the migrated
    ///             Instantiation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#migrationRelationHasSource"></see></summary>
    let migrationRelationHasSource =
        Namespaced_IRI.parse _namespace_name "migrationRelationHasSource" |> NamespacedName

    /// <summary>
    /// Categorization of a profession, trade, or craft pursued by a
    ///             person in fulfilment of an Activity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#OccupationType"></see></summary>
    let OccupationType =
        Namespaced_IRI.parse _namespace_name "OccupationType" |> NamespacedName

    /// <summary>
    /// Connects an Occupation Type to a Person whose occupation is or
    ///             was categorized by it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasOccupationTypeOf"></see></summary>
    let isOrWasOccupationTypeOf =
        Namespaced_IRI.parse _namespace_name "isOrWasOccupationTypeOf" |> NamespacedName

    /// <summary>
    /// Connects at least one Group, Person or Position, and at least a
    ///             Thing that these Agent(s) own(s).
    /// <see href="https://www.ica.org/standards/RiC/ontology#OwnershipRelation"></see></summary>
    let OwnershipRelation =
        Namespaced_IRI.parse _namespace_name "OwnershipRelation" |> NamespacedName

    /// <summary>
    /// Connects an Ownership Relation to a Person, Group or Position
    ///             that is involved as an owner.
    /// <see href="https://www.ica.org/standards/RiC/ontology#ownershipRelationHasSource"></see></summary>
    let ownershipRelationHasSource =
        Namespaced_IRI.parse _namespace_name "ownershipRelationHasSource" |> NamespacedName

    /// <summary>
    /// Connects an Ownership Relation to a Thing that is
    ///             owned.
    /// <see href="https://www.ica.org/standards/RiC/ontology#ownershipRelationHasTarget"></see></summary>
    let ownershipRelationHasTarget =
        Namespaced_IRI.parse _namespace_name "ownershipRelationHasTarget" |> NamespacedName

    /// <summary>
    /// Connects at least one Activity to at least one Agent, when the
    ///             first is performed by the second one(s).
    /// <see href="https://www.ica.org/standards/RiC/ontology#PerformanceRelation"></see></summary>
    let PerformanceRelation =
        Namespaced_IRI.parse _namespace_name "PerformanceRelation" |> NamespacedName

    /// <summary>
    /// Connects a Performance Relation to a performed
    ///             Activity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#performanceRelationHasSource"></see></summary>
    let performanceRelationHasSource =
        Namespaced_IRI.parse _namespace_name "performanceRelationHasSource" |> NamespacedName

    /// <summary>
    /// Connects a Performance Relation to a performing
    ///             Agent.
    /// <see href="https://www.ica.org/standards/RiC/ontology#performanceRelationHasTarget"></see></summary>
    let performanceRelationHasTarget =
        Namespaced_IRI.parse _namespace_name "performanceRelationHasTarget" |> NamespacedName

    /// <summary>
    /// Connects a Person to an Occupation Type that categorized or
    ///             categorizes his/her occupation (profession, trade or craft).
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadOccupationOfType"></see></summary>
    let hasOrHadOccupationOfType =
        Namespaced_IRI.parse _namespace_name "hasOrHadOccupationOfType" |> NamespacedName

    /// <summary>
    /// Connects a Physical Location to its past or present coordinates
    ///             in a reference system.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadCoordinates"></see></summary>
    let hasOrHadCoordinates =
        Namespaced_IRI.parse _namespace_name "hasOrHadCoordinates" |> NamespacedName

    /// <summary>
    /// Connects a Physical Location to a Place, when it is or was its
    ///             location.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasPhysicalLocationOf"></see></summary>
    let isOrWasPhysicalLocationOf =
        Namespaced_IRI.parse _namespace_name "isOrWasPhysicalLocationOf" |> NamespacedName

    /// <summary>
    /// Bounded, named geographic area or region.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Place"></see></summary>
    let Place = Namespaced_IRI.parse _namespace_name "Place" |> NamespacedName

    /// <summary>
    /// Connects a Place to one of its past or present Physical
    ///             Location.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadPhysicalLocation"></see></summary>
    let hasOrHadPhysicalLocation =
        Namespaced_IRI.parse _namespace_name "hasOrHadPhysicalLocation" |> NamespacedName

    /// <summary>
    /// A label, title or term designating a Place in order to make it
    ///             distinguishable from other similar entities.
    /// <see href="https://www.ica.org/standards/RiC/ontology#PlaceName"></see></summary>
    let PlaceName = Namespaced_IRI.parse _namespace_name "PlaceName" |> NamespacedName

    /// <summary>
    /// Connects a Place and at least one Thing, when the first is
    ///             associated with the existence and lifecycle of the second one.
    /// <see href="https://www.ica.org/standards/RiC/ontology#PlaceRelation"></see></summary>
    let PlaceRelation =
        Namespaced_IRI.parse _namespace_name "PlaceRelation" |> NamespacedName

    /// <summary>
    /// Connects a Place Relation to a Thing that is associated to the
    ///             Place.
    /// <see href="https://www.ica.org/standards/RiC/ontology#placeRelationHasTarget"></see></summary>
    let placeRelationHasTarget =
        Namespaced_IRI.parse _namespace_name "placeRelationHasTarget" |> NamespacedName

    /// <summary>
    /// Connects a Place Relation to the Place concerned.
    /// <see href="https://www.ica.org/standards/RiC/ontology#placeRelationHasSource"></see></summary>
    let placeRelationHasSource =
        Namespaced_IRI.parse _namespace_name "placeRelationHasSource" |> NamespacedName

    /// <summary>
    /// Categorization of a Place.
    /// <see href="https://www.ica.org/standards/RiC/ontology#PlaceType"></see></summary>
    let PlaceType = Namespaced_IRI.parse _namespace_name "PlaceType" |> NamespacedName

    /// <summary>
    /// Connects a Place Type to a Place that is or was categorized by
    ///             it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasPlaceTypeOf"></see></summary>
    let isOrWasPlaceTypeOf =
        Namespaced_IRI.parse _namespace_name "isOrWasPlaceTypeOf" |> NamespacedName

    /// <summary>
    /// Connects at least one Person, and at least one Position that the
    ///             Person occupies.
    /// <see href="https://www.ica.org/standards/RiC/ontology#PositionHoldingRelation"></see></summary>
    let PositionHoldingRelation =
        Namespaced_IRI.parse _namespace_name "PositionHoldingRelation" |> NamespacedName

    /// <summary>
    /// Connects a Position Holding Relation to a Person (who occupies a
    ///             Position).
    /// <see href="https://www.ica.org/standards/RiC/ontology#positionHoldingRelationHasSource"></see></summary>
    let positionHoldingRelationHasSource =
        Namespaced_IRI.parse _namespace_name "positionHoldingRelationHasSource" |> NamespacedName

    /// <summary>
    /// Connects a Position Holding Relation to a Position (that is
    ///             occupied).
    /// <see href="https://www.ica.org/standards/RiC/ontology#positionHoldingRelationHasTarget"></see></summary>
    let positionHoldingRelationHasTarget =
        Namespaced_IRI.parse _namespace_name "positionHoldingRelationHasTarget" |> NamespacedName

    /// <summary>
    /// Connects at least one Position, and a Group, when the first
    ///             one(s) exist(s) in/is defined within the second one.
    /// <see href="https://www.ica.org/standards/RiC/ontology#PositionToGroupRelation"></see></summary>
    let PositionToGroupRelation =
        Namespaced_IRI.parse _namespace_name "PositionToGroupRelation" |> NamespacedName

    /// <summary>
    /// Connects a Position to Group Relation to a Position (that exists
    ///             in a Group).
    /// <see href="https://www.ica.org/standards/RiC/ontology#positionToGroupRelationHasSource"></see></summary>
    let positionToGroupRelationHasSource =
        Namespaced_IRI.parse _namespace_name "positionToGroupRelationHasSource" |> NamespacedName

    /// <summary>
    /// Connects a Position to Group Relation to a Group (in which a
    ///             Position exists).
    /// <see href="https://www.ica.org/standards/RiC/ontology#positionToGroupRelationHasTarget"></see></summary>
    let positionToGroupRelationHasTarget =
        Namespaced_IRI.parse _namespace_name "positionToGroupRelationHasTarget" |> NamespacedName

    /// <summary>
    /// Connects a Production Technique Type to an Instantiation whose
    ///             production technique is categorized by it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isProductionTechniqueTypeOf"></see></summary>
    let isProductionTechniqueTypeOf =
        Namespaced_IRI.parse _namespace_name "isProductionTechniqueTypeOf" |> NamespacedName

    /// <summary>
    /// Connects a Provenance Relation to a Record Resource or
    ///             Instantiation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#provenanceRelationHasSource"></see></summary>
    let provenanceRelationHasSource =
        Namespaced_IRI.parse _namespace_name "provenanceRelationHasSource" |> NamespacedName

    /// <summary>
    /// Connects a Provenance Relation to an Agent or
    ///             Activity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#provenanceRelationHasTarget"></see></summary>
    let provenanceRelationHasTarget =
        Namespaced_IRI.parse _namespace_name "provenanceRelationHasTarget" |> NamespacedName

    /// <summary>
    /// A Proxy represents (stands for) a Record Resource as it exists
    ///             in a specific Record Set.
    /// <see href="https://www.ica.org/standards/RiC/ontology#Proxy"></see></summary>
    let Proxy = Namespaced_IRI.parse _namespace_name "Proxy" |> NamespacedName
    /// <summary>
    /// Connects a Proxy to the Record Resource it stands for in the
    ///             specific context of a Record Set.
    /// <see href="https://www.ica.org/standards/RiC/ontology#proxyFor"></see></summary>
    let proxyFor = Namespaced_IRI.parse _namespace_name "proxyFor" |> NamespacedName
    /// <summary>
    /// Connects a Proxy to the Record Set in which it stands for
    ///             (represents) another Record Resource.
    /// <see href="https://www.ica.org/standards/RiC/ontology#proxyIn"></see></summary>
    let proxyIn = Namespaced_IRI.parse _namespace_name "proxyIn" |> NamespacedName
    /// <summary>
    /// One or more records that are associated by categorization and/or
    ///             physical aggregation by the creator or other Agent.
    /// <see href="https://www.ica.org/standards/RiC/ontology#RecordSet"></see></summary>
    let RecordSet = Namespaced_IRI.parse _namespace_name "RecordSet" |> NamespacedName

    /// <summary>
    /// Connects a Record Resource to one of its
    ///             Instantiations.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasInstantiation"></see></summary>
    let hasInstantiation =
        Namespaced_IRI.parse _namespace_name "hasInstantiation" |> NamespacedName

    /// <summary>
    /// The extent of the content of a Record Resource.
    /// <see href="https://www.ica.org/standards/RiC/ontology#RecordResourceExtent"></see></summary>
    let RecordResourceExtent =
        Namespaced_IRI.parse _namespace_name "RecordResourceExtent" |> NamespacedName

    /// <summary>
    /// Connects two to more Record Resources when there is a genetic
    ///             relation between them. Genetic in this sense is as defined by diplomatics, i.e. the
    ///             process by which a Record Resource is developed.
    /// <see href="https://www.ica.org/standards/RiC/ontology#RecordResourceGeneticRelation"></see></summary>
    let RecordResourceGeneticRelation =
        Namespaced_IRI.parse _namespace_name "RecordResourceGeneticRelation" |> NamespacedName

    /// <summary>
    /// Connects a Record Resource Genetic Relation to one of the
    ///             associated Record Resources.
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordResourceGeneticRelationConnects"></see></summary>
    let recordResourceGeneticRelationConnects =
        Namespaced_IRI.parse _namespace_name "recordResourceGeneticRelationConnects" |> NamespacedName

    /// <summary>
    /// Connects at least two Record Resources.
    /// <see href="https://www.ica.org/standards/RiC/ontology#RecordResourceToRecordResourceRelation"></see></summary>
    let RecordResourceToRecordResourceRelation =
        Namespaced_IRI.parse _namespace_name "RecordResourceToRecordResourceRelation" |> NamespacedName

    /// <summary>
    /// Connects at least one Agent, and one or more Record Resource or
    ///             Instantiation that the Agent holds.
    /// <see href="https://www.ica.org/standards/RiC/ontology#RecordResourceHoldingRelation"></see></summary>
    let RecordResourceHoldingRelation =
        Namespaced_IRI.parse _namespace_name "RecordResourceHoldingRelation" |> NamespacedName

    /// <summary>
    /// Connects a Record Resource Holding Relation to an Agent (as the
    ///             holder of a Record Resource or Instantiation).
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordResourceHoldingRelationHasSource"></see></summary>
    let recordResourceHoldingRelationHasSource =
        Namespaced_IRI.parse _namespace_name "recordResourceHoldingRelationHasSource" |> NamespacedName

    /// <summary>
    /// Connects a Record Resource Holding Relation to a Record Resource
    ///             or Instantiation (that is held by an Agent).
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordResourceHoldingRelationHasTarget"></see></summary>
    let recordResourceHoldingRelationHasTarget =
        Namespaced_IRI.parse _namespace_name "recordResourceHoldingRelationHasTarget" |> NamespacedName

    /// <summary>
    /// Connects a Record Resource to one or more Instantiations that
    ///             instantiate it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#RecordResourceToInstantiationRelation"></see></summary>
    let RecordResourceToInstantiationRelation =
        Namespaced_IRI.parse _namespace_name "RecordResourceToInstantiationRelation" |> NamespacedName

    /// <summary>
    /// Connects a Record Resource To Instantiation Relation to an
    ///             Instantiation of the involved Record Resource.
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordResourceToInstantiationRelationHasTarget"></see></summary>
    let recordResourceToInstantiationRelationHasTarget =
        Namespaced_IRI.parse _namespace_name "recordResourceToInstantiationRelationHasTarget" |> NamespacedName

    /// <summary>
    /// Connects a Record Resource To Instantiation Relation to the
    ///             Record Resource (that was instantiated).
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordResourceToInstantiationRelationHasSource"></see></summary>
    let recordResourceToInstantiationRelationHasSource =
        Namespaced_IRI.parse _namespace_name "recordResourceToInstantiationRelationHasSource" |> NamespacedName

    /// <summary>
    /// Connects a Record Resource relation to one of the related Record
    ///             Resources.
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordResourceRelationConnects"></see></summary>
    let recordResourceRelationConnects =
        Namespaced_IRI.parse _namespace_name "recordResourceRelationConnects" |> NamespacedName

    /// <summary>
    /// Connects a Record Set to a Record Set Type that categorizes
    ///             it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasRecordSetType"></see></summary>
    let hasRecordSetType =
        Namespaced_IRI.parse _namespace_name "hasRecordSetType" |> NamespacedName

    /// <summary>
    /// A broad categorization of the type of Record Set.
    /// <see href="https://www.ica.org/standards/RiC/ontology#RecordSetType"></see></summary>
    let RecordSetType =
        Namespaced_IRI.parse _namespace_name "RecordSetType" |> NamespacedName

    /// <summary>
    /// Connects a Record Set Type to a Record Set that it
    ///             categorizes.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isRecordSetTypeOf"></see></summary>
    let isRecordSetTypeOf =
        Namespaced_IRI.parse _namespace_name "isRecordSetTypeOf" |> NamespacedName

    /// <summary>
    /// Categorization of the production or reproduction status of a
    ///             Record or Record Part.
    /// <see href="https://www.ica.org/standards/RiC/ontology#RecordState"></see></summary>
    let RecordState =
        Namespaced_IRI.parse _namespace_name "RecordState" |> NamespacedName

    /// <summary>
    /// Connects a Representation Type to an Instantiation that it
    ///             categorizes.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isRepresentationTypeOf"></see></summary>
    let isRepresentationTypeOf =
        Namespaced_IRI.parse _namespace_name "isRepresentationTypeOf" |> NamespacedName

    /// <summary>
    /// Connects a Rule to a Rule Type that categorized or categorizes
    ///             it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadRuleType"></see></summary>
    let hasOrHadRuleType =
        Namespaced_IRI.parse _namespace_name "hasOrHadRuleType" |> NamespacedName

    /// <summary>
    /// Categorization of a Rule.
    /// <see href="https://www.ica.org/standards/RiC/ontology#RuleType"></see></summary>
    let RuleType = Namespaced_IRI.parse _namespace_name "RuleType" |> NamespacedName

    /// <summary>
    /// Connects a Rule Relation to a Rule.
    /// <see href="https://www.ica.org/standards/RiC/ontology#ruleRelationHasSource"></see></summary>
    let ruleRelationHasSource =
        Namespaced_IRI.parse _namespace_name "ruleRelationHasSource" |> NamespacedName

    /// <summary>
    /// Connects a Rule Relation to a Thing (that is associated to a
    ///             Rule).
    /// <see href="https://www.ica.org/standards/RiC/ontology#ruleRelationHasTarget"></see></summary>
    let ruleRelationHasTarget =
        Namespaced_IRI.parse _namespace_name "ruleRelationHasTarget" |> NamespacedName

    /// <summary>
    /// connects a Rule Type to a Rule that it categorized or
    ///             categorizes.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasRuleTypeOf"></see></summary>
    let isOrWasRuleTypeOf =
        Namespaced_IRI.parse _namespace_name "isOrWasRuleTypeOf" |> NamespacedName

    /// <summary>
    /// Connects at least one Thing to at least one Thing that follows
    ///             it in some sequence.
    /// <see href="https://www.ica.org/standards/RiC/ontology#SequentialRelation"></see></summary>
    let SequentialRelation =
        Namespaced_IRI.parse _namespace_name "SequentialRelation" |> NamespacedName

    /// <summary>
    /// Connects a Sequential Relation to a Thing that precedes other
    ///             Thing(s) in the sequence.
    /// <see href="https://www.ica.org/standards/RiC/ontology#sequentialRelationHasSource"></see></summary>
    let sequentialRelationHasSource =
        Namespaced_IRI.parse _namespace_name "sequentialRelationHasSource" |> NamespacedName

    /// <summary>
    /// Connects a Sequential Relation to a Thing that follows other
    ///             Thing(s) in the sequence.
    /// <see href="https://www.ica.org/standards/RiC/ontology#sequentialRelationHasTarget"></see></summary>
    let sequentialRelationHasTarget =
        Namespaced_IRI.parse _namespace_name "sequentialRelationHasTarget" |> NamespacedName

    /// <summary>
    /// Connects at least two Persons, when they are
    ///             siblings.
    /// <see href="https://www.ica.org/standards/RiC/ontology#SiblingRelation"></see></summary>
    let SiblingRelation =
        Namespaced_IRI.parse _namespace_name "SiblingRelation" |> NamespacedName

    /// <summary>
    /// Connects a Sibling Relation to one of the siblings
    ///             involved.
    /// <see href="https://www.ica.org/standards/RiC/ontology#siblingRelationConnects"></see></summary>
    let siblingRelationConnects =
        Namespaced_IRI.parse _namespace_name "siblingRelationConnects" |> NamespacedName

    /// <summary>
    /// Connects at least two Persons, when they are
    ///             spouses.
    /// <see href="https://www.ica.org/standards/RiC/ontology#SpouseRelation"></see></summary>
    let SpouseRelation =
        Namespaced_IRI.parse _namespace_name "SpouseRelation" |> NamespacedName

    /// <summary>
    /// Connects a Sibling Relation to one of the spouses
    ///             involved.
    /// <see href="https://www.ica.org/standards/RiC/ontology#spouseRelationConnects"></see></summary>
    let spouseRelationConnects =
        Namespaced_IRI.parse _namespace_name "spouseRelationConnects" |> NamespacedName

    /// <summary>
    /// Connects at least one Person to at least another Person, who is
    ///             their student.
    /// <see href="https://www.ica.org/standards/RiC/ontology#TeachingRelation"></see></summary>
    let TeachingRelation =
        Namespaced_IRI.parse _namespace_name "TeachingRelation" |> NamespacedName

    /// <summary>
    /// Connects a Teaching Relation to a Person (who is a
    ///             teacher).
    /// <see href="https://www.ica.org/standards/RiC/ontology#teachingRelationHasSource"></see></summary>
    let teachingRelationHasSource =
        Namespaced_IRI.parse _namespace_name "teachingRelationHasSource" |> NamespacedName

    /// <summary>
    /// Connects a Teaching Relation to a Person (who is a
    ///             student).
    /// <see href="https://www.ica.org/standards/RiC/ontology#teachingRelationHasTarget"></see></summary>
    let teachingRelationHasTarget =
        Namespaced_IRI.parse _namespace_name "teachingRelationHasTarget" |> NamespacedName

    /// <summary>
    /// Connects a Temporal Relation to a Thing that precedes other
    ///             Thing(s) in time.
    /// <see href="https://www.ica.org/standards/RiC/ontology#temporalRelationHasSource"></see></summary>
    let temporalRelationHasSource =
        Namespaced_IRI.parse _namespace_name "temporalRelationHasSource" |> NamespacedName

    /// <summary>
    /// Connects a Temporal Relation to a Thing that follows other
    ///             Thing(s) in time.
    /// <see href="https://www.ica.org/standards/RiC/ontology#temporalRelationHasTarget"></see></summary>
    let temporalRelationHasTarget =
        Namespaced_IRI.parse _namespace_name "temporalRelationHasTarget" |> NamespacedName

    /// <summary>
    /// A name that is used for a Record Resource or a
    ///             Rule
    /// <see href="https://www.ica.org/standards/RiC/ontology#Title"></see></summary>
    let Title = Namespaced_IRI.parse _namespace_name "Title" |> NamespacedName

    /// <summary>
    /// Connects a category (a Type) and at least one Thing that belongs
    ///             to this category.
    /// <see href="https://www.ica.org/standards/RiC/ontology#TypeRelation"></see></summary>
    let TypeRelation =
        Namespaced_IRI.parse _namespace_name "TypeRelation" |> NamespacedName

    /// <summary>
    /// Connects a Type Relation to a Thing (that is categorized by the
    ///             involved Type).
    /// <see href="https://www.ica.org/standards/RiC/ontology#typeRelationHasTarget"></see></summary>
    let typeRelationHasTarget =
        Namespaced_IRI.parse _namespace_name "typeRelationHasTarget" |> NamespacedName

    /// <summary>
    /// Connects a Type Relation to the Type (that categorizes the
    ///             involved Thing(s)).
    /// <see href="https://www.ica.org/standards/RiC/ontology#typeRelationHasSource"></see></summary>
    let typeRelationHasSource =
        Namespaced_IRI.parse _namespace_name "typeRelationHasSource" |> NamespacedName

    /// <summary>
    /// A definite magnitude of a quantity, defined and adopted by convention or by
    ///             law, that is used as a standard for measurement of the same kind of quantity. Can be
    ///             spacial units (cm, m), weigt (g, kg), time (s, h), storage (MB, TB) or more informal
    ///             units used in the archival context like number of boxes, pages or words.
    /// <see href="https://www.ica.org/standards/RiC/ontology#UnitOfMeasurement"></see></summary>
    let UnitOfMeasurement =
        Namespaced_IRI.parse _namespace_name "UnitOfMeasurement" |> NamespacedName

    /// <summary>
    /// Connects a Whole Part Relation to a Thing that is a
    ///             part.
    /// <see href="https://www.ica.org/standards/RiC/ontology#wholePartRelationHasTarget"></see></summary>
    let wholePartRelationHasTarget =
        Namespaced_IRI.parse _namespace_name "wholePartRelationHasTarget" |> NamespacedName

    /// <summary>
    /// Connects a Whole Part Relation to the Thing that has some
    ///             parts.
    /// <see href="https://www.ica.org/standards/RiC/ontology#wholePartRelationHasSource"></see></summary>
    let wholePartRelationHasSource =
        Namespaced_IRI.parse _namespace_name "wholePartRelationHasSource" |> NamespacedName

    /// <summary>
    /// Connects at least two Agents that have some type of work
    ///             relation in the course of their activities.
    /// <see href="https://www.ica.org/standards/RiC/ontology#WorkRelation"></see></summary>
    let WorkRelation =
        Namespaced_IRI.parse _namespace_name "WorkRelation" |> NamespacedName

    /// <summary>
    /// Connects a Work Relation to an Agent.
    /// <see href="https://www.ica.org/standards/RiC/ontology#workRelationConnects"></see></summary>
    let workRelationConnects =
        Namespaced_IRI.parse _namespace_name "workRelationConnects" |> NamespacedName

    /// <summary>
    /// Information on the anticipated accession(s) to the Record
    ///             Set.
    /// <see href="https://www.ica.org/standards/RiC/ontology#accrual"></see></summary>
    let accrual = Namespaced_IRI.parse _namespace_name "accrual" |> NamespacedName

    /// <summary>
    /// Information on the status of an Accrual
    /// <see href="https://www.ica.org/standards/RiC/ontology#accrualStatus"></see></summary>
    let accrualStatus =
        Namespaced_IRI.parse _namespace_name "accrualStatus" |> NamespacedName

    /// <summary>
    /// Connects a Record Resource or Instantiation (that is
    ///             accumulated) to an Accumulation Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsSourceOfAccumulationRelation"></see></summary>
    let recordResourceOrInstantiationIsSourceOfAccumulationRelation =
        Namespaced_IRI.parse _namespace_name "recordResourceOrInstantiationIsSourceOfAccumulationRelation" |> NamespacedName

    /// <summary>
    /// Connects one of the accumulating Agents to an Accumulation
    ///             Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentIsTargetOfAccumulationRelation"></see></summary>
    let agentIsTargetOfAccumulationRelation =
        Namespaced_IRI.parse _namespace_name "agentIsTargetOfAccumulationRelation" |> NamespacedName

    /// <summary>
    /// Connects a Record Resource or Instantiation (that documents an
    ///             Activity) to an Activity Documentation Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsSourceOfActivityDocumentationRelation"></see></summary>
    let recordResourceOrInstantiationIsSourceOfActivityDocumentationRelation =
        Namespaced_IRI.parse _namespace_name "recordResourceOrInstantiationIsSourceOfActivityDocumentationRelation" |> NamespacedName

    /// <summary>
    /// Connects an Activity to an Activity Documentation
    ///             Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#activityIsTargetOfActivityDocumentationRelation"></see></summary>
    let activityIsTargetOfActivityDocumentationRelation =
        Namespaced_IRI.parse _namespace_name "activityIsTargetOfActivityDocumentationRelation" |> NamespacedName

    /// <summary>
    /// Connects an Activity to an Agent Temporal Relation (when the
    ///             Activity is transferred from an Agent to another one) or a Mandate Relation (the Mandate
    ///             assigns the Activity to the Agent or defines it).
    /// <see href="https://www.ica.org/standards/RiC/ontology#activityIsContextOfRelation"></see></summary>
    let activityIsContextOfRelation =
        Namespaced_IRI.parse _namespace_name "activityIsContextOfRelation" |> NamespacedName

    /// <summary>
    /// Connects a Thing (that is a secondary, contextual entity during
    ///             the existence of the Relation) to a n-ary Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#thingIsContextOfRelation"></see></summary>
    let thingIsContextOfRelation =
        Namespaced_IRI.parse _namespace_name "thingIsContextOfRelation" |> NamespacedName

    /// <summary>
    /// Connects an Activity that is performed to a Performance
    ///             Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#activityIsSourceOfPerformanceRelation"></see></summary>
    let activityIsSourceOfPerformanceRelation =
        Namespaced_IRI.parse _namespace_name "activityIsSourceOfPerformanceRelation" |> NamespacedName

    /// <summary>
    /// Connects a Thing (that is the source of a Relation) to a
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#thingIsSourceOfRelation"></see></summary>
    let thingIsSourceOfRelation =
        Namespaced_IRI.parse _namespace_name "thingIsSourceOfRelation" |> NamespacedName

    /// <summary>
    /// Connects an Agent or Activity that is the provenance of a Record
    ///             resource or Instantiation, to a Provenance Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentOrActivityIsTargetOfProvenanceRelation"></see></summary>
    let agentOrActivityIsTargetOfProvenanceRelation =
        Namespaced_IRI.parse _namespace_name "agentOrActivityIsTargetOfProvenanceRelation" |> NamespacedName

    /// <summary>
    /// Connects an Event to a Thing on which the Event has or had some
    ///             significant impact.
    /// <see href="https://www.ica.org/standards/RiC/ontology#affectsOrAffected"></see></summary>
    let affectsOrAffected =
        Namespaced_IRI.parse _namespace_name "affectsOrAffected" |> NamespacedName

    /// <summary>
    /// Connects an Event to a Thing that is or was actively or
    ///             passively involved in it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadParticipant"></see></summary>
    let hasOrHadParticipant =
        Namespaced_IRI.parse _namespace_name "hasOrHadParticipant" |> NamespacedName

    /// <summary>
    /// Inverse of 'affects or affected' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasAffectedBy"></see></summary>
    let isOrWasAffectedBy =
        Namespaced_IRI.parse _namespace_name "isOrWasAffectedBy" |> NamespacedName

    /// <summary>
    /// Connects a controlling Agent to an Agent Control
    ///             Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentIsSourceOfAgentControlRelation"></see></summary>
    let agentIsSourceOfAgentControlRelation =
        Namespaced_IRI.parse _namespace_name "agentIsSourceOfAgentControlRelation" |> NamespacedName

    /// <summary>
    /// Connects one of the controlled Agents to an Agent Control
    ///             Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentIsTargetOfAgentControlRelation"></see></summary>
    let agentIsTargetOfAgentControlRelation =
        Namespaced_IRI.parse _namespace_name "agentIsTargetOfAgentControlRelation" |> NamespacedName

    /// <summary>
    /// Connects an Agent to a Work Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentHasWorkRelation"></see></summary>
    let agentHasWorkRelation =
        Namespaced_IRI.parse _namespace_name "agentHasWorkRelation" |> NamespacedName

    /// <summary>
    /// Connects an Agent to an Agent Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentIsConnectedToAgentRelation"></see></summary>
    let agentIsConnectedToAgentRelation =
        Namespaced_IRI.parse _namespace_name "agentIsConnectedToAgentRelation" |> NamespacedName

    /// <summary>
    /// Connects an n-ary Relation to a Thing that is its
    ///             source.
    /// <see href="https://www.ica.org/standards/RiC/ontology#relationHasSource"></see></summary>
    let relationHasSource =
        Namespaced_IRI.parse _namespace_name "relationHasSource" |> NamespacedName

    /// <summary>
    /// Connects a hierarchically superior Agent to an Agent
    ///             Hierarchical Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentIsSourceOfAgentHierarchicalRelation"></see></summary>
    let agentIsSourceOfAgentHierarchicalRelation =
        Namespaced_IRI.parse _namespace_name "agentIsSourceOfAgentHierarchicalRelation" |> NamespacedName

    /// <summary>
    /// Connects an n-ary Relation to a Thing that is its
    ///             target.
    /// <see href="https://www.ica.org/standards/RiC/ontology#relationHasTarget"></see></summary>
    let relationHasTarget =
        Namespaced_IRI.parse _namespace_name "relationHasTarget" |> NamespacedName

    /// <summary>
    /// Connects one of the hierarchically inferior Agents to an Agent
    ///             Hierarchical Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentIsTargetOfAgentHierarchicalRelation"></see></summary>
    let agentIsTargetOfAgentHierarchicalRelation =
        Namespaced_IRI.parse _namespace_name "agentIsTargetOfAgentHierarchicalRelation" |> NamespacedName

    /// <summary>
    /// Connects a Thing to a n-ary Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#thingIsConnectedToRelation"></see></summary>
    let thingIsConnectedToRelation =
        Namespaced_IRI.parse _namespace_name "thingIsConnectedToRelation" |> NamespacedName

    /// <summary>
    /// Connects a predecessor Agent to an Agent Temporal
    ///             Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentIsSourceOfAgentTemporalRelation"></see></summary>
    let agentIsSourceOfAgentTemporalRelation =
        Namespaced_IRI.parse _namespace_name "agentIsSourceOfAgentTemporalRelation" |> NamespacedName

    /// <summary>
    /// Connects a Thing to a Temporal Relation, when this Thing
    ///             precedes other Thing(s) in time.
    /// <see href="https://www.ica.org/standards/RiC/ontology#thingIsSourceOfTemporalRelation"></see></summary>
    let thingIsSourceOfTemporalRelation =
        Namespaced_IRI.parse _namespace_name "thingIsSourceOfTemporalRelation" |> NamespacedName

    /// <summary>
    /// Connects an Agent thas has the authority, to an Authority
    ///             Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentIsSourceOfAuthorityRelation"></see></summary>
    let agentIsSourceOfAuthorityRelation =
        Namespaced_IRI.parse _namespace_name "agentIsSourceOfAuthorityRelation" |> NamespacedName

    /// <summary>
    /// Connects an Agent having the intellectual property rights, to an
    ///             Intellectual Property Rights Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentIsSourceOfIntellectualPropertyRightsRelation"></see></summary>
    let agentIsSourceOfIntellectualPropertyRightsRelation =
        Namespaced_IRI.parse _namespace_name "agentIsSourceOfIntellectualPropertyRightsRelation" |> NamespacedName

    /// <summary>
    /// Connects a manager Agent to a Management Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentIsSourceOfManagementRelation"></see></summary>
    let agentIsSourceOfManagementRelation =
        Namespaced_IRI.parse _namespace_name "agentIsSourceOfManagementRelation" |> NamespacedName

    /// <summary>
    /// Connects an owner Agent to an Ownership Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentIsSourceOfOwnershipRelation"></see></summary>
    let agentIsSourceOfOwnershipRelation =
        Namespaced_IRI.parse _namespace_name "agentIsSourceOfOwnershipRelation" |> NamespacedName

    /// <summary>
    /// Connects an Agent that holds a Record Resource or Instantiation,
    ///             to a Record Resource Holding Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentIsSourceOfRecordResourceHoldingRelation"></see></summary>
    let agentIsSourceOfRecordResourceHoldingRelation =
        Namespaced_IRI.parse _namespace_name "agentIsSourceOfRecordResourceHoldingRelation" |> NamespacedName

    /// <summary>
    /// Connects one of the Agents that created or accumulated the
    ///             Record resource or Instantiation, to an Agent Origination Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentIsTargetOfAgentOriginationRelation"></see></summary>
    let agentIsTargetOfAgentOriginationRelation =
        Namespaced_IRI.parse _namespace_name "agentIsTargetOfAgentOriginationRelation" |> NamespacedName

    /// <summary>
    /// Connects a Thing (that is under authority of an Agent) to an
    ///             Authority Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfAuthorityRelation"></see></summary>
    let thingIsTargetOfAuthorityRelation =
        Namespaced_IRI.parse _namespace_name "thingIsTargetOfAuthorityRelation" |> NamespacedName

    /// <summary>
    /// Connects a Thing to a n-ary Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfRelation"></see></summary>
    let thingIsTargetOfRelation =
        Namespaced_IRI.parse _namespace_name "thingIsTargetOfRelation" |> NamespacedName

    /// <summary>
    /// Connects a successor Agent to an Agent Temporal
    ///             Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentIsTargetOfAgentTemporalRelation"></see></summary>
    let agentIsTargetOfAgentTemporalRelation =
        Namespaced_IRI.parse _namespace_name "agentIsTargetOfAgentTemporalRelation" |> NamespacedName

    /// <summary>
    /// Connects a Thing (that follows other Thing(s) in time) to a
    ///             Temporal Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfTemporalRelation"></see></summary>
    let thingIsTargetOfTemporalRelation =
        Namespaced_IRI.parse _namespace_name "thingIsTargetOfTemporalRelation" |> NamespacedName

    /// <summary>
    /// Connects a Person, Group or Position to an Authorship
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentIsTargetOfAuthorshipRelation"></see></summary>
    let agentIsTargetOfAuthorshipRelation =
        Namespaced_IRI.parse _namespace_name "agentIsTargetOfAuthorshipRelation" |> NamespacedName

    /// <summary>
    /// Connects a creator Agent to a Creation Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentIsTargetOfCreationRelation"></see></summary>
    let agentIsTargetOfCreationRelation =
        Namespaced_IRI.parse _namespace_name "agentIsTargetOfCreationRelation" |> NamespacedName

    /// <summary>
    /// Connects a mandated Agent to a Mandate Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentIsTargetOfMandateRelation"></see></summary>
    let agentIsTargetOfMandateRelation =
        Namespaced_IRI.parse _namespace_name "agentIsTargetOfMandateRelation" |> NamespacedName

    /// <summary>
    /// Connects a Thing (that is associated with a Rule) to a Rule
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfRuleRelation"></see></summary>
    let thingIsTargetOfRuleRelation =
        Namespaced_IRI.parse _namespace_name "thingIsTargetOfRuleRelation" |> NamespacedName

    /// <summary>
    /// Connects an Agent to a Performance Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#agentIsTargetOfPerformanceRelation"></see></summary>
    let agentIsTargetOfPerformanceRelation =
        Namespaced_IRI.parse _namespace_name "agentIsTargetOfPerformanceRelation" |> NamespacedName

    /// <summary>
    /// Connects a Record Resource or Instantiation (that is created,
    ///             sent or accumulated) to an Agent Origination Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsSourceOfAgentOriginationRelation"></see></summary>
    let recordResourceOrInstantiationIsSourceOfAgentOriginationRelation =
        Namespaced_IRI.parse _namespace_name "recordResourceOrInstantiationIsSourceOfAgentOriginationRelation" |> NamespacedName

    /// <summary>
    /// Connects an n-ary Relation to any of the Things
    ///             involved.
    /// <see href="https://www.ica.org/standards/RiC/ontology#relationConnects"></see></summary>
    let relationConnects =
        Namespaced_IRI.parse _namespace_name "relationConnects" |> NamespacedName

    /// <summary>
    /// Reference system used for altitude
    /// <see href="https://www.ica.org/standards/RiC/ontology#altimetricSystem"></see></summary>
    let altimetricSystem =
        Namespaced_IRI.parse _namespace_name "altimetricSystem" |> NamespacedName

    /// <summary>
    /// Framework or standard used to represent an
    ///             information.
    /// <see href="https://www.ica.org/standards/RiC/ontology#referenceSystem"></see></summary>
    let referenceSystem =
        Namespaced_IRI.parse _namespace_name "referenceSystem" |> NamespacedName

    /// <summary>
    /// The height of a Place above a reference level, especially above
    ///             sea level.
    /// <see href="https://www.ica.org/standards/RiC/ontology#altitude"></see></summary>
    let altitude = Namespaced_IRI.parse _namespace_name "altitude" |> NamespacedName
    /// <summary>
    /// The extent, quantity, amount, or degree of an entity, as
    ///             determined by measurement or calculation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#measure"></see></summary>
    let measure = Namespaced_IRI.parse _namespace_name "measure" |> NamespacedName

    /// <summary>
    /// Connects an Appellation to an Appellation
    ///             Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#appellationIsSourceOfAppellationRelation"></see></summary>
    let appellationIsSourceOfAppellationRelation =
        Namespaced_IRI.parse _namespace_name "appellationIsSourceOfAppellationRelation" |> NamespacedName

    /// <summary>
    /// Connects a Thing (that is designated by an Appellation) to an
    ///             Appellation Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfAppellationRelation"></see></summary>
    let thingIsTargetOfAppellationRelation =
        Namespaced_IRI.parse _namespace_name "thingIsTargetOfAppellationRelation" |> NamespacedName

    /// <summary>
    /// Connects an n-ary Relation to a Thing that is a secondary,
    ///             contextual entity during the existence of the Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#relationHasContext"></see></summary>
    let relationHasContext =
        Namespaced_IRI.parse _namespace_name "relationHasContext" |> NamespacedName

    /// <summary>
    /// Description of evidences that the Record Resource or
    ///             Instantiation is what it purports to be, was created or sent by the said Agent, at the
    ///             said time and has not been tampered or corrupted.
    /// <see href="https://www.ica.org/standards/RiC/ontology#authenticityNote"></see></summary>
    let authenticityNote =
        Namespaced_IRI.parse _namespace_name "authenticityNote" |> NamespacedName

    /// <summary>
    /// Inverse of 'authorizes' object property
    /// <see href="https://www.ica.org/standards/RiC/ontology#authorizedBy"></see></summary>
    let authorizedBy =
        Namespaced_IRI.parse _namespace_name "authorizedBy" |> NamespacedName

    /// <summary>
    /// Inverse of 'is rule associated with' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isAssociatedWithRule"></see></summary>
    let isAssociatedWithRule =
        Namespaced_IRI.parse _namespace_name "isAssociatedWithRule" |> NamespacedName

    /// <summary>
    /// Connects a Rule to a Thing that is associated with the existence
    ///             and lifecycle of the Rule.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isRuleAssociatedWith"></see></summary>
    let isRuleAssociatedWith =
        Namespaced_IRI.parse _namespace_name "isRuleAssociatedWith" |> NamespacedName

    /// <summary>
    /// Connects a Mandate to a Mandate Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#mandateIsSourceOfMandateRelation"></see></summary>
    let mandateIsSourceOfMandateRelation =
        Namespaced_IRI.parse _namespace_name "mandateIsSourceOfMandateRelation" |> NamespacedName

    /// <summary>
    /// Connects an Agent that assigns the Mandate, to a Mandate
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isAuthorizingAgentInMandateRelation"></see></summary>
    let isAuthorizingAgentInMandateRelation =
        Namespaced_IRI.parse _namespace_name "isAuthorizingAgentInMandateRelation" |> NamespacedName

    /// <summary>
    /// Information on a Mandate that authorizes an Agent to perform an
    ///             Activity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#authorizingMandate"></see></summary>
    let authorizingMandate =
        Namespaced_IRI.parse _namespace_name "authorizingMandate" |> NamespacedName

    /// <summary>
    /// The rule or conditions that govern the existence or lifecycle of
    ///             a Thing.
    /// <see href="https://www.ica.org/standards/RiC/ontology#ruleFollowed"></see></summary>
    let ruleFollowed =
        Namespaced_IRI.parse _namespace_name "ruleFollowed" |> NamespacedName

    /// <summary>
    /// Connects a Record and an Authorship Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordIsSourceOfAuthorshipRelation"></see></summary>
    let recordIsSourceOfAuthorshipRelation =
        Namespaced_IRI.parse _namespace_name "recordIsSourceOfAuthorshipRelation" |> NamespacedName

    /// <summary>
    /// Date at which something began.
    /// <see href="https://www.ica.org/standards/RiC/ontology#beginningDate"></see></summary>
    let beginningDate =
        Namespaced_IRI.parse _namespace_name "beginningDate" |> NamespacedName

    /// <summary>
    /// Chronological information associated with an entity that
    ///             contributes to its identification and contextualization.
    /// <see href="https://www.ica.org/standards/RiC/ontology#date"></see></summary>
    let date = Namespaced_IRI.parse _namespace_name "date" |> NamespacedName
    /// <summary>
    /// Date at which a Person was born.
    /// <see href="https://www.ica.org/standards/RiC/ontology#birthDate"></see></summary>
    let birthDate = Namespaced_IRI.parse _namespace_name "birthDate" |> NamespacedName
    /// <summary>
    /// Used system of reckoning time in which the beginning, length,
    ///             and divisions of a year are defined, sometimes along with multiyear
    ///             cycles.
    /// <see href="https://www.ica.org/standards/RiC/ontology#calendar"></see></summary>
    let calendar = Namespaced_IRI.parse _namespace_name "calendar" |> NamespacedName

    /// <summary>
    /// Identifier of the standard of the Normalized
    ///             date.
    /// <see href="https://www.ica.org/standards/RiC/ontology#dateStandard"></see></summary>
    let dateStandard =
        Namespaced_IRI.parse _namespace_name "dateStandard" |> NamespacedName

    /// <summary>
    /// Number of physical units and/or physical dimensions of the
    ///             carrier of a record resource instantiation. Various carriers, depending on specific
    ///             needs, may have more than one relevant dimension. In some cases, indicating the number
    ///             of physical units may be sufficient, while in other case, relevant dimensions should be
    ///             used in order to characterize the carrier.
    /// <see href="https://www.ica.org/standards/RiC/ontology#carrierExtent"></see></summary>
    let carrierExtent =
        Namespaced_IRI.parse _namespace_name "carrierExtent" |> NamespacedName

    /// <summary>
    /// Countable characteristics of the content of an entity expressed
    ///             as a quantity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#physicalOrLogicalExtent"></see></summary>
    let physicalOrLogicalExtent =
        Namespaced_IRI.parse _namespace_name "physicalOrLogicalExtent" |> NamespacedName

    /// <summary>
    /// Qualifies the level of certitude of the accuracy of a Date, an
    ///             Event or a Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#certainty"></see></summary>
    let certainty = Namespaced_IRI.parse _namespace_name "certainty" |> NamespacedName

    /// <summary>
    /// Connects a Person (as a parent) to a Child
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#personIsSourceOfChildRelation"></see></summary>
    let personIsSourceOfChildRelation =
        Namespaced_IRI.parse _namespace_name "personIsSourceOfChildRelation" |> NamespacedName

    /// <summary>
    /// Connects a Person (as a child) to a Child
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#personIsTargetOfChildRelation"></see></summary>
    let personIsTargetOfChildRelation =
        Namespaced_IRI.parse _namespace_name "personIsTargetOfChildRelation" |> NamespacedName

    /// <summary>
    /// A term, number or alphanumeric string that is usually taken from
    ///             an external classification vocabulary or scheme that qualifies the Record
    ///             Resource.
    /// <see href="https://www.ica.org/standards/RiC/ontology#classification"></see></summary>
    let classification =
        Namespaced_IRI.parse _namespace_name "classification" |> NamespacedName

    /// <summary>
    /// Terms and circumstances affecting the availability of a Record
    ///             Resource for consultation. Such conditions may originate in laws, regulations and
    ///             policies, including those pertaining to privacy and security concerns or restrictions;
    ///             they may concern a specific Instantiation of a Record Resource, for example, conditions
    ///             that require preservation treatment; or they may specify the software or hardware
    ///             necessary to access the Instantiation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#conditionsOfAccess"></see></summary>
    let conditionsOfAccess =
        Namespaced_IRI.parse _namespace_name "conditionsOfAccess" |> NamespacedName

    /// <summary>
    /// Terms and circumstances affecting the use of a Record Resource
    ///             after access has been provided. Includes conditions governing reproduction of the Record
    ///             Resource under applicable copyright (intellectual property) and/or property legislation,
    ///             and of the Instantiation, due to conservation status.
    /// <see href="https://www.ica.org/standards/RiC/ontology#conditionsOfUse"></see></summary>
    let conditionsOfUse =
        Namespaced_IRI.parse _namespace_name "conditionsOfUse" |> NamespacedName

    /// <summary>
    /// Connects a Place to a region that is or was within
    ///             it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#containsOrContained"></see></summary>
    let containsOrContained =
        Namespaced_IRI.parse _namespace_name "containsOrContained" |> NamespacedName

    /// <summary>
    /// Connects a Place to a Thing that Place is associated with the
    ///             existence and lifecycle of.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isPlaceAssociatedWith"></see></summary>
    let isPlaceAssociatedWith =
        Namespaced_IRI.parse _namespace_name "isPlaceAssociatedWith" |> NamespacedName

    /// <summary>
    /// Inverse of 'is place associated with' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isAssociatedWithPlace"></see></summary>
    let isAssociatedWithPlace =
        Namespaced_IRI.parse _namespace_name "isAssociatedWithPlace" |> NamespacedName

    /// <summary>
    /// Connects a Thing to a constitutive or component part of that
    ///             Thing.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadPart"></see></summary>
    let hasOrHadPart =
        Namespaced_IRI.parse _namespace_name "hasOrHadPart" |> NamespacedName

    /// <summary>
    /// Inverse of 'contains or contained' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasContainedBy"></see></summary>
    let isOrWasContainedBy =
        Namespaced_IRI.parse _namespace_name "isOrWasContainedBy" |> NamespacedName

    /// <summary>
    /// Connects a Person to a Correspondence Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#personHasCorrespondenceRelation"></see></summary>
    let personHasCorrespondenceRelation =
        Namespaced_IRI.parse _namespace_name "personHasCorrespondenceRelation" |> NamespacedName

    /// <summary>
    /// Date at which an entity was created.
    /// <see href="https://www.ica.org/standards/RiC/ontology#creationDate"></see></summary>
    let creationDate =
        Namespaced_IRI.parse _namespace_name "creationDate" |> NamespacedName

    /// <summary>
    /// Connects a Record Resource or Instantiation (that is created) to
    ///             a Creation Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsSourceOfCreationRelation"></see></summary>
    let recordResourceOrInstantiationIsSourceOfCreationRelation =
        Namespaced_IRI.parse _namespace_name "recordResourceOrInstantiationIsSourceOfCreationRelation" |> NamespacedName

    /// <summary>
    /// Connects a Role Type to a Creation Relation (this Role Type
    ///             being the specific role played by the creating Person in the context of this
    ///             Relation).
    /// <see href="https://www.ica.org/standards/RiC/ontology#roleIsContextOfCreationRelation"></see></summary>
    let roleIsContextOfCreationRelation =
        Namespaced_IRI.parse _namespace_name "roleIsContextOfCreationRelation" |> NamespacedName

    /// <summary>
    /// Indicates the precision of a date. It specifies if, and to what
    ///             extent, the value is an estimation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#dateQualifier"></see></summary>
    let dateQualifier =
        Namespaced_IRI.parse _namespace_name "dateQualifier" |> NamespacedName

    /// <summary>
    /// Date at which a Person died.
    /// <see href="https://www.ica.org/standards/RiC/ontology#deathDate"></see></summary>
    let deathDate = Namespaced_IRI.parse _namespace_name "deathDate" |> NamespacedName
    /// <summary>
    /// Date at which something ended.
    /// <see href="https://www.ica.org/standards/RiC/ontology#endDate"></see></summary>
    let endDate = Namespaced_IRI.parse _namespace_name "endDate" |> NamespacedName

    /// <summary>
    /// Date at which an entity was deleted.
    /// <see href="https://www.ica.org/standards/RiC/ontology#deletionDate"></see></summary>
    let deletionDate =
        Namespaced_IRI.parse _namespace_name "deletionDate" |> NamespacedName

    /// <summary>
    /// Connects an Instantiation (from which at least one Instantiation
    ///             is derived) to a Derivation Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#instantiationIsSourceOfDerivationRelation"></see></summary>
    let instantiationIsSourceOfDerivationRelation =
        Namespaced_IRI.parse _namespace_name "instantiationIsSourceOfDerivationRelation" |> NamespacedName

    /// <summary>
    /// Connects a derived Instantiation to a Derivation
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#instantiationIsTargetOfDerivationRelation"></see></summary>
    let instantiationIsTargetOfDerivationRelation =
        Namespaced_IRI.parse _namespace_name "instantiationIsTargetOfDerivationRelation" |> NamespacedName

    /// <summary>
    /// Connects a Person (as an ancestor) to a Descendance
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#personIsSourceOfDescendanceRelation"></see></summary>
    let personIsSourceOfDescendanceRelation =
        Namespaced_IRI.parse _namespace_name "personIsSourceOfDescendanceRelation" |> NamespacedName

    /// <summary>
    /// Connects a Person (as a descendant) to a Descendance
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#personIsTargetOfDescendanceRelation"></see></summary>
    let personIsTargetOfDescendanceRelation =
        Namespaced_IRI.parse _namespace_name "personIsTargetOfDescendanceRelation" |> NamespacedName

    /// <summary>
    /// Connects a Record Resource to a Thing that it
    ///             describes.
    /// <see href="https://www.ica.org/standards/RiC/ontology#describesOrDescribed"></see></summary>
    let describesOrDescribed =
        Namespaced_IRI.parse _namespace_name "describesOrDescribed" |> NamespacedName

    /// <summary>
    /// Connects a Record Resource to a Thing that is or was its
    ///             subject.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadSubject"></see></summary>
    let hasOrHadSubject =
        Namespaced_IRI.parse _namespace_name "hasOrHadSubject" |> NamespacedName

    /// <summary>
    /// Inverse of 'describes or described' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasDescribedBy"></see></summary>
    let isOrWasDescribedBy =
        Namespaced_IRI.parse _namespace_name "isOrWasDescribedBy" |> NamespacedName

    /// <summary>
    /// Descriptive information about an entity that is not otherwise
    ///             addressed.
    /// <see href="https://www.ica.org/standards/RiC/ontology#descriptiveNote"></see></summary>
    let descriptiveNote =
        Namespaced_IRI.parse _namespace_name "descriptiveNote" |> NamespacedName

    /// <summary>
    /// Inverse of 'documents' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#documentedBy"></see></summary>
    let documentedBy =
        Namespaced_IRI.parse _namespace_name "documentedBy" |> NamespacedName

    /// <summary>
    /// Connects an Event to a Thing that results or resulted from the
    ///             Event.
    /// <see href="https://www.ica.org/standards/RiC/ontology#resultsOrResultedIn"></see></summary>
    let resultsOrResultedIn =
        Namespaced_IRI.parse _namespace_name "resultsOrResultedIn" |> NamespacedName

    /// <summary>
    /// Connects a Record Resource or an Instantiation to the Activity
    ///             that generates the Record Resource or Instantiation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#documents"></see></summary>
    let documents = Namespaced_IRI.parse _namespace_name "documents" |> NamespacedName

    /// <summary>
    /// Inverse of 'results or resulted in' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#resultsOrResultedFrom"></see></summary>
    let resultsOrResultedFrom =
        Namespaced_IRI.parse _namespace_name "resultsOrResultedFrom" |> NamespacedName

    /// <summary>
    /// Connects an Event to an Event Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#eventIsSourceOfEventRelation"></see></summary>
    let eventIsSourceOfEventRelation =
        Namespaced_IRI.parse _namespace_name "eventIsSourceOfEventRelation" |> NamespacedName

    /// <summary>
    /// Connects a Thing (that is associated with an Event) to an Event
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfEventRelation"></see></summary>
    let thingIsTargetOfEventRelation =
        Namespaced_IRI.parse _namespace_name "thingIsTargetOfEventRelation" |> NamespacedName

    /// <summary>
    /// Connects a Position to a Group in which that Position exists or
    ///             existed, or that is defined by that Group�s organizational structure.
    /// <see href="https://www.ica.org/standards/RiC/ontology#existsOrExistedIn"></see></summary>
    let existsOrExistedIn =
        Namespaced_IRI.parse _namespace_name "existsOrExistedIn" |> NamespacedName

    /// <summary>
    /// Connects two Agents. This object property is
    ///             symmetric.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isAgentAssociatedWithAgent"></see></summary>
    let isAgentAssociatedWithAgent =
        Namespaced_IRI.parse _namespace_name "isAgentAssociatedWithAgent" |> NamespacedName

    /// <summary>
    /// Inverse of 'exists or existed in' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadPosition"></see></summary>
    let hasOrHadPosition =
        Namespaced_IRI.parse _namespace_name "hasOrHadPosition" |> NamespacedName

    /// <summary>
    /// Connects a Position (that exists within a Group) to a Position
    ///             to Group Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#positionIsSourceOfPositionToGroupRelation"></see></summary>
    let positionIsSourceOfPositionToGroupRelation =
        Namespaced_IRI.parse _namespace_name "positionIsSourceOfPositionToGroupRelation" |> NamespacedName

    /// <summary>
    /// Natural language expression of a Date.
    /// <see href="https://www.ica.org/standards/RiC/ontology#expressedDate"></see></summary>
    let expressedDate =
        Namespaced_IRI.parse _namespace_name "expressedDate" |> NamespacedName

    /// <summary>
    /// A textual expression of an Appellation or Date.
    /// <see href="https://www.ica.org/standards/RiC/ontology#textualValue"></see></summary>
    let textualValue =
        Namespaced_IRI.parse _namespace_name "textualValue" |> NamespacedName

    /// <summary>
    /// Inverse of 'is or was expressed by' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#expressesOrExpressed"></see></summary>
    let expressesOrExpressed =
        Namespaced_IRI.parse _namespace_name "expressesOrExpressed" |> NamespacedName

    /// <summary>
    /// Connects a Rule to a Record Resource that expresses or expressed
    ///             the Rule.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasExpressedBy"></see></summary>
    let isOrWasExpressedBy =
        Namespaced_IRI.parse _namespace_name "isOrWasExpressedBy" |> NamespacedName

    /// <summary>
    /// Connects a Person to a Family Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#personHasFamilyRelation"></see></summary>
    let personHasFamilyRelation =
        Namespaced_IRI.parse _namespace_name "personHasFamilyRelation" |> NamespacedName

    /// <summary>
    /// Inverse of 'precedes in time' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#followsInTime"></see></summary>
    let followsInTime =
        Namespaced_IRI.parse _namespace_name "followsInTime" |> NamespacedName

    /// <summary>
    /// Inverse of 'precedesOrPreceded' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#followsOrFollowed"></see></summary>
    let followsOrFollowed =
        Namespaced_IRI.parse _namespace_name "followsOrFollowed" |> NamespacedName

    /// <summary>
    /// Connects a Thing to a Thing that follows it in chronological
    ///             order.
    /// <see href="https://www.ica.org/standards/RiC/ontology#precedesInTime"></see></summary>
    let precedesInTime =
        Namespaced_IRI.parse _namespace_name "precedesInTime" |> NamespacedName

    /// <summary>
    /// The most generic object property. Connects an Thing to any other
    ///             Thing This is a symmetric object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isRelatedTo"></see></summary>
    let isRelatedTo =
        Namespaced_IRI.parse _namespace_name "isRelatedTo" |> NamespacedName

    /// <summary>
    /// Connects a Thing to a Thing that follows or followed it in some
    ///             sequence.
    /// <see href="https://www.ica.org/standards/RiC/ontology#precedesOrPreceded"></see></summary>
    let precedesOrPreceded =
        Namespaced_IRI.parse _namespace_name "precedesOrPreceded" |> NamespacedName

    /// <summary>
    /// Connects a Thing (that follows other Thing(s) in a sequence) to
    ///             a Sequential Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfSequentialRelation"></see></summary>
    let thingIsTargetOfSequentialRelation =
        Namespaced_IRI.parse _namespace_name "thingIsTargetOfSequentialRelation" |> NamespacedName

    /// <summary>
    /// Connects an Instantiation to a Functional Equivalence
    ///             Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#instantiationIsConnectedToFunctionalEquivalenceRelation"></see></summary>
    let instantiationIsConnectedToFunctionalEquivalenceRelation =
        Namespaced_IRI.parse _namespace_name "instantiationIsConnectedToFunctionalEquivalenceRelation" |> NamespacedName

    /// <summary>
    /// Reference system used for geographical
    ///             coordinates.
    /// <see href="https://www.ica.org/standards/RiC/ontology#geodesicSystem"></see></summary>
    let geodesicSystem =
        Namespaced_IRI.parse _namespace_name "geodesicSystem" |> NamespacedName

    /// <summary>
    /// Longitudinal and latitudinal information of a
    ///             Place.
    /// <see href="https://www.ica.org/standards/RiC/ontology#geographicalCoordinates"></see></summary>
    let geographicalCoordinates =
        Namespaced_IRI.parse _namespace_name "geographicalCoordinates" |> NamespacedName

    /// <summary>
    /// Connects the Group that has at least a subdivision, to a Group
    ///             Subdivision Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#groupIsSourceOfGroupSubdivisionRelation"></see></summary>
    let groupIsSourceOfGroupSubdivisionRelation =
        Namespaced_IRI.parse _namespace_name "groupIsSourceOfGroupSubdivisionRelation" |> NamespacedName

    /// <summary>
    /// Connects a Thing to a Whole Part Relation, when this Thing has
    ///             Part other Thing(s).
    /// <see href="https://www.ica.org/standards/RiC/ontology#thingIsSourceOfWholePartRelation"></see></summary>
    let thingIsSourceOfWholePartRelation =
        Namespaced_IRI.parse _namespace_name "thingIsSourceOfWholePartRelation" |> NamespacedName

    /// <summary>
    /// Connects the Group (that has one to many members) to a
    ///             Membership Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#groupIsSourceOfMembershipRelation"></see></summary>
    let groupIsSourceOfMembershipRelation =
        Namespaced_IRI.parse _namespace_name "groupIsSourceOfMembershipRelation" |> NamespacedName

    /// <summary>
    /// Connects a Group that is a subdivision, to a Group Subdivision
    ///             Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#groupIsTargetOfGroupSubdivisionRelation"></see></summary>
    let groupIsTargetOfGroupSubdivisionRelation =
        Namespaced_IRI.parse _namespace_name "groupIsTargetOfGroupSubdivisionRelation" |> NamespacedName

    /// <summary>
    /// Connects a Thing to a Whole Part Relation, when this Thing is
    ///             Part of another Thing.
    /// <see href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfWholePartRelation"></see></summary>
    let thingIsTargetOfWholePartRelation =
        Namespaced_IRI.parse _namespace_name "thingIsTargetOfWholePartRelation" |> NamespacedName

    /// <summary>
    /// Connects a Group (which has a leader) to a Leadership
    ///             Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#groupIsTargetOfLeadershipRelation"></see></summary>
    let groupIsTargetOfLeadershipRelation =
        Namespaced_IRI.parse _namespace_name "groupIsTargetOfLeadershipRelation" |> NamespacedName

    /// <summary>
    /// Connects the Group (in which a Position exists) to a Position To
    ///             Group Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#groupIsTargetOfPositionToGroupRelation"></see></summary>
    let groupIsTargetOfPositionToGroupRelation =
        Namespaced_IRI.parse _namespace_name "groupIsTargetOfPositionToGroupRelation" |> NamespacedName

    /// <summary>
    /// Connects a Record Resource or an Instantiation to the Agent that
    ///             accumulates it, be it intentionally (collecting) or not (receiving in the course of its
    ///             activities).
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasAccumulator"></see></summary>
    let hasAccumulator =
        Namespaced_IRI.parse _namespace_name "hasAccumulator" |> NamespacedName

    /// <summary>
    /// Connects a Record Resource or an Instantiation to an Agent that
    ///             creates or accumulates the Record Resource, receives it, or sends it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasProvenance"></see></summary>
    let hasProvenance =
        Namespaced_IRI.parse _namespace_name "hasProvenance" |> NamespacedName

    /// <summary>
    /// Inverse of 'has accumulator' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isAccumulatorOf"></see></summary>
    let isAccumulatorOf =
        Namespaced_IRI.parse _namespace_name "isAccumulatorOf" |> NamespacedName

    /// <summary>
    /// Connects a Thing to a Type that categorizes or categorized
    ///             it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadCategory"></see></summary>
    let hasOrHadCategory =
        Namespaced_IRI.parse _namespace_name "hasOrHadCategory" |> NamespacedName

    /// <summary>
    /// Connects a Record Resource or an Instantiation to the Agent that
    ///             it is addressed to.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasAddressee"></see></summary>
    let hasAddressee =
        Namespaced_IRI.parse _namespace_name "hasAddressee" |> NamespacedName

    /// <summary>
    /// Inverse of 'has addressee' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isAddresseeOf"></see></summary>
    let isAddresseeOf =
        Namespaced_IRI.parse _namespace_name "isAddresseeOf" |> NamespacedName

    /// <summary>
    /// Inverse of 'has descendant' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasAncestor"></see></summary>
    let hasAncestor =
        Namespaced_IRI.parse _namespace_name "hasAncestor" |> NamespacedName

    /// <summary>
    /// Connects two Persons that have some type of family link, i.e.
    ///             belong to the same family. This relation is symmetric.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasFamilyAssociationWith"></see></summary>
    let hasFamilyAssociationWith =
        Namespaced_IRI.parse _namespace_name "hasFamilyAssociationWith" |> NamespacedName

    /// <summary>
    /// Inverse of 'has successor' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isSuccessorOf"></see></summary>
    let isSuccessorOf =
        Namespaced_IRI.parse _namespace_name "isSuccessorOf" |> NamespacedName

    /// <summary>
    /// Connects a Person to one of their descendants.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasDescendant"></see></summary>
    let hasDescendant =
        Namespaced_IRI.parse _namespace_name "hasDescendant" |> NamespacedName

    /// <summary>
    /// Connects a Record to the Group, Person or Position that is
    ///             responsible for conceiving and formulating the information contained in the
    ///             Record.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasAuthor"></see></summary>
    let hasAuthor = Namespaced_IRI.parse _namespace_name "hasAuthor" |> NamespacedName
    /// <summary>
    /// Connects a Record Resource or an Instantiation to an Agent that
    ///             is either responsible for all or some of the content of the Record Resource or is a
    ///             contributor to the genesis or production of an Instantiation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasCreator"></see></summary>
    let hasCreator = Namespaced_IRI.parse _namespace_name "hasCreator" |> NamespacedName
    /// <summary>
    /// Inverse of 'has author' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isAuthorOf"></see></summary>
    let isAuthorOf = Namespaced_IRI.parse _namespace_name "isAuthorOf" |> NamespacedName

    /// <summary>
    /// Inverse of 'is date associated with' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isAssociatedWithDate"></see></summary>
    let isAssociatedWithDate =
        Namespaced_IRI.parse _namespace_name "isAssociatedWithDate" |> NamespacedName

    /// <summary>
    /// Connects a Date to a Thing that came into existence on that
    ///             Date.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isBeginningDateOf"></see></summary>
    let isBeginningDateOf =
        Namespaced_IRI.parse _namespace_name "isBeginningDateOf" |> NamespacedName

    /// <summary>
    /// Inverse of 'is birth date of' object property
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasBirthDate"></see></summary>
    let hasBirthDate =
        Namespaced_IRI.parse _namespace_name "hasBirthDate" |> NamespacedName

    /// <summary>
    /// Connects a Date to a Person that was born on that
    ///             Date.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isBirthDateOf"></see></summary>
    let isBirthDateOf =
        Namespaced_IRI.parse _namespace_name "isBirthDateOf" |> NamespacedName

    /// <summary>
    /// Connects a Person to one of their children.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasChild"></see></summary>
    let hasChild = Namespaced_IRI.parse _namespace_name "hasChild" |> NamespacedName
    /// <summary>
    /// Inverse of 'has child' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isChildOf"></see></summary>
    let isChildOf = Namespaced_IRI.parse _namespace_name "isChildOf" |> NamespacedName

    /// <summary>
    /// Connects a Record Resource or an Instantiation to the Agent that
    ///             collects it intentionally (is a collector).
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasCollector"></see></summary>
    let hasCollector =
        Namespaced_IRI.parse _namespace_name "hasCollector" |> NamespacedName

    /// <summary>
    /// Inverse of 'has collector' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isCollectorOf"></see></summary>
    let isCollectorOf =
        Namespaced_IRI.parse _namespace_name "isCollectorOf" |> NamespacedName

    /// <summary>
    /// Connects a Record or a Record Part to a Content Type which
    ///             categorizes its content.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasContentOfType"></see></summary>
    let hasContentOfType =
        Namespaced_IRI.parse _namespace_name "hasContentOfType" |> NamespacedName

    /// <summary>
    /// Connects a Record Resource to a copy of that Record
    ///             Resource.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasCopy"></see></summary>
    let hasCopy = Namespaced_IRI.parse _namespace_name "hasCopy" |> NamespacedName

    /// <summary>
    /// Connects two Record Resources when there is a genetic link
    ///             between them. Genetic in this sense is as defined by diplomatics, i.e. the process by
    ///             which a Record Resource is developed. This relation is symmetric.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasGeneticLinkToRecordResource"></see></summary>
    let hasGeneticLinkToRecordResource =
        Namespaced_IRI.parse _namespace_name "hasGeneticLinkToRecordResource" |> NamespacedName

    /// <summary>
    /// Inverse of 'has copy' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isCopyOf"></see></summary>
    let isCopyOf = Namespaced_IRI.parse _namespace_name "isCopyOf" |> NamespacedName

    /// <summary>
    /// Inverse of 'has creator' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isCreatorOf"></see></summary>
    let isCreatorOf =
        Namespaced_IRI.parse _namespace_name "isCreatorOf" |> NamespacedName

    /// <summary>
    /// Inverse of 'is death date of' object property
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasDeathDate"></see></summary>
    let hasDeathDate =
        Namespaced_IRI.parse _namespace_name "hasDeathDate" |> NamespacedName

    /// <summary>
    /// Connects a Date to a Person who died on that
    ///             Date.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isDeathDateOf"></see></summary>
    let isDeathDateOf =
        Namespaced_IRI.parse _namespace_name "isDeathDateOf" |> NamespacedName

    /// <summary>
    /// Connects an Instantiation to an Instantiation that is derived
    ///             from it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasDerivedInstantiation"></see></summary>
    let hasDerivedInstantiation =
        Namespaced_IRI.parse _namespace_name "hasDerivedInstantiation" |> NamespacedName

    /// <summary>
    /// Connects two Instantiations. This object property is
    ///             symmetric.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isInstantiationAssociatedWithInstantiation"></see></summary>
    let isInstantiationAssociatedWithInstantiation =
        Namespaced_IRI.parse _namespace_name "isInstantiationAssociatedWithInstantiation" |> NamespacedName

    /// <summary>
    /// Inverse of 'has derived instantiation' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isDerivedFromInstantiation"></see></summary>
    let isDerivedFromInstantiation =
        Namespaced_IRI.parse _namespace_name "isDerivedFromInstantiation" |> NamespacedName

    /// <summary>
    /// Connects an Agent to another Agent that succeeds it
    ///             chronologically.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasSuccessor"></see></summary>
    let hasSuccessor =
        Namespaced_IRI.parse _namespace_name "hasSuccessor" |> NamespacedName

    /// <summary>
    /// Connects a Record or Record Part to its Documentary Form
    ///             Type.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasDocumentaryFormType"></see></summary>
    let hasDocumentaryFormType =
        Namespaced_IRI.parse _namespace_name "hasDocumentaryFormType" |> NamespacedName

    /// <summary>
    /// Inverse of 'is draft of' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasDraft"></see></summary>
    let hasDraft = Namespaced_IRI.parse _namespace_name "hasDraft" |> NamespacedName
    /// <summary>
    /// Connects a draft to the final version of a
    ///             Record.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isDraftOf"></see></summary>
    let isDraftOf = Namespaced_IRI.parse _namespace_name "isDraftOf" |> NamespacedName

    /// <summary>
    /// Connects a Date to a Thing whose existence ended on that
    ///             Date.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isEndDateOf"></see></summary>
    let isEndDateOf =
        Namespaced_IRI.parse _namespace_name "isEndDateOf" |> NamespacedName

    /// <summary>
    /// Connects a Record Resource or Instantiation to an Extent
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasExtent"></see></summary>
    let hasExtent = Namespaced_IRI.parse _namespace_name "hasExtent" |> NamespacedName
    /// <summary>
    /// Connects an Extent to a Record Resource or Instantiation
    /// <see href="https://www.ica.org/standards/RiC/ontology#isExtentOf"></see></summary>
    let isExtentOf = Namespaced_IRI.parse _namespace_name "isExtentOf" |> NamespacedName

    /// <summary>
    /// Connects an Extent to an Extent Type that categorizes what is being
    ///             measured.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasExtentType"></see></summary>
    let hasExtentType =
        Namespaced_IRI.parse _namespace_name "hasExtentType" |> NamespacedName

    /// <summary>
    /// Connects an Extent Type to an Extent that it
    ///             categorizes.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isExtentTypeOf"></see></summary>
    let isExtentTypeOf =
        Namespaced_IRI.parse _namespace_name "isExtentTypeOf" |> NamespacedName

    /// <summary>
    /// Connects a Family to a Family Type that categorizes
    ///             it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasFamilyType"></see></summary>
    let hasFamilyType =
        Namespaced_IRI.parse _namespace_name "hasFamilyType" |> NamespacedName

    /// <summary>
    /// Connects two Record Resources. This object property is
    ///             symmetric.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isRecordResourceAssociatedWithRecordResource"></see></summary>
    let isRecordResourceAssociatedWithRecordResource =
        Namespaced_IRI.parse _namespace_name "isRecordResourceAssociatedWithRecordResource" |> NamespacedName

    /// <summary>
    /// Inverse of 'has instantiation' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isInstantiationOf"></see></summary>
    let isInstantiationOf =
        Namespaced_IRI.parse _namespace_name "isInstantiationOf" |> NamespacedName

    /// <summary>
    /// Connects a Record Resource (that was instantiated) to a Record
    ///             Resource To Instantiation Relation
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordResourceIsSourceOfRecordResourceToInstantiationRelation"></see></summary>
    let recordResourceIsSourceOfRecordResourceToInstantiationRelation =
        Namespaced_IRI.parse _namespace_name "recordResourceIsSourceOfRecordResourceToInstantiationRelation" |> NamespacedName

    /// <summary>
    /// Inverse of 'is modification date of' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasModificationDate"></see></summary>
    let hasModificationDate =
        Namespaced_IRI.parse _namespace_name "hasModificationDate" |> NamespacedName

    /// <summary>
    /// Connects a Date to a Thing that was modified on that
    ///             Date.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isModificationDateOf"></see></summary>
    let isModificationDateOf =
        Namespaced_IRI.parse _namespace_name "isModificationDateOf" |> NamespacedName

    /// <summary>
    /// Connects an Agent and (one of) its present or past Agent
    ///             Name.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadAgentName"></see></summary>
    let hasOrHadAgentName =
        Namespaced_IRI.parse _namespace_name "hasOrHadAgentName" |> NamespacedName

    /// <summary>
    /// Connects a Thing to one of its past or present
    ///             Names.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadName"></see></summary>
    let hasOrHadName =
        Namespaced_IRI.parse _namespace_name "hasOrHadName" |> NamespacedName

    /// <summary>
    /// Connects an Agent Name to an Agent it designates or
    ///             designated.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasAgentNameOf"></see></summary>
    let isOrWasAgentNameOf =
        Namespaced_IRI.parse _namespace_name "isOrWasAgentNameOf" |> NamespacedName

    /// <summary>
    /// Connects a Record Set and a Category (Type) to which all the
    ///             Records or Record Parts that are or were included in the Record Set
    ///             belong.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadAllMembersWithCategory"></see></summary>
    let hasOrHadAllMembersWithCategory =
        Namespaced_IRI.parse _namespace_name "hasOrHadAllMembersWithCategory" |> NamespacedName

    /// <summary>
    /// Connects a Category (Type) and a Record Set whose all present or
    ///             past Record or Record Part members belong to that Category.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasCategoryOfAllMembersOf"></see></summary>
    let isOrWasCategoryOfAllMembersOf =
        Namespaced_IRI.parse _namespace_name "isOrWasCategoryOfAllMembersOf" |> NamespacedName

    /// <summary>
    /// Connects a Record Set and a Content Type that categorizes all
    ///             the Records or Record Parts that are or were included in the Record Set.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadAllMembersWithContentType"></see></summary>
    let hasOrHadAllMembersWithContentType =
        Namespaced_IRI.parse _namespace_name "hasOrHadAllMembersWithContentType" |> NamespacedName

    /// <summary>
    /// Connects a Content Type and a Record Set whose all past or
    ///             present Record or Record Part members have that Content Type.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasContentTypeOfAllMembersOf"></see></summary>
    let isOrWasContentTypeOfAllMembersOf =
        Namespaced_IRI.parse _namespace_name "isOrWasContentTypeOfAllMembersOf" |> NamespacedName

    /// <summary>
    /// Connects a Record Set and a Documentary Form Type that
    ///             categorizes all the Records or Record Parts that are or were included in the Record
    ///             Set.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadAllMembersWithDocumentaryFormType"></see></summary>
    let hasOrHadAllMembersWithDocumentaryFormType =
        Namespaced_IRI.parse _namespace_name "hasOrHadAllMembersWithDocumentaryFormType" |> NamespacedName

    /// <summary>
    /// Connects a Documentary Form Type and a Record Set whose all past
    ///             or present Record or Record Part members have that Documentary Form Type.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasDocumentaryFormTypeOfAllMembersOf"></see></summary>
    let isOrWasDocumentaryFormTypeOfAllMembersOf =
        Namespaced_IRI.parse _namespace_name "isOrWasDocumentaryFormTypeOfAllMembersOf" |> NamespacedName

    /// <summary>
    /// Connects a Record Set and a Language used by all the Records or
    ///             Record Parts that are or were included in the Record Set.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadAllMembersWithLanguage"></see></summary>
    let hasOrHadAllMembersWithLanguage =
        Namespaced_IRI.parse _namespace_name "hasOrHadAllMembersWithLanguage" |> NamespacedName

    /// <summary>
    /// Connects a Language and a Record Set whose all present or past
    ///             Record or Record Part members use that Language.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasLanguageOfAllMembersOf"></see></summary>
    let isOrWasLanguageOfAllMembersOf =
        Namespaced_IRI.parse _namespace_name "isOrWasLanguageOfAllMembersOf" |> NamespacedName

    /// <summary>
    /// Connects a Record Set and a Legal Status that categorizes all
    ///             the Records or Record Parts that are or were included in the Record Set.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadAllMembersWithLegalStatus"></see></summary>
    let hasOrHadAllMembersWithLegalStatus =
        Namespaced_IRI.parse _namespace_name "hasOrHadAllMembersWithLegalStatus" |> NamespacedName

    /// <summary>
    /// Connects a Legal Status and a Record Set whose all past or
    ///             present Record or Record Part members have that Legal Status.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasLegalStatusOfAllMembersOf"></see></summary>
    let isOrWasLegalStatusOfAllMembersOf =
        Namespaced_IRI.parse _namespace_name "isOrWasLegalStatusOfAllMembersOf" |> NamespacedName

    /// <summary>
    /// Connects a Record Set and a Record State that categorizes all
    ///             the Records or Record Parts that are or were included in the Record Set.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadAllMembersWithRecordState"></see></summary>
    let hasOrHadAllMembersWithRecordState =
        Namespaced_IRI.parse _namespace_name "hasOrHadAllMembersWithRecordState" |> NamespacedName

    /// <summary>
    /// Connects a Record State and a Record Set whose all past or
    ///             present Record or Record Part members have that Record State.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasRecordStateOfAllMembersOf"></see></summary>
    let isOrWasRecordStateOfAllMembersOf =
        Namespaced_IRI.parse _namespace_name "isOrWasRecordStateOfAllMembersOf" |> NamespacedName

    /// <summary>
    /// Connects a Thing to an Appellation that is or was used for
    ///             designating it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadAppellation"></see></summary>
    let hasOrHadAppellation =
        Namespaced_IRI.parse _namespace_name "hasOrHadAppellation" |> NamespacedName

    /// <summary>
    /// Connects an Appellation to a Thing that it designates or
    ///             designated.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasAppellationOf"></see></summary>
    let isOrWasAppellationOf =
        Namespaced_IRI.parse _namespace_name "isOrWasAppellationOf" |> NamespacedName

    /// <summary>
    /// Connects an Agent to a Thing the Agent has or had authority
    ///             over.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadAuthorityOver"></see></summary>
    let hasOrHadAuthorityOver =
        Namespaced_IRI.parse _namespace_name "hasOrHadAuthorityOver" |> NamespacedName

    /// <summary>
    /// Inverse of 'has or had authority over' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasUnderAuthorityOf"></see></summary>
    let isOrWasUnderAuthorityOf =
        Namespaced_IRI.parse _namespace_name "isOrWasUnderAuthorityOf" |> NamespacedName

    /// <summary>
    /// Connects a Type (a category) to a Thing that it categorizes or
    ///             categorized.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasCategoryOf"></see></summary>
    let isOrWasCategoryOf =
        Namespaced_IRI.parse _namespace_name "isOrWasCategoryOf" |> NamespacedName

    /// <summary>
    /// Connects a Thing (that is categorized by a Type) to a Type
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfTypeRelation"></see></summary>
    let thingIsTargetOfTypeRelation =
        Namespaced_IRI.parse _namespace_name "thingIsTargetOfTypeRelation" |> NamespacedName

    /// <summary>
    /// Connects an Instantiation to one of its present or past
    ///             component instantiations.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadComponent"></see></summary>
    let hasOrHadComponent =
        Namespaced_IRI.parse _namespace_name "hasOrHadComponent" |> NamespacedName

    /// <summary>
    /// Inverse of 'has or had component' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasComponentOf"></see></summary>
    let isOrWasComponentOf =
        Namespaced_IRI.parse _namespace_name "isOrWasComponentOf" |> NamespacedName

    /// <summary>
    /// Connects a Record to a Record Part that is or was a component of
    ///             that Record.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadConstituent"></see></summary>
    let hasOrHadConstituent =
        Namespaced_IRI.parse _namespace_name "hasOrHadConstituent" |> NamespacedName

    /// <summary>
    /// Inverse of 'has or had constituent' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasConstituentOf"></see></summary>
    let isOrWasConstituentOf =
        Namespaced_IRI.parse _namespace_name "isOrWasConstituentOf" |> NamespacedName

    /// <summary>
    /// Inverse of 'is or was controller of' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadController"></see></summary>
    let hasOrHadController =
        Namespaced_IRI.parse _namespace_name "hasOrHadController" |> NamespacedName

    /// <summary>
    /// Inverse of 'has or had subordinate' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasSubordinateTo"></see></summary>
    let isOrWasSubordinateTo =
        Namespaced_IRI.parse _namespace_name "isOrWasSubordinateTo" |> NamespacedName

    /// <summary>
    /// Connects an Agent to another Agent it controls or controlled via
    ///             Activities, i.e. controls by function.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasControllerOf"></see></summary>
    let isOrWasControllerOf =
        Namespaced_IRI.parse _namespace_name "isOrWasControllerOf" |> NamespacedName

    /// <summary>
    /// Connects a Corporate Body to a Corporate Body Type which
    ///             categorizes or categorized it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadCorporateBodyType"></see></summary>
    let hasOrHadCorporateBodyType =
        Namespaced_IRI.parse _namespace_name "hasOrHadCorporateBodyType" |> NamespacedName

    /// <summary>
    /// Connects two Persons that correspond or have corresponded with
    ///             each other. This relation is symmetric.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadCorrespondent"></see></summary>
    let hasOrHadCorrespondent =
        Namespaced_IRI.parse _namespace_name "hasOrHadCorrespondent" |> NamespacedName

    /// <summary>
    /// Connects two Persons that directly know each other during their
    ///             existence. This object property is symmetric.
    /// <see href="https://www.ica.org/standards/RiC/ontology#knows"></see></summary>
    let knows = Namespaced_IRI.parse _namespace_name "knows" |> NamespacedName

    /// <summary>
    /// Connects a Person or a Group to a Demographic Group to which it
    ///             belongs or belonged.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadDemographicGroup"></see></summary>
    let hasOrHadDemographicGroup =
        Namespaced_IRI.parse _namespace_name "hasOrHadDemographicGroup" |> NamespacedName

    /// <summary>
    /// Connects a Demographic Group to a Person or Group which belongs
    ///             or belonged to it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasDemographicGroupOf"></see></summary>
    let isOrWasDemographicGroupOf =
        Namespaced_IRI.parse _namespace_name "isOrWasDemographicGroupOf" |> NamespacedName

    /// <summary>
    /// Inverse of 'is or was holder of' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadHolder"></see></summary>
    let hasOrHadHolder =
        Namespaced_IRI.parse _namespace_name "hasOrHadHolder" |> NamespacedName

    /// <summary>
    /// Inverse of 'is or was manager of' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadManager"></see></summary>
    let hasOrHadManager =
        Namespaced_IRI.parse _namespace_name "hasOrHadManager" |> NamespacedName

    /// <summary>
    /// Connects an Agent to a Record Resource or Instantiation that the
    ///             Agent holds or held.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasHolderOf"></see></summary>
    let isOrWasHolderOf =
        Namespaced_IRI.parse _namespace_name "isOrWasHolderOf" |> NamespacedName

    /// <summary>
    /// Connects a Record Resource or Instantiation (that is held by an
    ///             Agent) to a Record Resource Holding Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsTargetOfRecordResourceHoldingRelation"></see></summary>
    let recordResourceOrInstantiationIsTargetOfRecordResourceHoldingRelation =
        Namespaced_IRI.parse _namespace_name "recordResourceOrInstantiationIsTargetOfRecordResourceHoldingRelation" |> NamespacedName

    /// <summary>
    /// Connects a Thing to one of its past or present
    ///             Identifiers.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadIdentifier"></see></summary>
    let hasOrHadIdentifier =
        Namespaced_IRI.parse _namespace_name "hasOrHadIdentifier" |> NamespacedName

    /// <summary>
    /// Connects an Identifier to a Thing that it identified or
    ///             identifies.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasIdentifierOf"></see></summary>
    let isOrWasIdentifierOf =
        Namespaced_IRI.parse _namespace_name "isOrWasIdentifierOf" |> NamespacedName

    /// <summary>
    /// Inverse of 'is or was holder of intellectual property rights of'
    ///             object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadIntellectualPropertyRightsHolder"></see></summary>
    let hasOrHadIntellectualPropertyRightsHolder =
        Namespaced_IRI.parse _namespace_name "hasOrHadIntellectualPropertyRightsHolder" |> NamespacedName

    /// <summary>
    /// Connects an Agent to a Record Resource or Instantiation on which
    ///             the Agent has or had some intellectual property rights.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasHolderOfIntellectualPropertyRightsOf"></see></summary>
    let isOrWasHolderOfIntellectualPropertyRightsOf =
        Namespaced_IRI.parse _namespace_name "isOrWasHolderOfIntellectualPropertyRightsOf" |> NamespacedName

    /// <summary>
    /// Connects a Record Resource or Instantiation (on which some
    ///             intellectual property rights are held) to an Intellectual Property Rights
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsTargetOfIntellectualPropertyRightsRelation"></see></summary>
    let recordResourceOrInstantiationIsTargetOfIntellectualPropertyRightsRelation =
        Namespaced_IRI.parse _namespace_name "recordResourceOrInstantiationIsTargetOfIntellectualPropertyRightsRelation" |> NamespacedName

    /// <summary>
    /// Inverse of 'is or was jurisdiction of' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadJurisdiction"></see></summary>
    let hasOrHadJurisdiction =
        Namespaced_IRI.parse _namespace_name "hasOrHadJurisdiction" |> NamespacedName

    /// <summary>
    /// Connects a Place to an Agent that has or had jurisdiction over
    ///             the Place.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasJurisdictionOf"></see></summary>
    let isOrWasJurisdictionOf =
        Namespaced_IRI.parse _namespace_name "isOrWasJurisdictionOf" |> NamespacedName

    /// <summary>
    /// Connects an Agent or Record Resource to a Language that it uses
    ///             or used.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadLanguage"></see></summary>
    let hasOrHadLanguage =
        Namespaced_IRI.parse _namespace_name "hasOrHadLanguage" |> NamespacedName

    /// <summary>
    /// Connects a Language to an Agent, Record or Record Part that uses
    ///             or used it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasLanguageOf"></see></summary>
    let isOrWasLanguageOf =
        Namespaced_IRI.parse _namespace_name "isOrWasLanguageOf" |> NamespacedName

    /// <summary>
    /// Inverse of 'is or was leader of' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadLeader"></see></summary>
    let hasOrHadLeader =
        Namespaced_IRI.parse _namespace_name "hasOrHadLeader" |> NamespacedName

    /// <summary>
    /// Connects a Person to the Group that Person leads or led in the
    ///             past.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasLeaderOf"></see></summary>
    let isOrWasLeaderOf =
        Namespaced_IRI.parse _namespace_name "isOrWasLeaderOf" |> NamespacedName

    /// <summary>
    /// Connects an Agent or Record Resource to a Legal Status which
    ///             categorized or categorizes it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadLegalStatus"></see></summary>
    let hasOrHadLegalStatus =
        Namespaced_IRI.parse _namespace_name "hasOrHadLegalStatus" |> NamespacedName

    /// <summary>
    /// Connects a Legal Status to an Agent or Record Resource that it
    ///             categorizes.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasLegalStatusOf"></see></summary>
    let isOrWasLegalStatusOf =
        Namespaced_IRI.parse _namespace_name "isOrWasLegalStatusOf" |> NamespacedName

    /// <summary>
    /// Inverse of 'is or was location of' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadLocation"></see></summary>
    let hasOrHadLocation =
        Namespaced_IRI.parse _namespace_name "hasOrHadLocation" |> NamespacedName

    /// <summary>
    /// Connects a Place to a Thing that is or was located in the
    ///             Place.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasLocationOf"></see></summary>
    let isOrWasLocationOf =
        Namespaced_IRI.parse _namespace_name "isOrWasLocationOf" |> NamespacedName

    /// <summary>
    /// Connects a Record Resource to a Thing that is or was its main
    ///             subject.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadMainSubject"></see></summary>
    let hasOrHadMainSubject =
        Namespaced_IRI.parse _namespace_name "hasOrHadMainSubject" |> NamespacedName

    /// <summary>
    /// Inverse of 'has or had main subject' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasMainSubjectOf"></see></summary>
    let isOrWasMainSubjectOf =
        Namespaced_IRI.parse _namespace_name "isOrWasMainSubjectOf" |> NamespacedName

    /// <summary>
    /// Connects an Agent to a Record Resource or Instantiation that the
    ///             Agent managed or manages.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasManagerOf"></see></summary>
    let isOrWasManagerOf =
        Namespaced_IRI.parse _namespace_name "isOrWasManagerOf" |> NamespacedName

    /// <summary>
    /// Connects a Record Resource or Instantiation (that is managed by
    ///             an Agent) to a Management Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsTargetOfManagementRelation"></see></summary>
    let recordResourceOrInstantiationIsTargetOfManagementRelation =
        Namespaced_IRI.parse _namespace_name "recordResourceOrInstantiationIsTargetOfManagementRelation" |> NamespacedName

    /// <summary>
    /// Connects a Group to a Person that is or was a member of that
    ///             Group.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadMember"></see></summary>
    let hasOrHadMember =
        Namespaced_IRI.parse _namespace_name "hasOrHadMember" |> NamespacedName

    /// <summary>
    /// Inverse of 'has or had member' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasMemberOf"></see></summary>
    let isOrWasMemberOf =
        Namespaced_IRI.parse _namespace_name "isOrWasMemberOf" |> NamespacedName

    /// <summary>
    /// Connects a Name to a Thing that it designated or
    ///             designates.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasNameOf"></see></summary>
    let isOrWasNameOf =
        Namespaced_IRI.parse _namespace_name "isOrWasNameOf" |> NamespacedName

    /// <summary>
    /// Inverse of 'is or was owner of' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadOwner"></see></summary>
    let hasOrHadOwner =
        Namespaced_IRI.parse _namespace_name "hasOrHadOwner" |> NamespacedName

    /// <summary>
    /// Connects a Group, Person or Position to a Thing that this Agent
    ///             owns or owned.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasOwnerOf"></see></summary>
    let isOrWasOwnerOf =
        Namespaced_IRI.parse _namespace_name "isOrWasOwnerOf" |> NamespacedName

    /// <summary>
    /// Connects a Thing (that is owned by a Group, a Person or a
    ///             Position) to an Ownership Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfOwnershipRelation"></see></summary>
    let thingIsTargetOfOwnershipRelation =
        Namespaced_IRI.parse _namespace_name "thingIsTargetOfOwnershipRelation" |> NamespacedName

    /// <summary>
    /// Inverse of 'has or had part' relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasPartOf"></see></summary>
    let isOrWasPartOf =
        Namespaced_IRI.parse _namespace_name "isOrWasPartOf" |> NamespacedName

    /// <summary>
    /// Connects an Event to a Thing that is associated with the
    ///             existence and lifecycle of the Event.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isEventAssociatedWith"></see></summary>
    let isEventAssociatedWith =
        Namespaced_IRI.parse _namespace_name "isEventAssociatedWith" |> NamespacedName

    /// <summary>
    /// Inverse of 'has or had participant' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasParticipantIn"></see></summary>
    let isOrWasParticipantIn =
        Namespaced_IRI.parse _namespace_name "isOrWasParticipantIn" |> NamespacedName

    /// <summary>
    /// Connects a Place to one of its past or present
    ///             names.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadPlaceName"></see></summary>
    let hasOrHadPlaceName =
        Namespaced_IRI.parse _namespace_name "hasOrHadPlaceName" |> NamespacedName

    /// <summary>
    /// Connects a Place Name to a Place that was or is designated by
    ///             it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasPlaceNameOf"></see></summary>
    let isOrWasPlaceNameOf =
        Namespaced_IRI.parse _namespace_name "isOrWasPlaceNameOf" |> NamespacedName

    /// <summary>
    /// Connects a Place to a Place Type that categorized or categorizes
    ///             it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadPlaceType"></see></summary>
    let hasOrHadPlaceType =
        Namespaced_IRI.parse _namespace_name "hasOrHadPlaceType" |> NamespacedName

    /// <summary>
    /// Connects a Record Set and a Category (Type) to which some of the
    ///             Records or Record Parts that are or were included in the Record Set
    ///             belong.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadSomeMembersWithCategory"></see></summary>
    let hasOrHadSomeMembersWithCategory =
        Namespaced_IRI.parse _namespace_name "hasOrHadSomeMembersWithCategory" |> NamespacedName

    /// <summary>
    /// Connects a Category (Type) and a Record Set whose some present
    ///             or past Record or Record Part members belong to that Category.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasCategoryOfSomeMembersOf"></see></summary>
    let isOrWasCategoryOfSomeMembersOf =
        Namespaced_IRI.parse _namespace_name "isOrWasCategoryOfSomeMembersOf" |> NamespacedName

    /// <summary>
    /// Connects a Record Set and a Content Type that categorizes some
    ///             of the Records or Record Parts that are or were included in the Record
    ///             Set.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadSomeMembersWithContentType"></see></summary>
    let hasOrHadSomeMembersWithContentType =
        Namespaced_IRI.parse _namespace_name "hasOrHadSomeMembersWithContentType" |> NamespacedName

    /// <summary>
    /// Connects a Content Type and a Record Set whose some past or
    ///             present Record or Record Part members have that Content Type.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasContentTypeOfSomeMembersOf"></see></summary>
    let isOrWasContentTypeOfSomeMembersOf =
        Namespaced_IRI.parse _namespace_name "isOrWasContentTypeOfSomeMembersOf" |> NamespacedName

    /// <summary>
    /// Connects a Record Set and a Language used by some of the Records
    ///             or Record Parts that are or were included in the Record Set.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadSomeMembersWithLanguage"></see></summary>
    let hasOrHadSomeMembersWithLanguage =
        Namespaced_IRI.parse _namespace_name "hasOrHadSomeMembersWithLanguage" |> NamespacedName

    /// <summary>
    /// Connects a Language and a Record Set whose some present or past
    ///             Record or Record Part members use that Language.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasLanguageOfSomeMembersOf"></see></summary>
    let isOrWasLanguageOfSomeMembersOf =
        Namespaced_IRI.parse _namespace_name "isOrWasLanguageOfSomeMembersOf" |> NamespacedName

    /// <summary>
    /// Connects a Record Set and a Legal Status that categorizes some
    ///             of the Records or Record Parts that are or were included in the Record
    ///             Set.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadSomeMembersWithLegalStatus"></see></summary>
    let hasOrHadSomeMembersWithLegalStatus =
        Namespaced_IRI.parse _namespace_name "hasOrHadSomeMembersWithLegalStatus" |> NamespacedName

    /// <summary>
    /// Connects a Legal Status and a Record Set whose some past or
    ///             present Record or Record Part members have that Legal Status.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasLegalStatusOfSomeMembersOf"></see></summary>
    let isOrWasLegalStatusOfSomeMembersOf =
        Namespaced_IRI.parse _namespace_name "isOrWasLegalStatusOfSomeMembersOf" |> NamespacedName

    /// <summary>
    /// Connects a Record Set and a Record State that categorizes some
    ///             of the Records or Record Parts that are or were included in the Record
    ///             Set.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadSomeMembersWithRecordState"></see></summary>
    let hasOrHadSomeMembersWithRecordState =
        Namespaced_IRI.parse _namespace_name "hasOrHadSomeMembersWithRecordState" |> NamespacedName

    /// <summary>
    /// Connects a Record State and a Record Set whose some past or
    ///             present Record or Record Part members have that Record State.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasRecordStateOfSomeMembersOf"></see></summary>
    let isOrWasRecordStateOfSomeMembersOf =
        Namespaced_IRI.parse _namespace_name "isOrWasRecordStateOfSomeMembersOf" |> NamespacedName

    /// <summary>
    /// Connects a Record Set and a Documentary Form Type that
    ///             categorizes some of the Records or Record Parts that are or were included in the Record
    ///             Set.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadSomeMemberswithDocumentaryFormType"></see></summary>
    let hasOrHadSomeMemberswithDocumentaryFormType =
        Namespaced_IRI.parse _namespace_name "hasOrHadSomeMemberswithDocumentaryFormType" |> NamespacedName

    /// <summary>
    /// Connects a Documentary Form Type and a Record Set whose some
    ///             past or present Record or Record Part members have that Documentary Form
    ///             Type.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasDocumentaryFormTypeOfSomeMembersOf"></see></summary>
    let isOrWasDocumentaryFormTypeOfSomeMembersOf =
        Namespaced_IRI.parse _namespace_name "isOrWasDocumentaryFormTypeOfSomeMembersOf" |> NamespacedName

    /// <summary>
    /// Connects two Persons that are or were married. This relation is
    ///             symmetric.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadSpouse"></see></summary>
    let hasOrHadSpouse =
        Namespaced_IRI.parse _namespace_name "hasOrHadSpouse" |> NamespacedName

    /// <summary>
    /// Connects a Person to a Spouse Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#personHasSpouseRelation"></see></summary>
    let personHasSpouseRelation =
        Namespaced_IRI.parse _namespace_name "personHasSpouseRelation" |> NamespacedName

    /// <summary>
    /// Inverse of 'has or had teacher' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadStudent"></see></summary>
    let hasOrHadStudent =
        Namespaced_IRI.parse _namespace_name "hasOrHadStudent" |> NamespacedName

    /// <summary>
    /// Connects a Person to another Person who is or was their
    ///             student.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadTeacher"></see></summary>
    let hasOrHadTeacher =
        Namespaced_IRI.parse _namespace_name "hasOrHadTeacher" |> NamespacedName

    /// <summary>
    /// Connects a Person (as a teacher) to a Teaching
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#personIsSourceOfTeachingRelation"></see></summary>
    let personIsSourceOfTeachingRelation =
        Namespaced_IRI.parse _namespace_name "personIsSourceOfTeachingRelation" |> NamespacedName

    /// <summary>
    /// Connects a Group to one of its present or past
    ///             subdivisions.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadSubdivision"></see></summary>
    let hasOrHadSubdivision =
        Namespaced_IRI.parse _namespace_name "hasOrHadSubdivision" |> NamespacedName

    /// <summary>
    /// Connects an Agent to an Agent that is hierarchically
    ///             inferior.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadSubordinate"></see></summary>
    let hasOrHadSubordinate =
        Namespaced_IRI.parse _namespace_name "hasOrHadSubordinate" |> NamespacedName

    /// <summary>
    /// Inverse of 'has or had subdivision' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasSubdivisionOf"></see></summary>
    let isOrWasSubdivisionOf =
        Namespaced_IRI.parse _namespace_name "isOrWasSubdivisionOf" |> NamespacedName

    /// <summary>
    /// Connects an Event to one of a series of Events that constitute
    ///             the original, broader, past or ongoing Event.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadSubevent"></see></summary>
    let hasOrHadSubevent =
        Namespaced_IRI.parse _namespace_name "hasOrHadSubevent" |> NamespacedName

    /// <summary>
    /// Inverse of 'is event associated with' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isAssociatedWithEvent"></see></summary>
    let isAssociatedWithEvent =
        Namespaced_IRI.parse _namespace_name "isAssociatedWithEvent" |> NamespacedName

    /// <summary>
    /// Inverse of 'has or had subevent' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasSubeventOf"></see></summary>
    let isOrWasSubeventOf =
        Namespaced_IRI.parse _namespace_name "isOrWasSubeventOf" |> NamespacedName

    /// <summary>
    /// Inverse of 'has or had subject' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasSubjectOf"></see></summary>
    let isOrWasSubjectOf =
        Namespaced_IRI.parse _namespace_name "isOrWasSubjectOf" |> NamespacedName

    /// <summary>
    /// Connects a Person (as a student) to a Teaching
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#personIsTargetOfTeachingRelation"></see></summary>
    let personIsTargetOfTeachingRelation =
        Namespaced_IRI.parse _namespace_name "personIsTargetOfTeachingRelation" |> NamespacedName

    /// <summary>
    /// Connects a Record Resource, Instantiation or Rule to a title
    ///             that is or was used for designating it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadTitle"></see></summary>
    let hasOrHadTitle =
        Namespaced_IRI.parse _namespace_name "hasOrHadTitle" |> NamespacedName

    /// <summary>
    /// Connects a Title to a Record Resource, Instantiation or Rule
    ///             that it designated or designates.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasTitleOf"></see></summary>
    let isOrWasTitleOf =
        Namespaced_IRI.parse _namespace_name "isOrWasTitleOf" |> NamespacedName

    /// <summary>
    /// Connects two Agents that have or had some type of work relation
    ///             in the course of their activities. This relation is symmetric.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOrHadWorkRelationWith"></see></summary>
    let hasOrHadWorkRelationWith =
        Namespaced_IRI.parse _namespace_name "hasOrHadWorkRelationWith" |> NamespacedName

    /// <summary>
    /// Inverse of 'is original of' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasOriginal"></see></summary>
    let hasOriginal =
        Namespaced_IRI.parse _namespace_name "hasOriginal" |> NamespacedName

    /// <summary>
    /// Connects the original version of a Record to a copy or a later
    ///             version.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOriginalOf"></see></summary>
    let isOriginalOf =
        Namespaced_IRI.parse _namespace_name "isOriginalOf" |> NamespacedName

    /// <summary>
    /// inverse of 'has provenance' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isProvenanceOf"></see></summary>
    let isProvenanceOf =
        Namespaced_IRI.parse _namespace_name "isProvenanceOf" |> NamespacedName

    /// <summary>
    /// Connects a Record resource to an Agent who published
    ///             it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasPublisher"></see></summary>
    let hasPublisher =
        Namespaced_IRI.parse _namespace_name "hasPublisher" |> NamespacedName

    /// <summary>
    /// Connects an Agent to a Record Resource that it
    ///             published.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isPublisherOf"></see></summary>
    let isPublisherOf =
        Namespaced_IRI.parse _namespace_name "isPublisherOf" |> NamespacedName

    /// <summary>
    /// Connects a Record Resource or an Instantiation to the Agent that
    ///             receives it in the course of its activities.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasReceiver"></see></summary>
    let hasReceiver =
        Namespaced_IRI.parse _namespace_name "hasReceiver" |> NamespacedName

    /// <summary>
    /// Inverse of 'received by' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isReceiverOf"></see></summary>
    let isReceiverOf =
        Namespaced_IRI.parse _namespace_name "isReceiverOf" |> NamespacedName

    /// <summary>
    /// Connects a Record or Record Part to a Record State that
    ///             categorizes its state.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasRecordState"></see></summary>
    let hasRecordState =
        Namespaced_IRI.parse _namespace_name "hasRecordState" |> NamespacedName

    /// <summary>
    /// Connects a Record State to a Record or Record Part whose state
    ///             it categorizes.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isRecordStateOf"></see></summary>
    let isRecordStateOf =
        Namespaced_IRI.parse _namespace_name "isRecordStateOf" |> NamespacedName

    /// <summary>
    /// Connects a Record Resource to a reply, usually in the form of
    ///             correspondence.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasReply"></see></summary>
    let hasReply = Namespaced_IRI.parse _namespace_name "hasReply" |> NamespacedName
    /// <summary>
    /// Inverse of 'has reply' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isReplyTo"></see></summary>
    let isReplyTo = Namespaced_IRI.parse _namespace_name "isReplyTo" |> NamespacedName
    /// <summary>
    /// Connects a Record Resource or an Instantiation to the Agent that
    ///             sends it
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasSender"></see></summary>
    let hasSender = Namespaced_IRI.parse _namespace_name "hasSender" |> NamespacedName
    /// <summary>
    /// Inverse of 'has sender' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isSenderOf"></see></summary>
    let isSenderOf = Namespaced_IRI.parse _namespace_name "isSenderOf" |> NamespacedName
    /// <summary>
    /// Connects two Persons that are siblings. This relation is
    ///             symmetric.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasSibling"></see></summary>
    let hasSibling = Namespaced_IRI.parse _namespace_name "hasSibling" |> NamespacedName

    /// <summary>
    /// Connects a Person to a Sibling Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#personHasSiblingRelation"></see></summary>
    let personHasSiblingRelation =
        Namespaced_IRI.parse _namespace_name "personHasSiblingRelation" |> NamespacedName

    /// <summary>
    /// Connects a Record Resource or Relation to a Record Resource or
    ///             Agent that is used as a source of information for identifying or describing
    ///             it.
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasSource"></see></summary>
    let hasSource = Namespaced_IRI.parse _namespace_name "hasSource" |> NamespacedName
    /// <summary>
    /// Connects a Record Resource or an Agent to a Record Resource or
    ///             Relation, when the first is used as a source of information for identifying or
    ///             describing the second one.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isSourceOf"></see></summary>
    let isSourceOf = Namespaced_IRI.parse _namespace_name "isSourceOf" |> NamespacedName

    /// <summary>
    /// Connects an Extent to a Unit Of Measurement
    /// <see href="https://www.ica.org/standards/RiC/ontology#hasUnitOfMeasurement"></see></summary>
    let hasUnitOfMeasurement =
        Namespaced_IRI.parse _namespace_name "hasUnitOfMeasurement" |> NamespacedName

    /// <summary>
    /// Inverse of 'has unit of measurement' object property
    /// <see href="https://www.ica.org/standards/RiC/ontology#isUnitOfMeasurementOf"></see></summary>
    let isUnitOfMeasurementOf =
        Namespaced_IRI.parse _namespace_name "isUnitOfMeasurementOf" |> NamespacedName

    /// <summary>
    /// Vertical dimension of an entity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#height"></see></summary>
    let height = Namespaced_IRI.parse _namespace_name "height" |> NamespacedName
    /// <summary>
    /// Summary of the development of an entity, since its origin until
    ///             present time.
    /// <see href="https://www.ica.org/standards/RiC/ontology#history"></see></summary>
    let history = Namespaced_IRI.parse _namespace_name "history" |> NamespacedName
    /// <summary>
    /// A word, number, letter, symbol, or any combination of these used
    ///             to uniquely identify or reference an individual instance of an entity within a specific
    ///             information domain. Includes Global Persistent Identifiers (globally unique and
    ///             persistently resolvable identifier for the entity) and/or Local
    ///             Identifiers.
    /// <see href="https://www.ica.org/standards/RiC/ontology#identifier"></see></summary>
    let identifier = Namespaced_IRI.parse _namespace_name "identifier" |> NamespacedName

    /// <summary>
    /// Connects a Record Set to a Record or Record Set it aggregates,
    ///             or aggregated in the past.
    /// <see href="https://www.ica.org/standards/RiC/ontology#includesOrIncluded"></see></summary>
    let includesOrIncluded =
        Namespaced_IRI.parse _namespace_name "includesOrIncluded" |> NamespacedName

    /// <summary>
    /// Inverse of 'includes or included' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasIncludedIn"></see></summary>
    let isOrWasIncludedIn =
        Namespaced_IRI.parse _namespace_name "isOrWasIncludedIn" |> NamespacedName

    /// <summary>
    /// Countable characteristics of the Instantiation expressed as a
    ///             quantity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#instantiationExtent"></see></summary>
    let instantiationExtent =
        Namespaced_IRI.parse _namespace_name "instantiationExtent" |> NamespacedName

    /// <summary>
    /// Connects an Instantiation to an Instantiation to Instantiation
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#instantiationIsConnectedToInstantiationRelation"></see></summary>
    let instantiationIsConnectedToInstantiationRelation =
        Namespaced_IRI.parse _namespace_name "instantiationIsConnectedToInstantiationRelation" |> NamespacedName

    /// <summary>
    /// Connects an Instantiation (from which at least one Instantiation
    ///             is migrated) to a Migration Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#instantiationIsSourceOfMigrationRelation"></see></summary>
    let instantiationIsSourceOfMigrationRelation =
        Namespaced_IRI.parse _namespace_name "instantiationIsSourceOfMigrationRelation" |> NamespacedName

    /// <summary>
    /// Connects an Instantiation which results from a migration, to a
    ///             Migration Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#instantiationIsTargetOfMigrationRelation"></see></summary>
    let instantiationIsTargetOfMigrationRelation =
        Namespaced_IRI.parse _namespace_name "instantiationIsTargetOfMigrationRelation" |> NamespacedName

    /// <summary>
    /// Connects an Instantiation of a Record Resource to the Record
    ///             Resource to Instantiation Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#instantiationIsTargetOfRecordResourceToInstantiationRelation"></see></summary>
    let instantiationIsTargetOfRecordResourceToInstantiationRelation =
        Namespaced_IRI.parse _namespace_name "instantiationIsTargetOfRecordResourceToInstantiationRelation" |> NamespacedName

    /// <summary>
    /// Information about the physical arrangement and composition of an
    ///             Instantiation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#instantiationStructure"></see></summary>
    let instantiationStructure =
        Namespaced_IRI.parse _namespace_name "instantiationStructure" |> NamespacedName

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
    let structure = Namespaced_IRI.parse _namespace_name "structure" |> NamespacedName
    /// <summary>
    /// Information about the completeness of a Record Resource or
    ///             Instantiation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#integrity"></see></summary>
    let integrity = Namespaced_IRI.parse _namespace_name "integrity" |> NamespacedName

    /// <summary>
    /// Connects a Date to a Thing that the Date is associated with the
    ///             existence and lifecycle of.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isDateAssociatedWith"></see></summary>
    let isDateAssociatedWith =
        Namespaced_IRI.parse _namespace_name "isDateAssociatedWith" |> NamespacedName

    /// <summary>
    /// Connects a Thing (that is associated with a Place) to a Place
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#thingIsTargetOfPlaceRelation"></see></summary>
    let thingIsTargetOfPlaceRelation =
        Namespaced_IRI.parse _namespace_name "thingIsTargetOfPlaceRelation" |> NamespacedName

    /// <summary>
    /// Connects two Things that are considered
    ///             equivalent.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isEquivalentTo"></see></summary>
    let isEquivalentTo =
        Namespaced_IRI.parse _namespace_name "isEquivalentTo" |> NamespacedName

    /// <summary>
    /// Connects a Date to an Appellation, when it is the date at which
    ///             the Appellation was first used.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isFromUseDateOf"></see></summary>
    let isFromUseDateOf =
        Namespaced_IRI.parse _namespace_name "isFromUseDateOf" |> NamespacedName

    /// <summary>
    /// Connects an Appellation to the Date from which it was
    ///             used.
    /// <see href="https://www.ica.org/standards/RiC/ontology#wasUsedFromDate"></see></summary>
    let wasUsedFromDate =
        Namespaced_IRI.parse _namespace_name "wasUsedFromDate" |> NamespacedName

    /// <summary>
    /// Connects two Instantiations which may be considered as
    ///             equivalent. This relation is symmetric.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isFunctionallyEquivalentTo"></see></summary>
    let isFunctionallyEquivalentTo =
        Namespaced_IRI.parse _namespace_name "isFunctionallyEquivalentTo" |> NamespacedName

    /// <summary>
    /// Connects a Date and a Thing that was last modified at this
    ///             Date.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isLastUpdateDateOf"></see></summary>
    let isLastUpdateDateOf =
        Namespaced_IRI.parse _namespace_name "isLastUpdateDateOf" |> NamespacedName

    /// <summary>
    /// Connects a Thing to the Date when it was last
    ///             modified.
    /// <see href="https://www.ica.org/standards/RiC/ontology#wasLastUpdatedAtDate"></see></summary>
    let wasLastUpdatedAtDate =
        Namespaced_IRI.parse _namespace_name "wasLastUpdatedAtDate" |> NamespacedName

    /// <summary>
    /// Connects two Places that are or were geographically adjacent.
    ///             This is a symmetric object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasAdjacentTo"></see></summary>
    let isOrWasAdjacentTo =
        Namespaced_IRI.parse _namespace_name "isOrWasAdjacentTo" |> NamespacedName

    /// <summary>
    /// Connects a Type (a category) to a Type Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#typeIsSourceOfTypeRelation"></see></summary>
    let typeIsSourceOfTypeRelation =
        Namespaced_IRI.parse _namespace_name "typeIsSourceOfTypeRelation" |> NamespacedName

    /// <summary>
    /// Connects a Rule to an Agent that enforces or enforced the
    ///             Rule.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasEnforcedBy"></see></summary>
    let isOrWasEnforcedBy =
        Namespaced_IRI.parse _namespace_name "isOrWasEnforcedBy" |> NamespacedName

    /// <summary>
    /// Inverse of 'is or was enforced by' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasResponsibleForEnforcing"></see></summary>
    let isOrWasResponsibleForEnforcing =
        Namespaced_IRI.parse _namespace_name "isOrWasResponsibleForEnforcing" |> NamespacedName

    /// <summary>
    /// Connects a Person (as a leader) to a Leadership
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#personIsSourceOfLeadershipRelation"></see></summary>
    let personIsSourceOfLeadershipRelation =
        Namespaced_IRI.parse _namespace_name "personIsSourceOfLeadershipRelation" |> NamespacedName

    /// <summary>
    /// Connects a Person (as a member of a Group) to a Membership
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#personIsTargetOfMembershipRelation"></see></summary>
    let personIsTargetOfMembershipRelation =
        Namespaced_IRI.parse _namespace_name "personIsTargetOfMembershipRelation" |> NamespacedName

    /// <summary>
    /// Inverse of 'occupies or occupied' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasOccupiedBy"></see></summary>
    let isOrWasOccupiedBy =
        Namespaced_IRI.parse _namespace_name "isOrWasOccupiedBy" |> NamespacedName

    /// <summary>
    /// Connects a Person to a Position they occupy or
    ///             occupied.
    /// <see href="https://www.ica.org/standards/RiC/ontology#occupiesOrOccupied"></see></summary>
    let occupiesOrOccupied =
        Namespaced_IRI.parse _namespace_name "occupiesOrOccupied" |> NamespacedName

    /// <summary>
    /// Connects a Position (that is occupied by a Person) to a Position
    ///             Holding Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#positionIsTargetOfPositionHoldingRelation"></see></summary>
    let positionIsTargetOfPositionHoldingRelation =
        Namespaced_IRI.parse _namespace_name "positionIsTargetOfPositionHoldingRelation" |> NamespacedName

    /// <summary>
    /// Inverse of 'is or was performed by' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#performsOrPerformed"></see></summary>
    let performsOrPerformed =
        Namespaced_IRI.parse _namespace_name "performsOrPerformed" |> NamespacedName

    /// <summary>
    /// Inverse of the 'regulates or regulated' object
    ///             property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isOrWasRegulatedBy"></see></summary>
    let isOrWasRegulatedBy =
        Namespaced_IRI.parse _namespace_name "isOrWasRegulatedBy" |> NamespacedName

    /// <summary>
    /// Connects a Rule to a Thing that it regulates or
    ///             regulated.
    /// <see href="https://www.ica.org/standards/RiC/ontology#regulatesOrRegulated"></see></summary>
    let regulatesOrRegulated =
        Namespaced_IRI.parse _namespace_name "regulatesOrRegulated" |> NamespacedName

    /// <summary>
    /// Connects a Place (as associated to a Thing) to a Place
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#placeIsSourceOfPlaceRelation"></see></summary>
    let placeIsSourceOfPlaceRelation =
        Namespaced_IRI.parse _namespace_name "placeIsSourceOfPlaceRelation" |> NamespacedName

    /// <summary>
    /// Connects a Record Resource to a Record Resource
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordResourceIsConnectedToRecordResourceRelation"></see></summary>
    let recordResourceIsConnectedToRecordResourceRelation =
        Namespaced_IRI.parse _namespace_name "recordResourceIsConnectedToRecordResourceRelation" |> NamespacedName

    /// <summary>
    /// Inverse of 'issued by' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isResponsibleForIssuing"></see></summary>
    let isResponsibleForIssuing =
        Namespaced_IRI.parse _namespace_name "isResponsibleForIssuing" |> NamespacedName

    /// <summary>
    /// Connects a Rule to the Agent that issued or published the
    ///             Rule.
    /// <see href="https://www.ica.org/standards/RiC/ontology#issuedBy"></see></summary>
    let issuedBy = Namespaced_IRI.parse _namespace_name "issuedBy" |> NamespacedName

    /// <summary>
    /// Connects a Rule to a Rule Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#ruleIsSourceOfRuleRelation"></see></summary>
    let ruleIsSourceOfRuleRelation =
        Namespaced_IRI.parse _namespace_name "ruleIsSourceOfRuleRelation" |> NamespacedName

    /// <summary>
    /// Connects a Date to an Appellation, when it is the date till
    ///             which the Appellation was used.
    /// <see href="https://www.ica.org/standards/RiC/ontology#isToUseDateOf"></see></summary>
    let isToUseDateOf =
        Namespaced_IRI.parse _namespace_name "isToUseDateOf" |> NamespacedName

    /// <summary>
    /// Connects an Appellation to the Date till when it was
    ///             used.
    /// <see href="https://www.ica.org/standards/RiC/ontology#wasUsedToDate"></see></summary>
    let wasUsedToDate =
        Namespaced_IRI.parse _namespace_name "wasUsedToDate" |> NamespacedName

    /// <summary>
    /// Connects a Person (who has some knowledge of another one) to a
    ///             Knowing Of Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#personIsSourceOfKnowingOfRelation"></see></summary>
    let personIsSourceOfKnowingOfRelation =
        Namespaced_IRI.parse _namespace_name "personIsSourceOfKnowingOfRelation" |> NamespacedName

    /// <summary>
    /// Connects a Person (of which another Person has some knowledge)
    ///             to a Knowing Of Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#personIsTargetOfKnowingOfRelation"></see></summary>
    let personIsTargetOfKnowingOfRelation =
        Namespaced_IRI.parse _namespace_name "personIsTargetOfKnowingOfRelation" |> NamespacedName

    /// <summary>
    /// Connects a Person to a Knowing Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#personHasKnowingRelation"></see></summary>
    let personHasKnowingRelation =
        Namespaced_IRI.parse _namespace_name "personHasKnowingRelation" |> NamespacedName

    /// <summary>
    /// Inverse of 'knows of' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#knownBy"></see></summary>
    let knownBy = Namespaced_IRI.parse _namespace_name "knownBy" |> NamespacedName
    /// <summary>
    /// Connects a Person to another Person they have some knowledge of
    ///             through time or space.
    /// <see href="https://www.ica.org/standards/RiC/ontology#knowsOf"></see></summary>
    let knowsOf = Namespaced_IRI.parse _namespace_name "knowsOf" |> NamespacedName

    /// <summary>
    /// Date at which an entity was last updated.
    /// <see href="https://www.ica.org/standards/RiC/ontology#lastModificationDate"></see></summary>
    let lastModificationDate =
        Namespaced_IRI.parse _namespace_name "lastModificationDate" |> NamespacedName

    /// <summary>
    /// Date of the modification of an entity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#modificationDate"></see></summary>
    let modificationDate =
        Namespaced_IRI.parse _namespace_name "modificationDate" |> NamespacedName

    /// <summary>
    /// Distance in degrees north or south of the
    ///             equator.
    /// <see href="https://www.ica.org/standards/RiC/ontology#latitude"></see></summary>
    let latitude = Namespaced_IRI.parse _namespace_name "latitude" |> NamespacedName

    /// <summary>
    /// Connects a Position to a Leadership Relation (the leading Person
    ///             occupies that Position).
    /// <see href="https://www.ica.org/standards/RiC/ontology#positionIsContextOfLeadershipRelation"></see></summary>
    let positionIsContextOfLeadershipRelation =
        Namespaced_IRI.parse _namespace_name "positionIsContextOfLeadershipRelation" |> NamespacedName

    /// <summary>
    /// A delimitation of the physical territory of a place. This
    ///             datatype property is used to describe basic human-readable text such as an address, a
    ///             cadastral reference, or less precise information found in a record.
    /// <see href="https://www.ica.org/standards/RiC/ontology#location"></see></summary>
    let location = Namespaced_IRI.parse _namespace_name "location" |> NamespacedName
    /// <summary>
    /// Distance in degrees east or west of a prime
    ///             meridian.
    /// <see href="https://www.ica.org/standards/RiC/ontology#longitude"></see></summary>
    let longitude = Namespaced_IRI.parse _namespace_name "longitude" |> NamespacedName

    /// <summary>
    /// Connects a Position to a Membership Relation (the member Person
    ///             occupies that Position).
    /// <see href="https://www.ica.org/standards/RiC/ontology#positionIsContextOfMembershipRelation"></see></summary>
    let positionIsContextOfMembershipRelation =
        Namespaced_IRI.parse _namespace_name "positionIsContextOfMembershipRelation" |> NamespacedName

    /// <summary>
    /// Inverse of 'migrated into' object property.
    /// <see href="https://www.ica.org/standards/RiC/ontology#migratedFrom"></see></summary>
    let migratedFrom =
        Namespaced_IRI.parse _namespace_name "migratedFrom" |> NamespacedName

    /// <summary>
    /// Connects an Instantiation to a version it has been migrated
    ///             to.
    /// <see href="https://www.ica.org/standards/RiC/ontology#migratedInto"></see></summary>
    let migratedInto =
        Namespaced_IRI.parse _namespace_name "migratedInto" |> NamespacedName

    /// <summary>
    /// A label, title or term designating the entity in order to make
    ///             it distinguishable from other similar entities. For Record Resource or Instantiation,
    ///             the Name is generally assigned by an Agent as most do not have a Name given when
    ///             created.
    /// <see href="https://www.ica.org/standards/RiC/ontology#name"></see></summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName

    /// <summary>
    /// Date representation based on a standard, preferably
    ///             machine-readable.
    /// <see href="https://www.ica.org/standards/RiC/ontology#normalizedDateValue"></see></summary>
    let normalizedDateValue =
        Namespaced_IRI.parse _namespace_name "normalizedDateValue" |> NamespacedName

    /// <summary>
    /// Value representation based on a standard, preferably
    ///             machine-readable.
    /// <see href="https://www.ica.org/standards/RiC/ontology#normalizedValue"></see></summary>
    let normalizedValue =
        Namespaced_IRI.parse _namespace_name "normalizedValue" |> NamespacedName

    /// <summary>
    /// Connects a Person (who occupies a Position) to a Position
    ///             Holding Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#personIsSourceOfPositionHoldingRelation"></see></summary>
    let personIsSourceOfPositionHoldingRelation =
        Namespaced_IRI.parse _namespace_name "personIsSourceOfPositionHoldingRelation" |> NamespacedName

    /// <summary>
    /// Connects two Places that geographically overlap or overlapped.
    ///             This object property is symmetric.
    /// <see href="https://www.ica.org/standards/RiC/ontology#overlapsOrOverlapped"></see></summary>
    let overlapsOrOverlapped =
        Namespaced_IRI.parse _namespace_name "overlapsOrOverlapped" |> NamespacedName

    /// <summary>
    /// Information about the physical features of the Instantiation.
    ///             Includes information about the physical nature and condition such as conservation
    ///             status.
    /// <see href="https://www.ica.org/standards/RiC/ontology#physicalCharacteristics"></see></summary>
    let physicalCharacteristics =
        Namespaced_IRI.parse _namespace_name "physicalCharacteristics" |> NamespacedName

    /// <summary>
    /// Connects a Thing to a Sequential Relation, when this Thing
    ///             precedes other Thing(s) in the sequence.
    /// <see href="https://www.ica.org/standards/RiC/ontology#thingIsSourceOfSequentialRelation"></see></summary>
    let thingIsSourceOfSequentialRelation =
        Namespaced_IRI.parse _namespace_name "thingIsSourceOfSequentialRelation" |> NamespacedName

    /// <summary>
    /// Method used in the representation of information on the
    ///             Instantiation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#productionTechnique"></see></summary>
    let productionTechnique =
        Namespaced_IRI.parse _namespace_name "productionTechnique" |> NamespacedName

    /// <summary>
    /// Connects a Record Resource or Instantiation (that is created or
    ///             accumulated by an Agent, or documents an Activity) to a Provenance
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordResourceOrInstantiationIsSourceOfProvenanceRelation"></see></summary>
    let recordResourceOrInstantiationIsSourceOfProvenanceRelation =
        Namespaced_IRI.parse _namespace_name "recordResourceOrInstantiationIsSourceOfProvenanceRelation" |> NamespacedName

    /// <summary>
    /// Date of the publication of a Record Resource.
    /// <see href="https://www.ica.org/standards/RiC/ontology#publicationDate"></see></summary>
    let publicationDate =
        Namespaced_IRI.parse _namespace_name "publicationDate" |> NamespacedName

    /// <summary>
    /// Conditions of an Instantiation that impact the legibility or
    ///             completeness of Record Resource, and thus the viability of its use. Conditions may be
    ///             associated with deficiencies in the processes of Record (re)creation or capture, or the
    ///             deterioration of the Instantiation (e.g. its carrier) causing loss of information of the
    ///             record over time
    /// <see href="https://www.ica.org/standards/RiC/ontology#qualityOfRepresentation"></see></summary>
    let qualityOfRepresentation =
        Namespaced_IRI.parse _namespace_name "qualityOfRepresentation" |> NamespacedName

    /// <summary>
    /// Machine-readable quantity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#quantity"></see></summary>
    let quantity = Namespaced_IRI.parse _namespace_name "quantity" |> NamespacedName

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
    let recordResourceExtent =
        Namespaced_IRI.parse _namespace_name "recordResourceExtent" |> NamespacedName

    /// <summary>
    /// Connects a Record Resource to a Record Resource Genetic
    ///             Relation.
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordResourceIsConnectedToRecordResourceGeneticRelation"></see></summary>
    let recordResourceIsConnectedToRecordResourceGeneticRelation =
        Namespaced_IRI.parse _namespace_name "recordResourceIsConnectedToRecordResourceGeneticRelation" |> NamespacedName

    /// <summary>
    /// Information about the intellectual arrangement and composition
    ///             of a Record Resource. For Record and Record Part, it encompasses information about the
    ///             intellectual composition of the record, the presence of record parts and their
    ///             functions. For Record Set, it encompasses information about the methodology or criteria
    ///             used for arranging the Record Set members or Record members within the containing Record
    ///             Set
    /// <see href="https://www.ica.org/standards/RiC/ontology#recordResourceStructure"></see></summary>
    let recordResourceStructure =
        Namespaced_IRI.parse _namespace_name "recordResourceStructure" |> NamespacedName

    /// <summary>
    /// Used to qualify the state of a Relation (e. g. present, past,
    ///             ongoing, unknown).
    /// <see href="https://www.ica.org/standards/RiC/ontology#relationState"></see></summary>
    let relationState =
        Namespaced_IRI.parse _namespace_name "relationState" |> NamespacedName

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
    let scopeAndContent =
        Namespaced_IRI.parse _namespace_name "scopeAndContent" |> NamespacedName

    /// <summary>
    /// Information about a source used to identify or describe an
    ///             entity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#source"></see></summary>
    let source = Namespaced_IRI.parse _namespace_name "source" |> NamespacedName

    /// <summary>
    /// Describes any relevant physical or software feature of any
    ///             device involved in the creation or management of a Record Resource.
    /// <see href="https://www.ica.org/standards/RiC/ontology#technicalCharacteristics"></see></summary>
    let technicalCharacteristics =
        Namespaced_IRI.parse _namespace_name "technicalCharacteristics" |> NamespacedName

    /// <summary>
    /// An identifying name of a Record Resource, Instantiation or
    ///             Rule.
    /// <see href="https://www.ica.org/standards/RiC/ontology#title"></see></summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName
    /// <summary>
    /// A term used to characterize an entity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#type"></see></summary>
    let type_ = Namespaced_IRI.parse _namespace_name "type" |> NamespacedName

    /// <summary>
    /// A definite magnitude of a quantity, defined and adopted by convention or by
    ///             law, that is used as a standard for measurement of the same kind of quantity. Can be
    ///             spacial units (cm, m), weight (g, kg), time (s, h), storage (MB, TB) or more informal
    ///             units used in the archival context like number of boxes, pages or words.
    /// <see href="https://www.ica.org/standards/RiC/ontology#unitOfMeasurement"></see></summary>
    let unitOfMeasurement =
        Namespaced_IRI.parse _namespace_name "unitOfMeasurement" |> NamespacedName

    /// <summary>
    /// Date at which an Appellation was first used.
    /// <see href="https://www.ica.org/standards/RiC/ontology#usedFromDate"></see></summary>
    let usedFromDate =
        Namespaced_IRI.parse _namespace_name "usedFromDate" |> NamespacedName

    /// <summary>
    /// Date until an Appellation was used.
    /// <see href="https://www.ica.org/standards/RiC/ontology#usedToDate"></see></summary>
    let usedToDate = Namespaced_IRI.parse _namespace_name "usedToDate" |> NamespacedName
    /// <summary>
    /// Horizontal dimension of an entity.
    /// <see href="https://www.ica.org/standards/RiC/ontology#width"></see></summary>
    let width = Namespaced_IRI.parse _namespace_name "width" |> NamespacedName
