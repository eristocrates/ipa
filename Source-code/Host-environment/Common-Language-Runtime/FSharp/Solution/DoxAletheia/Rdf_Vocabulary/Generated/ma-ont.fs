namespace http.www.w3.org.ns.ma_ont.hash

open DoxAletheia

module ma_ont =
    let _namespace_name = "http://www.w3.org/ns/ma-ont#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A person or organisation contributing to the media resource.
    /// <see href="http://www.w3.org/ns/ma-ont#Agent"></see></summary>
    let Agent = _prefix "Agent"
    /// <summary>
    /// Information about The target audience (target region, target audience category but also parental guidance recommendation) for which a media resource is intended.
    /// <see href="http://www.w3.org/ns/ma-ont#TargetAudience"></see></summary>
    let TargetAudience = _prefix "TargetAudience"
    /// <summary>
    /// Information about the rating given to a media resource.
    /// <see href="http://www.w3.org/ns/ma-ont#Rating"></see></summary>
    let Rating = _prefix "Rating"
    /// <summary>
    /// An image or an audiovisual media resource, which can be composed of one or more fragment / track.
    /// <see href="http://www.w3.org/ns/ma-ont#MediaResource"></see></summary>
    let MediaResource = _prefix "MediaResource"
    /// <summary>
    /// A location related to the media resource, e.g. depicted in the resource (possibly fictional) or where the resource was created (shooting location), etc.
    /// <see href="http://www.w3.org/ns/ma-ont#Location"></see></summary>
    let Location = _prefix "Location"
    /// <summary>
    /// Any group of media resource e.g. a series.
    /// <see href="http://www.w3.org/ns/ma-ont#Collection"></see></summary>
    let Collection = _prefix "Collection"
    /// <summary>
    /// A specialisation of Track for Audio to provide a link to specific data properties such as sampleRate, etc. Specialisation is defined through object properties.
    /// <see href="http://www.w3.org/ns/ma-ont#AudioTrack"></see></summary>
    let AudioTrack = _prefix "AudioTrack"
    /// <summary>
    /// A specialisation of MediaFragment for audiovisual content.
    /// <see href="http://www.w3.org/ns/ma-ont#Track"></see></summary>
    let Track = _prefix "Track"
    /// <summary>
    /// A specialisation of Track for Video to provide a link to specific data properties such as frameRate, etc. Signing is another possible example of video track. Specialisation is defined through object properties.
    /// <see href="http://www.w3.org/ns/ma-ont#VideoTrack"></see></summary>
    let VideoTrack = _prefix "VideoTrack"
    /// <summary>
    /// Ancillary data track e.g. captioning  in addition to video and audio tracks. Specialisation is made through the use of appropriate object properties.
    /// <see href="http://www.w3.org/ns/ma-ont#DataTrack"></see></summary>
    let DataTrack = _prefix "DataTrack"
    /// <summary>
    /// A still image / thumbnail / key frame related to the media resource or being the media resource itself.
    /// <see href="http://www.w3.org/ns/ma-ont#Image"></see></summary>
    let Image = _prefix "Image"
    /// <summary>
    /// A media fragment (spatial, temporal, track...) composing a media resource. In other ontologies fragment is sometimes referred to as a 'part' or 'segment'.
    /// <see href="http://www.w3.org/ns/ma-ont#MediaFragment"></see></summary>
    let MediaFragment = _prefix "MediaFragment"
    /// <summary>
    /// An organisation or moral agent.
    /// <see href="http://www.w3.org/ns/ma-ont#Organisation"></see></summary>
    let Organisation = _prefix "Organisation"
    /// <summary>
    /// A physical person.
    /// <see href="http://www.w3.org/ns/ma-ont#Person"></see></summary>
    let Person = _prefix "Person"
    /// <summary>
    /// Corresponds to 'title.title' in the Ontology for Media Resources with a 'title.type' meaning "alternative".
    /// <see href="http://www.w3.org/ns/ma-ont#alternativeTitle"></see></summary>
    let alternativeTitle = _prefix "alternativeTitle"
    /// <summary>
    /// Corresponds to 'title.title' in the Ontology for Media Resources. Subproperties can be used to distinguish different values of 'title.type'.
    /// <see href="http://www.w3.org/ns/ma-ont#title"></see></summary>
    let title = _prefix "title"
    /// <summary>
    /// Corresponds to 'averageBitRate' in the Ontology for Media Resources, expressed in kilobits/second.
    /// <see href="http://www.w3.org/ns/ma-ont#averageBitRate"></see></summary>
    let averageBitRate = _prefix "averageBitRate"
    /// <summary>
    /// The name by which a collection (e.g. series) is known.
    /// <see href="http://www.w3.org/ns/ma-ont#collectionName"></see></summary>
    let collectionName = _prefix "collectionName"
    /// <summary>
    /// Corresponds to 'copyright.copyright' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#copyright"></see></summary>
    let copyright = _prefix "copyright"
    /// <summary>
    /// A subproperty of 'hasRelatedLocation" used to specify where material shooting took place.
    /// <see href="http://www.w3.org/ns/ma-ont#createdIn"></see></summary>
    let createdIn = _prefix "createdIn"
    /// <summary>
    /// Corresponds to 'location' in the Ontology for Media Resources. Subproperties are provided to specify, when possible, the relation between the media resource and the location.
    /// <see href="http://www.w3.org/ns/ma-ont#hasRelatedLocation"></see></summary>
    let hasRelatedLocation = _prefix "hasRelatedLocation"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#isCreationLocationOf"></see>
    /// </summary>
    let isCreationLocationOf = _prefix "isCreationLocationOf"
    /// <summary>
    /// Corresponds to 'date.date' in the Ontology for Media Resources with a 'date.type' meaning "creationDate".
    /// <see href="http://www.w3.org/ns/ma-ont#creationDate"></see></summary>
    let creationDate = _prefix "creationDate"
    /// <summary>
    /// Corresponds to date.date in the ontology for Media Resources. Subproperties can be used to distinguish different values of 'date.type'. The recommended range is 'xsd:dateTime' (for compliance with OWL2-QL and OWL2-RL) but other time-related datatypes may be used (e.g. 'xsd:gYear', 'xsd:date'...).
    /// <see href="http://www.w3.org/ns/ma-ont#date"></see></summary>
    let date = _prefix "date"
    /// <summary>
    /// A subproperty of 'hasRelatedLocation' used to specify where the action depicted in the media is supposed to take place, as opposed to the location where shooting actually took place (see 'createdIn').
    /// <see href="http://www.w3.org/ns/ma-ont#depictsFictionalLocation"></see></summary>
    let depictsFictionalLocation = _prefix "depictsFictionalLocation"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#isFictionalLocationDepictedIn"></see>
    /// </summary>
    let isFictionalLocationDepictedIn = _prefix "isFictionalLocationDepictedIn"
    /// <summary>
    /// Corresponds to 'description' in the Ontology for Media Resources. This can be specialised by using sub-properties e.g. 'summary' or 'script'.
    /// <see href="http://www.w3.org/ns/ma-ont#description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// Corresponds to 'duration' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#duration"></see></summary>
    let duration = _prefix "duration"
    /// <summary>
    /// Corresponds to 'date.date' in the Ontology for Media Resources with a 'date.type' meaning "editDate".
    /// <see href="http://www.w3.org/ns/ma-ont#editDate"></see></summary>
    let editDate = _prefix "editDate"
    /// <summary>
    /// Corresponds to 'contributor.contributor' in the Ontology for Media Resources with a 'contributor.role' meaning "actor".
    /// <see href="http://www.w3.org/ns/ma-ont#features"></see></summary>
    let features = _prefix "features"
    /// <summary>
    /// Corresponds to 'contributor.contributor' in the Ontology for Media Resources. Subproperties can be used to distinguish different values of 'contributor.role'.
    /// <see href="http://www.w3.org/ns/ma-ont#hasContributor"></see></summary>
    let hasContributor = _prefix "hasContributor"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#playsIn"></see>
    /// </summary>
    let playsIn = _prefix "playsIn"
    /// <summary>
    /// Corresponds to 'namedFragment.label' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#fragmentName"></see></summary>
    let fragmentName = _prefix "fragmentName"
    /// <summary>
    /// Corresponds to 'frameSize.height' in the Ontology for Media Resources, measured in frameSizeUnit.
    /// <see href="http://www.w3.org/ns/ma-ont#frameHeight"></see></summary>
    let frameHeight = _prefix "frameHeight"
    /// <summary>
    /// Corresponds to 'frameRate' in the Ontology for Media Resources, in frame per second.
    /// <see href="http://www.w3.org/ns/ma-ont#frameRate"></see></summary>
    let frameRate = _prefix "frameRate"
    /// <summary>
    /// Corresponds to 'frameSize.unit' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#frameSizeUnit"></see></summary>
    let frameSizeUnit = _prefix "frameSizeUnit"
    /// <summary>
    /// Corresponds to 'frameSize.width' in the Ontology for Media Resources measured in frameSizeUnit.
    /// <see href="http://www.w3.org/ns/ma-ont#frameWidth"></see></summary>
    let frameWidth = _prefix "frameWidth"
    /// <summary>
    /// Corresponds to 'policy' in the Ontology for Media Resources with a 'policy.type' "access conditions".
    /// <see href="http://www.w3.org/ns/ma-ont#hasAccessConditions"></see></summary>
    let hasAccessConditions = _prefix "hasAccessConditions"
    /// <summary>
    /// Corresponds to 'policy' in the Ontology for Media Resources. Subproperties can be used to distinguish different values of 'policy.type'.
    /// <see href="http://www.w3.org/ns/ma-ont#hasPolicy"></see></summary>
    let hasPolicy = _prefix "hasPolicy"
    /// <summary>
    /// Corresponds to 'fragment' in the Ontology for Media Resources with a 'fragment.role' meaning "audio-description".
    /// <see href="http://www.w3.org/ns/ma-ont#hasAudioDescription"></see></summary>
    let hasAudioDescription = _prefix "hasAudioDescription"
    /// <summary>
    /// Corresponds to 'fragment' in the Ontology for Media Resources with a 'fragment.role' meaning "captioning". This property can for example point to a spatial fragment, a VideoTrack or a DataTrack. The language of the captioning track can be expressed by attaching a 'hasLanguage' property to the specific track.
    /// <see href="http://www.w3.org/ns/ma-ont#hasCaptioning"></see></summary>
    let hasCaptioning = _prefix "hasCaptioning"
    /// <summary>
    /// Corresponds to 'fragment' in the Ontology for Media Resources. Subproperties can be used to distinguish different values of 'fragment.role'.
    /// <see href="http://www.w3.org/ns/ma-ont#hasFragment"></see></summary>
    let hasFragment = _prefix "hasFragment"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#isCaptioningOf"></see>
    /// </summary>
    let isCaptioningOf = _prefix "isCaptioningOf"
    /// <summary>
    /// Corresponds to 'fragment' in the Ontology for Media Resources with a 'fragment.role' meaning "chapter".
    /// <see href="http://www.w3.org/ns/ma-ont#hasChapter"></see></summary>
    let hasChapter = _prefix "hasChapter"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#isChapterOf"></see>
    /// </summary>
    let isChapterOf = _prefix "isChapterOf"
    /// <summary>
    /// Corresponds to 'targetAudience.classification' in the Ontology for Media Resources. This property is used to provide a value characterising the target audience.
    /// <see href="http://www.w3.org/ns/ma-ont#hasClassification"></see></summary>
    let hasClassification = _prefix "hasClassification"
    /// <summary>
    /// Corresponds to 'targetAudience.identifier' in the Ontology for Media Resources. This is used to identify the reference sheme against which the target audience has been characterised.
    /// <see href="http://www.w3.org/ns/ma-ont#hasClassificationSystem"></see></summary>
    let hasClassificationSystem = _prefix "hasClassificationSystem"
    /// <summary>
    /// Corresponds to 'compression' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#hasCompression"></see></summary>
    let hasCompression = _prefix "hasCompression"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#hasContributedTo"></see>
    /// </summary>
    let hasContributedTo = _prefix "hasContributedTo"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#hasCopyrightOver"></see>
    /// </summary>
    let hasCopyrightOver = _prefix "hasCopyrightOver"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#hasCreated"></see>
    /// </summary>
    let hasCreated = _prefix "hasCreated"
    /// <summary>
    /// Corresponds to 'creator.creator' in the Ontology for Media Resources. Subproperties can be used to distinguish different values of 'creator.role'. Note that this property is semantically a subproperty of 'hasContributor'.
    /// <see href="http://www.w3.org/ns/ma-ont#hasCreator"></see></summary>
    let hasCreator = _prefix "hasCreator"
    /// <summary>
    /// Corresponds to 'format' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#hasFormat"></see></summary>
    let hasFormat = _prefix "hasFormat"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#isFragmentOf"></see>
    /// </summary>
    let isFragmentOf = _prefix "isFragmentOf"
    /// <summary>
    /// Corresponds to 'genre' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#hasGenre"></see></summary>
    let hasGenre = _prefix "hasGenre"
    /// <summary>
    /// Corresponds to 'keyword' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#hasKeyword"></see></summary>
    let hasKeyword = _prefix "hasKeyword"
    /// <summary>
    /// Corresponds to 'language' in the Ontology for Media Resources. The language used in the resource. A controlled vocabulary such as defined in BCP 47 SHOULD be used. This property can also be used to identify the presence of sign language (RFC 5646). By inheritance, the hasLanguage property applies indifferently at the media resource / fragment / track levels.  Best practice recommends to use to best possible level of granularity fo describe the usage of language within a media resource including at fragment and track levels.
    /// <see href="http://www.w3.org/ns/ma-ont#hasLanguage"></see></summary>
    let hasLanguage = _prefix "hasLanguage"
    /// <summary>
    /// Corresponds to 'location.coordinateSystem' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#hasLocationCoordinateSystem"></see></summary>
    let hasLocationCoordinateSystem = _prefix "hasLocationCoordinateSystem"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#hasMember"></see>
    /// </summary>
    let hasMember = _prefix "hasMember"
    /// <summary>
    /// Corresponds to 'namedFragment' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#hasNamedFragment"></see></summary>
    let hasNamedFragment = _prefix "hasNamedFragment"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#isNamedFragmentOf"></see>
    /// </summary>
    let isNamedFragmentOf = _prefix "isNamedFragmentOf"
    /// <summary>
    /// Corresponds to 'policy' in the Ontology for Media Resources with a  'policy.type' meaning "permissions".
    /// <see href="http://www.w3.org/ns/ma-ont#hasPermissions"></see></summary>
    let hasPermissions = _prefix "hasPermissions"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#hasPublished"></see>
    /// </summary>
    let hasPublished = _prefix "hasPublished"
    /// <summary>
    /// Corresponds to 'publisher' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#hasPublisher"></see></summary>
    let hasPublisher = _prefix "hasPublisher"
    /// <summary>
    /// Corresponds to 'rating' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#hasRating"></see></summary>
    let hasRating = _prefix "hasRating"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#isRatingOf"></see>
    /// </summary>
    let isRatingOf = _prefix "isRatingOf"
    /// <summary>
    /// Corresponds to 'rating.type' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#hasRatingSystem"></see></summary>
    let hasRatingSystem = _prefix "hasRatingSystem"
    /// <summary>
    /// Corresponds to 'relation' and in the Ontology for Media Resources with a 'relation.type' meaning "related image".
    /// <see href="http://www.w3.org/ns/ma-ont#hasRelatedImage"></see></summary>
    let hasRelatedImage = _prefix "hasRelatedImage"
    /// <summary>
    /// Corresponds to 'relation' and in the Ontology for Media Resources. Subproperties can be used to distinguish different values of 'relation.type'.
    /// <see href="http://www.w3.org/ns/ma-ont#hasRelatedResource"></see></summary>
    let hasRelatedResource = _prefix "hasRelatedResource"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#isImageRelatedTo"></see>
    /// </summary>
    let isImageRelatedTo = _prefix "isImageRelatedTo"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#isLocationRelatedTo"></see>
    /// </summary>
    let isLocationRelatedTo = _prefix "isLocationRelatedTo"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#isRelatedTo"></see>
    /// </summary>
    let isRelatedTo = _prefix "isRelatedTo"
    /// <summary>
    /// Corresponds to 'fragment' in the Ontology for Media Resources with a 'fragment.role' meaning "signing". This property can for example point to a spatial fragment or a VideoTrack. The sign language of the captioning track can be expressed by attaching a 'hasLanguage' property to the specific track.
    /// <see href="http://www.w3.org/ns/ma-ont#hasSigning"></see></summary>
    let hasSigning = _prefix "hasSigning"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#isSigningOf"></see>
    /// </summary>
    let isSigningOf = _prefix "isSigningOf"
    /// <summary>
    /// Corresponds to 'relation' and in the Ontology for Media Resources with a 'relation.type' meaning "source".
    /// <see href="http://www.w3.org/ns/ma-ont#hasSource"></see></summary>
    let hasSource = _prefix "hasSource"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#isSourceOf"></see>
    /// </summary>
    let isSourceOf = _prefix "isSourceOf"
    /// <summary>
    /// Corresponds to 'fragment' in the Ontology for Media Resources with a 'fragment.role' meaning "subtitling".
    /// <see href="http://www.w3.org/ns/ma-ont#hasSubtitling"></see></summary>
    let hasSubtitling = _prefix "hasSubtitling"
    /// <summary>
    /// Corresponds to 'targetAudience' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#hasTargetAudience"></see></summary>
    let hasTargetAudience = _prefix "hasTargetAudience"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#isTargetAudienceOf"></see>
    /// </summary>
    let isTargetAudienceOf = _prefix "isTargetAudienceOf"
    /// <summary>
    /// Corresponds to 'fragment' in the Ontology for Media Resources with a 'fragment.role' meaning "track".
    /// <see href="http://www.w3.org/ns/ma-ont#hasTrack"></see></summary>
    let hasTrack = _prefix "hasTrack"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#isTrackOf"></see>
    /// </summary>
    let isTrackOf = _prefix "isTrackOf"
    /// <summary>
    /// Corresponds to 'copyright.identifier' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#isCopyrightedBy"></see></summary>
    let isCopyrightedBy = _prefix "isCopyrightedBy"
    /// <summary>
    /// Corresponds to 'collection' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#isMemberOf"></see></summary>
    let isMemberOf = _prefix "isMemberOf"
    /// <summary>
    /// Corresponds to 'rating.identifier' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#isProvidedBy"></see></summary>
    let isProvidedBy = _prefix "isProvidedBy"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#provides"></see>
    /// </summary>
    let provides = _prefix "provides"
    /// <summary>
    /// Corresponds to 'location.altitude' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#locationAltitude"></see></summary>
    let locationAltitude = _prefix "locationAltitude"
    /// <summary>
    /// Corresponds to 'location.latitude' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#locationLatitude"></see></summary>
    let locationLatitude = _prefix "locationLatitude"
    /// <summary>
    /// Corresponds to 'location.longitude' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#locationLongitude"></see></summary>
    let locationLongitude = _prefix "locationLongitude"
    /// <summary>
    /// Corresponds to 'location.name' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#locationName"></see></summary>
    let locationName = _prefix "locationName"
    /// <summary>
    /// Corresponds to 'locator' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#locator"></see></summary>
    let locator = _prefix "locator"
    /// <summary>
    /// Corresponds to 'title.title' in the Ontology for Media Resources with a 'title.type' meaning "original".
    /// <see href="http://www.w3.org/ns/ma-ont#mainOriginalTitle"></see></summary>
    let mainOriginalTitle = _prefix "mainOriginalTitle"
    /// <summary>
    /// Corresponds to 'numTracks.number' in the Ontology for Media Resources. Subproperties can be used to distinguish different values of 'numTracks.type'.
    /// <see href="http://www.w3.org/ns/ma-ont#numberOfTracks"></see></summary>
    let numberOfTracks = _prefix "numberOfTracks"
    /// <summary>
    /// Corresponds to 'rating.max' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#ratingScaleMax"></see></summary>
    let ratingScaleMax = _prefix "ratingScaleMax"
    /// <summary>
    /// Corresponds to 'rating.min' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#ratingScaleMin"></see></summary>
    let ratingScaleMin = _prefix "ratingScaleMin"
    /// <summary>
    /// Corresponds to 'rating.value' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#ratingValue"></see></summary>
    let ratingValue = _prefix "ratingValue"
    /// <summary>
    /// Corresponds to 'date.date' in the Ontology for Media Resources with a 'date.type' meaning "recordDate".
    /// <see href="http://www.w3.org/ns/ma-ont#recordDate"></see></summary>
    let recordDate = _prefix "recordDate"
    /// <summary>
    /// Corresponds to 'date.date' in the Ontology for Media Resources with a 'date.type' meaning "releaseDate".
    /// <see href="http://www.w3.org/ns/ma-ont#releaseDate"></see></summary>
    let releaseDate = _prefix "releaseDate"
    /// <summary>
    /// Corresponds to 'samplingRate' in the Ontology for Media Resources, in samples per second.
    /// <see href="http://www.w3.org/ns/ma-ont#samplingRate"></see></summary>
    let samplingRate = _prefix "samplingRate"
    /// <summary>
    /// Corresponds to 'fragment.name' in the Ontology for Media Resources, for Track fragments.
    /// <see href="http://www.w3.org/ns/ma-ont#trackName"></see></summary>
    let trackName = _prefix "trackName"
