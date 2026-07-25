namespace https.w3id.org.ofo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ofo =
    let _namespace_iri = Namespace_Iri ofo |> NamespaceIRI
    /// <summary>
    ///   <para>ofo:DataPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A data element in a database representing the state of a property.</para>
    /// labels<para>Data point</para></remarks>
    /// <seealso href="https://w3id.org/ofo#DataPoint">https://w3id.org/ofo#DataPoint</seealso>
    let DataPoint = Prefixed_Name(ofo, "DataPoint") |> PrefixedName
    /// <summary>
    ///   <para>ofo:hasProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Linking a feature of interest with its property. The property is intrinsic to this feature of interest, and cannot exist without this feature of interest.</para>
    /// labels<para>has property</para></remarks>
    /// <seealso href="https://w3id.org/ofo#hasProperty">https://w3id.org/ofo#hasProperty</seealso>
    let hasProperty = Prefixed_Name(ofo, "hasProperty") |> PrefixedName
    /// <summary>
    ///   <para>ofo:Feedback</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An act of producing a statement of opinion on the state of a property.</para>
    /// labels<para>Feedback</para></remarks>
    /// <seealso href="https://w3id.org/ofo#Feedback">https://w3id.org/ofo#Feedback</seealso>
    let Feedback = Prefixed_Name(ofo, "Feedback") |> PrefixedName
    /// <summary>
    ///   <para>ofo:isPropertyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Linking a property with its feature of interest. The property is intrinsic to this feature of interest, and cannot exist without a feature of interest.</para>
    /// labels<para>is property of</para></remarks>
    /// <seealso href="https://w3id.org/ofo#isPropertyOf">https://w3id.org/ofo#isPropertyOf</seealso>
    let isPropertyOf = Prefixed_Name(ofo, "isPropertyOf") |> PrefixedName
    /// <summary>
    ///   <para>ofo:Wearable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A smart electronic device that is worn close to or on the surface of a person’s skin. It can implement procedures to perform observations and actuations.</para>
    /// labels<para>Wearable</para></remarks>
    /// <seealso href="https://w3id.org/ofo#Wearable">https://w3id.org/ofo#Wearable</seealso>
    let Wearable = Prefixed_Name(ofo, "Wearable") |> PrefixedName
    /// <summary>
    ///   <para>ofo:containsProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a property set and a property which is part of this set.</para>
    /// labels<para>contains property</para></remarks>
    /// <seealso href="https://w3id.org/ofo#containsProperty">https://w3id.org/ofo#containsProperty</seealso>
    let containsProperty = Prefixed_Name(ofo, "containsProperty") |> PrefixedName
    /// <summary>
    ///   <para>ofo:isFeedbackOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between feedback and the person that gave this feedback.</para>
    /// labels<para>is feedback of</para></remarks>
    /// <seealso href="https://w3id.org/ofo#isFeedbackOf">https://w3id.org/ofo#isFeedbackOf</seealso>
    let isFeedbackOf = Prefixed_Name(ofo, "isFeedbackOf") |> PrefixedName
    /// <summary>
    ///   <para>ofo:isComplexPropertyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Linking a result with a feature of interest.</para>
    /// labels<para>is complex property of</para></remarks>
    /// <seealso href="https://w3id.org/ofo#isComplexPropertyOf">https://w3id.org/ofo#isComplexPropertyOf</seealso>
    let isComplexPropertyOf = Prefixed_Name(ofo, "isComplexPropertyOf") |> PrefixedName
    /// <summary>
    ///   <para>ofo:FeatureOfInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An abstraction of a real-world phenomenon which could be described in terms of its properties.</para>
    /// labels<para>Feature of interest</para></remarks>
    /// <seealso href="https://w3id.org/ofo#FeatureOfInterest">https://w3id.org/ofo#FeatureOfInterest</seealso>
    let FeatureOfInterest = Prefixed_Name(ofo, "FeatureOfInterest") |> PrefixedName
    /// <summary>
    ///   <para>ofo:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The area or space something is in.
    ///
    /// The ofo:Location class could be used to describe both geographical locations (such as points) and topological locations (such as rooms).</para>
    /// labels<para>Location</para></remarks>
    /// <seealso href="https://w3id.org/ofo#Location">https://w3id.org/ofo#Location</seealso>
    let Location = Prefixed_Name(ofo, "Location") |> PrefixedName
    /// <summary>
    ///   <para>ofo:isLocationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a location and an entity, such as a person or a wearable.</para>
    /// labels<para>is location of</para></remarks>
    /// <seealso href="https://w3id.org/ofo#isLocationOf">https://w3id.org/ofo#isLocationOf</seealso>
    let isLocationOf = Prefixed_Name(ofo, "isLocationOf") |> PrefixedName
    /// <summary>
    ///   <para>ofo:hasPropertyState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Linking a property with a result.</para>
    /// labels<para>has property state</para></remarks>
    /// <seealso href="https://w3id.org/ofo#hasPropertyState">https://w3id.org/ofo#hasPropertyState</seealso>
    let hasPropertyState = Prefixed_Name(ofo, "hasPropertyState") |> PrefixedName
    /// <summary>
    ///   <para>ofo:Smartwatch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A wearable computer in the form of a watch. It can implement procedures to perform observations and actuations.</para>
    /// labels<para>Smartwatch</para></remarks>
    /// <seealso href="https://w3id.org/ofo#Smartwatch">https://w3id.org/ofo#Smartwatch</seealso>
    let Smartwatch = Prefixed_Name(ofo, "Smartwatch") |> PrefixedName
    /// <summary>
    ///   <para>ofo:executesOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a wearable and the property it executes on.</para>
    /// labels<para>executes on</para></remarks>
    /// <seealso href="https://w3id.org/ofo#executesOn">https://w3id.org/ofo#executesOn</seealso>
    let executesOn = Prefixed_Name(ofo, "executesOn") |> PrefixedName
    /// <summary>
    ///   <para>ofo:hasComplexProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Direct relationship between a feature of interest and a result.</para>
    /// labels<para>has complex property</para></remarks>
    /// <seealso href="https://w3id.org/ofo#hasComplexProperty">https://w3id.org/ofo#hasComplexProperty</seealso>
    let hasComplexProperty = Prefixed_Name(ofo, "hasComplexProperty") |> PrefixedName
    /// <summary>
    ///   <para>ofo:isDataPointOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Linking a data point with the database it is part of.</para>
    /// labels<para>is data point of</para></remarks>
    /// <seealso href="https://w3id.org/ofo#isDataPointOf">https://w3id.org/ofo#isDataPointOf</seealso>
    let isDataPointOf = Prefixed_Name(ofo, "isDataPointOf") |> PrefixedName
    /// <summary>
    ///   <para>ofo:hasExternalDatabase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Linking a wearable with the database its results are stored in.</para>
    /// labels<para>has external database</para></remarks>
    /// <seealso href="https://w3id.org/ofo#hasExternalDatabase">https://w3id.org/ofo#hasExternalDatabase</seealso>
    let hasExternalDatabase = Prefixed_Name(ofo, "hasExternalDatabase") |> PrefixedName

    /// <summary>
    ///   <para>ofo:isExternalDatabaseOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Linking a database with the wearable which results are stored in this database.</para>
    /// labels<para>is external database of</para></remarks>
    /// <seealso href="https://w3id.org/ofo#isExternalDatabaseOf">https://w3id.org/ofo#isExternalDatabaseOf</seealso>
    let isExternalDatabaseOf =
        Prefixed_Name(ofo, "isExternalDatabaseOf") |> PrefixedName

    /// <summary>
    ///   <para>ofo:isFeatureOfInterestOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Linking a feature of interest with feedback that evaluates a property of this feature of interest.</para>
    /// labels<para>is feature of interest of</para></remarks>
    /// <seealso href="https://w3id.org/ofo#isFeatureOfInterestOf">https://w3id.org/ofo#isFeatureOfInterestOf</seealso>
    let isFeatureOfInterestOf =
        Prefixed_Name(ofo, "isFeatureOfInterestOf") |> PrefixedName

    /// <summary>
    ///   <para>ofo:isPartOfPropertySet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a property and the property set it is part of.</para>
    /// labels<para>is part of property set</para></remarks>
    /// <seealso href="https://w3id.org/ofo#isPartOfPropertySet">https://w3id.org/ofo#isPartOfPropertySet</seealso>
    let isPartOfPropertySet = Prefixed_Name(ofo, "isPartOfPropertySet") |> PrefixedName
    /// <summary>
    ///   <para>ofo:isExecutedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a property and the wearable which acts on the property.</para>
    /// labels<para>is executed by</para></remarks>
    /// <seealso href="https://w3id.org/ofo#isExecutedBy">https://w3id.org/ofo#isExecutedBy</seealso>
    let isExecutedBy = Prefixed_Name(ofo, "isExecutedBy") |> PrefixedName
    /// <summary>
    ///   <para>ofo:wears</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a wearable and the person that wears this wearable.</para>
    /// labels<para>wears</para></remarks>
    /// <seealso href="https://w3id.org/ofo#wears">https://w3id.org/ofo#wears</seealso>
    let wears = Prefixed_Name(ofo, "wears") |> PrefixedName
    /// <summary>
    ///   <para>ofo:hasResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A superproperty of multiple object properties with an ofo:Result as rdfs:Range. This superproperty can be used to simultaneously query multiple ways of describing property values and increases the freedom of the data modeler.</para>
    /// labels<para>has result</para></remarks>
    /// <seealso href="https://w3id.org/ofo#hasResult">https://w3id.org/ofo#hasResult</seealso>
    let hasResult = Prefixed_Name(ofo, "hasResult") |> PrefixedName
    /// <summary>
    ///   <para>ofo:givesFeedback</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a person and the feedback given by this person.</para>
    /// labels<para>gives feedback</para></remarks>
    /// <seealso href="https://w3id.org/ofo#givesFeedback">https://w3id.org/ofo#givesFeedback</seealso>
    let givesFeedback = Prefixed_Name(ofo, "givesFeedback") |> PrefixedName
    /// <summary>
    ///   <para>ofo:monitorsFeedback</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between an executor (e.g. a wearable) and the feedback it monitors.</para>
    /// labels<para>monitors feedback</para></remarks>
    /// <seealso href="https://w3id.org/ofo#monitorsFeedback">https://w3id.org/ofo#monitorsFeedback</seealso>
    let monitorsFeedback = Prefixed_Name(ofo, "monitorsFeedback") |> PrefixedName
    /// <summary>
    ///   <para>ofo:hasDataPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a database and its data points.</para>
    /// labels<para>has data point</para></remarks>
    /// <seealso href="https://w3id.org/ofo#hasDataPoint">https://w3id.org/ofo#hasDataPoint</seealso>
    let hasDataPoint = Prefixed_Name(ofo, "hasDataPoint") |> PrefixedName
    /// <summary>
    ///   <para>ofo:hasFeedback</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a property and feedback evaluating this property.</para>
    /// labels<para>has feedback</para></remarks>
    /// <seealso href="https://w3id.org/ofo#hasFeedback">https://w3id.org/ofo#hasFeedback</seealso>
    let hasFeedback = Prefixed_Name(ofo, "hasFeedback") |> PrefixedName

    /// <summary>
    ///   <para>ofo:hasEvaluatedProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between feedback and the property it evaluates.</para>
    /// labels<para>has evaluated property</para></remarks>
    /// <seealso href="https://w3id.org/ofo#hasEvaluatedProperty">https://w3id.org/ofo#hasEvaluatedProperty</seealso>
    let hasEvaluatedProperty =
        Prefixed_Name(ofo, "hasEvaluatedProperty") |> PrefixedName

    /// <summary>
    ///   <para>ofo:hasFeatureOfInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Linking feedback with its feature of interest.</para>
    /// labels<para>has feature of interest</para></remarks>
    /// <seealso href="https://w3id.org/ofo#hasFeatureOfInterest">https://w3id.org/ofo#hasFeatureOfInterest</seealso>
    let hasFeatureOfInterest =
        Prefixed_Name(ofo, "hasFeatureOfInterest") |> PrefixedName

    /// <summary>
    ///   <para>ofo:hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The simple value of a result.</para>
    /// labels<para>has value</para></remarks>
    /// <seealso href="https://w3id.org/ofo#hasValue">https://w3id.org/ofo#hasValue</seealso>
    let hasValue = Prefixed_Name(ofo, "hasValue") |> PrefixedName
    /// <summary>
    ///   <para>ofo:isResultOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A superproperty of multiple object properties with an ofo:Result as rdfs:Domain. This superproperty can be used to simultaneously query multiple ways of describing property values and increases the freedom of the data modeler.</para>
    /// labels<para>is result of</para></remarks>
    /// <seealso href="https://w3id.org/ofo#isResultOf">https://w3id.org/ofo#isResultOf</seealso>
    let isResultOf = Prefixed_Name(ofo, "isResultOf") |> PrefixedName

    /// <summary>
    ///   <para>ofo:hasSimpleFeedbackState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Linking feedback with a simple result value described as a literal.</para>
    /// labels<para>has simple feedback state</para></remarks>
    /// <seealso href="https://w3id.org/ofo#hasSimpleFeedbackState">https://w3id.org/ofo#hasSimpleFeedbackState</seealso>
    let hasSimpleFeedbackState =
        Prefixed_Name(ofo, "hasSimpleFeedbackState") |> PrefixedName

    /// <summary>
    ///   <para>ofo:hasSubProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describing a whole-part relationship between a property and its sub-property.</para>
    /// labels<para>has sub-property</para></remarks>
    /// <seealso href="https://w3id.org/ofo#hasSubProperty">https://w3id.org/ofo#hasSubProperty</seealso>
    let hasSubProperty = Prefixed_Name(ofo, "hasSubProperty") |> PrefixedName
    /// <summary>
    ///   <para>ofo:isSubPropertyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between a sub-property and its parent property.</para>
    /// labels<para>is sub-property of</para></remarks>
    /// <seealso href="https://w3id.org/ofo#isSubPropertyOf">https://w3id.org/ofo#isSubPropertyOf</seealso>
    let isSubPropertyOf = Prefixed_Name(ofo, "isSubPropertyOf") |> PrefixedName
    /// <summary>
    ///   <para>ofo:hasFeedbackResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Linking feedback to its result.</para>
    /// labels<para>has feedback result</para></remarks>
    /// <seealso href="https://w3id.org/ofo#hasFeedbackResult">https://w3id.org/ofo#hasFeedbackResult</seealso>
    let hasFeedbackResult = Prefixed_Name(ofo, "hasFeedbackResult") |> PrefixedName
    /// <summary>
    ///   <para>ofo:hasID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The ID of a data point in an external database.</para>
    /// labels<para>has ID</para></remarks>
    /// <seealso href="https://w3id.org/ofo#hasID">https://w3id.org/ofo#hasID</seealso>
    let hasID = Prefixed_Name(ofo, "hasID") |> PrefixedName
    /// <summary>
    ///   <para>ofo:isFeedbackResultOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Linking a result with feedback.</para>
    /// labels<para>is feedback result of</para></remarks>
    /// <seealso href="https://w3id.org/ofo#isFeedbackResultOf">https://w3id.org/ofo#isFeedbackResultOf</seealso>
    let isFeedbackResultOf = Prefixed_Name(ofo, "isFeedbackResultOf") |> PrefixedName
    /// <summary>
    ///   <para>ofo:hasLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between an entity, such as a person or a wearable, and a location.</para>
    /// labels<para>has location</para></remarks>
    /// <seealso href="https://w3id.org/ofo#hasLocation">https://w3id.org/ofo#hasLocation</seealso>
    let hasLocation = Prefixed_Name(ofo, "hasLocation") |> PrefixedName
    /// <summary>
    ///   <para>ofo:isWornBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describing the relation between a wearable and the person wearing this wearable.</para>
    /// labels<para>is worn by</para></remarks>
    /// <seealso href="https://w3id.org/ofo#isWornBy">https://w3id.org/ofo#isWornBy</seealso>
    let isWornBy = Prefixed_Name(ofo, "isWornBy") |> PrefixedName
    /// <summary>
    ///   <para>ofo:isPropertyStateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Linking a result with a property.</para>
    /// labels<para>is property state of</para></remarks>
    /// <seealso href="https://w3id.org/ofo#isPropertyStateOf">https://w3id.org/ofo#isPropertyStateOf</seealso>
    let isPropertyStateOf = Prefixed_Name(ofo, "isPropertyStateOf") |> PrefixedName
    /// <summary>
    ///   <para>ofo:hasSimpleResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A superproperty of multiple datatype properties that describe simple result values. This superproperty can be used to simultaneously query multiple ways of describing simple property values and increases the freedom of the data modeler.</para>
    /// labels<para>has simple result</para></remarks>
    /// <seealso href="https://w3id.org/ofo#hasSimpleResult">https://w3id.org/ofo#hasSimpleResult</seealso>
    let hasSimpleResult = Prefixed_Name(ofo, "hasSimpleResult") |> PrefixedName
    /// <summary>
    ///   <para>ofo:hasSimpleProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Linking a feature of interest with a simple property value described as a literal.</para>
    /// labels<para>has simple property</para></remarks>
    /// <seealso href="https://w3id.org/ofo#hasSimpleProperty">https://w3id.org/ofo#hasSimpleProperty</seealso>
    let hasSimpleProperty = Prefixed_Name(ofo, "hasSimpleProperty") |> PrefixedName
    /// <summary>
    ///   <para>ofo:isMonitoredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between feedback and the executor (e.g. a wearable) that monitored this feedback.</para>
    /// labels<para>is monitored by</para></remarks>
    /// <seealso href="https://w3id.org/ofo#isMonitoredBy">https://w3id.org/ofo#isMonitoredBy</seealso>
    let isMonitoredBy = Prefixed_Name(ofo, "isMonitoredBy") |> PrefixedName

    /// <summary>
    ///   <para>ofo:hasSimplePropertyState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Linking a property with a simple property state value described as a literal.</para>
    /// labels<para>has simple property state</para></remarks>
    /// <seealso href="https://w3id.org/ofo#hasSimplePropertyState">https://w3id.org/ofo#hasSimplePropertyState</seealso>
    let hasSimplePropertyState =
        Prefixed_Name(ofo, "hasSimplePropertyState") |> PrefixedName

    /// <summary>
    ///   <para>ofo:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>Occupant Feedback Ontology</para></remarks>
    /// <seealso href="https://w3id.org/ofo#">https://w3id.org/ofo#</seealso>
    let _prefix_iri = Prefixed_Name(ofo, "") |> PrefixedName
    /// <summary>
    ///   <para>ofo:Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The outcome of an execution.</para>
    /// labels<para>Result</para></remarks>
    /// <seealso href="https://w3id.org/ofo#Result">https://w3id.org/ofo#Result</seealso>
    let Result = Prefixed_Name(ofo, "Result") |> PrefixedName
    /// <summary>
    ///   <para>ofo:Database</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A collection of data.
    ///
    /// The database class is used to describe an external database, storing results of executions, such as a time-series database.</para>
    /// labels<para>Database</para></remarks>
    /// <seealso href="https://w3id.org/ofo#Database">https://w3id.org/ofo#Database</seealso>
    let Database = Prefixed_Name(ofo, "Database") |> PrefixedName
    /// <summary>
    ///   <para>ofo:Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A measurable and intrinsic characteristic of a feature of interest.</para>
    /// labels<para>Property</para></remarks>
    /// <seealso href="https://w3id.org/ofo#Property">https://w3id.org/ofo#Property</seealso>
    let Property = Prefixed_Name(ofo, "Property") |> PrefixedName
    /// <summary>
    ///   <para>ofo:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A member of the human race.</para>
    /// labels<para>Person</para></remarks>
    /// <seealso href="https://w3id.org/ofo#Person">https://w3id.org/ofo#Person</seealso>
    let Person = Prefixed_Name(ofo, "Person") |> PrefixedName
    /// <summary>
    ///   <para>ofo:PropertySet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A collection of properties. The collection could also be a singleton or a null set.</para>
    /// labels<para>Property set</para></remarks>
    /// <seealso href="https://w3id.org/ofo#PropertySet">https://w3id.org/ofo#PropertySet</seealso>
    let PropertySet = Prefixed_Name(ofo, "PropertySet") |> PrefixedName
