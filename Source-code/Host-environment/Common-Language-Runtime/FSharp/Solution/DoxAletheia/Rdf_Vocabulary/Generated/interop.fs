namespace http.www.w3.org.ns.solid.interop.hash

open DoxAletheia.Rdf_Vocabulary

module interop =
    let _namespace_name = "http://www.w3.org/ns/solid/interop#"

    /// <summary>
    /// Records an access authorization made by a Social Agent to another Agent for data in their control
    /// <see href="http://www.w3.org/ns/solid/interop#AccessAuthorization"></see></summary>
    let AccessAuthorization =
        Namespaced_IRI.parse _namespace_name "AccessAuthorization" |> NamespacedName

    /// <summary>
    /// An individual member of a Registry
    /// <see href="http://www.w3.org/ns/solid/interop#Registration"></see></summary>
    let Registration =
        Namespaced_IRI.parse _namespace_name "Registration" |> NamespacedName

    /// <summary>
    /// Describes the association between a SKOS label and an Access Need
    /// <see href="http://www.w3.org/ns/solid/interop#AccessDescription"></see></summary>
    let AccessDescription =
        Namespaced_IRI.parse _namespace_name "AccessDescription" |> NamespacedName

    /// <summary>
    /// A set of SKOS poly-hierarchies to describe AccessNeeds in an AccessNeedGroup
    /// <see href="http://www.w3.org/ns/solid/interop#AccessDescriptionSet"></see></summary>
    let AccessDescriptionSet =
        Namespaced_IRI.parse _namespace_name "AccessDescriptionSet" |> NamespacedName

    /// <summary>
    /// Provides an Agent with a detailed description of access that has been granted to them
    /// <see href="http://www.w3.org/ns/solid/interop#AccessGrant"></see></summary>
    let AccessGrant =
        Namespaced_IRI.parse _namespace_name "AccessGrant" |> NamespacedName

    /// <summary>
    /// Request for access to a type of data at a specified access level
    /// <see href="http://www.w3.org/ns/solid/interop#AccessNeed"></see></summary>
    let AccessNeed = Namespaced_IRI.parse _namespace_name "AccessNeed" |> NamespacedName

    /// <summary>
    /// Describes the association between a SKOS label and an Access Need
    /// <see href="http://www.w3.org/ns/solid/interop#AccessNeedDescription"></see></summary>
    let AccessNeedDescription =
        Namespaced_IRI.parse _namespace_name "AccessNeedDescription" |> NamespacedName

    /// <summary>
    /// A grouping of access needs
    /// <see href="http://www.w3.org/ns/solid/interop#AccessNeedGroup"></see></summary>
    let AccessNeedGroup =
        Namespaced_IRI.parse _namespace_name "AccessNeedGroup" |> NamespacedName

    /// <summary>
    /// Describes the association between a SKOS label and an Access Need Group
    /// <see href="http://www.w3.org/ns/solid/interop#AccessNeedGroupDescription"></see></summary>
    let AccessNeedGroupDescription =
        Namespaced_IRI.parse _namespace_name "AccessNeedGroupDescription" |> NamespacedName

    /// <summary>
    /// AccessNeed is not required
    /// <see href="http://www.w3.org/ns/solid/interop#AccessOptional"></see></summary>
    let AccessOptional =
        Namespaced_IRI.parse _namespace_name "AccessOptional" |> NamespacedName

    /// <summary>
    /// A record of access granted by another Social Agent in the ecosystem
    /// <see href="http://www.w3.org/ns/solid/interop#AccessReceipt"></see></summary>
    let AccessReceipt =
        Namespaced_IRI.parse _namespace_name "AccessReceipt" |> NamespacedName

    /// <summary>
    /// Request for access from one agent to another
    /// <see href="http://www.w3.org/ns/solid/interop#AccessRequest"></see></summary>
    let AccessRequest =
        Namespaced_IRI.parse _namespace_name "AccessRequest" |> NamespacedName

    /// <summary>
    /// AccessNeed is required
    /// <see href="http://www.w3.org/ns/solid/interop#AccessRequired"></see></summary>
    let AccessRequired =
        Namespaced_IRI.parse _namespace_name "AccessRequired" |> NamespacedName

    /// <summary>
    /// Class of access scopes
    /// <see href="http://www.w3.org/ns/solid/interop#AccessScope"></see></summary>
    let AccessScope =
        Namespaced_IRI.parse _namespace_name "AccessScope" |> NamespacedName

    /// <summary>
    /// An agent profile for the Solid Ecosystem
    /// <see href="http://www.w3.org/ns/solid/interop#Agent"></see></summary>
    let Agent = Namespaced_IRI.parse _namespace_name "Agent" |> NamespacedName

    /// <summary>
    /// An individual member of an Agent Registry
    /// <see href="http://www.w3.org/ns/solid/interop#AgentRegistration"></see></summary>
    let AgentRegistration =
        Namespaced_IRI.parse _namespace_name "AgentRegistration" |> NamespacedName

    /// <summary>
    /// A collection of Agent Registrations
    /// <see href="http://www.w3.org/ns/solid/interop#AgentRegistry"></see></summary>
    let AgentRegistry =
        Namespaced_IRI.parse _namespace_name "AgentRegistry" |> NamespacedName

    /// <summary>
    /// A collection of things pertinent to the operation of the Solid ecosystem
    /// <see href="http://www.w3.org/ns/solid/interop#Registry"></see></summary>
    let Registry = Namespaced_IRI.parse _namespace_name "Registry" |> NamespacedName
    /// <summary>
    /// All of the data owners data of a specified type, and all data shared with the owner of that type, across the owners registries
    /// <see href="http://www.w3.org/ns/solid/interop#All"></see></summary>
    let All = Namespaced_IRI.parse _namespace_name "All" |> NamespacedName

    /// <summary>
    /// All data of a given type shared by a specified Social Agent with the owner, across that Social Agents registries
    /// <see href="http://www.w3.org/ns/solid/interop#AllFromAgent"></see></summary>
    let AllFromAgent =
        Namespaced_IRI.parse _namespace_name "AllFromAgent" |> NamespacedName

    /// <summary>
    /// All of the data owners data of a specified type in a specified Data Registry
    /// <see href="http://www.w3.org/ns/solid/interop#AllFromRegistry"></see></summary>
    let AllFromRegistry =
        Namespaced_IRI.parse _namespace_name "AllFromRegistry" |> NamespacedName

    /// <summary>
    /// A client software application in the Solid Ecosystem
    /// <see href="http://www.w3.org/ns/solid/interop#Application"></see></summary>
    let Application =
        Namespaced_IRI.parse _namespace_name "Application" |> NamespacedName

    /// <summary>
    /// A registered Application in an Agent Registry
    /// <see href="http://www.w3.org/ns/solid/interop#ApplicationRegistration"></see></summary>
    let ApplicationRegistration =
        Namespaced_IRI.parse _namespace_name "ApplicationRegistration" |> NamespacedName

    /// <summary>
    /// Service used by end user to manage access
    /// <see href="http://www.w3.org/ns/solid/interop#AuthorizationAgent"></see></summary>
    let AuthorizationAgent =
        Namespaced_IRI.parse _namespace_name "AuthorizationAgent" |> NamespacedName

    /// <summary>
    /// A collection of Access Authorizations
    /// <see href="http://www.w3.org/ns/solid/interop#AuthorizationRegistry"></see></summary>
    let AuthorizationRegistry =
        Namespaced_IRI.parse _namespace_name "AuthorizationRegistry" |> NamespacedName

    /// <summary>
    /// Records the decision of a Social Agent to grant access to a specific type of data in their control
    /// <see href="http://www.w3.org/ns/solid/interop#DataAuthorization"></see></summary>
    let DataAuthorization =
        Namespaced_IRI.parse _namespace_name "DataAuthorization" |> NamespacedName

    /// <summary>
    /// Associates a DataRegistration with an AccessGrant
    /// <see href="http://www.w3.org/ns/solid/interop#DataGrant"></see></summary>
    let DataGrant = Namespaced_IRI.parse _namespace_name "DataGrant" |> NamespacedName

    /// <summary>
    /// An individual member of a Data Registry
    /// <see href="http://www.w3.org/ns/solid/interop#DataRegistration"></see></summary>
    let DataRegistration =
        Namespaced_IRI.parse _namespace_name "DataRegistration" |> NamespacedName

    /// <summary>
    /// A collection of Data Registration instances
    /// <see href="http://www.w3.org/ns/solid/interop#DataRegistry"></see></summary>
    let DataRegistry =
        Namespaced_IRI.parse _namespace_name "DataRegistry" |> NamespacedName

    /// <summary>
    /// A type of Data Grant where a grantee re-shares or delegates access they have received to another Agent
    /// <see href="http://www.w3.org/ns/solid/interop#DelegatedDataGrant"></see></summary>
    let DelegatedDataGrant =
        Namespaced_IRI.parse _namespace_name "DelegatedDataGrant" |> NamespacedName

    /// <summary>
    /// Only Data Instances of the data owners that are associated with Data Instances allowed by another authorization or grant
    /// <see href="http://www.w3.org/ns/solid/interop#Inherited"></see></summary>
    let Inherited = Namespaced_IRI.parse _namespace_name "Inherited" |> NamespacedName
    /// <summary>
    /// No access
    /// <see href="http://www.w3.org/ns/solid/interop#NoAccess"></see></summary>
    let NoAccess = Namespaced_IRI.parse _namespace_name "NoAccess" |> NamespacedName

    /// <summary>
    /// Access is for personal use of the Social Agent
    /// <see href="http://www.w3.org/ns/solid/interop#PersonalAccess"></see></summary>
    let PersonalAccess =
        Namespaced_IRI.parse _namespace_name "PersonalAccess" |> NamespacedName

    /// <summary>
    /// A collection of Registry instances
    /// <see href="http://www.w3.org/ns/solid/interop#RegistrySet"></see></summary>
    let RegistrySet =
        Namespaced_IRI.parse _namespace_name "RegistrySet" |> NamespacedName

    /// <summary>
    /// Only specified Data Instances of the data owners of a given type in a specified Data Registry
    /// <see href="http://www.w3.org/ns/solid/interop#SelectedFromRegistry"></see></summary>
    let SelectedFromRegistry =
        Namespaced_IRI.parse _namespace_name "SelectedFromRegistry" |> NamespacedName

    /// <summary>
    /// Access is to be shared with other Social Agents
    /// <see href="http://www.w3.org/ns/solid/interop#SharedAccess"></see></summary>
    let SharedAccess =
        Namespaced_IRI.parse _namespace_name "SharedAccess" |> NamespacedName

    /// <summary>
    /// A strongly identifiable individual, group, or organization
    /// <see href="http://www.w3.org/ns/solid/interop#SocialAgent"></see></summary>
    let SocialAgent =
        Namespaced_IRI.parse _namespace_name "SocialAgent" |> NamespacedName

    /// <summary>
    /// An invited Social Agent in an Agent Registry
    /// <see href="http://www.w3.org/ns/solid/interop#SocialAgentInvitation"></see></summary>
    let SocialAgentInvitation =
        Namespaced_IRI.parse _namespace_name "SocialAgentInvitation" |> NamespacedName

    /// <summary>
    /// An registered Social Agent in an Agent Registry
    /// <see href="http://www.w3.org/ns/solid/interop#SocialAgentRegistration"></see></summary>
    let SocialAgentRegistration =
        Namespaced_IRI.parse _namespace_name "SocialAgentRegistration" |> NamespacedName

    /// <summary>
    /// A requested acl:mode of access for an AccessNeed
    /// <see href="http://www.w3.org/ns/solid/interop#accessMode"></see></summary>
    let accessMode = Namespaced_IRI.parse _namespace_name "accessMode" |> NamespacedName

    /// <summary>
    /// Identifies the necessity of the AccessNeed
    /// <see href="http://www.w3.org/ns/solid/interop#accessNecessity"></see></summary>
    let accessNecessity =
        Namespaced_IRI.parse _namespace_name "accessNecessity" |> NamespacedName

    /// <summary>
    /// Provides context types for sharing scenarios
    /// <see href="http://www.w3.org/ns/solid/interop#accessScenario"></see></summary>
    let accessScenario =
        Namespaced_IRI.parse _namespace_name "accessScenario" |> NamespacedName

    /// <summary>
    /// Author of the Application
    /// <see href="http://www.w3.org/ns/solid/interop#applicationAuthor"></see></summary>
    let applicationAuthor =
        Namespaced_IRI.parse _namespace_name "applicationAuthor" |> NamespacedName

    /// <summary>
    /// Description of the Application
    /// <see href="http://www.w3.org/ns/solid/interop#applicationDescription"></see></summary>
    let applicationDescription =
        Namespaced_IRI.parse _namespace_name "applicationDescription" |> NamespacedName

    /// <summary>
    /// Name of the Application
    /// <see href="http://www.w3.org/ns/solid/interop#applicationName"></see></summary>
    let applicationName =
        Namespaced_IRI.parse _namespace_name "applicationName" |> NamespacedName

    /// <summary>
    /// Thumbnail for the application
    /// <see href="http://www.w3.org/ns/solid/interop#applicationThumbnail"></see></summary>
    let applicationThumbnail =
        Namespaced_IRI.parse _namespace_name "applicationThumbnail" |> NamespacedName

    /// <summary>
    /// Agent or mode the Application authenticates as
    /// <see href="http://www.w3.org/ns/solid/interop#authenticatesAs"></see></summary>
    let authenticatesAs =
        Namespaced_IRI.parse _namespace_name "authenticatesAs" |> NamespacedName

    /// <summary>
    /// An additional requested acl:mode of access for the creator of a resource
    /// <see href="http://www.w3.org/ns/solid/interop#creatorAccessMode"></see></summary>
    let creatorAccessMode =
        Namespaced_IRI.parse _namespace_name "creatorAccessMode" |> NamespacedName

    /// <summary>
    /// Identifies the Social Agent that owns a given data set
    /// <see href="http://www.w3.org/ns/solid/interop#dataOwner"></see></summary>
    let dataOwner = Namespaced_IRI.parse _namespace_name "dataOwner" |> NamespacedName

    /// <summary>
    /// Data Grant which is being delegated
    /// <see href="http://www.w3.org/ns/solid/interop#delegationOfGrant"></see></summary>
    let delegationOfGrant =
        Namespaced_IRI.parse _namespace_name "delegationOfGrant" |> NamespacedName

    /// <summary>
    /// Social Agent sending a message
    /// <see href="http://www.w3.org/ns/solid/interop#fromSocialAgent"></see></summary>
    let fromSocialAgent =
        Namespaced_IRI.parse _namespace_name "fromSocialAgent" |> NamespacedName

    /// <summary>
    /// Time that authorization or grant was granted
    /// <see href="http://www.w3.org/ns/solid/interop#grantedAt"></see></summary>
    let grantedAt = Namespaced_IRI.parse _namespace_name "grantedAt" |> NamespacedName
    /// <summary>
    /// Social agent that granted authorization or grant
    /// <see href="http://www.w3.org/ns/solid/interop#grantedBy"></see></summary>
    let grantedBy = Namespaced_IRI.parse _namespace_name "grantedBy" |> NamespacedName

    /// <summary>
    /// Application used by a Social Agent to grant authorization or issue access grant
    /// <see href="http://www.w3.org/ns/solid/interop#grantedWith"></see></summary>
    let grantedWith =
        Namespaced_IRI.parse _namespace_name "grantedWith" |> NamespacedName

    /// <summary>
    /// Recipient of authorization or grant
    /// <see href="http://www.w3.org/ns/solid/interop#grantee"></see></summary>
    let grantee = Namespaced_IRI.parse _namespace_name "grantee" |> NamespacedName

    /// <summary>
    /// Links to an AccessAuthorization in an Authorization Registry
    /// <see href="http://www.w3.org/ns/solid/interop#hasAccessAuthorization"></see></summary>
    let hasAccessAuthorization =
        Namespaced_IRI.parse _namespace_name "hasAccessAuthorization" |> NamespacedName

    /// <summary>
    /// Links to a registration in a given registry
    /// <see href="http://www.w3.org/ns/solid/interop#hasRegistration"></see></summary>
    let hasRegistration =
        Namespaced_IRI.parse _namespace_name "hasRegistration" |> NamespacedName

    /// <summary>
    /// Link to an Access Description Set
    /// <see href="http://www.w3.org/ns/solid/interop#hasAccessDescriptionSet"></see></summary>
    let hasAccessDescriptionSet =
        Namespaced_IRI.parse _namespace_name "hasAccessDescriptionSet" |> NamespacedName

    /// <summary>
    /// Links to an Access Need
    /// <see href="http://www.w3.org/ns/solid/interop#hasAccessNeed"></see></summary>
    let hasAccessNeed =
        Namespaced_IRI.parse _namespace_name "hasAccessNeed" |> NamespacedName

    /// <summary>
    /// Links to an AccessNeedDescription
    /// <see href="http://www.w3.org/ns/solid/interop#hasAccessNeedDescription"></see></summary>
    let hasAccessNeedDescription =
        Namespaced_IRI.parse _namespace_name "hasAccessNeedDescription" |> NamespacedName

    /// <summary>
    /// Links to AccessNeedGroup
    /// <see href="http://www.w3.org/ns/solid/interop#hasAccessNeedGroup"></see></summary>
    let hasAccessNeedGroup =
        Namespaced_IRI.parse _namespace_name "hasAccessNeedGroup" |> NamespacedName

    /// <summary>
    /// Links to an AccessNeedGroupDescription
    /// <see href="http://www.w3.org/ns/solid/interop#hasAccessNeedGroupDescription"></see></summary>
    let hasAccessNeedGroupDescription =
        Namespaced_IRI.parse _namespace_name "hasAccessNeedGroupDescription" |> NamespacedName

    /// <summary>
    /// Links to an Agent Registry in a registry set
    /// <see href="http://www.w3.org/ns/solid/interop#hasAgentRegistry"></see></summary>
    let hasAgentRegistry =
        Namespaced_IRI.parse _namespace_name "hasAgentRegistry" |> NamespacedName

    /// <summary>
    /// Links to a registry in a registry set
    /// <see href="http://www.w3.org/ns/solid/interop#hasRegistry"></see></summary>
    let hasRegistry =
        Namespaced_IRI.parse _namespace_name "hasRegistry" |> NamespacedName

    /// <summary>
    /// Links to an AgentRegistration for an Application
    /// <see href="http://www.w3.org/ns/solid/interop#hasApplicationRegistration"></see></summary>
    let hasApplicationRegistration =
        Namespaced_IRI.parse _namespace_name "hasApplicationRegistration" |> NamespacedName

    /// <summary>
    /// Links a Social Agent to their Authorization Agent
    /// <see href="http://www.w3.org/ns/solid/interop#hasAuthorizationAgent"></see></summary>
    let hasAuthorizationAgent =
        Namespaced_IRI.parse _namespace_name "hasAuthorizationAgent" |> NamespacedName

    /// <summary>
    /// URI expected to be used for redirect after authorization
    /// <see href="http://www.w3.org/ns/solid/interop#hasAuthorizationCallbackEndpoint"></see></summary>
    let hasAuthorizationCallbackEndpoint =
        Namespaced_IRI.parse _namespace_name "hasAuthorizationCallbackEndpoint" |> NamespacedName

    /// <summary>
    /// URI expected to be used for redirect to obtain authorization
    /// <see href="http://www.w3.org/ns/solid/interop#hasAuthorizationRedirectEndpoint"></see></summary>
    let hasAuthorizationRedirectEndpoint =
        Namespaced_IRI.parse _namespace_name "hasAuthorizationRedirectEndpoint" |> NamespacedName

    /// <summary>
    /// Links to an Authorization Registry in a registry set
    /// <see href="http://www.w3.org/ns/solid/interop#hasAuthorizationRegistry"></see></summary>
    let hasAuthorizationRegistry =
        Namespaced_IRI.parse _namespace_name "hasAuthorizationRegistry" |> NamespacedName

    /// <summary>
    /// Link to a DataAuthorization
    /// <see href="http://www.w3.org/ns/solid/interop#hasDataAuthorization"></see></summary>
    let hasDataAuthorization =
        Namespaced_IRI.parse _namespace_name "hasDataAuthorization" |> NamespacedName

    /// <summary>
    /// Links to a Data Grant associated with an Access Grant
    /// <see href="http://www.w3.org/ns/solid/interop#hasDataGrant"></see></summary>
    let hasDataGrant =
        Namespaced_IRI.parse _namespace_name "hasDataGrant" |> NamespacedName

    /// <summary>
    /// Links to instances of the shape tree in a data registration
    /// <see href="http://www.w3.org/ns/solid/interop#hasDataInstance"></see></summary>
    let hasDataInstance =
        Namespaced_IRI.parse _namespace_name "hasDataInstance" |> NamespacedName

    /// <summary>
    /// Links to a DataRegistration in a Data Registry
    /// <see href="http://www.w3.org/ns/solid/interop#hasDataRegistration"></see></summary>
    let hasDataRegistration =
        Namespaced_IRI.parse _namespace_name "hasDataRegistration" |> NamespacedName

    /// <summary>
    /// Links to an Data Registry in a registry set
    /// <see href="http://www.w3.org/ns/solid/interop#hasDataRegistry"></see></summary>
    let hasDataRegistry =
        Namespaced_IRI.parse _namespace_name "hasDataRegistry" |> NamespacedName

    /// <summary>
    /// Links a Social Agent to their registry set
    /// <see href="http://www.w3.org/ns/solid/interop#hasRegistrySet"></see></summary>
    let hasRegistrySet =
        Namespaced_IRI.parse _namespace_name "hasRegistrySet" |> NamespacedName

    /// <summary>
    /// Links to a ShapeTreeDecorator
    /// <see href="http://www.w3.org/ns/solid/interop#hasShapeTreeDecorator"></see></summary>
    let hasShapeTreeDecorator =
        Namespaced_IRI.parse _namespace_name "hasShapeTreeDecorator" |> NamespacedName

    /// <summary>
    /// Links to an AgentRegistration for a SocialAgent
    /// <see href="http://www.w3.org/ns/solid/interop#hasSocialAgentRegistration"></see></summary>
    let hasSocialAgentRegistration =
        Namespaced_IRI.parse _namespace_name "hasSocialAgentRegistration" |> NamespacedName

    /// <summary>
    /// Access Description Set the description belongs to
    /// <see href="http://www.w3.org/ns/solid/interop#inAccessDescriptionSet"></see></summary>
    let inAccessDescriptionSet =
        Namespaced_IRI.parse _namespace_name "inAccessDescriptionSet" |> NamespacedName

    /// <summary>
    /// Identifies the AccessNeedGroup the AccessNeed belongs to
    /// <see href="http://www.w3.org/ns/solid/interop#inAccessNeedGroup"></see></summary>
    let inAccessNeedGroup =
        Namespaced_IRI.parse _namespace_name "inAccessNeedGroup" |> NamespacedName

    /// <summary>
    /// Data Authorization to inherit from
    /// <see href="http://www.w3.org/ns/solid/interop#inheritsFromAuthorization"></see></summary>
    let inheritsFromAuthorization =
        Namespaced_IRI.parse _namespace_name "inheritsFromAuthorization" |> NamespacedName

    /// <summary>
    /// Links to a Data Grant that another Data Grant inherits from
    /// <see href="http://www.w3.org/ns/solid/interop#inheritsFromGrant"></see></summary>
    let inheritsFromGrant =
        Namespaced_IRI.parse _namespace_name "inheritsFromGrant" |> NamespacedName

    /// <summary>
    /// Links to an Access Need that another Access Need inherits from
    /// <see href="http://www.w3.org/ns/solid/interop#inheritsFromNeed"></see></summary>
    let inheritsFromNeed =
        Namespaced_IRI.parse _namespace_name "inheritsFromNeed" |> NamespacedName

    /// <summary>
    /// Links to the Application registered by an ApplicationRegistration
    /// <see href="http://www.w3.org/ns/solid/interop#registeredAgent"></see></summary>
    let registeredAgent =
        Namespaced_IRI.parse _namespace_name "registeredAgent" |> NamespacedName

    /// <summary>
    /// Data and time the registration was created
    /// <see href="http://www.w3.org/ns/solid/interop#registeredAt"></see></summary>
    let registeredAt =
        Namespaced_IRI.parse _namespace_name "registeredAt" |> NamespacedName

    /// <summary>
    /// Links to the Social Agent that created the registration
    /// <see href="http://www.w3.org/ns/solid/interop#registeredBy"></see></summary>
    let registeredBy =
        Namespaced_IRI.parse _namespace_name "registeredBy" |> NamespacedName

    /// <summary>
    /// Links to the relevant shape tree
    /// <see href="http://www.w3.org/ns/solid/interop#registeredShapeTree"></see></summary>
    let registeredShapeTree =
        Namespaced_IRI.parse _namespace_name "registeredShapeTree" |> NamespacedName

    /// <summary>
    /// Links to the client Application that was used to create the registration
    /// <see href="http://www.w3.org/ns/solid/interop#registeredWith"></see></summary>
    let registeredWith =
        Namespaced_IRI.parse _namespace_name "registeredWith" |> NamespacedName

    /// <summary>
    /// Links to a previous immutable resource that has been superseded
    /// <see href="http://www.w3.org/ns/solid/interop#replaces"></see></summary>
    let replaces = Namespaced_IRI.parse _namespace_name "replaces" |> NamespacedName

    /// <summary>
    /// Links to an AccessNeed that the grant satisfies
    /// <see href="http://www.w3.org/ns/solid/interop#satisfiesAccessNeed"></see></summary>
    let satisfiesAccessNeed =
        Namespaced_IRI.parse _namespace_name "satisfiesAccessNeed" |> NamespacedName

    /// <summary>
    /// Identifies the access scope of a Data Authorization
    /// <see href="http://www.w3.org/ns/solid/interop#scopeOfAuthorization"></see></summary>
    let scopeOfAuthorization =
        Namespaced_IRI.parse _namespace_name "scopeOfAuthorization" |> NamespacedName

    /// <summary>
    /// Links to a scope identifier for one of the grant types
    /// <see href="http://www.w3.org/ns/solid/interop#scopeOfGrant"></see></summary>
    let scopeOfGrant =
        Namespaced_IRI.parse _namespace_name "scopeOfGrant" |> NamespacedName

    /// <summary>
    /// Date and time the registration was updated
    /// <see href="http://www.w3.org/ns/solid/interop#updatedAt"></see></summary>
    let updatedAt = Namespaced_IRI.parse _namespace_name "updatedAt" |> NamespacedName

    /// <summary>
    /// Language code
    /// <see href="http://www.w3.org/ns/solid/interop#usesLanguage"></see></summary>
    let usesLanguage =
        Namespaced_IRI.parse _namespace_name "usesLanguage" |> NamespacedName

    /// <summary>
    /// Social Agent providing access on behalf of fromAgent
    /// <see href="http://www.w3.org/ns/solid/interop#viaSocialAgent"></see></summary>
    let viaSocialAgent =
        Namespaced_IRI.parse _namespace_name "viaSocialAgent" |> NamespacedName
