namespace http.www.irit.fr.recherches.MELODI.ontologies.IoT_O.hash

open DoxAletheia

module ioto =
    let _namespace_name = "http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Most general thing in an iot ontology, a Thing can either be a physical connected object, an application, an abstracted interface... The class Object of DUL, from whom it inherits, doen't only represent physical objects, and can cover a fonction for instance.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#IoT_Thing"></see></summary>
    let IoT_Thing = _prefix "IoT_Thing"
    /// <summary>
    /// Service operation that is relevant to the business function of the service (and the object underneath in the case of IoT). This type of functions may be linked to a property the object deals with (monitoring or modification)
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#BusinessOperation"></see></summary>
    let BusinessOperation = _prefix "BusinessOperation"
    /// <summary>
    /// Service intended to be an interface for the functionnalities the object was designed to perform : measure temperature for a temperature sensor, switch on/off for a switch...
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#BusinessService"></see></summary>
    let BusinessService = _prefix "BusinessService"
    /// <summary>
    /// Generic property that marks the relationship between some entity and some ssn:Property. Dependant on context, it can be sensing, acting or else. Useful to descrie a generic service offered by a complex system that aggregates both sensors and actuators.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#hasRelationshipWithProperty"></see></summary>
    let hasRelationshipWithProperty = _prefix "hasRelationshipWithProperty"
    /// <summary>
    /// System implementing a control feedback loop in order to control an actuator thanks to the feedback of some sensors.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#ControlledSystem"></see></summary>
    let ControlledSystem = _prefix "ControlledSystem"
    /// <summary>
    /// Relation between a controlled system and the entities that provide it with a feedback about its action, usually sensors.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#getsFeedbackFrom"></see></summary>
    let getsFeedbackFrom = _prefix "getsFeedbackFrom"
    /// <summary>
    /// Controlled system that requires an operator attention, because it is not functionnig properly. Detected when the difference between the Observations and the Actuation made on the monitored property is out of its operating range.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#DefectuousSystem"></see></summary>
    let DefectuousSystem = _prefix "DefectuousSystem"
    /// <summary>
    /// Service operation that deals with device management
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#DeviceManagementOperation"></see></summary>
    let DeviceManagementOperation = _prefix "DeviceManagementOperation"
    /// <summary>
    /// This kind of service offers a set of operations regarding device management. That means it's not related to the functionnality of the object itsefl, but rather to its inner working : battery state, connectivity, firmware update...
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#DeviceManagementService"></see></summary>
    let DeviceManagementService = _prefix "DeviceManagementService"
    /// <summary>
    /// Specific message that has no content, its sole transfer achieves its purpose. For example, if an empty message is sent to the "switch light on" service of a light bulb, there is no need for an explicit content of the message asking the light to be turned on.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#EmptyMessage"></see></summary>
    let EmptyMessage = _prefix "EmptyMessage"
    /// <summary>
    /// This class describes the impact an operation may have on a property. It makes sense in an IoT environement, where things can manage properties of their environment and modify them.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#ImpactOnProperty"></see></summary>
    let ImpactOnProperty = _prefix "ImpactOnProperty"
    /// <summary>
    /// Relationship between an Entity and a service that is accessible through it.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#hasService"></see></summary>
    let hasService = _prefix "hasService"
    /// <summary>
    /// A manager is an application that offers management capabilities as described in the OneM2M norm.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#Manager"></see></summary>
    let Manager = _prefix "Manager"
    /// <summary>
    /// This individual represents the body of a request containing simple data, such as a numerical value.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#SimpleDataContent"></see></summary>
    let SimpleDataContent = _prefix "SimpleDataContent"
    /// <summary>
    /// Relationship between an entity that provides informations to a system and this system, that interprets these informations as a feedback of its action.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#providesFeedbackTo"></see></summary>
    let providesFeedbackTo = _prefix "providesFeedbackTo"
    /// <summary>
    /// Relationship between a Thing and a property of the environment. In a cyber-physical system, devices and software agents may have one to many feature of interest from the environment. This feature can be a property, another device, a person...
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#hasFeatureOfInterest"></see></summary>
    let hasFeatureOfInterest = _prefix "hasFeatureOfInterest"
    /// <summary>
    /// Characterizes a unique identifier for a thing
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#hasId"></see></summary>
    let hasId = _prefix "hasId"
    /// <summary>
    /// Relationship between an operation and its impact on a property
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#hasImpact"></see></summary>
    let hasImpact = _prefix "hasImpact"
    /// <summary>
    ///   <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#isImpactOf"></see>
    /// </summary>
    let isImpactOf = _prefix "isImpactOf"
    /// <summary>
    /// Relationship between an impact and the impacted property
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#hasImpactonProperty"></see></summary>
    let hasImpactonProperty = _prefix "hasImpactonProperty"
    /// <summary>
    ///   <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#propertyIsImpactedBy"></see>
    /// </summary>
    let propertyIsImpactedBy = _prefix "propertyIsImpactedBy"
    /// <summary>
    /// Associates an Instant individual with a timestamp
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#hasTimeStamp"></see></summary>
    let hasTimeStamp = _prefix "hasTimeStamp"
    /// <summary>
    /// Indicates that the property is the feature of interest of some entity of an IoT system, that can measure it/act upon it.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#isFeatureOfInterestOf"></see></summary>
    let isFeatureOfInterestOf = _prefix "isFeatureOfInterestOf"
    /// <summary>
    ///   <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#isInputMessageOf"></see>
    /// </summary>
    let isInputMessageOf = _prefix "isInputMessageOf"
    /// <summary>
    /// Relationship between a service and an entity that accesses it.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#isServiceOf"></see></summary>
    let isServiceOf = _prefix "isServiceOf"
