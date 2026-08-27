namespace http.www.semanticdesktop.org.ontologies._2008._05._20.tmo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tmo =
    let _namespace_iri = Namespace_Iri tmo |> NamespaceIRI
    /// <summary>
    ///   <para>tmo:AbilityCarrier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"AbilityCarrier is an abstract class which circumferences all entities which can take action or which are somehow involved in tasks.
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
    /// involved."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AbilityCarrier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#AbilityCarrier">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#AbilityCarrier</seealso>
    let AbilityCarrier = Prefixed_Name(tmo, "AbilityCarrier") |> PrefixedName

    /// <summary>
    ///   <para>tmo:AbilityCarrierInvolvement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class AbilityCarrier_Involvement ties together an AbilityCarrier with an AbilityCarrier_Role. This is a role based modelling approach. An n-ary relation is realized."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AbilityCarrierInvolvement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#AbilityCarrierInvolvement">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#AbilityCarrierInvolvement</seealso>
    let AbilityCarrierInvolvement =
        Prefixed_Name(tmo, "AbilityCarrierInvolvement") |> PrefixedName

    /// <summary>
    ///   <para>tmo:AbilityCarrierRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Examples instances  of AbilityCarrirRoles are e.g. "requested", "required" and "used" which further specify the type a person was involved in."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AbilityCarrierRole"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#AbilityCarrierRole">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#AbilityCarrierRole</seealso>
    let AbilityCarrierRole = Prefixed_Name(tmo, "AbilityCarrierRole") |> PrefixedName
    /// <summary>
    ///   <para>tmo:AgentAbilityCarrier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"AgentAbilityCarrier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#AgentAbilityCarrier">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#AgentAbilityCarrier</seealso>
    let AgentAbilityCarrier = Prefixed_Name(tmo, "AgentAbilityCarrier") |> PrefixedName

    /// <summary>
    ///   <para>tmo:AssociationDependency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"AssociationDependency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#AssociationDependency">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#AssociationDependency</seealso>
    let AssociationDependency =
        Prefixed_Name(tmo, "AssociationDependency") |> PrefixedName

    /// <summary>
    ///   <para>tmo:Attachment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"By means of attachments, references to other resources can be established. Resources are information objects. Every Thing, which can be referenced, on the SSD is an information object. In contrast to the usual SSD references/associations, here additionally information can be specified. Further metadata about the role an attachment plays can be stated by means of instances of AttachmentRole. It can be expressed what the Role of attachment is e.g., regarding "desired/requested" or "required" or "potentially useful / somehow related" or "used/produced/achieved". The reference property models the actual link to the attached piece of information."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Attachment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#Attachment">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#Attachment</seealso>
    let Attachment = Prefixed_Name(tmo, "Attachment") |> PrefixedName
    /// <summary>
    ///   <para>tmo:AttachmentRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"AttachmentRoles further specify the type of how an attachment relates to a task. Example instances  of AttachmentRoles are e.g. "desired_request", "required" and "used"."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AttachmentRole"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#AttachmentRole">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#AttachmentRole</seealso>
    let AttachmentRole = Prefixed_Name(tmo, "AttachmentRole") |> PrefixedName
    /// <summary>
    ///   <para>tmo:Delegability</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Delegability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#Delegability">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#Delegability</seealso>
    let Delegability = Prefixed_Name(tmo, "Delegability") |> PrefixedName
    /// <summary>
    ///   <para>tmo:Importance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Importance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#Importance">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#Importance</seealso>
    let Importance = Prefixed_Name(tmo, "Importance") |> PrefixedName
    /// <summary>
    ///   <para>tmo:Interdependence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Interdependence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#Interdependence">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#Interdependence</seealso>
    let Interdependence = Prefixed_Name(tmo, "Interdependence") |> PrefixedName
    /// <summary>
    ///   <para>tmo:PersonInvolvement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"PersonInvolvement  realizes n-ary associations to Persons which are realtedd to an task. The involvement is further characterized by an PersonTaskRole."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PersonInvolvement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#PersonInvolvement">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#PersonInvolvement</seealso>
    let PersonInvolvement = Prefixed_Name(tmo, "PersonInvolvement") |> PrefixedName

    /// <summary>
    ///   <para>tmo:PersonInvolvementRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"They further specify the type a person was related to an task.
    /// Examples instances  of AttachmentRoles are e.g."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PersonInvolvementRole"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#PersonInvolvementRole">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#PersonInvolvementRole</seealso>
    let PersonInvolvementRole =
        Prefixed_Name(tmo, "PersonInvolvementRole") |> PrefixedName

    /// <summary>
    ///   <para>tmo:PredecessorDependency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"In a  PredecessorDependency the dependencyMemberA is the task which is to be executed before dependencyMemberB."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PredecessorDependency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#PredecessorDependency">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#PredecessorDependency</seealso>
    let PredecessorDependency =
        Prefixed_Name(tmo, "PredecessorDependency") |> PrefixedName

    /// <summary>
    ///   <para>tmo:PredecessorSuccessorDependency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The PredecessorSuccessorDependency enables a directed relation between task. By means of the concrete sublcasses one can further distinguish from which point of view this relation is created."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PredecessorSuccessorDependency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#PredecessorSuccessorDependency">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#PredecessorSuccessorDependency</seealso>
    let PredecessorSuccessorDependency =
        Prefixed_Name(tmo, "PredecessorSuccessorDependency") |> PrefixedName

    /// <summary>
    ///   <para>tmo:Priority</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Priority"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#Priority">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#Priority</seealso>
    let Priority = Prefixed_Name(tmo, "Priority") |> PrefixedName
    /// <summary>
    ///   <para>tmo:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"examples: Architect, Developer, ..."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#Role">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#Role</seealso>
    let Role = Prefixed_Name(tmo, "Role") |> PrefixedName

    /// <summary>
    ///   <para>tmo:SimilarityDependence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"SimilarityDependence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#SimilarityDependence">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#SimilarityDependence</seealso>
    let SimilarityDependence =
        Prefixed_Name(tmo, "SimilarityDependence") |> PrefixedName

    /// <summary>
    ///   <para>tmo:Skill</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"examples are e.g. technologies like Java, XML,  ..."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Skill"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#Skill">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#Skill</seealso>
    let Skill = Prefixed_Name(tmo, "Skill") |> PrefixedName
    /// <summary>
    ///   <para>tmo:StateTypeRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"StateTypeRole is an abstract class which subsumes various other classes which represent "states" or roles e.g. in role based modelling conpetualisations."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"StateTypeRole"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#StateTypeRole">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#StateTypeRole</seealso>
    let StateTypeRole = Prefixed_Name(tmo, "StateTypeRole") |> PrefixedName
    /// <summary>
    ///   <para>tmo:SuccessorDependency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"In a SuccessorrDependency the dependencyMemberA is the task which is to be executed after dependencyMemberB."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SuccessorDependency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#SuccessorDependency">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#SuccessorDependency</seealso>
    let SuccessorDependency = Prefixed_Name(tmo, "SuccessorDependency") |> PrefixedName

    /// <summary>
    ///   <para>tmo:SuperSubTaskDependency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"By means of the SuperSubTaskDependency one can further describe the subtask-supertask relation .e.g by an descriptin. This enables an n-ary relation between subtask and supertask."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SuperSubTaskDependency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#SuperSubTaskDependency">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#SuperSubTaskDependency</seealso>
    let SuperSubTaskDependency =
        Prefixed_Name(tmo, "SuperSubTaskDependency") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_AbilityCarrierRole_Requested</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:AbilityCarrierRole</para>
    ///
    /// labels<para>"TMO_Instance_AbilityCarrierRole_Requested"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_AbilityCarrierRole_Requested">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_AbilityCarrierRole_Requested</seealso>
    let TMO_Instance_AbilityCarrierRole_Requested =
        Prefixed_Name(tmo, "TMO_Instance_AbilityCarrierRole_Requested") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_AbilityCarrierRole_Required</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:AbilityCarrierRole</para>
    ///
    /// labels<para>"TMO_Instance_AbilityCarrierRole_Required"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_AbilityCarrierRole_Required">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_AbilityCarrierRole_Required</seealso>
    let TMO_Instance_AbilityCarrierRole_Required =
        Prefixed_Name(tmo, "TMO_Instance_AbilityCarrierRole_Required") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_AbilityCarrierRole_Used</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:AbilityCarrierRole</para>
    ///
    /// labels<para>"TMO_Instance_AbilityCarrierRole_Used"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_AbilityCarrierRole_Used">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_AbilityCarrierRole_Used</seealso>
    let TMO_Instance_AbilityCarrierRole_Used =
        Prefixed_Name(tmo, "TMO_Instance_AbilityCarrierRole_Used") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_AttachmentRole_Desired_Requested</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:AttachmentRole</para>
    ///
    /// labels<para>"TMO_Instance_AttachmentRole_Desired_Requested"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_AttachmentRole_Desired_Requested">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_AttachmentRole_Desired_Requested</seealso>
    let TMO_Instance_AttachmentRole_Desired_Requested =
        Prefixed_Name(tmo, "TMO_Instance_AttachmentRole_Desired_Requested") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_AttachmentRole_Related</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:AttachmentRole</para>
    ///
    /// labels<para>"TMO_Instance_AttachmentRole_Related"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_AttachmentRole_Related">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_AttachmentRole_Related</seealso>
    let TMO_Instance_AttachmentRole_Related =
        Prefixed_Name(tmo, "TMO_Instance_AttachmentRole_Related") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_AttachmentRole_Required</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:AttachmentRole</para>
    ///
    /// labels<para>"TMO_Instance_AttachmentRole_Required"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_AttachmentRole_Required">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_AttachmentRole_Required</seealso>
    let TMO_Instance_AttachmentRole_Required =
        Prefixed_Name(tmo, "TMO_Instance_AttachmentRole_Required") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_AttachmentRole_Used</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:AttachmentRole</para>
    ///
    /// labels<para>"TMO_Instance_AttachmentRole_Used"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_AttachmentRole_Used">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_AttachmentRole_Used</seealso>
    let TMO_Instance_AttachmentRole_Used =
        Prefixed_Name(tmo, "TMO_Instance_AttachmentRole_Used") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_Delegability_High</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:Delegability</para>
    ///
    /// labels<para>"TMO_Instance_Delegability_High"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Delegability_High">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Delegability_High</seealso>
    let TMO_Instance_Delegability_High =
        Prefixed_Name(tmo, "TMO_Instance_Delegability_High") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_Delegability_Low</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:Delegability</para>
    ///
    /// labels<para>"TMO_Instance_Delegability_Low"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Delegability_Low">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Delegability_Low</seealso>
    let TMO_Instance_Delegability_Low =
        Prefixed_Name(tmo, "TMO_Instance_Delegability_Low") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_Delegability_Medium</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:Delegability</para>
    ///
    /// labels<para>"TMO_Instance_Delegability_Medium"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Delegability_Medium">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Delegability_Medium</seealso>
    let TMO_Instance_Delegability_Medium =
        Prefixed_Name(tmo, "TMO_Instance_Delegability_Medium") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_Delegability_Never</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:Delegability</para>
    ///
    /// labels<para>"TMO_Instance_Delegability_Never"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Delegability_Never">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Delegability_Never</seealso>
    let TMO_Instance_Delegability_Never =
        Prefixed_Name(tmo, "TMO_Instance_Delegability_Never") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_Delegability_Unrestricted</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:Delegability</para>
    ///
    /// labels<para>"TMO_Instance_Delegability_Unrestricted"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Delegability_Unrestricted">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Delegability_Unrestricted</seealso>
    let TMO_Instance_Delegability_Unrestricted =
        Prefixed_Name(tmo, "TMO_Instance_Delegability_Unrestricted") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_Importance_01</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:Importance</para>
    ///
    /// labels<para>"TMO_Instance_Importance_01"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_01">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_01</seealso>
    let TMO_Instance_Importance_01 =
        Prefixed_Name(tmo, "TMO_Instance_Importance_01") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_Importance_02</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:Importance</para>
    ///
    /// labels<para>"TMO_Instance_Importance_02"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_02">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_02</seealso>
    let TMO_Instance_Importance_02 =
        Prefixed_Name(tmo, "TMO_Instance_Importance_02") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_Importance_03</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:Importance</para>
    ///
    /// labels<para>"TMO_Instance_Importance_03"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_03">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_03</seealso>
    let TMO_Instance_Importance_03 =
        Prefixed_Name(tmo, "TMO_Instance_Importance_03") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_Importance_04</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:Importance</para>
    ///
    /// labels<para>"TMO_Instance_Importance_04"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_04">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_04</seealso>
    let TMO_Instance_Importance_04 =
        Prefixed_Name(tmo, "TMO_Instance_Importance_04") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_Importance_05</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:Importance</para>
    ///
    /// labels<para>"TMO_Instance_Importance_05"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_05">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_05</seealso>
    let TMO_Instance_Importance_05 =
        Prefixed_Name(tmo, "TMO_Instance_Importance_05") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_Importance_06</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:Importance</para>
    ///
    /// labels<para>"TMO_Instance_Importance_06"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_06">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_06</seealso>
    let TMO_Instance_Importance_06 =
        Prefixed_Name(tmo, "TMO_Instance_Importance_06") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_Importance_07</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:Importance</para>
    ///
    /// labels<para>"TMO_Instance_Importance_07"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_07">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_07</seealso>
    let TMO_Instance_Importance_07 =
        Prefixed_Name(tmo, "TMO_Instance_Importance_07") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_Importance_08</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:Importance</para>
    ///
    /// labels<para>"TMO_Instance_Importance_08"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_08">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_08</seealso>
    let TMO_Instance_Importance_08 =
        Prefixed_Name(tmo, "TMO_Instance_Importance_08") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_Importance_09</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:Importance</para>
    ///
    /// labels<para>"TMO_Instance_Importance_09"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_09">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_09</seealso>
    let TMO_Instance_Importance_09 =
        Prefixed_Name(tmo, "TMO_Instance_Importance_09") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_Importance_10</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:Importance</para>
    ///
    /// labels<para>"TMO_Instance_Importance_10"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_10">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Importance_10</seealso>
    let TMO_Instance_Importance_10 =
        Prefixed_Name(tmo, "TMO_Instance_Importance_10") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_PersonInvolvementRole_Analyst</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:PersonInvolvementRole</para>
    ///
    /// labels<para>"TMO_Instance_PersonInvolvementRole_Analyst"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Analyst">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Analyst</seealso>
    let TMO_Instance_PersonInvolvementRole_Analyst =
        Prefixed_Name(tmo, "TMO_Instance_PersonInvolvementRole_Analyst") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_PersonInvolvementRole_Co-worker</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:PersonInvolvementRole</para>
    ///
    /// labels<para>"TMO_Instance_PersonInvolvementRole_Co-worker"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Co-worker">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Co-worker</seealso>
    let TMO_Instance_PersonInvolvementRole_Co_worker =
        Prefixed_Name(tmo, "TMO_Instance_PersonInvolvementRole_Co-worker") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_PersonInvolvementRole_Collaborator</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:PersonInvolvementRole</para>
    ///
    /// labels<para>"TMO_Instance_PersonInvolvementRole_Collaborator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Collaborator">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Collaborator</seealso>
    let TMO_Instance_PersonInvolvementRole_Collaborator =
        Prefixed_Name(tmo, "TMO_Instance_PersonInvolvementRole_Collaborator") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_PersonInvolvementRole_Controller</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:PersonInvolvementRole</para>
    ///
    /// labels<para>"TMO_Instance_PersonInvolvementRole_Controller"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Controller">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Controller</seealso>
    let TMO_Instance_PersonInvolvementRole_Controller =
        Prefixed_Name(tmo, "TMO_Instance_PersonInvolvementRole_Controller") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_PersonInvolvementRole_Creator</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:PersonInvolvementRole</para>
    ///
    /// labels<para>"TMO_Instance_PersonInvolvementRole_Creator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Creator">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Creator</seealso>
    let TMO_Instance_PersonInvolvementRole_Creator =
        Prefixed_Name(tmo, "TMO_Instance_PersonInvolvementRole_Creator") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_PersonInvolvementRole_Delegate</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:PersonInvolvementRole</para>
    ///
    /// labels<para>"TMO_Instance_PersonInvolvementRole_Delegate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Delegate">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Delegate</seealso>
    let TMO_Instance_PersonInvolvementRole_Delegate =
        Prefixed_Name(tmo, "TMO_Instance_PersonInvolvementRole_Delegate") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_PersonInvolvementRole_Executor</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:PersonInvolvementRole</para>
    ///
    /// labels<para>"TMO_Instance_PersonInvolvementRole_Executor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Executor">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Executor</seealso>
    let TMO_Instance_PersonInvolvementRole_Executor =
        Prefixed_Name(tmo, "TMO_Instance_PersonInvolvementRole_Executor") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_PersonInvolvementRole_ExternalObserver</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:PersonInvolvementRole</para>
    ///
    /// labels<para>"TMO_Instance_PersonInvolvementRole_ExternalObserver"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_ExternalObserver">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_ExternalObserver</seealso>
    let TMO_Instance_PersonInvolvementRole_ExternalObserver =
        Prefixed_Name(tmo, "TMO_Instance_PersonInvolvementRole_ExternalObserver") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_PersonInvolvementRole_Initiator</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:PersonInvolvementRole</para>
    ///
    /// labels<para>"TMO_Instance_PersonInvolvementRole_Initiator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Initiator">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Initiator</seealso>
    let TMO_Instance_PersonInvolvementRole_Initiator =
        Prefixed_Name(tmo, "TMO_Instance_PersonInvolvementRole_Initiator") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_PersonInvolvementRole_InternalObserver</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:PersonInvolvementRole</para>
    ///
    /// labels<para>"TMO_Instance_PersonInvolvementRole_InternalObserver"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_InternalObserver">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_InternalObserver</seealso>
    let TMO_Instance_PersonInvolvementRole_InternalObserver =
        Prefixed_Name(tmo, "TMO_Instance_PersonInvolvementRole_InternalObserver") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_PersonInvolvementRole_Involved</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:PersonInvolvementRole</para>
    ///
    /// labels<para>"TMO_Instance_PersonInvolvementRole_Involved"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Involved">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Involved</seealso>
    let TMO_Instance_PersonInvolvementRole_Involved =
        Prefixed_Name(tmo, "TMO_Instance_PersonInvolvementRole_Involved") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_PersonInvolvementRole_Observer</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:PersonInvolvementRole</para>
    ///
    /// labels<para>"TMO_Instance_PersonInvolvementRole_Observer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Observer">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Observer</seealso>
    let TMO_Instance_PersonInvolvementRole_Observer =
        Prefixed_Name(tmo, "TMO_Instance_PersonInvolvementRole_Observer") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_PersonInvolvementRole_Owner</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:PersonInvolvementRole</para>
    ///
    /// labels<para>"TMO_Instance_PersonInvolvementRole_Owner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Owner">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Owner</seealso>
    let TMO_Instance_PersonInvolvementRole_Owner =
        Prefixed_Name(tmo, "TMO_Instance_PersonInvolvementRole_Owner") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_PersonInvolvementRole_Receiver</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:PersonInvolvementRole</para>
    ///
    /// labels<para>"TMO_Instance_PersonInvolvementRole_Receiver"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Receiver">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Receiver</seealso>
    let TMO_Instance_PersonInvolvementRole_Receiver =
        Prefixed_Name(tmo, "TMO_Instance_PersonInvolvementRole_Receiver") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_PersonInvolvementRole_Related</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:PersonInvolvementRole</para>
    ///
    /// labels<para>"TMO_Instance_PersonInvolvementRole_Related"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Related">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Related</seealso>
    let TMO_Instance_PersonInvolvementRole_Related =
        Prefixed_Name(tmo, "TMO_Instance_PersonInvolvementRole_Related") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_PersonInvolvementRole_Reviewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:PersonInvolvementRole</para>
    ///
    /// labels<para>"TMO_Instance_PersonInvolvementRole_Reviewer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Reviewer">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Reviewer</seealso>
    let TMO_Instance_PersonInvolvementRole_Reviewer =
        Prefixed_Name(tmo, "TMO_Instance_PersonInvolvementRole_Reviewer") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_PersonInvolvementRole_Suggested</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:PersonInvolvementRole</para>
    ///
    /// labels<para>"TMO_Instance_PersonInvolvementRole_Suggested"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Suggested">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_PersonInvolvementRole_Suggested</seealso>
    let TMO_Instance_PersonInvolvementRole_Suggested =
        Prefixed_Name(tmo, "TMO_Instance_PersonInvolvementRole_Suggested") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_Priority_High</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:Priority</para>
    ///
    /// labels<para>"TMO_Instance_Priority_High"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Priority_High">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Priority_High</seealso>
    let TMO_Instance_Priority_High =
        Prefixed_Name(tmo, "TMO_Instance_Priority_High") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_Priority_Low</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:Priority</para>
    ///
    /// labels<para>"TMO_Instance_Priority_Low"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Priority_Low">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Priority_Low</seealso>
    let TMO_Instance_Priority_Low =
        Prefixed_Name(tmo, "TMO_Instance_Priority_Low") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_Priority_Medium</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:Priority</para>
    ///
    /// labels<para>"TMO_Instance_Priority_Medium"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Priority_Medium">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Priority_Medium</seealso>
    let TMO_Instance_Priority_Medium =
        Prefixed_Name(tmo, "TMO_Instance_Priority_Medium") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_TaskContainer_activetasks</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:TaskContainer</para>
    ///
    /// labels<para>"TMO_Instance_TaskContainer_activetasks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskContainer_activetasks">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskContainer_activetasks</seealso>
    let TMO_Instance_TaskContainer_activetasks =
        Prefixed_Name(tmo, "TMO_Instance_TaskContainer_activetasks") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_TaskContainer_archive</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:TaskContainer</para>
    ///
    /// labels<para>"TMO_Instance_TaskContainer_archive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskContainer_archive">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskContainer_archive</seealso>
    let TMO_Instance_TaskContainer_archive =
        Prefixed_Name(tmo, "TMO_Instance_TaskContainer_archive") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_TaskContainer_inbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:TaskContainer</para>
    ///
    /// labels<para>"TMO_Instance_TaskContainer_inbox"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskContainer_inbox">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskContainer_inbox</seealso>
    let TMO_Instance_TaskContainer_inbox =
        Prefixed_Name(tmo, "TMO_Instance_TaskContainer_inbox") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_TaskContainer_outbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:TaskContainer</para>
    ///
    /// labels<para>"TMO_Instance_TaskContainer_outbox"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskContainer_outbox">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskContainer_outbox</seealso>
    let TMO_Instance_TaskContainer_outbox =
        Prefixed_Name(tmo, "TMO_Instance_TaskContainer_outbox") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_TaskContainer_trashtasks</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:TaskContainer</para>
    ///
    /// labels<para>"TMO_Instance_TaskContainer_trashtasks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskContainer_trashtasks">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskContainer_trashtasks</seealso>
    let TMO_Instance_TaskContainer_trashtasks =
        Prefixed_Name(tmo, "TMO_Instance_TaskContainer_trashtasks") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_TaskPrivacy_Private</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:TaskPrivacyState</para>
    ///
    /// labels<para>"TMO_Instance_TaskPrivacy_Private"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskPrivacy_Private">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskPrivacy_Private</seealso>
    let TMO_Instance_TaskPrivacy_Private =
        Prefixed_Name(tmo, "TMO_Instance_TaskPrivacy_Private") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_TaskPrivacy_Professional</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:TaskPrivacyState</para>
    ///
    /// labels<para>"TMO_Instance_TaskPrivacy_Professional"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskPrivacy_Professional">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskPrivacy_Professional</seealso>
    let TMO_Instance_TaskPrivacy_Professional =
        Prefixed_Name(tmo, "TMO_Instance_TaskPrivacy_Professional") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_TaskState_Archived</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:TaskState</para>
    ///
    /// labels<para>"TMO_Instance_TaskState_Archived"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskState_Archived">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskState_Archived</seealso>
    let TMO_Instance_TaskState_Archived =
        Prefixed_Name(tmo, "TMO_Instance_TaskState_Archived") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_TaskState_Completed</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:TaskState</para>
    ///
    /// labels<para>"TMO_Instance_TaskState_Completed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskState_Completed">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskState_Completed</seealso>
    let TMO_Instance_TaskState_Completed =
        Prefixed_Name(tmo, "TMO_Instance_TaskState_Completed") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_TaskState_Deleted</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:TaskState</para>
    ///
    /// labels<para>"TMO_Instance_TaskState_Deleted"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskState_Deleted">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskState_Deleted</seealso>
    let TMO_Instance_TaskState_Deleted =
        Prefixed_Name(tmo, "TMO_Instance_TaskState_Deleted") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_TaskState_Finalized</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:TaskState</para>
    ///
    /// labels<para>"TMO_Instance_TaskState_Finalized"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskState_Finalized">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskState_Finalized</seealso>
    let TMO_Instance_TaskState_Finalized =
        Prefixed_Name(tmo, "TMO_Instance_TaskState_Finalized") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_TaskState_New</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:TaskState</para>
    ///
    /// labels<para>"TMO_Instance_TaskState_New"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskState_New">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskState_New</seealso>
    let TMO_Instance_TaskState_New =
        Prefixed_Name(tmo, "TMO_Instance_TaskState_New") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_TaskState_Running</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:TaskState</para>
    ///
    /// labels<para>"TMO_Instance_TaskState_Running"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskState_Running">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskState_Running</seealso>
    let TMO_Instance_TaskState_Running =
        Prefixed_Name(tmo, "TMO_Instance_TaskState_Running") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_TaskState_Suspended</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:TaskState</para>
    ///
    /// labels<para>"TMO_Instance_TaskState_Suspended"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskState_Suspended">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskState_Suspended</seealso>
    let TMO_Instance_TaskState_Suspended =
        Prefixed_Name(tmo, "TMO_Instance_TaskState_Suspended") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_TaskState_Terminated</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:TaskState</para>
    ///
    /// labels<para>"TMO_Instance_TaskState_Terminated"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskState_Terminated">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TaskState_Terminated</seealso>
    let TMO_Instance_TaskState_Terminated =
        Prefixed_Name(tmo, "TMO_Instance_TaskState_Terminated") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_TransmissionState_Accepted_NotTransmitted</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:TransmissionState</para>
    ///
    /// labels<para>"TMO_Instance_TransmissionState_Accepted_NotTransmitted"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TransmissionState_Accepted_NotTransmitted">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TransmissionState_Accepted_NotTransmitted</seealso>
    let TMO_Instance_TransmissionState_Accepted_NotTransmitted =
        Prefixed_Name(tmo, "TMO_Instance_TransmissionState_Accepted_NotTransmitted") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_TransmissionState_Accepted_Transmitted</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:TransmissionState</para>
    ///
    /// labels<para>"TMO_Instance_TransmissionState_Accepted_Transmitted"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TransmissionState_Accepted_Transmitted">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TransmissionState_Accepted_Transmitted</seealso>
    let TMO_Instance_TransmissionState_Accepted_Transmitted =
        Prefixed_Name(tmo, "TMO_Instance_TransmissionState_Accepted_Transmitted") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_TransmissionState_NotTransmitted</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:TransmissionState</para>
    ///
    /// labels<para>"TMO_Instance_TransmissionState_NotTransmitted"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TransmissionState_NotTransmitted">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TransmissionState_NotTransmitted</seealso>
    let TMO_Instance_TransmissionState_NotTransmitted =
        Prefixed_Name(tmo, "TMO_Instance_TransmissionState_NotTransmitted") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_TransmissionState_Rejected_NotTransmitted</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:TransmissionState</para>
    ///
    /// labels<para>"TMO_Instance_TransmissionState_Rejected_NotTransmitted"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TransmissionState_Rejected_NotTransmitted">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TransmissionState_Rejected_NotTransmitted</seealso>
    let TMO_Instance_TransmissionState_Rejected_NotTransmitted =
        Prefixed_Name(tmo, "TMO_Instance_TransmissionState_Rejected_NotTransmitted") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_TransmissionState_Rejected_Transmitted</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:TransmissionState</para>
    ///
    /// labels<para>"TMO_Instance_TransmissionState_Rejected_Transmitted"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TransmissionState_Rejected_Transmitted">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TransmissionState_Rejected_Transmitted</seealso>
    let TMO_Instance_TransmissionState_Rejected_Transmitted =
        Prefixed_Name(tmo, "TMO_Instance_TransmissionState_Rejected_Transmitted") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_TransmissionState_Transmitted</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:TransmissionState</para>
    ///
    /// labels<para>"TMO_Instance_TransmissionState_Transmitted"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TransmissionState_Transmitted">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TransmissionState_Transmitted</seealso>
    let TMO_Instance_TransmissionState_Transmitted =
        Prefixed_Name(tmo, "TMO_Instance_TransmissionState_Transmitted") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_TransmissionType_Delegation</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:TransmissionType</para>
    ///
    /// labels<para>"TMO_Instance_TransmissionType_Delegation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TransmissionType_Delegation">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TransmissionType_Delegation</seealso>
    let TMO_Instance_TransmissionType_Delegation =
        Prefixed_Name(tmo, "TMO_Instance_TransmissionType_Delegation") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_TransmissionType_Join</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:TransmissionType</para>
    ///
    /// labels<para>"TMO_Instance_TransmissionType_Join"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TransmissionType_Join">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TransmissionType_Join</seealso>
    let TMO_Instance_TransmissionType_Join =
        Prefixed_Name(tmo, "TMO_Instance_TransmissionType_Join") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_TransmissionType_Transfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:TransmissionType</para>
    ///
    /// labels<para>"TMO_Instance_TransmissionType_Transfer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TransmissionType_Transfer">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_TransmissionType_Transfer</seealso>
    let TMO_Instance_TransmissionType_Transfer =
        Prefixed_Name(tmo, "TMO_Instance_TransmissionType_Transfer") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_Urgency_01</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:Urgency</para>
    ///
    /// labels<para>"TMO_Instance_Urgency_01"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_01">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_01</seealso>
    let TMO_Instance_Urgency_01 =
        Prefixed_Name(tmo, "TMO_Instance_Urgency_01") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_Urgency_02</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:Urgency</para>
    ///
    /// labels<para>"TMO_Instance_Urgency_02"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_02">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_02</seealso>
    let TMO_Instance_Urgency_02 =
        Prefixed_Name(tmo, "TMO_Instance_Urgency_02") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_Urgency_03</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:Urgency</para>
    ///
    /// labels<para>"TMO_Instance_Urgency_03"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_03">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_03</seealso>
    let TMO_Instance_Urgency_03 =
        Prefixed_Name(tmo, "TMO_Instance_Urgency_03") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_Urgency_04</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:Urgency</para>
    ///
    /// labels<para>"TMO_Instance_Urgency_04"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_04">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_04</seealso>
    let TMO_Instance_Urgency_04 =
        Prefixed_Name(tmo, "TMO_Instance_Urgency_04") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_Urgency_05</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:Urgency</para>
    ///
    /// labels<para>"TMO_Instance_Urgency_05"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_05">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_05</seealso>
    let TMO_Instance_Urgency_05 =
        Prefixed_Name(tmo, "TMO_Instance_Urgency_05") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_Urgency_06</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:Urgency</para>
    ///
    /// labels<para>"TMO_Instance_Urgency_06"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_06">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_06</seealso>
    let TMO_Instance_Urgency_06 =
        Prefixed_Name(tmo, "TMO_Instance_Urgency_06") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_Urgency_07</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:Urgency</para>
    ///
    /// labels<para>"TMO_Instance_Urgency_07"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_07">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_07</seealso>
    let TMO_Instance_Urgency_07 =
        Prefixed_Name(tmo, "TMO_Instance_Urgency_07") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_Urgency_08</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:Urgency</para>
    ///
    /// labels<para>"TMO_Instance_Urgency_08"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_08">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_08</seealso>
    let TMO_Instance_Urgency_08 =
        Prefixed_Name(tmo, "TMO_Instance_Urgency_08") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_Urgency_09</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:Urgency</para>
    ///
    /// labels<para>"TMO_Instance_Urgency_09"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_09">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_09</seealso>
    let TMO_Instance_Urgency_09 =
        Prefixed_Name(tmo, "TMO_Instance_Urgency_09") |> PrefixedName

    /// <summary>
    ///   <para>tmo:TMO_Instance_Urgency_10</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmo:Urgency</para>
    ///
    /// labels<para>"TMO_Instance_Urgency_10"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_10">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TMO_Instance_Urgency_10</seealso>
    let TMO_Instance_Urgency_10 =
        Prefixed_Name(tmo, "TMO_Instance_Urgency_10") |> PrefixedName

    /// <summary>
    ///   <para>tmo:Task</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The tmo:task is the central entitiey of the tmo. Task can range from vague things to be possibly done in e distant future to concrete things to be done in a precise forseeable manner. It is not unrealisitc to assume that knowledge worker have hundred or more tasks a day."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Task"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#Task">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#Task</seealso>
    let Task = Prefixed_Name(tmo, "Task") |> PrefixedName
    /// <summary>
    ///   <para>tmo:TaskContainer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"TaskContainer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TaskContainer">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TaskContainer</seealso>
    let TaskContainer = Prefixed_Name(tmo, "TaskContainer") |> PrefixedName
    /// <summary>
    ///   <para>tmo:TaskDependency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Between the tasks, further dependencies may exist. These dependencies allow for a graph network structure. For ease of use, dependencies should not be too frequent, otherwise the primarily character of a hierarchy would be diminished and a consequent graph representation would become considerable. However, such a graph representation has other drawbacks, the user is likely to loose oversight, tree structures are more helpful in structuring the work.
    ///
    /// A dependency relation is characterized by the type of the relation and by an additional description. There are different possibilities for dependency relations between tasks."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TaskDependency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TaskDependency">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TaskDependency</seealso>
    let TaskDependency = Prefixed_Name(tmo, "TaskDependency") |> PrefixedName
    /// <summary>
    ///   <para>tmo:TaskPrivacyState</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Privacy Status serves for the separation between a professional and a private purpose of a task. This attribute provides with the values "professional/private" a high-level separation of privacy in terms of setting distribution and access
    /// rights to other users for the task.
    /// This separation may arise as a general Nepomuk issue and may therefore be handled in conjunction with a privacy preserving SSD architecture."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TaskPrivacyState"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TaskPrivacyState">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TaskPrivacyState</seealso>
    let TaskPrivacyState = Prefixed_Name(tmo, "TaskPrivacyState") |> PrefixedName
    /// <summary>
    ///   <para>tmo:TaskState</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The task state property allows tracking a task during its lifecycle. Initially the state is just "created".
    /// The TaskState class was modeled so that for each state can be set which the typical prior and posterior states are. This has the advantage that e.g. a UI can retrieve the allowed states at runtime from the ontology; rather can having this potentially changing knowledge hard coded. But the prior and posterior states are only defaults; the human user is always free to change the state."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TaskState"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TaskState">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TaskState</seealso>
    let TaskState = Prefixed_Name(tmo, "TaskState") |> PrefixedName
    /// <summary>
    ///   <para>tmo:TaskTransmission</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"On the SSD, tasks are not restricted to one person and may cross from
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
    /// information is transferred in the "task space" of the participating persons."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TaskTransmission"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TaskTransmission">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TaskTransmission</seealso>
    let TaskTransmission = Prefixed_Name(tmo, "TaskTransmission") |> PrefixedName
    /// <summary>
    ///   <para>tmo:TransmissionState</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"States a task can go through during transmission of an task."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TransmissionState"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TransmissionState">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TransmissionState</seealso>
    let TransmissionState = Prefixed_Name(tmo, "TransmissionState") |> PrefixedName
    /// <summary>
    ///   <para>tmo:TransmissionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"By means of the TransmissionType one can distinguish several different types which might imply a different business logic. e.g. delegation can mean that the results of the task fulfillment care to be reported back to the sender of the task."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TransmissionType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TransmissionType">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#TransmissionType</seealso>
    let TransmissionType = Prefixed_Name(tmo, "TransmissionType") |> PrefixedName

    /// <summary>
    ///   <para>tmo:UndirectedDependency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A symmetric relations between task."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"UndirectedDependency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#UndirectedDependency">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#UndirectedDependency</seealso>
    let UndirectedDependency =
        Prefixed_Name(tmo, "UndirectedDependency") |> PrefixedName

    /// <summary>
    ///   <para>tmo:Urgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Urgency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#Urgency">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#Urgency</seealso>
    let Urgency = Prefixed_Name(tmo, "Urgency") |> PrefixedName
    /// <summary>
    ///   <para>tmo:abilityCarrier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"abilityCarrier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#abilityCarrier">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#abilityCarrier</seealso>
    let abilityCarrier = Prefixed_Name(tmo, "abilityCarrier") |> PrefixedName

    /// <summary>
    ///   <para>tmo:abilityCarrierInvolvement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"abilityCarrierInvolvement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#abilityCarrierInvolvement">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#abilityCarrierInvolvement</seealso>
    let abilityCarrierInvolvement =
        Prefixed_Name(tmo, "abilityCarrierInvolvement") |> PrefixedName

    /// <summary>
    ///   <para>tmo:abilityCarrierRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"abilityCarrierRole"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#abilityCarrierRole">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#abilityCarrierRole</seealso>
    let abilityCarrierRole = Prefixed_Name(tmo, "abilityCarrierRole") |> PrefixedName
    /// <summary>
    ///   <para>tmo:abilityCarrierTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"abilityCarrierTask"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#abilityCarrierTask">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#abilityCarrierTask</seealso>
    let abilityCarrierTask = Prefixed_Name(tmo, "abilityCarrierTask") |> PrefixedName
    /// <summary>
    ///   <para>tmo:actualCompletion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"actualCompletion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#actualCompletion">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#actualCompletion</seealso>
    let actualCompletion = Prefixed_Name(tmo, "actualCompletion") |> PrefixedName
    /// <summary>
    ///   <para>tmo:actualEndTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"actualEndTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#actualEndTime">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#actualEndTime</seealso>
    let actualEndTime = Prefixed_Name(tmo, "actualEndTime") |> PrefixedName
    /// <summary>
    ///   <para>tmo:actualStartTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"actualStartTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#actualStartTime">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#actualStartTime</seealso>
    let actualStartTime = Prefixed_Name(tmo, "actualStartTime") |> PrefixedName
    /// <summary>
    ///   <para>tmo:actualTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"actualTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#actualTime">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#actualTime</seealso>
    let actualTime = Prefixed_Name(tmo, "actualTime") |> PrefixedName
    /// <summary>
    ///   <para>tmo:attachment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"connects a Task with an Attachment object. Attachments are associations of Things."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"attachment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#attachment">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#attachment</seealso>
    let attachment = Prefixed_Name(tmo, "attachment") |> PrefixedName
    /// <summary>
    ///   <para>tmo:attachmentReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"attachmentReference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#attachmentReference">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#attachmentReference</seealso>
    let attachmentReference = Prefixed_Name(tmo, "attachmentReference") |> PrefixedName
    /// <summary>
    ///   <para>tmo:attachmentRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"attachmentRole"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#attachmentRole">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#attachmentRole</seealso>
    let attachmentRole = Prefixed_Name(tmo, "attachmentRole") |> PrefixedName
    /// <summary>
    ///   <para>tmo:attachmentTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Inverse of attachment, connects an Attachment Association to the associated Task. Is required for every instance of Attachment."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"attachmentTask"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#attachmentTask">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#attachmentTask</seealso>
    let attachmentTask = Prefixed_Name(tmo, "attachmentTask") |> PrefixedName
    /// <summary>
    ///   <para>tmo:containsTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"containsTask"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#containsTask">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#containsTask</seealso>
    let containsTask = Prefixed_Name(tmo, "containsTask") |> PrefixedName
    /// <summary>
    ///   <para>tmo:contextTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"contextTask"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#contextTask">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#contextTask</seealso>
    let contextTask = Prefixed_Name(tmo, "contextTask") |> PrefixedName
    /// <summary>
    ///   <para>tmo:contextThread</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"contextThread"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#contextThread">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#contextThread</seealso>
    let contextThread = Prefixed_Name(tmo, "contextThread") |> PrefixedName
    /// <summary>
    ///   <para>tmo:createdBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"createdBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#createdBy">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#createdBy</seealso>
    let createdBy = Prefixed_Name(tmo, "createdBy") |> PrefixedName
    /// <summary>
    ///   <para>tmo:dateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"dateTime subsumes various properties with Range XMLSchema:dateTime. If possible they are further grouped by "abstract" properties."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"dateTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#dateTime">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#dateTime</seealso>
    let dateTime = Prefixed_Name(tmo, "dateTime") |> PrefixedName
    /// <summary>
    ///   <para>tmo:delegability</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"delegability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#delegability">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#delegability</seealso>
    let delegability = Prefixed_Name(tmo, "delegability") |> PrefixedName
    /// <summary>
    ///   <para>tmo:dependency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"dependency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#dependency">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#dependency</seealso>
    let dependency = Prefixed_Name(tmo, "dependency") |> PrefixedName

    /// <summary>
    ///   <para>tmo:dependencyDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Endusers can clarify why they created a depedency."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"dependencyDescription"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#dependencyDescription">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#dependencyDescription</seealso>
    let dependencyDescription =
        Prefixed_Name(tmo, "dependencyDescription") |> PrefixedName

    /// <summary>
    ///   <para>tmo:dependencyMemberA</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The semantic of this relation is defined in the sublclass of undirected Dependency on which this property is stated. (The subject of the statment where this property is expressed)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"dependencyMemberA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#dependencyMemberA">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#dependencyMemberA</seealso>
    let dependencyMemberA = Prefixed_Name(tmo, "dependencyMemberA") |> PrefixedName
    /// <summary>
    ///   <para>tmo:dependencyMemberB</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The semantic of this relation is defined in the sublclass of undirected Dependency on which this property is stated. (The subject of the statment where this property is expressed)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"dependencyMemberB"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#dependencyMemberB">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#dependencyMemberB</seealso>
    let dependencyMemberB = Prefixed_Name(tmo, "dependencyMemberB") |> PrefixedName

    /// <summary>
    ///   <para>tmo:dependencyOrderNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"dependencyOrderNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#dependencyOrderNumber">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#dependencyOrderNumber</seealso>
    let dependencyOrderNumber =
        Prefixed_Name(tmo, "dependencyOrderNumber") |> PrefixedName

    /// <summary>
    ///   <para>tmo:dependencyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"dependencyType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#dependencyType">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#dependencyType</seealso>
    let dependencyType = Prefixed_Name(tmo, "dependencyType") |> PrefixedName
    /// <summary>
    ///   <para>tmo:dueDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"dueDate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#dueDate">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#dueDate</seealso>
    let dueDate = Prefixed_Name(tmo, "dueDate") |> PrefixedName
    /// <summary>
    ///   <para>tmo:endTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"endTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#endTime">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#endTime</seealso>
    let endTime = Prefixed_Name(tmo, "endTime") |> PrefixedName
    /// <summary>
    ///   <para>tmo:importance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"importance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#importance">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#importance</seealso>
    let importance = Prefixed_Name(tmo, "importance") |> PrefixedName
    /// <summary>
    ///   <para>tmo:indexPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"indexPosition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#indexPosition">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#indexPosition</seealso>
    let indexPosition = Prefixed_Name(tmo, "indexPosition") |> PrefixedName
    /// <summary>
    ///   <para>tmo:involvedPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"involvedPerson"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#involvedPerson">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#involvedPerson</seealso>
    let involvedPerson = Prefixed_Name(tmo, "involvedPerson") |> PrefixedName
    /// <summary>
    ///   <para>tmo:involvedPersonRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"involvedPersonRole"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#involvedPersonRole">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#involvedPersonRole</seealso>
    let involvedPersonRole = Prefixed_Name(tmo, "involvedPersonRole") |> PrefixedName
    /// <summary>
    ///   <para>tmo:involvedPersonTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"involvedPersonTask"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#involvedPersonTask">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#involvedPersonTask</seealso>
    let involvedPersonTask = Prefixed_Name(tmo, "involvedPersonTask") |> PrefixedName
    /// <summary>
    ///   <para>tmo:involvedPersons</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"involvedPersons"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#involvedPersons">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#involvedPersons</seealso>
    let involvedPersons = Prefixed_Name(tmo, "involvedPersons") |> PrefixedName
    /// <summary>
    ///   <para>tmo:lastReviewDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"lastReviewDate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#lastReviewDate">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#lastReviewDate</seealso>
    let lastReviewDate = Prefixed_Name(tmo, "lastReviewDate") |> PrefixedName
    /// <summary>
    ///   <para>tmo:logEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"logEntry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#logEntry">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#logEntry</seealso>
    let logEntry = Prefixed_Name(tmo, "logEntry") |> PrefixedName
    /// <summary>
    ///   <para>tmo:nextReviewIntervall</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"nextReviewIntervall"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#nextReviewIntervall">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#nextReviewIntervall</seealso>
    let nextReviewIntervall = Prefixed_Name(tmo, "nextReviewIntervall") |> PrefixedName
    /// <summary>
    ///   <para>tmo:priority</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"priority"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#priority">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#priority</seealso>
    let priority = Prefixed_Name(tmo, "priority") |> PrefixedName
    /// <summary>
    ///   <para>tmo:progress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"progress"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#progress">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#progress</seealso>
    let progress = Prefixed_Name(tmo, "progress") |> PrefixedName
    /// <summary>
    ///   <para>tmo:receiveDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"receiveDateTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#receiveDateTime">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#receiveDateTime</seealso>
    let receiveDateTime = Prefixed_Name(tmo, "receiveDateTime") |> PrefixedName
    /// <summary>
    ///   <para>tmo:sendDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"sendDateTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#sendDateTime">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#sendDateTime</seealso>
    let sendDateTime = Prefixed_Name(tmo, "sendDateTime") |> PrefixedName
    /// <summary>
    ///   <para>tmo:startTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"startTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#startTime">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#startTime</seealso>
    let startTime = Prefixed_Name(tmo, "startTime") |> PrefixedName
    /// <summary>
    ///   <para>tmo:stateTypeRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"stateTypeRole"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#stateTypeRole">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#stateTypeRole</seealso>
    let stateTypeRole = Prefixed_Name(tmo, "stateTypeRole") |> PrefixedName
    /// <summary>
    ///   <para>tmo:subTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"subTask"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#subTask">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#subTask</seealso>
    let subTask = Prefixed_Name(tmo, "subTask") |> PrefixedName
    /// <summary>
    ///   <para>tmo:subTaskOrdering</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Ordering of the subtasks listed in the tmo:subTasks property of this Task. This is only for ordering/sorting in GUIs, the semantic relation is defined in subTasks, and if this and subTasks differ, subTasks is the correct list."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"subTaskOrdering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#subTaskOrdering">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#subTaskOrdering</seealso>
    let subTaskOrdering = Prefixed_Name(tmo, "subTaskOrdering") |> PrefixedName
    /// <summary>
    ///   <para>tmo:superTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"superTask"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#superTask">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#superTask</seealso>
    let superTask = Prefixed_Name(tmo, "superTask") |> PrefixedName
    /// <summary>
    ///   <para>tmo:targetCompletion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"targetCompletion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#targetCompletion">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#targetCompletion</seealso>
    let targetCompletion = Prefixed_Name(tmo, "targetCompletion") |> PrefixedName
    /// <summary>
    ///   <para>tmo:targetEndTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"targetEndTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#targetEndTime">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#targetEndTime</seealso>
    let targetEndTime = Prefixed_Name(tmo, "targetEndTime") |> PrefixedName
    /// <summary>
    ///   <para>tmo:targetStartTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"targetStartTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#targetStartTime">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#targetStartTime</seealso>
    let targetStartTime = Prefixed_Name(tmo, "targetStartTime") |> PrefixedName
    /// <summary>
    ///   <para>tmo:targetTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"targetTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#targetTime">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#targetTime</seealso>
    let targetTime = Prefixed_Name(tmo, "targetTime") |> PrefixedName
    /// <summary>
    ///   <para>tmo:taskDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The task description helps users to understand the goal and the proceeding of a task. It can also describe the context of a task. The task description is composed at minimum of a summary of what is done to reach the goal. The task description is the main source for identifying related information, e.g., suitable patterns.
    /// A Task Description can be either an informal, described textual content (TextualDescription) or it can be a more formally structured representation (FormalDescription).
    /// Technology considerations: Informal descriptions allow for text similarity processing, a formal description allows for applying case based similarity measures."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"taskDescription"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskDescription">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskDescription</seealso>
    let taskDescription = Prefixed_Name(tmo, "taskDescription") |> PrefixedName
    /// <summary>
    ///   <para>tmo:taskGoal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"taskGoal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskGoal">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskGoal</seealso>
    let taskGoal = Prefixed_Name(tmo, "taskGoal") |> PrefixedName
    /// <summary>
    ///   <para>tmo:taskId</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The Task Identifier allows a unique identification of a task object within the range of all Nepomuk objects.
    /// The Task Identifier is automatically generated during the creation of a task. The generation of identifiers (IDs) is a Nepomuk architecture issue (Wp2000/WP6000)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"taskId"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskId">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskId</seealso>
    let taskId = Prefixed_Name(tmo, "taskId") |> PrefixedName
    /// <summary>
    ///   <para>tmo:taskName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The Task Name helps the user to identify a task in a list. It should be expressive enough to give a meaningful recognition. Details should be written in the description attribute instead. A name attribute is not allowed to contain line breaks."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"taskName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskName">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskName</seealso>
    let taskName = Prefixed_Name(tmo, "taskName") |> PrefixedName
    /// <summary>
    ///   <para>tmo:taskPrivacyState</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"For the separation between professional and private purpose of a task, this attribute provides with the values "professional/private" a high level separation of privacy in terms of setting distribution rights to other users for the task.
    /// This separation may arise as a general Nepomuk issue and may therefore be handled in conjunction with a privacy preserving SSD architecture."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"taskPrivacyState"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskPrivacyState">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskPrivacyState</seealso>
    let taskPrivacyState = Prefixed_Name(tmo, "taskPrivacyState") |> PrefixedName
    /// <summary>
    ///   <para>tmo:taskReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"taskReference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskReference">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskReference</seealso>
    let taskReference = Prefixed_Name(tmo, "taskReference") |> PrefixedName
    /// <summary>
    ///   <para>tmo:taskSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"here can be stated from which sources a task was derived. e.g from another task or from an task pattern"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"taskSource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskSource">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskSource</seealso>
    let taskSource = Prefixed_Name(tmo, "taskSource") |> PrefixedName
    /// <summary>
    ///   <para>tmo:taskState</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The task state describes the current state of the task as described in Section 5.2.7."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"taskState"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskState">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskState</seealso>
    let taskState = Prefixed_Name(tmo, "taskState") |> PrefixedName

    /// <summary>
    ///   <para>tmo:taskStateChangesFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"taskStateChangesFrom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskStateChangesFrom">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskStateChangesFrom</seealso>
    let taskStateChangesFrom =
        Prefixed_Name(tmo, "taskStateChangesFrom") |> PrefixedName

    /// <summary>
    ///   <para>tmo:taskStateChangesTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"taskStateChangesTo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskStateChangesTo">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskStateChangesTo</seealso>
    let taskStateChangesTo = Prefixed_Name(tmo, "taskStateChangesTo") |> PrefixedName
    /// <summary>
    ///   <para>tmo:taskTransmission</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"taskTransmission"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskTransmission">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#taskTransmission</seealso>
    let taskTransmission = Prefixed_Name(tmo, "taskTransmission") |> PrefixedName
    /// <summary>
    ///   <para>tmo:timemanagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"timemanagement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#timemanagement">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#timemanagement</seealso>
    let timemanagement = Prefixed_Name(tmo, "timemanagement") |> PrefixedName
    /// <summary>
    ///   <para>tmo:transmissionFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"transmissionFrom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#transmissionFrom">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#transmissionFrom</seealso>
    let transmissionFrom = Prefixed_Name(tmo, "transmissionFrom") |> PrefixedName
    /// <summary>
    ///   <para>tmo:transmissionState</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"transmissionState"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#transmissionState">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#transmissionState</seealso>
    let transmissionState = Prefixed_Name(tmo, "transmissionState") |> PrefixedName

    /// <summary>
    ///   <para>tmo:transmissionStateChangesFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"transmissionStateChangesFrom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#transmissionStateChangesFrom">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#transmissionStateChangesFrom</seealso>
    let transmissionStateChangesFrom =
        Prefixed_Name(tmo, "transmissionStateChangesFrom") |> PrefixedName

    /// <summary>
    ///   <para>tmo:transmissionStateChangesTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"transmissionStateChangesTo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#transmissionStateChangesTo">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#transmissionStateChangesTo</seealso>
    let transmissionStateChangesTo =
        Prefixed_Name(tmo, "transmissionStateChangesTo") |> PrefixedName

    /// <summary>
    ///   <para>tmo:transmissionTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"transmissionTask"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#transmissionTask">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#transmissionTask</seealso>
    let transmissionTask = Prefixed_Name(tmo, "transmissionTask") |> PrefixedName
    /// <summary>
    ///   <para>tmo:transmissionTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"transmissionTo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#transmissionTo">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#transmissionTo</seealso>
    let transmissionTo = Prefixed_Name(tmo, "transmissionTo") |> PrefixedName
    /// <summary>
    ///   <para>tmo:transmissionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"transmissionType"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#transmissionType">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#transmissionType</seealso>
    let transmissionType = Prefixed_Name(tmo, "transmissionType") |> PrefixedName
    /// <summary>
    ///   <para>tmo:urgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"urgency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#urgency">http://www.semanticdesktop.org/ontologies/2008/05/20/tmo#urgency</seealso>
    let urgency = Prefixed_Name(tmo, "urgency") |> PrefixedName
