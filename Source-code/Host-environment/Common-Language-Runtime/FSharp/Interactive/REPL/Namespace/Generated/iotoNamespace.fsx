#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ioto =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#" "ioto"

    /// <summary>
    ///   <para>rdfs:label : Business operation^^xsd:string</para>
    ///   <para>rdfs:comment : Service operation that is relevant to the business function of the service (and the object underneath in the case of IoT). This type of functions may be linked to a property the object deals with (monitoring or modification)^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#BusinessOperation">ioto:BusinessOperation</a>
    /// </summary>
    let BusinessOperation = _prefixId.prefix "BusinessOperation"
    /// <summary>
    ///   <para>rdfs:label : Business service^^xsd:string</para>
    ///   <para>rdfs:comment : Service intended to be an interface for the functionnalities the object was designed to perform : measure temperature for a temperature sensor, switch on/off for a switch...^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#BusinessService">ioto:BusinessService</a>
    /// </summary>
    let BusinessService = _prefixId.prefix "BusinessService"
    /// <summary>
    ///   <para>rdfs:label : Controlled system^^xsd:string</para>
    ///   <para>rdfs:comment : System implementing a control feedback loop in order to control an actuator thanks to the feedback of some sensors.^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#ControlledSystem">ioto:ControlledSystem</a>
    /// </summary>
    let ControlledSystem = _prefixId.prefix "ControlledSystem"
    /// <summary>
    ///   <para>rdfs:label : Defectuous System^^xsd:string</para>
    ///   <para>rdfs:comment : Controlled system that requires an operator attention, because it is not functionnig properly. Detected when the difference between the Observations and the Actuation made on the monitored property is out of its operating range.^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#DefectuousSystem">ioto:DefectuousSystem</a>
    /// </summary>
    let DefectuousSystem = _prefixId.prefix "DefectuousSystem"
    /// <summary>
    ///   <para>rdfs:label : Device management operation^^xsd:string</para>
    ///   <para>rdfs:comment : Service operation that deals with device management^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#DeviceManagementOperation">ioto:DeviceManagementOperation</a>
    /// </summary>
    let DeviceManagementOperation = _prefixId.prefix "DeviceManagementOperation"
    /// <summary>
    ///   <para>rdfs:label : Device management service^^xsd:string</para>
    ///   <para>rdfs:comment : This kind of service offers a set of operations regarding device management. That means it's not related to the functionnality of the object itsefl, but rather to its inner working : battery state, connectivity, firmware update...^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#DeviceManagementService">ioto:DeviceManagementService</a>
    /// </summary>
    let DeviceManagementService = _prefixId.prefix "DeviceManagementService"
    let EmptyMessage = _prefixId.prefix "EmptyMessage"
    /// <summary>
    ///   <para>rdfs:label : Impact on property^^xsd:string</para>
    ///   <para>rdfs:comment : This class describes the impact an operation may have on a property. It makes sense in an IoT environement, where things can manage properties of their environment and modify them.^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#ImpactOnProperty">ioto:ImpactOnProperty</a>
    /// </summary>
    let ImpactOnProperty = _prefixId.prefix "ImpactOnProperty"
    /// <summary>
    ///   <para>rdfs:label : IoT-Thing^^xsd:stringrdfs:label : Thing^^xsd:string</para>
    ///   <para>rdfs:comment : Most general thing in an iot ontology, a Thing can either be a physical connected object, an application, an abstracted interface... The class Object of DUL, from whom it inherits, doen't only represent physical objects, and can cover a fonction for instance.^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#IoT_Thing">ioto:IoT_Thing</a>
    /// </summary>
    let IoT_Thing = _prefixId.prefix "IoT_Thing"
    /// <summary>
    ///   <para>rdfs:label : Manager^^xsd:string</para>
    ///   <para>rdfs:comment : A manager is an application that offers management capabilities as described in the OneM2M norm.^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#Manager">ioto:Manager</a>
    /// </summary>
    let Manager = _prefixId.prefix "Manager"
    let SimpleDataContent = _prefixId.prefix "SimpleDataContent"
    /// <summary>
    ///   <para>rdfs:label : gets feedback from^^xsd:string</para>
    ///   <para>rdfs:comment : Relation between a controlled system and the entities that provide it with a feedback about its action, usually sensors.^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#getsFeedbackFrom">ioto:getsFeedbackFrom</a>
    /// </summary>
    let getsFeedbackFrom = _prefixId.prefix "getsFeedbackFrom"
    /// <summary>
    ///   <para>rdfs:label : has feature of interest^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between a Thing and a property of the environment. In a cyber-physical system, devices and software agents may have one to many feature of interest from the environment. This feature can be a property, another device, a person...^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#hasFeatureOfInterest">ioto:hasFeatureOfInterest</a>
    /// </summary>
    let hasFeatureOfInterest = _prefixId.prefix "hasFeatureOfInterest"
    /// <summary>
    ///   <para>rdfs:label : has id^^xsd:string</para>
    ///   <para>rdfs:comment : Characterizes a unique identifier for a thing^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#hasId">ioto:hasId</a>
    /// </summary>
    let hasId = _prefixId.prefix "hasId"
    /// <summary>
    ///   <para>rdfs:label : has impact^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between an operation and its impact on a property^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#hasImpact">ioto:hasImpact</a>
    /// </summary>
    let hasImpact = _prefixId.prefix "hasImpact"
    /// <summary>
    ///   <para>rdfs:label : on property^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between an impact and the impacted property^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#hasImpactonProperty">ioto:hasImpactonProperty</a>
    /// </summary>
    let hasImpactonProperty = _prefixId.prefix "hasImpactonProperty"
    /// <summary>
    ///   <para>rdfs:label : has relationship with property^^xsd:string</para>
    ///   <para>rdfs:comment : Generic property that marks the relationship between some entity and some ssn:Property. Dependant on context, it can be sensing, acting or else. Useful to descrie a generic service offered by a complex system that aggregates both sensors and actuators.^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#hasRelationshipWithProperty">ioto:hasRelationshipWithProperty</a>
    /// </summary>
    let hasRelationshipWithProperty = _prefixId.prefix "hasRelationshipWithProperty"
    /// <summary>
    ///   <para>rdfs:label : has service^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between an Entity and a service that is accessible through it.^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#hasService">ioto:hasService</a>
    /// </summary>
    let hasService = _prefixId.prefix "hasService"
    /// <summary>
    ///   <para>rdfs:comment : Associates an Instant individual with a timestamp^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#hasTimeStamp">ioto:hasTimeStamp</a>
    /// </summary>
    let hasTimeStamp = _prefixId.prefix "hasTimeStamp"
    /// <summary>
    ///   <para>rdfs:label : is feature of interest for^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that the property is the feature of interest of some entity of an IoT system, that can measure it/act upon it.^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#isFeatureOfInterestOf">ioto:isFeatureOfInterestOf</a>
    /// </summary>
    let isFeatureOfInterestOf = _prefixId.prefix "isFeatureOfInterestOf"
    /// <summary>
    ///   <para>rdfs:label : is impact of^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#isImpactOf">ioto:isImpactOf</a>
    /// </summary>
    let isImpactOf = _prefixId.prefix "isImpactOf"
    /// <summary>
    ///   <para>rdfs:label : is input message of^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#isInputMessageOf">ioto:isInputMessageOf</a>
    /// </summary>
    let isInputMessageOf = _prefixId.prefix "isInputMessageOf"
    /// <summary>
    ///   <para>rdfs:label : is service of^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between a service and an entity that accesses it.^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#isServiceOf">ioto:isServiceOf</a>
    /// </summary>
    let isServiceOf = _prefixId.prefix "isServiceOf"
    /// <summary>
    ///   <para>rdfs:label : property impacted by^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#propertyIsImpactedBy">ioto:propertyIsImpactedBy</a>
    /// </summary>
    let propertyIsImpactedBy = _prefixId.prefix "propertyIsImpactedBy"
    /// <summary>
    ///   <para>rdfs:label : provides feedback to^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between an entity that provides informations to a system and this system, that interprets these informations as a feedback of its action.^^xsd:string</para>
    ///   <a href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#providesFeedbackTo">ioto:providesFeedbackTo</a>
    /// </summary>
    let providesFeedbackTo = _prefixId.prefix "providesFeedbackTo"
