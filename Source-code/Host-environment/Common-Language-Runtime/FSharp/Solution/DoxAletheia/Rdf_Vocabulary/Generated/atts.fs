namespace https.data.nasa.gov.ontologies.atmonto.general.hash

open DoxAletheia

module atts =
    let _namespace_name = "https://data.nasa.gov/ontologies/atmonto/general#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A two-dimensional region defined by a geographic centerpoint and radius.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#CircularRegion"></see></summary>
    let CircularRegion = _prefix "CircularRegion"
    /// <summary>
    /// A two-dimensional geographic region.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#Region2D"></see></summary>
    let Region2D = _prefix "Region2D"
    /// <summary>
    /// A subclass of NumericParameter representing parameters with floating-point values.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#FloatParameter"></see></summary>
    let FloatParameter = _prefix "FloatParameter"
    /// <summary>
    /// The numeric value of a parameter.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#parameterValue"></see></summary>
    let parameterValue = _prefix "parameterValue"
    /// <summary>
    /// A class representing numeric parameters explicitly as objects (versus representing them as datatype properties). These parameters can be inserted into containers and sequenced. This enables reuse of the same parameter value in multiple sequences.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#NumericParameter"></see></summary>
    let NumericParameter = _prefix "NumericParameter"
    /// <summary>
    /// A class representing a demarcated region on or above the surface of the Earth.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#GeographicRegion"></see></summary>
    let GeographicRegion = _prefix "GeographicRegion"
    /// <summary>
    /// A place defined by a point or a contiguous geographic region.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#Location"></see></summary>
    let Location = _prefix "Location"
    /// <summary>
    /// A subclass of NumericParameter representing parameters with interger values.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#IntegerParameter"></see></summary>
    let IntegerParameter = _prefix "IntegerParameter"
    /// <summary>
    /// A location in three-space defined by a latitude, longitude, and altitude.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#PointLocation"></see></summary>
    let PointLocation = _prefix "PointLocation"
    /// <summary>
    /// The set of items that can be sequenced.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#SequencedItem"></see></summary>
    let SequencedItem = _prefix "SequencedItem"
    /// <summary>
    /// An ordered sequence of point locations where the last point connects back to the first point, closing the polygon.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#PolygonBoundary"></see></summary>
    let PolygonBoundary = _prefix "PolygonBoundary"
    /// <summary>
    /// Links a sequence to each of the items being sequenced.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#hasSequencedItem"></see></summary>
    let hasSequencedItem = _prefix "hasSequencedItem"
    /// <summary>
    /// Links a sequence to the last item being sequenced.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#hasLastItem"></see></summary>
    let hasLastItem = _prefix "hasLastItem"
    /// <summary>
    /// Links a sequence to the first item being sequenced.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#hasFirstItem"></see></summary>
    let hasFirstItem = _prefix "hasFirstItem"
    /// <summary>
    /// An ordered sequence of items.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#Sequence"></see></summary>
    let Sequence = _prefix "Sequence"
    /// <summary>
    /// A two-dimensional region defined by a polygonal boundary.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#Polygonal2DRegion"></see></summary>
    let Polygonal2DRegion = _prefix "Polygonal2DRegion"
    /// <summary>
    /// A three-dimensional geographic region.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#Region3D"></see></summary>
    let Region3D = _prefix "Region3D"
    /// <summary>
    /// A three-dimensional volume defined by a two-dimensional polygon plus a length component that stretches the polygon along an axis perpendicular to the polygon surface.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#ShearSidedPolygonalVolume"></see></summary>
    let ShearSidedPolygonalVolume = _prefix "ShearSidedPolygonalVolume"
    /// <summary>
    /// Represents a subsequence of existing base sequence. The subsequence does not replicate the items of the sequence, but merely points to the start and end positions within the base sequence.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#SubSequence"></see></summary>
    let SubSequence = _prefix "SubSequence"
    /// <summary>
    /// A time interval with starting and ending time points. Intervals can be open (including the end points) or closed including the end points) or mixed including one but not the other end point).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#TimeInterval"></see></summary>
    let TimeInterval = _prefix "TimeInterval"
    /// <summary>
    /// The WKT string representation of a location. Well-known text (WKT) is a text markup language for representing vector geometry objects on a map, spatial reference systems of spatial objects and transformations between spatial reference systems. WKT is a standards-based representation stored as an alternative to the explicit polygon boundary representation employed in the Ontology (see gen:PolygonBoundary).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#WKTgeoRepresentation"></see></summary>
    let WKTgeoRepresentation = _prefix "WKTgeoRepresentation"
    /// <summary>
    /// The altitude of a point location.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#altitude"></see></summary>
    let altitude = _prefix "altitude"
    /// <summary>
    /// Links to the center point of the 2-D circular region.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#centerpoint"></see></summary>
    let centerpoint = _prefix "centerpoint"
    /// <summary>
    /// A boolean property that specifies whether or not the endpoint of the time interval is closes (inclusive of the point).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#closedEndTimeInterval"></see></summary>
    let closedEndTimeInterval = _prefix "closedEndTimeInterval"
    /// <summary>
    /// A boolean property that specifies whether or not the starting point of the time interval is closed (inclusive of the point).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#closedStartTimeInterval"></see></summary>
    let closedStartTimeInterval = _prefix "closedStartTimeInterval"
    /// <summary>
    /// The ending time of a defined time interval.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#endTime"></see></summary>
    let endTime = _prefix "endTime"
    /// <summary>
    /// Links an item in a sequence to the subsequent item in the sequence.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#hasNextItem"></see></summary>
    let hasNextItem = _prefix "hasNextItem"
    /// <summary>
    /// Links a polygonal region to its boundary representation.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#hasPolygonBoundary"></see></summary>
    let hasPolygonBoundary = _prefix "hasPolygonBoundary"
    /// <summary>
    /// The latitude of a point location.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#latitude"></see></summary>
    let latitude = _prefix "latitude"
    /// <summary>
    /// The longitude of a point location.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#longitude"></see></summary>
    let longitude = _prefix "longitude"
    /// <summary>
    /// Specifies the length dimension of a polygonal volume.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#polygonHeight"></see></summary>
    let polygonHeight = _prefix "polygonHeight"
    /// <summary>
    /// The radius of a circular region. Note: Unfortunately, the units are currently dependent the type of circular region defined. This needs to be improved.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#radius"></see></summary>
    let radius = _prefix "radius"
    /// <summary>
    /// The number of items in the ordered sequence.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#sequenceLength"></see></summary>
    let sequenceLength = _prefix "sequenceLength"
    /// <summary>
    /// Indicates the ordered position of this item within the sequence, where 1 signifies the first position in the sequence.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#sequenceNumber"></see></summary>
    let sequenceNumber = _prefix "sequenceNumber"
    /// <summary>
    /// The starting time of a defined time interval.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#startTime"></see></summary>
    let startTime = _prefix "startTime"
    /// <summary>
    /// A numeric position within a base sequence that represents the end of the subsequence.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#subsequenceEndIndex"></see></summary>
    let subsequenceEndIndex = _prefix "subsequenceEndIndex"
    /// <summary>
    /// Links a subsequence to its base sequence.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#subsequenceOf"></see></summary>
    let subsequenceOf = _prefix "subsequenceOf"
    /// <summary>
    /// A numeric position within a base sequence that represents the start of the subsequence.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#subsequenceStartIndex"></see></summary>
    let subsequenceStartIndex = _prefix "subsequenceStartIndex"
