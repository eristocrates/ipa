#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module gml =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.opengis.net/ont/gml#" "gml"
    /// <summary>
    ///   <para>rdfs:label : Abstract Curve Segment</para>
    ///   <a href="http://www.opengis.net/ont/gml#AbstractCurveSegment">gml:AbstractCurveSegment</a>
    /// </summary>
    let AbstractCurveSegment = _prefixId.prefix "AbstractCurveSegment"
    /// <summary>
    ///   <para>rdfs:label : Abstract Geometric Primitive</para>
    ///   <a href="http://www.opengis.net/ont/gml#AbstractGeometricPrimitive">gml:AbstractGeometricPrimitive</a>
    /// </summary>
    let AbstractGeometricPrimitive = _prefixId.prefix "AbstractGeometricPrimitive"
    /// <summary>
    ///   <para>rdfs:label : Abstract Geometry</para>
    ///   <a href="http://www.opengis.net/ont/gml#AbstractGeometry">gml:AbstractGeometry</a>
    /// </summary>
    let AbstractGeometry = _prefixId.prefix "AbstractGeometry"
    /// <summary>
    ///   <para>rdfs:label : Abstract Gridded Surface</para>
    ///   <a href="http://www.opengis.net/ont/gml#AbstractGriddedSurface">gml:AbstractGriddedSurface</a>
    /// </summary>
    let AbstractGriddedSurface = _prefixId.prefix "AbstractGriddedSurface"

    /// <summary>
    ///   <para>rdfs:label : Abstract Parametric Curve Surface</para>
    ///   <a href="http://www.opengis.net/ont/gml#AbstractParametricCurveSurface">gml:AbstractParametricCurveSurface</a>
    /// </summary>
    let AbstractParametricCurveSurface =
        _prefixId.prefix "AbstractParametricCurveSurface"

    /// <summary>
    ///   <para>rdfs:label : Abstract Surface Patch</para>
    ///   <a href="http://www.opengis.net/ont/gml#AbstractSurfacePatch">gml:AbstractSurfacePatch</a>
    /// </summary>
    let AbstractSurfacePatch = _prefixId.prefix "AbstractSurfacePatch"
    /// <summary>
    ///   <para>rdfs:label : Arc</para>
    ///   <a href="http://www.opengis.net/ont/gml#Arc">gml:Arc</a>
    /// </summary>
    let Arc = _prefixId.prefix "Arc"
    /// <summary>
    ///   <para>rdfs:label : Arc by Bulge</para>
    ///   <a href="http://www.opengis.net/ont/gml#ArcByBulge">gml:ArcByBulge</a>
    /// </summary>
    let ArcByBulge = _prefixId.prefix "ArcByBulge"
    /// <summary>
    ///   <para>rdfs:label : Arc by Center Point</para>
    ///   <a href="http://www.opengis.net/ont/gml#ArcByCenterPoint">gml:ArcByCenterPoint</a>
    /// </summary>
    let ArcByCenterPoint = _prefixId.prefix "ArcByCenterPoint"
    /// <summary>
    ///   <para>rdfs:label : Arc String</para>
    ///   <a href="http://www.opengis.net/ont/gml#ArcString">gml:ArcString</a>
    /// </summary>
    let ArcString = _prefixId.prefix "ArcString"
    /// <summary>
    ///   <para>rdfs:label : Arc String by Bulge</para>
    ///   <a href="http://www.opengis.net/ont/gml#ArcStringByBulge">gml:ArcStringByBulge</a>
    /// </summary>
    let ArcStringByBulge = _prefixId.prefix "ArcStringByBulge"
    /// <summary>
    ///   <para>rdfs:label : BSpline</para>
    ///   <a href="http://www.opengis.net/ont/gml#BSpline">gml:BSpline</a>
    /// </summary>
    let BSpline = _prefixId.prefix "BSpline"
    /// <summary>
    ///   <para>rdfs:label : Bezier</para>
    ///   <a href="http://www.opengis.net/ont/gml#Bezier">gml:Bezier</a>
    /// </summary>
    let Bezier = _prefixId.prefix "Bezier"
    /// <summary>
    ///   <para>rdfs:label : Circle</para>
    ///   <a href="http://www.opengis.net/ont/gml#Circle">gml:Circle</a>
    /// </summary>
    let Circle = _prefixId.prefix "Circle"
    /// <summary>
    ///   <para>rdfs:label : CircleByCenterPoint</para>
    ///   <a href="http://www.opengis.net/ont/gml#CircleByCenterPoint">gml:CircleByCenterPoint</a>
    /// </summary>
    let CircleByCenterPoint = _prefixId.prefix "CircleByCenterPoint"
    /// <summary>
    ///   <para>rdfs:label : Clothoid</para>
    ///   <a href="http://www.opengis.net/ont/gml#Clothoid">gml:Clothoid</a>
    /// </summary>
    let Clothoid = _prefixId.prefix "Clothoid"
    /// <summary>
    ///   <para>rdfs:label : Composite</para>
    ///   <a href="http://www.opengis.net/ont/gml#Composite">gml:Composite</a>
    /// </summary>
    let Composite = _prefixId.prefix "Composite"
    /// <summary>
    ///   <para>rdfs:label : Composite Curve</para>
    ///   <a href="http://www.opengis.net/ont/gml#CompositeCurve">gml:CompositeCurve</a>
    /// </summary>
    let CompositeCurve = _prefixId.prefix "CompositeCurve"
    /// <summary>
    ///   <para>rdfs:label : Composite Solid</para>
    ///   <a href="http://www.opengis.net/ont/gml#CompositeSolid">gml:CompositeSolid</a>
    /// </summary>
    let CompositeSolid = _prefixId.prefix "CompositeSolid"
    /// <summary>
    ///   <para>rdfs:label : Composite Surface</para>
    ///   <a href="http://www.opengis.net/ont/gml#CompositeSurface">gml:CompositeSurface</a>
    /// </summary>
    let CompositeSurface = _prefixId.prefix "CompositeSurface"
    /// <summary>
    ///   <para>rdfs:label : Cone</para>
    ///   <a href="http://www.opengis.net/ont/gml#Cone">gml:Cone</a>
    /// </summary>
    let Cone = _prefixId.prefix "Cone"
    /// <summary>
    ///   <para>rdfs:label : Cubic Spline</para>
    ///   <a href="http://www.opengis.net/ont/gml#CubicSpline">gml:CubicSpline</a>
    /// </summary>
    let CubicSpline = _prefixId.prefix "CubicSpline"
    /// <summary>
    ///   <para>rdfs:label : Curve</para>
    ///   <a href="http://www.opengis.net/ont/gml#Curve">gml:Curve</a>
    /// </summary>
    let Curve = _prefixId.prefix "Curve"
    /// <summary>
    ///   <para>rdfs:label : Cylinder</para>
    ///   <a href="http://www.opengis.net/ont/gml#Cylinder">gml:Cylinder</a>
    /// </summary>
    let Cylinder = _prefixId.prefix "Cylinder"
    /// <summary>
    ///   <para>rdfs:label : Geodesic</para>
    ///   <a href="http://www.opengis.net/ont/gml#Geodesic">gml:Geodesic</a>
    /// </summary>
    let Geodesic = _prefixId.prefix "Geodesic"
    /// <summary>
    ///   <para>rdfs:label : Geodesic String</para>
    ///   <a href="http://www.opengis.net/ont/gml#GeodesicString">gml:GeodesicString</a>
    /// </summary>
    let GeodesicString = _prefixId.prefix "GeodesicString"
    /// <summary>
    ///   <para>rdfs:label : Geometric Complex</para>
    ///   <a href="http://www.opengis.net/ont/gml#GeometricComplex">gml:GeometricComplex</a>
    /// </summary>
    let GeometricComplex = _prefixId.prefix "GeometricComplex"
    /// <summary>
    ///   <para>rdfs:label : Line String</para>
    ///   <a href="http://www.opengis.net/ont/gml#LineString">gml:LineString</a>
    /// </summary>
    let LineString = _prefixId.prefix "LineString"
    /// <summary>
    ///   <para>rdfs:label : Line String Segment</para>
    ///   <a href="http://www.opengis.net/ont/gml#LineStringSegment">gml:LineStringSegment</a>
    /// </summary>
    let LineStringSegment = _prefixId.prefix "LineStringSegment"
    /// <summary>
    ///   <para>rdfs:label : Linear Ring</para>
    ///   <a href="http://www.opengis.net/ont/gml#LinearRing">gml:LinearRing</a>
    /// </summary>
    let LinearRing = _prefixId.prefix "LinearRing"
    /// <summary>
    ///   <para>rdfs:label : Multi-Curve</para>
    ///   <a href="http://www.opengis.net/ont/gml#MultiCurve">gml:MultiCurve</a>
    /// </summary>
    let MultiCurve = _prefixId.prefix "MultiCurve"
    /// <summary>
    ///   <para>rdfs:label : Multi-Geometry</para>
    ///   <a href="http://www.opengis.net/ont/gml#MultiGeometry">gml:MultiGeometry</a>
    /// </summary>
    let MultiGeometry = _prefixId.prefix "MultiGeometry"
    /// <summary>
    ///   <para>rdfs:label : Multi-Point</para>
    ///   <a href="http://www.opengis.net/ont/gml#MultiPoint">gml:MultiPoint</a>
    /// </summary>
    let MultiPoint = _prefixId.prefix "MultiPoint"
    /// <summary>
    ///   <para>rdfs:label : Multi-Solid</para>
    ///   <a href="http://www.opengis.net/ont/gml#MultiSolid">gml:MultiSolid</a>
    /// </summary>
    let MultiSolid = _prefixId.prefix "MultiSolid"
    /// <summary>
    ///   <para>rdfs:label : Multi-Surface</para>
    ///   <a href="http://www.opengis.net/ont/gml#MultiSurface">gml:MultiSurface</a>
    /// </summary>
    let MultiSurface = _prefixId.prefix "MultiSurface"
    /// <summary>
    ///   <para>rdfs:label : Offset Curve</para>
    ///   <a href="http://www.opengis.net/ont/gml#OffsetCurve">gml:OffsetCurve</a>
    /// </summary>
    let OffsetCurve = _prefixId.prefix "OffsetCurve"
    /// <summary>
    ///   <para>rdfs:label : Orientable Curve</para>
    ///   <a href="http://www.opengis.net/ont/gml#OrientableCurve">gml:OrientableCurve</a>
    /// </summary>
    let OrientableCurve = _prefixId.prefix "OrientableCurve"
    /// <summary>
    ///   <para>rdfs:label : Orientable Surface</para>
    ///   <a href="http://www.opengis.net/ont/gml#OrientableSurface">gml:OrientableSurface</a>
    /// </summary>
    let OrientableSurface = _prefixId.prefix "OrientableSurface"
    /// <summary>
    ///   <para>rdfs:label : Point</para>
    ///   <a href="http://www.opengis.net/ont/gml#Point">gml:Point</a>
    /// </summary>
    let Point = _prefixId.prefix "Point"
    /// <summary>
    ///   <para>rdfs:label : Polygon</para>
    ///   <a href="http://www.opengis.net/ont/gml#Polygon">gml:Polygon</a>
    /// </summary>
    let Polygon = _prefixId.prefix "Polygon"
    /// <summary>
    ///   <para>rdfs:label : Polygon Patch</para>
    ///   <a href="http://www.opengis.net/ont/gml#PolygonPatch">gml:PolygonPatch</a>
    /// </summary>
    let PolygonPatch = _prefixId.prefix "PolygonPatch"
    /// <summary>
    ///   <para>rdfs:label : Polyhedral Surface</para>
    ///   <a href="http://www.opengis.net/ont/gml#PolyhedralSurface">gml:PolyhedralSurface</a>
    /// </summary>
    let PolyhedralSurface = _prefixId.prefix "PolyhedralSurface"
    /// <summary>
    ///   <para>rdfs:label : Polynomial Spline</para>
    ///   <a href="http://www.opengis.net/ont/gml#PolynomialSpline">gml:PolynomialSpline</a>
    /// </summary>
    let PolynomialSpline = _prefixId.prefix "PolynomialSpline"
    /// <summary>
    ///   <para>rdfs:label : Rectangle</para>
    ///   <a href="http://www.opengis.net/ont/gml#Rectangle">gml:Rectangle</a>
    /// </summary>
    let Rectangle = _prefixId.prefix "Rectangle"
    /// <summary>
    ///   <para>rdfs:label : Ring</para>
    ///   <a href="http://www.opengis.net/ont/gml#Ring">gml:Ring</a>
    /// </summary>
    let Ring = _prefixId.prefix "Ring"
    /// <summary>
    ///   <para>rdfs:label : Shell</para>
    ///   <a href="http://www.opengis.net/ont/gml#Shell">gml:Shell</a>
    /// </summary>
    let Shell = _prefixId.prefix "Shell"
    /// <summary>
    ///   <para>rdfs:label : Solid</para>
    ///   <a href="http://www.opengis.net/ont/gml#Solid">gml:Solid</a>
    /// </summary>
    let Solid = _prefixId.prefix "Solid"
    /// <summary>
    ///   <para>rdfs:label : Sphere</para>
    ///   <a href="http://www.opengis.net/ont/gml#Sphere">gml:Sphere</a>
    /// </summary>
    let Sphere = _prefixId.prefix "Sphere"
    /// <summary>
    ///   <para>rdfs:label : Spline Curve</para>
    ///   <a href="http://www.opengis.net/ont/gml#SplineCurve">gml:SplineCurve</a>
    /// </summary>
    let SplineCurve = _prefixId.prefix "SplineCurve"
    /// <summary>
    ///   <para>rdfs:label : Surface</para>
    ///   <a href="http://www.opengis.net/ont/gml#Surface">gml:Surface</a>
    /// </summary>
    let Surface = _prefixId.prefix "Surface"
    /// <summary>
    ///   <para>rdfs:label : Triangulated Irregular Network</para>
    ///   <a href="http://www.opengis.net/ont/gml#Tin">gml:Tin</a>
    /// </summary>
    let Tin = _prefixId.prefix "Tin"
    /// <summary>
    ///   <para>rdfs:label : Triangle</para>
    ///   <a href="http://www.opengis.net/ont/gml#Triangle">gml:Triangle</a>
    /// </summary>
    let Triangle = _prefixId.prefix "Triangle"
    /// <summary>
    ///   <para>rdfs:label : Triangulated Surface</para>
    ///   <a href="http://www.opengis.net/ont/gml#TriangulatedSurface">gml:TriangulatedSurface</a>
    /// </summary>
    let TriangulatedSurface = _prefixId.prefix "TriangulatedSurface"
