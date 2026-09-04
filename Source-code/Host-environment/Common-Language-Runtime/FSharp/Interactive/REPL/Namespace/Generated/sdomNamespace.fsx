#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module sdom =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/okn/o/sdm#" "sdom"
    let _namespaceIri = _prefixId.prefix ""
    let Category = _prefixId.prefix "Category"
    /// <summary>
    ///   <para>rdfs:label : Causal Diagram</para>
    ///   <para>rdfs:comment : Diagram information with the processes and variables associated with a model configuration</para>
    ///   <a href="https://w3id.org/okn/o/sdm#CausalDiagram">sdom:CausalDiagram</a>
    /// </summary>
    let CausalDiagram = _prefixId.prefix "CausalDiagram"
    let Constraint = _prefixId.prefix "Constraint"
    /// <summary>
    ///   <para>rdfs:label : Coupled model</para>
    ///   <para>rdfs:comment : Model that incorporates the coupling of two or more existing models</para>
    ///   <a href="https://w3id.org/okn/o/sdm#CoupledModel">sdom:CoupledModel</a>
    /// </summary>
    let CoupledModel = _prefixId.prefix "CoupledModel"
    /// <summary>
    ///   <para>rdfs:label : Empirical model</para>
    ///   <para>rdfs:comment : Model based on observations.</para>
    ///   <a href="https://w3id.org/okn/o/sdm#EmpiricalModel">sdom:EmpiricalModel</a>
    /// </summary>
    let EmpiricalModel = _prefixId.prefix "EmpiricalModel"
    /// <summary>
    ///   <para>rdfs:label : Emulator</para>
    ///   <para>rdfs:comment : Type of models that emulates the behavior of another model. For example, an emulator can be a machine learning model trained on the output runs of a hydrology model</para>
    ///   <a href="https://w3id.org/okn/o/sdm#Emulator">sdom:Emulator</a>
    /// </summary>
    let Emulator = _prefixId.prefix "Emulator"
    /// <summary>
    ///   <para>rdfs:label : Equation</para>
    ///   <para>rdfs:comment : Information about the mathematical representation used in a model or model configuration</para>
    ///   <a href="https://w3id.org/okn/o/sdm#Equation">sdom:Equation</a>
    /// </summary>
    let Equation = _prefixId.prefix "Equation"
    /// <summary>
    ///   <para>rdfs:label : GeoCoordinates</para>
    ///   <para>rdfs:comment : Coordinate metadata of a region</para>
    ///   <a href="https://w3id.org/okn/o/sdm#GeoCoordinates">sdom:GeoCoordinates</a>
    /// </summary>
    let GeoCoordinates = _prefixId.prefix "GeoCoordinates"
    /// <summary>
    ///   <para>rdfs:label : GeoShape</para>
    ///   <para>rdfs:comment : Shape or polygon of a region in a map</para>
    ///   <a href="https://w3id.org/okn/o/sdm#GeoShape">sdom:GeoShape</a>
    /// </summary>
    let GeoShape = _prefixId.prefix "GeoShape"
    /// <summary>
    ///   <para>rdfs:label : Grid</para>
    ///   <para>rdfs:comment : Class that represents the geospatial information associated with a model^^xsd:string</para>
    ///   <a href="https://w3id.org/okn/o/sdm#Grid">sdom:Grid</a>
    /// </summary>
    let Grid = _prefixId.prefix "Grid"
    /// <summary>
    ///   <para>rdfs:label : Hybrid model</para>
    ///   <para>rdfs:comment : A model based on empirical observations and theory.</para>
    ///   <a href="https://w3id.org/okn/o/sdm#HybridModel">sdom:HybridModel</a>
    /// </summary>
    let HybridModel = _prefixId.prefix "HybridModel"
    /// <summary>
    ///   <para>rdfs:label : Intervention</para>
    ///   <para>rdfs:comment : Interference by a policy maker or modeler by modifying a variable or parameter of a model</para>
    ///   <a href="https://w3id.org/okn/o/sdm#Intervention">sdom:Intervention</a>
    /// </summary>
    let Intervention = _prefixId.prefix "Intervention"
    /// <summary>
    ///   <para>rdfs:label : Model</para>
    ///   <para>rdfs:comment : A mathematical description of a process (e.g., hydrological, agricultural, social, etc.)</para>
    ///   <a href="https://w3id.org/okn/o/sdm#Model">sdom:Model</a>
    /// </summary>
    let Model = _prefixId.prefix "Model"
    /// <summary>
    ///   <para>rdfs:label : Model category</para>
    ///   <para>rdfs:comment : Class used to represent a category of a model (e.g., Hydrology, Agriculture, etc.)</para>
    ///   <a href="https://w3id.org/okn/o/sdm#ModelCategory">sdom:ModelCategory</a>
    /// </summary>
    let ModelCategory = _prefixId.prefix "ModelCategory"
    /// <summary>
    ///   <para>rdfs:label : Model configuration</para>
    ///   <para>rdfs:comment : A model configuration is a way of exposing a particular functionality of a model.</para>
    ///   <a href="https://w3id.org/okn/o/sdm#ModelConfiguration">sdom:ModelConfiguration</a>
    /// </summary>
    let ModelConfiguration = _prefixId.prefix "ModelConfiguration"
    /// <summary>
    ///   <para>rdfs:label : Model configuration setup</para>
    ///   <para>rdfs:comment : Setup of a particular model, that may represent a calibration or a configuration with a set of values for a specific region.</para>
    ///   <a href="https://w3id.org/okn/o/sdm#ModelConfigurationSetup">sdom:ModelConfigurationSetup</a>
    /// </summary>
    let ModelConfigurationSetup = _prefixId.prefix "ModelConfigurationSetup"
    /// <summary>
    ///   <para>rdfs:label : Point Based Grid</para>
    ///   <para>rdfs:comment : A grid that is based on a series if points (or a single point). Typically associated with point-based models</para>
    ///   <a href="https://w3id.org/okn/o/sdm#PointBasedGrid">sdom:PointBasedGrid</a>
    /// </summary>
    let PointBasedGrid = _prefixId.prefix "PointBasedGrid"
    let Process = _prefixId.prefix "Process"
    /// <summary>
    ///   <para>rdfs:label : Region</para>
    ///   <para>rdfs:comment : An area or division with some characteristics but not always fixed boundaries</para>
    ///   <a href="https://w3id.org/okn/o/sdm#Region">sdom:Region</a>
    /// </summary>
    let Region = _prefixId.prefix "Region"
    let SpatialResolution = _prefixId.prefix "SpatialResolution"
    /// <summary>
    ///   <para>rdfs:label : Spatially Distributed Grid</para>
    ///   <para>rdfs:comment : Grid that represents a 2D or 3D space</para>
    ///   <a href="https://w3id.org/okn/o/sdm#SpatiallyDistributedGrid">sdom:SpatiallyDistributedGrid</a>
    /// </summary>
    let SpatiallyDistributedGrid = _prefixId.prefix "SpatiallyDistributedGrid"
    /// <summary>
    ///   <para>rdfs:label : Theory guided model</para>
    ///   <para>rdfs:comment : A model guided by mathematical equations that attempt to represent one or more natural processes.</para>
    ///   <a href="https://w3id.org/okn/o/sdm#Theory-GuidedModel">sdom:Theory-GuidedModel</a>
    /// </summary>
    let Theory_GuidedModel = _prefixId.prefix "Theory-GuidedModel"
    /// <summary>
    ///   <para>rdfs:label : Time Interval</para>
    ///   <para>rdfs:comment : Time interval at which a model produces output. For example, a model may produce outputs for every simulated day, hour, etc.</para>
    ///   <a href="https://w3id.org/okn/o/sdm#TimeInterval">sdom:TimeInterval</a>
    /// </summary>
    let TimeInterval = _prefixId.prefix "TimeInterval"
    let box = _prefixId.prefix "box"
    /// <summary>
    ///   <para>rdfs:label : calibrated variable</para>
    ///   <para>rdfs:comment : Variable that was calibrated in this particular model configuration calibration</para>
    ///   <a href="https://w3id.org/okn/o/sdm#calibratedVariable">sdom:calibratedVariable</a>
    /// </summary>
    let calibratedVariable = _prefixId.prefix "calibratedVariable"
    /// <summary>
    ///   <para>rdfs:label : calibration interval</para>
    ///   <para>rdfs:comment : Property that represents the temporal interval used to calibrate a model</para>
    ///   <a href="https://w3id.org/okn/o/sdm#calibrationInterval">sdom:calibrationInterval</a>
    /// </summary>
    let calibrationInterval = _prefixId.prefix "calibrationInterval"
    /// <summary>
    ///   <para>rdfs:label : calibration method</para>
    ///   <para>rdfs:comment : Calibration method used for a particular model configuration or setup</para>
    ///   <a href="https://w3id.org/okn/o/sdm#calibrationMethod">sdom:calibrationMethod</a>
    /// </summary>
    let calibrationMethod = _prefixId.prefix "calibrationMethod"
    /// <summary>
    ///   <para>rdfs:label : calibration target variable</para>
    ///   <para>rdfs:comment : Variable for which the model was calibrated for. For example, in a hydrology model one calibrate the predicted river width by varying hydrologic conductivity</para>
    ///   <a href="https://w3id.org/okn/o/sdm#calibrationTargetVariable">sdom:calibrationTargetVariable</a>
    /// </summary>
    let calibrationTargetVariable = _prefixId.prefix "calibrationTargetVariable"
    /// <summary>
    ///   <para>rdfs:label : elevation</para>
    ///   <para>rdfs:comment : Elevation of a location (WGS84)</para>
    ///   <a href="https://w3id.org/okn/o/sdm#elevation">sdom:elevation</a>
    /// </summary>
    let elevation = _prefixId.prefix "elevation"
    /// <summary>
    ///   <para>rdfs:label : geo</para>
    ///   <para>rdfs:comment : Specific coordinates or shape associated with a region</para>
    ///   <a href="https://w3id.org/okn/o/sdm#geo">sdom:geo</a>
    /// </summary>
    let geo = _prefixId.prefix "geo"
    /// <summary>
    ///   <para>rdfs:label : has causal diagram</para>
    ///   <para>rdfs:comment : Diagram associated to a model configuration</para>
    ///   <a href="https://w3id.org/okn/o/sdm#hasCausalDiagram">sdom:hasCausalDiagram</a>
    /// </summary>
    let hasCausalDiagram = _prefixId.prefix "hasCausalDiagram"
    let hasConstraint = _prefixId.prefix "hasConstraint"
    /// <summary>
    ///   <para>rdfs:label : has coordinate system</para>
    ///   <para>rdfs:comment : Coordinate system used in a grid</para>
    ///   <a href="https://w3id.org/okn/o/sdm#hasCoordinateSystem">sdom:hasCoordinateSystem</a>
    /// </summary>
    let hasCoordinateSystem = _prefixId.prefix "hasCoordinateSystem"
    /// <summary>
    ///   <para>rdfs:label : has diagram part</para>
    ///   <para>rdfs:comment : Property that links a causal diagram with its constituent nodes^^xsd:string</para>
    ///   <a href="https://w3id.org/okn/o/sdm#hasDiagramPart">sdom:hasDiagramPart</a>
    /// </summary>
    let hasDiagramPart = _prefixId.prefix "hasDiagramPart"
    /// <summary>
    ///   <para>rdfs:label : has dimension</para>
    ///   <para>rdfs:comment : Dimension of the grid (2D, 3D)</para>
    ///   <a href="https://w3id.org/okn/o/sdm#hasDimension">sdom:hasDimension</a>
    /// </summary>
    let hasDimension = _prefixId.prefix "hasDimension"
    /// <summary>
    ///   <para>rdfs:label : has equation</para>
    ///   <para>rdfs:comment : Equations used in the model</para>
    ///   <a href="https://w3id.org/okn/o/sdm#hasEquation">sdom:hasEquation</a>
    /// </summary>
    let hasEquation = _prefixId.prefix "hasEquation"
    /// <summary>
    ///   <para>rdfs:label : has explanation diagram</para>
    ///   <para>rdfs:comment : Diagram used to explain the behavior of the model</para>
    ///   <a href="https://w3id.org/okn/o/sdm#hasExplanationDiagram">sdom:hasExplanationDiagram</a>
    /// </summary>
    let hasExplanationDiagram = _prefixId.prefix "hasExplanationDiagram"
    /// <summary>
    ///   <para>rdfs:label : has grid</para>
    ///   <para>rdfs:comment : Grid information about the model</para>
    ///   <a href="https://w3id.org/okn/o/sdm#hasGrid">sdom:hasGrid</a>
    /// </summary>
    let hasGrid = _prefixId.prefix "hasGrid"
    /// <summary>
    ///   <para>rdfs:label : has input variable</para>
    ///   <para>rdfs:comment : Variable that is used as input for this model</para>
    ///   <a href="https://w3id.org/okn/o/sdm#hasInputVariable">sdom:hasInputVariable</a>
    /// </summary>
    let hasInputVariable = _prefixId.prefix "hasInputVariable"
    let hasMaximumValue = _prefixId.prefix "hasMaximumValue"
    let hasMinimumValue = _prefixId.prefix "hasMinimumValue"
    /// <summary>
    ///   <para>rdfs:label : has model category</para>
    ///   <para>rdfs:comment : Category associated with a model (e.g., Hydrology, etc.)</para>
    ///   <a href="https://w3id.org/okn/o/sdm#hasModelCategory">sdom:hasModelCategory</a>
    /// </summary>
    let hasModelCategory = _prefixId.prefix "hasModelCategory"
    /// <summary>
    ///   <para>rdfs:label : has model result table</para>
    ///   <para>rdfs:comment : Sample result table associated with a model configuration</para>
    ///   <a href="https://w3id.org/okn/o/sdm#hasModelResultTable">sdom:hasModelResultTable</a>
    /// </summary>
    let hasModelResultTable = _prefixId.prefix "hasModelResultTable"
    /// <summary>
    ///   <para>rdfs:label : has output time interval</para>
    ///   <para>rdfs:comment : Time interval used in the model configuration</para>
    ///   <a href="https://w3id.org/okn/o/sdm#hasOutputTimeInterval">sdom:hasOutputTimeInterval</a>
    /// </summary>
    let hasOutputTimeInterval = _prefixId.prefix "hasOutputTimeInterval"
    /// <summary>
    ///   <para>rdfs:label : has output variable</para>
    ///   <para>rdfs:comment : Variable that is used as output for this model</para>
    ///   <a href="https://w3id.org/okn/o/sdm#hasOutputVariable">sdom:hasOutputVariable</a>
    /// </summary>
    let hasOutputVariable = _prefixId.prefix "hasOutputVariable"
    /// <summary>
    ///   <para>rdfs:label : has process</para>
    ///   <para>rdfs:comment : Property that indicates which physical processes (if any) are associated with a model</para>
    ///   <a href="https://w3id.org/okn/o/sdm#hasProcess">sdom:hasProcess</a>
    /// </summary>
    let hasProcess = _prefixId.prefix "hasProcess"
    /// <summary>
    ///   <para>rdfs:comment : Property linking a region to a model configuration/calibration. This property implies that the described model configuration is prepared to execute in that target region</para>
    ///   <a href="https://w3id.org/okn/o/sdm#hasRegion">sdom:hasRegion</a>
    /// </summary>
    let hasRegion = _prefixId.prefix "hasRegion"
    /// <summary>
    ///   <para>rdfs:label : has shape</para>
    ///   <para>rdfs:comment : Grids may be: rectangular, triangular, hexagonal, hybrid, unstructured, block structure, etc.</para>
    ///   <a href="https://w3id.org/okn/o/sdm#hasShape">sdom:hasShape</a>
    /// </summary>
    let hasShape = _prefixId.prefix "hasShape"
    /// <summary>
    ///   <para>rdfs:label : has spatial resolution</para>
    ///   <para>rdfs:comment : Spatial resolution of a grid (e.g., 50m)</para>
    ///   <a href="https://w3id.org/okn/o/sdm#hasSpatialResolution">sdom:hasSpatialResolution</a>
    /// </summary>
    let hasSpatialResolution = _prefixId.prefix "hasSpatialResolution"
    let hasVariable = _prefixId.prefix "hasVariable"
    /// <summary>
    ///   <para>rdfs:label : influences</para>
    ///   <para>rdfs:comment : Property that captures if a physical process influences another process</para>
    ///   <a href="https://w3id.org/okn/o/sdm#influences">sdom:influences</a>
    /// </summary>
    let influences = _prefixId.prefix "influences"
    /// <summary>
    ///   <para>rdfs:label : interval unit</para>
    ///   <para>rdfs:comment : Unit used in an interval (e.g., month)</para>
    ///   <a href="https://w3id.org/okn/o/sdm#intervalUnit">sdom:intervalUnit</a>
    /// </summary>
    let intervalUnit = _prefixId.prefix "intervalUnit"
    /// <summary>
    ///   <para>rdfs:label : interval value</para>
    ///   <para>rdfs:comment : Value used in the time interval of a model (e.g., 1 month, 5 days, 'harvest cycle')</para>
    ///   <a href="https://w3id.org/okn/o/sdm#intervalValue">sdom:intervalValue</a>
    /// </summary>
    let intervalValue = _prefixId.prefix "intervalValue"
    /// <summary>
    ///   <para>rdfs:label : latitude</para>
    ///   <para>rdfs:comment : Latitude (coordinates) of a location (WGS84)</para>
    ///   <a href="https://w3id.org/okn/o/sdm#latitude">sdom:latitude</a>
    /// </summary>
    let latitude = _prefixId.prefix "latitude"
    /// <summary>
    ///   <para>rdfs:label : limitations</para>
    ///   <para>rdfs:comment : Known restrictions (i.e. cases where the model is known not to be reliable or shouldn't be used)</para>
    ///   <a href="https://w3id.org/okn/o/sdm#limitations">sdom:limitations</a>
    /// </summary>
    let limitations = _prefixId.prefix "limitations"
    /// <summary>
    ///   <para>rdfs:label : longitude</para>
    ///   <para>rdfs:comment : Longitude (coordinates) of a location (WGS84)</para>
    ///   <a href="https://w3id.org/okn/o/sdm#longitude">sdom:longitude</a>
    /// </summary>
    let longitude = _prefixId.prefix "longitude"
    /// <summary>
    ///   <para>rdfs:label : parameter assignment method</para>
    ///   <para>rdfs:comment : Property that indicates how have the parameters assigned in a model configuration (e.g., using an expert guess, by using calibration, etc.)</para>
    ///   <a href="https://w3id.org/okn/o/sdm#parameterAssignmentMethod">sdom:parameterAssignmentMethod</a>
    /// </summary>
    let parameterAssignmentMethod = _prefixId.prefix "parameterAssignmentMethod"
    /// <summary>
    ///   <para>rdfs:label : parameterization</para>
    ///   <para>rdfs:comment : Were there any simplifications made to processes to make the model more efficient</para>
    ///   <a href="https://w3id.org/okn/o/sdm#parameterization">sdom:parameterization</a>
    /// </summary>
    let parameterization = _prefixId.prefix "parameterization"
    /// <summary>
    ///   <para>rdfs:label : parent category</para>
    ///   <para>rdfs:comment : Indicates the parent category of a given category</para>
    ///   <a href="https://w3id.org/okn/o/sdm#parentCategory">sdom:parentCategory</a>
    /// </summary>
    let parentCategory = _prefixId.prefix "parentCategory"
    /// <summary>
    ///   <para>rdfs:label : part of</para>
    ///   <para>rdfs:comment : Indicates whether a region is part of another region</para>
    ///   <a href="https://w3id.org/okn/o/sdm#partOf">sdom:partOf</a>
    /// </summary>
    let partOf = _prefixId.prefix "partOf"
    /// <summary>
    ///   <para>rdfs:label : relevant for intervention</para>
    ///   <para>rdfs:comment : Property that links a parameter to the intervention it is relevant for.</para>
    ///   <a href="https://w3id.org/okn/o/sdm#relevantForIntervention">sdom:relevantForIntervention</a>
    /// </summary>
    let relevantForIntervention = _prefixId.prefix "relevantForIntervention"
    /// <summary>
    ///   <para>rdfs:label : runtime estimation</para>
    ///   <para>rdfs:comment : An estimate of the time required to run example codes or other known configurations</para>
    ///   <a href="https://w3id.org/okn/o/sdm#runtimeEstimation">sdom:runtimeEstimation</a>
    /// </summary>
    let runtimeEstimation = _prefixId.prefix "runtimeEstimation"
    /// <summary>
    ///   <para>rdfs:label : theoretical basis</para>
    ///   <para>rdfs:comment : What is the theory behind the processes described in the model</para>
    ///   <a href="https://w3id.org/okn/o/sdm#theoreticalBasis">sdom:theoreticalBasis</a>
    /// </summary>
    let theoreticalBasis = _prefixId.prefix "theoreticalBasis"
    /// <summary>
    ///   <para>rdfs:label : uses model</para>
    ///   <para>rdfs:comment : Property that describes which models are used by a coupled model</para>
    ///   <a href="https://w3id.org/okn/o/sdm#usesModel">sdom:usesModel</a>
    /// </summary>
    let usesModel = _prefixId.prefix "usesModel"
    /// <summary>
    ///   <para>rdfs:label : valid until</para>
    ///   <para>rdfs:comment : Date until which the calibration of a model is valid. For example, a trained model with data from 2005-2010 may only be valid for predictions until 2015.</para>
    ///   <a href="https://w3id.org/okn/o/sdm#validUntil">sdom:validUntil</a>
    /// </summary>
    let validUntil = _prefixId.prefix "validUntil"
