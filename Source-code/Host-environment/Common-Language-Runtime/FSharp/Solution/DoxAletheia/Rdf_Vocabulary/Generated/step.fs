namespace http.purl.org.net.step.hash

open DoxAletheia

module step =
    let _namespace_name = "http://purl.org/net/step#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The agent is the moving object. It can be a person, an animal, a car, etc.
    /// <see href="http://purl.org/net/step#Agent"></see></summary>
    let Agent = _prefix "Agent"
    /// <summary>
    /// The contextual element can be anything related to the trajectory. It can be another agent, another trajectory, a geographic feature, etc.
    /// <see href="http://purl.org/net/step#ContextualElement"></see></summary>
    let ContextualElement = _prefix "ContextualElement"
    /// <summary>
    /// The episode is the smallest semantic unity for discretizing some aspect of a Feature of Interest.
    /// <see href="http://purl.org/net/step#Episode"></see></summary>
    let Episode = _prefix "Episode"
    /// <summary>
    /// Extent is a superclass for all kinds of extents an Episode may have.
    /// <see href="http://purl.org/net/step#Extent"></see></summary>
    let Extent = _prefix "Extent"
    /// <summary>
    /// The aspect of the trajectory or context that is being described. Example: speed, direction, etc.
    /// <see href="http://purl.org/net/step#FeatureOfInterest"></see></summary>
    let FeatureOfInterest = _prefix "FeatureOfInterest"
    /// <summary>
    /// A Fix is a spatial timestamped point.
    /// <see href="http://purl.org/net/step#Fix"></see></summary>
    let Fix = _prefix "Fix"
    /// <summary>
    /// Key Points delimits the extent of SpatiotemporalExtents and can also be used to represent important points of a trajectory.
    /// <see href="http://purl.org/net/step#KeyPoint"></see></summary>
    let KeyPoint = _prefix "KeyPoint"
    /// <summary>
    /// Represent the raw data from trajectories. As there's no official support for ensuring sequential ordering of tuples, we advise putting sequential numbers into the URLs of fixes to be able to retrieve the spatial footprint of the trajectory. Another solution is querying using an ORDER BY statement that sorts by the time:Interval of each Fix that composes the RawTrajectory.
    /// <see href="http://purl.org/net/step#RawTrajectory"></see></summary>
    let RawTrajectory = _prefix "RawTrajectory"
    /// <summary>
    /// Each episode may have one or many semantic descriptions, which can be of two types: Qualitative or Quantitative.
    /// <see href="http://purl.org/net/step#SemanticDescription"></see></summary>
    let SemanticDescription = _prefix "SemanticDescription"
    /// <summary>
    /// The agent's trajectory.
    /// <see href="http://purl.org/net/step#Trajectory"></see></summary>
    let Trajectory = _prefix "Trajectory"
    /// <summary>
    /// Links the Fix or KeyPoint to a time instant.
    /// <see href="http://purl.org/net/step#atTime"></see></summary>
    let atTime = _prefix "atTime"
    /// <summary>
    /// Links a Spatiotemporal extent to a KeyPoint that defines when and where the episode finishes.
    /// <see href="http://purl.org/net/step#hasEndingPoint"></see></summary>
    let hasEndingPoint = _prefix "hasEndingPoint"
    /// <summary>
    /// Links a Feature of Interest to its corresponding Episodes.
    /// <see href="http://purl.org/net/step#hasEpisode"></see></summary>
    let hasEpisode = _prefix "hasEpisode"
    /// <summary>
    /// Links an episode to an extent.
    /// <see href="http://purl.org/net/step#hasExtent"></see></summary>
    let hasExtent = _prefix "hasExtent"
    /// <summary>
    /// Links a Trajectory or Contextual Element to a Feature of Interest.
    /// <see href="http://purl.org/net/step#hasFeature"></see></summary>
    let hasFeature = _prefix "hasFeature"
    /// <summary>
    /// Links each Fix to its Raw Trajectory.
    /// <see href="http://purl.org/net/step#hasFix"></see></summary>
    let hasFix = _prefix "hasFix"
    /// <summary>
    /// Links a Fix or a KeyPoint to a location.
    /// <see href="http://purl.org/net/step#hasLocation"></see></summary>
    let hasLocation = _prefix "hasLocation"
    /// <summary>
    /// Links any point of the trajectory to a spatiotemporal extent.
    /// <see href="http://purl.org/net/step#hasPoint"></see></summary>
    let hasPoint = _prefix "hasPoint"
    /// <summary>
    /// Links a trajectory to its own raw representation.
    /// <see href="http://purl.org/net/step#hasRawTrajectory"></see></summary>
    let hasRawTrajectory = _prefix "hasRawTrajectory"
    /// <summary>
    /// Links an episode to a description.
    /// <see href="http://purl.org/net/step#hasSemanticDescription"></see></summary>
    let hasSemanticDescription = _prefix "hasSemanticDescription"
    /// <summary>
    /// Links a Spatiotemporal extent to a KeyPoint that defines when and where the episode starts.
    /// <see href="http://purl.org/net/step#hasStartingPoint"></see></summary>
    let hasStartingPoint = _prefix "hasStartingPoint"
    /// <summary>
    /// Links an Agent to a Trajectory.
    /// <see href="http://purl.org/net/step#hasTrajectory"></see></summary>
    let hasTrajectory = _prefix "hasTrajectory"
    /// <summary>
    /// Links an Unit to a Quantitative Description.
    /// <see href="http://purl.org/net/step#hasUnit"></see></summary>
    let hasUnit = _prefix "hasUnit"
    /// <summary>
    /// Links an Episode to a ContextualElement.
    /// <see href="http://purl.org/net/step#relatesTo"></see></summary>
    let relatesTo = _prefix "relatesTo"
    /// <summary>
    /// A Qualitative Description is used in situations when the Episode cannot be described by numeric values. This is also a point of extension of the ontology as other ontologies can be plugged here for extending it. For instance, one can define values such as "slow", "medium", or "fast" for speed episodes.
    /// <see href="http://purl.org/net/step#QualitativeDescription"></see></summary>
    let QualitativeDescription = _prefix "QualitativeDescription"
    /// <summary>
    /// The value associated to the Episode. For instance, integer, decimal values. It is also associated with an Unit.
    /// <see href="http://purl.org/net/step#QuantitativeValue"></see></summary>
    let QuantitativeValue = _prefix "QuantitativeValue"
    /// <summary>
    /// An extent determined only by spatial concepts (points, lines, polygons, etc). The usage of OGC Simple Features is a suggestion and can be exchanged by other ontologies.
    /// <see href="http://purl.org/net/step#SpatialExtent"></see></summary>
    let SpatialExtent = _prefix "SpatialExtent"
    /// <summary>
    /// Spatiotemporal extents are delimited by KeyPoints and the properties hasStartingPoint and hasEndingPoint. Event-like episodes may be delimited by the property hasPoint.
    /// <see href="http://purl.org/net/step#SpatiotemporalExtent"></see></summary>
    let SpatiotemporalExtent = _prefix "SpatiotemporalExtent"
    /// <summary>
    /// An extent determined only by temporal concepts (interval, instant, etc). The usage of OWL Time is a suggestion and can be exchanged by other ontologies.
    /// <see href="http://purl.org/net/step#TemporalExtent"></see></summary>
    let TemporalExtent = _prefix "TemporalExtent"
    /// <summary>
    /// Links the value to a QuantitativeValue of an Episode.
    /// <see href="http://purl.org/net/step#hasValue"></see></summary>
    let hasValue = _prefix "hasValue"
