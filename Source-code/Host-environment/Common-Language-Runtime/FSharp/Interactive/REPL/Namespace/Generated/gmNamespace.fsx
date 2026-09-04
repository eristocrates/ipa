#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module gm =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#" "gm"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Geometry Aggregate^^xsd:string</para>
    ///   <para>h2o:isAbstract : true^^xsd:boolean</para>
    ///   <para>skos:notation : GM_Aggregate^^h2o:ISOClassName</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Aggregate">gm:Aggregate</a>
    /// </summary>
    let Aggregate = _prefixId.prefix "Aggregate"
    /// <summary>
    ///   <para>rdfs:label : Geometry Complex^^xsd:string</para>
    ///   <para>skos:notation : GM_Complex^^h2o:ISOClassName</para>
    ///   <para>rdfs:comment : geometric complex
    /// set of disjoint geometric primitives such that the boundary of each primitive can be represented as the union of other geometric primitives within the complex
    ///
    /// NOTE:  The geometric primitives in the set are mutually exclusive in the sense that no point is interior to more than one primitive.  The set is closed under boundary operations, meaning that for each element in the complex, there is a collection (also a complex) of geometric primitives that represents the boundary of that element.^^xsd:string</para>
    ///   <para>h2o:isAbstract : true^^xsd:boolean</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Complex">gm:Complex</a>
    /// </summary>
    let Complex = _prefixId.prefix "Complex"
    /// <summary>
    ///   <para>rdfs:label : Curve^^xsd:string</para>
    ///   <para>skos:notation : GM_Curve^^h2o:ISOClassName</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Curve">gm:Curve</a>
    /// </summary>
    let Curve = _prefixId.prefix "Curve"
    /// <summary>
    ///   <para>skos:notation : GM_Envelope^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Envelope^^xsd:string</para>
    ///   <para>rdfs:comment : GM_Envelope is often referred to as a minimum bounding box or rectangle. Regardless of dimension, a GM_Envelope can be represented without ambiguity as two direct positions (coordinate points). To encode a GM_Envelope, it is sufficient to encode these two points. This is consistent with all of the data types in this standard, their state is represented by their publicly accessible attributes.^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Envelope">gm:Envelope</a>
    /// </summary>
    let Envelope = _prefixId.prefix "Envelope"
    /// <summary>
    ///   <para>skos:notation : GM_Object^^h2o:ISOClassName</para>
    ///   <para>rdfs:comment : GM_Object (Figure 6) is the root class of the geometric object taxonomy and supports interfaces common to all geographically referenced geometric objects. GM_Object instances are sets of direct positions in a particular coordinate reference system. A GM_Object can be regarded as an infinite set of points that satisfies the set operation interfaces for a set of direct positions, TransfiniteSet&lt;DirectPosition&gt;. Since an infinite collection class cannot be implemented directly, a Boolean test for inclusion shall be provided by the GM_Object interface. This international standard concentrates on vector geometry classes, but future work may use GM_Object as a root class without modification.
    /// NOTE As a type, GM_Object does not have a well-defined default state or value representation as a data type. Instantiated subclasses of GM_Object will.^^xsd:string</para>
    ///   <para>h2o:isAbstract : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Geometry object^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Object">gm:Object</a>
    /// </summary>
    let Object = _prefixId.prefix "Object"
    /// <summary>
    ///   <para>rdfs:label : Orientable Curve^^xsd:string</para>
    ///   <para>skos:notation : GM_OrientableCurve^^h2o:ISOClassName</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#OrientableCurve">gm:OrientableCurve</a>
    /// </summary>
    let OrientableCurve = _prefixId.prefix "OrientableCurve"
    /// <summary>
    ///   <para>h2o:isAbstract : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Orientable primitive^^xsd:string</para>
    ///   <para>skos:notation : GM_OrientablePrimitive^^h2o:ISOClassName</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#OrientablePrimitive">gm:OrientablePrimitive</a>
    /// </summary>
    let OrientablePrimitive = _prefixId.prefix "OrientablePrimitive"
    /// <summary>
    ///   <para>rdfs:label : Orientable Surface^^xsd:string</para>
    ///   <para>skos:notation : GM_OrientableSurface^^h2o:ISOClassName</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#OrientableSurface">gm:OrientableSurface</a>
    /// </summary>
    let OrientableSurface = _prefixId.prefix "OrientableSurface"
    /// <summary>
    ///   <para>rdfs:label : Spatial point^^xsd:string</para>
    ///   <para>skos:notation : GM_Point^^h2o:ISOClassName</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Point">gm:Point</a>
    /// </summary>
    let Point = _prefixId.prefix "Point"
    /// <summary>
    ///   <para>rdfs:label : Geometry position^^xsd:string</para>
    ///   <para>rdfs:comment : DirectPosition object data types (Figure 14) hold the coordinates for a position within some coordinate reference system. The coordinate reference system is described in ISO 19111. Since DirectPositions, as data types, will often be included in larger objects (such as GM_Objects) that have references to ISO19111::SC_CRS, the DirectPosition::cordinateReferenceSystem may be left NULL if this particular DirectPosition is included in a larger object with such a reference to a SC_CRS. In this case, the DirectPosition::coordinateReferenceSystem is implicitly assumed to take on the value of the containing object's SC_CRS.^^xsd:string</para>
    ///   <para>skos:notation : DirectPosition^^h2o:ISOClassName</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Position">gm:Position</a>
    /// </summary>
    let Position = _prefixId.prefix "Position"
    /// <summary>
    ///   <para>rdfs:label : Geometry Primitive^^xsd:string</para>
    ///   <para>rdfs:comment : GM_Primitive (Figure 8) is the abstract root class of the geometric primitives. Its main purpose is to define the basic "boundary" operation that ties the primitives in each dimension together. A geometric primitive (GM_Primitive) is a geometric object that is not decomposed further into other primitives in the system. This includes curves and surfaces, even though they are composed of curve segments and surface patches, respectively. This composition is a strong aggregation: curve segments and surface patches cannot exist outside the context of a primitive.
    /// NOTE Most geometric primitives are decomposable infinitely many times. Adding a centre point to a line may split that line into two separate lines. A new curve drawn across a surface may divide that surface into two parts, each of which is a surface. This is the reason that the normal definition of primitive as "non-decomposable" is not plausible in a geometry model - the only non-decomposable object in geometry is a point.
    /// Any geometric object that is used to describe a feature is a collection of geometric primitives. A collection of geometric primitives may or may not be a geometric complex. Geometric complexes have additional properties such as closure by boundary operations and mutually exclusive component parts.
    /// GM_Primitive and GM_Complex share most semantics, in the meaning of operations, attributes and associations. There is an exception in that a GM_Primitive shall not contain its boundary (except in the trivial case of GM_Point where the boundary is empty), while a GM_Complex shall contain its boundary in all cases. This means that if an instantiated object implements GM_Object operations both as GM_Primitive and as a GM_Complex, the semantics of each set theoretic operation is determined by the its name resolution. Specifically, for a particular object such as GM_CompositeCurve, GM_Primitive::contains (returns FALSE for end points) is different from GM_Complex::contains (returns TRUE for end points). Further, if that object is cast as a GM_Primitive value and as a GM_Complex value, then the two values need not be equal as GM_Objects.^^xsd:string</para>
    ///   <para>skos:notation : GM_Primitive^^h2o:ISOClassName</para>
    ///   <para>h2o:isAbstract : true^^xsd:boolean</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Primitive">gm:Primitive</a>
    /// </summary>
    let Primitive = _prefixId.prefix "Primitive"
    /// <summary>
    ///   <para>rdfs:label : Solid^^xsd:string</para>
    ///   <para>skos:notation : GM_Solid^^h2o:ISOClassName</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Solid">gm:Solid</a>
    /// </summary>
    let Solid = _prefixId.prefix "Solid"
    /// <summary>
    ///   <para>rdfs:label : Surface^^xsd:string</para>
    ///   <para>skos:notation : GM_Surface^^h2o:ISOClassName</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#Surface">gm:Surface</a>
    /// </summary>
    let Surface = _prefixId.prefix "Surface"
    /// <summary>
    ///   <para>rdfs:label : bounding box^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#boundingBox">gm:boundingBox</a>
    /// </summary>
    let boundingBox = _prefixId.prefix "boundingBox"
    /// <summary>
    ///   <para>rdfs:label : coordinates^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#coordinates">gm:coordinates</a>
    /// </summary>
    let coordinates = _prefixId.prefix "coordinates"
    /// <summary>
    ///   <para>rdfs:label : lower corner^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#lowerCorner">gm:lowerCorner</a>
    /// </summary>
    let lowerCorner = _prefixId.prefix "lowerCorner"
    /// <summary>
    ///   <para>rdfs:label : geometric position^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#position">gm:position</a>
    /// </summary>
    let position = _prefixId.prefix "position"
    /// <summary>
    ///   <para>rdfs:label : spatial reference system^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#srs">gm:srs</a>
    /// </summary>
    let srs = _prefixId.prefix "srs"
    /// <summary>
    ///   <para>rdfs:label : upper corner^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#upperCorner">gm:upperCorner</a>
    /// </summary>
    let upperCorner = _prefixId.prefix "upperCorner"
