#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module tm =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#" "tm"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>skos:notation : TM_CalDate^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Calendar date^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#CalDate">tm:CalDate</a>
    /// </summary>
    let CalDate = _prefixId.prefix "CalDate"
    /// <summary>
    ///   <para>skos:notation : TM_Calendar^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Calendar^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Calendar">tm:Calendar</a>
    /// </summary>
    let Calendar = _prefixId.prefix "Calendar"
    /// <summary>
    ///   <para>skos:notation : TM_Clock^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Clock^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Clock">tm:Clock</a>
    /// </summary>
    let Clock = _prefixId.prefix "Clock"
    /// <summary>
    ///   <para>skos:notation : TM_ClockTime^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Clock time^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#ClockTime">tm:ClockTime</a>
    /// </summary>
    let ClockTime = _prefixId.prefix "ClockTime"
    /// <summary>
    ///   <para>skos:notation : TM_Complex^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Temporal Complex^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Complex">tm:Complex</a>
    /// </summary>
    let Complex = _prefixId.prefix "Complex"
    /// <summary>
    ///   <para>skos:notation : TM_Coordinate^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Temporal Coordinate^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Coordinate">tm:Coordinate</a>
    /// </summary>
    let Coordinate = _prefixId.prefix "Coordinate"
    /// <summary>
    ///   <para>skos:notation : TM_CoordinateSystem^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Temporal Coordinate System^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#CoordinateSystem">tm:CoordinateSystem</a>
    /// </summary>
    let CoordinateSystem = _prefixId.prefix "CoordinateSystem"
    /// <summary>
    ///   <para>skos:notation : TM_DateAndTime^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Date and time^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#DateAndTime">tm:DateAndTime</a>
    /// </summary>
    let DateAndTime = _prefixId.prefix "DateAndTime"
    /// <summary>
    ///   <para>rdfs:label : Temporal Edge^^xsd:string</para>
    ///   <para>skos:notation : TM_Edge^^h2o:ISOClassName</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Edge">tm:Edge</a>
    /// </summary>
    let Edge = _prefixId.prefix "Edge"
    /// <summary>
    ///   <para>skos:notation : TM_GeometricComplex^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Temporal geometric complex^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#GeometricComplex">tm:GeometricComplex</a>
    /// </summary>
    let GeometricComplex = _prefixId.prefix "GeometricComplex"
    /// <summary>
    ///   <para>skos:notation : TM_GeometricPrimitive^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Temporal Geometric Primitive^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#GeometricPrimitive">tm:GeometricPrimitive</a>
    /// </summary>
    let GeometricPrimitive = _prefixId.prefix "GeometricPrimitive"
    /// <summary>
    ///   <para>skos:notation : TM_Instant^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Temporal Instant^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Instant">tm:Instant</a>
    /// </summary>
    let Instant = _prefixId.prefix "Instant"
    /// <summary>
    ///   <para>skos:notation : TM_Node^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Temporal Node^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Node">tm:Node</a>
    /// </summary>
    let Node = _prefixId.prefix "Node"
    /// <summary>
    ///   <para>skos:notation : TM_Object^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Temporal Object^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Object">tm:Object</a>
    /// </summary>
    let Object = _prefixId.prefix "Object"
    /// <summary>
    ///   <para>skos:notation : TM_OrdinalEra^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Temporal ordinal era^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#OrdinalEra">tm:OrdinalEra</a>
    /// </summary>
    let OrdinalEra = _prefixId.prefix "OrdinalEra"
    /// <summary>
    ///   <para>skos:notation : TM_OrdinalPosition^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Temporal ordinal position^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#OrdinalPosition">tm:OrdinalPosition</a>
    /// </summary>
    let OrdinalPosition = _prefixId.prefix "OrdinalPosition"
    /// <summary>
    ///   <para>skos:notation : TM_OrdinalReferenceSystem^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Temporal Ordinal Reference System^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#OrdinalReferenceSystem">tm:OrdinalReferenceSystem</a>
    /// </summary>
    let OrdinalReferenceSystem = _prefixId.prefix "OrdinalReferenceSystem"
    /// <summary>
    ///   <para>rdfs:label : Temporal Period^^xsd:string</para>
    ///   <para>skos:notation : TM_Period^^h2o:ISOClassName</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Period">tm:Period</a>
    /// </summary>
    let Period = _prefixId.prefix "Period"
    /// <summary>
    ///   <para>skos:notation : TM_Primitive^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Temporal Primitive^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Primitive">tm:Primitive</a>
    /// </summary>
    let Primitive = _prefixId.prefix "Primitive"
    /// <summary>
    ///   <para>skos:notation : TM_ReferenceSystem^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Temporal Reference System^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#ReferenceSystem">tm:ReferenceSystem</a>
    /// </summary>
    let ReferenceSystem = _prefixId.prefix "ReferenceSystem"
    /// <summary>
    ///   <para>skos:notation : TM_TemporalPosition^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Temporal position^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#TemporalPosition">tm:TemporalPosition</a>
    /// </summary>
    let TemporalPosition = _prefixId.prefix "TemporalPosition"
    /// <summary>
    ///   <para>skos:notation : TM_TopologicalComplex^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Temporal topologic complex^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#TopologicalComplex">tm:TopologicalComplex</a>
    /// </summary>
    let TopologicalComplex = _prefixId.prefix "TopologicalComplex"
    /// <summary>
    ///   <para>skos:notation : TM_TopologicalPrimitive^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Temporal Topological Primitive^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#TopologicalPrimitive">tm:TopologicalPrimitive</a>
    /// </summary>
    let TopologicalPrimitive = _prefixId.prefix "TopologicalPrimitive"
    /// <summary>
    ///   <para>rdfs:label : beginning instant or node^^xsd:string</para>
    ///   <para>rdfs:comment : The value of this property defines the beginning of a time period^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#begin">tm:begin</a>
    /// </summary>
    let begin_ = _prefixId.prefix "begin"
    /// <summary>
    ///   <para>rdfs:label : begun by^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#begunBy">tm:begunBy</a>
    /// </summary>
    let begunBy = _prefixId.prefix "begunBy"
    /// <summary>
    ///   <para>rdfs:label : complex^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#complex">tm:complex</a>
    /// </summary>
    let complex = _prefixId.prefix "complex"
    /// <summary>
    ///   <para>rdfs:label : component era^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#component">tm:component</a>
    /// </summary>
    let component_ = _prefixId.prefix "component"
    /// <summary>
    ///   <para>rdfs:label : calendar date^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#date">tm:date</a>
    /// </summary>
    let date = _prefixId.prefix "date"
    /// <summary>
    ///   <para>rdfs:label : date or dateTime position^^xsd:string</para>
    ///   <para>rdfs:comment : The value of this property is a time encoded as an xsd:dateTime^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#dateTimePosition">tm:dateTimePosition</a>
    /// </summary>
    let dateTimePosition = _prefixId.prefix "dateTimePosition"
    /// <summary>
    ///   <para>rdfs:label : domain of validity^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#domainOfValidity">tm:domainOfValidity</a>
    /// </summary>
    let domainOfValidity = _prefixId.prefix "domainOfValidity"
    /// <summary>
    ///   <para>rdfs:label : ending instant or node^^xsd:string</para>
    ///   <para>rdfs:comment : The value of this property defines the end of a time period^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#end">tm:end</a>
    /// </summary>
    let end_ = _prefixId.prefix "end"
    /// <summary>
    ///   <para>rdfs:label : ended by^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#endedBy">tm:endedBy</a>
    /// </summary>
    let endedBy = _prefixId.prefix "endedBy"
    /// <summary>
    ///   <para>rdfs:label : temporal reference system or frame^^xsd:string</para>
    ///   <para>rdfs:comment : The value of this property indicates the temporal reference system for a time position^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#frame">tm:frame</a>
    /// </summary>
    let frame = _prefixId.prefix "frame"
    /// <summary>
    ///   <para>rdfs:label : temporal geometry^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#geometry">tm:geometry</a>
    /// </summary>
    let geometry = _prefixId.prefix "geometry"
    /// <summary>
    ///   <para>rdfs:label : parent era^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#group">tm:group</a>
    /// </summary>
    let group = _prefixId.prefix "group"
    /// <summary>
    ///   <para>rdfs:label : member era^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#member">tm:member</a>
    /// </summary>
    let member_ = _prefixId.prefix "member"
    /// <summary>
    ///   <para>rdfs:label : name^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#name">tm:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>rdfs:label : next edge^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#nextEdge">tm:nextEdge</a>
    /// </summary>
    let nextEdge = _prefixId.prefix "nextEdge"
    /// <summary>
    ///   <para>rdfs:label : ordinal time position^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#ordinalValue">tm:ordinalValue</a>
    /// </summary>
    let ordinalValue = _prefixId.prefix "ordinalValue"
    /// <summary>
    ///   <para>rdfs:label : previous edge^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#previousEdge">tm:previousEdge</a>
    /// </summary>
    let previousEdge = _prefixId.prefix "previousEdge"
    /// <summary>
    ///   <para>rdfs:label : primitive member^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#primitive">tm:primitive</a>
    /// </summary>
    let primitive = _prefixId.prefix "primitive"
    /// <summary>
    ///   <para>rdfs:label : parent reference system^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#system">tm:system</a>
    /// </summary>
    let system = _prefixId.prefix "system"
    /// <summary>
    ///   <para>rdfs:label : temporal position^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#temporalPosition">tm:temporalPosition</a>
    /// </summary>
    let temporalPosition = _prefixId.prefix "temporalPosition"
    /// <summary>
    ///   <para>rdfs:label : clock time^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#time">tm:time</a>
    /// </summary>
    let time = _prefixId.prefix "time"
    /// <summary>
    ///   <para>rdfs:label : temporal topology^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#topology">tm:topology</a>
    /// </summary>
    let topology = _prefixId.prefix "topology"
    /// <summary>
    ///   <para>rdfs:label : temporal position value^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#value">tm:value</a>
    /// </summary>
    let value = _prefixId.prefix "value"
