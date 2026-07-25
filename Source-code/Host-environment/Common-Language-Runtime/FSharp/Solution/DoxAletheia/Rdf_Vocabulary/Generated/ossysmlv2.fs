namespace http.open_services.net.ns.sysmlv2.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ossysmlv2 =
    let _namespace_iri = Namespace_Iri ossysmlv2 |> NamespaceIRI
    /// <summary>
    ///   <para>ossysmlv2:element_Owner</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The owner of this Element, derived as the owningRelatedElement of the owningRelationship of this Element, if any.</para>
    /// labels<para>element_Owner</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#element_Owner">http://open-services.net/ns/sysmlv2#element_Owner</seealso>
    let element_Owner = Prefixed_Name(ossysmlv2, "element_Owner") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:stateDefinition_EntryAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ActionUsage of this StateDefinition to be performed on entry to the state defined by the StateDefinition. It is the owned ActionUsage related to the StateDefinition by a StateSubactionMembership  with kind = entry.</para>
    /// labels<para>stateDefinition_EntryAction</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#stateDefinition_EntryAction">http://open-services.net/ns/sysmlv2#stateDefinition_EntryAction</seealso>
    let stateDefinition_EntryAction =
        Prefixed_Name(ossysmlv2, "stateDefinition_EntryAction") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:stateDefinition_IsParallel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether the ownedStates of this StateDefinition are to all be performed in parallel. If true, none of the ownedActions (which includes ownedStates) may have any incoming or outgoing Transitions. If false, only one ownedState may be performed at a time.</para>
    /// labels<para>stateDefinition_IsParallel</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#stateDefinition_IsParallel">http://open-services.net/ns/sysmlv2#stateDefinition_IsParallel</seealso>
    let stateDefinition_IsParallel =
        Prefixed_Name(ossysmlv2, "stateDefinition_IsParallel") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:stateDefinition_State</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The StateUsages, which are actions in the StateDefinition, that specify the discrete states in the behavior defined by the StateDefinition.</para>
    /// labels<para>stateDefinition_State</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#stateDefinition_State">http://open-services.net/ns/sysmlv2#stateDefinition_State</seealso>
    let stateDefinition_State =
        Prefixed_Name(ossysmlv2, "stateDefinition_State") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:CollectExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A CollectExpression is an OperatorExpression whose operator is "collect", which resolves to the Function ControlFunctions::collect from the Kernel Functions Library.</para>
    /// labels<para>CollectExpression</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#CollectExpression">http://open-services.net/ns/sysmlv2#CollectExpression</seealso>
    let CollectExpression =
        Prefixed_Name(ossysmlv2, "CollectExpression") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:ConcernDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A ConcernDefinition is a RequirementDefinition that one or more stakeholders may be interested in having addressed. These stakeholders are identified by the ownedStakeholdersof the ConcernDefinition.</para>
    /// labels<para>ConcernDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#ConcernDefinition">http://open-services.net/ns/sysmlv2#ConcernDefinition</seealso>
    let ConcernDefinition =
        Prefixed_Name(ossysmlv2, "ConcernDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:ConjugatedPortDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A ConjugatedPortDefinition is a PortDefinition that is a PortDefinition of its original PortDefinition. That is, a ConjugatedPortDefinition inherits all the features of the original PortDefinition, but input flows of the original PortDefinition become outputs on the ConjugatedPortDefinition and output flows of the original PortDefinition become inputs on the ConjugatedPortDefinition. Every PortDefinition (that is not itself a ConjugatedPortDefinition) has exactly one corresponding ConjugatedPortDefinition, whose effective name is the name of the originalPortDefinition, with the character ~ prepended.</para>
    /// labels<para>ConjugatedPortDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#ConjugatedPortDefinition">http://open-services.net/ns/sysmlv2#ConjugatedPortDefinition</seealso>
    let ConjugatedPortDefinition =
        Prefixed_Name(ossysmlv2, "ConjugatedPortDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:FeatureTyping</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>FeatureTyping is Specialization in which the specific Type is a Feature. This means the set of instances of the (specific) typedFeature is a subset of the set of instances of the (general) type. In the simplest case, the type is a Classifier, whereupon the typedFeature has values that are instances of the Classifier.</para>
    /// labels<para>FeatureTyping</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#FeatureTyping">http://open-services.net/ns/sysmlv2#FeatureTyping</seealso>
    let FeatureTyping = Prefixed_Name(ossysmlv2, "FeatureTyping") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:VisibilityKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>VisibilityKind is an enumeration whose literals specify the visibility of a Membership of an Element in a Namespace outside of that Namespace. Note that "visibility" specifically restricts whether an Element in a Namespace may be referenced by name from outside the Namespace and only otherwise restricts access to an Element as provided by specific constraints in the abstract syntax (e.g., preventing the import or inheritance of private Elements).</para>
    /// labels<para>VisibilityKind</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#VisibilityKind">http://open-services.net/ns/sysmlv2#VisibilityKind</seealso>
    let VisibilityKind = Prefixed_Name(ossysmlv2, "VisibilityKind") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:actionUsage_ActionDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Behaviors that are the types of this ActionUsage. Nominally, these would be ActionDefinitions, but other kinds of Kernel Behaviors are also allowed, to permit use of Behaviors from the Kernel Model Libraries.</para>
    /// labels<para>actionUsage_ActionDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#actionUsage_ActionDefinition">http://open-services.net/ns/sysmlv2#actionUsage_ActionDefinition</seealso>
    let actionUsage_ActionDefinition =
        Prefixed_Name(ossysmlv2, "actionUsage_ActionDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:actorMembership_OwnedActorParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The PartUsage specifying the actor.</para>
    /// labels<para>actorMembership_OwnedActorParameter</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#actorMembership_OwnedActorParameter">http://open-services.net/ns/sysmlv2#actorMembership_OwnedActorParameter</seealso>
    let actorMembership_OwnedActorParameter =
        Prefixed_Name(ossysmlv2, "actorMembership_OwnedActorParameter") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:triggerInvocationExpression_Kind</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates which of the Functions from the Triggers model in the Kernel Semantic Library is to be invoked by this TriggerInvocationExpression.</para>
    /// labels<para>triggerInvocationExpression_Kind</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#triggerInvocationExpression_Kind">http://open-services.net/ns/sysmlv2#triggerInvocationExpression_Kind</seealso>
    let triggerInvocationExpression_Kind =
        Prefixed_Name(ossysmlv2, "triggerInvocationExpression_Kind") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:ActionDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An ActionDefinition is a Definition that is also a Behavior that defines an Action performed by a system or part of a system.</para>
    /// labels<para>ActionDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#ActionDefinition">http://open-services.net/ns/sysmlv2#ActionDefinition</seealso>
    let ActionDefinition = Prefixed_Name(ossysmlv2, "ActionDefinition") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:Behavior</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Behavior coordinates occurrences of other Behaviors, as well as changes in objects. Behaviors can be decomposed into Steps and be characterized by parameters.</para>
    /// labels<para>Behavior</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Behavior">http://open-services.net/ns/sysmlv2#Behavior</seealso>
    let Behavior = Prefixed_Name(ossysmlv2, "Behavior") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:OccurrenceUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An OccurrenceUsage is a Usage whose types are all Classes. Nominally, if a type is an OccurrenceDefinition, an OccurrenceUsage is a Usage of that OccurrenceDefinition within a system. However, other types of Kernel Classes are also allowed, to permit use of Classes from the Kernel Model Libraries.</para>
    /// labels<para>OccurrenceUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#OccurrenceUsage">http://open-services.net/ns/sysmlv2#OccurrenceUsage</seealso>
    let OccurrenceUsage = Prefixed_Name(ossysmlv2, "OccurrenceUsage") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:UseCaseDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A UseCaseDefinition is a CaseDefinition that specifies a set of actions performed by its subject, in interaction with one or more actors external to the subject. The objective is to yield an observable result that is of value to one or more of the actors.</para>
    /// labels<para>UseCaseDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#UseCaseDefinition">http://open-services.net/ns/sysmlv2#UseCaseDefinition</seealso>
    let UseCaseDefinition =
        Prefixed_Name(ossysmlv2, "UseCaseDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:VerificationCaseUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A VerificationCaseUsage is a Usage of a VerificationCaseDefinition.</para>
    /// labels<para>VerificationCaseUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#VerificationCaseUsage">http://open-services.net/ns/sysmlv2#VerificationCaseUsage</seealso>
    let VerificationCaseUsage =
        Prefixed_Name(ossysmlv2, "VerificationCaseUsage") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:ifActionUsage_ThenAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ActionUsage that is to be performed if the result of the ifArgument is true. It is the second parameter of the IfActionUsage.</para>
    /// labels<para>ifActionUsage_ThenAction</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#ifActionUsage_ThenAction">http://open-services.net/ns/sysmlv2#ifActionUsage_ThenAction</seealso>
    let ifActionUsage_ThenAction =
        Prefixed_Name(ossysmlv2, "ifActionUsage_ThenAction") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:import_IsRecursive</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether to recursively import Memberships from visible, owned sub-Namespaces.</para>
    /// labels<para>import_IsRecursive</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#import_IsRecursive">http://open-services.net/ns/sysmlv2#import_IsRecursive</seealso>
    let import_IsRecursive =
        Prefixed_Name(ossysmlv2, "import_IsRecursive") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:transitionUsage_TriggerAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The AcceptActionUsages that define the triggers of this TransitionUsage, which are the ownedFeatures of the TransitionUsage related to it by TransitionFeatureMemberships with kind = trigger, which must all be AcceptActionUsages.</para>
    /// labels<para>transitionUsage_TriggerAction</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#transitionUsage_TriggerAction">http://open-services.net/ns/sysmlv2#transitionUsage_TriggerAction</seealso>
    let transitionUsage_TriggerAction =
        Prefixed_Name(ossysmlv2, "transitionUsage_TriggerAction") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:AcceptActionUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An AcceptActionUsage is an ActionUsage that specifies the acceptance of an incomingTransfer from the Occurrence given by the result of its receiverArgument Expression. (If no receiverArgument is provided, the default is the this context of the AcceptActionUsage.) The payload of the accepted Transfer is output on its payloadParameter. Which Transfers may be accepted is determined by conformance to the typing and (potentially) binding of the payloadParameter.</para>
    /// labels<para>AcceptActionUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#AcceptActionUsage">http://open-services.net/ns/sysmlv2#AcceptActionUsage</seealso>
    let AcceptActionUsage =
        Prefixed_Name(ossysmlv2, "AcceptActionUsage") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:RequirementDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A RequirementDefinition is a ConstraintDefinition that defines a requirement used in the context of a specification as a constraint that a valid solution must satisfy. The specification is relative to a specified subject, possibly in collaboration with one or more external actors.</para>
    /// labels<para>RequirementDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#RequirementDefinition">http://open-services.net/ns/sysmlv2#RequirementDefinition</seealso>
    let RequirementDefinition =
        Prefixed_Name(ossysmlv2, "RequirementDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:RequirementUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A RequirementUsage is a Usage of a RequirementDefinition.</para>
    /// labels<para>RequirementUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#RequirementUsage">http://open-services.net/ns/sysmlv2#RequirementUsage</seealso>
    let RequirementUsage = Prefixed_Name(ossysmlv2, "RequirementUsage") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:Conjugation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Conjugation is a Relationship between two types in which the conjugatedType inherits all the Features of the originalType, but with all input and output Features reversed. That is, any Features with a direction in relative to the originalType are considered to have an effective direction of out relative to the conjugatedType and, similarly, Features with direction out in the originalType are considered to have an effective direction of in in the conjugatedType. Features with direction inout, or with no direction, in the originalType, are inherited without change.</para>
    /// labels<para>Conjugation</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Conjugation">http://open-services.net/ns/sysmlv2#Conjugation</seealso>
    let Conjugation = Prefixed_Name(ossysmlv2, "Conjugation") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:interfaceUsage_InterfaceDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The InterfaceDefinitions that type this InterfaceUsage.</para>
    /// labels<para>interfaceUsage_InterfaceDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#interfaceUsage_InterfaceDefinition">http://open-services.net/ns/sysmlv2#interfaceUsage_InterfaceDefinition</seealso>
    let interfaceUsage_InterfaceDefinition =
        Prefixed_Name(ossysmlv2, "interfaceUsage_InterfaceDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:itemFlow_Interaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Interactions that type this ItemFlow. Interactions are both Associations and Behaviors, which can type Connectors and Steps, respectively.</para>
    /// labels<para>itemFlow_Interaction</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#itemFlow_Interaction">http://open-services.net/ns/sysmlv2#itemFlow_Interaction</seealso>
    let itemFlow_Interaction =
        Prefixed_Name(ossysmlv2, "itemFlow_Interaction") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:itemFlow_ItemFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ownedFeature of the ItemFlow that is an ItemFeature (if any).</para>
    /// labels<para>itemFlow_ItemFeature</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#itemFlow_ItemFeature">http://open-services.net/ns/sysmlv2#itemFlow_ItemFeature</seealso>
    let itemFlow_ItemFeature =
        Prefixed_Name(ossysmlv2, "itemFlow_ItemFeature") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:itemFlow_ItemFlowEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The connectorEnds of this ItemFlow that are ItemFlowEnds.</para>
    /// labels<para>itemFlow_ItemFlowEnd</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#itemFlow_ItemFlowEnd">http://open-services.net/ns/sysmlv2#itemFlow_ItemFlowEnd</seealso>
    let itemFlow_ItemFlowEnd =
        Prefixed_Name(ossysmlv2, "itemFlow_ItemFlowEnd") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:type_OwnedFeatureMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ownedMemberships of this Type that are FeatureMemberships, for which the Type is the owningType. Each such FeatureMembership identifies an ownedFeature of the Type.</para>
    /// labels<para>type_OwnedFeatureMembership</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#type_OwnedFeatureMembership">http://open-services.net/ns/sysmlv2#type_OwnedFeatureMembership</seealso>
    let type_OwnedFeatureMembership =
        Prefixed_Name(ossysmlv2, "type_OwnedFeatureMembership") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:type_OwnedSpecialization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ownedRelationships of this Type that are Specializations, for which the Type is the specific Type.</para>
    /// labels<para>type_OwnedSpecialization</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#type_OwnedSpecialization">http://open-services.net/ns/sysmlv2#type_OwnedSpecialization</seealso>
    let type_OwnedSpecialization =
        Prefixed_Name(ossysmlv2, "type_OwnedSpecialization") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:type_OwnedUnioning</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ownedRelationships of this Type that are Unionings, having the Type as their typeUnioned.</para>
    /// labels<para>type_OwnedUnioning</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#type_OwnedUnioning">http://open-services.net/ns/sysmlv2#type_OwnedUnioning</seealso>
    let type_OwnedUnioning =
        Prefixed_Name(ossysmlv2, "type_OwnedUnioning") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:OccurrenceDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An OccurrenceDefinition is a Definition of a Class of individuals that have an independent life over time and potentially an extent over space. This includes both structural things and behaviors that act on such structures.</para>
    /// labels<para>OccurrenceDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#OccurrenceDefinition">http://open-services.net/ns/sysmlv2#OccurrenceDefinition</seealso>
    let OccurrenceDefinition =
        Prefixed_Name(ossysmlv2, "OccurrenceDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:assignmentActionUsage_TargetArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Expression whose value is an occurrence in the domain of the referent Feature, for which the value of the referent will be set to the result of the valueExpression by this AssignmentActionUsage.</para>
    /// labels<para>assignmentActionUsage_TargetArgument</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#assignmentActionUsage_TargetArgument">http://open-services.net/ns/sysmlv2#assignmentActionUsage_TargetArgument</seealso>
    let assignmentActionUsage_TargetArgument =
        Prefixed_Name(ossysmlv2, "assignmentActionUsage_TargetArgument") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:metadataAccessExpression_ReferencedElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para> The Element whose metadata is being accessed.</para>
    /// labels<para>metadataAccessExpression_ReferencedElement</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#metadataAccessExpression_ReferencedElement">http://open-services.net/ns/sysmlv2#metadataAccessExpression_ReferencedElement</seealso>
    let metadataAccessExpression_ReferencedElement =
        Prefixed_Name(ossysmlv2, "metadataAccessExpression_ReferencedElement") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:usage_NestedRendering</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The RenderingUsages that are nestedUsages of this Usage.</para>
    /// labels<para>usage_NestedRendering</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#usage_NestedRendering">http://open-services.net/ns/sysmlv2#usage_NestedRendering</seealso>
    let usage_NestedRendering =
        Prefixed_Name(ossysmlv2, "usage_NestedRendering") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:ActionUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An ActionUsage is a Usage that is also a Step, and, so, is typed by a Behavior. Nominally, if the type is an ActionDefinition, an ActionUsage is a Usage of that ActionDefinition within a system. However, other kinds of kernel Behaviors are also allowed, to permit use of Behaviors from the Kernel Model Libraries.</para>
    /// labels<para>ActionUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#ActionUsage">http://open-services.net/ns/sysmlv2#ActionUsage</seealso>
    let ActionUsage = Prefixed_Name(ossysmlv2, "ActionUsage") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:Step</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Step is a Feature that is typed by one or more Behaviors. Steps may be used by one Behavior to coordinate the performance of other Behaviors, supporting a steady refinement of behavioral descriptions. Steps can be ordered in time and can be connected using ItemFlows to specify things flowing between their parameters.</para>
    /// labels<para>Step</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Step">http://open-services.net/ns/sysmlv2#Step</seealso>
    let Step = Prefixed_Name(ossysmlv2, "Step") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:ParameterMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A ParameterMembership is a FeatureMembership that identifies its memberFeature as a parameter, which is always owned, and must have a direction. A ParameterMembership must be owned by a Behavior or a Step.</para>
    /// labels<para>ParameterMembership</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#ParameterMembership">http://open-services.net/ns/sysmlv2#ParameterMembership</seealso>
    let ParameterMembership =
        Prefixed_Name(ossysmlv2, "ParameterMembership") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:AllocationUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An AllocationUsage is a usage of an AllocationDefinition asserting the allocation of the source feature to the target feature.</para>
    /// labels<para>AllocationUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#AllocationUsage">http://open-services.net/ns/sysmlv2#AllocationUsage</seealso>
    let AllocationUsage = Prefixed_Name(ossysmlv2, "AllocationUsage") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:comment_Locale</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Identification of the language of the body text and, optionally, the region and/or encoding. The format shall be a POSIX locale conformant to ISO/IEC 15897, with the format [language[_territory][.codeset][@modifier]].</para>
    /// labels<para>comment_Locale</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#comment_Locale">http://open-services.net/ns/sysmlv2#comment_Locale</seealso>
    let comment_Locale = Prefixed_Name(ossysmlv2, "comment_Locale") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:occurrenceUsage_IsIndividual</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether this OccurrenceUsage represents the usage of the specific individual (or portion of it) represented by its individualDefinition.</para>
    /// labels<para>occurrenceUsage_IsIndividual</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#occurrenceUsage_IsIndividual">http://open-services.net/ns/sysmlv2#occurrenceUsage_IsIndividual</seealso>
    let occurrenceUsage_IsIndividual =
        Prefixed_Name(ossysmlv2, "occurrenceUsage_IsIndividual") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:useCaseUsage_IncludedUseCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The UseCaseUsages that are included by this UseCaseUse, which are the useCaseIncludeds of the IncludeUseCaseUsages owned by this UseCaseUsage.</para>
    /// labels<para>useCaseUsage_IncludedUseCase</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#useCaseUsage_IncludedUseCase">http://open-services.net/ns/sysmlv2#useCaseUsage_IncludedUseCase</seealso>
    let useCaseUsage_IncludedUseCase =
        Prefixed_Name(ossysmlv2, "useCaseUsage_IncludedUseCase") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:viewDefinition_SatisfiedViewpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The composite ownedRequirements of this ViewDefinition that are ViewpointUsages for viewpoints satisfied by the ViewDefinition.</para>
    /// labels<para>viewDefinition_SatisfiedViewpoint</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#viewDefinition_SatisfiedViewpoint">http://open-services.net/ns/sysmlv2#viewDefinition_SatisfiedViewpoint</seealso>
    let viewDefinition_SatisfiedViewpoint =
        Prefixed_Name(ossysmlv2, "viewDefinition_SatisfiedViewpoint") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:viewDefinition_ViewCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Expressions related to this ViewDefinition by ElementFilterMemberships, which specify conditions on Elements to be rendered in a view.</para>
    /// labels<para>viewDefinition_ViewCondition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#viewDefinition_ViewCondition">http://open-services.net/ns/sysmlv2#viewDefinition_ViewCondition</seealso>
    let viewDefinition_ViewCondition =
        Prefixed_Name(ossysmlv2, "viewDefinition_ViewCondition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:viewUsage_ViewCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Expressions related to this ViewUsage by ElementFilterMemberships, which specify conditions on Elements to be rendered in a view.</para>
    /// labels<para>viewUsage_ViewCondition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#viewUsage_ViewCondition">http://open-services.net/ns/sysmlv2#viewUsage_ViewCondition</seealso>
    let viewUsage_ViewCondition =
        Prefixed_Name(ossysmlv2, "viewUsage_ViewCondition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:ActorMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An ActorMembership is a ParameterMembership that identifies a PartUsage as an actor parameter, which specifies a role played by an external entity in interaction with the owningType of the ActorMembership.</para>
    /// labels<para>ActorMembership</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#ActorMembership">http://open-services.net/ns/sysmlv2#ActorMembership</seealso>
    let ActorMembership = Prefixed_Name(ossysmlv2, "ActorMembership") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:ConnectionDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A ConnectionDefinition is a PartDefinition that is also an AssociationStructure. The end Features of a ConnectionDefinition must be Usages.</para>
    /// labels<para>ConnectionDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#ConnectionDefinition">http://open-services.net/ns/sysmlv2#ConnectionDefinition</seealso>
    let ConnectionDefinition =
        Prefixed_Name(ossysmlv2, "ConnectionDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:ConnectionUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A ConnectionUsage is a ConnectorAsUsage that is also a PartUsage. Nominally, if its type is a ConnectionDefinition, then a ConnectionUsage is a Usage of that ConnectionDefinition, representing a connection between parts of a system. However, other kinds of kernel AssociationStructures are also allowed, to permit use of AssociationStructures from the Kernel Model Libraries.</para>
    /// labels<para>ConnectionUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#ConnectionUsage">http://open-services.net/ns/sysmlv2#ConnectionUsage</seealso>
    let ConnectionUsage = Prefixed_Name(ossysmlv2, "ConnectionUsage") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:FeatureReferenceExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A FeatureReferenceExpression is an Expression whose result is bound to a referent Feature.</para>
    /// labels<para>FeatureReferenceExpression</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#FeatureReferenceExpression">http://open-services.net/ns/sysmlv2#FeatureReferenceExpression</seealso>
    let FeatureReferenceExpression =
        Prefixed_Name(ossysmlv2, "FeatureReferenceExpression") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:FlowConnectionDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A FlowConnectionDefinition is a ConnectionDefinition and ActionDefinition that is also an Interaction representing flows between Usages.</para>
    /// labels<para>FlowConnectionDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#FlowConnectionDefinition">http://open-services.net/ns/sysmlv2#FlowConnectionDefinition</seealso>
    let FlowConnectionDefinition =
        Prefixed_Name(ossysmlv2, "FlowConnectionDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:ItemFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An ItemFlow is a Step that represents the transfer of objects or data values from one Feature to another. ItemFlows can take non-zero time to complete.</para>
    /// labels<para>ItemFlow</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#ItemFlow">http://open-services.net/ns/sysmlv2#ItemFlow</seealso>
    let ItemFlow = Prefixed_Name(ossysmlv2, "ItemFlow") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:ForkNode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A ForkNode is a ControlNode that must be followed by successor Actions as given by all its outgoing Successions.</para>
    /// labels<para>ForkNode</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#ForkNode">http://open-services.net/ns/sysmlv2#ForkNode</seealso>
    let ForkNode = Prefixed_Name(ossysmlv2, "ForkNode") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:FramedConcernMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A FramedConcernMembership is a RequirementConstraintMembership for a framed ConcernUsage of a RequirementDefinition or RequirementUsage.</para>
    /// labels<para>FramedConcernMembership</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#FramedConcernMembership">http://open-services.net/ns/sysmlv2#FramedConcernMembership</seealso>
    let FramedConcernMembership =
        Prefixed_Name(ossysmlv2, "FramedConcernMembership") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:IfActionUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An IfActionUsage is an ActionUsage that specifies that the thenAction ActionUsage should be performed if the result of the ifArgument Expression is true. It may also optionally specify an elseAction ActionUsage that is performed if the result of the ifArgument is false.</para>
    /// labels<para>IfActionUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#IfActionUsage">http://open-services.net/ns/sysmlv2#IfActionUsage</seealso>
    let IfActionUsage = Prefixed_Name(ossysmlv2, "IfActionUsage") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:Intersecting</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Intersecting is a Relationship that makes its intersectingType one of the intersectingTypes of its typeIntersected.</para>
    /// labels<para>Intersecting</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Intersecting">http://open-services.net/ns/sysmlv2#Intersecting</seealso>
    let Intersecting = Prefixed_Name(ossysmlv2, "Intersecting") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:InvocationExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An InvocationExpression is an Expression each of whose input parameters are bound to the result of an argument Expression.</para>
    /// labels<para>InvocationExpression</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#InvocationExpression">http://open-services.net/ns/sysmlv2#InvocationExpression</seealso>
    let InvocationExpression =
        Prefixed_Name(ossysmlv2, "InvocationExpression") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:ItemDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An ItemDefinition is an OccurrenceDefinition of the Structure of things that may themselves be systems or parts of systems, but may also be things that are acted on by a system or parts of a system, but which do not necessarily perform actions themselves. This includes items that can be exchanged between parts of a system, such as water or electrical signals.</para>
    /// labels<para>ItemDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#ItemDefinition">http://open-services.net/ns/sysmlv2#ItemDefinition</seealso>
    let ItemDefinition = Prefixed_Name(ossysmlv2, "ItemDefinition") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:ItemFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An ItemFeature is the ownedFeature of an ItemFlow that identifies the things carried by the kinds of transfers that are instances of the ItemFlow.</para>
    /// labels<para>ItemFeature</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#ItemFeature">http://open-services.net/ns/sysmlv2#ItemFeature</seealso>
    let ItemFeature = Prefixed_Name(ossysmlv2, "ItemFeature") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:ItemUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An ItemUsage is a ItemUsage whose definition is a Structure. Nominally, if the definition is an ItemDefinition, an ItemUsage is a ItemUsage of that ItemDefinition within a system. However, other kinds of Kernel Structures are also allowed, to permit use of Structures from the Kernel Model Libraries.</para>
    /// labels<para>ItemUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#ItemUsage">http://open-services.net/ns/sysmlv2#ItemUsage</seealso>
    let ItemUsage = Prefixed_Name(ossysmlv2, "ItemUsage") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:LibraryPackage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A LibraryPackage is a Package that is the container for a model library. A LibraryPackage is itself a library Element as are all Elements that are directly or indirectly contained in it.</para>
    /// labels<para>LibraryPackage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#LibraryPackage">http://open-services.net/ns/sysmlv2#LibraryPackage</seealso>
    let LibraryPackage = Prefixed_Name(ossysmlv2, "LibraryPackage") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:LiteralExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A LiteralExpression is an Expression that provides a basic DataValue as a result.</para>
    /// labels<para>LiteralExpression</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#LiteralExpression">http://open-services.net/ns/sysmlv2#LiteralExpression</seealso>
    let LiteralExpression =
        Prefixed_Name(ossysmlv2, "LiteralExpression") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:LiteralInteger</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A LiteralInteger is a LiteralExpression that provides an Integer value as a result. Its result parameter must have the type Integer.</para>
    /// labels<para>LiteralInteger</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#LiteralInteger">http://open-services.net/ns/sysmlv2#LiteralInteger</seealso>
    let LiteralInteger = Prefixed_Name(ossysmlv2, "LiteralInteger") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:LiteralString</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A LiteralString is a LiteralExpression that provides a String value as a result. Its result parameter must have the type String.</para>
    /// labels<para>LiteralString</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#LiteralString">http://open-services.net/ns/sysmlv2#LiteralString</seealso>
    let LiteralString = Prefixed_Name(ossysmlv2, "LiteralString") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:MembershipExpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A MembershipExpose is an Expose  that exposes a specific importedMembership and, if isRecursive = true, additional Memberships recursively.</para>
    /// labels<para>MembershipExpose</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#MembershipExpose">http://open-services.net/ns/sysmlv2#MembershipExpose</seealso>
    let MembershipExpose = Prefixed_Name(ossysmlv2, "MembershipExpose") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:MembershipImport</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A MembershipImport is an Import that imports its importedMembership into the importOwningNamespace. If isRecursive = true and the memberElement of the importedMembership is a Namespace, then the equivalent of a recursive NamespaceImport is also performed on that Namespace.</para>
    /// labels<para>MembershipImport</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#MembershipImport">http://open-services.net/ns/sysmlv2#MembershipImport</seealso>
    let MembershipImport = Prefixed_Name(ossysmlv2, "MembershipImport") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:MergeNode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A MergeNode is a ControlNode that asserts the merging of its incoming Successions. A MergeNode may have at most one outgoing Successions.</para>
    /// labels<para>MergeNode</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#MergeNode">http://open-services.net/ns/sysmlv2#MergeNode</seealso>
    let MergeNode = Prefixed_Name(ossysmlv2, "MergeNode") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:MetadataAccessExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A MetadataAccessExpression is an Expression whose result is a sequence of instances of Metaclasses representing all the MetadataFeature annotations of the referencedElement. In addition, the sequence includes an instance of the reflective Metaclass corresponding to the MOF class of the referencedElement, with values for all the abstract syntax properties of the referencedElement.</para>
    /// labels<para>MetadataAccessExpression</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#MetadataAccessExpression">http://open-services.net/ns/sysmlv2#MetadataAccessExpression</seealso>
    let MetadataAccessExpression =
        Prefixed_Name(ossysmlv2, "MetadataAccessExpression") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:MetadataDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A MetadataDefinition is an ItemDefinition that is also a Metaclass.</para>
    /// labels<para>MetadataDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#MetadataDefinition">http://open-services.net/ns/sysmlv2#MetadataDefinition</seealso>
    let MetadataDefinition =
        Prefixed_Name(ossysmlv2, "MetadataDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:MetadataFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A MetadataFeature is a Feature that is an AnnotatingElement used to annotate another Element with metadata. It is typed by a Metaclass. All its ownedFeatures must redefine features of its metaclass and any feature bindings must be model-level evaluable.</para>
    /// labels<para>MetadataFeature</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#MetadataFeature">http://open-services.net/ns/sysmlv2#MetadataFeature</seealso>
    let MetadataFeature = Prefixed_Name(ossysmlv2, "MetadataFeature") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:Multiplicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Multiplicity is a Feature whose co-domain is a set of natural numbers giving the allowed cardinalities of each typeWithMultiplicity. The cardinality of a Type is defined as follows, depending on whether the Type is a Classifier or Feature.
    /// .</para>
    /// labels<para>Multiplicity</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Multiplicity">http://open-services.net/ns/sysmlv2#Multiplicity</seealso>
    let Multiplicity = Prefixed_Name(ossysmlv2, "Multiplicity") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:MultiplicityRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A MultiplicityRange is a Multiplicity whose value is defined to be the (inclusive) range of natural numbers given by the result of a lowerBound Expression and the result of an upperBound Expression. The result of these Expressions shall be of type Natural. If the result of the upperBound Expression is the unbounded value *, then the specified range includes all natural numbers greater than or equal to the lowerBound value. If no lowerBound Expression, then the default is that the lower bound has the same value as the upper bound, except if the upperBound evaluates to *, in which case the default for the lower bound is 0.</para>
    /// labels<para>MultiplicityRange</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#MultiplicityRange">http://open-services.net/ns/sysmlv2#MultiplicityRange</seealso>
    let MultiplicityRange =
        Prefixed_Name(ossysmlv2, "MultiplicityRange") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:Namespace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Namespace is an Element that contains other Elements, known as its members, via Membership Relationships with those Elements. The members of a Namespace may be owned by the Namespace, aliased in the Namespace, or imported into the Namespace via Import Relationships.</para>
    /// labels<para>Namespace</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Namespace">http://open-services.net/ns/sysmlv2#Namespace</seealso>
    let Namespace = Prefixed_Name(ossysmlv2, "Namespace") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:NamespaceImport</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A NamespaceImport is an Import that imports Memberships from its importedNamespace into the importOwningNamespace. If  isRecursive = false, then only the visible Memberships of the importedNamespace are imported. If  isRecursive = true, then, in addition, Memberships are recursively imported from any ownedMembers of the importedNamespace that are Namespaces.</para>
    /// labels<para>NamespaceImport</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#NamespaceImport">http://open-services.net/ns/sysmlv2#NamespaceImport</seealso>
    let NamespaceImport = Prefixed_Name(ossysmlv2, "NamespaceImport") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:NullExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A NullExpression is an Expression that results in a null value.</para>
    /// labels<para>NullExpression</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#NullExpression">http://open-services.net/ns/sysmlv2#NullExpression</seealso>
    let NullExpression = Prefixed_Name(ossysmlv2, "NullExpression") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:definition_OwnedViewpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ViewpointUsages that are ownedUsages of this Definition.</para>
    /// labels<para>definition_OwnedViewpoint</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#definition_OwnedViewpoint">http://open-services.net/ns/sysmlv2#definition_OwnedViewpoint</seealso>
    let definition_OwnedViewpoint =
        Prefixed_Name(ossysmlv2, "definition_OwnedViewpoint") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:definition_Usage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Usages that are features of this Definition (not necessarily owned).</para>
    /// labels<para>definition_Usage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#definition_Usage">http://open-services.net/ns/sysmlv2#definition_Usage</seealso>
    let definition_Usage = Prefixed_Name(ossysmlv2, "definition_Usage") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:definition_Variant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Usages which represent the variants of this Definition as a variation point Definition, if isVariation = true. If isVariation = false, the there must be no variants.</para>
    /// labels<para>definition_Variant</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#definition_Variant">http://open-services.net/ns/sysmlv2#definition_Variant</seealso>
    let definition_Variant =
        Prefixed_Name(ossysmlv2, "definition_Variant") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:differencing_DifferencingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Type that partly determines interpretations of typeDifferenced, as described in Type::differencingType.</para>
    /// labels<para>differencing_DifferencingType</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#differencing_DifferencingType">http://open-services.net/ns/sysmlv2#differencing_DifferencingType</seealso>
    let differencing_DifferencingType =
        Prefixed_Name(ossysmlv2, "differencing_DifferencingType") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:differencing_TypeDifferenced</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Type with interpretations partly determined by differencingType, as described in Type::differencingType.</para>
    /// labels<para>differencing_TypeDifferenced</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#differencing_TypeDifferenced">http://open-services.net/ns/sysmlv2#differencing_TypeDifferenced</seealso>
    let differencing_TypeDifferenced =
        Prefixed_Name(ossysmlv2, "differencing_TypeDifferenced") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:disjoining_OwningType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A typeDisjoined that is also an owningRelatedElement.</para>
    /// labels<para>disjoining_OwningType</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#disjoining_OwningType">http://open-services.net/ns/sysmlv2#disjoining_OwningType</seealso>
    let disjoining_OwningType =
        Prefixed_Name(ossysmlv2, "disjoining_OwningType") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:disjoining_TypeDisjoined</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Type asserted to be disjoint with the disjoiningType.</para>
    /// labels<para>disjoining_TypeDisjoined</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#disjoining_TypeDisjoined">http://open-services.net/ns/sysmlv2#disjoining_TypeDisjoined</seealso>
    let disjoining_TypeDisjoined =
        Prefixed_Name(ossysmlv2, "disjoining_TypeDisjoined") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:documentation_DocumentedElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Element that is documented by this Documentation.</para>
    /// labels<para>documentation_DocumentedElement</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#documentation_DocumentedElement">http://open-services.net/ns/sysmlv2#documentation_DocumentedElement</seealso>
    let documentation_DocumentedElement =
        Prefixed_Name(ossysmlv2, "documentation_DocumentedElement") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:elementFilterMembership_Condition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The model-level evaluable Boolean-valued Expression used to filter the imported members of the membershipOwningNamespace of this ElementFilterMembership.</para>
    /// labels<para>elementFilterMembership_Condition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#elementFilterMembership_Condition">http://open-services.net/ns/sysmlv2#elementFilterMembership_Condition</seealso>
    let elementFilterMembership_Condition =
        Prefixed_Name(ossysmlv2, "elementFilterMembership_Condition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:element_AliasIds</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Various alternative identifiers for this Element. Generally, these will be set by tools.</para>
    /// labels<para>element_AliasIds</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#element_AliasIds">http://open-services.net/ns/sysmlv2#element_AliasIds</seealso>
    let element_AliasIds = Prefixed_Name(ossysmlv2, "element_AliasIds") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:element_DeclaredName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The declared name of this Element.</para>
    /// labels<para>element_DeclaredName</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#element_DeclaredName">http://open-services.net/ns/sysmlv2#element_DeclaredName</seealso>
    let element_DeclaredName =
        Prefixed_Name(ossysmlv2, "element_DeclaredName") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:element_IsImpliedIncluded</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether all necessary implied Relationships have been included in the ownedRelationships of this Element. This property may be true, even if there are not actually any ownedRelationships with isImplied = true, meaning that no such Relationships are actually implied for this Element. However, if it is false, then ownedRelationships may not contain any implied Relationships. That is, either all required implied Relationships must be included, or none of them.</para>
    /// labels<para>element_IsImpliedIncluded</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#element_IsImpliedIncluded">http://open-services.net/ns/sysmlv2#element_IsImpliedIncluded</seealso>
    let element_IsImpliedIncluded =
        Prefixed_Name(ossysmlv2, "element_IsImpliedIncluded") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:element_IsLibraryElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether this Element is contained in the ownership tree of a library model.</para>
    /// labels<para>element_IsLibraryElement</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#element_IsLibraryElement">http://open-services.net/ns/sysmlv2#element_IsLibraryElement</seealso>
    let element_IsLibraryElement =
        Prefixed_Name(ossysmlv2, "element_IsLibraryElement") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:element_Name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The name to be used for this Element during name resolution within its owningNamespace. This is derived using the effectiveName() operation. By default, it is the same as the declaredName, but this is overridden for certain kinds of Elements to compute a name even when the declaredName is null.</para>
    /// labels<para>element_Name</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#element_Name">http://open-services.net/ns/sysmlv2#element_Name</seealso>
    let element_Name = Prefixed_Name(ossysmlv2, "element_Name") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:element_OwnedAnnotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ownedRelationships of this Element that are Annotations, for which this Element is the annotatedElement.</para>
    /// labels<para>element_OwnedAnnotation</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#element_OwnedAnnotation">http://open-services.net/ns/sysmlv2#element_OwnedAnnotation</seealso>
    let element_OwnedAnnotation =
        Prefixed_Name(ossysmlv2, "element_OwnedAnnotation") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:element_OwnedElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Elements owned by this Element, derived as the ownedRelatedElements of the ownedRelationships of this Element.</para>
    /// labels<para>element_OwnedElement</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#element_OwnedElement">http://open-services.net/ns/sysmlv2#element_OwnedElement</seealso>
    let element_OwnedElement =
        Prefixed_Name(ossysmlv2, "element_OwnedElement") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:element_OwningMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The owningRelationship of this Element, if that Relationship is a Membership.</para>
    /// labels<para>element_OwningMembership</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#element_OwningMembership">http://open-services.net/ns/sysmlv2#element_OwningMembership</seealso>
    let element_OwningMembership =
        Prefixed_Name(ossysmlv2, "element_OwningMembership") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:element_OwningNamespace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Namespace that owns this Element, which is the membershipOwningNamespace of the owningMembership of this Element, if any.</para>
    /// labels<para>element_OwningNamespace</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#element_OwningNamespace">http://open-services.net/ns/sysmlv2#element_OwningNamespace</seealso>
    let element_OwningNamespace =
        Prefixed_Name(ossysmlv2, "element_OwningNamespace") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:element_OwningRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Relationship for which this Element is an ownedRelatedElement, if any.</para>
    /// labels<para>element_OwningRelationship</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#element_OwningRelationship">http://open-services.net/ns/sysmlv2#element_OwningRelationship</seealso>
    let element_OwningRelationship =
        Prefixed_Name(ossysmlv2, "element_OwningRelationship") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:element_QualifiedName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The full ownership-qualified name of this Element, represented in a form that is valid according to the KerML textual concrete syntax for qualified names (including use of unrestricted name notation and escaped characters, as necessary). The qualifiedName is null if this Element has no owningNamespace or if there is not a complete ownership chain of named Namespaces from a root Namespace to this Element.</para>
    /// labels<para>element_QualifiedName</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#element_QualifiedName">http://open-services.net/ns/sysmlv2#element_QualifiedName</seealso>
    let element_QualifiedName =
        Prefixed_Name(ossysmlv2, "element_QualifiedName") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:element_ShortName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The short name to be used for this Element during name resolution within its owningNamespace. This is derived using the effectiveShortName() operation. By default, it is the same as the declaredShortName, but this is overridden for certain kinds of Elements to compute a shortName even when the declaredName is null.</para>
    /// labels<para>element_ShortName</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#element_ShortName">http://open-services.net/ns/sysmlv2#element_ShortName</seealso>
    let element_ShortName =
        Prefixed_Name(ossysmlv2, "element_ShortName") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:enumerationDefinition_EnumeratedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>EnumerationUsages of this EnumerationDefinitionthat have distinct, fixed values. Each enumeratedValue specifies one of the allowed instances of the EnumerationDefinition.</para>
    /// labels<para>enumerationDefinition_EnumeratedValue</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#enumerationDefinition_EnumeratedValue">http://open-services.net/ns/sysmlv2#enumerationDefinition_EnumeratedValue</seealso>
    let enumerationDefinition_EnumeratedValue =
        Prefixed_Name(ossysmlv2, "enumerationDefinition_EnumeratedValue") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:enumerationUsage_EnumerationDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The single EnumerationDefinition that is the type of this EnumerationUsage.</para>
    /// labels<para>enumerationUsage_EnumerationDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#enumerationUsage_EnumerationDefinition">http://open-services.net/ns/sysmlv2#enumerationUsage_EnumerationDefinition</seealso>
    let enumerationUsage_EnumerationDefinition =
        Prefixed_Name(ossysmlv2, "enumerationUsage_EnumerationDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:eventOccurrenceUsage_EventOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The OccurrenceUsage referenced as an event by this EventOccurrenceUsage. It is the referenceFeature of the ownedReferenceSubsetting for the EventOccurrenceUsage, if there is one, and, otherwise, the EventOccurrenceUsage itself.</para>
    /// labels<para>eventOccurrenceUsage_EventOccurrence</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#eventOccurrenceUsage_EventOccurrence">http://open-services.net/ns/sysmlv2#eventOccurrenceUsage_EventOccurrence</seealso>
    let eventOccurrenceUsage_EventOccurrence =
        Prefixed_Name(ossysmlv2, "eventOccurrenceUsage_EventOccurrence") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:exhibitStateUsage_ExhibitedState</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The StateUsage to be exhibited by the ExhibitStateUsage. It is the performedAction of the ExhibitStateUsage considered as a PerformActionUsage, which must be a StateUsage.</para>
    /// labels<para>exhibitStateUsage_ExhibitedState</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#exhibitStateUsage_ExhibitedState">http://open-services.net/ns/sysmlv2#exhibitStateUsage_ExhibitedState</seealso>
    let exhibitStateUsage_ExhibitedState =
        Prefixed_Name(ossysmlv2, "exhibitStateUsage_ExhibitedState") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:expression_Function</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Function that types this Expression.</para>
    /// labels<para>expression_Function</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#expression_Function">http://open-services.net/ns/sysmlv2#expression_Function</seealso>
    let expression_Function =
        Prefixed_Name(ossysmlv2, "expression_Function") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:featureChaining_ChainingFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Feature whose values partly determine values of featureChained, as described in Feature::chainingFeature.</para>
    /// labels<para>featureChaining_ChainingFeature</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#featureChaining_ChainingFeature">http://open-services.net/ns/sysmlv2#featureChaining_ChainingFeature</seealso>
    let featureChaining_ChainingFeature =
        Prefixed_Name(ossysmlv2, "featureChaining_ChainingFeature") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:featureChaining_FeatureChained</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Feature whose values are partly determined by values of the chainingFeature, as described in Feature::chainingFeature.</para>
    /// labels<para>featureChaining_FeatureChained</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#featureChaining_FeatureChained">http://open-services.net/ns/sysmlv2#featureChaining_FeatureChained</seealso>
    let featureChaining_FeatureChained =
        Prefixed_Name(ossysmlv2, "featureChaining_FeatureChained") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:featureDirectionKind_In</para>
    /// </summary>
    /// <remarks>
    ///   <para>ossysmlv2:FeatureDirectionKind</para>
    ///   <para>Values of the Feature on each instance of its domain are determined externally to that instance and used internally.</para>
    /// labels<para>featureDirectionKind_In</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#featureDirectionKind_In">http://open-services.net/ns/sysmlv2#featureDirectionKind_In</seealso>
    let featureDirectionKind_In =
        Prefixed_Name(ossysmlv2, "featureDirectionKind_In") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:featureDirectionKind_Inout</para>
    /// </summary>
    /// <remarks>
    ///   <para>ossysmlv2:FeatureDirectionKind</para>
    ///   <para>Values of the Feature on each instance are determined either as in or out directions, or both.</para>
    /// labels<para>featureDirectionKind_Inout</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#featureDirectionKind_Inout">http://open-services.net/ns/sysmlv2#featureDirectionKind_Inout</seealso>
    let featureDirectionKind_Inout =
        Prefixed_Name(ossysmlv2, "featureDirectionKind_Inout") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:featureDirectionKind_Out</para>
    /// </summary>
    /// <remarks>
    ///   <para>ossysmlv2:FeatureDirectionKind</para>
    ///   <para>Values of the Feature on each instance of its domain are determined internally to that instance and used externally.</para>
    /// labels<para>featureDirectionKind_Out</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#featureDirectionKind_Out">http://open-services.net/ns/sysmlv2#featureDirectionKind_Out</seealso>
    let featureDirectionKind_Out =
        Prefixed_Name(ossysmlv2, "featureDirectionKind_Out") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:featureMembership_OwnedMemberFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Feature that this FeatureMembership relates to its owningType, making it an ownedFeature of the owningType.</para>
    /// labels<para>featureMembership_OwnedMemberFeature</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#featureMembership_OwnedMemberFeature">http://open-services.net/ns/sysmlv2#featureMembership_OwnedMemberFeature</seealso>
    let featureMembership_OwnedMemberFeature =
        Prefixed_Name(ossysmlv2, "featureMembership_OwnedMemberFeature") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:featureMembership_OwningType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Type that owns this FeatureMembership.</para>
    /// labels<para>featureMembership_OwningType</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#featureMembership_OwningType">http://open-services.net/ns/sysmlv2#featureMembership_OwningType</seealso>
    let featureMembership_OwningType =
        Prefixed_Name(ossysmlv2, "featureMembership_OwningType") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:featureReferenceExpression_Referent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Feature that is referenced by this FeatureReferenceExpression, which is its first non-parameter member.</para>
    /// labels<para>featureReferenceExpression_Referent</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#featureReferenceExpression_Referent">http://open-services.net/ns/sysmlv2#featureReferenceExpression_Referent</seealso>
    let featureReferenceExpression_Referent =
        Prefixed_Name(ossysmlv2, "featureReferenceExpression_Referent") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:featureTyping_OwningFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A typedFeature that is also the owningRelatedElement of this FeatureTyping.</para>
    /// labels<para>featureTyping_OwningFeature</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#featureTyping_OwningFeature">http://open-services.net/ns/sysmlv2#featureTyping_OwningFeature</seealso>
    let featureTyping_OwningFeature =
        Prefixed_Name(ossysmlv2, "featureTyping_OwningFeature") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:featureTyping_Type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Type that is being applied by this FeatureTyping.</para>
    /// labels<para>featureTyping_Type</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#featureTyping_Type">http://open-services.net/ns/sysmlv2#featureTyping_Type</seealso>
    let featureTyping_Type =
        Prefixed_Name(ossysmlv2, "featureTyping_Type") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:featureValue_IsInitial</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether this FeatureValue specifies a bound value or an initial value for the featureWithValue.</para>
    /// labels<para>featureValue_IsInitial</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#featureValue_IsInitial">http://open-services.net/ns/sysmlv2#featureValue_IsInitial</seealso>
    let featureValue_IsInitial =
        Prefixed_Name(ossysmlv2, "featureValue_IsInitial") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:featureValue_Value</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Expression that provides the value of the featureWithValue as its result.</para>
    /// labels<para>featureValue_Value</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#featureValue_Value">http://open-services.net/ns/sysmlv2#featureValue_Value</seealso>
    let featureValue_Value =
        Prefixed_Name(ossysmlv2, "featureValue_Value") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:feature_ChainingFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Feature that are chained together to determine the values of this Feature, derived from the chainingFeatures of the ownedFeatureChainings of this Feature, in the same order. The values of a Feature with chainingFeatures are the same as values of the last Feature in the chain, which can be found by starting with the values of the first Feature (for each instance of the domain of the original Feature), then using each of those as domain instances to find the values of the second Feature in chainingFeatures, and so on, to values of the last Feature.</para>
    /// labels<para>feature_ChainingFeature</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#feature_ChainingFeature">http://open-services.net/ns/sysmlv2#feature_ChainingFeature</seealso>
    let feature_ChainingFeature =
        Prefixed_Name(ossysmlv2, "feature_ChainingFeature") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:feature_Direction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates how values of this Feature are determined or used (as specified for the FeatureDirectionKind).</para>
    /// labels<para>feature_Direction</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#feature_Direction">http://open-services.net/ns/sysmlv2#feature_Direction</seealso>
    let feature_Direction =
        Prefixed_Name(ossysmlv2, "feature_Direction") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:feature_EndOwningType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Type that is related to this Feature by an EndFeatureMembership in which the Feature is an ownedMemberFeature.</para>
    /// labels<para>feature_EndOwningType</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#feature_EndOwningType">http://open-services.net/ns/sysmlv2#feature_EndOwningType</seealso>
    let feature_EndOwningType =
        Prefixed_Name(ossysmlv2, "feature_EndOwningType") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:AllocationDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An AllocationDefinition is a ConnectionDefinition that specifies that some or all of the responsibility to realize the intent of the source is allocated to the target instances. Such allocations define mappings across the various structures and hierarchies of a system model, perhaps as a precursor to more rigorous specifications and implementations. An AllocationDefinition can itself be refined using nested allocations that give a finer-grained decomposition of the containing allocation mapping.</para>
    /// labels<para>AllocationDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#AllocationDefinition">http://open-services.net/ns/sysmlv2#AllocationDefinition</seealso>
    let AllocationDefinition =
        Prefixed_Name(ossysmlv2, "AllocationDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:membership_MemberElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Element that becomes a member of the membershipOwningNamespace due to this Membership.</para>
    /// labels<para>membership_MemberElement</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#membership_MemberElement">http://open-services.net/ns/sysmlv2#membership_MemberElement</seealso>
    let membership_MemberElement =
        Prefixed_Name(ossysmlv2, "membership_MemberElement") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:usage_NestedPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The PartUsages that are nestedUsages of this Usage.</para>
    /// labels<para>usage_NestedPart</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#usage_NestedPart">http://open-services.net/ns/sysmlv2#usage_NestedPart</seealso>
    let usage_NestedPart = Prefixed_Name(ossysmlv2, "usage_NestedPart") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:usage_NestedReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ReferenceUsages that are nestedUsages of this Usage.</para>
    /// labels<para>usage_NestedReference</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#usage_NestedReference">http://open-services.net/ns/sysmlv2#usage_NestedReference</seealso>
    let usage_NestedReference =
        Prefixed_Name(ossysmlv2, "usage_NestedReference") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:CaseDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A CaseDefinition is a CalculationDefinition for a process, often involving collecting evidence or data, relative to a subject, possibly involving the collaboration of one or more other actors, producing a result that meets an objective.</para>
    /// labels<para>CaseDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#CaseDefinition">http://open-services.net/ns/sysmlv2#CaseDefinition</seealso>
    let CaseDefinition = Prefixed_Name(ossysmlv2, "CaseDefinition") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An Annotation is a Relationship between an AnnotatingElement and the Element that is annotated by that AnnotatingElement.</para>
    /// labels<para>Annotation</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Annotation">http://open-services.net/ns/sysmlv2#Annotation</seealso>
    let Annotation = Prefixed_Name(ossysmlv2, "Annotation") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:Association</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An Association is a Relationship and a Classifier to enable classification of links between things (in the universe). The co-domains (types) of the associationEnd Features are the relatedTypes, as co-domain and participants (linked things) of an Association identify each other.</para>
    /// labels<para>Association</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Association">http://open-services.net/ns/sysmlv2#Association</seealso>
    let Association = Prefixed_Name(ossysmlv2, "Association") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:Classifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Classifier is a Type that classifies:.</para>
    /// labels<para>Classifier</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Classifier">http://open-services.net/ns/sysmlv2#Classifier</seealso>
    let Classifier = Prefixed_Name(ossysmlv2, "Classifier") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:AssociationStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An AssociationStructure is an Association that is also a Structure, classifying link objects that are both links and objects. As objects, link objects can be created and destroyed, and their non-end Features can change over time. However, the values of the end Features of a link object are fixed and cannot change over its lifetime.</para>
    /// labels<para>AssociationStructure</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#AssociationStructure">http://open-services.net/ns/sysmlv2#AssociationStructure</seealso>
    let AssociationStructure =
        Prefixed_Name(ossysmlv2, "AssociationStructure") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:AttributeDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An AttributeDefinition is a Definition and a DataType of information about a quality or characteristic of a system or part of a system that has no independent identity other than its value. All features of an AttributeDefinition must be referential (non-composite).</para>
    /// labels<para>AttributeDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#AttributeDefinition">http://open-services.net/ns/sysmlv2#AttributeDefinition</seealso>
    let AttributeDefinition =
        Prefixed_Name(ossysmlv2, "AttributeDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:ObjectiveMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An ObjectiveMembership is a FeatureMembership that indicates that its ownedObjectiveRequirement is the objective RequirementUsage for its owningType, which must be a CaseDefinition or CaseUsage.</para>
    /// labels<para>ObjectiveMembership</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#ObjectiveMembership">http://open-services.net/ns/sysmlv2#ObjectiveMembership</seealso>
    let ObjectiveMembership =
        Prefixed_Name(ossysmlv2, "ObjectiveMembership") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:disjoining_DisjoiningType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Type asserted to be disjoint with the typeDisjoined.</para>
    /// labels<para>disjoining_DisjoiningType</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#disjoining_DisjoiningType">http://open-services.net/ns/sysmlv2#disjoining_DisjoiningType</seealso>
    let disjoining_DisjoiningType =
        Prefixed_Name(ossysmlv2, "disjoining_DisjoiningType") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:element_DeclaredShortName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An optional alternative name for the Element that is intended to be shorter or in some way more succinct than its primary name. It may act as a modeler-specified identifier for the Element, though it is then the responsibility of the modeler to maintain the uniqueness of this identifier within a model or relative to some other context.</para>
    /// labels<para>element_DeclaredShortName</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#element_DeclaredShortName">http://open-services.net/ns/sysmlv2#element_DeclaredShortName</seealso>
    let element_DeclaredShortName =
        Prefixed_Name(ossysmlv2, "element_DeclaredShortName") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:element_Documentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Documentation owned by this Element.</para>
    /// labels<para>element_Documentation</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#element_Documentation">http://open-services.net/ns/sysmlv2#element_Documentation</seealso>
    let element_Documentation =
        Prefixed_Name(ossysmlv2, "element_Documentation") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:AnalysisCaseDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An AnalysisCaseDefinition is a CaseDefinition for the case of carrying out an analysis.</para>
    /// labels<para>AnalysisCaseDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#AnalysisCaseDefinition">http://open-services.net/ns/sysmlv2#AnalysisCaseDefinition</seealso>
    let AnalysisCaseDefinition =
        Prefixed_Name(ossysmlv2, "AnalysisCaseDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:CaseUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A CaseUsage is a Usage of a CaseDefinition.</para>
    /// labels<para>CaseUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#CaseUsage">http://open-services.net/ns/sysmlv2#CaseUsage</seealso>
    let CaseUsage = Prefixed_Name(ossysmlv2, "CaseUsage") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:Element</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An Element is a constituent of a model that is uniquely identified relative to all other Elements. It can have Relationships with other Elements. Some of these Relationships might imply ownership of other Elements, which means that if an Element is deleted from a model, then so are all the Elements that it owns.</para>
    /// labels<para>Element</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Element">http://open-services.net/ns/sysmlv2#Element</seealso>
    let Element = Prefixed_Name(ossysmlv2, "Element") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:connector_SourceFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The source relatedFeature for this Connector. It is the first relatedFeature.</para>
    /// labels<para>connector_SourceFeature</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#connector_SourceFeature">http://open-services.net/ns/sysmlv2#connector_SourceFeature</seealso>
    let connector_SourceFeature =
        Prefixed_Name(ossysmlv2, "connector_SourceFeature") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:definition_DirectedUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The usages of this Definition that are directedFeatures.</para>
    /// labels<para>definition_DirectedUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#definition_DirectedUsage">http://open-services.net/ns/sysmlv2#definition_DirectedUsage</seealso>
    let definition_DirectedUsage =
        Prefixed_Name(ossysmlv2, "definition_DirectedUsage") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:definition_OwnedAnalysisCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The AnalysisCaseUsages that are ownedUsages of this Definition.</para>
    /// labels<para>definition_OwnedAnalysisCase</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#definition_OwnedAnalysisCase">http://open-services.net/ns/sysmlv2#definition_OwnedAnalysisCase</seealso>
    let definition_OwnedAnalysisCase =
        Prefixed_Name(ossysmlv2, "definition_OwnedAnalysisCase") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:redefinition_RedefinedFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Feature that is redefined by the redefiningFeature of this Redefinition.</para>
    /// labels<para>redefinition_RedefinedFeature</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#redefinition_RedefinedFeature">http://open-services.net/ns/sysmlv2#redefinition_RedefinedFeature</seealso>
    let redefinition_RedefinedFeature =
        Prefixed_Name(ossysmlv2, "redefinition_RedefinedFeature") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:redefinition_RedefiningFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Feature that is redefining the redefinedFeature of this Redefinition.</para>
    /// labels<para>redefinition_RedefiningFeature</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#redefinition_RedefiningFeature">http://open-services.net/ns/sysmlv2#redefinition_RedefiningFeature</seealso>
    let redefinition_RedefiningFeature =
        Prefixed_Name(ossysmlv2, "redefinition_RedefiningFeature") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:referenceSubsetting_ReferencedFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Feature that is referenced by the referencingFeature of this ReferenceSubsetting.</para>
    /// labels<para>referenceSubsetting_ReferencedFeature</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#referenceSubsetting_ReferencedFeature">http://open-services.net/ns/sysmlv2#referenceSubsetting_ReferencedFeature</seealso>
    let referenceSubsetting_ReferencedFeature =
        Prefixed_Name(ossysmlv2, "referenceSubsetting_ReferencedFeature") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:relationship_IsImplied</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether this Relationship was generated by tooling to meet semantic rules, rather than being directly created by a modeler.</para>
    /// labels<para>relationship_IsImplied</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#relationship_IsImplied">http://open-services.net/ns/sysmlv2#relationship_IsImplied</seealso>
    let relationship_IsImplied =
        Prefixed_Name(ossysmlv2, "relationship_IsImplied") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:AnalysisCaseUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An AnalysisCaseUsage is a Usage of an AnalysisCaseDefinition.</para>
    /// labels<para>AnalysisCaseUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#AnalysisCaseUsage">http://open-services.net/ns/sysmlv2#AnalysisCaseUsage</seealso>
    let AnalysisCaseUsage =
        Prefixed_Name(ossysmlv2, "AnalysisCaseUsage") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:AnnotatingElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An AnnotatingElement is an Element that provides additional description of or metadata on some other Element. An AnnotatingElement is either attached to its annotatedElements by Annotation Relationships, or it implicitly annotates its owningNamespace.</para>
    /// labels<para>AnnotatingElement</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#AnnotatingElement">http://open-services.net/ns/sysmlv2#AnnotatingElement</seealso>
    let AnnotatingElement =
        Prefixed_Name(ossysmlv2, "AnnotatingElement") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:connector_Association</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Associations that type the Connector.</para>
    /// labels<para>connector_Association</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#connector_Association">http://open-services.net/ns/sysmlv2#connector_Association</seealso>
    let connector_Association =
        Prefixed_Name(ossysmlv2, "connector_Association") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:connector_ConnectorEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The endFeatures of a Connector, which redefine the endFeatures of the associations of the Connector. The connectorEnds determine via ReferenceSubsetting Relationships which Features are related by the Connector.</para>
    /// labels<para>connector_ConnectorEnd</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#connector_ConnectorEnd">http://open-services.net/ns/sysmlv2#connector_ConnectorEnd</seealso>
    let connector_ConnectorEnd =
        Prefixed_Name(ossysmlv2, "connector_ConnectorEnd") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:connector_RelatedFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Features that are related by this Connector considered as a Relationship and that restrict the links it identifies, given by the referenced Features of the connectorEnds of the Connector.</para>
    /// labels<para>connector_RelatedFeature</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#connector_RelatedFeature">http://open-services.net/ns/sysmlv2#connector_RelatedFeature</seealso>
    let connector_RelatedFeature =
        Prefixed_Name(ossysmlv2, "connector_RelatedFeature") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:connector_TargetFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The target relatedFeatures for this Connector. This includes all the relatedFeatures other than the sourceFeature.</para>
    /// labels<para>connector_TargetFeature</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#connector_TargetFeature">http://open-services.net/ns/sysmlv2#connector_TargetFeature</seealso>
    let connector_TargetFeature =
        Prefixed_Name(ossysmlv2, "connector_TargetFeature") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:definition_IsVariation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether this Definition is for a variation point or not. If true, then all the memberships of the Definition must be VariantMemberships.</para>
    /// labels<para>definition_IsVariation</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#definition_IsVariation">http://open-services.net/ns/sysmlv2#definition_IsVariation</seealso>
    let definition_IsVariation =
        Prefixed_Name(ossysmlv2, "definition_IsVariation") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:definition_OwnedAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The AttributeUsages that are ownedUsages of this Definition.</para>
    /// labels<para>definition_OwnedAttribute</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#definition_OwnedAttribute">http://open-services.net/ns/sysmlv2#definition_OwnedAttribute</seealso>
    let definition_OwnedAttribute =
        Prefixed_Name(ossysmlv2, "definition_OwnedAttribute") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:referenceSubsetting_ReferencingFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Feature that owns this ReferenceSubsetting relationship, which is also its subsettingFeature.</para>
    /// labels<para>referenceSubsetting_ReferencingFeature</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#referenceSubsetting_ReferencingFeature">http://open-services.net/ns/sysmlv2#referenceSubsetting_ReferencingFeature</seealso>
    let referenceSubsetting_ReferencingFeature =
        Prefixed_Name(ossysmlv2, "referenceSubsetting_ReferencingFeature") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:Relationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Relationship is an Element that relates other Element. Some of its relatedElements may be owned, in which case those ownedRelatedElements will be deleted from a model if their owningRelationship is. A Relationship may also be owned by another Element, in which case the ownedRelatedElements of the Relationship are also considered to be transitively owned by the owningRelatedElement of the Relationship.</para>
    /// labels<para>Relationship</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Relationship">http://open-services.net/ns/sysmlv2#Relationship</seealso>
    let Relationship = Prefixed_Name(ossysmlv2, "Relationship") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:Invariant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An Invariant is a BooleanExpression that is asserted to have a specific Boolean result value. If isNegated = false, then the result is asserted to be true. If isNegated = true, then the result is asserted to be false.</para>
    /// labels<para>Invariant</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Invariant">http://open-services.net/ns/sysmlv2#Invariant</seealso>
    let Invariant = Prefixed_Name(ossysmlv2, "Invariant") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:ItemFlowEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An ItemFlowEnd is a Feature that is one of the connectorEnds giving the source or target of an ItemFlow. For ItemFlows typed by FlowTransfer or its specializations, ItemFlowEnds must have exactly one ownedFeature, which redefines Transfer::source::sourceOutput or Transfer::target::targetInput and redefines the corresponding feature of the relatedElement for its end.</para>
    /// labels<para>ItemFlowEnd</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#ItemFlowEnd">http://open-services.net/ns/sysmlv2#ItemFlowEnd</seealso>
    let ItemFlowEnd = Prefixed_Name(ossysmlv2, "ItemFlowEnd") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:JoinNode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A JoinNode is a ControlNode that waits for the completion of all the predecessor Actions given by incoming Successions.</para>
    /// labels<para>JoinNode</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#JoinNode">http://open-services.net/ns/sysmlv2#JoinNode</seealso>
    let JoinNode = Prefixed_Name(ossysmlv2, "JoinNode") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:Package</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Package is a Namespace used to group Elements, without any instance-level semantics. It may have one or more model-level evaluable filterCondition Expressions used to filter its importedMemberships. Any imported member must meet all of the filterConditions.</para>
    /// labels<para>Package</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Package">http://open-services.net/ns/sysmlv2#Package</seealso>
    let Package = Prefixed_Name(ossysmlv2, "Package") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:LifeClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A LifeClass is a Class that specializes both the Class Occurrences::Life from the Kernel Semantic Library and a single OccurrenceDefinition, and has a multiplicity of 0..1. This constrains the OccurrenceDefinition being specialized to have at most one instance that is a complete Life.</para>
    /// labels<para>LifeClass</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#LifeClass">http://open-services.net/ns/sysmlv2#LifeClass</seealso>
    let LifeClass = Prefixed_Name(ossysmlv2, "LifeClass") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:LiteralInfinity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A LiteralInfinity is a LiteralExpression that provides the positive infinity value (*). It's result must have the type Positive.</para>
    /// labels<para>LiteralInfinity</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#LiteralInfinity">http://open-services.net/ns/sysmlv2#LiteralInfinity</seealso>
    let LiteralInfinity = Prefixed_Name(ossysmlv2, "LiteralInfinity") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:definition_OwnedFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The FlowConnectionUsages that are ownedUsages of this Definition.</para>
    /// labels<para>definition_OwnedFlow</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#definition_OwnedFlow">http://open-services.net/ns/sysmlv2#definition_OwnedFlow</seealso>
    let definition_OwnedFlow =
        Prefixed_Name(ossysmlv2, "definition_OwnedFlow") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:requirementConstraintMembership_ReferencedConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para> The ConstraintUsage that is referenced through this RequirementConstraintMembership. It is the referencedFeature of the ownedReferenceSubsetting of the ownedConstraint, if there is one, and, otherwise, the ownedConstraint itself.</para>
    /// labels<para>requirementConstraintMembership_ReferencedConstraint</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#requirementConstraintMembership_ReferencedConstraint">http://open-services.net/ns/sysmlv2#requirementConstraintMembership_ReferencedConstraint</seealso>
    let requirementConstraintMembership_ReferencedConstraint =
        Prefixed_Name(ossysmlv2, "requirementConstraintMembership_ReferencedConstraint") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:requirementDefinition_ActorParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The parameters of this RequirementDefinition that represent actors involved in the requirement.</para>
    /// labels<para>requirementDefinition_ActorParameter</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#requirementDefinition_ActorParameter">http://open-services.net/ns/sysmlv2#requirementDefinition_ActorParameter</seealso>
    let requirementDefinition_ActorParameter =
        Prefixed_Name(ossysmlv2, "requirementDefinition_ActorParameter") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:requirementDefinition_AssumedConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The owned ConstraintUsages that represent assumptions of this RequirementDefinition, which are the ownedConstraints of the RequirementConstraintMemberships of the RequirementDefinition with kind = assumption.</para>
    /// labels<para>requirementDefinition_AssumedConstraint</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#requirementDefinition_AssumedConstraint">http://open-services.net/ns/sysmlv2#requirementDefinition_AssumedConstraint</seealso>
    let requirementDefinition_AssumedConstraint =
        Prefixed_Name(ossysmlv2, "requirementDefinition_AssumedConstraint") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:AssertConstraintUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An AssertConstraintUsage is a ConstraintUsage that is also an Invariant and, so, is asserted to be true (by default). Unless it is the AssertConstraintUsage itself, the asserted ConstraintUsage is related to the AssertConstraintUsage by a ReferenceSubsetting Relationship.</para>
    /// labels<para>AssertConstraintUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#AssertConstraintUsage">http://open-services.net/ns/sysmlv2#AssertConstraintUsage</seealso>
    let AssertConstraintUsage =
        Prefixed_Name(ossysmlv2, "AssertConstraintUsage") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:AssignmentActionUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An AssignmentActionUsage is an ActionUsage that is defined, directly or indirectly, by the ActionDefinition AssignmentAction from the Systems Model Library. It specifies that the value of the referent Feature, relative to the target given by the result of the targetArgument Expression, should be set to the result of the valueExpression.</para>
    /// labels<para>AssignmentActionUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#AssignmentActionUsage">http://open-services.net/ns/sysmlv2#AssignmentActionUsage</seealso>
    let AssignmentActionUsage =
        Prefixed_Name(ossysmlv2, "AssignmentActionUsage") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:definition_OwnedConnection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ConnectorAsUsages that are ownedUsages of this Definition. Note that this list includes BindingConnectorAsUsages and SuccessionAsUsages, even though these are ConnectorAsUsages but not ConnectionUsages.</para>
    /// labels<para>definition_OwnedConnection</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#definition_OwnedConnection">http://open-services.net/ns/sysmlv2#definition_OwnedConnection</seealso>
    let definition_OwnedConnection =
        Prefixed_Name(ossysmlv2, "definition_OwnedConnection") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:ConstraintUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A ConstraintUsage is an OccurrenceUsage that is also a BooleanExpression, and, so, is typed by a Predicate. Nominally, if the type is a ConstraintDefinition, a ConstraintUsage is a Usage of that ConstraintDefinition. However, other kinds of kernel Predicates are also allowed, to permit use of Predicates from the Kernel Model Libraries.</para>
    /// labels<para>ConstraintUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#ConstraintUsage">http://open-services.net/ns/sysmlv2#ConstraintUsage</seealso>
    let ConstraintUsage = Prefixed_Name(ossysmlv2, "ConstraintUsage") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:Structure</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Structure is a Class of objects in the modeled universe that are primarily structural in nature. While such an object is not itself behavioral, it may be involved in and acted on by Behaviors, and it may be the performer of some of them.</para>
    /// labels<para>Structure</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Structure">http://open-services.net/ns/sysmlv2#Structure</seealso>
    let Structure = Prefixed_Name(ossysmlv2, "Structure") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:AttributeUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An AttributeUsage is a Usage whose type is a DataType. Nominally, if the type is an AttributeDefinition, an AttributeUsage is a usage of a AttributeDefinition to represent the value of some system quality or characteristic. However, other kinds of kernel DataTypes are also allowed, to permit use of DataTypes from the Kernel Model Libraries. An AttributeUsage itself as well as all its nested features must be referential (non-composite).</para>
    /// labels<para>AttributeUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#AttributeUsage">http://open-services.net/ns/sysmlv2#AttributeUsage</seealso>
    let AttributeUsage = Prefixed_Name(ossysmlv2, "AttributeUsage") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:Connector</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Connector is a usage of Associations, with links restricted according to instances of the Type in which they are used (domain of the Connector). The associations of the Connector restrict what kinds of things might be linked. The Connector further restricts these links to be between values of Features on instances of its domain.</para>
    /// labels<para>Connector</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Connector">http://open-services.net/ns/sysmlv2#Connector</seealso>
    let Connector = Prefixed_Name(ossysmlv2, "Connector") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:ConnectorAsUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A ConnectorAsUsage is both a Connector and a Usage. ConnectorAsUsage cannot itself be instantiated in a SysML model, but it is the base class for the concrete classes BindingConnectorAsUsage, SuccessionAsUsage and ConnectionUsage.</para>
    /// labels<para>ConnectorAsUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#ConnectorAsUsage">http://open-services.net/ns/sysmlv2#ConnectorAsUsage</seealso>
    let ConnectorAsUsage = Prefixed_Name(ossysmlv2, "ConnectorAsUsage") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:SelectExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SelectExpression is an OperatorExpression whose operator is "select", which resolves to the Function ControlFunctions::select from the Kernel Functions Library.</para>
    /// labels<para>SelectExpression</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#SelectExpression">http://open-services.net/ns/sysmlv2#SelectExpression</seealso>
    let SelectExpression = Prefixed_Name(ossysmlv2, "SelectExpression") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:StateDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A StateDefinition is the Definition of the Behavior of a system or part of a system in a certain state condition.</para>
    /// labels<para>StateDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#StateDefinition">http://open-services.net/ns/sysmlv2#StateDefinition</seealso>
    let StateDefinition = Prefixed_Name(ossysmlv2, "StateDefinition") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:step_Behavior</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Behaviors that type this Step.</para>
    /// labels<para>step_Behavior</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#step_Behavior">http://open-services.net/ns/sysmlv2#step_Behavior</seealso>
    let step_Behavior = Prefixed_Name(ossysmlv2, "step_Behavior") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:step_Parameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The parameters of this Step, which are defined as its directedFeatures, whose values are passed into and/or out of a performance of the Step.</para>
    /// labels<para>step_Parameter</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#step_Parameter">http://open-services.net/ns/sysmlv2#step_Parameter</seealso>
    let step_Parameter = Prefixed_Name(ossysmlv2, "step_Parameter") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:subclassification_OwningClassifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Classifier that owns this Subclassification relationship, which must also be its subclassifier.</para>
    /// labels<para>subclassification_OwningClassifier</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#subclassification_OwningClassifier">http://open-services.net/ns/sysmlv2#subclassification_OwningClassifier</seealso>
    let subclassification_OwningClassifier =
        Prefixed_Name(ossysmlv2, "subclassification_OwningClassifier") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:definition_OwnedOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The OccurrenceUsages that are ownedUsages of this Definition.</para>
    /// labels<para>definition_OwnedOccurrence</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#definition_OwnedOccurrence">http://open-services.net/ns/sysmlv2#definition_OwnedOccurrence</seealso>
    let definition_OwnedOccurrence =
        Prefixed_Name(ossysmlv2, "definition_OwnedOccurrence") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:definition_OwnedReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ReferenceUsages that are ownedUsages of this Definition.</para>
    /// labels<para>definition_OwnedReference</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#definition_OwnedReference">http://open-services.net/ns/sysmlv2#definition_OwnedReference</seealso>
    let definition_OwnedReference =
        Prefixed_Name(ossysmlv2, "definition_OwnedReference") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:DataType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A DataType is a Classifier of things (in the universe) that can only be distinguished by how they are related to other things (via Features). This means multiple things classified by the same DataType.</para>
    /// labels<para>DataType</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#DataType">http://open-services.net/ns/sysmlv2#DataType</seealso>
    let DataType = Prefixed_Name(ossysmlv2, "DataType") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:Usage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Usage is a usage of a Definition. A Usage may only be an ownedFeature of a Definition or another Usage.</para>
    /// labels<para>Usage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Usage">http://open-services.net/ns/sysmlv2#Usage</seealso>
    let Usage = Prefixed_Name(ossysmlv2, "Usage") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:BindingConnector</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A BindingConnector is a binary Connector that requires its relatedFeatures to identify the same things (have the same values).</para>
    /// labels<para>BindingConnector</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#BindingConnector">http://open-services.net/ns/sysmlv2#BindingConnector</seealso>
    let BindingConnector = Prefixed_Name(ossysmlv2, "BindingConnector") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:BindingConnectorAsUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A BindingConnectorAsUsage is both a BindingConnector and a ConnectorAsUsage.</para>
    /// labels<para>BindingConnectorAsUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#BindingConnectorAsUsage">http://open-services.net/ns/sysmlv2#BindingConnectorAsUsage</seealso>
    let BindingConnectorAsUsage =
        Prefixed_Name(ossysmlv2, "BindingConnectorAsUsage") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:PortionKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>PortionKind is an enumeration of the specific kinds of Occurrence portions that can be represented by an OccurrenceUsage.</para>
    /// labels<para>PortionKind</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#PortionKind">http://open-services.net/ns/sysmlv2#PortionKind</seealso>
    let PortionKind = Prefixed_Name(ossysmlv2, "PortionKind") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:Redefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Redefinition is a kind of Subsetting that requires the redefinedFeature and the redefiningFeature to have the same values (on each instance of the domain of the redefiningFeature). This means any restrictions on the redefiningFeature, such as type or multiplicity, also apply to the redefinedFeature (on each instance of the domain of the redefiningFeature), and vice versa. The redefinedFeature might have values for instances of the domain of the redefiningFeature, but only as instances of the domain of the redefinedFeature that happen to also be instances of the domain of the redefiningFeature. This is supported by the constraints inherited from Subsetting on the domains of the redefiningFeature and redefinedFeature. However, these constraints are narrowed for Redefinition to require the owningTypes of the redefiningFeature and redefinedFeature to be different and the redefinedFeature to not be inherited into the owningNamespace of the redefiningFeature.This enables the redefiningFeature to have the same name as the redefinedFeature, if desired.</para>
    /// labels<para>Redefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Redefinition">http://open-services.net/ns/sysmlv2#Redefinition</seealso>
    let Redefinition = Prefixed_Name(ossysmlv2, "Redefinition") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:ReferenceUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A ReferenceUsage is a Usage that specifies a non-compositional (isComposite = false) reference to something. The definition of a ReferenceUsage can be any kind of Classifier, with the default being the top-level Classifier Base::Anything from the Kernel Semantic Library. This allows the specification of a generic reference without distinguishing if the thing referenced is an attribute value, item, action, etc.</para>
    /// labels<para>ReferenceUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#ReferenceUsage">http://open-services.net/ns/sysmlv2#ReferenceUsage</seealso>
    let ReferenceUsage = Prefixed_Name(ossysmlv2, "ReferenceUsage") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:RenderingDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A RenderingDefinition is a PartDefinition that defines a specific rendering of the content of a model view (e.g., symbols, style, layout, etc.).</para>
    /// labels<para>RenderingDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#RenderingDefinition">http://open-services.net/ns/sysmlv2#RenderingDefinition</seealso>
    let RenderingDefinition =
        Prefixed_Name(ossysmlv2, "RenderingDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:RequirementConstraintKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A RequirementConstraintKind indicates whether a ConstraintUsage is an assumption or a requirement in a RequirementDefinition or RequirementUsage.</para>
    /// labels<para>RequirementConstraintKind</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#RequirementConstraintKind">http://open-services.net/ns/sysmlv2#RequirementConstraintKind</seealso>
    let RequirementConstraintKind =
        Prefixed_Name(ossysmlv2, "RequirementConstraintKind") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:ResultExpressionMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A ResultExpressionMembership is a FeatureMembership that indicates that the ownedResultExpression provides the result values for the Function or Expression that owns it. The owning Function or Expression must contain a BindingConnector between the result parameter of the ownedResultExpression and the result parameter of the owning Function or Expression.</para>
    /// labels<para>ResultExpressionMembership</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#ResultExpressionMembership">http://open-services.net/ns/sysmlv2#ResultExpressionMembership</seealso>
    let ResultExpressionMembership =
        Prefixed_Name(ossysmlv2, "ResultExpressionMembership") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:SatisfyRequirementUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SatisfyRequirementUsage is an AssertConstraintUsage that asserts, by default, that a satisfied RequirementUsage is true for a specific satisfyingFeature, or, if isNegated = true, that the RequirementUsage is false. The satisfied RequirementUsage is related to the SatisfyRequirementUsage by a ReferenceSubsetting Relationship.</para>
    /// labels<para>SatisfyRequirementUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#SatisfyRequirementUsage">http://open-services.net/ns/sysmlv2#SatisfyRequirementUsage</seealso>
    let SatisfyRequirementUsage =
        Prefixed_Name(ossysmlv2, "SatisfyRequirementUsage") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:element_TextualRepresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The TextualRepresentations that annotate this Element.</para>
    /// labels<para>element_TextualRepresentation</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#element_TextualRepresentation">http://open-services.net/ns/sysmlv2#element_TextualRepresentation</seealso>
    let element_TextualRepresentation =
        Prefixed_Name(ossysmlv2, "element_TextualRepresentation") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:expression_IsModelLevelEvaluable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether this Expression meets the constraints necessary to be evaluated at model level, that is, using metadata within the model.</para>
    /// labels<para>expression_IsModelLevelEvaluable</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#expression_IsModelLevelEvaluable">http://open-services.net/ns/sysmlv2#expression_IsModelLevelEvaluable</seealso>
    let expression_IsModelLevelEvaluable =
        Prefixed_Name(ossysmlv2, "expression_IsModelLevelEvaluable") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:expression_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>result.</para>
    /// labels<para>expression_Result</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#expression_Result">http://open-services.net/ns/sysmlv2#expression_Result</seealso>
    let expression_Result =
        Prefixed_Name(ossysmlv2, "expression_Result") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:featureChainExpression_TargetFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Feature that is accessed by this FeatureChainExpression, which is its first non-parameter member.</para>
    /// labels<para>featureChainExpression_TargetFeature</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#featureChainExpression_TargetFeature">http://open-services.net/ns/sysmlv2#featureChainExpression_TargetFeature</seealso>
    let featureChainExpression_TargetFeature =
        Prefixed_Name(ossysmlv2, "featureChainExpression_TargetFeature") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:featureInverting_FeatureInverted</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Feature that is an inverse of the invertingFeature.</para>
    /// labels<para>featureInverting_FeatureInverted</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#featureInverting_FeatureInverted">http://open-services.net/ns/sysmlv2#featureInverting_FeatureInverted</seealso>
    let featureInverting_FeatureInverted =
        Prefixed_Name(ossysmlv2, "featureInverting_FeatureInverted") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:featureInverting_InvertingFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Feature that is an inverse of the invertedFeature.</para>
    /// labels<para>featureInverting_InvertingFeature</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#featureInverting_InvertingFeature">http://open-services.net/ns/sysmlv2#featureInverting_InvertingFeature</seealso>
    let featureInverting_InvertingFeature =
        Prefixed_Name(ossysmlv2, "featureInverting_InvertingFeature") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:featureInverting_OwningFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A featureInverted that is also the owningRelatedElement of this FeatureInverting.</para>
    /// labels<para>featureInverting_OwningFeature</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#featureInverting_OwningFeature">http://open-services.net/ns/sysmlv2#featureInverting_OwningFeature</seealso>
    let featureInverting_OwningFeature =
        Prefixed_Name(ossysmlv2, "featureInverting_OwningFeature") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:featureTyping_TypedFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Feature that has a type determined by this FeatureTyping.</para>
    /// labels<para>featureTyping_TypedFeature</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#featureTyping_TypedFeature">http://open-services.net/ns/sysmlv2#featureTyping_TypedFeature</seealso>
    let featureTyping_TypedFeature =
        Prefixed_Name(ossysmlv2, "featureTyping_TypedFeature") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:featureValue_FeatureWithValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Feature to be provided a value.</para>
    /// labels<para>featureValue_FeatureWithValue</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#featureValue_FeatureWithValue">http://open-services.net/ns/sysmlv2#featureValue_FeatureWithValue</seealso>
    let featureValue_FeatureWithValue =
        Prefixed_Name(ossysmlv2, "featureValue_FeatureWithValue") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:featureValue_IsDefault</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether this FeatureValue is a concrete specification of the bound or initial value of the featureWithValue, or just a default value that may be overridden.</para>
    /// labels<para>featureValue_IsDefault</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#featureValue_IsDefault">http://open-services.net/ns/sysmlv2#featureValue_IsDefault</seealso>
    let featureValue_IsDefault =
        Prefixed_Name(ossysmlv2, "featureValue_IsDefault") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:feature_FeaturingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Types that feature this Feature, such that any instance in the domain of the Feature must be classified by all of these Types, including at least all the featuringTypes of its typeFeaturings.  If the Feature is chained, then the featuringTypes of the first Feature in the chain are also featuringTypes of the chained Feature.</para>
    /// labels<para>feature_FeaturingType</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#feature_FeaturingType">http://open-services.net/ns/sysmlv2#feature_FeaturingType</seealso>
    let feature_FeaturingType =
        Prefixed_Name(ossysmlv2, "feature_FeaturingType") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:feature_IsComposite</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether the Feature is a composite feature of its featuringType. If so, the values of the Feature cannot exist after its featuring instance no longer does.</para>
    /// labels<para>feature_IsComposite</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#feature_IsComposite">http://open-services.net/ns/sysmlv2#feature_IsComposite</seealso>
    let feature_IsComposite =
        Prefixed_Name(ossysmlv2, "feature_IsComposite") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:feature_IsDerived</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether the values of this Feature can always be computed from the values of other Features.</para>
    /// labels<para>feature_IsDerived</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#feature_IsDerived">http://open-services.net/ns/sysmlv2#feature_IsDerived</seealso>
    let feature_IsDerived =
        Prefixed_Name(ossysmlv2, "feature_IsDerived") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:feature_IsNonunique</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>isNonunique.</para>
    /// labels<para>feature_IsNonunique</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#feature_IsNonunique">http://open-services.net/ns/sysmlv2#feature_IsNonunique</seealso>
    let feature_IsNonunique =
        Prefixed_Name(ossysmlv2, "feature_IsNonunique") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:feature_IsOrdered</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether an order exists for the values of this Feature or not.</para>
    /// labels<para>feature_IsOrdered</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#feature_IsOrdered">http://open-services.net/ns/sysmlv2#feature_IsOrdered</seealso>
    let feature_IsOrdered =
        Prefixed_Name(ossysmlv2, "feature_IsOrdered") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:feature_IsPortion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether the values of this Feature are contained in the space and time of instances of the domain of the Feature and represent the same thing as those instances.</para>
    /// labels<para>feature_IsPortion</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#feature_IsPortion">http://open-services.net/ns/sysmlv2#feature_IsPortion</seealso>
    let feature_IsPortion =
        Prefixed_Name(ossysmlv2, "feature_IsPortion") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:feature_OwnedFeatureChaining</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ownedRelationships of this Feature that are FeatureChainings, for which the Feature will be the featureChained.</para>
    /// labels<para>feature_OwnedFeatureChaining</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#feature_OwnedFeatureChaining">http://open-services.net/ns/sysmlv2#feature_OwnedFeatureChaining</seealso>
    let feature_OwnedFeatureChaining =
        Prefixed_Name(ossysmlv2, "feature_OwnedFeatureChaining") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:feature_OwnedFeatureInverting</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ownedRelationships of this Feature that are FeatureInvertings and for which the Feature is the featureInverted.</para>
    /// labels<para>feature_OwnedFeatureInverting</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#feature_OwnedFeatureInverting">http://open-services.net/ns/sysmlv2#feature_OwnedFeatureInverting</seealso>
    let feature_OwnedFeatureInverting =
        Prefixed_Name(ossysmlv2, "feature_OwnedFeatureInverting") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:feature_OwnedSubsetting</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ownedSpecializations of this Feature that are Subsettings, for which the Feature is the subsettingFeature.</para>
    /// labels<para>feature_OwnedSubsetting</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#feature_OwnedSubsetting">http://open-services.net/ns/sysmlv2#feature_OwnedSubsetting</seealso>
    let feature_OwnedSubsetting =
        Prefixed_Name(ossysmlv2, "feature_OwnedSubsetting") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:feature_OwnedTypeFeaturing</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ownedRelationships of this Feature that are TypeFeaturings and for which the Feature is the featureOfType.</para>
    /// labels<para>feature_OwnedTypeFeaturing</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#feature_OwnedTypeFeaturing">http://open-services.net/ns/sysmlv2#feature_OwnedTypeFeaturing</seealso>
    let feature_OwnedTypeFeaturing =
        Prefixed_Name(ossysmlv2, "feature_OwnedTypeFeaturing") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:feature_OwnedTyping</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ownedSpecializations of this Feature that are FeatureTypings, for which the Feature is the typedFeature.</para>
    /// labels<para>feature_OwnedTyping</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#feature_OwnedTyping">http://open-services.net/ns/sysmlv2#feature_OwnedTyping</seealso>
    let feature_OwnedTyping =
        Prefixed_Name(ossysmlv2, "feature_OwnedTyping") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:feature_OwningType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Type that is the owningType of the owningFeatureMembership of this Feature.</para>
    /// labels<para>feature_OwningType</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#feature_OwningType">http://open-services.net/ns/sysmlv2#feature_OwningType</seealso>
    let feature_OwningType =
        Prefixed_Name(ossysmlv2, "feature_OwningType") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:feature_Type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Types that restrict the values of this Feature, such that the values must be instances of all the types. The types of a Feature are derived from its typings and the types of its subsettings. If the Feature is chained, then the types of the last Feature in the chain are also types of the chained Feature.</para>
    /// labels<para>feature_Type</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#feature_Type">http://open-services.net/ns/sysmlv2#feature_Type</seealso>
    let feature_Type = Prefixed_Name(ossysmlv2, "feature_Type") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:featuring_Feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Feature that is featured by the featuringType.</para>
    /// labels<para>featuring_Feature</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#featuring_Feature">http://open-services.net/ns/sysmlv2#featuring_Feature</seealso>
    let featuring_Feature =
        Prefixed_Name(ossysmlv2, "featuring_Feature") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:forLoopActionUsage_SeqArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Expression whose result provides the sequence of values to which the loopVariable is set for each iterative performance of the bodyAction. It is the Expression whose result is bound to the seq input parameter of this ForLoopActionUsage.</para>
    /// labels<para>forLoopActionUsage_SeqArgument</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#forLoopActionUsage_SeqArgument">http://open-services.net/ns/sysmlv2#forLoopActionUsage_SeqArgument</seealso>
    let forLoopActionUsage_SeqArgument =
        Prefixed_Name(ossysmlv2, "forLoopActionUsage_SeqArgument") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:framedConcernMembership_OwnedConcern</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ConcernUsage that is the ownedConstraint of this FramedConcernMembership.</para>
    /// labels<para>framedConcernMembership_OwnedConcern</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#framedConcernMembership_OwnedConcern">http://open-services.net/ns/sysmlv2#framedConcernMembership_OwnedConcern</seealso>
    let framedConcernMembership_OwnedConcern =
        Prefixed_Name(ossysmlv2, "framedConcernMembership_OwnedConcern") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:function_IsModelLevelEvaluable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether this Function can be used as the function of a model-level evaluable InvocationExpression. Certain Functions from the Kernel Functions Library are considered to have isModelLevelEvaluable = true. For all other Functions it is false.</para>
    /// labels<para>function_IsModelLevelEvaluable</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#function_IsModelLevelEvaluable">http://open-services.net/ns/sysmlv2#function_IsModelLevelEvaluable</seealso>
    let function_IsModelLevelEvaluable =
        Prefixed_Name(ossysmlv2, "function_IsModelLevelEvaluable") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:function_Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The result parameter of the Function, which is owned by the Function via a ReturnParameterMembership.</para>
    /// labels<para>function_Result</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#function_Result">http://open-services.net/ns/sysmlv2#function_Result</seealso>
    let function_Result = Prefixed_Name(ossysmlv2, "function_Result") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:import_ImportOwningNamespace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Namespace into which Memberships are imported by this Import, which must be the owningRelatedElement of the Import.</para>
    /// labels<para>import_ImportOwningNamespace</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#import_ImportOwningNamespace">http://open-services.net/ns/sysmlv2#import_ImportOwningNamespace</seealso>
    let import_ImportOwningNamespace =
        Prefixed_Name(ossysmlv2, "import_ImportOwningNamespace") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:import_ImportedElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The effectively imported Element for this Import. For a MembershipImport, this is the memberElement of the importedMembership. For a NamespaceImport, it is the importedNamespace.</para>
    /// labels<para>import_ImportedElement</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#import_ImportedElement">http://open-services.net/ns/sysmlv2#import_ImportedElement</seealso>
    let import_ImportedElement =
        Prefixed_Name(ossysmlv2, "import_ImportedElement") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:import_IsImportAll</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether to import memberships without regard to declared visibility.</para>
    /// labels<para>import_IsImportAll</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#import_IsImportAll">http://open-services.net/ns/sysmlv2#import_IsImportAll</seealso>
    let import_IsImportAll =
        Prefixed_Name(ossysmlv2, "import_IsImportAll") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:import_Visibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The visibility level of the imported members from this Import relative to the importOwningNamespace.</para>
    /// labels<para>import_Visibility</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#import_Visibility">http://open-services.net/ns/sysmlv2#import_Visibility</seealso>
    let import_Visibility =
        Prefixed_Name(ossysmlv2, "import_Visibility") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:includeUseCaseUsage_UseCaseIncluded</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The UseCaseUsage to be included by this IncludeUseCaseUsage. It is the performedAction of the IncludeUseCaseUsage considered as a PerformActionUsage, which must be a UseCaseUsage.</para>
    /// labels<para>includeUseCaseUsage_UseCaseIncluded</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#includeUseCaseUsage_UseCaseIncluded">http://open-services.net/ns/sysmlv2#includeUseCaseUsage_UseCaseIncluded</seealso>
    let includeUseCaseUsage_UseCaseIncluded =
        Prefixed_Name(ossysmlv2, "includeUseCaseUsage_UseCaseIncluded") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:interfaceDefinition_InterfaceEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The PortUsages that are the connectionEnds of this InterfaceDefinition.
    ///
    /// .</para>
    /// labels<para>interfaceDefinition_InterfaceEnd</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#interfaceDefinition_InterfaceEnd">http://open-services.net/ns/sysmlv2#interfaceDefinition_InterfaceEnd</seealso>
    let interfaceDefinition_InterfaceEnd =
        Prefixed_Name(ossysmlv2, "interfaceDefinition_InterfaceEnd") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:intersecting_IntersectingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Type that partly determines interpretations of typeIntersected, as described in Type::intersectingType.</para>
    /// labels<para>intersecting_IntersectingType</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#intersecting_IntersectingType">http://open-services.net/ns/sysmlv2#intersecting_IntersectingType</seealso>
    let intersecting_IntersectingType =
        Prefixed_Name(ossysmlv2, "intersecting_IntersectingType") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:intersecting_TypeIntersected</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Type with interpretations partly determined by intersectingType, as described in Type::intersectingType.</para>
    /// labels<para>intersecting_TypeIntersected</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#intersecting_TypeIntersected">http://open-services.net/ns/sysmlv2#intersecting_TypeIntersected</seealso>
    let intersecting_TypeIntersected =
        Prefixed_Name(ossysmlv2, "intersecting_TypeIntersected") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:invariant_IsNegated</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether this Invariant is asserted to be false rather than true.</para>
    /// labels<para>invariant_IsNegated</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#invariant_IsNegated">http://open-services.net/ns/sysmlv2#invariant_IsNegated</seealso>
    let invariant_IsNegated =
        Prefixed_Name(ossysmlv2, "invariant_IsNegated") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:invocationExpression_Argument</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The value Expressions of the FeatureValues of the owned input parameters of the InvocationExpression.</para>
    /// labels<para>invocationExpression_Argument</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#invocationExpression_Argument">http://open-services.net/ns/sysmlv2#invocationExpression_Argument</seealso>
    let invocationExpression_Argument =
        Prefixed_Name(ossysmlv2, "invocationExpression_Argument") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:invocationExpression_Operand</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>operand.</para>
    /// labels<para>invocationExpression_Operand</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#invocationExpression_Operand">http://open-services.net/ns/sysmlv2#invocationExpression_Operand</seealso>
    let invocationExpression_Operand =
        Prefixed_Name(ossysmlv2, "invocationExpression_Operand") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:itemFlow_ItemType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The type of values transferred, which is the type of the itemFeature of the ItemFlow.</para>
    /// labels<para>itemFlow_ItemType</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#itemFlow_ItemType">http://open-services.net/ns/sysmlv2#itemFlow_ItemType</seealso>
    let itemFlow_ItemType =
        Prefixed_Name(ossysmlv2, "itemFlow_ItemType") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:itemFlow_SourceOutputFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Feature that provides the items carried by the ItemFlow. It must be an owned output of the source of the ItemFlow.</para>
    /// labels<para>itemFlow_SourceOutputFeature</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#itemFlow_SourceOutputFeature">http://open-services.net/ns/sysmlv2#itemFlow_SourceOutputFeature</seealso>
    let itemFlow_SourceOutputFeature =
        Prefixed_Name(ossysmlv2, "itemFlow_SourceOutputFeature") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:itemFlow_TargetInputFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Feature that receives the values carried by the ItemFlow. It must be an owned output of the target participant of the ItemFlow.</para>
    /// labels<para>itemFlow_TargetInputFeature</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#itemFlow_TargetInputFeature">http://open-services.net/ns/sysmlv2#itemFlow_TargetInputFeature</seealso>
    let itemFlow_TargetInputFeature =
        Prefixed_Name(ossysmlv2, "itemFlow_TargetInputFeature") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:itemUsage_ItemDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Structures that are the definitions of this ItemUsage. Nominally, these are ItemDefinitions, but other kinds of Kernel Structures are also allowed, to permit use of Structures from the Kernel Library.</para>
    /// labels<para>itemUsage_ItemDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#itemUsage_ItemDefinition">http://open-services.net/ns/sysmlv2#itemUsage_ItemDefinition</seealso>
    let itemUsage_ItemDefinition =
        Prefixed_Name(ossysmlv2, "itemUsage_ItemDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:libraryPackage_IsStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether this LibraryPackage contains a standard library model. This should only be set to true for LibraryPackages in the standard Kernel Model Libraries or in normative model libraries for a language built on KerML.</para>
    /// labels<para>libraryPackage_IsStandard</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#libraryPackage_IsStandard">http://open-services.net/ns/sysmlv2#libraryPackage_IsStandard</seealso>
    let libraryPackage_IsStandard =
        Prefixed_Name(ossysmlv2, "libraryPackage_IsStandard") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:literalBoolean_Value</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Boolean value that is the result of evaluating this LiteralBoolean.</para>
    /// labels<para>literalBoolean_Value</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#literalBoolean_Value">http://open-services.net/ns/sysmlv2#literalBoolean_Value</seealso>
    let literalBoolean_Value =
        Prefixed_Name(ossysmlv2, "literalBoolean_Value") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:literalInteger_Value</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Integer value that is the result of evaluating this LiteralInteger.</para>
    /// labels<para>literalInteger_Value</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#literalInteger_Value">http://open-services.net/ns/sysmlv2#literalInteger_Value</seealso>
    let literalInteger_Value =
        Prefixed_Name(ossysmlv2, "literalInteger_Value") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:literalRational_Value</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The value whose rational approximation is the result of evaluating this LiteralRational.</para>
    /// labels<para>literalRational_Value</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#literalRational_Value">http://open-services.net/ns/sysmlv2#literalRational_Value</seealso>
    let literalRational_Value =
        Prefixed_Name(ossysmlv2, "literalRational_Value") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:literalString_Value</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The String value that is the result of evaluating this LiteralString.</para>
    /// labels<para>literalString_Value</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#literalString_Value">http://open-services.net/ns/sysmlv2#literalString_Value</seealso>
    let literalString_Value =
        Prefixed_Name(ossysmlv2, "literalString_Value") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:loopActionUsage_BodyAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ActionUsage to be performed repeatedly by the LoopActionUsage. It is the second parameter of the LoopActionUsage.</para>
    /// labels<para>loopActionUsage_BodyAction</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#loopActionUsage_BodyAction">http://open-services.net/ns/sysmlv2#loopActionUsage_BodyAction</seealso>
    let loopActionUsage_BodyAction =
        Prefixed_Name(ossysmlv2, "loopActionUsage_BodyAction") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:membershipImport_ImportedMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Membership to be imported.</para>
    /// labels<para>membershipImport_ImportedMembership</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#membershipImport_ImportedMembership">http://open-services.net/ns/sysmlv2#membershipImport_ImportedMembership</seealso>
    let membershipImport_ImportedMembership =
        Prefixed_Name(ossysmlv2, "membershipImport_ImportedMembership") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:membership_MemberElementId</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The elementId of the memberElement.</para>
    /// labels<para>membership_MemberElementId</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#membership_MemberElementId">http://open-services.net/ns/sysmlv2#membership_MemberElementId</seealso>
    let membership_MemberElementId =
        Prefixed_Name(ossysmlv2, "membership_MemberElementId") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:membership_MemberName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The name of the memberElement relative to the membershipOwningNamespace.</para>
    /// labels<para>membership_MemberName</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#membership_MemberName">http://open-services.net/ns/sysmlv2#membership_MemberName</seealso>
    let membership_MemberName =
        Prefixed_Name(ossysmlv2, "membership_MemberName") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:membership_MemberShortName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The short name of the memberElement relative to the membershipOwningNamespace.</para>
    /// labels<para>membership_MemberShortName</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#membership_MemberShortName">http://open-services.net/ns/sysmlv2#membership_MemberShortName</seealso>
    let membership_MemberShortName =
        Prefixed_Name(ossysmlv2, "membership_MemberShortName") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:membership_MembershipOwningNamespace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Namespace of which the memberElement becomes a member due to this Membership.</para>
    /// labels<para>membership_MembershipOwningNamespace</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#membership_MembershipOwningNamespace">http://open-services.net/ns/sysmlv2#membership_MembershipOwningNamespace</seealso>
    let membership_MembershipOwningNamespace =
        Prefixed_Name(ossysmlv2, "membership_MembershipOwningNamespace") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:membership_Visibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether or not the Membership of the memberElement in the membershipOwningNamespace is publicly visible outside that Namespace.</para>
    /// labels<para>membership_Visibility</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#membership_Visibility">http://open-services.net/ns/sysmlv2#membership_Visibility</seealso>
    let membership_Visibility =
        Prefixed_Name(ossysmlv2, "membership_Visibility") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:usage_NestedTransition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The TransitionUsages that are nestedUsages of this Usage.</para>
    /// labels<para>usage_NestedTransition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#usage_NestedTransition">http://open-services.net/ns/sysmlv2#usage_NestedTransition</seealso>
    let usage_NestedTransition =
        Prefixed_Name(ossysmlv2, "usage_NestedTransition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:usage_NestedUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Usages that are ownedFeatures of this Usage.</para>
    /// labels<para>usage_NestedUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#usage_NestedUsage">http://open-services.net/ns/sysmlv2#usage_NestedUsage</seealso>
    let usage_NestedUsage =
        Prefixed_Name(ossysmlv2, "usage_NestedUsage") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:usage_NestedUseCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The UseCaseUsages that are nestedUsages of this Usage.</para>
    /// labels<para>usage_NestedUseCase</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#usage_NestedUseCase">http://open-services.net/ns/sysmlv2#usage_NestedUseCase</seealso>
    let usage_NestedUseCase =
        Prefixed_Name(ossysmlv2, "usage_NestedUseCase") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:usage_NestedVerificationCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The VerificationCaseUsages that are nestedUsages of this Usage.</para>
    /// labels<para>usage_NestedVerificationCase</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#usage_NestedVerificationCase">http://open-services.net/ns/sysmlv2#usage_NestedVerificationCase</seealso>
    let usage_NestedVerificationCase =
        Prefixed_Name(ossysmlv2, "usage_NestedVerificationCase") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:usage_NestedView</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ViewUsages that are nestedUsages of this Usage.</para>
    /// labels<para>usage_NestedView</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#usage_NestedView">http://open-services.net/ns/sysmlv2#usage_NestedView</seealso>
    let usage_NestedView = Prefixed_Name(ossysmlv2, "usage_NestedView") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:usage_OwningUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Usage in which this Usage is nested (if any).</para>
    /// labels<para>usage_OwningUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#usage_OwningUsage">http://open-services.net/ns/sysmlv2#usage_OwningUsage</seealso>
    let usage_OwningUsage =
        Prefixed_Name(ossysmlv2, "usage_OwningUsage") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:usage_Usage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Usages that are features of this Usage (not necessarily owned).</para>
    /// labels<para>usage_Usage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#usage_Usage">http://open-services.net/ns/sysmlv2#usage_Usage</seealso>
    let usage_Usage = Prefixed_Name(ossysmlv2, "usage_Usage") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:usage_Variant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Usages which represent the variants of this Usage as a variation point Usage, if isVariation = true. If isVariation = false, then there must be no variants.</para>
    /// labels<para>usage_Variant</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#usage_Variant">http://open-services.net/ns/sysmlv2#usage_Variant</seealso>
    let usage_Variant = Prefixed_Name(ossysmlv2, "usage_Variant") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:usage_VariantMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ownedMemberships of this Usage that are VariantMemberships. If isVariation = true, then this must be all memberships of the Usage. If isVariation = false, then variantMembershipmust be empty.</para>
    /// labels<para>usage_VariantMembership</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#usage_VariantMembership">http://open-services.net/ns/sysmlv2#usage_VariantMembership</seealso>
    let usage_VariantMembership =
        Prefixed_Name(ossysmlv2, "usage_VariantMembership") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:useCaseDefinition_IncludedUseCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The UseCaseUsages that are included by this UseCaseDefinition, which are the useCaseIncludeds of the IncludeUseCaseUsages owned by this UseCaseDefinition.</para>
    /// labels<para>useCaseDefinition_IncludedUseCase</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#useCaseDefinition_IncludedUseCase">http://open-services.net/ns/sysmlv2#useCaseDefinition_IncludedUseCase</seealso>
    let useCaseDefinition_IncludedUseCase =
        Prefixed_Name(ossysmlv2, "useCaseDefinition_IncludedUseCase") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:useCaseUsage_UseCaseDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The UseCaseDefinition that is the definition of this UseCaseUsage.</para>
    /// labels<para>useCaseUsage_UseCaseDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#useCaseUsage_UseCaseDefinition">http://open-services.net/ns/sysmlv2#useCaseUsage_UseCaseDefinition</seealso>
    let useCaseUsage_UseCaseDefinition =
        Prefixed_Name(ossysmlv2, "useCaseUsage_UseCaseDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:variantMembership_OwnedVariantUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Usage that represents a variant in the context of the owningVariationDefinition or owningVariationUsage.</para>
    /// labels<para>variantMembership_OwnedVariantUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#variantMembership_OwnedVariantUsage">http://open-services.net/ns/sysmlv2#variantMembership_OwnedVariantUsage</seealso>
    let variantMembership_OwnedVariantUsage =
        Prefixed_Name(ossysmlv2, "variantMembership_OwnedVariantUsage") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:verificationCaseDefinition_VerifiedRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The RequirementUsages verified by this VerificationCaseDefinition, which are the verifiedRequirements of all RequirementVerificationMemberships of the objectiveRequirement.</para>
    /// labels<para>verificationCaseDefinition_VerifiedRequirement</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#verificationCaseDefinition_VerifiedRequirement">http://open-services.net/ns/sysmlv2#verificationCaseDefinition_VerifiedRequirement</seealso>
    let verificationCaseDefinition_VerifiedRequirement =
        Prefixed_Name(ossysmlv2, "verificationCaseDefinition_VerifiedRequirement") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:verificationCaseUsage_VerificationCaseDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The VerificationCase that is the definition of this VerificationCaseUsage.</para>
    /// labels<para>verificationCaseUsage_VerificationCaseDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#verificationCaseUsage_VerificationCaseDefinition">http://open-services.net/ns/sysmlv2#verificationCaseUsage_VerificationCaseDefinition</seealso>
    let verificationCaseUsage_VerificationCaseDefinition =
        Prefixed_Name(ossysmlv2, "verificationCaseUsage_VerificationCaseDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:verificationCaseUsage_VerifiedRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The RequirementUsages verified by this VerificationCaseUsage, which are the verifiedRequirements of all RequirementVerificationMemberships of the objectiveRequirement.</para>
    /// labels<para>verificationCaseUsage_VerifiedRequirement</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#verificationCaseUsage_VerifiedRequirement">http://open-services.net/ns/sysmlv2#verificationCaseUsage_VerifiedRequirement</seealso>
    let verificationCaseUsage_VerifiedRequirement =
        Prefixed_Name(ossysmlv2, "verificationCaseUsage_VerifiedRequirement") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:viewDefinition_ViewRendering</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The RenderingUsage to be used to render views defined by this ViewDefinition, which is the referencedRendering of the ViewRenderingMembership of the ViewDefinition.</para>
    /// labels<para>viewDefinition_ViewRendering</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#viewDefinition_ViewRendering">http://open-services.net/ns/sysmlv2#viewDefinition_ViewRendering</seealso>
    let viewDefinition_ViewRendering =
        Prefixed_Name(ossysmlv2, "viewDefinition_ViewRendering") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:viewRenderingMembership_OwnedRendering</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The owned RenderingUsage that is either itself the referencedRendering or subsets the referencedRendering.</para>
    /// labels<para>viewRenderingMembership_OwnedRendering</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#viewRenderingMembership_OwnedRendering">http://open-services.net/ns/sysmlv2#viewRenderingMembership_OwnedRendering</seealso>
    let viewRenderingMembership_OwnedRendering =
        Prefixed_Name(ossysmlv2, "viewRenderingMembership_OwnedRendering") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:viewRenderingMembership_ReferencedRendering</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para> The RenderingUsage that is referenced through this ViewRenderingMembership. It is the referencedFeature of the ownedReferenceSubsetting for the ownedRendering, if there is one, and, otherwise, the ownedRendering itself.</para>
    /// labels<para>viewRenderingMembership_ReferencedRendering</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#viewRenderingMembership_ReferencedRendering">http://open-services.net/ns/sysmlv2#viewRenderingMembership_ReferencedRendering</seealso>
    let viewRenderingMembership_ReferencedRendering =
        Prefixed_Name(ossysmlv2, "viewRenderingMembership_ReferencedRendering") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:viewUsage_ExposedElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Elements that are exposed by this ViewUsage, which are those memberElements of the imported Memberships from all the Expose Relationships that meet all the owned and inherited viewConditions.</para>
    /// labels<para>viewUsage_ExposedElement</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#viewUsage_ExposedElement">http://open-services.net/ns/sysmlv2#viewUsage_ExposedElement</seealso>
    let viewUsage_ExposedElement =
        Prefixed_Name(ossysmlv2, "viewUsage_ExposedElement") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:viewUsage_SatisfiedViewpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The nestedRequirements of this ViewUsage that are ViewpointUsages for (additional) viewpoints satisfied by the ViewUsage.</para>
    /// labels<para>viewUsage_SatisfiedViewpoint</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#viewUsage_SatisfiedViewpoint">http://open-services.net/ns/sysmlv2#viewUsage_SatisfiedViewpoint</seealso>
    let viewUsage_SatisfiedViewpoint =
        Prefixed_Name(ossysmlv2, "viewUsage_SatisfiedViewpoint") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:viewpointDefinition_ViewpointStakeholder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The PartUsages that identify the stakeholders with concerns framed by this ViewpointDefinition, which are the owned and inherited stakeholderParameters of the framedConcerns of this ViewpointDefinition.</para>
    /// labels<para>viewpointDefinition_ViewpointStakeholder</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#viewpointDefinition_ViewpointStakeholder">http://open-services.net/ns/sysmlv2#viewpointDefinition_ViewpointStakeholder</seealso>
    let viewpointDefinition_ViewpointStakeholder =
        Prefixed_Name(ossysmlv2, "viewpointDefinition_ViewpointStakeholder") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:viewpointUsage_ViewpointDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ViewpointDefinition that is the definition of this ViewpointUsage.</para>
    /// labels<para>viewpointUsage_ViewpointDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#viewpointUsage_ViewpointDefinition">http://open-services.net/ns/sysmlv2#viewpointUsage_ViewpointDefinition</seealso>
    let viewpointUsage_ViewpointDefinition =
        Prefixed_Name(ossysmlv2, "viewpointUsage_ViewpointDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:viewpointUsage_ViewpointStakeholder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The PartUsages that identify the stakeholders with concerns framed by this ViewpointUsage, which are the owned and inherited stakeholderParameters of the framedConcerns of this ViewpointUsage.</para>
    /// labels<para>viewpointUsage_ViewpointStakeholder</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#viewpointUsage_ViewpointStakeholder">http://open-services.net/ns/sysmlv2#viewpointUsage_ViewpointStakeholder</seealso>
    let viewpointUsage_ViewpointStakeholder =
        Prefixed_Name(ossysmlv2, "viewpointUsage_ViewpointStakeholder") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:visibilityKind_Private</para>
    /// </summary>
    /// <remarks>
    ///   <para>ossysmlv2:VisibilityKind</para>
    ///   <para>Indicates a Membership is not visible outside its owning Namespace.</para>
    /// labels<para>visibilityKind_Private</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#visibilityKind_Private">http://open-services.net/ns/sysmlv2#visibilityKind_Private</seealso>
    let visibilityKind_Private =
        Prefixed_Name(ossysmlv2, "visibilityKind_Private") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:visibilityKind_Protected</para>
    /// </summary>
    /// <remarks>
    ///   <para>ossysmlv2:VisibilityKind</para>
    ///   <para>An intermediate level of visibility between public and private. By default, it is equivalent to private for the purposes of normal access to and import of Elements from a Namespace. However, other Relationships may be specified to include Memberships with protected visibility in the list of memberships for a Namespace (e.g., Specialization).</para>
    /// labels<para>visibilityKind_Protected</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#visibilityKind_Protected">http://open-services.net/ns/sysmlv2#visibilityKind_Protected</seealso>
    let visibilityKind_Protected =
        Prefixed_Name(ossysmlv2, "visibilityKind_Protected") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:visibilityKind_Public</para>
    /// </summary>
    /// <remarks>
    ///   <para>ossysmlv2:VisibilityKind</para>
    ///   <para>Indicates that a Membership is publicly visible outside its owning Namespace.</para>
    /// labels<para>visibilityKind_Public</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#visibilityKind_Public">http://open-services.net/ns/sysmlv2#visibilityKind_Public</seealso>
    let visibilityKind_Public =
        Prefixed_Name(ossysmlv2, "visibilityKind_Public") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:whileLoopActionUsage_UntilArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Expression whose result, if false, determines that the bodyAction should continue to be performed. It is the (optional) third owned parameter of the WhileLoopActionUsage.</para>
    /// labels<para>whileLoopActionUsage_UntilArgument</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#whileLoopActionUsage_UntilArgument">http://open-services.net/ns/sysmlv2#whileLoopActionUsage_UntilArgument</seealso>
    let whileLoopActionUsage_UntilArgument =
        Prefixed_Name(ossysmlv2, "whileLoopActionUsage_UntilArgument") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:whileLoopActionUsage_WhileArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Expression whose result, if true, determines that the bodyAction should continue to be performed. It is the first owned parameter of the WhileLoopActionUsage.</para>
    /// labels<para>whileLoopActionUsage_WhileArgument</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#whileLoopActionUsage_WhileArgument">http://open-services.net/ns/sysmlv2#whileLoopActionUsage_WhileArgument</seealso>
    let whileLoopActionUsage_WhileArgument =
        Prefixed_Name(ossysmlv2, "whileLoopActionUsage_WhileArgument") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:Definition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Definition is a Classifier of Usages. The actual kinds of Definition that may appear in a model are given by the subclasses of Definition (possibly as extended with user-defined SemanticMetadata).</para>
    /// labels<para>Definition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Definition">http://open-services.net/ns/sysmlv2#Definition</seealso>
    let Definition = Prefixed_Name(ossysmlv2, "Definition") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:Class</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Class is a Classifier of things (in the universe) that can be distinguished without regard to how they are related to other things (via Features). This means multiple things classified by the same Class can be distinguished, even when they are related other things in exactly the same way.</para>
    /// labels<para>Class</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Class">http://open-services.net/ns/sysmlv2#Class</seealso>
    let Class = Prefixed_Name(ossysmlv2, "Class") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:BooleanExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A BooleanExpression is a Boolean-valued Expression whose type is a Predicate. It represents a logical condition resulting from the evaluation of the Predicate.</para>
    /// labels<para>BooleanExpression</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#BooleanExpression">http://open-services.net/ns/sysmlv2#BooleanExpression</seealso>
    let BooleanExpression =
        Prefixed_Name(ossysmlv2, "BooleanExpression") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:Expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An Expression is a Step that is typed by a Function. An Expression that also has a Function as its featuringType is a computational step within that Function. An Expression always has a single result parameter, which redefines the result parameter of its defining function. This allows Expressions to be interconnected in tree structures, in which inputs to each Expression in the tree are determined as the results of other Expression in the tree.</para>
    /// labels<para>Expression</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Expression">http://open-services.net/ns/sysmlv2#Expression</seealso>
    let Expression = Prefixed_Name(ossysmlv2, "Expression") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:Function</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Function is a Behavior that has an out parameter that is identified as its result. A Function represents the performance of a calculation that produces the values of its result parameter. This calculation may be decomposed into Expressions that are steps of the Function.</para>
    /// labels<para>Function</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Function">http://open-services.net/ns/sysmlv2#Function</seealso>
    let Function = Prefixed_Name(ossysmlv2, "Function") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:CalculationUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A CalculationUsage is an ActionUsage that is also an Expression, and, so, is typed by a Function. Nominally, if the type is a CalculationDefinition, a CalculationUsage is a Usage of that CalculationDefinition within a system. However, other kinds of kernel Functions are also allowed, to permit use of Functions from the Kernel Model Libraries.</para>
    /// labels<para>CalculationUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#CalculationUsage">http://open-services.net/ns/sysmlv2#CalculationUsage</seealso>
    let CalculationUsage = Prefixed_Name(ossysmlv2, "CalculationUsage") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:Succession</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Succession is a binary Connector that requires its relatedFeatures to happen separately in time.</para>
    /// labels<para>Succession</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Succession">http://open-services.net/ns/sysmlv2#Succession</seealso>
    let Succession = Prefixed_Name(ossysmlv2, "Succession") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:SuccessionItemFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SuccessionItemFlow is an ItemFlow that also provides temporal ordering. It classifies Transfers that cannot start until the source Occurrence has completed and that must complete before the target Occurrence can start.</para>
    /// labels<para>SuccessionItemFlow</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#SuccessionItemFlow">http://open-services.net/ns/sysmlv2#SuccessionItemFlow</seealso>
    let SuccessionItemFlow =
        Prefixed_Name(ossysmlv2, "SuccessionItemFlow") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:TransitionUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A TransitionUsage is an ActionUsage representing a triggered transition between ActionUsages or StateUsages. When triggered by a triggerAction, when its guardExpression is true, the TransitionUsage asserts that its source is exited, then its effectAction (if any) is performed, and then its target is entered.</para>
    /// labels<para>TransitionUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#TransitionUsage">http://open-services.net/ns/sysmlv2#TransitionUsage</seealso>
    let TransitionUsage = Prefixed_Name(ossysmlv2, "TransitionUsage") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:feature_IsEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether or not the this Feature is an end Feature, requiring a different interpretation of the multiplicity of the Feature.</para>
    /// labels<para>feature_IsEnd</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#feature_IsEnd">http://open-services.net/ns/sysmlv2#feature_IsEnd</seealso>
    let feature_IsEnd = Prefixed_Name(ossysmlv2, "feature_IsEnd") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:feature_IsReadOnly</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether the values of this Feature can change over the lifetime of an instance of the domain.</para>
    /// labels<para>feature_IsReadOnly</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#feature_IsReadOnly">http://open-services.net/ns/sysmlv2#feature_IsReadOnly</seealso>
    let feature_IsReadOnly =
        Prefixed_Name(ossysmlv2, "feature_IsReadOnly") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:feature_IsUnique</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether or not values for this Feature must have no duplicates or not.</para>
    /// labels<para>feature_IsUnique</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#feature_IsUnique">http://open-services.net/ns/sysmlv2#feature_IsUnique</seealso>
    let feature_IsUnique = Prefixed_Name(ossysmlv2, "feature_IsUnique") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:feature_OwnedRedefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ownedSubsettings of this Feature that are Redefinitions, for which the Feature is the redefiningFeature.</para>
    /// labels<para>feature_OwnedRedefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#feature_OwnedRedefinition">http://open-services.net/ns/sysmlv2#feature_OwnedRedefinition</seealso>
    let feature_OwnedRedefinition =
        Prefixed_Name(ossysmlv2, "feature_OwnedRedefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:feature_OwnedReferenceSubsetting</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The one ownedSubsetting of this Feature, if any, that is a ReferenceSubsetting, for which the Feature is the referencingFeature.</para>
    /// labels<para>feature_OwnedReferenceSubsetting</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#feature_OwnedReferenceSubsetting">http://open-services.net/ns/sysmlv2#feature_OwnedReferenceSubsetting</seealso>
    let feature_OwnedReferenceSubsetting =
        Prefixed_Name(ossysmlv2, "feature_OwnedReferenceSubsetting") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:feature_OwningFeatureMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The FeatureMembership that owns this Feature as an ownedMemberFeature, determining its owningType.</para>
    /// labels<para>feature_OwningFeatureMembership</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#feature_OwningFeatureMembership">http://open-services.net/ns/sysmlv2#feature_OwningFeatureMembership</seealso>
    let feature_OwningFeatureMembership =
        Prefixed_Name(ossysmlv2, "feature_OwningFeatureMembership") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:featuring_Type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Type that features the featureOfType.</para>
    /// labels<para>featuring_Type</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#featuring_Type">http://open-services.net/ns/sysmlv2#featuring_Type</seealso>
    let featuring_Type = Prefixed_Name(ossysmlv2, "featuring_Type") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:flowConnectionUsage_FlowConnectionDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Interactions that are the types of this FlowConnectionUsage. Nominally, these are FlowConnectionDefinitions, but other kinds of Kernel Interactions are also allowed, to permit use of Interactions from the Kernel Model Libraries.</para>
    /// labels<para>flowConnectionUsage_FlowConnectionDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#flowConnectionUsage_FlowConnectionDefinition">http://open-services.net/ns/sysmlv2#flowConnectionUsage_FlowConnectionDefinition</seealso>
    let flowConnectionUsage_FlowConnectionDefinition =
        Prefixed_Name(ossysmlv2, "flowConnectionUsage_FlowConnectionDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:forLoopActionUsage_LoopVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ownedFeature of this ForLoopActionUsage that acts as the loop variable, which is assigned the successive values of the input sequence on each iteration. It is the ownedFeature that redefines ForLoopAction::var.</para>
    /// labels<para>forLoopActionUsage_LoopVariable</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#forLoopActionUsage_LoopVariable">http://open-services.net/ns/sysmlv2#forLoopActionUsage_LoopVariable</seealso>
    let forLoopActionUsage_LoopVariable =
        Prefixed_Name(ossysmlv2, "forLoopActionUsage_LoopVariable") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:framedConcernMembership_ReferencedConcern</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para> The ConcernUsage that is referenced through this FramedConcernMembership. It is the referencedConstraint of the FramedConcernMembership considered as a RequirementConstraintMembership, which must be a ConcernUsage.</para>
    /// labels<para>framedConcernMembership_ReferencedConcern</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#framedConcernMembership_ReferencedConcern">http://open-services.net/ns/sysmlv2#framedConcernMembership_ReferencedConcern</seealso>
    let framedConcernMembership_ReferencedConcern =
        Prefixed_Name(ossysmlv2, "framedConcernMembership_ReferencedConcern") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:function_Expression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Expressions that are steps in the calculation of the result of this Function.</para>
    /// labels<para>function_Expression</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#function_Expression">http://open-services.net/ns/sysmlv2#function_Expression</seealso>
    let function_Expression =
        Prefixed_Name(ossysmlv2, "function_Expression") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:ifActionUsage_ElseAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ActionUsage that is to be performed if the result of the ifArgument is false. It is the (optional) third parameter of the IfActionUsage.</para>
    /// labels<para>ifActionUsage_ElseAction</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#ifActionUsage_ElseAction">http://open-services.net/ns/sysmlv2#ifActionUsage_ElseAction</seealso>
    let ifActionUsage_ElseAction =
        Prefixed_Name(ossysmlv2, "ifActionUsage_ElseAction") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:ifActionUsage_IfArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Expression whose result determines whether the thenAction or (optionally) the elseAction is performed. It is the first parameter of the IfActionUsage.</para>
    /// labels<para>ifActionUsage_IfArgument</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#ifActionUsage_IfArgument">http://open-services.net/ns/sysmlv2#ifActionUsage_IfArgument</seealso>
    let ifActionUsage_IfArgument =
        Prefixed_Name(ossysmlv2, "ifActionUsage_IfArgument") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:NamespaceExpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A NamespaceExpose is an Expose Relationship that exposes the Memberships of a specific importedNamespace and, if isRecursive = true, additional Memberships recursively.</para>
    /// labels<para>NamespaceExpose</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#NamespaceExpose">http://open-services.net/ns/sysmlv2#NamespaceExpose</seealso>
    let NamespaceExpose = Prefixed_Name(ossysmlv2, "NamespaceExpose") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:PortConjugation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A PortConjugation is a Conjugation Relationship between a PortDefinition and its corresponding ConjugatedPortDefinition. As a result of this Relationship, the ConjugatedPortDefinition inherits all the features of the original PortDefinition, but input flows of the original PortDefinition become outputs on the ConjugatedPortDefinition and output flows of the original PortDefinition become inputs on the ConjugatedPortDefinition.</para>
    /// labels<para>PortConjugation</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#PortConjugation">http://open-services.net/ns/sysmlv2#PortConjugation</seealso>
    let PortConjugation = Prefixed_Name(ossysmlv2, "PortConjugation") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:PortUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A PortUsage is a usage of a PortDefinition. A PortUsage itself as well as all its nestedUsages must be referential (non-composite).</para>
    /// labels<para>PortUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#PortUsage">http://open-services.net/ns/sysmlv2#PortUsage</seealso>
    let PortUsage = Prefixed_Name(ossysmlv2, "PortUsage") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:Subsetting</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Subsetting is Specialization in which the specific and general Types are Features. This means all values of the subsettingFeature (on instances of its domain, i.e., the intersection of its featuringTypes) are values of the subsettedFeature on instances of its domain. To support this the domain of the subsettingFeature must be the same or specialize (at least indirectly) the domain of the subsettedFeature (via Specialization), and the co-domain (intersection of the types) of the subsettingFeature must specialize the co-domain of the subsettedFeature.</para>
    /// labels<para>Subsetting</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Subsetting">http://open-services.net/ns/sysmlv2#Subsetting</seealso>
    let Subsetting = Prefixed_Name(ossysmlv2, "Subsetting") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:ReferenceSubsetting</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>ReferenceSubsetting is a kind of Subsetting in which the referencedFeature is syntactically distinguished from other Features subsetted by the referencingFeature. ReferenceSubsetting has the same semantics as Subsetting, but the referenceFeature may have a special purpose relative to the referencingFeature. For instance, ReferenceSubsetting is used to identify the relatedFeatures of a Connector.</para>
    /// labels<para>ReferenceSubsetting</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#ReferenceSubsetting">http://open-services.net/ns/sysmlv2#ReferenceSubsetting</seealso>
    let ReferenceSubsetting =
        Prefixed_Name(ossysmlv2, "ReferenceSubsetting") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:RenderingUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A RenderingUsage is the usage of a RenderingDefinition to specify the rendering of a specific model view to produce a physical view artifact.</para>
    /// labels<para>RenderingUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#RenderingUsage">http://open-services.net/ns/sysmlv2#RenderingUsage</seealso>
    let RenderingUsage = Prefixed_Name(ossysmlv2, "RenderingUsage") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:RequirementVerificationMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A RequirementVerificationMembership is a RequirementConstraintMembership  used in the objective of a VerificationCase to identify a RequirementUsage that is verified by the VerificationCase.</para>
    /// labels<para>RequirementVerificationMembership</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#RequirementVerificationMembership">http://open-services.net/ns/sysmlv2#RequirementVerificationMembership</seealso>
    let RequirementVerificationMembership =
        Prefixed_Name(ossysmlv2, "RequirementVerificationMembership") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:ReturnParameterMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A ReturnParameterMembership is a ParameterMembership that indicates that the ownedMemberParameter is the result parameter of a Function or Expression. The direction of the ownedMemberParameter must be out.</para>
    /// labels<para>ReturnParameterMembership</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#ReturnParameterMembership">http://open-services.net/ns/sysmlv2#ReturnParameterMembership</seealso>
    let ReturnParameterMembership =
        Prefixed_Name(ossysmlv2, "ReturnParameterMembership") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:SendActionUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SendActionUsage is an ActionUsage that specifies the sending of a payload given by the result of its payloadArgument Expression via a MessageTransfer whose source is given by the result of the senderArgument Expression and whose target is given by the result of the receiverArgument Expression. If no senderArgument is provided, the default is the this context for the action. If no receiverArgument is given, then the receiver is to be determined by, e.g., outgoing Connections from the sender.</para>
    /// labels<para>SendActionUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#SendActionUsage">http://open-services.net/ns/sysmlv2#SendActionUsage</seealso>
    let SendActionUsage = Prefixed_Name(ossysmlv2, "SendActionUsage") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:StakeholderMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A StakeholderMembership is a ParameterMembership that identifies a PartUsage as a stakeholderParameter of a RequirementDefinition or RequirementUsage, which specifies a role played by an entity with concerns framed by the owningType.</para>
    /// labels<para>StakeholderMembership</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#StakeholderMembership">http://open-services.net/ns/sysmlv2#StakeholderMembership</seealso>
    let StakeholderMembership =
        Prefixed_Name(ossysmlv2, "StakeholderMembership") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:StateSubactionKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A StateSubactionKind indicates whether the action of a StateSubactionMembership is an entry, do or exit action.</para>
    /// labels<para>StateSubactionKind</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#StateSubactionKind">http://open-services.net/ns/sysmlv2#StateSubactionKind</seealso>
    let StateSubactionKind =
        Prefixed_Name(ossysmlv2, "StateSubactionKind") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:StateSubactionMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A StateSubactionMembership is a FeatureMembership for an entry, do or exit ActionUsage of a StateDefinition or StateUsage.</para>
    /// labels<para>StateSubactionMembership</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#StateSubactionMembership">http://open-services.net/ns/sysmlv2#StateSubactionMembership</seealso>
    let StateSubactionMembership =
        Prefixed_Name(ossysmlv2, "StateSubactionMembership") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:Subclassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Subclassification is Specialization in which both the specific and general Types are Classifier. This means all instances of the specific Classifier are also instances of the general Classifier.</para>
    /// labels<para>Subclassification</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Subclassification">http://open-services.net/ns/sysmlv2#Subclassification</seealso>
    let Subclassification =
        Prefixed_Name(ossysmlv2, "Subclassification") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:SubjectMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SubjectMembership is a ParameterMembership that indicates that its ownedSubjectParameter is the subject of its owningType. The owningType of a SubjectMembership must be a RequirementDefinition, RequirementUsage, CaseDefinition, or CaseUsage.</para>
    /// labels<para>SubjectMembership</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#SubjectMembership">http://open-services.net/ns/sysmlv2#SubjectMembership</seealso>
    let SubjectMembership =
        Prefixed_Name(ossysmlv2, "SubjectMembership") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:SuccessionAsUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SuccessionAsUsage is both a ConnectorAsUsage and a Succession.</para>
    /// labels<para>SuccessionAsUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#SuccessionAsUsage">http://open-services.net/ns/sysmlv2#SuccessionAsUsage</seealso>
    let SuccessionAsUsage =
        Prefixed_Name(ossysmlv2, "SuccessionAsUsage") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:SuccessionFlowConnectionUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A SuccessionFlowConnectionUsage is a FlowConnectionUsage that is also a SuccessionItemFlow.</para>
    /// labels<para>SuccessionFlowConnectionUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#SuccessionFlowConnectionUsage">http://open-services.net/ns/sysmlv2#SuccessionFlowConnectionUsage</seealso>
    let SuccessionFlowConnectionUsage =
        Prefixed_Name(ossysmlv2, "SuccessionFlowConnectionUsage") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:TextualRepresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A TextualRepresentation is an AnnotatingElement whose body represents the representedElement in a given language. The representedElement must be the owner of the TextualRepresentation. The named language can be a natural language, in which case the body is an informal representation, or an artificial language, in which case the body is expected to be a formal, machine-parsable representation.</para>
    /// labels<para>TextualRepresentation</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#TextualRepresentation">http://open-services.net/ns/sysmlv2#TextualRepresentation</seealso>
    let TextualRepresentation =
        Prefixed_Name(ossysmlv2, "TextualRepresentation") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:TransitionFeatureKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A TransitionActionKind indicates whether the transitionFeature of a TransitionFeatureMembership is a trigger, guard or effect.</para>
    /// labels<para>TransitionFeatureKind</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#TransitionFeatureKind">http://open-services.net/ns/sysmlv2#TransitionFeatureKind</seealso>
    let TransitionFeatureKind =
        Prefixed_Name(ossysmlv2, "TransitionFeatureKind") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:TransitionFeatureMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A TransitionFeatureMembership is a FeatureMembership for a trigger, guard or effect of a TransitionUsage, whose transitionFeature is a AcceptActionUsage, Boolean-valued Expression or ActionUsage, depending on its kind. .</para>
    /// labels<para>TransitionFeatureMembership</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#TransitionFeatureMembership">http://open-services.net/ns/sysmlv2#TransitionFeatureMembership</seealso>
    let TransitionFeatureMembership =
        Prefixed_Name(ossysmlv2, "TransitionFeatureMembership") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:TriggerInvocationExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A TriggerInvocationExpression is an InvocationExpression that invokes one of the trigger Functions from the Kernel Semantic Library Triggers package, as indicated by its kind.</para>
    /// labels<para>TriggerInvocationExpression</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#TriggerInvocationExpression">http://open-services.net/ns/sysmlv2#TriggerInvocationExpression</seealso>
    let TriggerInvocationExpression =
        Prefixed_Name(ossysmlv2, "TriggerInvocationExpression") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:TriggerKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>TriggerKind enumerates the kinds of triggers that can be represented by a TriggerInvocationExpression.</para>
    /// labels<para>TriggerKind</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#TriggerKind">http://open-services.net/ns/sysmlv2#TriggerKind</seealso>
    let TriggerKind = Prefixed_Name(ossysmlv2, "TriggerKind") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:TypeFeaturing</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A TypeFeaturing is a Featuring Relationship in which the featureOfType is the source and the featuringType is the target.</para>
    /// labels<para>TypeFeaturing</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#TypeFeaturing">http://open-services.net/ns/sysmlv2#TypeFeaturing</seealso>
    let TypeFeaturing = Prefixed_Name(ossysmlv2, "TypeFeaturing") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:Unioning</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Unioning is a Relationship that makes its unioningType one of the unioningTypes of its typeUnioned.</para>
    /// labels<para>Unioning</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Unioning">http://open-services.net/ns/sysmlv2#Unioning</seealso>
    let Unioning = Prefixed_Name(ossysmlv2, "Unioning") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:VariantMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A VariantMembership is a Membership between a variation point Definition or Usage and a Usage that represents a variant in the context of that variation. The membershipOwningNamespace for the VariantMembership must be either a Definition or a Usage with isVariation = true.</para>
    /// labels<para>VariantMembership</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#VariantMembership">http://open-services.net/ns/sysmlv2#VariantMembership</seealso>
    let VariantMembership =
        Prefixed_Name(ossysmlv2, "VariantMembership") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:VerificationCaseDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A VerificationCaseDefinition is a CaseDefinition for the purpose of verification of the subject of the case against its requirements.</para>
    /// labels<para>VerificationCaseDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#VerificationCaseDefinition">http://open-services.net/ns/sysmlv2#VerificationCaseDefinition</seealso>
    let VerificationCaseDefinition =
        Prefixed_Name(ossysmlv2, "VerificationCaseDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:ViewDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A ViewDefinition is a PartDefinition that specifies how a view artifact is constructed to satisfy a viewpoint. It specifies a viewConditions to define the model content to be presented and a viewRendering to define how the model content is presented.</para>
    /// labels<para>ViewDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#ViewDefinition">http://open-services.net/ns/sysmlv2#ViewDefinition</seealso>
    let ViewDefinition = Prefixed_Name(ossysmlv2, "ViewDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:ViewRenderingMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A ViewRenderingMembership is a FeatureMembership that identifies the viewRendering of a ViewDefinition or ViewUsage.</para>
    /// labels<para>ViewRenderingMembership</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#ViewRenderingMembership">http://open-services.net/ns/sysmlv2#ViewRenderingMembership</seealso>
    let ViewRenderingMembership =
        Prefixed_Name(ossysmlv2, "ViewRenderingMembership") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:ViewUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A ViewUsage is a usage of a ViewDefinition to specify the generation of a view of the members of a collection of exposedNamespaces. The ViewUsage can satisfy more viewpoints than its definition, and it can specialize the viewRendering specified by its definition.</para>
    /// labels<para>ViewUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#ViewUsage">http://open-services.net/ns/sysmlv2#ViewUsage</seealso>
    let ViewUsage = Prefixed_Name(ossysmlv2, "ViewUsage") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:ViewpointDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A ViewpointDefinition is a RequirementDefinition that specifies one or more stakeholder concerns that are to be satisfied by creating a view of a model.</para>
    /// labels<para>ViewpointDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#ViewpointDefinition">http://open-services.net/ns/sysmlv2#ViewpointDefinition</seealso>
    let ViewpointDefinition =
        Prefixed_Name(ossysmlv2, "ViewpointDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:ViewpointUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A ViewpointUsage is a Usage of a ViewpointDefinition.</para>
    /// labels<para>ViewpointUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#ViewpointUsage">http://open-services.net/ns/sysmlv2#ViewpointUsage</seealso>
    let ViewpointUsage = Prefixed_Name(ossysmlv2, "ViewpointUsage") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:WhileLoopActionUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A WhileLoopActionUsage is a LoopActionUsage that specifies that the bodyAction ActionUsage should be performed repeatedly while the result of the whileArgument Expression is true or until the result of the untilArgument Expression (if provided) is true. The whileArgument Expression is evaluated before each (possible) performance of the bodyAction, and the untilArgument Expression is evaluated after each performance of the bodyAction.</para>
    /// labels<para>WhileLoopActionUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#WhileLoopActionUsage">http://open-services.net/ns/sysmlv2#WhileLoopActionUsage</seealso>
    let WhileLoopActionUsage =
        Prefixed_Name(ossysmlv2, "WhileLoopActionUsage") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:acceptActionUsage_PayloadArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An Expression whose result is bound to the payload parameter of this AcceptActionUsage. If provided, the AcceptActionUsage will only accept a Transfer with exactly this payload.</para>
    /// labels<para>acceptActionUsage_PayloadArgument</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#acceptActionUsage_PayloadArgument">http://open-services.net/ns/sysmlv2#acceptActionUsage_PayloadArgument</seealso>
    let acceptActionUsage_PayloadArgument =
        Prefixed_Name(ossysmlv2, "acceptActionUsage_PayloadArgument") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:acceptActionUsage_PayloadParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The nestedReference of this AcceptActionUsage that redefines the payload output parameter of the base AcceptActionUsage AcceptAction from the Systems Model Library.</para>
    /// labels<para>acceptActionUsage_PayloadParameter</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#acceptActionUsage_PayloadParameter">http://open-services.net/ns/sysmlv2#acceptActionUsage_PayloadParameter</seealso>
    let acceptActionUsage_PayloadParameter =
        Prefixed_Name(ossysmlv2, "acceptActionUsage_PayloadParameter") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:acceptActionUsage_ReceiverArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An Expression whose result is bound to the receiver input parameter of this AcceptActionUsage.</para>
    /// labels<para>acceptActionUsage_ReceiverArgument</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#acceptActionUsage_ReceiverArgument">http://open-services.net/ns/sysmlv2#acceptActionUsage_ReceiverArgument</seealso>
    let acceptActionUsage_ReceiverArgument =
        Prefixed_Name(ossysmlv2, "acceptActionUsage_ReceiverArgument") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:actionDefinition_Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ActionUsages that are steps in this ActionDefinition, which define the actions that specify the behavior of the ActionDefinition.</para>
    /// labels<para>actionDefinition_Action</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#actionDefinition_Action">http://open-services.net/ns/sysmlv2#actionDefinition_Action</seealso>
    let actionDefinition_Action =
        Prefixed_Name(ossysmlv2, "actionDefinition_Action") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:allocationDefinition_Allocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The AllocationUsages that refine the allocation mapping defined by this AllocationDefinition.</para>
    /// labels<para>allocationDefinition_Allocation</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#allocationDefinition_Allocation">http://open-services.net/ns/sysmlv2#allocationDefinition_Allocation</seealso>
    let allocationDefinition_Allocation =
        Prefixed_Name(ossysmlv2, "allocationDefinition_Allocation") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:allocationUsage_AllocationDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The AllocationDefinitions that are the types of this AllocationUsage.</para>
    /// labels<para>allocationUsage_AllocationDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#allocationUsage_AllocationDefinition">http://open-services.net/ns/sysmlv2#allocationUsage_AllocationDefinition</seealso>
    let allocationUsage_AllocationDefinition =
        Prefixed_Name(ossysmlv2, "allocationUsage_AllocationDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:analysisCaseDefinition_AnalysisAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The composite actions of the AnalysisCaseDefinition that are defined as AnalysisActions.</para>
    /// labels<para>analysisCaseDefinition_AnalysisAction</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#analysisCaseDefinition_AnalysisAction">http://open-services.net/ns/sysmlv2#analysisCaseDefinition_AnalysisAction</seealso>
    let analysisCaseDefinition_AnalysisAction =
        Prefixed_Name(ossysmlv2, "analysisCaseDefinition_AnalysisAction") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:analysisCaseDefinition_ResultExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An Expression used to compute the result of the AnalysisCaseDefinition, owned via a ResultExpressionMembership.</para>
    /// labels<para>analysisCaseDefinition_ResultExpression</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#analysisCaseDefinition_ResultExpression">http://open-services.net/ns/sysmlv2#analysisCaseDefinition_ResultExpression</seealso>
    let analysisCaseDefinition_ResultExpression =
        Prefixed_Name(ossysmlv2, "analysisCaseDefinition_ResultExpression") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:analysisCaseUsage_AnalysisAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The composite usages of the AnalysisCaseUsage that are defined as AnalysisActions.</para>
    /// labels<para>analysisCaseUsage_AnalysisAction</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#analysisCaseUsage_AnalysisAction">http://open-services.net/ns/sysmlv2#analysisCaseUsage_AnalysisAction</seealso>
    let analysisCaseUsage_AnalysisAction =
        Prefixed_Name(ossysmlv2, "analysisCaseUsage_AnalysisAction") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:analysisCaseUsage_AnalysisCaseDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The AnalysisCaseDefinition that is the definition of this AnalysisCaseUsage.</para>
    /// labels<para>analysisCaseUsage_AnalysisCaseDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#analysisCaseUsage_AnalysisCaseDefinition">http://open-services.net/ns/sysmlv2#analysisCaseUsage_AnalysisCaseDefinition</seealso>
    let analysisCaseUsage_AnalysisCaseDefinition =
        Prefixed_Name(ossysmlv2, "analysisCaseUsage_AnalysisCaseDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:analysisCaseUsage_ResultExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An Expression used to compute the result of the AnalysisCaseUsage, owned via a ResultExpressionMembership.</para>
    /// labels<para>analysisCaseUsage_ResultExpression</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#analysisCaseUsage_ResultExpression">http://open-services.net/ns/sysmlv2#analysisCaseUsage_ResultExpression</seealso>
    let analysisCaseUsage_ResultExpression =
        Prefixed_Name(ossysmlv2, "analysisCaseUsage_ResultExpression") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:annotatingElement_AnnotatedElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Elements that are annotated by this AnnotatingElement. If annotation is not empty, these are the annotatedElements of the annotations. If annotation is empty, then it is the owningNamespace of the AnnotatingElement.</para>
    /// labels<para>annotatingElement_AnnotatedElement</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#annotatingElement_AnnotatedElement">http://open-services.net/ns/sysmlv2#annotatingElement_AnnotatedElement</seealso>
    let annotatingElement_AnnotatedElement =
        Prefixed_Name(ossysmlv2, "annotatingElement_AnnotatedElement") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:annotatingElement_Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Annotations that relate this AnnotatingElement to its annotatedElements.</para>
    /// labels<para>annotatingElement_Annotation</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#annotatingElement_Annotation">http://open-services.net/ns/sysmlv2#annotatingElement_Annotation</seealso>
    let annotatingElement_Annotation =
        Prefixed_Name(ossysmlv2, "annotatingElement_Annotation") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:annotatingElement_OwnedAnnotatingRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ownedRelationships of this AnnotatingElement that are Annotations, for which this AnnotatingElement is the annotatingElement.</para>
    /// labels<para>annotatingElement_OwnedAnnotatingRelationship</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#annotatingElement_OwnedAnnotatingRelationship">http://open-services.net/ns/sysmlv2#annotatingElement_OwnedAnnotatingRelationship</seealso>
    let annotatingElement_OwnedAnnotatingRelationship =
        Prefixed_Name(ossysmlv2, "annotatingElement_OwnedAnnotatingRelationship") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:annotation_AnnotatedElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Element that is annotated by the annotatingElement of this Annotation.</para>
    /// labels<para>annotation_AnnotatedElement</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#annotation_AnnotatedElement">http://open-services.net/ns/sysmlv2#annotation_AnnotatedElement</seealso>
    let annotation_AnnotatedElement =
        Prefixed_Name(ossysmlv2, "annotation_AnnotatedElement") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:annotation_AnnotatingElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The AnnotatingElement that annotates the annotatedElement of this Annotation.</para>
    /// labels<para>annotation_AnnotatingElement</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#annotation_AnnotatingElement">http://open-services.net/ns/sysmlv2#annotation_AnnotatingElement</seealso>
    let annotation_AnnotatingElement =
        Prefixed_Name(ossysmlv2, "annotation_AnnotatingElement") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:annotation_OwningAnnotatedElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The annotatedElement of this Annotation, when it is also its owningRelatedElement.</para>
    /// labels<para>annotation_OwningAnnotatedElement</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#annotation_OwningAnnotatedElement">http://open-services.net/ns/sysmlv2#annotation_OwningAnnotatedElement</seealso>
    let annotation_OwningAnnotatedElement =
        Prefixed_Name(ossysmlv2, "annotation_OwningAnnotatedElement") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:annotation_OwningAnnotatingElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The annotatingElement of this Annotation, when it is also its owningRelatedElement.</para>
    /// labels<para>annotation_OwningAnnotatingElement</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#annotation_OwningAnnotatingElement">http://open-services.net/ns/sysmlv2#annotation_OwningAnnotatingElement</seealso>
    let annotation_OwningAnnotatingElement =
        Prefixed_Name(ossysmlv2, "annotation_OwningAnnotatingElement") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:assertConstraintUsage_AssertedConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ConstraintUsage to be performed by the AssertConstraintUsage. It is the referenceFeature of the ownedReferenceSubsetting for the AssertConstraintUsage, if there is one, and, otherwise, the AssertConstraintUsage itself.</para>
    /// labels<para>assertConstraintUsage_AssertedConstraint</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#assertConstraintUsage_AssertedConstraint">http://open-services.net/ns/sysmlv2#assertConstraintUsage_AssertedConstraint</seealso>
    let assertConstraintUsage_AssertedConstraint =
        Prefixed_Name(ossysmlv2, "assertConstraintUsage_AssertedConstraint") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:assignmentActionUsage_Referent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Feature whose value is to be set.</para>
    /// labels<para>assignmentActionUsage_Referent</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#assignmentActionUsage_Referent">http://open-services.net/ns/sysmlv2#assignmentActionUsage_Referent</seealso>
    let assignmentActionUsage_Referent =
        Prefixed_Name(ossysmlv2, "assignmentActionUsage_Referent") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:association_AssociationEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The features of the Association that identify the things that can be related by it. A concrete Association must have at least two associationEnds. When it has exactly two, the Association is called a binary Association.</para>
    /// labels<para>association_AssociationEnd</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#association_AssociationEnd">http://open-services.net/ns/sysmlv2#association_AssociationEnd</seealso>
    let association_AssociationEnd =
        Prefixed_Name(ossysmlv2, "association_AssociationEnd") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:association_RelatedType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The types of the associationEnds of the Association, which are the relatedElements of the Association considered as a Relationship.</para>
    /// labels<para>association_RelatedType</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#association_RelatedType">http://open-services.net/ns/sysmlv2#association_RelatedType</seealso>
    let association_RelatedType =
        Prefixed_Name(ossysmlv2, "association_RelatedType") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:association_SourceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The source relatedType for this Association. It is the first relatedType of the Association.</para>
    /// labels<para>association_SourceType</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#association_SourceType">http://open-services.net/ns/sysmlv2#association_SourceType</seealso>
    let association_SourceType =
        Prefixed_Name(ossysmlv2, "association_SourceType") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:association_TargetType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The target relatedTypes for this Association. This includes all the relatedTypes other than the sourceType.</para>
    /// labels<para>association_TargetType</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#association_TargetType">http://open-services.net/ns/sysmlv2#association_TargetType</seealso>
    let association_TargetType =
        Prefixed_Name(ossysmlv2, "association_TargetType") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:attributeUsage_AttributeDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The DataTypes that are the types of this AttributeUsage. Nominally, these are AttributeDefinitions, but other kinds of kernel DataTypes are also allowed, to permit use of DataTypes from the Kernel Model Libraries.</para>
    /// labels<para>attributeUsage_AttributeDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#attributeUsage_AttributeDefinition">http://open-services.net/ns/sysmlv2#attributeUsage_AttributeDefinition</seealso>
    let attributeUsage_AttributeDefinition =
        Prefixed_Name(ossysmlv2, "attributeUsage_AttributeDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:behavior_Parameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The parameters of this Behavior, which are defined as its directedFeatures, whose values are passed into and/or out of a performance of the Behavior.</para>
    /// labels<para>behavior_Parameter</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#behavior_Parameter">http://open-services.net/ns/sysmlv2#behavior_Parameter</seealso>
    let behavior_Parameter =
        Prefixed_Name(ossysmlv2, "behavior_Parameter") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:booleanExpression_Predicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Predicate that types this BooleanExpression.</para>
    /// labels<para>booleanExpression_Predicate</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#booleanExpression_Predicate">http://open-services.net/ns/sysmlv2#booleanExpression_Predicate</seealso>
    let booleanExpression_Predicate =
        Prefixed_Name(ossysmlv2, "booleanExpression_Predicate") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:calculationDefinition_Calculation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The actions of this CalculationDefinition that are CalculationUsages.</para>
    /// labels<para>calculationDefinition_Calculation</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#calculationDefinition_Calculation">http://open-services.net/ns/sysmlv2#calculationDefinition_Calculation</seealso>
    let calculationDefinition_Calculation =
        Prefixed_Name(ossysmlv2, "calculationDefinition_Calculation") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:calculationUsage_CalculationDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Function that is the type of this CalculationUsage. Nominally, this would be a CalculationDefinition, but a kernel Function is also allowed, to permit use of Functions from the Kernel Model Libraries.</para>
    /// labels<para>calculationUsage_CalculationDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#calculationUsage_CalculationDefinition">http://open-services.net/ns/sysmlv2#calculationUsage_CalculationDefinition</seealso>
    let calculationUsage_CalculationDefinition =
        Prefixed_Name(ossysmlv2, "calculationUsage_CalculationDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:caseDefinition_ActorParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The parameters of this CaseDefinition that represent actors involved in the case.</para>
    /// labels<para>caseDefinition_ActorParameter</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#caseDefinition_ActorParameter">http://open-services.net/ns/sysmlv2#caseDefinition_ActorParameter</seealso>
    let caseDefinition_ActorParameter =
        Prefixed_Name(ossysmlv2, "caseDefinition_ActorParameter") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:caseDefinition_ObjectiveRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The RequirementUsage representing the objective of this CaseDefinition.</para>
    /// labels<para>caseDefinition_ObjectiveRequirement</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#caseDefinition_ObjectiveRequirement">http://open-services.net/ns/sysmlv2#caseDefinition_ObjectiveRequirement</seealso>
    let caseDefinition_ObjectiveRequirement =
        Prefixed_Name(ossysmlv2, "caseDefinition_ObjectiveRequirement") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:caseUsage_CaseDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The CaseDefinition that is the type of this CaseUsage.</para>
    /// labels<para>caseUsage_CaseDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#caseUsage_CaseDefinition">http://open-services.net/ns/sysmlv2#caseUsage_CaseDefinition</seealso>
    let caseUsage_CaseDefinition =
        Prefixed_Name(ossysmlv2, "caseUsage_CaseDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:caseUsage_ObjectiveRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The RequirementUsage representing the objective of this CaseUsage.</para>
    /// labels<para>caseUsage_ObjectiveRequirement</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#caseUsage_ObjectiveRequirement">http://open-services.net/ns/sysmlv2#caseUsage_ObjectiveRequirement</seealso>
    let caseUsage_ObjectiveRequirement =
        Prefixed_Name(ossysmlv2, "caseUsage_ObjectiveRequirement") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:caseUsage_SubjectParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The parameter of this CaseUsage that represents its subject.</para>
    /// labels<para>caseUsage_SubjectParameter</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#caseUsage_SubjectParameter">http://open-services.net/ns/sysmlv2#caseUsage_SubjectParameter</seealso>
    let caseUsage_SubjectParameter =
        Prefixed_Name(ossysmlv2, "caseUsage_SubjectParameter") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:classifier_OwnedSubclassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ownedSpecializations of this Classifier that are Subclassifications, for which this Classifier is the subclassifier.</para>
    /// labels<para>classifier_OwnedSubclassification</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#classifier_OwnedSubclassification">http://open-services.net/ns/sysmlv2#classifier_OwnedSubclassification</seealso>
    let classifier_OwnedSubclassification =
        Prefixed_Name(ossysmlv2, "classifier_OwnedSubclassification") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:comment_Body</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The annotation text for the Comment.</para>
    /// labels<para>comment_Body</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#comment_Body">http://open-services.net/ns/sysmlv2#comment_Body</seealso>
    let comment_Body = Prefixed_Name(ossysmlv2, "comment_Body") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:concernUsage_ConcernDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ConcernDefinition that is the single type of this ConcernUsage.</para>
    /// labels<para>concernUsage_ConcernDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#concernUsage_ConcernDefinition">http://open-services.net/ns/sysmlv2#concernUsage_ConcernDefinition</seealso>
    let concernUsage_ConcernDefinition =
        Prefixed_Name(ossysmlv2, "concernUsage_ConcernDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:conjugatedPortDefinition_OriginalPortDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The original PortDefinition for this ConjugatedPortDefinition, which is the owningNamespace of the ConjugatedPortDefinition.</para>
    /// labels<para>conjugatedPortDefinition_OriginalPortDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#conjugatedPortDefinition_OriginalPortDefinition">http://open-services.net/ns/sysmlv2#conjugatedPortDefinition_OriginalPortDefinition</seealso>
    let conjugatedPortDefinition_OriginalPortDefinition =
        Prefixed_Name(ossysmlv2, "conjugatedPortDefinition_OriginalPortDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:conjugatedPortDefinition_OwnedPortConjugator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The PortConjugation that is the ownedConjugator of this ConjugatedPortDefinition, linking it to its originalPortDefinition.</para>
    /// labels<para>conjugatedPortDefinition_OwnedPortConjugator</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#conjugatedPortDefinition_OwnedPortConjugator">http://open-services.net/ns/sysmlv2#conjugatedPortDefinition_OwnedPortConjugator</seealso>
    let conjugatedPortDefinition_OwnedPortConjugator =
        Prefixed_Name(ossysmlv2, "conjugatedPortDefinition_OwnedPortConjugator") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:conjugatedPortTyping_ConjugatedPortDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The type of this ConjugatedPortTyping considered as a FeatureTyping, which must be a ConjugatedPortDefinition.</para>
    /// labels<para>conjugatedPortTyping_ConjugatedPortDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#conjugatedPortTyping_ConjugatedPortDefinition">http://open-services.net/ns/sysmlv2#conjugatedPortTyping_ConjugatedPortDefinition</seealso>
    let conjugatedPortTyping_ConjugatedPortDefinition =
        Prefixed_Name(ossysmlv2, "conjugatedPortTyping_ConjugatedPortDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:conjugatedPortTyping_PortDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The originalPortDefinition of the conjugatedPortDefinition of this ConjugatedPortTyping.</para>
    /// labels<para>conjugatedPortTyping_PortDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#conjugatedPortTyping_PortDefinition">http://open-services.net/ns/sysmlv2#conjugatedPortTyping_PortDefinition</seealso>
    let conjugatedPortTyping_PortDefinition =
        Prefixed_Name(ossysmlv2, "conjugatedPortTyping_PortDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:conjugation_ConjugatedType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Type that is the result of applying Conjugation to the originalType.</para>
    /// labels<para>conjugation_ConjugatedType</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#conjugation_ConjugatedType">http://open-services.net/ns/sysmlv2#conjugation_ConjugatedType</seealso>
    let conjugation_ConjugatedType =
        Prefixed_Name(ossysmlv2, "conjugation_ConjugatedType") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:conjugation_OriginalType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Type to be conjugated.</para>
    /// labels<para>conjugation_OriginalType</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#conjugation_OriginalType">http://open-services.net/ns/sysmlv2#conjugation_OriginalType</seealso>
    let conjugation_OriginalType =
        Prefixed_Name(ossysmlv2, "conjugation_OriginalType") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:conjugation_OwningType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The conjugatedType of this Conjugation that is also its owningRelatedElement.</para>
    /// labels<para>conjugation_OwningType</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#conjugation_OwningType">http://open-services.net/ns/sysmlv2#conjugation_OwningType</seealso>
    let conjugation_OwningType =
        Prefixed_Name(ossysmlv2, "conjugation_OwningType") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:connectionDefinition_ConnectionEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Usages that define the things related by the ConnectionDefinition.</para>
    /// labels<para>connectionDefinition_ConnectionEnd</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#connectionDefinition_ConnectionEnd">http://open-services.net/ns/sysmlv2#connectionDefinition_ConnectionEnd</seealso>
    let connectionDefinition_ConnectionEnd =
        Prefixed_Name(ossysmlv2, "connectionDefinition_ConnectionEnd") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:connectionUsage_ConnectionDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The AssociationStructures that are the types of this ConnectionUsage. Nominally, these are , but other kinds of Kernel AssociationStructures are also allowed, to permit use of AssociationStructures from the Kernel Model Libraries.</para>
    /// labels<para>connectionUsage_ConnectionDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#connectionUsage_ConnectionDefinition">http://open-services.net/ns/sysmlv2#connectionUsage_ConnectionDefinition</seealso>
    let connectionUsage_ConnectionDefinition =
        Prefixed_Name(ossysmlv2, "connectionUsage_ConnectionDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:package_FilterCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The model-level evaluable Boolean-valued Expression used to filter the members of this Package, which are owned by the Package are via ElementFilterMemberships.</para>
    /// labels<para>package_FilterCondition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#package_FilterCondition">http://open-services.net/ns/sysmlv2#package_FilterCondition</seealso>
    let package_FilterCondition =
        Prefixed_Name(ossysmlv2, "package_FilterCondition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:parameterMembership_OwnedMemberParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Feature that is identified as a parameter by this ParameterMembership.</para>
    /// labels<para>parameterMembership_OwnedMemberParameter</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#parameterMembership_OwnedMemberParameter">http://open-services.net/ns/sysmlv2#parameterMembership_OwnedMemberParameter</seealso>
    let parameterMembership_OwnedMemberParameter =
        Prefixed_Name(ossysmlv2, "parameterMembership_OwnedMemberParameter") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:partUsage_PartDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The itemDefinitions of this PartUsage that are PartDefinitions.</para>
    /// labels<para>partUsage_PartDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#partUsage_PartDefinition">http://open-services.net/ns/sysmlv2#partUsage_PartDefinition</seealso>
    let partUsage_PartDefinition =
        Prefixed_Name(ossysmlv2, "partUsage_PartDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:performActionUsage_PerformedAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ActionUsage to be performed by this PerformedActionUsage. It is the eventOccurrence of the PerformActionUsage considered as an EventOccurrenceUsage, which must be an ActionUsage.</para>
    /// labels<para>performActionUsage_PerformedAction</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#performActionUsage_PerformedAction">http://open-services.net/ns/sysmlv2#performActionUsage_PerformedAction</seealso>
    let performActionUsage_PerformedAction =
        Prefixed_Name(ossysmlv2, "performActionUsage_PerformedAction") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:portConjugation_ConjugatedPortDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ConjugatedPortDefinition that is conjugate to the originalPortDefinition.</para>
    /// labels<para>portConjugation_ConjugatedPortDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#portConjugation_ConjugatedPortDefinition">http://open-services.net/ns/sysmlv2#portConjugation_ConjugatedPortDefinition</seealso>
    let portConjugation_ConjugatedPortDefinition =
        Prefixed_Name(ossysmlv2, "portConjugation_ConjugatedPortDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:portConjugation_OriginalPortDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The PortDefinition being conjugated.</para>
    /// labels<para>portConjugation_OriginalPortDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#portConjugation_OriginalPortDefinition">http://open-services.net/ns/sysmlv2#portConjugation_OriginalPortDefinition</seealso>
    let portConjugation_OriginalPortDefinition =
        Prefixed_Name(ossysmlv2, "portConjugation_OriginalPortDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:portDefinition_ConjugatedPortDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The  that is conjugate to this PortDefinition.</para>
    /// labels<para>portDefinition_ConjugatedPortDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#portDefinition_ConjugatedPortDefinition">http://open-services.net/ns/sysmlv2#portDefinition_ConjugatedPortDefinition</seealso>
    let portDefinition_ConjugatedPortDefinition =
        Prefixed_Name(ossysmlv2, "portDefinition_ConjugatedPortDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:portUsage_PortDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The occurrenceDefinitions of this PortUsage, which must all be PortDefinitions.</para>
    /// labels<para>portUsage_PortDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#portUsage_PortDefinition">http://open-services.net/ns/sysmlv2#portUsage_PortDefinition</seealso>
    let portUsage_PortDefinition =
        Prefixed_Name(ossysmlv2, "portUsage_PortDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:portionKind_Snapshot</para>
    /// </summary>
    /// <remarks>
    ///   <para>ossysmlv2:PortionKind</para>
    ///   <para>A snapshot of an Occurrence (a time slice with zero duration).</para>
    /// labels<para>portionKind_Snapshot</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#portionKind_Snapshot">http://open-services.net/ns/sysmlv2#portionKind_Snapshot</seealso>
    let portionKind_Snapshot =
        Prefixed_Name(ossysmlv2, "portionKind_Snapshot") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:portionKind_Timeslice</para>
    /// </summary>
    /// <remarks>
    ///   <para>ossysmlv2:PortionKind</para>
    ///   <para>A time slice of an Occurrence (a portion over time).</para>
    /// labels<para>portionKind_Timeslice</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#portionKind_Timeslice">http://open-services.net/ns/sysmlv2#portionKind_Timeslice</seealso>
    let portionKind_Timeslice =
        Prefixed_Name(ossysmlv2, "portionKind_Timeslice") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:relationship_OwnedRelatedElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The relatedElements of this Relationship that are owned by the Relationship.</para>
    /// labels<para>relationship_OwnedRelatedElement</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#relationship_OwnedRelatedElement">http://open-services.net/ns/sysmlv2#relationship_OwnedRelatedElement</seealso>
    let relationship_OwnedRelatedElement =
        Prefixed_Name(ossysmlv2, "relationship_OwnedRelatedElement") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:relationship_OwningRelatedElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The relatedElement of this Relationship that owns the Relationship, if any.</para>
    /// labels<para>relationship_OwningRelatedElement</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#relationship_OwningRelatedElement">http://open-services.net/ns/sysmlv2#relationship_OwningRelatedElement</seealso>
    let relationship_OwningRelatedElement =
        Prefixed_Name(ossysmlv2, "relationship_OwningRelatedElement") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:relationship_RelatedElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Elements that are related by this Relationship, derived as the union of the source and target Elements of the Relationship.</para>
    /// labels<para>relationship_RelatedElement</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#relationship_RelatedElement">http://open-services.net/ns/sysmlv2#relationship_RelatedElement</seealso>
    let relationship_RelatedElement =
        Prefixed_Name(ossysmlv2, "relationship_RelatedElement") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:relationship_Source</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The relatedElements from which this Relationship is considered to be directed.</para>
    /// labels<para>relationship_Source</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#relationship_Source">http://open-services.net/ns/sysmlv2#relationship_Source</seealso>
    let relationship_Source =
        Prefixed_Name(ossysmlv2, "relationship_Source") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:relationship_Target</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The relatedElements to which this Relationship is considered to be directed.</para>
    /// labels<para>relationship_Target</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#relationship_Target">http://open-services.net/ns/sysmlv2#relationship_Target</seealso>
    let relationship_Target =
        Prefixed_Name(ossysmlv2, "relationship_Target") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:renderingDefinition_Rendering</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The usages of a RenderingDefinition that are RenderingUsages.</para>
    /// labels<para>renderingDefinition_Rendering</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#renderingDefinition_Rendering">http://open-services.net/ns/sysmlv2#renderingDefinition_Rendering</seealso>
    let renderingDefinition_Rendering =
        Prefixed_Name(ossysmlv2, "renderingDefinition_Rendering") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:renderingUsage_RenderingDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The RenderingDefinition that is the definition of this RenderingUsage.</para>
    /// labels<para>renderingUsage_RenderingDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#renderingUsage_RenderingDefinition">http://open-services.net/ns/sysmlv2#renderingUsage_RenderingDefinition</seealso>
    let renderingUsage_RenderingDefinition =
        Prefixed_Name(ossysmlv2, "renderingUsage_RenderingDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:requirementConstraintKind_Assumption</para>
    /// </summary>
    /// <remarks>
    ///   <para>ossysmlv2:RequirementConstraintKind</para>
    ///   <para>Indicates that a member ConstraintUsage of a RequirementDefinition or RequirementUsage represents an assumption.</para>
    /// labels<para>requirementConstraintKind_Assumption</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#requirementConstraintKind_Assumption">http://open-services.net/ns/sysmlv2#requirementConstraintKind_Assumption</seealso>
    let requirementConstraintKind_Assumption =
        Prefixed_Name(ossysmlv2, "requirementConstraintKind_Assumption") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:requirementConstraintKind_Requirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>ossysmlv2:RequirementConstraintKind</para>
    ///   <para>Indicates that a member ConstraintUsage of a RequirementDefinition or RequirementUsagerepresents an requirement.</para>
    /// labels<para>requirementConstraintKind_Requirement</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#requirementConstraintKind_Requirement">http://open-services.net/ns/sysmlv2#requirementConstraintKind_Requirement</seealso>
    let requirementConstraintKind_Requirement =
        Prefixed_Name(ossysmlv2, "requirementConstraintKind_Requirement") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:requirementConstraintMembership_Kind</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether the RequirementConstraintMembership is for an assumed or required ConstraintUsage.</para>
    /// labels<para>requirementConstraintMembership_Kind</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#requirementConstraintMembership_Kind">http://open-services.net/ns/sysmlv2#requirementConstraintMembership_Kind</seealso>
    let requirementConstraintMembership_Kind =
        Prefixed_Name(ossysmlv2, "requirementConstraintMembership_Kind") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:requirementConstraintMembership_OwnedConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ConstraintUsage that is the ownedMemberFeature of this RequirementConstraintMembership.</para>
    /// labels<para>requirementConstraintMembership_OwnedConstraint</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#requirementConstraintMembership_OwnedConstraint">http://open-services.net/ns/sysmlv2#requirementConstraintMembership_OwnedConstraint</seealso>
    let requirementConstraintMembership_OwnedConstraint =
        Prefixed_Name(ossysmlv2, "requirementConstraintMembership_OwnedConstraint") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:requirementDefinition_FramedConcern</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ConcernUsages framed by this RequirementDefinition, which are the ownedConcerns of all FramedConcernMemberships of the RequirementDefinition.</para>
    /// labels<para>requirementDefinition_FramedConcern</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#requirementDefinition_FramedConcern">http://open-services.net/ns/sysmlv2#requirementDefinition_FramedConcern</seealso>
    let requirementDefinition_FramedConcern =
        Prefixed_Name(ossysmlv2, "requirementDefinition_FramedConcern") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:requirementDefinition_ReqId</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An optional modeler-specified identifier for this RequirementDefinition (used, e.g., to link it to an original requirement text in some source document), which is the declaredShortName for the RequirementDefinition.</para>
    /// labels<para>requirementDefinition_ReqId</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#requirementDefinition_ReqId">http://open-services.net/ns/sysmlv2#requirementDefinition_ReqId</seealso>
    let requirementDefinition_ReqId =
        Prefixed_Name(ossysmlv2, "requirementDefinition_ReqId") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:requirementDefinition_RequiredConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The owned ConstraintUsages that represent requirements of this RequirementDefinition, derived as the ownedConstraints of the RequirementConstraintMemberships of the RequirementDefinition with kind = requirement.</para>
    /// labels<para>requirementDefinition_RequiredConstraint</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#requirementDefinition_RequiredConstraint">http://open-services.net/ns/sysmlv2#requirementDefinition_RequiredConstraint</seealso>
    let requirementDefinition_RequiredConstraint =
        Prefixed_Name(ossysmlv2, "requirementDefinition_RequiredConstraint") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:requirementDefinition_StakeholderParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The parameters of this RequirementDefinition that represent stakeholders for th requirement.</para>
    /// labels<para>requirementDefinition_StakeholderParameter</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#requirementDefinition_StakeholderParameter">http://open-services.net/ns/sysmlv2#requirementDefinition_StakeholderParameter</seealso>
    let requirementDefinition_StakeholderParameter =
        Prefixed_Name(ossysmlv2, "requirementDefinition_StakeholderParameter") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:requirementDefinition_SubjectParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The parameter of this RequirementDefinition that represents its subject.</para>
    /// labels<para>requirementDefinition_SubjectParameter</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#requirementDefinition_SubjectParameter">http://open-services.net/ns/sysmlv2#requirementDefinition_SubjectParameter</seealso>
    let requirementDefinition_SubjectParameter =
        Prefixed_Name(ossysmlv2, "requirementDefinition_SubjectParameter") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:requirementDefinition_Text</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An optional textual statement of the requirement represented by this RequirementDefinition, derived from the bodies of the documentation of the RequirementDefinition.</para>
    /// labels<para>requirementDefinition_Text</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#requirementDefinition_Text">http://open-services.net/ns/sysmlv2#requirementDefinition_Text</seealso>
    let requirementDefinition_Text =
        Prefixed_Name(ossysmlv2, "requirementDefinition_Text") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:requirementUsage_ActorParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The parameters of this RequirementUsage that represent actors involved in the requirement.</para>
    /// labels<para>requirementUsage_ActorParameter</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#requirementUsage_ActorParameter">http://open-services.net/ns/sysmlv2#requirementUsage_ActorParameter</seealso>
    let requirementUsage_ActorParameter =
        Prefixed_Name(ossysmlv2, "requirementUsage_ActorParameter") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:requirementUsage_AssumedConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The owned ConstraintUsages that represent assumptions of this RequirementUsage, derived as the ownedConstraints of the RequirementConstraintMemberships of the RequirementUsage with kind = assumption.</para>
    /// labels<para>requirementUsage_AssumedConstraint</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#requirementUsage_AssumedConstraint">http://open-services.net/ns/sysmlv2#requirementUsage_AssumedConstraint</seealso>
    let requirementUsage_AssumedConstraint =
        Prefixed_Name(ossysmlv2, "requirementUsage_AssumedConstraint") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:requirementUsage_FramedConcern</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ConcernUsages framed by this RequirementUsage, which are the ownedConcerns of all FramedConcernMemberships of the RequirementUsage.</para>
    /// labels<para>requirementUsage_FramedConcern</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#requirementUsage_FramedConcern">http://open-services.net/ns/sysmlv2#requirementUsage_FramedConcern</seealso>
    let requirementUsage_FramedConcern =
        Prefixed_Name(ossysmlv2, "requirementUsage_FramedConcern") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:requirementUsage_ReqId</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An optional modeler-specified identifier for this RequirementUsage (used, e.g., to link it to an original requirement text in some source document), which is the declaredShortName for the RequirementUsage.</para>
    /// labels<para>requirementUsage_ReqId</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#requirementUsage_ReqId">http://open-services.net/ns/sysmlv2#requirementUsage_ReqId</seealso>
    let requirementUsage_ReqId =
        Prefixed_Name(ossysmlv2, "requirementUsage_ReqId") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:requirementUsage_RequiredConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The owned ConstraintUsages that represent requirements of this RequirementUsage, which are the ownedConstraints of the RequirementConstraintMemberships of the RequirementUsage with kind = requirement.</para>
    /// labels<para>requirementUsage_RequiredConstraint</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#requirementUsage_RequiredConstraint">http://open-services.net/ns/sysmlv2#requirementUsage_RequiredConstraint</seealso>
    let requirementUsage_RequiredConstraint =
        Prefixed_Name(ossysmlv2, "requirementUsage_RequiredConstraint") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:requirementVerificationMembership_VerifiedRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para> The RequirementUsage that is identified as being verified. It is the referencedConstraint of the RequirementVerificationMembership considered as a RequirementConstraintMembership, which must be a RequirementUsage.</para>
    /// labels<para>requirementVerificationMembership_VerifiedRequirement</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#requirementVerificationMembership_VerifiedRequirement">http://open-services.net/ns/sysmlv2#requirementVerificationMembership_VerifiedRequirement</seealso>
    let requirementVerificationMembership_VerifiedRequirement =
        Prefixed_Name(ossysmlv2, "requirementVerificationMembership_VerifiedRequirement") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:resultExpressionMembership_OwnedResultExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Expression that provides the result for the owner of the ResultExpressionMembership.</para>
    /// labels<para>resultExpressionMembership_OwnedResultExpression</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#resultExpressionMembership_OwnedResultExpression">http://open-services.net/ns/sysmlv2#resultExpressionMembership_OwnedResultExpression</seealso>
    let resultExpressionMembership_OwnedResultExpression =
        Prefixed_Name(ossysmlv2, "resultExpressionMembership_OwnedResultExpression") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:satisfyRequirementUsage_SatisfiedRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The RequirementUsage that is satisfied by the satisfyingSubject of this SatisfyRequirementUsage. It is the assertedConstraint of the SatisfyRequirementUsage considered as an AssertConstraintUsage, which must be a RequirementUsage.</para>
    /// labels<para>satisfyRequirementUsage_SatisfiedRequirement</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#satisfyRequirementUsage_SatisfiedRequirement">http://open-services.net/ns/sysmlv2#satisfyRequirementUsage_SatisfiedRequirement</seealso>
    let satisfyRequirementUsage_SatisfiedRequirement =
        Prefixed_Name(ossysmlv2, "satisfyRequirementUsage_SatisfiedRequirement") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:satisfyRequirementUsage_SatisfyingFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Feature that represents the actual subject that is asserted to satisfy the satisfiedRequirement. The satisfyingFeature is bound to the subjectParameter of the SatisfyRequirementUsage.</para>
    /// labels<para>satisfyRequirementUsage_SatisfyingFeature</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#satisfyRequirementUsage_SatisfyingFeature">http://open-services.net/ns/sysmlv2#satisfyRequirementUsage_SatisfyingFeature</seealso>
    let satisfyRequirementUsage_SatisfyingFeature =
        Prefixed_Name(ossysmlv2, "satisfyRequirementUsage_SatisfyingFeature") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:sendActionUsage_PayloadArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An Expression whose result is bound to the payload input parameter of this SendActionUsage.</para>
    /// labels<para>sendActionUsage_PayloadArgument</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#sendActionUsage_PayloadArgument">http://open-services.net/ns/sysmlv2#sendActionUsage_PayloadArgument</seealso>
    let sendActionUsage_PayloadArgument =
        Prefixed_Name(ossysmlv2, "sendActionUsage_PayloadArgument") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:sendActionUsage_ReceiverArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An Expression whose result is bound to the receiver input parameter of this SendActionUsage.</para>
    /// labels<para>sendActionUsage_ReceiverArgument</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#sendActionUsage_ReceiverArgument">http://open-services.net/ns/sysmlv2#sendActionUsage_ReceiverArgument</seealso>
    let sendActionUsage_ReceiverArgument =
        Prefixed_Name(ossysmlv2, "sendActionUsage_ReceiverArgument") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:sendActionUsage_SenderArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An Expression whose result is bound to the sender input parameter of this SendActionUsage.</para>
    /// labels<para>sendActionUsage_SenderArgument</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#sendActionUsage_SenderArgument">http://open-services.net/ns/sysmlv2#sendActionUsage_SenderArgument</seealso>
    let sendActionUsage_SenderArgument =
        Prefixed_Name(ossysmlv2, "sendActionUsage_SenderArgument") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:specialization_General</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A Type with a superset of all instances of the specific Type, which might be the same set.</para>
    /// labels<para>specialization_General</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#specialization_General">http://open-services.net/ns/sysmlv2#specialization_General</seealso>
    let specialization_General =
        Prefixed_Name(ossysmlv2, "specialization_General") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:specialization_OwningType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Type that is the specific Type of this Specialization and owns it as its owningRelatedElement.</para>
    /// labels<para>specialization_OwningType</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#specialization_OwningType">http://open-services.net/ns/sysmlv2#specialization_OwningType</seealso>
    let specialization_OwningType =
        Prefixed_Name(ossysmlv2, "specialization_OwningType") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:specialization_Specific</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A Type with a subset of all instances of the general Type, which might be the same set.</para>
    /// labels<para>specialization_Specific</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#specialization_Specific">http://open-services.net/ns/sysmlv2#specialization_Specific</seealso>
    let specialization_Specific =
        Prefixed_Name(ossysmlv2, "specialization_Specific") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:stakeholderMembership_OwnedStakeholderParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The PartUsage specifying the stakeholder.</para>
    /// labels<para>stakeholderMembership_OwnedStakeholderParameter</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#stakeholderMembership_OwnedStakeholderParameter">http://open-services.net/ns/sysmlv2#stakeholderMembership_OwnedStakeholderParameter</seealso>
    let stakeholderMembership_OwnedStakeholderParameter =
        Prefixed_Name(ossysmlv2, "stakeholderMembership_OwnedStakeholderParameter") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:stateSubactionKind_Do</para>
    /// </summary>
    /// <remarks>
    ///   <para>ossysmlv2:StateSubactionKind</para>
    ///   <para>Indicates that the action of a StateSubactionMembership is a doAction.</para>
    /// labels<para>stateSubactionKind_Do</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#stateSubactionKind_Do">http://open-services.net/ns/sysmlv2#stateSubactionKind_Do</seealso>
    let stateSubactionKind_Do =
        Prefixed_Name(ossysmlv2, "stateSubactionKind_Do") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:stateSubactionKind_Entry</para>
    /// </summary>
    /// <remarks>
    ///   <para>ossysmlv2:StateSubactionKind</para>
    ///   <para>Indicates that the action of a StateSubactionMembership is an entryAction.</para>
    /// labels<para>stateSubactionKind_Entry</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#stateSubactionKind_Entry">http://open-services.net/ns/sysmlv2#stateSubactionKind_Entry</seealso>
    let stateSubactionKind_Entry =
        Prefixed_Name(ossysmlv2, "stateSubactionKind_Entry") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:stateSubactionKind_Exit</para>
    /// </summary>
    /// <remarks>
    ///   <para>ossysmlv2:StateSubactionKind</para>
    ///   <para>Indicates that the action of a StateSubactionMembership is an exitAction.</para>
    /// labels<para>stateSubactionKind_Exit</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#stateSubactionKind_Exit">http://open-services.net/ns/sysmlv2#stateSubactionKind_Exit</seealso>
    let stateSubactionKind_Exit =
        Prefixed_Name(ossysmlv2, "stateSubactionKind_Exit") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:stateSubactionMembership_Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ActionUsage that is the ownedMemberFeature of this StateSubactionMembership.</para>
    /// labels<para>stateSubactionMembership_Action</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#stateSubactionMembership_Action">http://open-services.net/ns/sysmlv2#stateSubactionMembership_Action</seealso>
    let stateSubactionMembership_Action =
        Prefixed_Name(ossysmlv2, "stateSubactionMembership_Action") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:stateSubactionMembership_Kind</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether this StateSubactionMembership is for an entry, do or exit ActionUsage.</para>
    /// labels<para>stateSubactionMembership_Kind</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#stateSubactionMembership_Kind">http://open-services.net/ns/sysmlv2#stateSubactionMembership_Kind</seealso>
    let stateSubactionMembership_Kind =
        Prefixed_Name(ossysmlv2, "stateSubactionMembership_Kind") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:stateUsage_DoAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ActionUsage of this StateUsage to be performed while in the state defined by the StateDefinition. It is the owned ActionUsage related to the StateUsage by a StateSubactionMembership  with kind = do.</para>
    /// labels<para>stateUsage_DoAction</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#stateUsage_DoAction">http://open-services.net/ns/sysmlv2#stateUsage_DoAction</seealso>
    let stateUsage_DoAction =
        Prefixed_Name(ossysmlv2, "stateUsage_DoAction") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:stateUsage_EntryAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ActionUsage of this StateUsage to be performed on entry to the state defined by the StateDefinition. It is the owned ActionUsage related to the StateUsage by a StateSubactionMembership  with kind = entry.</para>
    /// labels<para>stateUsage_EntryAction</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#stateUsage_EntryAction">http://open-services.net/ns/sysmlv2#stateUsage_EntryAction</seealso>
    let stateUsage_EntryAction =
        Prefixed_Name(ossysmlv2, "stateUsage_EntryAction") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:stateUsage_ExitAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ActionUsage of this StateUsage to be performed on exit to the state defined by the StateDefinition. It is the owned ActionUsage related to the StateUsage by a StateSubactionMembership  with kind = exit.</para>
    /// labels<para>stateUsage_ExitAction</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#stateUsage_ExitAction">http://open-services.net/ns/sysmlv2#stateUsage_ExitAction</seealso>
    let stateUsage_ExitAction =
        Prefixed_Name(ossysmlv2, "stateUsage_ExitAction") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:stateUsage_IsParallel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether the nestedStates of this StateUsage are to all be performed in parallel. If true, none of the nestedActions (which include nestedStates) may have any incoming or outgoing Transitions. If false, only one nestedState may be performed at a time.</para>
    /// labels<para>stateUsage_IsParallel</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#stateUsage_IsParallel">http://open-services.net/ns/sysmlv2#stateUsage_IsParallel</seealso>
    let stateUsage_IsParallel =
        Prefixed_Name(ossysmlv2, "stateUsage_IsParallel") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:stateUsage_StateDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Behaviors that are the types of this StateUsage. Nominally, these would be StateDefinitions, but kernel Behaviors are also allowed, to permit use of Behaviors from the Kernel Model Libraries.</para>
    /// labels<para>stateUsage_StateDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#stateUsage_StateDefinition">http://open-services.net/ns/sysmlv2#stateUsage_StateDefinition</seealso>
    let stateUsage_StateDefinition =
        Prefixed_Name(ossysmlv2, "stateUsage_StateDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:subclassification_Subclassifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The more specific Classifier in this Subclassification.</para>
    /// labels<para>subclassification_Subclassifier</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#subclassification_Subclassifier">http://open-services.net/ns/sysmlv2#subclassification_Subclassifier</seealso>
    let subclassification_Subclassifier =
        Prefixed_Name(ossysmlv2, "subclassification_Subclassifier") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:subclassification_Superclassifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The more general Classifier in this Subclassification.</para>
    /// labels<para>subclassification_Superclassifier</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#subclassification_Superclassifier">http://open-services.net/ns/sysmlv2#subclassification_Superclassifier</seealso>
    let subclassification_Superclassifier =
        Prefixed_Name(ossysmlv2, "subclassification_Superclassifier") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:subjectMembership_OwnedSubjectParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The UsageownedMemberParameter of this SubjectMembership.</para>
    /// labels<para>subjectMembership_OwnedSubjectParameter</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#subjectMembership_OwnedSubjectParameter">http://open-services.net/ns/sysmlv2#subjectMembership_OwnedSubjectParameter</seealso>
    let subjectMembership_OwnedSubjectParameter =
        Prefixed_Name(ossysmlv2, "subjectMembership_OwnedSubjectParameter") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:subsetting_OwningFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A subsettingFeature that is also the owningRelatedElement of this Subsetting.</para>
    /// labels<para>subsetting_OwningFeature</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#subsetting_OwningFeature">http://open-services.net/ns/sysmlv2#subsetting_OwningFeature</seealso>
    let subsetting_OwningFeature =
        Prefixed_Name(ossysmlv2, "subsetting_OwningFeature") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:subsetting_SubsettedFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Feature that is subsetted by the subsettingFeature of this Subsetting.</para>
    /// labels<para>subsetting_SubsettedFeature</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#subsetting_SubsettedFeature">http://open-services.net/ns/sysmlv2#subsetting_SubsettedFeature</seealso>
    let subsetting_SubsettedFeature =
        Prefixed_Name(ossysmlv2, "subsetting_SubsettedFeature") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:subsetting_SubsettingFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Feature that is a subset of the subsettedFeature of this Subsetting.</para>
    /// labels<para>subsetting_SubsettingFeature</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#subsetting_SubsettingFeature">http://open-services.net/ns/sysmlv2#subsetting_SubsettingFeature</seealso>
    let subsetting_SubsettingFeature =
        Prefixed_Name(ossysmlv2, "subsetting_SubsettingFeature") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:succession_EffectStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Steps that represent occurrences that are side effects of the transitionStep occurring.</para>
    /// labels<para>succession_EffectStep</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#succession_EffectStep">http://open-services.net/ns/sysmlv2#succession_EffectStep</seealso>
    let succession_EffectStep =
        Prefixed_Name(ossysmlv2, "succession_EffectStep") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:succession_GuardExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Expressions that must evaluate to true before the transitionStep can occur.</para>
    /// labels<para>succession_GuardExpression</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#succession_GuardExpression">http://open-services.net/ns/sysmlv2#succession_GuardExpression</seealso>
    let succession_GuardExpression =
        Prefixed_Name(ossysmlv2, "succession_GuardExpression") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:succession_TransitionStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A Step that is typed by the Behavior TransitionPerformances::TransitionPerformance (from the Kernel Semantic Library) that has this Succession as its transitionLink.</para>
    /// labels<para>succession_TransitionStep</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#succession_TransitionStep">http://open-services.net/ns/sysmlv2#succession_TransitionStep</seealso>
    let succession_TransitionStep =
        Prefixed_Name(ossysmlv2, "succession_TransitionStep") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:succession_TriggerStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Steps that map incoming events to the timing of occurrences of the transitionStep. The values of triggerStep subset the list of acceptable events to be received by a Behavior or the object that performs it.</para>
    /// labels<para>succession_TriggerStep</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#succession_TriggerStep">http://open-services.net/ns/sysmlv2#succession_TriggerStep</seealso>
    let succession_TriggerStep =
        Prefixed_Name(ossysmlv2, "succession_TriggerStep") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:textualRepresentation_RepresentedElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Element that is represented by this TextualRepresentation.</para>
    /// labels<para>textualRepresentation_RepresentedElement</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#textualRepresentation_RepresentedElement">http://open-services.net/ns/sysmlv2#textualRepresentation_RepresentedElement</seealso>
    let textualRepresentation_RepresentedElement =
        Prefixed_Name(ossysmlv2, "textualRepresentation_RepresentedElement") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:transitionFeatureKind_Effect</para>
    /// </summary>
    /// <remarks>
    ///   <para>ossysmlv2:TransitionFeatureKind</para>
    ///   <para>Indicates that the transitionFeature of a TransitionFeatureMembership is an effectAction.</para>
    /// labels<para>transitionFeatureKind_Effect</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#transitionFeatureKind_Effect">http://open-services.net/ns/sysmlv2#transitionFeatureKind_Effect</seealso>
    let transitionFeatureKind_Effect =
        Prefixed_Name(ossysmlv2, "transitionFeatureKind_Effect") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:transitionFeatureKind_Guard</para>
    /// </summary>
    /// <remarks>
    ///   <para>ossysmlv2:TransitionFeatureKind</para>
    ///   <para>Indicates that the transitionFeature of a TransitionFeatureMembership is a guardExpression.</para>
    /// labels<para>transitionFeatureKind_Guard</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#transitionFeatureKind_Guard">http://open-services.net/ns/sysmlv2#transitionFeatureKind_Guard</seealso>
    let transitionFeatureKind_Guard =
        Prefixed_Name(ossysmlv2, "transitionFeatureKind_Guard") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:transitionFeatureKind_Trigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>ossysmlv2:TransitionFeatureKind</para>
    ///   <para>Indicates that the transitionFeature of a TransitionFeatureMembership is a triggerAction.</para>
    /// labels<para>transitionFeatureKind_Trigger</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#transitionFeatureKind_Trigger">http://open-services.net/ns/sysmlv2#transitionFeatureKind_Trigger</seealso>
    let transitionFeatureKind_Trigger =
        Prefixed_Name(ossysmlv2, "transitionFeatureKind_Trigger") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:transitionFeatureMembership_Kind</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether this TransitionFeatureMembership  is for a trigger, guard or effect.</para>
    /// labels<para>transitionFeatureMembership_Kind</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#transitionFeatureMembership_Kind">http://open-services.net/ns/sysmlv2#transitionFeatureMembership_Kind</seealso>
    let transitionFeatureMembership_Kind =
        Prefixed_Name(ossysmlv2, "transitionFeatureMembership_Kind") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:transitionFeatureMembership_TransitionFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Step that is the ownedMemberFeature of this TransitionFeatureMembership.</para>
    /// labels<para>transitionFeatureMembership_TransitionFeature</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#transitionFeatureMembership_TransitionFeature">http://open-services.net/ns/sysmlv2#transitionFeatureMembership_TransitionFeature</seealso>
    let transitionFeatureMembership_TransitionFeature =
        Prefixed_Name(ossysmlv2, "transitionFeatureMembership_TransitionFeature") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:transitionUsage_EffectAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ActionUsages that define the effects of this TransitionUsage, which are the ownedFeatures of the TransitionUsage related to it by TransitionFeatureMemberships with kind = effect, which must all be ActionUsages.</para>
    /// labels<para>transitionUsage_EffectAction</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#transitionUsage_EffectAction">http://open-services.net/ns/sysmlv2#transitionUsage_EffectAction</seealso>
    let transitionUsage_EffectAction =
        Prefixed_Name(ossysmlv2, "transitionUsage_EffectAction") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:transitionUsage_GuardExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Expressions that define the guards of this TransitionUsage, which are the ownedFeatures of the TransitionUsage related to it by TransitionFeatureMemberships with kind = guard, which must all be Expressions.</para>
    /// labels<para>transitionUsage_GuardExpression</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#transitionUsage_GuardExpression">http://open-services.net/ns/sysmlv2#transitionUsage_GuardExpression</seealso>
    let transitionUsage_GuardExpression =
        Prefixed_Name(ossysmlv2, "transitionUsage_GuardExpression") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:transitionUsage_Source</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The source ActionUsage of this TransitionUsage, which becomes the source of the succession for the TransitionUsage.</para>
    /// labels<para>transitionUsage_Source</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#transitionUsage_Source">http://open-services.net/ns/sysmlv2#transitionUsage_Source</seealso>
    let transitionUsage_Source =
        Prefixed_Name(ossysmlv2, "transitionUsage_Source") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:transitionUsage_Succession</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Succession that is the ownedFeature of this TransitionUsage, which, if the TransitionUsage is triggered, asserts the temporal ordering of the source and target.</para>
    /// labels<para>transitionUsage_Succession</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#transitionUsage_Succession">http://open-services.net/ns/sysmlv2#transitionUsage_Succession</seealso>
    let transitionUsage_Succession =
        Prefixed_Name(ossysmlv2, "transitionUsage_Succession") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:transitionUsage_Target</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The target ActionUsage of this TransitionUsage, which is the targetFeature of the succession for the TransitionUsage.</para>
    /// labels<para>transitionUsage_Target</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#transitionUsage_Target">http://open-services.net/ns/sysmlv2#transitionUsage_Target</seealso>
    let transitionUsage_Target =
        Prefixed_Name(ossysmlv2, "transitionUsage_Target") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:triggerKind_After</para>
    /// </summary>
    /// <remarks>
    ///   <para>ossysmlv2:TriggerKind</para>
    ///   <para>Indicates a relative time trigger, corresponding to the TriggerAfter Function from the Triggers model in the Kernel Semantic Library.</para>
    /// labels<para>triggerKind_After</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#triggerKind_After">http://open-services.net/ns/sysmlv2#triggerKind_After</seealso>
    let triggerKind_After =
        Prefixed_Name(ossysmlv2, "triggerKind_After") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:triggerKind_At</para>
    /// </summary>
    /// <remarks>
    ///   <para>ossysmlv2:TriggerKind</para>
    ///   <para>Indicates an absolute time trigger, corresponding to the TriggerAt Function from the Triggers model in the Kernel Semantic Library.</para>
    /// labels<para>triggerKind_At</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#triggerKind_At">http://open-services.net/ns/sysmlv2#triggerKind_At</seealso>
    let triggerKind_At = Prefixed_Name(ossysmlv2, "triggerKind_At") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:triggerKind_When</para>
    /// </summary>
    /// <remarks>
    ///   <para>ossysmlv2:TriggerKind</para>
    ///   <para>Indicates a change trigger, corresponding to the TriggerWhen Function from the Triggers model in the Kernel Semantic Library.</para>
    /// labels<para>triggerKind_When</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#triggerKind_When">http://open-services.net/ns/sysmlv2#triggerKind_When</seealso>
    let triggerKind_When = Prefixed_Name(ossysmlv2, "triggerKind_When") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:typeFeaturing_FeatureOfType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Feature that is featured by the featuringType. It is the source of the TypeFeaturing.</para>
    /// labels<para>typeFeaturing_FeatureOfType</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#typeFeaturing_FeatureOfType">http://open-services.net/ns/sysmlv2#typeFeaturing_FeatureOfType</seealso>
    let typeFeaturing_FeatureOfType =
        Prefixed_Name(ossysmlv2, "typeFeaturing_FeatureOfType") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:typeFeaturing_FeaturingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Type that features the featureOfType. It is the target of the TypeFeaturing.</para>
    /// labels<para>typeFeaturing_FeaturingType</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#typeFeaturing_FeaturingType">http://open-services.net/ns/sysmlv2#typeFeaturing_FeaturingType</seealso>
    let typeFeaturing_FeaturingType =
        Prefixed_Name(ossysmlv2, "typeFeaturing_FeaturingType") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:typeFeaturing_OwningFeatureOfType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A featureOfType that is also the owningRelatedElement of this TypeFeaturing.</para>
    /// labels<para>typeFeaturing_OwningFeatureOfType</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#typeFeaturing_OwningFeatureOfType">http://open-services.net/ns/sysmlv2#typeFeaturing_OwningFeatureOfType</seealso>
    let typeFeaturing_OwningFeatureOfType =
        Prefixed_Name(ossysmlv2, "typeFeaturing_OwningFeatureOfType") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:type_DifferencingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The interpretations of a Type with differencingTypes are asserted to be those of the first of those Types, but not including those of the remaining Types. For example, a Classifier might be the difference of a Classifier for people and another for people of a particular nationality, leaving people who are not of that nationality. Similarly, a feature of people might be the difference between a feature for their children and a Classifier for people of a particular sex, identifying their children not of that sex (because the interpretations of the children Feature that identify those of that sex are also interpretations of the Classifier for that sex).</para>
    /// labels<para>type_DifferencingType</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#type_DifferencingType">http://open-services.net/ns/sysmlv2#type_DifferencingType</seealso>
    let type_DifferencingType =
        Prefixed_Name(ossysmlv2, "type_DifferencingType") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:type_DirectedFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The features of this Type that have a non-null direction.</para>
    /// labels<para>type_DirectedFeature</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#type_DirectedFeature">http://open-services.net/ns/sysmlv2#type_DirectedFeature</seealso>
    let type_DirectedFeature =
        Prefixed_Name(ossysmlv2, "type_DirectedFeature") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:type_EndFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>All features of this Type with isEnd = true.</para>
    /// labels<para>type_EndFeature</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#type_EndFeature">http://open-services.net/ns/sysmlv2#type_EndFeature</seealso>
    let type_EndFeature = Prefixed_Name(ossysmlv2, "type_EndFeature") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:type_Feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ownedMemberFeatures of the featureMemberships of this Type.</para>
    /// labels<para>type_Feature</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#type_Feature">http://open-services.net/ns/sysmlv2#type_Feature</seealso>
    let type_Feature = Prefixed_Name(ossysmlv2, "type_Feature") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:type_FeatureMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The FeatureMemberships for features of this Type, which include all ownedFeatureMemberships and those inheritedMemberships that are FeatureMemberships (but does not include any importedMemberships).</para>
    /// labels<para>type_FeatureMembership</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#type_FeatureMembership">http://open-services.net/ns/sysmlv2#type_FeatureMembership</seealso>
    let type_FeatureMembership =
        Prefixed_Name(ossysmlv2, "type_FeatureMembership") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:type_InheritedFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>All the memberFeatures of the inheritedMemberships of this Type that are FeatureMemberships.</para>
    /// labels<para>type_InheritedFeature</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#type_InheritedFeature">http://open-services.net/ns/sysmlv2#type_InheritedFeature</seealso>
    let type_InheritedFeature =
        Prefixed_Name(ossysmlv2, "type_InheritedFeature") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:type_InheritedMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>All Memberships inherited by this Type via Specialization or Conjugation. These are included in the derived union for the memberships of the Type.</para>
    /// labels<para>type_InheritedMembership</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#type_InheritedMembership">http://open-services.net/ns/sysmlv2#type_InheritedMembership</seealso>
    let type_InheritedMembership =
        Prefixed_Name(ossysmlv2, "type_InheritedMembership") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:type_Input</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>All features related to this Type by FeatureMemberships that have direction in or inout.</para>
    /// labels<para>type_Input</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#type_Input">http://open-services.net/ns/sysmlv2#type_Input</seealso>
    let type_Input = Prefixed_Name(ossysmlv2, "type_Input") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:type_IntersectingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The interpretations of a Type with intersectingTypes are asserted to be those in common among the intersectingTypes, which are the Types derived from the intersectingType of the ownedIntersectings of this Type. For example, a Classifier might be an intersection of Classifiers for people of a particular sex and of a particular nationality. Similarly, a feature for people's children of a particular sex might be the intersection of a Feature for their children and a Classifier for people of that sex (because the interpretations of the children Feature that identify those of that sex are also interpretations of the Classifier for that sex).</para>
    /// labels<para>type_IntersectingType</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#type_IntersectingType">http://open-services.net/ns/sysmlv2#type_IntersectingType</seealso>
    let type_IntersectingType =
        Prefixed_Name(ossysmlv2, "type_IntersectingType") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:type_IsAbstract</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates whether instances of this Type must also be instances of at least one of its specialized Types.</para>
    /// labels<para>type_IsAbstract</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#type_IsAbstract">http://open-services.net/ns/sysmlv2#type_IsAbstract</seealso>
    let type_IsAbstract = Prefixed_Name(ossysmlv2, "type_IsAbstract") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:type_IsConjugated</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates whether this Type has an ownedConjugator.</para>
    /// labels<para>type_IsConjugated</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#type_IsConjugated">http://open-services.net/ns/sysmlv2#type_IsConjugated</seealso>
    let type_IsConjugated =
        Prefixed_Name(ossysmlv2, "type_IsConjugated") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:type_IsSufficient</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether all things that meet the classification conditions of this Type must be classified by the Type.</para>
    /// labels<para>type_IsSufficient</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#type_IsSufficient">http://open-services.net/ns/sysmlv2#type_IsSufficient</seealso>
    let type_IsSufficient =
        Prefixed_Name(ossysmlv2, "type_IsSufficient") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:type_Multiplicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An ownedMember of this Type that is a Multiplicity, which constraints the cardinality of the Type. If there is no such ownedMember, then the cardinality of this Type is constrained by all the Multiplicity constraints applicable to any direct supertypes.</para>
    /// labels<para>type_Multiplicity</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#type_Multiplicity">http://open-services.net/ns/sysmlv2#type_Multiplicity</seealso>
    let type_Multiplicity =
        Prefixed_Name(ossysmlv2, "type_Multiplicity") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:type_Output</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>All features related to this Type by FeatureMemberships that have direction out or inout.</para>
    /// labels<para>type_Output</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#type_Output">http://open-services.net/ns/sysmlv2#type_Output</seealso>
    let type_Output = Prefixed_Name(ossysmlv2, "type_Output") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:type_OwnedConjugator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A Conjugation owned by this Type for which the Type is the originalType.</para>
    /// labels<para>type_OwnedConjugator</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#type_OwnedConjugator">http://open-services.net/ns/sysmlv2#type_OwnedConjugator</seealso>
    let type_OwnedConjugator =
        Prefixed_Name(ossysmlv2, "type_OwnedConjugator") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:type_OwnedDifferencing</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ownedRelationships of this Type that are Differencings, having this Type as their typeDifferenced.</para>
    /// labels<para>type_OwnedDifferencing</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#type_OwnedDifferencing">http://open-services.net/ns/sysmlv2#type_OwnedDifferencing</seealso>
    let type_OwnedDifferencing =
        Prefixed_Name(ossysmlv2, "type_OwnedDifferencing") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:type_UnioningType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The interpretations of a Type with unioningTypes are asserted to be the same as those of all the unioningTypes together, which are the Types derived from the unioningType of the ownedUnionings of this Type. For example, a Classifier for people might be the union of Classifiers for all the sexes. Similarly, a feature for people's children might be the union of features dividing them in the same ways as people in general.</para>
    /// labels<para>type_UnioningType</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#type_UnioningType">http://open-services.net/ns/sysmlv2#type_UnioningType</seealso>
    let type_UnioningType =
        Prefixed_Name(ossysmlv2, "type_UnioningType") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:unioning_TypeUnioned</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Type with interpretations partly determined by unioningType, as described in Type::unioningType.</para>
    /// labels<para>unioning_TypeUnioned</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#unioning_TypeUnioned">http://open-services.net/ns/sysmlv2#unioning_TypeUnioned</seealso>
    let unioning_TypeUnioned =
        Prefixed_Name(ossysmlv2, "unioning_TypeUnioned") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:unioning_UnioningType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Type that partly determines interpretations of typeUnioned, as described in Type::unioningType.</para>
    /// labels<para>unioning_UnioningType</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#unioning_UnioningType">http://open-services.net/ns/sysmlv2#unioning_UnioningType</seealso>
    let unioning_UnioningType =
        Prefixed_Name(ossysmlv2, "unioning_UnioningType") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:usage_Definition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Classifiers that are the types of this Usage. Nominally, these are Definitions, but other kinds of Kernel Classifiers are also allowed, to permit use of Classifiers from the Kernel Model Libraries.</para>
    /// labels<para>usage_Definition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#usage_Definition">http://open-services.net/ns/sysmlv2#usage_Definition</seealso>
    let usage_Definition = Prefixed_Name(ossysmlv2, "usage_Definition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:usage_DirectedUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The usages of this Usage that are directedFeatures.</para>
    /// labels<para>usage_DirectedUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#usage_DirectedUsage">http://open-services.net/ns/sysmlv2#usage_DirectedUsage</seealso>
    let usage_DirectedUsage =
        Prefixed_Name(ossysmlv2, "usage_DirectedUsage") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:usage_IsReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether this Usage is a referential Usage, that is, it has isComposite = false.</para>
    /// labels<para>usage_IsReference</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#usage_IsReference">http://open-services.net/ns/sysmlv2#usage_IsReference</seealso>
    let usage_IsReference =
        Prefixed_Name(ossysmlv2, "usage_IsReference") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:usage_IsVariation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether this Usage is for a variation point or not. If true, then all the memberships of the Usage must be VariantMemberships.</para>
    /// labels<para>usage_IsVariation</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#usage_IsVariation">http://open-services.net/ns/sysmlv2#usage_IsVariation</seealso>
    let usage_IsVariation =
        Prefixed_Name(ossysmlv2, "usage_IsVariation") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:usage_NestedAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ActionUsages that are nestedUsages of this Usage.</para>
    /// labels<para>usage_NestedAction</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#usage_NestedAction">http://open-services.net/ns/sysmlv2#usage_NestedAction</seealso>
    let usage_NestedAction =
        Prefixed_Name(ossysmlv2, "usage_NestedAction") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:usage_NestedAllocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The AllocationUsages that are nestedUsages of this Usage.</para>
    /// labels<para>usage_NestedAllocation</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#usage_NestedAllocation">http://open-services.net/ns/sysmlv2#usage_NestedAllocation</seealso>
    let usage_NestedAllocation =
        Prefixed_Name(ossysmlv2, "usage_NestedAllocation") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:usage_NestedAnalysisCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The AnalysisCaseUsages that are nestedUsages of this Usage.</para>
    /// labels<para>usage_NestedAnalysisCase</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#usage_NestedAnalysisCase">http://open-services.net/ns/sysmlv2#usage_NestedAnalysisCase</seealso>
    let usage_NestedAnalysisCase =
        Prefixed_Name(ossysmlv2, "usage_NestedAnalysisCase") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:usage_NestedAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The code&gt;AttributeUsages that are nestedUsages of this Usage.</para>
    /// labels<para>usage_NestedAttribute</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#usage_NestedAttribute">http://open-services.net/ns/sysmlv2#usage_NestedAttribute</seealso>
    let usage_NestedAttribute =
        Prefixed_Name(ossysmlv2, "usage_NestedAttribute") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:usage_NestedCalculation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The CalculationUsage that are nestedUsages of this Usage.</para>
    /// labels<para>usage_NestedCalculation</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#usage_NestedCalculation">http://open-services.net/ns/sysmlv2#usage_NestedCalculation</seealso>
    let usage_NestedCalculation =
        Prefixed_Name(ossysmlv2, "usage_NestedCalculation") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:usage_NestedCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The CaseUsages that are nestedUsages of this Usage.</para>
    /// labels<para>usage_NestedCase</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#usage_NestedCase">http://open-services.net/ns/sysmlv2#usage_NestedCase</seealso>
    let usage_NestedCase = Prefixed_Name(ossysmlv2, "usage_NestedCase") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:usage_NestedConcern</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ConcernUsages that are nestedUsages of this Usage.</para>
    /// labels<para>usage_NestedConcern</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#usage_NestedConcern">http://open-services.net/ns/sysmlv2#usage_NestedConcern</seealso>
    let usage_NestedConcern =
        Prefixed_Name(ossysmlv2, "usage_NestedConcern") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:usage_NestedConnection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ConnectorAsUsages that are nestedUsages of this Usage. Note that this list includes BindingConnectorAsUsages and SuccessionAsUsages, even though these are ConnectorAsUsages but not ConnectionUsages.</para>
    /// labels<para>usage_NestedConnection</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#usage_NestedConnection">http://open-services.net/ns/sysmlv2#usage_NestedConnection</seealso>
    let usage_NestedConnection =
        Prefixed_Name(ossysmlv2, "usage_NestedConnection") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:usage_NestedConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ConstraintUsages that are nestedUsages of this Usage.</para>
    /// labels<para>usage_NestedConstraint</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#usage_NestedConstraint">http://open-services.net/ns/sysmlv2#usage_NestedConstraint</seealso>
    let usage_NestedConstraint =
        Prefixed_Name(ossysmlv2, "usage_NestedConstraint") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:usage_NestedEnumeration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The code&gt;EnumerationUsages that are nestedUsages of this Usage.</para>
    /// labels<para>usage_NestedEnumeration</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#usage_NestedEnumeration">http://open-services.net/ns/sysmlv2#usage_NestedEnumeration</seealso>
    let usage_NestedEnumeration =
        Prefixed_Name(ossysmlv2, "usage_NestedEnumeration") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:usage_NestedFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The code&gt;FlowConnectionUsages that are nestedUsages of this Usage.</para>
    /// labels<para>usage_NestedFlow</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#usage_NestedFlow">http://open-services.net/ns/sysmlv2#usage_NestedFlow</seealso>
    let usage_NestedFlow = Prefixed_Name(ossysmlv2, "usage_NestedFlow") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:usage_NestedInterface</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The InterfaceUsages that are nestedUsages of this Usage.</para>
    /// labels<para>usage_NestedInterface</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#usage_NestedInterface">http://open-services.net/ns/sysmlv2#usage_NestedInterface</seealso>
    let usage_NestedInterface =
        Prefixed_Name(ossysmlv2, "usage_NestedInterface") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:usage_NestedItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ItemUsages that are nestedUsages of this Usage.</para>
    /// labels<para>usage_NestedItem</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#usage_NestedItem">http://open-services.net/ns/sysmlv2#usage_NestedItem</seealso>
    let usage_NestedItem = Prefixed_Name(ossysmlv2, "usage_NestedItem") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:usage_NestedMetadata</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The MetadataUsages that are nestedUsages of this of this Usage.</para>
    /// labels<para>usage_NestedMetadata</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#usage_NestedMetadata">http://open-services.net/ns/sysmlv2#usage_NestedMetadata</seealso>
    let usage_NestedMetadata =
        Prefixed_Name(ossysmlv2, "usage_NestedMetadata") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:element_ElementId</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The globally unique identifier for this Element. This is intended to be set by tooling, and it must not change during the lifetime of the Element.</para>
    /// labels<para>element_ElementId</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#element_ElementId">http://open-services.net/ns/sysmlv2#element_ElementId</seealso>
    let element_ElementId =
        Prefixed_Name(ossysmlv2, "element_ElementId") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:element_OwnedRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Relationships for which this Element is the owningRelatedElement.</para>
    /// labels<para>element_OwnedRelationship</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#element_OwnedRelationship">http://open-services.net/ns/sysmlv2#element_OwnedRelationship</seealso>
    let element_OwnedRelationship =
        Prefixed_Name(ossysmlv2, "element_OwnedRelationship") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:stateDefinition_DoAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ActionUsage of this StateDefinition to be performed while in the state defined by the StateDefinition. It is the owned ActionUsage related to the StateDefinition by a StateSubactionMembership  with kind = do.</para>
    /// labels<para>stateDefinition_DoAction</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#stateDefinition_DoAction">http://open-services.net/ns/sysmlv2#stateDefinition_DoAction</seealso>
    let stateDefinition_DoAction =
        Prefixed_Name(ossysmlv2, "stateDefinition_DoAction") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:stateDefinition_ExitAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ActionUsage of this StateDefinition to be performed on exit to the state defined by the StateDefinition. It is the owned ActionUsage related to the StateDefinition by a StateSubactionMembership  with kind = exit.</para>
    /// labels<para>stateDefinition_ExitAction</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#stateDefinition_ExitAction">http://open-services.net/ns/sysmlv2#stateDefinition_ExitAction</seealso>
    let stateDefinition_ExitAction =
        Prefixed_Name(ossysmlv2, "stateDefinition_ExitAction") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:Type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Type is a Namespace that is the most general kind of Element supporting the semantics of classification. A Type may be a Classifier or a Feature, defining conditions on what is classified by the Type (see also the description of isSufficient).</para>
    /// labels<para>Type</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Type">http://open-services.net/ns/sysmlv2#Type</seealso>
    let Type = Prefixed_Name(ossysmlv2, "Type") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:OperatorExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An OperatorExpression is an InvocationExpression whose function is determined by resolving its operator in the context of one of the standard packages from the Kernel Function Library.</para>
    /// labels<para>OperatorExpression</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#OperatorExpression">http://open-services.net/ns/sysmlv2#OperatorExpression</seealso>
    let OperatorExpression =
        Prefixed_Name(ossysmlv2, "OperatorExpression") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:Comment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Comment is an AnnotatingElement whose body in some way describes its annotatedElements.</para>
    /// labels<para>Comment</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Comment">http://open-services.net/ns/sysmlv2#Comment</seealso>
    let Comment = Prefixed_Name(ossysmlv2, "Comment") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:ConcernUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A ConcernUsage is a Usage of a ConcernDefinition.</para>
    /// labels<para>ConcernUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#ConcernUsage">http://open-services.net/ns/sysmlv2#ConcernUsage</seealso>
    let ConcernUsage = Prefixed_Name(ossysmlv2, "ConcernUsage") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:PortDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A PortDefinition defines a point at which external entities can connect to and interact with a system or part of a system. Any ownedUsages of a PortDefinition, other than PortUsages, must not be composite.</para>
    /// labels<para>PortDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#PortDefinition">http://open-services.net/ns/sysmlv2#PortDefinition</seealso>
    let PortDefinition = Prefixed_Name(ossysmlv2, "PortDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:ConjugatedPortTyping</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A ConjugatedPortTyping is a FeatureTyping whose type is a ConjugatedPortDefinition. (This relationship is intended to be an abstract-syntax marker for a special surface notation for conjugated typing of ports.).</para>
    /// labels<para>ConjugatedPortTyping</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#ConjugatedPortTyping">http://open-services.net/ns/sysmlv2#ConjugatedPortTyping</seealso>
    let ConjugatedPortTyping =
        Prefixed_Name(ossysmlv2, "ConjugatedPortTyping") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:PartDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A PartDefinition is an ItemDefinition of a Class of systems or parts of systems. Note that all parts may be considered items for certain purposes, but not all items are parts that can perform actions within a system.</para>
    /// labels<para>PartDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#PartDefinition">http://open-services.net/ns/sysmlv2#PartDefinition</seealso>
    let PartDefinition = Prefixed_Name(ossysmlv2, "PartDefinition") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:Feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Feature is a Type that classifies relations between multiple things (in the universe). The domain of the relation is the intersection of the featuringTypes of the Feature. (The domain of a Feature with no featuringTyps is implicitly the most general Type Base::Anything from the Kernel Semantic Library.) The co-domain of the relation is the intersection of the types of the Feature.
    ///
    /// .</para>
    /// labels<para>Feature</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Feature">http://open-services.net/ns/sysmlv2#Feature</seealso>
    let Feature = Prefixed_Name(ossysmlv2, "Feature") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:Predicate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Predicate is a Function whose result parameter has type Boolean and multiplicity 1..1.</para>
    /// labels<para>Predicate</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Predicate">http://open-services.net/ns/sysmlv2#Predicate</seealso>
    let Predicate = Prefixed_Name(ossysmlv2, "Predicate") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:ControlNode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A ControlNode is an ActionUsage that does not have any inherent behavior but provides constraints on incoming and outgoing Successions that are used to control other Actions. A ControlNode must be a composite owned usage of an ActionDefinition or ActionUsage.</para>
    /// labels<para>ControlNode</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#ControlNode">http://open-services.net/ns/sysmlv2#ControlNode</seealso>
    let ControlNode = Prefixed_Name(ossysmlv2, "ControlNode") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:Dependency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Dependency is a Relationship that indicates that one or more client Elements require one more supplier Elements for their complete specification. In general, this means that a change to one of the supplier Elements may necessitate a change to, or re-specification of, the client Elements.</para>
    /// labels<para>Dependency</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Dependency">http://open-services.net/ns/sysmlv2#Dependency</seealso>
    let Dependency = Prefixed_Name(ossysmlv2, "Dependency") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:Differencing</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Differencing is a Relationship that makes its differencingType one of the differencingTypes of its typeDifferenced.</para>
    /// labels<para>Differencing</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Differencing">http://open-services.net/ns/sysmlv2#Differencing</seealso>
    let Differencing = Prefixed_Name(ossysmlv2, "Differencing") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:Disjoining</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Disjoining is a Relationship between Types asserted to have interpretations that are not shared (disjoint) between them, identified as typeDisjoined and disjoiningType. For example, a Classifier for mammals is disjoint from a Classifier for minerals, and a Feature for people's parents is disjoint from a Feature for their children.</para>
    /// labels<para>Disjoining</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Disjoining">http://open-services.net/ns/sysmlv2#Disjoining</seealso>
    let Disjoining = Prefixed_Name(ossysmlv2, "Disjoining") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:behavior_Step</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Steps that make up this Behavior.</para>
    /// labels<para>behavior_Step</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#behavior_Step">http://open-services.net/ns/sysmlv2#behavior_Step</seealso>
    let behavior_Step = Prefixed_Name(ossysmlv2, "behavior_Step") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:metadataFeature_Metaclass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The type of this MetadataFeature, which must be a Metaclass.</para>
    /// labels<para>metadataFeature_Metaclass</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#metadataFeature_Metaclass">http://open-services.net/ns/sysmlv2#metadataFeature_Metaclass</seealso>
    let metadataFeature_Metaclass =
        Prefixed_Name(ossysmlv2, "metadataFeature_Metaclass") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:metadataUsage_MetadataDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The MetadataDefinition that is the definition of this MetadataUsage.</para>
    /// labels<para>metadataUsage_MetadataDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#metadataUsage_MetadataDefinition">http://open-services.net/ns/sysmlv2#metadataUsage_MetadataDefinition</seealso>
    let metadataUsage_MetadataDefinition =
        Prefixed_Name(ossysmlv2, "metadataUsage_MetadataDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:multiplicityRange_Bound</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The owned Expressions of the MultiplicityRange whose results provide its bounds. These must be the only ownedMembers of the MultiplicityRange.</para>
    /// labels<para>multiplicityRange_Bound</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#multiplicityRange_Bound">http://open-services.net/ns/sysmlv2#multiplicityRange_Bound</seealso>
    let multiplicityRange_Bound =
        Prefixed_Name(ossysmlv2, "multiplicityRange_Bound") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:multiplicityRange_UpperBound</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Expression whose result is the upper bound of the MultiplicityRange.</para>
    /// labels<para>multiplicityRange_UpperBound</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#multiplicityRange_UpperBound">http://open-services.net/ns/sysmlv2#multiplicityRange_UpperBound</seealso>
    let multiplicityRange_UpperBound =
        Prefixed_Name(ossysmlv2, "multiplicityRange_UpperBound") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:namespaceImport_ImportedNamespace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Namespace whose visible Memberships are imported by this NamespaceImport.</para>
    /// labels<para>namespaceImport_ImportedNamespace</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#namespaceImport_ImportedNamespace">http://open-services.net/ns/sysmlv2#namespaceImport_ImportedNamespace</seealso>
    let namespaceImport_ImportedNamespace =
        Prefixed_Name(ossysmlv2, "namespaceImport_ImportedNamespace") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:namespace_Membership</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>All Memberships in this Namespace, including (at least) the union of ownedMemberships and importedMemberships.</para>
    /// labels<para>namespace_Membership</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#namespace_Membership">http://open-services.net/ns/sysmlv2#namespace_Membership</seealso>
    let namespace_Membership =
        Prefixed_Name(ossysmlv2, "namespace_Membership") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:namespace_OwnedImport</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ownedRelationships of this Namespace that are Imports, for which the Namespace is the importOwningNamespace.</para>
    /// labels<para>namespace_OwnedImport</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#namespace_OwnedImport">http://open-services.net/ns/sysmlv2#namespace_OwnedImport</seealso>
    let namespace_OwnedImport =
        Prefixed_Name(ossysmlv2, "namespace_OwnedImport") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:namespace_OwnedMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The owned members of this Namespace, which are the ownedMemberElements of the ownedMemberships of the .</para>
    /// labels<para>namespace_OwnedMember</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#namespace_OwnedMember">http://open-services.net/ns/sysmlv2#namespace_OwnedMember</seealso>
    let namespace_OwnedMember =
        Prefixed_Name(ossysmlv2, "namespace_OwnedMember") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:occurrenceDefinition_IsIndividual</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Whether this OccurrenceDefinition is constrained to represent single individual.</para>
    /// labels<para>occurrenceDefinition_IsIndividual</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#occurrenceDefinition_IsIndividual">http://open-services.net/ns/sysmlv2#occurrenceDefinition_IsIndividual</seealso>
    let occurrenceDefinition_IsIndividual =
        Prefixed_Name(ossysmlv2, "occurrenceDefinition_IsIndividual") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:occurrenceDefinition_LifeClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>If isIndividual is true, a LifeClass that specializes this OccurrenceDefinition, restricting it to represent an individual.</para>
    /// labels<para>occurrenceDefinition_LifeClass</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#occurrenceDefinition_LifeClass">http://open-services.net/ns/sysmlv2#occurrenceDefinition_LifeClass</seealso>
    let occurrenceDefinition_LifeClass =
        Prefixed_Name(ossysmlv2, "occurrenceDefinition_LifeClass") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:occurrenceUsage_IndividualDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The at most one occurrenceDefinition that has isIndividual = true.</para>
    /// labels<para>occurrenceUsage_IndividualDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#occurrenceUsage_IndividualDefinition">http://open-services.net/ns/sysmlv2#occurrenceUsage_IndividualDefinition</seealso>
    let occurrenceUsage_IndividualDefinition =
        Prefixed_Name(ossysmlv2, "occurrenceUsage_IndividualDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:occurrenceUsage_OccurrenceDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Classes that are the types of this OccurrenceUsage. Nominally, these are OccurrenceDefinitions, but other kinds of kernel Classes are also allowed, to permit use of Classes from the Kernel Model Libraries.</para>
    /// labels<para>occurrenceUsage_OccurrenceDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#occurrenceUsage_OccurrenceDefinition">http://open-services.net/ns/sysmlv2#occurrenceUsage_OccurrenceDefinition</seealso>
    let occurrenceUsage_OccurrenceDefinition =
        Prefixed_Name(ossysmlv2, "occurrenceUsage_OccurrenceDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:occurrenceUsage_PortionKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The kind of (temporal) portion of the life of the occurrenceDefinition represented by this OccurrenceUsage, if it is so restricted.</para>
    /// labels<para>occurrenceUsage_PortionKind</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#occurrenceUsage_PortionKind">http://open-services.net/ns/sysmlv2#occurrenceUsage_PortionKind</seealso>
    let occurrenceUsage_PortionKind =
        Prefixed_Name(ossysmlv2, "occurrenceUsage_PortionKind") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:operatorExpression_Operator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An operator symbol that names a corresponding Function from one of the standard packages from the Kernel Function Library .</para>
    /// labels<para>operatorExpression_Operator</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#operatorExpression_Operator">http://open-services.net/ns/sysmlv2#operatorExpression_Operator</seealso>
    let operatorExpression_Operator =
        Prefixed_Name(ossysmlv2, "operatorExpression_Operator") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:owningMembership_OwnedMemberElementId</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The elementId of the ownedMemberElement.</para>
    /// labels<para>owningMembership_OwnedMemberElementId</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#owningMembership_OwnedMemberElementId">http://open-services.net/ns/sysmlv2#owningMembership_OwnedMemberElementId</seealso>
    let owningMembership_OwnedMemberElementId =
        Prefixed_Name(ossysmlv2, "owningMembership_OwnedMemberElementId") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:owningMembership_OwnedMemberName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The name of the ownedMemberElement.</para>
    /// labels<para>owningMembership_OwnedMemberName</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#owningMembership_OwnedMemberName">http://open-services.net/ns/sysmlv2#owningMembership_OwnedMemberName</seealso>
    let owningMembership_OwnedMemberName =
        Prefixed_Name(ossysmlv2, "owningMembership_OwnedMemberName") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:owningMembership_OwnedMemberShortName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The shortName of the ownedMemberElement.</para>
    /// labels<para>owningMembership_OwnedMemberShortName</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#owningMembership_OwnedMemberShortName">http://open-services.net/ns/sysmlv2#owningMembership_OwnedMemberShortName</seealso>
    let owningMembership_OwnedMemberShortName =
        Prefixed_Name(ossysmlv2, "owningMembership_OwnedMemberShortName") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:viewUsage_ViewDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ViewDefinition that is the definition of this ViewUsage.</para>
    /// labels<para>viewUsage_ViewDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#viewUsage_ViewDefinition">http://open-services.net/ns/sysmlv2#viewUsage_ViewDefinition</seealso>
    let viewUsage_ViewDefinition =
        Prefixed_Name(ossysmlv2, "viewUsage_ViewDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:viewUsage_ViewRendering</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The RenderingUsage to be used to render views defined by this ViewUsage, which is the referencedRendering of the ViewRenderingMembership of the ViewUsage.</para>
    /// labels<para>viewUsage_ViewRendering</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#viewUsage_ViewRendering">http://open-services.net/ns/sysmlv2#viewUsage_ViewRendering</seealso>
    let viewUsage_ViewRendering =
        Prefixed_Name(ossysmlv2, "viewUsage_ViewRendering") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:CalculationDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A CalculationDefinition is an ActionDefinition that also defines a Function producing a result.</para>
    /// labels<para>CalculationDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#CalculationDefinition">http://open-services.net/ns/sysmlv2#CalculationDefinition</seealso>
    let CalculationDefinition =
        Prefixed_Name(ossysmlv2, "CalculationDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:textualRepresentation_Body</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The textual representation of the representedElement in the given language.</para>
    /// labels<para>textualRepresentation_Body</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#textualRepresentation_Body">http://open-services.net/ns/sysmlv2#textualRepresentation_Body</seealso>
    let textualRepresentation_Body =
        Prefixed_Name(ossysmlv2, "textualRepresentation_Body") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:textualRepresentation_Language</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The natural or artifical language in which the body text is written.</para>
    /// labels<para>textualRepresentation_Language</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#textualRepresentation_Language">http://open-services.net/ns/sysmlv2#textualRepresentation_Language</seealso>
    let textualRepresentation_Language =
        Prefixed_Name(ossysmlv2, "textualRepresentation_Language") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:PartUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A PartUsage is a usage of a PartDefinition to represent a system or a part of a system. At least one of the itemDefinitions of the PartUsage must be a PartDefinition.</para>
    /// labels<para>PartUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#PartUsage">http://open-services.net/ns/sysmlv2#PartUsage</seealso>
    let PartUsage = Prefixed_Name(ossysmlv2, "PartUsage") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:type_OwnedDisjoining</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ownedRelationships of this Type that are Disjoinings, for which the Type is the typeDisjoined Type.</para>
    /// labels<para>type_OwnedDisjoining</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#type_OwnedDisjoining">http://open-services.net/ns/sysmlv2#type_OwnedDisjoining</seealso>
    let type_OwnedDisjoining =
        Prefixed_Name(ossysmlv2, "type_OwnedDisjoining") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:type_OwnedEndFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>All endFeatures of this Type that are ownedFeatures.</para>
    /// labels<para>type_OwnedEndFeature</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#type_OwnedEndFeature">http://open-services.net/ns/sysmlv2#type_OwnedEndFeature</seealso>
    let type_OwnedEndFeature =
        Prefixed_Name(ossysmlv2, "type_OwnedEndFeature") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:type_OwnedFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ownedMemberFeatures of the ownedFeatureMemberships of this Type.</para>
    /// labels<para>type_OwnedFeature</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#type_OwnedFeature">http://open-services.net/ns/sysmlv2#type_OwnedFeature</seealso>
    let type_OwnedFeature =
        Prefixed_Name(ossysmlv2, "type_OwnedFeature") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:type_OwnedIntersecting</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ownedRelationships of this Type that are Intersectings, have the Type as their typeIntersected.</para>
    /// labels<para>type_OwnedIntersecting</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#type_OwnedIntersecting">http://open-services.net/ns/sysmlv2#type_OwnedIntersecting</seealso>
    let type_OwnedIntersecting =
        Prefixed_Name(ossysmlv2, "type_OwnedIntersecting") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:ConstraintDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A ConstraintDefinition is an OccurrenceDefinition that is also a Predicate that defines a constraint that may be asserted to hold on a system or part of a system.</para>
    /// labels<para>ConstraintDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#ConstraintDefinition">http://open-services.net/ns/sysmlv2#ConstraintDefinition</seealso>
    let ConstraintDefinition =
        Prefixed_Name(ossysmlv2, "ConstraintDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:DecisionNode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A DecisionNode is a ControlNode that makes a selection from its outgoing Successions.</para>
    /// labels<para>DecisionNode</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#DecisionNode">http://open-services.net/ns/sysmlv2#DecisionNode</seealso>
    let DecisionNode = Prefixed_Name(ossysmlv2, "DecisionNode") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:Documentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Documentation is a Comment that specifically documents a documentedElement, which must be its owner.</para>
    /// labels<para>Documentation</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Documentation">http://open-services.net/ns/sysmlv2#Documentation</seealso>
    let Documentation = Prefixed_Name(ossysmlv2, "Documentation") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:caseDefinition_SubjectParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The parameter of this CaseDefinition that represents its subject.</para>
    /// labels<para>caseDefinition_SubjectParameter</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#caseDefinition_SubjectParameter">http://open-services.net/ns/sysmlv2#caseDefinition_SubjectParameter</seealso>
    let caseDefinition_SubjectParameter =
        Prefixed_Name(ossysmlv2, "caseDefinition_SubjectParameter") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:caseUsage_ActorParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The parameters of this CaseUsage that represent actors involved in the case.</para>
    /// labels<para>caseUsage_ActorParameter</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#caseUsage_ActorParameter">http://open-services.net/ns/sysmlv2#caseUsage_ActorParameter</seealso>
    let caseUsage_ActorParameter =
        Prefixed_Name(ossysmlv2, "caseUsage_ActorParameter") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:namespace_Member</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The set of all member Elements of this Namespace, which are the memberElements of all memberships of the Namespace.</para>
    /// labels<para>namespace_Member</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#namespace_Member">http://open-services.net/ns/sysmlv2#namespace_Member</seealso>
    let namespace_Member = Prefixed_Name(ossysmlv2, "namespace_Member") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:usage_NestedViewpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ViewpointUsages that are nestedUsages of this Usage.</para>
    /// labels<para>usage_NestedViewpoint</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#usage_NestedViewpoint">http://open-services.net/ns/sysmlv2#usage_NestedViewpoint</seealso>
    let usage_NestedViewpoint =
        Prefixed_Name(ossysmlv2, "usage_NestedViewpoint") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:usage_OwningDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Definition that owns this Usage (if any).</para>
    /// labels<para>usage_OwningDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#usage_OwningDefinition">http://open-services.net/ns/sysmlv2#usage_OwningDefinition</seealso>
    let usage_OwningDefinition =
        Prefixed_Name(ossysmlv2, "usage_OwningDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:assignmentActionUsage_ValueExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Expression whose result is to be assigned to the referent Feature.</para>
    /// labels<para>assignmentActionUsage_ValueExpression</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#assignmentActionUsage_ValueExpression">http://open-services.net/ns/sysmlv2#assignmentActionUsage_ValueExpression</seealso>
    let assignmentActionUsage_ValueExpression =
        Prefixed_Name(ossysmlv2, "assignmentActionUsage_ValueExpression") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:usage_NestedOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The OccurrenceUsages that are nestedUsages of this Usage.</para>
    /// labels<para>usage_NestedOccurrence</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#usage_NestedOccurrence">http://open-services.net/ns/sysmlv2#usage_NestedOccurrence</seealso>
    let usage_NestedOccurrence =
        Prefixed_Name(ossysmlv2, "usage_NestedOccurrence") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:usage_NestedPort</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The PortUsages that are nestedUsages of this Usage.</para>
    /// labels<para>usage_NestedPort</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#usage_NestedPort">http://open-services.net/ns/sysmlv2#usage_NestedPort</seealso>
    let usage_NestedPort = Prefixed_Name(ossysmlv2, "usage_NestedPort") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:usage_NestedRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The RequirementUsages that are nestedUsages of this Usage.</para>
    /// labels<para>usage_NestedRequirement</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#usage_NestedRequirement">http://open-services.net/ns/sysmlv2#usage_NestedRequirement</seealso>
    let usage_NestedRequirement =
        Prefixed_Name(ossysmlv2, "usage_NestedRequirement") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:usage_NestedState</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The StateUsages that are nestedUsages of this Usage.</para>
    /// labels<para>usage_NestedState</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#usage_NestedState">http://open-services.net/ns/sysmlv2#usage_NestedState</seealso>
    let usage_NestedState =
        Prefixed_Name(ossysmlv2, "usage_NestedState") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:OwningMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An OwningMembership is a Membership that owns its memberElement as a ownedRelatedElement. The ownedMemberElement becomes an ownedMember of the membershipOwningNamespace.</para>
    /// labels<para>OwningMembership</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#OwningMembership">http://open-services.net/ns/sysmlv2#OwningMembership</seealso>
    let OwningMembership = Prefixed_Name(ossysmlv2, "OwningMembership") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:EnumerationDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An EnumerationDefinition is an AttributeDefinition all of whose instances are given by an explicit list of enumeratedValues. This is realized by requiring that the EnumerationDefinition have isVariation = true, with the enumeratedValues being its variants.</para>
    /// labels<para>EnumerationDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#EnumerationDefinition">http://open-services.net/ns/sysmlv2#EnumerationDefinition</seealso>
    let EnumerationDefinition =
        Prefixed_Name(ossysmlv2, "EnumerationDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:EventOccurrenceUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An EventOccurrenceUsage is an OccurrenceUsage that represents another OccurrenceUsage occurring as a suboccurrence of the containing occurrence of the EventOccurrenceUsage. Unless it is the EventOccurrenceUsage itself, the referenced OccurrenceUsage is related to the EventOccurrenceUsage by a ReferenceSubsetting Relationship.</para>
    /// labels<para>EventOccurrenceUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#EventOccurrenceUsage">http://open-services.net/ns/sysmlv2#EventOccurrenceUsage</seealso>
    let EventOccurrenceUsage =
        Prefixed_Name(ossysmlv2, "EventOccurrenceUsage") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:ExhibitStateUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An ExhibitStateUsage is a StateUsage that represents the exhibiting of a StateUsage. Unless it is the StateUsage itself, the StateUsage to be exhibited is related to the ExhibitStateUsage by a ReferenceSubsetting Relationship. An ExhibitStateUsage is also a PerformActionUsage, with its exhibitedState as the performedAction.</para>
    /// labels<para>ExhibitStateUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#ExhibitStateUsage">http://open-services.net/ns/sysmlv2#ExhibitStateUsage</seealso>
    let ExhibitStateUsage =
        Prefixed_Name(ossysmlv2, "ExhibitStateUsage") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:StateUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A StateUsage is an ActionUsage that is nominally the Usage of a StateDefinition. However, other kinds of kernel Behaviors are also allowed as types, to permit use of Behaviors
    /// .</para>
    /// labels<para>StateUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#StateUsage">http://open-services.net/ns/sysmlv2#StateUsage</seealso>
    let StateUsage = Prefixed_Name(ossysmlv2, "StateUsage") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:Expose</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An Expose is an Import of Memberships into a ViewUsage that provide the Elements to be included in a view. Visibility is always ignored for an Expose (i.e., isImportAll = true).</para>
    /// labels<para>Expose</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Expose">http://open-services.net/ns/sysmlv2#Expose</seealso>
    let Expose = Prefixed_Name(ossysmlv2, "Expose") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:FeatureChainExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A FeatureChainExpression is an OperatorExpression whose operator is ".", which resolves to the Function ControlFunctions::'.' from the Kernel Functions Library. It evaluates to the result of chaining the result Feature of its single argument Expression with its targetFeature.</para>
    /// labels<para>FeatureChainExpression</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#FeatureChainExpression">http://open-services.net/ns/sysmlv2#FeatureChainExpression</seealso>
    let FeatureChainExpression =
        Prefixed_Name(ossysmlv2, "FeatureChainExpression") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:FeatureDirectionKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>FeatureDirectionKind enumerates the possible kinds of direction that a Feature may be given as a member of a Type.</para>
    /// labels<para>FeatureDirectionKind</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#FeatureDirectionKind">http://open-services.net/ns/sysmlv2#FeatureDirectionKind</seealso>
    let FeatureDirectionKind =
        Prefixed_Name(ossysmlv2, "FeatureDirectionKind") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:owningMembership_OwnedMemberElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Element that becomes an ownedMember of the membershipOwningNamespace due to this OwningMembership.</para>
    /// labels<para>owningMembership_OwnedMemberElement</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#owningMembership_OwnedMemberElement">http://open-services.net/ns/sysmlv2#owningMembership_OwnedMemberElement</seealso>
    let owningMembership_OwnedMemberElement =
        Prefixed_Name(ossysmlv2, "owningMembership_OwnedMemberElement") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:viewDefinition_View</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The usages of this ViewDefinition that are ViewUsages.</para>
    /// labels<para>viewDefinition_View</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#viewDefinition_View">http://open-services.net/ns/sysmlv2#viewDefinition_View</seealso>
    let viewDefinition_View =
        Prefixed_Name(ossysmlv2, "viewDefinition_View") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:ElementFilterMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>ElementFilterMembership is a Membership between a Namespace and a model-level evaluable Boolean-valued Expression, asserting that imported members of the Namespace should be filtered using the condition Expression. A general Namespace does not define any specific filtering behavior, but such behavior may be defined for various specialized kinds of Namespaces.</para>
    /// labels<para>ElementFilterMembership</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#ElementFilterMembership">http://open-services.net/ns/sysmlv2#ElementFilterMembership</seealso>
    let ElementFilterMembership =
        Prefixed_Name(ossysmlv2, "ElementFilterMembership") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:FeatureMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A FeatureMembership is an OwningMembership between a Feature in an owningType that is also a Featuring Relationship between the Feature and the Type, in which the featuringType is the source and the featureOfType is the target. A FeatureMembership is always owned by its owningType, which is the featuringType for the FeatureMembership considered as a Featuring.</para>
    /// labels<para>FeatureMembership</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#FeatureMembership">http://open-services.net/ns/sysmlv2#FeatureMembership</seealso>
    let FeatureMembership =
        Prefixed_Name(ossysmlv2, "FeatureMembership") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:EnumerationUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An EnumerationUsage is an AttributeUsage whose attributeDefinition is an EnumerationDefinition.</para>
    /// labels<para>EnumerationUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#EnumerationUsage">http://open-services.net/ns/sysmlv2#EnumerationUsage</seealso>
    let EnumerationUsage = Prefixed_Name(ossysmlv2, "EnumerationUsage") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:PerformActionUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A PerformActionUsage is an ActionUsage that represents the performance of an ActionUsage. Unless it is the PerformActionUsage itself, the ActionUsage to be performed is related to the PerformActionUsage by a ReferenceSubsetting relationship. A PerformActionUsage is also an EventOccurrenceUsage, with its performedAction as the eventOccurrence.</para>
    /// labels<para>PerformActionUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#PerformActionUsage">http://open-services.net/ns/sysmlv2#PerformActionUsage</seealso>
    let PerformActionUsage =
        Prefixed_Name(ossysmlv2, "PerformActionUsage") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:Import</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An Import is an Relationship between its importOwningNamespace and either a Membership (for a MembershipImport) or another Namespace (for a NamespaceImport), which determines a set of Memberships that become importedMemberships of the importOwningNamespace. If isImportAll = false (the default), then only public Memberships are considered "visible". If isImportAll = true, then all Memberships are considered "visible", regardless of their declared visibility. If isRecursive = true, then visible Memberships are also recursively imported from owned sub-Namespaces.</para>
    /// labels<para>Import</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Import">http://open-services.net/ns/sysmlv2#Import</seealso>
    let Import = Prefixed_Name(ossysmlv2, "Import") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:FeatureChaining</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>FeatureChaining is a Relationship that makes its target Feature one of the chainingFeatures of its owning Feature.</para>
    /// labels<para>FeatureChaining</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#FeatureChaining">http://open-services.net/ns/sysmlv2#FeatureChaining</seealso>
    let FeatureChaining = Prefixed_Name(ossysmlv2, "FeatureChaining") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:FeatureInverting</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A FeatureInverting is a Relationship between Features asserting that their interpretations (sequences) are the reverse of each other, identified as featureInverted and invertingFeature. For example, a Feature identifying each person's parents is the inverse of a Feature identifying each person's children. A person identified as a parent of another will identify that other as one of their children.</para>
    /// labels<para>FeatureInverting</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#FeatureInverting">http://open-services.net/ns/sysmlv2#FeatureInverting</seealso>
    let FeatureInverting = Prefixed_Name(ossysmlv2, "FeatureInverting") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:Featuring</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Featuring is a Relationship between a Type and a Feature that is featured by that Type. It asserts that every instance in the domain of the feature must be classified by the type.</para>
    /// labels<para>Featuring</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Featuring">http://open-services.net/ns/sysmlv2#Featuring</seealso>
    let Featuring = Prefixed_Name(ossysmlv2, "Featuring") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:Specialization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Specialization is a Relationship between two Types that requires all instances of the specific type to also be instances of the general Type (i.e., the set of instances of the specific Type is a subset of those of the general Type, which might be the same set).</para>
    /// labels<para>Specialization</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Specialization">http://open-services.net/ns/sysmlv2#Specialization</seealso>
    let Specialization = Prefixed_Name(ossysmlv2, "Specialization") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:FeatureValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A FeatureValue is a Membership that identifies a particular member Expression that provides the value of the Feature that owns the FeatureValue. The value is specified as either a bound value or an initial value, and as either a concrete or default value. A Feature can have at most one FeatureValue.</para>
    /// labels<para>FeatureValue</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#FeatureValue">http://open-services.net/ns/sysmlv2#FeatureValue</seealso>
    let FeatureValue = Prefixed_Name(ossysmlv2, "FeatureValue") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:Interaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An Interaction is a Behavior that is also an Association, providing a context for multiple objects that have behaviors that impact one another.</para>
    /// labels<para>Interaction</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Interaction">http://open-services.net/ns/sysmlv2#Interaction</seealso>
    let Interaction = Prefixed_Name(ossysmlv2, "Interaction") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:FlowConnectionUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A FlowConnectionUsage is a ConnectionUsage that is also an ItemFlow.</para>
    /// labels<para>FlowConnectionUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#FlowConnectionUsage">http://open-services.net/ns/sysmlv2#FlowConnectionUsage</seealso>
    let FlowConnectionUsage =
        Prefixed_Name(ossysmlv2, "FlowConnectionUsage") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:ForLoopActionUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A ForLoopActionUsage is a LoopActionUsage that specifies that its bodyAction ActionUsage should be performed once for each value, in order, from the sequence of values obtained as the result of the seqArgument Expression, with the loopVariable set to the value for each iteration.</para>
    /// labels<para>ForLoopActionUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#ForLoopActionUsage">http://open-services.net/ns/sysmlv2#ForLoopActionUsage</seealso>
    let ForLoopActionUsage =
        Prefixed_Name(ossysmlv2, "ForLoopActionUsage") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:LoopActionUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A LoopActionUsage is an ActionUsage that specifies that its bodyAction should be performed repeatedly. Its subclasses WhileLoopActionUsage and ForLoopActionUsage provide different ways to determine how many times the bodyAction should be performed.</para>
    /// labels<para>LoopActionUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#LoopActionUsage">http://open-services.net/ns/sysmlv2#LoopActionUsage</seealso>
    let LoopActionUsage = Prefixed_Name(ossysmlv2, "LoopActionUsage") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:RequirementConstraintMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A RequirementConstraintMembership is a FeatureMembership for an assumed or required ConstraintUsage of a RequirementDefinition or RequirementUsage.</para>
    /// labels<para>RequirementConstraintMembership</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#RequirementConstraintMembership">http://open-services.net/ns/sysmlv2#RequirementConstraintMembership</seealso>
    let RequirementConstraintMembership =
        Prefixed_Name(ossysmlv2, "RequirementConstraintMembership") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:IncludeUseCaseUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An IncludeUseCaseUsage is a UseCaseUsage that represents the inclusion of a UseCaseUsage by a UseCaseDefinition or UseCaseUsage. Unless it is the IncludeUseCaseUsage itself, the UseCaseUsage to be included is related to the includedUseCase by a ReferenceSubsetting Relationship. An IncludeUseCaseUsage is also a PerformActionUsage, with its useCaseIncluded as the performedAction.</para>
    /// labels<para>IncludeUseCaseUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#IncludeUseCaseUsage">http://open-services.net/ns/sysmlv2#IncludeUseCaseUsage</seealso>
    let IncludeUseCaseUsage =
        Prefixed_Name(ossysmlv2, "IncludeUseCaseUsage") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:UseCaseUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A UseCaseUsage is a Usage of a UseCaseDefinition.</para>
    /// labels<para>UseCaseUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#UseCaseUsage">http://open-services.net/ns/sysmlv2#UseCaseUsage</seealso>
    let UseCaseUsage = Prefixed_Name(ossysmlv2, "UseCaseUsage") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:InterfaceDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An InterfaceDefinition is a ConnectionDefinition all of whose ends are PortUsages, defining an interface between elements that interact through such ports.</para>
    /// labels<para>InterfaceDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#InterfaceDefinition">http://open-services.net/ns/sysmlv2#InterfaceDefinition</seealso>
    let InterfaceDefinition =
        Prefixed_Name(ossysmlv2, "InterfaceDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:InterfaceUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An InterfaceUsage is a Usage of an InterfaceDefinition to represent an interface connecting parts of a system through specific ports.</para>
    /// labels<para>InterfaceUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#InterfaceUsage">http://open-services.net/ns/sysmlv2#InterfaceUsage</seealso>
    let InterfaceUsage = Prefixed_Name(ossysmlv2, "InterfaceUsage") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:constraintUsage_ConstraintDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The (single) Predicate that is the type of this ConstraintUsage. Nominally, this will be a ConstraintDefinition, but other kinds of Predicates are also allowed, to permit use of Predicates from the Kernel Model Libraries.</para>
    /// labels<para>constraintUsage_ConstraintDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#constraintUsage_ConstraintDefinition">http://open-services.net/ns/sysmlv2#constraintUsage_ConstraintDefinition</seealso>
    let constraintUsage_ConstraintDefinition =
        Prefixed_Name(ossysmlv2, "constraintUsage_ConstraintDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:definition_OwnedAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ActionUsages that are ownedUsages of this Definition.</para>
    /// labels<para>definition_OwnedAction</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#definition_OwnedAction">http://open-services.net/ns/sysmlv2#definition_OwnedAction</seealso>
    let definition_OwnedAction =
        Prefixed_Name(ossysmlv2, "definition_OwnedAction") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:definition_OwnedAllocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The AllocationUsages that are ownedUsages of this Definition.</para>
    /// labels<para>definition_OwnedAllocation</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#definition_OwnedAllocation">http://open-services.net/ns/sysmlv2#definition_OwnedAllocation</seealso>
    let definition_OwnedAllocation =
        Prefixed_Name(ossysmlv2, "definition_OwnedAllocation") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:definition_OwnedCalculation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The CalculationUsages that are ownedUsages of this Definition.</para>
    /// labels<para>definition_OwnedCalculation</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#definition_OwnedCalculation">http://open-services.net/ns/sysmlv2#definition_OwnedCalculation</seealso>
    let definition_OwnedCalculation =
        Prefixed_Name(ossysmlv2, "definition_OwnedCalculation") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:definition_OwnedCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The code&gt;CaseUsages that are ownedUsages of this Definition.</para>
    /// labels<para>definition_OwnedCase</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#definition_OwnedCase">http://open-services.net/ns/sysmlv2#definition_OwnedCase</seealso>
    let definition_OwnedCase =
        Prefixed_Name(ossysmlv2, "definition_OwnedCase") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:definition_OwnedConcern</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ConcernUsages that are ownedUsages of this Definition.</para>
    /// labels<para>definition_OwnedConcern</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#definition_OwnedConcern">http://open-services.net/ns/sysmlv2#definition_OwnedConcern</seealso>
    let definition_OwnedConcern =
        Prefixed_Name(ossysmlv2, "definition_OwnedConcern") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:definition_OwnedConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ConstraintUsages that are ownedUsages of this Definition.</para>
    /// labels<para>definition_OwnedConstraint</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#definition_OwnedConstraint">http://open-services.net/ns/sysmlv2#definition_OwnedConstraint</seealso>
    let definition_OwnedConstraint =
        Prefixed_Name(ossysmlv2, "definition_OwnedConstraint") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:definition_OwnedEnumeration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The EnumerationUsages that are ownedUsages of this Definition.</para>
    /// labels<para>definition_OwnedEnumeration</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#definition_OwnedEnumeration">http://open-services.net/ns/sysmlv2#definition_OwnedEnumeration</seealso>
    let definition_OwnedEnumeration =
        Prefixed_Name(ossysmlv2, "definition_OwnedEnumeration") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:definition_OwnedInterface</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The InterfaceUsages that are ownedUsages of this Definition.</para>
    /// labels<para>definition_OwnedInterface</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#definition_OwnedInterface">http://open-services.net/ns/sysmlv2#definition_OwnedInterface</seealso>
    let definition_OwnedInterface =
        Prefixed_Name(ossysmlv2, "definition_OwnedInterface") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:definition_OwnedItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ItemUsages that are ownedUsages of this Definition.</para>
    /// labels<para>definition_OwnedItem</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#definition_OwnedItem">http://open-services.net/ns/sysmlv2#definition_OwnedItem</seealso>
    let definition_OwnedItem =
        Prefixed_Name(ossysmlv2, "definition_OwnedItem") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:definition_OwnedMetadata</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The MetadataUsages that are ownedUsages of this Definition.</para>
    /// labels<para>definition_OwnedMetadata</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#definition_OwnedMetadata">http://open-services.net/ns/sysmlv2#definition_OwnedMetadata</seealso>
    let definition_OwnedMetadata =
        Prefixed_Name(ossysmlv2, "definition_OwnedMetadata") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:definition_OwnedPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The PartUsages that are ownedUsages of this Definition.</para>
    /// labels<para>definition_OwnedPart</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#definition_OwnedPart">http://open-services.net/ns/sysmlv2#definition_OwnedPart</seealso>
    let definition_OwnedPart =
        Prefixed_Name(ossysmlv2, "definition_OwnedPart") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:definition_OwnedPort</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The PortUsages that are ownedUsages of this Definition.</para>
    /// labels<para>definition_OwnedPort</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#definition_OwnedPort">http://open-services.net/ns/sysmlv2#definition_OwnedPort</seealso>
    let definition_OwnedPort =
        Prefixed_Name(ossysmlv2, "definition_OwnedPort") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:definition_OwnedState</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The StateUsages that are ownedUsages of this Definition.</para>
    /// labels<para>definition_OwnedState</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#definition_OwnedState">http://open-services.net/ns/sysmlv2#definition_OwnedState</seealso>
    let definition_OwnedState =
        Prefixed_Name(ossysmlv2, "definition_OwnedState") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:definition_OwnedTransition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The TransitionUsages that are ownedUsages of this Definition.</para>
    /// labels<para>definition_OwnedTransition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#definition_OwnedTransition">http://open-services.net/ns/sysmlv2#definition_OwnedTransition</seealso>
    let definition_OwnedTransition =
        Prefixed_Name(ossysmlv2, "definition_OwnedTransition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:definition_OwnedVerificationCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The VerificationCaseUsages that are ownedUsages of this Definition.</para>
    /// labels<para>definition_OwnedVerificationCase</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#definition_OwnedVerificationCase">http://open-services.net/ns/sysmlv2#definition_OwnedVerificationCase</seealso>
    let definition_OwnedVerificationCase =
        Prefixed_Name(ossysmlv2, "definition_OwnedVerificationCase") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:definition_OwnedView</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ViewUsages that are ownedUsages of this Definition.</para>
    /// labels<para>definition_OwnedView</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#definition_OwnedView">http://open-services.net/ns/sysmlv2#definition_OwnedView</seealso>
    let definition_OwnedView =
        Prefixed_Name(ossysmlv2, "definition_OwnedView") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:definition_VariantMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ownedMemberships of this Definition that are VariantMemberships. If isVariation = true, then this must be all ownedMemberships of the Definition. If isVariation = false, then variantMembershipmust be empty.</para>
    /// labels<para>definition_VariantMembership</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#definition_VariantMembership">http://open-services.net/ns/sysmlv2#definition_VariantMembership</seealso>
    let definition_VariantMembership =
        Prefixed_Name(ossysmlv2, "definition_VariantMembership") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:dependency_Client</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Element or Elements dependent on the supplier Elements.</para>
    /// labels<para>dependency_Client</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#dependency_Client">http://open-services.net/ns/sysmlv2#dependency_Client</seealso>
    let dependency_Client =
        Prefixed_Name(ossysmlv2, "dependency_Client") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:dependency_Supplier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Element or Elements on which the client Elements depend in some respect.</para>
    /// labels<para>dependency_Supplier</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#dependency_Supplier">http://open-services.net/ns/sysmlv2#dependency_Supplier</seealso>
    let dependency_Supplier =
        Prefixed_Name(ossysmlv2, "dependency_Supplier") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:requirementUsage_RequirementDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The RequirementDefinition that is the single definition of this RequirementUsage.</para>
    /// labels<para>requirementUsage_RequirementDefinition</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#requirementUsage_RequirementDefinition">http://open-services.net/ns/sysmlv2#requirementUsage_RequirementDefinition</seealso>
    let requirementUsage_RequirementDefinition =
        Prefixed_Name(ossysmlv2, "requirementUsage_RequirementDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:requirementUsage_StakeholderParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The parameters of this RequirementUsage that represent stakeholders for the requirement.</para>
    /// labels<para>requirementUsage_StakeholderParameter</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#requirementUsage_StakeholderParameter">http://open-services.net/ns/sysmlv2#requirementUsage_StakeholderParameter</seealso>
    let requirementUsage_StakeholderParameter =
        Prefixed_Name(ossysmlv2, "requirementUsage_StakeholderParameter") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:requirementUsage_SubjectParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The parameter of this RequirementUsage that represents its subject.</para>
    /// labels<para>requirementUsage_SubjectParameter</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#requirementUsage_SubjectParameter">http://open-services.net/ns/sysmlv2#requirementUsage_SubjectParameter</seealso>
    let requirementUsage_SubjectParameter =
        Prefixed_Name(ossysmlv2, "requirementUsage_SubjectParameter") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:requirementUsage_Text</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An optional textual statement of the requirement represented by this RequirementUsage, derived from the bodies of the documentation of the RequirementUsage.</para>
    /// labels<para>requirementUsage_Text</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#requirementUsage_Text">http://open-services.net/ns/sysmlv2#requirementUsage_Text</seealso>
    let requirementUsage_Text =
        Prefixed_Name(ossysmlv2, "requirementUsage_Text") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:requirementVerificationMembership_OwnedRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The owned RequirementUsage that acts as the ownedConstraint for this RequirementVerificationMembership. This will either be the verifiedRequirement, or it will subset the verifiedRequirement.</para>
    /// labels<para>requirementVerificationMembership_OwnedRequirement</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#requirementVerificationMembership_OwnedRequirement">http://open-services.net/ns/sysmlv2#requirementVerificationMembership_OwnedRequirement</seealso>
    let requirementVerificationMembership_OwnedRequirement =
        Prefixed_Name(ossysmlv2, "requirementVerificationMembership_OwnedRequirement") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:EndFeatureMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>EndFeatureMembership is a FeatureMembership that requires its memberFeature be owned and have isEnd = true.</para>
    /// labels<para>EndFeatureMembership</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#EndFeatureMembership">http://open-services.net/ns/sysmlv2#EndFeatureMembership</seealso>
    let EndFeatureMembership =
        Prefixed_Name(ossysmlv2, "EndFeatureMembership") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:multiplicityRange_LowerBound</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Expression whose result provides the lower bound of the MultiplicityRange. If no lowerBound Expression is given, then the lower bound shall have the same value as the upper bound, unless the upper bound is unbounded (*), in which case the lower bound shall be 0.</para>
    /// labels<para>multiplicityRange_LowerBound</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#multiplicityRange_LowerBound">http://open-services.net/ns/sysmlv2#multiplicityRange_LowerBound</seealso>
    let multiplicityRange_LowerBound =
        Prefixed_Name(ossysmlv2, "multiplicityRange_LowerBound") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:namespace_ImportedMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Memberships in this Namespace that result from the ownedImports of this Namespace.</para>
    /// labels<para>namespace_ImportedMembership</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#namespace_ImportedMembership">http://open-services.net/ns/sysmlv2#namespace_ImportedMembership</seealso>
    let namespace_ImportedMembership =
        Prefixed_Name(ossysmlv2, "namespace_ImportedMembership") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:namespace_OwnedMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The ownedRelationships of this Namespace that are Memberships, for which the Namespace is the membershipOwningNamespace.</para>
    /// labels<para>namespace_OwnedMembership</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#namespace_OwnedMembership">http://open-services.net/ns/sysmlv2#namespace_OwnedMembership</seealso>
    let namespace_OwnedMembership =
        Prefixed_Name(ossysmlv2, "namespace_OwnedMembership") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:objectiveMembership_OwnedObjectiveRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The RequirementUsage that is the ownedMemberFeature of this RequirementUsage.</para>
    /// labels<para>objectiveMembership_OwnedObjectiveRequirement</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#objectiveMembership_OwnedObjectiveRequirement">http://open-services.net/ns/sysmlv2#objectiveMembership_OwnedObjectiveRequirement</seealso>
    let objectiveMembership_OwnedObjectiveRequirement =
        Prefixed_Name(ossysmlv2, "objectiveMembership_OwnedObjectiveRequirement") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>OSLC SysML v2 Vocabulary</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#">http://open-services.net/ns/sysmlv2#</seealso>
    let _prefix_iri = Prefixed_Name(ossysmlv2, "") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:LiteralBoolean</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>LiteralBoolean is a LiteralExpression that provides a Boolean value as a result. Its result parameter must have type Boolean.</para>
    /// labels<para>LiteralBoolean</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#LiteralBoolean">http://open-services.net/ns/sysmlv2#LiteralBoolean</seealso>
    let LiteralBoolean = Prefixed_Name(ossysmlv2, "LiteralBoolean") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:LiteralRational</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A LiteralRational is a LiteralExpression that provides a Rational value as a result. Its result parameter must have the type Rational.</para>
    /// labels<para>LiteralRational</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#LiteralRational">http://open-services.net/ns/sysmlv2#LiteralRational</seealso>
    let LiteralRational = Prefixed_Name(ossysmlv2, "LiteralRational") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:Membership</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Membership is a Relationship between a Namespace and an Element that indicates the Element is a member of (i.e., is contained in) the Namespace. Any memberNames specify how the memberElement is identified in the Namespace and the visibility specifies whether or not the memberElement is publicly visible from outside the Namespace.</para>
    /// labels<para>Membership</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Membership">http://open-services.net/ns/sysmlv2#Membership</seealso>
    let Membership = Prefixed_Name(ossysmlv2, "Membership") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:Metaclass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Metaclass is a Structure used to type MetadataFeatures.</para>
    /// labels<para>Metaclass</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#Metaclass">http://open-services.net/ns/sysmlv2#Metaclass</seealso>
    let Metaclass = Prefixed_Name(ossysmlv2, "Metaclass") |> PrefixedName
    /// <summary>
    ///   <para>ossysmlv2:MetadataUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A  MetadataUsage is a Usage and a MetadataFeature, used to annotate other Elements in a system model with metadata. As a MetadataFeature, its type must be a Metaclass, which will nominally be a MetadataDefinition. However, any kernel Metaclass is also allowed, to permit use of Metaclasses from the Kernel Model Libraries.</para>
    /// labels<para>MetadataUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#MetadataUsage">http://open-services.net/ns/sysmlv2#MetadataUsage</seealso>
    let MetadataUsage = Prefixed_Name(ossysmlv2, "MetadataUsage") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:definition_OwnedRendering</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The RenderingUsages that are ownedUsages of this Definition.</para>
    /// labels<para>definition_OwnedRendering</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#definition_OwnedRendering">http://open-services.net/ns/sysmlv2#definition_OwnedRendering</seealso>
    let definition_OwnedRendering =
        Prefixed_Name(ossysmlv2, "definition_OwnedRendering") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:definition_OwnedRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The RequirementUsages that are ownedUsages of this Definition.</para>
    /// labels<para>definition_OwnedRequirement</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#definition_OwnedRequirement">http://open-services.net/ns/sysmlv2#definition_OwnedRequirement</seealso>
    let definition_OwnedRequirement =
        Prefixed_Name(ossysmlv2, "definition_OwnedRequirement") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:definition_OwnedUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Usages that are ownedFeatures of this Definition.</para>
    /// labels<para>definition_OwnedUsage</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#definition_OwnedUsage">http://open-services.net/ns/sysmlv2#definition_OwnedUsage</seealso>
    let definition_OwnedUsage =
        Prefixed_Name(ossysmlv2, "definition_OwnedUsage") |> PrefixedName

    /// <summary>
    ///   <para>ossysmlv2:definition_OwnedUseCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The UseCaseUsages that are ownedUsages of this Definition.</para>
    /// labels<para>definition_OwnedUseCase</para></remarks>
    /// <seealso href="http://open-services.net/ns/sysmlv2#definition_OwnedUseCase">http://open-services.net/ns/sysmlv2#definition_OwnedUseCase</seealso>
    let definition_OwnedUseCase =
        Prefixed_Name(ossysmlv2, "definition_OwnedUseCase") |> PrefixedName
