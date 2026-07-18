namespace http.www.opengis.net.ont.gml.hash

open DoxAletheia.Rdf_Vocabulary

module gml =
    let _namespace_name = "http://www.opengis.net/ont/gml#"

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#AbstractCurveSegment"></see>
    /// </summary>
    let AbstractCurveSegment =
        Namespaced_IRI.parse _namespace_name "AbstractCurveSegment" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#AbstractGeometricPrimitive"></see>
    /// </summary>
    let AbstractGeometricPrimitive =
        Namespaced_IRI.parse _namespace_name "AbstractGeometricPrimitive" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#AbstractGeometry"></see>
    /// </summary>
    let AbstractGeometry =
        Namespaced_IRI.parse _namespace_name "AbstractGeometry" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#AbstractGriddedSurface"></see>
    /// </summary>
    let AbstractGriddedSurface =
        Namespaced_IRI.parse _namespace_name "AbstractGriddedSurface" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#AbstractParametricCurveSurface"></see>
    /// </summary>
    let AbstractParametricCurveSurface =
        Namespaced_IRI.parse _namespace_name "AbstractParametricCurveSurface" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#AbstractSurfacePatch"></see>
    /// </summary>
    let AbstractSurfacePatch =
        Namespaced_IRI.parse _namespace_name "AbstractSurfacePatch" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#Arc"></see>
    /// </summary>
    let Arc = Namespaced_IRI.parse _namespace_name "Arc" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#ArcString"></see>
    /// </summary>
    let ArcString = Namespaced_IRI.parse _namespace_name "ArcString" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#ArcByBulge"></see>
    /// </summary>
    let ArcByBulge = Namespaced_IRI.parse _namespace_name "ArcByBulge" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#ArcStringByBulge"></see>
    /// </summary>
    let ArcStringByBulge =
        Namespaced_IRI.parse _namespace_name "ArcStringByBulge" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#ArcByCenterPoint"></see>
    /// </summary>
    let ArcByCenterPoint =
        Namespaced_IRI.parse _namespace_name "ArcByCenterPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#BSpline"></see>
    /// </summary>
    let BSpline = Namespaced_IRI.parse _namespace_name "BSpline" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#SplineCurve"></see>
    /// </summary>
    let SplineCurve =
        Namespaced_IRI.parse _namespace_name "SplineCurve" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#Bezier"></see>
    /// </summary>
    let Bezier = Namespaced_IRI.parse _namespace_name "Bezier" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#Circle"></see>
    /// </summary>
    let Circle = Namespaced_IRI.parse _namespace_name "Circle" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#CircleByCenterPoint"></see>
    /// </summary>
    let CircleByCenterPoint =
        Namespaced_IRI.parse _namespace_name "CircleByCenterPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#Clothoid"></see>
    /// </summary>
    let Clothoid = Namespaced_IRI.parse _namespace_name "Clothoid" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#Composite"></see>
    /// </summary>
    let Composite = Namespaced_IRI.parse _namespace_name "Composite" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#GeometricComplex"></see>
    /// </summary>
    let GeometricComplex =
        Namespaced_IRI.parse _namespace_name "GeometricComplex" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#CompositeCurve"></see>
    /// </summary>
    let CompositeCurve =
        Namespaced_IRI.parse _namespace_name "CompositeCurve" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#OrientableCurve"></see>
    /// </summary>
    let OrientableCurve =
        Namespaced_IRI.parse _namespace_name "OrientableCurve" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#CompositeSolid"></see>
    /// </summary>
    let CompositeSolid =
        Namespaced_IRI.parse _namespace_name "CompositeSolid" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#Solid"></see>
    /// </summary>
    let Solid = Namespaced_IRI.parse _namespace_name "Solid" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#CompositeSurface"></see>
    /// </summary>
    let CompositeSurface =
        Namespaced_IRI.parse _namespace_name "CompositeSurface" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#OrientableSurface"></see>
    /// </summary>
    let OrientableSurface =
        Namespaced_IRI.parse _namespace_name "OrientableSurface" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#Cone"></see>
    /// </summary>
    let Cone = Namespaced_IRI.parse _namespace_name "Cone" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#CubicSpline"></see>
    /// </summary>
    let CubicSpline =
        Namespaced_IRI.parse _namespace_name "CubicSpline" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#PolynomialSpline"></see>
    /// </summary>
    let PolynomialSpline =
        Namespaced_IRI.parse _namespace_name "PolynomialSpline" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#Curve"></see>
    /// </summary>
    let Curve = Namespaced_IRI.parse _namespace_name "Curve" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#Cylinder"></see>
    /// </summary>
    let Cylinder = Namespaced_IRI.parse _namespace_name "Cylinder" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#Geodesic"></see>
    /// </summary>
    let Geodesic = Namespaced_IRI.parse _namespace_name "Geodesic" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#GeodesicString"></see>
    /// </summary>
    let GeodesicString =
        Namespaced_IRI.parse _namespace_name "GeodesicString" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#LineString"></see>
    /// </summary>
    let LineString = Namespaced_IRI.parse _namespace_name "LineString" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#LineStringSegment"></see>
    /// </summary>
    let LineStringSegment =
        Namespaced_IRI.parse _namespace_name "LineStringSegment" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#LinearRing"></see>
    /// </summary>
    let LinearRing = Namespaced_IRI.parse _namespace_name "LinearRing" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#Ring"></see>
    /// </summary>
    let Ring = Namespaced_IRI.parse _namespace_name "Ring" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#MultiCurve"></see>
    /// </summary>
    let MultiCurve = Namespaced_IRI.parse _namespace_name "MultiCurve" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#MultiGeometry"></see>
    /// </summary>
    let MultiGeometry =
        Namespaced_IRI.parse _namespace_name "MultiGeometry" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#MultiPoint"></see>
    /// </summary>
    let MultiPoint = Namespaced_IRI.parse _namespace_name "MultiPoint" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#MultiSolid"></see>
    /// </summary>
    let MultiSolid = Namespaced_IRI.parse _namespace_name "MultiSolid" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#MultiSurface"></see>
    /// </summary>
    let MultiSurface =
        Namespaced_IRI.parse _namespace_name "MultiSurface" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#OffsetCurve"></see>
    /// </summary>
    let OffsetCurve =
        Namespaced_IRI.parse _namespace_name "OffsetCurve" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#Point"></see>
    /// </summary>
    let Point = Namespaced_IRI.parse _namespace_name "Point" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#Polygon"></see>
    /// </summary>
    let Polygon = Namespaced_IRI.parse _namespace_name "Polygon" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#Surface"></see>
    /// </summary>
    let Surface = Namespaced_IRI.parse _namespace_name "Surface" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#PolygonPatch"></see>
    /// </summary>
    let PolygonPatch =
        Namespaced_IRI.parse _namespace_name "PolygonPatch" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#PolyhedralSurface"></see>
    /// </summary>
    let PolyhedralSurface =
        Namespaced_IRI.parse _namespace_name "PolyhedralSurface" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#Rectangle"></see>
    /// </summary>
    let Rectangle = Namespaced_IRI.parse _namespace_name "Rectangle" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#Shell"></see>
    /// </summary>
    let Shell = Namespaced_IRI.parse _namespace_name "Shell" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#Sphere"></see>
    /// </summary>
    let Sphere = Namespaced_IRI.parse _namespace_name "Sphere" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#Tin"></see>
    /// </summary>
    let Tin = Namespaced_IRI.parse _namespace_name "Tin" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#TriangulatedSurface"></see>
    /// </summary>
    let TriangulatedSurface =
        Namespaced_IRI.parse _namespace_name "TriangulatedSurface" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.opengis.net/ont/gml#Triangle"></see>
    /// </summary>
    let Triangle = Namespaced_IRI.parse _namespace_name "Triangle" |> NamespacedName
