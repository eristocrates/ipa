namespace http.dataid.dbpedia.org.ns.core.hash

open DoxAletheia.Rdf_Vocabulary

module dataid =
    let _namespace_name = "http://dataid.dbpedia.org/ns/core#"

    /// <summary>
    /// The level of openness of access to particular groups of agents
    /// <see href="http://dataid.dbpedia.org/ns/core#AccessLevel"></see></summary>
    let AccessLevel =
        Namespaced_IRI.parse _namespace_name "AccessLevel" |> NamespacedName

    /// <summary>
    /// Provides an agent with unrestricted access and all rights of a resource.
    /// <see href="http://dataid.dbpedia.org/ns/core#PrivateAccess"></see></summary>
    let PrivateAccess =
        Namespaced_IRI.parse _namespace_name "PrivateAccess" |> NamespacedName

    /// <summary>
    /// Limits the rights an agent has on a resource to read and modify.
    /// <see href="http://dataid.dbpedia.org/ns/core#SemiPrivateAccess"></see></summary>
    let SemiPrivateAccess =
        Namespaced_IRI.parse _namespace_name "SemiPrivateAccess" |> NamespacedName

    /// <summary>
    /// Limits the rights an agent has on a resource to read rights.
    /// <see href="http://dataid.dbpedia.org/ns/core#PublicAccess"></see></summary>
    let PublicAccess =
        Namespaced_IRI.parse _namespace_name "PublicAccess" |> NamespacedName

    /// <summary>
    /// Disallows access to a resource for an agent.
    /// <see href="http://dataid.dbpedia.org/ns/core#NoAccess"></see></summary>
    let NoAccess = Namespaced_IRI.parse _namespace_name "NoAccess" |> NamespacedName
    /// <summary>
    /// Any type of agent without a specific function.
    /// <see href="http://dataid.dbpedia.org/ns/core#Agent"></see></summary>
    let Agent = Namespaced_IRI.parse _namespace_name "Agent" |> NamespacedName

    /// <summary>
    /// Uniquly identifies an agent given a identifier and a correspondng aid/pid system (ORCID, ResearcherID etc.).
    /// <see href="http://dataid.dbpedia.org/ns/core#AgentIdentifier"></see></summary>
    let AgentIdentifier =
        Namespaced_IRI.parse _namespace_name "AgentIdentifier" |> NamespacedName

    /// <summary>
    /// the id of an agent as string
    /// <see href="http://dataid.dbpedia.org/ns/core#aid"></see></summary>
    let aid = Namespaced_IRI.parse _namespace_name "aid" |> NamespacedName
    /// <summary>
    /// the aid/pid system used for this identifier (ORCID, ResearcherID etc.)
    /// <see href="http://dataid.dbpedia.org/ns/core#aidSystem"></see></summary>
    let aidSystem = Namespaced_IRI.parse _namespace_name "aidSystem" |> NamespacedName
    /// <summary>
    /// Instances of this class define an array of rights and responsibilities an agent, assigned with this role for a given scope of entities, has to address or can execute.
    /// <see href="http://dataid.dbpedia.org/ns/core#AgentRole"></see></summary>
    let AgentRole = Namespaced_IRI.parse _namespace_name "AgentRole" |> NamespacedName
    /// <summary>
    /// AgentRoles allows an agent to execute certain actions.
    /// <see href="http://dataid.dbpedia.org/ns/core#allowsFor"></see></summary>
    let allowsFor = Namespaced_IRI.parse _namespace_name "allowsFor" |> NamespacedName
    /// <summary>
    /// A visitor/anonymous agent has only read rights on public and semi-private documents
    /// <see href="http://dataid.dbpedia.org/ns/core#Guest"></see></summary>
    let Guest = Namespaced_IRI.parse _namespace_name "Guest" |> NamespacedName
    /// <summary>
    /// Creator of the resource. An agent that is credited with a main part in the initial creation of the resource.
    /// <see href="http://dataid.dbpedia.org/ns/core#Creator"></see></summary>
    let Creator = Namespaced_IRI.parse _namespace_name "Creator" |> NamespacedName

    /// <summary>
    /// Contributor to the resource. An agent that was involved in creating or maintaining the resource but does not have the main part in this activity.
    /// <see href="http://dataid.dbpedia.org/ns/core#Contributor"></see></summary>
    let Contributor =
        Namespaced_IRI.parse _namespace_name "Contributor" |> NamespacedName

    /// <summary>
    /// Maintainer of the dataset. An agent that ensures the technical correctness, accessibility and up-to-dateness of a dataset.
    /// <see href="http://dataid.dbpedia.org/ns/core#Maintainer"></see></summary>
    let Maintainer = Namespaced_IRI.parse _namespace_name "Maintainer" |> NamespacedName
    /// <summary>
    /// Publisher of the dataset. An agent that makes the dataset accessible online on a server or repository without necessarily being involved in its creation.
    /// <see href="http://dataid.dbpedia.org/ns/core#Publisher"></see></summary>
    let Publisher = Namespaced_IRI.parse _namespace_name "Publisher" |> NamespacedName
    /// <summary>
    /// Contact agent. An agent that can be contacted for general requests about the resource.
    /// <see href="http://dataid.dbpedia.org/ns/core#Contact"></see></summary>
    let Contact = Namespaced_IRI.parse _namespace_name "Contact" |> NamespacedName

    /// <summary>
    /// The responsibility to supervise other agents.
    /// <see href="http://dataid.dbpedia.org/ns/core#AgentSupervision"></see></summary>
    let AgentSupervision =
        Namespaced_IRI.parse _namespace_name "AgentSupervision" |> NamespacedName

    /// <summary>
    /// AgentRoles provide access rights as well as responsibilities an agent has to attend to in order to fullfill this role. Responsible actions should describe actions pertaining to responsibilities an agent is supposed to do.
    /// <see href="http://dataid.dbpedia.org/ns/core#ResponsibleAction"></see></summary>
    let ResponsibleAction =
        Namespaced_IRI.parse _namespace_name "ResponsibleAction" |> NamespacedName

    /// <summary>
    /// This concept defines a scope of Entities and links it to an Agent which has certain rights for those entities (defined by the AgentRole). This scope consists of all Entities directly linked to the context, as well as transitively dependend Entities
    /// <see href="http://dataid.dbpedia.org/ns/core#AuthorityEntityContext"></see></summary>
    let AuthorityEntityContext =
        Namespaced_IRI.parse _namespace_name "AuthorityEntityContext" |> NamespacedName

    /// <summary>
    /// Defines that a context keeps intact for the next version of a DataID (if set to 'true').
    /// The property of certain authority entity context to be able to be inherited
    /// <see href="http://dataid.dbpedia.org/ns/core#isInheritable"></see></summary>
    let isInheritable =
        Namespaced_IRI.parse _namespace_name "isInheritable" |> NamespacedName

    /// <summary>
    /// Adds a role an agent can administer in the scope provided by the AuthorityEntityContext, thereby allowing for certain actions an agent can execute.
    /// <see href="http://dataid.dbpedia.org/ns/core#authorityAgentRole"></see></summary>
    let authorityAgentRole =
        Namespaced_IRI.parse _namespace_name "authorityAgentRole" |> NamespacedName

    /// <summary>
    /// An AuthorityEntityContext is valid for a specific Agent until a certain point in time.
    /// <see href="http://dataid.dbpedia.org/ns/core#validUntil"></see></summary>
    let validUntil = Namespaced_IRI.parse _namespace_name "validUntil" |> NamespacedName
    /// <summary>
    /// An AuthorityEntityContext is valid for a specific Agent from a certain point in time.
    /// <see href="http://dataid.dbpedia.org/ns/core#validFrom"></see></summary>
    let validFrom = Namespaced_IRI.parse _namespace_name "validFrom" |> NamespacedName

    /// <summary>
    /// Defines the scope of an authority-context. An Agent has the right to execute authorized actions in this scope (e.g. a single DataId and all it's members).
    /// <see href="http://dataid.dbpedia.org/ns/core#authorizedFor"></see></summary>
    let authorizedFor =
        Namespaced_IRI.parse _namespace_name "authorizedFor" |> NamespacedName

    /// <summary>
    /// Provides an agent the ability to execute authorized actions in a certain scope (e.g. to modify the metadata of a dataset)
    /// <see href="http://dataid.dbpedia.org/ns/core#authorizedAgent"></see></summary>
    let authorizedAgent =
        Namespaced_IRI.parse _namespace_name "authorizedAgent" |> NamespacedName

    /// <summary>
    /// AgentRoles provide agents with the ability to execute certain actions as well as demand certain responsibilities, which are defines by the instances of this concept.
    /// <see href="http://dataid.dbpedia.org/ns/core#AuthorizedAction"></see></summary>
    let AuthorizedAction =
        Namespaced_IRI.parse _namespace_name "AuthorizedAction" |> NamespacedName

    /// <summary>
    /// AgentRoles provide access and modification rights to an agent. Entitled actions should comprise actions pertaining to access/modification restrictions.
    /// <see href="http://dataid.dbpedia.org/ns/core#EntitledAction"></see></summary>
    let EntitledAction =
        Namespaced_IRI.parse _namespace_name "EntitledAction" |> NamespacedName

    /// <summary>
    /// Entitled action to modify the content of an entity.
    /// <see href="http://dataid.dbpedia.org/ns/core#ModifyContent"></see></summary>
    let ModifyContent =
        Namespaced_IRI.parse _namespace_name "ModifyContent" |> NamespacedName

    /// <summary>
    /// Entitled action to read the content of an entity.
    /// <see href="http://dataid.dbpedia.org/ns/core#ReadContent"></see></summary>
    let ReadContent =
        Namespaced_IRI.parse _namespace_name "ReadContent" |> NamespacedName

    /// <summary>
    /// Entitled action to read the DataID dataset metadata
    /// <see href="http://dataid.dbpedia.org/ns/core#ReadDataId"></see></summary>
    let ReadDataId = Namespaced_IRI.parse _namespace_name "ReadDataId" |> NamespacedName

    /// <summary>
    /// The responsibility to respond to contact attempts by external agents. A contact point for the entity.
    /// <see href="http://dataid.dbpedia.org/ns/core#ResponseToContact"></see></summary>
    let ResponseToContact =
        Namespaced_IRI.parse _namespace_name "ResponseToContact" |> NamespacedName

    /// <summary>
    /// Entitled action to modify the role of agents on certain entities.
    /// <see href="http://dataid.dbpedia.org/ns/core#ModifyAgentRoles"></see></summary>
    let ModifyAgentRoles =
        Namespaced_IRI.parse _namespace_name "ModifyAgentRoles" |> NamespacedName

    /// <summary>
    /// Entitled action to modify access level of an entity.
    /// <see href="http://dataid.dbpedia.org/ns/core#ModifyAccessLevel"></see></summary>
    let ModifyAccessLevel =
        Namespaced_IRI.parse _namespace_name "ModifyAccessLevel" |> NamespacedName

    /// <summary>
    /// Entitled action to delete some content of an entity.
    /// <see href="http://dataid.dbpedia.org/ns/core#DeleteContent"></see></summary>
    let DeleteContent =
        Namespaced_IRI.parse _namespace_name "DeleteContent" |> NamespacedName

    /// <summary>
    /// The responsibility to update dataset metadata.
    /// <see href="http://dataid.dbpedia.org/ns/core#UpdateDataId"></see></summary>
    let UpdateDataId =
        Namespaced_IRI.parse _namespace_name "UpdateDataId" |> NamespacedName

    /// <summary>
    /// The responsibility decide if the entity should be published
    /// <see href="http://dataid.dbpedia.org/ns/core#PublishingDecision"></see></summary>
    let PublishingDecision =
        Namespaced_IRI.parse _namespace_name "PublishingDecision" |> NamespacedName

    /// <summary>
    /// Entitled action to modify which agents are authorized on certain entities.
    /// <see href="http://dataid.dbpedia.org/ns/core#ModifyAuthorizedAgents"></see></summary>
    let ModifyAuthorizedAgents =
        Namespaced_IRI.parse _namespace_name "ModifyAuthorizedAgents" |> NamespacedName

    /// <summary>
    /// The responsibility to manage changes and react to bugs and issues that are reported
    /// <see href="http://dataid.dbpedia.org/ns/core#ResponseToLifeCycleEvent"></see></summary>
    let ResponseToLifeCycleEvent =
        Namespaced_IRI.parse _namespace_name "ResponseToLifeCycleEvent" |> NamespacedName

    /// <summary>
    /// A description of one or more datasets. The DataID itself.
    /// <see href="http://dataid.dbpedia.org/ns/core#DataId"></see></summary>
    let DataId = Namespaced_IRI.parse _namespace_name "DataId" |> NamespacedName

    /// <summary>
    /// defines the access rights for DataId related entities
    /// <see href="http://dataid.dbpedia.org/ns/core#hasAccessLevel"></see></summary>
    let hasAccessLevel =
        Namespaced_IRI.parse _namespace_name "hasAccessLevel" |> NamespacedName

    /// <summary>
    /// Points out a dataid:AuthorityEntityContext pertaining to this resource.
    /// <see href="http://dataid.dbpedia.org/ns/core#hasEntityContext"></see></summary>
    let hasEntityContext =
        Namespaced_IRI.parse _namespace_name "hasEntityContext" |> NamespacedName

    /// <summary>
    /// A collection of data, available for access in one or more formats. Dataset resources describe the concept of the dataset, not it's manifestation (the data itself), which can be acquired as Distribution.
    ///     Datasets are prov:Entities and can be generated by prov:Activities.
    /// <see href="http://dataid.dbpedia.org/ns/core#Dataset"></see></summary>
    let Dataset = Namespaced_IRI.parse _namespace_name "Dataset" |> NamespacedName

    /// <summary>
    /// Latest version of a DataIdPart
    /// <see href="http://dataid.dbpedia.org/ns/core#latestVersion"></see></summary>
    let latestVersion =
        Namespaced_IRI.parse _namespace_name "latestVersion" |> NamespacedName

    /// <summary>
    /// Next version of a DataIdPart
    /// <see href="http://dataid.dbpedia.org/ns/core#nextVersion"></see></summary>
    let nextVersion =
        Namespaced_IRI.parse _namespace_name "nextVersion" |> NamespacedName

    /// <summary>
    /// provides a version string for any entity
    /// <see href="http://dataid.dbpedia.org/ns/core#version"></see></summary>
    let version = Namespaced_IRI.parse _namespace_name "version" |> NamespacedName

    /// <summary>
    /// previous version of a DataIdPart
    /// <see href="http://dataid.dbpedia.org/ns/core#previousVersion"></see></summary>
    let previousVersion =
        Namespaced_IRI.parse _namespace_name "previousVersion" |> NamespacedName

    /// <summary>
    /// some agent generally connected to the dataset, their function to be specified by their rdf:type
    /// <see href="http://dataid.dbpedia.org/ns/core#associatedAgent"></see></summary>
    let associatedAgent =
        Namespaced_IRI.parse _namespace_name "associatedAgent" |> NamespacedName

    /// <summary>
    /// A way to access a dataset, like a dump file, an endpoint, an API etc.
    /// <see href="http://dataid.dbpedia.org/ns/core#Distribution"></see></summary>
    let Distribution =
        Namespaced_IRI.parse _namespace_name "Distribution" |> NamespacedName

    /// <summary>
    /// A dedicated directory holding multiple files of the same dataset.
    /// <see href="http://dataid.dbpedia.org/ns/core#Directory"></see></summary>
    let Directory = Namespaced_IRI.parse _namespace_name "Directory" |> NamespacedName
    /// <summary>
    /// Checksum of a file to check for correctness
    /// <see href="http://dataid.dbpedia.org/ns/core#checksum"></see></summary>
    let checksum = Namespaced_IRI.parse _namespace_name "checksum" |> NamespacedName
    /// <summary>
    /// The name of the graph of this distribution in a SPARQL endpoint
    /// <see href="http://dataid.dbpedia.org/ns/core#graphName"></see></summary>
    let graphName = Namespaced_IRI.parse _namespace_name "graphName" |> NamespacedName

    /// <summary>
    /// Multiple files of a distribution constituting one dataset.
    /// <see href="http://dataid.dbpedia.org/ns/core#FileCollection"></see></summary>
    let FileCollection =
        Namespaced_IRI.parse _namespace_name "FileCollection" |> NamespacedName

    /// <summary>
    ///   <see href="http://dataid.dbpedia.org/ns/core#GuestAgent"></see>
    /// </summary>
    let GuestAgent = Namespaced_IRI.parse _namespace_name "GuestAgent" |> NamespacedName
    /// <summary>
    /// Entity representing the set of links between two datasets.
    /// <see href="http://dataid.dbpedia.org/ns/core#Linkset"></see></summary>
    let Linkset = Namespaced_IRI.parse _namespace_name "Linkset" |> NamespacedName

    /// <summary>
    /// A specific distribution, which is accessible via an access url and provides data as a web service in a certain format.
    /// <see href="http://dataid.dbpedia.org/ns/core#ServiceEndpoint"></see></summary>
    let ServiceEndpoint =
        Namespaced_IRI.parse _namespace_name "ServiceEndpoint" |> NamespacedName

    /// <summary>
    /// A single data dump file representing your dataset.
    /// <see href="http://dataid.dbpedia.org/ns/core#SingleFile"></see></summary>
    let SingleFile = Namespaced_IRI.parse _namespace_name "SingleFile" |> NamespacedName

    /// <summary>
    /// A specific distribution, which is accessible via an access url and can be queried with the SPARQL language.
    /// <see href="http://dataid.dbpedia.org/ns/core#SparqlEndpoint"></see></summary>
    let SparqlEndpoint =
        Namespaced_IRI.parse _namespace_name "SparqlEndpoint" |> NamespacedName

    /// <summary>
    /// Describes the steps which have to be taken to gain access to the described data at the location of a distribution (e.g. register an account to gain dct:accessRights).
    /// <see href="http://dataid.dbpedia.org/ns/core#accessProcedure"></see></summary>
    let accessProcedure =
        Namespaced_IRI.parse _namespace_name "accessProcedure" |> NamespacedName

    /// <summary>
    /// provides an unique identifier for this agent
    /// <see href="http://dataid.dbpedia.org/ns/core#agentId"></see></summary>
    let agentId = Namespaced_IRI.parse _namespace_name "agentId" |> NamespacedName
    /// <summary>
    /// uri/url provided as, or in addition to an id
    /// <see href="http://dataid.dbpedia.org/ns/core#aidURI"></see></summary>
    let aidURI = Namespaced_IRI.parse _namespace_name "aidURI" |> NamespacedName
    /// <summary>
    /// A crc32 checksum
    /// <see href="http://dataid.dbpedia.org/ns/core#crc32"></see></summary>
    let crc32 = Namespaced_IRI.parse _namespace_name "crc32" |> NamespacedName
    /// <summary>
    /// A md5 checksum
    /// <see href="http://dataid.dbpedia.org/ns/core#md5"></see></summary>
    let md5 = Namespaced_IRI.parse _namespace_name "md5" |> NamespacedName

    /// <summary>
    /// Set of links to another dataset contained in this dataset
    /// <see href="http://dataid.dbpedia.org/ns/core#containsLinks"></see></summary>
    let containsLinks =
        Namespaced_IRI.parse _namespace_name "containsLinks" |> NamespacedName

    /// <summary>
    /// Inverse property of dcat:distribution, linking a Distribution to a Dataset
    /// <see href="http://dataid.dbpedia.org/ns/core#isDistributionOf"></see></summary>
    let isDistributionOf =
        Namespaced_IRI.parse _namespace_name "isDistributionOf" |> NamespacedName

    /// <summary>
    /// provides the uri of a short preview of the data provided by a distribution (do not link to the download or accessURL with this property)
    /// <see href="http://dataid.dbpedia.org/ns/core#preview"></see></summary>
    let preview = Namespaced_IRI.parse _namespace_name "preview" |> NamespacedName

    /// <summary>
    /// points to other dataset containing related data
    /// <see href="http://dataid.dbpedia.org/ns/core#similarData"></see></summary>
    let similarData =
        Namespaced_IRI.parse _namespace_name "similarData" |> NamespacedName

    /// <summary>
    /// software needed to access the data in this distribution
    /// <see href="http://dataid.dbpedia.org/ns/core#softwareRquirement"></see></summary>
    let softwareRquirement =
        Namespaced_IRI.parse _namespace_name "softwareRquirement" |> NamespacedName

    /// <summary>
    /// Limits rights and actions an Agent is allwed to take depending on the AccessLevel chosen for this AuthorityEntityContext.
    /// <see href="http://dataid.dbpedia.org/ns/core#validForAccessLevel"></see></summary>
    let validForAccessLevel =
        Namespaced_IRI.parse _namespace_name "validForAccessLevel" |> NamespacedName
