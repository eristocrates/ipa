namespace https.w3id.org.yang.server.hash

open DoxAletheia.Rdf_Vocabulary

module server =
    let _namespace_name = "https://w3id.org/yang/server#"

    /// <summary>
    /// The candidate configuration capability, `:candidate`, indicates that the device supports a candidate configuration datastore, which is used to hold configuration data that can be manipulated without impacting the device's current configuration.
    /// <see href="https://w3id.org/yang/server#CandidateCapability"></see></summary>
    let CandidateCapability =
        Namespaced_IRI.parse _namespace_name "CandidateCapability" |> NamespacedName

    /// <summary>
    /// NETCONF capability.
    /// <see href="https://w3id.org/yang/server#NetconfCapability"></see></summary>
    let NetconfCapability =
        Namespaced_IRI.parse _namespace_name "NetconfCapability" |> NamespacedName

    /// <summary>
    /// Represents the URI that identifies the NETCONF capability.
    /// <see href="https://w3id.org/yang/server#netconfCapabilityId"></see></summary>
    let netconfCapabilityId =
        Namespaced_IRI.parse _namespace_name "netconfCapabilityId" |> NamespacedName

    /// <summary>
    /// Represents the name of the NETCONF capability.
    /// <see href="https://w3id.org/yang/server#netconfCapabilityName"></see></summary>
    let netconfCapabilityName =
        Namespaced_IRI.parse _namespace_name "netconfCapabilityName" |> NamespacedName

    /// <summary>
    /// Represents the version of the NETCONF capability.
    /// <see href="https://w3id.org/yang/server#netconfCapabilityVersion"></see></summary>
    let netconfCapabilityVersion =
        Namespaced_IRI.parse _namespace_name "netconfCapabilityVersion" |> NamespacedName

    /// <summary>
    /// A configuration datastore that can be manipulated without impacting the device's running configuration datastore and that can be committed to the running configuration datastore.
    /// <see href="https://w3id.org/yang/server#CandidateDatastore"></see></summary>
    let CandidateDatastore =
        Namespaced_IRI.parse _namespace_name "CandidateDatastore" |> NamespacedName

    /// <summary>
    /// One of the following set of configuration datastores: `&lt;running&gt;`, `&lt;startup&gt;`, `&lt;candidate&gt;`, and `&lt;intended&gt;`.  These datastores share a common datastore schema, and protocol operations allow copying data between these datastores. The term "conventional" is chosen as a generic umbrella term for these datastores.
    /// <see href="https://w3id.org/yang/server#ConventionalDatastore"></see></summary>
    let ConventionalDatastore =
        Namespaced_IRI.parse _namespace_name "ConventionalDatastore" |> NamespacedName

    /// <summary>
    /// The `:confirmed-commit:1.1` capability indicates that the server will support the `&lt;cancel-commit&gt;` operation and the `&lt;confirmed&gt;`, `&lt;confirm-timeout&gt;`, `&lt;persist&gt;`, and `&lt;persist-id&gt;` parameters for the `&lt;commit&gt;` operation.
    /// <see href="https://w3id.org/yang/server#ConfirmedCommitCapability"></see></summary>
    let ConfirmedCommitCapability =
        Namespaced_IRI.parse _namespace_name "ConfirmedCommitCapability" |> NamespacedName

    /// <summary>
    /// A conceptual place to store and access information. A datastore might be implemented, for example, using files, a database, flash memory locations, or combinations thereof. A datastore maps to an instantiated YANG data tree.
    /// <see href="https://w3id.org/yang/server#Datastore"></see></summary>
    let Datastore = Namespaced_IRI.parse _namespace_name "Datastore" |> NamespacedName

    /// <summary>
    /// A configuration datastore holding configuration obtained dynamically during the operation of a device through interaction with other systems, rather than through one of the conventional configuration datastores.
    /// <see href="https://w3id.org/yang/server#DynamicDatastore"></see></summary>
    let DynamicDatastore =
        Namespaced_IRI.parse _namespace_name "DynamicDatastore" |> NamespacedName

    /// <summary>
    /// Evaluation criteria that may be applied to fetch data from a given YANG server.
    /// <see href="https://w3id.org/yang/server#Filter"></see></summary>
    let Filter = Namespaced_IRI.parse _namespace_name "Filter" |> NamespacedName

    /// <summary>
    /// A configuration datastore holding the complete intended configuration of the device. This represents the configuration after all configuration transformations to &lt;running&gt; have been performed and is the configuration that the system attempts to apply.
    /// <see href="https://w3id.org/yang/server#IntendedDatastore"></see></summary>
    let IntendedDatastore =
        Namespaced_IRI.parse _namespace_name "IntendedDatastore" |> NamespacedName

    /// <summary>
    /// Represents an XML namespace used in the XPath expression.
    /// <see href="https://w3id.org/yang/server#Namespace"></see></summary>
    let Namespace = Namespaced_IRI.parse _namespace_name "Namespace" |> NamespacedName

    /// <summary>
    /// Represents a NETCONF query operation in RML mappings.
    /// <see href="https://w3id.org/yang/server#NetconfQuerySource"></see></summary>
    let NetconfQuerySource =
        Namespaced_IRI.parse _namespace_name "NetconfQuerySource" |> NamespacedName

    /// <summary>
    /// YANG server that can be managed via the NETCONF protocol.
    /// <see href="https://w3id.org/yang/server#NetconfServer"></see></summary>
    let NetconfServer =
        Namespaced_IRI.parse _namespace_name "NetconfServer" |> NamespacedName

    /// <summary>
    /// An entity that provides access to YANG-defined data to a client, over some network management protocol.
    /// <see href="https://w3id.org/yang/server#YangServer"></see></summary>
    let YangServer = Namespaced_IRI.parse _namespace_name "YangServer" |> NamespacedName

    /// <summary>
    /// A datastore subscription with updates that are triggered when changes in subscribed datastore nodes are detected.
    /// <see href="https://w3id.org/yang/server#OnChangeSubscription"></see></summary>
    let OnChangeSubscription =
        Namespaced_IRI.parse _namespace_name "OnChangeSubscription" |> NamespacedName

    /// <summary>
    /// Represents a subscription operation to a YANG server using the corresponding network management protocol.
    /// <see href="https://w3id.org/yang/server#Subscription"></see></summary>
    let Subscription =
        Namespaced_IRI.parse _namespace_name "Subscription" |> NamespacedName

    /// <summary>
    /// Represents a Operation to a YANG server using the corresponding network management protocol.
    /// <see href="https://w3id.org/yang/server#Operation"></see></summary>
    let Operation = Namespaced_IRI.parse _namespace_name "Operation" |> NamespacedName

    /// <summary>
    /// A datastore holding the complete operational state of the device.
    /// <see href="https://w3id.org/yang/server#OperationalDatastore"></see></summary>
    let OperationalDatastore =
        Namespaced_IRI.parse _namespace_name "OperationalDatastore" |> NamespacedName

    /// <summary>
    /// Represents the period interval with which to report updates in a periodic subscription.
    /// <see href="https://w3id.org/yang/server#Period"></see></summary>
    let Period = Namespaced_IRI.parse _namespace_name "Period" |> NamespacedName

    /// <summary>
    /// A datastore subscription with updates that are triggered periodically according to some time interval.
    /// <see href="https://w3id.org/yang/server#PeriodicSubscription"></see></summary>
    let PeriodicSubscription =
        Namespaced_IRI.parse _namespace_name "PeriodicSubscription" |> NamespacedName

    /// <summary>
    /// Represents a query operation to a YANG server using the corresponding network management protocol.
    /// <see href="https://w3id.org/yang/server#Query"></see></summary>
    let Query = Namespaced_IRI.parse _namespace_name "Query" |> NamespacedName

    /// <summary>
    /// This capability indicates that the server will support the `rollback-on-error` value in the `&lt;error-option&gt;` parameter to the `&lt;edit-config&gt;` operation.
    /// <see href="https://w3id.org/yang/server#RollbackOnErrorCapability"></see></summary>
    let RollbackOnErrorCapability =
        Namespaced_IRI.parse _namespace_name "RollbackOnErrorCapability" |> NamespacedName

    /// <summary>
    /// A configuration datastore holding the current configuration of the device.  It may include configuration that requires further transformations before it can be applied.
    /// <see href="https://w3id.org/yang/server#RunningDatastore"></see></summary>
    let RunningDatastore =
        Namespaced_IRI.parse _namespace_name "RunningDatastore" |> NamespacedName

    /// <summary>
    /// Represents an account used for accessing the YANG server.
    /// <see href="https://w3id.org/yang/server#ServerAccount"></see></summary>
    let ServerAccount =
        Namespaced_IRI.parse _namespace_name "ServerAccount" |> NamespacedName

    /// <summary>
    /// The device supports separate running and startup configuration datastores. The startup configuration is loaded by the device when it boots.
    /// <see href="https://w3id.org/yang/server#StartupCapability"></see></summary>
    let StartupCapability =
        Namespaced_IRI.parse _namespace_name "StartupCapability" |> NamespacedName

    /// <summary>
    /// A configuration datastore holding the configuration loaded by the device into the running configuration datastore when it boots.
    /// <see href="https://w3id.org/yang/server#StartupDatastore"></see></summary>
    let StartupDatastore =
        Namespaced_IRI.parse _namespace_name "StartupDatastore" |> NamespacedName

    /// <summary>
    /// Evaluation criteria based on XML subtree expression.
    /// <see href="https://w3id.org/yang/server#SubtreeFilter"></see></summary>
    let SubtreeFilter =
        Namespaced_IRI.parse _namespace_name "SubtreeFilter" |> NamespacedName

    /// <summary>
    /// The NETCONF peer has the ability to accept the `&lt;url&gt;` element in `&lt;source&gt;` and `&lt;target&gt;` parameters. The capability is further identified by URL arguments indicating the URL schemes supported.
    /// <see href="https://w3id.org/yang/server#UrlCapability"></see></summary>
    let UrlCapability =
        Namespaced_IRI.parse _namespace_name "UrlCapability" |> NamespacedName

    /// <summary>
    /// Validate consists of checking a complete configuration for syntactical and semantic errors before applying the configuration to the device.
    /// <see href="https://w3id.org/yang/server#ValidateCapability"></see></summary>
    let ValidateCapability =
        Namespaced_IRI.parse _namespace_name "ValidateCapability" |> NamespacedName

    /// <summary>
    /// The `:writable-running` capability indicates that the device supports direct writes to the `&lt;running&gt;` configuration datastore. In other words, the device supports `&lt;edit-config&gt;` and `&lt;copy-config&gt;` operations where the `&lt;running&gt;` configuration is the target.
    /// <see href="https://w3id.org/yang/server#WritableRunningCapability"></see></summary>
    let WritableRunningCapability =
        Namespaced_IRI.parse _namespace_name "WritableRunningCapability" |> NamespacedName

    /// <summary>
    /// Evaluation criteria based on XPath expression.
    /// <see href="https://w3id.org/yang/server#XPathFilter"></see></summary>
    let XPathFilter =
        Namespaced_IRI.parse _namespace_name "XPathFilter" |> NamespacedName

    /// <summary>
    /// The XPath capability indicates that the NETCONF peer supports the use of XPath expressions in the `&lt;filter&gt;` element.
    /// <see href="https://w3id.org/yang/server#XpathCapability"></see></summary>
    let XpathCapability =
        Namespaced_IRI.parse _namespace_name "XpathCapability" |> NamespacedName

    /// <summary>
    /// NETCONF capability that indicates that the NETCONF server implements YANG Library RFC7895.
    /// <see href="https://w3id.org/yang/server#YangLibrary1.0Capability"></see></summary>
    let ``YangLibrary1.0Capability`` =
        Namespaced_IRI.parse _namespace_name "YangLibrary1.0Capability" |> NamespacedName

    /// <summary>
    /// NETCONF capability that indicates that the NETCONF server implements YANG Library RFC8525.
    /// <see href="https://w3id.org/yang/server#YangLibrary1.1Capability"></see></summary>
    let ``YangLibrary1.1Capability`` =
        Namespaced_IRI.parse _namespace_name "YangLibrary1.1Capability" |> NamespacedName

    /// <summary>
    /// Refers to the NETCONF capability supported by the NETCONF server.
    /// <see href="https://w3id.org/yang/server#capability"></see></summary>
    let capability = Namespaced_IRI.parse _namespace_name "capability" |> NamespacedName
    /// <summary>
    /// Indicates the YANG datastore used by the YANG server.
    /// <see href="https://w3id.org/yang/server#datastore"></see></summary>
    let datastore = Namespaced_IRI.parse _namespace_name "datastore" |> NamespacedName
    /// <summary>
    /// Refers to the YANG filter used when accessing the YANG server using a network management protocol.
    /// <see href="https://w3id.org/yang/server#filter"></see></summary>
    let filter = Namespaced_IRI.parse _namespace_name "filter" |> NamespacedName

    /// <summary>
    /// Value used by filter to access YANG data of the NETCONF server.
    /// <see href="https://w3id.org/yang/server#filterValue"></see></summary>
    let filterValue =
        Namespaced_IRI.parse _namespace_name "filterValue" |> NamespacedName

    /// <summary>
    /// Indicates whether SSH host key is verified to access the NETCONF server.
    /// <see href="https://w3id.org/yang/server#hostKeyVerification"></see></summary>
    let hostKeyVerification =
        Namespaced_IRI.parse _namespace_name "hostKeyVerification" |> NamespacedName

    /// <summary>
    /// Refers to an XML namespace used in the XPath expression.
    /// <see href="https://w3id.org/yang/server#namespace"></see></summary>
    let namespace_ = Namespaced_IRI.parse _namespace_name "namespace" |> NamespacedName

    /// <summary>
    /// Prefix of the XML namespace.
    /// <see href="https://w3id.org/yang/server#namespacePrefix"></see></summary>
    let namespacePrefix =
        Namespaced_IRI.parse _namespace_name "namespacePrefix" |> NamespacedName

    /// <summary>
    /// URL of the XML namespace.
    /// <see href="https://w3id.org/yang/server#namespaceURL"></see></summary>
    let namespaceURL =
        Namespaced_IRI.parse _namespace_name "namespaceURL" |> NamespacedName

    /// <summary>
    /// Refers to period interval with which to report updates in a periodic subscription.
    /// <see href="https://w3id.org/yang/server#period"></see></summary>
    let period = Namespaced_IRI.parse _namespace_name "period" |> NamespacedName
    /// <summary>
    /// Refers to the YANG server that runs the YANG datastore.
    /// <see href="https://w3id.org/yang/server#server"></see></summary>
    let server = Namespaced_IRI.parse _namespace_name "server" |> NamespacedName

    /// <summary>
    /// Refers to the socket address for connecting to the YANG server.
    /// <see href="https://w3id.org/yang/server#socketAddress"></see></summary>
    let socketAddress =
        Namespaced_IRI.parse _namespace_name "socketAddress" |> NamespacedName

    /// <summary>
    /// Refers to the YANG datastore of the source YANG server to be selected in the YANG operation.
    /// <see href="https://w3id.org/yang/server#sourceDatastore"></see></summary>
    let sourceDatastore =
        Namespaced_IRI.parse _namespace_name "sourceDatastore" |> NamespacedName

    /// <summary>
    /// XML Subtree filter used to access YANG data of the NETCONF server.
    /// <see href="https://w3id.org/yang/server#subtreeValue"></see></summary>
    let subtreeValue =
        Namespaced_IRI.parse _namespace_name "subtreeValue" |> NamespacedName

    /// <summary>
    /// Username for accessing the YANG server.
    /// <see href="https://w3id.org/yang/server#username"></see></summary>
    let username = Namespaced_IRI.parse _namespace_name "username" |> NamespacedName
    /// <summary>
    /// XPath expression used to access YANG data of the YANG server.
    /// <see href="https://w3id.org/yang/server#xpathValue"></see></summary>
    let xpathValue = Namespaced_IRI.parse _namespace_name "xpathValue" |> NamespacedName
