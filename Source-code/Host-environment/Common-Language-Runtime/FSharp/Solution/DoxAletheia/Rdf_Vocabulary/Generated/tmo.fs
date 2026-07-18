namespace http.www.semanticdesktop.org.ontologies._2008._05._20.tmo.hash

open DoxAletheia.Rdf_Vocabulary

module tmo =
    let _namespace_name = "http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#"

    /// <summary>
    /// AbilityCarrier is an abstract class which circumferences all entities which can take action or which are somehow involved in tasks.
    /// This is in other task conceptualizations rather named "actor". But here it is named AbilityCarrier because it is not neccessarily "active".
    ///
    /// The execution of a task relies on certain abilities. The abstract concept of
    /// Abilitiy_Carriers circumference all those more concrete concepts
    /// of which one can think of while working on tasks. Using this abstract
    /// class enables to substitute such Ability Carrier's in the process of
    /// generating patterns from task instances and vice versa in the process of
    /// instantiating task instances from patterns without violating the schema.
    /// With this attribute, a series of ability carrying entities (Person, Role,
    /// Skill, OrganizationalUnit, InformalDescribedAbility)
    /// and the role of involvement (required, request, used) is enabled. The role
    /// hereby allows specifying how the ability carrying entity is or was
    /// involved.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#AbilityCarrier"></see></summary>
    let AbilityCarrier =
        Namespaced_IRI.parse _namespace_name "AbilityCarrier" |> NamespacedName

    /// <summary>
    /// The class AbilityCarrier_Involvement ties together an AbilityCarrier with an AbilityCarrier_Role. This is a role based modelling approach. An n-ary relation is realized.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#AbilityCarrierInvolvement"></see></summary>
    let AbilityCarrierInvolvement =
        Namespaced_IRI.parse _namespace_name "AbilityCarrierInvolvement" |> NamespacedName

    /// <summary>
    /// Examples instances  of AbilityCarrirRoles are e.g. "requested", "required" and "used" which further specify the type a person was involved in.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#AbilityCarrierRole"></see></summary>
    let AbilityCarrierRole =
        Namespaced_IRI.parse _namespace_name "AbilityCarrierRole" |> NamespacedName

    /// <summary>
    /// StateTypeRole is an abstract class which subsumes various other classes which represent "states" or roles e.g. in role based modelling conpetualisations.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#StateTypeRole"></see></summary>
    let StateTypeRole =
        Namespaced_IRI.parse _namespace_name "StateTypeRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#AgentAbilityCarrier"></see>
    /// </summary>
    let AgentAbilityCarrier =
        Namespaced_IRI.parse _namespace_name "AgentAbilityCarrier" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#AssociationDependency"></see>
    /// </summary>
    let AssociationDependency =
        Namespaced_IRI.parse _namespace_name "AssociationDependency" |> NamespacedName

    /// <summary>
    /// A symmetric relations between task.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#UndirectedDependency"></see></summary>
    let UndirectedDependency =
        Namespaced_IRI.parse _namespace_name "UndirectedDependency" |> NamespacedName

    /// <summary>
    /// By means of attachments, references to other resources can be established. Resources are information objects. Every Thing, which can be referenced, on the SSD is an information object. In contrast to the usual SSD references/associations, here additionally information can be specified. Further metadata about the role an attachment plays can be stated by means of instances of AttachmentRole. It can be expressed what the Role of attachment is e.g., regarding "desired/requested" or "required" or "potentially useful / somehow related" or "used/produced/achieved". The reference property models the actual link to the attached piece of information.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#Attachment"></see></summary>
    let Attachment = Namespaced_IRI.parse _namespace_name "Attachment" |> NamespacedName

    /// <summary>
    /// AttachmentRoles further specify the type of how an attachment relates to a task. Example instances  of AttachmentRoles are e.g. "desired_request", "required" and "used".
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#AttachmentRole"></see></summary>
    let AttachmentRole =
        Namespaced_IRI.parse _namespace_name "AttachmentRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#Delegability"></see>
    /// </summary>
    let Delegability =
        Namespaced_IRI.parse _namespace_name "Delegability" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#Importance"></see>
    /// </summary>
    let Importance = Namespaced_IRI.parse _namespace_name "Importance" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#Interdependence"></see>
    /// </summary>
    let Interdependence =
        Namespaced_IRI.parse _namespace_name "Interdependence" |> NamespacedName

    /// <summary>
    /// PersonInvolvement  realizes n-ary associations to Persons which are realtedd to an task. The involvement is further characterized by an PersonTaskRole.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#PersonInvolvement"></see></summary>
    let PersonInvolvement =
        Namespaced_IRI.parse _namespace_name "PersonInvolvement" |> NamespacedName

    /// <summary>
    /// They further specify the type a person was related to an task.
    /// Examples instances  of AttachmentRoles are e.g.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#PersonInvolvementRole"></see></summary>
    let PersonInvolvementRole =
        Namespaced_IRI.parse _namespace_name "PersonInvolvementRole" |> NamespacedName

    /// <summary>
    /// In a  PredecessorDependency the dependencyMemberA is the task which is to be executed before dependencyMemberB.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#PredecessorDependency"></see></summary>
    let PredecessorDependency =
        Namespaced_IRI.parse _namespace_name "PredecessorDependency" |> NamespacedName

    /// <summary>
    /// The PredecessorSuccessorDependency enables a directed relation between task. By means of the concrete sublcasses one can further distinguish from which point of view this relation is created.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#PredecessorSuccessorDependency"></see></summary>
    let PredecessorSuccessorDependency =
        Namespaced_IRI.parse _namespace_name "PredecessorSuccessorDependency" |> NamespacedName

    /// <summary>
    /// Between the tasks, further dependencies may exist. These dependencies allow for a graph network structure. For ease of use, dependencies should not be too frequent, otherwise the primarily character of a hierarchy would be diminished and a consequent graph representation would become considerable. However, such a graph representation has other drawbacks, the user is likely to loose oversight, tree structures are more helpful in structuring the work.
    ///
    /// A dependency relation is characterized by the type of the relation and by an additional description. There are different possibilities for dependency relations between tasks.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TaskDependency"></see></summary>
    let TaskDependency =
        Namespaced_IRI.parse _namespace_name "TaskDependency" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#Priority"></see>
    /// </summary>
    let Priority = Namespaced_IRI.parse _namespace_name "Priority" |> NamespacedName
    /// <summary>
    /// examples: Architect, Developer, ...
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#Role"></see></summary>
    let Role = Namespaced_IRI.parse _namespace_name "Role" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#SimilarityDependence"></see>
    /// </summary>
    let SimilarityDependence =
        Namespaced_IRI.parse _namespace_name "SimilarityDependence" |> NamespacedName

    /// <summary>
    /// examples are e.g. technologies like Java, XML,  ...
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#Skill"></see></summary>
    let Skill = Namespaced_IRI.parse _namespace_name "Skill" |> NamespacedName

    /// <summary>
    /// In a SuccessorrDependency the dependencyMemberA is the task which is to be executed after dependencyMemberB.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#SuccessorDependency"></see></summary>
    let SuccessorDependency =
        Namespaced_IRI.parse _namespace_name "SuccessorDependency" |> NamespacedName

    /// <summary>
    /// By means of the SuperSubTaskDependency one can further describe the subtask-supertask relation .e.g by an descriptin. This enables an n-ary relation between subtask and supertask.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#SuperSubTaskDependency"></see></summary>
    let SuperSubTaskDependency =
        Namespaced_IRI.parse _namespace_name "SuperSubTaskDependency" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_AbilityCarrierRole_Requested"></see>
    /// </summary>
    let TMO_Instance_AbilityCarrierRole_Requested =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_AbilityCarrierRole_Requested" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_AbilityCarrierRole_Required"></see>
    /// </summary>
    let TMO_Instance_AbilityCarrierRole_Required =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_AbilityCarrierRole_Required" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_AbilityCarrierRole_Used"></see>
    /// </summary>
    let TMO_Instance_AbilityCarrierRole_Used =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_AbilityCarrierRole_Used" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_AttachmentRole_Desired_Requested"></see>
    /// </summary>
    let TMO_Instance_AttachmentRole_Desired_Requested =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_AttachmentRole_Desired_Requested" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_AttachmentRole_Related"></see>
    /// </summary>
    let TMO_Instance_AttachmentRole_Related =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_AttachmentRole_Related" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_AttachmentRole_Required"></see>
    /// </summary>
    let TMO_Instance_AttachmentRole_Required =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_AttachmentRole_Required" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_AttachmentRole_Used"></see>
    /// </summary>
    let TMO_Instance_AttachmentRole_Used =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_AttachmentRole_Used" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Delegability_High"></see>
    /// </summary>
    let TMO_Instance_Delegability_High =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_Delegability_High" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Delegability_Low"></see>
    /// </summary>
    let TMO_Instance_Delegability_Low =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_Delegability_Low" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Delegability_Medium"></see>
    /// </summary>
    let TMO_Instance_Delegability_Medium =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_Delegability_Medium" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Delegability_Never"></see>
    /// </summary>
    let TMO_Instance_Delegability_Never =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_Delegability_Never" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Delegability_Unrestricted"></see>
    /// </summary>
    let TMO_Instance_Delegability_Unrestricted =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_Delegability_Unrestricted" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_01"></see>
    /// </summary>
    let TMO_Instance_Importance_01 =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_Importance_01" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_02"></see>
    /// </summary>
    let TMO_Instance_Importance_02 =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_Importance_02" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_03"></see>
    /// </summary>
    let TMO_Instance_Importance_03 =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_Importance_03" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_04"></see>
    /// </summary>
    let TMO_Instance_Importance_04 =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_Importance_04" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_05"></see>
    /// </summary>
    let TMO_Instance_Importance_05 =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_Importance_05" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_06"></see>
    /// </summary>
    let TMO_Instance_Importance_06 =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_Importance_06" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_07"></see>
    /// </summary>
    let TMO_Instance_Importance_07 =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_Importance_07" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_08"></see>
    /// </summary>
    let TMO_Instance_Importance_08 =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_Importance_08" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_09"></see>
    /// </summary>
    let TMO_Instance_Importance_09 =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_Importance_09" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_10"></see>
    /// </summary>
    let TMO_Instance_Importance_10 =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_Importance_10" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Analyst"></see>
    /// </summary>
    let TMO_Instance_PersonInvolvementRole_Analyst =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_PersonInvolvementRole_Analyst" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Co-worker"></see>
    /// </summary>
    let ``TMO_Instance_PersonInvolvementRole_Co-worker`` =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_PersonInvolvementRole_Co-worker" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Collaborator"></see>
    /// </summary>
    let TMO_Instance_PersonInvolvementRole_Collaborator =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_PersonInvolvementRole_Collaborator" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Controller"></see>
    /// </summary>
    let TMO_Instance_PersonInvolvementRole_Controller =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_PersonInvolvementRole_Controller" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Creator"></see>
    /// </summary>
    let TMO_Instance_PersonInvolvementRole_Creator =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_PersonInvolvementRole_Creator" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Delegate"></see>
    /// </summary>
    let TMO_Instance_PersonInvolvementRole_Delegate =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_PersonInvolvementRole_Delegate" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Executor"></see>
    /// </summary>
    let TMO_Instance_PersonInvolvementRole_Executor =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_PersonInvolvementRole_Executor" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_ExternalObserver"></see>
    /// </summary>
    let TMO_Instance_PersonInvolvementRole_ExternalObserver =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_PersonInvolvementRole_ExternalObserver" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Initiator"></see>
    /// </summary>
    let TMO_Instance_PersonInvolvementRole_Initiator =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_PersonInvolvementRole_Initiator" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_InternalObserver"></see>
    /// </summary>
    let TMO_Instance_PersonInvolvementRole_InternalObserver =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_PersonInvolvementRole_InternalObserver" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Involved"></see>
    /// </summary>
    let TMO_Instance_PersonInvolvementRole_Involved =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_PersonInvolvementRole_Involved" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Observer"></see>
    /// </summary>
    let TMO_Instance_PersonInvolvementRole_Observer =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_PersonInvolvementRole_Observer" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Owner"></see>
    /// </summary>
    let TMO_Instance_PersonInvolvementRole_Owner =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_PersonInvolvementRole_Owner" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Receiver"></see>
    /// </summary>
    let TMO_Instance_PersonInvolvementRole_Receiver =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_PersonInvolvementRole_Receiver" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Related"></see>
    /// </summary>
    let TMO_Instance_PersonInvolvementRole_Related =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_PersonInvolvementRole_Related" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Reviewer"></see>
    /// </summary>
    let TMO_Instance_PersonInvolvementRole_Reviewer =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_PersonInvolvementRole_Reviewer" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Suggested"></see>
    /// </summary>
    let TMO_Instance_PersonInvolvementRole_Suggested =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_PersonInvolvementRole_Suggested" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Priority_High"></see>
    /// </summary>
    let TMO_Instance_Priority_High =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_Priority_High" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Priority_Low"></see>
    /// </summary>
    let TMO_Instance_Priority_Low =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_Priority_Low" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Priority_Medium"></see>
    /// </summary>
    let TMO_Instance_Priority_Medium =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_Priority_Medium" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskContainer_activetasks"></see>
    /// </summary>
    let TMO_Instance_TaskContainer_activetasks =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_TaskContainer_activetasks" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TaskContainer"></see>
    /// </summary>
    let TaskContainer =
        Namespaced_IRI.parse _namespace_name "TaskContainer" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskContainer_archive"></see>
    /// </summary>
    let TMO_Instance_TaskContainer_archive =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_TaskContainer_archive" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskContainer_inbox"></see>
    /// </summary>
    let TMO_Instance_TaskContainer_inbox =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_TaskContainer_inbox" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskContainer_outbox"></see>
    /// </summary>
    let TMO_Instance_TaskContainer_outbox =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_TaskContainer_outbox" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskContainer_trashtasks"></see>
    /// </summary>
    let TMO_Instance_TaskContainer_trashtasks =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_TaskContainer_trashtasks" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskPrivacy_Private"></see>
    /// </summary>
    let TMO_Instance_TaskPrivacy_Private =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_TaskPrivacy_Private" |> NamespacedName

    /// <summary>
    /// Privacy Status serves for the separation between a professional and a private purpose of a task. This attribute provides with the values "professional/private" a high-level separation of privacy in terms of setting distribution and access
    /// rights to other users for the task.
    /// This separation may arise as a general Nepomuk issue and may therefore be handled in conjunction with a privacy preserving SSD architecture.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TaskPrivacyState"></see></summary>
    let TaskPrivacyState =
        Namespaced_IRI.parse _namespace_name "TaskPrivacyState" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskPrivacy_Professional"></see>
    /// </summary>
    let TMO_Instance_TaskPrivacy_Professional =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_TaskPrivacy_Professional" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskState_Archived"></see>
    /// </summary>
    let TMO_Instance_TaskState_Archived =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_TaskState_Archived" |> NamespacedName

    /// <summary>
    /// The task state property allows tracking a task during its lifecycle. Initially the state is just "created".
    /// The TaskState class was modeled so that for each state can be set which the typical prior and posterior states are. This has the advantage that e.g. a UI can retrieve the allowed states at runtime from the ontology; rather can having this potentially changing knowledge hard coded. But the prior and posterior states are only defaults; the human user is always free to change the state.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TaskState"></see></summary>
    let TaskState = Namespaced_IRI.parse _namespace_name "TaskState" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskState_Completed"></see>
    /// </summary>
    let TMO_Instance_TaskState_Completed =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_TaskState_Completed" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskState_Deleted"></see>
    /// </summary>
    let TMO_Instance_TaskState_Deleted =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_TaskState_Deleted" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskState_Finalized"></see>
    /// </summary>
    let TMO_Instance_TaskState_Finalized =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_TaskState_Finalized" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskState_New"></see>
    /// </summary>
    let TMO_Instance_TaskState_New =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_TaskState_New" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskState_Running"></see>
    /// </summary>
    let TMO_Instance_TaskState_Running =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_TaskState_Running" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskState_Suspended"></see>
    /// </summary>
    let TMO_Instance_TaskState_Suspended =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_TaskState_Suspended" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskState_Terminated"></see>
    /// </summary>
    let TMO_Instance_TaskState_Terminated =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_TaskState_Terminated" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TransmissionState_Accepted_NotTransmitted"></see>
    /// </summary>
    let TMO_Instance_TransmissionState_Accepted_NotTransmitted =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_TransmissionState_Accepted_NotTransmitted" |> NamespacedName

    /// <summary>
    /// States a task can go through during transmission of an task.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TransmissionState"></see></summary>
    let TransmissionState =
        Namespaced_IRI.parse _namespace_name "TransmissionState" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TransmissionState_Accepted_Transmitted"></see>
    /// </summary>
    let TMO_Instance_TransmissionState_Accepted_Transmitted =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_TransmissionState_Accepted_Transmitted" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TransmissionState_NotTransmitted"></see>
    /// </summary>
    let TMO_Instance_TransmissionState_NotTransmitted =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_TransmissionState_NotTransmitted" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TransmissionState_Rejected_NotTransmitted"></see>
    /// </summary>
    let TMO_Instance_TransmissionState_Rejected_NotTransmitted =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_TransmissionState_Rejected_NotTransmitted" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TransmissionState_Rejected_Transmitted"></see>
    /// </summary>
    let TMO_Instance_TransmissionState_Rejected_Transmitted =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_TransmissionState_Rejected_Transmitted" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TransmissionState_Transmitted"></see>
    /// </summary>
    let TMO_Instance_TransmissionState_Transmitted =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_TransmissionState_Transmitted" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TransmissionType_Delegation"></see>
    /// </summary>
    let TMO_Instance_TransmissionType_Delegation =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_TransmissionType_Delegation" |> NamespacedName

    /// <summary>
    /// By means of the TransmissionType one can distinguish several different types which might imply a different business logic. e.g. delegation can mean that the results of the task fulfillment care to be reported back to the sender of the task.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TransmissionType"></see></summary>
    let TransmissionType =
        Namespaced_IRI.parse _namespace_name "TransmissionType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TransmissionType_Join"></see>
    /// </summary>
    let TMO_Instance_TransmissionType_Join =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_TransmissionType_Join" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TransmissionType_Transfer"></see>
    /// </summary>
    let TMO_Instance_TransmissionType_Transfer =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_TransmissionType_Transfer" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_01"></see>
    /// </summary>
    let TMO_Instance_Urgency_01 =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_Urgency_01" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#Urgency"></see>
    /// </summary>
    let Urgency = Namespaced_IRI.parse _namespace_name "Urgency" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_02"></see>
    /// </summary>
    let TMO_Instance_Urgency_02 =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_Urgency_02" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_03"></see>
    /// </summary>
    let TMO_Instance_Urgency_03 =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_Urgency_03" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_04"></see>
    /// </summary>
    let TMO_Instance_Urgency_04 =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_Urgency_04" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_05"></see>
    /// </summary>
    let TMO_Instance_Urgency_05 =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_Urgency_05" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_06"></see>
    /// </summary>
    let TMO_Instance_Urgency_06 =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_Urgency_06" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_07"></see>
    /// </summary>
    let TMO_Instance_Urgency_07 =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_Urgency_07" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_08"></see>
    /// </summary>
    let TMO_Instance_Urgency_08 =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_Urgency_08" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_09"></see>
    /// </summary>
    let TMO_Instance_Urgency_09 =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_Urgency_09" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_10"></see>
    /// </summary>
    let TMO_Instance_Urgency_10 =
        Namespaced_IRI.parse _namespace_name "TMO_Instance_Urgency_10" |> NamespacedName

    /// <summary>
    /// The tmo:task is the central entitiey of the tmo. Task can range from vague things to be possibly done in e distant future to concrete things to be done in a precise forseeable manner. It is not unrealisitc to assume that knowledge worker have hundred or more tasks a day.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#Task"></see></summary>
    let Task = Namespaced_IRI.parse _namespace_name "Task" |> NamespacedName

    /// <summary>
    /// On the SSD, tasks are not restricted to one person and may cross from
    /// the PTM of one person to the PTM of another. With transmission, we
    /// refer to the process of sending a task from one person (sender) to one
    /// or more other persons (receiver(s)) (see Section 5.2.1.3 Task
    /// Transmission). Task delegation and task transfer are two special kinds of
    /// task transmission which are described at the end of this section. In
    /// addition, the collaborative task is realized by task transmission.
    /// For the process of sending a task, some information is required. This
    /// information is also modelled in the task ontology. This information is still
    /// useful after the process of sending a task was completed. Task Delegation is a process where the sender of the task restricts the
    /// access rights of the receiver. This includes the right to distribute further
    /// this task and additionally the obligation to give feedback to the sender.
    /// The person that receives a task by delegation usually has not the full
    /// control about the task. The attributes described in the following section
    /// have the purpose to enable such "access rights". The receiver will also
    /// probably have obligations regarding what to report to whom at which
    /// time.
    /// In contrast, the simplest case is that all rights are granted to the receiver
    /// and there is no feedback desired by the sender. What to do with the task
    /// may be apparent by the organization context, or it may be left to the
    /// receiver. This is like sending an email but with the advantage that the
    /// information is transferred in the "task space" of the participating persons.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TaskTransmission"></see></summary>
    let TaskTransmission =
        Namespaced_IRI.parse _namespace_name "TaskTransmission" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#abilityCarrier"></see>
    /// </summary>
    let abilityCarrier =
        Namespaced_IRI.parse _namespace_name "abilityCarrier" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#abilityCarrierInvolvement"></see>
    /// </summary>
    let abilityCarrierInvolvement =
        Namespaced_IRI.parse _namespace_name "abilityCarrierInvolvement" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#abilityCarrierTask"></see>
    /// </summary>
    let abilityCarrierTask =
        Namespaced_IRI.parse _namespace_name "abilityCarrierTask" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#abilityCarrierRole"></see>
    /// </summary>
    let abilityCarrierRole =
        Namespaced_IRI.parse _namespace_name "abilityCarrierRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#stateTypeRole"></see>
    /// </summary>
    let stateTypeRole =
        Namespaced_IRI.parse _namespace_name "stateTypeRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#actualCompletion"></see>
    /// </summary>
    let actualCompletion =
        Namespaced_IRI.parse _namespace_name "actualCompletion" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#progress"></see>
    /// </summary>
    let progress = Namespaced_IRI.parse _namespace_name "progress" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#actualEndTime"></see>
    /// </summary>
    let actualEndTime =
        Namespaced_IRI.parse _namespace_name "actualEndTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#endTime"></see>
    /// </summary>
    let endTime = Namespaced_IRI.parse _namespace_name "endTime" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#actualTime"></see>
    /// </summary>
    let actualTime = Namespaced_IRI.parse _namespace_name "actualTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#actualStartTime"></see>
    /// </summary>
    let actualStartTime =
        Namespaced_IRI.parse _namespace_name "actualStartTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#startTime"></see>
    /// </summary>
    let startTime = Namespaced_IRI.parse _namespace_name "startTime" |> NamespacedName
    /// <summary>
    /// dateTime subsumes various properties with Range XMLSchema:dateTime. If possible they are further grouped by "abstract" properties.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#dateTime"></see></summary>
    let dateTime = Namespaced_IRI.parse _namespace_name "dateTime" |> NamespacedName
    /// <summary>
    /// connects a Task with an Attachment object. Attachments are associations of Things.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#attachment"></see></summary>
    let attachment = Namespaced_IRI.parse _namespace_name "attachment" |> NamespacedName

    /// <summary>
    /// Inverse of attachment, connects an Attachment Association to the associated Task. Is required for every instance of Attachment.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#attachmentTask"></see></summary>
    let attachmentTask =
        Namespaced_IRI.parse _namespace_name "attachmentTask" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#attachmentReference"></see>
    /// </summary>
    let attachmentReference =
        Namespaced_IRI.parse _namespace_name "attachmentReference" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#attachmentRole"></see>
    /// </summary>
    let attachmentRole =
        Namespaced_IRI.parse _namespace_name "attachmentRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#containsTask"></see>
    /// </summary>
    let containsTask =
        Namespaced_IRI.parse _namespace_name "containsTask" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#contextTask"></see>
    /// </summary>
    let contextTask =
        Namespaced_IRI.parse _namespace_name "contextTask" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#contextThread"></see>
    /// </summary>
    let contextThread =
        Namespaced_IRI.parse _namespace_name "contextThread" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#createdBy"></see>
    /// </summary>
    let createdBy = Namespaced_IRI.parse _namespace_name "createdBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#delegability"></see>
    /// </summary>
    let delegability =
        Namespaced_IRI.parse _namespace_name "delegability" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#timemanagement"></see>
    /// </summary>
    let timemanagement =
        Namespaced_IRI.parse _namespace_name "timemanagement" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#dependency"></see>
    /// </summary>
    let dependency = Namespaced_IRI.parse _namespace_name "dependency" |> NamespacedName

    /// <summary>
    /// Endusers can clarify why they created a depedency.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#dependencyDescription"></see></summary>
    let dependencyDescription =
        Namespaced_IRI.parse _namespace_name "dependencyDescription" |> NamespacedName

    /// <summary>
    /// The semantic of this relation is defined in the sublclass of undirected Dependency on which this property is stated. (The subject of the statment where this property is expressed)
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#dependencyMemberA"></see></summary>
    let dependencyMemberA =
        Namespaced_IRI.parse _namespace_name "dependencyMemberA" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskReference"></see>
    /// </summary>
    let taskReference =
        Namespaced_IRI.parse _namespace_name "taskReference" |> NamespacedName

    /// <summary>
    /// The semantic of this relation is defined in the sublclass of undirected Dependency on which this property is stated. (The subject of the statment where this property is expressed)
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#dependencyMemberB"></see></summary>
    let dependencyMemberB =
        Namespaced_IRI.parse _namespace_name "dependencyMemberB" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#dependencyOrderNumber"></see>
    /// </summary>
    let dependencyOrderNumber =
        Namespaced_IRI.parse _namespace_name "dependencyOrderNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#dependencyType"></see>
    /// </summary>
    let dependencyType =
        Namespaced_IRI.parse _namespace_name "dependencyType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#dueDate"></see>
    /// </summary>
    let dueDate = Namespaced_IRI.parse _namespace_name "dueDate" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#importance"></see>
    /// </summary>
    let importance = Namespaced_IRI.parse _namespace_name "importance" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#indexPosition"></see>
    /// </summary>
    let indexPosition =
        Namespaced_IRI.parse _namespace_name "indexPosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#involvedPerson"></see>
    /// </summary>
    let involvedPerson =
        Namespaced_IRI.parse _namespace_name "involvedPerson" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#involvedPersonRole"></see>
    /// </summary>
    let involvedPersonRole =
        Namespaced_IRI.parse _namespace_name "involvedPersonRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#involvedPersonTask"></see>
    /// </summary>
    let involvedPersonTask =
        Namespaced_IRI.parse _namespace_name "involvedPersonTask" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#involvedPersons"></see>
    /// </summary>
    let involvedPersons =
        Namespaced_IRI.parse _namespace_name "involvedPersons" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#lastReviewDate"></see>
    /// </summary>
    let lastReviewDate =
        Namespaced_IRI.parse _namespace_name "lastReviewDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#logEntry"></see>
    /// </summary>
    let logEntry = Namespaced_IRI.parse _namespace_name "logEntry" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#nextReviewIntervall"></see>
    /// </summary>
    let nextReviewIntervall =
        Namespaced_IRI.parse _namespace_name "nextReviewIntervall" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#priority"></see>
    /// </summary>
    let priority = Namespaced_IRI.parse _namespace_name "priority" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#receiveDateTime"></see>
    /// </summary>
    let receiveDateTime =
        Namespaced_IRI.parse _namespace_name "receiveDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#sendDateTime"></see>
    /// </summary>
    let sendDateTime =
        Namespaced_IRI.parse _namespace_name "sendDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#subTask"></see>
    /// </summary>
    let subTask = Namespaced_IRI.parse _namespace_name "subTask" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#superTask"></see>
    /// </summary>
    let superTask = Namespaced_IRI.parse _namespace_name "superTask" |> NamespacedName

    /// <summary>
    /// Ordering of the subtasks listed in the tmo:subTasks property of this Task. This is only for ordering/sorting in GUIs, the semantic relation is defined in subTasks, and if this and subTasks differ, subTasks is the correct list.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#subTaskOrdering"></see></summary>
    let subTaskOrdering =
        Namespaced_IRI.parse _namespace_name "subTaskOrdering" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#targetCompletion"></see>
    /// </summary>
    let targetCompletion =
        Namespaced_IRI.parse _namespace_name "targetCompletion" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#targetEndTime"></see>
    /// </summary>
    let targetEndTime =
        Namespaced_IRI.parse _namespace_name "targetEndTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#targetTime"></see>
    /// </summary>
    let targetTime = Namespaced_IRI.parse _namespace_name "targetTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#targetStartTime"></see>
    /// </summary>
    let targetStartTime =
        Namespaced_IRI.parse _namespace_name "targetStartTime" |> NamespacedName

    /// <summary>
    /// The task description helps users to understand the goal and the proceeding of a task. It can also describe the context of a task. The task description is composed at minimum of a summary of what is done to reach the goal. The task description is the main source for identifying related information, e.g., suitable patterns.
    /// A Task Description can be either an informal, described textual content (TextualDescription) or it can be a more formally structured representation (FormalDescription).
    /// Technology considerations: Informal descriptions allow for text similarity processing, a formal description allows for applying case based similarity measures.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskDescription"></see></summary>
    let taskDescription =
        Namespaced_IRI.parse _namespace_name "taskDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskGoal"></see>
    /// </summary>
    let taskGoal = Namespaced_IRI.parse _namespace_name "taskGoal" |> NamespacedName
    /// <summary>
    /// The Task Identifier allows a unique identification of a task object within the range of all Nepomuk objects.
    /// The Task Identifier is automatically generated during the creation of a task. The generation of identifiers (IDs) is a Nepomuk architecture issue (Wp2000/WP6000).
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskId"></see></summary>
    let taskId = Namespaced_IRI.parse _namespace_name "taskId" |> NamespacedName
    /// <summary>
    /// The Task Name helps the user to identify a task in a list. It should be expressive enough to give a meaningful recognition. Details should be written in the description attribute instead. A name attribute is not allowed to contain line breaks.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskName"></see></summary>
    let taskName = Namespaced_IRI.parse _namespace_name "taskName" |> NamespacedName

    /// <summary>
    /// For the separation between professional and private purpose of a task, this attribute provides with the values "professional/private" a high level separation of privacy in terms of setting distribution rights to other users for the task.
    /// This separation may arise as a general Nepomuk issue and may therefore be handled in conjunction with a privacy preserving SSD architecture.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskPrivacyState"></see></summary>
    let taskPrivacyState =
        Namespaced_IRI.parse _namespace_name "taskPrivacyState" |> NamespacedName

    /// <summary>
    /// here can be stated from which sources a task was derived. e.g from another task or from an task pattern
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskSource"></see></summary>
    let taskSource = Namespaced_IRI.parse _namespace_name "taskSource" |> NamespacedName
    /// <summary>
    /// The task state describes the current state of the task as described in Section 5.2.7.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskState"></see></summary>
    let taskState = Namespaced_IRI.parse _namespace_name "taskState" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskStateChangesFrom"></see>
    /// </summary>
    let taskStateChangesFrom =
        Namespaced_IRI.parse _namespace_name "taskStateChangesFrom" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskStateChangesTo"></see>
    /// </summary>
    let taskStateChangesTo =
        Namespaced_IRI.parse _namespace_name "taskStateChangesTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskTransmission"></see>
    /// </summary>
    let taskTransmission =
        Namespaced_IRI.parse _namespace_name "taskTransmission" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#transmissionTask"></see>
    /// </summary>
    let transmissionTask =
        Namespaced_IRI.parse _namespace_name "transmissionTask" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#transmissionFrom"></see>
    /// </summary>
    let transmissionFrom =
        Namespaced_IRI.parse _namespace_name "transmissionFrom" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#transmissionState"></see>
    /// </summary>
    let transmissionState =
        Namespaced_IRI.parse _namespace_name "transmissionState" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#transmissionStateChangesFrom"></see>
    /// </summary>
    let transmissionStateChangesFrom =
        Namespaced_IRI.parse _namespace_name "transmissionStateChangesFrom" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#transmissionStateChangesTo"></see>
    /// </summary>
    let transmissionStateChangesTo =
        Namespaced_IRI.parse _namespace_name "transmissionStateChangesTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#transmissionTo"></see>
    /// </summary>
    let transmissionTo =
        Namespaced_IRI.parse _namespace_name "transmissionTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#transmissionType"></see>
    /// </summary>
    let transmissionType =
        Namespaced_IRI.parse _namespace_name "transmissionType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#urgency"></see>
    /// </summary>
    let urgency = Namespaced_IRI.parse _namespace_name "urgency" |> NamespacedName
