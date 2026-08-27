namespace http.def.seegrid.csiro.au.isotc211.iso19107._2003.geometry.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module gm =
    let _namespace_iri = Namespace_Iri gm |> NamespaceIRI
    /// <summary>
    ///   <para>gm:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#">http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#</seealso>
    let _prefix_iri = Prefixed_Name(gm, "") |> PrefixedName
    /// <summary>
    ///   <para>gm:Aggregate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Geometry Aggregate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Aggregate">http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Aggregate</seealso>
    let Aggregate = Prefixed_Name(gm, "Aggregate") |> PrefixedName
    /// <summary>
    ///   <para>gm:Complex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"geometric complex
    /// set of disjoint geometric primitives such that the boundary of each primitive can be represented as the union of other geometric primitives within the complex
    ///
    /// NOTE:  The geometric primitives in the set are mutually exclusive in the sense that no point is interior to more than one primitive.  The set is closed under boundary operations, meaning that for each element in the complex, there is a collection (also a complex) of geometric primitives that represents the boundary of that element."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Geometry Complex"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Complex">http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Complex</seealso>
    let Complex = Prefixed_Name(gm, "Complex") |> PrefixedName
    /// <summary>
    ///   <para>gm:Curve</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Curve"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Curve">http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Curve</seealso>
    let Curve = Prefixed_Name(gm, "Curve") |> PrefixedName
    /// <summary>
    ///   <para>gm:Envelope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"GM_Envelope is often referred to as a minimum bounding box or rectangle. Regardless of dimension, a GM_Envelope can be represented without ambiguity as two direct positions (coordinate points). To encode a GM_Envelope, it is sufficient to encode these two points. This is consistent with all of the data types in this standard, their state is represented by their publicly accessible attributes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Envelope"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Envelope">http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Envelope</seealso>
    let Envelope = Prefixed_Name(gm, "Envelope") |> PrefixedName
    /// <summary>
    ///   <para>gm:Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"GM_Object (Figure 6) is the root class of the geometric object taxonomy and supports interfaces common to all geographically referenced geometric objects. GM_Object instances are sets of direct positions in a particular coordinate reference system. A GM_Object can be regarded as an infinite set of points that satisfies the set operation interfaces for a set of direct positions, TransfiniteSet&lt;DirectPosition&gt;. Since an infinite collection class cannot be implemented directly, a Boolean test for inclusion shall be provided by the GM_Object interface. This international standard concentrates on vector geometry classes, but future work may use GM_Object as a root class without modification.
    /// NOTE As a type, GM_Object does not have a well-defined default state or value representation as a data type. Instantiated subclasses of GM_Object will."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Geometry object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Object">http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Object</seealso>
    let Object = Prefixed_Name(gm, "Object") |> PrefixedName
    /// <summary>
    ///   <para>gm:OrientableCurve</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Orientable Curve"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#OrientableCurve">http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#OrientableCurve</seealso>
    let OrientableCurve = Prefixed_Name(gm, "OrientableCurve") |> PrefixedName
    /// <summary>
    ///   <para>gm:OrientablePrimitive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Orientable primitive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#OrientablePrimitive">http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#OrientablePrimitive</seealso>
    let OrientablePrimitive = Prefixed_Name(gm, "OrientablePrimitive") |> PrefixedName
    /// <summary>
    ///   <para>gm:OrientableSurface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Orientable Surface"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#OrientableSurface">http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#OrientableSurface</seealso>
    let OrientableSurface = Prefixed_Name(gm, "OrientableSurface") |> PrefixedName
    /// <summary>
    ///   <para>gm:Point</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Spatial point"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Point">http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Point</seealso>
    let Point = Prefixed_Name(gm, "Point") |> PrefixedName
    /// <summary>
    ///   <para>gm:Position</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"DirectPosition object data types (Figure 14) hold the coordinates for a position within some coordinate reference system. The coordinate reference system is described in ISO 19111. Since DirectPositions, as data types, will often be included in larger objects (such as GM_Objects) that have references to ISO19111::SC_CRS, the DirectPosition::cordinateReferenceSystem may be left NULL if this particular DirectPosition is included in a larger object with such a reference to a SC_CRS. In this case, the DirectPosition::coordinateReferenceSystem is implicitly assumed to take on the value of the containing object's SC_CRS."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Geometry position"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Position">http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Position</seealso>
    let Position = Prefixed_Name(gm, "Position") |> PrefixedName
    /// <summary>
    ///   <para>gm:Primitive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"GM_Primitive (Figure 8) is the abstract root class of the geometric primitives. Its main purpose is to define the basic "boundary" operation that ties the primitives in each dimension together. A geometric primitive (GM_Primitive) is a geometric object that is not decomposed further into other primitives in the system. This includes curves and surfaces, even though they are composed of curve segments and surface patches, respectively. This composition is a strong aggregation: curve segments and surface patches cannot exist outside the context of a primitive.
    /// NOTE Most geometric primitives are decomposable infinitely many times. Adding a centre point to a line may split that line into two separate lines. A new curve drawn across a surface may divide that surface into two parts, each of which is a surface. This is the reason that the normal definition of primitive as "non-decomposable" is not plausible in a geometry model - the only non-decomposable object in geometry is a point.
    /// Any geometric object that is used to describe a feature is a collection of geometric primitives. A collection of geometric primitives may or may not be a geometric complex. Geometric complexes have additional properties such as closure by boundary operations and mutually exclusive component parts.
    /// GM_Primitive and GM_Complex share most semantics, in the meaning of operations, attributes and associations. There is an exception in that a GM_Primitive shall not contain its boundary (except in the trivial case of GM_Point where the boundary is empty), while a GM_Complex shall contain its boundary in all cases. This means that if an instantiated object implements GM_Object operations both as GM_Primitive and as a GM_Complex, the semantics of each set theoretic operation is determined by the its name resolution. Specifically, for a particular object such as GM_CompositeCurve, GM_Primitive::contains (returns FALSE for end points) is different from GM_Complex::contains (returns TRUE for end points). Further, if that object is cast as a GM_Primitive value and as a GM_Complex value, then the two values need not be equal as GM_Objects."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Geometry Primitive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Primitive">http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Primitive</seealso>
    let Primitive = Prefixed_Name(gm, "Primitive") |> PrefixedName
    /// <summary>
    ///   <para>gm:Solid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Solid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Solid">http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Solid</seealso>
    let Solid = Prefixed_Name(gm, "Solid") |> PrefixedName
    /// <summary>
    ///   <para>gm:Surface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Surface"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Surface">http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Surface</seealso>
    let Surface = Prefixed_Name(gm, "Surface") |> PrefixedName
    /// <summary>
    ///   <para>gm:boundingBox</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"bounding box"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#boundingBox">http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#boundingBox</seealso>
    let boundingBox = Prefixed_Name(gm, "boundingBox") |> PrefixedName
    /// <summary>
    ///   <para>gm:coordinates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"coordinates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#coordinates">http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#coordinates</seealso>
    let coordinates = Prefixed_Name(gm, "coordinates") |> PrefixedName
    /// <summary>
    ///   <para>gm:lowerCorner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"lower corner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#lowerCorner">http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#lowerCorner</seealso>
    let lowerCorner = Prefixed_Name(gm, "lowerCorner") |> PrefixedName
    /// <summary>
    ///   <para>gm:position</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"geometric position"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#position">http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#position</seealso>
    let position = Prefixed_Name(gm, "position") |> PrefixedName
    /// <summary>
    ///   <para>gm:srs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"spatial reference system"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#srs">http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#srs</seealso>
    let srs = Prefixed_Name(gm, "srs") |> PrefixedName
    /// <summary>
    ///   <para>gm:upperCorner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"upper corner"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#upperCorner">http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#upperCorner</seealso>
    let upperCorner = Prefixed_Name(gm, "upperCorner") |> PrefixedName
