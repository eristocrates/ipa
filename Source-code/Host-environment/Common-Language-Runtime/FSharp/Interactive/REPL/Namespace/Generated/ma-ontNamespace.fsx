#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``ma-ont`` =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/ma-ont#" "ma-ont"
    /// <summary>
    ///   <para>rdfs:comment : A person or organisation contributing to the media resource.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#Agent">ma-ont:Agent</a>
    /// </summary>
    let Agent = _prefixId.prefix "Agent"
    /// <summary>
    ///   <para>rdfs:comment : A specialisation of Track for Audio to provide a link to specific data properties such as sampleRate, etc. Specialisation is defined through object properties.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#AudioTrack">ma-ont:AudioTrack</a>
    /// </summary>
    let AudioTrack = _prefixId.prefix "AudioTrack"
    /// <summary>
    ///   <para>rdfs:comment : Any group of media resource e.g. a series.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#Collection">ma-ont:Collection</a>
    /// </summary>
    let Collection = _prefixId.prefix "Collection"
    /// <summary>
    ///   <para>rdfs:comment : Ancillary data track e.g. captioning  in addition to video and audio tracks. Specialisation is made through the use of appropriate object properties.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#DataTrack">ma-ont:DataTrack</a>
    /// </summary>
    let DataTrack = _prefixId.prefix "DataTrack"
    /// <summary>
    ///   <para>rdfs:comment : A still image / thumbnail / key frame related to the media resource or being the media resource itself.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#Image">ma-ont:Image</a>
    /// </summary>
    let Image = _prefixId.prefix "Image"
    /// <summary>
    ///   <para>rdfs:comment : A location related to the media resource, e.g. depicted in the resource (possibly fictional) or where the resource was created (shooting location), etc.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#Location">ma-ont:Location</a>
    /// </summary>
    let Location = _prefixId.prefix "Location"
    /// <summary>
    ///   <para>rdfs:comment : A media fragment (spatial, temporal, track...) composing a media resource. In other ontologies fragment is sometimes referred to as a 'part' or 'segment'.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#MediaFragment">ma-ont:MediaFragment</a>
    /// </summary>
    let MediaFragment = _prefixId.prefix "MediaFragment"
    /// <summary>
    ///   <para>rdfs:comment : An image or an audiovisual media resource, which can be composed of one or more fragment / track.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#MediaResource">ma-ont:MediaResource</a>
    /// </summary>
    let MediaResource = _prefixId.prefix "MediaResource"
    /// <summary>
    ///   <para>rdfs:comment : An organisation or moral agent.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#Organisation">ma-ont:Organisation</a>
    /// </summary>
    let Organisation = _prefixId.prefix "Organisation"
    /// <summary>
    ///   <para>rdfs:comment : A physical person.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#Person">ma-ont:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>rdfs:comment : Information about the rating given to a media resource.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#Rating">ma-ont:Rating</a>
    /// </summary>
    let Rating = _prefixId.prefix "Rating"
    /// <summary>
    ///   <para>rdfs:comment : Information about The target audience (target region, target audience category but also parental guidance recommendation) for which a media resource is intended.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#TargetAudience">ma-ont:TargetAudience</a>
    /// </summary>
    let TargetAudience = _prefixId.prefix "TargetAudience"
    /// <summary>
    ///   <para>rdfs:comment : A specialisation of MediaFragment for audiovisual content.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#Track">ma-ont:Track</a>
    /// </summary>
    let Track = _prefixId.prefix "Track"
    /// <summary>
    ///   <para>rdfs:comment : A specialisation of Track for Video to provide a link to specific data properties such as frameRate, etc. Signing is another possible example of video track. Specialisation is defined through object properties.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#VideoTrack">ma-ont:VideoTrack</a>
    /// </summary>
    let VideoTrack = _prefixId.prefix "VideoTrack"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'title.title' in the Ontology for Media Resources with a 'title.type' meaning "alternative".^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#alternativeTitle">ma-ont:alternativeTitle</a>
    /// </summary>
    let alternativeTitle = _prefixId.prefix "alternativeTitle"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'averageBitRate' in the Ontology for Media Resources, expressed in kilobits/second.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#averageBitRate">ma-ont:averageBitRate</a>
    /// </summary>
    let averageBitRate = _prefixId.prefix "averageBitRate"
    /// <summary>
    ///   <para>rdfs:comment : The name by which a collection (e.g. series) is known.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#collectionName">ma-ont:collectionName</a>
    /// </summary>
    let collectionName = _prefixId.prefix "collectionName"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'copyright.copyright' in the Ontology for Media Resources.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#copyright">ma-ont:copyright</a>
    /// </summary>
    let copyright = _prefixId.prefix "copyright"
    /// <summary>
    ///   <para>rdfs:comment : A subproperty of 'hasRelatedLocation" used to specify where material shooting took place.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#createdIn">ma-ont:createdIn</a>
    /// </summary>
    let createdIn = _prefixId.prefix "createdIn"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'date.date' in the Ontology for Media Resources with a 'date.type' meaning "creationDate".^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#creationDate">ma-ont:creationDate</a>
    /// </summary>
    let creationDate = _prefixId.prefix "creationDate"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to date.date in the ontology for Media Resources. Subproperties can be used to distinguish different values of 'date.type'. The recommended range is 'xsd:dateTime' (for compliance with OWL2-QL and OWL2-RL) but other time-related datatypes may be used (e.g. 'xsd:gYear', 'xsd:date'...).^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#date">ma-ont:date</a>
    /// </summary>
    let date = _prefixId.prefix "date"
    /// <summary>
    ///   <para>rdfs:comment : A subproperty of 'hasRelatedLocation' used to specify where the action depicted in the media is supposed to take place, as opposed to the location where shooting actually took place (see 'createdIn').^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#depictsFictionalLocation">ma-ont:depictsFictionalLocation</a>
    /// </summary>
    let depictsFictionalLocation = _prefixId.prefix "depictsFictionalLocation"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'description' in the Ontology for Media Resources. This can be specialised by using sub-properties e.g. 'summary' or 'script'.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#description">ma-ont:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'duration' in the Ontology for Media Resources.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#duration">ma-ont:duration</a>
    /// </summary>
    let duration = _prefixId.prefix "duration"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'date.date' in the Ontology for Media Resources with a 'date.type' meaning "editDate".^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#editDate">ma-ont:editDate</a>
    /// </summary>
    let editDate = _prefixId.prefix "editDate"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'contributor.contributor' in the Ontology for Media Resources with a 'contributor.role' meaning "actor".^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#features">ma-ont:features</a>
    /// </summary>
    let features = _prefixId.prefix "features"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'namedFragment.label' in the Ontology for Media Resources.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#fragmentName">ma-ont:fragmentName</a>
    /// </summary>
    let fragmentName = _prefixId.prefix "fragmentName"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'frameSize.height' in the Ontology for Media Resources, measured in frameSizeUnit.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#frameHeight">ma-ont:frameHeight</a>
    /// </summary>
    let frameHeight = _prefixId.prefix "frameHeight"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'frameRate' in the Ontology for Media Resources, in frame per second.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#frameRate">ma-ont:frameRate</a>
    /// </summary>
    let frameRate = _prefixId.prefix "frameRate"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'frameSize.unit' in the Ontology for Media Resources.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#frameSizeUnit">ma-ont:frameSizeUnit</a>
    /// </summary>
    let frameSizeUnit = _prefixId.prefix "frameSizeUnit"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'frameSize.width' in the Ontology for Media Resources measured in frameSizeUnit.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#frameWidth">ma-ont:frameWidth</a>
    /// </summary>
    let frameWidth = _prefixId.prefix "frameWidth"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'policy' in the Ontology for Media Resources with a 'policy.type' "access conditions".^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#hasAccessConditions">ma-ont:hasAccessConditions</a>
    /// </summary>
    let hasAccessConditions = _prefixId.prefix "hasAccessConditions"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'fragment' in the Ontology for Media Resources with a 'fragment.role' meaning "audio-description".^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#hasAudioDescription">ma-ont:hasAudioDescription</a>
    /// </summary>
    let hasAudioDescription = _prefixId.prefix "hasAudioDescription"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'fragment' in the Ontology for Media Resources with a 'fragment.role' meaning "captioning". This property can for example point to a spatial fragment, a VideoTrack or a DataTrack. The language of the captioning track can be expressed by attaching a 'hasLanguage' property to the specific track.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#hasCaptioning">ma-ont:hasCaptioning</a>
    /// </summary>
    let hasCaptioning = _prefixId.prefix "hasCaptioning"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'fragment' in the Ontology for Media Resources with a 'fragment.role' meaning "chapter".^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#hasChapter">ma-ont:hasChapter</a>
    /// </summary>
    let hasChapter = _prefixId.prefix "hasChapter"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'targetAudience.classification' in the Ontology for Media Resources. This property is used to provide a value characterising the target audience.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#hasClassification">ma-ont:hasClassification</a>
    /// </summary>
    let hasClassification = _prefixId.prefix "hasClassification"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'targetAudience.identifier' in the Ontology for Media Resources. This is used to identify the reference sheme against which the target audience has been characterised.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#hasClassificationSystem">ma-ont:hasClassificationSystem</a>
    /// </summary>
    let hasClassificationSystem = _prefixId.prefix "hasClassificationSystem"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'compression' in the Ontology for Media Resources.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#hasCompression">ma-ont:hasCompression</a>
    /// </summary>
    let hasCompression = _prefixId.prefix "hasCompression"
    let hasContributedTo = _prefixId.prefix "hasContributedTo"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'contributor.contributor' in the Ontology for Media Resources. Subproperties can be used to distinguish different values of 'contributor.role'.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#hasContributor">ma-ont:hasContributor</a>
    /// </summary>
    let hasContributor = _prefixId.prefix "hasContributor"
    let hasCopyrightOver = _prefixId.prefix "hasCopyrightOver"
    let hasCreated = _prefixId.prefix "hasCreated"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'creator.creator' in the Ontology for Media Resources. Subproperties can be used to distinguish different values of 'creator.role'. Note that this property is semantically a subproperty of 'hasContributor'.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#hasCreator">ma-ont:hasCreator</a>
    /// </summary>
    let hasCreator = _prefixId.prefix "hasCreator"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'format' in the Ontology for Media Resources.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#hasFormat">ma-ont:hasFormat</a>
    /// </summary>
    let hasFormat = _prefixId.prefix "hasFormat"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'fragment' in the Ontology for Media Resources. Subproperties can be used to distinguish different values of 'fragment.role'.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#hasFragment">ma-ont:hasFragment</a>
    /// </summary>
    let hasFragment = _prefixId.prefix "hasFragment"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'genre' in the Ontology for Media Resources.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#hasGenre">ma-ont:hasGenre</a>
    /// </summary>
    let hasGenre = _prefixId.prefix "hasGenre"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'keyword' in the Ontology for Media Resources.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#hasKeyword">ma-ont:hasKeyword</a>
    /// </summary>
    let hasKeyword = _prefixId.prefix "hasKeyword"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'language' in the Ontology for Media Resources. The language used in the resource. A controlled vocabulary such as defined in BCP 47 SHOULD be used. This property can also be used to identify the presence of sign language (RFC 5646). By inheritance, the hasLanguage property applies indifferently at the media resource / fragment / track levels.  Best practice recommends to use to best possible level of granularity fo describe the usage of language within a media resource including at fragment and track levels.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#hasLanguage">ma-ont:hasLanguage</a>
    /// </summary>
    let hasLanguage = _prefixId.prefix "hasLanguage"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'location.coordinateSystem' in the Ontology for Media Resources.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#hasLocationCoordinateSystem">ma-ont:hasLocationCoordinateSystem</a>
    /// </summary>
    let hasLocationCoordinateSystem = _prefixId.prefix "hasLocationCoordinateSystem"
    let hasMember = _prefixId.prefix "hasMember"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'namedFragment' in the Ontology for Media Resources.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#hasNamedFragment">ma-ont:hasNamedFragment</a>
    /// </summary>
    let hasNamedFragment = _prefixId.prefix "hasNamedFragment"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'policy' in the Ontology for Media Resources with a  'policy.type' meaning "permissions".^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#hasPermissions">ma-ont:hasPermissions</a>
    /// </summary>
    let hasPermissions = _prefixId.prefix "hasPermissions"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'policy' in the Ontology for Media Resources. Subproperties can be used to distinguish different values of 'policy.type'.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#hasPolicy">ma-ont:hasPolicy</a>
    /// </summary>
    let hasPolicy = _prefixId.prefix "hasPolicy"
    let hasPublished = _prefixId.prefix "hasPublished"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'publisher' in the Ontology for Media Resources.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#hasPublisher">ma-ont:hasPublisher</a>
    /// </summary>
    let hasPublisher = _prefixId.prefix "hasPublisher"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'rating' in the Ontology for Media Resources.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#hasRating">ma-ont:hasRating</a>
    /// </summary>
    let hasRating = _prefixId.prefix "hasRating"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'rating.type' in the Ontology for Media Resources.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#hasRatingSystem">ma-ont:hasRatingSystem</a>
    /// </summary>
    let hasRatingSystem = _prefixId.prefix "hasRatingSystem"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'relation' and in the Ontology for Media Resources with a 'relation.type' meaning "related image".^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#hasRelatedImage">ma-ont:hasRelatedImage</a>
    /// </summary>
    let hasRelatedImage = _prefixId.prefix "hasRelatedImage"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'location' in the Ontology for Media Resources. Subproperties are provided to specify, when possible, the relation between the media resource and the location.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#hasRelatedLocation">ma-ont:hasRelatedLocation</a>
    /// </summary>
    let hasRelatedLocation = _prefixId.prefix "hasRelatedLocation"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'relation' and in the Ontology for Media Resources. Subproperties can be used to distinguish different values of 'relation.type'.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#hasRelatedResource">ma-ont:hasRelatedResource</a>
    /// </summary>
    let hasRelatedResource = _prefixId.prefix "hasRelatedResource"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'fragment' in the Ontology for Media Resources with a 'fragment.role' meaning "signing". This property can for example point to a spatial fragment or a VideoTrack. The sign language of the captioning track can be expressed by attaching a 'hasLanguage' property to the specific track.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#hasSigning">ma-ont:hasSigning</a>
    /// </summary>
    let hasSigning = _prefixId.prefix "hasSigning"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'relation' and in the Ontology for Media Resources with a 'relation.type' meaning "source".^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#hasSource">ma-ont:hasSource</a>
    /// </summary>
    let hasSource = _prefixId.prefix "hasSource"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'fragment' in the Ontology for Media Resources with a 'fragment.role' meaning "subtitling".^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#hasSubtitling">ma-ont:hasSubtitling</a>
    /// </summary>
    let hasSubtitling = _prefixId.prefix "hasSubtitling"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'targetAudience' in the Ontology for Media Resources.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#hasTargetAudience">ma-ont:hasTargetAudience</a>
    /// </summary>
    let hasTargetAudience = _prefixId.prefix "hasTargetAudience"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'fragment' in the Ontology for Media Resources with a 'fragment.role' meaning "track".^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#hasTrack">ma-ont:hasTrack</a>
    /// </summary>
    let hasTrack = _prefixId.prefix "hasTrack"
    let isCaptioningOf = _prefixId.prefix "isCaptioningOf"
    let isChapterOf = _prefixId.prefix "isChapterOf"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'copyright.identifier' in the Ontology for Media Resources.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#isCopyrightedBy">ma-ont:isCopyrightedBy</a>
    /// </summary>
    let isCopyrightedBy = _prefixId.prefix "isCopyrightedBy"
    let isCreationLocationOf = _prefixId.prefix "isCreationLocationOf"
    let isFictionalLocationDepictedIn = _prefixId.prefix "isFictionalLocationDepictedIn"
    let isFragmentOf = _prefixId.prefix "isFragmentOf"
    let isImageRelatedTo = _prefixId.prefix "isImageRelatedTo"
    let isLocationRelatedTo = _prefixId.prefix "isLocationRelatedTo"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'collection' in the Ontology for Media Resources.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#isMemberOf">ma-ont:isMemberOf</a>
    /// </summary>
    let isMemberOf = _prefixId.prefix "isMemberOf"
    let isNamedFragmentOf = _prefixId.prefix "isNamedFragmentOf"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'rating.identifier' in the Ontology for Media Resources.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#isProvidedBy">ma-ont:isProvidedBy</a>
    /// </summary>
    let isProvidedBy = _prefixId.prefix "isProvidedBy"
    let isRatingOf = _prefixId.prefix "isRatingOf"
    let isRelatedTo = _prefixId.prefix "isRelatedTo"
    let isSigningOf = _prefixId.prefix "isSigningOf"
    let isSourceOf = _prefixId.prefix "isSourceOf"
    let isTargetAudienceOf = _prefixId.prefix "isTargetAudienceOf"
    let isTrackOf = _prefixId.prefix "isTrackOf"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'location.altitude' in the Ontology for Media Resources.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#locationAltitude">ma-ont:locationAltitude</a>
    /// </summary>
    let locationAltitude = _prefixId.prefix "locationAltitude"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'location.latitude' in the Ontology for Media Resources.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#locationLatitude">ma-ont:locationLatitude</a>
    /// </summary>
    let locationLatitude = _prefixId.prefix "locationLatitude"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'location.longitude' in the Ontology for Media Resources.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#locationLongitude">ma-ont:locationLongitude</a>
    /// </summary>
    let locationLongitude = _prefixId.prefix "locationLongitude"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'location.name' in the Ontology for Media Resources.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#locationName">ma-ont:locationName</a>
    /// </summary>
    let locationName = _prefixId.prefix "locationName"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'locator' in the Ontology for Media Resources.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#locator">ma-ont:locator</a>
    /// </summary>
    let locator = _prefixId.prefix "locator"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'title.title' in the Ontology for Media Resources with a 'title.type' meaning "original".^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#mainOriginalTitle">ma-ont:mainOriginalTitle</a>
    /// </summary>
    let mainOriginalTitle = _prefixId.prefix "mainOriginalTitle"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'numTracks.number' in the Ontology for Media Resources. Subproperties can be used to distinguish different values of 'numTracks.type'.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#numberOfTracks">ma-ont:numberOfTracks</a>
    /// </summary>
    let numberOfTracks = _prefixId.prefix "numberOfTracks"
    let playsIn = _prefixId.prefix "playsIn"
    let provides = _prefixId.prefix "provides"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'rating.max' in the Ontology for Media Resources.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#ratingScaleMax">ma-ont:ratingScaleMax</a>
    /// </summary>
    let ratingScaleMax = _prefixId.prefix "ratingScaleMax"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'rating.min' in the Ontology for Media Resources.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#ratingScaleMin">ma-ont:ratingScaleMin</a>
    /// </summary>
    let ratingScaleMin = _prefixId.prefix "ratingScaleMin"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'rating.value' in the Ontology for Media Resources.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#ratingValue">ma-ont:ratingValue</a>
    /// </summary>
    let ratingValue = _prefixId.prefix "ratingValue"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'date.date' in the Ontology for Media Resources with a 'date.type' meaning "recordDate".^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#recordDate">ma-ont:recordDate</a>
    /// </summary>
    let recordDate = _prefixId.prefix "recordDate"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'date.date' in the Ontology for Media Resources with a 'date.type' meaning "releaseDate".^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#releaseDate">ma-ont:releaseDate</a>
    /// </summary>
    let releaseDate = _prefixId.prefix "releaseDate"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'samplingRate' in the Ontology for Media Resources, in samples per second.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#samplingRate">ma-ont:samplingRate</a>
    /// </summary>
    let samplingRate = _prefixId.prefix "samplingRate"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'title.title' in the Ontology for Media Resources. Subproperties can be used to distinguish different values of 'title.type'.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#title">ma-ont:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'fragment.name' in the Ontology for Media Resources, for Track fragments.^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/ma-ont#trackName">ma-ont:trackName</a>
    /// </summary>
    let trackName = _prefixId.prefix "trackName"
