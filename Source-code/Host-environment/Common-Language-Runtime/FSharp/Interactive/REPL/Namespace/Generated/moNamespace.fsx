#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module mo =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/ontology/mo/" "mo"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : activity^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         An activity period, defining when an artist was musically active.
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/Activity">mo:Activity</a>
    /// </summary>
    let Activity = _prefixId.prefix "Activity"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : analogue signal^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         An analog signal.
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/AnalogSignal">mo:AnalogSignal</a>
    /// </summary>
    let AnalogSignal = _prefixId.prefix "AnalogSignal"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : arrangement^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         An arrangement event.
    ///         Takes as agent the arranger, and produces a score (informational object, not the actually published score).
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/Arrangement">mo:Arrangement</a>
    /// </summary>
    let Arrangement = _prefixId.prefix "Arrangement"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : arranger^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/Arranger">mo:Arranger</a>
    /// </summary>
    let Arranger = _prefixId.prefix "Arranger"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : audio file^^xsd:string</para>
    ///   <para>rdfs:comment : An audio file, which may be available on a local file system or through http, ftp, etc.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/AudioFile">mo:AudioFile</a>
    /// </summary>
    let AudioFile = _prefixId.prefix "AudioFile"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : CD^^xsd:string</para>
    ///   <para>rdfs:comment : Compact Disc used as medium to record a musical manifestation.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/CD">mo:CD</a>
    /// </summary>
    let CD = _prefixId.prefix "CD"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : composer^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/Composer">mo:Composer</a>
    /// </summary>
    let Composer = _prefixId.prefix "Composer"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : composition^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         A composition event.
    ///         Takes as agent the composer himself.
    ///         It produces a MusicalWork, or a MusicalExpression (when the initial "product" is a score, for example), or both...
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/Composition">mo:Composition</a>
    /// </summary>
    let Composition = _prefixId.prefix "Composition"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : conductor^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/Conductor">mo:Conductor</a>
    /// </summary>
    let Conductor = _prefixId.prefix "Conductor"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : corporate body^^xsd:string</para>
    ///   <para>rdfs:comment : Organization or group of individuals and/or other organizations involved in the music market.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/CorporateBody">mo:CorporateBody</a>
    /// </summary>
    let CorporateBody = _prefixId.prefix "CorporateBody"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : DAT^^xsd:string</para>
    ///   <para>rdfs:comment : Digital Audio Tape used as medium to record a musical manifestation.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/DAT">mo:DAT</a>
    /// </summary>
    let DAT = _prefixId.prefix "DAT"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : DCC^^xsd:string</para>
    ///   <para>rdfs:comment : Digital Compact Cassette used as medium to record a musical manifestation.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/DCC">mo:DCC</a>
    /// </summary>
    let DCC = _prefixId.prefix "DCC"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : DVDA^^xsd:string</para>
    ///   <para>rdfs:comment : DVD-Audio used as medium to record a musical manifestation.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/DVDA">mo:DVDA</a>
    /// </summary>
    let DVDA = _prefixId.prefix "DVDA"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : digital signal^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         A digital signal
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/DigitalSignal">mo:DigitalSignal</a>
    /// </summary>
    let DigitalSignal = _prefixId.prefix "DigitalSignal"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : ED2K^^xsd:string</para>
    ///   <para>rdfs:comment : Something available on the E-Donkey peer-2-peer filesharing network^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/ED2K">mo:ED2K</a>
    /// </summary>
    let ED2K = _prefixId.prefix "ED2K"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : Festival^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         A festival - musical/artistic event lasting several days, like Glastonbury, Rock Am Ring...
    ///         We migth decompose this event (which is in fact just a classification of the space/time region related to
    ///         a particular festival) using hasSubEvent in several performances at different space/time.
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/Festival">mo:Festival</a>
    /// </summary>
    let Festival = _prefixId.prefix "Festival"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : Genre^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         An expressive style of music.
    ///
    ///         Any taxonomy can be plug-in here. You can either define a genre by yourself, like this:
    ///
    ///         :mygenre a mo:Genre; dc:title "electro rock".
    ///
    ///         Or you can refer to a DBPedia genre (such as http://dbpedia.org/resource/Baroque_music), allowing semantic web
    ///         clients to access easily really detailed structured information about the genre you are refering to.
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/Genre">mo:Genre</a>
    /// </summary>
    let Genre = _prefixId.prefix "Genre"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : Instrument^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Any of various devices or contrivances that can be used to produce musical tones or sound.
    ///
    ///         Any taxonomy can be used to subsume this concept. The default one is one extracted by Ivan Herman
    ///         from the Musicbrainz instrument taxonomy, conforming to SKOS. This concept holds a seeAlso link
    ///         towards this taxonomy.
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/Instrument">mo:Instrument</a>
    /// </summary>
    let Instrument = _prefixId.prefix "Instrument"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : instrumentation^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Instrumentation deals with the techniques of writing music for a specific instrument,
    ///         including the limitations of the instrument, playing techniques and idiomatic handling of the instrument.
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/Instrumentation">mo:Instrumentation</a>
    /// </summary>
    let Instrumentation = _prefixId.prefix "Instrumentation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : label^^xsd:string</para>
    ///   <para>rdfs:comment : Trade name of a company that produces musical works or expression of musical works.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/Label">mo:Label</a>
    /// </summary>
    let Label = _prefixId.prefix "Label"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : libretto^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///                 Libretto
    ///         ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/Libretto">mo:Libretto</a>
    /// </summary>
    let Libretto = _prefixId.prefix "Libretto"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : listened^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/Listener">mo:Listener</a>
    /// </summary>
    let Listener = _prefixId.prefix "Listener"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : lyrics^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Lyrics
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/Lyrics">mo:Lyrics</a>
    /// </summary>
    let Lyrics = _prefixId.prefix "Lyrics"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : MD^^xsd:string</para>
    ///   <para>rdfs:comment : Mini Disc used as medium to record a musical manifestation.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/MD">mo:MD</a>
    /// </summary>
    let MD = _prefixId.prefix "MD"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : MagneticTape^^xsd:string</para>
    ///   <para>rdfs:comment : Magnetic analogue tape used as medium to record a musical manifestation.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/MagneticTape">mo:MagneticTape</a>
    /// </summary>
    let MagneticTape = _prefixId.prefix "MagneticTape"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : Medium^^xsd:string</para>
    ///   <para>rdfs:comment : A means or instrumentality for storing or communicating musical manifestation.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/Medium">mo:Medium</a>
    /// </summary>
    let Medium = _prefixId.prefix "Medium"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : membership^^xsd:string</para>
    ///   <para>rdfs:comment : A membership event, where one or several people belongs to a group during a particular time period.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/Membership">mo:Membership</a>
    /// </summary>
    let Membership = _prefixId.prefix "Membership"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : movement^^xsd:string</para>
    ///   <para>rdfs:comment : A movement is a self-contained part of a musical work. While individual or selected movements from a composition are sometimes performed separately, a performance of the complete work requires all the movements to be performed in succession.
    ///
    /// Often a composer attempts to interrelate the movements thematically, or sometimes in more subtle ways, in order that the individual
    /// movements exert a cumulative effect. In some forms, composers sometimes link the movements, or ask for them to be played without a
    /// pause between them.
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/Movement">mo:Movement</a>
    /// </summary>
    let Movement = _prefixId.prefix "Movement"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : music artist^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         A person or a group of people (or a computer :-) ), whose musical
    ///         creative work shows sensitivity and imagination
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/MusicArtist">mo:MusicArtist</a>
    /// </summary>
    let MusicArtist = _prefixId.prefix "MusicArtist"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : music group^^xsd:string</para>
    ///   <para>rdfs:comment : Group of musicians, or musical ensemble, usually popular or folk, playing parts of or improvising off of a musical arrangement. ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/MusicGroup">mo:MusicGroup</a>
    /// </summary>
    let MusicGroup = _prefixId.prefix "MusicGroup"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : musical expression^^xsd:string</para>
    ///   <para>rdfs:comment :
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
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/MusicalExpression">mo:MusicalExpression</a>
    /// </summary>
    let MusicalExpression = _prefixId.prefix "MusicalExpression"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : MusicalItem^^xsd:string</para>
    ///   <para>rdfs:comment : A single exemplar of a musical expression.
    ///
    /// For example, it could be a single exemplar of a CD. This is normally an single object (a CD) possessed by somebody.
    ///
    /// From the FRBR final report: The entity defined as item is a concrete entity. It is in many instances a single physical object (e.g., a copy of a one-volume monograph, a single audio cassette, etc.). There are instances, however, where the entity defined as item comprises more than one physical object (e.g., a monograph issued as two separately bound volumes, a recording issued on three separate compact discs, etc.).
    ///
    /// In terms of intellectual content and physical form, an item exemplifying a manifestation is normally the same as the manifestation itself. However, variations may occur from one item to another, even when the items exemplify the same manifestation, where those variations are the result of actions external to the intent of the producer of the manifestation (e.g., damage occurring after the item was produced, binding performed by a library, etc.).
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/MusicalItem">mo:MusicalItem</a>
    /// </summary>
    let MusicalItem = _prefixId.prefix "MusicalItem"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : musical manifestation^^xsd:string</para>
    ///   <para>rdfs:comment :
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
    /// ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/MusicalManifestation">mo:MusicalManifestation</a>
    /// </summary>
    let MusicalManifestation = _prefixId.prefix "MusicalManifestation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : musical work^^xsd:string</para>
    ///   <para>rdfs:comment :
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
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/MusicalWork">mo:MusicalWork</a>
    /// </summary>
    let MusicalWork = _prefixId.prefix "MusicalWork"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : orchestration^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///             Orchestration includes, in addition to instrumentation, the handling of groups of instruments and their balance and interaction.
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/Orchestration">mo:Orchestration</a>
    /// </summary>
    let Orchestration = _prefixId.prefix "Orchestration"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : performance^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         A performance event.
    ///         It might include as agents performers, engineers, conductors, or even listeners.
    ///         It might include as factors a score, a MusicalWork, musical instruments.
    ///         It might produce a sound:-)
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/Performance">mo:Performance</a>
    /// </summary>
    let Performance = _prefixId.prefix "Performance"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : performer^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/Performer">mo:Performer</a>
    /// </summary>
    let Performer = _prefixId.prefix "Performer"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : published libretto^^xsd:string</para>
    ///   <para>rdfs:comment : A published libretto^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/PublishedLibretto">mo:PublishedLibretto</a>
    /// </summary>
    let PublishedLibretto = _prefixId.prefix "PublishedLibretto"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : published lyrics^^xsd:string</para>
    ///   <para>rdfs:comment : Published lyrics, as a book or as a text file, for example^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/PublishedLyrics">mo:PublishedLyrics</a>
    /// </summary>
    let PublishedLyrics = _prefixId.prefix "PublishedLyrics"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : published score^^xsd:string</para>
    ///   <para>rdfs:comment : A published score (subclass of MusicalManifestation)^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/PublishedScore">mo:PublishedScore</a>
    /// </summary>
    let PublishedScore = _prefixId.prefix "PublishedScore"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : record^^xsd:string</para>
    ///   <para>rdfs:comment : A published record (manifestation which first aim is to render the product of a recording)^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/Record">mo:Record</a>
    /// </summary>
    let Record = _prefixId.prefix "Record"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : recording^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         A recording event.
    ///         Takes a sound as a factor to produce a signal (analog or digital).
    ///         The location of such events (if any) is the actual location of the corresponding
    ///         microphone or the "recording device".
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/Recording">mo:Recording</a>
    /// </summary>
    let Recording = _prefixId.prefix "Recording"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : recording session^^xsd:string</para>
    ///   <para>rdfs:comment : A set of performances/recordings/mastering events. This event can be decomposed in its constituent events using event:sub_event^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/RecordingSession">mo:RecordingSession</a>
    /// </summary>
    let RecordingSession = _prefixId.prefix "RecordingSession"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : release^^xsd:string</para>
    ///   <para>rdfs:comment : A specific release, with barcode, box, liner notes, cover art, and a number of records^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/Release">mo:Release</a>
    /// </summary>
    let Release = _prefixId.prefix "Release"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : release event^^xsd:string</para>
    ///   <para>rdfs:comment : A release event, in a particular place (e.g. a country) at a particular time. Other factors of this event might include cover art, liner notes, box, etc. or a release grouping all these.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/ReleaseEvent">mo:ReleaseEvent</a>
    /// </summary>
    let ReleaseEvent = _prefixId.prefix "ReleaseEvent"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : release status^^xsd:string</para>
    ///   <para>rdfs:comment : Musical manifestation release status.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/ReleaseStatus">mo:ReleaseStatus</a>
    /// </summary>
    let ReleaseStatus = _prefixId.prefix "ReleaseStatus"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : Release type^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Release type of a particular manifestation, such as "album" or "interview"...
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/ReleaseType">mo:ReleaseType</a>
    /// </summary>
    let ReleaseType = _prefixId.prefix "ReleaseType"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : SACD^^xsd:string</para>
    ///   <para>rdfs:comment : Super Audio Compact Disc used as medium to record a musical manifestation.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/SACD">mo:SACD</a>
    /// </summary>
    let SACD = _prefixId.prefix "SACD"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : score^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Here, we are dealing with the informational object (the MusicalExpression), not the actually "published" score.
    ///         This may be, for example, the product of an arrangement process.
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/Score">mo:Score</a>
    /// </summary>
    let Score = _prefixId.prefix "Score"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : Show^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         A show - a musical event lasting several days, in a particular venue. Examples can be
    ///         "The Magic Flute" at the Opera Bastille, August 2005, or a musical in the west end...
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/Show">mo:Show</a>
    /// </summary>
    let Show = _prefixId.prefix "Show"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : signal^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         A subclass of MusicalExpression, representing a signal, for example a master signal produced by a performance and a recording.
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/Signal">mo:Signal</a>
    /// </summary>
    let Signal = _prefixId.prefix "Signal"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : signal group^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         A musical expression representing a group of signals, for example a set of masters resulting from a whole recording/mastering session.
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/SignalGroup">mo:SignalGroup</a>
    /// </summary>
    let SignalGroup = _prefixId.prefix "SignalGroup"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : solo music artist^^xsd:string</para>
    ///   <para>rdfs:comment : Single person whose musical creative work shows sensitivity and imagination.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/SoloMusicArtist">mo:SoloMusicArtist</a>
    /// </summary>
    let SoloMusicArtist = _prefixId.prefix "SoloMusicArtist"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : sound^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         A subclass of MusicalExpression, representing a sound. Realisation of a MusicalWork during a musical Performance.
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/Sound">mo:Sound</a>
    /// </summary>
    let Sound = _prefixId.prefix "Sound"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : sound engineer^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/SoundEngineer">mo:SoundEngineer</a>
    /// </summary>
    let SoundEngineer = _prefixId.prefix "SoundEngineer"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : Stream^^xsd:string</para>
    ///   <para>rdfs:comment : Transmission over a network  used as medium to broadcast a musical manifestation^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/Stream">mo:Stream</a>
    /// </summary>
    let Stream = _prefixId.prefix "Stream"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : Torrent^^xsd:string</para>
    ///   <para>rdfs:comment : Something available on the Bittorrent peer-2-peer filesharing network^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/Torrent">mo:Torrent</a>
    /// </summary>
    let Torrent = _prefixId.prefix "Torrent"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : track^^xsd:string</para>
    ///   <para>rdfs:comment : A track on a particular record^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/Track">mo:Track</a>
    /// </summary>
    let Track = _prefixId.prefix "Track"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : transcription^^xsd:string</para>
    ///   <para>rdfs:comment : Transcription event^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/Transcription">mo:Transcription</a>
    /// </summary>
    let Transcription = _prefixId.prefix "Transcription"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : Vinyl^^xsd:string</para>
    ///   <para>rdfs:comment : Vinyl used as medium to record a musical manifestation^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/Vinyl">mo:Vinyl</a>
    /// </summary>
    let Vinyl = _prefixId.prefix "Vinyl"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : activity^^xsd:string</para>
    ///   <para>rdfs:comment : Relates an artist to an activity period^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/activity">mo:activity</a>
    /// </summary>
    let activity = _prefixId.prefix "activity"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : activity end^^xsd:string</para>
    ///   <para>rdfs:comment : Relates an artist to a date at which its activity ended^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/activity_end">mo:activity_end</a>
    /// </summary>
    let activity_end = _prefixId.prefix "activity_end"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : activity start^^xsd:string</para>
    ///   <para>rdfs:comment : Relates an artist to a date at which its activity started^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/activity_start">mo:activity_start</a>
    /// </summary>
    let activity_start = _prefixId.prefix "activity_start"
    let album = _prefixId.prefix "album"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : amazon_asin^^xsd:string</para>
    ///   <para>rdfs:comment : Used to link a work or the expression of a work to its corresponding Amazon ASINs page.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/amazon_asin">mo:amazon_asin</a>
    /// </summary>
    let amazon_asin = _prefixId.prefix "amazon_asin"
    /// <summary>
    ///   <para>rdfs:label : arranged in^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Associates a work to an arrangement event where it was arranged
    ///     ^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/arranged_in">mo:arranged_in</a>
    /// </summary>
    let arranged_in = _prefixId.prefix "arranged_in"
    /// <summary>
    ///   <para>rdfs:label : arrangement of^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///                 Associates an arrangement event to a work
    ///         ^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/arrangement_of">mo:arrangement_of</a>
    /// </summary>
    let arrangement_of = _prefixId.prefix "arrangement_of"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : artist^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a membership event with the corresponding artist^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/artist">mo:artist</a>
    /// </summary>
    let artist = _prefixId.prefix "artist"
    let audiobook = _prefixId.prefix "audiobook"
    /// <summary>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/availableAs">mo:availableAs</a>
    /// </summary>
    let availableAs = _prefixId.prefix "availableAs"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Relates a musical manifestation to a musical item (this album, and my particular cd). By using
    ///         this property, there is no assumption on wether the full content is available on the linked item.
    ///         To be explicit about this, you can use a sub-property, such as mo:item (the full manifestation
    ///         is available on that item) or mo:preview (only a part of the manifestation is available on
    ///         that item).
    ///
    ///         This is a subproperty of frbr:examplar.
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/available_as">mo:available_as</a>
    /// </summary>
    let available_as = _prefixId.prefix "available_as"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : biography^^xsd:string</para>
    ///   <para>rdfs:comment : Used to link an artist to their online biography.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/biography">mo:biography</a>
    /// </summary>
    let biography = _prefixId.prefix "biography"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Associates a digital signal to the number a bits used to encode one sample. Range is xsd:int.
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/bitsPerSample">mo:bitsPerSample</a>
    /// </summary>
    let bitsPerSample = _prefixId.prefix "bitsPerSample"
    let bootleg = _prefixId.prefix "bootleg"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : bpm^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Indicates the BPM of a MusicalWork or a particular Performance
    ///         Beats per minute: the pace of music measured by the number of beats occurring in 60 seconds.
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/bpm">mo:bpm</a>
    /// </summary>
    let bpm = _prefixId.prefix "bpm"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : catalogue number^^xsd:string</para>
    ///   <para>rdfs:comment : Links a release with the corresponding catalogue number^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/catalogue_number">mo:catalogue_number</a>
    /// </summary>
    let catalogue_number = _prefixId.prefix "catalogue_number"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Associates a signal to the number of channels it holds (mono --&gt; 1, stereo --&gt; 2). Range is xsd:int.
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/channels">mo:channels</a>
    /// </summary>
    let channels = _prefixId.prefix "channels"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : collaborated_with^^xsd:string</para>
    ///   <para>rdfs:comment : Used to relate two collaborating people on a work.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/collaborated_with">mo:collaborated_with</a>
    /// </summary>
    let collaborated_with = _prefixId.prefix "collaborated_with"
    let compilation = _prefixId.prefix "compilation"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : compilation_of^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that a musical manifestation is a compilation of several Signals.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/compilation_of">mo:compilation_of</a>
    /// </summary>
    let compilation_of = _prefixId.prefix "compilation_of"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : compiled^^xsd:string</para>
    ///   <para>rdfs:comment : Used to relate an person or a group of person who compiled the manifestation of a musical work.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/compiled">mo:compiled</a>
    /// </summary>
    let compiled = _prefixId.prefix "compiled"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : compiler^^xsd:string</para>
    ///   <para>rdfs:comment : Used to relate the manifestation of a musical work to a person or a group of person who compiled it.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/compiler">mo:compiler</a>
    /// </summary>
    let compiler = _prefixId.prefix "compiler"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : composed in^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Associates a MusicalWork to the Composition event pertaining
    ///         to its creation. For example, I might use this property to associate
    ///         the Magic Flute to its composition event, occuring during 1782 and having as
    ///         a mo:composer Mozart.
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/composed_in">mo:composed_in</a>
    /// </summary>
    let composed_in = _prefixId.prefix "composed_in"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : composer^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Associates a composition event to the actual composer. For example,
    ///         this property could link the event corresponding to the composition of the
    ///         Magic Flute in 1782 to Mozart himself (who obviously has a FOAF profile:-) ).
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/composer">mo:composer</a>
    /// </summary>
    let composer = _prefixId.prefix "composer"
    /// <summary>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : conducted^^xsd:string</para>
    ///   <para>rdfs:comment : Relates agents to the performances they were conducting^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/conducted">mo:conducted</a>
    /// </summary>
    let conducted = _prefixId.prefix "conducted"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a performance to the conductor involved^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/conductor">mo:conductor</a>
    /// </summary>
    let conductor = _prefixId.prefix "conductor"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : contains_sample_from^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Relates a signal to another signal, which has been sampled.
    ///         ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/contains_sample_from">mo:contains_sample_from</a>
    /// </summary>
    let contains_sample_from = _prefixId.prefix "contains_sample_from"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : derived from^^xsd:string</para>
    ///   <para>rdfs:comment : A related signal from which the described signal is derived.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/derived_from">mo:derived_from</a>
    /// </summary>
    let derived_from = _prefixId.prefix "derived_from"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : discography^^xsd:string</para>
    ///   <para>rdfs:comment : Used to links an artist to an online discography of their musical works. The discography should provide a summary of each released musical work of the artist.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/discography">mo:discography</a>
    /// </summary>
    let discography = _prefixId.prefix "discography"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : discogs^^xsd:string</para>
    ///   <para>rdfs:comment : Used to link a musical work or the expression of a musical work, an artist or a corporate body to to its corresponding Discogs page.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/discogs">mo:discogs</a>
    /// </summary>
    let discogs = _prefixId.prefix "discogs"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : djmix_of^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that all (or most of) the tracks of a musical work or the expression of a musical work were mixed together from all (or most of) the tracks from another musical work or the expression of a musical work to form a so called DJ-Mix.
    ///
    /// The tracks might have been altered by pitching (so that the tempo of one track matches the tempo of the following track) and fading (so that one track blends in smoothly with the other). If the tracks have been more substantially altered, the "mo:remix" relationship type is more appropriate. ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/djmix_of">mo:djmix_of</a>
    /// </summary>
    let djmix_of = _prefixId.prefix "djmix_of"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : djmixed^^xsd:string</para>
    ///   <para>rdfs:comment : Used to relate an artist who djmixed a musical work or the expression of a musical work.
    ///
    /// The artist usually selected the tracks, chose their sequence, and slightly changed them by fading (so that one track blends in smoothly with the other) or pitching (so that the tempo of one track matches the tempo of the following track). This applies to a 'Mixtape' in which all tracks were DJ-mixed together into one single long track. ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/djmixed">mo:djmixed</a>
    /// </summary>
    let djmixed = _prefixId.prefix "djmixed"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : djmixed_by^^xsd:string</para>
    ///   <para>rdfs:comment : Used to relate a work or the expression of a work to an artist who djmixed it.
    ///
    /// The artist usually selected the tracks, chose their sequence, and slightly changed them by fading (so that one track blends in smoothly with the other) or pitching (so that the tempo of one track matches the tempo of the following track). This applies to a 'Mixtape' in which all tracks were DJ-mixed together into one single long track. ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/djmixed_by">mo:djmixed_by</a>
    /// </summary>
    let djmixed_by = _prefixId.prefix "djmixed_by"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : download^^xsd:string</para>
    ///   <para>rdfs:comment :
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
    ///         ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/download">mo:download</a>
    /// </summary>
    let download = _prefixId.prefix "download"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:comment : The duration of a track or a signal in ms^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/duration">mo:duration</a>
    /// </summary>
    let duration = _prefixId.prefix "duration"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : ean^^xsd:string</para>
    ///   <para>rdfs:comment : The European Article Number (EAN) is a universal identifier for products, commonly printed in form of barcodes on them. The numbers represented by those codes can either be 8 or 13 digits long, with the 13-digit-version being most common. EANs form a superset of the North American Universal Product Code (UPC) as every UPC can be made an EAN by adding a leading zero to it. Additionally every EAN is also a Japanese Article Number (JAN). The identifiers were formerly assigned by EAN International which merged with Uniform Code Council (UCC, the guys behind the UPCs) and Electronic Commerce Council of Canada (ECCC) to become GS1. ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/ean">mo:ean</a>
    /// </summary>
    let ean = _prefixId.prefix "ean"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : encodes^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Relates a MusicalItem (a track on a particular CD, an audio file, a stream somewhere) to the signal it encodes.
    ///
    ///         This is usually a lower-resolution version of the master signal (issued from a Recording event).
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/encodes">mo:encodes</a>
    /// </summary>
    let encodes = _prefixId.prefix "encodes"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : encoding^^xsd:string</para>
    ///   <para>rdfs:comment : Method used to convert analog electronic signals into digital format such as "MP3 CBR @ 128kbps", "OGG @ 160kbps", "FLAC", etc.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/encoding">mo:encoding</a>
    /// </summary>
    let encoding = _prefixId.prefix "encoding"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a performance or a recording to the engineer involved^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/engineer">mo:engineer</a>
    /// </summary>
    let engineer = _prefixId.prefix "engineer"
    /// <summary>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : engineered^^xsd:string</para>
    ///   <para>rdfs:comment : Relates agents to the performances/recordings they were engineering in^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/engineered">mo:engineered</a>
    /// </summary>
    let engineered = _prefixId.prefix "engineered"
    let ep = _prefixId.prefix "ep"
    /// <summary>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/eventHomePage">mo:eventHomePage</a>
    /// </summary>
    let eventHomePage = _prefixId.prefix "eventHomePage"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : event homepage^^xsd:string</para>
    ///   <para>rdfs:comment : Links a particular event to a web page^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/event_homepage">mo:event_homepage</a>
    /// </summary>
    let event_homepage = _prefixId.prefix "event_homepage"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : exchange_item^^xsd:string</para>
    ///   <para>rdfs:comment : A person, a group of person or an organization exchanging an exemplar of a single manifestation.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/exchange_item">mo:exchange_item</a>
    /// </summary>
    let exchange_item = _prefixId.prefix "exchange_item"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : fanpage^^xsd:string</para>
    ///   <para>rdfs:comment : Used to link an artist to a fan-created webpage devoted to that artist.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/fanpage">mo:fanpage</a>
    /// </summary>
    let fanpage = _prefixId.prefix "fanpage"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : free download^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         This property can be used to link from a person to the website where they make their works available, or from
    ///         a manifestation (a track or an album, for example) to a web page where it is available for free
    ///         download.
    ///
    ///         This property MUST be used only if the content is just available through a web page (holding, for example
    ///         a Flash application) - it is better to link to actual content directly through the use of mo:available_as and
    ///         mo:Stream, mo:Torrent or mo:ED2K, etc. Therefore, Semantic Web user agents that don't know how to read HTML and even
    ///         less to rip streams from Flash applications can still access the audio content.
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/free_download">mo:free_download</a>
    /// </summary>
    let free_download = _prefixId.prefix "free_download"
    /// <summary>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/freedownload">mo:freedownload</a>
    /// </summary>
    let freedownload = _prefixId.prefix "freedownload"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : genre^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Associates an event (like a performance or a recording) to a particular musical genre.
    ///         Further version of this property may also include works and scores in the domain.
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/genre">mo:genre</a>
    /// </summary>
    let genre = _prefixId.prefix "genre"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : GRid^^xsd:string</para>
    ///   <para>rdfs:comment : The Global Release Identifier (GRid) is a system for uniquely identifying Releases of music over electronic networks (that is, online stores where you can buy music as digital files). As that it can be seen as the equivalent of the BarCode (or more correctly the GTIN) as found on physical releases of music. Like the ISRC (a code for identifying single recordings as found on releases) it was developed by the IFPI but it does not appear to be a standard of the ISO.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/grid">mo:grid</a>
    /// </summary>
    let grid = _prefixId.prefix "grid"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : group^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a membership event with the corresponding group^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/group">mo:group</a>
    /// </summary>
    let group = _prefixId.prefix "group"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : gtin^^xsd:string</para>
    ///   <para>rdfs:comment : GTIN is a grouping term for EANs and UPCs. In common speech those are called barcodes although the barcodes are just a representation of those identifying numbers.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/gtin">mo:gtin</a>
    /// </summary>
    let gtin = _prefixId.prefix "gtin"
    /// <summary>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/has_track">mo:has_track</a>
    /// </summary>
    let has_track = _prefixId.prefix "has_track"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : headliner^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a performance to the headliner(s) involved^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/headliner">mo:headliner</a>
    /// </summary>
    let headliner = _prefixId.prefix "headliner"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : homepage^^xsd:string</para>
    ///   <para>rdfs:comment : Links an artist, a record, etc. to a corresponding web page^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/homepage">mo:homepage</a>
    /// </summary>
    let homepage = _prefixId.prefix "homepage"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : image^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates a pictorial image (JPEG, GIF, PNG, Etc.) of a musical work, the expression of a musical work, the manifestation of a work or the examplar of a manifestation.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/image">mo:image</a>
    /// </summary>
    let image = _prefixId.prefix "image"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : imdb^^xsd:string</para>
    ///   <para>rdfs:comment : Used to link an artist, a musical work or the expression of a musical work to their equivalent page on IMDb, the InternetMovieDatabase.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/imdb">mo:imdb</a>
    /// </summary>
    let imdb = _prefixId.prefix "imdb"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a performance to a musical instrument involved^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/instrument">mo:instrument</a>
    /// </summary>
    let instrument = _prefixId.prefix "instrument"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : has interpeter^^xsd:string</para>
    ///   <para>rdfs:comment : Adds an involved music artist, who interpreted, remixed, or otherwise modified an existing signal, which resulted in the signal that is here the subject of this relation.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/interpreter">mo:interpreter</a>
    /// </summary>
    let interpreter = _prefixId.prefix "interpreter"
    let interview = _prefixId.prefix "interview"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : ipi^^xsd:string</para>
    ///   <para>rdfs:comment : The Interested Parties Information Code (IPI) is an ISO standard similar to ISBNs for identifying the people or groups with some involvement with a particular musical work / compositions.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/ipi">mo:ipi</a>
    /// </summary>
    let ipi = _prefixId.prefix "ipi"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : ismn^^xsd:string</para>
    ///   <para>rdfs:comment : The International Standard Music Number (ISMN) is an ISO standard similar to ISBNs for identifying printed music publications^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/ismn">mo:ismn</a>
    /// </summary>
    let ismn = _prefixId.prefix "ismn"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : isrc^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///     The ISRC (International Standard Recording Code) is the international identification system for sound recordings and music videorecordings.
    ///     Each ISRC is a unique and permanent identifier for a specific recording which can be permanently encoded into a product as its digital fingerprint.
    ///     Encoded ISRC provide the means to automatically identify recordings for royalty payments.
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/isrc">mo:isrc</a>
    /// </summary>
    let isrc = _prefixId.prefix "isrc"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : iswc^^xsd:string</para>
    ///   <para>rdfs:comment : Links a musical work to the corresponding ISWC number^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/iswc">mo:iswc</a>
    /// </summary>
    let iswc = _prefixId.prefix "iswc"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///                 Relates a musical manifestation to a musical item (this album, and my particular cd) holding the
    ///                 entire manifestation, and not just a part of it.
    ///         ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/item">mo:item</a>
    /// </summary>
    let item = _prefixId.prefix "item"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : key^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Indicated the key used by the musicians during a performance, or the key of a MusicalWork.
    ///         Any of 24 major or minor diatonic scales that provide the tonal framework for a piece of music.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/key">mo:key</a>
    /// </summary>
    let key = _prefixId.prefix "key"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : label^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a release event with the label releasing the record^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/label">mo:label</a>
    /// </summary>
    let label = _prefixId.prefix "label"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : lc^^xsd:string</para>
    ///   <para>rdfs:comment : The Label Code (LC) was introduced in 1977 by the IFPI (International Federation of Phonogram and Videogram Industries) in order to unmistakably identify the different record labels (see Introduction, Record labels) for rights purposes. The Label Code consists historically of 4 figures, presently being extended to 5 figures, preceded by LC and a dash (e.g. LC-0193 = Electrola; LC-0233 = His Master's Voice). Note that the number of countries using the LC is limited, and that the code given on the item is not always accurate.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/lc">mo:lc</a>
    /// </summary>
    let lc = _prefixId.prefix "lc"
    /// <summary>
    ///   <para>rdfs:label : level^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         This annotation property associates to a particular Music Ontology term the corresponding
    ///         expressiveness level. These levels can be:
    ///
    ///             - 1: Only editorial/Musicbrainz type information
    ///             - 2: Workflow information
    ///             - 3: Even decomposition
    ///
    ///         This property is mainly used for specification generation.
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/level">mo:level</a>
    /// </summary>
    let level = _prefixId.prefix "level"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : licence^^xsd:string</para>
    ///   <para>rdfs:comment : Used to link a work or the expression of a work to the license under which they can be manipulated (downloaded, modified, etc).
    ///
    /// This is usually used to link to a Creative Commons licence.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/licence">mo:licence</a>
    /// </summary>
    let licence = _prefixId.prefix "licence"
    /// <summary>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : listened^^xsd:string</para>
    ///   <para>rdfs:comment : Relates agents to the performances they were listening in^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/listened">mo:listened</a>
    /// </summary>
    let listened = _prefixId.prefix "listened"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a performance to the listener involved^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/listener">mo:listener</a>
    /// </summary>
    let listener = _prefixId.prefix "listener"
    let live = _prefixId.prefix "live"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : lyrics^^xsd:string</para>
    ///   <para>rdfs:comment : Associates lyrics with a musical work^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/lyrics">mo:lyrics</a>
    /// </summary>
    let lyrics = _prefixId.prefix "lyrics"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : mailorder^^xsd:string</para>
    ///   <para>rdfs:comment : Used to link a musical work or the expression of a musical work to a website where people can buy a copy of the musical manifestation.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/mailorder">mo:mailorder</a>
    /// </summary>
    let mailorder = _prefixId.prefix "mailorder"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : mashup_of^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that musical works or the expressions of a musical work were mashed up on this album or track.
    ///
    /// This means that two musical works or the expressions of a musical work by different artists are mixed together, over each other, or otherwise combined into a single musical work (usually by a third artist, the remixer).^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/mashup_of">mo:mashup_of</a>
    /// </summary>
    let mashup_of = _prefixId.prefix "mashup_of"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : has media type^^xsd:string</para>
    ///   <para>rdfs:comment : The mediatype (file format or MIME type, or physical medium) of a musical manifestation, e.g. a MP3, CD or vinyl.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/media_type">mo:media_type</a>
    /// </summary>
    let media_type = _prefixId.prefix "media_type"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : medley_of^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that a musical expression is a medley of several other musical expressions.
    ///
    /// This means that the orignial musical expression were rearranged to create a new musical expression in the form of a medley. ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/medley_of">mo:medley_of</a>
    /// </summary>
    let medley_of = _prefixId.prefix "medley_of"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : member^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Indicates a member of a musical group
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/member">mo:member</a>
    /// </summary>
    let member_ = _prefixId.prefix "member"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : member_of^^xsd:string</para>
    ///   <para>rdfs:comment : Inverse of the foaf:member property^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/member_of">mo:member_of</a>
    /// </summary>
    let member_of = _prefixId.prefix "member_of"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : membership^^xsd:string</para>
    ///   <para>rdfs:comment : Relates an agent with related membership events^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/membership">mo:membership</a>
    /// </summary>
    let membership = _prefixId.prefix "membership"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : meter^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a musical work or a score with its meter^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/meter">mo:meter</a>
    /// </summary>
    let meter = _prefixId.prefix "meter"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : has_movement^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that a musical work has movements^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/movement">mo:movement</a>
    /// </summary>
    let movement = _prefixId.prefix "movement"
    let movementNum = _prefixId.prefix "movementNum"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : movement number^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the position of a movement in a musical work.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/movement_number">mo:movement_number</a>
    /// </summary>
    let movement_number = _prefixId.prefix "movement_number"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : musicbrainz^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Linking an agent, a track or a record to its corresponding Musicbrainz page.
    ///         ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/musicbrainz">mo:musicbrainz</a>
    /// </summary>
    let musicbrainz = _prefixId.prefix "musicbrainz"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : Musicbrainz GUID^^xsd:string</para>
    ///   <para>rdfs:comment : Links an object to the corresponding Musicbrainz identifier^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/musicbrainz_guid">mo:musicbrainz_guid</a>
    /// </summary>
    let musicbrainz_guid = _prefixId.prefix "musicbrainz_guid"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : musicmoz^^xsd:string</para>
    ///   <para>rdfs:comment : Used to link an artist, a musical work or the expression of a musical work to its corresponding MusicMoz page.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/musicmoz">mo:musicmoz</a>
    /// </summary>
    let musicmoz = _prefixId.prefix "musicmoz"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : myspace^^xsd:string</para>
    ///   <para>rdfs:comment : Used to link a person to its corresponding MySpace page.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/myspace">mo:myspace</a>
    /// </summary>
    let myspace = _prefixId.prefix "myspace"
    let official = _prefixId.prefix "official"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : olga^^xsd:string</para>
    ///   <para>rdfs:comment : Used to link a track to a tabulature file for track in the On-Line Guitar Archive.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/olga">mo:olga</a>
    /// </summary>
    let olga = _prefixId.prefix "olga"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : onlinecommunity^^xsd:string</para>
    ///   <para>rdfs:comment : Used to link a person with an online community web page like a blog, a wiki, a forum, a livejournal page, Etc.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/onlinecommunity">mo:onlinecommunity</a>
    /// </summary>
    let onlinecommunity = _prefixId.prefix "onlinecommunity"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : opus^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Used to define a creative work, especially a musical composition numbered to designate the order of a composer's works.
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/opus">mo:opus</a>
    /// </summary>
    let opus = _prefixId.prefix "opus"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : origin^^xsd:string</para>
    ///   <para>rdfs:comment : Relates an artist to its geographic origin^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/origin">mo:origin</a>
    /// </summary>
    let origin = _prefixId.prefix "origin"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : other_release_of^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that two musical manifestations are essentially the same.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/other_release_of">mo:other_release_of</a>
    /// </summary>
    let other_release_of = _prefixId.prefix "other_release_of"
    /// <summary>
    ///   <para>rdfs:comment :
    ///                 Provide a link from an artist to a web page where all of that artist's musical work is available for some money,
    ///                 or a link from a manifestation (record/track, for example) to a web page providing a paid access to this manifestation.
    ///         ^^xsd:string</para>
    ///   <para>rdfs:label : paid download^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/paid_download">mo:paid_download</a>
    /// </summary>
    let paid_download = _prefixId.prefix "paid_download"
    /// <summary>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/paiddownload">mo:paiddownload</a>
    /// </summary>
    let paiddownload = _prefixId.prefix "paiddownload"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Associates a Performance to a musical work or an arrangement that is being used as a factor in it.
    ///         For example, I might use this property to attach the Magic Flute musical work to
    ///         a particular Performance.
    ///     ^^xsd:string</para>
    ///   <para>rdfs:label : performance of^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/performance_of">mo:performance_of</a>
    /// </summary>
    let performance_of = _prefixId.prefix "performance_of"
    /// <summary>
    ///   <para>rdfs:comment : Relates agents to the performances they were performing in^^xsd:string</para>
    ///   <para>rdfs:label : performed^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/performed">mo:performed</a>
    /// </summary>
    let performed = _prefixId.prefix "performed"
    /// <summary>
    ///   <para>rdfs:label : performed in^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Associates a Musical Work or an Score to Performances in which they were
    ///         a factor. For example, I might use this property in order to
    ///         associate the Magic Flute to a particular performance at the Opera
    ///         Bastille last year.^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/performed_in">mo:performed_in</a>
    /// </summary>
    let performed_in = _prefixId.prefix "performed_in"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a performance to the performers involved^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/performer">mo:performer</a>
    /// </summary>
    let performer = _prefixId.prefix "performer"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : possess_item^^xsd:string</para>
    ///   <para>rdfs:comment : A person, a group of person or an organization possessing an exemplar of a single manifestation.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/possess_item">mo:possess_item</a>
    /// </summary>
    let possess_item = _prefixId.prefix "possess_item"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///                 Relates a musical manifestation to a musical item (this album, and my particular cd), which holds
    ///                 a preview of the manifestation (eg. one track for an album, or a snippet for a track)
    ///         ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/preview">mo:preview</a>
    /// </summary>
    let preview = _prefixId.prefix "preview"
    /// <summary>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : preview download^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///                 This property can be used to link from a person to the website where they make previews of their works available, or from
    ///                 a manifestation (a track or an album, for example) to a web page where a preview download is available.
    ///
    ///                 This property MUST be used only if the content is just available through a web page (holding, for example
    ///                 a Flash application) - it is better to link to actual content directly through the use of mo:available_as and
    ///                 mo:Stream, mo:Torrent or mo:ED2K, etc. Therefore, Semantic Web user agents that don't know how to read HTML and even
    ///                 less to rip streams from Flash applications can still access the audio content.
    ///         ^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/preview_download">mo:preview_download</a>
    /// </summary>
    let preview_download = _prefixId.prefix "preview_download"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : primary instrument^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that an artist primarily plays an instrument, or that a member was primarily playing a particular instrument during his membership^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/primary_instrument">mo:primary_instrument</a>
    /// </summary>
    let primary_instrument = _prefixId.prefix "primary_instrument"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : produced^^xsd:string</para>
    ///   <para>rdfs:comment : Used to relate an person or a group of person who produced the manifestation of a work.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/produced">mo:produced</a>
    /// </summary>
    let produced = _prefixId.prefix "produced"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : produced score^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Associates an arrangement or a composition event to a score product (score here does not refer to a published score, but more
    ///         an abstract arrangement of a particular work).
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/produced_score">mo:produced_score</a>
    /// </summary>
    let produced_score = _prefixId.prefix "produced_score"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : produced signal^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///                 Associates a Recording to the outputted signal.
    ///         ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/produced_signal">mo:produced_signal</a>
    /// </summary>
    let produced_signal = _prefixId.prefix "produced_signal"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : produced signal group^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a recording session with a group of master signals produced by it.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/produced_signal_group">mo:produced_signal_group</a>
    /// </summary>
    let produced_signal_group = _prefixId.prefix "produced_signal_group"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : produced sound^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///                 Associates a Performance to a physical Sound that is being produced by it.
    ///         ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/produced_sound">mo:produced_sound</a>
    /// </summary>
    let produced_sound = _prefixId.prefix "produced_sound"
    /// <summary>
    ///   <para>rdfs:comment :
    ///                 Associates a composition event to the produced MusicalWork. For example,
    ///                 this property could link the event corresponding to the composition of the
    ///                 Magic Flute in 1782 to the Magic Flute musical work itself. This musical work
    ///                 can then be used in particular performances.
    ///         ^^xsd:string</para>
    ///   <para>rdfs:label : produced work^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/produced_work">mo:produced_work</a>
    /// </summary>
    let produced_work = _prefixId.prefix "produced_work"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : producer^^xsd:string</para>
    ///   <para>rdfs:comment : Used to relate the manifestation of a work to a person or a group of person who produced it.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/producer">mo:producer</a>
    /// </summary>
    let producer = _prefixId.prefix "producer"
    /// <summary>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/producesSignal">mo:producesSignal</a>
    /// </summary>
    let producesSignal = _prefixId.prefix "producesSignal"
    /// <summary>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/producesSound">mo:producesSound</a>
    /// </summary>
    let producesSound = _prefixId.prefix "producesSound"
    let producesWork = _prefixId.prefix "producesWork"
    /// <summary>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/productOfComposition">mo:productOfComposition</a>
    /// </summary>
    let productOfComposition = _prefixId.prefix "productOfComposition"
    let promotion = _prefixId.prefix "promotion"
    /// <summary>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/publicationOf">mo:publicationOf</a>
    /// </summary>
    let publicationOf = _prefixId.prefix "publicationOf"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : publication of^^xsd:string</para>
    ///   <para>rdfs:comment : Link a particular manifestation to the related signal, score, libretto, or lyrics^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/publication_of">mo:publication_of</a>
    /// </summary>
    let publication_of = _prefixId.prefix "publication_of"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : published^^xsd:string</para>
    ///   <para>rdfs:comment : Used to relate an person or a group of person who published the manifestation of a work.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/published">mo:published</a>
    /// </summary>
    let published = _prefixId.prefix "published"
    /// <summary>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/publishedAs">mo:publishedAs</a>
    /// </summary>
    let publishedAs = _prefixId.prefix "publishedAs"
    /// <summary>
    ///   <para>rdfs:comment :
    ///         Links a musical expression (e.g. a signal or a score) to one of its manifestations (e.g. a track on a particular record or a published score).
    ///     ^^xsd:string</para>
    ///   <para>rdfs:label : published as^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/published_as">mo:published_as</a>
    /// </summary>
    let published_as = _prefixId.prefix "published_as"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : publisher^^xsd:string</para>
    ///   <para>rdfs:comment : Used to relate a musical manifestation to a person or a group of person who published it.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/publisher">mo:publisher</a>
    /// </summary>
    let publisher = _prefixId.prefix "publisher"
    /// <summary>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/publishingLocation">mo:publishingLocation</a>
    /// </summary>
    let publishingLocation = _prefixId.prefix "publishingLocation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : publishingLocation^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Relates a musical manifestation to its publication location.
    ///         ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/publishing_location">mo:publishing_location</a>
    /// </summary>
    let publishing_location = _prefixId.prefix "publishing_location"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : puid^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Link a signal to the PUIDs associated with it, that is, PUID computed from MusicalItems (mo:AudioFile)
    ///         derived from this signal.
    ///         PUIDs (Portable Unique IDentifier) are the IDs used in the
    ///         proprietary MusicDNS AudioFingerprinting system which is operated by MusicIP.
    ///
    ///         Using PUIDs, one (with some luck) can identify the Signal object associated with a particular audio file, therefore allowing
    ///         to access further information (on which release this track is featured? etc.). Using some more metadata one can identify
    ///         the particular Track corresponding to the audio file (a track on a particular release).^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/puid">mo:puid</a>
    /// </summary>
    let puid = _prefixId.prefix "puid"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : released record^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a release with the records it contains. A single release can be associated with multiple records, for example for a multi-disc release.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/record">mo:record</a>
    /// </summary>
    let record = _prefixId.prefix "record"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : record count^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a release with the number of records it contains, e.g. the number of discs it contains in the case of a multi-disc release.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/record_count">mo:record_count</a>
    /// </summary>
    let record_count = _prefixId.prefix "record_count"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : has record number^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the position of a record in a release (e.g. a 2xLP, etc.).^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/record_number">mo:record_number</a>
    /// </summary>
    let record_number = _prefixId.prefix "record_number"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : has record side^^xsd:string</para>
    ///   <para>rdfs:comment : Associates the side on a vinyl record, where a track is located, e.g. A, B, C, etc. This property can then also be used
    /// in conjunction with mo:track_number, so that one can infer e.g. "A1", that means, track number 1 on side A.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/record_side">mo:record_side</a>
    /// </summary>
    let record_side = _prefixId.prefix "record_side"
    let recordedAs = _prefixId.prefix "recordedAs"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : recorded as^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         This is a shortcut property, allowing to bypass all the Sound/Recording steps. This property
    ///         allows to directly link a Performance to the recorded Signal. This is recommended for "normal"
    ///         users. However, advanced users wanting to express things such as the location of the microphone will
    ///         have to create this shortcut as well as the whole workflow, in order to let the "normal" users access
    ///         simply the, well, simple information:-) .
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/recorded_as">mo:recorded_as</a>
    /// </summary>
    let recorded_as = _prefixId.prefix "recorded_as"
    /// <summary>
    ///   <para>rdfs:label : recorded in^^xsd:string</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///             Associates a physical Sound to a Recording event where it is being used
    ///         in order to produce a signal. For example, I might use this property to
    ///         associate the sound produced by a particular performance of the magic flute
    ///         to a given recording, done using my cell-phone.
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/recorded_in">mo:recorded_in</a>
    /// </summary>
    let recorded_in = _prefixId.prefix "recorded_in"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///             Associates a Recording event to a physical Sound being recorded.
    ///                 For example, I might use this property to
    ///                 associate a given recording, done using my cell phone, to the
    ///         sound produced by a particular performance of the magic flute.
    ///     ^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : recorded sound^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/recording_of">mo:recording_of</a>
    /// </summary>
    let recording_of = _prefixId.prefix "recording_of"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : records^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         This is the inverse of the shortcut property recordedAs, allowing to relate directly a performance
    ///         to a signal.
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/records">mo:records</a>
    /// </summary>
    let records = _prefixId.prefix "records"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : release^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a release with the corresponding release event^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/release">mo:release</a>
    /// </summary>
    let release = _prefixId.prefix "release"
    /// <summary>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/releaseStatus">mo:releaseStatus</a>
    /// </summary>
    let releaseStatus = _prefixId.prefix "releaseStatus"
    /// <summary>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/releaseType">mo:releaseType</a>
    /// </summary>
    let releaseType = _prefixId.prefix "releaseType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///                 Relates a musical manifestation to its release status (bootleg, ...)
    ///         ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/release_status">mo:release_status</a>
    /// </summary>
    let release_status = _prefixId.prefix "release_status"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Relates a musical manifestation to its release type (interview, spoken word, album, ...)
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/release_type">mo:release_type</a>
    /// </summary>
    let release_type = _prefixId.prefix "release_type"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : remaster_of^^xsd:string</para>
    ///   <para>rdfs:comment : This relates two musical work or the expression of a musical work, where one is a remaster of the other.
    ///
    /// A remaster is a new version made for release from source recordings that were earlier released separately. This is usually done to improve the audio quality or adjust for more modern playback equipment. The process generally doesn't involve changing the music in any artistically important way. It may, however, result in tracks that are a few seconds longer or shorter.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/remaster_of">mo:remaster_of</a>
    /// </summary>
    let remaster_of = _prefixId.prefix "remaster_of"
    let remix = _prefixId.prefix "remix"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : remix_of^^xsd:string</para>
    ///   <para>rdfs:comment : Used to relate the remix of a musical work in a substantially altered version produced by mixing together individual tracks or segments of an original musical source work.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/remix_of">mo:remix_of</a>
    /// </summary>
    let remix_of = _prefixId.prefix "remix_of"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : remixed^^xsd:string</para>
    ///   <para>rdfs:comment : Used to relate an artist who remixed a musical work or the expression of a musical work.
    ///
    /// This involves taking just one other musical work and using audio editing to make it sound like a significantly different, but usually still recognisable, song. It can be used to link an artist to a single song that they remixed, or, if they remixed an entire musical work.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/remixed">mo:remixed</a>
    /// </summary>
    let remixed = _prefixId.prefix "remixed"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : remixer^^xsd:string</para>
    ///   <para>rdfs:comment : Used to relate a musical work or the expression of a musical work to an artist who remixed it.
    ///
    /// This involves taking just one other musical work and using audio editing to make it sound like a significantly different, but usually still recognisable, song. It can be used to link an artist to a single song that they remixed, or, if they remixed an entire musical work.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/remixer">mo:remixer</a>
    /// </summary>
    let remixer = _prefixId.prefix "remixer"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : review^^xsd:string</para>
    ///   <para>rdfs:comment : Used to link a work or the expression of a work to a review.
    ///
    /// The review does not have to be open content, as long as it is accessible to the general internet population.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/review">mo:review</a>
    /// </summary>
    let review = _prefixId.prefix "review"
    /// <summary>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/sampleRate">mo:sampleRate</a>
    /// </summary>
    let sampleRate = _prefixId.prefix "sampleRate"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Associates a digital signal to its sample rate. It might be easier to express it this way instead of
    ///         defining a timeline map:-) Range is xsd:float.
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/sample_rate">mo:sample_rate</a>
    /// </summary>
    let sample_rate = _prefixId.prefix "sample_rate"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : sampled^^xsd:string</para>
    ///   <para>rdfs:comment : Used to relate an artist who sampled a Signal.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/sampled">mo:sampled</a>
    /// </summary>
    let sampled = _prefixId.prefix "sampled"
    /// <summary>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/sampledVersionOf">mo:sampledVersionOf</a>
    /// </summary>
    let sampledVersionOf = _prefixId.prefix "sampledVersionOf"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : sampled version^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Associates an analog signal with a sampled version of it
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/sampled_version">mo:sampled_version</a>
    /// </summary>
    let sampled_version = _prefixId.prefix "sampled_version"
    /// <summary>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : sampled version of^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Associates a digital signal with the analog version of it
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/sampled_version_of">mo:sampled_version_of</a>
    /// </summary>
    let sampled_version_of = _prefixId.prefix "sampled_version_of"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : sampler^^xsd:string</para>
    ///   <para>rdfs:comment : Used to relate the signal of a musical work to an artist who sampled it.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/sampler">mo:sampler</a>
    /// </summary>
    let sampler = _prefixId.prefix "sampler"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : sell_item^^xsd:string</para>
    ///   <para>rdfs:comment : A person, a group of person or an organization selling an exemplar of a single manifestation.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/sell_item">mo:sell_item</a>
    /// </summary>
    let sell_item = _prefixId.prefix "sell_item"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : signal^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a group of signals with one of the signals it contains^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/signal">mo:signal</a>
    /// </summary>
    let signal = _prefixId.prefix "signal"
    /// <summary>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/signalTime">mo:signalTime</a>
    /// </summary>
    let signalTime = _prefixId.prefix "signalTime"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : similar_to^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///             A similarity relationships between two objects (so far, either an agent, a signal or a genre, but
    ///         this could grow).
    ///         This relationship is pretty general and doesn't make any assumptions on how the similarity claim
    ///         was derived.
    ///         Such similarity statements can come from a range of different sources (Musicbrainz similarities between
    ///         artists, or coming from some automatic content analysis).
    ///         However, the origin of such statements should be kept using a named graph approach - and ultimately, the
    ///         documents providing such statements should attach some metadata to themselves (confidence of the claim, etc.).
    ///         ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/similar_to">mo:similar_to</a>
    /// </summary>
    let similar_to = _prefixId.prefix "similar_to"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a performance to an involved singer^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/singer">mo:singer</a>
    /// </summary>
    let singer = _prefixId.prefix "singer"
    let single = _prefixId.prefix "single"
    let soundtrack = _prefixId.prefix "soundtrack"
    let spokenword = _prefixId.prefix "spokenword"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : supporting_musician^^xsd:string</para>
    ///   <para>rdfs:comment : Used to relate an artist doing long-time instrumental or vocal support for another artist.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/supporting_musician">mo:supporting_musician</a>
    /// </summary>
    let supporting_musician = _prefixId.prefix "supporting_musician"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : tempo^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Rate of speed or pace of music. Tempo markings are traditionally given in Italian;
    ///         common markings include: grave (solemn; very, very slow); largo (broad; very slow);
    ///         adagio (quite slow); andante (a walking pace); moderato (moderate); allegro (fast; cheerful);
    ///         vivace (lively); presto (very fast); accelerando (getting faster); ritardando (getting slower);
    ///         and a tempo (in time; returning to the original pace).
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/tempo">mo:tempo</a>
    /// </summary>
    let tempo = _prefixId.prefix "tempo"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 2^^xsd:string</para>
    ///   <para>rdfs:label : text^^xsd:string</para>
    ///   <para>rdfs:comment : Associates lyrics with their text.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/text">mo:text</a>
    /// </summary>
    let text = _prefixId.prefix "text"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : time^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Associates a Signal to a time object - its actual domain
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/time">mo:time</a>
    /// </summary>
    let time = _prefixId.prefix "time"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : track^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates a part of a musical manifestation - in this particular case, a track.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/track">mo:track</a>
    /// </summary>
    let track = _prefixId.prefix "track"
    /// <summary>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/trackNum">mo:trackNum</a>
    /// </summary>
    let trackNum = _prefixId.prefix "trackNum"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : track count^^xsd:string</para>
    ///   <para>rdfs:comment : The track count of a record^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/track_count">mo:track_count</a>
    /// </summary>
    let track_count = _prefixId.prefix "track_count"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : track number^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the position of a track on a record medium (a CD, etc.).^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/track_number">mo:track_number</a>
    /// </summary>
    let track_number = _prefixId.prefix "track_number"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : translation_of^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that a work or the expression of a work has translated or transliterated into another expression of a work.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/translation_of">mo:translation_of</a>
    /// </summary>
    let translation_of = _prefixId.prefix "translation_of"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : tribute_to^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates a musical work or the expression of a musical work that is a tribute to an artist - normally consisting of music being composed by the artist but performed by other artists. ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/tribute_to">mo:tribute_to</a>
    /// </summary>
    let tribute_to = _prefixId.prefix "tribute_to"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : trmid^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Indicates the TRMID of a track.
    ///         TRM IDs are MusicBrainz' old AudioFingerprinting system.
    ///         TRM (TRM Recognizes Music) IDs are (somewhat) unique ids that represent
    ///         the audio signature of a musical piece (see AudioFingerprint).
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/trmid">mo:trmid</a>
    /// </summary>
    let trmid = _prefixId.prefix "trmid"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : upc^^xsd:string</para>
    ///   <para>rdfs:comment : UPC stands for "Universal Product Code", which was the original barcode used in the United States and Canada. The UPC (now officially EAN.UCC-12 is a numerical method of identifying products without redundancy worldwide for all types of products in the retail sector. The EAN is a superset of the original UPC increasing the digits to 13 with the prefix 0 reserved for UPC. As of 2005, manufacturers are only allowed to use the new 13-digit codes on their items, rather than having two separate numbers.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/upc">mo:upc</a>
    /// </summary>
    let upc = _prefixId.prefix "upc"
    /// <summary>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/usedInPerformance">mo:usedInPerformance</a>
    /// </summary>
    let usedInPerformance = _prefixId.prefix "usedInPerformance"
    /// <summary>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/usedInRecording">mo:usedInRecording</a>
    /// </summary>
    let usedInRecording = _prefixId.prefix "usedInRecording"
    /// <summary>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/usesSound">mo:usesSound</a>
    /// </summary>
    let usesSound = _prefixId.prefix "usesSound"
    /// <summary>
    ///   <para>vs:term_status : deprecated^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/usesWork">mo:usesWork</a>
    /// </summary>
    let usesWork = _prefixId.prefix "usesWork"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : universally unique identifier^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///             Links an object to an universally unique identifier for it.
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/uuid">mo:uuid</a>
    /// </summary>
    let uuid = _prefixId.prefix "uuid"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : want_item^^xsd:string</para>
    ///   <para>rdfs:comment : A person, a group of person or an organization wanting an exemplar of a single manifestation.^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/want_item">mo:want_item</a>
    /// </summary>
    let want_item = _prefixId.prefix "want_item"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>mo:level : 1^^xsd:string</para>
    ///   <para>rdfs:label : wikipedia^^xsd:string</para>
    ///   <para>rdfs:comment :
    ///         Used to link an work, an expression of a work, a manifestation of a work,
    ///         a person, an instrument or a musical genre to its corresponding WikiPedia page.
    ///         The full URL should be used, not just the WikiName.
    ///     ^^xsd:string</para>
    ///   <a href="http://purl.org/ontology/mo/wikipedia">mo:wikipedia</a>
    /// </summary>
    let wikipedia = _prefixId.prefix "wikipedia"
