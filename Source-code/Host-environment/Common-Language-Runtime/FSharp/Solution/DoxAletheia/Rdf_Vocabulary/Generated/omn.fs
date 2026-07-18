namespace http.open_multinet.info.ontology.omn.hash

open DoxAletheia.Rdf_Vocabulary

module omn =
    let _namespace_name = "http://open-multinet.info/ontology/omn#"
    /// <summary>
    /// Examples: Monitoring information, Color attributes, Reservation information, QoS, SLAs, Location, Configuration, ...
    /// Describes the attributes of an omn:Group, omn:Resource, omn:Service or omn:Component in more detail
    /// <see href="http://open-multinet.info/ontology/omn#Attribute"></see></summary>
    let Attribute = Namespaced_IRI.parse _namespace_name "Attribute" |> NamespacedName
    /// <summary>
    /// An Entity that is part of an omn:Resource or omn:Service. It does not need to be an omn:Resource or an omn:Service itself.
    /// Examples: CPU, Sensor, Core, Port, Image
    /// <see href="http://open-multinet.info/ontology/omn#Component"></see></summary>
    let Component = Namespaced_IRI.parse _namespace_name "Component" |> NamespacedName
    /// <summary>
    /// Helps to defines a directional relationship between omn:Resource, omn:Group, omn:Component or omn:Service. It makes it possible to annotate the dependencies with additional properties.
    /// Examples: application coloring (in GENI context), orchestration needs dependencies
    /// <see href="http://open-multinet.info/ontology/omn#Dependency"></see></summary>
    let Dependency = Namespaced_IRI.parse _namespace_name "Dependency" |> NamespacedName

    /// <summary>
    /// The operating conditions under which a omn:Resource, omn:Group, omn:Service is operating.
    /// Examples: interference, concurrent virtual machines, concurrent traffic, temperature, heat, ...
    /// <see href="http://open-multinet.info/ontology/omn#Environment"></see></summary>
    let Environment =
        Namespaced_IRI.parse _namespace_name "Environment" |> NamespacedName

    /// <summary>
    /// A collection of omn:Resource, omn:Service or omn:Group
    /// Examples: Bi-directional Link, ...
    /// <see href="http://open-multinet.info/ontology/omn#Group"></see></summary>
    let Group = Namespaced_IRI.parse _namespace_name "Group" |> NamespacedName
    /// <summary>
    /// Examples: In networking, an end-to-end connectivity has to be on the same layer (path finding). For resources, it can describe the capability to adapt to a virtualized version
    /// Describes a place within a hierarchy a specific omn:Group, omn:Resource, omn:Service or omn:Component can adapt to.
    /// <see href="http://open-multinet.info/ontology/omn#Layer"></see></summary>
    let Layer = Namespaced_IRI.parse _namespace_name "Layer" |> NamespacedName
    /// <summary>
    /// An Entity that can be provisioned/controlled/measured by APIs
    /// Examples: Node, Link, People, ...
    /// <see href="http://open-multinet.info/ontology/omn#Resource"></see></summary>
    let Resource = Namespaced_IRI.parse _namespace_name "Resource" |> NamespacedName
    /// <summary>
    /// Examples: Aggregate Manager, Portal, Measurement Service, Hadoop, Broker, ...
    /// An Entity that has an API/capability to use it, it may depend on an omn:Resource
    /// <see href="http://open-multinet.info/ontology/omn#Service"></see></summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName

    /// <summary>
    /// Examples: (Earliest) Start and (lates) end time, data volume, ...
    /// A specification of a guarantee
    /// <see href="http://open-multinet.info/ontology/omn#Reservation"></see></summary>
    let Reservation =
        Namespaced_IRI.parse _namespace_name "Reservation" |> NamespacedName

    /// <summary>
    /// A collection of omn:Resource, omn:Service or omn:Group
    /// Examples: Infrastructure, Reservation, Slice, ...
    /// <see href="http://open-multinet.info/ontology/omn#Topology"></see></summary>
    let Topology = Namespaced_IRI.parse _namespace_name "Topology" |> NamespacedName

    /// <summary>
    /// determines the resource from which this resource can be adapted from - e.g. from an Ethernet to a FDDI port.
    /// <see href="http://open-multinet.info/ontology/omn#adaptableFrom"></see></summary>
    let adaptableFrom =
        Namespaced_IRI.parse _namespace_name "adaptableFrom" |> NamespacedName

    /// <summary>
    /// determines to which resource this resource can adapts to - e.g. from an Ethernet to a FDDI port.
    /// <see href="http://open-multinet.info/ontology/omn#adaptableTo"></see></summary>
    let adaptableTo =
        Namespaced_IRI.parse _namespace_name "adaptableTo" |> NamespacedName

    /// <summary>
    /// determines from which resource this resource adapts - e.g. from an Ethernet to a FDDI port.
    /// <see href="http://open-multinet.info/ontology/omn#adaptsFrom"></see></summary>
    let adaptsFrom = Namespaced_IRI.parse _namespace_name "adaptsFrom" |> NamespacedName
    /// <summary>
    /// determines to which resource this resource adapts - e.g. from an Ethernet to a FDDI port.
    /// <see href="http://open-multinet.info/ontology/omn#adaptsTo"></see></summary>
    let adaptsTo = Namespaced_IRI.parse _namespace_name "adaptsTo" |> NamespacedName
    /// <summary>
    /// claims dependency
    /// <see href="http://open-multinet.info/ontology/omn#dependsOn"></see></summary>
    let dependsOn = Namespaced_IRI.parse _namespace_name "dependsOn" |> NamespacedName
    /// <summary>
    /// claims a general dependency
    /// <see href="http://open-multinet.info/ontology/omn#relatesTo"></see></summary>
    let relatesTo = Namespaced_IRI.parse _namespace_name "relatesTo" |> NamespacedName

    /// <summary>
    /// claims dependency
    /// <see href="http://open-multinet.info/ontology/omn#fromDependency"></see></summary>
    let fromDependency =
        Namespaced_IRI.parse _namespace_name "fromDependency" |> NamespacedName

    /// <summary>
    ///   <see href="http://open-multinet.info/ontology/omn#toDependency"></see>
    /// </summary>
    let toDependency =
        Namespaced_IRI.parse _namespace_name "toDependency" |> NamespacedName

    /// <summary>
    /// link to a general attribute of the resource - e.g. to a ReadOnly class
    /// <see href="http://open-multinet.info/ontology/omn#hasAttribute"></see></summary>
    let hasAttribute =
        Namespaced_IRI.parse _namespace_name "hasAttribute" |> NamespacedName

    /// <summary>
    ///   <see href="http://open-multinet.info/ontology/omn#isAttributeOf"></see>
    /// </summary>
    let isAttributeOf =
        Namespaced_IRI.parse _namespace_name "isAttributeOf" |> NamespacedName

    /// <summary>
    /// component of the resource - e.g. a CPU
    /// <see href="http://open-multinet.info/ontology/omn#hasComponent"></see></summary>
    let hasComponent =
        Namespaced_IRI.parse _namespace_name "hasComponent" |> NamespacedName

    /// <summary>
    ///   <see href="http://open-multinet.info/ontology/omn#isComponentOf"></see>
    /// </summary>
    let isComponentOf =
        Namespaced_IRI.parse _namespace_name "isComponentOf" |> NamespacedName

    /// <summary>
    /// The URL of the API of a service
    /// <see href="http://open-multinet.info/ontology/omn#hasEndpoint"></see></summary>
    let hasEndpoint =
        Namespaced_IRI.parse _namespace_name "hasEndpoint" |> NamespacedName

    /// <summary>
    /// a group that is related to this resource - e.g. a reserved topology within an infrastructure
    /// <see href="http://open-multinet.info/ontology/omn#hasGroup"></see></summary>
    let hasGroup = Namespaced_IRI.parse _namespace_name "hasGroup" |> NamespacedName
    /// <summary>
    ///   <see href="http://open-multinet.info/ontology/omn#isGroupOf"></see>
    /// </summary>
    let isGroupOf = Namespaced_IRI.parse _namespace_name "isGroupOf" |> NamespacedName

    /// <summary>
    /// the reservation details of a resource - e.g. an immediate reservation for 3 hours
    /// <see href="http://open-multinet.info/ontology/omn#hasReservation"></see></summary>
    let hasReservation =
        Namespaced_IRI.parse _namespace_name "hasReservation" |> NamespacedName

    /// <summary>
    /// a resource that this resource contains - e.g. a node within a reserved topology
    /// <see href="http://open-multinet.info/ontology/omn#hasResource"></see></summary>
    let hasResource =
        Namespaced_IRI.parse _namespace_name "hasResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://open-multinet.info/ontology/omn#isResourceOf"></see>
    /// </summary>
    let isResourceOf =
        Namespaced_IRI.parse _namespace_name "isResourceOf" |> NamespacedName

    /// <summary>
    /// a service that this resource contains - e.g. a Hadoop instance within a reserved topology
    /// <see href="http://open-multinet.info/ontology/omn#hasService"></see></summary>
    let hasService = Namespaced_IRI.parse _namespace_name "hasService" |> NamespacedName
    /// <summary>
    /// information/attribute that is not writable
    /// <see href="http://open-multinet.info/ontology/omn#isReadonly"></see></summary>
    let isReadonly = Namespaced_IRI.parse _namespace_name "isReadonly" |> NamespacedName

    /// <summary>
    ///   <see href="http://open-multinet.info/ontology/omn#isReservationOf"></see>
    /// </summary>
    let isReservationOf =
        Namespaced_IRI.parse _namespace_name "isReservationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://open-multinet.info/ontology/omn#isServiceOf"></see>
    /// </summary>
    let isServiceOf =
        Namespaced_IRI.parse _namespace_name "isServiceOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://open-multinet.info/ontology/omn#withinEnvironment"></see>
    /// </summary>
    let withinEnvironment =
        Namespaced_IRI.parse _namespace_name "withinEnvironment" |> NamespacedName
