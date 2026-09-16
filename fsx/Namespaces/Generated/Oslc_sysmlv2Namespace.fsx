#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module oslc_sysmlv2 =
    let _prefixId = PrefixId.fromNamespaceLabel "http://open-services.net/ns/sysmlv2#" "oslc_sysmlv2"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : AcceptActionUsage^^xsd:string</para>
    ///   <para>rdfs:comment : An AcceptActionUsage is an ActionUsage that specifies the acceptance of an incomingTransfer from the Occurrence given by the result of its receiverArgument Expression. (If no receiverArgument is provided, the default is the this context of the AcceptActionUsage.) The payload of the accepted Transfer is output on its payloadParameter. Which Transfers may be accepted is determined by conformance to the typing and (potentially) binding of the payloadParameter.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#AcceptActionUsage">oslc_sysmlv2:AcceptActionUsage</a>
    /// </summary>
    let AcceptActionUsage = _prefixId.prefix "AcceptActionUsage"
    /// <summary>
    ///   <para>rdfs:label : ActionDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : An ActionDefinition is a Definition that is also a Behavior that defines an Action performed by a system or part of a system.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#ActionDefinition">oslc_sysmlv2:ActionDefinition</a>
    /// </summary>
    let ActionDefinition = _prefixId.prefix "ActionDefinition"
    /// <summary>
    ///   <para>rdfs:label : ActionUsage^^xsd:string</para>
    ///   <para>rdfs:comment : An ActionUsage is a Usage that is also a Step, and, so, is typed by a Behavior. Nominally, if the type is an ActionDefinition, an ActionUsage is a Usage of that ActionDefinition within a system. However, other kinds of kernel Behaviors are also allowed, to permit use of Behaviors from the Kernel Model Libraries.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#ActionUsage">oslc_sysmlv2:ActionUsage</a>
    /// </summary>
    let ActionUsage = _prefixId.prefix "ActionUsage"
    /// <summary>
    ///   <para>rdfs:label : ActorMembership^^xsd:string</para>
    ///   <para>rdfs:comment : An ActorMembership is a ParameterMembership that identifies a PartUsage as an actor parameter, which specifies a role played by an external entity in interaction with the owningType of the ActorMembership.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#ActorMembership">oslc_sysmlv2:ActorMembership</a>
    /// </summary>
    let ActorMembership = _prefixId.prefix "ActorMembership"
    /// <summary>
    ///   <para>rdfs:label : AllocationDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : An AllocationDefinition is a ConnectionDefinition that specifies that some or all of the responsibility to realize the intent of the source is allocated to the target instances. Such allocations define mappings across the various structures and hierarchies of a system model, perhaps as a precursor to more rigorous specifications and implementations. An AllocationDefinition can itself be refined using nested allocations that give a finer-grained decomposition of the containing allocation mapping.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#AllocationDefinition">oslc_sysmlv2:AllocationDefinition</a>
    /// </summary>
    let AllocationDefinition = _prefixId.prefix "AllocationDefinition"
    /// <summary>
    ///   <para>rdfs:label : AllocationUsage^^xsd:string</para>
    ///   <para>rdfs:comment : An AllocationUsage is a usage of an AllocationDefinition asserting the allocation of the source feature to the target feature.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#AllocationUsage">oslc_sysmlv2:AllocationUsage</a>
    /// </summary>
    let AllocationUsage = _prefixId.prefix "AllocationUsage"
    /// <summary>
    ///   <para>rdfs:label : AnalysisCaseDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : An AnalysisCaseDefinition is a CaseDefinition for the case of carrying out an analysis.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#AnalysisCaseDefinition">oslc_sysmlv2:AnalysisCaseDefinition</a>
    /// </summary>
    let AnalysisCaseDefinition = _prefixId.prefix "AnalysisCaseDefinition"
    /// <summary>
    ///   <para>rdfs:label : AnalysisCaseUsage^^xsd:string</para>
    ///   <para>rdfs:comment : An AnalysisCaseUsage is a Usage of an AnalysisCaseDefinition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#AnalysisCaseUsage">oslc_sysmlv2:AnalysisCaseUsage</a>
    /// </summary>
    let AnalysisCaseUsage = _prefixId.prefix "AnalysisCaseUsage"
    /// <summary>
    ///   <para>rdfs:label : AnnotatingElement^^xsd:string</para>
    ///   <para>rdfs:comment : An AnnotatingElement is an Element that provides additional description of or metadata on some other Element. An AnnotatingElement is either attached to its annotatedElements by Annotation Relationships, or it implicitly annotates its owningNamespace.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#AnnotatingElement">oslc_sysmlv2:AnnotatingElement</a>
    /// </summary>
    let AnnotatingElement = _prefixId.prefix "AnnotatingElement"
    /// <summary>
    ///   <para>rdfs:label : Annotation^^xsd:string</para>
    ///   <para>rdfs:comment : An Annotation is a Relationship between an AnnotatingElement and the Element that is annotated by that AnnotatingElement.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Annotation">oslc_sysmlv2:Annotation</a>
    /// </summary>
    let Annotation = _prefixId.prefix "Annotation"
    /// <summary>
    ///   <para>rdfs:label : AssertConstraintUsage^^xsd:string</para>
    ///   <para>rdfs:comment : An AssertConstraintUsage is a ConstraintUsage that is also an Invariant and, so, is asserted to be true (by default). Unless it is the AssertConstraintUsage itself, the asserted ConstraintUsage is related to the AssertConstraintUsage by a ReferenceSubsetting Relationship.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#AssertConstraintUsage">oslc_sysmlv2:AssertConstraintUsage</a>
    /// </summary>
    let AssertConstraintUsage = _prefixId.prefix "AssertConstraintUsage"
    /// <summary>
    ///   <para>rdfs:label : AssignmentActionUsage^^xsd:string</para>
    ///   <para>rdfs:comment : An AssignmentActionUsage is an ActionUsage that is defined, directly or indirectly, by the ActionDefinition AssignmentAction from the Systems Model Library. It specifies that the value of the referent Feature, relative to the target given by the result of the targetArgument Expression, should be set to the result of the valueExpression.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#AssignmentActionUsage">oslc_sysmlv2:AssignmentActionUsage</a>
    /// </summary>
    let AssignmentActionUsage = _prefixId.prefix "AssignmentActionUsage"
    /// <summary>
    ///   <para>rdfs:label : Association^^xsd:string</para>
    ///   <para>rdfs:comment : An Association is a Relationship and a Classifier to enable classification of links between things (in the universe). The co-domains (types) of the associationEnd Features are the relatedTypes, as co-domain and participants (linked things) of an Association identify each other.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Association">oslc_sysmlv2:Association</a>
    /// </summary>
    let Association = _prefixId.prefix "Association"
    /// <summary>
    ///   <para>rdfs:label : AssociationStructure^^xsd:string</para>
    ///   <para>rdfs:comment : An AssociationStructure is an Association that is also a Structure, classifying link objects that are both links and objects. As objects, link objects can be created and destroyed, and their non-end Features can change over time. However, the values of the end Features of a link object are fixed and cannot change over its lifetime.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#AssociationStructure">oslc_sysmlv2:AssociationStructure</a>
    /// </summary>
    let AssociationStructure = _prefixId.prefix "AssociationStructure"
    /// <summary>
    ///   <para>rdfs:label : AttributeDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : An AttributeDefinition is a Definition and a DataType of information about a quality or characteristic of a system or part of a system that has no independent identity other than its value. All features of an AttributeDefinition must be referential (non-composite).^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#AttributeDefinition">oslc_sysmlv2:AttributeDefinition</a>
    /// </summary>
    let AttributeDefinition = _prefixId.prefix "AttributeDefinition"
    /// <summary>
    ///   <para>rdfs:label : AttributeUsage^^xsd:string</para>
    ///   <para>rdfs:comment : An AttributeUsage is a Usage whose type is a DataType. Nominally, if the type is an AttributeDefinition, an AttributeUsage is a usage of a AttributeDefinition to represent the value of some system quality or characteristic. However, other kinds of kernel DataTypes are also allowed, to permit use of DataTypes from the Kernel Model Libraries. An AttributeUsage itself as well as all its nested features must be referential (non-composite).^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#AttributeUsage">oslc_sysmlv2:AttributeUsage</a>
    /// </summary>
    let AttributeUsage = _prefixId.prefix "AttributeUsage"
    /// <summary>
    ///   <para>rdfs:label : Behavior^^xsd:string</para>
    ///   <para>rdfs:comment : A Behavior coordinates occurrences of other Behaviors, as well as changes in objects. Behaviors can be decomposed into Steps and be characterized by parameters.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Behavior">oslc_sysmlv2:Behavior</a>
    /// </summary>
    let Behavior = _prefixId.prefix "Behavior"
    /// <summary>
    ///   <para>rdfs:label : BindingConnector^^xsd:string</para>
    ///   <para>rdfs:comment : A BindingConnector is a binary Connector that requires its relatedFeatures to identify the same things (have the same values).^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#BindingConnector">oslc_sysmlv2:BindingConnector</a>
    /// </summary>
    let BindingConnector = _prefixId.prefix "BindingConnector"
    /// <summary>
    ///   <para>rdfs:label : BindingConnectorAsUsage^^xsd:string</para>
    ///   <para>rdfs:comment : A BindingConnectorAsUsage is both a BindingConnector and a ConnectorAsUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#BindingConnectorAsUsage">oslc_sysmlv2:BindingConnectorAsUsage</a>
    /// </summary>
    let BindingConnectorAsUsage = _prefixId.prefix "BindingConnectorAsUsage"
    /// <summary>
    ///   <para>rdfs:label : BooleanExpression^^xsd:string</para>
    ///   <para>rdfs:comment : A BooleanExpression is a Boolean-valued Expression whose type is a Predicate. It represents a logical condition resulting from the evaluation of the Predicate.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#BooleanExpression">oslc_sysmlv2:BooleanExpression</a>
    /// </summary>
    let BooleanExpression = _prefixId.prefix "BooleanExpression"
    /// <summary>
    ///   <para>rdfs:label : CalculationDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : A CalculationDefinition is an ActionDefinition that also defines a Function producing a result.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#CalculationDefinition">oslc_sysmlv2:CalculationDefinition</a>
    /// </summary>
    let CalculationDefinition = _prefixId.prefix "CalculationDefinition"
    /// <summary>
    ///   <para>rdfs:label : CalculationUsage^^xsd:string</para>
    ///   <para>rdfs:comment : A CalculationUsage is an ActionUsage that is also an Expression, and, so, is typed by a Function. Nominally, if the type is a CalculationDefinition, a CalculationUsage is a Usage of that CalculationDefinition within a system. However, other kinds of kernel Functions are also allowed, to permit use of Functions from the Kernel Model Libraries.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#CalculationUsage">oslc_sysmlv2:CalculationUsage</a>
    /// </summary>
    let CalculationUsage = _prefixId.prefix "CalculationUsage"
    /// <summary>
    ///   <para>rdfs:label : CaseDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : A CaseDefinition is a CalculationDefinition for a process, often involving collecting evidence or data, relative to a subject, possibly involving the collaboration of one or more other actors, producing a result that meets an objective.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#CaseDefinition">oslc_sysmlv2:CaseDefinition</a>
    /// </summary>
    let CaseDefinition = _prefixId.prefix "CaseDefinition"
    /// <summary>
    ///   <para>rdfs:label : CaseUsage^^xsd:string</para>
    ///   <para>rdfs:comment : A CaseUsage is a Usage of a CaseDefinition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#CaseUsage">oslc_sysmlv2:CaseUsage</a>
    /// </summary>
    let CaseUsage = _prefixId.prefix "CaseUsage"
    /// <summary>
    ///   <para>rdfs:label : Class^^xsd:string</para>
    ///   <para>rdfs:comment : A Class is a Classifier of things (in the universe) that can be distinguished without regard to how they are related to other things (via Features). This means multiple things classified by the same Class can be distinguished, even when they are related other things in exactly the same way.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Class">oslc_sysmlv2:Class</a>
    /// </summary>
    let Class = _prefixId.prefix "Class"
    /// <summary>
    ///   <para>rdfs:label : Classifier^^xsd:string</para>
    ///   <para>rdfs:comment : A Classifier is a Type that classifies:.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Classifier">oslc_sysmlv2:Classifier</a>
    /// </summary>
    let Classifier = _prefixId.prefix "Classifier"
    /// <summary>
    ///   <para>rdfs:label : CollectExpression^^xsd:string</para>
    ///   <para>rdfs:comment : A CollectExpression is an OperatorExpression whose operator is "collect", which resolves to the Function ControlFunctions::collect from the Kernel Functions Library.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#CollectExpression">oslc_sysmlv2:CollectExpression</a>
    /// </summary>
    let CollectExpression = _prefixId.prefix "CollectExpression"
    /// <summary>
    ///   <para>rdfs:label : Comment^^xsd:string</para>
    ///   <para>rdfs:comment : A Comment is an AnnotatingElement whose body in some way describes its annotatedElements.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Comment">oslc_sysmlv2:Comment</a>
    /// </summary>
    let Comment = _prefixId.prefix "Comment"
    /// <summary>
    ///   <para>rdfs:label : ConcernDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : A ConcernDefinition is a RequirementDefinition that one or more stakeholders may be interested in having addressed. These stakeholders are identified by the ownedStakeholdersof the ConcernDefinition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#ConcernDefinition">oslc_sysmlv2:ConcernDefinition</a>
    /// </summary>
    let ConcernDefinition = _prefixId.prefix "ConcernDefinition"
    /// <summary>
    ///   <para>rdfs:label : ConcernUsage^^xsd:string</para>
    ///   <para>rdfs:comment : A ConcernUsage is a Usage of a ConcernDefinition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#ConcernUsage">oslc_sysmlv2:ConcernUsage</a>
    /// </summary>
    let ConcernUsage = _prefixId.prefix "ConcernUsage"
    /// <summary>
    ///   <para>rdfs:label : ConjugatedPortDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : A ConjugatedPortDefinition is a PortDefinition that is a PortDefinition of its original PortDefinition. That is, a ConjugatedPortDefinition inherits all the features of the original PortDefinition, but input flows of the original PortDefinition become outputs on the ConjugatedPortDefinition and output flows of the original PortDefinition become inputs on the ConjugatedPortDefinition. Every PortDefinition (that is not itself a ConjugatedPortDefinition) has exactly one corresponding ConjugatedPortDefinition, whose effective name is the name of the originalPortDefinition, with the character ~ prepended.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#ConjugatedPortDefinition">oslc_sysmlv2:ConjugatedPortDefinition</a>
    /// </summary>
    let ConjugatedPortDefinition = _prefixId.prefix "ConjugatedPortDefinition"
    /// <summary>
    ///   <para>rdfs:label : ConjugatedPortTyping^^xsd:string</para>
    ///   <para>rdfs:comment : A ConjugatedPortTyping is a FeatureTyping whose type is a ConjugatedPortDefinition. (This relationship is intended to be an abstract-syntax marker for a special surface notation for conjugated typing of ports.).^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#ConjugatedPortTyping">oslc_sysmlv2:ConjugatedPortTyping</a>
    /// </summary>
    let ConjugatedPortTyping = _prefixId.prefix "ConjugatedPortTyping"
    /// <summary>
    ///   <para>rdfs:label : Conjugation^^xsd:string</para>
    ///   <para>rdfs:comment : Conjugation is a Relationship between two types in which the conjugatedType inherits all the Features of the originalType, but with all input and output Features reversed. That is, any Features with a direction in relative to the originalType are considered to have an effective direction of out relative to the conjugatedType and, similarly, Features with direction out in the originalType are considered to have an effective direction of in in the conjugatedType. Features with direction inout, or with no direction, in the originalType, are inherited without change.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Conjugation">oslc_sysmlv2:Conjugation</a>
    /// </summary>
    let Conjugation = _prefixId.prefix "Conjugation"
    /// <summary>
    ///   <para>rdfs:label : ConnectionDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : A ConnectionDefinition is a PartDefinition that is also an AssociationStructure. The end Features of a ConnectionDefinition must be Usages.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#ConnectionDefinition">oslc_sysmlv2:ConnectionDefinition</a>
    /// </summary>
    let ConnectionDefinition = _prefixId.prefix "ConnectionDefinition"
    /// <summary>
    ///   <para>rdfs:label : ConnectionUsage^^xsd:string</para>
    ///   <para>rdfs:comment : A ConnectionUsage is a ConnectorAsUsage that is also a PartUsage. Nominally, if its type is a ConnectionDefinition, then a ConnectionUsage is a Usage of that ConnectionDefinition, representing a connection between parts of a system. However, other kinds of kernel AssociationStructures are also allowed, to permit use of AssociationStructures from the Kernel Model Libraries.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#ConnectionUsage">oslc_sysmlv2:ConnectionUsage</a>
    /// </summary>
    let ConnectionUsage = _prefixId.prefix "ConnectionUsage"
    /// <summary>
    ///   <para>rdfs:label : Connector^^xsd:string</para>
    ///   <para>rdfs:comment : A Connector is a usage of Associations, with links restricted according to instances of the Type in which they are used (domain of the Connector). The associations of the Connector restrict what kinds of things might be linked. The Connector further restricts these links to be between values of Features on instances of its domain.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Connector">oslc_sysmlv2:Connector</a>
    /// </summary>
    let Connector = _prefixId.prefix "Connector"
    /// <summary>
    ///   <para>rdfs:label : ConnectorAsUsage^^xsd:string</para>
    ///   <para>rdfs:comment : A ConnectorAsUsage is both a Connector and a Usage. ConnectorAsUsage cannot itself be instantiated in a SysML model, but it is the base class for the concrete classes BindingConnectorAsUsage, SuccessionAsUsage and ConnectionUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#ConnectorAsUsage">oslc_sysmlv2:ConnectorAsUsage</a>
    /// </summary>
    let ConnectorAsUsage = _prefixId.prefix "ConnectorAsUsage"
    /// <summary>
    ///   <para>rdfs:label : ConstraintDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : A ConstraintDefinition is an OccurrenceDefinition that is also a Predicate that defines a constraint that may be asserted to hold on a system or part of a system.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#ConstraintDefinition">oslc_sysmlv2:ConstraintDefinition</a>
    /// </summary>
    let ConstraintDefinition = _prefixId.prefix "ConstraintDefinition"
    /// <summary>
    ///   <para>rdfs:label : ConstraintUsage^^xsd:string</para>
    ///   <para>rdfs:comment : A ConstraintUsage is an OccurrenceUsage that is also a BooleanExpression, and, so, is typed by a Predicate. Nominally, if the type is a ConstraintDefinition, a ConstraintUsage is a Usage of that ConstraintDefinition. However, other kinds of kernel Predicates are also allowed, to permit use of Predicates from the Kernel Model Libraries.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#ConstraintUsage">oslc_sysmlv2:ConstraintUsage</a>
    /// </summary>
    let ConstraintUsage = _prefixId.prefix "ConstraintUsage"
    /// <summary>
    ///   <para>rdfs:label : ControlNode^^xsd:string</para>
    ///   <para>rdfs:comment : A ControlNode is an ActionUsage that does not have any inherent behavior but provides constraints on incoming and outgoing Successions that are used to control other Actions. A ControlNode must be a composite owned usage of an ActionDefinition or ActionUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#ControlNode">oslc_sysmlv2:ControlNode</a>
    /// </summary>
    let ControlNode = _prefixId.prefix "ControlNode"
    /// <summary>
    ///   <para>rdfs:label : DataType^^xsd:string</para>
    ///   <para>rdfs:comment : A DataType is a Classifier of things (in the universe) that can only be distinguished by how they are related to other things (via Features). This means multiple things classified by the same DataType.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#DataType">oslc_sysmlv2:DataType</a>
    /// </summary>
    let DataType = _prefixId.prefix "DataType"
    /// <summary>
    ///   <para>rdfs:label : DecisionNode^^xsd:string</para>
    ///   <para>rdfs:comment : A DecisionNode is a ControlNode that makes a selection from its outgoing Successions.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#DecisionNode">oslc_sysmlv2:DecisionNode</a>
    /// </summary>
    let DecisionNode = _prefixId.prefix "DecisionNode"
    /// <summary>
    ///   <para>rdfs:label : Definition^^xsd:string</para>
    ///   <para>rdfs:comment : A Definition is a Classifier of Usages. The actual kinds of Definition that may appear in a model are given by the subclasses of Definition (possibly as extended with user-defined SemanticMetadata).^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Definition">oslc_sysmlv2:Definition</a>
    /// </summary>
    let Definition = _prefixId.prefix "Definition"
    /// <summary>
    ///   <para>rdfs:label : Dependency^^xsd:string</para>
    ///   <para>rdfs:comment : A Dependency is a Relationship that indicates that one or more client Elements require one more supplier Elements for their complete specification. In general, this means that a change to one of the supplier Elements may necessitate a change to, or re-specification of, the client Elements.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Dependency">oslc_sysmlv2:Dependency</a>
    /// </summary>
    let Dependency = _prefixId.prefix "Dependency"
    /// <summary>
    ///   <para>rdfs:label : Differencing^^xsd:string</para>
    ///   <para>rdfs:comment : Differencing is a Relationship that makes its differencingType one of the differencingTypes of its typeDifferenced.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Differencing">oslc_sysmlv2:Differencing</a>
    /// </summary>
    let Differencing = _prefixId.prefix "Differencing"
    /// <summary>
    ///   <para>rdfs:label : Disjoining^^xsd:string</para>
    ///   <para>rdfs:comment : A Disjoining is a Relationship between Types asserted to have interpretations that are not shared (disjoint) between them, identified as typeDisjoined and disjoiningType. For example, a Classifier for mammals is disjoint from a Classifier for minerals, and a Feature for people's parents is disjoint from a Feature for their children.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Disjoining">oslc_sysmlv2:Disjoining</a>
    /// </summary>
    let Disjoining = _prefixId.prefix "Disjoining"
    /// <summary>
    ///   <para>rdfs:label : Documentation^^xsd:string</para>
    ///   <para>rdfs:comment : Documentation is a Comment that specifically documents a documentedElement, which must be its owner.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Documentation">oslc_sysmlv2:Documentation</a>
    /// </summary>
    let Documentation = _prefixId.prefix "Documentation"
    /// <summary>
    ///   <para>rdfs:label : Element^^xsd:string</para>
    ///   <para>rdfs:comment : An Element is a constituent of a model that is uniquely identified relative to all other Elements. It can have Relationships with other Elements. Some of these Relationships might imply ownership of other Elements, which means that if an Element is deleted from a model, then so are all the Elements that it owns.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Element">oslc_sysmlv2:Element</a>
    /// </summary>
    let Element = _prefixId.prefix "Element"
    /// <summary>
    ///   <para>rdfs:label : ElementFilterMembership^^xsd:string</para>
    ///   <para>rdfs:comment : ElementFilterMembership is a Membership between a Namespace and a model-level evaluable Boolean-valued Expression, asserting that imported members of the Namespace should be filtered using the condition Expression. A general Namespace does not define any specific filtering behavior, but such behavior may be defined for various specialized kinds of Namespaces.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#ElementFilterMembership">oslc_sysmlv2:ElementFilterMembership</a>
    /// </summary>
    let ElementFilterMembership = _prefixId.prefix "ElementFilterMembership"
    /// <summary>
    ///   <para>rdfs:label : EndFeatureMembership^^xsd:string</para>
    ///   <para>rdfs:comment : EndFeatureMembership is a FeatureMembership that requires its memberFeature be owned and have isEnd = true.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#EndFeatureMembership">oslc_sysmlv2:EndFeatureMembership</a>
    /// </summary>
    let EndFeatureMembership = _prefixId.prefix "EndFeatureMembership"
    /// <summary>
    ///   <para>rdfs:label : EnumerationDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : An EnumerationDefinition is an AttributeDefinition all of whose instances are given by an explicit list of enumeratedValues. This is realized by requiring that the EnumerationDefinition have isVariation = true, with the enumeratedValues being its variants.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#EnumerationDefinition">oslc_sysmlv2:EnumerationDefinition</a>
    /// </summary>
    let EnumerationDefinition = _prefixId.prefix "EnumerationDefinition"
    /// <summary>
    ///   <para>rdfs:label : EnumerationUsage^^xsd:string</para>
    ///   <para>rdfs:comment : An EnumerationUsage is an AttributeUsage whose attributeDefinition is an EnumerationDefinition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#EnumerationUsage">oslc_sysmlv2:EnumerationUsage</a>
    /// </summary>
    let EnumerationUsage = _prefixId.prefix "EnumerationUsage"
    /// <summary>
    ///   <para>rdfs:label : EventOccurrenceUsage^^xsd:string</para>
    ///   <para>rdfs:comment : An EventOccurrenceUsage is an OccurrenceUsage that represents another OccurrenceUsage occurring as a suboccurrence of the containing occurrence of the EventOccurrenceUsage. Unless it is the EventOccurrenceUsage itself, the referenced OccurrenceUsage is related to the EventOccurrenceUsage by a ReferenceSubsetting Relationship.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#EventOccurrenceUsage">oslc_sysmlv2:EventOccurrenceUsage</a>
    /// </summary>
    let EventOccurrenceUsage = _prefixId.prefix "EventOccurrenceUsage"
    /// <summary>
    ///   <para>rdfs:label : ExhibitStateUsage^^xsd:string</para>
    ///   <para>rdfs:comment : An ExhibitStateUsage is a StateUsage that represents the exhibiting of a StateUsage. Unless it is the StateUsage itself, the StateUsage to be exhibited is related to the ExhibitStateUsage by a ReferenceSubsetting Relationship. An ExhibitStateUsage is also a PerformActionUsage, with its exhibitedState as the performedAction.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#ExhibitStateUsage">oslc_sysmlv2:ExhibitStateUsage</a>
    /// </summary>
    let ExhibitStateUsage = _prefixId.prefix "ExhibitStateUsage"
    /// <summary>
    ///   <para>rdfs:label : Expose^^xsd:string</para>
    ///   <para>rdfs:comment : An Expose is an Import of Memberships into a ViewUsage that provide the Elements to be included in a view. Visibility is always ignored for an Expose (i.e., isImportAll = true).^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Expose">oslc_sysmlv2:Expose</a>
    /// </summary>
    let Expose = _prefixId.prefix "Expose"
    /// <summary>
    ///   <para>rdfs:label : Expression^^xsd:string</para>
    ///   <para>rdfs:comment : An Expression is a Step that is typed by a Function. An Expression that also has a Function as its featuringType is a computational step within that Function. An Expression always has a single result parameter, which redefines the result parameter of its defining function. This allows Expressions to be interconnected in tree structures, in which inputs to each Expression in the tree are determined as the results of other Expression in the tree.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Expression">oslc_sysmlv2:Expression</a>
    /// </summary>
    let Expression = _prefixId.prefix "Expression"
    /// <summary>
    ///   <para>rdfs:label : Feature^^xsd:string</para>
    ///   <para>rdfs:comment : A Feature is a Type that classifies relations between multiple things (in the universe). The domain of the relation is the intersection of the featuringTypes of the Feature. (The domain of a Feature with no featuringTyps is implicitly the most general Type Base::Anything from the Kernel Semantic Library.) The co-domain of the relation is the intersection of the types of the Feature.
    ///
    /// .^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Feature">oslc_sysmlv2:Feature</a>
    /// </summary>
    let Feature = _prefixId.prefix "Feature"
    /// <summary>
    ///   <para>rdfs:label : FeatureChainExpression^^xsd:string</para>
    ///   <para>rdfs:comment : A FeatureChainExpression is an OperatorExpression whose operator is ".", which resolves to the Function ControlFunctions::'.' from the Kernel Functions Library. It evaluates to the result of chaining the result Feature of its single argument Expression with its targetFeature.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#FeatureChainExpression">oslc_sysmlv2:FeatureChainExpression</a>
    /// </summary>
    let FeatureChainExpression = _prefixId.prefix "FeatureChainExpression"
    /// <summary>
    ///   <para>rdfs:label : FeatureChaining^^xsd:string</para>
    ///   <para>rdfs:comment : FeatureChaining is a Relationship that makes its target Feature one of the chainingFeatures of its owning Feature.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#FeatureChaining">oslc_sysmlv2:FeatureChaining</a>
    /// </summary>
    let FeatureChaining = _prefixId.prefix "FeatureChaining"
    /// <summary>
    ///   <para>rdfs:label : FeatureDirectionKind^^xsd:string</para>
    ///   <para>rdfs:comment : FeatureDirectionKind enumerates the possible kinds of direction that a Feature may be given as a member of a Type.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#FeatureDirectionKind">oslc_sysmlv2:FeatureDirectionKind</a>
    /// </summary>
    let FeatureDirectionKind = _prefixId.prefix "FeatureDirectionKind"
    /// <summary>
    ///   <para>rdfs:label : FeatureInverting^^xsd:string</para>
    ///   <para>rdfs:comment : A FeatureInverting is a Relationship between Features asserting that their interpretations (sequences) are the reverse of each other, identified as featureInverted and invertingFeature. For example, a Feature identifying each person's parents is the inverse of a Feature identifying each person's children. A person identified as a parent of another will identify that other as one of their children.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#FeatureInverting">oslc_sysmlv2:FeatureInverting</a>
    /// </summary>
    let FeatureInverting = _prefixId.prefix "FeatureInverting"
    /// <summary>
    ///   <para>rdfs:label : FeatureMembership^^xsd:string</para>
    ///   <para>rdfs:comment : A FeatureMembership is an OwningMembership between a Feature in an owningType that is also a Featuring Relationship between the Feature and the Type, in which the featuringType is the source and the featureOfType is the target. A FeatureMembership is always owned by its owningType, which is the featuringType for the FeatureMembership considered as a Featuring.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#FeatureMembership">oslc_sysmlv2:FeatureMembership</a>
    /// </summary>
    let FeatureMembership = _prefixId.prefix "FeatureMembership"
    /// <summary>
    ///   <para>rdfs:label : FeatureReferenceExpression^^xsd:string</para>
    ///   <para>rdfs:comment : A FeatureReferenceExpression is an Expression whose result is bound to a referent Feature.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#FeatureReferenceExpression">oslc_sysmlv2:FeatureReferenceExpression</a>
    /// </summary>
    let FeatureReferenceExpression = _prefixId.prefix "FeatureReferenceExpression"
    /// <summary>
    ///   <para>rdfs:label : FeatureTyping^^xsd:string</para>
    ///   <para>rdfs:comment : FeatureTyping is Specialization in which the specific Type is a Feature. This means the set of instances of the (specific) typedFeature is a subset of the set of instances of the (general) type. In the simplest case, the type is a Classifier, whereupon the typedFeature has values that are instances of the Classifier.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#FeatureTyping">oslc_sysmlv2:FeatureTyping</a>
    /// </summary>
    let FeatureTyping = _prefixId.prefix "FeatureTyping"
    /// <summary>
    ///   <para>rdfs:label : FeatureValue^^xsd:string</para>
    ///   <para>rdfs:comment : A FeatureValue is a Membership that identifies a particular member Expression that provides the value of the Feature that owns the FeatureValue. The value is specified as either a bound value or an initial value, and as either a concrete or default value. A Feature can have at most one FeatureValue.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#FeatureValue">oslc_sysmlv2:FeatureValue</a>
    /// </summary>
    let FeatureValue = _prefixId.prefix "FeatureValue"
    /// <summary>
    ///   <para>rdfs:label : Featuring^^xsd:string</para>
    ///   <para>rdfs:comment : Featuring is a Relationship between a Type and a Feature that is featured by that Type. It asserts that every instance in the domain of the feature must be classified by the type.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Featuring">oslc_sysmlv2:Featuring</a>
    /// </summary>
    let Featuring = _prefixId.prefix "Featuring"
    /// <summary>
    ///   <para>rdfs:label : FlowConnectionDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : A FlowConnectionDefinition is a ConnectionDefinition and ActionDefinition that is also an Interaction representing flows between Usages.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#FlowConnectionDefinition">oslc_sysmlv2:FlowConnectionDefinition</a>
    /// </summary>
    let FlowConnectionDefinition = _prefixId.prefix "FlowConnectionDefinition"
    /// <summary>
    ///   <para>rdfs:label : FlowConnectionUsage^^xsd:string</para>
    ///   <para>rdfs:comment : A FlowConnectionUsage is a ConnectionUsage that is also an ItemFlow.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#FlowConnectionUsage">oslc_sysmlv2:FlowConnectionUsage</a>
    /// </summary>
    let FlowConnectionUsage = _prefixId.prefix "FlowConnectionUsage"
    /// <summary>
    ///   <para>rdfs:label : ForLoopActionUsage^^xsd:string</para>
    ///   <para>rdfs:comment : A ForLoopActionUsage is a LoopActionUsage that specifies that its bodyAction ActionUsage should be performed once for each value, in order, from the sequence of values obtained as the result of the seqArgument Expression, with the loopVariable set to the value for each iteration.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#ForLoopActionUsage">oslc_sysmlv2:ForLoopActionUsage</a>
    /// </summary>
    let ForLoopActionUsage = _prefixId.prefix "ForLoopActionUsage"
    /// <summary>
    ///   <para>rdfs:label : ForkNode^^xsd:string</para>
    ///   <para>rdfs:comment : A ForkNode is a ControlNode that must be followed by successor Actions as given by all its outgoing Successions.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#ForkNode">oslc_sysmlv2:ForkNode</a>
    /// </summary>
    let ForkNode = _prefixId.prefix "ForkNode"
    /// <summary>
    ///   <para>rdfs:label : FramedConcernMembership^^xsd:string</para>
    ///   <para>rdfs:comment : A FramedConcernMembership is a RequirementConstraintMembership for a framed ConcernUsage of a RequirementDefinition or RequirementUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#FramedConcernMembership">oslc_sysmlv2:FramedConcernMembership</a>
    /// </summary>
    let FramedConcernMembership = _prefixId.prefix "FramedConcernMembership"
    /// <summary>
    ///   <para>rdfs:label : Function^^xsd:string</para>
    ///   <para>rdfs:comment : A Function is a Behavior that has an out parameter that is identified as its result. A Function represents the performance of a calculation that produces the values of its result parameter. This calculation may be decomposed into Expressions that are steps of the Function.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Function">oslc_sysmlv2:Function</a>
    /// </summary>
    let Function = _prefixId.prefix "Function"
    /// <summary>
    ///   <para>rdfs:label : IfActionUsage^^xsd:string</para>
    ///   <para>rdfs:comment : An IfActionUsage is an ActionUsage that specifies that the thenAction ActionUsage should be performed if the result of the ifArgument Expression is true. It may also optionally specify an elseAction ActionUsage that is performed if the result of the ifArgument is false.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#IfActionUsage">oslc_sysmlv2:IfActionUsage</a>
    /// </summary>
    let IfActionUsage = _prefixId.prefix "IfActionUsage"
    /// <summary>
    ///   <para>rdfs:label : Import^^xsd:string</para>
    ///   <para>rdfs:comment : An Import is an Relationship between its importOwningNamespace and either a Membership (for a MembershipImport) or another Namespace (for a NamespaceImport), which determines a set of Memberships that become importedMemberships of the importOwningNamespace. If isImportAll = false (the default), then only public Memberships are considered "visible". If isImportAll = true, then all Memberships are considered "visible", regardless of their declared visibility. If isRecursive = true, then visible Memberships are also recursively imported from owned sub-Namespaces.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Import">oslc_sysmlv2:Import</a>
    /// </summary>
    let Import = _prefixId.prefix "Import"
    /// <summary>
    ///   <para>rdfs:label : IncludeUseCaseUsage^^xsd:string</para>
    ///   <para>rdfs:comment : An IncludeUseCaseUsage is a UseCaseUsage that represents the inclusion of a UseCaseUsage by a UseCaseDefinition or UseCaseUsage. Unless it is the IncludeUseCaseUsage itself, the UseCaseUsage to be included is related to the includedUseCase by a ReferenceSubsetting Relationship. An IncludeUseCaseUsage is also a PerformActionUsage, with its useCaseIncluded as the performedAction.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#IncludeUseCaseUsage">oslc_sysmlv2:IncludeUseCaseUsage</a>
    /// </summary>
    let IncludeUseCaseUsage = _prefixId.prefix "IncludeUseCaseUsage"
    /// <summary>
    ///   <para>rdfs:label : Interaction^^xsd:string</para>
    ///   <para>rdfs:comment : An Interaction is a Behavior that is also an Association, providing a context for multiple objects that have behaviors that impact one another.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Interaction">oslc_sysmlv2:Interaction</a>
    /// </summary>
    let Interaction = _prefixId.prefix "Interaction"
    /// <summary>
    ///   <para>rdfs:label : InterfaceDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : An InterfaceDefinition is a ConnectionDefinition all of whose ends are PortUsages, defining an interface between elements that interact through such ports.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#InterfaceDefinition">oslc_sysmlv2:InterfaceDefinition</a>
    /// </summary>
    let InterfaceDefinition = _prefixId.prefix "InterfaceDefinition"
    /// <summary>
    ///   <para>rdfs:label : InterfaceUsage^^xsd:string</para>
    ///   <para>rdfs:comment : An InterfaceUsage is a Usage of an InterfaceDefinition to represent an interface connecting parts of a system through specific ports.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#InterfaceUsage">oslc_sysmlv2:InterfaceUsage</a>
    /// </summary>
    let InterfaceUsage = _prefixId.prefix "InterfaceUsage"
    /// <summary>
    ///   <para>rdfs:label : Intersecting^^xsd:string</para>
    ///   <para>rdfs:comment : Intersecting is a Relationship that makes its intersectingType one of the intersectingTypes of its typeIntersected.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Intersecting">oslc_sysmlv2:Intersecting</a>
    /// </summary>
    let Intersecting = _prefixId.prefix "Intersecting"
    /// <summary>
    ///   <para>rdfs:label : Invariant^^xsd:string</para>
    ///   <para>rdfs:comment : An Invariant is a BooleanExpression that is asserted to have a specific Boolean result value. If isNegated = false, then the result is asserted to be true. If isNegated = true, then the result is asserted to be false.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Invariant">oslc_sysmlv2:Invariant</a>
    /// </summary>
    let Invariant = _prefixId.prefix "Invariant"
    /// <summary>
    ///   <para>rdfs:label : InvocationExpression^^xsd:string</para>
    ///   <para>rdfs:comment : An InvocationExpression is an Expression each of whose input parameters are bound to the result of an argument Expression.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#InvocationExpression">oslc_sysmlv2:InvocationExpression</a>
    /// </summary>
    let InvocationExpression = _prefixId.prefix "InvocationExpression"
    /// <summary>
    ///   <para>rdfs:label : ItemDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : An ItemDefinition is an OccurrenceDefinition of the Structure of things that may themselves be systems or parts of systems, but may also be things that are acted on by a system or parts of a system, but which do not necessarily perform actions themselves. This includes items that can be exchanged between parts of a system, such as water or electrical signals.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#ItemDefinition">oslc_sysmlv2:ItemDefinition</a>
    /// </summary>
    let ItemDefinition = _prefixId.prefix "ItemDefinition"
    /// <summary>
    ///   <para>rdfs:label : ItemFeature^^xsd:string</para>
    ///   <para>rdfs:comment : An ItemFeature is the ownedFeature of an ItemFlow that identifies the things carried by the kinds of transfers that are instances of the ItemFlow.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#ItemFeature">oslc_sysmlv2:ItemFeature</a>
    /// </summary>
    let ItemFeature = _prefixId.prefix "ItemFeature"
    /// <summary>
    ///   <para>rdfs:label : ItemFlow^^xsd:string</para>
    ///   <para>rdfs:comment : An ItemFlow is a Step that represents the transfer of objects or data values from one Feature to another. ItemFlows can take non-zero time to complete.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#ItemFlow">oslc_sysmlv2:ItemFlow</a>
    /// </summary>
    let ItemFlow = _prefixId.prefix "ItemFlow"
    /// <summary>
    ///   <para>rdfs:label : ItemFlowEnd^^xsd:string</para>
    ///   <para>rdfs:comment : An ItemFlowEnd is a Feature that is one of the connectorEnds giving the source or target of an ItemFlow. For ItemFlows typed by FlowTransfer or its specializations, ItemFlowEnds must have exactly one ownedFeature, which redefines Transfer::source::sourceOutput or Transfer::target::targetInput and redefines the corresponding feature of the relatedElement for its end.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#ItemFlowEnd">oslc_sysmlv2:ItemFlowEnd</a>
    /// </summary>
    let ItemFlowEnd = _prefixId.prefix "ItemFlowEnd"
    /// <summary>
    ///   <para>rdfs:label : ItemUsage^^xsd:string</para>
    ///   <para>rdfs:comment : An ItemUsage is a ItemUsage whose definition is a Structure. Nominally, if the definition is an ItemDefinition, an ItemUsage is a ItemUsage of that ItemDefinition within a system. However, other kinds of Kernel Structures are also allowed, to permit use of Structures from the Kernel Model Libraries.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#ItemUsage">oslc_sysmlv2:ItemUsage</a>
    /// </summary>
    let ItemUsage = _prefixId.prefix "ItemUsage"
    /// <summary>
    ///   <para>rdfs:label : JoinNode^^xsd:string</para>
    ///   <para>rdfs:comment : A JoinNode is a ControlNode that waits for the completion of all the predecessor Actions given by incoming Successions.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#JoinNode">oslc_sysmlv2:JoinNode</a>
    /// </summary>
    let JoinNode = _prefixId.prefix "JoinNode"
    /// <summary>
    ///   <para>rdfs:label : LibraryPackage^^xsd:string</para>
    ///   <para>rdfs:comment : A LibraryPackage is a Package that is the container for a model library. A LibraryPackage is itself a library Element as are all Elements that are directly or indirectly contained in it.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#LibraryPackage">oslc_sysmlv2:LibraryPackage</a>
    /// </summary>
    let LibraryPackage = _prefixId.prefix "LibraryPackage"
    /// <summary>
    ///   <para>rdfs:label : LifeClass^^xsd:string</para>
    ///   <para>rdfs:comment : A LifeClass is a Class that specializes both the Class Occurrences::Life from the Kernel Semantic Library and a single OccurrenceDefinition, and has a multiplicity of 0..1. This constrains the OccurrenceDefinition being specialized to have at most one instance that is a complete Life.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#LifeClass">oslc_sysmlv2:LifeClass</a>
    /// </summary>
    let LifeClass = _prefixId.prefix "LifeClass"
    /// <summary>
    ///   <para>rdfs:label : LiteralBoolean^^xsd:string</para>
    ///   <para>rdfs:comment : LiteralBoolean is a LiteralExpression that provides a Boolean value as a result. Its result parameter must have type Boolean.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#LiteralBoolean">oslc_sysmlv2:LiteralBoolean</a>
    /// </summary>
    let LiteralBoolean = _prefixId.prefix "LiteralBoolean"
    /// <summary>
    ///   <para>rdfs:label : LiteralExpression^^xsd:string</para>
    ///   <para>rdfs:comment : A LiteralExpression is an Expression that provides a basic DataValue as a result.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#LiteralExpression">oslc_sysmlv2:LiteralExpression</a>
    /// </summary>
    let LiteralExpression = _prefixId.prefix "LiteralExpression"
    /// <summary>
    ///   <para>rdfs:label : LiteralInfinity^^xsd:string</para>
    ///   <para>rdfs:comment : A LiteralInfinity is a LiteralExpression that provides the positive infinity value (*). It's result must have the type Positive.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#LiteralInfinity">oslc_sysmlv2:LiteralInfinity</a>
    /// </summary>
    let LiteralInfinity = _prefixId.prefix "LiteralInfinity"
    /// <summary>
    ///   <para>rdfs:label : LiteralInteger^^xsd:string</para>
    ///   <para>rdfs:comment : A LiteralInteger is a LiteralExpression that provides an Integer value as a result. Its result parameter must have the type Integer.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#LiteralInteger">oslc_sysmlv2:LiteralInteger</a>
    /// </summary>
    let LiteralInteger = _prefixId.prefix "LiteralInteger"
    /// <summary>
    ///   <para>rdfs:label : LiteralRational^^xsd:string</para>
    ///   <para>rdfs:comment : A LiteralRational is a LiteralExpression that provides a Rational value as a result. Its result parameter must have the type Rational.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#LiteralRational">oslc_sysmlv2:LiteralRational</a>
    /// </summary>
    let LiteralRational = _prefixId.prefix "LiteralRational"
    /// <summary>
    ///   <para>rdfs:label : LiteralString^^xsd:string</para>
    ///   <para>rdfs:comment : A LiteralString is a LiteralExpression that provides a String value as a result. Its result parameter must have the type String.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#LiteralString">oslc_sysmlv2:LiteralString</a>
    /// </summary>
    let LiteralString = _prefixId.prefix "LiteralString"
    /// <summary>
    ///   <para>rdfs:label : LoopActionUsage^^xsd:string</para>
    ///   <para>rdfs:comment : A LoopActionUsage is an ActionUsage that specifies that its bodyAction should be performed repeatedly. Its subclasses WhileLoopActionUsage and ForLoopActionUsage provide different ways to determine how many times the bodyAction should be performed.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#LoopActionUsage">oslc_sysmlv2:LoopActionUsage</a>
    /// </summary>
    let LoopActionUsage = _prefixId.prefix "LoopActionUsage"
    /// <summary>
    ///   <para>rdfs:label : Membership^^xsd:string</para>
    ///   <para>rdfs:comment : A Membership is a Relationship between a Namespace and an Element that indicates the Element is a member of (i.e., is contained in) the Namespace. Any memberNames specify how the memberElement is identified in the Namespace and the visibility specifies whether or not the memberElement is publicly visible from outside the Namespace.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Membership">oslc_sysmlv2:Membership</a>
    /// </summary>
    let Membership = _prefixId.prefix "Membership"
    /// <summary>
    ///   <para>rdfs:label : MembershipExpose^^xsd:string</para>
    ///   <para>rdfs:comment : A MembershipExpose is an Expose  that exposes a specific importedMembership and, if isRecursive = true, additional Memberships recursively.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#MembershipExpose">oslc_sysmlv2:MembershipExpose</a>
    /// </summary>
    let MembershipExpose = _prefixId.prefix "MembershipExpose"
    /// <summary>
    ///   <para>rdfs:label : MembershipImport^^xsd:string</para>
    ///   <para>rdfs:comment : A MembershipImport is an Import that imports its importedMembership into the importOwningNamespace. If isRecursive = true and the memberElement of the importedMembership is a Namespace, then the equivalent of a recursive NamespaceImport is also performed on that Namespace.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#MembershipImport">oslc_sysmlv2:MembershipImport</a>
    /// </summary>
    let MembershipImport = _prefixId.prefix "MembershipImport"
    /// <summary>
    ///   <para>rdfs:label : MergeNode^^xsd:string</para>
    ///   <para>rdfs:comment : A MergeNode is a ControlNode that asserts the merging of its incoming Successions. A MergeNode may have at most one outgoing Successions.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#MergeNode">oslc_sysmlv2:MergeNode</a>
    /// </summary>
    let MergeNode = _prefixId.prefix "MergeNode"
    /// <summary>
    ///   <para>rdfs:label : Metaclass^^xsd:string</para>
    ///   <para>rdfs:comment : A Metaclass is a Structure used to type MetadataFeatures.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Metaclass">oslc_sysmlv2:Metaclass</a>
    /// </summary>
    let Metaclass = _prefixId.prefix "Metaclass"
    /// <summary>
    ///   <para>rdfs:label : MetadataAccessExpression^^xsd:string</para>
    ///   <para>rdfs:comment : A MetadataAccessExpression is an Expression whose result is a sequence of instances of Metaclasses representing all the MetadataFeature annotations of the referencedElement. In addition, the sequence includes an instance of the reflective Metaclass corresponding to the MOF class of the referencedElement, with values for all the abstract syntax properties of the referencedElement.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#MetadataAccessExpression">oslc_sysmlv2:MetadataAccessExpression</a>
    /// </summary>
    let MetadataAccessExpression = _prefixId.prefix "MetadataAccessExpression"
    /// <summary>
    ///   <para>rdfs:label : MetadataDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : A MetadataDefinition is an ItemDefinition that is also a Metaclass.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#MetadataDefinition">oslc_sysmlv2:MetadataDefinition</a>
    /// </summary>
    let MetadataDefinition = _prefixId.prefix "MetadataDefinition"
    /// <summary>
    ///   <para>rdfs:label : MetadataFeature^^xsd:string</para>
    ///   <para>rdfs:comment : A MetadataFeature is a Feature that is an AnnotatingElement used to annotate another Element with metadata. It is typed by a Metaclass. All its ownedFeatures must redefine features of its metaclass and any feature bindings must be model-level evaluable.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#MetadataFeature">oslc_sysmlv2:MetadataFeature</a>
    /// </summary>
    let MetadataFeature = _prefixId.prefix "MetadataFeature"
    /// <summary>
    ///   <para>rdfs:label : MetadataUsage^^xsd:string</para>
    ///   <para>rdfs:comment : A  MetadataUsage is a Usage and a MetadataFeature, used to annotate other Elements in a system model with metadata. As a MetadataFeature, its type must be a Metaclass, which will nominally be a MetadataDefinition. However, any kernel Metaclass is also allowed, to permit use of Metaclasses from the Kernel Model Libraries.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#MetadataUsage">oslc_sysmlv2:MetadataUsage</a>
    /// </summary>
    let MetadataUsage = _prefixId.prefix "MetadataUsage"
    /// <summary>
    ///   <para>rdfs:label : Multiplicity^^xsd:string</para>
    ///   <para>rdfs:comment : A Multiplicity is a Feature whose co-domain is a set of natural numbers giving the allowed cardinalities of each typeWithMultiplicity. The cardinality of a Type is defined as follows, depending on whether the Type is a Classifier or Feature.
    /// .^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Multiplicity">oslc_sysmlv2:Multiplicity</a>
    /// </summary>
    let Multiplicity = _prefixId.prefix "Multiplicity"
    /// <summary>
    ///   <para>rdfs:label : MultiplicityRange^^xsd:string</para>
    ///   <para>rdfs:comment : A MultiplicityRange is a Multiplicity whose value is defined to be the (inclusive) range of natural numbers given by the result of a lowerBound Expression and the result of an upperBound Expression. The result of these Expressions shall be of type Natural. If the result of the upperBound Expression is the unbounded value *, then the specified range includes all natural numbers greater than or equal to the lowerBound value. If no lowerBound Expression, then the default is that the lower bound has the same value as the upper bound, except if the upperBound evaluates to *, in which case the default for the lower bound is 0.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#MultiplicityRange">oslc_sysmlv2:MultiplicityRange</a>
    /// </summary>
    let MultiplicityRange = _prefixId.prefix "MultiplicityRange"
    /// <summary>
    ///   <para>rdfs:label : Namespace^^xsd:string</para>
    ///   <para>rdfs:comment : A Namespace is an Element that contains other Elements, known as its members, via Membership Relationships with those Elements. The members of a Namespace may be owned by the Namespace, aliased in the Namespace, or imported into the Namespace via Import Relationships.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Namespace">oslc_sysmlv2:Namespace</a>
    /// </summary>
    let Namespace = _prefixId.prefix "Namespace"
    /// <summary>
    ///   <para>rdfs:label : NamespaceExpose^^xsd:string</para>
    ///   <para>rdfs:comment : A NamespaceExpose is an Expose Relationship that exposes the Memberships of a specific importedNamespace and, if isRecursive = true, additional Memberships recursively.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#NamespaceExpose">oslc_sysmlv2:NamespaceExpose</a>
    /// </summary>
    let NamespaceExpose = _prefixId.prefix "NamespaceExpose"
    /// <summary>
    ///   <para>rdfs:label : NamespaceImport^^xsd:string</para>
    ///   <para>rdfs:comment : A NamespaceImport is an Import that imports Memberships from its importedNamespace into the importOwningNamespace. If  isRecursive = false, then only the visible Memberships of the importedNamespace are imported. If  isRecursive = true, then, in addition, Memberships are recursively imported from any ownedMembers of the importedNamespace that are Namespaces.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#NamespaceImport">oslc_sysmlv2:NamespaceImport</a>
    /// </summary>
    let NamespaceImport = _prefixId.prefix "NamespaceImport"
    /// <summary>
    ///   <para>rdfs:label : NullExpression^^xsd:string</para>
    ///   <para>rdfs:comment : A NullExpression is an Expression that results in a null value.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#NullExpression">oslc_sysmlv2:NullExpression</a>
    /// </summary>
    let NullExpression = _prefixId.prefix "NullExpression"
    /// <summary>
    ///   <para>rdfs:label : ObjectiveMembership^^xsd:string</para>
    ///   <para>rdfs:comment : An ObjectiveMembership is a FeatureMembership that indicates that its ownedObjectiveRequirement is the objective RequirementUsage for its owningType, which must be a CaseDefinition or CaseUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#ObjectiveMembership">oslc_sysmlv2:ObjectiveMembership</a>
    /// </summary>
    let ObjectiveMembership = _prefixId.prefix "ObjectiveMembership"
    /// <summary>
    ///   <para>rdfs:label : OccurrenceDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : An OccurrenceDefinition is a Definition of a Class of individuals that have an independent life over time and potentially an extent over space. This includes both structural things and behaviors that act on such structures.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#OccurrenceDefinition">oslc_sysmlv2:OccurrenceDefinition</a>
    /// </summary>
    let OccurrenceDefinition = _prefixId.prefix "OccurrenceDefinition"
    /// <summary>
    ///   <para>rdfs:label : OccurrenceUsage^^xsd:string</para>
    ///   <para>rdfs:comment : An OccurrenceUsage is a Usage whose types are all Classes. Nominally, if a type is an OccurrenceDefinition, an OccurrenceUsage is a Usage of that OccurrenceDefinition within a system. However, other types of Kernel Classes are also allowed, to permit use of Classes from the Kernel Model Libraries.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#OccurrenceUsage">oslc_sysmlv2:OccurrenceUsage</a>
    /// </summary>
    let OccurrenceUsage = _prefixId.prefix "OccurrenceUsage"
    /// <summary>
    ///   <para>rdfs:label : OperatorExpression^^xsd:string</para>
    ///   <para>rdfs:comment : An OperatorExpression is an InvocationExpression whose function is determined by resolving its operator in the context of one of the standard packages from the Kernel Function Library.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#OperatorExpression">oslc_sysmlv2:OperatorExpression</a>
    /// </summary>
    let OperatorExpression = _prefixId.prefix "OperatorExpression"
    /// <summary>
    ///   <para>rdfs:label : OwningMembership^^xsd:string</para>
    ///   <para>rdfs:comment : An OwningMembership is a Membership that owns its memberElement as a ownedRelatedElement. The ownedMemberElement becomes an ownedMember of the membershipOwningNamespace.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#OwningMembership">oslc_sysmlv2:OwningMembership</a>
    /// </summary>
    let OwningMembership = _prefixId.prefix "OwningMembership"
    /// <summary>
    ///   <para>rdfs:label : Package^^xsd:string</para>
    ///   <para>rdfs:comment : A Package is a Namespace used to group Elements, without any instance-level semantics. It may have one or more model-level evaluable filterCondition Expressions used to filter its importedMemberships. Any imported member must meet all of the filterConditions.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Package">oslc_sysmlv2:Package</a>
    /// </summary>
    let Package = _prefixId.prefix "Package"
    /// <summary>
    ///   <para>rdfs:label : ParameterMembership^^xsd:string</para>
    ///   <para>rdfs:comment : A ParameterMembership is a FeatureMembership that identifies its memberFeature as a parameter, which is always owned, and must have a direction. A ParameterMembership must be owned by a Behavior or a Step.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#ParameterMembership">oslc_sysmlv2:ParameterMembership</a>
    /// </summary>
    let ParameterMembership = _prefixId.prefix "ParameterMembership"
    /// <summary>
    ///   <para>rdfs:label : PartDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : A PartDefinition is an ItemDefinition of a Class of systems or parts of systems. Note that all parts may be considered items for certain purposes, but not all items are parts that can perform actions within a system.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#PartDefinition">oslc_sysmlv2:PartDefinition</a>
    /// </summary>
    let PartDefinition = _prefixId.prefix "PartDefinition"
    /// <summary>
    ///   <para>rdfs:label : PartUsage^^xsd:string</para>
    ///   <para>rdfs:comment : A PartUsage is a usage of a PartDefinition to represent a system or a part of a system. At least one of the itemDefinitions of the PartUsage must be a PartDefinition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#PartUsage">oslc_sysmlv2:PartUsage</a>
    /// </summary>
    let PartUsage = _prefixId.prefix "PartUsage"
    /// <summary>
    ///   <para>rdfs:label : PerformActionUsage^^xsd:string</para>
    ///   <para>rdfs:comment : A PerformActionUsage is an ActionUsage that represents the performance of an ActionUsage. Unless it is the PerformActionUsage itself, the ActionUsage to be performed is related to the PerformActionUsage by a ReferenceSubsetting relationship. A PerformActionUsage is also an EventOccurrenceUsage, with its performedAction as the eventOccurrence.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#PerformActionUsage">oslc_sysmlv2:PerformActionUsage</a>
    /// </summary>
    let PerformActionUsage = _prefixId.prefix "PerformActionUsage"
    /// <summary>
    ///   <para>rdfs:label : PortConjugation^^xsd:string</para>
    ///   <para>rdfs:comment : A PortConjugation is a Conjugation Relationship between a PortDefinition and its corresponding ConjugatedPortDefinition. As a result of this Relationship, the ConjugatedPortDefinition inherits all the features of the original PortDefinition, but input flows of the original PortDefinition become outputs on the ConjugatedPortDefinition and output flows of the original PortDefinition become inputs on the ConjugatedPortDefinition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#PortConjugation">oslc_sysmlv2:PortConjugation</a>
    /// </summary>
    let PortConjugation = _prefixId.prefix "PortConjugation"
    /// <summary>
    ///   <para>rdfs:label : PortDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : A PortDefinition defines a point at which external entities can connect to and interact with a system or part of a system. Any ownedUsages of a PortDefinition, other than PortUsages, must not be composite.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#PortDefinition">oslc_sysmlv2:PortDefinition</a>
    /// </summary>
    let PortDefinition = _prefixId.prefix "PortDefinition"
    /// <summary>
    ///   <para>rdfs:label : PortUsage^^xsd:string</para>
    ///   <para>rdfs:comment : A PortUsage is a usage of a PortDefinition. A PortUsage itself as well as all its nestedUsages must be referential (non-composite).^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#PortUsage">oslc_sysmlv2:PortUsage</a>
    /// </summary>
    let PortUsage = _prefixId.prefix "PortUsage"
    /// <summary>
    ///   <para>rdfs:label : PortionKind^^xsd:string</para>
    ///   <para>rdfs:comment : PortionKind is an enumeration of the specific kinds of Occurrence portions that can be represented by an OccurrenceUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#PortionKind">oslc_sysmlv2:PortionKind</a>
    /// </summary>
    let PortionKind = _prefixId.prefix "PortionKind"
    /// <summary>
    ///   <para>rdfs:label : Predicate^^xsd:string</para>
    ///   <para>rdfs:comment : A Predicate is a Function whose result parameter has type Boolean and multiplicity 1..1.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Predicate">oslc_sysmlv2:Predicate</a>
    /// </summary>
    let Predicate = _prefixId.prefix "Predicate"
    /// <summary>
    ///   <para>rdfs:label : Redefinition^^xsd:string</para>
    ///   <para>rdfs:comment : Redefinition is a kind of Subsetting that requires the redefinedFeature and the redefiningFeature to have the same values (on each instance of the domain of the redefiningFeature). This means any restrictions on the redefiningFeature, such as type or multiplicity, also apply to the redefinedFeature (on each instance of the domain of the redefiningFeature), and vice versa. The redefinedFeature might have values for instances of the domain of the redefiningFeature, but only as instances of the domain of the redefinedFeature that happen to also be instances of the domain of the redefiningFeature. This is supported by the constraints inherited from Subsetting on the domains of the redefiningFeature and redefinedFeature. However, these constraints are narrowed for Redefinition to require the owningTypes of the redefiningFeature and redefinedFeature to be different and the redefinedFeature to not be inherited into the owningNamespace of the redefiningFeature.This enables the redefiningFeature to have the same name as the redefinedFeature, if desired.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Redefinition">oslc_sysmlv2:Redefinition</a>
    /// </summary>
    let Redefinition = _prefixId.prefix "Redefinition"
    /// <summary>
    ///   <para>rdfs:label : ReferenceSubsetting^^xsd:string</para>
    ///   <para>rdfs:comment : ReferenceSubsetting is a kind of Subsetting in which the referencedFeature is syntactically distinguished from other Features subsetted by the referencingFeature. ReferenceSubsetting has the same semantics as Subsetting, but the referenceFeature may have a special purpose relative to the referencingFeature. For instance, ReferenceSubsetting is used to identify the relatedFeatures of a Connector.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#ReferenceSubsetting">oslc_sysmlv2:ReferenceSubsetting</a>
    /// </summary>
    let ReferenceSubsetting = _prefixId.prefix "ReferenceSubsetting"
    /// <summary>
    ///   <para>rdfs:label : ReferenceUsage^^xsd:string</para>
    ///   <para>rdfs:comment : A ReferenceUsage is a Usage that specifies a non-compositional (isComposite = false) reference to something. The definition of a ReferenceUsage can be any kind of Classifier, with the default being the top-level Classifier Base::Anything from the Kernel Semantic Library. This allows the specification of a generic reference without distinguishing if the thing referenced is an attribute value, item, action, etc.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#ReferenceUsage">oslc_sysmlv2:ReferenceUsage</a>
    /// </summary>
    let ReferenceUsage = _prefixId.prefix "ReferenceUsage"
    /// <summary>
    ///   <para>rdfs:label : Relationship^^xsd:string</para>
    ///   <para>rdfs:comment : A Relationship is an Element that relates other Element. Some of its relatedElements may be owned, in which case those ownedRelatedElements will be deleted from a model if their owningRelationship is. A Relationship may also be owned by another Element, in which case the ownedRelatedElements of the Relationship are also considered to be transitively owned by the owningRelatedElement of the Relationship.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Relationship">oslc_sysmlv2:Relationship</a>
    /// </summary>
    let Relationship = _prefixId.prefix "Relationship"
    /// <summary>
    ///   <para>rdfs:label : RenderingDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : A RenderingDefinition is a PartDefinition that defines a specific rendering of the content of a model view (e.g., symbols, style, layout, etc.).^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#RenderingDefinition">oslc_sysmlv2:RenderingDefinition</a>
    /// </summary>
    let RenderingDefinition = _prefixId.prefix "RenderingDefinition"
    /// <summary>
    ///   <para>rdfs:label : RenderingUsage^^xsd:string</para>
    ///   <para>rdfs:comment : A RenderingUsage is the usage of a RenderingDefinition to specify the rendering of a specific model view to produce a physical view artifact.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#RenderingUsage">oslc_sysmlv2:RenderingUsage</a>
    /// </summary>
    let RenderingUsage = _prefixId.prefix "RenderingUsage"
    /// <summary>
    ///   <para>rdfs:label : RequirementConstraintKind^^xsd:string</para>
    ///   <para>rdfs:comment : A RequirementConstraintKind indicates whether a ConstraintUsage is an assumption or a requirement in a RequirementDefinition or RequirementUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#RequirementConstraintKind">oslc_sysmlv2:RequirementConstraintKind</a>
    /// </summary>
    let RequirementConstraintKind = _prefixId.prefix "RequirementConstraintKind"

    /// <summary>
    ///   <para>rdfs:label : RequirementConstraintMembership^^xsd:string</para>
    ///   <para>rdfs:comment : A RequirementConstraintMembership is a FeatureMembership for an assumed or required ConstraintUsage of a RequirementDefinition or RequirementUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#RequirementConstraintMembership">oslc_sysmlv2:RequirementConstraintMembership</a>
    /// </summary>
    let RequirementConstraintMembership = _prefixId.prefix "RequirementConstraintMembership"

    /// <summary>
    ///   <para>rdfs:label : RequirementDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : A RequirementDefinition is a ConstraintDefinition that defines a requirement used in the context of a specification as a constraint that a valid solution must satisfy. The specification is relative to a specified subject, possibly in collaboration with one or more external actors.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#RequirementDefinition">oslc_sysmlv2:RequirementDefinition</a>
    /// </summary>
    let RequirementDefinition = _prefixId.prefix "RequirementDefinition"
    /// <summary>
    ///   <para>rdfs:label : RequirementUsage^^xsd:string</para>
    ///   <para>rdfs:comment : A RequirementUsage is a Usage of a RequirementDefinition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#RequirementUsage">oslc_sysmlv2:RequirementUsage</a>
    /// </summary>
    let RequirementUsage = _prefixId.prefix "RequirementUsage"

    /// <summary>
    ///   <para>rdfs:label : RequirementVerificationMembership^^xsd:string</para>
    ///   <para>rdfs:comment : A RequirementVerificationMembership is a RequirementConstraintMembership  used in the objective of a VerificationCase to identify a RequirementUsage that is verified by the VerificationCase.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#RequirementVerificationMembership">oslc_sysmlv2:RequirementVerificationMembership</a>
    /// </summary>
    let RequirementVerificationMembership = _prefixId.prefix "RequirementVerificationMembership"

    /// <summary>
    ///   <para>rdfs:label : ResultExpressionMembership^^xsd:string</para>
    ///   <para>rdfs:comment : A ResultExpressionMembership is a FeatureMembership that indicates that the ownedResultExpression provides the result values for the Function or Expression that owns it. The owning Function or Expression must contain a BindingConnector between the result parameter of the ownedResultExpression and the result parameter of the owning Function or Expression.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#ResultExpressionMembership">oslc_sysmlv2:ResultExpressionMembership</a>
    /// </summary>
    let ResultExpressionMembership = _prefixId.prefix "ResultExpressionMembership"
    /// <summary>
    ///   <para>rdfs:label : ReturnParameterMembership^^xsd:string</para>
    ///   <para>rdfs:comment : A ReturnParameterMembership is a ParameterMembership that indicates that the ownedMemberParameter is the result parameter of a Function or Expression. The direction of the ownedMemberParameter must be out.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#ReturnParameterMembership">oslc_sysmlv2:ReturnParameterMembership</a>
    /// </summary>
    let ReturnParameterMembership = _prefixId.prefix "ReturnParameterMembership"
    /// <summary>
    ///   <para>rdfs:label : SatisfyRequirementUsage^^xsd:string</para>
    ///   <para>rdfs:comment : A SatisfyRequirementUsage is an AssertConstraintUsage that asserts, by default, that a satisfied RequirementUsage is true for a specific satisfyingFeature, or, if isNegated = true, that the RequirementUsage is false. The satisfied RequirementUsage is related to the SatisfyRequirementUsage by a ReferenceSubsetting Relationship.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#SatisfyRequirementUsage">oslc_sysmlv2:SatisfyRequirementUsage</a>
    /// </summary>
    let SatisfyRequirementUsage = _prefixId.prefix "SatisfyRequirementUsage"
    /// <summary>
    ///   <para>rdfs:label : SelectExpression^^xsd:string</para>
    ///   <para>rdfs:comment : A SelectExpression is an OperatorExpression whose operator is "select", which resolves to the Function ControlFunctions::select from the Kernel Functions Library.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#SelectExpression">oslc_sysmlv2:SelectExpression</a>
    /// </summary>
    let SelectExpression = _prefixId.prefix "SelectExpression"
    /// <summary>
    ///   <para>rdfs:label : SendActionUsage^^xsd:string</para>
    ///   <para>rdfs:comment : A SendActionUsage is an ActionUsage that specifies the sending of a payload given by the result of its payloadArgument Expression via a MessageTransfer whose source is given by the result of the senderArgument Expression and whose target is given by the result of the receiverArgument Expression. If no senderArgument is provided, the default is the this context for the action. If no receiverArgument is given, then the receiver is to be determined by, e.g., outgoing Connections from the sender.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#SendActionUsage">oslc_sysmlv2:SendActionUsage</a>
    /// </summary>
    let SendActionUsage = _prefixId.prefix "SendActionUsage"
    /// <summary>
    ///   <para>rdfs:label : Specialization^^xsd:string</para>
    ///   <para>rdfs:comment : Specialization is a Relationship between two Types that requires all instances of the specific type to also be instances of the general Type (i.e., the set of instances of the specific Type is a subset of those of the general Type, which might be the same set).^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Specialization">oslc_sysmlv2:Specialization</a>
    /// </summary>
    let Specialization = _prefixId.prefix "Specialization"
    /// <summary>
    ///   <para>rdfs:label : StakeholderMembership^^xsd:string</para>
    ///   <para>rdfs:comment : A StakeholderMembership is a ParameterMembership that identifies a PartUsage as a stakeholderParameter of a RequirementDefinition or RequirementUsage, which specifies a role played by an entity with concerns framed by the owningType.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#StakeholderMembership">oslc_sysmlv2:StakeholderMembership</a>
    /// </summary>
    let StakeholderMembership = _prefixId.prefix "StakeholderMembership"
    /// <summary>
    ///   <para>rdfs:label : StateDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : A StateDefinition is the Definition of the Behavior of a system or part of a system in a certain state condition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#StateDefinition">oslc_sysmlv2:StateDefinition</a>
    /// </summary>
    let StateDefinition = _prefixId.prefix "StateDefinition"
    /// <summary>
    ///   <para>rdfs:label : StateSubactionKind^^xsd:string</para>
    ///   <para>rdfs:comment : A StateSubactionKind indicates whether the action of a StateSubactionMembership is an entry, do or exit action.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#StateSubactionKind">oslc_sysmlv2:StateSubactionKind</a>
    /// </summary>
    let StateSubactionKind = _prefixId.prefix "StateSubactionKind"
    /// <summary>
    ///   <para>rdfs:label : StateSubactionMembership^^xsd:string</para>
    ///   <para>rdfs:comment : A StateSubactionMembership is a FeatureMembership for an entry, do or exit ActionUsage of a StateDefinition or StateUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#StateSubactionMembership">oslc_sysmlv2:StateSubactionMembership</a>
    /// </summary>
    let StateSubactionMembership = _prefixId.prefix "StateSubactionMembership"
    /// <summary>
    ///   <para>rdfs:label : StateUsage^^xsd:string</para>
    ///   <para>rdfs:comment : A StateUsage is an ActionUsage that is nominally the Usage of a StateDefinition. However, other kinds of kernel Behaviors are also allowed as types, to permit use of Behaviors
    /// .^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#StateUsage">oslc_sysmlv2:StateUsage</a>
    /// </summary>
    let StateUsage = _prefixId.prefix "StateUsage"
    /// <summary>
    ///   <para>rdfs:label : Step^^xsd:string</para>
    ///   <para>rdfs:comment : A Step is a Feature that is typed by one or more Behaviors. Steps may be used by one Behavior to coordinate the performance of other Behaviors, supporting a steady refinement of behavioral descriptions. Steps can be ordered in time and can be connected using ItemFlows to specify things flowing between their parameters.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Step">oslc_sysmlv2:Step</a>
    /// </summary>
    let Step = _prefixId.prefix "Step"
    /// <summary>
    ///   <para>rdfs:label : Structure^^xsd:string</para>
    ///   <para>rdfs:comment : A Structure is a Class of objects in the modeled universe that are primarily structural in nature. While such an object is not itself behavioral, it may be involved in and acted on by Behaviors, and it may be the performer of some of them.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Structure">oslc_sysmlv2:Structure</a>
    /// </summary>
    let Structure = _prefixId.prefix "Structure"
    /// <summary>
    ///   <para>rdfs:label : Subclassification^^xsd:string</para>
    ///   <para>rdfs:comment : Subclassification is Specialization in which both the specific and general Types are Classifier. This means all instances of the specific Classifier are also instances of the general Classifier.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Subclassification">oslc_sysmlv2:Subclassification</a>
    /// </summary>
    let Subclassification = _prefixId.prefix "Subclassification"
    /// <summary>
    ///   <para>rdfs:label : SubjectMembership^^xsd:string</para>
    ///   <para>rdfs:comment : A SubjectMembership is a ParameterMembership that indicates that its ownedSubjectParameter is the subject of its owningType. The owningType of a SubjectMembership must be a RequirementDefinition, RequirementUsage, CaseDefinition, or CaseUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#SubjectMembership">oslc_sysmlv2:SubjectMembership</a>
    /// </summary>
    let SubjectMembership = _prefixId.prefix "SubjectMembership"
    /// <summary>
    ///   <para>rdfs:label : Subsetting^^xsd:string</para>
    ///   <para>rdfs:comment : Subsetting is Specialization in which the specific and general Types are Features. This means all values of the subsettingFeature (on instances of its domain, i.e., the intersection of its featuringTypes) are values of the subsettedFeature on instances of its domain. To support this the domain of the subsettingFeature must be the same or specialize (at least indirectly) the domain of the subsettedFeature (via Specialization), and the co-domain (intersection of the types) of the subsettingFeature must specialize the co-domain of the subsettedFeature.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Subsetting">oslc_sysmlv2:Subsetting</a>
    /// </summary>
    let Subsetting = _prefixId.prefix "Subsetting"
    /// <summary>
    ///   <para>rdfs:label : Succession^^xsd:string</para>
    ///   <para>rdfs:comment : A Succession is a binary Connector that requires its relatedFeatures to happen separately in time.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Succession">oslc_sysmlv2:Succession</a>
    /// </summary>
    let Succession = _prefixId.prefix "Succession"
    /// <summary>
    ///   <para>rdfs:label : SuccessionAsUsage^^xsd:string</para>
    ///   <para>rdfs:comment : A SuccessionAsUsage is both a ConnectorAsUsage and a Succession.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#SuccessionAsUsage">oslc_sysmlv2:SuccessionAsUsage</a>
    /// </summary>
    let SuccessionAsUsage = _prefixId.prefix "SuccessionAsUsage"
    /// <summary>
    ///   <para>rdfs:label : SuccessionFlowConnectionUsage^^xsd:string</para>
    ///   <para>rdfs:comment : A SuccessionFlowConnectionUsage is a FlowConnectionUsage that is also a SuccessionItemFlow.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#SuccessionFlowConnectionUsage">oslc_sysmlv2:SuccessionFlowConnectionUsage</a>
    /// </summary>
    let SuccessionFlowConnectionUsage = _prefixId.prefix "SuccessionFlowConnectionUsage"
    /// <summary>
    ///   <para>rdfs:label : SuccessionItemFlow^^xsd:string</para>
    ///   <para>rdfs:comment : A SuccessionItemFlow is an ItemFlow that also provides temporal ordering. It classifies Transfers that cannot start until the source Occurrence has completed and that must complete before the target Occurrence can start.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#SuccessionItemFlow">oslc_sysmlv2:SuccessionItemFlow</a>
    /// </summary>
    let SuccessionItemFlow = _prefixId.prefix "SuccessionItemFlow"
    /// <summary>
    ///   <para>rdfs:label : TextualRepresentation^^xsd:string</para>
    ///   <para>rdfs:comment : A TextualRepresentation is an AnnotatingElement whose body represents the representedElement in a given language. The representedElement must be the owner of the TextualRepresentation. The named language can be a natural language, in which case the body is an informal representation, or an artificial language, in which case the body is expected to be a formal, machine-parsable representation.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#TextualRepresentation">oslc_sysmlv2:TextualRepresentation</a>
    /// </summary>
    let TextualRepresentation = _prefixId.prefix "TextualRepresentation"
    /// <summary>
    ///   <para>rdfs:label : TransitionFeatureKind^^xsd:string</para>
    ///   <para>rdfs:comment : A TransitionActionKind indicates whether the transitionFeature of a TransitionFeatureMembership is a trigger, guard or effect.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#TransitionFeatureKind">oslc_sysmlv2:TransitionFeatureKind</a>
    /// </summary>
    let TransitionFeatureKind = _prefixId.prefix "TransitionFeatureKind"
    /// <summary>
    ///   <para>rdfs:label : TransitionFeatureMembership^^xsd:string</para>
    ///   <para>rdfs:comment : A TransitionFeatureMembership is a FeatureMembership for a trigger, guard or effect of a TransitionUsage, whose transitionFeature is a AcceptActionUsage, Boolean-valued Expression or ActionUsage, depending on its kind. .^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#TransitionFeatureMembership">oslc_sysmlv2:TransitionFeatureMembership</a>
    /// </summary>
    let TransitionFeatureMembership = _prefixId.prefix "TransitionFeatureMembership"
    /// <summary>
    ///   <para>rdfs:label : TransitionUsage^^xsd:string</para>
    ///   <para>rdfs:comment : A TransitionUsage is an ActionUsage representing a triggered transition between ActionUsages or StateUsages. When triggered by a triggerAction, when its guardExpression is true, the TransitionUsage asserts that its source is exited, then its effectAction (if any) is performed, and then its target is entered.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#TransitionUsage">oslc_sysmlv2:TransitionUsage</a>
    /// </summary>
    let TransitionUsage = _prefixId.prefix "TransitionUsage"
    /// <summary>
    ///   <para>rdfs:label : TriggerInvocationExpression^^xsd:string</para>
    ///   <para>rdfs:comment : A TriggerInvocationExpression is an InvocationExpression that invokes one of the trigger Functions from the Kernel Semantic Library Triggers package, as indicated by its kind.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#TriggerInvocationExpression">oslc_sysmlv2:TriggerInvocationExpression</a>
    /// </summary>
    let TriggerInvocationExpression = _prefixId.prefix "TriggerInvocationExpression"
    /// <summary>
    ///   <para>rdfs:label : TriggerKind^^xsd:string</para>
    ///   <para>rdfs:comment : TriggerKind enumerates the kinds of triggers that can be represented by a TriggerInvocationExpression.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#TriggerKind">oslc_sysmlv2:TriggerKind</a>
    /// </summary>
    let TriggerKind = _prefixId.prefix "TriggerKind"
    /// <summary>
    ///   <para>rdfs:label : Type^^xsd:string</para>
    ///   <para>rdfs:comment : A Type is a Namespace that is the most general kind of Element supporting the semantics of classification. A Type may be a Classifier or a Feature, defining conditions on what is classified by the Type (see also the description of isSufficient).^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Type">oslc_sysmlv2:Type</a>
    /// </summary>
    let Type = _prefixId.prefix "Type"
    /// <summary>
    ///   <para>rdfs:label : TypeFeaturing^^xsd:string</para>
    ///   <para>rdfs:comment : A TypeFeaturing is a Featuring Relationship in which the featureOfType is the source and the featuringType is the target.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#TypeFeaturing">oslc_sysmlv2:TypeFeaturing</a>
    /// </summary>
    let TypeFeaturing = _prefixId.prefix "TypeFeaturing"
    /// <summary>
    ///   <para>rdfs:label : Unioning^^xsd:string</para>
    ///   <para>rdfs:comment : Unioning is a Relationship that makes its unioningType one of the unioningTypes of its typeUnioned.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Unioning">oslc_sysmlv2:Unioning</a>
    /// </summary>
    let Unioning = _prefixId.prefix "Unioning"
    /// <summary>
    ///   <para>rdfs:label : Usage^^xsd:string</para>
    ///   <para>rdfs:comment : A Usage is a usage of a Definition. A Usage may only be an ownedFeature of a Definition or another Usage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#Usage">oslc_sysmlv2:Usage</a>
    /// </summary>
    let Usage = _prefixId.prefix "Usage"
    /// <summary>
    ///   <para>rdfs:label : UseCaseDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : A UseCaseDefinition is a CaseDefinition that specifies a set of actions performed by its subject, in interaction with one or more actors external to the subject. The objective is to yield an observable result that is of value to one or more of the actors.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#UseCaseDefinition">oslc_sysmlv2:UseCaseDefinition</a>
    /// </summary>
    let UseCaseDefinition = _prefixId.prefix "UseCaseDefinition"
    /// <summary>
    ///   <para>rdfs:label : UseCaseUsage^^xsd:string</para>
    ///   <para>rdfs:comment : A UseCaseUsage is a Usage of a UseCaseDefinition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#UseCaseUsage">oslc_sysmlv2:UseCaseUsage</a>
    /// </summary>
    let UseCaseUsage = _prefixId.prefix "UseCaseUsage"
    /// <summary>
    ///   <para>rdfs:label : VariantMembership^^xsd:string</para>
    ///   <para>rdfs:comment : A VariantMembership is a Membership between a variation point Definition or Usage and a Usage that represents a variant in the context of that variation. The membershipOwningNamespace for the VariantMembership must be either a Definition or a Usage with isVariation = true.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#VariantMembership">oslc_sysmlv2:VariantMembership</a>
    /// </summary>
    let VariantMembership = _prefixId.prefix "VariantMembership"
    /// <summary>
    ///   <para>rdfs:label : VerificationCaseDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : A VerificationCaseDefinition is a CaseDefinition for the purpose of verification of the subject of the case against its requirements.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#VerificationCaseDefinition">oslc_sysmlv2:VerificationCaseDefinition</a>
    /// </summary>
    let VerificationCaseDefinition = _prefixId.prefix "VerificationCaseDefinition"
    /// <summary>
    ///   <para>rdfs:label : VerificationCaseUsage^^xsd:string</para>
    ///   <para>rdfs:comment : A VerificationCaseUsage is a Usage of a VerificationCaseDefinition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#VerificationCaseUsage">oslc_sysmlv2:VerificationCaseUsage</a>
    /// </summary>
    let VerificationCaseUsage = _prefixId.prefix "VerificationCaseUsage"
    /// <summary>
    ///   <para>rdfs:label : ViewDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : A ViewDefinition is a PartDefinition that specifies how a view artifact is constructed to satisfy a viewpoint. It specifies a viewConditions to define the model content to be presented and a viewRendering to define how the model content is presented.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#ViewDefinition">oslc_sysmlv2:ViewDefinition</a>
    /// </summary>
    let ViewDefinition = _prefixId.prefix "ViewDefinition"
    /// <summary>
    ///   <para>rdfs:label : ViewRenderingMembership^^xsd:string</para>
    ///   <para>rdfs:comment : A ViewRenderingMembership is a FeatureMembership that identifies the viewRendering of a ViewDefinition or ViewUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#ViewRenderingMembership">oslc_sysmlv2:ViewRenderingMembership</a>
    /// </summary>
    let ViewRenderingMembership = _prefixId.prefix "ViewRenderingMembership"
    /// <summary>
    ///   <para>rdfs:label : ViewUsage^^xsd:string</para>
    ///   <para>rdfs:comment : A ViewUsage is a usage of a ViewDefinition to specify the generation of a view of the members of a collection of exposedNamespaces. The ViewUsage can satisfy more viewpoints than its definition, and it can specialize the viewRendering specified by its definition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#ViewUsage">oslc_sysmlv2:ViewUsage</a>
    /// </summary>
    let ViewUsage = _prefixId.prefix "ViewUsage"
    /// <summary>
    ///   <para>rdfs:label : ViewpointDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : A ViewpointDefinition is a RequirementDefinition that specifies one or more stakeholder concerns that are to be satisfied by creating a view of a model.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#ViewpointDefinition">oslc_sysmlv2:ViewpointDefinition</a>
    /// </summary>
    let ViewpointDefinition = _prefixId.prefix "ViewpointDefinition"
    /// <summary>
    ///   <para>rdfs:label : ViewpointUsage^^xsd:string</para>
    ///   <para>rdfs:comment : A ViewpointUsage is a Usage of a ViewpointDefinition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#ViewpointUsage">oslc_sysmlv2:ViewpointUsage</a>
    /// </summary>
    let ViewpointUsage = _prefixId.prefix "ViewpointUsage"
    /// <summary>
    ///   <para>rdfs:label : VisibilityKind^^xsd:string</para>
    ///   <para>rdfs:comment : VisibilityKind is an enumeration whose literals specify the visibility of a Membership of an Element in a Namespace outside of that Namespace. Note that "visibility" specifically restricts whether an Element in a Namespace may be referenced by name from outside the Namespace and only otherwise restricts access to an Element as provided by specific constraints in the abstract syntax (e.g., preventing the import or inheritance of private Elements).^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#VisibilityKind">oslc_sysmlv2:VisibilityKind</a>
    /// </summary>
    let VisibilityKind = _prefixId.prefix "VisibilityKind"
    /// <summary>
    ///   <para>rdfs:label : WhileLoopActionUsage^^xsd:string</para>
    ///   <para>rdfs:comment : A WhileLoopActionUsage is a LoopActionUsage that specifies that the bodyAction ActionUsage should be performed repeatedly while the result of the whileArgument Expression is true or until the result of the untilArgument Expression (if provided) is true. The whileArgument Expression is evaluated before each (possible) performance of the bodyAction, and the untilArgument Expression is evaluated after each performance of the bodyAction.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#WhileLoopActionUsage">oslc_sysmlv2:WhileLoopActionUsage</a>
    /// </summary>
    let WhileLoopActionUsage = _prefixId.prefix "WhileLoopActionUsage"

    /// <summary>
    ///   <para>rdfs:label : acceptActionUsage_PayloadArgument^^xsd:string</para>
    ///   <para>rdfs:comment : An Expression whose result is bound to the payload parameter of this AcceptActionUsage. If provided, the AcceptActionUsage will only accept a Transfer with exactly this payload.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#acceptActionUsage_PayloadArgument">oslc_sysmlv2:acceptActionUsage_PayloadArgument</a>
    /// </summary>
    let acceptActionUsage_PayloadArgument = _prefixId.prefix "acceptActionUsage_PayloadArgument"

    /// <summary>
    ///   <para>rdfs:label : acceptActionUsage_PayloadParameter^^xsd:string</para>
    ///   <para>rdfs:comment : The nestedReference of this AcceptActionUsage that redefines the payload output parameter of the base AcceptActionUsage AcceptAction from the Systems Model Library.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#acceptActionUsage_PayloadParameter">oslc_sysmlv2:acceptActionUsage_PayloadParameter</a>
    /// </summary>
    let acceptActionUsage_PayloadParameter = _prefixId.prefix "acceptActionUsage_PayloadParameter"

    /// <summary>
    ///   <para>rdfs:label : acceptActionUsage_ReceiverArgument^^xsd:string</para>
    ///   <para>rdfs:comment : An Expression whose result is bound to the receiver input parameter of this AcceptActionUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#acceptActionUsage_ReceiverArgument">oslc_sysmlv2:acceptActionUsage_ReceiverArgument</a>
    /// </summary>
    let acceptActionUsage_ReceiverArgument = _prefixId.prefix "acceptActionUsage_ReceiverArgument"

    /// <summary>
    ///   <para>rdfs:label : actionDefinition_Action^^xsd:string</para>
    ///   <para>rdfs:comment : The ActionUsages that are steps in this ActionDefinition, which define the actions that specify the behavior of the ActionDefinition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#actionDefinition_Action">oslc_sysmlv2:actionDefinition_Action</a>
    /// </summary>
    let actionDefinition_Action = _prefixId.prefix "actionDefinition_Action"
    /// <summary>
    ///   <para>rdfs:label : actionUsage_ActionDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : The Behaviors that are the types of this ActionUsage. Nominally, these would be ActionDefinitions, but other kinds of Kernel Behaviors are also allowed, to permit use of Behaviors from the Kernel Model Libraries.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#actionUsage_ActionDefinition">oslc_sysmlv2:actionUsage_ActionDefinition</a>
    /// </summary>
    let actionUsage_ActionDefinition = _prefixId.prefix "actionUsage_ActionDefinition"

    /// <summary>
    ///   <para>rdfs:label : actorMembership_OwnedActorParameter^^xsd:string</para>
    ///   <para>rdfs:comment : The PartUsage specifying the actor.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#actorMembership_OwnedActorParameter">oslc_sysmlv2:actorMembership_OwnedActorParameter</a>
    /// </summary>
    let actorMembership_OwnedActorParameter = _prefixId.prefix "actorMembership_OwnedActorParameter"

    /// <summary>
    ///   <para>rdfs:label : allocationDefinition_Allocation^^xsd:string</para>
    ///   <para>rdfs:comment : The AllocationUsages that refine the allocation mapping defined by this AllocationDefinition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#allocationDefinition_Allocation">oslc_sysmlv2:allocationDefinition_Allocation</a>
    /// </summary>
    let allocationDefinition_Allocation = _prefixId.prefix "allocationDefinition_Allocation"

    /// <summary>
    ///   <para>rdfs:label : allocationUsage_AllocationDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : The AllocationDefinitions that are the types of this AllocationUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#allocationUsage_AllocationDefinition">oslc_sysmlv2:allocationUsage_AllocationDefinition</a>
    /// </summary>
    let allocationUsage_AllocationDefinition = _prefixId.prefix "allocationUsage_AllocationDefinition"

    /// <summary>
    ///   <para>rdfs:label : analysisCaseDefinition_AnalysisAction^^xsd:string</para>
    ///   <para>rdfs:comment : The composite actions of the AnalysisCaseDefinition that are defined as AnalysisActions.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#analysisCaseDefinition_AnalysisAction">oslc_sysmlv2:analysisCaseDefinition_AnalysisAction</a>
    /// </summary>
    let analysisCaseDefinition_AnalysisAction = _prefixId.prefix "analysisCaseDefinition_AnalysisAction"

    /// <summary>
    ///   <para>rdfs:label : analysisCaseDefinition_ResultExpression^^xsd:string</para>
    ///   <para>rdfs:comment : An Expression used to compute the result of the AnalysisCaseDefinition, owned via a ResultExpressionMembership.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#analysisCaseDefinition_ResultExpression">oslc_sysmlv2:analysisCaseDefinition_ResultExpression</a>
    /// </summary>
    let analysisCaseDefinition_ResultExpression = _prefixId.prefix "analysisCaseDefinition_ResultExpression"

    /// <summary>
    ///   <para>rdfs:label : analysisCaseUsage_AnalysisAction^^xsd:string</para>
    ///   <para>rdfs:comment : The composite usages of the AnalysisCaseUsage that are defined as AnalysisActions.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#analysisCaseUsage_AnalysisAction">oslc_sysmlv2:analysisCaseUsage_AnalysisAction</a>
    /// </summary>
    let analysisCaseUsage_AnalysisAction = _prefixId.prefix "analysisCaseUsage_AnalysisAction"

    /// <summary>
    ///   <para>rdfs:label : analysisCaseUsage_AnalysisCaseDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : The AnalysisCaseDefinition that is the definition of this AnalysisCaseUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#analysisCaseUsage_AnalysisCaseDefinition">oslc_sysmlv2:analysisCaseUsage_AnalysisCaseDefinition</a>
    /// </summary>
    let analysisCaseUsage_AnalysisCaseDefinition = _prefixId.prefix "analysisCaseUsage_AnalysisCaseDefinition"

    /// <summary>
    ///   <para>rdfs:label : analysisCaseUsage_ResultExpression^^xsd:string</para>
    ///   <para>rdfs:comment : An Expression used to compute the result of the AnalysisCaseUsage, owned via a ResultExpressionMembership.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#analysisCaseUsage_ResultExpression">oslc_sysmlv2:analysisCaseUsage_ResultExpression</a>
    /// </summary>
    let analysisCaseUsage_ResultExpression = _prefixId.prefix "analysisCaseUsage_ResultExpression"

    /// <summary>
    ///   <para>rdfs:label : annotatingElement_AnnotatedElement^^xsd:string</para>
    ///   <para>rdfs:comment : The Elements that are annotated by this AnnotatingElement. If annotation is not empty, these are the annotatedElements of the annotations. If annotation is empty, then it is the owningNamespace of the AnnotatingElement.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#annotatingElement_AnnotatedElement">oslc_sysmlv2:annotatingElement_AnnotatedElement</a>
    /// </summary>
    let annotatingElement_AnnotatedElement = _prefixId.prefix "annotatingElement_AnnotatedElement"

    /// <summary>
    ///   <para>rdfs:label : annotatingElement_Annotation^^xsd:string</para>
    ///   <para>rdfs:comment : The Annotations that relate this AnnotatingElement to its annotatedElements.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#annotatingElement_Annotation">oslc_sysmlv2:annotatingElement_Annotation</a>
    /// </summary>
    let annotatingElement_Annotation = _prefixId.prefix "annotatingElement_Annotation"

    /// <summary>
    ///   <para>rdfs:label : annotatingElement_OwnedAnnotatingRelationship^^xsd:string</para>
    ///   <para>rdfs:comment : The ownedRelationships of this AnnotatingElement that are Annotations, for which this AnnotatingElement is the annotatingElement.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#annotatingElement_OwnedAnnotatingRelationship">oslc_sysmlv2:annotatingElement_OwnedAnnotatingRelationship</a>
    /// </summary>
    let annotatingElement_OwnedAnnotatingRelationship = _prefixId.prefix "annotatingElement_OwnedAnnotatingRelationship"

    /// <summary>
    ///   <para>rdfs:label : annotation_AnnotatedElement^^xsd:string</para>
    ///   <para>rdfs:comment : The Element that is annotated by the annotatingElement of this Annotation.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#annotation_AnnotatedElement">oslc_sysmlv2:annotation_AnnotatedElement</a>
    /// </summary>
    let annotation_AnnotatedElement = _prefixId.prefix "annotation_AnnotatedElement"
    /// <summary>
    ///   <para>rdfs:label : annotation_AnnotatingElement^^xsd:string</para>
    ///   <para>rdfs:comment : The AnnotatingElement that annotates the annotatedElement of this Annotation.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#annotation_AnnotatingElement">oslc_sysmlv2:annotation_AnnotatingElement</a>
    /// </summary>
    let annotation_AnnotatingElement = _prefixId.prefix "annotation_AnnotatingElement"

    /// <summary>
    ///   <para>rdfs:label : annotation_OwningAnnotatedElement^^xsd:string</para>
    ///   <para>rdfs:comment : The annotatedElement of this Annotation, when it is also its owningRelatedElement.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#annotation_OwningAnnotatedElement">oslc_sysmlv2:annotation_OwningAnnotatedElement</a>
    /// </summary>
    let annotation_OwningAnnotatedElement = _prefixId.prefix "annotation_OwningAnnotatedElement"

    /// <summary>
    ///   <para>rdfs:label : annotation_OwningAnnotatingElement^^xsd:string</para>
    ///   <para>rdfs:comment : The annotatingElement of this Annotation, when it is also its owningRelatedElement.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#annotation_OwningAnnotatingElement">oslc_sysmlv2:annotation_OwningAnnotatingElement</a>
    /// </summary>
    let annotation_OwningAnnotatingElement = _prefixId.prefix "annotation_OwningAnnotatingElement"

    /// <summary>
    ///   <para>rdfs:label : assertConstraintUsage_AssertedConstraint^^xsd:string</para>
    ///   <para>rdfs:comment : The ConstraintUsage to be performed by the AssertConstraintUsage. It is the referenceFeature of the ownedReferenceSubsetting for the AssertConstraintUsage, if there is one, and, otherwise, the AssertConstraintUsage itself.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#assertConstraintUsage_AssertedConstraint">oslc_sysmlv2:assertConstraintUsage_AssertedConstraint</a>
    /// </summary>
    let assertConstraintUsage_AssertedConstraint = _prefixId.prefix "assertConstraintUsage_AssertedConstraint"

    /// <summary>
    ///   <para>rdfs:label : assignmentActionUsage_Referent^^xsd:string</para>
    ///   <para>rdfs:comment : The Feature whose value is to be set.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#assignmentActionUsage_Referent">oslc_sysmlv2:assignmentActionUsage_Referent</a>
    /// </summary>
    let assignmentActionUsage_Referent = _prefixId.prefix "assignmentActionUsage_Referent"

    /// <summary>
    ///   <para>rdfs:label : assignmentActionUsage_TargetArgument^^xsd:string</para>
    ///   <para>rdfs:comment : The Expression whose value is an occurrence in the domain of the referent Feature, for which the value of the referent will be set to the result of the valueExpression by this AssignmentActionUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#assignmentActionUsage_TargetArgument">oslc_sysmlv2:assignmentActionUsage_TargetArgument</a>
    /// </summary>
    let assignmentActionUsage_TargetArgument = _prefixId.prefix "assignmentActionUsage_TargetArgument"

    /// <summary>
    ///   <para>rdfs:label : assignmentActionUsage_ValueExpression^^xsd:string</para>
    ///   <para>rdfs:comment : The Expression whose result is to be assigned to the referent Feature.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#assignmentActionUsage_ValueExpression">oslc_sysmlv2:assignmentActionUsage_ValueExpression</a>
    /// </summary>
    let assignmentActionUsage_ValueExpression = _prefixId.prefix "assignmentActionUsage_ValueExpression"

    /// <summary>
    ///   <para>rdfs:label : association_AssociationEnd^^xsd:string</para>
    ///   <para>rdfs:comment : The features of the Association that identify the things that can be related by it. A concrete Association must have at least two associationEnds. When it has exactly two, the Association is called a binary Association.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#association_AssociationEnd">oslc_sysmlv2:association_AssociationEnd</a>
    /// </summary>
    let association_AssociationEnd = _prefixId.prefix "association_AssociationEnd"
    /// <summary>
    ///   <para>rdfs:label : association_RelatedType^^xsd:string</para>
    ///   <para>rdfs:comment : The types of the associationEnds of the Association, which are the relatedElements of the Association considered as a Relationship.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#association_RelatedType">oslc_sysmlv2:association_RelatedType</a>
    /// </summary>
    let association_RelatedType = _prefixId.prefix "association_RelatedType"
    /// <summary>
    ///   <para>rdfs:label : association_SourceType^^xsd:string</para>
    ///   <para>rdfs:comment : The source relatedType for this Association. It is the first relatedType of the Association.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#association_SourceType">oslc_sysmlv2:association_SourceType</a>
    /// </summary>
    let association_SourceType = _prefixId.prefix "association_SourceType"
    /// <summary>
    ///   <para>rdfs:label : association_TargetType^^xsd:string</para>
    ///   <para>rdfs:comment : The target relatedTypes for this Association. This includes all the relatedTypes other than the sourceType.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#association_TargetType">oslc_sysmlv2:association_TargetType</a>
    /// </summary>
    let association_TargetType = _prefixId.prefix "association_TargetType"

    /// <summary>
    ///   <para>rdfs:label : attributeUsage_AttributeDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : The DataTypes that are the types of this AttributeUsage. Nominally, these are AttributeDefinitions, but other kinds of kernel DataTypes are also allowed, to permit use of DataTypes from the Kernel Model Libraries.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#attributeUsage_AttributeDefinition">oslc_sysmlv2:attributeUsage_AttributeDefinition</a>
    /// </summary>
    let attributeUsage_AttributeDefinition = _prefixId.prefix "attributeUsage_AttributeDefinition"

    /// <summary>
    ///   <para>rdfs:label : behavior_Parameter^^xsd:string</para>
    ///   <para>rdfs:comment : The parameters of this Behavior, which are defined as its directedFeatures, whose values are passed into and/or out of a performance of the Behavior.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#behavior_Parameter">oslc_sysmlv2:behavior_Parameter</a>
    /// </summary>
    let behavior_Parameter = _prefixId.prefix "behavior_Parameter"
    /// <summary>
    ///   <para>rdfs:label : behavior_Step^^xsd:string</para>
    ///   <para>rdfs:comment : The Steps that make up this Behavior.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#behavior_Step">oslc_sysmlv2:behavior_Step</a>
    /// </summary>
    let behavior_Step = _prefixId.prefix "behavior_Step"
    /// <summary>
    ///   <para>rdfs:label : booleanExpression_Predicate^^xsd:string</para>
    ///   <para>rdfs:comment : The Predicate that types this BooleanExpression.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#booleanExpression_Predicate">oslc_sysmlv2:booleanExpression_Predicate</a>
    /// </summary>
    let booleanExpression_Predicate = _prefixId.prefix "booleanExpression_Predicate"

    /// <summary>
    ///   <para>rdfs:label : calculationDefinition_Calculation^^xsd:string</para>
    ///   <para>rdfs:comment : The actions of this CalculationDefinition that are CalculationUsages.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#calculationDefinition_Calculation">oslc_sysmlv2:calculationDefinition_Calculation</a>
    /// </summary>
    let calculationDefinition_Calculation = _prefixId.prefix "calculationDefinition_Calculation"

    /// <summary>
    ///   <para>rdfs:label : calculationUsage_CalculationDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : The Function that is the type of this CalculationUsage. Nominally, this would be a CalculationDefinition, but a kernel Function is also allowed, to permit use of Functions from the Kernel Model Libraries.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#calculationUsage_CalculationDefinition">oslc_sysmlv2:calculationUsage_CalculationDefinition</a>
    /// </summary>
    let calculationUsage_CalculationDefinition = _prefixId.prefix "calculationUsage_CalculationDefinition"

    /// <summary>
    ///   <para>rdfs:label : caseDefinition_ActorParameter^^xsd:string</para>
    ///   <para>rdfs:comment : The parameters of this CaseDefinition that represent actors involved in the case.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#caseDefinition_ActorParameter">oslc_sysmlv2:caseDefinition_ActorParameter</a>
    /// </summary>
    let caseDefinition_ActorParameter = _prefixId.prefix "caseDefinition_ActorParameter"

    /// <summary>
    ///   <para>rdfs:label : caseDefinition_ObjectiveRequirement^^xsd:string</para>
    ///   <para>rdfs:comment : The RequirementUsage representing the objective of this CaseDefinition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#caseDefinition_ObjectiveRequirement">oslc_sysmlv2:caseDefinition_ObjectiveRequirement</a>
    /// </summary>
    let caseDefinition_ObjectiveRequirement = _prefixId.prefix "caseDefinition_ObjectiveRequirement"

    /// <summary>
    ///   <para>rdfs:label : caseDefinition_SubjectParameter^^xsd:string</para>
    ///   <para>rdfs:comment : The parameter of this CaseDefinition that represents its subject.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#caseDefinition_SubjectParameter">oslc_sysmlv2:caseDefinition_SubjectParameter</a>
    /// </summary>
    let caseDefinition_SubjectParameter = _prefixId.prefix "caseDefinition_SubjectParameter"

    /// <summary>
    ///   <para>rdfs:label : caseUsage_ActorParameter^^xsd:string</para>
    ///   <para>rdfs:comment : The parameters of this CaseUsage that represent actors involved in the case.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#caseUsage_ActorParameter">oslc_sysmlv2:caseUsage_ActorParameter</a>
    /// </summary>
    let caseUsage_ActorParameter = _prefixId.prefix "caseUsage_ActorParameter"
    /// <summary>
    ///   <para>rdfs:label : caseUsage_CaseDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : The CaseDefinition that is the type of this CaseUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#caseUsage_CaseDefinition">oslc_sysmlv2:caseUsage_CaseDefinition</a>
    /// </summary>
    let caseUsage_CaseDefinition = _prefixId.prefix "caseUsage_CaseDefinition"

    /// <summary>
    ///   <para>rdfs:label : caseUsage_ObjectiveRequirement^^xsd:string</para>
    ///   <para>rdfs:comment : The RequirementUsage representing the objective of this CaseUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#caseUsage_ObjectiveRequirement">oslc_sysmlv2:caseUsage_ObjectiveRequirement</a>
    /// </summary>
    let caseUsage_ObjectiveRequirement = _prefixId.prefix "caseUsage_ObjectiveRequirement"

    /// <summary>
    ///   <para>rdfs:label : caseUsage_SubjectParameter^^xsd:string</para>
    ///   <para>rdfs:comment : The parameter of this CaseUsage that represents its subject.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#caseUsage_SubjectParameter">oslc_sysmlv2:caseUsage_SubjectParameter</a>
    /// </summary>
    let caseUsage_SubjectParameter = _prefixId.prefix "caseUsage_SubjectParameter"

    /// <summary>
    ///   <para>rdfs:label : classifier_OwnedSubclassification^^xsd:string</para>
    ///   <para>rdfs:comment : The ownedSpecializations of this Classifier that are Subclassifications, for which this Classifier is the subclassifier.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#classifier_OwnedSubclassification">oslc_sysmlv2:classifier_OwnedSubclassification</a>
    /// </summary>
    let classifier_OwnedSubclassification = _prefixId.prefix "classifier_OwnedSubclassification"

    /// <summary>
    ///   <para>rdfs:label : comment_Body^^xsd:string</para>
    ///   <para>rdfs:comment : The annotation text for the Comment.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#comment_Body">oslc_sysmlv2:comment_Body</a>
    /// </summary>
    let comment_Body = _prefixId.prefix "comment_Body"
    /// <summary>
    ///   <para>rdfs:label : comment_Locale^^xsd:string</para>
    ///   <para>rdfs:comment : Identification of the language of the body text and, optionally, the region and/or encoding. The format shall be a POSIX locale conformant to ISO/IEC 15897, with the format [language[_territory][.codeset][@modifier]].^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#comment_Locale">oslc_sysmlv2:comment_Locale</a>
    /// </summary>
    let comment_Locale = _prefixId.prefix "comment_Locale"

    /// <summary>
    ///   <para>rdfs:label : concernUsage_ConcernDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : The ConcernDefinition that is the single type of this ConcernUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#concernUsage_ConcernDefinition">oslc_sysmlv2:concernUsage_ConcernDefinition</a>
    /// </summary>
    let concernUsage_ConcernDefinition = _prefixId.prefix "concernUsage_ConcernDefinition"

    /// <summary>
    ///   <para>rdfs:label : conjugatedPortDefinition_OriginalPortDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : The original PortDefinition for this ConjugatedPortDefinition, which is the owningNamespace of the ConjugatedPortDefinition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#conjugatedPortDefinition_OriginalPortDefinition">oslc_sysmlv2:conjugatedPortDefinition_OriginalPortDefinition</a>
    /// </summary>
    let conjugatedPortDefinition_OriginalPortDefinition = _prefixId.prefix "conjugatedPortDefinition_OriginalPortDefinition"

    /// <summary>
    ///   <para>rdfs:label : conjugatedPortDefinition_OwnedPortConjugator^^xsd:string</para>
    ///   <para>rdfs:comment : The PortConjugation that is the ownedConjugator of this ConjugatedPortDefinition, linking it to its originalPortDefinition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#conjugatedPortDefinition_OwnedPortConjugator">oslc_sysmlv2:conjugatedPortDefinition_OwnedPortConjugator</a>
    /// </summary>
    let conjugatedPortDefinition_OwnedPortConjugator = _prefixId.prefix "conjugatedPortDefinition_OwnedPortConjugator"

    /// <summary>
    ///   <para>rdfs:label : conjugatedPortTyping_ConjugatedPortDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : The type of this ConjugatedPortTyping considered as a FeatureTyping, which must be a ConjugatedPortDefinition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#conjugatedPortTyping_ConjugatedPortDefinition">oslc_sysmlv2:conjugatedPortTyping_ConjugatedPortDefinition</a>
    /// </summary>
    let conjugatedPortTyping_ConjugatedPortDefinition = _prefixId.prefix "conjugatedPortTyping_ConjugatedPortDefinition"

    /// <summary>
    ///   <para>rdfs:label : conjugatedPortTyping_PortDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : The originalPortDefinition of the conjugatedPortDefinition of this ConjugatedPortTyping.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#conjugatedPortTyping_PortDefinition">oslc_sysmlv2:conjugatedPortTyping_PortDefinition</a>
    /// </summary>
    let conjugatedPortTyping_PortDefinition = _prefixId.prefix "conjugatedPortTyping_PortDefinition"

    /// <summary>
    ///   <para>rdfs:label : conjugation_ConjugatedType^^xsd:string</para>
    ///   <para>rdfs:comment : The Type that is the result of applying Conjugation to the originalType.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#conjugation_ConjugatedType">oslc_sysmlv2:conjugation_ConjugatedType</a>
    /// </summary>
    let conjugation_ConjugatedType = _prefixId.prefix "conjugation_ConjugatedType"
    /// <summary>
    ///   <para>rdfs:label : conjugation_OriginalType^^xsd:string</para>
    ///   <para>rdfs:comment : The Type to be conjugated.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#conjugation_OriginalType">oslc_sysmlv2:conjugation_OriginalType</a>
    /// </summary>
    let conjugation_OriginalType = _prefixId.prefix "conjugation_OriginalType"
    /// <summary>
    ///   <para>rdfs:label : conjugation_OwningType^^xsd:string</para>
    ///   <para>rdfs:comment : The conjugatedType of this Conjugation that is also its owningRelatedElement.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#conjugation_OwningType">oslc_sysmlv2:conjugation_OwningType</a>
    /// </summary>
    let conjugation_OwningType = _prefixId.prefix "conjugation_OwningType"

    /// <summary>
    ///   <para>rdfs:label : connectionDefinition_ConnectionEnd^^xsd:string</para>
    ///   <para>rdfs:comment : The Usages that define the things related by the ConnectionDefinition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#connectionDefinition_ConnectionEnd">oslc_sysmlv2:connectionDefinition_ConnectionEnd</a>
    /// </summary>
    let connectionDefinition_ConnectionEnd = _prefixId.prefix "connectionDefinition_ConnectionEnd"

    /// <summary>
    ///   <para>rdfs:label : connectionUsage_ConnectionDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : The AssociationStructures that are the types of this ConnectionUsage. Nominally, these are , but other kinds of Kernel AssociationStructures are also allowed, to permit use of AssociationStructures from the Kernel Model Libraries.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#connectionUsage_ConnectionDefinition">oslc_sysmlv2:connectionUsage_ConnectionDefinition</a>
    /// </summary>
    let connectionUsage_ConnectionDefinition = _prefixId.prefix "connectionUsage_ConnectionDefinition"

    /// <summary>
    ///   <para>rdfs:label : connector_Association^^xsd:string</para>
    ///   <para>rdfs:comment : The Associations that type the Connector.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#connector_Association">oslc_sysmlv2:connector_Association</a>
    /// </summary>
    let connector_Association = _prefixId.prefix "connector_Association"
    /// <summary>
    ///   <para>rdfs:label : connector_ConnectorEnd^^xsd:string</para>
    ///   <para>rdfs:comment : The endFeatures of a Connector, which redefine the endFeatures of the associations of the Connector. The connectorEnds determine via ReferenceSubsetting Relationships which Features are related by the Connector.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#connector_ConnectorEnd">oslc_sysmlv2:connector_ConnectorEnd</a>
    /// </summary>
    let connector_ConnectorEnd = _prefixId.prefix "connector_ConnectorEnd"
    /// <summary>
    ///   <para>rdfs:label : connector_RelatedFeature^^xsd:string</para>
    ///   <para>rdfs:comment : The Features that are related by this Connector considered as a Relationship and that restrict the links it identifies, given by the referenced Features of the connectorEnds of the Connector.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#connector_RelatedFeature">oslc_sysmlv2:connector_RelatedFeature</a>
    /// </summary>
    let connector_RelatedFeature = _prefixId.prefix "connector_RelatedFeature"
    /// <summary>
    ///   <para>rdfs:label : connector_SourceFeature^^xsd:string</para>
    ///   <para>rdfs:comment : The source relatedFeature for this Connector. It is the first relatedFeature.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#connector_SourceFeature">oslc_sysmlv2:connector_SourceFeature</a>
    /// </summary>
    let connector_SourceFeature = _prefixId.prefix "connector_SourceFeature"
    /// <summary>
    ///   <para>rdfs:label : connector_TargetFeature^^xsd:string</para>
    ///   <para>rdfs:comment : The target relatedFeatures for this Connector. This includes all the relatedFeatures other than the sourceFeature.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#connector_TargetFeature">oslc_sysmlv2:connector_TargetFeature</a>
    /// </summary>
    let connector_TargetFeature = _prefixId.prefix "connector_TargetFeature"

    /// <summary>
    ///   <para>rdfs:label : constraintUsage_ConstraintDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : The (single) Predicate that is the type of this ConstraintUsage. Nominally, this will be a ConstraintDefinition, but other kinds of Predicates are also allowed, to permit use of Predicates from the Kernel Model Libraries.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#constraintUsage_ConstraintDefinition">oslc_sysmlv2:constraintUsage_ConstraintDefinition</a>
    /// </summary>
    let constraintUsage_ConstraintDefinition = _prefixId.prefix "constraintUsage_ConstraintDefinition"

    /// <summary>
    ///   <para>rdfs:label : definition_DirectedUsage^^xsd:string</para>
    ///   <para>rdfs:comment : The usages of this Definition that are directedFeatures.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#definition_DirectedUsage">oslc_sysmlv2:definition_DirectedUsage</a>
    /// </summary>
    let definition_DirectedUsage = _prefixId.prefix "definition_DirectedUsage"
    /// <summary>
    ///   <para>rdfs:label : definition_IsVariation^^xsd:string</para>
    ///   <para>rdfs:comment : Whether this Definition is for a variation point or not. If true, then all the memberships of the Definition must be VariantMemberships.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#definition_IsVariation">oslc_sysmlv2:definition_IsVariation</a>
    /// </summary>
    let definition_IsVariation = _prefixId.prefix "definition_IsVariation"
    /// <summary>
    ///   <para>rdfs:label : definition_OwnedAction^^xsd:string</para>
    ///   <para>rdfs:comment : The ActionUsages that are ownedUsages of this Definition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#definition_OwnedAction">oslc_sysmlv2:definition_OwnedAction</a>
    /// </summary>
    let definition_OwnedAction = _prefixId.prefix "definition_OwnedAction"
    /// <summary>
    ///   <para>rdfs:label : definition_OwnedAllocation^^xsd:string</para>
    ///   <para>rdfs:comment : The AllocationUsages that are ownedUsages of this Definition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#definition_OwnedAllocation">oslc_sysmlv2:definition_OwnedAllocation</a>
    /// </summary>
    let definition_OwnedAllocation = _prefixId.prefix "definition_OwnedAllocation"
    /// <summary>
    ///   <para>rdfs:label : definition_OwnedAnalysisCase^^xsd:string</para>
    ///   <para>rdfs:comment : The AnalysisCaseUsages that are ownedUsages of this Definition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#definition_OwnedAnalysisCase">oslc_sysmlv2:definition_OwnedAnalysisCase</a>
    /// </summary>
    let definition_OwnedAnalysisCase = _prefixId.prefix "definition_OwnedAnalysisCase"
    /// <summary>
    ///   <para>rdfs:label : definition_OwnedAttribute^^xsd:string</para>
    ///   <para>rdfs:comment : The AttributeUsages that are ownedUsages of this Definition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#definition_OwnedAttribute">oslc_sysmlv2:definition_OwnedAttribute</a>
    /// </summary>
    let definition_OwnedAttribute = _prefixId.prefix "definition_OwnedAttribute"
    /// <summary>
    ///   <para>rdfs:label : definition_OwnedCalculation^^xsd:string</para>
    ///   <para>rdfs:comment : The CalculationUsages that are ownedUsages of this Definition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#definition_OwnedCalculation">oslc_sysmlv2:definition_OwnedCalculation</a>
    /// </summary>
    let definition_OwnedCalculation = _prefixId.prefix "definition_OwnedCalculation"
    /// <summary>
    ///   <para>rdfs:label : definition_OwnedCase^^xsd:string</para>
    ///   <para>rdfs:comment : The code&gt;CaseUsages that are ownedUsages of this Definition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#definition_OwnedCase">oslc_sysmlv2:definition_OwnedCase</a>
    /// </summary>
    let definition_OwnedCase = _prefixId.prefix "definition_OwnedCase"
    /// <summary>
    ///   <para>rdfs:label : definition_OwnedConcern^^xsd:string</para>
    ///   <para>rdfs:comment : The ConcernUsages that are ownedUsages of this Definition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#definition_OwnedConcern">oslc_sysmlv2:definition_OwnedConcern</a>
    /// </summary>
    let definition_OwnedConcern = _prefixId.prefix "definition_OwnedConcern"
    /// <summary>
    ///   <para>rdfs:label : definition_OwnedConnection^^xsd:string</para>
    ///   <para>rdfs:comment : The ConnectorAsUsages that are ownedUsages of this Definition. Note that this list includes BindingConnectorAsUsages and SuccessionAsUsages, even though these are ConnectorAsUsages but not ConnectionUsages.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#definition_OwnedConnection">oslc_sysmlv2:definition_OwnedConnection</a>
    /// </summary>
    let definition_OwnedConnection = _prefixId.prefix "definition_OwnedConnection"
    /// <summary>
    ///   <para>rdfs:label : definition_OwnedConstraint^^xsd:string</para>
    ///   <para>rdfs:comment : The ConstraintUsages that are ownedUsages of this Definition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#definition_OwnedConstraint">oslc_sysmlv2:definition_OwnedConstraint</a>
    /// </summary>
    let definition_OwnedConstraint = _prefixId.prefix "definition_OwnedConstraint"
    /// <summary>
    ///   <para>rdfs:label : definition_OwnedEnumeration^^xsd:string</para>
    ///   <para>rdfs:comment : The EnumerationUsages that are ownedUsages of this Definition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#definition_OwnedEnumeration">oslc_sysmlv2:definition_OwnedEnumeration</a>
    /// </summary>
    let definition_OwnedEnumeration = _prefixId.prefix "definition_OwnedEnumeration"
    /// <summary>
    ///   <para>rdfs:label : definition_OwnedFlow^^xsd:string</para>
    ///   <para>rdfs:comment : The FlowConnectionUsages that are ownedUsages of this Definition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#definition_OwnedFlow">oslc_sysmlv2:definition_OwnedFlow</a>
    /// </summary>
    let definition_OwnedFlow = _prefixId.prefix "definition_OwnedFlow"
    /// <summary>
    ///   <para>rdfs:label : definition_OwnedInterface^^xsd:string</para>
    ///   <para>rdfs:comment : The InterfaceUsages that are ownedUsages of this Definition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#definition_OwnedInterface">oslc_sysmlv2:definition_OwnedInterface</a>
    /// </summary>
    let definition_OwnedInterface = _prefixId.prefix "definition_OwnedInterface"
    /// <summary>
    ///   <para>rdfs:label : definition_OwnedItem^^xsd:string</para>
    ///   <para>rdfs:comment : The ItemUsages that are ownedUsages of this Definition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#definition_OwnedItem">oslc_sysmlv2:definition_OwnedItem</a>
    /// </summary>
    let definition_OwnedItem = _prefixId.prefix "definition_OwnedItem"
    /// <summary>
    ///   <para>rdfs:label : definition_OwnedMetadata^^xsd:string</para>
    ///   <para>rdfs:comment : The MetadataUsages that are ownedUsages of this Definition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#definition_OwnedMetadata">oslc_sysmlv2:definition_OwnedMetadata</a>
    /// </summary>
    let definition_OwnedMetadata = _prefixId.prefix "definition_OwnedMetadata"
    /// <summary>
    ///   <para>rdfs:label : definition_OwnedOccurrence^^xsd:string</para>
    ///   <para>rdfs:comment : The OccurrenceUsages that are ownedUsages of this Definition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#definition_OwnedOccurrence">oslc_sysmlv2:definition_OwnedOccurrence</a>
    /// </summary>
    let definition_OwnedOccurrence = _prefixId.prefix "definition_OwnedOccurrence"
    /// <summary>
    ///   <para>rdfs:label : definition_OwnedPart^^xsd:string</para>
    ///   <para>rdfs:comment : The PartUsages that are ownedUsages of this Definition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#definition_OwnedPart">oslc_sysmlv2:definition_OwnedPart</a>
    /// </summary>
    let definition_OwnedPart = _prefixId.prefix "definition_OwnedPart"
    /// <summary>
    ///   <para>rdfs:label : definition_OwnedPort^^xsd:string</para>
    ///   <para>rdfs:comment : The PortUsages that are ownedUsages of this Definition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#definition_OwnedPort">oslc_sysmlv2:definition_OwnedPort</a>
    /// </summary>
    let definition_OwnedPort = _prefixId.prefix "definition_OwnedPort"
    /// <summary>
    ///   <para>rdfs:label : definition_OwnedReference^^xsd:string</para>
    ///   <para>rdfs:comment : The ReferenceUsages that are ownedUsages of this Definition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#definition_OwnedReference">oslc_sysmlv2:definition_OwnedReference</a>
    /// </summary>
    let definition_OwnedReference = _prefixId.prefix "definition_OwnedReference"
    /// <summary>
    ///   <para>rdfs:label : definition_OwnedRendering^^xsd:string</para>
    ///   <para>rdfs:comment : The RenderingUsages that are ownedUsages of this Definition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#definition_OwnedRendering">oslc_sysmlv2:definition_OwnedRendering</a>
    /// </summary>
    let definition_OwnedRendering = _prefixId.prefix "definition_OwnedRendering"
    /// <summary>
    ///   <para>rdfs:label : definition_OwnedRequirement^^xsd:string</para>
    ///   <para>rdfs:comment : The RequirementUsages that are ownedUsages of this Definition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#definition_OwnedRequirement">oslc_sysmlv2:definition_OwnedRequirement</a>
    /// </summary>
    let definition_OwnedRequirement = _prefixId.prefix "definition_OwnedRequirement"
    /// <summary>
    ///   <para>rdfs:label : definition_OwnedState^^xsd:string</para>
    ///   <para>rdfs:comment : The StateUsages that are ownedUsages of this Definition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#definition_OwnedState">oslc_sysmlv2:definition_OwnedState</a>
    /// </summary>
    let definition_OwnedState = _prefixId.prefix "definition_OwnedState"
    /// <summary>
    ///   <para>rdfs:label : definition_OwnedTransition^^xsd:string</para>
    ///   <para>rdfs:comment : The TransitionUsages that are ownedUsages of this Definition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#definition_OwnedTransition">oslc_sysmlv2:definition_OwnedTransition</a>
    /// </summary>
    let definition_OwnedTransition = _prefixId.prefix "definition_OwnedTransition"
    /// <summary>
    ///   <para>rdfs:label : definition_OwnedUsage^^xsd:string</para>
    ///   <para>rdfs:comment : The Usages that are ownedFeatures of this Definition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#definition_OwnedUsage">oslc_sysmlv2:definition_OwnedUsage</a>
    /// </summary>
    let definition_OwnedUsage = _prefixId.prefix "definition_OwnedUsage"
    /// <summary>
    ///   <para>rdfs:label : definition_OwnedUseCase^^xsd:string</para>
    ///   <para>rdfs:comment : The UseCaseUsages that are ownedUsages of this Definition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#definition_OwnedUseCase">oslc_sysmlv2:definition_OwnedUseCase</a>
    /// </summary>
    let definition_OwnedUseCase = _prefixId.prefix "definition_OwnedUseCase"

    /// <summary>
    ///   <para>rdfs:label : definition_OwnedVerificationCase^^xsd:string</para>
    ///   <para>rdfs:comment : The VerificationCaseUsages that are ownedUsages of this Definition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#definition_OwnedVerificationCase">oslc_sysmlv2:definition_OwnedVerificationCase</a>
    /// </summary>
    let definition_OwnedVerificationCase = _prefixId.prefix "definition_OwnedVerificationCase"

    /// <summary>
    ///   <para>rdfs:label : definition_OwnedView^^xsd:string</para>
    ///   <para>rdfs:comment : The ViewUsages that are ownedUsages of this Definition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#definition_OwnedView">oslc_sysmlv2:definition_OwnedView</a>
    /// </summary>
    let definition_OwnedView = _prefixId.prefix "definition_OwnedView"
    /// <summary>
    ///   <para>rdfs:label : definition_OwnedViewpoint^^xsd:string</para>
    ///   <para>rdfs:comment : The ViewpointUsages that are ownedUsages of this Definition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#definition_OwnedViewpoint">oslc_sysmlv2:definition_OwnedViewpoint</a>
    /// </summary>
    let definition_OwnedViewpoint = _prefixId.prefix "definition_OwnedViewpoint"
    /// <summary>
    ///   <para>rdfs:label : definition_Usage^^xsd:string</para>
    ///   <para>rdfs:comment : The Usages that are features of this Definition (not necessarily owned).^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#definition_Usage">oslc_sysmlv2:definition_Usage</a>
    /// </summary>
    let definition_Usage = _prefixId.prefix "definition_Usage"
    /// <summary>
    ///   <para>rdfs:label : definition_Variant^^xsd:string</para>
    ///   <para>rdfs:comment : The Usages which represent the variants of this Definition as a variation point Definition, if isVariation = true. If isVariation = false, the there must be no variants.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#definition_Variant">oslc_sysmlv2:definition_Variant</a>
    /// </summary>
    let definition_Variant = _prefixId.prefix "definition_Variant"
    /// <summary>
    ///   <para>rdfs:label : definition_VariantMembership^^xsd:string</para>
    ///   <para>rdfs:comment : The ownedMemberships of this Definition that are VariantMemberships. If isVariation = true, then this must be all ownedMemberships of the Definition. If isVariation = false, then variantMembershipmust be empty.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#definition_VariantMembership">oslc_sysmlv2:definition_VariantMembership</a>
    /// </summary>
    let definition_VariantMembership = _prefixId.prefix "definition_VariantMembership"
    /// <summary>
    ///   <para>rdfs:label : dependency_Client^^xsd:string</para>
    ///   <para>rdfs:comment : The Element or Elements dependent on the supplier Elements.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#dependency_Client">oslc_sysmlv2:dependency_Client</a>
    /// </summary>
    let dependency_Client = _prefixId.prefix "dependency_Client"
    /// <summary>
    ///   <para>rdfs:label : dependency_Supplier^^xsd:string</para>
    ///   <para>rdfs:comment : The Element or Elements on which the client Elements depend in some respect.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#dependency_Supplier">oslc_sysmlv2:dependency_Supplier</a>
    /// </summary>
    let dependency_Supplier = _prefixId.prefix "dependency_Supplier"
    /// <summary>
    ///   <para>rdfs:label : differencing_DifferencingType^^xsd:string</para>
    ///   <para>rdfs:comment : Type that partly determines interpretations of typeDifferenced, as described in Type::differencingType.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#differencing_DifferencingType">oslc_sysmlv2:differencing_DifferencingType</a>
    /// </summary>
    let differencing_DifferencingType = _prefixId.prefix "differencing_DifferencingType"
    /// <summary>
    ///   <para>rdfs:label : differencing_TypeDifferenced^^xsd:string</para>
    ///   <para>rdfs:comment : Type with interpretations partly determined by differencingType, as described in Type::differencingType.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#differencing_TypeDifferenced">oslc_sysmlv2:differencing_TypeDifferenced</a>
    /// </summary>
    let differencing_TypeDifferenced = _prefixId.prefix "differencing_TypeDifferenced"
    /// <summary>
    ///   <para>rdfs:label : disjoining_DisjoiningType^^xsd:string</para>
    ///   <para>rdfs:comment : Type asserted to be disjoint with the typeDisjoined.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#disjoining_DisjoiningType">oslc_sysmlv2:disjoining_DisjoiningType</a>
    /// </summary>
    let disjoining_DisjoiningType = _prefixId.prefix "disjoining_DisjoiningType"
    /// <summary>
    ///   <para>rdfs:label : disjoining_OwningType^^xsd:string</para>
    ///   <para>rdfs:comment : A typeDisjoined that is also an owningRelatedElement.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#disjoining_OwningType">oslc_sysmlv2:disjoining_OwningType</a>
    /// </summary>
    let disjoining_OwningType = _prefixId.prefix "disjoining_OwningType"
    /// <summary>
    ///   <para>rdfs:label : disjoining_TypeDisjoined^^xsd:string</para>
    ///   <para>rdfs:comment : Type asserted to be disjoint with the disjoiningType.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#disjoining_TypeDisjoined">oslc_sysmlv2:disjoining_TypeDisjoined</a>
    /// </summary>
    let disjoining_TypeDisjoined = _prefixId.prefix "disjoining_TypeDisjoined"

    /// <summary>
    ///   <para>rdfs:label : documentation_DocumentedElement^^xsd:string</para>
    ///   <para>rdfs:comment : The Element that is documented by this Documentation.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#documentation_DocumentedElement">oslc_sysmlv2:documentation_DocumentedElement</a>
    /// </summary>
    let documentation_DocumentedElement = _prefixId.prefix "documentation_DocumentedElement"

    /// <summary>
    ///   <para>rdfs:label : elementFilterMembership_Condition^^xsd:string</para>
    ///   <para>rdfs:comment : The model-level evaluable Boolean-valued Expression used to filter the imported members of the membershipOwningNamespace of this ElementFilterMembership.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#elementFilterMembership_Condition">oslc_sysmlv2:elementFilterMembership_Condition</a>
    /// </summary>
    let elementFilterMembership_Condition = _prefixId.prefix "elementFilterMembership_Condition"

    /// <summary>
    ///   <para>rdfs:label : element_AliasIds^^xsd:string</para>
    ///   <para>rdfs:comment : Various alternative identifiers for this Element. Generally, these will be set by tools.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#element_AliasIds">oslc_sysmlv2:element_AliasIds</a>
    /// </summary>
    let element_AliasIds = _prefixId.prefix "element_AliasIds"
    /// <summary>
    ///   <para>rdfs:label : element_DeclaredName^^xsd:string</para>
    ///   <para>rdfs:comment : The declared name of this Element.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#element_DeclaredName">oslc_sysmlv2:element_DeclaredName</a>
    /// </summary>
    let element_DeclaredName = _prefixId.prefix "element_DeclaredName"
    /// <summary>
    ///   <para>rdfs:label : element_DeclaredShortName^^xsd:string</para>
    ///   <para>rdfs:comment : An optional alternative name for the Element that is intended to be shorter or in some way more succinct than its primary name. It may act as a modeler-specified identifier for the Element, though it is then the responsibility of the modeler to maintain the uniqueness of this identifier within a model or relative to some other context.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#element_DeclaredShortName">oslc_sysmlv2:element_DeclaredShortName</a>
    /// </summary>
    let element_DeclaredShortName = _prefixId.prefix "element_DeclaredShortName"
    /// <summary>
    ///   <para>rdfs:label : element_Documentation^^xsd:string</para>
    ///   <para>rdfs:comment : The Documentation owned by this Element.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#element_Documentation">oslc_sysmlv2:element_Documentation</a>
    /// </summary>
    let element_Documentation = _prefixId.prefix "element_Documentation"
    /// <summary>
    ///   <para>rdfs:label : element_ElementId^^xsd:string</para>
    ///   <para>rdfs:comment : The globally unique identifier for this Element. This is intended to be set by tooling, and it must not change during the lifetime of the Element.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#element_ElementId">oslc_sysmlv2:element_ElementId</a>
    /// </summary>
    let element_ElementId = _prefixId.prefix "element_ElementId"
    /// <summary>
    ///   <para>rdfs:label : element_IsImpliedIncluded^^xsd:string</para>
    ///   <para>rdfs:comment : Whether all necessary implied Relationships have been included in the ownedRelationships of this Element. This property may be true, even if there are not actually any ownedRelationships with isImplied = true, meaning that no such Relationships are actually implied for this Element. However, if it is false, then ownedRelationships may not contain any implied Relationships. That is, either all required implied Relationships must be included, or none of them.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#element_IsImpliedIncluded">oslc_sysmlv2:element_IsImpliedIncluded</a>
    /// </summary>
    let element_IsImpliedIncluded = _prefixId.prefix "element_IsImpliedIncluded"
    /// <summary>
    ///   <para>rdfs:label : element_IsLibraryElement^^xsd:string</para>
    ///   <para>rdfs:comment : Whether this Element is contained in the ownership tree of a library model.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#element_IsLibraryElement">oslc_sysmlv2:element_IsLibraryElement</a>
    /// </summary>
    let element_IsLibraryElement = _prefixId.prefix "element_IsLibraryElement"
    /// <summary>
    ///   <para>rdfs:label : element_Name^^xsd:string</para>
    ///   <para>rdfs:comment : The name to be used for this Element during name resolution within its owningNamespace. This is derived using the effectiveName() operation. By default, it is the same as the declaredName, but this is overridden for certain kinds of Elements to compute a name even when the declaredName is null.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#element_Name">oslc_sysmlv2:element_Name</a>
    /// </summary>
    let element_Name = _prefixId.prefix "element_Name"
    /// <summary>
    ///   <para>rdfs:label : element_OwnedAnnotation^^xsd:string</para>
    ///   <para>rdfs:comment : The ownedRelationships of this Element that are Annotations, for which this Element is the annotatedElement.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#element_OwnedAnnotation">oslc_sysmlv2:element_OwnedAnnotation</a>
    /// </summary>
    let element_OwnedAnnotation = _prefixId.prefix "element_OwnedAnnotation"
    /// <summary>
    ///   <para>rdfs:label : element_OwnedElement^^xsd:string</para>
    ///   <para>rdfs:comment : The Elements owned by this Element, derived as the ownedRelatedElements of the ownedRelationships of this Element.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#element_OwnedElement">oslc_sysmlv2:element_OwnedElement</a>
    /// </summary>
    let element_OwnedElement = _prefixId.prefix "element_OwnedElement"
    /// <summary>
    ///   <para>rdfs:label : element_OwnedRelationship^^xsd:string</para>
    ///   <para>rdfs:comment : The Relationships for which this Element is the owningRelatedElement.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#element_OwnedRelationship">oslc_sysmlv2:element_OwnedRelationship</a>
    /// </summary>
    let element_OwnedRelationship = _prefixId.prefix "element_OwnedRelationship"
    /// <summary>
    ///   <para>rdfs:label : element_Owner^^xsd:string</para>
    ///   <para>rdfs:comment : The owner of this Element, derived as the owningRelatedElement of the owningRelationship of this Element, if any.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#element_Owner">oslc_sysmlv2:element_Owner</a>
    /// </summary>
    let element_Owner = _prefixId.prefix "element_Owner"
    /// <summary>
    ///   <para>rdfs:label : element_OwningMembership^^xsd:string</para>
    ///   <para>rdfs:comment : The owningRelationship of this Element, if that Relationship is a Membership.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#element_OwningMembership">oslc_sysmlv2:element_OwningMembership</a>
    /// </summary>
    let element_OwningMembership = _prefixId.prefix "element_OwningMembership"
    /// <summary>
    ///   <para>rdfs:label : element_OwningNamespace^^xsd:string</para>
    ///   <para>rdfs:comment : The Namespace that owns this Element, which is the membershipOwningNamespace of the owningMembership of this Element, if any.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#element_OwningNamespace">oslc_sysmlv2:element_OwningNamespace</a>
    /// </summary>
    let element_OwningNamespace = _prefixId.prefix "element_OwningNamespace"
    /// <summary>
    ///   <para>rdfs:label : element_OwningRelationship^^xsd:string</para>
    ///   <para>rdfs:comment : The Relationship for which this Element is an ownedRelatedElement, if any.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#element_OwningRelationship">oslc_sysmlv2:element_OwningRelationship</a>
    /// </summary>
    let element_OwningRelationship = _prefixId.prefix "element_OwningRelationship"
    /// <summary>
    ///   <para>rdfs:label : element_QualifiedName^^xsd:string</para>
    ///   <para>rdfs:comment : The full ownership-qualified name of this Element, represented in a form that is valid according to the KerML textual concrete syntax for qualified names (including use of unrestricted name notation and escaped characters, as necessary). The qualifiedName is null if this Element has no owningNamespace or if there is not a complete ownership chain of named Namespaces from a root Namespace to this Element.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#element_QualifiedName">oslc_sysmlv2:element_QualifiedName</a>
    /// </summary>
    let element_QualifiedName = _prefixId.prefix "element_QualifiedName"
    /// <summary>
    ///   <para>rdfs:label : element_ShortName^^xsd:string</para>
    ///   <para>rdfs:comment : The short name to be used for this Element during name resolution within its owningNamespace. This is derived using the effectiveShortName() operation. By default, it is the same as the declaredShortName, but this is overridden for certain kinds of Elements to compute a shortName even when the declaredName is null.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#element_ShortName">oslc_sysmlv2:element_ShortName</a>
    /// </summary>
    let element_ShortName = _prefixId.prefix "element_ShortName"
    /// <summary>
    ///   <para>rdfs:label : element_TextualRepresentation^^xsd:string</para>
    ///   <para>rdfs:comment : The TextualRepresentations that annotate this Element.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#element_TextualRepresentation">oslc_sysmlv2:element_TextualRepresentation</a>
    /// </summary>
    let element_TextualRepresentation = _prefixId.prefix "element_TextualRepresentation"

    /// <summary>
    ///   <para>rdfs:label : enumerationDefinition_EnumeratedValue^^xsd:string</para>
    ///   <para>rdfs:comment : EnumerationUsages of this EnumerationDefinitionthat have distinct, fixed values. Each enumeratedValue specifies one of the allowed instances of the EnumerationDefinition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#enumerationDefinition_EnumeratedValue">oslc_sysmlv2:enumerationDefinition_EnumeratedValue</a>
    /// </summary>
    let enumerationDefinition_EnumeratedValue = _prefixId.prefix "enumerationDefinition_EnumeratedValue"

    /// <summary>
    ///   <para>rdfs:label : enumerationUsage_EnumerationDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : The single EnumerationDefinition that is the type of this EnumerationUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#enumerationUsage_EnumerationDefinition">oslc_sysmlv2:enumerationUsage_EnumerationDefinition</a>
    /// </summary>
    let enumerationUsage_EnumerationDefinition = _prefixId.prefix "enumerationUsage_EnumerationDefinition"

    /// <summary>
    ///   <para>rdfs:label : eventOccurrenceUsage_EventOccurrence^^xsd:string</para>
    ///   <para>rdfs:comment : The OccurrenceUsage referenced as an event by this EventOccurrenceUsage. It is the referenceFeature of the ownedReferenceSubsetting for the EventOccurrenceUsage, if there is one, and, otherwise, the EventOccurrenceUsage itself.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#eventOccurrenceUsage_EventOccurrence">oslc_sysmlv2:eventOccurrenceUsage_EventOccurrence</a>
    /// </summary>
    let eventOccurrenceUsage_EventOccurrence = _prefixId.prefix "eventOccurrenceUsage_EventOccurrence"

    /// <summary>
    ///   <para>rdfs:label : exhibitStateUsage_ExhibitedState^^xsd:string</para>
    ///   <para>rdfs:comment : The StateUsage to be exhibited by the ExhibitStateUsage. It is the performedAction of the ExhibitStateUsage considered as a PerformActionUsage, which must be a StateUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#exhibitStateUsage_ExhibitedState">oslc_sysmlv2:exhibitStateUsage_ExhibitedState</a>
    /// </summary>
    let exhibitStateUsage_ExhibitedState = _prefixId.prefix "exhibitStateUsage_ExhibitedState"

    /// <summary>
    ///   <para>rdfs:label : expression_Function^^xsd:string</para>
    ///   <para>rdfs:comment : The Function that types this Expression.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#expression_Function">oslc_sysmlv2:expression_Function</a>
    /// </summary>
    let expression_Function = _prefixId.prefix "expression_Function"

    /// <summary>
    ///   <para>rdfs:label : expression_IsModelLevelEvaluable^^xsd:string</para>
    ///   <para>rdfs:comment : Whether this Expression meets the constraints necessary to be evaluated at model level, that is, using metadata within the model.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#expression_IsModelLevelEvaluable">oslc_sysmlv2:expression_IsModelLevelEvaluable</a>
    /// </summary>
    let expression_IsModelLevelEvaluable = _prefixId.prefix "expression_IsModelLevelEvaluable"

    /// <summary>
    ///   <para>rdfs:label : expression_Result^^xsd:string</para>
    ///   <para>rdfs:comment : result.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#expression_Result">oslc_sysmlv2:expression_Result</a>
    /// </summary>
    let expression_Result = _prefixId.prefix "expression_Result"

    /// <summary>
    ///   <para>rdfs:label : featureChainExpression_TargetFeature^^xsd:string</para>
    ///   <para>rdfs:comment : The Feature that is accessed by this FeatureChainExpression, which is its first non-parameter member.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#featureChainExpression_TargetFeature">oslc_sysmlv2:featureChainExpression_TargetFeature</a>
    /// </summary>
    let featureChainExpression_TargetFeature = _prefixId.prefix "featureChainExpression_TargetFeature"

    /// <summary>
    ///   <para>rdfs:label : featureChaining_ChainingFeature^^xsd:string</para>
    ///   <para>rdfs:comment : The Feature whose values partly determine values of featureChained, as described in Feature::chainingFeature.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#featureChaining_ChainingFeature">oslc_sysmlv2:featureChaining_ChainingFeature</a>
    /// </summary>
    let featureChaining_ChainingFeature = _prefixId.prefix "featureChaining_ChainingFeature"

    /// <summary>
    ///   <para>rdfs:label : featureChaining_FeatureChained^^xsd:string</para>
    ///   <para>rdfs:comment : The Feature whose values are partly determined by values of the chainingFeature, as described in Feature::chainingFeature.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#featureChaining_FeatureChained">oslc_sysmlv2:featureChaining_FeatureChained</a>
    /// </summary>
    let featureChaining_FeatureChained = _prefixId.prefix "featureChaining_FeatureChained"

    let featureDirectionKind_In = _prefixId.prefix "featureDirectionKind_In"
    let featureDirectionKind_Inout = _prefixId.prefix "featureDirectionKind_Inout"
    let featureDirectionKind_Out = _prefixId.prefix "featureDirectionKind_Out"

    /// <summary>
    ///   <para>rdfs:label : featureInverting_FeatureInverted^^xsd:string</para>
    ///   <para>rdfs:comment : The Feature that is an inverse of the invertingFeature.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#featureInverting_FeatureInverted">oslc_sysmlv2:featureInverting_FeatureInverted</a>
    /// </summary>
    let featureInverting_FeatureInverted = _prefixId.prefix "featureInverting_FeatureInverted"

    /// <summary>
    ///   <para>rdfs:label : featureInverting_InvertingFeature^^xsd:string</para>
    ///   <para>rdfs:comment : The Feature that is an inverse of the invertedFeature.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#featureInverting_InvertingFeature">oslc_sysmlv2:featureInverting_InvertingFeature</a>
    /// </summary>
    let featureInverting_InvertingFeature = _prefixId.prefix "featureInverting_InvertingFeature"

    /// <summary>
    ///   <para>rdfs:label : featureInverting_OwningFeature^^xsd:string</para>
    ///   <para>rdfs:comment : A featureInverted that is also the owningRelatedElement of this FeatureInverting.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#featureInverting_OwningFeature">oslc_sysmlv2:featureInverting_OwningFeature</a>
    /// </summary>
    let featureInverting_OwningFeature = _prefixId.prefix "featureInverting_OwningFeature"

    /// <summary>
    ///   <para>rdfs:label : featureMembership_OwnedMemberFeature^^xsd:string</para>
    ///   <para>rdfs:comment : The Feature that this FeatureMembership relates to its owningType, making it an ownedFeature of the owningType.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#featureMembership_OwnedMemberFeature">oslc_sysmlv2:featureMembership_OwnedMemberFeature</a>
    /// </summary>
    let featureMembership_OwnedMemberFeature = _prefixId.prefix "featureMembership_OwnedMemberFeature"

    /// <summary>
    ///   <para>rdfs:label : featureMembership_OwningType^^xsd:string</para>
    ///   <para>rdfs:comment : The Type that owns this FeatureMembership.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#featureMembership_OwningType">oslc_sysmlv2:featureMembership_OwningType</a>
    /// </summary>
    let featureMembership_OwningType = _prefixId.prefix "featureMembership_OwningType"

    /// <summary>
    ///   <para>rdfs:label : featureReferenceExpression_Referent^^xsd:string</para>
    ///   <para>rdfs:comment : The Feature that is referenced by this FeatureReferenceExpression, which is its first non-parameter member.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#featureReferenceExpression_Referent">oslc_sysmlv2:featureReferenceExpression_Referent</a>
    /// </summary>
    let featureReferenceExpression_Referent = _prefixId.prefix "featureReferenceExpression_Referent"

    /// <summary>
    ///   <para>rdfs:label : featureTyping_OwningFeature^^xsd:string</para>
    ///   <para>rdfs:comment : A typedFeature that is also the owningRelatedElement of this FeatureTyping.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#featureTyping_OwningFeature">oslc_sysmlv2:featureTyping_OwningFeature</a>
    /// </summary>
    let featureTyping_OwningFeature = _prefixId.prefix "featureTyping_OwningFeature"
    /// <summary>
    ///   <para>rdfs:label : featureTyping_Type^^xsd:string</para>
    ///   <para>rdfs:comment : The Type that is being applied by this FeatureTyping.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#featureTyping_Type">oslc_sysmlv2:featureTyping_Type</a>
    /// </summary>
    let featureTyping_Type = _prefixId.prefix "featureTyping_Type"
    /// <summary>
    ///   <para>rdfs:label : featureTyping_TypedFeature^^xsd:string</para>
    ///   <para>rdfs:comment : The Feature that has a type determined by this FeatureTyping.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#featureTyping_TypedFeature">oslc_sysmlv2:featureTyping_TypedFeature</a>
    /// </summary>
    let featureTyping_TypedFeature = _prefixId.prefix "featureTyping_TypedFeature"
    /// <summary>
    ///   <para>rdfs:label : featureValue_FeatureWithValue^^xsd:string</para>
    ///   <para>rdfs:comment : The Feature to be provided a value.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#featureValue_FeatureWithValue">oslc_sysmlv2:featureValue_FeatureWithValue</a>
    /// </summary>
    let featureValue_FeatureWithValue = _prefixId.prefix "featureValue_FeatureWithValue"
    /// <summary>
    ///   <para>rdfs:label : featureValue_IsDefault^^xsd:string</para>
    ///   <para>rdfs:comment : Whether this FeatureValue is a concrete specification of the bound or initial value of the featureWithValue, or just a default value that may be overridden.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#featureValue_IsDefault">oslc_sysmlv2:featureValue_IsDefault</a>
    /// </summary>
    let featureValue_IsDefault = _prefixId.prefix "featureValue_IsDefault"
    /// <summary>
    ///   <para>rdfs:label : featureValue_IsInitial^^xsd:string</para>
    ///   <para>rdfs:comment : Whether this FeatureValue specifies a bound value or an initial value for the featureWithValue.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#featureValue_IsInitial">oslc_sysmlv2:featureValue_IsInitial</a>
    /// </summary>
    let featureValue_IsInitial = _prefixId.prefix "featureValue_IsInitial"
    /// <summary>
    ///   <para>rdfs:label : featureValue_Value^^xsd:string</para>
    ///   <para>rdfs:comment : The Expression that provides the value of the featureWithValue as its result.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#featureValue_Value">oslc_sysmlv2:featureValue_Value</a>
    /// </summary>
    let featureValue_Value = _prefixId.prefix "featureValue_Value"
    /// <summary>
    ///   <para>rdfs:label : feature_ChainingFeature^^xsd:string</para>
    ///   <para>rdfs:comment : The Feature that are chained together to determine the values of this Feature, derived from the chainingFeatures of the ownedFeatureChainings of this Feature, in the same order. The values of a Feature with chainingFeatures are the same as values of the last Feature in the chain, which can be found by starting with the values of the first Feature (for each instance of the domain of the original Feature), then using each of those as domain instances to find the values of the second Feature in chainingFeatures, and so on, to values of the last Feature.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#feature_ChainingFeature">oslc_sysmlv2:feature_ChainingFeature</a>
    /// </summary>
    let feature_ChainingFeature = _prefixId.prefix "feature_ChainingFeature"
    /// <summary>
    ///   <para>rdfs:label : feature_Direction^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates how values of this Feature are determined or used (as specified for the FeatureDirectionKind).^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#feature_Direction">oslc_sysmlv2:feature_Direction</a>
    /// </summary>
    let feature_Direction = _prefixId.prefix "feature_Direction"
    /// <summary>
    ///   <para>rdfs:label : feature_EndOwningType^^xsd:string</para>
    ///   <para>rdfs:comment : The Type that is related to this Feature by an EndFeatureMembership in which the Feature is an ownedMemberFeature.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#feature_EndOwningType">oslc_sysmlv2:feature_EndOwningType</a>
    /// </summary>
    let feature_EndOwningType = _prefixId.prefix "feature_EndOwningType"
    /// <summary>
    ///   <para>rdfs:label : feature_FeaturingType^^xsd:string</para>
    ///   <para>rdfs:comment : Types that feature this Feature, such that any instance in the domain of the Feature must be classified by all of these Types, including at least all the featuringTypes of its typeFeaturings.  If the Feature is chained, then the featuringTypes of the first Feature in the chain are also featuringTypes of the chained Feature.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#feature_FeaturingType">oslc_sysmlv2:feature_FeaturingType</a>
    /// </summary>
    let feature_FeaturingType = _prefixId.prefix "feature_FeaturingType"
    /// <summary>
    ///   <para>rdfs:label : feature_IsComposite^^xsd:string</para>
    ///   <para>rdfs:comment : Whether the Feature is a composite feature of its featuringType. If so, the values of the Feature cannot exist after its featuring instance no longer does.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#feature_IsComposite">oslc_sysmlv2:feature_IsComposite</a>
    /// </summary>
    let feature_IsComposite = _prefixId.prefix "feature_IsComposite"
    /// <summary>
    ///   <para>rdfs:label : feature_IsDerived^^xsd:string</para>
    ///   <para>rdfs:comment : Whether the values of this Feature can always be computed from the values of other Features.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#feature_IsDerived">oslc_sysmlv2:feature_IsDerived</a>
    /// </summary>
    let feature_IsDerived = _prefixId.prefix "feature_IsDerived"
    /// <summary>
    ///   <para>rdfs:label : feature_IsEnd^^xsd:string</para>
    ///   <para>rdfs:comment : Whether or not the this Feature is an end Feature, requiring a different interpretation of the multiplicity of the Feature.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#feature_IsEnd">oslc_sysmlv2:feature_IsEnd</a>
    /// </summary>
    let feature_IsEnd = _prefixId.prefix "feature_IsEnd"
    /// <summary>
    ///   <para>rdfs:label : feature_IsNonunique^^xsd:string</para>
    ///   <para>rdfs:comment : isNonunique.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#feature_IsNonunique">oslc_sysmlv2:feature_IsNonunique</a>
    /// </summary>
    let feature_IsNonunique = _prefixId.prefix "feature_IsNonunique"
    /// <summary>
    ///   <para>rdfs:label : feature_IsOrdered^^xsd:string</para>
    ///   <para>rdfs:comment : Whether an order exists for the values of this Feature or not.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#feature_IsOrdered">oslc_sysmlv2:feature_IsOrdered</a>
    /// </summary>
    let feature_IsOrdered = _prefixId.prefix "feature_IsOrdered"
    /// <summary>
    ///   <para>rdfs:label : feature_IsPortion^^xsd:string</para>
    ///   <para>rdfs:comment : Whether the values of this Feature are contained in the space and time of instances of the domain of the Feature and represent the same thing as those instances.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#feature_IsPortion">oslc_sysmlv2:feature_IsPortion</a>
    /// </summary>
    let feature_IsPortion = _prefixId.prefix "feature_IsPortion"
    /// <summary>
    ///   <para>rdfs:label : feature_IsReadOnly^^xsd:string</para>
    ///   <para>rdfs:comment : Whether the values of this Feature can change over the lifetime of an instance of the domain.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#feature_IsReadOnly">oslc_sysmlv2:feature_IsReadOnly</a>
    /// </summary>
    let feature_IsReadOnly = _prefixId.prefix "feature_IsReadOnly"
    /// <summary>
    ///   <para>rdfs:label : feature_IsUnique^^xsd:string</para>
    ///   <para>rdfs:comment : Whether or not values for this Feature must have no duplicates or not.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#feature_IsUnique">oslc_sysmlv2:feature_IsUnique</a>
    /// </summary>
    let feature_IsUnique = _prefixId.prefix "feature_IsUnique"
    /// <summary>
    ///   <para>rdfs:label : feature_OwnedFeatureChaining^^xsd:string</para>
    ///   <para>rdfs:comment : The ownedRelationships of this Feature that are FeatureChainings, for which the Feature will be the featureChained.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#feature_OwnedFeatureChaining">oslc_sysmlv2:feature_OwnedFeatureChaining</a>
    /// </summary>
    let feature_OwnedFeatureChaining = _prefixId.prefix "feature_OwnedFeatureChaining"
    /// <summary>
    ///   <para>rdfs:label : feature_OwnedFeatureInverting^^xsd:string</para>
    ///   <para>rdfs:comment : The ownedRelationships of this Feature that are FeatureInvertings and for which the Feature is the featureInverted.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#feature_OwnedFeatureInverting">oslc_sysmlv2:feature_OwnedFeatureInverting</a>
    /// </summary>
    let feature_OwnedFeatureInverting = _prefixId.prefix "feature_OwnedFeatureInverting"
    /// <summary>
    ///   <para>rdfs:label : feature_OwnedRedefinition^^xsd:string</para>
    ///   <para>rdfs:comment : The ownedSubsettings of this Feature that are Redefinitions, for which the Feature is the redefiningFeature.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#feature_OwnedRedefinition">oslc_sysmlv2:feature_OwnedRedefinition</a>
    /// </summary>
    let feature_OwnedRedefinition = _prefixId.prefix "feature_OwnedRedefinition"

    /// <summary>
    ///   <para>rdfs:label : feature_OwnedReferenceSubsetting^^xsd:string</para>
    ///   <para>rdfs:comment : The one ownedSubsetting of this Feature, if any, that is a ReferenceSubsetting, for which the Feature is the referencingFeature.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#feature_OwnedReferenceSubsetting">oslc_sysmlv2:feature_OwnedReferenceSubsetting</a>
    /// </summary>
    let feature_OwnedReferenceSubsetting = _prefixId.prefix "feature_OwnedReferenceSubsetting"

    /// <summary>
    ///   <para>rdfs:label : feature_OwnedSubsetting^^xsd:string</para>
    ///   <para>rdfs:comment : The ownedSpecializations of this Feature that are Subsettings, for which the Feature is the subsettingFeature.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#feature_OwnedSubsetting">oslc_sysmlv2:feature_OwnedSubsetting</a>
    /// </summary>
    let feature_OwnedSubsetting = _prefixId.prefix "feature_OwnedSubsetting"
    /// <summary>
    ///   <para>rdfs:label : feature_OwnedTypeFeaturing^^xsd:string</para>
    ///   <para>rdfs:comment : The ownedRelationships of this Feature that are TypeFeaturings and for which the Feature is the featureOfType.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#feature_OwnedTypeFeaturing">oslc_sysmlv2:feature_OwnedTypeFeaturing</a>
    /// </summary>
    let feature_OwnedTypeFeaturing = _prefixId.prefix "feature_OwnedTypeFeaturing"
    /// <summary>
    ///   <para>rdfs:label : feature_OwnedTyping^^xsd:string</para>
    ///   <para>rdfs:comment : The ownedSpecializations of this Feature that are FeatureTypings, for which the Feature is the typedFeature.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#feature_OwnedTyping">oslc_sysmlv2:feature_OwnedTyping</a>
    /// </summary>
    let feature_OwnedTyping = _prefixId.prefix "feature_OwnedTyping"

    /// <summary>
    ///   <para>rdfs:label : feature_OwningFeatureMembership^^xsd:string</para>
    ///   <para>rdfs:comment : The FeatureMembership that owns this Feature as an ownedMemberFeature, determining its owningType.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#feature_OwningFeatureMembership">oslc_sysmlv2:feature_OwningFeatureMembership</a>
    /// </summary>
    let feature_OwningFeatureMembership = _prefixId.prefix "feature_OwningFeatureMembership"

    /// <summary>
    ///   <para>rdfs:label : feature_OwningType^^xsd:string</para>
    ///   <para>rdfs:comment : The Type that is the owningType of the owningFeatureMembership of this Feature.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#feature_OwningType">oslc_sysmlv2:feature_OwningType</a>
    /// </summary>
    let feature_OwningType = _prefixId.prefix "feature_OwningType"
    /// <summary>
    ///   <para>rdfs:label : feature_Type^^xsd:string</para>
    ///   <para>rdfs:comment : Types that restrict the values of this Feature, such that the values must be instances of all the types. The types of a Feature are derived from its typings and the types of its subsettings. If the Feature is chained, then the types of the last Feature in the chain are also types of the chained Feature.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#feature_Type">oslc_sysmlv2:feature_Type</a>
    /// </summary>
    let feature_Type = _prefixId.prefix "feature_Type"
    /// <summary>
    ///   <para>rdfs:label : featuring_Feature^^xsd:string</para>
    ///   <para>rdfs:comment : The Feature that is featured by the featuringType.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#featuring_Feature">oslc_sysmlv2:featuring_Feature</a>
    /// </summary>
    let featuring_Feature = _prefixId.prefix "featuring_Feature"
    /// <summary>
    ///   <para>rdfs:label : featuring_Type^^xsd:string</para>
    ///   <para>rdfs:comment : The Type that features the featureOfType.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#featuring_Type">oslc_sysmlv2:featuring_Type</a>
    /// </summary>
    let featuring_Type = _prefixId.prefix "featuring_Type"

    /// <summary>
    ///   <para>rdfs:label : flowConnectionUsage_FlowConnectionDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : The Interactions that are the types of this FlowConnectionUsage. Nominally, these are FlowConnectionDefinitions, but other kinds of Kernel Interactions are also allowed, to permit use of Interactions from the Kernel Model Libraries.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#flowConnectionUsage_FlowConnectionDefinition">oslc_sysmlv2:flowConnectionUsage_FlowConnectionDefinition</a>
    /// </summary>
    let flowConnectionUsage_FlowConnectionDefinition = _prefixId.prefix "flowConnectionUsage_FlowConnectionDefinition"

    /// <summary>
    ///   <para>rdfs:label : forLoopActionUsage_LoopVariable^^xsd:string</para>
    ///   <para>rdfs:comment : The ownedFeature of this ForLoopActionUsage that acts as the loop variable, which is assigned the successive values of the input sequence on each iteration. It is the ownedFeature that redefines ForLoopAction::var.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#forLoopActionUsage_LoopVariable">oslc_sysmlv2:forLoopActionUsage_LoopVariable</a>
    /// </summary>
    let forLoopActionUsage_LoopVariable = _prefixId.prefix "forLoopActionUsage_LoopVariable"

    /// <summary>
    ///   <para>rdfs:label : forLoopActionUsage_SeqArgument^^xsd:string</para>
    ///   <para>rdfs:comment : The Expression whose result provides the sequence of values to which the loopVariable is set for each iterative performance of the bodyAction. It is the Expression whose result is bound to the seq input parameter of this ForLoopActionUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#forLoopActionUsage_SeqArgument">oslc_sysmlv2:forLoopActionUsage_SeqArgument</a>
    /// </summary>
    let forLoopActionUsage_SeqArgument = _prefixId.prefix "forLoopActionUsage_SeqArgument"

    /// <summary>
    ///   <para>rdfs:label : framedConcernMembership_OwnedConcern^^xsd:string</para>
    ///   <para>rdfs:comment : The ConcernUsage that is the ownedConstraint of this FramedConcernMembership.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#framedConcernMembership_OwnedConcern">oslc_sysmlv2:framedConcernMembership_OwnedConcern</a>
    /// </summary>
    let framedConcernMembership_OwnedConcern = _prefixId.prefix "framedConcernMembership_OwnedConcern"

    /// <summary>
    ///   <para>rdfs:label : framedConcernMembership_ReferencedConcern^^xsd:string</para>
    ///   <para>rdfs:comment :  The ConcernUsage that is referenced through this FramedConcernMembership. It is the referencedConstraint of the FramedConcernMembership considered as a RequirementConstraintMembership, which must be a ConcernUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#framedConcernMembership_ReferencedConcern">oslc_sysmlv2:framedConcernMembership_ReferencedConcern</a>
    /// </summary>
    let framedConcernMembership_ReferencedConcern = _prefixId.prefix "framedConcernMembership_ReferencedConcern"

    /// <summary>
    ///   <para>rdfs:label : function_Expression^^xsd:string</para>
    ///   <para>rdfs:comment : The Expressions that are steps in the calculation of the result of this Function.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#function_Expression">oslc_sysmlv2:function_Expression</a>
    /// </summary>
    let function_Expression = _prefixId.prefix "function_Expression"

    /// <summary>
    ///   <para>rdfs:label : function_IsModelLevelEvaluable^^xsd:string</para>
    ///   <para>rdfs:comment : Whether this Function can be used as the function of a model-level evaluable InvocationExpression. Certain Functions from the Kernel Functions Library are considered to have isModelLevelEvaluable = true. For all other Functions it is false.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#function_IsModelLevelEvaluable">oslc_sysmlv2:function_IsModelLevelEvaluable</a>
    /// </summary>
    let function_IsModelLevelEvaluable = _prefixId.prefix "function_IsModelLevelEvaluable"

    /// <summary>
    ///   <para>rdfs:label : function_Result^^xsd:string</para>
    ///   <para>rdfs:comment : The result parameter of the Function, which is owned by the Function via a ReturnParameterMembership.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#function_Result">oslc_sysmlv2:function_Result</a>
    /// </summary>
    let function_Result = _prefixId.prefix "function_Result"
    /// <summary>
    ///   <para>rdfs:label : ifActionUsage_ElseAction^^xsd:string</para>
    ///   <para>rdfs:comment : The ActionUsage that is to be performed if the result of the ifArgument is false. It is the (optional) third parameter of the IfActionUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#ifActionUsage_ElseAction">oslc_sysmlv2:ifActionUsage_ElseAction</a>
    /// </summary>
    let ifActionUsage_ElseAction = _prefixId.prefix "ifActionUsage_ElseAction"
    /// <summary>
    ///   <para>rdfs:label : ifActionUsage_IfArgument^^xsd:string</para>
    ///   <para>rdfs:comment : The Expression whose result determines whether the thenAction or (optionally) the elseAction is performed. It is the first parameter of the IfActionUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#ifActionUsage_IfArgument">oslc_sysmlv2:ifActionUsage_IfArgument</a>
    /// </summary>
    let ifActionUsage_IfArgument = _prefixId.prefix "ifActionUsage_IfArgument"
    /// <summary>
    ///   <para>rdfs:label : ifActionUsage_ThenAction^^xsd:string</para>
    ///   <para>rdfs:comment : The ActionUsage that is to be performed if the result of the ifArgument is true. It is the second parameter of the IfActionUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#ifActionUsage_ThenAction">oslc_sysmlv2:ifActionUsage_ThenAction</a>
    /// </summary>
    let ifActionUsage_ThenAction = _prefixId.prefix "ifActionUsage_ThenAction"
    /// <summary>
    ///   <para>rdfs:label : import_ImportOwningNamespace^^xsd:string</para>
    ///   <para>rdfs:comment : The Namespace into which Memberships are imported by this Import, which must be the owningRelatedElement of the Import.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#import_ImportOwningNamespace">oslc_sysmlv2:import_ImportOwningNamespace</a>
    /// </summary>
    let import_ImportOwningNamespace = _prefixId.prefix "import_ImportOwningNamespace"
    /// <summary>
    ///   <para>rdfs:label : import_ImportedElement^^xsd:string</para>
    ///   <para>rdfs:comment : The effectively imported Element for this Import. For a MembershipImport, this is the memberElement of the importedMembership. For a NamespaceImport, it is the importedNamespace.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#import_ImportedElement">oslc_sysmlv2:import_ImportedElement</a>
    /// </summary>
    let import_ImportedElement = _prefixId.prefix "import_ImportedElement"
    /// <summary>
    ///   <para>rdfs:label : import_IsImportAll^^xsd:string</para>
    ///   <para>rdfs:comment : Whether to import memberships without regard to declared visibility.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#import_IsImportAll">oslc_sysmlv2:import_IsImportAll</a>
    /// </summary>
    let import_IsImportAll = _prefixId.prefix "import_IsImportAll"
    /// <summary>
    ///   <para>rdfs:label : import_IsRecursive^^xsd:string</para>
    ///   <para>rdfs:comment : Whether to recursively import Memberships from visible, owned sub-Namespaces.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#import_IsRecursive">oslc_sysmlv2:import_IsRecursive</a>
    /// </summary>
    let import_IsRecursive = _prefixId.prefix "import_IsRecursive"
    /// <summary>
    ///   <para>rdfs:label : import_Visibility^^xsd:string</para>
    ///   <para>rdfs:comment : The visibility level of the imported members from this Import relative to the importOwningNamespace.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#import_Visibility">oslc_sysmlv2:import_Visibility</a>
    /// </summary>
    let import_Visibility = _prefixId.prefix "import_Visibility"

    /// <summary>
    ///   <para>rdfs:label : includeUseCaseUsage_UseCaseIncluded^^xsd:string</para>
    ///   <para>rdfs:comment : The UseCaseUsage to be included by this IncludeUseCaseUsage. It is the performedAction of the IncludeUseCaseUsage considered as a PerformActionUsage, which must be a UseCaseUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#includeUseCaseUsage_UseCaseIncluded">oslc_sysmlv2:includeUseCaseUsage_UseCaseIncluded</a>
    /// </summary>
    let includeUseCaseUsage_UseCaseIncluded = _prefixId.prefix "includeUseCaseUsage_UseCaseIncluded"

    /// <summary>
    ///   <para>rdfs:label : interfaceDefinition_InterfaceEnd^^xsd:string</para>
    ///   <para>rdfs:comment : The PortUsages that are the connectionEnds of this InterfaceDefinition.
    ///
    /// .^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#interfaceDefinition_InterfaceEnd">oslc_sysmlv2:interfaceDefinition_InterfaceEnd</a>
    /// </summary>
    let interfaceDefinition_InterfaceEnd = _prefixId.prefix "interfaceDefinition_InterfaceEnd"

    /// <summary>
    ///   <para>rdfs:label : interfaceUsage_InterfaceDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : The InterfaceDefinitions that type this InterfaceUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#interfaceUsage_InterfaceDefinition">oslc_sysmlv2:interfaceUsage_InterfaceDefinition</a>
    /// </summary>
    let interfaceUsage_InterfaceDefinition = _prefixId.prefix "interfaceUsage_InterfaceDefinition"

    /// <summary>
    ///   <para>rdfs:label : intersecting_IntersectingType^^xsd:string</para>
    ///   <para>rdfs:comment : Type that partly determines interpretations of typeIntersected, as described in Type::intersectingType.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#intersecting_IntersectingType">oslc_sysmlv2:intersecting_IntersectingType</a>
    /// </summary>
    let intersecting_IntersectingType = _prefixId.prefix "intersecting_IntersectingType"
    /// <summary>
    ///   <para>rdfs:label : intersecting_TypeIntersected^^xsd:string</para>
    ///   <para>rdfs:comment : Type with interpretations partly determined by intersectingType, as described in Type::intersectingType.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#intersecting_TypeIntersected">oslc_sysmlv2:intersecting_TypeIntersected</a>
    /// </summary>
    let intersecting_TypeIntersected = _prefixId.prefix "intersecting_TypeIntersected"
    /// <summary>
    ///   <para>rdfs:label : invariant_IsNegated^^xsd:string</para>
    ///   <para>rdfs:comment : Whether this Invariant is asserted to be false rather than true.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#invariant_IsNegated">oslc_sysmlv2:invariant_IsNegated</a>
    /// </summary>
    let invariant_IsNegated = _prefixId.prefix "invariant_IsNegated"
    /// <summary>
    ///   <para>rdfs:label : invocationExpression_Argument^^xsd:string</para>
    ///   <para>rdfs:comment : The value Expressions of the FeatureValues of the owned input parameters of the InvocationExpression.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#invocationExpression_Argument">oslc_sysmlv2:invocationExpression_Argument</a>
    /// </summary>
    let invocationExpression_Argument = _prefixId.prefix "invocationExpression_Argument"
    /// <summary>
    ///   <para>rdfs:label : invocationExpression_Operand^^xsd:string</para>
    ///   <para>rdfs:comment : operand.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#invocationExpression_Operand">oslc_sysmlv2:invocationExpression_Operand</a>
    /// </summary>
    let invocationExpression_Operand = _prefixId.prefix "invocationExpression_Operand"
    /// <summary>
    ///   <para>rdfs:label : itemFlow_Interaction^^xsd:string</para>
    ///   <para>rdfs:comment : The Interactions that type this ItemFlow. Interactions are both Associations and Behaviors, which can type Connectors and Steps, respectively.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#itemFlow_Interaction">oslc_sysmlv2:itemFlow_Interaction</a>
    /// </summary>
    let itemFlow_Interaction = _prefixId.prefix "itemFlow_Interaction"
    /// <summary>
    ///   <para>rdfs:label : itemFlow_ItemFeature^^xsd:string</para>
    ///   <para>rdfs:comment : The ownedFeature of the ItemFlow that is an ItemFeature (if any).^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#itemFlow_ItemFeature">oslc_sysmlv2:itemFlow_ItemFeature</a>
    /// </summary>
    let itemFlow_ItemFeature = _prefixId.prefix "itemFlow_ItemFeature"
    /// <summary>
    ///   <para>rdfs:label : itemFlow_ItemFlowEnd^^xsd:string</para>
    ///   <para>rdfs:comment : The connectorEnds of this ItemFlow that are ItemFlowEnds.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#itemFlow_ItemFlowEnd">oslc_sysmlv2:itemFlow_ItemFlowEnd</a>
    /// </summary>
    let itemFlow_ItemFlowEnd = _prefixId.prefix "itemFlow_ItemFlowEnd"
    /// <summary>
    ///   <para>rdfs:label : itemFlow_ItemType^^xsd:string</para>
    ///   <para>rdfs:comment : The type of values transferred, which is the type of the itemFeature of the ItemFlow.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#itemFlow_ItemType">oslc_sysmlv2:itemFlow_ItemType</a>
    /// </summary>
    let itemFlow_ItemType = _prefixId.prefix "itemFlow_ItemType"
    /// <summary>
    ///   <para>rdfs:label : itemFlow_SourceOutputFeature^^xsd:string</para>
    ///   <para>rdfs:comment : The Feature that provides the items carried by the ItemFlow. It must be an owned output of the source of the ItemFlow.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#itemFlow_SourceOutputFeature">oslc_sysmlv2:itemFlow_SourceOutputFeature</a>
    /// </summary>
    let itemFlow_SourceOutputFeature = _prefixId.prefix "itemFlow_SourceOutputFeature"
    /// <summary>
    ///   <para>rdfs:label : itemFlow_TargetInputFeature^^xsd:string</para>
    ///   <para>rdfs:comment : The Feature that receives the values carried by the ItemFlow. It must be an owned output of the target participant of the ItemFlow.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#itemFlow_TargetInputFeature">oslc_sysmlv2:itemFlow_TargetInputFeature</a>
    /// </summary>
    let itemFlow_TargetInputFeature = _prefixId.prefix "itemFlow_TargetInputFeature"
    /// <summary>
    ///   <para>rdfs:label : itemUsage_ItemDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : The Structures that are the definitions of this ItemUsage. Nominally, these are ItemDefinitions, but other kinds of Kernel Structures are also allowed, to permit use of Structures from the Kernel Library.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#itemUsage_ItemDefinition">oslc_sysmlv2:itemUsage_ItemDefinition</a>
    /// </summary>
    let itemUsage_ItemDefinition = _prefixId.prefix "itemUsage_ItemDefinition"
    /// <summary>
    ///   <para>rdfs:label : libraryPackage_IsStandard^^xsd:string</para>
    ///   <para>rdfs:comment : Whether this LibraryPackage contains a standard library model. This should only be set to true for LibraryPackages in the standard Kernel Model Libraries or in normative model libraries for a language built on KerML.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#libraryPackage_IsStandard">oslc_sysmlv2:libraryPackage_IsStandard</a>
    /// </summary>
    let libraryPackage_IsStandard = _prefixId.prefix "libraryPackage_IsStandard"
    /// <summary>
    ///   <para>rdfs:label : literalBoolean_Value^^xsd:string</para>
    ///   <para>rdfs:comment : The Boolean value that is the result of evaluating this LiteralBoolean.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#literalBoolean_Value">oslc_sysmlv2:literalBoolean_Value</a>
    /// </summary>
    let literalBoolean_Value = _prefixId.prefix "literalBoolean_Value"
    /// <summary>
    ///   <para>rdfs:label : literalInteger_Value^^xsd:string</para>
    ///   <para>rdfs:comment : The Integer value that is the result of evaluating this LiteralInteger.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#literalInteger_Value">oslc_sysmlv2:literalInteger_Value</a>
    /// </summary>
    let literalInteger_Value = _prefixId.prefix "literalInteger_Value"
    /// <summary>
    ///   <para>rdfs:label : literalRational_Value^^xsd:string</para>
    ///   <para>rdfs:comment : The value whose rational approximation is the result of evaluating this LiteralRational.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#literalRational_Value">oslc_sysmlv2:literalRational_Value</a>
    /// </summary>
    let literalRational_Value = _prefixId.prefix "literalRational_Value"
    /// <summary>
    ///   <para>rdfs:label : literalString_Value^^xsd:string</para>
    ///   <para>rdfs:comment : The String value that is the result of evaluating this LiteralString.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#literalString_Value">oslc_sysmlv2:literalString_Value</a>
    /// </summary>
    let literalString_Value = _prefixId.prefix "literalString_Value"
    /// <summary>
    ///   <para>rdfs:label : loopActionUsage_BodyAction^^xsd:string</para>
    ///   <para>rdfs:comment : The ActionUsage to be performed repeatedly by the LoopActionUsage. It is the second parameter of the LoopActionUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#loopActionUsage_BodyAction">oslc_sysmlv2:loopActionUsage_BodyAction</a>
    /// </summary>
    let loopActionUsage_BodyAction = _prefixId.prefix "loopActionUsage_BodyAction"

    /// <summary>
    ///   <para>rdfs:label : membershipImport_ImportedMembership^^xsd:string</para>
    ///   <para>rdfs:comment : The Membership to be imported.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#membershipImport_ImportedMembership">oslc_sysmlv2:membershipImport_ImportedMembership</a>
    /// </summary>
    let membershipImport_ImportedMembership = _prefixId.prefix "membershipImport_ImportedMembership"

    /// <summary>
    ///   <para>rdfs:label : membership_MemberElement^^xsd:string</para>
    ///   <para>rdfs:comment : The Element that becomes a member of the membershipOwningNamespace due to this Membership.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#membership_MemberElement">oslc_sysmlv2:membership_MemberElement</a>
    /// </summary>
    let membership_MemberElement = _prefixId.prefix "membership_MemberElement"
    /// <summary>
    ///   <para>rdfs:label : membership_MemberElementId^^xsd:string</para>
    ///   <para>rdfs:comment : The elementId of the memberElement.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#membership_MemberElementId">oslc_sysmlv2:membership_MemberElementId</a>
    /// </summary>
    let membership_MemberElementId = _prefixId.prefix "membership_MemberElementId"
    /// <summary>
    ///   <para>rdfs:label : membership_MemberName^^xsd:string</para>
    ///   <para>rdfs:comment : The name of the memberElement relative to the membershipOwningNamespace.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#membership_MemberName">oslc_sysmlv2:membership_MemberName</a>
    /// </summary>
    let membership_MemberName = _prefixId.prefix "membership_MemberName"
    /// <summary>
    ///   <para>rdfs:label : membership_MemberShortName^^xsd:string</para>
    ///   <para>rdfs:comment : The short name of the memberElement relative to the membershipOwningNamespace.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#membership_MemberShortName">oslc_sysmlv2:membership_MemberShortName</a>
    /// </summary>
    let membership_MemberShortName = _prefixId.prefix "membership_MemberShortName"

    /// <summary>
    ///   <para>rdfs:label : membership_MembershipOwningNamespace^^xsd:string</para>
    ///   <para>rdfs:comment : The Namespace of which the memberElement becomes a member due to this Membership.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#membership_MembershipOwningNamespace">oslc_sysmlv2:membership_MembershipOwningNamespace</a>
    /// </summary>
    let membership_MembershipOwningNamespace = _prefixId.prefix "membership_MembershipOwningNamespace"

    /// <summary>
    ///   <para>rdfs:label : membership_Visibility^^xsd:string</para>
    ///   <para>rdfs:comment : Whether or not the Membership of the memberElement in the membershipOwningNamespace is publicly visible outside that Namespace.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#membership_Visibility">oslc_sysmlv2:membership_Visibility</a>
    /// </summary>
    let membership_Visibility = _prefixId.prefix "membership_Visibility"

    /// <summary>
    ///   <para>rdfs:label : metadataAccessExpression_ReferencedElement^^xsd:string</para>
    ///   <para>rdfs:comment :  The Element whose metadata is being accessed.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#metadataAccessExpression_ReferencedElement">oslc_sysmlv2:metadataAccessExpression_ReferencedElement</a>
    /// </summary>
    let metadataAccessExpression_ReferencedElement = _prefixId.prefix "metadataAccessExpression_ReferencedElement"

    /// <summary>
    ///   <para>rdfs:label : metadataFeature_Metaclass^^xsd:string</para>
    ///   <para>rdfs:comment : The type of this MetadataFeature, which must be a Metaclass.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#metadataFeature_Metaclass">oslc_sysmlv2:metadataFeature_Metaclass</a>
    /// </summary>
    let metadataFeature_Metaclass = _prefixId.prefix "metadataFeature_Metaclass"

    /// <summary>
    ///   <para>rdfs:label : metadataUsage_MetadataDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : The MetadataDefinition that is the definition of this MetadataUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#metadataUsage_MetadataDefinition">oslc_sysmlv2:metadataUsage_MetadataDefinition</a>
    /// </summary>
    let metadataUsage_MetadataDefinition = _prefixId.prefix "metadataUsage_MetadataDefinition"

    /// <summary>
    ///   <para>rdfs:label : multiplicityRange_Bound^^xsd:string</para>
    ///   <para>rdfs:comment : The owned Expressions of the MultiplicityRange whose results provide its bounds. These must be the only ownedMembers of the MultiplicityRange.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#multiplicityRange_Bound">oslc_sysmlv2:multiplicityRange_Bound</a>
    /// </summary>
    let multiplicityRange_Bound = _prefixId.prefix "multiplicityRange_Bound"
    /// <summary>
    ///   <para>rdfs:label : multiplicityRange_LowerBound^^xsd:string</para>
    ///   <para>rdfs:comment : The Expression whose result provides the lower bound of the MultiplicityRange. If no lowerBound Expression is given, then the lower bound shall have the same value as the upper bound, unless the upper bound is unbounded (*), in which case the lower bound shall be 0.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#multiplicityRange_LowerBound">oslc_sysmlv2:multiplicityRange_LowerBound</a>
    /// </summary>
    let multiplicityRange_LowerBound = _prefixId.prefix "multiplicityRange_LowerBound"
    /// <summary>
    ///   <para>rdfs:label : multiplicityRange_UpperBound^^xsd:string</para>
    ///   <para>rdfs:comment : The Expression whose result is the upper bound of the MultiplicityRange.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#multiplicityRange_UpperBound">oslc_sysmlv2:multiplicityRange_UpperBound</a>
    /// </summary>
    let multiplicityRange_UpperBound = _prefixId.prefix "multiplicityRange_UpperBound"

    /// <summary>
    ///   <para>rdfs:label : namespaceImport_ImportedNamespace^^xsd:string</para>
    ///   <para>rdfs:comment : The Namespace whose visible Memberships are imported by this NamespaceImport.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#namespaceImport_ImportedNamespace">oslc_sysmlv2:namespaceImport_ImportedNamespace</a>
    /// </summary>
    let namespaceImport_ImportedNamespace = _prefixId.prefix "namespaceImport_ImportedNamespace"

    /// <summary>
    ///   <para>rdfs:label : namespace_ImportedMembership^^xsd:string</para>
    ///   <para>rdfs:comment : The Memberships in this Namespace that result from the ownedImports of this Namespace.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#namespace_ImportedMembership">oslc_sysmlv2:namespace_ImportedMembership</a>
    /// </summary>
    let namespace_ImportedMembership = _prefixId.prefix "namespace_ImportedMembership"
    /// <summary>
    ///   <para>rdfs:label : namespace_Member^^xsd:string</para>
    ///   <para>rdfs:comment : The set of all member Elements of this Namespace, which are the memberElements of all memberships of the Namespace.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#namespace_Member">oslc_sysmlv2:namespace_Member</a>
    /// </summary>
    let namespace_Member = _prefixId.prefix "namespace_Member"
    /// <summary>
    ///   <para>rdfs:label : namespace_Membership^^xsd:string</para>
    ///   <para>rdfs:comment : All Memberships in this Namespace, including (at least) the union of ownedMemberships and importedMemberships.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#namespace_Membership">oslc_sysmlv2:namespace_Membership</a>
    /// </summary>
    let namespace_Membership = _prefixId.prefix "namespace_Membership"
    /// <summary>
    ///   <para>rdfs:label : namespace_OwnedImport^^xsd:string</para>
    ///   <para>rdfs:comment : The ownedRelationships of this Namespace that are Imports, for which the Namespace is the importOwningNamespace.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#namespace_OwnedImport">oslc_sysmlv2:namespace_OwnedImport</a>
    /// </summary>
    let namespace_OwnedImport = _prefixId.prefix "namespace_OwnedImport"
    /// <summary>
    ///   <para>rdfs:label : namespace_OwnedMember^^xsd:string</para>
    ///   <para>rdfs:comment : The owned members of this Namespace, which are the ownedMemberElements of the ownedMemberships of the .^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#namespace_OwnedMember">oslc_sysmlv2:namespace_OwnedMember</a>
    /// </summary>
    let namespace_OwnedMember = _prefixId.prefix "namespace_OwnedMember"
    /// <summary>
    ///   <para>rdfs:label : namespace_OwnedMembership^^xsd:string</para>
    ///   <para>rdfs:comment : The ownedRelationships of this Namespace that are Memberships, for which the Namespace is the membershipOwningNamespace.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#namespace_OwnedMembership">oslc_sysmlv2:namespace_OwnedMembership</a>
    /// </summary>
    let namespace_OwnedMembership = _prefixId.prefix "namespace_OwnedMembership"

    /// <summary>
    ///   <para>rdfs:label : objectiveMembership_OwnedObjectiveRequirement^^xsd:string</para>
    ///   <para>rdfs:comment : The RequirementUsage that is the ownedMemberFeature of this RequirementUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#objectiveMembership_OwnedObjectiveRequirement">oslc_sysmlv2:objectiveMembership_OwnedObjectiveRequirement</a>
    /// </summary>
    let objectiveMembership_OwnedObjectiveRequirement = _prefixId.prefix "objectiveMembership_OwnedObjectiveRequirement"

    /// <summary>
    ///   <para>rdfs:label : occurrenceDefinition_IsIndividual^^xsd:string</para>
    ///   <para>rdfs:comment : Whether this OccurrenceDefinition is constrained to represent single individual.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#occurrenceDefinition_IsIndividual">oslc_sysmlv2:occurrenceDefinition_IsIndividual</a>
    /// </summary>
    let occurrenceDefinition_IsIndividual = _prefixId.prefix "occurrenceDefinition_IsIndividual"

    /// <summary>
    ///   <para>rdfs:label : occurrenceDefinition_LifeClass^^xsd:string</para>
    ///   <para>rdfs:comment : If isIndividual is true, a LifeClass that specializes this OccurrenceDefinition, restricting it to represent an individual.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#occurrenceDefinition_LifeClass">oslc_sysmlv2:occurrenceDefinition_LifeClass</a>
    /// </summary>
    let occurrenceDefinition_LifeClass = _prefixId.prefix "occurrenceDefinition_LifeClass"

    /// <summary>
    ///   <para>rdfs:label : occurrenceUsage_IndividualDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : The at most one occurrenceDefinition that has isIndividual = true.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#occurrenceUsage_IndividualDefinition">oslc_sysmlv2:occurrenceUsage_IndividualDefinition</a>
    /// </summary>
    let occurrenceUsage_IndividualDefinition = _prefixId.prefix "occurrenceUsage_IndividualDefinition"

    /// <summary>
    ///   <para>rdfs:label : occurrenceUsage_IsIndividual^^xsd:string</para>
    ///   <para>rdfs:comment : Whether this OccurrenceUsage represents the usage of the specific individual (or portion of it) represented by its individualDefinition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#occurrenceUsage_IsIndividual">oslc_sysmlv2:occurrenceUsage_IsIndividual</a>
    /// </summary>
    let occurrenceUsage_IsIndividual = _prefixId.prefix "occurrenceUsage_IsIndividual"

    /// <summary>
    ///   <para>rdfs:label : occurrenceUsage_OccurrenceDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : The Classes that are the types of this OccurrenceUsage. Nominally, these are OccurrenceDefinitions, but other kinds of kernel Classes are also allowed, to permit use of Classes from the Kernel Model Libraries.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#occurrenceUsage_OccurrenceDefinition">oslc_sysmlv2:occurrenceUsage_OccurrenceDefinition</a>
    /// </summary>
    let occurrenceUsage_OccurrenceDefinition = _prefixId.prefix "occurrenceUsage_OccurrenceDefinition"

    /// <summary>
    ///   <para>rdfs:label : occurrenceUsage_PortionKind^^xsd:string</para>
    ///   <para>rdfs:comment : The kind of (temporal) portion of the life of the occurrenceDefinition represented by this OccurrenceUsage, if it is so restricted.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#occurrenceUsage_PortionKind">oslc_sysmlv2:occurrenceUsage_PortionKind</a>
    /// </summary>
    let occurrenceUsage_PortionKind = _prefixId.prefix "occurrenceUsage_PortionKind"
    /// <summary>
    ///   <para>rdfs:label : operatorExpression_Operator^^xsd:string</para>
    ///   <para>rdfs:comment : An operator symbol that names a corresponding Function from one of the standard packages from the Kernel Function Library .^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#operatorExpression_Operator">oslc_sysmlv2:operatorExpression_Operator</a>
    /// </summary>
    let operatorExpression_Operator = _prefixId.prefix "operatorExpression_Operator"

    /// <summary>
    ///   <para>rdfs:label : owningMembership_OwnedMemberElement^^xsd:string</para>
    ///   <para>rdfs:comment : The Element that becomes an ownedMember of the membershipOwningNamespace due to this OwningMembership.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#owningMembership_OwnedMemberElement">oslc_sysmlv2:owningMembership_OwnedMemberElement</a>
    /// </summary>
    let owningMembership_OwnedMemberElement = _prefixId.prefix "owningMembership_OwnedMemberElement"

    /// <summary>
    ///   <para>rdfs:label : owningMembership_OwnedMemberElementId^^xsd:string</para>
    ///   <para>rdfs:comment : The elementId of the ownedMemberElement.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#owningMembership_OwnedMemberElementId">oslc_sysmlv2:owningMembership_OwnedMemberElementId</a>
    /// </summary>
    let owningMembership_OwnedMemberElementId = _prefixId.prefix "owningMembership_OwnedMemberElementId"

    /// <summary>
    ///   <para>rdfs:label : owningMembership_OwnedMemberName^^xsd:string</para>
    ///   <para>rdfs:comment : The name of the ownedMemberElement.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#owningMembership_OwnedMemberName">oslc_sysmlv2:owningMembership_OwnedMemberName</a>
    /// </summary>
    let owningMembership_OwnedMemberName = _prefixId.prefix "owningMembership_OwnedMemberName"

    /// <summary>
    ///   <para>rdfs:label : owningMembership_OwnedMemberShortName^^xsd:string</para>
    ///   <para>rdfs:comment : The shortName of the ownedMemberElement.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#owningMembership_OwnedMemberShortName">oslc_sysmlv2:owningMembership_OwnedMemberShortName</a>
    /// </summary>
    let owningMembership_OwnedMemberShortName = _prefixId.prefix "owningMembership_OwnedMemberShortName"

    /// <summary>
    ///   <para>rdfs:label : package_FilterCondition^^xsd:string</para>
    ///   <para>rdfs:comment : The model-level evaluable Boolean-valued Expression used to filter the members of this Package, which are owned by the Package are via ElementFilterMemberships.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#package_FilterCondition">oslc_sysmlv2:package_FilterCondition</a>
    /// </summary>
    let package_FilterCondition = _prefixId.prefix "package_FilterCondition"

    /// <summary>
    ///   <para>rdfs:label : parameterMembership_OwnedMemberParameter^^xsd:string</para>
    ///   <para>rdfs:comment : The Feature that is identified as a parameter by this ParameterMembership.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#parameterMembership_OwnedMemberParameter">oslc_sysmlv2:parameterMembership_OwnedMemberParameter</a>
    /// </summary>
    let parameterMembership_OwnedMemberParameter = _prefixId.prefix "parameterMembership_OwnedMemberParameter"

    /// <summary>
    ///   <para>rdfs:label : partUsage_PartDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : The itemDefinitions of this PartUsage that are PartDefinitions.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#partUsage_PartDefinition">oslc_sysmlv2:partUsage_PartDefinition</a>
    /// </summary>
    let partUsage_PartDefinition = _prefixId.prefix "partUsage_PartDefinition"

    /// <summary>
    ///   <para>rdfs:label : performActionUsage_PerformedAction^^xsd:string</para>
    ///   <para>rdfs:comment : The ActionUsage to be performed by this PerformedActionUsage. It is the eventOccurrence of the PerformActionUsage considered as an EventOccurrenceUsage, which must be an ActionUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#performActionUsage_PerformedAction">oslc_sysmlv2:performActionUsage_PerformedAction</a>
    /// </summary>
    let performActionUsage_PerformedAction = _prefixId.prefix "performActionUsage_PerformedAction"

    /// <summary>
    ///   <para>rdfs:label : portConjugation_ConjugatedPortDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : The ConjugatedPortDefinition that is conjugate to the originalPortDefinition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#portConjugation_ConjugatedPortDefinition">oslc_sysmlv2:portConjugation_ConjugatedPortDefinition</a>
    /// </summary>
    let portConjugation_ConjugatedPortDefinition = _prefixId.prefix "portConjugation_ConjugatedPortDefinition"

    /// <summary>
    ///   <para>rdfs:label : portConjugation_OriginalPortDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : The PortDefinition being conjugated.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#portConjugation_OriginalPortDefinition">oslc_sysmlv2:portConjugation_OriginalPortDefinition</a>
    /// </summary>
    let portConjugation_OriginalPortDefinition = _prefixId.prefix "portConjugation_OriginalPortDefinition"

    /// <summary>
    ///   <para>rdfs:label : portDefinition_ConjugatedPortDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : The  that is conjugate to this PortDefinition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#portDefinition_ConjugatedPortDefinition">oslc_sysmlv2:portDefinition_ConjugatedPortDefinition</a>
    /// </summary>
    let portDefinition_ConjugatedPortDefinition = _prefixId.prefix "portDefinition_ConjugatedPortDefinition"

    /// <summary>
    ///   <para>rdfs:label : portUsage_PortDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : The occurrenceDefinitions of this PortUsage, which must all be PortDefinitions.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#portUsage_PortDefinition">oslc_sysmlv2:portUsage_PortDefinition</a>
    /// </summary>
    let portUsage_PortDefinition = _prefixId.prefix "portUsage_PortDefinition"
    let portionKind_Snapshot = _prefixId.prefix "portionKind_Snapshot"
    let portionKind_Timeslice = _prefixId.prefix "portionKind_Timeslice"
    /// <summary>
    ///   <para>rdfs:label : redefinition_RedefinedFeature^^xsd:string</para>
    ///   <para>rdfs:comment : The Feature that is redefined by the redefiningFeature of this Redefinition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#redefinition_RedefinedFeature">oslc_sysmlv2:redefinition_RedefinedFeature</a>
    /// </summary>
    let redefinition_RedefinedFeature = _prefixId.prefix "redefinition_RedefinedFeature"

    /// <summary>
    ///   <para>rdfs:label : redefinition_RedefiningFeature^^xsd:string</para>
    ///   <para>rdfs:comment : The Feature that is redefining the redefinedFeature of this Redefinition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#redefinition_RedefiningFeature">oslc_sysmlv2:redefinition_RedefiningFeature</a>
    /// </summary>
    let redefinition_RedefiningFeature = _prefixId.prefix "redefinition_RedefiningFeature"

    /// <summary>
    ///   <para>rdfs:label : referenceSubsetting_ReferencedFeature^^xsd:string</para>
    ///   <para>rdfs:comment : The Feature that is referenced by the referencingFeature of this ReferenceSubsetting.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#referenceSubsetting_ReferencedFeature">oslc_sysmlv2:referenceSubsetting_ReferencedFeature</a>
    /// </summary>
    let referenceSubsetting_ReferencedFeature = _prefixId.prefix "referenceSubsetting_ReferencedFeature"

    /// <summary>
    ///   <para>rdfs:label : referenceSubsetting_ReferencingFeature^^xsd:string</para>
    ///   <para>rdfs:comment : The Feature that owns this ReferenceSubsetting relationship, which is also its subsettingFeature.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#referenceSubsetting_ReferencingFeature">oslc_sysmlv2:referenceSubsetting_ReferencingFeature</a>
    /// </summary>
    let referenceSubsetting_ReferencingFeature = _prefixId.prefix "referenceSubsetting_ReferencingFeature"

    /// <summary>
    ///   <para>rdfs:label : relationship_IsImplied^^xsd:string</para>
    ///   <para>rdfs:comment : Whether this Relationship was generated by tooling to meet semantic rules, rather than being directly created by a modeler.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#relationship_IsImplied">oslc_sysmlv2:relationship_IsImplied</a>
    /// </summary>
    let relationship_IsImplied = _prefixId.prefix "relationship_IsImplied"

    /// <summary>
    ///   <para>rdfs:label : relationship_OwnedRelatedElement^^xsd:string</para>
    ///   <para>rdfs:comment : The relatedElements of this Relationship that are owned by the Relationship.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#relationship_OwnedRelatedElement">oslc_sysmlv2:relationship_OwnedRelatedElement</a>
    /// </summary>
    let relationship_OwnedRelatedElement = _prefixId.prefix "relationship_OwnedRelatedElement"

    /// <summary>
    ///   <para>rdfs:label : relationship_OwningRelatedElement^^xsd:string</para>
    ///   <para>rdfs:comment : The relatedElement of this Relationship that owns the Relationship, if any.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#relationship_OwningRelatedElement">oslc_sysmlv2:relationship_OwningRelatedElement</a>
    /// </summary>
    let relationship_OwningRelatedElement = _prefixId.prefix "relationship_OwningRelatedElement"

    /// <summary>
    ///   <para>rdfs:label : relationship_RelatedElement^^xsd:string</para>
    ///   <para>rdfs:comment : The Elements that are related by this Relationship, derived as the union of the source and target Elements of the Relationship.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#relationship_RelatedElement">oslc_sysmlv2:relationship_RelatedElement</a>
    /// </summary>
    let relationship_RelatedElement = _prefixId.prefix "relationship_RelatedElement"
    /// <summary>
    ///   <para>rdfs:label : relationship_Source^^xsd:string</para>
    ///   <para>rdfs:comment : The relatedElements from which this Relationship is considered to be directed.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#relationship_Source">oslc_sysmlv2:relationship_Source</a>
    /// </summary>
    let relationship_Source = _prefixId.prefix "relationship_Source"
    /// <summary>
    ///   <para>rdfs:label : relationship_Target^^xsd:string</para>
    ///   <para>rdfs:comment : The relatedElements to which this Relationship is considered to be directed.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#relationship_Target">oslc_sysmlv2:relationship_Target</a>
    /// </summary>
    let relationship_Target = _prefixId.prefix "relationship_Target"
    /// <summary>
    ///   <para>rdfs:label : renderingDefinition_Rendering^^xsd:string</para>
    ///   <para>rdfs:comment : The usages of a RenderingDefinition that are RenderingUsages.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#renderingDefinition_Rendering">oslc_sysmlv2:renderingDefinition_Rendering</a>
    /// </summary>
    let renderingDefinition_Rendering = _prefixId.prefix "renderingDefinition_Rendering"

    /// <summary>
    ///   <para>rdfs:label : renderingUsage_RenderingDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : The RenderingDefinition that is the definition of this RenderingUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#renderingUsage_RenderingDefinition">oslc_sysmlv2:renderingUsage_RenderingDefinition</a>
    /// </summary>
    let renderingUsage_RenderingDefinition = _prefixId.prefix "renderingUsage_RenderingDefinition"

    let requirementConstraintKind_Assumption = _prefixId.prefix "requirementConstraintKind_Assumption"

    let requirementConstraintKind_Requirement = _prefixId.prefix "requirementConstraintKind_Requirement"

    /// <summary>
    ///   <para>rdfs:label : requirementConstraintMembership_Kind^^xsd:string</para>
    ///   <para>rdfs:comment : Whether the RequirementConstraintMembership is for an assumed or required ConstraintUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#requirementConstraintMembership_Kind">oslc_sysmlv2:requirementConstraintMembership_Kind</a>
    /// </summary>
    let requirementConstraintMembership_Kind = _prefixId.prefix "requirementConstraintMembership_Kind"

    /// <summary>
    ///   <para>rdfs:label : requirementConstraintMembership_OwnedConstraint^^xsd:string</para>
    ///   <para>rdfs:comment : The ConstraintUsage that is the ownedMemberFeature of this RequirementConstraintMembership.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#requirementConstraintMembership_OwnedConstraint">oslc_sysmlv2:requirementConstraintMembership_OwnedConstraint</a>
    /// </summary>
    let requirementConstraintMembership_OwnedConstraint = _prefixId.prefix "requirementConstraintMembership_OwnedConstraint"

    /// <summary>
    ///   <para>rdfs:label : requirementConstraintMembership_ReferencedConstraint^^xsd:string</para>
    ///   <para>rdfs:comment :  The ConstraintUsage that is referenced through this RequirementConstraintMembership. It is the referencedFeature of the ownedReferenceSubsetting of the ownedConstraint, if there is one, and, otherwise, the ownedConstraint itself.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#requirementConstraintMembership_ReferencedConstraint">oslc_sysmlv2:requirementConstraintMembership_ReferencedConstraint</a>
    /// </summary>
    let requirementConstraintMembership_ReferencedConstraint = _prefixId.prefix "requirementConstraintMembership_ReferencedConstraint"

    /// <summary>
    ///   <para>rdfs:label : requirementDefinition_ActorParameter^^xsd:string</para>
    ///   <para>rdfs:comment : The parameters of this RequirementDefinition that represent actors involved in the requirement.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#requirementDefinition_ActorParameter">oslc_sysmlv2:requirementDefinition_ActorParameter</a>
    /// </summary>
    let requirementDefinition_ActorParameter = _prefixId.prefix "requirementDefinition_ActorParameter"

    /// <summary>
    ///   <para>rdfs:label : requirementDefinition_AssumedConstraint^^xsd:string</para>
    ///   <para>rdfs:comment : The owned ConstraintUsages that represent assumptions of this RequirementDefinition, which are the ownedConstraints of the RequirementConstraintMemberships of the RequirementDefinition with kind = assumption.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#requirementDefinition_AssumedConstraint">oslc_sysmlv2:requirementDefinition_AssumedConstraint</a>
    /// </summary>
    let requirementDefinition_AssumedConstraint = _prefixId.prefix "requirementDefinition_AssumedConstraint"

    /// <summary>
    ///   <para>rdfs:label : requirementDefinition_FramedConcern^^xsd:string</para>
    ///   <para>rdfs:comment : The ConcernUsages framed by this RequirementDefinition, which are the ownedConcerns of all FramedConcernMemberships of the RequirementDefinition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#requirementDefinition_FramedConcern">oslc_sysmlv2:requirementDefinition_FramedConcern</a>
    /// </summary>
    let requirementDefinition_FramedConcern = _prefixId.prefix "requirementDefinition_FramedConcern"

    /// <summary>
    ///   <para>rdfs:label : requirementDefinition_ReqId^^xsd:string</para>
    ///   <para>rdfs:comment : An optional modeler-specified identifier for this RequirementDefinition (used, e.g., to link it to an original requirement text in some source document), which is the declaredShortName for the RequirementDefinition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#requirementDefinition_ReqId">oslc_sysmlv2:requirementDefinition_ReqId</a>
    /// </summary>
    let requirementDefinition_ReqId = _prefixId.prefix "requirementDefinition_ReqId"

    /// <summary>
    ///   <para>rdfs:label : requirementDefinition_RequiredConstraint^^xsd:string</para>
    ///   <para>rdfs:comment : The owned ConstraintUsages that represent requirements of this RequirementDefinition, derived as the ownedConstraints of the RequirementConstraintMemberships of the RequirementDefinition with kind = requirement.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#requirementDefinition_RequiredConstraint">oslc_sysmlv2:requirementDefinition_RequiredConstraint</a>
    /// </summary>
    let requirementDefinition_RequiredConstraint = _prefixId.prefix "requirementDefinition_RequiredConstraint"

    /// <summary>
    ///   <para>rdfs:label : requirementDefinition_StakeholderParameter^^xsd:string</para>
    ///   <para>rdfs:comment : The parameters of this RequirementDefinition that represent stakeholders for th requirement.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#requirementDefinition_StakeholderParameter">oslc_sysmlv2:requirementDefinition_StakeholderParameter</a>
    /// </summary>
    let requirementDefinition_StakeholderParameter = _prefixId.prefix "requirementDefinition_StakeholderParameter"

    /// <summary>
    ///   <para>rdfs:label : requirementDefinition_SubjectParameter^^xsd:string</para>
    ///   <para>rdfs:comment : The parameter of this RequirementDefinition that represents its subject.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#requirementDefinition_SubjectParameter">oslc_sysmlv2:requirementDefinition_SubjectParameter</a>
    /// </summary>
    let requirementDefinition_SubjectParameter = _prefixId.prefix "requirementDefinition_SubjectParameter"

    /// <summary>
    ///   <para>rdfs:label : requirementDefinition_Text^^xsd:string</para>
    ///   <para>rdfs:comment : An optional textual statement of the requirement represented by this RequirementDefinition, derived from the bodies of the documentation of the RequirementDefinition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#requirementDefinition_Text">oslc_sysmlv2:requirementDefinition_Text</a>
    /// </summary>
    let requirementDefinition_Text = _prefixId.prefix "requirementDefinition_Text"

    /// <summary>
    ///   <para>rdfs:label : requirementUsage_ActorParameter^^xsd:string</para>
    ///   <para>rdfs:comment : The parameters of this RequirementUsage that represent actors involved in the requirement.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#requirementUsage_ActorParameter">oslc_sysmlv2:requirementUsage_ActorParameter</a>
    /// </summary>
    let requirementUsage_ActorParameter = _prefixId.prefix "requirementUsage_ActorParameter"

    /// <summary>
    ///   <para>rdfs:label : requirementUsage_AssumedConstraint^^xsd:string</para>
    ///   <para>rdfs:comment : The owned ConstraintUsages that represent assumptions of this RequirementUsage, derived as the ownedConstraints of the RequirementConstraintMemberships of the RequirementUsage with kind = assumption.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#requirementUsage_AssumedConstraint">oslc_sysmlv2:requirementUsage_AssumedConstraint</a>
    /// </summary>
    let requirementUsage_AssumedConstraint = _prefixId.prefix "requirementUsage_AssumedConstraint"

    /// <summary>
    ///   <para>rdfs:label : requirementUsage_FramedConcern^^xsd:string</para>
    ///   <para>rdfs:comment : The ConcernUsages framed by this RequirementUsage, which are the ownedConcerns of all FramedConcernMemberships of the RequirementUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#requirementUsage_FramedConcern">oslc_sysmlv2:requirementUsage_FramedConcern</a>
    /// </summary>
    let requirementUsage_FramedConcern = _prefixId.prefix "requirementUsage_FramedConcern"

    /// <summary>
    ///   <para>rdfs:label : requirementUsage_ReqId^^xsd:string</para>
    ///   <para>rdfs:comment : An optional modeler-specified identifier for this RequirementUsage (used, e.g., to link it to an original requirement text in some source document), which is the declaredShortName for the RequirementUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#requirementUsage_ReqId">oslc_sysmlv2:requirementUsage_ReqId</a>
    /// </summary>
    let requirementUsage_ReqId = _prefixId.prefix "requirementUsage_ReqId"

    /// <summary>
    ///   <para>rdfs:label : requirementUsage_RequiredConstraint^^xsd:string</para>
    ///   <para>rdfs:comment : The owned ConstraintUsages that represent requirements of this RequirementUsage, which are the ownedConstraints of the RequirementConstraintMemberships of the RequirementUsage with kind = requirement.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#requirementUsage_RequiredConstraint">oslc_sysmlv2:requirementUsage_RequiredConstraint</a>
    /// </summary>
    let requirementUsage_RequiredConstraint = _prefixId.prefix "requirementUsage_RequiredConstraint"

    /// <summary>
    ///   <para>rdfs:label : requirementUsage_RequirementDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : The RequirementDefinition that is the single definition of this RequirementUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#requirementUsage_RequirementDefinition">oslc_sysmlv2:requirementUsage_RequirementDefinition</a>
    /// </summary>
    let requirementUsage_RequirementDefinition = _prefixId.prefix "requirementUsage_RequirementDefinition"

    /// <summary>
    ///   <para>rdfs:label : requirementUsage_StakeholderParameter^^xsd:string</para>
    ///   <para>rdfs:comment : The parameters of this RequirementUsage that represent stakeholders for the requirement.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#requirementUsage_StakeholderParameter">oslc_sysmlv2:requirementUsage_StakeholderParameter</a>
    /// </summary>
    let requirementUsage_StakeholderParameter = _prefixId.prefix "requirementUsage_StakeholderParameter"

    /// <summary>
    ///   <para>rdfs:label : requirementUsage_SubjectParameter^^xsd:string</para>
    ///   <para>rdfs:comment : The parameter of this RequirementUsage that represents its subject.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#requirementUsage_SubjectParameter">oslc_sysmlv2:requirementUsage_SubjectParameter</a>
    /// </summary>
    let requirementUsage_SubjectParameter = _prefixId.prefix "requirementUsage_SubjectParameter"

    /// <summary>
    ///   <para>rdfs:label : requirementUsage_Text^^xsd:string</para>
    ///   <para>rdfs:comment : An optional textual statement of the requirement represented by this RequirementUsage, derived from the bodies of the documentation of the RequirementUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#requirementUsage_Text">oslc_sysmlv2:requirementUsage_Text</a>
    /// </summary>
    let requirementUsage_Text = _prefixId.prefix "requirementUsage_Text"

    /// <summary>
    ///   <para>rdfs:label : requirementVerificationMembership_OwnedRequirement^^xsd:string</para>
    ///   <para>rdfs:comment : The owned RequirementUsage that acts as the ownedConstraint for this RequirementVerificationMembership. This will either be the verifiedRequirement, or it will subset the verifiedRequirement.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#requirementVerificationMembership_OwnedRequirement">oslc_sysmlv2:requirementVerificationMembership_OwnedRequirement</a>
    /// </summary>
    let requirementVerificationMembership_OwnedRequirement = _prefixId.prefix "requirementVerificationMembership_OwnedRequirement"

    /// <summary>
    ///   <para>rdfs:label : requirementVerificationMembership_VerifiedRequirement^^xsd:string</para>
    ///   <para>rdfs:comment :  The RequirementUsage that is identified as being verified. It is the referencedConstraint of the RequirementVerificationMembership considered as a RequirementConstraintMembership, which must be a RequirementUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#requirementVerificationMembership_VerifiedRequirement">oslc_sysmlv2:requirementVerificationMembership_VerifiedRequirement</a>
    /// </summary>
    let requirementVerificationMembership_VerifiedRequirement = _prefixId.prefix "requirementVerificationMembership_VerifiedRequirement"

    /// <summary>
    ///   <para>rdfs:label : resultExpressionMembership_OwnedResultExpression^^xsd:string</para>
    ///   <para>rdfs:comment : The Expression that provides the result for the owner of the ResultExpressionMembership.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#resultExpressionMembership_OwnedResultExpression">oslc_sysmlv2:resultExpressionMembership_OwnedResultExpression</a>
    /// </summary>
    let resultExpressionMembership_OwnedResultExpression = _prefixId.prefix "resultExpressionMembership_OwnedResultExpression"

    /// <summary>
    ///   <para>rdfs:label : satisfyRequirementUsage_SatisfiedRequirement^^xsd:string</para>
    ///   <para>rdfs:comment : The RequirementUsage that is satisfied by the satisfyingSubject of this SatisfyRequirementUsage. It is the assertedConstraint of the SatisfyRequirementUsage considered as an AssertConstraintUsage, which must be a RequirementUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#satisfyRequirementUsage_SatisfiedRequirement">oslc_sysmlv2:satisfyRequirementUsage_SatisfiedRequirement</a>
    /// </summary>
    let satisfyRequirementUsage_SatisfiedRequirement = _prefixId.prefix "satisfyRequirementUsage_SatisfiedRequirement"

    /// <summary>
    ///   <para>rdfs:label : satisfyRequirementUsage_SatisfyingFeature^^xsd:string</para>
    ///   <para>rdfs:comment : The Feature that represents the actual subject that is asserted to satisfy the satisfiedRequirement. The satisfyingFeature is bound to the subjectParameter of the SatisfyRequirementUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#satisfyRequirementUsage_SatisfyingFeature">oslc_sysmlv2:satisfyRequirementUsage_SatisfyingFeature</a>
    /// </summary>
    let satisfyRequirementUsage_SatisfyingFeature = _prefixId.prefix "satisfyRequirementUsage_SatisfyingFeature"

    /// <summary>
    ///   <para>rdfs:label : sendActionUsage_PayloadArgument^^xsd:string</para>
    ///   <para>rdfs:comment : An Expression whose result is bound to the payload input parameter of this SendActionUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#sendActionUsage_PayloadArgument">oslc_sysmlv2:sendActionUsage_PayloadArgument</a>
    /// </summary>
    let sendActionUsage_PayloadArgument = _prefixId.prefix "sendActionUsage_PayloadArgument"

    /// <summary>
    ///   <para>rdfs:label : sendActionUsage_ReceiverArgument^^xsd:string</para>
    ///   <para>rdfs:comment : An Expression whose result is bound to the receiver input parameter of this SendActionUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#sendActionUsage_ReceiverArgument">oslc_sysmlv2:sendActionUsage_ReceiverArgument</a>
    /// </summary>
    let sendActionUsage_ReceiverArgument = _prefixId.prefix "sendActionUsage_ReceiverArgument"

    /// <summary>
    ///   <para>rdfs:label : sendActionUsage_SenderArgument^^xsd:string</para>
    ///   <para>rdfs:comment : An Expression whose result is bound to the sender input parameter of this SendActionUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#sendActionUsage_SenderArgument">oslc_sysmlv2:sendActionUsage_SenderArgument</a>
    /// </summary>
    let sendActionUsage_SenderArgument = _prefixId.prefix "sendActionUsage_SenderArgument"

    /// <summary>
    ///   <para>rdfs:label : specialization_General^^xsd:string</para>
    ///   <para>rdfs:comment : A Type with a superset of all instances of the specific Type, which might be the same set.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#specialization_General">oslc_sysmlv2:specialization_General</a>
    /// </summary>
    let specialization_General = _prefixId.prefix "specialization_General"
    /// <summary>
    ///   <para>rdfs:label : specialization_OwningType^^xsd:string</para>
    ///   <para>rdfs:comment : The Type that is the specific Type of this Specialization and owns it as its owningRelatedElement.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#specialization_OwningType">oslc_sysmlv2:specialization_OwningType</a>
    /// </summary>
    let specialization_OwningType = _prefixId.prefix "specialization_OwningType"
    /// <summary>
    ///   <para>rdfs:label : specialization_Specific^^xsd:string</para>
    ///   <para>rdfs:comment : A Type with a subset of all instances of the general Type, which might be the same set.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#specialization_Specific">oslc_sysmlv2:specialization_Specific</a>
    /// </summary>
    let specialization_Specific = _prefixId.prefix "specialization_Specific"

    /// <summary>
    ///   <para>rdfs:label : stakeholderMembership_OwnedStakeholderParameter^^xsd:string</para>
    ///   <para>rdfs:comment : The PartUsage specifying the stakeholder.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#stakeholderMembership_OwnedStakeholderParameter">oslc_sysmlv2:stakeholderMembership_OwnedStakeholderParameter</a>
    /// </summary>
    let stakeholderMembership_OwnedStakeholderParameter = _prefixId.prefix "stakeholderMembership_OwnedStakeholderParameter"

    /// <summary>
    ///   <para>rdfs:label : stateDefinition_DoAction^^xsd:string</para>
    ///   <para>rdfs:comment : The ActionUsage of this StateDefinition to be performed while in the state defined by the StateDefinition. It is the owned ActionUsage related to the StateDefinition by a StateSubactionMembership  with kind = do.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#stateDefinition_DoAction">oslc_sysmlv2:stateDefinition_DoAction</a>
    /// </summary>
    let stateDefinition_DoAction = _prefixId.prefix "stateDefinition_DoAction"
    /// <summary>
    ///   <para>rdfs:label : stateDefinition_EntryAction^^xsd:string</para>
    ///   <para>rdfs:comment : The ActionUsage of this StateDefinition to be performed on entry to the state defined by the StateDefinition. It is the owned ActionUsage related to the StateDefinition by a StateSubactionMembership  with kind = entry.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#stateDefinition_EntryAction">oslc_sysmlv2:stateDefinition_EntryAction</a>
    /// </summary>
    let stateDefinition_EntryAction = _prefixId.prefix "stateDefinition_EntryAction"
    /// <summary>
    ///   <para>rdfs:label : stateDefinition_ExitAction^^xsd:string</para>
    ///   <para>rdfs:comment : The ActionUsage of this StateDefinition to be performed on exit to the state defined by the StateDefinition. It is the owned ActionUsage related to the StateDefinition by a StateSubactionMembership  with kind = exit.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#stateDefinition_ExitAction">oslc_sysmlv2:stateDefinition_ExitAction</a>
    /// </summary>
    let stateDefinition_ExitAction = _prefixId.prefix "stateDefinition_ExitAction"
    /// <summary>
    ///   <para>rdfs:label : stateDefinition_IsParallel^^xsd:string</para>
    ///   <para>rdfs:comment : Whether the ownedStates of this StateDefinition are to all be performed in parallel. If true, none of the ownedActions (which includes ownedStates) may have any incoming or outgoing Transitions. If false, only one ownedState may be performed at a time.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#stateDefinition_IsParallel">oslc_sysmlv2:stateDefinition_IsParallel</a>
    /// </summary>
    let stateDefinition_IsParallel = _prefixId.prefix "stateDefinition_IsParallel"
    /// <summary>
    ///   <para>rdfs:label : stateDefinition_State^^xsd:string</para>
    ///   <para>rdfs:comment : The StateUsages, which are actions in the StateDefinition, that specify the discrete states in the behavior defined by the StateDefinition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#stateDefinition_State">oslc_sysmlv2:stateDefinition_State</a>
    /// </summary>
    let stateDefinition_State = _prefixId.prefix "stateDefinition_State"
    let stateSubactionKind_Do = _prefixId.prefix "stateSubactionKind_Do"
    let stateSubactionKind_Entry = _prefixId.prefix "stateSubactionKind_Entry"
    let stateSubactionKind_Exit = _prefixId.prefix "stateSubactionKind_Exit"

    /// <summary>
    ///   <para>rdfs:label : stateSubactionMembership_Action^^xsd:string</para>
    ///   <para>rdfs:comment : The ActionUsage that is the ownedMemberFeature of this StateSubactionMembership.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#stateSubactionMembership_Action">oslc_sysmlv2:stateSubactionMembership_Action</a>
    /// </summary>
    let stateSubactionMembership_Action = _prefixId.prefix "stateSubactionMembership_Action"

    /// <summary>
    ///   <para>rdfs:label : stateSubactionMembership_Kind^^xsd:string</para>
    ///   <para>rdfs:comment : Whether this StateSubactionMembership is for an entry, do or exit ActionUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#stateSubactionMembership_Kind">oslc_sysmlv2:stateSubactionMembership_Kind</a>
    /// </summary>
    let stateSubactionMembership_Kind = _prefixId.prefix "stateSubactionMembership_Kind"
    /// <summary>
    ///   <para>rdfs:label : stateUsage_DoAction^^xsd:string</para>
    ///   <para>rdfs:comment : The ActionUsage of this StateUsage to be performed while in the state defined by the StateDefinition. It is the owned ActionUsage related to the StateUsage by a StateSubactionMembership  with kind = do.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#stateUsage_DoAction">oslc_sysmlv2:stateUsage_DoAction</a>
    /// </summary>
    let stateUsage_DoAction = _prefixId.prefix "stateUsage_DoAction"
    /// <summary>
    ///   <para>rdfs:label : stateUsage_EntryAction^^xsd:string</para>
    ///   <para>rdfs:comment : The ActionUsage of this StateUsage to be performed on entry to the state defined by the StateDefinition. It is the owned ActionUsage related to the StateUsage by a StateSubactionMembership  with kind = entry.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#stateUsage_EntryAction">oslc_sysmlv2:stateUsage_EntryAction</a>
    /// </summary>
    let stateUsage_EntryAction = _prefixId.prefix "stateUsage_EntryAction"
    /// <summary>
    ///   <para>rdfs:label : stateUsage_ExitAction^^xsd:string</para>
    ///   <para>rdfs:comment : The ActionUsage of this StateUsage to be performed on exit to the state defined by the StateDefinition. It is the owned ActionUsage related to the StateUsage by a StateSubactionMembership  with kind = exit.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#stateUsage_ExitAction">oslc_sysmlv2:stateUsage_ExitAction</a>
    /// </summary>
    let stateUsage_ExitAction = _prefixId.prefix "stateUsage_ExitAction"
    /// <summary>
    ///   <para>rdfs:label : stateUsage_IsParallel^^xsd:string</para>
    ///   <para>rdfs:comment : Whether the nestedStates of this StateUsage are to all be performed in parallel. If true, none of the nestedActions (which include nestedStates) may have any incoming or outgoing Transitions. If false, only one nestedState may be performed at a time.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#stateUsage_IsParallel">oslc_sysmlv2:stateUsage_IsParallel</a>
    /// </summary>
    let stateUsage_IsParallel = _prefixId.prefix "stateUsage_IsParallel"
    /// <summary>
    ///   <para>rdfs:label : stateUsage_StateDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : The Behaviors that are the types of this StateUsage. Nominally, these would be StateDefinitions, but kernel Behaviors are also allowed, to permit use of Behaviors from the Kernel Model Libraries.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#stateUsage_StateDefinition">oslc_sysmlv2:stateUsage_StateDefinition</a>
    /// </summary>
    let stateUsage_StateDefinition = _prefixId.prefix "stateUsage_StateDefinition"
    /// <summary>
    ///   <para>rdfs:label : step_Behavior^^xsd:string</para>
    ///   <para>rdfs:comment : The Behaviors that type this Step.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#step_Behavior">oslc_sysmlv2:step_Behavior</a>
    /// </summary>
    let step_Behavior = _prefixId.prefix "step_Behavior"
    /// <summary>
    ///   <para>rdfs:label : step_Parameter^^xsd:string</para>
    ///   <para>rdfs:comment : The parameters of this Step, which are defined as its directedFeatures, whose values are passed into and/or out of a performance of the Step.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#step_Parameter">oslc_sysmlv2:step_Parameter</a>
    /// </summary>
    let step_Parameter = _prefixId.prefix "step_Parameter"

    /// <summary>
    ///   <para>rdfs:label : subclassification_OwningClassifier^^xsd:string</para>
    ///   <para>rdfs:comment : The Classifier that owns this Subclassification relationship, which must also be its subclassifier.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#subclassification_OwningClassifier">oslc_sysmlv2:subclassification_OwningClassifier</a>
    /// </summary>
    let subclassification_OwningClassifier = _prefixId.prefix "subclassification_OwningClassifier"

    /// <summary>
    ///   <para>rdfs:label : subclassification_Subclassifier^^xsd:string</para>
    ///   <para>rdfs:comment : The more specific Classifier in this Subclassification.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#subclassification_Subclassifier">oslc_sysmlv2:subclassification_Subclassifier</a>
    /// </summary>
    let subclassification_Subclassifier = _prefixId.prefix "subclassification_Subclassifier"

    /// <summary>
    ///   <para>rdfs:label : subclassification_Superclassifier^^xsd:string</para>
    ///   <para>rdfs:comment : The more general Classifier in this Subclassification.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#subclassification_Superclassifier">oslc_sysmlv2:subclassification_Superclassifier</a>
    /// </summary>
    let subclassification_Superclassifier = _prefixId.prefix "subclassification_Superclassifier"

    /// <summary>
    ///   <para>rdfs:label : subjectMembership_OwnedSubjectParameter^^xsd:string</para>
    ///   <para>rdfs:comment : The UsageownedMemberParameter of this SubjectMembership.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#subjectMembership_OwnedSubjectParameter">oslc_sysmlv2:subjectMembership_OwnedSubjectParameter</a>
    /// </summary>
    let subjectMembership_OwnedSubjectParameter = _prefixId.prefix "subjectMembership_OwnedSubjectParameter"

    /// <summary>
    ///   <para>rdfs:label : subsetting_OwningFeature^^xsd:string</para>
    ///   <para>rdfs:comment : A subsettingFeature that is also the owningRelatedElement of this Subsetting.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#subsetting_OwningFeature">oslc_sysmlv2:subsetting_OwningFeature</a>
    /// </summary>
    let subsetting_OwningFeature = _prefixId.prefix "subsetting_OwningFeature"
    /// <summary>
    ///   <para>rdfs:label : subsetting_SubsettedFeature^^xsd:string</para>
    ///   <para>rdfs:comment : The Feature that is subsetted by the subsettingFeature of this Subsetting.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#subsetting_SubsettedFeature">oslc_sysmlv2:subsetting_SubsettedFeature</a>
    /// </summary>
    let subsetting_SubsettedFeature = _prefixId.prefix "subsetting_SubsettedFeature"
    /// <summary>
    ///   <para>rdfs:label : subsetting_SubsettingFeature^^xsd:string</para>
    ///   <para>rdfs:comment : The Feature that is a subset of the subsettedFeature of this Subsetting.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#subsetting_SubsettingFeature">oslc_sysmlv2:subsetting_SubsettingFeature</a>
    /// </summary>
    let subsetting_SubsettingFeature = _prefixId.prefix "subsetting_SubsettingFeature"
    /// <summary>
    ///   <para>rdfs:label : succession_EffectStep^^xsd:string</para>
    ///   <para>rdfs:comment : Steps that represent occurrences that are side effects of the transitionStep occurring.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#succession_EffectStep">oslc_sysmlv2:succession_EffectStep</a>
    /// </summary>
    let succession_EffectStep = _prefixId.prefix "succession_EffectStep"
    /// <summary>
    ///   <para>rdfs:label : succession_GuardExpression^^xsd:string</para>
    ///   <para>rdfs:comment : Expressions that must evaluate to true before the transitionStep can occur.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#succession_GuardExpression">oslc_sysmlv2:succession_GuardExpression</a>
    /// </summary>
    let succession_GuardExpression = _prefixId.prefix "succession_GuardExpression"
    /// <summary>
    ///   <para>rdfs:label : succession_TransitionStep^^xsd:string</para>
    ///   <para>rdfs:comment : A Step that is typed by the Behavior TransitionPerformances::TransitionPerformance (from the Kernel Semantic Library) that has this Succession as its transitionLink.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#succession_TransitionStep">oslc_sysmlv2:succession_TransitionStep</a>
    /// </summary>
    let succession_TransitionStep = _prefixId.prefix "succession_TransitionStep"
    /// <summary>
    ///   <para>rdfs:label : succession_TriggerStep^^xsd:string</para>
    ///   <para>rdfs:comment : Steps that map incoming events to the timing of occurrences of the transitionStep. The values of triggerStep subset the list of acceptable events to be received by a Behavior or the object that performs it.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#succession_TriggerStep">oslc_sysmlv2:succession_TriggerStep</a>
    /// </summary>
    let succession_TriggerStep = _prefixId.prefix "succession_TriggerStep"
    /// <summary>
    ///   <para>rdfs:label : textualRepresentation_Body^^xsd:string</para>
    ///   <para>rdfs:comment : The textual representation of the representedElement in the given language.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#textualRepresentation_Body">oslc_sysmlv2:textualRepresentation_Body</a>
    /// </summary>
    let textualRepresentation_Body = _prefixId.prefix "textualRepresentation_Body"

    /// <summary>
    ///   <para>rdfs:label : textualRepresentation_Language^^xsd:string</para>
    ///   <para>rdfs:comment : The natural or artifical language in which the body text is written.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#textualRepresentation_Language">oslc_sysmlv2:textualRepresentation_Language</a>
    /// </summary>
    let textualRepresentation_Language = _prefixId.prefix "textualRepresentation_Language"

    /// <summary>
    ///   <para>rdfs:label : textualRepresentation_RepresentedElement^^xsd:string</para>
    ///   <para>rdfs:comment : The Element that is represented by this TextualRepresentation.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#textualRepresentation_RepresentedElement">oslc_sysmlv2:textualRepresentation_RepresentedElement</a>
    /// </summary>
    let textualRepresentation_RepresentedElement = _prefixId.prefix "textualRepresentation_RepresentedElement"

    let transitionFeatureKind_Effect = _prefixId.prefix "transitionFeatureKind_Effect"
    let transitionFeatureKind_Guard = _prefixId.prefix "transitionFeatureKind_Guard"
    let transitionFeatureKind_Trigger = _prefixId.prefix "transitionFeatureKind_Trigger"

    /// <summary>
    ///   <para>rdfs:label : transitionFeatureMembership_Kind^^xsd:string</para>
    ///   <para>rdfs:comment : Whether this TransitionFeatureMembership  is for a trigger, guard or effect.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#transitionFeatureMembership_Kind">oslc_sysmlv2:transitionFeatureMembership_Kind</a>
    /// </summary>
    let transitionFeatureMembership_Kind = _prefixId.prefix "transitionFeatureMembership_Kind"

    /// <summary>
    ///   <para>rdfs:label : transitionFeatureMembership_TransitionFeature^^xsd:string</para>
    ///   <para>rdfs:comment : The Step that is the ownedMemberFeature of this TransitionFeatureMembership.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#transitionFeatureMembership_TransitionFeature">oslc_sysmlv2:transitionFeatureMembership_TransitionFeature</a>
    /// </summary>
    let transitionFeatureMembership_TransitionFeature = _prefixId.prefix "transitionFeatureMembership_TransitionFeature"

    /// <summary>
    ///   <para>rdfs:label : transitionUsage_EffectAction^^xsd:string</para>
    ///   <para>rdfs:comment : The ActionUsages that define the effects of this TransitionUsage, which are the ownedFeatures of the TransitionUsage related to it by TransitionFeatureMemberships with kind = effect, which must all be ActionUsages.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#transitionUsage_EffectAction">oslc_sysmlv2:transitionUsage_EffectAction</a>
    /// </summary>
    let transitionUsage_EffectAction = _prefixId.prefix "transitionUsage_EffectAction"

    /// <summary>
    ///   <para>rdfs:label : transitionUsage_GuardExpression^^xsd:string</para>
    ///   <para>rdfs:comment : The Expressions that define the guards of this TransitionUsage, which are the ownedFeatures of the TransitionUsage related to it by TransitionFeatureMemberships with kind = guard, which must all be Expressions.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#transitionUsage_GuardExpression">oslc_sysmlv2:transitionUsage_GuardExpression</a>
    /// </summary>
    let transitionUsage_GuardExpression = _prefixId.prefix "transitionUsage_GuardExpression"

    /// <summary>
    ///   <para>rdfs:label : transitionUsage_Source^^xsd:string</para>
    ///   <para>rdfs:comment : The source ActionUsage of this TransitionUsage, which becomes the source of the succession for the TransitionUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#transitionUsage_Source">oslc_sysmlv2:transitionUsage_Source</a>
    /// </summary>
    let transitionUsage_Source = _prefixId.prefix "transitionUsage_Source"
    /// <summary>
    ///   <para>rdfs:label : transitionUsage_Succession^^xsd:string</para>
    ///   <para>rdfs:comment : The Succession that is the ownedFeature of this TransitionUsage, which, if the TransitionUsage is triggered, asserts the temporal ordering of the source and target.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#transitionUsage_Succession">oslc_sysmlv2:transitionUsage_Succession</a>
    /// </summary>
    let transitionUsage_Succession = _prefixId.prefix "transitionUsage_Succession"
    /// <summary>
    ///   <para>rdfs:label : transitionUsage_Target^^xsd:string</para>
    ///   <para>rdfs:comment : The target ActionUsage of this TransitionUsage, which is the targetFeature of the succession for the TransitionUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#transitionUsage_Target">oslc_sysmlv2:transitionUsage_Target</a>
    /// </summary>
    let transitionUsage_Target = _prefixId.prefix "transitionUsage_Target"
    /// <summary>
    ///   <para>rdfs:label : transitionUsage_TriggerAction^^xsd:string</para>
    ///   <para>rdfs:comment : The AcceptActionUsages that define the triggers of this TransitionUsage, which are the ownedFeatures of the TransitionUsage related to it by TransitionFeatureMemberships with kind = trigger, which must all be AcceptActionUsages.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#transitionUsage_TriggerAction">oslc_sysmlv2:transitionUsage_TriggerAction</a>
    /// </summary>
    let transitionUsage_TriggerAction = _prefixId.prefix "transitionUsage_TriggerAction"

    /// <summary>
    ///   <para>rdfs:label : triggerInvocationExpression_Kind^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates which of the Functions from the Triggers model in the Kernel Semantic Library is to be invoked by this TriggerInvocationExpression.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#triggerInvocationExpression_Kind">oslc_sysmlv2:triggerInvocationExpression_Kind</a>
    /// </summary>
    let triggerInvocationExpression_Kind = _prefixId.prefix "triggerInvocationExpression_Kind"

    let triggerKind_After = _prefixId.prefix "triggerKind_After"
    let triggerKind_At = _prefixId.prefix "triggerKind_At"
    let triggerKind_When = _prefixId.prefix "triggerKind_When"
    /// <summary>
    ///   <para>rdfs:label : typeFeaturing_FeatureOfType^^xsd:string</para>
    ///   <para>rdfs:comment : The Feature that is featured by the featuringType. It is the source of the TypeFeaturing.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#typeFeaturing_FeatureOfType">oslc_sysmlv2:typeFeaturing_FeatureOfType</a>
    /// </summary>
    let typeFeaturing_FeatureOfType = _prefixId.prefix "typeFeaturing_FeatureOfType"
    /// <summary>
    ///   <para>rdfs:label : typeFeaturing_FeaturingType^^xsd:string</para>
    ///   <para>rdfs:comment : The Type that features the featureOfType. It is the target of the TypeFeaturing.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#typeFeaturing_FeaturingType">oslc_sysmlv2:typeFeaturing_FeaturingType</a>
    /// </summary>
    let typeFeaturing_FeaturingType = _prefixId.prefix "typeFeaturing_FeaturingType"

    /// <summary>
    ///   <para>rdfs:label : typeFeaturing_OwningFeatureOfType^^xsd:string</para>
    ///   <para>rdfs:comment : A featureOfType that is also the owningRelatedElement of this TypeFeaturing.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#typeFeaturing_OwningFeatureOfType">oslc_sysmlv2:typeFeaturing_OwningFeatureOfType</a>
    /// </summary>
    let typeFeaturing_OwningFeatureOfType = _prefixId.prefix "typeFeaturing_OwningFeatureOfType"

    /// <summary>
    ///   <para>rdfs:label : type_DifferencingType^^xsd:string</para>
    ///   <para>rdfs:comment : The interpretations of a Type with differencingTypes are asserted to be those of the first of those Types, but not including those of the remaining Types. For example, a Classifier might be the difference of a Classifier for people and another for people of a particular nationality, leaving people who are not of that nationality. Similarly, a feature of people might be the difference between a feature for their children and a Classifier for people of a particular sex, identifying their children not of that sex (because the interpretations of the children Feature that identify those of that sex are also interpretations of the Classifier for that sex).^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#type_DifferencingType">oslc_sysmlv2:type_DifferencingType</a>
    /// </summary>
    let type_DifferencingType = _prefixId.prefix "type_DifferencingType"
    /// <summary>
    ///   <para>rdfs:label : type_DirectedFeature^^xsd:string</para>
    ///   <para>rdfs:comment : The features of this Type that have a non-null direction.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#type_DirectedFeature">oslc_sysmlv2:type_DirectedFeature</a>
    /// </summary>
    let type_DirectedFeature = _prefixId.prefix "type_DirectedFeature"
    /// <summary>
    ///   <para>rdfs:label : type_EndFeature^^xsd:string</para>
    ///   <para>rdfs:comment : All features of this Type with isEnd = true.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#type_EndFeature">oslc_sysmlv2:type_EndFeature</a>
    /// </summary>
    let type_EndFeature = _prefixId.prefix "type_EndFeature"
    /// <summary>
    ///   <para>rdfs:label : type_Feature^^xsd:string</para>
    ///   <para>rdfs:comment : The ownedMemberFeatures of the featureMemberships of this Type.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#type_Feature">oslc_sysmlv2:type_Feature</a>
    /// </summary>
    let type_Feature = _prefixId.prefix "type_Feature"
    /// <summary>
    ///   <para>rdfs:label : type_FeatureMembership^^xsd:string</para>
    ///   <para>rdfs:comment : The FeatureMemberships for features of this Type, which include all ownedFeatureMemberships and those inheritedMemberships that are FeatureMemberships (but does not include any importedMemberships).^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#type_FeatureMembership">oslc_sysmlv2:type_FeatureMembership</a>
    /// </summary>
    let type_FeatureMembership = _prefixId.prefix "type_FeatureMembership"
    /// <summary>
    ///   <para>rdfs:label : type_InheritedFeature^^xsd:string</para>
    ///   <para>rdfs:comment : All the memberFeatures of the inheritedMemberships of this Type that are FeatureMemberships.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#type_InheritedFeature">oslc_sysmlv2:type_InheritedFeature</a>
    /// </summary>
    let type_InheritedFeature = _prefixId.prefix "type_InheritedFeature"
    /// <summary>
    ///   <para>rdfs:label : type_InheritedMembership^^xsd:string</para>
    ///   <para>rdfs:comment : All Memberships inherited by this Type via Specialization or Conjugation. These are included in the derived union for the memberships of the Type.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#type_InheritedMembership">oslc_sysmlv2:type_InheritedMembership</a>
    /// </summary>
    let type_InheritedMembership = _prefixId.prefix "type_InheritedMembership"
    /// <summary>
    ///   <para>rdfs:label : type_Input^^xsd:string</para>
    ///   <para>rdfs:comment : All features related to this Type by FeatureMemberships that have direction in or inout.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#type_Input">oslc_sysmlv2:type_Input</a>
    /// </summary>
    let type_Input = _prefixId.prefix "type_Input"
    /// <summary>
    ///   <para>rdfs:label : type_IntersectingType^^xsd:string</para>
    ///   <para>rdfs:comment : The interpretations of a Type with intersectingTypes are asserted to be those in common among the intersectingTypes, which are the Types derived from the intersectingType of the ownedIntersectings of this Type. For example, a Classifier might be an intersection of Classifiers for people of a particular sex and of a particular nationality. Similarly, a feature for people's children of a particular sex might be the intersection of a Feature for their children and a Classifier for people of that sex (because the interpretations of the children Feature that identify those of that sex are also interpretations of the Classifier for that sex).^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#type_IntersectingType">oslc_sysmlv2:type_IntersectingType</a>
    /// </summary>
    let type_IntersectingType = _prefixId.prefix "type_IntersectingType"
    /// <summary>
    ///   <para>rdfs:label : type_IsAbstract^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates whether instances of this Type must also be instances of at least one of its specialized Types.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#type_IsAbstract">oslc_sysmlv2:type_IsAbstract</a>
    /// </summary>
    let type_IsAbstract = _prefixId.prefix "type_IsAbstract"
    /// <summary>
    ///   <para>rdfs:label : type_IsConjugated^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates whether this Type has an ownedConjugator.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#type_IsConjugated">oslc_sysmlv2:type_IsConjugated</a>
    /// </summary>
    let type_IsConjugated = _prefixId.prefix "type_IsConjugated"
    /// <summary>
    ///   <para>rdfs:label : type_IsSufficient^^xsd:string</para>
    ///   <para>rdfs:comment : Whether all things that meet the classification conditions of this Type must be classified by the Type.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#type_IsSufficient">oslc_sysmlv2:type_IsSufficient</a>
    /// </summary>
    let type_IsSufficient = _prefixId.prefix "type_IsSufficient"
    /// <summary>
    ///   <para>rdfs:label : type_Multiplicity^^xsd:string</para>
    ///   <para>rdfs:comment : An ownedMember of this Type that is a Multiplicity, which constraints the cardinality of the Type. If there is no such ownedMember, then the cardinality of this Type is constrained by all the Multiplicity constraints applicable to any direct supertypes.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#type_Multiplicity">oslc_sysmlv2:type_Multiplicity</a>
    /// </summary>
    let type_Multiplicity = _prefixId.prefix "type_Multiplicity"
    /// <summary>
    ///   <para>rdfs:label : type_Output^^xsd:string</para>
    ///   <para>rdfs:comment : All features related to this Type by FeatureMemberships that have direction out or inout.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#type_Output">oslc_sysmlv2:type_Output</a>
    /// </summary>
    let type_Output = _prefixId.prefix "type_Output"
    /// <summary>
    ///   <para>rdfs:label : type_OwnedConjugator^^xsd:string</para>
    ///   <para>rdfs:comment : A Conjugation owned by this Type for which the Type is the originalType.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#type_OwnedConjugator">oslc_sysmlv2:type_OwnedConjugator</a>
    /// </summary>
    let type_OwnedConjugator = _prefixId.prefix "type_OwnedConjugator"
    /// <summary>
    ///   <para>rdfs:label : type_OwnedDifferencing^^xsd:string</para>
    ///   <para>rdfs:comment : The ownedRelationships of this Type that are Differencings, having this Type as their typeDifferenced.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#type_OwnedDifferencing">oslc_sysmlv2:type_OwnedDifferencing</a>
    /// </summary>
    let type_OwnedDifferencing = _prefixId.prefix "type_OwnedDifferencing"
    /// <summary>
    ///   <para>rdfs:label : type_OwnedDisjoining^^xsd:string</para>
    ///   <para>rdfs:comment : The ownedRelationships of this Type that are Disjoinings, for which the Type is the typeDisjoined Type.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#type_OwnedDisjoining">oslc_sysmlv2:type_OwnedDisjoining</a>
    /// </summary>
    let type_OwnedDisjoining = _prefixId.prefix "type_OwnedDisjoining"
    /// <summary>
    ///   <para>rdfs:label : type_OwnedEndFeature^^xsd:string</para>
    ///   <para>rdfs:comment : All endFeatures of this Type that are ownedFeatures.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#type_OwnedEndFeature">oslc_sysmlv2:type_OwnedEndFeature</a>
    /// </summary>
    let type_OwnedEndFeature = _prefixId.prefix "type_OwnedEndFeature"
    /// <summary>
    ///   <para>rdfs:label : type_OwnedFeature^^xsd:string</para>
    ///   <para>rdfs:comment : The ownedMemberFeatures of the ownedFeatureMemberships of this Type.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#type_OwnedFeature">oslc_sysmlv2:type_OwnedFeature</a>
    /// </summary>
    let type_OwnedFeature = _prefixId.prefix "type_OwnedFeature"
    /// <summary>
    ///   <para>rdfs:label : type_OwnedFeatureMembership^^xsd:string</para>
    ///   <para>rdfs:comment : The ownedMemberships of this Type that are FeatureMemberships, for which the Type is the owningType. Each such FeatureMembership identifies an ownedFeature of the Type.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#type_OwnedFeatureMembership">oslc_sysmlv2:type_OwnedFeatureMembership</a>
    /// </summary>
    let type_OwnedFeatureMembership = _prefixId.prefix "type_OwnedFeatureMembership"
    /// <summary>
    ///   <para>rdfs:label : type_OwnedIntersecting^^xsd:string</para>
    ///   <para>rdfs:comment : The ownedRelationships of this Type that are Intersectings, have the Type as their typeIntersected.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#type_OwnedIntersecting">oslc_sysmlv2:type_OwnedIntersecting</a>
    /// </summary>
    let type_OwnedIntersecting = _prefixId.prefix "type_OwnedIntersecting"
    /// <summary>
    ///   <para>rdfs:label : type_OwnedSpecialization^^xsd:string</para>
    ///   <para>rdfs:comment : The ownedRelationships of this Type that are Specializations, for which the Type is the specific Type.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#type_OwnedSpecialization">oslc_sysmlv2:type_OwnedSpecialization</a>
    /// </summary>
    let type_OwnedSpecialization = _prefixId.prefix "type_OwnedSpecialization"
    /// <summary>
    ///   <para>rdfs:label : type_OwnedUnioning^^xsd:string</para>
    ///   <para>rdfs:comment : The ownedRelationships of this Type that are Unionings, having the Type as their typeUnioned.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#type_OwnedUnioning">oslc_sysmlv2:type_OwnedUnioning</a>
    /// </summary>
    let type_OwnedUnioning = _prefixId.prefix "type_OwnedUnioning"
    /// <summary>
    ///   <para>rdfs:label : type_UnioningType^^xsd:string</para>
    ///   <para>rdfs:comment : The interpretations of a Type with unioningTypes are asserted to be the same as those of all the unioningTypes together, which are the Types derived from the unioningType of the ownedUnionings of this Type. For example, a Classifier for people might be the union of Classifiers for all the sexes. Similarly, a feature for people's children might be the union of features dividing them in the same ways as people in general.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#type_UnioningType">oslc_sysmlv2:type_UnioningType</a>
    /// </summary>
    let type_UnioningType = _prefixId.prefix "type_UnioningType"
    /// <summary>
    ///   <para>rdfs:label : unioning_TypeUnioned^^xsd:string</para>
    ///   <para>rdfs:comment : Type with interpretations partly determined by unioningType, as described in Type::unioningType.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#unioning_TypeUnioned">oslc_sysmlv2:unioning_TypeUnioned</a>
    /// </summary>
    let unioning_TypeUnioned = _prefixId.prefix "unioning_TypeUnioned"
    /// <summary>
    ///   <para>rdfs:label : unioning_UnioningType^^xsd:string</para>
    ///   <para>rdfs:comment : Type that partly determines interpretations of typeUnioned, as described in Type::unioningType.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#unioning_UnioningType">oslc_sysmlv2:unioning_UnioningType</a>
    /// </summary>
    let unioning_UnioningType = _prefixId.prefix "unioning_UnioningType"
    /// <summary>
    ///   <para>rdfs:label : usage_Definition^^xsd:string</para>
    ///   <para>rdfs:comment : The Classifiers that are the types of this Usage. Nominally, these are Definitions, but other kinds of Kernel Classifiers are also allowed, to permit use of Classifiers from the Kernel Model Libraries.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#usage_Definition">oslc_sysmlv2:usage_Definition</a>
    /// </summary>
    let usage_Definition = _prefixId.prefix "usage_Definition"
    /// <summary>
    ///   <para>rdfs:label : usage_DirectedUsage^^xsd:string</para>
    ///   <para>rdfs:comment : The usages of this Usage that are directedFeatures.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#usage_DirectedUsage">oslc_sysmlv2:usage_DirectedUsage</a>
    /// </summary>
    let usage_DirectedUsage = _prefixId.prefix "usage_DirectedUsage"
    /// <summary>
    ///   <para>rdfs:label : usage_IsReference^^xsd:string</para>
    ///   <para>rdfs:comment : Whether this Usage is a referential Usage, that is, it has isComposite = false.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#usage_IsReference">oslc_sysmlv2:usage_IsReference</a>
    /// </summary>
    let usage_IsReference = _prefixId.prefix "usage_IsReference"
    /// <summary>
    ///   <para>rdfs:label : usage_IsVariation^^xsd:string</para>
    ///   <para>rdfs:comment : Whether this Usage is for a variation point or not. If true, then all the memberships of the Usage must be VariantMemberships.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#usage_IsVariation">oslc_sysmlv2:usage_IsVariation</a>
    /// </summary>
    let usage_IsVariation = _prefixId.prefix "usage_IsVariation"
    /// <summary>
    ///   <para>rdfs:label : usage_NestedAction^^xsd:string</para>
    ///   <para>rdfs:comment : The ActionUsages that are nestedUsages of this Usage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#usage_NestedAction">oslc_sysmlv2:usage_NestedAction</a>
    /// </summary>
    let usage_NestedAction = _prefixId.prefix "usage_NestedAction"
    /// <summary>
    ///   <para>rdfs:label : usage_NestedAllocation^^xsd:string</para>
    ///   <para>rdfs:comment : The AllocationUsages that are nestedUsages of this Usage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#usage_NestedAllocation">oslc_sysmlv2:usage_NestedAllocation</a>
    /// </summary>
    let usage_NestedAllocation = _prefixId.prefix "usage_NestedAllocation"
    /// <summary>
    ///   <para>rdfs:label : usage_NestedAnalysisCase^^xsd:string</para>
    ///   <para>rdfs:comment : The AnalysisCaseUsages that are nestedUsages of this Usage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#usage_NestedAnalysisCase">oslc_sysmlv2:usage_NestedAnalysisCase</a>
    /// </summary>
    let usage_NestedAnalysisCase = _prefixId.prefix "usage_NestedAnalysisCase"
    /// <summary>
    ///   <para>rdfs:label : usage_NestedAttribute^^xsd:string</para>
    ///   <para>rdfs:comment : The code&gt;AttributeUsages that are nestedUsages of this Usage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#usage_NestedAttribute">oslc_sysmlv2:usage_NestedAttribute</a>
    /// </summary>
    let usage_NestedAttribute = _prefixId.prefix "usage_NestedAttribute"
    /// <summary>
    ///   <para>rdfs:label : usage_NestedCalculation^^xsd:string</para>
    ///   <para>rdfs:comment : The CalculationUsage that are nestedUsages of this Usage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#usage_NestedCalculation">oslc_sysmlv2:usage_NestedCalculation</a>
    /// </summary>
    let usage_NestedCalculation = _prefixId.prefix "usage_NestedCalculation"
    /// <summary>
    ///   <para>rdfs:label : usage_NestedCase^^xsd:string</para>
    ///   <para>rdfs:comment : The CaseUsages that are nestedUsages of this Usage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#usage_NestedCase">oslc_sysmlv2:usage_NestedCase</a>
    /// </summary>
    let usage_NestedCase = _prefixId.prefix "usage_NestedCase"
    /// <summary>
    ///   <para>rdfs:label : usage_NestedConcern^^xsd:string</para>
    ///   <para>rdfs:comment : The ConcernUsages that are nestedUsages of this Usage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#usage_NestedConcern">oslc_sysmlv2:usage_NestedConcern</a>
    /// </summary>
    let usage_NestedConcern = _prefixId.prefix "usage_NestedConcern"
    /// <summary>
    ///   <para>rdfs:label : usage_NestedConnection^^xsd:string</para>
    ///   <para>rdfs:comment : The ConnectorAsUsages that are nestedUsages of this Usage. Note that this list includes BindingConnectorAsUsages and SuccessionAsUsages, even though these are ConnectorAsUsages but not ConnectionUsages.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#usage_NestedConnection">oslc_sysmlv2:usage_NestedConnection</a>
    /// </summary>
    let usage_NestedConnection = _prefixId.prefix "usage_NestedConnection"
    /// <summary>
    ///   <para>rdfs:label : usage_NestedConstraint^^xsd:string</para>
    ///   <para>rdfs:comment : The ConstraintUsages that are nestedUsages of this Usage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#usage_NestedConstraint">oslc_sysmlv2:usage_NestedConstraint</a>
    /// </summary>
    let usage_NestedConstraint = _prefixId.prefix "usage_NestedConstraint"
    /// <summary>
    ///   <para>rdfs:label : usage_NestedEnumeration^^xsd:string</para>
    ///   <para>rdfs:comment : The code&gt;EnumerationUsages that are nestedUsages of this Usage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#usage_NestedEnumeration">oslc_sysmlv2:usage_NestedEnumeration</a>
    /// </summary>
    let usage_NestedEnumeration = _prefixId.prefix "usage_NestedEnumeration"
    /// <summary>
    ///   <para>rdfs:label : usage_NestedFlow^^xsd:string</para>
    ///   <para>rdfs:comment : The code&gt;FlowConnectionUsages that are nestedUsages of this Usage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#usage_NestedFlow">oslc_sysmlv2:usage_NestedFlow</a>
    /// </summary>
    let usage_NestedFlow = _prefixId.prefix "usage_NestedFlow"
    /// <summary>
    ///   <para>rdfs:label : usage_NestedInterface^^xsd:string</para>
    ///   <para>rdfs:comment : The InterfaceUsages that are nestedUsages of this Usage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#usage_NestedInterface">oslc_sysmlv2:usage_NestedInterface</a>
    /// </summary>
    let usage_NestedInterface = _prefixId.prefix "usage_NestedInterface"
    /// <summary>
    ///   <para>rdfs:label : usage_NestedItem^^xsd:string</para>
    ///   <para>rdfs:comment : The ItemUsages that are nestedUsages of this Usage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#usage_NestedItem">oslc_sysmlv2:usage_NestedItem</a>
    /// </summary>
    let usage_NestedItem = _prefixId.prefix "usage_NestedItem"
    /// <summary>
    ///   <para>rdfs:label : usage_NestedMetadata^^xsd:string</para>
    ///   <para>rdfs:comment : The MetadataUsages that are nestedUsages of this of this Usage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#usage_NestedMetadata">oslc_sysmlv2:usage_NestedMetadata</a>
    /// </summary>
    let usage_NestedMetadata = _prefixId.prefix "usage_NestedMetadata"
    /// <summary>
    ///   <para>rdfs:label : usage_NestedOccurrence^^xsd:string</para>
    ///   <para>rdfs:comment : The OccurrenceUsages that are nestedUsages of this Usage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#usage_NestedOccurrence">oslc_sysmlv2:usage_NestedOccurrence</a>
    /// </summary>
    let usage_NestedOccurrence = _prefixId.prefix "usage_NestedOccurrence"
    /// <summary>
    ///   <para>rdfs:label : usage_NestedPart^^xsd:string</para>
    ///   <para>rdfs:comment : The PartUsages that are nestedUsages of this Usage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#usage_NestedPart">oslc_sysmlv2:usage_NestedPart</a>
    /// </summary>
    let usage_NestedPart = _prefixId.prefix "usage_NestedPart"
    /// <summary>
    ///   <para>rdfs:label : usage_NestedPort^^xsd:string</para>
    ///   <para>rdfs:comment : The PortUsages that are nestedUsages of this Usage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#usage_NestedPort">oslc_sysmlv2:usage_NestedPort</a>
    /// </summary>
    let usage_NestedPort = _prefixId.prefix "usage_NestedPort"
    /// <summary>
    ///   <para>rdfs:label : usage_NestedReference^^xsd:string</para>
    ///   <para>rdfs:comment : The ReferenceUsages that are nestedUsages of this Usage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#usage_NestedReference">oslc_sysmlv2:usage_NestedReference</a>
    /// </summary>
    let usage_NestedReference = _prefixId.prefix "usage_NestedReference"
    /// <summary>
    ///   <para>rdfs:label : usage_NestedRendering^^xsd:string</para>
    ///   <para>rdfs:comment : The RenderingUsages that are nestedUsages of this Usage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#usage_NestedRendering">oslc_sysmlv2:usage_NestedRendering</a>
    /// </summary>
    let usage_NestedRendering = _prefixId.prefix "usage_NestedRendering"
    /// <summary>
    ///   <para>rdfs:label : usage_NestedRequirement^^xsd:string</para>
    ///   <para>rdfs:comment : The RequirementUsages that are nestedUsages of this Usage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#usage_NestedRequirement">oslc_sysmlv2:usage_NestedRequirement</a>
    /// </summary>
    let usage_NestedRequirement = _prefixId.prefix "usage_NestedRequirement"
    /// <summary>
    ///   <para>rdfs:label : usage_NestedState^^xsd:string</para>
    ///   <para>rdfs:comment : The StateUsages that are nestedUsages of this Usage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#usage_NestedState">oslc_sysmlv2:usage_NestedState</a>
    /// </summary>
    let usage_NestedState = _prefixId.prefix "usage_NestedState"
    /// <summary>
    ///   <para>rdfs:label : usage_NestedTransition^^xsd:string</para>
    ///   <para>rdfs:comment : The TransitionUsages that are nestedUsages of this Usage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#usage_NestedTransition">oslc_sysmlv2:usage_NestedTransition</a>
    /// </summary>
    let usage_NestedTransition = _prefixId.prefix "usage_NestedTransition"
    /// <summary>
    ///   <para>rdfs:label : usage_NestedUsage^^xsd:string</para>
    ///   <para>rdfs:comment : The Usages that are ownedFeatures of this Usage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#usage_NestedUsage">oslc_sysmlv2:usage_NestedUsage</a>
    /// </summary>
    let usage_NestedUsage = _prefixId.prefix "usage_NestedUsage"
    /// <summary>
    ///   <para>rdfs:label : usage_NestedUseCase^^xsd:string</para>
    ///   <para>rdfs:comment : The UseCaseUsages that are nestedUsages of this Usage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#usage_NestedUseCase">oslc_sysmlv2:usage_NestedUseCase</a>
    /// </summary>
    let usage_NestedUseCase = _prefixId.prefix "usage_NestedUseCase"
    /// <summary>
    ///   <para>rdfs:label : usage_NestedVerificationCase^^xsd:string</para>
    ///   <para>rdfs:comment : The VerificationCaseUsages that are nestedUsages of this Usage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#usage_NestedVerificationCase">oslc_sysmlv2:usage_NestedVerificationCase</a>
    /// </summary>
    let usage_NestedVerificationCase = _prefixId.prefix "usage_NestedVerificationCase"
    /// <summary>
    ///   <para>rdfs:label : usage_NestedView^^xsd:string</para>
    ///   <para>rdfs:comment : The ViewUsages that are nestedUsages of this Usage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#usage_NestedView">oslc_sysmlv2:usage_NestedView</a>
    /// </summary>
    let usage_NestedView = _prefixId.prefix "usage_NestedView"
    /// <summary>
    ///   <para>rdfs:label : usage_NestedViewpoint^^xsd:string</para>
    ///   <para>rdfs:comment : The ViewpointUsages that are nestedUsages of this Usage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#usage_NestedViewpoint">oslc_sysmlv2:usage_NestedViewpoint</a>
    /// </summary>
    let usage_NestedViewpoint = _prefixId.prefix "usage_NestedViewpoint"
    /// <summary>
    ///   <para>rdfs:label : usage_OwningDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : The Definition that owns this Usage (if any).^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#usage_OwningDefinition">oslc_sysmlv2:usage_OwningDefinition</a>
    /// </summary>
    let usage_OwningDefinition = _prefixId.prefix "usage_OwningDefinition"
    /// <summary>
    ///   <para>rdfs:label : usage_OwningUsage^^xsd:string</para>
    ///   <para>rdfs:comment : The Usage in which this Usage is nested (if any).^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#usage_OwningUsage">oslc_sysmlv2:usage_OwningUsage</a>
    /// </summary>
    let usage_OwningUsage = _prefixId.prefix "usage_OwningUsage"
    /// <summary>
    ///   <para>rdfs:label : usage_Usage^^xsd:string</para>
    ///   <para>rdfs:comment : The Usages that are features of this Usage (not necessarily owned).^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#usage_Usage">oslc_sysmlv2:usage_Usage</a>
    /// </summary>
    let usage_Usage = _prefixId.prefix "usage_Usage"
    /// <summary>
    ///   <para>rdfs:label : usage_Variant^^xsd:string</para>
    ///   <para>rdfs:comment : The Usages which represent the variants of this Usage as a variation point Usage, if isVariation = true. If isVariation = false, then there must be no variants.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#usage_Variant">oslc_sysmlv2:usage_Variant</a>
    /// </summary>
    let usage_Variant = _prefixId.prefix "usage_Variant"
    /// <summary>
    ///   <para>rdfs:label : usage_VariantMembership^^xsd:string</para>
    ///   <para>rdfs:comment : The ownedMemberships of this Usage that are VariantMemberships. If isVariation = true, then this must be all memberships of the Usage. If isVariation = false, then variantMembershipmust be empty.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#usage_VariantMembership">oslc_sysmlv2:usage_VariantMembership</a>
    /// </summary>
    let usage_VariantMembership = _prefixId.prefix "usage_VariantMembership"

    /// <summary>
    ///   <para>rdfs:label : useCaseDefinition_IncludedUseCase^^xsd:string</para>
    ///   <para>rdfs:comment : The UseCaseUsages that are included by this UseCaseDefinition, which are the useCaseIncludeds of the IncludeUseCaseUsages owned by this UseCaseDefinition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#useCaseDefinition_IncludedUseCase">oslc_sysmlv2:useCaseDefinition_IncludedUseCase</a>
    /// </summary>
    let useCaseDefinition_IncludedUseCase = _prefixId.prefix "useCaseDefinition_IncludedUseCase"

    /// <summary>
    ///   <para>rdfs:label : useCaseUsage_IncludedUseCase^^xsd:string</para>
    ///   <para>rdfs:comment : The UseCaseUsages that are included by this UseCaseUse, which are the useCaseIncludeds of the IncludeUseCaseUsages owned by this UseCaseUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#useCaseUsage_IncludedUseCase">oslc_sysmlv2:useCaseUsage_IncludedUseCase</a>
    /// </summary>
    let useCaseUsage_IncludedUseCase = _prefixId.prefix "useCaseUsage_IncludedUseCase"

    /// <summary>
    ///   <para>rdfs:label : useCaseUsage_UseCaseDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : The UseCaseDefinition that is the definition of this UseCaseUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#useCaseUsage_UseCaseDefinition">oslc_sysmlv2:useCaseUsage_UseCaseDefinition</a>
    /// </summary>
    let useCaseUsage_UseCaseDefinition = _prefixId.prefix "useCaseUsage_UseCaseDefinition"

    /// <summary>
    ///   <para>rdfs:label : variantMembership_OwnedVariantUsage^^xsd:string</para>
    ///   <para>rdfs:comment : The Usage that represents a variant in the context of the owningVariationDefinition or owningVariationUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#variantMembership_OwnedVariantUsage">oslc_sysmlv2:variantMembership_OwnedVariantUsage</a>
    /// </summary>
    let variantMembership_OwnedVariantUsage = _prefixId.prefix "variantMembership_OwnedVariantUsage"

    /// <summary>
    ///   <para>rdfs:label : verificationCaseDefinition_VerifiedRequirement^^xsd:string</para>
    ///   <para>rdfs:comment : The RequirementUsages verified by this VerificationCaseDefinition, which are the verifiedRequirements of all RequirementVerificationMemberships of the objectiveRequirement.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#verificationCaseDefinition_VerifiedRequirement">oslc_sysmlv2:verificationCaseDefinition_VerifiedRequirement</a>
    /// </summary>
    let verificationCaseDefinition_VerifiedRequirement = _prefixId.prefix "verificationCaseDefinition_VerifiedRequirement"

    /// <summary>
    ///   <para>rdfs:label : verificationCaseUsage_VerificationCaseDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : The VerificationCase that is the definition of this VerificationCaseUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#verificationCaseUsage_VerificationCaseDefinition">oslc_sysmlv2:verificationCaseUsage_VerificationCaseDefinition</a>
    /// </summary>
    let verificationCaseUsage_VerificationCaseDefinition = _prefixId.prefix "verificationCaseUsage_VerificationCaseDefinition"

    /// <summary>
    ///   <para>rdfs:label : verificationCaseUsage_VerifiedRequirement^^xsd:string</para>
    ///   <para>rdfs:comment : The RequirementUsages verified by this VerificationCaseUsage, which are the verifiedRequirements of all RequirementVerificationMemberships of the objectiveRequirement.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#verificationCaseUsage_VerifiedRequirement">oslc_sysmlv2:verificationCaseUsage_VerifiedRequirement</a>
    /// </summary>
    let verificationCaseUsage_VerifiedRequirement = _prefixId.prefix "verificationCaseUsage_VerifiedRequirement"

    /// <summary>
    ///   <para>rdfs:label : viewDefinition_SatisfiedViewpoint^^xsd:string</para>
    ///   <para>rdfs:comment : The composite ownedRequirements of this ViewDefinition that are ViewpointUsages for viewpoints satisfied by the ViewDefinition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#viewDefinition_SatisfiedViewpoint">oslc_sysmlv2:viewDefinition_SatisfiedViewpoint</a>
    /// </summary>
    let viewDefinition_SatisfiedViewpoint = _prefixId.prefix "viewDefinition_SatisfiedViewpoint"

    /// <summary>
    ///   <para>rdfs:label : viewDefinition_View^^xsd:string</para>
    ///   <para>rdfs:comment : The usages of this ViewDefinition that are ViewUsages.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#viewDefinition_View">oslc_sysmlv2:viewDefinition_View</a>
    /// </summary>
    let viewDefinition_View = _prefixId.prefix "viewDefinition_View"
    /// <summary>
    ///   <para>rdfs:label : viewDefinition_ViewCondition^^xsd:string</para>
    ///   <para>rdfs:comment : The Expressions related to this ViewDefinition by ElementFilterMemberships, which specify conditions on Elements to be rendered in a view.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#viewDefinition_ViewCondition">oslc_sysmlv2:viewDefinition_ViewCondition</a>
    /// </summary>
    let viewDefinition_ViewCondition = _prefixId.prefix "viewDefinition_ViewCondition"
    /// <summary>
    ///   <para>rdfs:label : viewDefinition_ViewRendering^^xsd:string</para>
    ///   <para>rdfs:comment : The RenderingUsage to be used to render views defined by this ViewDefinition, which is the referencedRendering of the ViewRenderingMembership of the ViewDefinition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#viewDefinition_ViewRendering">oslc_sysmlv2:viewDefinition_ViewRendering</a>
    /// </summary>
    let viewDefinition_ViewRendering = _prefixId.prefix "viewDefinition_ViewRendering"

    /// <summary>
    ///   <para>rdfs:label : viewRenderingMembership_OwnedRendering^^xsd:string</para>
    ///   <para>rdfs:comment : The owned RenderingUsage that is either itself the referencedRendering or subsets the referencedRendering.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#viewRenderingMembership_OwnedRendering">oslc_sysmlv2:viewRenderingMembership_OwnedRendering</a>
    /// </summary>
    let viewRenderingMembership_OwnedRendering = _prefixId.prefix "viewRenderingMembership_OwnedRendering"

    /// <summary>
    ///   <para>rdfs:label : viewRenderingMembership_ReferencedRendering^^xsd:string</para>
    ///   <para>rdfs:comment :  The RenderingUsage that is referenced through this ViewRenderingMembership. It is the referencedFeature of the ownedReferenceSubsetting for the ownedRendering, if there is one, and, otherwise, the ownedRendering itself.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#viewRenderingMembership_ReferencedRendering">oslc_sysmlv2:viewRenderingMembership_ReferencedRendering</a>
    /// </summary>
    let viewRenderingMembership_ReferencedRendering = _prefixId.prefix "viewRenderingMembership_ReferencedRendering"

    /// <summary>
    ///   <para>rdfs:label : viewUsage_ExposedElement^^xsd:string</para>
    ///   <para>rdfs:comment : The Elements that are exposed by this ViewUsage, which are those memberElements of the imported Memberships from all the Expose Relationships that meet all the owned and inherited viewConditions.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#viewUsage_ExposedElement">oslc_sysmlv2:viewUsage_ExposedElement</a>
    /// </summary>
    let viewUsage_ExposedElement = _prefixId.prefix "viewUsage_ExposedElement"
    /// <summary>
    ///   <para>rdfs:label : viewUsage_SatisfiedViewpoint^^xsd:string</para>
    ///   <para>rdfs:comment : The nestedRequirements of this ViewUsage that are ViewpointUsages for (additional) viewpoints satisfied by the ViewUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#viewUsage_SatisfiedViewpoint">oslc_sysmlv2:viewUsage_SatisfiedViewpoint</a>
    /// </summary>
    let viewUsage_SatisfiedViewpoint = _prefixId.prefix "viewUsage_SatisfiedViewpoint"
    /// <summary>
    ///   <para>rdfs:label : viewUsage_ViewCondition^^xsd:string</para>
    ///   <para>rdfs:comment : The Expressions related to this ViewUsage by ElementFilterMemberships, which specify conditions on Elements to be rendered in a view.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#viewUsage_ViewCondition">oslc_sysmlv2:viewUsage_ViewCondition</a>
    /// </summary>
    let viewUsage_ViewCondition = _prefixId.prefix "viewUsage_ViewCondition"
    /// <summary>
    ///   <para>rdfs:label : viewUsage_ViewDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : The ViewDefinition that is the definition of this ViewUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#viewUsage_ViewDefinition">oslc_sysmlv2:viewUsage_ViewDefinition</a>
    /// </summary>
    let viewUsage_ViewDefinition = _prefixId.prefix "viewUsage_ViewDefinition"
    /// <summary>
    ///   <para>rdfs:label : viewUsage_ViewRendering^^xsd:string</para>
    ///   <para>rdfs:comment : The RenderingUsage to be used to render views defined by this ViewUsage, which is the referencedRendering of the ViewRenderingMembership of the ViewUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#viewUsage_ViewRendering">oslc_sysmlv2:viewUsage_ViewRendering</a>
    /// </summary>
    let viewUsage_ViewRendering = _prefixId.prefix "viewUsage_ViewRendering"

    /// <summary>
    ///   <para>rdfs:label : viewpointDefinition_ViewpointStakeholder^^xsd:string</para>
    ///   <para>rdfs:comment : The PartUsages that identify the stakeholders with concerns framed by this ViewpointDefinition, which are the owned and inherited stakeholderParameters of the framedConcerns of this ViewpointDefinition.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#viewpointDefinition_ViewpointStakeholder">oslc_sysmlv2:viewpointDefinition_ViewpointStakeholder</a>
    /// </summary>
    let viewpointDefinition_ViewpointStakeholder = _prefixId.prefix "viewpointDefinition_ViewpointStakeholder"

    /// <summary>
    ///   <para>rdfs:label : viewpointUsage_ViewpointDefinition^^xsd:string</para>
    ///   <para>rdfs:comment : The ViewpointDefinition that is the definition of this ViewpointUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#viewpointUsage_ViewpointDefinition">oslc_sysmlv2:viewpointUsage_ViewpointDefinition</a>
    /// </summary>
    let viewpointUsage_ViewpointDefinition = _prefixId.prefix "viewpointUsage_ViewpointDefinition"

    /// <summary>
    ///   <para>rdfs:label : viewpointUsage_ViewpointStakeholder^^xsd:string</para>
    ///   <para>rdfs:comment : The PartUsages that identify the stakeholders with concerns framed by this ViewpointUsage, which are the owned and inherited stakeholderParameters of the framedConcerns of this ViewpointUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#viewpointUsage_ViewpointStakeholder">oslc_sysmlv2:viewpointUsage_ViewpointStakeholder</a>
    /// </summary>
    let viewpointUsage_ViewpointStakeholder = _prefixId.prefix "viewpointUsage_ViewpointStakeholder"

    let visibilityKind_Private = _prefixId.prefix "visibilityKind_Private"
    let visibilityKind_Protected = _prefixId.prefix "visibilityKind_Protected"
    let visibilityKind_Public = _prefixId.prefix "visibilityKind_Public"

    /// <summary>
    ///   <para>rdfs:label : whileLoopActionUsage_UntilArgument^^xsd:string</para>
    ///   <para>rdfs:comment : The Expression whose result, if false, determines that the bodyAction should continue to be performed. It is the (optional) third owned parameter of the WhileLoopActionUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#whileLoopActionUsage_UntilArgument">oslc_sysmlv2:whileLoopActionUsage_UntilArgument</a>
    /// </summary>
    let whileLoopActionUsage_UntilArgument = _prefixId.prefix "whileLoopActionUsage_UntilArgument"

    /// <summary>
    ///   <para>rdfs:label : whileLoopActionUsage_WhileArgument^^xsd:string</para>
    ///   <para>rdfs:comment : The Expression whose result, if true, determines that the bodyAction should continue to be performed. It is the first owned parameter of the WhileLoopActionUsage.^^xsd:string</para>
    ///   <a href="http://open-services.net/ns/sysmlv2#whileLoopActionUsage_WhileArgument">oslc_sysmlv2:whileLoopActionUsage_WhileArgument</a>
    /// </summary>
    let whileLoopActionUsage_WhileArgument = _prefixId.prefix "whileLoopActionUsage_WhileArgument"
