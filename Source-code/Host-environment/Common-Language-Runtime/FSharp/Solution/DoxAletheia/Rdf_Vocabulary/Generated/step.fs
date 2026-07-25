namespace http.purl.org.net.step.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module step =
    let _namespace_iri = Namespace_Iri step |> NamespaceIRI
    /// <summary>
    ///   <para>step:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The agent is the moving object. It can be a person, an animal, a car, etc.</para>
    /// labels<para>Agent</para></remarks>
    /// <seealso href="http://purl.org/net/step#Agent">http://purl.org/net/step#Agent</seealso>
    let Agent = Prefixed_Name(step, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>step:TemporalExtent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An extent determined only by temporal concepts (interval, instant, etc). The usage of OWL Time is a suggestion and can be exchanged by other ontologies.</para>
    /// labels<para>Temporal Extent</para></remarks>
    /// <seealso href="http://purl.org/net/step#TemporalExtent">http://purl.org/net/step#TemporalExtent</seealso>
    let TemporalExtent = Prefixed_Name(step, "TemporalExtent") |> PrefixedName
    /// <summary>
    ///   <para>step:FeatureOfInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The aspect of the trajectory or context that is being described. Example: speed, direction, etc.</para>
    /// labels<para>Feature of Interest</para></remarks>
    /// <seealso href="http://purl.org/net/step#FeatureOfInterest">http://purl.org/net/step#FeatureOfInterest</seealso>
    let FeatureOfInterest = Prefixed_Name(step, "FeatureOfInterest") |> PrefixedName
    /// <summary>
    ///   <para>step:KeyPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Key Points delimits the extent of SpatiotemporalExtents and can also be used to represent important points of a trajectory.</para>
    /// labels<para>Key Point</para></remarks>
    /// <seealso href="http://purl.org/net/step#KeyPoint">http://purl.org/net/step#KeyPoint</seealso>
    let KeyPoint = Prefixed_Name(step, "KeyPoint") |> PrefixedName
    /// <summary>
    ///   <para>step:Extent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Extent is a superclass for all kinds of extents an Episode may have.</para>
    /// labels<para>Extent</para></remarks>
    /// <seealso href="http://purl.org/net/step#Extent">http://purl.org/net/step#Extent</seealso>
    let Extent = Prefixed_Name(step, "Extent") |> PrefixedName
    /// <summary>
    ///   <para>step:Fix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Fix is a spatial timestamped point.</para>
    /// labels<para>Fix</para></remarks>
    /// <seealso href="http://purl.org/net/step#Fix">http://purl.org/net/step#Fix</seealso>
    let Fix = Prefixed_Name(step, "Fix") |> PrefixedName
    /// <summary>
    ///   <para>step:SemanticDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Each episode may have one or many semantic descriptions, which can be of two types: Qualitative or Quantitative.</para>
    /// labels<para>Semantic Description</para></remarks>
    /// <seealso href="http://purl.org/net/step#SemanticDescription">http://purl.org/net/step#SemanticDescription</seealso>
    let SemanticDescription = Prefixed_Name(step, "SemanticDescription") |> PrefixedName
    /// <summary>
    ///   <para>step:hasEndingPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a Spatiotemporal extent to a KeyPoint that defines when and where the episode finishes.</para>
    /// labels<para>hasEndingPoint</para></remarks>
    /// <seealso href="http://purl.org/net/step#hasEndingPoint">http://purl.org/net/step#hasEndingPoint</seealso>
    let hasEndingPoint = Prefixed_Name(step, "hasEndingPoint") |> PrefixedName
    /// <summary>
    ///   <para>step:hasEpisode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a Feature of Interest to its corresponding Episodes.</para>
    /// labels<para>hasEpisode</para></remarks>
    /// <seealso href="http://purl.org/net/step#hasEpisode">http://purl.org/net/step#hasEpisode</seealso>
    let hasEpisode = Prefixed_Name(step, "hasEpisode") |> PrefixedName
    /// <summary>
    ///   <para>step:Episode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The episode is the smallest semantic unity for discretizing some aspect of a Feature of Interest.</para>
    /// labels<para>Episode</para></remarks>
    /// <seealso href="http://purl.org/net/step#Episode">http://purl.org/net/step#Episode</seealso>
    let Episode = Prefixed_Name(step, "Episode") |> PrefixedName
    /// <summary>
    ///   <para>step:RawTrajectory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represent the raw data from trajectories. As there's no official support for ensuring sequential ordering of tuples, we advise putting sequential numbers into the URLs of fixes to be able to retrieve the spatial footprint of the trajectory. Another solution is querying using an ORDER BY statement that sorts by the time:Interval of each Fix that composes the RawTrajectory.</para>
    /// labels<para>Raw Trajectory</para></remarks>
    /// <seealso href="http://purl.org/net/step#RawTrajectory">http://purl.org/net/step#RawTrajectory</seealso>
    let RawTrajectory = Prefixed_Name(step, "RawTrajectory") |> PrefixedName
    /// <summary>
    ///   <para>step:Trajectory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The agent's trajectory.</para>
    /// labels<para>Trajectory</para></remarks>
    /// <seealso href="http://purl.org/net/step#Trajectory">http://purl.org/net/step#Trajectory</seealso>
    let Trajectory = Prefixed_Name(step, "Trajectory") |> PrefixedName
    /// <summary>
    ///   <para>step:hasLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Links a Fix or a KeyPoint to a location.</para>
    /// labels<para>hasLocation</para></remarks>
    /// <seealso href="http://purl.org/net/step#hasLocation">http://purl.org/net/step#hasLocation</seealso>
    let hasLocation = Prefixed_Name(step, "hasLocation") |> PrefixedName
    /// <summary>
    ///   <para>step:hasTrajectory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>Links an Agent to a Trajectory.</para>
    /// labels<para>hasTrajectory</para></remarks>
    /// <seealso href="http://purl.org/net/step#hasTrajectory">http://purl.org/net/step#hasTrajectory</seealso>
    let hasTrajectory = Prefixed_Name(step, "hasTrajectory") |> PrefixedName
    /// <summary>
    ///   <para>step:atTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links the Fix or KeyPoint to a time instant.</para>
    /// labels<para>atTime</para></remarks>
    /// <seealso href="http://purl.org/net/step#atTime">http://purl.org/net/step#atTime</seealso>
    let atTime = Prefixed_Name(step, "atTime") |> PrefixedName
    /// <summary>
    ///   <para>step:hasExtent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an episode to an extent.</para>
    /// labels<para>hasExtent</para></remarks>
    /// <seealso href="http://purl.org/net/step#hasExtent">http://purl.org/net/step#hasExtent</seealso>
    let hasExtent = Prefixed_Name(step, "hasExtent") |> PrefixedName
    /// <summary>
    ///   <para>step:hasPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links any point of the trajectory to a spatiotemporal extent.</para>
    /// labels<para>hasPoint</para></remarks>
    /// <seealso href="http://purl.org/net/step#hasPoint">http://purl.org/net/step#hasPoint</seealso>
    let hasPoint = Prefixed_Name(step, "hasPoint") |> PrefixedName
    /// <summary>
    ///   <para>step:hasUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an Unit to a Quantitative Description.</para>
    /// labels<para>hasUnit</para></remarks>
    /// <seealso href="http://purl.org/net/step#hasUnit">http://purl.org/net/step#hasUnit</seealso>
    let hasUnit = Prefixed_Name(step, "hasUnit") |> PrefixedName
    /// <summary>
    ///   <para>step:relatesTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an Episode to a ContextualElement.</para>
    /// labels<para>relatesTo</para></remarks>
    /// <seealso href="http://purl.org/net/step#relatesTo">http://purl.org/net/step#relatesTo</seealso>
    let relatesTo = Prefixed_Name(step, "relatesTo") |> PrefixedName

    /// <summary>
    ///   <para>step:QualitativeDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Qualitative Description is used in situations when the Episode cannot be described by numeric values. This is also a point of extension of the ontology as other ontologies can be plugged here for extending it. For instance, one can define values such as "slow", "medium", or "fast" for speed episodes.</para>
    /// labels<para>Qualitative Description</para></remarks>
    /// <seealso href="http://purl.org/net/step#QualitativeDescription">http://purl.org/net/step#QualitativeDescription</seealso>
    let QualitativeDescription =
        Prefixed_Name(step, "QualitativeDescription") |> PrefixedName

    /// <summary>
    ///   <para>step:SpatialExtent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An extent determined only by spatial concepts (points, lines, polygons, etc). The usage of OGC Simple Features is a suggestion and can be exchanged by other ontologies.</para>
    /// labels<para>Spatial Extent</para></remarks>
    /// <seealso href="http://purl.org/net/step#SpatialExtent">http://purl.org/net/step#SpatialExtent</seealso>
    let SpatialExtent = Prefixed_Name(step, "SpatialExtent") |> PrefixedName
    /// <summary>
    ///   <para>step:hasFix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links each Fix to its Raw Trajectory.</para>
    /// labels<para>hasFix</para></remarks>
    /// <seealso href="http://purl.org/net/step#hasFix">http://purl.org/net/step#hasFix</seealso>
    let hasFix = Prefixed_Name(step, "hasFix") |> PrefixedName
    /// <summary>
    ///   <para>step:hasStartingPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a Spatiotemporal extent to a KeyPoint that defines when and where the episode starts.</para>
    /// labels<para>hasStartingPoint</para></remarks>
    /// <seealso href="http://purl.org/net/step#hasStartingPoint">http://purl.org/net/step#hasStartingPoint</seealso>
    let hasStartingPoint = Prefixed_Name(step, "hasStartingPoint") |> PrefixedName
    /// <summary>
    ///   <para>step:QuantitativeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The value associated to the Episode. For instance, integer, decimal values. It is also associated with an Unit.</para>
    /// labels<para>Quantitative Value</para></remarks>
    /// <seealso href="http://purl.org/net/step#QuantitativeValue">http://purl.org/net/step#QuantitativeValue</seealso>
    let QuantitativeValue = Prefixed_Name(step, "QuantitativeValue") |> PrefixedName

    /// <summary>
    ///   <para>step:SpatiotemporalExtent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Spatiotemporal extents are delimited by KeyPoints and the properties hasStartingPoint and hasEndingPoint. Event-like episodes may be delimited by the property hasPoint.</para>
    /// labels<para>Spatiotemporal Extent</para></remarks>
    /// <seealso href="http://purl.org/net/step#SpatiotemporalExtent">http://purl.org/net/step#SpatiotemporalExtent</seealso>
    let SpatiotemporalExtent =
        Prefixed_Name(step, "SpatiotemporalExtent") |> PrefixedName

    /// <summary>
    ///   <para>step:hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Links the value to a QuantitativeValue of an Episode.</para>
    /// labels<para>hasValue</para></remarks>
    /// <seealso href="http://purl.org/net/step#hasValue">http://purl.org/net/step#hasValue</seealso>
    let hasValue = Prefixed_Name(step, "hasValue") |> PrefixedName
    /// <summary>
    ///   <para>step:ContextualElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The contextual element can be anything related to the trajectory. It can be another agent, another trajectory, a geographic feature, etc.</para>
    /// labels<para>Contextual Element</para></remarks>
    /// <seealso href="http://purl.org/net/step#ContextualElement">http://purl.org/net/step#ContextualElement</seealso>
    let ContextualElement = Prefixed_Name(step, "ContextualElement") |> PrefixedName
    /// <summary>
    ///   <para>step:hasFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a Trajectory or Contextual Element to a Feature of Interest.</para>
    /// labels<para>hasFeature</para></remarks>
    /// <seealso href="http://purl.org/net/step#hasFeature">http://purl.org/net/step#hasFeature</seealso>
    let hasFeature = Prefixed_Name(step, "hasFeature") |> PrefixedName
    /// <summary>
    ///   <para>step:hasRawTrajectory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a trajectory to its own raw representation.</para>
    /// labels<para>hasRawTrajectory</para></remarks>
    /// <seealso href="http://purl.org/net/step#hasRawTrajectory">http://purl.org/net/step#hasRawTrajectory</seealso>
    let hasRawTrajectory = Prefixed_Name(step, "hasRawTrajectory") |> PrefixedName

    /// <summary>
    ///   <para>step:hasSemanticDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an episode to a description.</para>
    /// labels<para>hasSemanticDescription</para></remarks>
    /// <seealso href="http://purl.org/net/step#hasSemanticDescription">http://purl.org/net/step#hasSemanticDescription</seealso>
    let hasSemanticDescription =
        Prefixed_Name(step, "hasSemanticDescription") |> PrefixedName
