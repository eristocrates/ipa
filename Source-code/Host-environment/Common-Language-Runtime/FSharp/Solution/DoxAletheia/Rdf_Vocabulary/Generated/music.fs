namespace http.www.kanzaki.com.ns.music.hash

open DoxAletheia.Rdf_Vocabulary

module music =
    let _namespace_name = "http://www.kanzaki.com/ns/music#"
    /// <summary>
    /// Major key based on A, whose key signature has 3 sharps.
    /// <see href="http://www.kanzaki.com/ns/music#A-dur"></see></summary>
    let ``A-dur`` = Namespaced_IRI.parse _namespace_name "A-dur" |> NamespacedName
    /// <summary>
    /// A key of a musical work (e.g. C-dur, b-moll)
    /// <see href="http://www.kanzaki.com/ns/music#Key"></see></summary>
    let Key = Namespaced_IRI.parse _namespace_name "Key" |> NamespacedName
    /// <summary>
    /// An Alto singer
    /// <see href="http://www.kanzaki.com/ns/music#Alto"></see></summary>
    let Alto = Namespaced_IRI.parse _namespace_name "Alto" |> NamespacedName
    /// <summary>
    /// An artist who sings a song
    /// <see href="http://www.kanzaki.com/ns/music#Singer"></see></summary>
    let Singer = Namespaced_IRI.parse _namespace_name "Singer" |> NamespacedName
    /// <summary>
    /// A person or group (or any agent) who creates or performs art works
    /// <see href="http://www.kanzaki.com/ns/music#Artist"></see></summary>
    let Artist = Namespaced_IRI.parse _namespace_name "Artist" |> NamespacedName
    /// <summary>
    /// Major key based on A flat, whose key signature has 4 flats.
    /// <see href="http://www.kanzaki.com/ns/music#As-dur"></see></summary>
    let ``As-dur`` = Namespaced_IRI.parse _namespace_name "As-dur" |> NamespacedName
    /// <summary>
    /// Major key based on B flat, whose key signature has 2 flats.
    /// <see href="http://www.kanzaki.com/ns/music#B-dur"></see></summary>
    let ``B-dur`` = Namespaced_IRI.parse _namespace_name "B-dur" |> NamespacedName
    /// <summary>
    /// A musical work for a dance form featuring a staged presentation of group or solo dancing. Note 'Ballet_Event' in this vocabulary describes the performance of a ballet.
    /// <see href="http://www.kanzaki.com/ns/music#Ballet"></see></summary>
    let Ballet = Namespaced_IRI.parse _namespace_name "Ballet" |> NamespacedName
    /// <summary>
    /// A (complete) musical work by a composer.
    /// <see href="http://www.kanzaki.com/ns/music#Oeuvre"></see></summary>
    let Oeuvre = Namespaced_IRI.parse _namespace_name "Oeuvre" |> NamespacedName

    /// <summary>
    /// A musical group that performs ballet works.
    /// <see href="http://www.kanzaki.com/ns/music#BalletCompany"></see></summary>
    let BalletCompany =
        Namespaced_IRI.parse _namespace_name "BalletCompany" |> NamespacedName

    /// <summary>
    /// A group that performs art works
    /// <see href="http://www.kanzaki.com/ns/music#MusicalGroup"></see></summary>
    let MusicalGroup =
        Namespaced_IRI.parse _namespace_name "MusicalGroup" |> NamespacedName

    /// <summary>
    /// An event of ballet performance
    ///
    /// <see href="http://www.kanzaki.com/ns/music#Ballet_Event"></see></summary>
    let Ballet_Event =
        Namespaced_IRI.parse _namespace_name "Ballet_Event" |> NamespacedName

    /// <summary>
    /// An event of musical performance by players or singers, including theatrical staging. Typically the event has date and location. Note this is different from Performance, which is a 'representation' of a musical work realized at a musical event or recording, etc.
    /// <see href="http://www.kanzaki.com/ns/music#Musical_Event"></see></summary>
    let Musical_Event =
        Namespaced_IRI.parse _namespace_name "Musical_Event" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.kanzaki.com/ns/music#Ballet_Performance"></see>
    /// </summary>
    let Ballet_Performance =
        Namespaced_IRI.parse _namespace_name "Ballet_Performance" |> NamespacedName

    /// <summary>
    /// A Baritone singer
    /// <see href="http://www.kanzaki.com/ns/music#Baritone"></see></summary>
    let Baritone = Namespaced_IRI.parse _namespace_name "Baritone" |> NamespacedName
    /// <summary>
    /// A Bass singer
    /// <see href="http://www.kanzaki.com/ns/music#Bass"></see></summary>
    let Bass = Namespaced_IRI.parse _namespace_name "Bass" |> NamespacedName

    /// <summary>
    /// A larger member of the clarinet family, usually in key B-flat.
    /// <see href="http://www.kanzaki.com/ns/music#BassClarinet"></see></summary>
    let BassClarinet =
        Namespaced_IRI.parse _namespace_name "BassClarinet" |> NamespacedName

    /// <summary>
    /// A woodwind instrument having a straight cylindrical tube with a flaring bell and a single-reed mouthpiece.
    /// <see href="http://www.kanzaki.com/ns/music#Clarinet"></see></summary>
    let Clarinet = Namespaced_IRI.parse _namespace_name "Clarinet" |> NamespacedName

    /// <summary>
    /// A Bass Clarinet player
    /// <see href="http://www.kanzaki.com/ns/music#BassClarinettist"></see></summary>
    let BassClarinettist =
        Namespaced_IRI.parse _namespace_name "BassClarinettist" |> NamespacedName

    /// <summary>
    /// The subject artist (or group, machine, etc) plays an musical instrument. If :me :plays :Violin, then :me a :Violininst.
    /// <see href="http://www.kanzaki.com/ns/music#plays"></see></summary>
    let plays = Namespaced_IRI.parse _namespace_name "plays" |> NamespacedName

    /// <summary>
    /// A Clarinet player
    /// <see href="http://www.kanzaki.com/ns/music#Clarinettist"></see></summary>
    let Clarinettist =
        Namespaced_IRI.parse _namespace_name "Clarinettist" |> NamespacedName

    /// <summary>
    /// A larger member of the clarinet family, typically in lower F, and has darker and less brilliant timbre.
    /// <see href="http://www.kanzaki.com/ns/music#BassetHorn"></see></summary>
    let BassetHorn = Namespaced_IRI.parse _namespace_name "BassetHorn" |> NamespacedName
    /// <summary>
    /// A low-pitched woodwind instrument with a double reed, having a long wooden body attached to a U-shaped lateral tube that leads to the mouthpiece. A Fagotto.
    /// <see href="http://www.kanzaki.com/ns/music#Bassoon"></see></summary>
    let Bassoon = Namespaced_IRI.parse _namespace_name "Bassoon" |> NamespacedName

    /// <summary>
    /// A wind musical instrument, in which sound is produced by the vibration of reeds in the mouthpiece, or by the passing of air across the mouthpiece.
    /// <see href="http://www.kanzaki.com/ns/music#Woodwind_Instrument"></see></summary>
    let Woodwind_Instrument =
        Namespaced_IRI.parse _namespace_name "Woodwind_Instrument" |> NamespacedName

    /// <summary>
    /// A Fagotto player
    /// <see href="http://www.kanzaki.com/ns/music#Bassoonist"></see></summary>
    let Bassoonist = Namespaced_IRI.parse _namespace_name "Bassoonist" |> NamespacedName
    /// <summary>
    /// An artist who performs a musical instrument
    /// <see href="http://www.kanzaki.com/ns/music#Player"></see></summary>
    let Player = Namespaced_IRI.parse _namespace_name "Player" |> NamespacedName

    /// <summary>
    /// A wind musical instrument, that consists of a brass tube  blown by means of a cup-shaped or funnel-shaped mouthpiece.
    /// <see href="http://www.kanzaki.com/ns/music#Brass_Instrument"></see></summary>
    let Brass_Instrument =
        Namespaced_IRI.parse _namespace_name "Brass_Instrument" |> NamespacedName

    /// <summary>
    /// An instrument to play music
    /// <see href="http://www.kanzaki.com/ns/music#Musical_Instrument"></see></summary>
    let Musical_Instrument =
        Namespaced_IRI.parse _namespace_name "Musical_Instrument" |> NamespacedName

    /// <summary>
    /// Major key based on C, whose key signature has no sharp or flat.
    /// <see href="http://www.kanzaki.com/ns/music#C-dur"></see></summary>
    let ``C-dur`` = Namespaced_IRI.parse _namespace_name "C-dur" |> NamespacedName
    /// <summary>
    /// A vocal composition accompanied by instruments and generally containing more than one movement.
    /// <see href="http://www.kanzaki.com/ns/music#Cantata"></see></summary>
    let Cantata = Namespaced_IRI.parse _namespace_name "Cantata" |> NamespacedName

    /// <summary>
    /// A genre of music composed for performance by a chorus or choir
    /// <see href="http://www.kanzaki.com/ns/music#Choral_Music"></see></summary>
    let Choral_Music =
        Namespaced_IRI.parse _namespace_name "Choral_Music" |> NamespacedName

    /// <summary>
    /// A musical instrument with a keyboard and metal plates struck by hammers that produce bell-like tones.
    /// <see href="http://www.kanzaki.com/ns/music#Celesta"></see></summary>
    let Celesta = Namespaced_IRI.parse _namespace_name "Celesta" |> NamespacedName

    /// <summary>
    /// A musical instrument that has a set of keys that consist of scale.
    /// <see href="http://www.kanzaki.com/ns/music#Keyboard_Instrument"></see></summary>
    let Keyboard_Instrument =
        Namespaced_IRI.parse _namespace_name "Keyboard_Instrument" |> NamespacedName

    /// <summary>
    /// A Celesta player
    /// <see href="http://www.kanzaki.com/ns/music#CelestaPlayer"></see></summary>
    let CelestaPlayer =
        Namespaced_IRI.parse _namespace_name "CelestaPlayer" |> NamespacedName

    /// <summary>
    /// A Cello player
    /// <see href="http://www.kanzaki.com/ns/music#Cellist"></see></summary>
    let Cellist = Namespaced_IRI.parse _namespace_name "Cellist" |> NamespacedName
    /// <summary>
    /// A stringed instrument of the violin family, with bass to tenor tone. Usually played in sitting position.
    /// <see href="http://www.kanzaki.com/ns/music#Cello"></see></summary>
    let Cello = Namespaced_IRI.parse _namespace_name "Cello" |> NamespacedName

    /// <summary>
    /// A stringed musical instrument, in which sound is produced by plucking, striking, or bowing taut strings.
    /// <see href="http://www.kanzaki.com/ns/music#String_Instrument"></see></summary>
    let String_Instrument =
        Namespaced_IRI.parse _namespace_name "String_Instrument" |> NamespacedName

    /// <summary>
    /// Major key based on C flat, whose key signature has 7 flats.
    /// <see href="http://www.kanzaki.com/ns/music#Ces-dur"></see></summary>
    let ``Ces-dur`` = Namespaced_IRI.parse _namespace_name "Ces-dur" |> NamespacedName

    /// <summary>
    /// A genre of music composed for performance by small ensemble
    /// <see href="http://www.kanzaki.com/ns/music#Chamber_Music"></see></summary>
    let Chamber_Music =
        Namespaced_IRI.parse _namespace_name "Chamber_Music" |> NamespacedName

    /// <summary>
    /// someone who creates new dances, or directs an opera
    /// <see href="http://www.kanzaki.com/ns/music#Choreographer"></see></summary>
    let Choreographer =
        Namespaced_IRI.parse _namespace_name "Choreographer" |> NamespacedName

    /// <summary>
    /// An artist who directs a musical group
    /// <see href="http://www.kanzaki.com/ns/music#Director"></see></summary>
    let Director = Namespaced_IRI.parse _namespace_name "Director" |> NamespacedName
    /// <summary>
    /// A musical group of singers.
    /// <see href="http://www.kanzaki.com/ns/music#Chorus"></see></summary>
    let Chorus = Namespaced_IRI.parse _namespace_name "Chorus" |> NamespacedName
    /// <summary>
    /// Major key based on C sharp, whose key signature has 7 sharps.
    /// <see href="http://www.kanzaki.com/ns/music#Cis-dur"></see></summary>
    let ``Cis-dur`` = Namespaced_IRI.parse _namespace_name "Cis-dur" |> NamespacedName
    /// <summary>
    /// A person (or any agent) who composed art works
    /// <see href="http://www.kanzaki.com/ns/music#Composer"></see></summary>
    let Composer = Namespaced_IRI.parse _namespace_name "Composer" |> NamespacedName
    /// <summary>
    /// An event of musical performance by players or singers not involving theatrical staging
    /// <see href="http://www.kanzaki.com/ns/music#Concert"></see></summary>
    let Concert = Namespaced_IRI.parse _namespace_name "Concert" |> NamespacedName
    /// <summary>
    /// A composition for orchestra and a soloist
    /// <see href="http://www.kanzaki.com/ns/music#Concerto"></see></summary>
    let Concerto = Namespaced_IRI.parse _namespace_name "Concerto" |> NamespacedName

    /// <summary>
    /// A composition for orchestra (and a soloist or soloists, optionally with chorus)
    /// <see href="http://www.kanzaki.com/ns/music#Orchestral_Work"></see></summary>
    let Orchestral_Work =
        Namespaced_IRI.parse _namespace_name "Orchestral_Work" |> NamespacedName

    /// <summary>
    /// A Conductor
    /// <see href="http://www.kanzaki.com/ns/music#Conductor"></see></summary>
    let Conductor = Namespaced_IRI.parse _namespace_name "Conductor" |> NamespacedName
    /// <summary>
    /// An artist who performs, composes or conducts music
    /// <see href="http://www.kanzaki.com/ns/music#Musician"></see></summary>
    let Musician = Namespaced_IRI.parse _namespace_name "Musician" |> NamespacedName
    /// <summary>
    /// The largest member of string insrtument, usually with four or five strings.
    /// <see href="http://www.kanzaki.com/ns/music#Contrabass"></see></summary>
    let Contrabass = Namespaced_IRI.parse _namespace_name "Contrabass" |> NamespacedName

    /// <summary>
    /// A Contrabass player
    /// <see href="http://www.kanzaki.com/ns/music#Contrabassist"></see></summary>
    let Contrabassist =
        Namespaced_IRI.parse _namespace_name "Contrabassist" |> NamespacedName

    /// <summary>
    /// A larger mebmer of the basoon family, producing the lowest tone in the woodwind section.
    /// <see href="http://www.kanzaki.com/ns/music#Contrafagotto"></see></summary>
    let Contrafagotto =
        Namespaced_IRI.parse _namespace_name "Contrafagotto" |> NamespacedName

    /// <summary>
    /// A Contrafagotto player
    /// <see href="http://www.kanzaki.com/ns/music#ContrafagottoPlayer"></see></summary>
    let ContrafagottoPlayer =
        Namespaced_IRI.parse _namespace_name "ContrafagottoPlayer" |> NamespacedName

    /// <summary>
    /// A Countertenor singer
    /// <see href="http://www.kanzaki.com/ns/music#Countertenor"></see></summary>
    let Countertenor =
        Namespaced_IRI.parse _namespace_name "Countertenor" |> NamespacedName

    /// <summary>
    /// Major key based on D, whose key signature has 2 sharps.
    /// <see href="http://www.kanzaki.com/ns/music#D-dur"></see></summary>
    let ``D-dur`` = Namespaced_IRI.parse _namespace_name "D-dur" |> NamespacedName
    /// <summary>
    /// Major key based on D flat, whose key signature has 5 flats.
    /// <see href="http://www.kanzaki.com/ns/music#Des-dur"></see></summary>
    let ``Des-dur`` = Namespaced_IRI.parse _namespace_name "Des-dur" |> NamespacedName
    /// <summary>
    /// Major key based on E, whose key signature has 4 sharps.
    /// <see href="http://www.kanzaki.com/ns/music#E-dur"></see></summary>
    let ``E-dur`` = Namespaced_IRI.parse _namespace_name "E-dur" |> NamespacedName

    /// <summary>
    /// A double-reed woodwind instrument, larger member of the oboe family.
    /// <see href="http://www.kanzaki.com/ns/music#EnglishHorn"></see></summary>
    let EnglishHorn =
        Namespaced_IRI.parse _namespace_name "EnglishHorn" |> NamespacedName

    /// <summary>
    /// A woodwind instrument with a conical bore and a double-reed mouthpiece.
    /// <see href="http://www.kanzaki.com/ns/music#Oboe"></see></summary>
    let Oboe = Namespaced_IRI.parse _namespace_name "Oboe" |> NamespacedName

    /// <summary>
    /// An English Horn player
    /// <see href="http://www.kanzaki.com/ns/music#EnglishHornPlayer"></see></summary>
    let EnglishHornPlayer =
        Namespaced_IRI.parse _namespace_name "EnglishHornPlayer" |> NamespacedName

    /// <summary>
    /// An Oboe player
    /// <see href="http://www.kanzaki.com/ns/music#Oboist"></see></summary>
    let Oboist = Namespaced_IRI.parse _namespace_name "Oboist" |> NamespacedName
    /// <summary>
    /// A musical group which perfroms in relatively small size, particularly chamber music
    /// <see href="http://www.kanzaki.com/ns/music#Ensemble"></see></summary>
    let Ensemble = Namespaced_IRI.parse _namespace_name "Ensemble" |> NamespacedName
    /// <summary>
    /// Major key based on E flat, whose key signature has 3 flats.
    /// <see href="http://www.kanzaki.com/ns/music#Es-dur"></see></summary>
    let ``Es-dur`` = Namespaced_IRI.parse _namespace_name "Es-dur" |> NamespacedName
    /// <summary>
    /// Major key based on F, whose key signature has 1 flat.
    /// <see href="http://www.kanzaki.com/ns/music#F-dur"></see></summary>
    let ``F-dur`` = Namespaced_IRI.parse _namespace_name "F-dur" |> NamespacedName
    /// <summary>
    /// Major key based on F sharp, whose key signature has 6 sharps.
    /// <see href="http://www.kanzaki.com/ns/music#Fis-dur"></see></summary>
    let ``Fis-dur`` = Namespaced_IRI.parse _namespace_name "Fis-dur" |> NamespacedName
    /// <summary>
    /// A high-pitched woodwind instrument; a slender tube closed at one end with finger holes on one end and an opening near the closed end across which the breath is blown
    /// <see href="http://www.kanzaki.com/ns/music#Flute"></see></summary>
    let Flute = Namespaced_IRI.parse _namespace_name "Flute" |> NamespacedName
    /// <summary>
    /// A Flute player
    /// <see href="http://www.kanzaki.com/ns/music#Flutist"></see></summary>
    let Flutist = Namespaced_IRI.parse _namespace_name "Flutist" |> NamespacedName
    /// <summary>
    /// Major key based on G, whose key signature has 1 sharp.
    /// <see href="http://www.kanzaki.com/ns/music#G-dur"></see></summary>
    let ``G-dur`` = Namespaced_IRI.parse _namespace_name "G-dur" |> NamespacedName
    /// <summary>
    /// Major key based on G flat, whose key signature has 6 flats.
    /// <see href="http://www.kanzaki.com/ns/music#Ges-dur"></see></summary>
    let ``Ges-dur`` = Namespaced_IRI.parse _namespace_name "Ges-dur" |> NamespacedName
    /// <summary>
    /// A musical instrument having a large flat-backed sound box, a long fretted neck, and usually six strings, played by strumming or plucking.
    /// <see href="http://www.kanzaki.com/ns/music#Guitar"></see></summary>
    let Guitar = Namespaced_IRI.parse _namespace_name "Guitar" |> NamespacedName
    /// <summary>
    /// A Guitar player
    /// <see href="http://www.kanzaki.com/ns/music#Guitarist"></see></summary>
    let Guitarist = Namespaced_IRI.parse _namespace_name "Guitarist" |> NamespacedName
    /// <summary>
    /// Major key based on B, whose key signature has 5 sharps.
    /// <see href="http://www.kanzaki.com/ns/music#H-dur"></see></summary>
    let ``H-dur`` = Namespaced_IRI.parse _namespace_name "H-dur" |> NamespacedName
    /// <summary>
    /// An instrument with usually 46 or 47 strings that are played by plucking with the fingers.
    /// <see href="http://www.kanzaki.com/ns/music#Harp"></see></summary>
    let Harp = Namespaced_IRI.parse _namespace_name "Harp" |> NamespacedName
    /// <summary>
    /// A Harp player
    /// <see href="http://www.kanzaki.com/ns/music#Harpist"></see></summary>
    let Harpist = Namespaced_IRI.parse _namespace_name "Harpist" |> NamespacedName

    /// <summary>
    /// A keyboard instrument whose strings are plucked by means of quills or plectrums. Cembalo.
    /// <see href="http://www.kanzaki.com/ns/music#Harpsichord"></see></summary>
    let Harpsichord =
        Namespaced_IRI.parse _namespace_name "Harpsichord" |> NamespacedName

    /// <summary>
    /// A brass instrument with a long narrow tube that is coiled in a circle before ending in a flaring bell, usually being equipped with valves. A French Horn.
    /// <see href="http://www.kanzaki.com/ns/music#Horn"></see></summary>
    let Horn = Namespaced_IRI.parse _namespace_name "Horn" |> NamespacedName
    /// <summary>
    /// A Horn player
    /// <see href="http://www.kanzaki.com/ns/music#Hornist"></see></summary>
    let Hornist = Namespaced_IRI.parse _namespace_name "Hornist" |> NamespacedName
    /// <summary>
    /// A pear-shaped small stringed instrument descended from the lute, played with a pick.
    /// <see href="http://www.kanzaki.com/ns/music#Mandolin"></see></summary>
    let Mandolin = Namespaced_IRI.parse _namespace_name "Mandolin" |> NamespacedName

    /// <summary>
    /// A Mezzo Soprano singer
    /// <see href="http://www.kanzaki.com/ns/music#MezzoSoprano"></see></summary>
    let MezzoSoprano =
        Namespaced_IRI.parse _namespace_name "MezzoSoprano" |> NamespacedName

    /// <summary>
    /// A subsection of a musical work. Typically a movement of a symphony, but also a piece of suit, etc.
    /// <see href="http://www.kanzaki.com/ns/music#Movement"></see></summary>
    let Movement = Namespaced_IRI.parse _namespace_name "Movement" |> NamespacedName

    /// <summary>
    /// A musical work in any form, e.g. a composition, its movement, phrase, theme etc.
    /// <see href="http://www.kanzaki.com/ns/music#Musical_Work"></see></summary>
    let Musical_Work =
        Namespaced_IRI.parse _namespace_name "Musical_Work" |> NamespacedName

    /// <summary>
    /// The person who leads a musical group
    /// <see href="http://www.kanzaki.com/ns/music#MusicDirector"></see></summary>
    let MusicDirector =
        Namespaced_IRI.parse _namespace_name "MusicDirector" |> NamespacedName

    /// <summary>
    /// Representation of a musical work, such as a score, sheet music, perfornamce, recoding, etc.
    /// <see href="http://www.kanzaki.com/ns/music#Musical_Representation"></see></summary>
    let Musical_Representation =
        Namespaced_IRI.parse _namespace_name "Musical_Representation" |> NamespacedName

    /// <summary>
    /// A musical work with drama, song, chorus and orchestral music. Note 'Opera_Event' in this vocabulary describes the performance of an opera.
    /// <see href="http://www.kanzaki.com/ns/music#Opera"></see></summary>
    let Opera = Namespaced_IRI.parse _namespace_name "Opera" |> NamespacedName

    /// <summary>
    /// A musical group that performs opera works.
    /// <see href="http://www.kanzaki.com/ns/music#OperaCompany"></see></summary>
    let OperaCompany =
        Namespaced_IRI.parse _namespace_name "OperaCompany" |> NamespacedName

    /// <summary>
    /// An event of opera performance (not an opera as a musical work, which is defined here as 'Opera')
    /// <see href="http://www.kanzaki.com/ns/music#Opera_Event"></see></summary>
    let Opera_Event =
        Namespaced_IRI.parse _namespace_name "Opera_Event" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.kanzaki.com/ns/music#Opera_Performance"></see>
    /// </summary>
    let Opera_Performance =
        Namespaced_IRI.parse _namespace_name "Opera_Performance" |> NamespacedName

    /// <summary>
    /// A large musical composition for orchestra, vocal soloists and chorus
    /// <see href="http://www.kanzaki.com/ns/music#Oratorio"></see></summary>
    let Oratorio = Namespaced_IRI.parse _namespace_name "Oratorio" |> NamespacedName
    /// <summary>
    /// A musical group which perfroms large scale symphonic works
    /// <see href="http://www.kanzaki.com/ns/music#Orchestra"></see></summary>
    let Orchestra = Namespaced_IRI.parse _namespace_name "Orchestra" |> NamespacedName
    /// <summary>
    /// An orchestral music composed for the opening of an opera or oratorio, often played as an independend work in concerts
    /// <see href="http://www.kanzaki.com/ns/music#Overture"></see></summary>
    let Overture = Namespaced_IRI.parse _namespace_name "Overture" |> NamespacedName
    /// <summary>
    /// A music for a particular instrument or voice taken from a full score (Note: in this ontology, Part is not a division of an orchestra).
    /// <see href="http://www.kanzaki.com/ns/music#Part"></see></summary>
    let Part = Namespaced_IRI.parse _namespace_name "Part" |> NamespacedName

    /// <summary>
    /// Representation of a musical work in the form of a written expression, e.g. score, parts, autograph, printed music, sketch, etc.
    /// <see href="http://www.kanzaki.com/ns/music#Written_Representation"></see></summary>
    let Written_Representation =
        Namespaced_IRI.parse _namespace_name "Written_Representation" |> NamespacedName

    /// <summary>
    /// A musical instrument that produces sound by striking the body.
    /// <see href="http://www.kanzaki.com/ns/music#Percussion"></see></summary>
    let Percussion = Namespaced_IRI.parse _namespace_name "Percussion" |> NamespacedName

    /// <summary>
    /// A Percussion player
    /// <see href="http://www.kanzaki.com/ns/music#Percussionist"></see></summary>
    let Percussionist =
        Namespaced_IRI.parse _namespace_name "Percussionist" |> NamespacedName

    /// <summary>
    /// Representation of a musical work in the form of performace, e.g. playing instruments, singing etc. Note a concert is a Musical_Event where a Performance is presented.
    /// <see href="http://www.kanzaki.com/ns/music#Performance"></see></summary>
    let Performance =
        Namespaced_IRI.parse _namespace_name "Performance" |> NamespacedName

    /// <summary>
    /// A Piano player
    /// <see href="http://www.kanzaki.com/ns/music#Pianist"></see></summary>
    let Pianist = Namespaced_IRI.parse _namespace_name "Pianist" |> NamespacedName
    /// <summary>
    /// A musical instrument with a manual keyboard actuating hammers that strike wire strings. A pianoforte.
    /// <see href="http://www.kanzaki.com/ns/music#Piano"></see></summary>
    let Piano = Namespaced_IRI.parse _namespace_name "Piano" |> NamespacedName
    /// <summary>
    /// A piccolo flute, smaller member of the flute family.
    /// <see href="http://www.kanzaki.com/ns/music#Piccolo"></see></summary>
    let Piccolo = Namespaced_IRI.parse _namespace_name "Piccolo" |> NamespacedName

    /// <summary>
    /// A Piccolo flute player
    /// <see href="http://www.kanzaki.com/ns/music#PiccoloPlayer"></see></summary>
    let PiccoloPlayer =
        Namespaced_IRI.parse _namespace_name "PiccoloPlayer" |> NamespacedName

    /// <summary>
    /// An event of musical performance especially by soloists
    /// <see href="http://www.kanzaki.com/ns/music#Recital"></see></summary>
    let Recital = Namespaced_IRI.parse _namespace_name "Recital" |> NamespacedName

    /// <summary>
    /// A genre of music composed for performance as part of religious ceremonies
    /// <see href="http://www.kanzaki.com/ns/music#Religious_Music"></see></summary>
    let Religious_Music =
        Namespaced_IRI.parse _namespace_name "Religious_Music" |> NamespacedName

    /// <summary>
    /// A woodwind instrument with a single-reed mouthpiece and a (usually curved) conical metal tube, including soprano, alto, tenor, and baritone sizes.
    /// <see href="http://www.kanzaki.com/ns/music#Saxophone"></see></summary>
    let Saxophone = Namespaced_IRI.parse _namespace_name "Saxophone" |> NamespacedName
    /// <summary>
    /// A full score or piano-vocal score of a work, either published or manuscript.
    /// <see href="http://www.kanzaki.com/ns/music#Score"></see></summary>
    let Score = Namespaced_IRI.parse _namespace_name "Score" |> NamespacedName
    /// <summary>
    /// A sketch, or a brief prelimary composition of a work.
    /// <see href="http://www.kanzaki.com/ns/music#Sketch"></see></summary>
    let Sketch = Namespaced_IRI.parse _namespace_name "Sketch" |> NamespacedName
    /// <summary>
    /// A Soprano singer
    /// <see href="http://www.kanzaki.com/ns/music#Soprano"></see></summary>
    let Soprano = Namespaced_IRI.parse _namespace_name "Soprano" |> NamespacedName

    /// <summary>
    /// A smaller member of the clarinet family, commonly in key E-flat.
    /// <see href="http://www.kanzaki.com/ns/music#SopranoClarinet"></see></summary>
    let SopranoClarinet =
        Namespaced_IRI.parse _namespace_name "SopranoClarinet" |> NamespacedName

    /// <summary>
    /// A musical group of four string players. Note 'String_Quartette' is SQ as musical work in this vocabulary.
    /// <see href="http://www.kanzaki.com/ns/music#StringQuartetEnsemble"></see></summary>
    let StringQuartetEnsemble =
        Namespaced_IRI.parse _namespace_name "StringQuartetEnsemble" |> NamespacedName

    /// <summary>
    /// A music composed for instrumental quartet with 2 violins and a viola and a cello. Note 'StringQuartetEnsemble' is SQ ensemble in this vocabulary.
    /// <see href="http://www.kanzaki.com/ns/music#String_Quartet"></see></summary>
    let String_Quartet =
        Namespaced_IRI.parse _namespace_name "String_Quartet" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.kanzaki.com/ns/music#String_Quartette"></see>
    /// </summary>
    let String_Quartette =
        Namespaced_IRI.parse _namespace_name "String_Quartette" |> NamespacedName

    /// <summary>
    /// A musical composition of several movements only loosely connected
    /// <see href="http://www.kanzaki.com/ns/music#Suite"></see></summary>
    let Suite = Namespaced_IRI.parse _namespace_name "Suite" |> NamespacedName

    /// <summary>
    /// An orchestral composition based on a thematic subject
    /// <see href="http://www.kanzaki.com/ns/music#Symphonic_Poem"></see></summary>
    let Symphonic_Poem =
        Namespaced_IRI.parse _namespace_name "Symphonic_Poem" |> NamespacedName

    /// <summary>
    /// A large and complex work for symphony orchestra
    /// <see href="http://www.kanzaki.com/ns/music#Symphony"></see></summary>
    let Symphony = Namespaced_IRI.parse _namespace_name "Symphony" |> NamespacedName
    /// <summary>
    /// A Tenor singer
    /// <see href="http://www.kanzaki.com/ns/music#Tenor"></see></summary>
    let Tenor = Namespaced_IRI.parse _namespace_name "Tenor" |> NamespacedName
    /// <summary>
    /// Text of a musical work (e.g. lyric or verse)
    /// <see href="http://www.kanzaki.com/ns/music#Text"></see></summary>
    let Text = Namespaced_IRI.parse _namespace_name "Text" |> NamespacedName
    /// <summary>
    /// A set of large copper or brass hemispherical drums with a parchment head that can be tuned by adjusting the tension.
    /// <see href="http://www.kanzaki.com/ns/music#Timpani"></see></summary>
    let Timpani = Namespaced_IRI.parse _namespace_name "Timpani" |> NamespacedName
    /// <summary>
    /// A Timpani player
    /// <see href="http://www.kanzaki.com/ns/music#Timpanist"></see></summary>
    let Timpanist = Namespaced_IRI.parse _namespace_name "Timpanist" |> NamespacedName
    /// <summary>
    /// A brass instrument consisting of a long cylindrical tube, and having a movable U-shaped slide for producing different pitches.
    /// <see href="http://www.kanzaki.com/ns/music#Trombone"></see></summary>
    let Trombone = Namespaced_IRI.parse _namespace_name "Trombone" |> NamespacedName
    /// <summary>
    /// A Trombone player
    /// <see href="http://www.kanzaki.com/ns/music#Trombonist"></see></summary>
    let Trombonist = Namespaced_IRI.parse _namespace_name "Trombonist" |> NamespacedName
    /// <summary>
    /// A A soprano brass instrument consisting of a long metal tube looped once and ending in a flared bell, usually being equipped with valves or pistons.
    /// <see href="http://www.kanzaki.com/ns/music#Trumpet"></see></summary>
    let Trumpet = Namespaced_IRI.parse _namespace_name "Trumpet" |> NamespacedName
    /// <summary>
    /// A Trumpet player
    /// <see href="http://www.kanzaki.com/ns/music#Trumpeter"></see></summary>
    let Trumpeter = Namespaced_IRI.parse _namespace_name "Trumpeter" |> NamespacedName
    /// <summary>
    /// A large, valved, brass instrument with a bass pitch.
    /// <see href="http://www.kanzaki.com/ns/music#Tuba"></see></summary>
    let Tuba = Namespaced_IRI.parse _namespace_name "Tuba" |> NamespacedName
    /// <summary>
    /// A Tuba player
    /// <see href="http://www.kanzaki.com/ns/music#TubaPlayer"></see></summary>
    let TubaPlayer = Namespaced_IRI.parse _namespace_name "TubaPlayer" |> NamespacedName
    /// <summary>
    /// A venue for musical performance, e.g. concert hall, opera house, recital hall, etc.
    /// <see href="http://www.kanzaki.com/ns/music#Venue"></see></summary>
    let Venue = Namespaced_IRI.parse _namespace_name "Venue" |> NamespacedName
    /// <summary>
    /// A stringed instrument of the violin family, slightly larger than a violin, tuned a fifth lower, and having a deeper, more sonorous tone.
    /// <see href="http://www.kanzaki.com/ns/music#Viola"></see></summary>
    let Viola = Namespaced_IRI.parse _namespace_name "Viola" |> NamespacedName
    /// <summary>
    /// A musical instrument played with a bow, having four strings. Usually plays the highest part of the string section.
    /// <see href="http://www.kanzaki.com/ns/music#Violin"></see></summary>
    let Violin = Namespaced_IRI.parse _namespace_name "Violin" |> NamespacedName
    /// <summary>
    /// A Violn player
    /// <see href="http://www.kanzaki.com/ns/music#Violinist"></see></summary>
    let Violinist = Namespaced_IRI.parse _namespace_name "Violinist" |> NamespacedName
    /// <summary>
    /// A Viola player
    /// <see href="http://www.kanzaki.com/ns/music#Violist"></see></summary>
    let Violist = Namespaced_IRI.parse _namespace_name "Violist" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.kanzaki.com/ns/music#a-moll"></see>
    /// </summary>
    let ``a-moll`` = Namespaced_IRI.parse _namespace_name "a-moll" |> NamespacedName
    /// <summary>
    /// Minor key based on A sharp, whose key signature has 7 sharps.
    /// <see href="http://www.kanzaki.com/ns/music#ais-moll"></see></summary>
    let ``ais-moll`` = Namespaced_IRI.parse _namespace_name "ais-moll" |> NamespacedName

    /// <summary>
    /// A description of the subject artist or agent. Super-property of #plays, #performs.
    /// <see href="http://www.kanzaki.com/ns/music#artist_description"></see></summary>
    let artist_description =
        Namespaced_IRI.parse _namespace_name "artist_description" |> NamespacedName

    /// <summary>
    /// Minor key based on A flat, whose key signature has 7 flats.
    /// <see href="http://www.kanzaki.com/ns/music#as-moll"></see></summary>
    let ``as-moll`` = Namespaced_IRI.parse _namespace_name "as-moll" |> NamespacedName
    /// <summary>
    /// Minor key based on B flat, whose key signature has 5 flats.
    /// <see href="http://www.kanzaki.com/ns/music#b-moll"></see></summary>
    let ``b-moll`` = Namespaced_IRI.parse _namespace_name "b-moll" |> NamespacedName
    /// <summary>
    /// Minor key based on C, whose key signature has 3 flats.
    /// <see href="http://www.kanzaki.com/ns/music#c-moll"></see></summary>
    let ``c-moll`` = Namespaced_IRI.parse _namespace_name "c-moll" |> NamespacedName
    /// <summary>
    /// Minor key based on C sharp, whose key signature has 4 sharps.
    /// <see href="http://www.kanzaki.com/ns/music#cis-moll"></see></summary>
    let ``cis-moll`` = Namespaced_IRI.parse _namespace_name "cis-moll" |> NamespacedName
    /// <summary>
    /// The subject musical work is composed by a person, a group, a software program etc.
    /// <see href="http://www.kanzaki.com/ns/music#composer"></see></summary>
    let composer = Namespaced_IRI.parse _namespace_name "composer" |> NamespacedName

    /// <summary>
    /// A description of the subject musical work. Super-property of some properties in this vocabulary, as well as description of a general descriptive resource such as time-line of composing process.
    /// <see href="http://www.kanzaki.com/ns/music#description"></see></summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    /// Describes the composition process of the subject. Composition period or completion date, place, revision etc. can be described as properties of the object composition process.
    /// <see href="http://www.kanzaki.com/ns/music#composition"></see></summary>
    let composition =
        Namespaced_IRI.parse _namespace_name "composition" |> NamespacedName

    /// <summary>
    /// The subject performance is coducted by the object (or the subject musical event has a conductor). See comment of #performer.
    /// <see href="http://www.kanzaki.com/ns/music#conductor"></see></summary>
    let conductor = Namespaced_IRI.parse _namespace_name "conductor" |> NamespacedName
    /// <summary>
    /// The subject has a performer (an artist, a group, a machine etc.). The preferred domain of this property is #Performance, so as to model that "a concert presents a performance (of a musical work) that is realized by this performer". However, in natural language, we often say that "a concert has performers who play these musical works", i.e. the domain of 'performer' is #Musical_Event in this case, and it would be more intuitive model. Hence, the domain is leave unrestricted here for a moment.
    /// <see href="http://www.kanzaki.com/ns/music#performer"></see></summary>
    let performer = Namespaced_IRI.parse _namespace_name "performer" |> NamespacedName

    /// <summary>
    /// The subject musical event has a conductor. Literal version of #conductor.
    /// <see href="http://www.kanzaki.com/ns/music#conductorName"></see></summary>
    let conductorName =
        Namespaced_IRI.parse _namespace_name "conductorName" |> NamespacedName

    /// <summary>
    /// The subject musical event has a performer. Literal version of #performer.
    /// <see href="http://www.kanzaki.com/ns/music#performerName"></see></summary>
    let performerName =
        Namespaced_IRI.parse _namespace_name "performerName" |> NamespacedName

    /// <summary>
    /// Minor key based on D, whose key signature has 1 flat.
    /// <see href="http://www.kanzaki.com/ns/music#d-moll"></see></summary>
    let ``d-moll`` = Namespaced_IRI.parse _namespace_name "d-moll" |> NamespacedName

    /// <summary>
    /// The subject is (was) derived from the object, e.g a copy score is derived from the composer manuscript (or, possibly, a CD recording is derived from a performance at a concert).
    /// <see href="http://www.kanzaki.com/ns/music#derivedFrom"></see></summary>
    let derivedFrom =
        Namespaced_IRI.parse _namespace_name "derivedFrom" |> NamespacedName

    /// <summary>
    /// Minor key based on D sharp, whose key signature has 6 sharps.
    /// <see href="http://www.kanzaki.com/ns/music#dis-moll"></see></summary>
    let ``dis-moll`` = Namespaced_IRI.parse _namespace_name "dis-moll" |> NamespacedName
    /// <summary>
    /// Minor key based on E, whose key signature has 1 sharp.
    /// <see href="http://www.kanzaki.com/ns/music#e-moll"></see></summary>
    let ``e-moll`` = Namespaced_IRI.parse _namespace_name "e-moll" |> NamespacedName
    /// <summary>
    /// Minor key based on E flat, whose key signature has 6 flats.
    /// <see href="http://www.kanzaki.com/ns/music#es-moll"></see></summary>
    let ``es-moll`` = Namespaced_IRI.parse _namespace_name "es-moll" |> NamespacedName

    /// <summary>
    /// A description of the subject musical event. Super-property of #program, #presents, #venue.
    /// <see href="http://www.kanzaki.com/ns/music#event_description"></see></summary>
    let event_description =
        Namespaced_IRI.parse _namespace_name "event_description" |> NamespacedName

    /// <summary>
    /// Minor key based on F, whose key signature has 4 flats.
    /// <see href="http://www.kanzaki.com/ns/music#f-moll"></see></summary>
    let ``f-moll`` = Namespaced_IRI.parse _namespace_name "f-moll" |> NamespacedName
    /// <summary>
    /// Minor key based on F sharp, whose key signature has 3 sharps.
    /// <see href="http://www.kanzaki.com/ns/music#fis-moll"></see></summary>
    let ``fis-moll`` = Namespaced_IRI.parse _namespace_name "fis-moll" |> NamespacedName
    /// <summary>
    /// The subject musical work or its movement has a form, such as sonata, minuet, etc. Would be better defined as ObjectProperty.
    /// <see href="http://www.kanzaki.com/ns/music#form"></see></summary>
    let form = Namespaced_IRI.parse _namespace_name "form" |> NamespacedName
    /// <summary>
    /// Minor key based on G, whose key signature has 2 flats.
    /// <see href="http://www.kanzaki.com/ns/music#g-moll"></see></summary>
    let ``g-moll`` = Namespaced_IRI.parse _namespace_name "g-moll" |> NamespacedName
    /// <summary>
    /// Minor key based on G sharp, whose key signature has 5 sharps.
    /// <see href="http://www.kanzaki.com/ns/music#gis-moll"></see></summary>
    let ``gis-moll`` = Namespaced_IRI.parse _namespace_name "gis-moll" |> NamespacedName
    /// <summary>
    /// Minor key based on B, whose key signature has 2 sharps.
    /// <see href="http://www.kanzaki.com/ns/music#h-moll"></see></summary>
    let ``h-moll`` = Namespaced_IRI.parse _namespace_name "h-moll" |> NamespacedName
    /// <summary>
    /// The subject musical work or its movement has a key, such as C major, d minor, etc.
    /// <see href="http://www.kanzaki.com/ns/music#key"></see></summary>
    let key = Namespaced_IRI.parse _namespace_name "key" |> NamespacedName
    /// <summary>
    /// The subject musical work or its movement has a key. Textual version of #key.
    /// <see href="http://www.kanzaki.com/ns/music#keyName"></see></summary>
    let keyName = Namespaced_IRI.parse _namespace_name "keyName" |> NamespacedName
    /// <summary>
    /// The subject musical work or its movement has instruction mark(s) of tempo and/or expression
    /// <see href="http://www.kanzaki.com/ns/music#marks"></see></summary>
    let marks = Namespaced_IRI.parse _namespace_name "marks" |> NamespacedName
    /// <summary>
    /// The subject musical work or its movement has a time measure such as 3/4, 4/4, 6/8 etc
    /// <see href="http://www.kanzaki.com/ns/music#meter"></see></summary>
    let meter = Namespaced_IRI.parse _namespace_name "meter" |> NamespacedName
    /// <summary>
    /// The subject musical composition has an identifier assigned by a composer (e.g. 'op.131') or other editor (e.g. 'KV.551')
    /// <see href="http://www.kanzaki.com/ns/music#opus"></see></summary>
    let opus = Namespaced_IRI.parse _namespace_name "opus" |> NamespacedName
    /// <summary>
    /// The subject artist (or group, machine, etc) performs a musical work.
    /// <see href="http://www.kanzaki.com/ns/music#performs"></see></summary>
    let performs = Namespaced_IRI.parse _namespace_name "performs" |> NamespacedName
    /// <summary>
    /// The subject musical work was first performed at an concert
    /// <see href="http://www.kanzaki.com/ns/music#premiere"></see></summary>
    let premiere = Namespaced_IRI.parse _namespace_name "premiere" |> NamespacedName
    /// <summary>
    /// The subject musical event presents a performance of a musical work. An experiment to have better model to describe musical work, its representation and an event to present the representation.
    /// <see href="http://www.kanzaki.com/ns/music#presents"></see></summary>
    let presents = Namespaced_IRI.parse _namespace_name "presents" |> NamespacedName
    /// <summary>
    /// The subject musical event presents a musical work as its program
    /// <see href="http://www.kanzaki.com/ns/music#program"></see></summary>
    let program = Namespaced_IRI.parse _namespace_name "program" |> NamespacedName

    /// <summary>
    /// The subject musical event presents a musical work as its program. Literal version of #program.
    /// <see href="http://www.kanzaki.com/ns/music#programLine"></see></summary>
    let programLine =
        Namespaced_IRI.parse _namespace_name "programLine" |> NamespacedName

    /// <summary>
    /// The subject musical work is published as a score or sheet music (still not sure what kind of class is appropriate as the range)
    /// <see href="http://www.kanzaki.com/ns/music#published"></see></summary>
    let published = Namespaced_IRI.parse _namespace_name "published" |> NamespacedName
    /// <summary>
    /// The subject (performance, score, etc) is a representation of the object musical work. An experiment to have better model.
    /// <see href="http://www.kanzaki.com/ns/music#represents"></see></summary>
    let represents = Namespaced_IRI.parse _namespace_name "represents" |> NamespacedName
    /// <summary>
    /// The subject musical work has subsections such as movements. Current model recommends RDF Collection as the object.
    /// <see href="http://www.kanzaki.com/ns/music#sections"></see></summary>
    let sections = Namespaced_IRI.parse _namespace_name "sections" |> NamespacedName
    /// <summary>
    /// The subject performance is performed by this soloist (or the subject musical event has a soloist. See comment of #performer.
    /// <see href="http://www.kanzaki.com/ns/music#soloist"></see></summary>
    let soloist = Namespaced_IRI.parse _namespace_name "soloist" |> NamespacedName
    /// <summary>
    /// The subject musical work has a historical source, such as sketch, autograph score or published score.
    /// <see href="http://www.kanzaki.com/ns/music#source"></see></summary>
    let source = Namespaced_IRI.parse _namespace_name "source" |> NamespacedName
    /// <summary>
    /// The subject musical event is presented at the object venue.
    /// <see href="http://www.kanzaki.com/ns/music#venue"></see></summary>
    let venue = Namespaced_IRI.parse _namespace_name "venue" |> NamespacedName
