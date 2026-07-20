namespace http.purl.org.ontology.mo.slash

open DoxAletheia

module mo =
    let _namespace_name = "http://purl.org/ontology/mo/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///
    ///         An activity period, defining when an artist was musically active.
    ///
    /// <see href="http://purl.org/ontology/mo/Activity"></see></summary>
    let Activity = _prefix "Activity"
    /// <summary>
    ///
    ///         This annotation property associates to a particular Music Ontology term the corresponding
    ///         expressiveness level. These levels can be:
    ///
    ///             - 1: Only editorial/Musicbrainz type information
    ///             - 2: Workflow information
    ///             - 3: Even decomposition
    ///
    ///         This property is mainly used for specification generation.
    ///
    /// <see href="http://purl.org/ontology/mo/level"></see></summary>
    let level = _prefix "level"
    /// <summary>
    ///
    ///         An analog signal.
    ///
    /// <see href="http://purl.org/ontology/mo/AnalogSignal"></see></summary>
    let AnalogSignal = _prefix "AnalogSignal"
    /// <summary>
    ///
    ///         A subclass of MusicalExpression, representing a signal, for example a master signal produced by a performance and a recording.
    ///
    /// <see href="http://purl.org/ontology/mo/Signal"></see></summary>
    let Signal = _prefix "Signal"
    /// <summary>
    ///
    ///         A digital signal
    ///
    /// <see href="http://purl.org/ontology/mo/DigitalSignal"></see></summary>
    let DigitalSignal = _prefix "DigitalSignal"
    /// <summary>
    ///
    ///         An arrangement event.
    ///         Takes as agent the arranger, and produces a score (informational object, not the actually published score).
    ///
    /// <see href="http://purl.org/ontology/mo/Arrangement"></see></summary>
    let Arrangement = _prefix "Arrangement"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/Arranger"></see>
    /// </summary>
    let Arranger = _prefix "Arranger"
    /// <summary>
    /// An audio file, which may be available on a local file system or through http, ftp, etc.
    /// <see href="http://purl.org/ontology/mo/AudioFile"></see></summary>
    let AudioFile = _prefix "AudioFile"
    /// <summary>
    /// A means or instrumentality for storing or communicating musical manifestation.
    /// <see href="http://purl.org/ontology/mo/Medium"></see></summary>
    let Medium = _prefix "Medium"
    /// <summary>
    /// Compact Disc used as medium to record a musical manifestation.
    /// <see href="http://purl.org/ontology/mo/CD"></see></summary>
    let CD = _prefix "CD"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/Composer"></see>
    /// </summary>
    let Composer = _prefix "Composer"
    /// <summary>
    ///
    ///         A composition event.
    ///         Takes as agent the composer himself.
    ///         It produces a MusicalWork, or a MusicalExpression (when the initial "product" is a score, for example), or both...
    ///
    /// <see href="http://purl.org/ontology/mo/Composition"></see></summary>
    let Composition = _prefix "Composition"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/Conductor"></see>
    /// </summary>
    let Conductor = _prefix "Conductor"
    /// <summary>
    ///
    ///         A performance event.
    ///         It might include as agents performers, engineers, conductors, or even listeners.
    ///         It might include as factors a score, a MusicalWork, musical instruments.
    ///         It might produce a sound:-)
    ///
    /// <see href="http://purl.org/ontology/mo/Performance"></see></summary>
    let Performance = _prefix "Performance"
    /// <summary>
    /// Relates agents to the performances they were conducting
    /// <see href="http://purl.org/ontology/mo/conducted"></see></summary>
    let conducted = _prefix "conducted"
    /// <summary>
    /// Organization or group of individuals and/or other organizations involved in the music market.
    /// <see href="http://purl.org/ontology/mo/CorporateBody"></see></summary>
    let CorporateBody = _prefix "CorporateBody"
    /// <summary>
    /// Digital Audio Tape used as medium to record a musical manifestation.
    /// <see href="http://purl.org/ontology/mo/DAT"></see></summary>
    let DAT = _prefix "DAT"
    /// <summary>
    /// Digital Compact Cassette used as medium to record a musical manifestation.
    /// <see href="http://purl.org/ontology/mo/DCC"></see></summary>
    let DCC = _prefix "DCC"
    /// <summary>
    /// DVD-Audio used as medium to record a musical manifestation.
    /// <see href="http://purl.org/ontology/mo/DVDA"></see></summary>
    let DVDA = _prefix "DVDA"
    /// <summary>
    /// Something available on the E-Donkey peer-2-peer filesharing network
    /// <see href="http://purl.org/ontology/mo/ED2K"></see></summary>
    let ED2K = _prefix "ED2K"
    /// <summary>
    ///
    ///         A festival - musical/artistic event lasting several days, like Glastonbury, Rock Am Ring...
    ///         We migth decompose this event (which is in fact just a classification of the space/time region related to
    ///         a particular festival) using hasSubEvent in several performances at different space/time.
    ///
    /// <see href="http://purl.org/ontology/mo/Festival"></see></summary>
    let Festival = _prefix "Festival"
    /// <summary>
    ///
    ///         An expressive style of music.
    ///
    ///         Any taxonomy can be plug-in here. You can either define a genre by yourself, like this:
    ///
    ///         :mygenre a mo:Genre; dc:title "electro rock".
    ///
    ///         Or you can refer to a DBPedia genre (such as http://dbpedia.org/resource/Baroque_music), allowing semantic web
    ///         clients to access easily really detailed structured information about the genre you are refering to.
    ///
    /// <see href="http://purl.org/ontology/mo/Genre"></see></summary>
    let Genre = _prefix "Genre"
    /// <summary>
    ///
    ///         Any of various devices or contrivances that can be used to produce musical tones or sound.
    ///
    ///         Any taxonomy can be used to subsume this concept. The default one is one extracted by Ivan Herman
    ///         from the Musicbrainz instrument taxonomy, conforming to SKOS. This concept holds a seeAlso link
    ///         towards this taxonomy.
    ///
    /// <see href="http://purl.org/ontology/mo/Instrument"></see></summary>
    let Instrument = _prefix "Instrument"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/mit#"></see>
    /// </summary>
    let ``mit#`` = _prefix "mit#"
    /// <summary>
    ///
    ///         Instrumentation deals with the techniques of writing music for a specific instrument,
    ///         including the limitations of the instrument, playing techniques and idiomatic handling of the instrument.
    ///
    /// <see href="http://purl.org/ontology/mo/Instrumentation"></see></summary>
    let Instrumentation = _prefix "Instrumentation"
    /// <summary>
    /// Trade name of a company that produces musical works or expression of musical works.
    /// <see href="http://purl.org/ontology/mo/Label"></see></summary>
    let Label = _prefix "Label"
    /// <summary>
    ///
    ///                 Libretto
    ///
    /// <see href="http://purl.org/ontology/mo/Libretto"></see></summary>
    let Libretto = _prefix "Libretto"
    /// <summary>
    ///
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
    ///
    /// <see href="http://purl.org/ontology/mo/MusicalExpression"></see></summary>
    let MusicalExpression = _prefix "MusicalExpression"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/Listener"></see>
    /// </summary>
    let Listener = _prefix "Listener"
    /// <summary>
    /// Relates agents to the performances they were listening in
    /// <see href="http://purl.org/ontology/mo/listened"></see></summary>
    let listened = _prefix "listened"
    /// <summary>
    ///
    ///         Lyrics
    ///
    /// <see href="http://purl.org/ontology/mo/Lyrics"></see></summary>
    let Lyrics = _prefix "Lyrics"
    /// <summary>
    /// Mini Disc used as medium to record a musical manifestation.
    /// <see href="http://purl.org/ontology/mo/MD"></see></summary>
    let MD = _prefix "MD"
    /// <summary>
    /// Magnetic analogue tape used as medium to record a musical manifestation.
    /// <see href="http://purl.org/ontology/mo/MagneticTape"></see></summary>
    let MagneticTape = _prefix "MagneticTape"
    /// <summary>
    /// A single exemplar of a musical expression.
    ///
    /// For example, it could be a single exemplar of a CD. This is normally an single object (a CD) possessed by somebody.
    ///
    /// From the FRBR final report: The entity defined as item is a concrete entity. It is in many instances a single physical object (e.g., a copy of a one-volume monograph, a single audio cassette, etc.). There are instances, however, where the entity defined as item comprises more than one physical object (e.g., a monograph issued as two separately bound volumes, a recording issued on three separate compact discs, etc.).
    ///
    /// In terms of intellectual content and physical form, an item exemplifying a manifestation is normally the same as the manifestation itself. However, variations may occur from one item to another, even when the items exemplify the same manifestation, where those variations are the result of actions external to the intent of the producer of the manifestation (e.g., damage occurring after the item was produced, binding performed by a library, etc.).
    ///
    /// <see href="http://purl.org/ontology/mo/MusicalItem"></see></summary>
    let MusicalItem = _prefix "MusicalItem"
    /// <summary>
    /// A membership event, where one or several people belongs to a group during a particular time period.
    /// <see href="http://purl.org/ontology/mo/Membership"></see></summary>
    let Membership = _prefix "Membership"
    /// <summary>
    /// A movement is a self-contained part of a musical work. While individual or selected movements from a composition are sometimes performed separately, a performance of the complete work requires all the movements to be performed in succession.
    ///
    /// Often a composer attempts to interrelate the movements thematically, or sometimes in more subtle ways, in order that the individual
    /// movements exert a cumulative effect. In some forms, composers sometimes link the movements, or ask for them to be played without a
    /// pause between them.
    ///
    /// <see href="http://purl.org/ontology/mo/Movement"></see></summary>
    let Movement = _prefix "Movement"
    /// <summary>
    ///
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
    ///
    /// <see href="http://purl.org/ontology/mo/MusicalWork"></see></summary>
    let MusicalWork = _prefix "MusicalWork"
    /// <summary>
    ///
    ///         A person or a group of people (or a computer :-) ), whose musical
    ///         creative work shows sensitivity and imagination
    ///
    /// <see href="http://purl.org/ontology/mo/MusicArtist"></see></summary>
    let MusicArtist = _prefix "MusicArtist"
    /// <summary>
    /// Group of musicians, or musical ensemble, usually popular or folk, playing parts of or improvising off of a musical arrangement.
    /// <see href="http://purl.org/ontology/mo/MusicGroup"></see></summary>
    let MusicGroup = _prefix "MusicGroup"
    /// <summary>
    ///
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
    ///
    /// <see href="http://purl.org/ontology/mo/MusicalManifestation"></see></summary>
    let MusicalManifestation = _prefix "MusicalManifestation"
    /// <summary>
    ///
    ///             Orchestration includes, in addition to instrumentation, the handling of groups of instruments and their balance and interaction.
    ///
    /// <see href="http://purl.org/ontology/mo/Orchestration"></see></summary>
    let Orchestration = _prefix "Orchestration"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/Performer"></see>
    /// </summary>
    let Performer = _prefix "Performer"
    /// <summary>
    /// Relates agents to the performances they were performing in
    /// <see href="http://purl.org/ontology/mo/performed"></see></summary>
    let performed = _prefix "performed"
    /// <summary>
    /// A published libretto
    /// <see href="http://purl.org/ontology/mo/PublishedLibretto"></see></summary>
    let PublishedLibretto = _prefix "PublishedLibretto"
    /// <summary>
    /// Published lyrics, as a book or as a text file, for example
    /// <see href="http://purl.org/ontology/mo/PublishedLyrics"></see></summary>
    let PublishedLyrics = _prefix "PublishedLyrics"
    /// <summary>
    /// A published score (subclass of MusicalManifestation)
    /// <see href="http://purl.org/ontology/mo/PublishedScore"></see></summary>
    let PublishedScore = _prefix "PublishedScore"
    /// <summary>
    /// A published record (manifestation which first aim is to render the product of a recording)
    /// <see href="http://purl.org/ontology/mo/Record"></see></summary>
    let Record = _prefix "Record"
    /// <summary>
    ///
    ///         A recording event.
    ///         Takes a sound as a factor to produce a signal (analog or digital).
    ///         The location of such events (if any) is the actual location of the corresponding
    ///         microphone or the "recording device".
    ///
    /// <see href="http://purl.org/ontology/mo/Recording"></see></summary>
    let Recording = _prefix "Recording"
    /// <summary>
    /// A set of performances/recordings/mastering events. This event can be decomposed in its constituent events using event:sub_event
    /// <see href="http://purl.org/ontology/mo/RecordingSession"></see></summary>
    let RecordingSession = _prefix "RecordingSession"
    /// <summary>
    /// A specific release, with barcode, box, liner notes, cover art, and a number of records
    /// <see href="http://purl.org/ontology/mo/Release"></see></summary>
    let Release = _prefix "Release"
    /// <summary>
    /// A release event, in a particular place (e.g. a country) at a particular time. Other factors of this event might include cover art, liner notes, box, etc. or a release grouping all these.
    /// <see href="http://purl.org/ontology/mo/ReleaseEvent"></see></summary>
    let ReleaseEvent = _prefix "ReleaseEvent"
    /// <summary>
    /// Musical manifestation release status.
    /// <see href="http://purl.org/ontology/mo/ReleaseStatus"></see></summary>
    let ReleaseStatus = _prefix "ReleaseStatus"
    /// <summary>
    ///
    ///         Release type of a particular manifestation, such as "album" or "interview"...
    ///
    /// <see href="http://purl.org/ontology/mo/ReleaseType"></see></summary>
    let ReleaseType = _prefix "ReleaseType"
    /// <summary>
    /// Super Audio Compact Disc used as medium to record a musical manifestation.
    /// <see href="http://purl.org/ontology/mo/SACD"></see></summary>
    let SACD = _prefix "SACD"
    /// <summary>
    ///
    ///         Here, we are dealing with the informational object (the MusicalExpression), not the actually "published" score.
    ///         This may be, for example, the product of an arrangement process.
    ///
    /// <see href="http://purl.org/ontology/mo/Score"></see></summary>
    let Score = _prefix "Score"
    /// <summary>
    ///
    ///         A show - a musical event lasting several days, in a particular venue. Examples can be
    ///         "The Magic Flute" at the Opera Bastille, August 2005, or a musical in the west end...
    ///
    /// <see href="http://purl.org/ontology/mo/Show"></see></summary>
    let Show = _prefix "Show"
    /// <summary>
    ///
    ///         A musical expression representing a group of signals, for example a set of masters resulting from a whole recording/mastering session.
    ///
    /// <see href="http://purl.org/ontology/mo/SignalGroup"></see></summary>
    let SignalGroup = _prefix "SignalGroup"
    /// <summary>
    /// Single person whose musical creative work shows sensitivity and imagination.
    /// <see href="http://purl.org/ontology/mo/SoloMusicArtist"></see></summary>
    let SoloMusicArtist = _prefix "SoloMusicArtist"
    /// <summary>
    ///
    ///         A subclass of MusicalExpression, representing a sound. Realisation of a MusicalWork during a musical Performance.
    ///
    /// <see href="http://purl.org/ontology/mo/Sound"></see></summary>
    let Sound = _prefix "Sound"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/SoundEngineer"></see>
    /// </summary>
    let SoundEngineer = _prefix "SoundEngineer"
    /// <summary>
    /// Relates agents to the performances/recordings they were engineering in
    /// <see href="http://purl.org/ontology/mo/engineered"></see></summary>
    let engineered = _prefix "engineered"
    /// <summary>
    /// Transmission over a network  used as medium to broadcast a musical manifestation
    /// <see href="http://purl.org/ontology/mo/Stream"></see></summary>
    let Stream = _prefix "Stream"
    /// <summary>
    /// Something available on the Bittorrent peer-2-peer filesharing network
    /// <see href="http://purl.org/ontology/mo/Torrent"></see></summary>
    let Torrent = _prefix "Torrent"
    /// <summary>
    /// A track on a particular record
    /// <see href="http://purl.org/ontology/mo/Track"></see></summary>
    let Track = _prefix "Track"
    /// <summary>
    /// Transcription event
    /// <see href="http://purl.org/ontology/mo/Transcription"></see></summary>
    let Transcription = _prefix "Transcription"
    /// <summary>
    /// Vinyl used as medium to record a musical manifestation
    /// <see href="http://purl.org/ontology/mo/Vinyl"></see></summary>
    let Vinyl = _prefix "Vinyl"
    /// <summary>
    /// Relates an artist to an activity period
    /// <see href="http://purl.org/ontology/mo/activity"></see></summary>
    let activity = _prefix "activity"
    /// <summary>
    /// Relates an artist to a date at which its activity ended
    /// <see href="http://purl.org/ontology/mo/activity_end"></see></summary>
    let activity_end = _prefix "activity_end"
    /// <summary>
    /// Relates an artist to a date at which its activity started
    /// <see href="http://purl.org/ontology/mo/activity_start"></see></summary>
    let activity_start = _prefix "activity_start"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/album"></see>
    /// </summary>
    let album = _prefix "album"
    /// <summary>
    /// Used to link a work or the expression of a work to its corresponding Amazon ASINs page.
    /// <see href="http://purl.org/ontology/mo/amazon_asin"></see></summary>
    let amazon_asin = _prefix "amazon_asin"
    /// <summary>
    ///
    ///         Associates a work to an arrangement event where it was arranged
    ///
    /// <see href="http://purl.org/ontology/mo/arranged_in"></see></summary>
    let arranged_in = _prefix "arranged_in"
    /// <summary>
    ///
    ///                 Associates an arrangement event to a work
    ///
    /// <see href="http://purl.org/ontology/mo/arrangement_of"></see></summary>
    let arrangement_of = _prefix "arrangement_of"
    /// <summary>
    /// Relates a membership event with the corresponding artist
    /// <see href="http://purl.org/ontology/mo/artist"></see></summary>
    let artist = _prefix "artist"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/audiobook"></see>
    /// </summary>
    let audiobook = _prefix "audiobook"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/availableAs"></see>
    /// </summary>
    let availableAs = _prefix "availableAs"
    /// <summary>
    ///
    ///         Relates a musical manifestation to a musical item (this album, and my particular cd). By using
    ///         this property, there is no assumption on wether the full content is available on the linked item.
    ///         To be explicit about this, you can use a sub-property, such as mo:item (the full manifestation
    ///         is available on that item) or mo:preview (only a part of the manifestation is available on
    ///         that item).
    ///
    ///         This is a subproperty of frbr:examplar.
    ///
    /// <see href="http://purl.org/ontology/mo/available_as"></see></summary>
    let available_as = _prefix "available_as"
    /// <summary>
    /// Used to link an artist to their online biography.
    /// <see href="http://purl.org/ontology/mo/biography"></see></summary>
    let biography = _prefix "biography"
    /// <summary>
    ///
    ///         Associates a digital signal to the number a bits used to encode one sample. Range is xsd:int.
    ///
    /// <see href="http://purl.org/ontology/mo/bitsPerSample"></see></summary>
    let bitsPerSample = _prefix "bitsPerSample"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/bootleg"></see>
    /// </summary>
    let bootleg = _prefix "bootleg"
    /// <summary>
    ///
    ///         Indicates the BPM of a MusicalWork or a particular Performance
    ///         Beats per minute: the pace of music measured by the number of beats occurring in 60 seconds.
    ///
    /// <see href="http://purl.org/ontology/mo/bpm"></see></summary>
    let bpm = _prefix "bpm"
    /// <summary>
    /// Links a release with the corresponding catalogue number
    /// <see href="http://purl.org/ontology/mo/catalogue_number"></see></summary>
    let catalogue_number = _prefix "catalogue_number"
    /// <summary>
    ///
    ///             Links an object to an universally unique identifier for it.
    ///
    /// <see href="http://purl.org/ontology/mo/uuid"></see></summary>
    let uuid = _prefix "uuid"
    /// <summary>
    ///
    ///         Associates a signal to the number of channels it holds (mono --&gt; 1, stereo --&gt; 2). Range is xsd:int.
    ///
    /// <see href="http://purl.org/ontology/mo/channels"></see></summary>
    let channels = _prefix "channels"
    /// <summary>
    /// Used to relate two collaborating people on a work.
    /// <see href="http://purl.org/ontology/mo/collaborated_with"></see></summary>
    let collaborated_with = _prefix "collaborated_with"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/compilation"></see>
    /// </summary>
    let compilation = _prefix "compilation"
    /// <summary>
    /// Indicates that a musical manifestation is a compilation of several Signals.
    /// <see href="http://purl.org/ontology/mo/compilation_of"></see></summary>
    let compilation_of = _prefix "compilation_of"
    /// <summary>
    /// Used to relate an person or a group of person who compiled the manifestation of a musical work.
    /// <see href="http://purl.org/ontology/mo/compiled"></see></summary>
    let compiled = _prefix "compiled"
    /// <summary>
    /// Used to relate the manifestation of a musical work to a person or a group of person who compiled it.
    /// <see href="http://purl.org/ontology/mo/compiler"></see></summary>
    let compiler = _prefix "compiler"
    /// <summary>
    ///
    ///         Associates a MusicalWork to the Composition event pertaining
    ///         to its creation. For example, I might use this property to associate
    ///         the Magic Flute to its composition event, occuring during 1782 and having as
    ///         a mo:composer Mozart.
    ///
    /// <see href="http://purl.org/ontology/mo/composed_in"></see></summary>
    let composed_in = _prefix "composed_in"
    /// <summary>
    ///
    ///                 Associates a composition event to the produced MusicalWork. For example,
    ///                 this property could link the event corresponding to the composition of the
    ///                 Magic Flute in 1782 to the Magic Flute musical work itself. This musical work
    ///                 can then be used in particular performances.
    ///
    /// <see href="http://purl.org/ontology/mo/produced_work"></see></summary>
    let produced_work = _prefix "produced_work"
    /// <summary>
    ///
    ///         Associates a composition event to the actual composer. For example,
    ///         this property could link the event corresponding to the composition of the
    ///         Magic Flute in 1782 to Mozart himself (who obviously has a FOAF profile:-) ).
    ///
    /// <see href="http://purl.org/ontology/mo/composer"></see></summary>
    let composer = _prefix "composer"
    /// <summary>
    /// Relates a performance to the conductor involved
    /// <see href="http://purl.org/ontology/mo/conductor"></see></summary>
    let conductor = _prefix "conductor"
    /// <summary>
    ///
    ///         Relates a signal to another signal, which has been sampled.
    ///
    /// <see href="http://purl.org/ontology/mo/contains_sample_from"></see></summary>
    let contains_sample_from = _prefix "contains_sample_from"
    /// <summary>
    /// A related signal from which the described signal is derived.
    /// <see href="http://purl.org/ontology/mo/derived_from"></see></summary>
    let derived_from = _prefix "derived_from"
    /// <summary>
    /// Used to links an artist to an online discography of their musical works. The discography should provide a summary of each released musical work of the artist.
    /// <see href="http://purl.org/ontology/mo/discography"></see></summary>
    let discography = _prefix "discography"
    /// <summary>
    /// Used to link a musical work or the expression of a musical work, an artist or a corporate body to to its corresponding Discogs page.
    /// <see href="http://purl.org/ontology/mo/discogs"></see></summary>
    let discogs = _prefix "discogs"
    /// <summary>
    /// Indicates that all (or most of) the tracks of a musical work or the expression of a musical work were mixed together from all (or most of) the tracks from another musical work or the expression of a musical work to form a so called DJ-Mix.
    ///
    /// The tracks might have been altered by pitching (so that the tempo of one track matches the tempo of the following track) and fading (so that one track blends in smoothly with the other). If the tracks have been more substantially altered, the "mo:remix" relationship type is more appropriate.
    /// <see href="http://purl.org/ontology/mo/djmix_of"></see></summary>
    let djmix_of = _prefix "djmix_of"
    /// <summary>
    /// Used to relate an artist who djmixed a musical work or the expression of a musical work.
    ///
    /// The artist usually selected the tracks, chose their sequence, and slightly changed them by fading (so that one track blends in smoothly with the other) or pitching (so that the tempo of one track matches the tempo of the following track). This applies to a 'Mixtape' in which all tracks were DJ-mixed together into one single long track.
    /// <see href="http://purl.org/ontology/mo/djmixed"></see></summary>
    let djmixed = _prefix "djmixed"
    /// <summary>
    /// Used to relate a work or the expression of a work to an artist who djmixed it.
    ///
    /// The artist usually selected the tracks, chose their sequence, and slightly changed them by fading (so that one track blends in smoothly with the other) or pitching (so that the tempo of one track matches the tempo of the following track). This applies to a 'Mixtape' in which all tracks were DJ-mixed together into one single long track.
    /// <see href="http://purl.org/ontology/mo/djmixed_by"></see></summary>
    let djmixed_by = _prefix "djmixed_by"
    /// <summary>
    ///
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
    ///
    /// <see href="http://purl.org/ontology/mo/download"></see></summary>
    let download = _prefix "download"
    /// <summary>
    /// The duration of a track or a signal in ms
    /// <see href="http://purl.org/ontology/mo/duration"></see></summary>
    let duration = _prefix "duration"
    /// <summary>
    /// The European Article Number (EAN) is a universal identifier for products, commonly printed in form of barcodes on them. The numbers represented by those codes can either be 8 or 13 digits long, with the 13-digit-version being most common. EANs form a superset of the North American Universal Product Code (UPC) as every UPC can be made an EAN by adding a leading zero to it. Additionally every EAN is also a Japanese Article Number (JAN). The identifiers were formerly assigned by EAN International which merged with Uniform Code Council (UCC, the guys behind the UPCs) and Electronic Commerce Council of Canada (ECCC) to become GS1.
    /// <see href="http://purl.org/ontology/mo/ean"></see></summary>
    let ean = _prefix "ean"
    /// <summary>
    /// GTIN is a grouping term for EANs and UPCs. In common speech those are called barcodes although the barcodes are just a representation of those identifying numbers.
    /// <see href="http://purl.org/ontology/mo/gtin"></see></summary>
    let gtin = _prefix "gtin"
    /// <summary>
    ///
    ///         Relates a MusicalItem (a track on a particular CD, an audio file, a stream somewhere) to the signal it encodes.
    ///
    ///         This is usually a lower-resolution version of the master signal (issued from a Recording event).
    ///
    /// <see href="http://purl.org/ontology/mo/encodes"></see></summary>
    let encodes = _prefix "encodes"
    /// <summary>
    /// Method used to convert analog electronic signals into digital format such as "MP3 CBR @ 128kbps", "OGG @ 160kbps", "FLAC", etc.
    /// <see href="http://purl.org/ontology/mo/encoding"></see></summary>
    let encoding = _prefix "encoding"
    /// <summary>
    /// Relates a performance or a recording to the engineer involved
    /// <see href="http://purl.org/ontology/mo/engineer"></see></summary>
    let engineer = _prefix "engineer"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/ep"></see>
    /// </summary>
    let ep = _prefix "ep"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/eventHomePage"></see>
    /// </summary>
    let eventHomePage = _prefix "eventHomePage"
    /// <summary>
    /// Links a particular event to a web page
    /// <see href="http://purl.org/ontology/mo/event_homepage"></see></summary>
    let event_homepage = _prefix "event_homepage"
    /// <summary>
    /// A person, a group of person or an organization exchanging an exemplar of a single manifestation.
    /// <see href="http://purl.org/ontology/mo/exchange_item"></see></summary>
    let exchange_item = _prefix "exchange_item"
    /// <summary>
    /// Used to link an artist to a fan-created webpage devoted to that artist.
    /// <see href="http://purl.org/ontology/mo/fanpage"></see></summary>
    let fanpage = _prefix "fanpage"
    /// <summary>
    ///
    ///         This property can be used to link from a person to the website where they make their works available, or from
    ///         a manifestation (a track or an album, for example) to a web page where it is available for free
    ///         download.
    ///
    ///         This property MUST be used only if the content is just available through a web page (holding, for example
    ///         a Flash application) - it is better to link to actual content directly through the use of mo:available_as and
    ///         mo:Stream, mo:Torrent or mo:ED2K, etc. Therefore, Semantic Web user agents that don't know how to read HTML and even
    ///         less to rip streams from Flash applications can still access the audio content.
    ///
    /// <see href="http://purl.org/ontology/mo/free_download"></see></summary>
    let free_download = _prefix "free_download"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/freedownload"></see>
    /// </summary>
    let freedownload = _prefix "freedownload"
    /// <summary>
    ///
    ///         Associates an event (like a performance or a recording) to a particular musical genre.
    ///         Further version of this property may also include works and scores in the domain.
    ///
    /// <see href="http://purl.org/ontology/mo/genre"></see></summary>
    let genre = _prefix "genre"
    /// <summary>
    /// The Global Release Identifier (GRid) is a system for uniquely identifying Releases of music over electronic networks (that is, online stores where you can buy music as digital files). As that it can be seen as the equivalent of the BarCode (or more correctly the GTIN) as found on physical releases of music. Like the ISRC (a code for identifying single recordings as found on releases) it was developed by the IFPI but it does not appear to be a standard of the ISO.
    /// <see href="http://purl.org/ontology/mo/grid"></see></summary>
    let grid = _prefix "grid"
    /// <summary>
    /// Relates a membership event with the corresponding group
    /// <see href="http://purl.org/ontology/mo/group"></see></summary>
    let group = _prefix "group"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/has_track"></see>
    /// </summary>
    let has_track = _prefix "has_track"
    /// <summary>
    /// Indicates a part of a musical manifestation - in this particular case, a track.
    /// <see href="http://purl.org/ontology/mo/track"></see></summary>
    let track = _prefix "track"
    /// <summary>
    /// Relates a performance to the headliner(s) involved
    /// <see href="http://purl.org/ontology/mo/headliner"></see></summary>
    let headliner = _prefix "headliner"
    /// <summary>
    /// Relates a performance to the performers involved
    /// <see href="http://purl.org/ontology/mo/performer"></see></summary>
    let performer = _prefix "performer"
    /// <summary>
    /// Links an artist, a record, etc. to a corresponding web page
    /// <see href="http://purl.org/ontology/mo/homepage"></see></summary>
    let homepage = _prefix "homepage"
    /// <summary>
    /// Indicates a pictorial image (JPEG, GIF, PNG, Etc.) of a musical work, the expression of a musical work, the manifestation of a work or the examplar of a manifestation.
    /// <see href="http://purl.org/ontology/mo/image"></see></summary>
    let image = _prefix "image"
    /// <summary>
    /// Used to link an artist, a musical work or the expression of a musical work to their equivalent page on IMDb, the InternetMovieDatabase.
    /// <see href="http://purl.org/ontology/mo/imdb"></see></summary>
    let imdb = _prefix "imdb"
    /// <summary>
    /// Relates a performance to a musical instrument involved
    /// <see href="http://purl.org/ontology/mo/instrument"></see></summary>
    let instrument = _prefix "instrument"
    /// <summary>
    /// Adds an involved music artist, who interpreted, remixed, or otherwise modified an existing signal, which resulted in the signal that is here the subject of this relation.
    /// <see href="http://purl.org/ontology/mo/interpreter"></see></summary>
    let interpreter = _prefix "interpreter"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/interview"></see>
    /// </summary>
    let interview = _prefix "interview"
    /// <summary>
    /// The Interested Parties Information Code (IPI) is an ISO standard similar to ISBNs for identifying the people or groups with some involvement with a particular musical work / compositions.
    /// <see href="http://purl.org/ontology/mo/ipi"></see></summary>
    let ipi = _prefix "ipi"
    /// <summary>
    /// The International Standard Music Number (ISMN) is an ISO standard similar to ISBNs for identifying printed music publications
    /// <see href="http://purl.org/ontology/mo/ismn"></see></summary>
    let ismn = _prefix "ismn"
    /// <summary>
    ///
    ///     The ISRC (International Standard Recording Code) is the international identification system for sound recordings and music videorecordings.
    ///     Each ISRC is a unique and permanent identifier for a specific recording which can be permanently encoded into a product as its digital fingerprint.
    ///     Encoded ISRC provide the means to automatically identify recordings for royalty payments.
    ///
    /// <see href="http://purl.org/ontology/mo/isrc"></see></summary>
    let isrc = _prefix "isrc"
    /// <summary>
    /// Links a musical work to the corresponding ISWC number
    /// <see href="http://purl.org/ontology/mo/iswc"></see></summary>
    let iswc = _prefix "iswc"
    /// <summary>
    ///
    ///                 Relates a musical manifestation to a musical item (this album, and my particular cd) holding the
    ///                 entire manifestation, and not just a part of it.
    ///
    /// <see href="http://purl.org/ontology/mo/item"></see></summary>
    let item = _prefix "item"
    /// <summary>
    ///
    ///         Indicated the key used by the musicians during a performance, or the key of a MusicalWork.
    ///         Any of 24 major or minor diatonic scales that provide the tonal framework for a piece of music.
    /// <see href="http://purl.org/ontology/mo/key"></see></summary>
    let key = _prefix "key"
    /// <summary>
    /// Associates a release event with the label releasing the record
    /// <see href="http://purl.org/ontology/mo/label"></see></summary>
    let label = _prefix "label"
    /// <summary>
    /// The Label Code (LC) was introduced in 1977 by the IFPI (International Federation of Phonogram and Videogram Industries) in order to unmistakably identify the different record labels (see Introduction, Record labels) for rights purposes. The Label Code consists historically of 4 figures, presently being extended to 5 figures, preceded by LC and a dash (e.g. LC-0193 = Electrola; LC-0233 = His Master's Voice). Note that the number of countries using the LC is limited, and that the code given on the item is not always accurate.
    /// <see href="http://purl.org/ontology/mo/lc"></see></summary>
    let lc = _prefix "lc"
    /// <summary>
    /// Used to link a work or the expression of a work to the license under which they can be manipulated (downloaded, modified, etc).
    ///
    /// This is usually used to link to a Creative Commons licence.
    /// <see href="http://purl.org/ontology/mo/licence"></see></summary>
    let licence = _prefix "licence"
    /// <summary>
    /// Relates a performance to the listener involved
    /// <see href="http://purl.org/ontology/mo/listener"></see></summary>
    let listener = _prefix "listener"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/live"></see>
    /// </summary>
    let live = _prefix "live"
    /// <summary>
    /// Associates lyrics with a musical work
    /// <see href="http://purl.org/ontology/mo/lyrics"></see></summary>
    let lyrics = _prefix "lyrics"
    /// <summary>
    /// Used to link a musical work or the expression of a musical work to a website where people can buy a copy of the musical manifestation.
    /// <see href="http://purl.org/ontology/mo/mailorder"></see></summary>
    let mailorder = _prefix "mailorder"
    /// <summary>
    /// Indicates that musical works or the expressions of a musical work were mashed up on this album or track.
    ///
    /// This means that two musical works or the expressions of a musical work by different artists are mixed together, over each other, or otherwise combined into a single musical work (usually by a third artist, the remixer).
    /// <see href="http://purl.org/ontology/mo/mashup_of"></see></summary>
    let mashup_of = _prefix "mashup_of"
    /// <summary>
    /// The mediatype (file format or MIME type, or physical medium) of a musical manifestation, e.g. a MP3, CD or vinyl.
    /// <see href="http://purl.org/ontology/mo/media_type"></see></summary>
    let media_type = _prefix "media_type"
    /// <summary>
    /// Indicates that a musical expression is a medley of several other musical expressions.
    ///
    /// This means that the orignial musical expression were rearranged to create a new musical expression in the form of a medley.
    /// <see href="http://purl.org/ontology/mo/medley_of"></see></summary>
    let medley_of = _prefix "medley_of"
    /// <summary>
    ///
    ///         Indicates a member of a musical group
    ///
    /// <see href="http://purl.org/ontology/mo/member"></see></summary>
    let member_ = _prefix "member"
    /// <summary>
    /// Inverse of the foaf:member property
    /// <see href="http://purl.org/ontology/mo/member_of"></see></summary>
    let member_of = _prefix "member_of"
    /// <summary>
    /// Relates an agent with related membership events
    /// <see href="http://purl.org/ontology/mo/membership"></see></summary>
    let membership = _prefix "membership"
    /// <summary>
    /// Associates a musical work or a score with its meter
    /// <see href="http://purl.org/ontology/mo/meter"></see></summary>
    let meter = _prefix "meter"
    /// <summary>
    /// Indicates that a musical work has movements
    /// <see href="http://purl.org/ontology/mo/movement"></see></summary>
    let movement = _prefix "movement"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/movementNum"></see>
    /// </summary>
    let movementNum = _prefix "movementNum"
    /// <summary>
    /// Indicates the position of a movement in a musical work.
    /// <see href="http://purl.org/ontology/mo/movement_number"></see></summary>
    let movement_number = _prefix "movement_number"
    /// <summary>
    ///
    ///         Linking an agent, a track or a record to its corresponding Musicbrainz page.
    ///
    /// <see href="http://purl.org/ontology/mo/musicbrainz"></see></summary>
    let musicbrainz = _prefix "musicbrainz"
    /// <summary>
    /// Links an object to the corresponding Musicbrainz identifier
    /// <see href="http://purl.org/ontology/mo/musicbrainz_guid"></see></summary>
    let musicbrainz_guid = _prefix "musicbrainz_guid"
    /// <summary>
    /// Used to link an artist, a musical work or the expression of a musical work to its corresponding MusicMoz page.
    /// <see href="http://purl.org/ontology/mo/musicmoz"></see></summary>
    let musicmoz = _prefix "musicmoz"
    /// <summary>
    /// Used to link a person to its corresponding MySpace page.
    /// <see href="http://purl.org/ontology/mo/myspace"></see></summary>
    let myspace = _prefix "myspace"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/official"></see>
    /// </summary>
    let official = _prefix "official"
    /// <summary>
    /// Used to link a track to a tabulature file for track in the On-Line Guitar Archive.
    /// <see href="http://purl.org/ontology/mo/olga"></see></summary>
    let olga = _prefix "olga"
    /// <summary>
    /// Used to link a person with an online community web page like a blog, a wiki, a forum, a livejournal page, Etc.
    /// <see href="http://purl.org/ontology/mo/onlinecommunity"></see></summary>
    let onlinecommunity = _prefix "onlinecommunity"
    /// <summary>
    ///
    ///         Used to define a creative work, especially a musical composition numbered to designate the order of a composer's works.
    ///
    /// <see href="http://purl.org/ontology/mo/opus"></see></summary>
    let opus = _prefix "opus"
    /// <summary>
    /// Relates an artist to its geographic origin
    /// <see href="http://purl.org/ontology/mo/origin"></see></summary>
    let origin = _prefix "origin"
    /// <summary>
    /// Indicates that two musical manifestations are essentially the same.
    /// <see href="http://purl.org/ontology/mo/other_release_of"></see></summary>
    let other_release_of = _prefix "other_release_of"
    /// <summary>
    ///
    ///                 Provide a link from an artist to a web page where all of that artist's musical work is available for some money,
    ///                 or a link from a manifestation (record/track, for example) to a web page providing a paid access to this manifestation.
    ///
    /// <see href="http://purl.org/ontology/mo/paid_download"></see></summary>
    let paid_download = _prefix "paid_download"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/paiddownload"></see>
    /// </summary>
    let paiddownload = _prefix "paiddownload"
    /// <summary>
    ///
    ///         Associates a Performance to a musical work or an arrangement that is being used as a factor in it.
    ///         For example, I might use this property to attach the Magic Flute musical work to
    ///         a particular Performance.
    ///
    /// <see href="http://purl.org/ontology/mo/performance_of"></see></summary>
    let performance_of = _prefix "performance_of"
    /// <summary>
    ///
    ///         Associates a Musical Work or an Score to Performances in which they were
    ///         a factor. For example, I might use this property in order to
    ///         associate the Magic Flute to a particular performance at the Opera
    ///         Bastille last year.
    /// <see href="http://purl.org/ontology/mo/performed_in"></see></summary>
    let performed_in = _prefix "performed_in"
    /// <summary>
    /// A person, a group of person or an organization possessing an exemplar of a single manifestation.
    /// <see href="http://purl.org/ontology/mo/possess_item"></see></summary>
    let possess_item = _prefix "possess_item"
    /// <summary>
    ///
    ///                 Relates a musical manifestation to a musical item (this album, and my particular cd), which holds
    ///                 a preview of the manifestation (eg. one track for an album, or a snippet for a track)
    ///
    /// <see href="http://purl.org/ontology/mo/preview"></see></summary>
    let preview = _prefix "preview"
    /// <summary>
    ///
    ///                 This property can be used to link from a person to the website where they make previews of their works available, or from
    ///                 a manifestation (a track or an album, for example) to a web page where a preview download is available.
    ///
    ///                 This property MUST be used only if the content is just available through a web page (holding, for example
    ///                 a Flash application) - it is better to link to actual content directly through the use of mo:available_as and
    ///                 mo:Stream, mo:Torrent or mo:ED2K, etc. Therefore, Semantic Web user agents that don't know how to read HTML and even
    ///                 less to rip streams from Flash applications can still access the audio content.
    ///
    /// <see href="http://purl.org/ontology/mo/preview_download"></see></summary>
    let preview_download = _prefix "preview_download"
    /// <summary>
    /// Indicates that an artist primarily plays an instrument, or that a member was primarily playing a particular instrument during his membership
    /// <see href="http://purl.org/ontology/mo/primary_instrument"></see></summary>
    let primary_instrument = _prefix "primary_instrument"
    /// <summary>
    /// Used to relate an person or a group of person who produced the manifestation of a work.
    /// <see href="http://purl.org/ontology/mo/produced"></see></summary>
    let produced = _prefix "produced"
    /// <summary>
    /// Used to relate the manifestation of a work to a person or a group of person who produced it.
    /// <see href="http://purl.org/ontology/mo/producer"></see></summary>
    let producer = _prefix "producer"
    /// <summary>
    ///
    ///         Associates an arrangement or a composition event to a score product (score here does not refer to a published score, but more
    ///         an abstract arrangement of a particular work).
    ///
    /// <see href="http://purl.org/ontology/mo/produced_score"></see></summary>
    let produced_score = _prefix "produced_score"
    /// <summary>
    ///
    ///                 Associates a Recording to the outputted signal.
    ///
    /// <see href="http://purl.org/ontology/mo/produced_signal"></see></summary>
    let produced_signal = _prefix "produced_signal"
    /// <summary>
    /// Associates a recording session with a group of master signals produced by it.
    /// <see href="http://purl.org/ontology/mo/produced_signal_group"></see></summary>
    let produced_signal_group = _prefix "produced_signal_group"
    /// <summary>
    ///
    ///                 Associates a Performance to a physical Sound that is being produced by it.
    ///
    /// <see href="http://purl.org/ontology/mo/produced_sound"></see></summary>
    let produced_sound = _prefix "produced_sound"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/producesSignal"></see>
    /// </summary>
    let producesSignal = _prefix "producesSignal"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/producesSound"></see>
    /// </summary>
    let producesSound = _prefix "producesSound"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/producesWork"></see>
    /// </summary>
    let producesWork = _prefix "producesWork"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/productOfComposition"></see>
    /// </summary>
    let productOfComposition = _prefix "productOfComposition"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/promotion"></see>
    /// </summary>
    let promotion = _prefix "promotion"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/publicationOf"></see>
    /// </summary>
    let publicationOf = _prefix "publicationOf"
    /// <summary>
    /// Link a particular manifestation to the related signal, score, libretto, or lyrics
    /// <see href="http://purl.org/ontology/mo/publication_of"></see></summary>
    let publication_of = _prefix "publication_of"
    /// <summary>
    ///
    ///         Links a musical expression (e.g. a signal or a score) to one of its manifestations (e.g. a track on a particular record or a published score).
    ///
    /// <see href="http://purl.org/ontology/mo/published_as"></see></summary>
    let published_as = _prefix "published_as"
    /// <summary>
    /// Used to relate an person or a group of person who published the manifestation of a work.
    /// <see href="http://purl.org/ontology/mo/published"></see></summary>
    let published = _prefix "published"
    /// <summary>
    /// Used to relate a musical manifestation to a person or a group of person who published it.
    /// <see href="http://purl.org/ontology/mo/publisher"></see></summary>
    let publisher = _prefix "publisher"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/publishedAs"></see>
    /// </summary>
    let publishedAs = _prefix "publishedAs"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/publishingLocation"></see>
    /// </summary>
    let publishingLocation = _prefix "publishingLocation"
    /// <summary>
    ///
    ///         Relates a musical manifestation to its publication location.
    ///
    /// <see href="http://purl.org/ontology/mo/publishing_location"></see></summary>
    let publishing_location = _prefix "publishing_location"
    /// <summary>
    ///
    ///         Link a signal to the PUIDs associated with it, that is, PUID computed from MusicalItems (mo:AudioFile)
    ///         derived from this signal.
    ///         PUIDs (Portable Unique IDentifier) are the IDs used in the
    ///         proprietary MusicDNS AudioFingerprinting system which is operated by MusicIP.
    ///
    ///         Using PUIDs, one (with some luck) can identify the Signal object associated with a particular audio file, therefore allowing
    ///         to access further information (on which release this track is featured? etc.). Using some more metadata one can identify
    ///         the particular Track corresponding to the audio file (a track on a particular release).
    /// <see href="http://purl.org/ontology/mo/puid"></see></summary>
    let puid = _prefix "puid"
    /// <summary>
    /// Associates a release with the records it contains. A single release can be associated with multiple records, for example for a multi-disc release.
    /// <see href="http://purl.org/ontology/mo/record"></see></summary>
    let record = _prefix "record"
    /// <summary>
    /// Associates a release with the number of records it contains, e.g. the number of discs it contains in the case of a multi-disc release.
    /// <see href="http://purl.org/ontology/mo/record_count"></see></summary>
    let record_count = _prefix "record_count"
    /// <summary>
    /// Indicates the position of a record in a release (e.g. a 2xLP, etc.).
    /// <see href="http://purl.org/ontology/mo/record_number"></see></summary>
    let record_number = _prefix "record_number"
    /// <summary>
    /// Associates the side on a vinyl record, where a track is located, e.g. A, B, C, etc. This property can then also be used
    /// in conjunction with mo:track_number, so that one can infer e.g. "A1", that means, track number 1 on side A.
    /// <see href="http://purl.org/ontology/mo/record_side"></see></summary>
    let record_side = _prefix "record_side"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/recordedAs"></see>
    /// </summary>
    let recordedAs = _prefix "recordedAs"
    /// <summary>
    ///
    ///         This is a shortcut property, allowing to bypass all the Sound/Recording steps. This property
    ///         allows to directly link a Performance to the recorded Signal. This is recommended for "normal"
    ///         users. However, advanced users wanting to express things such as the location of the microphone will
    ///         have to create this shortcut as well as the whole workflow, in order to let the "normal" users access
    ///         simply the, well, simple information:-) .
    ///
    /// <see href="http://purl.org/ontology/mo/recorded_as"></see></summary>
    let recorded_as = _prefix "recorded_as"
    /// <summary>
    ///
    ///         This is the inverse of the shortcut property recordedAs, allowing to relate directly a performance
    ///         to a signal.
    ///
    /// <see href="http://purl.org/ontology/mo/records"></see></summary>
    let records = _prefix "records"
    /// <summary>
    ///
    ///             Associates a physical Sound to a Recording event where it is being used
    ///         in order to produce a signal. For example, I might use this property to
    ///         associate the sound produced by a particular performance of the magic flute
    ///         to a given recording, done using my cell-phone.
    ///
    /// <see href="http://purl.org/ontology/mo/recorded_in"></see></summary>
    let recorded_in = _prefix "recorded_in"
    /// <summary>
    ///
    ///             Associates a Recording event to a physical Sound being recorded.
    ///                 For example, I might use this property to
    ///                 associate a given recording, done using my cell phone, to the
    ///         sound produced by a particular performance of the magic flute.
    ///
    /// <see href="http://purl.org/ontology/mo/recording_of"></see></summary>
    let recording_of = _prefix "recording_of"
    /// <summary>
    /// Associates a release with the corresponding release event
    /// <see href="http://purl.org/ontology/mo/release"></see></summary>
    let release = _prefix "release"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/releaseStatus"></see>
    /// </summary>
    let releaseStatus = _prefix "releaseStatus"
    /// <summary>
    ///
    ///                 Relates a musical manifestation to its release status (bootleg, ...)
    ///
    /// <see href="http://purl.org/ontology/mo/release_status"></see></summary>
    let release_status = _prefix "release_status"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/releaseType"></see>
    /// </summary>
    let releaseType = _prefix "releaseType"
    /// <summary>
    ///
    ///         Relates a musical manifestation to its release type (interview, spoken word, album, ...)
    ///
    /// <see href="http://purl.org/ontology/mo/release_type"></see></summary>
    let release_type = _prefix "release_type"
    /// <summary>
    /// This relates two musical work or the expression of a musical work, where one is a remaster of the other.
    ///
    /// A remaster is a new version made for release from source recordings that were earlier released separately. This is usually done to improve the audio quality or adjust for more modern playback equipment. The process generally doesn't involve changing the music in any artistically important way. It may, however, result in tracks that are a few seconds longer or shorter.
    /// <see href="http://purl.org/ontology/mo/remaster_of"></see></summary>
    let remaster_of = _prefix "remaster_of"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/remix"></see>
    /// </summary>
    let remix = _prefix "remix"
    /// <summary>
    /// Used to relate the remix of a musical work in a substantially altered version produced by mixing together individual tracks or segments of an original musical source work.
    /// <see href="http://purl.org/ontology/mo/remix_of"></see></summary>
    let remix_of = _prefix "remix_of"
    /// <summary>
    /// Used to relate an artist who remixed a musical work or the expression of a musical work.
    ///
    /// This involves taking just one other musical work and using audio editing to make it sound like a significantly different, but usually still recognisable, song. It can be used to link an artist to a single song that they remixed, or, if they remixed an entire musical work.
    /// <see href="http://purl.org/ontology/mo/remixed"></see></summary>
    let remixed = _prefix "remixed"
    /// <summary>
    /// Used to relate a musical work or the expression of a musical work to an artist who remixed it.
    ///
    /// This involves taking just one other musical work and using audio editing to make it sound like a significantly different, but usually still recognisable, song. It can be used to link an artist to a single song that they remixed, or, if they remixed an entire musical work.
    /// <see href="http://purl.org/ontology/mo/remixer"></see></summary>
    let remixer = _prefix "remixer"
    /// <summary>
    /// Used to link a work or the expression of a work to a review.
    ///
    /// The review does not have to be open content, as long as it is accessible to the general internet population.
    /// <see href="http://purl.org/ontology/mo/review"></see></summary>
    let review = _prefix "review"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/sampleRate"></see>
    /// </summary>
    let sampleRate = _prefix "sampleRate"
    /// <summary>
    ///
    ///         Associates a digital signal to its sample rate. It might be easier to express it this way instead of
    ///         defining a timeline map:-) Range is xsd:float.
    ///
    /// <see href="http://purl.org/ontology/mo/sample_rate"></see></summary>
    let sample_rate = _prefix "sample_rate"
    /// <summary>
    /// Used to relate an artist who sampled a Signal.
    /// <see href="http://purl.org/ontology/mo/sampled"></see></summary>
    let sampled = _prefix "sampled"
    /// <summary>
    /// Used to relate the signal of a musical work to an artist who sampled it.
    /// <see href="http://purl.org/ontology/mo/sampler"></see></summary>
    let sampler = _prefix "sampler"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/sampledVersionOf"></see>
    /// </summary>
    let sampledVersionOf = _prefix "sampledVersionOf"
    /// <summary>
    ///
    ///         Associates a digital signal with the analog version of it
    ///
    /// <see href="http://purl.org/ontology/mo/sampled_version_of"></see></summary>
    let sampled_version_of = _prefix "sampled_version_of"
    /// <summary>
    ///
    ///         Associates an analog signal with a sampled version of it
    ///
    /// <see href="http://purl.org/ontology/mo/sampled_version"></see></summary>
    let sampled_version = _prefix "sampled_version"
    /// <summary>
    /// A person, a group of person or an organization selling an exemplar of a single manifestation.
    /// <see href="http://purl.org/ontology/mo/sell_item"></see></summary>
    let sell_item = _prefix "sell_item"
    /// <summary>
    /// Associates a group of signals with one of the signals it contains
    /// <see href="http://purl.org/ontology/mo/signal"></see></summary>
    let signal = _prefix "signal"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/signalTime"></see>
    /// </summary>
    let signalTime = _prefix "signalTime"
    /// <summary>
    ///
    ///         Associates a Signal to a time object - its actual domain
    ///
    /// <see href="http://purl.org/ontology/mo/time"></see></summary>
    let time = _prefix "time"
    /// <summary>
    ///
    ///             A similarity relationships between two objects (so far, either an agent, a signal or a genre, but
    ///         this could grow).
    ///         This relationship is pretty general and doesn't make any assumptions on how the similarity claim
    ///         was derived.
    ///         Such similarity statements can come from a range of different sources (Musicbrainz similarities between
    ///         artists, or coming from some automatic content analysis).
    ///         However, the origin of such statements should be kept using a named graph approach - and ultimately, the
    ///         documents providing such statements should attach some metadata to themselves (confidence of the claim, etc.).
    ///
    /// <see href="http://purl.org/ontology/mo/similar_to"></see></summary>
    let similar_to = _prefix "similar_to"
    /// <summary>
    /// Relates a performance to an involved singer
    /// <see href="http://purl.org/ontology/mo/singer"></see></summary>
    let singer = _prefix "singer"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/single"></see>
    /// </summary>
    let single = _prefix "single"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/soundtrack"></see>
    /// </summary>
    let soundtrack = _prefix "soundtrack"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/spokenword"></see>
    /// </summary>
    let spokenword = _prefix "spokenword"
    /// <summary>
    /// Used to relate an artist doing long-time instrumental or vocal support for another artist.
    /// <see href="http://purl.org/ontology/mo/supporting_musician"></see></summary>
    let supporting_musician = _prefix "supporting_musician"
    /// <summary>
    ///
    ///         Rate of speed or pace of music. Tempo markings are traditionally given in Italian;
    ///         common markings include: grave (solemn; very, very slow); largo (broad; very slow);
    ///         adagio (quite slow); andante (a walking pace); moderato (moderate); allegro (fast; cheerful);
    ///         vivace (lively); presto (very fast); accelerando (getting faster); ritardando (getting slower);
    ///         and a tempo (in time; returning to the original pace).
    ///
    /// <see href="http://purl.org/ontology/mo/tempo"></see></summary>
    let tempo = _prefix "tempo"
    /// <summary>
    /// Associates lyrics with their text.
    /// <see href="http://purl.org/ontology/mo/text"></see></summary>
    let text = _prefix "text"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/trackNum"></see>
    /// </summary>
    let trackNum = _prefix "trackNum"
    /// <summary>
    /// Indicates the position of a track on a record medium (a CD, etc.).
    /// <see href="http://purl.org/ontology/mo/track_number"></see></summary>
    let track_number = _prefix "track_number"
    /// <summary>
    /// The track count of a record
    /// <see href="http://purl.org/ontology/mo/track_count"></see></summary>
    let track_count = _prefix "track_count"
    /// <summary>
    /// Indicates that a work or the expression of a work has translated or transliterated into another expression of a work.
    /// <see href="http://purl.org/ontology/mo/translation_of"></see></summary>
    let translation_of = _prefix "translation_of"
    /// <summary>
    /// Indicates a musical work or the expression of a musical work that is a tribute to an artist - normally consisting of music being composed by the artist but performed by other artists.
    /// <see href="http://purl.org/ontology/mo/tribute_to"></see></summary>
    let tribute_to = _prefix "tribute_to"
    /// <summary>
    ///
    ///         Indicates the TRMID of a track.
    ///         TRM IDs are MusicBrainz' old AudioFingerprinting system.
    ///         TRM (TRM Recognizes Music) IDs are (somewhat) unique ids that represent
    ///         the audio signature of a musical piece (see AudioFingerprint).
    ///
    /// <see href="http://purl.org/ontology/mo/trmid"></see></summary>
    let trmid = _prefix "trmid"
    /// <summary>
    /// UPC stands for "Universal Product Code", which was the original barcode used in the United States and Canada. The UPC (now officially EAN.UCC-12 is a numerical method of identifying products without redundancy worldwide for all types of products in the retail sector. The EAN is a superset of the original UPC increasing the digits to 13 with the prefix 0 reserved for UPC. As of 2005, manufacturers are only allowed to use the new 13-digit codes on their items, rather than having two separate numbers.
    /// <see href="http://purl.org/ontology/mo/upc"></see></summary>
    let upc = _prefix "upc"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/usedInPerformance"></see>
    /// </summary>
    let usedInPerformance = _prefix "usedInPerformance"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/usedInRecording"></see>
    /// </summary>
    let usedInRecording = _prefix "usedInRecording"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/usesSound"></see>
    /// </summary>
    let usesSound = _prefix "usesSound"
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/usesWork"></see>
    /// </summary>
    let usesWork = _prefix "usesWork"
    /// <summary>
    /// A person, a group of person or an organization wanting an exemplar of a single manifestation.
    /// <see href="http://purl.org/ontology/mo/want_item"></see></summary>
    let want_item = _prefix "want_item"
    /// <summary>
    ///
    ///         Used to link an work, an expression of a work, a manifestation of a work,
    ///         a person, an instrument or a musical genre to its corresponding WikiPedia page.
    ///         The full URL should be used, not just the WikiName.
    ///
    /// <see href="http://purl.org/ontology/mo/wikipedia"></see></summary>
    let wikipedia = _prefix "wikipedia"
