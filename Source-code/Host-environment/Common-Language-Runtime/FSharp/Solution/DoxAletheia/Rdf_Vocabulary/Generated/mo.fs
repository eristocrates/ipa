namespace http.purl.org.ontology.mo.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module mo =
    let _namespace_iri = Namespace_Iri mo |> NamespaceIRI
    /// <summary>
    ///   <para>mo:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/">http://purl.org/ontology/mo/</seealso>
    let _prefix_iri = Prefixed_Name(mo, "") |> PrefixedName
    /// <summary>
    ///   <para>mo:bootleg</para>
    /// </summary>
    /// <remarks>
    ///   <para>mo:ReleaseStatus</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/bootleg">http://purl.org/ontology/mo/bootleg</seealso>
    let bootleg = Prefixed_Name(mo, "bootleg") |> PrefixedName
    /// <summary>
    ///   <para>mo:catalogue_number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Links a release with the corresponding catalogue number</para>
    /// labels<para>catalogue number</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/catalogue_number">http://purl.org/ontology/mo/catalogue_number</seealso>
    let catalogue_number = Prefixed_Name(mo, "catalogue_number") |> PrefixedName
    /// <summary>
    ///   <para>mo:uuid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    ///             Links an object to an universally unique identifier for it.
    ///     </para>
    /// labels<para>universally unique identifier</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/uuid">http://purl.org/ontology/mo/uuid</seealso>
    let uuid = Prefixed_Name(mo, "uuid") |> PrefixedName
    /// <summary>
    ///   <para>mo:channels</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    ///         Associates a signal to the number of channels it holds (mono --&gt; 1, stereo --&gt; 2). Range is xsd:int.
    ///     </para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/channels">http://purl.org/ontology/mo/channels</seealso>
    let channels = Prefixed_Name(mo, "channels") |> PrefixedName
    /// <summary>
    ///   <para>mo:collaborated_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>Used to relate two collaborating people on a work.</para>
    /// labels<para>collaborated_with</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/collaborated_with">http://purl.org/ontology/mo/collaborated_with</seealso>
    let collaborated_with = Prefixed_Name(mo, "collaborated_with") |> PrefixedName
    /// <summary>
    ///   <para>mo:compilation_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a musical manifestation is a compilation of several Signals.</para>
    /// labels<para>compilation_of</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/compilation_of">http://purl.org/ontology/mo/compilation_of</seealso>
    let compilation_of = Prefixed_Name(mo, "compilation_of") |> PrefixedName
    /// <summary>
    ///   <para>mo:level</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>
    ///         This annotation property associates to a particular Music Ontology term the corresponding
    ///         expressiveness level. These levels can be:
    ///
    ///             - 1: Only editorial/Musicbrainz type information
    ///             - 2: Workflow information
    ///             - 3: Even decomposition
    ///
    ///         This property is mainly used for specification generation.
    ///     </para>
    /// labels<para>level</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/level">http://purl.org/ontology/mo/level</seealso>
    let level = Prefixed_Name(mo, "level") |> PrefixedName
    /// <summary>
    ///   <para>mo:AnalogSignal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///         An analog signal.
    ///     </para>
    /// labels<para>analogue signal</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/AnalogSignal">http://purl.org/ontology/mo/AnalogSignal</seealso>
    let AnalogSignal = Prefixed_Name(mo, "AnalogSignal") |> PrefixedName
    /// <summary>
    ///   <para>mo:DigitalSignal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///         A digital signal
    ///     </para>
    /// labels<para>digital signal</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/DigitalSignal">http://purl.org/ontology/mo/DigitalSignal</seealso>
    let DigitalSignal = Prefixed_Name(mo, "DigitalSignal") |> PrefixedName
    /// <summary>
    ///   <para>mo:Arrangement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///         An arrangement event.
    ///         Takes as agent the arranger, and produces a score (informational object, not the actually published score).
    ///     </para>
    /// labels<para>arrangement</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/Arrangement">http://purl.org/ontology/mo/Arrangement</seealso>
    let Arrangement = Prefixed_Name(mo, "Arrangement") |> PrefixedName
    /// <summary>
    ///   <para>mo:Orchestration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///             Orchestration includes, in addition to instrumentation, the handling of groups of instruments and their balance and interaction.
    ///     </para>
    /// labels<para>orchestration</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/Orchestration">http://purl.org/ontology/mo/Orchestration</seealso>
    let Orchestration = Prefixed_Name(mo, "Orchestration") |> PrefixedName
    /// <summary>
    ///   <para>mo:movementNum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/movementNum">http://purl.org/ontology/mo/movementNum</seealso>
    let movementNum = Prefixed_Name(mo, "movementNum") |> PrefixedName
    /// <summary>
    ///   <para>mo:Activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///         An activity period, defining when an artist was musically active.
    ///     </para>
    /// labels<para>activity</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/Activity">http://purl.org/ontology/mo/Activity</seealso>
    let Activity = Prefixed_Name(mo, "Activity") |> PrefixedName
    /// <summary>
    ///   <para>mo:PublishedScore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A published score (subclass of MusicalManifestation)</para>
    /// labels<para>published score</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/PublishedScore">http://purl.org/ontology/mo/PublishedScore</seealso>
    let PublishedScore = Prefixed_Name(mo, "PublishedScore") |> PrefixedName
    /// <summary>
    ///   <para>mo:Signal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///         A subclass of MusicalExpression, representing a signal, for example a master signal produced by a performance and a recording.
    ///     </para>
    /// labels<para>signal</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/Signal">http://purl.org/ontology/mo/Signal</seealso>
    let Signal = Prefixed_Name(mo, "Signal") |> PrefixedName
    /// <summary>
    ///   <para>mo:ReleaseStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Musical manifestation release status.</para>
    /// labels<para>release status</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/ReleaseStatus">http://purl.org/ontology/mo/ReleaseStatus</seealso>
    let ReleaseStatus = Prefixed_Name(mo, "ReleaseStatus") |> PrefixedName
    /// <summary>
    ///   <para>mo:ReleaseType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///         Release type of a particular manifestation, such as "album" or "interview"...
    ///     </para>
    /// labels<para>Release type</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/ReleaseType">http://purl.org/ontology/mo/ReleaseType</seealso>
    let ReleaseType = Prefixed_Name(mo, "ReleaseType") |> PrefixedName
    /// <summary>
    ///   <para>mo:Score</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///         Here, we are dealing with the informational object (the MusicalExpression), not the actually "published" score.
    ///         This may be, for example, the product of an arrangement process.
    ///     </para>
    /// labels<para>score</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/Score">http://purl.org/ontology/mo/Score</seealso>
    let Score = Prefixed_Name(mo, "Score") |> PrefixedName
    /// <summary>
    ///   <para>mo:SignalGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///         A musical expression representing a group of signals, for example a set of masters resulting from a whole recording/mastering session.
    ///     </para>
    /// labels<para>signal group</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/SignalGroup">http://purl.org/ontology/mo/SignalGroup</seealso>
    let SignalGroup = Prefixed_Name(mo, "SignalGroup") |> PrefixedName
    /// <summary>
    ///   <para>mo:SoloMusicArtist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Single person whose musical creative work shows sensitivity and imagination.</para>
    /// labels<para>solo music artist</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/SoloMusicArtist">http://purl.org/ontology/mo/SoloMusicArtist</seealso>
    let SoloMusicArtist = Prefixed_Name(mo, "SoloMusicArtist") |> PrefixedName
    /// <summary>
    ///   <para>mo:SoundEngineer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>sound engineer</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/SoundEngineer">http://purl.org/ontology/mo/SoundEngineer</seealso>
    let SoundEngineer = Prefixed_Name(mo, "SoundEngineer") |> PrefixedName
    /// <summary>
    ///   <para>mo:Stream</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Transmission over a network  used as medium to broadcast a musical manifestation</para>
    /// labels<para>Stream</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/Stream">http://purl.org/ontology/mo/Stream</seealso>
    let Stream = Prefixed_Name(mo, "Stream") |> PrefixedName
    /// <summary>
    ///   <para>mo:Torrent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Something available on the Bittorrent peer-2-peer filesharing network</para>
    /// labels<para>Torrent</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/Torrent">http://purl.org/ontology/mo/Torrent</seealso>
    let Torrent = Prefixed_Name(mo, "Torrent") |> PrefixedName
    /// <summary>
    ///   <para>mo:Track</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A track on a particular record</para>
    /// labels<para>track</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/Track">http://purl.org/ontology/mo/Track</seealso>
    let Track = Prefixed_Name(mo, "Track") |> PrefixedName
    /// <summary>
    ///   <para>mo:Vinyl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Vinyl used as medium to record a musical manifestation</para>
    /// labels<para>Vinyl</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/Vinyl">http://purl.org/ontology/mo/Vinyl</seealso>
    let Vinyl = Prefixed_Name(mo, "Vinyl") |> PrefixedName
    /// <summary>
    ///   <para>mo:activity_end</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Relates an artist to a date at which its activity ended</para>
    /// labels<para>activity end</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/activity_end">http://purl.org/ontology/mo/activity_end</seealso>
    let activity_end = Prefixed_Name(mo, "activity_end") |> PrefixedName
    /// <summary>
    ///   <para>mo:activity_start</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Relates an artist to a date at which its activity started</para>
    /// labels<para>activity start</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/activity_start">http://purl.org/ontology/mo/activity_start</seealso>
    let activity_start = Prefixed_Name(mo, "activity_start") |> PrefixedName
    /// <summary>
    ///   <para>mo:arrangement_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///                 Associates an arrangement event to a work
    ///         </para>
    /// labels<para>arrangement of</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/arrangement_of">http://purl.org/ontology/mo/arrangement_of</seealso>
    let arrangement_of = Prefixed_Name(mo, "arrangement_of") |> PrefixedName
    /// <summary>
    ///   <para>mo:audiobook</para>
    /// </summary>
    /// <remarks>
    ///   <para>mo:ReleaseType</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/audiobook">http://purl.org/ontology/mo/audiobook</seealso>
    let audiobook = Prefixed_Name(mo, "audiobook") |> PrefixedName
    /// <summary>
    ///   <para>mo:availableAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/availableAs">http://purl.org/ontology/mo/availableAs</seealso>
    let availableAs = Prefixed_Name(mo, "availableAs") |> PrefixedName
    /// <summary>
    ///   <para>mo:available_as</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///         Relates a musical manifestation to a musical item (this album, and my particular cd). By using
    ///         this property, there is no assumption on wether the full content is available on the linked item.
    ///         To be explicit about this, you can use a sub-property, such as mo:item (the full manifestation
    ///         is available on that item) or mo:preview (only a part of the manifestation is available on
    ///         that item).
    ///
    ///         This is a subproperty of frbr:examplar.
    ///     </para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/available_as">http://purl.org/ontology/mo/available_as</seealso>
    let available_as = Prefixed_Name(mo, "available_as") |> PrefixedName
    /// <summary>
    ///   <para>mo:publication_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Link a particular manifestation to the related signal, score, libretto, or lyrics</para>
    /// labels<para>publication of</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/publication_of">http://purl.org/ontology/mo/publication_of</seealso>
    let publication_of = Prefixed_Name(mo, "publication_of") |> PrefixedName
    /// <summary>
    ///   <para>mo:published_as</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///         Links a musical expression (e.g. a signal or a score) to one of its manifestations (e.g. a track on a particular record or a published score).
    ///     </para>
    /// labels<para>published as</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/published_as">http://purl.org/ontology/mo/published_as</seealso>
    let published_as = Prefixed_Name(mo, "published_as") |> PrefixedName
    /// <summary>
    ///   <para>mo:published</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Used to relate an person or a group of person who published the manifestation of a work.</para>
    /// labels<para>published</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/published">http://purl.org/ontology/mo/published</seealso>
    let published = Prefixed_Name(mo, "published") |> PrefixedName
    /// <summary>
    ///   <para>mo:publisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Used to relate a musical manifestation to a person or a group of person who published it.</para>
    /// labels<para>publisher</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/publisher">http://purl.org/ontology/mo/publisher</seealso>
    let publisher = Prefixed_Name(mo, "publisher") |> PrefixedName
    /// <summary>
    ///   <para>mo:puid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    ///         Link a signal to the PUIDs associated with it, that is, PUID computed from MusicalItems (mo:AudioFile)
    ///         derived from this signal.
    ///         PUIDs (Portable Unique IDentifier) are the IDs used in the
    ///         proprietary MusicDNS AudioFingerprinting system which is operated by MusicIP.
    ///
    ///         Using PUIDs, one (with some luck) can identify the Signal object associated with a particular audio file, therefore allowing
    ///         to access further information (on which release this track is featured? etc.). Using some more metadata one can identify
    ///         the particular Track corresponding to the audio file (a track on a particular release).</para>
    /// labels<para>puid</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/puid">http://purl.org/ontology/mo/puid</seealso>
    let puid = Prefixed_Name(mo, "puid") |> PrefixedName
    /// <summary>
    ///   <para>mo:record</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a release with the records it contains. A single release can be associated with multiple records, for example for a multi-disc release.</para>
    /// labels<para>released record</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/record">http://purl.org/ontology/mo/record</seealso>
    let record = Prefixed_Name(mo, "record") |> PrefixedName
    /// <summary>
    ///   <para>mo:ReleaseEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A release event, in a particular place (e.g. a country) at a particular time. Other factors of this event might include cover art, liner notes, box, etc. or a release grouping all these.</para>
    /// labels<para>release event</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/ReleaseEvent">http://purl.org/ontology/mo/ReleaseEvent</seealso>
    let ReleaseEvent = Prefixed_Name(mo, "ReleaseEvent") |> PrefixedName
    /// <summary>
    ///   <para>mo:SACD</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Super Audio Compact Disc used as medium to record a musical manifestation.</para>
    /// labels<para>SACD</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/SACD">http://purl.org/ontology/mo/SACD</seealso>
    let SACD = Prefixed_Name(mo, "SACD") |> PrefixedName
    /// <summary>
    ///   <para>mo:Show</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///         A show - a musical event lasting several days, in a particular venue. Examples can be
    ///         "The Magic Flute" at the Opera Bastille, August 2005, or a musical in the west end...
    ///     </para>
    /// labels<para>Show</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/Show">http://purl.org/ontology/mo/Show</seealso>
    let Show = Prefixed_Name(mo, "Show") |> PrefixedName
    /// <summary>
    ///   <para>mo:preview_download</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///                 This property can be used to link from a person to the website where they make previews of their works available, or from
    ///                 a manifestation (a track or an album, for example) to a web page where a preview download is available.
    ///
    ///                 This property MUST be used only if the content is just available through a web page (holding, for example
    ///                 a Flash application) - it is better to link to actual content directly through the use of mo:available_as and
    ///                 mo:Stream, mo:Torrent or mo:ED2K, etc. Therefore, Semantic Web user agents that don't know how to read HTML and even
    ///                 less to rip streams from Flash applications can still access the audio content.
    ///         </para>
    /// labels<para>preview download</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/preview_download">http://purl.org/ontology/mo/preview_download</seealso>
    let preview_download = Prefixed_Name(mo, "preview_download") |> PrefixedName
    /// <summary>
    ///   <para>mo:produced</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Used to relate an person or a group of person who produced the manifestation of a work.</para>
    /// labels<para>produced</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/produced">http://purl.org/ontology/mo/produced</seealso>
    let produced = Prefixed_Name(mo, "produced") |> PrefixedName
    /// <summary>
    ///   <para>mo:produced_signal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///                 Associates a Recording to the outputted signal.
    ///         </para>
    /// labels<para>produced signal</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/produced_signal">http://purl.org/ontology/mo/produced_signal</seealso>
    let produced_signal = Prefixed_Name(mo, "produced_signal") |> PrefixedName
    /// <summary>
    ///   <para>mo:produced_sound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///                 Associates a Performance to a physical Sound that is being produced by it.
    ///         </para>
    /// labels<para>produced sound</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/produced_sound">http://purl.org/ontology/mo/produced_sound</seealso>
    let produced_sound = Prefixed_Name(mo, "produced_sound") |> PrefixedName
    /// <summary>
    ///   <para>mo:Arranger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>arranger</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/Arranger">http://purl.org/ontology/mo/Arranger</seealso>
    let Arranger = Prefixed_Name(mo, "Arranger") |> PrefixedName
    /// <summary>
    ///   <para>mo:AudioFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An audio file, which may be available on a local file system or through http, ftp, etc.</para>
    /// labels<para>audio file</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/AudioFile">http://purl.org/ontology/mo/AudioFile</seealso>
    let AudioFile = Prefixed_Name(mo, "AudioFile") |> PrefixedName
    /// <summary>
    ///   <para>mo:Composer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>composer</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/Composer">http://purl.org/ontology/mo/Composer</seealso>
    let Composer = Prefixed_Name(mo, "Composer") |> PrefixedName
    /// <summary>
    ///   <para>mo:Transcription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Transcription event</para>
    /// labels<para>transcription</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/Transcription">http://purl.org/ontology/mo/Transcription</seealso>
    let Transcription = Prefixed_Name(mo, "Transcription") |> PrefixedName
    /// <summary>
    ///   <para>mo:activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an artist to an activity period</para>
    /// labels<para>activity</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/activity">http://purl.org/ontology/mo/activity</seealso>
    let activity = Prefixed_Name(mo, "activity") |> PrefixedName
    /// <summary>
    ///   <para>mo:album</para>
    /// </summary>
    /// <remarks>
    ///   <para>mo:ReleaseType</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/album">http://purl.org/ontology/mo/album</seealso>
    let album = Prefixed_Name(mo, "album") |> PrefixedName
    /// <summary>
    ///   <para>mo:CD</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Compact Disc used as medium to record a musical manifestation.</para>
    /// labels<para>CD</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/CD">http://purl.org/ontology/mo/CD</seealso>
    let CD = Prefixed_Name(mo, "CD") |> PrefixedName
    /// <summary>
    ///   <para>mo:amazon_asin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Used to link a work or the expression of a work to its corresponding Amazon ASINs page.</para>
    /// labels<para>amazon_asin</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/amazon_asin">http://purl.org/ontology/mo/amazon_asin</seealso>
    let amazon_asin = Prefixed_Name(mo, "amazon_asin") |> PrefixedName
    /// <summary>
    ///   <para>mo:arranged_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///         Associates a work to an arrangement event where it was arranged
    ///     </para>
    /// labels<para>arranged in</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/arranged_in">http://purl.org/ontology/mo/arranged_in</seealso>
    let arranged_in = Prefixed_Name(mo, "arranged_in") |> PrefixedName
    /// <summary>
    ///   <para>mo:artist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a membership event with the corresponding artist</para>
    /// labels<para>artist</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/artist">http://purl.org/ontology/mo/artist</seealso>
    let artist = Prefixed_Name(mo, "artist") |> PrefixedName
    /// <summary>
    ///   <para>mo:bitsPerSample</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    ///         Associates a digital signal to the number a bits used to encode one sample. Range is xsd:int.
    ///     </para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/bitsPerSample">http://purl.org/ontology/mo/bitsPerSample</seealso>
    let bitsPerSample = Prefixed_Name(mo, "bitsPerSample") |> PrefixedName
    /// <summary>
    ///   <para>mo:recordedAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/recordedAs">http://purl.org/ontology/mo/recordedAs</seealso>
    let recordedAs = Prefixed_Name(mo, "recordedAs") |> PrefixedName
    /// <summary>
    ///   <para>mo:recorded_as</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///         This is a shortcut property, allowing to bypass all the Sound/Recording steps. This property
    ///         allows to directly link a Performance to the recorded Signal. This is recommended for "normal"
    ///         users. However, advanced users wanting to express things such as the location of the microphone will
    ///         have to create this shortcut as well as the whole workflow, in order to let the "normal" users access
    ///         simply the, well, simple information:-) .
    ///     </para>
    /// labels<para>recorded as</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/recorded_as">http://purl.org/ontology/mo/recorded_as</seealso>
    let recorded_as = Prefixed_Name(mo, "recorded_as") |> PrefixedName
    /// <summary>
    ///   <para>mo:Medium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A means or instrumentality for storing or communicating musical manifestation.</para>
    /// labels<para>Medium</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/Medium">http://purl.org/ontology/mo/Medium</seealso>
    let Medium = Prefixed_Name(mo, "Medium") |> PrefixedName
    /// <summary>
    ///   <para>mo:Composition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///         A composition event.
    ///         Takes as agent the composer himself.
    ///         It produces a MusicalWork, or a MusicalExpression (when the initial "product" is a score, for example), or both...
    ///     </para>
    /// labels<para>composition</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/Composition">http://purl.org/ontology/mo/Composition</seealso>
    let Composition = Prefixed_Name(mo, "Composition") |> PrefixedName
    /// <summary>
    ///   <para>mo:biography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Used to link an artist to their online biography.</para>
    /// labels<para>biography</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/biography">http://purl.org/ontology/mo/biography</seealso>
    let biography = Prefixed_Name(mo, "biography") |> PrefixedName
    /// <summary>
    ///   <para>mo:bpm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    ///         Indicates the BPM of a MusicalWork or a particular Performance
    ///         Beats per minute: the pace of music measured by the number of beats occurring in 60 seconds.
    ///     </para>
    /// labels<para>bpm</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/bpm">http://purl.org/ontology/mo/bpm</seealso>
    let bpm = Prefixed_Name(mo, "bpm") |> PrefixedName
    /// <summary>
    ///   <para>mo:Sound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///         A subclass of MusicalExpression, representing a sound. Realisation of a MusicalWork during a musical Performance.
    ///     </para>
    /// labels<para>sound</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/Sound">http://purl.org/ontology/mo/Sound</seealso>
    let Sound = Prefixed_Name(mo, "Sound") |> PrefixedName
    /// <summary>
    ///   <para>mo:engineered</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates agents to the performances/recordings they were engineering in</para>
    /// labels<para>engineered</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/engineered">http://purl.org/ontology/mo/engineered</seealso>
    let engineered = Prefixed_Name(mo, "engineered") |> PrefixedName
    /// <summary>
    ///   <para>mo:Conductor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>conductor</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/Conductor">http://purl.org/ontology/mo/Conductor</seealso>
    let Conductor = Prefixed_Name(mo, "Conductor") |> PrefixedName
    /// <summary>
    ///   <para>mo:Performance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///         A performance event.
    ///         It might include as agents performers, engineers, conductors, or even listeners.
    ///         It might include as factors a score, a MusicalWork, musical instruments.
    ///         It might produce a sound:-)
    ///     </para>
    /// labels<para>performance</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/Performance">http://purl.org/ontology/mo/Performance</seealso>
    let Performance = Prefixed_Name(mo, "Performance") |> PrefixedName
    /// <summary>
    ///   <para>mo:DVDA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>DVD-Audio used as medium to record a musical manifestation.</para>
    /// labels<para>DVDA</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/DVDA">http://purl.org/ontology/mo/DVDA</seealso>
    let DVDA = Prefixed_Name(mo, "DVDA") |> PrefixedName
    /// <summary>
    ///   <para>mo:ED2K</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Something available on the E-Donkey peer-2-peer filesharing network</para>
    /// labels<para>ED2K</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/ED2K">http://purl.org/ontology/mo/ED2K</seealso>
    let ED2K = Prefixed_Name(mo, "ED2K") |> PrefixedName
    /// <summary>
    ///   <para>mo:Genre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///         An expressive style of music.
    ///
    ///         Any taxonomy can be plug-in here. You can either define a genre by yourself, like this:
    ///
    ///         :mygenre a mo:Genre; dc:title "electro rock".
    ///
    ///         Or you can refer to a DBPedia genre (such as http://dbpedia.org/resource/Baroque_music), allowing semantic web
    ///         clients to access easily really detailed structured information about the genre you are refering to.
    ///     </para>
    /// labels<para>Genre</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/Genre">http://purl.org/ontology/mo/Genre</seealso>
    let Genre = Prefixed_Name(mo, "Genre") |> PrefixedName
    /// <summary>
    ///   <para>mo:mit#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/ontology/mo/mit#">http://purl.org/ontology/mo/mit#</seealso>
    let ``mit#`` = Prefixed_Name(mo, "mit#") |> PrefixedName
    /// <summary>
    ///   <para>mo:Label</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Trade name of a company that produces musical works or expression of musical works.</para>
    /// labels<para>label</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/Label">http://purl.org/ontology/mo/Label</seealso>
    let Label = Prefixed_Name(mo, "Label") |> PrefixedName
    /// <summary>
    ///   <para>mo:MusicalExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    /// The intellectual or artistic realization of a work in the form of alpha-numeric, musical, or choreographic notation, sound, etc., or any combination of such forms.
    ///
    ///
    /// For example:
    ///
    /// Work #1 Franz Schubert's Trout quintet
    ///
    ///     * Expression #1 the composer's score
    ///     * Expression #2 sound issued from the performance by the Amadeus Quartet and Hephzibah Menuhin on piano
    ///     * Expression #3 sound issued from the performance by the Cleveland Quartet and Yo-Yo Ma on the cello
    ///     * . . . .
    ///
    /// The Music Ontology defines the following sub-concepts of a MusicalExpression, which should be used instead of MusicalExpression itself: Score (the
    /// result of an arrangement), Sound (produced during a performance), Signal. However, it is possible to stick to FRBR and bypass the worflow
    /// mechanism this ontology defines by using the core FRBR properties on such objects. But it is often better to use events to interconnect such
    /// expressions (allowing to go deeply into the production process - `this performer was playing this particular instrument at that
    /// particular time').
    ///
    ///     </para>
    /// labels<para>musical expression</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/MusicalExpression">http://purl.org/ontology/mo/MusicalExpression</seealso>
    let MusicalExpression = Prefixed_Name(mo, "MusicalExpression") |> PrefixedName
    /// <summary>
    ///   <para>mo:Listener</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>listened</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/Listener">http://purl.org/ontology/mo/Listener</seealso>
    let Listener = Prefixed_Name(mo, "Listener") |> PrefixedName
    /// <summary>
    ///   <para>mo:spokenword</para>
    /// </summary>
    /// <remarks>
    ///   <para>mo:ReleaseType</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/spokenword">http://purl.org/ontology/mo/spokenword</seealso>
    let spokenword = Prefixed_Name(mo, "spokenword") |> PrefixedName
    /// <summary>
    ///   <para>mo:tempo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    ///         Rate of speed or pace of music. Tempo markings are traditionally given in Italian;
    ///         common markings include: grave (solemn; very, very slow); largo (broad; very slow);
    ///         adagio (quite slow); andante (a walking pace); moderato (moderate); allegro (fast; cheerful);
    ///         vivace (lively); presto (very fast); accelerando (getting faster); ritardando (getting slower);
    ///         and a tempo (in time; returning to the original pace).
    ///     </para>
    /// labels<para>tempo</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/tempo">http://purl.org/ontology/mo/tempo</seealso>
    let tempo = Prefixed_Name(mo, "tempo") |> PrefixedName
    /// <summary>
    ///   <para>mo:text</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Associates lyrics with their text.</para>
    /// labels<para>text</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/text">http://purl.org/ontology/mo/text</seealso>
    let text = Prefixed_Name(mo, "text") |> PrefixedName
    /// <summary>
    ///   <para>mo:track_number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates the position of a track on a record medium (a CD, etc.).</para>
    /// labels<para>track number</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/track_number">http://purl.org/ontology/mo/track_number</seealso>
    let track_number = Prefixed_Name(mo, "track_number") |> PrefixedName
    /// <summary>
    ///   <para>mo:track_count</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The track count of a record</para>
    /// labels<para>track count</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/track_count">http://purl.org/ontology/mo/track_count</seealso>
    let track_count = Prefixed_Name(mo, "track_count") |> PrefixedName
    /// <summary>
    ///   <para>mo:tribute_to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates a musical work or the expression of a musical work that is a tribute to an artist - normally consisting of music being composed by the artist but performed by other artists. </para>
    /// labels<para>tribute_to</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/tribute_to">http://purl.org/ontology/mo/tribute_to</seealso>
    let tribute_to = Prefixed_Name(mo, "tribute_to") |> PrefixedName
    /// <summary>
    ///   <para>mo:usedInPerformance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/usedInPerformance">http://purl.org/ontology/mo/usedInPerformance</seealso>
    let usedInPerformance = Prefixed_Name(mo, "usedInPerformance") |> PrefixedName
    /// <summary>
    ///   <para>mo:usedInRecording</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/usedInRecording">http://purl.org/ontology/mo/usedInRecording</seealso>
    let usedInRecording = Prefixed_Name(mo, "usedInRecording") |> PrefixedName
    /// <summary>
    ///   <para>mo:want_item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A person, a group of person or an organization wanting an exemplar of a single manifestation.</para>
    /// labels<para>want_item</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/want_item">http://purl.org/ontology/mo/want_item</seealso>
    let want_item = Prefixed_Name(mo, "want_item") |> PrefixedName
    /// <summary>
    ///   <para>mo:conducted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates agents to the performances they were conducting</para>
    /// labels<para>conducted</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/conducted">http://purl.org/ontology/mo/conducted</seealso>
    let conducted = Prefixed_Name(mo, "conducted") |> PrefixedName
    /// <summary>
    ///   <para>mo:DCC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Digital Compact Cassette used as medium to record a musical manifestation.</para>
    /// labels<para>DCC</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/DCC">http://purl.org/ontology/mo/DCC</seealso>
    let DCC = Prefixed_Name(mo, "DCC") |> PrefixedName
    /// <summary>
    ///   <para>mo:composer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///         Associates a composition event to the actual composer. For example,
    ///         this property could link the event corresponding to the composition of the
    ///         Magic Flute in 1782 to Mozart himself (who obviously has a FOAF profile:-) ).
    ///     </para>
    /// labels<para>composer</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/composer">http://purl.org/ontology/mo/composer</seealso>
    let composer = Prefixed_Name(mo, "composer") |> PrefixedName
    /// <summary>
    ///   <para>mo:remaster_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This relates two musical work or the expression of a musical work, where one is a remaster of the other.
    ///
    /// A remaster is a new version made for release from source recordings that were earlier released separately. This is usually done to improve the audio quality or adjust for more modern playback equipment. The process generally doesn't involve changing the music in any artistically important way. It may, however, result in tracks that are a few seconds longer or shorter.</para>
    /// labels<para>remaster_of</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/remaster_of">http://purl.org/ontology/mo/remaster_of</seealso>
    let remaster_of = Prefixed_Name(mo, "remaster_of") |> PrefixedName
    /// <summary>
    ///   <para>mo:remixer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Used to relate a musical work or the expression of a musical work to an artist who remixed it.
    ///
    /// This involves taking just one other musical work and using audio editing to make it sound like a significantly different, but usually still recognisable, song. It can be used to link an artist to a single song that they remixed, or, if they remixed an entire musical work.</para>
    /// labels<para>remixer</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/remixer">http://purl.org/ontology/mo/remixer</seealso>
    let remixer = Prefixed_Name(mo, "remixer") |> PrefixedName
    /// <summary>
    ///   <para>mo:CorporateBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Organization or group of individuals and/or other organizations involved in the music market.</para>
    /// labels<para>corporate body</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/CorporateBody">http://purl.org/ontology/mo/CorporateBody</seealso>
    let CorporateBody = Prefixed_Name(mo, "CorporateBody") |> PrefixedName
    /// <summary>
    ///   <para>mo:compilation</para>
    /// </summary>
    /// <remarks>
    ///   <para>mo:ReleaseType</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/compilation">http://purl.org/ontology/mo/compilation</seealso>
    let compilation = Prefixed_Name(mo, "compilation") |> PrefixedName
    /// <summary>
    ///   <para>mo:compiled</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Used to relate an person or a group of person who compiled the manifestation of a musical work.</para>
    /// labels<para>compiled</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/compiled">http://purl.org/ontology/mo/compiled</seealso>
    let compiled = Prefixed_Name(mo, "compiled") |> PrefixedName
    /// <summary>
    ///   <para>mo:produced_work</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///                 Associates a composition event to the produced MusicalWork. For example,
    ///                 this property could link the event corresponding to the composition of the
    ///                 Magic Flute in 1782 to the Magic Flute musical work itself. This musical work
    ///                 can then be used in particular performances.
    ///         </para>
    /// labels<para>produced work</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/produced_work">http://purl.org/ontology/mo/produced_work</seealso>
    let produced_work = Prefixed_Name(mo, "produced_work") |> PrefixedName
    /// <summary>
    ///   <para>mo:conductor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a performance to the conductor involved</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/conductor">http://purl.org/ontology/mo/conductor</seealso>
    let conductor = Prefixed_Name(mo, "conductor") |> PrefixedName
    /// <summary>
    ///   <para>mo:derived_from</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A related signal from which the described signal is derived.</para>
    /// labels<para>derived from</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/derived_from">http://purl.org/ontology/mo/derived_from</seealso>
    let derived_from = Prefixed_Name(mo, "derived_from") |> PrefixedName
    /// <summary>
    ///   <para>mo:discogs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Used to link a musical work or the expression of a musical work, an artist or a corporate body to to its corresponding Discogs page.</para>
    /// labels<para>discogs</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/discogs">http://purl.org/ontology/mo/discogs</seealso>
    let discogs = Prefixed_Name(mo, "discogs") |> PrefixedName
    /// <summary>
    ///   <para>mo:DAT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Digital Audio Tape used as medium to record a musical manifestation.</para>
    /// labels<para>DAT</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/DAT">http://purl.org/ontology/mo/DAT</seealso>
    let DAT = Prefixed_Name(mo, "DAT") |> PrefixedName
    /// <summary>
    ///   <para>mo:compiler</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Used to relate the manifestation of a musical work to a person or a group of person who compiled it.</para>
    /// labels<para>compiler</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/compiler">http://purl.org/ontology/mo/compiler</seealso>
    let compiler = Prefixed_Name(mo, "compiler") |> PrefixedName
    /// <summary>
    ///   <para>mo:composed_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///         Associates a MusicalWork to the Composition event pertaining
    ///         to its creation. For example, I might use this property to associate
    ///         the Magic Flute to its composition event, occuring during 1782 and having as
    ///         a mo:composer Mozart.
    ///     </para>
    /// labels<para>composed in</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/composed_in">http://purl.org/ontology/mo/composed_in</seealso>
    let composed_in = Prefixed_Name(mo, "composed_in") |> PrefixedName
    /// <summary>
    ///   <para>mo:contains_sample_from</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///         Relates a signal to another signal, which has been sampled.
    ///         </para>
    /// labels<para>contains_sample_from</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/contains_sample_from">http://purl.org/ontology/mo/contains_sample_from</seealso>
    let contains_sample_from = Prefixed_Name(mo, "contains_sample_from") |> PrefixedName
    /// <summary>
    ///   <para>mo:discography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Used to links an artist to an online discography of their musical works. The discography should provide a summary of each released musical work of the artist.</para>
    /// labels<para>discography</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/discography">http://purl.org/ontology/mo/discography</seealso>
    let discography = Prefixed_Name(mo, "discography") |> PrefixedName
    /// <summary>
    ///   <para>mo:djmix_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that all (or most of) the tracks of a musical work or the expression of a musical work were mixed together from all (or most of) the tracks from another musical work or the expression of a musical work to form a so called DJ-Mix.
    ///
    /// The tracks might have been altered by pitching (so that the tempo of one track matches the tempo of the following track) and fading (so that one track blends in smoothly with the other). If the tracks have been more substantially altered, the "mo:remix" relationship type is more appropriate. </para>
    /// labels<para>djmix_of</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/djmix_of">http://purl.org/ontology/mo/djmix_of</seealso>
    let djmix_of = Prefixed_Name(mo, "djmix_of") |> PrefixedName
    /// <summary>
    ///   <para>mo:djmixed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Used to relate an artist who djmixed a musical work or the expression of a musical work.
    ///
    /// The artist usually selected the tracks, chose their sequence, and slightly changed them by fading (so that one track blends in smoothly with the other) or pitching (so that the tempo of one track matches the tempo of the following track). This applies to a 'Mixtape' in which all tracks were DJ-mixed together into one single long track. </para>
    /// labels<para>djmixed</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/djmixed">http://purl.org/ontology/mo/djmixed</seealso>
    let djmixed = Prefixed_Name(mo, "djmixed") |> PrefixedName
    /// <summary>
    ///   <para>mo:djmixed_by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Used to relate a work or the expression of a work to an artist who djmixed it.
    ///
    /// The artist usually selected the tracks, chose their sequence, and slightly changed them by fading (so that one track blends in smoothly with the other) or pitching (so that the tempo of one track matches the tempo of the following track). This applies to a 'Mixtape' in which all tracks were DJ-mixed together into one single long track. </para>
    /// labels<para>djmixed_by</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/djmixed_by">http://purl.org/ontology/mo/djmixed_by</seealso>
    let djmixed_by = Prefixed_Name(mo, "djmixed_by") |> PrefixedName
    /// <summary>
    ///   <para>mo:ean</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The European Article Number (EAN) is a universal identifier for products, commonly printed in form of barcodes on them. The numbers represented by those codes can either be 8 or 13 digits long, with the 13-digit-version being most common. EANs form a superset of the North American Universal Product Code (UPC) as every UPC can be made an EAN by adding a leading zero to it. Additionally every EAN is also a Japanese Article Number (JAN). The identifiers were formerly assigned by EAN International which merged with Uniform Code Council (UCC, the guys behind the UPCs) and Electronic Commerce Council of Canada (ECCC) to become GS1. </para>
    /// labels<para>ean</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/ean">http://purl.org/ontology/mo/ean</seealso>
    let ean = Prefixed_Name(mo, "ean") |> PrefixedName
    /// <summary>
    ///   <para>mo:gtin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>GTIN is a grouping term for EANs and UPCs. In common speech those are called barcodes although the barcodes are just a representation of those identifying numbers.</para>
    /// labels<para>gtin</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/gtin">http://purl.org/ontology/mo/gtin</seealso>
    let gtin = Prefixed_Name(mo, "gtin") |> PrefixedName
    /// <summary>
    ///   <para>mo:encodes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///         Relates a MusicalItem (a track on a particular CD, an audio file, a stream somewhere) to the signal it encodes.
    ///
    ///         This is usually a lower-resolution version of the master signal (issued from a Recording event).
    ///     </para>
    /// labels<para>encodes</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/encodes">http://purl.org/ontology/mo/encodes</seealso>
    let encodes = Prefixed_Name(mo, "encodes") |> PrefixedName
    /// <summary>
    ///   <para>mo:encoding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Method used to convert analog electronic signals into digital format such as "MP3 CBR @ 128kbps", "OGG @ 160kbps", "FLAC", etc.</para>
    /// labels<para>encoding</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/encoding">http://purl.org/ontology/mo/encoding</seealso>
    let encoding = Prefixed_Name(mo, "encoding") |> PrefixedName
    /// <summary>
    ///   <para>mo:engineer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a performance or a recording to the engineer involved</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/engineer">http://purl.org/ontology/mo/engineer</seealso>
    let engineer = Prefixed_Name(mo, "engineer") |> PrefixedName
    /// <summary>
    ///   <para>mo:ep</para>
    /// </summary>
    /// <remarks>
    ///   <para>mo:ReleaseType</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/ep">http://purl.org/ontology/mo/ep</seealso>
    let ep = Prefixed_Name(mo, "ep") |> PrefixedName
    /// <summary>
    ///   <para>mo:eventHomePage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/eventHomePage">http://purl.org/ontology/mo/eventHomePage</seealso>
    let eventHomePage = Prefixed_Name(mo, "eventHomePage") |> PrefixedName
    /// <summary>
    ///   <para>mo:exchange_item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A person, a group of person or an organization exchanging an exemplar of a single manifestation.</para>
    /// labels<para>exchange_item</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/exchange_item">http://purl.org/ontology/mo/exchange_item</seealso>
    let exchange_item = Prefixed_Name(mo, "exchange_item") |> PrefixedName
    /// <summary>
    ///   <para>mo:fanpage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Used to link an artist to a fan-created webpage devoted to that artist.</para>
    /// labels<para>fanpage</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/fanpage">http://purl.org/ontology/mo/fanpage</seealso>
    let fanpage = Prefixed_Name(mo, "fanpage") |> PrefixedName
    /// <summary>
    ///   <para>mo:free_download</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///         This property can be used to link from a person to the website where they make their works available, or from
    ///         a manifestation (a track or an album, for example) to a web page where it is available for free
    ///         download.
    ///
    ///         This property MUST be used only if the content is just available through a web page (holding, for example
    ///         a Flash application) - it is better to link to actual content directly through the use of mo:available_as and
    ///         mo:Stream, mo:Torrent or mo:ED2K, etc. Therefore, Semantic Web user agents that don't know how to read HTML and even
    ///         less to rip streams from Flash applications can still access the audio content.
    ///     </para>
    /// labels<para>free download</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/free_download">http://purl.org/ontology/mo/free_download</seealso>
    let free_download = Prefixed_Name(mo, "free_download") |> PrefixedName
    /// <summary>
    ///   <para>mo:freedownload</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/freedownload">http://purl.org/ontology/mo/freedownload</seealso>
    let freedownload = Prefixed_Name(mo, "freedownload") |> PrefixedName
    /// <summary>
    ///   <para>mo:genre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///         Associates an event (like a performance or a recording) to a particular musical genre.
    ///         Further version of this property may also include works and scores in the domain.
    ///     </para>
    /// labels<para>genre</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/genre">http://purl.org/ontology/mo/genre</seealso>
    let genre = Prefixed_Name(mo, "genre") |> PrefixedName
    /// <summary>
    ///   <para>mo:grid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The Global Release Identifier (GRid) is a system for uniquely identifying Releases of music over electronic networks (that is, online stores where you can buy music as digital files). As that it can be seen as the equivalent of the BarCode (or more correctly the GTIN) as found on physical releases of music. Like the ISRC (a code for identifying single recordings as found on releases) it was developed by the IFPI but it does not appear to be a standard of the ISO.</para>
    /// labels<para>GRid</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/grid">http://purl.org/ontology/mo/grid</seealso>
    let grid = Prefixed_Name(mo, "grid") |> PrefixedName
    /// <summary>
    ///   <para>mo:group</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a membership event with the corresponding group</para>
    /// labels<para>group</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/group">http://purl.org/ontology/mo/group</seealso>
    let group = Prefixed_Name(mo, "group") |> PrefixedName
    /// <summary>
    ///   <para>mo:has_track</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/has_track">http://purl.org/ontology/mo/has_track</seealso>
    let has_track = Prefixed_Name(mo, "has_track") |> PrefixedName
    /// <summary>
    ///   <para>mo:track</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates a part of a musical manifestation - in this particular case, a track.</para>
    /// labels<para>track</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/track">http://purl.org/ontology/mo/track</seealso>
    let track = Prefixed_Name(mo, "track") |> PrefixedName
    /// <summary>
    ///   <para>mo:performer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a performance to the performers involved</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/performer">http://purl.org/ontology/mo/performer</seealso>
    let performer = Prefixed_Name(mo, "performer") |> PrefixedName
    /// <summary>
    ///   <para>mo:homepage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an artist, a record, etc. to a corresponding web page</para>
    /// labels<para>homepage</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/homepage">http://purl.org/ontology/mo/homepage</seealso>
    let homepage = Prefixed_Name(mo, "homepage") |> PrefixedName
    /// <summary>
    ///   <para>mo:image</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates a pictorial image (JPEG, GIF, PNG, Etc.) of a musical work, the expression of a musical work, the manifestation of a work or the examplar of a manifestation.</para>
    /// labels<para>image</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/image">http://purl.org/ontology/mo/image</seealso>
    let image = Prefixed_Name(mo, "image") |> PrefixedName
    /// <summary>
    ///   <para>mo:imdb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Used to link an artist, a musical work or the expression of a musical work to their equivalent page on IMDb, the InternetMovieDatabase.</para>
    /// labels<para>imdb</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/imdb">http://purl.org/ontology/mo/imdb</seealso>
    let imdb = Prefixed_Name(mo, "imdb") |> PrefixedName
    /// <summary>
    ///   <para>mo:instrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a performance to a musical instrument involved</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/instrument">http://purl.org/ontology/mo/instrument</seealso>
    let instrument = Prefixed_Name(mo, "instrument") |> PrefixedName
    /// <summary>
    ///   <para>mo:interpreter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Adds an involved music artist, who interpreted, remixed, or otherwise modified an existing signal, which resulted in the signal that is here the subject of this relation.</para>
    /// labels<para>has interpeter</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/interpreter">http://purl.org/ontology/mo/interpreter</seealso>
    let interpreter = Prefixed_Name(mo, "interpreter") |> PrefixedName
    /// <summary>
    ///   <para>mo:interview</para>
    /// </summary>
    /// <remarks>
    ///   <para>mo:ReleaseType</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/interview">http://purl.org/ontology/mo/interview</seealso>
    let interview = Prefixed_Name(mo, "interview") |> PrefixedName
    /// <summary>
    ///   <para>mo:ipi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The Interested Parties Information Code (IPI) is an ISO standard similar to ISBNs for identifying the people or groups with some involvement with a particular musical work / compositions.</para>
    /// labels<para>ipi</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/ipi">http://purl.org/ontology/mo/ipi</seealso>
    let ipi = Prefixed_Name(mo, "ipi") |> PrefixedName
    /// <summary>
    ///   <para>mo:isrc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    ///     The ISRC (International Standard Recording Code) is the international identification system for sound recordings and music videorecordings.
    ///     Each ISRC is a unique and permanent identifier for a specific recording which can be permanently encoded into a product as its digital fingerprint.
    ///     Encoded ISRC provide the means to automatically identify recordings for royalty payments.
    ///     </para>
    /// labels<para>isrc</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/isrc">http://purl.org/ontology/mo/isrc</seealso>
    let isrc = Prefixed_Name(mo, "isrc") |> PrefixedName
    /// <summary>
    ///   <para>mo:iswc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Links a musical work to the corresponding ISWC number</para>
    /// labels<para>iswc</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/iswc">http://purl.org/ontology/mo/iswc</seealso>
    let iswc = Prefixed_Name(mo, "iswc") |> PrefixedName
    /// <summary>
    ///   <para>mo:item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///                 Relates a musical manifestation to a musical item (this album, and my particular cd) holding the
    ///                 entire manifestation, and not just a part of it.
    ///         </para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/item">http://purl.org/ontology/mo/item</seealso>
    let item = Prefixed_Name(mo, "item") |> PrefixedName
    /// <summary>
    ///   <para>mo:key</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///         Indicated the key used by the musicians during a performance, or the key of a MusicalWork.
    ///         Any of 24 major or minor diatonic scales that provide the tonal framework for a piece of music.</para>
    /// labels<para>key</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/key">http://purl.org/ontology/mo/key</seealso>
    let key = Prefixed_Name(mo, "key") |> PrefixedName
    /// <summary>
    ///   <para>mo:label</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a release event with the label releasing the record</para>
    /// labels<para>label</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/label">http://purl.org/ontology/mo/label</seealso>
    let label = Prefixed_Name(mo, "label") |> PrefixedName
    /// <summary>
    ///   <para>mo:lc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The Label Code (LC) was introduced in 1977 by the IFPI (International Federation of Phonogram and Videogram Industries) in order to unmistakably identify the different record labels (see Introduction, Record labels) for rights purposes. The Label Code consists historically of 4 figures, presently being extended to 5 figures, preceded by LC and a dash (e.g. LC-0193 = Electrola; LC-0233 = His Master's Voice). Note that the number of countries using the LC is limited, and that the code given on the item is not always accurate.</para>
    /// labels<para>lc</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/lc">http://purl.org/ontology/mo/lc</seealso>
    let lc = Prefixed_Name(mo, "lc") |> PrefixedName
    /// <summary>
    ///   <para>mo:licence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Used to link a work or the expression of a work to the license under which they can be manipulated (downloaded, modified, etc).
    ///
    /// This is usually used to link to a Creative Commons licence.</para>
    /// labels<para>licence</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/licence">http://purl.org/ontology/mo/licence</seealso>
    let licence = Prefixed_Name(mo, "licence") |> PrefixedName
    /// <summary>
    ///   <para>mo:listener</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a performance to the listener involved</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/listener">http://purl.org/ontology/mo/listener</seealso>
    let listener = Prefixed_Name(mo, "listener") |> PrefixedName
    /// <summary>
    ///   <para>mo:live</para>
    /// </summary>
    /// <remarks>
    ///   <para>mo:ReleaseType</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/live">http://purl.org/ontology/mo/live</seealso>
    let live = Prefixed_Name(mo, "live") |> PrefixedName
    /// <summary>
    ///   <para>mo:lyrics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates lyrics with a musical work</para>
    /// labels<para>lyrics</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/lyrics">http://purl.org/ontology/mo/lyrics</seealso>
    let lyrics = Prefixed_Name(mo, "lyrics") |> PrefixedName
    /// <summary>
    ///   <para>mo:mashup_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that musical works or the expressions of a musical work were mashed up on this album or track.
    ///
    /// This means that two musical works or the expressions of a musical work by different artists are mixed together, over each other, or otherwise combined into a single musical work (usually by a third artist, the remixer).</para>
    /// labels<para>mashup_of</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/mashup_of">http://purl.org/ontology/mo/mashup_of</seealso>
    let mashup_of = Prefixed_Name(mo, "mashup_of") |> PrefixedName
    /// <summary>
    ///   <para>mo:media_type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The mediatype (file format or MIME type, or physical medium) of a musical manifestation, e.g. a MP3, CD or vinyl.</para>
    /// labels<para>has media type</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/media_type">http://purl.org/ontology/mo/media_type</seealso>
    let media_type = Prefixed_Name(mo, "media_type") |> PrefixedName
    /// <summary>
    ///   <para>mo:medley_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a musical expression is a medley of several other musical expressions.
    ///
    /// This means that the orignial musical expression were rearranged to create a new musical expression in the form of a medley. </para>
    /// labels<para>medley_of</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/medley_of">http://purl.org/ontology/mo/medley_of</seealso>
    let medley_of = Prefixed_Name(mo, "medley_of") |> PrefixedName
    /// <summary>
    ///   <para>mo:member_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse of the foaf:member property</para>
    /// labels<para>member_of</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/member_of">http://purl.org/ontology/mo/member_of</seealso>
    let member_of = Prefixed_Name(mo, "member_of") |> PrefixedName
    /// <summary>
    ///   <para>mo:membership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an agent with related membership events</para>
    /// labels<para>membership</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/membership">http://purl.org/ontology/mo/membership</seealso>
    let membership = Prefixed_Name(mo, "membership") |> PrefixedName
    /// <summary>
    ///   <para>mo:meter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Associates a musical work or a score with its meter</para>
    /// labels<para>meter</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/meter">http://purl.org/ontology/mo/meter</seealso>
    let meter = Prefixed_Name(mo, "meter") |> PrefixedName
    /// <summary>
    ///   <para>mo:movement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a musical work has movements</para>
    /// labels<para>has_movement</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/movement">http://purl.org/ontology/mo/movement</seealso>
    let movement = Prefixed_Name(mo, "movement") |> PrefixedName
    /// <summary>
    ///   <para>mo:movement_number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates the position of a movement in a musical work.</para>
    /// labels<para>movement number</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/movement_number">http://purl.org/ontology/mo/movement_number</seealso>
    let movement_number = Prefixed_Name(mo, "movement_number") |> PrefixedName
    /// <summary>
    ///   <para>mo:musicbrainz</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///         Linking an agent, a track or a record to its corresponding Musicbrainz page.
    ///         </para>
    /// labels<para>musicbrainz</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/musicbrainz">http://purl.org/ontology/mo/musicbrainz</seealso>
    let musicbrainz = Prefixed_Name(mo, "musicbrainz") |> PrefixedName
    /// <summary>
    ///   <para>mo:musicbrainz_guid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Links an object to the corresponding Musicbrainz identifier</para>
    /// labels<para>Musicbrainz GUID</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/musicbrainz_guid">http://purl.org/ontology/mo/musicbrainz_guid</seealso>
    let musicbrainz_guid = Prefixed_Name(mo, "musicbrainz_guid") |> PrefixedName
    /// <summary>
    ///   <para>mo:musicmoz</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Used to link an artist, a musical work or the expression of a musical work to its corresponding MusicMoz page.</para>
    /// labels<para>musicmoz</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/musicmoz">http://purl.org/ontology/mo/musicmoz</seealso>
    let musicmoz = Prefixed_Name(mo, "musicmoz") |> PrefixedName
    /// <summary>
    ///   <para>mo:myspace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Used to link a person to its corresponding MySpace page.</para>
    /// labels<para>myspace</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/myspace">http://purl.org/ontology/mo/myspace</seealso>
    let myspace = Prefixed_Name(mo, "myspace") |> PrefixedName
    /// <summary>
    ///   <para>mo:official</para>
    /// </summary>
    /// <remarks>
    ///   <para>mo:ReleaseStatus</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/official">http://purl.org/ontology/mo/official</seealso>
    let official = Prefixed_Name(mo, "official") |> PrefixedName
    /// <summary>
    ///   <para>mo:olga</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Used to link a track to a tabulature file for track in the On-Line Guitar Archive.</para>
    /// labels<para>olga</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/olga">http://purl.org/ontology/mo/olga</seealso>
    let olga = Prefixed_Name(mo, "olga") |> PrefixedName
    /// <summary>
    ///   <para>mo:onlinecommunity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Used to link a person with an online community web page like a blog, a wiki, a forum, a livejournal page, Etc.</para>
    /// labels<para>onlinecommunity</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/onlinecommunity">http://purl.org/ontology/mo/onlinecommunity</seealso>
    let onlinecommunity = Prefixed_Name(mo, "onlinecommunity") |> PrefixedName
    /// <summary>
    ///   <para>mo:opus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    ///         Used to define a creative work, especially a musical composition numbered to designate the order of a composer's works.
    ///     </para>
    /// labels<para>opus</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/opus">http://purl.org/ontology/mo/opus</seealso>
    let opus = Prefixed_Name(mo, "opus") |> PrefixedName
    /// <summary>
    ///   <para>mo:origin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an artist to its geographic origin</para>
    /// labels<para>origin</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/origin">http://purl.org/ontology/mo/origin</seealso>
    let origin = Prefixed_Name(mo, "origin") |> PrefixedName
    /// <summary>
    ///   <para>mo:other_release_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>Indicates that two musical manifestations are essentially the same.</para>
    /// labels<para>other_release_of</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/other_release_of">http://purl.org/ontology/mo/other_release_of</seealso>
    let other_release_of = Prefixed_Name(mo, "other_release_of") |> PrefixedName
    /// <summary>
    ///   <para>mo:paid_download</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///                 Provide a link from an artist to a web page where all of that artist's musical work is available for some money,
    ///                 or a link from a manifestation (record/track, for example) to a web page providing a paid access to this manifestation.
    ///         </para>
    /// labels<para>paid download</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/paid_download">http://purl.org/ontology/mo/paid_download</seealso>
    let paid_download = Prefixed_Name(mo, "paid_download") |> PrefixedName
    /// <summary>
    ///   <para>mo:paiddownload</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/paiddownload">http://purl.org/ontology/mo/paiddownload</seealso>
    let paiddownload = Prefixed_Name(mo, "paiddownload") |> PrefixedName
    /// <summary>
    ///   <para>mo:performance_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///         Associates a Performance to a musical work or an arrangement that is being used as a factor in it.
    ///         For example, I might use this property to attach the Magic Flute musical work to
    ///         a particular Performance.
    ///     </para>
    /// labels<para>performance of</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/performance_of">http://purl.org/ontology/mo/performance_of</seealso>
    let performance_of = Prefixed_Name(mo, "performance_of") |> PrefixedName
    /// <summary>
    ///   <para>mo:performed_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///         Associates a Musical Work or an Score to Performances in which they were
    ///         a factor. For example, I might use this property in order to
    ///         associate the Magic Flute to a particular performance at the Opera
    ///         Bastille last year.</para>
    /// labels<para>performed in</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/performed_in">http://purl.org/ontology/mo/performed_in</seealso>
    let performed_in = Prefixed_Name(mo, "performed_in") |> PrefixedName
    /// <summary>
    ///   <para>mo:download</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///                 This property can be used to link from a person to the website where they make their works available, or from
    ///                 a manifestation (a track or an album, for example) to a web page where it is available for
    ///                 download.
    ///
    ///         It is better to use one of the three sub-properties instead of this one in order to specify wether the
    ///         content can be accessed for free (mo:freedownload), if it is just free preview material (mo:previewdownload), or
    ///         if it can be accessed for some money (mo:paiddownload) (this includes links to the Amazon store, for example).
    ///
    ///                 This property MUST be used only if the content is just available through a web page (holding, for example
    ///                 a Flash application) - it is better to link to actual content directly through the use of mo:available_as and
    ///                 mo:Stream, mo:Torrent or mo:ED2K, etc. Therefore, Semantic Web user agents that don't know how to read HTML and even
    ///                 less to rip streams from Flash applications can still access the audio content.
    ///         </para>
    /// labels<para>download</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/download">http://purl.org/ontology/mo/download</seealso>
    let download = Prefixed_Name(mo, "download") |> PrefixedName
    /// <summary>
    ///   <para>mo:duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The duration of a track or a signal in ms</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/duration">http://purl.org/ontology/mo/duration</seealso>
    let duration = Prefixed_Name(mo, "duration") |> PrefixedName
    /// <summary>
    ///   <para>mo:Festival</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///         A festival - musical/artistic event lasting several days, like Glastonbury, Rock Am Ring...
    ///         We migth decompose this event (which is in fact just a classification of the space/time region related to
    ///         a particular festival) using hasSubEvent in several performances at different space/time.
    ///     </para>
    /// labels<para>Festival</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/Festival">http://purl.org/ontology/mo/Festival</seealso>
    let Festival = Prefixed_Name(mo, "Festival") |> PrefixedName
    /// <summary>
    ///   <para>mo:event_homepage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a particular event to a web page</para>
    /// labels<para>event homepage</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/event_homepage">http://purl.org/ontology/mo/event_homepage</seealso>
    let event_homepage = Prefixed_Name(mo, "event_homepage") |> PrefixedName
    /// <summary>
    ///   <para>mo:single</para>
    /// </summary>
    /// <remarks>
    ///   <para>mo:ReleaseType</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/single">http://purl.org/ontology/mo/single</seealso>
    let single = Prefixed_Name(mo, "single") |> PrefixedName
    /// <summary>
    ///   <para>mo:supporting_musician</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Used to relate an artist doing long-time instrumental or vocal support for another artist.</para>
    /// labels<para>supporting_musician</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/supporting_musician">http://purl.org/ontology/mo/supporting_musician</seealso>
    let supporting_musician = Prefixed_Name(mo, "supporting_musician") |> PrefixedName
    /// <summary>
    ///   <para>mo:trackNum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/trackNum">http://purl.org/ontology/mo/trackNum</seealso>
    let trackNum = Prefixed_Name(mo, "trackNum") |> PrefixedName
    /// <summary>
    ///   <para>mo:translation_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a work or the expression of a work has translated or transliterated into another expression of a work.</para>
    /// labels<para>translation_of</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/translation_of">http://purl.org/ontology/mo/translation_of</seealso>
    let translation_of = Prefixed_Name(mo, "translation_of") |> PrefixedName
    /// <summary>
    ///   <para>mo:trmid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>
    ///         Indicates the TRMID of a track.
    ///         TRM IDs are MusicBrainz' old AudioFingerprinting system.
    ///         TRM (TRM Recognizes Music) IDs are (somewhat) unique ids that represent
    ///         the audio signature of a musical piece (see AudioFingerprint).
    ///     </para>
    /// labels<para>trmid</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/trmid">http://purl.org/ontology/mo/trmid</seealso>
    let trmid = Prefixed_Name(mo, "trmid") |> PrefixedName
    /// <summary>
    ///   <para>mo:upc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>UPC stands for "Universal Product Code", which was the original barcode used in the United States and Canada. The UPC (now officially EAN.UCC-12 is a numerical method of identifying products without redundancy worldwide for all types of products in the retail sector. The EAN is a superset of the original UPC increasing the digits to 13 with the prefix 0 reserved for UPC. As of 2005, manufacturers are only allowed to use the new 13-digit codes on their items, rather than having two separate numbers.</para>
    /// labels<para>upc</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/upc">http://purl.org/ontology/mo/upc</seealso>
    let upc = Prefixed_Name(mo, "upc") |> PrefixedName
    /// <summary>
    ///   <para>mo:usesSound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/usesSound">http://purl.org/ontology/mo/usesSound</seealso>
    let usesSound = Prefixed_Name(mo, "usesSound") |> PrefixedName
    /// <summary>
    ///   <para>mo:usesWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/usesWork">http://purl.org/ontology/mo/usesWork</seealso>
    let usesWork = Prefixed_Name(mo, "usesWork") |> PrefixedName
    /// <summary>
    ///   <para>mo:wikipedia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///         Used to link an work, an expression of a work, a manifestation of a work,
    ///         a person, an instrument or a musical genre to its corresponding WikiPedia page.
    ///         The full URL should be used, not just the WikiName.
    ///     </para>
    /// labels<para>wikipedia</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/wikipedia">http://purl.org/ontology/mo/wikipedia</seealso>
    let wikipedia = Prefixed_Name(mo, "wikipedia") |> PrefixedName
    /// <summary>
    ///   <para>mo:sampled_version_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///         Associates a digital signal with the analog version of it
    ///     </para>
    /// labels<para>sampled version of</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/sampled_version_of">http://purl.org/ontology/mo/sampled_version_of</seealso>
    let sampled_version_of = Prefixed_Name(mo, "sampled_version_of") |> PrefixedName
    /// <summary>
    ///   <para>mo:Instrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///         Any of various devices or contrivances that can be used to produce musical tones or sound.
    ///
    ///         Any taxonomy can be used to subsume this concept. The default one is one extracted by Ivan Herman
    ///         from the Musicbrainz instrument taxonomy, conforming to SKOS. This concept holds a seeAlso link
    ///         towards this taxonomy.
    ///     </para>
    /// labels<para>Instrument</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/Instrument">http://purl.org/ontology/mo/Instrument</seealso>
    let Instrument = Prefixed_Name(mo, "Instrument") |> PrefixedName
    /// <summary>
    ///   <para>mo:Instrumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///         Instrumentation deals with the techniques of writing music for a specific instrument,
    ///         including the limitations of the instrument, playing techniques and idiomatic handling of the instrument.
    ///     </para>
    /// labels<para>instrumentation</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/Instrumentation">http://purl.org/ontology/mo/Instrumentation</seealso>
    let Instrumentation = Prefixed_Name(mo, "Instrumentation") |> PrefixedName
    /// <summary>
    ///   <para>mo:Libretto</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///                 Libretto
    ///         </para>
    /// labels<para>libretto</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/Libretto">http://purl.org/ontology/mo/Libretto</seealso>
    let Libretto = Prefixed_Name(mo, "Libretto") |> PrefixedName
    /// <summary>
    ///   <para>mo:listened</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates agents to the performances they were listening in</para>
    /// labels<para>listened</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/listened">http://purl.org/ontology/mo/listened</seealso>
    let listened = Prefixed_Name(mo, "listened") |> PrefixedName
    /// <summary>
    ///   <para>mo:MD</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Mini Disc used as medium to record a musical manifestation.</para>
    /// labels<para>MD</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/MD">http://purl.org/ontology/mo/MD</seealso>
    let MD = Prefixed_Name(mo, "MD") |> PrefixedName
    /// <summary>
    ///   <para>mo:Membership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A membership event, where one or several people belongs to a group during a particular time period.</para>
    /// labels<para>membership</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/Membership">http://purl.org/ontology/mo/Membership</seealso>
    let Membership = Prefixed_Name(mo, "Membership") |> PrefixedName
    /// <summary>
    ///   <para>mo:Movement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A movement is a self-contained part of a musical work. While individual or selected movements from a composition are sometimes performed separately, a performance of the complete work requires all the movements to be performed in succession.
    ///
    /// Often a composer attempts to interrelate the movements thematically, or sometimes in more subtle ways, in order that the individual
    /// movements exert a cumulative effect. In some forms, composers sometimes link the movements, or ask for them to be played without a
    /// pause between them.
    ///     </para>
    /// labels<para>movement</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/Movement">http://purl.org/ontology/mo/Movement</seealso>
    let Movement = Prefixed_Name(mo, "Movement") |> PrefixedName
    /// <summary>
    ///   <para>mo:ismn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The International Standard Music Number (ISMN) is an ISO standard similar to ISBNs for identifying printed music publications</para>
    /// labels<para>ismn</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/ismn">http://purl.org/ontology/mo/ismn</seealso>
    let ismn = Prefixed_Name(mo, "ismn") |> PrefixedName
    /// <summary>
    ///   <para>mo:Lyrics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///         Lyrics
    ///     </para>
    /// labels<para>lyrics</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/Lyrics">http://purl.org/ontology/mo/Lyrics</seealso>
    let Lyrics = Prefixed_Name(mo, "Lyrics") |> PrefixedName
    /// <summary>
    ///   <para>mo:headliner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a performance to the headliner(s) involved</para>
    /// labels<para>headliner</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/headliner">http://purl.org/ontology/mo/headliner</seealso>
    let headliner = Prefixed_Name(mo, "headliner") |> PrefixedName
    /// <summary>
    ///   <para>mo:singer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a performance to an involved singer</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/singer">http://purl.org/ontology/mo/singer</seealso>
    let singer = Prefixed_Name(mo, "singer") |> PrefixedName
    /// <summary>
    ///   <para>mo:soundtrack</para>
    /// </summary>
    /// <remarks>
    ///   <para>mo:ReleaseType</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/soundtrack">http://purl.org/ontology/mo/soundtrack</seealso>
    let soundtrack = Prefixed_Name(mo, "soundtrack") |> PrefixedName
    /// <summary>
    ///   <para>mo:MagneticTape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Magnetic analogue tape used as medium to record a musical manifestation.</para>
    /// labels<para>MagneticTape</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/MagneticTape">http://purl.org/ontology/mo/MagneticTape</seealso>
    let MagneticTape = Prefixed_Name(mo, "MagneticTape") |> PrefixedName
    /// <summary>
    ///   <para>mo:MusicalItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A single exemplar of a musical expression.
    ///
    /// For example, it could be a single exemplar of a CD. This is normally an single object (a CD) possessed by somebody.
    ///
    /// From the FRBR final report: The entity defined as item is a concrete entity. It is in many instances a single physical object (e.g., a copy of a one-volume monograph, a single audio cassette, etc.). There are instances, however, where the entity defined as item comprises more than one physical object (e.g., a monograph issued as two separately bound volumes, a recording issued on three separate compact discs, etc.).
    ///
    /// In terms of intellectual content and physical form, an item exemplifying a manifestation is normally the same as the manifestation itself. However, variations may occur from one item to another, even when the items exemplify the same manifestation, where those variations are the result of actions external to the intent of the producer of the manifestation (e.g., damage occurring after the item was produced, binding performed by a library, etc.).
    ///     </para>
    /// labels<para>MusicalItem</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/MusicalItem">http://purl.org/ontology/mo/MusicalItem</seealso>
    let MusicalItem = Prefixed_Name(mo, "MusicalItem") |> PrefixedName
    /// <summary>
    ///   <para>mo:MusicalWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///     Distinct intellectual or artistic musical creation.
    ///
    /// From the FRBR final report: A work is an abstract entity; there is no single material object one can point to as the work. We recognize the work through individual realizations or expressions of the work, but the work itself exists only in the commonality of
    /// content between and among the various expressions of the work. When we speak of Homer's Iliad as a work, our point of reference is not a particular recitation or text of the work, but the intellectual creation that lies behind all the various expressions of the work.
    ///
    /// For example:
    ///
    /// work #1 J. S. Bach's The art of the fugue
    ///
    ///
    ///     </para>
    /// labels<para>musical work</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/MusicalWork">http://purl.org/ontology/mo/MusicalWork</seealso>
    let MusicalWork = Prefixed_Name(mo, "MusicalWork") |> PrefixedName
    /// <summary>
    ///   <para>mo:MusicGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Group of musicians, or musical ensemble, usually popular or folk, playing parts of or improvising off of a musical arrangement. </para>
    /// labels<para>music group</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/MusicGroup">http://purl.org/ontology/mo/MusicGroup</seealso>
    let MusicGroup = Prefixed_Name(mo, "MusicGroup") |> PrefixedName
    /// <summary>
    ///   <para>mo:mailorder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Used to link a musical work or the expression of a musical work to a website where people can buy a copy of the musical manifestation.</para>
    /// labels<para>mailorder</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/mailorder">http://purl.org/ontology/mo/mailorder</seealso>
    let mailorder = Prefixed_Name(mo, "mailorder") |> PrefixedName
    /// <summary>
    ///   <para>mo:MusicArtist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///         A person or a group of people (or a computer :-) ), whose musical
    ///         creative work shows sensitivity and imagination
    ///     </para>
    /// labels<para>music artist</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/MusicArtist">http://purl.org/ontology/mo/MusicArtist</seealso>
    let MusicArtist = Prefixed_Name(mo, "MusicArtist") |> PrefixedName
    /// <summary>
    ///   <para>mo:MusicalManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///
    /// This entity is related to the edition/production/publication of a musical expression (musical manifestation are closely related with the music industry (their terms, concepts, definitions, methods (production, publication, etc.), etc.)
    ///
    /// From the FRBR final report: The entity defined as manifestation encompasses a wide range of materials, including manuscripts, books, periodicals, maps, posters, sound recordings, films, video recordings, CD-ROMs, multimedia kits, etc. As an entity, manifestation represents all the physical objects that bear the same characteristics, in respect to both intellectual content and physical form.
    ///
    ///
    /// Work #1 J. S. Bach's Six suites for unaccompanied cello
    ///
    ///     * Expression #1 sound issued during the performance by Janos Starker recorded in 1963 and 1965
    ///           o Manifestation #1 recordings released on 33 1/3 rpm sound discs in 1965 by Mercury
    ///           o Manifestation #2 recordings re-released on compact disc in 1991 by Mercury
    ///     * Expression #2 sound issued during the performances by Yo-Yo Ma recorded in 1983
    ///           o Manifestation #1 recordings released on 33 1/3 rpm sound discs in 1983 by CBS Records
    ///           o Manifestation #2 recordings re-released on compact disc in 1992 by CBS Records
    ///
    ///
    /// Changes that occur deliberately or even inadvertently in the production process that affect the copies result, strictly speaking, in a new manifestation. A manifestation resulting from such a change may be identified as a particular "state" or "issue" of the publication.
    ///
    /// Changes that occur to an individual copy after the production process is complete (e.g., the loss of a page, rebinding, etc.) are not considered to result in a new manifestation. That copy is simply considered to be an exemplar (or item) of the manifestation that deviates from the copy as produced.
    ///
    /// With the entity defined as manifestation we can describe the physical characteristics of a set of items and the characteristics associated with the production and distribution of that set of items that may be important factors in enabling users to choose a manifestation appropriate to their physical needs and constraints, and to identify and acquire a copy of that manifestation.
    ///
    /// Defining manifestation as an entity also enables us to draw relationships between specific manifestations of a work. We can use the relationships between manifestations to identify, for example, the specific publication that was used to create a microreproduction.
    ///
    /// </para>
    /// labels<para>musical manifestation</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/MusicalManifestation">http://purl.org/ontology/mo/MusicalManifestation</seealso>
    let MusicalManifestation = Prefixed_Name(mo, "MusicalManifestation") |> PrefixedName
    /// <summary>
    ///   <para>mo:member</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///         Indicates a member of a musical group
    ///     </para>
    /// labels<para>member</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/member">http://purl.org/ontology/mo/member</seealso>
    let member_ = Prefixed_Name(mo, "member") |> PrefixedName
    /// <summary>
    ///   <para>mo:Performer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>performer</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/Performer">http://purl.org/ontology/mo/Performer</seealso>
    let Performer = Prefixed_Name(mo, "Performer") |> PrefixedName
    /// <summary>
    ///   <para>mo:PublishedLibretto</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A published libretto</para>
    /// labels<para>published libretto</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/PublishedLibretto">http://purl.org/ontology/mo/PublishedLibretto</seealso>
    let PublishedLibretto = Prefixed_Name(mo, "PublishedLibretto") |> PrefixedName
    /// <summary>
    ///   <para>mo:PublishedLyrics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Published lyrics, as a book or as a text file, for example</para>
    /// labels<para>published lyrics</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/PublishedLyrics">http://purl.org/ontology/mo/PublishedLyrics</seealso>
    let PublishedLyrics = Prefixed_Name(mo, "PublishedLyrics") |> PrefixedName
    /// <summary>
    ///   <para>mo:Record</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A published record (manifestation which first aim is to render the product of a recording)</para>
    /// labels<para>record</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/Record">http://purl.org/ontology/mo/Record</seealso>
    let Record = Prefixed_Name(mo, "Record") |> PrefixedName
    /// <summary>
    ///   <para>mo:Recording</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>
    ///         A recording event.
    ///         Takes a sound as a factor to produce a signal (analog or digital).
    ///         The location of such events (if any) is the actual location of the corresponding
    ///         microphone or the "recording device".
    ///     </para>
    /// labels<para>recording</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/Recording">http://purl.org/ontology/mo/Recording</seealso>
    let Recording = Prefixed_Name(mo, "Recording") |> PrefixedName
    /// <summary>
    ///   <para>mo:RecordingSession</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A set of performances/recordings/mastering events. This event can be decomposed in its constituent events using event:sub_event</para>
    /// labels<para>recording session</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/RecordingSession">http://purl.org/ontology/mo/RecordingSession</seealso>
    let RecordingSession = Prefixed_Name(mo, "RecordingSession") |> PrefixedName
    /// <summary>
    ///   <para>mo:Release</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A specific release, with barcode, box, liner notes, cover art, and a number of records</para>
    /// labels<para>release</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/Release">http://purl.org/ontology/mo/Release</seealso>
    let Release = Prefixed_Name(mo, "Release") |> PrefixedName
    /// <summary>
    ///   <para>mo:possess_item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A person, a group of person or an organization possessing an exemplar of a single manifestation.</para>
    /// labels<para>possess_item</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/possess_item">http://purl.org/ontology/mo/possess_item</seealso>
    let possess_item = Prefixed_Name(mo, "possess_item") |> PrefixedName
    /// <summary>
    ///   <para>mo:preview</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///                 Relates a musical manifestation to a musical item (this album, and my particular cd), which holds
    ///                 a preview of the manifestation (eg. one track for an album, or a snippet for a track)
    ///         </para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/preview">http://purl.org/ontology/mo/preview</seealso>
    let preview = Prefixed_Name(mo, "preview") |> PrefixedName
    /// <summary>
    ///   <para>mo:primary_instrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that an artist primarily plays an instrument, or that a member was primarily playing a particular instrument during his membership</para>
    /// labels<para>primary instrument</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/primary_instrument">http://purl.org/ontology/mo/primary_instrument</seealso>
    let primary_instrument = Prefixed_Name(mo, "primary_instrument") |> PrefixedName
    /// <summary>
    ///   <para>mo:producer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Used to relate the manifestation of a work to a person or a group of person who produced it.</para>
    /// labels<para>producer</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/producer">http://purl.org/ontology/mo/producer</seealso>
    let producer = Prefixed_Name(mo, "producer") |> PrefixedName
    /// <summary>
    ///   <para>mo:produced_score</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///         Associates an arrangement or a composition event to a score product (score here does not refer to a published score, but more
    ///         an abstract arrangement of a particular work).
    ///     </para>
    /// labels<para>produced score</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/produced_score">http://purl.org/ontology/mo/produced_score</seealso>
    let produced_score = Prefixed_Name(mo, "produced_score") |> PrefixedName

    /// <summary>
    ///   <para>mo:produced_signal_group</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a recording session with a group of master signals produced by it.</para>
    /// labels<para>produced signal group</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/produced_signal_group">http://purl.org/ontology/mo/produced_signal_group</seealso>
    let produced_signal_group =
        Prefixed_Name(mo, "produced_signal_group") |> PrefixedName

    /// <summary>
    ///   <para>mo:producesSignal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/producesSignal">http://purl.org/ontology/mo/producesSignal</seealso>
    let producesSignal = Prefixed_Name(mo, "producesSignal") |> PrefixedName
    /// <summary>
    ///   <para>mo:producesSound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/producesSound">http://purl.org/ontology/mo/producesSound</seealso>
    let producesSound = Prefixed_Name(mo, "producesSound") |> PrefixedName
    /// <summary>
    ///   <para>mo:producesWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/producesWork">http://purl.org/ontology/mo/producesWork</seealso>
    let producesWork = Prefixed_Name(mo, "producesWork") |> PrefixedName
    /// <summary>
    ///   <para>mo:productOfComposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/productOfComposition">http://purl.org/ontology/mo/productOfComposition</seealso>
    let productOfComposition = Prefixed_Name(mo, "productOfComposition") |> PrefixedName
    /// <summary>
    ///   <para>mo:promotion</para>
    /// </summary>
    /// <remarks>
    ///   <para>mo:ReleaseStatus</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/promotion">http://purl.org/ontology/mo/promotion</seealso>
    let promotion = Prefixed_Name(mo, "promotion") |> PrefixedName
    /// <summary>
    ///   <para>mo:publicationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/publicationOf">http://purl.org/ontology/mo/publicationOf</seealso>
    let publicationOf = Prefixed_Name(mo, "publicationOf") |> PrefixedName
    /// <summary>
    ///   <para>mo:publishedAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/publishedAs">http://purl.org/ontology/mo/publishedAs</seealso>
    let publishedAs = Prefixed_Name(mo, "publishedAs") |> PrefixedName
    /// <summary>
    ///   <para>mo:publishingLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/publishingLocation">http://purl.org/ontology/mo/publishingLocation</seealso>
    let publishingLocation = Prefixed_Name(mo, "publishingLocation") |> PrefixedName
    /// <summary>
    ///   <para>mo:publishing_location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///         Relates a musical manifestation to its publication location.
    ///         </para>
    /// labels<para>publishingLocation</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/publishing_location">http://purl.org/ontology/mo/publishing_location</seealso>
    let publishing_location = Prefixed_Name(mo, "publishing_location") |> PrefixedName
    /// <summary>
    ///   <para>mo:record_count</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Associates a release with the number of records it contains, e.g. the number of discs it contains in the case of a multi-disc release.</para>
    /// labels<para>record count</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/record_count">http://purl.org/ontology/mo/record_count</seealso>
    let record_count = Prefixed_Name(mo, "record_count") |> PrefixedName
    /// <summary>
    ///   <para>mo:record_number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates the position of a record in a release (e.g. a 2xLP, etc.).</para>
    /// labels<para>has record number</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/record_number">http://purl.org/ontology/mo/record_number</seealso>
    let record_number = Prefixed_Name(mo, "record_number") |> PrefixedName
    /// <summary>
    ///   <para>mo:record_side</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Associates the side on a vinyl record, where a track is located, e.g. A, B, C, etc. This property can then also be used
    /// in conjunction with mo:track_number, so that one can infer e.g. "A1", that means, track number 1 on side A.</para>
    /// labels<para>has record side</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/record_side">http://purl.org/ontology/mo/record_side</seealso>
    let record_side = Prefixed_Name(mo, "record_side") |> PrefixedName
    /// <summary>
    ///   <para>mo:records</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///         This is the inverse of the shortcut property recordedAs, allowing to relate directly a performance
    ///         to a signal.
    ///     </para>
    /// labels<para>records</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/records">http://purl.org/ontology/mo/records</seealso>
    let records = Prefixed_Name(mo, "records") |> PrefixedName
    /// <summary>
    ///   <para>mo:recorded_in</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///             Associates a physical Sound to a Recording event where it is being used
    ///         in order to produce a signal. For example, I might use this property to
    ///         associate the sound produced by a particular performance of the magic flute
    ///         to a given recording, done using my cell-phone.
    ///     </para>
    /// labels<para>recorded in</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/recorded_in">http://purl.org/ontology/mo/recorded_in</seealso>
    let recorded_in = Prefixed_Name(mo, "recorded_in") |> PrefixedName
    /// <summary>
    ///   <para>mo:recording_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///             Associates a Recording event to a physical Sound being recorded.
    ///                 For example, I might use this property to
    ///                 associate a given recording, done using my cell phone, to the
    ///         sound produced by a particular performance of the magic flute.
    ///     </para>
    /// labels<para>recorded sound</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/recording_of">http://purl.org/ontology/mo/recording_of</seealso>
    let recording_of = Prefixed_Name(mo, "recording_of") |> PrefixedName
    /// <summary>
    ///   <para>mo:release</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a release with the corresponding release event</para>
    /// labels<para>release</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/release">http://purl.org/ontology/mo/release</seealso>
    let release = Prefixed_Name(mo, "release") |> PrefixedName
    /// <summary>
    ///   <para>mo:releaseStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/releaseStatus">http://purl.org/ontology/mo/releaseStatus</seealso>
    let releaseStatus = Prefixed_Name(mo, "releaseStatus") |> PrefixedName
    /// <summary>
    ///   <para>mo:release_status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///                 Relates a musical manifestation to its release status (bootleg, ...)
    ///         </para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/release_status">http://purl.org/ontology/mo/release_status</seealso>
    let release_status = Prefixed_Name(mo, "release_status") |> PrefixedName
    /// <summary>
    ///   <para>mo:releaseType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/releaseType">http://purl.org/ontology/mo/releaseType</seealso>
    let releaseType = Prefixed_Name(mo, "releaseType") |> PrefixedName
    /// <summary>
    ///   <para>mo:release_type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///         Relates a musical manifestation to its release type (interview, spoken word, album, ...)
    ///     </para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/release_type">http://purl.org/ontology/mo/release_type</seealso>
    let release_type = Prefixed_Name(mo, "release_type") |> PrefixedName
    /// <summary>
    ///   <para>mo:remix</para>
    /// </summary>
    /// <remarks>
    ///   <para>mo:ReleaseType</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/remix">http://purl.org/ontology/mo/remix</seealso>
    let remix = Prefixed_Name(mo, "remix") |> PrefixedName
    /// <summary>
    ///   <para>mo:remix_of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Used to relate the remix of a musical work in a substantially altered version produced by mixing together individual tracks or segments of an original musical source work.</para>
    /// labels<para>remix_of</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/remix_of">http://purl.org/ontology/mo/remix_of</seealso>
    let remix_of = Prefixed_Name(mo, "remix_of") |> PrefixedName
    /// <summary>
    ///   <para>mo:remixed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Used to relate an artist who remixed a musical work or the expression of a musical work.
    ///
    /// This involves taking just one other musical work and using audio editing to make it sound like a significantly different, but usually still recognisable, song. It can be used to link an artist to a single song that they remixed, or, if they remixed an entire musical work.</para>
    /// labels<para>remixed</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/remixed">http://purl.org/ontology/mo/remixed</seealso>
    let remixed = Prefixed_Name(mo, "remixed") |> PrefixedName
    /// <summary>
    ///   <para>mo:review</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Used to link a work or the expression of a work to a review.
    ///
    /// The review does not have to be open content, as long as it is accessible to the general internet population.</para>
    /// labels<para>review</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/review">http://purl.org/ontology/mo/review</seealso>
    let review = Prefixed_Name(mo, "review") |> PrefixedName
    /// <summary>
    ///   <para>mo:sampleRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/sampleRate">http://purl.org/ontology/mo/sampleRate</seealso>
    let sampleRate = Prefixed_Name(mo, "sampleRate") |> PrefixedName
    /// <summary>
    ///   <para>mo:sample_rate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>
    ///         Associates a digital signal to its sample rate. It might be easier to express it this way instead of
    ///         defining a timeline map:-) Range is xsd:float.
    ///     </para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/sample_rate">http://purl.org/ontology/mo/sample_rate</seealso>
    let sample_rate = Prefixed_Name(mo, "sample_rate") |> PrefixedName
    /// <summary>
    ///   <para>mo:sampled</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Used to relate an artist who sampled a Signal.</para>
    /// labels<para>sampled</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/sampled">http://purl.org/ontology/mo/sampled</seealso>
    let sampled = Prefixed_Name(mo, "sampled") |> PrefixedName
    /// <summary>
    ///   <para>mo:sampler</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Used to relate the signal of a musical work to an artist who sampled it.</para>
    /// labels<para>sampler</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/sampler">http://purl.org/ontology/mo/sampler</seealso>
    let sampler = Prefixed_Name(mo, "sampler") |> PrefixedName
    /// <summary>
    ///   <para>mo:sampledVersionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/sampledVersionOf">http://purl.org/ontology/mo/sampledVersionOf</seealso>
    let sampledVersionOf = Prefixed_Name(mo, "sampledVersionOf") |> PrefixedName
    /// <summary>
    ///   <para>mo:sampled_version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///         Associates an analog signal with a sampled version of it
    ///     </para>
    /// labels<para>sampled version</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/sampled_version">http://purl.org/ontology/mo/sampled_version</seealso>
    let sampled_version = Prefixed_Name(mo, "sampled_version") |> PrefixedName
    /// <summary>
    ///   <para>mo:sell_item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A person, a group of person or an organization selling an exemplar of a single manifestation.</para>
    /// labels<para>sell_item</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/sell_item">http://purl.org/ontology/mo/sell_item</seealso>
    let sell_item = Prefixed_Name(mo, "sell_item") |> PrefixedName
    /// <summary>
    ///   <para>mo:signal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a group of signals with one of the signals it contains</para>
    /// labels<para>signal</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/signal">http://purl.org/ontology/mo/signal</seealso>
    let signal = Prefixed_Name(mo, "signal") |> PrefixedName
    /// <summary>
    ///   <para>mo:signalTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ontology/mo/signalTime">http://purl.org/ontology/mo/signalTime</seealso>
    let signalTime = Prefixed_Name(mo, "signalTime") |> PrefixedName
    /// <summary>
    ///   <para>mo:time</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>
    ///         Associates a Signal to a time object - its actual domain
    ///     </para>
    /// labels<para>time</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/time">http://purl.org/ontology/mo/time</seealso>
    let time = Prefixed_Name(mo, "time") |> PrefixedName
    /// <summary>
    ///   <para>mo:similar_to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>
    ///             A similarity relationships between two objects (so far, either an agent, a signal or a genre, but
    ///         this could grow).
    ///         This relationship is pretty general and doesn't make any assumptions on how the similarity claim
    ///         was derived.
    ///         Such similarity statements can come from a range of different sources (Musicbrainz similarities between
    ///         artists, or coming from some automatic content analysis).
    ///         However, the origin of such statements should be kept using a named graph approach - and ultimately, the
    ///         documents providing such statements should attach some metadata to themselves (confidence of the claim, etc.).
    ///         </para>
    /// labels<para>similar_to</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/similar_to">http://purl.org/ontology/mo/similar_to</seealso>
    let similar_to = Prefixed_Name(mo, "similar_to") |> PrefixedName
    /// <summary>
    ///   <para>mo:performed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates agents to the performances they were performing in</para>
    /// labels<para>performed</para></remarks>
    /// <seealso href="http://purl.org/ontology/mo/performed">http://purl.org/ontology/mo/performed</seealso>
    let performed = Prefixed_Name(mo, "performed") |> PrefixedName
