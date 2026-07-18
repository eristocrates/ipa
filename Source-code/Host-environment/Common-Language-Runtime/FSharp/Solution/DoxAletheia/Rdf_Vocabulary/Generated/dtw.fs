namespace https.w3id.org.def.dtw.hash

open DoxAletheia.Rdf_Vocabulary

module dtw =
    let _namespace_name = "https://w3id.org/def/dtw#"

    /// <summary>
    /// This dimension of the digital twin consists of various data models that represents all the information allocated in the digital twin.
    /// <see href="https://w3id.org/def/dtw#DigitalEntity"></see></summary>
    let DigitalEntity =
        Namespaced_IRI.parse _namespace_name "DigitalEntity" |> NamespacedName

    /// <summary>
    /// Data of a Digital Entity.
    /// <see href="https://w3id.org/def/dtw#isDataOf"></see></summary>
    let isDataOf = Namespaced_IRI.parse _namespace_name "isDataOf" |> NamespacedName

    /// <summary>
    /// Resource aggregated from resource.
    /// <see href="https://w3id.org/def/dtw#resourceAggregatedFrom"></see></summary>
    let resourceAggregatedFrom =
        Namespaced_IRI.parse _namespace_name "resourceAggregatedFrom" |> NamespacedName

    /// <summary>
    /// Resource aggregates resource.
    /// <see href="https://w3id.org/def/dtw#resourceAggregates"></see></summary>
    let resourceAggregates =
        Namespaced_IRI.parse _namespace_name "resourceAggregates" |> NamespacedName

    /// <summary>
    /// Digital Entity Dimension class to add resource, model and interaction affordances clases
    /// <see href="https://w3id.org/def/dtw#DigitalEntityDimension"></see></summary>
    let DigitalEntityDimension =
        Namespaced_IRI.parse _namespace_name "DigitalEntityDimension" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/dtw#0.5.0"></see>
    /// </summary>
    let ``_0.5.0`` = Namespaced_IRI.parse _namespace_name "0.5.0" |> NamespacedName

    /// <summary>
    /// Describes the behaviors and response mechanisms of the entity (e.g. state transition, performance and disturbances)
    /// <see href="https://w3id.org/def/dtw#BehavioralModel"></see></summary>
    let BehavioralModel =
        Namespaced_IRI.parse _namespace_name "BehavioralModel" |> NamespacedName

    /// <summary>
    /// Representation or conceptualization of the data registered in the Virtual Entity dimension.
    /// <see href="https://w3id.org/def/dtw#Model"></see></summary>
    let Model = Namespaced_IRI.parse _namespace_name "Model" |> NamespacedName
    /// <summary>
    /// Existing connection between different dtw:ConnectionPoint.
    /// <see href="https://w3id.org/def/dtw#Connection"></see></summary>
    let Connection = Namespaced_IRI.parse _namespace_name "Connection" |> NamespacedName

    /// <summary>
    /// Connection point of the connection that is internal to the DTw.
    /// <see href="https://w3id.org/def/dtw#InternalConnectionPoint"></see></summary>
    let InternalConnectionPoint =
        Namespaced_IRI.parse _namespace_name "InternalConnectionPoint" |> NamespacedName

    /// <summary>
    /// Property that describes if the connection point is the consumer of the information.
    /// <see href="https://w3id.org/def/dtw#hasConsumer"></see></summary>
    let hasConsumer =
        Namespaced_IRI.parse _namespace_name "hasConsumer" |> NamespacedName

    /// <summary>
    /// Dimensions of which the digital twin is composed.
    /// <see href="https://w3id.org/def/dtw#DigitalTwinDimension"></see></summary>
    let DigitalTwinDimension =
        Namespaced_IRI.parse _namespace_name "DigitalTwinDimension" |> NamespacedName

    /// <summary>
    /// Connection point of the connection.
    /// <see href="https://w3id.org/def/dtw#ConnectionPoint"></see></summary>
    let ConnectionPoint =
        Namespaced_IRI.parse _namespace_name "ConnectionPoint" |> NamespacedName

    /// <summary>
    /// Property that describes if the connection point is the provider of the information.
    /// <see href="https://w3id.org/def/dtw#hasProvider"></see></summary>
    let hasProvider =
        Namespaced_IRI.parse _namespace_name "hasProvider" |> NamespacedName

    /// <summary>
    /// Connection point of the connection that is external to the DTw.
    /// <see href="https://w3id.org/def/dtw#ExternalConnectionPoint"></see></summary>
    let ExternalConnectionPoint =
        Namespaced_IRI.parse _namespace_name "ExternalConnectionPoint" |> NamespacedName

    /// <summary>
    /// Connection between dcat:Resource and td:InteractionAffordance.
    /// <see href="https://w3id.org/def/dtw#DataServiceConnection"></see></summary>
    let DataServiceConnection =
        Namespaced_IRI.parse _namespace_name "DataServiceConnection" |> NamespacedName

    /// <summary>
    /// Property that describes the different interaction affordances that the dt:DigitalTwinServices contains.
    /// <see href="https://w3id.org/def/dtw#containsInteractionAffordance"></see></summary>
    let containsInteractionAffordance =
        Namespaced_IRI.parse _namespace_name "containsInteractionAffordance" |> NamespacedName

    /// <summary>
    /// A set of rules extracted from the historical data obtained from the physical model, whose function is to provide the virtual entity with a judgment for decision making, optimization, evaluation, prediction and maintenance.
    /// <see href="https://w3id.org/def/dtw#RulesModel"></see></summary>
    let RulesModel = Namespaced_IRI.parse _namespace_name "RulesModel" |> NamespacedName
    /// <summary>
    /// Property that describes the different models that the dtw:DigitalEntity contains.
    /// <see href="https://w3id.org/def/dtw#hasModel"></see></summary>
    let hasModel = Namespaced_IRI.parse _namespace_name "hasModel" |> NamespacedName

    /// <summary>
    /// Model representing semantic web rules or conceptualizations.
    /// <see href="https://w3id.org/def/dtw#SemanticModel"></see></summary>
    let SemanticModel =
        Namespaced_IRI.parse _namespace_name "SemanticModel" |> NamespacedName

    /// <summary>
    /// Responsible for providing all the physical properties (e.g. speed and force) based on dt:GeometricModel
    /// <see href="https://w3id.org/def/dtw#PhysicalModel"></see></summary>
    let PhysicalModel =
        Namespaced_IRI.parse _namespace_name "PhysicalModel" |> NamespacedName

    /// <summary>
    /// Property that describes the different data that the dt:DigitalTwinData contains.
    /// <see href="https://w3id.org/def/dtw#hasData"></see></summary>
    let hasData = Namespaced_IRI.parse _namespace_name "hasData" |> NamespacedName

    /// <summary>
    /// Model that contains the conceptualization of the information of the digital twin. This conceptualization activity refers to the organization and structuration of the information (data, knowledge, etc.), obtained during the acquisition process, into meaningful models at the knowledge level and according to the ontology requirements specification document.
    /// <see href="https://w3id.org/def/dtw#OntologyModel"></see></summary>
    let OntologyModel =
        Namespaced_IRI.parse _namespace_name "OntologyModel" |> NamespacedName

    /// <summary>
    /// Describes all the geometric parameters of the physical entity (e.g. shapes, sizes and assembly relations).
    /// <see href="https://w3id.org/def/dtw#GeometricModel"></see></summary>
    let GeometricModel =
        Namespaced_IRI.parse _namespace_name "GeometricModel" |> NamespacedName

    /// <summary>
    /// Model that allows the alignment of data with the objective of obtaining harmonised data from non-harmonised data.
    /// <see href="https://w3id.org/def/dtw#MappingModel"></see></summary>
    let MappingModel =
        Namespaced_IRI.parse _namespace_name "MappingModel" |> NamespacedName

    /// <summary>
    /// Model that contains the data validation rules allowing the data to be validated.
    /// <see href="https://w3id.org/def/dtw#ShapesModel"></see></summary>
    let ShapesModel =
        Namespaced_IRI.parse _namespace_name "ShapesModel" |> NamespacedName

    /// <summary>
    /// A realistic representation of all product life cycle components using physical, virtual and interaction data.
    /// <see href="https://w3id.org/def/dtw#DigitalTwin"></see></summary>
    let DigitalTwin =
        Namespaced_IRI.parse _namespace_name "DigitalTwin" |> NamespacedName

    /// <summary>
    /// Property that describes the Physical Entity that the digital twin describes.
    /// <see href="https://w3id.org/def/dtw#hasPhysicalEntity"></see></summary>
    let hasPhysicalEntity =
        Namespaced_IRI.parse _namespace_name "hasPhysicalEntity" |> NamespacedName

    /// <summary>
    /// This dimension of the digital twin consists of various subsystems, objects and sensory devices. These subsystems can include dynamic systems, control systems, maintenance systems, etc., and can be combined for a specific task. Also, non physical entities can be represented.
    /// <see href="https://w3id.org/def/dtw#PhysicalEntity"></see></summary>
    let PhysicalEntity =
        Namespaced_IRI.parse _namespace_name "PhysicalEntity" |> NamespacedName

    /// <summary>
    /// Connection between dtw:Model and td:InteractionAffordance.
    /// <see href="https://w3id.org/def/dtw#ModelServiceConnection"></see></summary>
    let ModelServiceConnection =
        Namespaced_IRI.parse _namespace_name "ModelServiceConnection" |> NamespacedName

    /// <summary>
    /// Property that describes the different connections of the dtw:DigitalTwin.
    /// <see href="https://w3id.org/def/dtw#hasConnection"></see></summary>
    let hasConnection =
        Namespaced_IRI.parse _namespace_name "hasConnection" |> NamespacedName

    /// <summary>
    /// Property that describes the different Digital Entities that the digital twin contains.
    /// <see href="https://w3id.org/def/dtw#hasDigitalEntity"></see></summary>
    let hasDigitalEntity =
        Namespaced_IRI.parse _namespace_name "hasDigitalEntity" |> NamespacedName

    /// <summary>
    /// Connection between dtw:Model and dcat:Resource.
    /// <see href="https://w3id.org/def/dtw#ModelDataConnection"></see></summary>
    let ModelDataConnection =
        Namespaced_IRI.parse _namespace_name "ModelDataConnection" |> NamespacedName

    /// <summary>
    /// Model to model connection.
    /// <see href="https://w3id.org/def/dtw#ModelModelConnection"></see></summary>
    let ModelModelConnection =
        Namespaced_IRI.parse _namespace_name "ModelModelConnection" |> NamespacedName

    /// <summary>
    /// Describes the aggregation of all the DTIs. Unlike the DTI, the DTA may not be an independent data structure. It may be a computing construct that has access to all DTIs and queries them either ad-hoc or proactively.
    /// <see href="https://w3id.org/def/dtw#DigitalTwinAggregate"></see></summary>
    let DigitalTwinAggregate =
        Namespaced_IRI.parse _namespace_name "DigitalTwinAggregate" |> NamespacedName

    /// <summary>
    /// Property that describes de action of aggregation between two different entities or dtw:DigitalTwinAggregate.
    /// <see href="https://w3id.org/def/dtw#aggregateDTwA"></see></summary>
    let aggregateDTwA =
        Namespaced_IRI.parse _namespace_name "aggregateDTwA" |> NamespacedName

    /// <summary>
    /// Describes a specific corresponding physical product that an individual Digital Twin remains linked to throughout the life of that physical product.
    /// <see href="https://w3id.org/def/dtw#DigitalTwinInstance"></see></summary>
    let DigitalTwinInstance =
        Namespaced_IRI.parse _namespace_name "DigitalTwinInstance" |> NamespacedName

    /// <summary>
    /// Property that describes de action of aggregation between two different entities or dtw:DigitalTwinInstance.
    /// <see href="https://w3id.org/def/dtw#aggregateDTwI"></see></summary>
    let aggregateDTwI =
        Namespaced_IRI.parse _namespace_name "aggregateDTwI" |> NamespacedName

    /// <summary>
    /// Extension format in which the model or data is available.
    /// <see href="https://w3id.org/def/dtw#Format"></see></summary>
    let Format = Namespaced_IRI.parse _namespace_name "Format" |> NamespacedName
    /// <summary>
    /// Model contained by the Digital Entity Dimension.
    /// <see href="https://w3id.org/def/dtw#isModelOf"></see></summary>
    let isModelOf = Namespaced_IRI.parse _namespace_name "isModelOf" |> NamespacedName

    /// <summary>
    /// Model aggregated from model.
    /// <see href="https://w3id.org/def/dtw#modelAggregatedFrom"></see></summary>
    let modelAggregatedFrom =
        Namespaced_IRI.parse _namespace_name "modelAggregatedFrom" |> NamespacedName

    /// <summary>
    /// Model aggregates model.
    /// <see href="https://w3id.org/def/dtw#modelAggregates"></see></summary>
    let modelAggregates =
        Namespaced_IRI.parse _namespace_name "modelAggregates" |> NamespacedName

    /// <summary>
    /// Property that describes the different extension formats that the models or data can be found.
    /// <see href="https://w3id.org/def/dtw#hasFormat"></see></summary>
    let hasFormat = Namespaced_IRI.parse _namespace_name "hasFormat" |> NamespacedName

    /// <summary>
    /// DTwA aggregated from a specific DTwA
    /// <see href="https://w3id.org/def/dtw#aggregatedDTwAFrom"></see></summary>
    let aggregatedDTwAFrom =
        Namespaced_IRI.parse _namespace_name "aggregatedDTwAFrom" |> NamespacedName

    /// <summary>
    /// DTwI aggregated from a specific DTwA
    /// <see href="https://w3id.org/def/dtw#aggregatedDTwIFrom"></see></summary>
    let aggregatedDTwIFrom =
        Namespaced_IRI.parse _namespace_name "aggregatedDTwIFrom" |> NamespacedName

    /// <summary>
    /// Interaction Afforfance of a Digital Entity.
    /// <see href="https://w3id.org/def/dtw#isInteracctionAffordanceOf"></see></summary>
    let isInteracctionAffordanceOf =
        Namespaced_IRI.parse _namespace_name "isInteracctionAffordanceOf" |> NamespacedName

    /// <summary>
    /// Connection of a Digital Twin.
    /// <see href="https://w3id.org/def/dtw#isConnectionOf"></see></summary>
    let isConnectionOf =
        Namespaced_IRI.parse _namespace_name "isConnectionOf" |> NamespacedName

    /// <summary>
    /// Property that describes the connection point that the element of the DTw has to connect with others
    /// <see href="https://w3id.org/def/dtw#hasConnectionPoint"></see></summary>
    let hasConnectionPoint =
        Namespaced_IRI.parse _namespace_name "hasConnectionPoint" |> NamespacedName

    /// <summary>
    /// Connection point is referred to a Digital Entity Dimension
    /// <see href="https://w3id.org/def/dtw#isConnectionPointOf"></see></summary>
    let isConnectionPointOf =
        Namespaced_IRI.parse _namespace_name "isConnectionPointOf" |> NamespacedName

    /// <summary>
    /// Connection point is consumer of a connection.
    /// <see href="https://w3id.org/def/dtw#isConsumerOf"></see></summary>
    let isConsumerOf =
        Namespaced_IRI.parse _namespace_name "isConsumerOf" |> NamespacedName

    /// <summary>
    /// Digital entity of a Digital Twin.
    /// <see href="https://w3id.org/def/dtw#isDigitalEntityOf"></see></summary>
    let isDigitalEntityOf =
        Namespaced_IRI.parse _namespace_name "isDigitalEntityOf" |> NamespacedName

    /// <summary>
    /// Extension of the model or data with which can be found.
    /// <see href="https://w3id.org/def/dtw#hasExtension"></see></summary>
    let hasExtension =
        Namespaced_IRI.parse _namespace_name "hasExtension" |> NamespacedName

    /// <summary>
    /// Format of a Model.
    /// <see href="https://w3id.org/def/dtw#isFormatOf"></see></summary>
    let isFormatOf = Namespaced_IRI.parse _namespace_name "isFormatOf" |> NamespacedName

    /// <summary>
    /// Physical entity of a Digital Twin.
    /// <see href="https://w3id.org/def/dtw#isPhysicalEntityOf"></see></summary>
    let isPhysicalEntityOf =
        Namespaced_IRI.parse _namespace_name "isPhysicalEntityOf" |> NamespacedName

    /// <summary>
    /// Connection point is provider of a connection.
    /// <see href="https://w3id.org/def/dtw#isProviderOf"></see></summary>
    let isProviderOf =
        Namespaced_IRI.parse _namespace_name "isProviderOf" |> NamespacedName
