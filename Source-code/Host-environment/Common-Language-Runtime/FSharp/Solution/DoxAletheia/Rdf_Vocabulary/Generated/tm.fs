namespace http.def.seegrid.csiro.au.isotc211.iso19108._2002.temporal.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tm =
    let _namespace_iri = Namespace_Iri tm |> NamespaceIRI
    /// <summary>
    ///   <para>tm:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#</seealso>
    let _prefix_iri = Prefixed_Name(tm, "") |> PrefixedName
    /// <summary>
    ///   <para>tm:CalDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Calendar date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#CalDate">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#CalDate</seealso>
    let CalDate = Prefixed_Name(tm, "CalDate") |> PrefixedName
    /// <summary>
    ///   <para>tm:Calendar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Calendar"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Calendar">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Calendar</seealso>
    let Calendar = Prefixed_Name(tm, "Calendar") |> PrefixedName
    /// <summary>
    ///   <para>tm:Clock</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Clock"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Clock">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Clock</seealso>
    let Clock = Prefixed_Name(tm, "Clock") |> PrefixedName
    /// <summary>
    ///   <para>tm:ClockTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Clock time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#ClockTime">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#ClockTime</seealso>
    let ClockTime = Prefixed_Name(tm, "ClockTime") |> PrefixedName
    /// <summary>
    ///   <para>tm:Complex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Temporal Complex"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Complex">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Complex</seealso>
    let Complex = Prefixed_Name(tm, "Complex") |> PrefixedName
    /// <summary>
    ///   <para>tm:Coordinate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Temporal Coordinate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Coordinate">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Coordinate</seealso>
    let Coordinate = Prefixed_Name(tm, "Coordinate") |> PrefixedName
    /// <summary>
    ///   <para>tm:CoordinateSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Temporal Coordinate System"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#CoordinateSystem">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#CoordinateSystem</seealso>
    let CoordinateSystem = Prefixed_Name(tm, "CoordinateSystem") |> PrefixedName
    /// <summary>
    ///   <para>tm:DateAndTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Date and time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#DateAndTime">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#DateAndTime</seealso>
    let DateAndTime = Prefixed_Name(tm, "DateAndTime") |> PrefixedName
    /// <summary>
    ///   <para>tm:Edge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Temporal Edge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Edge">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Edge</seealso>
    let Edge = Prefixed_Name(tm, "Edge") |> PrefixedName
    /// <summary>
    ///   <para>tm:GeometricComplex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Temporal geometric complex"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#GeometricComplex">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#GeometricComplex</seealso>
    let GeometricComplex = Prefixed_Name(tm, "GeometricComplex") |> PrefixedName
    /// <summary>
    ///   <para>tm:GeometricPrimitive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Temporal Geometric Primitive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#GeometricPrimitive">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#GeometricPrimitive</seealso>
    let GeometricPrimitive = Prefixed_Name(tm, "GeometricPrimitive") |> PrefixedName
    /// <summary>
    ///   <para>tm:Instant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Temporal Instant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Instant">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Instant</seealso>
    let Instant = Prefixed_Name(tm, "Instant") |> PrefixedName
    /// <summary>
    ///   <para>tm:Node</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Temporal Node"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Node">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Node</seealso>
    let Node = Prefixed_Name(tm, "Node") |> PrefixedName
    /// <summary>
    ///   <para>tm:Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Temporal Object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Object">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Object</seealso>
    let Object = Prefixed_Name(tm, "Object") |> PrefixedName
    /// <summary>
    ///   <para>tm:OrdinalEra</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Temporal ordinal era"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#OrdinalEra">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#OrdinalEra</seealso>
    let OrdinalEra = Prefixed_Name(tm, "OrdinalEra") |> PrefixedName
    /// <summary>
    ///   <para>tm:OrdinalPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Temporal ordinal position"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#OrdinalPosition">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#OrdinalPosition</seealso>
    let OrdinalPosition = Prefixed_Name(tm, "OrdinalPosition") |> PrefixedName

    /// <summary>
    ///   <para>tm:OrdinalReferenceSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Temporal Ordinal Reference System"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#OrdinalReferenceSystem">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#OrdinalReferenceSystem</seealso>
    let OrdinalReferenceSystem =
        Prefixed_Name(tm, "OrdinalReferenceSystem") |> PrefixedName

    /// <summary>
    ///   <para>tm:Period</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Temporal Period"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Period">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Period</seealso>
    let Period = Prefixed_Name(tm, "Period") |> PrefixedName
    /// <summary>
    ///   <para>tm:Primitive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Temporal Primitive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Primitive">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Primitive</seealso>
    let Primitive = Prefixed_Name(tm, "Primitive") |> PrefixedName
    /// <summary>
    ///   <para>tm:ReferenceSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Temporal Reference System"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#ReferenceSystem">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#ReferenceSystem</seealso>
    let ReferenceSystem = Prefixed_Name(tm, "ReferenceSystem") |> PrefixedName
    /// <summary>
    ///   <para>tm:TemporalPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Temporal position"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#TemporalPosition">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#TemporalPosition</seealso>
    let TemporalPosition = Prefixed_Name(tm, "TemporalPosition") |> PrefixedName
    /// <summary>
    ///   <para>tm:TopologicalComplex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Temporal topologic complex"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#TopologicalComplex">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#TopologicalComplex</seealso>
    let TopologicalComplex = Prefixed_Name(tm, "TopologicalComplex") |> PrefixedName
    /// <summary>
    ///   <para>tm:TopologicalPrimitive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Temporal Topological Primitive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#TopologicalPrimitive">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#TopologicalPrimitive</seealso>
    let TopologicalPrimitive = Prefixed_Name(tm, "TopologicalPrimitive") |> PrefixedName
    /// <summary>
    ///   <para>tm:begin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The value of this property defines the beginning of a time period"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"beginning instant or node"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#begin">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#begin</seealso>
    let begin_ = Prefixed_Name(tm, "begin") |> PrefixedName
    /// <summary>
    ///   <para>tm:begunBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"begun by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#begunBy">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#begunBy</seealso>
    let begunBy = Prefixed_Name(tm, "begunBy") |> PrefixedName
    /// <summary>
    ///   <para>tm:complex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"complex"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#complex">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#complex</seealso>
    let complex = Prefixed_Name(tm, "complex") |> PrefixedName
    /// <summary>
    ///   <para>tm:component</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"component era"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#component">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#component</seealso>
    let component_ = Prefixed_Name(tm, "component") |> PrefixedName
    /// <summary>
    ///   <para>tm:date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"calendar date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#date">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#date</seealso>
    let date = Prefixed_Name(tm, "date") |> PrefixedName
    /// <summary>
    ///   <para>tm:dateTimePosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The value of this property is a time encoded as an xsd:dateTime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"date or dateTime position"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#dateTimePosition">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#dateTimePosition</seealso>
    let dateTimePosition = Prefixed_Name(tm, "dateTimePosition") |> PrefixedName
    /// <summary>
    ///   <para>tm:domainOfValidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"domain of validity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#domainOfValidity">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#domainOfValidity</seealso>
    let domainOfValidity = Prefixed_Name(tm, "domainOfValidity") |> PrefixedName
    /// <summary>
    ///   <para>tm:end</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The value of this property defines the end of a time period"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ending instant or node"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#end">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#end</seealso>
    let end_ = Prefixed_Name(tm, "end") |> PrefixedName
    /// <summary>
    ///   <para>tm:endedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ended by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#endedBy">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#endedBy</seealso>
    let endedBy = Prefixed_Name(tm, "endedBy") |> PrefixedName
    /// <summary>
    ///   <para>tm:frame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The value of this property indicates the temporal reference system for a time position"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"temporal reference system or frame"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#frame">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#frame</seealso>
    let frame = Prefixed_Name(tm, "frame") |> PrefixedName
    /// <summary>
    ///   <para>tm:geometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"temporal geometry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#geometry">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#geometry</seealso>
    let geometry = Prefixed_Name(tm, "geometry") |> PrefixedName
    /// <summary>
    ///   <para>tm:group</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"parent era"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#group">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#group</seealso>
    let group = Prefixed_Name(tm, "group") |> PrefixedName
    /// <summary>
    ///   <para>tm:member</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"member era"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#member">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#member</seealso>
    let member_ = Prefixed_Name(tm, "member") |> PrefixedName
    /// <summary>
    ///   <para>tm:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#name">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#name</seealso>
    let name = Prefixed_Name(tm, "name") |> PrefixedName
    /// <summary>
    ///   <para>tm:nextEdge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"next edge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#nextEdge">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#nextEdge</seealso>
    let nextEdge = Prefixed_Name(tm, "nextEdge") |> PrefixedName
    /// <summary>
    ///   <para>tm:ordinalValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ordinal time position"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#ordinalValue">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#ordinalValue</seealso>
    let ordinalValue = Prefixed_Name(tm, "ordinalValue") |> PrefixedName
    /// <summary>
    ///   <para>tm:previousEdge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"previous edge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#previousEdge">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#previousEdge</seealso>
    let previousEdge = Prefixed_Name(tm, "previousEdge") |> PrefixedName
    /// <summary>
    ///   <para>tm:primitive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"primitive member"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#primitive">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#primitive</seealso>
    let primitive = Prefixed_Name(tm, "primitive") |> PrefixedName
    /// <summary>
    ///   <para>tm:system</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"parent reference system"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#system">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#system</seealso>
    let system = Prefixed_Name(tm, "system") |> PrefixedName
    /// <summary>
    ///   <para>tm:temporalPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"temporal position"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#temporalPosition">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#temporalPosition</seealso>
    let temporalPosition = Prefixed_Name(tm, "temporalPosition") |> PrefixedName
    /// <summary>
    ///   <para>tm:time</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"clock time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#time">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#time</seealso>
    let time = Prefixed_Name(tm, "time") |> PrefixedName
    /// <summary>
    ///   <para>tm:topology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"temporal topology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#topology">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#topology</seealso>
    let topology = Prefixed_Name(tm, "topology") |> PrefixedName
    /// <summary>
    ///   <para>tm:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"temporal position value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#value">http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#value</seealso>
    let value = Prefixed_Name(tm, "value") |> PrefixedName
