namespace http.open_services.net.ns.sysmlv2.hash

open DoxAletheia.Rdf_Vocabulary

module sysml =
    let _namespace_name = "http://open-services.net/ns/sysmlv2#"

    /// <summary>
    /// An AcceptActionUsage is an ActionUsage that specifies the acceptance of an incomingTransfer from the Occurrence given by the result of its receiverArgument Expression. (If no receiverArgument is provided, the default is the this context of the AcceptActionUsage.) The payload of the accepted Transfer is output on its payloadParameter. Which Transfers may be accepted is determined by conformance to the typing and (potentially) binding of the payloadParameter.
    /// <see href="http://open-services.net/ns/sysmlv2#AcceptActionUsage"></see></summary>
    let AcceptActionUsage =
        Namespaced_IRI.parse _namespace_name "AcceptActionUsage" |> NamespacedName

    /// <summary>
    /// An ActionUsage is a Usage that is also a Step, and, so, is typed by a Behavior. Nominally, if the type is an ActionDefinition, an ActionUsage is a Usage of that ActionDefinition within a system. However, other kinds of kernel Behaviors are also allowed, to permit use of Behaviors from the Kernel Model Libraries.
    /// <see href="http://open-services.net/ns/sysmlv2#ActionUsage"></see></summary>
    let ActionUsage =
        Namespaced_IRI.parse _namespace_name "ActionUsage" |> NamespacedName

    /// <summary>
    /// An ActionDefinition is a Definition that is also a Behavior that defines an Action performed by a system or part of a system.
    /// <see href="http://open-services.net/ns/sysmlv2#ActionDefinition"></see></summary>
    let ActionDefinition =
        Namespaced_IRI.parse _namespace_name "ActionDefinition" |> NamespacedName

    /// <summary>
    /// A Behavior coordinates occurrences of other Behaviors, as well as changes in objects. Behaviors can be decomposed into Steps and be characterized by parameters.
    /// <see href="http://open-services.net/ns/sysmlv2#Behavior"></see></summary>
    let Behavior = Namespaced_IRI.parse _namespace_name "Behavior" |> NamespacedName

    /// <summary>
    /// An OccurrenceDefinition is a Definition of a Class of individuals that have an independent life over time and potentially an extent over space. This includes both structural things and behaviors that act on such structures.
    /// <see href="http://open-services.net/ns/sysmlv2#OccurrenceDefinition"></see></summary>
    let OccurrenceDefinition =
        Namespaced_IRI.parse _namespace_name "OccurrenceDefinition" |> NamespacedName

    /// <summary>
    /// An OccurrenceUsage is a Usage whose types are all Classes. Nominally, if a type is an OccurrenceDefinition, an OccurrenceUsage is a Usage of that OccurrenceDefinition within a system. However, other types of Kernel Classes are also allowed, to permit use of Classes from the Kernel Model Libraries.
    /// <see href="http://open-services.net/ns/sysmlv2#OccurrenceUsage"></see></summary>
    let OccurrenceUsage =
        Namespaced_IRI.parse _namespace_name "OccurrenceUsage" |> NamespacedName

    /// <summary>
    /// A Step is a Feature that is typed by one or more Behaviors. Steps may be used by one Behavior to coordinate the performance of other Behaviors, supporting a steady refinement of behavioral descriptions. Steps can be ordered in time and can be connected using ItemFlows to specify things flowing between their parameters.
    /// <see href="http://open-services.net/ns/sysmlv2#Step"></see></summary>
    let Step = Namespaced_IRI.parse _namespace_name "Step" |> NamespacedName

    /// <summary>
    /// An ActorMembership is a ParameterMembership that identifies a PartUsage as an actor parameter, which specifies a role played by an external entity in interaction with the owningType of the ActorMembership.
    /// <see href="http://open-services.net/ns/sysmlv2#ActorMembership"></see></summary>
    let ActorMembership =
        Namespaced_IRI.parse _namespace_name "ActorMembership" |> NamespacedName

    /// <summary>
    /// A ParameterMembership is a FeatureMembership that identifies its memberFeature as a parameter, which is always owned, and must have a direction. A ParameterMembership must be owned by a Behavior or a Step.
    /// <see href="http://open-services.net/ns/sysmlv2#ParameterMembership"></see></summary>
    let ParameterMembership =
        Namespaced_IRI.parse _namespace_name "ParameterMembership" |> NamespacedName

    /// <summary>
    /// An AllocationDefinition is a ConnectionDefinition that specifies that some or all of the responsibility to realize the intent of the source is allocated to the target instances. Such allocations define mappings across the various structures and hierarchies of a system model, perhaps as a precursor to more rigorous specifications and implementations. An AllocationDefinition can itself be refined using nested allocations that give a finer-grained decomposition of the containing allocation mapping.
    /// <see href="http://open-services.net/ns/sysmlv2#AllocationDefinition"></see></summary>
    let AllocationDefinition =
        Namespaced_IRI.parse _namespace_name "AllocationDefinition" |> NamespacedName

    /// <summary>
    /// A ConnectionDefinition is a PartDefinition that is also an AssociationStructure. The end Features of a ConnectionDefinition must be Usages.
    /// <see href="http://open-services.net/ns/sysmlv2#ConnectionDefinition"></see></summary>
    let ConnectionDefinition =
        Namespaced_IRI.parse _namespace_name "ConnectionDefinition" |> NamespacedName

    /// <summary>
    /// An AllocationUsage is a usage of an AllocationDefinition asserting the allocation of the source feature to the target feature.
    /// <see href="http://open-services.net/ns/sysmlv2#AllocationUsage"></see></summary>
    let AllocationUsage =
        Namespaced_IRI.parse _namespace_name "AllocationUsage" |> NamespacedName

    /// <summary>
    /// A ConnectionUsage is a ConnectorAsUsage that is also a PartUsage. Nominally, if its type is a ConnectionDefinition, then a ConnectionUsage is a Usage of that ConnectionDefinition, representing a connection between parts of a system. However, other kinds of kernel AssociationStructures are also allowed, to permit use of AssociationStructures from the Kernel Model Libraries.
    /// <see href="http://open-services.net/ns/sysmlv2#ConnectionUsage"></see></summary>
    let ConnectionUsage =
        Namespaced_IRI.parse _namespace_name "ConnectionUsage" |> NamespacedName

    /// <summary>
    /// An AnalysisCaseDefinition is a CaseDefinition for the case of carrying out an analysis.
    /// <see href="http://open-services.net/ns/sysmlv2#AnalysisCaseDefinition"></see></summary>
    let AnalysisCaseDefinition =
        Namespaced_IRI.parse _namespace_name "AnalysisCaseDefinition" |> NamespacedName

    /// <summary>
    /// A CaseDefinition is a CalculationDefinition for a process, often involving collecting evidence or data, relative to a subject, possibly involving the collaboration of one or more other actors, producing a result that meets an objective.
    /// <see href="http://open-services.net/ns/sysmlv2#CaseDefinition"></see></summary>
    let CaseDefinition =
        Namespaced_IRI.parse _namespace_name "CaseDefinition" |> NamespacedName

    /// <summary>
    /// An AnalysisCaseUsage is a Usage of an AnalysisCaseDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#AnalysisCaseUsage"></see></summary>
    let AnalysisCaseUsage =
        Namespaced_IRI.parse _namespace_name "AnalysisCaseUsage" |> NamespacedName

    /// <summary>
    /// A CaseUsage is a Usage of a CaseDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#CaseUsage"></see></summary>
    let CaseUsage = Namespaced_IRI.parse _namespace_name "CaseUsage" |> NamespacedName

    /// <summary>
    /// An AnnotatingElement is an Element that provides additional description of or metadata on some other Element. An AnnotatingElement is either attached to its annotatedElements by Annotation Relationships, or it implicitly annotates its owningNamespace.
    /// <see href="http://open-services.net/ns/sysmlv2#AnnotatingElement"></see></summary>
    let AnnotatingElement =
        Namespaced_IRI.parse _namespace_name "AnnotatingElement" |> NamespacedName

    /// <summary>
    /// An Element is a constituent of a model that is uniquely identified relative to all other Elements. It can have Relationships with other Elements. Some of these Relationships might imply ownership of other Elements, which means that if an Element is deleted from a model, then so are all the Elements that it owns.
    /// <see href="http://open-services.net/ns/sysmlv2#Element"></see></summary>
    let Element = Namespaced_IRI.parse _namespace_name "Element" |> NamespacedName
    /// <summary>
    /// An Annotation is a Relationship between an AnnotatingElement and the Element that is annotated by that AnnotatingElement.
    /// <see href="http://open-services.net/ns/sysmlv2#Annotation"></see></summary>
    let Annotation = Namespaced_IRI.parse _namespace_name "Annotation" |> NamespacedName

    /// <summary>
    /// A Relationship is an Element that relates other Element. Some of its relatedElements may be owned, in which case those ownedRelatedElements will be deleted from a model if their owningRelationship is. A Relationship may also be owned by another Element, in which case the ownedRelatedElements of the Relationship are also considered to be transitively owned by the owningRelatedElement of the Relationship.
    /// <see href="http://open-services.net/ns/sysmlv2#Relationship"></see></summary>
    let Relationship =
        Namespaced_IRI.parse _namespace_name "Relationship" |> NamespacedName

    /// <summary>
    /// An AssertConstraintUsage is a ConstraintUsage that is also an Invariant and, so, is asserted to be true (by default). Unless it is the AssertConstraintUsage itself, the asserted ConstraintUsage is related to the AssertConstraintUsage by a ReferenceSubsetting Relationship.
    /// <see href="http://open-services.net/ns/sysmlv2#AssertConstraintUsage"></see></summary>
    let AssertConstraintUsage =
        Namespaced_IRI.parse _namespace_name "AssertConstraintUsage" |> NamespacedName

    /// <summary>
    /// A ConstraintUsage is an OccurrenceUsage that is also a BooleanExpression, and, so, is typed by a Predicate. Nominally, if the type is a ConstraintDefinition, a ConstraintUsage is a Usage of that ConstraintDefinition. However, other kinds of kernel Predicates are also allowed, to permit use of Predicates from the Kernel Model Libraries.
    /// <see href="http://open-services.net/ns/sysmlv2#ConstraintUsage"></see></summary>
    let ConstraintUsage =
        Namespaced_IRI.parse _namespace_name "ConstraintUsage" |> NamespacedName

    /// <summary>
    /// An Invariant is a BooleanExpression that is asserted to have a specific Boolean result value. If isNegated = false, then the result is asserted to be true. If isNegated = true, then the result is asserted to be false.
    /// <see href="http://open-services.net/ns/sysmlv2#Invariant"></see></summary>
    let Invariant = Namespaced_IRI.parse _namespace_name "Invariant" |> NamespacedName

    /// <summary>
    /// An AssignmentActionUsage is an ActionUsage that is defined, directly or indirectly, by the ActionDefinition AssignmentAction from the Systems Model Library. It specifies that the value of the referent Feature, relative to the target given by the result of the targetArgument Expression, should be set to the result of the valueExpression.
    /// <see href="http://open-services.net/ns/sysmlv2#AssignmentActionUsage"></see></summary>
    let AssignmentActionUsage =
        Namespaced_IRI.parse _namespace_name "AssignmentActionUsage" |> NamespacedName

    /// <summary>
    /// An Association is a Relationship and a Classifier to enable classification of links between things (in the universe). The co-domains (types) of the associationEnd Features are the relatedTypes, as co-domain and participants (linked things) of an Association identify each other.
    /// <see href="http://open-services.net/ns/sysmlv2#Association"></see></summary>
    let Association =
        Namespaced_IRI.parse _namespace_name "Association" |> NamespacedName

    /// <summary>
    /// A Classifier is a Type that classifies:.
    /// <see href="http://open-services.net/ns/sysmlv2#Classifier"></see></summary>
    let Classifier = Namespaced_IRI.parse _namespace_name "Classifier" |> NamespacedName

    /// <summary>
    /// An AssociationStructure is an Association that is also a Structure, classifying link objects that are both links and objects. As objects, link objects can be created and destroyed, and their non-end Features can change over time. However, the values of the end Features of a link object are fixed and cannot change over its lifetime.
    /// <see href="http://open-services.net/ns/sysmlv2#AssociationStructure"></see></summary>
    let AssociationStructure =
        Namespaced_IRI.parse _namespace_name "AssociationStructure" |> NamespacedName

    /// <summary>
    /// A Structure is a Class of objects in the modeled universe that are primarily structural in nature. While such an object is not itself behavioral, it may be involved in and acted on by Behaviors, and it may be the performer of some of them.
    /// <see href="http://open-services.net/ns/sysmlv2#Structure"></see></summary>
    let Structure = Namespaced_IRI.parse _namespace_name "Structure" |> NamespacedName

    /// <summary>
    /// An AttributeDefinition is a Definition and a DataType of information about a quality or characteristic of a system or part of a system that has no independent identity other than its value. All features of an AttributeDefinition must be referential (non-composite).
    /// <see href="http://open-services.net/ns/sysmlv2#AttributeDefinition"></see></summary>
    let AttributeDefinition =
        Namespaced_IRI.parse _namespace_name "AttributeDefinition" |> NamespacedName

    /// <summary>
    /// A DataType is a Classifier of things (in the universe) that can only be distinguished by how they are related to other things (via Features). This means multiple things classified by the same DataType.
    /// <see href="http://open-services.net/ns/sysmlv2#DataType"></see></summary>
    let DataType = Namespaced_IRI.parse _namespace_name "DataType" |> NamespacedName
    /// <summary>
    /// A Definition is a Classifier of Usages. The actual kinds of Definition that may appear in a model are given by the subclasses of Definition (possibly as extended with user-defined SemanticMetadata).
    /// <see href="http://open-services.net/ns/sysmlv2#Definition"></see></summary>
    let Definition = Namespaced_IRI.parse _namespace_name "Definition" |> NamespacedName

    /// <summary>
    /// An AttributeUsage is a Usage whose type is a DataType. Nominally, if the type is an AttributeDefinition, an AttributeUsage is a usage of a AttributeDefinition to represent the value of some system quality or characteristic. However, other kinds of kernel DataTypes are also allowed, to permit use of DataTypes from the Kernel Model Libraries. An AttributeUsage itself as well as all its nested features must be referential (non-composite).
    /// <see href="http://open-services.net/ns/sysmlv2#AttributeUsage"></see></summary>
    let AttributeUsage =
        Namespaced_IRI.parse _namespace_name "AttributeUsage" |> NamespacedName

    /// <summary>
    /// A Usage is a usage of a Definition. A Usage may only be an ownedFeature of a Definition or another Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#Usage"></see></summary>
    let Usage = Namespaced_IRI.parse _namespace_name "Usage" |> NamespacedName
    /// <summary>
    /// A Class is a Classifier of things (in the universe) that can be distinguished without regard to how they are related to other things (via Features). This means multiple things classified by the same Class can be distinguished, even when they are related other things in exactly the same way.
    /// <see href="http://open-services.net/ns/sysmlv2#Class"></see></summary>
    let Class = Namespaced_IRI.parse _namespace_name "Class" |> NamespacedName

    /// <summary>
    /// A BindingConnector is a binary Connector that requires its relatedFeatures to identify the same things (have the same values).
    /// <see href="http://open-services.net/ns/sysmlv2#BindingConnector"></see></summary>
    let BindingConnector =
        Namespaced_IRI.parse _namespace_name "BindingConnector" |> NamespacedName

    /// <summary>
    /// A Connector is a usage of Associations, with links restricted according to instances of the Type in which they are used (domain of the Connector). The associations of the Connector restrict what kinds of things might be linked. The Connector further restricts these links to be between values of Features on instances of its domain.
    /// <see href="http://open-services.net/ns/sysmlv2#Connector"></see></summary>
    let Connector = Namespaced_IRI.parse _namespace_name "Connector" |> NamespacedName

    /// <summary>
    /// A BindingConnectorAsUsage is both a BindingConnector and a ConnectorAsUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#BindingConnectorAsUsage"></see></summary>
    let BindingConnectorAsUsage =
        Namespaced_IRI.parse _namespace_name "BindingConnectorAsUsage" |> NamespacedName

    /// <summary>
    /// A ConnectorAsUsage is both a Connector and a Usage. ConnectorAsUsage cannot itself be instantiated in a SysML model, but it is the base class for the concrete classes BindingConnectorAsUsage, SuccessionAsUsage and ConnectionUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#ConnectorAsUsage"></see></summary>
    let ConnectorAsUsage =
        Namespaced_IRI.parse _namespace_name "ConnectorAsUsage" |> NamespacedName

    /// <summary>
    /// A BooleanExpression is a Boolean-valued Expression whose type is a Predicate. It represents a logical condition resulting from the evaluation of the Predicate.
    /// <see href="http://open-services.net/ns/sysmlv2#BooleanExpression"></see></summary>
    let BooleanExpression =
        Namespaced_IRI.parse _namespace_name "BooleanExpression" |> NamespacedName

    /// <summary>
    /// An Expression is a Step that is typed by a Function. An Expression that also has a Function as its featuringType is a computational step within that Function. An Expression always has a single result parameter, which redefines the result parameter of its defining function. This allows Expressions to be interconnected in tree structures, in which inputs to each Expression in the tree are determined as the results of other Expression in the tree.
    /// <see href="http://open-services.net/ns/sysmlv2#Expression"></see></summary>
    let Expression = Namespaced_IRI.parse _namespace_name "Expression" |> NamespacedName

    /// <summary>
    /// A CalculationDefinition is an ActionDefinition that also defines a Function producing a result.
    /// <see href="http://open-services.net/ns/sysmlv2#CalculationDefinition"></see></summary>
    let CalculationDefinition =
        Namespaced_IRI.parse _namespace_name "CalculationDefinition" |> NamespacedName

    /// <summary>
    /// A Function is a Behavior that has an out parameter that is identified as its result. A Function represents the performance of a calculation that produces the values of its result parameter. This calculation may be decomposed into Expressions that are steps of the Function.
    /// <see href="http://open-services.net/ns/sysmlv2#Function"></see></summary>
    let Function = Namespaced_IRI.parse _namespace_name "Function" |> NamespacedName

    /// <summary>
    /// A CalculationUsage is an ActionUsage that is also an Expression, and, so, is typed by a Function. Nominally, if the type is a CalculationDefinition, a CalculationUsage is a Usage of that CalculationDefinition within a system. However, other kinds of kernel Functions are also allowed, to permit use of Functions from the Kernel Model Libraries.
    /// <see href="http://open-services.net/ns/sysmlv2#CalculationUsage"></see></summary>
    let CalculationUsage =
        Namespaced_IRI.parse _namespace_name "CalculationUsage" |> NamespacedName

    /// <summary>
    /// A Type is a Namespace that is the most general kind of Element supporting the semantics of classification. A Type may be a Classifier or a Feature, defining conditions on what is classified by the Type (see also the description of isSufficient).
    /// <see href="http://open-services.net/ns/sysmlv2#Type"></see></summary>
    let Type = Namespaced_IRI.parse _namespace_name "Type" |> NamespacedName

    /// <summary>
    /// A CollectExpression is an OperatorExpression whose operator is "collect", which resolves to the Function ControlFunctions::collect from the Kernel Functions Library.
    /// <see href="http://open-services.net/ns/sysmlv2#CollectExpression"></see></summary>
    let CollectExpression =
        Namespaced_IRI.parse _namespace_name "CollectExpression" |> NamespacedName

    /// <summary>
    /// An OperatorExpression is an InvocationExpression whose function is determined by resolving its operator in the context of one of the standard packages from the Kernel Function Library.
    /// <see href="http://open-services.net/ns/sysmlv2#OperatorExpression"></see></summary>
    let OperatorExpression =
        Namespaced_IRI.parse _namespace_name "OperatorExpression" |> NamespacedName

    /// <summary>
    /// A Comment is an AnnotatingElement whose body in some way describes its annotatedElements.
    /// <see href="http://open-services.net/ns/sysmlv2#Comment"></see></summary>
    let Comment = Namespaced_IRI.parse _namespace_name "Comment" |> NamespacedName

    /// <summary>
    /// A ConcernDefinition is a RequirementDefinition that one or more stakeholders may be interested in having addressed. These stakeholders are identified by the ownedStakeholdersof the ConcernDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#ConcernDefinition"></see></summary>
    let ConcernDefinition =
        Namespaced_IRI.parse _namespace_name "ConcernDefinition" |> NamespacedName

    /// <summary>
    /// A RequirementDefinition is a ConstraintDefinition that defines a requirement used in the context of a specification as a constraint that a valid solution must satisfy. The specification is relative to a specified subject, possibly in collaboration with one or more external actors.
    /// <see href="http://open-services.net/ns/sysmlv2#RequirementDefinition"></see></summary>
    let RequirementDefinition =
        Namespaced_IRI.parse _namespace_name "RequirementDefinition" |> NamespacedName

    /// <summary>
    /// A ConcernUsage is a Usage of a ConcernDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#ConcernUsage"></see></summary>
    let ConcernUsage =
        Namespaced_IRI.parse _namespace_name "ConcernUsage" |> NamespacedName

    /// <summary>
    /// A RequirementUsage is a Usage of a RequirementDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#RequirementUsage"></see></summary>
    let RequirementUsage =
        Namespaced_IRI.parse _namespace_name "RequirementUsage" |> NamespacedName

    /// <summary>
    /// A ConjugatedPortDefinition is a PortDefinition that is a PortDefinition of its original PortDefinition. That is, a ConjugatedPortDefinition inherits all the features of the original PortDefinition, but input flows of the original PortDefinition become outputs on the ConjugatedPortDefinition and output flows of the original PortDefinition become inputs on the ConjugatedPortDefinition. Every PortDefinition (that is not itself a ConjugatedPortDefinition) has exactly one corresponding ConjugatedPortDefinition, whose effective name is the name of the originalPortDefinition, with the character ~ prepended.
    /// <see href="http://open-services.net/ns/sysmlv2#ConjugatedPortDefinition"></see></summary>
    let ConjugatedPortDefinition =
        Namespaced_IRI.parse _namespace_name "ConjugatedPortDefinition" |> NamespacedName

    /// <summary>
    /// A PortDefinition defines a point at which external entities can connect to and interact with a system or part of a system. Any ownedUsages of a PortDefinition, other than PortUsages, must not be composite.
    /// <see href="http://open-services.net/ns/sysmlv2#PortDefinition"></see></summary>
    let PortDefinition =
        Namespaced_IRI.parse _namespace_name "PortDefinition" |> NamespacedName

    /// <summary>
    /// A ConjugatedPortTyping is a FeatureTyping whose type is a ConjugatedPortDefinition. (This relationship is intended to be an abstract-syntax marker for a special surface notation for conjugated typing of ports.).
    /// <see href="http://open-services.net/ns/sysmlv2#ConjugatedPortTyping"></see></summary>
    let ConjugatedPortTyping =
        Namespaced_IRI.parse _namespace_name "ConjugatedPortTyping" |> NamespacedName

    /// <summary>
    /// FeatureTyping is Specialization in which the specific Type is a Feature. This means the set of instances of the (specific) typedFeature is a subset of the set of instances of the (general) type. In the simplest case, the type is a Classifier, whereupon the typedFeature has values that are instances of the Classifier.
    /// <see href="http://open-services.net/ns/sysmlv2#FeatureTyping"></see></summary>
    let FeatureTyping =
        Namespaced_IRI.parse _namespace_name "FeatureTyping" |> NamespacedName

    /// <summary>
    /// Conjugation is a Relationship between two types in which the conjugatedType inherits all the Features of the originalType, but with all input and output Features reversed. That is, any Features with a direction in relative to the originalType are considered to have an effective direction of out relative to the conjugatedType and, similarly, Features with direction out in the originalType are considered to have an effective direction of in in the conjugatedType. Features with direction inout, or with no direction, in the originalType, are inherited without change.
    /// <see href="http://open-services.net/ns/sysmlv2#Conjugation"></see></summary>
    let Conjugation =
        Namespaced_IRI.parse _namespace_name "Conjugation" |> NamespacedName

    /// <summary>
    /// A PartDefinition is an ItemDefinition of a Class of systems or parts of systems. Note that all parts may be considered items for certain purposes, but not all items are parts that can perform actions within a system.
    /// <see href="http://open-services.net/ns/sysmlv2#PartDefinition"></see></summary>
    let PartDefinition =
        Namespaced_IRI.parse _namespace_name "PartDefinition" |> NamespacedName

    /// <summary>
    /// A PartUsage is a usage of a PartDefinition to represent a system or a part of a system. At least one of the itemDefinitions of the PartUsage must be a PartDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#PartUsage"></see></summary>
    let PartUsage = Namespaced_IRI.parse _namespace_name "PartUsage" |> NamespacedName
    /// <summary>
    /// A Feature is a Type that classifies relations between multiple things (in the universe). The domain of the relation is the intersection of the featuringTypes of the Feature. (The domain of a Feature with no featuringTyps is implicitly the most general Type Base::Anything from the Kernel Semantic Library.) The co-domain of the relation is the intersection of the types of the Feature.
    ///
    /// .
    /// <see href="http://open-services.net/ns/sysmlv2#Feature"></see></summary>
    let Feature = Namespaced_IRI.parse _namespace_name "Feature" |> NamespacedName

    /// <summary>
    /// A ConstraintDefinition is an OccurrenceDefinition that is also a Predicate that defines a constraint that may be asserted to hold on a system or part of a system.
    /// <see href="http://open-services.net/ns/sysmlv2#ConstraintDefinition"></see></summary>
    let ConstraintDefinition =
        Namespaced_IRI.parse _namespace_name "ConstraintDefinition" |> NamespacedName

    /// <summary>
    /// A Predicate is a Function whose result parameter has type Boolean and multiplicity 1..1.
    /// <see href="http://open-services.net/ns/sysmlv2#Predicate"></see></summary>
    let Predicate = Namespaced_IRI.parse _namespace_name "Predicate" |> NamespacedName

    /// <summary>
    /// A ControlNode is an ActionUsage that does not have any inherent behavior but provides constraints on incoming and outgoing Successions that are used to control other Actions. A ControlNode must be a composite owned usage of an ActionDefinition or ActionUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#ControlNode"></see></summary>
    let ControlNode =
        Namespaced_IRI.parse _namespace_name "ControlNode" |> NamespacedName

    /// <summary>
    /// A DecisionNode is a ControlNode that makes a selection from its outgoing Successions.
    /// <see href="http://open-services.net/ns/sysmlv2#DecisionNode"></see></summary>
    let DecisionNode =
        Namespaced_IRI.parse _namespace_name "DecisionNode" |> NamespacedName

    /// <summary>
    /// A Dependency is a Relationship that indicates that one or more client Elements require one more supplier Elements for their complete specification. In general, this means that a change to one of the supplier Elements may necessitate a change to, or re-specification of, the client Elements.
    /// <see href="http://open-services.net/ns/sysmlv2#Dependency"></see></summary>
    let Dependency = Namespaced_IRI.parse _namespace_name "Dependency" |> NamespacedName

    /// <summary>
    /// Differencing is a Relationship that makes its differencingType one of the differencingTypes of its typeDifferenced.
    /// <see href="http://open-services.net/ns/sysmlv2#Differencing"></see></summary>
    let Differencing =
        Namespaced_IRI.parse _namespace_name "Differencing" |> NamespacedName

    /// <summary>
    /// A Disjoining is a Relationship between Types asserted to have interpretations that are not shared (disjoint) between them, identified as typeDisjoined and disjoiningType. For example, a Classifier for mammals is disjoint from a Classifier for minerals, and a Feature for people's parents is disjoint from a Feature for their children.
    /// <see href="http://open-services.net/ns/sysmlv2#Disjoining"></see></summary>
    let Disjoining = Namespaced_IRI.parse _namespace_name "Disjoining" |> NamespacedName

    /// <summary>
    /// Documentation is a Comment that specifically documents a documentedElement, which must be its owner.
    /// <see href="http://open-services.net/ns/sysmlv2#Documentation"></see></summary>
    let Documentation =
        Namespaced_IRI.parse _namespace_name "Documentation" |> NamespacedName

    /// <summary>
    /// ElementFilterMembership is a Membership between a Namespace and a model-level evaluable Boolean-valued Expression, asserting that imported members of the Namespace should be filtered using the condition Expression. A general Namespace does not define any specific filtering behavior, but such behavior may be defined for various specialized kinds of Namespaces.
    /// <see href="http://open-services.net/ns/sysmlv2#ElementFilterMembership"></see></summary>
    let ElementFilterMembership =
        Namespaced_IRI.parse _namespace_name "ElementFilterMembership" |> NamespacedName

    /// <summary>
    /// An OwningMembership is a Membership that owns its memberElement as a ownedRelatedElement. The ownedMemberElement becomes an ownedMember of the membershipOwningNamespace.
    /// <see href="http://open-services.net/ns/sysmlv2#OwningMembership"></see></summary>
    let OwningMembership =
        Namespaced_IRI.parse _namespace_name "OwningMembership" |> NamespacedName

    /// <summary>
    /// EndFeatureMembership is a FeatureMembership that requires its memberFeature be owned and have isEnd = true.
    /// <see href="http://open-services.net/ns/sysmlv2#EndFeatureMembership"></see></summary>
    let EndFeatureMembership =
        Namespaced_IRI.parse _namespace_name "EndFeatureMembership" |> NamespacedName

    /// <summary>
    /// A FeatureMembership is an OwningMembership between a Feature in an owningType that is also a Featuring Relationship between the Feature and the Type, in which the featuringType is the source and the featureOfType is the target. A FeatureMembership is always owned by its owningType, which is the featuringType for the FeatureMembership considered as a Featuring.
    /// <see href="http://open-services.net/ns/sysmlv2#FeatureMembership"></see></summary>
    let FeatureMembership =
        Namespaced_IRI.parse _namespace_name "FeatureMembership" |> NamespacedName

    /// <summary>
    /// An EnumerationDefinition is an AttributeDefinition all of whose instances are given by an explicit list of enumeratedValues. This is realized by requiring that the EnumerationDefinition have isVariation = true, with the enumeratedValues being its variants.
    /// <see href="http://open-services.net/ns/sysmlv2#EnumerationDefinition"></see></summary>
    let EnumerationDefinition =
        Namespaced_IRI.parse _namespace_name "EnumerationDefinition" |> NamespacedName

    /// <summary>
    /// An EnumerationUsage is an AttributeUsage whose attributeDefinition is an EnumerationDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#EnumerationUsage"></see></summary>
    let EnumerationUsage =
        Namespaced_IRI.parse _namespace_name "EnumerationUsage" |> NamespacedName

    /// <summary>
    /// An EventOccurrenceUsage is an OccurrenceUsage that represents another OccurrenceUsage occurring as a suboccurrence of the containing occurrence of the EventOccurrenceUsage. Unless it is the EventOccurrenceUsage itself, the referenced OccurrenceUsage is related to the EventOccurrenceUsage by a ReferenceSubsetting Relationship.
    /// <see href="http://open-services.net/ns/sysmlv2#EventOccurrenceUsage"></see></summary>
    let EventOccurrenceUsage =
        Namespaced_IRI.parse _namespace_name "EventOccurrenceUsage" |> NamespacedName

    /// <summary>
    /// An ExhibitStateUsage is a StateUsage that represents the exhibiting of a StateUsage. Unless it is the StateUsage itself, the StateUsage to be exhibited is related to the ExhibitStateUsage by a ReferenceSubsetting Relationship. An ExhibitStateUsage is also a PerformActionUsage, with its exhibitedState as the performedAction.
    /// <see href="http://open-services.net/ns/sysmlv2#ExhibitStateUsage"></see></summary>
    let ExhibitStateUsage =
        Namespaced_IRI.parse _namespace_name "ExhibitStateUsage" |> NamespacedName

    /// <summary>
    /// A PerformActionUsage is an ActionUsage that represents the performance of an ActionUsage. Unless it is the PerformActionUsage itself, the ActionUsage to be performed is related to the PerformActionUsage by a ReferenceSubsetting relationship. A PerformActionUsage is also an EventOccurrenceUsage, with its performedAction as the eventOccurrence.
    /// <see href="http://open-services.net/ns/sysmlv2#PerformActionUsage"></see></summary>
    let PerformActionUsage =
        Namespaced_IRI.parse _namespace_name "PerformActionUsage" |> NamespacedName

    /// <summary>
    /// A StateUsage is an ActionUsage that is nominally the Usage of a StateDefinition. However, other kinds of kernel Behaviors are also allowed as types, to permit use of Behaviors
    /// .
    /// <see href="http://open-services.net/ns/sysmlv2#StateUsage"></see></summary>
    let StateUsage = Namespaced_IRI.parse _namespace_name "StateUsage" |> NamespacedName
    /// <summary>
    /// An Expose is an Import of Memberships into a ViewUsage that provide the Elements to be included in a view. Visibility is always ignored for an Expose (i.e., isImportAll = true).
    /// <see href="http://open-services.net/ns/sysmlv2#Expose"></see></summary>
    let Expose = Namespaced_IRI.parse _namespace_name "Expose" |> NamespacedName
    /// <summary>
    /// An Import is an Relationship between its importOwningNamespace and either a Membership (for a MembershipImport) or another Namespace (for a NamespaceImport), which determines a set of Memberships that become importedMemberships of the importOwningNamespace. If isImportAll = false (the default), then only public Memberships are considered "visible". If isImportAll = true, then all Memberships are considered "visible", regardless of their declared visibility. If isRecursive = true, then visible Memberships are also recursively imported from owned sub-Namespaces.
    /// <see href="http://open-services.net/ns/sysmlv2#Import"></see></summary>
    let Import = Namespaced_IRI.parse _namespace_name "Import" |> NamespacedName

    /// <summary>
    /// A FeatureChainExpression is an OperatorExpression whose operator is ".", which resolves to the Function ControlFunctions::'.' from the Kernel Functions Library. It evaluates to the result of chaining the result Feature of its single argument Expression with its targetFeature.
    /// <see href="http://open-services.net/ns/sysmlv2#FeatureChainExpression"></see></summary>
    let FeatureChainExpression =
        Namespaced_IRI.parse _namespace_name "FeatureChainExpression" |> NamespacedName

    /// <summary>
    /// FeatureChaining is a Relationship that makes its target Feature one of the chainingFeatures of its owning Feature.
    /// <see href="http://open-services.net/ns/sysmlv2#FeatureChaining"></see></summary>
    let FeatureChaining =
        Namespaced_IRI.parse _namespace_name "FeatureChaining" |> NamespacedName

    /// <summary>
    /// FeatureDirectionKind enumerates the possible kinds of direction that a Feature may be given as a member of a Type.
    /// <see href="http://open-services.net/ns/sysmlv2#FeatureDirectionKind"></see></summary>
    let FeatureDirectionKind =
        Namespaced_IRI.parse _namespace_name "FeatureDirectionKind" |> NamespacedName

    /// <summary>
    /// A FeatureInverting is a Relationship between Features asserting that their interpretations (sequences) are the reverse of each other, identified as featureInverted and invertingFeature. For example, a Feature identifying each person's parents is the inverse of a Feature identifying each person's children. A person identified as a parent of another will identify that other as one of their children.
    /// <see href="http://open-services.net/ns/sysmlv2#FeatureInverting"></see></summary>
    let FeatureInverting =
        Namespaced_IRI.parse _namespace_name "FeatureInverting" |> NamespacedName

    /// <summary>
    /// Featuring is a Relationship between a Type and a Feature that is featured by that Type. It asserts that every instance in the domain of the feature must be classified by the type.
    /// <see href="http://open-services.net/ns/sysmlv2#Featuring"></see></summary>
    let Featuring = Namespaced_IRI.parse _namespace_name "Featuring" |> NamespacedName

    /// <summary>
    /// A FeatureReferenceExpression is an Expression whose result is bound to a referent Feature.
    /// <see href="http://open-services.net/ns/sysmlv2#FeatureReferenceExpression"></see></summary>
    let FeatureReferenceExpression =
        Namespaced_IRI.parse _namespace_name "FeatureReferenceExpression" |> NamespacedName

    /// <summary>
    /// Specialization is a Relationship between two Types that requires all instances of the specific type to also be instances of the general Type (i.e., the set of instances of the specific Type is a subset of those of the general Type, which might be the same set).
    /// <see href="http://open-services.net/ns/sysmlv2#Specialization"></see></summary>
    let Specialization =
        Namespaced_IRI.parse _namespace_name "Specialization" |> NamespacedName

    /// <summary>
    /// A FeatureValue is a Membership that identifies a particular member Expression that provides the value of the Feature that owns the FeatureValue. The value is specified as either a bound value or an initial value, and as either a concrete or default value. A Feature can have at most one FeatureValue.
    /// <see href="http://open-services.net/ns/sysmlv2#FeatureValue"></see></summary>
    let FeatureValue =
        Namespaced_IRI.parse _namespace_name "FeatureValue" |> NamespacedName

    /// <summary>
    /// A FlowConnectionDefinition is a ConnectionDefinition and ActionDefinition that is also an Interaction representing flows between Usages.
    /// <see href="http://open-services.net/ns/sysmlv2#FlowConnectionDefinition"></see></summary>
    let FlowConnectionDefinition =
        Namespaced_IRI.parse _namespace_name "FlowConnectionDefinition" |> NamespacedName

    /// <summary>
    /// An Interaction is a Behavior that is also an Association, providing a context for multiple objects that have behaviors that impact one another.
    /// <see href="http://open-services.net/ns/sysmlv2#Interaction"></see></summary>
    let Interaction =
        Namespaced_IRI.parse _namespace_name "Interaction" |> NamespacedName

    /// <summary>
    /// A FlowConnectionUsage is a ConnectionUsage that is also an ItemFlow.
    /// <see href="http://open-services.net/ns/sysmlv2#FlowConnectionUsage"></see></summary>
    let FlowConnectionUsage =
        Namespaced_IRI.parse _namespace_name "FlowConnectionUsage" |> NamespacedName

    /// <summary>
    /// An ItemFlow is a Step that represents the transfer of objects or data values from one Feature to another. ItemFlows can take non-zero time to complete.
    /// <see href="http://open-services.net/ns/sysmlv2#ItemFlow"></see></summary>
    let ItemFlow = Namespaced_IRI.parse _namespace_name "ItemFlow" |> NamespacedName

    /// <summary>
    /// A ForLoopActionUsage is a LoopActionUsage that specifies that its bodyAction ActionUsage should be performed once for each value, in order, from the sequence of values obtained as the result of the seqArgument Expression, with the loopVariable set to the value for each iteration.
    /// <see href="http://open-services.net/ns/sysmlv2#ForLoopActionUsage"></see></summary>
    let ForLoopActionUsage =
        Namespaced_IRI.parse _namespace_name "ForLoopActionUsage" |> NamespacedName

    /// <summary>
    /// A LoopActionUsage is an ActionUsage that specifies that its bodyAction should be performed repeatedly. Its subclasses WhileLoopActionUsage and ForLoopActionUsage provide different ways to determine how many times the bodyAction should be performed.
    /// <see href="http://open-services.net/ns/sysmlv2#LoopActionUsage"></see></summary>
    let LoopActionUsage =
        Namespaced_IRI.parse _namespace_name "LoopActionUsage" |> NamespacedName

    /// <summary>
    /// A ForkNode is a ControlNode that must be followed by successor Actions as given by all its outgoing Successions.
    /// <see href="http://open-services.net/ns/sysmlv2#ForkNode"></see></summary>
    let ForkNode = Namespaced_IRI.parse _namespace_name "ForkNode" |> NamespacedName

    /// <summary>
    /// A FramedConcernMembership is a RequirementConstraintMembership for a framed ConcernUsage of a RequirementDefinition or RequirementUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#FramedConcernMembership"></see></summary>
    let FramedConcernMembership =
        Namespaced_IRI.parse _namespace_name "FramedConcernMembership" |> NamespacedName

    /// <summary>
    /// A RequirementConstraintMembership is a FeatureMembership for an assumed or required ConstraintUsage of a RequirementDefinition or RequirementUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#RequirementConstraintMembership"></see></summary>
    let RequirementConstraintMembership =
        Namespaced_IRI.parse _namespace_name "RequirementConstraintMembership" |> NamespacedName

    /// <summary>
    /// An IfActionUsage is an ActionUsage that specifies that the thenAction ActionUsage should be performed if the result of the ifArgument Expression is true. It may also optionally specify an elseAction ActionUsage that is performed if the result of the ifArgument is false.
    /// <see href="http://open-services.net/ns/sysmlv2#IfActionUsage"></see></summary>
    let IfActionUsage =
        Namespaced_IRI.parse _namespace_name "IfActionUsage" |> NamespacedName

    /// <summary>
    /// An IncludeUseCaseUsage is a UseCaseUsage that represents the inclusion of a UseCaseUsage by a UseCaseDefinition or UseCaseUsage. Unless it is the IncludeUseCaseUsage itself, the UseCaseUsage to be included is related to the includedUseCase by a ReferenceSubsetting Relationship. An IncludeUseCaseUsage is also a PerformActionUsage, with its useCaseIncluded as the performedAction.
    /// <see href="http://open-services.net/ns/sysmlv2#IncludeUseCaseUsage"></see></summary>
    let IncludeUseCaseUsage =
        Namespaced_IRI.parse _namespace_name "IncludeUseCaseUsage" |> NamespacedName

    /// <summary>
    /// A UseCaseUsage is a Usage of a UseCaseDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#UseCaseUsage"></see></summary>
    let UseCaseUsage =
        Namespaced_IRI.parse _namespace_name "UseCaseUsage" |> NamespacedName

    /// <summary>
    /// An InterfaceDefinition is a ConnectionDefinition all of whose ends are PortUsages, defining an interface between elements that interact through such ports.
    /// <see href="http://open-services.net/ns/sysmlv2#InterfaceDefinition"></see></summary>
    let InterfaceDefinition =
        Namespaced_IRI.parse _namespace_name "InterfaceDefinition" |> NamespacedName

    /// <summary>
    /// An InterfaceUsage is a Usage of an InterfaceDefinition to represent an interface connecting parts of a system through specific ports.
    /// <see href="http://open-services.net/ns/sysmlv2#InterfaceUsage"></see></summary>
    let InterfaceUsage =
        Namespaced_IRI.parse _namespace_name "InterfaceUsage" |> NamespacedName

    /// <summary>
    /// Intersecting is a Relationship that makes its intersectingType one of the intersectingTypes of its typeIntersected.
    /// <see href="http://open-services.net/ns/sysmlv2#Intersecting"></see></summary>
    let Intersecting =
        Namespaced_IRI.parse _namespace_name "Intersecting" |> NamespacedName

    /// <summary>
    /// An InvocationExpression is an Expression each of whose input parameters are bound to the result of an argument Expression.
    /// <see href="http://open-services.net/ns/sysmlv2#InvocationExpression"></see></summary>
    let InvocationExpression =
        Namespaced_IRI.parse _namespace_name "InvocationExpression" |> NamespacedName

    /// <summary>
    /// An ItemDefinition is an OccurrenceDefinition of the Structure of things that may themselves be systems or parts of systems, but may also be things that are acted on by a system or parts of a system, but which do not necessarily perform actions themselves. This includes items that can be exchanged between parts of a system, such as water or electrical signals.
    /// <see href="http://open-services.net/ns/sysmlv2#ItemDefinition"></see></summary>
    let ItemDefinition =
        Namespaced_IRI.parse _namespace_name "ItemDefinition" |> NamespacedName

    /// <summary>
    /// An ItemFeature is the ownedFeature of an ItemFlow that identifies the things carried by the kinds of transfers that are instances of the ItemFlow.
    /// <see href="http://open-services.net/ns/sysmlv2#ItemFeature"></see></summary>
    let ItemFeature =
        Namespaced_IRI.parse _namespace_name "ItemFeature" |> NamespacedName

    /// <summary>
    /// An ItemFlowEnd is a Feature that is one of the connectorEnds giving the source or target of an ItemFlow. For ItemFlows typed by FlowTransfer or its specializations, ItemFlowEnds must have exactly one ownedFeature, which redefines Transfer::source::sourceOutput or Transfer::target::targetInput and redefines the corresponding feature of the relatedElement for its end.
    /// <see href="http://open-services.net/ns/sysmlv2#ItemFlowEnd"></see></summary>
    let ItemFlowEnd =
        Namespaced_IRI.parse _namespace_name "ItemFlowEnd" |> NamespacedName

    /// <summary>
    /// An ItemUsage is a ItemUsage whose definition is a Structure. Nominally, if the definition is an ItemDefinition, an ItemUsage is a ItemUsage of that ItemDefinition within a system. However, other kinds of Kernel Structures are also allowed, to permit use of Structures from the Kernel Model Libraries.
    /// <see href="http://open-services.net/ns/sysmlv2#ItemUsage"></see></summary>
    let ItemUsage = Namespaced_IRI.parse _namespace_name "ItemUsage" |> NamespacedName
    /// <summary>
    /// A JoinNode is a ControlNode that waits for the completion of all the predecessor Actions given by incoming Successions.
    /// <see href="http://open-services.net/ns/sysmlv2#JoinNode"></see></summary>
    let JoinNode = Namespaced_IRI.parse _namespace_name "JoinNode" |> NamespacedName

    /// <summary>
    /// A LibraryPackage is a Package that is the container for a model library. A LibraryPackage is itself a library Element as are all Elements that are directly or indirectly contained in it.
    /// <see href="http://open-services.net/ns/sysmlv2#LibraryPackage"></see></summary>
    let LibraryPackage =
        Namespaced_IRI.parse _namespace_name "LibraryPackage" |> NamespacedName

    /// <summary>
    /// A Package is a Namespace used to group Elements, without any instance-level semantics. It may have one or more model-level evaluable filterCondition Expressions used to filter its importedMemberships. Any imported member must meet all of the filterConditions.
    /// <see href="http://open-services.net/ns/sysmlv2#Package"></see></summary>
    let Package = Namespaced_IRI.parse _namespace_name "Package" |> NamespacedName
    /// <summary>
    /// A LifeClass is a Class that specializes both the Class Occurrences::Life from the Kernel Semantic Library and a single OccurrenceDefinition, and has a multiplicity of 0..1. This constrains the OccurrenceDefinition being specialized to have at most one instance that is a complete Life.
    /// <see href="http://open-services.net/ns/sysmlv2#LifeClass"></see></summary>
    let LifeClass = Namespaced_IRI.parse _namespace_name "LifeClass" |> NamespacedName

    /// <summary>
    /// LiteralBoolean is a LiteralExpression that provides a Boolean value as a result. Its result parameter must have type Boolean.
    /// <see href="http://open-services.net/ns/sysmlv2#LiteralBoolean"></see></summary>
    let LiteralBoolean =
        Namespaced_IRI.parse _namespace_name "LiteralBoolean" |> NamespacedName

    /// <summary>
    /// A LiteralExpression is an Expression that provides a basic DataValue as a result.
    /// <see href="http://open-services.net/ns/sysmlv2#LiteralExpression"></see></summary>
    let LiteralExpression =
        Namespaced_IRI.parse _namespace_name "LiteralExpression" |> NamespacedName

    /// <summary>
    /// A LiteralInfinity is a LiteralExpression that provides the positive infinity value (*). It's result must have the type Positive.
    /// <see href="http://open-services.net/ns/sysmlv2#LiteralInfinity"></see></summary>
    let LiteralInfinity =
        Namespaced_IRI.parse _namespace_name "LiteralInfinity" |> NamespacedName

    /// <summary>
    /// A LiteralInteger is a LiteralExpression that provides an Integer value as a result. Its result parameter must have the type Integer.
    /// <see href="http://open-services.net/ns/sysmlv2#LiteralInteger"></see></summary>
    let LiteralInteger =
        Namespaced_IRI.parse _namespace_name "LiteralInteger" |> NamespacedName

    /// <summary>
    /// A LiteralRational is a LiteralExpression that provides a Rational value as a result. Its result parameter must have the type Rational.
    /// <see href="http://open-services.net/ns/sysmlv2#LiteralRational"></see></summary>
    let LiteralRational =
        Namespaced_IRI.parse _namespace_name "LiteralRational" |> NamespacedName

    /// <summary>
    /// A LiteralString is a LiteralExpression that provides a String value as a result. Its result parameter must have the type String.
    /// <see href="http://open-services.net/ns/sysmlv2#LiteralString"></see></summary>
    let LiteralString =
        Namespaced_IRI.parse _namespace_name "LiteralString" |> NamespacedName

    /// <summary>
    /// A Membership is a Relationship between a Namespace and an Element that indicates the Element is a member of (i.e., is contained in) the Namespace. Any memberNames specify how the memberElement is identified in the Namespace and the visibility specifies whether or not the memberElement is publicly visible from outside the Namespace.
    /// <see href="http://open-services.net/ns/sysmlv2#Membership"></see></summary>
    let Membership = Namespaced_IRI.parse _namespace_name "Membership" |> NamespacedName

    /// <summary>
    /// A MembershipExpose is an Expose  that exposes a specific importedMembership and, if isRecursive = true, additional Memberships recursively.
    /// <see href="http://open-services.net/ns/sysmlv2#MembershipExpose"></see></summary>
    let MembershipExpose =
        Namespaced_IRI.parse _namespace_name "MembershipExpose" |> NamespacedName

    /// <summary>
    /// A MembershipImport is an Import that imports its importedMembership into the importOwningNamespace. If isRecursive = true and the memberElement of the importedMembership is a Namespace, then the equivalent of a recursive NamespaceImport is also performed on that Namespace.
    /// <see href="http://open-services.net/ns/sysmlv2#MembershipImport"></see></summary>
    let MembershipImport =
        Namespaced_IRI.parse _namespace_name "MembershipImport" |> NamespacedName

    /// <summary>
    /// A MergeNode is a ControlNode that asserts the merging of its incoming Successions. A MergeNode may have at most one outgoing Successions.
    /// <see href="http://open-services.net/ns/sysmlv2#MergeNode"></see></summary>
    let MergeNode = Namespaced_IRI.parse _namespace_name "MergeNode" |> NamespacedName
    /// <summary>
    /// A Metaclass is a Structure used to type MetadataFeatures.
    /// <see href="http://open-services.net/ns/sysmlv2#Metaclass"></see></summary>
    let Metaclass = Namespaced_IRI.parse _namespace_name "Metaclass" |> NamespacedName

    /// <summary>
    /// A MetadataAccessExpression is an Expression whose result is a sequence of instances of Metaclasses representing all the MetadataFeature annotations of the referencedElement. In addition, the sequence includes an instance of the reflective Metaclass corresponding to the MOF class of the referencedElement, with values for all the abstract syntax properties of the referencedElement.
    /// <see href="http://open-services.net/ns/sysmlv2#MetadataAccessExpression"></see></summary>
    let MetadataAccessExpression =
        Namespaced_IRI.parse _namespace_name "MetadataAccessExpression" |> NamespacedName

    /// <summary>
    /// A MetadataDefinition is an ItemDefinition that is also a Metaclass.
    /// <see href="http://open-services.net/ns/sysmlv2#MetadataDefinition"></see></summary>
    let MetadataDefinition =
        Namespaced_IRI.parse _namespace_name "MetadataDefinition" |> NamespacedName

    /// <summary>
    /// A MetadataFeature is a Feature that is an AnnotatingElement used to annotate another Element with metadata. It is typed by a Metaclass. All its ownedFeatures must redefine features of its metaclass and any feature bindings must be model-level evaluable.
    /// <see href="http://open-services.net/ns/sysmlv2#MetadataFeature"></see></summary>
    let MetadataFeature =
        Namespaced_IRI.parse _namespace_name "MetadataFeature" |> NamespacedName

    /// <summary>
    /// A  MetadataUsage is a Usage and a MetadataFeature, used to annotate other Elements in a system model with metadata. As a MetadataFeature, its type must be a Metaclass, which will nominally be a MetadataDefinition. However, any kernel Metaclass is also allowed, to permit use of Metaclasses from the Kernel Model Libraries.
    /// <see href="http://open-services.net/ns/sysmlv2#MetadataUsage"></see></summary>
    let MetadataUsage =
        Namespaced_IRI.parse _namespace_name "MetadataUsage" |> NamespacedName

    /// <summary>
    /// A Multiplicity is a Feature whose co-domain is a set of natural numbers giving the allowed cardinalities of each typeWithMultiplicity. The cardinality of a Type is defined as follows, depending on whether the Type is a Classifier or Feature.
    /// .
    /// <see href="http://open-services.net/ns/sysmlv2#Multiplicity"></see></summary>
    let Multiplicity =
        Namespaced_IRI.parse _namespace_name "Multiplicity" |> NamespacedName

    /// <summary>
    /// A MultiplicityRange is a Multiplicity whose value is defined to be the (inclusive) range of natural numbers given by the result of a lowerBound Expression and the result of an upperBound Expression. The result of these Expressions shall be of type Natural. If the result of the upperBound Expression is the unbounded value *, then the specified range includes all natural numbers greater than or equal to the lowerBound value. If no lowerBound Expression, then the default is that the lower bound has the same value as the upper bound, except if the upperBound evaluates to *, in which case the default for the lower bound is 0.
    /// <see href="http://open-services.net/ns/sysmlv2#MultiplicityRange"></see></summary>
    let MultiplicityRange =
        Namespaced_IRI.parse _namespace_name "MultiplicityRange" |> NamespacedName

    /// <summary>
    /// A Namespace is an Element that contains other Elements, known as its members, via Membership Relationships with those Elements. The members of a Namespace may be owned by the Namespace, aliased in the Namespace, or imported into the Namespace via Import Relationships.
    /// <see href="http://open-services.net/ns/sysmlv2#Namespace"></see></summary>
    let Namespace = Namespaced_IRI.parse _namespace_name "Namespace" |> NamespacedName

    /// <summary>
    /// A NamespaceExpose is an Expose Relationship that exposes the Memberships of a specific importedNamespace and, if isRecursive = true, additional Memberships recursively.
    /// <see href="http://open-services.net/ns/sysmlv2#NamespaceExpose"></see></summary>
    let NamespaceExpose =
        Namespaced_IRI.parse _namespace_name "NamespaceExpose" |> NamespacedName

    /// <summary>
    /// A NamespaceImport is an Import that imports Memberships from its importedNamespace into the importOwningNamespace. If  isRecursive = false, then only the visible Memberships of the importedNamespace are imported. If  isRecursive = true, then, in addition, Memberships are recursively imported from any ownedMembers of the importedNamespace that are Namespaces.
    /// <see href="http://open-services.net/ns/sysmlv2#NamespaceImport"></see></summary>
    let NamespaceImport =
        Namespaced_IRI.parse _namespace_name "NamespaceImport" |> NamespacedName

    /// <summary>
    /// A NullExpression is an Expression that results in a null value.
    /// <see href="http://open-services.net/ns/sysmlv2#NullExpression"></see></summary>
    let NullExpression =
        Namespaced_IRI.parse _namespace_name "NullExpression" |> NamespacedName

    /// <summary>
    /// An ObjectiveMembership is a FeatureMembership that indicates that its ownedObjectiveRequirement is the objective RequirementUsage for its owningType, which must be a CaseDefinition or CaseUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#ObjectiveMembership"></see></summary>
    let ObjectiveMembership =
        Namespaced_IRI.parse _namespace_name "ObjectiveMembership" |> NamespacedName

    /// <summary>
    /// A PortConjugation is a Conjugation Relationship between a PortDefinition and its corresponding ConjugatedPortDefinition. As a result of this Relationship, the ConjugatedPortDefinition inherits all the features of the original PortDefinition, but input flows of the original PortDefinition become outputs on the ConjugatedPortDefinition and output flows of the original PortDefinition become inputs on the ConjugatedPortDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#PortConjugation"></see></summary>
    let PortConjugation =
        Namespaced_IRI.parse _namespace_name "PortConjugation" |> NamespacedName

    /// <summary>
    /// A PortUsage is a usage of a PortDefinition. A PortUsage itself as well as all its nestedUsages must be referential (non-composite).
    /// <see href="http://open-services.net/ns/sysmlv2#PortUsage"></see></summary>
    let PortUsage = Namespaced_IRI.parse _namespace_name "PortUsage" |> NamespacedName

    /// <summary>
    /// PortionKind is an enumeration of the specific kinds of Occurrence portions that can be represented by an OccurrenceUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#PortionKind"></see></summary>
    let PortionKind =
        Namespaced_IRI.parse _namespace_name "PortionKind" |> NamespacedName

    /// <summary>
    /// Redefinition is a kind of Subsetting that requires the redefinedFeature and the redefiningFeature to have the same values (on each instance of the domain of the redefiningFeature). This means any restrictions on the redefiningFeature, such as type or multiplicity, also apply to the redefinedFeature (on each instance of the domain of the redefiningFeature), and vice versa. The redefinedFeature might have values for instances of the domain of the redefiningFeature, but only as instances of the domain of the redefinedFeature that happen to also be instances of the domain of the redefiningFeature. This is supported by the constraints inherited from Subsetting on the domains of the redefiningFeature and redefinedFeature. However, these constraints are narrowed for Redefinition to require the owningTypes of the redefiningFeature and redefinedFeature to be different and the redefinedFeature to not be inherited into the owningNamespace of the redefiningFeature.This enables the redefiningFeature to have the same name as the redefinedFeature, if desired.
    /// <see href="http://open-services.net/ns/sysmlv2#Redefinition"></see></summary>
    let Redefinition =
        Namespaced_IRI.parse _namespace_name "Redefinition" |> NamespacedName

    /// <summary>
    /// Subsetting is Specialization in which the specific and general Types are Features. This means all values of the subsettingFeature (on instances of its domain, i.e., the intersection of its featuringTypes) are values of the subsettedFeature on instances of its domain. To support this the domain of the subsettingFeature must be the same or specialize (at least indirectly) the domain of the subsettedFeature (via Specialization), and the co-domain (intersection of the types) of the subsettingFeature must specialize the co-domain of the subsettedFeature.
    /// <see href="http://open-services.net/ns/sysmlv2#Subsetting"></see></summary>
    let Subsetting = Namespaced_IRI.parse _namespace_name "Subsetting" |> NamespacedName

    /// <summary>
    /// ReferenceSubsetting is a kind of Subsetting in which the referencedFeature is syntactically distinguished from other Features subsetted by the referencingFeature. ReferenceSubsetting has the same semantics as Subsetting, but the referenceFeature may have a special purpose relative to the referencingFeature. For instance, ReferenceSubsetting is used to identify the relatedFeatures of a Connector.
    /// <see href="http://open-services.net/ns/sysmlv2#ReferenceSubsetting"></see></summary>
    let ReferenceSubsetting =
        Namespaced_IRI.parse _namespace_name "ReferenceSubsetting" |> NamespacedName

    /// <summary>
    /// A ReferenceUsage is a Usage that specifies a non-compositional (isComposite = false) reference to something. The definition of a ReferenceUsage can be any kind of Classifier, with the default being the top-level Classifier Base::Anything from the Kernel Semantic Library. This allows the specification of a generic reference without distinguishing if the thing referenced is an attribute value, item, action, etc.
    /// <see href="http://open-services.net/ns/sysmlv2#ReferenceUsage"></see></summary>
    let ReferenceUsage =
        Namespaced_IRI.parse _namespace_name "ReferenceUsage" |> NamespacedName

    /// <summary>
    /// A RenderingDefinition is a PartDefinition that defines a specific rendering of the content of a model view (e.g., symbols, style, layout, etc.).
    /// <see href="http://open-services.net/ns/sysmlv2#RenderingDefinition"></see></summary>
    let RenderingDefinition =
        Namespaced_IRI.parse _namespace_name "RenderingDefinition" |> NamespacedName

    /// <summary>
    /// A RenderingUsage is the usage of a RenderingDefinition to specify the rendering of a specific model view to produce a physical view artifact.
    /// <see href="http://open-services.net/ns/sysmlv2#RenderingUsage"></see></summary>
    let RenderingUsage =
        Namespaced_IRI.parse _namespace_name "RenderingUsage" |> NamespacedName

    /// <summary>
    /// A RequirementConstraintKind indicates whether a ConstraintUsage is an assumption or a requirement in a RequirementDefinition or RequirementUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#RequirementConstraintKind"></see></summary>
    let RequirementConstraintKind =
        Namespaced_IRI.parse _namespace_name "RequirementConstraintKind" |> NamespacedName

    /// <summary>
    /// A RequirementVerificationMembership is a RequirementConstraintMembership  used in the objective of a VerificationCase to identify a RequirementUsage that is verified by the VerificationCase.
    /// <see href="http://open-services.net/ns/sysmlv2#RequirementVerificationMembership"></see></summary>
    let RequirementVerificationMembership =
        Namespaced_IRI.parse _namespace_name "RequirementVerificationMembership" |> NamespacedName

    /// <summary>
    /// A ResultExpressionMembership is a FeatureMembership that indicates that the ownedResultExpression provides the result values for the Function or Expression that owns it. The owning Function or Expression must contain a BindingConnector between the result parameter of the ownedResultExpression and the result parameter of the owning Function or Expression.
    /// <see href="http://open-services.net/ns/sysmlv2#ResultExpressionMembership"></see></summary>
    let ResultExpressionMembership =
        Namespaced_IRI.parse _namespace_name "ResultExpressionMembership" |> NamespacedName

    /// <summary>
    /// A ReturnParameterMembership is a ParameterMembership that indicates that the ownedMemberParameter is the result parameter of a Function or Expression. The direction of the ownedMemberParameter must be out.
    /// <see href="http://open-services.net/ns/sysmlv2#ReturnParameterMembership"></see></summary>
    let ReturnParameterMembership =
        Namespaced_IRI.parse _namespace_name "ReturnParameterMembership" |> NamespacedName

    /// <summary>
    /// A SatisfyRequirementUsage is an AssertConstraintUsage that asserts, by default, that a satisfied RequirementUsage is true for a specific satisfyingFeature, or, if isNegated = true, that the RequirementUsage is false. The satisfied RequirementUsage is related to the SatisfyRequirementUsage by a ReferenceSubsetting Relationship.
    /// <see href="http://open-services.net/ns/sysmlv2#SatisfyRequirementUsage"></see></summary>
    let SatisfyRequirementUsage =
        Namespaced_IRI.parse _namespace_name "SatisfyRequirementUsage" |> NamespacedName

    /// <summary>
    /// A SelectExpression is an OperatorExpression whose operator is "select", which resolves to the Function ControlFunctions::select from the Kernel Functions Library.
    /// <see href="http://open-services.net/ns/sysmlv2#SelectExpression"></see></summary>
    let SelectExpression =
        Namespaced_IRI.parse _namespace_name "SelectExpression" |> NamespacedName

    /// <summary>
    /// A SendActionUsage is an ActionUsage that specifies the sending of a payload given by the result of its payloadArgument Expression via a MessageTransfer whose source is given by the result of the senderArgument Expression and whose target is given by the result of the receiverArgument Expression. If no senderArgument is provided, the default is the this context for the action. If no receiverArgument is given, then the receiver is to be determined by, e.g., outgoing Connections from the sender.
    /// <see href="http://open-services.net/ns/sysmlv2#SendActionUsage"></see></summary>
    let SendActionUsage =
        Namespaced_IRI.parse _namespace_name "SendActionUsage" |> NamespacedName

    /// <summary>
    /// A StakeholderMembership is a ParameterMembership that identifies a PartUsage as a stakeholderParameter of a RequirementDefinition or RequirementUsage, which specifies a role played by an entity with concerns framed by the owningType.
    /// <see href="http://open-services.net/ns/sysmlv2#StakeholderMembership"></see></summary>
    let StakeholderMembership =
        Namespaced_IRI.parse _namespace_name "StakeholderMembership" |> NamespacedName

    /// <summary>
    /// A StateDefinition is the Definition of the Behavior of a system or part of a system in a certain state condition.
    /// <see href="http://open-services.net/ns/sysmlv2#StateDefinition"></see></summary>
    let StateDefinition =
        Namespaced_IRI.parse _namespace_name "StateDefinition" |> NamespacedName

    /// <summary>
    /// A StateSubactionKind indicates whether the action of a StateSubactionMembership is an entry, do or exit action.
    /// <see href="http://open-services.net/ns/sysmlv2#StateSubactionKind"></see></summary>
    let StateSubactionKind =
        Namespaced_IRI.parse _namespace_name "StateSubactionKind" |> NamespacedName

    /// <summary>
    /// A StateSubactionMembership is a FeatureMembership for an entry, do or exit ActionUsage of a StateDefinition or StateUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#StateSubactionMembership"></see></summary>
    let StateSubactionMembership =
        Namespaced_IRI.parse _namespace_name "StateSubactionMembership" |> NamespacedName

    /// <summary>
    /// Subclassification is Specialization in which both the specific and general Types are Classifier. This means all instances of the specific Classifier are also instances of the general Classifier.
    /// <see href="http://open-services.net/ns/sysmlv2#Subclassification"></see></summary>
    let Subclassification =
        Namespaced_IRI.parse _namespace_name "Subclassification" |> NamespacedName

    /// <summary>
    /// A SubjectMembership is a ParameterMembership that indicates that its ownedSubjectParameter is the subject of its owningType. The owningType of a SubjectMembership must be a RequirementDefinition, RequirementUsage, CaseDefinition, or CaseUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#SubjectMembership"></see></summary>
    let SubjectMembership =
        Namespaced_IRI.parse _namespace_name "SubjectMembership" |> NamespacedName

    /// <summary>
    /// A Succession is a binary Connector that requires its relatedFeatures to happen separately in time.
    /// <see href="http://open-services.net/ns/sysmlv2#Succession"></see></summary>
    let Succession = Namespaced_IRI.parse _namespace_name "Succession" |> NamespacedName

    /// <summary>
    /// A SuccessionAsUsage is both a ConnectorAsUsage and a Succession.
    /// <see href="http://open-services.net/ns/sysmlv2#SuccessionAsUsage"></see></summary>
    let SuccessionAsUsage =
        Namespaced_IRI.parse _namespace_name "SuccessionAsUsage" |> NamespacedName

    /// <summary>
    /// A SuccessionFlowConnectionUsage is a FlowConnectionUsage that is also a SuccessionItemFlow.
    /// <see href="http://open-services.net/ns/sysmlv2#SuccessionFlowConnectionUsage"></see></summary>
    let SuccessionFlowConnectionUsage =
        Namespaced_IRI.parse _namespace_name "SuccessionFlowConnectionUsage" |> NamespacedName

    /// <summary>
    /// A SuccessionItemFlow is an ItemFlow that also provides temporal ordering. It classifies Transfers that cannot start until the source Occurrence has completed and that must complete before the target Occurrence can start.
    /// <see href="http://open-services.net/ns/sysmlv2#SuccessionItemFlow"></see></summary>
    let SuccessionItemFlow =
        Namespaced_IRI.parse _namespace_name "SuccessionItemFlow" |> NamespacedName

    /// <summary>
    /// A TextualRepresentation is an AnnotatingElement whose body represents the representedElement in a given language. The representedElement must be the owner of the TextualRepresentation. The named language can be a natural language, in which case the body is an informal representation, or an artificial language, in which case the body is expected to be a formal, machine-parsable representation.
    /// <see href="http://open-services.net/ns/sysmlv2#TextualRepresentation"></see></summary>
    let TextualRepresentation =
        Namespaced_IRI.parse _namespace_name "TextualRepresentation" |> NamespacedName

    /// <summary>
    /// A TransitionActionKind indicates whether the transitionFeature of a TransitionFeatureMembership is a trigger, guard or effect.
    /// <see href="http://open-services.net/ns/sysmlv2#TransitionFeatureKind"></see></summary>
    let TransitionFeatureKind =
        Namespaced_IRI.parse _namespace_name "TransitionFeatureKind" |> NamespacedName

    /// <summary>
    /// A TransitionFeatureMembership is a FeatureMembership for a trigger, guard or effect of a TransitionUsage, whose transitionFeature is a AcceptActionUsage, Boolean-valued Expression or ActionUsage, depending on its kind. .
    /// <see href="http://open-services.net/ns/sysmlv2#TransitionFeatureMembership"></see></summary>
    let TransitionFeatureMembership =
        Namespaced_IRI.parse _namespace_name "TransitionFeatureMembership" |> NamespacedName

    /// <summary>
    /// A TransitionUsage is an ActionUsage representing a triggered transition between ActionUsages or StateUsages. When triggered by a triggerAction, when its guardExpression is true, the TransitionUsage asserts that its source is exited, then its effectAction (if any) is performed, and then its target is entered.
    /// <see href="http://open-services.net/ns/sysmlv2#TransitionUsage"></see></summary>
    let TransitionUsage =
        Namespaced_IRI.parse _namespace_name "TransitionUsage" |> NamespacedName

    /// <summary>
    /// A TriggerInvocationExpression is an InvocationExpression that invokes one of the trigger Functions from the Kernel Semantic Library Triggers package, as indicated by its kind.
    /// <see href="http://open-services.net/ns/sysmlv2#TriggerInvocationExpression"></see></summary>
    let TriggerInvocationExpression =
        Namespaced_IRI.parse _namespace_name "TriggerInvocationExpression" |> NamespacedName

    /// <summary>
    /// TriggerKind enumerates the kinds of triggers that can be represented by a TriggerInvocationExpression.
    /// <see href="http://open-services.net/ns/sysmlv2#TriggerKind"></see></summary>
    let TriggerKind =
        Namespaced_IRI.parse _namespace_name "TriggerKind" |> NamespacedName

    /// <summary>
    /// A TypeFeaturing is a Featuring Relationship in which the featureOfType is the source and the featuringType is the target.
    /// <see href="http://open-services.net/ns/sysmlv2#TypeFeaturing"></see></summary>
    let TypeFeaturing =
        Namespaced_IRI.parse _namespace_name "TypeFeaturing" |> NamespacedName

    /// <summary>
    /// Unioning is a Relationship that makes its unioningType one of the unioningTypes of its typeUnioned.
    /// <see href="http://open-services.net/ns/sysmlv2#Unioning"></see></summary>
    let Unioning = Namespaced_IRI.parse _namespace_name "Unioning" |> NamespacedName

    /// <summary>
    /// A UseCaseDefinition is a CaseDefinition that specifies a set of actions performed by its subject, in interaction with one or more actors external to the subject. The objective is to yield an observable result that is of value to one or more of the actors.
    /// <see href="http://open-services.net/ns/sysmlv2#UseCaseDefinition"></see></summary>
    let UseCaseDefinition =
        Namespaced_IRI.parse _namespace_name "UseCaseDefinition" |> NamespacedName

    /// <summary>
    /// A VariantMembership is a Membership between a variation point Definition or Usage and a Usage that represents a variant in the context of that variation. The membershipOwningNamespace for the VariantMembership must be either a Definition or a Usage with isVariation = true.
    /// <see href="http://open-services.net/ns/sysmlv2#VariantMembership"></see></summary>
    let VariantMembership =
        Namespaced_IRI.parse _namespace_name "VariantMembership" |> NamespacedName

    /// <summary>
    /// A VerificationCaseDefinition is a CaseDefinition for the purpose of verification of the subject of the case against its requirements.
    /// <see href="http://open-services.net/ns/sysmlv2#VerificationCaseDefinition"></see></summary>
    let VerificationCaseDefinition =
        Namespaced_IRI.parse _namespace_name "VerificationCaseDefinition" |> NamespacedName

    /// <summary>
    /// A VerificationCaseUsage is a Usage of a VerificationCaseDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#VerificationCaseUsage"></see></summary>
    let VerificationCaseUsage =
        Namespaced_IRI.parse _namespace_name "VerificationCaseUsage" |> NamespacedName

    /// <summary>
    /// A ViewDefinition is a PartDefinition that specifies how a view artifact is constructed to satisfy a viewpoint. It specifies a viewConditions to define the model content to be presented and a viewRendering to define how the model content is presented.
    /// <see href="http://open-services.net/ns/sysmlv2#ViewDefinition"></see></summary>
    let ViewDefinition =
        Namespaced_IRI.parse _namespace_name "ViewDefinition" |> NamespacedName

    /// <summary>
    /// A ViewRenderingMembership is a FeatureMembership that identifies the viewRendering of a ViewDefinition or ViewUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#ViewRenderingMembership"></see></summary>
    let ViewRenderingMembership =
        Namespaced_IRI.parse _namespace_name "ViewRenderingMembership" |> NamespacedName

    /// <summary>
    /// A ViewUsage is a usage of a ViewDefinition to specify the generation of a view of the members of a collection of exposedNamespaces. The ViewUsage can satisfy more viewpoints than its definition, and it can specialize the viewRendering specified by its definition.
    /// <see href="http://open-services.net/ns/sysmlv2#ViewUsage"></see></summary>
    let ViewUsage = Namespaced_IRI.parse _namespace_name "ViewUsage" |> NamespacedName

    /// <summary>
    /// A ViewpointDefinition is a RequirementDefinition that specifies one or more stakeholder concerns that are to be satisfied by creating a view of a model.
    /// <see href="http://open-services.net/ns/sysmlv2#ViewpointDefinition"></see></summary>
    let ViewpointDefinition =
        Namespaced_IRI.parse _namespace_name "ViewpointDefinition" |> NamespacedName

    /// <summary>
    /// A ViewpointUsage is a Usage of a ViewpointDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#ViewpointUsage"></see></summary>
    let ViewpointUsage =
        Namespaced_IRI.parse _namespace_name "ViewpointUsage" |> NamespacedName

    /// <summary>
    /// VisibilityKind is an enumeration whose literals specify the visibility of a Membership of an Element in a Namespace outside of that Namespace. Note that "visibility" specifically restricts whether an Element in a Namespace may be referenced by name from outside the Namespace and only otherwise restricts access to an Element as provided by specific constraints in the abstract syntax (e.g., preventing the import or inheritance of private Elements).
    /// <see href="http://open-services.net/ns/sysmlv2#VisibilityKind"></see></summary>
    let VisibilityKind =
        Namespaced_IRI.parse _namespace_name "VisibilityKind" |> NamespacedName

    /// <summary>
    /// A WhileLoopActionUsage is a LoopActionUsage that specifies that the bodyAction ActionUsage should be performed repeatedly while the result of the whileArgument Expression is true or until the result of the untilArgument Expression (if provided) is true. The whileArgument Expression is evaluated before each (possible) performance of the bodyAction, and the untilArgument Expression is evaluated after each performance of the bodyAction.
    /// <see href="http://open-services.net/ns/sysmlv2#WhileLoopActionUsage"></see></summary>
    let WhileLoopActionUsage =
        Namespaced_IRI.parse _namespace_name "WhileLoopActionUsage" |> NamespacedName

    /// <summary>
    /// An Expression whose result is bound to the payload parameter of this AcceptActionUsage. If provided, the AcceptActionUsage will only accept a Transfer with exactly this payload.
    /// <see href="http://open-services.net/ns/sysmlv2#acceptActionUsage_PayloadArgument"></see></summary>
    let acceptActionUsage_PayloadArgument =
        Namespaced_IRI.parse _namespace_name "acceptActionUsage_PayloadArgument" |> NamespacedName

    /// <summary>
    /// The nestedReference of this AcceptActionUsage that redefines the payload output parameter of the base AcceptActionUsage AcceptAction from the Systems Model Library.
    /// <see href="http://open-services.net/ns/sysmlv2#acceptActionUsage_PayloadParameter"></see></summary>
    let acceptActionUsage_PayloadParameter =
        Namespaced_IRI.parse _namespace_name "acceptActionUsage_PayloadParameter" |> NamespacedName

    /// <summary>
    /// An Expression whose result is bound to the receiver input parameter of this AcceptActionUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#acceptActionUsage_ReceiverArgument"></see></summary>
    let acceptActionUsage_ReceiverArgument =
        Namespaced_IRI.parse _namespace_name "acceptActionUsage_ReceiverArgument" |> NamespacedName

    /// <summary>
    /// The ActionUsages that are steps in this ActionDefinition, which define the actions that specify the behavior of the ActionDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#actionDefinition_Action"></see></summary>
    let actionDefinition_Action =
        Namespaced_IRI.parse _namespace_name "actionDefinition_Action" |> NamespacedName

    /// <summary>
    /// The Behaviors that are the types of this ActionUsage. Nominally, these would be ActionDefinitions, but other kinds of Kernel Behaviors are also allowed, to permit use of Behaviors from the Kernel Model Libraries.
    /// <see href="http://open-services.net/ns/sysmlv2#actionUsage_ActionDefinition"></see></summary>
    let actionUsage_ActionDefinition =
        Namespaced_IRI.parse _namespace_name "actionUsage_ActionDefinition" |> NamespacedName

    /// <summary>
    /// The PartUsage specifying the actor.
    /// <see href="http://open-services.net/ns/sysmlv2#actorMembership_OwnedActorParameter"></see></summary>
    let actorMembership_OwnedActorParameter =
        Namespaced_IRI.parse _namespace_name "actorMembership_OwnedActorParameter" |> NamespacedName

    /// <summary>
    /// The AllocationUsages that refine the allocation mapping defined by this AllocationDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#allocationDefinition_Allocation"></see></summary>
    let allocationDefinition_Allocation =
        Namespaced_IRI.parse _namespace_name "allocationDefinition_Allocation" |> NamespacedName

    /// <summary>
    /// The AllocationDefinitions that are the types of this AllocationUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#allocationUsage_AllocationDefinition"></see></summary>
    let allocationUsage_AllocationDefinition =
        Namespaced_IRI.parse _namespace_name "allocationUsage_AllocationDefinition" |> NamespacedName

    /// <summary>
    /// The composite actions of the AnalysisCaseDefinition that are defined as AnalysisActions.
    /// <see href="http://open-services.net/ns/sysmlv2#analysisCaseDefinition_AnalysisAction"></see></summary>
    let analysisCaseDefinition_AnalysisAction =
        Namespaced_IRI.parse _namespace_name "analysisCaseDefinition_AnalysisAction" |> NamespacedName

    /// <summary>
    /// An Expression used to compute the result of the AnalysisCaseDefinition, owned via a ResultExpressionMembership.
    /// <see href="http://open-services.net/ns/sysmlv2#analysisCaseDefinition_ResultExpression"></see></summary>
    let analysisCaseDefinition_ResultExpression =
        Namespaced_IRI.parse _namespace_name "analysisCaseDefinition_ResultExpression" |> NamespacedName

    /// <summary>
    /// The composite usages of the AnalysisCaseUsage that are defined as AnalysisActions.
    /// <see href="http://open-services.net/ns/sysmlv2#analysisCaseUsage_AnalysisAction"></see></summary>
    let analysisCaseUsage_AnalysisAction =
        Namespaced_IRI.parse _namespace_name "analysisCaseUsage_AnalysisAction" |> NamespacedName

    /// <summary>
    /// The AnalysisCaseDefinition that is the definition of this AnalysisCaseUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#analysisCaseUsage_AnalysisCaseDefinition"></see></summary>
    let analysisCaseUsage_AnalysisCaseDefinition =
        Namespaced_IRI.parse _namespace_name "analysisCaseUsage_AnalysisCaseDefinition" |> NamespacedName

    /// <summary>
    /// An Expression used to compute the result of the AnalysisCaseUsage, owned via a ResultExpressionMembership.
    /// <see href="http://open-services.net/ns/sysmlv2#analysisCaseUsage_ResultExpression"></see></summary>
    let analysisCaseUsage_ResultExpression =
        Namespaced_IRI.parse _namespace_name "analysisCaseUsage_ResultExpression" |> NamespacedName

    /// <summary>
    /// The Elements that are annotated by this AnnotatingElement. If annotation is not empty, these are the annotatedElements of the annotations. If annotation is empty, then it is the owningNamespace of the AnnotatingElement.
    /// <see href="http://open-services.net/ns/sysmlv2#annotatingElement_AnnotatedElement"></see></summary>
    let annotatingElement_AnnotatedElement =
        Namespaced_IRI.parse _namespace_name "annotatingElement_AnnotatedElement" |> NamespacedName

    /// <summary>
    /// The Annotations that relate this AnnotatingElement to its annotatedElements.
    /// <see href="http://open-services.net/ns/sysmlv2#annotatingElement_Annotation"></see></summary>
    let annotatingElement_Annotation =
        Namespaced_IRI.parse _namespace_name "annotatingElement_Annotation" |> NamespacedName

    /// <summary>
    /// The ownedRelationships of this AnnotatingElement that are Annotations, for which this AnnotatingElement is the annotatingElement.
    /// <see href="http://open-services.net/ns/sysmlv2#annotatingElement_OwnedAnnotatingRelationship"></see></summary>
    let annotatingElement_OwnedAnnotatingRelationship =
        Namespaced_IRI.parse _namespace_name "annotatingElement_OwnedAnnotatingRelationship" |> NamespacedName

    /// <summary>
    /// The Element that is annotated by the annotatingElement of this Annotation.
    /// <see href="http://open-services.net/ns/sysmlv2#annotation_AnnotatedElement"></see></summary>
    let annotation_AnnotatedElement =
        Namespaced_IRI.parse _namespace_name "annotation_AnnotatedElement" |> NamespacedName

    /// <summary>
    /// The AnnotatingElement that annotates the annotatedElement of this Annotation.
    /// <see href="http://open-services.net/ns/sysmlv2#annotation_AnnotatingElement"></see></summary>
    let annotation_AnnotatingElement =
        Namespaced_IRI.parse _namespace_name "annotation_AnnotatingElement" |> NamespacedName

    /// <summary>
    /// The annotatedElement of this Annotation, when it is also its owningRelatedElement.
    /// <see href="http://open-services.net/ns/sysmlv2#annotation_OwningAnnotatedElement"></see></summary>
    let annotation_OwningAnnotatedElement =
        Namespaced_IRI.parse _namespace_name "annotation_OwningAnnotatedElement" |> NamespacedName

    /// <summary>
    /// The annotatingElement of this Annotation, when it is also its owningRelatedElement.
    /// <see href="http://open-services.net/ns/sysmlv2#annotation_OwningAnnotatingElement"></see></summary>
    let annotation_OwningAnnotatingElement =
        Namespaced_IRI.parse _namespace_name "annotation_OwningAnnotatingElement" |> NamespacedName

    /// <summary>
    /// The ConstraintUsage to be performed by the AssertConstraintUsage. It is the referenceFeature of the ownedReferenceSubsetting for the AssertConstraintUsage, if there is one, and, otherwise, the AssertConstraintUsage itself.
    /// <see href="http://open-services.net/ns/sysmlv2#assertConstraintUsage_AssertedConstraint"></see></summary>
    let assertConstraintUsage_AssertedConstraint =
        Namespaced_IRI.parse _namespace_name "assertConstraintUsage_AssertedConstraint" |> NamespacedName

    /// <summary>
    /// The Feature whose value is to be set.
    /// <see href="http://open-services.net/ns/sysmlv2#assignmentActionUsage_Referent"></see></summary>
    let assignmentActionUsage_Referent =
        Namespaced_IRI.parse _namespace_name "assignmentActionUsage_Referent" |> NamespacedName

    /// <summary>
    /// The Expression whose value is an occurrence in the domain of the referent Feature, for which the value of the referent will be set to the result of the valueExpression by this AssignmentActionUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#assignmentActionUsage_TargetArgument"></see></summary>
    let assignmentActionUsage_TargetArgument =
        Namespaced_IRI.parse _namespace_name "assignmentActionUsage_TargetArgument" |> NamespacedName

    /// <summary>
    /// The Expression whose result is to be assigned to the referent Feature.
    /// <see href="http://open-services.net/ns/sysmlv2#assignmentActionUsage_ValueExpression"></see></summary>
    let assignmentActionUsage_ValueExpression =
        Namespaced_IRI.parse _namespace_name "assignmentActionUsage_ValueExpression" |> NamespacedName

    /// <summary>
    /// The features of the Association that identify the things that can be related by it. A concrete Association must have at least two associationEnds. When it has exactly two, the Association is called a binary Association.
    /// <see href="http://open-services.net/ns/sysmlv2#association_AssociationEnd"></see></summary>
    let association_AssociationEnd =
        Namespaced_IRI.parse _namespace_name "association_AssociationEnd" |> NamespacedName

    /// <summary>
    /// The types of the associationEnds of the Association, which are the relatedElements of the Association considered as a Relationship.
    /// <see href="http://open-services.net/ns/sysmlv2#association_RelatedType"></see></summary>
    let association_RelatedType =
        Namespaced_IRI.parse _namespace_name "association_RelatedType" |> NamespacedName

    /// <summary>
    /// The source relatedType for this Association. It is the first relatedType of the Association.
    /// <see href="http://open-services.net/ns/sysmlv2#association_SourceType"></see></summary>
    let association_SourceType =
        Namespaced_IRI.parse _namespace_name "association_SourceType" |> NamespacedName

    /// <summary>
    /// The target relatedTypes for this Association. This includes all the relatedTypes other than the sourceType.
    /// <see href="http://open-services.net/ns/sysmlv2#association_TargetType"></see></summary>
    let association_TargetType =
        Namespaced_IRI.parse _namespace_name "association_TargetType" |> NamespacedName

    /// <summary>
    /// The DataTypes that are the types of this AttributeUsage. Nominally, these are AttributeDefinitions, but other kinds of kernel DataTypes are also allowed, to permit use of DataTypes from the Kernel Model Libraries.
    /// <see href="http://open-services.net/ns/sysmlv2#attributeUsage_AttributeDefinition"></see></summary>
    let attributeUsage_AttributeDefinition =
        Namespaced_IRI.parse _namespace_name "attributeUsage_AttributeDefinition" |> NamespacedName

    /// <summary>
    /// The parameters of this Behavior, which are defined as its directedFeatures, whose values are passed into and/or out of a performance of the Behavior.
    /// <see href="http://open-services.net/ns/sysmlv2#behavior_Parameter"></see></summary>
    let behavior_Parameter =
        Namespaced_IRI.parse _namespace_name "behavior_Parameter" |> NamespacedName

    /// <summary>
    /// The Steps that make up this Behavior.
    /// <see href="http://open-services.net/ns/sysmlv2#behavior_Step"></see></summary>
    let behavior_Step =
        Namespaced_IRI.parse _namespace_name "behavior_Step" |> NamespacedName

    /// <summary>
    /// The Predicate that types this BooleanExpression.
    /// <see href="http://open-services.net/ns/sysmlv2#booleanExpression_Predicate"></see></summary>
    let booleanExpression_Predicate =
        Namespaced_IRI.parse _namespace_name "booleanExpression_Predicate" |> NamespacedName

    /// <summary>
    /// The actions of this CalculationDefinition that are CalculationUsages.
    /// <see href="http://open-services.net/ns/sysmlv2#calculationDefinition_Calculation"></see></summary>
    let calculationDefinition_Calculation =
        Namespaced_IRI.parse _namespace_name "calculationDefinition_Calculation" |> NamespacedName

    /// <summary>
    /// The Function that is the type of this CalculationUsage. Nominally, this would be a CalculationDefinition, but a kernel Function is also allowed, to permit use of Functions from the Kernel Model Libraries.
    /// <see href="http://open-services.net/ns/sysmlv2#calculationUsage_CalculationDefinition"></see></summary>
    let calculationUsage_CalculationDefinition =
        Namespaced_IRI.parse _namespace_name "calculationUsage_CalculationDefinition" |> NamespacedName

    /// <summary>
    /// The parameters of this CaseDefinition that represent actors involved in the case.
    /// <see href="http://open-services.net/ns/sysmlv2#caseDefinition_ActorParameter"></see></summary>
    let caseDefinition_ActorParameter =
        Namespaced_IRI.parse _namespace_name "caseDefinition_ActorParameter" |> NamespacedName

    /// <summary>
    /// The RequirementUsage representing the objective of this CaseDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#caseDefinition_ObjectiveRequirement"></see></summary>
    let caseDefinition_ObjectiveRequirement =
        Namespaced_IRI.parse _namespace_name "caseDefinition_ObjectiveRequirement" |> NamespacedName

    /// <summary>
    /// The parameter of this CaseDefinition that represents its subject.
    /// <see href="http://open-services.net/ns/sysmlv2#caseDefinition_SubjectParameter"></see></summary>
    let caseDefinition_SubjectParameter =
        Namespaced_IRI.parse _namespace_name "caseDefinition_SubjectParameter" |> NamespacedName

    /// <summary>
    /// The parameters of this CaseUsage that represent actors involved in the case.
    /// <see href="http://open-services.net/ns/sysmlv2#caseUsage_ActorParameter"></see></summary>
    let caseUsage_ActorParameter =
        Namespaced_IRI.parse _namespace_name "caseUsage_ActorParameter" |> NamespacedName

    /// <summary>
    /// The CaseDefinition that is the type of this CaseUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#caseUsage_CaseDefinition"></see></summary>
    let caseUsage_CaseDefinition =
        Namespaced_IRI.parse _namespace_name "caseUsage_CaseDefinition" |> NamespacedName

    /// <summary>
    /// The RequirementUsage representing the objective of this CaseUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#caseUsage_ObjectiveRequirement"></see></summary>
    let caseUsage_ObjectiveRequirement =
        Namespaced_IRI.parse _namespace_name "caseUsage_ObjectiveRequirement" |> NamespacedName

    /// <summary>
    /// The parameter of this CaseUsage that represents its subject.
    /// <see href="http://open-services.net/ns/sysmlv2#caseUsage_SubjectParameter"></see></summary>
    let caseUsage_SubjectParameter =
        Namespaced_IRI.parse _namespace_name "caseUsage_SubjectParameter" |> NamespacedName

    /// <summary>
    /// The ownedSpecializations of this Classifier that are Subclassifications, for which this Classifier is the subclassifier.
    /// <see href="http://open-services.net/ns/sysmlv2#classifier_OwnedSubclassification"></see></summary>
    let classifier_OwnedSubclassification =
        Namespaced_IRI.parse _namespace_name "classifier_OwnedSubclassification" |> NamespacedName

    /// <summary>
    /// The annotation text for the Comment.
    /// <see href="http://open-services.net/ns/sysmlv2#comment_Body"></see></summary>
    let comment_Body =
        Namespaced_IRI.parse _namespace_name "comment_Body" |> NamespacedName

    /// <summary>
    /// Identification of the language of the body text and, optionally, the region and/or encoding. The format shall be a POSIX locale conformant to ISO/IEC 15897, with the format [language[_territory][.codeset][@modifier]].
    /// <see href="http://open-services.net/ns/sysmlv2#comment_Locale"></see></summary>
    let comment_Locale =
        Namespaced_IRI.parse _namespace_name "comment_Locale" |> NamespacedName

    /// <summary>
    /// The ConcernDefinition that is the single type of this ConcernUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#concernUsage_ConcernDefinition"></see></summary>
    let concernUsage_ConcernDefinition =
        Namespaced_IRI.parse _namespace_name "concernUsage_ConcernDefinition" |> NamespacedName

    /// <summary>
    /// The original PortDefinition for this ConjugatedPortDefinition, which is the owningNamespace of the ConjugatedPortDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#conjugatedPortDefinition_OriginalPortDefinition"></see></summary>
    let conjugatedPortDefinition_OriginalPortDefinition =
        Namespaced_IRI.parse _namespace_name "conjugatedPortDefinition_OriginalPortDefinition" |> NamespacedName

    /// <summary>
    /// The PortConjugation that is the ownedConjugator of this ConjugatedPortDefinition, linking it to its originalPortDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#conjugatedPortDefinition_OwnedPortConjugator"></see></summary>
    let conjugatedPortDefinition_OwnedPortConjugator =
        Namespaced_IRI.parse _namespace_name "conjugatedPortDefinition_OwnedPortConjugator" |> NamespacedName

    /// <summary>
    /// The type of this ConjugatedPortTyping considered as a FeatureTyping, which must be a ConjugatedPortDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#conjugatedPortTyping_ConjugatedPortDefinition"></see></summary>
    let conjugatedPortTyping_ConjugatedPortDefinition =
        Namespaced_IRI.parse _namespace_name "conjugatedPortTyping_ConjugatedPortDefinition" |> NamespacedName

    /// <summary>
    /// The originalPortDefinition of the conjugatedPortDefinition of this ConjugatedPortTyping.
    /// <see href="http://open-services.net/ns/sysmlv2#conjugatedPortTyping_PortDefinition"></see></summary>
    let conjugatedPortTyping_PortDefinition =
        Namespaced_IRI.parse _namespace_name "conjugatedPortTyping_PortDefinition" |> NamespacedName

    /// <summary>
    /// The Type that is the result of applying Conjugation to the originalType.
    /// <see href="http://open-services.net/ns/sysmlv2#conjugation_ConjugatedType"></see></summary>
    let conjugation_ConjugatedType =
        Namespaced_IRI.parse _namespace_name "conjugation_ConjugatedType" |> NamespacedName

    /// <summary>
    /// The Type to be conjugated.
    /// <see href="http://open-services.net/ns/sysmlv2#conjugation_OriginalType"></see></summary>
    let conjugation_OriginalType =
        Namespaced_IRI.parse _namespace_name "conjugation_OriginalType" |> NamespacedName

    /// <summary>
    /// The conjugatedType of this Conjugation that is also its owningRelatedElement.
    /// <see href="http://open-services.net/ns/sysmlv2#conjugation_OwningType"></see></summary>
    let conjugation_OwningType =
        Namespaced_IRI.parse _namespace_name "conjugation_OwningType" |> NamespacedName

    /// <summary>
    /// The Usages that define the things related by the ConnectionDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#connectionDefinition_ConnectionEnd"></see></summary>
    let connectionDefinition_ConnectionEnd =
        Namespaced_IRI.parse _namespace_name "connectionDefinition_ConnectionEnd" |> NamespacedName

    /// <summary>
    /// The AssociationStructures that are the types of this ConnectionUsage. Nominally, these are , but other kinds of Kernel AssociationStructures are also allowed, to permit use of AssociationStructures from the Kernel Model Libraries.
    /// <see href="http://open-services.net/ns/sysmlv2#connectionUsage_ConnectionDefinition"></see></summary>
    let connectionUsage_ConnectionDefinition =
        Namespaced_IRI.parse _namespace_name "connectionUsage_ConnectionDefinition" |> NamespacedName

    /// <summary>
    /// The Associations that type the Connector.
    /// <see href="http://open-services.net/ns/sysmlv2#connector_Association"></see></summary>
    let connector_Association =
        Namespaced_IRI.parse _namespace_name "connector_Association" |> NamespacedName

    /// <summary>
    /// The endFeatures of a Connector, which redefine the endFeatures of the associations of the Connector. The connectorEnds determine via ReferenceSubsetting Relationships which Features are related by the Connector.
    /// <see href="http://open-services.net/ns/sysmlv2#connector_ConnectorEnd"></see></summary>
    let connector_ConnectorEnd =
        Namespaced_IRI.parse _namespace_name "connector_ConnectorEnd" |> NamespacedName

    /// <summary>
    /// The Features that are related by this Connector considered as a Relationship and that restrict the links it identifies, given by the referenced Features of the connectorEnds of the Connector.
    /// <see href="http://open-services.net/ns/sysmlv2#connector_RelatedFeature"></see></summary>
    let connector_RelatedFeature =
        Namespaced_IRI.parse _namespace_name "connector_RelatedFeature" |> NamespacedName

    /// <summary>
    /// The source relatedFeature for this Connector. It is the first relatedFeature.
    /// <see href="http://open-services.net/ns/sysmlv2#connector_SourceFeature"></see></summary>
    let connector_SourceFeature =
        Namespaced_IRI.parse _namespace_name "connector_SourceFeature" |> NamespacedName

    /// <summary>
    /// The target relatedFeatures for this Connector. This includes all the relatedFeatures other than the sourceFeature.
    /// <see href="http://open-services.net/ns/sysmlv2#connector_TargetFeature"></see></summary>
    let connector_TargetFeature =
        Namespaced_IRI.parse _namespace_name "connector_TargetFeature" |> NamespacedName

    /// <summary>
    /// The (single) Predicate that is the type of this ConstraintUsage. Nominally, this will be a ConstraintDefinition, but other kinds of Predicates are also allowed, to permit use of Predicates from the Kernel Model Libraries.
    /// <see href="http://open-services.net/ns/sysmlv2#constraintUsage_ConstraintDefinition"></see></summary>
    let constraintUsage_ConstraintDefinition =
        Namespaced_IRI.parse _namespace_name "constraintUsage_ConstraintDefinition" |> NamespacedName

    /// <summary>
    /// The usages of this Definition that are directedFeatures.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_DirectedUsage"></see></summary>
    let definition_DirectedUsage =
        Namespaced_IRI.parse _namespace_name "definition_DirectedUsage" |> NamespacedName

    /// <summary>
    /// Whether this Definition is for a variation point or not. If true, then all the memberships of the Definition must be VariantMemberships.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_IsVariation"></see></summary>
    let definition_IsVariation =
        Namespaced_IRI.parse _namespace_name "definition_IsVariation" |> NamespacedName

    /// <summary>
    /// The ActionUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedAction"></see></summary>
    let definition_OwnedAction =
        Namespaced_IRI.parse _namespace_name "definition_OwnedAction" |> NamespacedName

    /// <summary>
    /// The AllocationUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedAllocation"></see></summary>
    let definition_OwnedAllocation =
        Namespaced_IRI.parse _namespace_name "definition_OwnedAllocation" |> NamespacedName

    /// <summary>
    /// The AnalysisCaseUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedAnalysisCase"></see></summary>
    let definition_OwnedAnalysisCase =
        Namespaced_IRI.parse _namespace_name "definition_OwnedAnalysisCase" |> NamespacedName

    /// <summary>
    /// The AttributeUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedAttribute"></see></summary>
    let definition_OwnedAttribute =
        Namespaced_IRI.parse _namespace_name "definition_OwnedAttribute" |> NamespacedName

    /// <summary>
    /// The CalculationUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedCalculation"></see></summary>
    let definition_OwnedCalculation =
        Namespaced_IRI.parse _namespace_name "definition_OwnedCalculation" |> NamespacedName

    /// <summary>
    /// The code&gt;CaseUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedCase"></see></summary>
    let definition_OwnedCase =
        Namespaced_IRI.parse _namespace_name "definition_OwnedCase" |> NamespacedName

    /// <summary>
    /// The ConcernUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedConcern"></see></summary>
    let definition_OwnedConcern =
        Namespaced_IRI.parse _namespace_name "definition_OwnedConcern" |> NamespacedName

    /// <summary>
    /// The ConnectorAsUsages that are ownedUsages of this Definition. Note that this list includes BindingConnectorAsUsages and SuccessionAsUsages, even though these are ConnectorAsUsages but not ConnectionUsages.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedConnection"></see></summary>
    let definition_OwnedConnection =
        Namespaced_IRI.parse _namespace_name "definition_OwnedConnection" |> NamespacedName

    /// <summary>
    /// The ConstraintUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedConstraint"></see></summary>
    let definition_OwnedConstraint =
        Namespaced_IRI.parse _namespace_name "definition_OwnedConstraint" |> NamespacedName

    /// <summary>
    /// The EnumerationUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedEnumeration"></see></summary>
    let definition_OwnedEnumeration =
        Namespaced_IRI.parse _namespace_name "definition_OwnedEnumeration" |> NamespacedName

    /// <summary>
    /// The FlowConnectionUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedFlow"></see></summary>
    let definition_OwnedFlow =
        Namespaced_IRI.parse _namespace_name "definition_OwnedFlow" |> NamespacedName

    /// <summary>
    /// The InterfaceUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedInterface"></see></summary>
    let definition_OwnedInterface =
        Namespaced_IRI.parse _namespace_name "definition_OwnedInterface" |> NamespacedName

    /// <summary>
    /// The ItemUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedItem"></see></summary>
    let definition_OwnedItem =
        Namespaced_IRI.parse _namespace_name "definition_OwnedItem" |> NamespacedName

    /// <summary>
    /// The MetadataUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedMetadata"></see></summary>
    let definition_OwnedMetadata =
        Namespaced_IRI.parse _namespace_name "definition_OwnedMetadata" |> NamespacedName

    /// <summary>
    /// The OccurrenceUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedOccurrence"></see></summary>
    let definition_OwnedOccurrence =
        Namespaced_IRI.parse _namespace_name "definition_OwnedOccurrence" |> NamespacedName

    /// <summary>
    /// The PartUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedPart"></see></summary>
    let definition_OwnedPart =
        Namespaced_IRI.parse _namespace_name "definition_OwnedPart" |> NamespacedName

    /// <summary>
    /// The PortUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedPort"></see></summary>
    let definition_OwnedPort =
        Namespaced_IRI.parse _namespace_name "definition_OwnedPort" |> NamespacedName

    /// <summary>
    /// The ReferenceUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedReference"></see></summary>
    let definition_OwnedReference =
        Namespaced_IRI.parse _namespace_name "definition_OwnedReference" |> NamespacedName

    /// <summary>
    /// The RenderingUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedRendering"></see></summary>
    let definition_OwnedRendering =
        Namespaced_IRI.parse _namespace_name "definition_OwnedRendering" |> NamespacedName

    /// <summary>
    /// The RequirementUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedRequirement"></see></summary>
    let definition_OwnedRequirement =
        Namespaced_IRI.parse _namespace_name "definition_OwnedRequirement" |> NamespacedName

    /// <summary>
    /// The StateUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedState"></see></summary>
    let definition_OwnedState =
        Namespaced_IRI.parse _namespace_name "definition_OwnedState" |> NamespacedName

    /// <summary>
    /// The TransitionUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedTransition"></see></summary>
    let definition_OwnedTransition =
        Namespaced_IRI.parse _namespace_name "definition_OwnedTransition" |> NamespacedName

    /// <summary>
    /// The Usages that are ownedFeatures of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedUsage"></see></summary>
    let definition_OwnedUsage =
        Namespaced_IRI.parse _namespace_name "definition_OwnedUsage" |> NamespacedName

    /// <summary>
    /// The UseCaseUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedUseCase"></see></summary>
    let definition_OwnedUseCase =
        Namespaced_IRI.parse _namespace_name "definition_OwnedUseCase" |> NamespacedName

    /// <summary>
    /// The VerificationCaseUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedVerificationCase"></see></summary>
    let definition_OwnedVerificationCase =
        Namespaced_IRI.parse _namespace_name "definition_OwnedVerificationCase" |> NamespacedName

    /// <summary>
    /// The ViewUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedView"></see></summary>
    let definition_OwnedView =
        Namespaced_IRI.parse _namespace_name "definition_OwnedView" |> NamespacedName

    /// <summary>
    /// The ViewpointUsages that are ownedUsages of this Definition.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_OwnedViewpoint"></see></summary>
    let definition_OwnedViewpoint =
        Namespaced_IRI.parse _namespace_name "definition_OwnedViewpoint" |> NamespacedName

    /// <summary>
    /// The Usages that are features of this Definition (not necessarily owned).
    /// <see href="http://open-services.net/ns/sysmlv2#definition_Usage"></see></summary>
    let definition_Usage =
        Namespaced_IRI.parse _namespace_name "definition_Usage" |> NamespacedName

    /// <summary>
    /// The Usages which represent the variants of this Definition as a variation point Definition, if isVariation = true. If isVariation = false, the there must be no variants.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_Variant"></see></summary>
    let definition_Variant =
        Namespaced_IRI.parse _namespace_name "definition_Variant" |> NamespacedName

    /// <summary>
    /// The ownedMemberships of this Definition that are VariantMemberships. If isVariation = true, then this must be all ownedMemberships of the Definition. If isVariation = false, then variantMembershipmust be empty.
    /// <see href="http://open-services.net/ns/sysmlv2#definition_VariantMembership"></see></summary>
    let definition_VariantMembership =
        Namespaced_IRI.parse _namespace_name "definition_VariantMembership" |> NamespacedName

    /// <summary>
    /// The Element or Elements dependent on the supplier Elements.
    /// <see href="http://open-services.net/ns/sysmlv2#dependency_Client"></see></summary>
    let dependency_Client =
        Namespaced_IRI.parse _namespace_name "dependency_Client" |> NamespacedName

    /// <summary>
    /// The Element or Elements on which the client Elements depend in some respect.
    /// <see href="http://open-services.net/ns/sysmlv2#dependency_Supplier"></see></summary>
    let dependency_Supplier =
        Namespaced_IRI.parse _namespace_name "dependency_Supplier" |> NamespacedName

    /// <summary>
    /// Type that partly determines interpretations of typeDifferenced, as described in Type::differencingType.
    /// <see href="http://open-services.net/ns/sysmlv2#differencing_DifferencingType"></see></summary>
    let differencing_DifferencingType =
        Namespaced_IRI.parse _namespace_name "differencing_DifferencingType" |> NamespacedName

    /// <summary>
    /// Type with interpretations partly determined by differencingType, as described in Type::differencingType.
    /// <see href="http://open-services.net/ns/sysmlv2#differencing_TypeDifferenced"></see></summary>
    let differencing_TypeDifferenced =
        Namespaced_IRI.parse _namespace_name "differencing_TypeDifferenced" |> NamespacedName

    /// <summary>
    /// Type asserted to be disjoint with the typeDisjoined.
    /// <see href="http://open-services.net/ns/sysmlv2#disjoining_DisjoiningType"></see></summary>
    let disjoining_DisjoiningType =
        Namespaced_IRI.parse _namespace_name "disjoining_DisjoiningType" |> NamespacedName

    /// <summary>
    /// A typeDisjoined that is also an owningRelatedElement.
    /// <see href="http://open-services.net/ns/sysmlv2#disjoining_OwningType"></see></summary>
    let disjoining_OwningType =
        Namespaced_IRI.parse _namespace_name "disjoining_OwningType" |> NamespacedName

    /// <summary>
    /// Type asserted to be disjoint with the disjoiningType.
    /// <see href="http://open-services.net/ns/sysmlv2#disjoining_TypeDisjoined"></see></summary>
    let disjoining_TypeDisjoined =
        Namespaced_IRI.parse _namespace_name "disjoining_TypeDisjoined" |> NamespacedName

    /// <summary>
    /// The Element that is documented by this Documentation.
    /// <see href="http://open-services.net/ns/sysmlv2#documentation_DocumentedElement"></see></summary>
    let documentation_DocumentedElement =
        Namespaced_IRI.parse _namespace_name "documentation_DocumentedElement" |> NamespacedName

    /// <summary>
    /// The model-level evaluable Boolean-valued Expression used to filter the imported members of the membershipOwningNamespace of this ElementFilterMembership.
    /// <see href="http://open-services.net/ns/sysmlv2#elementFilterMembership_Condition"></see></summary>
    let elementFilterMembership_Condition =
        Namespaced_IRI.parse _namespace_name "elementFilterMembership_Condition" |> NamespacedName

    /// <summary>
    /// Various alternative identifiers for this Element. Generally, these will be set by tools.
    /// <see href="http://open-services.net/ns/sysmlv2#element_AliasIds"></see></summary>
    let element_AliasIds =
        Namespaced_IRI.parse _namespace_name "element_AliasIds" |> NamespacedName

    /// <summary>
    /// The declared name of this Element.
    /// <see href="http://open-services.net/ns/sysmlv2#element_DeclaredName"></see></summary>
    let element_DeclaredName =
        Namespaced_IRI.parse _namespace_name "element_DeclaredName" |> NamespacedName

    /// <summary>
    /// An optional alternative name for the Element that is intended to be shorter or in some way more succinct than its primary name. It may act as a modeler-specified identifier for the Element, though it is then the responsibility of the modeler to maintain the uniqueness of this identifier within a model or relative to some other context.
    /// <see href="http://open-services.net/ns/sysmlv2#element_DeclaredShortName"></see></summary>
    let element_DeclaredShortName =
        Namespaced_IRI.parse _namespace_name "element_DeclaredShortName" |> NamespacedName

    /// <summary>
    /// The Documentation owned by this Element.
    /// <see href="http://open-services.net/ns/sysmlv2#element_Documentation"></see></summary>
    let element_Documentation =
        Namespaced_IRI.parse _namespace_name "element_Documentation" |> NamespacedName

    /// <summary>
    /// The globally unique identifier for this Element. This is intended to be set by tooling, and it must not change during the lifetime of the Element.
    /// <see href="http://open-services.net/ns/sysmlv2#element_ElementId"></see></summary>
    let element_ElementId =
        Namespaced_IRI.parse _namespace_name "element_ElementId" |> NamespacedName

    /// <summary>
    /// Whether all necessary implied Relationships have been included in the ownedRelationships of this Element. This property may be true, even if there are not actually any ownedRelationships with isImplied = true, meaning that no such Relationships are actually implied for this Element. However, if it is false, then ownedRelationships may not contain any implied Relationships. That is, either all required implied Relationships must be included, or none of them.
    /// <see href="http://open-services.net/ns/sysmlv2#element_IsImpliedIncluded"></see></summary>
    let element_IsImpliedIncluded =
        Namespaced_IRI.parse _namespace_name "element_IsImpliedIncluded" |> NamespacedName

    /// <summary>
    /// Whether this Element is contained in the ownership tree of a library model.
    /// <see href="http://open-services.net/ns/sysmlv2#element_IsLibraryElement"></see></summary>
    let element_IsLibraryElement =
        Namespaced_IRI.parse _namespace_name "element_IsLibraryElement" |> NamespacedName

    /// <summary>
    /// The name to be used for this Element during name resolution within its owningNamespace. This is derived using the effectiveName() operation. By default, it is the same as the declaredName, but this is overridden for certain kinds of Elements to compute a name even when the declaredName is null.
    /// <see href="http://open-services.net/ns/sysmlv2#element_Name"></see></summary>
    let element_Name =
        Namespaced_IRI.parse _namespace_name "element_Name" |> NamespacedName

    /// <summary>
    /// The ownedRelationships of this Element that are Annotations, for which this Element is the annotatedElement.
    /// <see href="http://open-services.net/ns/sysmlv2#element_OwnedAnnotation"></see></summary>
    let element_OwnedAnnotation =
        Namespaced_IRI.parse _namespace_name "element_OwnedAnnotation" |> NamespacedName

    /// <summary>
    /// The Elements owned by this Element, derived as the ownedRelatedElements of the ownedRelationships of this Element.
    /// <see href="http://open-services.net/ns/sysmlv2#element_OwnedElement"></see></summary>
    let element_OwnedElement =
        Namespaced_IRI.parse _namespace_name "element_OwnedElement" |> NamespacedName

    /// <summary>
    /// The Relationships for which this Element is the owningRelatedElement.
    /// <see href="http://open-services.net/ns/sysmlv2#element_OwnedRelationship"></see></summary>
    let element_OwnedRelationship =
        Namespaced_IRI.parse _namespace_name "element_OwnedRelationship" |> NamespacedName

    /// <summary>
    /// The owner of this Element, derived as the owningRelatedElement of the owningRelationship of this Element, if any.
    /// <see href="http://open-services.net/ns/sysmlv2#element_Owner"></see></summary>
    let element_Owner =
        Namespaced_IRI.parse _namespace_name "element_Owner" |> NamespacedName

    /// <summary>
    /// The owningRelationship of this Element, if that Relationship is a Membership.
    /// <see href="http://open-services.net/ns/sysmlv2#element_OwningMembership"></see></summary>
    let element_OwningMembership =
        Namespaced_IRI.parse _namespace_name "element_OwningMembership" |> NamespacedName

    /// <summary>
    /// The Namespace that owns this Element, which is the membershipOwningNamespace of the owningMembership of this Element, if any.
    /// <see href="http://open-services.net/ns/sysmlv2#element_OwningNamespace"></see></summary>
    let element_OwningNamespace =
        Namespaced_IRI.parse _namespace_name "element_OwningNamespace" |> NamespacedName

    /// <summary>
    /// The Relationship for which this Element is an ownedRelatedElement, if any.
    /// <see href="http://open-services.net/ns/sysmlv2#element_OwningRelationship"></see></summary>
    let element_OwningRelationship =
        Namespaced_IRI.parse _namespace_name "element_OwningRelationship" |> NamespacedName

    /// <summary>
    /// The full ownership-qualified name of this Element, represented in a form that is valid according to the KerML textual concrete syntax for qualified names (including use of unrestricted name notation and escaped characters, as necessary). The qualifiedName is null if this Element has no owningNamespace or if there is not a complete ownership chain of named Namespaces from a root Namespace to this Element.
    /// <see href="http://open-services.net/ns/sysmlv2#element_QualifiedName"></see></summary>
    let element_QualifiedName =
        Namespaced_IRI.parse _namespace_name "element_QualifiedName" |> NamespacedName

    /// <summary>
    /// The short name to be used for this Element during name resolution within its owningNamespace. This is derived using the effectiveShortName() operation. By default, it is the same as the declaredShortName, but this is overridden for certain kinds of Elements to compute a shortName even when the declaredName is null.
    /// <see href="http://open-services.net/ns/sysmlv2#element_ShortName"></see></summary>
    let element_ShortName =
        Namespaced_IRI.parse _namespace_name "element_ShortName" |> NamespacedName

    /// <summary>
    /// The TextualRepresentations that annotate this Element.
    /// <see href="http://open-services.net/ns/sysmlv2#element_TextualRepresentation"></see></summary>
    let element_TextualRepresentation =
        Namespaced_IRI.parse _namespace_name "element_TextualRepresentation" |> NamespacedName

    /// <summary>
    /// EnumerationUsages of this EnumerationDefinitionthat have distinct, fixed values. Each enumeratedValue specifies one of the allowed instances of the EnumerationDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#enumerationDefinition_EnumeratedValue"></see></summary>
    let enumerationDefinition_EnumeratedValue =
        Namespaced_IRI.parse _namespace_name "enumerationDefinition_EnumeratedValue" |> NamespacedName

    /// <summary>
    /// The single EnumerationDefinition that is the type of this EnumerationUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#enumerationUsage_EnumerationDefinition"></see></summary>
    let enumerationUsage_EnumerationDefinition =
        Namespaced_IRI.parse _namespace_name "enumerationUsage_EnumerationDefinition" |> NamespacedName

    /// <summary>
    /// The OccurrenceUsage referenced as an event by this EventOccurrenceUsage. It is the referenceFeature of the ownedReferenceSubsetting for the EventOccurrenceUsage, if there is one, and, otherwise, the EventOccurrenceUsage itself.
    /// <see href="http://open-services.net/ns/sysmlv2#eventOccurrenceUsage_EventOccurrence"></see></summary>
    let eventOccurrenceUsage_EventOccurrence =
        Namespaced_IRI.parse _namespace_name "eventOccurrenceUsage_EventOccurrence" |> NamespacedName

    /// <summary>
    /// The StateUsage to be exhibited by the ExhibitStateUsage. It is the performedAction of the ExhibitStateUsage considered as a PerformActionUsage, which must be a StateUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#exhibitStateUsage_ExhibitedState"></see></summary>
    let exhibitStateUsage_ExhibitedState =
        Namespaced_IRI.parse _namespace_name "exhibitStateUsage_ExhibitedState" |> NamespacedName

    /// <summary>
    /// The Function that types this Expression.
    /// <see href="http://open-services.net/ns/sysmlv2#expression_Function"></see></summary>
    let expression_Function =
        Namespaced_IRI.parse _namespace_name "expression_Function" |> NamespacedName

    /// <summary>
    /// Whether this Expression meets the constraints necessary to be evaluated at model level, that is, using metadata within the model.
    /// <see href="http://open-services.net/ns/sysmlv2#expression_IsModelLevelEvaluable"></see></summary>
    let expression_IsModelLevelEvaluable =
        Namespaced_IRI.parse _namespace_name "expression_IsModelLevelEvaluable" |> NamespacedName

    /// <summary>
    /// result.
    /// <see href="http://open-services.net/ns/sysmlv2#expression_Result"></see></summary>
    let expression_Result =
        Namespaced_IRI.parse _namespace_name "expression_Result" |> NamespacedName

    /// <summary>
    /// The Feature that is accessed by this FeatureChainExpression, which is its first non-parameter member.
    /// <see href="http://open-services.net/ns/sysmlv2#featureChainExpression_TargetFeature"></see></summary>
    let featureChainExpression_TargetFeature =
        Namespaced_IRI.parse _namespace_name "featureChainExpression_TargetFeature" |> NamespacedName

    /// <summary>
    /// The Feature whose values partly determine values of featureChained, as described in Feature::chainingFeature.
    /// <see href="http://open-services.net/ns/sysmlv2#featureChaining_ChainingFeature"></see></summary>
    let featureChaining_ChainingFeature =
        Namespaced_IRI.parse _namespace_name "featureChaining_ChainingFeature" |> NamespacedName

    /// <summary>
    /// The Feature whose values are partly determined by values of the chainingFeature, as described in Feature::chainingFeature.
    /// <see href="http://open-services.net/ns/sysmlv2#featureChaining_FeatureChained"></see></summary>
    let featureChaining_FeatureChained =
        Namespaced_IRI.parse _namespace_name "featureChaining_FeatureChained" |> NamespacedName

    /// <summary>
    /// Values of the Feature on each instance of its domain are determined externally to that instance and used internally.
    /// <see href="http://open-services.net/ns/sysmlv2#featureDirectionKind_In"></see></summary>
    let featureDirectionKind_In =
        Namespaced_IRI.parse _namespace_name "featureDirectionKind_In" |> NamespacedName

    /// <summary>
    /// Values of the Feature on each instance are determined either as in or out directions, or both.
    /// <see href="http://open-services.net/ns/sysmlv2#featureDirectionKind_Inout"></see></summary>
    let featureDirectionKind_Inout =
        Namespaced_IRI.parse _namespace_name "featureDirectionKind_Inout" |> NamespacedName

    /// <summary>
    /// Values of the Feature on each instance of its domain are determined internally to that instance and used externally.
    /// <see href="http://open-services.net/ns/sysmlv2#featureDirectionKind_Out"></see></summary>
    let featureDirectionKind_Out =
        Namespaced_IRI.parse _namespace_name "featureDirectionKind_Out" |> NamespacedName

    /// <summary>
    /// The Feature that is an inverse of the invertingFeature.
    /// <see href="http://open-services.net/ns/sysmlv2#featureInverting_FeatureInverted"></see></summary>
    let featureInverting_FeatureInverted =
        Namespaced_IRI.parse _namespace_name "featureInverting_FeatureInverted" |> NamespacedName

    /// <summary>
    /// The Feature that is an inverse of the invertedFeature.
    /// <see href="http://open-services.net/ns/sysmlv2#featureInverting_InvertingFeature"></see></summary>
    let featureInverting_InvertingFeature =
        Namespaced_IRI.parse _namespace_name "featureInverting_InvertingFeature" |> NamespacedName

    /// <summary>
    /// A featureInverted that is also the owningRelatedElement of this FeatureInverting.
    /// <see href="http://open-services.net/ns/sysmlv2#featureInverting_OwningFeature"></see></summary>
    let featureInverting_OwningFeature =
        Namespaced_IRI.parse _namespace_name "featureInverting_OwningFeature" |> NamespacedName

    /// <summary>
    /// The Feature that this FeatureMembership relates to its owningType, making it an ownedFeature of the owningType.
    /// <see href="http://open-services.net/ns/sysmlv2#featureMembership_OwnedMemberFeature"></see></summary>
    let featureMembership_OwnedMemberFeature =
        Namespaced_IRI.parse _namespace_name "featureMembership_OwnedMemberFeature" |> NamespacedName

    /// <summary>
    /// The Type that owns this FeatureMembership.
    /// <see href="http://open-services.net/ns/sysmlv2#featureMembership_OwningType"></see></summary>
    let featureMembership_OwningType =
        Namespaced_IRI.parse _namespace_name "featureMembership_OwningType" |> NamespacedName

    /// <summary>
    /// The Feature that is referenced by this FeatureReferenceExpression, which is its first non-parameter member.
    /// <see href="http://open-services.net/ns/sysmlv2#featureReferenceExpression_Referent"></see></summary>
    let featureReferenceExpression_Referent =
        Namespaced_IRI.parse _namespace_name "featureReferenceExpression_Referent" |> NamespacedName

    /// <summary>
    /// A typedFeature that is also the owningRelatedElement of this FeatureTyping.
    /// <see href="http://open-services.net/ns/sysmlv2#featureTyping_OwningFeature"></see></summary>
    let featureTyping_OwningFeature =
        Namespaced_IRI.parse _namespace_name "featureTyping_OwningFeature" |> NamespacedName

    /// <summary>
    /// The Type that is being applied by this FeatureTyping.
    /// <see href="http://open-services.net/ns/sysmlv2#featureTyping_Type"></see></summary>
    let featureTyping_Type =
        Namespaced_IRI.parse _namespace_name "featureTyping_Type" |> NamespacedName

    /// <summary>
    /// The Feature that has a type determined by this FeatureTyping.
    /// <see href="http://open-services.net/ns/sysmlv2#featureTyping_TypedFeature"></see></summary>
    let featureTyping_TypedFeature =
        Namespaced_IRI.parse _namespace_name "featureTyping_TypedFeature" |> NamespacedName

    /// <summary>
    /// The Feature to be provided a value.
    /// <see href="http://open-services.net/ns/sysmlv2#featureValue_FeatureWithValue"></see></summary>
    let featureValue_FeatureWithValue =
        Namespaced_IRI.parse _namespace_name "featureValue_FeatureWithValue" |> NamespacedName

    /// <summary>
    /// Whether this FeatureValue is a concrete specification of the bound or initial value of the featureWithValue, or just a default value that may be overridden.
    /// <see href="http://open-services.net/ns/sysmlv2#featureValue_IsDefault"></see></summary>
    let featureValue_IsDefault =
        Namespaced_IRI.parse _namespace_name "featureValue_IsDefault" |> NamespacedName

    /// <summary>
    /// Whether this FeatureValue specifies a bound value or an initial value for the featureWithValue.
    /// <see href="http://open-services.net/ns/sysmlv2#featureValue_IsInitial"></see></summary>
    let featureValue_IsInitial =
        Namespaced_IRI.parse _namespace_name "featureValue_IsInitial" |> NamespacedName

    /// <summary>
    /// The Expression that provides the value of the featureWithValue as its result.
    /// <see href="http://open-services.net/ns/sysmlv2#featureValue_Value"></see></summary>
    let featureValue_Value =
        Namespaced_IRI.parse _namespace_name "featureValue_Value" |> NamespacedName

    /// <summary>
    /// The Feature that are chained together to determine the values of this Feature, derived from the chainingFeatures of the ownedFeatureChainings of this Feature, in the same order. The values of a Feature with chainingFeatures are the same as values of the last Feature in the chain, which can be found by starting with the values of the first Feature (for each instance of the domain of the original Feature), then using each of those as domain instances to find the values of the second Feature in chainingFeatures, and so on, to values of the last Feature.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_ChainingFeature"></see></summary>
    let feature_ChainingFeature =
        Namespaced_IRI.parse _namespace_name "feature_ChainingFeature" |> NamespacedName

    /// <summary>
    /// Indicates how values of this Feature are determined or used (as specified for the FeatureDirectionKind).
    /// <see href="http://open-services.net/ns/sysmlv2#feature_Direction"></see></summary>
    let feature_Direction =
        Namespaced_IRI.parse _namespace_name "feature_Direction" |> NamespacedName

    /// <summary>
    /// The Type that is related to this Feature by an EndFeatureMembership in which the Feature is an ownedMemberFeature.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_EndOwningType"></see></summary>
    let feature_EndOwningType =
        Namespaced_IRI.parse _namespace_name "feature_EndOwningType" |> NamespacedName

    /// <summary>
    /// Types that feature this Feature, such that any instance in the domain of the Feature must be classified by all of these Types, including at least all the featuringTypes of its typeFeaturings.  If the Feature is chained, then the featuringTypes of the first Feature in the chain are also featuringTypes of the chained Feature.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_FeaturingType"></see></summary>
    let feature_FeaturingType =
        Namespaced_IRI.parse _namespace_name "feature_FeaturingType" |> NamespacedName

    /// <summary>
    /// Whether the Feature is a composite feature of its featuringType. If so, the values of the Feature cannot exist after its featuring instance no longer does.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_IsComposite"></see></summary>
    let feature_IsComposite =
        Namespaced_IRI.parse _namespace_name "feature_IsComposite" |> NamespacedName

    /// <summary>
    /// Whether the values of this Feature can always be computed from the values of other Features.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_IsDerived"></see></summary>
    let feature_IsDerived =
        Namespaced_IRI.parse _namespace_name "feature_IsDerived" |> NamespacedName

    /// <summary>
    /// Whether or not the this Feature is an end Feature, requiring a different interpretation of the multiplicity of the Feature.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_IsEnd"></see></summary>
    let feature_IsEnd =
        Namespaced_IRI.parse _namespace_name "feature_IsEnd" |> NamespacedName

    /// <summary>
    /// isNonunique.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_IsNonunique"></see></summary>
    let feature_IsNonunique =
        Namespaced_IRI.parse _namespace_name "feature_IsNonunique" |> NamespacedName

    /// <summary>
    /// Whether an order exists for the values of this Feature or not.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_IsOrdered"></see></summary>
    let feature_IsOrdered =
        Namespaced_IRI.parse _namespace_name "feature_IsOrdered" |> NamespacedName

    /// <summary>
    /// Whether the values of this Feature are contained in the space and time of instances of the domain of the Feature and represent the same thing as those instances.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_IsPortion"></see></summary>
    let feature_IsPortion =
        Namespaced_IRI.parse _namespace_name "feature_IsPortion" |> NamespacedName

    /// <summary>
    /// Whether the values of this Feature can change over the lifetime of an instance of the domain.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_IsReadOnly"></see></summary>
    let feature_IsReadOnly =
        Namespaced_IRI.parse _namespace_name "feature_IsReadOnly" |> NamespacedName

    /// <summary>
    /// Whether or not values for this Feature must have no duplicates or not.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_IsUnique"></see></summary>
    let feature_IsUnique =
        Namespaced_IRI.parse _namespace_name "feature_IsUnique" |> NamespacedName

    /// <summary>
    /// The ownedRelationships of this Feature that are FeatureChainings, for which the Feature will be the featureChained.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_OwnedFeatureChaining"></see></summary>
    let feature_OwnedFeatureChaining =
        Namespaced_IRI.parse _namespace_name "feature_OwnedFeatureChaining" |> NamespacedName

    /// <summary>
    /// The ownedRelationships of this Feature that are FeatureInvertings and for which the Feature is the featureInverted.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_OwnedFeatureInverting"></see></summary>
    let feature_OwnedFeatureInverting =
        Namespaced_IRI.parse _namespace_name "feature_OwnedFeatureInverting" |> NamespacedName

    /// <summary>
    /// The ownedSubsettings of this Feature that are Redefinitions, for which the Feature is the redefiningFeature.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_OwnedRedefinition"></see></summary>
    let feature_OwnedRedefinition =
        Namespaced_IRI.parse _namespace_name "feature_OwnedRedefinition" |> NamespacedName

    /// <summary>
    /// The one ownedSubsetting of this Feature, if any, that is a ReferenceSubsetting, for which the Feature is the referencingFeature.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_OwnedReferenceSubsetting"></see></summary>
    let feature_OwnedReferenceSubsetting =
        Namespaced_IRI.parse _namespace_name "feature_OwnedReferenceSubsetting" |> NamespacedName

    /// <summary>
    /// The ownedSpecializations of this Feature that are Subsettings, for which the Feature is the subsettingFeature.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_OwnedSubsetting"></see></summary>
    let feature_OwnedSubsetting =
        Namespaced_IRI.parse _namespace_name "feature_OwnedSubsetting" |> NamespacedName

    /// <summary>
    /// The ownedRelationships of this Feature that are TypeFeaturings and for which the Feature is the featureOfType.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_OwnedTypeFeaturing"></see></summary>
    let feature_OwnedTypeFeaturing =
        Namespaced_IRI.parse _namespace_name "feature_OwnedTypeFeaturing" |> NamespacedName

    /// <summary>
    /// The ownedSpecializations of this Feature that are FeatureTypings, for which the Feature is the typedFeature.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_OwnedTyping"></see></summary>
    let feature_OwnedTyping =
        Namespaced_IRI.parse _namespace_name "feature_OwnedTyping" |> NamespacedName

    /// <summary>
    /// The FeatureMembership that owns this Feature as an ownedMemberFeature, determining its owningType.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_OwningFeatureMembership"></see></summary>
    let feature_OwningFeatureMembership =
        Namespaced_IRI.parse _namespace_name "feature_OwningFeatureMembership" |> NamespacedName

    /// <summary>
    /// The Type that is the owningType of the owningFeatureMembership of this Feature.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_OwningType"></see></summary>
    let feature_OwningType =
        Namespaced_IRI.parse _namespace_name "feature_OwningType" |> NamespacedName

    /// <summary>
    /// Types that restrict the values of this Feature, such that the values must be instances of all the types. The types of a Feature are derived from its typings and the types of its subsettings. If the Feature is chained, then the types of the last Feature in the chain are also types of the chained Feature.
    /// <see href="http://open-services.net/ns/sysmlv2#feature_Type"></see></summary>
    let feature_Type =
        Namespaced_IRI.parse _namespace_name "feature_Type" |> NamespacedName

    /// <summary>
    /// The Feature that is featured by the featuringType.
    /// <see href="http://open-services.net/ns/sysmlv2#featuring_Feature"></see></summary>
    let featuring_Feature =
        Namespaced_IRI.parse _namespace_name "featuring_Feature" |> NamespacedName

    /// <summary>
    /// The Type that features the featureOfType.
    /// <see href="http://open-services.net/ns/sysmlv2#featuring_Type"></see></summary>
    let featuring_Type =
        Namespaced_IRI.parse _namespace_name "featuring_Type" |> NamespacedName

    /// <summary>
    /// The Interactions that are the types of this FlowConnectionUsage. Nominally, these are FlowConnectionDefinitions, but other kinds of Kernel Interactions are also allowed, to permit use of Interactions from the Kernel Model Libraries.
    /// <see href="http://open-services.net/ns/sysmlv2#flowConnectionUsage_FlowConnectionDefinition"></see></summary>
    let flowConnectionUsage_FlowConnectionDefinition =
        Namespaced_IRI.parse _namespace_name "flowConnectionUsage_FlowConnectionDefinition" |> NamespacedName

    /// <summary>
    /// The ownedFeature of this ForLoopActionUsage that acts as the loop variable, which is assigned the successive values of the input sequence on each iteration. It is the ownedFeature that redefines ForLoopAction::var.
    /// <see href="http://open-services.net/ns/sysmlv2#forLoopActionUsage_LoopVariable"></see></summary>
    let forLoopActionUsage_LoopVariable =
        Namespaced_IRI.parse _namespace_name "forLoopActionUsage_LoopVariable" |> NamespacedName

    /// <summary>
    /// The Expression whose result provides the sequence of values to which the loopVariable is set for each iterative performance of the bodyAction. It is the Expression whose result is bound to the seq input parameter of this ForLoopActionUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#forLoopActionUsage_SeqArgument"></see></summary>
    let forLoopActionUsage_SeqArgument =
        Namespaced_IRI.parse _namespace_name "forLoopActionUsage_SeqArgument" |> NamespacedName

    /// <summary>
    /// The ConcernUsage that is the ownedConstraint of this FramedConcernMembership.
    /// <see href="http://open-services.net/ns/sysmlv2#framedConcernMembership_OwnedConcern"></see></summary>
    let framedConcernMembership_OwnedConcern =
        Namespaced_IRI.parse _namespace_name "framedConcernMembership_OwnedConcern" |> NamespacedName

    /// <summary>
    ///  The ConcernUsage that is referenced through this FramedConcernMembership. It is the referencedConstraint of the FramedConcernMembership considered as a RequirementConstraintMembership, which must be a ConcernUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#framedConcernMembership_ReferencedConcern"></see></summary>
    let framedConcernMembership_ReferencedConcern =
        Namespaced_IRI.parse _namespace_name "framedConcernMembership_ReferencedConcern" |> NamespacedName

    /// <summary>
    /// The Expressions that are steps in the calculation of the result of this Function.
    /// <see href="http://open-services.net/ns/sysmlv2#function_Expression"></see></summary>
    let function_Expression =
        Namespaced_IRI.parse _namespace_name "function_Expression" |> NamespacedName

    /// <summary>
    /// Whether this Function can be used as the function of a model-level evaluable InvocationExpression. Certain Functions from the Kernel Functions Library are considered to have isModelLevelEvaluable = true. For all other Functions it is false.
    /// <see href="http://open-services.net/ns/sysmlv2#function_IsModelLevelEvaluable"></see></summary>
    let function_IsModelLevelEvaluable =
        Namespaced_IRI.parse _namespace_name "function_IsModelLevelEvaluable" |> NamespacedName

    /// <summary>
    /// The result parameter of the Function, which is owned by the Function via a ReturnParameterMembership.
    /// <see href="http://open-services.net/ns/sysmlv2#function_Result"></see></summary>
    let function_Result =
        Namespaced_IRI.parse _namespace_name "function_Result" |> NamespacedName

    /// <summary>
    /// The ActionUsage that is to be performed if the result of the ifArgument is false. It is the (optional) third parameter of the IfActionUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#ifActionUsage_ElseAction"></see></summary>
    let ifActionUsage_ElseAction =
        Namespaced_IRI.parse _namespace_name "ifActionUsage_ElseAction" |> NamespacedName

    /// <summary>
    /// The Expression whose result determines whether the thenAction or (optionally) the elseAction is performed. It is the first parameter of the IfActionUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#ifActionUsage_IfArgument"></see></summary>
    let ifActionUsage_IfArgument =
        Namespaced_IRI.parse _namespace_name "ifActionUsage_IfArgument" |> NamespacedName

    /// <summary>
    /// The ActionUsage that is to be performed if the result of the ifArgument is true. It is the second parameter of the IfActionUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#ifActionUsage_ThenAction"></see></summary>
    let ifActionUsage_ThenAction =
        Namespaced_IRI.parse _namespace_name "ifActionUsage_ThenAction" |> NamespacedName

    /// <summary>
    /// The Namespace into which Memberships are imported by this Import, which must be the owningRelatedElement of the Import.
    /// <see href="http://open-services.net/ns/sysmlv2#import_ImportOwningNamespace"></see></summary>
    let import_ImportOwningNamespace =
        Namespaced_IRI.parse _namespace_name "import_ImportOwningNamespace" |> NamespacedName

    /// <summary>
    /// The effectively imported Element for this Import. For a MembershipImport, this is the memberElement of the importedMembership. For a NamespaceImport, it is the importedNamespace.
    /// <see href="http://open-services.net/ns/sysmlv2#import_ImportedElement"></see></summary>
    let import_ImportedElement =
        Namespaced_IRI.parse _namespace_name "import_ImportedElement" |> NamespacedName

    /// <summary>
    /// Whether to import memberships without regard to declared visibility.
    /// <see href="http://open-services.net/ns/sysmlv2#import_IsImportAll"></see></summary>
    let import_IsImportAll =
        Namespaced_IRI.parse _namespace_name "import_IsImportAll" |> NamespacedName

    /// <summary>
    /// Whether to recursively import Memberships from visible, owned sub-Namespaces.
    /// <see href="http://open-services.net/ns/sysmlv2#import_IsRecursive"></see></summary>
    let import_IsRecursive =
        Namespaced_IRI.parse _namespace_name "import_IsRecursive" |> NamespacedName

    /// <summary>
    /// The visibility level of the imported members from this Import relative to the importOwningNamespace.
    /// <see href="http://open-services.net/ns/sysmlv2#import_Visibility"></see></summary>
    let import_Visibility =
        Namespaced_IRI.parse _namespace_name "import_Visibility" |> NamespacedName

    /// <summary>
    /// The UseCaseUsage to be included by this IncludeUseCaseUsage. It is the performedAction of the IncludeUseCaseUsage considered as a PerformActionUsage, which must be a UseCaseUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#includeUseCaseUsage_UseCaseIncluded"></see></summary>
    let includeUseCaseUsage_UseCaseIncluded =
        Namespaced_IRI.parse _namespace_name "includeUseCaseUsage_UseCaseIncluded" |> NamespacedName

    /// <summary>
    /// The PortUsages that are the connectionEnds of this InterfaceDefinition.
    ///
    /// .
    /// <see href="http://open-services.net/ns/sysmlv2#interfaceDefinition_InterfaceEnd"></see></summary>
    let interfaceDefinition_InterfaceEnd =
        Namespaced_IRI.parse _namespace_name "interfaceDefinition_InterfaceEnd" |> NamespacedName

    /// <summary>
    /// The InterfaceDefinitions that type this InterfaceUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#interfaceUsage_InterfaceDefinition"></see></summary>
    let interfaceUsage_InterfaceDefinition =
        Namespaced_IRI.parse _namespace_name "interfaceUsage_InterfaceDefinition" |> NamespacedName

    /// <summary>
    /// Type that partly determines interpretations of typeIntersected, as described in Type::intersectingType.
    /// <see href="http://open-services.net/ns/sysmlv2#intersecting_IntersectingType"></see></summary>
    let intersecting_IntersectingType =
        Namespaced_IRI.parse _namespace_name "intersecting_IntersectingType" |> NamespacedName

    /// <summary>
    /// Type with interpretations partly determined by intersectingType, as described in Type::intersectingType.
    /// <see href="http://open-services.net/ns/sysmlv2#intersecting_TypeIntersected"></see></summary>
    let intersecting_TypeIntersected =
        Namespaced_IRI.parse _namespace_name "intersecting_TypeIntersected" |> NamespacedName

    /// <summary>
    /// Whether this Invariant is asserted to be false rather than true.
    /// <see href="http://open-services.net/ns/sysmlv2#invariant_IsNegated"></see></summary>
    let invariant_IsNegated =
        Namespaced_IRI.parse _namespace_name "invariant_IsNegated" |> NamespacedName

    /// <summary>
    /// The value Expressions of the FeatureValues of the owned input parameters of the InvocationExpression.
    /// <see href="http://open-services.net/ns/sysmlv2#invocationExpression_Argument"></see></summary>
    let invocationExpression_Argument =
        Namespaced_IRI.parse _namespace_name "invocationExpression_Argument" |> NamespacedName

    /// <summary>
    /// operand.
    /// <see href="http://open-services.net/ns/sysmlv2#invocationExpression_Operand"></see></summary>
    let invocationExpression_Operand =
        Namespaced_IRI.parse _namespace_name "invocationExpression_Operand" |> NamespacedName

    /// <summary>
    /// The Interactions that type this ItemFlow. Interactions are both Associations and Behaviors, which can type Connectors and Steps, respectively.
    /// <see href="http://open-services.net/ns/sysmlv2#itemFlow_Interaction"></see></summary>
    let itemFlow_Interaction =
        Namespaced_IRI.parse _namespace_name "itemFlow_Interaction" |> NamespacedName

    /// <summary>
    /// The ownedFeature of the ItemFlow that is an ItemFeature (if any).
    /// <see href="http://open-services.net/ns/sysmlv2#itemFlow_ItemFeature"></see></summary>
    let itemFlow_ItemFeature =
        Namespaced_IRI.parse _namespace_name "itemFlow_ItemFeature" |> NamespacedName

    /// <summary>
    /// The connectorEnds of this ItemFlow that are ItemFlowEnds.
    /// <see href="http://open-services.net/ns/sysmlv2#itemFlow_ItemFlowEnd"></see></summary>
    let itemFlow_ItemFlowEnd =
        Namespaced_IRI.parse _namespace_name "itemFlow_ItemFlowEnd" |> NamespacedName

    /// <summary>
    /// The type of values transferred, which is the type of the itemFeature of the ItemFlow.
    /// <see href="http://open-services.net/ns/sysmlv2#itemFlow_ItemType"></see></summary>
    let itemFlow_ItemType =
        Namespaced_IRI.parse _namespace_name "itemFlow_ItemType" |> NamespacedName

    /// <summary>
    /// The Feature that provides the items carried by the ItemFlow. It must be an owned output of the source of the ItemFlow.
    /// <see href="http://open-services.net/ns/sysmlv2#itemFlow_SourceOutputFeature"></see></summary>
    let itemFlow_SourceOutputFeature =
        Namespaced_IRI.parse _namespace_name "itemFlow_SourceOutputFeature" |> NamespacedName

    /// <summary>
    /// The Feature that receives the values carried by the ItemFlow. It must be an owned output of the target participant of the ItemFlow.
    /// <see href="http://open-services.net/ns/sysmlv2#itemFlow_TargetInputFeature"></see></summary>
    let itemFlow_TargetInputFeature =
        Namespaced_IRI.parse _namespace_name "itemFlow_TargetInputFeature" |> NamespacedName

    /// <summary>
    /// The Structures that are the definitions of this ItemUsage. Nominally, these are ItemDefinitions, but other kinds of Kernel Structures are also allowed, to permit use of Structures from the Kernel Library.
    /// <see href="http://open-services.net/ns/sysmlv2#itemUsage_ItemDefinition"></see></summary>
    let itemUsage_ItemDefinition =
        Namespaced_IRI.parse _namespace_name "itemUsage_ItemDefinition" |> NamespacedName

    /// <summary>
    /// Whether this LibraryPackage contains a standard library model. This should only be set to true for LibraryPackages in the standard Kernel Model Libraries or in normative model libraries for a language built on KerML.
    /// <see href="http://open-services.net/ns/sysmlv2#libraryPackage_IsStandard"></see></summary>
    let libraryPackage_IsStandard =
        Namespaced_IRI.parse _namespace_name "libraryPackage_IsStandard" |> NamespacedName

    /// <summary>
    /// The Boolean value that is the result of evaluating this LiteralBoolean.
    /// <see href="http://open-services.net/ns/sysmlv2#literalBoolean_Value"></see></summary>
    let literalBoolean_Value =
        Namespaced_IRI.parse _namespace_name "literalBoolean_Value" |> NamespacedName

    /// <summary>
    /// The Integer value that is the result of evaluating this LiteralInteger.
    /// <see href="http://open-services.net/ns/sysmlv2#literalInteger_Value"></see></summary>
    let literalInteger_Value =
        Namespaced_IRI.parse _namespace_name "literalInteger_Value" |> NamespacedName

    /// <summary>
    /// The value whose rational approximation is the result of evaluating this LiteralRational.
    /// <see href="http://open-services.net/ns/sysmlv2#literalRational_Value"></see></summary>
    let literalRational_Value =
        Namespaced_IRI.parse _namespace_name "literalRational_Value" |> NamespacedName

    /// <summary>
    /// The String value that is the result of evaluating this LiteralString.
    /// <see href="http://open-services.net/ns/sysmlv2#literalString_Value"></see></summary>
    let literalString_Value =
        Namespaced_IRI.parse _namespace_name "literalString_Value" |> NamespacedName

    /// <summary>
    /// The ActionUsage to be performed repeatedly by the LoopActionUsage. It is the second parameter of the LoopActionUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#loopActionUsage_BodyAction"></see></summary>
    let loopActionUsage_BodyAction =
        Namespaced_IRI.parse _namespace_name "loopActionUsage_BodyAction" |> NamespacedName

    /// <summary>
    /// The Membership to be imported.
    /// <see href="http://open-services.net/ns/sysmlv2#membershipImport_ImportedMembership"></see></summary>
    let membershipImport_ImportedMembership =
        Namespaced_IRI.parse _namespace_name "membershipImport_ImportedMembership" |> NamespacedName

    /// <summary>
    /// The Element that becomes a member of the membershipOwningNamespace due to this Membership.
    /// <see href="http://open-services.net/ns/sysmlv2#membership_MemberElement"></see></summary>
    let membership_MemberElement =
        Namespaced_IRI.parse _namespace_name "membership_MemberElement" |> NamespacedName

    /// <summary>
    /// The elementId of the memberElement.
    /// <see href="http://open-services.net/ns/sysmlv2#membership_MemberElementId"></see></summary>
    let membership_MemberElementId =
        Namespaced_IRI.parse _namespace_name "membership_MemberElementId" |> NamespacedName

    /// <summary>
    /// The name of the memberElement relative to the membershipOwningNamespace.
    /// <see href="http://open-services.net/ns/sysmlv2#membership_MemberName"></see></summary>
    let membership_MemberName =
        Namespaced_IRI.parse _namespace_name "membership_MemberName" |> NamespacedName

    /// <summary>
    /// The short name of the memberElement relative to the membershipOwningNamespace.
    /// <see href="http://open-services.net/ns/sysmlv2#membership_MemberShortName"></see></summary>
    let membership_MemberShortName =
        Namespaced_IRI.parse _namespace_name "membership_MemberShortName" |> NamespacedName

    /// <summary>
    /// The Namespace of which the memberElement becomes a member due to this Membership.
    /// <see href="http://open-services.net/ns/sysmlv2#membership_MembershipOwningNamespace"></see></summary>
    let membership_MembershipOwningNamespace =
        Namespaced_IRI.parse _namespace_name "membership_MembershipOwningNamespace" |> NamespacedName

    /// <summary>
    /// Whether or not the Membership of the memberElement in the membershipOwningNamespace is publicly visible outside that Namespace.
    /// <see href="http://open-services.net/ns/sysmlv2#membership_Visibility"></see></summary>
    let membership_Visibility =
        Namespaced_IRI.parse _namespace_name "membership_Visibility" |> NamespacedName

    /// <summary>
    ///  The Element whose metadata is being accessed.
    /// <see href="http://open-services.net/ns/sysmlv2#metadataAccessExpression_ReferencedElement"></see></summary>
    let metadataAccessExpression_ReferencedElement =
        Namespaced_IRI.parse _namespace_name "metadataAccessExpression_ReferencedElement" |> NamespacedName

    /// <summary>
    /// The type of this MetadataFeature, which must be a Metaclass.
    /// <see href="http://open-services.net/ns/sysmlv2#metadataFeature_Metaclass"></see></summary>
    let metadataFeature_Metaclass =
        Namespaced_IRI.parse _namespace_name "metadataFeature_Metaclass" |> NamespacedName

    /// <summary>
    /// The MetadataDefinition that is the definition of this MetadataUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#metadataUsage_MetadataDefinition"></see></summary>
    let metadataUsage_MetadataDefinition =
        Namespaced_IRI.parse _namespace_name "metadataUsage_MetadataDefinition" |> NamespacedName

    /// <summary>
    /// The owned Expressions of the MultiplicityRange whose results provide its bounds. These must be the only ownedMembers of the MultiplicityRange.
    /// <see href="http://open-services.net/ns/sysmlv2#multiplicityRange_Bound"></see></summary>
    let multiplicityRange_Bound =
        Namespaced_IRI.parse _namespace_name "multiplicityRange_Bound" |> NamespacedName

    /// <summary>
    /// The Expression whose result provides the lower bound of the MultiplicityRange. If no lowerBound Expression is given, then the lower bound shall have the same value as the upper bound, unless the upper bound is unbounded (*), in which case the lower bound shall be 0.
    /// <see href="http://open-services.net/ns/sysmlv2#multiplicityRange_LowerBound"></see></summary>
    let multiplicityRange_LowerBound =
        Namespaced_IRI.parse _namespace_name "multiplicityRange_LowerBound" |> NamespacedName

    /// <summary>
    /// The Expression whose result is the upper bound of the MultiplicityRange.
    /// <see href="http://open-services.net/ns/sysmlv2#multiplicityRange_UpperBound"></see></summary>
    let multiplicityRange_UpperBound =
        Namespaced_IRI.parse _namespace_name "multiplicityRange_UpperBound" |> NamespacedName

    /// <summary>
    /// The Namespace whose visible Memberships are imported by this NamespaceImport.
    /// <see href="http://open-services.net/ns/sysmlv2#namespaceImport_ImportedNamespace"></see></summary>
    let namespaceImport_ImportedNamespace =
        Namespaced_IRI.parse _namespace_name "namespaceImport_ImportedNamespace" |> NamespacedName

    /// <summary>
    /// The Memberships in this Namespace that result from the ownedImports of this Namespace.
    /// <see href="http://open-services.net/ns/sysmlv2#namespace_ImportedMembership"></see></summary>
    let namespace_ImportedMembership =
        Namespaced_IRI.parse _namespace_name "namespace_ImportedMembership" |> NamespacedName

    /// <summary>
    /// The set of all member Elements of this Namespace, which are the memberElements of all memberships of the Namespace.
    /// <see href="http://open-services.net/ns/sysmlv2#namespace_Member"></see></summary>
    let namespace_Member =
        Namespaced_IRI.parse _namespace_name "namespace_Member" |> NamespacedName

    /// <summary>
    /// All Memberships in this Namespace, including (at least) the union of ownedMemberships and importedMemberships.
    /// <see href="http://open-services.net/ns/sysmlv2#namespace_Membership"></see></summary>
    let namespace_Membership =
        Namespaced_IRI.parse _namespace_name "namespace_Membership" |> NamespacedName

    /// <summary>
    /// The ownedRelationships of this Namespace that are Imports, for which the Namespace is the importOwningNamespace.
    /// <see href="http://open-services.net/ns/sysmlv2#namespace_OwnedImport"></see></summary>
    let namespace_OwnedImport =
        Namespaced_IRI.parse _namespace_name "namespace_OwnedImport" |> NamespacedName

    /// <summary>
    /// The owned members of this Namespace, which are the ownedMemberElements of the ownedMemberships of the .
    /// <see href="http://open-services.net/ns/sysmlv2#namespace_OwnedMember"></see></summary>
    let namespace_OwnedMember =
        Namespaced_IRI.parse _namespace_name "namespace_OwnedMember" |> NamespacedName

    /// <summary>
    /// The ownedRelationships of this Namespace that are Memberships, for which the Namespace is the membershipOwningNamespace.
    /// <see href="http://open-services.net/ns/sysmlv2#namespace_OwnedMembership"></see></summary>
    let namespace_OwnedMembership =
        Namespaced_IRI.parse _namespace_name "namespace_OwnedMembership" |> NamespacedName

    /// <summary>
    /// The RequirementUsage that is the ownedMemberFeature of this RequirementUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#objectiveMembership_OwnedObjectiveRequirement"></see></summary>
    let objectiveMembership_OwnedObjectiveRequirement =
        Namespaced_IRI.parse _namespace_name "objectiveMembership_OwnedObjectiveRequirement" |> NamespacedName

    /// <summary>
    /// Whether this OccurrenceDefinition is constrained to represent single individual.
    /// <see href="http://open-services.net/ns/sysmlv2#occurrenceDefinition_IsIndividual"></see></summary>
    let occurrenceDefinition_IsIndividual =
        Namespaced_IRI.parse _namespace_name "occurrenceDefinition_IsIndividual" |> NamespacedName

    /// <summary>
    /// If isIndividual is true, a LifeClass that specializes this OccurrenceDefinition, restricting it to represent an individual.
    /// <see href="http://open-services.net/ns/sysmlv2#occurrenceDefinition_LifeClass"></see></summary>
    let occurrenceDefinition_LifeClass =
        Namespaced_IRI.parse _namespace_name "occurrenceDefinition_LifeClass" |> NamespacedName

    /// <summary>
    /// The at most one occurrenceDefinition that has isIndividual = true.
    /// <see href="http://open-services.net/ns/sysmlv2#occurrenceUsage_IndividualDefinition"></see></summary>
    let occurrenceUsage_IndividualDefinition =
        Namespaced_IRI.parse _namespace_name "occurrenceUsage_IndividualDefinition" |> NamespacedName

    /// <summary>
    /// Whether this OccurrenceUsage represents the usage of the specific individual (or portion of it) represented by its individualDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#occurrenceUsage_IsIndividual"></see></summary>
    let occurrenceUsage_IsIndividual =
        Namespaced_IRI.parse _namespace_name "occurrenceUsage_IsIndividual" |> NamespacedName

    /// <summary>
    /// The Classes that are the types of this OccurrenceUsage. Nominally, these are OccurrenceDefinitions, but other kinds of kernel Classes are also allowed, to permit use of Classes from the Kernel Model Libraries.
    /// <see href="http://open-services.net/ns/sysmlv2#occurrenceUsage_OccurrenceDefinition"></see></summary>
    let occurrenceUsage_OccurrenceDefinition =
        Namespaced_IRI.parse _namespace_name "occurrenceUsage_OccurrenceDefinition" |> NamespacedName

    /// <summary>
    /// The kind of (temporal) portion of the life of the occurrenceDefinition represented by this OccurrenceUsage, if it is so restricted.
    /// <see href="http://open-services.net/ns/sysmlv2#occurrenceUsage_PortionKind"></see></summary>
    let occurrenceUsage_PortionKind =
        Namespaced_IRI.parse _namespace_name "occurrenceUsage_PortionKind" |> NamespacedName

    /// <summary>
    /// An operator symbol that names a corresponding Function from one of the standard packages from the Kernel Function Library .
    /// <see href="http://open-services.net/ns/sysmlv2#operatorExpression_Operator"></see></summary>
    let operatorExpression_Operator =
        Namespaced_IRI.parse _namespace_name "operatorExpression_Operator" |> NamespacedName

    /// <summary>
    /// The Element that becomes an ownedMember of the membershipOwningNamespace due to this OwningMembership.
    /// <see href="http://open-services.net/ns/sysmlv2#owningMembership_OwnedMemberElement"></see></summary>
    let owningMembership_OwnedMemberElement =
        Namespaced_IRI.parse _namespace_name "owningMembership_OwnedMemberElement" |> NamespacedName

    /// <summary>
    /// The elementId of the ownedMemberElement.
    /// <see href="http://open-services.net/ns/sysmlv2#owningMembership_OwnedMemberElementId"></see></summary>
    let owningMembership_OwnedMemberElementId =
        Namespaced_IRI.parse _namespace_name "owningMembership_OwnedMemberElementId" |> NamespacedName

    /// <summary>
    /// The name of the ownedMemberElement.
    /// <see href="http://open-services.net/ns/sysmlv2#owningMembership_OwnedMemberName"></see></summary>
    let owningMembership_OwnedMemberName =
        Namespaced_IRI.parse _namespace_name "owningMembership_OwnedMemberName" |> NamespacedName

    /// <summary>
    /// The shortName of the ownedMemberElement.
    /// <see href="http://open-services.net/ns/sysmlv2#owningMembership_OwnedMemberShortName"></see></summary>
    let owningMembership_OwnedMemberShortName =
        Namespaced_IRI.parse _namespace_name "owningMembership_OwnedMemberShortName" |> NamespacedName

    /// <summary>
    /// The model-level evaluable Boolean-valued Expression used to filter the members of this Package, which are owned by the Package are via ElementFilterMemberships.
    /// <see href="http://open-services.net/ns/sysmlv2#package_FilterCondition"></see></summary>
    let package_FilterCondition =
        Namespaced_IRI.parse _namespace_name "package_FilterCondition" |> NamespacedName

    /// <summary>
    /// The Feature that is identified as a parameter by this ParameterMembership.
    /// <see href="http://open-services.net/ns/sysmlv2#parameterMembership_OwnedMemberParameter"></see></summary>
    let parameterMembership_OwnedMemberParameter =
        Namespaced_IRI.parse _namespace_name "parameterMembership_OwnedMemberParameter" |> NamespacedName

    /// <summary>
    /// The itemDefinitions of this PartUsage that are PartDefinitions.
    /// <see href="http://open-services.net/ns/sysmlv2#partUsage_PartDefinition"></see></summary>
    let partUsage_PartDefinition =
        Namespaced_IRI.parse _namespace_name "partUsage_PartDefinition" |> NamespacedName

    /// <summary>
    /// The ActionUsage to be performed by this PerformedActionUsage. It is the eventOccurrence of the PerformActionUsage considered as an EventOccurrenceUsage, which must be an ActionUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#performActionUsage_PerformedAction"></see></summary>
    let performActionUsage_PerformedAction =
        Namespaced_IRI.parse _namespace_name "performActionUsage_PerformedAction" |> NamespacedName

    /// <summary>
    /// The ConjugatedPortDefinition that is conjugate to the originalPortDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#portConjugation_ConjugatedPortDefinition"></see></summary>
    let portConjugation_ConjugatedPortDefinition =
        Namespaced_IRI.parse _namespace_name "portConjugation_ConjugatedPortDefinition" |> NamespacedName

    /// <summary>
    /// The PortDefinition being conjugated.
    /// <see href="http://open-services.net/ns/sysmlv2#portConjugation_OriginalPortDefinition"></see></summary>
    let portConjugation_OriginalPortDefinition =
        Namespaced_IRI.parse _namespace_name "portConjugation_OriginalPortDefinition" |> NamespacedName

    /// <summary>
    /// The  that is conjugate to this PortDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#portDefinition_ConjugatedPortDefinition"></see></summary>
    let portDefinition_ConjugatedPortDefinition =
        Namespaced_IRI.parse _namespace_name "portDefinition_ConjugatedPortDefinition" |> NamespacedName

    /// <summary>
    /// The occurrenceDefinitions of this PortUsage, which must all be PortDefinitions.
    /// <see href="http://open-services.net/ns/sysmlv2#portUsage_PortDefinition"></see></summary>
    let portUsage_PortDefinition =
        Namespaced_IRI.parse _namespace_name "portUsage_PortDefinition" |> NamespacedName

    /// <summary>
    /// A snapshot of an Occurrence (a time slice with zero duration).
    /// <see href="http://open-services.net/ns/sysmlv2#portionKind_Snapshot"></see></summary>
    let portionKind_Snapshot =
        Namespaced_IRI.parse _namespace_name "portionKind_Snapshot" |> NamespacedName

    /// <summary>
    /// A time slice of an Occurrence (a portion over time).
    /// <see href="http://open-services.net/ns/sysmlv2#portionKind_Timeslice"></see></summary>
    let portionKind_Timeslice =
        Namespaced_IRI.parse _namespace_name "portionKind_Timeslice" |> NamespacedName

    /// <summary>
    /// The Feature that is redefined by the redefiningFeature of this Redefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#redefinition_RedefinedFeature"></see></summary>
    let redefinition_RedefinedFeature =
        Namespaced_IRI.parse _namespace_name "redefinition_RedefinedFeature" |> NamespacedName

    /// <summary>
    /// The Feature that is redefining the redefinedFeature of this Redefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#redefinition_RedefiningFeature"></see></summary>
    let redefinition_RedefiningFeature =
        Namespaced_IRI.parse _namespace_name "redefinition_RedefiningFeature" |> NamespacedName

    /// <summary>
    /// The Feature that is referenced by the referencingFeature of this ReferenceSubsetting.
    /// <see href="http://open-services.net/ns/sysmlv2#referenceSubsetting_ReferencedFeature"></see></summary>
    let referenceSubsetting_ReferencedFeature =
        Namespaced_IRI.parse _namespace_name "referenceSubsetting_ReferencedFeature" |> NamespacedName

    /// <summary>
    /// The Feature that owns this ReferenceSubsetting relationship, which is also its subsettingFeature.
    /// <see href="http://open-services.net/ns/sysmlv2#referenceSubsetting_ReferencingFeature"></see></summary>
    let referenceSubsetting_ReferencingFeature =
        Namespaced_IRI.parse _namespace_name "referenceSubsetting_ReferencingFeature" |> NamespacedName

    /// <summary>
    /// Whether this Relationship was generated by tooling to meet semantic rules, rather than being directly created by a modeler.
    /// <see href="http://open-services.net/ns/sysmlv2#relationship_IsImplied"></see></summary>
    let relationship_IsImplied =
        Namespaced_IRI.parse _namespace_name "relationship_IsImplied" |> NamespacedName

    /// <summary>
    /// The relatedElements of this Relationship that are owned by the Relationship.
    /// <see href="http://open-services.net/ns/sysmlv2#relationship_OwnedRelatedElement"></see></summary>
    let relationship_OwnedRelatedElement =
        Namespaced_IRI.parse _namespace_name "relationship_OwnedRelatedElement" |> NamespacedName

    /// <summary>
    /// The relatedElement of this Relationship that owns the Relationship, if any.
    /// <see href="http://open-services.net/ns/sysmlv2#relationship_OwningRelatedElement"></see></summary>
    let relationship_OwningRelatedElement =
        Namespaced_IRI.parse _namespace_name "relationship_OwningRelatedElement" |> NamespacedName

    /// <summary>
    /// The Elements that are related by this Relationship, derived as the union of the source and target Elements of the Relationship.
    /// <see href="http://open-services.net/ns/sysmlv2#relationship_RelatedElement"></see></summary>
    let relationship_RelatedElement =
        Namespaced_IRI.parse _namespace_name "relationship_RelatedElement" |> NamespacedName

    /// <summary>
    /// The relatedElements from which this Relationship is considered to be directed.
    /// <see href="http://open-services.net/ns/sysmlv2#relationship_Source"></see></summary>
    let relationship_Source =
        Namespaced_IRI.parse _namespace_name "relationship_Source" |> NamespacedName

    /// <summary>
    /// The relatedElements to which this Relationship is considered to be directed.
    /// <see href="http://open-services.net/ns/sysmlv2#relationship_Target"></see></summary>
    let relationship_Target =
        Namespaced_IRI.parse _namespace_name "relationship_Target" |> NamespacedName

    /// <summary>
    /// The usages of a RenderingDefinition that are RenderingUsages.
    /// <see href="http://open-services.net/ns/sysmlv2#renderingDefinition_Rendering"></see></summary>
    let renderingDefinition_Rendering =
        Namespaced_IRI.parse _namespace_name "renderingDefinition_Rendering" |> NamespacedName

    /// <summary>
    /// The RenderingDefinition that is the definition of this RenderingUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#renderingUsage_RenderingDefinition"></see></summary>
    let renderingUsage_RenderingDefinition =
        Namespaced_IRI.parse _namespace_name "renderingUsage_RenderingDefinition" |> NamespacedName

    /// <summary>
    /// Indicates that a member ConstraintUsage of a RequirementDefinition or RequirementUsage represents an assumption.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementConstraintKind_Assumption"></see></summary>
    let requirementConstraintKind_Assumption =
        Namespaced_IRI.parse _namespace_name "requirementConstraintKind_Assumption" |> NamespacedName

    /// <summary>
    /// Indicates that a member ConstraintUsage of a RequirementDefinition or RequirementUsagerepresents an requirement.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementConstraintKind_Requirement"></see></summary>
    let requirementConstraintKind_Requirement =
        Namespaced_IRI.parse _namespace_name "requirementConstraintKind_Requirement" |> NamespacedName

    /// <summary>
    /// Whether the RequirementConstraintMembership is for an assumed or required ConstraintUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementConstraintMembership_Kind"></see></summary>
    let requirementConstraintMembership_Kind =
        Namespaced_IRI.parse _namespace_name "requirementConstraintMembership_Kind" |> NamespacedName

    /// <summary>
    /// The ConstraintUsage that is the ownedMemberFeature of this RequirementConstraintMembership.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementConstraintMembership_OwnedConstraint"></see></summary>
    let requirementConstraintMembership_OwnedConstraint =
        Namespaced_IRI.parse _namespace_name "requirementConstraintMembership_OwnedConstraint" |> NamespacedName

    /// <summary>
    ///  The ConstraintUsage that is referenced through this RequirementConstraintMembership. It is the referencedFeature of the ownedReferenceSubsetting of the ownedConstraint, if there is one, and, otherwise, the ownedConstraint itself.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementConstraintMembership_ReferencedConstraint"></see></summary>
    let requirementConstraintMembership_ReferencedConstraint =
        Namespaced_IRI.parse _namespace_name "requirementConstraintMembership_ReferencedConstraint" |> NamespacedName

    /// <summary>
    /// The parameters of this RequirementDefinition that represent actors involved in the requirement.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementDefinition_ActorParameter"></see></summary>
    let requirementDefinition_ActorParameter =
        Namespaced_IRI.parse _namespace_name "requirementDefinition_ActorParameter" |> NamespacedName

    /// <summary>
    /// The owned ConstraintUsages that represent assumptions of this RequirementDefinition, which are the ownedConstraints of the RequirementConstraintMemberships of the RequirementDefinition with kind = assumption.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementDefinition_AssumedConstraint"></see></summary>
    let requirementDefinition_AssumedConstraint =
        Namespaced_IRI.parse _namespace_name "requirementDefinition_AssumedConstraint" |> NamespacedName

    /// <summary>
    /// The ConcernUsages framed by this RequirementDefinition, which are the ownedConcerns of all FramedConcernMemberships of the RequirementDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementDefinition_FramedConcern"></see></summary>
    let requirementDefinition_FramedConcern =
        Namespaced_IRI.parse _namespace_name "requirementDefinition_FramedConcern" |> NamespacedName

    /// <summary>
    /// An optional modeler-specified identifier for this RequirementDefinition (used, e.g., to link it to an original requirement text in some source document), which is the declaredShortName for the RequirementDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementDefinition_ReqId"></see></summary>
    let requirementDefinition_ReqId =
        Namespaced_IRI.parse _namespace_name "requirementDefinition_ReqId" |> NamespacedName

    /// <summary>
    /// The owned ConstraintUsages that represent requirements of this RequirementDefinition, derived as the ownedConstraints of the RequirementConstraintMemberships of the RequirementDefinition with kind = requirement.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementDefinition_RequiredConstraint"></see></summary>
    let requirementDefinition_RequiredConstraint =
        Namespaced_IRI.parse _namespace_name "requirementDefinition_RequiredConstraint" |> NamespacedName

    /// <summary>
    /// The parameters of this RequirementDefinition that represent stakeholders for th requirement.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementDefinition_StakeholderParameter"></see></summary>
    let requirementDefinition_StakeholderParameter =
        Namespaced_IRI.parse _namespace_name "requirementDefinition_StakeholderParameter" |> NamespacedName

    /// <summary>
    /// The parameter of this RequirementDefinition that represents its subject.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementDefinition_SubjectParameter"></see></summary>
    let requirementDefinition_SubjectParameter =
        Namespaced_IRI.parse _namespace_name "requirementDefinition_SubjectParameter" |> NamespacedName

    /// <summary>
    /// An optional textual statement of the requirement represented by this RequirementDefinition, derived from the bodies of the documentation of the RequirementDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementDefinition_Text"></see></summary>
    let requirementDefinition_Text =
        Namespaced_IRI.parse _namespace_name "requirementDefinition_Text" |> NamespacedName

    /// <summary>
    /// The parameters of this RequirementUsage that represent actors involved in the requirement.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementUsage_ActorParameter"></see></summary>
    let requirementUsage_ActorParameter =
        Namespaced_IRI.parse _namespace_name "requirementUsage_ActorParameter" |> NamespacedName

    /// <summary>
    /// The owned ConstraintUsages that represent assumptions of this RequirementUsage, derived as the ownedConstraints of the RequirementConstraintMemberships of the RequirementUsage with kind = assumption.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementUsage_AssumedConstraint"></see></summary>
    let requirementUsage_AssumedConstraint =
        Namespaced_IRI.parse _namespace_name "requirementUsage_AssumedConstraint" |> NamespacedName

    /// <summary>
    /// The ConcernUsages framed by this RequirementUsage, which are the ownedConcerns of all FramedConcernMemberships of the RequirementUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementUsage_FramedConcern"></see></summary>
    let requirementUsage_FramedConcern =
        Namespaced_IRI.parse _namespace_name "requirementUsage_FramedConcern" |> NamespacedName

    /// <summary>
    /// An optional modeler-specified identifier for this RequirementUsage (used, e.g., to link it to an original requirement text in some source document), which is the declaredShortName for the RequirementUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementUsage_ReqId"></see></summary>
    let requirementUsage_ReqId =
        Namespaced_IRI.parse _namespace_name "requirementUsage_ReqId" |> NamespacedName

    /// <summary>
    /// The owned ConstraintUsages that represent requirements of this RequirementUsage, which are the ownedConstraints of the RequirementConstraintMemberships of the RequirementUsage with kind = requirement.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementUsage_RequiredConstraint"></see></summary>
    let requirementUsage_RequiredConstraint =
        Namespaced_IRI.parse _namespace_name "requirementUsage_RequiredConstraint" |> NamespacedName

    /// <summary>
    /// The RequirementDefinition that is the single definition of this RequirementUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementUsage_RequirementDefinition"></see></summary>
    let requirementUsage_RequirementDefinition =
        Namespaced_IRI.parse _namespace_name "requirementUsage_RequirementDefinition" |> NamespacedName

    /// <summary>
    /// The parameters of this RequirementUsage that represent stakeholders for the requirement.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementUsage_StakeholderParameter"></see></summary>
    let requirementUsage_StakeholderParameter =
        Namespaced_IRI.parse _namespace_name "requirementUsage_StakeholderParameter" |> NamespacedName

    /// <summary>
    /// The parameter of this RequirementUsage that represents its subject.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementUsage_SubjectParameter"></see></summary>
    let requirementUsage_SubjectParameter =
        Namespaced_IRI.parse _namespace_name "requirementUsage_SubjectParameter" |> NamespacedName

    /// <summary>
    /// An optional textual statement of the requirement represented by this RequirementUsage, derived from the bodies of the documentation of the RequirementUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementUsage_Text"></see></summary>
    let requirementUsage_Text =
        Namespaced_IRI.parse _namespace_name "requirementUsage_Text" |> NamespacedName

    /// <summary>
    /// The owned RequirementUsage that acts as the ownedConstraint for this RequirementVerificationMembership. This will either be the verifiedRequirement, or it will subset the verifiedRequirement.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementVerificationMembership_OwnedRequirement"></see></summary>
    let requirementVerificationMembership_OwnedRequirement =
        Namespaced_IRI.parse _namespace_name "requirementVerificationMembership_OwnedRequirement" |> NamespacedName

    /// <summary>
    ///  The RequirementUsage that is identified as being verified. It is the referencedConstraint of the RequirementVerificationMembership considered as a RequirementConstraintMembership, which must be a RequirementUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#requirementVerificationMembership_VerifiedRequirement"></see></summary>
    let requirementVerificationMembership_VerifiedRequirement =
        Namespaced_IRI.parse _namespace_name "requirementVerificationMembership_VerifiedRequirement" |> NamespacedName

    /// <summary>
    /// The Expression that provides the result for the owner of the ResultExpressionMembership.
    /// <see href="http://open-services.net/ns/sysmlv2#resultExpressionMembership_OwnedResultExpression"></see></summary>
    let resultExpressionMembership_OwnedResultExpression =
        Namespaced_IRI.parse _namespace_name "resultExpressionMembership_OwnedResultExpression" |> NamespacedName

    /// <summary>
    /// The RequirementUsage that is satisfied by the satisfyingSubject of this SatisfyRequirementUsage. It is the assertedConstraint of the SatisfyRequirementUsage considered as an AssertConstraintUsage, which must be a RequirementUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#satisfyRequirementUsage_SatisfiedRequirement"></see></summary>
    let satisfyRequirementUsage_SatisfiedRequirement =
        Namespaced_IRI.parse _namespace_name "satisfyRequirementUsage_SatisfiedRequirement" |> NamespacedName

    /// <summary>
    /// The Feature that represents the actual subject that is asserted to satisfy the satisfiedRequirement. The satisfyingFeature is bound to the subjectParameter of the SatisfyRequirementUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#satisfyRequirementUsage_SatisfyingFeature"></see></summary>
    let satisfyRequirementUsage_SatisfyingFeature =
        Namespaced_IRI.parse _namespace_name "satisfyRequirementUsage_SatisfyingFeature" |> NamespacedName

    /// <summary>
    /// An Expression whose result is bound to the payload input parameter of this SendActionUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#sendActionUsage_PayloadArgument"></see></summary>
    let sendActionUsage_PayloadArgument =
        Namespaced_IRI.parse _namespace_name "sendActionUsage_PayloadArgument" |> NamespacedName

    /// <summary>
    /// An Expression whose result is bound to the receiver input parameter of this SendActionUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#sendActionUsage_ReceiverArgument"></see></summary>
    let sendActionUsage_ReceiverArgument =
        Namespaced_IRI.parse _namespace_name "sendActionUsage_ReceiverArgument" |> NamespacedName

    /// <summary>
    /// An Expression whose result is bound to the sender input parameter of this SendActionUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#sendActionUsage_SenderArgument"></see></summary>
    let sendActionUsage_SenderArgument =
        Namespaced_IRI.parse _namespace_name "sendActionUsage_SenderArgument" |> NamespacedName

    /// <summary>
    /// A Type with a superset of all instances of the specific Type, which might be the same set.
    /// <see href="http://open-services.net/ns/sysmlv2#specialization_General"></see></summary>
    let specialization_General =
        Namespaced_IRI.parse _namespace_name "specialization_General" |> NamespacedName

    /// <summary>
    /// The Type that is the specific Type of this Specialization and owns it as its owningRelatedElement.
    /// <see href="http://open-services.net/ns/sysmlv2#specialization_OwningType"></see></summary>
    let specialization_OwningType =
        Namespaced_IRI.parse _namespace_name "specialization_OwningType" |> NamespacedName

    /// <summary>
    /// A Type with a subset of all instances of the general Type, which might be the same set.
    /// <see href="http://open-services.net/ns/sysmlv2#specialization_Specific"></see></summary>
    let specialization_Specific =
        Namespaced_IRI.parse _namespace_name "specialization_Specific" |> NamespacedName

    /// <summary>
    /// The PartUsage specifying the stakeholder.
    /// <see href="http://open-services.net/ns/sysmlv2#stakeholderMembership_OwnedStakeholderParameter"></see></summary>
    let stakeholderMembership_OwnedStakeholderParameter =
        Namespaced_IRI.parse _namespace_name "stakeholderMembership_OwnedStakeholderParameter" |> NamespacedName

    /// <summary>
    /// The ActionUsage of this StateDefinition to be performed while in the state defined by the StateDefinition. It is the owned ActionUsage related to the StateDefinition by a StateSubactionMembership  with kind = do.
    /// <see href="http://open-services.net/ns/sysmlv2#stateDefinition_DoAction"></see></summary>
    let stateDefinition_DoAction =
        Namespaced_IRI.parse _namespace_name "stateDefinition_DoAction" |> NamespacedName

    /// <summary>
    /// The ActionUsage of this StateDefinition to be performed on entry to the state defined by the StateDefinition. It is the owned ActionUsage related to the StateDefinition by a StateSubactionMembership  with kind = entry.
    /// <see href="http://open-services.net/ns/sysmlv2#stateDefinition_EntryAction"></see></summary>
    let stateDefinition_EntryAction =
        Namespaced_IRI.parse _namespace_name "stateDefinition_EntryAction" |> NamespacedName

    /// <summary>
    /// The ActionUsage of this StateDefinition to be performed on exit to the state defined by the StateDefinition. It is the owned ActionUsage related to the StateDefinition by a StateSubactionMembership  with kind = exit.
    /// <see href="http://open-services.net/ns/sysmlv2#stateDefinition_ExitAction"></see></summary>
    let stateDefinition_ExitAction =
        Namespaced_IRI.parse _namespace_name "stateDefinition_ExitAction" |> NamespacedName

    /// <summary>
    /// Whether the ownedStates of this StateDefinition are to all be performed in parallel. If true, none of the ownedActions (which includes ownedStates) may have any incoming or outgoing Transitions. If false, only one ownedState may be performed at a time.
    /// <see href="http://open-services.net/ns/sysmlv2#stateDefinition_IsParallel"></see></summary>
    let stateDefinition_IsParallel =
        Namespaced_IRI.parse _namespace_name "stateDefinition_IsParallel" |> NamespacedName

    /// <summary>
    /// The StateUsages, which are actions in the StateDefinition, that specify the discrete states in the behavior defined by the StateDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#stateDefinition_State"></see></summary>
    let stateDefinition_State =
        Namespaced_IRI.parse _namespace_name "stateDefinition_State" |> NamespacedName

    /// <summary>
    /// Indicates that the action of a StateSubactionMembership is a doAction.
    /// <see href="http://open-services.net/ns/sysmlv2#stateSubactionKind_Do"></see></summary>
    let stateSubactionKind_Do =
        Namespaced_IRI.parse _namespace_name "stateSubactionKind_Do" |> NamespacedName

    /// <summary>
    /// Indicates that the action of a StateSubactionMembership is an entryAction.
    /// <see href="http://open-services.net/ns/sysmlv2#stateSubactionKind_Entry"></see></summary>
    let stateSubactionKind_Entry =
        Namespaced_IRI.parse _namespace_name "stateSubactionKind_Entry" |> NamespacedName

    /// <summary>
    /// Indicates that the action of a StateSubactionMembership is an exitAction.
    /// <see href="http://open-services.net/ns/sysmlv2#stateSubactionKind_Exit"></see></summary>
    let stateSubactionKind_Exit =
        Namespaced_IRI.parse _namespace_name "stateSubactionKind_Exit" |> NamespacedName

    /// <summary>
    /// The ActionUsage that is the ownedMemberFeature of this StateSubactionMembership.
    /// <see href="http://open-services.net/ns/sysmlv2#stateSubactionMembership_Action"></see></summary>
    let stateSubactionMembership_Action =
        Namespaced_IRI.parse _namespace_name "stateSubactionMembership_Action" |> NamespacedName

    /// <summary>
    /// Whether this StateSubactionMembership is for an entry, do or exit ActionUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#stateSubactionMembership_Kind"></see></summary>
    let stateSubactionMembership_Kind =
        Namespaced_IRI.parse _namespace_name "stateSubactionMembership_Kind" |> NamespacedName

    /// <summary>
    /// The ActionUsage of this StateUsage to be performed while in the state defined by the StateDefinition. It is the owned ActionUsage related to the StateUsage by a StateSubactionMembership  with kind = do.
    /// <see href="http://open-services.net/ns/sysmlv2#stateUsage_DoAction"></see></summary>
    let stateUsage_DoAction =
        Namespaced_IRI.parse _namespace_name "stateUsage_DoAction" |> NamespacedName

    /// <summary>
    /// The ActionUsage of this StateUsage to be performed on entry to the state defined by the StateDefinition. It is the owned ActionUsage related to the StateUsage by a StateSubactionMembership  with kind = entry.
    /// <see href="http://open-services.net/ns/sysmlv2#stateUsage_EntryAction"></see></summary>
    let stateUsage_EntryAction =
        Namespaced_IRI.parse _namespace_name "stateUsage_EntryAction" |> NamespacedName

    /// <summary>
    /// The ActionUsage of this StateUsage to be performed on exit to the state defined by the StateDefinition. It is the owned ActionUsage related to the StateUsage by a StateSubactionMembership  with kind = exit.
    /// <see href="http://open-services.net/ns/sysmlv2#stateUsage_ExitAction"></see></summary>
    let stateUsage_ExitAction =
        Namespaced_IRI.parse _namespace_name "stateUsage_ExitAction" |> NamespacedName

    /// <summary>
    /// Whether the nestedStates of this StateUsage are to all be performed in parallel. If true, none of the nestedActions (which include nestedStates) may have any incoming or outgoing Transitions. If false, only one nestedState may be performed at a time.
    /// <see href="http://open-services.net/ns/sysmlv2#stateUsage_IsParallel"></see></summary>
    let stateUsage_IsParallel =
        Namespaced_IRI.parse _namespace_name "stateUsage_IsParallel" |> NamespacedName

    /// <summary>
    /// The Behaviors that are the types of this StateUsage. Nominally, these would be StateDefinitions, but kernel Behaviors are also allowed, to permit use of Behaviors from the Kernel Model Libraries.
    /// <see href="http://open-services.net/ns/sysmlv2#stateUsage_StateDefinition"></see></summary>
    let stateUsage_StateDefinition =
        Namespaced_IRI.parse _namespace_name "stateUsage_StateDefinition" |> NamespacedName

    /// <summary>
    /// The Behaviors that type this Step.
    /// <see href="http://open-services.net/ns/sysmlv2#step_Behavior"></see></summary>
    let step_Behavior =
        Namespaced_IRI.parse _namespace_name "step_Behavior" |> NamespacedName

    /// <summary>
    /// The parameters of this Step, which are defined as its directedFeatures, whose values are passed into and/or out of a performance of the Step.
    /// <see href="http://open-services.net/ns/sysmlv2#step_Parameter"></see></summary>
    let step_Parameter =
        Namespaced_IRI.parse _namespace_name "step_Parameter" |> NamespacedName

    /// <summary>
    /// The Classifier that owns this Subclassification relationship, which must also be its subclassifier.
    /// <see href="http://open-services.net/ns/sysmlv2#subclassification_OwningClassifier"></see></summary>
    let subclassification_OwningClassifier =
        Namespaced_IRI.parse _namespace_name "subclassification_OwningClassifier" |> NamespacedName

    /// <summary>
    /// The more specific Classifier in this Subclassification.
    /// <see href="http://open-services.net/ns/sysmlv2#subclassification_Subclassifier"></see></summary>
    let subclassification_Subclassifier =
        Namespaced_IRI.parse _namespace_name "subclassification_Subclassifier" |> NamespacedName

    /// <summary>
    /// The more general Classifier in this Subclassification.
    /// <see href="http://open-services.net/ns/sysmlv2#subclassification_Superclassifier"></see></summary>
    let subclassification_Superclassifier =
        Namespaced_IRI.parse _namespace_name "subclassification_Superclassifier" |> NamespacedName

    /// <summary>
    /// The UsageownedMemberParameter of this SubjectMembership.
    /// <see href="http://open-services.net/ns/sysmlv2#subjectMembership_OwnedSubjectParameter"></see></summary>
    let subjectMembership_OwnedSubjectParameter =
        Namespaced_IRI.parse _namespace_name "subjectMembership_OwnedSubjectParameter" |> NamespacedName

    /// <summary>
    /// A subsettingFeature that is also the owningRelatedElement of this Subsetting.
    /// <see href="http://open-services.net/ns/sysmlv2#subsetting_OwningFeature"></see></summary>
    let subsetting_OwningFeature =
        Namespaced_IRI.parse _namespace_name "subsetting_OwningFeature" |> NamespacedName

    /// <summary>
    /// The Feature that is subsetted by the subsettingFeature of this Subsetting.
    /// <see href="http://open-services.net/ns/sysmlv2#subsetting_SubsettedFeature"></see></summary>
    let subsetting_SubsettedFeature =
        Namespaced_IRI.parse _namespace_name "subsetting_SubsettedFeature" |> NamespacedName

    /// <summary>
    /// The Feature that is a subset of the subsettedFeature of this Subsetting.
    /// <see href="http://open-services.net/ns/sysmlv2#subsetting_SubsettingFeature"></see></summary>
    let subsetting_SubsettingFeature =
        Namespaced_IRI.parse _namespace_name "subsetting_SubsettingFeature" |> NamespacedName

    /// <summary>
    /// Steps that represent occurrences that are side effects of the transitionStep occurring.
    /// <see href="http://open-services.net/ns/sysmlv2#succession_EffectStep"></see></summary>
    let succession_EffectStep =
        Namespaced_IRI.parse _namespace_name "succession_EffectStep" |> NamespacedName

    /// <summary>
    /// Expressions that must evaluate to true before the transitionStep can occur.
    /// <see href="http://open-services.net/ns/sysmlv2#succession_GuardExpression"></see></summary>
    let succession_GuardExpression =
        Namespaced_IRI.parse _namespace_name "succession_GuardExpression" |> NamespacedName

    /// <summary>
    /// A Step that is typed by the Behavior TransitionPerformances::TransitionPerformance (from the Kernel Semantic Library) that has this Succession as its transitionLink.
    /// <see href="http://open-services.net/ns/sysmlv2#succession_TransitionStep"></see></summary>
    let succession_TransitionStep =
        Namespaced_IRI.parse _namespace_name "succession_TransitionStep" |> NamespacedName

    /// <summary>
    /// Steps that map incoming events to the timing of occurrences of the transitionStep. The values of triggerStep subset the list of acceptable events to be received by a Behavior or the object that performs it.
    /// <see href="http://open-services.net/ns/sysmlv2#succession_TriggerStep"></see></summary>
    let succession_TriggerStep =
        Namespaced_IRI.parse _namespace_name "succession_TriggerStep" |> NamespacedName

    /// <summary>
    /// The textual representation of the representedElement in the given language.
    /// <see href="http://open-services.net/ns/sysmlv2#textualRepresentation_Body"></see></summary>
    let textualRepresentation_Body =
        Namespaced_IRI.parse _namespace_name "textualRepresentation_Body" |> NamespacedName

    /// <summary>
    /// The natural or artifical language in which the body text is written.
    /// <see href="http://open-services.net/ns/sysmlv2#textualRepresentation_Language"></see></summary>
    let textualRepresentation_Language =
        Namespaced_IRI.parse _namespace_name "textualRepresentation_Language" |> NamespacedName

    /// <summary>
    /// The Element that is represented by this TextualRepresentation.
    /// <see href="http://open-services.net/ns/sysmlv2#textualRepresentation_RepresentedElement"></see></summary>
    let textualRepresentation_RepresentedElement =
        Namespaced_IRI.parse _namespace_name "textualRepresentation_RepresentedElement" |> NamespacedName

    /// <summary>
    /// Indicates that the transitionFeature of a TransitionFeatureMembership is an effectAction.
    /// <see href="http://open-services.net/ns/sysmlv2#transitionFeatureKind_Effect"></see></summary>
    let transitionFeatureKind_Effect =
        Namespaced_IRI.parse _namespace_name "transitionFeatureKind_Effect" |> NamespacedName

    /// <summary>
    /// Indicates that the transitionFeature of a TransitionFeatureMembership is a guardExpression.
    /// <see href="http://open-services.net/ns/sysmlv2#transitionFeatureKind_Guard"></see></summary>
    let transitionFeatureKind_Guard =
        Namespaced_IRI.parse _namespace_name "transitionFeatureKind_Guard" |> NamespacedName

    /// <summary>
    /// Indicates that the transitionFeature of a TransitionFeatureMembership is a triggerAction.
    /// <see href="http://open-services.net/ns/sysmlv2#transitionFeatureKind_Trigger"></see></summary>
    let transitionFeatureKind_Trigger =
        Namespaced_IRI.parse _namespace_name "transitionFeatureKind_Trigger" |> NamespacedName

    /// <summary>
    /// Whether this TransitionFeatureMembership  is for a trigger, guard or effect.
    /// <see href="http://open-services.net/ns/sysmlv2#transitionFeatureMembership_Kind"></see></summary>
    let transitionFeatureMembership_Kind =
        Namespaced_IRI.parse _namespace_name "transitionFeatureMembership_Kind" |> NamespacedName

    /// <summary>
    /// The Step that is the ownedMemberFeature of this TransitionFeatureMembership.
    /// <see href="http://open-services.net/ns/sysmlv2#transitionFeatureMembership_TransitionFeature"></see></summary>
    let transitionFeatureMembership_TransitionFeature =
        Namespaced_IRI.parse _namespace_name "transitionFeatureMembership_TransitionFeature" |> NamespacedName

    /// <summary>
    /// The ActionUsages that define the effects of this TransitionUsage, which are the ownedFeatures of the TransitionUsage related to it by TransitionFeatureMemberships with kind = effect, which must all be ActionUsages.
    /// <see href="http://open-services.net/ns/sysmlv2#transitionUsage_EffectAction"></see></summary>
    let transitionUsage_EffectAction =
        Namespaced_IRI.parse _namespace_name "transitionUsage_EffectAction" |> NamespacedName

    /// <summary>
    /// The Expressions that define the guards of this TransitionUsage, which are the ownedFeatures of the TransitionUsage related to it by TransitionFeatureMemberships with kind = guard, which must all be Expressions.
    /// <see href="http://open-services.net/ns/sysmlv2#transitionUsage_GuardExpression"></see></summary>
    let transitionUsage_GuardExpression =
        Namespaced_IRI.parse _namespace_name "transitionUsage_GuardExpression" |> NamespacedName

    /// <summary>
    /// The source ActionUsage of this TransitionUsage, which becomes the source of the succession for the TransitionUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#transitionUsage_Source"></see></summary>
    let transitionUsage_Source =
        Namespaced_IRI.parse _namespace_name "transitionUsage_Source" |> NamespacedName

    /// <summary>
    /// The Succession that is the ownedFeature of this TransitionUsage, which, if the TransitionUsage is triggered, asserts the temporal ordering of the source and target.
    /// <see href="http://open-services.net/ns/sysmlv2#transitionUsage_Succession"></see></summary>
    let transitionUsage_Succession =
        Namespaced_IRI.parse _namespace_name "transitionUsage_Succession" |> NamespacedName

    /// <summary>
    /// The target ActionUsage of this TransitionUsage, which is the targetFeature of the succession for the TransitionUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#transitionUsage_Target"></see></summary>
    let transitionUsage_Target =
        Namespaced_IRI.parse _namespace_name "transitionUsage_Target" |> NamespacedName

    /// <summary>
    /// The AcceptActionUsages that define the triggers of this TransitionUsage, which are the ownedFeatures of the TransitionUsage related to it by TransitionFeatureMemberships with kind = trigger, which must all be AcceptActionUsages.
    /// <see href="http://open-services.net/ns/sysmlv2#transitionUsage_TriggerAction"></see></summary>
    let transitionUsage_TriggerAction =
        Namespaced_IRI.parse _namespace_name "transitionUsage_TriggerAction" |> NamespacedName

    /// <summary>
    /// Indicates which of the Functions from the Triggers model in the Kernel Semantic Library is to be invoked by this TriggerInvocationExpression.
    /// <see href="http://open-services.net/ns/sysmlv2#triggerInvocationExpression_Kind"></see></summary>
    let triggerInvocationExpression_Kind =
        Namespaced_IRI.parse _namespace_name "triggerInvocationExpression_Kind" |> NamespacedName

    /// <summary>
    /// Indicates a relative time trigger, corresponding to the TriggerAfter Function from the Triggers model in the Kernel Semantic Library.
    /// <see href="http://open-services.net/ns/sysmlv2#triggerKind_After"></see></summary>
    let triggerKind_After =
        Namespaced_IRI.parse _namespace_name "triggerKind_After" |> NamespacedName

    /// <summary>
    /// Indicates an absolute time trigger, corresponding to the TriggerAt Function from the Triggers model in the Kernel Semantic Library.
    /// <see href="http://open-services.net/ns/sysmlv2#triggerKind_At"></see></summary>
    let triggerKind_At =
        Namespaced_IRI.parse _namespace_name "triggerKind_At" |> NamespacedName

    /// <summary>
    /// Indicates a change trigger, corresponding to the TriggerWhen Function from the Triggers model in the Kernel Semantic Library.
    /// <see href="http://open-services.net/ns/sysmlv2#triggerKind_When"></see></summary>
    let triggerKind_When =
        Namespaced_IRI.parse _namespace_name "triggerKind_When" |> NamespacedName

    /// <summary>
    /// The Feature that is featured by the featuringType. It is the source of the TypeFeaturing.
    /// <see href="http://open-services.net/ns/sysmlv2#typeFeaturing_FeatureOfType"></see></summary>
    let typeFeaturing_FeatureOfType =
        Namespaced_IRI.parse _namespace_name "typeFeaturing_FeatureOfType" |> NamespacedName

    /// <summary>
    /// The Type that features the featureOfType. It is the target of the TypeFeaturing.
    /// <see href="http://open-services.net/ns/sysmlv2#typeFeaturing_FeaturingType"></see></summary>
    let typeFeaturing_FeaturingType =
        Namespaced_IRI.parse _namespace_name "typeFeaturing_FeaturingType" |> NamespacedName

    /// <summary>
    /// A featureOfType that is also the owningRelatedElement of this TypeFeaturing.
    /// <see href="http://open-services.net/ns/sysmlv2#typeFeaturing_OwningFeatureOfType"></see></summary>
    let typeFeaturing_OwningFeatureOfType =
        Namespaced_IRI.parse _namespace_name "typeFeaturing_OwningFeatureOfType" |> NamespacedName

    /// <summary>
    /// The interpretations of a Type with differencingTypes are asserted to be those of the first of those Types, but not including those of the remaining Types. For example, a Classifier might be the difference of a Classifier for people and another for people of a particular nationality, leaving people who are not of that nationality. Similarly, a feature of people might be the difference between a feature for their children and a Classifier for people of a particular sex, identifying their children not of that sex (because the interpretations of the children Feature that identify those of that sex are also interpretations of the Classifier for that sex).
    /// <see href="http://open-services.net/ns/sysmlv2#type_DifferencingType"></see></summary>
    let type_DifferencingType =
        Namespaced_IRI.parse _namespace_name "type_DifferencingType" |> NamespacedName

    /// <summary>
    /// The features of this Type that have a non-null direction.
    /// <see href="http://open-services.net/ns/sysmlv2#type_DirectedFeature"></see></summary>
    let type_DirectedFeature =
        Namespaced_IRI.parse _namespace_name "type_DirectedFeature" |> NamespacedName

    /// <summary>
    /// All features of this Type with isEnd = true.
    /// <see href="http://open-services.net/ns/sysmlv2#type_EndFeature"></see></summary>
    let type_EndFeature =
        Namespaced_IRI.parse _namespace_name "type_EndFeature" |> NamespacedName

    /// <summary>
    /// The ownedMemberFeatures of the featureMemberships of this Type.
    /// <see href="http://open-services.net/ns/sysmlv2#type_Feature"></see></summary>
    let type_Feature =
        Namespaced_IRI.parse _namespace_name "type_Feature" |> NamespacedName

    /// <summary>
    /// The FeatureMemberships for features of this Type, which include all ownedFeatureMemberships and those inheritedMemberships that are FeatureMemberships (but does not include any importedMemberships).
    /// <see href="http://open-services.net/ns/sysmlv2#type_FeatureMembership"></see></summary>
    let type_FeatureMembership =
        Namespaced_IRI.parse _namespace_name "type_FeatureMembership" |> NamespacedName

    /// <summary>
    /// All the memberFeatures of the inheritedMemberships of this Type that are FeatureMemberships.
    /// <see href="http://open-services.net/ns/sysmlv2#type_InheritedFeature"></see></summary>
    let type_InheritedFeature =
        Namespaced_IRI.parse _namespace_name "type_InheritedFeature" |> NamespacedName

    /// <summary>
    /// All Memberships inherited by this Type via Specialization or Conjugation. These are included in the derived union for the memberships of the Type.
    /// <see href="http://open-services.net/ns/sysmlv2#type_InheritedMembership"></see></summary>
    let type_InheritedMembership =
        Namespaced_IRI.parse _namespace_name "type_InheritedMembership" |> NamespacedName

    /// <summary>
    /// All features related to this Type by FeatureMemberships that have direction in or inout.
    /// <see href="http://open-services.net/ns/sysmlv2#type_Input"></see></summary>
    let type_Input = Namespaced_IRI.parse _namespace_name "type_Input" |> NamespacedName

    /// <summary>
    /// The interpretations of a Type with intersectingTypes are asserted to be those in common among the intersectingTypes, which are the Types derived from the intersectingType of the ownedIntersectings of this Type. For example, a Classifier might be an intersection of Classifiers for people of a particular sex and of a particular nationality. Similarly, a feature for people's children of a particular sex might be the intersection of a Feature for their children and a Classifier for people of that sex (because the interpretations of the children Feature that identify those of that sex are also interpretations of the Classifier for that sex).
    /// <see href="http://open-services.net/ns/sysmlv2#type_IntersectingType"></see></summary>
    let type_IntersectingType =
        Namespaced_IRI.parse _namespace_name "type_IntersectingType" |> NamespacedName

    /// <summary>
    /// Indicates whether instances of this Type must also be instances of at least one of its specialized Types.
    /// <see href="http://open-services.net/ns/sysmlv2#type_IsAbstract"></see></summary>
    let type_IsAbstract =
        Namespaced_IRI.parse _namespace_name "type_IsAbstract" |> NamespacedName

    /// <summary>
    /// Indicates whether this Type has an ownedConjugator.
    /// <see href="http://open-services.net/ns/sysmlv2#type_IsConjugated"></see></summary>
    let type_IsConjugated =
        Namespaced_IRI.parse _namespace_name "type_IsConjugated" |> NamespacedName

    /// <summary>
    /// Whether all things that meet the classification conditions of this Type must be classified by the Type.
    /// <see href="http://open-services.net/ns/sysmlv2#type_IsSufficient"></see></summary>
    let type_IsSufficient =
        Namespaced_IRI.parse _namespace_name "type_IsSufficient" |> NamespacedName

    /// <summary>
    /// An ownedMember of this Type that is a Multiplicity, which constraints the cardinality of the Type. If there is no such ownedMember, then the cardinality of this Type is constrained by all the Multiplicity constraints applicable to any direct supertypes.
    /// <see href="http://open-services.net/ns/sysmlv2#type_Multiplicity"></see></summary>
    let type_Multiplicity =
        Namespaced_IRI.parse _namespace_name "type_Multiplicity" |> NamespacedName

    /// <summary>
    /// All features related to this Type by FeatureMemberships that have direction out or inout.
    /// <see href="http://open-services.net/ns/sysmlv2#type_Output"></see></summary>
    let type_Output =
        Namespaced_IRI.parse _namespace_name "type_Output" |> NamespacedName

    /// <summary>
    /// A Conjugation owned by this Type for which the Type is the originalType.
    /// <see href="http://open-services.net/ns/sysmlv2#type_OwnedConjugator"></see></summary>
    let type_OwnedConjugator =
        Namespaced_IRI.parse _namespace_name "type_OwnedConjugator" |> NamespacedName

    /// <summary>
    /// The ownedRelationships of this Type that are Differencings, having this Type as their typeDifferenced.
    /// <see href="http://open-services.net/ns/sysmlv2#type_OwnedDifferencing"></see></summary>
    let type_OwnedDifferencing =
        Namespaced_IRI.parse _namespace_name "type_OwnedDifferencing" |> NamespacedName

    /// <summary>
    /// The ownedRelationships of this Type that are Disjoinings, for which the Type is the typeDisjoined Type.
    /// <see href="http://open-services.net/ns/sysmlv2#type_OwnedDisjoining"></see></summary>
    let type_OwnedDisjoining =
        Namespaced_IRI.parse _namespace_name "type_OwnedDisjoining" |> NamespacedName

    /// <summary>
    /// All endFeatures of this Type that are ownedFeatures.
    /// <see href="http://open-services.net/ns/sysmlv2#type_OwnedEndFeature"></see></summary>
    let type_OwnedEndFeature =
        Namespaced_IRI.parse _namespace_name "type_OwnedEndFeature" |> NamespacedName

    /// <summary>
    /// The ownedMemberFeatures of the ownedFeatureMemberships of this Type.
    /// <see href="http://open-services.net/ns/sysmlv2#type_OwnedFeature"></see></summary>
    let type_OwnedFeature =
        Namespaced_IRI.parse _namespace_name "type_OwnedFeature" |> NamespacedName

    /// <summary>
    /// The ownedMemberships of this Type that are FeatureMemberships, for which the Type is the owningType. Each such FeatureMembership identifies an ownedFeature of the Type.
    /// <see href="http://open-services.net/ns/sysmlv2#type_OwnedFeatureMembership"></see></summary>
    let type_OwnedFeatureMembership =
        Namespaced_IRI.parse _namespace_name "type_OwnedFeatureMembership" |> NamespacedName

    /// <summary>
    /// The ownedRelationships of this Type that are Intersectings, have the Type as their typeIntersected.
    /// <see href="http://open-services.net/ns/sysmlv2#type_OwnedIntersecting"></see></summary>
    let type_OwnedIntersecting =
        Namespaced_IRI.parse _namespace_name "type_OwnedIntersecting" |> NamespacedName

    /// <summary>
    /// The ownedRelationships of this Type that are Specializations, for which the Type is the specific Type.
    /// <see href="http://open-services.net/ns/sysmlv2#type_OwnedSpecialization"></see></summary>
    let type_OwnedSpecialization =
        Namespaced_IRI.parse _namespace_name "type_OwnedSpecialization" |> NamespacedName

    /// <summary>
    /// The ownedRelationships of this Type that are Unionings, having the Type as their typeUnioned.
    /// <see href="http://open-services.net/ns/sysmlv2#type_OwnedUnioning"></see></summary>
    let type_OwnedUnioning =
        Namespaced_IRI.parse _namespace_name "type_OwnedUnioning" |> NamespacedName

    /// <summary>
    /// The interpretations of a Type with unioningTypes are asserted to be the same as those of all the unioningTypes together, which are the Types derived from the unioningType of the ownedUnionings of this Type. For example, a Classifier for people might be the union of Classifiers for all the sexes. Similarly, a feature for people's children might be the union of features dividing them in the same ways as people in general.
    /// <see href="http://open-services.net/ns/sysmlv2#type_UnioningType"></see></summary>
    let type_UnioningType =
        Namespaced_IRI.parse _namespace_name "type_UnioningType" |> NamespacedName

    /// <summary>
    /// Type with interpretations partly determined by unioningType, as described in Type::unioningType.
    /// <see href="http://open-services.net/ns/sysmlv2#unioning_TypeUnioned"></see></summary>
    let unioning_TypeUnioned =
        Namespaced_IRI.parse _namespace_name "unioning_TypeUnioned" |> NamespacedName

    /// <summary>
    /// Type that partly determines interpretations of typeUnioned, as described in Type::unioningType.
    /// <see href="http://open-services.net/ns/sysmlv2#unioning_UnioningType"></see></summary>
    let unioning_UnioningType =
        Namespaced_IRI.parse _namespace_name "unioning_UnioningType" |> NamespacedName

    /// <summary>
    /// The Classifiers that are the types of this Usage. Nominally, these are Definitions, but other kinds of Kernel Classifiers are also allowed, to permit use of Classifiers from the Kernel Model Libraries.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_Definition"></see></summary>
    let usage_Definition =
        Namespaced_IRI.parse _namespace_name "usage_Definition" |> NamespacedName

    /// <summary>
    /// The usages of this Usage that are directedFeatures.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_DirectedUsage"></see></summary>
    let usage_DirectedUsage =
        Namespaced_IRI.parse _namespace_name "usage_DirectedUsage" |> NamespacedName

    /// <summary>
    /// Whether this Usage is a referential Usage, that is, it has isComposite = false.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_IsReference"></see></summary>
    let usage_IsReference =
        Namespaced_IRI.parse _namespace_name "usage_IsReference" |> NamespacedName

    /// <summary>
    /// Whether this Usage is for a variation point or not. If true, then all the memberships of the Usage must be VariantMemberships.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_IsVariation"></see></summary>
    let usage_IsVariation =
        Namespaced_IRI.parse _namespace_name "usage_IsVariation" |> NamespacedName

    /// <summary>
    /// The ActionUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedAction"></see></summary>
    let usage_NestedAction =
        Namespaced_IRI.parse _namespace_name "usage_NestedAction" |> NamespacedName

    /// <summary>
    /// The AllocationUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedAllocation"></see></summary>
    let usage_NestedAllocation =
        Namespaced_IRI.parse _namespace_name "usage_NestedAllocation" |> NamespacedName

    /// <summary>
    /// The AnalysisCaseUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedAnalysisCase"></see></summary>
    let usage_NestedAnalysisCase =
        Namespaced_IRI.parse _namespace_name "usage_NestedAnalysisCase" |> NamespacedName

    /// <summary>
    /// The code&gt;AttributeUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedAttribute"></see></summary>
    let usage_NestedAttribute =
        Namespaced_IRI.parse _namespace_name "usage_NestedAttribute" |> NamespacedName

    /// <summary>
    /// The CalculationUsage that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedCalculation"></see></summary>
    let usage_NestedCalculation =
        Namespaced_IRI.parse _namespace_name "usage_NestedCalculation" |> NamespacedName

    /// <summary>
    /// The CaseUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedCase"></see></summary>
    let usage_NestedCase =
        Namespaced_IRI.parse _namespace_name "usage_NestedCase" |> NamespacedName

    /// <summary>
    /// The ConcernUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedConcern"></see></summary>
    let usage_NestedConcern =
        Namespaced_IRI.parse _namespace_name "usage_NestedConcern" |> NamespacedName

    /// <summary>
    /// The ConnectorAsUsages that are nestedUsages of this Usage. Note that this list includes BindingConnectorAsUsages and SuccessionAsUsages, even though these are ConnectorAsUsages but not ConnectionUsages.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedConnection"></see></summary>
    let usage_NestedConnection =
        Namespaced_IRI.parse _namespace_name "usage_NestedConnection" |> NamespacedName

    /// <summary>
    /// The ConstraintUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedConstraint"></see></summary>
    let usage_NestedConstraint =
        Namespaced_IRI.parse _namespace_name "usage_NestedConstraint" |> NamespacedName

    /// <summary>
    /// The code&gt;EnumerationUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedEnumeration"></see></summary>
    let usage_NestedEnumeration =
        Namespaced_IRI.parse _namespace_name "usage_NestedEnumeration" |> NamespacedName

    /// <summary>
    /// The code&gt;FlowConnectionUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedFlow"></see></summary>
    let usage_NestedFlow =
        Namespaced_IRI.parse _namespace_name "usage_NestedFlow" |> NamespacedName

    /// <summary>
    /// The InterfaceUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedInterface"></see></summary>
    let usage_NestedInterface =
        Namespaced_IRI.parse _namespace_name "usage_NestedInterface" |> NamespacedName

    /// <summary>
    /// The ItemUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedItem"></see></summary>
    let usage_NestedItem =
        Namespaced_IRI.parse _namespace_name "usage_NestedItem" |> NamespacedName

    /// <summary>
    /// The MetadataUsages that are nestedUsages of this of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedMetadata"></see></summary>
    let usage_NestedMetadata =
        Namespaced_IRI.parse _namespace_name "usage_NestedMetadata" |> NamespacedName

    /// <summary>
    /// The OccurrenceUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedOccurrence"></see></summary>
    let usage_NestedOccurrence =
        Namespaced_IRI.parse _namespace_name "usage_NestedOccurrence" |> NamespacedName

    /// <summary>
    /// The PartUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedPart"></see></summary>
    let usage_NestedPart =
        Namespaced_IRI.parse _namespace_name "usage_NestedPart" |> NamespacedName

    /// <summary>
    /// The PortUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedPort"></see></summary>
    let usage_NestedPort =
        Namespaced_IRI.parse _namespace_name "usage_NestedPort" |> NamespacedName

    /// <summary>
    /// The ReferenceUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedReference"></see></summary>
    let usage_NestedReference =
        Namespaced_IRI.parse _namespace_name "usage_NestedReference" |> NamespacedName

    /// <summary>
    /// The RenderingUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedRendering"></see></summary>
    let usage_NestedRendering =
        Namespaced_IRI.parse _namespace_name "usage_NestedRendering" |> NamespacedName

    /// <summary>
    /// The RequirementUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedRequirement"></see></summary>
    let usage_NestedRequirement =
        Namespaced_IRI.parse _namespace_name "usage_NestedRequirement" |> NamespacedName

    /// <summary>
    /// The StateUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedState"></see></summary>
    let usage_NestedState =
        Namespaced_IRI.parse _namespace_name "usage_NestedState" |> NamespacedName

    /// <summary>
    /// The TransitionUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedTransition"></see></summary>
    let usage_NestedTransition =
        Namespaced_IRI.parse _namespace_name "usage_NestedTransition" |> NamespacedName

    /// <summary>
    /// The Usages that are ownedFeatures of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedUsage"></see></summary>
    let usage_NestedUsage =
        Namespaced_IRI.parse _namespace_name "usage_NestedUsage" |> NamespacedName

    /// <summary>
    /// The UseCaseUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedUseCase"></see></summary>
    let usage_NestedUseCase =
        Namespaced_IRI.parse _namespace_name "usage_NestedUseCase" |> NamespacedName

    /// <summary>
    /// The VerificationCaseUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedVerificationCase"></see></summary>
    let usage_NestedVerificationCase =
        Namespaced_IRI.parse _namespace_name "usage_NestedVerificationCase" |> NamespacedName

    /// <summary>
    /// The ViewUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedView"></see></summary>
    let usage_NestedView =
        Namespaced_IRI.parse _namespace_name "usage_NestedView" |> NamespacedName

    /// <summary>
    /// The ViewpointUsages that are nestedUsages of this Usage.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_NestedViewpoint"></see></summary>
    let usage_NestedViewpoint =
        Namespaced_IRI.parse _namespace_name "usage_NestedViewpoint" |> NamespacedName

    /// <summary>
    /// The Definition that owns this Usage (if any).
    /// <see href="http://open-services.net/ns/sysmlv2#usage_OwningDefinition"></see></summary>
    let usage_OwningDefinition =
        Namespaced_IRI.parse _namespace_name "usage_OwningDefinition" |> NamespacedName

    /// <summary>
    /// The Usage in which this Usage is nested (if any).
    /// <see href="http://open-services.net/ns/sysmlv2#usage_OwningUsage"></see></summary>
    let usage_OwningUsage =
        Namespaced_IRI.parse _namespace_name "usage_OwningUsage" |> NamespacedName

    /// <summary>
    /// The Usages that are features of this Usage (not necessarily owned).
    /// <see href="http://open-services.net/ns/sysmlv2#usage_Usage"></see></summary>
    let usage_Usage =
        Namespaced_IRI.parse _namespace_name "usage_Usage" |> NamespacedName

    /// <summary>
    /// The Usages which represent the variants of this Usage as a variation point Usage, if isVariation = true. If isVariation = false, then there must be no variants.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_Variant"></see></summary>
    let usage_Variant =
        Namespaced_IRI.parse _namespace_name "usage_Variant" |> NamespacedName

    /// <summary>
    /// The ownedMemberships of this Usage that are VariantMemberships. If isVariation = true, then this must be all memberships of the Usage. If isVariation = false, then variantMembershipmust be empty.
    /// <see href="http://open-services.net/ns/sysmlv2#usage_VariantMembership"></see></summary>
    let usage_VariantMembership =
        Namespaced_IRI.parse _namespace_name "usage_VariantMembership" |> NamespacedName

    /// <summary>
    /// The UseCaseUsages that are included by this UseCaseDefinition, which are the useCaseIncludeds of the IncludeUseCaseUsages owned by this UseCaseDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#useCaseDefinition_IncludedUseCase"></see></summary>
    let useCaseDefinition_IncludedUseCase =
        Namespaced_IRI.parse _namespace_name "useCaseDefinition_IncludedUseCase" |> NamespacedName

    /// <summary>
    /// The UseCaseUsages that are included by this UseCaseUse, which are the useCaseIncludeds of the IncludeUseCaseUsages owned by this UseCaseUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#useCaseUsage_IncludedUseCase"></see></summary>
    let useCaseUsage_IncludedUseCase =
        Namespaced_IRI.parse _namespace_name "useCaseUsage_IncludedUseCase" |> NamespacedName

    /// <summary>
    /// The UseCaseDefinition that is the definition of this UseCaseUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#useCaseUsage_UseCaseDefinition"></see></summary>
    let useCaseUsage_UseCaseDefinition =
        Namespaced_IRI.parse _namespace_name "useCaseUsage_UseCaseDefinition" |> NamespacedName

    /// <summary>
    /// The Usage that represents a variant in the context of the owningVariationDefinition or owningVariationUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#variantMembership_OwnedVariantUsage"></see></summary>
    let variantMembership_OwnedVariantUsage =
        Namespaced_IRI.parse _namespace_name "variantMembership_OwnedVariantUsage" |> NamespacedName

    /// <summary>
    /// The RequirementUsages verified by this VerificationCaseDefinition, which are the verifiedRequirements of all RequirementVerificationMemberships of the objectiveRequirement.
    /// <see href="http://open-services.net/ns/sysmlv2#verificationCaseDefinition_VerifiedRequirement"></see></summary>
    let verificationCaseDefinition_VerifiedRequirement =
        Namespaced_IRI.parse _namespace_name "verificationCaseDefinition_VerifiedRequirement" |> NamespacedName

    /// <summary>
    /// The VerificationCase that is the definition of this VerificationCaseUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#verificationCaseUsage_VerificationCaseDefinition"></see></summary>
    let verificationCaseUsage_VerificationCaseDefinition =
        Namespaced_IRI.parse _namespace_name "verificationCaseUsage_VerificationCaseDefinition" |> NamespacedName

    /// <summary>
    /// The RequirementUsages verified by this VerificationCaseUsage, which are the verifiedRequirements of all RequirementVerificationMemberships of the objectiveRequirement.
    /// <see href="http://open-services.net/ns/sysmlv2#verificationCaseUsage_VerifiedRequirement"></see></summary>
    let verificationCaseUsage_VerifiedRequirement =
        Namespaced_IRI.parse _namespace_name "verificationCaseUsage_VerifiedRequirement" |> NamespacedName

    /// <summary>
    /// The composite ownedRequirements of this ViewDefinition that are ViewpointUsages for viewpoints satisfied by the ViewDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#viewDefinition_SatisfiedViewpoint"></see></summary>
    let viewDefinition_SatisfiedViewpoint =
        Namespaced_IRI.parse _namespace_name "viewDefinition_SatisfiedViewpoint" |> NamespacedName

    /// <summary>
    /// The usages of this ViewDefinition that are ViewUsages.
    /// <see href="http://open-services.net/ns/sysmlv2#viewDefinition_View"></see></summary>
    let viewDefinition_View =
        Namespaced_IRI.parse _namespace_name "viewDefinition_View" |> NamespacedName

    /// <summary>
    /// The Expressions related to this ViewDefinition by ElementFilterMemberships, which specify conditions on Elements to be rendered in a view.
    /// <see href="http://open-services.net/ns/sysmlv2#viewDefinition_ViewCondition"></see></summary>
    let viewDefinition_ViewCondition =
        Namespaced_IRI.parse _namespace_name "viewDefinition_ViewCondition" |> NamespacedName

    /// <summary>
    /// The RenderingUsage to be used to render views defined by this ViewDefinition, which is the referencedRendering of the ViewRenderingMembership of the ViewDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#viewDefinition_ViewRendering"></see></summary>
    let viewDefinition_ViewRendering =
        Namespaced_IRI.parse _namespace_name "viewDefinition_ViewRendering" |> NamespacedName

    /// <summary>
    /// The owned RenderingUsage that is either itself the referencedRendering or subsets the referencedRendering.
    /// <see href="http://open-services.net/ns/sysmlv2#viewRenderingMembership_OwnedRendering"></see></summary>
    let viewRenderingMembership_OwnedRendering =
        Namespaced_IRI.parse _namespace_name "viewRenderingMembership_OwnedRendering" |> NamespacedName

    /// <summary>
    ///  The RenderingUsage that is referenced through this ViewRenderingMembership. It is the referencedFeature of the ownedReferenceSubsetting for the ownedRendering, if there is one, and, otherwise, the ownedRendering itself.
    /// <see href="http://open-services.net/ns/sysmlv2#viewRenderingMembership_ReferencedRendering"></see></summary>
    let viewRenderingMembership_ReferencedRendering =
        Namespaced_IRI.parse _namespace_name "viewRenderingMembership_ReferencedRendering" |> NamespacedName

    /// <summary>
    /// The Elements that are exposed by this ViewUsage, which are those memberElements of the imported Memberships from all the Expose Relationships that meet all the owned and inherited viewConditions.
    /// <see href="http://open-services.net/ns/sysmlv2#viewUsage_ExposedElement"></see></summary>
    let viewUsage_ExposedElement =
        Namespaced_IRI.parse _namespace_name "viewUsage_ExposedElement" |> NamespacedName

    /// <summary>
    /// The nestedRequirements of this ViewUsage that are ViewpointUsages for (additional) viewpoints satisfied by the ViewUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#viewUsage_SatisfiedViewpoint"></see></summary>
    let viewUsage_SatisfiedViewpoint =
        Namespaced_IRI.parse _namespace_name "viewUsage_SatisfiedViewpoint" |> NamespacedName

    /// <summary>
    /// The Expressions related to this ViewUsage by ElementFilterMemberships, which specify conditions on Elements to be rendered in a view.
    /// <see href="http://open-services.net/ns/sysmlv2#viewUsage_ViewCondition"></see></summary>
    let viewUsage_ViewCondition =
        Namespaced_IRI.parse _namespace_name "viewUsage_ViewCondition" |> NamespacedName

    /// <summary>
    /// The ViewDefinition that is the definition of this ViewUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#viewUsage_ViewDefinition"></see></summary>
    let viewUsage_ViewDefinition =
        Namespaced_IRI.parse _namespace_name "viewUsage_ViewDefinition" |> NamespacedName

    /// <summary>
    /// The RenderingUsage to be used to render views defined by this ViewUsage, which is the referencedRendering of the ViewRenderingMembership of the ViewUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#viewUsage_ViewRendering"></see></summary>
    let viewUsage_ViewRendering =
        Namespaced_IRI.parse _namespace_name "viewUsage_ViewRendering" |> NamespacedName

    /// <summary>
    /// The PartUsages that identify the stakeholders with concerns framed by this ViewpointDefinition, which are the owned and inherited stakeholderParameters of the framedConcerns of this ViewpointDefinition.
    /// <see href="http://open-services.net/ns/sysmlv2#viewpointDefinition_ViewpointStakeholder"></see></summary>
    let viewpointDefinition_ViewpointStakeholder =
        Namespaced_IRI.parse _namespace_name "viewpointDefinition_ViewpointStakeholder" |> NamespacedName

    /// <summary>
    /// The ViewpointDefinition that is the definition of this ViewpointUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#viewpointUsage_ViewpointDefinition"></see></summary>
    let viewpointUsage_ViewpointDefinition =
        Namespaced_IRI.parse _namespace_name "viewpointUsage_ViewpointDefinition" |> NamespacedName

    /// <summary>
    /// The PartUsages that identify the stakeholders with concerns framed by this ViewpointUsage, which are the owned and inherited stakeholderParameters of the framedConcerns of this ViewpointUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#viewpointUsage_ViewpointStakeholder"></see></summary>
    let viewpointUsage_ViewpointStakeholder =
        Namespaced_IRI.parse _namespace_name "viewpointUsage_ViewpointStakeholder" |> NamespacedName

    /// <summary>
    /// Indicates a Membership is not visible outside its owning Namespace.
    /// <see href="http://open-services.net/ns/sysmlv2#visibilityKind_Private"></see></summary>
    let visibilityKind_Private =
        Namespaced_IRI.parse _namespace_name "visibilityKind_Private" |> NamespacedName

    /// <summary>
    /// An intermediate level of visibility between public and private. By default, it is equivalent to private for the purposes of normal access to and import of Elements from a Namespace. However, other Relationships may be specified to include Memberships with protected visibility in the list of memberships for a Namespace (e.g., Specialization).
    /// <see href="http://open-services.net/ns/sysmlv2#visibilityKind_Protected"></see></summary>
    let visibilityKind_Protected =
        Namespaced_IRI.parse _namespace_name "visibilityKind_Protected" |> NamespacedName

    /// <summary>
    /// Indicates that a Membership is publicly visible outside its owning Namespace.
    /// <see href="http://open-services.net/ns/sysmlv2#visibilityKind_Public"></see></summary>
    let visibilityKind_Public =
        Namespaced_IRI.parse _namespace_name "visibilityKind_Public" |> NamespacedName

    /// <summary>
    /// The Expression whose result, if false, determines that the bodyAction should continue to be performed. It is the (optional) third owned parameter of the WhileLoopActionUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#whileLoopActionUsage_UntilArgument"></see></summary>
    let whileLoopActionUsage_UntilArgument =
        Namespaced_IRI.parse _namespace_name "whileLoopActionUsage_UntilArgument" |> NamespacedName

    /// <summary>
    /// The Expression whose result, if true, determines that the bodyAction should continue to be performed. It is the first owned parameter of the WhileLoopActionUsage.
    /// <see href="http://open-services.net/ns/sysmlv2#whileLoopActionUsage_WhileArgument"></see></summary>
    let whileLoopActionUsage_WhileArgument =
        Namespaced_IRI.parse _namespace_name "whileLoopActionUsage_WhileArgument" |> NamespacedName
