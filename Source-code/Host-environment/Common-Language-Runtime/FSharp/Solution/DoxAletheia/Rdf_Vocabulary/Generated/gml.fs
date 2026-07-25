namespace http.www.opengis.net.ont.gml.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module gml =
    let _namespace_iri = Namespace_Iri gml |> NamespaceIRI

    /// <summary>
    ///   <para>gml:AbstractCurveSegment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Abstract Curve Segment</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#AbstractCurveSegment">http://www.opengis.net/ont/gml#AbstractCurveSegment</seealso>
    let AbstractCurveSegment =
        Prefixed_Name(gml, "AbstractCurveSegment") |> PrefixedName

    /// <summary>
    ///   <para>gml:AbstractGriddedSurface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Abstract Gridded Surface</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#AbstractGriddedSurface">http://www.opengis.net/ont/gml#AbstractGriddedSurface</seealso>
    let AbstractGriddedSurface =
        Prefixed_Name(gml, "AbstractGriddedSurface") |> PrefixedName

    /// <summary>
    ///   <para>gml:Circle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Circle</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#Circle">http://www.opengis.net/ont/gml#Circle</seealso>
    let Circle = Prefixed_Name(gml, "Circle") |> PrefixedName
    /// <summary>
    ///   <para>gml:CompositeCurve</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Composite Curve</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#CompositeCurve">http://www.opengis.net/ont/gml#CompositeCurve</seealso>
    let CompositeCurve = Prefixed_Name(gml, "CompositeCurve") |> PrefixedName
    /// <summary>
    ///   <para>gml:Solid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Solid</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#Solid">http://www.opengis.net/ont/gml#Solid</seealso>
    let Solid = Prefixed_Name(gml, "Solid") |> PrefixedName
    /// <summary>
    ///   <para>gml:CompositeSurface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Composite Surface</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#CompositeSurface">http://www.opengis.net/ont/gml#CompositeSurface</seealso>
    let CompositeSurface = Prefixed_Name(gml, "CompositeSurface") |> PrefixedName
    /// <summary>
    ///   <para>gml:CubicSpline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Cubic Spline</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#CubicSpline">http://www.opengis.net/ont/gml#CubicSpline</seealso>
    let CubicSpline = Prefixed_Name(gml, "CubicSpline") |> PrefixedName
    /// <summary>
    ///   <para>gml:Curve</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Curve</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#Curve">http://www.opengis.net/ont/gml#Curve</seealso>
    let Curve = Prefixed_Name(gml, "Curve") |> PrefixedName
    /// <summary>
    ///   <para>gml:Geodesic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Geodesic</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#Geodesic">http://www.opengis.net/ont/gml#Geodesic</seealso>
    let Geodesic = Prefixed_Name(gml, "Geodesic") |> PrefixedName

    /// <summary>
    ///   <para>gml:AbstractGeometricPrimitive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Abstract Geometric Primitive</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#AbstractGeometricPrimitive">http://www.opengis.net/ont/gml#AbstractGeometricPrimitive</seealso>
    let AbstractGeometricPrimitive =
        Prefixed_Name(gml, "AbstractGeometricPrimitive") |> PrefixedName

    /// <summary>
    ///   <para>gml:AbstractParametricCurveSurface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Abstract Parametric Curve Surface</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#AbstractParametricCurveSurface">http://www.opengis.net/ont/gml#AbstractParametricCurveSurface</seealso>
    let AbstractParametricCurveSurface =
        Prefixed_Name(gml, "AbstractParametricCurveSurface") |> PrefixedName

    /// <summary>
    ///   <para>gml:Arc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Arc</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#Arc">http://www.opengis.net/ont/gml#Arc</seealso>
    let Arc = Prefixed_Name(gml, "Arc") |> PrefixedName
    /// <summary>
    ///   <para>gml:ArcByBulge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Arc by Bulge</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#ArcByBulge">http://www.opengis.net/ont/gml#ArcByBulge</seealso>
    let ArcByBulge = Prefixed_Name(gml, "ArcByBulge") |> PrefixedName
    /// <summary>
    ///   <para>gml:Shell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Shell</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#Shell">http://www.opengis.net/ont/gml#Shell</seealso>
    let Shell = Prefixed_Name(gml, "Shell") |> PrefixedName
    /// <summary>
    ///   <para>gml:ArcString</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Arc String</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#ArcString">http://www.opengis.net/ont/gml#ArcString</seealso>
    let ArcString = Prefixed_Name(gml, "ArcString") |> PrefixedName
    /// <summary>
    ///   <para>gml:BSpline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>BSpline</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#BSpline">http://www.opengis.net/ont/gml#BSpline</seealso>
    let BSpline = Prefixed_Name(gml, "BSpline") |> PrefixedName

    /// <summary>
    ///   <para>gml:AbstractSurfacePatch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Abstract Surface Patch</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#AbstractSurfacePatch">http://www.opengis.net/ont/gml#AbstractSurfacePatch</seealso>
    let AbstractSurfacePatch =
        Prefixed_Name(gml, "AbstractSurfacePatch") |> PrefixedName

    /// <summary>
    ///   <para>gml:ArcStringByBulge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Arc String by Bulge</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#ArcStringByBulge">http://www.opengis.net/ont/gml#ArcStringByBulge</seealso>
    let ArcStringByBulge = Prefixed_Name(gml, "ArcStringByBulge") |> PrefixedName
    /// <summary>
    ///   <para>gml:Bezier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Bezier</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#Bezier">http://www.opengis.net/ont/gml#Bezier</seealso>
    let Bezier = Prefixed_Name(gml, "Bezier") |> PrefixedName
    /// <summary>
    ///   <para>gml:Clothoid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Clothoid</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#Clothoid">http://www.opengis.net/ont/gml#Clothoid</seealso>
    let Clothoid = Prefixed_Name(gml, "Clothoid") |> PrefixedName
    /// <summary>
    ///   <para>gml:Composite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Composite</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#Composite">http://www.opengis.net/ont/gml#Composite</seealso>
    let Composite = Prefixed_Name(gml, "Composite") |> PrefixedName
    /// <summary>
    ///   <para>gml:OrientableSurface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Orientable Surface</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#OrientableSurface">http://www.opengis.net/ont/gml#OrientableSurface</seealso>
    let OrientableSurface = Prefixed_Name(gml, "OrientableSurface") |> PrefixedName
    /// <summary>
    ///   <para>gml:ArcByCenterPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Arc by Center Point</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#ArcByCenterPoint">http://www.opengis.net/ont/gml#ArcByCenterPoint</seealso>
    let ArcByCenterPoint = Prefixed_Name(gml, "ArcByCenterPoint") |> PrefixedName
    /// <summary>
    ///   <para>gml:SplineCurve</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Spline Curve</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#SplineCurve">http://www.opengis.net/ont/gml#SplineCurve</seealso>
    let SplineCurve = Prefixed_Name(gml, "SplineCurve") |> PrefixedName
    /// <summary>
    ///   <para>gml:OrientableCurve</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Orientable Curve</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#OrientableCurve">http://www.opengis.net/ont/gml#OrientableCurve</seealso>
    let OrientableCurve = Prefixed_Name(gml, "OrientableCurve") |> PrefixedName
    /// <summary>
    ///   <para>gml:PolynomialSpline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Polynomial Spline</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#PolynomialSpline">http://www.opengis.net/ont/gml#PolynomialSpline</seealso>
    let PolynomialSpline = Prefixed_Name(gml, "PolynomialSpline") |> PrefixedName
    /// <summary>
    ///   <para>gml:GeodesicString</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Geodesic String</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#GeodesicString">http://www.opengis.net/ont/gml#GeodesicString</seealso>
    let GeodesicString = Prefixed_Name(gml, "GeodesicString") |> PrefixedName
    /// <summary>
    ///   <para>gml:LineString</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Line String</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#LineString">http://www.opengis.net/ont/gml#LineString</seealso>
    let LineString = Prefixed_Name(gml, "LineString") |> PrefixedName
    /// <summary>
    ///   <para>gml:Ring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Ring</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#Ring">http://www.opengis.net/ont/gml#Ring</seealso>
    let Ring = Prefixed_Name(gml, "Ring") |> PrefixedName
    /// <summary>
    ///   <para>gml:MultiPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Multi-Point</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#MultiPoint">http://www.opengis.net/ont/gml#MultiPoint</seealso>
    let MultiPoint = Prefixed_Name(gml, "MultiPoint") |> PrefixedName
    /// <summary>
    ///   <para>gml:MultiSurface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Multi-Surface</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#MultiSurface">http://www.opengis.net/ont/gml#MultiSurface</seealso>
    let MultiSurface = Prefixed_Name(gml, "MultiSurface") |> PrefixedName
    /// <summary>
    ///   <para>gml:Polygon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Polygon</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#Polygon">http://www.opengis.net/ont/gml#Polygon</seealso>
    let Polygon = Prefixed_Name(gml, "Polygon") |> PrefixedName
    /// <summary>
    ///   <para>gml:PolyhedralSurface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Polyhedral Surface</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#PolyhedralSurface">http://www.opengis.net/ont/gml#PolyhedralSurface</seealso>
    let PolyhedralSurface = Prefixed_Name(gml, "PolyhedralSurface") |> PrefixedName
    /// <summary>
    ///   <para>gml:CircleByCenterPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>CircleByCenterPoint</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#CircleByCenterPoint">http://www.opengis.net/ont/gml#CircleByCenterPoint</seealso>
    let CircleByCenterPoint = Prefixed_Name(gml, "CircleByCenterPoint") |> PrefixedName
    /// <summary>
    ///   <para>gml:GeometricComplex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Geometric Complex</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#GeometricComplex">http://www.opengis.net/ont/gml#GeometricComplex</seealso>
    let GeometricComplex = Prefixed_Name(gml, "GeometricComplex") |> PrefixedName
    /// <summary>
    ///   <para>gml:CompositeSolid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Composite Solid</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#CompositeSolid">http://www.opengis.net/ont/gml#CompositeSolid</seealso>
    let CompositeSolid = Prefixed_Name(gml, "CompositeSolid") |> PrefixedName
    /// <summary>
    ///   <para>gml:Cone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Cone</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#Cone">http://www.opengis.net/ont/gml#Cone</seealso>
    let Cone = Prefixed_Name(gml, "Cone") |> PrefixedName
    /// <summary>
    ///   <para>gml:Cylinder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Cylinder</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#Cylinder">http://www.opengis.net/ont/gml#Cylinder</seealso>
    let Cylinder = Prefixed_Name(gml, "Cylinder") |> PrefixedName
    /// <summary>
    ///   <para>gml:LineStringSegment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Line String Segment</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#LineStringSegment">http://www.opengis.net/ont/gml#LineStringSegment</seealso>
    let LineStringSegment = Prefixed_Name(gml, "LineStringSegment") |> PrefixedName
    /// <summary>
    ///   <para>gml:MultiCurve</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Multi-Curve</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#MultiCurve">http://www.opengis.net/ont/gml#MultiCurve</seealso>
    let MultiCurve = Prefixed_Name(gml, "MultiCurve") |> PrefixedName
    /// <summary>
    ///   <para>gml:MultiSolid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Multi-Solid</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#MultiSolid">http://www.opengis.net/ont/gml#MultiSolid</seealso>
    let MultiSolid = Prefixed_Name(gml, "MultiSolid") |> PrefixedName
    /// <summary>
    ///   <para>gml:OffsetCurve</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Offset Curve</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#OffsetCurve">http://www.opengis.net/ont/gml#OffsetCurve</seealso>
    let OffsetCurve = Prefixed_Name(gml, "OffsetCurve") |> PrefixedName
    /// <summary>
    ///   <para>gml:Point</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Point</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#Point">http://www.opengis.net/ont/gml#Point</seealso>
    let Point = Prefixed_Name(gml, "Point") |> PrefixedName
    /// <summary>
    ///   <para>gml:Surface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Surface</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#Surface">http://www.opengis.net/ont/gml#Surface</seealso>
    let Surface = Prefixed_Name(gml, "Surface") |> PrefixedName
    /// <summary>
    ///   <para>gml:LinearRing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Linear Ring</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#LinearRing">http://www.opengis.net/ont/gml#LinearRing</seealso>
    let LinearRing = Prefixed_Name(gml, "LinearRing") |> PrefixedName
    /// <summary>
    ///   <para>gml:MultiGeometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Multi-Geometry</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#MultiGeometry">http://www.opengis.net/ont/gml#MultiGeometry</seealso>
    let MultiGeometry = Prefixed_Name(gml, "MultiGeometry") |> PrefixedName
    /// <summary>
    ///   <para>gml:PolygonPatch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Polygon Patch</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#PolygonPatch">http://www.opengis.net/ont/gml#PolygonPatch</seealso>
    let PolygonPatch = Prefixed_Name(gml, "PolygonPatch") |> PrefixedName
    /// <summary>
    ///   <para>gml:Rectangle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Rectangle</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#Rectangle">http://www.opengis.net/ont/gml#Rectangle</seealso>
    let Rectangle = Prefixed_Name(gml, "Rectangle") |> PrefixedName
    /// <summary>
    ///   <para>gml:Tin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Triangulated Irregular Network</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#Tin">http://www.opengis.net/ont/gml#Tin</seealso>
    let Tin = Prefixed_Name(gml, "Tin") |> PrefixedName
    /// <summary>
    ///   <para>gml:TriangulatedSurface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Triangulated Surface</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#TriangulatedSurface">http://www.opengis.net/ont/gml#TriangulatedSurface</seealso>
    let TriangulatedSurface = Prefixed_Name(gml, "TriangulatedSurface") |> PrefixedName
    /// <summary>
    ///   <para>gml:Sphere</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Sphere</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#Sphere">http://www.opengis.net/ont/gml#Sphere</seealso>
    let Sphere = Prefixed_Name(gml, "Sphere") |> PrefixedName
    /// <summary>
    ///   <para>gml:Triangle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Triangle</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#Triangle">http://www.opengis.net/ont/gml#Triangle</seealso>
    let Triangle = Prefixed_Name(gml, "Triangle") |> PrefixedName
    /// <summary>
    ///   <para>gml:AbstractGeometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Abstract Geometry</para></remarks>
    /// <seealso href="http://www.opengis.net/ont/gml#AbstractGeometry">http://www.opengis.net/ont/gml#AbstractGeometry</seealso>
    let AbstractGeometry = Prefixed_Name(gml, "AbstractGeometry") |> PrefixedName
