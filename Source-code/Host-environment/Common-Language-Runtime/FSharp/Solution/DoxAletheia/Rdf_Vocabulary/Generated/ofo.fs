namespace https.w3id.org.ofo.hash

open DoxAletheia.Rdf_Vocabulary

module ofo =
    let _namespace_name = "https://w3id.org/ofo#"
    /// <summary>
    /// A data element in a database representing the state of a property.
    /// <see href="https://w3id.org/ofo#DataPoint"></see></summary>
    let DataPoint = Namespaced_IRI.parse _namespace_name "DataPoint" |> NamespacedName
    /// <summary>
    /// The outcome of an execution.
    /// <see href="https://w3id.org/ofo#Result"></see></summary>
    let Result = Namespaced_IRI.parse _namespace_name "Result" |> NamespacedName
    /// <summary>
    /// A collection of data.
    ///
    /// The database class is used to describe an external database, storing results of executions, such as a time-series database.
    /// <see href="https://w3id.org/ofo#Database"></see></summary>
    let Database = Namespaced_IRI.parse _namespace_name "Database" |> NamespacedName

    /// <summary>
    /// An abstraction of a real-world phenomenon which could be described in terms of its properties.
    /// <see href="https://w3id.org/ofo#FeatureOfInterest"></see></summary>
    let FeatureOfInterest =
        Namespaced_IRI.parse _namespace_name "FeatureOfInterest" |> NamespacedName

    /// <summary>
    /// Linking a feature of interest with its property. The property is intrinsic to this feature of interest, and cannot exist without this feature of interest.
    /// <see href="https://w3id.org/ofo#hasProperty"></see></summary>
    let hasProperty =
        Namespaced_IRI.parse _namespace_name "hasProperty" |> NamespacedName

    /// <summary>
    /// A measurable and intrinsic characteristic of a feature of interest.
    /// <see href="https://w3id.org/ofo#Property"></see></summary>
    let Property = Namespaced_IRI.parse _namespace_name "Property" |> NamespacedName
    /// <summary>
    /// An act of producing a statement of opinion on the state of a property.
    /// <see href="https://w3id.org/ofo#Feedback"></see></summary>
    let Feedback = Namespaced_IRI.parse _namespace_name "Feedback" |> NamespacedName
    /// <summary>
    /// The area or space something is in.
    ///
    /// The ofo:Location class could be used to describe both geographical locations (such as points) and topological locations (such as rooms).
    /// <see href="https://w3id.org/ofo#Location"></see></summary>
    let Location = Namespaced_IRI.parse _namespace_name "Location" |> NamespacedName
    /// <summary>
    /// A member of the human race.
    /// <see href="https://w3id.org/ofo#Person"></see></summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName

    /// <summary>
    /// Linking a property with its feature of interest. The property is intrinsic to this feature of interest, and cannot exist without a feature of interest.
    /// <see href="https://w3id.org/ofo#isPropertyOf"></see></summary>
    let isPropertyOf =
        Namespaced_IRI.parse _namespace_name "isPropertyOf" |> NamespacedName

    /// <summary>
    /// A collection of properties. The collection could also be a singleton or a null set.
    /// <see href="https://w3id.org/ofo#PropertySet"></see></summary>
    let PropertySet =
        Namespaced_IRI.parse _namespace_name "PropertySet" |> NamespacedName

    /// <summary>
    /// A wearable computer in the form of a watch. It can implement procedures to perform observations and actuations.
    /// <see href="https://w3id.org/ofo#Smartwatch"></see></summary>
    let Smartwatch = Namespaced_IRI.parse _namespace_name "Smartwatch" |> NamespacedName
    /// <summary>
    /// A smart electronic device that is worn close to or on the surface of a person’s skin. It can implement procedures to perform observations and actuations.
    /// <see href="https://w3id.org/ofo#Wearable"></see></summary>
    let Wearable = Namespaced_IRI.parse _namespace_name "Wearable" |> NamespacedName

    /// <summary>
    /// Relationship between a property set and a property which is part of this set.
    /// <see href="https://w3id.org/ofo#containsProperty"></see></summary>
    let containsProperty =
        Namespaced_IRI.parse _namespace_name "containsProperty" |> NamespacedName

    /// <summary>
    /// Relationship between a property and the property set it is part of.
    /// <see href="https://w3id.org/ofo#isPartOfPropertySet"></see></summary>
    let isPartOfPropertySet =
        Namespaced_IRI.parse _namespace_name "isPartOfPropertySet" |> NamespacedName

    /// <summary>
    /// Relationship between a wearable and the property it executes on.
    /// <see href="https://w3id.org/ofo#executesOn"></see></summary>
    let executesOn = Namespaced_IRI.parse _namespace_name "executesOn" |> NamespacedName

    /// <summary>
    /// Relationship between a property and the wearable which acts on the property.
    /// <see href="https://w3id.org/ofo#isExecutedBy"></see></summary>
    let isExecutedBy =
        Namespaced_IRI.parse _namespace_name "isExecutedBy" |> NamespacedName

    /// <summary>
    /// Relationship between a person and the feedback given by this person.
    /// <see href="https://w3id.org/ofo#givesFeedback"></see></summary>
    let givesFeedback =
        Namespaced_IRI.parse _namespace_name "givesFeedback" |> NamespacedName

    /// <summary>
    /// Relationship between feedback and the person that gave this feedback.
    /// <see href="https://w3id.org/ofo#isFeedbackOf"></see></summary>
    let isFeedbackOf =
        Namespaced_IRI.parse _namespace_name "isFeedbackOf" |> NamespacedName

    /// <summary>
    /// Relationship between a wearable and the person that wears this wearable.
    /// <see href="https://w3id.org/ofo#wears"></see></summary>
    let wears = Namespaced_IRI.parse _namespace_name "wears" |> NamespacedName

    /// <summary>
    /// Relationship between an executor (e.g. a wearable) and the feedback it monitors.
    /// <see href="https://w3id.org/ofo#monitorsFeedback"></see></summary>
    let monitorsFeedback =
        Namespaced_IRI.parse _namespace_name "monitorsFeedback" |> NamespacedName

    /// <summary>
    /// Direct relationship between a feature of interest and a result.
    /// <see href="https://w3id.org/ofo#hasComplexProperty"></see></summary>
    let hasComplexProperty =
        Namespaced_IRI.parse _namespace_name "hasComplexProperty" |> NamespacedName

    /// <summary>
    /// A superproperty of multiple object properties with an ofo:Result as rdfs:Range. This superproperty can be used to simultaneously query multiple ways of describing property values and increases the freedom of the data modeler.
    /// <see href="https://w3id.org/ofo#hasResult"></see></summary>
    let hasResult = Namespaced_IRI.parse _namespace_name "hasResult" |> NamespacedName

    /// <summary>
    /// Linking a result with a feature of interest.
    /// <see href="https://w3id.org/ofo#isComplexPropertyOf"></see></summary>
    let isComplexPropertyOf =
        Namespaced_IRI.parse _namespace_name "isComplexPropertyOf" |> NamespacedName

    /// <summary>
    /// Relationship between a database and its data points.
    /// <see href="https://w3id.org/ofo#hasDataPoint"></see></summary>
    let hasDataPoint =
        Namespaced_IRI.parse _namespace_name "hasDataPoint" |> NamespacedName

    /// <summary>
    /// Linking a data point with the database it is part of.
    /// <see href="https://w3id.org/ofo#isDataPointOf"></see></summary>
    let isDataPointOf =
        Namespaced_IRI.parse _namespace_name "isDataPointOf" |> NamespacedName

    /// <summary>
    /// Relationship between feedback and the property it evaluates.
    /// <see href="https://w3id.org/ofo#hasEvaluatedProperty"></see></summary>
    let hasEvaluatedProperty =
        Namespaced_IRI.parse _namespace_name "hasEvaluatedProperty" |> NamespacedName

    /// <summary>
    /// Relationship between a property and feedback evaluating this property.
    /// <see href="https://w3id.org/ofo#hasFeedback"></see></summary>
    let hasFeedback =
        Namespaced_IRI.parse _namespace_name "hasFeedback" |> NamespacedName

    /// <summary>
    /// Linking a wearable with the database its results are stored in.
    /// <see href="https://w3id.org/ofo#hasExternalDatabase"></see></summary>
    let hasExternalDatabase =
        Namespaced_IRI.parse _namespace_name "hasExternalDatabase" |> NamespacedName

    /// <summary>
    /// Linking a database with the wearable which results are stored in this database.
    /// <see href="https://w3id.org/ofo#isExternalDatabaseOf"></see></summary>
    let isExternalDatabaseOf =
        Namespaced_IRI.parse _namespace_name "isExternalDatabaseOf" |> NamespacedName

    /// <summary>
    /// Linking feedback with its feature of interest.
    /// <see href="https://w3id.org/ofo#hasFeatureOfInterest"></see></summary>
    let hasFeatureOfInterest =
        Namespaced_IRI.parse _namespace_name "hasFeatureOfInterest" |> NamespacedName

    /// <summary>
    /// Linking a feature of interest with feedback that evaluates a property of this feature of interest.
    /// <see href="https://w3id.org/ofo#isFeatureOfInterestOf"></see></summary>
    let isFeatureOfInterestOf =
        Namespaced_IRI.parse _namespace_name "isFeatureOfInterestOf" |> NamespacedName

    /// <summary>
    /// Linking feedback to its result.
    /// <see href="https://w3id.org/ofo#hasFeedbackResult"></see></summary>
    let hasFeedbackResult =
        Namespaced_IRI.parse _namespace_name "hasFeedbackResult" |> NamespacedName

    /// <summary>
    /// Linking a result with feedback.
    /// <see href="https://w3id.org/ofo#isFeedbackResultOf"></see></summary>
    let isFeedbackResultOf =
        Namespaced_IRI.parse _namespace_name "isFeedbackResultOf" |> NamespacedName

    /// <summary>
    /// The ID of a data point in an external database.
    /// <see href="https://w3id.org/ofo#hasID"></see></summary>
    let hasID = Namespaced_IRI.parse _namespace_name "hasID" |> NamespacedName
    /// <summary>
    /// The simple value of a result.
    /// <see href="https://w3id.org/ofo#hasValue"></see></summary>
    let hasValue = Namespaced_IRI.parse _namespace_name "hasValue" |> NamespacedName

    /// <summary>
    /// Relationship between an entity, such as a person or a wearable, and a location.
    /// <see href="https://w3id.org/ofo#hasLocation"></see></summary>
    let hasLocation =
        Namespaced_IRI.parse _namespace_name "hasLocation" |> NamespacedName

    /// <summary>
    /// Relationship between a location and an entity, such as a person or a wearable.
    /// <see href="https://w3id.org/ofo#isLocationOf"></see></summary>
    let isLocationOf =
        Namespaced_IRI.parse _namespace_name "isLocationOf" |> NamespacedName

    /// <summary>
    /// Describing the relation between a wearable and the person wearing this wearable.
    /// <see href="https://w3id.org/ofo#isWornBy"></see></summary>
    let isWornBy = Namespaced_IRI.parse _namespace_name "isWornBy" |> NamespacedName

    /// <summary>
    /// Linking a property with a result.
    /// <see href="https://w3id.org/ofo#hasPropertyState"></see></summary>
    let hasPropertyState =
        Namespaced_IRI.parse _namespace_name "hasPropertyState" |> NamespacedName

    /// <summary>
    /// Linking a result with a property.
    /// <see href="https://w3id.org/ofo#isPropertyStateOf"></see></summary>
    let isPropertyStateOf =
        Namespaced_IRI.parse _namespace_name "isPropertyStateOf" |> NamespacedName

    /// <summary>
    /// A superproperty of multiple object properties with an ofo:Result as rdfs:Domain. This superproperty can be used to simultaneously query multiple ways of describing property values and increases the freedom of the data modeler.
    /// <see href="https://w3id.org/ofo#isResultOf"></see></summary>
    let isResultOf = Namespaced_IRI.parse _namespace_name "isResultOf" |> NamespacedName

    /// <summary>
    /// Linking feedback with a simple result value described as a literal.
    /// <see href="https://w3id.org/ofo#hasSimpleFeedbackState"></see></summary>
    let hasSimpleFeedbackState =
        Namespaced_IRI.parse _namespace_name "hasSimpleFeedbackState" |> NamespacedName

    /// <summary>
    /// A superproperty of multiple datatype properties that describe simple result values. This superproperty can be used to simultaneously query multiple ways of describing simple property values and increases the freedom of the data modeler.
    /// <see href="https://w3id.org/ofo#hasSimpleResult"></see></summary>
    let hasSimpleResult =
        Namespaced_IRI.parse _namespace_name "hasSimpleResult" |> NamespacedName

    /// <summary>
    /// Linking a feature of interest with a simple property value described as a literal.
    /// <see href="https://w3id.org/ofo#hasSimpleProperty"></see></summary>
    let hasSimpleProperty =
        Namespaced_IRI.parse _namespace_name "hasSimpleProperty" |> NamespacedName

    /// <summary>
    /// Linking a property with a simple property state value described as a literal.
    /// <see href="https://w3id.org/ofo#hasSimplePropertyState"></see></summary>
    let hasSimplePropertyState =
        Namespaced_IRI.parse _namespace_name "hasSimplePropertyState" |> NamespacedName

    /// <summary>
    /// Describing a whole-part relationship between a property and its sub-property.
    /// <see href="https://w3id.org/ofo#hasSubProperty"></see></summary>
    let hasSubProperty =
        Namespaced_IRI.parse _namespace_name "hasSubProperty" |> NamespacedName

    /// <summary>
    /// Relation between a sub-property and its parent property.
    /// <see href="https://w3id.org/ofo#isSubPropertyOf"></see></summary>
    let isSubPropertyOf =
        Namespaced_IRI.parse _namespace_name "isSubPropertyOf" |> NamespacedName

    /// <summary>
    /// Relationship between feedback and the executor (e.g. a wearable) that monitored this feedback.
    /// <see href="https://w3id.org/ofo#isMonitoredBy"></see></summary>
    let isMonitoredBy =
        Namespaced_IRI.parse _namespace_name "isMonitoredBy" |> NamespacedName
