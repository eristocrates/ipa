namespace http.www.w3.org.ns.ssn.slash

open DoxAletheia.Rdf_Vocabulary

module ssno =
    let _namespace_name = "http://www.w3.org/ns/ssn/"
    /// <summary>
    /// A quality of an entity. An aspect of an entity that is intrinsic to and cannot exist without the entity.
    /// <see href="http://www.w3.org/ns/ssn/Property"></see></summary>
    let Property = Namespaced_IRI.parse _namespace_name "Property" |> NamespacedName
    /// <summary>
    /// Relation between an entity that implements a Procedure in some executable way and the Procedure (an algorithm, procedure or method).
    /// <see href="http://www.w3.org/ns/ssn/implements"></see></summary>
    let implements = Namespaced_IRI.parse _namespace_name "implements" |> NamespacedName

    /// <summary>
    /// A relation between some aspect of an entity and a Property.
    /// <see href="http://www.w3.org/ns/ssn/forProperty"></see></summary>
    let forProperty =
        Namespaced_IRI.parse _namespace_name "forProperty" |> NamespacedName

    /// <summary>
    /// System is a unit of abstraction for pieces of infrastructure that implements Procedures. A System may have components, its subsystems, which are other systems.
    /// <see href="http://www.w3.org/ns/ssn/System"></see></summary>
    let System = Namespaced_IRI.parse _namespace_name "System" |> NamespacedName

    /// <summary>
    /// Relation between an entity and a Property of that entity.
    /// <see href="http://www.w3.org/ns/ssn/hasProperty"></see></summary>
    let hasProperty =
        Namespaced_IRI.parse _namespace_name "hasProperty" |> NamespacedName

    /// <summary>
    /// A relation from a Stimulus to the Property that the Stimulus is serving as a proxy for.
    /// <see href="http://www.w3.org/ns/ssn/isProxyFor"></see></summary>
    let isProxyFor = Namespaced_IRI.parse _namespace_name "isProxyFor" |> NamespacedName
    /// <summary>
    /// An event in the real world that 'triggers' the Sensor. The properties associated to the Stimulus may be different to the eventual observed ObservableProperty. It is the event, not the object, that triggers the Sensor.
    /// <see href="http://www.w3.org/ns/ssn/Stimulus"></see></summary>
    let Stimulus = Namespaced_IRI.parse _namespace_name "Stimulus" |> NamespacedName

    /// <summary>
    /// Relation between an Observation and the Stimulus that originated it.
    /// <see href="http://www.w3.org/ns/ssn/wasOriginatedBy"></see></summary>
    let wasOriginatedBy =
        Namespaced_IRI.parse _namespace_name "wasOriginatedBy" |> NamespacedName

    /// <summary>
    /// Relation between a Platform and a Deployment, meaning that the deployedSystems of the Deployment are hosted on the Platform.
    /// <see href="http://www.w3.org/ns/ssn/inDeployment"></see></summary>
    let inDeployment =
        Namespaced_IRI.parse _namespace_name "inDeployment" |> NamespacedName

    /// <summary>
    /// Describes the Deployment of one or more Systems for a particular purpose. Deployment may be done on a Platform.
    /// <see href="http://www.w3.org/ns/ssn/Deployment"></see></summary>
    let Deployment = Namespaced_IRI.parse _namespace_name "Deployment" |> NamespacedName
    /// <summary>
    /// Relation between a Procedure and an Input to it.
    /// <see href="http://www.w3.org/ns/ssn/hasInput"></see></summary>
    let hasInput = Namespaced_IRI.parse _namespace_name "hasInput" |> NamespacedName
    /// <summary>
    /// Any information that is provided to a Procedure for its use.
    /// <see href="http://www.w3.org/ns/ssn/Input"></see></summary>
    let Input = Namespaced_IRI.parse _namespace_name "Input" |> NamespacedName
    /// <summary>
    /// Relation between a Procedure and an Output of it.
    /// <see href="http://www.w3.org/ns/ssn/hasOutput"></see></summary>
    let hasOutput = Namespaced_IRI.parse _namespace_name "hasOutput" |> NamespacedName
    /// <summary>
    /// Any information that is reported from a Procedure.
    /// <see href="http://www.w3.org/ns/ssn/Output"></see></summary>
    let Output = Namespaced_IRI.parse _namespace_name "Output" |> NamespacedName

    /// <summary>
    /// Relation between a Procedure (an algorithm, procedure or method) and an entity that implements that Procedure in some executable way.
    /// <see href="http://www.w3.org/ns/ssn/implementedBy"></see></summary>
    let implementedBy =
        Namespaced_IRI.parse _namespace_name "implementedBy" |> NamespacedName

    /// <summary>
    /// A relation from a Sensor to the Stimulus that the Sensor can detect. The Stimulus itself will be serving as a proxy for some ObservableProperty.
    /// <see href="http://www.w3.org/ns/ssn/detects"></see></summary>
    let detects = Namespaced_IRI.parse _namespace_name "detects" |> NamespacedName

    /// <summary>
    /// Relation between a Deployment and a deployed System.
    /// <see href="http://www.w3.org/ns/ssn/deployedSystem"></see></summary>
    let deployedSystem =
        Namespaced_IRI.parse _namespace_name "deployedSystem" |> NamespacedName

    /// <summary>
    /// Relation between a Deployment and the Platform on which the Systems are deployed.
    /// <see href="http://www.w3.org/ns/ssn/deployedOnPlatform"></see></summary>
    let deployedOnPlatform =
        Namespaced_IRI.parse _namespace_name "deployedOnPlatform" |> NamespacedName

    /// <summary>
    /// Relation between a Property and the entity it belongs to.
    /// <see href="http://www.w3.org/ns/ssn/isPropertyOf"></see></summary>
    let isPropertyOf =
        Namespaced_IRI.parse _namespace_name "isPropertyOf" |> NamespacedName

    /// <summary>
    /// Relation between a System and its component parts.
    /// <see href="http://www.w3.org/ns/ssn/hasSubSystem"></see></summary>
    let hasSubSystem =
        Namespaced_IRI.parse _namespace_name "hasSubSystem" |> NamespacedName

    /// <summary>
    /// Relation between a System and a Deployment, recording that the System is deployed in that Deployment.
    /// <see href="http://www.w3.org/ns/ssn/hasDeployment"></see></summary>
    let hasDeployment =
        Namespaced_IRI.parse _namespace_name "hasDeployment" |> NamespacedName
