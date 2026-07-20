namespace http.www.opengis.net.ont.gml.hash

open DoxAletheia

module gml =
    let _namespace_name = "http://www.opengis.net/ont/gml#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#AbstractCurveSegment"></see>
    /// </summary>
    let AbstractCurveSegment = _prefix "AbstractCurveSegment"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#AbstractGeometricPrimitive"></see>
    /// </summary>
    let AbstractGeometricPrimitive = _prefix "AbstractGeometricPrimitive"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#AbstractGeometry"></see>
    /// </summary>
    let AbstractGeometry = _prefix "AbstractGeometry"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#AbstractGriddedSurface"></see>
    /// </summary>
    let AbstractGriddedSurface = _prefix "AbstractGriddedSurface"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#AbstractParametricCurveSurface"></see>
    /// </summary>
    let AbstractParametricCurveSurface = _prefix "AbstractParametricCurveSurface"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#AbstractSurfacePatch"></see>
    /// </summary>
    let AbstractSurfacePatch = _prefix "AbstractSurfacePatch"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#Arc"></see>
    /// </summary>
    let Arc = _prefix "Arc"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#ArcString"></see>
    /// </summary>
    let ArcString = _prefix "ArcString"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#ArcByBulge"></see>
    /// </summary>
    let ArcByBulge = _prefix "ArcByBulge"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#ArcStringByBulge"></see>
    /// </summary>
    let ArcStringByBulge = _prefix "ArcStringByBulge"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#ArcByCenterPoint"></see>
    /// </summary>
    let ArcByCenterPoint = _prefix "ArcByCenterPoint"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#BSpline"></see>
    /// </summary>
    let BSpline = _prefix "BSpline"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#SplineCurve"></see>
    /// </summary>
    let SplineCurve = _prefix "SplineCurve"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#Bezier"></see>
    /// </summary>
    let Bezier = _prefix "Bezier"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#Circle"></see>
    /// </summary>
    let Circle = _prefix "Circle"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#CircleByCenterPoint"></see>
    /// </summary>
    let CircleByCenterPoint = _prefix "CircleByCenterPoint"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#Clothoid"></see>
    /// </summary>
    let Clothoid = _prefix "Clothoid"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#Composite"></see>
    /// </summary>
    let Composite = _prefix "Composite"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#GeometricComplex"></see>
    /// </summary>
    let GeometricComplex = _prefix "GeometricComplex"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#CompositeCurve"></see>
    /// </summary>
    let CompositeCurve = _prefix "CompositeCurve"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#OrientableCurve"></see>
    /// </summary>
    let OrientableCurve = _prefix "OrientableCurve"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#CompositeSolid"></see>
    /// </summary>
    let CompositeSolid = _prefix "CompositeSolid"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#Solid"></see>
    /// </summary>
    let Solid = _prefix "Solid"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#CompositeSurface"></see>
    /// </summary>
    let CompositeSurface = _prefix "CompositeSurface"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#OrientableSurface"></see>
    /// </summary>
    let OrientableSurface = _prefix "OrientableSurface"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#Cone"></see>
    /// </summary>
    let Cone = _prefix "Cone"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#CubicSpline"></see>
    /// </summary>
    let CubicSpline = _prefix "CubicSpline"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#PolynomialSpline"></see>
    /// </summary>
    let PolynomialSpline = _prefix "PolynomialSpline"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#Curve"></see>
    /// </summary>
    let Curve = _prefix "Curve"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#Cylinder"></see>
    /// </summary>
    let Cylinder = _prefix "Cylinder"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#Geodesic"></see>
    /// </summary>
    let Geodesic = _prefix "Geodesic"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#GeodesicString"></see>
    /// </summary>
    let GeodesicString = _prefix "GeodesicString"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#LineString"></see>
    /// </summary>
    let LineString = _prefix "LineString"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#LineStringSegment"></see>
    /// </summary>
    let LineStringSegment = _prefix "LineStringSegment"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#LinearRing"></see>
    /// </summary>
    let LinearRing = _prefix "LinearRing"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#Ring"></see>
    /// </summary>
    let Ring = _prefix "Ring"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#MultiCurve"></see>
    /// </summary>
    let MultiCurve = _prefix "MultiCurve"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#MultiGeometry"></see>
    /// </summary>
    let MultiGeometry = _prefix "MultiGeometry"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#MultiPoint"></see>
    /// </summary>
    let MultiPoint = _prefix "MultiPoint"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#MultiSolid"></see>
    /// </summary>
    let MultiSolid = _prefix "MultiSolid"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#MultiSurface"></see>
    /// </summary>
    let MultiSurface = _prefix "MultiSurface"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#OffsetCurve"></see>
    /// </summary>
    let OffsetCurve = _prefix "OffsetCurve"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#Point"></see>
    /// </summary>
    let Point = _prefix "Point"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#Polygon"></see>
    /// </summary>
    let Polygon = _prefix "Polygon"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#Surface"></see>
    /// </summary>
    let Surface = _prefix "Surface"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#PolygonPatch"></see>
    /// </summary>
    let PolygonPatch = _prefix "PolygonPatch"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#PolyhedralSurface"></see>
    /// </summary>
    let PolyhedralSurface = _prefix "PolyhedralSurface"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#Rectangle"></see>
    /// </summary>
    let Rectangle = _prefix "Rectangle"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#Shell"></see>
    /// </summary>
    let Shell = _prefix "Shell"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#Sphere"></see>
    /// </summary>
    let Sphere = _prefix "Sphere"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#Tin"></see>
    /// </summary>
    let Tin = _prefix "Tin"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#TriangulatedSurface"></see>
    /// </summary>
    let TriangulatedSurface = _prefix "TriangulatedSurface"
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#Triangle"></see>
    /// </summary>
    let Triangle = _prefix "Triangle"
