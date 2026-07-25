namespace https.w3id.org.def.dtw.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dtw =
    let _namespace_iri = Namespace_Iri dtw |> NamespaceIRI

    /// <summary>
    ///   <para>dtw:containsInteractionAffordance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that describes the different interaction affordances that the dt:DigitalTwinServices contains.</para>
    /// labels<para>contains interaction affordance</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#containsInteractionAffordance">https://w3id.org/def/dtw#containsInteractionAffordance</seealso>
    let containsInteractionAffordance =
        Prefixed_Name(dtw, "containsInteractionAffordance") |> PrefixedName

    /// <summary>
    ///   <para>dtw:RulesModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A set of rules extracted from the historical data obtained from the physical model, whose function is to provide the virtual entity with a judgment for decision making, optimization, evaluation, prediction and maintenance.</para>
    /// labels<para>Rules Model</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#RulesModel">https://w3id.org/def/dtw#RulesModel</seealso>
    let RulesModel = Prefixed_Name(dtw, "RulesModel") |> PrefixedName
    /// <summary>
    ///   <para>dtw:SemanticModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Model representing semantic web rules or conceptualizations.</para>
    /// labels<para>Semantic Model</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#SemanticModel">https://w3id.org/def/dtw#SemanticModel</seealso>
    let SemanticModel = Prefixed_Name(dtw, "SemanticModel") |> PrefixedName

    /// <summary>
    ///   <para>dtw:DigitalEntityDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Digital Entity Dimension class to add resource, model and interaction affordances clases</para>
    /// labels<para>Digital Entity Dimension</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#DigitalEntityDimension">https://w3id.org/def/dtw#DigitalEntityDimension</seealso>
    let DigitalEntityDimension =
        Prefixed_Name(dtw, "DigitalEntityDimension") |> PrefixedName

    /// <summary>
    ///   <para>dtw:ShapesModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Model that contains the data validation rules allowing the data to be validated.</para>
    /// labels<para>Shapes Model</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#ShapesModel">https://w3id.org/def/dtw#ShapesModel</seealso>
    let ShapesModel = Prefixed_Name(dtw, "ShapesModel") |> PrefixedName
    /// <summary>
    ///   <para>dtw:DigitalTwin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A realistic representation of all product life cycle components using physical, virtual and interaction data.</para>
    /// labels<para>Digital Twin</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#DigitalTwin">https://w3id.org/def/dtw#DigitalTwin</seealso>
    let DigitalTwin = Prefixed_Name(dtw, "DigitalTwin") |> PrefixedName

    /// <summary>
    ///   <para>dtw:ModelServiceConnection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Connection between dtw:Model and td:InteractionAffordance.</para>
    /// labels<para>Model Service Connection</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#ModelServiceConnection">https://w3id.org/def/dtw#ModelServiceConnection</seealso>
    let ModelServiceConnection =
        Prefixed_Name(dtw, "ModelServiceConnection") |> PrefixedName

    /// <summary>
    ///   <para>dtw:ModelDataConnection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Connection between dtw:Model and dcat:Resource.</para>
    /// labels<para>Model Data Connection</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#ModelDataConnection">https://w3id.org/def/dtw#ModelDataConnection</seealso>
    let ModelDataConnection = Prefixed_Name(dtw, "ModelDataConnection") |> PrefixedName

    /// <summary>
    ///   <para>dtw:DigitalTwinAggregate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes the aggregation of all the DTIs. Unlike the DTI, the DTA may not be an independent data structure. It may be a computing construct that has access to all DTIs and queries them either ad-hoc or proactively.</para>
    /// labels<para>Digital Twin Aggregate</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#DigitalTwinAggregate">https://w3id.org/def/dtw#DigitalTwinAggregate</seealso>
    let DigitalTwinAggregate =
        Prefixed_Name(dtw, "DigitalTwinAggregate") |> PrefixedName

    /// <summary>
    ///   <para>dtw:aggregateDTwA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that describes de action of aggregation between two different entities or dtw:DigitalTwinAggregate.</para>
    /// labels<para>aggregate DTwA</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#aggregateDTwA">https://w3id.org/def/dtw#aggregateDTwA</seealso>
    let aggregateDTwA = Prefixed_Name(dtw, "aggregateDTwA") |> PrefixedName
    /// <summary>
    ///   <para>dtw:DigitalTwinInstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes a specific corresponding physical product that an individual Digital Twin remains linked to throughout the life of that physical product.</para>
    /// labels<para>Digital Twin Instance</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#DigitalTwinInstance">https://w3id.org/def/dtw#DigitalTwinInstance</seealso>
    let DigitalTwinInstance = Prefixed_Name(dtw, "DigitalTwinInstance") |> PrefixedName
    /// <summary>
    ///   <para>dtw:aggregateDTwI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that describes de action of aggregation between two different entities or dtw:DigitalTwinInstance.</para>
    /// labels<para>aggregate DTwI</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#aggregateDTwI">https://w3id.org/def/dtw#aggregateDTwI</seealso>
    let aggregateDTwI = Prefixed_Name(dtw, "aggregateDTwI") |> PrefixedName
    /// <summary>
    ///   <para>dtw:Format</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Extension format in which the model or data is available.</para>
    /// labels<para>Format</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#Format">https://w3id.org/def/dtw#Format</seealso>
    let Format = Prefixed_Name(dtw, "Format") |> PrefixedName
    /// <summary>
    ///   <para>dtw:isDataOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Data of a Digital Entity.</para>
    /// labels<para>is data of</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#isDataOf">https://w3id.org/def/dtw#isDataOf</seealso>
    let isDataOf = Prefixed_Name(dtw, "isDataOf") |> PrefixedName
    /// <summary>
    ///   <para>dtw:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/dtw#">https://w3id.org/def/dtw#</seealso>
    let _prefix_iri = Prefixed_Name(dtw, "") |> PrefixedName
    /// <summary>
    ///   <para>dtw:0.5.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/def/dtw#0.5.0">https://w3id.org/def/dtw#0.5.0</seealso>
    let ``_0.5.0`` = Prefixed_Name(dtw, "0.5.0") |> PrefixedName
    /// <summary>
    ///   <para>dtw:BehavioralModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes the behaviors and response mechanisms of the entity (e.g. state transition, performance and disturbances)</para>
    /// labels<para>Behavioral Model</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#BehavioralModel">https://w3id.org/def/dtw#BehavioralModel</seealso>
    let BehavioralModel = Prefixed_Name(dtw, "BehavioralModel") |> PrefixedName
    /// <summary>
    ///   <para>dtw:Model</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Representation or conceptualization of the data registered in the Virtual Entity dimension.</para>
    /// labels<para>Model</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#Model">https://w3id.org/def/dtw#Model</seealso>
    let Model = Prefixed_Name(dtw, "Model") |> PrefixedName

    /// <summary>
    ///   <para>dtw:InternalConnectionPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Connection point of the connection that is internal to the DTw.</para>
    /// labels<para>Internal Connection Point</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#InternalConnectionPoint">https://w3id.org/def/dtw#InternalConnectionPoint</seealso>
    let InternalConnectionPoint =
        Prefixed_Name(dtw, "InternalConnectionPoint") |> PrefixedName

    /// <summary>
    ///   <para>dtw:hasConsumer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that describes if the connection point is the consumer of the information.</para>
    /// labels<para>has consumer</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#hasConsumer">https://w3id.org/def/dtw#hasConsumer</seealso>
    let hasConsumer = Prefixed_Name(dtw, "hasConsumer") |> PrefixedName

    /// <summary>
    ///   <para>dtw:DigitalTwinDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Dimensions of which the digital twin is composed.</para>
    /// labels<para>Digital Twin Dimension</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#DigitalTwinDimension">https://w3id.org/def/dtw#DigitalTwinDimension</seealso>
    let DigitalTwinDimension =
        Prefixed_Name(dtw, "DigitalTwinDimension") |> PrefixedName

    /// <summary>
    ///   <para>dtw:hasProvider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that describes if the connection point is the provider of the information.</para>
    /// labels<para>has provider</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#hasProvider">https://w3id.org/def/dtw#hasProvider</seealso>
    let hasProvider = Prefixed_Name(dtw, "hasProvider") |> PrefixedName
    /// <summary>
    ///   <para>dtw:DigitalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This dimension of the digital twin consists of various data models that represents all the information allocated in the digital twin.</para>
    /// labels<para>Digital Entity</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#DigitalEntity">https://w3id.org/def/dtw#DigitalEntity</seealso>
    let DigitalEntity = Prefixed_Name(dtw, "DigitalEntity") |> PrefixedName

    /// <summary>
    ///   <para>dtw:resourceAggregatedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Resource aggregated from resource.</para>
    /// labels<para>resource aggregated from</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#resourceAggregatedFrom">https://w3id.org/def/dtw#resourceAggregatedFrom</seealso>
    let resourceAggregatedFrom =
        Prefixed_Name(dtw, "resourceAggregatedFrom") |> PrefixedName

    /// <summary>
    ///   <para>dtw:resourceAggregates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Resource aggregates resource.</para>
    /// labels<para>resource aggregates</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#resourceAggregates">https://w3id.org/def/dtw#resourceAggregates</seealso>
    let resourceAggregates = Prefixed_Name(dtw, "resourceAggregates") |> PrefixedName
    /// <summary>
    ///   <para>dtw:ConnectionPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Connection point of the connection.</para>
    /// labels<para>Connection Point</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#ConnectionPoint">https://w3id.org/def/dtw#ConnectionPoint</seealso>
    let ConnectionPoint = Prefixed_Name(dtw, "ConnectionPoint") |> PrefixedName

    /// <summary>
    ///   <para>dtw:ExternalConnectionPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Connection point of the connection that is external to the DTw.</para>
    /// labels<para>External Connection Point</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#ExternalConnectionPoint">https://w3id.org/def/dtw#ExternalConnectionPoint</seealso>
    let ExternalConnectionPoint =
        Prefixed_Name(dtw, "ExternalConnectionPoint") |> PrefixedName

    /// <summary>
    ///   <para>dtw:isProviderOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Connection point is provider of a connection.</para>
    /// labels<para>is provider of</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#isProviderOf">https://w3id.org/def/dtw#isProviderOf</seealso>
    let isProviderOf = Prefixed_Name(dtw, "isProviderOf") |> PrefixedName
    /// <summary>
    ///   <para>dtw:Connection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Existing connection between different dtw:ConnectionPoint.</para>
    /// labels<para>Connection</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#Connection">https://w3id.org/def/dtw#Connection</seealso>
    let Connection = Prefixed_Name(dtw, "Connection") |> PrefixedName

    /// <summary>
    ///   <para>dtw:isInteracctionAffordanceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Interaction Afforfance of a Digital Entity.</para>
    /// labels<para>is interaction affordance of</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#isInteracctionAffordanceOf">https://w3id.org/def/dtw#isInteracctionAffordanceOf</seealso>
    let isInteracctionAffordanceOf =
        Prefixed_Name(dtw, "isInteracctionAffordanceOf") |> PrefixedName

    /// <summary>
    ///   <para>dtw:isConnectionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Connection of a Digital Twin.</para>
    /// labels<para>is connection of</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#isConnectionOf">https://w3id.org/def/dtw#isConnectionOf</seealso>
    let isConnectionOf = Prefixed_Name(dtw, "isConnectionOf") |> PrefixedName
    /// <summary>
    ///   <para>dtw:isConnectionPointOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Connection point is referred to a Digital Entity Dimension</para>
    /// labels<para>is connection point of</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#isConnectionPointOf">https://w3id.org/def/dtw#isConnectionPointOf</seealso>
    let isConnectionPointOf = Prefixed_Name(dtw, "isConnectionPointOf") |> PrefixedName
    /// <summary>
    ///   <para>dtw:isFormatOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Format of a Model.</para>
    /// labels<para>is format of</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#isFormatOf">https://w3id.org/def/dtw#isFormatOf</seealso>
    let isFormatOf = Prefixed_Name(dtw, "isFormatOf") |> PrefixedName
    /// <summary>
    ///   <para>dtw:isPhysicalEntityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Physical entity of a Digital Twin.</para>
    /// labels<para>is physical entity of</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#isPhysicalEntityOf">https://w3id.org/def/dtw#isPhysicalEntityOf</seealso>
    let isPhysicalEntityOf = Prefixed_Name(dtw, "isPhysicalEntityOf") |> PrefixedName
    /// <summary>
    ///   <para>dtw:aggregatedDTwAFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>DTwA aggregated from a specific DTwA</para>
    /// labels<para>aggregated DTwA from</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#aggregatedDTwAFrom">https://w3id.org/def/dtw#aggregatedDTwAFrom</seealso>
    let aggregatedDTwAFrom = Prefixed_Name(dtw, "aggregatedDTwAFrom") |> PrefixedName
    /// <summary>
    ///   <para>dtw:hasConnectionPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that describes the connection point that the element of the DTw has to connect with others</para>
    /// labels<para>has connection point</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#hasConnectionPoint">https://w3id.org/def/dtw#hasConnectionPoint</seealso>
    let hasConnectionPoint = Prefixed_Name(dtw, "hasConnectionPoint") |> PrefixedName
    /// <summary>
    ///   <para>dtw:isConsumerOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Connection point is consumer of a connection.</para>
    /// labels<para>is consumer of</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#isConsumerOf">https://w3id.org/def/dtw#isConsumerOf</seealso>
    let isConsumerOf = Prefixed_Name(dtw, "isConsumerOf") |> PrefixedName
    /// <summary>
    ///   <para>dtw:isDigitalEntityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Digital entity of a Digital Twin.</para>
    /// labels<para>is digital entity of</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#isDigitalEntityOf">https://w3id.org/def/dtw#isDigitalEntityOf</seealso>
    let isDigitalEntityOf = Prefixed_Name(dtw, "isDigitalEntityOf") |> PrefixedName
    /// <summary>
    ///   <para>dtw:hasExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Extension of the model or data with which can be found.</para>
    /// labels<para>has extension</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#hasExtension">https://w3id.org/def/dtw#hasExtension</seealso>
    let hasExtension = Prefixed_Name(dtw, "hasExtension") |> PrefixedName

    /// <summary>
    ///   <para>dtw:DataServiceConnection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Connection between dcat:Resource and td:InteractionAffordance.</para>
    /// labels<para>Data Service Connection</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#DataServiceConnection">https://w3id.org/def/dtw#DataServiceConnection</seealso>
    let DataServiceConnection =
        Prefixed_Name(dtw, "DataServiceConnection") |> PrefixedName

    /// <summary>
    ///   <para>dtw:hasModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that describes the different models that the dtw:DigitalEntity contains.</para>
    /// labels<para>has model</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#hasModel">https://w3id.org/def/dtw#hasModel</seealso>
    let hasModel = Prefixed_Name(dtw, "hasModel") |> PrefixedName
    /// <summary>
    ///   <para>dtw:PhysicalModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Responsible for providing all the physical properties (e.g. speed and force) based on dt:GeometricModel</para>
    /// labels<para>Physical Model</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#PhysicalModel">https://w3id.org/def/dtw#PhysicalModel</seealso>
    let PhysicalModel = Prefixed_Name(dtw, "PhysicalModel") |> PrefixedName
    /// <summary>
    ///   <para>dtw:OntologyModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Model that contains the conceptualization of the information of the digital twin. This conceptualization activity refers to the organization and structuration of the information (data, knowledge, etc.), obtained during the acquisition process, into meaningful models at the knowledge level and according to the ontology requirements specification document.</para>
    /// labels<para>Ontology Model</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#OntologyModel">https://w3id.org/def/dtw#OntologyModel</seealso>
    let OntologyModel = Prefixed_Name(dtw, "OntologyModel") |> PrefixedName
    /// <summary>
    ///   <para>dtw:GeometricModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes all the geometric parameters of the physical entity (e.g. shapes, sizes and assembly relations).</para>
    /// labels<para>Geometric Model</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#GeometricModel">https://w3id.org/def/dtw#GeometricModel</seealso>
    let GeometricModel = Prefixed_Name(dtw, "GeometricModel") |> PrefixedName
    /// <summary>
    ///   <para>dtw:MappingModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Model that allows the alignment of data with the objective of obtaining harmonised data from non-harmonised data.</para>
    /// labels<para>Mapping Model</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#MappingModel">https://w3id.org/def/dtw#MappingModel</seealso>
    let MappingModel = Prefixed_Name(dtw, "MappingModel") |> PrefixedName
    /// <summary>
    ///   <para>dtw:hasData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that describes the different data that the dt:DigitalTwinData contains.</para>
    /// labels<para>has data</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#hasData">https://w3id.org/def/dtw#hasData</seealso>
    let hasData = Prefixed_Name(dtw, "hasData") |> PrefixedName
    /// <summary>
    ///   <para>dtw:hasPhysicalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that describes the Physical Entity that the digital twin describes.</para>
    /// labels<para>has physical entity</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#hasPhysicalEntity">https://w3id.org/def/dtw#hasPhysicalEntity</seealso>
    let hasPhysicalEntity = Prefixed_Name(dtw, "hasPhysicalEntity") |> PrefixedName
    /// <summary>
    ///   <para>dtw:hasConnection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that describes the different connections of the dtw:DigitalTwin.</para>
    /// labels<para>has connection</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#hasConnection">https://w3id.org/def/dtw#hasConnection</seealso>
    let hasConnection = Prefixed_Name(dtw, "hasConnection") |> PrefixedName
    /// <summary>
    ///   <para>dtw:PhysicalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This dimension of the digital twin consists of various subsystems, objects and sensory devices. These subsystems can include dynamic systems, control systems, maintenance systems, etc., and can be combined for a specific task. Also, non physical entities can be represented.</para>
    /// labels<para>Physical Entity</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#PhysicalEntity">https://w3id.org/def/dtw#PhysicalEntity</seealso>
    let PhysicalEntity = Prefixed_Name(dtw, "PhysicalEntity") |> PrefixedName
    /// <summary>
    ///   <para>dtw:hasDigitalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that describes the different Digital Entities that the digital twin contains.</para>
    /// labels<para>has digital entity</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#hasDigitalEntity">https://w3id.org/def/dtw#hasDigitalEntity</seealso>
    let hasDigitalEntity = Prefixed_Name(dtw, "hasDigitalEntity") |> PrefixedName

    /// <summary>
    ///   <para>dtw:ModelModelConnection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Model to model connection.</para>
    /// labels<para>Model Model Connection</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#ModelModelConnection">https://w3id.org/def/dtw#ModelModelConnection</seealso>
    let ModelModelConnection =
        Prefixed_Name(dtw, "ModelModelConnection") |> PrefixedName

    /// <summary>
    ///   <para>dtw:modelAggregatedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Model aggregated from model.</para>
    /// labels<para>model aggregated from</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#modelAggregatedFrom">https://w3id.org/def/dtw#modelAggregatedFrom</seealso>
    let modelAggregatedFrom = Prefixed_Name(dtw, "modelAggregatedFrom") |> PrefixedName
    /// <summary>
    ///   <para>dtw:isModelOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Model contained by the Digital Entity Dimension.</para>
    /// labels<para>is model of</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#isModelOf">https://w3id.org/def/dtw#isModelOf</seealso>
    let isModelOf = Prefixed_Name(dtw, "isModelOf") |> PrefixedName
    /// <summary>
    ///   <para>dtw:modelAggregates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Model aggregates model.</para>
    /// labels<para>model aggregates</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#modelAggregates">https://w3id.org/def/dtw#modelAggregates</seealso>
    let modelAggregates = Prefixed_Name(dtw, "modelAggregates") |> PrefixedName
    /// <summary>
    ///   <para>dtw:hasFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that describes the different extension formats that the models or data can be found.</para>
    /// labels<para>has format</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#hasFormat">https://w3id.org/def/dtw#hasFormat</seealso>
    let hasFormat = Prefixed_Name(dtw, "hasFormat") |> PrefixedName
    /// <summary>
    ///   <para>dtw:aggregatedDTwIFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>DTwI aggregated from a specific DTwA</para>
    /// labels<para>aggregated DTwI from</para></remarks>
    /// <seealso href="https://w3id.org/def/dtw#aggregatedDTwIFrom">https://w3id.org/def/dtw#aggregatedDTwIFrom</seealso>
    let aggregatedDTwIFrom = Prefixed_Name(dtw, "aggregatedDTwIFrom") |> PrefixedName
