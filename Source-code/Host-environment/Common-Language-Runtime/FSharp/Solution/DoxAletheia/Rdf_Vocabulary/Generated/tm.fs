namespace http.def.seegrid.csiro.au.isotc211.iso19108._2002.temporal.hash

open DoxAletheia.Rdf_Vocabulary

module tm =
    let _namespace_name = "http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#"

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#GeometricPrimitive"></see>
    /// </summary>
    let GeometricPrimitive =
        Namespaced_IRI.parse _namespace_name "GeometricPrimitive" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#complex"></see>
    /// </summary>
    let complex = Namespaced_IRI.parse _namespace_name "complex" |> NamespacedName
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#ClockTime"></see>
    /// </summary>
    let ClockTime = Namespaced_IRI.parse _namespace_name "ClockTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#OrdinalReferenceSystem"></see>
    /// </summary>
    let OrdinalReferenceSystem =
        Namespaced_IRI.parse _namespace_name "OrdinalReferenceSystem" |> NamespacedName

    /// <summary>
    /// The value of this property indicates the temporal reference system for a time position
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#frame"></see></summary>
    let frame = Namespaced_IRI.parse _namespace_name "frame" |> NamespacedName
    /// <summary>
    /// The value of this property defines the end of a time period
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#end"></see></summary>
    let end_ = Namespaced_IRI.parse _namespace_name "end" |> NamespacedName
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#value"></see>
    /// </summary>
    let value = Namespaced_IRI.parse _namespace_name "value" |> NamespacedName
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#geometry"></see>
    /// </summary>
    let geometry = Namespaced_IRI.parse _namespace_name "geometry" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#ordinalValue"></see>
    /// </summary>
    let ordinalValue =
        Namespaced_IRI.parse _namespace_name "ordinalValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#DateAndTime"></see>
    /// </summary>
    let DateAndTime =
        Namespaced_IRI.parse _namespace_name "DateAndTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Clock"></see>
    /// </summary>
    let Clock = Namespaced_IRI.parse _namespace_name "Clock" |> NamespacedName
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#begunBy"></see>
    /// </summary>
    let begunBy = Namespaced_IRI.parse _namespace_name "begunBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Object"></see>
    /// </summary>
    let Object = Namespaced_IRI.parse _namespace_name "Object" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#TopologicalPrimitive"></see>
    /// </summary>
    let TopologicalPrimitive =
        Namespaced_IRI.parse _namespace_name "TopologicalPrimitive" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#topology"></see>
    /// </summary>
    let topology = Namespaced_IRI.parse _namespace_name "topology" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#OrdinalPosition"></see>
    /// </summary>
    let OrdinalPosition =
        Namespaced_IRI.parse _namespace_name "OrdinalPosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Instant"></see>
    /// </summary>
    let Instant = Namespaced_IRI.parse _namespace_name "Instant" |> NamespacedName
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Node"></see>
    /// </summary>
    let Node = Namespaced_IRI.parse _namespace_name "Node" |> NamespacedName
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#time"></see>
    /// </summary>
    let time = Namespaced_IRI.parse _namespace_name "time" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#temporalPosition"></see>
    /// </summary>
    let temporalPosition =
        Namespaced_IRI.parse _namespace_name "temporalPosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#ReferenceSystem"></see>
    /// </summary>
    let ReferenceSystem =
        Namespaced_IRI.parse _namespace_name "ReferenceSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#member"></see>
    /// </summary>
    let member_ = Namespaced_IRI.parse _namespace_name "member" |> NamespacedName
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#primitive"></see>
    /// </summary>
    let primitive = Namespaced_IRI.parse _namespace_name "primitive" |> NamespacedName
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Period"></see>
    /// </summary>
    let Period = Namespaced_IRI.parse _namespace_name "Period" |> NamespacedName

    /// <summary>
    /// The value of this property is a time encoded as an xsd:dateTime
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#dateTimePosition"></see></summary>
    let dateTimePosition =
        Namespaced_IRI.parse _namespace_name "dateTimePosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#endedBy"></see>
    /// </summary>
    let endedBy = Namespaced_IRI.parse _namespace_name "endedBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#CalDate"></see>
    /// </summary>
    let CalDate = Namespaced_IRI.parse _namespace_name "CalDate" |> NamespacedName
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Edge"></see>
    /// </summary>
    let Edge = Namespaced_IRI.parse _namespace_name "Edge" |> NamespacedName
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#date"></see>
    /// </summary>
    let date = Namespaced_IRI.parse _namespace_name "date" |> NamespacedName
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Calendar"></see>
    /// </summary>
    let Calendar = Namespaced_IRI.parse _namespace_name "Calendar" |> NamespacedName
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#name"></see>
    /// </summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#domainOfValidity"></see>
    /// </summary>
    let domainOfValidity =
        Namespaced_IRI.parse _namespace_name "domainOfValidity" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#system"></see>
    /// </summary>
    let system = Namespaced_IRI.parse _namespace_name "system" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#previousEdge"></see>
    /// </summary>
    let previousEdge =
        Namespaced_IRI.parse _namespace_name "previousEdge" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#nextEdge"></see>
    /// </summary>
    let nextEdge = Namespaced_IRI.parse _namespace_name "nextEdge" |> NamespacedName
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#group"></see>
    /// </summary>
    let group = Namespaced_IRI.parse _namespace_name "group" |> NamespacedName
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#OrdinalEra"></see>
    /// </summary>
    let OrdinalEra = Namespaced_IRI.parse _namespace_name "OrdinalEra" |> NamespacedName
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Coordinate"></see>
    /// </summary>
    let Coordinate = Namespaced_IRI.parse _namespace_name "Coordinate" |> NamespacedName
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Primitive"></see>
    /// </summary>
    let Primitive = Namespaced_IRI.parse _namespace_name "Primitive" |> NamespacedName
    /// <summary>
    /// The value of this property defines the beginning of a time period
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#begin"></see></summary>
    let begin_ = Namespaced_IRI.parse _namespace_name "begin" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#CoordinateSystem"></see>
    /// </summary>
    let CoordinateSystem =
        Namespaced_IRI.parse _namespace_name "CoordinateSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#Complex"></see>
    /// </summary>
    let Complex = Namespaced_IRI.parse _namespace_name "Complex" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#TopologicalComplex"></see>
    /// </summary>
    let TopologicalComplex =
        Namespaced_IRI.parse _namespace_name "TopologicalComplex" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#TemporalPosition"></see>
    /// </summary>
    let TemporalPosition =
        Namespaced_IRI.parse _namespace_name "TemporalPosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#component"></see>
    /// </summary>
    let component_ = Namespaced_IRI.parse _namespace_name "component" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#GeometricComplex"></see>
    /// </summary>
    let GeometricComplex =
        Namespaced_IRI.parse _namespace_name "GeometricComplex" |> NamespacedName
