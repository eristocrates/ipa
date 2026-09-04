#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module atts =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://data.nasa.gov/ontologies/atmonto/general#" "atts"

    /// <summary>
    ///   <para>rdfs:comment : A two-dimensional region defined by a geographic centerpoint and radius.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/general#CircularRegion">atts:CircularRegion</a>
    /// </summary>
    let CircularRegion = _prefixId.prefix "CircularRegion"
    /// <summary>
    ///   <para>rdfs:label : Float parameter^^xsd:string</para>
    ///   <para>rdfs:comment : A subclass of NumericParameter representing parameters with floating-point values.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/general#FloatParameter">atts:FloatParameter</a>
    /// </summary>
    let FloatParameter = _prefixId.prefix "FloatParameter"
    /// <summary>
    ///   <para>rdfs:comment : A class representing a demarcated region on or above the surface of the Earth.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/general#GeographicRegion">atts:GeographicRegion</a>
    /// </summary>
    let GeographicRegion = _prefixId.prefix "GeographicRegion"
    /// <summary>
    ///   <para>rdfs:label : Integer Parameter^^xsd:string</para>
    ///   <para>rdfs:comment : A subclass of NumericParameter representing parameters with interger values.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/general#IntegerParameter">atts:IntegerParameter</a>
    /// </summary>
    let IntegerParameter = _prefixId.prefix "IntegerParameter"
    /// <summary>
    ///   <para>rdfs:label : Location^^xsd:string</para>
    ///   <para>rdfs:comment : A place defined by a point or a contiguous geographic region.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/general#Location">atts:Location</a>
    /// </summary>
    let Location = _prefixId.prefix "Location"
    /// <summary>
    ///   <para>rdfs:label : Numeric Parameter^^xsd:string</para>
    ///   <para>rdfs:comment : A class representing numeric parameters explicitly as objects (versus representing them as datatype properties). These parameters can be inserted into containers and sequenced. This enables reuse of the same parameter value in multiple sequences.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/general#NumericParameter">atts:NumericParameter</a>
    /// </summary>
    let NumericParameter = _prefixId.prefix "NumericParameter"
    /// <summary>
    ///   <para>rdfs:comment : A location in three-space defined by a latitude, longitude, and altitude.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/general#PointLocation">atts:PointLocation</a>
    /// </summary>
    let PointLocation = _prefixId.prefix "PointLocation"
    /// <summary>
    ///   <para>rdfs:label : Polygon boundary^^xsd:string</para>
    ///   <para>rdfs:comment : An ordered sequence of point locations where the last point connects back to the first point, closing the polygon.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/general#PolygonBoundary">atts:PolygonBoundary</a>
    /// </summary>
    let PolygonBoundary = _prefixId.prefix "PolygonBoundary"
    /// <summary>
    ///   <para>rdfs:comment : A two-dimensional region defined by a polygonal boundary.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/general#Polygonal2DRegion">atts:Polygonal2DRegion</a>
    /// </summary>
    let Polygonal2DRegion = _prefixId.prefix "Polygonal2DRegion"
    /// <summary>
    ///   <para>rdfs:comment : A two-dimensional geographic region.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/general#Region2D">atts:Region2D</a>
    /// </summary>
    let Region2D = _prefixId.prefix "Region2D"
    /// <summary>
    ///   <para>rdfs:comment : A three-dimensional geographic region.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/general#Region3D">atts:Region3D</a>
    /// </summary>
    let Region3D = _prefixId.prefix "Region3D"
    /// <summary>
    ///   <para>rdfs:label : Sequence^^xsd:string</para>
    ///   <para>rdfs:comment : An ordered sequence of items.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/general#Sequence">atts:Sequence</a>
    /// </summary>
    let Sequence = _prefixId.prefix "Sequence"
    /// <summary>
    ///   <para>rdfs:label : Sequenced item^^xsd:string</para>
    ///   <para>rdfs:comment : The set of items that can be sequenced.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/general#SequencedItem">atts:SequencedItem</a>
    /// </summary>
    let SequencedItem = _prefixId.prefix "SequencedItem"
    /// <summary>
    ///   <para>rdfs:label : Shear sided polygonal volume^^xsd:string</para>
    ///   <para>rdfs:comment : A three-dimensional volume defined by a two-dimensional polygon plus a length component that stretches the polygon along an axis perpendicular to the polygon surface.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/general#ShearSidedPolygonalVolume">atts:ShearSidedPolygonalVolume</a>
    /// </summary>
    let ShearSidedPolygonalVolume = _prefixId.prefix "ShearSidedPolygonalVolume"
    /// <summary>
    ///   <para>rdfs:label : Subsequence^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a subsequence of existing base sequence. The subsequence does not replicate the items of the sequence, but merely points to the start and end positions within the base sequence.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/general#SubSequence">atts:SubSequence</a>
    /// </summary>
    let SubSequence = _prefixId.prefix "SubSequence"
    /// <summary>
    ///   <para>rdfs:label : Time interval^^xsd:string</para>
    ///   <para>rdfs:comment : A time interval with starting and ending time points. Intervals can be open (including the end points) or closed including the end points) or mixed including one but not the other end point).^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/general#TimeInterval">atts:TimeInterval</a>
    /// </summary>
    let TimeInterval = _prefixId.prefix "TimeInterval"
    /// <summary>
    ///   <para>rdfs:label : Well-Known Text geographic representation^^xsd:string</para>
    ///   <para>rdfs:comment : The WKT string representation of a location. Well-known text (WKT) is a text markup language for representing vector geometry objects on a map, spatial reference systems of spatial objects and transformations between spatial reference systems. WKT is a standards-based representation stored as an alternative to the explicit polygon boundary representation employed in the Ontology (see gen:PolygonBoundary).^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/general#WKTgeoRepresentation">atts:WKTgeoRepresentation</a>
    /// </summary>
    let WKTgeoRepresentation = _prefixId.prefix "WKTgeoRepresentation"
    /// <summary>
    ///   <para>rdfs:label : altitude^^xsd:string</para>
    ///   <para>rdfs:comment : The altitude of a point location.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/general#altitude">atts:altitude</a>
    /// </summary>
    let altitude = _prefixId.prefix "altitude"
    /// <summary>
    ///   <para>rdfs:label : centerpoint^^xsd:string</para>
    ///   <para>rdfs:comment : Links to the center point of the 2-D circular region.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/general#centerpoint">atts:centerpoint</a>
    /// </summary>
    let centerpoint = _prefixId.prefix "centerpoint"
    /// <summary>
    ///   <para>rdfs:label : closed end time interval^^xsd:string</para>
    ///   <para>rdfs:comment : A boolean property that specifies whether or not the endpoint of the time interval is closes (inclusive of the point).^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/general#closedEndTimeInterval">atts:closedEndTimeInterval</a>
    /// </summary>
    let closedEndTimeInterval = _prefixId.prefix "closedEndTimeInterval"
    /// <summary>
    ///   <para>rdfs:label : closed start time interval^^xsd:string</para>
    ///   <para>rdfs:comment : A boolean property that specifies whether or not the starting point of the time interval is closed (inclusive of the point).^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/general#closedStartTimeInterval">atts:closedStartTimeInterval</a>
    /// </summary>
    let closedStartTimeInterval = _prefixId.prefix "closedStartTimeInterval"
    /// <summary>
    ///   <para>rdfs:label : end time^^xsd:string</para>
    ///   <para>rdfs:comment : The ending time of a defined time interval.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/general#endTime">atts:endTime</a>
    /// </summary>
    let endTime = _prefixId.prefix "endTime"
    /// <summary>
    ///   <para>rdfs:label : hasFirstItem^^xsd:string</para>
    ///   <para>rdfs:comment : Links a sequence to the first item being sequenced.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/general#hasFirstItem">atts:hasFirstItem</a>
    /// </summary>
    let hasFirstItem = _prefixId.prefix "hasFirstItem"
    /// <summary>
    ///   <para>rdfs:label : hasLastItem^^xsd:string</para>
    ///   <para>rdfs:comment : Links a sequence to the last item being sequenced.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/general#hasLastItem">atts:hasLastItem</a>
    /// </summary>
    let hasLastItem = _prefixId.prefix "hasLastItem"
    /// <summary>
    ///   <para>rdfs:label : hasNext^^xsd:string</para>
    ///   <para>rdfs:comment : Links an item in a sequence to the subsequent item in the sequence.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/general#hasNextItem">atts:hasNextItem</a>
    /// </summary>
    let hasNextItem = _prefixId.prefix "hasNextItem"
    /// <summary>
    ///   <para>rdfs:label : has polygon boundary^^xsd:string</para>
    ///   <para>rdfs:comment : Links a polygonal region to its boundary representation.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/general#hasPolygonBoundary">atts:hasPolygonBoundary</a>
    /// </summary>
    let hasPolygonBoundary = _prefixId.prefix "hasPolygonBoundary"
    /// <summary>
    ///   <para>rdfs:label : hasSequencedItem^^xsd:string</para>
    ///   <para>rdfs:comment : Links a sequence to each of the items being sequenced.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/general#hasSequencedItem">atts:hasSequencedItem</a>
    /// </summary>
    let hasSequencedItem = _prefixId.prefix "hasSequencedItem"
    /// <summary>
    ///   <para>rdfs:label : latitude^^xsd:string</para>
    ///   <para>rdfs:comment : The latitude of a point location.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/general#latitude">atts:latitude</a>
    /// </summary>
    let latitude = _prefixId.prefix "latitude"
    /// <summary>
    ///   <para>rdfs:label : longitude^^xsd:string</para>
    ///   <para>rdfs:comment : The longitude of a point location.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/general#longitude">atts:longitude</a>
    /// </summary>
    let longitude = _prefixId.prefix "longitude"
    /// <summary>
    ///   <para>rdfs:label : parameter value^^xsd:string</para>
    ///   <para>rdfs:comment : The numeric value of a parameter.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/general#parameterValue">atts:parameterValue</a>
    /// </summary>
    let parameterValue = _prefixId.prefix "parameterValue"
    /// <summary>
    ///   <para>rdfs:label : polygon height^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies the length dimension of a polygonal volume.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/general#polygonHeight">atts:polygonHeight</a>
    /// </summary>
    let polygonHeight = _prefixId.prefix "polygonHeight"
    /// <summary>
    ///   <para>rdfs:label : radius^^xsd:string</para>
    ///   <para>rdfs:comment : The radius of a circular region. Note: Unfortunately, the units are currently dependent the type of circular region defined. This needs to be improved.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/general#radius">atts:radius</a>
    /// </summary>
    let radius = _prefixId.prefix "radius"
    /// <summary>
    ///   <para>rdfs:label : sequence length^^xsd:string</para>
    ///   <para>rdfs:comment : The number of items in the ordered sequence.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/general#sequenceLength">atts:sequenceLength</a>
    /// </summary>
    let sequenceLength = _prefixId.prefix "sequenceLength"
    /// <summary>
    ///   <para>rdfs:label : sequenceNumber^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the ordered position of this item within the sequence, where 1 signifies the first position in the sequence.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/general#sequenceNumber">atts:sequenceNumber</a>
    /// </summary>
    let sequenceNumber = _prefixId.prefix "sequenceNumber"
    /// <summary>
    ///   <para>rdfs:label : start time^^xsd:string</para>
    ///   <para>rdfs:comment : The starting time of a defined time interval.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/general#startTime">atts:startTime</a>
    /// </summary>
    let startTime = _prefixId.prefix "startTime"
    /// <summary>
    ///   <para>rdfs:label : subsequence end index^^xsd:string</para>
    ///   <para>rdfs:comment : A numeric position within a base sequence that represents the end of the subsequence.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/general#subsequenceEndIndex">atts:subsequenceEndIndex</a>
    /// </summary>
    let subsequenceEndIndex = _prefixId.prefix "subsequenceEndIndex"
    /// <summary>
    ///   <para>rdfs:label : subsequence of^^xsd:string</para>
    ///   <para>rdfs:comment : Links a subsequence to its base sequence.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/general#subsequenceOf">atts:subsequenceOf</a>
    /// </summary>
    let subsequenceOf = _prefixId.prefix "subsequenceOf"
    /// <summary>
    ///   <para>rdfs:label : subsequence start index^^xsd:string</para>
    ///   <para>rdfs:comment : A numeric position within a base sequence that represents the start of the subsequence.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/general#subsequenceStartIndex">atts:subsequenceStartIndex</a>
    /// </summary>
    let subsequenceStartIndex = _prefixId.prefix "subsequenceStartIndex"
