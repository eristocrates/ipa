namespace https.data.nasa.gov.ontologies.atmonto.general.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module atts =
    let _namespace_iri = Namespace_Iri atts |> NamespaceIRI
    /// <summary>
    ///   <para>atts:CircularRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A two-dimensional region defined by a geographic centerpoint and radius.</para>
    /// </remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/general#CircularRegion">https://data.nasa.gov/ontologies/atmonto/general#CircularRegion</seealso>
    let CircularRegion = Prefixed_Name(atts, "CircularRegion") |> PrefixedName
    /// <summary>
    ///   <para>atts:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A place defined by a point or a contiguous geographic region.</para>
    /// labels<para>Location</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/general#Location">https://data.nasa.gov/ontologies/atmonto/general#Location</seealso>
    let Location = Prefixed_Name(atts, "Location") |> PrefixedName
    /// <summary>
    ///   <para>atts:PolygonBoundary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An ordered sequence of point locations where the last point connects back to the first point, closing the polygon.</para>
    /// labels<para>Polygon boundary</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/general#PolygonBoundary">https://data.nasa.gov/ontologies/atmonto/general#PolygonBoundary</seealso>
    let PolygonBoundary = Prefixed_Name(atts, "PolygonBoundary") |> PrefixedName
    /// <summary>
    ///   <para>atts:hasLastItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a sequence to the last item being sequenced.</para>
    /// labels<para>hasLastItem</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/general#hasLastItem">https://data.nasa.gov/ontologies/atmonto/general#hasLastItem</seealso>
    let hasLastItem = Prefixed_Name(atts, "hasLastItem") |> PrefixedName
    /// <summary>
    ///   <para>atts:Region3D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A three-dimensional geographic region.</para>
    /// </remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/general#Region3D">https://data.nasa.gov/ontologies/atmonto/general#Region3D</seealso>
    let Region3D = Prefixed_Name(atts, "Region3D") |> PrefixedName
    /// <summary>
    ///   <para>atts:centerpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Links to the center point of the 2-D circular region.</para>
    /// labels<para>centerpoint</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/general#centerpoint">https://data.nasa.gov/ontologies/atmonto/general#centerpoint</seealso>
    let centerpoint = Prefixed_Name(atts, "centerpoint") |> PrefixedName
    /// <summary>
    ///   <para>atts:Region2D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A two-dimensional geographic region.</para>
    /// </remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/general#Region2D">https://data.nasa.gov/ontologies/atmonto/general#Region2D</seealso>
    let Region2D = Prefixed_Name(atts, "Region2D") |> PrefixedName
    /// <summary>
    ///   <para>atts:parameterValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The numeric value of a parameter.</para>
    /// labels<para>parameter value</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/general#parameterValue">https://data.nasa.gov/ontologies/atmonto/general#parameterValue</seealso>
    let parameterValue = Prefixed_Name(atts, "parameterValue") |> PrefixedName
    /// <summary>
    ///   <para>atts:GeographicRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class representing a demarcated region on or above the surface of the Earth.</para>
    /// </remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/general#GeographicRegion">https://data.nasa.gov/ontologies/atmonto/general#GeographicRegion</seealso>
    let GeographicRegion = Prefixed_Name(atts, "GeographicRegion") |> PrefixedName
    /// <summary>
    ///   <para>atts:IntegerParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A subclass of NumericParameter representing parameters with interger values.</para>
    /// labels<para>Integer Parameter</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/general#IntegerParameter">https://data.nasa.gov/ontologies/atmonto/general#IntegerParameter</seealso>
    let IntegerParameter = Prefixed_Name(atts, "IntegerParameter") |> PrefixedName
    /// <summary>
    ///   <para>atts:PointLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A location in three-space defined by a latitude, longitude, and altitude.</para>
    /// </remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/general#PointLocation">https://data.nasa.gov/ontologies/atmonto/general#PointLocation</seealso>
    let PointLocation = Prefixed_Name(atts, "PointLocation") |> PrefixedName
    /// <summary>
    ///   <para>atts:hasSequencedItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a sequence to each of the items being sequenced.</para>
    /// labels<para>hasSequencedItem</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/general#hasSequencedItem">https://data.nasa.gov/ontologies/atmonto/general#hasSequencedItem</seealso>
    let hasSequencedItem = Prefixed_Name(atts, "hasSequencedItem") |> PrefixedName
    /// <summary>
    ///   <para>atts:Polygonal2DRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A two-dimensional region defined by a polygonal boundary.</para>
    /// </remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/general#Polygonal2DRegion">https://data.nasa.gov/ontologies/atmonto/general#Polygonal2DRegion</seealso>
    let Polygonal2DRegion = Prefixed_Name(atts, "Polygonal2DRegion") |> PrefixedName

    /// <summary>
    ///   <para>atts:ShearSidedPolygonalVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A three-dimensional volume defined by a two-dimensional polygon plus a length component that stretches the polygon along an axis perpendicular to the polygon surface.</para>
    /// labels<para>Shear sided polygonal volume</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/general#ShearSidedPolygonalVolume">https://data.nasa.gov/ontologies/atmonto/general#ShearSidedPolygonalVolume</seealso>
    let ShearSidedPolygonalVolume =
        Prefixed_Name(atts, "ShearSidedPolygonalVolume") |> PrefixedName

    /// <summary>
    ///   <para>atts:TimeInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A time interval with starting and ending time points. Intervals can be open (including the end points) or closed including the end points) or mixed including one but not the other end point).</para>
    /// labels<para>Time interval</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/general#TimeInterval">https://data.nasa.gov/ontologies/atmonto/general#TimeInterval</seealso>
    let TimeInterval = Prefixed_Name(atts, "TimeInterval") |> PrefixedName
    /// <summary>
    ///   <para>atts:altitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The altitude of a point location.</para>
    /// labels<para>altitude</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/general#altitude">https://data.nasa.gov/ontologies/atmonto/general#altitude</seealso>
    let altitude = Prefixed_Name(atts, "altitude") |> PrefixedName

    /// <summary>
    ///   <para>atts:closedStartTimeInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A boolean property that specifies whether or not the starting point of the time interval is closed (inclusive of the point).</para>
    /// labels<para>closed start time interval</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/general#closedStartTimeInterval">https://data.nasa.gov/ontologies/atmonto/general#closedStartTimeInterval</seealso>
    let closedStartTimeInterval =
        Prefixed_Name(atts, "closedStartTimeInterval") |> PrefixedName

    /// <summary>
    ///   <para>atts:hasPolygonBoundary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a polygonal region to its boundary representation.</para>
    /// labels<para>has polygon boundary</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/general#hasPolygonBoundary">https://data.nasa.gov/ontologies/atmonto/general#hasPolygonBoundary</seealso>
    let hasPolygonBoundary = Prefixed_Name(atts, "hasPolygonBoundary") |> PrefixedName
    /// <summary>
    ///   <para>atts:latitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The latitude of a point location.</para>
    /// labels<para>latitude</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/general#latitude">https://data.nasa.gov/ontologies/atmonto/general#latitude</seealso>
    let latitude = Prefixed_Name(atts, "latitude") |> PrefixedName
    /// <summary>
    ///   <para>atts:polygonHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specifies the length dimension of a polygonal volume.</para>
    /// labels<para>polygon height</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/general#polygonHeight">https://data.nasa.gov/ontologies/atmonto/general#polygonHeight</seealso>
    let polygonHeight = Prefixed_Name(atts, "polygonHeight") |> PrefixedName
    /// <summary>
    ///   <para>atts:radius</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The radius of a circular region. Note: Unfortunately, the units are currently dependent the type of circular region defined. This needs to be improved.</para>
    /// labels<para>radius</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/general#radius">https://data.nasa.gov/ontologies/atmonto/general#radius</seealso>
    let radius = Prefixed_Name(atts, "radius") |> PrefixedName
    /// <summary>
    ///   <para>atts:sequenceNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates the ordered position of this item within the sequence, where 1 signifies the first position in the sequence.</para>
    /// labels<para>sequenceNumber</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/general#sequenceNumber">https://data.nasa.gov/ontologies/atmonto/general#sequenceNumber</seealso>
    let sequenceNumber = Prefixed_Name(atts, "sequenceNumber") |> PrefixedName
    /// <summary>
    ///   <para>atts:subsequenceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Links a subsequence to its base sequence.</para>
    /// labels<para>subsequence of</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/general#subsequenceOf">https://data.nasa.gov/ontologies/atmonto/general#subsequenceOf</seealso>
    let subsequenceOf = Prefixed_Name(atts, "subsequenceOf") |> PrefixedName

    /// <summary>
    ///   <para>atts:subsequenceStartIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A numeric position within a base sequence that represents the start of the subsequence.</para>
    /// labels<para>subsequence start index</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/general#subsequenceStartIndex">https://data.nasa.gov/ontologies/atmonto/general#subsequenceStartIndex</seealso>
    let subsequenceStartIndex =
        Prefixed_Name(atts, "subsequenceStartIndex") |> PrefixedName

    /// <summary>
    ///   <para>atts:FloatParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A subclass of NumericParameter representing parameters with floating-point values.</para>
    /// labels<para>Float parameter</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/general#FloatParameter">https://data.nasa.gov/ontologies/atmonto/general#FloatParameter</seealso>
    let FloatParameter = Prefixed_Name(atts, "FloatParameter") |> PrefixedName
    /// <summary>
    ///   <para>atts:NumericParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class representing numeric parameters explicitly as objects (versus representing them as datatype properties). These parameters can be inserted into containers and sequenced. This enables reuse of the same parameter value in multiple sequences.</para>
    /// labels<para>Numeric Parameter</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/general#NumericParameter">https://data.nasa.gov/ontologies/atmonto/general#NumericParameter</seealso>
    let NumericParameter = Prefixed_Name(atts, "NumericParameter") |> PrefixedName
    /// <summary>
    ///   <para>atts:SequencedItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The set of items that can be sequenced.</para>
    /// labels<para>Sequenced item</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/general#SequencedItem">https://data.nasa.gov/ontologies/atmonto/general#SequencedItem</seealso>
    let SequencedItem = Prefixed_Name(atts, "SequencedItem") |> PrefixedName
    /// <summary>
    ///   <para>atts:hasFirstItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a sequence to the first item being sequenced.</para>
    /// labels<para>hasFirstItem</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/general#hasFirstItem">https://data.nasa.gov/ontologies/atmonto/general#hasFirstItem</seealso>
    let hasFirstItem = Prefixed_Name(atts, "hasFirstItem") |> PrefixedName
    /// <summary>
    ///   <para>atts:Sequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An ordered sequence of items.</para>
    /// labels<para>Sequence</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/general#Sequence">https://data.nasa.gov/ontologies/atmonto/general#Sequence</seealso>
    let Sequence = Prefixed_Name(atts, "Sequence") |> PrefixedName
    /// <summary>
    ///   <para>atts:SubSequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents a subsequence of existing base sequence. The subsequence does not replicate the items of the sequence, but merely points to the start and end positions within the base sequence.</para>
    /// labels<para>Subsequence</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/general#SubSequence">https://data.nasa.gov/ontologies/atmonto/general#SubSequence</seealso>
    let SubSequence = Prefixed_Name(atts, "SubSequence") |> PrefixedName

    /// <summary>
    ///   <para>atts:WKTgeoRepresentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The WKT string representation of a location. Well-known text (WKT) is a text markup language for representing vector geometry objects on a map, spatial reference systems of spatial objects and transformations between spatial reference systems. WKT is a standards-based representation stored as an alternative to the explicit polygon boundary representation employed in the Ontology (see gen:PolygonBoundary).</para>
    /// labels<para>Well-Known Text geographic representation</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/general#WKTgeoRepresentation">https://data.nasa.gov/ontologies/atmonto/general#WKTgeoRepresentation</seealso>
    let WKTgeoRepresentation =
        Prefixed_Name(atts, "WKTgeoRepresentation") |> PrefixedName

    /// <summary>
    ///   <para>atts:closedEndTimeInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A boolean property that specifies whether or not the endpoint of the time interval is closes (inclusive of the point).</para>
    /// labels<para>closed end time interval</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/general#closedEndTimeInterval">https://data.nasa.gov/ontologies/atmonto/general#closedEndTimeInterval</seealso>
    let closedEndTimeInterval =
        Prefixed_Name(atts, "closedEndTimeInterval") |> PrefixedName

    /// <summary>
    ///   <para>atts:endTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The ending time of a defined time interval.</para>
    /// labels<para>end time</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/general#endTime">https://data.nasa.gov/ontologies/atmonto/general#endTime</seealso>
    let endTime = Prefixed_Name(atts, "endTime") |> PrefixedName
    /// <summary>
    ///   <para>atts:hasNextItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an item in a sequence to the subsequent item in the sequence.</para>
    /// labels<para>hasNext</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/general#hasNextItem">https://data.nasa.gov/ontologies/atmonto/general#hasNextItem</seealso>
    let hasNextItem = Prefixed_Name(atts, "hasNextItem") |> PrefixedName
    /// <summary>
    ///   <para>atts:longitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The longitude of a point location.</para>
    /// labels<para>longitude</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/general#longitude">https://data.nasa.gov/ontologies/atmonto/general#longitude</seealso>
    let longitude = Prefixed_Name(atts, "longitude") |> PrefixedName
    /// <summary>
    ///   <para>atts:sequenceLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The number of items in the ordered sequence.</para>
    /// labels<para>sequence length</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/general#sequenceLength">https://data.nasa.gov/ontologies/atmonto/general#sequenceLength</seealso>
    let sequenceLength = Prefixed_Name(atts, "sequenceLength") |> PrefixedName
    /// <summary>
    ///   <para>atts:startTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The starting time of a defined time interval.</para>
    /// labels<para>start time</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/general#startTime">https://data.nasa.gov/ontologies/atmonto/general#startTime</seealso>
    let startTime = Prefixed_Name(atts, "startTime") |> PrefixedName
    /// <summary>
    ///   <para>atts:subsequenceEndIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A numeric position within a base sequence that represents the end of the subsequence.</para>
    /// labels<para>subsequence end index</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/general#subsequenceEndIndex">https://data.nasa.gov/ontologies/atmonto/general#subsequenceEndIndex</seealso>
    let subsequenceEndIndex = Prefixed_Name(atts, "subsequenceEndIndex") |> PrefixedName
