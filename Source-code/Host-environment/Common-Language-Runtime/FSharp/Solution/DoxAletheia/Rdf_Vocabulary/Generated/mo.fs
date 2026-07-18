namespace http.purl.org.ontology.mo.slash

open DoxAletheia.Rdf_Vocabulary

module mo =
    let _namespace_name = "http://purl.org/ontology/mo/"
    /// <summary>
    ///
    ///         An activity period, defining when an artist was musically active.
    ///
    /// <see href="http://purl.org/ontology/mo/Activity"></see></summary>
    let Activity = Namespaced_IRI.parse _namespace_name "Activity" |> NamespacedName
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
    let level = Namespaced_IRI.parse _namespace_name "level" |> NamespacedName

    /// <summary>
    ///
    ///         An analog signal.
    ///
    /// <see href="http://purl.org/ontology/mo/AnalogSignal"></see></summary>
    let AnalogSignal =
        Namespaced_IRI.parse _namespace_name "AnalogSignal" |> NamespacedName

    /// <summary>
    ///
    ///         A subclass of MusicalExpression, representing a signal, for example a master signal produced by a performance and a recording.
    ///
    /// <see href="http://purl.org/ontology/mo/Signal"></see></summary>
    let Signal = Namespaced_IRI.parse _namespace_name "Signal" |> NamespacedName

    /// <summary>
    ///
    ///         A digital signal
    ///
    /// <see href="http://purl.org/ontology/mo/DigitalSignal"></see></summary>
    let DigitalSignal =
        Namespaced_IRI.parse _namespace_name "DigitalSignal" |> NamespacedName

    /// <summary>
    ///
    ///         An arrangement event.
    ///         Takes as agent the arranger, and produces a score (informational object, not the actually published score).
    ///
    /// <see href="http://purl.org/ontology/mo/Arrangement"></see></summary>
    let Arrangement =
        Namespaced_IRI.parse _namespace_name "Arrangement" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/Arranger"></see>
    /// </summary>
    let Arranger = Namespaced_IRI.parse _namespace_name "Arranger" |> NamespacedName
    /// <summary>
    /// An audio file, which may be available on a local file system or through http, ftp, etc.
    /// <see href="http://purl.org/ontology/mo/AudioFile"></see></summary>
    let AudioFile = Namespaced_IRI.parse _namespace_name "AudioFile" |> NamespacedName
    /// <summary>
    /// A means or instrumentality for storing or communicating musical manifestation.
    /// <see href="http://purl.org/ontology/mo/Medium"></see></summary>
    let Medium = Namespaced_IRI.parse _namespace_name "Medium" |> NamespacedName
    /// <summary>
    /// Compact Disc used as medium to record a musical manifestation.
    /// <see href="http://purl.org/ontology/mo/CD"></see></summary>
    let CD = Namespaced_IRI.parse _namespace_name "CD" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/Composer"></see>
    /// </summary>
    let Composer = Namespaced_IRI.parse _namespace_name "Composer" |> NamespacedName

    /// <summary>
    ///
    ///         A composition event.
    ///         Takes as agent the composer himself.
    ///         It produces a MusicalWork, or a MusicalExpression (when the initial "product" is a score, for example), or both...
    ///
    /// <see href="http://purl.org/ontology/mo/Composition"></see></summary>
    let Composition =
        Namespaced_IRI.parse _namespace_name "Composition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/Conductor"></see>
    /// </summary>
    let Conductor = Namespaced_IRI.parse _namespace_name "Conductor" |> NamespacedName

    /// <summary>
    ///
    ///         A performance event.
    ///         It might include as agents performers, engineers, conductors, or even listeners.
    ///         It might include as factors a score, a MusicalWork, musical instruments.
    ///         It might produce a sound:-)
    ///
    /// <see href="http://purl.org/ontology/mo/Performance"></see></summary>
    let Performance =
        Namespaced_IRI.parse _namespace_name "Performance" |> NamespacedName

    /// <summary>
    /// Relates agents to the performances they were conducting
    /// <see href="http://purl.org/ontology/mo/conducted"></see></summary>
    let conducted = Namespaced_IRI.parse _namespace_name "conducted" |> NamespacedName

    /// <summary>
    /// Organization or group of individuals and/or other organizations involved in the music market.
    /// <see href="http://purl.org/ontology/mo/CorporateBody"></see></summary>
    let CorporateBody =
        Namespaced_IRI.parse _namespace_name "CorporateBody" |> NamespacedName

    /// <summary>
    /// Digital Audio Tape used as medium to record a musical manifestation.
    /// <see href="http://purl.org/ontology/mo/DAT"></see></summary>
    let DAT = Namespaced_IRI.parse _namespace_name "DAT" |> NamespacedName
    /// <summary>
    /// Digital Compact Cassette used as medium to record a musical manifestation.
    /// <see href="http://purl.org/ontology/mo/DCC"></see></summary>
    let DCC = Namespaced_IRI.parse _namespace_name "DCC" |> NamespacedName
    /// <summary>
    /// DVD-Audio used as medium to record a musical manifestation.
    /// <see href="http://purl.org/ontology/mo/DVDA"></see></summary>
    let DVDA = Namespaced_IRI.parse _namespace_name "DVDA" |> NamespacedName
    /// <summary>
    /// Something available on the E-Donkey peer-2-peer filesharing network
    /// <see href="http://purl.org/ontology/mo/ED2K"></see></summary>
    let ED2K = Namespaced_IRI.parse _namespace_name "ED2K" |> NamespacedName
    /// <summary>
    ///
    ///         A festival - musical/artistic event lasting several days, like Glastonbury, Rock Am Ring...
    ///         We migth decompose this event (which is in fact just a classification of the space/time region related to
    ///         a particular festival) using hasSubEvent in several performances at different space/time.
    ///
    /// <see href="http://purl.org/ontology/mo/Festival"></see></summary>
    let Festival = Namespaced_IRI.parse _namespace_name "Festival" |> NamespacedName
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
    let Genre = Namespaced_IRI.parse _namespace_name "Genre" |> NamespacedName
    /// <summary>
    ///
    ///         Any of various devices or contrivances that can be used to produce musical tones or sound.
    ///
    ///         Any taxonomy can be used to subsume this concept. The default one is one extracted by Ivan Herman
    ///         from the Musicbrainz instrument taxonomy, conforming to SKOS. This concept holds a seeAlso link
    ///         towards this taxonomy.
    ///
    /// <see href="http://purl.org/ontology/mo/Instrument"></see></summary>
    let Instrument = Namespaced_IRI.parse _namespace_name "Instrument" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/mit#"></see>
    /// </summary>
    let ``mit#`` = Namespaced_IRI.parse _namespace_name "mit#" |> NamespacedName

    /// <summary>
    ///
    ///         Instrumentation deals with the techniques of writing music for a specific instrument,
    ///         including the limitations of the instrument, playing techniques and idiomatic handling of the instrument.
    ///
    /// <see href="http://purl.org/ontology/mo/Instrumentation"></see></summary>
    let Instrumentation =
        Namespaced_IRI.parse _namespace_name "Instrumentation" |> NamespacedName

    /// <summary>
    /// Trade name of a company that produces musical works or expression of musical works.
    /// <see href="http://purl.org/ontology/mo/Label"></see></summary>
    let Label = Namespaced_IRI.parse _namespace_name "Label" |> NamespacedName
    /// <summary>
    ///
    ///                 Libretto
    ///
    /// <see href="http://purl.org/ontology/mo/Libretto"></see></summary>
    let Libretto = Namespaced_IRI.parse _namespace_name "Libretto" |> NamespacedName

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
    let MusicalExpression =
        Namespaced_IRI.parse _namespace_name "MusicalExpression" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/Listener"></see>
    /// </summary>
    let Listener = Namespaced_IRI.parse _namespace_name "Listener" |> NamespacedName
    /// <summary>
    /// Relates agents to the performances they were listening in
    /// <see href="http://purl.org/ontology/mo/listened"></see></summary>
    let listened = Namespaced_IRI.parse _namespace_name "listened" |> NamespacedName
    /// <summary>
    ///
    ///         Lyrics
    ///
    /// <see href="http://purl.org/ontology/mo/Lyrics"></see></summary>
    let Lyrics = Namespaced_IRI.parse _namespace_name "Lyrics" |> NamespacedName
    /// <summary>
    /// Mini Disc used as medium to record a musical manifestation.
    /// <see href="http://purl.org/ontology/mo/MD"></see></summary>
    let MD = Namespaced_IRI.parse _namespace_name "MD" |> NamespacedName

    /// <summary>
    /// Magnetic analogue tape used as medium to record a musical manifestation.
    /// <see href="http://purl.org/ontology/mo/MagneticTape"></see></summary>
    let MagneticTape =
        Namespaced_IRI.parse _namespace_name "MagneticTape" |> NamespacedName

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
    let MusicalItem =
        Namespaced_IRI.parse _namespace_name "MusicalItem" |> NamespacedName

    /// <summary>
    /// A membership event, where one or several people belongs to a group during a particular time period.
    /// <see href="http://purl.org/ontology/mo/Membership"></see></summary>
    let Membership = Namespaced_IRI.parse _namespace_name "Membership" |> NamespacedName
    /// <summary>
    /// A movement is a self-contained part of a musical work. While individual or selected movements from a composition are sometimes performed separately, a performance of the complete work requires all the movements to be performed in succession.
    ///
    /// Often a composer attempts to interrelate the movements thematically, or sometimes in more subtle ways, in order that the individual
    /// movements exert a cumulative effect. In some forms, composers sometimes link the movements, or ask for them to be played without a
    /// pause between them.
    ///
    /// <see href="http://purl.org/ontology/mo/Movement"></see></summary>
    let Movement = Namespaced_IRI.parse _namespace_name "Movement" |> NamespacedName

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
    let MusicalWork =
        Namespaced_IRI.parse _namespace_name "MusicalWork" |> NamespacedName

    /// <summary>
    ///
    ///         A person or a group of people (or a computer :-) ), whose musical
    ///         creative work shows sensitivity and imagination
    ///
    /// <see href="http://purl.org/ontology/mo/MusicArtist"></see></summary>
    let MusicArtist =
        Namespaced_IRI.parse _namespace_name "MusicArtist" |> NamespacedName

    /// <summary>
    /// Group of musicians, or musical ensemble, usually popular or folk, playing parts of or improvising off of a musical arrangement.
    /// <see href="http://purl.org/ontology/mo/MusicGroup"></see></summary>
    let MusicGroup = Namespaced_IRI.parse _namespace_name "MusicGroup" |> NamespacedName

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
    let MusicalManifestation =
        Namespaced_IRI.parse _namespace_name "MusicalManifestation" |> NamespacedName

    /// <summary>
    ///
    ///             Orchestration includes, in addition to instrumentation, the handling of groups of instruments and their balance and interaction.
    ///
    /// <see href="http://purl.org/ontology/mo/Orchestration"></see></summary>
    let Orchestration =
        Namespaced_IRI.parse _namespace_name "Orchestration" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/Performer"></see>
    /// </summary>
    let Performer = Namespaced_IRI.parse _namespace_name "Performer" |> NamespacedName
    /// <summary>
    /// Relates agents to the performances they were performing in
    /// <see href="http://purl.org/ontology/mo/performed"></see></summary>
    let performed = Namespaced_IRI.parse _namespace_name "performed" |> NamespacedName

    /// <summary>
    /// A published libretto
    /// <see href="http://purl.org/ontology/mo/PublishedLibretto"></see></summary>
    let PublishedLibretto =
        Namespaced_IRI.parse _namespace_name "PublishedLibretto" |> NamespacedName

    /// <summary>
    /// Published lyrics, as a book or as a text file, for example
    /// <see href="http://purl.org/ontology/mo/PublishedLyrics"></see></summary>
    let PublishedLyrics =
        Namespaced_IRI.parse _namespace_name "PublishedLyrics" |> NamespacedName

    /// <summary>
    /// A published score (subclass of MusicalManifestation)
    /// <see href="http://purl.org/ontology/mo/PublishedScore"></see></summary>
    let PublishedScore =
        Namespaced_IRI.parse _namespace_name "PublishedScore" |> NamespacedName

    /// <summary>
    /// A published record (manifestation which first aim is to render the product of a recording)
    /// <see href="http://purl.org/ontology/mo/Record"></see></summary>
    let Record = Namespaced_IRI.parse _namespace_name "Record" |> NamespacedName
    /// <summary>
    ///
    ///         A recording event.
    ///         Takes a sound as a factor to produce a signal (analog or digital).
    ///         The location of such events (if any) is the actual location of the corresponding
    ///         microphone or the "recording device".
    ///
    /// <see href="http://purl.org/ontology/mo/Recording"></see></summary>
    let Recording = Namespaced_IRI.parse _namespace_name "Recording" |> NamespacedName

    /// <summary>
    /// A set of performances/recordings/mastering events. This event can be decomposed in its constituent events using event:sub_event
    /// <see href="http://purl.org/ontology/mo/RecordingSession"></see></summary>
    let RecordingSession =
        Namespaced_IRI.parse _namespace_name "RecordingSession" |> NamespacedName

    /// <summary>
    /// A specific release, with barcode, box, liner notes, cover art, and a number of records
    /// <see href="http://purl.org/ontology/mo/Release"></see></summary>
    let Release = Namespaced_IRI.parse _namespace_name "Release" |> NamespacedName

    /// <summary>
    /// A release event, in a particular place (e.g. a country) at a particular time. Other factors of this event might include cover art, liner notes, box, etc. or a release grouping all these.
    /// <see href="http://purl.org/ontology/mo/ReleaseEvent"></see></summary>
    let ReleaseEvent =
        Namespaced_IRI.parse _namespace_name "ReleaseEvent" |> NamespacedName

    /// <summary>
    /// Musical manifestation release status.
    /// <see href="http://purl.org/ontology/mo/ReleaseStatus"></see></summary>
    let ReleaseStatus =
        Namespaced_IRI.parse _namespace_name "ReleaseStatus" |> NamespacedName

    /// <summary>
    ///
    ///         Release type of a particular manifestation, such as "album" or "interview"...
    ///
    /// <see href="http://purl.org/ontology/mo/ReleaseType"></see></summary>
    let ReleaseType =
        Namespaced_IRI.parse _namespace_name "ReleaseType" |> NamespacedName

    /// <summary>
    /// Super Audio Compact Disc used as medium to record a musical manifestation.
    /// <see href="http://purl.org/ontology/mo/SACD"></see></summary>
    let SACD = Namespaced_IRI.parse _namespace_name "SACD" |> NamespacedName
    /// <summary>
    ///
    ///         Here, we are dealing with the informational object (the MusicalExpression), not the actually "published" score.
    ///         This may be, for example, the product of an arrangement process.
    ///
    /// <see href="http://purl.org/ontology/mo/Score"></see></summary>
    let Score = Namespaced_IRI.parse _namespace_name "Score" |> NamespacedName
    /// <summary>
    ///
    ///         A show - a musical event lasting several days, in a particular venue. Examples can be
    ///         "The Magic Flute" at the Opera Bastille, August 2005, or a musical in the west end...
    ///
    /// <see href="http://purl.org/ontology/mo/Show"></see></summary>
    let Show = Namespaced_IRI.parse _namespace_name "Show" |> NamespacedName

    /// <summary>
    ///
    ///         A musical expression representing a group of signals, for example a set of masters resulting from a whole recording/mastering session.
    ///
    /// <see href="http://purl.org/ontology/mo/SignalGroup"></see></summary>
    let SignalGroup =
        Namespaced_IRI.parse _namespace_name "SignalGroup" |> NamespacedName

    /// <summary>
    /// Single person whose musical creative work shows sensitivity and imagination.
    /// <see href="http://purl.org/ontology/mo/SoloMusicArtist"></see></summary>
    let SoloMusicArtist =
        Namespaced_IRI.parse _namespace_name "SoloMusicArtist" |> NamespacedName

    /// <summary>
    ///
    ///         A subclass of MusicalExpression, representing a sound. Realisation of a MusicalWork during a musical Performance.
    ///
    /// <see href="http://purl.org/ontology/mo/Sound"></see></summary>
    let Sound = Namespaced_IRI.parse _namespace_name "Sound" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/SoundEngineer"></see>
    /// </summary>
    let SoundEngineer =
        Namespaced_IRI.parse _namespace_name "SoundEngineer" |> NamespacedName

    /// <summary>
    /// Relates agents to the performances/recordings they were engineering in
    /// <see href="http://purl.org/ontology/mo/engineered"></see></summary>
    let engineered = Namespaced_IRI.parse _namespace_name "engineered" |> NamespacedName
    /// <summary>
    /// Transmission over a network  used as medium to broadcast a musical manifestation
    /// <see href="http://purl.org/ontology/mo/Stream"></see></summary>
    let Stream = Namespaced_IRI.parse _namespace_name "Stream" |> NamespacedName
    /// <summary>
    /// Something available on the Bittorrent peer-2-peer filesharing network
    /// <see href="http://purl.org/ontology/mo/Torrent"></see></summary>
    let Torrent = Namespaced_IRI.parse _namespace_name "Torrent" |> NamespacedName
    /// <summary>
    /// A track on a particular record
    /// <see href="http://purl.org/ontology/mo/Track"></see></summary>
    let Track = Namespaced_IRI.parse _namespace_name "Track" |> NamespacedName

    /// <summary>
    /// Transcription event
    /// <see href="http://purl.org/ontology/mo/Transcription"></see></summary>
    let Transcription =
        Namespaced_IRI.parse _namespace_name "Transcription" |> NamespacedName

    /// <summary>
    /// Vinyl used as medium to record a musical manifestation
    /// <see href="http://purl.org/ontology/mo/Vinyl"></see></summary>
    let Vinyl = Namespaced_IRI.parse _namespace_name "Vinyl" |> NamespacedName
    /// <summary>
    /// Relates an artist to an activity period
    /// <see href="http://purl.org/ontology/mo/activity"></see></summary>
    let activity = Namespaced_IRI.parse _namespace_name "activity" |> NamespacedName

    /// <summary>
    /// Relates an artist to a date at which its activity ended
    /// <see href="http://purl.org/ontology/mo/activity_end"></see></summary>
    let activity_end =
        Namespaced_IRI.parse _namespace_name "activity_end" |> NamespacedName

    /// <summary>
    /// Relates an artist to a date at which its activity started
    /// <see href="http://purl.org/ontology/mo/activity_start"></see></summary>
    let activity_start =
        Namespaced_IRI.parse _namespace_name "activity_start" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/album"></see>
    /// </summary>
    let album = Namespaced_IRI.parse _namespace_name "album" |> NamespacedName

    /// <summary>
    /// Used to link a work or the expression of a work to its corresponding Amazon ASINs page.
    /// <see href="http://purl.org/ontology/mo/amazon_asin"></see></summary>
    let amazon_asin =
        Namespaced_IRI.parse _namespace_name "amazon_asin" |> NamespacedName

    /// <summary>
    ///
    ///         Associates a work to an arrangement event where it was arranged
    ///
    /// <see href="http://purl.org/ontology/mo/arranged_in"></see></summary>
    let arranged_in =
        Namespaced_IRI.parse _namespace_name "arranged_in" |> NamespacedName

    /// <summary>
    ///
    ///                 Associates an arrangement event to a work
    ///
    /// <see href="http://purl.org/ontology/mo/arrangement_of"></see></summary>
    let arrangement_of =
        Namespaced_IRI.parse _namespace_name "arrangement_of" |> NamespacedName

    /// <summary>
    /// Relates a membership event with the corresponding artist
    /// <see href="http://purl.org/ontology/mo/artist"></see></summary>
    let artist = Namespaced_IRI.parse _namespace_name "artist" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/audiobook"></see>
    /// </summary>
    let audiobook = Namespaced_IRI.parse _namespace_name "audiobook" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/availableAs"></see>
    /// </summary>
    let availableAs =
        Namespaced_IRI.parse _namespace_name "availableAs" |> NamespacedName

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
    let available_as =
        Namespaced_IRI.parse _namespace_name "available_as" |> NamespacedName

    /// <summary>
    /// Used to link an artist to their online biography.
    /// <see href="http://purl.org/ontology/mo/biography"></see></summary>
    let biography = Namespaced_IRI.parse _namespace_name "biography" |> NamespacedName

    /// <summary>
    ///
    ///         Associates a digital signal to the number a bits used to encode one sample. Range is xsd:int.
    ///
    /// <see href="http://purl.org/ontology/mo/bitsPerSample"></see></summary>
    let bitsPerSample =
        Namespaced_IRI.parse _namespace_name "bitsPerSample" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/bootleg"></see>
    /// </summary>
    let bootleg = Namespaced_IRI.parse _namespace_name "bootleg" |> NamespacedName
    /// <summary>
    ///
    ///         Indicates the BPM of a MusicalWork or a particular Performance
    ///         Beats per minute: the pace of music measured by the number of beats occurring in 60 seconds.
    ///
    /// <see href="http://purl.org/ontology/mo/bpm"></see></summary>
    let bpm = Namespaced_IRI.parse _namespace_name "bpm" |> NamespacedName

    /// <summary>
    /// Links a release with the corresponding catalogue number
    /// <see href="http://purl.org/ontology/mo/catalogue_number"></see></summary>
    let catalogue_number =
        Namespaced_IRI.parse _namespace_name "catalogue_number" |> NamespacedName

    /// <summary>
    ///
    ///             Links an object to an universally unique identifier for it.
    ///
    /// <see href="http://purl.org/ontology/mo/uuid"></see></summary>
    let uuid = Namespaced_IRI.parse _namespace_name "uuid" |> NamespacedName
    /// <summary>
    ///
    ///         Associates a signal to the number of channels it holds (mono --&gt; 1, stereo --&gt; 2). Range is xsd:int.
    ///
    /// <see href="http://purl.org/ontology/mo/channels"></see></summary>
    let channels = Namespaced_IRI.parse _namespace_name "channels" |> NamespacedName

    /// <summary>
    /// Used to relate two collaborating people on a work.
    /// <see href="http://purl.org/ontology/mo/collaborated_with"></see></summary>
    let collaborated_with =
        Namespaced_IRI.parse _namespace_name "collaborated_with" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/compilation"></see>
    /// </summary>
    let compilation =
        Namespaced_IRI.parse _namespace_name "compilation" |> NamespacedName

    /// <summary>
    /// Indicates that a musical manifestation is a compilation of several Signals.
    /// <see href="http://purl.org/ontology/mo/compilation_of"></see></summary>
    let compilation_of =
        Namespaced_IRI.parse _namespace_name "compilation_of" |> NamespacedName

    /// <summary>
    /// Used to relate an person or a group of person who compiled the manifestation of a musical work.
    /// <see href="http://purl.org/ontology/mo/compiled"></see></summary>
    let compiled = Namespaced_IRI.parse _namespace_name "compiled" |> NamespacedName
    /// <summary>
    /// Used to relate the manifestation of a musical work to a person or a group of person who compiled it.
    /// <see href="http://purl.org/ontology/mo/compiler"></see></summary>
    let compiler = Namespaced_IRI.parse _namespace_name "compiler" |> NamespacedName

    /// <summary>
    ///
    ///         Associates a MusicalWork to the Composition event pertaining
    ///         to its creation. For example, I might use this property to associate
    ///         the Magic Flute to its composition event, occuring during 1782 and having as
    ///         a mo:composer Mozart.
    ///
    /// <see href="http://purl.org/ontology/mo/composed_in"></see></summary>
    let composed_in =
        Namespaced_IRI.parse _namespace_name "composed_in" |> NamespacedName

    /// <summary>
    ///
    ///                 Associates a composition event to the produced MusicalWork. For example,
    ///                 this property could link the event corresponding to the composition of the
    ///                 Magic Flute in 1782 to the Magic Flute musical work itself. This musical work
    ///                 can then be used in particular performances.
    ///
    /// <see href="http://purl.org/ontology/mo/produced_work"></see></summary>
    let produced_work =
        Namespaced_IRI.parse _namespace_name "produced_work" |> NamespacedName

    /// <summary>
    ///
    ///         Associates a composition event to the actual composer. For example,
    ///         this property could link the event corresponding to the composition of the
    ///         Magic Flute in 1782 to Mozart himself (who obviously has a FOAF profile:-) ).
    ///
    /// <see href="http://purl.org/ontology/mo/composer"></see></summary>
    let composer = Namespaced_IRI.parse _namespace_name "composer" |> NamespacedName
    /// <summary>
    /// Relates a performance to the conductor involved
    /// <see href="http://purl.org/ontology/mo/conductor"></see></summary>
    let conductor = Namespaced_IRI.parse _namespace_name "conductor" |> NamespacedName

    /// <summary>
    ///
    ///         Relates a signal to another signal, which has been sampled.
    ///
    /// <see href="http://purl.org/ontology/mo/contains_sample_from"></see></summary>
    let contains_sample_from =
        Namespaced_IRI.parse _namespace_name "contains_sample_from" |> NamespacedName

    /// <summary>
    /// A related signal from which the described signal is derived.
    /// <see href="http://purl.org/ontology/mo/derived_from"></see></summary>
    let derived_from =
        Namespaced_IRI.parse _namespace_name "derived_from" |> NamespacedName

    /// <summary>
    /// Used to links an artist to an online discography of their musical works. The discography should provide a summary of each released musical work of the artist.
    /// <see href="http://purl.org/ontology/mo/discography"></see></summary>
    let discography =
        Namespaced_IRI.parse _namespace_name "discography" |> NamespacedName

    /// <summary>
    /// Used to link a musical work or the expression of a musical work, an artist or a corporate body to to its corresponding Discogs page.
    /// <see href="http://purl.org/ontology/mo/discogs"></see></summary>
    let discogs = Namespaced_IRI.parse _namespace_name "discogs" |> NamespacedName
    /// <summary>
    /// Indicates that all (or most of) the tracks of a musical work or the expression of a musical work were mixed together from all (or most of) the tracks from another musical work or the expression of a musical work to form a so called DJ-Mix.
    ///
    /// The tracks might have been altered by pitching (so that the tempo of one track matches the tempo of the following track) and fading (so that one track blends in smoothly with the other). If the tracks have been more substantially altered, the "mo:remix" relationship type is more appropriate.
    /// <see href="http://purl.org/ontology/mo/djmix_of"></see></summary>
    let djmix_of = Namespaced_IRI.parse _namespace_name "djmix_of" |> NamespacedName
    /// <summary>
    /// Used to relate an artist who djmixed a musical work or the expression of a musical work.
    ///
    /// The artist usually selected the tracks, chose their sequence, and slightly changed them by fading (so that one track blends in smoothly with the other) or pitching (so that the tempo of one track matches the tempo of the following track). This applies to a 'Mixtape' in which all tracks were DJ-mixed together into one single long track.
    /// <see href="http://purl.org/ontology/mo/djmixed"></see></summary>
    let djmixed = Namespaced_IRI.parse _namespace_name "djmixed" |> NamespacedName
    /// <summary>
    /// Used to relate a work or the expression of a work to an artist who djmixed it.
    ///
    /// The artist usually selected the tracks, chose their sequence, and slightly changed them by fading (so that one track blends in smoothly with the other) or pitching (so that the tempo of one track matches the tempo of the following track). This applies to a 'Mixtape' in which all tracks were DJ-mixed together into one single long track.
    /// <see href="http://purl.org/ontology/mo/djmixed_by"></see></summary>
    let djmixed_by = Namespaced_IRI.parse _namespace_name "djmixed_by" |> NamespacedName
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
    let download = Namespaced_IRI.parse _namespace_name "download" |> NamespacedName
    /// <summary>
    /// The duration of a track or a signal in ms
    /// <see href="http://purl.org/ontology/mo/duration"></see></summary>
    let duration = Namespaced_IRI.parse _namespace_name "duration" |> NamespacedName
    /// <summary>
    /// The European Article Number (EAN) is a universal identifier for products, commonly printed in form of barcodes on them. The numbers represented by those codes can either be 8 or 13 digits long, with the 13-digit-version being most common. EANs form a superset of the North American Universal Product Code (UPC) as every UPC can be made an EAN by adding a leading zero to it. Additionally every EAN is also a Japanese Article Number (JAN). The identifiers were formerly assigned by EAN International which merged with Uniform Code Council (UCC, the guys behind the UPCs) and Electronic Commerce Council of Canada (ECCC) to become GS1.
    /// <see href="http://purl.org/ontology/mo/ean"></see></summary>
    let ean = Namespaced_IRI.parse _namespace_name "ean" |> NamespacedName
    /// <summary>
    /// GTIN is a grouping term for EANs and UPCs. In common speech those are called barcodes although the barcodes are just a representation of those identifying numbers.
    /// <see href="http://purl.org/ontology/mo/gtin"></see></summary>
    let gtin = Namespaced_IRI.parse _namespace_name "gtin" |> NamespacedName
    /// <summary>
    ///
    ///         Relates a MusicalItem (a track on a particular CD, an audio file, a stream somewhere) to the signal it encodes.
    ///
    ///         This is usually a lower-resolution version of the master signal (issued from a Recording event).
    ///
    /// <see href="http://purl.org/ontology/mo/encodes"></see></summary>
    let encodes = Namespaced_IRI.parse _namespace_name "encodes" |> NamespacedName
    /// <summary>
    /// Method used to convert analog electronic signals into digital format such as "MP3 CBR @ 128kbps", "OGG @ 160kbps", "FLAC", etc.
    /// <see href="http://purl.org/ontology/mo/encoding"></see></summary>
    let encoding = Namespaced_IRI.parse _namespace_name "encoding" |> NamespacedName
    /// <summary>
    /// Relates a performance or a recording to the engineer involved
    /// <see href="http://purl.org/ontology/mo/engineer"></see></summary>
    let engineer = Namespaced_IRI.parse _namespace_name "engineer" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/ep"></see>
    /// </summary>
    let ep = Namespaced_IRI.parse _namespace_name "ep" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/eventHomePage"></see>
    /// </summary>
    let eventHomePage =
        Namespaced_IRI.parse _namespace_name "eventHomePage" |> NamespacedName

    /// <summary>
    /// Links a particular event to a web page
    /// <see href="http://purl.org/ontology/mo/event_homepage"></see></summary>
    let event_homepage =
        Namespaced_IRI.parse _namespace_name "event_homepage" |> NamespacedName

    /// <summary>
    /// A person, a group of person or an organization exchanging an exemplar of a single manifestation.
    /// <see href="http://purl.org/ontology/mo/exchange_item"></see></summary>
    let exchange_item =
        Namespaced_IRI.parse _namespace_name "exchange_item" |> NamespacedName

    /// <summary>
    /// Used to link an artist to a fan-created webpage devoted to that artist.
    /// <see href="http://purl.org/ontology/mo/fanpage"></see></summary>
    let fanpage = Namespaced_IRI.parse _namespace_name "fanpage" |> NamespacedName

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
    let free_download =
        Namespaced_IRI.parse _namespace_name "free_download" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/freedownload"></see>
    /// </summary>
    let freedownload =
        Namespaced_IRI.parse _namespace_name "freedownload" |> NamespacedName

    /// <summary>
    ///
    ///         Associates an event (like a performance or a recording) to a particular musical genre.
    ///         Further version of this property may also include works and scores in the domain.
    ///
    /// <see href="http://purl.org/ontology/mo/genre"></see></summary>
    let genre = Namespaced_IRI.parse _namespace_name "genre" |> NamespacedName
    /// <summary>
    /// The Global Release Identifier (GRid) is a system for uniquely identifying Releases of music over electronic networks (that is, online stores where you can buy music as digital files). As that it can be seen as the equivalent of the BarCode (or more correctly the GTIN) as found on physical releases of music. Like the ISRC (a code for identifying single recordings as found on releases) it was developed by the IFPI but it does not appear to be a standard of the ISO.
    /// <see href="http://purl.org/ontology/mo/grid"></see></summary>
    let grid = Namespaced_IRI.parse _namespace_name "grid" |> NamespacedName
    /// <summary>
    /// Relates a membership event with the corresponding group
    /// <see href="http://purl.org/ontology/mo/group"></see></summary>
    let group = Namespaced_IRI.parse _namespace_name "group" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/has_track"></see>
    /// </summary>
    let has_track = Namespaced_IRI.parse _namespace_name "has_track" |> NamespacedName
    /// <summary>
    /// Indicates a part of a musical manifestation - in this particular case, a track.
    /// <see href="http://purl.org/ontology/mo/track"></see></summary>
    let track = Namespaced_IRI.parse _namespace_name "track" |> NamespacedName
    /// <summary>
    /// Relates a performance to the headliner(s) involved
    /// <see href="http://purl.org/ontology/mo/headliner"></see></summary>
    let headliner = Namespaced_IRI.parse _namespace_name "headliner" |> NamespacedName
    /// <summary>
    /// Relates a performance to the performers involved
    /// <see href="http://purl.org/ontology/mo/performer"></see></summary>
    let performer = Namespaced_IRI.parse _namespace_name "performer" |> NamespacedName
    /// <summary>
    /// Links an artist, a record, etc. to a corresponding web page
    /// <see href="http://purl.org/ontology/mo/homepage"></see></summary>
    let homepage = Namespaced_IRI.parse _namespace_name "homepage" |> NamespacedName
    /// <summary>
    /// Indicates a pictorial image (JPEG, GIF, PNG, Etc.) of a musical work, the expression of a musical work, the manifestation of a work or the examplar of a manifestation.
    /// <see href="http://purl.org/ontology/mo/image"></see></summary>
    let image = Namespaced_IRI.parse _namespace_name "image" |> NamespacedName
    /// <summary>
    /// Used to link an artist, a musical work or the expression of a musical work to their equivalent page on IMDb, the InternetMovieDatabase.
    /// <see href="http://purl.org/ontology/mo/imdb"></see></summary>
    let imdb = Namespaced_IRI.parse _namespace_name "imdb" |> NamespacedName
    /// <summary>
    /// Relates a performance to a musical instrument involved
    /// <see href="http://purl.org/ontology/mo/instrument"></see></summary>
    let instrument = Namespaced_IRI.parse _namespace_name "instrument" |> NamespacedName

    /// <summary>
    /// Adds an involved music artist, who interpreted, remixed, or otherwise modified an existing signal, which resulted in the signal that is here the subject of this relation.
    /// <see href="http://purl.org/ontology/mo/interpreter"></see></summary>
    let interpreter =
        Namespaced_IRI.parse _namespace_name "interpreter" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/interview"></see>
    /// </summary>
    let interview = Namespaced_IRI.parse _namespace_name "interview" |> NamespacedName
    /// <summary>
    /// The Interested Parties Information Code (IPI) is an ISO standard similar to ISBNs for identifying the people or groups with some involvement with a particular musical work / compositions.
    /// <see href="http://purl.org/ontology/mo/ipi"></see></summary>
    let ipi = Namespaced_IRI.parse _namespace_name "ipi" |> NamespacedName
    /// <summary>
    /// The International Standard Music Number (ISMN) is an ISO standard similar to ISBNs for identifying printed music publications
    /// <see href="http://purl.org/ontology/mo/ismn"></see></summary>
    let ismn = Namespaced_IRI.parse _namespace_name "ismn" |> NamespacedName
    /// <summary>
    ///
    ///     The ISRC (International Standard Recording Code) is the international identification system for sound recordings and music videorecordings.
    ///     Each ISRC is a unique and permanent identifier for a specific recording which can be permanently encoded into a product as its digital fingerprint.
    ///     Encoded ISRC provide the means to automatically identify recordings for royalty payments.
    ///
    /// <see href="http://purl.org/ontology/mo/isrc"></see></summary>
    let isrc = Namespaced_IRI.parse _namespace_name "isrc" |> NamespacedName
    /// <summary>
    /// Links a musical work to the corresponding ISWC number
    /// <see href="http://purl.org/ontology/mo/iswc"></see></summary>
    let iswc = Namespaced_IRI.parse _namespace_name "iswc" |> NamespacedName
    /// <summary>
    ///
    ///                 Relates a musical manifestation to a musical item (this album, and my particular cd) holding the
    ///                 entire manifestation, and not just a part of it.
    ///
    /// <see href="http://purl.org/ontology/mo/item"></see></summary>
    let item = Namespaced_IRI.parse _namespace_name "item" |> NamespacedName
    /// <summary>
    ///
    ///         Indicated the key used by the musicians during a performance, or the key of a MusicalWork.
    ///         Any of 24 major or minor diatonic scales that provide the tonal framework for a piece of music.
    /// <see href="http://purl.org/ontology/mo/key"></see></summary>
    let key = Namespaced_IRI.parse _namespace_name "key" |> NamespacedName
    /// <summary>
    /// Associates a release event with the label releasing the record
    /// <see href="http://purl.org/ontology/mo/label"></see></summary>
    let label = Namespaced_IRI.parse _namespace_name "label" |> NamespacedName
    /// <summary>
    /// The Label Code (LC) was introduced in 1977 by the IFPI (International Federation of Phonogram and Videogram Industries) in order to unmistakably identify the different record labels (see Introduction, Record labels) for rights purposes. The Label Code consists historically of 4 figures, presently being extended to 5 figures, preceded by LC and a dash (e.g. LC-0193 = Electrola; LC-0233 = His Master's Voice). Note that the number of countries using the LC is limited, and that the code given on the item is not always accurate.
    /// <see href="http://purl.org/ontology/mo/lc"></see></summary>
    let lc = Namespaced_IRI.parse _namespace_name "lc" |> NamespacedName
    /// <summary>
    /// Used to link a work or the expression of a work to the license under which they can be manipulated (downloaded, modified, etc).
    ///
    /// This is usually used to link to a Creative Commons licence.
    /// <see href="http://purl.org/ontology/mo/licence"></see></summary>
    let licence = Namespaced_IRI.parse _namespace_name "licence" |> NamespacedName
    /// <summary>
    /// Relates a performance to the listener involved
    /// <see href="http://purl.org/ontology/mo/listener"></see></summary>
    let listener = Namespaced_IRI.parse _namespace_name "listener" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/live"></see>
    /// </summary>
    let live = Namespaced_IRI.parse _namespace_name "live" |> NamespacedName
    /// <summary>
    /// Associates lyrics with a musical work
    /// <see href="http://purl.org/ontology/mo/lyrics"></see></summary>
    let lyrics = Namespaced_IRI.parse _namespace_name "lyrics" |> NamespacedName
    /// <summary>
    /// Used to link a musical work or the expression of a musical work to a website where people can buy a copy of the musical manifestation.
    /// <see href="http://purl.org/ontology/mo/mailorder"></see></summary>
    let mailorder = Namespaced_IRI.parse _namespace_name "mailorder" |> NamespacedName
    /// <summary>
    /// Indicates that musical works or the expressions of a musical work were mashed up on this album or track.
    ///
    /// This means that two musical works or the expressions of a musical work by different artists are mixed together, over each other, or otherwise combined into a single musical work (usually by a third artist, the remixer).
    /// <see href="http://purl.org/ontology/mo/mashup_of"></see></summary>
    let mashup_of = Namespaced_IRI.parse _namespace_name "mashup_of" |> NamespacedName
    /// <summary>
    /// The mediatype (file format or MIME type, or physical medium) of a musical manifestation, e.g. a MP3, CD or vinyl.
    /// <see href="http://purl.org/ontology/mo/media_type"></see></summary>
    let media_type = Namespaced_IRI.parse _namespace_name "media_type" |> NamespacedName
    /// <summary>
    /// Indicates that a musical expression is a medley of several other musical expressions.
    ///
    /// This means that the orignial musical expression were rearranged to create a new musical expression in the form of a medley.
    /// <see href="http://purl.org/ontology/mo/medley_of"></see></summary>
    let medley_of = Namespaced_IRI.parse _namespace_name "medley_of" |> NamespacedName
    /// <summary>
    ///
    ///         Indicates a member of a musical group
    ///
    /// <see href="http://purl.org/ontology/mo/member"></see></summary>
    let member_ = Namespaced_IRI.parse _namespace_name "member" |> NamespacedName
    /// <summary>
    /// Inverse of the foaf:member property
    /// <see href="http://purl.org/ontology/mo/member_of"></see></summary>
    let member_of = Namespaced_IRI.parse _namespace_name "member_of" |> NamespacedName
    /// <summary>
    /// Relates an agent with related membership events
    /// <see href="http://purl.org/ontology/mo/membership"></see></summary>
    let membership = Namespaced_IRI.parse _namespace_name "membership" |> NamespacedName
    /// <summary>
    /// Associates a musical work or a score with its meter
    /// <see href="http://purl.org/ontology/mo/meter"></see></summary>
    let meter = Namespaced_IRI.parse _namespace_name "meter" |> NamespacedName
    /// <summary>
    /// Indicates that a musical work has movements
    /// <see href="http://purl.org/ontology/mo/movement"></see></summary>
    let movement = Namespaced_IRI.parse _namespace_name "movement" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/movementNum"></see>
    /// </summary>
    let movementNum =
        Namespaced_IRI.parse _namespace_name "movementNum" |> NamespacedName

    /// <summary>
    /// Indicates the position of a movement in a musical work.
    /// <see href="http://purl.org/ontology/mo/movement_number"></see></summary>
    let movement_number =
        Namespaced_IRI.parse _namespace_name "movement_number" |> NamespacedName

    /// <summary>
    ///
    ///         Linking an agent, a track or a record to its corresponding Musicbrainz page.
    ///
    /// <see href="http://purl.org/ontology/mo/musicbrainz"></see></summary>
    let musicbrainz =
        Namespaced_IRI.parse _namespace_name "musicbrainz" |> NamespacedName

    /// <summary>
    /// Links an object to the corresponding Musicbrainz identifier
    /// <see href="http://purl.org/ontology/mo/musicbrainz_guid"></see></summary>
    let musicbrainz_guid =
        Namespaced_IRI.parse _namespace_name "musicbrainz_guid" |> NamespacedName

    /// <summary>
    /// Used to link an artist, a musical work or the expression of a musical work to its corresponding MusicMoz page.
    /// <see href="http://purl.org/ontology/mo/musicmoz"></see></summary>
    let musicmoz = Namespaced_IRI.parse _namespace_name "musicmoz" |> NamespacedName
    /// <summary>
    /// Used to link a person to its corresponding MySpace page.
    /// <see href="http://purl.org/ontology/mo/myspace"></see></summary>
    let myspace = Namespaced_IRI.parse _namespace_name "myspace" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/official"></see>
    /// </summary>
    let official = Namespaced_IRI.parse _namespace_name "official" |> NamespacedName
    /// <summary>
    /// Used to link a track to a tabulature file for track in the On-Line Guitar Archive.
    /// <see href="http://purl.org/ontology/mo/olga"></see></summary>
    let olga = Namespaced_IRI.parse _namespace_name "olga" |> NamespacedName

    /// <summary>
    /// Used to link a person with an online community web page like a blog, a wiki, a forum, a livejournal page, Etc.
    /// <see href="http://purl.org/ontology/mo/onlinecommunity"></see></summary>
    let onlinecommunity =
        Namespaced_IRI.parse _namespace_name "onlinecommunity" |> NamespacedName

    /// <summary>
    ///
    ///         Used to define a creative work, especially a musical composition numbered to designate the order of a composer's works.
    ///
    /// <see href="http://purl.org/ontology/mo/opus"></see></summary>
    let opus = Namespaced_IRI.parse _namespace_name "opus" |> NamespacedName
    /// <summary>
    /// Relates an artist to its geographic origin
    /// <see href="http://purl.org/ontology/mo/origin"></see></summary>
    let origin = Namespaced_IRI.parse _namespace_name "origin" |> NamespacedName

    /// <summary>
    /// Indicates that two musical manifestations are essentially the same.
    /// <see href="http://purl.org/ontology/mo/other_release_of"></see></summary>
    let other_release_of =
        Namespaced_IRI.parse _namespace_name "other_release_of" |> NamespacedName

    /// <summary>
    ///
    ///                 Provide a link from an artist to a web page where all of that artist's musical work is available for some money,
    ///                 or a link from a manifestation (record/track, for example) to a web page providing a paid access to this manifestation.
    ///
    /// <see href="http://purl.org/ontology/mo/paid_download"></see></summary>
    let paid_download =
        Namespaced_IRI.parse _namespace_name "paid_download" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/paiddownload"></see>
    /// </summary>
    let paiddownload =
        Namespaced_IRI.parse _namespace_name "paiddownload" |> NamespacedName

    /// <summary>
    ///
    ///         Associates a Performance to a musical work or an arrangement that is being used as a factor in it.
    ///         For example, I might use this property to attach the Magic Flute musical work to
    ///         a particular Performance.
    ///
    /// <see href="http://purl.org/ontology/mo/performance_of"></see></summary>
    let performance_of =
        Namespaced_IRI.parse _namespace_name "performance_of" |> NamespacedName

    /// <summary>
    ///
    ///         Associates a Musical Work or an Score to Performances in which they were
    ///         a factor. For example, I might use this property in order to
    ///         associate the Magic Flute to a particular performance at the Opera
    ///         Bastille last year.
    /// <see href="http://purl.org/ontology/mo/performed_in"></see></summary>
    let performed_in =
        Namespaced_IRI.parse _namespace_name "performed_in" |> NamespacedName

    /// <summary>
    /// A person, a group of person or an organization possessing an exemplar of a single manifestation.
    /// <see href="http://purl.org/ontology/mo/possess_item"></see></summary>
    let possess_item =
        Namespaced_IRI.parse _namespace_name "possess_item" |> NamespacedName

    /// <summary>
    ///
    ///                 Relates a musical manifestation to a musical item (this album, and my particular cd), which holds
    ///                 a preview of the manifestation (eg. one track for an album, or a snippet for a track)
    ///
    /// <see href="http://purl.org/ontology/mo/preview"></see></summary>
    let preview = Namespaced_IRI.parse _namespace_name "preview" |> NamespacedName

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
    let preview_download =
        Namespaced_IRI.parse _namespace_name "preview_download" |> NamespacedName

    /// <summary>
    /// Indicates that an artist primarily plays an instrument, or that a member was primarily playing a particular instrument during his membership
    /// <see href="http://purl.org/ontology/mo/primary_instrument"></see></summary>
    let primary_instrument =
        Namespaced_IRI.parse _namespace_name "primary_instrument" |> NamespacedName

    /// <summary>
    /// Used to relate an person or a group of person who produced the manifestation of a work.
    /// <see href="http://purl.org/ontology/mo/produced"></see></summary>
    let produced = Namespaced_IRI.parse _namespace_name "produced" |> NamespacedName
    /// <summary>
    /// Used to relate the manifestation of a work to a person or a group of person who produced it.
    /// <see href="http://purl.org/ontology/mo/producer"></see></summary>
    let producer = Namespaced_IRI.parse _namespace_name "producer" |> NamespacedName

    /// <summary>
    ///
    ///         Associates an arrangement or a composition event to a score product (score here does not refer to a published score, but more
    ///         an abstract arrangement of a particular work).
    ///
    /// <see href="http://purl.org/ontology/mo/produced_score"></see></summary>
    let produced_score =
        Namespaced_IRI.parse _namespace_name "produced_score" |> NamespacedName

    /// <summary>
    ///
    ///                 Associates a Recording to the outputted signal.
    ///
    /// <see href="http://purl.org/ontology/mo/produced_signal"></see></summary>
    let produced_signal =
        Namespaced_IRI.parse _namespace_name "produced_signal" |> NamespacedName

    /// <summary>
    /// Associates a recording session with a group of master signals produced by it.
    /// <see href="http://purl.org/ontology/mo/produced_signal_group"></see></summary>
    let produced_signal_group =
        Namespaced_IRI.parse _namespace_name "produced_signal_group" |> NamespacedName

    /// <summary>
    ///
    ///                 Associates a Performance to a physical Sound that is being produced by it.
    ///
    /// <see href="http://purl.org/ontology/mo/produced_sound"></see></summary>
    let produced_sound =
        Namespaced_IRI.parse _namespace_name "produced_sound" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/producesSignal"></see>
    /// </summary>
    let producesSignal =
        Namespaced_IRI.parse _namespace_name "producesSignal" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/producesSound"></see>
    /// </summary>
    let producesSound =
        Namespaced_IRI.parse _namespace_name "producesSound" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/producesWork"></see>
    /// </summary>
    let producesWork =
        Namespaced_IRI.parse _namespace_name "producesWork" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/productOfComposition"></see>
    /// </summary>
    let productOfComposition =
        Namespaced_IRI.parse _namespace_name "productOfComposition" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/promotion"></see>
    /// </summary>
    let promotion = Namespaced_IRI.parse _namespace_name "promotion" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/publicationOf"></see>
    /// </summary>
    let publicationOf =
        Namespaced_IRI.parse _namespace_name "publicationOf" |> NamespacedName

    /// <summary>
    /// Link a particular manifestation to the related signal, score, libretto, or lyrics
    /// <see href="http://purl.org/ontology/mo/publication_of"></see></summary>
    let publication_of =
        Namespaced_IRI.parse _namespace_name "publication_of" |> NamespacedName

    /// <summary>
    ///
    ///         Links a musical expression (e.g. a signal or a score) to one of its manifestations (e.g. a track on a particular record or a published score).
    ///
    /// <see href="http://purl.org/ontology/mo/published_as"></see></summary>
    let published_as =
        Namespaced_IRI.parse _namespace_name "published_as" |> NamespacedName

    /// <summary>
    /// Used to relate an person or a group of person who published the manifestation of a work.
    /// <see href="http://purl.org/ontology/mo/published"></see></summary>
    let published = Namespaced_IRI.parse _namespace_name "published" |> NamespacedName
    /// <summary>
    /// Used to relate a musical manifestation to a person or a group of person who published it.
    /// <see href="http://purl.org/ontology/mo/publisher"></see></summary>
    let publisher = Namespaced_IRI.parse _namespace_name "publisher" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/publishedAs"></see>
    /// </summary>
    let publishedAs =
        Namespaced_IRI.parse _namespace_name "publishedAs" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/publishingLocation"></see>
    /// </summary>
    let publishingLocation =
        Namespaced_IRI.parse _namespace_name "publishingLocation" |> NamespacedName

    /// <summary>
    ///
    ///         Relates a musical manifestation to its publication location.
    ///
    /// <see href="http://purl.org/ontology/mo/publishing_location"></see></summary>
    let publishing_location =
        Namespaced_IRI.parse _namespace_name "publishing_location" |> NamespacedName

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
    let puid = Namespaced_IRI.parse _namespace_name "puid" |> NamespacedName
    /// <summary>
    /// Associates a release with the records it contains. A single release can be associated with multiple records, for example for a multi-disc release.
    /// <see href="http://purl.org/ontology/mo/record"></see></summary>
    let record = Namespaced_IRI.parse _namespace_name "record" |> NamespacedName

    /// <summary>
    /// Associates a release with the number of records it contains, e.g. the number of discs it contains in the case of a multi-disc release.
    /// <see href="http://purl.org/ontology/mo/record_count"></see></summary>
    let record_count =
        Namespaced_IRI.parse _namespace_name "record_count" |> NamespacedName

    /// <summary>
    /// Indicates the position of a record in a release (e.g. a 2xLP, etc.).
    /// <see href="http://purl.org/ontology/mo/record_number"></see></summary>
    let record_number =
        Namespaced_IRI.parse _namespace_name "record_number" |> NamespacedName

    /// <summary>
    /// Associates the side on a vinyl record, where a track is located, e.g. A, B, C, etc. This property can then also be used
    /// in conjunction with mo:track_number, so that one can infer e.g. "A1", that means, track number 1 on side A.
    /// <see href="http://purl.org/ontology/mo/record_side"></see></summary>
    let record_side =
        Namespaced_IRI.parse _namespace_name "record_side" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/recordedAs"></see>
    /// </summary>
    let recordedAs = Namespaced_IRI.parse _namespace_name "recordedAs" |> NamespacedName

    /// <summary>
    ///
    ///         This is a shortcut property, allowing to bypass all the Sound/Recording steps. This property
    ///         allows to directly link a Performance to the recorded Signal. This is recommended for "normal"
    ///         users. However, advanced users wanting to express things such as the location of the microphone will
    ///         have to create this shortcut as well as the whole workflow, in order to let the "normal" users access
    ///         simply the, well, simple information:-) .
    ///
    /// <see href="http://purl.org/ontology/mo/recorded_as"></see></summary>
    let recorded_as =
        Namespaced_IRI.parse _namespace_name "recorded_as" |> NamespacedName

    /// <summary>
    ///
    ///         This is the inverse of the shortcut property recordedAs, allowing to relate directly a performance
    ///         to a signal.
    ///
    /// <see href="http://purl.org/ontology/mo/records"></see></summary>
    let records = Namespaced_IRI.parse _namespace_name "records" |> NamespacedName

    /// <summary>
    ///
    ///             Associates a physical Sound to a Recording event where it is being used
    ///         in order to produce a signal. For example, I might use this property to
    ///         associate the sound produced by a particular performance of the magic flute
    ///         to a given recording, done using my cell-phone.
    ///
    /// <see href="http://purl.org/ontology/mo/recorded_in"></see></summary>
    let recorded_in =
        Namespaced_IRI.parse _namespace_name "recorded_in" |> NamespacedName

    /// <summary>
    ///
    ///             Associates a Recording event to a physical Sound being recorded.
    ///                 For example, I might use this property to
    ///                 associate a given recording, done using my cell phone, to the
    ///         sound produced by a particular performance of the magic flute.
    ///
    /// <see href="http://purl.org/ontology/mo/recording_of"></see></summary>
    let recording_of =
        Namespaced_IRI.parse _namespace_name "recording_of" |> NamespacedName

    /// <summary>
    /// Associates a release with the corresponding release event
    /// <see href="http://purl.org/ontology/mo/release"></see></summary>
    let release = Namespaced_IRI.parse _namespace_name "release" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/releaseStatus"></see>
    /// </summary>
    let releaseStatus =
        Namespaced_IRI.parse _namespace_name "releaseStatus" |> NamespacedName

    /// <summary>
    ///
    ///                 Relates a musical manifestation to its release status (bootleg, ...)
    ///
    /// <see href="http://purl.org/ontology/mo/release_status"></see></summary>
    let release_status =
        Namespaced_IRI.parse _namespace_name "release_status" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/releaseType"></see>
    /// </summary>
    let releaseType =
        Namespaced_IRI.parse _namespace_name "releaseType" |> NamespacedName

    /// <summary>
    ///
    ///         Relates a musical manifestation to its release type (interview, spoken word, album, ...)
    ///
    /// <see href="http://purl.org/ontology/mo/release_type"></see></summary>
    let release_type =
        Namespaced_IRI.parse _namespace_name "release_type" |> NamespacedName

    /// <summary>
    /// This relates two musical work or the expression of a musical work, where one is a remaster of the other.
    ///
    /// A remaster is a new version made for release from source recordings that were earlier released separately. This is usually done to improve the audio quality or adjust for more modern playback equipment. The process generally doesn't involve changing the music in any artistically important way. It may, however, result in tracks that are a few seconds longer or shorter.
    /// <see href="http://purl.org/ontology/mo/remaster_of"></see></summary>
    let remaster_of =
        Namespaced_IRI.parse _namespace_name "remaster_of" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/remix"></see>
    /// </summary>
    let remix = Namespaced_IRI.parse _namespace_name "remix" |> NamespacedName
    /// <summary>
    /// Used to relate the remix of a musical work in a substantially altered version produced by mixing together individual tracks or segments of an original musical source work.
    /// <see href="http://purl.org/ontology/mo/remix_of"></see></summary>
    let remix_of = Namespaced_IRI.parse _namespace_name "remix_of" |> NamespacedName
    /// <summary>
    /// Used to relate an artist who remixed a musical work or the expression of a musical work.
    ///
    /// This involves taking just one other musical work and using audio editing to make it sound like a significantly different, but usually still recognisable, song. It can be used to link an artist to a single song that they remixed, or, if they remixed an entire musical work.
    /// <see href="http://purl.org/ontology/mo/remixed"></see></summary>
    let remixed = Namespaced_IRI.parse _namespace_name "remixed" |> NamespacedName
    /// <summary>
    /// Used to relate a musical work or the expression of a musical work to an artist who remixed it.
    ///
    /// This involves taking just one other musical work and using audio editing to make it sound like a significantly different, but usually still recognisable, song. It can be used to link an artist to a single song that they remixed, or, if they remixed an entire musical work.
    /// <see href="http://purl.org/ontology/mo/remixer"></see></summary>
    let remixer = Namespaced_IRI.parse _namespace_name "remixer" |> NamespacedName
    /// <summary>
    /// Used to link a work or the expression of a work to a review.
    ///
    /// The review does not have to be open content, as long as it is accessible to the general internet population.
    /// <see href="http://purl.org/ontology/mo/review"></see></summary>
    let review = Namespaced_IRI.parse _namespace_name "review" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/sampleRate"></see>
    /// </summary>
    let sampleRate = Namespaced_IRI.parse _namespace_name "sampleRate" |> NamespacedName

    /// <summary>
    ///
    ///         Associates a digital signal to its sample rate. It might be easier to express it this way instead of
    ///         defining a timeline map:-) Range is xsd:float.
    ///
    /// <see href="http://purl.org/ontology/mo/sample_rate"></see></summary>
    let sample_rate =
        Namespaced_IRI.parse _namespace_name "sample_rate" |> NamespacedName

    /// <summary>
    /// Used to relate an artist who sampled a Signal.
    /// <see href="http://purl.org/ontology/mo/sampled"></see></summary>
    let sampled = Namespaced_IRI.parse _namespace_name "sampled" |> NamespacedName
    /// <summary>
    /// Used to relate the signal of a musical work to an artist who sampled it.
    /// <see href="http://purl.org/ontology/mo/sampler"></see></summary>
    let sampler = Namespaced_IRI.parse _namespace_name "sampler" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/sampledVersionOf"></see>
    /// </summary>
    let sampledVersionOf =
        Namespaced_IRI.parse _namespace_name "sampledVersionOf" |> NamespacedName

    /// <summary>
    ///
    ///         Associates a digital signal with the analog version of it
    ///
    /// <see href="http://purl.org/ontology/mo/sampled_version_of"></see></summary>
    let sampled_version_of =
        Namespaced_IRI.parse _namespace_name "sampled_version_of" |> NamespacedName

    /// <summary>
    ///
    ///         Associates an analog signal with a sampled version of it
    ///
    /// <see href="http://purl.org/ontology/mo/sampled_version"></see></summary>
    let sampled_version =
        Namespaced_IRI.parse _namespace_name "sampled_version" |> NamespacedName

    /// <summary>
    /// A person, a group of person or an organization selling an exemplar of a single manifestation.
    /// <see href="http://purl.org/ontology/mo/sell_item"></see></summary>
    let sell_item = Namespaced_IRI.parse _namespace_name "sell_item" |> NamespacedName
    /// <summary>
    /// Associates a group of signals with one of the signals it contains
    /// <see href="http://purl.org/ontology/mo/signal"></see></summary>
    let signal = Namespaced_IRI.parse _namespace_name "signal" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/signalTime"></see>
    /// </summary>
    let signalTime = Namespaced_IRI.parse _namespace_name "signalTime" |> NamespacedName
    /// <summary>
    ///
    ///         Associates a Signal to a time object - its actual domain
    ///
    /// <see href="http://purl.org/ontology/mo/time"></see></summary>
    let time = Namespaced_IRI.parse _namespace_name "time" |> NamespacedName
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
    let similar_to = Namespaced_IRI.parse _namespace_name "similar_to" |> NamespacedName
    /// <summary>
    /// Relates a performance to an involved singer
    /// <see href="http://purl.org/ontology/mo/singer"></see></summary>
    let singer = Namespaced_IRI.parse _namespace_name "singer" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/single"></see>
    /// </summary>
    let single = Namespaced_IRI.parse _namespace_name "single" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/soundtrack"></see>
    /// </summary>
    let soundtrack = Namespaced_IRI.parse _namespace_name "soundtrack" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/spokenword"></see>
    /// </summary>
    let spokenword = Namespaced_IRI.parse _namespace_name "spokenword" |> NamespacedName

    /// <summary>
    /// Used to relate an artist doing long-time instrumental or vocal support for another artist.
    /// <see href="http://purl.org/ontology/mo/supporting_musician"></see></summary>
    let supporting_musician =
        Namespaced_IRI.parse _namespace_name "supporting_musician" |> NamespacedName

    /// <summary>
    ///
    ///         Rate of speed or pace of music. Tempo markings are traditionally given in Italian;
    ///         common markings include: grave (solemn; very, very slow); largo (broad; very slow);
    ///         adagio (quite slow); andante (a walking pace); moderato (moderate); allegro (fast; cheerful);
    ///         vivace (lively); presto (very fast); accelerando (getting faster); ritardando (getting slower);
    ///         and a tempo (in time; returning to the original pace).
    ///
    /// <see href="http://purl.org/ontology/mo/tempo"></see></summary>
    let tempo = Namespaced_IRI.parse _namespace_name "tempo" |> NamespacedName
    /// <summary>
    /// Associates lyrics with their text.
    /// <see href="http://purl.org/ontology/mo/text"></see></summary>
    let text = Namespaced_IRI.parse _namespace_name "text" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/trackNum"></see>
    /// </summary>
    let trackNum = Namespaced_IRI.parse _namespace_name "trackNum" |> NamespacedName

    /// <summary>
    /// Indicates the position of a track on a record medium (a CD, etc.).
    /// <see href="http://purl.org/ontology/mo/track_number"></see></summary>
    let track_number =
        Namespaced_IRI.parse _namespace_name "track_number" |> NamespacedName

    /// <summary>
    /// The track count of a record
    /// <see href="http://purl.org/ontology/mo/track_count"></see></summary>
    let track_count =
        Namespaced_IRI.parse _namespace_name "track_count" |> NamespacedName

    /// <summary>
    /// Indicates that a work or the expression of a work has translated or transliterated into another expression of a work.
    /// <see href="http://purl.org/ontology/mo/translation_of"></see></summary>
    let translation_of =
        Namespaced_IRI.parse _namespace_name "translation_of" |> NamespacedName

    /// <summary>
    /// Indicates a musical work or the expression of a musical work that is a tribute to an artist - normally consisting of music being composed by the artist but performed by other artists.
    /// <see href="http://purl.org/ontology/mo/tribute_to"></see></summary>
    let tribute_to = Namespaced_IRI.parse _namespace_name "tribute_to" |> NamespacedName
    /// <summary>
    ///
    ///         Indicates the TRMID of a track.
    ///         TRM IDs are MusicBrainz' old AudioFingerprinting system.
    ///         TRM (TRM Recognizes Music) IDs are (somewhat) unique ids that represent
    ///         the audio signature of a musical piece (see AudioFingerprint).
    ///
    /// <see href="http://purl.org/ontology/mo/trmid"></see></summary>
    let trmid = Namespaced_IRI.parse _namespace_name "trmid" |> NamespacedName
    /// <summary>
    /// UPC stands for "Universal Product Code", which was the original barcode used in the United States and Canada. The UPC (now officially EAN.UCC-12 is a numerical method of identifying products without redundancy worldwide for all types of products in the retail sector. The EAN is a superset of the original UPC increasing the digits to 13 with the prefix 0 reserved for UPC. As of 2005, manufacturers are only allowed to use the new 13-digit codes on their items, rather than having two separate numbers.
    /// <see href="http://purl.org/ontology/mo/upc"></see></summary>
    let upc = Namespaced_IRI.parse _namespace_name "upc" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/usedInPerformance"></see>
    /// </summary>
    let usedInPerformance =
        Namespaced_IRI.parse _namespace_name "usedInPerformance" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/usedInRecording"></see>
    /// </summary>
    let usedInRecording =
        Namespaced_IRI.parse _namespace_name "usedInRecording" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/usesSound"></see>
    /// </summary>
    let usesSound = Namespaced_IRI.parse _namespace_name "usesSound" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ontology/mo/usesWork"></see>
    /// </summary>
    let usesWork = Namespaced_IRI.parse _namespace_name "usesWork" |> NamespacedName
    /// <summary>
    /// A person, a group of person or an organization wanting an exemplar of a single manifestation.
    /// <see href="http://purl.org/ontology/mo/want_item"></see></summary>
    let want_item = Namespaced_IRI.parse _namespace_name "want_item" |> NamespacedName
    /// <summary>
    ///
    ///         Used to link an work, an expression of a work, a manifestation of a work,
    ///         a person, an instrument or a musical genre to its corresponding WikiPedia page.
    ///         The full URL should be used, not just the WikiName.
    ///
    /// <see href="http://purl.org/ontology/mo/wikipedia"></see></summary>
    let wikipedia = Namespaced_IRI.parse _namespace_name "wikipedia" |> NamespacedName
