namespace https.w3id.org.okn.o.sdm.hash

open DoxAletheia.Rdf_Vocabulary

module sdom =
    let _namespace_name = "https://w3id.org/okn/o/sdm#"
    /// <summary>
    ///   <see href="https://w3id.org/okn/o/sdm#Category"></see>
    /// </summary>
    let Category = Namespaced_IRI.parse _namespace_name "Category" |> NamespacedName

    /// <summary>
    /// Diagram information with the processes and variables associated with a model configuration
    /// <see href="https://w3id.org/okn/o/sdm#CausalDiagram"></see></summary>
    let CausalDiagram =
        Namespaced_IRI.parse _namespace_name "CausalDiagram" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/okn/o/sdm#Constraint"></see>
    /// </summary>
    let Constraint = Namespaced_IRI.parse _namespace_name "Constraint" |> NamespacedName

    /// <summary>
    /// Model that incorporates the coupling of two or more existing models
    /// <see href="https://w3id.org/okn/o/sdm#CoupledModel"></see></summary>
    let CoupledModel =
        Namespaced_IRI.parse _namespace_name "CoupledModel" |> NamespacedName

    /// <summary>
    /// A mathematical description of a process (e.g., hydrological, agricultural, social, etc.)
    /// <see href="https://w3id.org/okn/o/sdm#Model"></see></summary>
    let Model = Namespaced_IRI.parse _namespace_name "Model" |> NamespacedName

    /// <summary>
    /// Model based on observations.
    /// <see href="https://w3id.org/okn/o/sdm#EmpiricalModel"></see></summary>
    let EmpiricalModel =
        Namespaced_IRI.parse _namespace_name "EmpiricalModel" |> NamespacedName

    /// <summary>
    /// Type of models that emulates the behavior of another model. For example, an emulator can be a machine learning model trained on the output runs of a hydrology model
    /// <see href="https://w3id.org/okn/o/sdm#Emulator"></see></summary>
    let Emulator = Namespaced_IRI.parse _namespace_name "Emulator" |> NamespacedName
    /// <summary>
    /// Information about the mathematical representation used in a model or model configuration
    /// <see href="https://w3id.org/okn/o/sdm#Equation"></see></summary>
    let Equation = Namespaced_IRI.parse _namespace_name "Equation" |> NamespacedName

    /// <summary>
    /// Coordinate metadata of a region
    /// <see href="https://w3id.org/okn/o/sdm#GeoCoordinates"></see></summary>
    let GeoCoordinates =
        Namespaced_IRI.parse _namespace_name "GeoCoordinates" |> NamespacedName

    /// <summary>
    /// Shape or polygon of a region in a map
    /// <see href="https://w3id.org/okn/o/sdm#GeoShape"></see></summary>
    let GeoShape = Namespaced_IRI.parse _namespace_name "GeoShape" |> NamespacedName
    /// <summary>
    /// Class that represents the geospatial information associated with a model
    /// <see href="https://w3id.org/okn/o/sdm#Grid"></see></summary>
    let Grid = Namespaced_IRI.parse _namespace_name "Grid" |> NamespacedName

    /// <summary>
    /// A model based on empirical observations and theory.
    /// <see href="https://w3id.org/okn/o/sdm#HybridModel"></see></summary>
    let HybridModel =
        Namespaced_IRI.parse _namespace_name "HybridModel" |> NamespacedName

    /// <summary>
    /// Interference by a policy maker or modeler by modifying a variable or parameter of a model
    /// <see href="https://w3id.org/okn/o/sdm#Intervention"></see></summary>
    let Intervention =
        Namespaced_IRI.parse _namespace_name "Intervention" |> NamespacedName

    /// <summary>
    /// Class used to represent a category of a model (e.g., Hydrology, Agriculture, etc.)
    /// <see href="https://w3id.org/okn/o/sdm#ModelCategory"></see></summary>
    let ModelCategory =
        Namespaced_IRI.parse _namespace_name "ModelCategory" |> NamespacedName

    /// <summary>
    /// A model configuration is a way of exposing a particular functionality of a model.
    /// <see href="https://w3id.org/okn/o/sdm#ModelConfiguration"></see></summary>
    let ModelConfiguration =
        Namespaced_IRI.parse _namespace_name "ModelConfiguration" |> NamespacedName

    /// <summary>
    /// Setup of a particular model, that may represent a calibration or a configuration with a set of values for a specific region.
    /// <see href="https://w3id.org/okn/o/sdm#ModelConfigurationSetup"></see></summary>
    let ModelConfigurationSetup =
        Namespaced_IRI.parse _namespace_name "ModelConfigurationSetup" |> NamespacedName

    /// <summary>
    /// A grid that is based on a series if points (or a single point). Typically associated with point-based models
    /// <see href="https://w3id.org/okn/o/sdm#PointBasedGrid"></see></summary>
    let PointBasedGrid =
        Namespaced_IRI.parse _namespace_name "PointBasedGrid" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/okn/o/sdm#Process"></see>
    /// </summary>
    let Process = Namespaced_IRI.parse _namespace_name "Process" |> NamespacedName
    /// <summary>
    /// An area or division with some characteristics but not always fixed boundaries
    /// <see href="https://w3id.org/okn/o/sdm#Region"></see></summary>
    let Region = Namespaced_IRI.parse _namespace_name "Region" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/okn/o/sdm#SpatialResolution"></see>
    /// </summary>
    let SpatialResolution =
        Namespaced_IRI.parse _namespace_name "SpatialResolution" |> NamespacedName

    /// <summary>
    /// Grid that represents a 2D or 3D space
    /// <see href="https://w3id.org/okn/o/sdm#SpatiallyDistributedGrid"></see></summary>
    let SpatiallyDistributedGrid =
        Namespaced_IRI.parse _namespace_name "SpatiallyDistributedGrid" |> NamespacedName

    /// <summary>
    /// A model guided by mathematical equations that attempt to represent one or more natural processes.
    /// <see href="https://w3id.org/okn/o/sdm#Theory-GuidedModel"></see></summary>
    let ``Theory-GuidedModel`` =
        Namespaced_IRI.parse _namespace_name "Theory-GuidedModel" |> NamespacedName

    /// <summary>
    /// Time interval at which a model produces output. For example, a model may produce outputs for every simulated day, hour, etc.
    /// <see href="https://w3id.org/okn/o/sdm#TimeInterval"></see></summary>
    let TimeInterval =
        Namespaced_IRI.parse _namespace_name "TimeInterval" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/okn/o/sdm#box"></see>
    /// </summary>
    let box = Namespaced_IRI.parse _namespace_name "box" |> NamespacedName

    /// <summary>
    /// Variable that was calibrated in this particular model configuration calibration
    /// <see href="https://w3id.org/okn/o/sdm#calibratedVariable"></see></summary>
    let calibratedVariable =
        Namespaced_IRI.parse _namespace_name "calibratedVariable" |> NamespacedName

    /// <summary>
    /// Property that represents the temporal interval used to calibrate a model
    /// <see href="https://w3id.org/okn/o/sdm#calibrationInterval"></see></summary>
    let calibrationInterval =
        Namespaced_IRI.parse _namespace_name "calibrationInterval" |> NamespacedName

    /// <summary>
    /// Calibration method used for a particular model configuration or setup
    /// <see href="https://w3id.org/okn/o/sdm#calibrationMethod"></see></summary>
    let calibrationMethod =
        Namespaced_IRI.parse _namespace_name "calibrationMethod" |> NamespacedName

    /// <summary>
    /// Variable for which the model was calibrated for. For example, in a hydrology model one calibrate the predicted river width by varying hydrologic conductivity
    /// <see href="https://w3id.org/okn/o/sdm#calibrationTargetVariable"></see></summary>
    let calibrationTargetVariable =
        Namespaced_IRI.parse _namespace_name "calibrationTargetVariable" |> NamespacedName

    /// <summary>
    /// Elevation of a location (WGS84)
    /// <see href="https://w3id.org/okn/o/sdm#elevation"></see></summary>
    let elevation = Namespaced_IRI.parse _namespace_name "elevation" |> NamespacedName
    /// <summary>
    /// Specific coordinates or shape associated with a region
    /// <see href="https://w3id.org/okn/o/sdm#geo"></see></summary>
    let geo = Namespaced_IRI.parse _namespace_name "geo" |> NamespacedName

    /// <summary>
    /// Diagram associated to a model configuration
    /// <see href="https://w3id.org/okn/o/sdm#hasCausalDiagram"></see></summary>
    let hasCausalDiagram =
        Namespaced_IRI.parse _namespace_name "hasCausalDiagram" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/okn/o/sdm#hasConstraint"></see>
    /// </summary>
    let hasConstraint =
        Namespaced_IRI.parse _namespace_name "hasConstraint" |> NamespacedName

    /// <summary>
    /// Coordinate system used in a grid
    /// <see href="https://w3id.org/okn/o/sdm#hasCoordinateSystem"></see></summary>
    let hasCoordinateSystem =
        Namespaced_IRI.parse _namespace_name "hasCoordinateSystem" |> NamespacedName

    /// <summary>
    /// Property that links a causal diagram with its constituent nodes
    /// <see href="https://w3id.org/okn/o/sdm#hasDiagramPart"></see></summary>
    let hasDiagramPart =
        Namespaced_IRI.parse _namespace_name "hasDiagramPart" |> NamespacedName

    /// <summary>
    /// Dimension of the grid (2D, 3D)
    /// <see href="https://w3id.org/okn/o/sdm#hasDimension"></see></summary>
    let hasDimension =
        Namespaced_IRI.parse _namespace_name "hasDimension" |> NamespacedName

    /// <summary>
    /// Equations used in the model
    /// <see href="https://w3id.org/okn/o/sdm#hasEquation"></see></summary>
    let hasEquation =
        Namespaced_IRI.parse _namespace_name "hasEquation" |> NamespacedName

    /// <summary>
    /// Diagram used to explain the behavior of the model
    /// <see href="https://w3id.org/okn/o/sdm#hasExplanationDiagram"></see></summary>
    let hasExplanationDiagram =
        Namespaced_IRI.parse _namespace_name "hasExplanationDiagram" |> NamespacedName

    /// <summary>
    /// Grid information about the model
    /// <see href="https://w3id.org/okn/o/sdm#hasGrid"></see></summary>
    let hasGrid = Namespaced_IRI.parse _namespace_name "hasGrid" |> NamespacedName

    /// <summary>
    /// Variable that is used as input for this model
    /// <see href="https://w3id.org/okn/o/sdm#hasInputVariable"></see></summary>
    let hasInputVariable =
        Namespaced_IRI.parse _namespace_name "hasInputVariable" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/okn/o/sdm#hasMaximumValue"></see>
    /// </summary>
    let hasMaximumValue =
        Namespaced_IRI.parse _namespace_name "hasMaximumValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/okn/o/sdm#hasMinimumValue"></see>
    /// </summary>
    let hasMinimumValue =
        Namespaced_IRI.parse _namespace_name "hasMinimumValue" |> NamespacedName

    /// <summary>
    /// Category associated with a model (e.g., Hydrology, etc.)
    /// <see href="https://w3id.org/okn/o/sdm#hasModelCategory"></see></summary>
    let hasModelCategory =
        Namespaced_IRI.parse _namespace_name "hasModelCategory" |> NamespacedName

    /// <summary>
    /// Sample result table associated with a model configuration
    /// <see href="https://w3id.org/okn/o/sdm#hasModelResultTable"></see></summary>
    let hasModelResultTable =
        Namespaced_IRI.parse _namespace_name "hasModelResultTable" |> NamespacedName

    /// <summary>
    /// Time interval used in the model configuration
    /// <see href="https://w3id.org/okn/o/sdm#hasOutputTimeInterval"></see></summary>
    let hasOutputTimeInterval =
        Namespaced_IRI.parse _namespace_name "hasOutputTimeInterval" |> NamespacedName

    /// <summary>
    /// Variable that is used as output for this model
    /// <see href="https://w3id.org/okn/o/sdm#hasOutputVariable"></see></summary>
    let hasOutputVariable =
        Namespaced_IRI.parse _namespace_name "hasOutputVariable" |> NamespacedName

    /// <summary>
    /// Property that indicates which physical processes (if any) are associated with a model
    /// <see href="https://w3id.org/okn/o/sdm#hasProcess"></see></summary>
    let hasProcess = Namespaced_IRI.parse _namespace_name "hasProcess" |> NamespacedName
    /// <summary>
    /// Property linking a region to a model configuration/calibration. This property implies that the described model configuration is prepared to execute in that target region
    /// <see href="https://w3id.org/okn/o/sdm#hasRegion"></see></summary>
    let hasRegion = Namespaced_IRI.parse _namespace_name "hasRegion" |> NamespacedName
    /// <summary>
    /// Grids may be: rectangular, triangular, hexagonal, hybrid, unstructured, block structure, etc.
    /// <see href="https://w3id.org/okn/o/sdm#hasShape"></see></summary>
    let hasShape = Namespaced_IRI.parse _namespace_name "hasShape" |> NamespacedName

    /// <summary>
    /// Spatial resolution of a grid (e.g., 50m)
    /// <see href="https://w3id.org/okn/o/sdm#hasSpatialResolution"></see></summary>
    let hasSpatialResolution =
        Namespaced_IRI.parse _namespace_name "hasSpatialResolution" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/okn/o/sdm#hasVariable"></see>
    /// </summary>
    let hasVariable =
        Namespaced_IRI.parse _namespace_name "hasVariable" |> NamespacedName

    /// <summary>
    /// Property that captures if a physical process influences another process
    /// <see href="https://w3id.org/okn/o/sdm#influences"></see></summary>
    let influences = Namespaced_IRI.parse _namespace_name "influences" |> NamespacedName

    /// <summary>
    /// Unit used in an interval (e.g., month)
    /// <see href="https://w3id.org/okn/o/sdm#intervalUnit"></see></summary>
    let intervalUnit =
        Namespaced_IRI.parse _namespace_name "intervalUnit" |> NamespacedName

    /// <summary>
    /// Value used in the time interval of a model (e.g., 1 month, 5 days, 'harvest cycle')
    /// <see href="https://w3id.org/okn/o/sdm#intervalValue"></see></summary>
    let intervalValue =
        Namespaced_IRI.parse _namespace_name "intervalValue" |> NamespacedName

    /// <summary>
    /// Latitude (coordinates) of a location (WGS84)
    /// <see href="https://w3id.org/okn/o/sdm#latitude"></see></summary>
    let latitude = Namespaced_IRI.parse _namespace_name "latitude" |> NamespacedName

    /// <summary>
    /// Known restrictions (i.e. cases where the model is known not to be reliable or shouldn't be used)
    /// <see href="https://w3id.org/okn/o/sdm#limitations"></see></summary>
    let limitations =
        Namespaced_IRI.parse _namespace_name "limitations" |> NamespacedName

    /// <summary>
    /// Longitude (coordinates) of a location (WGS84)
    /// <see href="https://w3id.org/okn/o/sdm#longitude"></see></summary>
    let longitude = Namespaced_IRI.parse _namespace_name "longitude" |> NamespacedName

    /// <summary>
    /// Property that indicates how have the parameters assigned in a model configuration (e.g., using an expert guess, by using calibration, etc.)
    /// <see href="https://w3id.org/okn/o/sdm#parameterAssignmentMethod"></see></summary>
    let parameterAssignmentMethod =
        Namespaced_IRI.parse _namespace_name "parameterAssignmentMethod" |> NamespacedName

    /// <summary>
    /// Were there any simplifications made to processes to make the model more efficient
    /// <see href="https://w3id.org/okn/o/sdm#parameterization"></see></summary>
    let parameterization =
        Namespaced_IRI.parse _namespace_name "parameterization" |> NamespacedName

    /// <summary>
    /// Indicates the parent category of a given category
    /// <see href="https://w3id.org/okn/o/sdm#parentCategory"></see></summary>
    let parentCategory =
        Namespaced_IRI.parse _namespace_name "parentCategory" |> NamespacedName

    /// <summary>
    /// Indicates whether a region is part of another region
    /// <see href="https://w3id.org/okn/o/sdm#partOf"></see></summary>
    let partOf = Namespaced_IRI.parse _namespace_name "partOf" |> NamespacedName

    /// <summary>
    /// Property that links a parameter to the intervention it is relevant for.
    /// <see href="https://w3id.org/okn/o/sdm#relevantForIntervention"></see></summary>
    let relevantForIntervention =
        Namespaced_IRI.parse _namespace_name "relevantForIntervention" |> NamespacedName

    /// <summary>
    /// An estimate of the time required to run example codes or other known configurations
    /// <see href="https://w3id.org/okn/o/sdm#runtimeEstimation"></see></summary>
    let runtimeEstimation =
        Namespaced_IRI.parse _namespace_name "runtimeEstimation" |> NamespacedName

    /// <summary>
    /// What is the theory behind the processes described in the model
    /// <see href="https://w3id.org/okn/o/sdm#theoreticalBasis"></see></summary>
    let theoreticalBasis =
        Namespaced_IRI.parse _namespace_name "theoreticalBasis" |> NamespacedName

    /// <summary>
    /// Property that describes which models are used by a coupled model
    /// <see href="https://w3id.org/okn/o/sdm#usesModel"></see></summary>
    let usesModel = Namespaced_IRI.parse _namespace_name "usesModel" |> NamespacedName
    /// <summary>
    /// Date until which the calibration of a model is valid. For example, a trained model with data from 2005-2010 may only be valid for predictions until 2015.
    /// <see href="https://w3id.org/okn/o/sdm#validUntil"></see></summary>
    let validUntil = Namespaced_IRI.parse _namespace_name "validUntil" |> NamespacedName
