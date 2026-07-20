namespace http.www.irit.fr.recherches.MELODI.ontologies.SAN.hash

open DoxAletheia

module san =
    let _namespace_name = "http://www.irit.fr/recherches/MELODI/ontologies/SAN#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Acting is the process that results in an action on the physical world, might it be a motion, a display, the emission of a sound...
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#Acting"></see></summary>
    let Acting = _prefix "Acting"
    /// <summary>
    /// Represents actuation properties such as precision, latency, power consumption, and the environmental conditions in which these actuation can take place normally.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuatingCapability"></see></summary>
    let ActuatingCapability = _prefix "ActuatingCapability"
    /// <summary>
    /// A characteristic of an Actuator that gives information about the Actuations it is able to perform.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuatingProperty"></see></summary>
    let ActuatingProperty = _prefix "ActuatingProperty"
    /// <summary>
    /// Relation from an actuation capability to an actuation property.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#hasActuatingProperty"></see></summary>
    let hasActuatingProperty = _prefix "hasActuatingProperty"
    /// <summary>
    /// A device that implements actuating
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuatingDevice"></see></summary>
    let ActuatingDevice = _prefix "ActuatingDevice"
    /// <summary>
    /// An actuator is an entity which is able to act upon the physical world. Whether it is a light bulb or a servomotor, an actuator receives inputs represented by Actuations and produces an effect on the world.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#Actuator"></see></summary>
    let Actuator = _prefix "Actuator"
    /// <summary>
    /// Range of commands that the actuator can receive and transduce into the physical world without damage to itself or security issues to its surrounding environment.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuatingRange"></see></summary>
    let ActuatingRange = _prefix "ActuatingRange"
    /// <summary>
    /// Time between the moment when the actuator receives an actuation command and the actual actuation.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuatingTime"></see></summary>
    let ActuatingTime = _prefix "ActuatingTime"
    /// <summary>
    /// An Actuation is the abstract representation of the command that will be translated into Effect by the Actuator (cf http://ontologydesignpatterns.org/wiki/Submissions:Actuation-Actuator-Effect for more information).
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#Actuation"></see></summary>
    let Actuation = _prefix "Actuation"
    /// <summary>
    /// Relationship between an actuation that was sent and the actuator that received it
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#wasActuationSent"></see></summary>
    let wasActuationSent = _prefix "wasActuationSent"
    /// <summary>
    /// Concept bound to the definition of an actuator as an agent havong an effect on the physical world. Therefore, an effect is any kind of physical modification induced by an actuator.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#Effect"></see></summary>
    let Effect = _prefix "Effect"
    /// <summary>
    /// Process involved in the Actuation
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#actuationMethodUsed"></see></summary>
    let actuationMethodUsed = _prefix "actuationMethodUsed"
    /// <summary>
    /// Value of the command sent to an actuator
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuationValue"></see></summary>
    let ActuationValue = _prefix "ActuationValue"
    /// <summary>
    /// Relationship between an event (DUL:Region) and a point in time.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#hasDateTime"></see></summary>
    let hasDateTime = _prefix "hasDateTime"
    /// <summary>
    /// Relationship between an entity that acts upon a quantity or another entity
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#actsOn"></see></summary>
    let actsOn = _prefix "actsOn"
    /// <summary>
    /// Relationship between an Actuator and the effect that it induces. The Effect will be linked to a physical property that the actuator impacts
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#hasEffect"></see></summary>
    let hasEffect = _prefix "hasEffect"
    /// <summary>
    /// Relation between an Actuator and an ActuatingCapability, describing the actuating properties of an actuator.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#hasActuatingCapability"></see></summary>
    let hasActuatingCapability = _prefix "hasActuatingCapability"
    /// <summary>
    /// An actuator input is a piece of information provided to an actuator describing its expected behaviour, and it is described by an Actuation Value
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuatorInput"></see></summary>
    let ActuatorInput = _prefix "ActuatorInput"
    /// <summary>
    /// Describes a relation between a consumer and a consumee
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#isConsumedBy"></see></summary>
    let isConsumedBy = _prefix "isConsumedBy"
    /// <summary>
    /// Behaviour of an actuator after it has been given an input. To stick to its definition, an actuator output must have an effect on the physical world.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuatorOutput"></see></summary>
    let ActuatorOutput = _prefix "ActuatorOutput"
    /// <summary>
    /// Relationship between an effect and the property it impacts. Used in the Effect-Actuator-Actuation design pattern to describe the link between an actuator and the physical property it acts upon.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#impacts"></see></summary>
    let impacts = _prefix "impacts"
    /// <summary>
    /// Relation between an entity that is acted upen by another acting entity
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#isActedUponBy"></see></summary>
    let isActedUponBy = _prefix "isActedUponBy"
    /// <summary>
    /// Relation between an actuation and an actuator input, its result. Implements the ODP Effect-Actuator-Observation
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#actuationResults"></see></summary>
    let actuationResults = _prefix "actuationResults"
    /// <summary>
    /// Relation between an consumer entity and a consumee entity. Consumption can be destructive, transformative or neutral for the consumed entity.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#consumes"></see></summary>
    let consumes = _prefix "consumes"
    /// <summary>
    /// Describes the relationship between a controlledentity and a controller  one. The controlled entity can be a situation (state of a system, property of an environment), a device, a piece of software...
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#controlledBy"></see></summary>
    let controlledBy = _prefix "controlledBy"
    /// <summary>
    /// An entity is controller of another one when it has influence on its decision process or evolution in time.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#isController"></see></summary>
    let isController = _prefix "isController"
    /// <summary>
    /// Relationship between an actuator and an Actuation it received in order to modify its action.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#receivedActuation"></see></summary>
    let receivedActuation = _prefix "receivedActuation"
