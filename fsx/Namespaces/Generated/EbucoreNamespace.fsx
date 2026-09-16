#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ebucore =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#" "ebucore"

    /// <summary>
    ///   <para>rdfs:comment : The conditions under which content can be accessed.</para>
    ///   <para>rdfs:label : Access conditions</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AccessConditions">ebucore:AccessConditions</a>
    /// </summary>
    let AccessConditions = _prefixId.prefix "AccessConditions"
    /// <summary>
    ///   <para>rdfs:label : Affiliation</para>
    ///   <para>rdfs:comment : An Organisation to which a Contact is affiliated (with period of validity).</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Affiliation">ebucore:Affiliation</a>
    /// </summary>
    let Affiliation = _prefixId.prefix "Affiliation"
    /// <summary>
    ///   <para>rdfs:comment : A person / contact or organisation.</para>
    ///   <para>rdfs:label : Agent</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Agent">ebucore:Agent</a>
    /// </summary>
    let Agent = _prefixId.prefix "Agent"
    /// <summary>
    ///   <para>rdfs:label : Ancillary data</para>
    ///   <para>rdfs:comment : Any ancillary data provided with the content
    ///             other than captioning and subtitling.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AncillaryData">ebucore:AncillaryData</a>
    /// </summary>
    let AncillaryData = _prefixId.prefix "AncillaryData"
    /// <summary>
    ///   <para>rdfs:comment : To define the format of AncillaryData such as
    ///             legacy data used to be carried in vertical blanking intervals. This is provided as free
    ///             text in an annotation label or as an identifier pointing to a term in a classification
    ///             scheme.</para>
    ///   <para>rdfs:label : Ancillary data format</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AncillaryDataFormat">ebucore:AncillaryDataFormat</a>
    /// </summary>
    let AncillaryDataFormat = _prefixId.prefix "AncillaryDataFormat"
    /// <summary>
    ///   <para>rdfs:label : Annotation</para>
    ///   <para>rdfs:comment : A set of descriptive or technical metadata.
    ///             Annotation can also be made in the form of a document or media resource such as an or
    ///             video audio file . An annotation can exist on its own and be related / associated to
    ///             other editorial objects or resources.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Annotation">ebucore:Annotation</a>
    /// </summary>
    let Annotation = _prefixId.prefix "Annotation"
    /// <summary>
    ///   <para>rdfs:label : Asset</para>
    ///   <para>rdfs:comment : The Class "Asset" is an
    ///             object to which an identifier will be associated at commissioning. It will serve as a
    ///             central reference point to manage rights associated to EditorialObjects, Resources,
    ///             MediaResources or Essences, and PublicationEvents (distribution and exploitation
    ///             conditions).</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Asset">ebucore:Asset</a>
    /// </summary>
    let Asset = _prefixId.prefix "Asset"
    /// <summary>
    ///   <para>rdfs:label : Audience rating</para>
    ///   <para>rdfs:comment : The audience by which the Resource can be
    ///             seen according to ratings like MPAA  (http://en.wikipedia.org/wiki/Motion_picture_rating_system) or other organisational / national / local standards.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudienceRating">ebucore:AudienceRating</a>
    /// </summary>
    let AudienceRating = _prefixId.prefix "AudienceRating"
    /// <summary>
    ///   <para>rdfs:label : Audio channel^^xsd:string</para>
    ///   <para>rdfs:comment : An audioChannel represents a single sequence of audio samples. It
    /// 				is sub-divided in the time domain into audioBlocks, which is must contain at
    /// 				least one of. The typeDefintion of the audioChannel format specifies the type of
    /// 				audio it is describing, and also determines which parameters are used within its
    /// 				audioBlock children.^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioChannel">ebucore:AudioChannel</a>
    /// </summary>
    let AudioChannel = _prefixId.prefix "AudioChannel"
    /// <summary>
    ///   <para>rdfs:comment : An audioContent defines one component of a programme (e.g. background
    /// 				music), its association with an audioGroup (e.g. a 2.0 audioPackFormat of
    /// 				audioChannelFormats for stereo reproduction), its association with an
    /// 				audioStreamFormat, and its set of loudness parameters.</para>
    ///   <para>rdfs:label : Audio content</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioContent">ebucore:AudioContent</a>
    /// </summary>
    let AudioContent = _prefixId.prefix "AudioContent"
    /// <summary>
    ///   <para>rdfs:label : Audio description^^xsd:string</para>
    ///   <para>skos:prefLabel : Audio description^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioDescription">ebucore:AudioDescription</a>
    /// </summary>
    let AudioDescription = _prefixId.prefix "AudioDescription"
    /// <summary>
    ///   <para>rdfs:label : Audio encoding format</para>
    ///   <para>rdfs:comment : The encoding format for the audio.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioEncodingFormat">ebucore:AudioEncodingFormat</a>
    /// </summary>
    let AudioEncodingFormat = _prefixId.prefix "AudioEncodingFormat"
    /// <summary>
    ///   <para>rdfs:comment : The technical characteristics of an
    ///             AudioResource such as the sampleRate. This is provided as free text in an annotation
    ///             label or as an identifier pointing to a term in a classification scheme e.g.
    ///             http://www.ebu.ch/metadata/ontologies/skos/ebu_AudioFormatCodeCS.rdf.</para>
    ///   <para>rdfs:label : Audio Format</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioFormat">ebucore:AudioFormat</a>
    /// </summary>
    let AudioFormat = _prefixId.prefix "AudioFormat"
    /// <summary>
    ///   <para>rdfs:label : Audio pack format</para>
    ///   <para>rdfs:comment : The format of an AudioPack. Examples of audioPackFormats are 'stereo' and '5.1' for channel-based formats.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioPackFormat">ebucore:AudioPackFormat</a>
    /// </summary>
    let AudioPackFormat = _prefixId.prefix "AudioPackFormat"
    /// <summary>
    ///   <para>rdfs:comment : A set of one or more audioContent that derive from the same material,
    /// 				i.e. an audioMultiplex, and the definition of its multiplexed audioContents (e.g.
    /// 				foreground and commentary, background music).</para>
    ///   <para>rdfs:label : Audio programme</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioProgramme">ebucore:AudioProgramme</a>
    /// </summary>
    let AudioProgramme = _prefixId.prefix "AudioProgramme"
    /// <summary>
    ///   <para>rdfs:label : Audio stream</para>
    ///   <para>rdfs:comment : An audioStreamFormat describes a decodable signal - PCM signal or a Dolby E stream for example. It is composed of one or more AudioTracks.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioStream">ebucore:AudioStream</a>
    /// </summary>
    let AudioStream = _prefixId.prefix "AudioStream"
    /// <summary>
    ///   <para>rdfs:label : Audio stream format</para>
    ///   <para>rdfs:comment : The format of an AudioStream, e.g. PCM_FrontLeft or Dolby E.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioStreamFormat">ebucore:AudioStreamFormat</a>
    /// </summary>
    let AudioStreamFormat = _prefixId.prefix "AudioStreamFormat"
    /// <summary>
    ///   <para>rdfs:label : Audio track</para>
    ///   <para>rdfs:comment : An audioTrack object defines a component of an audioStream.
    /// 				A single set of samples or data in the storage medium.rdfs:comment : Represents a physical container or carrier to hold an audio stream. This
    /// 				should be usually defined by many attributes such as ID, format (e.g. 48 kHz/24
    /// 				bits), linkage information (e.g. odd/even)…rdfs:comment : An audioTrack is the basic audio data container of a medium. Attribute is
    /// 				an unambiguous reference to this container in a given medium.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioTrack">ebucore:AudioTrack</a>
    /// </summary>
    let AudioTrack = _prefixId.prefix "AudioTrack"
    /// <summary>
    ///   <para>rdfs:label : Audio track format</para>
    ///   <para>rdfs:comment : The format of an AudioTrack e.g. PCM_FrontLeft.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioTrackFormat">ebucore:AudioTrackFormat</a>
    /// </summary>
    let AudioTrackFormat = _prefixId.prefix "AudioTrackFormat"
    /// <summary>
    ///   <para>skos:prefLabel : Bibliographical object^^xsd:string</para>
    ///   <para>rdfs:label : Bibliographical object^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#BibliographicalObject">ebucore:BibliographicalObject</a>
    /// </summary>
    let BibliographicalObject = _prefixId.prefix "BibliographicalObject"
    /// <summary>
    ///   <para>rdfs:comment : A group of EditorialObjects having a Brand as a
    ///             common denominator^^xsd:string</para>
    ///   <para>rdfs:label : Brand^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Brand">ebucore:Brand</a>
    /// </summary>
    let Brand = _prefixId.prefix "Brand"
    /// <summary>
    ///   <para>rdfs:label : Business Object</para>
    ///   <para>rdfs:comment : An image, a document, an annotation
    ///             (descriptive textual metadata or audio/video tag), a tag (time related in audiovisual
    ///             media resources), or an audiovisual media resource (optionally composed of one or more
    ///             fragment / part and / or audio, video data tracks). Other types of BusinessObjects may
    ///             be defined as subclasses.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#BusinessObject">ebucore:BusinessObject</a>
    /// </summary>
    let BusinessObject = _prefixId.prefix "BusinessObject"
    /// <summary>
    ///   <para>rdfs:label : Captioning</para>
    ///   <para>rdfs:comment : To signal the presence of hard of hearing
    ///             captioning.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Captioning">ebucore:Captioning</a>
    /// </summary>
    let Captioning = _prefixId.prefix "Captioning"
    /// <summary>
    ///   <para>rdfs:label : Captioning format</para>
    ///   <para>rdfs:comment : To define the format of captioning.
    ///             Captioning's main use isfor hard of hearing transcription. This is provided as
    ///             free text in an annotation label or as an identifier pointing to a term in a
    ///             classification scheme.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#CaptioningFormat">ebucore:CaptioningFormat</a>
    /// </summary>
    let CaptioningFormat = _prefixId.prefix "CaptioningFormat"
    /// <summary>
    ///   <para>rdfs:comment : A member of the cast list (a list of performers/actors and associated fictitious
    ///             characters).</para>
    ///   <para>rdfs:label : Cast member</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Cast">ebucore:Cast</a>
    /// </summary>
    let Cast = _prefixId.prefix "Cast"
    /// <summary>
    ///   <para>rdfs:comment : E.g. a fictitious contact / person.</para>
    ///   <para>rdfs:label : Character</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Character">ebucore:Character</a>
    /// </summary>
    let Character = _prefixId.prefix "Character"
    /// <summary>
    ///   <para>rdfs:comment : Closed captioning is provided as separate
    ///             content.</para>
    ///   <para>rdfs:label : Closed caption</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ClosedCaptions">ebucore:ClosedCaptions</a>
    /// </summary>
    let ClosedCaptions = _prefixId.prefix "ClosedCaptions"
    /// <summary>
    ///   <para>rdfs:label : Closed subtitling</para>
    ///   <para>rdfs:comment : Closed subtitles are provided as separate
    ///             content.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ClosedSubtitling">ebucore:ClosedSubtitling</a>
    /// </summary>
    let ClosedSubtitling = _prefixId.prefix "ClosedSubtitling"
    /// <summary>
    ///   <para>rdfs:comment : To provide information on a codec.</para>
    ///   <para>rdfs:label : Codec</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Codec">ebucore:Codec</a>
    /// </summary>
    let Codec = _prefixId.prefix "Codec"
    /// <summary>
    ///   <para>rdfs:comment : A group of EditorialObjects. There can be many
    ///             types of collections for which specific sub-classes should be defined. In the worl of
    ///             archives, A collection corresponds to all items belonging to an individual /
    ///             collector.^^xsd:string</para>
    ///   <para>rdfs:label : Collection^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Collection">ebucore:Collection</a>
    /// </summary>
    let Collection = _prefixId.prefix "Collection"
    /// <summary>
    ///   <para>rdfs:label : Colour space</para>
    ///   <para>rdfs:comment : The CoulourSpace of a VideoResource. A
    ///             ColourSpace is defined as free text in an annotation label or as an identifier pointing
    ///             to a term in a classification scheme such as
    ///             http://www.ebu.ch/metadata/ontologies/skos/ebu_ColourCodeCS.rdf.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ColourSpace">ebucore:ColourSpace</a>
    /// </summary>
    let ColourSpace = _prefixId.prefix "ColourSpace"
    /// <summary>
    ///   <para>rdfs:label : Component</para>
    ///   <para>rdfs:comment : A component e.g. audio, video, data or else or a MediaResource or Essence.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Component">ebucore:Component</a>
    /// </summary>
    let Component = _prefixId.prefix "Component"
    /// <summary>
    ///   <para>rdfs:comment : A physical person.</para>
    ///   <para>rdfs:label : Contact</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Contact">ebucore:Contact</a>
    /// </summary>
    let Contact = _prefixId.prefix "Contact"
    /// <summary>
    ///   <para>rdfs:comment : The container or wrapper format used to package
    ///             audio, video and data components of a Mediaresource. The format is defined as free text
    ///             or pointing at a term in a classification scheme e.g.
    ///             http://www.ebu.ch/metadata/ontologies/skos/ebu_ContainerFormatCS.rdf.</para>
    ///   <para>rdfs:label : Container format</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ContainerFormat">ebucore:ContainerFormat</a>
    /// </summary>
    let ContainerFormat = _prefixId.prefix "ContainerFormat"
    /// <summary>
    ///   <para>rdfs:comment : The definition of the container if available as
    ///             a MIME type. This is provided as free text in an annotation label or as an identifier
    ///             pointing to a term in a classification scheme. For more information:
    ///             http://www.iana.org/assignments/media-types/application/index.html.</para>
    ///   <para>rdfs:label : Container Mime type</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ContainerMimeType">ebucore:ContainerMimeType</a>
    /// </summary>
    let ContainerMimeType = _prefixId.prefix "ContainerMimeType"
    /// <summary>
    ///   <para>rdfs:comment : To provide a copyright
    ///             statement.</para>
    ///   <para>rdfs:label : Copyright</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Copyright">ebucore:Copyright</a>
    /// </summary>
    let Copyright = _prefixId.prefix "Copyright"
    /// <summary>
    ///   <para>rdfs:comment : To provide information on possible restrictions
    ///             regarding the temporal and spatial coverage for publication.</para>
    ///   <para>rdfs:label : Coverage restrictions</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#CoverageRestrictions">ebucore:CoverageRestrictions</a>
    /// </summary>
    let CoverageRestrictions = _prefixId.prefix "CoverageRestrictions"
    /// <summary>
    ///   <para>rdfs:label : Crew member</para>
    ///   <para>rdfs:comment : Crew member.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Crew">ebucore:Crew</a>
    /// </summary>
    let Crew = _prefixId.prefix "Crew"
    /// <summary>
    ///   <para>rdfs:comment : The Data Identifier word (along with the SDID,
    ///             if used), indicates the type of ancillary data that the packet corresponds
    ///             to.</para>
    ///   <para>rdfs:label : DID</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#DID">ebucore:DID</a>
    /// </summary>
    let DID = _prefixId.prefix "DID"
    /// <summary>
    ///   <para>rdfs:comment : To provide addtional technical information on
    ///             the characteristics of data streams in a MediaResource including but not limited to
    ///             AncillaryData, Subtilting and Captioning. Additional specific data format may be defined
    ///             as subclasses of DataFormat.</para>
    ///   <para>rdfs:label : Data format</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#DataFormat">ebucore:DataFormat</a>
    /// </summary>
    let DataFormat = _prefixId.prefix "DataFormat"
    /// <summary>
    ///   <para>rdfs:comment : Ancillary data track e.g. ¨captioning"
    ///             or "subtitling" in addition to video and audio tracks.</para>
    ///   <para>rdfs:label : Data track</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#DataTrack">ebucore:DataTrack</a>
    /// </summary>
    let DataTrack = _prefixId.prefix "DataTrack"
    /// <summary>
    ///   <para>rdfs:label : Department</para>
    ///   <para>rdfs:comment : A department within and
    ///             organisation.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Department">ebucore:Department</a>
    /// </summary>
    let Department = _prefixId.prefix "Department"
    /// <summary>
    ///   <para>rdfs:label : Depicted Event</para>
    ///   <para>rdfs:comment : A DepictedEVent is fictitious or historical or
    ///             other sort of Event that the content of the BusinessObject or resource relates
    ///             to.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#DepictedEvent">ebucore:DepictedEvent</a>
    /// </summary>
    let DepictedEvent = _prefixId.prefix "DepictedEvent"
    /// <summary>
    ///   <para>rdfs:comment : To provide a disclaimer of any
    ///             form.</para>
    ///   <para>rdfs:label : Disclaimer</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Disclaimer">ebucore:Disclaimer</a>
    /// </summary>
    let Disclaimer = _prefixId.prefix "Disclaimer"
    /// <summary>
    ///   <para>rdfs:comment : To describe a publication in the form of a
    ///             document e.g. a html webpage (news item) or a pdf document e.g. a script.</para>
    ///   <para>rdfs:label : Document</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Document">ebucore:Document</a>
    /// </summary>
    let Document = _prefixId.prefix "Document"
    /// <summary>
    ///   <para>rdfs:label : Document format</para>
    ///   <para>rdfs:comment : To provide technical information about the
    ///             format of a document such as the orientation. This is provided as free text in an
    ///             annotation label or as an identifier pointing to a term in a classification
    ///             scheme.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#DocumentFormat">ebucore:DocumentFormat</a>
    /// </summary>
    let DocumentFormat = _prefixId.prefix "DocumentFormat"
    /// <summary>
    ///   <para>rdfs:label : Dopesheet</para>
    ///   <para>rdfs:comment : Provides additional information about a NewsItem, e.g. date and place, subject.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Dopesheet">ebucore:Dopesheet</a>
    /// </summary>
    let Dopesheet = _prefixId.prefix "Dopesheet"
    /// <summary>
    ///   <para>rdfs:label : Editorial Object</para>
    ///   <para>rdfs:comment : In the audiovisual domain, the Class
    ///             EditorialObject transforms a commissioned concept into an editorial definition of a
    ///             MediaResource before fabrication (in the Production Domain) and Distribution (in the
    ///             Distribution Domain). An EditorialObject is a set of descriptive metadata summarising
    ///             e.g. editing decisions. An EditorialObject can also be a part of an EditorialObject,
    ///             which is defined by its start time and duration. An EditorialObject can also be a group
    ///             of EditorialObjects. For example a series composed of episodes is defined as an
    ///             EditorialObject.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#EditorialObject">ebucore:EditorialObject</a>
    /// </summary>
    let EditorialObject = _prefixId.prefix "EditorialObject"
    /// <summary>
    ///   <para>rdfs:comment : To provide a definition of the encoding format
    ///             for audio and video. This is provided as free text in an annotation label or as an
    ///             identifier pointing to a term in a classification scheme e.g.
    ///             http://www.ebu.ch/metadata/ontologies/skos/ebu_AudioCompressionCodeCS.rdf or
    ///             http://www.ebu.ch/metadata/ontologies/skos/ebu_VideoCompressionCodeCS.rdf.</para>
    ///   <para>rdfs:label : Encoding</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#EncodingFormat">ebucore:EncodingFormat</a>
    /// </summary>
    let EncodingFormat = _prefixId.prefix "EncodingFormat"
    /// <summary>
    ///   <para>rdfs:comment : In some audiovisual standardisation groups,
    ///             Essence is preferred to MediaResource. In also has subclasses well known as MediaObject
    ///             clustered in AudioObjects and VideoObjects.</para>
    ///   <para>rdfs:label : Essence</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Essence">ebucore:Essence</a>
    /// </summary>
    let Essence = _prefixId.prefix "Essence"
    /// <summary>
    ///   <para>rdfs:comment : Additional types of event shall be defined as
    ///             new sub-classes of event.rdfs:comment : An event related to the media resource, e.g.
    ///             depicted in the resource (possibly fictional), etc.</para>
    ///   <para>rdfs:label : Event</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Event">ebucore:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>rdfs:comment : To highlight potential exploitation
    ///             issues.</para>
    ///   <para>rdfs:label : Exploitation issues</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ExploitationIssues">ebucore:ExploitationIssues</a>
    /// </summary>
    let ExploitationIssues = _prefixId.prefix "ExploitationIssues"
    /// <summary>
    ///   <para>rdfs:label : Feature^^xsd:string</para>
    ///   <para>skos:prefLabel : Feature^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Feature">ebucore:Feature</a>
    /// </summary>
    let Feature = _prefixId.prefix "Feature"
    /// <summary>
    ///   <para>rdfs:label : File format</para>
    ///   <para>rdfs:comment : A file format for Resources other than
    ///             audiovisual resources. The format is defined as free text or pointing at a term in a
    ///             classification scheme e.g.
    ///             http://www.ebu.ch/metadata/ontologies/skos/ebu_FileFormatCS.rdf.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#FileFormat">ebucore:FileFormat</a>
    /// </summary>
    let FileFormat = _prefixId.prefix "FileFormat"
    /// <summary>
    ///   <para>rdfs:label : Format</para>
    ///   <para>rdfs:comment : The format provides technical information on
    ///             the format of a Resource. A BusinessObject can be instantiated in a variety of Resources
    ///             each in a particular Format. Other specific data formats may be defined as subclasses of
    ///             format.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Format">ebucore:Format</a>
    /// </summary>
    let Format = _prefixId.prefix "Format"
    /// <summary>
    ///   <para>rdfs:comment : Identifies the generation of a version of a resource, i.e. master, edit master, distribution copy, etc.</para>
    ///   <para>skos:prefLabel : Generation^^xsd:string</para>
    ///   <para>rdfs:label : Generation^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Generation">ebucore:Generation</a>
    /// </summary>
    let Generation = _prefixId.prefix "Generation"
    /// <summary>
    ///   <para>rdfs:comment : This class shall be used to provide information
    ///             on the genre of the BusinessObject or Resource. This is provided as free text in an
    ///             annotation label or as an identifier pointing to a term in a classification scheme e.g.
    ///             http://www.ebu.ch/metadata/ontologies/skos/ebu_ContentGenreCS.rdf or
    ///             http://www.ebu.ch/metadata/ontologies/skos/ebu_EditorialFormatCodeCS.rdf.</para>
    ///   <para>rdfs:label : Genre</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Genre">ebucore:Genre</a>
    /// </summary>
    let Genre = _prefixId.prefix "Genre"
    /// <summary>
    ///   <para>rdfs:comment : To define a collection / group of media
    ///             resources, for example a series made of episodes.</para>
    ///   <para>rdfs:label : Group</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Group">ebucore:Group</a>
    /// </summary>
    let Group = _prefixId.prefix "Group"
    /// <summary>
    ///   <para>rdfs:comment : To provide information on intellectual
    ///             property.</para>
    ///   <para>rdfs:label : IPR restrictions</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#IPRRestrictions">ebucore:IPRRestrictions</a>
    /// </summary>
    let IPRRestrictions = _prefixId.prefix "IPRRestrictions"
    /// <summary>
    ///   <para>rdfs:comment : A still image / thumbnail / key frame / logo
    ///             related to the media resource or being the media resource itself^^xsd:string</para>
    ///   <para>rdfs:label : Image^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Image">ebucore:Image</a>
    /// </summary>
    let Image = _prefixId.prefix "Image"
    /// <summary>
    ///   <para>rdfs:label : Image format</para>
    ///   <para>rdfs:comment : To provide technical information about the
    ///             format of an image such as the orientation. This is provided as free text in an
    ///             annotation label or as an identifier pointing to a term in a classification
    ///             scheme.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ImageFormat">ebucore:ImageFormat</a>
    /// </summary>
    let ImageFormat = _prefixId.prefix "ImageFormat"
    /// <summary>
    ///   <para>rdfs:label : Item</para>
    ///   <para>rdfs:comment : An item e.g. newsItem or sportItem</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Item">ebucore:Item</a>
    /// </summary>
    let Item = _prefixId.prefix "Item"
    /// <summary>
    ///   <para>rdfs:label : Key career event^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#KeyCareerEvent">ebucore:KeyCareerEvent</a>
    /// </summary>
    let KeyCareerEvent = _prefixId.prefix "KeyCareerEvent"
    /// <summary>
    ///   <para>rdfs:label : Key event^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#KeyEvent">ebucore:KeyEvent</a>
    /// </summary>
    let KeyEvent = _prefixId.prefix "KeyEvent"
    /// <summary>
    ///   <para>rdfs:label : Key personal event^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#KeyPersonalEvent">ebucore:KeyPersonalEvent</a>
    /// </summary>
    let KeyPersonalEvent = _prefixId.prefix "KeyPersonalEvent"
    /// <summary>
    ///   <para>rdfs:comment : A key frame is a frame extarcted from video,
    ///             e.g. representative of a part of a MediaResource.</para>
    ///   <para>rdfs:label : key frame</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Keyframe">ebucore:Keyframe</a>
    /// </summary>
    let Keyframe = _prefixId.prefix "Keyframe"
    /// <summary>
    ///   <para>rdfs:label : Keyword</para>
    ///   <para>rdfs:comment : To proivde keywords and define key concepts
    ///             illustrating the content of the Resource or EditorialObject. This is provided as free
    ///             text in an annotation label or as an identifier pointing to a term in a classification
    ///             scheme.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Keyword">ebucore:Keyword</a>
    /// </summary>
    let Keyword = _prefixId.prefix "Keyword"
    /// <summary>
    ///   <para>rdfs:label : Language</para>
    ///   <para>rdfs:comment : To provide information on languages present in
    ///             the BusinessObject and its purpose. This is provided as free text in an annotation label
    ///             or as an identifier pointing to a term in a classification scheme.Other language
    ///             specific types may be added as subclasses of language.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Language">ebucore:Language</a>
    /// </summary>
    let Language = _prefixId.prefix "Language"
    /// <summary>
    ///   <para>rdfs:comment : A type of location is defined as a sub-class of
    ///             location.rdfs:comment : A location related to the media resource, e.g.
    ///             depicted in the resource (possibly fictional) or where the resource was created
    ///             (shooting location), etc.rdfs:comment : This is provided as free text in an annotation
    ///             label or as an identifier pointing to a term in a classification scheme.</para>
    ///   <para>rdfs:label : Location^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Location">ebucore:Location</a>
    /// </summary>
    let Location = _prefixId.prefix "Location"
    /// <summary>
    ///   <para>rdfs:comment : A Logo allows to visually identify an
    ///             organisation, publicationService, publicationChannel, or ratings /
    ///             parentalGuidance</para>
    ///   <para>rdfs:label : Logo</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Logo">ebucore:Logo</a>
    /// </summary>
    let Logo = _prefixId.prefix "Logo"
    /// <summary>
    ///   <para>rdfs:label : Media Fragment</para>
    ///   <para>rdfs:comment : A MediaFragment is a temporal or spatial segment of a resource identified by a MediaGragment URI (http://www.w3.org/2008/WebVideo/Fragments/WD-media-fragments-spec/).</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#MediaFragment">ebucore:MediaFragment</a>
    /// </summary>
    let MediaFragment = _prefixId.prefix "MediaFragment"
    /// <summary>
    ///   <para>rdfs:comment : The use of MediaResource is reserved to
    ///             audiovisual content.</para>
    ///   <para>rdfs:label : Media Resource</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#MediaResource">ebucore:MediaResource</a>
    /// </summary>
    let MediaResource = _prefixId.prefix "MediaResource"
    /// <summary>
    ///   <para>rdfs:label : Medium</para>
    ///   <para>rdfs:comment : To provide information on the medium formats in
    ///             which the resource is available. This is provided as free text in an annotation label or
    ///             as an identifier pointing to a term in a classification scheme.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Medium">ebucore:Medium</a>
    /// </summary>
    let Medium = _prefixId.prefix "Medium"
    /// <summary>
    ///   <para>skos:prefLabel : Metadata track^^xsd:string</para>
    ///   <para>rdfs:label : Metadata track^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#MetadataTrack">ebucore:MetadataTrack</a>
    /// </summary>
    let MetadataTrack = _prefixId.prefix "MetadataTrack"
    /// <summary>
    ///   <para>rdfs:label : Mime type</para>
    ///   <para>rdfs:comment : The definition of the container if available as
    ///             a MIME type. This is provided as free text in an annotation label or as an identifier
    ///             pointing to a term in a classification scheme. For more information:
    ///             http://www.iana.org/assignments/media-types/index.html.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#MimeType">ebucore:MimeType</a>
    /// </summary>
    let MimeType = _prefixId.prefix "MimeType"
    /// <summary>
    ///   <para>rdfs:label : News Item</para>
    ///   <para>rdfs:comment : A NewsItem aggregates all information about a particular news event.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#NewsItem">ebucore:NewsItem</a>
    /// </summary>
    let NewsItem = _prefixId.prefix "NewsItem"
    /// <summary>
    ///   <para>rdfs:comment : To specify the type of BusinessObject e.g. and
    ///             EditorialObject of type "programme" or clip". This is
    ///             provided as free text in an annotation label or as an identifier pointing to a term in a
    ///             classification scheme e.g.
    ///             http://www.ebu.ch/metadata/ontologies/skos/ebu_ObjectTypeCodeCS.rdf.</para>
    ///   <para>rdfs:label : Object type</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ObjectType">ebucore:ObjectType</a>
    /// </summary>
    let ObjectType = _prefixId.prefix "ObjectType"
    /// <summary>
    ///   <para>rdfs:comment : Open Captions are burned in the
    ///             image.</para>
    ///   <para>rdfs:label : Open captions</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#OpenCaptions">ebucore:OpenCaptions</a>
    /// </summary>
    let OpenCaptions = _prefixId.prefix "OpenCaptions"
    /// <summary>
    ///   <para>rdfs:label : Open subtitling</para>
    ///   <para>rdfs:comment : Open subtitles are burned in the
    ///             image.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#OpenSubtitling">ebucore:OpenSubtitling</a>
    /// </summary>
    let OpenSubtitling = _prefixId.prefix "OpenSubtitling"
    /// <summary>
    ///   <para>rdfs:comment : An organisation (business, corporation, federation, etc.) or moral agent (gvernment body).</para>
    ///   <para>rdfs:label : Organisation</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Organisation">ebucore:Organisation</a>
    /// </summary>
    let Organisation = _prefixId.prefix "Organisation"
    /// <summary>
    ///   <para>rdfs:comment : The original language in which the
    ///             BusinessObject or Resource has been created and released. This is provided as free text
    ///             in an annotation label or as an identifier pointing to a term in a classification
    ///             scheme.^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#OriginalLanguage">ebucore:OriginalLanguage</a>
    /// </summary>
    let OriginalLanguage = _prefixId.prefix "OriginalLanguage"
    /// <summary>
    ///   <para>rdfs:comment : One of more media fragment (audio, video, data)
    ///             composing an audiovisual media resource. In other ontolgies fragment is often referred
    ///             to e.g. as a 'part' or 'segment' or
    ///             'fragment'.rdfs:comment : A Fragment is a particular section of a
    ///             MediaResource identified by a start and end time or duration. Fragment can also be
    ///             called segment or part.</para>
    ///   <para>rdfs:label : Part, Fragment, Segment</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Part">ebucore:Part</a>
    /// </summary>
    let Part = _prefixId.prefix "Part"
    /// <summary>
    ///   <para>rdfs:label : Pictogram</para>
    ///   <para>rdfs:comment : A visual / graphical representation of a concept.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Pictogram">ebucore:Pictogram</a>
    /// </summary>
    let Pictogram = _prefixId.prefix "Pictogram"
    /// <summary>
    ///   <para>rdfs:label : Picture</para>
    ///   <para>rdfs:comment : A photography, a logo, a pictogram, etc.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Picture">ebucore:Picture</a>
    /// </summary>
    let Picture = _prefixId.prefix "Picture"
    /// <summary>
    ///   <para>rdfs:comment : An EditorialObject corresponding to a
    ///             MediaResource ready for publication.</para>
    ///   <para>rdfs:label : Programme</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Programme">ebucore:Programme</a>
    /// </summary>
    let Programme = _prefixId.prefix "Programme"
    /// <summary>
    ///   <para>rdfs:label : Publication Channel</para>
    ///   <para>rdfs:comment : The name of the channel through which a
    ///             Resource has been published as a PublicationEvent. A PublicationChannel can use a
    ///             variety of medias e.g. broadcast or online.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#PublicationChannel">ebucore:PublicationChannel</a>
    /// </summary>
    let PublicationChannel = _prefixId.prefix "PublicationChannel"
    /// <summary>
    ///   <para>rdfs:label : Publication Event</para>
    ///   <para>rdfs:comment : To describe any manifestation of a media
    ///             resource on any media (live, on demand, catch-up TV, etc.) and the appropriate
    ///             PublciationChannel.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#PublicationEvent">ebucore:PublicationEvent</a>
    /// </summary>
    let PublicationEvent = _prefixId.prefix "PublicationEvent"
    /// <summary>
    ///   <para>rdfs:label : Publication History</para>
    ///   <para>rdfs:comment : A collection of PublicationEvents through which
    ///             a resource has been published.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#PublicationHistory">ebucore:PublicationHistory</a>
    /// </summary>
    let PublicationHistory = _prefixId.prefix "PublicationHistory"
    /// <summary>
    ///   <para>rdfs:label : Publication History</para>
    ///   <para>rdfs:comment : A collection of PublicationEvents organised as a PublicationPlanning.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#PublicationPlanning">ebucore:PublicationPlanning</a>
    /// </summary>
    let PublicationPlanning = _prefixId.prefix "PublicationPlanning"
    /// <summary>
    ///   <para>rdfs:comment : A programme for distribution on radio
    ///             channels.</para>
    ///   <para>rdfs:label : Radio Programme</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#RadioProgramme">ebucore:RadioProgramme</a>
    /// </summary>
    let RadioProgramme = _prefixId.prefix "RadioProgramme"
    /// <summary>
    ///   <para>rdfs:comment : All the information about the rating/evaluation
    ///             given to a media resource by an Agent i.e. a person/Contact or
    ///             Organisation.rdfs:comment : This is provided as free text in an annotation
    ///             label or as an identifier pointing to a term in a classification scheme.</para>
    ///   <para>rdfs:label : Rating</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Rating">ebucore:Rating</a>
    /// </summary>
    let Rating = _prefixId.prefix "Rating"
    /// <summary>
    ///   <para>rdfs:label : Resource</para>
    ///   <para>rdfs:comment : A manifestation of a
    ///             BusinessObject.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Resource">ebucore:Resource</a>
    /// </summary>
    let Resource = _prefixId.prefix "Resource"
    /// <summary>
    ///   <para>rdfs:label : Rights</para>
    ///   <para>rdfs:comment : To provide information on the rights, including
    ///             intellectual property, related to a BusinessObject or Resource.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Rights">ebucore:Rights</a>
    /// </summary>
    let Rights = _prefixId.prefix "Rights"
    /// <summary>
    ///   <para>rdfs:comment : To signal that rights have been cleared (or
    ///             not)</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#RightsClearance">ebucore:RightsClearance</a>
    /// </summary>
    let RightsClearance = _prefixId.prefix "RightsClearance"
    /// <summary>
    ///   <para>rdfs:comment : To define the role / action of an agent. This
    ///             is provided as free text in an annotation label or as an identifier pointing to a term
    ///             in a classification scheme.</para>
    ///   <para>rdfs:label : Role</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Role">ebucore:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"
    /// <summary>
    ///   <para>rdfs:comment : Secondary data identification word for
    ///             ancillary data. Send mode identifier. An identifier which indicates the transmission
    ///             timing for closed caption data.</para>
    ///   <para>rdfs:label : SDID</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#SDID">ebucore:SDID</a>
    /// </summary>
    let SDID = _prefixId.prefix "SDID"
    /// <summary>
    ///   <para>rdfs:label : Season^^xsd:string</para>
    ///   <para>rdfs:comment : A series can be composed of one or more seasons
    ///             clustering a certain number of episodes. Fro this reason, seasons are related to series
    ///             using the isRelatedTo property.^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Season">ebucore:Season</a>
    /// </summary>
    let Season = _prefixId.prefix "Season"
    /// <summary>
    ///   <para>rdfs:label : Series^^xsd:string</para>
    ///   <para>rdfs:comment : Series is a particular type of collection. TV
    ///             or Radio Series are composed of Episodes.^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Series">ebucore:Series</a>
    /// </summary>
    let Series = _prefixId.prefix "Series"
    /// <summary>
    ///   <para>rdfs:label : Service</para>
    ///   <para>rdfs:comment : A service is the umbrella under which one or
    ///             more PublicationChannel is operated.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Service">ebucore:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    /// <summary>
    ///   <para>rdfs:comment : To signal the presence of Signing for hard of
    ///             hearing users. The type of Signing (e.g. incursted in or else) or language of Signing
    ///             can be specified using the appropriate properties.</para>
    ///   <para>rdfs:label : Signing</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Signing">ebucore:Signing</a>
    /// </summary>
    let Signing = _prefixId.prefix "Signing"
    /// <summary>
    ///   <para>rdfs:label : Signing format</para>
    ///   <para>rdfs:comment : To provide additional information on the
    ///             signing format. This is provided as free text in an annotation label or as an identifier
    ///             pointing to a term in a classification scheme.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#SigningFormat">ebucore:SigningFormat</a>
    /// </summary>
    let SigningFormat = _prefixId.prefix "SigningFormat"
    /// <summary>
    ///   <para>rdfs:label : Sport item</para>
    ///   <para>rdfs:comment : A SportItem aggregates all information about a sport event.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#SportItem">ebucore:SportItem</a>
    /// </summary>
    let SportItem = _prefixId.prefix "SportItem"
    /// <summary>
    ///   <para>rdfs:comment : Staff member.</para>
    ///   <para>rdfs:label : Staff member.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Staff">ebucore:Staff</a>
    /// </summary>
    let Staff = _prefixId.prefix "Staff"
    /// <summary>
    ///   <para>rdfs:comment : identifies the technical video standard of a resource, i.e. NTSC or PAL.</para>
    ///   <para>skos:prefLabel : Standard^^xsd:string</para>
    ///   <para>rdfs:label : Standard^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Standard">ebucore:Standard</a>
    /// </summary>
    let Standard = _prefixId.prefix "Standard"
    /// <summary>
    ///   <para>rdfs:label : Storage type</para>
    ///   <para>rdfs:comment : The type of storage used for the repository.
    ///             This is provided as free text in an annotation label or as an identifier pointing to a
    ///             term in a classification scheme.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#StorageType">ebucore:StorageType</a>
    /// </summary>
    let StorageType = _prefixId.prefix "StorageType"
    /// <summary>
    ///   <para>rdfs:label : Stream</para>
    ///   <para>rdfs:comment : A continuous stream of bits.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Stream">ebucore:Stream</a>
    /// </summary>
    let Stream = _prefixId.prefix "Stream"
    /// <summary>
    ///   <para>rdfs:comment : A term describing the topic covered by the
    ///             BusinessObject or resource. This is provided as free text in an annotation label or as
    ///             an identifier pointing to a term in a classification scheme.</para>
    ///   <para>rdfs:label : Subject</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Subject">ebucore:Subject</a>
    /// </summary>
    let Subject = _prefixId.prefix "Subject"
    /// <summary>
    ///   <para>rdfs:label : Subtitling</para>
    ///   <para>rdfs:comment : To signal the presence of subtitles for
    ///             translation in alternative languages.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Subtitling">ebucore:Subtitling</a>
    /// </summary>
    let Subtitling = _prefixId.prefix "Subtitling"
    /// <summary>
    ///   <para>rdfs:label : Subtitling format</para>
    ///   <para>rdfs:comment : To define the format of subtitling.
    ///             subtitling's main use isfor translation. This is provided as free text in an
    ///             annotation label  or as an identifier pointing to a term in a classification
    ///             scheme.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#SubtitlingFormat">ebucore:SubtitlingFormat</a>
    /// </summary>
    let SubtitlingFormat = _prefixId.prefix "SubtitlingFormat"
    /// <summary>
    ///   <para>rdfs:label : TV Programme</para>
    ///   <para>rdfs:comment : A programme for distribution on television
    ///             channels.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#TVProgramme">ebucore:TVProgramme</a>
    /// </summary>
    let TVProgramme = _prefixId.prefix "TVProgramme"
    /// <summary>
    ///   <para>rdfs:label : Tag^^xsd:string</para>
    ///   <para>rdfs:comment : An annotation specific to a particular
    ///             timestamp in audiovisual MediaResources.^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Tag">ebucore:Tag</a>
    /// </summary>
    let Tag = _prefixId.prefix "Tag"
    /// <summary>
    ///   <para>rdfs:comment : A thumbnail is a low resolution picture that
    ///             can be associated with EditorialObjects or e.g. MediaResources or
    ///             Contacts.</para>
    ///   <para>rdfs:label : Thumbnail</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Thumbnail">ebucore:Thumbnail</a>
    /// </summary>
    let Thumbnail = _prefixId.prefix "Thumbnail"
    /// <summary>
    ///   <para>rdfs:label : Timecode track^^xsd:string</para>
    ///   <para>rdfs:comment : A track with timecode information.^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#TimecodeTrack">ebucore:TimecodeTrack</a>
    /// </summary>
    let TimecodeTrack = _prefixId.prefix "TimecodeTrack"
    /// <summary>
    ///   <para>rdfs:comment : A type subject for use in some contexts. This
    ///             is provided as free text in an annotation label or as an identifier pointing to a term
    ///             in a classification scheme.</para>
    ///   <para>rdfs:label : Topic</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Topic">ebucore:Topic</a>
    /// </summary>
    let Topic = _prefixId.prefix "Topic"
    /// <summary>
    ///   <para>rdfs:comment : Audiovisual content can be composed of audio,
    ///             video and data Tracks (including captioning and subtitling).</para>
    ///   <para>rdfs:label : Track</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Track">ebucore:Track</a>
    /// </summary>
    let Track = _prefixId.prefix "Track"
    /// <summary>
    ///   <para>rdfs:label : Type</para>
    ///   <para>rdfs:comment : An expression of type in textual form or as a term from a classification scheme.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Type">ebucore:Type</a>
    /// </summary>
    let Type = _prefixId.prefix "Type"
    /// <summary>
    ///   <para>rdfs:comment : Usage rights associated with content.</para>
    ///   <para>rdfs:label : Usage rights</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#UsageRights">ebucore:UsageRights</a>
    /// </summary>
    let UsageRights = _prefixId.prefix "UsageRights"
    /// <summary>
    ///   <para>rdfs:label : Video encoding format</para>
    ///   <para>rdfs:comment : The encoding format of the video.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#VideoEncodingFormat">ebucore:VideoEncodingFormat</a>
    /// </summary>
    let VideoEncodingFormat = _prefixId.prefix "VideoEncodingFormat"
    /// <summary>
    ///   <para>rdfs:comment : To provide additional technical information
    ///             about a video resource such as the frame rate. This is provided as free text in an
    ///             annotation label or as an identifier pointing to a term in a classification
    ///             scheme.</para>
    ///   <para>rdfs:label : Video format</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#VideoFormat">ebucore:VideoFormat</a>
    /// </summary>
    let VideoFormat = _prefixId.prefix "VideoFormat"
    /// <summary>
    ///   <para>rdfs:label : Video stream</para>
    ///   <para>rdfs:comment : A decodable video stream of bits.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#VideoStream">ebucore:VideoStream</a>
    /// </summary>
    let VideoStream = _prefixId.prefix "VideoStream"
    /// <summary>
    ///   <para>rdfs:label : Video track</para>
    ///   <para>rdfs:comment : A specialisation of Track for Video to provide
    ///             a link to specific data properties such as frameRate, etc. Signing is another possible
    ///             example of video track. Specific VideoTracks such as Signing can be defined as sub
    ///             VideoTracks.. In advanced systems, different VideoTracks can be used to provide e.g.
    ///             different viewing angles.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#VideoTrack">ebucore:VideoTrack</a>
    /// </summary>
    let VideoTrack = _prefixId.prefix "VideoTrack"
    /// <summary>
    ///   <para>rdfs:label : You tube video^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#YouTubeVideo">ebucore:YouTubeVideo</a>
    /// </summary>
    let YouTubeVideo = _prefixId.prefix "YouTubeVideo"
    /// <summary>
    ///   <para>rdfs:label : Abridged title</para>
    ///   <para>rdfs:comment : A shorter version of the title.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#abridgedTitle">ebucore:abridgedTitle</a>
    /// </summary>
    let abridgedTitle = _prefixId.prefix "abridgedTitle"
    /// <summary>
    ///   <para>rdfs:comment : To provide a brief summary.</para>
    ///   <para>rdfs:label : Abstract</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#abstract">ebucore:abstract</a>
    /// </summary>
    let abstract_ = _prefixId.prefix "abstract"
    /// <summary>
    ///   <para>rdfs:label : adult content^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#adultContent">ebucore:adultContent</a>
    /// </summary>
    let adultContent = _prefixId.prefix "adultContent"
    /// <summary>
    ///   <para>rdfs:label : Affiliation start date</para>
    ///   <para>rdfs:comment : The date when a Contact left an Organisation</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#affiliationEndDate">ebucore:affiliationEndDate</a>
    /// </summary>
    let affiliationEndDate = _prefixId.prefix "affiliationEndDate"
    /// <summary>
    ///   <para>rdfs:label : Affiliation start date^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#affiliationStartDate">ebucore:affiliationStartDate</a>
    /// </summary>
    let affiliationStartDate = _prefixId.prefix "affiliationStartDate"
    /// <summary>
    ///   <para>rdfs:label : Address</para>
    ///   <para>rdfs:comment : To provide the address of an Agent
    ///             (Contact/person or organisation).</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentAddress">ebucore:agentAddress</a>
    /// </summary>
    let agentAddress = _prefixId.prefix "agentAddress"
    /// <summary>
    ///   <para>rdfs:comment : The age of a Contact/Person^^xsd:string</para>
    ///   <para>rdfs:label : Age</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentAge">ebucore:agentAge</a>
    /// </summary>
    let agentAge = _prefixId.prefix "agentAge"
    /// <summary>
    ///   <para>rdfs:label : agent country of residence^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentCountryOfResidence">ebucore:agentCountryOfResidence</a>
    /// </summary>
    let agentCountryOfResidence = _prefixId.prefix "agentCountryOfResidence"
    /// <summary>
    ///   <para>rdfs:comment : To provide the email address of an agent
    ///             (Contact/person or organisation).</para>
    ///   <para>rdfs:label : Email</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentEmailAddress">ebucore:agentEmailAddress</a>
    /// </summary>
    let agentEmailAddress = _prefixId.prefix "agentEmailAddress"
    /// <summary>
    ///   <para>rdfs:comment : To provide the mobile telephone number of an
    ///             Agent (Contact/person or organisation)</para>
    ///   <para>rdfs:label : Mobile</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentMobileTelephoneNumber">ebucore:agentMobileTelephoneNumber</a>
    /// </summary>
    let agentMobileTelephoneNumber = _prefixId.prefix "agentMobileTelephoneNumber"
    /// <summary>
    ///   <para>rdfs:comment : To provide the full name of Contact/person - family and given name.</para>
    ///   <para>rdfs:label : Name</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentName">ebucore:agentName</a>
    /// </summary>
    let agentName = _prefixId.prefix "agentName"
    /// <summary>
    ///   <para>rdfs:label : agent nationality^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentNationality">ebucore:agentNationality</a>
    /// </summary>
    let agentNationality = _prefixId.prefix "agentNationality"
    /// <summary>
    ///   <para>rdfs:comment : To provide a nickname of a Contact/person.</para>
    ///   <para>rdfs:label : Nickname</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentNickname">ebucore:agentNickname</a>
    /// </summary>
    let agentNickname = _prefixId.prefix "agentNickname"
    /// <summary>
    ///   <para>rdfs:label : agent picture id locator^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentPictureIdLocator">ebucore:agentPictureIdLocator</a>
    /// </summary>
    let agentPictureIdLocator = _prefixId.prefix "agentPictureIdLocator"
    /// <summary>
    ///   <para>rdfs:comment : To provide the telephone number of an Agent
    ///             (Contact/person or Organisation).</para>
    ///   <para>rdfs:label : Telephone</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentTelephoneNumber">ebucore:agentTelephoneNumber</a>
    /// </summary>
    let agentTelephoneNumber = _prefixId.prefix "agentTelephoneNumber"
    /// <summary>
    ///   <para>rdfs:label : Homepage</para>
    ///   <para>rdfs:comment : To provide the address of the webpage of an
    ///             Agent (Contact/person or Organisation).</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentWebHomepage">ebucore:agentWebHomepage</a>
    /// </summary>
    let agentWebHomepage = _prefixId.prefix "agentWebHomepage"
    /// <summary>
    ///   <para>rdfs:label : Alternative title</para>
    ///   <para>rdfs:comment : To provide an alternative title.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#alternativeTitle">ebucore:alternativeTitle</a>
    /// </summary>
    let alternativeTitle = _prefixId.prefix "alternativeTitle"
    /// <summary>
    ///   <para>rdfs:comment : To define the Location (e.g. country, region) to which Rating and TargetAudience do NOT apply.</para>
    ///   <para>rdfs:label : Exclusion area</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#appliesOutOf">ebucore:appliesOutOf</a>
    /// </summary>
    let appliesOutOf = _prefixId.prefix "appliesOutOf"
    /// <summary>
    ///   <para>rdfs:comment : To define the location/region to which Rating and TargetAudience apply.</para>
    ///   <para>rdfs:label : Coverage</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#appliesTo">ebucore:appliesTo</a>
    /// </summary>
    let appliesTo = _prefixId.prefix "appliesTo"
    /// <summary>
    ///   <para>rdfs:comment : To provide the aspect ratio of a video frame or
    ///             image. Several types of different aspect ration can apply to the same video image. If
    ///             necessary, specialised aspect ratios can be defined as subproperties.</para>
    ///   <para>rdfs:label : Aspect ratio</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#aspectRatio">ebucore:aspectRatio</a>
    /// </summary>
    let aspectRatio = _prefixId.prefix "aspectRatio"
    /// <summary>
    ///   <para>rdfs:comment : This is provided as free text in an annotation
    ///             label or as an identifier pointing to a term in a classification scheme.rdfs:comment : The target audience (target region, target
    ///             audience category but also parental guidance recommendation) for which the media
    ///             resource is intended.</para>
    ///   <para>rdfs:label : Target audience</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#audienceLevel">ebucore:audienceLevel</a>
    /// </summary>
    let audienceLevel = _prefixId.prefix "audienceLevel"
    /// <summary>
    ///   <para>rdfs:comment : The total number of audio channels contained in
    ///             the MediaResource.</para>
    ///   <para>rdfs:label : Audio channel number</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#audioChannelNumber">ebucore:audioChannelNumber</a>
    /// </summary>
    let audioChannelNumber = _prefixId.prefix "audioChannelNumber"
    /// <summary>
    ///   <para>rdfs:comment : To provide the configuration of an audio track
    ///             (e.g. stereo pair) in a MediaResource.</para>
    ///   <para>rdfs:label : Audio track configuration^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#audioTrackConfiguration">ebucore:audioTrackConfiguration</a>
    /// </summary>
    let audioTrackConfiguration = _prefixId.prefix "audioTrackConfiguration"
    /// <summary>
    ///   <para>rdfs:comment : To provide the audio encoding bit depth. Also called sample size.</para>
    ///   <para>rdfs:label : Bit depth</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#bitDepth">ebucore:bitDepth</a>
    /// </summary>
    let bitDepth = _prefixId.prefix "bitDepth"
    /// <summary>
    ///   <para>rdfs:comment : To provide the bitrate at which the
    ///             MediaResource can be played in bits/second. Current bitrate if constant, and average bitrate if variable.</para>
    ///   <para>rdfs:label : Bitrate^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#bitRate">ebucore:bitRate</a>
    /// </summary>
    let bitRate = _prefixId.prefix "bitRate"
    /// <summary>
    ///   <para>rdfs:comment : The maximum bitrate when variable, in bits per second.</para>
    ///   <para>rdfs:label : Maximum bitrate</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#bitRateMax">ebucore:bitRateMax</a>
    /// </summary>
    let bitRateMax = _prefixId.prefix "bitRateMax"
    /// <summary>
    ///   <para>rdfs:label : Bitrate mode</para>
    ///   <para>rdfs:comment : A flag to indicate if the bit rate is fixed or
    ///             variable.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#bitRateMode">ebucore:bitRateMode</a>
    /// </summary>
    let bitRateMode = _prefixId.prefix "bitRateMode"
    /// <summary>
    ///   <para>rdfs:comment : To provide a bookmark.</para>
    ///   <para>rdfs:label : Bookmark</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#bookmark">ebucore:bookmark</a>
    /// </summary>
    let bookmark = _prefixId.prefix "bookmark"
    /// <summary>
    ///   <para>rdfs:label : Name</para>
    ///   <para>rdfs:comment : A name attributed to a
    ///             BusinessObject.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#businessObjectName">ebucore:businessObjectName</a>
    /// </summary>
    let businessObjectName = _prefixId.prefix "businessObjectName"
    /// <summary>
    ///   <para>rdfs:comment : To provide information on the source of a
    ///             captioning file.</para>
    ///   <para>rdfs:label : Captioning source</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#captioningSource">ebucore:captioningSource</a>
    /// </summary>
    let captioningSource = _prefixId.prefix "captioningSource"
    /// <summary>
    ///   <para>rdfs:comment : Identifies relationship between a digital instantiation of a resource and its direct copy, with no generational loss.</para>
    ///   <para>rdfs:label : Cloned to</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#clonedTo">ebucore:clonedTo</a>
    /// </summary>
    let clonedTo = _prefixId.prefix "clonedTo"
    /// <summary>
    ///   <para>rdfs:comment : To provide information on the product family of the Codec.</para>
    ///   <para>rdfs:label : Codec family</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#codecFamily">ebucore:codecFamily</a>
    /// </summary>
    let codecFamily = _prefixId.prefix "codecFamily"
    /// <summary>
    ///   <para>rdfs:comment : To provide a name for the Codec, e.g. a product name.</para>
    ///   <para>rdfs:label : Codec name</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#codecName">ebucore:codecName</a>
    /// </summary>
    let codecName = _prefixId.prefix "codecName"
    /// <summary>
    ///   <para>rdfs:comment : To provide a name for the vendor of the Codec.</para>
    ///   <para>rdfs:label : Codec vendor</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#codecVendor">ebucore:codecVendor</a>
    /// </summary>
    let codecVendor = _prefixId.prefix "codecVendor"
    /// <summary>
    ///   <para>rdfs:comment : To provide information on the version of the Codec.</para>
    ///   <para>rdfs:label : Codec version</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#codecVersion">ebucore:codecVersion</a>
    /// </summary>
    let codecVersion = _prefixId.prefix "codecVersion"
    /// <summary>
    ///   <para>rdfs:comment : To provide a comment.</para>
    ///   <para>rdfs:label : Comments</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#comments">ebucore:comments</a>
    /// </summary>
    let comments = _prefixId.prefix "comments"
    /// <summary>
    ///   <para>rdfs:label : Education</para>
    ///   <para>rdfs:comment : The education details of a Contact /
    ///             person.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#contactEducation">ebucore:contactEducation</a>
    /// </summary>
    let contactEducation = _prefixId.prefix "contactEducation"
    /// <summary>
    ///   <para>rdfs:label : Family information</para>
    ///   <para>rdfs:comment : Information on the family of a Contact /
    ///             person.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#contactFamilyInformation">ebucore:contactFamilyInformation</a>
    /// </summary>
    let contactFamilyInformation = _prefixId.prefix "contactFamilyInformation"
    /// <summary>
    ///   <para>rdfs:label : Hobbies</para>
    ///   <para>rdfs:comment : The hobbies of a Contact /
    ///             person.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#contactHobbies">ebucore:contactHobbies</a>
    /// </summary>
    let contactHobbies = _prefixId.prefix "contactHobbies"
    /// <summary>
    ///   <para>rdfs:label : Marital status</para>
    ///   <para>rdfs:comment : The marital status of a Contact /
    ///             person.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#contactMaritalStatus">ebucore:contactMaritalStatus</a>
    /// </summary>
    let contactMaritalStatus = _prefixId.prefix "contactMaritalStatus"
    /// <summary>
    ///   <para>rdfs:comment : The job / occupation name of a Contact /
    ///             person.</para>
    ///   <para>rdfs:label : Occupation</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#contactOccupation">ebucore:contactOccupation</a>
    /// </summary>
    let contactOccupation = _prefixId.prefix "contactOccupation"
    /// <summary>
    ///   <para>rdfs:label : Username</para>
    ///   <para>rdfs:comment : The username by which a Contact / person is
    ///             known e.g. when attributing a rating value.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#contactUsername">ebucore:contactUsername</a>
    /// </summary>
    let contactUsername = _prefixId.prefix "contactUsername"
    /// <summary>
    ///   <para>rdfs:label : Broadcast date^^xsd:string</para>
    ///   <para>rdfs:comment : The date when the resource was first broadcast publicly on television or radio.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateBroadcast">ebucore:dateBroadcast</a>
    /// </summary>
    let dateBroadcast = _prefixId.prefix "dateBroadcast"
    /// <summary>
    ///   <para>rdfs:comment : The date of creation of the Resource.</para>
    ///   <para>rdfs:label : Creation date/time^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateCreated">ebucore:dateCreated</a>
    /// </summary>
    let dateCreated = _prefixId.prefix "dateCreated"
    /// <summary>
    ///   <para>rdfs:comment : The date when the resource was removed from institutional holdings.</para>
    ///   <para>rdfs:label : Deletion date^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateDeleted">ebucore:dateDeleted</a>
    /// </summary>
    let dateDeleted = _prefixId.prefix "dateDeleted"
    /// <summary>
    ///   <para>rdfs:comment : To provide the date of digitisation of the Resource.</para>
    ///   <para>rdfs:label : Digitisation date/time^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateDigitised">ebucore:dateDigitised</a>
    /// </summary>
    let dateDigitised = _prefixId.prefix "dateDigitised"
    /// <summary>
    ///   <para>rdfs:comment : The date when the resource was first made available to the public for purchase, download, or online access.</para>
    ///   <para>rdfs:label : Distribution date^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateDistributed">ebucore:dateDistributed</a>
    /// </summary>
    let dateDistributed = _prefixId.prefix "dateDistributed"
    /// <summary>
    ///   <para>rdfs:label : Ingest date^^xsd:string</para>
    ///   <para>rdfs:comment : The date when the resource was removed from institutional holdings.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateIngested">ebucore:dateIngested</a>
    /// </summary>
    let dateIngested = _prefixId.prefix "dateIngested"
    /// <summary>
    ///   <para>rdfs:comment : To provide the date of release of the Resource.</para>
    ///   <para>rdfs:label : Publication date/time^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateIssued">ebucore:dateIssued</a>
    /// </summary>
    let dateIssued = _prefixId.prefix "dateIssued"
    /// <summary>
    ///   <para>rdfs:label : License start date^^xsd:string</para>
    ///   <para>rdfs:comment : The date when the license for the resource begins.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateLicenced">ebucore:dateLicenced</a>
    /// </summary>
    let dateLicenced = _prefixId.prefix "dateLicenced"
    /// <summary>
    ///   <para>rdfs:label : Migration date^^xsd:string</para>
    ///   <para>rdfs:comment : The date when the resource was copied or converted from an obsolete or endangered original format to a more updated format for preservation.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateMigrated">ebucore:dateMigrated</a>
    /// </summary>
    let dateMigrated = _prefixId.prefix "dateMigrated"
    /// <summary>
    ///   <para>rdfs:label : Modification date/time^^xsd:string</para>
    ///   <para>rdfs:comment : To indicate the date at which the Resource has been modified.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateModified">ebucore:dateModified</a>
    /// </summary>
    let dateModified = _prefixId.prefix "dateModified"
    /// <summary>
    ///   <para>rdfs:label : Normalization date^^xsd:string</para>
    ///   <para>rdfs:comment : The date when the resource was converted from its original format into a format pre-selected by the institution for preservation.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateNormalized">ebucore:dateNormalized</a>
    /// </summary>
    let dateNormalized = _prefixId.prefix "dateNormalized"
    /// <summary>
    ///   <para>rdfs:label : Transfer date^^xsd:string</para>
    ///   <para>rdfs:comment : The date when the resource was moved from one digital or physical location to another.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateTransferred">ebucore:dateTransferred</a>
    /// </summary>
    let dateTransferred = _prefixId.prefix "dateTransferred"
    /// <summary>
    ///   <para>rdfs:label : Validation date^^xsd:string</para>
    ///   <para>rdfs:comment : The most recent date when the resource was confirmed to be valid through manual or digital QC.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateValidated">ebucore:dateValidated</a>
    /// </summary>
    let dateValidated = _prefixId.prefix "dateValidated"
    /// <summary>
    ///   <para>rdfs:comment : Identifies a content-based relationship between two resources.</para>
    ///   <para>rdfs:label : Derived to</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#derivedTo">ebucore:derivedTo</a>
    /// </summary>
    let derivedTo = _prefixId.prefix "derivedTo"
    /// <summary>
    ///   <para>rdfs:label : Description^^xsd:string</para>
    ///   <para>rdfs:comment : This can be specialised by using sub-properties
    ///             like defined in http://www.ebu.ch/metadata/cs/web/ebu_DescriptionTypeCodeCS_p.xml.htm
    ///             implemented as examples as e.g. 'summary' or
    ///             'script'.^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#description">ebucore:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:label : Dimensions</para>
    ///   <para>rdfs:comment : Describes the physical dimensions of a media resource, with units of measure concatenated to become part of the value.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dimensions">ebucore:dimensions</a>
    /// </summary>
    let dimensions = _prefixId.prefix "dimensions"
    /// <summary>
    ///   <para>rdfs:comment : To provide a dopesheet with a title and brief description for news.</para>
    ///   <para>rdfs:label : Dopesheet</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dopesheet">ebucore:dopesheet</a>
    /// </summary>
    let dopesheet = _prefixId.prefix "dopesheet"
    /// <summary>
    ///   <para>rdfs:label : Dubbed to</para>
    ///   <para>rdfs:comment : Identifies relationship between a physical instantiation of a resource and a duplicate physical copy that may involve generational loss.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dubbedTo">ebucore:dubbedTo</a>
    /// </summary>
    let dubbedTo = _prefixId.prefix "dubbedTo"
    /// <summary>
    ///   <para>rdfs:label : Duration</para>
    ///   <para>rdfs:comment : To provide information on the duration of a MediaResource. It corresponds to 'duration' in the
    ///             Ontology for Media Resources.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#duration">ebucore:duration</a>
    /// </summary>
    let duration = _prefixId.prefix "duration"
    /// <summary>
    ///   <para>rdfs:comment : To provide a duration as normal
    ///             time.</para>
    ///   <para>rdfs:label : Duration (time)^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#durationNormalPlayTime">ebucore:durationNormalPlayTime</a>
    /// </summary>
    let durationNormalPlayTime = _prefixId.prefix "durationNormalPlayTime"
    /// <summary>
    ///   <para>rdfs:comment : To provide a duration as a number of EditUnits
    ///             which value is for instance the inverse of the audio sample rate or video frame
    ///             rate.</para>
    ///   <para>rdfs:label : Duration (edit units)^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#durationNumberEditUnit">ebucore:durationNumberEditUnit</a>
    /// </summary>
    let durationNumberEditUnit = _prefixId.prefix "durationNumberEditUnit"
    /// <summary>
    ///   <para>rdfs:comment : To provide information on the published / announced duration of an EditorialObject.</para>
    ///   <para>rdfs:label : Published Duration</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#durationPublished">ebucore:durationPublished</a>
    /// </summary>
    let durationPublished = _prefixId.prefix "durationPublished"

    /// <summary>
    ///   <para>rdfs:comment : To provide a published duration as normal
    ///             time.</para>
    ///   <para>rdfs:label : Published duration (time)</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#durationPublishedNormalPlayTime">ebucore:durationPublishedNormalPlayTime</a>
    /// </summary>
    let durationPublishedNormalPlayTime = _prefixId.prefix "durationPublishedNormalPlayTime"

    /// <summary>
    ///   <para>rdfs:comment : To provide a published duration as a number of EditUnits
    ///             which value is for instance the inverse of the audio sample rate or video frame
    ///             rate.</para>
    ///   <para>rdfs:label : Published duration (edit units)</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#durationPublishedNumberEditUnit">ebucore:durationPublishedNumberEditUnit</a>
    /// </summary>
    let durationPublishedNumberEditUnit = _prefixId.prefix "durationPublishedNumberEditUnit"

    /// <summary>
    ///   <para>rdfs:label : Published duration (timecode)</para>
    ///   <para>rdfs:comment : The published duration expressed as a
    ///             timecode.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#durationPublishedTimecode">ebucore:durationPublishedTimecode</a>
    /// </summary>
    let durationPublishedTimecode = _prefixId.prefix "durationPublishedTimecode"
    /// <summary>
    ///   <para>rdfs:label : Duration (timecode)^^xsd:string</para>
    ///   <para>rdfs:comment : The duration expressed as a
    ///             timecode.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#durationTimecode">ebucore:durationTimecode</a>
    /// </summary>
    let durationTimecode = _prefixId.prefix "durationTimecode"
    /// <summary>
    ///   <para>rdfs:label : Edit unit</para>
    ///   <para>rdfs:comment : The edit unit is e.g. the inverse of the audio
    ///             sample rate or video frame rate.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#editUnit">ebucore:editUnit</a>
    /// </summary>
    let editUnit = _prefixId.prefix "editUnit"
    /// <summary>
    ///   <para>rdfs:comment : The encoding level.</para>
    ///   <para>rdfs:label : Encoding level</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#encodingLevel">ebucore:encodingLevel</a>
    /// </summary>
    let encodingLevel = _prefixId.prefix "encodingLevel"
    /// <summary>
    ///   <para>rdfs:comment : The encoding profile</para>
    ///   <para>rdfs:label : Encoding profile</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#encodingProfile">ebucore:encodingProfile</a>
    /// </summary>
    let encodingProfile = _prefixId.prefix "encodingProfile"
    /// <summary>
    ///   <para>rdfs:label : End time</para>
    ///   <para>rdfs:comment : The start point of the media
    ///             resource.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#end">ebucore:end</a>
    /// </summary>
    let end_ = _prefixId.prefix "end"
    /// <summary>
    ///   <para>rdfs:label : License expiration date^^xsd:string</para>
    ///   <para>rdfs:comment : The date on which the license for the resource expires.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#endLicenceDate">ebucore:endLicenceDate</a>
    /// </summary>
    let endLicenceDate = _prefixId.prefix "endLicenceDate"
    /// <summary>
    ///   <para>rdfs:label : End time (time)</para>
    ///   <para>rdfs:comment : The start time expressed using a time
    ///             expression.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#endNormalPlayTime">ebucore:endNormalPlayTime</a>
    /// </summary>
    let endNormalPlayTime = _prefixId.prefix "endNormalPlayTime"
    /// <summary>
    ///   <para>rdfs:comment : A start time expressed as a number of edit
    ///             units.</para>
    ///   <para>rdfs:label : End time (edit units)</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#endNumberEditUnits">ebucore:endNumberEditUnits</a>
    /// </summary>
    let endNumberEditUnits = _prefixId.prefix "endNumberEditUnits"
    /// <summary>
    ///   <para>rdfs:comment : A start time expressed as
    ///             timecode.</para>
    ///   <para>rdfs:label : End time (timecode)</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#endTimecode">ebucore:endTimecode</a>
    /// </summary>
    let endTimecode = _prefixId.prefix "endTimecode"
    /// <summary>
    ///   <para>rdfs:comment : To provide a deescription for an
    ///             Event.</para>
    ///   <para>rdfs:label : Description</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#eventDescription">ebucore:eventDescription</a>
    /// </summary>
    let eventDescription = _prefixId.prefix "eventDescription"
    /// <summary>
    ///   <para>rdfs:label : Duration^^xsd:string</para>
    ///   <para>rdfs:comment : The duration of an event.^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#eventDuration">ebucore:eventDuration</a>
    /// </summary>
    let eventDuration = _prefixId.prefix "eventDuration"
    /// <summary>
    ///   <para>rdfs:comment : The end date of an Event.</para>
    ///   <para>rdfs:label : Event end date</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#eventEndDate">ebucore:eventEndDate</a>
    /// </summary>
    let eventEndDate = _prefixId.prefix "eventEndDate"
    /// <summary>
    ///   <para>rdfs:comment : To provide a name for an Event.</para>
    ///   <para>rdfs:label : Event name</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#eventName">ebucore:eventName</a>
    /// </summary>
    let eventName = _prefixId.prefix "eventName"
    /// <summary>
    ///   <para>rdfs:label : Event period</para>
    ///   <para>rdfs:comment : The period of time during which an Event has occured.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#eventPeriod">ebucore:eventPeriod</a>
    /// </summary>
    let eventPeriod = _prefixId.prefix "eventPeriod"
    /// <summary>
    ///   <para>rdfs:comment : The start date of an Event.</para>
    ///   <para>rdfs:label : Event start date</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#eventStartDate">ebucore:eventStartDate</a>
    /// </summary>
    let eventStartDate = _prefixId.prefix "eventStartDate"
    /// <summary>
    ///   <para>rdfs:label : Family name</para>
    ///   <para>rdfs:comment : To provide a family name / last name.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#familyName">ebucore:familyName</a>
    /// </summary>
    let familyName = _prefixId.prefix "familyName"
    /// <summary>
    ///   <para>rdfs:label : Fictitious agent indicator</para>
    ///   <para>rdfs:comment : A flag to indicate if an agent of fictitious
    ///             (set to true).</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#fictitious">ebucore:fictitious</a>
    /// </summary>
    let fictitious = _prefixId.prefix "fictitious"
    /// <summary>
    ///   <para>rdfs:label : File size</para>
    ///   <para>rdfs:comment : Provides the size of a MediaResource in bytes.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#fileSize">ebucore:fileSize</a>
    /// </summary>
    let fileSize = _prefixId.prefix "fileSize"
    /// <summary>
    ///   <para>rdfs:label : File name</para>
    ///   <para>rdfs:comment : The name of the file containing the
    ///             Resource.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#filename">ebucore:filename</a>
    /// </summary>
    let filename = _prefixId.prefix "filename"
    /// <summary>
    ///   <para>rdfs:label : Folksonomy</para>
    ///   <para>rdfs:comment : Provides a user/audience-generated description, tag, or label for resource content.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#folksonomy">ebucore:folksonomy</a>
    /// </summary>
    let folksonomy = _prefixId.prefix "folksonomy"
    /// <summary>
    ///   <para>rdfs:label : Previous^^xsd:string</para>
    ///   <para>rdfs:comment : A link to a an BusinessObject or a Resource preceding the current BusinessObject or Resource in an ordered sequence^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#followsInSequence">ebucore:followsInSequence</a>
    /// </summary>
    let followsInSequence = _prefixId.prefix "followsInSequence"
    /// <summary>
    ///   <para>rdfs:comment : The frame rate of the video signal in frame per second.</para>
    ///   <para>rdfs:label : Frame rate</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#frameRate">ebucore:frameRate</a>
    /// </summary>
    let frameRate = _prefixId.prefix "frameRate"
    /// <summary>
    ///   <para>rdfs:label : Frame size unit</para>
    ///   <para>rdfs:comment : The unit used to express the frame width or
    ///             height. The unit by default is 'pixel'.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#frameSizeUnit">ebucore:frameSizeUnit</a>
    /// </summary>
    let frameSizeUnit = _prefixId.prefix "frameSizeUnit"
    /// <summary>
    ///   <para>rdfs:comment : Identifies the frames per second at which a visual resource should be played back for human consumption.</para>
    ///   <para>rdfs:label : Frames per second</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#framesPerSecond">ebucore:framesPerSecond</a>
    /// </summary>
    let framesPerSecond = _prefixId.prefix "framesPerSecond"
    /// <summary>
    ///   <para>rdfs:comment : To provide the frequency of an AudioChannel filter</para>
    ///   <para>rdfs:label : Frequency</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#frequency">ebucore:frequency</a>
    /// </summary>
    let frequency = _prefixId.prefix "frequency"
    /// <summary>
    ///   <para>rdfs:label : Given name</para>
    ///   <para>rdfs:comment : To provide one or more given names.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#givenName">ebucore:givenName</a>
    /// </summary>
    let givenName = _prefixId.prefix "givenName"
    /// <summary>
    ///   <para>rdfs:label : Group description</para>
    ///   <para>rdfs:comment : A textual description of a
    ///             Group.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#groupDescription">ebucore:groupDescription</a>
    /// </summary>
    let groupDescription = _prefixId.prefix "groupDescription"
    /// <summary>
    ///   <para>rdfs:comment : The name attributed to a Group.</para>
    ///   <para>rdfs:label : Group name</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#groupName">ebucore:groupName</a>
    /// </summary>
    let groupName = _prefixId.prefix "groupName"
    /// <summary>
    ///   <para>rdfs:comment : A property to establish the relation between a
    ///             Contact/person and an Organisation.</para>
    ///   <para>rdfs:label : Affiliation</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAffiliation">ebucore:hasAffiliation</a>
    /// </summary>
    let hasAffiliation = _prefixId.prefix "hasAffiliation"
    /// <summary>
    ///   <para>rdfs:label : Ancillary data</para>
    ///   <para>rdfs:comment : A property to signal the presence of
    ///             AncillaryData associated with the EditorialObject and / or MediaResource.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAncillaryData">ebucore:hasAncillaryData</a>
    /// </summary>
    let hasAncillaryData = _prefixId.prefix "hasAncillaryData"
    /// <summary>
    ///   <para>rdfs:label : Ancillary data format^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAncillaryDataFormat">ebucore:hasAncillaryDataFormat</a>
    /// </summary>
    let hasAncillaryDataFormat = _prefixId.prefix "hasAncillaryDataFormat"
    /// <summary>
    ///   <para>rdfs:comment : A property to signal the presence of Annotation
    ///             information associated with an EditorialObject and / or a MediaResource.</para>
    ///   <para>rdfs:label : Annotation</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAnnotation">ebucore:hasAnnotation</a>
    /// </summary>
    let hasAnnotation = _prefixId.prefix "hasAnnotation"
    /// <summary>
    ///   <para>rdfs:label : Annotation Source</para>
    ///   <para>rdfs:comment : To identify the Agent, Contact/person or
    ///             Organisation who has provided the Annotation.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAnnotationSource">ebucore:hasAnnotationSource</a>
    /// </summary>
    let hasAnnotationSource = _prefixId.prefix "hasAnnotationSource"
    /// <summary>
    ///   <para>rdfs:comment : To signal the presence of
    ///             AudioDescription.</para>
    ///   <para>rdfs:label : Audio description</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAudioDescription">ebucore:hasAudioDescription</a>
    /// </summary>
    let hasAudioDescription = _prefixId.prefix "hasAudioDescription"
    /// <summary>
    ///   <para>rdfs:label : Audio encoding format^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAudioEncodingFormat">ebucore:hasAudioEncodingFormat</a>
    /// </summary>
    let hasAudioEncodingFormat = _prefixId.prefix "hasAudioEncodingFormat"
    /// <summary>
    ///   <para>rdfs:label : Audio format^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAudioFormat">ebucore:hasAudioFormat</a>
    /// </summary>
    let hasAudioFormat = _prefixId.prefix "hasAudioFormat"
    /// <summary>
    ///   <para>rdfs:comment : To signal the presence of
    ///             Captioning.</para>
    ///   <para>rdfs:label : Captioning</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCaptioning">ebucore:hasCaptioning</a>
    /// </summary>
    let hasCaptioning = _prefixId.prefix "hasCaptioning"
    /// <summary>
    ///   <para>rdfs:label : Captioning format^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCaptioningFormat">ebucore:hasCaptioningFormat</a>
    /// </summary>
    let hasCaptioningFormat = _prefixId.prefix "hasCaptioningFormat"
    /// <summary>
    ///   <para>skos:prefLabel : Cast member^^xsd:string</para>
    ///   <para>rdfs:label : Cast member^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCastMember">ebucore:hasCastMember</a>
    /// </summary>
    let hasCastMember = _prefixId.prefix "hasCastMember"
    /// <summary>
    ///   <para>rdfs:label : Character^^xsd:string</para>
    ///   <para>skos:prefLabel : Character^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCharacter">ebucore:hasCharacter</a>
    /// </summary>
    let hasCharacter = _prefixId.prefix "hasCharacter"
    /// <summary>
    ///   <para>rdfs:comment : To identify the Codec with which the Resource has been encoded.</para>
    ///   <para>rdfs:label : Encoder^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCodec">ebucore:hasCodec</a>
    /// </summary>
    let hasCodec = _prefixId.prefix "hasCodec"
    /// <summary>
    ///   <para>rdfs:label : Colour space^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasColourSpace">ebucore:hasColourSpace</a>
    /// </summary>
    let hasColourSpace = _prefixId.prefix "hasColourSpace"
    /// <summary>
    ///   <para>rdfs:comment : To provide information on a Contact for an
    ///             Organisation or a physical person (e.g. the agent of an actor).</para>
    ///   <para>rdfs:label : Contact</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasContact">ebucore:hasContact</a>
    /// </summary>
    let hasContact = _prefixId.prefix "hasContact"
    /// <summary>
    ///   <para>rdfs:label : Container format^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasContainerFormat">ebucore:hasContainerFormat</a>
    /// </summary>
    let hasContainerFormat = _prefixId.prefix "hasContainerFormat"
    /// <summary>
    ///   <para>rdfs:label : Mime type^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasContainerMimeType">ebucore:hasContainerMimeType</a>
    /// </summary>
    let hasContainerMimeType = _prefixId.prefix "hasContainerMimeType"
    /// <summary>
    ///   <para>rdfs:label : Contributor</para>
    ///   <para>rdfs:comment : To provide information on Contacts/persons or
    ///             Organisations who have contributed to the BusinessObject or Resource.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasContributor">ebucore:hasContributor</a>
    /// </summary>
    let hasContributor = _prefixId.prefix "hasContributor"
    /// <summary>
    ///   <para>rdfs:comment : A property to identify the Events and or
    ///             Locations, all real or fictional, covered by the
    ///             BusinessObject.</para>
    ///   <para>rdfs:label : Coverage</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCoverage">ebucore:hasCoverage</a>
    /// </summary>
    let hasCoverage = _prefixId.prefix "hasCoverage"
    /// <summary>
    ///   <para>rdfs:label : Creation location</para>
    ///   <para>rdfs:comment : The Location where content has been created.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCreationLocation">ebucore:hasCreationLocation</a>
    /// </summary>
    let hasCreationLocation = _prefixId.prefix "hasCreationLocation"
    /// <summary>
    ///   <para>rdfs:label : Creator</para>
    ///   <para>rdfs:comment : To identify an Agent involved in the creation of the Resource or BusinessObject.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCreator">ebucore:hasCreator</a>
    /// </summary>
    let hasCreator = _prefixId.prefix "hasCreator"
    /// <summary>
    ///   <para>skos:prefLabel : Crew member^^xsd:string</para>
    ///   <para>rdfs:label : Crew member^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCrewMember">ebucore:hasCrewMember</a>
    /// </summary>
    let hasCrewMember = _prefixId.prefix "hasCrewMember"
    /// <summary>
    ///   <para>rdfs:label : Data format^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasDataFormat">ebucore:hasDataFormat</a>
    /// </summary>
    let hasDataFormat = _prefixId.prefix "hasDataFormat"
    /// <summary>
    ///   <para>rdfs:label : Department</para>
    ///   <para>rdfs:comment : To identify Departments within an
    ///             Organisation.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasDepartment">ebucore:hasDepartment</a>
    /// </summary>
    let hasDepartment = _prefixId.prefix "hasDepartment"
    /// <summary>
    ///   <para>rdfs:label : has document format^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasDocumentFormat">ebucore:hasDocumentFormat</a>
    /// </summary>
    let hasDocumentFormat = _prefixId.prefix "hasDocumentFormat"
    /// <summary>
    ///   <para>rdfs:label : Dopesheet</para>
    ///   <para>rdfs:comment : To associate a Dopesheet with a NewsItem.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasDopesheet">ebucore:hasDopesheet</a>
    /// </summary>
    let hasDopesheet = _prefixId.prefix "hasDopesheet"
    /// <summary>
    ///   <para>rdfs:label : Encoding format^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasEncodingFormat">ebucore:hasEncodingFormat</a>
    /// </summary>
    let hasEncodingFormat = _prefixId.prefix "hasEncodingFormat"
    /// <summary>
    ///   <para>rdfs:comment : To identify an episode of a
    ///             Series or a Season.</para>
    ///   <para>rdfs:label : Episode</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasEpisode">ebucore:hasEpisode</a>
    /// </summary>
    let hasEpisode = _prefixId.prefix "hasEpisode"
    /// <summary>
    ///   <para>rdfs:label : Event</para>
    ///   <para>rdfs:comment : To associate an Event with a
    ///             Location.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasEvent">ebucore:hasEvent</a>
    /// </summary>
    let hasEvent = _prefixId.prefix "hasEvent"
    /// <summary>
    ///   <para>rdfs:label : File format^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasFileFormat">ebucore:hasFileFormat</a>
    /// </summary>
    let hasFileFormat = _prefixId.prefix "hasFileFormat"
    /// <summary>
    ///   <para>rdfs:comment : A property to define the Format of a Resource.</para>
    ///   <para>rdfs:label : Format</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasFormat">ebucore:hasFormat</a>
    /// </summary>
    let hasFormat = _prefixId.prefix "hasFormat"
    /// <summary>
    ///   <para>rdfs:label : Generation</para>
    ///   <para>rdfs:comment : Identifies the generation of a version of a resource, i.e. master, edit master, distribution copy, etc.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasGeneration">ebucore:hasGeneration</a>
    /// </summary>
    let hasGeneration = _prefixId.prefix "hasGeneration"
    /// <summary>
    ///   <para>rdfs:comment : To define a Genre/category associated to the
    ///             BusinesssObject.</para>
    ///   <para>rdfs:label : Genre</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasGenre">ebucore:hasGenre</a>
    /// </summary>
    let hasGenre = _prefixId.prefix "hasGenre"
    /// <summary>
    ///   <para>skos:prefLabel : Homepage^^xsd:string</para>
    ///   <para>rdfs:label : Homepage^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasHomepage">ebucore:hasHomepage</a>
    /// </summary>
    let hasHomepage = _prefixId.prefix "hasHomepage"
    /// <summary>
    ///   <para>skos:prefLabel : Id picture^^xsd:string</para>
    ///   <para>rdfs:label : Id picture^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasIdPicture">ebucore:hasIdPicture</a>
    /// </summary>
    let hasIdPicture = _prefixId.prefix "hasIdPicture"
    /// <summary>
    ///   <para>rdfs:label : Image format^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasImageFormat">ebucore:hasImageFormat</a>
    /// </summary>
    let hasImageFormat = _prefixId.prefix "hasImageFormat"
    /// <summary>
    ///   <para>rdfs:label : Career event^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasKeyCareerEvent">ebucore:hasKeyCareerEvent</a>
    /// </summary>
    let hasKeyCareerEvent = _prefixId.prefix "hasKeyCareerEvent"
    /// <summary>
    ///   <para>rdfs:label : Personal event^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasKeyPersonalEvent">ebucore:hasKeyPersonalEvent</a>
    /// </summary>
    let hasKeyPersonalEvent = _prefixId.prefix "hasKeyPersonalEvent"
    /// <summary>
    ///   <para>rdfs:label : Keyword</para>
    ///   <para>rdfs:comment : To associate a concept, descriptive phrase or
    ///             Keyword that specifies the topic of the BusinessObject or Annotation.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasKeyword">ebucore:hasKeyword</a>
    /// </summary>
    let hasKeyword = _prefixId.prefix "hasKeyword"
    /// <summary>
    ///   <para>rdfs:comment : To associate a Language to a Resource or
    ///             BusinessObject. A controlled vocabulary based on BCP 47 is recommended. This
    ///             property can also be used to identify the presence of sign language (RFC 5646). By
    ///             inheritance, the hasLanguage property applies indifferently at the MediaResource /
    ///             Fragment / Track levels at which the usage is being defined. Best practice recommends to
    ///             use to best possible level of granularity fo describe the usage of language within a
    ///             MediaResource including at Fragment and Track levels.</para>
    ///   <para>rdfs:label : Language</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasLanguage">ebucore:hasLanguage</a>
    /// </summary>
    let hasLanguage = _prefixId.prefix "hasLanguage"
    /// <summary>
    ///   <para>rdfs:comment : To associate a Location with a BusinessObject.</para>
    ///   <para>rdfs:label : Location</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasLocation">ebucore:hasLocation</a>
    /// </summary>
    let hasLocation = _prefixId.prefix "hasLocation"
    /// <summary>
    ///   <para>rdfs:label : Logo</para>
    ///   <para>rdfs:comment : Logos can be used in a variety of contexts.
    ///             Logo can be associated with an Organisation or a Service or a PublicationChannel.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasLogo">ebucore:hasLogo</a>
    /// </summary>
    let hasLogo = _prefixId.prefix "hasLogo"
    /// <summary>
    ///   <para>rdfs:label : Part</para>
    ///   <para>rdfs:comment : To define Parts (segments, fragments, etc.)
    ///             withiin a MediaResource.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasMediaFragment">ebucore:hasMediaFragment</a>
    /// </summary>
    let hasMediaFragment = _prefixId.prefix "hasMediaFragment"
    /// <summary>
    ///   <para>rdfs:label : Medium^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasMedium">ebucore:hasMedium</a>
    /// </summary>
    let hasMedium = _prefixId.prefix "hasMedium"
    /// <summary>
    ///   <para>rdfs:comment : To establish group/collection relationship between EditorialObjects.</para>
    ///   <para>rdfs:label : Member.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasMember">ebucore:hasMember</a>
    /// </summary>
    let hasMember = _prefixId.prefix "hasMember"
    /// <summary>
    ///   <para>rdfs:label : Metadata attributor</para>
    ///   <para>rdfs:comment : To identify the Agent (Contact/person or
    ///             Organisation) who has created the metadata.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasMetadataAttributor">ebucore:hasMetadataAttributor</a>
    /// </summary>
    let hasMetadataAttributor = _prefixId.prefix "hasMetadataAttributor"
    /// <summary>
    ///   <para>rdfs:label : Mime type^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasMimeType">ebucore:hasMimeType</a>
    /// </summary>
    let hasMimeType = _prefixId.prefix "hasMimeType"
    /// <summary>
    ///   <para>rdfs:label : Object/asset type^^xsd:string</para>
    ///   <para>rdfs:comment : To define an ObjectType for the BusinessObject
    ///              (e.g. book, report, programme, clip) if not defined as a subClass of BusinessObject.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasObjectType">ebucore:hasObjectType</a>
    /// </summary>
    let hasObjectType = _prefixId.prefix "hasObjectType"
    /// <summary>
    ///   <para>rdfs:label : Original language^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasOriginalLanguage">ebucore:hasOriginalLanguage</a>
    /// </summary>
    let hasOriginalLanguage = _prefixId.prefix "hasOriginalLanguage"
    /// <summary>
    ///   <para>rdfs:comment : To define Parts (segments, fragments, etc.)
    ///             within a BusinessObject.</para>
    ///   <para>rdfs:label : Part</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasPart">ebucore:hasPart</a>
    /// </summary>
    let hasPart = _prefixId.prefix "hasPart"
    /// <summary>
    ///   <para>rdfs:comment : To provide a visual representation of  TargetAudience or Rating.</para>
    ///   <para>rdfs:label : Pictogram</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasPictogram">ebucore:hasPictogram</a>
    /// </summary>
    let hasPictogram = _prefixId.prefix "hasPictogram"
    /// <summary>
    ///   <para>rdfs:comment : To associate a PublicationEvent with a
    ///             PublicationChannel.</para>
    ///   <para>rdfs:label : Publication channel</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasPublicationChannel">ebucore:hasPublicationChannel</a>
    /// </summary>
    let hasPublicationChannel = _prefixId.prefix "hasPublicationChannel"
    /// <summary>
    ///   <para>rdfs:comment : To associate PublicationEvents with
    ///             PublicationChannels or as elements of a PublicationHistory or PublicationPlanning.</para>
    ///   <para>rdfs:label : Publication event</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasPublicationEvent">ebucore:hasPublicationEvent</a>
    /// </summary>
    let hasPublicationEvent = _prefixId.prefix "hasPublicationEvent"
    /// <summary>
    ///   <para>rdfs:label : has publication history^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasPublicationHistory">ebucore:hasPublicationHistory</a>
    /// </summary>
    let hasPublicationHistory = _prefixId.prefix "hasPublicationHistory"
    /// <summary>
    ///   <para>rdfs:label : Publisher</para>
    ///   <para>rdfs:comment : To identify an Agent involved in the publication of the Resource or BusinessObject.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasPublisher">ebucore:hasPublisher</a>
    /// </summary>
    let hasPublisher = _prefixId.prefix "hasPublisher"
    /// <summary>
    ///   <para>rdfs:label : Rating</para>
    ///   <para>rdfs:comment : To identify the presence of Rating attributed
    ///             to a Resource or BusinessObject.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRating">ebucore:hasRating</a>
    /// </summary>
    let hasRating = _prefixId.prefix "hasRating"
    /// <summary>
    ///   <para>rdfs:label : Rating provider</para>
    ///   <para>rdfs:comment : To identify an Agent (Contact/person or
    ///             Organisation) who has proposed a Rating.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRatingSource">ebucore:hasRatingSource</a>
    /// </summary>
    let hasRatingSource = _prefixId.prefix "hasRatingSource"
    /// <summary>
    ///   <para>rdfs:comment : To associate an AudioChannel with an AudioPack or an AudioStream.</para>
    ///   <para>rdfs:label : Audio channel</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedAudioChannel">ebucore:hasRelatedAudioChannel</a>
    /// </summary>
    let hasRelatedAudioChannel = _prefixId.prefix "hasRelatedAudioChannel"
    /// <summary>
    ///   <para>rdfs:comment : To identify the AudioContent associated with an AudioProgramme.</para>
    ///   <para>rdfs:label : Audio content</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedAudioContent">ebucore:hasRelatedAudioContent</a>
    /// </summary>
    let hasRelatedAudioContent = _prefixId.prefix "hasRelatedAudioContent"
    /// <summary>
    ///   <para>rdfs:comment : To identify AudioObjects associated with AudioContent or other AudioObjects.</para>
    ///   <para>rdfs:label : Audio object</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedAudioObject">ebucore:hasRelatedAudioObject</a>
    /// </summary>
    let hasRelatedAudioObject = _prefixId.prefix "hasRelatedAudioObject"
    /// <summary>
    ///   <para>rdfs:label : Audio stream</para>
    ///   <para>rdfs:comment : To associate an AudioStream with an AudioTrack.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedAudioStream">ebucore:hasRelatedAudioStream</a>
    /// </summary>
    let hasRelatedAudioStream = _prefixId.prefix "hasRelatedAudioStream"
    /// <summary>
    ///   <para>rdfs:comment : To associate an AudioTrack with an AudioStream or an AudioTrackUID.</para>
    ///   <para>rdfs:label : Audio track</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedAudioTrack">ebucore:hasRelatedAudioTrack</a>
    /// </summary>
    let hasRelatedAudioTrack = _prefixId.prefix "hasRelatedAudioTrack"
    /// <summary>
    ///   <para>rdfs:label : Editorial object</para>
    ///   <para>rdfs:comment : EditorialObjects can be related to other BusinessOjects, Assets (and associated rights), PublicationEvents(defined when commissioning the EditorialObject before it is instantiated as a Resource (manifestation), or Resources, or Ratings.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedBusinessObject">ebucore:hasRelatedBusinessObject</a>
    /// </summary>
    let hasRelatedBusinessObject = _prefixId.prefix "hasRelatedBusinessObject"
    /// <summary>
    ///   <para>rdfs:label : has related event^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedEvent">ebucore:hasRelatedEvent</a>
    /// </summary>
    let hasRelatedEvent = _prefixId.prefix "hasRelatedEvent"
    /// <summary>
    ///   <para>rdfs:label : Image</para>
    ///   <para>rdfs:comment : To associate an Image with a BusinessObject.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedImage">ebucore:hasRelatedImage</a>
    /// </summary>
    let hasRelatedImage = _prefixId.prefix "hasRelatedImage"
    /// <summary>
    ///   <para>rdfs:label : has related event^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedLocation">ebucore:hasRelatedLocation</a>
    /// </summary>
    let hasRelatedLocation = _prefixId.prefix "hasRelatedLocation"
    /// <summary>
    ///   <para>rdfs:comment : To associate a Part of an EditorialObject with a MediaFragment within the association MediaResource instantiating the EditorialObject.</para>
    ///   <para>rdfs:label : Media fragment</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedMediaFragment">ebucore:hasRelatedMediaFragment</a>
    /// </summary>
    let hasRelatedMediaFragment = _prefixId.prefix "hasRelatedMediaFragment"
    /// <summary>
    ///   <para>rdfs:comment : To associate a Picture with a BusinessObject or a Resource.</para>
    ///   <para>rdfs:label : Picture</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedPicture">ebucore:hasRelatedPicture</a>
    /// </summary>
    let hasRelatedPicture = _prefixId.prefix "hasRelatedPicture"
    /// <summary>
    ///   <para>rdfs:comment : To identify the PublicationEvent associated with a MediaResource (manifestation of an EditorialObject).</para>
    ///   <para>rdfs:label : Publication event</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedPublicationEvent">ebucore:hasRelatedPublicationEvent</a>
    /// </summary>
    let hasRelatedPublicationEvent = _prefixId.prefix "hasRelatedPublicationEvent"
    /// <summary>
    ///   <para>rdfs:comment : To identify a Resource associated with an Asset or a BusinessObject or a PublicationEvent or another Resource.</para>
    ///   <para>rdfs:label : Related resource^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedResource">ebucore:hasRelatedResource</a>
    /// </summary>
    let hasRelatedResource = _prefixId.prefix "hasRelatedResource"
    /// <summary>
    ///   <para>skos:prefLabel : Rights^^xsd:string</para>
    ///   <para>rdfs:label : Rights^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRights">ebucore:hasRights</a>
    /// </summary>
    let hasRights = _prefixId.prefix "hasRights"
    /// <summary>
    ///   <para>rdfs:label : Contact</para>
    ///   <para>rdfs:comment : To identify a Contact/person who can provide
    ///             assistance / guidance regarding the associated Rights.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRightsContact">ebucore:hasRightsContact</a>
    /// </summary>
    let hasRightsContact = _prefixId.prefix "hasRightsContact"
    /// <summary>
    ///   <para>rdfs:label : Rights holder</para>
    ///   <para>rdfs:comment : To identify an Agent (Contact/person or
    ///             Organisation) having/managing Rights.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRightsHolder">ebucore:hasRightsHolder</a>
    /// </summary>
    let hasRightsHolder = _prefixId.prefix "hasRightsHolder"
    /// <summary>
    ///   <para>rdfs:label : Role</para>
    ///   <para>rdfs:comment : To define the role of an Agent (Contact/person
    ///             or Organisation). The association in a particular context is made by declaring the hasCastRole  associated with the BusinessObject.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRole">ebucore:hasRole</a>
    /// </summary>
    let hasRole = _prefixId.prefix "hasRole"
    /// <summary>
    ///   <para>rdfs:label : Season</para>
    ///   <para>rdfs:comment : The Season of a Series.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasSeason">ebucore:hasSeason</a>
    /// </summary>
    let hasSeason = _prefixId.prefix "hasSeason"
    /// <summary>
    ///   <para>rdfs:comment : To identify the presence of Signing associated
    ///             to the BusinessObject/Resource.</para>
    ///   <para>rdfs:label : Accessibility - signing</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasSigning">ebucore:hasSigning</a>
    /// </summary>
    let hasSigning = _prefixId.prefix "hasSigning"
    /// <summary>
    ///   <para>rdfs:label : Signing format^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasSigningFormat">ebucore:hasSigningFormat</a>
    /// </summary>
    let hasSigningFormat = _prefixId.prefix "hasSigningFormat"
    /// <summary>
    ///   <para>rdfs:label : Source</para>
    ///   <para>rdfs:comment : To identify a Resource as the source of another Resource.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasSource">ebucore:hasSource</a>
    /// </summary>
    let hasSource = _prefixId.prefix "hasSource"
    /// <summary>
    ///   <para>rdfs:label : Staff</para>
    ///   <para>rdfs:comment : To identify staff working within an Organisation.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasStaff">ebucore:hasStaff</a>
    /// </summary>
    let hasStaff = _prefixId.prefix "hasStaff"
    /// <summary>
    ///   <para>rdfs:comment : Identifies the technical video standard of a resource, i.e. NTSC or PAL.</para>
    ///   <para>rdfs:label : Standard</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasStandard">ebucore:hasStandard</a>
    /// </summary>
    let hasStandard = _prefixId.prefix "hasStandard"
    /// <summary>
    ///   <para>rdfs:comment : To define a particular type of storage /
    ///             repository associated with the Locator from where a Resource can be
    ///             accessed.</para>
    ///   <para>rdfs:label : Storage type^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasStorageType">ebucore:hasStorageType</a>
    /// </summary>
    let hasStorageType = _prefixId.prefix "hasStorageType"
    /// <summary>
    ///   <para>rdfs:label : Subject</para>
    ///   <para>rdfs:comment : To associate a Subject addressed with a
    ///             BusinessObject / Resource.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasSubject">ebucore:hasSubject</a>
    /// </summary>
    let hasSubject = _prefixId.prefix "hasSubject"
    /// <summary>
    ///   <para>rdfs:label : Subtitling</para>
    ///   <para>rdfs:comment : To signal the presence of Subtitling associated
    ///             with the EditorialObject or MediaResource.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasSubtitling">ebucore:hasSubtitling</a>
    /// </summary>
    let hasSubtitling = _prefixId.prefix "hasSubtitling"
    /// <summary>
    ///   <para>rdfs:label : Subtitling format^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasSubtitlingFormat">ebucore:hasSubtitlingFormat</a>
    /// </summary>
    let hasSubtitlingFormat = _prefixId.prefix "hasSubtitlingFormat"
    /// <summary>
    ///   <para>rdfs:label : Target audience^^xsd:string</para>
    ///   <para>rdfs:comment : To associate a TargetAudience (e.g. for
    ///             parental guiddance or targeting a particular social group) with a
    ///             BusinessObject/Resource.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasTargetAudience">ebucore:hasTargetAudience</a>
    /// </summary>
    let hasTargetAudience = _prefixId.prefix "hasTargetAudience"
    /// <summary>
    ///   <para>rdfs:label : Theme^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasTheme">ebucore:hasTheme</a>
    /// </summary>
    let hasTheme = _prefixId.prefix "hasTheme"
    /// <summary>
    ///   <para>rdfs:label : Topic^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasTopic">ebucore:hasTopic</a>
    /// </summary>
    let hasTopic = _prefixId.prefix "hasTopic"
    /// <summary>
    ///   <para>rdfs:comment : To associate audio/data/video tracks with a MediaResource.</para>
    ///   <para>rdfs:label : Track</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasTrack">ebucore:hasTrack</a>
    /// </summary>
    let hasTrack = _prefixId.prefix "hasTrack"
    /// <summary>
    ///   <para>rdfs:label : Type</para>
    ///   <para>rdfs:comment : To define a type of BusinessObject is not declared as a subClass of BusinessObject.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasType">ebucore:hasType</a>
    /// </summary>
    let hasType = _prefixId.prefix "hasType"
    /// <summary>
    ///   <para>rdfs:comment : To identify another version of an Asset, BusinessObject or Resource.</para>
    ///   <para>rdfs:label : Version</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasVersion">ebucore:hasVersion</a>
    /// </summary>
    let hasVersion = _prefixId.prefix "hasVersion"
    /// <summary>
    ///   <para>rdfs:label : Video encoding format^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasVideoEncodingFormat">ebucore:hasVideoEncodingFormat</a>
    /// </summary>
    let hasVideoEncodingFormat = _prefixId.prefix "hasVideoEncodingFormat"
    /// <summary>
    ///   <para>rdfs:label : Video format^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasVideoFormat">ebucore:hasVideoFormat</a>
    /// </summary>
    let hasVideoFormat = _prefixId.prefix "hasVideoFormat"
    /// <summary>
    ///   <para>rdfs:label : Hash code</para>
    ///   <para>rdfs:comment : The hash value associated to a Resource. There
    ///             are different methods / algorithms to calculate hash values, which can be defined as
    ///             subproperties.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hashValue">ebucore:hashValue</a>
    /// </summary>
    let hashValue = _prefixId.prefix "hashValue"
    /// <summary>
    ///   <para>rdfs:comment : The height of e.g. a video frame typically
    ///             expressed as a number of lines or the height of a picture/image expressed in millimeters
    ///             or else.</para>
    ///   <para>rdfs:label : Height</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#height">ebucore:height</a>
    /// </summary>
    let height = _prefixId.prefix "height"
    /// <summary>
    ///   <para>rdfs:comment : The unit used to measure a Height e.g. in
    ///             pixels or number of lines or millimeters or else.</para>
    ///   <para>rdfs:label : Height unit</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#heightUnit">ebucore:heightUnit</a>
    /// </summary>
    let heightUnit = _prefixId.prefix "heightUnit"
    /// <summary>
    ///   <para>rdfs:comment : The high pass frequency of the AudioChannel filter.</para>
    ///   <para>rdfs:label : High pass frequency</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#highPass">ebucore:highPass</a>
    /// </summary>
    let highPass = _prefixId.prefix "highPass"
    /// <summary>
    ///   <para>rdfs:comment : To provide highlights.</para>
    ///   <para>rdfs:label : Highlights</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#highlights">ebucore:highlights</a>
    /// </summary>
    let highlights = _prefixId.prefix "highlights"
    /// <summary>
    ///   <para>rdfs:comment : To identify a BusinessObject or Resource on
    ///             which an Agent (Contact/person or Organisation) holds Rights.</para>
    ///   <para>rdfs:label : Asset, resource, object</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#holdsRightsOver">ebucore:holdsRightsOver</a>
    /// </summary>
    let holdsRightsOver = _prefixId.prefix "holdsRightsOver"
    /// <summary>
    ///   <para>rdfs:comment : Corresponds to 'identifier'
    ///             in the W3C Ontology for Media Annotation. The URI may be used to express an alternative
    ///             identifier of the resource, or to share an identifier used by other instances of the
    ///             same resource (equivalent to the fucntionality owl:sameAs).rdfs:comment : This property is intended to provide an
    ///             alternative identifier for the resource, which has no URI counterpart. In the case where
    ///             the alternative identifier can be expressed as a URI, it is recommended to use
    ///             owl:sameAs instead.</para>
    ///   <para>rdfs:label : Identifier</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#identifier">ebucore:identifier</a>
    /// </summary>
    let identifier = _prefixId.prefix "identifier"
    /// <summary>
    ///   <para>rdfs:comment : Identifies the inches per second at which an analog audio tape should be played back for human consumption.</para>
    ///   <para>rdfs:label : Inches per second</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#inchesPerSecond">ebucore:inchesPerSecond</a>
    /// </summary>
    let inchesPerSecond = _prefixId.prefix "inchesPerSecond"
    /// <summary>
    ///   <para>rdfs:comment : To link a particular manifestation of a
    ///             BusinessObject to the corresponding Resource.</para>
    ///   <para>rdfs:label : Business object</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#instantiates">ebucore:instantiates</a>
    /// </summary>
    let instantiates = _prefixId.prefix "instantiates"
    /// <summary>
    ///   <para>rdfs:label : Agent</para>
    ///   <para>rdfs:comment : To identify a Contact/person or Organisation as part of a cast list.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isAgent">ebucore:isAgent</a>
    /// </summary>
    let isAgent = _prefixId.prefix "isAgent"
    /// <summary>
    ///   <para>rdfs:comment : To identify the character personified by a Cast individual.</para>
    ///   <para>rdfs:label : Character</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isCharacter">ebucore:isCharacter</a>
    /// </summary>
    let isCharacter = _prefixId.prefix "isCharacter"
    /// <summary>
    ///   <para>rdfs:comment : Identifies relationship between a digital instantiation of a resource and its direct copy, with no generational loss.</para>
    ///   <para>rdfs:label : Cloned from</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isClonedFrom">ebucore:isClonedFrom</a>
    /// </summary>
    let isClonedFrom = _prefixId.prefix "isClonedFrom"
    /// <summary>
    ///   <para>rdfs:comment : Copyright statement.</para>
    ///   <para>rdfs:label : Copyright</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isCopyrightedBy">ebucore:isCopyrightedBy</a>
    /// </summary>
    let isCopyrightedBy = _prefixId.prefix "isCopyrightedBy"
    /// <summary>
    ///   <para>rdfs:comment : The Rights or policy applicable to the
    ///             BusinessObject, Asset, Resource or PublicationEvent.</para>
    ///   <para>rdfs:label : Rights</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isCoveredBy">ebucore:isCoveredBy</a>
    /// </summary>
    let isCoveredBy = _prefixId.prefix "isCoveredBy"
    /// <summary>
    ///   <para>rdfs:label : Derived from</para>
    ///   <para>rdfs:comment : Identifies a content-based relationship between two resources.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isDerivedFrom">ebucore:isDerivedFrom</a>
    /// </summary>
    let isDerivedFrom = _prefixId.prefix "isDerivedFrom"
    /// <summary>
    ///   <para>rdfs:label : Dubbed from</para>
    ///   <para>rdfs:comment : Identifies relationship between a physical instantiation of a resource and a duplicate physical copy that may involve generational loss.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isDubbedFrom">ebucore:isDubbedFrom</a>
    /// </summary>
    let isDubbedFrom = _prefixId.prefix "isDubbedFrom"
    /// <summary>
    ///   <para>rdfs:comment : The Episode of a Series or a Season.</para>
    ///   <para>rdfs:label : Parent season</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isEpisodeOf">ebucore:isEpisodeOf</a>
    /// </summary>
    let isEpisodeOf = _prefixId.prefix "isEpisodeOf"
    /// <summary>
    ///   <para>rdfs:label : Fictitious contact</para>
    ///   <para>rdfs:comment : To identify Contact/persons being fictitious.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isFictitiousContact">ebucore:isFictitiousContact</a>
    /// </summary>
    let isFictitiousContact = _prefixId.prefix "isFictitiousContact"
    /// <summary>
    ///   <para>rdfs:comment : To identify the MediaResource to which the MediaFragment belongs to.</para>
    ///   <para>rdfs:label : Source</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isMediaFragmentOf">ebucore:isMediaFragmentOf</a>
    /// </summary>
    let isMediaFragmentOf = _prefixId.prefix "isMediaFragmentOf"
    /// <summary>
    ///   <para>rdfs:comment : To identify a Group to which an EidtorialObject is a member of.</para>
    ///   <para>rdfs:label : Member of</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isMemberOf">ebucore:isMemberOf</a>
    /// </summary>
    let isMemberOf = _prefixId.prefix "isMemberOf"
    /// <summary>
    ///   <para>rdfs:label : Next^^xsd:string</para>
    ///   <para>rdfs:comment : A link to a an BusinessObject or a Resource following the current BusinessObject or Resource in an ordered sequence^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isNextInSequence">ebucore:isNextInSequence</a>
    /// </summary>
    let isNextInSequence = _prefixId.prefix "isNextInSequence"
    /// <summary>
    ///   <para>rdfs:comment : To identify the Service that operates the
    ///             PublicationChannel.</para>
    ///   <para>rdfs:label : Operator, owner</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isOperatedBy">ebucore:isOperatedBy</a>
    /// </summary>
    let isOperatedBy = _prefixId.prefix "isOperatedBy"
    /// <summary>
    ///   <para>rdfs:label : Owner</para>
    ///   <para>rdfs:comment : To identify the Agent (Contact/person or
    ///             Organisation) who owns a Service operating a PublicationChannel.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isOwnedBy">ebucore:isOwnedBy</a>
    /// </summary>
    let isOwnedBy = _prefixId.prefix "isOwnedBy"
    /// <summary>
    ///   <para>rdfs:label : Related object, resource</para>
    ///   <para>rdfs:comment : To express references across Assets, BusinessObjects or Resources.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isReferencedBy">ebucore:isReferencedBy</a>
    /// </summary>
    let isReferencedBy = _prefixId.prefix "isReferencedBy"
    /// <summary>
    ///   <para>rdfs:label : Related to</para>
    ///   <para>rdfs:comment : To establish relationships between Assets,
    ///             BusinessObjects, PublicationEvents, Ratings and Resources.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isRelatedTo">ebucore:isRelatedTo</a>
    /// </summary>
    let isRelatedTo = _prefixId.prefix "isRelatedTo"
    /// <summary>
    ///   <para>rdfs:label : Replacement</para>
    ///   <para>rdfs:comment : To identify substitutions.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isReplacedBy">ebucore:isReplacedBy</a>
    /// </summary>
    let isReplacedBy = _prefixId.prefix "isReplacedBy"
    /// <summary>
    ///   <para>rdfs:label : Required</para>
    ///   <para>rdfs:comment : To express strong relations between Assets, BusinessObjects or Resources.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isRequiredBy">ebucore:isRequiredBy</a>
    /// </summary>
    let isRequiredBy = _prefixId.prefix "isRequiredBy"
    /// <summary>
    ///   <para>rdfs:comment : The Season of a Series.</para>
    ///   <para>rdfs:label : Parent Series</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isSeasonOf">ebucore:isSeasonOf</a>
    /// </summary>
    let isSeasonOf = _prefixId.prefix "isSeasonOf"
    /// <summary>
    ///   <para>rdfs:label : Version of</para>
    ///   <para>rdfs:comment : To identify related versions.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isVersionOf">ebucore:isVersionOf</a>
    /// </summary>
    let isVersionOf = _prefixId.prefix "isVersionOf"
    /// <summary>
    ///   <para>rdfs:comment : To provide a definition for a Keyword.</para>
    ///   <para>rdfs:label : Keyword definition</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#keywordDefinition">ebucore:keywordDefinition</a>
    /// </summary>
    let keywordDefinition = _prefixId.prefix "keywordDefinition"
    /// <summary>
    ///   <para>rdfs:label : Line number</para>
    ///   <para>rdfs:comment : To provide the number of the line on which
    ///             ancillary data is being carried and the equivalent in the digital domain.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#lineNumber">ebucore:lineNumber</a>
    /// </summary>
    let lineNumber = _prefixId.prefix "lineNumber"
    /// <summary>
    ///   <para>rdfs:label : Address</para>
    ///   <para>rdfs:comment : To provide the address of a
    ///            Location.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationAddress">ebucore:locationAddress</a>
    /// </summary>
    let locationAddress = _prefixId.prefix "locationAddress"
    /// <summary>
    ///   <para>rdfs:comment : To provide the Area part of an
    ///             Adrress.</para>
    ///   <para>rdfs:label : Area</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationAddressArea">ebucore:locationAddressArea</a>
    /// </summary>
    let locationAddressArea = _prefixId.prefix "locationAddressArea"
    /// <summary>
    ///   <para>rdfs:comment : To provide the country name and or country
    ///             code.</para>
    ///   <para>rdfs:label : Country</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationAddressCountry">ebucore:locationAddressCountry</a>
    /// </summary>
    let locationAddressCountry = _prefixId.prefix "locationAddressCountry"
    /// <summary>
    ///   <para>rdfs:comment : To write address line with e.g. the street name
    ///             and number.</para>
    ///   <para>rdfs:label : Address line</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationAddressLine">ebucore:locationAddressLine</a>
    /// </summary>
    let locationAddressLine = _prefixId.prefix "locationAddressLine"
    /// <summary>
    ///   <para>rdfs:comment : To provide the name of a city, viallge,
    ///             etc.</para>
    ///   <para>rdfs:label : Locality</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationAddressLocality">ebucore:locationAddressLocality</a>
    /// </summary>
    let locationAddressLocality = _prefixId.prefix "locationAddressLocality"
    /// <summary>
    ///   <para>rdfs:comment : To provide an address postal
    ///             code.</para>
    ///   <para>rdfs:label : Postal code</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationAddressPostalCode">ebucore:locationAddressPostalCode</a>
    /// </summary>
    let locationAddressPostalCode = _prefixId.prefix "locationAddressPostalCode"
    /// <summary>
    ///   <para>rdfs:label : Altitude</para>
    ///   <para>rdfs:comment : To define the altitude of a Location in
    ///             meters.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationAltitude">ebucore:locationAltitude</a>
    /// </summary>
    let locationAltitude = _prefixId.prefix "locationAltitude"
    /// <summary>
    ///   <para>rdfs:label : Coordinate system</para>
    ///   <para>rdfs:comment : To specify the name of the gps coordinate
    ///             system used for the Location.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationCoordinateSystemName">ebucore:locationCoordinateSystemName</a>
    /// </summary>
    let locationCoordinateSystemName = _prefixId.prefix "locationCoordinateSystemName"
    /// <summary>
    ///   <para>rdfs:comment : To provide a description of a particular Location.</para>
    ///   <para>rdfs:label : Location description</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationDescription">ebucore:locationDescription</a>
    /// </summary>
    let locationDescription = _prefixId.prefix "locationDescription"
    /// <summary>
    ///   <para>rdfs:comment : The latitude of the Location.</para>
    ///   <para>rdfs:label : Latitude</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationLatitude">ebucore:locationLatitude</a>
    /// </summary>
    let locationLatitude = _prefixId.prefix "locationLatitude"
    /// <summary>
    ///   <para>rdfs:label : Longitude</para>
    ///   <para>rdfs:comment : To define the longitude of the
    ///             Location.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationLongitude">ebucore:locationLongitude</a>
    /// </summary>
    let locationLongitude = _prefixId.prefix "locationLongitude"
    /// <summary>
    ///   <para>rdfs:label : Location name</para>
    ///   <para>rdfs:comment : The name by which a Location is
    ///             known.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationName">ebucore:locationName</a>
    /// </summary>
    let locationName = _prefixId.prefix "locationName"
    /// <summary>
    ///   <para>rdfs:comment : To provide a description of a particular region assocoated to the Location.</para>
    ///   <para>rdfs:label : Region</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationRegion">ebucore:locationRegion</a>
    /// </summary>
    let locationRegion = _prefixId.prefix "locationRegion"
    /// <summary>
    ///   <para>rdfs:comment : A locator from where the Resource can be accessed.</para>
    ///   <para>rdfs:label : Locator^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locator">ebucore:locator</a>
    /// </summary>
    let locator = _prefixId.prefix "locator"
    /// <summary>
    ///   <para>rdfs:comment : Information about storage accessed by the locator.</para>
    ///   <para>rdfs:label : Target information</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locatorTargetInformation">ebucore:locatorTargetInformation</a>
    /// </summary>
    let locatorTargetInformation = _prefixId.prefix "locatorTargetInformation"
    /// <summary>
    ///   <para>rdfs:comment : The value for integrated loudness measured at AudioProgramme or AudioContent level.</para>
    ///   <para>rdfs:label : Integrated loudness</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#loudnessIntegratedLoudness">ebucore:loudnessIntegratedLoudness</a>
    /// </summary>
    let loudnessIntegratedLoudness = _prefixId.prefix "loudnessIntegratedLoudness"
    /// <summary>
    ///   <para>rdfs:label : Max momentary loudness</para>
    ///   <para>rdfs:comment : The value for maximum momentary loudness measured at AudioProgramme or AudioContent level.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#loudnessMaxMomentary">ebucore:loudnessMaxMomentary</a>
    /// </summary>
    let loudnessMaxMomentary = _prefixId.prefix "loudnessMaxMomentary"
    /// <summary>
    ///   <para>rdfs:label : Max true peak loudness</para>
    ///   <para>rdfs:comment : The value for maximum true peak loudness measured at AudioProgramme or AudioContent level.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#loudnessMaxTruepeak">ebucore:loudnessMaxTruepeak</a>
    /// </summary>
    let loudnessMaxTruepeak = _prefixId.prefix "loudnessMaxTruepeak"
    /// <summary>
    ///   <para>rdfs:comment : The method for loudness measurement at AudioProgramme or AudioContent level.</para>
    ///   <para>rdfs:label : Loudness method</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#loudnessMethod">ebucore:loudnessMethod</a>
    /// </summary>
    let loudnessMethod = _prefixId.prefix "loudnessMethod"
    /// <summary>
    ///   <para>rdfs:label : loudness parameters</para>
    ///   <para>rdfs:comment : All the parameters for measurement of loudness at the AudioContent or AudioProgramme level.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#loudnessParameters">ebucore:loudnessParameters</a>
    /// </summary>
    let loudnessParameters = _prefixId.prefix "loudnessParameters"
    /// <summary>
    ///   <para>rdfs:comment : The loudness range measured at AudioProgramme or AudioContent level.</para>
    ///   <para>rdfs:label : Loudness range</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#loudnessRange">ebucore:loudnessRange</a>
    /// </summary>
    let loudnessRange = _prefixId.prefix "loudnessRange"
    /// <summary>
    ///   <para>rdfs:label : Max short term loudness</para>
    ///   <para>rdfs:comment : The maximum short term loudness measured at AudioProgramme or AudioContent level.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#lounessMaxShortTerm">ebucore:lounessMaxShortTerm</a>
    /// </summary>
    let lounessMaxShortTerm = _prefixId.prefix "lounessMaxShortTerm"
    /// <summary>
    ///   <para>rdfs:label : Low pass frequency</para>
    ///   <para>rdfs:comment : The low pass frequency of the AudioChannel filter.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#lowPass">ebucore:lowPass</a>
    /// </summary>
    let lowPass = _prefixId.prefix "lowPass"
    /// <summary>
    ///   <para>rdfs:label : Main title</para>
    ///   <para>rdfs:comment : To provide the main title by which the media
    ///             resource is known.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#mainTitle">ebucore:mainTitle</a>
    /// </summary>
    let mainTitle = _prefixId.prefix "mainTitle"
    /// <summary>
    ///   <para>rdfs:label : Salutation title</para>
    ///   <para>rdfs:comment : To provide a salutation title e.g M. Ms, Dr, Pr.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#nameTitle">ebucore:nameTitle</a>
    /// </summary>
    let nameTitle = _prefixId.prefix "nameTitle"
    /// <summary>
    ///   <para>rdfs:label : Noise filter</para>
    ///   <para>rdfs:comment : A flag to signal that a noise filter has been
    ///             used.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#noiseFilter">ebucore:noiseFilter</a>
    /// </summary>
    let noiseFilter = _prefixId.prefix "noiseFilter"
    /// <summary>
    ///   <para>rdfs:comment : A flag to indicate that the BusinessObejct has not been rated.</para>
    ///   <para>rdfs:label : Not rated</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#notRated">ebucore:notRated</a>
    /// </summary>
    let notRated = _prefixId.prefix "notRated"
    /// <summary>
    ///   <para>rdfs:comment : The number of Tracks composing the MediaResource.</para>
    ///   <para>rdfs:label : Number of tracks</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#numberOfTracks">ebucore:numberOfTracks</a>
    /// </summary>
    let numberOfTracks = _prefixId.prefix "numberOfTracks"
    /// <summary>
    ///   <para>rdfs:label : Audio object type definition</para>
    ///   <para>rdfs:comment : To provide a definition of an AudioObject type.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#objectTypeDefinition">ebucore:objectTypeDefinition</a>
    /// </summary>
    let objectTypeDefinition = _prefixId.prefix "objectTypeDefinition"
    /// <summary>
    ///   <para>rdfs:label : Area code</para>
    ///   <para>rdfs:comment : To provide the Area part of an
    ///             Address.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeAddressArea">ebucore:officeAddressArea</a>
    /// </summary>
    let officeAddressArea = _prefixId.prefix "officeAddressArea"
    /// <summary>
    ///   <para>rdfs:comment : To provide the country name and or country
    ///             code.</para>
    ///   <para>rdfs:label : Country</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeAddressCountry">ebucore:officeAddressCountry</a>
    /// </summary>
    let officeAddressCountry = _prefixId.prefix "officeAddressCountry"
    /// <summary>
    ///   <para>rdfs:comment : To write address line with e.g. the street name
    ///             and number.</para>
    ///   <para>rdfs:label : Address line</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeAddressLine">ebucore:officeAddressLine</a>
    /// </summary>
    let officeAddressLine = _prefixId.prefix "officeAddressLine"
    /// <summary>
    ///   <para>rdfs:comment : To provide the name of a city, village,
    ///             etc.</para>
    ///   <para>rdfs:label : Locality</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeAddressLocality">ebucore:officeAddressLocality</a>
    /// </summary>
    let officeAddressLocality = _prefixId.prefix "officeAddressLocality"
    /// <summary>
    ///   <para>rdfs:comment : To provide an address postal
    ///             code.</para>
    ///   <para>rdfs:label : Postal code</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeAddressPostalCode">ebucore:officeAddressPostalCode</a>
    /// </summary>
    let officeAddressPostalCode = _prefixId.prefix "officeAddressPostalCode"
    /// <summary>
    ///   <para>rdfs:comment : To provide the professional/office email
    ///             address of an agent (Contact/person or organisation).</para>
    ///   <para>rdfs:label : Office email</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeEmailAddress">ebucore:officeEmailAddress</a>
    /// </summary>
    let officeEmailAddress = _prefixId.prefix "officeEmailAddress"
    /// <summary>
    ///   <para>rdfs:comment : To provide an office/professional/company web
    ///             homepage of an Agent (Contact/person or Organisation).</para>
    ///   <para>rdfs:label : Homepage (office)</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeHomepage">ebucore:officeHomepage</a>
    /// </summary>
    let officeHomepage = _prefixId.prefix "officeHomepage"
    /// <summary>
    ///   <para>rdfs:comment : To provide the professional / office address of
    ///             an agent (Contact/person or organisation).</para>
    ///   <para>rdfs:label : Office mail address</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeMailAddress">ebucore:officeMailAddress</a>
    /// </summary>
    let officeMailAddress = _prefixId.prefix "officeMailAddress"
    /// <summary>
    ///   <para>rdfs:comment : To provide the professional/office/company
    ///             mobile telephone number of an agent (Contact/person or organisation).</para>
    ///   <para>rdfs:label : Mobile (office)</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeMobileTelephoneNumber">ebucore:officeMobileTelephoneNumber</a>
    /// </summary>
    let officeMobileTelephoneNumber = _prefixId.prefix "officeMobileTelephoneNumber"
    /// <summary>
    ///   <para>rdfs:label : Telephone (office)</para>
    ///   <para>rdfs:comment : To provide an office/professional/company
    ///             telephone number of an Agent (Contact/person or Organisation).</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeTelephoneNumber">ebucore:officeTelephoneNumber</a>
    /// </summary>
    let officeTelephoneNumber = _prefixId.prefix "officeTelephoneNumber"
    /// <summary>
    ///   <para>rdfs:label : Name</para>
    ///   <para>rdfs:comment : To provide the full name of an Organisation.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#organisationName">ebucore:organisationName</a>
    /// </summary>
    let organisationName = _prefixId.prefix "organisationName"
    /// <summary>
    ///   <para>rdfs:comment : The orientation of a Document or an Image i.e. landscape or
    ///             portrait.</para>
    ///   <para>rdfs:label : Orientation</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#orientation">ebucore:orientation</a>
    /// </summary>
    let orientation = _prefixId.prefix "orientation"
    /// <summary>
    ///   <para>rdfs:label : Original title</para>
    ///   <para>rdfs:comment : To provide the original title attributed to the
    ///             media resource e.g. in its original language.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#originalTitle">ebucore:originalTitle</a>
    /// </summary>
    let originalTitle = _prefixId.prefix "originalTitle"
    /// <summary>
    ///   <para>rdfs:comment : To identify the service (s) that an Agent
    ///             (Contact/person or Organisation) owns.</para>
    ///   <para>rdfs:label : Owns</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#owns">ebucore:owns</a>
    /// </summary>
    let owns = _prefixId.prefix "owns"
    /// <summary>
    ///   <para>rdfs:label : Package size (in bytes)</para>
    ///   <para>rdfs:comment : The size of a media package in
    ///             Bytes.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#packageByteSize">ebucore:packageByteSize</a>
    /// </summary>
    let packageByteSize = _prefixId.prefix "packageByteSize"
    /// <summary>
    ///   <para>rdfs:comment : The name attributed to a
    ///             package.</para>
    ///   <para>rdfs:label : Package name</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#packageName">ebucore:packageName</a>
    /// </summary>
    let packageName = _prefixId.prefix "packageName"
    /// <summary>
    ///   <para>rdfs:comment : A definition associated with the Part.</para>
    ///   <para>rdfs:label : Part definition</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#partDefinition">ebucore:partDefinition</a>
    /// </summary>
    let partDefinition = _prefixId.prefix "partDefinition"
    /// <summary>
    ///   <para>rdfs:label : Part name</para>
    ///   <para>rdfs:comment : A name by which the Part is identified.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#partName">ebucore:partName</a>
    /// </summary>
    let partName = _prefixId.prefix "partName"
    /// <summary>
    ///   <para>rdfs:comment : The number associated to a Part as one among
    ///             many.</para>
    ///   <para>rdfs:label : Part number</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#partNumber">ebucore:partNumber</a>
    /// </summary>
    let partNumber = _prefixId.prefix "partNumber"
    /// <summary>
    ///   <para>rdfs:comment : The total number of Parts associated with a
    ///             BusinessObject.</para>
    ///   <para>rdfs:label : Total number of parts</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#partTotalNumber">ebucore:partTotalNumber</a>
    /// </summary>
    let partTotalNumber = _prefixId.prefix "partTotalNumber"
    /// <summary>
    ///   <para>rdfs:label : Playback speed</para>
    ///   <para>rdfs:comment : Identifies the rate of units against time at which the resource should be played back for human consumption.  If the unit of measure is known, use sub-properties framesPerSecond or inchesPerSecond.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#playbackSpeed">ebucore:playbackSpeed</a>
    /// </summary>
    let playbackSpeed = _prefixId.prefix "playbackSpeed"
    /// <summary>
    ///   <para>rdfs:comment : To describe a playlist.</para>
    ///   <para>rdfs:label : Playlist</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#playlist">ebucore:playlist</a>
    /// </summary>
    let playlist = _prefixId.prefix "playlist"
    /// <summary>
    ///   <para>rdfs:comment : To provide the Area part of an
    ///             Adrress.</para>
    ///   <para>rdfs:label : Area code</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateAddressArea">ebucore:privateAddressArea</a>
    /// </summary>
    let privateAddressArea = _prefixId.prefix "privateAddressArea"
    /// <summary>
    ///   <para>rdfs:comment : To provide the country name and or country
    ///             code.</para>
    ///   <para>rdfs:label : Country</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateAddressCountry">ebucore:privateAddressCountry</a>
    /// </summary>
    let privateAddressCountry = _prefixId.prefix "privateAddressCountry"
    /// <summary>
    ///   <para>rdfs:comment : To write address line with e.g. the street name
    ///             and number.</para>
    ///   <para>rdfs:label : Address line</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateAddressLine">ebucore:privateAddressLine</a>
    /// </summary>
    let privateAddressLine = _prefixId.prefix "privateAddressLine"
    /// <summary>
    ///   <para>rdfs:comment : To provide the name of a city, viallge,
    ///             etc.</para>
    ///   <para>rdfs:label : Locality</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateAddressLocality">ebucore:privateAddressLocality</a>
    /// </summary>
    let privateAddressLocality = _prefixId.prefix "privateAddressLocality"
    /// <summary>
    ///   <para>rdfs:comment : To provide an address postal
    ///             code.</para>
    ///   <para>rdfs:label : Postal code</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateAddressPostalCode">ebucore:privateAddressPostalCode</a>
    /// </summary>
    let privateAddressPostalCode = _prefixId.prefix "privateAddressPostalCode"
    /// <summary>
    ///   <para>rdfs:label : Private email</para>
    ///   <para>rdfs:comment : To provide the private email address of an
    ///             agent (Contact/person)</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateEmailAddress">ebucore:privateEmailAddress</a>
    /// </summary>
    let privateEmailAddress = _prefixId.prefix "privateEmailAddress"
    /// <summary>
    ///   <para>rdfs:comment : To provide an private web homepage of an Agent
    ///             (Contact/person).</para>
    ///   <para>rdfs:label : Homepage (private)</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateHomepage">ebucore:privateHomepage</a>
    /// </summary>
    let privateHomepage = _prefixId.prefix "privateHomepage"
    /// <summary>
    ///   <para>rdfs:comment : To provide the private / personal address of an
    ///             agent (Contact/person).</para>
    ///   <para>rdfs:label : Private mail address</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateMailAddress">ebucore:privateMailAddress</a>
    /// </summary>
    let privateMailAddress = _prefixId.prefix "privateMailAddress"
    /// <summary>
    ///   <para>rdfs:label : Mobile (private)</para>
    ///   <para>rdfs:comment : To provide the private mobile telephone number
    ///             of an agent (Contact/person).</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateMobileTelephoneNumber">ebucore:privateMobileTelephoneNumber</a>
    /// </summary>
    let privateMobileTelephoneNumber = _prefixId.prefix "privateMobileTelephoneNumber"
    /// <summary>
    ///   <para>rdfs:label : Telephone (private)</para>
    ///   <para>rdfs:comment : To provide the private telephone number of an
    ///             Agent (Contact/person).</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateTelephoneNumber">ebucore:privateTelephoneNumber</a>
    /// </summary>
    let privateTelephoneNumber = _prefixId.prefix "privateTelephoneNumber"
    /// <summary>
    ///   <para>rdfs:comment : To provide textual promotional information.</para>
    ///   <para>rdfs:label : Promotional information</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#promotionalInformation">ebucore:promotionalInformation</a>
    /// </summary>
    let promotionalInformation = _prefixId.prefix "promotionalInformation"
    /// <summary>
    ///   <para>rdfs:comment : To indicate a publication status.</para>
    ///   <para>rdfs:label : Publication status</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#pubStatus">ebucore:pubStatus</a>
    /// </summary>
    let pubStatus = _prefixId.prefix "pubStatus"
    /// <summary>
    ///   <para>rdfs:comment : To provide a name to a PublicationChannel e.g. a TV channel or website.</para>
    ///   <para>rdfs:label : Publication channel name</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publicationChannelName">ebucore:publicationChannelName</a>
    /// </summary>
    let publicationChannelName = _prefixId.prefix "publicationChannelName"
    /// <summary>
    ///   <para>rdfs:comment : The actual end date and time of a PublicationEvent.</para>
    ///   <para>rdfs:label : Publication end date &amp; time</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publicationEndDateTime">ebucore:publicationEndDateTime</a>
    /// </summary>
    let publicationEndDateTime = _prefixId.prefix "publicationEndDateTime"
    /// <summary>
    ///   <para>rdfs:comment : To provide a name to a PublicationEvent.</para>
    ///   <para>rdfs:label : Publication event name</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publicationEventName">ebucore:publicationEventName</a>
    /// </summary>
    let publicationEventName = _prefixId.prefix "publicationEventName"
    /// <summary>
    ///   <para>rdfs:label : schedule date</para>
    ///   <para>rdfs:comment : To express specifically the schedule date to which a PublicationEvent is related in particular if the broacdast time is after midnight. For example, the schedule date would be May 29th and the programme is published at 1 am on May 30th, while still associated in the schedule with the night of May 29th.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publicationScheduleDate">ebucore:publicationScheduleDate</a>
    /// </summary>
    let publicationScheduleDate = _prefixId.prefix "publicationScheduleDate"
    /// <summary>
    ///   <para>rdfs:comment : The actual start date and time of a PublicationEvent.</para>
    ///   <para>rdfs:label : Publication start date &amp; time</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publicationStartDateTime">ebucore:publicationStartDateTime</a>
    /// </summary>
    let publicationStartDateTime = _prefixId.prefix "publicationStartDateTime"
    /// <summary>
    ///   <para>rdfs:comment : The end date and time of a PublicationEvent as
    ///             scheduled.</para>
    ///   <para>rdfs:label : Publication end date &amp; time</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publishedEndDateTime">ebucore:publishedEndDateTime</a>
    /// </summary>
    let publishedEndDateTime = _prefixId.prefix "publishedEndDateTime"
    /// <summary>
    ///   <para>rdfs:comment : The start date and time of a PublicationEvent
    ///             as scheduled.</para>
    ///   <para>rdfs:label : Publication start date &amp; time</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publishedStartDateTime">ebucore:publishedStartDateTime</a>
    /// </summary>
    let publishedStartDateTime = _prefixId.prefix "publishedStartDateTime"
    /// <summary>
    ///   <para>rdfs:label : Published title.</para>
    ///   <para>rdfs:comment : The title used to identify the work at publication time.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publishedTitle">ebucore:publishedTitle</a>
    /// </summary>
    let publishedTitle = _prefixId.prefix "publishedTitle"
    /// <summary>
    ///   <para>rdfs:comment : The maximum value of the scale used for rating
    ///             a media resource.</para>
    ///   <para>rdfs:label : Rating scale (top value)</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ratingScaleMax">ebucore:ratingScaleMax</a>
    /// </summary>
    let ratingScaleMax = _prefixId.prefix "ratingScaleMax"
    /// <summary>
    ///   <para>rdfs:label : Rating scale (min. value)</para>
    ///   <para>rdfs:comment : The minimum value of the scale used for rating
    ///             a Resource.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ratingScaleMin">ebucore:ratingScaleMin</a>
    /// </summary>
    let ratingScaleMin = _prefixId.prefix "ratingScaleMin"
    /// <summary>
    ///   <para>rdfs:label : Rating environment</para>
    ///   <para>rdfs:comment : To identify the environment in which rating applies.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ratingSystemEnvironment">ebucore:ratingSystemEnvironment</a>
    /// </summary>
    let ratingSystemEnvironment = _prefixId.prefix "ratingSystemEnvironment"
    /// <summary>
    ///   <para>rdfs:comment : To identify a rating system by its name.</para>
    ///   <para>rdfs:label : Rating system</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ratingSystemName">ebucore:ratingSystemName</a>
    /// </summary>
    let ratingSystemName = _prefixId.prefix "ratingSystemName"
    /// <summary>
    ///   <para>rdfs:label : Rating</para>
    ///   <para>rdfs:comment : To express a free text rating value defined in
    ///             a rating classification scheme.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ratingValue">ebucore:ratingValue</a>
    /// </summary>
    let ratingValue = _prefixId.prefix "ratingValue"
    /// <summary>
    ///   <para>rdfs:comment : To provide a reason for which Rating as been attributed as provided.</para>
    ///   <para>rdfs:label : Reason</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#reason">ebucore:reason</a>
    /// </summary>
    let reason = _prefixId.prefix "reason"
    /// <summary>
    ///   <para>rdfs:label : References</para>
    ///   <para>rdfs:comment : To express a reference between Assets, BusinessObjects or Resources.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#references">ebucore:references</a>
    /// </summary>
    let references = _prefixId.prefix "references"
    /// <summary>
    ///   <para>rdfs:comment : To define the bottom right corner of a zone on
    ///             the x-axis. If present with regionDelimY, the zone definition is complemented by the
    ///             associated values of the height and width.</para>
    ///   <para>rdfs:label : Region delimiter (x-axis)</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#regionDelimX">ebucore:regionDelimX</a>
    /// </summary>
    let regionDelimX = _prefixId.prefix "regionDelimX"
    /// <summary>
    ///   <para>rdfs:comment : To define the bottom right corner of a zone on
    ///             the y-axis. If present with regionDelimX, the zone definition is complemented by the
    ///             associated values of the height and width.</para>
    ///   <para>rdfs:label : Region delimiter (y-axis)</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#regionDelimY">ebucore:regionDelimY</a>
    /// </summary>
    let regionDelimY = _prefixId.prefix "regionDelimY"
    /// <summary>
    ///   <para>rdfs:label : Related resources</para>
    ///   <para>rdfs:comment : To provide a link to a web resource containing
    ///             information related to an Agent (Contact/person or Organisation).</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#relatedLink">ebucore:relatedLink</a>
    /// </summary>
    let relatedLink = _prefixId.prefix "relatedLink"
    /// <summary>
    ///   <para>rdfs:label : Replaces</para>
    ///   <para>rdfs:comment : To identify substitution.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#replaces">ebucore:replaces</a>
    /// </summary>
    let replaces = _prefixId.prefix "replaces"
    /// <summary>
    ///   <para>rdfs:label : Requires</para>
    ///   <para>rdfs:comment : To express dependency.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#requires">ebucore:requires</a>
    /// </summary>
    let requires = _prefixId.prefix "requires"
    /// <summary>
    ///   <para>rdfs:label : Resource description^^xsd:string</para>
    ///   <para>rdfs:comment : This can be specialised by using sub-properties
    ///             like defined in http://www.ebu.ch/metadata/cs/web/ebu_DescriptionTypeCodeCS_p.xml.htm
    ///             implemented as examples as e.g. 'summary' or
    ///             'script'.^^xsd:string</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#resourceDescription">ebucore:resourceDescription</a>
    /// </summary>
    let resourceDescription = _prefixId.prefix "resourceDescription"
    /// <summary>
    ///   <para>rdfs:label : Resource description</para>
    ///   <para>rdfs:comment : A name by which the resource can be identified.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#resourceName">ebucore:resourceName</a>
    /// </summary>
    let resourceName = _prefixId.prefix "resourceName"
    /// <summary>
    ///   <para>rdfs:comment : To provide a text for a review.</para>
    ///   <para>rdfs:label : Review</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#review">ebucore:review</a>
    /// </summary>
    let review = _prefixId.prefix "review"
    /// <summary>
    ///   <para>rdfs:label : Rights expression</para>
    ///   <para>rdfs:comment : The expression of Rights as free
    ///             text.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#rightsExpression">ebucore:rightsExpression</a>
    /// </summary>
    let rightsExpression = _prefixId.prefix "rightsExpression"
    /// <summary>
    ///   <para>rdfs:label : Rights web resource</para>
    ///   <para>rdfs:comment : A link to e.g. a webpage where an expression of
    ///             the rights can be found and consulted.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#rightsLink">ebucore:rightsLink</a>
    /// </summary>
    let rightsLink = _prefixId.prefix "rightsLink"
    /// <summary>
    ///   <para>rdfs:comment : To provide a definition for a role</para>
    ///   <para>rdfs:label : Role definition</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#roleDefinition">ebucore:roleDefinition</a>
    /// </summary>
    let roleDefinition = _prefixId.prefix "roleDefinition"
    /// <summary>
    ///   <para>rdfs:comment : The frequency at which audio is sampled per second. Also called sampling rate.</para>
    ///   <para>rdfs:label : Sample Rate</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#sampleRate">ebucore:sampleRate</a>
    /// </summary>
    let sampleRate = _prefixId.prefix "sampleRate"
    /// <summary>
    ///   <para>rdfs:comment : The size of an audio sample in
    ///             bits. Also called bit depth.</para>
    ///   <para>rdfs:label : Sample size</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#sampleSize">ebucore:sampleSize</a>
    /// </summary>
    let sampleSize = _prefixId.prefix "sampleSize"
    /// <summary>
    ///   <para>rdfs:label : Sample type</para>
    ///   <para>rdfs:comment : The type of audio sample.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#sampleType">ebucore:sampleType</a>
    /// </summary>
    let sampleType = _prefixId.prefix "sampleType"
    /// <summary>
    ///   <para>rdfs:comment : To define the scanning format for a
    ///             MediaResource. For video, the two main values are "interlaced" or
    ///             "progressive".</para>
    ///   <para>rdfs:label : Sampling format</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#scanningFormat">ebucore:scanningFormat</a>
    /// </summary>
    let scanningFormat = _prefixId.prefix "scanningFormat"
    /// <summary>
    ///   <para>rdfs:comment : To provide a script.</para>
    ///   <para>rdfs:label : Script</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#script">ebucore:script</a>
    /// </summary>
    let script = _prefixId.prefix "script"
    /// <summary>
    ///   <para>rdfs:label : Shot log</para>
    ///   <para>rdfs:comment : Provides a shot-by-shot description of resource content.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#shotlog">ebucore:shotlog</a>
    /// </summary>
    let shotlog = _prefixId.prefix "shotlog"
    /// <summary>
    ///   <para>rdfs:label : Signing source</para>
    ///   <para>rdfs:comment : To identify the source of the signing
    ///             resource.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#signingSource">ebucore:signingSource</a>
    /// </summary>
    let signingSource = _prefixId.prefix "signingSource"
    /// <summary>
    ///   <para>rdfs:comment : The start point of the MediaResource.</para>
    ///   <para>rdfs:label : Start time</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#start">ebucore:start</a>
    /// </summary>
    let start = _prefixId.prefix "start"
    /// <summary>
    ///   <para>rdfs:comment : The start time expressed using a time
    ///             expression.</para>
    ///   <para>rdfs:label : Start time (time)</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#startNormalPlayTime">ebucore:startNormalPlayTime</a>
    /// </summary>
    let startNormalPlayTime = _prefixId.prefix "startNormalPlayTime"
    /// <summary>
    ///   <para>rdfs:comment : A start time expressed as a number of edit
    ///             units.</para>
    ///   <para>rdfs:label : Start time (edit units)</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#startNumberEditUnits">ebucore:startNumberEditUnits</a>
    /// </summary>
    let startNumberEditUnits = _prefixId.prefix "startNumberEditUnits"
    /// <summary>
    ///   <para>rdfs:comment : A start time expressed as
    ///             timecode.</para>
    ///   <para>rdfs:label : Start time (timecode)</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#startTimecode">ebucore:startTimecode</a>
    /// </summary>
    let startTimecode = _prefixId.prefix "startTimecode"
    /// <summary>
    ///   <para>rdfs:comment : To provide a definition for storage.</para>
    ///   <para>rdfs:label : Storage definition</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#storageDefinition">ebucore:storageDefinition</a>
    /// </summary>
    let storageDefinition = _prefixId.prefix "storageDefinition"
    /// <summary>
    ///   <para>rdfs:label : Subtitle</para>
    ///   <para>rdfs:comment : A complementary subtitle.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#subtitle">ebucore:subtitle</a>
    /// </summary>
    let subtitle = _prefixId.prefix "subtitle"
    /// <summary>
    ///   <para>rdfs:comment : To identify the source of the Subtitling
    ///             resource.</para>
    ///   <para>rdfs:label : Subtitling source</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#subtitlingSource">ebucore:subtitlingSource</a>
    /// </summary>
    let subtitlingSource = _prefixId.prefix "subtitlingSource"
    /// <summary>
    ///   <para>rdfs:comment : To provide a summary.</para>
    ///   <para>rdfs:label : Summary</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#summary">ebucore:summary</a>
    /// </summary>
    let summary = _prefixId.prefix "summary"
    /// <summary>
    ///   <para>rdfs:comment : To provide a summary.</para>
    ///   <para>rdfs:label : Synopsis</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#synopsis">ebucore:synopsis</a>
    /// </summary>
    let synopsis = _prefixId.prefix "synopsis"
    /// <summary>
    ///   <para>rdfs:comment : To provide a Table of Content.</para>
    ///   <para>rdfs:label : Table of Content</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#tableOfContent">ebucore:tableOfContent</a>
    /// </summary>
    let tableOfContent = _prefixId.prefix "tableOfContent"
    /// <summary>
    ///   <para>rdfs:comment : To define the system used to provide a TargetAudience.</para>
    ///   <para>rdfs:label : Target audience system</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#targetAudienceSystem">ebucore:targetAudienceSystem</a>
    /// </summary>
    let targetAudienceSystem = _prefixId.prefix "targetAudienceSystem"
    /// <summary>
    ///   <para>rdfs:label : Note</para>
    ///   <para>rdfs:comment : The value of an Annotation as free
    ///             text.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#textualAnnotation">ebucore:textualAnnotation</a>
    /// </summary>
    let textualAnnotation = _prefixId.prefix "textualAnnotation"
    /// <summary>
    ///   <para>rdfs:comment : All value of the EBU title status
    ///             classification scheme
    ///             (http://www.ebu.ch/metadata/cs/web/ebu_TitleStatusCodeCS_p.xml.htm) are candidates
    ///             subproperties of the title property as implemented for an example with
    ///             alternativeTitle.rdfs:comment : Specifies the title or name given to the
    ///             resource.  A root for the definition of subproperties defining ebucore titles of different types. The ebucore title type can be used to define sub-properties to optionally refine the category of
    ///             the title.</para>
    ///   <para>rdfs:label : Title</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#title">ebucore:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>rdfs:comment : To provide a definition associated to a
    ///             Track.</para>
    ///   <para>rdfs:label : Definition</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#trackDefinition">ebucore:trackDefinition</a>
    /// </summary>
    let trackDefinition = _prefixId.prefix "trackDefinition"
    /// <summary>
    ///   <para>rdfs:label : Track name</para>
    ///   <para>rdfs:comment : The name attributed to a Track.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#trackName">ebucore:trackName</a>
    /// </summary>
    let trackName = _prefixId.prefix "trackName"
    /// <summary>
    ///   <para>rdfs:comment : A translated version of the title.</para>
    ///   <para>rdfs:label : Translation title</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#translationTitle">ebucore:translationTitle</a>
    /// </summary>
    let translationTitle = _prefixId.prefix "translationTitle"
    /// <summary>
    ///   <para>rdfs:comment : An alternative title specific to a verison of content.</para>
    ///   <para>rdfs:label : Version title</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#versionTitle">ebucore:versionTitle</a>
    /// </summary>
    let versionTitle = _prefixId.prefix "versionTitle"
    /// <summary>
    ///   <para>rdfs:comment : The width of e.g. a video frame typically
    ///             expressed as a number of pixels, or picture/image in millimeters.</para>
    ///   <para>rdfs:label : Width</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#width">ebucore:width</a>
    /// </summary>
    let width = _prefixId.prefix "width"
    /// <summary>
    ///   <para>rdfs:comment : The unit used to measure a width e.g. in pixels
    ///             or number of lines or millimeters or else.</para>
    ///   <para>rdfs:label : Width unit</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#widthUnit">ebucore:widthUnit</a>
    /// </summary>
    let widthUnit = _prefixId.prefix "widthUnit"
    /// <summary>
    ///   <para>rdfs:comment : The number of words contained in a
    ///             document.</para>
    ///   <para>rdfs:label : Word count</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#wordCount">ebucore:wordCount</a>
    /// </summary>
    let wordCount = _prefixId.prefix "wordCount"
    /// <summary>
    ///   <para>rdfs:comment : A title used while content is not complete.</para>
    ///   <para>rdfs:label : Working title</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#workingTitle">ebucore:workingTitle</a>
    /// </summary>
    let workingTitle = _prefixId.prefix "workingTitle"
    /// <summary>
    ///   <para>rdfs:label : Wrapping type</para>
    ///   <para>rdfs:comment : To provide additional information on the
    ///             wrapping type of ancillary data.</para>
    ///   <a href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#wrappingType">ebucore:wrappingType</a>
    /// </summary>
    let wrappingType = _prefixId.prefix "wrappingType"
