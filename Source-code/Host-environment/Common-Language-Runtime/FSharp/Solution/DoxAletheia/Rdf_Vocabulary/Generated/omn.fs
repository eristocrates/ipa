namespace http.open_multinet.info.ontology.omn.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module omn =
    let _namespace_iri = Namespace_Iri omn |> NamespaceIRI
    /// <summary>
    ///   <para>omn:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn#">http://open-multinet.info/ontology/omn#</seealso>
    let _prefix_iri = Prefixed_Name(omn, "") |> PrefixedName
    /// <summary>
    ///   <para>omn:Attribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes the attributes of an omn:Group, omn:Resource, omn:Service or omn:Component in more detail"</para>
    ///   <para>"Examples: Monitoring information, Color attributes, Reservation information, QoS, SLAs, Location, Configuration, ..."</para>
    /// labels<para>"Attribute"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn#Attribute">http://open-multinet.info/ontology/omn#Attribute</seealso>
    let Attribute = Prefixed_Name(omn, "Attribute") |> PrefixedName
    /// <summary>
    ///   <para>omn:Component</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Entity that is part of an omn:Resource or omn:Service. It does not need to be an omn:Resource or an omn:Service itself."</para>
    ///   <para>"Examples: CPU, Sensor, Core, Port, Image"</para>
    /// labels<para>"Component"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn#Component">http://open-multinet.info/ontology/omn#Component</seealso>
    let Component = Prefixed_Name(omn, "Component") |> PrefixedName
    /// <summary>
    ///   <para>omn:Dependency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Helps to defines a directional relationship between omn:Resource, omn:Group, omn:Component or omn:Service. It makes it possible to annotate the dependencies with additional properties."</para>
    ///   <para>"Examples: application coloring (in GENI context), orchestration needs dependencies"</para>
    /// labels<para>"Dependency"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn#Dependency">http://open-multinet.info/ontology/omn#Dependency</seealso>
    let Dependency = Prefixed_Name(omn, "Dependency") |> PrefixedName
    /// <summary>
    ///   <para>omn:Environment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Examples: interference, concurrent virtual machines, concurrent traffic, temperature, heat, ..."</para>
    ///   <para>"The operating conditions under which a omn:Resource, omn:Group, omn:Service is operating."</para>
    /// labels<para>"Environment"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn#Environment">http://open-multinet.info/ontology/omn#Environment</seealso>
    let Environment = Prefixed_Name(omn, "Environment") |> PrefixedName
    /// <summary>
    ///   <para>omn:Group</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Examples: Bi-directional Link, ..."</para>
    ///   <para>"A collection of omn:Resource, omn:Service or omn:Group"</para>
    /// labels<para>"Group"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn#Group">http://open-multinet.info/ontology/omn#Group</seealso>
    let Group = Prefixed_Name(omn, "Group") |> PrefixedName
    /// <summary>
    ///   <para>omn:Layer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Examples: In networking, an end-to-end connectivity has to be on the same layer (path finding). For resources, it can describe the capability to adapt to a virtualized version"</para>
    ///   <para>"Describes a place within a hierarchy a specific omn:Group, omn:Resource, omn:Service or omn:Component can adapt to."</para>
    /// labels<para>"Layer"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn#Layer">http://open-multinet.info/ontology/omn#Layer</seealso>
    let Layer = Prefixed_Name(omn, "Layer") |> PrefixedName
    /// <summary>
    ///   <para>omn:Reservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Examples: (Earliest) Start and (lates) end time, data volume, ..."</para>
    ///   <para>"A specification of a guarantee"</para>
    /// labels<para>"Reservation"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn#Reservation">http://open-multinet.info/ontology/omn#Reservation</seealso>
    let Reservation = Prefixed_Name(omn, "Reservation") |> PrefixedName
    /// <summary>
    ///   <para>omn:Resource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Examples: Node, Link, People, ..."</para>
    ///   <para>"An Entity that can be provisioned/controlled/measured by APIs"</para>
    /// labels<para>"Resource"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn#Resource">http://open-multinet.info/ontology/omn#Resource</seealso>
    let Resource = Prefixed_Name(omn, "Resource") |> PrefixedName
    /// <summary>
    ///   <para>omn:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Entity that has an API/capability to use it, it may depend on an omn:Resource"</para>
    ///   <para>"Examples: Aggregate Manager, Portal, Measurement Service, Hadoop, Broker, ..."</para>
    /// labels<para>"Service"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn#Service">http://open-multinet.info/ontology/omn#Service</seealso>
    let Service = Prefixed_Name(omn, "Service") |> PrefixedName
    /// <summary>
    ///   <para>omn:Topology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A collection of omn:Resource, omn:Service or omn:Group"</para>
    ///   <para>"Examples: Infrastructure, Reservation, Slice, ..."</para>
    /// labels<para>"Topology"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn#Topology">http://open-multinet.info/ontology/omn#Topology</seealso>
    let Topology = Prefixed_Name(omn, "Topology") |> PrefixedName
    /// <summary>
    ///   <para>omn:adaptableFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"determines the resource from which this resource can be adapted from - e.g. from an Ethernet to a FDDI port."</para>
    /// labels<para>"adaptable from"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn#adaptableFrom">http://open-multinet.info/ontology/omn#adaptableFrom</seealso>
    let adaptableFrom = Prefixed_Name(omn, "adaptableFrom") |> PrefixedName
    /// <summary>
    ///   <para>omn:adaptableTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"determines to which resource this resource can adapts to - e.g. from an Ethernet to a FDDI port."</para>
    /// labels<para>"adaptable to"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn#adaptableTo">http://open-multinet.info/ontology/omn#adaptableTo</seealso>
    let adaptableTo = Prefixed_Name(omn, "adaptableTo") |> PrefixedName
    /// <summary>
    ///   <para>omn:adaptsFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>"determines from which resource this resource adapts - e.g. from an Ethernet to a FDDI port."</para>
    /// labels<para>"adapts from"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn#adaptsFrom">http://open-multinet.info/ontology/omn#adaptsFrom</seealso>
    let adaptsFrom = Prefixed_Name(omn, "adaptsFrom") |> PrefixedName
    /// <summary>
    ///   <para>omn:adaptsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"determines to which resource this resource adapts - e.g. from an Ethernet to a FDDI port."</para>
    /// labels<para>"adapts to"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn#adaptsTo">http://open-multinet.info/ontology/omn#adaptsTo</seealso>
    let adaptsTo = Prefixed_Name(omn, "adaptsTo") |> PrefixedName
    /// <summary>
    ///   <para>omn:dependsOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"claims dependency"</para>
    /// labels<para>"depends on"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn#dependsOn">http://open-multinet.info/ontology/omn#dependsOn</seealso>
    let dependsOn = Prefixed_Name(omn, "dependsOn") |> PrefixedName
    /// <summary>
    ///   <para>omn:fromDependency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"claims dependency"</para>
    /// labels<para>"from dependency"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn#fromDependency">http://open-multinet.info/ontology/omn#fromDependency</seealso>
    let fromDependency = Prefixed_Name(omn, "fromDependency") |> PrefixedName
    /// <summary>
    ///   <para>omn:hasAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"link to a general attribute of the resource - e.g. to a ReadOnly class"</para>
    /// labels<para>"has attribute"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn#hasAttribute">http://open-multinet.info/ontology/omn#hasAttribute</seealso>
    let hasAttribute = Prefixed_Name(omn, "hasAttribute") |> PrefixedName
    /// <summary>
    ///   <para>omn:hasComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"component of the resource - e.g. a CPU"</para>
    /// labels<para>"has component"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn#hasComponent">http://open-multinet.info/ontology/omn#hasComponent</seealso>
    let hasComponent = Prefixed_Name(omn, "hasComponent") |> PrefixedName
    /// <summary>
    ///   <para>omn:hasEndpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The URL of the API of a service"</para>
    /// labels<para>"has endpoint"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn#hasEndpoint">http://open-multinet.info/ontology/omn#hasEndpoint</seealso>
    let hasEndpoint = Prefixed_Name(omn, "hasEndpoint") |> PrefixedName
    /// <summary>
    ///   <para>omn:hasGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"a group that is related to this resource - e.g. a reserved topology within an infrastructure"</para>
    /// labels<para>"has group"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn#hasGroup">http://open-multinet.info/ontology/omn#hasGroup</seealso>
    let hasGroup = Prefixed_Name(omn, "hasGroup") |> PrefixedName
    /// <summary>
    ///   <para>omn:hasReservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"the reservation details of a resource - e.g. an immediate reservation for 3 hours"</para>
    /// labels<para>"has reservation"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn#hasReservation">http://open-multinet.info/ontology/omn#hasReservation</seealso>
    let hasReservation = Prefixed_Name(omn, "hasReservation") |> PrefixedName
    /// <summary>
    ///   <para>omn:hasResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"a resource that this resource contains - e.g. a node within a reserved topology"</para>
    /// labels<para>"has resource"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn#hasResource">http://open-multinet.info/ontology/omn#hasResource</seealso>
    let hasResource = Prefixed_Name(omn, "hasResource") |> PrefixedName
    /// <summary>
    ///   <para>omn:hasService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"a service that this resource contains - e.g. a Hadoop instance within a reserved topology"</para>
    /// labels<para>"has service"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn#hasService">http://open-multinet.info/ontology/omn#hasService</seealso>
    let hasService = Prefixed_Name(omn, "hasService") |> PrefixedName
    /// <summary>
    ///   <para>omn:isAttributeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"is attribute of"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn#isAttributeOf">http://open-multinet.info/ontology/omn#isAttributeOf</seealso>
    let isAttributeOf = Prefixed_Name(omn, "isAttributeOf") |> PrefixedName
    /// <summary>
    ///   <para>omn:isComponentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"is component of"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn#isComponentOf">http://open-multinet.info/ontology/omn#isComponentOf</seealso>
    let isComponentOf = Prefixed_Name(omn, "isComponentOf") |> PrefixedName
    /// <summary>
    ///   <para>omn:isGroupOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is group of"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn#isGroupOf">http://open-multinet.info/ontology/omn#isGroupOf</seealso>
    let isGroupOf = Prefixed_Name(omn, "isGroupOf") |> PrefixedName
    /// <summary>
    ///   <para>omn:isReadonly</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"information/attribute that is not writable"</para>
    /// labels<para>"is read only"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn#isReadonly">http://open-multinet.info/ontology/omn#isReadonly</seealso>
    let isReadonly = Prefixed_Name(omn, "isReadonly") |> PrefixedName
    /// <summary>
    ///   <para>omn:isReservationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"is reservation of"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn#isReservationOf">http://open-multinet.info/ontology/omn#isReservationOf</seealso>
    let isReservationOf = Prefixed_Name(omn, "isReservationOf") |> PrefixedName
    /// <summary>
    ///   <para>omn:isResourceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is resource of"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn#isResourceOf">http://open-multinet.info/ontology/omn#isResourceOf</seealso>
    let isResourceOf = Prefixed_Name(omn, "isResourceOf") |> PrefixedName
    /// <summary>
    ///   <para>omn:isServiceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is service of"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn#isServiceOf">http://open-multinet.info/ontology/omn#isServiceOf</seealso>
    let isServiceOf = Prefixed_Name(omn, "isServiceOf") |> PrefixedName
    /// <summary>
    ///   <para>omn:relatesTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"claims a general dependency"</para>
    /// labels<para>"relates to"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn#relatesTo">http://open-multinet.info/ontology/omn#relatesTo</seealso>
    let relatesTo = Prefixed_Name(omn, "relatesTo") |> PrefixedName
    /// <summary>
    ///   <para>omn:toDependency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"to dependency"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn#toDependency">http://open-multinet.info/ontology/omn#toDependency</seealso>
    let toDependency = Prefixed_Name(omn, "toDependency") |> PrefixedName
    /// <summary>
    ///   <para>omn:withinEnvironment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"within environment"</para></remarks>
    /// <seealso href="http://open-multinet.info/ontology/omn#withinEnvironment">http://open-multinet.info/ontology/omn#withinEnvironment</seealso>
    let withinEnvironment = Prefixed_Name(omn, "withinEnvironment") |> PrefixedName
