namespace https.w3id.org.okn.o.sdm.hash

open DoxAletheia

module sdom =
    let _namespace_name = "https://w3id.org/okn/o/sdm#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/okn/o/sdm#Category"></see>
    /// </summary>
    let Category = _prefix "Category"
    /// <summary>
    /// Diagram information with the processes and variables associated with a model configuration
    /// <see href="https://w3id.org/okn/o/sdm#CausalDiagram"></see></summary>
    let CausalDiagram = _prefix "CausalDiagram"
    /// <summary>
    ///   <see href="https://w3id.org/okn/o/sdm#Constraint"></see>
    /// </summary>
    let Constraint = _prefix "Constraint"
    /// <summary>
    /// Model that incorporates the coupling of two or more existing models
    /// <see href="https://w3id.org/okn/o/sdm#CoupledModel"></see></summary>
    let CoupledModel = _prefix "CoupledModel"
    /// <summary>
    /// A mathematical description of a process (e.g., hydrological, agricultural, social, etc.)
    /// <see href="https://w3id.org/okn/o/sdm#Model"></see></summary>
    let Model = _prefix "Model"
    /// <summary>
    /// Model based on observations.
    /// <see href="https://w3id.org/okn/o/sdm#EmpiricalModel"></see></summary>
    let EmpiricalModel = _prefix "EmpiricalModel"
    /// <summary>
    /// Type of models that emulates the behavior of another model. For example, an emulator can be a machine learning model trained on the output runs of a hydrology model
    /// <see href="https://w3id.org/okn/o/sdm#Emulator"></see></summary>
    let Emulator = _prefix "Emulator"
    /// <summary>
    /// Information about the mathematical representation used in a model or model configuration
    /// <see href="https://w3id.org/okn/o/sdm#Equation"></see></summary>
    let Equation = _prefix "Equation"
    /// <summary>
    /// Coordinate metadata of a region
    /// <see href="https://w3id.org/okn/o/sdm#GeoCoordinates"></see></summary>
    let GeoCoordinates = _prefix "GeoCoordinates"
    /// <summary>
    /// Shape or polygon of a region in a map
    /// <see href="https://w3id.org/okn/o/sdm#GeoShape"></see></summary>
    let GeoShape = _prefix "GeoShape"
    /// <summary>
    /// Class that represents the geospatial information associated with a model
    /// <see href="https://w3id.org/okn/o/sdm#Grid"></see></summary>
    let Grid = _prefix "Grid"
    /// <summary>
    /// A model based on empirical observations and theory.
    /// <see href="https://w3id.org/okn/o/sdm#HybridModel"></see></summary>
    let HybridModel = _prefix "HybridModel"
    /// <summary>
    /// Interference by a policy maker or modeler by modifying a variable or parameter of a model
    /// <see href="https://w3id.org/okn/o/sdm#Intervention"></see></summary>
    let Intervention = _prefix "Intervention"
    /// <summary>
    /// Class used to represent a category of a model (e.g., Hydrology, Agriculture, etc.)
    /// <see href="https://w3id.org/okn/o/sdm#ModelCategory"></see></summary>
    let ModelCategory = _prefix "ModelCategory"
    /// <summary>
    /// A model configuration is a way of exposing a particular functionality of a model.
    /// <see href="https://w3id.org/okn/o/sdm#ModelConfiguration"></see></summary>
    let ModelConfiguration = _prefix "ModelConfiguration"
    /// <summary>
    /// Setup of a particular model, that may represent a calibration or a configuration with a set of values for a specific region.
    /// <see href="https://w3id.org/okn/o/sdm#ModelConfigurationSetup"></see></summary>
    let ModelConfigurationSetup = _prefix "ModelConfigurationSetup"
    /// <summary>
    /// A grid that is based on a series if points (or a single point). Typically associated with point-based models
    /// <see href="https://w3id.org/okn/o/sdm#PointBasedGrid"></see></summary>
    let PointBasedGrid = _prefix "PointBasedGrid"
    /// <summary>
    ///   <see href="https://w3id.org/okn/o/sdm#Process"></see>
    /// </summary>
    let Process = _prefix "Process"
    /// <summary>
    /// An area or division with some characteristics but not always fixed boundaries
    /// <see href="https://w3id.org/okn/o/sdm#Region"></see></summary>
    let Region = _prefix "Region"
    /// <summary>
    ///   <see href="https://w3id.org/okn/o/sdm#SpatialResolution"></see>
    /// </summary>
    let SpatialResolution = _prefix "SpatialResolution"
    /// <summary>
    /// Grid that represents a 2D or 3D space
    /// <see href="https://w3id.org/okn/o/sdm#SpatiallyDistributedGrid"></see></summary>
    let SpatiallyDistributedGrid = _prefix "SpatiallyDistributedGrid"
    /// <summary>
    /// A model guided by mathematical equations that attempt to represent one or more natural processes.
    /// <see href="https://w3id.org/okn/o/sdm#Theory-GuidedModel"></see></summary>
    let ``Theory-GuidedModel`` = _prefix "Theory-GuidedModel"
    /// <summary>
    /// Time interval at which a model produces output. For example, a model may produce outputs for every simulated day, hour, etc.
    /// <see href="https://w3id.org/okn/o/sdm#TimeInterval"></see></summary>
    let TimeInterval = _prefix "TimeInterval"
    /// <summary>
    ///   <see href="https://w3id.org/okn/o/sdm#box"></see>
    /// </summary>
    let box = _prefix "box"
    /// <summary>
    /// Variable that was calibrated in this particular model configuration calibration
    /// <see href="https://w3id.org/okn/o/sdm#calibratedVariable"></see></summary>
    let calibratedVariable = _prefix "calibratedVariable"
    /// <summary>
    /// Property that represents the temporal interval used to calibrate a model
    /// <see href="https://w3id.org/okn/o/sdm#calibrationInterval"></see></summary>
    let calibrationInterval = _prefix "calibrationInterval"
    /// <summary>
    /// Calibration method used for a particular model configuration or setup
    /// <see href="https://w3id.org/okn/o/sdm#calibrationMethod"></see></summary>
    let calibrationMethod = _prefix "calibrationMethod"
    /// <summary>
    /// Variable for which the model was calibrated for. For example, in a hydrology model one calibrate the predicted river width by varying hydrologic conductivity
    /// <see href="https://w3id.org/okn/o/sdm#calibrationTargetVariable"></see></summary>
    let calibrationTargetVariable = _prefix "calibrationTargetVariable"
    /// <summary>
    /// Elevation of a location (WGS84)
    /// <see href="https://w3id.org/okn/o/sdm#elevation"></see></summary>
    let elevation = _prefix "elevation"
    /// <summary>
    /// Specific coordinates or shape associated with a region
    /// <see href="https://w3id.org/okn/o/sdm#geo"></see></summary>
    let geo = _prefix "geo"
    /// <summary>
    /// Diagram associated to a model configuration
    /// <see href="https://w3id.org/okn/o/sdm#hasCausalDiagram"></see></summary>
    let hasCausalDiagram = _prefix "hasCausalDiagram"
    /// <summary>
    ///   <see href="https://w3id.org/okn/o/sdm#hasConstraint"></see>
    /// </summary>
    let hasConstraint = _prefix "hasConstraint"
    /// <summary>
    /// Coordinate system used in a grid
    /// <see href="https://w3id.org/okn/o/sdm#hasCoordinateSystem"></see></summary>
    let hasCoordinateSystem = _prefix "hasCoordinateSystem"
    /// <summary>
    /// Property that links a causal diagram with its constituent nodes
    /// <see href="https://w3id.org/okn/o/sdm#hasDiagramPart"></see></summary>
    let hasDiagramPart = _prefix "hasDiagramPart"
    /// <summary>
    /// Dimension of the grid (2D, 3D)
    /// <see href="https://w3id.org/okn/o/sdm#hasDimension"></see></summary>
    let hasDimension = _prefix "hasDimension"
    /// <summary>
    /// Equations used in the model
    /// <see href="https://w3id.org/okn/o/sdm#hasEquation"></see></summary>
    let hasEquation = _prefix "hasEquation"
    /// <summary>
    /// Diagram used to explain the behavior of the model
    /// <see href="https://w3id.org/okn/o/sdm#hasExplanationDiagram"></see></summary>
    let hasExplanationDiagram = _prefix "hasExplanationDiagram"
    /// <summary>
    /// Grid information about the model
    /// <see href="https://w3id.org/okn/o/sdm#hasGrid"></see></summary>
    let hasGrid = _prefix "hasGrid"
    /// <summary>
    /// Variable that is used as input for this model
    /// <see href="https://w3id.org/okn/o/sdm#hasInputVariable"></see></summary>
    let hasInputVariable = _prefix "hasInputVariable"
    /// <summary>
    ///   <see href="https://w3id.org/okn/o/sdm#hasMaximumValue"></see>
    /// </summary>
    let hasMaximumValue = _prefix "hasMaximumValue"
    /// <summary>
    ///   <see href="https://w3id.org/okn/o/sdm#hasMinimumValue"></see>
    /// </summary>
    let hasMinimumValue = _prefix "hasMinimumValue"
    /// <summary>
    /// Category associated with a model (e.g., Hydrology, etc.)
    /// <see href="https://w3id.org/okn/o/sdm#hasModelCategory"></see></summary>
    let hasModelCategory = _prefix "hasModelCategory"
    /// <summary>
    /// Sample result table associated with a model configuration
    /// <see href="https://w3id.org/okn/o/sdm#hasModelResultTable"></see></summary>
    let hasModelResultTable = _prefix "hasModelResultTable"
    /// <summary>
    /// Time interval used in the model configuration
    /// <see href="https://w3id.org/okn/o/sdm#hasOutputTimeInterval"></see></summary>
    let hasOutputTimeInterval = _prefix "hasOutputTimeInterval"
    /// <summary>
    /// Variable that is used as output for this model
    /// <see href="https://w3id.org/okn/o/sdm#hasOutputVariable"></see></summary>
    let hasOutputVariable = _prefix "hasOutputVariable"
    /// <summary>
    /// Property that indicates which physical processes (if any) are associated with a model
    /// <see href="https://w3id.org/okn/o/sdm#hasProcess"></see></summary>
    let hasProcess = _prefix "hasProcess"
    /// <summary>
    /// Property linking a region to a model configuration/calibration. This property implies that the described model configuration is prepared to execute in that target region
    /// <see href="https://w3id.org/okn/o/sdm#hasRegion"></see></summary>
    let hasRegion = _prefix "hasRegion"
    /// <summary>
    /// Grids may be: rectangular, triangular, hexagonal, hybrid, unstructured, block structure, etc.
    /// <see href="https://w3id.org/okn/o/sdm#hasShape"></see></summary>
    let hasShape = _prefix "hasShape"
    /// <summary>
    /// Spatial resolution of a grid (e.g., 50m)
    /// <see href="https://w3id.org/okn/o/sdm#hasSpatialResolution"></see></summary>
    let hasSpatialResolution = _prefix "hasSpatialResolution"
    /// <summary>
    ///   <see href="https://w3id.org/okn/o/sdm#hasVariable"></see>
    /// </summary>
    let hasVariable = _prefix "hasVariable"
    /// <summary>
    /// Property that captures if a physical process influences another process
    /// <see href="https://w3id.org/okn/o/sdm#influences"></see></summary>
    let influences = _prefix "influences"
    /// <summary>
    /// Unit used in an interval (e.g., month)
    /// <see href="https://w3id.org/okn/o/sdm#intervalUnit"></see></summary>
    let intervalUnit = _prefix "intervalUnit"
    /// <summary>
    /// Value used in the time interval of a model (e.g., 1 month, 5 days, 'harvest cycle')
    /// <see href="https://w3id.org/okn/o/sdm#intervalValue"></see></summary>
    let intervalValue = _prefix "intervalValue"
    /// <summary>
    /// Latitude (coordinates) of a location (WGS84)
    /// <see href="https://w3id.org/okn/o/sdm#latitude"></see></summary>
    let latitude = _prefix "latitude"
    /// <summary>
    /// Known restrictions (i.e. cases where the model is known not to be reliable or shouldn't be used)
    /// <see href="https://w3id.org/okn/o/sdm#limitations"></see></summary>
    let limitations = _prefix "limitations"
    /// <summary>
    /// Longitude (coordinates) of a location (WGS84)
    /// <see href="https://w3id.org/okn/o/sdm#longitude"></see></summary>
    let longitude = _prefix "longitude"
    /// <summary>
    /// Property that indicates how have the parameters assigned in a model configuration (e.g., using an expert guess, by using calibration, etc.)
    /// <see href="https://w3id.org/okn/o/sdm#parameterAssignmentMethod"></see></summary>
    let parameterAssignmentMethod = _prefix "parameterAssignmentMethod"
    /// <summary>
    /// Were there any simplifications made to processes to make the model more efficient
    /// <see href="https://w3id.org/okn/o/sdm#parameterization"></see></summary>
    let parameterization = _prefix "parameterization"
    /// <summary>
    /// Indicates the parent category of a given category
    /// <see href="https://w3id.org/okn/o/sdm#parentCategory"></see></summary>
    let parentCategory = _prefix "parentCategory"
    /// <summary>
    /// Indicates whether a region is part of another region
    /// <see href="https://w3id.org/okn/o/sdm#partOf"></see></summary>
    let partOf = _prefix "partOf"
    /// <summary>
    /// Property that links a parameter to the intervention it is relevant for.
    /// <see href="https://w3id.org/okn/o/sdm#relevantForIntervention"></see></summary>
    let relevantForIntervention = _prefix "relevantForIntervention"
    /// <summary>
    /// An estimate of the time required to run example codes or other known configurations
    /// <see href="https://w3id.org/okn/o/sdm#runtimeEstimation"></see></summary>
    let runtimeEstimation = _prefix "runtimeEstimation"
    /// <summary>
    /// What is the theory behind the processes described in the model
    /// <see href="https://w3id.org/okn/o/sdm#theoreticalBasis"></see></summary>
    let theoreticalBasis = _prefix "theoreticalBasis"
    /// <summary>
    /// Property that describes which models are used by a coupled model
    /// <see href="https://w3id.org/okn/o/sdm#usesModel"></see></summary>
    let usesModel = _prefix "usesModel"
    /// <summary>
    /// Date until which the calibration of a model is valid. For example, a trained model with data from 2005-2010 may only be valid for predictions until 2015.
    /// <see href="https://w3id.org/okn/o/sdm#validUntil"></see></summary>
    let validUntil = _prefix "validUntil"
