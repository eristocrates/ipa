namespace https.w3id.org.yang.server.hash

open DoxAletheia

module server =
    let _namespace_name = "https://w3id.org/yang/server#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The candidate configuration capability, `:candidate`, indicates that the device supports a candidate configuration datastore, which is used to hold configuration data that can be manipulated without impacting the device's current configuration.
    /// <see href="https://w3id.org/yang/server#CandidateCapability"></see></summary>
    let CandidateCapability = _prefix "CandidateCapability"
    /// <summary>
    /// NETCONF capability.
    /// <see href="https://w3id.org/yang/server#NetconfCapability"></see></summary>
    let NetconfCapability = _prefix "NetconfCapability"
    /// <summary>
    /// Represents the URI that identifies the NETCONF capability.
    /// <see href="https://w3id.org/yang/server#netconfCapabilityId"></see></summary>
    let netconfCapabilityId = _prefix "netconfCapabilityId"
    /// <summary>
    /// Represents the name of the NETCONF capability.
    /// <see href="https://w3id.org/yang/server#netconfCapabilityName"></see></summary>
    let netconfCapabilityName = _prefix "netconfCapabilityName"
    /// <summary>
    /// Represents the version of the NETCONF capability.
    /// <see href="https://w3id.org/yang/server#netconfCapabilityVersion"></see></summary>
    let netconfCapabilityVersion = _prefix "netconfCapabilityVersion"
    /// <summary>
    /// A configuration datastore that can be manipulated without impacting the device's running configuration datastore and that can be committed to the running configuration datastore.
    /// <see href="https://w3id.org/yang/server#CandidateDatastore"></see></summary>
    let CandidateDatastore = _prefix "CandidateDatastore"
    /// <summary>
    /// One of the following set of configuration datastores: `&lt;running&gt;`, `&lt;startup&gt;`, `&lt;candidate&gt;`, and `&lt;intended&gt;`.  These datastores share a common datastore schema, and protocol operations allow copying data between these datastores. The term "conventional" is chosen as a generic umbrella term for these datastores.
    /// <see href="https://w3id.org/yang/server#ConventionalDatastore"></see></summary>
    let ConventionalDatastore = _prefix "ConventionalDatastore"
    /// <summary>
    /// The `:confirmed-commit:1.1` capability indicates that the server will support the `&lt;cancel-commit&gt;` operation and the `&lt;confirmed&gt;`, `&lt;confirm-timeout&gt;`, `&lt;persist&gt;`, and `&lt;persist-id&gt;` parameters for the `&lt;commit&gt;` operation.
    /// <see href="https://w3id.org/yang/server#ConfirmedCommitCapability"></see></summary>
    let ConfirmedCommitCapability = _prefix "ConfirmedCommitCapability"
    /// <summary>
    /// A conceptual place to store and access information. A datastore might be implemented, for example, using files, a database, flash memory locations, or combinations thereof. A datastore maps to an instantiated YANG data tree.
    /// <see href="https://w3id.org/yang/server#Datastore"></see></summary>
    let Datastore = _prefix "Datastore"
    /// <summary>
    /// A configuration datastore holding configuration obtained dynamically during the operation of a device through interaction with other systems, rather than through one of the conventional configuration datastores.
    /// <see href="https://w3id.org/yang/server#DynamicDatastore"></see></summary>
    let DynamicDatastore = _prefix "DynamicDatastore"
    /// <summary>
    /// Evaluation criteria that may be applied to fetch data from a given YANG server.
    /// <see href="https://w3id.org/yang/server#Filter"></see></summary>
    let Filter = _prefix "Filter"
    /// <summary>
    /// A configuration datastore holding the complete intended configuration of the device. This represents the configuration after all configuration transformations to &lt;running&gt; have been performed and is the configuration that the system attempts to apply.
    /// <see href="https://w3id.org/yang/server#IntendedDatastore"></see></summary>
    let IntendedDatastore = _prefix "IntendedDatastore"
    /// <summary>
    /// Represents an XML namespace used in the XPath expression.
    /// <see href="https://w3id.org/yang/server#Namespace"></see></summary>
    let Namespace = _prefix "Namespace"
    /// <summary>
    /// Represents a NETCONF query operation in RML mappings.
    /// <see href="https://w3id.org/yang/server#NetconfQuerySource"></see></summary>
    let NetconfQuerySource = _prefix "NetconfQuerySource"
    /// <summary>
    /// YANG server that can be managed via the NETCONF protocol.
    /// <see href="https://w3id.org/yang/server#NetconfServer"></see></summary>
    let NetconfServer = _prefix "NetconfServer"
    /// <summary>
    /// An entity that provides access to YANG-defined data to a client, over some network management protocol.
    /// <see href="https://w3id.org/yang/server#YangServer"></see></summary>
    let YangServer = _prefix "YangServer"
    /// <summary>
    /// A datastore subscription with updates that are triggered when changes in subscribed datastore nodes are detected.
    /// <see href="https://w3id.org/yang/server#OnChangeSubscription"></see></summary>
    let OnChangeSubscription = _prefix "OnChangeSubscription"
    /// <summary>
    /// Represents a subscription operation to a YANG server using the corresponding network management protocol.
    /// <see href="https://w3id.org/yang/server#Subscription"></see></summary>
    let Subscription = _prefix "Subscription"
    /// <summary>
    /// Represents a Operation to a YANG server using the corresponding network management protocol.
    /// <see href="https://w3id.org/yang/server#Operation"></see></summary>
    let Operation = _prefix "Operation"
    /// <summary>
    /// A datastore holding the complete operational state of the device.
    /// <see href="https://w3id.org/yang/server#OperationalDatastore"></see></summary>
    let OperationalDatastore = _prefix "OperationalDatastore"
    /// <summary>
    /// Represents the period interval with which to report updates in a periodic subscription.
    /// <see href="https://w3id.org/yang/server#Period"></see></summary>
    let Period = _prefix "Period"
    /// <summary>
    /// A datastore subscription with updates that are triggered periodically according to some time interval.
    /// <see href="https://w3id.org/yang/server#PeriodicSubscription"></see></summary>
    let PeriodicSubscription = _prefix "PeriodicSubscription"
    /// <summary>
    /// Represents a query operation to a YANG server using the corresponding network management protocol.
    /// <see href="https://w3id.org/yang/server#Query"></see></summary>
    let Query = _prefix "Query"
    /// <summary>
    /// This capability indicates that the server will support the `rollback-on-error` value in the `&lt;error-option&gt;` parameter to the `&lt;edit-config&gt;` operation.
    /// <see href="https://w3id.org/yang/server#RollbackOnErrorCapability"></see></summary>
    let RollbackOnErrorCapability = _prefix "RollbackOnErrorCapability"
    /// <summary>
    /// A configuration datastore holding the current configuration of the device.  It may include configuration that requires further transformations before it can be applied.
    /// <see href="https://w3id.org/yang/server#RunningDatastore"></see></summary>
    let RunningDatastore = _prefix "RunningDatastore"
    /// <summary>
    /// Represents an account used for accessing the YANG server.
    /// <see href="https://w3id.org/yang/server#ServerAccount"></see></summary>
    let ServerAccount = _prefix "ServerAccount"
    /// <summary>
    /// The device supports separate running and startup configuration datastores. The startup configuration is loaded by the device when it boots.
    /// <see href="https://w3id.org/yang/server#StartupCapability"></see></summary>
    let StartupCapability = _prefix "StartupCapability"
    /// <summary>
    /// A configuration datastore holding the configuration loaded by the device into the running configuration datastore when it boots.
    /// <see href="https://w3id.org/yang/server#StartupDatastore"></see></summary>
    let StartupDatastore = _prefix "StartupDatastore"
    /// <summary>
    /// Evaluation criteria based on XML subtree expression.
    /// <see href="https://w3id.org/yang/server#SubtreeFilter"></see></summary>
    let SubtreeFilter = _prefix "SubtreeFilter"
    /// <summary>
    /// The NETCONF peer has the ability to accept the `&lt;url&gt;` element in `&lt;source&gt;` and `&lt;target&gt;` parameters. The capability is further identified by URL arguments indicating the URL schemes supported.
    /// <see href="https://w3id.org/yang/server#UrlCapability"></see></summary>
    let UrlCapability = _prefix "UrlCapability"
    /// <summary>
    /// Validate consists of checking a complete configuration for syntactical and semantic errors before applying the configuration to the device.
    /// <see href="https://w3id.org/yang/server#ValidateCapability"></see></summary>
    let ValidateCapability = _prefix "ValidateCapability"
    /// <summary>
    /// The `:writable-running` capability indicates that the device supports direct writes to the `&lt;running&gt;` configuration datastore. In other words, the device supports `&lt;edit-config&gt;` and `&lt;copy-config&gt;` operations where the `&lt;running&gt;` configuration is the target.
    /// <see href="https://w3id.org/yang/server#WritableRunningCapability"></see></summary>
    let WritableRunningCapability = _prefix "WritableRunningCapability"
    /// <summary>
    /// Evaluation criteria based on XPath expression.
    /// <see href="https://w3id.org/yang/server#XPathFilter"></see></summary>
    let XPathFilter = _prefix "XPathFilter"
    /// <summary>
    /// The XPath capability indicates that the NETCONF peer supports the use of XPath expressions in the `&lt;filter&gt;` element.
    /// <see href="https://w3id.org/yang/server#XpathCapability"></see></summary>
    let XpathCapability = _prefix "XpathCapability"
    /// <summary>
    /// NETCONF capability that indicates that the NETCONF server implements YANG Library RFC7895.
    /// <see href="https://w3id.org/yang/server#YangLibrary1.0Capability"></see></summary>
    let ``YangLibrary1.0Capability`` = _prefix "YangLibrary1.0Capability"
    /// <summary>
    /// NETCONF capability that indicates that the NETCONF server implements YANG Library RFC8525.
    /// <see href="https://w3id.org/yang/server#YangLibrary1.1Capability"></see></summary>
    let ``YangLibrary1.1Capability`` = _prefix "YangLibrary1.1Capability"
    /// <summary>
    /// Refers to the NETCONF capability supported by the NETCONF server.
    /// <see href="https://w3id.org/yang/server#capability"></see></summary>
    let capability = _prefix "capability"
    /// <summary>
    /// Indicates the YANG datastore used by the YANG server.
    /// <see href="https://w3id.org/yang/server#datastore"></see></summary>
    let datastore = _prefix "datastore"
    /// <summary>
    /// Refers to the YANG filter used when accessing the YANG server using a network management protocol.
    /// <see href="https://w3id.org/yang/server#filter"></see></summary>
    let filter = _prefix "filter"
    /// <summary>
    /// Value used by filter to access YANG data of the NETCONF server.
    /// <see href="https://w3id.org/yang/server#filterValue"></see></summary>
    let filterValue = _prefix "filterValue"
    /// <summary>
    /// Indicates whether SSH host key is verified to access the NETCONF server.
    /// <see href="https://w3id.org/yang/server#hostKeyVerification"></see></summary>
    let hostKeyVerification = _prefix "hostKeyVerification"
    /// <summary>
    /// Refers to an XML namespace used in the XPath expression.
    /// <see href="https://w3id.org/yang/server#namespace"></see></summary>
    let namespace_ = _prefix "namespace"
    /// <summary>
    /// Prefix of the XML namespace.
    /// <see href="https://w3id.org/yang/server#namespacePrefix"></see></summary>
    let namespacePrefix = _prefix "namespacePrefix"
    /// <summary>
    /// URL of the XML namespace.
    /// <see href="https://w3id.org/yang/server#namespaceURL"></see></summary>
    let namespaceURL = _prefix "namespaceURL"
    /// <summary>
    /// Refers to period interval with which to report updates in a periodic subscription.
    /// <see href="https://w3id.org/yang/server#period"></see></summary>
    let period = _prefix "period"
    /// <summary>
    /// Refers to the YANG server that runs the YANG datastore.
    /// <see href="https://w3id.org/yang/server#server"></see></summary>
    let server = _prefix "server"
    /// <summary>
    /// Refers to the socket address for connecting to the YANG server.
    /// <see href="https://w3id.org/yang/server#socketAddress"></see></summary>
    let socketAddress = _prefix "socketAddress"
    /// <summary>
    /// Refers to the YANG datastore of the source YANG server to be selected in the YANG operation.
    /// <see href="https://w3id.org/yang/server#sourceDatastore"></see></summary>
    let sourceDatastore = _prefix "sourceDatastore"
    /// <summary>
    /// XML Subtree filter used to access YANG data of the NETCONF server.
    /// <see href="https://w3id.org/yang/server#subtreeValue"></see></summary>
    let subtreeValue = _prefix "subtreeValue"
    /// <summary>
    /// Username for accessing the YANG server.
    /// <see href="https://w3id.org/yang/server#username"></see></summary>
    let username = _prefix "username"
    /// <summary>
    /// XPath expression used to access YANG data of the YANG server.
    /// <see href="https://w3id.org/yang/server#xpathValue"></see></summary>
    let xpathValue = _prefix "xpathValue"
