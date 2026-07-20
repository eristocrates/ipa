namespace http.open_multinet.info.ontology.omn.hash

open DoxAletheia

module omn =
    let _namespace_name = "http://open-multinet.info/ontology/omn#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Examples: Monitoring information, Color attributes, Reservation information, QoS, SLAs, Location, Configuration, ...
    /// Describes the attributes of an omn:Group, omn:Resource, omn:Service or omn:Component in more detail
    /// <see href="http://open-multinet.info/ontology/omn#Attribute"></see></summary>
    let Attribute = _prefix "Attribute"
    /// <summary>
    /// An Entity that is part of an omn:Resource or omn:Service. It does not need to be an omn:Resource or an omn:Service itself.
    /// Examples: CPU, Sensor, Core, Port, Image
    /// <see href="http://open-multinet.info/ontology/omn#Component"></see></summary>
    let Component = _prefix "Component"
    /// <summary>
    /// Helps to defines a directional relationship between omn:Resource, omn:Group, omn:Component or omn:Service. It makes it possible to annotate the dependencies with additional properties.
    /// Examples: application coloring (in GENI context), orchestration needs dependencies
    /// <see href="http://open-multinet.info/ontology/omn#Dependency"></see></summary>
    let Dependency = _prefix "Dependency"
    /// <summary>
    /// The operating conditions under which a omn:Resource, omn:Group, omn:Service is operating.
    /// Examples: interference, concurrent virtual machines, concurrent traffic, temperature, heat, ...
    /// <see href="http://open-multinet.info/ontology/omn#Environment"></see></summary>
    let Environment = _prefix "Environment"
    /// <summary>
    /// A collection of omn:Resource, omn:Service or omn:Group
    /// Examples: Bi-directional Link, ...
    /// <see href="http://open-multinet.info/ontology/omn#Group"></see></summary>
    let Group = _prefix "Group"
    /// <summary>
    /// Examples: In networking, an end-to-end connectivity has to be on the same layer (path finding). For resources, it can describe the capability to adapt to a virtualized version
    /// Describes a place within a hierarchy a specific omn:Group, omn:Resource, omn:Service or omn:Component can adapt to.
    /// <see href="http://open-multinet.info/ontology/omn#Layer"></see></summary>
    let Layer = _prefix "Layer"
    /// <summary>
    /// An Entity that can be provisioned/controlled/measured by APIs
    /// Examples: Node, Link, People, ...
    /// <see href="http://open-multinet.info/ontology/omn#Resource"></see></summary>
    let Resource = _prefix "Resource"
    /// <summary>
    /// Examples: Aggregate Manager, Portal, Measurement Service, Hadoop, Broker, ...
    /// An Entity that has an API/capability to use it, it may depend on an omn:Resource
    /// <see href="http://open-multinet.info/ontology/omn#Service"></see></summary>
    let Service = _prefix "Service"
    /// <summary>
    /// Examples: (Earliest) Start and (lates) end time, data volume, ...
    /// A specification of a guarantee
    /// <see href="http://open-multinet.info/ontology/omn#Reservation"></see></summary>
    let Reservation = _prefix "Reservation"
    /// <summary>
    /// A collection of omn:Resource, omn:Service or omn:Group
    /// Examples: Infrastructure, Reservation, Slice, ...
    /// <see href="http://open-multinet.info/ontology/omn#Topology"></see></summary>
    let Topology = _prefix "Topology"
    /// <summary>
    /// determines the resource from which this resource can be adapted from - e.g. from an Ethernet to a FDDI port.
    /// <see href="http://open-multinet.info/ontology/omn#adaptableFrom"></see></summary>
    let adaptableFrom = _prefix "adaptableFrom"
    /// <summary>
    /// determines to which resource this resource can adapts to - e.g. from an Ethernet to a FDDI port.
    /// <see href="http://open-multinet.info/ontology/omn#adaptableTo"></see></summary>
    let adaptableTo = _prefix "adaptableTo"
    /// <summary>
    /// determines from which resource this resource adapts - e.g. from an Ethernet to a FDDI port.
    /// <see href="http://open-multinet.info/ontology/omn#adaptsFrom"></see></summary>
    let adaptsFrom = _prefix "adaptsFrom"
    /// <summary>
    /// determines to which resource this resource adapts - e.g. from an Ethernet to a FDDI port.
    /// <see href="http://open-multinet.info/ontology/omn#adaptsTo"></see></summary>
    let adaptsTo = _prefix "adaptsTo"
    /// <summary>
    /// claims dependency
    /// <see href="http://open-multinet.info/ontology/omn#dependsOn"></see></summary>
    let dependsOn = _prefix "dependsOn"
    /// <summary>
    /// claims a general dependency
    /// <see href="http://open-multinet.info/ontology/omn#relatesTo"></see></summary>
    let relatesTo = _prefix "relatesTo"
    /// <summary>
    /// claims dependency
    /// <see href="http://open-multinet.info/ontology/omn#fromDependency"></see></summary>
    let fromDependency = _prefix "fromDependency"
    /// <summary>
    ///   <see href="http://open-multinet.info/ontology/omn#toDependency"></see>
    /// </summary>
    let toDependency = _prefix "toDependency"
    /// <summary>
    /// link to a general attribute of the resource - e.g. to a ReadOnly class
    /// <see href="http://open-multinet.info/ontology/omn#hasAttribute"></see></summary>
    let hasAttribute = _prefix "hasAttribute"
    /// <summary>
    ///   <see href="http://open-multinet.info/ontology/omn#isAttributeOf"></see>
    /// </summary>
    let isAttributeOf = _prefix "isAttributeOf"
    /// <summary>
    /// component of the resource - e.g. a CPU
    /// <see href="http://open-multinet.info/ontology/omn#hasComponent"></see></summary>
    let hasComponent = _prefix "hasComponent"
    /// <summary>
    ///   <see href="http://open-multinet.info/ontology/omn#isComponentOf"></see>
    /// </summary>
    let isComponentOf = _prefix "isComponentOf"
    /// <summary>
    /// The URL of the API of a service
    /// <see href="http://open-multinet.info/ontology/omn#hasEndpoint"></see></summary>
    let hasEndpoint = _prefix "hasEndpoint"
    /// <summary>
    /// a group that is related to this resource - e.g. a reserved topology within an infrastructure
    /// <see href="http://open-multinet.info/ontology/omn#hasGroup"></see></summary>
    let hasGroup = _prefix "hasGroup"
    /// <summary>
    ///   <see href="http://open-multinet.info/ontology/omn#isGroupOf"></see>
    /// </summary>
    let isGroupOf = _prefix "isGroupOf"
    /// <summary>
    /// the reservation details of a resource - e.g. an immediate reservation for 3 hours
    /// <see href="http://open-multinet.info/ontology/omn#hasReservation"></see></summary>
    let hasReservation = _prefix "hasReservation"
    /// <summary>
    /// a resource that this resource contains - e.g. a node within a reserved topology
    /// <see href="http://open-multinet.info/ontology/omn#hasResource"></see></summary>
    let hasResource = _prefix "hasResource"
    /// <summary>
    ///   <see href="http://open-multinet.info/ontology/omn#isResourceOf"></see>
    /// </summary>
    let isResourceOf = _prefix "isResourceOf"
    /// <summary>
    /// a service that this resource contains - e.g. a Hadoop instance within a reserved topology
    /// <see href="http://open-multinet.info/ontology/omn#hasService"></see></summary>
    let hasService = _prefix "hasService"
    /// <summary>
    /// information/attribute that is not writable
    /// <see href="http://open-multinet.info/ontology/omn#isReadonly"></see></summary>
    let isReadonly = _prefix "isReadonly"
    /// <summary>
    ///   <see href="http://open-multinet.info/ontology/omn#isReservationOf"></see>
    /// </summary>
    let isReservationOf = _prefix "isReservationOf"
    /// <summary>
    ///   <see href="http://open-multinet.info/ontology/omn#isServiceOf"></see>
    /// </summary>
    let isServiceOf = _prefix "isServiceOf"
    /// <summary>
    ///   <see href="http://open-multinet.info/ontology/omn#withinEnvironment"></see>
    /// </summary>
    let withinEnvironment = _prefix "withinEnvironment"
