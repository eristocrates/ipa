#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module step =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/net/step#" "step"
    /// <summary>
    ///   <para>rdfs:comment : The agent is the moving object. It can be a person, an animal, a car, etc.</para>
    ///   <para>rdfs:label : Agent</para>
    ///   <a href="http://purl.org/net/step#Agent">step:Agent</a>
    /// </summary>
    let Agent = _prefixId.prefix "Agent"
    /// <summary>
    ///   <para>rdfs:comment : The contextual element can be anything related to the trajectory. It can be another agent, another trajectory, a geographic feature, etc.</para>
    ///   <para>rdfs:label : Contextual Element</para>
    ///   <a href="http://purl.org/net/step#ContextualElement">step:ContextualElement</a>
    /// </summary>
    let ContextualElement = _prefixId.prefix "ContextualElement"
    /// <summary>
    ///   <para>rdfs:comment : The episode is the smallest semantic unity for discretizing some aspect of a Feature of Interest.</para>
    ///   <para>rdfs:label : Episode</para>
    ///   <a href="http://purl.org/net/step#Episode">step:Episode</a>
    /// </summary>
    let Episode = _prefixId.prefix "Episode"
    /// <summary>
    ///   <para>rdfs:comment : Extent is a superclass for all kinds of extents an Episode may have.</para>
    ///   <para>rdfs:label : Extent</para>
    ///   <a href="http://purl.org/net/step#Extent">step:Extent</a>
    /// </summary>
    let Extent = _prefixId.prefix "Extent"
    /// <summary>
    ///   <para>rdfs:comment : The aspect of the trajectory or context that is being described. Example: speed, direction, etc.</para>
    ///   <para>rdfs:label : Feature of Interest</para>
    ///   <a href="http://purl.org/net/step#FeatureOfInterest">step:FeatureOfInterest</a>
    /// </summary>
    let FeatureOfInterest = _prefixId.prefix "FeatureOfInterest"
    /// <summary>
    ///   <para>rdfs:comment : A Fix is a spatial timestamped point.</para>
    ///   <para>rdfs:label : Fix</para>
    ///   <a href="http://purl.org/net/step#Fix">step:Fix</a>
    /// </summary>
    let Fix = _prefixId.prefix "Fix"
    /// <summary>
    ///   <para>rdfs:comment : Key Points delimits the extent of SpatiotemporalExtents and can also be used to represent important points of a trajectory.</para>
    ///   <para>rdfs:label : Key Point</para>
    ///   <a href="http://purl.org/net/step#KeyPoint">step:KeyPoint</a>
    /// </summary>
    let KeyPoint = _prefixId.prefix "KeyPoint"
    /// <summary>
    ///   <para>rdfs:comment : A Qualitative Description is used in situations when the Episode cannot be described by numeric values. This is also a point of extension of the ontology as other ontologies can be plugged here for extending it. For instance, one can define values such as "slow", "medium", or "fast" for speed episodes.</para>
    ///   <para>rdfs:label : Qualitative Description</para>
    ///   <a href="http://purl.org/net/step#QualitativeDescription">step:QualitativeDescription</a>
    /// </summary>
    let QualitativeDescription = _prefixId.prefix "QualitativeDescription"
    /// <summary>
    ///   <para>rdfs:comment : The value associated to the Episode. For instance, integer, decimal values. It is also associated with an Unit.</para>
    ///   <para>rdfs:label : Quantitative Value</para>
    ///   <a href="http://purl.org/net/step#QuantitativeValue">step:QuantitativeValue</a>
    /// </summary>
    let QuantitativeValue = _prefixId.prefix "QuantitativeValue"
    /// <summary>
    ///   <para>rdfs:comment : Represent the raw data from trajectories. As there's no official support for ensuring sequential ordering of tuples, we advise putting sequential numbers into the URLs of fixes to be able to retrieve the spatial footprint of the trajectory. Another solution is querying using an ORDER BY statement that sorts by the time:Interval of each Fix that composes the RawTrajectory.</para>
    ///   <para>rdfs:label : Raw Trajectory</para>
    ///   <a href="http://purl.org/net/step#RawTrajectory">step:RawTrajectory</a>
    /// </summary>
    let RawTrajectory = _prefixId.prefix "RawTrajectory"
    /// <summary>
    ///   <para>rdfs:comment : Each episode may have one or many semantic descriptions, which can be of two types: Qualitative or Quantitative.</para>
    ///   <para>rdfs:label : Semantic Description</para>
    ///   <a href="http://purl.org/net/step#SemanticDescription">step:SemanticDescription</a>
    /// </summary>
    let SemanticDescription = _prefixId.prefix "SemanticDescription"
    /// <summary>
    ///   <para>rdfs:comment : An extent determined only by spatial concepts (points, lines, polygons, etc). The usage of OGC Simple Features is a suggestion and can be exchanged by other ontologies.</para>
    ///   <para>rdfs:label : Spatial Extent</para>
    ///   <a href="http://purl.org/net/step#SpatialExtent">step:SpatialExtent</a>
    /// </summary>
    let SpatialExtent = _prefixId.prefix "SpatialExtent"
    /// <summary>
    ///   <para>rdfs:comment : Spatiotemporal extents are delimited by KeyPoints and the properties hasStartingPoint and hasEndingPoint. Event-like episodes may be delimited by the property hasPoint.</para>
    ///   <para>rdfs:label : Spatiotemporal Extent</para>
    ///   <a href="http://purl.org/net/step#SpatiotemporalExtent">step:SpatiotemporalExtent</a>
    /// </summary>
    let SpatiotemporalExtent = _prefixId.prefix "SpatiotemporalExtent"
    /// <summary>
    ///   <para>rdfs:comment : An extent determined only by temporal concepts (interval, instant, etc). The usage of OWL Time is a suggestion and can be exchanged by other ontologies.</para>
    ///   <para>rdfs:label : Temporal Extent</para>
    ///   <a href="http://purl.org/net/step#TemporalExtent">step:TemporalExtent</a>
    /// </summary>
    let TemporalExtent = _prefixId.prefix "TemporalExtent"
    /// <summary>
    ///   <para>rdfs:comment : The agent's trajectory.</para>
    ///   <para>rdfs:label : Trajectory</para>
    ///   <a href="http://purl.org/net/step#Trajectory">step:Trajectory</a>
    /// </summary>
    let Trajectory = _prefixId.prefix "Trajectory"
    /// <summary>
    ///   <para>rdfs:comment : Links the Fix or KeyPoint to a time instant.</para>
    ///   <para>rdfs:label : atTime</para>
    ///   <a href="http://purl.org/net/step#atTime">step:atTime</a>
    /// </summary>
    let atTime = _prefixId.prefix "atTime"
    /// <summary>
    ///   <para>rdfs:comment : Links a Spatiotemporal extent to a KeyPoint that defines when and where the episode finishes.</para>
    ///   <para>rdfs:label : hasEndingPoint</para>
    ///   <a href="http://purl.org/net/step#hasEndingPoint">step:hasEndingPoint</a>
    /// </summary>
    let hasEndingPoint = _prefixId.prefix "hasEndingPoint"
    /// <summary>
    ///   <para>rdfs:comment : Links a Feature of Interest to its corresponding Episodes.</para>
    ///   <para>rdfs:label : hasEpisode</para>
    ///   <a href="http://purl.org/net/step#hasEpisode">step:hasEpisode</a>
    /// </summary>
    let hasEpisode = _prefixId.prefix "hasEpisode"
    /// <summary>
    ///   <para>rdfs:comment : Links an episode to an extent.</para>
    ///   <para>rdfs:label : hasExtent</para>
    ///   <a href="http://purl.org/net/step#hasExtent">step:hasExtent</a>
    /// </summary>
    let hasExtent = _prefixId.prefix "hasExtent"
    /// <summary>
    ///   <para>rdfs:comment : Links a Trajectory or Contextual Element to a Feature of Interest.</para>
    ///   <para>rdfs:label : hasFeature</para>
    ///   <a href="http://purl.org/net/step#hasFeature">step:hasFeature</a>
    /// </summary>
    let hasFeature = _prefixId.prefix "hasFeature"
    /// <summary>
    ///   <para>rdfs:comment : Links each Fix to its Raw Trajectory.</para>
    ///   <para>rdfs:label : hasFix</para>
    ///   <a href="http://purl.org/net/step#hasFix">step:hasFix</a>
    /// </summary>
    let hasFix = _prefixId.prefix "hasFix"
    /// <summary>
    ///   <para>rdfs:comment : Links a Fix or a KeyPoint to a location.</para>
    ///   <para>rdfs:label : hasLocation</para>
    ///   <a href="http://purl.org/net/step#hasLocation">step:hasLocation</a>
    /// </summary>
    let hasLocation = _prefixId.prefix "hasLocation"
    /// <summary>
    ///   <para>rdfs:comment : Links any point of the trajectory to a spatiotemporal extent.</para>
    ///   <para>rdfs:label : hasPoint</para>
    ///   <a href="http://purl.org/net/step#hasPoint">step:hasPoint</a>
    /// </summary>
    let hasPoint = _prefixId.prefix "hasPoint"
    /// <summary>
    ///   <para>rdfs:comment : Links a trajectory to its own raw representation.</para>
    ///   <para>rdfs:label : hasRawTrajectory</para>
    ///   <a href="http://purl.org/net/step#hasRawTrajectory">step:hasRawTrajectory</a>
    /// </summary>
    let hasRawTrajectory = _prefixId.prefix "hasRawTrajectory"
    /// <summary>
    ///   <para>rdfs:comment : Links an episode to a description.</para>
    ///   <para>rdfs:label : hasSemanticDescription</para>
    ///   <a href="http://purl.org/net/step#hasSemanticDescription">step:hasSemanticDescription</a>
    /// </summary>
    let hasSemanticDescription = _prefixId.prefix "hasSemanticDescription"
    /// <summary>
    ///   <para>rdfs:comment : Links a Spatiotemporal extent to a KeyPoint that defines when and where the episode starts.</para>
    ///   <para>rdfs:label : hasStartingPoint</para>
    ///   <a href="http://purl.org/net/step#hasStartingPoint">step:hasStartingPoint</a>
    /// </summary>
    let hasStartingPoint = _prefixId.prefix "hasStartingPoint"
    /// <summary>
    ///   <para>rdfs:comment : Links an Agent to a Trajectory.</para>
    ///   <para>rdfs:label : hasTrajectory</para>
    ///   <a href="http://purl.org/net/step#hasTrajectory">step:hasTrajectory</a>
    /// </summary>
    let hasTrajectory = _prefixId.prefix "hasTrajectory"
    /// <summary>
    ///   <para>rdfs:comment : Links an Unit to a Quantitative Description.</para>
    ///   <para>rdfs:label : hasUnit</para>
    ///   <a href="http://purl.org/net/step#hasUnit">step:hasUnit</a>
    /// </summary>
    let hasUnit = _prefixId.prefix "hasUnit"
    /// <summary>
    ///   <para>rdfs:comment : Links the value to a QuantitativeValue of an Episode.</para>
    ///   <para>rdfs:label : hasValue^^xsd:string</para>
    ///   <a href="http://purl.org/net/step#hasValue">step:hasValue</a>
    /// </summary>
    let hasValue = _prefixId.prefix "hasValue"
    /// <summary>
    ///   <para>rdfs:comment : Links an Episode to a ContextualElement.</para>
    ///   <para>rdfs:label : relatesTo</para>
    ///   <a href="http://purl.org/net/step#relatesTo">step:relatesTo</a>
    /// </summary>
    let relatesTo = _prefixId.prefix "relatesTo"
