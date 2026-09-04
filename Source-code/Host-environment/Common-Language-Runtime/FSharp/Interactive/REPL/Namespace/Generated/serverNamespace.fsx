#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module server =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/yang/server#" "server"
    let _namespaceIri = _prefixId.prefix ""
    let CandidateCapability = _prefixId.prefix "CandidateCapability"
    /// <summary>
    ///   <para>rdfs:label : Candidate Datastore^^xsd:string</para>
    ///   <para>rdfs:comment : A configuration datastore that can be manipulated without impacting the device's running configuration datastore and that can be committed to the running configuration datastore.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#CandidateDatastore">server:CandidateDatastore</a>
    /// </summary>
    let CandidateDatastore = _prefixId.prefix "CandidateDatastore"
    let ConfirmedCommitCapability = _prefixId.prefix "ConfirmedCommitCapability"
    /// <summary>
    ///   <para>rdfs:label : Conventional Datastore^^xsd:string</para>
    ///   <para>rdfs:comment : One of the following set of configuration datastores: `&lt;running&gt;`, `&lt;startup&gt;`, `&lt;candidate&gt;`, and `&lt;intended&gt;`.  These datastores share a common datastore schema, and protocol operations allow copying data between these datastores. The term "conventional" is chosen as a generic umbrella term for these datastores.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#ConventionalDatastore">server:ConventionalDatastore</a>
    /// </summary>
    let ConventionalDatastore = _prefixId.prefix "ConventionalDatastore"
    /// <summary>
    ///   <para>rdfs:label : Datastore^^xsd:string</para>
    ///   <para>rdfs:comment : A conceptual place to store and access information. A datastore might be implemented, for example, using files, a database, flash memory locations, or combinations thereof. A datastore maps to an instantiated YANG data tree.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#Datastore">server:Datastore</a>
    /// </summary>
    let Datastore = _prefixId.prefix "Datastore"
    /// <summary>
    ///   <para>rdfs:label : Dynamic Datastore^^xsd:string</para>
    ///   <para>rdfs:comment : A configuration datastore holding configuration obtained dynamically during the operation of a device through interaction with other systems, rather than through one of the conventional configuration datastores.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#DynamicDatastore">server:DynamicDatastore</a>
    /// </summary>
    let DynamicDatastore = _prefixId.prefix "DynamicDatastore"
    /// <summary>
    ///   <para>rdfs:label : Filter^^xsd:string</para>
    ///   <para>rdfs:comment : Evaluation criteria that may be applied to fetch data from a given YANG server.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#Filter">server:Filter</a>
    /// </summary>
    let Filter = _prefixId.prefix "Filter"
    /// <summary>
    ///   <para>rdfs:label : Intended Datastore^^xsd:string</para>
    ///   <para>rdfs:comment : A configuration datastore holding the complete intended configuration of the device. This represents the configuration after all configuration transformations to &lt;running&gt; have been performed and is the configuration that the system attempts to apply.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#IntendedDatastore">server:IntendedDatastore</a>
    /// </summary>
    let IntendedDatastore = _prefixId.prefix "IntendedDatastore"
    /// <summary>
    ///   <para>rdfs:label : Namespace^^xsd:string</para>
    ///   <para>rdfs:comment : Represents an XML namespace used in the XPath expression.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#Namespace">server:Namespace</a>
    /// </summary>
    let Namespace = _prefixId.prefix "Namespace"
    /// <summary>
    ///   <para>rdfs:label : Netconf Capability^^xsd:string</para>
    ///   <para>rdfs:comment : NETCONF capability.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#NetconfCapability">server:NetconfCapability</a>
    /// </summary>
    let NetconfCapability = _prefixId.prefix "NetconfCapability"
    /// <summary>
    ///   <para>rdfs:label : Netconf Query Source^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a NETCONF query operation in RML mappings.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#NetconfQuerySource">server:NetconfQuerySource</a>
    /// </summary>
    let NetconfQuerySource = _prefixId.prefix "NetconfQuerySource"
    /// <summary>
    ///   <para>rdfs:label : Netconf Server^^xsd:string</para>
    ///   <para>rdfs:comment : YANG server that can be managed via the NETCONF protocol.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#NetconfServer">server:NetconfServer</a>
    /// </summary>
    let NetconfServer = _prefixId.prefix "NetconfServer"
    /// <summary>
    ///   <para>rdfs:label : On-change Subscription^^xsd:string</para>
    ///   <para>rdfs:comment : A datastore subscription with updates that are triggered when changes in subscribed datastore nodes are detected.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#OnChangeSubscription">server:OnChangeSubscription</a>
    /// </summary>
    let OnChangeSubscription = _prefixId.prefix "OnChangeSubscription"
    /// <summary>
    ///   <para>rdfs:label : Operation^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a Operation to a YANG server using the corresponding network management protocol.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#Operation">server:Operation</a>
    /// </summary>
    let Operation = _prefixId.prefix "Operation"
    /// <summary>
    ///   <para>rdfs:label : Operational Datastore^^xsd:string</para>
    ///   <para>rdfs:comment : A datastore holding the complete operational state of the device.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#OperationalDatastore">server:OperationalDatastore</a>
    /// </summary>
    let OperationalDatastore = _prefixId.prefix "OperationalDatastore"
    /// <summary>
    ///   <para>rdfs:label : Period^^xsd:string</para>
    ///   <para>rdfs:comment : Represents the period interval with which to report updates in a periodic subscription.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#Period">server:Period</a>
    /// </summary>
    let Period = _prefixId.prefix "Period"
    /// <summary>
    ///   <para>rdfs:label : Periodic Subscription^^xsd:string</para>
    ///   <para>rdfs:comment : A datastore subscription with updates that are triggered periodically according to some time interval.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#PeriodicSubscription">server:PeriodicSubscription</a>
    /// </summary>
    let PeriodicSubscription = _prefixId.prefix "PeriodicSubscription"
    /// <summary>
    ///   <para>rdfs:label : Query^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a query operation to a YANG server using the corresponding network management protocol.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#Query">server:Query</a>
    /// </summary>
    let Query = _prefixId.prefix "Query"
    let RollbackOnErrorCapability = _prefixId.prefix "RollbackOnErrorCapability"
    /// <summary>
    ///   <para>rdfs:label : Running Datastore^^xsd:string</para>
    ///   <para>rdfs:comment : A configuration datastore holding the current configuration of the device.  It may include configuration that requires further transformations before it can be applied.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#RunningDatastore">server:RunningDatastore</a>
    /// </summary>
    let RunningDatastore = _prefixId.prefix "RunningDatastore"
    /// <summary>
    ///   <para>rdfs:label : Server Account^^xsd:string</para>
    ///   <para>rdfs:comment : Represents an account used for accessing the YANG server.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#ServerAccount">server:ServerAccount</a>
    /// </summary>
    let ServerAccount = _prefixId.prefix "ServerAccount"
    let StartupCapability = _prefixId.prefix "StartupCapability"
    /// <summary>
    ///   <para>rdfs:label : Startup Datastore^^xsd:string</para>
    ///   <para>rdfs:comment : A configuration datastore holding the configuration loaded by the device into the running configuration datastore when it boots.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#StartupDatastore">server:StartupDatastore</a>
    /// </summary>
    let StartupDatastore = _prefixId.prefix "StartupDatastore"
    /// <summary>
    ///   <para>rdfs:label : Subscription^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a subscription operation to a YANG server using the corresponding network management protocol.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#Subscription">server:Subscription</a>
    /// </summary>
    let Subscription = _prefixId.prefix "Subscription"
    /// <summary>
    ///   <para>rdfs:label : Subtree Filter^^xsd:string</para>
    ///   <para>rdfs:comment : Evaluation criteria based on XML subtree expression.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#SubtreeFilter">server:SubtreeFilter</a>
    /// </summary>
    let SubtreeFilter = _prefixId.prefix "SubtreeFilter"
    let UrlCapability = _prefixId.prefix "UrlCapability"
    let ValidateCapability = _prefixId.prefix "ValidateCapability"
    let WritableRunningCapability = _prefixId.prefix "WritableRunningCapability"
    /// <summary>
    ///   <para>rdfs:label : XPath Filter^^xsd:string</para>
    ///   <para>rdfs:comment : Evaluation criteria based on XPath expression.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#XPathFilter">server:XPathFilter</a>
    /// </summary>
    let XPathFilter = _prefixId.prefix "XPathFilter"
    let XpathCapability = _prefixId.prefix "XpathCapability"
    let ``YangLibrary1.0Capability`` = _prefixId.prefix "YangLibrary1.0Capability"
    let ``YangLibrary1.1Capability`` = _prefixId.prefix "YangLibrary1.1Capability"
    /// <summary>
    ///   <para>rdfs:label : Yang Server^^xsd:string</para>
    ///   <para>rdfs:comment : An entity that provides access to YANG-defined data to a client, over some network management protocol.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#YangServer">server:YangServer</a>
    /// </summary>
    let YangServer = _prefixId.prefix "YangServer"
    /// <summary>
    ///   <para>rdfs:label : capability^^xsd:string</para>
    ///   <para>rdfs:comment : Refers to the NETCONF capability supported by the NETCONF server.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#capability">server:capability</a>
    /// </summary>
    let capability = _prefixId.prefix "capability"
    /// <summary>
    ///   <para>rdfs:label : datastore^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the YANG datastore used by the YANG server.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#datastore">server:datastore</a>
    /// </summary>
    let datastore = _prefixId.prefix "datastore"
    /// <summary>
    ///   <para>rdfs:label : filter^^xsd:string</para>
    ///   <para>rdfs:comment : Refers to the YANG filter used when accessing the YANG server using a network management protocol.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#filter">server:filter</a>
    /// </summary>
    let filter = _prefixId.prefix "filter"
    /// <summary>
    ///   <para>rdfs:label : filter value^^xsd:string</para>
    ///   <para>rdfs:comment : Value used by filter to access YANG data of the NETCONF server.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#filterValue">server:filterValue</a>
    /// </summary>
    let filterValue = _prefixId.prefix "filterValue"
    /// <summary>
    ///   <para>rdfs:label : host key verification^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates whether SSH host key is verified to access the NETCONF server.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#hostKeyVerification">server:hostKeyVerification</a>
    /// </summary>
    let hostKeyVerification = _prefixId.prefix "hostKeyVerification"
    /// <summary>
    ///   <para>rdfs:label : namespace^^xsd:string</para>
    ///   <para>rdfs:comment : Refers to an XML namespace used in the XPath expression.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#namespace">server:namespace</a>
    /// </summary>
    let namespace_ = _prefixId.prefix "namespace"
    /// <summary>
    ///   <para>rdfs:label : namespace prefix^^xsd:string</para>
    ///   <para>rdfs:comment : Prefix of the XML namespace.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#namespacePrefix">server:namespacePrefix</a>
    /// </summary>
    let namespacePrefix = _prefixId.prefix "namespacePrefix"
    /// <summary>
    ///   <para>rdfs:label : namespace url^^xsd:string</para>
    ///   <para>rdfs:comment : URL of the XML namespace.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#namespaceURL">server:namespaceURL</a>
    /// </summary>
    let namespaceURL = _prefixId.prefix "namespaceURL"
    /// <summary>
    ///   <para>rdfs:label : netconf capability id^^xsd:string</para>
    ///   <para>rdfs:comment : Represents the URI that identifies the NETCONF capability.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#netconfCapabilityId">server:netconfCapabilityId</a>
    /// </summary>
    let netconfCapabilityId = _prefixId.prefix "netconfCapabilityId"
    /// <summary>
    ///   <para>rdfs:label : netconf capability name^^xsd:string</para>
    ///   <para>rdfs:comment : Represents the name of the NETCONF capability.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#netconfCapabilityName">server:netconfCapabilityName</a>
    /// </summary>
    let netconfCapabilityName = _prefixId.prefix "netconfCapabilityName"
    /// <summary>
    ///   <para>rdfs:label : netconf capability version^^xsd:string</para>
    ///   <para>rdfs:comment : Represents the version of the NETCONF capability.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#netconfCapabilityVersion">server:netconfCapabilityVersion</a>
    /// </summary>
    let netconfCapabilityVersion = _prefixId.prefix "netconfCapabilityVersion"
    /// <summary>
    ///   <para>rdfs:label : period^^xsd:string</para>
    ///   <para>rdfs:comment : Refers to period interval with which to report updates in a periodic subscription.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#period">server:period</a>
    /// </summary>
    let period = _prefixId.prefix "period"
    /// <summary>
    ///   <para>rdfs:label : server^^xsd:string</para>
    ///   <para>rdfs:comment : Refers to the YANG server that runs the YANG datastore.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#server">server:server</a>
    /// </summary>
    let server = _prefixId.prefix "server"
    /// <summary>
    ///   <para>rdfs:label : socket address^^xsd:string</para>
    ///   <para>rdfs:comment : Refers to the socket address for connecting to the YANG server.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#socketAddress">server:socketAddress</a>
    /// </summary>
    let socketAddress = _prefixId.prefix "socketAddress"
    /// <summary>
    ///   <para>rdfs:label : source datastore^^xsd:string</para>
    ///   <para>rdfs:comment : Refers to the YANG datastore of the source YANG server to be selected in the YANG operation.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#sourceDatastore">server:sourceDatastore</a>
    /// </summary>
    let sourceDatastore = _prefixId.prefix "sourceDatastore"
    /// <summary>
    ///   <para>vann:example :
    /// &lt;interfaces xmlns="urn:ietf:params:xml:ns:yang:ietf-interfaces"&gt;
    ///   &lt;interface&gt;
    ///   &lt;/interface&gt;
    /// &lt;/interfaces&gt;^^xsd:string</para>
    ///   <para>rdfs:label : subtree value^^xsd:string</para>
    ///   <para>rdfs:comment : XML Subtree filter used to access YANG data of the NETCONF server.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#subtreeValue">server:subtreeValue</a>
    /// </summary>
    let subtreeValue = _prefixId.prefix "subtreeValue"
    /// <summary>
    ///   <para>rdfs:label : username^^xsd:string</para>
    ///   <para>rdfs:comment : Username for accessing the YANG server.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#username">server:username</a>
    /// </summary>
    let username = _prefixId.prefix "username"
    /// <summary>
    ///   <para>vann:example : /ietf-interfaces:interfaces^^xsd:string</para>
    ///   <para>rdfs:label : xpath value^^xsd:string</para>
    ///   <para>rdfs:comment : XPath expression used to access YANG data of the YANG server.^^xsd:string</para>
    ///   <a href="https://w3id.org/yang/server#xpathValue">server:xpathValue</a>
    /// </summary>
    let xpathValue = _prefixId.prefix "xpathValue"
