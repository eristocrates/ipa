namespace http.def.seegrid.csiro.au.isotc211.iso19107._2003.geometry.hash

open DoxAletheia.Rdf_Vocabulary

module gm =
    let _namespace_name = "http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Curve"></see>
    /// </summary>
    let Curve = Namespaced_IRI.parse _namespace_name "Curve" |> NamespacedName
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Surface"></see>
    /// </summary>
    let Surface = Namespaced_IRI.parse _namespace_name "Surface" |> NamespacedName
    /// <summary>
    /// GM_Object (Figure 6) is the root class of the geometric object taxonomy and supports interfaces common to all geographically referenced geometric objects. GM_Object instances are sets of direct positions in a particular coordinate reference system. A GM_Object can be regarded as an infinite set of points that satisfies the set operation interfaces for a set of direct positions, TransfiniteSet&lt;DirectPosition&gt;. Since an infinite collection class cannot be implemented directly, a Boolean test for inclusion shall be provided by the GM_Object interface. This international standard concentrates on vector geometry classes, but future work may use GM_Object as a root class without modification.
    /// NOTE As a type, GM_Object does not have a well-defined default state or value representation as a data type. Instantiated subclasses of GM_Object will.
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Object"></see></summary>
    let Object = Namespaced_IRI.parse _namespace_name "Object" |> NamespacedName
    /// <summary>
    /// DirectPosition object data types (Figure 14) hold the coordinates for a position within some coordinate reference system. The coordinate reference system is described in ISO 19111. Since DirectPositions, as data types, will often be included in larger objects (such as GM_Objects) that have references to ISO19111::SC_CRS, the DirectPosition::cordinateReferenceSystem may be left NULL if this particular DirectPosition is included in a larger object with such a reference to a SC_CRS. In this case, the DirectPosition::coordinateReferenceSystem is implicitly assumed to take on the value of the containing object's SC_CRS.
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Position"></see></summary>
    let Position = Namespaced_IRI.parse _namespace_name "Position" |> NamespacedName
    /// <summary>
    /// GM_Primitive (Figure 8) is the abstract root class of the geometric primitives. Its main purpose is to define the basic "boundary" operation that ties the primitives in each dimension together. A geometric primitive (GM_Primitive) is a geometric object that is not decomposed further into other primitives in the system. This includes curves and surfaces, even though they are composed of curve segments and surface patches, respectively. This composition is a strong aggregation: curve segments and surface patches cannot exist outside the context of a primitive.
    /// NOTE Most geometric primitives are decomposable infinitely many times. Adding a centre point to a line may split that line into two separate lines. A new curve drawn across a surface may divide that surface into two parts, each of which is a surface. This is the reason that the normal definition of primitive as "non-decomposable" is not plausible in a geometry model - the only non-decomposable object in geometry is a point.
    /// Any geometric object that is used to describe a feature is a collection of geometric primitives. A collection of geometric primitives may or may not be a geometric complex. Geometric complexes have additional properties such as closure by boundary operations and mutually exclusive component parts.
    /// GM_Primitive and GM_Complex share most semantics, in the meaning of operations, attributes and associations. There is an exception in that a GM_Primitive shall not contain its boundary (except in the trivial case of GM_Point where the boundary is empty), while a GM_Complex shall contain its boundary in all cases. This means that if an instantiated object implements GM_Object operations both as GM_Primitive and as a GM_Complex, the semantics of each set theoretic operation is determined by the its name resolution. Specifically, for a particular object such as GM_CompositeCurve, GM_Primitive::contains (returns FALSE for end points) is different from GM_Complex::contains (returns TRUE for end points). Further, if that object is cast as a GM_Primitive value and as a GM_Complex value, then the two values need not be equal as GM_Objects.
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Primitive"></see></summary>
    let Primitive = Namespaced_IRI.parse _namespace_name "Primitive" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#boundingBox"></see>
    /// </summary>
    let boundingBox =
        Namespaced_IRI.parse _namespace_name "boundingBox" |> NamespacedName

    /// <summary>
    /// GM_Envelope is often referred to as a minimum bounding box or rectangle. Regardless of dimension, a GM_Envelope can be represented without ambiguity as two direct positions (coordinate points). To encode a GM_Envelope, it is sufficient to encode these two points. This is consistent with all of the data types in this standard, their state is represented by their publicly accessible attributes.
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Envelope"></see></summary>
    let Envelope = Namespaced_IRI.parse _namespace_name "Envelope" |> NamespacedName
    /// <summary>
    /// geometric complex
    /// set of disjoint geometric primitives such that the boundary of each primitive can be represented as the union of other geometric primitives within the complex
    ///
    /// NOTE:  The geometric primitives in the set are mutually exclusive in the sense that no point is interior to more than one primitive.  The set is closed under boundary operations, meaning that for each element in the complex, there is a collection (also a complex) of geometric primitives that represents the boundary of that element.
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Complex"></see></summary>
    let Complex = Namespaced_IRI.parse _namespace_name "Complex" |> NamespacedName
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#position"></see>
    /// </summary>
    let position = Namespaced_IRI.parse _namespace_name "position" |> NamespacedName
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Aggregate"></see>
    /// </summary>
    let Aggregate = Namespaced_IRI.parse _namespace_name "Aggregate" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#OrientablePrimitive"></see>
    /// </summary>
    let OrientablePrimitive =
        Namespaced_IRI.parse _namespace_name "OrientablePrimitive" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#upperCorner"></see>
    /// </summary>
    let upperCorner =
        Namespaced_IRI.parse _namespace_name "upperCorner" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#srs"></see>
    /// </summary>
    let srs = Namespaced_IRI.parse _namespace_name "srs" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#coordinates"></see>
    /// </summary>
    let coordinates =
        Namespaced_IRI.parse _namespace_name "coordinates" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#lowerCorner"></see>
    /// </summary>
    let lowerCorner =
        Namespaced_IRI.parse _namespace_name "lowerCorner" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#OrientableCurve"></see>
    /// </summary>
    let OrientableCurve =
        Namespaced_IRI.parse _namespace_name "OrientableCurve" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Solid"></see>
    /// </summary>
    let Solid = Namespaced_IRI.parse _namespace_name "Solid" |> NamespacedName
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Point"></see>
    /// </summary>
    let Point = Namespaced_IRI.parse _namespace_name "Point" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#OrientableSurface"></see>
    /// </summary>
    let OrientableSurface =
        Namespaced_IRI.parse _namespace_name "OrientableSurface" |> NamespacedName
