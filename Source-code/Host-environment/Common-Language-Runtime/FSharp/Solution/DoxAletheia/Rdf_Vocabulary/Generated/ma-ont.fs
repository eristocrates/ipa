namespace http.www.w3.org.ns.ma_ont.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ma_ont =
    let _namespace_iri = Namespace_Iri ma_ont |> NamespaceIRI
    /// <summary>
    ///   <para>ma-ont:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A person or organisation contributing to the media resource.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#Agent">http://www.w3.org/ns/ma-ont#Agent</seealso>
    let Agent = Prefixed_Name(ma_ont, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A location related to the media resource, e.g. depicted in the resource (possibly fictional) or where the resource was created (shooting location), etc.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#Location">http://www.w3.org/ns/ma-ont#Location</seealso>
    let Location = Prefixed_Name(ma_ont, "Location") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:Collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any group of media resource e.g. a series.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#Collection">http://www.w3.org/ns/ma-ont#Collection</seealso>
    let Collection = Prefixed_Name(ma_ont, "Collection") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:MediaResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An image or an audiovisual media resource, which can be composed of one or more fragment / track.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#MediaResource">http://www.w3.org/ns/ma-ont#MediaResource</seealso>
    let MediaResource = Prefixed_Name(ma_ont, "MediaResource") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:VideoTrack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A specialisation of Track for Video to provide a link to specific data properties such as frameRate, etc. Signing is another possible example of video track. Specialisation is defined through object properties.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#VideoTrack">http://www.w3.org/ns/ma-ont#VideoTrack</seealso>
    let VideoTrack = Prefixed_Name(ma_ont, "VideoTrack") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:TargetAudience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information about The target audience (target region, target audience category but also parental guidance recommendation) for which a media resource is intended.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#TargetAudience">http://www.w3.org/ns/ma-ont#TargetAudience</seealso>
    let TargetAudience = Prefixed_Name(ma_ont, "TargetAudience") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:isCopyrightedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Corresponds to 'copyright.identifier' in the Ontology for Media Resources.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#isCopyrightedBy">http://www.w3.org/ns/ma-ont#isCopyrightedBy</seealso>
    let isCopyrightedBy = Prefixed_Name(ma_ont, "isCopyrightedBy") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:Rating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information about the rating given to a media resource.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#Rating">http://www.w3.org/ns/ma-ont#Rating</seealso>
    let Rating = Prefixed_Name(ma_ont, "Rating") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:Track</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A specialisation of MediaFragment for audiovisual content.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#Track">http://www.w3.org/ns/ma-ont#Track</seealso>
    let Track = Prefixed_Name(ma_ont, "Track") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:Image</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A still image / thumbnail / key frame related to the media resource or being the media resource itself.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#Image">http://www.w3.org/ns/ma-ont#Image</seealso>
    let Image = Prefixed_Name(ma_ont, "Image") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:MediaFragment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A media fragment (spatial, temporal, track...) composing a media resource. In other ontologies fragment is sometimes referred to as a 'part' or 'segment'.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#MediaFragment">http://www.w3.org/ns/ma-ont#MediaFragment</seealso>
    let MediaFragment = Prefixed_Name(ma_ont, "MediaFragment") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:Organisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An organisation or moral agent.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#Organisation">http://www.w3.org/ns/ma-ont#Organisation</seealso>
    let Organisation = Prefixed_Name(ma_ont, "Organisation") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:alternativeTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Corresponds to 'title.title' in the Ontology for Media Resources with a 'title.type' meaning "alternative".</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#alternativeTitle">http://www.w3.org/ns/ma-ont#alternativeTitle</seealso>
    let alternativeTitle = Prefixed_Name(ma_ont, "alternativeTitle") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:AudioTrack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A specialisation of Track for Audio to provide a link to specific data properties such as sampleRate, etc. Specialisation is defined through object properties.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#AudioTrack">http://www.w3.org/ns/ma-ont#AudioTrack</seealso>
    let AudioTrack = Prefixed_Name(ma_ont, "AudioTrack") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:DataTrack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Ancillary data track e.g. captioning  in addition to video and audio tracks. Specialisation is made through the use of appropriate object properties.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#DataTrack">http://www.w3.org/ns/ma-ont#DataTrack</seealso>
    let DataTrack = Prefixed_Name(ma_ont, "DataTrack") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A physical person.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#Person">http://www.w3.org/ns/ma-ont#Person</seealso>
    let Person = Prefixed_Name(ma_ont, "Person") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Corresponds to 'title.title' in the Ontology for Media Resources. Subproperties can be used to distinguish different values of 'title.type'.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#title">http://www.w3.org/ns/ma-ont#title</seealso>
    let title = Prefixed_Name(ma_ont, "title") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:collectionName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The name by which a collection (e.g. series) is known.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#collectionName">http://www.w3.org/ns/ma-ont#collectionName</seealso>
    let collectionName = Prefixed_Name(ma_ont, "collectionName") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:createdIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A subproperty of 'hasRelatedLocation" used to specify where material shooting took place.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#createdIn">http://www.w3.org/ns/ma-ont#createdIn</seealso>
    let createdIn = Prefixed_Name(ma_ont, "createdIn") |> PrefixedName

    /// <summary>
    ///   <para>ma-ont:isCreationLocationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#isCreationLocationOf">http://www.w3.org/ns/ma-ont#isCreationLocationOf</seealso>
    let isCreationLocationOf =
        Prefixed_Name(ma_ont, "isCreationLocationOf") |> PrefixedName

    /// <summary>
    ///   <para>ma-ont:depictsFictionalLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A subproperty of 'hasRelatedLocation' used to specify where the action depicted in the media is supposed to take place, as opposed to the location where shooting actually took place (see 'createdIn').</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#depictsFictionalLocation">http://www.w3.org/ns/ma-ont#depictsFictionalLocation</seealso>
    let depictsFictionalLocation =
        Prefixed_Name(ma_ont, "depictsFictionalLocation") |> PrefixedName

    /// <summary>
    ///   <para>ma-ont:duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Corresponds to 'duration' in the Ontology for Media Resources.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#duration">http://www.w3.org/ns/ma-ont#duration</seealso>
    let duration = Prefixed_Name(ma_ont, "duration") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:features</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Corresponds to 'contributor.contributor' in the Ontology for Media Resources with a 'contributor.role' meaning "actor".</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#features">http://www.w3.org/ns/ma-ont#features</seealso>
    let features = Prefixed_Name(ma_ont, "features") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:hasContributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Corresponds to 'contributor.contributor' in the Ontology for Media Resources. Subproperties can be used to distinguish different values of 'contributor.role'.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#hasContributor">http://www.w3.org/ns/ma-ont#hasContributor</seealso>
    let hasContributor = Prefixed_Name(ma_ont, "hasContributor") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:frameRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Corresponds to 'frameRate' in the Ontology for Media Resources, in frame per second.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#frameRate">http://www.w3.org/ns/ma-ont#frameRate</seealso>
    let frameRate = Prefixed_Name(ma_ont, "frameRate") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:frameWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Corresponds to 'frameSize.width' in the Ontology for Media Resources measured in frameSizeUnit.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#frameWidth">http://www.w3.org/ns/ma-ont#frameWidth</seealso>
    let frameWidth = Prefixed_Name(ma_ont, "frameWidth") |> PrefixedName

    /// <summary>
    ///   <para>ma-ont:hasAccessConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Corresponds to 'policy' in the Ontology for Media Resources with a 'policy.type' "access conditions".</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#hasAccessConditions">http://www.w3.org/ns/ma-ont#hasAccessConditions</seealso>
    let hasAccessConditions =
        Prefixed_Name(ma_ont, "hasAccessConditions") |> PrefixedName

    /// <summary>
    ///   <para>ma-ont:hasFragment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Corresponds to 'fragment' in the Ontology for Media Resources. Subproperties can be used to distinguish different values of 'fragment.role'.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#hasFragment">http://www.w3.org/ns/ma-ont#hasFragment</seealso>
    let hasFragment = Prefixed_Name(ma_ont, "hasFragment") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:isCaptioningOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#isCaptioningOf">http://www.w3.org/ns/ma-ont#isCaptioningOf</seealso>
    let isCaptioningOf = Prefixed_Name(ma_ont, "isCaptioningOf") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:hasChapter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Corresponds to 'fragment' in the Ontology for Media Resources with a 'fragment.role' meaning "chapter".</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#hasChapter">http://www.w3.org/ns/ma-ont#hasChapter</seealso>
    let hasChapter = Prefixed_Name(ma_ont, "hasChapter") |> PrefixedName

    /// <summary>
    ///   <para>ma-ont:hasClassificationSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Corresponds to 'targetAudience.identifier' in the Ontology for Media Resources. This is used to identify the reference sheme against which the target audience has been characterised.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#hasClassificationSystem">http://www.w3.org/ns/ma-ont#hasClassificationSystem</seealso>
    let hasClassificationSystem =
        Prefixed_Name(ma_ont, "hasClassificationSystem") |> PrefixedName

    /// <summary>
    ///   <para>ma-ont:hasCompression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Corresponds to 'compression' in the Ontology for Media Resources.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#hasCompression">http://www.w3.org/ns/ma-ont#hasCompression</seealso>
    let hasCompression = Prefixed_Name(ma_ont, "hasCompression") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:hasFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Corresponds to 'format' in the Ontology for Media Resources.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#hasFormat">http://www.w3.org/ns/ma-ont#hasFormat</seealso>
    let hasFormat = Prefixed_Name(ma_ont, "hasFormat") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:hasLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Corresponds to 'language' in the Ontology for Media Resources. The language used in the resource. A controlled vocabulary such as defined in BCP 47 SHOULD be used. This property can also be used to identify the presence of sign language (RFC 5646). By inheritance, the hasLanguage property applies indifferently at the media resource / fragment / track levels.  Best practice recommends to use to best possible level of granularity fo describe the usage of language within a media resource including at fragment and track levels.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#hasLanguage">http://www.w3.org/ns/ma-ont#hasLanguage</seealso>
    let hasLanguage = Prefixed_Name(ma_ont, "hasLanguage") |> PrefixedName

    /// <summary>
    ///   <para>ma-ont:hasLocationCoordinateSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Corresponds to 'location.coordinateSystem' in the Ontology for Media Resources.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#hasLocationCoordinateSystem">http://www.w3.org/ns/ma-ont#hasLocationCoordinateSystem</seealso>
    let hasLocationCoordinateSystem =
        Prefixed_Name(ma_ont, "hasLocationCoordinateSystem") |> PrefixedName

    /// <summary>
    ///   <para>ma-ont:hasPublished</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#hasPublished">http://www.w3.org/ns/ma-ont#hasPublished</seealso>
    let hasPublished = Prefixed_Name(ma_ont, "hasPublished") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:hasPublisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Corresponds to 'publisher' in the Ontology for Media Resources.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#hasPublisher">http://www.w3.org/ns/ma-ont#hasPublisher</seealso>
    let hasPublisher = Prefixed_Name(ma_ont, "hasPublisher") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:hasRelatedImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Corresponds to 'relation' and in the Ontology for Media Resources with a 'relation.type' meaning "related image".</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#hasRelatedImage">http://www.w3.org/ns/ma-ont#hasRelatedImage</seealso>
    let hasRelatedImage = Prefixed_Name(ma_ont, "hasRelatedImage") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:hasRelatedResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Corresponds to 'relation' and in the Ontology for Media Resources. Subproperties can be used to distinguish different values of 'relation.type'.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#hasRelatedResource">http://www.w3.org/ns/ma-ont#hasRelatedResource</seealso>
    let hasRelatedResource = Prefixed_Name(ma_ont, "hasRelatedResource") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:isImageRelatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#isImageRelatedTo">http://www.w3.org/ns/ma-ont#isImageRelatedTo</seealso>
    let isImageRelatedTo = Prefixed_Name(ma_ont, "isImageRelatedTo") |> PrefixedName

    /// <summary>
    ///   <para>ma-ont:isLocationRelatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#isLocationRelatedTo">http://www.w3.org/ns/ma-ont#isLocationRelatedTo</seealso>
    let isLocationRelatedTo =
        Prefixed_Name(ma_ont, "isLocationRelatedTo") |> PrefixedName

    /// <summary>
    ///   <para>ma-ont:hasSubtitling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Corresponds to 'fragment' in the Ontology for Media Resources with a 'fragment.role' meaning "subtitling".</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#hasSubtitling">http://www.w3.org/ns/ma-ont#hasSubtitling</seealso>
    let hasSubtitling = Prefixed_Name(ma_ont, "hasSubtitling") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:hasTargetAudience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Corresponds to 'targetAudience' in the Ontology for Media Resources.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#hasTargetAudience">http://www.w3.org/ns/ma-ont#hasTargetAudience</seealso>
    let hasTargetAudience = Prefixed_Name(ma_ont, "hasTargetAudience") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:isTargetAudienceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#isTargetAudienceOf">http://www.w3.org/ns/ma-ont#isTargetAudienceOf</seealso>
    let isTargetAudienceOf = Prefixed_Name(ma_ont, "isTargetAudienceOf") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:hasTrack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Corresponds to 'fragment' in the Ontology for Media Resources with a 'fragment.role' meaning "track".</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#hasTrack">http://www.w3.org/ns/ma-ont#hasTrack</seealso>
    let hasTrack = Prefixed_Name(ma_ont, "hasTrack") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:isTrackOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#isTrackOf">http://www.w3.org/ns/ma-ont#isTrackOf</seealso>
    let isTrackOf = Prefixed_Name(ma_ont, "isTrackOf") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:isProvidedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Corresponds to 'rating.identifier' in the Ontology for Media Resources.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#isProvidedBy">http://www.w3.org/ns/ma-ont#isProvidedBy</seealso>
    let isProvidedBy = Prefixed_Name(ma_ont, "isProvidedBy") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:provides</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#provides">http://www.w3.org/ns/ma-ont#provides</seealso>
    let provides = Prefixed_Name(ma_ont, "provides") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:locationAltitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Corresponds to 'location.altitude' in the Ontology for Media Resources.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#locationAltitude">http://www.w3.org/ns/ma-ont#locationAltitude</seealso>
    let locationAltitude = Prefixed_Name(ma_ont, "locationAltitude") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:locationLatitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Corresponds to 'location.latitude' in the Ontology for Media Resources.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#locationLatitude">http://www.w3.org/ns/ma-ont#locationLatitude</seealso>
    let locationLatitude = Prefixed_Name(ma_ont, "locationLatitude") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:locator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Corresponds to 'locator' in the Ontology for Media Resources.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#locator">http://www.w3.org/ns/ma-ont#locator</seealso>
    let locator = Prefixed_Name(ma_ont, "locator") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:mainOriginalTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Corresponds to 'title.title' in the Ontology for Media Resources with a 'title.type' meaning "original".</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#mainOriginalTitle">http://www.w3.org/ns/ma-ont#mainOriginalTitle</seealso>
    let mainOriginalTitle = Prefixed_Name(ma_ont, "mainOriginalTitle") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:numberOfTracks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Corresponds to 'numTracks.number' in the Ontology for Media Resources. Subproperties can be used to distinguish different values of 'numTracks.type'.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#numberOfTracks">http://www.w3.org/ns/ma-ont#numberOfTracks</seealso>
    let numberOfTracks = Prefixed_Name(ma_ont, "numberOfTracks") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:ratingValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Corresponds to 'rating.value' in the Ontology for Media Resources.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#ratingValue">http://www.w3.org/ns/ma-ont#ratingValue</seealso>
    let ratingValue = Prefixed_Name(ma_ont, "ratingValue") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:recordDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Corresponds to 'date.date' in the Ontology for Media Resources with a 'date.type' meaning "recordDate".</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#recordDate">http://www.w3.org/ns/ma-ont#recordDate</seealso>
    let recordDate = Prefixed_Name(ma_ont, "recordDate") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:releaseDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Corresponds to 'date.date' in the Ontology for Media Resources with a 'date.type' meaning "releaseDate".</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#releaseDate">http://www.w3.org/ns/ma-ont#releaseDate</seealso>
    let releaseDate = Prefixed_Name(ma_ont, "releaseDate") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:samplingRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Corresponds to 'samplingRate' in the Ontology for Media Resources, in samples per second.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#samplingRate">http://www.w3.org/ns/ma-ont#samplingRate</seealso>
    let samplingRate = Prefixed_Name(ma_ont, "samplingRate") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:copyright</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Corresponds to 'copyright.copyright' in the Ontology for Media Resources.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#copyright">http://www.w3.org/ns/ma-ont#copyright</seealso>
    let copyright = Prefixed_Name(ma_ont, "copyright") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Corresponds to 'description' in the Ontology for Media Resources. This can be specialised by using sub-properties e.g. 'summary' or 'script'.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#description">http://www.w3.org/ns/ma-ont#description</seealso>
    let description = Prefixed_Name(ma_ont, "description") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:creationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Corresponds to 'date.date' in the Ontology for Media Resources with a 'date.type' meaning "creationDate".</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#creationDate">http://www.w3.org/ns/ma-ont#creationDate</seealso>
    let creationDate = Prefixed_Name(ma_ont, "creationDate") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:hasRelatedLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Corresponds to 'location' in the Ontology for Media Resources. Subproperties are provided to specify, when possible, the relation between the media resource and the location.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#hasRelatedLocation">http://www.w3.org/ns/ma-ont#hasRelatedLocation</seealso>
    let hasRelatedLocation = Prefixed_Name(ma_ont, "hasRelatedLocation") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:editDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Corresponds to 'date.date' in the Ontology for Media Resources with a 'date.type' meaning "editDate".</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#editDate">http://www.w3.org/ns/ma-ont#editDate</seealso>
    let editDate = Prefixed_Name(ma_ont, "editDate") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:playsIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#playsIn">http://www.w3.org/ns/ma-ont#playsIn</seealso>
    let playsIn = Prefixed_Name(ma_ont, "playsIn") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:fragmentName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Corresponds to 'namedFragment.label' in the Ontology for Media Resources.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#fragmentName">http://www.w3.org/ns/ma-ont#fragmentName</seealso>
    let fragmentName = Prefixed_Name(ma_ont, "fragmentName") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Corresponds to date.date in the ontology for Media Resources. Subproperties can be used to distinguish different values of 'date.type'. The recommended range is 'xsd:dateTime' (for compliance with OWL2-QL and OWL2-RL) but other time-related datatypes may be used (e.g. 'xsd:gYear', 'xsd:date'...).</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#date">http://www.w3.org/ns/ma-ont#date</seealso>
    let date = Prefixed_Name(ma_ont, "date") |> PrefixedName

    /// <summary>
    ///   <para>ma-ont:isFictionalLocationDepictedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#isFictionalLocationDepictedIn">http://www.w3.org/ns/ma-ont#isFictionalLocationDepictedIn</seealso>
    let isFictionalLocationDepictedIn =
        Prefixed_Name(ma_ont, "isFictionalLocationDepictedIn") |> PrefixedName

    /// <summary>
    ///   <para>ma-ont:frameHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Corresponds to 'frameSize.height' in the Ontology for Media Resources, measured in frameSizeUnit.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#frameHeight">http://www.w3.org/ns/ma-ont#frameHeight</seealso>
    let frameHeight = Prefixed_Name(ma_ont, "frameHeight") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:hasPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Corresponds to 'policy' in the Ontology for Media Resources. Subproperties can be used to distinguish different values of 'policy.type'.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#hasPolicy">http://www.w3.org/ns/ma-ont#hasPolicy</seealso>
    let hasPolicy = Prefixed_Name(ma_ont, "hasPolicy") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:frameSizeUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Corresponds to 'frameSize.unit' in the Ontology for Media Resources.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#frameSizeUnit">http://www.w3.org/ns/ma-ont#frameSizeUnit</seealso>
    let frameSizeUnit = Prefixed_Name(ma_ont, "frameSizeUnit") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:hasCaptioning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Corresponds to 'fragment' in the Ontology for Media Resources with a 'fragment.role' meaning "captioning". This property can for example point to a spatial fragment, a VideoTrack or a DataTrack. The language of the captioning track can be expressed by attaching a 'hasLanguage' property to the specific track.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#hasCaptioning">http://www.w3.org/ns/ma-ont#hasCaptioning</seealso>
    let hasCaptioning = Prefixed_Name(ma_ont, "hasCaptioning") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:isChapterOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#isChapterOf">http://www.w3.org/ns/ma-ont#isChapterOf</seealso>
    let isChapterOf = Prefixed_Name(ma_ont, "isChapterOf") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:hasContributedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#hasContributedTo">http://www.w3.org/ns/ma-ont#hasContributedTo</seealso>
    let hasContributedTo = Prefixed_Name(ma_ont, "hasContributedTo") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:hasCreated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#hasCreated">http://www.w3.org/ns/ma-ont#hasCreated</seealso>
    let hasCreated = Prefixed_Name(ma_ont, "hasCreated") |> PrefixedName

    /// <summary>
    ///   <para>ma-ont:hasAudioDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Corresponds to 'fragment' in the Ontology for Media Resources with a 'fragment.role' meaning "audio-description".</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#hasAudioDescription">http://www.w3.org/ns/ma-ont#hasAudioDescription</seealso>
    let hasAudioDescription =
        Prefixed_Name(ma_ont, "hasAudioDescription") |> PrefixedName

    /// <summary>
    ///   <para>ma-ont:hasClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Corresponds to 'targetAudience.classification' in the Ontology for Media Resources. This property is used to provide a value characterising the target audience.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#hasClassification">http://www.w3.org/ns/ma-ont#hasClassification</seealso>
    let hasClassification = Prefixed_Name(ma_ont, "hasClassification") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:hasCopyrightOver</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#hasCopyrightOver">http://www.w3.org/ns/ma-ont#hasCopyrightOver</seealso>
    let hasCopyrightOver = Prefixed_Name(ma_ont, "hasCopyrightOver") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:isFragmentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#isFragmentOf">http://www.w3.org/ns/ma-ont#isFragmentOf</seealso>
    let isFragmentOf = Prefixed_Name(ma_ont, "isFragmentOf") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:hasKeyword</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Corresponds to 'keyword' in the Ontology for Media Resources.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#hasKeyword">http://www.w3.org/ns/ma-ont#hasKeyword</seealso>
    let hasKeyword = Prefixed_Name(ma_ont, "hasKeyword") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:hasMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#hasMember">http://www.w3.org/ns/ma-ont#hasMember</seealso>
    let hasMember = Prefixed_Name(ma_ont, "hasMember") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:hasNamedFragment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Corresponds to 'namedFragment' in the Ontology for Media Resources.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#hasNamedFragment">http://www.w3.org/ns/ma-ont#hasNamedFragment</seealso>
    let hasNamedFragment = Prefixed_Name(ma_ont, "hasNamedFragment") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:hasRating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Corresponds to 'rating' in the Ontology for Media Resources.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#hasRating">http://www.w3.org/ns/ma-ont#hasRating</seealso>
    let hasRating = Prefixed_Name(ma_ont, "hasRating") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:isRatingOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#isRatingOf">http://www.w3.org/ns/ma-ont#isRatingOf</seealso>
    let isRatingOf = Prefixed_Name(ma_ont, "isRatingOf") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:hasRatingSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Corresponds to 'rating.type' in the Ontology for Media Resources.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#hasRatingSystem">http://www.w3.org/ns/ma-ont#hasRatingSystem</seealso>
    let hasRatingSystem = Prefixed_Name(ma_ont, "hasRatingSystem") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:isRelatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#isRelatedTo">http://www.w3.org/ns/ma-ont#isRelatedTo</seealso>
    let isRelatedTo = Prefixed_Name(ma_ont, "isRelatedTo") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:hasSigning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Corresponds to 'fragment' in the Ontology for Media Resources with a 'fragment.role' meaning "signing". This property can for example point to a spatial fragment or a VideoTrack. The sign language of the captioning track can be expressed by attaching a 'hasLanguage' property to the specific track.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#hasSigning">http://www.w3.org/ns/ma-ont#hasSigning</seealso>
    let hasSigning = Prefixed_Name(ma_ont, "hasSigning") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:isSigningOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#isSigningOf">http://www.w3.org/ns/ma-ont#isSigningOf</seealso>
    let isSigningOf = Prefixed_Name(ma_ont, "isSigningOf") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:hasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Corresponds to 'relation' and in the Ontology for Media Resources with a 'relation.type' meaning "source".</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#hasSource">http://www.w3.org/ns/ma-ont#hasSource</seealso>
    let hasSource = Prefixed_Name(ma_ont, "hasSource") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:hasCreator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Corresponds to 'creator.creator' in the Ontology for Media Resources. Subproperties can be used to distinguish different values of 'creator.role'. Note that this property is semantically a subproperty of 'hasContributor'.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#hasCreator">http://www.w3.org/ns/ma-ont#hasCreator</seealso>
    let hasCreator = Prefixed_Name(ma_ont, "hasCreator") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:hasPermissions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Corresponds to 'policy' in the Ontology for Media Resources with a  'policy.type' meaning "permissions".</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#hasPermissions">http://www.w3.org/ns/ma-ont#hasPermissions</seealso>
    let hasPermissions = Prefixed_Name(ma_ont, "hasPermissions") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:hasGenre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Corresponds to 'genre' in the Ontology for Media Resources.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#hasGenre">http://www.w3.org/ns/ma-ont#hasGenre</seealso>
    let hasGenre = Prefixed_Name(ma_ont, "hasGenre") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:isNamedFragmentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#isNamedFragmentOf">http://www.w3.org/ns/ma-ont#isNamedFragmentOf</seealso>
    let isNamedFragmentOf = Prefixed_Name(ma_ont, "isNamedFragmentOf") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:isSourceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#isSourceOf">http://www.w3.org/ns/ma-ont#isSourceOf</seealso>
    let isSourceOf = Prefixed_Name(ma_ont, "isSourceOf") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:isMemberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Corresponds to 'collection' in the Ontology for Media Resources.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#isMemberOf">http://www.w3.org/ns/ma-ont#isMemberOf</seealso>
    let isMemberOf = Prefixed_Name(ma_ont, "isMemberOf") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:locationLongitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Corresponds to 'location.longitude' in the Ontology for Media Resources.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#locationLongitude">http://www.w3.org/ns/ma-ont#locationLongitude</seealso>
    let locationLongitude = Prefixed_Name(ma_ont, "locationLongitude") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:locationName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Corresponds to 'location.name' in the Ontology for Media Resources.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#locationName">http://www.w3.org/ns/ma-ont#locationName</seealso>
    let locationName = Prefixed_Name(ma_ont, "locationName") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:ratingScaleMax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Corresponds to 'rating.max' in the Ontology for Media Resources.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#ratingScaleMax">http://www.w3.org/ns/ma-ont#ratingScaleMax</seealso>
    let ratingScaleMax = Prefixed_Name(ma_ont, "ratingScaleMax") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:ratingScaleMin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Corresponds to 'rating.min' in the Ontology for Media Resources.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#ratingScaleMin">http://www.w3.org/ns/ma-ont#ratingScaleMin</seealso>
    let ratingScaleMin = Prefixed_Name(ma_ont, "ratingScaleMin") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:trackName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Corresponds to 'fragment.name' in the Ontology for Media Resources, for Track fragments.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#trackName">http://www.w3.org/ns/ma-ont#trackName</seealso>
    let trackName = Prefixed_Name(ma_ont, "trackName") |> PrefixedName
    /// <summary>
    ///   <para>ma-ont:averageBitRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Corresponds to 'averageBitRate' in the Ontology for Media Resources, expressed in kilobits/second.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/ma-ont#averageBitRate">http://www.w3.org/ns/ma-ont#averageBitRate</seealso>
    let averageBitRate = Prefixed_Name(ma_ont, "averageBitRate") |> PrefixedName
