#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module omn =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://open-multinet.info/ontology/omn#" "omn"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : Examples: Monitoring information, Color attributes, Reservation information, QoS, SLAs, Location, Configuration, ...rdfs:comment : Describes the attributes of an omn:Group, omn:Resource, omn:Service or omn:Component in more detail</para>
    ///   <para>rdfs:label : Attribute</para>
    ///   <a href="http://open-multinet.info/ontology/omn#Attribute">omn:Attribute</a>
    /// </summary>
    let Attribute = _prefixId.prefix "Attribute"
    /// <summary>
    ///   <para>rdfs:comment : An Entity that is part of an omn:Resource or omn:Service. It does not need to be an omn:Resource or an omn:Service itself.rdfs:comment : Examples: CPU, Sensor, Core, Port, Image</para>
    ///   <para>rdfs:label : Component</para>
    ///   <a href="http://open-multinet.info/ontology/omn#Component">omn:Component</a>
    /// </summary>
    let Component = _prefixId.prefix "Component"
    /// <summary>
    ///   <para>rdfs:comment : Helps to defines a directional relationship between omn:Resource, omn:Group, omn:Component or omn:Service. It makes it possible to annotate the dependencies with additional properties.rdfs:comment : Examples: application coloring (in GENI context), orchestration needs dependencies</para>
    ///   <para>rdfs:label : Dependency</para>
    ///   <a href="http://open-multinet.info/ontology/omn#Dependency">omn:Dependency</a>
    /// </summary>
    let Dependency = _prefixId.prefix "Dependency"
    /// <summary>
    ///   <para>rdfs:comment : The operating conditions under which a omn:Resource, omn:Group, omn:Service is operating.rdfs:comment : Examples: interference, concurrent virtual machines, concurrent traffic, temperature, heat, ...</para>
    ///   <para>rdfs:label : Environment</para>
    ///   <a href="http://open-multinet.info/ontology/omn#Environment">omn:Environment</a>
    /// </summary>
    let Environment = _prefixId.prefix "Environment"
    /// <summary>
    ///   <para>rdfs:comment : A collection of omn:Resource, omn:Service or omn:Grouprdfs:comment : Examples: Bi-directional Link, ...</para>
    ///   <para>rdfs:label : Group</para>
    ///   <a href="http://open-multinet.info/ontology/omn#Group">omn:Group</a>
    /// </summary>
    let Group = _prefixId.prefix "Group"
    /// <summary>
    ///   <para>rdfs:comment : Examples: In networking, an end-to-end connectivity has to be on the same layer (path finding). For resources, it can describe the capability to adapt to a virtualized versionrdfs:comment : Describes a place within a hierarchy a specific omn:Group, omn:Resource, omn:Service or omn:Component can adapt to.</para>
    ///   <para>rdfs:label : Layer</para>
    ///   <a href="http://open-multinet.info/ontology/omn#Layer">omn:Layer</a>
    /// </summary>
    let Layer = _prefixId.prefix "Layer"
    /// <summary>
    ///   <para>rdfs:comment : Examples: (Earliest) Start and (lates) end time, data volume, ...rdfs:comment : A specification of a guarantee</para>
    ///   <para>rdfs:label : Reservation</para>
    ///   <a href="http://open-multinet.info/ontology/omn#Reservation">omn:Reservation</a>
    /// </summary>
    let Reservation = _prefixId.prefix "Reservation"
    /// <summary>
    ///   <para>rdfs:comment : An Entity that can be provisioned/controlled/measured by APIsrdfs:comment : Examples: Node, Link, People, ...</para>
    ///   <para>rdfs:label : Resource</para>
    ///   <a href="http://open-multinet.info/ontology/omn#Resource">omn:Resource</a>
    /// </summary>
    let Resource = _prefixId.prefix "Resource"
    /// <summary>
    ///   <para>rdfs:label : Service</para>
    ///   <para>rdfs:comment : Examples: Aggregate Manager, Portal, Measurement Service, Hadoop, Broker, ...rdfs:comment : An Entity that has an API/capability to use it, it may depend on an omn:Resource</para>
    ///   <a href="http://open-multinet.info/ontology/omn#Service">omn:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    /// <summary>
    ///   <para>rdfs:comment : A collection of omn:Resource, omn:Service or omn:Grouprdfs:comment : Examples: Infrastructure, Reservation, Slice, ...</para>
    ///   <para>rdfs:label : Topology</para>
    ///   <a href="http://open-multinet.info/ontology/omn#Topology">omn:Topology</a>
    /// </summary>
    let Topology = _prefixId.prefix "Topology"
    /// <summary>
    ///   <para>rdfs:comment : determines the resource from which this resource can be adapted from - e.g. from an Ethernet to a FDDI port.</para>
    ///   <para>rdfs:label : adaptable from</para>
    ///   <a href="http://open-multinet.info/ontology/omn#adaptableFrom">omn:adaptableFrom</a>
    /// </summary>
    let adaptableFrom = _prefixId.prefix "adaptableFrom"
    /// <summary>
    ///   <para>rdfs:comment : determines to which resource this resource can adapts to - e.g. from an Ethernet to a FDDI port.</para>
    ///   <para>rdfs:label : adaptable to</para>
    ///   <a href="http://open-multinet.info/ontology/omn#adaptableTo">omn:adaptableTo</a>
    /// </summary>
    let adaptableTo = _prefixId.prefix "adaptableTo"
    /// <summary>
    ///   <para>rdfs:comment : determines from which resource this resource adapts - e.g. from an Ethernet to a FDDI port.</para>
    ///   <para>rdfs:label : adapts from</para>
    ///   <a href="http://open-multinet.info/ontology/omn#adaptsFrom">omn:adaptsFrom</a>
    /// </summary>
    let adaptsFrom = _prefixId.prefix "adaptsFrom"
    /// <summary>
    ///   <para>rdfs:comment : determines to which resource this resource adapts - e.g. from an Ethernet to a FDDI port.</para>
    ///   <para>rdfs:label : adapts to</para>
    ///   <a href="http://open-multinet.info/ontology/omn#adaptsTo">omn:adaptsTo</a>
    /// </summary>
    let adaptsTo = _prefixId.prefix "adaptsTo"
    /// <summary>
    ///   <para>rdfs:comment : claims dependency</para>
    ///   <para>rdfs:label : depends on</para>
    ///   <a href="http://open-multinet.info/ontology/omn#dependsOn">omn:dependsOn</a>
    /// </summary>
    let dependsOn = _prefixId.prefix "dependsOn"
    /// <summary>
    ///   <para>rdfs:comment : claims dependency</para>
    ///   <para>rdfs:label : from dependency</para>
    ///   <a href="http://open-multinet.info/ontology/omn#fromDependency">omn:fromDependency</a>
    /// </summary>
    let fromDependency = _prefixId.prefix "fromDependency"
    /// <summary>
    ///   <para>rdfs:comment : link to a general attribute of the resource - e.g. to a ReadOnly class</para>
    ///   <para>rdfs:label : has attribute</para>
    ///   <a href="http://open-multinet.info/ontology/omn#hasAttribute">omn:hasAttribute</a>
    /// </summary>
    let hasAttribute = _prefixId.prefix "hasAttribute"
    /// <summary>
    ///   <para>rdfs:comment : component of the resource - e.g. a CPU</para>
    ///   <para>rdfs:label : has component</para>
    ///   <a href="http://open-multinet.info/ontology/omn#hasComponent">omn:hasComponent</a>
    /// </summary>
    let hasComponent = _prefixId.prefix "hasComponent"
    /// <summary>
    ///   <para>rdfs:comment : The URL of the API of a service</para>
    ///   <para>rdfs:label : has endpoint</para>
    ///   <a href="http://open-multinet.info/ontology/omn#hasEndpoint">omn:hasEndpoint</a>
    /// </summary>
    let hasEndpoint = _prefixId.prefix "hasEndpoint"
    /// <summary>
    ///   <para>rdfs:comment : a group that is related to this resource - e.g. a reserved topology within an infrastructure</para>
    ///   <para>rdfs:label : has group</para>
    ///   <a href="http://open-multinet.info/ontology/omn#hasGroup">omn:hasGroup</a>
    /// </summary>
    let hasGroup = _prefixId.prefix "hasGroup"
    /// <summary>
    ///   <para>rdfs:comment : the reservation details of a resource - e.g. an immediate reservation for 3 hours</para>
    ///   <para>rdfs:label : has reservation</para>
    ///   <a href="http://open-multinet.info/ontology/omn#hasReservation">omn:hasReservation</a>
    /// </summary>
    let hasReservation = _prefixId.prefix "hasReservation"
    /// <summary>
    ///   <para>rdfs:comment : a resource that this resource contains - e.g. a node within a reserved topology</para>
    ///   <para>rdfs:label : has resource</para>
    ///   <a href="http://open-multinet.info/ontology/omn#hasResource">omn:hasResource</a>
    /// </summary>
    let hasResource = _prefixId.prefix "hasResource"
    /// <summary>
    ///   <para>rdfs:comment : a service that this resource contains - e.g. a Hadoop instance within a reserved topology</para>
    ///   <para>rdfs:label : has service</para>
    ///   <a href="http://open-multinet.info/ontology/omn#hasService">omn:hasService</a>
    /// </summary>
    let hasService = _prefixId.prefix "hasService"
    /// <summary>
    ///   <para>rdfs:label : is attribute of</para>
    ///   <a href="http://open-multinet.info/ontology/omn#isAttributeOf">omn:isAttributeOf</a>
    /// </summary>
    let isAttributeOf = _prefixId.prefix "isAttributeOf"
    /// <summary>
    ///   <para>rdfs:label : is component of</para>
    ///   <a href="http://open-multinet.info/ontology/omn#isComponentOf">omn:isComponentOf</a>
    /// </summary>
    let isComponentOf = _prefixId.prefix "isComponentOf"
    /// <summary>
    ///   <para>rdfs:label : is group of</para>
    ///   <a href="http://open-multinet.info/ontology/omn#isGroupOf">omn:isGroupOf</a>
    /// </summary>
    let isGroupOf = _prefixId.prefix "isGroupOf"
    /// <summary>
    ///   <para>rdfs:comment : information/attribute that is not writable</para>
    ///   <para>rdfs:label : is read only</para>
    ///   <a href="http://open-multinet.info/ontology/omn#isReadonly">omn:isReadonly</a>
    /// </summary>
    let isReadonly = _prefixId.prefix "isReadonly"
    /// <summary>
    ///   <para>rdfs:label : is reservation of</para>
    ///   <a href="http://open-multinet.info/ontology/omn#isReservationOf">omn:isReservationOf</a>
    /// </summary>
    let isReservationOf = _prefixId.prefix "isReservationOf"
    /// <summary>
    ///   <para>rdfs:label : is resource of</para>
    ///   <a href="http://open-multinet.info/ontology/omn#isResourceOf">omn:isResourceOf</a>
    /// </summary>
    let isResourceOf = _prefixId.prefix "isResourceOf"
    /// <summary>
    ///   <para>rdfs:label : is service of</para>
    ///   <a href="http://open-multinet.info/ontology/omn#isServiceOf">omn:isServiceOf</a>
    /// </summary>
    let isServiceOf = _prefixId.prefix "isServiceOf"
    /// <summary>
    ///   <para>rdfs:comment : claims a general dependency</para>
    ///   <para>rdfs:label : relates to</para>
    ///   <a href="http://open-multinet.info/ontology/omn#relatesTo">omn:relatesTo</a>
    /// </summary>
    let relatesTo = _prefixId.prefix "relatesTo"
    /// <summary>
    ///   <para>rdfs:label : to dependency</para>
    ///   <a href="http://open-multinet.info/ontology/omn#toDependency">omn:toDependency</a>
    /// </summary>
    let toDependency = _prefixId.prefix "toDependency"
    /// <summary>
    ///   <para>rdfs:label : within environment</para>
    ///   <a href="http://open-multinet.info/ontology/omn#withinEnvironment">omn:withinEnvironment</a>
    /// </summary>
    let withinEnvironment = _prefixId.prefix "withinEnvironment"
