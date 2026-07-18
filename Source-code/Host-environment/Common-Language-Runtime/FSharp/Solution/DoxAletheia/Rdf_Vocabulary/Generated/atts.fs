namespace https.data.nasa.gov.ontologies.atmonto.general.hash

open DoxAletheia.Rdf_Vocabulary

module atts =
    let _namespace_name = "https://data.nasa.gov/ontologies/atmonto/general#"

    /// <summary>
    /// A two-dimensional region defined by a geographic centerpoint and radius.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#CircularRegion"></see></summary>
    let CircularRegion =
        Namespaced_IRI.parse _namespace_name "CircularRegion" |> NamespacedName

    /// <summary>
    /// A two-dimensional geographic region.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#Region2D"></see></summary>
    let Region2D = Namespaced_IRI.parse _namespace_name "Region2D" |> NamespacedName

    /// <summary>
    /// A subclass of NumericParameter representing parameters with floating-point values.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#FloatParameter"></see></summary>
    let FloatParameter =
        Namespaced_IRI.parse _namespace_name "FloatParameter" |> NamespacedName

    /// <summary>
    /// The numeric value of a parameter.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#parameterValue"></see></summary>
    let parameterValue =
        Namespaced_IRI.parse _namespace_name "parameterValue" |> NamespacedName

    /// <summary>
    /// A class representing numeric parameters explicitly as objects (versus representing them as datatype properties). These parameters can be inserted into containers and sequenced. This enables reuse of the same parameter value in multiple sequences.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#NumericParameter"></see></summary>
    let NumericParameter =
        Namespaced_IRI.parse _namespace_name "NumericParameter" |> NamespacedName

    /// <summary>
    /// A class representing a demarcated region on or above the surface of the Earth.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#GeographicRegion"></see></summary>
    let GeographicRegion =
        Namespaced_IRI.parse _namespace_name "GeographicRegion" |> NamespacedName

    /// <summary>
    /// A place defined by a point or a contiguous geographic region.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#Location"></see></summary>
    let Location = Namespaced_IRI.parse _namespace_name "Location" |> NamespacedName

    /// <summary>
    /// A subclass of NumericParameter representing parameters with interger values.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#IntegerParameter"></see></summary>
    let IntegerParameter =
        Namespaced_IRI.parse _namespace_name "IntegerParameter" |> NamespacedName

    /// <summary>
    /// A location in three-space defined by a latitude, longitude, and altitude.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#PointLocation"></see></summary>
    let PointLocation =
        Namespaced_IRI.parse _namespace_name "PointLocation" |> NamespacedName

    /// <summary>
    /// The set of items that can be sequenced.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#SequencedItem"></see></summary>
    let SequencedItem =
        Namespaced_IRI.parse _namespace_name "SequencedItem" |> NamespacedName

    /// <summary>
    /// An ordered sequence of point locations where the last point connects back to the first point, closing the polygon.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#PolygonBoundary"></see></summary>
    let PolygonBoundary =
        Namespaced_IRI.parse _namespace_name "PolygonBoundary" |> NamespacedName

    /// <summary>
    /// Links a sequence to each of the items being sequenced.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#hasSequencedItem"></see></summary>
    let hasSequencedItem =
        Namespaced_IRI.parse _namespace_name "hasSequencedItem" |> NamespacedName

    /// <summary>
    /// Links a sequence to the last item being sequenced.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#hasLastItem"></see></summary>
    let hasLastItem =
        Namespaced_IRI.parse _namespace_name "hasLastItem" |> NamespacedName

    /// <summary>
    /// Links a sequence to the first item being sequenced.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#hasFirstItem"></see></summary>
    let hasFirstItem =
        Namespaced_IRI.parse _namespace_name "hasFirstItem" |> NamespacedName

    /// <summary>
    /// An ordered sequence of items.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#Sequence"></see></summary>
    let Sequence = Namespaced_IRI.parse _namespace_name "Sequence" |> NamespacedName

    /// <summary>
    /// A two-dimensional region defined by a polygonal boundary.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#Polygonal2DRegion"></see></summary>
    let Polygonal2DRegion =
        Namespaced_IRI.parse _namespace_name "Polygonal2DRegion" |> NamespacedName

    /// <summary>
    /// A three-dimensional geographic region.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#Region3D"></see></summary>
    let Region3D = Namespaced_IRI.parse _namespace_name "Region3D" |> NamespacedName

    /// <summary>
    /// A three-dimensional volume defined by a two-dimensional polygon plus a length component that stretches the polygon along an axis perpendicular to the polygon surface.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#ShearSidedPolygonalVolume"></see></summary>
    let ShearSidedPolygonalVolume =
        Namespaced_IRI.parse _namespace_name "ShearSidedPolygonalVolume" |> NamespacedName

    /// <summary>
    /// Represents a subsequence of existing base sequence. The subsequence does not replicate the items of the sequence, but merely points to the start and end positions within the base sequence.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#SubSequence"></see></summary>
    let SubSequence =
        Namespaced_IRI.parse _namespace_name "SubSequence" |> NamespacedName

    /// <summary>
    /// A time interval with starting and ending time points. Intervals can be open (including the end points) or closed including the end points) or mixed including one but not the other end point).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#TimeInterval"></see></summary>
    let TimeInterval =
        Namespaced_IRI.parse _namespace_name "TimeInterval" |> NamespacedName

    /// <summary>
    /// The WKT string representation of a location. Well-known text (WKT) is a text markup language for representing vector geometry objects on a map, spatial reference systems of spatial objects and transformations between spatial reference systems. WKT is a standards-based representation stored as an alternative to the explicit polygon boundary representation employed in the Ontology (see gen:PolygonBoundary).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#WKTgeoRepresentation"></see></summary>
    let WKTgeoRepresentation =
        Namespaced_IRI.parse _namespace_name "WKTgeoRepresentation" |> NamespacedName

    /// <summary>
    /// The altitude of a point location.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#altitude"></see></summary>
    let altitude = Namespaced_IRI.parse _namespace_name "altitude" |> NamespacedName

    /// <summary>
    /// Links to the center point of the 2-D circular region.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#centerpoint"></see></summary>
    let centerpoint =
        Namespaced_IRI.parse _namespace_name "centerpoint" |> NamespacedName

    /// <summary>
    /// A boolean property that specifies whether or not the endpoint of the time interval is closes (inclusive of the point).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#closedEndTimeInterval"></see></summary>
    let closedEndTimeInterval =
        Namespaced_IRI.parse _namespace_name "closedEndTimeInterval" |> NamespacedName

    /// <summary>
    /// A boolean property that specifies whether or not the starting point of the time interval is closed (inclusive of the point).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#closedStartTimeInterval"></see></summary>
    let closedStartTimeInterval =
        Namespaced_IRI.parse _namespace_name "closedStartTimeInterval" |> NamespacedName

    /// <summary>
    /// The ending time of a defined time interval.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#endTime"></see></summary>
    let endTime = Namespaced_IRI.parse _namespace_name "endTime" |> NamespacedName

    /// <summary>
    /// Links an item in a sequence to the subsequent item in the sequence.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#hasNextItem"></see></summary>
    let hasNextItem =
        Namespaced_IRI.parse _namespace_name "hasNextItem" |> NamespacedName

    /// <summary>
    /// Links a polygonal region to its boundary representation.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#hasPolygonBoundary"></see></summary>
    let hasPolygonBoundary =
        Namespaced_IRI.parse _namespace_name "hasPolygonBoundary" |> NamespacedName

    /// <summary>
    /// The latitude of a point location.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#latitude"></see></summary>
    let latitude = Namespaced_IRI.parse _namespace_name "latitude" |> NamespacedName
    /// <summary>
    /// The longitude of a point location.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#longitude"></see></summary>
    let longitude = Namespaced_IRI.parse _namespace_name "longitude" |> NamespacedName

    /// <summary>
    /// Specifies the length dimension of a polygonal volume.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#polygonHeight"></see></summary>
    let polygonHeight =
        Namespaced_IRI.parse _namespace_name "polygonHeight" |> NamespacedName

    /// <summary>
    /// The radius of a circular region. Note: Unfortunately, the units are currently dependent the type of circular region defined. This needs to be improved.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#radius"></see></summary>
    let radius = Namespaced_IRI.parse _namespace_name "radius" |> NamespacedName

    /// <summary>
    /// The number of items in the ordered sequence.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#sequenceLength"></see></summary>
    let sequenceLength =
        Namespaced_IRI.parse _namespace_name "sequenceLength" |> NamespacedName

    /// <summary>
    /// Indicates the ordered position of this item within the sequence, where 1 signifies the first position in the sequence.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#sequenceNumber"></see></summary>
    let sequenceNumber =
        Namespaced_IRI.parse _namespace_name "sequenceNumber" |> NamespacedName

    /// <summary>
    /// The starting time of a defined time interval.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#startTime"></see></summary>
    let startTime = Namespaced_IRI.parse _namespace_name "startTime" |> NamespacedName

    /// <summary>
    /// A numeric position within a base sequence that represents the end of the subsequence.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#subsequenceEndIndex"></see></summary>
    let subsequenceEndIndex =
        Namespaced_IRI.parse _namespace_name "subsequenceEndIndex" |> NamespacedName

    /// <summary>
    /// Links a subsequence to its base sequence.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#subsequenceOf"></see></summary>
    let subsequenceOf =
        Namespaced_IRI.parse _namespace_name "subsequenceOf" |> NamespacedName

    /// <summary>
    /// A numeric position within a base sequence that represents the start of the subsequence.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/general#subsequenceStartIndex"></see></summary>
    let subsequenceStartIndex =
        Namespaced_IRI.parse _namespace_name "subsequenceStartIndex" |> NamespacedName
