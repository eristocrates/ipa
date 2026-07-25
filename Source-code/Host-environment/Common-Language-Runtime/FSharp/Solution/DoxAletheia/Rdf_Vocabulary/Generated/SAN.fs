namespace http.www.irit.fr.recherches.MELODI.ontologies.SAN.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module SAN =
    let _namespace_iri = Namespace_Iri SAN |> NamespaceIRI
    /// <summary>
    ///   <para>SAN:actuationMethodUsed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Process involved in the Actuation</para>
    /// labels<para>actuation method used</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#actuationMethodUsed">http://www.irit.fr/recherches/MELODI/ontologies/SAN#actuationMethodUsed</seealso>
    let actuationMethodUsed = Prefixed_Name(SAN, "actuationMethodUsed") |> PrefixedName

    /// <summary>
    ///   <para>SAN:hasActuatingProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation from an actuation capability to an actuation property.</para>
    /// labels<para>has actuation property</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#hasActuatingProperty">http://www.irit.fr/recherches/MELODI/ontologies/SAN#hasActuatingProperty</seealso>
    let hasActuatingProperty =
        Prefixed_Name(SAN, "hasActuatingProperty") |> PrefixedName

    /// <summary>
    ///   <para>SAN:ActuationValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Value of the command sent to an actuator</para>
    /// labels<para>Actuation Value</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuationValue">http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuationValue</seealso>
    let ActuationValue = Prefixed_Name(SAN, "ActuationValue") |> PrefixedName
    /// <summary>
    ///   <para>SAN:actsOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>Relationship between an entity that acts upon a quantity or another entity</para>
    /// labels<para>acts on</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#actsOn">http://www.irit.fr/recherches/MELODI/ontologies/SAN#actsOn</seealso>
    let actsOn = Prefixed_Name(SAN, "actsOn") |> PrefixedName
    /// <summary>
    ///   <para>SAN:hasEffect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between an Actuator and the effect that it induces. The Effect will be linked to a physical property that the actuator impacts</para>
    /// labels<para>has effect</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#hasEffect">http://www.irit.fr/recherches/MELODI/ontologies/SAN#hasEffect</seealso>
    let hasEffect = Prefixed_Name(SAN, "hasEffect") |> PrefixedName
    /// <summary>
    ///   <para>SAN:ActuatorInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An actuator input is a piece of information provided to an actuator describing its expected behaviour, and it is described by an Actuation Value</para>
    /// labels<para>Actuator Input</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuatorInput">http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuatorInput</seealso>
    let ActuatorInput = Prefixed_Name(SAN, "ActuatorInput") |> PrefixedName
    /// <summary>
    ///   <para>SAN:ActuatingProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A characteristic of an Actuator that gives information about the Actuations it is able to perform.</para>
    /// labels<para>Actuating Property</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuatingProperty">http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuatingProperty</seealso>
    let ActuatingProperty = Prefixed_Name(SAN, "ActuatingProperty") |> PrefixedName
    /// <summary>
    ///   <para>SAN:Acting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Acting is the process that results in an action on the physical world, might it be a motion, a display, the emission of a sound...</para>
    /// labels<para>Acting</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#Acting">http://www.irit.fr/recherches/MELODI/ontologies/SAN#Acting</seealso>
    let Acting = Prefixed_Name(SAN, "Acting") |> PrefixedName
    /// <summary>
    ///   <para>SAN:ActuatingRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Range of commands that the actuator can receive and transduce into the physical world without damage to itself or security issues to its surrounding environment.</para>
    /// labels<para>Actuating Range</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuatingRange">http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuatingRange</seealso>
    let ActuatingRange = Prefixed_Name(SAN, "ActuatingRange") |> PrefixedName
    /// <summary>
    ///   <para>SAN:ActuatingTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Time between the moment when the actuator receives an actuation command and the actual actuation.</para>
    /// labels<para>Actuating Time</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuatingTime">http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuatingTime</seealso>
    let ActuatingTime = Prefixed_Name(SAN, "ActuatingTime") |> PrefixedName
    /// <summary>
    ///   <para>SAN:Actuation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An Actuation is the abstract representation of the command that will be translated into Effect by the Actuator (cf http://ontologydesignpatterns.org/wiki/Submissions:Actuation-Actuator-Effect for more information).</para>
    /// labels<para>Actuation</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#Actuation">http://www.irit.fr/recherches/MELODI/ontologies/SAN#Actuation</seealso>
    let Actuation = Prefixed_Name(SAN, "Actuation") |> PrefixedName
    /// <summary>
    ///   <para>SAN:wasActuationSent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between an actuation that was sent and the actuator that received it</para>
    /// labels<para>was actuation sent</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#wasActuationSent">http://www.irit.fr/recherches/MELODI/ontologies/SAN#wasActuationSent</seealso>
    let wasActuationSent = Prefixed_Name(SAN, "wasActuationSent") |> PrefixedName
    /// <summary>
    ///   <para>SAN:Effect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Concept bound to the definition of an actuator as an agent havong an effect on the physical world. Therefore, an effect is any kind of physical modification induced by an actuator.</para>
    /// labels<para>Effect</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#Effect">http://www.irit.fr/recherches/MELODI/ontologies/SAN#Effect</seealso>
    let Effect = Prefixed_Name(SAN, "Effect") |> PrefixedName
    /// <summary>
    ///   <para>SAN:hasDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between an event (DUL:Region) and a point in time.</para>
    /// labels<para>has date time</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#hasDateTime">http://www.irit.fr/recherches/MELODI/ontologies/SAN#hasDateTime</seealso>
    let hasDateTime = Prefixed_Name(SAN, "hasDateTime") |> PrefixedName

    /// <summary>
    ///   <para>SAN:hasActuatingCapability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between an Actuator and an ActuatingCapability, describing the actuating properties of an actuator.</para>
    /// labels<para>has actuation capability</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#hasActuatingCapability">http://www.irit.fr/recherches/MELODI/ontologies/SAN#hasActuatingCapability</seealso>
    let hasActuatingCapability =
        Prefixed_Name(SAN, "hasActuatingCapability") |> PrefixedName

    /// <summary>
    ///   <para>SAN:isConsumedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes a relation between a consumer and a consumee</para>
    /// labels<para>is consumed by</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#isConsumedBy">http://www.irit.fr/recherches/MELODI/ontologies/SAN#isConsumedBy</seealso>
    let isConsumedBy = Prefixed_Name(SAN, "isConsumedBy") |> PrefixedName
    /// <summary>
    ///   <para>SAN:impacts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between an effect and the property it impacts. Used in the Effect-Actuator-Actuation design pattern to describe the link between an actuator and the physical property it acts upon.</para>
    /// labels<para>impacts</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#impacts">http://www.irit.fr/recherches/MELODI/ontologies/SAN#impacts</seealso>
    let impacts = Prefixed_Name(SAN, "impacts") |> PrefixedName
    /// <summary>
    ///   <para>SAN:isActedUponBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between an entity that is acted upen by another acting entity</para>
    /// labels<para>is acted upon by</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#isActedUponBy">http://www.irit.fr/recherches/MELODI/ontologies/SAN#isActedUponBy</seealso>
    let isActedUponBy = Prefixed_Name(SAN, "isActedUponBy") |> PrefixedName
    /// <summary>
    ///   <para>SAN:consumes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between an consumer entity and a consumee entity. Consumption can be destructive, transformative or neutral for the consumed entity.</para>
    /// labels<para>consumes</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#consumes">http://www.irit.fr/recherches/MELODI/ontologies/SAN#consumes</seealso>
    let consumes = Prefixed_Name(SAN, "consumes") |> PrefixedName
    /// <summary>
    ///   <para>SAN:ActuatorOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Behaviour of an actuator after it has been given an input. To stick to its definition, an actuator output must have an effect on the physical world.</para>
    /// labels<para>Actuator Output</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuatorOutput">http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuatorOutput</seealso>
    let ActuatorOutput = Prefixed_Name(SAN, "ActuatorOutput") |> PrefixedName
    /// <summary>
    ///   <para>SAN:controlledBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the relationship between a controlledentity and a controller  one. The controlled entity can be a situation (state of a system, property of an environment), a device, a piece of software...</para>
    /// labels<para>controlled by</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#controlledBy">http://www.irit.fr/recherches/MELODI/ontologies/SAN#controlledBy</seealso>
    let controlledBy = Prefixed_Name(SAN, "controlledBy") |> PrefixedName
    /// <summary>
    ///   <para>SAN:actuationResults</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between an actuation and an actuator input, its result. Implements the ODP Effect-Actuator-Observation</para>
    /// labels<para>actuation results</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#actuationResults">http://www.irit.fr/recherches/MELODI/ontologies/SAN#actuationResults</seealso>
    let actuationResults = Prefixed_Name(SAN, "actuationResults") |> PrefixedName
    /// <summary>
    ///   <para>SAN:isController</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An entity is controller of another one when it has influence on its decision process or evolution in time.</para>
    /// labels<para>is controller</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#isController">http://www.irit.fr/recherches/MELODI/ontologies/SAN#isController</seealso>
    let isController = Prefixed_Name(SAN, "isController") |> PrefixedName
    /// <summary>
    ///   <para>SAN:receivedActuation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between an actuator and an Actuation it received in order to modify its action.</para>
    /// labels<para>received actuation</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#receivedActuation">http://www.irit.fr/recherches/MELODI/ontologies/SAN#receivedActuation</seealso>
    let receivedActuation = Prefixed_Name(SAN, "receivedActuation") |> PrefixedName
    /// <summary>
    ///   <para>SAN:ActuatingCapability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents actuation properties such as precision, latency, power consumption, and the environmental conditions in which these actuation can take place normally.</para>
    /// labels<para>Actuating Capability</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuatingCapability">http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuatingCapability</seealso>
    let ActuatingCapability = Prefixed_Name(SAN, "ActuatingCapability") |> PrefixedName
    /// <summary>
    ///   <para>SAN:ActuatingDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A device that implements actuating</para>
    /// labels<para>Actuating device</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuatingDevice">http://www.irit.fr/recherches/MELODI/ontologies/SAN#ActuatingDevice</seealso>
    let ActuatingDevice = Prefixed_Name(SAN, "ActuatingDevice") |> PrefixedName
    /// <summary>
    ///   <para>SAN:Actuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An actuator is an entity which is able to act upon the physical world. Whether it is a light bulb or a servomotor, an actuator receives inputs represented by Actuations and produces an effect on the world.</para>
    /// labels<para>Actuator</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/SAN#Actuator">http://www.irit.fr/recherches/MELODI/ontologies/SAN#Actuator</seealso>
    let Actuator = Prefixed_Name(SAN, "Actuator") |> PrefixedName
