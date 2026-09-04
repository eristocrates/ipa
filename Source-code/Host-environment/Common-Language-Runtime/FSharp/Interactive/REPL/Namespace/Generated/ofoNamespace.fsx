#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ofo =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/ofo#" "ofo"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>skos:example : The data point can be used in various types of databases. It corresponds to single data records in time-series databases, or rows in SQL database tables. It is also a common concept in BMS servers, representing for example a sensor reading, output value of an actuator or any other scalar value.</para>
    ///   <para>rdfs:label : Data point</para>
    ///   <para>rdfs:comment : A data element in a database representing the state of a property.</para>
    ///   <a href="https://w3id.org/ofo#DataPoint">ofo:DataPoint</a>
    /// </summary>
    let DataPoint = _prefixId.prefix "DataPoint"
    /// <summary>
    ///   <para>rdfs:label : Database</para>
    ///   <para>rdfs:comment : A collection of data.
    ///
    /// The database class is used to describe an external database, storing results of executions, such as a time-series database.</para>
    ///   <a href="https://w3id.org/ofo#Database">ofo:Database</a>
    /// </summary>
    let Database = _prefixId.prefix "Database"
    /// <summary>
    ///   <para>skos:example : An object, part, zone, event etc.
    /// In the context of the OFO ontology, an ofo:Person will usually also be an ofo:FeatureOfInterest.</para>
    ///   <para>rdfs:label : Feature of interest</para>
    ///   <para>rdfs:comment : An abstraction of a real-world phenomenon which could be described in terms of its properties.</para>
    ///   <a href="https://w3id.org/ofo#FeatureOfInterest">ofo:FeatureOfInterest</a>
    /// </summary>
    let FeatureOfInterest = _prefixId.prefix "FeatureOfInterest"
    /// <summary>
    ///   <para>rdfs:label : Feedback</para>
    ///   <para>rdfs:comment : An act of producing a statement of opinion on the state of a property.</para>
    ///   <a href="https://w3id.org/ofo#Feedback">ofo:Feedback</a>
    /// </summary>
    let Feedback = _prefixId.prefix "Feedback"
    /// <summary>
    ///   <para>rdfs:label : Location</para>
    ///   <para>rdfs:comment : The area or space something is in.
    ///
    /// The ofo:Location class could be used to describe both geographical locations (such as points) and topological locations (such as rooms).</para>
    ///   <a href="https://w3id.org/ofo#Location">ofo:Location</a>
    /// </summary>
    let Location = _prefixId.prefix "Location"
    /// <summary>
    ///   <para>rdfs:label : Person</para>
    ///   <para>rdfs:comment : A member of the human race.</para>
    ///   <a href="https://w3id.org/ofo#Person">ofo:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>rdfs:label : Property</para>
    ///   <para>rdfs:comment : A measurable and intrinsic characteristic of a feature of interest.</para>
    ///   <a href="https://w3id.org/ofo#Property">ofo:Property</a>
    /// </summary>
    let Property = _prefixId.prefix "Property"
    /// <summary>
    ///   <para>rdfs:label : Property set</para>
    ///   <para>rdfs:comment : A collection of properties. The collection could also be a singleton or a null set.</para>
    ///   <a href="https://w3id.org/ofo#PropertySet">ofo:PropertySet</a>
    /// </summary>
    let PropertySet = _prefixId.prefix "PropertySet"
    /// <summary>
    ///   <para>skos:example : The result may hold, for example, a value, a unit, a result time and other provenance data.</para>
    ///   <para>rdfs:label : Result</para>
    ///   <para>rdfs:comment : The outcome of an execution.</para>
    ///   <a href="https://w3id.org/ofo#Result">ofo:Result</a>
    /// </summary>
    let Result = _prefixId.prefix "Result"
    /// <summary>
    ///   <para>rdfs:label : Smartwatch</para>
    ///   <para>rdfs:comment : A wearable computer in the form of a watch. It can implement procedures to perform observations and actuations.</para>
    ///   <a href="https://w3id.org/ofo#Smartwatch">ofo:Smartwatch</a>
    /// </summary>
    let Smartwatch = _prefixId.prefix "Smartwatch"
    /// <summary>
    ///   <para>rdfs:label : Wearable</para>
    ///   <para>rdfs:comment : A smart electronic device that is worn close to or on the surface of a person’s skin. It can implement procedures to perform observations and actuations.</para>
    ///   <a href="https://w3id.org/ofo#Wearable">ofo:Wearable</a>
    /// </summary>
    let Wearable = _prefixId.prefix "Wearable"
    /// <summary>
    ///   <para>rdfs:label : contains property</para>
    ///   <para>rdfs:comment : Relationship between a property set and a property which is part of this set.</para>
    ///   <a href="https://w3id.org/ofo#containsProperty">ofo:containsProperty</a>
    /// </summary>
    let containsProperty = _prefixId.prefix "containsProperty"
    /// <summary>
    ///   <para>rdfs:label : executes on</para>
    ///   <para>rdfs:comment : Relationship between a wearable and the property it executes on.</para>
    ///   <a href="https://w3id.org/ofo#executesOn">ofo:executesOn</a>
    /// </summary>
    let executesOn = _prefixId.prefix "executesOn"
    /// <summary>
    ///   <para>rdfs:label : gives feedback</para>
    ///   <para>rdfs:comment : Relationship between a person and the feedback given by this person.</para>
    ///   <a href="https://w3id.org/ofo#givesFeedback">ofo:givesFeedback</a>
    /// </summary>
    let givesFeedback = _prefixId.prefix "givesFeedback"
    /// <summary>
    ///   <para>rdfs:label : has complex property</para>
    ///   <para>rdfs:comment : Direct relationship between a feature of interest and a result.</para>
    ///   <a href="https://w3id.org/ofo#hasComplexProperty">ofo:hasComplexProperty</a>
    /// </summary>
    let hasComplexProperty = _prefixId.prefix "hasComplexProperty"
    /// <summary>
    ///   <para>rdfs:label : has data point</para>
    ///   <para>rdfs:comment : Relationship between a database and its data points.</para>
    ///   <a href="https://w3id.org/ofo#hasDataPoint">ofo:hasDataPoint</a>
    /// </summary>
    let hasDataPoint = _prefixId.prefix "hasDataPoint"
    /// <summary>
    ///   <para>rdfs:label : has evaluated property</para>
    ///   <para>rdfs:comment : Relationship between feedback and the property it evaluates.</para>
    ///   <a href="https://w3id.org/ofo#hasEvaluatedProperty">ofo:hasEvaluatedProperty</a>
    /// </summary>
    let hasEvaluatedProperty = _prefixId.prefix "hasEvaluatedProperty"
    /// <summary>
    ///   <para>rdfs:label : has external database</para>
    ///   <para>rdfs:comment : Linking a wearable with the database its results are stored in.</para>
    ///   <a href="https://w3id.org/ofo#hasExternalDatabase">ofo:hasExternalDatabase</a>
    /// </summary>
    let hasExternalDatabase = _prefixId.prefix "hasExternalDatabase"
    /// <summary>
    ///   <para>rdfs:label : has feature of interest</para>
    ///   <para>rdfs:comment : Linking feedback with its feature of interest.</para>
    ///   <a href="https://w3id.org/ofo#hasFeatureOfInterest">ofo:hasFeatureOfInterest</a>
    /// </summary>
    let hasFeatureOfInterest = _prefixId.prefix "hasFeatureOfInterest"
    /// <summary>
    ///   <para>rdfs:label : has feedback</para>
    ///   <para>rdfs:comment : Relationship between a property and feedback evaluating this property.</para>
    ///   <a href="https://w3id.org/ofo#hasFeedback">ofo:hasFeedback</a>
    /// </summary>
    let hasFeedback = _prefixId.prefix "hasFeedback"
    /// <summary>
    ///   <para>rdfs:label : has feedback result</para>
    ///   <para>rdfs:comment : Linking feedback to its result.</para>
    ///   <a href="https://w3id.org/ofo#hasFeedbackResult">ofo:hasFeedbackResult</a>
    /// </summary>
    let hasFeedbackResult = _prefixId.prefix "hasFeedbackResult"
    /// <summary>
    ///   <para>rdfs:label : has ID</para>
    ///   <para>rdfs:comment : The ID of a data point in an external database.</para>
    ///   <a href="https://w3id.org/ofo#hasID">ofo:hasID</a>
    /// </summary>
    let hasID = _prefixId.prefix "hasID"
    /// <summary>
    ///   <para>rdfs:label : has location</para>
    ///   <para>rdfs:comment : Relationship between an entity, such as a person or a wearable, and a location.</para>
    ///   <a href="https://w3id.org/ofo#hasLocation">ofo:hasLocation</a>
    /// </summary>
    let hasLocation = _prefixId.prefix "hasLocation"
    /// <summary>
    ///   <para>rdfs:label : has property</para>
    ///   <para>rdfs:comment : Linking a feature of interest with its property. The property is intrinsic to this feature of interest, and cannot exist without this feature of interest.</para>
    ///   <a href="https://w3id.org/ofo#hasProperty">ofo:hasProperty</a>
    /// </summary>
    let hasProperty = _prefixId.prefix "hasProperty"
    /// <summary>
    ///   <para>rdfs:label : has property state</para>
    ///   <para>rdfs:comment : Linking a property with a result.</para>
    ///   <a href="https://w3id.org/ofo#hasPropertyState">ofo:hasPropertyState</a>
    /// </summary>
    let hasPropertyState = _prefixId.prefix "hasPropertyState"
    /// <summary>
    ///   <para>rdfs:label : has result</para>
    ///   <para>rdfs:comment : A superproperty of multiple object properties with an ofo:Result as rdfs:Range. This superproperty can be used to simultaneously query multiple ways of describing property values and increases the freedom of the data modeler.</para>
    ///   <a href="https://w3id.org/ofo#hasResult">ofo:hasResult</a>
    /// </summary>
    let hasResult = _prefixId.prefix "hasResult"
    /// <summary>
    ///   <para>rdfs:label : has simple feedback state</para>
    ///   <para>rdfs:comment : Linking feedback with a simple result value described as a literal.</para>
    ///   <a href="https://w3id.org/ofo#hasSimpleFeedbackState">ofo:hasSimpleFeedbackState</a>
    /// </summary>
    let hasSimpleFeedbackState = _prefixId.prefix "hasSimpleFeedbackState"
    /// <summary>
    ///   <para>rdfs:label : has simple property</para>
    ///   <para>rdfs:comment : Linking a feature of interest with a simple property value described as a literal.</para>
    ///   <a href="https://w3id.org/ofo#hasSimpleProperty">ofo:hasSimpleProperty</a>
    /// </summary>
    let hasSimpleProperty = _prefixId.prefix "hasSimpleProperty"
    /// <summary>
    ///   <para>rdfs:label : has simple property state</para>
    ///   <para>rdfs:comment : Linking a property with a simple property state value described as a literal.</para>
    ///   <a href="https://w3id.org/ofo#hasSimplePropertyState">ofo:hasSimplePropertyState</a>
    /// </summary>
    let hasSimplePropertyState = _prefixId.prefix "hasSimplePropertyState"
    /// <summary>
    ///   <para>rdfs:label : has simple result</para>
    ///   <para>rdfs:comment : A superproperty of multiple datatype properties that describe simple result values. This superproperty can be used to simultaneously query multiple ways of describing simple property values and increases the freedom of the data modeler.</para>
    ///   <a href="https://w3id.org/ofo#hasSimpleResult">ofo:hasSimpleResult</a>
    /// </summary>
    let hasSimpleResult = _prefixId.prefix "hasSimpleResult"
    /// <summary>
    ///   <para>rdfs:label : has sub-property</para>
    ///   <para>rdfs:comment : Describing a whole-part relationship between a property and its sub-property.</para>
    ///   <a href="https://w3id.org/ofo#hasSubProperty">ofo:hasSubProperty</a>
    /// </summary>
    let hasSubProperty = _prefixId.prefix "hasSubProperty"
    /// <summary>
    ///   <para>rdfs:label : has value</para>
    ///   <para>rdfs:comment : The simple value of a result.</para>
    ///   <a href="https://w3id.org/ofo#hasValue">ofo:hasValue</a>
    /// </summary>
    let hasValue = _prefixId.prefix "hasValue"
    /// <summary>
    ///   <para>rdfs:label : is complex property of</para>
    ///   <para>rdfs:comment : Linking a result with a feature of interest.</para>
    ///   <a href="https://w3id.org/ofo#isComplexPropertyOf">ofo:isComplexPropertyOf</a>
    /// </summary>
    let isComplexPropertyOf = _prefixId.prefix "isComplexPropertyOf"
    /// <summary>
    ///   <para>rdfs:label : is data point of</para>
    ///   <para>rdfs:comment : Linking a data point with the database it is part of.</para>
    ///   <a href="https://w3id.org/ofo#isDataPointOf">ofo:isDataPointOf</a>
    /// </summary>
    let isDataPointOf = _prefixId.prefix "isDataPointOf"
    /// <summary>
    ///   <para>rdfs:label : is executed by</para>
    ///   <para>rdfs:comment : Relationship between a property and the wearable which acts on the property.</para>
    ///   <a href="https://w3id.org/ofo#isExecutedBy">ofo:isExecutedBy</a>
    /// </summary>
    let isExecutedBy = _prefixId.prefix "isExecutedBy"
    /// <summary>
    ///   <para>rdfs:label : is external database of</para>
    ///   <para>rdfs:comment : Linking a database with the wearable which results are stored in this database.</para>
    ///   <a href="https://w3id.org/ofo#isExternalDatabaseOf">ofo:isExternalDatabaseOf</a>
    /// </summary>
    let isExternalDatabaseOf = _prefixId.prefix "isExternalDatabaseOf"
    /// <summary>
    ///   <para>rdfs:label : is feature of interest of</para>
    ///   <para>rdfs:comment : Linking a feature of interest with feedback that evaluates a property of this feature of interest.</para>
    ///   <a href="https://w3id.org/ofo#isFeatureOfInterestOf">ofo:isFeatureOfInterestOf</a>
    /// </summary>
    let isFeatureOfInterestOf = _prefixId.prefix "isFeatureOfInterestOf"
    /// <summary>
    ///   <para>rdfs:label : is feedback of</para>
    ///   <para>rdfs:comment : Relationship between feedback and the person that gave this feedback.</para>
    ///   <a href="https://w3id.org/ofo#isFeedbackOf">ofo:isFeedbackOf</a>
    /// </summary>
    let isFeedbackOf = _prefixId.prefix "isFeedbackOf"
    /// <summary>
    ///   <para>rdfs:label : is feedback result of</para>
    ///   <para>rdfs:comment : Linking a result with feedback.</para>
    ///   <a href="https://w3id.org/ofo#isFeedbackResultOf">ofo:isFeedbackResultOf</a>
    /// </summary>
    let isFeedbackResultOf = _prefixId.prefix "isFeedbackResultOf"
    /// <summary>
    ///   <para>rdfs:label : is location of</para>
    ///   <para>rdfs:comment : Relationship between a location and an entity, such as a person or a wearable.</para>
    ///   <a href="https://w3id.org/ofo#isLocationOf">ofo:isLocationOf</a>
    /// </summary>
    let isLocationOf = _prefixId.prefix "isLocationOf"
    /// <summary>
    ///   <para>rdfs:label : is monitored by</para>
    ///   <para>rdfs:comment : Relationship between feedback and the executor (e.g. a wearable) that monitored this feedback.</para>
    ///   <a href="https://w3id.org/ofo#isMonitoredBy">ofo:isMonitoredBy</a>
    /// </summary>
    let isMonitoredBy = _prefixId.prefix "isMonitoredBy"
    /// <summary>
    ///   <para>rdfs:label : is part of property set</para>
    ///   <para>rdfs:comment : Relationship between a property and the property set it is part of.</para>
    ///   <a href="https://w3id.org/ofo#isPartOfPropertySet">ofo:isPartOfPropertySet</a>
    /// </summary>
    let isPartOfPropertySet = _prefixId.prefix "isPartOfPropertySet"
    /// <summary>
    ///   <para>rdfs:label : is property of</para>
    ///   <para>rdfs:comment : Linking a property with its feature of interest. The property is intrinsic to this feature of interest, and cannot exist without a feature of interest.</para>
    ///   <a href="https://w3id.org/ofo#isPropertyOf">ofo:isPropertyOf</a>
    /// </summary>
    let isPropertyOf = _prefixId.prefix "isPropertyOf"
    /// <summary>
    ///   <para>rdfs:label : is property state of</para>
    ///   <para>rdfs:comment : Linking a result with a property.</para>
    ///   <a href="https://w3id.org/ofo#isPropertyStateOf">ofo:isPropertyStateOf</a>
    /// </summary>
    let isPropertyStateOf = _prefixId.prefix "isPropertyStateOf"
    /// <summary>
    ///   <para>rdfs:label : is result of</para>
    ///   <para>rdfs:comment : A superproperty of multiple object properties with an ofo:Result as rdfs:Domain. This superproperty can be used to simultaneously query multiple ways of describing property values and increases the freedom of the data modeler.</para>
    ///   <a href="https://w3id.org/ofo#isResultOf">ofo:isResultOf</a>
    /// </summary>
    let isResultOf = _prefixId.prefix "isResultOf"
    /// <summary>
    ///   <para>skos:example : The object property describes a typical whole-part relationship between a property and its sub-properties. It is used in cases where properties are so complex that it is desirable to decompose them into separate properties. The separate properties might also be individually linked to their own results.</para>
    ///   <para>rdfs:label : is sub-property of</para>
    ///   <para>rdfs:comment : Relation between a sub-property and its parent property.</para>
    ///   <a href="https://w3id.org/ofo#isSubPropertyOf">ofo:isSubPropertyOf</a>
    /// </summary>
    let isSubPropertyOf = _prefixId.prefix "isSubPropertyOf"
    /// <summary>
    ///   <para>rdfs:label : is worn by</para>
    ///   <para>rdfs:comment : Describing the relation between a wearable and the person wearing this wearable.</para>
    ///   <a href="https://w3id.org/ofo#isWornBy">ofo:isWornBy</a>
    /// </summary>
    let isWornBy = _prefixId.prefix "isWornBy"
    /// <summary>
    ///   <para>rdfs:label : monitors feedback</para>
    ///   <para>rdfs:comment : Relationship between an executor (e.g. a wearable) and the feedback it monitors.</para>
    ///   <a href="https://w3id.org/ofo#monitorsFeedback">ofo:monitorsFeedback</a>
    /// </summary>
    let monitorsFeedback = _prefixId.prefix "monitorsFeedback"
    /// <summary>
    ///   <para>rdfs:label : wears</para>
    ///   <para>rdfs:comment : Relationship between a wearable and the person that wears this wearable.</para>
    ///   <a href="https://w3id.org/ofo#wears">ofo:wears</a>
    /// </summary>
    let wears = _prefixId.prefix "wears"
