namespace http.www.w3.org.ns.ssn.slash

open DoxAletheia

module ssno =
    let _namespace_name = "http://www.w3.org/ns/ssn/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A quality of an entity. An aspect of an entity that is intrinsic to and cannot exist without the entity.
    /// <see href="http://www.w3.org/ns/ssn/Property"></see></summary>
    let Property = _prefix "Property"
    /// <summary>
    /// Relation between an entity that implements a Procedure in some executable way and the Procedure (an algorithm, procedure or method).
    /// <see href="http://www.w3.org/ns/ssn/implements"></see></summary>
    let implements = _prefix "implements"
    /// <summary>
    /// A relation between some aspect of an entity and a Property.
    /// <see href="http://www.w3.org/ns/ssn/forProperty"></see></summary>
    let forProperty = _prefix "forProperty"
    /// <summary>
    /// System is a unit of abstraction for pieces of infrastructure that implements Procedures. A System may have components, its subsystems, which are other systems.
    /// <see href="http://www.w3.org/ns/ssn/System"></see></summary>
    let System = _prefix "System"
    /// <summary>
    /// Relation between an entity and a Property of that entity.
    /// <see href="http://www.w3.org/ns/ssn/hasProperty"></see></summary>
    let hasProperty = _prefix "hasProperty"
    /// <summary>
    /// A relation from a Stimulus to the Property that the Stimulus is serving as a proxy for.
    /// <see href="http://www.w3.org/ns/ssn/isProxyFor"></see></summary>
    let isProxyFor = _prefix "isProxyFor"
    /// <summary>
    /// An event in the real world that 'triggers' the Sensor. The properties associated to the Stimulus may be different to the eventual observed ObservableProperty. It is the event, not the object, that triggers the Sensor.
    /// <see href="http://www.w3.org/ns/ssn/Stimulus"></see></summary>
    let Stimulus = _prefix "Stimulus"
    /// <summary>
    /// Relation between an Observation and the Stimulus that originated it.
    /// <see href="http://www.w3.org/ns/ssn/wasOriginatedBy"></see></summary>
    let wasOriginatedBy = _prefix "wasOriginatedBy"
    /// <summary>
    /// Relation between a Platform and a Deployment, meaning that the deployedSystems of the Deployment are hosted on the Platform.
    /// <see href="http://www.w3.org/ns/ssn/inDeployment"></see></summary>
    let inDeployment = _prefix "inDeployment"
    /// <summary>
    /// Describes the Deployment of one or more Systems for a particular purpose. Deployment may be done on a Platform.
    /// <see href="http://www.w3.org/ns/ssn/Deployment"></see></summary>
    let Deployment = _prefix "Deployment"
    /// <summary>
    /// Relation between a Procedure and an Input to it.
    /// <see href="http://www.w3.org/ns/ssn/hasInput"></see></summary>
    let hasInput = _prefix "hasInput"
    /// <summary>
    /// Any information that is provided to a Procedure for its use.
    /// <see href="http://www.w3.org/ns/ssn/Input"></see></summary>
    let Input = _prefix "Input"
    /// <summary>
    /// Relation between a Procedure and an Output of it.
    /// <see href="http://www.w3.org/ns/ssn/hasOutput"></see></summary>
    let hasOutput = _prefix "hasOutput"
    /// <summary>
    /// Any information that is reported from a Procedure.
    /// <see href="http://www.w3.org/ns/ssn/Output"></see></summary>
    let Output = _prefix "Output"
    /// <summary>
    /// Relation between a Procedure (an algorithm, procedure or method) and an entity that implements that Procedure in some executable way.
    /// <see href="http://www.w3.org/ns/ssn/implementedBy"></see></summary>
    let implementedBy = _prefix "implementedBy"
    /// <summary>
    /// A relation from a Sensor to the Stimulus that the Sensor can detect. The Stimulus itself will be serving as a proxy for some ObservableProperty.
    /// <see href="http://www.w3.org/ns/ssn/detects"></see></summary>
    let detects = _prefix "detects"
    /// <summary>
    /// Relation between a Deployment and a deployed System.
    /// <see href="http://www.w3.org/ns/ssn/deployedSystem"></see></summary>
    let deployedSystem = _prefix "deployedSystem"
    /// <summary>
    /// Relation between a Deployment and the Platform on which the Systems are deployed.
    /// <see href="http://www.w3.org/ns/ssn/deployedOnPlatform"></see></summary>
    let deployedOnPlatform = _prefix "deployedOnPlatform"
    /// <summary>
    /// Relation between a Property and the entity it belongs to.
    /// <see href="http://www.w3.org/ns/ssn/isPropertyOf"></see></summary>
    let isPropertyOf = _prefix "isPropertyOf"
    /// <summary>
    /// Relation between a System and its component parts.
    /// <see href="http://www.w3.org/ns/ssn/hasSubSystem"></see></summary>
    let hasSubSystem = _prefix "hasSubSystem"
    /// <summary>
    /// Relation between a System and a Deployment, recording that the System is deployed in that Deployment.
    /// <see href="http://www.w3.org/ns/ssn/hasDeployment"></see></summary>
    let hasDeployment = _prefix "hasDeployment"
