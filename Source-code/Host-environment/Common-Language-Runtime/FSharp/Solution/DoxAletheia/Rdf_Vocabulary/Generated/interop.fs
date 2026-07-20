namespace http.www.w3.org.ns.solid.interop.hash

open DoxAletheia

module interop =
    let _namespace_name = "http://www.w3.org/ns/solid/interop#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Records an access authorization made by a Social Agent to another Agent for data in their control
    /// <see href="http://www.w3.org/ns/solid/interop#AccessAuthorization"></see></summary>
    let AccessAuthorization = _prefix "AccessAuthorization"
    /// <summary>
    /// An individual member of a Registry
    /// <see href="http://www.w3.org/ns/solid/interop#Registration"></see></summary>
    let Registration = _prefix "Registration"
    /// <summary>
    /// Describes the association between a SKOS label and an Access Need
    /// <see href="http://www.w3.org/ns/solid/interop#AccessDescription"></see></summary>
    let AccessDescription = _prefix "AccessDescription"
    /// <summary>
    /// A set of SKOS poly-hierarchies to describe AccessNeeds in an AccessNeedGroup
    /// <see href="http://www.w3.org/ns/solid/interop#AccessDescriptionSet"></see></summary>
    let AccessDescriptionSet = _prefix "AccessDescriptionSet"
    /// <summary>
    /// Provides an Agent with a detailed description of access that has been granted to them
    /// <see href="http://www.w3.org/ns/solid/interop#AccessGrant"></see></summary>
    let AccessGrant = _prefix "AccessGrant"
    /// <summary>
    /// Request for access to a type of data at a specified access level
    /// <see href="http://www.w3.org/ns/solid/interop#AccessNeed"></see></summary>
    let AccessNeed = _prefix "AccessNeed"
    /// <summary>
    /// Describes the association between a SKOS label and an Access Need
    /// <see href="http://www.w3.org/ns/solid/interop#AccessNeedDescription"></see></summary>
    let AccessNeedDescription = _prefix "AccessNeedDescription"
    /// <summary>
    /// A grouping of access needs
    /// <see href="http://www.w3.org/ns/solid/interop#AccessNeedGroup"></see></summary>
    let AccessNeedGroup = _prefix "AccessNeedGroup"
    /// <summary>
    /// Describes the association between a SKOS label and an Access Need Group
    /// <see href="http://www.w3.org/ns/solid/interop#AccessNeedGroupDescription"></see></summary>
    let AccessNeedGroupDescription = _prefix "AccessNeedGroupDescription"
    /// <summary>
    /// AccessNeed is not required
    /// <see href="http://www.w3.org/ns/solid/interop#AccessOptional"></see></summary>
    let AccessOptional = _prefix "AccessOptional"
    /// <summary>
    /// A record of access granted by another Social Agent in the ecosystem
    /// <see href="http://www.w3.org/ns/solid/interop#AccessReceipt"></see></summary>
    let AccessReceipt = _prefix "AccessReceipt"
    /// <summary>
    /// Request for access from one agent to another
    /// <see href="http://www.w3.org/ns/solid/interop#AccessRequest"></see></summary>
    let AccessRequest = _prefix "AccessRequest"
    /// <summary>
    /// AccessNeed is required
    /// <see href="http://www.w3.org/ns/solid/interop#AccessRequired"></see></summary>
    let AccessRequired = _prefix "AccessRequired"
    /// <summary>
    /// Class of access scopes
    /// <see href="http://www.w3.org/ns/solid/interop#AccessScope"></see></summary>
    let AccessScope = _prefix "AccessScope"
    /// <summary>
    /// An agent profile for the Solid Ecosystem
    /// <see href="http://www.w3.org/ns/solid/interop#Agent"></see></summary>
    let Agent = _prefix "Agent"
    /// <summary>
    /// An individual member of an Agent Registry
    /// <see href="http://www.w3.org/ns/solid/interop#AgentRegistration"></see></summary>
    let AgentRegistration = _prefix "AgentRegistration"
    /// <summary>
    /// A collection of Agent Registrations
    /// <see href="http://www.w3.org/ns/solid/interop#AgentRegistry"></see></summary>
    let AgentRegistry = _prefix "AgentRegistry"
    /// <summary>
    /// A collection of things pertinent to the operation of the Solid ecosystem
    /// <see href="http://www.w3.org/ns/solid/interop#Registry"></see></summary>
    let Registry = _prefix "Registry"
    /// <summary>
    /// All of the data owners data of a specified type, and all data shared with the owner of that type, across the owners registries
    /// <see href="http://www.w3.org/ns/solid/interop#All"></see></summary>
    let All = _prefix "All"
    /// <summary>
    /// All data of a given type shared by a specified Social Agent with the owner, across that Social Agents registries
    /// <see href="http://www.w3.org/ns/solid/interop#AllFromAgent"></see></summary>
    let AllFromAgent = _prefix "AllFromAgent"
    /// <summary>
    /// All of the data owners data of a specified type in a specified Data Registry
    /// <see href="http://www.w3.org/ns/solid/interop#AllFromRegistry"></see></summary>
    let AllFromRegistry = _prefix "AllFromRegistry"
    /// <summary>
    /// A client software application in the Solid Ecosystem
    /// <see href="http://www.w3.org/ns/solid/interop#Application"></see></summary>
    let Application = _prefix "Application"
    /// <summary>
    /// A registered Application in an Agent Registry
    /// <see href="http://www.w3.org/ns/solid/interop#ApplicationRegistration"></see></summary>
    let ApplicationRegistration = _prefix "ApplicationRegistration"
    /// <summary>
    /// Service used by end user to manage access
    /// <see href="http://www.w3.org/ns/solid/interop#AuthorizationAgent"></see></summary>
    let AuthorizationAgent = _prefix "AuthorizationAgent"
    /// <summary>
    /// A collection of Access Authorizations
    /// <see href="http://www.w3.org/ns/solid/interop#AuthorizationRegistry"></see></summary>
    let AuthorizationRegistry = _prefix "AuthorizationRegistry"
    /// <summary>
    /// Records the decision of a Social Agent to grant access to a specific type of data in their control
    /// <see href="http://www.w3.org/ns/solid/interop#DataAuthorization"></see></summary>
    let DataAuthorization = _prefix "DataAuthorization"
    /// <summary>
    /// Associates a DataRegistration with an AccessGrant
    /// <see href="http://www.w3.org/ns/solid/interop#DataGrant"></see></summary>
    let DataGrant = _prefix "DataGrant"
    /// <summary>
    /// An individual member of a Data Registry
    /// <see href="http://www.w3.org/ns/solid/interop#DataRegistration"></see></summary>
    let DataRegistration = _prefix "DataRegistration"
    /// <summary>
    /// A collection of Data Registration instances
    /// <see href="http://www.w3.org/ns/solid/interop#DataRegistry"></see></summary>
    let DataRegistry = _prefix "DataRegistry"
    /// <summary>
    /// A type of Data Grant where a grantee re-shares or delegates access they have received to another Agent
    /// <see href="http://www.w3.org/ns/solid/interop#DelegatedDataGrant"></see></summary>
    let DelegatedDataGrant = _prefix "DelegatedDataGrant"
    /// <summary>
    /// Only Data Instances of the data owners that are associated with Data Instances allowed by another authorization or grant
    /// <see href="http://www.w3.org/ns/solid/interop#Inherited"></see></summary>
    let Inherited = _prefix "Inherited"
    /// <summary>
    /// No access
    /// <see href="http://www.w3.org/ns/solid/interop#NoAccess"></see></summary>
    let NoAccess = _prefix "NoAccess"
    /// <summary>
    /// Access is for personal use of the Social Agent
    /// <see href="http://www.w3.org/ns/solid/interop#PersonalAccess"></see></summary>
    let PersonalAccess = _prefix "PersonalAccess"
    /// <summary>
    /// A collection of Registry instances
    /// <see href="http://www.w3.org/ns/solid/interop#RegistrySet"></see></summary>
    let RegistrySet = _prefix "RegistrySet"
    /// <summary>
    /// Only specified Data Instances of the data owners of a given type in a specified Data Registry
    /// <see href="http://www.w3.org/ns/solid/interop#SelectedFromRegistry"></see></summary>
    let SelectedFromRegistry = _prefix "SelectedFromRegistry"
    /// <summary>
    /// Access is to be shared with other Social Agents
    /// <see href="http://www.w3.org/ns/solid/interop#SharedAccess"></see></summary>
    let SharedAccess = _prefix "SharedAccess"
    /// <summary>
    /// A strongly identifiable individual, group, or organization
    /// <see href="http://www.w3.org/ns/solid/interop#SocialAgent"></see></summary>
    let SocialAgent = _prefix "SocialAgent"
    /// <summary>
    /// An invited Social Agent in an Agent Registry
    /// <see href="http://www.w3.org/ns/solid/interop#SocialAgentInvitation"></see></summary>
    let SocialAgentInvitation = _prefix "SocialAgentInvitation"
    /// <summary>
    /// An registered Social Agent in an Agent Registry
    /// <see href="http://www.w3.org/ns/solid/interop#SocialAgentRegistration"></see></summary>
    let SocialAgentRegistration = _prefix "SocialAgentRegistration"
    /// <summary>
    /// A requested acl:mode of access for an AccessNeed
    /// <see href="http://www.w3.org/ns/solid/interop#accessMode"></see></summary>
    let accessMode = _prefix "accessMode"
    /// <summary>
    /// Identifies the necessity of the AccessNeed
    /// <see href="http://www.w3.org/ns/solid/interop#accessNecessity"></see></summary>
    let accessNecessity = _prefix "accessNecessity"
    /// <summary>
    /// Provides context types for sharing scenarios
    /// <see href="http://www.w3.org/ns/solid/interop#accessScenario"></see></summary>
    let accessScenario = _prefix "accessScenario"
    /// <summary>
    /// Author of the Application
    /// <see href="http://www.w3.org/ns/solid/interop#applicationAuthor"></see></summary>
    let applicationAuthor = _prefix "applicationAuthor"
    /// <summary>
    /// Description of the Application
    /// <see href="http://www.w3.org/ns/solid/interop#applicationDescription"></see></summary>
    let applicationDescription = _prefix "applicationDescription"
    /// <summary>
    /// Name of the Application
    /// <see href="http://www.w3.org/ns/solid/interop#applicationName"></see></summary>
    let applicationName = _prefix "applicationName"
    /// <summary>
    /// Thumbnail for the application
    /// <see href="http://www.w3.org/ns/solid/interop#applicationThumbnail"></see></summary>
    let applicationThumbnail = _prefix "applicationThumbnail"
    /// <summary>
    /// Agent or mode the Application authenticates as
    /// <see href="http://www.w3.org/ns/solid/interop#authenticatesAs"></see></summary>
    let authenticatesAs = _prefix "authenticatesAs"
    /// <summary>
    /// An additional requested acl:mode of access for the creator of a resource
    /// <see href="http://www.w3.org/ns/solid/interop#creatorAccessMode"></see></summary>
    let creatorAccessMode = _prefix "creatorAccessMode"
    /// <summary>
    /// Identifies the Social Agent that owns a given data set
    /// <see href="http://www.w3.org/ns/solid/interop#dataOwner"></see></summary>
    let dataOwner = _prefix "dataOwner"
    /// <summary>
    /// Data Grant which is being delegated
    /// <see href="http://www.w3.org/ns/solid/interop#delegationOfGrant"></see></summary>
    let delegationOfGrant = _prefix "delegationOfGrant"
    /// <summary>
    /// Social Agent sending a message
    /// <see href="http://www.w3.org/ns/solid/interop#fromSocialAgent"></see></summary>
    let fromSocialAgent = _prefix "fromSocialAgent"
    /// <summary>
    /// Time that authorization or grant was granted
    /// <see href="http://www.w3.org/ns/solid/interop#grantedAt"></see></summary>
    let grantedAt = _prefix "grantedAt"
    /// <summary>
    /// Social agent that granted authorization or grant
    /// <see href="http://www.w3.org/ns/solid/interop#grantedBy"></see></summary>
    let grantedBy = _prefix "grantedBy"
    /// <summary>
    /// Application used by a Social Agent to grant authorization or issue access grant
    /// <see href="http://www.w3.org/ns/solid/interop#grantedWith"></see></summary>
    let grantedWith = _prefix "grantedWith"
    /// <summary>
    /// Recipient of authorization or grant
    /// <see href="http://www.w3.org/ns/solid/interop#grantee"></see></summary>
    let grantee = _prefix "grantee"
    /// <summary>
    /// Links to an AccessAuthorization in an Authorization Registry
    /// <see href="http://www.w3.org/ns/solid/interop#hasAccessAuthorization"></see></summary>
    let hasAccessAuthorization = _prefix "hasAccessAuthorization"
    /// <summary>
    /// Links to a registration in a given registry
    /// <see href="http://www.w3.org/ns/solid/interop#hasRegistration"></see></summary>
    let hasRegistration = _prefix "hasRegistration"
    /// <summary>
    /// Link to an Access Description Set
    /// <see href="http://www.w3.org/ns/solid/interop#hasAccessDescriptionSet"></see></summary>
    let hasAccessDescriptionSet = _prefix "hasAccessDescriptionSet"
    /// <summary>
    /// Links to an Access Need
    /// <see href="http://www.w3.org/ns/solid/interop#hasAccessNeed"></see></summary>
    let hasAccessNeed = _prefix "hasAccessNeed"
    /// <summary>
    /// Links to an AccessNeedDescription
    /// <see href="http://www.w3.org/ns/solid/interop#hasAccessNeedDescription"></see></summary>
    let hasAccessNeedDescription = _prefix "hasAccessNeedDescription"
    /// <summary>
    /// Links to AccessNeedGroup
    /// <see href="http://www.w3.org/ns/solid/interop#hasAccessNeedGroup"></see></summary>
    let hasAccessNeedGroup = _prefix "hasAccessNeedGroup"
    /// <summary>
    /// Links to an AccessNeedGroupDescription
    /// <see href="http://www.w3.org/ns/solid/interop#hasAccessNeedGroupDescription"></see></summary>
    let hasAccessNeedGroupDescription = _prefix "hasAccessNeedGroupDescription"
    /// <summary>
    /// Links to an Agent Registry in a registry set
    /// <see href="http://www.w3.org/ns/solid/interop#hasAgentRegistry"></see></summary>
    let hasAgentRegistry = _prefix "hasAgentRegistry"
    /// <summary>
    /// Links to a registry in a registry set
    /// <see href="http://www.w3.org/ns/solid/interop#hasRegistry"></see></summary>
    let hasRegistry = _prefix "hasRegistry"
    /// <summary>
    /// Links to an AgentRegistration for an Application
    /// <see href="http://www.w3.org/ns/solid/interop#hasApplicationRegistration"></see></summary>
    let hasApplicationRegistration = _prefix "hasApplicationRegistration"
    /// <summary>
    /// Links a Social Agent to their Authorization Agent
    /// <see href="http://www.w3.org/ns/solid/interop#hasAuthorizationAgent"></see></summary>
    let hasAuthorizationAgent = _prefix "hasAuthorizationAgent"
    /// <summary>
    /// URI expected to be used for redirect after authorization
    /// <see href="http://www.w3.org/ns/solid/interop#hasAuthorizationCallbackEndpoint"></see></summary>
    let hasAuthorizationCallbackEndpoint = _prefix "hasAuthorizationCallbackEndpoint"
    /// <summary>
    /// URI expected to be used for redirect to obtain authorization
    /// <see href="http://www.w3.org/ns/solid/interop#hasAuthorizationRedirectEndpoint"></see></summary>
    let hasAuthorizationRedirectEndpoint = _prefix "hasAuthorizationRedirectEndpoint"
    /// <summary>
    /// Links to an Authorization Registry in a registry set
    /// <see href="http://www.w3.org/ns/solid/interop#hasAuthorizationRegistry"></see></summary>
    let hasAuthorizationRegistry = _prefix "hasAuthorizationRegistry"
    /// <summary>
    /// Link to a DataAuthorization
    /// <see href="http://www.w3.org/ns/solid/interop#hasDataAuthorization"></see></summary>
    let hasDataAuthorization = _prefix "hasDataAuthorization"
    /// <summary>
    /// Links to a Data Grant associated with an Access Grant
    /// <see href="http://www.w3.org/ns/solid/interop#hasDataGrant"></see></summary>
    let hasDataGrant = _prefix "hasDataGrant"
    /// <summary>
    /// Links to instances of the shape tree in a data registration
    /// <see href="http://www.w3.org/ns/solid/interop#hasDataInstance"></see></summary>
    let hasDataInstance = _prefix "hasDataInstance"
    /// <summary>
    /// Links to a DataRegistration in a Data Registry
    /// <see href="http://www.w3.org/ns/solid/interop#hasDataRegistration"></see></summary>
    let hasDataRegistration = _prefix "hasDataRegistration"
    /// <summary>
    /// Links to an Data Registry in a registry set
    /// <see href="http://www.w3.org/ns/solid/interop#hasDataRegistry"></see></summary>
    let hasDataRegistry = _prefix "hasDataRegistry"
    /// <summary>
    /// Links a Social Agent to their registry set
    /// <see href="http://www.w3.org/ns/solid/interop#hasRegistrySet"></see></summary>
    let hasRegistrySet = _prefix "hasRegistrySet"
    /// <summary>
    /// Links to a ShapeTreeDecorator
    /// <see href="http://www.w3.org/ns/solid/interop#hasShapeTreeDecorator"></see></summary>
    let hasShapeTreeDecorator = _prefix "hasShapeTreeDecorator"
    /// <summary>
    /// Links to an AgentRegistration for a SocialAgent
    /// <see href="http://www.w3.org/ns/solid/interop#hasSocialAgentRegistration"></see></summary>
    let hasSocialAgentRegistration = _prefix "hasSocialAgentRegistration"
    /// <summary>
    /// Access Description Set the description belongs to
    /// <see href="http://www.w3.org/ns/solid/interop#inAccessDescriptionSet"></see></summary>
    let inAccessDescriptionSet = _prefix "inAccessDescriptionSet"
    /// <summary>
    /// Identifies the AccessNeedGroup the AccessNeed belongs to
    /// <see href="http://www.w3.org/ns/solid/interop#inAccessNeedGroup"></see></summary>
    let inAccessNeedGroup = _prefix "inAccessNeedGroup"
    /// <summary>
    /// Data Authorization to inherit from
    /// <see href="http://www.w3.org/ns/solid/interop#inheritsFromAuthorization"></see></summary>
    let inheritsFromAuthorization = _prefix "inheritsFromAuthorization"
    /// <summary>
    /// Links to a Data Grant that another Data Grant inherits from
    /// <see href="http://www.w3.org/ns/solid/interop#inheritsFromGrant"></see></summary>
    let inheritsFromGrant = _prefix "inheritsFromGrant"
    /// <summary>
    /// Links to an Access Need that another Access Need inherits from
    /// <see href="http://www.w3.org/ns/solid/interop#inheritsFromNeed"></see></summary>
    let inheritsFromNeed = _prefix "inheritsFromNeed"
    /// <summary>
    /// Links to the Application registered by an ApplicationRegistration
    /// <see href="http://www.w3.org/ns/solid/interop#registeredAgent"></see></summary>
    let registeredAgent = _prefix "registeredAgent"
    /// <summary>
    /// Data and time the registration was created
    /// <see href="http://www.w3.org/ns/solid/interop#registeredAt"></see></summary>
    let registeredAt = _prefix "registeredAt"
    /// <summary>
    /// Links to the Social Agent that created the registration
    /// <see href="http://www.w3.org/ns/solid/interop#registeredBy"></see></summary>
    let registeredBy = _prefix "registeredBy"
    /// <summary>
    /// Links to the relevant shape tree
    /// <see href="http://www.w3.org/ns/solid/interop#registeredShapeTree"></see></summary>
    let registeredShapeTree = _prefix "registeredShapeTree"
    /// <summary>
    /// Links to the client Application that was used to create the registration
    /// <see href="http://www.w3.org/ns/solid/interop#registeredWith"></see></summary>
    let registeredWith = _prefix "registeredWith"
    /// <summary>
    /// Links to a previous immutable resource that has been superseded
    /// <see href="http://www.w3.org/ns/solid/interop#replaces"></see></summary>
    let replaces = _prefix "replaces"
    /// <summary>
    /// Links to an AccessNeed that the grant satisfies
    /// <see href="http://www.w3.org/ns/solid/interop#satisfiesAccessNeed"></see></summary>
    let satisfiesAccessNeed = _prefix "satisfiesAccessNeed"
    /// <summary>
    /// Identifies the access scope of a Data Authorization
    /// <see href="http://www.w3.org/ns/solid/interop#scopeOfAuthorization"></see></summary>
    let scopeOfAuthorization = _prefix "scopeOfAuthorization"
    /// <summary>
    /// Links to a scope identifier for one of the grant types
    /// <see href="http://www.w3.org/ns/solid/interop#scopeOfGrant"></see></summary>
    let scopeOfGrant = _prefix "scopeOfGrant"
    /// <summary>
    /// Date and time the registration was updated
    /// <see href="http://www.w3.org/ns/solid/interop#updatedAt"></see></summary>
    let updatedAt = _prefix "updatedAt"
    /// <summary>
    /// Language code
    /// <see href="http://www.w3.org/ns/solid/interop#usesLanguage"></see></summary>
    let usesLanguage = _prefix "usesLanguage"
    /// <summary>
    /// Social Agent providing access on behalf of fromAgent
    /// <see href="http://www.w3.org/ns/solid/interop#viaSocialAgent"></see></summary>
    let viaSocialAgent = _prefix "viaSocialAgent"
