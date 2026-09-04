#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module SAN =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.irit.fr/recherches/MELODI/ontologies/SAN#" "SAN"

    /// <summary>
    ///   <para>rdfs:label : Acting^^xsd:string</para>
    ///   <para>rdfs:comment : Acting is the process that results in an action on the physical world, might it be a motion, a display, the emission of a sound...^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#Acting">SAN:Acting</a>
    /// </summary>
    let Acting = _prefixId.prefix "Acting"
    /// <summary>
    ///   <para>rdfs:label : Actuating Capability^^xsd:string</para>
    ///   <para>rdfs:comment : Represents actuation properties such as precision, latency, power consumption, and the environmental conditions in which these actuation can take place normally.^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuatingCapability">SAN:ActuatingCapability</a>
    /// </summary>
    let ActuatingCapability = _prefixId.prefix "ActuatingCapability"
    /// <summary>
    ///   <para>rdfs:label : Actuating device^^xsd:string</para>
    ///   <para>rdfs:comment : A device that implements actuating^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuatingDevice">SAN:ActuatingDevice</a>
    /// </summary>
    let ActuatingDevice = _prefixId.prefix "ActuatingDevice"
    /// <summary>
    ///   <para>rdfs:label : Actuating Property^^xsd:string</para>
    ///   <para>rdfs:comment : A characteristic of an Actuator that gives information about the Actuations it is able to perform.^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuatingProperty">SAN:ActuatingProperty</a>
    /// </summary>
    let ActuatingProperty = _prefixId.prefix "ActuatingProperty"
    /// <summary>
    ///   <para>rdfs:label : Actuating Range^^xsd:string</para>
    ///   <para>rdfs:comment : Range of commands that the actuator can receive and transduce into the physical world without damage to itself or security issues to its surrounding environment.^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuatingRange">SAN:ActuatingRange</a>
    /// </summary>
    let ActuatingRange = _prefixId.prefix "ActuatingRange"
    /// <summary>
    ///   <para>rdfs:label : Actuating Time^^xsd:string</para>
    ///   <para>rdfs:comment : Time between the moment when the actuator receives an actuation command and the actual actuation.^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuatingTime">SAN:ActuatingTime</a>
    /// </summary>
    let ActuatingTime = _prefixId.prefix "ActuatingTime"
    /// <summary>
    ///   <para>rdfs:label : Actuation^^xsd:string</para>
    ///   <para>rdfs:comment : An Actuation is the abstract representation of the command that will be translated into Effect by the Actuator (cf http://ontologydesignpatterns.org/wiki/Submissions:Actuation-Actuator-Effect for more information).^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#Actuation">SAN:Actuation</a>
    /// </summary>
    let Actuation = _prefixId.prefix "Actuation"
    /// <summary>
    ///   <para>rdfs:label : Actuation Value^^xsd:string</para>
    ///   <para>rdfs:comment : Value of the command sent to an actuator^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuationValue">SAN:ActuationValue</a>
    /// </summary>
    let ActuationValue = _prefixId.prefix "ActuationValue"
    /// <summary>
    ///   <para>rdfs:label : Actuator^^xsd:string</para>
    ///   <para>rdfs:comment : An actuator is an entity which is able to act upon the physical world. Whether it is a light bulb or a servomotor, an actuator receives inputs represented by Actuations and produces an effect on the world.^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#Actuator">SAN:Actuator</a>
    /// </summary>
    let Actuator = _prefixId.prefix "Actuator"
    /// <summary>
    ///   <para>rdfs:label : Actuator Input^^xsd:string</para>
    ///   <para>rdfs:comment : An actuator input is a piece of information provided to an actuator describing its expected behaviour, and it is described by an Actuation Value^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuatorInput">SAN:ActuatorInput</a>
    /// </summary>
    let ActuatorInput = _prefixId.prefix "ActuatorInput"
    /// <summary>
    ///   <para>rdfs:label : Actuator Output^^xsd:string</para>
    ///   <para>rdfs:comment : Behaviour of an actuator after it has been given an input. To stick to its definition, an actuator output must have an effect on the physical world.^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuatorOutput">SAN:ActuatorOutput</a>
    /// </summary>
    let ActuatorOutput = _prefixId.prefix "ActuatorOutput"
    /// <summary>
    ///   <para>rdfs:label : Effect^^xsd:string</para>
    ///   <para>rdfs:comment : Concept bound to the definition of an actuator as an agent havong an effect on the physical world. Therefore, an effect is any kind of physical modification induced by an actuator.^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#Effect">SAN:Effect</a>
    /// </summary>
    let Effect = _prefixId.prefix "Effect"
    /// <summary>
    ///   <para>rdfs:label : acts on^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between an entity that acts upon a quantity or another entity^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#actsOn">SAN:actsOn</a>
    /// </summary>
    let actsOn = _prefixId.prefix "actsOn"
    /// <summary>
    ///   <para>rdfs:label : actuation method used^^xsd:string</para>
    ///   <para>rdfs:comment : Process involved in the Actuation^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#actuationMethodUsed">SAN:actuationMethodUsed</a>
    /// </summary>
    let actuationMethodUsed = _prefixId.prefix "actuationMethodUsed"
    /// <summary>
    ///   <para>rdfs:label : actuation results^^xsd:string</para>
    ///   <para>rdfs:comment : Relation between an actuation and an actuator input, its result. Implements the ODP Effect-Actuator-Observation^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#actuationResults">SAN:actuationResults</a>
    /// </summary>
    let actuationResults = _prefixId.prefix "actuationResults"
    /// <summary>
    ///   <para>rdfs:label : consumes^^xsd:string</para>
    ///   <para>rdfs:comment : Relation between an consumer entity and a consumee entity. Consumption can be destructive, transformative or neutral for the consumed entity.^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#consumes">SAN:consumes</a>
    /// </summary>
    let consumes = _prefixId.prefix "consumes"
    /// <summary>
    ///   <para>rdfs:label : controlled by^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the relationship between a controlledentity and a controller  one. The controlled entity can be a situation (state of a system, property of an environment), a device, a piece of software...^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#controlledBy">SAN:controlledBy</a>
    /// </summary>
    let controlledBy = _prefixId.prefix "controlledBy"
    /// <summary>
    ///   <para>rdfs:label : has actuation capability^^xsd:string</para>
    ///   <para>rdfs:comment : Relation between an Actuator and an ActuatingCapability, describing the actuating properties of an actuator.^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#hasActuatingCapability">SAN:hasActuatingCapability</a>
    /// </summary>
    let hasActuatingCapability = _prefixId.prefix "hasActuatingCapability"
    /// <summary>
    ///   <para>rdfs:label : has actuation property^^xsd:string</para>
    ///   <para>rdfs:comment : Relation from an actuation capability to an actuation property.^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#hasActuatingProperty">SAN:hasActuatingProperty</a>
    /// </summary>
    let hasActuatingProperty = _prefixId.prefix "hasActuatingProperty"
    /// <summary>
    ///   <para>rdfs:label : has date time^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between an event (DUL:Region) and a point in time.^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#hasDateTime">SAN:hasDateTime</a>
    /// </summary>
    let hasDateTime = _prefixId.prefix "hasDateTime"
    /// <summary>
    ///   <para>rdfs:label : has effect^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between an Actuator and the effect that it induces. The Effect will be linked to a physical property that the actuator impacts^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#hasEffect">SAN:hasEffect</a>
    /// </summary>
    let hasEffect = _prefixId.prefix "hasEffect"
    /// <summary>
    ///   <para>rdfs:label : impacts^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between an effect and the property it impacts. Used in the Effect-Actuator-Actuation design pattern to describe the link between an actuator and the physical property it acts upon.^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#impacts">SAN:impacts</a>
    /// </summary>
    let impacts = _prefixId.prefix "impacts"
    /// <summary>
    ///   <para>rdfs:label : is acted upon by^^xsd:string</para>
    ///   <para>rdfs:comment : Relation between an entity that is acted upen by another acting entity^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#isActedUponBy">SAN:isActedUponBy</a>
    /// </summary>
    let isActedUponBy = _prefixId.prefix "isActedUponBy"
    /// <summary>
    ///   <para>rdfs:label : is consumed by^^xsd:string</para>
    ///   <para>rdfs:comment : Describes a relation between a consumer and a consumee^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#isConsumedBy">SAN:isConsumedBy</a>
    /// </summary>
    let isConsumedBy = _prefixId.prefix "isConsumedBy"
    /// <summary>
    ///   <para>rdfs:label : is controller^^xsd:string</para>
    ///   <para>rdfs:comment : An entity is controller of another one when it has influence on its decision process or evolution in time.^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#isController">SAN:isController</a>
    /// </summary>
    let isController = _prefixId.prefix "isController"
    /// <summary>
    ///   <para>rdfs:label : received actuation^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between an actuator and an Actuation it received in order to modify its action.^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#receivedActuation">SAN:receivedActuation</a>
    /// </summary>
    let receivedActuation = _prefixId.prefix "receivedActuation"
    /// <summary>
    ///   <para>rdfs:label : was actuation sent^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between an actuation that was sent and the actuator that received it^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#wasActuationSent">SAN:wasActuationSent</a>
    /// </summary>
    let wasActuationSent = _prefixId.prefix "wasActuationSent"
