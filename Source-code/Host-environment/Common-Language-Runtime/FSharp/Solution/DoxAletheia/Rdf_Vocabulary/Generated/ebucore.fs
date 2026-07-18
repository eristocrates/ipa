namespace http.www.ebu.ch.metadata.ontologies.ebucore.ebucore.hash

open DoxAletheia.Rdf_Vocabulary

module ebucore =
    let _namespace_name = "http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#"

    /// <summary>
    /// An image, a document, an annotation
    ///             (descriptive textual metadata or audio/video tag), a tag (time related in audiovisual
    ///             media resources), or an audiovisual media resource (optionally composed of one or more
    ///             fragment / part and / or audio, video data tracks). Other types of BusinessObjects may
    ///             be defined as subclasses.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#BusinessObject"></see></summary>
    let BusinessObject =
        Namespaced_IRI.parse _namespace_name "BusinessObject" |> NamespacedName

    /// <summary>
    /// A manifestation of a
    ///             BusinessObject.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Resource"></see></summary>
    let Resource = Namespaced_IRI.parse _namespace_name "Resource" |> NamespacedName
    /// <summary>
    /// The Class "Asset" is an
    ///             object to which an identifier will be associated at commissioning. It will serve as a
    ///             central reference point to manage rights associated to EditorialObjects, Resources,
    ///             MediaResources or Essences, and PublicationEvents (distribution and exploitation
    ///             conditions).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Asset"></see></summary>
    let Asset = Namespaced_IRI.parse _namespace_name "Asset" |> NamespacedName

    /// <summary>
    /// To describe any manifestation of a media
    ///             resource on any media (live, on demand, catch-up TV, etc.) and the appropriate
    ///             PublciationChannel.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#PublicationEvent"></see></summary>
    let PublicationEvent =
        Namespaced_IRI.parse _namespace_name "PublicationEvent" |> NamespacedName

    /// <summary>
    /// Additional types of event shall be defined as
    ///             new sub-classes of event.
    /// An event related to the media resource, e.g.
    ///             depicted in the resource (possibly fictional), etc.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Event"></see></summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName

    /// <summary>
    /// An organisation (business, corporation, federation, etc.) or moral agent (gvernment body).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Organisation"></see></summary>
    let Organisation =
        Namespaced_IRI.parse _namespace_name "Organisation" |> NamespacedName

    /// <summary>
    /// A physical person.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Contact"></see></summary>
    let Contact = Namespaced_IRI.parse _namespace_name "Contact" |> NamespacedName
    /// <summary>
    /// A type of location is defined as a sub-class of
    ///             location.
    /// A location related to the media resource, e.g.
    ///             depicted in the resource (possibly fictional) or where the resource was created
    ///             (shooting location), etc.
    /// This is provided as free text in an annotation
    ///             label or as an identifier pointing to a term in a classification scheme.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Location"></see></summary>
    let Location = Namespaced_IRI.parse _namespace_name "Location" |> NamespacedName
    /// <summary>
    /// To proivde keywords and define key concepts
    ///             illustrating the content of the Resource or EditorialObject. This is provided as free
    ///             text in an annotation label or as an identifier pointing to a term in a classification
    ///             scheme.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Keyword"></see></summary>
    let Keyword = Namespaced_IRI.parse _namespace_name "Keyword" |> NamespacedName

    /// <summary>
    /// The conditions under which content can be accessed.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AccessConditions"></see></summary>
    let AccessConditions =
        Namespaced_IRI.parse _namespace_name "AccessConditions" |> NamespacedName

    /// <summary>
    /// To provide information on the rights, including
    ///             intellectual property, related to a BusinessObject or Resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Rights"></see></summary>
    let Rights = Namespaced_IRI.parse _namespace_name "Rights" |> NamespacedName

    /// <summary>
    /// An Organisation to which a Contact is affiliated (with period of validity).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Affiliation"></see></summary>
    let Affiliation =
        Namespaced_IRI.parse _namespace_name "Affiliation" |> NamespacedName

    /// <summary>
    /// A person / contact or organisation.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Agent"></see></summary>
    let Agent = Namespaced_IRI.parse _namespace_name "Agent" |> NamespacedName

    /// <summary>
    /// Any ancillary data provided with the content
    ///             other than captioning and subtitling.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AncillaryData"></see></summary>
    let AncillaryData =
        Namespaced_IRI.parse _namespace_name "AncillaryData" |> NamespacedName

    /// <summary>
    /// Ancillary data track e.g. ¨captioning"
    ///             or "subtitling" in addition to video and audio tracks.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#DataTrack"></see></summary>
    let DataTrack = Namespaced_IRI.parse _namespace_name "DataTrack" |> NamespacedName

    /// <summary>
    /// To define the format of AncillaryData such as
    ///             legacy data used to be carried in vertical blanking intervals. This is provided as free
    ///             text in an annotation label or as an identifier pointing to a term in a classification
    ///             scheme.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AncillaryDataFormat"></see></summary>
    let AncillaryDataFormat =
        Namespaced_IRI.parse _namespace_name "AncillaryDataFormat" |> NamespacedName

    /// <summary>
    /// To provide addtional technical information on
    ///             the characteristics of data streams in a MediaResource including but not limited to
    ///             AncillaryData, Subtilting and Captioning. Additional specific data format may be defined
    ///             as subclasses of DataFormat.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#DataFormat"></see></summary>
    let DataFormat = Namespaced_IRI.parse _namespace_name "DataFormat" |> NamespacedName
    /// <summary>
    /// A set of descriptive or technical metadata.
    ///             Annotation can also be made in the form of a document or media resource such as an or
    ///             video audio file . An annotation can exist on its own and be related / associated to
    ///             other editorial objects or resources.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Annotation"></see></summary>
    let Annotation = Namespaced_IRI.parse _namespace_name "Annotation" |> NamespacedName

    /// <summary>
    /// The audience by which the Resource can be
    ///             seen according to ratings like MPAA  (http://en.wikipedia.org/wiki/Motion_picture_rating_system) or other organisational / national / local standards.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudienceRating"></see></summary>
    let AudienceRating =
        Namespaced_IRI.parse _namespace_name "AudienceRating" |> NamespacedName

    /// <summary>
    /// All the information about the rating/evaluation
    ///             given to a media resource by an Agent i.e. a person/Contact or
    ///             Organisation.
    /// This is provided as free text in an annotation
    ///             label or as an identifier pointing to a term in a classification scheme.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Rating"></see></summary>
    let Rating = Namespaced_IRI.parse _namespace_name "Rating" |> NamespacedName

    /// <summary>
    /// An audioChannel represents a single sequence of audio samples. It
    /// 				is sub-divided in the time domain into audioBlocks, which is must contain at
    /// 				least one of. The typeDefintion of the audioChannel format specifies the type of
    /// 				audio it is describing, and also determines which parameters are used within its
    /// 				audioBlock children.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioChannel"></see></summary>
    let AudioChannel =
        Namespaced_IRI.parse _namespace_name "AudioChannel" |> NamespacedName

    /// <summary>
    /// In some audiovisual standardisation groups,
    ///             Essence is preferred to MediaResource. In also has subclasses well known as MediaObject
    ///             clustered in AudioObjects and VideoObjects.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Essence"></see></summary>
    let Essence = Namespaced_IRI.parse _namespace_name "Essence" |> NamespacedName

    /// <summary>
    /// An audioContent defines one component of a programme (e.g. background
    /// 				music), its association with an audioGroup (e.g. a 2.0 audioPackFormat of
    /// 				audioChannelFormats for stereo reproduction), its association with an
    /// 				audioStreamFormat, and its set of loudness parameters.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioContent"></see></summary>
    let AudioContent =
        Namespaced_IRI.parse _namespace_name "AudioContent" |> NamespacedName

    /// <summary>
    /// A set of one or more audioContent that derive from the same material,
    /// 				i.e. an audioMultiplex, and the definition of its multiplexed audioContents (e.g.
    /// 				foreground and commentary, background music).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioProgramme"></see></summary>
    let AudioProgramme =
        Namespaced_IRI.parse _namespace_name "AudioProgramme" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioDescription"></see>
    /// </summary>
    let AudioDescription =
        Namespaced_IRI.parse _namespace_name "AudioDescription" |> NamespacedName

    /// <summary>
    /// An audioTrack object defines a component of an audioStream.
    /// 				A single set of samples or data in the storage medium.
    /// Represents a physical container or carrier to hold an audio stream. This
    /// 				should be usually defined by many attributes such as ID, format (e.g. 48 kHz/24
    /// 				bits), linkage information (e.g. odd/even)…
    /// An audioTrack is the basic audio data container of a medium. Attribute is
    /// 				an unambiguous reference to this container in a given medium.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioTrack"></see></summary>
    let AudioTrack = Namespaced_IRI.parse _namespace_name "AudioTrack" |> NamespacedName

    /// <summary>
    /// The encoding format for the audio.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioEncodingFormat"></see></summary>
    let AudioEncodingFormat =
        Namespaced_IRI.parse _namespace_name "AudioEncodingFormat" |> NamespacedName

    /// <summary>
    /// To provide a definition of the encoding format
    ///             for audio and video. This is provided as free text in an annotation label or as an
    ///             identifier pointing to a term in a classification scheme e.g.
    ///             http://www.ebu.ch/metadata/ontologies/skos/ebu_AudioCompressionCodeCS.rdf or
    ///             http://www.ebu.ch/metadata/ontologies/skos/ebu_VideoCompressionCodeCS.rdf.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#EncodingFormat"></see></summary>
    let EncodingFormat =
        Namespaced_IRI.parse _namespace_name "EncodingFormat" |> NamespacedName

    /// <summary>
    /// The technical characteristics of an
    ///             AudioResource such as the sampleRate. This is provided as free text in an annotation
    ///             label or as an identifier pointing to a term in a classification scheme e.g.
    ///             http://www.ebu.ch/metadata/ontologies/skos/ebu_AudioFormatCodeCS.rdf.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioFormat"></see></summary>
    let AudioFormat =
        Namespaced_IRI.parse _namespace_name "AudioFormat" |> NamespacedName

    /// <summary>
    /// The format provides technical information on
    ///             the format of a Resource. A BusinessObject can be instantiated in a variety of Resources
    ///             each in a particular Format. Other specific data formats may be defined as subclasses of
    ///             format.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Format"></see></summary>
    let Format = Namespaced_IRI.parse _namespace_name "Format" |> NamespacedName

    /// <summary>
    /// The format of an AudioPack. Examples of audioPackFormats are 'stereo' and '5.1' for channel-based formats.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioPackFormat"></see></summary>
    let AudioPackFormat =
        Namespaced_IRI.parse _namespace_name "AudioPackFormat" |> NamespacedName

    /// <summary>
    /// An EditorialObject corresponding to a
    ///             MediaResource ready for publication.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Programme"></see></summary>
    let Programme = Namespaced_IRI.parse _namespace_name "Programme" |> NamespacedName

    /// <summary>
    /// An audioStreamFormat describes a decodable signal - PCM signal or a Dolby E stream for example. It is composed of one or more AudioTracks.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioStream"></see></summary>
    let AudioStream =
        Namespaced_IRI.parse _namespace_name "AudioStream" |> NamespacedName

    /// <summary>
    /// A continuous stream of bits.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Stream"></see></summary>
    let Stream = Namespaced_IRI.parse _namespace_name "Stream" |> NamespacedName

    /// <summary>
    /// The format of an AudioStream, e.g. PCM_FrontLeft or Dolby E.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioStreamFormat"></see></summary>
    let AudioStreamFormat =
        Namespaced_IRI.parse _namespace_name "AudioStreamFormat" |> NamespacedName

    /// <summary>
    /// Audiovisual content can be composed of audio,
    ///             video and data Tracks (including captioning and subtitling).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Track"></see></summary>
    let Track = Namespaced_IRI.parse _namespace_name "Track" |> NamespacedName

    /// <summary>
    /// The format of an AudioTrack e.g. PCM_FrontLeft.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioTrackFormat"></see></summary>
    let AudioTrackFormat =
        Namespaced_IRI.parse _namespace_name "AudioTrackFormat" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#BibliographicalObject"></see>
    /// </summary>
    let BibliographicalObject =
        Namespaced_IRI.parse _namespace_name "BibliographicalObject" |> NamespacedName

    /// <summary>
    /// A group of EditorialObjects having a Brand as a
    ///             common denominator
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Brand"></see></summary>
    let Brand = Namespaced_IRI.parse _namespace_name "Brand" |> NamespacedName
    /// <summary>
    /// To define a collection / group of media
    ///             resources, for example a series made of episodes.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Group"></see></summary>
    let Group = Namespaced_IRI.parse _namespace_name "Group" |> NamespacedName
    /// <summary>
    /// To signal the presence of hard of hearing
    ///             captioning.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Captioning"></see></summary>
    let Captioning = Namespaced_IRI.parse _namespace_name "Captioning" |> NamespacedName

    /// <summary>
    /// To define the format of captioning.
    ///             Captioning's main use isfor hard of hearing transcription. This is provided as
    ///             free text in an annotation label or as an identifier pointing to a term in a
    ///             classification scheme.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#CaptioningFormat"></see></summary>
    let CaptioningFormat =
        Namespaced_IRI.parse _namespace_name "CaptioningFormat" |> NamespacedName

    /// <summary>
    /// A member of the cast list (a list of performers/actors and associated fictitious
    ///             characters).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Cast"></see></summary>
    let Cast = Namespaced_IRI.parse _namespace_name "Cast" |> NamespacedName
    /// <summary>
    /// E.g. a fictitious contact / person.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Character"></see></summary>
    let Character = Namespaced_IRI.parse _namespace_name "Character" |> NamespacedName

    /// <summary>
    /// Closed captioning is provided as separate
    ///             content.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ClosedCaptions"></see></summary>
    let ClosedCaptions =
        Namespaced_IRI.parse _namespace_name "ClosedCaptions" |> NamespacedName

    /// <summary>
    /// Closed subtitles are provided as separate
    ///             content.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ClosedSubtitling"></see></summary>
    let ClosedSubtitling =
        Namespaced_IRI.parse _namespace_name "ClosedSubtitling" |> NamespacedName

    /// <summary>
    /// To signal the presence of subtitles for
    ///             translation in alternative languages.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Subtitling"></see></summary>
    let Subtitling = Namespaced_IRI.parse _namespace_name "Subtitling" |> NamespacedName
    /// <summary>
    /// To provide information on a codec.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Codec"></see></summary>
    let Codec = Namespaced_IRI.parse _namespace_name "Codec" |> NamespacedName
    /// <summary>
    /// A group of EditorialObjects. There can be many
    ///             types of collections for which specific sub-classes should be defined. In the worl of
    ///             archives, A collection corresponds to all items belonging to an individual /
    ///             collector.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Collection"></see></summary>
    let Collection = Namespaced_IRI.parse _namespace_name "Collection" |> NamespacedName

    /// <summary>
    /// The CoulourSpace of a VideoResource. A
    ///             ColourSpace is defined as free text in an annotation label or as an identifier pointing
    ///             to a term in a classification scheme such as
    ///             http://www.ebu.ch/metadata/ontologies/skos/ebu_ColourCodeCS.rdf.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ColourSpace"></see></summary>
    let ColourSpace =
        Namespaced_IRI.parse _namespace_name "ColourSpace" |> NamespacedName

    /// <summary>
    /// A component e.g. audio, video, data or else or a MediaResource or Essence.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Component"></see></summary>
    let Component = Namespaced_IRI.parse _namespace_name "Component" |> NamespacedName

    /// <summary>
    /// The container or wrapper format used to package
    ///             audio, video and data components of a Mediaresource. The format is defined as free text
    ///             or pointing at a term in a classification scheme e.g.
    ///             http://www.ebu.ch/metadata/ontologies/skos/ebu_ContainerFormatCS.rdf.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ContainerFormat"></see></summary>
    let ContainerFormat =
        Namespaced_IRI.parse _namespace_name "ContainerFormat" |> NamespacedName

    /// <summary>
    /// The definition of the container if available as
    ///             a MIME type. This is provided as free text in an annotation label or as an identifier
    ///             pointing to a term in a classification scheme. For more information:
    ///             http://www.iana.org/assignments/media-types/application/index.html.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ContainerMimeType"></see></summary>
    let ContainerMimeType =
        Namespaced_IRI.parse _namespace_name "ContainerMimeType" |> NamespacedName

    /// <summary>
    /// To provide a copyright
    ///             statement.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Copyright"></see></summary>
    let Copyright = Namespaced_IRI.parse _namespace_name "Copyright" |> NamespacedName

    /// <summary>
    /// To provide information on possible restrictions
    ///             regarding the temporal and spatial coverage for publication.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#CoverageRestrictions"></see></summary>
    let CoverageRestrictions =
        Namespaced_IRI.parse _namespace_name "CoverageRestrictions" |> NamespacedName

    /// <summary>
    /// Crew member.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Crew"></see></summary>
    let Crew = Namespaced_IRI.parse _namespace_name "Crew" |> NamespacedName
    /// <summary>
    /// The Data Identifier word (along with the SDID,
    ///             if used), indicates the type of ancillary data that the packet corresponds
    ///             to.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#DID"></see></summary>
    let DID = Namespaced_IRI.parse _namespace_name "DID" |> NamespacedName
    /// <summary>
    /// A department within and
    ///             organisation.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Department"></see></summary>
    let Department = Namespaced_IRI.parse _namespace_name "Department" |> NamespacedName

    /// <summary>
    /// A DepictedEVent is fictitious or historical or
    ///             other sort of Event that the content of the BusinessObject or resource relates
    ///             to.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#DepictedEvent"></see></summary>
    let DepictedEvent =
        Namespaced_IRI.parse _namespace_name "DepictedEvent" |> NamespacedName

    /// <summary>
    /// To provide a disclaimer of any
    ///             form.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Disclaimer"></see></summary>
    let Disclaimer = Namespaced_IRI.parse _namespace_name "Disclaimer" |> NamespacedName
    /// <summary>
    /// To describe a publication in the form of a
    ///             document e.g. a html webpage (news item) or a pdf document e.g. a script.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Document"></see></summary>
    let Document = Namespaced_IRI.parse _namespace_name "Document" |> NamespacedName

    /// <summary>
    /// To provide technical information about the
    ///             format of a document such as the orientation. This is provided as free text in an
    ///             annotation label or as an identifier pointing to a term in a classification
    ///             scheme.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#DocumentFormat"></see></summary>
    let DocumentFormat =
        Namespaced_IRI.parse _namespace_name "DocumentFormat" |> NamespacedName

    /// <summary>
    /// Provides additional information about a NewsItem, e.g. date and place, subject.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Dopesheet"></see></summary>
    let Dopesheet = Namespaced_IRI.parse _namespace_name "Dopesheet" |> NamespacedName

    /// <summary>
    /// In the audiovisual domain, the Class
    ///             EditorialObject transforms a commissioned concept into an editorial definition of a
    ///             MediaResource before fabrication (in the Production Domain) and Distribution (in the
    ///             Distribution Domain). An EditorialObject is a set of descriptive metadata summarising
    ///             e.g. editing decisions. An EditorialObject can also be a part of an EditorialObject,
    ///             which is defined by its start time and duration. An EditorialObject can also be a group
    ///             of EditorialObjects. For example a series composed of episodes is defined as an
    ///             EditorialObject.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#EditorialObject"></see></summary>
    let EditorialObject =
        Namespaced_IRI.parse _namespace_name "EditorialObject" |> NamespacedName

    /// <summary>
    /// The use of MediaResource is reserved to
    ///             audiovisual content.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#MediaResource"></see></summary>
    let MediaResource =
        Namespaced_IRI.parse _namespace_name "MediaResource" |> NamespacedName

    /// <summary>
    /// To highlight potential exploitation
    ///             issues.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ExploitationIssues"></see></summary>
    let ExploitationIssues =
        Namespaced_IRI.parse _namespace_name "ExploitationIssues" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Feature"></see>
    /// </summary>
    let Feature = Namespaced_IRI.parse _namespace_name "Feature" |> NamespacedName
    /// <summary>
    /// A file format for Resources other than
    ///             audiovisual resources. The format is defined as free text or pointing at a term in a
    ///             classification scheme e.g.
    ///             http://www.ebu.ch/metadata/ontologies/skos/ebu_FileFormatCS.rdf.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#FileFormat"></see></summary>
    let FileFormat = Namespaced_IRI.parse _namespace_name "FileFormat" |> NamespacedName
    /// <summary>
    /// Identifies the generation of a version of a resource, i.e. master, edit master, distribution copy, etc.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Generation"></see></summary>
    let Generation = Namespaced_IRI.parse _namespace_name "Generation" |> NamespacedName
    /// <summary>
    /// This class shall be used to provide information
    ///             on the genre of the BusinessObject or Resource. This is provided as free text in an
    ///             annotation label or as an identifier pointing to a term in a classification scheme e.g.
    ///             http://www.ebu.ch/metadata/ontologies/skos/ebu_ContentGenreCS.rdf or
    ///             http://www.ebu.ch/metadata/ontologies/skos/ebu_EditorialFormatCodeCS.rdf.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Genre"></see></summary>
    let Genre = Namespaced_IRI.parse _namespace_name "Genre" |> NamespacedName
    /// <summary>
    /// An expression of type in textual form or as a term from a classification scheme.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Type"></see></summary>
    let Type = Namespaced_IRI.parse _namespace_name "Type" |> NamespacedName

    /// <summary>
    /// To provide information on intellectual
    ///             property.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#IPRRestrictions"></see></summary>
    let IPRRestrictions =
        Namespaced_IRI.parse _namespace_name "IPRRestrictions" |> NamespacedName

    /// <summary>
    /// A still image / thumbnail / key frame / logo
    ///             related to the media resource or being the media resource itself
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Image"></see></summary>
    let Image = Namespaced_IRI.parse _namespace_name "Image" |> NamespacedName

    /// <summary>
    /// To provide technical information about the
    ///             format of an image such as the orientation. This is provided as free text in an
    ///             annotation label or as an identifier pointing to a term in a classification
    ///             scheme.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ImageFormat"></see></summary>
    let ImageFormat =
        Namespaced_IRI.parse _namespace_name "ImageFormat" |> NamespacedName

    /// <summary>
    /// An item e.g. newsItem or sportItem
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Item"></see></summary>
    let Item = Namespaced_IRI.parse _namespace_name "Item" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#KeyCareerEvent"></see>
    /// </summary>
    let KeyCareerEvent =
        Namespaced_IRI.parse _namespace_name "KeyCareerEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#KeyEvent"></see>
    /// </summary>
    let KeyEvent = Namespaced_IRI.parse _namespace_name "KeyEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#KeyPersonalEvent"></see>
    /// </summary>
    let KeyPersonalEvent =
        Namespaced_IRI.parse _namespace_name "KeyPersonalEvent" |> NamespacedName

    /// <summary>
    /// A key frame is a frame extarcted from video,
    ///             e.g. representative of a part of a MediaResource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Keyframe"></see></summary>
    let Keyframe = Namespaced_IRI.parse _namespace_name "Keyframe" |> NamespacedName
    /// <summary>
    /// A photography, a logo, a pictogram, etc.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Picture"></see></summary>
    let Picture = Namespaced_IRI.parse _namespace_name "Picture" |> NamespacedName
    /// <summary>
    /// To provide information on languages present in
    ///             the BusinessObject and its purpose. This is provided as free text in an annotation label
    ///             or as an identifier pointing to a term in a classification scheme.Other language
    ///             specific types may be added as subclasses of language.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Language"></see></summary>
    let Language = Namespaced_IRI.parse _namespace_name "Language" |> NamespacedName
    /// <summary>
    /// A Logo allows to visually identify an
    ///             organisation, publicationService, publicationChannel, or ratings /
    ///             parentalGuidance
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Logo"></see></summary>
    let Logo = Namespaced_IRI.parse _namespace_name "Logo" |> NamespacedName

    /// <summary>
    /// A MediaFragment is a temporal or spatial segment of a resource identified by a MediaGragment URI (http://www.w3.org/2008/WebVideo/Fragments/WD-media-fragments-spec/).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#MediaFragment"></see></summary>
    let MediaFragment =
        Namespaced_IRI.parse _namespace_name "MediaFragment" |> NamespacedName

    /// <summary>
    /// To provide information on the medium formats in
    ///             which the resource is available. This is provided as free text in an annotation label or
    ///             as an identifier pointing to a term in a classification scheme.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Medium"></see></summary>
    let Medium = Namespaced_IRI.parse _namespace_name "Medium" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#MetadataTrack"></see>
    /// </summary>
    let MetadataTrack =
        Namespaced_IRI.parse _namespace_name "MetadataTrack" |> NamespacedName

    /// <summary>
    /// The definition of the container if available as
    ///             a MIME type. This is provided as free text in an annotation label or as an identifier
    ///             pointing to a term in a classification scheme. For more information:
    ///             http://www.iana.org/assignments/media-types/index.html.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#MimeType"></see></summary>
    let MimeType = Namespaced_IRI.parse _namespace_name "MimeType" |> NamespacedName
    /// <summary>
    /// A NewsItem aggregates all information about a particular news event.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#NewsItem"></see></summary>
    let NewsItem = Namespaced_IRI.parse _namespace_name "NewsItem" |> NamespacedName
    /// <summary>
    /// To specify the type of BusinessObject e.g. and
    ///             EditorialObject of type "programme" or clip". This is
    ///             provided as free text in an annotation label or as an identifier pointing to a term in a
    ///             classification scheme e.g.
    ///             http://www.ebu.ch/metadata/ontologies/skos/ebu_ObjectTypeCodeCS.rdf.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ObjectType"></see></summary>
    let ObjectType = Namespaced_IRI.parse _namespace_name "ObjectType" |> NamespacedName

    /// <summary>
    /// Open Captions are burned in the
    ///             image.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#OpenCaptions"></see></summary>
    let OpenCaptions =
        Namespaced_IRI.parse _namespace_name "OpenCaptions" |> NamespacedName

    /// <summary>
    /// Open subtitles are burned in the
    ///             image.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#OpenSubtitling"></see></summary>
    let OpenSubtitling =
        Namespaced_IRI.parse _namespace_name "OpenSubtitling" |> NamespacedName

    /// <summary>
    /// The original language in which the
    ///             BusinessObject or Resource has been created and released. This is provided as free text
    ///             in an annotation label or as an identifier pointing to a term in a classification
    ///             scheme.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#OriginalLanguage"></see></summary>
    let OriginalLanguage =
        Namespaced_IRI.parse _namespace_name "OriginalLanguage" |> NamespacedName

    /// <summary>
    /// One of more media fragment (audio, video, data)
    ///             composing an audiovisual media resource. In other ontolgies fragment is often referred
    ///             to e.g. as a 'part' or 'segment' or
    ///             'fragment'.
    /// A Fragment is a particular section of a
    ///             MediaResource identified by a start and end time or duration. Fragment can also be
    ///             called segment or part.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Part"></see></summary>
    let Part = Namespaced_IRI.parse _namespace_name "Part" |> NamespacedName
    /// <summary>
    /// A visual / graphical representation of a concept.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Pictogram"></see></summary>
    let Pictogram = Namespaced_IRI.parse _namespace_name "Pictogram" |> NamespacedName

    /// <summary>
    /// The name of the channel through which a
    ///             Resource has been published as a PublicationEvent. A PublicationChannel can use a
    ///             variety of medias e.g. broadcast or online.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#PublicationChannel"></see></summary>
    let PublicationChannel =
        Namespaced_IRI.parse _namespace_name "PublicationChannel" |> NamespacedName

    /// <summary>
    /// A collection of PublicationEvents through which
    ///             a resource has been published.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#PublicationHistory"></see></summary>
    let PublicationHistory =
        Namespaced_IRI.parse _namespace_name "PublicationHistory" |> NamespacedName

    /// <summary>
    /// A collection of PublicationEvents organised as a PublicationPlanning.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#PublicationPlanning"></see></summary>
    let PublicationPlanning =
        Namespaced_IRI.parse _namespace_name "PublicationPlanning" |> NamespacedName

    /// <summary>
    /// A programme for distribution on radio
    ///             channels.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#RadioProgramme"></see></summary>
    let RadioProgramme =
        Namespaced_IRI.parse _namespace_name "RadioProgramme" |> NamespacedName

    /// <summary>
    /// To signal that rights have been cleared (or
    ///             not)
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#RightsClearance"></see></summary>
    let RightsClearance =
        Namespaced_IRI.parse _namespace_name "RightsClearance" |> NamespacedName

    /// <summary>
    /// To define the role / action of an agent. This
    ///             is provided as free text in an annotation label or as an identifier pointing to a term
    ///             in a classification scheme.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Role"></see></summary>
    let Role = Namespaced_IRI.parse _namespace_name "Role" |> NamespacedName
    /// <summary>
    /// Secondary data identification word for
    ///             ancillary data. Send mode identifier. An identifier which indicates the transmission
    ///             timing for closed caption data.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#SDID"></see></summary>
    let SDID = Namespaced_IRI.parse _namespace_name "SDID" |> NamespacedName
    /// <summary>
    /// A series can be composed of one or more seasons
    ///             clustering a certain number of episodes. Fro this reason, seasons are related to series
    ///             using the isRelatedTo property.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Season"></see></summary>
    let Season = Namespaced_IRI.parse _namespace_name "Season" |> NamespacedName
    /// <summary>
    /// Series is a particular type of collection. TV
    ///             or Radio Series are composed of Episodes.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Series"></see></summary>
    let Series = Namespaced_IRI.parse _namespace_name "Series" |> NamespacedName
    /// <summary>
    /// A service is the umbrella under which one or
    ///             more PublicationChannel is operated.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Service"></see></summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName
    /// <summary>
    /// To signal the presence of Signing for hard of
    ///             hearing users. The type of Signing (e.g. incursted in or else) or language of Signing
    ///             can be specified using the appropriate properties.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Signing"></see></summary>
    let Signing = Namespaced_IRI.parse _namespace_name "Signing" |> NamespacedName
    /// <summary>
    /// A specialisation of Track for Video to provide
    ///             a link to specific data properties such as frameRate, etc. Signing is another possible
    ///             example of video track. Specific VideoTracks such as Signing can be defined as sub
    ///             VideoTracks.. In advanced systems, different VideoTracks can be used to provide e.g.
    ///             different viewing angles.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#VideoTrack"></see></summary>
    let VideoTrack = Namespaced_IRI.parse _namespace_name "VideoTrack" |> NamespacedName

    /// <summary>
    /// To provide additional information on the
    ///             signing format. This is provided as free text in an annotation label or as an identifier
    ///             pointing to a term in a classification scheme.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#SigningFormat"></see></summary>
    let SigningFormat =
        Namespaced_IRI.parse _namespace_name "SigningFormat" |> NamespacedName

    /// <summary>
    /// To provide additional technical information
    ///             about a video resource such as the frame rate. This is provided as free text in an
    ///             annotation label or as an identifier pointing to a term in a classification
    ///             scheme.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#VideoFormat"></see></summary>
    let VideoFormat =
        Namespaced_IRI.parse _namespace_name "VideoFormat" |> NamespacedName

    /// <summary>
    /// A SportItem aggregates all information about a sport event.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#SportItem"></see></summary>
    let SportItem = Namespaced_IRI.parse _namespace_name "SportItem" |> NamespacedName
    /// <summary>
    /// Staff member.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Staff"></see></summary>
    let Staff = Namespaced_IRI.parse _namespace_name "Staff" |> NamespacedName
    /// <summary>
    /// identifies the technical video standard of a resource, i.e. NTSC or PAL.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Standard"></see></summary>
    let Standard = Namespaced_IRI.parse _namespace_name "Standard" |> NamespacedName

    /// <summary>
    /// The type of storage used for the repository.
    ///             This is provided as free text in an annotation label or as an identifier pointing to a
    ///             term in a classification scheme.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#StorageType"></see></summary>
    let StorageType =
        Namespaced_IRI.parse _namespace_name "StorageType" |> NamespacedName

    /// <summary>
    /// A term describing the topic covered by the
    ///             BusinessObject or resource. This is provided as free text in an annotation label or as
    ///             an identifier pointing to a term in a classification scheme.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Subject"></see></summary>
    let Subject = Namespaced_IRI.parse _namespace_name "Subject" |> NamespacedName

    /// <summary>
    /// To define the format of subtitling.
    ///             subtitling's main use isfor translation. This is provided as free text in an
    ///             annotation label  or as an identifier pointing to a term in a classification
    ///             scheme.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#SubtitlingFormat"></see></summary>
    let SubtitlingFormat =
        Namespaced_IRI.parse _namespace_name "SubtitlingFormat" |> NamespacedName

    /// <summary>
    /// A programme for distribution on television
    ///             channels.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#TVProgramme"></see></summary>
    let TVProgramme =
        Namespaced_IRI.parse _namespace_name "TVProgramme" |> NamespacedName

    /// <summary>
    /// An annotation specific to a particular
    ///             timestamp in audiovisual MediaResources.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Tag"></see></summary>
    let Tag = Namespaced_IRI.parse _namespace_name "Tag" |> NamespacedName
    /// <summary>
    /// A thumbnail is a low resolution picture that
    ///             can be associated with EditorialObjects or e.g. MediaResources or
    ///             Contacts.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Thumbnail"></see></summary>
    let Thumbnail = Namespaced_IRI.parse _namespace_name "Thumbnail" |> NamespacedName

    /// <summary>
    /// A track with timecode information.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#TimecodeTrack"></see></summary>
    let TimecodeTrack =
        Namespaced_IRI.parse _namespace_name "TimecodeTrack" |> NamespacedName

    /// <summary>
    /// A type subject for use in some contexts. This
    ///             is provided as free text in an annotation label or as an identifier pointing to a term
    ///             in a classification scheme.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Topic"></see></summary>
    let Topic = Namespaced_IRI.parse _namespace_name "Topic" |> NamespacedName

    /// <summary>
    /// Usage rights associated with content.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#UsageRights"></see></summary>
    let UsageRights =
        Namespaced_IRI.parse _namespace_name "UsageRights" |> NamespacedName

    /// <summary>
    /// The encoding format of the video.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#VideoEncodingFormat"></see></summary>
    let VideoEncodingFormat =
        Namespaced_IRI.parse _namespace_name "VideoEncodingFormat" |> NamespacedName

    /// <summary>
    /// A decodable video stream of bits.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#VideoStream"></see></summary>
    let VideoStream =
        Namespaced_IRI.parse _namespace_name "VideoStream" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#YouTubeVideo"></see>
    /// </summary>
    let YouTubeVideo =
        Namespaced_IRI.parse _namespace_name "YouTubeVideo" |> NamespacedName

    /// <summary>
    /// A shorter version of the title.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#abridgedTitle"></see></summary>
    let abridgedTitle =
        Namespaced_IRI.parse _namespace_name "abridgedTitle" |> NamespacedName

    /// <summary>
    /// To provide an alternative title.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#alternativeTitle"></see></summary>
    let alternativeTitle =
        Namespaced_IRI.parse _namespace_name "alternativeTitle" |> NamespacedName

    /// <summary>
    /// To provide a brief summary.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#abstract"></see></summary>
    let abstract_ = Namespaced_IRI.parse _namespace_name "abstract" |> NamespacedName

    /// <summary>
    /// This can be specialised by using sub-properties
    ///             like defined in http://www.ebu.ch/metadata/cs/web/ebu_DescriptionTypeCodeCS_p.xml.htm
    ///             implemented as examples as e.g. 'summary' or
    ///             'script'.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#description"></see></summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#adultContent"></see>
    /// </summary>
    let adultContent =
        Namespaced_IRI.parse _namespace_name "adultContent" |> NamespacedName

    /// <summary>
    /// The date when a Contact left an Organisation
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#affiliationEndDate"></see></summary>
    let affiliationEndDate =
        Namespaced_IRI.parse _namespace_name "affiliationEndDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#affiliationStartDate"></see>
    /// </summary>
    let affiliationStartDate =
        Namespaced_IRI.parse _namespace_name "affiliationStartDate" |> NamespacedName

    /// <summary>
    /// To provide the address of an Agent
    ///             (Contact/person or organisation).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentAddress"></see></summary>
    let agentAddress =
        Namespaced_IRI.parse _namespace_name "agentAddress" |> NamespacedName

    /// <summary>
    /// The age of a Contact/Person
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentAge"></see></summary>
    let agentAge = Namespaced_IRI.parse _namespace_name "agentAge" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentCountryOfResidence"></see>
    /// </summary>
    let agentCountryOfResidence =
        Namespaced_IRI.parse _namespace_name "agentCountryOfResidence" |> NamespacedName

    /// <summary>
    /// To provide the email address of an agent
    ///             (Contact/person or organisation).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentEmailAddress"></see></summary>
    let agentEmailAddress =
        Namespaced_IRI.parse _namespace_name "agentEmailAddress" |> NamespacedName

    /// <summary>
    /// To provide the mobile telephone number of an
    ///             Agent (Contact/person or organisation)
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentMobileTelephoneNumber"></see></summary>
    let agentMobileTelephoneNumber =
        Namespaced_IRI.parse _namespace_name "agentMobileTelephoneNumber" |> NamespacedName

    /// <summary>
    /// To provide the full name of Contact/person - family and given name.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentName"></see></summary>
    let agentName = Namespaced_IRI.parse _namespace_name "agentName" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentNationality"></see>
    /// </summary>
    let agentNationality =
        Namespaced_IRI.parse _namespace_name "agentNationality" |> NamespacedName

    /// <summary>
    /// To provide a nickname of a Contact/person.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentNickname"></see></summary>
    let agentNickname =
        Namespaced_IRI.parse _namespace_name "agentNickname" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentPictureIdLocator"></see>
    /// </summary>
    let agentPictureIdLocator =
        Namespaced_IRI.parse _namespace_name "agentPictureIdLocator" |> NamespacedName

    /// <summary>
    /// A locator from where the Resource can be accessed.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locator"></see></summary>
    let locator = Namespaced_IRI.parse _namespace_name "locator" |> NamespacedName

    /// <summary>
    /// To provide the telephone number of an Agent
    ///             (Contact/person or Organisation).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentTelephoneNumber"></see></summary>
    let agentTelephoneNumber =
        Namespaced_IRI.parse _namespace_name "agentTelephoneNumber" |> NamespacedName

    /// <summary>
    /// To provide the address of the webpage of an
    ///             Agent (Contact/person or Organisation).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentWebHomepage"></see></summary>
    let agentWebHomepage =
        Namespaced_IRI.parse _namespace_name "agentWebHomepage" |> NamespacedName

    /// <summary>
    /// To define the Location (e.g. country, region) to which Rating and TargetAudience do NOT apply.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#appliesOutOf"></see></summary>
    let appliesOutOf =
        Namespaced_IRI.parse _namespace_name "appliesOutOf" |> NamespacedName

    /// <summary>
    /// This is provided as free text in an annotation
    ///             label or as an identifier pointing to a term in a classification scheme.
    /// The target audience (target region, target
    ///             audience category but also parental guidance recommendation) for which the media
    ///             resource is intended.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#audienceLevel"></see></summary>
    let audienceLevel =
        Namespaced_IRI.parse _namespace_name "audienceLevel" |> NamespacedName

    /// <summary>
    /// To define the location/region to which Rating and TargetAudience apply.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#appliesTo"></see></summary>
    let appliesTo = Namespaced_IRI.parse _namespace_name "appliesTo" |> NamespacedName

    /// <summary>
    /// To provide the aspect ratio of a video frame or
    ///             image. Several types of different aspect ration can apply to the same video image. If
    ///             necessary, specialised aspect ratios can be defined as subproperties.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#aspectRatio"></see></summary>
    let aspectRatio =
        Namespaced_IRI.parse _namespace_name "aspectRatio" |> NamespacedName

    /// <summary>
    /// The total number of audio channels contained in
    ///             the MediaResource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#audioChannelNumber"></see></summary>
    let audioChannelNumber =
        Namespaced_IRI.parse _namespace_name "audioChannelNumber" |> NamespacedName

    /// <summary>
    /// To provide the configuration of an audio track
    ///             (e.g. stereo pair) in a MediaResource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#audioTrackConfiguration"></see></summary>
    let audioTrackConfiguration =
        Namespaced_IRI.parse _namespace_name "audioTrackConfiguration" |> NamespacedName

    /// <summary>
    /// To provide the audio encoding bit depth. Also called sample size.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#bitDepth"></see></summary>
    let bitDepth = Namespaced_IRI.parse _namespace_name "bitDepth" |> NamespacedName
    /// <summary>
    /// To provide the bitrate at which the
    ///             MediaResource can be played in bits/second. Current bitrate if constant, and average bitrate if variable.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#bitRate"></see></summary>
    let bitRate = Namespaced_IRI.parse _namespace_name "bitRate" |> NamespacedName
    /// <summary>
    /// The maximum bitrate when variable, in bits per second.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#bitRateMax"></see></summary>
    let bitRateMax = Namespaced_IRI.parse _namespace_name "bitRateMax" |> NamespacedName

    /// <summary>
    /// A flag to indicate if the bit rate is fixed or
    ///             variable.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#bitRateMode"></see></summary>
    let bitRateMode =
        Namespaced_IRI.parse _namespace_name "bitRateMode" |> NamespacedName

    /// <summary>
    /// To provide a bookmark.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#bookmark"></see></summary>
    let bookmark = Namespaced_IRI.parse _namespace_name "bookmark" |> NamespacedName

    /// <summary>
    /// A name attributed to a
    ///             BusinessObject.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#businessObjectName"></see></summary>
    let businessObjectName =
        Namespaced_IRI.parse _namespace_name "businessObjectName" |> NamespacedName

    /// <summary>
    /// To provide information on the source of a
    ///             captioning file.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#captioningSource"></see></summary>
    let captioningSource =
        Namespaced_IRI.parse _namespace_name "captioningSource" |> NamespacedName

    /// <summary>
    /// Identifies relationship between a digital instantiation of a resource and its direct copy, with no generational loss.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#clonedTo"></see></summary>
    let clonedTo = Namespaced_IRI.parse _namespace_name "clonedTo" |> NamespacedName

    /// <summary>
    /// Identifies relationship between a digital instantiation of a resource and its direct copy, with no generational loss.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isClonedFrom"></see></summary>
    let isClonedFrom =
        Namespaced_IRI.parse _namespace_name "isClonedFrom" |> NamespacedName

    /// <summary>
    /// To provide information on the product family of the Codec.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#codecFamily"></see></summary>
    let codecFamily =
        Namespaced_IRI.parse _namespace_name "codecFamily" |> NamespacedName

    /// <summary>
    /// To provide a name for the Codec, e.g. a product name.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#codecName"></see></summary>
    let codecName = Namespaced_IRI.parse _namespace_name "codecName" |> NamespacedName

    /// <summary>
    /// To provide a name for the vendor of the Codec.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#codecVendor"></see></summary>
    let codecVendor =
        Namespaced_IRI.parse _namespace_name "codecVendor" |> NamespacedName

    /// <summary>
    /// To provide information on the version of the Codec.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#codecVersion"></see></summary>
    let codecVersion =
        Namespaced_IRI.parse _namespace_name "codecVersion" |> NamespacedName

    /// <summary>
    /// To provide a comment.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#comments"></see></summary>
    let comments = Namespaced_IRI.parse _namespace_name "comments" |> NamespacedName

    /// <summary>
    /// The education details of a Contact /
    ///             person.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#contactEducation"></see></summary>
    let contactEducation =
        Namespaced_IRI.parse _namespace_name "contactEducation" |> NamespacedName

    /// <summary>
    /// Information on the family of a Contact /
    ///             person.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#contactFamilyInformation"></see></summary>
    let contactFamilyInformation =
        Namespaced_IRI.parse _namespace_name "contactFamilyInformation" |> NamespacedName

    /// <summary>
    /// The hobbies of a Contact /
    ///             person.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#contactHobbies"></see></summary>
    let contactHobbies =
        Namespaced_IRI.parse _namespace_name "contactHobbies" |> NamespacedName

    /// <summary>
    /// The marital status of a Contact /
    ///             person.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#contactMaritalStatus"></see></summary>
    let contactMaritalStatus =
        Namespaced_IRI.parse _namespace_name "contactMaritalStatus" |> NamespacedName

    /// <summary>
    /// The job / occupation name of a Contact /
    ///             person.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#contactOccupation"></see></summary>
    let contactOccupation =
        Namespaced_IRI.parse _namespace_name "contactOccupation" |> NamespacedName

    /// <summary>
    /// The username by which a Contact / person is
    ///             known e.g. when attributing a rating value.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#contactUsername"></see></summary>
    let contactUsername =
        Namespaced_IRI.parse _namespace_name "contactUsername" |> NamespacedName

    /// <summary>
    /// The date when the resource was first broadcast publicly on television or radio.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateBroadcast"></see></summary>
    let dateBroadcast =
        Namespaced_IRI.parse _namespace_name "dateBroadcast" |> NamespacedName

    /// <summary>
    /// The date of creation of the Resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateCreated"></see></summary>
    let dateCreated =
        Namespaced_IRI.parse _namespace_name "dateCreated" |> NamespacedName

    /// <summary>
    /// The date when the resource was removed from institutional holdings.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateDeleted"></see></summary>
    let dateDeleted =
        Namespaced_IRI.parse _namespace_name "dateDeleted" |> NamespacedName

    /// <summary>
    /// To provide the date of digitisation of the Resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateDigitised"></see></summary>
    let dateDigitised =
        Namespaced_IRI.parse _namespace_name "dateDigitised" |> NamespacedName

    /// <summary>
    /// The date when the resource was first made available to the public for purchase, download, or online access.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateDistributed"></see></summary>
    let dateDistributed =
        Namespaced_IRI.parse _namespace_name "dateDistributed" |> NamespacedName

    /// <summary>
    /// The date when the resource was removed from institutional holdings.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateIngested"></see></summary>
    let dateIngested =
        Namespaced_IRI.parse _namespace_name "dateIngested" |> NamespacedName

    /// <summary>
    /// To provide the date of release of the Resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateIssued"></see></summary>
    let dateIssued = Namespaced_IRI.parse _namespace_name "dateIssued" |> NamespacedName

    /// <summary>
    /// The date when the license for the resource begins.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateLicenced"></see></summary>
    let dateLicenced =
        Namespaced_IRI.parse _namespace_name "dateLicenced" |> NamespacedName

    /// <summary>
    /// The date when the resource was copied or converted from an obsolete or endangered original format to a more updated format for preservation.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateMigrated"></see></summary>
    let dateMigrated =
        Namespaced_IRI.parse _namespace_name "dateMigrated" |> NamespacedName

    /// <summary>
    /// To indicate the date at which the Resource has been modified.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateModified"></see></summary>
    let dateModified =
        Namespaced_IRI.parse _namespace_name "dateModified" |> NamespacedName

    /// <summary>
    /// The date when the resource was converted from its original format into a format pre-selected by the institution for preservation.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateNormalized"></see></summary>
    let dateNormalized =
        Namespaced_IRI.parse _namespace_name "dateNormalized" |> NamespacedName

    /// <summary>
    /// The date when the resource was moved from one digital or physical location to another.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateTransferred"></see></summary>
    let dateTransferred =
        Namespaced_IRI.parse _namespace_name "dateTransferred" |> NamespacedName

    /// <summary>
    /// The most recent date when the resource was confirmed to be valid through manual or digital QC.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateValidated"></see></summary>
    let dateValidated =
        Namespaced_IRI.parse _namespace_name "dateValidated" |> NamespacedName

    /// <summary>
    /// Identifies a content-based relationship between two resources.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#derivedTo"></see></summary>
    let derivedTo = Namespaced_IRI.parse _namespace_name "derivedTo" |> NamespacedName

    /// <summary>
    /// Identifies a content-based relationship between two resources.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isDerivedFrom"></see></summary>
    let isDerivedFrom =
        Namespaced_IRI.parse _namespace_name "isDerivedFrom" |> NamespacedName

    /// <summary>
    /// Describes the physical dimensions of a media resource, with units of measure concatenated to become part of the value.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dimensions"></see></summary>
    let dimensions = Namespaced_IRI.parse _namespace_name "dimensions" |> NamespacedName
    /// <summary>
    /// To provide a dopesheet with a title and brief description for news.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dopesheet"></see></summary>
    let dopesheet = Namespaced_IRI.parse _namespace_name "dopesheet" |> NamespacedName
    /// <summary>
    /// Identifies relationship between a physical instantiation of a resource and a duplicate physical copy that may involve generational loss.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dubbedTo"></see></summary>
    let dubbedTo = Namespaced_IRI.parse _namespace_name "dubbedTo" |> NamespacedName

    /// <summary>
    /// Identifies relationship between a physical instantiation of a resource and a duplicate physical copy that may involve generational loss.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isDubbedFrom"></see></summary>
    let isDubbedFrom =
        Namespaced_IRI.parse _namespace_name "isDubbedFrom" |> NamespacedName

    /// <summary>
    /// To provide information on the duration of a MediaResource. It corresponds to 'duration' in the
    ///             Ontology for Media Resources.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#duration"></see></summary>
    let duration = Namespaced_IRI.parse _namespace_name "duration" |> NamespacedName

    /// <summary>
    /// To provide a duration as normal
    ///             time.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#durationNormalPlayTime"></see></summary>
    let durationNormalPlayTime =
        Namespaced_IRI.parse _namespace_name "durationNormalPlayTime" |> NamespacedName

    /// <summary>
    /// To provide a duration as a number of EditUnits
    ///             which value is for instance the inverse of the audio sample rate or video frame
    ///             rate.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#durationNumberEditUnit"></see></summary>
    let durationNumberEditUnit =
        Namespaced_IRI.parse _namespace_name "durationNumberEditUnit" |> NamespacedName

    /// <summary>
    /// To provide information on the published / announced duration of an EditorialObject.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#durationPublished"></see></summary>
    let durationPublished =
        Namespaced_IRI.parse _namespace_name "durationPublished" |> NamespacedName

    /// <summary>
    /// To provide a published duration as normal
    ///             time.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#durationPublishedNormalPlayTime"></see></summary>
    let durationPublishedNormalPlayTime =
        Namespaced_IRI.parse _namespace_name "durationPublishedNormalPlayTime" |> NamespacedName

    /// <summary>
    /// To provide a published duration as a number of EditUnits
    ///             which value is for instance the inverse of the audio sample rate or video frame
    ///             rate.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#durationPublishedNumberEditUnit"></see></summary>
    let durationPublishedNumberEditUnit =
        Namespaced_IRI.parse _namespace_name "durationPublishedNumberEditUnit" |> NamespacedName

    /// <summary>
    /// The published duration expressed as a
    ///             timecode.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#durationPublishedTimecode"></see></summary>
    let durationPublishedTimecode =
        Namespaced_IRI.parse _namespace_name "durationPublishedTimecode" |> NamespacedName

    /// <summary>
    /// The duration expressed as a
    ///             timecode.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#durationTimecode"></see></summary>
    let durationTimecode =
        Namespaced_IRI.parse _namespace_name "durationTimecode" |> NamespacedName

    /// <summary>
    /// The edit unit is e.g. the inverse of the audio
    ///             sample rate or video frame rate.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#editUnit"></see></summary>
    let editUnit = Namespaced_IRI.parse _namespace_name "editUnit" |> NamespacedName

    /// <summary>
    /// The encoding level.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#encodingLevel"></see></summary>
    let encodingLevel =
        Namespaced_IRI.parse _namespace_name "encodingLevel" |> NamespacedName

    /// <summary>
    /// The encoding profile
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#encodingProfile"></see></summary>
    let encodingProfile =
        Namespaced_IRI.parse _namespace_name "encodingProfile" |> NamespacedName

    /// <summary>
    /// The start point of the media
    ///             resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#end"></see></summary>
    let end_ = Namespaced_IRI.parse _namespace_name "end" |> NamespacedName

    /// <summary>
    /// The date on which the license for the resource expires.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#endLicenceDate"></see></summary>
    let endLicenceDate =
        Namespaced_IRI.parse _namespace_name "endLicenceDate" |> NamespacedName

    /// <summary>
    /// The start time expressed using a time
    ///             expression.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#endNormalPlayTime"></see></summary>
    let endNormalPlayTime =
        Namespaced_IRI.parse _namespace_name "endNormalPlayTime" |> NamespacedName

    /// <summary>
    /// A start time expressed as a number of edit
    ///             units.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#endNumberEditUnits"></see></summary>
    let endNumberEditUnits =
        Namespaced_IRI.parse _namespace_name "endNumberEditUnits" |> NamespacedName

    /// <summary>
    /// A start time expressed as
    ///             timecode.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#endTimecode"></see></summary>
    let endTimecode =
        Namespaced_IRI.parse _namespace_name "endTimecode" |> NamespacedName

    /// <summary>
    /// To provide a deescription for an
    ///             Event.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#eventDescription"></see></summary>
    let eventDescription =
        Namespaced_IRI.parse _namespace_name "eventDescription" |> NamespacedName

    /// <summary>
    /// The duration of an event.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#eventDuration"></see></summary>
    let eventDuration =
        Namespaced_IRI.parse _namespace_name "eventDuration" |> NamespacedName

    /// <summary>
    /// The end date of an Event.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#eventEndDate"></see></summary>
    let eventEndDate =
        Namespaced_IRI.parse _namespace_name "eventEndDate" |> NamespacedName

    /// <summary>
    /// To provide a name for an Event.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#eventName"></see></summary>
    let eventName = Namespaced_IRI.parse _namespace_name "eventName" |> NamespacedName

    /// <summary>
    /// The period of time during which an Event has occured.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#eventPeriod"></see></summary>
    let eventPeriod =
        Namespaced_IRI.parse _namespace_name "eventPeriod" |> NamespacedName

    /// <summary>
    /// The start date of an Event.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#eventStartDate"></see></summary>
    let eventStartDate =
        Namespaced_IRI.parse _namespace_name "eventStartDate" |> NamespacedName

    /// <summary>
    /// To provide a family name / last name.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#familyName"></see></summary>
    let familyName = Namespaced_IRI.parse _namespace_name "familyName" |> NamespacedName
    /// <summary>
    /// A flag to indicate if an agent of fictitious
    ///             (set to true).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#fictitious"></see></summary>
    let fictitious = Namespaced_IRI.parse _namespace_name "fictitious" |> NamespacedName
    /// <summary>
    /// Provides the size of a MediaResource in bytes.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#fileSize"></see></summary>
    let fileSize = Namespaced_IRI.parse _namespace_name "fileSize" |> NamespacedName
    /// <summary>
    /// The name of the file containing the
    ///             Resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#filename"></see></summary>
    let filename = Namespaced_IRI.parse _namespace_name "filename" |> NamespacedName
    /// <summary>
    /// Provides a user/audience-generated description, tag, or label for resource content.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#folksonomy"></see></summary>
    let folksonomy = Namespaced_IRI.parse _namespace_name "folksonomy" |> NamespacedName

    /// <summary>
    /// A link to a an BusinessObject or a Resource preceding the current BusinessObject or Resource in an ordered sequence
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#followsInSequence"></see></summary>
    let followsInSequence =
        Namespaced_IRI.parse _namespace_name "followsInSequence" |> NamespacedName

    /// <summary>
    /// The frame rate of the video signal in frame per second.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#frameRate"></see></summary>
    let frameRate = Namespaced_IRI.parse _namespace_name "frameRate" |> NamespacedName

    /// <summary>
    /// The unit used to express the frame width or
    ///             height. The unit by default is 'pixel'.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#frameSizeUnit"></see></summary>
    let frameSizeUnit =
        Namespaced_IRI.parse _namespace_name "frameSizeUnit" |> NamespacedName

    /// <summary>
    /// Identifies the frames per second at which a visual resource should be played back for human consumption.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#framesPerSecond"></see></summary>
    let framesPerSecond =
        Namespaced_IRI.parse _namespace_name "framesPerSecond" |> NamespacedName

    /// <summary>
    /// Identifies the rate of units against time at which the resource should be played back for human consumption.  If the unit of measure is known, use sub-properties framesPerSecond or inchesPerSecond.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#playbackSpeed"></see></summary>
    let playbackSpeed =
        Namespaced_IRI.parse _namespace_name "playbackSpeed" |> NamespacedName

    /// <summary>
    /// To provide the frequency of an AudioChannel filter
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#frequency"></see></summary>
    let frequency = Namespaced_IRI.parse _namespace_name "frequency" |> NamespacedName
    /// <summary>
    /// To provide one or more given names.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#givenName"></see></summary>
    let givenName = Namespaced_IRI.parse _namespace_name "givenName" |> NamespacedName

    /// <summary>
    /// A textual description of a
    ///             Group.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#groupDescription"></see></summary>
    let groupDescription =
        Namespaced_IRI.parse _namespace_name "groupDescription" |> NamespacedName

    /// <summary>
    /// The name attributed to a Group.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#groupName"></see></summary>
    let groupName = Namespaced_IRI.parse _namespace_name "groupName" |> NamespacedName

    /// <summary>
    /// A property to establish the relation between a
    ///             Contact/person and an Organisation.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAffiliation"></see></summary>
    let hasAffiliation =
        Namespaced_IRI.parse _namespace_name "hasAffiliation" |> NamespacedName

    /// <summary>
    /// A property to signal the presence of
    ///             AncillaryData associated with the EditorialObject and / or MediaResource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAncillaryData"></see></summary>
    let hasAncillaryData =
        Namespaced_IRI.parse _namespace_name "hasAncillaryData" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAncillaryDataFormat"></see>
    /// </summary>
    let hasAncillaryDataFormat =
        Namespaced_IRI.parse _namespace_name "hasAncillaryDataFormat" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasDataFormat"></see>
    /// </summary>
    let hasDataFormat =
        Namespaced_IRI.parse _namespace_name "hasDataFormat" |> NamespacedName

    /// <summary>
    /// A property to signal the presence of Annotation
    ///             information associated with an EditorialObject and / or a MediaResource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAnnotation"></see></summary>
    let hasAnnotation =
        Namespaced_IRI.parse _namespace_name "hasAnnotation" |> NamespacedName

    /// <summary>
    /// To identify the Agent, Contact/person or
    ///             Organisation who has provided the Annotation.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAnnotationSource"></see></summary>
    let hasAnnotationSource =
        Namespaced_IRI.parse _namespace_name "hasAnnotationSource" |> NamespacedName

    /// <summary>
    /// To signal the presence of
    ///             AudioDescription.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAudioDescription"></see></summary>
    let hasAudioDescription =
        Namespaced_IRI.parse _namespace_name "hasAudioDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAudioEncodingFormat"></see>
    /// </summary>
    let hasAudioEncodingFormat =
        Namespaced_IRI.parse _namespace_name "hasAudioEncodingFormat" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasEncodingFormat"></see>
    /// </summary>
    let hasEncodingFormat =
        Namespaced_IRI.parse _namespace_name "hasEncodingFormat" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAudioFormat"></see>
    /// </summary>
    let hasAudioFormat =
        Namespaced_IRI.parse _namespace_name "hasAudioFormat" |> NamespacedName

    /// <summary>
    /// A property to define the Format of a Resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasFormat"></see></summary>
    let hasFormat = Namespaced_IRI.parse _namespace_name "hasFormat" |> NamespacedName

    /// <summary>
    /// To signal the presence of
    ///             Captioning.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCaptioning"></see></summary>
    let hasCaptioning =
        Namespaced_IRI.parse _namespace_name "hasCaptioning" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCaptioningFormat"></see>
    /// </summary>
    let hasCaptioningFormat =
        Namespaced_IRI.parse _namespace_name "hasCaptioningFormat" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCastMember"></see>
    /// </summary>
    let hasCastMember =
        Namespaced_IRI.parse _namespace_name "hasCastMember" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCharacter"></see>
    /// </summary>
    let hasCharacter =
        Namespaced_IRI.parse _namespace_name "hasCharacter" |> NamespacedName

    /// <summary>
    /// To identify the Codec with which the Resource has been encoded.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCodec"></see></summary>
    let hasCodec = Namespaced_IRI.parse _namespace_name "hasCodec" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasColourSpace"></see>
    /// </summary>
    let hasColourSpace =
        Namespaced_IRI.parse _namespace_name "hasColourSpace" |> NamespacedName

    /// <summary>
    /// To provide information on a Contact for an
    ///             Organisation or a physical person (e.g. the agent of an actor).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasContact"></see></summary>
    let hasContact = Namespaced_IRI.parse _namespace_name "hasContact" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasContainerFormat"></see>
    /// </summary>
    let hasContainerFormat =
        Namespaced_IRI.parse _namespace_name "hasContainerFormat" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasContainerMimeType"></see>
    /// </summary>
    let hasContainerMimeType =
        Namespaced_IRI.parse _namespace_name "hasContainerMimeType" |> NamespacedName

    /// <summary>
    /// To provide information on Contacts/persons or
    ///             Organisations who have contributed to the BusinessObject or Resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasContributor"></see></summary>
    let hasContributor =
        Namespaced_IRI.parse _namespace_name "hasContributor" |> NamespacedName

    /// <summary>
    /// A property to identify the Events and or
    ///             Locations, all real or fictional, covered by the
    ///             BusinessObject.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCoverage"></see></summary>
    let hasCoverage =
        Namespaced_IRI.parse _namespace_name "hasCoverage" |> NamespacedName

    /// <summary>
    /// The Location where content has been created.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCreationLocation"></see></summary>
    let hasCreationLocation =
        Namespaced_IRI.parse _namespace_name "hasCreationLocation" |> NamespacedName

    /// <summary>
    /// To identify an Agent involved in the creation of the Resource or BusinessObject.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCreator"></see></summary>
    let hasCreator = Namespaced_IRI.parse _namespace_name "hasCreator" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCrewMember"></see>
    /// </summary>
    let hasCrewMember =
        Namespaced_IRI.parse _namespace_name "hasCrewMember" |> NamespacedName

    /// <summary>
    /// To identify Departments within an
    ///             Organisation.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasDepartment"></see></summary>
    let hasDepartment =
        Namespaced_IRI.parse _namespace_name "hasDepartment" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasDocumentFormat"></see>
    /// </summary>
    let hasDocumentFormat =
        Namespaced_IRI.parse _namespace_name "hasDocumentFormat" |> NamespacedName

    /// <summary>
    /// To associate a Dopesheet with a NewsItem.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasDopesheet"></see></summary>
    let hasDopesheet =
        Namespaced_IRI.parse _namespace_name "hasDopesheet" |> NamespacedName

    /// <summary>
    /// To identify an episode of a
    ///             Series or a Season.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasEpisode"></see></summary>
    let hasEpisode = Namespaced_IRI.parse _namespace_name "hasEpisode" |> NamespacedName

    /// <summary>
    /// EditorialObjects can be related to other BusinessOjects, Assets (and associated rights), PublicationEvents(defined when commissioning the EditorialObject before it is instantiated as a Resource (manifestation), or Resources, or Ratings.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedBusinessObject"></see></summary>
    let hasRelatedBusinessObject =
        Namespaced_IRI.parse _namespace_name "hasRelatedBusinessObject" |> NamespacedName

    /// <summary>
    /// The Episode of a Series or a Season.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isEpisodeOf"></see></summary>
    let isEpisodeOf =
        Namespaced_IRI.parse _namespace_name "isEpisodeOf" |> NamespacedName

    /// <summary>
    /// To associate an Event with a
    ///             Location.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasEvent"></see></summary>
    let hasEvent = Namespaced_IRI.parse _namespace_name "hasEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasFileFormat"></see>
    /// </summary>
    let hasFileFormat =
        Namespaced_IRI.parse _namespace_name "hasFileFormat" |> NamespacedName

    /// <summary>
    /// Identifies the generation of a version of a resource, i.e. master, edit master, distribution copy, etc.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasGeneration"></see></summary>
    let hasGeneration =
        Namespaced_IRI.parse _namespace_name "hasGeneration" |> NamespacedName

    /// <summary>
    /// To define a Genre/category associated to the
    ///             BusinesssObject.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasGenre"></see></summary>
    let hasGenre = Namespaced_IRI.parse _namespace_name "hasGenre" |> NamespacedName
    /// <summary>
    /// To define a type of BusinessObject is not declared as a subClass of BusinessObject.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasType"></see></summary>
    let hasType = Namespaced_IRI.parse _namespace_name "hasType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasHomepage"></see>
    /// </summary>
    let hasHomepage =
        Namespaced_IRI.parse _namespace_name "hasHomepage" |> NamespacedName

    /// <summary>
    /// To identify a Resource associated with an Asset or a BusinessObject or a PublicationEvent or another Resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedResource"></see></summary>
    let hasRelatedResource =
        Namespaced_IRI.parse _namespace_name "hasRelatedResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasIdPicture"></see>
    /// </summary>
    let hasIdPicture =
        Namespaced_IRI.parse _namespace_name "hasIdPicture" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasImageFormat"></see>
    /// </summary>
    let hasImageFormat =
        Namespaced_IRI.parse _namespace_name "hasImageFormat" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasKeyCareerEvent"></see>
    /// </summary>
    let hasKeyCareerEvent =
        Namespaced_IRI.parse _namespace_name "hasKeyCareerEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedEvent"></see>
    /// </summary>
    let hasRelatedEvent =
        Namespaced_IRI.parse _namespace_name "hasRelatedEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasKeyPersonalEvent"></see>
    /// </summary>
    let hasKeyPersonalEvent =
        Namespaced_IRI.parse _namespace_name "hasKeyPersonalEvent" |> NamespacedName

    /// <summary>
    /// To associate a concept, descriptive phrase or
    ///             Keyword that specifies the topic of the BusinessObject or Annotation.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasKeyword"></see></summary>
    let hasKeyword = Namespaced_IRI.parse _namespace_name "hasKeyword" |> NamespacedName

    /// <summary>
    /// To associate a Language to a Resource or
    ///             BusinessObject. A controlled vocabulary based on BCP 47 is recommended. This
    ///             property can also be used to identify the presence of sign language (RFC 5646). By
    ///             inheritance, the hasLanguage property applies indifferently at the MediaResource /
    ///             Fragment / Track levels at which the usage is being defined. Best practice recommends to
    ///             use to best possible level of granularity fo describe the usage of language within a
    ///             MediaResource including at Fragment and Track levels.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasLanguage"></see></summary>
    let hasLanguage =
        Namespaced_IRI.parse _namespace_name "hasLanguage" |> NamespacedName

    /// <summary>
    /// To associate a Location with a BusinessObject.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasLocation"></see></summary>
    let hasLocation =
        Namespaced_IRI.parse _namespace_name "hasLocation" |> NamespacedName

    /// <summary>
    /// Logos can be used in a variety of contexts.
    ///             Logo can be associated with an Organisation or a Service or a PublicationChannel.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasLogo"></see></summary>
    let hasLogo = Namespaced_IRI.parse _namespace_name "hasLogo" |> NamespacedName

    /// <summary>
    /// To define Parts (segments, fragments, etc.)
    ///             withiin a MediaResource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasMediaFragment"></see></summary>
    let hasMediaFragment =
        Namespaced_IRI.parse _namespace_name "hasMediaFragment" |> NamespacedName

    /// <summary>
    /// To identify the MediaResource to which the MediaFragment belongs to.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isMediaFragmentOf"></see></summary>
    let isMediaFragmentOf =
        Namespaced_IRI.parse _namespace_name "isMediaFragmentOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasMedium"></see>
    /// </summary>
    let hasMedium = Namespaced_IRI.parse _namespace_name "hasMedium" |> NamespacedName
    /// <summary>
    /// To establish group/collection relationship between EditorialObjects.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasMember"></see></summary>
    let hasMember = Namespaced_IRI.parse _namespace_name "hasMember" |> NamespacedName

    /// <summary>
    /// To identify the Agent (Contact/person or
    ///             Organisation) who has created the metadata.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasMetadataAttributor"></see></summary>
    let hasMetadataAttributor =
        Namespaced_IRI.parse _namespace_name "hasMetadataAttributor" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasMimeType"></see>
    /// </summary>
    let hasMimeType =
        Namespaced_IRI.parse _namespace_name "hasMimeType" |> NamespacedName

    /// <summary>
    /// To define an ObjectType for the BusinessObject
    ///              (e.g. book, report, programme, clip) if not defined as a subClass of BusinessObject.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasObjectType"></see></summary>
    let hasObjectType =
        Namespaced_IRI.parse _namespace_name "hasObjectType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasOriginalLanguage"></see>
    /// </summary>
    let hasOriginalLanguage =
        Namespaced_IRI.parse _namespace_name "hasOriginalLanguage" |> NamespacedName

    /// <summary>
    /// To define Parts (segments, fragments, etc.)
    ///             within a BusinessObject.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasPart"></see></summary>
    let hasPart = Namespaced_IRI.parse _namespace_name "hasPart" |> NamespacedName

    /// <summary>
    /// To provide a visual representation of  TargetAudience or Rating.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasPictogram"></see></summary>
    let hasPictogram =
        Namespaced_IRI.parse _namespace_name "hasPictogram" |> NamespacedName

    /// <summary>
    /// To associate a PublicationEvent with a
    ///             PublicationChannel.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasPublicationChannel"></see></summary>
    let hasPublicationChannel =
        Namespaced_IRI.parse _namespace_name "hasPublicationChannel" |> NamespacedName

    /// <summary>
    /// To associate PublicationEvents with
    ///             PublicationChannels or as elements of a PublicationHistory or PublicationPlanning.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasPublicationEvent"></see></summary>
    let hasPublicationEvent =
        Namespaced_IRI.parse _namespace_name "hasPublicationEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasPublicationHistory"></see>
    /// </summary>
    let hasPublicationHistory =
        Namespaced_IRI.parse _namespace_name "hasPublicationHistory" |> NamespacedName

    /// <summary>
    /// To identify an Agent involved in the publication of the Resource or BusinessObject.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasPublisher"></see></summary>
    let hasPublisher =
        Namespaced_IRI.parse _namespace_name "hasPublisher" |> NamespacedName

    /// <summary>
    /// To identify the presence of Rating attributed
    ///             to a Resource or BusinessObject.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRating"></see></summary>
    let hasRating = Namespaced_IRI.parse _namespace_name "hasRating" |> NamespacedName

    /// <summary>
    /// To identify an Agent (Contact/person or
    ///             Organisation) who has proposed a Rating.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRatingSource"></see></summary>
    let hasRatingSource =
        Namespaced_IRI.parse _namespace_name "hasRatingSource" |> NamespacedName

    /// <summary>
    /// To associate an AudioChannel with an AudioPack or an AudioStream.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedAudioChannel"></see></summary>
    let hasRelatedAudioChannel =
        Namespaced_IRI.parse _namespace_name "hasRelatedAudioChannel" |> NamespacedName

    /// <summary>
    /// To identify the AudioContent associated with an AudioProgramme.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedAudioContent"></see></summary>
    let hasRelatedAudioContent =
        Namespaced_IRI.parse _namespace_name "hasRelatedAudioContent" |> NamespacedName

    /// <summary>
    /// To identify AudioObjects associated with AudioContent or other AudioObjects.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedAudioObject"></see></summary>
    let hasRelatedAudioObject =
        Namespaced_IRI.parse _namespace_name "hasRelatedAudioObject" |> NamespacedName

    /// <summary>
    /// To associate an AudioStream with an AudioTrack.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedAudioStream"></see></summary>
    let hasRelatedAudioStream =
        Namespaced_IRI.parse _namespace_name "hasRelatedAudioStream" |> NamespacedName

    /// <summary>
    /// To associate an AudioTrack with an AudioStream or an AudioTrackUID.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedAudioTrack"></see></summary>
    let hasRelatedAudioTrack =
        Namespaced_IRI.parse _namespace_name "hasRelatedAudioTrack" |> NamespacedName

    /// <summary>
    /// To associate an Image with a BusinessObject.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedImage"></see></summary>
    let hasRelatedImage =
        Namespaced_IRI.parse _namespace_name "hasRelatedImage" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedLocation"></see>
    /// </summary>
    let hasRelatedLocation =
        Namespaced_IRI.parse _namespace_name "hasRelatedLocation" |> NamespacedName

    /// <summary>
    /// To associate a Part of an EditorialObject with a MediaFragment within the association MediaResource instantiating the EditorialObject.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedMediaFragment"></see></summary>
    let hasRelatedMediaFragment =
        Namespaced_IRI.parse _namespace_name "hasRelatedMediaFragment" |> NamespacedName

    /// <summary>
    /// To associate a Picture with a BusinessObject or a Resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedPicture"></see></summary>
    let hasRelatedPicture =
        Namespaced_IRI.parse _namespace_name "hasRelatedPicture" |> NamespacedName

    /// <summary>
    /// To identify the PublicationEvent associated with a MediaResource (manifestation of an EditorialObject).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedPublicationEvent"></see></summary>
    let hasRelatedPublicationEvent =
        Namespaced_IRI.parse _namespace_name "hasRelatedPublicationEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRights"></see>
    /// </summary>
    let hasRights = Namespaced_IRI.parse _namespace_name "hasRights" |> NamespacedName

    /// <summary>
    /// To identify a Contact/person who can provide
    ///             assistance / guidance regarding the associated Rights.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRightsContact"></see></summary>
    let hasRightsContact =
        Namespaced_IRI.parse _namespace_name "hasRightsContact" |> NamespacedName

    /// <summary>
    /// To identify an Agent (Contact/person or
    ///             Organisation) having/managing Rights.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRightsHolder"></see></summary>
    let hasRightsHolder =
        Namespaced_IRI.parse _namespace_name "hasRightsHolder" |> NamespacedName

    /// <summary>
    /// To define the role of an Agent (Contact/person
    ///             or Organisation). The association in a particular context is made by declaring the hasCastRole  associated with the BusinessObject.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRole"></see></summary>
    let hasRole = Namespaced_IRI.parse _namespace_name "hasRole" |> NamespacedName
    /// <summary>
    /// The Season of a Series.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasSeason"></see></summary>
    let hasSeason = Namespaced_IRI.parse _namespace_name "hasSeason" |> NamespacedName
    /// <summary>
    /// The Season of a Series.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isSeasonOf"></see></summary>
    let isSeasonOf = Namespaced_IRI.parse _namespace_name "isSeasonOf" |> NamespacedName
    /// <summary>
    /// To identify the presence of Signing associated
    ///             to the BusinessObject/Resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasSigning"></see></summary>
    let hasSigning = Namespaced_IRI.parse _namespace_name "hasSigning" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasSigningFormat"></see>
    /// </summary>
    let hasSigningFormat =
        Namespaced_IRI.parse _namespace_name "hasSigningFormat" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasVideoFormat"></see>
    /// </summary>
    let hasVideoFormat =
        Namespaced_IRI.parse _namespace_name "hasVideoFormat" |> NamespacedName

    /// <summary>
    /// To identify a Resource as the source of another Resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasSource"></see></summary>
    let hasSource = Namespaced_IRI.parse _namespace_name "hasSource" |> NamespacedName
    /// <summary>
    /// To identify staff working within an Organisation.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasStaff"></see></summary>
    let hasStaff = Namespaced_IRI.parse _namespace_name "hasStaff" |> NamespacedName

    /// <summary>
    /// Identifies the technical video standard of a resource, i.e. NTSC or PAL.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasStandard"></see></summary>
    let hasStandard =
        Namespaced_IRI.parse _namespace_name "hasStandard" |> NamespacedName

    /// <summary>
    /// To define a particular type of storage /
    ///             repository associated with the Locator from where a Resource can be
    ///             accessed.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasStorageType"></see></summary>
    let hasStorageType =
        Namespaced_IRI.parse _namespace_name "hasStorageType" |> NamespacedName

    /// <summary>
    /// To associate a Subject addressed with a
    ///             BusinessObject / Resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasSubject"></see></summary>
    let hasSubject = Namespaced_IRI.parse _namespace_name "hasSubject" |> NamespacedName

    /// <summary>
    /// To signal the presence of Subtitling associated
    ///             with the EditorialObject or MediaResource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasSubtitling"></see></summary>
    let hasSubtitling =
        Namespaced_IRI.parse _namespace_name "hasSubtitling" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasSubtitlingFormat"></see>
    /// </summary>
    let hasSubtitlingFormat =
        Namespaced_IRI.parse _namespace_name "hasSubtitlingFormat" |> NamespacedName

    /// <summary>
    /// To associate a TargetAudience (e.g. for
    ///             parental guiddance or targeting a particular social group) with a
    ///             BusinessObject/Resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasTargetAudience"></see></summary>
    let hasTargetAudience =
        Namespaced_IRI.parse _namespace_name "hasTargetAudience" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasTheme"></see>
    /// </summary>
    let hasTheme = Namespaced_IRI.parse _namespace_name "hasTheme" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasTopic"></see>
    /// </summary>
    let hasTopic = Namespaced_IRI.parse _namespace_name "hasTopic" |> NamespacedName
    /// <summary>
    /// To associate audio/data/video tracks with a MediaResource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasTrack"></see></summary>
    let hasTrack = Namespaced_IRI.parse _namespace_name "hasTrack" |> NamespacedName
    /// <summary>
    /// To identify another version of an Asset, BusinessObject or Resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasVersion"></see></summary>
    let hasVersion = Namespaced_IRI.parse _namespace_name "hasVersion" |> NamespacedName

    /// <summary>
    /// To identify related versions.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isVersionOf"></see></summary>
    let isVersionOf =
        Namespaced_IRI.parse _namespace_name "isVersionOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasVideoEncodingFormat"></see>
    /// </summary>
    let hasVideoEncodingFormat =
        Namespaced_IRI.parse _namespace_name "hasVideoEncodingFormat" |> NamespacedName

    /// <summary>
    /// The hash value associated to a Resource. There
    ///             are different methods / algorithms to calculate hash values, which can be defined as
    ///             subproperties.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hashValue"></see></summary>
    let hashValue = Namespaced_IRI.parse _namespace_name "hashValue" |> NamespacedName
    /// <summary>
    /// The height of e.g. a video frame typically
    ///             expressed as a number of lines or the height of a picture/image expressed in millimeters
    ///             or else.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#height"></see></summary>
    let height = Namespaced_IRI.parse _namespace_name "height" |> NamespacedName
    /// <summary>
    /// The unit used to measure a Height e.g. in
    ///             pixels or number of lines or millimeters or else.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#heightUnit"></see></summary>
    let heightUnit = Namespaced_IRI.parse _namespace_name "heightUnit" |> NamespacedName
    /// <summary>
    /// The high pass frequency of the AudioChannel filter.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#highPass"></see></summary>
    let highPass = Namespaced_IRI.parse _namespace_name "highPass" |> NamespacedName
    /// <summary>
    /// To provide highlights.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#highlights"></see></summary>
    let highlights = Namespaced_IRI.parse _namespace_name "highlights" |> NamespacedName

    /// <summary>
    /// To identify a BusinessObject or Resource on
    ///             which an Agent (Contact/person or Organisation) holds Rights.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#holdsRightsOver"></see></summary>
    let holdsRightsOver =
        Namespaced_IRI.parse _namespace_name "holdsRightsOver" |> NamespacedName

    /// <summary>
    /// Corresponds to 'identifier'
    ///             in the W3C Ontology for Media Annotation. The URI may be used to express an alternative
    ///             identifier of the resource, or to share an identifier used by other instances of the
    ///             same resource (equivalent to the fucntionality owl:sameAs).
    /// This property is intended to provide an
    ///             alternative identifier for the resource, which has no URI counterpart. In the case where
    ///             the alternative identifier can be expressed as a URI, it is recommended to use
    ///             owl:sameAs instead.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#identifier"></see></summary>
    let identifier = Namespaced_IRI.parse _namespace_name "identifier" |> NamespacedName

    /// <summary>
    /// Identifies the inches per second at which an analog audio tape should be played back for human consumption.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#inchesPerSecond"></see></summary>
    let inchesPerSecond =
        Namespaced_IRI.parse _namespace_name "inchesPerSecond" |> NamespacedName

    /// <summary>
    /// To link a particular manifestation of a
    ///             BusinessObject to the corresponding Resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#instantiates"></see></summary>
    let instantiates =
        Namespaced_IRI.parse _namespace_name "instantiates" |> NamespacedName

    /// <summary>
    /// To identify a Contact/person or Organisation as part of a cast list.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isAgent"></see></summary>
    let isAgent = Namespaced_IRI.parse _namespace_name "isAgent" |> NamespacedName

    /// <summary>
    /// To identify the character personified by a Cast individual.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isCharacter"></see></summary>
    let isCharacter =
        Namespaced_IRI.parse _namespace_name "isCharacter" |> NamespacedName

    /// <summary>
    /// Copyright statement.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isCopyrightedBy"></see></summary>
    let isCopyrightedBy =
        Namespaced_IRI.parse _namespace_name "isCopyrightedBy" |> NamespacedName

    /// <summary>
    /// The Rights or policy applicable to the
    ///             BusinessObject, Asset, Resource or PublicationEvent.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isCoveredBy"></see></summary>
    let isCoveredBy =
        Namespaced_IRI.parse _namespace_name "isCoveredBy" |> NamespacedName

    /// <summary>
    /// To identify Contact/persons being fictitious.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isFictitiousContact"></see></summary>
    let isFictitiousContact =
        Namespaced_IRI.parse _namespace_name "isFictitiousContact" |> NamespacedName

    /// <summary>
    /// To identify a Group to which an EidtorialObject is a member of.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isMemberOf"></see></summary>
    let isMemberOf = Namespaced_IRI.parse _namespace_name "isMemberOf" |> NamespacedName

    /// <summary>
    /// A link to a an BusinessObject or a Resource following the current BusinessObject or Resource in an ordered sequence
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isNextInSequence"></see></summary>
    let isNextInSequence =
        Namespaced_IRI.parse _namespace_name "isNextInSequence" |> NamespacedName

    /// <summary>
    /// To identify the Service that operates the
    ///             PublicationChannel.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isOperatedBy"></see></summary>
    let isOperatedBy =
        Namespaced_IRI.parse _namespace_name "isOperatedBy" |> NamespacedName

    /// <summary>
    /// To identify the Agent (Contact/person or
    ///             Organisation) who owns a Service operating a PublicationChannel.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isOwnedBy"></see></summary>
    let isOwnedBy = Namespaced_IRI.parse _namespace_name "isOwnedBy" |> NamespacedName

    /// <summary>
    /// To express references across Assets, BusinessObjects or Resources.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isReferencedBy"></see></summary>
    let isReferencedBy =
        Namespaced_IRI.parse _namespace_name "isReferencedBy" |> NamespacedName

    /// <summary>
    /// To establish relationships between Assets,
    ///             BusinessObjects, PublicationEvents, Ratings and Resources.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isRelatedTo"></see></summary>
    let isRelatedTo =
        Namespaced_IRI.parse _namespace_name "isRelatedTo" |> NamespacedName

    /// <summary>
    /// To identify substitutions.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isReplacedBy"></see></summary>
    let isReplacedBy =
        Namespaced_IRI.parse _namespace_name "isReplacedBy" |> NamespacedName

    /// <summary>
    /// To express strong relations between Assets, BusinessObjects or Resources.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isRequiredBy"></see></summary>
    let isRequiredBy =
        Namespaced_IRI.parse _namespace_name "isRequiredBy" |> NamespacedName

    /// <summary>
    /// To provide a definition for a Keyword.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#keywordDefinition"></see></summary>
    let keywordDefinition =
        Namespaced_IRI.parse _namespace_name "keywordDefinition" |> NamespacedName

    /// <summary>
    /// To provide the number of the line on which
    ///             ancillary data is being carried and the equivalent in the digital domain.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#lineNumber"></see></summary>
    let lineNumber = Namespaced_IRI.parse _namespace_name "lineNumber" |> NamespacedName

    /// <summary>
    /// To provide the address of a
    ///            Location.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationAddress"></see></summary>
    let locationAddress =
        Namespaced_IRI.parse _namespace_name "locationAddress" |> NamespacedName

    /// <summary>
    /// To provide the Area part of an
    ///             Adrress.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationAddressArea"></see></summary>
    let locationAddressArea =
        Namespaced_IRI.parse _namespace_name "locationAddressArea" |> NamespacedName

    /// <summary>
    /// To provide the country name and or country
    ///             code.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationAddressCountry"></see></summary>
    let locationAddressCountry =
        Namespaced_IRI.parse _namespace_name "locationAddressCountry" |> NamespacedName

    /// <summary>
    /// To write address line with e.g. the street name
    ///             and number.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationAddressLine"></see></summary>
    let locationAddressLine =
        Namespaced_IRI.parse _namespace_name "locationAddressLine" |> NamespacedName

    /// <summary>
    /// To provide the name of a city, viallge,
    ///             etc.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationAddressLocality"></see></summary>
    let locationAddressLocality =
        Namespaced_IRI.parse _namespace_name "locationAddressLocality" |> NamespacedName

    /// <summary>
    /// To provide an address postal
    ///             code.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationAddressPostalCode"></see></summary>
    let locationAddressPostalCode =
        Namespaced_IRI.parse _namespace_name "locationAddressPostalCode" |> NamespacedName

    /// <summary>
    /// To define the altitude of a Location in
    ///             meters.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationAltitude"></see></summary>
    let locationAltitude =
        Namespaced_IRI.parse _namespace_name "locationAltitude" |> NamespacedName

    /// <summary>
    /// To specify the name of the gps coordinate
    ///             system used for the Location.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationCoordinateSystemName"></see></summary>
    let locationCoordinateSystemName =
        Namespaced_IRI.parse _namespace_name "locationCoordinateSystemName" |> NamespacedName

    /// <summary>
    /// To provide a description of a particular Location.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationDescription"></see></summary>
    let locationDescription =
        Namespaced_IRI.parse _namespace_name "locationDescription" |> NamespacedName

    /// <summary>
    /// The latitude of the Location.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationLatitude"></see></summary>
    let locationLatitude =
        Namespaced_IRI.parse _namespace_name "locationLatitude" |> NamespacedName

    /// <summary>
    /// To define the longitude of the
    ///             Location.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationLongitude"></see></summary>
    let locationLongitude =
        Namespaced_IRI.parse _namespace_name "locationLongitude" |> NamespacedName

    /// <summary>
    /// The name by which a Location is
    ///             known.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationName"></see></summary>
    let locationName =
        Namespaced_IRI.parse _namespace_name "locationName" |> NamespacedName

    /// <summary>
    /// To provide a description of a particular region assocoated to the Location.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationRegion"></see></summary>
    let locationRegion =
        Namespaced_IRI.parse _namespace_name "locationRegion" |> NamespacedName

    /// <summary>
    /// Information about storage accessed by the locator.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locatorTargetInformation"></see></summary>
    let locatorTargetInformation =
        Namespaced_IRI.parse _namespace_name "locatorTargetInformation" |> NamespacedName

    /// <summary>
    /// The value for integrated loudness measured at AudioProgramme or AudioContent level.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#loudnessIntegratedLoudness"></see></summary>
    let loudnessIntegratedLoudness =
        Namespaced_IRI.parse _namespace_name "loudnessIntegratedLoudness" |> NamespacedName

    /// <summary>
    /// All the parameters for measurement of loudness at the AudioContent or AudioProgramme level.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#loudnessParameters"></see></summary>
    let loudnessParameters =
        Namespaced_IRI.parse _namespace_name "loudnessParameters" |> NamespacedName

    /// <summary>
    /// The value for maximum momentary loudness measured at AudioProgramme or AudioContent level.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#loudnessMaxMomentary"></see></summary>
    let loudnessMaxMomentary =
        Namespaced_IRI.parse _namespace_name "loudnessMaxMomentary" |> NamespacedName

    /// <summary>
    /// The value for maximum true peak loudness measured at AudioProgramme or AudioContent level.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#loudnessMaxTruepeak"></see></summary>
    let loudnessMaxTruepeak =
        Namespaced_IRI.parse _namespace_name "loudnessMaxTruepeak" |> NamespacedName

    /// <summary>
    /// The method for loudness measurement at AudioProgramme or AudioContent level.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#loudnessMethod"></see></summary>
    let loudnessMethod =
        Namespaced_IRI.parse _namespace_name "loudnessMethod" |> NamespacedName

    /// <summary>
    /// The loudness range measured at AudioProgramme or AudioContent level.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#loudnessRange"></see></summary>
    let loudnessRange =
        Namespaced_IRI.parse _namespace_name "loudnessRange" |> NamespacedName

    /// <summary>
    /// The maximum short term loudness measured at AudioProgramme or AudioContent level.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#lounessMaxShortTerm"></see></summary>
    let lounessMaxShortTerm =
        Namespaced_IRI.parse _namespace_name "lounessMaxShortTerm" |> NamespacedName

    /// <summary>
    /// The low pass frequency of the AudioChannel filter.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#lowPass"></see></summary>
    let lowPass = Namespaced_IRI.parse _namespace_name "lowPass" |> NamespacedName
    /// <summary>
    /// To provide the main title by which the media
    ///             resource is known.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#mainTitle"></see></summary>
    let mainTitle = Namespaced_IRI.parse _namespace_name "mainTitle" |> NamespacedName
    /// <summary>
    /// All value of the EBU title status
    ///             classification scheme
    ///             (http://www.ebu.ch/metadata/cs/web/ebu_TitleStatusCodeCS_p.xml.htm) are candidates
    ///             subproperties of the title property as implemented for an example with
    ///             alternativeTitle.
    /// Specifies the title or name given to the
    ///             resource.  A root for the definition of subproperties defining ebucore titles of different types. The ebucore title type can be used to define sub-properties to optionally refine the category of
    ///             the title.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#title"></see></summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName
    /// <summary>
    /// To provide a salutation title e.g M. Ms, Dr, Pr.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#nameTitle"></see></summary>
    let nameTitle = Namespaced_IRI.parse _namespace_name "nameTitle" |> NamespacedName

    /// <summary>
    /// A flag to signal that a noise filter has been
    ///             used.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#noiseFilter"></see></summary>
    let noiseFilter =
        Namespaced_IRI.parse _namespace_name "noiseFilter" |> NamespacedName

    /// <summary>
    /// A flag to indicate that the BusinessObejct has not been rated.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#notRated"></see></summary>
    let notRated = Namespaced_IRI.parse _namespace_name "notRated" |> NamespacedName

    /// <summary>
    /// The number of Tracks composing the MediaResource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#numberOfTracks"></see></summary>
    let numberOfTracks =
        Namespaced_IRI.parse _namespace_name "numberOfTracks" |> NamespacedName

    /// <summary>
    /// To provide a definition of an AudioObject type.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#objectTypeDefinition"></see></summary>
    let objectTypeDefinition =
        Namespaced_IRI.parse _namespace_name "objectTypeDefinition" |> NamespacedName

    /// <summary>
    /// To provide the Area part of an
    ///             Address.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeAddressArea"></see></summary>
    let officeAddressArea =
        Namespaced_IRI.parse _namespace_name "officeAddressArea" |> NamespacedName

    /// <summary>
    /// To provide the professional / office address of
    ///             an agent (Contact/person or organisation).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeMailAddress"></see></summary>
    let officeMailAddress =
        Namespaced_IRI.parse _namespace_name "officeMailAddress" |> NamespacedName

    /// <summary>
    /// To provide the country name and or country
    ///             code.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeAddressCountry"></see></summary>
    let officeAddressCountry =
        Namespaced_IRI.parse _namespace_name "officeAddressCountry" |> NamespacedName

    /// <summary>
    /// To write address line with e.g. the street name
    ///             and number.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeAddressLine"></see></summary>
    let officeAddressLine =
        Namespaced_IRI.parse _namespace_name "officeAddressLine" |> NamespacedName

    /// <summary>
    /// To provide the name of a city, village,
    ///             etc.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeAddressLocality"></see></summary>
    let officeAddressLocality =
        Namespaced_IRI.parse _namespace_name "officeAddressLocality" |> NamespacedName

    /// <summary>
    /// To provide an address postal
    ///             code.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeAddressPostalCode"></see></summary>
    let officeAddressPostalCode =
        Namespaced_IRI.parse _namespace_name "officeAddressPostalCode" |> NamespacedName

    /// <summary>
    /// To provide the professional/office email
    ///             address of an agent (Contact/person or organisation).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeEmailAddress"></see></summary>
    let officeEmailAddress =
        Namespaced_IRI.parse _namespace_name "officeEmailAddress" |> NamespacedName

    /// <summary>
    /// To provide an office/professional/company web
    ///             homepage of an Agent (Contact/person or Organisation).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeHomepage"></see></summary>
    let officeHomepage =
        Namespaced_IRI.parse _namespace_name "officeHomepage" |> NamespacedName

    /// <summary>
    /// To provide the professional/office/company
    ///             mobile telephone number of an agent (Contact/person or organisation).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeMobileTelephoneNumber"></see></summary>
    let officeMobileTelephoneNumber =
        Namespaced_IRI.parse _namespace_name "officeMobileTelephoneNumber" |> NamespacedName

    /// <summary>
    /// To provide an office/professional/company
    ///             telephone number of an Agent (Contact/person or Organisation).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeTelephoneNumber"></see></summary>
    let officeTelephoneNumber =
        Namespaced_IRI.parse _namespace_name "officeTelephoneNumber" |> NamespacedName

    /// <summary>
    /// To provide the full name of an Organisation.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#organisationName"></see></summary>
    let organisationName =
        Namespaced_IRI.parse _namespace_name "organisationName" |> NamespacedName

    /// <summary>
    /// The orientation of a Document or an Image i.e. landscape or
    ///             portrait.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#orientation"></see></summary>
    let orientation =
        Namespaced_IRI.parse _namespace_name "orientation" |> NamespacedName

    /// <summary>
    /// To provide the original title attributed to the
    ///             media resource e.g. in its original language.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#originalTitle"></see></summary>
    let originalTitle =
        Namespaced_IRI.parse _namespace_name "originalTitle" |> NamespacedName

    /// <summary>
    /// To identify the service (s) that an Agent
    ///             (Contact/person or Organisation) owns.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#owns"></see></summary>
    let owns = Namespaced_IRI.parse _namespace_name "owns" |> NamespacedName

    /// <summary>
    /// The size of a media package in
    ///             Bytes.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#packageByteSize"></see></summary>
    let packageByteSize =
        Namespaced_IRI.parse _namespace_name "packageByteSize" |> NamespacedName

    /// <summary>
    /// The name attributed to a
    ///             package.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#packageName"></see></summary>
    let packageName =
        Namespaced_IRI.parse _namespace_name "packageName" |> NamespacedName

    /// <summary>
    /// A definition associated with the Part.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#partDefinition"></see></summary>
    let partDefinition =
        Namespaced_IRI.parse _namespace_name "partDefinition" |> NamespacedName

    /// <summary>
    /// A name by which the Part is identified.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#partName"></see></summary>
    let partName = Namespaced_IRI.parse _namespace_name "partName" |> NamespacedName
    /// <summary>
    /// The number associated to a Part as one among
    ///             many.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#partNumber"></see></summary>
    let partNumber = Namespaced_IRI.parse _namespace_name "partNumber" |> NamespacedName

    /// <summary>
    /// The total number of Parts associated with a
    ///             BusinessObject.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#partTotalNumber"></see></summary>
    let partTotalNumber =
        Namespaced_IRI.parse _namespace_name "partTotalNumber" |> NamespacedName

    /// <summary>
    /// To describe a playlist.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#playlist"></see></summary>
    let playlist = Namespaced_IRI.parse _namespace_name "playlist" |> NamespacedName

    /// <summary>
    /// To provide the Area part of an
    ///             Adrress.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateAddressArea"></see></summary>
    let privateAddressArea =
        Namespaced_IRI.parse _namespace_name "privateAddressArea" |> NamespacedName

    /// <summary>
    /// To provide the private / personal address of an
    ///             agent (Contact/person).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateMailAddress"></see></summary>
    let privateMailAddress =
        Namespaced_IRI.parse _namespace_name "privateMailAddress" |> NamespacedName

    /// <summary>
    /// To provide the country name and or country
    ///             code.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateAddressCountry"></see></summary>
    let privateAddressCountry =
        Namespaced_IRI.parse _namespace_name "privateAddressCountry" |> NamespacedName

    /// <summary>
    /// To write address line with e.g. the street name
    ///             and number.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateAddressLine"></see></summary>
    let privateAddressLine =
        Namespaced_IRI.parse _namespace_name "privateAddressLine" |> NamespacedName

    /// <summary>
    /// To provide the name of a city, viallge,
    ///             etc.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateAddressLocality"></see></summary>
    let privateAddressLocality =
        Namespaced_IRI.parse _namespace_name "privateAddressLocality" |> NamespacedName

    /// <summary>
    /// To provide an address postal
    ///             code.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateAddressPostalCode"></see></summary>
    let privateAddressPostalCode =
        Namespaced_IRI.parse _namespace_name "privateAddressPostalCode" |> NamespacedName

    /// <summary>
    /// To provide the private email address of an
    ///             agent (Contact/person)
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateEmailAddress"></see></summary>
    let privateEmailAddress =
        Namespaced_IRI.parse _namespace_name "privateEmailAddress" |> NamespacedName

    /// <summary>
    /// To provide an private web homepage of an Agent
    ///             (Contact/person).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateHomepage"></see></summary>
    let privateHomepage =
        Namespaced_IRI.parse _namespace_name "privateHomepage" |> NamespacedName

    /// <summary>
    /// To provide the private mobile telephone number
    ///             of an agent (Contact/person).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateMobileTelephoneNumber"></see></summary>
    let privateMobileTelephoneNumber =
        Namespaced_IRI.parse _namespace_name "privateMobileTelephoneNumber" |> NamespacedName

    /// <summary>
    /// To provide the private telephone number of an
    ///             Agent (Contact/person).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateTelephoneNumber"></see></summary>
    let privateTelephoneNumber =
        Namespaced_IRI.parse _namespace_name "privateTelephoneNumber" |> NamespacedName

    /// <summary>
    /// To provide textual promotional information.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#promotionalInformation"></see></summary>
    let promotionalInformation =
        Namespaced_IRI.parse _namespace_name "promotionalInformation" |> NamespacedName

    /// <summary>
    /// To indicate a publication status.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#pubStatus"></see></summary>
    let pubStatus = Namespaced_IRI.parse _namespace_name "pubStatus" |> NamespacedName

    /// <summary>
    /// To provide a name to a PublicationChannel e.g. a TV channel or website.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publicationChannelName"></see></summary>
    let publicationChannelName =
        Namespaced_IRI.parse _namespace_name "publicationChannelName" |> NamespacedName

    /// <summary>
    /// The actual end date and time of a PublicationEvent.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publicationEndDateTime"></see></summary>
    let publicationEndDateTime =
        Namespaced_IRI.parse _namespace_name "publicationEndDateTime" |> NamespacedName

    /// <summary>
    /// To provide a name to a PublicationEvent.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publicationEventName"></see></summary>
    let publicationEventName =
        Namespaced_IRI.parse _namespace_name "publicationEventName" |> NamespacedName

    /// <summary>
    /// To express specifically the schedule date to which a PublicationEvent is related in particular if the broacdast time is after midnight. For example, the schedule date would be May 29th and the programme is published at 1 am on May 30th, while still associated in the schedule with the night of May 29th.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publicationScheduleDate"></see></summary>
    let publicationScheduleDate =
        Namespaced_IRI.parse _namespace_name "publicationScheduleDate" |> NamespacedName

    /// <summary>
    /// The actual start date and time of a PublicationEvent.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publicationStartDateTime"></see></summary>
    let publicationStartDateTime =
        Namespaced_IRI.parse _namespace_name "publicationStartDateTime" |> NamespacedName

    /// <summary>
    /// The end date and time of a PublicationEvent as
    ///             scheduled.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publishedEndDateTime"></see></summary>
    let publishedEndDateTime =
        Namespaced_IRI.parse _namespace_name "publishedEndDateTime" |> NamespacedName

    /// <summary>
    /// The start date and time of a PublicationEvent
    ///             as scheduled.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publishedStartDateTime"></see></summary>
    let publishedStartDateTime =
        Namespaced_IRI.parse _namespace_name "publishedStartDateTime" |> NamespacedName

    /// <summary>
    /// The title used to identify the work at publication time.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publishedTitle"></see></summary>
    let publishedTitle =
        Namespaced_IRI.parse _namespace_name "publishedTitle" |> NamespacedName

    /// <summary>
    /// The maximum value of the scale used for rating
    ///             a media resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ratingScaleMax"></see></summary>
    let ratingScaleMax =
        Namespaced_IRI.parse _namespace_name "ratingScaleMax" |> NamespacedName

    /// <summary>
    /// The minimum value of the scale used for rating
    ///             a Resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ratingScaleMin"></see></summary>
    let ratingScaleMin =
        Namespaced_IRI.parse _namespace_name "ratingScaleMin" |> NamespacedName

    /// <summary>
    /// To identify the environment in which rating applies.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ratingSystemEnvironment"></see></summary>
    let ratingSystemEnvironment =
        Namespaced_IRI.parse _namespace_name "ratingSystemEnvironment" |> NamespacedName

    /// <summary>
    /// To identify a rating system by its name.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ratingSystemName"></see></summary>
    let ratingSystemName =
        Namespaced_IRI.parse _namespace_name "ratingSystemName" |> NamespacedName

    /// <summary>
    /// To express a free text rating value defined in
    ///             a rating classification scheme.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ratingValue"></see></summary>
    let ratingValue =
        Namespaced_IRI.parse _namespace_name "ratingValue" |> NamespacedName

    /// <summary>
    /// To provide a reason for which Rating as been attributed as provided.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#reason"></see></summary>
    let reason = Namespaced_IRI.parse _namespace_name "reason" |> NamespacedName
    /// <summary>
    /// To express a reference between Assets, BusinessObjects or Resources.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#references"></see></summary>
    let references = Namespaced_IRI.parse _namespace_name "references" |> NamespacedName

    /// <summary>
    /// To define the bottom right corner of a zone on
    ///             the x-axis. If present with regionDelimY, the zone definition is complemented by the
    ///             associated values of the height and width.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#regionDelimX"></see></summary>
    let regionDelimX =
        Namespaced_IRI.parse _namespace_name "regionDelimX" |> NamespacedName

    /// <summary>
    /// To define the bottom right corner of a zone on
    ///             the y-axis. If present with regionDelimX, the zone definition is complemented by the
    ///             associated values of the height and width.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#regionDelimY"></see></summary>
    let regionDelimY =
        Namespaced_IRI.parse _namespace_name "regionDelimY" |> NamespacedName

    /// <summary>
    /// To provide a link to a web resource containing
    ///             information related to an Agent (Contact/person or Organisation).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#relatedLink"></see></summary>
    let relatedLink =
        Namespaced_IRI.parse _namespace_name "relatedLink" |> NamespacedName

    /// <summary>
    /// To identify substitution.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#replaces"></see></summary>
    let replaces = Namespaced_IRI.parse _namespace_name "replaces" |> NamespacedName
    /// <summary>
    /// To express dependency.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#requires"></see></summary>
    let requires = Namespaced_IRI.parse _namespace_name "requires" |> NamespacedName

    /// <summary>
    /// This can be specialised by using sub-properties
    ///             like defined in http://www.ebu.ch/metadata/cs/web/ebu_DescriptionTypeCodeCS_p.xml.htm
    ///             implemented as examples as e.g. 'summary' or
    ///             'script'.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#resourceDescription"></see></summary>
    let resourceDescription =
        Namespaced_IRI.parse _namespace_name "resourceDescription" |> NamespacedName

    /// <summary>
    /// A name by which the resource can be identified.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#resourceName"></see></summary>
    let resourceName =
        Namespaced_IRI.parse _namespace_name "resourceName" |> NamespacedName

    /// <summary>
    /// To provide a text for a review.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#review"></see></summary>
    let review = Namespaced_IRI.parse _namespace_name "review" |> NamespacedName

    /// <summary>
    /// The expression of Rights as free
    ///             text.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#rightsExpression"></see></summary>
    let rightsExpression =
        Namespaced_IRI.parse _namespace_name "rightsExpression" |> NamespacedName

    /// <summary>
    /// A link to e.g. a webpage where an expression of
    ///             the rights can be found and consulted.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#rightsLink"></see></summary>
    let rightsLink = Namespaced_IRI.parse _namespace_name "rightsLink" |> NamespacedName

    /// <summary>
    /// To provide a definition for a role
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#roleDefinition"></see></summary>
    let roleDefinition =
        Namespaced_IRI.parse _namespace_name "roleDefinition" |> NamespacedName

    /// <summary>
    /// The frequency at which audio is sampled per second. Also called sampling rate.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#sampleRate"></see></summary>
    let sampleRate = Namespaced_IRI.parse _namespace_name "sampleRate" |> NamespacedName
    /// <summary>
    /// The size of an audio sample in
    ///             bits. Also called bit depth.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#sampleSize"></see></summary>
    let sampleSize = Namespaced_IRI.parse _namespace_name "sampleSize" |> NamespacedName
    /// <summary>
    /// The type of audio sample.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#sampleType"></see></summary>
    let sampleType = Namespaced_IRI.parse _namespace_name "sampleType" |> NamespacedName

    /// <summary>
    /// To define the scanning format for a
    ///             MediaResource. For video, the two main values are "interlaced" or
    ///             "progressive".
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#scanningFormat"></see></summary>
    let scanningFormat =
        Namespaced_IRI.parse _namespace_name "scanningFormat" |> NamespacedName

    /// <summary>
    /// To provide a script.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#script"></see></summary>
    let script = Namespaced_IRI.parse _namespace_name "script" |> NamespacedName
    /// <summary>
    /// Provides a shot-by-shot description of resource content.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#shotlog"></see></summary>
    let shotlog = Namespaced_IRI.parse _namespace_name "shotlog" |> NamespacedName

    /// <summary>
    /// To identify the source of the signing
    ///             resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#signingSource"></see></summary>
    let signingSource =
        Namespaced_IRI.parse _namespace_name "signingSource" |> NamespacedName

    /// <summary>
    /// The start point of the MediaResource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#start"></see></summary>
    let start = Namespaced_IRI.parse _namespace_name "start" |> NamespacedName

    /// <summary>
    /// The start time expressed using a time
    ///             expression.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#startNormalPlayTime"></see></summary>
    let startNormalPlayTime =
        Namespaced_IRI.parse _namespace_name "startNormalPlayTime" |> NamespacedName

    /// <summary>
    /// A start time expressed as a number of edit
    ///             units.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#startNumberEditUnits"></see></summary>
    let startNumberEditUnits =
        Namespaced_IRI.parse _namespace_name "startNumberEditUnits" |> NamespacedName

    /// <summary>
    /// A start time expressed as
    ///             timecode.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#startTimecode"></see></summary>
    let startTimecode =
        Namespaced_IRI.parse _namespace_name "startTimecode" |> NamespacedName

    /// <summary>
    /// To provide a definition for storage.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#storageDefinition"></see></summary>
    let storageDefinition =
        Namespaced_IRI.parse _namespace_name "storageDefinition" |> NamespacedName

    /// <summary>
    /// A complementary subtitle.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#subtitle"></see></summary>
    let subtitle = Namespaced_IRI.parse _namespace_name "subtitle" |> NamespacedName

    /// <summary>
    /// To identify the source of the Subtitling
    ///             resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#subtitlingSource"></see></summary>
    let subtitlingSource =
        Namespaced_IRI.parse _namespace_name "subtitlingSource" |> NamespacedName

    /// <summary>
    /// To provide a summary.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#summary"></see></summary>
    let summary = Namespaced_IRI.parse _namespace_name "summary" |> NamespacedName
    /// <summary>
    /// To provide a summary.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#synopsis"></see></summary>
    let synopsis = Namespaced_IRI.parse _namespace_name "synopsis" |> NamespacedName

    /// <summary>
    /// To provide a Table of Content.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#tableOfContent"></see></summary>
    let tableOfContent =
        Namespaced_IRI.parse _namespace_name "tableOfContent" |> NamespacedName

    /// <summary>
    /// To define the system used to provide a TargetAudience.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#targetAudienceSystem"></see></summary>
    let targetAudienceSystem =
        Namespaced_IRI.parse _namespace_name "targetAudienceSystem" |> NamespacedName

    /// <summary>
    /// The value of an Annotation as free
    ///             text.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#textualAnnotation"></see></summary>
    let textualAnnotation =
        Namespaced_IRI.parse _namespace_name "textualAnnotation" |> NamespacedName

    /// <summary>
    /// To provide a definition associated to a
    ///             Track.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#trackDefinition"></see></summary>
    let trackDefinition =
        Namespaced_IRI.parse _namespace_name "trackDefinition" |> NamespacedName

    /// <summary>
    /// The name attributed to a Track.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#trackName"></see></summary>
    let trackName = Namespaced_IRI.parse _namespace_name "trackName" |> NamespacedName

    /// <summary>
    /// A translated version of the title.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#translationTitle"></see></summary>
    let translationTitle =
        Namespaced_IRI.parse _namespace_name "translationTitle" |> NamespacedName

    /// <summary>
    /// An alternative title specific to a verison of content.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#versionTitle"></see></summary>
    let versionTitle =
        Namespaced_IRI.parse _namespace_name "versionTitle" |> NamespacedName

    /// <summary>
    /// The width of e.g. a video frame typically
    ///             expressed as a number of pixels, or picture/image in millimeters.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#width"></see></summary>
    let width = Namespaced_IRI.parse _namespace_name "width" |> NamespacedName
    /// <summary>
    /// The unit used to measure a width e.g. in pixels
    ///             or number of lines or millimeters or else.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#widthUnit"></see></summary>
    let widthUnit = Namespaced_IRI.parse _namespace_name "widthUnit" |> NamespacedName
    /// <summary>
    /// The number of words contained in a
    ///             document.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#wordCount"></see></summary>
    let wordCount = Namespaced_IRI.parse _namespace_name "wordCount" |> NamespacedName

    /// <summary>
    /// A title used while content is not complete.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#workingTitle"></see></summary>
    let workingTitle =
        Namespaced_IRI.parse _namespace_name "workingTitle" |> NamespacedName

    /// <summary>
    /// To provide additional information on the
    ///             wrapping type of ancillary data.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#wrappingType"></see></summary>
    let wrappingType =
        Namespaced_IRI.parse _namespace_name "wrappingType" |> NamespacedName
