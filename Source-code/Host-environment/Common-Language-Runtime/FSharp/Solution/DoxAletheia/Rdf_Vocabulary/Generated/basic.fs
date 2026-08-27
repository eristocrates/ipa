namespace http.def.seegrid.csiro.au.isotc211.iso19103._2005.basic.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module basic =
    let _namespace_iri = Namespace_Iri basic |> NamespaceIRI
    /// <summary>
    ///   <para>basic:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#">http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#</seealso>
    let _prefix_iri = Prefixed_Name(basic, "") |> PrefixedName
    /// <summary>
    ///   <para>basic:Acceleration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of rate of change of velocity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Acceleration"</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Acceleration">http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Acceleration</seealso>
    let Acceleration = Prefixed_Name(basic, "Acceleration") |> PrefixedName
    /// <summary>
    ///   <para>basic:Angle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"measure of arc length or rotation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Angle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Angle">http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Angle</seealso>
    let Angle = Prefixed_Name(basic, "Angle") |> PrefixedName
    /// <summary>
    ///   <para>basic:AngularVelocity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of rate of change of angular position"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AngularVelocity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#AngularVelocity">http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#AngularVelocity</seealso>
    let AngularVelocity = Prefixed_Name(basic, "AngularVelocity") |> PrefixedName
    /// <summary>
    ///   <para>basic:Area</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of 2-D extent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Area">http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Area</seealso>
    let Area = Prefixed_Name(basic, "Area") |> PrefixedName
    /// <summary>
    ///   <para>basic:Boolean</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"Truth value. Most valuable in the predicate calculus, where items are either True or False, unless they are ill formed."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"boolean"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Boolean">http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Boolean</seealso>
    let Boolean = Prefixed_Name(basic, "Boolean") |> PrefixedName
    /// <summary>
    ///   <para>basic:CharacterString</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"sequence of characters"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"characterString"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#CharacterString">http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#CharacterString</seealso>
    let CharacterString = Prefixed_Name(basic, "CharacterString") |> PrefixedName
    /// <summary>
    ///   <para>basic:Currency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of exchange value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Currency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Currency">http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Currency</seealso>
    let Currency = Prefixed_Name(basic, "Currency") |> PrefixedName
    /// <summary>
    ///   <para>basic:Date</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"Temporal position expressed with precision of days"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Date">http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Date</seealso>
    let Date = Prefixed_Name(basic, "Date") |> PrefixedName
    /// <summary>
    ///   <para>basic:DateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"Temporal position expressed as a time and date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"dateTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#DateTime">http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#DateTime</seealso>
    let DateTime = Prefixed_Name(basic, "DateTime") |> PrefixedName
    /// <summary>
    ///   <para>basic:Decimal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"The usually finite representation of a decimal number. It differs from the common binary Real implementation in that it can represent 1/10 (one-tenth) without error, while binary real representation can only represent powers of 1/2 (one-half) exactly. Since many currencies are decimal, these representations are preferred in dealing with such moneys. This is also true for mile markers, which are often given in decimals.
    ///
    /// Can be thought of as an integer part followed by a fractional part given in multiples of powers of 1/10 (tenths)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"decimal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Decimal">http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Decimal</seealso>
    let Decimal = Prefixed_Name(basic, "Decimal") |> PrefixedName
    /// <summary>
    ///   <para>basic:Distance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of spatial separation along some 1-D manifold"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Distance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Distance">http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Distance</seealso>
    let Distance = Prefixed_Name(basic, "Distance") |> PrefixedName
    /// <summary>
    ///   <para>basic:Integer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"An exact integer value, with no fractional part."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"integer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Integer">http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Integer</seealso>
    let Integer = Prefixed_Name(basic, "Integer") |> PrefixedName
    /// <summary>
    ///   <para>basic:Length</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of 1-D extent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Length">http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Length</seealso>
    let Length = Prefixed_Name(basic, "Length") |> PrefixedName
    /// <summary>
    ///   <para>basic:LocalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"Name in some local context"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"localName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#LocalName">http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#LocalName</seealso>
    let LocalName = Prefixed_Name(basic, "LocalName") |> PrefixedName
    /// <summary>
    ///   <para>basic:Mass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of amount of substance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Mass">http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Mass</seealso>
    let Mass = Prefixed_Name(basic, "Mass") |> PrefixedName
    /// <summary>
    ///   <para>basic:Measure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Scaled number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Measure"</para><para>"Mesure"</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Measure">http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Measure</seealso>
    let Measure = Prefixed_Name(basic, "Measure") |> PrefixedName
    /// <summary>
    ///   <para>basic:Number</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"The set of numbers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Note: integer is a specialization of decimal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Number">http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Number</seealso>
    let Number = Prefixed_Name(basic, "Number") |> PrefixedName
    /// <summary>
    ///   <para>basic:Real</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"The common binary Real finite implementation using base 2. Since such reals can approximate any measure where absolute accuracy is not possible, this form of numeric is most often used for measures. In cases were absolute accuracy is needed, such as currencies, then a decimal representation may be preferred (assuming the currency is decimal, such as the US dollar, British pound, etc.). Where there are no subunits possible, Integer numbers may be preferred.
    ///
    /// Can be thought of as an integer part followed by a fractional part given in multiples of powers of 1/2 (halves)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"realNumber"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Real">http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Real</seealso>
    let Real = Prefixed_Name(basic, "Real") |> PrefixedName
    /// <summary>
    ///   <para>basic:Scale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Factor by which a representation should be magnified to match the geomstric size of the thing it represents."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Scale"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Scale">http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Scale</seealso>
    let Scale = Prefixed_Name(basic, "Scale") |> PrefixedName
    /// <summary>
    ///   <para>basic:Time</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of temporal extent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Time">http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Time</seealso>
    let Time = Prefixed_Name(basic, "Time") |> PrefixedName
    /// <summary>
    ///   <para>basic:UnitOfMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Scale for a number describing size or extent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Unit of measure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#UnitOfMeasure">http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#UnitOfMeasure</seealso>
    let UnitOfMeasure = Prefixed_Name(basic, "UnitOfMeasure") |> PrefixedName
    /// <summary>
    ///   <para>basic:Vector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A vector is a sequence of a fixed length of Numbers. Normally, the numbers represent some measures, and thus vectors are often used where records of Numbers would be more appropriate. In geometry for example, direct positions are given by undistinguished coordinate vectors, which can be interpreted through the use of coordinate reference systems."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Vector"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Vector">http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Vector</seealso>
    let Vector = Prefixed_Name(basic, "Vector") |> PrefixedName
    /// <summary>
    ///   <para>basic:Velocity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of rate of change of position"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Velocity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Velocity">http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Velocity</seealso>
    let Velocity = Prefixed_Name(basic, "Velocity") |> PrefixedName
    /// <summary>
    ///   <para>basic:Volume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of 3-D extent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Volume"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Volume">http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Volume</seealso>
    let Volume = Prefixed_Name(basic, "Volume") |> PrefixedName
    /// <summary>
    ///   <para>basic:Weight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of force due to a mass in a specific gravitational field"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Weight"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Weight">http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Weight</seealso>
    let Weight = Prefixed_Name(basic, "Weight") |> PrefixedName
    /// <summary>
    ///   <para>basic:dimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Number of components in the vector"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"dimension"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#dimension">http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#dimension</seealso>
    let dimension = Prefixed_Name(basic, "dimension") |> PrefixedName
    /// <summary>
    ///   <para>basic:measure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The value of this property is a scaled number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"measure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#measure">http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#measure</seealso>
    let measure = Prefixed_Name(basic, "measure") |> PrefixedName
    /// <summary>
    ///   <para>basic:ordinates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Numerical values of the vector components"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ordinates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#ordinates">http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#ordinates</seealso>
    let ordinates = Prefixed_Name(basic, "ordinates") |> PrefixedName
    /// <summary>
    ///   <para>basic:uom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The value of this property designates the units of measure or scale for the quantity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"unit of measure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#uom">http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#uom</seealso>
    let uom = Prefixed_Name(basic, "uom") |> PrefixedName
    /// <summary>
    ///   <para>basic:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The value of this property is a number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#value">http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#value</seealso>
    let value = Prefixed_Name(basic, "value") |> PrefixedName
