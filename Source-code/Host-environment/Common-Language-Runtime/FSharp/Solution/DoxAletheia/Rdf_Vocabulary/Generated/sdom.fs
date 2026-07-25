namespace https.w3id.org.okn.o.sdm.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module sdom =
    let _namespace_iri = Namespace_Iri sdom |> NamespaceIRI
    /// <summary>
    ///   <para>sdom:Constraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#Constraint">https://w3id.org/okn/o/sdm#Constraint</seealso>
    let Constraint = Prefixed_Name(sdom, "Constraint") |> PrefixedName
    /// <summary>
    ///   <para>sdom:Emulator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Type of models that emulates the behavior of another model. For example, an emulator can be a machine learning model trained on the output runs of a hydrology model</para>
    /// labels<para>Emulator</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#Emulator">https://w3id.org/okn/o/sdm#Emulator</seealso>
    let Emulator = Prefixed_Name(sdom, "Emulator") |> PrefixedName
    /// <summary>
    ///   <para>sdom:GeoShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Shape or polygon of a region in a map</para>
    /// labels<para>GeoShape</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#GeoShape">https://w3id.org/okn/o/sdm#GeoShape</seealso>
    let GeoShape = Prefixed_Name(sdom, "GeoShape") |> PrefixedName
    /// <summary>
    ///   <para>sdom:TimeInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Time interval at which a model produces output. For example, a model may produce outputs for every simulated day, hour, etc.</para>
    /// labels<para>Time Interval</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#TimeInterval">https://w3id.org/okn/o/sdm#TimeInterval</seealso>
    let TimeInterval = Prefixed_Name(sdom, "TimeInterval") |> PrefixedName
    /// <summary>
    ///   <para>sdom:calibratedVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Variable that was calibrated in this particular model configuration calibration</para>
    /// labels<para>calibrated variable</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#calibratedVariable">https://w3id.org/okn/o/sdm#calibratedVariable</seealso>
    let calibratedVariable = Prefixed_Name(sdom, "calibratedVariable") |> PrefixedName
    /// <summary>
    ///   <para>sdom:calibrationMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Calibration method used for a particular model configuration or setup</para>
    /// labels<para>calibration method</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#calibrationMethod">https://w3id.org/okn/o/sdm#calibrationMethod</seealso>
    let calibrationMethod = Prefixed_Name(sdom, "calibrationMethod") |> PrefixedName
    /// <summary>
    ///   <para>sdom:elevation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Elevation of a location (WGS84)</para>
    /// labels<para>elevation</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#elevation">https://w3id.org/okn/o/sdm#elevation</seealso>
    let elevation = Prefixed_Name(sdom, "elevation") |> PrefixedName
    /// <summary>
    ///   <para>sdom:geo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specific coordinates or shape associated with a region</para>
    /// labels<para>geo</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#geo">https://w3id.org/okn/o/sdm#geo</seealso>
    let geo = Prefixed_Name(sdom, "geo") |> PrefixedName
    /// <summary>
    ///   <para>sdom:hasCausalDiagram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Diagram associated to a model configuration</para>
    /// labels<para>has causal diagram</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#hasCausalDiagram">https://w3id.org/okn/o/sdm#hasCausalDiagram</seealso>
    let hasCausalDiagram = Prefixed_Name(sdom, "hasCausalDiagram") |> PrefixedName
    /// <summary>
    ///   <para>sdom:hasDiagramPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that links a causal diagram with its constituent nodes</para>
    /// labels<para>has diagram part</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#hasDiagramPart">https://w3id.org/okn/o/sdm#hasDiagramPart</seealso>
    let hasDiagramPart = Prefixed_Name(sdom, "hasDiagramPart") |> PrefixedName
    /// <summary>
    ///   <para>sdom:parentCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the parent category of a given category</para>
    /// labels<para>parent category</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#parentCategory">https://w3id.org/okn/o/sdm#parentCategory</seealso>
    let parentCategory = Prefixed_Name(sdom, "parentCategory") |> PrefixedName
    /// <summary>
    ///   <para>sdom:theoreticalBasis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>What is the theory behind the processes described in the model</para>
    /// labels<para>theoretical basis</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#theoreticalBasis">https://w3id.org/okn/o/sdm#theoreticalBasis</seealso>
    let theoreticalBasis = Prefixed_Name(sdom, "theoreticalBasis") |> PrefixedName
    /// <summary>
    ///   <para>sdom:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#">https://w3id.org/okn/o/sdm#</seealso>
    let _prefix_iri = Prefixed_Name(sdom, "") |> PrefixedName
    /// <summary>
    ///   <para>sdom:Model</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A mathematical description of a process (e.g., hydrological, agricultural, social, etc.)</para>
    /// labels<para>Model</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#Model">https://w3id.org/okn/o/sdm#Model</seealso>
    let Model = Prefixed_Name(sdom, "Model") |> PrefixedName
    /// <summary>
    ///   <para>sdom:GeoCoordinates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Coordinate metadata of a region</para>
    /// labels<para>GeoCoordinates</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#GeoCoordinates">https://w3id.org/okn/o/sdm#GeoCoordinates</seealso>
    let GeoCoordinates = Prefixed_Name(sdom, "GeoCoordinates") |> PrefixedName
    /// <summary>
    ///   <para>sdom:Grid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class that represents the geospatial information associated with a model</para>
    /// labels<para>Grid</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#Grid">https://w3id.org/okn/o/sdm#Grid</seealso>
    let Grid = Prefixed_Name(sdom, "Grid") |> PrefixedName
    /// <summary>
    ///   <para>sdom:HybridModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A model based on empirical observations and theory.</para>
    /// labels<para>Hybrid model</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#HybridModel">https://w3id.org/okn/o/sdm#HybridModel</seealso>
    let HybridModel = Prefixed_Name(sdom, "HybridModel") |> PrefixedName
    /// <summary>
    ///   <para>sdom:Intervention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Interference by a policy maker or modeler by modifying a variable or parameter of a model</para>
    /// labels<para>Intervention</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#Intervention">https://w3id.org/okn/o/sdm#Intervention</seealso>
    let Intervention = Prefixed_Name(sdom, "Intervention") |> PrefixedName
    /// <summary>
    ///   <para>sdom:Category</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#Category">https://w3id.org/okn/o/sdm#Category</seealso>
    let Category = Prefixed_Name(sdom, "Category") |> PrefixedName
    /// <summary>
    ///   <para>sdom:EmpiricalModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Model based on observations.</para>
    /// labels<para>Empirical model</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#EmpiricalModel">https://w3id.org/okn/o/sdm#EmpiricalModel</seealso>
    let EmpiricalModel = Prefixed_Name(sdom, "EmpiricalModel") |> PrefixedName
    /// <summary>
    ///   <para>sdom:CausalDiagram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Diagram information with the processes and variables associated with a model configuration</para>
    /// labels<para>Causal Diagram</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#CausalDiagram">https://w3id.org/okn/o/sdm#CausalDiagram</seealso>
    let CausalDiagram = Prefixed_Name(sdom, "CausalDiagram") |> PrefixedName
    /// <summary>
    ///   <para>sdom:CoupledModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Model that incorporates the coupling of two or more existing models</para>
    /// labels<para>Coupled model</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#CoupledModel">https://w3id.org/okn/o/sdm#CoupledModel</seealso>
    let CoupledModel = Prefixed_Name(sdom, "CoupledModel") |> PrefixedName
    /// <summary>
    ///   <para>sdom:Equation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information about the mathematical representation used in a model or model configuration</para>
    /// labels<para>Equation</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#Equation">https://w3id.org/okn/o/sdm#Equation</seealso>
    let Equation = Prefixed_Name(sdom, "Equation") |> PrefixedName
    /// <summary>
    ///   <para>sdom:ModelCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class used to represent a category of a model (e.g., Hydrology, Agriculture, etc.)</para>
    /// labels<para>Model category</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#ModelCategory">https://w3id.org/okn/o/sdm#ModelCategory</seealso>
    let ModelCategory = Prefixed_Name(sdom, "ModelCategory") |> PrefixedName

    /// <summary>
    ///   <para>sdom:ModelConfigurationSetup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Setup of a particular model, that may represent a calibration or a configuration with a set of values for a specific region.</para>
    /// labels<para>Model configuration setup</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#ModelConfigurationSetup">https://w3id.org/okn/o/sdm#ModelConfigurationSetup</seealso>
    let ModelConfigurationSetup =
        Prefixed_Name(sdom, "ModelConfigurationSetup") |> PrefixedName

    /// <summary>
    ///   <para>sdom:Process</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#Process">https://w3id.org/okn/o/sdm#Process</seealso>
    let Process = Prefixed_Name(sdom, "Process") |> PrefixedName
    /// <summary>
    ///   <para>sdom:Region</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An area or division with some characteristics but not always fixed boundaries</para>
    /// labels<para>Region</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#Region">https://w3id.org/okn/o/sdm#Region</seealso>
    let Region = Prefixed_Name(sdom, "Region") |> PrefixedName
    /// <summary>
    ///   <para>sdom:SpatialResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#SpatialResolution">https://w3id.org/okn/o/sdm#SpatialResolution</seealso>
    let SpatialResolution = Prefixed_Name(sdom, "SpatialResolution") |> PrefixedName

    /// <summary>
    ///   <para>sdom:SpatiallyDistributedGrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Grid that represents a 2D or 3D space</para>
    /// labels<para>Spatially Distributed Grid</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#SpatiallyDistributedGrid">https://w3id.org/okn/o/sdm#SpatiallyDistributedGrid</seealso>
    let SpatiallyDistributedGrid =
        Prefixed_Name(sdom, "SpatiallyDistributedGrid") |> PrefixedName

    /// <summary>
    ///   <para>sdom:ModelConfiguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A model configuration is a way of exposing a particular functionality of a model.</para>
    /// labels<para>Model configuration</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#ModelConfiguration">https://w3id.org/okn/o/sdm#ModelConfiguration</seealso>
    let ModelConfiguration = Prefixed_Name(sdom, "ModelConfiguration") |> PrefixedName
    /// <summary>
    ///   <para>sdom:PointBasedGrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A grid that is based on a series if points (or a single point). Typically associated with point-based models</para>
    /// labels<para>Point Based Grid</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#PointBasedGrid">https://w3id.org/okn/o/sdm#PointBasedGrid</seealso>
    let PointBasedGrid = Prefixed_Name(sdom, "PointBasedGrid") |> PrefixedName
    /// <summary>
    ///   <para>sdom:Theory-GuidedModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A model guided by mathematical equations that attempt to represent one or more natural processes.</para>
    /// labels<para>Theory guided model</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#Theory-GuidedModel">https://w3id.org/okn/o/sdm#Theory-GuidedModel</seealso>
    let Theory_GuidedModel = Prefixed_Name(sdom, "Theory-GuidedModel") |> PrefixedName
    /// <summary>
    ///   <para>sdom:box</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#box">https://w3id.org/okn/o/sdm#box</seealso>
    let box = Prefixed_Name(sdom, "box") |> PrefixedName
    /// <summary>
    ///   <para>sdom:calibrationInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Property that represents the temporal interval used to calibrate a model</para>
    /// labels<para>calibration interval</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#calibrationInterval">https://w3id.org/okn/o/sdm#calibrationInterval</seealso>
    let calibrationInterval = Prefixed_Name(sdom, "calibrationInterval") |> PrefixedName

    /// <summary>
    ///   <para>sdom:calibrationTargetVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Variable for which the model was calibrated for. For example, in a hydrology model one calibrate the predicted river width by varying hydrologic conductivity</para>
    /// labels<para>calibration target variable</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#calibrationTargetVariable">https://w3id.org/okn/o/sdm#calibrationTargetVariable</seealso>
    let calibrationTargetVariable =
        Prefixed_Name(sdom, "calibrationTargetVariable") |> PrefixedName

    /// <summary>
    ///   <para>sdom:hasConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#hasConstraint">https://w3id.org/okn/o/sdm#hasConstraint</seealso>
    let hasConstraint = Prefixed_Name(sdom, "hasConstraint") |> PrefixedName
    /// <summary>
    ///   <para>sdom:hasCoordinateSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Coordinate system used in a grid</para>
    /// labels<para>has coordinate system</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#hasCoordinateSystem">https://w3id.org/okn/o/sdm#hasCoordinateSystem</seealso>
    let hasCoordinateSystem = Prefixed_Name(sdom, "hasCoordinateSystem") |> PrefixedName
    /// <summary>
    ///   <para>sdom:hasDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Dimension of the grid (2D, 3D)</para>
    /// labels<para>has dimension</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#hasDimension">https://w3id.org/okn/o/sdm#hasDimension</seealso>
    let hasDimension = Prefixed_Name(sdom, "hasDimension") |> PrefixedName
    /// <summary>
    ///   <para>sdom:hasGrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Grid information about the model</para>
    /// labels<para>has grid</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#hasGrid">https://w3id.org/okn/o/sdm#hasGrid</seealso>
    let hasGrid = Prefixed_Name(sdom, "hasGrid") |> PrefixedName
    /// <summary>
    ///   <para>sdom:hasEquation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Equations used in the model</para>
    /// labels<para>has equation</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#hasEquation">https://w3id.org/okn/o/sdm#hasEquation</seealso>
    let hasEquation = Prefixed_Name(sdom, "hasEquation") |> PrefixedName
    /// <summary>
    ///   <para>sdom:hasMaximumValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#hasMaximumValue">https://w3id.org/okn/o/sdm#hasMaximumValue</seealso>
    let hasMaximumValue = Prefixed_Name(sdom, "hasMaximumValue") |> PrefixedName

    /// <summary>
    ///   <para>sdom:hasOutputTimeInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Time interval used in the model configuration</para>
    /// labels<para>has output time interval</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#hasOutputTimeInterval">https://w3id.org/okn/o/sdm#hasOutputTimeInterval</seealso>
    let hasOutputTimeInterval =
        Prefixed_Name(sdom, "hasOutputTimeInterval") |> PrefixedName

    /// <summary>
    ///   <para>sdom:hasProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that indicates which physical processes (if any) are associated with a model</para>
    /// labels<para>has process</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#hasProcess">https://w3id.org/okn/o/sdm#hasProcess</seealso>
    let hasProcess = Prefixed_Name(sdom, "hasProcess") |> PrefixedName
    /// <summary>
    ///   <para>sdom:hasRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property linking a region to a model configuration/calibration. This property implies that the described model configuration is prepared to execute in that target region</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#hasRegion">https://w3id.org/okn/o/sdm#hasRegion</seealso>
    let hasRegion = Prefixed_Name(sdom, "hasRegion") |> PrefixedName

    /// <summary>
    ///   <para>sdom:hasSpatialResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Spatial resolution of a grid (e.g., 50m)</para>
    /// labels<para>has spatial resolution</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#hasSpatialResolution">https://w3id.org/okn/o/sdm#hasSpatialResolution</seealso>
    let hasSpatialResolution =
        Prefixed_Name(sdom, "hasSpatialResolution") |> PrefixedName

    /// <summary>
    ///   <para>sdom:influences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that captures if a physical process influences another process</para>
    /// labels<para>influences</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#influences">https://w3id.org/okn/o/sdm#influences</seealso>
    let influences = Prefixed_Name(sdom, "influences") |> PrefixedName
    /// <summary>
    ///   <para>sdom:limitations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Known restrictions (i.e. cases where the model is known not to be reliable or shouldn't be used)</para>
    /// labels<para>limitations</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#limitations">https://w3id.org/okn/o/sdm#limitations</seealso>
    let limitations = Prefixed_Name(sdom, "limitations") |> PrefixedName
    /// <summary>
    ///   <para>sdom:longitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Longitude (coordinates) of a location (WGS84)</para>
    /// labels<para>longitude</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#longitude">https://w3id.org/okn/o/sdm#longitude</seealso>
    let longitude = Prefixed_Name(sdom, "longitude") |> PrefixedName
    /// <summary>
    ///   <para>sdom:parameterization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Were there any simplifications made to processes to make the model more efficient</para>
    /// labels<para>parameterization</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#parameterization">https://w3id.org/okn/o/sdm#parameterization</seealso>
    let parameterization = Prefixed_Name(sdom, "parameterization") |> PrefixedName

    /// <summary>
    ///   <para>sdom:relevantForIntervention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that links a parameter to the intervention it is relevant for.</para>
    /// labels<para>relevant for intervention</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#relevantForIntervention">https://w3id.org/okn/o/sdm#relevantForIntervention</seealso>
    let relevantForIntervention =
        Prefixed_Name(sdom, "relevantForIntervention") |> PrefixedName

    /// <summary>
    ///   <para>sdom:usesModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that describes which models are used by a coupled model</para>
    /// labels<para>uses model</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#usesModel">https://w3id.org/okn/o/sdm#usesModel</seealso>
    let usesModel = Prefixed_Name(sdom, "usesModel") |> PrefixedName

    /// <summary>
    ///   <para>sdom:hasExplanationDiagram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Diagram used to explain the behavior of the model</para>
    /// labels<para>has explanation diagram</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#hasExplanationDiagram">https://w3id.org/okn/o/sdm#hasExplanationDiagram</seealso>
    let hasExplanationDiagram =
        Prefixed_Name(sdom, "hasExplanationDiagram") |> PrefixedName

    /// <summary>
    ///   <para>sdom:hasInputVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Variable that is used as input for this model</para>
    /// labels<para>has input variable</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#hasInputVariable">https://w3id.org/okn/o/sdm#hasInputVariable</seealso>
    let hasInputVariable = Prefixed_Name(sdom, "hasInputVariable") |> PrefixedName
    /// <summary>
    ///   <para>sdom:hasModelCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Category associated with a model (e.g., Hydrology, etc.)</para>
    /// labels<para>has model category</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#hasModelCategory">https://w3id.org/okn/o/sdm#hasModelCategory</seealso>
    let hasModelCategory = Prefixed_Name(sdom, "hasModelCategory") |> PrefixedName
    /// <summary>
    ///   <para>sdom:hasMinimumValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#hasMinimumValue">https://w3id.org/okn/o/sdm#hasMinimumValue</seealso>
    let hasMinimumValue = Prefixed_Name(sdom, "hasMinimumValue") |> PrefixedName
    /// <summary>
    ///   <para>sdom:hasModelResultTable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Sample result table associated with a model configuration</para>
    /// labels<para>has model result table</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#hasModelResultTable">https://w3id.org/okn/o/sdm#hasModelResultTable</seealso>
    let hasModelResultTable = Prefixed_Name(sdom, "hasModelResultTable") |> PrefixedName
    /// <summary>
    ///   <para>sdom:hasOutputVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Variable that is used as output for this model</para>
    /// labels<para>has output variable</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#hasOutputVariable">https://w3id.org/okn/o/sdm#hasOutputVariable</seealso>
    let hasOutputVariable = Prefixed_Name(sdom, "hasOutputVariable") |> PrefixedName
    /// <summary>
    ///   <para>sdom:hasShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Grids may be: rectangular, triangular, hexagonal, hybrid, unstructured, block structure, etc.</para>
    /// labels<para>has shape</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#hasShape">https://w3id.org/okn/o/sdm#hasShape</seealso>
    let hasShape = Prefixed_Name(sdom, "hasShape") |> PrefixedName
    /// <summary>
    ///   <para>sdom:hasVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#hasVariable">https://w3id.org/okn/o/sdm#hasVariable</seealso>
    let hasVariable = Prefixed_Name(sdom, "hasVariable") |> PrefixedName
    /// <summary>
    ///   <para>sdom:intervalUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Unit used in an interval (e.g., month)</para>
    /// labels<para>interval unit</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#intervalUnit">https://w3id.org/okn/o/sdm#intervalUnit</seealso>
    let intervalUnit = Prefixed_Name(sdom, "intervalUnit") |> PrefixedName
    /// <summary>
    ///   <para>sdom:intervalValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Value used in the time interval of a model (e.g., 1 month, 5 days, 'harvest cycle')</para>
    /// labels<para>interval value</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#intervalValue">https://w3id.org/okn/o/sdm#intervalValue</seealso>
    let intervalValue = Prefixed_Name(sdom, "intervalValue") |> PrefixedName
    /// <summary>
    ///   <para>sdom:latitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Latitude (coordinates) of a location (WGS84)</para>
    /// labels<para>latitude</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#latitude">https://w3id.org/okn/o/sdm#latitude</seealso>
    let latitude = Prefixed_Name(sdom, "latitude") |> PrefixedName

    /// <summary>
    ///   <para>sdom:parameterAssignmentMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Property that indicates how have the parameters assigned in a model configuration (e.g., using an expert guess, by using calibration, etc.)</para>
    /// labels<para>parameter assignment method</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#parameterAssignmentMethod">https://w3id.org/okn/o/sdm#parameterAssignmentMethod</seealso>
    let parameterAssignmentMethod =
        Prefixed_Name(sdom, "parameterAssignmentMethod") |> PrefixedName

    /// <summary>
    ///   <para>sdom:partOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates whether a region is part of another region</para>
    /// labels<para>part of</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#partOf">https://w3id.org/okn/o/sdm#partOf</seealso>
    let partOf = Prefixed_Name(sdom, "partOf") |> PrefixedName
    /// <summary>
    ///   <para>sdom:runtimeEstimation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>An estimate of the time required to run example codes or other known configurations</para>
    /// labels<para>runtime estimation</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#runtimeEstimation">https://w3id.org/okn/o/sdm#runtimeEstimation</seealso>
    let runtimeEstimation = Prefixed_Name(sdom, "runtimeEstimation") |> PrefixedName
    /// <summary>
    ///   <para>sdom:validUntil</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date until which the calibration of a model is valid. For example, a trained model with data from 2005-2010 may only be valid for predictions until 2015.</para>
    /// labels<para>valid until</para></remarks>
    /// <seealso href="https://w3id.org/okn/o/sdm#validUntil">https://w3id.org/okn/o/sdm#validUntil</seealso>
    let validUntil = Prefixed_Name(sdom, "validUntil") |> PrefixedName
