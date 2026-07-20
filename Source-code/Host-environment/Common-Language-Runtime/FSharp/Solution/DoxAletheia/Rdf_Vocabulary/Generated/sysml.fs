namespace http.open_services.net.ns.sysmlv2.hash

open DoxAletheia

module sysml =
    let _namespace_name = "http://open-services.net/ns/sysmlv2#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An AcceptActionUsage is an ActionUsage that specifies the acceptance of an incomingTransfer from the Occurrence given by the result of its receiverArgument Expression. (If no receiverArgument is provided, the default is the this context of the AcceptActionUsage.) The payload of the accepted Transfer is output on its payloadParameter. Which Transfers may be accepted is determined by conformance to the typing and (potentially) binding of the payloadParameter.
    /// <see href="http://open-services.net/ns/sysmlv2#AcceptActionUsage"></see></summary>
    let AcceptActionUsage = _prefix "AcceptActionUsage"
    /// <summary>
    /// An ActionUsage is a Usage that is also a Step, and, so, is typed by a Behavior. Nominally, if the type is an ActionDefinition, an ActionUsage is a Usage of that ActionDefinition within a system. However, other kinds of kernel Behaviors are also allowed, to permit use of Behaviors from the Kernel Model Libraries.
    /// <see href="http://open-services.net/ns/sysmlv2#ActionUsage"></see></summary>
    let ActionUsage = _prefix "ActionUsage"
    /// <summary>
    /// An ActionDefinition is a Definition that is also a Behavior that defines an Action performed by a system or part of a system.
    /// <see href="http://open-services.net/ns/sysmlv2#ActionDefinition"></see></summary>
    let ActionDefinition = _prefix "ActionDefinition"
    /// <summary>
    /// A Behavior coordinates occurrences of other Behaviors, as well as changes in objects. Behaviors can be decomposed into Steps and be characterized by parameters.
    /// <see href="http://open-services.net/ns/sysmlv2#Behavior"></see></summary>
    let Behavior = _prefix "Behavior"
    /// <summary>
    /// An OccurrenceDefinition is a Definition of a Class of individuals that have an independent life over time and potentially an extent over space. This includes both structural things and behaviors that act on such structures.
    /// <see href="http://open-services.net/ns/sysmlv2#OccurrenceDefinition"></see></summary>
    let OccurrenceDefinition = _prefix "OccurrenceDefinition"
    /// <summary>
    /// An OccurrenceUsage is a Usage whose types are all Classes. Nominally, if a type is an OccurrenceDefinition, an OccurrenceUsage is a Usage of that OccurrenceDefinition within a system. However, other types of Kernel Classes are also allowed, to permit use of Classes from the Kernel Model Libraries.
    /// <see href="http://open-services.net/ns/sysmlv2#OccurrenceUsage"></see></summary>
    let OccurrenceUsage = _prefix "OccurrenceUsage"
    /// <summary>
    /// A Step is a Feature that is typed by one or more Behaviors. Steps may be used by one Behavior to coordinate the performance of other Behaviors, supporting a steady refinement of behavioral descriptions. Steps can be ordered in time and can be connected using ItemFlows to specify things flowing between their parameters.
    /// <see href="http://open-services.net/ns/sysmlv2#Step"></see></summary>
    let Step = _prefix "Step"
    /// <summary>
    /// An ActorMembership is a ParameterMembership that identifies a PartUsage as an actor parameter, which specifies a role played by an external entity in interaction with the owningType of the ActorMembership.
    /// <see href="http://open-services.net/ns/sysmlv2#ActorMembership"></see></summary>
    let ActorMembership = _prefix "ActorMembership"
    /// <summary>
    /// A ParameterMembership is a FeatureMembership that identifies its memberFeature as a parameter, which is always owned, and must have a direction. A ParameterMembership must be owned by a Behavior or a Step.
    /// <see href="http://open-services.net/ns/sysmlv2#ParameterMembership"></see></summary>
    let ParameterMembership = _prefix "ParameterMembership"
    /// <summary>
    /// An AllocationDefinition is a ConnectionDefinition that specifies that some or all of the responsibility to realize the intent of the source is allocated to the target instances. Such allocations define mappings across the various structures and hierarchies of a system model, perhaps as a precursor to more rigorous specifications and implementations. An AllocationDefinition can itself be refined using nested allocations that give a finer-grained decomposition of the containing allocation mapping.
    /// <see href="http://open-services.net/ns/sysmlv2#AllocationDefinition"></see></summary>
    let AllocationDefinition = _prefix "AllocationDefinition"
    /// <summary>
    /// A ConnectionDefinition is a PartDefinition that is also an AssociationStructure. The end Features of a ConnectionDefinition must be Usages.
    /// <see href="http://open-services.net/ns/sysmlv2#ConnectionDefinition"></see></summary>
    let ConnectionDefinition = _prefix "ConnectionDefinition"
    /// <summary>
    /// An AllocationUsage is a usage of an AllocationDefinition asserting the allocation of the source feature to the target feature.
    /// <see href="http://open-services.net/ns/sysmlv2#AllocationUsage"></see></summary>
    let AllocationUsage = _prefix "AllocationUsage"
    /// <summary>
    /// A ConnectionUsage is a ConnectorAsUsage that is also a PartUsage. Nominally, if its type is a ConnectionDefinition, then a ConnectionUsage is a Usage of that ConnectionDefinition, representing a connection between parts of a system. However, other kinds of kernel AssociationStructures are also allowed, to permit use of AssociationStructures from the Kernel Model Libraries.
    /// <see href="http://open-services.net/ns/sysmlv2#ConnectionUsage"></see></summary>
    let ConnectionUsage = _prefix "ConnectionUsage"
    /// <summary>
    /// An AnalysisCaseDefinition is a CaseDefinition for the case of carrying out an analysis.
    /// <see href="http://open-services.net/ns/sysmlv2#AnalysisCaseDefinition"></see></summary>
    let AnalysisCaseDefinition = _prefix "AnalysisCaseDefinition"
    /// <summary>
    /// A CaseDefinition is a CalculationDefinition for a process, often involving collecting evidence or data, relative to a subject, possibly involving the collaboration of one or more other actors, producing a result that meets an objective.
    /// <see href="http://open-services.net/ns/sysmlv2#CaseDefinition"></see></summary>
    let CaseDefinition = _prefix "CaseDefinition"
    /// <summary>
    /// An AnalysisCaseUsage is a Usage of an AnalysisCaseDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#AnalysisCaseUsage"></see></summary>
    let AnalysisCaseUsage = _prefix "AnalysisCaseUsage"
    /// <summary>
    /// A CaseUsage is a Usage of a CaseDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#CaseUsage"></see></summary>
    let CaseUsage = _prefix "CaseUsage"
    /// <summary>
    /// An AnnotatingElement is an Element that provides additional description of or metadata on some other Element. An AnnotatingElement is either attached to its annotatedElements by Annotation Relationships, or it implicitly annotates its owningNamespace.
    /// <see href="http://open-services.net/ns/sysmlv2#AnnotatingElement"></see></summary>
    let AnnotatingElement = _prefix "AnnotatingElement"
    /// <summary>
    /// An Element is a constituent of a model that is uniquely identified relative to all other Elements. It can have Relationships with other Elements. Some of these Relationships might imply ownership of other Elements, which means that if an Element is deleted from a model, then so are all the Elements that it owns.
    /// <see href="http://open-services.net/ns/sysmlv2#Element"></see></summary>
    let Element = _prefix "Element"
    /// <summary>
    /// An Annotation is a Relationship between an AnnotatingElement and the Element that is annotated by that AnnotatingElement.
    /// <see href="http://open-services.net/ns/sysmlv2#Annotation"></see></summary>
    let Annotation = _prefix "Annotation"
    /// <summary>
    /// A Relationship is an Element that relates other Element. Some of its relatedElements may be owned, in which case those ownedRelatedElements will be deleted from a model if their owningRelationship is. A Relationship may also be owned by another Element, in which case the ownedRelatedElements of the Relationship are also considered to be transitively owned by the owningRelatedElement of the Relationship.
    /// <see href="http://open-services.net/ns/sysmlv2#Relationship"></see></summary>
    let Relationship = _prefix "Relationship"
    /// <summary>
    /// An AssertConstraintUsage is a ConstraintUsage that is also an Invariant and, so, is asserted to be true (by default). Unless it is the AssertConstraintUsage itself, the asserted ConstraintUsage is related to the AssertConstraintUsage by a ReferenceSubsetting Relationship.
    /// <see href="http://open-services.net/ns/sysmlv2#AssertConstraintUsage"></see></summary>
    let AssertConstraintUsage = _prefix "AssertConstraintUsage"
    /// <summary>
    /// A ConstraintUsage is an OccurrenceUsage that is also a BooleanExpression, and, so, is typed by a Predicate. Nominally, if the type is a ConstraintDefinition, a ConstraintUsage is a Usage of that ConstraintDefinition. However, other kinds of kernel Predicates are also allowed, to permit use of Predicates from the Kernel Model Libraries.
    /// <see href="http://open-services.net/ns/sysmlv2#ConstraintUsage"></see></summary>
    let ConstraintUsage = _prefix "ConstraintUsage"
    /// <summary>
    /// An Invariant is a BooleanExpression that is asserted to have a specific Boolean result value. If isNegated = false, then the result is asserted to be true. If isNegated = true, then the result is asserted to be false.
    /// <see href="http://open-services.net/ns/sysmlv2#Invariant"></see></summary>
    let Invariant = _prefix "Invariant"
    /// <summary>
    /// An AssignmentActionUsage is an ActionUsage that is defined, directly or indirectly, by the ActionDefinition AssignmentAction from the Systems Model Library. It specifies that the value of the referent Feature, relative to the target given by the result of the targetArgument Expression, should be set to the result of the valueExpression.
    /// <see href="http://open-services.net/ns/sysmlv2#AssignmentActionUsage"></see></summary>
    let AssignmentActionUsage = _prefix "AssignmentActionUsage"
    /// <summary>
    /// An Association is a Relationship and a Classifier to enable classification of links between things (in the universe). The co-domains (types) of the associationEnd Features are the relatedTypes, as co-domain and participants (linked things) of an Association identify each other.
    /// <see href="http://open-services.net/ns/sysmlv2#Association"></see></summary>
    let Association = _prefix "Association"
    /// <summary>
    /// A Classifier is a Type that classifies:.
    /// <see href="http://open-services.net/ns/sysmlv2#Classifier"></see></summary>
    let Classifier = _prefix "Classifier"
    /// <summary>
    /// An AssociationStructure is an Association that is also a Structure, classifying link objects that are both links and objects. As objects, link objects can be created and destroyed, and their non-end Features can change over time. However, the values of the end Features of a link object are fixed and cannot change over its lifetime.
    /// <see href="http://open-services.net/ns/sysmlv2#AssociationStructure"></see></summary>
    let AssociationStructure = _prefix "AssociationStructure"
    /// <summary>
    /// A Structure is a Class of objects in the modeled universe that are primarily structural in nature. While such an object is not itself behavioral, it may be involved in and acted on by Behaviors, and it may be the performer of some of them.
    /// <see href="http://open-services.net/ns/sysmlv2#Structure"></see></summary>
    let Structure = _prefix "Structure"
    /// <summary>
    /// An AttributeDefinition is a Definition and a DataType of information about a quality or characteristic of a system or part of a system that has no independent identity other than its value. All features of an AttributeDefinition must be referential (non-composite).
    /// <see href="http://open-services.net/ns/sysmlv2#AttributeDefinition"></see></summary>
    let AttributeDefinition = _prefix "AttributeDefinition"
    /// <summary>
    /// A DataType is a Classifier of things (in the universe) that can only be distinguished by how they are related to other things (via Features). This means multiple things classified by the same DataType.
    /// <see href="http://open-services.net/ns/sysmlv2#DataType"></see></summary>
    let DataType = _prefix "DataType"
    /// <summary>
    /// A Definition is a Classifier of Usages. The actual kinds of Definition that may appear in a model are given by the subclasses of Definition (possibly as extended with user-defined SemanticMetadata).
    /// <see href="http://open-services.net/ns/sysmlv2#Definition"></see></summary>
    let Definition = _prefix "Definition"
    /// <summary>
    /// An AttributeUsage is a Usage whose type is a DataType. Nominally, if the type is an AttributeDefinition, an AttributeUsage is a usage of a AttributeDefinition to represent the value of some system quality or characteristic. However, other kinds of kernel DataTypes are also allowed, to permit use of DataTypes from the Kernel Model Libraries. An AttributeUsage itself as well as all its nested features must be referential (non-composite).
    /// <see href="http://open-services.net/ns/sysmlv2#AttributeUsage"></see></summary>
    let AttributeUsage = _prefix "AttributeUsage"
    /// <summary>
    /// A Usage is a usage of a Definition. A Usage may only be an ownedFeature of a Definition or another Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#Usage"></see></summary>
    let Usage = _prefix "Usage"
    /// <summary>
    /// A Class is a Classifier of things (in the universe) that can be distinguished without regard to how they are related to other things (via Features). This means multiple things classified by the same Class can be distinguished, even when they are related other things in exactly the same way.
    /// <see href="http://open-services.net/ns/sysmlv2#Class"></see></summary>
    let Class = _prefix "Class"
    /// <summary>
    /// A BindingConnector is a binary Connector that requires its relatedFeatures to identify the same things (have the same values).
    /// <see href="http://open-services.net/ns/sysmlv2#BindingConnector"></see></summary>
    let BindingConnector = _prefix "BindingConnector"
    /// <summary>
    /// A Connector is a usage of Associations, with links restricted according to instances of the Type in which they are used (domain of the Connector). The associations of the Connector restrict what kinds of things might be linked. The Connector further restricts these links to be between values of Features on instances of its domain.
    /// <see href="http://open-services.net/ns/sysmlv2#Connector"></see></summary>
    let Connector = _prefix "Connector"
    /// <summary>
    /// A BindingConnectorAsUsage is both a BindingConnector and a ConnectorAsUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#BindingConnectorAsUsage"></see></summary>
    let BindingConnectorAsUsage = _prefix "BindingConnectorAsUsage"
    /// <summary>
    /// A ConnectorAsUsage is both a Connector and a Usage. ConnectorAsUsage cannot itself be instantiated in a SysML model, but it is the base class for the concrete classes BindingConnectorAsUsage, SuccessionAsUsage and ConnectionUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#ConnectorAsUsage"></see></summary>
    let ConnectorAsUsage = _prefix "ConnectorAsUsage"
    /// <summary>
    /// A BooleanExpression is a Boolean-valued Expression whose type is a Predicate. It represents a logical condition resulting from the evaluation of the Predicate.
    /// <see href="http://open-services.net/ns/sysmlv2#BooleanExpression"></see></summary>
    let BooleanExpression = _prefix "BooleanExpression"
    /// <summary>
    /// An Expression is a Step that is typed by a Function. An Expression that also has a Function as its featuringType is a computational step within that Function. An Expression always has a single result parameter, which redefines the result parameter of its defining function. This allows Expressions to be interconnected in tree structures, in which inputs to each Expression in the tree are determined as the results of other Expression in the tree.
    /// <see href="http://open-services.net/ns/sysmlv2#Expression"></see></summary>
    let Expression = _prefix "Expression"
    /// <summary>
    /// A CalculationDefinition is an ActionDefinition that also defines a Function producing a result.
    /// <see href="http://open-services.net/ns/sysmlv2#CalculationDefinition"></see></summary>
    let CalculationDefinition = _prefix "CalculationDefinition"
    /// <summary>
    /// A Function is a Behavior that has an out parameter that is identified as its result. A Function represents the performance of a calculation that produces the values of its result parameter. This calculation may be decomposed into Expressions that are steps of the Function.
    /// <see href="http://open-services.net/ns/sysmlv2#Function"></see></summary>
    let Function = _prefix "Function"
    /// <summary>
    /// A CalculationUsage is an ActionUsage that is also an Expression, and, so, is typed by a Function. Nominally, if the type is a CalculationDefinition, a CalculationUsage is a Usage of that CalculationDefinition within a system. However, other kinds of kernel Functions are also allowed, to permit use of Functions from the Kernel Model Libraries.
    /// <see href="http://open-services.net/ns/sysmlv2#CalculationUsage"></see></summary>
    let CalculationUsage = _prefix "CalculationUsage"
    /// <summary>
    /// A Type is a Namespace that is the most general kind of Element supporting the semantics of classification. A Type may be a Classifier or a Feature, defining conditions on what is classified by the Type (see also the description of isSufficient).
    /// <see href="http://open-services.net/ns/sysmlv2#Type"></see></summary>
    let Type = _prefix "Type"
    /// <summary>
    /// A CollectExpression is an OperatorExpression whose operator is "collect", which resolves to the Function ControlFunctions::collect from the Kernel Functions Library.
    /// <see href="http://open-services.net/ns/sysmlv2#CollectExpression"></see></summary>
    let CollectExpression = _prefix "CollectExpression"
    /// <summary>
    /// An OperatorExpression is an InvocationExpression whose function is determined by resolving its operator in the context of one of the standard packages from the Kernel Function Library.
    /// <see href="http://open-services.net/ns/sysmlv2#OperatorExpression"></see></summary>
    let OperatorExpression = _prefix "OperatorExpression"
    /// <summary>
    /// A Comment is an AnnotatingElement whose body in some way describes its annotatedElements.
    /// <see href="http://open-services.net/ns/sysmlv2#Comment"></see></summary>
    let Comment = _prefix "Comment"
    /// <summary>
    /// A ConcernDefinition is a RequirementDefinition that one or more stakeholders may be interested in having addressed. These stakeholders are identified by the ownedStakeholdersof the ConcernDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#ConcernDefinition"></see></summary>
    let ConcernDefinition = _prefix "ConcernDefinition"
    /// <summary>
    /// A RequirementDefinition is a ConstraintDefinition that defines a requirement used in the context of a specification as a constraint that a valid solution must satisfy. The specification is relative to a specified subject, possibly in collaboration with one or more external actors.
    /// <see href="http://open-services.net/ns/sysmlv2#RequirementDefinition"></see></summary>
    let RequirementDefinition = _prefix "RequirementDefinition"
    /// <summary>
    /// A ConcernUsage is a Usage of a ConcernDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#ConcernUsage"></see></summary>
    let ConcernUsage = _prefix "ConcernUsage"
    /// <summary>
    /// A RequirementUsage is a Usage of a RequirementDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#RequirementUsage"></see></summary>
    let RequirementUsage = _prefix "RequirementUsage"
    /// <summary>
    /// A ConjugatedPortDefinition is a PortDefinition that is a PortDefinition of its original PortDefinition. That is, a ConjugatedPortDefinition inherits all the features of the original PortDefinition, but input flows of the original PortDefinition become outputs on the ConjugatedPortDefinition and output flows of the original PortDefinition become inputs on the ConjugatedPortDefinition. Every PortDefinition (that is not itself a ConjugatedPortDefinition) has exactly one corresponding ConjugatedPortDefinition, whose effective name is the name of the originalPortDefinition, with the character ~ prepended.
    /// <see href="http://open-services.net/ns/sysmlv2#ConjugatedPortDefinition"></see></summary>
    let ConjugatedPortDefinition = _prefix "ConjugatedPortDefinition"
    /// <summary>
    /// A PortDefinition defines a point at which external entities can connect to and interact with a system or part of a system. Any ownedUsages of a PortDefinition, other than PortUsages, must not be composite.
    /// <see href="http://open-services.net/ns/sysmlv2#PortDefinition"></see></summary>
    let PortDefinition = _prefix "PortDefinition"
    /// <summary>
    /// A ConjugatedPortTyping is a FeatureTyping whose type is a ConjugatedPortDefinition. (This relationship is intended to be an abstract-syntax marker for a special surface notation for conjugated typing of ports.).
    /// <see href="http://open-services.net/ns/sysmlv2#ConjugatedPortTyping"></see></summary>
    let ConjugatedPortTyping = _prefix "ConjugatedPortTyping"
    /// <summary>
    /// FeatureTyping is Specialization in which the specific Type is a Feature. This means the set of instances of the (specific) typedFeature is a subset of the set of instances of the (general) type. In the simplest case, the type is a Classifier, whereupon the typedFeature has values that are instances of the Classifier.
    /// <see href="http://open-services.net/ns/sysmlv2#FeatureTyping"></see></summary>
    let FeatureTyping = _prefix "FeatureTyping"
    /// <summary>
    /// Conjugation is a Relationship between two types in which the conjugatedType inherits all the Features of the originalType, but with all input and output Features reversed. That is, any Features with a direction in relative to the originalType are considered to have an effective direction of out relative to the conjugatedType and, similarly, Features with direction out in the originalType are considered to have an effective direction of in in the conjugatedType. Features with direction inout, or with no direction, in the originalType, are inherited without change.
    /// <see href="http://open-services.net/ns/sysmlv2#Conjugation"></see></summary>
    let Conjugation = _prefix "Conjugation"
    /// <summary>
    /// A PartDefinition is an ItemDefinition of a Class of systems or parts of systems. Note that all parts may be considered items for certain purposes, but not all items are parts that can perform actions within a system.
    /// <see href="http://open-services.net/ns/sysmlv2#PartDefinition"></see></summary>
    let PartDefinition = _prefix "PartDefinition"
    /// <summary>
    /// A PartUsage is a usage of a PartDefinition to represent a system or a part of a system. At least one of the itemDefinitions of the PartUsage must be a PartDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#PartUsage"></see></summary>
    let PartUsage = _prefix "PartUsage"
    /// <summary>
    /// A Feature is a Type that classifies relations between multiple things (in the universe). The domain of the relation is the intersection of the featuringTypes of the Feature. (The domain of a Feature with no featuringTyps is implicitly the most general Type Base::Anything from the Kernel Semantic Library.) The co-domain of the relation is the intersection of the types of the Feature.
    ///
    /// .
    /// <see href="http://open-services.net/ns/sysmlv2#Feature"></see></summary>
    let Feature = _prefix "Feature"
    /// <summary>
    /// A ConstraintDefinition is an OccurrenceDefinition that is also a Predicate that defines a constraint that may be asserted to hold on a system or part of a system.
    /// <see href="http://open-services.net/ns/sysmlv2#ConstraintDefinition"></see></summary>
    let ConstraintDefinition = _prefix "ConstraintDefinition"
    /// <summary>
    /// A Predicate is a Function whose result parameter has type Boolean and multiplicity 1..1.
    /// <see href="http://open-services.net/ns/sysmlv2#Predicate"></see></summary>
    let Predicate = _prefix "Predicate"
    /// <summary>
    /// A ControlNode is an ActionUsage that does not have any inherent behavior but provides constraints on incoming and outgoing Successions that are used to control other Actions. A ControlNode must be a composite owned usage of an ActionDefinition or ActionUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#ControlNode"></see></summary>
    let ControlNode = _prefix "ControlNode"
    /// <summary>
    /// A DecisionNode is a ControlNode that makes a selection from its outgoing Successions.
    /// <see href="http://open-services.net/ns/sysmlv2#DecisionNode"></see></summary>
    let DecisionNode = _prefix "DecisionNode"
    /// <summary>
    /// A Dependency is a Relationship that indicates that one or more client Elements require one more supplier Elements for their complete specification. In general, this means that a change to one of the supplier Elements may necessitate a change to, or re-specification of, the client Elements.
    /// <see href="http://open-services.net/ns/sysmlv2#Dependency"></see></summary>
    let Dependency = _prefix "Dependency"
    /// <summary>
    /// Differencing is a Relationship that makes its differencingType one of the differencingTypes of its typeDifferenced.
    /// <see href="http://open-services.net/ns/sysmlv2#Differencing"></see></summary>
    let Differencing = _prefix "Differencing"
    /// <summary>
    /// A Disjoining is a Relationship between Types asserted to have interpretations that are not shared (disjoint) between them, identified as typeDisjoined and disjoiningType. For example, a Classifier for mammals is disjoint from a Classifier for minerals, and a Feature for people's parents is disjoint from a Feature for their children.
    /// <see href="http://open-services.net/ns/sysmlv2#Disjoining"></see></summary>
    let Disjoining = _prefix "Disjoining"
    /// <summary>
    /// Documentation is a Comment that specifically documents a documentedElement, which must be its owner.
    /// <see href="http://open-services.net/ns/sysmlv2#Documentation"></see></summary>
    let Documentation = _prefix "Documentation"
    /// <summary>
    /// ElementFilterMembership is a Membership between a Namespace and a model-level evaluable Boolean-valued Expression, asserting that imported members of the Namespace should be filtered using the condition Expression. A general Namespace does not define any specific filtering behavior, but such behavior may be defined for various specialized kinds of Namespaces.
    /// <see href="http://open-services.net/ns/sysmlv2#ElementFilterMembership"></see></summary>
    let ElementFilterMembership = _prefix "ElementFilterMembership"
    /// <summary>
    /// An OwningMembership is a Membership that owns its memberElement as a ownedRelatedElement. The ownedMemberElement becomes an ownedMember of the membershipOwningNamespace.
    /// <see href="http://open-services.net/ns/sysmlv2#OwningMembership"></see></summary>
    let OwningMembership = _prefix "OwningMembership"
    /// <summary>
    /// EndFeatureMembership is a FeatureMembership that requires its memberFeature be owned and have isEnd = true.
    /// <see href="http://open-services.net/ns/sysmlv2#EndFeatureMembership"></see></summary>
    let EndFeatureMembership = _prefix "EndFeatureMembership"
    /// <summary>
    /// A FeatureMembership is an OwningMembership between a Feature in an owningType that is also a Featuring Relationship between the Feature and the Type, in which the featuringType is the source and the featureOfType is the target. A FeatureMembership is always owned by its owningType, which is the featuringType for the FeatureMembership considered as a Featuring.
    /// <see href="http://open-services.net/ns/sysmlv2#FeatureMembership"></see></summary>
    let FeatureMembership = _prefix "FeatureMembership"
    /// <summary>
    /// An EnumerationDefinition is an AttributeDefinition all of whose instances are given by an explicit list of enumeratedValues. This is realized by requiring that the EnumerationDefinition have isVariation = true, with the enumeratedValues being its variants.
    /// <see href="http://open-services.net/ns/sysmlv2#EnumerationDefinition"></see></summary>
    let EnumerationDefinition = _prefix "EnumerationDefinition"
    /// <summary>
    /// An EnumerationUsage is an AttributeUsage whose attributeDefinition is an EnumerationDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#EnumerationUsage"></see></summary>
    let EnumerationUsage = _prefix "EnumerationUsage"
    /// <summary>
    /// An EventOccurrenceUsage is an OccurrenceUsage that represents another OccurrenceUsage occurring as a suboccurrence of the containing occurrence of the EventOccurrenceUsage. Unless it is the EventOccurrenceUsage itself, the referenced OccurrenceUsage is related to the EventOccurrenceUsage by a ReferenceSubsetting Relationship.
    /// <see href="http://open-services.net/ns/sysmlv2#EventOccurrenceUsage"></see></summary>
    let EventOccurrenceUsage = _prefix "EventOccurrenceUsage"
    /// <summary>
    /// An ExhibitStateUsage is a StateUsage that represents the exhibiting of a StateUsage. Unless it is the StateUsage itself, the StateUsage to be exhibited is related to the ExhibitStateUsage by a ReferenceSubsetting Relationship. An ExhibitStateUsage is also a PerformActionUsage, with its exhibitedState as the performedAction.
    /// <see href="http://open-services.net/ns/sysmlv2#ExhibitStateUsage"></see></summary>
    let ExhibitStateUsage = _prefix "ExhibitStateUsage"
    /// <summary>
    /// A PerformActionUsage is an ActionUsage that represents the performance of an ActionUsage. Unless it is the PerformActionUsage itself, the ActionUsage to be performed is related to the PerformActionUsage by a ReferenceSubsetting relationship. A PerformActionUsage is also an EventOccurrenceUsage, with its performedAction as the eventOccurrence.
    /// <see href="http://open-services.net/ns/sysmlv2#PerformActionUsage"></see></summary>
    let PerformActionUsage = _prefix "PerformActionUsage"
    /// <summary>
    /// A StateUsage is an ActionUsage that is nominally the Usage of a StateDefinition. However, other kinds of kernel Behaviors are also allowed as types, to permit use of Behaviors
    /// .
    /// <see href="http://open-services.net/ns/sysmlv2#StateUsage"></see></summary>
    let StateUsage = _prefix "StateUsage"
    /// <summary>
    /// An Expose is an Import of Memberships into a ViewUsage that provide the Elements to be included in a view. Visibility is always ignored for an Expose (i.e., isImportAll = true).
    /// <see href="http://open-services.net/ns/sysmlv2#Expose"></see></summary>
    let Expose = _prefix "Expose"
    /// <summary>
    /// An Import is an Relationship between its importOwningNamespace and either a Membership (for a MembershipImport) or another Namespace (for a NamespaceImport), which determines a set of Memberships that become importedMemberships of the importOwningNamespace. If isImportAll = false (the default), then only public Memberships are considered "visible". If isImportAll = true, then all Memberships are considered "visible", regardless of their declared visibility. If isRecursive = true, then visible Memberships are also recursively imported from owned sub-Namespaces.
    /// <see href="http://open-services.net/ns/sysmlv2#Import"></see></summary>
    let Import = _prefix "Import"
    /// <summary>
    /// A FeatureChainExpression is an OperatorExpression whose operator is ".", which resolves to the Function ControlFunctions::'.' from the Kernel Functions Library. It evaluates to the result of chaining the result Feature of its single argument Expression with its targetFeature.
    /// <see href="http://open-services.net/ns/sysmlv2#FeatureChainExpression"></see></summary>
    let FeatureChainExpression = _prefix "FeatureChainExpression"
    /// <summary>
    /// FeatureChaining is a Relationship that makes its target Feature one of the chainingFeatures of its owning Feature.
    /// <see href="http://open-services.net/ns/sysmlv2#FeatureChaining"></see></summary>
    let FeatureChaining = _prefix "FeatureChaining"
    /// <summary>
    /// FeatureDirectionKind enumerates the possible kinds of direction that a Feature may be given as a member of a Type.
    /// <see href="http://open-services.net/ns/sysmlv2#FeatureDirectionKind"></see></summary>
    let FeatureDirectionKind = _prefix "FeatureDirectionKind"
    /// <summary>
    /// A FeatureInverting is a Relationship between Features asserting that their interpretations (sequences) are the reverse of each other, identified as featureInverted and invertingFeature. For example, a Feature identifying each person's parents is the inverse of a Feature identifying each person's children. A person identified as a parent of another will identify that other as one of their children.
    /// <see href="http://open-services.net/ns/sysmlv2#FeatureInverting"></see></summary>
    let FeatureInverting = _prefix "FeatureInverting"
    /// <summary>
    /// Featuring is a Relationship between a Type and a Feature that is featured by that Type. It asserts that every instance in the domain of the feature must be classified by the type.
    /// <see href="http://open-services.net/ns/sysmlv2#Featuring"></see></summary>
    let Featuring = _prefix "Featuring"
    /// <summary>
    /// A FeatureReferenceExpression is an Expression whose result is bound to a referent Feature.
    /// <see href="http://open-services.net/ns/sysmlv2#FeatureReferenceExpression"></see></summary>
    let FeatureReferenceExpression = _prefix "FeatureReferenceExpression"
    /// <summary>
    /// Specialization is a Relationship between two Types that requires all instances of the specific type to also be instances of the general Type (i.e., the set of instances of the specific Type is a subset of those of the general Type, which might be the same set).
    /// <see href="http://open-services.net/ns/sysmlv2#Specialization"></see></summary>
    let Specialization = _prefix "Specialization"
    /// <summary>
    /// A FeatureValue is a Membership that identifies a particular member Expression that provides the value of the Feature that owns the FeatureValue. The value is specified as either a bound value or an initial value, and as either a concrete or default value. A Feature can have at most one FeatureValue.
    /// <see href="http://open-services.net/ns/sysmlv2#FeatureValue"></see></summary>
    let FeatureValue = _prefix "FeatureValue"
    /// <summary>
    /// A FlowConnectionDefinition is a ConnectionDefinition and ActionDefinition that is also an Interaction representing flows between Usages.
    /// <see href="http://open-services.net/ns/sysmlv2#FlowConnectionDefinition"></see></summary>
    let FlowConnectionDefinition = _prefix "FlowConnectionDefinition"
    /// <summary>
    /// An Interaction is a Behavior that is also an Association, providing a context for multiple objects that have behaviors that impact one another.
    /// <see href="http://open-services.net/ns/sysmlv2#Interaction"></see></summary>
    let Interaction = _prefix "Interaction"
    /// <summary>
    /// A FlowConnectionUsage is a ConnectionUsage that is also an ItemFlow.
    /// <see href="http://open-services.net/ns/sysmlv2#FlowConnectionUsage"></see></summary>
    let FlowConnectionUsage = _prefix "FlowConnectionUsage"
    /// <summary>
    /// An ItemFlow is a Step that represents the transfer of objects or data values from one Feature to another. ItemFlows can take non-zero time to complete.
    /// <see href="http://open-services.net/ns/sysmlv2#ItemFlow"></see></summary>
    let ItemFlow = _prefix "ItemFlow"
    /// <summary>
    /// A ForLoopActionUsage is a LoopActionUsage that specifies that its bodyAction ActionUsage should be performed once for each value, in order, from the sequence of values obtained as the result of the seqArgument Expression, with the loopVariable set to the value for each iteration.
    /// <see href="http://open-services.net/ns/sysmlv2#ForLoopActionUsage"></see></summary>
    let ForLoopActionUsage = _prefix "ForLoopActionUsage"
    /// <summary>
    /// A LoopActionUsage is an ActionUsage that specifies that its bodyAction should be performed repeatedly. Its subclasses WhileLoopActionUsage and ForLoopActionUsage provide different ways to determine how many times the bodyAction should be performed.
    /// <see href="http://open-services.net/ns/sysmlv2#LoopActionUsage"></see></summary>
    let LoopActionUsage = _prefix "LoopActionUsage"
    /// <summary>
    /// A ForkNode is a ControlNode that must be followed by successor Actions as given by all its outgoing Successions.
    /// <see href="http://open-services.net/ns/sysmlv2#ForkNode"></see></summary>
    let ForkNode = _prefix "ForkNode"
    /// <summary>
    /// A FramedConcernMembership is a RequirementConstraintMembership for a framed ConcernUsage of a RequirementDefinition or RequirementUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#FramedConcernMembership"></see></summary>
    let FramedConcernMembership = _prefix "FramedConcernMembership"
    /// <summary>
    /// A RequirementConstraintMembership is a FeatureMembership for an assumed or required ConstraintUsage of a RequirementDefinition or RequirementUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#RequirementConstraintMembership"></see></summary>
    let RequirementConstraintMembership = _prefix "RequirementConstraintMembership"
    /// <summary>
    /// An IfActionUsage is an ActionUsage that specifies that the thenAction ActionUsage should be performed if the result of the ifArgument Expression is true. It may also optionally specify an elseAction ActionUsage that is performed if the result of the ifArgument is false.
    /// <see href="http://open-services.net/ns/sysmlv2#IfActionUsage"></see></summary>
    let IfActionUsage = _prefix "IfActionUsage"
    /// <summary>
    /// An IncludeUseCaseUsage is a UseCaseUsage that represents the inclusion of a UseCaseUsage by a UseCaseDefinition or UseCaseUsage. Unless it is the IncludeUseCaseUsage itself, the UseCaseUsage to be included is related to the includedUseCase by a ReferenceSubsetting Relationship. An IncludeUseCaseUsage is also a PerformActionUsage, with its useCaseIncluded as the performedAction.
    /// <see href="http://open-services.net/ns/sysmlv2#IncludeUseCaseUsage"></see></summary>
    let IncludeUseCaseUsage = _prefix "IncludeUseCaseUsage"
    /// <summary>
    /// A UseCaseUsage is a Usage of a UseCaseDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#UseCaseUsage"></see></summary>
    let UseCaseUsage = _prefix "UseCaseUsage"
    /// <summary>
    /// An InterfaceDefinition is a ConnectionDefinition all of whose ends are PortUsages, defining an interface between elements that interact through such ports.
    /// <see href="http://open-services.net/ns/sysmlv2#InterfaceDefinition"></see></summary>
    let InterfaceDefinition = _prefix "InterfaceDefinition"
    /// <summary>
    /// An InterfaceUsage is a Usage of an InterfaceDefinition to represent an interface connecting parts of a system through specific ports.
    /// <see href="http://open-services.net/ns/sysmlv2#InterfaceUsage"></see></summary>
    let InterfaceUsage = _prefix "InterfaceUsage"
    /// <summary>
    /// Intersecting is a Relationship that makes its intersectingType one of the intersectingTypes of its typeIntersected.
    /// <see href="http://open-services.net/ns/sysmlv2#Intersecting"></see></summary>
    let Intersecting = _prefix "Intersecting"
    /// <summary>
    /// An InvocationExpression is an Expression each of whose input parameters are bound to the result of an argument Expression.
    /// <see href="http://open-services.net/ns/sysmlv2#InvocationExpression"></see></summary>
    let InvocationExpression = _prefix "InvocationExpression"
    /// <summary>
    /// An ItemDefinition is an OccurrenceDefinition of the Structure of things that may themselves be systems or parts of systems, but may also be things that are acted on by a system or parts of a system, but which do not necessarily perform actions themselves. This includes items that can be exchanged between parts of a system, such as water or electrical signals.
    /// <see href="http://open-services.net/ns/sysmlv2#ItemDefinition"></see></summary>
    let ItemDefinition = _prefix "ItemDefinition"
    /// <summary>
    /// An ItemFeature is the ownedFeature of an ItemFlow that identifies the things carried by the kinds of transfers that are instances of the ItemFlow.
    /// <see href="http://open-services.net/ns/sysmlv2#ItemFeature"></see></summary>
    let ItemFeature = _prefix "ItemFeature"
    /// <summary>
    /// An ItemFlowEnd is a Feature that is one of the connectorEnds giving the source or target of an ItemFlow. For ItemFlows typed by FlowTransfer or its specializations, ItemFlowEnds must have exactly one ownedFeature, which redefines Transfer::source::sourceOutput or Transfer::target::targetInput and redefines the corresponding feature of the relatedElement for its end.
    /// <see href="http://open-services.net/ns/sysmlv2#ItemFlowEnd"></see></summary>
    let ItemFlowEnd = _prefix "ItemFlowEnd"
    /// <summary>
    /// An ItemUsage is a ItemUsage whose definition is a Structure. Nominally, if the definition is an ItemDefinition, an ItemUsage is a ItemUsage of that ItemDefinition within a system. However, other kinds of Kernel Structures are also allowed, to permit use of Structures from the Kernel Model Libraries.
    /// <see href="http://open-services.net/ns/sysmlv2#ItemUsage"></see></summary>
    let ItemUsage = _prefix "ItemUsage"
    /// <summary>
    /// A JoinNode is a ControlNode that waits for the completion of all the predecessor Actions given by incoming Successions.
    /// <see href="http://open-services.net/ns/sysmlv2#JoinNode"></see></summary>
    let JoinNode = _prefix "JoinNode"
    /// <summary>
    /// A LibraryPackage is a Package that is the container for a model library. A LibraryPackage is itself a library Element as are all Elements that are directly or indirectly contained in it.
    /// <see href="http://open-services.net/ns/sysmlv2#LibraryPackage"></see></summary>
    let LibraryPackage = _prefix "LibraryPackage"
    /// <summary>
    /// A Package is a Namespace used to group Elements, without any instance-level semantics. It may have one or more model-level evaluable filterCondition Expressions used to filter its importedMemberships. Any imported member must meet all of the filterConditions.
    /// <see href="http://open-services.net/ns/sysmlv2#Package"></see></summary>
    let Package = _prefix "Package"
    /// <summary>
    /// A LifeClass is a Class that specializes both the Class Occurrences::Life from the Kernel Semantic Library and a single OccurrenceDefinition, and has a multiplicity of 0..1. This constrains the OccurrenceDefinition being specialized to have at most one instance that is a complete Life.
    /// <see href="http://open-services.net/ns/sysmlv2#LifeClass"></see></summary>
    let LifeClass = _prefix "LifeClass"
    /// <summary>
    /// LiteralBoolean is a LiteralExpression that provides a Boolean value as a result. Its result parameter must have type Boolean.
    /// <see href="http://open-services.net/ns/sysmlv2#LiteralBoolean"></see></summary>
    let LiteralBoolean = _prefix "LiteralBoolean"
    /// <summary>
    /// A LiteralExpression is an Expression that provides a basic DataValue as a result.
    /// <see href="http://open-services.net/ns/sysmlv2#LiteralExpression"></see></summary>
    let LiteralExpression = _prefix "LiteralExpression"
    /// <summary>
    /// A LiteralInfinity is a LiteralExpression that provides the positive infinity value (*). It's result must have the type Positive.
    /// <see href="http://open-services.net/ns/sysmlv2#LiteralInfinity"></see></summary>
    let LiteralInfinity = _prefix "LiteralInfinity"
    /// <summary>
    /// A LiteralInteger is a LiteralExpression that provides an Integer value as a result. Its result parameter must have the type Integer.
    /// <see href="http://open-services.net/ns/sysmlv2#LiteralInteger"></see></summary>
    let LiteralInteger = _prefix "LiteralInteger"
    /// <summary>
    /// A LiteralRational is a LiteralExpression that provides a Rational value as a result. Its result parameter must have the type Rational.
    /// <see href="http://open-services.net/ns/sysmlv2#LiteralRational"></see></summary>
    let LiteralRational = _prefix "LiteralRational"
    /// <summary>
    /// A LiteralString is a LiteralExpression that provides a String value as a result. Its result parameter must have the type String.
    /// <see href="http://open-services.net/ns/sysmlv2#LiteralString"></see></summary>
    let LiteralString = _prefix "LiteralString"
    /// <summary>
    /// A Membership is a Relationship between a Namespace and an Element that indicates the Element is a member of (i.e., is contained in) the Namespace. Any memberNames specify how the memberElement is identified in the Namespace and the visibility specifies whether or not the memberElement is publicly visible from outside the Namespace.
    /// <see href="http://open-services.net/ns/sysmlv2#Membership"></see></summary>
    let Membership = _prefix "Membership"
    /// <summary>
    /// A MembershipExpose is an Expose  that exposes a specific importedMembership and, if isRecursive = true, additional Memberships recursively.
    /// <see href="http://open-services.net/ns/sysmlv2#MembershipExpose"></see></summary>
    let MembershipExpose = _prefix "MembershipExpose"
    /// <summary>
    /// A MembershipImport is an Import that imports its importedMembership into the importOwningNamespace. If isRecursive = true and the memberElement of the importedMembership is a Namespace, then the equivalent of a recursive NamespaceImport is also performed on that Namespace.
    /// <see href="http://open-services.net/ns/sysmlv2#MembershipImport"></see></summary>
    let MembershipImport = _prefix "MembershipImport"
    /// <summary>
    /// A MergeNode is a ControlNode that asserts the merging of its incoming Successions. A MergeNode may have at most one outgoing Successions.
    /// <see href="http://open-services.net/ns/sysmlv2#MergeNode"></see></summary>
    let MergeNode = _prefix "MergeNode"
    /// <summary>
    /// A Metaclass is a Structure used to type MetadataFeatures.
    /// <see href="http://open-services.net/ns/sysmlv2#Metaclass"></see></summary>
    let Metaclass = _prefix "Metaclass"
    /// <summary>
    /// A MetadataAccessExpression is an Expression whose result is a sequence of instances of Metaclasses representing all the MetadataFeature annotations of the referencedElement. In addition, the sequence includes an instance of the reflective Metaclass corresponding to the MOF class of the referencedElement, with values for all the abstract syntax properties of the referencedElement.
    /// <see href="http://open-services.net/ns/sysmlv2#MetadataAccessExpression"></see></summary>
    let MetadataAccessExpression = _prefix "MetadataAccessExpression"
    /// <summary>
    /// A MetadataDefinition is an ItemDefinition that is also a Metaclass.
    /// <see href="http://open-services.net/ns/sysmlv2#MetadataDefinition"></see></summary>
    let MetadataDefinition = _prefix "MetadataDefinition"
    /// <summary>
    /// A MetadataFeature is a Feature that is an AnnotatingElement used to annotate another Element with metadata. It is typed by a Metaclass. All its ownedFeatures must redefine features of its metaclass and any feature bindings must be model-level evaluable.
    /// <see href="http://open-services.net/ns/sysmlv2#MetadataFeature"></see></summary>
    let MetadataFeature = _prefix "MetadataFeature"
    /// <summary>
    /// A  MetadataUsage is a Usage and a MetadataFeature, used to annotate other Elements in a system model with metadata. As a MetadataFeature, its type must be a Metaclass, which will nominally be a MetadataDefinition. However, any kernel Metaclass is also allowed, to permit use of Metaclasses from the Kernel Model Libraries.
    /// <see href="http://open-services.net/ns/sysmlv2#MetadataUsage"></see></summary>
    let MetadataUsage = _prefix "MetadataUsage"
    /// <summary>
    /// A Multiplicity is a Feature whose co-domain is a set of natural numbers giving the allowed cardinalities of each typeWithMultiplicity. The cardinality of a Type is defined as follows, depending on whether the Type is a Classifier or Feature.
    /// .
    /// <see href="http://open-services.net/ns/sysmlv2#Multiplicity"></see></summary>
    let Multiplicity = _prefix "Multiplicity"
    /// <summary>
    /// A MultiplicityRange is a Multiplicity whose value is defined to be the (inclusive) range of natural numbers given by the result of a lowerBound Expression and the result of an upperBound Expression. The result of these Expressions shall be of type Natural. If the result of the upperBound Expression is the unbounded value *, then the specified range includes all natural numbers greater than or equal to the lowerBound value. If no lowerBound Expression, then the default is that the lower bound has the same value as the upper bound, except if the upperBound evaluates to *, in which case the default for the lower bound is 0.
    /// <see href="http://open-services.net/ns/sysmlv2#MultiplicityRange"></see></summary>
    let MultiplicityRange = _prefix "MultiplicityRange"
    /// <summary>
    /// A Namespace is an Element that contains other Elements, known as its members, via Membership Relationships with those Elements. The members of a Namespace may be owned by the Namespace, aliased in the Namespace, or imported into the Namespace via Import Relationships.
    /// <see href="http://open-services.net/ns/sysmlv2#Namespace"></see></summary>
    let Namespace = _prefix "Namespace"
    /// <summary>
    /// A NamespaceExpose is an Expose Relationship that exposes the Memberships of a specific importedNamespace and, if isRecursive = true, additional Memberships recursively.
    /// <see href="http://open-services.net/ns/sysmlv2#NamespaceExpose"></see></summary>
    let NamespaceExpose = _prefix "NamespaceExpose"
    /// <summary>
    /// A NamespaceImport is an Import that imports Memberships from its importedNamespace into the importOwningNamespace. If  isRecursive = false, then only the visible Memberships of the importedNamespace are imported. If  isRecursive = true, then, in addition, Memberships are recursively imported from any ownedMembers of the importedNamespace that are Namespaces.
    /// <see href="http://open-services.net/ns/sysmlv2#NamespaceImport"></see></summary>
    let NamespaceImport = _prefix "NamespaceImport"
    /// <summary>
    /// A NullExpression is an Expression that results in a null value.
    /// <see href="http://open-services.net/ns/sysmlv2#NullExpression"></see></summary>
    let NullExpression = _prefix "NullExpression"
    /// <summary>
    /// An ObjectiveMembership is a FeatureMembership that indicates that its ownedObjectiveRequirement is the objective RequirementUsage for its owningType, which must be a CaseDefinition or CaseUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#ObjectiveMembership"></see></summary>
    let ObjectiveMembership = _prefix "ObjectiveMembership"
    /// <summary>
    /// A PortConjugation is a Conjugation Relationship between a PortDefinition and its corresponding ConjugatedPortDefinition. As a result of this Relationship, the ConjugatedPortDefinition inherits all the features of the original PortDefinition, but input flows of the original PortDefinition become outputs on the ConjugatedPortDefinition and output flows of the original PortDefinition become inputs on the ConjugatedPortDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#PortConjugation"></see></summary>
    let PortConjugation = _prefix "PortConjugation"
    /// <summary>
    /// A PortUsage is a usage of a PortDefinition. A PortUsage itself as well as all its nestedUsages must be referential (non-composite).
    /// <see href="http://open-services.net/ns/sysmlv2#PortUsage"></see></summary>
    let PortUsage = _prefix "PortUsage"
    /// <summary>
    /// PortionKind is an enumeration of the specific kinds of Occurrence portions that can be represented by an OccurrenceUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#PortionKind"></see></summary>
    let PortionKind = _prefix "PortionKind"
    /// <summary>
    /// Redefinition is a kind of Subsetting that requires the redefinedFeature and the redefiningFeature to have the same values (on each instance of the domain of the redefiningFeature). This means any restrictions on the redefiningFeature, such as type or multiplicity, also apply to the redefinedFeature (on each instance of the domain of the redefiningFeature), and vice versa. The redefinedFeature might have values for instances of the domain of the redefiningFeature, but only as instances of the domain of the redefinedFeature that happen to also be instances of the domain of the redefiningFeature. This is supported by the constraints inherited from Subsetting on the domains of the redefiningFeature and redefinedFeature. However, these constraints are narrowed for Redefinition to require the owningTypes of the redefiningFeature and redefinedFeature to be different and the redefinedFeature to not be inherited into the owningNamespace of the redefiningFeature.This enables the redefiningFeature to have the same name as the redefinedFeature, if desired.
    /// <see href="http://open-services.net/ns/sysmlv2#Redefinition"></see></summary>
    let Redefinition = _prefix "Redefinition"
    /// <summary>
    /// Subsetting is Specialization in which the specific and general Types are Features. This means all values of the subsettingFeature (on instances of its domain, i.e., the intersection of its featuringTypes) are values of the subsettedFeature on instances of its domain. To support this the domain of the subsettingFeature must be the same or specialize (at least indirectly) the domain of the subsettedFeature (via Specialization), and the co-domain (intersection of the types) of the subsettingFeature must specialize the co-domain of the subsettedFeature.
    /// <see href="http://open-services.net/ns/sysmlv2#Subsetting"></see></summary>
    let Subsetting = _prefix "Subsetting"
    /// <summary>
    /// ReferenceSubsetting is a kind of Subsetting in which the referencedFeature is syntactically distinguished from other Features subsetted by the referencingFeature. ReferenceSubsetting has the same semantics as Subsetting, but the referenceFeature may have a special purpose relative to the referencingFeature. For instance, ReferenceSubsetting is used to identify the relatedFeatures of a Connector.
    /// <see href="http://open-services.net/ns/sysmlv2#ReferenceSubsetting"></see></summary>
    let ReferenceSubsetting = _prefix "ReferenceSubsetting"
    /// <summary>
    /// A ReferenceUsage is a Usage that specifies a non-compositional (isComposite = false) reference to something. The definition of a ReferenceUsage can be any kind of Classifier, with the default being the top-level Classifier Base::Anything from the Kernel Semantic Library. This allows the specification of a generic reference without distinguishing if the thing referenced is an attribute value, item, action, etc.
    /// <see href="http://open-services.net/ns/sysmlv2#ReferenceUsage"></see></summary>
    let ReferenceUsage = _prefix "ReferenceUsage"
    /// <summary>
    /// A RenderingDefinition is a PartDefinition that defines a specific rendering of the content of a model view (e.g., symbols, style, layout, etc.).
    /// <see href="http://open-services.net/ns/sysmlv2#RenderingDefinition"></see></summary>
    let RenderingDefinition = _prefix "RenderingDefinition"
    /// <summary>
    /// A RenderingUsage is the usage of a RenderingDefinition to specify the rendering of a specific model view to produce a physical view artifact.
    /// <see href="http://open-services.net/ns/sysmlv2#RenderingUsage"></see></summary>
    let RenderingUsage = _prefix "RenderingUsage"
    /// <summary>
    /// A RequirementConstraintKind indicates whether a ConstraintUsage is an assumption or a requirement in a RequirementDefinition or RequirementUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#RequirementConstraintKind"></see></summary>
    let RequirementConstraintKind = _prefix "RequirementConstraintKind"
    /// <summary>
    /// A RequirementVerificationMembership is a RequirementConstraintMembership  used in the objective of a VerificationCase to identify a RequirementUsage that is verified by the VerificationCase.
    /// <see href="http://open-services.net/ns/sysmlv2#RequirementVerificationMembership"></see></summary>
    let RequirementVerificationMembership = _prefix "RequirementVerificationMembership"
    /// <summary>
    /// A ResultExpressionMembership is a FeatureMembership that indicates that the ownedResultExpression provides the result values for the Function or Expression that owns it. The owning Function or Expression must contain a BindingConnector between the result parameter of the ownedResultExpression and the result parameter of the owning Function or Expression.
    /// <see href="http://open-services.net/ns/sysmlv2#ResultExpressionMembership"></see></summary>
    let ResultExpressionMembership = _prefix "ResultExpressionMembership"
    /// <summary>
    /// A ReturnParameterMembership is a ParameterMembership that indicates that the ownedMemberParameter is the result parameter of a Function or Expression. The direction of the ownedMemberParameter must be out.
    /// <see href="http://open-services.net/ns/sysmlv2#ReturnParameterMembership"></see></summary>
    let ReturnParameterMembership = _prefix "ReturnParameterMembership"
    /// <summary>
    /// A SatisfyRequirementUsage is an AssertConstraintUsage that asserts, by default, that a satisfied RequirementUsage is true for a specific satisfyingFeature, or, if isNegated = true, that the RequirementUsage is false. The satisfied RequirementUsage is related to the SatisfyRequirementUsage by a ReferenceSubsetting Relationship.
    /// <see href="http://open-services.net/ns/sysmlv2#SatisfyRequirementUsage"></see></summary>
    let SatisfyRequirementUsage = _prefix "SatisfyRequirementUsage"
    /// <summary>
    /// A SelectExpression is an OperatorExpression whose operator is "select", which resolves to the Function ControlFunctions::select from the Kernel Functions Library.
    /// <see href="http://open-services.net/ns/sysmlv2#SelectExpression"></see></summary>
    let SelectExpression = _prefix "SelectExpression"
    /// <summary>
    /// A SendActionUsage is an ActionUsage that specifies the sending of a payload given by the result of its payloadArgument Expression via a MessageTransfer whose source is given by the result of the senderArgument Expression and whose target is given by the result of the receiverArgument Expression. If no senderArgument is provided, the default is the this context for the action. If no receiverArgument is given, then the receiver is to be determined by, e.g., outgoing Connections from the sender.
    /// <see href="http://open-services.net/ns/sysmlv2#SendActionUsage"></see></summary>
    let SendActionUsage = _prefix "SendActionUsage"
    /// <summary>
    /// A StakeholderMembership is a ParameterMembership that identifies a PartUsage as a stakeholderParameter of a RequirementDefinition or RequirementUsage, which specifies a role played by an entity with concerns framed by the owningType.
    /// <see href="http://open-services.net/ns/sysmlv2#StakeholderMembership"></see></summary>
    let StakeholderMembership = _prefix "StakeholderMembership"
    /// <summary>
    /// A StateDefinition is the Definition of the Behavior of a system or part of a system in a certain state condition.
    /// <see href="http://open-services.net/ns/sysmlv2#StateDefinition"></see></summary>
    let StateDefinition = _prefix "StateDefinition"
    /// <summary>
    /// A StateSubactionKind indicates whether the action of a StateSubactionMembership is an entry, do or exit action.
    /// <see href="http://open-services.net/ns/sysmlv2#StateSubactionKind"></see></summary>
    let StateSubactionKind = _prefix "StateSubactionKind"
    /// <summary>
    /// A StateSubactionMembership is a FeatureMembership for an entry, do or exit ActionUsage of a StateDefinition or StateUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#StateSubactionMembership"></see></summary>
    let StateSubactionMembership = _prefix "StateSubactionMembership"
    /// <summary>
    /// Subclassification is Specialization in which both the specific and general Types are Classifier. This means all instances of the specific Classifier are also instances of the general Classifier.
    /// <see href="http://open-services.net/ns/sysmlv2#Subclassification"></see></summary>
    let Subclassification = _prefix "Subclassification"
    /// <summary>
    /// A SubjectMembership is a ParameterMembership that indicates that its ownedSubjectParameter is the subject of its owningType. The owningType of a SubjectMembership must be a RequirementDefinition, RequirementUsage, CaseDefinition, or CaseUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#SubjectMembership"></see></summary>
    let SubjectMembership = _prefix "SubjectMembership"
    /// <summary>
    /// A Succession is a binary Connector that requires its relatedFeatures to happen separately in time.
    /// <see href="http://open-services.net/ns/sysmlv2#Succession"></see></summary>
    let Succession = _prefix "Succession"
    /// <summary>
    /// A SuccessionAsUsage is both a ConnectorAsUsage and a Succession.
    /// <see href="http://open-services.net/ns/sysmlv2#SuccessionAsUsage"></see></summary>
    let SuccessionAsUsage = _prefix "SuccessionAsUsage"
    /// <summary>
    /// A SuccessionFlowConnectionUsage is a FlowConnectionUsage that is also a SuccessionItemFlow.
    /// <see href="http://open-services.net/ns/sysmlv2#SuccessionFlowConnectionUsage"></see></summary>
    let SuccessionFlowConnectionUsage = _prefix "SuccessionFlowConnectionUsage"
    /// <summary>
    /// A SuccessionItemFlow is an ItemFlow that also provides temporal ordering. It classifies Transfers that cannot start until the source Occurrence has completed and that must complete before the target Occurrence can start.
    /// <see href="http://open-services.net/ns/sysmlv2#SuccessionItemFlow"></see></summary>
    let SuccessionItemFlow = _prefix "SuccessionItemFlow"
    /// <summary>
    /// A TextualRepresentation is an AnnotatingElement whose body represents the representedElement in a given language. The representedElement must be the owner of the TextualRepresentation. The named language can be a natural language, in which case the body is an informal representation, or an artificial language, in which case the body is expected to be a formal, machine-parsable representation.
    /// <see href="http://open-services.net/ns/sysmlv2#TextualRepresentation"></see></summary>
    let TextualRepresentation = _prefix "TextualRepresentation"
    /// <summary>
    /// A TransitionActionKind indicates whether the transitionFeature of a TransitionFeatureMembership is a trigger, guard or effect.
    /// <see href="http://open-services.net/ns/sysmlv2#TransitionFeatureKind"></see></summary>
    let TransitionFeatureKind = _prefix "TransitionFeatureKind"
    /// <summary>
    /// A TransitionFeatureMembership is a FeatureMembership for a trigger, guard or effect of a TransitionUsage, whose transitionFeature is a AcceptActionUsage, Boolean-valued Expression or ActionUsage, depending on its kind. .
    /// <see href="http://open-services.net/ns/sysmlv2#TransitionFeatureMembership"></see></summary>
    let TransitionFeatureMembership = _prefix "TransitionFeatureMembership"
    /// <summary>
    /// A TransitionUsage is an ActionUsage representing a triggered transition between ActionUsages or StateUsages. When triggered by a triggerAction, when its guardExpression is true, the TransitionUsage asserts that its source is exited, then its effectAction (if any) is performed, and then its target is entered.
    /// <see href="http://open-services.net/ns/sysmlv2#TransitionUsage"></see></summary>
    let TransitionUsage = _prefix "TransitionUsage"
    /// <summary>
    /// A TriggerInvocationExpression is an InvocationExpression that invokes one of the trigger Functions from the Kernel Semantic Library Triggers package, as indicated by its kind.
    /// <see href="http://open-services.net/ns/sysmlv2#TriggerInvocationExpression"></see></summary>
    let TriggerInvocationExpression = _prefix "TriggerInvocationExpression"
    /// <summary>
    /// TriggerKind enumerates the kinds of triggers that can be represented by a TriggerInvocationExpression.
    /// <see href="http://open-services.net/ns/sysmlv2#TriggerKind"></see></summary>
    let TriggerKind = _prefix "TriggerKind"
    /// <summary>
    /// A TypeFeaturing is a Featuring Relationship in which the featureOfType is the source and the featuringType is the target.
    /// <see href="http://open-services.net/ns/sysmlv2#TypeFeaturing"></see></summary>
    let TypeFeaturing = _prefix "TypeFeaturing"
    /// <summary>
    /// Unioning is a Relationship that makes its unioningType one of the unioningTypes of its typeUnioned.
    /// <see href="http://open-services.net/ns/sysmlv2#Unioning"></see></summary>
    let Unioning = _prefix "Unioning"
    /// <summary>
    /// A UseCaseDefinition is a CaseDefinition that specifies a set of actions performed by its subject, in interaction with one or more actors external to the subject. The objective is to yield an observable result that is of value to one or more of the actors.
    /// <see href="http://open-services.net/ns/sysmlv2#UseCaseDefinition"></see></summary>
    let UseCaseDefinition = _prefix "UseCaseDefinition"
    /// <summary>
    /// A VariantMembership is a Membership between a variation point Definition or Usage and a Usage that represents a variant in the context of that variation. The membershipOwningNamespace for the VariantMembership must be either a Definition or a Usage with isVariation = true.
    /// <see href="http://open-services.net/ns/sysmlv2#VariantMembership"></see></summary>
    let VariantMembership = _prefix "VariantMembership"
    /// <summary>
    /// A VerificationCaseDefinition is a CaseDefinition for the purpose of verification of the subject of the case against its requirements.
    /// <see href="http://open-services.net/ns/sysmlv2#VerificationCaseDefinition"></see></summary>
    let VerificationCaseDefinition = _prefix "VerificationCaseDefinition"
    /// <summary>
    /// A VerificationCaseUsage is a Usage of a VerificationCaseDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#VerificationCaseUsage"></see></summary>
    let VerificationCaseUsage = _prefix "VerificationCaseUsage"
    /// <summary>
    /// A ViewDefinition is a PartDefinition that specifies how a view artifact is constructed to satisfy a viewpoint. It specifies a viewConditions to define the model content to be presented and a viewRendering to define how the model content is presented.
    /// <see href="http://open-services.net/ns/sysmlv2#ViewDefinition"></see></summary>
    let ViewDefinition = _prefix "ViewDefinition"
    /// <summary>
    /// A ViewRenderingMembership is a FeatureMembership that identifies the viewRendering of a ViewDefinition or ViewUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#ViewRenderingMembership"></see></summary>
    let ViewRenderingMembership = _prefix "ViewRenderingMembership"
    /// <summary>
    /// A ViewUsage is a usage of a ViewDefinition to specify the generation of a view of the members of a collection of exposedNamespaces. The ViewUsage can satisfy more viewpoints than its definition, and it can specialize the viewRendering specified by its definition.
    /// <see href="http://open-services.net/ns/sysmlv2#ViewUsage"></see></summary>
    let ViewUsage = _prefix "ViewUsage"
    /// <summary>
    /// A ViewpointDefinition is a RequirementDefinition that specifies one or more stakeholder concerns that are to be satisfied by creating a view of a model.
    /// <see href="http://open-services.net/ns/sysmlv2#ViewpointDefinition"></see></summary>
    let ViewpointDefinition = _prefix "ViewpointDefinition"
    /// <summary>
    /// A ViewpointUsage is a Usage of a ViewpointDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#ViewpointUsage"></see></summary>
    let ViewpointUsage = _prefix "ViewpointUsage"
    /// <summary>
    /// VisibilityKind is an enumeration whose literals specify the visibility of a Membership of an Element in a Namespace outside of that Namespace. Note that "visibility" specifically restricts whether an Element in a Namespace may be referenced by name from outside the Namespace and only otherwise restricts access to an Element as provided by specific constraints in the abstract syntax (e.g., preventing the import or inheritance of private Elements).
    /// <see href="http://open-services.net/ns/sysmlv2#VisibilityKind"></see></summary>
    let VisibilityKind = _prefix "VisibilityKind"
    /// <summary>
    /// A WhileLoopActionUsage is a LoopActionUsage that specifies that the bodyAction ActionUsage should be performed repeatedly while the result of the whileArgument Expression is true or until the result of the untilArgument Expression (if provided) is true. The whileArgument Expression is evaluated before each (possible) performance of the bodyAction, and the untilArgument Expression is evaluated after each performance of the bodyAction.
    /// <see href="http://open-services.net/ns/sysmlv2#WhileLoopActionUsage"></see></summary>
    let WhileLoopActionUsage = _prefix "WhileLoopActionUsage"
    /// <summary>
    /// An Expression whose result is bound to the payload parameter of this AcceptActionUsage. If provided, the AcceptActionUsage will only accept a Transfer with exactly this payload.
    /// <see href="http://open-services.net/ns/sysmlv2#acceptActionUsage_PayloadArgument"></see></summary>
    let acceptActionUsage_PayloadArgument = _prefix "acceptActionUsage_PayloadArgument"

    /// <summary>
    /// The nestedReference of this AcceptActionUsage that redefines the payload output parameter of the base AcceptActionUsage AcceptAction from the Systems Model Library.
    /// <see href="http://open-services.net/ns/sysmlv2#acceptActionUsage_PayloadParameter"></see></summary>
    let acceptActionUsage_PayloadParameter =
        _prefix "acceptActionUsage_PayloadParameter"

    /// <summary>
    /// An Expression whose result is bound to the receiver input parameter of this AcceptActionUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#acceptActionUsage_ReceiverArgument"></see></summary>
    let acceptActionUsage_ReceiverArgument =
        _prefix "acceptActionUsage_ReceiverArgument"

    /// <summary>
    /// The ActionUsages that are steps in this ActionDefinition, which define the actions that specify the behavior of the ActionDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#actionDefinition_Action"></see></summary>
    let actionDefinition_Action = _prefix "actionDefinition_Action"
    /// <summary>
    /// The Behaviors that are the types of this ActionUsage. Nominally, these would be ActionDefinitions, but other kinds of Kernel Behaviors are also allowed, to permit use of Behaviors from the Kernel Model Libraries.
    /// <see href="http://open-services.net/ns/sysmlv2#actionUsage_ActionDefinition"></see></summary>
    let actionUsage_ActionDefinition = _prefix "actionUsage_ActionDefinition"

    /// <summary>
    /// The PartUsage specifying the actor.
    /// <see href="http://open-services.net/ns/sysmlv2#actorMembership_OwnedActorParameter"></see></summary>
    let actorMembership_OwnedActorParameter =
        _prefix "actorMembership_OwnedActorParameter"

    /// <summary>
    /// The AllocationUsages that refine the allocation mapping defined by this AllocationDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#allocationDefinition_Allocation"></see></summary>
    let allocationDefinition_Allocation = _prefix "allocationDefinition_Allocation"

    /// <summary>
    /// The AllocationDefinitions that are the types of this AllocationUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#allocationUsage_AllocationDefinition"></see></summary>
    let allocationUsage_AllocationDefinition =
        _prefix "allocationUsage_AllocationDefinition"

    /// <summary>
    /// The composite actions of the AnalysisCaseDefinition that are defined as AnalysisActions.
    /// <see href="http://open-services.net/ns/sysmlv2#analysisCaseDefinition_AnalysisAction"></see></summary>
    let analysisCaseDefinition_AnalysisAction =
        _prefix "analysisCaseDefinition_AnalysisAction"

    /// <summary>
    /// An Expression used to compute the result of the AnalysisCaseDefinition, owned via a ResultExpressionMembership.
    /// <see href="http://open-services.net/ns/sysmlv2#analysisCaseDefinition_ResultExpression"></see></summary>
    let analysisCaseDefinition_ResultExpression =
        _prefix "analysisCaseDefinition_ResultExpression"

    /// <summary>
    /// The composite usages of the AnalysisCaseUsage that are defined as AnalysisActions.
    /// <see href="http://open-services.net/ns/sysmlv2#analysisCaseUsage_AnalysisAction"></see></summary>
    let analysisCaseUsage_AnalysisAction = _prefix "analysisCaseUsage_AnalysisAction"

    /// <summary>
    /// The AnalysisCaseDefinition that is the definition of this AnalysisCaseUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#analysisCaseUsage_AnalysisCaseDefinition"></see></summary>
    let analysisCaseUsage_AnalysisCaseDefinition =
        _prefix "analysisCaseUsage_AnalysisCaseDefinition"

    /// <summary>
    /// An Expression used to compute the result of the AnalysisCaseUsage, owned via a ResultExpressionMembership.
    /// <see href="http://open-services.net/ns/sysmlv2#analysisCaseUsage_ResultExpression"></see></summary>
    let analysisCaseUsage_ResultExpression =
        _prefix "analysisCaseUsage_ResultExpression"

    /// <summary>
    /// The Elements that are annotated by this AnnotatingElement. If annotation is not empty, these are the annotatedElements of the annotations. If annotation is empty, then it is the owningNamespace of the AnnotatingElement.
    /// <see href="http://open-services.net/ns/sysmlv2#annotatingElement_AnnotatedElement"></see></summary>
    let annotatingElement_AnnotatedElement =
        _prefix "annotatingElement_AnnotatedElement"

    /// <summary>
    /// The Annotations that relate this AnnotatingElement to its annotatedElements.
    /// <see href="http://open-services.net/ns/sysmlv2#annotatingElement_Annotation"></see></summary>
    let annotatingElement_Annotation = _prefix "annotatingElement_Annotation"

    /// <summary>
    /// The ownedRelationships of this AnnotatingElement that are Annotations, for which this AnnotatingElement is the annotatingElement.
    /// <see href="http://open-services.net/ns/sysmlv2#annotatingElement_OwnedAnnotatingRelationship"></see></summary>
    let annotatingElement_OwnedAnnotatingRelationship =
        _prefix "annotatingElement_OwnedAnnotatingRelationship"

    /// <summary>
    /// The Element that is annotated by the annotatingElement of this Annotation.
    /// <see href="http://open-services.net/ns/sysmlv2#annotation_AnnotatedElement"></see></summary>
    let annotation_AnnotatedElement = _prefix "annotation_AnnotatedElement"
    /// <summary>
    /// The AnnotatingElement that annotates the annotatedElement of this Annotation.
    /// <see href="http://open-services.net/ns/sysmlv2#annotation_AnnotatingElement"></see></summary>
    let annotation_AnnotatingElement = _prefix "annotation_AnnotatingElement"
    /// <summary>
    /// The annotatedElement of this Annotation, when it is also its owningRelatedElement.
    /// <see href="http://open-services.net/ns/sysmlv2#annotation_OwningAnnotatedElement"></see></summary>
    let annotation_OwningAnnotatedElement = _prefix "annotation_OwningAnnotatedElement"

    /// <summary>
    /// The annotatingElement of this Annotation, when it is also its owningRelatedElement.
    /// <see href="http://open-services.net/ns/sysmlv2#annotation_OwningAnnotatingElement"></see></summary>
    let annotation_OwningAnnotatingElement =
        _prefix "annotation_OwningAnnotatingElement"

    /// <summary>
    /// The ConstraintUsage to be performed by the AssertConstraintUsage. It is the referenceFeature of the ownedReferenceSubsetting for the AssertConstraintUsage, if there is one, and, otherwise, the AssertConstraintUsage itself.
    /// <see href="http://open-services.net/ns/sysmlv2#assertConstraintUsage_AssertedConstraint"></see></summary>
    let assertConstraintUsage_AssertedConstraint =
        _prefix "assertConstraintUsage_AssertedConstraint"

    /// <summary>
    /// The Feature whose value is to be set.
    /// <see href="http://open-services.net/ns/sysmlv2#assignmentActionUsage_Referent"></see></summary>
    let assignmentActionUsage_Referent = _prefix "assignmentActionUsage_Referent"

    /// <summary>
    /// The Expression whose value is an occurrence in the domain of the referent Feature, for which the value of the referent will be set to the result of the valueExpression by this AssignmentActionUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#assignmentActionUsage_TargetArgument"></see></summary>
    let assignmentActionUsage_TargetArgument =
        _prefix "assignmentActionUsage_TargetArgument"

    /// <summary>
    /// The Expression whose result is to be assigned to the referent Feature.
    /// <see href="http://open-services.net/ns/sysmlv2#assignmentActionUsage_ValueExpression"></see></summary>
    let assignmentActionUsage_ValueExpression =
        _prefix "assignmentActionUsage_ValueExpression"

    /// <summary>
    /// The features of the Association that identify the things that can be related by it. A concrete Association must have at least two associationEnds. When it has exactly two, the Association is called a binary Association.
    /// <see href="http://open-services.net/ns/sysmlv2#association_AssociationEnd"></see></summary>
    let association_AssociationEnd = _prefix "association_AssociationEnd"
    /// <summary>
    /// The types of the associationEnds of the Association, which are the relatedElements of the Association considered as a Relationship.
    /// <see href="http://open-services.net/ns/sysmlv2#association_RelatedType"></see></summary>
    let association_RelatedType = _prefix "association_RelatedType"
    /// <summary>
    /// The source relatedType for this Association. It is the first relatedType of the Association.
    /// <see href="http://open-services.net/ns/sysmlv2#association_SourceType"></see></summary>
    let association_SourceType = _prefix "association_SourceType"
    /// <summary>
    /// The target relatedTypes for this Association. This includes all the relatedTypes other than the sourceType.
    /// <see href="http://open-services.net/ns/sysmlv2#association_TargetType"></see></summary>
    let association_TargetType = _prefix "association_TargetType"

    /// <summary>
    /// The DataTypes that are the types of this AttributeUsage. Nominally, these are AttributeDefinitions, but other kinds of kernel DataTypes are also allowed, to permit use of DataTypes from the Kernel Model Libraries.
    /// <see href="http://open-services.net/ns/sysmlv2#attributeUsage_AttributeDefinition"></see></summary>
    let attributeUsage_AttributeDefinition =
        _prefix "attributeUsage_AttributeDefinition"

    /// <summary>
    /// The parameters of this Behavior, which are defined as its directedFeatures, whose values are passed into and/or out of a performance of the Behavior.
    /// <see href="http://open-services.net/ns/sysmlv2#behavior_Parameter"></see></summary>
    let behavior_Parameter = _prefix "behavior_Parameter"
    /// <summary>
    /// The Steps that make up this Behavior.
    /// <see href="http://open-services.net/ns/sysmlv2#behavior_Step"></see></summary>
    let behavior_Step = _prefix "behavior_Step"
    /// <summary>
    /// The Predicate that types this BooleanExpression.
    /// <see href="http://open-services.net/ns/sysmlv2#booleanExpression_Predicate"></see></summary>
    let booleanExpression_Predicate = _prefix "booleanExpression_Predicate"
    /// <summary>
    /// The actions of this CalculationDefinition that are CalculationUsages.
    /// <see href="http://open-services.net/ns/sysmlv2#calculationDefinition_Calculation"></see></summary>
    let calculationDefinition_Calculation = _prefix "calculationDefinition_Calculation"

    /// <summary>
    /// The Function that is the type of this CalculationUsage. Nominally, this would be a CalculationDefinition, but a kernel Function is also allowed, to permit use of Functions from the Kernel Model Libraries.
    /// <see href="http://open-services.net/ns/sysmlv2#calculationUsage_CalculationDefinition"></see></summary>
    let calculationUsage_CalculationDefinition =
        _prefix "calculationUsage_CalculationDefinition"

    /// <summary>
    /// The parameters of this CaseDefinition that represent actors involved in the case.
    /// <see href="http://open-services.net/ns/sysmlv2#caseDefinition_ActorParameter"></see></summary>
    let caseDefinition_ActorParameter = _prefix "caseDefinition_ActorParameter"

    /// <summary>
    /// The RequirementUsage representing the objective of this CaseDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#caseDefinition_ObjectiveRequirement"></see></summary>
    let caseDefinition_ObjectiveRequirement =
        _prefix "caseDefinition_ObjectiveRequirement"

    /// <summary>
    /// The parameter of this CaseDefinition that represents its subject.
    /// <see href="http://open-services.net/ns/sysmlv2#caseDefinition_SubjectParameter"></see></summary>
    let caseDefinition_SubjectParameter = _prefix "caseDefinition_SubjectParameter"
    /// <summary>
    /// The parameters of this CaseUsage that represent actors involved in the case.
    /// <see href="http://open-services.net/ns/sysmlv2#caseUsage_ActorParameter"></see></summary>
    let caseUsage_ActorParameter = _prefix "caseUsage_ActorParameter"
    /// <summary>
    /// The CaseDefinition that is the type of this CaseUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#caseUsage_CaseDefinition"></see></summary>
    let caseUsage_CaseDefinition = _prefix "caseUsage_CaseDefinition"
    /// <summary>
    /// The RequirementUsage representing the objective of this CaseUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#caseUsage_ObjectiveRequirement"></see></summary>
    let caseUsage_ObjectiveRequirement = _prefix "caseUsage_ObjectiveRequirement"
    /// <summary>
    /// The parameter of this CaseUsage that represents its subject.
    /// <see href="http://open-services.net/ns/sysmlv2#caseUsage_SubjectParameter"></see></summary>
    let caseUsage_SubjectParameter = _prefix "caseUsage_SubjectParameter"
    /// <summary>
    /// The ownedSpecializations of this Classifier that are Subclassifications, for which this Classifier is the subclassifier.
    /// <see href="http://open-services.net/ns/sysmlv2#classifier_OwnedSubclassification"></see></summary>
    let classifier_OwnedSubclassification = _prefix "classifier_OwnedSubclassification"
    /// <summary>
    /// The annotation text for the Comment.
    /// <see href="http://open-services.net/ns/sysmlv2#comment_Body"></see></summary>
    let comment_Body = _prefix "comment_Body"
    /// <summary>
    /// Identification of the language of the body text and, optionally, the region and/or encoding. The format shall be a POSIX locale conformant to ISO/IEC 15897, with the format [language[_territory][.codeset][@modifier]].
    /// <see href="http://open-services.net/ns/sysmlv2#comment_Locale"></see></summary>
    let comment_Locale = _prefix "comment_Locale"
    /// <summary>
    /// The ConcernDefinition that is the single type of this ConcernUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#concernUsage_ConcernDefinition"></see></summary>
    let concernUsage_ConcernDefinition = _prefix "concernUsage_ConcernDefinition"

    /// <summary>
    /// The original PortDefinition for this ConjugatedPortDefinition, which is the owningNamespace of the ConjugatedPortDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#conjugatedPortDefinition_OriginalPortDefinition"></see></summary>
    let conjugatedPortDefinition_OriginalPortDefinition =
        _prefix "conjugatedPortDefinition_OriginalPortDefinition"

    /// <summary>
    /// The PortConjugation that is the ownedConjugator of this ConjugatedPortDefinition, linking it to its originalPortDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#conjugatedPortDefinition_OwnedPortConjugator"></see></summary>
    let conjugatedPortDefinition_OwnedPortConjugator =
        _prefix "conjugatedPortDefinition_OwnedPortConjugator"

    /// <summary>
    /// The type of this ConjugatedPortTyping considered as a FeatureTyping, which must be a ConjugatedPortDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#conjugatedPortTyping_ConjugatedPortDefinition"></see></summary>
    let conjugatedPortTyping_ConjugatedPortDefinition =
        _prefix "conjugatedPortTyping_ConjugatedPortDefinition"

    /// <summary>
    /// The originalPortDefinition of the conjugatedPortDefinition of this ConjugatedPortTyping.
    /// <see href="http://open-services.net/ns/sysmlv2#conjugatedPortTyping_PortDefinition"></see></summary>
    let conjugatedPortTyping_PortDefinition =
        _prefix "conjugatedPortTyping_PortDefinition"

    /// <summary>
    /// The Type that is the result of applying Conjugation to the originalType.
    /// <see href="http://open-services.net/ns/sysmlv2#conjugation_ConjugatedType"></see></summary>
    let conjugation_ConjugatedType = _prefix "conjugation_ConjugatedType"
    /// <summary>
    /// The Type to be conjugated.
    /// <see href="http://open-services.net/ns/sysmlv2#conjugation_OriginalType"></see></summary>
    let conjugation_OriginalType = _prefix "conjugation_OriginalType"
    /// <summary>
    /// The conjugatedType of this Conjugation that is also its owningRelatedElement.
    /// <see href="http://open-services.net/ns/sysmlv2#conjugation_OwningType"></see></summary>
    let conjugation_OwningType = _prefix "conjugation_OwningType"

    /// <summary>
    /// The Usages that define the things related by the ConnectionDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#connectionDefinition_ConnectionEnd"></see></summary>
    let connectionDefinition_ConnectionEnd =
        _prefix "connectionDefinition_ConnectionEnd"

    /// <summary>
    /// The AssociationStructures that are the types of this ConnectionUsage. Nominally, these are , but other kinds of Kernel AssociationStructures are also allowed, to permit use of AssociationStructures from the Kernel Model Libraries.
    /// <see href="http://open-services.net/ns/sysmlv2#connectionUsage_ConnectionDefinition"></see></summary>
    let connectionUsage_ConnectionDefinition =
        _prefix "connectionUsage_ConnectionDefinition"

    /// <summary>
    /// The Associations that type the Connector.
    /// <see href="http://open-services.net/ns/sysmlv2#connector_Association"></see></summary>
    let connector_Association = _prefix "connector_Association"
    /// <summary>
    /// The endFeatures of a Connector, which redefine the endFeatures of the associations of the Connector. The connectorEnds determine via ReferenceSubsetting Relationships which Features are related by the Connector.
    /// <see href="http://open-services.net/ns/sysmlv2#connector_ConnectorEnd"></see></summary>
    let connector_ConnectorEnd = _prefix "connector_ConnectorEnd"
    /// <summary>
    /// The Features that are related by this Connector considered as a Relationship and that restrict the links it identifies, given by the referenced Features of the connectorEnds of the Connector.
    /// <see href="http://open-services.net/ns/sysmlv2#connector_RelatedFeature"></see></summary>
    let connector_RelatedFeature = _prefix "connector_RelatedFeature"
    /// <summary>
    /// The source relatedFeature for this Connector. It is the first relatedFeature.
    /// <see href="http://open-services.net/ns/sysmlv2#connector_SourceFeature"></see></summary>
    let connector_SourceFeature = _prefix "connector_SourceFeature"
    /// <summary>
    /// The target relatedFeatures for this Connector. This includes all the relatedFeatures other than the sourceFeature.
    /// <see href="http://open-services.net/ns/sysmlv2#connector_TargetFeature"></see></summary>
    let connector_TargetFeature = _prefix "connector_TargetFeature"

    /// <summary>
    /// The (single) Predicate that is the type of this ConstraintUsage. Nominally, this will be a ConstraintDefinition, but other kinds of Predicates are also allowed, to permit use of Predicates from the Kernel Model Libraries.
    /// <see href="http://open-services.net/ns/sysmlv2#constraintUsage_ConstraintDefinition"></see></summary>
    let constraintUsage_ConstraintDefinition =
        _prefix "constraintUsage_ConstraintDefinition"

    /// <summary>
    /// The usages of this Definition that are directedFeatures.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_DirectedUsage"></see></summary>
    let definition_DirectedUsage = _prefix "definition_DirectedUsage"
    /// <summary>
    /// Whether this Definition is for a variation point or not. If true, then all the memberships of the Definition must be VariantMemberships.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_IsVariation"></see></summary>
    let definition_IsVariation = _prefix "definition_IsVariation"
    /// <summary>
    /// The ActionUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedAction"></see></summary>
    let definition_OwnedAction = _prefix "definition_OwnedAction"
    /// <summary>
    /// The AllocationUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedAllocation"></see></summary>
    let definition_OwnedAllocation = _prefix "definition_OwnedAllocation"
    /// <summary>
    /// The AnalysisCaseUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedAnalysisCase"></see></summary>
    let definition_OwnedAnalysisCase = _prefix "definition_OwnedAnalysisCase"
    /// <summary>
    /// The AttributeUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedAttribute"></see></summary>
    let definition_OwnedAttribute = _prefix "definition_OwnedAttribute"
    /// <summary>
    /// The CalculationUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedCalculation"></see></summary>
    let definition_OwnedCalculation = _prefix "definition_OwnedCalculation"
    /// <summary>
    /// The code&gt;CaseUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedCase"></see></summary>
    let definition_OwnedCase = _prefix "definition_OwnedCase"
    /// <summary>
    /// The ConcernUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedConcern"></see></summary>
    let definition_OwnedConcern = _prefix "definition_OwnedConcern"
    /// <summary>
    /// The ConnectorAsUsages that are ownedUsages of this Definition. Note that this list includes BindingConnectorAsUsages and SuccessionAsUsages, even though these are ConnectorAsUsages but not ConnectionUsages.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedConnection"></see></summary>
    let definition_OwnedConnection = _prefix "definition_OwnedConnection"
    /// <summary>
    /// The ConstraintUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedConstraint"></see></summary>
    let definition_OwnedConstraint = _prefix "definition_OwnedConstraint"
    /// <summary>
    /// The EnumerationUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedEnumeration"></see></summary>
    let definition_OwnedEnumeration = _prefix "definition_OwnedEnumeration"
    /// <summary>
    /// The FlowConnectionUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedFlow"></see></summary>
    let definition_OwnedFlow = _prefix "definition_OwnedFlow"
    /// <summary>
    /// The InterfaceUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedInterface"></see></summary>
    let definition_OwnedInterface = _prefix "definition_OwnedInterface"
    /// <summary>
    /// The ItemUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedItem"></see></summary>
    let definition_OwnedItem = _prefix "definition_OwnedItem"
    /// <summary>
    /// The MetadataUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedMetadata"></see></summary>
    let definition_OwnedMetadata = _prefix "definition_OwnedMetadata"
    /// <summary>
    /// The OccurrenceUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedOccurrence"></see></summary>
    let definition_OwnedOccurrence = _prefix "definition_OwnedOccurrence"
    /// <summary>
    /// The PartUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedPart"></see></summary>
    let definition_OwnedPart = _prefix "definition_OwnedPart"
    /// <summary>
    /// The PortUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedPort"></see></summary>
    let definition_OwnedPort = _prefix "definition_OwnedPort"
    /// <summary>
    /// The ReferenceUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedReference"></see></summary>
    let definition_OwnedReference = _prefix "definition_OwnedReference"
    /// <summary>
    /// The RenderingUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedRendering"></see></summary>
    let definition_OwnedRendering = _prefix "definition_OwnedRendering"
    /// <summary>
    /// The RequirementUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedRequirement"></see></summary>
    let definition_OwnedRequirement = _prefix "definition_OwnedRequirement"
    /// <summary>
    /// The StateUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedState"></see></summary>
    let definition_OwnedState = _prefix "definition_OwnedState"
    /// <summary>
    /// The TransitionUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedTransition"></see></summary>
    let definition_OwnedTransition = _prefix "definition_OwnedTransition"
    /// <summary>
    /// The Usages that are ownedFeatures of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedUsage"></see></summary>
    let definition_OwnedUsage = _prefix "definition_OwnedUsage"
    /// <summary>
    /// The UseCaseUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedUseCase"></see></summary>
    let definition_OwnedUseCase = _prefix "definition_OwnedUseCase"
    /// <summary>
    /// The VerificationCaseUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedVerificationCase"></see></summary>
    let definition_OwnedVerificationCase = _prefix "definition_OwnedVerificationCase"
    /// <summary>
    /// The ViewUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedView"></see></summary>
    let definition_OwnedView = _prefix "definition_OwnedView"
    /// <summary>
    /// The ViewpointUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedViewpoint"></see></summary>
    let definition_OwnedViewpoint = _prefix "definition_OwnedViewpoint"
    /// <summary>
    /// The Usages that are features of this Definition (not necessarily owned).
    /// <see href="http://open-services.net/ns/sysmlv2#definition_Usage"></see></summary>
    let definition_Usage = _prefix "definition_Usage"
    /// <summary>
    /// The Usages which represent the variants of this Definition as a variation point Definition, if isVariation = true. If isVariation = false, the there must be no variants.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_Variant"></see></summary>
    let definition_Variant = _prefix "definition_Variant"
    /// <summary>
    /// The ownedMemberships of this Definition that are VariantMemberships. If isVariation = true, then this must be all ownedMemberships of the Definition. If isVariation = false, then variantMembershipmust be empty.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_VariantMembership"></see></summary>
    let definition_VariantMembership = _prefix "definition_VariantMembership"
    /// <summary>
    /// The Element or Elements dependent on the supplier Elements.
    /// <see href="http://open-services.net/ns/sysmlv2#dependency_Client"></see></summary>
    let dependency_Client = _prefix "dependency_Client"
    /// <summary>
    /// The Element or Elements on which the client Elements depend in some respect.
    /// <see href="http://open-services.net/ns/sysmlv2#dependency_Supplier"></see></summary>
    let dependency_Supplier = _prefix "dependency_Supplier"
    /// <summary>
    /// Type that partly determines interpretations of typeDifferenced, as described in Type::differencingType.
    /// <see href="http://open-services.net/ns/sysmlv2#differencing_DifferencingType"></see></summary>
    let differencing_DifferencingType = _prefix "differencing_DifferencingType"
    /// <summary>
    /// Type with interpretations partly determined by differencingType, as described in Type::differencingType.
    /// <see href="http://open-services.net/ns/sysmlv2#differencing_TypeDifferenced"></see></summary>
    let differencing_TypeDifferenced = _prefix "differencing_TypeDifferenced"
    /// <summary>
    /// Type asserted to be disjoint with the typeDisjoined.
    /// <see href="http://open-services.net/ns/sysmlv2#disjoining_DisjoiningType"></see></summary>
    let disjoining_DisjoiningType = _prefix "disjoining_DisjoiningType"
    /// <summary>
    /// A typeDisjoined that is also an owningRelatedElement.
    /// <see href="http://open-services.net/ns/sysmlv2#disjoining_OwningType"></see></summary>
    let disjoining_OwningType = _prefix "disjoining_OwningType"
    /// <summary>
    /// Type asserted to be disjoint with the disjoiningType.
    /// <see href="http://open-services.net/ns/sysmlv2#disjoining_TypeDisjoined"></see></summary>
    let disjoining_TypeDisjoined = _prefix "disjoining_TypeDisjoined"
    /// <summary>
    /// The Element that is documented by this Documentation.
    /// <see href="http://open-services.net/ns/sysmlv2#documentation_DocumentedElement"></see></summary>
    let documentation_DocumentedElement = _prefix "documentation_DocumentedElement"
    /// <summary>
    /// The model-level evaluable Boolean-valued Expression used to filter the imported members of the membershipOwningNamespace of this ElementFilterMembership.
    /// <see href="http://open-services.net/ns/sysmlv2#elementFilterMembership_Condition"></see></summary>
    let elementFilterMembership_Condition = _prefix "elementFilterMembership_Condition"
    /// <summary>
    /// Various alternative identifiers for this Element. Generally, these will be set by tools.
    /// <see href="http://open-services.net/ns/sysmlv2#element_AliasIds"></see></summary>
    let element_AliasIds = _prefix "element_AliasIds"
    /// <summary>
    /// The declared name of this Element.
    /// <see href="http://open-services.net/ns/sysmlv2#element_DeclaredName"></see></summary>
    let element_DeclaredName = _prefix "element_DeclaredName"
    /// <summary>
    /// An optional alternative name for the Element that is intended to be shorter or in some way more succinct than its primary name. It may act as a modeler-specified identifier for the Element, though it is then the responsibility of the modeler to maintain the uniqueness of this identifier within a model or relative to some other context.
    /// <see href="http://open-services.net/ns/sysmlv2#element_DeclaredShortName"></see></summary>
    let element_DeclaredShortName = _prefix "element_DeclaredShortName"
    /// <summary>
    /// The Documentation owned by this Element.
    /// <see href="http://open-services.net/ns/sysmlv2#element_Documentation"></see></summary>
    let element_Documentation = _prefix "element_Documentation"
    /// <summary>
    /// The globally unique identifier for this Element. This is intended to be set by tooling, and it must not change during the lifetime of the Element.
    /// <see href="http://open-services.net/ns/sysmlv2#element_ElementId"></see></summary>
    let element_ElementId = _prefix "element_ElementId"
    /// <summary>
    /// Whether all necessary implied Relationships have been included in the ownedRelationships of this Element. This property may be true, even if there are not actually any ownedRelationships with isImplied = true, meaning that no such Relationships are actually implied for this Element. However, if it is false, then ownedRelationships may not contain any implied Relationships. That is, either all required implied Relationships must be included, or none of them.
    /// <see href="http://open-services.net/ns/sysmlv2#element_IsImpliedIncluded"></see></summary>
    let element_IsImpliedIncluded = _prefix "element_IsImpliedIncluded"
    /// <summary>
    /// Whether this Element is contained in the ownership tree of a library model.
    /// <see href="http://open-services.net/ns/sysmlv2#element_IsLibraryElement"></see></summary>
    let element_IsLibraryElement = _prefix "element_IsLibraryElement"
    /// <summary>
    /// The name to be used for this Element during name resolution within its owningNamespace. This is derived using the effectiveName() operation. By default, it is the same as the declaredName, but this is overridden for certain kinds of Elements to compute a name even when the declaredName is null.
    /// <see href="http://open-services.net/ns/sysmlv2#element_Name"></see></summary>
    let element_Name = _prefix "element_Name"
    /// <summary>
    /// The ownedRelationships of this Element that are Annotations, for which this Element is the annotatedElement.
    /// <see href="http://open-services.net/ns/sysmlv2#element_OwnedAnnotation"></see></summary>
    let element_OwnedAnnotation = _prefix "element_OwnedAnnotation"
    /// <summary>
    /// The Elements owned by this Element, derived as the ownedRelatedElements of the ownedRelationships of this Element.
    /// <see href="http://open-services.net/ns/sysmlv2#element_OwnedElement"></see></summary>
    let element_OwnedElement = _prefix "element_OwnedElement"
    /// <summary>
    /// The Relationships for which this Element is the owningRelatedElement.
    /// <see href="http://open-services.net/ns/sysmlv2#element_OwnedRelationship"></see></summary>
    let element_OwnedRelationship = _prefix "element_OwnedRelationship"
    /// <summary>
    /// The owner of this Element, derived as the owningRelatedElement of the owningRelationship of this Element, if any.
    /// <see href="http://open-services.net/ns/sysmlv2#element_Owner"></see></summary>
    let element_Owner = _prefix "element_Owner"
    /// <summary>
    /// The owningRelationship of this Element, if that Relationship is a Membership.
    /// <see href="http://open-services.net/ns/sysmlv2#element_OwningMembership"></see></summary>
    let element_OwningMembership = _prefix "element_OwningMembership"
    /// <summary>
    /// The Namespace that owns this Element, which is the membershipOwningNamespace of the owningMembership of this Element, if any.
    /// <see href="http://open-services.net/ns/sysmlv2#element_OwningNamespace"></see></summary>
    let element_OwningNamespace = _prefix "element_OwningNamespace"
    /// <summary>
    /// The Relationship for which this Element is an ownedRelatedElement, if any.
    /// <see href="http://open-services.net/ns/sysmlv2#element_OwningRelationship"></see></summary>
    let element_OwningRelationship = _prefix "element_OwningRelationship"
    /// <summary>
    /// The full ownership-qualified name of this Element, represented in a form that is valid according to the KerML textual concrete syntax for qualified names (including use of unrestricted name notation and escaped characters, as necessary). The qualifiedName is null if this Element has no owningNamespace or if there is not a complete ownership chain of named Namespaces from a root Namespace to this Element.
    /// <see href="http://open-services.net/ns/sysmlv2#element_QualifiedName"></see></summary>
    let element_QualifiedName = _prefix "element_QualifiedName"
    /// <summary>
    /// The short name to be used for this Element during name resolution within its owningNamespace. This is derived using the effectiveShortName() operation. By default, it is the same as the declaredShortName, but this is overridden for certain kinds of Elements to compute a shortName even when the declaredName is null.
    /// <see href="http://open-services.net/ns/sysmlv2#element_ShortName"></see></summary>
    let element_ShortName = _prefix "element_ShortName"
    /// <summary>
    /// The TextualRepresentations that annotate this Element.
    /// <see href="http://open-services.net/ns/sysmlv2#element_TextualRepresentation"></see></summary>
    let element_TextualRepresentation = _prefix "element_TextualRepresentation"

    /// <summary>
    /// EnumerationUsages of this EnumerationDefinitionthat have distinct, fixed values. Each enumeratedValue specifies one of the allowed instances of the EnumerationDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#enumerationDefinition_EnumeratedValue"></see></summary>
    let enumerationDefinition_EnumeratedValue =
        _prefix "enumerationDefinition_EnumeratedValue"

    /// <summary>
    /// The single EnumerationDefinition that is the type of this EnumerationUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#enumerationUsage_EnumerationDefinition"></see></summary>
    let enumerationUsage_EnumerationDefinition =
        _prefix "enumerationUsage_EnumerationDefinition"

    /// <summary>
    /// The OccurrenceUsage referenced as an event by this EventOccurrenceUsage. It is the referenceFeature of the ownedReferenceSubsetting for the EventOccurrenceUsage, if there is one, and, otherwise, the EventOccurrenceUsage itself.
    /// <see href="http://open-services.net/ns/sysmlv2#eventOccurrenceUsage_EventOccurrence"></see></summary>
    let eventOccurrenceUsage_EventOccurrence =
        _prefix "eventOccurrenceUsage_EventOccurrence"

    /// <summary>
    /// The StateUsage to be exhibited by the ExhibitStateUsage. It is the performedAction of the ExhibitStateUsage considered as a PerformActionUsage, which must be a StateUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#exhibitStateUsage_ExhibitedState"></see></summary>
    let exhibitStateUsage_ExhibitedState = _prefix "exhibitStateUsage_ExhibitedState"
    /// <summary>
    /// The Function that types this Expression.
    /// <see href="http://open-services.net/ns/sysmlv2#expression_Function"></see></summary>
    let expression_Function = _prefix "expression_Function"
    /// <summary>
    /// Whether this Expression meets the constraints necessary to be evaluated at model level, that is, using metadata within the model.
    /// <see href="http://open-services.net/ns/sysmlv2#expression_IsModelLevelEvaluable"></see></summary>
    let expression_IsModelLevelEvaluable = _prefix "expression_IsModelLevelEvaluable"
    /// <summary>
    /// result.
    /// <see href="http://open-services.net/ns/sysmlv2#expression_Result"></see></summary>
    let expression_Result = _prefix "expression_Result"

    /// <summary>
    /// The Feature that is accessed by this FeatureChainExpression, which is its first non-parameter member.
    /// <see href="http://open-services.net/ns/sysmlv2#featureChainExpression_TargetFeature"></see></summary>
    let featureChainExpression_TargetFeature =
        _prefix "featureChainExpression_TargetFeature"

    /// <summary>
    /// The Feature whose values partly determine values of featureChained, as described in Feature::chainingFeature.
    /// <see href="http://open-services.net/ns/sysmlv2#featureChaining_ChainingFeature"></see></summary>
    let featureChaining_ChainingFeature = _prefix "featureChaining_ChainingFeature"
    /// <summary>
    /// The Feature whose values are partly determined by values of the chainingFeature, as described in Feature::chainingFeature.
    /// <see href="http://open-services.net/ns/sysmlv2#featureChaining_FeatureChained"></see></summary>
    let featureChaining_FeatureChained = _prefix "featureChaining_FeatureChained"
    /// <summary>
    /// Values of the Feature on each instance of its domain are determined externally to that instance and used internally.
    /// <see href="http://open-services.net/ns/sysmlv2#featureDirectionKind_In"></see></summary>
    let featureDirectionKind_In = _prefix "featureDirectionKind_In"
    /// <summary>
    /// Values of the Feature on each instance are determined either as in or out directions, or both.
    /// <see href="http://open-services.net/ns/sysmlv2#featureDirectionKind_Inout"></see></summary>
    let featureDirectionKind_Inout = _prefix "featureDirectionKind_Inout"
    /// <summary>
    /// Values of the Feature on each instance of its domain are determined internally to that instance and used externally.
    /// <see href="http://open-services.net/ns/sysmlv2#featureDirectionKind_Out"></see></summary>
    let featureDirectionKind_Out = _prefix "featureDirectionKind_Out"
    /// <summary>
    /// The Feature that is an inverse of the invertingFeature.
    /// <see href="http://open-services.net/ns/sysmlv2#featureInverting_FeatureInverted"></see></summary>
    let featureInverting_FeatureInverted = _prefix "featureInverting_FeatureInverted"
    /// <summary>
    /// The Feature that is an inverse of the invertedFeature.
    /// <see href="http://open-services.net/ns/sysmlv2#featureInverting_InvertingFeature"></see></summary>
    let featureInverting_InvertingFeature = _prefix "featureInverting_InvertingFeature"
    /// <summary>
    /// A featureInverted that is also the owningRelatedElement of this FeatureInverting.
    /// <see href="http://open-services.net/ns/sysmlv2#featureInverting_OwningFeature"></see></summary>
    let featureInverting_OwningFeature = _prefix "featureInverting_OwningFeature"

    /// <summary>
    /// The Feature that this FeatureMembership relates to its owningType, making it an ownedFeature of the owningType.
    /// <see href="http://open-services.net/ns/sysmlv2#featureMembership_OwnedMemberFeature"></see></summary>
    let featureMembership_OwnedMemberFeature =
        _prefix "featureMembership_OwnedMemberFeature"

    /// <summary>
    /// The Type that owns this FeatureMembership.
    /// <see href="http://open-services.net/ns/sysmlv2#featureMembership_OwningType"></see></summary>
    let featureMembership_OwningType = _prefix "featureMembership_OwningType"

    /// <summary>
    /// The Feature that is referenced by this FeatureReferenceExpression, which is its first non-parameter member.
    /// <see href="http://open-services.net/ns/sysmlv2#featureReferenceExpression_Referent"></see></summary>
    let featureReferenceExpression_Referent =
        _prefix "featureReferenceExpression_Referent"

    /// <summary>
    /// A typedFeature that is also the owningRelatedElement of this FeatureTyping.
    /// <see href="http://open-services.net/ns/sysmlv2#featureTyping_OwningFeature"></see></summary>
    let featureTyping_OwningFeature = _prefix "featureTyping_OwningFeature"
    /// <summary>
    /// The Type that is being applied by this FeatureTyping.
    /// <see href="http://open-services.net/ns/sysmlv2#featureTyping_Type"></see></summary>
    let featureTyping_Type = _prefix "featureTyping_Type"
    /// <summary>
    /// The Feature that has a type determined by this FeatureTyping.
    /// <see href="http://open-services.net/ns/sysmlv2#featureTyping_TypedFeature"></see></summary>
    let featureTyping_TypedFeature = _prefix "featureTyping_TypedFeature"
    /// <summary>
    /// The Feature to be provided a value.
    /// <see href="http://open-services.net/ns/sysmlv2#featureValue_FeatureWithValue"></see></summary>
    let featureValue_FeatureWithValue = _prefix "featureValue_FeatureWithValue"
    /// <summary>
    /// Whether this FeatureValue is a concrete specification of the bound or initial value of the featureWithValue, or just a default value that may be overridden.
    /// <see href="http://open-services.net/ns/sysmlv2#featureValue_IsDefault"></see></summary>
    let featureValue_IsDefault = _prefix "featureValue_IsDefault"
    /// <summary>
    /// Whether this FeatureValue specifies a bound value or an initial value for the featureWithValue.
    /// <see href="http://open-services.net/ns/sysmlv2#featureValue_IsInitial"></see></summary>
    let featureValue_IsInitial = _prefix "featureValue_IsInitial"
    /// <summary>
    /// The Expression that provides the value of the featureWithValue as its result.
    /// <see href="http://open-services.net/ns/sysmlv2#featureValue_Value"></see></summary>
    let featureValue_Value = _prefix "featureValue_Value"
    /// <summary>
    /// The Feature that are chained together to determine the values of this Feature, derived from the chainingFeatures of the ownedFeatureChainings of this Feature, in the same order. The values of a Feature with chainingFeatures are the same as values of the last Feature in the chain, which can be found by starting with the values of the first Feature (for each instance of the domain of the original Feature), then using each of those as domain instances to find the values of the second Feature in chainingFeatures, and so on, to values of the last Feature.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_ChainingFeature"></see></summary>
    let feature_ChainingFeature = _prefix "feature_ChainingFeature"
    /// <summary>
    /// Indicates how values of this Feature are determined or used (as specified for the FeatureDirectionKind).
    /// <see href="http://open-services.net/ns/sysmlv2#feature_Direction"></see></summary>
    let feature_Direction = _prefix "feature_Direction"
    /// <summary>
    /// The Type that is related to this Feature by an EndFeatureMembership in which the Feature is an ownedMemberFeature.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_EndOwningType"></see></summary>
    let feature_EndOwningType = _prefix "feature_EndOwningType"
    /// <summary>
    /// Types that feature this Feature, such that any instance in the domain of the Feature must be classified by all of these Types, including at least all the featuringTypes of its typeFeaturings.  If the Feature is chained, then the featuringTypes of the first Feature in the chain are also featuringTypes of the chained Feature.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_FeaturingType"></see></summary>
    let feature_FeaturingType = _prefix "feature_FeaturingType"
    /// <summary>
    /// Whether the Feature is a composite feature of its featuringType. If so, the values of the Feature cannot exist after its featuring instance no longer does.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_IsComposite"></see></summary>
    let feature_IsComposite = _prefix "feature_IsComposite"
    /// <summary>
    /// Whether the values of this Feature can always be computed from the values of other Features.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_IsDerived"></see></summary>
    let feature_IsDerived = _prefix "feature_IsDerived"
    /// <summary>
    /// Whether or not the this Feature is an end Feature, requiring a different interpretation of the multiplicity of the Feature.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_IsEnd"></see></summary>
    let feature_IsEnd = _prefix "feature_IsEnd"
    /// <summary>
    /// isNonunique.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_IsNonunique"></see></summary>
    let feature_IsNonunique = _prefix "feature_IsNonunique"
    /// <summary>
    /// Whether an order exists for the values of this Feature or not.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_IsOrdered"></see></summary>
    let feature_IsOrdered = _prefix "feature_IsOrdered"
    /// <summary>
    /// Whether the values of this Feature are contained in the space and time of instances of the domain of the Feature and represent the same thing as those instances.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_IsPortion"></see></summary>
    let feature_IsPortion = _prefix "feature_IsPortion"
    /// <summary>
    /// Whether the values of this Feature can change over the lifetime of an instance of the domain.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_IsReadOnly"></see></summary>
    let feature_IsReadOnly = _prefix "feature_IsReadOnly"
    /// <summary>
    /// Whether or not values for this Feature must have no duplicates or not.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_IsUnique"></see></summary>
    let feature_IsUnique = _prefix "feature_IsUnique"
    /// <summary>
    /// The ownedRelationships of this Feature that are FeatureChainings, for which the Feature will be the featureChained.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_OwnedFeatureChaining"></see></summary>
    let feature_OwnedFeatureChaining = _prefix "feature_OwnedFeatureChaining"
    /// <summary>
    /// The ownedRelationships of this Feature that are FeatureInvertings and for which the Feature is the featureInverted.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_OwnedFeatureInverting"></see></summary>
    let feature_OwnedFeatureInverting = _prefix "feature_OwnedFeatureInverting"
    /// <summary>
    /// The ownedSubsettings of this Feature that are Redefinitions, for which the Feature is the redefiningFeature.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_OwnedRedefinition"></see></summary>
    let feature_OwnedRedefinition = _prefix "feature_OwnedRedefinition"
    /// <summary>
    /// The one ownedSubsetting of this Feature, if any, that is a ReferenceSubsetting, for which the Feature is the referencingFeature.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_OwnedReferenceSubsetting"></see></summary>
    let feature_OwnedReferenceSubsetting = _prefix "feature_OwnedReferenceSubsetting"
    /// <summary>
    /// The ownedSpecializations of this Feature that are Subsettings, for which the Feature is the subsettingFeature.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_OwnedSubsetting"></see></summary>
    let feature_OwnedSubsetting = _prefix "feature_OwnedSubsetting"
    /// <summary>
    /// The ownedRelationships of this Feature that are TypeFeaturings and for which the Feature is the featureOfType.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_OwnedTypeFeaturing"></see></summary>
    let feature_OwnedTypeFeaturing = _prefix "feature_OwnedTypeFeaturing"
    /// <summary>
    /// The ownedSpecializations of this Feature that are FeatureTypings, for which the Feature is the typedFeature.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_OwnedTyping"></see></summary>
    let feature_OwnedTyping = _prefix "feature_OwnedTyping"
    /// <summary>
    /// The FeatureMembership that owns this Feature as an ownedMemberFeature, determining its owningType.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_OwningFeatureMembership"></see></summary>
    let feature_OwningFeatureMembership = _prefix "feature_OwningFeatureMembership"
    /// <summary>
    /// The Type that is the owningType of the owningFeatureMembership of this Feature.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_OwningType"></see></summary>
    let feature_OwningType = _prefix "feature_OwningType"
    /// <summary>
    /// Types that restrict the values of this Feature, such that the values must be instances of all the types. The types of a Feature are derived from its typings and the types of its subsettings. If the Feature is chained, then the types of the last Feature in the chain are also types of the chained Feature.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_Type"></see></summary>
    let feature_Type = _prefix "feature_Type"
    /// <summary>
    /// The Feature that is featured by the featuringType.
    /// <see href="http://open-services.net/ns/sysmlv2#featuring_Feature"></see></summary>
    let featuring_Feature = _prefix "featuring_Feature"
    /// <summary>
    /// The Type that features the featureOfType.
    /// <see href="http://open-services.net/ns/sysmlv2#featuring_Type"></see></summary>
    let featuring_Type = _prefix "featuring_Type"

    /// <summary>
    /// The Interactions that are the types of this FlowConnectionUsage. Nominally, these are FlowConnectionDefinitions, but other kinds of Kernel Interactions are also allowed, to permit use of Interactions from the Kernel Model Libraries.
    /// <see href="http://open-services.net/ns/sysmlv2#flowConnectionUsage_FlowConnectionDefinition"></see></summary>
    let flowConnectionUsage_FlowConnectionDefinition =
        _prefix "flowConnectionUsage_FlowConnectionDefinition"

    /// <summary>
    /// The ownedFeature of this ForLoopActionUsage that acts as the loop variable, which is assigned the successive values of the input sequence on each iteration. It is the ownedFeature that redefines ForLoopAction::var.
    /// <see href="http://open-services.net/ns/sysmlv2#forLoopActionUsage_LoopVariable"></see></summary>
    let forLoopActionUsage_LoopVariable = _prefix "forLoopActionUsage_LoopVariable"
    /// <summary>
    /// The Expression whose result provides the sequence of values to which the loopVariable is set for each iterative performance of the bodyAction. It is the Expression whose result is bound to the seq input parameter of this ForLoopActionUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#forLoopActionUsage_SeqArgument"></see></summary>
    let forLoopActionUsage_SeqArgument = _prefix "forLoopActionUsage_SeqArgument"

    /// <summary>
    /// The ConcernUsage that is the ownedConstraint of this FramedConcernMembership.
    /// <see href="http://open-services.net/ns/sysmlv2#framedConcernMembership_OwnedConcern"></see></summary>
    let framedConcernMembership_OwnedConcern =
        _prefix "framedConcernMembership_OwnedConcern"

    /// <summary>
    ///  The ConcernUsage that is referenced through this FramedConcernMembership. It is the referencedConstraint of the FramedConcernMembership considered as a RequirementConstraintMembership, which must be a ConcernUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#framedConcernMembership_ReferencedConcern"></see></summary>
    let framedConcernMembership_ReferencedConcern =
        _prefix "framedConcernMembership_ReferencedConcern"

    /// <summary>
    /// The Expressions that are steps in the calculation of the result of this Function.
    /// <see href="http://open-services.net/ns/sysmlv2#function_Expression"></see></summary>
    let function_Expression = _prefix "function_Expression"
    /// <summary>
    /// Whether this Function can be used as the function of a model-level evaluable InvocationExpression. Certain Functions from the Kernel Functions Library are considered to have isModelLevelEvaluable = true. For all other Functions it is false.
    /// <see href="http://open-services.net/ns/sysmlv2#function_IsModelLevelEvaluable"></see></summary>
    let function_IsModelLevelEvaluable = _prefix "function_IsModelLevelEvaluable"
    /// <summary>
    /// The result parameter of the Function, which is owned by the Function via a ReturnParameterMembership.
    /// <see href="http://open-services.net/ns/sysmlv2#function_Result"></see></summary>
    let function_Result = _prefix "function_Result"
    /// <summary>
    /// The ActionUsage that is to be performed if the result of the ifArgument is false. It is the (optional) third parameter of the IfActionUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#ifActionUsage_ElseAction"></see></summary>
    let ifActionUsage_ElseAction = _prefix "ifActionUsage_ElseAction"
    /// <summary>
    /// The Expression whose result determines whether the thenAction or (optionally) the elseAction is performed. It is the first parameter of the IfActionUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#ifActionUsage_IfArgument"></see></summary>
    let ifActionUsage_IfArgument = _prefix "ifActionUsage_IfArgument"
    /// <summary>
    /// The ActionUsage that is to be performed if the result of the ifArgument is true. It is the second parameter of the IfActionUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#ifActionUsage_ThenAction"></see></summary>
    let ifActionUsage_ThenAction = _prefix "ifActionUsage_ThenAction"
    /// <summary>
    /// The Namespace into which Memberships are imported by this Import, which must be the owningRelatedElement of the Import.
    /// <see href="http://open-services.net/ns/sysmlv2#import_ImportOwningNamespace"></see></summary>
    let import_ImportOwningNamespace = _prefix "import_ImportOwningNamespace"
    /// <summary>
    /// The effectively imported Element for this Import. For a MembershipImport, this is the memberElement of the importedMembership. For a NamespaceImport, it is the importedNamespace.
    /// <see href="http://open-services.net/ns/sysmlv2#import_ImportedElement"></see></summary>
    let import_ImportedElement = _prefix "import_ImportedElement"
    /// <summary>
    /// Whether to import memberships without regard to declared visibility.
    /// <see href="http://open-services.net/ns/sysmlv2#import_IsImportAll"></see></summary>
    let import_IsImportAll = _prefix "import_IsImportAll"
    /// <summary>
    /// Whether to recursively import Memberships from visible, owned sub-Namespaces.
    /// <see href="http://open-services.net/ns/sysmlv2#import_IsRecursive"></see></summary>
    let import_IsRecursive = _prefix "import_IsRecursive"
    /// <summary>
    /// The visibility level of the imported members from this Import relative to the importOwningNamespace.
    /// <see href="http://open-services.net/ns/sysmlv2#import_Visibility"></see></summary>
    let import_Visibility = _prefix "import_Visibility"

    /// <summary>
    /// The UseCaseUsage to be included by this IncludeUseCaseUsage. It is the performedAction of the IncludeUseCaseUsage considered as a PerformActionUsage, which must be a UseCaseUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#includeUseCaseUsage_UseCaseIncluded"></see></summary>
    let includeUseCaseUsage_UseCaseIncluded =
        _prefix "includeUseCaseUsage_UseCaseIncluded"

    /// <summary>
    /// The PortUsages that are the connectionEnds of this InterfaceDefinition.
    ///
    /// .
    /// <see href="http://open-services.net/ns/sysmlv2#interfaceDefinition_InterfaceEnd"></see></summary>
    let interfaceDefinition_InterfaceEnd = _prefix "interfaceDefinition_InterfaceEnd"

    /// <summary>
    /// The InterfaceDefinitions that type this InterfaceUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#interfaceUsage_InterfaceDefinition"></see></summary>
    let interfaceUsage_InterfaceDefinition =
        _prefix "interfaceUsage_InterfaceDefinition"

    /// <summary>
    /// Type that partly determines interpretations of typeIntersected, as described in Type::intersectingType.
    /// <see href="http://open-services.net/ns/sysmlv2#intersecting_IntersectingType"></see></summary>
    let intersecting_IntersectingType = _prefix "intersecting_IntersectingType"
    /// <summary>
    /// Type with interpretations partly determined by intersectingType, as described in Type::intersectingType.
    /// <see href="http://open-services.net/ns/sysmlv2#intersecting_TypeIntersected"></see></summary>
    let intersecting_TypeIntersected = _prefix "intersecting_TypeIntersected"
    /// <summary>
    /// Whether this Invariant is asserted to be false rather than true.
    /// <see href="http://open-services.net/ns/sysmlv2#invariant_IsNegated"></see></summary>
    let invariant_IsNegated = _prefix "invariant_IsNegated"
    /// <summary>
    /// The value Expressions of the FeatureValues of the owned input parameters of the InvocationExpression.
    /// <see href="http://open-services.net/ns/sysmlv2#invocationExpression_Argument"></see></summary>
    let invocationExpression_Argument = _prefix "invocationExpression_Argument"
    /// <summary>
    /// operand.
    /// <see href="http://open-services.net/ns/sysmlv2#invocationExpression_Operand"></see></summary>
    let invocationExpression_Operand = _prefix "invocationExpression_Operand"
    /// <summary>
    /// The Interactions that type this ItemFlow. Interactions are both Associations and Behaviors, which can type Connectors and Steps, respectively.
    /// <see href="http://open-services.net/ns/sysmlv2#itemFlow_Interaction"></see></summary>
    let itemFlow_Interaction = _prefix "itemFlow_Interaction"
    /// <summary>
    /// The ownedFeature of the ItemFlow that is an ItemFeature (if any).
    /// <see href="http://open-services.net/ns/sysmlv2#itemFlow_ItemFeature"></see></summary>
    let itemFlow_ItemFeature = _prefix "itemFlow_ItemFeature"
    /// <summary>
    /// The connectorEnds of this ItemFlow that are ItemFlowEnds.
    /// <see href="http://open-services.net/ns/sysmlv2#itemFlow_ItemFlowEnd"></see></summary>
    let itemFlow_ItemFlowEnd = _prefix "itemFlow_ItemFlowEnd"
    /// <summary>
    /// The type of values transferred, which is the type of the itemFeature of the ItemFlow.
    /// <see href="http://open-services.net/ns/sysmlv2#itemFlow_ItemType"></see></summary>
    let itemFlow_ItemType = _prefix "itemFlow_ItemType"
    /// <summary>
    /// The Feature that provides the items carried by the ItemFlow. It must be an owned output of the source of the ItemFlow.
    /// <see href="http://open-services.net/ns/sysmlv2#itemFlow_SourceOutputFeature"></see></summary>
    let itemFlow_SourceOutputFeature = _prefix "itemFlow_SourceOutputFeature"
    /// <summary>
    /// The Feature that receives the values carried by the ItemFlow. It must be an owned output of the target participant of the ItemFlow.
    /// <see href="http://open-services.net/ns/sysmlv2#itemFlow_TargetInputFeature"></see></summary>
    let itemFlow_TargetInputFeature = _prefix "itemFlow_TargetInputFeature"
    /// <summary>
    /// The Structures that are the definitions of this ItemUsage. Nominally, these are ItemDefinitions, but other kinds of Kernel Structures are also allowed, to permit use of Structures from the Kernel Library.
    /// <see href="http://open-services.net/ns/sysmlv2#itemUsage_ItemDefinition"></see></summary>
    let itemUsage_ItemDefinition = _prefix "itemUsage_ItemDefinition"
    /// <summary>
    /// Whether this LibraryPackage contains a standard library model. This should only be set to true for LibraryPackages in the standard Kernel Model Libraries or in normative model libraries for a language built on KerML.
    /// <see href="http://open-services.net/ns/sysmlv2#libraryPackage_IsStandard"></see></summary>
    let libraryPackage_IsStandard = _prefix "libraryPackage_IsStandard"
    /// <summary>
    /// The Boolean value that is the result of evaluating this LiteralBoolean.
    /// <see href="http://open-services.net/ns/sysmlv2#literalBoolean_Value"></see></summary>
    let literalBoolean_Value = _prefix "literalBoolean_Value"
    /// <summary>
    /// The Integer value that is the result of evaluating this LiteralInteger.
    /// <see href="http://open-services.net/ns/sysmlv2#literalInteger_Value"></see></summary>
    let literalInteger_Value = _prefix "literalInteger_Value"
    /// <summary>
    /// The value whose rational approximation is the result of evaluating this LiteralRational.
    /// <see href="http://open-services.net/ns/sysmlv2#literalRational_Value"></see></summary>
    let literalRational_Value = _prefix "literalRational_Value"
    /// <summary>
    /// The String value that is the result of evaluating this LiteralString.
    /// <see href="http://open-services.net/ns/sysmlv2#literalString_Value"></see></summary>
    let literalString_Value = _prefix "literalString_Value"
    /// <summary>
    /// The ActionUsage to be performed repeatedly by the LoopActionUsage. It is the second parameter of the LoopActionUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#loopActionUsage_BodyAction"></see></summary>
    let loopActionUsage_BodyAction = _prefix "loopActionUsage_BodyAction"

    /// <summary>
    /// The Membership to be imported.
    /// <see href="http://open-services.net/ns/sysmlv2#membershipImport_ImportedMembership"></see></summary>
    let membershipImport_ImportedMembership =
        _prefix "membershipImport_ImportedMembership"

    /// <summary>
    /// The Element that becomes a member of the membershipOwningNamespace due to this Membership.
    /// <see href="http://open-services.net/ns/sysmlv2#membership_MemberElement"></see></summary>
    let membership_MemberElement = _prefix "membership_MemberElement"
    /// <summary>
    /// The elementId of the memberElement.
    /// <see href="http://open-services.net/ns/sysmlv2#membership_MemberElementId"></see></summary>
    let membership_MemberElementId = _prefix "membership_MemberElementId"
    /// <summary>
    /// The name of the memberElement relative to the membershipOwningNamespace.
    /// <see href="http://open-services.net/ns/sysmlv2#membership_MemberName"></see></summary>
    let membership_MemberName = _prefix "membership_MemberName"
    /// <summary>
    /// The short name of the memberElement relative to the membershipOwningNamespace.
    /// <see href="http://open-services.net/ns/sysmlv2#membership_MemberShortName"></see></summary>
    let membership_MemberShortName = _prefix "membership_MemberShortName"

    /// <summary>
    /// The Namespace of which the memberElement becomes a member due to this Membership.
    /// <see href="http://open-services.net/ns/sysmlv2#membership_MembershipOwningNamespace"></see></summary>
    let membership_MembershipOwningNamespace =
        _prefix "membership_MembershipOwningNamespace"

    /// <summary>
    /// Whether or not the Membership of the memberElement in the membershipOwningNamespace is publicly visible outside that Namespace.
    /// <see href="http://open-services.net/ns/sysmlv2#membership_Visibility"></see></summary>
    let membership_Visibility = _prefix "membership_Visibility"

    /// <summary>
    ///  The Element whose metadata is being accessed.
    /// <see href="http://open-services.net/ns/sysmlv2#metadataAccessExpression_ReferencedElement"></see></summary>
    let metadataAccessExpression_ReferencedElement =
        _prefix "metadataAccessExpression_ReferencedElement"

    /// <summary>
    /// The type of this MetadataFeature, which must be a Metaclass.
    /// <see href="http://open-services.net/ns/sysmlv2#metadataFeature_Metaclass"></see></summary>
    let metadataFeature_Metaclass = _prefix "metadataFeature_Metaclass"
    /// <summary>
    /// The MetadataDefinition that is the definition of this MetadataUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#metadataUsage_MetadataDefinition"></see></summary>
    let metadataUsage_MetadataDefinition = _prefix "metadataUsage_MetadataDefinition"
    /// <summary>
    /// The owned Expressions of the MultiplicityRange whose results provide its bounds. These must be the only ownedMembers of the MultiplicityRange.
    /// <see href="http://open-services.net/ns/sysmlv2#multiplicityRange_Bound"></see></summary>
    let multiplicityRange_Bound = _prefix "multiplicityRange_Bound"
    /// <summary>
    /// The Expression whose result provides the lower bound of the MultiplicityRange. If no lowerBound Expression is given, then the lower bound shall have the same value as the upper bound, unless the upper bound is unbounded (*), in which case the lower bound shall be 0.
    /// <see href="http://open-services.net/ns/sysmlv2#multiplicityRange_LowerBound"></see></summary>
    let multiplicityRange_LowerBound = _prefix "multiplicityRange_LowerBound"
    /// <summary>
    /// The Expression whose result is the upper bound of the MultiplicityRange.
    /// <see href="http://open-services.net/ns/sysmlv2#multiplicityRange_UpperBound"></see></summary>
    let multiplicityRange_UpperBound = _prefix "multiplicityRange_UpperBound"
    /// <summary>
    /// The Namespace whose visible Memberships are imported by this NamespaceImport.
    /// <see href="http://open-services.net/ns/sysmlv2#namespaceImport_ImportedNamespace"></see></summary>
    let namespaceImport_ImportedNamespace = _prefix "namespaceImport_ImportedNamespace"
    /// <summary>
    /// The Memberships in this Namespace that result from the ownedImports of this Namespace.
    /// <see href="http://open-services.net/ns/sysmlv2#namespace_ImportedMembership"></see></summary>
    let namespace_ImportedMembership = _prefix "namespace_ImportedMembership"
    /// <summary>
    /// The set of all member Elements of this Namespace, which are the memberElements of all memberships of the Namespace.
    /// <see href="http://open-services.net/ns/sysmlv2#namespace_Member"></see></summary>
    let namespace_Member = _prefix "namespace_Member"
    /// <summary>
    /// All Memberships in this Namespace, including (at least) the union of ownedMemberships and importedMemberships.
    /// <see href="http://open-services.net/ns/sysmlv2#namespace_Membership"></see></summary>
    let namespace_Membership = _prefix "namespace_Membership"
    /// <summary>
    /// The ownedRelationships of this Namespace that are Imports, for which the Namespace is the importOwningNamespace.
    /// <see href="http://open-services.net/ns/sysmlv2#namespace_OwnedImport"></see></summary>
    let namespace_OwnedImport = _prefix "namespace_OwnedImport"
    /// <summary>
    /// The owned members of this Namespace, which are the ownedMemberElements of the ownedMemberships of the .
    /// <see href="http://open-services.net/ns/sysmlv2#namespace_OwnedMember"></see></summary>
    let namespace_OwnedMember = _prefix "namespace_OwnedMember"
    /// <summary>
    /// The ownedRelationships of this Namespace that are Memberships, for which the Namespace is the membershipOwningNamespace.
    /// <see href="http://open-services.net/ns/sysmlv2#namespace_OwnedMembership"></see></summary>
    let namespace_OwnedMembership = _prefix "namespace_OwnedMembership"

    /// <summary>
    /// The RequirementUsage that is the ownedMemberFeature of this RequirementUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#objectiveMembership_OwnedObjectiveRequirement"></see></summary>
    let objectiveMembership_OwnedObjectiveRequirement =
        _prefix "objectiveMembership_OwnedObjectiveRequirement"

    /// <summary>
    /// Whether this OccurrenceDefinition is constrained to represent single individual.
    /// <see href="http://open-services.net/ns/sysmlv2#occurrenceDefinition_IsIndividual"></see></summary>
    let occurrenceDefinition_IsIndividual = _prefix "occurrenceDefinition_IsIndividual"
    /// <summary>
    /// If isIndividual is true, a LifeClass that specializes this OccurrenceDefinition, restricting it to represent an individual.
    /// <see href="http://open-services.net/ns/sysmlv2#occurrenceDefinition_LifeClass"></see></summary>
    let occurrenceDefinition_LifeClass = _prefix "occurrenceDefinition_LifeClass"

    /// <summary>
    /// The at most one occurrenceDefinition that has isIndividual = true.
    /// <see href="http://open-services.net/ns/sysmlv2#occurrenceUsage_IndividualDefinition"></see></summary>
    let occurrenceUsage_IndividualDefinition =
        _prefix "occurrenceUsage_IndividualDefinition"

    /// <summary>
    /// Whether this OccurrenceUsage represents the usage of the specific individual (or portion of it) represented by its individualDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#occurrenceUsage_IsIndividual"></see></summary>
    let occurrenceUsage_IsIndividual = _prefix "occurrenceUsage_IsIndividual"

    /// <summary>
    /// The Classes that are the types of this OccurrenceUsage. Nominally, these are OccurrenceDefinitions, but other kinds of kernel Classes are also allowed, to permit use of Classes from the Kernel Model Libraries.
    /// <see href="http://open-services.net/ns/sysmlv2#occurrenceUsage_OccurrenceDefinition"></see></summary>
    let occurrenceUsage_OccurrenceDefinition =
        _prefix "occurrenceUsage_OccurrenceDefinition"

    /// <summary>
    /// The kind of (temporal) portion of the life of the occurrenceDefinition represented by this OccurrenceUsage, if it is so restricted.
    /// <see href="http://open-services.net/ns/sysmlv2#occurrenceUsage_PortionKind"></see></summary>
    let occurrenceUsage_PortionKind = _prefix "occurrenceUsage_PortionKind"
    /// <summary>
    /// An operator symbol that names a corresponding Function from one of the standard packages from the Kernel Function Library .
    /// <see href="http://open-services.net/ns/sysmlv2#operatorExpression_Operator"></see></summary>
    let operatorExpression_Operator = _prefix "operatorExpression_Operator"

    /// <summary>
    /// The Element that becomes an ownedMember of the membershipOwningNamespace due to this OwningMembership.
    /// <see href="http://open-services.net/ns/sysmlv2#owningMembership_OwnedMemberElement"></see></summary>
    let owningMembership_OwnedMemberElement =
        _prefix "owningMembership_OwnedMemberElement"

    /// <summary>
    /// The elementId of the ownedMemberElement.
    /// <see href="http://open-services.net/ns/sysmlv2#owningMembership_OwnedMemberElementId"></see></summary>
    let owningMembership_OwnedMemberElementId =
        _prefix "owningMembership_OwnedMemberElementId"

    /// <summary>
    /// The name of the ownedMemberElement.
    /// <see href="http://open-services.net/ns/sysmlv2#owningMembership_OwnedMemberName"></see></summary>
    let owningMembership_OwnedMemberName = _prefix "owningMembership_OwnedMemberName"

    /// <summary>
    /// The shortName of the ownedMemberElement.
    /// <see href="http://open-services.net/ns/sysmlv2#owningMembership_OwnedMemberShortName"></see></summary>
    let owningMembership_OwnedMemberShortName =
        _prefix "owningMembership_OwnedMemberShortName"

    /// <summary>
    /// The model-level evaluable Boolean-valued Expression used to filter the members of this Package, which are owned by the Package are via ElementFilterMemberships.
    /// <see href="http://open-services.net/ns/sysmlv2#package_FilterCondition"></see></summary>
    let package_FilterCondition = _prefix "package_FilterCondition"

    /// <summary>
    /// The Feature that is identified as a parameter by this ParameterMembership.
    /// <see href="http://open-services.net/ns/sysmlv2#parameterMembership_OwnedMemberParameter"></see></summary>
    let parameterMembership_OwnedMemberParameter =
        _prefix "parameterMembership_OwnedMemberParameter"

    /// <summary>
    /// The itemDefinitions of this PartUsage that are PartDefinitions.
    /// <see href="http://open-services.net/ns/sysmlv2#partUsage_PartDefinition"></see></summary>
    let partUsage_PartDefinition = _prefix "partUsage_PartDefinition"

    /// <summary>
    /// The ActionUsage to be performed by this PerformedActionUsage. It is the eventOccurrence of the PerformActionUsage considered as an EventOccurrenceUsage, which must be an ActionUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#performActionUsage_PerformedAction"></see></summary>
    let performActionUsage_PerformedAction =
        _prefix "performActionUsage_PerformedAction"

    /// <summary>
    /// The ConjugatedPortDefinition that is conjugate to the originalPortDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#portConjugation_ConjugatedPortDefinition"></see></summary>
    let portConjugation_ConjugatedPortDefinition =
        _prefix "portConjugation_ConjugatedPortDefinition"

    /// <summary>
    /// The PortDefinition being conjugated.
    /// <see href="http://open-services.net/ns/sysmlv2#portConjugation_OriginalPortDefinition"></see></summary>
    let portConjugation_OriginalPortDefinition =
        _prefix "portConjugation_OriginalPortDefinition"

    /// <summary>
    /// The  that is conjugate to this PortDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#portDefinition_ConjugatedPortDefinition"></see></summary>
    let portDefinition_ConjugatedPortDefinition =
        _prefix "portDefinition_ConjugatedPortDefinition"

    /// <summary>
    /// The occurrenceDefinitions of this PortUsage, which must all be PortDefinitions.
    /// <see href="http://open-services.net/ns/sysmlv2#portUsage_PortDefinition"></see></summary>
    let portUsage_PortDefinition = _prefix "portUsage_PortDefinition"
    /// <summary>
    /// A snapshot of an Occurrence (a time slice with zero duration).
    /// <see href="http://open-services.net/ns/sysmlv2#portionKind_Snapshot"></see></summary>
    let portionKind_Snapshot = _prefix "portionKind_Snapshot"
    /// <summary>
    /// A time slice of an Occurrence (a portion over time).
    /// <see href="http://open-services.net/ns/sysmlv2#portionKind_Timeslice"></see></summary>
    let portionKind_Timeslice = _prefix "portionKind_Timeslice"
    /// <summary>
    /// The Feature that is redefined by the redefiningFeature of this Redefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#redefinition_RedefinedFeature"></see></summary>
    let redefinition_RedefinedFeature = _prefix "redefinition_RedefinedFeature"
    /// <summary>
    /// The Feature that is redefining the redefinedFeature of this Redefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#redefinition_RedefiningFeature"></see></summary>
    let redefinition_RedefiningFeature = _prefix "redefinition_RedefiningFeature"

    /// <summary>
    /// The Feature that is referenced by the referencingFeature of this ReferenceSubsetting.
    /// <see href="http://open-services.net/ns/sysmlv2#referenceSubsetting_ReferencedFeature"></see></summary>
    let referenceSubsetting_ReferencedFeature =
        _prefix "referenceSubsetting_ReferencedFeature"

    /// <summary>
    /// The Feature that owns this ReferenceSubsetting relationship, which is also its subsettingFeature.
    /// <see href="http://open-services.net/ns/sysmlv2#referenceSubsetting_ReferencingFeature"></see></summary>
    let referenceSubsetting_ReferencingFeature =
        _prefix "referenceSubsetting_ReferencingFeature"

    /// <summary>
    /// Whether this Relationship was generated by tooling to meet semantic rules, rather than being directly created by a modeler.
    /// <see href="http://open-services.net/ns/sysmlv2#relationship_IsImplied"></see></summary>
    let relationship_IsImplied = _prefix "relationship_IsImplied"
    /// <summary>
    /// The relatedElements of this Relationship that are owned by the Relationship.
    /// <see href="http://open-services.net/ns/sysmlv2#relationship_OwnedRelatedElement"></see></summary>
    let relationship_OwnedRelatedElement = _prefix "relationship_OwnedRelatedElement"
    /// <summary>
    /// The relatedElement of this Relationship that owns the Relationship, if any.
    /// <see href="http://open-services.net/ns/sysmlv2#relationship_OwningRelatedElement"></see></summary>
    let relationship_OwningRelatedElement = _prefix "relationship_OwningRelatedElement"
    /// <summary>
    /// The Elements that are related by this Relationship, derived as the union of the source and target Elements of the Relationship.
    /// <see href="http://open-services.net/ns/sysmlv2#relationship_RelatedElement"></see></summary>
    let relationship_RelatedElement = _prefix "relationship_RelatedElement"
    /// <summary>
    /// The relatedElements from which this Relationship is considered to be directed.
    /// <see href="http://open-services.net/ns/sysmlv2#relationship_Source"></see></summary>
    let relationship_Source = _prefix "relationship_Source"
    /// <summary>
    /// The relatedElements to which this Relationship is considered to be directed.
    /// <see href="http://open-services.net/ns/sysmlv2#relationship_Target"></see></summary>
    let relationship_Target = _prefix "relationship_Target"
    /// <summary>
    /// The usages of a RenderingDefinition that are RenderingUsages.
    /// <see href="http://open-services.net/ns/sysmlv2#renderingDefinition_Rendering"></see></summary>
    let renderingDefinition_Rendering = _prefix "renderingDefinition_Rendering"

    /// <summary>
    /// The RenderingDefinition that is the definition of this RenderingUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#renderingUsage_RenderingDefinition"></see></summary>
    let renderingUsage_RenderingDefinition =
        _prefix "renderingUsage_RenderingDefinition"

    /// <summary>
    /// Indicates that a member ConstraintUsage of a RequirementDefinition or RequirementUsage represents an assumption.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementConstraintKind_Assumption"></see></summary>
    let requirementConstraintKind_Assumption =
        _prefix "requirementConstraintKind_Assumption"

    /// <summary>
    /// Indicates that a member ConstraintUsage of a RequirementDefinition or RequirementUsagerepresents an requirement.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementConstraintKind_Requirement"></see></summary>
    let requirementConstraintKind_Requirement =
        _prefix "requirementConstraintKind_Requirement"

    /// <summary>
    /// Whether the RequirementConstraintMembership is for an assumed or required ConstraintUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementConstraintMembership_Kind"></see></summary>
    let requirementConstraintMembership_Kind =
        _prefix "requirementConstraintMembership_Kind"

    /// <summary>
    /// The ConstraintUsage that is the ownedMemberFeature of this RequirementConstraintMembership.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementConstraintMembership_OwnedConstraint"></see></summary>
    let requirementConstraintMembership_OwnedConstraint =
        _prefix "requirementConstraintMembership_OwnedConstraint"

    /// <summary>
    ///  The ConstraintUsage that is referenced through this RequirementConstraintMembership. It is the referencedFeature of the ownedReferenceSubsetting of the ownedConstraint, if there is one, and, otherwise, the ownedConstraint itself.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementConstraintMembership_ReferencedConstraint"></see></summary>
    let requirementConstraintMembership_ReferencedConstraint =
        _prefix "requirementConstraintMembership_ReferencedConstraint"

    /// <summary>
    /// The parameters of this RequirementDefinition that represent actors involved in the requirement.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementDefinition_ActorParameter"></see></summary>
    let requirementDefinition_ActorParameter =
        _prefix "requirementDefinition_ActorParameter"

    /// <summary>
    /// The owned ConstraintUsages that represent assumptions of this RequirementDefinition, which are the ownedConstraints of the RequirementConstraintMemberships of the RequirementDefinition with kind = assumption.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementDefinition_AssumedConstraint"></see></summary>
    let requirementDefinition_AssumedConstraint =
        _prefix "requirementDefinition_AssumedConstraint"

    /// <summary>
    /// The ConcernUsages framed by this RequirementDefinition, which are the ownedConcerns of all FramedConcernMemberships of the RequirementDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementDefinition_FramedConcern"></see></summary>
    let requirementDefinition_FramedConcern =
        _prefix "requirementDefinition_FramedConcern"

    /// <summary>
    /// An optional modeler-specified identifier for this RequirementDefinition (used, e.g., to link it to an original requirement text in some source document), which is the declaredShortName for the RequirementDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementDefinition_ReqId"></see></summary>
    let requirementDefinition_ReqId = _prefix "requirementDefinition_ReqId"

    /// <summary>
    /// The owned ConstraintUsages that represent requirements of this RequirementDefinition, derived as the ownedConstraints of the RequirementConstraintMemberships of the RequirementDefinition with kind = requirement.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementDefinition_RequiredConstraint"></see></summary>
    let requirementDefinition_RequiredConstraint =
        _prefix "requirementDefinition_RequiredConstraint"

    /// <summary>
    /// The parameters of this RequirementDefinition that represent stakeholders for th requirement.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementDefinition_StakeholderParameter"></see></summary>
    let requirementDefinition_StakeholderParameter =
        _prefix "requirementDefinition_StakeholderParameter"

    /// <summary>
    /// The parameter of this RequirementDefinition that represents its subject.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementDefinition_SubjectParameter"></see></summary>
    let requirementDefinition_SubjectParameter =
        _prefix "requirementDefinition_SubjectParameter"

    /// <summary>
    /// An optional textual statement of the requirement represented by this RequirementDefinition, derived from the bodies of the documentation of the RequirementDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementDefinition_Text"></see></summary>
    let requirementDefinition_Text = _prefix "requirementDefinition_Text"
    /// <summary>
    /// The parameters of this RequirementUsage that represent actors involved in the requirement.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementUsage_ActorParameter"></see></summary>
    let requirementUsage_ActorParameter = _prefix "requirementUsage_ActorParameter"

    /// <summary>
    /// The owned ConstraintUsages that represent assumptions of this RequirementUsage, derived as the ownedConstraints of the RequirementConstraintMemberships of the RequirementUsage with kind = assumption.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementUsage_AssumedConstraint"></see></summary>
    let requirementUsage_AssumedConstraint =
        _prefix "requirementUsage_AssumedConstraint"

    /// <summary>
    /// The ConcernUsages framed by this RequirementUsage, which are the ownedConcerns of all FramedConcernMemberships of the RequirementUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementUsage_FramedConcern"></see></summary>
    let requirementUsage_FramedConcern = _prefix "requirementUsage_FramedConcern"
    /// <summary>
    /// An optional modeler-specified identifier for this RequirementUsage (used, e.g., to link it to an original requirement text in some source document), which is the declaredShortName for the RequirementUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementUsage_ReqId"></see></summary>
    let requirementUsage_ReqId = _prefix "requirementUsage_ReqId"

    /// <summary>
    /// The owned ConstraintUsages that represent requirements of this RequirementUsage, which are the ownedConstraints of the RequirementConstraintMemberships of the RequirementUsage with kind = requirement.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementUsage_RequiredConstraint"></see></summary>
    let requirementUsage_RequiredConstraint =
        _prefix "requirementUsage_RequiredConstraint"

    /// <summary>
    /// The RequirementDefinition that is the single definition of this RequirementUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementUsage_RequirementDefinition"></see></summary>
    let requirementUsage_RequirementDefinition =
        _prefix "requirementUsage_RequirementDefinition"

    /// <summary>
    /// The parameters of this RequirementUsage that represent stakeholders for the requirement.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementUsage_StakeholderParameter"></see></summary>
    let requirementUsage_StakeholderParameter =
        _prefix "requirementUsage_StakeholderParameter"

    /// <summary>
    /// The parameter of this RequirementUsage that represents its subject.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementUsage_SubjectParameter"></see></summary>
    let requirementUsage_SubjectParameter = _prefix "requirementUsage_SubjectParameter"
    /// <summary>
    /// An optional textual statement of the requirement represented by this RequirementUsage, derived from the bodies of the documentation of the RequirementUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementUsage_Text"></see></summary>
    let requirementUsage_Text = _prefix "requirementUsage_Text"

    /// <summary>
    /// The owned RequirementUsage that acts as the ownedConstraint for this RequirementVerificationMembership. This will either be the verifiedRequirement, or it will subset the verifiedRequirement.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementVerificationMembership_OwnedRequirement"></see></summary>
    let requirementVerificationMembership_OwnedRequirement =
        _prefix "requirementVerificationMembership_OwnedRequirement"

    /// <summary>
    ///  The RequirementUsage that is identified as being verified. It is the referencedConstraint of the RequirementVerificationMembership considered as a RequirementConstraintMembership, which must be a RequirementUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementVerificationMembership_VerifiedRequirement"></see></summary>
    let requirementVerificationMembership_VerifiedRequirement =
        _prefix "requirementVerificationMembership_VerifiedRequirement"

    /// <summary>
    /// The Expression that provides the result for the owner of the ResultExpressionMembership.
    /// <see href="http://open-services.net/ns/sysmlv2#resultExpressionMembership_OwnedResultExpression"></see></summary>
    let resultExpressionMembership_OwnedResultExpression =
        _prefix "resultExpressionMembership_OwnedResultExpression"

    /// <summary>
    /// The RequirementUsage that is satisfied by the satisfyingSubject of this SatisfyRequirementUsage. It is the assertedConstraint of the SatisfyRequirementUsage considered as an AssertConstraintUsage, which must be a RequirementUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#satisfyRequirementUsage_SatisfiedRequirement"></see></summary>
    let satisfyRequirementUsage_SatisfiedRequirement =
        _prefix "satisfyRequirementUsage_SatisfiedRequirement"

    /// <summary>
    /// The Feature that represents the actual subject that is asserted to satisfy the satisfiedRequirement. The satisfyingFeature is bound to the subjectParameter of the SatisfyRequirementUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#satisfyRequirementUsage_SatisfyingFeature"></see></summary>
    let satisfyRequirementUsage_SatisfyingFeature =
        _prefix "satisfyRequirementUsage_SatisfyingFeature"

    /// <summary>
    /// An Expression whose result is bound to the payload input parameter of this SendActionUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#sendActionUsage_PayloadArgument"></see></summary>
    let sendActionUsage_PayloadArgument = _prefix "sendActionUsage_PayloadArgument"
    /// <summary>
    /// An Expression whose result is bound to the receiver input parameter of this SendActionUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#sendActionUsage_ReceiverArgument"></see></summary>
    let sendActionUsage_ReceiverArgument = _prefix "sendActionUsage_ReceiverArgument"
    /// <summary>
    /// An Expression whose result is bound to the sender input parameter of this SendActionUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#sendActionUsage_SenderArgument"></see></summary>
    let sendActionUsage_SenderArgument = _prefix "sendActionUsage_SenderArgument"
    /// <summary>
    /// A Type with a superset of all instances of the specific Type, which might be the same set.
    /// <see href="http://open-services.net/ns/sysmlv2#specialization_General"></see></summary>
    let specialization_General = _prefix "specialization_General"
    /// <summary>
    /// The Type that is the specific Type of this Specialization and owns it as its owningRelatedElement.
    /// <see href="http://open-services.net/ns/sysmlv2#specialization_OwningType"></see></summary>
    let specialization_OwningType = _prefix "specialization_OwningType"
    /// <summary>
    /// A Type with a subset of all instances of the general Type, which might be the same set.
    /// <see href="http://open-services.net/ns/sysmlv2#specialization_Specific"></see></summary>
    let specialization_Specific = _prefix "specialization_Specific"

    /// <summary>
    /// The PartUsage specifying the stakeholder.
    /// <see href="http://open-services.net/ns/sysmlv2#stakeholderMembership_OwnedStakeholderParameter"></see></summary>
    let stakeholderMembership_OwnedStakeholderParameter =
        _prefix "stakeholderMembership_OwnedStakeholderParameter"

    /// <summary>
    /// The ActionUsage of this StateDefinition to be performed while in the state defined by the StateDefinition. It is the owned ActionUsage related to the StateDefinition by a StateSubactionMembership  with kind = do.
    /// <see href="http://open-services.net/ns/sysmlv2#stateDefinition_DoAction"></see></summary>
    let stateDefinition_DoAction = _prefix "stateDefinition_DoAction"
    /// <summary>
    /// The ActionUsage of this StateDefinition to be performed on entry to the state defined by the StateDefinition. It is the owned ActionUsage related to the StateDefinition by a StateSubactionMembership  with kind = entry.
    /// <see href="http://open-services.net/ns/sysmlv2#stateDefinition_EntryAction"></see></summary>
    let stateDefinition_EntryAction = _prefix "stateDefinition_EntryAction"
    /// <summary>
    /// The ActionUsage of this StateDefinition to be performed on exit to the state defined by the StateDefinition. It is the owned ActionUsage related to the StateDefinition by a StateSubactionMembership  with kind = exit.
    /// <see href="http://open-services.net/ns/sysmlv2#stateDefinition_ExitAction"></see></summary>
    let stateDefinition_ExitAction = _prefix "stateDefinition_ExitAction"
    /// <summary>
    /// Whether the ownedStates of this StateDefinition are to all be performed in parallel. If true, none of the ownedActions (which includes ownedStates) may have any incoming or outgoing Transitions. If false, only one ownedState may be performed at a time.
    /// <see href="http://open-services.net/ns/sysmlv2#stateDefinition_IsParallel"></see></summary>
    let stateDefinition_IsParallel = _prefix "stateDefinition_IsParallel"
    /// <summary>
    /// The StateUsages, which are actions in the StateDefinition, that specify the discrete states in the behavior defined by the StateDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#stateDefinition_State"></see></summary>
    let stateDefinition_State = _prefix "stateDefinition_State"
    /// <summary>
    /// Indicates that the action of a StateSubactionMembership is a doAction.
    /// <see href="http://open-services.net/ns/sysmlv2#stateSubactionKind_Do"></see></summary>
    let stateSubactionKind_Do = _prefix "stateSubactionKind_Do"
    /// <summary>
    /// Indicates that the action of a StateSubactionMembership is an entryAction.
    /// <see href="http://open-services.net/ns/sysmlv2#stateSubactionKind_Entry"></see></summary>
    let stateSubactionKind_Entry = _prefix "stateSubactionKind_Entry"
    /// <summary>
    /// Indicates that the action of a StateSubactionMembership is an exitAction.
    /// <see href="http://open-services.net/ns/sysmlv2#stateSubactionKind_Exit"></see></summary>
    let stateSubactionKind_Exit = _prefix "stateSubactionKind_Exit"
    /// <summary>
    /// The ActionUsage that is the ownedMemberFeature of this StateSubactionMembership.
    /// <see href="http://open-services.net/ns/sysmlv2#stateSubactionMembership_Action"></see></summary>
    let stateSubactionMembership_Action = _prefix "stateSubactionMembership_Action"
    /// <summary>
    /// Whether this StateSubactionMembership is for an entry, do or exit ActionUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#stateSubactionMembership_Kind"></see></summary>
    let stateSubactionMembership_Kind = _prefix "stateSubactionMembership_Kind"
    /// <summary>
    /// The ActionUsage of this StateUsage to be performed while in the state defined by the StateDefinition. It is the owned ActionUsage related to the StateUsage by a StateSubactionMembership  with kind = do.
    /// <see href="http://open-services.net/ns/sysmlv2#stateUsage_DoAction"></see></summary>
    let stateUsage_DoAction = _prefix "stateUsage_DoAction"
    /// <summary>
    /// The ActionUsage of this StateUsage to be performed on entry to the state defined by the StateDefinition. It is the owned ActionUsage related to the StateUsage by a StateSubactionMembership  with kind = entry.
    /// <see href="http://open-services.net/ns/sysmlv2#stateUsage_EntryAction"></see></summary>
    let stateUsage_EntryAction = _prefix "stateUsage_EntryAction"
    /// <summary>
    /// The ActionUsage of this StateUsage to be performed on exit to the state defined by the StateDefinition. It is the owned ActionUsage related to the StateUsage by a StateSubactionMembership  with kind = exit.
    /// <see href="http://open-services.net/ns/sysmlv2#stateUsage_ExitAction"></see></summary>
    let stateUsage_ExitAction = _prefix "stateUsage_ExitAction"
    /// <summary>
    /// Whether the nestedStates of this StateUsage are to all be performed in parallel. If true, none of the nestedActions (which include nestedStates) may have any incoming or outgoing Transitions. If false, only one nestedState may be performed at a time.
    /// <see href="http://open-services.net/ns/sysmlv2#stateUsage_IsParallel"></see></summary>
    let stateUsage_IsParallel = _prefix "stateUsage_IsParallel"
    /// <summary>
    /// The Behaviors that are the types of this StateUsage. Nominally, these would be StateDefinitions, but kernel Behaviors are also allowed, to permit use of Behaviors from the Kernel Model Libraries.
    /// <see href="http://open-services.net/ns/sysmlv2#stateUsage_StateDefinition"></see></summary>
    let stateUsage_StateDefinition = _prefix "stateUsage_StateDefinition"
    /// <summary>
    /// The Behaviors that type this Step.
    /// <see href="http://open-services.net/ns/sysmlv2#step_Behavior"></see></summary>
    let step_Behavior = _prefix "step_Behavior"
    /// <summary>
    /// The parameters of this Step, which are defined as its directedFeatures, whose values are passed into and/or out of a performance of the Step.
    /// <see href="http://open-services.net/ns/sysmlv2#step_Parameter"></see></summary>
    let step_Parameter = _prefix "step_Parameter"

    /// <summary>
    /// The Classifier that owns this Subclassification relationship, which must also be its subclassifier.
    /// <see href="http://open-services.net/ns/sysmlv2#subclassification_OwningClassifier"></see></summary>
    let subclassification_OwningClassifier =
        _prefix "subclassification_OwningClassifier"

    /// <summary>
    /// The more specific Classifier in this Subclassification.
    /// <see href="http://open-services.net/ns/sysmlv2#subclassification_Subclassifier"></see></summary>
    let subclassification_Subclassifier = _prefix "subclassification_Subclassifier"
    /// <summary>
    /// The more general Classifier in this Subclassification.
    /// <see href="http://open-services.net/ns/sysmlv2#subclassification_Superclassifier"></see></summary>
    let subclassification_Superclassifier = _prefix "subclassification_Superclassifier"

    /// <summary>
    /// The UsageownedMemberParameter of this SubjectMembership.
    /// <see href="http://open-services.net/ns/sysmlv2#subjectMembership_OwnedSubjectParameter"></see></summary>
    let subjectMembership_OwnedSubjectParameter =
        _prefix "subjectMembership_OwnedSubjectParameter"

    /// <summary>
    /// A subsettingFeature that is also the owningRelatedElement of this Subsetting.
    /// <see href="http://open-services.net/ns/sysmlv2#subsetting_OwningFeature"></see></summary>
    let subsetting_OwningFeature = _prefix "subsetting_OwningFeature"
    /// <summary>
    /// The Feature that is subsetted by the subsettingFeature of this Subsetting.
    /// <see href="http://open-services.net/ns/sysmlv2#subsetting_SubsettedFeature"></see></summary>
    let subsetting_SubsettedFeature = _prefix "subsetting_SubsettedFeature"
    /// <summary>
    /// The Feature that is a subset of the subsettedFeature of this Subsetting.
    /// <see href="http://open-services.net/ns/sysmlv2#subsetting_SubsettingFeature"></see></summary>
    let subsetting_SubsettingFeature = _prefix "subsetting_SubsettingFeature"
    /// <summary>
    /// Steps that represent occurrences that are side effects of the transitionStep occurring.
    /// <see href="http://open-services.net/ns/sysmlv2#succession_EffectStep"></see></summary>
    let succession_EffectStep = _prefix "succession_EffectStep"
    /// <summary>
    /// Expressions that must evaluate to true before the transitionStep can occur.
    /// <see href="http://open-services.net/ns/sysmlv2#succession_GuardExpression"></see></summary>
    let succession_GuardExpression = _prefix "succession_GuardExpression"
    /// <summary>
    /// A Step that is typed by the Behavior TransitionPerformances::TransitionPerformance (from the Kernel Semantic Library) that has this Succession as its transitionLink.
    /// <see href="http://open-services.net/ns/sysmlv2#succession_TransitionStep"></see></summary>
    let succession_TransitionStep = _prefix "succession_TransitionStep"
    /// <summary>
    /// Steps that map incoming events to the timing of occurrences of the transitionStep. The values of triggerStep subset the list of acceptable events to be received by a Behavior or the object that performs it.
    /// <see href="http://open-services.net/ns/sysmlv2#succession_TriggerStep"></see></summary>
    let succession_TriggerStep = _prefix "succession_TriggerStep"
    /// <summary>
    /// The textual representation of the representedElement in the given language.
    /// <see href="http://open-services.net/ns/sysmlv2#textualRepresentation_Body"></see></summary>
    let textualRepresentation_Body = _prefix "textualRepresentation_Body"
    /// <summary>
    /// The natural or artifical language in which the body text is written.
    /// <see href="http://open-services.net/ns/sysmlv2#textualRepresentation_Language"></see></summary>
    let textualRepresentation_Language = _prefix "textualRepresentation_Language"

    /// <summary>
    /// The Element that is represented by this TextualRepresentation.
    /// <see href="http://open-services.net/ns/sysmlv2#textualRepresentation_RepresentedElement"></see></summary>
    let textualRepresentation_RepresentedElement =
        _prefix "textualRepresentation_RepresentedElement"

    /// <summary>
    /// Indicates that the transitionFeature of a TransitionFeatureMembership is an effectAction.
    /// <see href="http://open-services.net/ns/sysmlv2#transitionFeatureKind_Effect"></see></summary>
    let transitionFeatureKind_Effect = _prefix "transitionFeatureKind_Effect"
    /// <summary>
    /// Indicates that the transitionFeature of a TransitionFeatureMembership is a guardExpression.
    /// <see href="http://open-services.net/ns/sysmlv2#transitionFeatureKind_Guard"></see></summary>
    let transitionFeatureKind_Guard = _prefix "transitionFeatureKind_Guard"
    /// <summary>
    /// Indicates that the transitionFeature of a TransitionFeatureMembership is a triggerAction.
    /// <see href="http://open-services.net/ns/sysmlv2#transitionFeatureKind_Trigger"></see></summary>
    let transitionFeatureKind_Trigger = _prefix "transitionFeatureKind_Trigger"
    /// <summary>
    /// Whether this TransitionFeatureMembership  is for a trigger, guard or effect.
    /// <see href="http://open-services.net/ns/sysmlv2#transitionFeatureMembership_Kind"></see></summary>
    let transitionFeatureMembership_Kind = _prefix "transitionFeatureMembership_Kind"

    /// <summary>
    /// The Step that is the ownedMemberFeature of this TransitionFeatureMembership.
    /// <see href="http://open-services.net/ns/sysmlv2#transitionFeatureMembership_TransitionFeature"></see></summary>
    let transitionFeatureMembership_TransitionFeature =
        _prefix "transitionFeatureMembership_TransitionFeature"

    /// <summary>
    /// The ActionUsages that define the effects of this TransitionUsage, which are the ownedFeatures of the TransitionUsage related to it by TransitionFeatureMemberships with kind = effect, which must all be ActionUsages.
    /// <see href="http://open-services.net/ns/sysmlv2#transitionUsage_EffectAction"></see></summary>
    let transitionUsage_EffectAction = _prefix "transitionUsage_EffectAction"
    /// <summary>
    /// The Expressions that define the guards of this TransitionUsage, which are the ownedFeatures of the TransitionUsage related to it by TransitionFeatureMemberships with kind = guard, which must all be Expressions.
    /// <see href="http://open-services.net/ns/sysmlv2#transitionUsage_GuardExpression"></see></summary>
    let transitionUsage_GuardExpression = _prefix "transitionUsage_GuardExpression"
    /// <summary>
    /// The source ActionUsage of this TransitionUsage, which becomes the source of the succession for the TransitionUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#transitionUsage_Source"></see></summary>
    let transitionUsage_Source = _prefix "transitionUsage_Source"
    /// <summary>
    /// The Succession that is the ownedFeature of this TransitionUsage, which, if the TransitionUsage is triggered, asserts the temporal ordering of the source and target.
    /// <see href="http://open-services.net/ns/sysmlv2#transitionUsage_Succession"></see></summary>
    let transitionUsage_Succession = _prefix "transitionUsage_Succession"
    /// <summary>
    /// The target ActionUsage of this TransitionUsage, which is the targetFeature of the succession for the TransitionUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#transitionUsage_Target"></see></summary>
    let transitionUsage_Target = _prefix "transitionUsage_Target"
    /// <summary>
    /// The AcceptActionUsages that define the triggers of this TransitionUsage, which are the ownedFeatures of the TransitionUsage related to it by TransitionFeatureMemberships with kind = trigger, which must all be AcceptActionUsages.
    /// <see href="http://open-services.net/ns/sysmlv2#transitionUsage_TriggerAction"></see></summary>
    let transitionUsage_TriggerAction = _prefix "transitionUsage_TriggerAction"
    /// <summary>
    /// Indicates which of the Functions from the Triggers model in the Kernel Semantic Library is to be invoked by this TriggerInvocationExpression.
    /// <see href="http://open-services.net/ns/sysmlv2#triggerInvocationExpression_Kind"></see></summary>
    let triggerInvocationExpression_Kind = _prefix "triggerInvocationExpression_Kind"
    /// <summary>
    /// Indicates a relative time trigger, corresponding to the TriggerAfter Function from the Triggers model in the Kernel Semantic Library.
    /// <see href="http://open-services.net/ns/sysmlv2#triggerKind_After"></see></summary>
    let triggerKind_After = _prefix "triggerKind_After"
    /// <summary>
    /// Indicates an absolute time trigger, corresponding to the TriggerAt Function from the Triggers model in the Kernel Semantic Library.
    /// <see href="http://open-services.net/ns/sysmlv2#triggerKind_At"></see></summary>
    let triggerKind_At = _prefix "triggerKind_At"
    /// <summary>
    /// Indicates a change trigger, corresponding to the TriggerWhen Function from the Triggers model in the Kernel Semantic Library.
    /// <see href="http://open-services.net/ns/sysmlv2#triggerKind_When"></see></summary>
    let triggerKind_When = _prefix "triggerKind_When"
    /// <summary>
    /// The Feature that is featured by the featuringType. It is the source of the TypeFeaturing.
    /// <see href="http://open-services.net/ns/sysmlv2#typeFeaturing_FeatureOfType"></see></summary>
    let typeFeaturing_FeatureOfType = _prefix "typeFeaturing_FeatureOfType"
    /// <summary>
    /// The Type that features the featureOfType. It is the target of the TypeFeaturing.
    /// <see href="http://open-services.net/ns/sysmlv2#typeFeaturing_FeaturingType"></see></summary>
    let typeFeaturing_FeaturingType = _prefix "typeFeaturing_FeaturingType"
    /// <summary>
    /// A featureOfType that is also the owningRelatedElement of this TypeFeaturing.
    /// <see href="http://open-services.net/ns/sysmlv2#typeFeaturing_OwningFeatureOfType"></see></summary>
    let typeFeaturing_OwningFeatureOfType = _prefix "typeFeaturing_OwningFeatureOfType"
    /// <summary>
    /// The interpretations of a Type with differencingTypes are asserted to be those of the first of those Types, but not including those of the remaining Types. For example, a Classifier might be the difference of a Classifier for people and another for people of a particular nationality, leaving people who are not of that nationality. Similarly, a feature of people might be the difference between a feature for their children and a Classifier for people of a particular sex, identifying their children not of that sex (because the interpretations of the children Feature that identify those of that sex are also interpretations of the Classifier for that sex).
    /// <see href="http://open-services.net/ns/sysmlv2#type_DifferencingType"></see></summary>
    let type_DifferencingType = _prefix "type_DifferencingType"
    /// <summary>
    /// The features of this Type that have a non-null direction.
    /// <see href="http://open-services.net/ns/sysmlv2#type_DirectedFeature"></see></summary>
    let type_DirectedFeature = _prefix "type_DirectedFeature"
    /// <summary>
    /// All features of this Type with isEnd = true.
    /// <see href="http://open-services.net/ns/sysmlv2#type_EndFeature"></see></summary>
    let type_EndFeature = _prefix "type_EndFeature"
    /// <summary>
    /// The ownedMemberFeatures of the featureMemberships of this Type.
    /// <see href="http://open-services.net/ns/sysmlv2#type_Feature"></see></summary>
    let type_Feature = _prefix "type_Feature"
    /// <summary>
    /// The FeatureMemberships for features of this Type, which include all ownedFeatureMemberships and those inheritedMemberships that are FeatureMemberships (but does not include any importedMemberships).
    /// <see href="http://open-services.net/ns/sysmlv2#type_FeatureMembership"></see></summary>
    let type_FeatureMembership = _prefix "type_FeatureMembership"
    /// <summary>
    /// All the memberFeatures of the inheritedMemberships of this Type that are FeatureMemberships.
    /// <see href="http://open-services.net/ns/sysmlv2#type_InheritedFeature"></see></summary>
    let type_InheritedFeature = _prefix "type_InheritedFeature"
    /// <summary>
    /// All Memberships inherited by this Type via Specialization or Conjugation. These are included in the derived union for the memberships of the Type.
    /// <see href="http://open-services.net/ns/sysmlv2#type_InheritedMembership"></see></summary>
    let type_InheritedMembership = _prefix "type_InheritedMembership"
    /// <summary>
    /// All features related to this Type by FeatureMemberships that have direction in or inout.
    /// <see href="http://open-services.net/ns/sysmlv2#type_Input"></see></summary>
    let type_Input = _prefix "type_Input"
    /// <summary>
    /// The interpretations of a Type with intersectingTypes are asserted to be those in common among the intersectingTypes, which are the Types derived from the intersectingType of the ownedIntersectings of this Type. For example, a Classifier might be an intersection of Classifiers for people of a particular sex and of a particular nationality. Similarly, a feature for people's children of a particular sex might be the intersection of a Feature for their children and a Classifier for people of that sex (because the interpretations of the children Feature that identify those of that sex are also interpretations of the Classifier for that sex).
    /// <see href="http://open-services.net/ns/sysmlv2#type_IntersectingType"></see></summary>
    let type_IntersectingType = _prefix "type_IntersectingType"
    /// <summary>
    /// Indicates whether instances of this Type must also be instances of at least one of its specialized Types.
    /// <see href="http://open-services.net/ns/sysmlv2#type_IsAbstract"></see></summary>
    let type_IsAbstract = _prefix "type_IsAbstract"
    /// <summary>
    /// Indicates whether this Type has an ownedConjugator.
    /// <see href="http://open-services.net/ns/sysmlv2#type_IsConjugated"></see></summary>
    let type_IsConjugated = _prefix "type_IsConjugated"
    /// <summary>
    /// Whether all things that meet the classification conditions of this Type must be classified by the Type.
    /// <see href="http://open-services.net/ns/sysmlv2#type_IsSufficient"></see></summary>
    let type_IsSufficient = _prefix "type_IsSufficient"
    /// <summary>
    /// An ownedMember of this Type that is a Multiplicity, which constraints the cardinality of the Type. If there is no such ownedMember, then the cardinality of this Type is constrained by all the Multiplicity constraints applicable to any direct supertypes.
    /// <see href="http://open-services.net/ns/sysmlv2#type_Multiplicity"></see></summary>
    let type_Multiplicity = _prefix "type_Multiplicity"
    /// <summary>
    /// All features related to this Type by FeatureMemberships that have direction out or inout.
    /// <see href="http://open-services.net/ns/sysmlv2#type_Output"></see></summary>
    let type_Output = _prefix "type_Output"
    /// <summary>
    /// A Conjugation owned by this Type for which the Type is the originalType.
    /// <see href="http://open-services.net/ns/sysmlv2#type_OwnedConjugator"></see></summary>
    let type_OwnedConjugator = _prefix "type_OwnedConjugator"
    /// <summary>
    /// The ownedRelationships of this Type that are Differencings, having this Type as their typeDifferenced.
    /// <see href="http://open-services.net/ns/sysmlv2#type_OwnedDifferencing"></see></summary>
    let type_OwnedDifferencing = _prefix "type_OwnedDifferencing"
    /// <summary>
    /// The ownedRelationships of this Type that are Disjoinings, for which the Type is the typeDisjoined Type.
    /// <see href="http://open-services.net/ns/sysmlv2#type_OwnedDisjoining"></see></summary>
    let type_OwnedDisjoining = _prefix "type_OwnedDisjoining"
    /// <summary>
    /// All endFeatures of this Type that are ownedFeatures.
    /// <see href="http://open-services.net/ns/sysmlv2#type_OwnedEndFeature"></see></summary>
    let type_OwnedEndFeature = _prefix "type_OwnedEndFeature"
    /// <summary>
    /// The ownedMemberFeatures of the ownedFeatureMemberships of this Type.
    /// <see href="http://open-services.net/ns/sysmlv2#type_OwnedFeature"></see></summary>
    let type_OwnedFeature = _prefix "type_OwnedFeature"
    /// <summary>
    /// The ownedMemberships of this Type that are FeatureMemberships, for which the Type is the owningType. Each such FeatureMembership identifies an ownedFeature of the Type.
    /// <see href="http://open-services.net/ns/sysmlv2#type_OwnedFeatureMembership"></see></summary>
    let type_OwnedFeatureMembership = _prefix "type_OwnedFeatureMembership"
    /// <summary>
    /// The ownedRelationships of this Type that are Intersectings, have the Type as their typeIntersected.
    /// <see href="http://open-services.net/ns/sysmlv2#type_OwnedIntersecting"></see></summary>
    let type_OwnedIntersecting = _prefix "type_OwnedIntersecting"
    /// <summary>
    /// The ownedRelationships of this Type that are Specializations, for which the Type is the specific Type.
    /// <see href="http://open-services.net/ns/sysmlv2#type_OwnedSpecialization"></see></summary>
    let type_OwnedSpecialization = _prefix "type_OwnedSpecialization"
    /// <summary>
    /// The ownedRelationships of this Type that are Unionings, having the Type as their typeUnioned.
    /// <see href="http://open-services.net/ns/sysmlv2#type_OwnedUnioning"></see></summary>
    let type_OwnedUnioning = _prefix "type_OwnedUnioning"
    /// <summary>
    /// The interpretations of a Type with unioningTypes are asserted to be the same as those of all the unioningTypes together, which are the Types derived from the unioningType of the ownedUnionings of this Type. For example, a Classifier for people might be the union of Classifiers for all the sexes. Similarly, a feature for people's children might be the union of features dividing them in the same ways as people in general.
    /// <see href="http://open-services.net/ns/sysmlv2#type_UnioningType"></see></summary>
    let type_UnioningType = _prefix "type_UnioningType"
    /// <summary>
    /// Type with interpretations partly determined by unioningType, as described in Type::unioningType.
    /// <see href="http://open-services.net/ns/sysmlv2#unioning_TypeUnioned"></see></summary>
    let unioning_TypeUnioned = _prefix "unioning_TypeUnioned"
    /// <summary>
    /// Type that partly determines interpretations of typeUnioned, as described in Type::unioningType.
    /// <see href="http://open-services.net/ns/sysmlv2#unioning_UnioningType"></see></summary>
    let unioning_UnioningType = _prefix "unioning_UnioningType"
    /// <summary>
    /// The Classifiers that are the types of this Usage. Nominally, these are Definitions, but other kinds of Kernel Classifiers are also allowed, to permit use of Classifiers from the Kernel Model Libraries.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_Definition"></see></summary>
    let usage_Definition = _prefix "usage_Definition"
    /// <summary>
    /// The usages of this Usage that are directedFeatures.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_DirectedUsage"></see></summary>
    let usage_DirectedUsage = _prefix "usage_DirectedUsage"
    /// <summary>
    /// Whether this Usage is a referential Usage, that is, it has isComposite = false.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_IsReference"></see></summary>
    let usage_IsReference = _prefix "usage_IsReference"
    /// <summary>
    /// Whether this Usage is for a variation point or not. If true, then all the memberships of the Usage must be VariantMemberships.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_IsVariation"></see></summary>
    let usage_IsVariation = _prefix "usage_IsVariation"
    /// <summary>
    /// The ActionUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedAction"></see></summary>
    let usage_NestedAction = _prefix "usage_NestedAction"
    /// <summary>
    /// The AllocationUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedAllocation"></see></summary>
    let usage_NestedAllocation = _prefix "usage_NestedAllocation"
    /// <summary>
    /// The AnalysisCaseUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedAnalysisCase"></see></summary>
    let usage_NestedAnalysisCase = _prefix "usage_NestedAnalysisCase"
    /// <summary>
    /// The code&gt;AttributeUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedAttribute"></see></summary>
    let usage_NestedAttribute = _prefix "usage_NestedAttribute"
    /// <summary>
    /// The CalculationUsage that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedCalculation"></see></summary>
    let usage_NestedCalculation = _prefix "usage_NestedCalculation"
    /// <summary>
    /// The CaseUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedCase"></see></summary>
    let usage_NestedCase = _prefix "usage_NestedCase"
    /// <summary>
    /// The ConcernUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedConcern"></see></summary>
    let usage_NestedConcern = _prefix "usage_NestedConcern"
    /// <summary>
    /// The ConnectorAsUsages that are nestedUsages of this Usage. Note that this list includes BindingConnectorAsUsages and SuccessionAsUsages, even though these are ConnectorAsUsages but not ConnectionUsages.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedConnection"></see></summary>
    let usage_NestedConnection = _prefix "usage_NestedConnection"
    /// <summary>
    /// The ConstraintUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedConstraint"></see></summary>
    let usage_NestedConstraint = _prefix "usage_NestedConstraint"
    /// <summary>
    /// The code&gt;EnumerationUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedEnumeration"></see></summary>
    let usage_NestedEnumeration = _prefix "usage_NestedEnumeration"
    /// <summary>
    /// The code&gt;FlowConnectionUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedFlow"></see></summary>
    let usage_NestedFlow = _prefix "usage_NestedFlow"
    /// <summary>
    /// The InterfaceUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedInterface"></see></summary>
    let usage_NestedInterface = _prefix "usage_NestedInterface"
    /// <summary>
    /// The ItemUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedItem"></see></summary>
    let usage_NestedItem = _prefix "usage_NestedItem"
    /// <summary>
    /// The MetadataUsages that are nestedUsages of this of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedMetadata"></see></summary>
    let usage_NestedMetadata = _prefix "usage_NestedMetadata"
    /// <summary>
    /// The OccurrenceUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedOccurrence"></see></summary>
    let usage_NestedOccurrence = _prefix "usage_NestedOccurrence"
    /// <summary>
    /// The PartUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedPart"></see></summary>
    let usage_NestedPart = _prefix "usage_NestedPart"
    /// <summary>
    /// The PortUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedPort"></see></summary>
    let usage_NestedPort = _prefix "usage_NestedPort"
    /// <summary>
    /// The ReferenceUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedReference"></see></summary>
    let usage_NestedReference = _prefix "usage_NestedReference"
    /// <summary>
    /// The RenderingUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedRendering"></see></summary>
    let usage_NestedRendering = _prefix "usage_NestedRendering"
    /// <summary>
    /// The RequirementUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedRequirement"></see></summary>
    let usage_NestedRequirement = _prefix "usage_NestedRequirement"
    /// <summary>
    /// The StateUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedState"></see></summary>
    let usage_NestedState = _prefix "usage_NestedState"
    /// <summary>
    /// The TransitionUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedTransition"></see></summary>
    let usage_NestedTransition = _prefix "usage_NestedTransition"
    /// <summary>
    /// The Usages that are ownedFeatures of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedUsage"></see></summary>
    let usage_NestedUsage = _prefix "usage_NestedUsage"
    /// <summary>
    /// The UseCaseUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedUseCase"></see></summary>
    let usage_NestedUseCase = _prefix "usage_NestedUseCase"
    /// <summary>
    /// The VerificationCaseUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedVerificationCase"></see></summary>
    let usage_NestedVerificationCase = _prefix "usage_NestedVerificationCase"
    /// <summary>
    /// The ViewUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedView"></see></summary>
    let usage_NestedView = _prefix "usage_NestedView"
    /// <summary>
    /// The ViewpointUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedViewpoint"></see></summary>
    let usage_NestedViewpoint = _prefix "usage_NestedViewpoint"
    /// <summary>
    /// The Definition that owns this Usage (if any).
    /// <see href="http://open-services.net/ns/sysmlv2#usage_OwningDefinition"></see></summary>
    let usage_OwningDefinition = _prefix "usage_OwningDefinition"
    /// <summary>
    /// The Usage in which this Usage is nested (if any).
    /// <see href="http://open-services.net/ns/sysmlv2#usage_OwningUsage"></see></summary>
    let usage_OwningUsage = _prefix "usage_OwningUsage"
    /// <summary>
    /// The Usages that are features of this Usage (not necessarily owned).
    /// <see href="http://open-services.net/ns/sysmlv2#usage_Usage"></see></summary>
    let usage_Usage = _prefix "usage_Usage"
    /// <summary>
    /// The Usages which represent the variants of this Usage as a variation point Usage, if isVariation = true. If isVariation = false, then there must be no variants.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_Variant"></see></summary>
    let usage_Variant = _prefix "usage_Variant"
    /// <summary>
    /// The ownedMemberships of this Usage that are VariantMemberships. If isVariation = true, then this must be all memberships of the Usage. If isVariation = false, then variantMembershipmust be empty.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_VariantMembership"></see></summary>
    let usage_VariantMembership = _prefix "usage_VariantMembership"
    /// <summary>
    /// The UseCaseUsages that are included by this UseCaseDefinition, which are the useCaseIncludeds of the IncludeUseCaseUsages owned by this UseCaseDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#useCaseDefinition_IncludedUseCase"></see></summary>
    let useCaseDefinition_IncludedUseCase = _prefix "useCaseDefinition_IncludedUseCase"
    /// <summary>
    /// The UseCaseUsages that are included by this UseCaseUse, which are the useCaseIncludeds of the IncludeUseCaseUsages owned by this UseCaseUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#useCaseUsage_IncludedUseCase"></see></summary>
    let useCaseUsage_IncludedUseCase = _prefix "useCaseUsage_IncludedUseCase"
    /// <summary>
    /// The UseCaseDefinition that is the definition of this UseCaseUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#useCaseUsage_UseCaseDefinition"></see></summary>
    let useCaseUsage_UseCaseDefinition = _prefix "useCaseUsage_UseCaseDefinition"

    /// <summary>
    /// The Usage that represents a variant in the context of the owningVariationDefinition or owningVariationUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#variantMembership_OwnedVariantUsage"></see></summary>
    let variantMembership_OwnedVariantUsage =
        _prefix "variantMembership_OwnedVariantUsage"

    /// <summary>
    /// The RequirementUsages verified by this VerificationCaseDefinition, which are the verifiedRequirements of all RequirementVerificationMemberships of the objectiveRequirement.
    /// <see href="http://open-services.net/ns/sysmlv2#verificationCaseDefinition_VerifiedRequirement"></see></summary>
    let verificationCaseDefinition_VerifiedRequirement =
        _prefix "verificationCaseDefinition_VerifiedRequirement"

    /// <summary>
    /// The VerificationCase that is the definition of this VerificationCaseUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#verificationCaseUsage_VerificationCaseDefinition"></see></summary>
    let verificationCaseUsage_VerificationCaseDefinition =
        _prefix "verificationCaseUsage_VerificationCaseDefinition"

    /// <summary>
    /// The RequirementUsages verified by this VerificationCaseUsage, which are the verifiedRequirements of all RequirementVerificationMemberships of the objectiveRequirement.
    /// <see href="http://open-services.net/ns/sysmlv2#verificationCaseUsage_VerifiedRequirement"></see></summary>
    let verificationCaseUsage_VerifiedRequirement =
        _prefix "verificationCaseUsage_VerifiedRequirement"

    /// <summary>
    /// The composite ownedRequirements of this ViewDefinition that are ViewpointUsages for viewpoints satisfied by the ViewDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#viewDefinition_SatisfiedViewpoint"></see></summary>
    let viewDefinition_SatisfiedViewpoint = _prefix "viewDefinition_SatisfiedViewpoint"
    /// <summary>
    /// The usages of this ViewDefinition that are ViewUsages.
    /// <see href="http://open-services.net/ns/sysmlv2#viewDefinition_View"></see></summary>
    let viewDefinition_View = _prefix "viewDefinition_View"
    /// <summary>
    /// The Expressions related to this ViewDefinition by ElementFilterMemberships, which specify conditions on Elements to be rendered in a view.
    /// <see href="http://open-services.net/ns/sysmlv2#viewDefinition_ViewCondition"></see></summary>
    let viewDefinition_ViewCondition = _prefix "viewDefinition_ViewCondition"
    /// <summary>
    /// The RenderingUsage to be used to render views defined by this ViewDefinition, which is the referencedRendering of the ViewRenderingMembership of the ViewDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#viewDefinition_ViewRendering"></see></summary>
    let viewDefinition_ViewRendering = _prefix "viewDefinition_ViewRendering"

    /// <summary>
    /// The owned RenderingUsage that is either itself the referencedRendering or subsets the referencedRendering.
    /// <see href="http://open-services.net/ns/sysmlv2#viewRenderingMembership_OwnedRendering"></see></summary>
    let viewRenderingMembership_OwnedRendering =
        _prefix "viewRenderingMembership_OwnedRendering"

    /// <summary>
    ///  The RenderingUsage that is referenced through this ViewRenderingMembership. It is the referencedFeature of the ownedReferenceSubsetting for the ownedRendering, if there is one, and, otherwise, the ownedRendering itself.
    /// <see href="http://open-services.net/ns/sysmlv2#viewRenderingMembership_ReferencedRendering"></see></summary>
    let viewRenderingMembership_ReferencedRendering =
        _prefix "viewRenderingMembership_ReferencedRendering"

    /// <summary>
    /// The Elements that are exposed by this ViewUsage, which are those memberElements of the imported Memberships from all the Expose Relationships that meet all the owned and inherited viewConditions.
    /// <see href="http://open-services.net/ns/sysmlv2#viewUsage_ExposedElement"></see></summary>
    let viewUsage_ExposedElement = _prefix "viewUsage_ExposedElement"
    /// <summary>
    /// The nestedRequirements of this ViewUsage that are ViewpointUsages for (additional) viewpoints satisfied by the ViewUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#viewUsage_SatisfiedViewpoint"></see></summary>
    let viewUsage_SatisfiedViewpoint = _prefix "viewUsage_SatisfiedViewpoint"
    /// <summary>
    /// The Expressions related to this ViewUsage by ElementFilterMemberships, which specify conditions on Elements to be rendered in a view.
    /// <see href="http://open-services.net/ns/sysmlv2#viewUsage_ViewCondition"></see></summary>
    let viewUsage_ViewCondition = _prefix "viewUsage_ViewCondition"
    /// <summary>
    /// The ViewDefinition that is the definition of this ViewUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#viewUsage_ViewDefinition"></see></summary>
    let viewUsage_ViewDefinition = _prefix "viewUsage_ViewDefinition"
    /// <summary>
    /// The RenderingUsage to be used to render views defined by this ViewUsage, which is the referencedRendering of the ViewRenderingMembership of the ViewUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#viewUsage_ViewRendering"></see></summary>
    let viewUsage_ViewRendering = _prefix "viewUsage_ViewRendering"

    /// <summary>
    /// The PartUsages that identify the stakeholders with concerns framed by this ViewpointDefinition, which are the owned and inherited stakeholderParameters of the framedConcerns of this ViewpointDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#viewpointDefinition_ViewpointStakeholder"></see></summary>
    let viewpointDefinition_ViewpointStakeholder =
        _prefix "viewpointDefinition_ViewpointStakeholder"

    /// <summary>
    /// The ViewpointDefinition that is the definition of this ViewpointUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#viewpointUsage_ViewpointDefinition"></see></summary>
    let viewpointUsage_ViewpointDefinition =
        _prefix "viewpointUsage_ViewpointDefinition"

    /// <summary>
    /// The PartUsages that identify the stakeholders with concerns framed by this ViewpointUsage, which are the owned and inherited stakeholderParameters of the framedConcerns of this ViewpointUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#viewpointUsage_ViewpointStakeholder"></see></summary>
    let viewpointUsage_ViewpointStakeholder =
        _prefix "viewpointUsage_ViewpointStakeholder"

    /// <summary>
    /// Indicates a Membership is not visible outside its owning Namespace.
    /// <see href="http://open-services.net/ns/sysmlv2#visibilityKind_Private"></see></summary>
    let visibilityKind_Private = _prefix "visibilityKind_Private"
    /// <summary>
    /// An intermediate level of visibility between public and private. By default, it is equivalent to private for the purposes of normal access to and import of Elements from a Namespace. However, other Relationships may be specified to include Memberships with protected visibility in the list of memberships for a Namespace (e.g., Specialization).
    /// <see href="http://open-services.net/ns/sysmlv2#visibilityKind_Protected"></see></summary>
    let visibilityKind_Protected = _prefix "visibilityKind_Protected"
    /// <summary>
    /// Indicates that a Membership is publicly visible outside its owning Namespace.
    /// <see href="http://open-services.net/ns/sysmlv2#visibilityKind_Public"></see></summary>
    let visibilityKind_Public = _prefix "visibilityKind_Public"

    /// <summary>
    /// The Expression whose result, if false, determines that the bodyAction should continue to be performed. It is the (optional) third owned parameter of the WhileLoopActionUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#whileLoopActionUsage_UntilArgument"></see></summary>
    let whileLoopActionUsage_UntilArgument =
        _prefix "whileLoopActionUsage_UntilArgument"

    /// <summary>
    /// The Expression whose result, if true, determines that the bodyAction should continue to be performed. It is the first owned parameter of the WhileLoopActionUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#whileLoopActionUsage_WhileArgument"></see></summary>
    let whileLoopActionUsage_WhileArgument =
        _prefix "whileLoopActionUsage_WhileArgument"
