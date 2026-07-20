namespace http.www.semanticdesktop.org.ontologies._2008._05._20.tmo.hash

open DoxAletheia

module tmo =
    let _namespace_name = "http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

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
    let AbilityCarrier = _prefix "AbilityCarrier"
    /// <summary>
    /// The class AbilityCarrier_Involvement ties together an AbilityCarrier with an AbilityCarrier_Role. This is a role based modelling approach. An n-ary relation is realized.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#AbilityCarrierInvolvement"></see></summary>
    let AbilityCarrierInvolvement = _prefix "AbilityCarrierInvolvement"
    /// <summary>
    /// Examples instances  of AbilityCarrirRoles are e.g. "requested", "required" and "used" which further specify the type a person was involved in.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#AbilityCarrierRole"></see></summary>
    let AbilityCarrierRole = _prefix "AbilityCarrierRole"
    /// <summary>
    /// StateTypeRole is an abstract class which subsumes various other classes which represent "states" or roles e.g. in role based modelling conpetualisations.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#StateTypeRole"></see></summary>
    let StateTypeRole = _prefix "StateTypeRole"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#AgentAbilityCarrier"></see>
    /// </summary>
    let AgentAbilityCarrier = _prefix "AgentAbilityCarrier"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#AssociationDependency"></see>
    /// </summary>
    let AssociationDependency = _prefix "AssociationDependency"
    /// <summary>
    /// A symmetric relations between task.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#UndirectedDependency"></see></summary>
    let UndirectedDependency = _prefix "UndirectedDependency"
    /// <summary>
    /// By means of attachments, references to other resources can be established. Resources are information objects. Every Thing, which can be referenced, on the SSD is an information object. In contrast to the usual SSD references/associations, here additionally information can be specified. Further metadata about the role an attachment plays can be stated by means of instances of AttachmentRole. It can be expressed what the Role of attachment is e.g., regarding "desired/requested" or "required" or "potentially useful / somehow related" or "used/produced/achieved". The reference property models the actual link to the attached piece of information.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#Attachment"></see></summary>
    let Attachment = _prefix "Attachment"
    /// <summary>
    /// AttachmentRoles further specify the type of how an attachment relates to a task. Example instances  of AttachmentRoles are e.g. "desired_request", "required" and "used".
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#AttachmentRole"></see></summary>
    let AttachmentRole = _prefix "AttachmentRole"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#Delegability"></see>
    /// </summary>
    let Delegability = _prefix "Delegability"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#Importance"></see>
    /// </summary>
    let Importance = _prefix "Importance"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#Interdependence"></see>
    /// </summary>
    let Interdependence = _prefix "Interdependence"
    /// <summary>
    /// PersonInvolvement  realizes n-ary associations to Persons which are realtedd to an task. The involvement is further characterized by an PersonTaskRole.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#PersonInvolvement"></see></summary>
    let PersonInvolvement = _prefix "PersonInvolvement"
    /// <summary>
    /// They further specify the type a person was related to an task.
    /// Examples instances  of AttachmentRoles are e.g.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#PersonInvolvementRole"></see></summary>
    let PersonInvolvementRole = _prefix "PersonInvolvementRole"
    /// <summary>
    /// In a  PredecessorDependency the dependencyMemberA is the task which is to be executed before dependencyMemberB.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#PredecessorDependency"></see></summary>
    let PredecessorDependency = _prefix "PredecessorDependency"
    /// <summary>
    /// The PredecessorSuccessorDependency enables a directed relation between task. By means of the concrete sublcasses one can further distinguish from which point of view this relation is created.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#PredecessorSuccessorDependency"></see></summary>
    let PredecessorSuccessorDependency = _prefix "PredecessorSuccessorDependency"
    /// <summary>
    /// Between the tasks, further dependencies may exist. These dependencies allow for a graph network structure. For ease of use, dependencies should not be too frequent, otherwise the primarily character of a hierarchy would be diminished and a consequent graph representation would become considerable. However, such a graph representation has other drawbacks, the user is likely to loose oversight, tree structures are more helpful in structuring the work.
    ///
    /// A dependency relation is characterized by the type of the relation and by an additional description. There are different possibilities for dependency relations between tasks.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TaskDependency"></see></summary>
    let TaskDependency = _prefix "TaskDependency"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#Priority"></see>
    /// </summary>
    let Priority = _prefix "Priority"
    /// <summary>
    /// examples: Architect, Developer, ...
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#Role"></see></summary>
    let Role = _prefix "Role"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#SimilarityDependence"></see>
    /// </summary>
    let SimilarityDependence = _prefix "SimilarityDependence"
    /// <summary>
    /// examples are e.g. technologies like Java, XML,  ...
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#Skill"></see></summary>
    let Skill = _prefix "Skill"
    /// <summary>
    /// In a SuccessorrDependency the dependencyMemberA is the task which is to be executed after dependencyMemberB.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#SuccessorDependency"></see></summary>
    let SuccessorDependency = _prefix "SuccessorDependency"
    /// <summary>
    /// By means of the SuperSubTaskDependency one can further describe the subtask-supertask relation .e.g by an descriptin. This enables an n-ary relation between subtask and supertask.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#SuperSubTaskDependency"></see></summary>
    let SuperSubTaskDependency = _prefix "SuperSubTaskDependency"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_AbilityCarrierRole_Requested"></see>
    /// </summary>
    let TMO_Instance_AbilityCarrierRole_Requested =
        _prefix "TMO_Instance_AbilityCarrierRole_Requested"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_AbilityCarrierRole_Required"></see>
    /// </summary>
    let TMO_Instance_AbilityCarrierRole_Required =
        _prefix "TMO_Instance_AbilityCarrierRole_Required"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_AbilityCarrierRole_Used"></see>
    /// </summary>
    let TMO_Instance_AbilityCarrierRole_Used =
        _prefix "TMO_Instance_AbilityCarrierRole_Used"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_AttachmentRole_Desired_Requested"></see>
    /// </summary>
    let TMO_Instance_AttachmentRole_Desired_Requested =
        _prefix "TMO_Instance_AttachmentRole_Desired_Requested"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_AttachmentRole_Related"></see>
    /// </summary>
    let TMO_Instance_AttachmentRole_Related =
        _prefix "TMO_Instance_AttachmentRole_Related"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_AttachmentRole_Required"></see>
    /// </summary>
    let TMO_Instance_AttachmentRole_Required =
        _prefix "TMO_Instance_AttachmentRole_Required"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_AttachmentRole_Used"></see>
    /// </summary>
    let TMO_Instance_AttachmentRole_Used = _prefix "TMO_Instance_AttachmentRole_Used"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Delegability_High"></see>
    /// </summary>
    let TMO_Instance_Delegability_High = _prefix "TMO_Instance_Delegability_High"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Delegability_Low"></see>
    /// </summary>
    let TMO_Instance_Delegability_Low = _prefix "TMO_Instance_Delegability_Low"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Delegability_Medium"></see>
    /// </summary>
    let TMO_Instance_Delegability_Medium = _prefix "TMO_Instance_Delegability_Medium"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Delegability_Never"></see>
    /// </summary>
    let TMO_Instance_Delegability_Never = _prefix "TMO_Instance_Delegability_Never"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Delegability_Unrestricted"></see>
    /// </summary>
    let TMO_Instance_Delegability_Unrestricted =
        _prefix "TMO_Instance_Delegability_Unrestricted"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_01"></see>
    /// </summary>
    let TMO_Instance_Importance_01 = _prefix "TMO_Instance_Importance_01"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_02"></see>
    /// </summary>
    let TMO_Instance_Importance_02 = _prefix "TMO_Instance_Importance_02"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_03"></see>
    /// </summary>
    let TMO_Instance_Importance_03 = _prefix "TMO_Instance_Importance_03"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_04"></see>
    /// </summary>
    let TMO_Instance_Importance_04 = _prefix "TMO_Instance_Importance_04"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_05"></see>
    /// </summary>
    let TMO_Instance_Importance_05 = _prefix "TMO_Instance_Importance_05"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_06"></see>
    /// </summary>
    let TMO_Instance_Importance_06 = _prefix "TMO_Instance_Importance_06"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_07"></see>
    /// </summary>
    let TMO_Instance_Importance_07 = _prefix "TMO_Instance_Importance_07"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_08"></see>
    /// </summary>
    let TMO_Instance_Importance_08 = _prefix "TMO_Instance_Importance_08"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_09"></see>
    /// </summary>
    let TMO_Instance_Importance_09 = _prefix "TMO_Instance_Importance_09"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_10"></see>
    /// </summary>
    let TMO_Instance_Importance_10 = _prefix "TMO_Instance_Importance_10"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Analyst"></see>
    /// </summary>
    let TMO_Instance_PersonInvolvementRole_Analyst =
        _prefix "TMO_Instance_PersonInvolvementRole_Analyst"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Co-worker"></see>
    /// </summary>
    let ``TMO_Instance_PersonInvolvementRole_Co-worker`` =
        _prefix "TMO_Instance_PersonInvolvementRole_Co-worker"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Collaborator"></see>
    /// </summary>
    let TMO_Instance_PersonInvolvementRole_Collaborator =
        _prefix "TMO_Instance_PersonInvolvementRole_Collaborator"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Controller"></see>
    /// </summary>
    let TMO_Instance_PersonInvolvementRole_Controller =
        _prefix "TMO_Instance_PersonInvolvementRole_Controller"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Creator"></see>
    /// </summary>
    let TMO_Instance_PersonInvolvementRole_Creator =
        _prefix "TMO_Instance_PersonInvolvementRole_Creator"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Delegate"></see>
    /// </summary>
    let TMO_Instance_PersonInvolvementRole_Delegate =
        _prefix "TMO_Instance_PersonInvolvementRole_Delegate"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Executor"></see>
    /// </summary>
    let TMO_Instance_PersonInvolvementRole_Executor =
        _prefix "TMO_Instance_PersonInvolvementRole_Executor"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_ExternalObserver"></see>
    /// </summary>
    let TMO_Instance_PersonInvolvementRole_ExternalObserver =
        _prefix "TMO_Instance_PersonInvolvementRole_ExternalObserver"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Initiator"></see>
    /// </summary>
    let TMO_Instance_PersonInvolvementRole_Initiator =
        _prefix "TMO_Instance_PersonInvolvementRole_Initiator"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_InternalObserver"></see>
    /// </summary>
    let TMO_Instance_PersonInvolvementRole_InternalObserver =
        _prefix "TMO_Instance_PersonInvolvementRole_InternalObserver"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Involved"></see>
    /// </summary>
    let TMO_Instance_PersonInvolvementRole_Involved =
        _prefix "TMO_Instance_PersonInvolvementRole_Involved"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Observer"></see>
    /// </summary>
    let TMO_Instance_PersonInvolvementRole_Observer =
        _prefix "TMO_Instance_PersonInvolvementRole_Observer"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Owner"></see>
    /// </summary>
    let TMO_Instance_PersonInvolvementRole_Owner =
        _prefix "TMO_Instance_PersonInvolvementRole_Owner"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Receiver"></see>
    /// </summary>
    let TMO_Instance_PersonInvolvementRole_Receiver =
        _prefix "TMO_Instance_PersonInvolvementRole_Receiver"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Related"></see>
    /// </summary>
    let TMO_Instance_PersonInvolvementRole_Related =
        _prefix "TMO_Instance_PersonInvolvementRole_Related"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Reviewer"></see>
    /// </summary>
    let TMO_Instance_PersonInvolvementRole_Reviewer =
        _prefix "TMO_Instance_PersonInvolvementRole_Reviewer"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Suggested"></see>
    /// </summary>
    let TMO_Instance_PersonInvolvementRole_Suggested =
        _prefix "TMO_Instance_PersonInvolvementRole_Suggested"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Priority_High"></see>
    /// </summary>
    let TMO_Instance_Priority_High = _prefix "TMO_Instance_Priority_High"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Priority_Low"></see>
    /// </summary>
    let TMO_Instance_Priority_Low = _prefix "TMO_Instance_Priority_Low"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Priority_Medium"></see>
    /// </summary>
    let TMO_Instance_Priority_Medium = _prefix "TMO_Instance_Priority_Medium"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskContainer_activetasks"></see>
    /// </summary>
    let TMO_Instance_TaskContainer_activetasks =
        _prefix "TMO_Instance_TaskContainer_activetasks"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TaskContainer"></see>
    /// </summary>
    let TaskContainer = _prefix "TaskContainer"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskContainer_archive"></see>
    /// </summary>
    let TMO_Instance_TaskContainer_archive =
        _prefix "TMO_Instance_TaskContainer_archive"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskContainer_inbox"></see>
    /// </summary>
    let TMO_Instance_TaskContainer_inbox = _prefix "TMO_Instance_TaskContainer_inbox"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskContainer_outbox"></see>
    /// </summary>
    let TMO_Instance_TaskContainer_outbox = _prefix "TMO_Instance_TaskContainer_outbox"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskContainer_trashtasks"></see>
    /// </summary>
    let TMO_Instance_TaskContainer_trashtasks =
        _prefix "TMO_Instance_TaskContainer_trashtasks"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskPrivacy_Private"></see>
    /// </summary>
    let TMO_Instance_TaskPrivacy_Private = _prefix "TMO_Instance_TaskPrivacy_Private"
    /// <summary>
    /// Privacy Status serves for the separation between a professional and a private purpose of a task. This attribute provides with the values "professional/private" a high-level separation of privacy in terms of setting distribution and access
    /// rights to other users for the task.
    /// This separation may arise as a general Nepomuk issue and may therefore be handled in conjunction with a privacy preserving SSD architecture.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TaskPrivacyState"></see></summary>
    let TaskPrivacyState = _prefix "TaskPrivacyState"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskPrivacy_Professional"></see>
    /// </summary>
    let TMO_Instance_TaskPrivacy_Professional =
        _prefix "TMO_Instance_TaskPrivacy_Professional"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskState_Archived"></see>
    /// </summary>
    let TMO_Instance_TaskState_Archived = _prefix "TMO_Instance_TaskState_Archived"
    /// <summary>
    /// The task state property allows tracking a task during its lifecycle. Initially the state is just "created".
    /// The TaskState class was modeled so that for each state can be set which the typical prior and posterior states are. This has the advantage that e.g. a UI can retrieve the allowed states at runtime from the ontology; rather can having this potentially changing knowledge hard coded. But the prior and posterior states are only defaults; the human user is always free to change the state.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TaskState"></see></summary>
    let TaskState = _prefix "TaskState"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskState_Completed"></see>
    /// </summary>
    let TMO_Instance_TaskState_Completed = _prefix "TMO_Instance_TaskState_Completed"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskState_Deleted"></see>
    /// </summary>
    let TMO_Instance_TaskState_Deleted = _prefix "TMO_Instance_TaskState_Deleted"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskState_Finalized"></see>
    /// </summary>
    let TMO_Instance_TaskState_Finalized = _prefix "TMO_Instance_TaskState_Finalized"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskState_New"></see>
    /// </summary>
    let TMO_Instance_TaskState_New = _prefix "TMO_Instance_TaskState_New"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskState_Running"></see>
    /// </summary>
    let TMO_Instance_TaskState_Running = _prefix "TMO_Instance_TaskState_Running"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskState_Suspended"></see>
    /// </summary>
    let TMO_Instance_TaskState_Suspended = _prefix "TMO_Instance_TaskState_Suspended"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskState_Terminated"></see>
    /// </summary>
    let TMO_Instance_TaskState_Terminated = _prefix "TMO_Instance_TaskState_Terminated"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TransmissionState_Accepted_NotTransmitted"></see>
    /// </summary>
    let TMO_Instance_TransmissionState_Accepted_NotTransmitted =
        _prefix "TMO_Instance_TransmissionState_Accepted_NotTransmitted"

    /// <summary>
    /// States a task can go through during transmission of an task.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TransmissionState"></see></summary>
    let TransmissionState = _prefix "TransmissionState"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TransmissionState_Accepted_Transmitted"></see>
    /// </summary>
    let TMO_Instance_TransmissionState_Accepted_Transmitted =
        _prefix "TMO_Instance_TransmissionState_Accepted_Transmitted"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TransmissionState_NotTransmitted"></see>
    /// </summary>
    let TMO_Instance_TransmissionState_NotTransmitted =
        _prefix "TMO_Instance_TransmissionState_NotTransmitted"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TransmissionState_Rejected_NotTransmitted"></see>
    /// </summary>
    let TMO_Instance_TransmissionState_Rejected_NotTransmitted =
        _prefix "TMO_Instance_TransmissionState_Rejected_NotTransmitted"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TransmissionState_Rejected_Transmitted"></see>
    /// </summary>
    let TMO_Instance_TransmissionState_Rejected_Transmitted =
        _prefix "TMO_Instance_TransmissionState_Rejected_Transmitted"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TransmissionState_Transmitted"></see>
    /// </summary>
    let TMO_Instance_TransmissionState_Transmitted =
        _prefix "TMO_Instance_TransmissionState_Transmitted"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TransmissionType_Delegation"></see>
    /// </summary>
    let TMO_Instance_TransmissionType_Delegation =
        _prefix "TMO_Instance_TransmissionType_Delegation"

    /// <summary>
    /// By means of the TransmissionType one can distinguish several different types which might imply a different business logic. e.g. delegation can mean that the results of the task fulfillment care to be reported back to the sender of the task.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TransmissionType"></see></summary>
    let TransmissionType = _prefix "TransmissionType"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TransmissionType_Join"></see>
    /// </summary>
    let TMO_Instance_TransmissionType_Join =
        _prefix "TMO_Instance_TransmissionType_Join"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TransmissionType_Transfer"></see>
    /// </summary>
    let TMO_Instance_TransmissionType_Transfer =
        _prefix "TMO_Instance_TransmissionType_Transfer"

    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_01"></see>
    /// </summary>
    let TMO_Instance_Urgency_01 = _prefix "TMO_Instance_Urgency_01"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#Urgency"></see>
    /// </summary>
    let Urgency = _prefix "Urgency"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_02"></see>
    /// </summary>
    let TMO_Instance_Urgency_02 = _prefix "TMO_Instance_Urgency_02"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_03"></see>
    /// </summary>
    let TMO_Instance_Urgency_03 = _prefix "TMO_Instance_Urgency_03"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_04"></see>
    /// </summary>
    let TMO_Instance_Urgency_04 = _prefix "TMO_Instance_Urgency_04"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_05"></see>
    /// </summary>
    let TMO_Instance_Urgency_05 = _prefix "TMO_Instance_Urgency_05"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_06"></see>
    /// </summary>
    let TMO_Instance_Urgency_06 = _prefix "TMO_Instance_Urgency_06"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_07"></see>
    /// </summary>
    let TMO_Instance_Urgency_07 = _prefix "TMO_Instance_Urgency_07"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_08"></see>
    /// </summary>
    let TMO_Instance_Urgency_08 = _prefix "TMO_Instance_Urgency_08"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_09"></see>
    /// </summary>
    let TMO_Instance_Urgency_09 = _prefix "TMO_Instance_Urgency_09"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_10"></see>
    /// </summary>
    let TMO_Instance_Urgency_10 = _prefix "TMO_Instance_Urgency_10"
    /// <summary>
    /// The tmo:task is the central entitiey of the tmo. Task can range from vague things to be possibly done in e distant future to concrete things to be done in a precise forseeable manner. It is not unrealisitc to assume that knowledge worker have hundred or more tasks a day.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#Task"></see></summary>
    let Task = _prefix "Task"
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
    let TaskTransmission = _prefix "TaskTransmission"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#abilityCarrier"></see>
    /// </summary>
    let abilityCarrier = _prefix "abilityCarrier"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#abilityCarrierInvolvement"></see>
    /// </summary>
    let abilityCarrierInvolvement = _prefix "abilityCarrierInvolvement"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#abilityCarrierTask"></see>
    /// </summary>
    let abilityCarrierTask = _prefix "abilityCarrierTask"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#abilityCarrierRole"></see>
    /// </summary>
    let abilityCarrierRole = _prefix "abilityCarrierRole"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#stateTypeRole"></see>
    /// </summary>
    let stateTypeRole = _prefix "stateTypeRole"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#actualCompletion"></see>
    /// </summary>
    let actualCompletion = _prefix "actualCompletion"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#progress"></see>
    /// </summary>
    let progress = _prefix "progress"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#actualEndTime"></see>
    /// </summary>
    let actualEndTime = _prefix "actualEndTime"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#endTime"></see>
    /// </summary>
    let endTime = _prefix "endTime"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#actualTime"></see>
    /// </summary>
    let actualTime = _prefix "actualTime"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#actualStartTime"></see>
    /// </summary>
    let actualStartTime = _prefix "actualStartTime"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#startTime"></see>
    /// </summary>
    let startTime = _prefix "startTime"
    /// <summary>
    /// dateTime subsumes various properties with Range XMLSchema:dateTime. If possible they are further grouped by "abstract" properties.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#dateTime"></see></summary>
    let dateTime = _prefix "dateTime"
    /// <summary>
    /// connects a Task with an Attachment object. Attachments are associations of Things.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#attachment"></see></summary>
    let attachment = _prefix "attachment"
    /// <summary>
    /// Inverse of attachment, connects an Attachment Association to the associated Task. Is required for every instance of Attachment.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#attachmentTask"></see></summary>
    let attachmentTask = _prefix "attachmentTask"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#attachmentReference"></see>
    /// </summary>
    let attachmentReference = _prefix "attachmentReference"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#attachmentRole"></see>
    /// </summary>
    let attachmentRole = _prefix "attachmentRole"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#containsTask"></see>
    /// </summary>
    let containsTask = _prefix "containsTask"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#contextTask"></see>
    /// </summary>
    let contextTask = _prefix "contextTask"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#contextThread"></see>
    /// </summary>
    let contextThread = _prefix "contextThread"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#createdBy"></see>
    /// </summary>
    let createdBy = _prefix "createdBy"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#delegability"></see>
    /// </summary>
    let delegability = _prefix "delegability"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#timemanagement"></see>
    /// </summary>
    let timemanagement = _prefix "timemanagement"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#dependency"></see>
    /// </summary>
    let dependency = _prefix "dependency"
    /// <summary>
    /// Endusers can clarify why they created a depedency.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#dependencyDescription"></see></summary>
    let dependencyDescription = _prefix "dependencyDescription"
    /// <summary>
    /// The semantic of this relation is defined in the sublclass of undirected Dependency on which this property is stated. (The subject of the statment where this property is expressed)
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#dependencyMemberA"></see></summary>
    let dependencyMemberA = _prefix "dependencyMemberA"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskReference"></see>
    /// </summary>
    let taskReference = _prefix "taskReference"
    /// <summary>
    /// The semantic of this relation is defined in the sublclass of undirected Dependency on which this property is stated. (The subject of the statment where this property is expressed)
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#dependencyMemberB"></see></summary>
    let dependencyMemberB = _prefix "dependencyMemberB"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#dependencyOrderNumber"></see>
    /// </summary>
    let dependencyOrderNumber = _prefix "dependencyOrderNumber"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#dependencyType"></see>
    /// </summary>
    let dependencyType = _prefix "dependencyType"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#dueDate"></see>
    /// </summary>
    let dueDate = _prefix "dueDate"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#importance"></see>
    /// </summary>
    let importance = _prefix "importance"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#indexPosition"></see>
    /// </summary>
    let indexPosition = _prefix "indexPosition"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#involvedPerson"></see>
    /// </summary>
    let involvedPerson = _prefix "involvedPerson"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#involvedPersonRole"></see>
    /// </summary>
    let involvedPersonRole = _prefix "involvedPersonRole"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#involvedPersonTask"></see>
    /// </summary>
    let involvedPersonTask = _prefix "involvedPersonTask"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#involvedPersons"></see>
    /// </summary>
    let involvedPersons = _prefix "involvedPersons"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#lastReviewDate"></see>
    /// </summary>
    let lastReviewDate = _prefix "lastReviewDate"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#logEntry"></see>
    /// </summary>
    let logEntry = _prefix "logEntry"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#nextReviewIntervall"></see>
    /// </summary>
    let nextReviewIntervall = _prefix "nextReviewIntervall"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#priority"></see>
    /// </summary>
    let priority = _prefix "priority"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#receiveDateTime"></see>
    /// </summary>
    let receiveDateTime = _prefix "receiveDateTime"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#sendDateTime"></see>
    /// </summary>
    let sendDateTime = _prefix "sendDateTime"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#subTask"></see>
    /// </summary>
    let subTask = _prefix "subTask"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#superTask"></see>
    /// </summary>
    let superTask = _prefix "superTask"
    /// <summary>
    /// Ordering of the subtasks listed in the tmo:subTasks property of this Task. This is only for ordering/sorting in GUIs, the semantic relation is defined in subTasks, and if this and subTasks differ, subTasks is the correct list.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#subTaskOrdering"></see></summary>
    let subTaskOrdering = _prefix "subTaskOrdering"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#targetCompletion"></see>
    /// </summary>
    let targetCompletion = _prefix "targetCompletion"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#targetEndTime"></see>
    /// </summary>
    let targetEndTime = _prefix "targetEndTime"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#targetTime"></see>
    /// </summary>
    let targetTime = _prefix "targetTime"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#targetStartTime"></see>
    /// </summary>
    let targetStartTime = _prefix "targetStartTime"
    /// <summary>
    /// The task description helps users to understand the goal and the proceeding of a task. It can also describe the context of a task. The task description is composed at minimum of a summary of what is done to reach the goal. The task description is the main source for identifying related information, e.g., suitable patterns.
    /// A Task Description can be either an informal, described textual content (TextualDescription) or it can be a more formally structured representation (FormalDescription).
    /// Technology considerations: Informal descriptions allow for text similarity processing, a formal description allows for applying case based similarity measures.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskDescription"></see></summary>
    let taskDescription = _prefix "taskDescription"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskGoal"></see>
    /// </summary>
    let taskGoal = _prefix "taskGoal"
    /// <summary>
    /// The Task Identifier allows a unique identification of a task object within the range of all Nepomuk objects.
    /// The Task Identifier is automatically generated during the creation of a task. The generation of identifiers (IDs) is a Nepomuk architecture issue (Wp2000/WP6000).
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskId"></see></summary>
    let taskId = _prefix "taskId"
    /// <summary>
    /// The Task Name helps the user to identify a task in a list. It should be expressive enough to give a meaningful recognition. Details should be written in the description attribute instead. A name attribute is not allowed to contain line breaks.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskName"></see></summary>
    let taskName = _prefix "taskName"
    /// <summary>
    /// For the separation between professional and private purpose of a task, this attribute provides with the values "professional/private" a high level separation of privacy in terms of setting distribution rights to other users for the task.
    /// This separation may arise as a general Nepomuk issue and may therefore be handled in conjunction with a privacy preserving SSD architecture.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskPrivacyState"></see></summary>
    let taskPrivacyState = _prefix "taskPrivacyState"
    /// <summary>
    /// here can be stated from which sources a task was derived. e.g from another task or from an task pattern
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskSource"></see></summary>
    let taskSource = _prefix "taskSource"
    /// <summary>
    /// The task state describes the current state of the task as described in Section 5.2.7.
    /// <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskState"></see></summary>
    let taskState = _prefix "taskState"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskStateChangesFrom"></see>
    /// </summary>
    let taskStateChangesFrom = _prefix "taskStateChangesFrom"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskStateChangesTo"></see>
    /// </summary>
    let taskStateChangesTo = _prefix "taskStateChangesTo"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskTransmission"></see>
    /// </summary>
    let taskTransmission = _prefix "taskTransmission"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#transmissionTask"></see>
    /// </summary>
    let transmissionTask = _prefix "transmissionTask"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#transmissionFrom"></see>
    /// </summary>
    let transmissionFrom = _prefix "transmissionFrom"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#transmissionState"></see>
    /// </summary>
    let transmissionState = _prefix "transmissionState"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#transmissionStateChangesFrom"></see>
    /// </summary>
    let transmissionStateChangesFrom = _prefix "transmissionStateChangesFrom"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#transmissionStateChangesTo"></see>
    /// </summary>
    let transmissionStateChangesTo = _prefix "transmissionStateChangesTo"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#transmissionTo"></see>
    /// </summary>
    let transmissionTo = _prefix "transmissionTo"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#transmissionType"></see>
    /// </summary>
    let transmissionType = _prefix "transmissionType"
    /// <summary>
    ///   <see href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#urgency"></see>
    /// </summary>
    let urgency = _prefix "urgency"
