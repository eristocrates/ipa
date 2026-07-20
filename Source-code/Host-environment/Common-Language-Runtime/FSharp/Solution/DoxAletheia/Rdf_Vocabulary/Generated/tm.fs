namespace http.def.seegrid.csiro.au.isotc211.iso19108._2002.temporal.hash

open DoxAletheia

module tm =
    let _namespace_name = "http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#GeometricPrimitive"></see>
    /// </summary>
    let GeometricPrimitive = _prefix "GeometricPrimitive"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#complex"></see>
    /// </summary>
    let complex = _prefix "complex"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#ClockTime"></see>
    /// </summary>
    let ClockTime = _prefix "ClockTime"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#OrdinalReferenceSystem"></see>
    /// </summary>
    let OrdinalReferenceSystem = _prefix "OrdinalReferenceSystem"
    /// <summary>
    /// The value of this property indicates the temporal reference system for a time position
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#frame"></see></summary>
    let frame = _prefix "frame"
    /// <summary>
    /// The value of this property defines the end of a time period
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#end"></see></summary>
    let end_ = _prefix "end"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#value"></see>
    /// </summary>
    let value = _prefix "value"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#geometry"></see>
    /// </summary>
    let geometry = _prefix "geometry"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#ordinalValue"></see>
    /// </summary>
    let ordinalValue = _prefix "ordinalValue"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#DateAndTime"></see>
    /// </summary>
    let DateAndTime = _prefix "DateAndTime"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Clock"></see>
    /// </summary>
    let Clock = _prefix "Clock"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#begunBy"></see>
    /// </summary>
    let begunBy = _prefix "begunBy"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Object"></see>
    /// </summary>
    let Object = _prefix "Object"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#TopologicalPrimitive"></see>
    /// </summary>
    let TopologicalPrimitive = _prefix "TopologicalPrimitive"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#topology"></see>
    /// </summary>
    let topology = _prefix "topology"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#OrdinalPosition"></see>
    /// </summary>
    let OrdinalPosition = _prefix "OrdinalPosition"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Instant"></see>
    /// </summary>
    let Instant = _prefix "Instant"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Node"></see>
    /// </summary>
    let Node = _prefix "Node"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#time"></see>
    /// </summary>
    let time = _prefix "time"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#temporalPosition"></see>
    /// </summary>
    let temporalPosition = _prefix "temporalPosition"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#ReferenceSystem"></see>
    /// </summary>
    let ReferenceSystem = _prefix "ReferenceSystem"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#member"></see>
    /// </summary>
    let member_ = _prefix "member"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#primitive"></see>
    /// </summary>
    let primitive = _prefix "primitive"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Period"></see>
    /// </summary>
    let Period = _prefix "Period"
    /// <summary>
    /// The value of this property is a time encoded as an xsd:dateTime
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#dateTimePosition"></see></summary>
    let dateTimePosition = _prefix "dateTimePosition"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#endedBy"></see>
    /// </summary>
    let endedBy = _prefix "endedBy"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#CalDate"></see>
    /// </summary>
    let CalDate = _prefix "CalDate"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Edge"></see>
    /// </summary>
    let Edge = _prefix "Edge"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#date"></see>
    /// </summary>
    let date = _prefix "date"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Calendar"></see>
    /// </summary>
    let Calendar = _prefix "Calendar"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#name"></see>
    /// </summary>
    let name = _prefix "name"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#domainOfValidity"></see>
    /// </summary>
    let domainOfValidity = _prefix "domainOfValidity"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#system"></see>
    /// </summary>
    let system = _prefix "system"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#previousEdge"></see>
    /// </summary>
    let previousEdge = _prefix "previousEdge"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#nextEdge"></see>
    /// </summary>
    let nextEdge = _prefix "nextEdge"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#group"></see>
    /// </summary>
    let group = _prefix "group"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#OrdinalEra"></see>
    /// </summary>
    let OrdinalEra = _prefix "OrdinalEra"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Coordinate"></see>
    /// </summary>
    let Coordinate = _prefix "Coordinate"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Primitive"></see>
    /// </summary>
    let Primitive = _prefix "Primitive"
    /// <summary>
    /// The value of this property defines the beginning of a time period
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#begin"></see></summary>
    let begin_ = _prefix "begin"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#CoordinateSystem"></see>
    /// </summary>
    let CoordinateSystem = _prefix "CoordinateSystem"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Complex"></see>
    /// </summary>
    let Complex = _prefix "Complex"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#TopologicalComplex"></see>
    /// </summary>
    let TopologicalComplex = _prefix "TopologicalComplex"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#TemporalPosition"></see>
    /// </summary>
    let TemporalPosition = _prefix "TemporalPosition"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#component"></see>
    /// </summary>
    let component_ = _prefix "component"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#GeometricComplex"></see>
    /// </summary>
    let GeometricComplex = _prefix "GeometricComplex"
