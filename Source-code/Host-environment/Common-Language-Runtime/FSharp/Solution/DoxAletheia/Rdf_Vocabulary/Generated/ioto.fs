namespace http.www.irit.fr.recherches.MELODI.ontologies.IoT_O.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ioto =
    let _namespace_iri = Namespace_Iri ioto |> NamespaceIRI
    /// <summary>
    ///   <para>ioto:BusinessOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Service operation that is relevant to the business function of the service (and the object underneath in the case of IoT). This type of functions may be linked to a property the object deals with (monitoring or modification)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Business operation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#BusinessOperation">http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#BusinessOperation</seealso>
    let BusinessOperation = Prefixed_Name(ioto, "BusinessOperation") |> PrefixedName
    /// <summary>
    ///   <para>ioto:BusinessService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Service intended to be an interface for the functionnalities the object was designed to perform : measure temperature for a temperature sensor, switch on/off for a switch..."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Business service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#BusinessService">http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#BusinessService</seealso>
    let BusinessService = Prefixed_Name(ioto, "BusinessService") |> PrefixedName
    /// <summary>
    ///   <para>ioto:ControlledSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"System implementing a control feedback loop in order to control an actuator thanks to the feedback of some sensors."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Controlled system"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#ControlledSystem">http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#ControlledSystem</seealso>
    let ControlledSystem = Prefixed_Name(ioto, "ControlledSystem") |> PrefixedName
    /// <summary>
    ///   <para>ioto:DefectuousSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Controlled system that requires an operator attention, because it is not functionnig properly. Detected when the difference between the Observations and the Actuation made on the monitored property is out of its operating range."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Defectuous System"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#DefectuousSystem">http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#DefectuousSystem</seealso>
    let DefectuousSystem = Prefixed_Name(ioto, "DefectuousSystem") |> PrefixedName

    /// <summary>
    ///   <para>ioto:DeviceManagementOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Service operation that deals with device management"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Device management operation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#DeviceManagementOperation">http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#DeviceManagementOperation</seealso>
    let DeviceManagementOperation =
        Prefixed_Name(ioto, "DeviceManagementOperation") |> PrefixedName

    /// <summary>
    ///   <para>ioto:DeviceManagementService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This kind of service offers a set of operations regarding device management. That means it's not related to the functionnality of the object itsefl, but rather to its inner working : battery state, connectivity, firmware update..."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Device management service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#DeviceManagementService">http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#DeviceManagementService</seealso>
    let DeviceManagementService =
        Prefixed_Name(ioto, "DeviceManagementService") |> PrefixedName

    /// <summary>
    ///   <para>ioto:EmptyMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>wsl:Message</para>
    ///   <para>"Specific message that has no content, its sole transfer achieves its purpose. For example, if an empty message is sent to the "switch light on" service of a light bulb, there is no need for an explicit content of the message asking the light to be turned on."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Empty message"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#EmptyMessage">http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#EmptyMessage</seealso>
    let EmptyMessage = Prefixed_Name(ioto, "EmptyMessage") |> PrefixedName
    /// <summary>
    ///   <para>ioto:ImpactOnProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class describes the impact an operation may have on a property. It makes sense in an IoT environement, where things can manage properties of their environment and modify them."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Impact on property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#ImpactOnProperty">http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#ImpactOnProperty</seealso>
    let ImpactOnProperty = Prefixed_Name(ioto, "ImpactOnProperty") |> PrefixedName
    /// <summary>
    ///   <para>ioto:IoT_Thing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Most general thing in an iot ontology, a Thing can either be a physical connected object, an application, an abstracted interface... The class Object of DUL, from whom it inherits, doen't only represent physical objects, and can cover a fonction for instance."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"IoT-Thing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Thing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#IoT_Thing">http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#IoT_Thing</seealso>
    let IoT_Thing = Prefixed_Name(ioto, "IoT_Thing") |> PrefixedName
    /// <summary>
    ///   <para>ioto:Manager</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A manager is an application that offers management capabilities as described in the OneM2M norm."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Manager"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#Manager">http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#Manager</seealso>
    let Manager = Prefixed_Name(ioto, "Manager") |> PrefixedName
    /// <summary>
    ///   <para>ioto:SimpleDataContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>msm:MessageContent</para>
    ///   <para>"This individual represents the body of a request containing simple data, such as a numerical value."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Simple data content"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#SimpleDataContent">http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#SimpleDataContent</seealso>
    let SimpleDataContent = Prefixed_Name(ioto, "SimpleDataContent") |> PrefixedName
    /// <summary>
    ///   <para>ioto:getsFeedbackFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation between a controlled system and the entities that provide it with a feedback about its action, usually sensors."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"gets feedback from"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#getsFeedbackFrom">http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#getsFeedbackFrom</seealso>
    let getsFeedbackFrom = Prefixed_Name(ioto, "getsFeedbackFrom") |> PrefixedName

    /// <summary>
    ///   <para>ioto:hasFeatureOfInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between a Thing and a property of the environment. In a cyber-physical system, devices and software agents may have one to many feature of interest from the environment. This feature can be a property, another device, a person..."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has feature of interest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#hasFeatureOfInterest">http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#hasFeatureOfInterest</seealso>
    let hasFeatureOfInterest =
        Prefixed_Name(ioto, "hasFeatureOfInterest") |> PrefixedName

    /// <summary>
    ///   <para>ioto:hasId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Characterizes a unique identifier for a thing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has id"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#hasId">http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#hasId</seealso>
    let hasId = Prefixed_Name(ioto, "hasId") |> PrefixedName
    /// <summary>
    ///   <para>ioto:hasImpact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between an operation and its impact on a property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has impact"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#hasImpact">http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#hasImpact</seealso>
    let hasImpact = Prefixed_Name(ioto, "hasImpact") |> PrefixedName
    /// <summary>
    ///   <para>ioto:hasImpactonProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between an impact and the impacted property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"on property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#hasImpactonProperty">http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#hasImpactonProperty</seealso>
    let hasImpactonProperty = Prefixed_Name(ioto, "hasImpactonProperty") |> PrefixedName

    /// <summary>
    ///   <para>ioto:hasRelationshipWithProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Generic property that marks the relationship between some entity and some ssn:Property. Dependant on context, it can be sensing, acting or else. Useful to descrie a generic service offered by a complex system that aggregates both sensors and actuators."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has relationship with property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#hasRelationshipWithProperty">http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#hasRelationshipWithProperty</seealso>
    let hasRelationshipWithProperty =
        Prefixed_Name(ioto, "hasRelationshipWithProperty") |> PrefixedName

    /// <summary>
    ///   <para>ioto:hasService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between an Entity and a service that is accessible through it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#hasService">http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#hasService</seealso>
    let hasService = Prefixed_Name(ioto, "hasService") |> PrefixedName
    /// <summary>
    ///   <para>ioto:hasTimeStamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Associates an Instant individual with a timestamp"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#hasTimeStamp">http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#hasTimeStamp</seealso>
    let hasTimeStamp = Prefixed_Name(ioto, "hasTimeStamp") |> PrefixedName

    /// <summary>
    ///   <para>ioto:isFeatureOfInterestOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that the property is the feature of interest of some entity of an IoT system, that can measure it/act upon it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is feature of interest for"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#isFeatureOfInterestOf">http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#isFeatureOfInterestOf</seealso>
    let isFeatureOfInterestOf =
        Prefixed_Name(ioto, "isFeatureOfInterestOf") |> PrefixedName

    /// <summary>
    ///   <para>ioto:isImpactOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is impact of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#isImpactOf">http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#isImpactOf</seealso>
    let isImpactOf = Prefixed_Name(ioto, "isImpactOf") |> PrefixedName
    /// <summary>
    ///   <para>ioto:isInputMessageOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is input message of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#isInputMessageOf">http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#isInputMessageOf</seealso>
    let isInputMessageOf = Prefixed_Name(ioto, "isInputMessageOf") |> PrefixedName
    /// <summary>
    ///   <para>ioto:isServiceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between a service and an entity that accesses it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is service of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#isServiceOf">http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#isServiceOf</seealso>
    let isServiceOf = Prefixed_Name(ioto, "isServiceOf") |> PrefixedName

    /// <summary>
    ///   <para>ioto:propertyIsImpactedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"property impacted by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#propertyIsImpactedBy">http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#propertyIsImpactedBy</seealso>
    let propertyIsImpactedBy =
        Prefixed_Name(ioto, "propertyIsImpactedBy") |> PrefixedName

    /// <summary>
    ///   <para>ioto:providesFeedbackTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between an entity that provides informations to a system and this system, that interprets these informations as a feedback of its action."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"provides feedback to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#providesFeedbackTo">http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#providesFeedbackTo</seealso>
    let providesFeedbackTo = Prefixed_Name(ioto, "providesFeedbackTo") |> PrefixedName
