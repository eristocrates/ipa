namespace http.www.ebu.ch.metadata.ontologies.ebucore.ebucore.hash

open DoxAletheia

module ebucore =
    let _namespace_name = "http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An image, a document, an annotation
    ///             (descriptive textual metadata or audio/video tag), a tag (time related in audiovisual
    ///             media resources), or an audiovisual media resource (optionally composed of one or more
    ///             fragment / part and / or audio, video data tracks). Other types of BusinessObjects may
    ///             be defined as subclasses.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#BusinessObject"></see></summary>
    let BusinessObject = _prefix "BusinessObject"
    /// <summary>
    /// A manifestation of a
    ///             BusinessObject.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Resource"></see></summary>
    let Resource = _prefix "Resource"
    /// <summary>
    /// The Class "Asset" is an
    ///             object to which an identifier will be associated at commissioning. It will serve as a
    ///             central reference point to manage rights associated to EditorialObjects, Resources,
    ///             MediaResources or Essences, and PublicationEvents (distribution and exploitation
    ///             conditions).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Asset"></see></summary>
    let Asset = _prefix "Asset"
    /// <summary>
    /// To describe any manifestation of a media
    ///             resource on any media (live, on demand, catch-up TV, etc.) and the appropriate
    ///             PublciationChannel.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#PublicationEvent"></see></summary>
    let PublicationEvent = _prefix "PublicationEvent"
    /// <summary>
    /// Additional types of event shall be defined as
    ///             new sub-classes of event.
    /// An event related to the media resource, e.g.
    ///             depicted in the resource (possibly fictional), etc.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Event"></see></summary>
    let Event = _prefix "Event"
    /// <summary>
    /// An organisation (business, corporation, federation, etc.) or moral agent (gvernment body).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Organisation"></see></summary>
    let Organisation = _prefix "Organisation"
    /// <summary>
    /// A physical person.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Contact"></see></summary>
    let Contact = _prefix "Contact"
    /// <summary>
    /// A type of location is defined as a sub-class of
    ///             location.
    /// A location related to the media resource, e.g.
    ///             depicted in the resource (possibly fictional) or where the resource was created
    ///             (shooting location), etc.
    /// This is provided as free text in an annotation
    ///             label or as an identifier pointing to a term in a classification scheme.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Location"></see></summary>
    let Location = _prefix "Location"
    /// <summary>
    /// To proivde keywords and define key concepts
    ///             illustrating the content of the Resource or EditorialObject. This is provided as free
    ///             text in an annotation label or as an identifier pointing to a term in a classification
    ///             scheme.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Keyword"></see></summary>
    let Keyword = _prefix "Keyword"
    /// <summary>
    /// The conditions under which content can be accessed.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AccessConditions"></see></summary>
    let AccessConditions = _prefix "AccessConditions"
    /// <summary>
    /// To provide information on the rights, including
    ///             intellectual property, related to a BusinessObject or Resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Rights"></see></summary>
    let Rights = _prefix "Rights"
    /// <summary>
    /// An Organisation to which a Contact is affiliated (with period of validity).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Affiliation"></see></summary>
    let Affiliation = _prefix "Affiliation"
    /// <summary>
    /// A person / contact or organisation.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Agent"></see></summary>
    let Agent = _prefix "Agent"
    /// <summary>
    /// Any ancillary data provided with the content
    ///             other than captioning and subtitling.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AncillaryData"></see></summary>
    let AncillaryData = _prefix "AncillaryData"
    /// <summary>
    /// Ancillary data track e.g. ¨captioning"
    ///             or "subtitling" in addition to video and audio tracks.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#DataTrack"></see></summary>
    let DataTrack = _prefix "DataTrack"
    /// <summary>
    /// To define the format of AncillaryData such as
    ///             legacy data used to be carried in vertical blanking intervals. This is provided as free
    ///             text in an annotation label or as an identifier pointing to a term in a classification
    ///             scheme.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AncillaryDataFormat"></see></summary>
    let AncillaryDataFormat = _prefix "AncillaryDataFormat"
    /// <summary>
    /// To provide addtional technical information on
    ///             the characteristics of data streams in a MediaResource including but not limited to
    ///             AncillaryData, Subtilting and Captioning. Additional specific data format may be defined
    ///             as subclasses of DataFormat.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#DataFormat"></see></summary>
    let DataFormat = _prefix "DataFormat"
    /// <summary>
    /// A set of descriptive or technical metadata.
    ///             Annotation can also be made in the form of a document or media resource such as an or
    ///             video audio file . An annotation can exist on its own and be related / associated to
    ///             other editorial objects or resources.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Annotation"></see></summary>
    let Annotation = _prefix "Annotation"
    /// <summary>
    /// The audience by which the Resource can be
    ///             seen according to ratings like MPAA  (http://en.wikipedia.org/wiki/Motion_picture_rating_system) or other organisational / national / local standards.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudienceRating"></see></summary>
    let AudienceRating = _prefix "AudienceRating"
    /// <summary>
    /// All the information about the rating/evaluation
    ///             given to a media resource by an Agent i.e. a person/Contact or
    ///             Organisation.
    /// This is provided as free text in an annotation
    ///             label or as an identifier pointing to a term in a classification scheme.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Rating"></see></summary>
    let Rating = _prefix "Rating"
    /// <summary>
    /// An audioChannel represents a single sequence of audio samples. It
    /// 				is sub-divided in the time domain into audioBlocks, which is must contain at
    /// 				least one of. The typeDefintion of the audioChannel format specifies the type of
    /// 				audio it is describing, and also determines which parameters are used within its
    /// 				audioBlock children.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioChannel"></see></summary>
    let AudioChannel = _prefix "AudioChannel"
    /// <summary>
    /// In some audiovisual standardisation groups,
    ///             Essence is preferred to MediaResource. In also has subclasses well known as MediaObject
    ///             clustered in AudioObjects and VideoObjects.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Essence"></see></summary>
    let Essence = _prefix "Essence"
    /// <summary>
    /// An audioContent defines one component of a programme (e.g. background
    /// 				music), its association with an audioGroup (e.g. a 2.0 audioPackFormat of
    /// 				audioChannelFormats for stereo reproduction), its association with an
    /// 				audioStreamFormat, and its set of loudness parameters.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioContent"></see></summary>
    let AudioContent = _prefix "AudioContent"
    /// <summary>
    /// A set of one or more audioContent that derive from the same material,
    /// 				i.e. an audioMultiplex, and the definition of its multiplexed audioContents (e.g.
    /// 				foreground and commentary, background music).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioProgramme"></see></summary>
    let AudioProgramme = _prefix "AudioProgramme"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioDescription"></see>
    /// </summary>
    let AudioDescription = _prefix "AudioDescription"
    /// <summary>
    /// An audioTrack object defines a component of an audioStream.
    /// 				A single set of samples or data in the storage medium.
    /// Represents a physical container or carrier to hold an audio stream. This
    /// 				should be usually defined by many attributes such as ID, format (e.g. 48 kHz/24
    /// 				bits), linkage information (e.g. odd/even)…
    /// An audioTrack is the basic audio data container of a medium. Attribute is
    /// 				an unambiguous reference to this container in a given medium.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioTrack"></see></summary>
    let AudioTrack = _prefix "AudioTrack"
    /// <summary>
    /// The encoding format for the audio.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioEncodingFormat"></see></summary>
    let AudioEncodingFormat = _prefix "AudioEncodingFormat"
    /// <summary>
    /// To provide a definition of the encoding format
    ///             for audio and video. This is provided as free text in an annotation label or as an
    ///             identifier pointing to a term in a classification scheme e.g.
    ///             http://www.ebu.ch/metadata/ontologies/skos/ebu_AudioCompressionCodeCS.rdf or
    ///             http://www.ebu.ch/metadata/ontologies/skos/ebu_VideoCompressionCodeCS.rdf.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#EncodingFormat"></see></summary>
    let EncodingFormat = _prefix "EncodingFormat"
    /// <summary>
    /// The technical characteristics of an
    ///             AudioResource such as the sampleRate. This is provided as free text in an annotation
    ///             label or as an identifier pointing to a term in a classification scheme e.g.
    ///             http://www.ebu.ch/metadata/ontologies/skos/ebu_AudioFormatCodeCS.rdf.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioFormat"></see></summary>
    let AudioFormat = _prefix "AudioFormat"
    /// <summary>
    /// The format provides technical information on
    ///             the format of a Resource. A BusinessObject can be instantiated in a variety of Resources
    ///             each in a particular Format. Other specific data formats may be defined as subclasses of
    ///             format.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Format"></see></summary>
    let Format = _prefix "Format"
    /// <summary>
    /// The format of an AudioPack. Examples of audioPackFormats are 'stereo' and '5.1' for channel-based formats.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioPackFormat"></see></summary>
    let AudioPackFormat = _prefix "AudioPackFormat"
    /// <summary>
    /// An EditorialObject corresponding to a
    ///             MediaResource ready for publication.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Programme"></see></summary>
    let Programme = _prefix "Programme"
    /// <summary>
    /// An audioStreamFormat describes a decodable signal - PCM signal or a Dolby E stream for example. It is composed of one or more AudioTracks.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioStream"></see></summary>
    let AudioStream = _prefix "AudioStream"
    /// <summary>
    /// A continuous stream of bits.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Stream"></see></summary>
    let Stream = _prefix "Stream"
    /// <summary>
    /// The format of an AudioStream, e.g. PCM_FrontLeft or Dolby E.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioStreamFormat"></see></summary>
    let AudioStreamFormat = _prefix "AudioStreamFormat"
    /// <summary>
    /// Audiovisual content can be composed of audio,
    ///             video and data Tracks (including captioning and subtitling).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Track"></see></summary>
    let Track = _prefix "Track"
    /// <summary>
    /// The format of an AudioTrack e.g. PCM_FrontLeft.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioTrackFormat"></see></summary>
    let AudioTrackFormat = _prefix "AudioTrackFormat"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#BibliographicalObject"></see>
    /// </summary>
    let BibliographicalObject = _prefix "BibliographicalObject"
    /// <summary>
    /// A group of EditorialObjects having a Brand as a
    ///             common denominator
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Brand"></see></summary>
    let Brand = _prefix "Brand"
    /// <summary>
    /// To define a collection / group of media
    ///             resources, for example a series made of episodes.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Group"></see></summary>
    let Group = _prefix "Group"
    /// <summary>
    /// To signal the presence of hard of hearing
    ///             captioning.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Captioning"></see></summary>
    let Captioning = _prefix "Captioning"
    /// <summary>
    /// To define the format of captioning.
    ///             Captioning's main use isfor hard of hearing transcription. This is provided as
    ///             free text in an annotation label or as an identifier pointing to a term in a
    ///             classification scheme.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#CaptioningFormat"></see></summary>
    let CaptioningFormat = _prefix "CaptioningFormat"
    /// <summary>
    /// A member of the cast list (a list of performers/actors and associated fictitious
    ///             characters).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Cast"></see></summary>
    let Cast = _prefix "Cast"
    /// <summary>
    /// E.g. a fictitious contact / person.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Character"></see></summary>
    let Character = _prefix "Character"
    /// <summary>
    /// Closed captioning is provided as separate
    ///             content.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ClosedCaptions"></see></summary>
    let ClosedCaptions = _prefix "ClosedCaptions"
    /// <summary>
    /// Closed subtitles are provided as separate
    ///             content.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ClosedSubtitling"></see></summary>
    let ClosedSubtitling = _prefix "ClosedSubtitling"
    /// <summary>
    /// To signal the presence of subtitles for
    ///             translation in alternative languages.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Subtitling"></see></summary>
    let Subtitling = _prefix "Subtitling"
    /// <summary>
    /// To provide information on a codec.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Codec"></see></summary>
    let Codec = _prefix "Codec"
    /// <summary>
    /// A group of EditorialObjects. There can be many
    ///             types of collections for which specific sub-classes should be defined. In the worl of
    ///             archives, A collection corresponds to all items belonging to an individual /
    ///             collector.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Collection"></see></summary>
    let Collection = _prefix "Collection"
    /// <summary>
    /// The CoulourSpace of a VideoResource. A
    ///             ColourSpace is defined as free text in an annotation label or as an identifier pointing
    ///             to a term in a classification scheme such as
    ///             http://www.ebu.ch/metadata/ontologies/skos/ebu_ColourCodeCS.rdf.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ColourSpace"></see></summary>
    let ColourSpace = _prefix "ColourSpace"
    /// <summary>
    /// A component e.g. audio, video, data or else or a MediaResource or Essence.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Component"></see></summary>
    let Component = _prefix "Component"
    /// <summary>
    /// The container or wrapper format used to package
    ///             audio, video and data components of a Mediaresource. The format is defined as free text
    ///             or pointing at a term in a classification scheme e.g.
    ///             http://www.ebu.ch/metadata/ontologies/skos/ebu_ContainerFormatCS.rdf.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ContainerFormat"></see></summary>
    let ContainerFormat = _prefix "ContainerFormat"
    /// <summary>
    /// The definition of the container if available as
    ///             a MIME type. This is provided as free text in an annotation label or as an identifier
    ///             pointing to a term in a classification scheme. For more information:
    ///             http://www.iana.org/assignments/media-types/application/index.html.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ContainerMimeType"></see></summary>
    let ContainerMimeType = _prefix "ContainerMimeType"
    /// <summary>
    /// To provide a copyright
    ///             statement.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Copyright"></see></summary>
    let Copyright = _prefix "Copyright"
    /// <summary>
    /// To provide information on possible restrictions
    ///             regarding the temporal and spatial coverage for publication.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#CoverageRestrictions"></see></summary>
    let CoverageRestrictions = _prefix "CoverageRestrictions"
    /// <summary>
    /// Crew member.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Crew"></see></summary>
    let Crew = _prefix "Crew"
    /// <summary>
    /// The Data Identifier word (along with the SDID,
    ///             if used), indicates the type of ancillary data that the packet corresponds
    ///             to.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#DID"></see></summary>
    let DID = _prefix "DID"
    /// <summary>
    /// A department within and
    ///             organisation.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Department"></see></summary>
    let Department = _prefix "Department"
    /// <summary>
    /// A DepictedEVent is fictitious or historical or
    ///             other sort of Event that the content of the BusinessObject or resource relates
    ///             to.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#DepictedEvent"></see></summary>
    let DepictedEvent = _prefix "DepictedEvent"
    /// <summary>
    /// To provide a disclaimer of any
    ///             form.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Disclaimer"></see></summary>
    let Disclaimer = _prefix "Disclaimer"
    /// <summary>
    /// To describe a publication in the form of a
    ///             document e.g. a html webpage (news item) or a pdf document e.g. a script.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Document"></see></summary>
    let Document = _prefix "Document"
    /// <summary>
    /// To provide technical information about the
    ///             format of a document such as the orientation. This is provided as free text in an
    ///             annotation label or as an identifier pointing to a term in a classification
    ///             scheme.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#DocumentFormat"></see></summary>
    let DocumentFormat = _prefix "DocumentFormat"
    /// <summary>
    /// Provides additional information about a NewsItem, e.g. date and place, subject.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Dopesheet"></see></summary>
    let Dopesheet = _prefix "Dopesheet"
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
    let EditorialObject = _prefix "EditorialObject"
    /// <summary>
    /// The use of MediaResource is reserved to
    ///             audiovisual content.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#MediaResource"></see></summary>
    let MediaResource = _prefix "MediaResource"
    /// <summary>
    /// To highlight potential exploitation
    ///             issues.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ExploitationIssues"></see></summary>
    let ExploitationIssues = _prefix "ExploitationIssues"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Feature"></see>
    /// </summary>
    let Feature = _prefix "Feature"
    /// <summary>
    /// A file format for Resources other than
    ///             audiovisual resources. The format is defined as free text or pointing at a term in a
    ///             classification scheme e.g.
    ///             http://www.ebu.ch/metadata/ontologies/skos/ebu_FileFormatCS.rdf.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#FileFormat"></see></summary>
    let FileFormat = _prefix "FileFormat"
    /// <summary>
    /// Identifies the generation of a version of a resource, i.e. master, edit master, distribution copy, etc.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Generation"></see></summary>
    let Generation = _prefix "Generation"
    /// <summary>
    /// This class shall be used to provide information
    ///             on the genre of the BusinessObject or Resource. This is provided as free text in an
    ///             annotation label or as an identifier pointing to a term in a classification scheme e.g.
    ///             http://www.ebu.ch/metadata/ontologies/skos/ebu_ContentGenreCS.rdf or
    ///             http://www.ebu.ch/metadata/ontologies/skos/ebu_EditorialFormatCodeCS.rdf.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Genre"></see></summary>
    let Genre = _prefix "Genre"
    /// <summary>
    /// An expression of type in textual form or as a term from a classification scheme.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Type"></see></summary>
    let Type = _prefix "Type"
    /// <summary>
    /// To provide information on intellectual
    ///             property.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#IPRRestrictions"></see></summary>
    let IPRRestrictions = _prefix "IPRRestrictions"
    /// <summary>
    /// A still image / thumbnail / key frame / logo
    ///             related to the media resource or being the media resource itself
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Image"></see></summary>
    let Image = _prefix "Image"
    /// <summary>
    /// To provide technical information about the
    ///             format of an image such as the orientation. This is provided as free text in an
    ///             annotation label or as an identifier pointing to a term in a classification
    ///             scheme.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ImageFormat"></see></summary>
    let ImageFormat = _prefix "ImageFormat"
    /// <summary>
    /// An item e.g. newsItem or sportItem
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Item"></see></summary>
    let Item = _prefix "Item"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#KeyCareerEvent"></see>
    /// </summary>
    let KeyCareerEvent = _prefix "KeyCareerEvent"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#KeyEvent"></see>
    /// </summary>
    let KeyEvent = _prefix "KeyEvent"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#KeyPersonalEvent"></see>
    /// </summary>
    let KeyPersonalEvent = _prefix "KeyPersonalEvent"
    /// <summary>
    /// A key frame is a frame extarcted from video,
    ///             e.g. representative of a part of a MediaResource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Keyframe"></see></summary>
    let Keyframe = _prefix "Keyframe"
    /// <summary>
    /// A photography, a logo, a pictogram, etc.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Picture"></see></summary>
    let Picture = _prefix "Picture"
    /// <summary>
    /// To provide information on languages present in
    ///             the BusinessObject and its purpose. This is provided as free text in an annotation label
    ///             or as an identifier pointing to a term in a classification scheme.Other language
    ///             specific types may be added as subclasses of language.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Language"></see></summary>
    let Language = _prefix "Language"
    /// <summary>
    /// A Logo allows to visually identify an
    ///             organisation, publicationService, publicationChannel, or ratings /
    ///             parentalGuidance
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Logo"></see></summary>
    let Logo = _prefix "Logo"
    /// <summary>
    /// A MediaFragment is a temporal or spatial segment of a resource identified by a MediaGragment URI (http://www.w3.org/2008/WebVideo/Fragments/WD-media-fragments-spec/).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#MediaFragment"></see></summary>
    let MediaFragment = _prefix "MediaFragment"
    /// <summary>
    /// To provide information on the medium formats in
    ///             which the resource is available. This is provided as free text in an annotation label or
    ///             as an identifier pointing to a term in a classification scheme.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Medium"></see></summary>
    let Medium = _prefix "Medium"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#MetadataTrack"></see>
    /// </summary>
    let MetadataTrack = _prefix "MetadataTrack"
    /// <summary>
    /// The definition of the container if available as
    ///             a MIME type. This is provided as free text in an annotation label or as an identifier
    ///             pointing to a term in a classification scheme. For more information:
    ///             http://www.iana.org/assignments/media-types/index.html.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#MimeType"></see></summary>
    let MimeType = _prefix "MimeType"
    /// <summary>
    /// A NewsItem aggregates all information about a particular news event.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#NewsItem"></see></summary>
    let NewsItem = _prefix "NewsItem"
    /// <summary>
    /// To specify the type of BusinessObject e.g. and
    ///             EditorialObject of type "programme" or clip". This is
    ///             provided as free text in an annotation label or as an identifier pointing to a term in a
    ///             classification scheme e.g.
    ///             http://www.ebu.ch/metadata/ontologies/skos/ebu_ObjectTypeCodeCS.rdf.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ObjectType"></see></summary>
    let ObjectType = _prefix "ObjectType"
    /// <summary>
    /// Open Captions are burned in the
    ///             image.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#OpenCaptions"></see></summary>
    let OpenCaptions = _prefix "OpenCaptions"
    /// <summary>
    /// Open subtitles are burned in the
    ///             image.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#OpenSubtitling"></see></summary>
    let OpenSubtitling = _prefix "OpenSubtitling"
    /// <summary>
    /// The original language in which the
    ///             BusinessObject or Resource has been created and released. This is provided as free text
    ///             in an annotation label or as an identifier pointing to a term in a classification
    ///             scheme.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#OriginalLanguage"></see></summary>
    let OriginalLanguage = _prefix "OriginalLanguage"
    /// <summary>
    /// One of more media fragment (audio, video, data)
    ///             composing an audiovisual media resource. In other ontolgies fragment is often referred
    ///             to e.g. as a 'part' or 'segment' or
    ///             'fragment'.
    /// A Fragment is a particular section of a
    ///             MediaResource identified by a start and end time or duration. Fragment can also be
    ///             called segment or part.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Part"></see></summary>
    let Part = _prefix "Part"
    /// <summary>
    /// A visual / graphical representation of a concept.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Pictogram"></see></summary>
    let Pictogram = _prefix "Pictogram"
    /// <summary>
    /// The name of the channel through which a
    ///             Resource has been published as a PublicationEvent. A PublicationChannel can use a
    ///             variety of medias e.g. broadcast or online.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#PublicationChannel"></see></summary>
    let PublicationChannel = _prefix "PublicationChannel"
    /// <summary>
    /// A collection of PublicationEvents through which
    ///             a resource has been published.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#PublicationHistory"></see></summary>
    let PublicationHistory = _prefix "PublicationHistory"
    /// <summary>
    /// A collection of PublicationEvents organised as a PublicationPlanning.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#PublicationPlanning"></see></summary>
    let PublicationPlanning = _prefix "PublicationPlanning"
    /// <summary>
    /// A programme for distribution on radio
    ///             channels.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#RadioProgramme"></see></summary>
    let RadioProgramme = _prefix "RadioProgramme"
    /// <summary>
    /// To signal that rights have been cleared (or
    ///             not)
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#RightsClearance"></see></summary>
    let RightsClearance = _prefix "RightsClearance"
    /// <summary>
    /// To define the role / action of an agent. This
    ///             is provided as free text in an annotation label or as an identifier pointing to a term
    ///             in a classification scheme.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Role"></see></summary>
    let Role = _prefix "Role"
    /// <summary>
    /// Secondary data identification word for
    ///             ancillary data. Send mode identifier. An identifier which indicates the transmission
    ///             timing for closed caption data.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#SDID"></see></summary>
    let SDID = _prefix "SDID"
    /// <summary>
    /// A series can be composed of one or more seasons
    ///             clustering a certain number of episodes. Fro this reason, seasons are related to series
    ///             using the isRelatedTo property.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Season"></see></summary>
    let Season = _prefix "Season"
    /// <summary>
    /// Series is a particular type of collection. TV
    ///             or Radio Series are composed of Episodes.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Series"></see></summary>
    let Series = _prefix "Series"
    /// <summary>
    /// A service is the umbrella under which one or
    ///             more PublicationChannel is operated.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Service"></see></summary>
    let Service = _prefix "Service"
    /// <summary>
    /// To signal the presence of Signing for hard of
    ///             hearing users. The type of Signing (e.g. incursted in or else) or language of Signing
    ///             can be specified using the appropriate properties.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Signing"></see></summary>
    let Signing = _prefix "Signing"
    /// <summary>
    /// A specialisation of Track for Video to provide
    ///             a link to specific data properties such as frameRate, etc. Signing is another possible
    ///             example of video track. Specific VideoTracks such as Signing can be defined as sub
    ///             VideoTracks.. In advanced systems, different VideoTracks can be used to provide e.g.
    ///             different viewing angles.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#VideoTrack"></see></summary>
    let VideoTrack = _prefix "VideoTrack"
    /// <summary>
    /// To provide additional information on the
    ///             signing format. This is provided as free text in an annotation label or as an identifier
    ///             pointing to a term in a classification scheme.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#SigningFormat"></see></summary>
    let SigningFormat = _prefix "SigningFormat"
    /// <summary>
    /// To provide additional technical information
    ///             about a video resource such as the frame rate. This is provided as free text in an
    ///             annotation label or as an identifier pointing to a term in a classification
    ///             scheme.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#VideoFormat"></see></summary>
    let VideoFormat = _prefix "VideoFormat"
    /// <summary>
    /// A SportItem aggregates all information about a sport event.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#SportItem"></see></summary>
    let SportItem = _prefix "SportItem"
    /// <summary>
    /// Staff member.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Staff"></see></summary>
    let Staff = _prefix "Staff"
    /// <summary>
    /// identifies the technical video standard of a resource, i.e. NTSC or PAL.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Standard"></see></summary>
    let Standard = _prefix "Standard"
    /// <summary>
    /// The type of storage used for the repository.
    ///             This is provided as free text in an annotation label or as an identifier pointing to a
    ///             term in a classification scheme.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#StorageType"></see></summary>
    let StorageType = _prefix "StorageType"
    /// <summary>
    /// A term describing the topic covered by the
    ///             BusinessObject or resource. This is provided as free text in an annotation label or as
    ///             an identifier pointing to a term in a classification scheme.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Subject"></see></summary>
    let Subject = _prefix "Subject"
    /// <summary>
    /// To define the format of subtitling.
    ///             subtitling's main use isfor translation. This is provided as free text in an
    ///             annotation label  or as an identifier pointing to a term in a classification
    ///             scheme.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#SubtitlingFormat"></see></summary>
    let SubtitlingFormat = _prefix "SubtitlingFormat"
    /// <summary>
    /// A programme for distribution on television
    ///             channels.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#TVProgramme"></see></summary>
    let TVProgramme = _prefix "TVProgramme"
    /// <summary>
    /// An annotation specific to a particular
    ///             timestamp in audiovisual MediaResources.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Tag"></see></summary>
    let Tag = _prefix "Tag"
    /// <summary>
    /// A thumbnail is a low resolution picture that
    ///             can be associated with EditorialObjects or e.g. MediaResources or
    ///             Contacts.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Thumbnail"></see></summary>
    let Thumbnail = _prefix "Thumbnail"
    /// <summary>
    /// A track with timecode information.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#TimecodeTrack"></see></summary>
    let TimecodeTrack = _prefix "TimecodeTrack"
    /// <summary>
    /// A type subject for use in some contexts. This
    ///             is provided as free text in an annotation label or as an identifier pointing to a term
    ///             in a classification scheme.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Topic"></see></summary>
    let Topic = _prefix "Topic"
    /// <summary>
    /// Usage rights associated with content.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#UsageRights"></see></summary>
    let UsageRights = _prefix "UsageRights"
    /// <summary>
    /// The encoding format of the video.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#VideoEncodingFormat"></see></summary>
    let VideoEncodingFormat = _prefix "VideoEncodingFormat"
    /// <summary>
    /// A decodable video stream of bits.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#VideoStream"></see></summary>
    let VideoStream = _prefix "VideoStream"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#YouTubeVideo"></see>
    /// </summary>
    let YouTubeVideo = _prefix "YouTubeVideo"
    /// <summary>
    /// A shorter version of the title.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#abridgedTitle"></see></summary>
    let abridgedTitle = _prefix "abridgedTitle"
    /// <summary>
    /// To provide an alternative title.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#alternativeTitle"></see></summary>
    let alternativeTitle = _prefix "alternativeTitle"
    /// <summary>
    /// To provide a brief summary.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#abstract"></see></summary>
    let abstract_ = _prefix "abstract"
    /// <summary>
    /// This can be specialised by using sub-properties
    ///             like defined in http://www.ebu.ch/metadata/cs/web/ebu_DescriptionTypeCodeCS_p.xml.htm
    ///             implemented as examples as e.g. 'summary' or
    ///             'script'.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#adultContent"></see>
    /// </summary>
    let adultContent = _prefix "adultContent"
    /// <summary>
    /// The date when a Contact left an Organisation
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#affiliationEndDate"></see></summary>
    let affiliationEndDate = _prefix "affiliationEndDate"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#affiliationStartDate"></see>
    /// </summary>
    let affiliationStartDate = _prefix "affiliationStartDate"
    /// <summary>
    /// To provide the address of an Agent
    ///             (Contact/person or organisation).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentAddress"></see></summary>
    let agentAddress = _prefix "agentAddress"
    /// <summary>
    /// The age of a Contact/Person
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentAge"></see></summary>
    let agentAge = _prefix "agentAge"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentCountryOfResidence"></see>
    /// </summary>
    let agentCountryOfResidence = _prefix "agentCountryOfResidence"
    /// <summary>
    /// To provide the email address of an agent
    ///             (Contact/person or organisation).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentEmailAddress"></see></summary>
    let agentEmailAddress = _prefix "agentEmailAddress"
    /// <summary>
    /// To provide the mobile telephone number of an
    ///             Agent (Contact/person or organisation)
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentMobileTelephoneNumber"></see></summary>
    let agentMobileTelephoneNumber = _prefix "agentMobileTelephoneNumber"
    /// <summary>
    /// To provide the full name of Contact/person - family and given name.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentName"></see></summary>
    let agentName = _prefix "agentName"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentNationality"></see>
    /// </summary>
    let agentNationality = _prefix "agentNationality"
    /// <summary>
    /// To provide a nickname of a Contact/person.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentNickname"></see></summary>
    let agentNickname = _prefix "agentNickname"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentPictureIdLocator"></see>
    /// </summary>
    let agentPictureIdLocator = _prefix "agentPictureIdLocator"
    /// <summary>
    /// A locator from where the Resource can be accessed.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locator"></see></summary>
    let locator = _prefix "locator"
    /// <summary>
    /// To provide the telephone number of an Agent
    ///             (Contact/person or Organisation).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentTelephoneNumber"></see></summary>
    let agentTelephoneNumber = _prefix "agentTelephoneNumber"
    /// <summary>
    /// To provide the address of the webpage of an
    ///             Agent (Contact/person or Organisation).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentWebHomepage"></see></summary>
    let agentWebHomepage = _prefix "agentWebHomepage"
    /// <summary>
    /// To define the Location (e.g. country, region) to which Rating and TargetAudience do NOT apply.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#appliesOutOf"></see></summary>
    let appliesOutOf = _prefix "appliesOutOf"
    /// <summary>
    /// This is provided as free text in an annotation
    ///             label or as an identifier pointing to a term in a classification scheme.
    /// The target audience (target region, target
    ///             audience category but also parental guidance recommendation) for which the media
    ///             resource is intended.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#audienceLevel"></see></summary>
    let audienceLevel = _prefix "audienceLevel"
    /// <summary>
    /// To define the location/region to which Rating and TargetAudience apply.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#appliesTo"></see></summary>
    let appliesTo = _prefix "appliesTo"
    /// <summary>
    /// To provide the aspect ratio of a video frame or
    ///             image. Several types of different aspect ration can apply to the same video image. If
    ///             necessary, specialised aspect ratios can be defined as subproperties.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#aspectRatio"></see></summary>
    let aspectRatio = _prefix "aspectRatio"
    /// <summary>
    /// The total number of audio channels contained in
    ///             the MediaResource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#audioChannelNumber"></see></summary>
    let audioChannelNumber = _prefix "audioChannelNumber"
    /// <summary>
    /// To provide the configuration of an audio track
    ///             (e.g. stereo pair) in a MediaResource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#audioTrackConfiguration"></see></summary>
    let audioTrackConfiguration = _prefix "audioTrackConfiguration"
    /// <summary>
    /// To provide the audio encoding bit depth. Also called sample size.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#bitDepth"></see></summary>
    let bitDepth = _prefix "bitDepth"
    /// <summary>
    /// To provide the bitrate at which the
    ///             MediaResource can be played in bits/second. Current bitrate if constant, and average bitrate if variable.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#bitRate"></see></summary>
    let bitRate = _prefix "bitRate"
    /// <summary>
    /// The maximum bitrate when variable, in bits per second.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#bitRateMax"></see></summary>
    let bitRateMax = _prefix "bitRateMax"
    /// <summary>
    /// A flag to indicate if the bit rate is fixed or
    ///             variable.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#bitRateMode"></see></summary>
    let bitRateMode = _prefix "bitRateMode"
    /// <summary>
    /// To provide a bookmark.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#bookmark"></see></summary>
    let bookmark = _prefix "bookmark"
    /// <summary>
    /// A name attributed to a
    ///             BusinessObject.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#businessObjectName"></see></summary>
    let businessObjectName = _prefix "businessObjectName"
    /// <summary>
    /// To provide information on the source of a
    ///             captioning file.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#captioningSource"></see></summary>
    let captioningSource = _prefix "captioningSource"
    /// <summary>
    /// Identifies relationship between a digital instantiation of a resource and its direct copy, with no generational loss.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#clonedTo"></see></summary>
    let clonedTo = _prefix "clonedTo"
    /// <summary>
    /// Identifies relationship between a digital instantiation of a resource and its direct copy, with no generational loss.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isClonedFrom"></see></summary>
    let isClonedFrom = _prefix "isClonedFrom"
    /// <summary>
    /// To provide information on the product family of the Codec.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#codecFamily"></see></summary>
    let codecFamily = _prefix "codecFamily"
    /// <summary>
    /// To provide a name for the Codec, e.g. a product name.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#codecName"></see></summary>
    let codecName = _prefix "codecName"
    /// <summary>
    /// To provide a name for the vendor of the Codec.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#codecVendor"></see></summary>
    let codecVendor = _prefix "codecVendor"
    /// <summary>
    /// To provide information on the version of the Codec.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#codecVersion"></see></summary>
    let codecVersion = _prefix "codecVersion"
    /// <summary>
    /// To provide a comment.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#comments"></see></summary>
    let comments = _prefix "comments"
    /// <summary>
    /// The education details of a Contact /
    ///             person.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#contactEducation"></see></summary>
    let contactEducation = _prefix "contactEducation"
    /// <summary>
    /// Information on the family of a Contact /
    ///             person.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#contactFamilyInformation"></see></summary>
    let contactFamilyInformation = _prefix "contactFamilyInformation"
    /// <summary>
    /// The hobbies of a Contact /
    ///             person.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#contactHobbies"></see></summary>
    let contactHobbies = _prefix "contactHobbies"
    /// <summary>
    /// The marital status of a Contact /
    ///             person.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#contactMaritalStatus"></see></summary>
    let contactMaritalStatus = _prefix "contactMaritalStatus"
    /// <summary>
    /// The job / occupation name of a Contact /
    ///             person.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#contactOccupation"></see></summary>
    let contactOccupation = _prefix "contactOccupation"
    /// <summary>
    /// The username by which a Contact / person is
    ///             known e.g. when attributing a rating value.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#contactUsername"></see></summary>
    let contactUsername = _prefix "contactUsername"
    /// <summary>
    /// The date when the resource was first broadcast publicly on television or radio.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateBroadcast"></see></summary>
    let dateBroadcast = _prefix "dateBroadcast"
    /// <summary>
    /// The date of creation of the Resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateCreated"></see></summary>
    let dateCreated = _prefix "dateCreated"
    /// <summary>
    /// The date when the resource was removed from institutional holdings.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateDeleted"></see></summary>
    let dateDeleted = _prefix "dateDeleted"
    /// <summary>
    /// To provide the date of digitisation of the Resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateDigitised"></see></summary>
    let dateDigitised = _prefix "dateDigitised"
    /// <summary>
    /// The date when the resource was first made available to the public for purchase, download, or online access.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateDistributed"></see></summary>
    let dateDistributed = _prefix "dateDistributed"
    /// <summary>
    /// The date when the resource was removed from institutional holdings.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateIngested"></see></summary>
    let dateIngested = _prefix "dateIngested"
    /// <summary>
    /// To provide the date of release of the Resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateIssued"></see></summary>
    let dateIssued = _prefix "dateIssued"
    /// <summary>
    /// The date when the license for the resource begins.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateLicenced"></see></summary>
    let dateLicenced = _prefix "dateLicenced"
    /// <summary>
    /// The date when the resource was copied or converted from an obsolete or endangered original format to a more updated format for preservation.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateMigrated"></see></summary>
    let dateMigrated = _prefix "dateMigrated"
    /// <summary>
    /// To indicate the date at which the Resource has been modified.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateModified"></see></summary>
    let dateModified = _prefix "dateModified"
    /// <summary>
    /// The date when the resource was converted from its original format into a format pre-selected by the institution for preservation.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateNormalized"></see></summary>
    let dateNormalized = _prefix "dateNormalized"
    /// <summary>
    /// The date when the resource was moved from one digital or physical location to another.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateTransferred"></see></summary>
    let dateTransferred = _prefix "dateTransferred"
    /// <summary>
    /// The most recent date when the resource was confirmed to be valid through manual or digital QC.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateValidated"></see></summary>
    let dateValidated = _prefix "dateValidated"
    /// <summary>
    /// Identifies a content-based relationship between two resources.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#derivedTo"></see></summary>
    let derivedTo = _prefix "derivedTo"
    /// <summary>
    /// Identifies a content-based relationship between two resources.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isDerivedFrom"></see></summary>
    let isDerivedFrom = _prefix "isDerivedFrom"
    /// <summary>
    /// Describes the physical dimensions of a media resource, with units of measure concatenated to become part of the value.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dimensions"></see></summary>
    let dimensions = _prefix "dimensions"
    /// <summary>
    /// To provide a dopesheet with a title and brief description for news.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dopesheet"></see></summary>
    let dopesheet = _prefix "dopesheet"
    /// <summary>
    /// Identifies relationship between a physical instantiation of a resource and a duplicate physical copy that may involve generational loss.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dubbedTo"></see></summary>
    let dubbedTo = _prefix "dubbedTo"
    /// <summary>
    /// Identifies relationship between a physical instantiation of a resource and a duplicate physical copy that may involve generational loss.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isDubbedFrom"></see></summary>
    let isDubbedFrom = _prefix "isDubbedFrom"
    /// <summary>
    /// To provide information on the duration of a MediaResource. It corresponds to 'duration' in the
    ///             Ontology for Media Resources.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#duration"></see></summary>
    let duration = _prefix "duration"
    /// <summary>
    /// To provide a duration as normal
    ///             time.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#durationNormalPlayTime"></see></summary>
    let durationNormalPlayTime = _prefix "durationNormalPlayTime"
    /// <summary>
    /// To provide a duration as a number of EditUnits
    ///             which value is for instance the inverse of the audio sample rate or video frame
    ///             rate.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#durationNumberEditUnit"></see></summary>
    let durationNumberEditUnit = _prefix "durationNumberEditUnit"
    /// <summary>
    /// To provide information on the published / announced duration of an EditorialObject.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#durationPublished"></see></summary>
    let durationPublished = _prefix "durationPublished"
    /// <summary>
    /// To provide a published duration as normal
    ///             time.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#durationPublishedNormalPlayTime"></see></summary>
    let durationPublishedNormalPlayTime = _prefix "durationPublishedNormalPlayTime"
    /// <summary>
    /// To provide a published duration as a number of EditUnits
    ///             which value is for instance the inverse of the audio sample rate or video frame
    ///             rate.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#durationPublishedNumberEditUnit"></see></summary>
    let durationPublishedNumberEditUnit = _prefix "durationPublishedNumberEditUnit"
    /// <summary>
    /// The published duration expressed as a
    ///             timecode.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#durationPublishedTimecode"></see></summary>
    let durationPublishedTimecode = _prefix "durationPublishedTimecode"
    /// <summary>
    /// The duration expressed as a
    ///             timecode.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#durationTimecode"></see></summary>
    let durationTimecode = _prefix "durationTimecode"
    /// <summary>
    /// The edit unit is e.g. the inverse of the audio
    ///             sample rate or video frame rate.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#editUnit"></see></summary>
    let editUnit = _prefix "editUnit"
    /// <summary>
    /// The encoding level.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#encodingLevel"></see></summary>
    let encodingLevel = _prefix "encodingLevel"
    /// <summary>
    /// The encoding profile
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#encodingProfile"></see></summary>
    let encodingProfile = _prefix "encodingProfile"
    /// <summary>
    /// The start point of the media
    ///             resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#end"></see></summary>
    let end_ = _prefix "end"
    /// <summary>
    /// The date on which the license for the resource expires.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#endLicenceDate"></see></summary>
    let endLicenceDate = _prefix "endLicenceDate"
    /// <summary>
    /// The start time expressed using a time
    ///             expression.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#endNormalPlayTime"></see></summary>
    let endNormalPlayTime = _prefix "endNormalPlayTime"
    /// <summary>
    /// A start time expressed as a number of edit
    ///             units.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#endNumberEditUnits"></see></summary>
    let endNumberEditUnits = _prefix "endNumberEditUnits"
    /// <summary>
    /// A start time expressed as
    ///             timecode.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#endTimecode"></see></summary>
    let endTimecode = _prefix "endTimecode"
    /// <summary>
    /// To provide a deescription for an
    ///             Event.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#eventDescription"></see></summary>
    let eventDescription = _prefix "eventDescription"
    /// <summary>
    /// The duration of an event.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#eventDuration"></see></summary>
    let eventDuration = _prefix "eventDuration"
    /// <summary>
    /// The end date of an Event.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#eventEndDate"></see></summary>
    let eventEndDate = _prefix "eventEndDate"
    /// <summary>
    /// To provide a name for an Event.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#eventName"></see></summary>
    let eventName = _prefix "eventName"
    /// <summary>
    /// The period of time during which an Event has occured.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#eventPeriod"></see></summary>
    let eventPeriod = _prefix "eventPeriod"
    /// <summary>
    /// The start date of an Event.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#eventStartDate"></see></summary>
    let eventStartDate = _prefix "eventStartDate"
    /// <summary>
    /// To provide a family name / last name.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#familyName"></see></summary>
    let familyName = _prefix "familyName"
    /// <summary>
    /// A flag to indicate if an agent of fictitious
    ///             (set to true).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#fictitious"></see></summary>
    let fictitious = _prefix "fictitious"
    /// <summary>
    /// Provides the size of a MediaResource in bytes.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#fileSize"></see></summary>
    let fileSize = _prefix "fileSize"
    /// <summary>
    /// The name of the file containing the
    ///             Resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#filename"></see></summary>
    let filename = _prefix "filename"
    /// <summary>
    /// Provides a user/audience-generated description, tag, or label for resource content.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#folksonomy"></see></summary>
    let folksonomy = _prefix "folksonomy"
    /// <summary>
    /// A link to a an BusinessObject or a Resource preceding the current BusinessObject or Resource in an ordered sequence
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#followsInSequence"></see></summary>
    let followsInSequence = _prefix "followsInSequence"
    /// <summary>
    /// The frame rate of the video signal in frame per second.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#frameRate"></see></summary>
    let frameRate = _prefix "frameRate"
    /// <summary>
    /// The unit used to express the frame width or
    ///             height. The unit by default is 'pixel'.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#frameSizeUnit"></see></summary>
    let frameSizeUnit = _prefix "frameSizeUnit"
    /// <summary>
    /// Identifies the frames per second at which a visual resource should be played back for human consumption.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#framesPerSecond"></see></summary>
    let framesPerSecond = _prefix "framesPerSecond"
    /// <summary>
    /// Identifies the rate of units against time at which the resource should be played back for human consumption.  If the unit of measure is known, use sub-properties framesPerSecond or inchesPerSecond.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#playbackSpeed"></see></summary>
    let playbackSpeed = _prefix "playbackSpeed"
    /// <summary>
    /// To provide the frequency of an AudioChannel filter
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#frequency"></see></summary>
    let frequency = _prefix "frequency"
    /// <summary>
    /// To provide one or more given names.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#givenName"></see></summary>
    let givenName = _prefix "givenName"
    /// <summary>
    /// A textual description of a
    ///             Group.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#groupDescription"></see></summary>
    let groupDescription = _prefix "groupDescription"
    /// <summary>
    /// The name attributed to a Group.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#groupName"></see></summary>
    let groupName = _prefix "groupName"
    /// <summary>
    /// A property to establish the relation between a
    ///             Contact/person and an Organisation.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAffiliation"></see></summary>
    let hasAffiliation = _prefix "hasAffiliation"
    /// <summary>
    /// A property to signal the presence of
    ///             AncillaryData associated with the EditorialObject and / or MediaResource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAncillaryData"></see></summary>
    let hasAncillaryData = _prefix "hasAncillaryData"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAncillaryDataFormat"></see>
    /// </summary>
    let hasAncillaryDataFormat = _prefix "hasAncillaryDataFormat"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasDataFormat"></see>
    /// </summary>
    let hasDataFormat = _prefix "hasDataFormat"
    /// <summary>
    /// A property to signal the presence of Annotation
    ///             information associated with an EditorialObject and / or a MediaResource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAnnotation"></see></summary>
    let hasAnnotation = _prefix "hasAnnotation"
    /// <summary>
    /// To identify the Agent, Contact/person or
    ///             Organisation who has provided the Annotation.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAnnotationSource"></see></summary>
    let hasAnnotationSource = _prefix "hasAnnotationSource"
    /// <summary>
    /// To signal the presence of
    ///             AudioDescription.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAudioDescription"></see></summary>
    let hasAudioDescription = _prefix "hasAudioDescription"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAudioEncodingFormat"></see>
    /// </summary>
    let hasAudioEncodingFormat = _prefix "hasAudioEncodingFormat"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasEncodingFormat"></see>
    /// </summary>
    let hasEncodingFormat = _prefix "hasEncodingFormat"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAudioFormat"></see>
    /// </summary>
    let hasAudioFormat = _prefix "hasAudioFormat"
    /// <summary>
    /// A property to define the Format of a Resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasFormat"></see></summary>
    let hasFormat = _prefix "hasFormat"
    /// <summary>
    /// To signal the presence of
    ///             Captioning.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCaptioning"></see></summary>
    let hasCaptioning = _prefix "hasCaptioning"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCaptioningFormat"></see>
    /// </summary>
    let hasCaptioningFormat = _prefix "hasCaptioningFormat"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCastMember"></see>
    /// </summary>
    let hasCastMember = _prefix "hasCastMember"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCharacter"></see>
    /// </summary>
    let hasCharacter = _prefix "hasCharacter"
    /// <summary>
    /// To identify the Codec with which the Resource has been encoded.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCodec"></see></summary>
    let hasCodec = _prefix "hasCodec"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasColourSpace"></see>
    /// </summary>
    let hasColourSpace = _prefix "hasColourSpace"
    /// <summary>
    /// To provide information on a Contact for an
    ///             Organisation or a physical person (e.g. the agent of an actor).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasContact"></see></summary>
    let hasContact = _prefix "hasContact"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasContainerFormat"></see>
    /// </summary>
    let hasContainerFormat = _prefix "hasContainerFormat"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasContainerMimeType"></see>
    /// </summary>
    let hasContainerMimeType = _prefix "hasContainerMimeType"
    /// <summary>
    /// To provide information on Contacts/persons or
    ///             Organisations who have contributed to the BusinessObject or Resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasContributor"></see></summary>
    let hasContributor = _prefix "hasContributor"
    /// <summary>
    /// A property to identify the Events and or
    ///             Locations, all real or fictional, covered by the
    ///             BusinessObject.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCoverage"></see></summary>
    let hasCoverage = _prefix "hasCoverage"
    /// <summary>
    /// The Location where content has been created.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCreationLocation"></see></summary>
    let hasCreationLocation = _prefix "hasCreationLocation"
    /// <summary>
    /// To identify an Agent involved in the creation of the Resource or BusinessObject.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCreator"></see></summary>
    let hasCreator = _prefix "hasCreator"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCrewMember"></see>
    /// </summary>
    let hasCrewMember = _prefix "hasCrewMember"
    /// <summary>
    /// To identify Departments within an
    ///             Organisation.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasDepartment"></see></summary>
    let hasDepartment = _prefix "hasDepartment"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasDocumentFormat"></see>
    /// </summary>
    let hasDocumentFormat = _prefix "hasDocumentFormat"
    /// <summary>
    /// To associate a Dopesheet with a NewsItem.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasDopesheet"></see></summary>
    let hasDopesheet = _prefix "hasDopesheet"
    /// <summary>
    /// To identify an episode of a
    ///             Series or a Season.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasEpisode"></see></summary>
    let hasEpisode = _prefix "hasEpisode"
    /// <summary>
    /// EditorialObjects can be related to other BusinessOjects, Assets (and associated rights), PublicationEvents(defined when commissioning the EditorialObject before it is instantiated as a Resource (manifestation), or Resources, or Ratings.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedBusinessObject"></see></summary>
    let hasRelatedBusinessObject = _prefix "hasRelatedBusinessObject"
    /// <summary>
    /// The Episode of a Series or a Season.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isEpisodeOf"></see></summary>
    let isEpisodeOf = _prefix "isEpisodeOf"
    /// <summary>
    /// To associate an Event with a
    ///             Location.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasEvent"></see></summary>
    let hasEvent = _prefix "hasEvent"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasFileFormat"></see>
    /// </summary>
    let hasFileFormat = _prefix "hasFileFormat"
    /// <summary>
    /// Identifies the generation of a version of a resource, i.e. master, edit master, distribution copy, etc.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasGeneration"></see></summary>
    let hasGeneration = _prefix "hasGeneration"
    /// <summary>
    /// To define a Genre/category associated to the
    ///             BusinesssObject.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasGenre"></see></summary>
    let hasGenre = _prefix "hasGenre"
    /// <summary>
    /// To define a type of BusinessObject is not declared as a subClass of BusinessObject.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasType"></see></summary>
    let hasType = _prefix "hasType"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasHomepage"></see>
    /// </summary>
    let hasHomepage = _prefix "hasHomepage"
    /// <summary>
    /// To identify a Resource associated with an Asset or a BusinessObject or a PublicationEvent or another Resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedResource"></see></summary>
    let hasRelatedResource = _prefix "hasRelatedResource"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasIdPicture"></see>
    /// </summary>
    let hasIdPicture = _prefix "hasIdPicture"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasImageFormat"></see>
    /// </summary>
    let hasImageFormat = _prefix "hasImageFormat"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasKeyCareerEvent"></see>
    /// </summary>
    let hasKeyCareerEvent = _prefix "hasKeyCareerEvent"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedEvent"></see>
    /// </summary>
    let hasRelatedEvent = _prefix "hasRelatedEvent"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasKeyPersonalEvent"></see>
    /// </summary>
    let hasKeyPersonalEvent = _prefix "hasKeyPersonalEvent"
    /// <summary>
    /// To associate a concept, descriptive phrase or
    ///             Keyword that specifies the topic of the BusinessObject or Annotation.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasKeyword"></see></summary>
    let hasKeyword = _prefix "hasKeyword"
    /// <summary>
    /// To associate a Language to a Resource or
    ///             BusinessObject. A controlled vocabulary based on BCP 47 is recommended. This
    ///             property can also be used to identify the presence of sign language (RFC 5646). By
    ///             inheritance, the hasLanguage property applies indifferently at the MediaResource /
    ///             Fragment / Track levels at which the usage is being defined. Best practice recommends to
    ///             use to best possible level of granularity fo describe the usage of language within a
    ///             MediaResource including at Fragment and Track levels.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasLanguage"></see></summary>
    let hasLanguage = _prefix "hasLanguage"
    /// <summary>
    /// To associate a Location with a BusinessObject.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasLocation"></see></summary>
    let hasLocation = _prefix "hasLocation"
    /// <summary>
    /// Logos can be used in a variety of contexts.
    ///             Logo can be associated with an Organisation or a Service or a PublicationChannel.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasLogo"></see></summary>
    let hasLogo = _prefix "hasLogo"
    /// <summary>
    /// To define Parts (segments, fragments, etc.)
    ///             withiin a MediaResource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasMediaFragment"></see></summary>
    let hasMediaFragment = _prefix "hasMediaFragment"
    /// <summary>
    /// To identify the MediaResource to which the MediaFragment belongs to.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isMediaFragmentOf"></see></summary>
    let isMediaFragmentOf = _prefix "isMediaFragmentOf"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasMedium"></see>
    /// </summary>
    let hasMedium = _prefix "hasMedium"
    /// <summary>
    /// To establish group/collection relationship between EditorialObjects.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasMember"></see></summary>
    let hasMember = _prefix "hasMember"
    /// <summary>
    /// To identify the Agent (Contact/person or
    ///             Organisation) who has created the metadata.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasMetadataAttributor"></see></summary>
    let hasMetadataAttributor = _prefix "hasMetadataAttributor"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasMimeType"></see>
    /// </summary>
    let hasMimeType = _prefix "hasMimeType"
    /// <summary>
    /// To define an ObjectType for the BusinessObject
    ///              (e.g. book, report, programme, clip) if not defined as a subClass of BusinessObject.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasObjectType"></see></summary>
    let hasObjectType = _prefix "hasObjectType"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasOriginalLanguage"></see>
    /// </summary>
    let hasOriginalLanguage = _prefix "hasOriginalLanguage"
    /// <summary>
    /// To define Parts (segments, fragments, etc.)
    ///             within a BusinessObject.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasPart"></see></summary>
    let hasPart = _prefix "hasPart"
    /// <summary>
    /// To provide a visual representation of  TargetAudience or Rating.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasPictogram"></see></summary>
    let hasPictogram = _prefix "hasPictogram"
    /// <summary>
    /// To associate a PublicationEvent with a
    ///             PublicationChannel.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasPublicationChannel"></see></summary>
    let hasPublicationChannel = _prefix "hasPublicationChannel"
    /// <summary>
    /// To associate PublicationEvents with
    ///             PublicationChannels or as elements of a PublicationHistory or PublicationPlanning.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasPublicationEvent"></see></summary>
    let hasPublicationEvent = _prefix "hasPublicationEvent"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasPublicationHistory"></see>
    /// </summary>
    let hasPublicationHistory = _prefix "hasPublicationHistory"
    /// <summary>
    /// To identify an Agent involved in the publication of the Resource or BusinessObject.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasPublisher"></see></summary>
    let hasPublisher = _prefix "hasPublisher"
    /// <summary>
    /// To identify the presence of Rating attributed
    ///             to a Resource or BusinessObject.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRating"></see></summary>
    let hasRating = _prefix "hasRating"
    /// <summary>
    /// To identify an Agent (Contact/person or
    ///             Organisation) who has proposed a Rating.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRatingSource"></see></summary>
    let hasRatingSource = _prefix "hasRatingSource"
    /// <summary>
    /// To associate an AudioChannel with an AudioPack or an AudioStream.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedAudioChannel"></see></summary>
    let hasRelatedAudioChannel = _prefix "hasRelatedAudioChannel"
    /// <summary>
    /// To identify the AudioContent associated with an AudioProgramme.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedAudioContent"></see></summary>
    let hasRelatedAudioContent = _prefix "hasRelatedAudioContent"
    /// <summary>
    /// To identify AudioObjects associated with AudioContent or other AudioObjects.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedAudioObject"></see></summary>
    let hasRelatedAudioObject = _prefix "hasRelatedAudioObject"
    /// <summary>
    /// To associate an AudioStream with an AudioTrack.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedAudioStream"></see></summary>
    let hasRelatedAudioStream = _prefix "hasRelatedAudioStream"
    /// <summary>
    /// To associate an AudioTrack with an AudioStream or an AudioTrackUID.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedAudioTrack"></see></summary>
    let hasRelatedAudioTrack = _prefix "hasRelatedAudioTrack"
    /// <summary>
    /// To associate an Image with a BusinessObject.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedImage"></see></summary>
    let hasRelatedImage = _prefix "hasRelatedImage"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedLocation"></see>
    /// </summary>
    let hasRelatedLocation = _prefix "hasRelatedLocation"
    /// <summary>
    /// To associate a Part of an EditorialObject with a MediaFragment within the association MediaResource instantiating the EditorialObject.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedMediaFragment"></see></summary>
    let hasRelatedMediaFragment = _prefix "hasRelatedMediaFragment"
    /// <summary>
    /// To associate a Picture with a BusinessObject or a Resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedPicture"></see></summary>
    let hasRelatedPicture = _prefix "hasRelatedPicture"
    /// <summary>
    /// To identify the PublicationEvent associated with a MediaResource (manifestation of an EditorialObject).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedPublicationEvent"></see></summary>
    let hasRelatedPublicationEvent = _prefix "hasRelatedPublicationEvent"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRights"></see>
    /// </summary>
    let hasRights = _prefix "hasRights"
    /// <summary>
    /// To identify a Contact/person who can provide
    ///             assistance / guidance regarding the associated Rights.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRightsContact"></see></summary>
    let hasRightsContact = _prefix "hasRightsContact"
    /// <summary>
    /// To identify an Agent (Contact/person or
    ///             Organisation) having/managing Rights.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRightsHolder"></see></summary>
    let hasRightsHolder = _prefix "hasRightsHolder"
    /// <summary>
    /// To define the role of an Agent (Contact/person
    ///             or Organisation). The association in a particular context is made by declaring the hasCastRole  associated with the BusinessObject.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRole"></see></summary>
    let hasRole = _prefix "hasRole"
    /// <summary>
    /// The Season of a Series.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasSeason"></see></summary>
    let hasSeason = _prefix "hasSeason"
    /// <summary>
    /// The Season of a Series.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isSeasonOf"></see></summary>
    let isSeasonOf = _prefix "isSeasonOf"
    /// <summary>
    /// To identify the presence of Signing associated
    ///             to the BusinessObject/Resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasSigning"></see></summary>
    let hasSigning = _prefix "hasSigning"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasSigningFormat"></see>
    /// </summary>
    let hasSigningFormat = _prefix "hasSigningFormat"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasVideoFormat"></see>
    /// </summary>
    let hasVideoFormat = _prefix "hasVideoFormat"
    /// <summary>
    /// To identify a Resource as the source of another Resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasSource"></see></summary>
    let hasSource = _prefix "hasSource"
    /// <summary>
    /// To identify staff working within an Organisation.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasStaff"></see></summary>
    let hasStaff = _prefix "hasStaff"
    /// <summary>
    /// Identifies the technical video standard of a resource, i.e. NTSC or PAL.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasStandard"></see></summary>
    let hasStandard = _prefix "hasStandard"
    /// <summary>
    /// To define a particular type of storage /
    ///             repository associated with the Locator from where a Resource can be
    ///             accessed.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasStorageType"></see></summary>
    let hasStorageType = _prefix "hasStorageType"
    /// <summary>
    /// To associate a Subject addressed with a
    ///             BusinessObject / Resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasSubject"></see></summary>
    let hasSubject = _prefix "hasSubject"
    /// <summary>
    /// To signal the presence of Subtitling associated
    ///             with the EditorialObject or MediaResource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasSubtitling"></see></summary>
    let hasSubtitling = _prefix "hasSubtitling"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasSubtitlingFormat"></see>
    /// </summary>
    let hasSubtitlingFormat = _prefix "hasSubtitlingFormat"
    /// <summary>
    /// To associate a TargetAudience (e.g. for
    ///             parental guiddance or targeting a particular social group) with a
    ///             BusinessObject/Resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasTargetAudience"></see></summary>
    let hasTargetAudience = _prefix "hasTargetAudience"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasTheme"></see>
    /// </summary>
    let hasTheme = _prefix "hasTheme"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasTopic"></see>
    /// </summary>
    let hasTopic = _prefix "hasTopic"
    /// <summary>
    /// To associate audio/data/video tracks with a MediaResource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasTrack"></see></summary>
    let hasTrack = _prefix "hasTrack"
    /// <summary>
    /// To identify another version of an Asset, BusinessObject or Resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasVersion"></see></summary>
    let hasVersion = _prefix "hasVersion"
    /// <summary>
    /// To identify related versions.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isVersionOf"></see></summary>
    let isVersionOf = _prefix "isVersionOf"
    /// <summary>
    ///   <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasVideoEncodingFormat"></see>
    /// </summary>
    let hasVideoEncodingFormat = _prefix "hasVideoEncodingFormat"
    /// <summary>
    /// The hash value associated to a Resource. There
    ///             are different methods / algorithms to calculate hash values, which can be defined as
    ///             subproperties.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hashValue"></see></summary>
    let hashValue = _prefix "hashValue"
    /// <summary>
    /// The height of e.g. a video frame typically
    ///             expressed as a number of lines or the height of a picture/image expressed in millimeters
    ///             or else.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#height"></see></summary>
    let height = _prefix "height"
    /// <summary>
    /// The unit used to measure a Height e.g. in
    ///             pixels or number of lines or millimeters or else.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#heightUnit"></see></summary>
    let heightUnit = _prefix "heightUnit"
    /// <summary>
    /// The high pass frequency of the AudioChannel filter.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#highPass"></see></summary>
    let highPass = _prefix "highPass"
    /// <summary>
    /// To provide highlights.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#highlights"></see></summary>
    let highlights = _prefix "highlights"
    /// <summary>
    /// To identify a BusinessObject or Resource on
    ///             which an Agent (Contact/person or Organisation) holds Rights.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#holdsRightsOver"></see></summary>
    let holdsRightsOver = _prefix "holdsRightsOver"
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
    let identifier = _prefix "identifier"
    /// <summary>
    /// Identifies the inches per second at which an analog audio tape should be played back for human consumption.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#inchesPerSecond"></see></summary>
    let inchesPerSecond = _prefix "inchesPerSecond"
    /// <summary>
    /// To link a particular manifestation of a
    ///             BusinessObject to the corresponding Resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#instantiates"></see></summary>
    let instantiates = _prefix "instantiates"
    /// <summary>
    /// To identify a Contact/person or Organisation as part of a cast list.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isAgent"></see></summary>
    let isAgent = _prefix "isAgent"
    /// <summary>
    /// To identify the character personified by a Cast individual.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isCharacter"></see></summary>
    let isCharacter = _prefix "isCharacter"
    /// <summary>
    /// Copyright statement.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isCopyrightedBy"></see></summary>
    let isCopyrightedBy = _prefix "isCopyrightedBy"
    /// <summary>
    /// The Rights or policy applicable to the
    ///             BusinessObject, Asset, Resource or PublicationEvent.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isCoveredBy"></see></summary>
    let isCoveredBy = _prefix "isCoveredBy"
    /// <summary>
    /// To identify Contact/persons being fictitious.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isFictitiousContact"></see></summary>
    let isFictitiousContact = _prefix "isFictitiousContact"
    /// <summary>
    /// To identify a Group to which an EidtorialObject is a member of.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isMemberOf"></see></summary>
    let isMemberOf = _prefix "isMemberOf"
    /// <summary>
    /// A link to a an BusinessObject or a Resource following the current BusinessObject or Resource in an ordered sequence
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isNextInSequence"></see></summary>
    let isNextInSequence = _prefix "isNextInSequence"
    /// <summary>
    /// To identify the Service that operates the
    ///             PublicationChannel.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isOperatedBy"></see></summary>
    let isOperatedBy = _prefix "isOperatedBy"
    /// <summary>
    /// To identify the Agent (Contact/person or
    ///             Organisation) who owns a Service operating a PublicationChannel.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isOwnedBy"></see></summary>
    let isOwnedBy = _prefix "isOwnedBy"
    /// <summary>
    /// To express references across Assets, BusinessObjects or Resources.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isReferencedBy"></see></summary>
    let isReferencedBy = _prefix "isReferencedBy"
    /// <summary>
    /// To establish relationships between Assets,
    ///             BusinessObjects, PublicationEvents, Ratings and Resources.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isRelatedTo"></see></summary>
    let isRelatedTo = _prefix "isRelatedTo"
    /// <summary>
    /// To identify substitutions.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isReplacedBy"></see></summary>
    let isReplacedBy = _prefix "isReplacedBy"
    /// <summary>
    /// To express strong relations between Assets, BusinessObjects or Resources.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isRequiredBy"></see></summary>
    let isRequiredBy = _prefix "isRequiredBy"
    /// <summary>
    /// To provide a definition for a Keyword.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#keywordDefinition"></see></summary>
    let keywordDefinition = _prefix "keywordDefinition"
    /// <summary>
    /// To provide the number of the line on which
    ///             ancillary data is being carried and the equivalent in the digital domain.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#lineNumber"></see></summary>
    let lineNumber = _prefix "lineNumber"
    /// <summary>
    /// To provide the address of a
    ///            Location.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationAddress"></see></summary>
    let locationAddress = _prefix "locationAddress"
    /// <summary>
    /// To provide the Area part of an
    ///             Adrress.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationAddressArea"></see></summary>
    let locationAddressArea = _prefix "locationAddressArea"
    /// <summary>
    /// To provide the country name and or country
    ///             code.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationAddressCountry"></see></summary>
    let locationAddressCountry = _prefix "locationAddressCountry"
    /// <summary>
    /// To write address line with e.g. the street name
    ///             and number.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationAddressLine"></see></summary>
    let locationAddressLine = _prefix "locationAddressLine"
    /// <summary>
    /// To provide the name of a city, viallge,
    ///             etc.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationAddressLocality"></see></summary>
    let locationAddressLocality = _prefix "locationAddressLocality"
    /// <summary>
    /// To provide an address postal
    ///             code.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationAddressPostalCode"></see></summary>
    let locationAddressPostalCode = _prefix "locationAddressPostalCode"
    /// <summary>
    /// To define the altitude of a Location in
    ///             meters.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationAltitude"></see></summary>
    let locationAltitude = _prefix "locationAltitude"
    /// <summary>
    /// To specify the name of the gps coordinate
    ///             system used for the Location.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationCoordinateSystemName"></see></summary>
    let locationCoordinateSystemName = _prefix "locationCoordinateSystemName"
    /// <summary>
    /// To provide a description of a particular Location.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationDescription"></see></summary>
    let locationDescription = _prefix "locationDescription"
    /// <summary>
    /// The latitude of the Location.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationLatitude"></see></summary>
    let locationLatitude = _prefix "locationLatitude"
    /// <summary>
    /// To define the longitude of the
    ///             Location.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationLongitude"></see></summary>
    let locationLongitude = _prefix "locationLongitude"
    /// <summary>
    /// The name by which a Location is
    ///             known.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationName"></see></summary>
    let locationName = _prefix "locationName"
    /// <summary>
    /// To provide a description of a particular region assocoated to the Location.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationRegion"></see></summary>
    let locationRegion = _prefix "locationRegion"
    /// <summary>
    /// Information about storage accessed by the locator.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locatorTargetInformation"></see></summary>
    let locatorTargetInformation = _prefix "locatorTargetInformation"
    /// <summary>
    /// The value for integrated loudness measured at AudioProgramme or AudioContent level.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#loudnessIntegratedLoudness"></see></summary>
    let loudnessIntegratedLoudness = _prefix "loudnessIntegratedLoudness"
    /// <summary>
    /// All the parameters for measurement of loudness at the AudioContent or AudioProgramme level.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#loudnessParameters"></see></summary>
    let loudnessParameters = _prefix "loudnessParameters"
    /// <summary>
    /// The value for maximum momentary loudness measured at AudioProgramme or AudioContent level.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#loudnessMaxMomentary"></see></summary>
    let loudnessMaxMomentary = _prefix "loudnessMaxMomentary"
    /// <summary>
    /// The value for maximum true peak loudness measured at AudioProgramme or AudioContent level.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#loudnessMaxTruepeak"></see></summary>
    let loudnessMaxTruepeak = _prefix "loudnessMaxTruepeak"
    /// <summary>
    /// The method for loudness measurement at AudioProgramme or AudioContent level.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#loudnessMethod"></see></summary>
    let loudnessMethod = _prefix "loudnessMethod"
    /// <summary>
    /// The loudness range measured at AudioProgramme or AudioContent level.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#loudnessRange"></see></summary>
    let loudnessRange = _prefix "loudnessRange"
    /// <summary>
    /// The maximum short term loudness measured at AudioProgramme or AudioContent level.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#lounessMaxShortTerm"></see></summary>
    let lounessMaxShortTerm = _prefix "lounessMaxShortTerm"
    /// <summary>
    /// The low pass frequency of the AudioChannel filter.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#lowPass"></see></summary>
    let lowPass = _prefix "lowPass"
    /// <summary>
    /// To provide the main title by which the media
    ///             resource is known.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#mainTitle"></see></summary>
    let mainTitle = _prefix "mainTitle"
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
    let title = _prefix "title"
    /// <summary>
    /// To provide a salutation title e.g M. Ms, Dr, Pr.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#nameTitle"></see></summary>
    let nameTitle = _prefix "nameTitle"
    /// <summary>
    /// A flag to signal that a noise filter has been
    ///             used.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#noiseFilter"></see></summary>
    let noiseFilter = _prefix "noiseFilter"
    /// <summary>
    /// A flag to indicate that the BusinessObejct has not been rated.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#notRated"></see></summary>
    let notRated = _prefix "notRated"
    /// <summary>
    /// The number of Tracks composing the MediaResource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#numberOfTracks"></see></summary>
    let numberOfTracks = _prefix "numberOfTracks"
    /// <summary>
    /// To provide a definition of an AudioObject type.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#objectTypeDefinition"></see></summary>
    let objectTypeDefinition = _prefix "objectTypeDefinition"
    /// <summary>
    /// To provide the Area part of an
    ///             Address.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeAddressArea"></see></summary>
    let officeAddressArea = _prefix "officeAddressArea"
    /// <summary>
    /// To provide the professional / office address of
    ///             an agent (Contact/person or organisation).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeMailAddress"></see></summary>
    let officeMailAddress = _prefix "officeMailAddress"
    /// <summary>
    /// To provide the country name and or country
    ///             code.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeAddressCountry"></see></summary>
    let officeAddressCountry = _prefix "officeAddressCountry"
    /// <summary>
    /// To write address line with e.g. the street name
    ///             and number.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeAddressLine"></see></summary>
    let officeAddressLine = _prefix "officeAddressLine"
    /// <summary>
    /// To provide the name of a city, village,
    ///             etc.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeAddressLocality"></see></summary>
    let officeAddressLocality = _prefix "officeAddressLocality"
    /// <summary>
    /// To provide an address postal
    ///             code.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeAddressPostalCode"></see></summary>
    let officeAddressPostalCode = _prefix "officeAddressPostalCode"
    /// <summary>
    /// To provide the professional/office email
    ///             address of an agent (Contact/person or organisation).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeEmailAddress"></see></summary>
    let officeEmailAddress = _prefix "officeEmailAddress"
    /// <summary>
    /// To provide an office/professional/company web
    ///             homepage of an Agent (Contact/person or Organisation).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeHomepage"></see></summary>
    let officeHomepage = _prefix "officeHomepage"
    /// <summary>
    /// To provide the professional/office/company
    ///             mobile telephone number of an agent (Contact/person or organisation).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeMobileTelephoneNumber"></see></summary>
    let officeMobileTelephoneNumber = _prefix "officeMobileTelephoneNumber"
    /// <summary>
    /// To provide an office/professional/company
    ///             telephone number of an Agent (Contact/person or Organisation).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeTelephoneNumber"></see></summary>
    let officeTelephoneNumber = _prefix "officeTelephoneNumber"
    /// <summary>
    /// To provide the full name of an Organisation.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#organisationName"></see></summary>
    let organisationName = _prefix "organisationName"
    /// <summary>
    /// The orientation of a Document or an Image i.e. landscape or
    ///             portrait.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#orientation"></see></summary>
    let orientation = _prefix "orientation"
    /// <summary>
    /// To provide the original title attributed to the
    ///             media resource e.g. in its original language.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#originalTitle"></see></summary>
    let originalTitle = _prefix "originalTitle"
    /// <summary>
    /// To identify the service (s) that an Agent
    ///             (Contact/person or Organisation) owns.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#owns"></see></summary>
    let owns = _prefix "owns"
    /// <summary>
    /// The size of a media package in
    ///             Bytes.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#packageByteSize"></see></summary>
    let packageByteSize = _prefix "packageByteSize"
    /// <summary>
    /// The name attributed to a
    ///             package.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#packageName"></see></summary>
    let packageName = _prefix "packageName"
    /// <summary>
    /// A definition associated with the Part.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#partDefinition"></see></summary>
    let partDefinition = _prefix "partDefinition"
    /// <summary>
    /// A name by which the Part is identified.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#partName"></see></summary>
    let partName = _prefix "partName"
    /// <summary>
    /// The number associated to a Part as one among
    ///             many.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#partNumber"></see></summary>
    let partNumber = _prefix "partNumber"
    /// <summary>
    /// The total number of Parts associated with a
    ///             BusinessObject.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#partTotalNumber"></see></summary>
    let partTotalNumber = _prefix "partTotalNumber"
    /// <summary>
    /// To describe a playlist.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#playlist"></see></summary>
    let playlist = _prefix "playlist"
    /// <summary>
    /// To provide the Area part of an
    ///             Adrress.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateAddressArea"></see></summary>
    let privateAddressArea = _prefix "privateAddressArea"
    /// <summary>
    /// To provide the private / personal address of an
    ///             agent (Contact/person).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateMailAddress"></see></summary>
    let privateMailAddress = _prefix "privateMailAddress"
    /// <summary>
    /// To provide the country name and or country
    ///             code.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateAddressCountry"></see></summary>
    let privateAddressCountry = _prefix "privateAddressCountry"
    /// <summary>
    /// To write address line with e.g. the street name
    ///             and number.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateAddressLine"></see></summary>
    let privateAddressLine = _prefix "privateAddressLine"
    /// <summary>
    /// To provide the name of a city, viallge,
    ///             etc.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateAddressLocality"></see></summary>
    let privateAddressLocality = _prefix "privateAddressLocality"
    /// <summary>
    /// To provide an address postal
    ///             code.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateAddressPostalCode"></see></summary>
    let privateAddressPostalCode = _prefix "privateAddressPostalCode"
    /// <summary>
    /// To provide the private email address of an
    ///             agent (Contact/person)
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateEmailAddress"></see></summary>
    let privateEmailAddress = _prefix "privateEmailAddress"
    /// <summary>
    /// To provide an private web homepage of an Agent
    ///             (Contact/person).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateHomepage"></see></summary>
    let privateHomepage = _prefix "privateHomepage"
    /// <summary>
    /// To provide the private mobile telephone number
    ///             of an agent (Contact/person).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateMobileTelephoneNumber"></see></summary>
    let privateMobileTelephoneNumber = _prefix "privateMobileTelephoneNumber"
    /// <summary>
    /// To provide the private telephone number of an
    ///             Agent (Contact/person).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateTelephoneNumber"></see></summary>
    let privateTelephoneNumber = _prefix "privateTelephoneNumber"
    /// <summary>
    /// To provide textual promotional information.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#promotionalInformation"></see></summary>
    let promotionalInformation = _prefix "promotionalInformation"
    /// <summary>
    /// To indicate a publication status.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#pubStatus"></see></summary>
    let pubStatus = _prefix "pubStatus"
    /// <summary>
    /// To provide a name to a PublicationChannel e.g. a TV channel or website.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publicationChannelName"></see></summary>
    let publicationChannelName = _prefix "publicationChannelName"
    /// <summary>
    /// The actual end date and time of a PublicationEvent.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publicationEndDateTime"></see></summary>
    let publicationEndDateTime = _prefix "publicationEndDateTime"
    /// <summary>
    /// To provide a name to a PublicationEvent.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publicationEventName"></see></summary>
    let publicationEventName = _prefix "publicationEventName"
    /// <summary>
    /// To express specifically the schedule date to which a PublicationEvent is related in particular if the broacdast time is after midnight. For example, the schedule date would be May 29th and the programme is published at 1 am on May 30th, while still associated in the schedule with the night of May 29th.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publicationScheduleDate"></see></summary>
    let publicationScheduleDate = _prefix "publicationScheduleDate"
    /// <summary>
    /// The actual start date and time of a PublicationEvent.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publicationStartDateTime"></see></summary>
    let publicationStartDateTime = _prefix "publicationStartDateTime"
    /// <summary>
    /// The end date and time of a PublicationEvent as
    ///             scheduled.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publishedEndDateTime"></see></summary>
    let publishedEndDateTime = _prefix "publishedEndDateTime"
    /// <summary>
    /// The start date and time of a PublicationEvent
    ///             as scheduled.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publishedStartDateTime"></see></summary>
    let publishedStartDateTime = _prefix "publishedStartDateTime"
    /// <summary>
    /// The title used to identify the work at publication time.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publishedTitle"></see></summary>
    let publishedTitle = _prefix "publishedTitle"
    /// <summary>
    /// The maximum value of the scale used for rating
    ///             a media resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ratingScaleMax"></see></summary>
    let ratingScaleMax = _prefix "ratingScaleMax"
    /// <summary>
    /// The minimum value of the scale used for rating
    ///             a Resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ratingScaleMin"></see></summary>
    let ratingScaleMin = _prefix "ratingScaleMin"
    /// <summary>
    /// To identify the environment in which rating applies.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ratingSystemEnvironment"></see></summary>
    let ratingSystemEnvironment = _prefix "ratingSystemEnvironment"
    /// <summary>
    /// To identify a rating system by its name.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ratingSystemName"></see></summary>
    let ratingSystemName = _prefix "ratingSystemName"
    /// <summary>
    /// To express a free text rating value defined in
    ///             a rating classification scheme.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ratingValue"></see></summary>
    let ratingValue = _prefix "ratingValue"
    /// <summary>
    /// To provide a reason for which Rating as been attributed as provided.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#reason"></see></summary>
    let reason = _prefix "reason"
    /// <summary>
    /// To express a reference between Assets, BusinessObjects or Resources.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#references"></see></summary>
    let references = _prefix "references"
    /// <summary>
    /// To define the bottom right corner of a zone on
    ///             the x-axis. If present with regionDelimY, the zone definition is complemented by the
    ///             associated values of the height and width.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#regionDelimX"></see></summary>
    let regionDelimX = _prefix "regionDelimX"
    /// <summary>
    /// To define the bottom right corner of a zone on
    ///             the y-axis. If present with regionDelimX, the zone definition is complemented by the
    ///             associated values of the height and width.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#regionDelimY"></see></summary>
    let regionDelimY = _prefix "regionDelimY"
    /// <summary>
    /// To provide a link to a web resource containing
    ///             information related to an Agent (Contact/person or Organisation).
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#relatedLink"></see></summary>
    let relatedLink = _prefix "relatedLink"
    /// <summary>
    /// To identify substitution.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#replaces"></see></summary>
    let replaces = _prefix "replaces"
    /// <summary>
    /// To express dependency.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#requires"></see></summary>
    let requires = _prefix "requires"
    /// <summary>
    /// This can be specialised by using sub-properties
    ///             like defined in http://www.ebu.ch/metadata/cs/web/ebu_DescriptionTypeCodeCS_p.xml.htm
    ///             implemented as examples as e.g. 'summary' or
    ///             'script'.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#resourceDescription"></see></summary>
    let resourceDescription = _prefix "resourceDescription"
    /// <summary>
    /// A name by which the resource can be identified.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#resourceName"></see></summary>
    let resourceName = _prefix "resourceName"
    /// <summary>
    /// To provide a text for a review.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#review"></see></summary>
    let review = _prefix "review"
    /// <summary>
    /// The expression of Rights as free
    ///             text.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#rightsExpression"></see></summary>
    let rightsExpression = _prefix "rightsExpression"
    /// <summary>
    /// A link to e.g. a webpage where an expression of
    ///             the rights can be found and consulted.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#rightsLink"></see></summary>
    let rightsLink = _prefix "rightsLink"
    /// <summary>
    /// To provide a definition for a role
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#roleDefinition"></see></summary>
    let roleDefinition = _prefix "roleDefinition"
    /// <summary>
    /// The frequency at which audio is sampled per second. Also called sampling rate.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#sampleRate"></see></summary>
    let sampleRate = _prefix "sampleRate"
    /// <summary>
    /// The size of an audio sample in
    ///             bits. Also called bit depth.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#sampleSize"></see></summary>
    let sampleSize = _prefix "sampleSize"
    /// <summary>
    /// The type of audio sample.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#sampleType"></see></summary>
    let sampleType = _prefix "sampleType"
    /// <summary>
    /// To define the scanning format for a
    ///             MediaResource. For video, the two main values are "interlaced" or
    ///             "progressive".
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#scanningFormat"></see></summary>
    let scanningFormat = _prefix "scanningFormat"
    /// <summary>
    /// To provide a script.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#script"></see></summary>
    let script = _prefix "script"
    /// <summary>
    /// Provides a shot-by-shot description of resource content.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#shotlog"></see></summary>
    let shotlog = _prefix "shotlog"
    /// <summary>
    /// To identify the source of the signing
    ///             resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#signingSource"></see></summary>
    let signingSource = _prefix "signingSource"
    /// <summary>
    /// The start point of the MediaResource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#start"></see></summary>
    let start = _prefix "start"
    /// <summary>
    /// The start time expressed using a time
    ///             expression.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#startNormalPlayTime"></see></summary>
    let startNormalPlayTime = _prefix "startNormalPlayTime"
    /// <summary>
    /// A start time expressed as a number of edit
    ///             units.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#startNumberEditUnits"></see></summary>
    let startNumberEditUnits = _prefix "startNumberEditUnits"
    /// <summary>
    /// A start time expressed as
    ///             timecode.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#startTimecode"></see></summary>
    let startTimecode = _prefix "startTimecode"
    /// <summary>
    /// To provide a definition for storage.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#storageDefinition"></see></summary>
    let storageDefinition = _prefix "storageDefinition"
    /// <summary>
    /// A complementary subtitle.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#subtitle"></see></summary>
    let subtitle = _prefix "subtitle"
    /// <summary>
    /// To identify the source of the Subtitling
    ///             resource.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#subtitlingSource"></see></summary>
    let subtitlingSource = _prefix "subtitlingSource"
    /// <summary>
    /// To provide a summary.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#summary"></see></summary>
    let summary = _prefix "summary"
    /// <summary>
    /// To provide a summary.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#synopsis"></see></summary>
    let synopsis = _prefix "synopsis"
    /// <summary>
    /// To provide a Table of Content.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#tableOfContent"></see></summary>
    let tableOfContent = _prefix "tableOfContent"
    /// <summary>
    /// To define the system used to provide a TargetAudience.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#targetAudienceSystem"></see></summary>
    let targetAudienceSystem = _prefix "targetAudienceSystem"
    /// <summary>
    /// The value of an Annotation as free
    ///             text.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#textualAnnotation"></see></summary>
    let textualAnnotation = _prefix "textualAnnotation"
    /// <summary>
    /// To provide a definition associated to a
    ///             Track.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#trackDefinition"></see></summary>
    let trackDefinition = _prefix "trackDefinition"
    /// <summary>
    /// The name attributed to a Track.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#trackName"></see></summary>
    let trackName = _prefix "trackName"
    /// <summary>
    /// A translated version of the title.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#translationTitle"></see></summary>
    let translationTitle = _prefix "translationTitle"
    /// <summary>
    /// An alternative title specific to a verison of content.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#versionTitle"></see></summary>
    let versionTitle = _prefix "versionTitle"
    /// <summary>
    /// The width of e.g. a video frame typically
    ///             expressed as a number of pixels, or picture/image in millimeters.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#width"></see></summary>
    let width = _prefix "width"
    /// <summary>
    /// The unit used to measure a width e.g. in pixels
    ///             or number of lines or millimeters or else.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#widthUnit"></see></summary>
    let widthUnit = _prefix "widthUnit"
    /// <summary>
    /// The number of words contained in a
    ///             document.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#wordCount"></see></summary>
    let wordCount = _prefix "wordCount"
    /// <summary>
    /// A title used while content is not complete.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#workingTitle"></see></summary>
    let workingTitle = _prefix "workingTitle"
    /// <summary>
    /// To provide additional information on the
    ///             wrapping type of ancillary data.
    /// <see href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#wrappingType"></see></summary>
    let wrappingType = _prefix "wrappingType"
