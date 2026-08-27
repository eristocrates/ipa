namespace https.w3id.org.yang.server.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module server =
    let _namespace_iri = Namespace_Iri server |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:yang/server#</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"YANG Server Ontology"</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#">https://w3id.org/yang/server#</seealso>
    let _prefix_iri = Prefixed_Name(server, "") |> PrefixedName

    /// <summary>
    ///   <para>w3id:yang/server#CandidateCapability</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:yang/server#NetconfCapability</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The candidate configuration capability, `:candidate`, indicates that the device supports a candidate configuration datastore, which is used to hold configuration data that can be manipulated without impacting the device's current configuration."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Candidate Capability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#CandidateCapability">https://w3id.org/yang/server#CandidateCapability</seealso>
    let CandidateCapability =
        Prefixed_Name(server, "CandidateCapability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:yang/server#CandidateDatastore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A configuration datastore that can be manipulated without impacting the device's running configuration datastore and that can be committed to the running configuration datastore."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Candidate Datastore"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#CandidateDatastore">https://w3id.org/yang/server#CandidateDatastore</seealso>
    let CandidateDatastore = Prefixed_Name(server, "CandidateDatastore") |> PrefixedName

    /// <summary>
    ///   <para>w3id:yang/server#ConfirmedCommitCapability</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:yang/server#NetconfCapability</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The `:confirmed-commit:1.1` capability indicates that the server will support the `&lt;cancel-commit&gt;` operation and the `&lt;confirmed&gt;`, `&lt;confirm-timeout&gt;`, `&lt;persist&gt;`, and `&lt;persist-id&gt;` parameters for the `&lt;commit&gt;` operation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Confirmed Commit Capability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#ConfirmedCommitCapability">https://w3id.org/yang/server#ConfirmedCommitCapability</seealso>
    let ConfirmedCommitCapability =
        Prefixed_Name(server, "ConfirmedCommitCapability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:yang/server#ConventionalDatastore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"One of the following set of configuration datastores: `&lt;running&gt;`, `&lt;startup&gt;`, `&lt;candidate&gt;`, and `&lt;intended&gt;`.  These datastores share a common datastore schema, and protocol operations allow copying data between these datastores. The term "conventional" is chosen as a generic umbrella term for these datastores."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Conventional Datastore"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#ConventionalDatastore">https://w3id.org/yang/server#ConventionalDatastore</seealso>
    let ConventionalDatastore =
        Prefixed_Name(server, "ConventionalDatastore") |> PrefixedName

    /// <summary>
    ///   <para>w3id:yang/server#Datastore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A conceptual place to store and access information. A datastore might be implemented, for example, using files, a database, flash memory locations, or combinations thereof. A datastore maps to an instantiated YANG data tree."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Datastore"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#Datastore">https://w3id.org/yang/server#Datastore</seealso>
    let Datastore = Prefixed_Name(server, "Datastore") |> PrefixedName
    /// <summary>
    ///   <para>w3id:yang/server#DynamicDatastore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A configuration datastore holding configuration obtained dynamically during the operation of a device through interaction with other systems, rather than through one of the conventional configuration datastores."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dynamic Datastore"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#DynamicDatastore">https://w3id.org/yang/server#DynamicDatastore</seealso>
    let DynamicDatastore = Prefixed_Name(server, "DynamicDatastore") |> PrefixedName
    /// <summary>
    ///   <para>w3id:yang/server#Filter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Evaluation criteria that may be applied to fetch data from a given YANG server."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Filter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#Filter">https://w3id.org/yang/server#Filter</seealso>
    let Filter = Prefixed_Name(server, "Filter") |> PrefixedName
    /// <summary>
    ///   <para>w3id:yang/server#IntendedDatastore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A configuration datastore holding the complete intended configuration of the device. This represents the configuration after all configuration transformations to &lt;running&gt; have been performed and is the configuration that the system attempts to apply."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Intended Datastore"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#IntendedDatastore">https://w3id.org/yang/server#IntendedDatastore</seealso>
    let IntendedDatastore = Prefixed_Name(server, "IntendedDatastore") |> PrefixedName
    /// <summary>
    ///   <para>w3id:yang/server#Namespace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents an XML namespace used in the XPath expression."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Namespace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#Namespace">https://w3id.org/yang/server#Namespace</seealso>
    let Namespace = Prefixed_Name(server, "Namespace") |> PrefixedName
    /// <summary>
    ///   <para>w3id:yang/server#NetconfCapability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"NETCONF capability."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Netconf Capability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#NetconfCapability">https://w3id.org/yang/server#NetconfCapability</seealso>
    let NetconfCapability = Prefixed_Name(server, "NetconfCapability") |> PrefixedName
    /// <summary>
    ///   <para>w3id:yang/server#NetconfQuerySource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a NETCONF query operation in RML mappings."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Netconf Query Source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#NetconfQuerySource">https://w3id.org/yang/server#NetconfQuerySource</seealso>
    let NetconfQuerySource = Prefixed_Name(server, "NetconfQuerySource") |> PrefixedName
    /// <summary>
    ///   <para>w3id:yang/server#NetconfServer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"YANG server that can be managed via the NETCONF protocol."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Netconf Server"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#NetconfServer">https://w3id.org/yang/server#NetconfServer</seealso>
    let NetconfServer = Prefixed_Name(server, "NetconfServer") |> PrefixedName

    /// <summary>
    ///   <para>w3id:yang/server#OnChangeSubscription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A datastore subscription with updates that are triggered when changes in subscribed datastore nodes are detected."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"On-change Subscription"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#OnChangeSubscription">https://w3id.org/yang/server#OnChangeSubscription</seealso>
    let OnChangeSubscription =
        Prefixed_Name(server, "OnChangeSubscription") |> PrefixedName

    /// <summary>
    ///   <para>w3id:yang/server#Operation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a Operation to a YANG server using the corresponding network management protocol."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Operation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#Operation">https://w3id.org/yang/server#Operation</seealso>
    let Operation = Prefixed_Name(server, "Operation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:yang/server#OperationalDatastore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A datastore holding the complete operational state of the device."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Operational Datastore"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#OperationalDatastore">https://w3id.org/yang/server#OperationalDatastore</seealso>
    let OperationalDatastore =
        Prefixed_Name(server, "OperationalDatastore") |> PrefixedName

    /// <summary>
    ///   <para>w3id:yang/server#Period</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents the period interval with which to report updates in a periodic subscription."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Period"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#Period">https://w3id.org/yang/server#Period</seealso>
    let Period = Prefixed_Name(server, "Period") |> PrefixedName

    /// <summary>
    ///   <para>w3id:yang/server#PeriodicSubscription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A datastore subscription with updates that are triggered periodically according to some time interval."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Periodic Subscription"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#PeriodicSubscription">https://w3id.org/yang/server#PeriodicSubscription</seealso>
    let PeriodicSubscription =
        Prefixed_Name(server, "PeriodicSubscription") |> PrefixedName

    /// <summary>
    ///   <para>w3id:yang/server#Query</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a query operation to a YANG server using the corresponding network management protocol."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Query"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#Query">https://w3id.org/yang/server#Query</seealso>
    let Query = Prefixed_Name(server, "Query") |> PrefixedName

    /// <summary>
    ///   <para>w3id:yang/server#RollbackOnErrorCapability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:yang/server#NetconfCapability</para>
    ///   <para>"This capability indicates that the server will support the `rollback-on-error` value in the `&lt;error-option&gt;` parameter to the `&lt;edit-config&gt;` operation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Rollback-on-Error Capability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#RollbackOnErrorCapability">https://w3id.org/yang/server#RollbackOnErrorCapability</seealso>
    let RollbackOnErrorCapability =
        Prefixed_Name(server, "RollbackOnErrorCapability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:yang/server#RunningDatastore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A configuration datastore holding the current configuration of the device.  It may include configuration that requires further transformations before it can be applied."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Running Datastore"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#RunningDatastore">https://w3id.org/yang/server#RunningDatastore</seealso>
    let RunningDatastore = Prefixed_Name(server, "RunningDatastore") |> PrefixedName
    /// <summary>
    ///   <para>w3id:yang/server#ServerAccount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents an account used for accessing the YANG server."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Server Account"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#ServerAccount">https://w3id.org/yang/server#ServerAccount</seealso>
    let ServerAccount = Prefixed_Name(server, "ServerAccount") |> PrefixedName
    /// <summary>
    ///   <para>w3id:yang/server#StartupCapability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:yang/server#NetconfCapability</para>
    ///   <para>"The device supports separate running and startup configuration datastores. The startup configuration is loaded by the device when it boots."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Startup Capability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#StartupCapability">https://w3id.org/yang/server#StartupCapability</seealso>
    let StartupCapability = Prefixed_Name(server, "StartupCapability") |> PrefixedName
    /// <summary>
    ///   <para>w3id:yang/server#StartupDatastore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A configuration datastore holding the configuration loaded by the device into the running configuration datastore when it boots."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Startup Datastore"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#StartupDatastore">https://w3id.org/yang/server#StartupDatastore</seealso>
    let StartupDatastore = Prefixed_Name(server, "StartupDatastore") |> PrefixedName
    /// <summary>
    ///   <para>w3id:yang/server#Subscription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a subscription operation to a YANG server using the corresponding network management protocol."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Subscription"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#Subscription">https://w3id.org/yang/server#Subscription</seealso>
    let Subscription = Prefixed_Name(server, "Subscription") |> PrefixedName
    /// <summary>
    ///   <para>w3id:yang/server#SubtreeFilter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Evaluation criteria based on XML subtree expression."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Subtree Filter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#SubtreeFilter">https://w3id.org/yang/server#SubtreeFilter</seealso>
    let SubtreeFilter = Prefixed_Name(server, "SubtreeFilter") |> PrefixedName
    /// <summary>
    ///   <para>w3id:yang/server#UrlCapability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:yang/server#NetconfCapability</para>
    ///   <para>"The NETCONF peer has the ability to accept the `&lt;url&gt;` element in `&lt;source&gt;` and `&lt;target&gt;` parameters. The capability is further identified by URL arguments indicating the URL schemes supported."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"URL Capability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#UrlCapability">https://w3id.org/yang/server#UrlCapability</seealso>
    let UrlCapability = Prefixed_Name(server, "UrlCapability") |> PrefixedName
    /// <summary>
    ///   <para>w3id:yang/server#ValidateCapability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:yang/server#NetconfCapability</para>
    ///   <para>"Validate consists of checking a complete configuration for syntactical and semantic errors before applying the configuration to the device."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Validate Capability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#ValidateCapability">https://w3id.org/yang/server#ValidateCapability</seealso>
    let ValidateCapability = Prefixed_Name(server, "ValidateCapability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:yang/server#WritableRunningCapability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:yang/server#NetconfCapability</para>
    ///   <para>"The `:writable-running` capability indicates that the device supports direct writes to the `&lt;running&gt;` configuration datastore. In other words, the device supports `&lt;edit-config&gt;` and `&lt;copy-config&gt;` operations where the `&lt;running&gt;` configuration is the target."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Writable Running Capability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#WritableRunningCapability">https://w3id.org/yang/server#WritableRunningCapability</seealso>
    let WritableRunningCapability =
        Prefixed_Name(server, "WritableRunningCapability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:yang/server#XPathFilter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Evaluation criteria based on XPath expression."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"XPath Filter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#XPathFilter">https://w3id.org/yang/server#XPathFilter</seealso>
    let XPathFilter = Prefixed_Name(server, "XPathFilter") |> PrefixedName
    /// <summary>
    ///   <para>w3id:yang/server#XpathCapability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:yang/server#NetconfCapability</para>
    ///   <para>"The XPath capability indicates that the NETCONF peer supports the use of XPath expressions in the `&lt;filter&gt;` element."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"XPath Capability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#XpathCapability">https://w3id.org/yang/server#XpathCapability</seealso>
    let XpathCapability = Prefixed_Name(server, "XpathCapability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:yang/server#YangLibrary1.0Capability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:yang/server#NetconfCapability</para>
    ///   <para>"NETCONF capability that indicates that the NETCONF server implements YANG Library RFC7895."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Yang Library 1.0 Capability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#YangLibrary1.0Capability">https://w3id.org/yang/server#YangLibrary1.0Capability</seealso>
    let ``YangLibrary1.0Capability`` =
        Prefixed_Name(server, "YangLibrary1.0Capability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:yang/server#YangLibrary1.1Capability</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:yang/server#NetconfCapability</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"NETCONF capability that indicates that the NETCONF server implements YANG Library RFC8525."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Yang Library 1.1 Capability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#YangLibrary1.1Capability">https://w3id.org/yang/server#YangLibrary1.1Capability</seealso>
    let ``YangLibrary1.1Capability`` =
        Prefixed_Name(server, "YangLibrary1.1Capability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:yang/server#YangServer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An entity that provides access to YANG-defined data to a client, over some network management protocol."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Yang Server"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#YangServer">https://w3id.org/yang/server#YangServer</seealso>
    let YangServer = Prefixed_Name(server, "YangServer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:yang/server#capability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Refers to the NETCONF capability supported by the NETCONF server."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"capability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#capability">https://w3id.org/yang/server#capability</seealso>
    let capability = Prefixed_Name(server, "capability") |> PrefixedName
    /// <summary>
    ///   <para>w3id:yang/server#datastore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the YANG datastore used by the YANG server."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"datastore"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#datastore">https://w3id.org/yang/server#datastore</seealso>
    let datastore = Prefixed_Name(server, "datastore") |> PrefixedName
    /// <summary>
    ///   <para>w3id:yang/server#filter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Refers to the YANG filter used when accessing the YANG server using a network management protocol."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"filter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#filter">https://w3id.org/yang/server#filter</seealso>
    let filter = Prefixed_Name(server, "filter") |> PrefixedName
    /// <summary>
    ///   <para>w3id:yang/server#filterValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Value used by filter to access YANG data of the NETCONF server."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"filter value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#filterValue">https://w3id.org/yang/server#filterValue</seealso>
    let filterValue = Prefixed_Name(server, "filterValue") |> PrefixedName

    /// <summary>
    ///   <para>w3id:yang/server#hostKeyVerification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indicates whether SSH host key is verified to access the NETCONF server."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"host key verification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#hostKeyVerification">https://w3id.org/yang/server#hostKeyVerification</seealso>
    let hostKeyVerification =
        Prefixed_Name(server, "hostKeyVerification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:yang/server#namespace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Refers to an XML namespace used in the XPath expression."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"namespace"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#namespace">https://w3id.org/yang/server#namespace</seealso>
    let namespace_ = Prefixed_Name(server, "namespace") |> PrefixedName
    /// <summary>
    ///   <para>w3id:yang/server#namespacePrefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Prefix of the XML namespace."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"namespace prefix"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#namespacePrefix">https://w3id.org/yang/server#namespacePrefix</seealso>
    let namespacePrefix = Prefixed_Name(server, "namespacePrefix") |> PrefixedName
    /// <summary>
    ///   <para>w3id:yang/server#namespaceURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"URL of the XML namespace."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"namespace url"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#namespaceURL">https://w3id.org/yang/server#namespaceURL</seealso>
    let namespaceURL = Prefixed_Name(server, "namespaceURL") |> PrefixedName

    /// <summary>
    ///   <para>w3id:yang/server#netconfCapabilityId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Represents the URI that identifies the NETCONF capability."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"netconf capability id"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#netconfCapabilityId">https://w3id.org/yang/server#netconfCapabilityId</seealso>
    let netconfCapabilityId =
        Prefixed_Name(server, "netconfCapabilityId") |> PrefixedName

    /// <summary>
    ///   <para>w3id:yang/server#netconfCapabilityName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Represents the name of the NETCONF capability."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"netconf capability name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#netconfCapabilityName">https://w3id.org/yang/server#netconfCapabilityName</seealso>
    let netconfCapabilityName =
        Prefixed_Name(server, "netconfCapabilityName") |> PrefixedName

    /// <summary>
    ///   <para>w3id:yang/server#netconfCapabilityVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Represents the version of the NETCONF capability."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"netconf capability version"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#netconfCapabilityVersion">https://w3id.org/yang/server#netconfCapabilityVersion</seealso>
    let netconfCapabilityVersion =
        Prefixed_Name(server, "netconfCapabilityVersion") |> PrefixedName

    /// <summary>
    ///   <para>w3id:yang/server#period</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Refers to period interval with which to report updates in a periodic subscription."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"period"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#period">https://w3id.org/yang/server#period</seealso>
    let period = Prefixed_Name(server, "period") |> PrefixedName
    /// <summary>
    ///   <para>w3id:yang/server#server</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Refers to the YANG server that runs the YANG datastore."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"server"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#server">https://w3id.org/yang/server#server</seealso>
    let server_ = Prefixed_Name(server, "server") |> PrefixedName
    /// <summary>
    ///   <para>w3id:yang/server#socketAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Refers to the socket address for connecting to the YANG server."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"socket address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#socketAddress">https://w3id.org/yang/server#socketAddress</seealso>
    let socketAddress = Prefixed_Name(server, "socketAddress") |> PrefixedName
    /// <summary>
    ///   <para>w3id:yang/server#sourceDatastore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Refers to the YANG datastore of the source YANG server to be selected in the YANG operation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"source datastore"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#sourceDatastore">https://w3id.org/yang/server#sourceDatastore</seealso>
    let sourceDatastore = Prefixed_Name(server, "sourceDatastore") |> PrefixedName
    /// <summary>
    ///   <para>w3id:yang/server#subtreeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"XML Subtree filter used to access YANG data of the NETCONF server."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"subtree value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#subtreeValue">https://w3id.org/yang/server#subtreeValue</seealso>
    let subtreeValue = Prefixed_Name(server, "subtreeValue") |> PrefixedName
    /// <summary>
    ///   <para>w3id:yang/server#username</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Username for accessing the YANG server."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"username"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#username">https://w3id.org/yang/server#username</seealso>
    let username = Prefixed_Name(server, "username") |> PrefixedName
    /// <summary>
    ///   <para>w3id:yang/server#xpathValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"XPath expression used to access YANG data of the YANG server."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"xpath value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/yang/server#xpathValue">https://w3id.org/yang/server#xpathValue</seealso>
    let xpathValue = Prefixed_Name(server, "xpathValue") |> PrefixedName
