namespace http.www.irit.fr.recherches.MELODI.ontologies.SAN.hash

open DoxAletheia.Rdf_Vocabulary

module san =
    let _namespace_name = "http://www.irit.fr/recherches/MELODI/ontologies/SAN#"
    /// <summary>
    /// Acting is the process that results in an action on the physical world, might it be a motion, a display, the emission of a sound...
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#Acting"></see></summary>
    let Acting = Namespaced_IRI.parse _namespace_name "Acting" |> NamespacedName

    /// <summary>
    /// Represents actuation properties such as precision, latency, power consumption, and the environmental conditions in which these actuation can take place normally.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuatingCapability"></see></summary>
    let ActuatingCapability =
        Namespaced_IRI.parse _namespace_name "ActuatingCapability" |> NamespacedName

    /// <summary>
    /// A characteristic of an Actuator that gives information about the Actuations it is able to perform.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuatingProperty"></see></summary>
    let ActuatingProperty =
        Namespaced_IRI.parse _namespace_name "ActuatingProperty" |> NamespacedName

    /// <summary>
    /// Relation from an actuation capability to an actuation property.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#hasActuatingProperty"></see></summary>
    let hasActuatingProperty =
        Namespaced_IRI.parse _namespace_name "hasActuatingProperty" |> NamespacedName

    /// <summary>
    /// A device that implements actuating
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuatingDevice"></see></summary>
    let ActuatingDevice =
        Namespaced_IRI.parse _namespace_name "ActuatingDevice" |> NamespacedName

    /// <summary>
    /// An actuator is an entity which is able to act upon the physical world. Whether it is a light bulb or a servomotor, an actuator receives inputs represented by Actuations and produces an effect on the world.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#Actuator"></see></summary>
    let Actuator = Namespaced_IRI.parse _namespace_name "Actuator" |> NamespacedName

    /// <summary>
    /// Range of commands that the actuator can receive and transduce into the physical world without damage to itself or security issues to its surrounding environment.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuatingRange"></see></summary>
    let ActuatingRange =
        Namespaced_IRI.parse _namespace_name "ActuatingRange" |> NamespacedName

    /// <summary>
    /// Time between the moment when the actuator receives an actuation command and the actual actuation.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuatingTime"></see></summary>
    let ActuatingTime =
        Namespaced_IRI.parse _namespace_name "ActuatingTime" |> NamespacedName

    /// <summary>
    /// An Actuation is the abstract representation of the command that will be translated into Effect by the Actuator (cf http://ontologydesignpatterns.org/wiki/Submissions:Actuation-Actuator-Effect for more information).
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#Actuation"></see></summary>
    let Actuation = Namespaced_IRI.parse _namespace_name "Actuation" |> NamespacedName

    /// <summary>
    /// Relationship between an actuation that was sent and the actuator that received it
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#wasActuationSent"></see></summary>
    let wasActuationSent =
        Namespaced_IRI.parse _namespace_name "wasActuationSent" |> NamespacedName

    /// <summary>
    /// Concept bound to the definition of an actuator as an agent havong an effect on the physical world. Therefore, an effect is any kind of physical modification induced by an actuator.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#Effect"></see></summary>
    let Effect = Namespaced_IRI.parse _namespace_name "Effect" |> NamespacedName

    /// <summary>
    /// Process involved in the Actuation
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#actuationMethodUsed"></see></summary>
    let actuationMethodUsed =
        Namespaced_IRI.parse _namespace_name "actuationMethodUsed" |> NamespacedName

    /// <summary>
    /// Value of the command sent to an actuator
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuationValue"></see></summary>
    let ActuationValue =
        Namespaced_IRI.parse _namespace_name "ActuationValue" |> NamespacedName

    /// <summary>
    /// Relationship between an event (DUL:Region) and a point in time.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#hasDateTime"></see></summary>
    let hasDateTime =
        Namespaced_IRI.parse _namespace_name "hasDateTime" |> NamespacedName

    /// <summary>
    /// Relationship between an entity that acts upon a quantity or another entity
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#actsOn"></see></summary>
    let actsOn = Namespaced_IRI.parse _namespace_name "actsOn" |> NamespacedName
    /// <summary>
    /// Relationship between an Actuator and the effect that it induces. The Effect will be linked to a physical property that the actuator impacts
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#hasEffect"></see></summary>
    let hasEffect = Namespaced_IRI.parse _namespace_name "hasEffect" |> NamespacedName

    /// <summary>
    /// Relation between an Actuator and an ActuatingCapability, describing the actuating properties of an actuator.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#hasActuatingCapability"></see></summary>
    let hasActuatingCapability =
        Namespaced_IRI.parse _namespace_name "hasActuatingCapability" |> NamespacedName

    /// <summary>
    /// An actuator input is a piece of information provided to an actuator describing its expected behaviour, and it is described by an Actuation Value
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuatorInput"></see></summary>
    let ActuatorInput =
        Namespaced_IRI.parse _namespace_name "ActuatorInput" |> NamespacedName

    /// <summary>
    /// Describes a relation between a consumer and a consumee
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#isConsumedBy"></see></summary>
    let isConsumedBy =
        Namespaced_IRI.parse _namespace_name "isConsumedBy" |> NamespacedName

    /// <summary>
    /// Behaviour of an actuator after it has been given an input. To stick to its definition, an actuator output must have an effect on the physical world.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuatorOutput"></see></summary>
    let ActuatorOutput =
        Namespaced_IRI.parse _namespace_name "ActuatorOutput" |> NamespacedName

    /// <summary>
    /// Relationship between an effect and the property it impacts. Used in the Effect-Actuator-Actuation design pattern to describe the link between an actuator and the physical property it acts upon.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#impacts"></see></summary>
    let impacts = Namespaced_IRI.parse _namespace_name "impacts" |> NamespacedName

    /// <summary>
    /// Relation between an entity that is acted upen by another acting entity
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#isActedUponBy"></see></summary>
    let isActedUponBy =
        Namespaced_IRI.parse _namespace_name "isActedUponBy" |> NamespacedName

    /// <summary>
    /// Relation between an actuation and an actuator input, its result. Implements the ODP Effect-Actuator-Observation
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#actuationResults"></see></summary>
    let actuationResults =
        Namespaced_IRI.parse _namespace_name "actuationResults" |> NamespacedName

    /// <summary>
    /// Relation between an consumer entity and a consumee entity. Consumption can be destructive, transformative or neutral for the consumed entity.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#consumes"></see></summary>
    let consumes = Namespaced_IRI.parse _namespace_name "consumes" |> NamespacedName

    /// <summary>
    /// Describes the relationship between a controlledentity and a controller  one. The controlled entity can be a situation (state of a system, property of an environment), a device, a piece of software...
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#controlledBy"></see></summary>
    let controlledBy =
        Namespaced_IRI.parse _namespace_name "controlledBy" |> NamespacedName

    /// <summary>
    /// An entity is controller of another one when it has influence on its decision process or evolution in time.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#isController"></see></summary>
    let isController =
        Namespaced_IRI.parse _namespace_name "isController" |> NamespacedName

    /// <summary>
    /// Relationship between an actuator and an Actuation it received in order to modify its action.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#receivedActuation"></see></summary>
    let receivedActuation =
        Namespaced_IRI.parse _namespace_name "receivedActuation" |> NamespacedName
