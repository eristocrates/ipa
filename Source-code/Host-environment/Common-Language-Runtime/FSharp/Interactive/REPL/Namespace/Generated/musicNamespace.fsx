#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module music =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.kanzaki.com/ns/music#" "music"

    let A_dur = _prefixId.prefix "A-dur"
    /// <summary>
    ///   <para>rdfs:label : Alto^^xsd:string</para>
    ///   <para>rdfs:comment : An Alto singer^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Alto">music:Alto</a>
    /// </summary>
    let Alto = _prefixId.prefix "Alto"
    /// <summary>
    ///   <para>rdfs:label : Artist^^xsd:string</para>
    ///   <para>rdfs:comment : A person or group (or any agent) who creates or performs art works^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Artist">music:Artist</a>
    /// </summary>
    let Artist = _prefixId.prefix "Artist"
    let As_dur = _prefixId.prefix "As-dur"
    let B_dur = _prefixId.prefix "B-dur"
    /// <summary>
    ///   <para>rdfs:label : Ballet (Work)^^xsd:string</para>
    ///   <para>rdfs:comment : A musical work for a dance form featuring a staged presentation of group or solo dancing. Note 'Ballet_Event' in this vocabulary describes the performance of a ballet.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Ballet">music:Ballet</a>
    /// </summary>
    let Ballet = _prefixId.prefix "Ballet"
    /// <summary>
    ///   <para>rdfs:label : Ballet Company^^xsd:string</para>
    ///   <para>rdfs:comment : A musical group that performs ballet works.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#BalletCompany">music:BalletCompany</a>
    /// </summary>
    let BalletCompany = _prefixId.prefix "BalletCompany"
    /// <summary>
    ///   <para>rdfs:label : Ballet Event^^xsd:string</para>
    ///   <para>rdfs:comment : An event of ballet performance
    ///   ^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Ballet_Event">music:Ballet_Event</a>
    /// </summary>
    let Ballet_Event = _prefixId.prefix "Ballet_Event"
    let Ballet_Performance = _prefixId.prefix "Ballet_Performance"
    /// <summary>
    ///   <para>rdfs:label : Baritone^^xsd:string</para>
    ///   <para>rdfs:comment : A Baritone singer^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Baritone">music:Baritone</a>
    /// </summary>
    let Baritone = _prefixId.prefix "Baritone"
    /// <summary>
    ///   <para>rdfs:label : Bass^^xsd:string</para>
    ///   <para>rdfs:comment : A Bass singer^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Bass">music:Bass</a>
    /// </summary>
    let Bass = _prefixId.prefix "Bass"
    /// <summary>
    ///   <para>rdfs:label : Bass Clarinet^^xsd:string</para>
    ///   <para>rdfs:comment : A larger member of the clarinet family, usually in key B-flat.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#BassClarinet">music:BassClarinet</a>
    /// </summary>
    let BassClarinet = _prefixId.prefix "BassClarinet"
    /// <summary>
    ///   <para>rdfs:label : Bass_Clarinettist^^xsd:string</para>
    ///   <para>rdfs:comment : A Bass Clarinet player^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#BassClarinettist">music:BassClarinettist</a>
    /// </summary>
    let BassClarinettist = _prefixId.prefix "BassClarinettist"
    /// <summary>
    ///   <para>rdfs:label : Basset Horn^^xsd:string</para>
    ///   <para>rdfs:comment : A larger member of the clarinet family, typically in lower F, and has darker and less brilliant timbre.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#BassetHorn">music:BassetHorn</a>
    /// </summary>
    let BassetHorn = _prefixId.prefix "BassetHorn"
    /// <summary>
    ///   <para>rdfs:label : Bassoon^^xsd:string</para>
    ///   <para>rdfs:comment : A low-pitched woodwind instrument with a double reed, having a long wooden body attached to a U-shaped lateral tube that leads to the mouthpiece. A Fagotto.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Bassoon">music:Bassoon</a>
    /// </summary>
    let Bassoon = _prefixId.prefix "Bassoon"
    /// <summary>
    ///   <para>rdfs:label : Bassoonist^^xsd:string</para>
    ///   <para>rdfs:comment : A Fagotto player^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Bassoonist">music:Bassoonist</a>
    /// </summary>
    let Bassoonist = _prefixId.prefix "Bassoonist"
    /// <summary>
    ///   <para>rdfs:label : Brass Instrument^^xsd:string</para>
    ///   <para>rdfs:comment : A wind musical instrument, that consists of a brass tube  blown by means of a cup-shaped or funnel-shaped mouthpiece.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Brass_Instrument">music:Brass_Instrument</a>
    /// </summary>
    let Brass_Instrument = _prefixId.prefix "Brass_Instrument"
    let C_dur = _prefixId.prefix "C-dur"
    /// <summary>
    ///   <para>rdfs:label : Cantata^^xsd:string</para>
    ///   <para>rdfs:comment : A vocal composition accompanied by instruments and generally containing more than one movement.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Cantata">music:Cantata</a>
    /// </summary>
    let Cantata = _prefixId.prefix "Cantata"
    /// <summary>
    ///   <para>rdfs:label : Celesta^^xsd:string</para>
    ///   <para>rdfs:comment : A musical instrument with a keyboard and metal plates struck by hammers that produce bell-like tones.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Celesta">music:Celesta</a>
    /// </summary>
    let Celesta = _prefixId.prefix "Celesta"
    /// <summary>
    ///   <para>rdfs:label : CelestaPlayer^^xsd:string</para>
    ///   <para>rdfs:comment : A Celesta player^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#CelestaPlayer">music:CelestaPlayer</a>
    /// </summary>
    let CelestaPlayer = _prefixId.prefix "CelestaPlayer"
    /// <summary>
    ///   <para>rdfs:label : Cellist^^xsd:string</para>
    ///   <para>rdfs:comment : A Cello player^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Cellist">music:Cellist</a>
    /// </summary>
    let Cellist = _prefixId.prefix "Cellist"
    /// <summary>
    ///   <para>rdfs:label : Cello^^xsd:string</para>
    ///   <para>rdfs:comment : A stringed instrument of the violin family, with bass to tenor tone. Usually played in sitting position.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Cello">music:Cello</a>
    /// </summary>
    let Cello = _prefixId.prefix "Cello"
    let Ces_dur = _prefixId.prefix "Ces-dur"
    /// <summary>
    ///   <para>rdfs:label : Chamber Music^^xsd:string</para>
    ///   <para>rdfs:comment : A genre of music composed for performance by small ensemble^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Chamber_Music">music:Chamber_Music</a>
    /// </summary>
    let Chamber_Music = _prefixId.prefix "Chamber_Music"
    /// <summary>
    ///   <para>rdfs:label : Choral Music^^xsd:string</para>
    ///   <para>rdfs:comment : A genre of music composed for performance by a chorus or choir^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Choral_Music">music:Choral_Music</a>
    /// </summary>
    let Choral_Music = _prefixId.prefix "Choral_Music"
    /// <summary>
    ///   <para>rdfs:label : Choreographer^^xsd:string</para>
    ///   <para>rdfs:comment : someone who creates new dances, or directs an opera^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Choreographer">music:Choreographer</a>
    /// </summary>
    let Choreographer = _prefixId.prefix "Choreographer"
    /// <summary>
    ///   <para>rdfs:label : Chorus^^xsd:string</para>
    ///   <para>rdfs:comment : A musical group of singers.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Chorus">music:Chorus</a>
    /// </summary>
    let Chorus = _prefixId.prefix "Chorus"
    let Cis_dur = _prefixId.prefix "Cis-dur"
    /// <summary>
    ///   <para>rdfs:label : Clarinet^^xsd:string</para>
    ///   <para>rdfs:comment : A woodwind instrument having a straight cylindrical tube with a flaring bell and a single-reed mouthpiece.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Clarinet">music:Clarinet</a>
    /// </summary>
    let Clarinet = _prefixId.prefix "Clarinet"
    /// <summary>
    ///   <para>rdfs:label : Clarinettist^^xsd:string</para>
    ///   <para>rdfs:comment : A Clarinet player^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Clarinettist">music:Clarinettist</a>
    /// </summary>
    let Clarinettist = _prefixId.prefix "Clarinettist"
    /// <summary>
    ///   <para>rdfs:label : Composer^^xsd:string</para>
    ///   <para>rdfs:comment : A person (or any agent) who composed art works^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Composer">music:Composer</a>
    /// </summary>
    let Composer = _prefixId.prefix "Composer"
    /// <summary>
    ///   <para>rdfs:label : Concert^^xsd:string</para>
    ///   <para>rdfs:comment : An event of musical performance by players or singers not involving theatrical staging^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Concert">music:Concert</a>
    /// </summary>
    let Concert = _prefixId.prefix "Concert"
    /// <summary>
    ///   <para>rdfs:label : Concerto^^xsd:string</para>
    ///   <para>rdfs:comment : A composition for orchestra and a soloist^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Concerto">music:Concerto</a>
    /// </summary>
    let Concerto = _prefixId.prefix "Concerto"
    /// <summary>
    ///   <para>rdfs:label : Conductor^^xsd:string</para>
    ///   <para>rdfs:comment : A Conductor^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Conductor">music:Conductor</a>
    /// </summary>
    let Conductor = _prefixId.prefix "Conductor"
    /// <summary>
    ///   <para>rdfs:label : Contrabass^^xsd:string</para>
    ///   <para>rdfs:comment : The largest member of string insrtument, usually with four or five strings.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Contrabass">music:Contrabass</a>
    /// </summary>
    let Contrabass = _prefixId.prefix "Contrabass"
    /// <summary>
    ///   <para>rdfs:label : Contrabassist^^xsd:string</para>
    ///   <para>rdfs:comment : A Contrabass player^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Contrabassist">music:Contrabassist</a>
    /// </summary>
    let Contrabassist = _prefixId.prefix "Contrabassist"
    /// <summary>
    ///   <para>rdfs:label : Contrafagotto^^xsd:string</para>
    ///   <para>rdfs:comment : A larger mebmer of the basoon family, producing the lowest tone in the woodwind section.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Contrafagotto">music:Contrafagotto</a>
    /// </summary>
    let Contrafagotto = _prefixId.prefix "Contrafagotto"
    /// <summary>
    ///   <para>rdfs:label : ContrafagottoPlayer^^xsd:string</para>
    ///   <para>rdfs:comment : A Contrafagotto player^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#ContrafagottoPlayer">music:ContrafagottoPlayer</a>
    /// </summary>
    let ContrafagottoPlayer = _prefixId.prefix "ContrafagottoPlayer"
    /// <summary>
    ///   <para>rdfs:label : Countertenor^^xsd:string</para>
    ///   <para>rdfs:comment : A Countertenor singer^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Countertenor">music:Countertenor</a>
    /// </summary>
    let Countertenor = _prefixId.prefix "Countertenor"
    let D_dur = _prefixId.prefix "D-dur"
    let Des_dur = _prefixId.prefix "Des-dur"
    /// <summary>
    ///   <para>rdfs:label : Director^^xsd:string</para>
    ///   <para>rdfs:comment : An artist who directs a musical group^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Director">music:Director</a>
    /// </summary>
    let Director = _prefixId.prefix "Director"
    let E_dur = _prefixId.prefix "E-dur"
    /// <summary>
    ///   <para>rdfs:label : English Horn^^xsd:string</para>
    ///   <para>rdfs:comment : A double-reed woodwind instrument, larger member of the oboe family.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#EnglishHorn">music:EnglishHorn</a>
    /// </summary>
    let EnglishHorn = _prefixId.prefix "EnglishHorn"
    /// <summary>
    ///   <para>rdfs:label : English Horn player^^xsd:string</para>
    ///   <para>rdfs:comment : An English Horn player^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#EnglishHornPlayer">music:EnglishHornPlayer</a>
    /// </summary>
    let EnglishHornPlayer = _prefixId.prefix "EnglishHornPlayer"
    /// <summary>
    ///   <para>rdfs:label : Ensemble^^xsd:string</para>
    ///   <para>rdfs:comment : A musical group which perfroms in relatively small size, particularly chamber music^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Ensemble">music:Ensemble</a>
    /// </summary>
    let Ensemble = _prefixId.prefix "Ensemble"
    let Es_dur = _prefixId.prefix "Es-dur"
    let F_dur = _prefixId.prefix "F-dur"
    let Fis_dur = _prefixId.prefix "Fis-dur"
    /// <summary>
    ///   <para>rdfs:label : Flute^^xsd:string</para>
    ///   <para>rdfs:comment : A high-pitched woodwind instrument; a slender tube closed at one end with finger holes on one end and an opening near the closed end across which the breath is blown^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Flute">music:Flute</a>
    /// </summary>
    let Flute = _prefixId.prefix "Flute"
    /// <summary>
    ///   <para>rdfs:label : Flutist^^xsd:string</para>
    ///   <para>rdfs:comment : A Flute player^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Flutist">music:Flutist</a>
    /// </summary>
    let Flutist = _prefixId.prefix "Flutist"
    let G_dur = _prefixId.prefix "G-dur"
    let Ges_dur = _prefixId.prefix "Ges-dur"
    /// <summary>
    ///   <para>rdfs:label : Guitar^^xsd:string</para>
    ///   <para>rdfs:comment : A musical instrument having a large flat-backed sound box, a long fretted neck, and usually six strings, played by strumming or plucking.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Guitar">music:Guitar</a>
    /// </summary>
    let Guitar = _prefixId.prefix "Guitar"
    /// <summary>
    ///   <para>rdfs:label : Guitarist^^xsd:string</para>
    ///   <para>rdfs:comment : A Guitar player^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Guitarist">music:Guitarist</a>
    /// </summary>
    let Guitarist = _prefixId.prefix "Guitarist"
    let H_dur = _prefixId.prefix "H-dur"
    /// <summary>
    ///   <para>rdfs:label : Harp^^xsd:string</para>
    ///   <para>rdfs:comment : An instrument with usually 46 or 47 strings that are played by plucking with the fingers.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Harp">music:Harp</a>
    /// </summary>
    let Harp = _prefixId.prefix "Harp"
    /// <summary>
    ///   <para>rdfs:label : Harpist^^xsd:string</para>
    ///   <para>rdfs:comment : A Harp player^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Harpist">music:Harpist</a>
    /// </summary>
    let Harpist = _prefixId.prefix "Harpist"
    /// <summary>
    ///   <para>rdfs:label : Harpsichord^^xsd:string</para>
    ///   <para>rdfs:comment : A keyboard instrument whose strings are plucked by means of quills or plectrums. Cembalo.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Harpsichord">music:Harpsichord</a>
    /// </summary>
    let Harpsichord = _prefixId.prefix "Harpsichord"
    /// <summary>
    ///   <para>rdfs:label : Horn^^xsd:string</para>
    ///   <para>rdfs:comment : A brass instrument with a long narrow tube that is coiled in a circle before ending in a flaring bell, usually being equipped with valves. A French Horn.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Horn">music:Horn</a>
    /// </summary>
    let Horn = _prefixId.prefix "Horn"
    /// <summary>
    ///   <para>rdfs:label : Hornist^^xsd:string</para>
    ///   <para>rdfs:comment : A Horn player^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Hornist">music:Hornist</a>
    /// </summary>
    let Hornist = _prefixId.prefix "Hornist"
    /// <summary>
    ///   <para>rdfs:label : Key^^xsd:string</para>
    ///   <para>rdfs:comment : A key of a musical work (e.g. C-dur, b-moll)^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Key">music:Key</a>
    /// </summary>
    let Key = _prefixId.prefix "Key"
    /// <summary>
    ///   <para>rdfs:label : Keyboard Instrument^^xsd:string</para>
    ///   <para>rdfs:comment : A musical instrument that has a set of keys that consist of scale.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Keyboard_Instrument">music:Keyboard_Instrument</a>
    /// </summary>
    let Keyboard_Instrument = _prefixId.prefix "Keyboard_Instrument"
    /// <summary>
    ///   <para>rdfs:label : Mandolin^^xsd:string</para>
    ///   <para>rdfs:comment : A pear-shaped small stringed instrument descended from the lute, played with a pick.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Mandolin">music:Mandolin</a>
    /// </summary>
    let Mandolin = _prefixId.prefix "Mandolin"
    /// <summary>
    ///   <para>rdfs:label : Mezzo Soprano^^xsd:string</para>
    ///   <para>rdfs:comment : A Mezzo Soprano singer^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#MezzoSoprano">music:MezzoSoprano</a>
    /// </summary>
    let MezzoSoprano = _prefixId.prefix "MezzoSoprano"
    /// <summary>
    ///   <para>rdfs:label : Movement^^xsd:string</para>
    ///   <para>rdfs:comment : A subsection of a musical work. Typically a movement of a symphony, but also a piece of suit, etc.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Movement">music:Movement</a>
    /// </summary>
    let Movement = _prefixId.prefix "Movement"
    /// <summary>
    ///   <para>rdfs:label : Music Director^^xsd:string</para>
    ///   <para>rdfs:comment : The person who leads a musical group^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#MusicDirector">music:MusicDirector</a>
    /// </summary>
    let MusicDirector = _prefixId.prefix "MusicDirector"
    /// <summary>
    ///   <para>rdfs:label : Musical Group^^xsd:string</para>
    ///   <para>rdfs:comment : A group that performs art works^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#MusicalGroup">music:MusicalGroup</a>
    /// </summary>
    let MusicalGroup = _prefixId.prefix "MusicalGroup"
    /// <summary>
    ///   <para>rdfs:label : Musical Event^^xsd:string</para>
    ///   <para>rdfs:comment : An event of musical performance by players or singers, including theatrical staging. Typically the event has date and location. Note this is different from Performance, which is a 'representation' of a musical work realized at a musical event or recording, etc.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Musical_Event">music:Musical_Event</a>
    /// </summary>
    let Musical_Event = _prefixId.prefix "Musical_Event"
    /// <summary>
    ///   <para>rdfs:label : Musical Instrument^^xsd:string</para>
    ///   <para>rdfs:comment : An instrument to play music^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Musical_Instrument">music:Musical_Instrument</a>
    /// </summary>
    let Musical_Instrument = _prefixId.prefix "Musical_Instrument"
    /// <summary>
    ///   <para>rdfs:label : Musical Representation^^xsd:string</para>
    ///   <para>rdfs:comment : Representation of a musical work, such as a score, sheet music, perfornamce, recoding, etc.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Musical_Representation">music:Musical_Representation</a>
    /// </summary>
    let Musical_Representation = _prefixId.prefix "Musical_Representation"
    /// <summary>
    ///   <para>rdfs:label : Musical Work^^xsd:string</para>
    ///   <para>rdfs:comment : A musical work in any form, e.g. a composition, its movement, phrase, theme etc.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Musical_Work">music:Musical_Work</a>
    /// </summary>
    let Musical_Work = _prefixId.prefix "Musical_Work"
    /// <summary>
    ///   <para>rdfs:label : Musician^^xsd:string</para>
    ///   <para>rdfs:comment : An artist who performs, composes or conducts music^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Musician">music:Musician</a>
    /// </summary>
    let Musician = _prefixId.prefix "Musician"
    /// <summary>
    ///   <para>rdfs:label : Oboe^^xsd:string</para>
    ///   <para>rdfs:comment : A woodwind instrument with a conical bore and a double-reed mouthpiece.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Oboe">music:Oboe</a>
    /// </summary>
    let Oboe = _prefixId.prefix "Oboe"
    /// <summary>
    ///   <para>rdfs:label : Oboist^^xsd:string</para>
    ///   <para>rdfs:comment : An Oboe player^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Oboist">music:Oboist</a>
    /// </summary>
    let Oboist = _prefixId.prefix "Oboist"
    /// <summary>
    ///   <para>rdfs:label : Oeuvre^^xsd:string</para>
    ///   <para>rdfs:comment : A (complete) musical work by a composer.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Oeuvre">music:Oeuvre</a>
    /// </summary>
    let Oeuvre = _prefixId.prefix "Oeuvre"
    /// <summary>
    ///   <para>rdfs:label : Opera (Work)^^xsd:string</para>
    ///   <para>rdfs:comment : A musical work with drama, song, chorus and orchestral music. Note 'Opera_Event' in this vocabulary describes the performance of an opera.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Opera">music:Opera</a>
    /// </summary>
    let Opera = _prefixId.prefix "Opera"
    /// <summary>
    ///   <para>rdfs:label : Opera Company^^xsd:string</para>
    ///   <para>rdfs:comment : A musical group that performs opera works.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#OperaCompany">music:OperaCompany</a>
    /// </summary>
    let OperaCompany = _prefixId.prefix "OperaCompany"
    /// <summary>
    ///   <para>rdfs:label : Opera Event^^xsd:string</para>
    ///   <para>rdfs:comment : An event of opera performance (not an opera as a musical work, which is defined here as 'Opera')^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Opera_Event">music:Opera_Event</a>
    /// </summary>
    let Opera_Event = _prefixId.prefix "Opera_Event"
    let Opera_Performance = _prefixId.prefix "Opera_Performance"
    /// <summary>
    ///   <para>rdfs:label : Oratorio^^xsd:string</para>
    ///   <para>rdfs:comment : A large musical composition for orchestra, vocal soloists and chorus^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Oratorio">music:Oratorio</a>
    /// </summary>
    let Oratorio = _prefixId.prefix "Oratorio"
    /// <summary>
    ///   <para>rdfs:label : Orchestra^^xsd:string</para>
    ///   <para>rdfs:comment : A musical group which perfroms large scale symphonic works^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Orchestra">music:Orchestra</a>
    /// </summary>
    let Orchestra = _prefixId.prefix "Orchestra"
    /// <summary>
    ///   <para>rdfs:label : Orchestral Work^^xsd:string</para>
    ///   <para>rdfs:comment : A composition for orchestra (and a soloist or soloists, optionally with chorus)^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Orchestral_Work">music:Orchestral_Work</a>
    /// </summary>
    let Orchestral_Work = _prefixId.prefix "Orchestral_Work"
    /// <summary>
    ///   <para>rdfs:label : Overture^^xsd:string</para>
    ///   <para>rdfs:comment : An orchestral music composed for the opening of an opera or oratorio, often played as an independend work in concerts^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Overture">music:Overture</a>
    /// </summary>
    let Overture = _prefixId.prefix "Overture"
    /// <summary>
    ///   <para>rdfs:label : Part^^xsd:string</para>
    ///   <para>rdfs:comment : A music for a particular instrument or voice taken from a full score (Note: in this ontology, Part is not a division of an orchestra).^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Part">music:Part</a>
    /// </summary>
    let Part = _prefixId.prefix "Part"
    /// <summary>
    ///   <para>rdfs:label : Percussion^^xsd:string</para>
    ///   <para>rdfs:comment : A musical instrument that produces sound by striking the body.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Percussion">music:Percussion</a>
    /// </summary>
    let Percussion = _prefixId.prefix "Percussion"
    /// <summary>
    ///   <para>rdfs:label : Percussionist^^xsd:string</para>
    ///   <para>rdfs:comment : A Percussion player^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Percussionist">music:Percussionist</a>
    /// </summary>
    let Percussionist = _prefixId.prefix "Percussionist"
    /// <summary>
    ///   <para>rdfs:label : Peroformance^^xsd:string</para>
    ///   <para>rdfs:comment : Representation of a musical work in the form of performace, e.g. playing instruments, singing etc. Note a concert is a Musical_Event where a Performance is presented.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Performance">music:Performance</a>
    /// </summary>
    let Performance = _prefixId.prefix "Performance"
    /// <summary>
    ///   <para>rdfs:label : Pianist^^xsd:string</para>
    ///   <para>rdfs:comment : A Piano player^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Pianist">music:Pianist</a>
    /// </summary>
    let Pianist = _prefixId.prefix "Pianist"
    /// <summary>
    ///   <para>rdfs:label : Pian^^xsd:string</para>
    ///   <para>rdfs:comment : A musical instrument with a manual keyboard actuating hammers that strike wire strings. A pianoforte.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Piano">music:Piano</a>
    /// </summary>
    let Piano = _prefixId.prefix "Piano"
    /// <summary>
    ///   <para>rdfs:label : Piccolo^^xsd:string</para>
    ///   <para>rdfs:comment : A piccolo flute, smaller member of the flute family.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Piccolo">music:Piccolo</a>
    /// </summary>
    let Piccolo = _prefixId.prefix "Piccolo"
    /// <summary>
    ///   <para>rdfs:label : Piccolo player^^xsd:string</para>
    ///   <para>rdfs:comment : A Piccolo flute player^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#PiccoloPlayer">music:PiccoloPlayer</a>
    /// </summary>
    let PiccoloPlayer = _prefixId.prefix "PiccoloPlayer"
    /// <summary>
    ///   <para>rdfs:label : Player^^xsd:string</para>
    ///   <para>rdfs:comment : An artist who performs a musical instrument^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Player">music:Player</a>
    /// </summary>
    let Player = _prefixId.prefix "Player"
    /// <summary>
    ///   <para>rdfs:label : Recital^^xsd:string</para>
    ///   <para>rdfs:comment : An event of musical performance especially by soloists^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Recital">music:Recital</a>
    /// </summary>
    let Recital = _prefixId.prefix "Recital"
    /// <summary>
    ///   <para>rdfs:label : Religious Music^^xsd:string</para>
    ///   <para>rdfs:comment : A genre of music composed for performance as part of religious ceremonies^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Religious_Music">music:Religious_Music</a>
    /// </summary>
    let Religious_Music = _prefixId.prefix "Religious_Music"
    /// <summary>
    ///   <para>rdfs:label : Saxophone^^xsd:string</para>
    ///   <para>rdfs:comment : A woodwind instrument with a single-reed mouthpiece and a (usually curved) conical metal tube, including soprano, alto, tenor, and baritone sizes.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Saxophone">music:Saxophone</a>
    /// </summary>
    let Saxophone = _prefixId.prefix "Saxophone"
    /// <summary>
    ///   <para>rdfs:label : Score^^xsd:string</para>
    ///   <para>rdfs:comment : A full score or piano-vocal score of a work, either published or manuscript.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Score">music:Score</a>
    /// </summary>
    let Score = _prefixId.prefix "Score"
    /// <summary>
    ///   <para>rdfs:label : Singer^^xsd:string</para>
    ///   <para>rdfs:comment : An artist who sings a song^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Singer">music:Singer</a>
    /// </summary>
    let Singer = _prefixId.prefix "Singer"
    /// <summary>
    ///   <para>rdfs:label : Sketch^^xsd:string</para>
    ///   <para>rdfs:comment : A sketch, or a brief prelimary composition of a work.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Sketch">music:Sketch</a>
    /// </summary>
    let Sketch = _prefixId.prefix "Sketch"
    /// <summary>
    ///   <para>rdfs:label : Soprano^^xsd:string</para>
    ///   <para>rdfs:comment : A Soprano singer^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Soprano">music:Soprano</a>
    /// </summary>
    let Soprano = _prefixId.prefix "Soprano"
    /// <summary>
    ///   <para>rdfs:label : Soprano Clarinet^^xsd:string</para>
    ///   <para>rdfs:comment : A smaller member of the clarinet family, commonly in key E-flat.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#SopranoClarinet">music:SopranoClarinet</a>
    /// </summary>
    let SopranoClarinet = _prefixId.prefix "SopranoClarinet"
    /// <summary>
    ///   <para>rdfs:label : Qtring Quartet^^xsd:string</para>
    ///   <para>rdfs:comment : A musical group of four string players. Note 'String_Quartette' is SQ as musical work in this vocabulary.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#StringQuartetEnsemble">music:StringQuartetEnsemble</a>
    /// </summary>
    let StringQuartetEnsemble = _prefixId.prefix "StringQuartetEnsemble"
    /// <summary>
    ///   <para>rdfs:label : String Instrument^^xsd:string</para>
    ///   <para>rdfs:comment : A stringed musical instrument, in which sound is produced by plucking, striking, or bowing taut strings.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#String_Instrument">music:String_Instrument</a>
    /// </summary>
    let String_Instrument = _prefixId.prefix "String_Instrument"
    /// <summary>
    ///   <para>rdfs:label : String Quartet^^xsd:string</para>
    ///   <para>rdfs:comment : A music composed for instrumental quartet with 2 violins and a viola and a cello. Note 'StringQuartetEnsemble' is SQ ensemble in this vocabulary.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#String_Quartet">music:String_Quartet</a>
    /// </summary>
    let String_Quartet = _prefixId.prefix "String_Quartet"
    let String_Quartette = _prefixId.prefix "String_Quartette"
    /// <summary>
    ///   <para>rdfs:label : Suite^^xsd:string</para>
    ///   <para>rdfs:comment : A musical composition of several movements only loosely connected^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Suite">music:Suite</a>
    /// </summary>
    let Suite = _prefixId.prefix "Suite"
    /// <summary>
    ///   <para>rdfs:label : Symphonic Poem^^xsd:string</para>
    ///   <para>rdfs:comment : An orchestral composition based on a thematic subject^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Symphonic_Poem">music:Symphonic_Poem</a>
    /// </summary>
    let Symphonic_Poem = _prefixId.prefix "Symphonic_Poem"
    /// <summary>
    ///   <para>rdfs:label : Symphony^^xsd:string</para>
    ///   <para>rdfs:comment : A large and complex work for symphony orchestra^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Symphony">music:Symphony</a>
    /// </summary>
    let Symphony = _prefixId.prefix "Symphony"
    /// <summary>
    ///   <para>rdfs:label : Tenor^^xsd:string</para>
    ///   <para>rdfs:comment : A Tenor singer^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Tenor">music:Tenor</a>
    /// </summary>
    let Tenor = _prefixId.prefix "Tenor"
    /// <summary>
    ///   <para>rdfs:label : Text^^xsd:string</para>
    ///   <para>rdfs:comment : Text of a musical work (e.g. lyric or verse)^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Text">music:Text</a>
    /// </summary>
    let Text = _prefixId.prefix "Text"
    /// <summary>
    ///   <para>rdfs:label : Timpani^^xsd:string</para>
    ///   <para>rdfs:comment : A set of large copper or brass hemispherical drums with a parchment head that can be tuned by adjusting the tension.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Timpani">music:Timpani</a>
    /// </summary>
    let Timpani = _prefixId.prefix "Timpani"
    /// <summary>
    ///   <para>rdfs:label : Timpanist^^xsd:string</para>
    ///   <para>rdfs:comment : A Timpani player^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Timpanist">music:Timpanist</a>
    /// </summary>
    let Timpanist = _prefixId.prefix "Timpanist"
    /// <summary>
    ///   <para>rdfs:label : Trombone^^xsd:string</para>
    ///   <para>rdfs:comment : A brass instrument consisting of a long cylindrical tube, and having a movable U-shaped slide for producing different pitches.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Trombone">music:Trombone</a>
    /// </summary>
    let Trombone = _prefixId.prefix "Trombone"
    /// <summary>
    ///   <para>rdfs:label : Trombonist^^xsd:string</para>
    ///   <para>rdfs:comment : A Trombone player^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Trombonist">music:Trombonist</a>
    /// </summary>
    let Trombonist = _prefixId.prefix "Trombonist"
    /// <summary>
    ///   <para>rdfs:label : Trumpet^^xsd:string</para>
    ///   <para>rdfs:comment : A A soprano brass instrument consisting of a long metal tube looped once and ending in a flared bell, usually being equipped with valves or pistons.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Trumpet">music:Trumpet</a>
    /// </summary>
    let Trumpet = _prefixId.prefix "Trumpet"
    /// <summary>
    ///   <para>rdfs:label : Trumpeter^^xsd:string</para>
    ///   <para>rdfs:comment : A Trumpet player^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Trumpeter">music:Trumpeter</a>
    /// </summary>
    let Trumpeter = _prefixId.prefix "Trumpeter"
    /// <summary>
    ///   <para>rdfs:label : Tuba^^xsd:string</para>
    ///   <para>rdfs:comment : A large, valved, brass instrument with a bass pitch.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Tuba">music:Tuba</a>
    /// </summary>
    let Tuba = _prefixId.prefix "Tuba"
    /// <summary>
    ///   <para>rdfs:label : TubaPlayer^^xsd:string</para>
    ///   <para>rdfs:comment : A Tuba player^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#TubaPlayer">music:TubaPlayer</a>
    /// </summary>
    let TubaPlayer = _prefixId.prefix "TubaPlayer"
    /// <summary>
    ///   <para>rdfs:label : Venue^^xsd:string</para>
    ///   <para>rdfs:comment : A venue for musical performance, e.g. concert hall, opera house, recital hall, etc.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Venue">music:Venue</a>
    /// </summary>
    let Venue = _prefixId.prefix "Venue"
    /// <summary>
    ///   <para>rdfs:label : Viola^^xsd:string</para>
    ///   <para>rdfs:comment : A stringed instrument of the violin family, slightly larger than a violin, tuned a fifth lower, and having a deeper, more sonorous tone.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Viola">music:Viola</a>
    /// </summary>
    let Viola = _prefixId.prefix "Viola"
    /// <summary>
    ///   <para>rdfs:label : Violin^^xsd:string</para>
    ///   <para>rdfs:comment : A musical instrument played with a bow, having four strings. Usually plays the highest part of the string section.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Violin">music:Violin</a>
    /// </summary>
    let Violin = _prefixId.prefix "Violin"
    /// <summary>
    ///   <para>rdfs:label : Violinist^^xsd:string</para>
    ///   <para>rdfs:comment : A Violn player^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Violinist">music:Violinist</a>
    /// </summary>
    let Violinist = _prefixId.prefix "Violinist"
    /// <summary>
    ///   <para>rdfs:label : Violist^^xsd:string</para>
    ///   <para>rdfs:comment : A Viola player^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Violist">music:Violist</a>
    /// </summary>
    let Violist = _prefixId.prefix "Violist"
    /// <summary>
    ///   <para>rdfs:label : Woodwind Instrument^^xsd:string</para>
    ///   <para>rdfs:comment : A wind musical instrument, in which sound is produced by the vibration of reeds in the mouthpiece, or by the passing of air across the mouthpiece.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Woodwind_Instrument">music:Woodwind_Instrument</a>
    /// </summary>
    let Woodwind_Instrument = _prefixId.prefix "Woodwind_Instrument"
    /// <summary>
    ///   <para>rdfs:label : Written Representation^^xsd:string</para>
    ///   <para>rdfs:comment : Representation of a musical work in the form of a written expression, e.g. score, parts, autograph, printed music, sketch, etc.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#Written_Representation">music:Written_Representation</a>
    /// </summary>
    let Written_Representation = _prefixId.prefix "Written_Representation"
    let a_moll = _prefixId.prefix "a-moll"
    let ais_moll = _prefixId.prefix "ais-moll"
    /// <summary>
    ///   <para>rdfs:label : Artist Description^^xsd:string</para>
    ///   <para>rdfs:comment : A description of the subject artist or agent. Super-property of #plays, #performs.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#artist_description">music:artist_description</a>
    /// </summary>
    let artist_description = _prefixId.prefix "artist_description"
    let as_moll = _prefixId.prefix "as-moll"
    let b_moll = _prefixId.prefix "b-moll"
    let c_moll = _prefixId.prefix "c-moll"
    let cis_moll = _prefixId.prefix "cis-moll"
    /// <summary>
    ///   <para>rdfs:label : Composer^^xsd:string</para>
    ///   <para>rdfs:comment : The subject musical work is composed by a person, a group, a software program etc.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#composer">music:composer</a>
    /// </summary>
    let composer = _prefixId.prefix "composer"
    /// <summary>
    ///   <para>rdfs:label : Composition^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the composition process of the subject. Composition period or completion date, place, revision etc. can be described as properties of the object composition process.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#composition">music:composition</a>
    /// </summary>
    let composition = _prefixId.prefix "composition"
    /// <summary>
    ///   <para>rdfs:label : Conductor^^xsd:string</para>
    ///   <para>rdfs:comment : The subject performance is coducted by the object (or the subject musical event has a conductor). See comment of #performer.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#conductor">music:conductor</a>
    /// </summary>
    let conductor = _prefixId.prefix "conductor"
    /// <summary>
    ///   <para>rdfs:label : Conductor Name^^xsd:string</para>
    ///   <para>rdfs:comment : The subject musical event has a conductor. Literal version of #conductor.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#conductorName">music:conductorName</a>
    /// </summary>
    let conductorName = _prefixId.prefix "conductorName"
    let d_moll = _prefixId.prefix "d-moll"
    /// <summary>
    ///   <para>rdfs:label : Derived From^^xsd:string</para>
    ///   <para>rdfs:comment : The subject is (was) derived from the object, e.g a copy score is derived from the composer manuscript (or, possibly, a CD recording is derived from a performance at a concert).^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#derivedFrom">music:derivedFrom</a>
    /// </summary>
    let derivedFrom = _prefixId.prefix "derivedFrom"
    /// <summary>
    ///   <para>rdfs:label : Description^^xsd:string</para>
    ///   <para>rdfs:comment : A description of the subject musical work. Super-property of some properties in this vocabulary, as well as description of a general descriptive resource such as time-line of composing process.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#description">music:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    let dis_moll = _prefixId.prefix "dis-moll"
    let e_moll = _prefixId.prefix "e-moll"
    let es_moll = _prefixId.prefix "es-moll"
    /// <summary>
    ///   <para>rdfs:label : Event Description^^xsd:string</para>
    ///   <para>rdfs:comment : A description of the subject musical event. Super-property of #program, #presents, #venue.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#event_description">music:event_description</a>
    /// </summary>
    let event_description = _prefixId.prefix "event_description"
    let f_moll = _prefixId.prefix "f-moll"
    let fis_moll = _prefixId.prefix "fis-moll"
    /// <summary>
    ///   <para>rdfs:label : Form^^xsd:string</para>
    ///   <para>rdfs:comment : The subject musical work or its movement has a form, such as sonata, minuet, etc. Would be better defined as ObjectProperty.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#form">music:form</a>
    /// </summary>
    let form = _prefixId.prefix "form"
    let g_moll = _prefixId.prefix "g-moll"
    let gis_moll = _prefixId.prefix "gis-moll"
    let h_moll = _prefixId.prefix "h-moll"
    /// <summary>
    ///   <para>rdfs:label : Key^^xsd:string</para>
    ///   <para>rdfs:comment : The subject musical work or its movement has a key, such as C major, d minor, etc.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#key">music:key</a>
    /// </summary>
    let key = _prefixId.prefix "key"
    /// <summary>
    ///   <para>rdfs:label : Key Name^^xsd:string</para>
    ///   <para>rdfs:comment : The subject musical work or its movement has a key. Textual version of #key.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#keyName">music:keyName</a>
    /// </summary>
    let keyName = _prefixId.prefix "keyName"
    /// <summary>
    ///   <para>rdfs:label : Marks^^xsd:string</para>
    ///   <para>rdfs:comment : The subject musical work or its movement has instruction mark(s) of tempo and/or expression^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#marks">music:marks</a>
    /// </summary>
    let marks = _prefixId.prefix "marks"
    /// <summary>
    ///   <para>rdfs:label : Meter^^xsd:string</para>
    ///   <para>rdfs:comment : The subject musical work or its movement has a time measure such as 3/4, 4/4, 6/8 etc^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#meter">music:meter</a>
    /// </summary>
    let meter = _prefixId.prefix "meter"
    /// <summary>
    ///   <para>rdfs:label : Opus^^xsd:string</para>
    ///   <para>rdfs:comment : The subject musical composition has an identifier assigned by a composer (e.g. 'op.131') or other editor (e.g. 'KV.551')^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#opus">music:opus</a>
    /// </summary>
    let opus = _prefixId.prefix "opus"
    /// <summary>
    ///   <para>rdfs:label : Performer^^xsd:string</para>
    ///   <para>rdfs:comment : The subject has a performer (an artist, a group, a machine etc.). The preferred domain of this property is #Performance, so as to model that "a concert presents a performance (of a musical work) that is realized by this performer". However, in natural language, we often say that "a concert has performers who play these musical works", i.e. the domain of 'performer' is #Musical_Event in this case, and it would be more intuitive model. Hence, the domain is leave unrestricted here for a moment. ^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#performer">music:performer</a>
    /// </summary>
    let performer = _prefixId.prefix "performer"
    /// <summary>
    ///   <para>rdfs:label : PerformerName^^xsd:string</para>
    ///   <para>rdfs:comment : The subject musical event has a performer. Literal version of #performer.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#performerName">music:performerName</a>
    /// </summary>
    let performerName = _prefixId.prefix "performerName"
    /// <summary>
    ///   <para>rdfs:label : Performs^^xsd:string</para>
    ///   <para>rdfs:comment : The subject artist (or group, machine, etc) performs a musical work.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#performs">music:performs</a>
    /// </summary>
    let performs = _prefixId.prefix "performs"
    /// <summary>
    ///   <para>rdfs:label : Plays^^xsd:string</para>
    ///   <para>rdfs:comment : The subject artist (or group, machine, etc) plays an musical instrument. If :me :plays :Violin, then :me a :Violininst.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#plays">music:plays</a>
    /// </summary>
    let plays = _prefixId.prefix "plays"
    /// <summary>
    ///   <para>rdfs:label : Premiere^^xsd:string</para>
    ///   <para>rdfs:comment : The subject musical work was first performed at an concert^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#premiere">music:premiere</a>
    /// </summary>
    let premiere = _prefixId.prefix "premiere"
    /// <summary>
    ///   <para>rdfs:label : Presents^^xsd:string</para>
    ///   <para>rdfs:comment : The subject musical event presents a performance of a musical work. An experiment to have better model to describe musical work, its representation and an event to present the representation.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#presents">music:presents</a>
    /// </summary>
    let presents = _prefixId.prefix "presents"
    /// <summary>
    ///   <para>rdfs:label : Program^^xsd:string</para>
    ///   <para>rdfs:comment : The subject musical event presents a musical work as its program^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#program">music:program</a>
    /// </summary>
    let program = _prefixId.prefix "program"
    /// <summary>
    ///   <para>rdfs:label : Program Line^^xsd:string</para>
    ///   <para>rdfs:comment : The subject musical event presents a musical work as its program. Literal version of #program.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#programLine">music:programLine</a>
    /// </summary>
    let programLine = _prefixId.prefix "programLine"
    /// <summary>
    ///   <para>rdfs:label : published^^xsd:string</para>
    ///   <para>rdfs:comment : The subject musical work is published as a score or sheet music (still not sure what kind of class is appropriate as the range)^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#published">music:published</a>
    /// </summary>
    let published = _prefixId.prefix "published"
    /// <summary>
    ///   <para>rdfs:label : Represents^^xsd:string</para>
    ///   <para>rdfs:comment : The subject (performance, score, etc) is a representation of the object musical work. An experiment to have better model.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#represents">music:represents</a>
    /// </summary>
    let represents = _prefixId.prefix "represents"
    /// <summary>
    ///   <para>rdfs:label : Sections^^xsd:string</para>
    ///   <para>rdfs:comment : The subject musical work has subsections such as movements. Current model recommends RDF Collection as the object.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#sections">music:sections</a>
    /// </summary>
    let sections = _prefixId.prefix "sections"
    /// <summary>
    ///   <para>rdfs:label : Soloist^^xsd:string</para>
    ///   <para>rdfs:comment : The subject performance is performed by this soloist (or the subject musical event has a soloist. See comment of #performer.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#soloist">music:soloist</a>
    /// </summary>
    let soloist = _prefixId.prefix "soloist"
    /// <summary>
    ///   <para>rdfs:label : Source^^xsd:string</para>
    ///   <para>rdfs:comment : The subject musical work has a historical source, such as sketch, autograph score or published score.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#source">music:source</a>
    /// </summary>
    let source = _prefixId.prefix "source"
    /// <summary>
    ///   <para>rdfs:label : Venue^^xsd:string</para>
    ///   <para>rdfs:comment : The subject musical event is presented at the object venue.^^xsd:string</para>
    ///   <a href="http://www.kanzaki.com/ns/music#venue">music:venue</a>
    /// </summary>
    let venue = _prefixId.prefix "venue"
