namespace https.w3id.org.gom.hash

open DoxAletheia.Rdf_Vocabulary

module gom =
    let _namespace_name = "https://w3id.org/gom#"

    /// <summary>
    /// An affine transformation between 3D Cartesian Coordinate Systems. An instance of this class links to exactly two gom:CartesianCoordinateSystem instances using resp. gom:fromCartesianCoordinateSystem and gom:toCartesianCoordinateSystem. Each instance of gom:AffineCoordinateSystemTransformation also links to one or multiple literals containing matrices defining the transformation. In the simplest example, there is only one such linked literal containing an entire 4 X 4 transformation matrix, linked with the gom:hasTransformationMatrix datatype property.
    /// <see href="https://w3id.org/gom#AffineCoordinateSystemTransformation"></see></summary>
    let AffineCoordinateSystemTransformation =
        Namespaced_IRI.parse _namespace_name "AffineCoordinateSystemTransformation" |> NamespacedName

    /// <summary>
    /// A transformation between 3D Coordinate Systems. An instance of this class links to exactly two gom:CoordinateSystem instances using resp. gom:fromCoordinateSystem and gom:toCoordinateSystem. Each instance of gom:CoordinateSystemTransformation also links to one or multiple literals containing matrices or individual parameters defining the transformation.
    /// <see href="https://w3id.org/gom#CoordinateSystemTransformation"></see></summary>
    let CoordinateSystemTransformation =
        Namespaced_IRI.parse _namespace_name "CoordinateSystemTransformation" |> NamespacedName

    /// <summary>
    /// A 3D Cartesian Coordinate System. One or multiple omg:Geometry or omg:GeometryState nodes can link to an instance of this class using gom:hasCoordinateSystem. If no named Coordinate System is linked explicitly to a geometry description, an unnamed Cartesian Coordinate System is assumed. A custom Cartesian Coordinate System can be registered in RDF to a world Cartesian Coordinate System by linking a gom:AffineCoordinateSystemTransformation instance to two instances of gom:CartesianCoordinateSystem
    /// <see href="https://w3id.org/gom#CartesianCoordinateSystem"></see></summary>
    let CartesianCoordinateSystem =
        Namespaced_IRI.parse _namespace_name "CartesianCoordinateSystem" |> NamespacedName

    /// <summary>
    /// A 3D Coordinate System. One or multiple omg:Geometry or omg:GeometryState nodes can link to an instance of this class using gom:hasCoordinateSystem. If no named Coordinate System is linked explicitly to a geometry description, an unnamed Cartesian Coordinate System is assumed. A custom Coordinate System can be registered in RDF by linking a gom:CoordinateSystemTransformation instance to this Coordinate System (gom:fromCoordinateSystem) and a second instance of gom:CoordinateSystem (gom:toCoordinateSystem)
    /// <see href="https://w3id.org/gom#CoordinateSystem"></see></summary>
    let CoordinateSystem =
        Namespaced_IRI.parse _namespace_name "CoordinateSystem" |> NamespacedName

    /// <summary>
    /// A geometry modelling application, used to create geometry descriptions
    /// <see href="https://w3id.org/gom#GeometryModellingApplication"></see></summary>
    let GeometryModellingApplication =
        Namespaced_IRI.parse _namespace_name "GeometryModellingApplication" |> NamespacedName

    /// <summary>
    /// A length unit for a Cartesian Coordinate System. Each such Coordinate System has exactly one length unit (e.g. metre, kilometre, etc.). The instance of this class can be defined in QUDT or other ontologies for units.
    /// <see href="https://w3id.org/gom#LengthUnit"></see></summary>
    let LengthUnit = Namespaced_IRI.parse _namespace_name "LengthUnit" |> NamespacedName

    /// <summary>
    /// A 3D mesh geometry consisting of planar faces connected via their edges
    /// <see href="https://w3id.org/gom#MeshGeometry"></see></summary>
    let MeshGeometry =
        Namespaced_IRI.parse _namespace_name "MeshGeometry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/gom#Meshlab_v2016"></see>
    /// </summary>
    let Meshlab_v2016 =
        Namespaced_IRI.parse _namespace_name "Meshlab_v2016" |> NamespacedName

    /// <summary>
    /// A 2D plan geometry including floorplans, ceilingplans, elevations, sections and 2D ortographic drawings
    /// <see href="https://w3id.org/gom#PlanGeometry"></see></summary>
    let PlanGeometry =
        Namespaced_IRI.parse _namespace_name "PlanGeometry" |> NamespacedName

    /// <summary>
    /// A point cloud geometry consisting of a series of 3D points, with optional color and other scalar values
    /// <see href="https://w3id.org/gom#PointCloudGeometry"></see></summary>
    let PointCloudGeometry =
        Namespaced_IRI.parse _namespace_name "PointCloudGeometry" |> NamespacedName

    /// <summary>
    /// A 3D accuracy analysis executed to determine the represented LOA (Level Of Accuracy) as defined by the related USIBD specification. It is connected with exactly one source geometry resulting from a survey and one simplified 3D geometry.
    /// <see href="https://w3id.org/gom#RepresentedAccuracyAnalysis"></see></summary>
    let RepresentedAccuracyAnalysis =
        Namespaced_IRI.parse _namespace_name "RepresentedAccuracyAnalysis" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/gom#Rhinoceros_v6"></see>
    /// </summary>
    let Rhinoceros_v6 =
        Namespaced_IRI.parse _namespace_name "Rhinoceros_v6" |> NamespacedName

    /// <summary>
    /// a JSON column major array representing a square matrix. An example in Turtle of a literal representing a 2 X 2 matrix M: "[m11,m21,m12,m22]"^^gom:columnMajorArray
    /// <see href="https://w3id.org/gom#columnMajorArray"></see></summary>
    let columnMajorArray =
        Namespaced_IRI.parse _namespace_name "columnMajorArray" |> NamespacedName

    /// <summary>
    /// property to link to the geometry modelling application the geometry description was created in
    /// <see href="https://w3id.org/gom#createdIn"></see></summary>
    let createdIn = Namespaced_IRI.parse _namespace_name "createdIn" |> NamespacedName

    /// <summary>
    /// links to an instance of gom:CartesianCoordinateSystem where the transformation results in
    /// <see href="https://w3id.org/gom#fromCartesianCoordinateSystem"></see></summary>
    let fromCartesianCoordinateSystem =
        Namespaced_IRI.parse _namespace_name "fromCartesianCoordinateSystem" |> NamespacedName

    /// <summary>
    /// links to an instance of gom:CoordinateSystem where the transformation results in
    /// <see href="https://w3id.org/gom#fromCoordinateSystem"></see></summary>
    let fromCoordinateSystem =
        Namespaced_IRI.parse _namespace_name "fromCoordinateSystem" |> NamespacedName

    /// <summary>
    /// Links to an RDF literal containing an embedded analysis file or a reference to such a file.
    /// <see href="https://w3id.org/gom#hasAnalysisFile"></see></summary>
    let hasAnalysisFile =
        Namespaced_IRI.parse _namespace_name "hasAnalysisFile" |> NamespacedName

    /// <summary>
    /// Geometry description is defined in exactly one Coordinate System. This property links a omg:Geometry of omg:GeometryState instance to a gom:CoordinateSystem instance.
    /// <see href="https://w3id.org/gom#hasCoordinateSystem"></see></summary>
    let hasCoordinateSystem =
        Namespaced_IRI.parse _namespace_name "hasCoordinateSystem" |> NamespacedName

    /// <summary>
    /// the number of edges of a mesh geometry description
    /// <see href="https://w3id.org/gom#hasEdges"></see></summary>
    let hasEdges = Namespaced_IRI.parse _namespace_name "hasEdges" |> NamespacedName
    /// <summary>
    /// the number of faces of a mesh geometry description
    /// <see href="https://w3id.org/gom#hasFaces"></see></summary>
    let hasFaces = Namespaced_IRI.parse _namespace_name "hasFaces" |> NamespacedName

    /// <summary>
    /// the file size of the geometry description in bytes. If the geometry description includes material and/or texture files, the size of these files is included.
    /// <see href="https://w3id.org/gom#hasFileSize"></see></summary>
    let hasFileSize =
        Namespaced_IRI.parse _namespace_name "hasFileSize" |> NamespacedName

    /// <summary>
    /// Each Cartesian Coordinate System has exactly one length unit. If such a Coordinate System does not link to a length unit, it is assumed to be in metre.
    /// <see href="https://w3id.org/gom#hasLengthUnit"></see></summary>
    let hasLengthUnit =
        Namespaced_IRI.parse _namespace_name "hasLengthUnit" |> NamespacedName

    /// <summary>
    /// The simplified geometry of a gom:RepresentedAccuracyAnalysis that is compared with a survey geometry.
    /// <see href="https://w3id.org/gom#hasSimplifiedGeometry"></see></summary>
    let hasSimplifiedGeometry =
        Namespaced_IRI.parse _namespace_name "hasSimplifiedGeometry" |> NamespacedName

    /// <summary>
    /// the area of a volumetric (closed) geometry description. The units of this value are in m2
    /// <see href="https://w3id.org/gom#hasSurfaceArea"></see></summary>
    let hasSurfaceArea =
        Namespaced_IRI.parse _namespace_name "hasSurfaceArea" |> NamespacedName

    /// <summary>
    /// The survey geometry where a gom:RepresentedAccuracyAnalysis starts from.
    /// <see href="https://w3id.org/gom#hasSurveyGeometry"></see></summary>
    let hasSurveyGeometry =
        Namespaced_IRI.parse _namespace_name "hasSurveyGeometry" |> NamespacedName

    /// <summary>
    /// has a single 4 X 4 transformation matrix. This datatype property links a gom:AffineCoordinateSystemTransformation to exactly one 4 X 4 transformation matrix M. Currently, two approaches can be used to define this matrix in one literal, i.e. using a JSON row major array (gom:rowMajorArray) or a column major array (gom:columnMajorArray).
    /// <see href="https://w3id.org/gom#hasTransformationMatrix"></see></summary>
    let hasTransformationMatrix =
        Namespaced_IRI.parse _namespace_name "hasTransformationMatrix" |> NamespacedName

    /// <summary>
    /// a JSON row major array representing a square matrix. An example in Turtle of a literal representing a 2 X 2 matrix M: "[m11,m12,m21,m22]"^^gom:rowMajorArray
    /// <see href="https://w3id.org/gom#rowMajorArray"></see></summary>
    let rowMajorArray =
        Namespaced_IRI.parse _namespace_name "rowMajorArray" |> NamespacedName

    /// <summary>
    /// the number of vertices of a mesh or point cloud geometry description
    /// <see href="https://w3id.org/gom#hasVertices"></see></summary>
    let hasVertices =
        Namespaced_IRI.parse _namespace_name "hasVertices" |> NamespacedName

    /// <summary>
    /// the volume of a volumetric (closed) geometry description. The units of this value are in m3
    /// <see href="https://w3id.org/gom#hasVolume"></see></summary>
    let hasVolume = Namespaced_IRI.parse _namespace_name "hasVolume" |> NamespacedName

    /// <summary>
    /// Property to link a omg:Geometry, that transforms (omg:transformsGeometry) another omg:Geometry (prototype geometry), to an RDF literal containing the 4x4 transformation matrix. {@en}x
    /// <see href="https://w3id.org/gom#locallyTransformedByMatrix"></see></summary>
    let locallyTransformedByMatrix =
        Namespaced_IRI.parse _namespace_name "locallyTransformedByMatrix" |> NamespacedName

    /// <summary>
    /// The maximum calculated deviation distance to classify a point on the surface of the simplified geometry as being occluded. It is a setting of the represented accuracy analysis.
    /// <see href="https://w3id.org/gom#maxOcclusionDistance"></see></summary>
    let maxOcclusionDistance =
        Namespaced_IRI.parse _namespace_name "maxOcclusionDistance" |> NamespacedName

    /// <summary>
    /// links to an instance of gom:CartesianCoordinateSystem where the transformation is applied to
    /// <see href="https://w3id.org/gom#toCartesianCoordinateSystem"></see></summary>
    let toCartesianCoordinateSystem =
        Namespaced_IRI.parse _namespace_name "toCartesianCoordinateSystem" |> NamespacedName

    /// <summary>
    /// links an instance of gom:CoordinateSystemTransformation to an instance of gom:CoordinateSystem where the transformation is applied to
    /// <see href="https://w3id.org/gom#toCoordinateSystem"></see></summary>
    let toCoordinateSystem =
        Namespaced_IRI.parse _namespace_name "toCoordinateSystem" |> NamespacedName

    /// <summary>
    /// The total deviation limit in mm where 95% of the surface area complies with.
    /// <see href="https://w3id.org/gom#total95PercentUpperLimit"></see></summary>
    let total95PercentUpperLimit =
        Namespaced_IRI.parse _namespace_name "total95PercentUpperLimit" |> NamespacedName

    /// <summary>
    /// The percentage of total relevant surface area of the simplified geometry that is occluded in LOA10 (deviation &gt; 50 mm)
    /// <see href="https://w3id.org/gom#totalLOA10"></see></summary>
    let totalLOA10 = Namespaced_IRI.parse _namespace_name "totalLOA10" |> NamespacedName
    /// <summary>
    /// The percentage of total relevant surface area of the simplified geometry that is occluded in LOA20 (50 mm &gt; deviation &gt; 15 mm)
    /// <see href="https://w3id.org/gom#totalLOA20"></see></summary>
    let totalLOA20 = Namespaced_IRI.parse _namespace_name "totalLOA20" |> NamespacedName
    /// <summary>
    /// The percentage of total relevant surface area of the simplified geometry that is occluded in LOA30 (15 mm &gt; deviation &gt; 5 mm)
    /// <see href="https://w3id.org/gom#totalLOA30"></see></summary>
    let totalLOA30 = Namespaced_IRI.parse _namespace_name "totalLOA30" |> NamespacedName
    /// <summary>
    /// The percentage of total relevant surface area of the simplified geometry that is occluded in LOA40 (5 mm &gt; deviation &gt; 1 mm)
    /// <see href="https://w3id.org/gom#totalLOA40"></see></summary>
    let totalLOA40 = Namespaced_IRI.parse _namespace_name "totalLOA40" |> NamespacedName
    /// <summary>
    /// The percentage of total relevant surface area of the simplified geometry that is occluded in LOA50 (1 mm &gt; deviation &gt; 0 mm)
    /// <see href="https://w3id.org/gom#totalLOA50"></see></summary>
    let totalLOA50 = Namespaced_IRI.parse _namespace_name "totalLOA50" |> NamespacedName

    /// <summary>
    /// The percentage of total relevant surface area of the simplified geometry that is occluded
    /// <see href="https://w3id.org/gom#totalOccluded"></see></summary>
    let totalOccluded =
        Namespaced_IRI.parse _namespace_name "totalOccluded" |> NamespacedName

    /// <summary>
    /// The percentage of total relevant surface area of the simplified geometry
    /// <see href="https://w3id.org/gom#totalRelevant"></see></summary>
    let totalRelevant =
        Namespaced_IRI.parse _namespace_name "totalRelevant" |> NamespacedName

    /// <summary>
    /// A boolean datatype property to express if the represented accuracy analysis method used a local model or not.
    /// <see href="https://w3id.org/gom#usedLocalModelMethod"></see></summary>
    let usedLocalModelMethod =
        Namespaced_IRI.parse _namespace_name "usedLocalModelMethod" |> NamespacedName
