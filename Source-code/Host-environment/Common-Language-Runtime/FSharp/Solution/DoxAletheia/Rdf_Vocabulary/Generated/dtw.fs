namespace https.w3id.org.def.dtw.hash

open DoxAletheia

module dtw =
    let _namespace_name = "https://w3id.org/def/dtw#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// This dimension of the digital twin consists of various data models that represents all the information allocated in the digital twin.
    /// <see href="https://w3id.org/def/dtw#DigitalEntity"></see></summary>
    let DigitalEntity = _prefix "DigitalEntity"
    /// <summary>
    /// Data of a Digital Entity.
    /// <see href="https://w3id.org/def/dtw#isDataOf"></see></summary>
    let isDataOf = _prefix "isDataOf"
    /// <summary>
    /// Resource aggregated from resource.
    /// <see href="https://w3id.org/def/dtw#resourceAggregatedFrom"></see></summary>
    let resourceAggregatedFrom = _prefix "resourceAggregatedFrom"
    /// <summary>
    /// Resource aggregates resource.
    /// <see href="https://w3id.org/def/dtw#resourceAggregates"></see></summary>
    let resourceAggregates = _prefix "resourceAggregates"
    /// <summary>
    /// Digital Entity Dimension class to add resource, model and interaction affordances clases
    /// <see href="https://w3id.org/def/dtw#DigitalEntityDimension"></see></summary>
    let DigitalEntityDimension = _prefix "DigitalEntityDimension"
    /// <summary>
    ///   <see href="https://w3id.org/def/dtw#0.5.0"></see>
    /// </summary>
    let ``_0.5.0`` = _prefix "0.5.0"
    /// <summary>
    /// Describes the behaviors and response mechanisms of the entity (e.g. state transition, performance and disturbances)
    /// <see href="https://w3id.org/def/dtw#BehavioralModel"></see></summary>
    let BehavioralModel = _prefix "BehavioralModel"
    /// <summary>
    /// Representation or conceptualization of the data registered in the Virtual Entity dimension.
    /// <see href="https://w3id.org/def/dtw#Model"></see></summary>
    let Model = _prefix "Model"
    /// <summary>
    /// Existing connection between different dtw:ConnectionPoint.
    /// <see href="https://w3id.org/def/dtw#Connection"></see></summary>
    let Connection = _prefix "Connection"
    /// <summary>
    /// Connection point of the connection that is internal to the DTw.
    /// <see href="https://w3id.org/def/dtw#InternalConnectionPoint"></see></summary>
    let InternalConnectionPoint = _prefix "InternalConnectionPoint"
    /// <summary>
    /// Property that describes if the connection point is the consumer of the information.
    /// <see href="https://w3id.org/def/dtw#hasConsumer"></see></summary>
    let hasConsumer = _prefix "hasConsumer"
    /// <summary>
    /// Dimensions of which the digital twin is composed.
    /// <see href="https://w3id.org/def/dtw#DigitalTwinDimension"></see></summary>
    let DigitalTwinDimension = _prefix "DigitalTwinDimension"
    /// <summary>
    /// Connection point of the connection.
    /// <see href="https://w3id.org/def/dtw#ConnectionPoint"></see></summary>
    let ConnectionPoint = _prefix "ConnectionPoint"
    /// <summary>
    /// Property that describes if the connection point is the provider of the information.
    /// <see href="https://w3id.org/def/dtw#hasProvider"></see></summary>
    let hasProvider = _prefix "hasProvider"
    /// <summary>
    /// Connection point of the connection that is external to the DTw.
    /// <see href="https://w3id.org/def/dtw#ExternalConnectionPoint"></see></summary>
    let ExternalConnectionPoint = _prefix "ExternalConnectionPoint"
    /// <summary>
    /// Connection between dcat:Resource and td:InteractionAffordance.
    /// <see href="https://w3id.org/def/dtw#DataServiceConnection"></see></summary>
    let DataServiceConnection = _prefix "DataServiceConnection"
    /// <summary>
    /// Property that describes the different interaction affordances that the dt:DigitalTwinServices contains.
    /// <see href="https://w3id.org/def/dtw#containsInteractionAffordance"></see></summary>
    let containsInteractionAffordance = _prefix "containsInteractionAffordance"
    /// <summary>
    /// A set of rules extracted from the historical data obtained from the physical model, whose function is to provide the virtual entity with a judgment for decision making, optimization, evaluation, prediction and maintenance.
    /// <see href="https://w3id.org/def/dtw#RulesModel"></see></summary>
    let RulesModel = _prefix "RulesModel"
    /// <summary>
    /// Property that describes the different models that the dtw:DigitalEntity contains.
    /// <see href="https://w3id.org/def/dtw#hasModel"></see></summary>
    let hasModel = _prefix "hasModel"
    /// <summary>
    /// Model representing semantic web rules or conceptualizations.
    /// <see href="https://w3id.org/def/dtw#SemanticModel"></see></summary>
    let SemanticModel = _prefix "SemanticModel"
    /// <summary>
    /// Responsible for providing all the physical properties (e.g. speed and force) based on dt:GeometricModel
    /// <see href="https://w3id.org/def/dtw#PhysicalModel"></see></summary>
    let PhysicalModel = _prefix "PhysicalModel"
    /// <summary>
    /// Property that describes the different data that the dt:DigitalTwinData contains.
    /// <see href="https://w3id.org/def/dtw#hasData"></see></summary>
    let hasData = _prefix "hasData"
    /// <summary>
    /// Model that contains the conceptualization of the information of the digital twin. This conceptualization activity refers to the organization and structuration of the information (data, knowledge, etc.), obtained during the acquisition process, into meaningful models at the knowledge level and according to the ontology requirements specification document.
    /// <see href="https://w3id.org/def/dtw#OntologyModel"></see></summary>
    let OntologyModel = _prefix "OntologyModel"
    /// <summary>
    /// Describes all the geometric parameters of the physical entity (e.g. shapes, sizes and assembly relations).
    /// <see href="https://w3id.org/def/dtw#GeometricModel"></see></summary>
    let GeometricModel = _prefix "GeometricModel"
    /// <summary>
    /// Model that allows the alignment of data with the objective of obtaining harmonised data from non-harmonised data.
    /// <see href="https://w3id.org/def/dtw#MappingModel"></see></summary>
    let MappingModel = _prefix "MappingModel"
    /// <summary>
    /// Model that contains the data validation rules allowing the data to be validated.
    /// <see href="https://w3id.org/def/dtw#ShapesModel"></see></summary>
    let ShapesModel = _prefix "ShapesModel"
    /// <summary>
    /// A realistic representation of all product life cycle components using physical, virtual and interaction data.
    /// <see href="https://w3id.org/def/dtw#DigitalTwin"></see></summary>
    let DigitalTwin = _prefix "DigitalTwin"
    /// <summary>
    /// Property that describes the Physical Entity that the digital twin describes.
    /// <see href="https://w3id.org/def/dtw#hasPhysicalEntity"></see></summary>
    let hasPhysicalEntity = _prefix "hasPhysicalEntity"
    /// <summary>
    /// This dimension of the digital twin consists of various subsystems, objects and sensory devices. These subsystems can include dynamic systems, control systems, maintenance systems, etc., and can be combined for a specific task. Also, non physical entities can be represented.
    /// <see href="https://w3id.org/def/dtw#PhysicalEntity"></see></summary>
    let PhysicalEntity = _prefix "PhysicalEntity"
    /// <summary>
    /// Connection between dtw:Model and td:InteractionAffordance.
    /// <see href="https://w3id.org/def/dtw#ModelServiceConnection"></see></summary>
    let ModelServiceConnection = _prefix "ModelServiceConnection"
    /// <summary>
    /// Property that describes the different connections of the dtw:DigitalTwin.
    /// <see href="https://w3id.org/def/dtw#hasConnection"></see></summary>
    let hasConnection = _prefix "hasConnection"
    /// <summary>
    /// Property that describes the different Digital Entities that the digital twin contains.
    /// <see href="https://w3id.org/def/dtw#hasDigitalEntity"></see></summary>
    let hasDigitalEntity = _prefix "hasDigitalEntity"
    /// <summary>
    /// Connection between dtw:Model and dcat:Resource.
    /// <see href="https://w3id.org/def/dtw#ModelDataConnection"></see></summary>
    let ModelDataConnection = _prefix "ModelDataConnection"
    /// <summary>
    /// Model to model connection.
    /// <see href="https://w3id.org/def/dtw#ModelModelConnection"></see></summary>
    let ModelModelConnection = _prefix "ModelModelConnection"
    /// <summary>
    /// Describes the aggregation of all the DTIs. Unlike the DTI, the DTA may not be an independent data structure. It may be a computing construct that has access to all DTIs and queries them either ad-hoc or proactively.
    /// <see href="https://w3id.org/def/dtw#DigitalTwinAggregate"></see></summary>
    let DigitalTwinAggregate = _prefix "DigitalTwinAggregate"
    /// <summary>
    /// Property that describes de action of aggregation between two different entities or dtw:DigitalTwinAggregate.
    /// <see href="https://w3id.org/def/dtw#aggregateDTwA"></see></summary>
    let aggregateDTwA = _prefix "aggregateDTwA"
    /// <summary>
    /// Describes a specific corresponding physical product that an individual Digital Twin remains linked to throughout the life of that physical product.
    /// <see href="https://w3id.org/def/dtw#DigitalTwinInstance"></see></summary>
    let DigitalTwinInstance = _prefix "DigitalTwinInstance"
    /// <summary>
    /// Property that describes de action of aggregation between two different entities or dtw:DigitalTwinInstance.
    /// <see href="https://w3id.org/def/dtw#aggregateDTwI"></see></summary>
    let aggregateDTwI = _prefix "aggregateDTwI"
    /// <summary>
    /// Extension format in which the model or data is available.
    /// <see href="https://w3id.org/def/dtw#Format"></see></summary>
    let Format = _prefix "Format"
    /// <summary>
    /// Model contained by the Digital Entity Dimension.
    /// <see href="https://w3id.org/def/dtw#isModelOf"></see></summary>
    let isModelOf = _prefix "isModelOf"
    /// <summary>
    /// Model aggregated from model.
    /// <see href="https://w3id.org/def/dtw#modelAggregatedFrom"></see></summary>
    let modelAggregatedFrom = _prefix "modelAggregatedFrom"
    /// <summary>
    /// Model aggregates model.
    /// <see href="https://w3id.org/def/dtw#modelAggregates"></see></summary>
    let modelAggregates = _prefix "modelAggregates"
    /// <summary>
    /// Property that describes the different extension formats that the models or data can be found.
    /// <see href="https://w3id.org/def/dtw#hasFormat"></see></summary>
    let hasFormat = _prefix "hasFormat"
    /// <summary>
    /// DTwA aggregated from a specific DTwA
    /// <see href="https://w3id.org/def/dtw#aggregatedDTwAFrom"></see></summary>
    let aggregatedDTwAFrom = _prefix "aggregatedDTwAFrom"
    /// <summary>
    /// DTwI aggregated from a specific DTwA
    /// <see href="https://w3id.org/def/dtw#aggregatedDTwIFrom"></see></summary>
    let aggregatedDTwIFrom = _prefix "aggregatedDTwIFrom"
    /// <summary>
    /// Interaction Afforfance of a Digital Entity.
    /// <see href="https://w3id.org/def/dtw#isInteracctionAffordanceOf"></see></summary>
    let isInteracctionAffordanceOf = _prefix "isInteracctionAffordanceOf"
    /// <summary>
    /// Connection of a Digital Twin.
    /// <see href="https://w3id.org/def/dtw#isConnectionOf"></see></summary>
    let isConnectionOf = _prefix "isConnectionOf"
    /// <summary>
    /// Property that describes the connection point that the element of the DTw has to connect with others
    /// <see href="https://w3id.org/def/dtw#hasConnectionPoint"></see></summary>
    let hasConnectionPoint = _prefix "hasConnectionPoint"
    /// <summary>
    /// Connection point is referred to a Digital Entity Dimension
    /// <see href="https://w3id.org/def/dtw#isConnectionPointOf"></see></summary>
    let isConnectionPointOf = _prefix "isConnectionPointOf"
    /// <summary>
    /// Connection point is consumer of a connection.
    /// <see href="https://w3id.org/def/dtw#isConsumerOf"></see></summary>
    let isConsumerOf = _prefix "isConsumerOf"
    /// <summary>
    /// Digital entity of a Digital Twin.
    /// <see href="https://w3id.org/def/dtw#isDigitalEntityOf"></see></summary>
    let isDigitalEntityOf = _prefix "isDigitalEntityOf"
    /// <summary>
    /// Extension of the model or data with which can be found.
    /// <see href="https://w3id.org/def/dtw#hasExtension"></see></summary>
    let hasExtension = _prefix "hasExtension"
    /// <summary>
    /// Format of a Model.
    /// <see href="https://w3id.org/def/dtw#isFormatOf"></see></summary>
    let isFormatOf = _prefix "isFormatOf"
    /// <summary>
    /// Physical entity of a Digital Twin.
    /// <see href="https://w3id.org/def/dtw#isPhysicalEntityOf"></see></summary>
    let isPhysicalEntityOf = _prefix "isPhysicalEntityOf"
    /// <summary>
    /// Connection point is provider of a connection.
    /// <see href="https://w3id.org/def/dtw#isProviderOf"></see></summary>
    let isProviderOf = _prefix "isProviderOf"
