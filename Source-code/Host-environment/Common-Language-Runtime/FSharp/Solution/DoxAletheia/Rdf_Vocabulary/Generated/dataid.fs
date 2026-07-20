namespace http.dataid.dbpedia.org.ns.core.hash

open DoxAletheia

module dataid =
    let _namespace_name = "http://dataid.dbpedia.org/ns/core#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The level of openness of access to particular groups of agents
    /// <see href="http://dataid.dbpedia.org/ns/core#AccessLevel"></see></summary>
    let AccessLevel = _prefix "AccessLevel"
    /// <summary>
    /// Provides an agent with unrestricted access and all rights of a resource.
    /// <see href="http://dataid.dbpedia.org/ns/core#PrivateAccess"></see></summary>
    let PrivateAccess = _prefix "PrivateAccess"
    /// <summary>
    /// Limits the rights an agent has on a resource to read and modify.
    /// <see href="http://dataid.dbpedia.org/ns/core#SemiPrivateAccess"></see></summary>
    let SemiPrivateAccess = _prefix "SemiPrivateAccess"
    /// <summary>
    /// Limits the rights an agent has on a resource to read rights.
    /// <see href="http://dataid.dbpedia.org/ns/core#PublicAccess"></see></summary>
    let PublicAccess = _prefix "PublicAccess"
    /// <summary>
    /// Disallows access to a resource for an agent.
    /// <see href="http://dataid.dbpedia.org/ns/core#NoAccess"></see></summary>
    let NoAccess = _prefix "NoAccess"
    /// <summary>
    /// Any type of agent without a specific function.
    /// <see href="http://dataid.dbpedia.org/ns/core#Agent"></see></summary>
    let Agent = _prefix "Agent"
    /// <summary>
    /// Uniquly identifies an agent given a identifier and a correspondng aid/pid system (ORCID, ResearcherID etc.).
    /// <see href="http://dataid.dbpedia.org/ns/core#AgentIdentifier"></see></summary>
    let AgentIdentifier = _prefix "AgentIdentifier"
    /// <summary>
    /// the id of an agent as string
    /// <see href="http://dataid.dbpedia.org/ns/core#aid"></see></summary>
    let aid = _prefix "aid"
    /// <summary>
    /// the aid/pid system used for this identifier (ORCID, ResearcherID etc.)
    /// <see href="http://dataid.dbpedia.org/ns/core#aidSystem"></see></summary>
    let aidSystem = _prefix "aidSystem"
    /// <summary>
    /// Instances of this class define an array of rights and responsibilities an agent, assigned with this role for a given scope of entities, has to address or can execute.
    /// <see href="http://dataid.dbpedia.org/ns/core#AgentRole"></see></summary>
    let AgentRole = _prefix "AgentRole"
    /// <summary>
    /// AgentRoles allows an agent to execute certain actions.
    /// <see href="http://dataid.dbpedia.org/ns/core#allowsFor"></see></summary>
    let allowsFor = _prefix "allowsFor"
    /// <summary>
    /// A visitor/anonymous agent has only read rights on public and semi-private documents
    /// <see href="http://dataid.dbpedia.org/ns/core#Guest"></see></summary>
    let Guest = _prefix "Guest"
    /// <summary>
    /// Creator of the resource. An agent that is credited with a main part in the initial creation of the resource.
    /// <see href="http://dataid.dbpedia.org/ns/core#Creator"></see></summary>
    let Creator = _prefix "Creator"
    /// <summary>
    /// Contributor to the resource. An agent that was involved in creating or maintaining the resource but does not have the main part in this activity.
    /// <see href="http://dataid.dbpedia.org/ns/core#Contributor"></see></summary>
    let Contributor = _prefix "Contributor"
    /// <summary>
    /// Maintainer of the dataset. An agent that ensures the technical correctness, accessibility and up-to-dateness of a dataset.
    /// <see href="http://dataid.dbpedia.org/ns/core#Maintainer"></see></summary>
    let Maintainer = _prefix "Maintainer"
    /// <summary>
    /// Publisher of the dataset. An agent that makes the dataset accessible online on a server or repository without necessarily being involved in its creation.
    /// <see href="http://dataid.dbpedia.org/ns/core#Publisher"></see></summary>
    let Publisher = _prefix "Publisher"
    /// <summary>
    /// Contact agent. An agent that can be contacted for general requests about the resource.
    /// <see href="http://dataid.dbpedia.org/ns/core#Contact"></see></summary>
    let Contact = _prefix "Contact"
    /// <summary>
    /// The responsibility to supervise other agents.
    /// <see href="http://dataid.dbpedia.org/ns/core#AgentSupervision"></see></summary>
    let AgentSupervision = _prefix "AgentSupervision"
    /// <summary>
    /// AgentRoles provide access rights as well as responsibilities an agent has to attend to in order to fullfill this role. Responsible actions should describe actions pertaining to responsibilities an agent is supposed to do.
    /// <see href="http://dataid.dbpedia.org/ns/core#ResponsibleAction"></see></summary>
    let ResponsibleAction = _prefix "ResponsibleAction"
    /// <summary>
    /// This concept defines a scope of Entities and links it to an Agent which has certain rights for those entities (defined by the AgentRole). This scope consists of all Entities directly linked to the context, as well as transitively dependend Entities
    /// <see href="http://dataid.dbpedia.org/ns/core#AuthorityEntityContext"></see></summary>
    let AuthorityEntityContext = _prefix "AuthorityEntityContext"
    /// <summary>
    /// Defines that a context keeps intact for the next version of a DataID (if set to 'true').
    /// The property of certain authority entity context to be able to be inherited
    /// <see href="http://dataid.dbpedia.org/ns/core#isInheritable"></see></summary>
    let isInheritable = _prefix "isInheritable"
    /// <summary>
    /// Adds a role an agent can administer in the scope provided by the AuthorityEntityContext, thereby allowing for certain actions an agent can execute.
    /// <see href="http://dataid.dbpedia.org/ns/core#authorityAgentRole"></see></summary>
    let authorityAgentRole = _prefix "authorityAgentRole"
    /// <summary>
    /// An AuthorityEntityContext is valid for a specific Agent until a certain point in time.
    /// <see href="http://dataid.dbpedia.org/ns/core#validUntil"></see></summary>
    let validUntil = _prefix "validUntil"
    /// <summary>
    /// An AuthorityEntityContext is valid for a specific Agent from a certain point in time.
    /// <see href="http://dataid.dbpedia.org/ns/core#validFrom"></see></summary>
    let validFrom = _prefix "validFrom"
    /// <summary>
    /// Defines the scope of an authority-context. An Agent has the right to execute authorized actions in this scope (e.g. a single DataId and all it's members).
    /// <see href="http://dataid.dbpedia.org/ns/core#authorizedFor"></see></summary>
    let authorizedFor = _prefix "authorizedFor"
    /// <summary>
    /// Provides an agent the ability to execute authorized actions in a certain scope (e.g. to modify the metadata of a dataset)
    /// <see href="http://dataid.dbpedia.org/ns/core#authorizedAgent"></see></summary>
    let authorizedAgent = _prefix "authorizedAgent"
    /// <summary>
    /// AgentRoles provide agents with the ability to execute certain actions as well as demand certain responsibilities, which are defines by the instances of this concept.
    /// <see href="http://dataid.dbpedia.org/ns/core#AuthorizedAction"></see></summary>
    let AuthorizedAction = _prefix "AuthorizedAction"
    /// <summary>
    /// AgentRoles provide access and modification rights to an agent. Entitled actions should comprise actions pertaining to access/modification restrictions.
    /// <see href="http://dataid.dbpedia.org/ns/core#EntitledAction"></see></summary>
    let EntitledAction = _prefix "EntitledAction"
    /// <summary>
    /// Entitled action to modify the content of an entity.
    /// <see href="http://dataid.dbpedia.org/ns/core#ModifyContent"></see></summary>
    let ModifyContent = _prefix "ModifyContent"
    /// <summary>
    /// Entitled action to read the content of an entity.
    /// <see href="http://dataid.dbpedia.org/ns/core#ReadContent"></see></summary>
    let ReadContent = _prefix "ReadContent"
    /// <summary>
    /// Entitled action to read the DataID dataset metadata
    /// <see href="http://dataid.dbpedia.org/ns/core#ReadDataId"></see></summary>
    let ReadDataId = _prefix "ReadDataId"
    /// <summary>
    /// The responsibility to respond to contact attempts by external agents. A contact point for the entity.
    /// <see href="http://dataid.dbpedia.org/ns/core#ResponseToContact"></see></summary>
    let ResponseToContact = _prefix "ResponseToContact"
    /// <summary>
    /// Entitled action to modify the role of agents on certain entities.
    /// <see href="http://dataid.dbpedia.org/ns/core#ModifyAgentRoles"></see></summary>
    let ModifyAgentRoles = _prefix "ModifyAgentRoles"
    /// <summary>
    /// Entitled action to modify access level of an entity.
    /// <see href="http://dataid.dbpedia.org/ns/core#ModifyAccessLevel"></see></summary>
    let ModifyAccessLevel = _prefix "ModifyAccessLevel"
    /// <summary>
    /// Entitled action to delete some content of an entity.
    /// <see href="http://dataid.dbpedia.org/ns/core#DeleteContent"></see></summary>
    let DeleteContent = _prefix "DeleteContent"
    /// <summary>
    /// The responsibility to update dataset metadata.
    /// <see href="http://dataid.dbpedia.org/ns/core#UpdateDataId"></see></summary>
    let UpdateDataId = _prefix "UpdateDataId"
    /// <summary>
    /// The responsibility decide if the entity should be published
    /// <see href="http://dataid.dbpedia.org/ns/core#PublishingDecision"></see></summary>
    let PublishingDecision = _prefix "PublishingDecision"
    /// <summary>
    /// Entitled action to modify which agents are authorized on certain entities.
    /// <see href="http://dataid.dbpedia.org/ns/core#ModifyAuthorizedAgents"></see></summary>
    let ModifyAuthorizedAgents = _prefix "ModifyAuthorizedAgents"
    /// <summary>
    /// The responsibility to manage changes and react to bugs and issues that are reported
    /// <see href="http://dataid.dbpedia.org/ns/core#ResponseToLifeCycleEvent"></see></summary>
    let ResponseToLifeCycleEvent = _prefix "ResponseToLifeCycleEvent"
    /// <summary>
    /// A description of one or more datasets. The DataID itself.
    /// <see href="http://dataid.dbpedia.org/ns/core#DataId"></see></summary>
    let DataId = _prefix "DataId"
    /// <summary>
    /// defines the access rights for DataId related entities
    /// <see href="http://dataid.dbpedia.org/ns/core#hasAccessLevel"></see></summary>
    let hasAccessLevel = _prefix "hasAccessLevel"
    /// <summary>
    /// Points out a dataid:AuthorityEntityContext pertaining to this resource.
    /// <see href="http://dataid.dbpedia.org/ns/core#hasEntityContext"></see></summary>
    let hasEntityContext = _prefix "hasEntityContext"
    /// <summary>
    /// A collection of data, available for access in one or more formats. Dataset resources describe the concept of the dataset, not it's manifestation (the data itself), which can be acquired as Distribution.
    ///     Datasets are prov:Entities and can be generated by prov:Activities.
    /// <see href="http://dataid.dbpedia.org/ns/core#Dataset"></see></summary>
    let Dataset = _prefix "Dataset"
    /// <summary>
    /// Latest version of a DataIdPart
    /// <see href="http://dataid.dbpedia.org/ns/core#latestVersion"></see></summary>
    let latestVersion = _prefix "latestVersion"
    /// <summary>
    /// Next version of a DataIdPart
    /// <see href="http://dataid.dbpedia.org/ns/core#nextVersion"></see></summary>
    let nextVersion = _prefix "nextVersion"
    /// <summary>
    /// provides a version string for any entity
    /// <see href="http://dataid.dbpedia.org/ns/core#version"></see></summary>
    let version = _prefix "version"
    /// <summary>
    /// previous version of a DataIdPart
    /// <see href="http://dataid.dbpedia.org/ns/core#previousVersion"></see></summary>
    let previousVersion = _prefix "previousVersion"
    /// <summary>
    /// some agent generally connected to the dataset, their function to be specified by their rdf:type
    /// <see href="http://dataid.dbpedia.org/ns/core#associatedAgent"></see></summary>
    let associatedAgent = _prefix "associatedAgent"
    /// <summary>
    /// A way to access a dataset, like a dump file, an endpoint, an API etc.
    /// <see href="http://dataid.dbpedia.org/ns/core#Distribution"></see></summary>
    let Distribution = _prefix "Distribution"
    /// <summary>
    /// A dedicated directory holding multiple files of the same dataset.
    /// <see href="http://dataid.dbpedia.org/ns/core#Directory"></see></summary>
    let Directory = _prefix "Directory"
    /// <summary>
    /// Checksum of a file to check for correctness
    /// <see href="http://dataid.dbpedia.org/ns/core#checksum"></see></summary>
    let checksum = _prefix "checksum"
    /// <summary>
    /// The name of the graph of this distribution in a SPARQL endpoint
    /// <see href="http://dataid.dbpedia.org/ns/core#graphName"></see></summary>
    let graphName = _prefix "graphName"
    /// <summary>
    /// Multiple files of a distribution constituting one dataset.
    /// <see href="http://dataid.dbpedia.org/ns/core#FileCollection"></see></summary>
    let FileCollection = _prefix "FileCollection"
    /// <summary>
    ///   <see href="http://dataid.dbpedia.org/ns/core#GuestAgent"></see>
    /// </summary>
    let GuestAgent = _prefix "GuestAgent"
    /// <summary>
    /// Entity representing the set of links between two datasets.
    /// <see href="http://dataid.dbpedia.org/ns/core#Linkset"></see></summary>
    let Linkset = _prefix "Linkset"
    /// <summary>
    /// A specific distribution, which is accessible via an access url and provides data as a web service in a certain format.
    /// <see href="http://dataid.dbpedia.org/ns/core#ServiceEndpoint"></see></summary>
    let ServiceEndpoint = _prefix "ServiceEndpoint"
    /// <summary>
    /// A single data dump file representing your dataset.
    /// <see href="http://dataid.dbpedia.org/ns/core#SingleFile"></see></summary>
    let SingleFile = _prefix "SingleFile"
    /// <summary>
    /// A specific distribution, which is accessible via an access url and can be queried with the SPARQL language.
    /// <see href="http://dataid.dbpedia.org/ns/core#SparqlEndpoint"></see></summary>
    let SparqlEndpoint = _prefix "SparqlEndpoint"
    /// <summary>
    /// Describes the steps which have to be taken to gain access to the described data at the location of a distribution (e.g. register an account to gain dct:accessRights).
    /// <see href="http://dataid.dbpedia.org/ns/core#accessProcedure"></see></summary>
    let accessProcedure = _prefix "accessProcedure"
    /// <summary>
    /// provides an unique identifier for this agent
    /// <see href="http://dataid.dbpedia.org/ns/core#agentId"></see></summary>
    let agentId = _prefix "agentId"
    /// <summary>
    /// uri/url provided as, or in addition to an id
    /// <see href="http://dataid.dbpedia.org/ns/core#aidURI"></see></summary>
    let aidURI = _prefix "aidURI"
    /// <summary>
    /// A crc32 checksum
    /// <see href="http://dataid.dbpedia.org/ns/core#crc32"></see></summary>
    let crc32 = _prefix "crc32"
    /// <summary>
    /// A md5 checksum
    /// <see href="http://dataid.dbpedia.org/ns/core#md5"></see></summary>
    let md5 = _prefix "md5"
    /// <summary>
    /// Set of links to another dataset contained in this dataset
    /// <see href="http://dataid.dbpedia.org/ns/core#containsLinks"></see></summary>
    let containsLinks = _prefix "containsLinks"
    /// <summary>
    /// Inverse property of dcat:distribution, linking a Distribution to a Dataset
    /// <see href="http://dataid.dbpedia.org/ns/core#isDistributionOf"></see></summary>
    let isDistributionOf = _prefix "isDistributionOf"
    /// <summary>
    /// provides the uri of a short preview of the data provided by a distribution (do not link to the download or accessURL with this property)
    /// <see href="http://dataid.dbpedia.org/ns/core#preview"></see></summary>
    let preview = _prefix "preview"
    /// <summary>
    /// points to other dataset containing related data
    /// <see href="http://dataid.dbpedia.org/ns/core#similarData"></see></summary>
    let similarData = _prefix "similarData"
    /// <summary>
    /// software needed to access the data in this distribution
    /// <see href="http://dataid.dbpedia.org/ns/core#softwareRquirement"></see></summary>
    let softwareRquirement = _prefix "softwareRquirement"
    /// <summary>
    /// Limits rights and actions an Agent is allwed to take depending on the AccessLevel chosen for this AuthorityEntityContext.
    /// <see href="http://dataid.dbpedia.org/ns/core#validForAccessLevel"></see></summary>
    let validForAccessLevel = _prefix "validForAccessLevel"
