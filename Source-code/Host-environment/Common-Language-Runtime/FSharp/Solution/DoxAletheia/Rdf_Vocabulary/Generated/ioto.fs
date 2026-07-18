namespace http.www.irit.fr.recherches.MELODI.ontologies.IoT_O.hash

open DoxAletheia.Rdf_Vocabulary

module ioto =
    let _namespace_name = "http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#"
    /// <summary>
    /// Most general thing in an iot ontology, a Thing can either be a physical connected object, an application, an abstracted interface... The class Object of DUL, from whom it inherits, doen't only represent physical objects, and can cover a fonction for instance.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#IoT_Thing"></see></summary>
    let IoT_Thing = Namespaced_IRI.parse _namespace_name "IoT_Thing" |> NamespacedName

    /// <summary>
    /// Service operation that is relevant to the business function of the service (and the object underneath in the case of IoT). This type of functions may be linked to a property the object deals with (monitoring or modification)
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#BusinessOperation"></see></summary>
    let BusinessOperation =
        Namespaced_IRI.parse _namespace_name "BusinessOperation" |> NamespacedName

    /// <summary>
    /// Service intended to be an interface for the functionnalities the object was designed to perform : measure temperature for a temperature sensor, switch on/off for a switch...
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#BusinessService"></see></summary>
    let BusinessService =
        Namespaced_IRI.parse _namespace_name "BusinessService" |> NamespacedName

    /// <summary>
    /// Generic property that marks the relationship between some entity and some ssn:Property. Dependant on context, it can be sensing, acting or else. Useful to descrie a generic service offered by a complex system that aggregates both sensors and actuators.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#hasRelationshipWithProperty"></see></summary>
    let hasRelationshipWithProperty =
        Namespaced_IRI.parse _namespace_name "hasRelationshipWithProperty" |> NamespacedName

    /// <summary>
    /// System implementing a control feedback loop in order to control an actuator thanks to the feedback of some sensors.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#ControlledSystem"></see></summary>
    let ControlledSystem =
        Namespaced_IRI.parse _namespace_name "ControlledSystem" |> NamespacedName

    /// <summary>
    /// Relation between a controlled system and the entities that provide it with a feedback about its action, usually sensors.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#getsFeedbackFrom"></see></summary>
    let getsFeedbackFrom =
        Namespaced_IRI.parse _namespace_name "getsFeedbackFrom" |> NamespacedName

    /// <summary>
    /// Controlled system that requires an operator attention, because it is not functionnig properly. Detected when the difference between the Observations and the Actuation made on the monitored property is out of its operating range.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#DefectuousSystem"></see></summary>
    let DefectuousSystem =
        Namespaced_IRI.parse _namespace_name "DefectuousSystem" |> NamespacedName

    /// <summary>
    /// Service operation that deals with device management
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#DeviceManagementOperation"></see></summary>
    let DeviceManagementOperation =
        Namespaced_IRI.parse _namespace_name "DeviceManagementOperation" |> NamespacedName

    /// <summary>
    /// This kind of service offers a set of operations regarding device management. That means it's not related to the functionnality of the object itsefl, but rather to its inner working : battery state, connectivity, firmware update...
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#DeviceManagementService"></see></summary>
    let DeviceManagementService =
        Namespaced_IRI.parse _namespace_name "DeviceManagementService" |> NamespacedName

    /// <summary>
    /// Specific message that has no content, its sole transfer achieves its purpose. For example, if an empty message is sent to the "switch light on" service of a light bulb, there is no need for an explicit content of the message asking the light to be turned on.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#EmptyMessage"></see></summary>
    let EmptyMessage =
        Namespaced_IRI.parse _namespace_name "EmptyMessage" |> NamespacedName

    /// <summary>
    /// This class describes the impact an operation may have on a property. It makes sense in an IoT environement, where things can manage properties of their environment and modify them.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#ImpactOnProperty"></see></summary>
    let ImpactOnProperty =
        Namespaced_IRI.parse _namespace_name "ImpactOnProperty" |> NamespacedName

    /// <summary>
    /// Relationship between an Entity and a service that is accessible through it.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#hasService"></see></summary>
    let hasService = Namespaced_IRI.parse _namespace_name "hasService" |> NamespacedName
    /// <summary>
    /// A manager is an application that offers management capabilities as described in the OneM2M norm.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#Manager"></see></summary>
    let Manager = Namespaced_IRI.parse _namespace_name "Manager" |> NamespacedName

    /// <summary>
    /// This individual represents the body of a request containing simple data, such as a numerical value.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#SimpleDataContent"></see></summary>
    let SimpleDataContent =
        Namespaced_IRI.parse _namespace_name "SimpleDataContent" |> NamespacedName

    /// <summary>
    /// Relationship between an entity that provides informations to a system and this system, that interprets these informations as a feedback of its action.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#providesFeedbackTo"></see></summary>
    let providesFeedbackTo =
        Namespaced_IRI.parse _namespace_name "providesFeedbackTo" |> NamespacedName

    /// <summary>
    /// Relationship between a Thing and a property of the environment. In a cyber-physical system, devices and software agents may have one to many feature of interest from the environment. This feature can be a property, another device, a person...
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#hasFeatureOfInterest"></see></summary>
    let hasFeatureOfInterest =
        Namespaced_IRI.parse _namespace_name "hasFeatureOfInterest" |> NamespacedName

    /// <summary>
    /// Characterizes a unique identifier for a thing
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#hasId"></see></summary>
    let hasId = Namespaced_IRI.parse _namespace_name "hasId" |> NamespacedName
    /// <summary>
    /// Relationship between an operation and its impact on a property
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#hasImpact"></see></summary>
    let hasImpact = Namespaced_IRI.parse _namespace_name "hasImpact" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#isImpactOf"></see>
    /// </summary>
    let isImpactOf = Namespaced_IRI.parse _namespace_name "isImpactOf" |> NamespacedName

    /// <summary>
    /// Relationship between an impact and the impacted property
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#hasImpactonProperty"></see></summary>
    let hasImpactonProperty =
        Namespaced_IRI.parse _namespace_name "hasImpactonProperty" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#propertyIsImpactedBy"></see>
    /// </summary>
    let propertyIsImpactedBy =
        Namespaced_IRI.parse _namespace_name "propertyIsImpactedBy" |> NamespacedName

    /// <summary>
    /// Associates an Instant individual with a timestamp
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#hasTimeStamp"></see></summary>
    let hasTimeStamp =
        Namespaced_IRI.parse _namespace_name "hasTimeStamp" |> NamespacedName

    /// <summary>
    /// Indicates that the property is the feature of interest of some entity of an IoT system, that can measure it/act upon it.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#isFeatureOfInterestOf"></see></summary>
    let isFeatureOfInterestOf =
        Namespaced_IRI.parse _namespace_name "isFeatureOfInterestOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#isInputMessageOf"></see>
    /// </summary>
    let isInputMessageOf =
        Namespaced_IRI.parse _namespace_name "isInputMessageOf" |> NamespacedName

    /// <summary>
    /// Relationship between a service and an entity that accesses it.
    /// <see href="http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#isServiceOf"></see></summary>
    let isServiceOf =
        Namespaced_IRI.parse _namespace_name "isServiceOf" |> NamespacedName
