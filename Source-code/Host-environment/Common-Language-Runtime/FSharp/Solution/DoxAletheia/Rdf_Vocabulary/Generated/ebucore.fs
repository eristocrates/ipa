namespace http.www.ebu.ch.metadata.ontologies.ebucore.ebucore.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ebucore =
    let _namespace_iri = Namespace_Iri ebucore |> NamespaceIRI
    /// <summary>
    ///   <para>ebucore:AccessConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The conditions under which content can be accessed."</para>
    /// labels<para>"Access conditions"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AccessConditions">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AccessConditions</seealso>
    let AccessConditions = Prefixed_Name(ebucore, "AccessConditions") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Affiliation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An Organisation to which a Contact is affiliated (with period of validity)."</para>
    /// labels<para>"Affiliation"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Affiliation">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Affiliation</seealso>
    let Affiliation = Prefixed_Name(ebucore, "Affiliation") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A person / contact or organisation."</para>
    /// labels<para>"Agent"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Agent">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Agent</seealso>
    let Agent = Prefixed_Name(ebucore, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:AncillaryData</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Any ancillary data provided with the content
    ///             other than captioning and subtitling."</para>
    /// labels<para>"Ancillary data"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AncillaryData">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AncillaryData</seealso>
    let AncillaryData = Prefixed_Name(ebucore, "AncillaryData") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:AncillaryDataFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"To define the format of AncillaryData such as
    ///             legacy data used to be carried in vertical blanking intervals. This is provided as free
    ///             text in an annotation label or as an identifier pointing to a term in a classification
    ///             scheme."</para>
    /// labels<para>"Ancillary data format"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AncillaryDataFormat">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AncillaryDataFormat</seealso>
    let AncillaryDataFormat =
        Prefixed_Name(ebucore, "AncillaryDataFormat") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A set of descriptive or technical metadata.
    ///             Annotation can also be made in the form of a document or media resource such as an or
    ///             video audio file . An annotation can exist on its own and be related / associated to
    ///             other editorial objects or resources."</para>
    /// labels<para>"Annotation"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Annotation">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Annotation</seealso>
    let Annotation = Prefixed_Name(ebucore, "Annotation") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Asset</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The Class "Asset" is an
    ///             object to which an identifier will be associated at commissioning. It will serve as a
    ///             central reference point to manage rights associated to EditorialObjects, Resources,
    ///             MediaResources or Essences, and PublicationEvents (distribution and exploitation
    ///             conditions)."</para>
    /// labels<para>"Asset"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Asset">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Asset</seealso>
    let Asset = Prefixed_Name(ebucore, "Asset") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:AudienceRating</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The audience by which the Resource can be
    ///             seen according to ratings like MPAA  (http://en.wikipedia.org/wiki/Motion_picture_rating_system) or other organisational / national / local standards."</para>
    /// labels<para>"Audience rating"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudienceRating">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudienceRating</seealso>
    let AudienceRating = Prefixed_Name(ebucore, "AudienceRating") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:AudioChannel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An audioChannel represents a single sequence of audio samples. It
    /// 				is sub-divided in the time domain into audioBlocks, which is must contain at
    /// 				least one of. The typeDefintion of the audioChannel format specifies the type of
    /// 				audio it is describing, and also determines which parameters are used within its
    /// 				audioBlock children."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Audio channel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioChannel">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioChannel</seealso>
    let AudioChannel = Prefixed_Name(ebucore, "AudioChannel") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:AudioContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An audioContent defines one component of a programme (e.g. background
    /// 				music), its association with an audioGroup (e.g. a 2.0 audioPackFormat of
    /// 				audioChannelFormats for stereo reproduction), its association with an
    /// 				audioStreamFormat, and its set of loudness parameters."</para>
    /// labels<para>"Audio content"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioContent">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioContent</seealso>
    let AudioContent = Prefixed_Name(ebucore, "AudioContent") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:AudioDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Audio description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioDescription">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioDescription</seealso>
    let AudioDescription = Prefixed_Name(ebucore, "AudioDescription") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:AudioEncodingFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The encoding format for the audio."</para>
    /// labels<para>"Audio encoding format"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioEncodingFormat">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioEncodingFormat</seealso>
    let AudioEncodingFormat =
        Prefixed_Name(ebucore, "AudioEncodingFormat") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:AudioFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The technical characteristics of an
    ///             AudioResource such as the sampleRate. This is provided as free text in an annotation
    ///             label or as an identifier pointing to a term in a classification scheme e.g.
    ///             http://www.ebu.ch/metadata/ontologies/skos/ebu_AudioFormatCodeCS.rdf."</para>
    /// labels<para>"Audio Format"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioFormat">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioFormat</seealso>
    let AudioFormat = Prefixed_Name(ebucore, "AudioFormat") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:AudioPackFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The format of an AudioPack. Examples of audioPackFormats are 'stereo' and '5.1' for channel-based formats."</para>
    /// labels<para>"Audio pack format"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioPackFormat">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioPackFormat</seealso>
    let AudioPackFormat = Prefixed_Name(ebucore, "AudioPackFormat") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:AudioProgramme</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A set of one or more audioContent that derive from the same material,
    /// 				i.e. an audioMultiplex, and the definition of its multiplexed audioContents (e.g.
    /// 				foreground and commentary, background music)."</para>
    /// labels<para>"Audio programme"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioProgramme">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioProgramme</seealso>
    let AudioProgramme = Prefixed_Name(ebucore, "AudioProgramme") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:AudioStream</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An audioStreamFormat describes a decodable signal - PCM signal or a Dolby E stream for example. It is composed of one or more AudioTracks."</para>
    /// labels<para>"Audio stream"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioStream">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioStream</seealso>
    let AudioStream = Prefixed_Name(ebucore, "AudioStream") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:AudioStreamFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The format of an AudioStream, e.g. PCM_FrontLeft or Dolby E."</para>
    /// labels<para>"Audio stream format"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioStreamFormat">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioStreamFormat</seealso>
    let AudioStreamFormat = Prefixed_Name(ebucore, "AudioStreamFormat") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:AudioTrack</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Represents a physical container or carrier to hold an audio stream. This
    /// 				should be usually defined by many attributes such as ID, format (e.g. 48 kHz/24
    /// 				bits), linkage information (e.g. odd/even)…"</para>
    ///   <para>"An audioTrack is the basic audio data container of a medium. Attribute is
    /// 				an unambiguous reference to this container in a given medium."</para>
    ///   <para>"An audioTrack object defines a component of an audioStream.
    /// 				A single set of samples or data in the storage medium."</para>
    /// labels<para>"Audio track"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioTrack">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioTrack</seealso>
    let AudioTrack = Prefixed_Name(ebucore, "AudioTrack") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:AudioTrackFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The format of an AudioTrack e.g. PCM_FrontLeft."</para>
    /// labels<para>"Audio track format"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioTrackFormat">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#AudioTrackFormat</seealso>
    let AudioTrackFormat = Prefixed_Name(ebucore, "AudioTrackFormat") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:BibliographicalObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Bibliographical object"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#BibliographicalObject">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#BibliographicalObject</seealso>
    let BibliographicalObject =
        Prefixed_Name(ebucore, "BibliographicalObject") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:Brand</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A group of EditorialObjects having a Brand as a
    ///             common denominator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Brand"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Brand">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Brand</seealso>
    let Brand = Prefixed_Name(ebucore, "Brand") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:BusinessObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An image, a document, an annotation
    ///             (descriptive textual metadata or audio/video tag), a tag (time related in audiovisual
    ///             media resources), or an audiovisual media resource (optionally composed of one or more
    ///             fragment / part and / or audio, video data tracks). Other types of BusinessObjects may
    ///             be defined as subclasses."</para>
    /// labels<para>"Business Object"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#BusinessObject">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#BusinessObject</seealso>
    let BusinessObject = Prefixed_Name(ebucore, "BusinessObject") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Captioning</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"To signal the presence of hard of hearing
    ///             captioning."</para>
    /// labels<para>"Captioning"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Captioning">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Captioning</seealso>
    let Captioning = Prefixed_Name(ebucore, "Captioning") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:CaptioningFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"To define the format of captioning.
    ///             Captioning's main use isfor hard of hearing transcription. This is provided as
    ///             free text in an annotation label or as an identifier pointing to a term in a
    ///             classification scheme."</para>
    /// labels<para>"Captioning format"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#CaptioningFormat">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#CaptioningFormat</seealso>
    let CaptioningFormat = Prefixed_Name(ebucore, "CaptioningFormat") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Cast</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A member of the cast list (a list of performers/actors and associated fictitious
    ///             characters)."</para>
    /// labels<para>"Cast member"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Cast">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Cast</seealso>
    let Cast = Prefixed_Name(ebucore, "Cast") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Character</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"E.g. a fictitious contact / person."</para>
    /// labels<para>"Character"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Character">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Character</seealso>
    let Character = Prefixed_Name(ebucore, "Character") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:ClosedCaptions</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Closed captioning is provided as separate
    ///             content."</para>
    /// labels<para>"Closed caption"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ClosedCaptions">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ClosedCaptions</seealso>
    let ClosedCaptions = Prefixed_Name(ebucore, "ClosedCaptions") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:ClosedSubtitling</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Closed subtitles are provided as separate
    ///             content."</para>
    /// labels<para>"Closed subtitling"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ClosedSubtitling">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ClosedSubtitling</seealso>
    let ClosedSubtitling = Prefixed_Name(ebucore, "ClosedSubtitling") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Codec</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"To provide information on a codec."</para>
    /// labels<para>"Codec"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Codec">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Codec</seealso>
    let Codec = Prefixed_Name(ebucore, "Codec") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A group of EditorialObjects. There can be many
    ///             types of collections for which specific sub-classes should be defined. In the worl of
    ///             archives, A collection corresponds to all items belonging to an individual /
    ///             collector."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Collection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Collection">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Collection</seealso>
    let Collection = Prefixed_Name(ebucore, "Collection") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:ColourSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The CoulourSpace of a VideoResource. A
    ///             ColourSpace is defined as free text in an annotation label or as an identifier pointing
    ///             to a term in a classification scheme such as
    ///             http://www.ebu.ch/metadata/ontologies/skos/ebu_ColourCodeCS.rdf."</para>
    /// labels<para>"Colour space"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ColourSpace">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ColourSpace</seealso>
    let ColourSpace = Prefixed_Name(ebucore, "ColourSpace") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Component</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A component e.g. audio, video, data or else or a MediaResource or Essence."</para>
    /// labels<para>"Component"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Component">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Component</seealso>
    let Component = Prefixed_Name(ebucore, "Component") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Contact</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A physical person."</para>
    /// labels<para>"Contact"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Contact">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Contact</seealso>
    let Contact = Prefixed_Name(ebucore, "Contact") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:ContainerFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The container or wrapper format used to package
    ///             audio, video and data components of a Mediaresource. The format is defined as free text
    ///             or pointing at a term in a classification scheme e.g.
    ///             http://www.ebu.ch/metadata/ontologies/skos/ebu_ContainerFormatCS.rdf."</para>
    /// labels<para>"Container format"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ContainerFormat">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ContainerFormat</seealso>
    let ContainerFormat = Prefixed_Name(ebucore, "ContainerFormat") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:ContainerMimeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The definition of the container if available as
    ///             a MIME type. This is provided as free text in an annotation label or as an identifier
    ///             pointing to a term in a classification scheme. For more information:
    ///             http://www.iana.org/assignments/media-types/application/index.html."</para>
    /// labels<para>"Container Mime type"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ContainerMimeType">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ContainerMimeType</seealso>
    let ContainerMimeType = Prefixed_Name(ebucore, "ContainerMimeType") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Copyright</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"To provide a copyright
    ///             statement."</para>
    /// labels<para>"Copyright"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Copyright">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Copyright</seealso>
    let Copyright = Prefixed_Name(ebucore, "Copyright") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:CoverageRestrictions</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"To provide information on possible restrictions
    ///             regarding the temporal and spatial coverage for publication."</para>
    /// labels<para>"Coverage restrictions"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#CoverageRestrictions">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#CoverageRestrictions</seealso>
    let CoverageRestrictions =
        Prefixed_Name(ebucore, "CoverageRestrictions") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:Crew</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Crew member."</para>
    /// labels<para>"Crew member"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Crew">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Crew</seealso>
    let Crew = Prefixed_Name(ebucore, "Crew") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:DID</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The Data Identifier word (along with the SDID,
    ///             if used), indicates the type of ancillary data that the packet corresponds
    ///             to."</para>
    /// labels<para>"DID"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#DID">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#DID</seealso>
    let DID = Prefixed_Name(ebucore, "DID") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:DataFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"To provide addtional technical information on
    ///             the characteristics of data streams in a MediaResource including but not limited to
    ///             AncillaryData, Subtilting and Captioning. Additional specific data format may be defined
    ///             as subclasses of DataFormat."</para>
    /// labels<para>"Data format"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#DataFormat">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#DataFormat</seealso>
    let DataFormat = Prefixed_Name(ebucore, "DataFormat") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:DataTrack</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Ancillary data track e.g. ¨captioning"
    ///             or "subtitling" in addition to video and audio tracks."</para>
    /// labels<para>"Data track"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#DataTrack">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#DataTrack</seealso>
    let DataTrack = Prefixed_Name(ebucore, "DataTrack") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Department</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A department within and
    ///             organisation."</para>
    /// labels<para>"Department"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Department">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Department</seealso>
    let Department = Prefixed_Name(ebucore, "Department") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:DepictedEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A DepictedEVent is fictitious or historical or
    ///             other sort of Event that the content of the BusinessObject or resource relates
    ///             to."</para>
    /// labels<para>"Depicted Event"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#DepictedEvent">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#DepictedEvent</seealso>
    let DepictedEvent = Prefixed_Name(ebucore, "DepictedEvent") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Disclaimer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"To provide a disclaimer of any
    ///             form."</para>
    /// labels<para>"Disclaimer"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Disclaimer">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Disclaimer</seealso>
    let Disclaimer = Prefixed_Name(ebucore, "Disclaimer") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Document</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"To describe a publication in the form of a
    ///             document e.g. a html webpage (news item) or a pdf document e.g. a script."</para>
    /// labels<para>"Document"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Document">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Document</seealso>
    let Document = Prefixed_Name(ebucore, "Document") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:DocumentFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"To provide technical information about the
    ///             format of a document such as the orientation. This is provided as free text in an
    ///             annotation label or as an identifier pointing to a term in a classification
    ///             scheme."</para>
    /// labels<para>"Document format"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#DocumentFormat">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#DocumentFormat</seealso>
    let DocumentFormat = Prefixed_Name(ebucore, "DocumentFormat") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Dopesheet</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Provides additional information about a NewsItem, e.g. date and place, subject."</para>
    /// labels<para>"Dopesheet"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Dopesheet">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Dopesheet</seealso>
    let Dopesheet = Prefixed_Name(ebucore, "Dopesheet") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:EditorialObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"In the audiovisual domain, the Class
    ///             EditorialObject transforms a commissioned concept into an editorial definition of a
    ///             MediaResource before fabrication (in the Production Domain) and Distribution (in the
    ///             Distribution Domain). An EditorialObject is a set of descriptive metadata summarising
    ///             e.g. editing decisions. An EditorialObject can also be a part of an EditorialObject,
    ///             which is defined by its start time and duration. An EditorialObject can also be a group
    ///             of EditorialObjects. For example a series composed of episodes is defined as an
    ///             EditorialObject."</para>
    /// labels<para>"Editorial Object"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#EditorialObject">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#EditorialObject</seealso>
    let EditorialObject = Prefixed_Name(ebucore, "EditorialObject") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:EncodingFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"To provide a definition of the encoding format
    ///             for audio and video. This is provided as free text in an annotation label or as an
    ///             identifier pointing to a term in a classification scheme e.g.
    ///             http://www.ebu.ch/metadata/ontologies/skos/ebu_AudioCompressionCodeCS.rdf or
    ///             http://www.ebu.ch/metadata/ontologies/skos/ebu_VideoCompressionCodeCS.rdf."</para>
    /// labels<para>"Encoding"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#EncodingFormat">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#EncodingFormat</seealso>
    let EncodingFormat = Prefixed_Name(ebucore, "EncodingFormat") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Essence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"In some audiovisual standardisation groups,
    ///             Essence is preferred to MediaResource. In also has subclasses well known as MediaObject
    ///             clustered in AudioObjects and VideoObjects."</para>
    /// labels<para>"Essence"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Essence">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Essence</seealso>
    let Essence = Prefixed_Name(ebucore, "Essence") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An event related to the media resource, e.g.
    ///             depicted in the resource (possibly fictional), etc."</para>
    ///   <para>"Additional types of event shall be defined as
    ///             new sub-classes of event."</para>
    /// labels<para>"Event"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Event">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Event</seealso>
    let Event = Prefixed_Name(ebucore, "Event") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:ExploitationIssues</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"To highlight potential exploitation
    ///             issues."</para>
    /// labels<para>"Exploitation issues"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ExploitationIssues">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ExploitationIssues</seealso>
    let ExploitationIssues =
        Prefixed_Name(ebucore, "ExploitationIssues") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:Feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Feature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Feature">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Feature</seealso>
    let Feature = Prefixed_Name(ebucore, "Feature") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:FileFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A file format for Resources other than
    ///             audiovisual resources. The format is defined as free text or pointing at a term in a
    ///             classification scheme e.g.
    ///             http://www.ebu.ch/metadata/ontologies/skos/ebu_FileFormatCS.rdf."</para>
    /// labels<para>"File format"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#FileFormat">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#FileFormat</seealso>
    let FileFormat = Prefixed_Name(ebucore, "FileFormat") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Format</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The format provides technical information on
    ///             the format of a Resource. A BusinessObject can be instantiated in a variety of Resources
    ///             each in a particular Format. Other specific data formats may be defined as subclasses of
    ///             format."</para>
    /// labels<para>"Format"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Format">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Format</seealso>
    let Format = Prefixed_Name(ebucore, "Format") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Generation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Identifies the generation of a version of a resource, i.e. master, edit master, distribution copy, etc."</para>
    /// labels<para>"Generation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Generation">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Generation</seealso>
    let Generation = Prefixed_Name(ebucore, "Generation") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Genre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"This class shall be used to provide information
    ///             on the genre of the BusinessObject or Resource. This is provided as free text in an
    ///             annotation label or as an identifier pointing to a term in a classification scheme e.g.
    ///             http://www.ebu.ch/metadata/ontologies/skos/ebu_ContentGenreCS.rdf or
    ///             http://www.ebu.ch/metadata/ontologies/skos/ebu_EditorialFormatCodeCS.rdf."</para>
    /// labels<para>"Genre"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Genre">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Genre</seealso>
    let Genre = Prefixed_Name(ebucore, "Genre") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Group</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"To define a collection / group of media
    ///             resources, for example a series made of episodes."</para>
    /// labels<para>"Group"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Group">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Group</seealso>
    let Group = Prefixed_Name(ebucore, "Group") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:IPRRestrictions</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"To provide information on intellectual
    ///             property."</para>
    /// labels<para>"IPR restrictions"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#IPRRestrictions">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#IPRRestrictions</seealso>
    let IPRRestrictions = Prefixed_Name(ebucore, "IPRRestrictions") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Image</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A still image / thumbnail / key frame / logo
    ///             related to the media resource or being the media resource itself"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Image"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Image">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Image</seealso>
    let Image = Prefixed_Name(ebucore, "Image") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:ImageFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"To provide technical information about the
    ///             format of an image such as the orientation. This is provided as free text in an
    ///             annotation label or as an identifier pointing to a term in a classification
    ///             scheme."</para>
    /// labels<para>"Image format"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ImageFormat">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ImageFormat</seealso>
    let ImageFormat = Prefixed_Name(ebucore, "ImageFormat") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Item</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An item e.g. newsItem or sportItem"</para>
    /// labels<para>"Item"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Item">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Item</seealso>
    let Item = Prefixed_Name(ebucore, "Item") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:KeyCareerEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Key career event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#KeyCareerEvent">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#KeyCareerEvent</seealso>
    let KeyCareerEvent = Prefixed_Name(ebucore, "KeyCareerEvent") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:KeyEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Key event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#KeyEvent">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#KeyEvent</seealso>
    let KeyEvent = Prefixed_Name(ebucore, "KeyEvent") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:KeyPersonalEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Key personal event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#KeyPersonalEvent">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#KeyPersonalEvent</seealso>
    let KeyPersonalEvent = Prefixed_Name(ebucore, "KeyPersonalEvent") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Keyframe</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A key frame is a frame extarcted from video,
    ///             e.g. representative of a part of a MediaResource."</para>
    /// labels<para>"key frame"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Keyframe">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Keyframe</seealso>
    let Keyframe = Prefixed_Name(ebucore, "Keyframe") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Keyword</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"To proivde keywords and define key concepts
    ///             illustrating the content of the Resource or EditorialObject. This is provided as free
    ///             text in an annotation label or as an identifier pointing to a term in a classification
    ///             scheme."</para>
    /// labels<para>"Keyword"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Keyword">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Keyword</seealso>
    let Keyword = Prefixed_Name(ebucore, "Keyword") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Language</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"To provide information on languages present in
    ///             the BusinessObject and its purpose. This is provided as free text in an annotation label
    ///             or as an identifier pointing to a term in a classification scheme.Other language
    ///             specific types may be added as subclasses of language."</para>
    /// labels<para>"Language"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Language">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Language</seealso>
    let Language = Prefixed_Name(ebucore, "Language") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A type of location is defined as a sub-class of
    ///             location."</para>
    ///   <para>"This is provided as free text in an annotation
    ///             label or as an identifier pointing to a term in a classification scheme."</para>
    ///   <para>"A location related to the media resource, e.g.
    ///             depicted in the resource (possibly fictional) or where the resource was created
    ///             (shooting location), etc."</para>
    /// labels<para>"Location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Location">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Location</seealso>
    let Location = Prefixed_Name(ebucore, "Location") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Logo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A Logo allows to visually identify an
    ///             organisation, publicationService, publicationChannel, or ratings /
    ///             parentalGuidance"</para>
    /// labels<para>"Logo"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Logo">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Logo</seealso>
    let Logo = Prefixed_Name(ebucore, "Logo") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:MediaFragment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A MediaFragment is a temporal or spatial segment of a resource identified by a MediaGragment URI (http://www.w3.org/2008/WebVideo/Fragments/WD-media-fragments-spec/)."</para>
    /// labels<para>"Media Fragment"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#MediaFragment">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#MediaFragment</seealso>
    let MediaFragment = Prefixed_Name(ebucore, "MediaFragment") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:MediaResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The use of MediaResource is reserved to
    ///             audiovisual content."</para>
    /// labels<para>"Media Resource"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#MediaResource">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#MediaResource</seealso>
    let MediaResource = Prefixed_Name(ebucore, "MediaResource") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Medium</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"To provide information on the medium formats in
    ///             which the resource is available. This is provided as free text in an annotation label or
    ///             as an identifier pointing to a term in a classification scheme."</para>
    /// labels<para>"Medium"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Medium">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Medium</seealso>
    let Medium = Prefixed_Name(ebucore, "Medium") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:MetadataTrack</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"Metadata track"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#MetadataTrack">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#MetadataTrack</seealso>
    let MetadataTrack = Prefixed_Name(ebucore, "MetadataTrack") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:MimeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The definition of the container if available as
    ///             a MIME type. This is provided as free text in an annotation label or as an identifier
    ///             pointing to a term in a classification scheme. For more information:
    ///             http://www.iana.org/assignments/media-types/index.html."</para>
    /// labels<para>"Mime type"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#MimeType">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#MimeType</seealso>
    let MimeType = Prefixed_Name(ebucore, "MimeType") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:NewsItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A NewsItem aggregates all information about a particular news event."</para>
    /// labels<para>"News Item"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#NewsItem">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#NewsItem</seealso>
    let NewsItem = Prefixed_Name(ebucore, "NewsItem") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:ObjectType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"To specify the type of BusinessObject e.g. and
    ///             EditorialObject of type "programme" or clip". This is
    ///             provided as free text in an annotation label or as an identifier pointing to a term in a
    ///             classification scheme e.g.
    ///             http://www.ebu.ch/metadata/ontologies/skos/ebu_ObjectTypeCodeCS.rdf."</para>
    /// labels<para>"Object type"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ObjectType">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ObjectType</seealso>
    let ObjectType = Prefixed_Name(ebucore, "ObjectType") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:OpenCaptions</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Open Captions are burned in the
    ///             image."</para>
    /// labels<para>"Open captions"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#OpenCaptions">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#OpenCaptions</seealso>
    let OpenCaptions = Prefixed_Name(ebucore, "OpenCaptions") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:OpenSubtitling</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Open subtitles are burned in the
    ///             image."</para>
    /// labels<para>"Open subtitling"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#OpenSubtitling">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#OpenSubtitling</seealso>
    let OpenSubtitling = Prefixed_Name(ebucore, "OpenSubtitling") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Organisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An organisation (business, corporation, federation, etc.) or moral agent (gvernment body)."</para>
    /// labels<para>"Organisation"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Organisation">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Organisation</seealso>
    let Organisation = Prefixed_Name(ebucore, "Organisation") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:OriginalLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The original language in which the
    ///             BusinessObject or Resource has been created and released. This is provided as free text
    ///             in an annotation label or as an identifier pointing to a term in a classification
    ///             scheme."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#OriginalLanguage">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#OriginalLanguage</seealso>
    let OriginalLanguage = Prefixed_Name(ebucore, "OriginalLanguage") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Part</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A Fragment is a particular section of a
    ///             MediaResource identified by a start and end time or duration. Fragment can also be
    ///             called segment or part."</para>
    ///   <para>"One of more media fragment (audio, video, data)
    ///             composing an audiovisual media resource. In other ontolgies fragment is often referred
    ///             to e.g. as a 'part' or 'segment' or
    ///             'fragment'."</para>
    /// labels<para>"Part, Fragment, Segment"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Part">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Part</seealso>
    let Part = Prefixed_Name(ebucore, "Part") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Pictogram</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A visual / graphical representation of a concept."</para>
    /// labels<para>"Pictogram"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Pictogram">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Pictogram</seealso>
    let Pictogram = Prefixed_Name(ebucore, "Pictogram") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Picture</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A photography, a logo, a pictogram, etc."</para>
    /// labels<para>"Picture"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Picture">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Picture</seealso>
    let Picture = Prefixed_Name(ebucore, "Picture") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Programme</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An EditorialObject corresponding to a
    ///             MediaResource ready for publication."</para>
    /// labels<para>"Programme"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Programme">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Programme</seealso>
    let Programme = Prefixed_Name(ebucore, "Programme") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:PublicationChannel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The name of the channel through which a
    ///             Resource has been published as a PublicationEvent. A PublicationChannel can use a
    ///             variety of medias e.g. broadcast or online."</para>
    /// labels<para>"Publication Channel"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#PublicationChannel">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#PublicationChannel</seealso>
    let PublicationChannel =
        Prefixed_Name(ebucore, "PublicationChannel") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:PublicationEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"To describe any manifestation of a media
    ///             resource on any media (live, on demand, catch-up TV, etc.) and the appropriate
    ///             PublciationChannel."</para>
    /// labels<para>"Publication Event"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#PublicationEvent">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#PublicationEvent</seealso>
    let PublicationEvent = Prefixed_Name(ebucore, "PublicationEvent") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:PublicationHistory</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A collection of PublicationEvents through which
    ///             a resource has been published."</para>
    /// labels<para>"Publication History"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#PublicationHistory">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#PublicationHistory</seealso>
    let PublicationHistory =
        Prefixed_Name(ebucore, "PublicationHistory") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:PublicationPlanning</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A collection of PublicationEvents organised as a PublicationPlanning."</para>
    /// labels<para>"Publication History"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#PublicationPlanning">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#PublicationPlanning</seealso>
    let PublicationPlanning =
        Prefixed_Name(ebucore, "PublicationPlanning") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:RadioProgramme</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A programme for distribution on radio
    ///             channels."</para>
    /// labels<para>"Radio Programme"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#RadioProgramme">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#RadioProgramme</seealso>
    let RadioProgramme = Prefixed_Name(ebucore, "RadioProgramme") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Rating</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"All the information about the rating/evaluation
    ///             given to a media resource by an Agent i.e. a person/Contact or
    ///             Organisation."</para>
    ///   <para>"This is provided as free text in an annotation
    ///             label or as an identifier pointing to a term in a classification scheme."</para>
    /// labels<para>"Rating"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Rating">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Rating</seealso>
    let Rating = Prefixed_Name(ebucore, "Rating") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Resource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A manifestation of a
    ///             BusinessObject."</para>
    /// labels<para>"Resource"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Resource">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Resource</seealso>
    let Resource = Prefixed_Name(ebucore, "Resource") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Rights</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"To provide information on the rights, including
    ///             intellectual property, related to a BusinessObject or Resource."</para>
    /// labels<para>"Rights"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Rights">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Rights</seealso>
    let Rights = Prefixed_Name(ebucore, "Rights") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:RightsClearance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"To signal that rights have been cleared (or
    ///             not)"</para>
    /// </remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#RightsClearance">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#RightsClearance</seealso>
    let RightsClearance = Prefixed_Name(ebucore, "RightsClearance") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"To define the role / action of an agent. This
    ///             is provided as free text in an annotation label or as an identifier pointing to a term
    ///             in a classification scheme."</para>
    /// labels<para>"Role"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Role">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Role</seealso>
    let Role = Prefixed_Name(ebucore, "Role") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:SDID</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Secondary data identification word for
    ///             ancillary data. Send mode identifier. An identifier which indicates the transmission
    ///             timing for closed caption data."</para>
    /// labels<para>"SDID"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#SDID">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#SDID</seealso>
    let SDID = Prefixed_Name(ebucore, "SDID") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Season</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A series can be composed of one or more seasons
    ///             clustering a certain number of episodes. Fro this reason, seasons are related to series
    ///             using the isRelatedTo property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Season"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Season">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Season</seealso>
    let Season = Prefixed_Name(ebucore, "Season") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Series</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Series is a particular type of collection. TV
    ///             or Radio Series are composed of Episodes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Series"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Series">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Series</seealso>
    let Series = Prefixed_Name(ebucore, "Series") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A service is the umbrella under which one or
    ///             more PublicationChannel is operated."</para>
    /// labels<para>"Service"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Service">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Service</seealso>
    let Service = Prefixed_Name(ebucore, "Service") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Signing</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"To signal the presence of Signing for hard of
    ///             hearing users. The type of Signing (e.g. incursted in or else) or language of Signing
    ///             can be specified using the appropriate properties."</para>
    /// labels<para>"Signing"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Signing">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Signing</seealso>
    let Signing = Prefixed_Name(ebucore, "Signing") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:SigningFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"To provide additional information on the
    ///             signing format. This is provided as free text in an annotation label or as an identifier
    ///             pointing to a term in a classification scheme."</para>
    /// labels<para>"Signing format"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#SigningFormat">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#SigningFormat</seealso>
    let SigningFormat = Prefixed_Name(ebucore, "SigningFormat") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:SportItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A SportItem aggregates all information about a sport event."</para>
    /// labels<para>"Sport item"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#SportItem">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#SportItem</seealso>
    let SportItem = Prefixed_Name(ebucore, "SportItem") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Staff</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Staff member."</para>
    /// labels<para>"Staff member."</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Staff">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Staff</seealso>
    let Staff = Prefixed_Name(ebucore, "Staff") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Standard</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"identifies the technical video standard of a resource, i.e. NTSC or PAL."</para>
    /// labels<para>"Standard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Standard">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Standard</seealso>
    let Standard = Prefixed_Name(ebucore, "Standard") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:StorageType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The type of storage used for the repository.
    ///             This is provided as free text in an annotation label or as an identifier pointing to a
    ///             term in a classification scheme."</para>
    /// labels<para>"Storage type"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#StorageType">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#StorageType</seealso>
    let StorageType = Prefixed_Name(ebucore, "StorageType") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Stream</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A continuous stream of bits."</para>
    /// labels<para>"Stream"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Stream">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Stream</seealso>
    let Stream = Prefixed_Name(ebucore, "Stream") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A term describing the topic covered by the
    ///             BusinessObject or resource. This is provided as free text in an annotation label or as
    ///             an identifier pointing to a term in a classification scheme."</para>
    /// labels<para>"Subject"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Subject">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Subject</seealso>
    let Subject = Prefixed_Name(ebucore, "Subject") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Subtitling</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"To signal the presence of subtitles for
    ///             translation in alternative languages."</para>
    /// labels<para>"Subtitling"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Subtitling">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Subtitling</seealso>
    let Subtitling = Prefixed_Name(ebucore, "Subtitling") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:SubtitlingFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"To define the format of subtitling.
    ///             subtitling's main use isfor translation. This is provided as free text in an
    ///             annotation label  or as an identifier pointing to a term in a classification
    ///             scheme."</para>
    /// labels<para>"Subtitling format"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#SubtitlingFormat">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#SubtitlingFormat</seealso>
    let SubtitlingFormat = Prefixed_Name(ebucore, "SubtitlingFormat") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:TVProgramme</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A programme for distribution on television
    ///             channels."</para>
    /// labels<para>"TV Programme"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#TVProgramme">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#TVProgramme</seealso>
    let TVProgramme = Prefixed_Name(ebucore, "TVProgramme") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Tag</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An annotation specific to a particular
    ///             timestamp in audiovisual MediaResources."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Tag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Tag">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Tag</seealso>
    let Tag = Prefixed_Name(ebucore, "Tag") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Thumbnail</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A thumbnail is a low resolution picture that
    ///             can be associated with EditorialObjects or e.g. MediaResources or
    ///             Contacts."</para>
    /// labels<para>"Thumbnail"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Thumbnail">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Thumbnail</seealso>
    let Thumbnail = Prefixed_Name(ebucore, "Thumbnail") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:TimecodeTrack</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A track with timecode information."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Timecode track"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#TimecodeTrack">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#TimecodeTrack</seealso>
    let TimecodeTrack = Prefixed_Name(ebucore, "TimecodeTrack") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Topic</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A type subject for use in some contexts. This
    ///             is provided as free text in an annotation label or as an identifier pointing to a term
    ///             in a classification scheme."</para>
    /// labels<para>"Topic"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Topic">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Topic</seealso>
    let Topic = Prefixed_Name(ebucore, "Topic") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Track</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Audiovisual content can be composed of audio,
    ///             video and data Tracks (including captioning and subtitling)."</para>
    /// labels<para>"Track"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Track">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Track</seealso>
    let Track = Prefixed_Name(ebucore, "Track") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:Type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"An expression of type in textual form or as a term from a classification scheme."</para>
    /// labels<para>"Type"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Type">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#Type</seealso>
    let Type = Prefixed_Name(ebucore, "Type") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:UsageRights</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Usage rights associated with content."</para>
    /// labels<para>"Usage rights"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#UsageRights">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#UsageRights</seealso>
    let UsageRights = Prefixed_Name(ebucore, "UsageRights") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:VideoEncodingFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The encoding format of the video."</para>
    /// labels<para>"Video encoding format"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#VideoEncodingFormat">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#VideoEncodingFormat</seealso>
    let VideoEncodingFormat =
        Prefixed_Name(ebucore, "VideoEncodingFormat") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:VideoFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"To provide additional technical information
    ///             about a video resource such as the frame rate. This is provided as free text in an
    ///             annotation label or as an identifier pointing to a term in a classification
    ///             scheme."</para>
    /// labels<para>"Video format"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#VideoFormat">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#VideoFormat</seealso>
    let VideoFormat = Prefixed_Name(ebucore, "VideoFormat") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:VideoStream</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A decodable video stream of bits."</para>
    /// labels<para>"Video stream"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#VideoStream">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#VideoStream</seealso>
    let VideoStream = Prefixed_Name(ebucore, "VideoStream") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:VideoTrack</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"A specialisation of Track for Video to provide
    ///             a link to specific data properties such as frameRate, etc. Signing is another possible
    ///             example of video track. Specific VideoTracks such as Signing can be defined as sub
    ///             VideoTracks.. In advanced systems, different VideoTracks can be used to provide e.g.
    ///             different viewing angles."</para>
    /// labels<para>"Video track"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#VideoTrack">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#VideoTrack</seealso>
    let VideoTrack = Prefixed_Name(ebucore, "VideoTrack") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:YouTubeVideo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"You tube video"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#YouTubeVideo">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#YouTubeVideo</seealso>
    let YouTubeVideo = Prefixed_Name(ebucore, "YouTubeVideo") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:abridgedTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A shorter version of the title."</para>
    /// labels<para>"Abridged title"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#abridgedTitle">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#abridgedTitle</seealso>
    let abridgedTitle = Prefixed_Name(ebucore, "abridgedTitle") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:abstract</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide a brief summary."</para>
    /// labels<para>"Abstract"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#abstract">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#abstract</seealso>
    let abstract_ = Prefixed_Name(ebucore, "abstract") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:adultContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"adult content"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#adultContent">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#adultContent</seealso>
    let adultContent = Prefixed_Name(ebucore, "adultContent") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:affiliationEndDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The date when a Contact left an Organisation"</para>
    /// labels<para>"Affiliation start date"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#affiliationEndDate">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#affiliationEndDate</seealso>
    let affiliationEndDate =
        Prefixed_Name(ebucore, "affiliationEndDate") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:affiliationStartDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Affiliation start date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#affiliationStartDate">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#affiliationStartDate</seealso>
    let affiliationStartDate =
        Prefixed_Name(ebucore, "affiliationStartDate") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:agentAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide the address of an Agent
    ///             (Contact/person or organisation)."</para>
    /// labels<para>"Address"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentAddress">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentAddress</seealso>
    let agentAddress = Prefixed_Name(ebucore, "agentAddress") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:agentAge</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The age of a Contact/Person"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Age"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentAge">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentAge</seealso>
    let agentAge = Prefixed_Name(ebucore, "agentAge") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:agentCountryOfResidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"agent country of residence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentCountryOfResidence">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentCountryOfResidence</seealso>
    let agentCountryOfResidence =
        Prefixed_Name(ebucore, "agentCountryOfResidence") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:agentEmailAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide the email address of an agent
    ///             (Contact/person or organisation)."</para>
    /// labels<para>"Email"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentEmailAddress">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentEmailAddress</seealso>
    let agentEmailAddress = Prefixed_Name(ebucore, "agentEmailAddress") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:agentMobileTelephoneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide the mobile telephone number of an
    ///             Agent (Contact/person or organisation)"</para>
    /// labels<para>"Mobile"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentMobileTelephoneNumber">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentMobileTelephoneNumber</seealso>
    let agentMobileTelephoneNumber =
        Prefixed_Name(ebucore, "agentMobileTelephoneNumber") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:agentName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide the full name of Contact/person - family and given name."</para>
    /// labels<para>"Name"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentName">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentName</seealso>
    let agentName = Prefixed_Name(ebucore, "agentName") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:agentNationality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"agent nationality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentNationality">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentNationality</seealso>
    let agentNationality = Prefixed_Name(ebucore, "agentNationality") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:agentNickname</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide a nickname of a Contact/person."</para>
    /// labels<para>"Nickname"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentNickname">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentNickname</seealso>
    let agentNickname = Prefixed_Name(ebucore, "agentNickname") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:agentPictureIdLocator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"agent picture id locator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentPictureIdLocator">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentPictureIdLocator</seealso>
    let agentPictureIdLocator =
        Prefixed_Name(ebucore, "agentPictureIdLocator") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:agentTelephoneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide the telephone number of an Agent
    ///             (Contact/person or Organisation)."</para>
    /// labels<para>"Telephone"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentTelephoneNumber">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentTelephoneNumber</seealso>
    let agentTelephoneNumber =
        Prefixed_Name(ebucore, "agentTelephoneNumber") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:agentWebHomepage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide the address of the webpage of an
    ///             Agent (Contact/person or Organisation)."</para>
    /// labels<para>"Homepage"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentWebHomepage">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#agentWebHomepage</seealso>
    let agentWebHomepage = Prefixed_Name(ebucore, "agentWebHomepage") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:alternativeTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide an alternative title."</para>
    /// labels<para>"Alternative title"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#alternativeTitle">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#alternativeTitle</seealso>
    let alternativeTitle = Prefixed_Name(ebucore, "alternativeTitle") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:appliesOutOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"To define the Location (e.g. country, region) to which Rating and TargetAudience do NOT apply."</para>
    /// labels<para>"Exclusion area"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#appliesOutOf">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#appliesOutOf</seealso>
    let appliesOutOf = Prefixed_Name(ebucore, "appliesOutOf") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:appliesTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"To define the location/region to which Rating and TargetAudience apply."</para>
    /// labels<para>"Coverage"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#appliesTo">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#appliesTo</seealso>
    let appliesTo = Prefixed_Name(ebucore, "appliesTo") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:aspectRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide the aspect ratio of a video frame or
    ///             image. Several types of different aspect ration can apply to the same video image. If
    ///             necessary, specialised aspect ratios can be defined as subproperties."</para>
    /// labels<para>"Aspect ratio"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#aspectRatio">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#aspectRatio</seealso>
    let aspectRatio = Prefixed_Name(ebucore, "aspectRatio") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:audienceLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The target audience (target region, target
    ///             audience category but also parental guidance recommendation) for which the media
    ///             resource is intended."</para>
    ///   <para>"This is provided as free text in an annotation
    ///             label or as an identifier pointing to a term in a classification scheme."</para>
    /// labels<para>"Target audience"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#audienceLevel">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#audienceLevel</seealso>
    let audienceLevel = Prefixed_Name(ebucore, "audienceLevel") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:audioChannelNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The total number of audio channels contained in
    ///             the MediaResource."</para>
    /// labels<para>"Audio channel number"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#audioChannelNumber">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#audioChannelNumber</seealso>
    let audioChannelNumber =
        Prefixed_Name(ebucore, "audioChannelNumber") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:audioTrackConfiguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide the configuration of an audio track
    ///             (e.g. stereo pair) in a MediaResource."</para>
    /// labels<para>"Audio track configuration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#audioTrackConfiguration">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#audioTrackConfiguration</seealso>
    let audioTrackConfiguration =
        Prefixed_Name(ebucore, "audioTrackConfiguration") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:bitDepth</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide the audio encoding bit depth. Also called sample size."</para>
    /// labels<para>"Bit depth"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#bitDepth">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#bitDepth</seealso>
    let bitDepth = Prefixed_Name(ebucore, "bitDepth") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:bitRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide the bitrate at which the
    ///             MediaResource can be played in bits/second. Current bitrate if constant, and average bitrate if variable."</para>
    /// labels<para>"Bitrate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#bitRate">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#bitRate</seealso>
    let bitRate = Prefixed_Name(ebucore, "bitRate") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:bitRateMax</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The maximum bitrate when variable, in bits per second."</para>
    /// labels<para>"Maximum bitrate"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#bitRateMax">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#bitRateMax</seealso>
    let bitRateMax = Prefixed_Name(ebucore, "bitRateMax") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:bitRateMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A flag to indicate if the bit rate is fixed or
    ///             variable."</para>
    /// labels<para>"Bitrate mode"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#bitRateMode">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#bitRateMode</seealso>
    let bitRateMode = Prefixed_Name(ebucore, "bitRateMode") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:bookmark</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide a bookmark."</para>
    /// labels<para>"Bookmark"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#bookmark">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#bookmark</seealso>
    let bookmark = Prefixed_Name(ebucore, "bookmark") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:businessObjectName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A name attributed to a
    ///             BusinessObject."</para>
    /// labels<para>"Name"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#businessObjectName">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#businessObjectName</seealso>
    let businessObjectName =
        Prefixed_Name(ebucore, "businessObjectName") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:captioningSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide information on the source of a
    ///             captioning file."</para>
    /// labels<para>"Captioning source"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#captioningSource">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#captioningSource</seealso>
    let captioningSource = Prefixed_Name(ebucore, "captioningSource") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:clonedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Identifies relationship between a digital instantiation of a resource and its direct copy, with no generational loss."</para>
    /// labels<para>"Cloned to"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#clonedTo">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#clonedTo</seealso>
    let clonedTo = Prefixed_Name(ebucore, "clonedTo") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:codecFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide information on the product family of the Codec."</para>
    /// labels<para>"Codec family"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#codecFamily">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#codecFamily</seealso>
    let codecFamily = Prefixed_Name(ebucore, "codecFamily") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:codecName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide a name for the Codec, e.g. a product name."</para>
    /// labels<para>"Codec name"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#codecName">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#codecName</seealso>
    let codecName = Prefixed_Name(ebucore, "codecName") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:codecVendor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide a name for the vendor of the Codec."</para>
    /// labels<para>"Codec vendor"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#codecVendor">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#codecVendor</seealso>
    let codecVendor = Prefixed_Name(ebucore, "codecVendor") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:codecVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide information on the version of the Codec."</para>
    /// labels<para>"Codec version"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#codecVersion">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#codecVersion</seealso>
    let codecVersion = Prefixed_Name(ebucore, "codecVersion") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:comments</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide a comment."</para>
    /// labels<para>"Comments"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#comments">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#comments</seealso>
    let comments = Prefixed_Name(ebucore, "comments") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:contactEducation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The education details of a Contact /
    ///             person."</para>
    /// labels<para>"Education"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#contactEducation">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#contactEducation</seealso>
    let contactEducation = Prefixed_Name(ebucore, "contactEducation") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:contactFamilyInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Information on the family of a Contact /
    ///             person."</para>
    /// labels<para>"Family information"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#contactFamilyInformation">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#contactFamilyInformation</seealso>
    let contactFamilyInformation =
        Prefixed_Name(ebucore, "contactFamilyInformation") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:contactHobbies</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The hobbies of a Contact /
    ///             person."</para>
    /// labels<para>"Hobbies"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#contactHobbies">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#contactHobbies</seealso>
    let contactHobbies = Prefixed_Name(ebucore, "contactHobbies") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:contactMaritalStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The marital status of a Contact /
    ///             person."</para>
    /// labels<para>"Marital status"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#contactMaritalStatus">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#contactMaritalStatus</seealso>
    let contactMaritalStatus =
        Prefixed_Name(ebucore, "contactMaritalStatus") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:contactOccupation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The job / occupation name of a Contact /
    ///             person."</para>
    /// labels<para>"Occupation"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#contactOccupation">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#contactOccupation</seealso>
    let contactOccupation = Prefixed_Name(ebucore, "contactOccupation") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:contactUsername</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The username by which a Contact / person is
    ///             known e.g. when attributing a rating value."</para>
    /// labels<para>"Username"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#contactUsername">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#contactUsername</seealso>
    let contactUsername = Prefixed_Name(ebucore, "contactUsername") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:dateBroadcast</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:Class</para>
    ///   <para>"The date when the resource was first broadcast publicly on television or radio."</para>
    /// labels<para>"Broadcast date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateBroadcast">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateBroadcast</seealso>
    let dateBroadcast = Prefixed_Name(ebucore, "dateBroadcast") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:dateCreated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The date of creation of the Resource."</para>
    /// labels<para>"Creation date/time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateCreated">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateCreated</seealso>
    let dateCreated = Prefixed_Name(ebucore, "dateCreated") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:dateDeleted</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:Class</para>
    ///   <para>"The date when the resource was removed from institutional holdings."</para>
    /// labels<para>"Deletion date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateDeleted">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateDeleted</seealso>
    let dateDeleted = Prefixed_Name(ebucore, "dateDeleted") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:dateDigitised</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:Class</para>
    ///   <para>"To provide the date of digitisation of the Resource."</para>
    /// labels<para>"Digitisation date/time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateDigitised">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateDigitised</seealso>
    let dateDigitised = Prefixed_Name(ebucore, "dateDigitised") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:dateDistributed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:Class</para>
    ///   <para>"The date when the resource was first made available to the public for purchase, download, or online access."</para>
    /// labels<para>"Distribution date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateDistributed">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateDistributed</seealso>
    let dateDistributed = Prefixed_Name(ebucore, "dateDistributed") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:dateIngested</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The date when the resource was removed from institutional holdings."</para>
    /// labels<para>"Ingest date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateIngested">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateIngested</seealso>
    let dateIngested = Prefixed_Name(ebucore, "dateIngested") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:dateIssued</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide the date of release of the Resource."</para>
    /// labels<para>"Publication date/time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateIssued">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateIssued</seealso>
    let dateIssued = Prefixed_Name(ebucore, "dateIssued") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:dateLicenced</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The date when the license for the resource begins."</para>
    /// labels<para>"License start date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateLicenced">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateLicenced</seealso>
    let dateLicenced = Prefixed_Name(ebucore, "dateLicenced") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:dateMigrated</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:Class</para>
    ///   <para>"The date when the resource was copied or converted from an obsolete or endangered original format to a more updated format for preservation."</para>
    /// labels<para>"Migration date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateMigrated">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateMigrated</seealso>
    let dateMigrated = Prefixed_Name(ebucore, "dateMigrated") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:dateModified</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:Class</para>
    ///   <para>"To indicate the date at which the Resource has been modified."</para>
    /// labels<para>"Modification date/time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateModified">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateModified</seealso>
    let dateModified = Prefixed_Name(ebucore, "dateModified") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:dateNormalized</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The date when the resource was converted from its original format into a format pre-selected by the institution for preservation."</para>
    /// labels<para>"Normalization date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateNormalized">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateNormalized</seealso>
    let dateNormalized = Prefixed_Name(ebucore, "dateNormalized") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:dateTransferred</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The date when the resource was moved from one digital or physical location to another."</para>
    /// labels<para>"Transfer date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateTransferred">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateTransferred</seealso>
    let dateTransferred = Prefixed_Name(ebucore, "dateTransferred") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:dateValidated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The most recent date when the resource was confirmed to be valid through manual or digital QC."</para>
    /// labels<para>"Validation date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateValidated">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dateValidated</seealso>
    let dateValidated = Prefixed_Name(ebucore, "dateValidated") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:derivedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Identifies a content-based relationship between two resources."</para>
    /// labels<para>"Derived to"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#derivedTo">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#derivedTo</seealso>
    let derivedTo = Prefixed_Name(ebucore, "derivedTo") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This can be specialised by using sub-properties
    ///             like defined in http://www.ebu.ch/metadata/cs/web/ebu_DescriptionTypeCodeCS_p.xml.htm
    ///             implemented as examples as e.g. 'summary' or
    ///             'script'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#description">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#description</seealso>
    let description = Prefixed_Name(ebucore, "description") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:dimensions</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Describes the physical dimensions of a media resource, with units of measure concatenated to become part of the value."</para>
    /// labels<para>"Dimensions"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dimensions">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dimensions</seealso>
    let dimensions = Prefixed_Name(ebucore, "dimensions") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:dopesheet</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide a dopesheet with a title and brief description for news."</para>
    /// labels<para>"Dopesheet"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dopesheet">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dopesheet</seealso>
    let dopesheet = Prefixed_Name(ebucore, "dopesheet") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:dubbedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Identifies relationship between a physical instantiation of a resource and a duplicate physical copy that may involve generational loss."</para>
    /// labels<para>"Dubbed to"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dubbedTo">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#dubbedTo</seealso>
    let dubbedTo = Prefixed_Name(ebucore, "dubbedTo") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide information on the duration of a MediaResource. It corresponds to 'duration' in the
    ///             Ontology for Media Resources."</para>
    /// labels<para>"Duration"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#duration">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#duration</seealso>
    let duration = Prefixed_Name(ebucore, "duration") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:durationNormalPlayTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide a duration as normal
    ///             time."</para>
    /// labels<para>"Duration (time)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#durationNormalPlayTime">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#durationNormalPlayTime</seealso>
    let durationNormalPlayTime =
        Prefixed_Name(ebucore, "durationNormalPlayTime") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:durationNumberEditUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide a duration as a number of EditUnits
    ///             which value is for instance the inverse of the audio sample rate or video frame
    ///             rate."</para>
    /// labels<para>"Duration (edit units)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#durationNumberEditUnit">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#durationNumberEditUnit</seealso>
    let durationNumberEditUnit =
        Prefixed_Name(ebucore, "durationNumberEditUnit") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:durationPublished</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide information on the published / announced duration of an EditorialObject."</para>
    /// labels<para>"Published Duration"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#durationPublished">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#durationPublished</seealso>
    let durationPublished = Prefixed_Name(ebucore, "durationPublished") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:durationPublishedNormalPlayTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide a published duration as normal
    ///             time."</para>
    /// labels<para>"Published duration (time)"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#durationPublishedNormalPlayTime">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#durationPublishedNormalPlayTime</seealso>
    let durationPublishedNormalPlayTime =
        Prefixed_Name(ebucore, "durationPublishedNormalPlayTime") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:durationPublishedNumberEditUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide a published duration as a number of EditUnits
    ///             which value is for instance the inverse of the audio sample rate or video frame
    ///             rate."</para>
    /// labels<para>"Published duration (edit units)"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#durationPublishedNumberEditUnit">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#durationPublishedNumberEditUnit</seealso>
    let durationPublishedNumberEditUnit =
        Prefixed_Name(ebucore, "durationPublishedNumberEditUnit") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:durationPublishedTimecode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The published duration expressed as a
    ///             timecode."</para>
    /// labels<para>"Published duration (timecode)"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#durationPublishedTimecode">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#durationPublishedTimecode</seealso>
    let durationPublishedTimecode =
        Prefixed_Name(ebucore, "durationPublishedTimecode") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:durationTimecode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The duration expressed as a
    ///             timecode."</para>
    /// labels<para>"Duration (timecode)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#durationTimecode">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#durationTimecode</seealso>
    let durationTimecode = Prefixed_Name(ebucore, "durationTimecode") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:editUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The edit unit is e.g. the inverse of the audio
    ///             sample rate or video frame rate."</para>
    /// labels<para>"Edit unit"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#editUnit">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#editUnit</seealso>
    let editUnit = Prefixed_Name(ebucore, "editUnit") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:encodingLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The encoding level."</para>
    /// labels<para>"Encoding level"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#encodingLevel">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#encodingLevel</seealso>
    let encodingLevel = Prefixed_Name(ebucore, "encodingLevel") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:encodingProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The encoding profile"</para>
    /// labels<para>"Encoding profile"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#encodingProfile">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#encodingProfile</seealso>
    let encodingProfile = Prefixed_Name(ebucore, "encodingProfile") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:end</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The start point of the media
    ///             resource."</para>
    /// labels<para>"End time"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#end">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#end</seealso>
    let end_ = Prefixed_Name(ebucore, "end") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:endLicenceDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The date on which the license for the resource expires."</para>
    /// labels<para>"License expiration date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#endLicenceDate">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#endLicenceDate</seealso>
    let endLicenceDate = Prefixed_Name(ebucore, "endLicenceDate") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:endNormalPlayTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The start time expressed using a time
    ///             expression."</para>
    /// labels<para>"End time (time)"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#endNormalPlayTime">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#endNormalPlayTime</seealso>
    let endNormalPlayTime = Prefixed_Name(ebucore, "endNormalPlayTime") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:endNumberEditUnits</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A start time expressed as a number of edit
    ///             units."</para>
    /// labels<para>"End time (edit units)"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#endNumberEditUnits">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#endNumberEditUnits</seealso>
    let endNumberEditUnits =
        Prefixed_Name(ebucore, "endNumberEditUnits") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:endTimecode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A start time expressed as
    ///             timecode."</para>
    /// labels<para>"End time (timecode)"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#endTimecode">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#endTimecode</seealso>
    let endTimecode = Prefixed_Name(ebucore, "endTimecode") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:eventDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide a deescription for an
    ///             Event."</para>
    /// labels<para>"Description"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#eventDescription">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#eventDescription</seealso>
    let eventDescription = Prefixed_Name(ebucore, "eventDescription") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:eventDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The duration of an event."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Duration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#eventDuration">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#eventDuration</seealso>
    let eventDuration = Prefixed_Name(ebucore, "eventDuration") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:eventEndDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The end date of an Event."</para>
    /// labels<para>"Event end date"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#eventEndDate">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#eventEndDate</seealso>
    let eventEndDate = Prefixed_Name(ebucore, "eventEndDate") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:eventName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide a name for an Event."</para>
    /// labels<para>"Event name"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#eventName">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#eventName</seealso>
    let eventName = Prefixed_Name(ebucore, "eventName") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:eventPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The period of time during which an Event has occured."</para>
    /// labels<para>"Event period"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#eventPeriod">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#eventPeriod</seealso>
    let eventPeriod = Prefixed_Name(ebucore, "eventPeriod") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:eventStartDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The start date of an Event."</para>
    /// labels<para>"Event start date"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#eventStartDate">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#eventStartDate</seealso>
    let eventStartDate = Prefixed_Name(ebucore, "eventStartDate") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:familyName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide a family name / last name."</para>
    /// labels<para>"Family name"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#familyName">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#familyName</seealso>
    let familyName = Prefixed_Name(ebucore, "familyName") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:fictitious</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A flag to indicate if an agent of fictitious
    ///             (set to true)."</para>
    /// labels<para>"Fictitious agent indicator"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#fictitious">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#fictitious</seealso>
    let fictitious = Prefixed_Name(ebucore, "fictitious") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:fileSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Provides the size of a MediaResource in bytes."</para>
    /// labels<para>"File size"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#fileSize">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#fileSize</seealso>
    let fileSize = Prefixed_Name(ebucore, "fileSize") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:filename</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The name of the file containing the
    ///             Resource."</para>
    /// labels<para>"File name"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#filename">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#filename</seealso>
    let filename = Prefixed_Name(ebucore, "filename") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:folksonomy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Provides a user/audience-generated description, tag, or label for resource content."</para>
    /// labels<para>"Folksonomy"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#folksonomy">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#folksonomy</seealso>
    let folksonomy = Prefixed_Name(ebucore, "folksonomy") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:followsInSequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:Class</para>
    ///   <para>"A link to a an BusinessObject or a Resource preceding the current BusinessObject or Resource in an ordered sequence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Previous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#followsInSequence">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#followsInSequence</seealso>
    let followsInSequence = Prefixed_Name(ebucore, "followsInSequence") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:frameRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The frame rate of the video signal in frame per second."</para>
    /// labels<para>"Frame rate"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#frameRate">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#frameRate</seealso>
    let frameRate = Prefixed_Name(ebucore, "frameRate") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:frameSizeUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The unit used to express the frame width or
    ///             height. The unit by default is 'pixel'."</para>
    /// labels<para>"Frame size unit"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#frameSizeUnit">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#frameSizeUnit</seealso>
    let frameSizeUnit = Prefixed_Name(ebucore, "frameSizeUnit") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:framesPerSecond</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Identifies the frames per second at which a visual resource should be played back for human consumption."</para>
    /// labels<para>"Frames per second"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#framesPerSecond">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#framesPerSecond</seealso>
    let framesPerSecond = Prefixed_Name(ebucore, "framesPerSecond") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:frequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide the frequency of an AudioChannel filter"</para>
    /// labels<para>"Frequency"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#frequency">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#frequency</seealso>
    let frequency = Prefixed_Name(ebucore, "frequency") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:givenName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide one or more given names."</para>
    /// labels<para>"Given name"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#givenName">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#givenName</seealso>
    let givenName = Prefixed_Name(ebucore, "givenName") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:groupDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A textual description of a
    ///             Group."</para>
    /// labels<para>"Group description"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#groupDescription">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#groupDescription</seealso>
    let groupDescription = Prefixed_Name(ebucore, "groupDescription") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:groupName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The name attributed to a Group."</para>
    /// labels<para>"Group name"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#groupName">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#groupName</seealso>
    let groupName = Prefixed_Name(ebucore, "groupName") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasAffiliation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A property to establish the relation between a
    ///             Contact/person and an Organisation."</para>
    /// labels<para>"Affiliation"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAffiliation">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAffiliation</seealso>
    let hasAffiliation = Prefixed_Name(ebucore, "hasAffiliation") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasAncillaryData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A property to signal the presence of
    ///             AncillaryData associated with the EditorialObject and / or MediaResource."</para>
    /// labels<para>"Ancillary data"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAncillaryData">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAncillaryData</seealso>
    let hasAncillaryData = Prefixed_Name(ebucore, "hasAncillaryData") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasAncillaryDataFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Ancillary data format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAncillaryDataFormat">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAncillaryDataFormat</seealso>
    let hasAncillaryDataFormat =
        Prefixed_Name(ebucore, "hasAncillaryDataFormat") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasAnnotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A property to signal the presence of Annotation
    ///             information associated with an EditorialObject and / or a MediaResource."</para>
    /// labels<para>"Annotation"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAnnotation">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAnnotation</seealso>
    let hasAnnotation = Prefixed_Name(ebucore, "hasAnnotation") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasAnnotationSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To identify the Agent, Contact/person or
    ///             Organisation who has provided the Annotation."</para>
    /// labels<para>"Annotation Source"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAnnotationSource">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAnnotationSource</seealso>
    let hasAnnotationSource =
        Prefixed_Name(ebucore, "hasAnnotationSource") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasAudioDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:Class</para>
    ///   <para>"To signal the presence of
    ///             AudioDescription."</para>
    /// labels<para>"Audio description"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAudioDescription">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAudioDescription</seealso>
    let hasAudioDescription =
        Prefixed_Name(ebucore, "hasAudioDescription") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasAudioEncodingFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Audio encoding format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAudioEncodingFormat">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAudioEncodingFormat</seealso>
    let hasAudioEncodingFormat =
        Prefixed_Name(ebucore, "hasAudioEncodingFormat") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasAudioFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Audio format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAudioFormat">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasAudioFormat</seealso>
    let hasAudioFormat = Prefixed_Name(ebucore, "hasAudioFormat") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasCaptioning</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:Class</para>
    ///   <para>"To signal the presence of
    ///             Captioning."</para>
    /// labels<para>"Captioning"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCaptioning">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCaptioning</seealso>
    let hasCaptioning = Prefixed_Name(ebucore, "hasCaptioning") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasCaptioningFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Captioning format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCaptioningFormat">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCaptioningFormat</seealso>
    let hasCaptioningFormat =
        Prefixed_Name(ebucore, "hasCaptioningFormat") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasCastMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Cast member"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCastMember">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCastMember</seealso>
    let hasCastMember = Prefixed_Name(ebucore, "hasCastMember") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasCharacter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Character"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCharacter">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCharacter</seealso>
    let hasCharacter = Prefixed_Name(ebucore, "hasCharacter") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasCodec</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To identify the Codec with which the Resource has been encoded."</para>
    /// labels<para>"Encoder"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCodec">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCodec</seealso>
    let hasCodec = Prefixed_Name(ebucore, "hasCodec") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasColourSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Colour space"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasColourSpace">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasColourSpace</seealso>
    let hasColourSpace = Prefixed_Name(ebucore, "hasColourSpace") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasContact</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide information on a Contact for an
    ///             Organisation or a physical person (e.g. the agent of an actor)."</para>
    /// labels<para>"Contact"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasContact">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasContact</seealso>
    let hasContact = Prefixed_Name(ebucore, "hasContact") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasContainerFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Container format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasContainerFormat">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasContainerFormat</seealso>
    let hasContainerFormat =
        Prefixed_Name(ebucore, "hasContainerFormat") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasContainerMimeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Mime type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasContainerMimeType">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasContainerMimeType</seealso>
    let hasContainerMimeType =
        Prefixed_Name(ebucore, "hasContainerMimeType") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasContributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide information on Contacts/persons or
    ///             Organisations who have contributed to the BusinessObject or Resource."</para>
    /// labels<para>"Contributor"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasContributor">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasContributor</seealso>
    let hasContributor = Prefixed_Name(ebucore, "hasContributor") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasCoverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A property to identify the Events and or
    ///             Locations, all real or fictional, covered by the
    ///             BusinessObject."</para>
    /// labels<para>"Coverage"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCoverage">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCoverage</seealso>
    let hasCoverage = Prefixed_Name(ebucore, "hasCoverage") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasCreationLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The Location where content has been created."</para>
    /// labels<para>"Creation location"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCreationLocation">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCreationLocation</seealso>
    let hasCreationLocation =
        Prefixed_Name(ebucore, "hasCreationLocation") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasCreator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To identify an Agent involved in the creation of the Resource or BusinessObject."</para>
    /// labels<para>"Creator"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCreator">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCreator</seealso>
    let hasCreator = Prefixed_Name(ebucore, "hasCreator") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasCrewMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Crew member"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCrewMember">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasCrewMember</seealso>
    let hasCrewMember = Prefixed_Name(ebucore, "hasCrewMember") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasDataFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Data format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasDataFormat">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasDataFormat</seealso>
    let hasDataFormat = Prefixed_Name(ebucore, "hasDataFormat") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasDepartment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To identify Departments within an
    ///             Organisation."</para>
    /// labels<para>"Department"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasDepartment">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasDepartment</seealso>
    let hasDepartment = Prefixed_Name(ebucore, "hasDepartment") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasDocumentFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has document format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasDocumentFormat">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasDocumentFormat</seealso>
    let hasDocumentFormat = Prefixed_Name(ebucore, "hasDocumentFormat") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasDopesheet</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To associate a Dopesheet with a NewsItem."</para>
    /// labels<para>"Dopesheet"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasDopesheet">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasDopesheet</seealso>
    let hasDopesheet = Prefixed_Name(ebucore, "hasDopesheet") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasEncodingFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Encoding format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasEncodingFormat">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasEncodingFormat</seealso>
    let hasEncodingFormat = Prefixed_Name(ebucore, "hasEncodingFormat") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasEpisode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"To identify an episode of a
    ///             Series or a Season."</para>
    /// labels<para>"Episode"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasEpisode">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasEpisode</seealso>
    let hasEpisode = Prefixed_Name(ebucore, "hasEpisode") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To associate an Event with a
    ///             Location."</para>
    /// labels<para>"Event"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasEvent">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasEvent</seealso>
    let hasEvent = Prefixed_Name(ebucore, "hasEvent") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasFileFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"File format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasFileFormat">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasFileFormat</seealso>
    let hasFileFormat = Prefixed_Name(ebucore, "hasFileFormat") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A property to define the Format of a Resource."</para>
    /// labels<para>"Format"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasFormat">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasFormat</seealso>
    let hasFormat = Prefixed_Name(ebucore, "hasFormat") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasGeneration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Identifies the generation of a version of a resource, i.e. master, edit master, distribution copy, etc."</para>
    /// labels<para>"Generation"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasGeneration">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasGeneration</seealso>
    let hasGeneration = Prefixed_Name(ebucore, "hasGeneration") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasGenre</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To define a Genre/category associated to the
    ///             BusinesssObject."</para>
    /// labels<para>"Genre"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasGenre">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasGenre</seealso>
    let hasGenre = Prefixed_Name(ebucore, "hasGenre") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasHomepage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Homepage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasHomepage">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasHomepage</seealso>
    let hasHomepage = Prefixed_Name(ebucore, "hasHomepage") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasIdPicture</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Id picture"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasIdPicture">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasIdPicture</seealso>
    let hasIdPicture = Prefixed_Name(ebucore, "hasIdPicture") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasImageFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Image format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasImageFormat">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasImageFormat</seealso>
    let hasImageFormat = Prefixed_Name(ebucore, "hasImageFormat") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasKeyCareerEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Career event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasKeyCareerEvent">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasKeyCareerEvent</seealso>
    let hasKeyCareerEvent = Prefixed_Name(ebucore, "hasKeyCareerEvent") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasKeyPersonalEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Personal event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasKeyPersonalEvent">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasKeyPersonalEvent</seealso>
    let hasKeyPersonalEvent =
        Prefixed_Name(ebucore, "hasKeyPersonalEvent") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasKeyword</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:Class</para>
    ///   <para>"To associate a concept, descriptive phrase or
    ///             Keyword that specifies the topic of the BusinessObject or Annotation."</para>
    /// labels<para>"Keyword"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasKeyword">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasKeyword</seealso>
    let hasKeyword = Prefixed_Name(ebucore, "hasKeyword") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To associate a Language to a Resource or
    ///             BusinessObject. A controlled vocabulary based on BCP 47 is recommended. This
    ///             property can also be used to identify the presence of sign language (RFC 5646). By
    ///             inheritance, the hasLanguage property applies indifferently at the MediaResource /
    ///             Fragment / Track levels at which the usage is being defined. Best practice recommends to
    ///             use to best possible level of granularity fo describe the usage of language within a
    ///             MediaResource including at Fragment and Track levels."</para>
    /// labels<para>"Language"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasLanguage">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasLanguage</seealso>
    let hasLanguage = Prefixed_Name(ebucore, "hasLanguage") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To associate a Location with a BusinessObject."</para>
    /// labels<para>"Location"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasLocation">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasLocation</seealso>
    let hasLocation = Prefixed_Name(ebucore, "hasLocation") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasLogo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Logos can be used in a variety of contexts.
    ///             Logo can be associated with an Organisation or a Service or a PublicationChannel."</para>
    /// labels<para>"Logo"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasLogo">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasLogo</seealso>
    let hasLogo = Prefixed_Name(ebucore, "hasLogo") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasMediaFragment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:Class</para>
    ///   <para>"To define Parts (segments, fragments, etc.)
    ///             withiin a MediaResource."</para>
    /// labels<para>"Part"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasMediaFragment">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasMediaFragment</seealso>
    let hasMediaFragment = Prefixed_Name(ebucore, "hasMediaFragment") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasMedium</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Medium"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasMedium">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasMedium</seealso>
    let hasMedium = Prefixed_Name(ebucore, "hasMedium") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To establish group/collection relationship between EditorialObjects."</para>
    /// labels<para>"Member."</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasMember">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasMember</seealso>
    let hasMember = Prefixed_Name(ebucore, "hasMember") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasMetadataAttributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To identify the Agent (Contact/person or
    ///             Organisation) who has created the metadata."</para>
    /// labels<para>"Metadata attributor"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasMetadataAttributor">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasMetadataAttributor</seealso>
    let hasMetadataAttributor =
        Prefixed_Name(ebucore, "hasMetadataAttributor") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasMimeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Mime type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasMimeType">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasMimeType</seealso>
    let hasMimeType = Prefixed_Name(ebucore, "hasMimeType") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasObjectType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To define an ObjectType for the BusinessObject
    ///              (e.g. book, report, programme, clip) if not defined as a subClass of BusinessObject."</para>
    /// labels<para>"Object/asset type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasObjectType">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasObjectType</seealso>
    let hasObjectType = Prefixed_Name(ebucore, "hasObjectType") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasOriginalLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Original language"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasOriginalLanguage">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasOriginalLanguage</seealso>
    let hasOriginalLanguage =
        Prefixed_Name(ebucore, "hasOriginalLanguage") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To define Parts (segments, fragments, etc.)
    ///             within a BusinessObject."</para>
    /// labels<para>"Part"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasPart">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasPart</seealso>
    let hasPart = Prefixed_Name(ebucore, "hasPart") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasPictogram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide a visual representation of  TargetAudience or Rating."</para>
    /// labels<para>"Pictogram"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasPictogram">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasPictogram</seealso>
    let hasPictogram = Prefixed_Name(ebucore, "hasPictogram") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasPublicationChannel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To associate a PublicationEvent with a
    ///             PublicationChannel."</para>
    /// labels<para>"Publication channel"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasPublicationChannel">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasPublicationChannel</seealso>
    let hasPublicationChannel =
        Prefixed_Name(ebucore, "hasPublicationChannel") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasPublicationEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:Class</para>
    ///   <para>"To associate PublicationEvents with
    ///             PublicationChannels or as elements of a PublicationHistory or PublicationPlanning."</para>
    /// labels<para>"Publication event"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasPublicationEvent">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasPublicationEvent</seealso>
    let hasPublicationEvent =
        Prefixed_Name(ebucore, "hasPublicationEvent") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasPublicationHistory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has publication history"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasPublicationHistory">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasPublicationHistory</seealso>
    let hasPublicationHistory =
        Prefixed_Name(ebucore, "hasPublicationHistory") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasPublisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To identify an Agent involved in the publication of the Resource or BusinessObject."</para>
    /// labels<para>"Publisher"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasPublisher">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasPublisher</seealso>
    let hasPublisher = Prefixed_Name(ebucore, "hasPublisher") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasRating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"To identify the presence of Rating attributed
    ///             to a Resource or BusinessObject."</para>
    /// labels<para>"Rating"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRating">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRating</seealso>
    let hasRating = Prefixed_Name(ebucore, "hasRating") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasRatingSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To identify an Agent (Contact/person or
    ///             Organisation) who has proposed a Rating."</para>
    /// labels<para>"Rating provider"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRatingSource">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRatingSource</seealso>
    let hasRatingSource = Prefixed_Name(ebucore, "hasRatingSource") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasRelatedAudioChannel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To associate an AudioChannel with an AudioPack or an AudioStream."</para>
    /// labels<para>"Audio channel"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedAudioChannel">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedAudioChannel</seealso>
    let hasRelatedAudioChannel =
        Prefixed_Name(ebucore, "hasRelatedAudioChannel") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasRelatedAudioContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To identify the AudioContent associated with an AudioProgramme."</para>
    /// labels<para>"Audio content"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedAudioContent">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedAudioContent</seealso>
    let hasRelatedAudioContent =
        Prefixed_Name(ebucore, "hasRelatedAudioContent") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasRelatedAudioObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To identify AudioObjects associated with AudioContent or other AudioObjects."</para>
    /// labels<para>"Audio object"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedAudioObject">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedAudioObject</seealso>
    let hasRelatedAudioObject =
        Prefixed_Name(ebucore, "hasRelatedAudioObject") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasRelatedAudioStream</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To associate an AudioStream with an AudioTrack."</para>
    /// labels<para>"Audio stream"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedAudioStream">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedAudioStream</seealso>
    let hasRelatedAudioStream =
        Prefixed_Name(ebucore, "hasRelatedAudioStream") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasRelatedAudioTrack</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To associate an AudioTrack with an AudioStream or an AudioTrackUID."</para>
    /// labels<para>"Audio track"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedAudioTrack">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedAudioTrack</seealso>
    let hasRelatedAudioTrack =
        Prefixed_Name(ebucore, "hasRelatedAudioTrack") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasRelatedBusinessObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"EditorialObjects can be related to other BusinessOjects, Assets (and associated rights), PublicationEvents(defined when commissioning the EditorialObject before it is instantiated as a Resource (manifestation), or Resources, or Ratings."</para>
    /// labels<para>"Editorial object"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedBusinessObject">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedBusinessObject</seealso>
    let hasRelatedBusinessObject =
        Prefixed_Name(ebucore, "hasRelatedBusinessObject") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasRelatedEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has related event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedEvent">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedEvent</seealso>
    let hasRelatedEvent = Prefixed_Name(ebucore, "hasRelatedEvent") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasRelatedImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To associate an Image with a BusinessObject."</para>
    /// labels<para>"Image"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedImage">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedImage</seealso>
    let hasRelatedImage = Prefixed_Name(ebucore, "hasRelatedImage") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasRelatedLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"has related event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedLocation">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedLocation</seealso>
    let hasRelatedLocation =
        Prefixed_Name(ebucore, "hasRelatedLocation") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasRelatedMediaFragment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To associate a Part of an EditorialObject with a MediaFragment within the association MediaResource instantiating the EditorialObject."</para>
    /// labels<para>"Media fragment"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedMediaFragment">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedMediaFragment</seealso>
    let hasRelatedMediaFragment =
        Prefixed_Name(ebucore, "hasRelatedMediaFragment") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasRelatedPicture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"To associate a Picture with a BusinessObject or a Resource."</para>
    /// labels<para>"Picture"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedPicture">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedPicture</seealso>
    let hasRelatedPicture = Prefixed_Name(ebucore, "hasRelatedPicture") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasRelatedPublicationEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To identify the PublicationEvent associated with a MediaResource (manifestation of an EditorialObject)."</para>
    /// labels<para>"Publication event"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedPublicationEvent">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedPublicationEvent</seealso>
    let hasRelatedPublicationEvent =
        Prefixed_Name(ebucore, "hasRelatedPublicationEvent") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasRelatedResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"To identify a Resource associated with an Asset or a BusinessObject or a PublicationEvent or another Resource."</para>
    /// labels<para>"Related resource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedResource">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRelatedResource</seealso>
    let hasRelatedResource =
        Prefixed_Name(ebucore, "hasRelatedResource") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasRights</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Rights"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRights">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRights</seealso>
    let hasRights = Prefixed_Name(ebucore, "hasRights") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasRightsContact</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To identify a Contact/person who can provide
    ///             assistance / guidance regarding the associated Rights."</para>
    /// labels<para>"Contact"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRightsContact">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRightsContact</seealso>
    let hasRightsContact = Prefixed_Name(ebucore, "hasRightsContact") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasRightsHolder</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To identify an Agent (Contact/person or
    ///             Organisation) having/managing Rights."</para>
    /// labels<para>"Rights holder"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRightsHolder">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRightsHolder</seealso>
    let hasRightsHolder = Prefixed_Name(ebucore, "hasRightsHolder") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To define the role of an Agent (Contact/person
    ///             or Organisation). The association in a particular context is made by declaring the hasCastRole  associated with the BusinessObject."</para>
    /// labels<para>"Role"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRole">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasRole</seealso>
    let hasRole = Prefixed_Name(ebucore, "hasRole") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasSeason</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The Season of a Series."</para>
    /// labels<para>"Season"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasSeason">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasSeason</seealso>
    let hasSeason = Prefixed_Name(ebucore, "hasSeason") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasSigning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"To identify the presence of Signing associated
    ///             to the BusinessObject/Resource."</para>
    /// labels<para>"Accessibility - signing"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasSigning">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasSigning</seealso>
    let hasSigning = Prefixed_Name(ebucore, "hasSigning") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasSigningFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Signing format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasSigningFormat">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasSigningFormat</seealso>
    let hasSigningFormat = Prefixed_Name(ebucore, "hasSigningFormat") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To identify a Resource as the source of another Resource."</para>
    /// labels<para>"Source"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasSource">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasSource</seealso>
    let hasSource = Prefixed_Name(ebucore, "hasSource") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasStaff</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To identify staff working within an Organisation."</para>
    /// labels<para>"Staff"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasStaff">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasStaff</seealso>
    let hasStaff = Prefixed_Name(ebucore, "hasStaff") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Identifies the technical video standard of a resource, i.e. NTSC or PAL."</para>
    /// labels<para>"Standard"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasStandard">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasStandard</seealso>
    let hasStandard = Prefixed_Name(ebucore, "hasStandard") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasStorageType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To define a particular type of storage /
    ///             repository associated with the Locator from where a Resource can be
    ///             accessed."</para>
    /// labels<para>"Storage type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasStorageType">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasStorageType</seealso>
    let hasStorageType = Prefixed_Name(ebucore, "hasStorageType") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To associate a Subject addressed with a
    ///             BusinessObject / Resource."</para>
    /// labels<para>"Subject"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasSubject">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasSubject</seealso>
    let hasSubject = Prefixed_Name(ebucore, "hasSubject") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasSubtitling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"To signal the presence of Subtitling associated
    ///             with the EditorialObject or MediaResource."</para>
    /// labels<para>"Subtitling"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasSubtitling">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasSubtitling</seealso>
    let hasSubtitling = Prefixed_Name(ebucore, "hasSubtitling") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasSubtitlingFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Subtitling format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasSubtitlingFormat">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasSubtitlingFormat</seealso>
    let hasSubtitlingFormat =
        Prefixed_Name(ebucore, "hasSubtitlingFormat") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasTargetAudience</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To associate a TargetAudience (e.g. for
    ///             parental guiddance or targeting a particular social group) with a
    ///             BusinessObject/Resource."</para>
    /// labels<para>"Target audience"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasTargetAudience">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasTargetAudience</seealso>
    let hasTargetAudience = Prefixed_Name(ebucore, "hasTargetAudience") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasTheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Theme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasTheme">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasTheme</seealso>
    let hasTheme = Prefixed_Name(ebucore, "hasTheme") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasTopic</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Topic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasTopic">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasTopic</seealso>
    let hasTopic = Prefixed_Name(ebucore, "hasTopic") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasTrack</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To associate audio/data/video tracks with a MediaResource."</para>
    /// labels<para>"Track"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasTrack">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasTrack</seealso>
    let hasTrack = Prefixed_Name(ebucore, "hasTrack") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To define a type of BusinessObject is not declared as a subClass of BusinessObject."</para>
    /// labels<para>"Type"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasType">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasType</seealso>
    let hasType = Prefixed_Name(ebucore, "hasType") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hasVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:Class</para>
    ///   <para>"To identify another version of an Asset, BusinessObject or Resource."</para>
    /// labels<para>"Version"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasVersion">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasVersion</seealso>
    let hasVersion = Prefixed_Name(ebucore, "hasVersion") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasVideoEncodingFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Video encoding format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasVideoEncodingFormat">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasVideoEncodingFormat</seealso>
    let hasVideoEncodingFormat =
        Prefixed_Name(ebucore, "hasVideoEncodingFormat") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:hasVideoFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Video format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasVideoFormat">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hasVideoFormat</seealso>
    let hasVideoFormat = Prefixed_Name(ebucore, "hasVideoFormat") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:hashValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The hash value associated to a Resource. There
    ///             are different methods / algorithms to calculate hash values, which can be defined as
    ///             subproperties."</para>
    /// labels<para>"Hash code"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hashValue">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#hashValue</seealso>
    let hashValue = Prefixed_Name(ebucore, "hashValue") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:height</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The height of e.g. a video frame typically
    ///             expressed as a number of lines or the height of a picture/image expressed in millimeters
    ///             or else."</para>
    /// labels<para>"Height"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#height">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#height</seealso>
    let height = Prefixed_Name(ebucore, "height") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:heightUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The unit used to measure a Height e.g. in
    ///             pixels or number of lines or millimeters or else."</para>
    /// labels<para>"Height unit"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#heightUnit">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#heightUnit</seealso>
    let heightUnit = Prefixed_Name(ebucore, "heightUnit") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:highPass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The high pass frequency of the AudioChannel filter."</para>
    /// labels<para>"High pass frequency"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#highPass">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#highPass</seealso>
    let highPass = Prefixed_Name(ebucore, "highPass") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:highlights</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide highlights."</para>
    /// labels<para>"Highlights"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#highlights">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#highlights</seealso>
    let highlights = Prefixed_Name(ebucore, "highlights") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:holdsRightsOver</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"To identify a BusinessObject or Resource on
    ///             which an Agent (Contact/person or Organisation) holds Rights."</para>
    /// labels<para>"Asset, resource, object"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#holdsRightsOver">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#holdsRightsOver</seealso>
    let holdsRightsOver = Prefixed_Name(ebucore, "holdsRightsOver") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Corresponds to 'identifier'
    ///             in the W3C Ontology for Media Annotation. The URI may be used to express an alternative
    ///             identifier of the resource, or to share an identifier used by other instances of the
    ///             same resource (equivalent to the fucntionality owl:sameAs)."</para>
    ///   <para>"This property is intended to provide an
    ///             alternative identifier for the resource, which has no URI counterpart. In the case where
    ///             the alternative identifier can be expressed as a URI, it is recommended to use
    ///             owl:sameAs instead."</para>
    /// labels<para>"Identifier"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#identifier">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#identifier</seealso>
    let identifier = Prefixed_Name(ebucore, "identifier") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:inchesPerSecond</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Identifies the inches per second at which an analog audio tape should be played back for human consumption."</para>
    /// labels<para>"Inches per second"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#inchesPerSecond">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#inchesPerSecond</seealso>
    let inchesPerSecond = Prefixed_Name(ebucore, "inchesPerSecond") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:instantiates</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To link a particular manifestation of a
    ///             BusinessObject to the corresponding Resource."</para>
    /// labels<para>"Business object"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#instantiates">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#instantiates</seealso>
    let instantiates = Prefixed_Name(ebucore, "instantiates") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:isAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To identify a Contact/person or Organisation as part of a cast list."</para>
    /// labels<para>"Agent"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isAgent">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isAgent</seealso>
    let isAgent = Prefixed_Name(ebucore, "isAgent") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:isCharacter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To identify the character personified by a Cast individual."</para>
    /// labels<para>"Character"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isCharacter">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isCharacter</seealso>
    let isCharacter = Prefixed_Name(ebucore, "isCharacter") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:isClonedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:Class</para>
    ///   <para>"Identifies relationship between a digital instantiation of a resource and its direct copy, with no generational loss."</para>
    /// labels<para>"Cloned from"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isClonedFrom">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isClonedFrom</seealso>
    let isClonedFrom = Prefixed_Name(ebucore, "isClonedFrom") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:isCopyrightedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Copyright statement."</para>
    /// labels<para>"Copyright"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isCopyrightedBy">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isCopyrightedBy</seealso>
    let isCopyrightedBy = Prefixed_Name(ebucore, "isCopyrightedBy") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:isCoveredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The Rights or policy applicable to the
    ///             BusinessObject, Asset, Resource or PublicationEvent."</para>
    /// labels<para>"Rights"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isCoveredBy">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isCoveredBy</seealso>
    let isCoveredBy = Prefixed_Name(ebucore, "isCoveredBy") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:isDerivedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Identifies a content-based relationship between two resources."</para>
    /// labels<para>"Derived from"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isDerivedFrom">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isDerivedFrom</seealso>
    let isDerivedFrom = Prefixed_Name(ebucore, "isDerivedFrom") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:isDubbedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:Class</para>
    ///   <para>"Identifies relationship between a physical instantiation of a resource and a duplicate physical copy that may involve generational loss."</para>
    /// labels<para>"Dubbed from"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isDubbedFrom">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isDubbedFrom</seealso>
    let isDubbedFrom = Prefixed_Name(ebucore, "isDubbedFrom") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:isEpisodeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:Class</para>
    ///   <para>"The Episode of a Series or a Season."</para>
    /// labels<para>"Parent season"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isEpisodeOf">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isEpisodeOf</seealso>
    let isEpisodeOf = Prefixed_Name(ebucore, "isEpisodeOf") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:isFictitiousContact</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To identify Contact/persons being fictitious."</para>
    /// labels<para>"Fictitious contact"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isFictitiousContact">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isFictitiousContact</seealso>
    let isFictitiousContact =
        Prefixed_Name(ebucore, "isFictitiousContact") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:isMediaFragmentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To identify the MediaResource to which the MediaFragment belongs to."</para>
    /// labels<para>"Source"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isMediaFragmentOf">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isMediaFragmentOf</seealso>
    let isMediaFragmentOf = Prefixed_Name(ebucore, "isMediaFragmentOf") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:isMemberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To identify a Group to which an EidtorialObject is a member of."</para>
    /// labels<para>"Member of"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isMemberOf">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isMemberOf</seealso>
    let isMemberOf = Prefixed_Name(ebucore, "isMemberOf") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:isNextInSequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A link to a an BusinessObject or a Resource following the current BusinessObject or Resource in an ordered sequence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Next"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isNextInSequence">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isNextInSequence</seealso>
    let isNextInSequence = Prefixed_Name(ebucore, "isNextInSequence") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:isOperatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To identify the Service that operates the
    ///             PublicationChannel."</para>
    /// labels<para>"Operator, owner"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isOperatedBy">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isOperatedBy</seealso>
    let isOperatedBy = Prefixed_Name(ebucore, "isOperatedBy") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:isOwnedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To identify the Agent (Contact/person or
    ///             Organisation) who owns a Service operating a PublicationChannel."</para>
    /// labels<para>"Owner"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isOwnedBy">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isOwnedBy</seealso>
    let isOwnedBy = Prefixed_Name(ebucore, "isOwnedBy") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:isReferencedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"To express references across Assets, BusinessObjects or Resources."</para>
    /// labels<para>"Related object, resource"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isReferencedBy">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isReferencedBy</seealso>
    let isReferencedBy = Prefixed_Name(ebucore, "isReferencedBy") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:isRelatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"To establish relationships between Assets,
    ///             BusinessObjects, PublicationEvents, Ratings and Resources."</para>
    /// labels<para>"Related to"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isRelatedTo">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isRelatedTo</seealso>
    let isRelatedTo = Prefixed_Name(ebucore, "isRelatedTo") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:isReplacedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"To identify substitutions."</para>
    /// labels<para>"Replacement"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isReplacedBy">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isReplacedBy</seealso>
    let isReplacedBy = Prefixed_Name(ebucore, "isReplacedBy") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:isRequiredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"To express strong relations between Assets, BusinessObjects or Resources."</para>
    /// labels<para>"Required"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isRequiredBy">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isRequiredBy</seealso>
    let isRequiredBy = Prefixed_Name(ebucore, "isRequiredBy") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:isSeasonOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The Season of a Series."</para>
    /// labels<para>"Parent Series"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isSeasonOf">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isSeasonOf</seealso>
    let isSeasonOf = Prefixed_Name(ebucore, "isSeasonOf") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:isVersionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"To identify related versions."</para>
    /// labels<para>"Version of"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isVersionOf">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#isVersionOf</seealso>
    let isVersionOf = Prefixed_Name(ebucore, "isVersionOf") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:keywordDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide a definition for a Keyword."</para>
    /// labels<para>"Keyword definition"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#keywordDefinition">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#keywordDefinition</seealso>
    let keywordDefinition = Prefixed_Name(ebucore, "keywordDefinition") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:lineNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide the number of the line on which
    ///             ancillary data is being carried and the equivalent in the digital domain."</para>
    /// labels<para>"Line number"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#lineNumber">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#lineNumber</seealso>
    let lineNumber = Prefixed_Name(ebucore, "lineNumber") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:locationAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide the address of a
    ///            Location."</para>
    /// labels<para>"Address"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationAddress">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationAddress</seealso>
    let locationAddress = Prefixed_Name(ebucore, "locationAddress") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:locationAddressArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide the Area part of an
    ///             Adrress."</para>
    /// labels<para>"Area"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationAddressArea">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationAddressArea</seealso>
    let locationAddressArea =
        Prefixed_Name(ebucore, "locationAddressArea") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:locationAddressCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide the country name and or country
    ///             code."</para>
    /// labels<para>"Country"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationAddressCountry">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationAddressCountry</seealso>
    let locationAddressCountry =
        Prefixed_Name(ebucore, "locationAddressCountry") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:locationAddressLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To write address line with e.g. the street name
    ///             and number."</para>
    /// labels<para>"Address line"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationAddressLine">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationAddressLine</seealso>
    let locationAddressLine =
        Prefixed_Name(ebucore, "locationAddressLine") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:locationAddressLocality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide the name of a city, viallge,
    ///             etc."</para>
    /// labels<para>"Locality"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationAddressLocality">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationAddressLocality</seealso>
    let locationAddressLocality =
        Prefixed_Name(ebucore, "locationAddressLocality") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:locationAddressPostalCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide an address postal
    ///             code."</para>
    /// labels<para>"Postal code"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationAddressPostalCode">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationAddressPostalCode</seealso>
    let locationAddressPostalCode =
        Prefixed_Name(ebucore, "locationAddressPostalCode") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:locationAltitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To define the altitude of a Location in
    ///             meters."</para>
    /// labels<para>"Altitude"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationAltitude">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationAltitude</seealso>
    let locationAltitude = Prefixed_Name(ebucore, "locationAltitude") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:locationCoordinateSystemName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To specify the name of the gps coordinate
    ///             system used for the Location."</para>
    /// labels<para>"Coordinate system"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationCoordinateSystemName">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationCoordinateSystemName</seealso>
    let locationCoordinateSystemName =
        Prefixed_Name(ebucore, "locationCoordinateSystemName") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:locationDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide a description of a particular Location."</para>
    /// labels<para>"Location description"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationDescription">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationDescription</seealso>
    let locationDescription =
        Prefixed_Name(ebucore, "locationDescription") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:locationLatitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The latitude of the Location."</para>
    /// labels<para>"Latitude"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationLatitude">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationLatitude</seealso>
    let locationLatitude = Prefixed_Name(ebucore, "locationLatitude") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:locationLongitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To define the longitude of the
    ///             Location."</para>
    /// labels<para>"Longitude"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationLongitude">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationLongitude</seealso>
    let locationLongitude = Prefixed_Name(ebucore, "locationLongitude") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:locationName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The name by which a Location is
    ///             known."</para>
    /// labels<para>"Location name"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationName">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationName</seealso>
    let locationName = Prefixed_Name(ebucore, "locationName") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:locationRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide a description of a particular region assocoated to the Location."</para>
    /// labels<para>"Region"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationRegion">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locationRegion</seealso>
    let locationRegion = Prefixed_Name(ebucore, "locationRegion") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:locator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A locator from where the Resource can be accessed."</para>
    /// labels<para>"Locator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locator">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locator</seealso>
    let locator = Prefixed_Name(ebucore, "locator") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:locatorTargetInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Information about storage accessed by the locator."</para>
    /// labels<para>"Target information"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locatorTargetInformation">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#locatorTargetInformation</seealso>
    let locatorTargetInformation =
        Prefixed_Name(ebucore, "locatorTargetInformation") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:loudnessIntegratedLoudness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The value for integrated loudness measured at AudioProgramme or AudioContent level."</para>
    /// labels<para>"Integrated loudness"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#loudnessIntegratedLoudness">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#loudnessIntegratedLoudness</seealso>
    let loudnessIntegratedLoudness =
        Prefixed_Name(ebucore, "loudnessIntegratedLoudness") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:loudnessMaxMomentary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The value for maximum momentary loudness measured at AudioProgramme or AudioContent level."</para>
    /// labels<para>"Max momentary loudness"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#loudnessMaxMomentary">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#loudnessMaxMomentary</seealso>
    let loudnessMaxMomentary =
        Prefixed_Name(ebucore, "loudnessMaxMomentary") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:loudnessMaxTruepeak</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The value for maximum true peak loudness measured at AudioProgramme or AudioContent level."</para>
    /// labels<para>"Max true peak loudness"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#loudnessMaxTruepeak">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#loudnessMaxTruepeak</seealso>
    let loudnessMaxTruepeak =
        Prefixed_Name(ebucore, "loudnessMaxTruepeak") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:loudnessMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The method for loudness measurement at AudioProgramme or AudioContent level."</para>
    /// labels<para>"Loudness method"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#loudnessMethod">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#loudnessMethod</seealso>
    let loudnessMethod = Prefixed_Name(ebucore, "loudnessMethod") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:loudnessParameters</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:Class</para>
    ///   <para>"All the parameters for measurement of loudness at the AudioContent or AudioProgramme level."</para>
    /// labels<para>"loudness parameters"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#loudnessParameters">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#loudnessParameters</seealso>
    let loudnessParameters =
        Prefixed_Name(ebucore, "loudnessParameters") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:loudnessRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The loudness range measured at AudioProgramme or AudioContent level."</para>
    /// labels<para>"Loudness range"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#loudnessRange">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#loudnessRange</seealso>
    let loudnessRange = Prefixed_Name(ebucore, "loudnessRange") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:lounessMaxShortTerm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:Class</para>
    ///   <para>"The maximum short term loudness measured at AudioProgramme or AudioContent level."</para>
    /// labels<para>"Max short term loudness"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#lounessMaxShortTerm">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#lounessMaxShortTerm</seealso>
    let lounessMaxShortTerm =
        Prefixed_Name(ebucore, "lounessMaxShortTerm") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:lowPass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The low pass frequency of the AudioChannel filter."</para>
    /// labels<para>"Low pass frequency"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#lowPass">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#lowPass</seealso>
    let lowPass = Prefixed_Name(ebucore, "lowPass") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:mainTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide the main title by which the media
    ///             resource is known."</para>
    /// labels<para>"Main title"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#mainTitle">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#mainTitle</seealso>
    let mainTitle = Prefixed_Name(ebucore, "mainTitle") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:nameTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide a salutation title e.g M. Ms, Dr, Pr."</para>
    /// labels<para>"Salutation title"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#nameTitle">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#nameTitle</seealso>
    let nameTitle = Prefixed_Name(ebucore, "nameTitle") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:noiseFilter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A flag to signal that a noise filter has been
    ///             used."</para>
    /// labels<para>"Noise filter"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#noiseFilter">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#noiseFilter</seealso>
    let noiseFilter = Prefixed_Name(ebucore, "noiseFilter") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:notRated</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:Class</para>
    ///   <para>"A flag to indicate that the BusinessObejct has not been rated."</para>
    /// labels<para>"Not rated"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#notRated">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#notRated</seealso>
    let notRated = Prefixed_Name(ebucore, "notRated") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:numberOfTracks</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The number of Tracks composing the MediaResource."</para>
    /// labels<para>"Number of tracks"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#numberOfTracks">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#numberOfTracks</seealso>
    let numberOfTracks = Prefixed_Name(ebucore, "numberOfTracks") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:objectTypeDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide a definition of an AudioObject type."</para>
    /// labels<para>"Audio object type definition"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#objectTypeDefinition">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#objectTypeDefinition</seealso>
    let objectTypeDefinition =
        Prefixed_Name(ebucore, "objectTypeDefinition") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:officeAddressArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide the Area part of an
    ///             Address."</para>
    /// labels<para>"Area code"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeAddressArea">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeAddressArea</seealso>
    let officeAddressArea = Prefixed_Name(ebucore, "officeAddressArea") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:officeAddressCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide the country name and or country
    ///             code."</para>
    /// labels<para>"Country"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeAddressCountry">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeAddressCountry</seealso>
    let officeAddressCountry =
        Prefixed_Name(ebucore, "officeAddressCountry") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:officeAddressLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To write address line with e.g. the street name
    ///             and number."</para>
    /// labels<para>"Address line"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeAddressLine">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeAddressLine</seealso>
    let officeAddressLine = Prefixed_Name(ebucore, "officeAddressLine") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:officeAddressLocality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide the name of a city, village,
    ///             etc."</para>
    /// labels<para>"Locality"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeAddressLocality">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeAddressLocality</seealso>
    let officeAddressLocality =
        Prefixed_Name(ebucore, "officeAddressLocality") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:officeAddressPostalCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide an address postal
    ///             code."</para>
    /// labels<para>"Postal code"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeAddressPostalCode">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeAddressPostalCode</seealso>
    let officeAddressPostalCode =
        Prefixed_Name(ebucore, "officeAddressPostalCode") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:officeEmailAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide the professional/office email
    ///             address of an agent (Contact/person or organisation)."</para>
    /// labels<para>"Office email"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeEmailAddress">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeEmailAddress</seealso>
    let officeEmailAddress =
        Prefixed_Name(ebucore, "officeEmailAddress") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:officeHomepage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide an office/professional/company web
    ///             homepage of an Agent (Contact/person or Organisation)."</para>
    /// labels<para>"Homepage (office)"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeHomepage">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeHomepage</seealso>
    let officeHomepage = Prefixed_Name(ebucore, "officeHomepage") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:officeMailAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide the professional / office address of
    ///             an agent (Contact/person or organisation)."</para>
    /// labels<para>"Office mail address"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeMailAddress">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeMailAddress</seealso>
    let officeMailAddress = Prefixed_Name(ebucore, "officeMailAddress") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:officeMobileTelephoneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide the professional/office/company
    ///             mobile telephone number of an agent (Contact/person or organisation)."</para>
    /// labels<para>"Mobile (office)"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeMobileTelephoneNumber">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeMobileTelephoneNumber</seealso>
    let officeMobileTelephoneNumber =
        Prefixed_Name(ebucore, "officeMobileTelephoneNumber") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:officeTelephoneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide an office/professional/company
    ///             telephone number of an Agent (Contact/person or Organisation)."</para>
    /// labels<para>"Telephone (office)"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeTelephoneNumber">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#officeTelephoneNumber</seealso>
    let officeTelephoneNumber =
        Prefixed_Name(ebucore, "officeTelephoneNumber") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:organisationName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide the full name of an Organisation."</para>
    /// labels<para>"Name"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#organisationName">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#organisationName</seealso>
    let organisationName = Prefixed_Name(ebucore, "organisationName") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:orientation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:Class</para>
    ///   <para>"The orientation of a Document or an Image i.e. landscape or
    ///             portrait."</para>
    /// labels<para>"Orientation"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#orientation">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#orientation</seealso>
    let orientation = Prefixed_Name(ebucore, "orientation") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:originalTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide the original title attributed to the
    ///             media resource e.g. in its original language."</para>
    /// labels<para>"Original title"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#originalTitle">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#originalTitle</seealso>
    let originalTitle = Prefixed_Name(ebucore, "originalTitle") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:owns</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To identify the service (s) that an Agent
    ///             (Contact/person or Organisation) owns."</para>
    /// labels<para>"Owns"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#owns">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#owns</seealso>
    let owns = Prefixed_Name(ebucore, "owns") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:packageByteSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The size of a media package in
    ///             Bytes."</para>
    /// labels<para>"Package size (in bytes)"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#packageByteSize">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#packageByteSize</seealso>
    let packageByteSize = Prefixed_Name(ebucore, "packageByteSize") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:packageName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The name attributed to a
    ///             package."</para>
    /// labels<para>"Package name"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#packageName">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#packageName</seealso>
    let packageName = Prefixed_Name(ebucore, "packageName") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:partDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A definition associated with the Part."</para>
    /// labels<para>"Part definition"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#partDefinition">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#partDefinition</seealso>
    let partDefinition = Prefixed_Name(ebucore, "partDefinition") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:partName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A name by which the Part is identified."</para>
    /// labels<para>"Part name"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#partName">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#partName</seealso>
    let partName = Prefixed_Name(ebucore, "partName") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:partNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The number associated to a Part as one among
    ///             many."</para>
    /// labels<para>"Part number"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#partNumber">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#partNumber</seealso>
    let partNumber = Prefixed_Name(ebucore, "partNumber") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:partTotalNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The total number of Parts associated with a
    ///             BusinessObject."</para>
    /// labels<para>"Total number of parts"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#partTotalNumber">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#partTotalNumber</seealso>
    let partTotalNumber = Prefixed_Name(ebucore, "partTotalNumber") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:playbackSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Identifies the rate of units against time at which the resource should be played back for human consumption.  If the unit of measure is known, use sub-properties framesPerSecond or inchesPerSecond."</para>
    /// labels<para>"Playback speed"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#playbackSpeed">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#playbackSpeed</seealso>
    let playbackSpeed = Prefixed_Name(ebucore, "playbackSpeed") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:playlist</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To describe a playlist."</para>
    /// labels<para>"Playlist"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#playlist">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#playlist</seealso>
    let playlist = Prefixed_Name(ebucore, "playlist") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:privateAddressArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide the Area part of an
    ///             Adrress."</para>
    /// labels<para>"Area code"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateAddressArea">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateAddressArea</seealso>
    let privateAddressArea =
        Prefixed_Name(ebucore, "privateAddressArea") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:privateAddressCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide the country name and or country
    ///             code."</para>
    /// labels<para>"Country"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateAddressCountry">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateAddressCountry</seealso>
    let privateAddressCountry =
        Prefixed_Name(ebucore, "privateAddressCountry") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:privateAddressLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To write address line with e.g. the street name
    ///             and number."</para>
    /// labels<para>"Address line"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateAddressLine">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateAddressLine</seealso>
    let privateAddressLine =
        Prefixed_Name(ebucore, "privateAddressLine") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:privateAddressLocality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide the name of a city, viallge,
    ///             etc."</para>
    /// labels<para>"Locality"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateAddressLocality">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateAddressLocality</seealso>
    let privateAddressLocality =
        Prefixed_Name(ebucore, "privateAddressLocality") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:privateAddressPostalCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide an address postal
    ///             code."</para>
    /// labels<para>"Postal code"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateAddressPostalCode">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateAddressPostalCode</seealso>
    let privateAddressPostalCode =
        Prefixed_Name(ebucore, "privateAddressPostalCode") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:privateEmailAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide the private email address of an
    ///             agent (Contact/person)"</para>
    /// labels<para>"Private email"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateEmailAddress">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateEmailAddress</seealso>
    let privateEmailAddress =
        Prefixed_Name(ebucore, "privateEmailAddress") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:privateHomepage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide an private web homepage of an Agent
    ///             (Contact/person)."</para>
    /// labels<para>"Homepage (private)"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateHomepage">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateHomepage</seealso>
    let privateHomepage = Prefixed_Name(ebucore, "privateHomepage") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:privateMailAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide the private / personal address of an
    ///             agent (Contact/person)."</para>
    /// labels<para>"Private mail address"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateMailAddress">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateMailAddress</seealso>
    let privateMailAddress =
        Prefixed_Name(ebucore, "privateMailAddress") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:privateMobileTelephoneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide the private mobile telephone number
    ///             of an agent (Contact/person)."</para>
    /// labels<para>"Mobile (private)"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateMobileTelephoneNumber">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateMobileTelephoneNumber</seealso>
    let privateMobileTelephoneNumber =
        Prefixed_Name(ebucore, "privateMobileTelephoneNumber") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:privateTelephoneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide the private telephone number of an
    ///             Agent (Contact/person)."</para>
    /// labels<para>"Telephone (private)"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateTelephoneNumber">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#privateTelephoneNumber</seealso>
    let privateTelephoneNumber =
        Prefixed_Name(ebucore, "privateTelephoneNumber") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:promotionalInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide textual promotional information."</para>
    /// labels<para>"Promotional information"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#promotionalInformation">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#promotionalInformation</seealso>
    let promotionalInformation =
        Prefixed_Name(ebucore, "promotionalInformation") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:pubStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To indicate a publication status."</para>
    /// labels<para>"Publication status"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#pubStatus">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#pubStatus</seealso>
    let pubStatus = Prefixed_Name(ebucore, "pubStatus") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:publicationChannelName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide a name to a PublicationChannel e.g. a TV channel or website."</para>
    /// labels<para>"Publication channel name"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publicationChannelName">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publicationChannelName</seealso>
    let publicationChannelName =
        Prefixed_Name(ebucore, "publicationChannelName") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:publicationEndDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The actual end date and time of a PublicationEvent."</para>
    /// labels<para>"Publication end date &amp; time"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publicationEndDateTime">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publicationEndDateTime</seealso>
    let publicationEndDateTime =
        Prefixed_Name(ebucore, "publicationEndDateTime") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:publicationEventName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide a name to a PublicationEvent."</para>
    /// labels<para>"Publication event name"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publicationEventName">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publicationEventName</seealso>
    let publicationEventName =
        Prefixed_Name(ebucore, "publicationEventName") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:publicationScheduleDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To express specifically the schedule date to which a PublicationEvent is related in particular if the broacdast time is after midnight. For example, the schedule date would be May 29th and the programme is published at 1 am on May 30th, while still associated in the schedule with the night of May 29th."</para>
    /// labels<para>"schedule date"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publicationScheduleDate">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publicationScheduleDate</seealso>
    let publicationScheduleDate =
        Prefixed_Name(ebucore, "publicationScheduleDate") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:publicationStartDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The actual start date and time of a PublicationEvent."</para>
    /// labels<para>"Publication start date &amp; time"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publicationStartDateTime">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publicationStartDateTime</seealso>
    let publicationStartDateTime =
        Prefixed_Name(ebucore, "publicationStartDateTime") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:publishedEndDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The end date and time of a PublicationEvent as
    ///             scheduled."</para>
    /// labels<para>"Publication end date &amp; time"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publishedEndDateTime">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publishedEndDateTime</seealso>
    let publishedEndDateTime =
        Prefixed_Name(ebucore, "publishedEndDateTime") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:publishedStartDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The start date and time of a PublicationEvent
    ///             as scheduled."</para>
    /// labels<para>"Publication start date &amp; time"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publishedStartDateTime">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publishedStartDateTime</seealso>
    let publishedStartDateTime =
        Prefixed_Name(ebucore, "publishedStartDateTime") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:publishedTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The title used to identify the work at publication time."</para>
    /// labels<para>"Published title."</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publishedTitle">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#publishedTitle</seealso>
    let publishedTitle = Prefixed_Name(ebucore, "publishedTitle") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:ratingScaleMax</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The maximum value of the scale used for rating
    ///             a media resource."</para>
    /// labels<para>"Rating scale (top value)"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ratingScaleMax">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ratingScaleMax</seealso>
    let ratingScaleMax = Prefixed_Name(ebucore, "ratingScaleMax") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:ratingScaleMin</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The minimum value of the scale used for rating
    ///             a Resource."</para>
    /// labels<para>"Rating scale (min. value)"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ratingScaleMin">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ratingScaleMin</seealso>
    let ratingScaleMin = Prefixed_Name(ebucore, "ratingScaleMin") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:ratingSystemEnvironment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To identify the environment in which rating applies."</para>
    /// labels<para>"Rating environment"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ratingSystemEnvironment">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ratingSystemEnvironment</seealso>
    let ratingSystemEnvironment =
        Prefixed_Name(ebucore, "ratingSystemEnvironment") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:ratingSystemName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To identify a rating system by its name."</para>
    /// labels<para>"Rating system"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ratingSystemName">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ratingSystemName</seealso>
    let ratingSystemName = Prefixed_Name(ebucore, "ratingSystemName") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:ratingValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To express a free text rating value defined in
    ///             a rating classification scheme."</para>
    /// labels<para>"Rating"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ratingValue">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#ratingValue</seealso>
    let ratingValue = Prefixed_Name(ebucore, "ratingValue") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:reason</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide a reason for which Rating as been attributed as provided."</para>
    /// labels<para>"Reason"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#reason">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#reason</seealso>
    let reason = Prefixed_Name(ebucore, "reason") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:references</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"To express a reference between Assets, BusinessObjects or Resources."</para>
    /// labels<para>"References"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#references">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#references</seealso>
    let references = Prefixed_Name(ebucore, "references") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:regionDelimX</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To define the bottom right corner of a zone on
    ///             the x-axis. If present with regionDelimY, the zone definition is complemented by the
    ///             associated values of the height and width."</para>
    /// labels<para>"Region delimiter (x-axis)"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#regionDelimX">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#regionDelimX</seealso>
    let regionDelimX = Prefixed_Name(ebucore, "regionDelimX") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:regionDelimY</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To define the bottom right corner of a zone on
    ///             the y-axis. If present with regionDelimX, the zone definition is complemented by the
    ///             associated values of the height and width."</para>
    /// labels<para>"Region delimiter (y-axis)"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#regionDelimY">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#regionDelimY</seealso>
    let regionDelimY = Prefixed_Name(ebucore, "regionDelimY") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:relatedLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide a link to a web resource containing
    ///             information related to an Agent (Contact/person or Organisation)."</para>
    /// labels<para>"Related resources"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#relatedLink">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#relatedLink</seealso>
    let relatedLink = Prefixed_Name(ebucore, "relatedLink") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:replaces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"To identify substitution."</para>
    /// labels<para>"Replaces"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#replaces">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#replaces</seealso>
    let replaces = Prefixed_Name(ebucore, "replaces") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:requires</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Property</para>
    ///   <para>"To express dependency."</para>
    /// labels<para>"Requires"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#requires">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#requires</seealso>
    let requires = Prefixed_Name(ebucore, "requires") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:resourceDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"This can be specialised by using sub-properties
    ///             like defined in http://www.ebu.ch/metadata/cs/web/ebu_DescriptionTypeCodeCS_p.xml.htm
    ///             implemented as examples as e.g. 'summary' or
    ///             'script'."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Resource description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#resourceDescription">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#resourceDescription</seealso>
    let resourceDescription =
        Prefixed_Name(ebucore, "resourceDescription") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:resourceName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A name by which the resource can be identified."</para>
    /// labels<para>"Resource description"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#resourceName">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#resourceName</seealso>
    let resourceName = Prefixed_Name(ebucore, "resourceName") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:review</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide a text for a review."</para>
    /// labels<para>"Review"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#review">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#review</seealso>
    let review = Prefixed_Name(ebucore, "review") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:rightsExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The expression of Rights as free
    ///             text."</para>
    /// labels<para>"Rights expression"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#rightsExpression">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#rightsExpression</seealso>
    let rightsExpression = Prefixed_Name(ebucore, "rightsExpression") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:rightsLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A link to e.g. a webpage where an expression of
    ///             the rights can be found and consulted."</para>
    /// labels<para>"Rights web resource"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#rightsLink">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#rightsLink</seealso>
    let rightsLink = Prefixed_Name(ebucore, "rightsLink") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:roleDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide a definition for a role"</para>
    /// labels<para>"Role definition"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#roleDefinition">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#roleDefinition</seealso>
    let roleDefinition = Prefixed_Name(ebucore, "roleDefinition") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:sampleRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The frequency at which audio is sampled per second. Also called sampling rate."</para>
    /// labels<para>"Sample Rate"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#sampleRate">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#sampleRate</seealso>
    let sampleRate = Prefixed_Name(ebucore, "sampleRate") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:sampleSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The size of an audio sample in
    ///             bits. Also called bit depth."</para>
    /// labels<para>"Sample size"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#sampleSize">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#sampleSize</seealso>
    let sampleSize = Prefixed_Name(ebucore, "sampleSize") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:sampleType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The type of audio sample."</para>
    /// labels<para>"Sample type"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#sampleType">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#sampleType</seealso>
    let sampleType = Prefixed_Name(ebucore, "sampleType") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:scanningFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To define the scanning format for a
    ///             MediaResource. For video, the two main values are "interlaced" or
    ///             "progressive"."</para>
    /// labels<para>"Sampling format"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#scanningFormat">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#scanningFormat</seealso>
    let scanningFormat = Prefixed_Name(ebucore, "scanningFormat") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:script</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide a script."</para>
    /// labels<para>"Script"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#script">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#script</seealso>
    let script = Prefixed_Name(ebucore, "script") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:shotlog</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Provides a shot-by-shot description of resource content."</para>
    /// labels<para>"Shot log"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#shotlog">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#shotlog</seealso>
    let shotlog = Prefixed_Name(ebucore, "shotlog") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:signingSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To identify the source of the signing
    ///             resource."</para>
    /// labels<para>"Signing source"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#signingSource">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#signingSource</seealso>
    let signingSource = Prefixed_Name(ebucore, "signingSource") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:start</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:Class</para>
    ///   <para>"The start point of the MediaResource."</para>
    /// labels<para>"Start time"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#start">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#start</seealso>
    let start = Prefixed_Name(ebucore, "start") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:startNormalPlayTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The start time expressed using a time
    ///             expression."</para>
    /// labels<para>"Start time (time)"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#startNormalPlayTime">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#startNormalPlayTime</seealso>
    let startNormalPlayTime =
        Prefixed_Name(ebucore, "startNormalPlayTime") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:startNumberEditUnits</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A start time expressed as a number of edit
    ///             units."</para>
    /// labels<para>"Start time (edit units)"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#startNumberEditUnits">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#startNumberEditUnits</seealso>
    let startNumberEditUnits =
        Prefixed_Name(ebucore, "startNumberEditUnits") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:startTimecode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A start time expressed as
    ///             timecode."</para>
    /// labels<para>"Start time (timecode)"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#startTimecode">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#startTimecode</seealso>
    let startTimecode = Prefixed_Name(ebucore, "startTimecode") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:storageDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide a definition for storage."</para>
    /// labels<para>"Storage definition"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#storageDefinition">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#storageDefinition</seealso>
    let storageDefinition = Prefixed_Name(ebucore, "storageDefinition") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:subtitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A complementary subtitle."</para>
    /// labels<para>"Subtitle"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#subtitle">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#subtitle</seealso>
    let subtitle = Prefixed_Name(ebucore, "subtitle") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:subtitlingSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To identify the source of the Subtitling
    ///             resource."</para>
    /// labels<para>"Subtitling source"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#subtitlingSource">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#subtitlingSource</seealso>
    let subtitlingSource = Prefixed_Name(ebucore, "subtitlingSource") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:summary</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide a summary."</para>
    /// labels<para>"Summary"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#summary">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#summary</seealso>
    let summary = Prefixed_Name(ebucore, "summary") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:synopsis</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide a summary."</para>
    /// labels<para>"Synopsis"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#synopsis">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#synopsis</seealso>
    let synopsis = Prefixed_Name(ebucore, "synopsis") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:tableOfContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide a Table of Content."</para>
    /// labels<para>"Table of Content"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#tableOfContent">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#tableOfContent</seealso>
    let tableOfContent = Prefixed_Name(ebucore, "tableOfContent") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:targetAudienceSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To define the system used to provide a TargetAudience."</para>
    /// labels<para>"Target audience system"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#targetAudienceSystem">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#targetAudienceSystem</seealso>
    let targetAudienceSystem =
        Prefixed_Name(ebucore, "targetAudienceSystem") |> PrefixedName

    /// <summary>
    ///   <para>ebucore:textualAnnotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The value of an Annotation as free
    ///             text."</para>
    /// labels<para>"Note"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#textualAnnotation">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#textualAnnotation</seealso>
    let textualAnnotation = Prefixed_Name(ebucore, "textualAnnotation") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Specifies the title or name given to the
    ///             resource.  A root for the definition of subproperties defining ebucore titles of different types. The ebucore title type can be used to define sub-properties to optionally refine the category of
    ///             the title."</para>
    ///   <para>"All value of the EBU title status
    ///             classification scheme
    ///             (http://www.ebu.ch/metadata/cs/web/ebu_TitleStatusCodeCS_p.xml.htm) are candidates
    ///             subproperties of the title property as implemented for an example with
    ///             alternativeTitle."</para>
    /// labels<para>"Title"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#title">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#title</seealso>
    let title = Prefixed_Name(ebucore, "title") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:trackDefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide a definition associated to a
    ///             Track."</para>
    /// labels<para>"Definition"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#trackDefinition">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#trackDefinition</seealso>
    let trackDefinition = Prefixed_Name(ebucore, "trackDefinition") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:trackName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The name attributed to a Track."</para>
    /// labels<para>"Track name"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#trackName">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#trackName</seealso>
    let trackName = Prefixed_Name(ebucore, "trackName") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:translationTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A translated version of the title."</para>
    /// labels<para>"Translation title"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#translationTitle">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#translationTitle</seealso>
    let translationTitle = Prefixed_Name(ebucore, "translationTitle") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:versionTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An alternative title specific to a verison of content."</para>
    /// labels<para>"Version title"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#versionTitle">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#versionTitle</seealso>
    let versionTitle = Prefixed_Name(ebucore, "versionTitle") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:width</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The width of e.g. a video frame typically
    ///             expressed as a number of pixels, or picture/image in millimeters."</para>
    /// labels<para>"Width"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#width">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#width</seealso>
    let width = Prefixed_Name(ebucore, "width") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:widthUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The unit used to measure a width e.g. in pixels
    ///             or number of lines or millimeters or else."</para>
    /// labels<para>"Width unit"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#widthUnit">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#widthUnit</seealso>
    let widthUnit = Prefixed_Name(ebucore, "widthUnit") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:wordCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The number of words contained in a
    ///             document."</para>
    /// labels<para>"Word count"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#wordCount">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#wordCount</seealso>
    let wordCount = Prefixed_Name(ebucore, "wordCount") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:workingTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A title used while content is not complete."</para>
    /// labels<para>"Working title"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#workingTitle">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#workingTitle</seealso>
    let workingTitle = Prefixed_Name(ebucore, "workingTitle") |> PrefixedName
    /// <summary>
    ///   <para>ebucore:wrappingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"To provide additional information on the
    ///             wrapping type of ancillary data."</para>
    /// labels<para>"Wrapping type"</para></remarks>
    /// <seealso href="http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#wrappingType">http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#wrappingType</seealso>
    let wrappingType = Prefixed_Name(ebucore, "wrappingType") |> PrefixedName
