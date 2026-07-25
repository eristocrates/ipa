namespace https.w3id.org.gom.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module gom =
    let _namespace_iri = Namespace_Iri gom |> NamespaceIRI

    /// <summary>
    ///   <para>gom:AffineCoordinateSystemTransformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An affine transformation between 3D Cartesian Coordinate Systems. An instance of this class links to exactly two gom:CartesianCoordinateSystem instances using resp. gom:fromCartesianCoordinateSystem and gom:toCartesianCoordinateSystem. Each instance of gom:AffineCoordinateSystemTransformation also links to one or multiple literals containing matrices defining the transformation. In the simplest example, there is only one such linked literal containing an entire 4 X 4 transformation matrix, linked with the gom:hasTransformationMatrix datatype property.</para>
    /// labels<para>Affine Coordinate System Transformation</para></remarks>
    /// <seealso href="https://w3id.org/gom#AffineCoordinateSystemTransformation">https://w3id.org/gom#AffineCoordinateSystemTransformation</seealso>
    let AffineCoordinateSystemTransformation =
        Prefixed_Name(gom, "AffineCoordinateSystemTransformation") |> PrefixedName

    /// <summary>
    ///   <para>gom:CoordinateSystemTransformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A transformation between 3D Coordinate Systems. An instance of this class links to exactly two gom:CoordinateSystem instances using resp. gom:fromCoordinateSystem and gom:toCoordinateSystem. Each instance of gom:CoordinateSystemTransformation also links to one or multiple literals containing matrices or individual parameters defining the transformation.</para>
    /// labels<para>Coordinate System Transformation</para></remarks>
    /// <seealso href="https://w3id.org/gom#CoordinateSystemTransformation">https://w3id.org/gom#CoordinateSystemTransformation</seealso>
    let CoordinateSystemTransformation =
        Prefixed_Name(gom, "CoordinateSystemTransformation") |> PrefixedName

    /// <summary>
    ///   <para>gom:CartesianCoordinateSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A 3D Cartesian Coordinate System. One or multiple omg:Geometry or omg:GeometryState nodes can link to an instance of this class using gom:hasCoordinateSystem. If no named Coordinate System is linked explicitly to a geometry description, an unnamed Cartesian Coordinate System is assumed. A custom Cartesian Coordinate System can be registered in RDF to a world Cartesian Coordinate System by linking a gom:AffineCoordinateSystemTransformation instance to two instances of gom:CartesianCoordinateSystem</para>
    /// labels<para>Coordinate System</para></remarks>
    /// <seealso href="https://w3id.org/gom#CartesianCoordinateSystem">https://w3id.org/gom#CartesianCoordinateSystem</seealso>
    let CartesianCoordinateSystem =
        Prefixed_Name(gom, "CartesianCoordinateSystem") |> PrefixedName

    /// <summary>
    ///   <para>gom:CoordinateSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A 3D Coordinate System. One or multiple omg:Geometry or omg:GeometryState nodes can link to an instance of this class using gom:hasCoordinateSystem. If no named Coordinate System is linked explicitly to a geometry description, an unnamed Cartesian Coordinate System is assumed. A custom Coordinate System can be registered in RDF by linking a gom:CoordinateSystemTransformation instance to this Coordinate System (gom:fromCoordinateSystem) and a second instance of gom:CoordinateSystem (gom:toCoordinateSystem)</para>
    /// labels<para>Coordinate System</para></remarks>
    /// <seealso href="https://w3id.org/gom#CoordinateSystem">https://w3id.org/gom#CoordinateSystem</seealso>
    let CoordinateSystem = Prefixed_Name(gom, "CoordinateSystem") |> PrefixedName
    /// <summary>
    ///   <para>gom:Meshlab_v2016</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:gom#GeometryModellingApplication</para>
    ///
    /// labels<para>Meshlab v2016 application</para></remarks>
    /// <seealso href="https://w3id.org/gom#Meshlab_v2016">https://w3id.org/gom#Meshlab_v2016</seealso>
    let Meshlab_v2016 = Prefixed_Name(gom, "Meshlab_v2016") |> PrefixedName
    /// <summary>
    ///   <para>gom:PlanGeometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A 2D plan geometry including floorplans, ceilingplans, elevations, sections and 2D ortographic drawings</para>
    /// labels<para>2D plan geometry</para></remarks>
    /// <seealso href="https://w3id.org/gom#PlanGeometry">https://w3id.org/gom#PlanGeometry</seealso>
    let PlanGeometry = Prefixed_Name(gom, "PlanGeometry") |> PrefixedName
    /// <summary>
    ///   <para>gom:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/gom#">https://w3id.org/gom#</seealso>
    let _prefix_iri = Prefixed_Name(gom, "") |> PrefixedName

    /// <summary>
    ///   <para>gom:GeometryModellingApplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A geometry modelling application, used to create geometry descriptions</para>
    /// labels<para>geometry modelling application</para></remarks>
    /// <seealso href="https://w3id.org/gom#GeometryModellingApplication">https://w3id.org/gom#GeometryModellingApplication</seealso>
    let GeometryModellingApplication =
        Prefixed_Name(gom, "GeometryModellingApplication") |> PrefixedName

    /// <summary>
    ///   <para>gom:MeshGeometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A 3D mesh geometry consisting of planar faces connected via their edges</para>
    /// labels<para>Mesh geometry</para></remarks>
    /// <seealso href="https://w3id.org/gom#MeshGeometry">https://w3id.org/gom#MeshGeometry</seealso>
    let MeshGeometry = Prefixed_Name(gom, "MeshGeometry") |> PrefixedName

    /// <summary>
    ///   <para>gom:RepresentedAccuracyAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A 3D accuracy analysis executed to determine the represented LOA (Level Of Accuracy) as defined by the related USIBD specification. It is connected with exactly one source geometry resulting from a survey and one simplified 3D geometry.</para>
    /// labels<para>represented accuracy analysis</para></remarks>
    /// <seealso href="https://w3id.org/gom#RepresentedAccuracyAnalysis">https://w3id.org/gom#RepresentedAccuracyAnalysis</seealso>
    let RepresentedAccuracyAnalysis =
        Prefixed_Name(gom, "RepresentedAccuracyAnalysis") |> PrefixedName

    /// <summary>
    ///   <para>gom:LengthUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A length unit for a Cartesian Coordinate System. Each such Coordinate System has exactly one length unit (e.g. metre, kilometre, etc.). The instance of this class can be defined in QUDT or other ontologies for units.</para>
    /// labels<para>Length unit</para></remarks>
    /// <seealso href="https://w3id.org/gom#LengthUnit">https://w3id.org/gom#LengthUnit</seealso>
    let LengthUnit = Prefixed_Name(gom, "LengthUnit") |> PrefixedName
    /// <summary>
    ///   <para>gom:PointCloudGeometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A point cloud geometry consisting of a series of 3D points, with optional color and other scalar values</para>
    /// labels<para>point cloud geometry</para></remarks>
    /// <seealso href="https://w3id.org/gom#PointCloudGeometry">https://w3id.org/gom#PointCloudGeometry</seealso>
    let PointCloudGeometry = Prefixed_Name(gom, "PointCloudGeometry") |> PrefixedName
    /// <summary>
    ///   <para>gom:columnMajorArray</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>a JSON column major array representing a square matrix. An example in Turtle of a literal representing a 2 X 2 matrix M: "[m11,m21,m12,m22]"^^gom:columnMajorArray</para>
    /// labels<para>a column major array</para></remarks>
    /// <seealso href="https://w3id.org/gom#columnMajorArray">https://w3id.org/gom#columnMajorArray</seealso>
    let columnMajorArray = Prefixed_Name(gom, "columnMajorArray") |> PrefixedName
    /// <summary>
    ///   <para>gom:createdIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>property to link to the geometry modelling application the geometry description was created in</para>
    /// labels<para>created in</para></remarks>
    /// <seealso href="https://w3id.org/gom#createdIn">https://w3id.org/gom#createdIn</seealso>
    let createdIn = Prefixed_Name(gom, "createdIn") |> PrefixedName

    /// <summary>
    ///   <para>gom:fromCartesianCoordinateSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>links to an instance of gom:CartesianCoordinateSystem where the transformation results in</para>
    /// labels<para>from Cartesian Coordinate System</para></remarks>
    /// <seealso href="https://w3id.org/gom#fromCartesianCoordinateSystem">https://w3id.org/gom#fromCartesianCoordinateSystem</seealso>
    let fromCartesianCoordinateSystem =
        Prefixed_Name(gom, "fromCartesianCoordinateSystem") |> PrefixedName

    /// <summary>
    ///   <para>gom:hasAnalysisFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Links to an RDF literal containing an embedded analysis file or a reference to such a file.</para>
    /// labels<para>has analysis file</para></remarks>
    /// <seealso href="https://w3id.org/gom#hasAnalysisFile">https://w3id.org/gom#hasAnalysisFile</seealso>
    let hasAnalysisFile = Prefixed_Name(gom, "hasAnalysisFile") |> PrefixedName
    /// <summary>
    ///   <para>gom:Rhinoceros_v6</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:gom#GeometryModellingApplication</para>
    ///
    /// labels<para>Rhinoceros v6 CAD application</para></remarks>
    /// <seealso href="https://w3id.org/gom#Rhinoceros_v6">https://w3id.org/gom#Rhinoceros_v6</seealso>
    let Rhinoceros_v6 = Prefixed_Name(gom, "Rhinoceros_v6") |> PrefixedName

    /// <summary>
    ///   <para>gom:fromCoordinateSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>links to an instance of gom:CoordinateSystem where the transformation results in</para>
    /// labels<para>from Coordinate System</para></remarks>
    /// <seealso href="https://w3id.org/gom#fromCoordinateSystem">https://w3id.org/gom#fromCoordinateSystem</seealso>
    let fromCoordinateSystem =
        Prefixed_Name(gom, "fromCoordinateSystem") |> PrefixedName

    /// <summary>
    ///   <para>gom:hasCoordinateSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Geometry description is defined in exactly one Coordinate System. This property links a omg:Geometry of omg:GeometryState instance to a gom:CoordinateSystem instance.</para>
    /// labels<para>has length unit</para></remarks>
    /// <seealso href="https://w3id.org/gom#hasCoordinateSystem">https://w3id.org/gom#hasCoordinateSystem</seealso>
    let hasCoordinateSystem = Prefixed_Name(gom, "hasCoordinateSystem") |> PrefixedName
    /// <summary>
    ///   <para>gom:hasEdges</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>the number of edges of a mesh geometry description</para>
    /// labels<para>has edges</para></remarks>
    /// <seealso href="https://w3id.org/gom#hasEdges">https://w3id.org/gom#hasEdges</seealso>
    let hasEdges = Prefixed_Name(gom, "hasEdges") |> PrefixedName
    /// <summary>
    ///   <para>gom:hasFaces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>the number of faces of a mesh geometry description</para>
    /// labels<para>has faces</para></remarks>
    /// <seealso href="https://w3id.org/gom#hasFaces">https://w3id.org/gom#hasFaces</seealso>
    let hasFaces = Prefixed_Name(gom, "hasFaces") |> PrefixedName
    /// <summary>
    ///   <para>gom:hasLengthUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Each Cartesian Coordinate System has exactly one length unit. If such a Coordinate System does not link to a length unit, it is assumed to be in metre.</para>
    /// labels<para>has length unit</para></remarks>
    /// <seealso href="https://w3id.org/gom#hasLengthUnit">https://w3id.org/gom#hasLengthUnit</seealso>
    let hasLengthUnit = Prefixed_Name(gom, "hasLengthUnit") |> PrefixedName

    /// <summary>
    ///   <para>gom:hasSimplifiedGeometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The simplified geometry of a gom:RepresentedAccuracyAnalysis that is compared with a survey geometry.</para>
    /// labels<para>has simplified geometry</para></remarks>
    /// <seealso href="https://w3id.org/gom#hasSimplifiedGeometry">https://w3id.org/gom#hasSimplifiedGeometry</seealso>
    let hasSimplifiedGeometry =
        Prefixed_Name(gom, "hasSimplifiedGeometry") |> PrefixedName

    /// <summary>
    ///   <para>gom:hasVertices</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>the number of vertices of a mesh or point cloud geometry description</para>
    /// labels<para>has vertices</para></remarks>
    /// <seealso href="https://w3id.org/gom#hasVertices">https://w3id.org/gom#hasVertices</seealso>
    let hasVertices = Prefixed_Name(gom, "hasVertices") |> PrefixedName

    /// <summary>
    ///   <para>gom:toCartesianCoordinateSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>links to an instance of gom:CartesianCoordinateSystem where the transformation is applied to</para>
    /// labels<para>to Cartesian Coordinate System</para></remarks>
    /// <seealso href="https://w3id.org/gom#toCartesianCoordinateSystem">https://w3id.org/gom#toCartesianCoordinateSystem</seealso>
    let toCartesianCoordinateSystem =
        Prefixed_Name(gom, "toCartesianCoordinateSystem") |> PrefixedName

    /// <summary>
    ///   <para>gom:totalLOA20</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The percentage of total relevant surface area of the simplified geometry that is occluded in LOA20 (50 mm &gt; deviation &gt; 15 mm)</para>
    /// labels<para>% of total surface area in LOA20</para></remarks>
    /// <seealso href="https://w3id.org/gom#totalLOA20">https://w3id.org/gom#totalLOA20</seealso>
    let totalLOA20 = Prefixed_Name(gom, "totalLOA20") |> PrefixedName
    /// <summary>
    ///   <para>gom:totalLOA40</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The percentage of total relevant surface area of the simplified geometry that is occluded in LOA40 (5 mm &gt; deviation &gt; 1 mm)</para>
    /// labels<para>% of total surface area in LOA40</para></remarks>
    /// <seealso href="https://w3id.org/gom#totalLOA40">https://w3id.org/gom#totalLOA40</seealso>
    let totalLOA40 = Prefixed_Name(gom, "totalLOA40") |> PrefixedName
    /// <summary>
    ///   <para>gom:hasVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>the volume of a volumetric (closed) geometry description. The units of this value are in m3</para>
    /// labels<para>has volume</para></remarks>
    /// <seealso href="https://w3id.org/gom#hasVolume">https://w3id.org/gom#hasVolume</seealso>
    let hasVolume = Prefixed_Name(gom, "hasVolume") |> PrefixedName

    /// <summary>
    ///   <para>gom:maxOcclusionDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The maximum calculated deviation distance to classify a point on the surface of the simplified geometry as being occluded. It is a setting of the represented accuracy analysis.</para>
    /// labels<para>max occlusion distance (mm)</para></remarks>
    /// <seealso href="https://w3id.org/gom#maxOcclusionDistance">https://w3id.org/gom#maxOcclusionDistance</seealso>
    let maxOcclusionDistance =
        Prefixed_Name(gom, "maxOcclusionDistance") |> PrefixedName

    /// <summary>
    ///   <para>gom:totalLOA10</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The percentage of total relevant surface area of the simplified geometry that is occluded in LOA10 (deviation &gt; 50 mm)</para>
    /// labels<para>% of total surface area in LOA10</para></remarks>
    /// <seealso href="https://w3id.org/gom#totalLOA10">https://w3id.org/gom#totalLOA10</seealso>
    let totalLOA10 = Prefixed_Name(gom, "totalLOA10") |> PrefixedName
    /// <summary>
    ///   <para>gom:totalOccluded</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The percentage of total relevant surface area of the simplified geometry that is occluded</para>
    /// labels<para>% occluded surface area</para></remarks>
    /// <seealso href="https://w3id.org/gom#totalOccluded">https://w3id.org/gom#totalOccluded</seealso>
    let totalOccluded = Prefixed_Name(gom, "totalOccluded") |> PrefixedName
    /// <summary>
    ///   <para>gom:totalLOA50</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The percentage of total relevant surface area of the simplified geometry that is occluded in LOA50 (1 mm &gt; deviation &gt; 0 mm)</para>
    /// labels<para>% of total surface area in LOA50</para></remarks>
    /// <seealso href="https://w3id.org/gom#totalLOA50">https://w3id.org/gom#totalLOA50</seealso>
    let totalLOA50 = Prefixed_Name(gom, "totalLOA50") |> PrefixedName
    /// <summary>
    ///   <para>gom:totalRelevant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The percentage of total relevant surface area of the simplified geometry</para>
    /// labels<para>% of total relevant surface area</para></remarks>
    /// <seealso href="https://w3id.org/gom#totalRelevant">https://w3id.org/gom#totalRelevant</seealso>
    let totalRelevant = Prefixed_Name(gom, "totalRelevant") |> PrefixedName

    /// <summary>
    ///   <para>gom:usedLocalModelMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>A boolean datatype property to express if the represented accuracy analysis method used a local model or not.</para>
    /// labels<para>used local model method</para></remarks>
    /// <seealso href="https://w3id.org/gom#usedLocalModelMethod">https://w3id.org/gom#usedLocalModelMethod</seealso>
    let usedLocalModelMethod =
        Prefixed_Name(gom, "usedLocalModelMethod") |> PrefixedName

    /// <summary>
    ///   <para>gom:hasFileSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>the file size of the geometry description in bytes. If the geometry description includes material and/or texture files, the size of these files is included.</para>
    /// labels<para>has file size</para></remarks>
    /// <seealso href="https://w3id.org/gom#hasFileSize">https://w3id.org/gom#hasFileSize</seealso>
    let hasFileSize = Prefixed_Name(gom, "hasFileSize") |> PrefixedName
    /// <summary>
    ///   <para>gom:hasSurfaceArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>the area of a volumetric (closed) geometry description. The units of this value are in m2</para>
    /// labels<para>has surface area</para></remarks>
    /// <seealso href="https://w3id.org/gom#hasSurfaceArea">https://w3id.org/gom#hasSurfaceArea</seealso>
    let hasSurfaceArea = Prefixed_Name(gom, "hasSurfaceArea") |> PrefixedName
    /// <summary>
    ///   <para>gom:hasSurveyGeometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The survey geometry where a gom:RepresentedAccuracyAnalysis starts from.</para>
    /// labels<para>has survey geometry</para></remarks>
    /// <seealso href="https://w3id.org/gom#hasSurveyGeometry">https://w3id.org/gom#hasSurveyGeometry</seealso>
    let hasSurveyGeometry = Prefixed_Name(gom, "hasSurveyGeometry") |> PrefixedName

    /// <summary>
    ///   <para>gom:hasTransformationMatrix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>has a single 4 X 4 transformation matrix. This datatype property links a gom:AffineCoordinateSystemTransformation to exactly one 4 X 4 transformation matrix M. Currently, two approaches can be used to define this matrix in one literal, i.e. using a JSON row major array (gom:rowMajorArray) or a column major array (gom:columnMajorArray).</para>
    /// labels<para>has a transformation matrix</para></remarks>
    /// <seealso href="https://w3id.org/gom#hasTransformationMatrix">https://w3id.org/gom#hasTransformationMatrix</seealso>
    let hasTransformationMatrix =
        Prefixed_Name(gom, "hasTransformationMatrix") |> PrefixedName

    /// <summary>
    ///   <para>gom:rowMajorArray</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>a JSON row major array representing a square matrix. An example in Turtle of a literal representing a 2 X 2 matrix M: "[m11,m12,m21,m22]"^^gom:rowMajorArray</para>
    /// labels<para>a row major array</para></remarks>
    /// <seealso href="https://w3id.org/gom#rowMajorArray">https://w3id.org/gom#rowMajorArray</seealso>
    let rowMajorArray = Prefixed_Name(gom, "rowMajorArray") |> PrefixedName

    /// <summary>
    ///   <para>gom:locallyTransformedByMatrix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Property to link a omg:Geometry, that transforms (omg:transformsGeometry) another omg:Geometry (prototype geometry), to an RDF literal containing the 4x4 transformation matrix. {@en}x</para>
    /// labels<para>locally transformed by</para></remarks>
    /// <seealso href="https://w3id.org/gom#locallyTransformedByMatrix">https://w3id.org/gom#locallyTransformedByMatrix</seealso>
    let locallyTransformedByMatrix =
        Prefixed_Name(gom, "locallyTransformedByMatrix") |> PrefixedName

    /// <summary>
    ///   <para>gom:toCoordinateSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>links an instance of gom:CoordinateSystemTransformation to an instance of gom:CoordinateSystem where the transformation is applied to</para>
    /// labels<para>from Coordinate System</para></remarks>
    /// <seealso href="https://w3id.org/gom#toCoordinateSystem">https://w3id.org/gom#toCoordinateSystem</seealso>
    let toCoordinateSystem = Prefixed_Name(gom, "toCoordinateSystem") |> PrefixedName

    /// <summary>
    ///   <para>gom:total95PercentUpperLimit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The total deviation limit in mm where 95% of the surface area complies with.</para>
    /// labels<para>total 95% deviation limit</para></remarks>
    /// <seealso href="https://w3id.org/gom#total95PercentUpperLimit">https://w3id.org/gom#total95PercentUpperLimit</seealso>
    let total95PercentUpperLimit =
        Prefixed_Name(gom, "total95PercentUpperLimit") |> PrefixedName

    /// <summary>
    ///   <para>gom:totalLOA30</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The percentage of total relevant surface area of the simplified geometry that is occluded in LOA30 (15 mm &gt; deviation &gt; 5 mm)</para>
    /// labels<para>% of total surface area in LOA30</para></remarks>
    /// <seealso href="https://w3id.org/gom#totalLOA30">https://w3id.org/gom#totalLOA30</seealso>
    let totalLOA30 = Prefixed_Name(gom, "totalLOA30") |> PrefixedName
