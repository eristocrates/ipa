#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dtw =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/def/dtw#" "dtw"
    let _namespaceIri = _prefixId.prefix ""
    let ``_0.5.0`` = _prefixId.prefix "0.5.0"
    /// <summary>
    ///   <para>rdfs:label : Behavioral Model</para>
    ///   <para>rdfs:comment : Describes the behaviors and response mechanisms of the entity (e.g. state transition, performance and disturbances)</para>
    ///   <a href="https://w3id.org/def/dtw#BehavioralModel">dtw:BehavioralModel</a>
    /// </summary>
    let BehavioralModel = _prefixId.prefix "BehavioralModel"
    /// <summary>
    ///   <para>rdfs:label : Connection</para>
    ///   <para>rdfs:comment : Existing connection between different dtw:ConnectionPoint.</para>
    ///   <a href="https://w3id.org/def/dtw#Connection">dtw:Connection</a>
    /// </summary>
    let Connection = _prefixId.prefix "Connection"
    /// <summary>
    ///   <para>rdfs:label : Connection Point</para>
    ///   <para>rdfs:comment : Connection point of the connection.</para>
    ///   <a href="https://w3id.org/def/dtw#ConnectionPoint">dtw:ConnectionPoint</a>
    /// </summary>
    let ConnectionPoint = _prefixId.prefix "ConnectionPoint"
    /// <summary>
    ///   <para>rdfs:label : Data Service Connection</para>
    ///   <para>rdfs:comment : Connection between dcat:Resource and td:InteractionAffordance.</para>
    ///   <a href="https://w3id.org/def/dtw#DataServiceConnection">dtw:DataServiceConnection</a>
    /// </summary>
    let DataServiceConnection = _prefixId.prefix "DataServiceConnection"
    /// <summary>
    ///   <para>rdfs:comment : This dimension of the digital twin consists of various data models that represents all the information allocated in the digital twin.</para>
    ///   <para>rdfs:label : Digital Entity</para>
    ///   <a href="https://w3id.org/def/dtw#DigitalEntity">dtw:DigitalEntity</a>
    /// </summary>
    let DigitalEntity = _prefixId.prefix "DigitalEntity"
    /// <summary>
    ///   <para>dce:description : Digital Entity Dimension class to add resource, model and interaction affordances clases</para>
    ///   <para>rdfs:label : Digital Entity Dimension</para>
    ///   <para>rdfs:comment : Digital Entity Dimension class to add resource, model and interaction affordances clases</para>
    ///   <a href="https://w3id.org/def/dtw#DigitalEntityDimension">dtw:DigitalEntityDimension</a>
    /// </summary>
    let DigitalEntityDimension = _prefixId.prefix "DigitalEntityDimension"
    /// <summary>
    ///   <para>rdfs:label : Digital Twin</para>
    ///   <para>rdfs:comment : A realistic representation of all product life cycle components using physical, virtual and interaction data.</para>
    ///   <a href="https://w3id.org/def/dtw#DigitalTwin">dtw:DigitalTwin</a>
    /// </summary>
    let DigitalTwin = _prefixId.prefix "DigitalTwin"
    /// <summary>
    ///   <para>rdfs:label : Digital Twin Aggregate</para>
    ///   <para>rdfs:comment : Describes the aggregation of all the DTIs. Unlike the DTI, the DTA may not be an independent data structure. It may be a computing construct that has access to all DTIs and queries them either ad-hoc or proactively.</para>
    ///   <a href="https://w3id.org/def/dtw#DigitalTwinAggregate">dtw:DigitalTwinAggregate</a>
    /// </summary>
    let DigitalTwinAggregate = _prefixId.prefix "DigitalTwinAggregate"
    /// <summary>
    ///   <para>rdfs:label : Digital Twin Dimension</para>
    ///   <para>rdfs:comment : Dimensions of which the digital twin is composed.</para>
    ///   <a href="https://w3id.org/def/dtw#DigitalTwinDimension">dtw:DigitalTwinDimension</a>
    /// </summary>
    let DigitalTwinDimension = _prefixId.prefix "DigitalTwinDimension"
    /// <summary>
    ///   <para>rdfs:label : Digital Twin Instance</para>
    ///   <para>rdfs:comment : Describes a specific corresponding physical product that an individual Digital Twin remains linked to throughout the life of that physical product.</para>
    ///   <a href="https://w3id.org/def/dtw#DigitalTwinInstance">dtw:DigitalTwinInstance</a>
    /// </summary>
    let DigitalTwinInstance = _prefixId.prefix "DigitalTwinInstance"
    /// <summary>
    ///   <para>rdfs:label : External Connection Point</para>
    ///   <para>rdfs:comment : Connection point of the connection that is external to the DTw.</para>
    ///   <a href="https://w3id.org/def/dtw#ExternalConnectionPoint">dtw:ExternalConnectionPoint</a>
    /// </summary>
    let ExternalConnectionPoint = _prefixId.prefix "ExternalConnectionPoint"
    /// <summary>
    ///   <para>rdfs:label : Format</para>
    ///   <para>rdfs:comment : Extension format in which the model or data is available.</para>
    ///   <a href="https://w3id.org/def/dtw#Format">dtw:Format</a>
    /// </summary>
    let Format = _prefixId.prefix "Format"
    /// <summary>
    ///   <para>rdfs:label : Geometric Model</para>
    ///   <para>rdfs:comment : Describes all the geometric parameters of the physical entity (e.g. shapes, sizes and assembly relations).</para>
    ///   <a href="https://w3id.org/def/dtw#GeometricModel">dtw:GeometricModel</a>
    /// </summary>
    let GeometricModel = _prefixId.prefix "GeometricModel"
    /// <summary>
    ///   <para>rdfs:label : Internal Connection Point</para>
    ///   <para>rdfs:comment : Connection point of the connection that is internal to the DTw.</para>
    ///   <a href="https://w3id.org/def/dtw#InternalConnectionPoint">dtw:InternalConnectionPoint</a>
    /// </summary>
    let InternalConnectionPoint = _prefixId.prefix "InternalConnectionPoint"
    /// <summary>
    ///   <para>rdfs:label : Mapping Model</para>
    ///   <para>rdfs:comment : Model that allows the alignment of data with the objective of obtaining harmonised data from non-harmonised data.</para>
    ///   <a href="https://w3id.org/def/dtw#MappingModel">dtw:MappingModel</a>
    /// </summary>
    let MappingModel = _prefixId.prefix "MappingModel"
    /// <summary>
    ///   <para>rdfs:label : Model</para>
    ///   <para>rdfs:comment : Representation or conceptualization of the data registered in the Virtual Entity dimension.</para>
    ///   <a href="https://w3id.org/def/dtw#Model">dtw:Model</a>
    /// </summary>
    let Model = _prefixId.prefix "Model"
    /// <summary>
    ///   <para>rdfs:label : Model Data Connection</para>
    ///   <para>rdfs:comment : Connection between dtw:Model and dcat:Resource.</para>
    ///   <a href="https://w3id.org/def/dtw#ModelDataConnection">dtw:ModelDataConnection</a>
    /// </summary>
    let ModelDataConnection = _prefixId.prefix "ModelDataConnection"
    /// <summary>
    ///   <para>dce:description : Model to model connection.</para>
    ///   <para>rdfs:label : Model Model Connection</para>
    ///   <para>rdfs:comment : Model to model connection.</para>
    ///   <a href="https://w3id.org/def/dtw#ModelModelConnection">dtw:ModelModelConnection</a>
    /// </summary>
    let ModelModelConnection = _prefixId.prefix "ModelModelConnection"
    /// <summary>
    ///   <para>rdfs:label : Model Service Connection</para>
    ///   <para>rdfs:comment : Connection between dtw:Model and td:InteractionAffordance.</para>
    ///   <a href="https://w3id.org/def/dtw#ModelServiceConnection">dtw:ModelServiceConnection</a>
    /// </summary>
    let ModelServiceConnection = _prefixId.prefix "ModelServiceConnection"
    /// <summary>
    ///   <para>rdfs:label : Ontology Model</para>
    ///   <para>rdfs:comment : Model that contains the conceptualization of the information of the digital twin. This conceptualization activity refers to the organization and structuration of the information (data, knowledge, etc.), obtained during the acquisition process, into meaningful models at the knowledge level and according to the ontology requirements specification document.</para>
    ///   <a href="https://w3id.org/def/dtw#OntologyModel">dtw:OntologyModel</a>
    /// </summary>
    let OntologyModel = _prefixId.prefix "OntologyModel"
    /// <summary>
    ///   <para>rdfs:label : Physical Entity</para>
    ///   <para>rdfs:comment : This dimension of the digital twin consists of various subsystems, objects and sensory devices. These subsystems can include dynamic systems, control systems, maintenance systems, etc., and can be combined for a specific task. Also, non physical entities can be represented.</para>
    ///   <a href="https://w3id.org/def/dtw#PhysicalEntity">dtw:PhysicalEntity</a>
    /// </summary>
    let PhysicalEntity = _prefixId.prefix "PhysicalEntity"
    /// <summary>
    ///   <para>rdfs:label : Physical Model</para>
    ///   <para>rdfs:comment : Responsible for providing all the physical properties (e.g. speed and force) based on dt:GeometricModel</para>
    ///   <a href="https://w3id.org/def/dtw#PhysicalModel">dtw:PhysicalModel</a>
    /// </summary>
    let PhysicalModel = _prefixId.prefix "PhysicalModel"
    /// <summary>
    ///   <para>rdfs:label : Rules Model</para>
    ///   <para>rdfs:comment : A set of rules extracted from the historical data obtained from the physical model, whose function is to provide the virtual entity with a judgment for decision making, optimization, evaluation, prediction and maintenance.</para>
    ///   <a href="https://w3id.org/def/dtw#RulesModel">dtw:RulesModel</a>
    /// </summary>
    let RulesModel = _prefixId.prefix "RulesModel"
    /// <summary>
    ///   <para>dce:description : Model representing semantic web rules or conceptualizations.</para>
    ///   <para>rdfs:label : Semantic Model</para>
    ///   <para>rdfs:comment : Model representing semantic web rules or conceptualizations.</para>
    ///   <a href="https://w3id.org/def/dtw#SemanticModel">dtw:SemanticModel</a>
    /// </summary>
    let SemanticModel = _prefixId.prefix "SemanticModel"
    /// <summary>
    ///   <para>rdfs:label : Shapes Model</para>
    ///   <para>rdfs:comment : Model that contains the data validation rules allowing the data to be validated.</para>
    ///   <a href="https://w3id.org/def/dtw#ShapesModel">dtw:ShapesModel</a>
    /// </summary>
    let ShapesModel = _prefixId.prefix "ShapesModel"
    /// <summary>
    ///   <para>rdfs:label : aggregate DTwA</para>
    ///   <para>rdfs:comment : Property that describes de action of aggregation between two different entities or dtw:DigitalTwinAggregate.</para>
    ///   <a href="https://w3id.org/def/dtw#aggregateDTwA">dtw:aggregateDTwA</a>
    /// </summary>
    let aggregateDTwA = _prefixId.prefix "aggregateDTwA"
    /// <summary>
    ///   <para>rdfs:label : aggregate DTwI</para>
    ///   <para>rdfs:comment : Property that describes de action of aggregation between two different entities or dtw:DigitalTwinInstance.</para>
    ///   <a href="https://w3id.org/def/dtw#aggregateDTwI">dtw:aggregateDTwI</a>
    /// </summary>
    let aggregateDTwI = _prefixId.prefix "aggregateDTwI"
    /// <summary>
    ///   <para>dce:description : DTwA aggregated from a specific DTwA</para>
    ///   <para>rdfs:label : aggregated DTwA from</para>
    ///   <para>rdfs:comment : DTwA aggregated from a specific DTwA</para>
    ///   <a href="https://w3id.org/def/dtw#aggregatedDTwAFrom">dtw:aggregatedDTwAFrom</a>
    /// </summary>
    let aggregatedDTwAFrom = _prefixId.prefix "aggregatedDTwAFrom"
    /// <summary>
    ///   <para>dce:description : DTwI aggregated from a specific DTwA</para>
    ///   <para>rdfs:label : aggregated DTwI from</para>
    ///   <para>rdfs:comment : DTwI aggregated from a specific DTwA</para>
    ///   <a href="https://w3id.org/def/dtw#aggregatedDTwIFrom">dtw:aggregatedDTwIFrom</a>
    /// </summary>
    let aggregatedDTwIFrom = _prefixId.prefix "aggregatedDTwIFrom"
    /// <summary>
    ///   <para>rdfs:label : contains interaction affordance</para>
    ///   <para>rdfs:comment : Property that describes the different interaction affordances that the dt:DigitalTwinServices contains.</para>
    ///   <a href="https://w3id.org/def/dtw#containsInteractionAffordance">dtw:containsInteractionAffordance</a>
    /// </summary>
    let containsInteractionAffordance = _prefixId.prefix "containsInteractionAffordance"
    /// <summary>
    ///   <para>rdfs:label : has connection</para>
    ///   <para>rdfs:comment : Property that describes the different connections of the dtw:DigitalTwin.</para>
    ///   <a href="https://w3id.org/def/dtw#hasConnection">dtw:hasConnection</a>
    /// </summary>
    let hasConnection = _prefixId.prefix "hasConnection"
    /// <summary>
    ///   <para>rdfs:label : has connection point</para>
    ///   <para>rdfs:comment : Property that describes the connection point that the element of the DTw has to connect with others</para>
    ///   <a href="https://w3id.org/def/dtw#hasConnectionPoint">dtw:hasConnectionPoint</a>
    /// </summary>
    let hasConnectionPoint = _prefixId.prefix "hasConnectionPoint"
    /// <summary>
    ///   <para>rdfs:label : has consumer</para>
    ///   <para>rdfs:comment : Property that describes if the connection point is the consumer of the information.</para>
    ///   <a href="https://w3id.org/def/dtw#hasConsumer">dtw:hasConsumer</a>
    /// </summary>
    let hasConsumer = _prefixId.prefix "hasConsumer"
    /// <summary>
    ///   <para>rdfs:label : has data</para>
    ///   <para>rdfs:comment : Property that describes the different data that the dt:DigitalTwinData contains.</para>
    ///   <a href="https://w3id.org/def/dtw#hasData">dtw:hasData</a>
    /// </summary>
    let hasData = _prefixId.prefix "hasData"
    /// <summary>
    ///   <para>rdfs:label : has digital entity</para>
    ///   <para>rdfs:comment : Property that describes the different Digital Entities that the digital twin contains.</para>
    ///   <a href="https://w3id.org/def/dtw#hasDigitalEntity">dtw:hasDigitalEntity</a>
    /// </summary>
    let hasDigitalEntity = _prefixId.prefix "hasDigitalEntity"
    /// <summary>
    ///   <para>rdfs:label : has extension</para>
    ///   <para>rdfs:comment : Extension of the model or data with which can be found.</para>
    ///   <a href="https://w3id.org/def/dtw#hasExtension">dtw:hasExtension</a>
    /// </summary>
    let hasExtension = _prefixId.prefix "hasExtension"
    /// <summary>
    ///   <para>rdfs:label : has format</para>
    ///   <para>rdfs:comment : Property that describes the different extension formats that the models or data can be found.</para>
    ///   <a href="https://w3id.org/def/dtw#hasFormat">dtw:hasFormat</a>
    /// </summary>
    let hasFormat = _prefixId.prefix "hasFormat"
    /// <summary>
    ///   <para>rdfs:label : has model</para>
    ///   <para>rdfs:comment : Property that describes the different models that the dtw:DigitalEntity contains.</para>
    ///   <a href="https://w3id.org/def/dtw#hasModel">dtw:hasModel</a>
    /// </summary>
    let hasModel = _prefixId.prefix "hasModel"
    /// <summary>
    ///   <para>rdfs:label : has physical entity</para>
    ///   <para>rdfs:comment : Property that describes the Physical Entity that the digital twin describes.</para>
    ///   <a href="https://w3id.org/def/dtw#hasPhysicalEntity">dtw:hasPhysicalEntity</a>
    /// </summary>
    let hasPhysicalEntity = _prefixId.prefix "hasPhysicalEntity"
    /// <summary>
    ///   <para>rdfs:label : has provider</para>
    ///   <para>rdfs:comment : Property that describes if the connection point is the provider of the information.</para>
    ///   <a href="https://w3id.org/def/dtw#hasProvider">dtw:hasProvider</a>
    /// </summary>
    let hasProvider = _prefixId.prefix "hasProvider"
    /// <summary>
    ///   <para>dce:description : Connection of a Digital Twin.</para>
    ///   <para>rdfs:label : is connection of</para>
    ///   <para>rdfs:comment : Connection of a Digital Twin.</para>
    ///   <a href="https://w3id.org/def/dtw#isConnectionOf">dtw:isConnectionOf</a>
    /// </summary>
    let isConnectionOf = _prefixId.prefix "isConnectionOf"
    /// <summary>
    ///   <para>dce:description : Connection point is referred to a Digital Entity Dimension</para>
    ///   <para>rdfs:label : is connection point of</para>
    ///   <para>rdfs:comment : Connection point is referred to a Digital Entity Dimension</para>
    ///   <a href="https://w3id.org/def/dtw#isConnectionPointOf">dtw:isConnectionPointOf</a>
    /// </summary>
    let isConnectionPointOf = _prefixId.prefix "isConnectionPointOf"
    /// <summary>
    ///   <para>dce:description : Connection point is consumer of a connection.</para>
    ///   <para>rdfs:label : is consumer of</para>
    ///   <para>rdfs:comment : Connection point is consumer of a connection.</para>
    ///   <a href="https://w3id.org/def/dtw#isConsumerOf">dtw:isConsumerOf</a>
    /// </summary>
    let isConsumerOf = _prefixId.prefix "isConsumerOf"
    /// <summary>
    ///   <para>dce:description : Data of a Digital Entity.</para>
    ///   <para>rdfs:label : is data of</para>
    ///   <para>rdfs:comment : Data of a Digital Entity.</para>
    ///   <a href="https://w3id.org/def/dtw#isDataOf">dtw:isDataOf</a>
    /// </summary>
    let isDataOf = _prefixId.prefix "isDataOf"
    /// <summary>
    ///   <para>dce:description : Digital entity of a Digital Twin.</para>
    ///   <para>rdfs:label : is digital entity of</para>
    ///   <para>rdfs:comment : Digital entity of a Digital Twin.</para>
    ///   <a href="https://w3id.org/def/dtw#isDigitalEntityOf">dtw:isDigitalEntityOf</a>
    /// </summary>
    let isDigitalEntityOf = _prefixId.prefix "isDigitalEntityOf"
    /// <summary>
    ///   <para>dce:description : Format of a Model.</para>
    ///   <para>rdfs:label : is format of</para>
    ///   <para>rdfs:comment : Format of a Model.</para>
    ///   <a href="https://w3id.org/def/dtw#isFormatOf">dtw:isFormatOf</a>
    /// </summary>
    let isFormatOf = _prefixId.prefix "isFormatOf"
    /// <summary>
    ///   <para>dce:description : Interaction Afforfance of a Digital Entity.</para>
    ///   <para>rdfs:label : is interaction affordance of</para>
    ///   <para>rdfs:comment : Interaction Afforfance of a Digital Entity.</para>
    ///   <a href="https://w3id.org/def/dtw#isInteracctionAffordanceOf">dtw:isInteracctionAffordanceOf</a>
    /// </summary>
    let isInteracctionAffordanceOf = _prefixId.prefix "isInteracctionAffordanceOf"
    /// <summary>
    ///   <para>dce:description : Model contained by the Digital Entity Dimension.</para>
    ///   <para>rdfs:label : is model of</para>
    ///   <para>rdfs:comment : Model contained by the Digital Entity Dimension.</para>
    ///   <a href="https://w3id.org/def/dtw#isModelOf">dtw:isModelOf</a>
    /// </summary>
    let isModelOf = _prefixId.prefix "isModelOf"
    /// <summary>
    ///   <para>dce:description : Physical entity of a Digital Twin.</para>
    ///   <para>rdfs:label : is physical entity of</para>
    ///   <para>rdfs:comment : Physical entity of a Digital Twin.</para>
    ///   <a href="https://w3id.org/def/dtw#isPhysicalEntityOf">dtw:isPhysicalEntityOf</a>
    /// </summary>
    let isPhysicalEntityOf = _prefixId.prefix "isPhysicalEntityOf"
    /// <summary>
    ///   <para>dce:description : Connection point is provider of a connection.</para>
    ///   <para>rdfs:label : is provider of</para>
    ///   <para>rdfs:comment : Connection point is provider of a connection.</para>
    ///   <a href="https://w3id.org/def/dtw#isProviderOf">dtw:isProviderOf</a>
    /// </summary>
    let isProviderOf = _prefixId.prefix "isProviderOf"
    /// <summary>
    ///   <para>rdfs:label : model aggregated from</para>
    ///   <para>rdfs:comment : Model aggregated from model.</para>
    ///   <a href="https://w3id.org/def/dtw#modelAggregatedFrom">dtw:modelAggregatedFrom</a>
    /// </summary>
    let modelAggregatedFrom = _prefixId.prefix "modelAggregatedFrom"
    /// <summary>
    ///   <para>dce:description : Model aggregates model.</para>
    ///   <para>rdfs:label : model aggregates</para>
    ///   <para>rdfs:comment : Model aggregates model.</para>
    ///   <a href="https://w3id.org/def/dtw#modelAggregates">dtw:modelAggregates</a>
    /// </summary>
    let modelAggregates = _prefixId.prefix "modelAggregates"
    /// <summary>
    ///   <para>rdfs:label : resource aggregated from</para>
    ///   <para>rdfs:comment : Resource aggregated from resource.</para>
    ///   <a href="https://w3id.org/def/dtw#resourceAggregatedFrom">dtw:resourceAggregatedFrom</a>
    /// </summary>
    let resourceAggregatedFrom = _prefixId.prefix "resourceAggregatedFrom"
    /// <summary>
    ///   <para>dce:description : Resource aggregates resource.</para>
    ///   <para>rdfs:label : resource aggregates</para>
    ///   <para>rdfs:comment : Resource aggregates resource.</para>
    ///   <a href="https://w3id.org/def/dtw#resourceAggregates">dtw:resourceAggregates</a>
    /// </summary>
    let resourceAggregates = _prefixId.prefix "resourceAggregates"
