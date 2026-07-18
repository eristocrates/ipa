namespace http.www.w3.org.ns.ma_ont.hash

open DoxAletheia.Rdf_Vocabulary

module ma_ont =
    let _namespace_name = "http://www.w3.org/ns/ma-ont#"
    /// <summary>
    /// A person or organisation contributing to the media resource.
    /// <see href="http://www.w3.org/ns/ma-ont#Agent"></see></summary>
    let Agent = Namespaced_IRI.parse _namespace_name "Agent" |> NamespacedName

    /// <summary>
    /// Information about The target audience (target region, target audience category but also parental guidance recommendation) for which a media resource is intended.
    /// <see href="http://www.w3.org/ns/ma-ont#TargetAudience"></see></summary>
    let TargetAudience =
        Namespaced_IRI.parse _namespace_name "TargetAudience" |> NamespacedName

    /// <summary>
    /// Information about the rating given to a media resource.
    /// <see href="http://www.w3.org/ns/ma-ont#Rating"></see></summary>
    let Rating = Namespaced_IRI.parse _namespace_name "Rating" |> NamespacedName

    /// <summary>
    /// An image or an audiovisual media resource, which can be composed of one or more fragment / track.
    /// <see href="http://www.w3.org/ns/ma-ont#MediaResource"></see></summary>
    let MediaResource =
        Namespaced_IRI.parse _namespace_name "MediaResource" |> NamespacedName

    /// <summary>
    /// A location related to the media resource, e.g. depicted in the resource (possibly fictional) or where the resource was created (shooting location), etc.
    /// <see href="http://www.w3.org/ns/ma-ont#Location"></see></summary>
    let Location = Namespaced_IRI.parse _namespace_name "Location" |> NamespacedName
    /// <summary>
    /// Any group of media resource e.g. a series.
    /// <see href="http://www.w3.org/ns/ma-ont#Collection"></see></summary>
    let Collection = Namespaced_IRI.parse _namespace_name "Collection" |> NamespacedName
    /// <summary>
    /// A specialisation of Track for Audio to provide a link to specific data properties such as sampleRate, etc. Specialisation is defined through object properties.
    /// <see href="http://www.w3.org/ns/ma-ont#AudioTrack"></see></summary>
    let AudioTrack = Namespaced_IRI.parse _namespace_name "AudioTrack" |> NamespacedName
    /// <summary>
    /// A specialisation of MediaFragment for audiovisual content.
    /// <see href="http://www.w3.org/ns/ma-ont#Track"></see></summary>
    let Track = Namespaced_IRI.parse _namespace_name "Track" |> NamespacedName
    /// <summary>
    /// A specialisation of Track for Video to provide a link to specific data properties such as frameRate, etc. Signing is another possible example of video track. Specialisation is defined through object properties.
    /// <see href="http://www.w3.org/ns/ma-ont#VideoTrack"></see></summary>
    let VideoTrack = Namespaced_IRI.parse _namespace_name "VideoTrack" |> NamespacedName
    /// <summary>
    /// Ancillary data track e.g. captioning  in addition to video and audio tracks. Specialisation is made through the use of appropriate object properties.
    /// <see href="http://www.w3.org/ns/ma-ont#DataTrack"></see></summary>
    let DataTrack = Namespaced_IRI.parse _namespace_name "DataTrack" |> NamespacedName
    /// <summary>
    /// A still image / thumbnail / key frame related to the media resource or being the media resource itself.
    /// <see href="http://www.w3.org/ns/ma-ont#Image"></see></summary>
    let Image = Namespaced_IRI.parse _namespace_name "Image" |> NamespacedName

    /// <summary>
    /// A media fragment (spatial, temporal, track...) composing a media resource. In other ontologies fragment is sometimes referred to as a 'part' or 'segment'.
    /// <see href="http://www.w3.org/ns/ma-ont#MediaFragment"></see></summary>
    let MediaFragment =
        Namespaced_IRI.parse _namespace_name "MediaFragment" |> NamespacedName

    /// <summary>
    /// An organisation or moral agent.
    /// <see href="http://www.w3.org/ns/ma-ont#Organisation"></see></summary>
    let Organisation =
        Namespaced_IRI.parse _namespace_name "Organisation" |> NamespacedName

    /// <summary>
    /// A physical person.
    /// <see href="http://www.w3.org/ns/ma-ont#Person"></see></summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName

    /// <summary>
    /// Corresponds to 'title.title' in the Ontology for Media Resources with a 'title.type' meaning "alternative".
    /// <see href="http://www.w3.org/ns/ma-ont#alternativeTitle"></see></summary>
    let alternativeTitle =
        Namespaced_IRI.parse _namespace_name "alternativeTitle" |> NamespacedName

    /// <summary>
    /// Corresponds to 'title.title' in the Ontology for Media Resources. Subproperties can be used to distinguish different values of 'title.type'.
    /// <see href="http://www.w3.org/ns/ma-ont#title"></see></summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName

    /// <summary>
    /// Corresponds to 'averageBitRate' in the Ontology for Media Resources, expressed in kilobits/second.
    /// <see href="http://www.w3.org/ns/ma-ont#averageBitRate"></see></summary>
    let averageBitRate =
        Namespaced_IRI.parse _namespace_name "averageBitRate" |> NamespacedName

    /// <summary>
    /// The name by which a collection (e.g. series) is known.
    /// <see href="http://www.w3.org/ns/ma-ont#collectionName"></see></summary>
    let collectionName =
        Namespaced_IRI.parse _namespace_name "collectionName" |> NamespacedName

    /// <summary>
    /// Corresponds to 'copyright.copyright' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#copyright"></see></summary>
    let copyright = Namespaced_IRI.parse _namespace_name "copyright" |> NamespacedName
    /// <summary>
    /// A subproperty of 'hasRelatedLocation" used to specify where material shooting took place.
    /// <see href="http://www.w3.org/ns/ma-ont#createdIn"></see></summary>
    let createdIn = Namespaced_IRI.parse _namespace_name "createdIn" |> NamespacedName

    /// <summary>
    /// Corresponds to 'location' in the Ontology for Media Resources. Subproperties are provided to specify, when possible, the relation between the media resource and the location.
    /// <see href="http://www.w3.org/ns/ma-ont#hasRelatedLocation"></see></summary>
    let hasRelatedLocation =
        Namespaced_IRI.parse _namespace_name "hasRelatedLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#isCreationLocationOf"></see>
    /// </summary>
    let isCreationLocationOf =
        Namespaced_IRI.parse _namespace_name "isCreationLocationOf" |> NamespacedName

    /// <summary>
    /// Corresponds to 'date.date' in the Ontology for Media Resources with a 'date.type' meaning "creationDate".
    /// <see href="http://www.w3.org/ns/ma-ont#creationDate"></see></summary>
    let creationDate =
        Namespaced_IRI.parse _namespace_name "creationDate" |> NamespacedName

    /// <summary>
    /// Corresponds to date.date in the ontology for Media Resources. Subproperties can be used to distinguish different values of 'date.type'. The recommended range is 'xsd:dateTime' (for compliance with OWL2-QL and OWL2-RL) but other time-related datatypes may be used (e.g. 'xsd:gYear', 'xsd:date'...).
    /// <see href="http://www.w3.org/ns/ma-ont#date"></see></summary>
    let date = Namespaced_IRI.parse _namespace_name "date" |> NamespacedName

    /// <summary>
    /// A subproperty of 'hasRelatedLocation' used to specify where the action depicted in the media is supposed to take place, as opposed to the location where shooting actually took place (see 'createdIn').
    /// <see href="http://www.w3.org/ns/ma-ont#depictsFictionalLocation"></see></summary>
    let depictsFictionalLocation =
        Namespaced_IRI.parse _namespace_name "depictsFictionalLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#isFictionalLocationDepictedIn"></see>
    /// </summary>
    let isFictionalLocationDepictedIn =
        Namespaced_IRI.parse _namespace_name "isFictionalLocationDepictedIn" |> NamespacedName

    /// <summary>
    /// Corresponds to 'description' in the Ontology for Media Resources. This can be specialised by using sub-properties e.g. 'summary' or 'script'.
    /// <see href="http://www.w3.org/ns/ma-ont#description"></see></summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    /// Corresponds to 'duration' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#duration"></see></summary>
    let duration = Namespaced_IRI.parse _namespace_name "duration" |> NamespacedName
    /// <summary>
    /// Corresponds to 'date.date' in the Ontology for Media Resources with a 'date.type' meaning "editDate".
    /// <see href="http://www.w3.org/ns/ma-ont#editDate"></see></summary>
    let editDate = Namespaced_IRI.parse _namespace_name "editDate" |> NamespacedName
    /// <summary>
    /// Corresponds to 'contributor.contributor' in the Ontology for Media Resources with a 'contributor.role' meaning "actor".
    /// <see href="http://www.w3.org/ns/ma-ont#features"></see></summary>
    let features = Namespaced_IRI.parse _namespace_name "features" |> NamespacedName

    /// <summary>
    /// Corresponds to 'contributor.contributor' in the Ontology for Media Resources. Subproperties can be used to distinguish different values of 'contributor.role'.
    /// <see href="http://www.w3.org/ns/ma-ont#hasContributor"></see></summary>
    let hasContributor =
        Namespaced_IRI.parse _namespace_name "hasContributor" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#playsIn"></see>
    /// </summary>
    let playsIn = Namespaced_IRI.parse _namespace_name "playsIn" |> NamespacedName

    /// <summary>
    /// Corresponds to 'namedFragment.label' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#fragmentName"></see></summary>
    let fragmentName =
        Namespaced_IRI.parse _namespace_name "fragmentName" |> NamespacedName

    /// <summary>
    /// Corresponds to 'frameSize.height' in the Ontology for Media Resources, measured in frameSizeUnit.
    /// <see href="http://www.w3.org/ns/ma-ont#frameHeight"></see></summary>
    let frameHeight =
        Namespaced_IRI.parse _namespace_name "frameHeight" |> NamespacedName

    /// <summary>
    /// Corresponds to 'frameRate' in the Ontology for Media Resources, in frame per second.
    /// <see href="http://www.w3.org/ns/ma-ont#frameRate"></see></summary>
    let frameRate = Namespaced_IRI.parse _namespace_name "frameRate" |> NamespacedName

    /// <summary>
    /// Corresponds to 'frameSize.unit' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#frameSizeUnit"></see></summary>
    let frameSizeUnit =
        Namespaced_IRI.parse _namespace_name "frameSizeUnit" |> NamespacedName

    /// <summary>
    /// Corresponds to 'frameSize.width' in the Ontology for Media Resources measured in frameSizeUnit.
    /// <see href="http://www.w3.org/ns/ma-ont#frameWidth"></see></summary>
    let frameWidth = Namespaced_IRI.parse _namespace_name "frameWidth" |> NamespacedName

    /// <summary>
    /// Corresponds to 'policy' in the Ontology for Media Resources with a 'policy.type' "access conditions".
    /// <see href="http://www.w3.org/ns/ma-ont#hasAccessConditions"></see></summary>
    let hasAccessConditions =
        Namespaced_IRI.parse _namespace_name "hasAccessConditions" |> NamespacedName

    /// <summary>
    /// Corresponds to 'policy' in the Ontology for Media Resources. Subproperties can be used to distinguish different values of 'policy.type'.
    /// <see href="http://www.w3.org/ns/ma-ont#hasPolicy"></see></summary>
    let hasPolicy = Namespaced_IRI.parse _namespace_name "hasPolicy" |> NamespacedName

    /// <summary>
    /// Corresponds to 'fragment' in the Ontology for Media Resources with a 'fragment.role' meaning "audio-description".
    /// <see href="http://www.w3.org/ns/ma-ont#hasAudioDescription"></see></summary>
    let hasAudioDescription =
        Namespaced_IRI.parse _namespace_name "hasAudioDescription" |> NamespacedName

    /// <summary>
    /// Corresponds to 'fragment' in the Ontology for Media Resources with a 'fragment.role' meaning "captioning". This property can for example point to a spatial fragment, a VideoTrack or a DataTrack. The language of the captioning track can be expressed by attaching a 'hasLanguage' property to the specific track.
    /// <see href="http://www.w3.org/ns/ma-ont#hasCaptioning"></see></summary>
    let hasCaptioning =
        Namespaced_IRI.parse _namespace_name "hasCaptioning" |> NamespacedName

    /// <summary>
    /// Corresponds to 'fragment' in the Ontology for Media Resources. Subproperties can be used to distinguish different values of 'fragment.role'.
    /// <see href="http://www.w3.org/ns/ma-ont#hasFragment"></see></summary>
    let hasFragment =
        Namespaced_IRI.parse _namespace_name "hasFragment" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#isCaptioningOf"></see>
    /// </summary>
    let isCaptioningOf =
        Namespaced_IRI.parse _namespace_name "isCaptioningOf" |> NamespacedName

    /// <summary>
    /// Corresponds to 'fragment' in the Ontology for Media Resources with a 'fragment.role' meaning "chapter".
    /// <see href="http://www.w3.org/ns/ma-ont#hasChapter"></see></summary>
    let hasChapter = Namespaced_IRI.parse _namespace_name "hasChapter" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#isChapterOf"></see>
    /// </summary>
    let isChapterOf =
        Namespaced_IRI.parse _namespace_name "isChapterOf" |> NamespacedName

    /// <summary>
    /// Corresponds to 'targetAudience.classification' in the Ontology for Media Resources. This property is used to provide a value characterising the target audience.
    /// <see href="http://www.w3.org/ns/ma-ont#hasClassification"></see></summary>
    let hasClassification =
        Namespaced_IRI.parse _namespace_name "hasClassification" |> NamespacedName

    /// <summary>
    /// Corresponds to 'targetAudience.identifier' in the Ontology for Media Resources. This is used to identify the reference sheme against which the target audience has been characterised.
    /// <see href="http://www.w3.org/ns/ma-ont#hasClassificationSystem"></see></summary>
    let hasClassificationSystem =
        Namespaced_IRI.parse _namespace_name "hasClassificationSystem" |> NamespacedName

    /// <summary>
    /// Corresponds to 'compression' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#hasCompression"></see></summary>
    let hasCompression =
        Namespaced_IRI.parse _namespace_name "hasCompression" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#hasContributedTo"></see>
    /// </summary>
    let hasContributedTo =
        Namespaced_IRI.parse _namespace_name "hasContributedTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#hasCopyrightOver"></see>
    /// </summary>
    let hasCopyrightOver =
        Namespaced_IRI.parse _namespace_name "hasCopyrightOver" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#hasCreated"></see>
    /// </summary>
    let hasCreated = Namespaced_IRI.parse _namespace_name "hasCreated" |> NamespacedName
    /// <summary>
    /// Corresponds to 'creator.creator' in the Ontology for Media Resources. Subproperties can be used to distinguish different values of 'creator.role'. Note that this property is semantically a subproperty of 'hasContributor'.
    /// <see href="http://www.w3.org/ns/ma-ont#hasCreator"></see></summary>
    let hasCreator = Namespaced_IRI.parse _namespace_name "hasCreator" |> NamespacedName
    /// <summary>
    /// Corresponds to 'format' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#hasFormat"></see></summary>
    let hasFormat = Namespaced_IRI.parse _namespace_name "hasFormat" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#isFragmentOf"></see>
    /// </summary>
    let isFragmentOf =
        Namespaced_IRI.parse _namespace_name "isFragmentOf" |> NamespacedName

    /// <summary>
    /// Corresponds to 'genre' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#hasGenre"></see></summary>
    let hasGenre = Namespaced_IRI.parse _namespace_name "hasGenre" |> NamespacedName
    /// <summary>
    /// Corresponds to 'keyword' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#hasKeyword"></see></summary>
    let hasKeyword = Namespaced_IRI.parse _namespace_name "hasKeyword" |> NamespacedName

    /// <summary>
    /// Corresponds to 'language' in the Ontology for Media Resources. The language used in the resource. A controlled vocabulary such as defined in BCP 47 SHOULD be used. This property can also be used to identify the presence of sign language (RFC 5646). By inheritance, the hasLanguage property applies indifferently at the media resource / fragment / track levels.  Best practice recommends to use to best possible level of granularity fo describe the usage of language within a media resource including at fragment and track levels.
    /// <see href="http://www.w3.org/ns/ma-ont#hasLanguage"></see></summary>
    let hasLanguage =
        Namespaced_IRI.parse _namespace_name "hasLanguage" |> NamespacedName

    /// <summary>
    /// Corresponds to 'location.coordinateSystem' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#hasLocationCoordinateSystem"></see></summary>
    let hasLocationCoordinateSystem =
        Namespaced_IRI.parse _namespace_name "hasLocationCoordinateSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#hasMember"></see>
    /// </summary>
    let hasMember = Namespaced_IRI.parse _namespace_name "hasMember" |> NamespacedName

    /// <summary>
    /// Corresponds to 'namedFragment' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#hasNamedFragment"></see></summary>
    let hasNamedFragment =
        Namespaced_IRI.parse _namespace_name "hasNamedFragment" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#isNamedFragmentOf"></see>
    /// </summary>
    let isNamedFragmentOf =
        Namespaced_IRI.parse _namespace_name "isNamedFragmentOf" |> NamespacedName

    /// <summary>
    /// Corresponds to 'policy' in the Ontology for Media Resources with a  'policy.type' meaning "permissions".
    /// <see href="http://www.w3.org/ns/ma-ont#hasPermissions"></see></summary>
    let hasPermissions =
        Namespaced_IRI.parse _namespace_name "hasPermissions" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#hasPublished"></see>
    /// </summary>
    let hasPublished =
        Namespaced_IRI.parse _namespace_name "hasPublished" |> NamespacedName

    /// <summary>
    /// Corresponds to 'publisher' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#hasPublisher"></see></summary>
    let hasPublisher =
        Namespaced_IRI.parse _namespace_name "hasPublisher" |> NamespacedName

    /// <summary>
    /// Corresponds to 'rating' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#hasRating"></see></summary>
    let hasRating = Namespaced_IRI.parse _namespace_name "hasRating" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#isRatingOf"></see>
    /// </summary>
    let isRatingOf = Namespaced_IRI.parse _namespace_name "isRatingOf" |> NamespacedName

    /// <summary>
    /// Corresponds to 'rating.type' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#hasRatingSystem"></see></summary>
    let hasRatingSystem =
        Namespaced_IRI.parse _namespace_name "hasRatingSystem" |> NamespacedName

    /// <summary>
    /// Corresponds to 'relation' and in the Ontology for Media Resources with a 'relation.type' meaning "related image".
    /// <see href="http://www.w3.org/ns/ma-ont#hasRelatedImage"></see></summary>
    let hasRelatedImage =
        Namespaced_IRI.parse _namespace_name "hasRelatedImage" |> NamespacedName

    /// <summary>
    /// Corresponds to 'relation' and in the Ontology for Media Resources. Subproperties can be used to distinguish different values of 'relation.type'.
    /// <see href="http://www.w3.org/ns/ma-ont#hasRelatedResource"></see></summary>
    let hasRelatedResource =
        Namespaced_IRI.parse _namespace_name "hasRelatedResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#isImageRelatedTo"></see>
    /// </summary>
    let isImageRelatedTo =
        Namespaced_IRI.parse _namespace_name "isImageRelatedTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#isLocationRelatedTo"></see>
    /// </summary>
    let isLocationRelatedTo =
        Namespaced_IRI.parse _namespace_name "isLocationRelatedTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#isRelatedTo"></see>
    /// </summary>
    let isRelatedTo =
        Namespaced_IRI.parse _namespace_name "isRelatedTo" |> NamespacedName

    /// <summary>
    /// Corresponds to 'fragment' in the Ontology for Media Resources with a 'fragment.role' meaning "signing". This property can for example point to a spatial fragment or a VideoTrack. The sign language of the captioning track can be expressed by attaching a 'hasLanguage' property to the specific track.
    /// <see href="http://www.w3.org/ns/ma-ont#hasSigning"></see></summary>
    let hasSigning = Namespaced_IRI.parse _namespace_name "hasSigning" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#isSigningOf"></see>
    /// </summary>
    let isSigningOf =
        Namespaced_IRI.parse _namespace_name "isSigningOf" |> NamespacedName

    /// <summary>
    /// Corresponds to 'relation' and in the Ontology for Media Resources with a 'relation.type' meaning "source".
    /// <see href="http://www.w3.org/ns/ma-ont#hasSource"></see></summary>
    let hasSource = Namespaced_IRI.parse _namespace_name "hasSource" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#isSourceOf"></see>
    /// </summary>
    let isSourceOf = Namespaced_IRI.parse _namespace_name "isSourceOf" |> NamespacedName

    /// <summary>
    /// Corresponds to 'fragment' in the Ontology for Media Resources with a 'fragment.role' meaning "subtitling".
    /// <see href="http://www.w3.org/ns/ma-ont#hasSubtitling"></see></summary>
    let hasSubtitling =
        Namespaced_IRI.parse _namespace_name "hasSubtitling" |> NamespacedName

    /// <summary>
    /// Corresponds to 'targetAudience' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#hasTargetAudience"></see></summary>
    let hasTargetAudience =
        Namespaced_IRI.parse _namespace_name "hasTargetAudience" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#isTargetAudienceOf"></see>
    /// </summary>
    let isTargetAudienceOf =
        Namespaced_IRI.parse _namespace_name "isTargetAudienceOf" |> NamespacedName

    /// <summary>
    /// Corresponds to 'fragment' in the Ontology for Media Resources with a 'fragment.role' meaning "track".
    /// <see href="http://www.w3.org/ns/ma-ont#hasTrack"></see></summary>
    let hasTrack = Namespaced_IRI.parse _namespace_name "hasTrack" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#isTrackOf"></see>
    /// </summary>
    let isTrackOf = Namespaced_IRI.parse _namespace_name "isTrackOf" |> NamespacedName

    /// <summary>
    /// Corresponds to 'copyright.identifier' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#isCopyrightedBy"></see></summary>
    let isCopyrightedBy =
        Namespaced_IRI.parse _namespace_name "isCopyrightedBy" |> NamespacedName

    /// <summary>
    /// Corresponds to 'collection' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#isMemberOf"></see></summary>
    let isMemberOf = Namespaced_IRI.parse _namespace_name "isMemberOf" |> NamespacedName

    /// <summary>
    /// Corresponds to 'rating.identifier' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#isProvidedBy"></see></summary>
    let isProvidedBy =
        Namespaced_IRI.parse _namespace_name "isProvidedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/ns/ma-ont#provides"></see>
    /// </summary>
    let provides = Namespaced_IRI.parse _namespace_name "provides" |> NamespacedName

    /// <summary>
    /// Corresponds to 'location.altitude' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#locationAltitude"></see></summary>
    let locationAltitude =
        Namespaced_IRI.parse _namespace_name "locationAltitude" |> NamespacedName

    /// <summary>
    /// Corresponds to 'location.latitude' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#locationLatitude"></see></summary>
    let locationLatitude =
        Namespaced_IRI.parse _namespace_name "locationLatitude" |> NamespacedName

    /// <summary>
    /// Corresponds to 'location.longitude' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#locationLongitude"></see></summary>
    let locationLongitude =
        Namespaced_IRI.parse _namespace_name "locationLongitude" |> NamespacedName

    /// <summary>
    /// Corresponds to 'location.name' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#locationName"></see></summary>
    let locationName =
        Namespaced_IRI.parse _namespace_name "locationName" |> NamespacedName

    /// <summary>
    /// Corresponds to 'locator' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#locator"></see></summary>
    let locator = Namespaced_IRI.parse _namespace_name "locator" |> NamespacedName

    /// <summary>
    /// Corresponds to 'title.title' in the Ontology for Media Resources with a 'title.type' meaning "original".
    /// <see href="http://www.w3.org/ns/ma-ont#mainOriginalTitle"></see></summary>
    let mainOriginalTitle =
        Namespaced_IRI.parse _namespace_name "mainOriginalTitle" |> NamespacedName

    /// <summary>
    /// Corresponds to 'numTracks.number' in the Ontology for Media Resources. Subproperties can be used to distinguish different values of 'numTracks.type'.
    /// <see href="http://www.w3.org/ns/ma-ont#numberOfTracks"></see></summary>
    let numberOfTracks =
        Namespaced_IRI.parse _namespace_name "numberOfTracks" |> NamespacedName

    /// <summary>
    /// Corresponds to 'rating.max' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#ratingScaleMax"></see></summary>
    let ratingScaleMax =
        Namespaced_IRI.parse _namespace_name "ratingScaleMax" |> NamespacedName

    /// <summary>
    /// Corresponds to 'rating.min' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#ratingScaleMin"></see></summary>
    let ratingScaleMin =
        Namespaced_IRI.parse _namespace_name "ratingScaleMin" |> NamespacedName

    /// <summary>
    /// Corresponds to 'rating.value' in the Ontology for Media Resources.
    /// <see href="http://www.w3.org/ns/ma-ont#ratingValue"></see></summary>
    let ratingValue =
        Namespaced_IRI.parse _namespace_name "ratingValue" |> NamespacedName

    /// <summary>
    /// Corresponds to 'date.date' in the Ontology for Media Resources with a 'date.type' meaning "recordDate".
    /// <see href="http://www.w3.org/ns/ma-ont#recordDate"></see></summary>
    let recordDate = Namespaced_IRI.parse _namespace_name "recordDate" |> NamespacedName

    /// <summary>
    /// Corresponds to 'date.date' in the Ontology for Media Resources with a 'date.type' meaning "releaseDate".
    /// <see href="http://www.w3.org/ns/ma-ont#releaseDate"></see></summary>
    let releaseDate =
        Namespaced_IRI.parse _namespace_name "releaseDate" |> NamespacedName

    /// <summary>
    /// Corresponds to 'samplingRate' in the Ontology for Media Resources, in samples per second.
    /// <see href="http://www.w3.org/ns/ma-ont#samplingRate"></see></summary>
    let samplingRate =
        Namespaced_IRI.parse _namespace_name "samplingRate" |> NamespacedName

    /// <summary>
    /// Corresponds to 'fragment.name' in the Ontology for Media Resources, for Track fragments.
    /// <see href="http://www.w3.org/ns/ma-ont#trackName"></see></summary>
    let trackName = Namespaced_IRI.parse _namespace_name "trackName" |> NamespacedName
