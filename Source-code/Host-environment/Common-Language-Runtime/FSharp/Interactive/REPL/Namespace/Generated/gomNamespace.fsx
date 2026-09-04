#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module gom =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/gom#" "gom"
    let _namespaceIri = _prefixId.prefix ""

    /// <summary>
    ///   <para>rdfs:label : Affine Coordinate System Transformation</para>
    ///   <para>rdfs:comment : An affine transformation between 3D Cartesian Coordinate Systems. An instance of this class links to exactly two gom:CartesianCoordinateSystem instances using resp. gom:fromCartesianCoordinateSystem and gom:toCartesianCoordinateSystem. Each instance of gom:AffineCoordinateSystemTransformation also links to one or multiple literals containing matrices defining the transformation. In the simplest example, there is only one such linked literal containing an entire 4 X 4 transformation matrix, linked with the gom:hasTransformationMatrix datatype property.</para>
    ///   <a href="https://w3id.org/gom#AffineCoordinateSystemTransformation">gom:AffineCoordinateSystemTransformation</a>
    /// </summary>
    let AffineCoordinateSystemTransformation =
        _prefixId.prefix "AffineCoordinateSystemTransformation"

    /// <summary>
    ///   <para>rdfs:label : Coordinate System</para>
    ///   <para>rdfs:comment : A 3D Cartesian Coordinate System. One or multiple omg:Geometry or omg:GeometryState nodes can link to an instance of this class using gom:hasCoordinateSystem. If no named Coordinate System is linked explicitly to a geometry description, an unnamed Cartesian Coordinate System is assumed. A custom Cartesian Coordinate System can be registered in RDF to a world Cartesian Coordinate System by linking a gom:AffineCoordinateSystemTransformation instance to two instances of gom:CartesianCoordinateSystem</para>
    ///   <a href="https://w3id.org/gom#CartesianCoordinateSystem">gom:CartesianCoordinateSystem</a>
    /// </summary>
    let CartesianCoordinateSystem = _prefixId.prefix "CartesianCoordinateSystem"
    /// <summary>
    ///   <para>rdfs:label : Coordinate System</para>
    ///   <para>rdfs:comment : A 3D Coordinate System. One or multiple omg:Geometry or omg:GeometryState nodes can link to an instance of this class using gom:hasCoordinateSystem. If no named Coordinate System is linked explicitly to a geometry description, an unnamed Cartesian Coordinate System is assumed. A custom Coordinate System can be registered in RDF by linking a gom:CoordinateSystemTransformation instance to this Coordinate System (gom:fromCoordinateSystem) and a second instance of gom:CoordinateSystem (gom:toCoordinateSystem)</para>
    ///   <a href="https://w3id.org/gom#CoordinateSystem">gom:CoordinateSystem</a>
    /// </summary>
    let CoordinateSystem = _prefixId.prefix "CoordinateSystem"

    /// <summary>
    ///   <para>rdfs:label : Coordinate System Transformation</para>
    ///   <para>rdfs:comment : A transformation between 3D Coordinate Systems. An instance of this class links to exactly two gom:CoordinateSystem instances using resp. gom:fromCoordinateSystem and gom:toCoordinateSystem. Each instance of gom:CoordinateSystemTransformation also links to one or multiple literals containing matrices or individual parameters defining the transformation.</para>
    ///   <a href="https://w3id.org/gom#CoordinateSystemTransformation">gom:CoordinateSystemTransformation</a>
    /// </summary>
    let CoordinateSystemTransformation =
        _prefixId.prefix "CoordinateSystemTransformation"

    /// <summary>
    ///   <para>rdfs:label : geometry modelling application</para>
    ///   <para>rdfs:comment : A geometry modelling application, used to create geometry descriptions</para>
    ///   <a href="https://w3id.org/gom#GeometryModellingApplication">gom:GeometryModellingApplication</a>
    /// </summary>
    let GeometryModellingApplication = _prefixId.prefix "GeometryModellingApplication"
    /// <summary>
    ///   <para>rdfs:label : Length unit</para>
    ///   <para>rdfs:comment : A length unit for a Cartesian Coordinate System. Each such Coordinate System has exactly one length unit (e.g. metre, kilometre, etc.). The instance of this class can be defined in QUDT or other ontologies for units.</para>
    ///   <a href="https://w3id.org/gom#LengthUnit">gom:LengthUnit</a>
    /// </summary>
    let LengthUnit = _prefixId.prefix "LengthUnit"
    /// <summary>
    ///   <para>rdfs:label : Mesh geometry</para>
    ///   <para>rdfs:comment : A 3D mesh geometry consisting of planar faces connected via their edges</para>
    ///   <a href="https://w3id.org/gom#MeshGeometry">gom:MeshGeometry</a>
    /// </summary>
    let MeshGeometry = _prefixId.prefix "MeshGeometry"
    let Meshlab_v2016 = _prefixId.prefix "Meshlab_v2016"
    /// <summary>
    ///   <para>rdfs:label : 2D plan geometry</para>
    ///   <para>rdfs:comment : A 2D plan geometry including floorplans, ceilingplans, elevations, sections and 2D ortographic drawings</para>
    ///   <a href="https://w3id.org/gom#PlanGeometry">gom:PlanGeometry</a>
    /// </summary>
    let PlanGeometry = _prefixId.prefix "PlanGeometry"
    /// <summary>
    ///   <para>rdfs:label : point cloud geometry</para>
    ///   <para>rdfs:comment : A point cloud geometry consisting of a series of 3D points, with optional color and other scalar values</para>
    ///   <a href="https://w3id.org/gom#PointCloudGeometry">gom:PointCloudGeometry</a>
    /// </summary>
    let PointCloudGeometry = _prefixId.prefix "PointCloudGeometry"
    /// <summary>
    ///   <para>rdfs:label : represented accuracy analysis</para>
    ///   <para>rdfs:comment : A 3D accuracy analysis executed to determine the represented LOA (Level Of Accuracy) as defined by the related USIBD specification. It is connected with exactly one source geometry resulting from a survey and one simplified 3D geometry.</para>
    ///   <a href="https://w3id.org/gom#RepresentedAccuracyAnalysis">gom:RepresentedAccuracyAnalysis</a>
    /// </summary>
    let RepresentedAccuracyAnalysis = _prefixId.prefix "RepresentedAccuracyAnalysis"
    let Rhinoceros_v6 = _prefixId.prefix "Rhinoceros_v6"
    let columnMajorArray = _prefixId.prefix "columnMajorArray"
    /// <summary>
    ///   <para>rdfs:label : created in</para>
    ///   <para>rdfs:comment : property to link to the geometry modelling application the geometry description was created in</para>
    ///   <a href="https://w3id.org/gom#createdIn">gom:createdIn</a>
    /// </summary>
    let createdIn = _prefixId.prefix "createdIn"
    /// <summary>
    ///   <para>rdfs:label : from Cartesian Coordinate System</para>
    ///   <para>rdfs:comment : links to an instance of gom:CartesianCoordinateSystem where the transformation results in</para>
    ///   <a href="https://w3id.org/gom#fromCartesianCoordinateSystem">gom:fromCartesianCoordinateSystem</a>
    /// </summary>
    let fromCartesianCoordinateSystem = _prefixId.prefix "fromCartesianCoordinateSystem"
    /// <summary>
    ///   <para>rdfs:label : from Coordinate System</para>
    ///   <para>rdfs:comment : links to an instance of gom:CoordinateSystem where the transformation results in</para>
    ///   <a href="https://w3id.org/gom#fromCoordinateSystem">gom:fromCoordinateSystem</a>
    /// </summary>
    let fromCoordinateSystem = _prefixId.prefix "fromCoordinateSystem"
    /// <summary>
    ///   <para>rdfs:label : has analysis file</para>
    ///   <para>rdfs:comment : Links to an RDF literal containing an embedded analysis file or a reference to such a file.</para>
    ///   <a href="https://w3id.org/gom#hasAnalysisFile">gom:hasAnalysisFile</a>
    /// </summary>
    let hasAnalysisFile = _prefixId.prefix "hasAnalysisFile"
    /// <summary>
    ///   <para>rdfs:label : has length unit</para>
    ///   <para>rdfs:comment : Geometry description is defined in exactly one Coordinate System. This property links a omg:Geometry of omg:GeometryState instance to a gom:CoordinateSystem instance.</para>
    ///   <a href="https://w3id.org/gom#hasCoordinateSystem">gom:hasCoordinateSystem</a>
    /// </summary>
    let hasCoordinateSystem = _prefixId.prefix "hasCoordinateSystem"
    /// <summary>
    ///   <para>rdfs:label : has edges</para>
    ///   <para>rdfs:comment : the number of edges of a mesh geometry description</para>
    ///   <a href="https://w3id.org/gom#hasEdges">gom:hasEdges</a>
    /// </summary>
    let hasEdges = _prefixId.prefix "hasEdges"
    /// <summary>
    ///   <para>rdfs:label : has faces</para>
    ///   <para>rdfs:comment : the number of faces of a mesh geometry description</para>
    ///   <a href="https://w3id.org/gom#hasFaces">gom:hasFaces</a>
    /// </summary>
    let hasFaces = _prefixId.prefix "hasFaces"
    /// <summary>
    ///   <para>rdfs:label : has file size</para>
    ///   <para>rdfs:comment : the file size of the geometry description in bytes. If the geometry description includes material and/or texture files, the size of these files is included.</para>
    ///   <a href="https://w3id.org/gom#hasFileSize">gom:hasFileSize</a>
    /// </summary>
    let hasFileSize = _prefixId.prefix "hasFileSize"
    /// <summary>
    ///   <para>rdfs:label : has length unit</para>
    ///   <para>rdfs:comment : Each Cartesian Coordinate System has exactly one length unit. If such a Coordinate System does not link to a length unit, it is assumed to be in metre.</para>
    ///   <a href="https://w3id.org/gom#hasLengthUnit">gom:hasLengthUnit</a>
    /// </summary>
    let hasLengthUnit = _prefixId.prefix "hasLengthUnit"
    /// <summary>
    ///   <para>rdfs:label : has simplified geometry</para>
    ///   <para>rdfs:comment : The simplified geometry of a gom:RepresentedAccuracyAnalysis that is compared with a survey geometry.</para>
    ///   <a href="https://w3id.org/gom#hasSimplifiedGeometry">gom:hasSimplifiedGeometry</a>
    /// </summary>
    let hasSimplifiedGeometry = _prefixId.prefix "hasSimplifiedGeometry"
    /// <summary>
    ///   <para>rdfs:label : has surface area</para>
    ///   <para>rdfs:comment : the area of a volumetric (closed) geometry description. The units of this value are in m2</para>
    ///   <a href="https://w3id.org/gom#hasSurfaceArea">gom:hasSurfaceArea</a>
    /// </summary>
    let hasSurfaceArea = _prefixId.prefix "hasSurfaceArea"
    /// <summary>
    ///   <para>rdfs:label : has survey geometry</para>
    ///   <para>rdfs:comment : The survey geometry where a gom:RepresentedAccuracyAnalysis starts from.</para>
    ///   <a href="https://w3id.org/gom#hasSurveyGeometry">gom:hasSurveyGeometry</a>
    /// </summary>
    let hasSurveyGeometry = _prefixId.prefix "hasSurveyGeometry"
    /// <summary>
    ///   <para>rdfs:label : has a transformation matrix</para>
    ///   <para>rdfs:comment : has a single 4 X 4 transformation matrix. This datatype property links a gom:AffineCoordinateSystemTransformation to exactly one 4 X 4 transformation matrix M. Currently, two approaches can be used to define this matrix in one literal, i.e. using a JSON row major array (gom:rowMajorArray) or a column major array (gom:columnMajorArray).</para>
    ///   <a href="https://w3id.org/gom#hasTransformationMatrix">gom:hasTransformationMatrix</a>
    /// </summary>
    let hasTransformationMatrix = _prefixId.prefix "hasTransformationMatrix"
    /// <summary>
    ///   <para>rdfs:label : has vertices</para>
    ///   <para>rdfs:comment : the number of vertices of a mesh or point cloud geometry description</para>
    ///   <a href="https://w3id.org/gom#hasVertices">gom:hasVertices</a>
    /// </summary>
    let hasVertices = _prefixId.prefix "hasVertices"
    /// <summary>
    ///   <para>rdfs:label : has volume</para>
    ///   <para>rdfs:comment : the volume of a volumetric (closed) geometry description. The units of this value are in m3</para>
    ///   <a href="https://w3id.org/gom#hasVolume">gom:hasVolume</a>
    /// </summary>
    let hasVolume = _prefixId.prefix "hasVolume"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : locally transformed by</para>
    ///   <para>rdfs:comment : Property to link a omg:Geometry, that transforms (omg:transformsGeometry) another omg:Geometry (prototype geometry), to an RDF literal containing the 4x4 transformation matrix. {@en}x^^xsd:string</para>
    ///   <a href="https://w3id.org/gom#locallyTransformedByMatrix">gom:locallyTransformedByMatrix</a>
    /// </summary>
    let locallyTransformedByMatrix = _prefixId.prefix "locallyTransformedByMatrix"
    /// <summary>
    ///   <para>rdfs:label : max occlusion distance (mm)</para>
    ///   <para>rdfs:comment : The maximum calculated deviation distance to classify a point on the surface of the simplified geometry as being occluded. It is a setting of the represented accuracy analysis.</para>
    ///   <a href="https://w3id.org/gom#maxOcclusionDistance">gom:maxOcclusionDistance</a>
    /// </summary>
    let maxOcclusionDistance = _prefixId.prefix "maxOcclusionDistance"
    let rowMajorArray = _prefixId.prefix "rowMajorArray"
    /// <summary>
    ///   <para>rdfs:label : to Cartesian Coordinate System</para>
    ///   <para>rdfs:comment : links to an instance of gom:CartesianCoordinateSystem where the transformation is applied to</para>
    ///   <a href="https://w3id.org/gom#toCartesianCoordinateSystem">gom:toCartesianCoordinateSystem</a>
    /// </summary>
    let toCartesianCoordinateSystem = _prefixId.prefix "toCartesianCoordinateSystem"
    /// <summary>
    ///   <para>rdfs:label : from Coordinate System</para>
    ///   <para>rdfs:comment : links an instance of gom:CoordinateSystemTransformation to an instance of gom:CoordinateSystem where the transformation is applied to</para>
    ///   <a href="https://w3id.org/gom#toCoordinateSystem">gom:toCoordinateSystem</a>
    /// </summary>
    let toCoordinateSystem = _prefixId.prefix "toCoordinateSystem"
    /// <summary>
    ///   <para>rdfs:label : total 95% deviation limit</para>
    ///   <para>rdfs:comment : The total deviation limit in mm where 95% of the surface area complies with.</para>
    ///   <a href="https://w3id.org/gom#total95PercentUpperLimit">gom:total95PercentUpperLimit</a>
    /// </summary>
    let total95PercentUpperLimit = _prefixId.prefix "total95PercentUpperLimit"
    /// <summary>
    ///   <para>rdfs:label : % of total surface area in LOA10</para>
    ///   <para>rdfs:comment : The percentage of total relevant surface area of the simplified geometry that is occluded in LOA10 (deviation &gt; 50 mm)</para>
    ///   <a href="https://w3id.org/gom#totalLOA10">gom:totalLOA10</a>
    /// </summary>
    let totalLOA10 = _prefixId.prefix "totalLOA10"
    /// <summary>
    ///   <para>rdfs:label : % of total surface area in LOA20</para>
    ///   <para>rdfs:comment : The percentage of total relevant surface area of the simplified geometry that is occluded in LOA20 (50 mm &gt; deviation &gt; 15 mm)</para>
    ///   <a href="https://w3id.org/gom#totalLOA20">gom:totalLOA20</a>
    /// </summary>
    let totalLOA20 = _prefixId.prefix "totalLOA20"
    /// <summary>
    ///   <para>rdfs:label : % of total surface area in LOA30</para>
    ///   <para>rdfs:comment : The percentage of total relevant surface area of the simplified geometry that is occluded in LOA30 (15 mm &gt; deviation &gt; 5 mm)</para>
    ///   <a href="https://w3id.org/gom#totalLOA30">gom:totalLOA30</a>
    /// </summary>
    let totalLOA30 = _prefixId.prefix "totalLOA30"
    /// <summary>
    ///   <para>rdfs:label : % of total surface area in LOA40</para>
    ///   <para>rdfs:comment : The percentage of total relevant surface area of the simplified geometry that is occluded in LOA40 (5 mm &gt; deviation &gt; 1 mm)</para>
    ///   <a href="https://w3id.org/gom#totalLOA40">gom:totalLOA40</a>
    /// </summary>
    let totalLOA40 = _prefixId.prefix "totalLOA40"
    /// <summary>
    ///   <para>rdfs:label : % of total surface area in LOA50</para>
    ///   <para>rdfs:comment : The percentage of total relevant surface area of the simplified geometry that is occluded in LOA50 (1 mm &gt; deviation &gt; 0 mm)</para>
    ///   <a href="https://w3id.org/gom#totalLOA50">gom:totalLOA50</a>
    /// </summary>
    let totalLOA50 = _prefixId.prefix "totalLOA50"
    /// <summary>
    ///   <para>rdfs:label : % occluded surface area</para>
    ///   <para>rdfs:comment : The percentage of total relevant surface area of the simplified geometry that is occluded</para>
    ///   <a href="https://w3id.org/gom#totalOccluded">gom:totalOccluded</a>
    /// </summary>
    let totalOccluded = _prefixId.prefix "totalOccluded"
    /// <summary>
    ///   <para>rdfs:label : % of total relevant surface area</para>
    ///   <para>rdfs:comment : The percentage of total relevant surface area of the simplified geometry</para>
    ///   <a href="https://w3id.org/gom#totalRelevant">gom:totalRelevant</a>
    /// </summary>
    let totalRelevant = _prefixId.prefix "totalRelevant"
    /// <summary>
    ///   <para>rdfs:label : used local model method</para>
    ///   <para>rdfs:comment : A boolean datatype property to express if the represented accuracy analysis method used a local model or not.</para>
    ///   <a href="https://w3id.org/gom#usedLocalModelMethod">gom:usedLocalModelMethod</a>
    /// </summary>
    let usedLocalModelMethod = _prefixId.prefix "usedLocalModelMethod"
