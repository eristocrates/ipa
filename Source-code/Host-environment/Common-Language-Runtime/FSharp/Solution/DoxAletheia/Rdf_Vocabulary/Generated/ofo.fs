namespace https.w3id.org.ofo.hash

open DoxAletheia

module ofo =
    let _namespace_name = "https://w3id.org/ofo#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A data element in a database representing the state of a property.
    /// <see href="https://w3id.org/ofo#DataPoint"></see></summary>
    let DataPoint = _prefix "DataPoint"
    /// <summary>
    /// The outcome of an execution.
    /// <see href="https://w3id.org/ofo#Result"></see></summary>
    let Result = _prefix "Result"
    /// <summary>
    /// A collection of data.
    ///
    /// The database class is used to describe an external database, storing results of executions, such as a time-series database.
    /// <see href="https://w3id.org/ofo#Database"></see></summary>
    let Database = _prefix "Database"
    /// <summary>
    /// An abstraction of a real-world phenomenon which could be described in terms of its properties.
    /// <see href="https://w3id.org/ofo#FeatureOfInterest"></see></summary>
    let FeatureOfInterest = _prefix "FeatureOfInterest"
    /// <summary>
    /// Linking a feature of interest with its property. The property is intrinsic to this feature of interest, and cannot exist without this feature of interest.
    /// <see href="https://w3id.org/ofo#hasProperty"></see></summary>
    let hasProperty = _prefix "hasProperty"
    /// <summary>
    /// A measurable and intrinsic characteristic of a feature of interest.
    /// <see href="https://w3id.org/ofo#Property"></see></summary>
    let Property = _prefix "Property"
    /// <summary>
    /// An act of producing a statement of opinion on the state of a property.
    /// <see href="https://w3id.org/ofo#Feedback"></see></summary>
    let Feedback = _prefix "Feedback"
    /// <summary>
    /// The area or space something is in.
    ///
    /// The ofo:Location class could be used to describe both geographical locations (such as points) and topological locations (such as rooms).
    /// <see href="https://w3id.org/ofo#Location"></see></summary>
    let Location = _prefix "Location"
    /// <summary>
    /// A member of the human race.
    /// <see href="https://w3id.org/ofo#Person"></see></summary>
    let Person = _prefix "Person"
    /// <summary>
    /// Linking a property with its feature of interest. The property is intrinsic to this feature of interest, and cannot exist without a feature of interest.
    /// <see href="https://w3id.org/ofo#isPropertyOf"></see></summary>
    let isPropertyOf = _prefix "isPropertyOf"
    /// <summary>
    /// A collection of properties. The collection could also be a singleton or a null set.
    /// <see href="https://w3id.org/ofo#PropertySet"></see></summary>
    let PropertySet = _prefix "PropertySet"
    /// <summary>
    /// A wearable computer in the form of a watch. It can implement procedures to perform observations and actuations.
    /// <see href="https://w3id.org/ofo#Smartwatch"></see></summary>
    let Smartwatch = _prefix "Smartwatch"
    /// <summary>
    /// A smart electronic device that is worn close to or on the surface of a person’s skin. It can implement procedures to perform observations and actuations.
    /// <see href="https://w3id.org/ofo#Wearable"></see></summary>
    let Wearable = _prefix "Wearable"
    /// <summary>
    /// Relationship between a property set and a property which is part of this set.
    /// <see href="https://w3id.org/ofo#containsProperty"></see></summary>
    let containsProperty = _prefix "containsProperty"
    /// <summary>
    /// Relationship between a property and the property set it is part of.
    /// <see href="https://w3id.org/ofo#isPartOfPropertySet"></see></summary>
    let isPartOfPropertySet = _prefix "isPartOfPropertySet"
    /// <summary>
    /// Relationship between a wearable and the property it executes on.
    /// <see href="https://w3id.org/ofo#executesOn"></see></summary>
    let executesOn = _prefix "executesOn"
    /// <summary>
    /// Relationship between a property and the wearable which acts on the property.
    /// <see href="https://w3id.org/ofo#isExecutedBy"></see></summary>
    let isExecutedBy = _prefix "isExecutedBy"
    /// <summary>
    /// Relationship between a person and the feedback given by this person.
    /// <see href="https://w3id.org/ofo#givesFeedback"></see></summary>
    let givesFeedback = _prefix "givesFeedback"
    /// <summary>
    /// Relationship between feedback and the person that gave this feedback.
    /// <see href="https://w3id.org/ofo#isFeedbackOf"></see></summary>
    let isFeedbackOf = _prefix "isFeedbackOf"
    /// <summary>
    /// Relationship between a wearable and the person that wears this wearable.
    /// <see href="https://w3id.org/ofo#wears"></see></summary>
    let wears = _prefix "wears"
    /// <summary>
    /// Relationship between an executor (e.g. a wearable) and the feedback it monitors.
    /// <see href="https://w3id.org/ofo#monitorsFeedback"></see></summary>
    let monitorsFeedback = _prefix "monitorsFeedback"
    /// <summary>
    /// Direct relationship between a feature of interest and a result.
    /// <see href="https://w3id.org/ofo#hasComplexProperty"></see></summary>
    let hasComplexProperty = _prefix "hasComplexProperty"
    /// <summary>
    /// A superproperty of multiple object properties with an ofo:Result as rdfs:Range. This superproperty can be used to simultaneously query multiple ways of describing property values and increases the freedom of the data modeler.
    /// <see href="https://w3id.org/ofo#hasResult"></see></summary>
    let hasResult = _prefix "hasResult"
    /// <summary>
    /// Linking a result with a feature of interest.
    /// <see href="https://w3id.org/ofo#isComplexPropertyOf"></see></summary>
    let isComplexPropertyOf = _prefix "isComplexPropertyOf"
    /// <summary>
    /// Relationship between a database and its data points.
    /// <see href="https://w3id.org/ofo#hasDataPoint"></see></summary>
    let hasDataPoint = _prefix "hasDataPoint"
    /// <summary>
    /// Linking a data point with the database it is part of.
    /// <see href="https://w3id.org/ofo#isDataPointOf"></see></summary>
    let isDataPointOf = _prefix "isDataPointOf"
    /// <summary>
    /// Relationship between feedback and the property it evaluates.
    /// <see href="https://w3id.org/ofo#hasEvaluatedProperty"></see></summary>
    let hasEvaluatedProperty = _prefix "hasEvaluatedProperty"
    /// <summary>
    /// Relationship between a property and feedback evaluating this property.
    /// <see href="https://w3id.org/ofo#hasFeedback"></see></summary>
    let hasFeedback = _prefix "hasFeedback"
    /// <summary>
    /// Linking a wearable with the database its results are stored in.
    /// <see href="https://w3id.org/ofo#hasExternalDatabase"></see></summary>
    let hasExternalDatabase = _prefix "hasExternalDatabase"
    /// <summary>
    /// Linking a database with the wearable which results are stored in this database.
    /// <see href="https://w3id.org/ofo#isExternalDatabaseOf"></see></summary>
    let isExternalDatabaseOf = _prefix "isExternalDatabaseOf"
    /// <summary>
    /// Linking feedback with its feature of interest.
    /// <see href="https://w3id.org/ofo#hasFeatureOfInterest"></see></summary>
    let hasFeatureOfInterest = _prefix "hasFeatureOfInterest"
    /// <summary>
    /// Linking a feature of interest with feedback that evaluates a property of this feature of interest.
    /// <see href="https://w3id.org/ofo#isFeatureOfInterestOf"></see></summary>
    let isFeatureOfInterestOf = _prefix "isFeatureOfInterestOf"
    /// <summary>
    /// Linking feedback to its result.
    /// <see href="https://w3id.org/ofo#hasFeedbackResult"></see></summary>
    let hasFeedbackResult = _prefix "hasFeedbackResult"
    /// <summary>
    /// Linking a result with feedback.
    /// <see href="https://w3id.org/ofo#isFeedbackResultOf"></see></summary>
    let isFeedbackResultOf = _prefix "isFeedbackResultOf"
    /// <summary>
    /// The ID of a data point in an external database.
    /// <see href="https://w3id.org/ofo#hasID"></see></summary>
    let hasID = _prefix "hasID"
    /// <summary>
    /// The simple value of a result.
    /// <see href="https://w3id.org/ofo#hasValue"></see></summary>
    let hasValue = _prefix "hasValue"
    /// <summary>
    /// Relationship between an entity, such as a person or a wearable, and a location.
    /// <see href="https://w3id.org/ofo#hasLocation"></see></summary>
    let hasLocation = _prefix "hasLocation"
    /// <summary>
    /// Relationship between a location and an entity, such as a person or a wearable.
    /// <see href="https://w3id.org/ofo#isLocationOf"></see></summary>
    let isLocationOf = _prefix "isLocationOf"
    /// <summary>
    /// Describing the relation between a wearable and the person wearing this wearable.
    /// <see href="https://w3id.org/ofo#isWornBy"></see></summary>
    let isWornBy = _prefix "isWornBy"
    /// <summary>
    /// Linking a property with a result.
    /// <see href="https://w3id.org/ofo#hasPropertyState"></see></summary>
    let hasPropertyState = _prefix "hasPropertyState"
    /// <summary>
    /// Linking a result with a property.
    /// <see href="https://w3id.org/ofo#isPropertyStateOf"></see></summary>
    let isPropertyStateOf = _prefix "isPropertyStateOf"
    /// <summary>
    /// A superproperty of multiple object properties with an ofo:Result as rdfs:Domain. This superproperty can be used to simultaneously query multiple ways of describing property values and increases the freedom of the data modeler.
    /// <see href="https://w3id.org/ofo#isResultOf"></see></summary>
    let isResultOf = _prefix "isResultOf"
    /// <summary>
    /// Linking feedback with a simple result value described as a literal.
    /// <see href="https://w3id.org/ofo#hasSimpleFeedbackState"></see></summary>
    let hasSimpleFeedbackState = _prefix "hasSimpleFeedbackState"
    /// <summary>
    /// A superproperty of multiple datatype properties that describe simple result values. This superproperty can be used to simultaneously query multiple ways of describing simple property values and increases the freedom of the data modeler.
    /// <see href="https://w3id.org/ofo#hasSimpleResult"></see></summary>
    let hasSimpleResult = _prefix "hasSimpleResult"
    /// <summary>
    /// Linking a feature of interest with a simple property value described as a literal.
    /// <see href="https://w3id.org/ofo#hasSimpleProperty"></see></summary>
    let hasSimpleProperty = _prefix "hasSimpleProperty"
    /// <summary>
    /// Linking a property with a simple property state value described as a literal.
    /// <see href="https://w3id.org/ofo#hasSimplePropertyState"></see></summary>
    let hasSimplePropertyState = _prefix "hasSimplePropertyState"
    /// <summary>
    /// Describing a whole-part relationship between a property and its sub-property.
    /// <see href="https://w3id.org/ofo#hasSubProperty"></see></summary>
    let hasSubProperty = _prefix "hasSubProperty"
    /// <summary>
    /// Relation between a sub-property and its parent property.
    /// <see href="https://w3id.org/ofo#isSubPropertyOf"></see></summary>
    let isSubPropertyOf = _prefix "isSubPropertyOf"
    /// <summary>
    /// Relationship between feedback and the executor (e.g. a wearable) that monitored this feedback.
    /// <see href="https://w3id.org/ofo#isMonitoredBy"></see></summary>
    let isMonitoredBy = _prefix "isMonitoredBy"
